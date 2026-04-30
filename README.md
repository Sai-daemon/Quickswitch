# QuickSwitch

A KSP 1.12.x mod that adds a "Switch To" button to the right-click menu of command-capable vessels and Kerbals on EVA, allowing quick switching between vessels in flight.

Version 1.0 of the mod. Will leave it up on Github for a preliminary release while testing further. 

## Features

- Right-click any command pod, probe core, or Kerbal on EVA and press **"Switch To"** to instantly switch to that vessel
- Works at any range (up to 5000m)
- Zero configuration — install and it just works
- No toolbar clutter — the button lives in the right-click menu
- Works with your existing save files

## Requirements

- Kerbal Space Program 1.12.x
- Module Manager

## Installation

1. Download the latest release
2. Merge the `GameData` folder from the zip into your KSP `GameData` folder
3. That's it — the Module Manager patch injects the module automatically

## Known issues
- Cannot right click on kerbals/other vessels when you are commanding a uncrewed/controlled command pod/vessel. This is stock KSP behaviour and I was not able to override it. 

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

## Project Structure

```
QuickSwitch/
├── src/
│   ├── QuickSwitch.csproj
│   ├── QuickSwitchModule.cs
│   └── Properties/
│       └── AssemblyInfo.cs
└── GameData/
    └── QuickSwitch/
        ├── QuickSwitch.version
        └── Patches/
            └── QuickSwitchMM.cfg
```
## AI-Generated content disclosure

The code in this mode was generated entirely using Deepseek (model: Deepseek-v4-pro), with extensive human guidance, review, and integration. I take full responsinbility for the code's functionality and license compliance under the MIT license. 

All inquiries into bugs and or changes should be addressed to me (SAI-DAEMON) .

## License

MIT

