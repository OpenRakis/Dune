# AGENTS

Guidance for AI agents working in this Dune reverse-engineering repository.

## Project Overview

This repo incrementally rewrites **Cryo Interactive's Dune (1992) CD** (`DNCDPRG.EXE` v3.7) from x86 assembly into C#, using [Spice86](Spice86/AGENTS.md) as the emulation and override engine.

- **Binary**: `DNCDPRG.EXE` · SHA1 `c55e9e35c24941d8590c068c69cb6cee85e4afcb`
- **Expected checksum**: `5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9`
- **Game files location** (not in repo): `C:\Jeux\DUNE_CDVF\C\`

## Repository Layout

| Path | Purpose |
|---|---|
| `GeneratedProject/` | C# project with auto-generated override stubs + entry point |
| `GeneratedProject/CfgGeneratedOverrides.cs` | 7 610 auto-generated function stubs (all currently `unknown_`) |
| `GeneratedProject/Properties/launchSettings.json` | VS launch profile with correct args |
| `GeneratedProject/Program.cs` | Thin wrapper that injects `CfgGeneratedOverrideSupplier` |
| `cryo-dune-3.7-cd-dncdprg.chani.htm` | Reference disassembly (Chani disassembler, Thomas Fach-Pedersen) |
| `spice86dumpCfgBlocks.json` | CFG block dump from last Spice86 run |
| `spice86dumpExecutionFlow.json` | Execution-flow trace used to generate overrides |
| `Spice86/` | Spice86 emulator source (branch `feature/speculative_execution`) |
| `DuneOverrides.slnx` | Solution file |

## Code Segment Map

| Constant | Segment | Notes |
|---|---|---|
| `cs1` | `0x100D` | Main code segment (entry point `start:`) |
| `cs2` | `0x3358` | Second code segment |
| `cs3` | `0x5642` | Third code segment |
| `cs4` | `0x5BAE` | Fourth code segment |
| `cs5` | `0xF000` | BIOS segment |

## Build & Run

```powershell
# Build
cd GeneratedProject
dotnet build

# Run (game files must exist at C:\Jeux\DUNE_CDVF\C\)
dotnet run -- -e "C:\Jeux\DUNE_CDVF\C\DNCDPRG.EXE" -a "ADP220 SBP2227" -p 4096 --UseCodeOverride true --HttpApiPort 0 --GdbPort 0 --McpHttpPort 0

# Or use the VS launch profile (launchSettings.json already has the correct args)
```

> The `-a "ADP220 SBP2227"` argument selects the AdLib/Sound Blaster audio driver. `-p 4096` sets the program segment.

## Reverse Engineering Workflow

1. Identify a function in `CfgGeneratedOverrides.cs` by cross-referencing `cryo-dune-3.7-cd-dncdprg.chani.htm`
2. Rename the stub from `unknown_XXXX_YYYY_ZZZZZ` to a descriptive name matching the disassembly label
3. Implement the C# body using `CSharpOverrideHelper` primitives (see [Spice86/AGENTS.md](Spice86/AGENTS.md#code-override-system))
4. Run the game and verify behavior

### Key Top-Level Functions (from disassembly)

These are the first functions to orient from; all reside in `cs1` (`0x100D`):

| Disassembly label | Spice86 address | Generated stub name |
|---|---|---|
| `start` | `cs1:0x0000` | `entry_100D_0000_100D0` |
| `init_game_ui` | `cs1:0x0083` | `unknown_100D_0083_10153` |
| `adjust_sub_resource_pointers` | `cs1:0x0098` | `unknown_100D_0098_10168` |
| `initialize_resources` | `cs1:0x00B0` | `unknown_100D_00B0_10180` |
| `initialize_resources2` | `cs1:0x00D1` | `unknown_100D_00D1_101A1` |
| `map2_resource_func` | `cs1:0x0169` | `unknown_100D_0169_10239` |
| `play_intro2` | `cs1:0x021C` | `unknown_100D_021C_102EC` |
| `play_credits` | `cs1:0x0309` | `unknown_100D_0309_103D9` |
| `play_intro` | `cs1:0x0580` | `unknown_100D_0580_10650` |

> **Tip**: The disassembly file `cryo-dune-3.7-cd-dncdprg.chani.htm` is the primary reference. Function comments in it describe the high-level semantics. Match segment offsets between the `.chani.htm` anchors (`seg000:XXXX`) and the generated stub addresses (`cs1:0xXXXX` where `seg000` maps to `cs1 = 0x100D`).

## Current State

All 7 610 functions in `CfgGeneratedOverrides.cs` are **unimplemented stubs** — none have been renamed or given a C# body yet. The game runs entirely in emulated assembly via `--UseCodeOverride true`.

## Conventions

- Inherit all C# style rules from [Spice86/AGENTS.md](Spice86/AGENTS.md#project-specific-conventions)
- When renaming a stub, use the exact label from the disassembly (snake_case matching `.chani.htm`)
- Do **not** split `CfgGeneratedOverrides.cs` into multiple files yet — one class per logical subsystem is the target but can wait until a subsystem is substantially implemented
- Memory data structures go in separate files alongside the override class that owns them
- Game files (`C:\Jeux\DUNE_CDVF\C\`) are never committed to the repo
