# PWS530_FS2020Adapter
Allows the PropWashSim PWS530 to be used with Flight Simulator 2020 until official support is added in FSXPropWash by PropWash Simulation

## Installation
- [Download](https://github.com/thtanner/PWS530_FS2020Adapter/releases/) the latest PWS530_FS2020Adapter release and extract the into a directory of your choice
- [Download](http://fsuipc.simflight.com/beta/Install_FSUIPC7.zip) and Install FSUIPC7
- [Download](https://www.mobiflight.com/en/download.html) MobiFlight
  1. Launch MobiFlight
  2. Go to Settings and enable the beta
  3. Go to Help, check for updataes
  4. After the update, go to the MobiFlight folder (where MFConnector.exe is located)
  5. Go inside the MSFS2020-module folder and copy the mobiflight-event-module folder to your Flight Sumulator 2020's Community packages folder
  6. Close MobiFlight as it is no longer needed

## Usage
- Run **FSUIPC7**
- Run **PSW530_FS2020Adapter.exe**
- **If you are using FSXPropWash** to control other PWS hardware, *do not Auto Detect your PWS530 using FSXPropWash*. If you have done so and the PWS530 is showing in FSXPropWash, select the PWS530 and press Delete Port, then disconnect/reconnect the PWS530's USB cable.
- **Launch Flight Simulator 2020** and enjoy your PWS530 on aircraft equipped with the GNS530

## Known Limiations
- This is meant to only work with PropWash Simulation's PWS530 and Microsoft Flight Simulator 2020 using MobiFlight's Event Module and FSUIPC7, it will not work for any other usage scenerio

## Versions
- 1.0 - Initial Release
- 1.1 - CDI Button Support Added

## Credits
- Based on one of [FSUIPC Client DLL](http://fsuipc.paulhenty.com/)'s sample projects
- Sample code for RegisterHotKey was found [here](https://social.msdn.microsoft.com/Forums/vstudio/en-US/c1a24688-d844-4adc-9d85-416a7158c6ba/faq-how-do-i-register-a-hotkey-in-vbnet?forum=vbgeneral).
- Thanks to [PropWash Simulation](https://www.propwashsim.com/) for their outstanding flight simulator hardware at a great price
