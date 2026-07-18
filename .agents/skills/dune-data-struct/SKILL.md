---
name: dune-data-struct
description: "Generate a MemoryBasedDataStructureWithDsBaseAddress subclass from seg001 data declarations in the Chani disassembly. Use when: creating memory wrapper, data structure, DS memory accessor, seg001 fields, MemoryBasedDataStructure, game state struct, wrap memory offsets, data class for Dune override."
argument-hint: "logical group name (e.g. 'game state', 'audio', 'UI') or a seg001 offset range (e.g. 0x0002-0x00FF)"
---

# dune-data-struct

Generate a typed `MemoryBasedDataStructureWithDsBaseAddress` subclass wrapping a logical group of `seg001` fields from the Chani disassembly.

## When to Use

- You are implementing an override function that reads/writes multiple `seg001` fields
- A logical cluster of DS-relative offsets belongs together (game state, audio state, UI state, etc.)
- The existing [dune-memory-layout.instructions.md](../../.github/instructions/dune-memory-layout.instructions.md) table lists the offsets you need

## Inputs

Accept any of:
- A **logical group** name: `"game state"`, `"audio"`, `"UI"`, `"troop"`, `"resource"`
- An **offset range**: `0x0002–0x00FF`
- A **list of label names** from the disassembly: `game_time, current_room, charisma`

## Procedure

### Step 1 — Collect offsets

**From the memory-layout instructions file** (preferred — already curated):  
Read [dune-memory-layout.instructions.md](../../.github/instructions/dune-memory-layout.instructions.md) and filter rows matching the requested group or range.

**From the disassembly directly** (for unlisted offsets):  
Search `cryo-dune-3.7-cd-dncdprg.chani.htm` for `id="seg001-XXXX"` (lowercase hex, 4 digits) to find the label and type (`db` = byte, `dw` = word). Include the inline comment as the property's XML doc if present.

### Step 2 — Map disassembly types to C#

| Disassembly | C# accessor | Property type |
|-------------|-------------|---------------|
| `db` | `UInt8[offset]` | `int` (getter) / `byte` (setter cast) |
| `dw` | `UInt16[offset]` | `int` (getter) / `ushort` (setter cast) |
| `dd` | `UInt32[offset]` | `uint` |

> Use `int` for getter return types to match Spice86's convention; cast on setter.

### Step 3 — Choose a class name and file location

- **Class name**: PascalCase logical group + `OnDs` suffix  
  Examples: `GameStateOnDs`, `AudioStateOnDs`, `UiStateOnDs`, `TroopStateOnDs`
- **File location**: `GeneratedProject/` alongside the override class that owns the data  
  Example: `GeneratedProject/GameStateOnDs.cs`
- **One top-level type per file** — do not add to an existing file

### Step 4 — Generate the class

Template:

```csharp
using Spice86.Core.Emulator.Memory;
using Spice86.Shared.Emulator.Memory;

namespace Spice86.Generated;

/// <summary>Game-state variables at DS-relative offsets (seg001).</summary>
public sealed class GameStateOnDs : MemoryBasedDataStructureWithDsBaseAddress {
    public GameStateOnDs(IByteReaderWriter memory, SegmentRegisters segmentRegisters)
        : base(memory, segmentRegisters) { }

    /// <summary>Current in-game time (time periods). Init = 2.</summary>
    public int GameTime { get => UInt16[0x0002]; set => UInt16[0x0002] = (ushort)value; }

    /// <summary>Current room number. Init = 0x0A.</summary>
    public int CurrentRoom { get => UInt8[0x000B]; set => UInt8[0x000B] = (byte)value; }

    /// <summary>Paul's charisma level.</summary>
    public int Charisma { get => UInt8[0x0029]; set => UInt8[0x0029] = (byte)value; }
}
```

Rules:
- Property names are PascalCase translations of the disassembly snake_case label  
  `game_time` → `GameTime`, `music_playlist_flags` → `MusicPlaylistFlags`
- Strip `for_condit_` prefixes — they denote CONDIT script scratch variables, not primary accessors
- Omit offsets where the label is purely `data_XXXXX` with no meaningful name — add them to the memory-layout instructions file first and name them before wrapping
- No optional parameters; no nullable fields unless absence is a real distinct state

### Step 5 — Instantiate in the override class

Add the struct as a field on the `CfgGeneratedOverrides` subclass (or a future subsystem override class) and pass `Memory` and `State.SegmentRegisters`:

```csharp
private readonly GameStateOnDs _gameState;

public CfgGeneratedOverrides(...) : base(...) {
    _gameState = new GameStateOnDs(Memory, State.SegmentRegisters);
    // ...
}
```

### Step 6 — Build

```powershell
cd GeneratedProject
dotnet build
```

Fix any compilation errors before finishing.

## Quality Criteria

- [ ] File is in `GeneratedProject/`, one top-level type, filename matches class name
- [ ] All property names are PascalCase; no `var`, no optional parameters
- [ ] Getter returns `int`; setter casts to `byte` or `ushort` as appropriate
- [ ] XML doc on class and on each non-obvious property
- [ ] Build passes clean
