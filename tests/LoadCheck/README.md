# LoadCheck

A test plugin for the clean-install test of the pack. It logs one line, `LoadCheck loaded`, when BepInEx loads it. It proves that the pack loads a plugin while no mod is installed. It is not part of the pack zip and is not published.

## Build

The plugin references only the BepInEx core assemblies (`BepInEx.Core.dll`, `BepInEx.Unity.IL2CPP.dll`, `Il2CppInterop.Runtime.dll`). It needs no interop assembly of the game, so it builds before the first start.

By default the build takes the core assemblies from the game folder (`C:\Program Files (x86)\Steam\steamapps\common\The Last Plague\BepInEx\core`). To build against an extracted pack zip, set `BepInExCore`:

```
mise exec -- dotnet build tests/LoadCheck/LoadCheck.csproj -c Release -p:BepInExCore=<extracted pack>\BepInEx\core
```

The output is `tests/LoadCheck/bin/Release/net6.0/LoadCheck.dll`.

## Use

1. Copy `LoadCheck.dll` into `BepInEx\plugins` of the game folder.
2. Start the game.
3. Look for `LoadCheck loaded` in `BepInEx\LogOutput.log`.
4. Delete `LoadCheck.dll` from `BepInEx\plugins` after the check.
