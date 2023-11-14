# Sterling Systems

# 0.3.5
### Changes
- Moved Batteries to their own folder and away from FuelCells.
- Set Sun shield's System Heat loop temperature to 700 K, respecting its high heat tolerance as an armor but staying near to low temp radiator territory.

### Fixes
- Fixed/Revised Upgrade parts. They show up in the tech tree now.
- Updated the balancing of all electrics.
- Updated the balancing of all thermals to hopefully fit Nertea's balance scheme.
- Updated tech progression.


# 0.3.1
### Fixes
- Fixed the System Heat Fission Engines module problem: Ensured that affected engines always hold the requested nuclear resource.
- Updated localization (fixes an issue in the B9PS patch for the fuel cells).


# 0.3.0
### Additions
- Added FusionPellets production to large ICF engine.
- Added Kerbalism configs. (Sun and Shadow shields can hold "Shielding" resource.)
- Added System Heat and Kerbalism System Heat configs for all radiators.
- Added System Heat configs for all current engines.
- Added Sun and Shadow shields.
  - With detailed, fully localized tooltips and upgrades.
  - Shadow shields contribute to System Heat loop volume.

### Changes
- Changes to metal fuel cells:
  - Fully localized tooltips.
  - Added Recharger information to tooltips, including precise System Heat information.
  - Restored some ThermalPower output.
- Changes to wrapper PVs:
  - Fully localized tooltips.
  - Updated upgrades information.
- Added cost of EnrU to engines that hold it.
- Changed SULEU engines to surface attach from their top, not their side.
- Reduced amounts of EnrU held by GCNTRs.
- Updated balancing and tankage on fissile salt and fissile pebbles. Reactors should now hold 10 kerbal years worth of fuel by default and cost a lot more because the fuel is now more expensive.


## 0.2.2
### Additions
- Added SULEU (NERV alternative) engines.

### Changes
- Updated fuel cell configs:
  - Added Beryllium option.
  - Updated stored amounts (B9 tank types) and ratios.
  - Changed ThermalPower output to zero.
- Localization for fuel cell B9 configs (partial) and resources.
- Finished remaining mesh work on batteries/fuel cells for Simple Repaint.

### Fixes
- Fixed mesh problem with 3.75m wrapper solar panels.
- Updated thermal efficiency curve of Delta Electro TBCs to hopefully fix zero efficiency bug when spawned with VesselMover.


## 0.2.1
### Changes
- Renamed wrapper solar panels and wrapper radiators. **This will break craft files**.

### Fixes
- Waterfall detection. `StockWaterfallEffects` is the particular plume pack needed.
- Added missing localization, and B9 switching and System Heat config for wrapper solar panels.
- Added missing System Heat config for 1.875m wrapper radiators.


## 0.2
* Initial release