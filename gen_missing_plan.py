#!/usr/bin/env python3
"""
Generate a follow-up plan MD file documenting all 210 missing (unimplemented)
functions from fn_addresses.md. For each function, extracts:
  - Disassembly listing (from spice86dumpListing.asm)
  - CFG block (from spice86dumpCfgBlocks.json)
  - Callers (from spice86dumpExecutionFlow.json CallsFromTo)
  - Call targets (from the listing)
  - Whether the function was ever executed
"""

import json
import re
from pathlib import Path
from collections import defaultdict

REPO = Path(r"C:\Users\noalm\source\repos\Dune")
MD = REPO / "fn_addresses.md"
LISTING = REPO / "spice86dumpListing.asm"
CFG = REPO / "spice86dumpCfgBlocks.json"
FLOW = REPO / "spice86dumpExecutionFlow.json"
OUT = REPO / "missing_functions_plan.md"

# ── Parse fn_addresses.md ─────────────────────────────────────────────────────
line_re = re.compile(r"^\|\s*(\S+\.rs)\s*\|\s*(seg\w+):([0-9A-Fa-f]+)\s*\|\s*(\S+)\s*\|")
md_entries = []  # list of (seg, offset, name, fname)
seen = set()
with open(MD, encoding="utf-8") as f:
    for line in f:
        m = line_re.match(line.rstrip())
        if not m:
            continue
        seg = m.group(2)
        off = int(m.group(3), 16)
        name = m.group(4)
        fname = m.group(1)
        key = (seg, off)
        if key not in seen:
            seen.add(key)
            md_entries.append((seg, off, name, fname))

# ── Determine which are missing (no C# stub) ──────────────────────────────────
OV = REPO / "GeneratedProject" / "Overrides"
method_pattern = re.compile(r"public\s+virtual\s+Action\s+(\w+)\(int\s+loadOffset\)")
all_methods = set()
for fp in OV.glob("CfgGeneratedOverrides.*.cs"):
    with open(fp, encoding="utf-8") as fh:
        for m in method_pattern.finditer(fh.read()):
            all_methods.add(m.group(1))

def has_stub(seg, off):
    seg_id = "100D" if seg == "seg000" else "SEGVGA"
    off_str = f"{off:04X}"
    pat = re.compile(r"^unknown_" + re.escape(seg_id) + "_" + re.escape(off_str) + r"_[0-9A-F]+$")
    for method in all_methods:
        if pat.match(method):
            return True
    return False

missing = [(seg, off, name, fname) for seg, off, name, fname in md_entries if not has_stub(seg, off)]
missing.sort(key=lambda x: (0 if x[0] == "seg000" else 1, x[1]))

# ── Parse listing ─────────────────────────────────────────────────────────────
# Build: linear_addr -> (offset, segment, instr)
# and: segment:offset -> list of (linear, instr) for functions starting there
listing_by_offset = {}  # "SEGOFF" -> list of lines
listing_order = []  # ordered list of (linear, seg, offset, instr)

with open(LISTING, encoding="utf-8") as f:
    for line in f:
        line = line.strip()
        if not line:
            continue
        # Format: "SEGOFF:OFFSET  instruction"
        m = re.match(r"^([0-9A-Fa-f]+):([0-9A-Fa-f]+)\s+(.+)$", line)
        if not m:
            continue
        seg = int(m.group(1), 16)
        off = int(m.group(2), 16)
        instr = m.group(3)
        linear = (seg << 4) + off
        listing_order.append((linear, seg, off, instr))
        key = f"{seg:04X}:{off:04X}"
        if key not in listing_by_offset:
            listing_by_offset[key] = []
        listing_by_offset[key].append(instr)

# ── Parse CFG blocks ──────────────────────────────────────────────────────────
with open(CFG, encoding="utf-8") as f:
    cfg_data = json.load(f)

# Index blocks by entry address
cfg_by_entry = {}
for block in cfg_data["blocks"]:
    entry = block["entry"]  # e.g. "100D:0000"
    cfg_by_entry[entry] = block

# ── Parse execution flow ──────────────────────────────────────────────────────
with open(FLOW, encoding="utf-8") as f:
    flow_data = json.load(f)

calls_from_to = flow_data["CallsFromTo"]  # linear_addr_str -> [{Offset, Segment, Linear}]
executed_set = set()
for inst in flow_data["ExecutedInstructions"]:
    executed_set.add(inst["Linear"])

# ── Helper: find function body in listing (from entry to next known function or ret) ─
def get_function_body(seg_hex: str, off: int, max_lines: int = 80) -> list[str]:
    """Get the assembly listing for a function starting at seg:off."""
    key = f"{int(seg_hex, 16):04X}:{off:04X}"
    if key not in listing_by_offset:
        return []
    # We need to find consecutive lines in the listing starting from this offset
    # The listing is linear, so find the index and read forward
    target_linear = (int(seg_hex, 16) << 4) + off
    body = []
    started = False
    for linear, seg, off_i, instr in listing_order:
        if linear == target_linear:
            started = True
        if started:
            body.append(instr)
            if len(body) >= max_lines:
                break
            # Stop if we hit a ret and we've had at least a few instructions
            if len(body) > 3 and instr.startswith("ret"):
                break
    return body

def get_callers(linear: int) -> list[dict]:
    """Find all callers of a given linear address."""
    key = str(linear)
    if key in calls_from_to:
        return calls_from_to[key]
    return []

def get_call_targets(body: list[str], seg: int) -> list[str]:
    """Extract call targets from a function body."""
    targets = []
    for instr in body:
        m = re.search(r"call near (0x[0-9A-Fa-f]+)", instr)
        if m:
            targets.append(m.group(1))
        m = re.search(r"call far (0x[0-9A-Fa-f]+):([0-9A-Fa-f]+)", instr)
        if m:
            targets.append(f"{m.group(1)}:{m.group(2)}")
        m = re.search(r"call far dword ptr", instr)
        if m:
            targets.append("indirect")
    return targets

def is_executed(seg: int, off: int) -> bool:
    linear = (seg << 4) + off
    return linear in executed_set

# ── Build the markdown ────────────────────────────────────────────────────────
out_lines = []
out_lines.append("# Missing Functions - Follow-Up Plan")
out_lines.append("")
out_lines.append(f"> {len(missing)} functions are named in `fn_addresses.md` but have no C# override stub.")
out_lines.append("> These were never observed executing during the Spice86 discovery run, so no")
out_lines.append("> `DefineFunction` entry was generated. They must be reverse-engineered manually")
out_lines.append("> from the binary disassembly before they can be overridden in C#.")
out_lines.append("")
out_lines.append("## Sources")
out_lines.append("")
out_lines.append("| File | Content |")
out_lines.append("|------|---------|")
out_lines.append("| `spice86dumpListing.asm` | Full instruction listing (29 388 lines, segments 100D/3358/5642/5BAE/F000) |")
out_lines.append("| `spice86dumpCfgBlocks.json` | 10 658 CFG blocks with pred/succ edges and assembly bytes |")
out_lines.append("| `spice86dumpExecutionFlow.json` | 3 257 call sites, 4 206 jump sites, 29 164 executed instructions |")
out_lines.append("| `spice86dumpMemoryDump.bin` | 1 114 095-byte raw memory image |")
out_lines.append("| `cryo-dune-3.7-cd-dncdprg.chani.htm` | Full disassembly with labels and comments |")
out_lines.append("")
out_lines.append("## How to Implement")
out_lines.append("")
out_lines.append("For each function below:")
out_lines.append("")
out_lines.append("1. Locate the function in `cryo-dune-3.7-cd-dncdprg.chani.htm` by its address")
out_lines.append("2. Read the disassembly, understand the logic, and the comments")
out_lines.append("3. Use the listing snippet and CFG block below as quick reference")
out_lines.append("4. Create the C# override in the appropriate `CfgGeneratedOverrides.PartNNN.cs` file")
out_lines.append("5. Add a `DefineFunction` entry in `CfgGeneratedOverrides.Base.cs`")
out_lines.append("6. Build and test")
out_lines.append("")
out_lines.append("---")
out_lines.append("")

# Group by subsystem (filename)
by_file = defaultdict(list)
for seg, off, name, fname in missing:
    by_file[fname].append((seg, off, name))

for fname in sorted(by_file.keys()):
    funcs = by_file[fname]
    out_lines.append(f"## {fname} ({len(funcs)} functions)")
    out_lines.append("")

    for seg, off, name in funcs:
        seg_int = int(seg.replace("seg", "").ljust(4, "0"), 16) if seg.startswith("seg0") else None
        if seg == "seg000":
            seg_hex = "100D"
        else:
            seg_hex = "SEGVGA"

        out_lines.append(f"### `{name}` — {seg}:{off:04X}")
        out_lines.append("")

        # Executed?
        if seg == "seg000":
            seg_int_val = 0x100D
            executed = is_executed(seg_int_val, off)
            if executed:
                out_lines.append("**Status:** Was executed during discovery but has no stub (possible partial coverage).")
            else:
                out_lines.append("**Status:** Never executed during discovery.")
        else:
            out_lines.append("**Status:** In VGA BIOS segment - not present in any dump (separate code path).")
        out_lines.append("")

        # Listing snippet
        if seg == "seg000":
            body = get_function_body("100D", off, max_lines=40)
            if body:
                out_lines.append("**Disassembly (first 40 instr):**")
                out_lines.append("")
                out_lines.append("```asm")
                out_lines.append(f"; 100D:{off:04X} {name}")
                for i, instr in enumerate(body):
                    out_lines.append(f"  {instr}")
                out_lines.append("```")
                out_lines.append("")

            # Call targets
            calls = get_call_targets(body, 0x100D)
            if calls:
                out_lines.append(f"**Calls:** {', '.join(calls)}")
                out_lines.append("")

            # Callers
            linear = (0x100D << 4) + off
            callers = get_callers(linear)
            if callers:
                caller_strs = [f"{c['Segment']:04X}:{c['Offset']:04X}" for c in callers]
                out_lines.append(f"**Called from:** {', '.join(caller_strs)}")
                out_lines.append("")

        # CFG block
        if seg == "seg000":
            cfg_key = f"100D:{off:04X}"
            if cfg_key in cfg_by_entry:
                blk = cfg_by_entry[cfg_key]
                out_lines.append("**CFG Block:**")
                out_lines.append(f"- ID: {blk['id']}")
                out_lines.append(f"- Entry: {blk['entry']}, Term: {blk['term']}")
                out_lines.append(f"- Preds: {blk['pred']}, Succs: {blk['succ']}")
                out_lines.append("")

        out_lines.append("---")
        out_lines.append("")

# Write output
with open(OUT, "w", encoding="utf-8") as f:
    f.write("\n".join(out_lines))

print(f"Written {OUT}")
print(f"  {len(missing)} missing functions across {len(by_file)} subsystems")
for fname in sorted(by_file.keys()):
    print(f"    {fname}: {len(by_file[fname])} functions")
