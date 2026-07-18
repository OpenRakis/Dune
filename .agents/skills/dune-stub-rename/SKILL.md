---
name: dune-stub-rename
description: "Rename and optionally implement a generated stub in CfgGeneratedOverrides.cs by cross-referencing the Chani disassembly. Use when: renaming unknown_ stub, identifying a function by address, looking up chani.htm label, implementing a Dune override, stub-rename, rename function, implement function, what does this stub do."
argument-hint: "stub name (e.g. unknown_100D_021C_102EC) or seg000 address (e.g. seg000:021c) or disassembly label (e.g. play_intro2)"
---

# dune-stub-rename

Rename a generated stub in `GeneratedProject/CfgGeneratedOverrides.cs` to its disassembly label, then optionally implement its body.

## Inputs

Accepts any of:
- A stub method name: `unknown_100D_021C_102EC`
- A raw address: `cs1:0x021C` or `seg000:021c`
- A disassembly label: `play_intro2`

## Address Decoding

Stub names encode the segment constant and offset:

```
unknown_SSSS_OOOO_AAAAA
         │    │    └── absolute address (segment × 16 + offset), hex, informational
         │    └─────── offset within segment, hex
         └──────────── segment value, hex (e.g. 100D = cs1)
```

Segment-to-constant mapping (from `CfgGeneratedOverrides.cs`):

| Segment | Constant | Disassembly alias |
|---------|----------|-------------------|
| `0x100D` | `cs1` | `seg000` |
| `0x3358` | `cs2` | `seg001` or later segments |
| `0x5642` | `cs3` | |
| `0x5BAE` | `cs4` | |
| `0xF000` | `cs5` | BIOS |

> `seg000` in the `.chani.htm` file maps 1:1 to `cs1 = 0x100D`. An offset like `0x021C` in the stub corresponds to anchor `seg000:021c` in the disassembly.

## Procedure

### Step 1 — Resolve the label

If given a **stub name** (e.g. `unknown_100D_021C_102EC`):
- Extract segment `100D` → `cs1` / `seg000`, offset `021C`
- Search `cryo-dune-3.7-cd-dncdprg.chani.htm` for anchor `seg000:021c` (lowercase hex)
- Read the label on that line (e.g. `play_intro2:`) and its inline comment for semantics

If given a **label** (e.g. `play_intro2`):
- Search `.chani.htm` for `play_intro2:` to find its address
- Derive the stub name: `unknown_100D_OOOO_AAAAA` where `OOOO` = offset

If given a **raw address** (`cs1:0x021C`):
- Compute anchor `seg000:021c` and proceed as above

### Step 2 — Find occurrences in overrides

In `GeneratedProject/CfgGeneratedOverrides.cs` there are exactly **two** occurrences of each stub name:

1. Constructor registration:
   ```csharp
   DefineFunction(cs1, 0x021C, unknown_100D_021C_102EC);
   ```
2. Method signature:
   ```csharp
   public Action unknown_100D_021C_102EC(int loadOffset)
   ```

Use `grep_search` to locate both lines before editing.

### Step 3 — Rename

Replace both occurrences with the disassembly label (snake_case, exact match to `.chani.htm`):

```csharp
// Before
DefineFunction(cs1, 0x021C, unknown_100D_021C_102EC);
// After
DefineFunction(cs1, 0x021C, play_intro2);
```

```csharp
// Before
public Action unknown_100D_021C_102EC(int loadOffset)
// After
public Action play_intro2(int loadOffset)
```

Use `multi_replace_string_in_file` for both replacements in a single call.

### Step 4 — Implement (optional)

If the user asks to implement the function body, read the disassembly starting at the label address in `.chani.htm` and translate each instruction to C# using `CSharpOverrideHelper` primitives documented in [Spice86/AGENTS.md](../../../Spice86/AGENTS.md#code-override-system).

The stub body template to replace:

```csharp
public Action play_intro2(int loadOffset) {
    return NotImplemented(nameof(play_intro2));
}
```

Finish with the correct return: `NearRet()`, `FarRet()`, `FarJump()`, etc., depending on how the disassembly function ends.

### Step 5 — Verify

After editing, run:

```powershell
cd GeneratedProject
dotnet build
```

Fix any compilation errors before finishing.

## Quality Criteria

- [ ] Both occurrences renamed (constructor + method)
- [ ] Name is exact snake_case label from `.chani.htm`
- [ ] Build passes with no errors
- [ ] If implemented: return type matches disassembly control flow (`ret` / `retf` / `jmp`)
