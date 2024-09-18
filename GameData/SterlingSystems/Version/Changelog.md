# Sterling Systems

# 0.5.0 WIP

### Additions
- Added Chinese localization provided by @Aebestach.
- Added Sterling Utilities:
  - Added Circular Refinery suite.
  - Added recipes concerning reactor fuels.
  - Tagged compatible Omniconverter recipes in WildBlueTools to appear in Sterling Omniconverters.
  
### Changes
- Reorganized mod folders and added to modularity of install. CKAN ready.
- Updated Sterling Tankage: 
  - Added ExoticMinerals tank type.
  - Updated unitsPerVolume on tank types. They were nerfed in error.

### Fixes
- Updated Sterling Electric:
  - Fixed missing } in localization.
  - Fixed missing # in Delta Electro (non-System Heat) power config. Error caused the parts to be invalid and not appear.
- Updated Sterling Thermals:
  - Added DRE detection. DRE renames the ablator module which upsets the super heavy shield.
  - Fixed slight detached geometry in 3.75m white wrapper radiators.


# 0.4.0.2

### Fixes
- Updated Sterling Electric: 
  - Fixed reactors producing DepletedUranium when they should be producing DepletedFuel.
  - Fixed SCM reactor treating DepletedUranium as an input.
- Updated Sterling Tankage: 
  - Added missing 'Jettison Contents' button to the Ore tanks.
  - Fixed tank ratios of D+3He.
  - Updated Simple Construction detection. Should stop the B9PS fatal error (MetalOre resource not defined) caused by that mod.
- Updated Sterling Thermals: 
  - Fixed error assigning added mass and cost to film radiator subtypes. (PR from @arbsoup)
  - Fixed calculation error behind displayed cooling powers of some film radiators. (PR from @arbsoup)
  - Reduced waste heat generation of thermal reactors further. As a fraction it was tiny but as absolute values it was still too much.
  - Removed patch for Kerbalism Shielding resource for super heavy shield. Kerbalism profile problems make it a bad idea to keep this feature.

# 0.4.0

### Additions
- Added low temperature wrapper radiators.
- Added taller Stackable LFR.

### Changes
- Changed System Heat engine configs to require System Heat but not its Fission Engines extra (mostly).
- Changed MSRs and PBRs to contribute to System Heat loops.
- Changed SULEU engines to have built-in Pebble Bed reactors.
- Moved thermal reactors out of Electric category and into Thermal category.
- Moved World Power out of Electric category and into distinct download.
- Moved all localization files into Agency folder.
- Updated Sterling Tankage: Added stack nodes that don't trigger the trusses.
- Updated radiators tech tree positions (stock and CTT).
- Updated radiators overall based on an RO dev's advice:
  - Their temperature curves are no longer linear but parabolic, following the 4th power of the given temperature.
  - High temperature radiators are passive and consume 0 ElectricCharge.
  - High temperature radiators do not sub-cool parts but low temperature radiators do.

### Fixes
- Fixed Super heavy shield tooltip saying "Ablator? enabled" when it's not, in ThP variant.
- Fixed Icarus ICF engine's ISRU not asking for Deuterium under System Heat.
- Fixed a tank having the wrong title and description.
- Fixed excessive System Heat production in SULEU and thermal nozzles.
- Fixed node and ground collider offset problems in World Power parts.
- Fixed weak joint strength on LFRs.

# 0.3.8.1

- Fixed System Heat engine efficiency curves.
- Raised loop temperatures on Delta Electro generators. Evidently it was impossible or excessively hard to adequately cool them.

# 0.3.8

### Additions
- Added Stackable liquid film radiators.
- Added World Power parts:
  - Solar Thermal Panel
  - Solar Thermal Tower
  - Air-breathing radiator suite
- Added equivalent to Rational Resources Nuclear Family, removing external requirement.
- Created custom Waterfall template for BCAM engine.

### Changes
- Adjusted volume calculation for inline heatsinks. The larger ones get a bit more loop volume.
- Buffed thrust on BCAM engine (Undid excessive nerf).
- Raised some engines' loop temperature since the liquid film radiators now exist and can cover their great needs.
- Changed Olympian and Icarus ICF engines to be single-mode.
- Reduced System Heat power of BCAM engine. Its scale factor was 10x what it should be.

### Fixes
- Fixed Icarus engine's System Heat engine module and converter module using the same heat loop.
- Fixed possible missing/incomplete KerbalismSystemHeat patches.
- Fixed tank shroud issue and antimatter issues with Sterling Tankage.
- Fixed turbine generators missing System Heat modules (resulting in -1% efficiency).

# 0.3.7.2

### Changes
- KRUSTY and SCM reactors now produce waste heat (require radiators) and participate in System Heat.
- Reduced turbine generator efficiency to 50% (from 75%). They now also produce waste heat.
- Shuffled nuclear fuel tank options. (This will upset some craft designs.)

# 0.3.7.1

### Changes
- Tankage: Moved gas tank types to general liquid tank.

### Fixes
- Tankage: Added missing boiloff configs for Deuterium and Helium3.
- Tankage: Removed dependency on Rational Resources.

# 0.3.7

### Additions
- Added tank suite with these diameters: 2.5m, 3.75m, 5m.

### Changes
- Reduced added masses in Super Heavy shield.

### Fixes
- Fixed KerbalismSystemHeat problems.
- Ensured that all wrapper radiators' stock module stats still change when used with devices that still use/generate Core Heat when System Heat installed.

# 0.3.6

### Additions
- Added World Power series parts: Giant vertical windmill and XXL solar panel.
- Added tiny solar panels.

### Changes
- Set Sun shield's System Heat loop temperature to 650 K.

### Fixes
- Fixed Thermal nozzle Waterfall plume problem. It needed an Ignition controller.
- Fixed Upgrades not showing in the CTT nodes.
- Updated Waterfall configs to respect engines being duplicated and altered by Rational Resources Nuclear Family.


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