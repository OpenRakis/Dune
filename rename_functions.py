#!/usr/bin/env python3
"""
Applies function names from fn_addresses.md to method names in
CfgGeneratedOverrides partial class files (Base.cs + Part001.cs .. Part030.cs).

The mapping is:
  fn_addresses.md:  seg000:XXXX  →  C#:  unknown_100D_XXXX_<last>
  fn_addresses.md:  segvga:XXXX  →  C#:  unknown_<SEGVGA>_XXXX_<last>

For each (segment, offset) pair in the MD file, ALL methods with that address
are renamed to the FIRST function_name found for that address (duplicates in
the MD share the same address and thus the same C# method).

The rename is done globally across all Override .cs files (method declarations,
DefineFunction calls, NearCall calls, etc.).
"""

import os
import re
import sys
from pathlib import Path

REPO = Path(r"C:\Users\noalm\source\repos\Dune")
MD_FILE = REPO / "fn_addresses.md"
OVERRIDES_DIR = REPO / "GeneratedProject" / "Overrides"

# Segment base addresses (from CfgGeneratedOverrides.Base.cs)
SEGMENT_BASES = {
    "seg000": "100D",
    "segvga": None,  # resolved dynamically below
}


def parse_md(md_path: Path) -> dict[tuple[str, int], str]:
    """Parse fn_addresses.md and return {(segment, offset): function_name}.

    segment is the hex string used in C# names (e.g. "100D", or the resolved
    segment base for segvga). For duplicate addresses, the first name wins.
    """
    result: dict[tuple[str, int], str] = {}
    line_re = re.compile(
        r"^\|\s*(\S+\.rs)\s*\|\s*(seg\w+):([0-9A-Fa-f]+)\s*\|\s*(\S+)\s*\|"
    )
    with open(md_path, encoding="utf-8") as f:
        for line in f:
            m = line_re.match(line.rstrip())
            if not m:
                continue
            seg_label = m.group(2)  # e.g. "seg000"
            offset_hex = m.group(3)  # e.g. "0083"
            func_name = m.group(4)
            offset = int(offset_hex, 16)

            # Map segment label to the C# segment identifier
            if seg_label == "seg000":
                seg_id = "100D"
            elif seg_label == "segvga":
                seg_id = "SEGVGA"  # placeholder, will be resolved below
            else:
                seg_id = seg_label

            key = (seg_id, offset)
            if key not in result:
                result[key] = func_name
    return result


def resolve_segvga_id(overrides_dir: Path) -> str:
    """Find the actual segment base address for 'segvga' by scanning the
    DefineFunction calls in Base.cs. We look for a DefineFunction that uses
    a segment value other than cs1/cs2/cs3/cs4/cs5."""
    base_cs = overrides_dir / "CfgGeneratedOverrides.Base.cs"
    with open(base_cs, encoding="utf-8") as f:
        content = f.read()
    # Find all DefineFunction calls
    for m in re.finditer(r"DefineFunction\((\w+),\s*0x([0-9A-Fa-f]+)", content):
        var = m.group(1)
        if var not in ("cs1", "cs2", "cs3", "cs4", "cs5"):
            return var
    # Fallback: return None meaning we can't map segvga
    return None


def build_renamemap(
    md_map: dict[tuple[str, int], str],
    overrides_dir: Path,
) -> dict[str, str]:
    """
    Build a dict of {old_c#_name: new_c#_name} by scanning the Override files
    for method declarations and matching them against the MD map.
    """
    # First, find all method names in the override files
    # Pattern: public virtual Action <name>(int loadOffset)
    method_pattern = re.compile(
        r"public\s+virtual\s+Action\s+(\w+)\(int\s+loadOffset\)"
    )

    all_methods: set[str] = set()
    for f in overrides_dir.glob("CfgGeneratedOverrides.*.cs"):
        with open(f, encoding="utf-8") as fh:
            for m in method_pattern.finditer(fh.read()):
                all_methods.add(m.group(1))

    # Now build the rename map
    renames: dict[str, str] = {}
    unmatched: list[str] = []

    for (seg_id, offset), func_name in md_map.items():
        # The C# name pattern: unknown_<SEG>_<OFFSET>_<LAST>
        # We need to find which method in all_methods matches this pattern.
        # The OFFSET in the C# name is uppercase hex without 0x prefix, padded to 4 chars.
        offset_str = f"{offset:04X}"

        # Try to find the method by pattern
        found = False
        for method in all_methods:
            # Method name format: unknown_<SEG>_<OFFSET>_<LAST>
            # e.g. unknown_100D_0083_10153
            pattern = re.compile(
                r"^unknown_" + re.escape(seg_id) + "_" + re.escape(offset_str) + r"_[0-9A-F]+$"
            )
            if pattern.match(method):
                renames[method] = func_name
                found = True
                break

        if not found:
            unmatched.append(f"{seg_id}:{offset:04X} -> {func_name}")

    return renames, unmatched


def apply_renames(overrides_dir: Path, renames: dict[str, str]) -> int:
    """Apply renames to all CfgGeneratedOverrides.*.cs files. Returns count of files changed."""
    # Sort by length descending to avoid partial-match issues
    # (e.g. renaming "foo" before "foobar" would corrupt "foobar")
    sorted_renames = sorted(renames.items(), key=lambda x: len(x[0]), reverse=True)

    files_changed = 0
    for f in sorted(overrides_dir.glob("CfgGeneratedOverrides.*.cs")):
        with open(f, encoding="utf-8") as fh:
            content = fh.read()
        original = content
        for old, new in sorted_renames:
            content = content.replace(old, new)
        if content != original:
            with open(f, "w", encoding="utf-8") as fh:
                fh.write(content)
            files_changed += 1
    return files_changed


def main():
    dry_run = "--dry-run" in sys.argv

    print(f"MD file:        {MD_FILE}")
    print(f"Overrides dir:  {OVERRIDES_DIR}")
    if dry_run:
        print("Mode:           DRY RUN (no files will be modified)")
    print()

    if not MD_FILE.exists():
        print(f"ERROR: {MD_FILE} not found")
        sys.exit(1)
    if not OVERRIDES_DIR.exists():
        print(f"ERROR: {OVERRIDES_DIR} not found")
        sys.exit(1)

    # Step 1: Parse the MD file
    md_map = parse_md(MD_FILE)
    print(f"Parsed {len(md_map)} unique (segment, offset) entries from MD file")

    # Step 2: Build the rename map by scanning override files
    renames, unmatched = build_renamemap(md_map, OVERRIDES_DIR)
    print(f"Matched {len(renames)} C# methods to MD entries")
    if unmatched:
        print(f"\nWARNING: {len(unmatched)} MD entries had no matching C# method:")
        for entry in unmatched[:20]:
            print(f"  {entry}")
        if len(unmatched) > 20:
            print(f"  ... and {len(unmatched) - 20} more")

    if not renames:
        print("\nNo renames to apply.")
        sys.exit(0)

    # Step 3: Apply the renames (or just report in dry-run mode)
    if dry_run:
        print(f"\n[DRY RUN] Would apply {len(renames)} renames across override files.")
    else:
        print(f"\nApplying {len(renames)} renames across override files...")
        files_changed = apply_renames(OVERRIDES_DIR, renames)
        print(f"Done. {files_changed} files modified.")

    # Show a sample of what was renamed
    print("\nSample renames (first 10):")
    for i, (old, new) in enumerate(sorted(renames.items())[:10]):
        print(f"  {old}  ->  {new}")


if __name__ == "__main__":
    main()
