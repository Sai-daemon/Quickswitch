# QuickSwitch

Mouse lovers rejoice! This is a KSP 1.12.x mod that adds a "Switch To" button to the right-click menu of nearby vessels and Kerbals on EVA, allowing quick switching between vessels in flight without using any keyboard keys.

Version 1.0 of the mod. Will leave it up on Github for a preliminary release while testing further. 

## Features

- Right-click any part of any vessel, or Kerbal on EVA and press **"Switch To"** to instantly switch to that vessel/Kerbal
- Works at any range (up to physics range which is ~2.5 km, but it can go up to 5km theoretically with a physics mod extender)
- Zero configuration needed
- No toolbar clutter as the button is in the right click menu
- Works with your existing save files
- Should work with any mod that uses @ PART for their parts in their code

## Requirements

- Kerbal Space Program 1.12.x
- Module Manager

## Known Limitations
- Cannot right click on kerbals/other vessels when you are in command of a uncrewed/uncontrolled command pod/vessel. This is stock KSP behaviour and I was not able to override it. 
- Due to the difficulty in actually clicking on the kerbal/command pod at a distance, the mod is really only useful for distances less than 50 or so metres away. One workaround is to pin the parts/kerbal's you are swapping between.

 > A solution to each of these limitations is to download the Targetron Adopted (https://forum.kerbalspaceprogram.com/topic/209523-112x-targetron-adopted/), this is a mod that already adds a menu of nearby ojects you can switch to.

## Installation 

1. Download the latest release. If you are downloading the release with the pre-compiled .dll, skip to step 3. 
2. If building from source, compile in your IDE of choice as per the instructions below. 
3. Merge the `GameData` folder from the zip into your KSP `GameData` folder
4. That's it! the Module Manager patch injects the module automatically

## Building from Source

### Windows

```cmd
set KSP_DIR=C:\path\to\Kerbal Space Program
dotnet msbuild /p:Configuration=Release
```

### Linux / macOS

```bash
export KSP_DIR="/path/to/Kerbal Space Program"
dotnet msbuild /p:Configuration=Release
```

The build will automatically copy the compiled DLL to `GameData/QuickSwitch/Plugins/` via the `InstallMod` MSBuild target.

### AI-Generated content disclosure

The code in this mod was generated entirely using Deepseek (model: Deepseek-v4-pro), with extensive human guidance, review, testing, and integration. I take full responsability for the code's functionality and license compliance under the MIT license. 

All inquiries into bugs and or changes should be addressed to me (SAI-DAEMON) .

## License

MIT

