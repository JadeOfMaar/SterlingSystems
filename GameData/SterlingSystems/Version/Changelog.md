# Sterling Systems

## 0.6.1

### Additions
- Updated Sterling Agency:
  - Added upgrade definitions for battery chemistries.
- Updated Sterling Electrics:
  - Added/Revised RealBattery chemistries.
  - Added non-RealBattery chemistries.
- Updated Sterling Kerbalism:
  - Added standardized formula for engine radioactivity and tagged missing engines with it.
- Updated Sterling World Power:
  - Received custom module for dual axis solar panels and radiators.
  - Added/Revised RealBattery chemistries.
  - Added non-RealBattery chemistries.

### Changes
- Updated Sterling Kerbalism:
  - Changed pebble bed reactors' one option to a Configure option.
- Updated Sterling Engines:
  - Balance pass on thermal nozzles. Aerospikes and RCS ask for much less ThermalPower. Bell nozzled engines ask for a little more.
- Updated Sterling Tankage:
  - Lowered Fluorine boiloff temperature.
  - Reduced crash tolerances...

### Fixes
- Updated Sterling Agency:
  - Centralized B9 tank definitions here. This should fix the tankage and fuel cell problems.
- Updated Sterling Engines:
  - Fixed thermal nozzle aerospike engines should require IntakeAir by default (when CRP not installed).
  - Fixed thermal nozzle aerospike engines not ignoring LF for thrust curve. They're not supposed to weaken as LF is used up.
  - Fixed System Heat module ID mismatch in some engines.
  - Fixed wet cost of ICF engines.
  - Removed forgotten patch that caused ThermalPower demand to show up twice in some engines.
- Updated Sterling Kerbalism:
  - Fixed erroneous FOR that shouldn't have been there.
  - Removed WBI resources as the soft dependence thereof, within Kerbalism, is usually not a thing and is a cause for crashes.
- Updated Sterling Tankage:
  - Added missing Carbon Monoxide...
- Updated Sterling Thermals:
  - Added missing entry for cryo radiator boards to be ignored by Simple Repaint.
- Updated Sterling Utilities:
  - Added Scrap Fizzled Pebbles recipe.


## 0.6

### Additions
- Added Sterling Structural
  - Added Super Heavy Shield 2 with variants: Glass, White Armor, Perfect Mirror.
- Updated Sterling Engines Thermal:
  - Added 0.625m rocket and jet for landers.
  - Added dyson bladeless style tilt engines.
  - Added dual-mode aerospike nacelle.
  - Added high-thrust RCS array parts.
- Updated Sterling Thermals:
  - Added giant cryo radiator boards.
- Updated Sterling World Power:
  - Added batteries, fuel cells, heatsinks.
  - Added VABO standardization for grid sizes.
  - Updated models and configs for VABO standard.
  - Added Interstellar MJ chemistry for batteries.

### Changes
- Updated Sterling Electrics:
  - Made solar panels have 1/10 the previous mass and cost. They were quite heavy, and supposedly, were also excessively pricey.
  - Adjusted Delta Electro A series generators: Modest reductions of mass and cost.
  - Updated RealBattery config per RealBattery v3.0.2.

### Fixes
- Updated Sterling Engines:
  - Deactivated Classic Stock Resources (CSR) integration as the detection somehow backfires (forced active) when WBI mods are installed but not set to CSR.
  - Fixed wrong System Heat overlay icon on thermal nozzles.
- Updated Sterling Kerbalism:
  - Fixed resource name error in the supply nodes (Fissile Pebbles).
- Updated Sterling ThermalsExotic:
  - Updated B9 tooltip formatting and fixed interlink mesh location on 90m LFR.
- Updated Sterling ThermalsPower:
  - Fixed wrong/invalid System Heat overlay icon on fission reactors.
- Updated Sterling Utilities:
  - Changed Omniconverter swapping to require RocketParts by default. (Somehow this remained set to WBI Equipment.)
  - Updated dependency from WildBlueTools to WBIResources.
- Updated Sterling UtilitiesConstruction:
  - Increased clearance distance on (deployed) spawn transform on the inline launchpads. New value range is 15m ~ 40m. Also changed orientation so spawned vessels are less likely to clip the parent vessel.


## 0.5.2

### Changes
- Updated Sterling Engines:
  - Revised the formulas and heat curves in the System Heat patches.
- Updated Sterling Tankage:
  - Applied missing/needed values for gas tank types. Aligned with expectations of Procedural Parts gas tank.
- Updated Sterling Thermals:
  - Improved DRE config for super heavy shield 1.
  - Changed Triangle board radiators to show angles in their variant titles.
  - Fixed Triangle board radiator offering 96 MW where it should offer 9.6 MW.
- Updated Sterling ThermalsPower:
  - Changed Pebble Bed Reactors to dump excess on ThermalPower.
- Updated Sterling Utilities:
  - Added EnrU capacity and NFE modules to Fissile Foundries.
- Updated Sterling UtilitiesConstruction:
  - Added missing buff to crash tolerance of pads and runways: 15 --> 150 m/s.
  - Added Omniconverter recipes for Thermal Ironwork (EL MetalOre refining) and Thermal Remelter (EL ScrapMetal recycling).
  - Changed byproduct resources in Omniconverter recipes to gas form.
  - Gave non-default internal names to spawner pads (for the in-flight EL window).
- Updated Sterling World Power:
  - Added heatsink (System Heat volume) upgrade to Gulf Stream TCS.
  - Slowed fan spin animation in Gulf Stream TCS.
  - Made Gulf Stream TCS into resource converters that produce negative heat for System Heat. System Heat Radiator module does not respect resource deprived status, allowing for air-breathing in vacuum.
  
### Fixes
- Updated Sterling Electrics:
  - Fixed Real Battery patch. It now needs to provide the System Heat module for itself.
- Updated Sterling Engines:
  - Fixed antimatter and fusion engines no longer receiving System Heat modules. Erroneously needed RR Nuclear Family to not be installed.
- Updated Sterling Thermals:
  - Added Tweakscale for rollout radiators.
  - Added legacy heat animation to boards and roll-out radiators for non-System Heat players.
  - Added radiator boards to Simple Repaint blacklist.
  - Fixed triangle board option providing 10x the power it should.


## 0.5.1

### Additions
- Updated Sterling Electrics:
  - Added flat height variants to batteries.
- Updated Sterling Thermals:
  - Added Graphene boards.

### Changes
- Updated Sterling Kerbalism:
  - Added RTG module to SubCritial Multiplier.
  - Added RTG module (as BVG) to Betavoltaics. Half-life value set as 200 years but Kerbalism counts that under "perpetual."
- Updated Sterling ThermalsPower:
  - Slightly reduced shutdown temperature of Pebble Bed Reactors.

### Fixes
- Updated Sterling Kerbalism:
  - Added CRP detection to fuel cell patch. This and Addresses invalid resource problems in case of installs of Simplex Kerbalism.
  - Fixes to refinery mode 1. This mode is supposed to used switched SystemHeatConverterKerbalism modules.
  - Fixed Molten Metal Foundries now receiving recipe modules.
- Updated Sterling Tankage:
  - Removed obsolete patch which affected added cost and mass in height selectors.
- Updated Sterling World Power:
  - Changed Gulf Stream radiators and the windmills to use IntakeAir by default and detect CRP to use IntakeAtm.
  - Hopefully fixed heat emissive controller on Gulf Stream radiators.


## 0.5.0

### Additions
- Added Kerbal Health compatibility.
- Added Sterling Kerbalism: Collection of Kerbalism specific things previously released with Rational Resources.
- Updated Sterling Electrics:
  - Added 0.625m Betavoltaics and Real Battery configs for them.
- Updated Sterling Core:
  - Added Alternate Resource Panel icons for nuclear resources.
- Updated Sterling Tankage:
  - Added Tritium configs for hazard tankage.
- Updated Sterling Thermals:
  - Added wrapper heatshields for stock Mk2 and Mk3 adapters.
  - Added preheaters.
  - Added roll-out array radiators.
- Updated Sterling ThermalsPower:
  - Added Tritium configs for molten salt reactors.
- Updated Sterling UtilitiesConstruction:
  - Added inline construction pads to complement the printeries.
- Updated Sterling World Power:
  - Added solar panel type 2 and windmill type 2.
  - Added tune-able wide radiator based on solar panel type 2.

### Changes
- Updated All:
  - Added missing tags to the great majority of parts.
- Updated Sterling Core:
  - All associated part upgrade and localization changes.
  - Adjusted unit costs of Fissile Fuel and Fissile Pebbles.
- Updated Sterling Engines:
  - Added/Fixed missing defaults for nuclear engines' propellants when Rational Resources Nuclear Family not installed.
  - Added tail toggle for "Tiny" CCGC.
  - Removed Nuclear Family implementation.
- Updated Sterling Electrics:
  - Updated CTT locations of fission reactors.
  - Added fuel cell B9 option colors.
  - Added Real Battery compatibility. (Parts become 20x massive when this installed.)
  - Updated costs and tech tree placement according to (and without) Real Battery.
  - Resurfaced batteries, fuel cells and nukes (SCM, KRUSTY).
- Updated Sterling Kerbalism:
  - Added mode select and System Heat involved modules mode for refineries and printeries.
  - Added System Heat involved modules mode for metal fuel cells. Module switching is WIP and weird right now but still playable.
  - Gathered all Kerbalism configs here.
  - Removed Minerals Splitter and ExoticMinerals Splitter recipe. Put those in Rational Resources Kerbalism.
- Updated Sterling Tankage:
  - Added MaterialKits and SpecializedParts.
  - Added options for Beryllium and LqdFluorine. Both are very hazardous so check the black tanks for them.
  - Added System Heat Boiloff compatibility. Instead of asking for ElectricCharge, cryotanks ask for their own loop.
- Updated Sterling Thermals:
  - Made inline heatsinks ThermalPower non-empty by default.
  - Made inline heatsinks lower mass and have 1/25 original ThermalPower capacity.
  - Made inline heatsinks upgrade-able, adding more mass, loop volume and ThermalPower capacity.
  - Rebalanced wrapper radiators. (Still botched, after another inspection.) Cryo radiators are lower mass and capacity. Metal radiators are higher mass and capacity. Graphene radiators mostly gain but somewhat also lose.
  - Retxtured wrapper graphene radiators.
  - ThermalPower gauge on heatsinks now animates if System Heat installed.
  - Updated CTT locations of heat sinks.
  - Updated title convention on wrapper radiators.
- Updated Sterling ThermalsPower:
  - Added nicknames to MSRs and PBRs. 
  - Resurfaced all fission reactors.
  - Increased Fissile Pebbles consumption rate. (It was too efficient.)
  - Minor adjustment (number rounding) to ThermalPower outputs of MSRs and PBRs.
  - Updated CTT locations of fission reactors.
- Updated Sterling Utilities:
  - Resurfaced circular refineries.
- Updated Sterling UtilitiesConstruction:
  - Added heat emissive to the field parts.
  - Added missing ElectricCharge in 25m pad and Construction Field.
  - Blacklisted ElectricCharge from Omnistorage in case of Real Battery installs.
  - Enabled Omnistorage for 25m pad.
  - Resurfaced circular printeries and the field parts.
- Updated World Power:
  - Added toggle for Underground meshes.
  - Resurfaced.
  - Updated windmills to be deployable always-on converters when Planetside Exploration Tech not installed.

### Fixes
- Updated Sterling Electrics:
  - Added missing skinMaxTemp keys to parts and B9 upgrades. Wrapper solar panels had edge cases of (skin) heat tolerance dipping back to 1200K.
- Updated Sterling Engines:
  - Fixed Antimatter propellant ratio in 10m BCAM.
  - Fixed basic CRP config to not run when Classic Stock Resources (CSR) installed.
  - Added parallel CSR config.
- Updated Sterling Kerbalism:
  - Fixed missing detections for System Heat radiators.
  - Fixed big config error with solar panel fixer. Not sure if it helps anything, though.
- Updated Sterling Tankage:
  - Make Ore option always appear.
  - Fixed CRP detection fatal issue.
  - Fixed typo in FFT antimatter containment cost logic.
- Updated Sterling Thermals:
  - Partial fix to super heavy shield losing heat tolerance when Ablator empty (for Deadly Reentry).
- Updated Sterling ThermalsPower:
  - Stopped fission reactors from eating national budgets.
- Updated Sterling Utilities:
  - Fixed EL module injection patch to only affect Molten Metal Foundry.
- Updated Sterling UtilitiesConstruction:
  - Fixed missing `{` which may have crippled the spawners with Sandcastle.
  - Updated WBI Sandcastle module names per Sandcastle 1.3.0 release.
- Updated World Power:
  - Fixed Solar PV panel whole part material changed when selecting concentrator variant.
  - Fixed solar furnace config pointing to solar PV type 2's model, and other issues therein.
  
  
## 0.4.10

### Fixes
- Updated Sterling Electrics:
  - Model path was incorrect for the SubCritical Multiplier and the KRUSTY. They are selectable again.
  - Super batteries no longer have excessive mass and cost applied through their height selector.
- Updated Sterling Engines:
  - Nuclear Family patch will apply to SULEU engines. (It had a bad and obsolete detection for Rational Resources Nuclear Family.)
  - Nuclear Family patch will no longer divide and clone the SULEU engines. 
- Updated Sterling Tankage:
  - Added Kerbalism FFT Antimatter tank module to Antimatter tanks.
- Updated Sterling Thermals:
  - Added SHINY to Super Heavy shield.
  - Added emissive overheat to wrapper heatshields.
  - Added detection for Deadly Reentry on the Super Heavy Shield. Fixes related B9PS error.
  - Reduced Conical Shadow Shield's dry mass and added mass by its size selector.
  - Reduced dry masses of larger fission reactors. The huge mass was realistic...but questionable for long enough.
- Updated Sterling Utilities:
  - Added thermal powered Metals smelting recipe.
  - Added missing length colliders to runway.
  - Omniconverter system will no longer appear when Kerbalism installed. (Rational Resources Kerbalism updated to cover for this.)
- Updated World Power:
  - Added patch to reverse Kerbalism's effects on the solar thermal panels. They do not produce ElectricCharge and so should not be considered by the Planner but also, Kerbalism's solar panel fix module makes them entirely unusable.
  - Added patch to remove the generator function from the tracking solar thermal panel under Kerbalism. The Planner does not recognize it.
  - Reduced boxed part masses to < 1 ton.
  

## 0.4.9

### Additions
- Added Chinese localization provided by @Aebestach.
- Added Sterling Utilities:
  - Added Circular Refinery (Omniconverter only) suite.
  - Added Circular Printery EL drone / Sandcastle printer suite.
  - Added construction site suite: Rocket pads, runway, variable field with Omnistorage.
  - Added recipes concerning reactor fuels.
  - Tagged compatible Omniconverter recipes in WildBlueTools to appear in Sterling Omniconverters.
  
### Changes
- Reorganized mod folders and added to modularity of install. CKAN ready.
- Updated Sterling Tankage: 
  - Added ExoticMinerals tank type.
  - Updated unitsPerVolume on tank types. They were nerfed in error.
- Updated Sterling Thermals:
  - Added emissives for wrapper heatshields and super heavy shield.
  - Removed stock shiny shader and texture from super heavy shield.
  - Restored radiator module for inline heatsinks.

### Fixes
- Updated Sterling Electrics:
  - Fixed missing } in localization.
  - Fixed missing # in Delta Electro (non-System Heat) power config. Error caused the parts to be invalid and not appear.
- Updated Sterling Thermals:
  - Added DRE detection. DRE renames the ablator module which upsets the super heavy shield.
  - Fixed slight detached geometry in 3.75m white wrapper radiators.


## 0.4.0.2

### Fixes
- Updated Sterling Electrics: 
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

## 0.4.0

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

## 0.3.8.1

- Fixed System Heat engine efficiency curves.
- Raised loop temperatures on Delta Electro generators. Evidently it was impossible or excessively hard to adequately cool them.

## 0.3.8

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

## 0.3.7.2

### Changes
- KRUSTY and SCM reactors now produce waste heat (require radiators) and participate in System Heat.
- Reduced turbine generator efficiency to 50% (from 75%). They now also produce waste heat.
- Shuffled nuclear fuel tank options. (This will upset some craft designs.)

## 0.3.7.1

### Changes
- Tankage: Moved gas tank types to general liquid tank.

### Fixes
- Tankage: Added missing boiloff configs for Deuterium and Helium3.
- Tankage: Removed dependency on Rational Resources.

## 0.3.7

### Additions
- Added tank suite with these diameters: 2.5m, 3.75m, 5m.

### Changes
- Reduced added masses in Super Heavy shield.

### Fixes
- Fixed KerbalismSystemHeat problems.
- Ensured that all wrapper radiators' stock module stats still change when used with devices that still use/generate Core Heat when System Heat installed.

## 0.3.6

### Additions
- Added World Power series parts: Giant vertical windmill and XXL solar panel.
- Added tiny solar panels.

### Changes
- Set Sun shield's System Heat loop temperature to 650 K.

### Fixes
- Fixed Thermal nozzle Waterfall plume problem. It needed an Ignition controller.
- Fixed Upgrades not showing in the CTT nodes.
- Updated Waterfall configs to respect engines being duplicated and altered by Rational Resources Nuclear Family.


## 0.3.5

### Changes
- Moved Batteries to their own folder and away from FuelCells.
- Set Sun shield's System Heat loop temperature to 700 K, respecting its high heat tolerance as an armor but staying near to low temp radiator territory.

### Fixes
- Fixed/Revised Upgrade parts. They show up in the tech tree now.
- Updated the balancing of all electrics.
- Updated the balancing of all thermals to hopefully fit Nertea's balance scheme.
- Updated tech progression.


## 0.3.1

### Fixes
- Fixed the System Heat Fission Engines module problem: Ensured that affected engines always hold the requested nuclear resource.
- Updated localization (fixes an issue in the B9PS patch for the fuel cells).


## 0.3.0

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