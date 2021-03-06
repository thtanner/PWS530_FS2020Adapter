# PWS530_FS2020Adapter
Allows the PropWashSim PWS530 to be used with Flight Simulator 2020 until official support is added in FSXPropWash by PropWash Simulation

## Installation
- [Download](https://github.com/thtanner/PWS530_FS2020Adapter/releases/) the latest PWS530_FS2020Adapter release and extract the into a directory of your choice
- [Download](http://fsuipc.simflight.com/beta/Install_FSUIPC7.zip) and Install FSUIPC7
- [Download](https://www.mobiflight.com/en/download.html) and Install MobiFlight
  1. Run MobiFlight
  2. In the Extras -> Settings menu, at the bottom, check "I would like to receive beta version updates"
  3. Click "Help -> Check for update"
  4. After update, navigate to the install location for MobiFlight on your machine
  5. There should now be a "MSFS2020-module" folder, open that folder
  6. Copy the "mobiflight-event-module" folder to your MSFS community folder
  7. MobiFlight is no longer needed at this stage; you may choose to uninstall it if you wish.
- The [pms-gns530 Mod](https://github.com/pimarc/pms50-gns530) is highly suggeted, but not required, as it grealy improves the GNS530 functionality in Flight Simulator 2020

## Usage
- Run **FSUIPC7**
- Run **PSW530_FS2020Adapter.exe**
- **If you are using FSXPropWash** to control other PWS hardware, *do not Auto Detect your PWS530 using FSXPropWash*. If you have done so and the PWS530 is showing in FSXPropWash, select the PWS530 and press Delete Port, then disconnect/reconnect the PWS530's USB cable
- **Launch Flight Simulator 2020** and enjoy your PWS530 on aircraft equipped with the GNS530
- To pop-out the GNS530 screen from the simulator, press and hold the Right Alt button on your keyboard and Left Click on the GNS530 window with your mouse; the GNS530 window will pop out, then drag it to your PWS530 screen and press ALT + Enter to make it full screen on your PWS530

## Known Limitations
- This is meant to only work with PropWash Simulation's PWS530 and Microsoft Flight Simulator 2020 using MobiFlight's Event Module and FSUIPC7, it will not work for any other usage scenerio

## Versions
- 1.0 - Initial Release
- 1.1 - CDI Button Support Added

## Credits
- Based on one of [FSUIPC Client DLL](http://fsuipc.paulhenty.com/)'s sample projects
- Sample code for RegisterHotKey was found [here](https://social.msdn.microsoft.com/Forums/vstudio/en-US/c1a24688-d844-4adc-9d85-416a7158c6ba/faq-how-do-i-register-a-hotkey-in-vbnet?forum=vbgeneral).
- Huge thanks to [MobiFlight](https://www.mobiflight.com/) for their event module, as this could not work without it
- Thanks to [PropWash Simulation](https://www.propwashsim.com/) for their outstanding flight simulator hardware at a great price
