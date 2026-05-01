# QuickSwitch

A KSP 1.12.x mod that adds a "Switch To" button to the right-click menu of command-capable vessels and Kerbals on EVA, allowing quick switching between vessels in flight.

Version 1.0 of the mod. Will leave it up on Github for a preliminary release while testing further. 

## Features

- Right-click any command pod, probe core, or Kerbal on EVA and press **"Switch To"** to instantly switch to that vessel
- Works at any range (up to physics range which is ~2.3 km, but it can go up to 5km theoretically with a physics mod extender)
- Zero configuration needed
- No toolbar clutter as the button is in the right click menu
- Works with your existing save files

## Requirements

- Kerbal Space Program 1.12.x
- Module Manager

## Known issues
- Cannot right click on kerbals/other vessels when you are in command of a uncrewed/uncontrolled command pod/vessel. This is stock KSP behaviour and I was not able to override it. 
- Due to the difficulty in actually clicking on the kerbal/command pod at a distance, the mod is really only useful for distances less than 50 or so metres away. Again this is a limitation in the game itself, but it still is an issue nonetheless.

## Installation 

1. Download the latest release. If you are downloading the pre-compiled .dll, skip to step 3. 
2. If building from source, compile in your IDE of choice as per the instructions below. 
3. Merge the `GameData` folder from the zip into your KSP `GameData` folder
4. That's it! the Module Manager patch injects the module automatically

## Building from Source

### Windows

```cmd
set KSP_DIR=C:\path\to\Kerbal Space Program
msbuild /p:Configuration=Release
```

### Linux / macOS

```bash
export KSP_DIR="/path/to/Kerbal Space Program"
msbuild /p:Configuration=Release
```

The build will automatically copy the compiled DLL to `GameData/QuickSwitch/Plugins/` via the `InstallMod` MSBuild target.

### AI-Generated content disclosure

The code in this mod was generated entirely using Deepseek (model: Deepseek-v4-pro), with extensive human guidance, review, and integration. I take full responsinbility for the code's functionality and license compliance under the MIT license. 

All inquiries into bugs and or changes should be addressed to me (SAI-DAEMON) .

## License

MIT

