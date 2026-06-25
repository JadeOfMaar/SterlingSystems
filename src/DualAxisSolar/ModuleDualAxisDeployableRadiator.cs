using UnityEngine;

namespace DualAxisSolar
{
    /// <summary>
    /// Dual-axis sun tracking for deployable radiators: yaw on <see cref="pivotName"/>,
    /// pitch on <see cref="pitchPivotName"/> after deploy animation is frozen.
    /// </summary>
    public class ModuleDualAxisDeployableRadiator : ModuleDeployableRadiator
    {
        [KSPField]
        public string yawPivotName = "rotorYaw";

        [KSPField]
        public string pitchPivotName = "rotorPitch";

        [KSPField]
        public string pitchRotationAxis = "X";

        [KSPField]
        public float pitchMin = 5f;

        [KSPField]
        public float pitchMax = 85f;

        [KSPField]
        public float pitchTrackSpeed = 15f;

        [KSPField]
        public float yawAlignThreshold = 8f;

        [KSPField]
        public bool trackYawBeforePitch = true;

        [KSPField]
        public float pitchAngleSign = -1f;

        private Transform _yawPivot;
        private Transform _pitchPivot;
        private Transform _aimTransform;
        private Quaternion _pitchBaseLocalRotation = Quaternion.identity;
        private float _smoothedPitchAngle;
        private bool _pitchBaseCaptured;
        private bool _deployAnimFrozen;
        private bool _pitchTrackingActive;
        private DeployState _lastDeployState = DeployState.RETRACTED;
        private bool _warnedMissingAxes;
        private Animation _partAnimation;

        public override void OnStart(StartState state)
        {
            if (string.IsNullOrEmpty(pivotName))
                pivotName = yawPivotName;

            base.OnStart(state);
            ResolveAxes();

            if (HighLogic.LoadedSceneIsFlight && trackingBody == null)
                GetTrackingBodyTransforms();
        }

        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);
            ResolveAxes();
        }

        private void ResolveAxes()
        {
            _yawPivot = string.IsNullOrEmpty(yawPivotName) ? null : part.FindModelTransform(yawPivotName);
            _pitchPivot = string.IsNullOrEmpty(pitchPivotName) ? null : part.FindModelTransform(pitchPivotName);
            string aimName = string.IsNullOrEmpty(secondaryTransformName) ? "sunCatcher" : secondaryTransformName;
            _aimTransform = part.FindModelTransform(aimName);

            if ((_yawPivot == null || _pitchPivot == null || _aimTransform == null) && !_warnedMissingAxes)
            {
                _warnedMissingAxes = true;
                Debug.LogWarning(
                    $"[DualAxisSolar] {part.partInfo.name}: missing yaw={yawPivotName}, pitch={pitchPivotName}, or aim={aimName}");
            }
        }

        public override void CalculateTracking()
        {
            if (HighLogic.LoadedSceneIsEditor)
                return;

            if (deployState != DeployState.EXTENDED)
                return;

            base.CalculateTracking();
        }

        public override void LateUpdate()
        {
            base.LateUpdate();

            if (HighLogic.LoadedSceneIsEditor)
                return;

            bool justExtended = deployState == DeployState.EXTENDED && _lastDeployState != DeployState.EXTENDED;
            _lastDeployState = deployState;

            if (justExtended)
                OnFullyDeployed();

            if (deployState != DeployState.EXTENDED)
                return;

            if (_yawPivot == null || _pitchPivot == null)
                return;

            if (trackingBody == null)
                GetTrackingBodyTransforms();

            if (trackingBody == null)
                return;

            if (!_deployAnimFrozen)
                FreezeDeployAnimation();

            Vector3 sunDir = (trackingBody.position - part.transform.position).normalized;

            if (trackYawBeforePitch && !_pitchTrackingActive)
            {
                HoldDeployPitchPose();
                if (GetYawAlignmentError(sunDir) <= yawAlignThreshold)
                    _pitchTrackingActive = true;
                return;
            }

            ApplyPitchTracking(sunDir);
        }

        private void OnFullyDeployed()
        {
            FreezeDeployAnimation();
            CapturePitchBaseRotation();
            _smoothedPitchAngle = 0f;
            _pitchTrackingActive = !trackYawBeforePitch;
        }

        private void CapturePitchBaseRotation()
        {
            if (_pitchPivot == null || _pitchBaseCaptured)
                return;

            _pitchBaseLocalRotation = _pitchPivot.localRotation;
            _pitchBaseCaptured = true;
        }

        private void FreezeDeployAnimation()
        {
            if (_deployAnimFrozen || string.IsNullOrEmpty(animationName))
                return;

            if (_partAnimation == null)
                _partAnimation = part.GetComponentInChildren<Animation>();

            if (_partAnimation == null)
            {
                _deployAnimFrozen = true;
                return;
            }

            AnimationState clip = _partAnimation[animationName];
            if (clip != null)
            {
                clip.normalizedTime = 1f;
                _partAnimation.Sample();
                clip.speed = 0f;
                clip.enabled = false;
            }

            _partAnimation.Stop();
            _deployAnimFrozen = true;
            CapturePitchBaseRotation();
        }

        private void HoldDeployPitchPose()
        {
            if (!_pitchBaseCaptured)
                CapturePitchBaseRotation();

            _smoothedPitchAngle = 0f;
            if (_pitchPivot != null)
                _pitchPivot.localRotation = _pitchBaseLocalRotation;
        }

        private float GetYawAlignmentError(Vector3 sunDirWorld)
        {
            if (_yawPivot == null || _aimTransform == null)
                return 180f;

            Vector3 axis = _yawPivot.up;
            Vector3 sunFlat = Vector3.ProjectOnPlane(sunDirWorld, axis);
            Vector3 aimFlat = Vector3.ProjectOnPlane(_aimTransform.forward, axis);
            if (sunFlat.sqrMagnitude < 1e-8f || aimFlat.sqrMagnitude < 1e-8f)
                return 0f;

            return Vector3.Angle(sunFlat.normalized, aimFlat.normalized);
        }

        private void ApplyPitchTracking(Vector3 sunDir)
        {
            if (!_pitchBaseCaptured)
                CapturePitchBaseRotation();

            float target = ComputeTargetPitchAngle(sunDir);
            float step = Mathf.Max(1f, pitchTrackSpeed) * Time.deltaTime;
            _smoothedPitchAngle = Mathf.MoveTowards(_smoothedPitchAngle, target, step);

            Vector3 axis = GetLocalAxisVector(pitchRotationAxis);
            _pitchPivot.localRotation = _pitchBaseLocalRotation *
                Quaternion.AngleAxis(_smoothedPitchAngle * pitchAngleSign, axis);
        }

        private float ComputeTargetPitchAngle(Vector3 sunDirWorld)
        {
            Vector3 localSun = _yawPivot.InverseTransformDirection(sunDirWorld.normalized);
            float elevation = Mathf.Atan2(
                localSun.y,
                new Vector2(localSun.x, localSun.z).magnitude) * Mathf.Rad2Deg;
            return Mathf.Clamp(elevation, pitchMin, pitchMax);
        }

        private static Vector3 GetLocalAxisVector(string axisName)
        {
            switch (axisName?.Trim().ToUpperInvariant())
            {
                case "X":
                case "+X":
                    return Vector3.right;
                case "-X":
                    return Vector3.left;
                case "Y":
                case "+Y":
                    return Vector3.up;
                case "-Y":
                    return Vector3.down;
                case "Z":
                case "+Z":
                    return Vector3.forward;
                case "-Z":
                    return Vector3.back;
                default:
                    return Vector3.right;
            }
        }
    }
}
