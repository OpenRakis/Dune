---
applyTo: "GeneratedProject/**"
---

# Dune Memory Layout — Data Segment (seg001 / DS)

`seg001` is the primary game-state data segment. At runtime `DS` holds its base address. All offsets below are DS-relative (i.e. `seg001:XXXX` in the disassembly).

## Accessing DS Memory in C# Overrides

Wrap a group of related fields in a `MemoryBasedDataStructureWithDsBaseAddress` subclass:

```csharp
public sealed class GameState : MemoryBasedDataStructureWithDsBaseAddress {
    public GameState(IByteReaderWriter memory, SegmentRegisters segmentRegisters)
        : base(memory, segmentRegisters) { }

    public int GameTime { get => UInt16[0x0002]; set => UInt16[0x0002] = (ushort)value; }
    public int CurrentRoom { get => UInt8[0x000B]; set => UInt8[0x000B] = (byte)value; }
}
```

For CS-relative or SS-relative access use `MemoryBasedDataStructureWithCsBaseAddress` / `MemoryBasedDataStructureWithSsBaseAddress`.

## Known seg001 Offsets

### Core Game State (`0x0000–0x00FF`)

| Offset | Label | Type | Notes |
|--------|-------|------|-------|
| `0x0002` | `game_time` | `dw` | Current in-game time (units = time periods); initialised to 2 |
| `0x0004` | `location_and_room` | `dw` | Packed current location + room |
| `0x0006` | `location_appearance` | — | Location appearance flags |
| `0x0008` | `current_scene` | `db` | Active scene index (init = `0x20`) |
| `0x000B` | `current_room` | `db` | Current room number (init = `0x0A`) |
| `0x000C` | `pending_destination_room` | `db` | Room to travel to (written by click-move handler) |
| `0x000D` | `previous_room` | `db` | Room player just left |
| `0x000E` | `persons_met` | `dw` | Bitfield of characters encountered |
| `0x0010` | `persons_travelling_with` | `dw` | Bitfield of companions |
| `0x0012` | `persons_in_room` | `dw` | Bitfield of NPCs in current room |
| `0x0014` | `persons_talking_to` | `dw` | Bitfield of active dialogue targets |
| `0x0018` | `data_00018` | `db` | Flags: bit 2 = left Jessica in the desert |
| `0x0025` | `number_of_sietches_visited` | `db` | |
| `0x0026` | `entering_new_sietch` | `db` | Non-zero when first entering a sietch |
| `0x0027` | `discovered_sietch_count` | `db` | |
| `0x0028` | `number_of_rallied_troops` | `db` | Total troops allied to Paul |
| `0x0029` | `charisma` | `db` | Paul's charisma level |
| `0x002A` | `game_phase` | `db` | Main game phase index |
| `0x009F` | `accept_refuse_argue_choice_ds_9f` | `db` | Last dialogue choice (accept/refuse/argue) |
| `0x00A0` | `spice_in_stock` | `dw` | Total spice held |
| `0x00C2` | `final_attack_stage_ds_c2` | `db` | Stage of the final Harkonnen attack |
| `0x00C9` | `RES_SMUG_HSQ` | `db` | Smuggler resource load flag |
| `0x00CF` | `days_left_until_spice_shipment` | `db` | Countdown to next Harkonnen spice demand |
| `0x00E8` | `ui_hud_head_index` | `db` | Which character portrait is shown in the HUD |
| `0x00EC` | `bulb_growing_progress` | `db` | Ecology bulb growth counter |

### UI & Rendering

| Offset | Label | Type | Notes |
|--------|-------|------|-------|
| `0x1AE4` | `ui_hud_elements_count` | `dw` | Count/pointer used by `draw_all_ui_elements` |
| `0x3CBC` | `_word_2316C_error_msg` | `dw` | Near pointer to error message string; 0 = no error |
| `0xCE80` | `pause_enabled` | `db` | `0xFF` = game pause allowed |
| `0xDBE4` | `font_draw_fg_color` | `db` | Font foreground colour byte (low byte of colour pair) |
| `0xDBE5` | `font_draw_bg_color` | `db` | Font background colour byte; 0 = transparent |
| `0xDC6C` | `frame_tasks` | — | Per-frame task queue (see `clear_frame_tasks` at `cs1:0x00B6`) |

### Audio

| Offset | Label | Type | Notes |
|--------|-------|------|-------|
| `0x3810` | `music_playlist_flags` | `db` | Music playback flags; set to 0 at game start |
| `0x3975` | `MIDI_Reset` | `dw` | Near pointer to MIDI reset vtable entry |
| `0x3977` | `data_03977` | `dw` | Non-zero when audio driver is loaded |
| `0x398D` | `pcm_vtable_reset` | `dw` | Near pointer to PCM reset vtable entry |

### System / Misc

| Offset | Label | Type | Notes |
|--------|-------|------|-------|
| `0xD824` | `_unk_2CCD4_rand_seed` | `dw` | RNG seed word 1 (seeded from BIOS timer at init) |
| `0xD826` | `_unk_2CCD6_rand_seed` | `dw` | RNG seed word 2 |
| `0xD828` | `_unk_2CCD8_bios_timer_count_3` | `dw` | Third BIOS timer snapshot used for RNG |
| `0xDD1D` | `top_of_mem` | `dw` | Top-of-memory paragraph used at startup |

## Adding New Offsets

When a newly implemented function accesses an unnamed `data_XXXXX` label, look it up in `cryo-dune-3.7-cd-dncdprg.chani.htm` by searching for `id="seg001-XXXX"` (lowercase hex, no leading zeros beyond 4 digits). Add the offset to this file with its label and a brief note.
