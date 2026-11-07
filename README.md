# BepInEx Pack for The Last Plague: Blight

Most mods for the Steam game [The Last Plague: Blight](https://store.steampowered.com/app/1564600/) need the mod loader [BepInEx](https://github.com/BepInEx/BepInEx). This pack is the official BepInEx 6 build that works with the game, in one zip that you extract into the game folder. Install it once, then install any mod that lists it as a requirement.

- The files are the official BepInEx build `6.0.0-be.793` (IL2CPP, win-x64), not changed in any way.
- BepInEx is made by the BepInEx team. This pack is not made or endorsed by them.
- This repo holds the recipe, not the binaries: the pinned build with its hash, and the scripts that build and check the zip.

**This is unofficial.** BepInEx and the mods that use it are not made or supported by the developer of The Last Plague: Blight. If you find a bug in the game, remove your mods and check that the bug still happens before you report it to the developer.

## Install

Close the game. Download `BepInExPack_TheLastPlagueBlight-6.0.0-be.793.zip` from [Releases](https://github.com/ivmakk-tlpb/tlpb-bepinex-pack/releases) or from [Nexus Mods](https://www.nexusmods.com/thelastplagueblight/mods/9). The two files are the same.

1. Extract the zip into `C:\Program Files (x86)\Steam\steamapps\common\The Last Plague` *(if you installed Steam or the game elsewhere, find the folder in your Steam Library: right-click The Last Plague: Blight > Manage > Browse local files)*.
2. Start the game from Steam. Wait for the main menu, then quit before installing mods.

Example after extraction (other game files omitted):

```text
C:\Program Files (x86)\Steam\steamapps\common\The Last Plague\
├── BepInEx\
├── dotnet\
├── TheLastPlague.exe
├── doorstop_config.ini
└── winhttp.dll
```

## The first start

- The BepInEx console window opens with the game. This is normal. Do not close the console window, because that also closes the game.
- The first start takes longer than normal (about 20 seconds longer on the test PC). BepInEx reads the game and prepares files for mods. Wait for the main menu.
- The first start needs an internet connection. BepInEx downloads a small file (about 1.7 MB) from the BepInEx site. If the site does not open where you live, see [The Unity libraries file](#the-unity-libraries-file-optional).

It works when the first line of the console window says `BepInEx 6.0.0-be.793 - TheLastPlague`, and the `BepInEx` folder holds new `config` and `interop` folders. Mods go into `BepInEx\plugins`.

## Problems

- **No console window opens.** Check the file location. `winhttp.dll` must be in the same folder as `TheLastPlague.exe`.
- **The first start stays at `Downloading unity base libraries`, or the console shows `End of Central Directory record could not be found`.** The game could not download the Unity libraries from the BepInEx site, and no mod loads. Starting the game again does not fix it: BepInEx keeps the broken download and tries it again at each start. Close the game and follow [The Unity libraries file](#the-unity-libraries-file-optional).
- **BepInEx is already installed.** If the console shows `6.0.0-be.793`, you do not need this pack. For a different build, follow the [replacement instructions](#replace-an-existing-installation).
- **The antivirus warns about `winhttp.dll`.** This file is how BepInEx starts: the game loads it because of its name, and it then loads BepInEx. Some antivirus programs flag this method. The file is the same as in the official download. To check, download `BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793+dbc82f0.zip` (build #793) from [builds.bepinex.dev](https://builds.bepinex.dev/projects/bepinex_be) and compare. The SHA-256 of that official zip is `5B63D7D0E92A2448CCD13B738FF95FF1CC1026C6D718555D4DF8E6C824953AC4`, and `verify.ps1` in this repo does the full comparison.
- **Mods stopped after a game update.** A game update can break BepInEx or a mod. Check here and on the pages of your mods for an update. To play in the meantime, uninstall. Saves are not touched.
- **The game does not start at all.** Uninstall, then in Steam use Properties, Installed Files, Verify integrity of game files.

BepInEx bugs that are not about this pack belong to the [BepInEx project](https://github.com/BepInEx/BepInEx/issues).

## The Unity libraries file (optional)

On the first start, BepInEx downloads the Unity libraries of the game, `2021.3.45.zip` (about 1.7 MB), from `unity.bepinex.dev`. If that site is blocked or very slow where you live, get the same file from another place. You need this only when the first start fails at that download.

1. Close the game.
2. Download the Unity libraries zip from one of these places:
   - `Unity libraries 2021.3.45` in the optional files of the [Files tab of the Nexus page](https://www.nexusmods.com/thelastplagueblight/mods/9?tab=files)
   - the BepInEx site: `https://unity.bepinex.dev/libraries/2021.3.45.zip`
   - the mirror on GitHub, an asset of the latest release of this pack: `https://github.com/ivmakk-tlpb/tlpb-bepinex-pack/releases/latest/download/2021.3.45.zip`. GitHub shows its SHA-256 on the release page.
3. Rename the file to exactly `2021.3.45.zip`. The Nexus download has a longer name, with the mod id, the version, and a date after `Unity libraries 2021.3.45`.
4. Do not extract it. Put the zip itself into `BepInEx\unity-libs\` in the game folder (create the folder if it is missing). When asked, replace the existing file. Full path example:
   - Steam: `C:\Program Files (x86)\Steam\steamapps\common\The Last Plague\BepInEx\unity-libs\2021.3.45.zip`
5. Start the game. BepInEx now uses the file and downloads nothing.

The file belongs to one Unity version of the game. When a game update moves the game to a new Unity version, BepInEx looks for a new file name and downloads again, and the Nexus page and the latest release get the new file.

The zip holds the Unity engine libraries (`UnityEngine.*.dll`) of Unity Technologies, unchanged. Each place serves byte for byte the file that BepInEx downloads from `unity.bepinex.dev`, with the SHA-256 `3CFDE1613715C966CB8084087C37081ED5896871B39194D45A907A69DD7DA9E5`. Neither the pack author nor the BepInEx team made these files.

## Uninstall

Close the game. To keep your mods and settings, copy `BepInEx\plugins` and `BepInEx\config` somewhere outside the game folder.

Delete these files and folders from your The Last Plague game folder:

```text
BepInEx/
dotnet/
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
```

Delete the entire `BepInEx` and `dotnet` folders. Deleting `BepInEx` also removes all installed mods and their settings.

Keep the `The Last Plague` folder and all other files. The game then runs without mods. These uninstall steps do not delete your save files.

## Replace an existing installation

Close the game before replacing BepInEx.

1. Copy `BepInEx\plugins` and `BepInEx\config` somewhere outside the game folder.
2. Delete the files and folders listed under [Uninstall](#uninstall).
3. Follow the [installation steps](#install).
4. Copy your saved plugins and configuration files back into their original folders.

## Verify the download

Download the official archive using the [manual installation instructions](#manual-install-advanced). Its SHA-256 is `5B63D7D0E92A2448CCD13B738FF95FF1CC1026C6D718555D4DF8E6C824953AC4`. This is the official archive's hash, not the pack zip's hash.

Download this repository and install PowerShell 7. Open PowerShell in the repository folder. Replace the example paths below with the paths to your downloaded files:

```powershell
Get-FileHash -Algorithm SHA256 "C:\Downloads\BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793+dbc82f0.zip"
pwsh ./verify.ps1 "C:\Downloads\BepInExPack_TheLastPlagueBlight-6.0.0-be.793.zip" "C:\Downloads\BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793+dbc82f0.zip"
```

Check that the first command reports the hash above. The second command must report `verify: PASSED`. It compares the official file contents and archive entries, checks that the notice exists, and rejects unexpected additions.

## Manual install (advanced)

You do not need this pack to use BepInEx. Open [builds.bepinex.dev/projects/bepinex_be](https://builds.bepinex.dev/projects/bepinex_be), find build #793, download `BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793+dbc82f0.zip` (the `Unity.IL2CPP-win-x64` file, the Mono files do not work with this game), extract it into the game folder, and start the game once.

## Why this build

The Last Plague: Blight runs on Unity 2021.3.45f2 with IL2CPP, metadata version 31. Build 793 is the newest bleeding edge build at the time of the pin, and it logs the Unity stack traces of errors, which helps mod debugging. It passed the recorded clean-install test on The Last Plague: Blight v0.12.7 (Steam build 24535672).

All official BepInEx builds, this one (#793) and newer ones, are listed at [builds.bepinex.dev](https://builds.bepinex.dev/projects/bepinex_be). A newer build is not tested with this game until this pack moves to it.

## For maintainers

Requirements: PowerShell 7 (`pwsh`). Nothing else.

- `pack.json` - the pin: build number, source commit, official archive name, URL, SHA-256. Its `unityLibs` object pins the Unity libraries zip of the optional file: the Unity version in the short form of BepInEx (`2021.3.45`), the URL, and the SHA-256.
- `pwsh ./pack.ps1` - downloads the pinned archive into `cache/` and the Unity libraries zip into `cache/unity-libs/` when they are absent, and checks both SHA-256 values before it writes anything (a mismatch fails and makes no zip). It copies the archive to `dist/BepInExPack_TheLastPlagueBlight-<build>.zip` and appends `BepInEx/NOTICE-BepInExPack.txt` (credits from `credits.template.txt` and `pack.json`, followed by the full text of `LICENSE`). The official zip is copied and appended to, never extracted and zipped again, so every entry stays as it is, the empty `BepInEx/plugins/` folder included. It then copies the checked Unity libraries zip to `dist/<Unity version>.zip`, the optional file for Nexus and the mirror for GitHub. That file is the raw zip of the site, not wrapped in another zip: Nexus quarantines an archive inside an archive.
- `pwsh ./verify.ps1` - compares the zip in `dist/` with the archive in `cache/`, one named rule each. It also takes `verify.ps1 <pack zip> <official archive>`.
- `pwsh ./tests/run.ps1` - the tests of the two scripts. It builds good and bad zips from the cached archive and expects each bad zip to fail on its rule, and checks the hash of the Unity libraries zip that `pack.ps1` writes.
- `tests/LoadCheck/` - a test plugin that logs `LoadCheck loaded`, for the plugin load check of the clean-install test. It is not in the pack zip. See its README.

The zip hash changes with each run of `pack.ps1` because of zip timestamps, so the hash in the release notes belongs to that release asset only.

### Update the pin

The pin is the bleeding edge build that the mods are built and tested against. It moves when that build stops working with the game, or when the mods move to a newer build.

1. Pick the build on [builds.bepinex.dev](https://builds.bepinex.dev/projects/bepinex_be). Put its number, commit, `Unity.IL2CPP-win-x64` file name, URL, and SHA-256 into `pack.json`.
2. Run `pack.ps1`, `verify.ps1`, and `tests/run.ps1`.
3. Test on a clean install: move the loader entries (the Uninstall list) out of the game folder, extract the new zip, start the game, and read `BepInEx\LogOutput.log` for the build line, "Chainloader startup complete", and no error. Build `tests/LoadCheck/` against the new core, put it into `BepInEx\plugins`, and check its load line. Then restore the old entries or keep the new ones.
4. Update the build values in this README, `nexus/`, and `CHANGELOG.md` with the tested game version, then release with the tag `v<build>`. Attach the pack zip and the current `cache/unity-libs/<Unity version>.zip`, so the mirror link `releases/latest/download/<Unity version>.zip` keeps working. A repack of the same build gets `.2`, `.3` (for example `6.0.0-be.793.2`, which semver sorts between `be.793` and the next build).

### A new Unity version of the game

The optional file belongs to one Unity version. The Unity version of the game is the ProductVersion of `UnityPlayer.dll` without its suffix (`2021.3.45f2` is `2021.3.45`), and BepInEx logs the URL with that version in its `Downloading unity base libraries` line.

1. Put the new version, its URL `https://unity.bepinex.dev/libraries/<version>.zip`, and the SHA-256 of the downloaded file into `unityLibs` of `pack.json`.
2. Run `pack.ps1`, `verify.ps1`, and `tests/run.ps1`.
3. Test the optional file on a clean install: a broken `BepInEx\unity-libs\<version>.zip` and `UnityBaseLibrariesSource = http://127.0.0.1:9/libraries/{VERSION}.zip` in `BepInEx\config\BepInEx.cfg` give the error of a failed download; then copy `dist/<version>.zip` over it and start again, with no `Downloading unity base libraries` line, no interop error, and the title screen. Make the broken file from the first part of the real zip, as a cut download is: a file of a few bytes fails with `Central Directory corrupt.`, which is not the error that players see.
4. Update the version and the hash in this README and in `nexus/`. On Nexus, upload `dist/<version>.zip` as the new optional file and remove the old one. On GitHub, upload the same file to the latest release: `gh release upload <tag> dist/<version>.zip`, and check that its digest equals `unityLibs.sha256`.

If builds.bepinex.dev no longer serves the pinned build, put a copy of the official archive from any source into `cache/` under the name in `pack.json`. `pack.ps1` accepts it only when the SHA-256 matches. The GitHub Release of this repo keeps the built zip.

### Test record

- 2026-11-07, game v0.12.7 (Steam build 24535672), Unity 2021.3.45f2: the pack zip with `6.0.0-be.793` on a clean install, with the default config and internet. The log starts with `BepInEx 6.0.0-be.793 - TheLastPlague`. BepInEx downloads `2021.3.45.zip` and generates the interop assemblies, `Chainloader startup complete` comes about 20 seconds after the start, and the game reaches the main menu. The only warning is `Class::Init signatures have been exhausted, using a substitute!` of Il2CppInterop, at each start. The plugin `tests/LoadCheck/` placed in `BepInEx\plugins` loads. Deleting the Uninstall list leaves exactly the files that the game shipped, and the game then starts unmodded to the main menu.
- 2026-11-07, same game version: the third-party mod Bigger Stacks TLP by Flusk 1.6.0 ([Nexus mod 3](https://www.nexusmods.com/thelastplagueblight/mods/3), `InventoryStackingFixPlugin.dll`). It was built against older BepInEx assemblies (Il2CppInterop 1.4.6, HarmonyX 2.10.1) and runs on the versions of build 793 (Il2CppInterop 1.5.3, HarmonyX 2.10.2). It loads with no Harmony or interop error, and in a loaded save items stack above the default size.
- 2026-11-07, same game version: the failed download of the problems section. With a broken `BepInEx\unity-libs\2021.3.45.zip` (the first 800,000 bytes of the real file) and an unreachable `UnityBaseLibrariesSource`, the start logs "Failed to generate Il2Cpp interop assemblies: System.IO.InvalidDataException: End of Central Directory record could not be found" and "Unable to execute IL2CPP chainloader, no plugins will be loaded", with no download. After the pinned `2021.3.45.zip` replaced it, the next start makes no download, generates the interop assemblies with no error, and reaches the main menu.

## Credits and license

BepInEx is the work of the [BepInEx team](https://github.com/BepInEx/BepInEx) and its contributors, licensed under LGPL-2.1. The zip is an unmodified redistribution of [build #793](https://builds.bepinex.dev/projects/bepinex_be/793/BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793%2Bdbc82f0.zip), and `BepInEx/NOTICE-BepInExPack.txt` in the zip lists the bundled components with their licenses. The BepInEx logo in `nexus/images/` belongs to the BepInEx team. The optional Unity libraries file holds Unity Technologies' Unity engine libraries, unchanged, as `unity.bepinex.dev` serves them.

This repo is licensed under LGPL-2.1, the same license as BepInEx. See `LICENSE`.
