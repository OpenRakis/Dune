# Missing Functions - Follow-Up Plan

> 210 functions are named in `fn_addresses.md` but have no C# override stub.
> These were never observed executing during the Spice86 discovery run, so no
> `DefineFunction` entry was generated. They must be reverse-engineered manually
> from the binary disassembly before they can be overridden in C#.

## Sources

| File | Content |
|------|---------|
| `spice86dumpListing.asm` | Full instruction listing (29 388 lines, segments 100D/3358/5642/5BAE/F000) |
| `spice86dumpCfgBlocks.json` | 10 658 CFG blocks with pred/succ edges and assembly bytes |
| `spice86dumpExecutionFlow.json` | 3 257 call sites, 4 206 jump sites, 29 164 executed instructions |
| `spice86dumpMemoryDump.bin` | 1 114 095-byte raw memory image |
| `cryo-dune-3.7-cd-dncdprg.chani.htm` | Full disassembly with labels and comments |

## How to Implement

For each function below:

1. Locate the function in `cryo-dune-3.7-cd-dncdprg.chani.htm` by its address
2. Read the disassembly, understand the logic, and the comments
3. Use the listing snippet and CFG block below as quick reference
4. Create the C# override in the appropriate `CfgGeneratedOverrides.PartNNN.cs` file
5. Add a `DefineFunction` entry in `CfgGeneratedOverrides.Base.cs`
6. Build and test

---

## book_screen.rs (3 functions)

### `menu_callback_choice_book_topic` — seg000:AF58

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AF58 menu_callback_choice_book_topic
  mov BX,0
  mov BP,0
  jmp short 0xAF76
  mov BX,0x041C
  mov BP,4
  jmp short 0xAF76
  mov BX,0x081C
  mov BP,8
  jmp short 0xAF76
  mov BX,0x0C1C
  mov BP,0x000C
  push BP
  test byte ptr DS:[0x00C6],2
  jne short 0xAF86
  push BX
  call near 0x0A3E
  call near 0xB024
  pop BX
  call near 0xB147
  pop BP
  je short 0xAFC6
  mov word ptr DS:[0x2406],BX
  mov AX,0x00A8
  test byte ptr DS:[0x00C6],2
  je short 0xAF9D
  add AX,2
  mov word ptr DS:[0x11BF],AX
  mov SI,0x2034
  mov CX,4
  push SI
  and word ptr DS:[SI],0x7FFF
  add SI,4
  loop 0xAFA7
  pop SI
  or word ptr SS:[BP+SI],0x8000
  mov CX,1
  mov DX,2
  test byte ptr DS:[0x00C6],2
  je short 0xAFE6
  xor DX,DX
```

**Calls:** 0x0A3E, 0xB024, 0xB147

**CFG Block:**
- ID: 39529
- Entry: 100D:AF58, Term: 100D:AF5E
- Preds: [15411], Succs: [16477]

---

### `callback_ui_element_book_close` — seg000:B18B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B18B callback_ui_element_book_close
  call near 0xADBE
  mov byte ptr DS:[0x2788],0
  mov byte ptr DS:[0x00C6],0
  mov byte ptr DS:[0x1C30],0
  call near 0xCA01
  call near 0x0A3E
  call near 0x9901
  mov AX,0x0026
  call near 0xC13E
  jmp near 0x1877
  push DX
  call near 0xC08E
  call near 0xC137
  mov AX,0x000B
  or DX,DX
  js short 0xB1BE
  dec AX
  mov BX,0x009E
  mov DX,0x001B
  push AX
  call near 0xC2FD
  mov AX,0x000A
  call near 0xE387
  pop AX
  inc AX
  cmp AX,0x000B
  je short 0xB1D8
  sub AX,2
  call near 0xC22F
  mov AX,0x000A
  call near 0xE387
  mov SI,0x1AF4
  mov CX,1
  call near 0xD1F2
  pop DX
  jmp near 0xC07C
  call far dword ptr DS:[0x3959]
  call near 0xAEB7
  mov byte ptr DS:[0xDC2B],1
  mov AL,0x34
```

**Calls:** 0xADBE, 0xCA01, 0x0A3E, 0x9901, 0xC13E, 0xC08E, 0xC137, 0xC2FD, 0xE387, 0xC22F, 0xE387, 0xD1F2, indirect, 0xAEB7

**Called from:** 100D:ADBE

**CFG Block:**
- ID: 17392
- Entry: 100D:B18B, Term: 100D:B18B
- Preds: [15411], Succs: [14423, 17394]

---

### `handle_ctrl_v_once` — seg000:B270

**Status:** Never executed during discovery.

---

## dialogue.rs (9 functions)

### `dialogue_event_0f_duncan_idaho` — seg000:24A3

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:24A3 dialogue_event_0f_duncan_idaho
  cmp byte ptr DS:[0x002A],0x10
  jae short 0x24B0
  or byte ptr DS:[0x0FF7],0x10
  ret near
```

**CFG Block:**
- ID: 26940
- Entry: 100D:24A3, Term: 100D:24A8
- Preds: [26938], Succs: [26943, 33247]

---

### `common_dialogue` — seg000:93AA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:93AA common_dialogue
  xor AH,AH
  mov word ptr DS:[0x47E1],0
  push AX
  mov word ptr DS:[0x47C4],AX
  call near 0x91A0
  call near 0x3AF9
  call near 0x9197
  call near 0x9908
  mov SI,word ptr DS:[0x47C8]
  mov word ptr DS:[0x4540],0
  call near 0x9BAC
  call near 0x1834
  call near 0xC0F4
  call near 0xC4DD
  pop AX
  call near 0x93DF
  jmp near 0x9472
  mov CL,AL
  shl AL,1
  shl AL,1
  shl AL,1
  mov word ptr DS:[0x47BE],AX
  mov AX,1
  shl AX,CL
  or word ptr DS:[0x000E],AX
  or word ptr DS:[0x0014],AX
  mov AL,0x10
  mul CL
  add AX,0x0FD8
  mov word ptr DS:[0x47A2],AX
  mov SI,AX
  mov word ptr DS:[0x47BA],0
  call near 0x90BD
  mov word ptr DS:[0x47B6],0
  mov byte ptr DS:[0x47C2],0x80
  mov byte ptr DS:[0x0019],0
  ret near
```

**Calls:** 0x91A0, 0x3AF9, 0x9197, 0x9908, 0x9BAC, 0x1834, 0xC0F4, 0xC4DD, 0x93DF, 0x90BD

**CFG Block:**
- ID: 15416
- Entry: 100D:93AA, Term: 100D:93B6
- Preds: [15413, 20398, 23067, 23174, 26928, 27012, 32040, 33284, 33493, 33902, 34587, 35317, 38273, 38377], Succs: [7853, 15422]

---

### `menu_callback_choice_talk_to_me` — seg000:9472

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9472 menu_callback_choice_talk_to_me
  call near 0x9F40
  mov byte ptr DS:[0x226D],0x0A
  mov byte ptr DS:[0x001B],0
  cmp word ptr DS:[0x47B6],0
  jne short 0x94DD
  mov SI,word ptr DS:[0x47BA]
  or SI,SI
  jne short 0x949A
  mov SI,word ptr DS:[0x47BE]
  mov AX,SI
  shl SI,1
  mov SI,word ptr DS:[SI-21898]
  cmp SI,-1
  je short 0x94B9
  call near 0x9B49
  call near 0x9F9E
  mov word ptr DS:[0x47BA],SI
  jae short 0x94DA
  mov AX,word ptr DS:[0x47BE]
  inc AX
  mov word ptr DS:[0x47BE],AX
  mov SI,AX
  and AX,3
  jne short 0x9492
  cmp word ptr DS:[0x47C4],0x000D
  je short 0x94C3
  jmp near 0xD2E2
  cmp SI,-1
  jne short 0x94CC
  mov SI,word ptr DS:[0x47BE]
  and SI,-8
  mov word ptr DS:[0x47BE],SI
  mov byte ptr DS:[0x47C2],0x20
  jmp short 0x9492
  jmp near 0xD280
  lds SI,word ptr DS:[0x47B6]
  call near 0x88D2
  mov SI,word ptr DS:[0x47BA]
  add word ptr DS:[0x4780],0x1000
  call near 0xA03F
```

**Calls:** 0x9F40, 0x9B49, 0x9F9E, 0x88D2, 0xA03F

**Called from:** 100D:9F40

**CFG Block:**
- ID: 15582
- Entry: 100D:9472, Term: 100D:9472
- Preds: [15411, 15580, 33013, 38385], Succs: [15584, 15604]

---

### `menu_callback_choice_stay_here` — seg000:9533

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9533 menu_callback_choice_stay_here
  call near 0xA1C4
  mov AX,6
  call near 0x9F31
  call near 0x9F8B
  inc byte ptr DS:[0x001B]
  call near 0xA1E2
  jne short 0x956C
  mov SI,word ptr DS:[0x47A2]
  call near 0x1E01
  jae short 0x9556
  add byte ptr DS:[0x00F9],0x10
  and byte ptr DS:[SI+0x0F],0xBF
  mov BX,2
  call near 0x956D
  mov CL,byte ptr DS:[SI+0x0E]
  mov AX,0xFFFE
  rol AX,CL
  and word ptr DS:[0x0010],AX
  ret near
```

**Calls:** 0xA1C4, 0x9F31, 0x9F8B, 0xA1E2, 0x1E01, 0x956D

**Called from:** 100D:A1C4

**CFG Block:**
- ID: 25902
- Entry: 100D:9533, Term: 100D:9533
- Preds: [15411], Succs: [16172, 25904]

---

### `menu_callback_choice_come_with_me_troop` — seg000:95C1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:95C1 menu_callback_choice_come_with_me_troop
  mov AX,0x0064
  cmp word ptr DS:[0x00AC],0x03E8
  jb short 0x95DE
  sub AL,byte ptr DS:[0x0029]
  jb short 0x95DE
  shr AL,1
  shr AL,1
  cmp AL,byte ptr DS:[0x0036]
  jbe short 0x95DE
  mov AH,2
  mov byte ptr DS:[0x0023],AH
  call near 0xA1C4
  mov AX,5
  call near 0x9F31
  call near 0x9F8B
  inc byte ptr DS:[0x001B]
  mov byte ptr DS:[0x0023],0
  call near 0xA1E2
  jne short 0x961A
  mov SI,word ptr DS:[0x47A2]
  mov CL,byte ptr DS:[SI+0x0E]
  cmp CL,0x0E
  je short 0x961B
  or byte ptr DS:[SI+0x0F],0x40
  xor BX,BX
  call near 0x956D
  mov AX,1
  shl AX,CL
  or word ptr DS:[0x0010],AX
  ret near
```

**Calls:** 0xA1C4, 0x9F31, 0x9F8B, 0xA1E2, 0x956D

**CFG Block:**
- ID: 23196
- Entry: 100D:95C1, Term: 100D:95CA
- Preds: [15411], Succs: [23200, 23208]

---

### `menu_callback_choice_come_with_me` — seg000:95E2

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:95E2 menu_callback_choice_come_with_me
  call near 0xA1C4
  mov AX,5
  call near 0x9F31
  call near 0x9F8B
  inc byte ptr DS:[0x001B]
  mov byte ptr DS:[0x0023],0
  call near 0xA1E2
  jne short 0x961A
  mov SI,word ptr DS:[0x47A2]
  mov CL,byte ptr DS:[SI+0x0E]
  cmp CL,0x0E
  je short 0x961B
  or byte ptr DS:[SI+0x0F],0x40
  xor BX,BX
  call near 0x956D
  mov AX,1
  shl AX,CL
  or word ptr DS:[0x0010],AX
  ret near
```

**Calls:** 0xA1C4, 0x9F31, 0x9F8B, 0xA1E2, 0x956D

**Called from:** 100D:A1C4

**CFG Block:**
- ID: 16170
- Entry: 100D:95E2, Term: 100D:95E2
- Preds: [15411, 23208], Succs: [16172, 16175]

---

### `menu_callback_choice_what` — seg000:9ED5

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9ED5 menu_callback_choice_what
  cmp word ptr DS:[0x47C4],0x0010
  jae short 0x9EEB
  call near 0x9985
  cmp byte ptr DS:[0x47E1],0x81
  jne short 0x9EEB
  call near 0xC85B
  mov AL,byte ptr DS:[0x47DD]
  mov byte ptr DS:[0x47DC],AL
  call near 0x9EFD
  mov byte ptr DS:[0x47DC],0
  ret near
```

**Calls:** 0x9985, 0xC85B, 0x9EFD

**CFG Block:**
- ID: 16217
- Entry: 100D:9ED5, Term: 100D:9EDA
- Preds: [15411, 41155], Succs: [16220, 16225]

---

### `dispatch_dialogue_line_event` — seg000:A049

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A049 dispatch_dialogue_line_event
  mov AL,byte ptr DS:[SI]
  and AL,0x0F
  je short 0xA05E
  xor AH,AH
  push SI
  dec AX
  shl AX,1
  mov BX,0xA107
  add BX,AX
  call near word ptr CS:[BX]
  pop SI
  mov AL,byte ptr DS:[SI+2]
  and AL,0x0C
  je short 0xA092
  test byte ptr DS:[SI],0x80
  jne short 0xA092
  mov AX,SI
  sub AX,0xAA78
  shr AX,1
  shr AX,1
  mov BL,byte ptr DS:[0x47C4]
  shl BL,1
  shl BL,1
  shl BL,1
  or AH,BL
  mov BP,word ptr DS:[0x11BD]
  mov word ptr CS:[BP],AX
  mov word ptr CS:[BP+2],0
  add word ptr DS:[0x11BD],2
  mov byte ptr DS:[0x0019],0xFF
  or byte ptr DS:[SI],0x80
  add SI,4
  xor AL,AL
  xchg AL,byte ptr DS:[0x47A8]
  or AL,AL
  je short 0xA0AA
  mov SI,0xFFFF
  cmp byte ptr DS:[0x46EB],0
  jne short 0xA0E2
  cmp word ptr DS:[0x47C4],0x0010
```

**CFG Block:**
- ID: 3251
- Entry: 100D:A049, Term: 100D:A04D
- Preds: [3248], Succs: [3255, 16190]

---

### `mark_spoken` — seg000:A097

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A097 mark_spoken
  or byte ptr DS:[SI],0x80
  add SI,4
  xor AL,AL
  xchg AL,byte ptr DS:[0x47A8]
  or AL,AL
  je short 0xA0AA
  mov SI,0xFFFF
  cmp byte ptr DS:[0x46EB],0
  jne short 0xA0E2
  cmp word ptr DS:[0x47C4],0x0010
  jae short 0xA0E2
  push SI
  call near 0x978E
  pop SI
  cmp byte ptr DS:[0x4774],0
  je short 0xA0C9
  push SI
  call near 0x2EBF
  pop SI
  cmp byte ptr DS:[0x00EA],0
  jg short 0xA0E2
  call near 0xE270
  call near 0x9EFD
  mov AX,0x0F66
  xchg AX,word ptr DS:[0x227E]
  call near AX
  call near 0xE283
  cmp byte ptr DS:[0x00FB],0
  js short 0xA0EF
  mov AL,byte ptr DS:[0x28E8]
  mov byte ptr DS:[0x28E7],AL
  clc
  ret near
```

**Calls:** 0x978E, 0x2EBF, 0xE270, 0x9EFD, 0xE283

---

## events.rs (3 functions)

### `randomly_increase_all_harkonnen_troops_head_count` — seg000:1D10

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:1D10 randomly_increase_all_harkonnen_troops_head_count
  rol word ptr DS:[0],1
  jae short 0x1D34
  mov SI,0x08AA
  test byte ptr DS:[SI+0x10],0x80
  je short 0x1D2B
  mov AL,byte ptr DS:[SI+0x1A]
  dec AL
  cmp AL,0xC7
  jae short 0x1D2B
  inc byte ptr DS:[SI+0x1A]
  add SI,0x001B
  cmp SI,0x0FA0
  jb short 0x1D19
  ret near
```

**CFG Block:**
- ID: 26009
- Entry: 100D:1D10, Term: 100D:1D14
- Preds: [26007], Succs: [26012, 32136]

---

### `actions_time_in_day_4` — seg000:1F64

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:1F64 actions_time_in_day_4
  cmp byte ptr DS:[0x002A],0x3C
  jae short 0x1F79
  mov AX,word ptr DS:[2]
  sub AX,word ptr DS:[0x1154]
  jb short 0x1F91
  cmp AX,0x0070
  jb short 0x1F91
  test word ptr DS:[2],0x0010
  jne short 0x1F91
  xor AL,AL
  xchg AL,byte ptr DS:[0x11BC]
  or AL,AL
  jne short 0x1F91
  rol word ptr DS:[0],1
  jb short 0x1F92
  ret near
```

**CFG Block:**
- ID: 22436
- Entry: 100D:1F64, Term: 100D:1F69
- Preds: [22434], Succs: [22439, 34084]

---

### `actions_time_in_day_3` — seg000:20A4

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:20A4 actions_time_in_day_3
  test byte ptr DS:[0x00BF],0x80
  je short 0x20D1
  call near 0x1AC5
  cmp byte ptr DS:[0x00C2],0
  jne short 0x2098
  test byte ptr DS:[0x00BF],0x10
  jne short 0x2131
  cmp byte ptr DS:[0x11BB],0
  je short 0x20C6
  sub AX,word ptr DS:[0x118D]
  je short 0x20D2
  neg AX
  mov byte ptr DS:[0x00CF],AL
  ret near
```

**Calls:** 0x1AC5

**CFG Block:**
- ID: 15157
- Entry: 100D:20A4, Term: 100D:20A9
- Preds: [15155], Succs: [15160, 33334]

---

## font.rs (1 functions)

### `draw_glyph` — segvga:1BF5

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

## game_state.rs (4 functions)

### `start` — seg000:0000

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0000 start
  mov AX,0xDD1D
  call near 0xE4AD
  call near 0xE594
  call near 0x00B0
  sti
  call near 0x0580
  call near 0x0309
  call near 0x021C
  call near 0xAEB7
  mov byte ptr DS:[0x3810],0
  mov word ptr DS:[2],2
  call near 0x0083
  mov CL,0xFF
  call near 0xB389
  call near 0x1860
  mov byte ptr DS:[0xCE80],0xFF
  call near 0xB2BE
  call near 0xD815
  cld
  xor AX,AX
  int 0x33
  mov AX,0x1F58
  mov DS,AX
  call near 0xE8D5
  cmp word ptr DS:[0x3977],0
  je short 0x0056
  call far dword ptr DS:[0x3975]
  call far dword ptr DS:[0x398D]
  mov AX,3
  int 0x10
  mov SI,word ptr DS:[0x3CBC]
  or SI,SI
  je short 0x006E
  mov AX,0x0E0D
  int 0x10
  mov AX,0x0E0A
  int 0x10
  mov DL,0xFF
  mov AX,0x0C06
  int 0x21
```

**Calls:** 0xE4AD, 0xE594, 0x00B0, 0x0580, 0x0309, 0x021C, 0xAEB7, 0x0083, 0xB389, 0x1860, 0xB2BE, 0xD815, 0xE8D5, indirect, indirect

**CFG Block:**
- ID: 2
- Entry: 100D:0000, Term: 100D:0003
- Preds: [], Succs: [4, 121]

---

### `decode_sd_block` — seg000:AA48

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AA48 decode_sd_block
  les DI,word ptr DS:[0x3819]
  mov CX,word ptr DS:[0x3815]
  push DS
  lds SI,word ptr DS:[0x3811]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  mov AL,0x80
  rep stos byte ptr ES:[DI],AL
  pop DS
  mov SI,0x3819
  mov word ptr DS:[0x3824],SI
  call far dword ptr DS:[0x3991]
  mov SI,0x3811
  call far dword ptr DS:[0x39A1]
  ret near
```

**Calls:** indirect, indirect

---

### `draw_sprite_at_clipped` — seg000:C327

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:C327 draw_sprite_at_clipped
  call far dword ptr SS:[0x38CD]
  push SS
  pop DS
  ret near
```

**Calls:** indirect

**Called from:** 3358:0112

---

### `advance_game_clock` — seg000:EF84

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:EF84 advance_game_clock
  cmp byte ptr DS:[0x2788],0
  jne short 0xEF9F
  dec word ptr DS:[0x46DB]
  jns short 0xEF9F
  mov AX,word ptr DS:[0x146E]
  mov word ptr DS:[0x46DB],AX
  inc word ptr DS:[2]
  inc byte ptr DS:[0x46DD]
  call near 0xEFBA
  pop ES
  dec byte ptr DS:[0xCE72]
  js short 0xEFD5
  mov AL,0x20
  out 0x20,AL
  cmp byte ptr DS:[0xDBB5],0
  je short 0xEFB7
  call near 0xCEC9
  pop DS
  pop AX
  iret
  push BX
  test byte ptr DS:[0x2943],0x10
  jne short 0xEFD3
  push CX
  call far dword ptr DS:[0x3981]
  mov byte ptr DS:[0xDBCD],AL
  mov word ptr DS:[0xDBCE],BX
  mov word ptr DS:[0xDBD0],CX
  pop CX
  pop BX
  ret near
```

**Calls:** 0xEFBA, 0xCEC9, indirect

**CFG Block:**
- ID: 929
- Entry: 100D:EF84, Term: 100D:EF89
- Preds: [926, 10012], Succs: [932, 14930]

---

## game_ui.rs (7 functions)

### `draw_game_ui` — seg000:0086

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0086 draw_game_ui
  call near 0xC07C
  call near 0xC0AD
  mov SI,0x1AE4
  mov BP,0xD1EF
  call near 0xC097
  jmp near 0x1797
  mov CX,word ptr ES:[DI]
  shr CX,1
  mov BX,DI
  mov AX,word ptr ES:[DI]
  add AX,BX
  stos word ptr ES:[DI],AX
  loop 0x009F
  ret near
```

**Calls:** 0xC07C, 0xC0AD, 0xC097

**Called from:** 100D:C07C

**CFG Block:**
- ID: 12987
- Entry: 100D:0086, Term: 100D:0086
- Preds: [12972, 12982], Succs: [2704, 12989]

---

### `ui_enter_room_view_tail` — seg000:1877

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:1877 ui_enter_room_view_tail
  call near 0xD2BD
  call near 0x5ADF
  mov AL,byte ptr DS:[0x28E8]
  mov byte ptr DS:[0x28E7],AL
  call near 0xB930
  mov word ptr DS:[0x1C14],0x0080
  mov word ptr DS:[0x1C22],0x0080
  mov BP,0xD75A
  call near 0xC097
  mov AL,0x34
  mov BP,0x2DB1
  cmp byte ptr DS:[0x46D9],0
  je short 0x18A6
  jmp near BP
  xor DX,DX
  call near 0xC108
  call near 0xC07C
  call near 0xAE04
  mov AX,word ptr DS:[0xCE7A]
  mov word ptr DS:[0xDC5A],AX
  jmp near 0x17E6
  mov word ptr DS:[0x1C06],0
  mov word ptr DS:[0x1C14],0
  mov word ptr DS:[0x1C22],0
  call near 0x39E6
  call near 0xAC30
  call near 0x4D00
  call near 0xD2BD
  call near 0x4ACA
  call near 0x98E6
  mov byte ptr DS:[0x46DF],0
  cmp byte ptr DS:[0x002B],0
  je short 0x18ED
  call near 0x0B21
  ret near
```

**Calls:** 0xD2BD, 0x5ADF, 0xB930, 0xC097, 0xC108, 0xC07C, 0xAE04, 0x39E6, 0xAC30, 0x4D00, 0xD2BD, 0x4ACA, 0x98E6, 0x0B21

**Called from:** 100D:D2BD

**CFG Block:**
- ID: 13219
- Entry: 100D:1877, Term: 100D:1877
- Preds: [13216, 17406], Succs: [13221, 13234]

---

### `ui_draw_date_and_time_indicator_sprite` — seg000:1A42

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:1A42 ui_draw_date_and_time_indicator_sprite
  mov AX,word ptr DS:[2]
  and AX,0x000F
  shl AX,1
  shl AX,1
  shl AX,1
  add AX,0x1E7E
  mov SI,AX
  mov AX,0x004A
  call near 0x1A9B
  mov AX,0x004B
  call near 0x1A9B
  call near 0xD075
  mov word ptr DS:[0xDBE4],0xF1FA
  call near 0x1AD1
  mov BX,0x016D
  add AX,BX
  sub AX,BX
  cmp AX,BX
  jae short 0x1A70
  inc AX
  mov DX,0x000B
  mov BX,0x00BE
  cmp AX,0x0064
  jae short 0x1A8D
  sub DL,2
  cmp AX,0x000A
  jae short 0x1A8D
  sub DL,2
  call near 0xE290
  mov AL,0x20
  call near word ptr DS:[0x2518]
  pop word ptr DS:[0xDBDA]
  ret near
```

**Calls:** 0x1A9B, 0x1A9B, 0xD075, 0x1AD1, 0xE290

**CFG Block:**
- ID: 13320
- Entry: 100D:1A42, Term: 100D:1A56
- Preds: [737, 13317], Succs: [13330, 13358]

---

### `menu_callback_choice_music_cd_order_cancel` — seg000:D2DF

**Status:** Never executed during discovery.

---

### `game_loop_dispatch_lmb_press` — seg000:D8FE

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D8FE game_loop_dispatch_lmb_press
  cmp SI,word ptr DS:[0x2570]
  jne short 0xD90E
  call near 0xD6B7
  jb short 0xD918
  push SI
  call near 0x9215
  pop SI
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[SI+2]
  jmp near 0xD820
  ret near
```

**Calls:** 0xD6B7, 0x9215

**CFG Block:**
- ID: 15322
- Entry: 100D:D8FE, Term: 100D:D902
- Preds: [15319], Succs: [15325, 29947]

---

### `ui_element_press` — seg000:D918

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D918 ui_element_press
  mov word ptr DS:[0xDC60],DI
  call near 0xD65A
  test byte ptr DS:[DI+9],0x40
  je short 0xD92B
  mov word ptr DS:[0xDC5C],DI
  jmp short 0xD935
  mov byte ptr DS:[0xCE9D],0
  mov byte ptr DS:[0xCEBA],0
  mov AX,word ptr DS:[0xCE7A]
  mov word ptr DS:[0xDC5E],AX
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[DI+0x0C]
  jmp near 0xD820
  mov DI,word ptr DS:[0xDC5C]
  mov word ptr DS:[0xDC5C],0
  or DI,DI
  jne short 0xD92B
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[SI+6]
  jmp near 0xD820
  mov AX,0x2572
  mov word ptr DS:[0x2570],AX
  ret near
```

**Calls:** 0xD65A

**CFG Block:**
- ID: 15382
- Entry: 100D:D918, Term: 100D:D91C
- Preds: [15380], Succs: [15385, 15390]

---

### `dispatch_element_with_latch` — seg000:D92B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D92B dispatch_element_with_latch
  mov byte ptr DS:[0xCE9D],0
  mov byte ptr DS:[0xCEBA],0
  mov AX,word ptr DS:[0xCE7A]
  mov word ptr DS:[0xDC5E],AX
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[DI+0x0C]
  jmp near 0xD820
  mov DI,word ptr DS:[0xDC5C]
  mov word ptr DS:[0xDC5C],0
  or DI,DI
  jne short 0xD92B
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[SI+6]
  jmp near 0xD820
  mov AX,0x2572
  mov word ptr DS:[0x2570],AX
  ret near
```

**CFG Block:**
- ID: 15393
- Entry: 100D:D92B, Term: 100D:D930
- Preds: [15390, 16033, 33423], Succs: [28201]

---

## gfx.rs (35 functions)

### `vga_save_palette_to_fade_target` — segvga:0A68

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_swap_palettes` — segvga:0A76

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_draw_cursor` — segvga:1888

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_restore_cursor` — segvga:1940

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_clear_screen` — segvga:19F7

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_grab_rect` — segvga:1C46

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_put_rect` — segvga:1C76

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_blit_shaded` — segvga:23EB

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_draw_landscape` — segvga:2441

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_transition` — segvga:25E7

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_tick` — segvga:276C

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_draw_edge` — segvga:27E6

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_erase_edge` — segvga:2802

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `ripple_edge_op` — segvga:2823

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_kernel` — segvga:28EC

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `ripple_plot` — segvga:29D4

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_dissolve_lfsr_slow` — segvga:2A10

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_dissolve_lfsr_fast` — segvga:2A15

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `dissolve_lfsr_body` — segvga:2A18

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_expanding_box` — segvga:2A68

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_page_turn` — segvga:2AD1

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `page_turn_draw_fold` — segvga:2B56

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `page_turn_fill_forward_band` — segvga:2BAC

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `page_turn_fill_backward_band` — segvga:2C02

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `page_turn_build_rotated_page` — segvga:2C52

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_vertical_curtain` — segvga:2CCA

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_dotted_columns_tall` — segvga:2DC0

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_dotted_columns` — segvga:2DC3

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_spiral` — segvga:2EEA

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `transition_vertical_fold` — segvga:3130

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `panel_solid_fill` — segvga:3280

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `scroll_rect_down_pass` — segvga:33CA

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `scroll_rect_up_pass` — segvga:3429

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `vga_xor_rect_outline_inner` — segvga:3733

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `xor_rect_outline_anim` — segvga:38D8

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

## globe_renderer.rs (1 functions)

### `draw` — segvga:1CB6

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

## globe_screen.rs (3 functions)

### `ui_transition_to_map_interface` — seg000:5A3D

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5A3D ui_transition_to_map_interface
  mov byte ptr DS:[0x00FB],0xFF
  call near 0xC13B
  call far dword ptr DS:[0x3935]
  mov BP,0x5A56
  mov AL,2
  xor DX,DX
  call near 0xC108
  jmp near 0xAE04
  cmp byte ptr DS:[0x46EB],0
  js short 0x5A9A
  call near 0xD2BD
  call near 0x4ACA
  call near 0xB930
  mov SI,0x6B34
  mov BP,0x000F
  call near 0xDA25
  mov SI,0x1482
  mov DI,0x46E3
  call near 0x5B99
  call near 0x5B69
  call near 0x1797
  mov byte ptr DS:[0x46EB],0x80
  call near 0xAD5E
  mov word ptr DS:[0x2786],0xC835
  mov AX,0x5A9A
  mov word ptr DS:[0x46ED],AX
  call near AX
  call near 0xD792
  jmp near 0xD712
  call near 0xC07C
  call near 0x5B8D
  mov AL,0x80
  xchg AL,byte ptr DS:[0x46EB]
  push AX
  call near 0xB6C3
  call near 0xC13B
  call near 0x5DCE
  call near 0x6314
  call near 0xC412
  mov word ptr DS:[0x3CBE],0
```

**Calls:** 0xC13B, indirect, 0xC108, 0xD2BD, 0x4ACA, 0xB930, 0xDA25, 0x5B99, 0x5B69, 0x1797, 0xAD5E, 0xD792, 0xC07C, 0x5B8D, 0xB6C3, 0xC13B, 0x5DCE, 0x6314, 0xC412

**CFG Block:**
- ID: 19717
- Entry: 100D:5A3D, Term: 100D:5A42
- Preds: [19715], Succs: [10211, 19720]

---

### `menu_callback_choice_globe_see_standard_vision` — seg000:B961

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B961 menu_callback_choice_globe_see_standard_vision
  call near 0xB915
  mov byte ptr DS:[0xDD02],0
  jmp short 0xB972
  call near 0xB8F3
  dec byte ptr DS:[0xDD02]
  call near 0xB98B
  jmp short 0xB941
  mov BP,0x4948
  mov ES,word ptr DS:[0xDBD6]
  mov AL,byte ptr DS:[0xDD02]
  lds SI,word ptr DS:[0xDCFE]
  call far dword ptr SS:[0x3911]
  ret near
```

**Calls:** 0xB915, 0xB8F3, 0xB98B, indirect

**Called from:** 100D:B915

**CFG Block:**
- ID: 30558
- Entry: 100D:B961, Term: 100D:B961
- Preds: [15411], Succs: [30560, 30574]

---

### `globe_results_menu_tail` — seg000:B972

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B972 globe_results_menu_tail
  call near 0xB98B
  jmp short 0xB941
  mov BP,0x4948
  mov ES,word ptr DS:[0xDBD6]
  mov AL,byte ptr DS:[0xDD02]
  lds SI,word ptr DS:[0xDCFE]
  call far dword ptr SS:[0x3911]
  ret near
```

**Calls:** 0xB98B, indirect

**Called from:** 100D:B98B

**CFG Block:**
- ID: 30576
- Entry: 100D:B972, Term: 100D:B972
- Preds: [19258, 30574], Succs: [19261, 19333]

---

## hnm/mod.rs (2 functions)

### `hnm_read_header` — seg000:C93C

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:C93C hnm_read_header
  mov AX,word ptr DS:[0xDC00]
  mov word ptr DS:[0xDC02],AX
  call near 0xC921
  mov AX,word ptr DS:[BX]
  mov word ptr DS:[0xDBFE],AX
  lea DX,BX+2
  call near 0xF229
  mov word ptr DS:[0x35A6],BX
  mov word ptr DS:[0xDC04],AX
  mov word ptr DS:[0xDC06],DX
  mov word ptr DS:[0xDC08],CX
  mov word ptr DS:[0xDC0A],BP
  push word ptr DS:[0xDC1A]
  push word ptr DS:[0xDC0C]
  call near 0xCD8F
  jb short 0xC988
  add SI,AX
  jb short 0xC97A
  cmp SI,word ptr DS:[0xCE74]
  jbe short 0xC980
  sub AX,2
  mov CX,AX
  call near 0xCDBF
  pop word ptr DS:[0xDC0C]
  pop word ptr DS:[0xDC1A]
  jb short 0xC9E7
  les SI,word ptr DS:[0xDC0C]
  lods AX,word ptr ES:[SI]
  add AX,SI
  jb short 0xC9A2
  cmp AX,word ptr DS:[0xCE74]
  jbe short 0xC9A4
  mov byte ptr DS:[0xDBB4],0xFF
  call near 0xC1BA
  dec SI
  inc SI
  cmp byte ptr ES:[SI],0xFF
  je short 0xC9AD
  xor BX,BX
  test byte ptr DS:[0xDBFE],4
```

**Calls:** 0xC921, 0xF229, 0xCD8F, 0xCDBF, 0xC1BA

**CFG Block:**
- ID: 2544
- Entry: 100D:C93C, Term: 100D:C942
- Preds: [2535, 22383], Succs: [2485, 2548]

---

### `hnm_lop_queue_bridge` — seg000:CBB8

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:CBB8 hnm_lop_queue_bridge
  test byte ptr DS:[0xDBFE],4
  je short 0xCC09
  jmp near 0xCB00
  add SI,AX
  jb short 0xCC16
  cmp SI,word ptr DS:[0xCE74]
  jbe short 0xCC20
  xor CX,CX
  xchg CX,word ptr DS:[0xDC0C]
  mov word ptr DS:[0xDC18],CX
  sub AX,2
  mov word ptr DS:[0xDC20],AX
  inc word ptr DS:[0xDBEA]
  ret near
```

---

## input.rs (2 functions)

### `pause_draw_window` — seg000:DEAC

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:DEAC pause_draw_window
  mov SI,0x2945
  call near 0x7B1B
  mov CX,0xF1FE
  mov DX,0x0082
  mov BX,0x00A9
  mov AX,0x0115
  call near 0xD068
  call near 0xD194
  call near 0xD075
  mov DX,0x0060
  mov BX,0x00B8
  mov AX,0x0116
  mov CX,0xF1F7
  call near 0xD194
  cmp byte ptr DS:[0xCE9A],0
  jne short 0xDED6
  call near 0xDE68
  call near 0xDD5A
  je short 0xDEE0
  push AX
  call near 0xDE68
  call near 0xDF07
  pop AX
  dec AL
  je short 0xDEE0
  pop word ptr DS:[0xDBD6]
  pop word ptr DS:[0xDBDA]
  pop word ptr DS:[0xCE7A]
  pop AX
  mov byte ptr DS:[0x2788],AL
  call near 0xE283
  xor AX,AX
  ret near
```

**Calls:** 0x7B1B, 0xD068, 0xD194, 0xD075, 0xD194, 0xDE68, 0xDD5A, 0xDE68, 0xDF07, 0xE283

---

### `clear_keyboard_array` — seg000:F08E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:F08E clear_keyboard_array
  push ES
  push DS
  pop ES
  xor AX,AX
  mov byte ptr DS:[0xCEE8],AL
  mov DI,0xCE81
  mov CX,0x0067
  rep stos byte ptr ES:[DI],AL
  pop ES
  ret near
```

**CFG Block:**
- ID: 40430
- Entry: 100D:F08E, Term: 100D:F09F
- Preds: [40428], Succs: [40453, 40465]

---

## intro_cd.rs (4 functions)

### `stage_01_init` — seg000:0345

**Status:** Never executed during discovery.

---

### `stage_01_play` — seg000:034B

**Status:** Never executed during discovery.

---

### `stage_39_init` — seg000:050D

**Status:** Never executed during discovery.

---

### `load_sunrs_palette_to_fade_target` — seg000:0847

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0847 load_sunrs_palette_to_fade_target
  call near 0x0820
  mov CX,0x00F0
  mov BX,0x0180
  call far dword ptr DS:[0x394D]
  jmp near 0x391D
  mov AX,9
  jmp near 0xC13E
  mov SI,0x0826
  mov BP,9
  call near 0xDA25
  clc
  ret near
```

**Calls:** 0x0820, indirect, 0xDA25

**Called from:** 100D:0820

---

## intro_floppy.rs (4 functions)

### `intro_floppy_play_cutscenes` — seg000:0228

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0228 intro_floppy_play_cutscenes
  call near 0xAD50
  mov AX,0x03E8
  mov SI,1
  push SI
  mov BP,0x02C1
  call near 0xC102
  call near 0xADE0
  pop AX
  push AX
  call near 0xAB4F
  pop SI
  call near 0xDE54
  je short 0x0292
  push SI
  mov AX,0x0320
  mov AX,0x0FA0
  call near 0xDDB0
  pushf
  call near 0x0911
  call near 0xAC14
  call near 0xADED
  popf
  pop SI
  je short 0x0292
  inc SI
  cmp SI,8
  jbe short 0x0231
  mov BP,0x0301
  mov AL,0x10
  call near 0xC108
  mov AX,0x00C8
  call near 0xDDB0
  mov BL,0x0C
  call near 0x38F1
  mov byte ptr DS:[0x46DF],1
  mov AX,0x04B0
  call near 0xDDB0
  call near 0x3950
  mov byte ptr DS:[0x46DF],0
  mov BP,0xC0AD
```

**Calls:** 0xAD50, 0xC102, 0xADE0, 0xAB4F, 0xDE54, 0xDDB0, 0x0911, 0xAC14, 0xADED, 0xC108, 0xDDB0, 0x38F1, 0xDDB0, 0x3950

**Called from:** 100D:AD50

**CFG Block:**
- ID: 11593
- Entry: 100D:0228, Term: 100D:0228
- Preds: [11589], Succs: [11541, 11595]

---

### `intro_floppy_night_to_day_sky_fade` — seg000:0264

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0264 intro_floppy_night_to_day_sky_fade
  mov BP,0x0301
  mov AL,0x10
  call near 0xC108
  mov AX,0x00C8
  call near 0xDDB0
  mov BL,0x0C
  call near 0x38F1
  mov byte ptr DS:[0x46DF],1
  mov AX,0x04B0
  call near 0xDDB0
  call near 0x3950
  mov byte ptr DS:[0x46DF],0
  mov BP,0xC0AD
  mov AL,0x10
  call near 0xC108
  mov ES,word ptr DS:[0xDBD8]
  call far dword ptr DS:[0x38D5]
  call near 0xAC14
  mov byte ptr DS:[0x227D],0
  mov byte ptr DS:[0x00C5],0
  call near 0x0911
  mov byte ptr DS:[0x28E7],0
  mov byte ptr DS:[0xDBE6],6
  inc byte ptr DS:[0x0115]
  mov DX,0x200A
  mov BX,0x0180
  jmp near 0x08F0
  push SI
  call near 0xC0AD
  add SI,SI
  mov BP,word ptr CS:[SI+0x020A]
  call near BP
  pop AX
  add AX,0x0117
  call near 0xD068
  call near 0x9901
  call near 0x88AF
  jmp near 0x9901
  xor CX,CX
  jmp near 0x0A44
```

**Calls:** 0xC108, 0xDDB0, 0x38F1, 0xDDB0, 0x3950, 0xC108, indirect, 0xAC14, 0x0911, 0xC0AD, 0xD068, 0x9901, 0x88AF

**CFG Block:**
- ID: 12911
- Entry: 100D:0264, Term: 100D:0269
- Preds: [12359], Succs: [4484, 12920]

---

### `intro_floppy_post_setup` — seg000:0292

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0292 intro_floppy_post_setup
  mov ES,word ptr DS:[0xDBD8]
  call far dword ptr DS:[0x38D5]
  call near 0xAC14
  mov byte ptr DS:[0x227D],0
  mov byte ptr DS:[0x00C5],0
  call near 0x0911
  mov byte ptr DS:[0x28E7],0
  mov byte ptr DS:[0xDBE6],6
  inc byte ptr DS:[0x0115]
  mov DX,0x200A
  mov BX,0x0180
  jmp near 0x08F0
  push SI
  call near 0xC0AD
  add SI,SI
  mov BP,word ptr CS:[SI+0x020A]
  call near BP
  pop AX
  add AX,0x0117
  call near 0xD068
  call near 0x9901
  call near 0x88AF
  jmp near 0x9901
  xor CX,CX
  jmp near 0x0A44
  mov CX,0x0020
  call near 0x02E0
  call near 0xB8A7
  call near 0xB85A
  mov AX,0x002C
  call near 0xC13E
  jmp near 0xB8EA
  jmp near 0x07EE
  jmp near 0x09AD
  jmp near 0x076A
  call near 0xC0AD
  mov AL,0x1B
  jmp near 0xC2F2
  je short 0x0331
  call near 0xDE4E
```

**Calls:** indirect, 0xAC14, 0x0911, 0xC0AD, 0xD068, 0x9901, 0x88AF, 0x02E0, 0xB8A7, 0xB85A, 0xC13E, 0xC0AD, 0xDE4E

**CFG Block:**
- ID: 12946
- Entry: 100D:0292, Term: 100D:0296
- Preds: [4694, 11589, 12356, 12941], Succs: [2713, 12949]

---

### `measure_line` — seg000:8EDA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:8EDA measure_line
  lods AL,byte ptr DS:[SI]
  cmp AL,0x20
  je short 0x8F25
  cmp AL,0x0D
  je short 0x8F25
  or AL,AL
  je short 0x8EED
  cmp AL,9
  jb short 0x8F09
  js short 0x8F25
  cmp word ptr DS:[0x2518],0xD0FF
  jne short 0x8F04
  cmp SI,0xA6B1
  jne short 0x8F04
  call near 0xD0E3
  jb short 0x8F04
  add CL,AL
  jmp short 0x8EDA
  xlat byte ptr DS:[BX+AL]
  add CL,AL
  jmp short 0x8EDA
  cmp AL,0x0D
  je short 0x8F25
  cmp AL,6
  je short 0x8F1D
  cmp AL,8
  jne short 0x8EDA
  mov word ptr DS:[0x47A0],0xCEEC
  jmp short 0x8EDA
  mov word ptr DS:[0x47A0],0xCF6C
  jmp short 0x8EDA
  dec SI
  pop BX
  ret near
```

**Calls:** 0xD0E3

**CFG Block:**
- ID: 11918
- Entry: 100D:8EDA, Term: 100D:8EDD
- Preds: [11894, 11915, 16683, 27460, 31996], Succs: [11901, 11920]

---

## language.rs (1 functions)

### `phrase_dictionary` — seg000:CF88

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:CF88 phrase_dictionary
  mov BX,word ptr ES:[BX]
  mov BX,word ptr ES:[BX-2]
  mov word ptr DS:[0x47B4],BX
  pop BX
  ret near
```

---

## map_renderer.rs (6 functions)

### `draw` — segvga:1F4C

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `interpolate_horizontal_line` — segvga:2025

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `read_map_pixel` — segvga:206A

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `interpolate_vertically` — segvga:2123

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `post_process` — segvga:22A0

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `copy_to_framebuffer` — segvga:230A

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

## messages.rs (9 functions)

### `menu_callback_choice_comms_room_view_new_messages` — seg000:283A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:283A menu_callback_choice_comms_room_view_new_messages
  xor AX,AX
  jmp short 0x2841
  xor AX,AX
  dec AX
  mov byte ptr DS:[0x00DB],AL
  neg AX
  add AL,0x2A
  call near 0xAB45
  call near 0x98B2
  call near 0x2806
  call near 0x2A7F
  call near 0x3AE9
  mov byte ptr DS:[0x00E9],0
  push DS
  pop ES
  mov DI,0x1FC3
  xor AL,AL
  stos byte ptr ES:[DI],AL
  mov SI,0x1179
  xor CX,CX
  mov CL,byte ptr DS:[0x00C8]
  add SI,CX
  add SI,CX
  mov BL,byte ptr DS:[0x00DB]
  sub SI,2
  mov AX,word ptr DS:[SI]
  mov AH,AL
  xor AH,BL
  js short 0x288B
  and AX,0x003F
  add AX,0x0078
  stos word ptr ES:[DI],AX
  mov AX,0x290B
  stos word ptr ES:[DI],AX
  loop 0x2875
  mov AX,0x00A3
  stos word ptr ES:[DI],AX
  mov AX,0x29D4
  stos word ptr ES:[DI],AX
  xor AX,AX
```

**Calls:** 0xAB45, 0x98B2, 0x2806, 0x2A7F, 0x3AE9

**CFG Block:**
- ID: 31599
- Entry: 100D:283A, Term: 100D:283C
- Preds: [15411], Succs: [31602]

---

### `menu_callback_choice_comms_room_messages_already_seen` — seg000:283E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:283E menu_callback_choice_comms_room_messages_already_seen
  xor AX,AX
  dec AX
  mov byte ptr DS:[0x00DB],AL
  neg AX
  add AL,0x2A
  call near 0xAB45
  call near 0x98B2
  call near 0x2806
  call near 0x2A7F
  call near 0x3AE9
  mov byte ptr DS:[0x00E9],0
  push DS
  pop ES
  mov DI,0x1FC3
  xor AL,AL
  stos byte ptr ES:[DI],AL
  mov SI,0x1179
  xor CX,CX
  mov CL,byte ptr DS:[0x00C8]
  add SI,CX
  add SI,CX
  mov BL,byte ptr DS:[0x00DB]
  sub SI,2
  mov AX,word ptr DS:[SI]
  mov AH,AL
  xor AH,BL
  js short 0x288B
  and AX,0x003F
  add AX,0x0078
  stos word ptr ES:[DI],AX
  mov AX,0x290B
  stos word ptr ES:[DI],AX
  loop 0x2875
  mov AX,0x00A3
  stos word ptr ES:[DI],AX
  mov AX,0x29D4
  stos word ptr ES:[DI],AX
  xor AX,AX
  stos word ptr ES:[DI],AX
  mov BP,0x1FC2
```

**Calls:** 0xAB45, 0x98B2, 0x2806, 0x2A7F, 0x3AE9

**CFG Block:**
- ID: 38314
- Entry: 100D:283E, Term: 100D:2840
- Preds: [15411], Succs: [31602]

---

### `comm_open_message_list` — seg000:2841

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2841 comm_open_message_list
  mov byte ptr DS:[0x00DB],AL
  neg AX
  add AL,0x2A
  call near 0xAB45
  call near 0x98B2
  call near 0x2806
  call near 0x2A7F
  call near 0x3AE9
  mov byte ptr DS:[0x00E9],0
  push DS
  pop ES
  mov DI,0x1FC3
  xor AL,AL
  stos byte ptr ES:[DI],AL
  mov SI,0x1179
  xor CX,CX
  mov CL,byte ptr DS:[0x00C8]
  add SI,CX
  add SI,CX
  mov BL,byte ptr DS:[0x00DB]
  sub SI,2
  mov AX,word ptr DS:[SI]
  mov AH,AL
  xor AH,BL
  js short 0x288B
  and AX,0x003F
  add AX,0x0078
  stos word ptr ES:[DI],AX
  mov AX,0x290B
  stos word ptr ES:[DI],AX
  loop 0x2875
  mov AX,0x00A3
  stos word ptr ES:[DI],AX
  mov AX,0x29D4
  stos word ptr ES:[DI],AX
  xor AX,AX
  stos word ptr ES:[DI],AX
  mov BP,0x1FC2
  mov BX,0x0F66
  jmp near 0xD323
```

**Calls:** 0xAB45, 0x98B2, 0x2806, 0x2A7F, 0x3AE9

**CFG Block:**
- ID: 31602
- Entry: 100D:2841, Term: 100D:2848
- Preds: [31599, 38314], Succs: [21406, 31607]

---

### `menu_callback_comms_message_selected` — seg000:290B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:290B menu_callback_comms_message_selected
  mov AL,byte ptr DS:[0x1FC3]
  cbw
  shr AX,1
  shr AX,1
  add CX,AX
  inc CX
  mov SI,0x1179
  xor AX,AX
  mov AL,byte ptr DS:[0x00C8]
  add SI,AX
  add SI,AX
  sub SI,2
  mov AX,word ptr DS:[SI]
  xor AL,byte ptr DS:[0x00DB]
  js short 0x2922
  loop 0x2922
  mov AX,word ptr DS:[SI]
  mov byte ptr DS:[0x0024],AH
  and AL,0x3F
  cmp byte ptr DS:[0x00DB],0
  jne short 0x2956
  or byte ptr DS:[SI],0x80
  dec byte ptr DS:[0x00C9]
  cmp AL,0x0B
  jne short 0x2956
  sub AH,2
  cmp AH,2
  jae short 0x2956
  or byte ptr DS:[0x00BF],0x20
  xor AH,AH
  cmp AL,byte ptr DS:[0x47A9]
  je short 0x2970
  push AX
  call near 0x28E1
  pop AX
  push AX
  add AX,0x001A
  call near 0xAB45
  pop AX
  push AX
```

**Calls:** 0x28E1, 0xAB45

**CFG Block:**
- ID: 31741
- Entry: 100D:290B, Term: 100D:2920
- Preds: [15411], Succs: [34797]

---

### `menu_callback_choice_comms_room_message_viewed` — seg000:2993

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2993 menu_callback_choice_comms_room_message_viewed
  mov AL,6
  jmp short 0x2999
  xor AL,AL
  mov BL,byte ptr DS:[0x00C9]
  mov byte ptr DS:[0x00EB],BL
  cmp byte ptr DS:[0x47A9],0
  je short 0x2992
  push AX
  call near 0x97CF
  call near 0x98F5
  call near 0xC08E
  call near 0x28B5
  call near 0x28E1
  mov byte ptr DS:[0x0024],0
  pop AX
  mov byte ptr DS:[0x0023],AL
  call near 0xD316
  call near 0x2EB2
  call near 0x2DD3
  cmp byte ptr DS:[0x47A7],0
  jne short 0x2992
  jmp near 0xD280
  mov AX,0x0029
  call near 0xAB45
  mov byte ptr DS:[0x47A6],0xFF
  mov BP,0x2DBF
  call near 0xC097
  call near 0xD316
  call near 0xD280
  jmp near 0xABA9
  xor DI,DI
  test byte ptr DS:[0x000A],1
  je short 0x2A33
  mov SI,0x1190
  mov CL,byte ptr DS:[SI]
  xor CH,CH
  jcxz short 0x2A14
  inc SI
  cmp AX,word ptr DS:[SI]
  jne short 0x2A0A
```

**Calls:** 0x97CF, 0x98F5, 0xC08E, 0x28B5, 0x28E1, 0xD316, 0x2EB2, 0x2DD3, 0xAB45, 0xC097, 0xD316, 0xD280

**CFG Block:**
- ID: 31928
- Entry: 100D:2993, Term: 100D:2995
- Preds: [15411, 37478], Succs: [31931]

---

### `comm_return_to_room` — seg000:2999

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2999 comm_return_to_room
  mov BL,byte ptr DS:[0x00C9]
  mov byte ptr DS:[0x00EB],BL
  cmp byte ptr DS:[0x47A9],0
  je short 0x2992
  push AX
  call near 0x97CF
  call near 0x98F5
  call near 0xC08E
  call near 0x28B5
  call near 0x28E1
  mov byte ptr DS:[0x0024],0
  pop AX
  mov byte ptr DS:[0x0023],AL
  call near 0xD316
  call near 0x2EB2
  call near 0x2DD3
  cmp byte ptr DS:[0x47A7],0
  jne short 0x2992
  jmp near 0xD280
  mov AX,0x0029
  call near 0xAB45
  mov byte ptr DS:[0x47A6],0xFF
  mov BP,0x2DBF
  call near 0xC097
  call near 0xD316
  call near 0xD280
  jmp near 0xABA9
  xor DI,DI
  test byte ptr DS:[0x000A],1
  je short 0x2A33
  mov SI,0x1190
  mov CL,byte ptr DS:[SI]
  xor CH,CH
  jcxz short 0x2A14
  inc SI
  cmp AX,word ptr DS:[SI]
  jne short 0x2A0A
  cmp DI,word ptr DS:[SI+2]
  je short 0x2A33
  add SI,4
```

**Calls:** 0x97CF, 0x98F5, 0xC08E, 0x28B5, 0x28E1, 0xD316, 0x2EB2, 0x2DD3, 0xAB45, 0xC097, 0xD316, 0xD280

**CFG Block:**
- ID: 31931
- Entry: 100D:2999, Term: 100D:29A6
- Preds: [31928, 31983], Succs: [31936, 31984]

---

### `menu_callback_comms_messages_done` — seg000:29D4

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:29D4 menu_callback_comms_messages_done
  mov AX,0x0029
  call near 0xAB45
  mov byte ptr DS:[0x47A6],0xFF
  mov BP,0x2DBF
  call near 0xC097
  call near 0xD316
  call near 0xD280
  jmp near 0xABA9
  xor DI,DI
  test byte ptr DS:[0x000A],1
  je short 0x2A33
  mov SI,0x1190
  mov CL,byte ptr DS:[SI]
  xor CH,CH
  jcxz short 0x2A14
  inc SI
  cmp AX,word ptr DS:[SI]
  jne short 0x2A0A
  cmp DI,word ptr DS:[SI+2]
  je short 0x2A33
  add SI,4
  loop 0x2A01
  mov SI,0x1190
  mov CL,byte ptr DS:[SI]
  cmp CX,0x000A
  jb short 0x2A25
  inc byte ptr DS:[SI]
  inc SI
  add CX,CX
  add CX,CX
  add SI,CX
  mov word ptr DS:[SI],AX
  mov word ptr DS:[SI+2],DI
  ret near
```

**Calls:** 0xAB45, 0xC097, 0xD316, 0xD280

**CFG Block:**
- ID: 36735
- Entry: 100D:29D4, Term: 100D:29D7
- Preds: [15411], Succs: [21406, 36738]

---

### `first_vision_idle_check` — seg000:2BA1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2BA1 first_vision_idle_check
  cmp word ptr DS:[0x0010],0
  jne short 0x2B8F
  cmp byte ptr DS:[8],0xFF
  jne short 0x2B8F
  sub AX,word ptr DS:[0xDC5A]
  cmp AX,0x03E8
  jb short 0x2B8F
  add word ptr DS:[0xDC5A],0x03B6
  call near 0x1071
  call near 0xB17A
  call near 0x2B2A
  cmp byte ptr DS:[0x00EA],0xFF
  jne short 0x2BC4
  ret near
```

**Calls:** 0x1071, 0xB17A, 0x2B2A

**CFG Block:**
- ID: 32048
- Entry: 100D:2BA1, Term: 100D:2BA6
- Preds: [32046], Succs: [14675, 32175]

---

### `present_vision_dream` — seg000:2BD2

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2BD2 present_vision_dream
  call near 0xDBB2
  call near 0xAD5E
  mov DI,word ptr DS:[0x1193]
  or DI,DI
  je short 0x2BF4
  mov AX,DI
  sub AX,0x0100
  cmp AX,0x07AA
  jb short 0x2BF1
  call near 0x331E
  mov AX,word ptr DS:[0x1191]
  mov byte ptr DS:[0x00EA],AL
  cmp AL,1
  jne short 0x2C01
  mov byte ptr DS:[0x00EB],AL
  mov AL,AH
  xor AH,AH
  mov DI,word ptr DS:[0x1193]
  cmp AX,0x0010
  jae short 0x2BCF
  cmp AL,0x0E
  jne short 0x2C16
  mov word ptr DS:[0x47C4],AX
  or DI,DI
  je short 0x2C47
  call near 0x331E
  call near 0x2E98
  cmp word ptr DS:[0x47C4],0x000E
  jb short 0x2C47
  mov AL,3
  cmp byte ptr DS:[0x00EA],0x0E
  je short 0x2C3A
  mov AL,byte ptr DS:[DI+9]
  or AL,AL
  je short 0x2C47
  call near 0x6906
  mov word ptr DS:[0x47C4],0x000E
  mov word ptr DS:[0x4756],SI
  call near 0x2C92
  mov AL,1
```

**Calls:** 0xDBB2, 0xAD5E, 0x331E, 0x331E, 0x2E98, 0x6906, 0x2C92

**Called from:** 100D:DBB2

**CFG Block:**
- ID: 32583
- Entry: 100D:2BD2, Term: 100D:2BD2
- Preds: [32416, 32580], Succs: [1223, 32585]

---

## music.rs (2 functions)

### `music_cd_playlist_advance` — seg000:AD18

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AD18 music_cd_playlist_advance
  mov SI,word ptr DS:[0x380E]
  lods AL,byte ptr DS:[SI]
  or AL,AL
  jns short 0xAD30
  mov SI,0x37FA
  lods AL,byte ptr DS:[SI]
  test byte ptr DS:[0x3810],2
  je short 0xAD30
  call near 0xACBF
  lods AL,byte ptr DS:[SI]
  mov word ptr DS:[0x380E],SI
  jmp short 0xAD95
  ret near
```

**Calls:** 0xACBF

**CFG Block:**
- ID: 25830
- Entry: 100D:AD18, Term: 100D:AD1F
- Preds: [25828], Succs: [25763, 25813]

---

### `music_cd_playlist_restart` — seg000:AD21

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AD21 music_cd_playlist_restart
  mov SI,0x37FA
  lods AL,byte ptr DS:[SI]
  test byte ptr DS:[0x3810],2
  je short 0xAD30
  call near 0xACBF
  lods AL,byte ptr DS:[SI]
  mov word ptr DS:[0x380E],SI
  jmp short 0xAD95
  ret near
```

**Calls:** 0xACBF

**CFG Block:**
- ID: 25763
- Entry: 100D:AD21, Term: 100D:AD2A
- Preds: [25760, 25830], Succs: [25768, 25813]

---

## room_game_screen.rs (22 functions)

### `menu_callback_choice_exit_game` — seg000:0E3E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0E3E menu_callback_choice_exit_game
  mov BX,0x0F66
  mov BP,0x20B6
  jmp near 0xD323
  mov CL,0xFF
  push CX
  cmp byte ptr DS:[0x46D9],0
  je short 0x0E62
  mov AX,0x000D
  call near 0x0E6C
  mov byte ptr DS:[0x46D9],0
  mov word ptr DS:[0x47C4],0
  pop CX
  jmp near 0xB3B0
  call near 0xAD5E
  mov AX,0x000C
  push AX
  call near 0xA7A5
  pop AX
  mov BP,0x181E
  jmp near 0xC8FB
  call near 0xB2B9
  call near 0x98E6
  call near 0x181E
  mov AL,4
  xor DX,DX
  mov BP,0x0ED0
  jmp near 0xC108
  xor AX,AX
  mov byte ptr DS:[0x47C3],AL
  call near 0xB2BE
  mov byte ptr DS:[0x47A6],0xFF
  mov AL,4
  xor DX,DX
  call near 0x189A
  jmp near 0x2DB1
  mov AL,0x3B
  call near 0xC2F2
  mov AX,1
  call near 0xC22F
  call near 0x0F08
```

**Calls:** 0x0E6C, 0xAD5E, 0xA7A5, 0xB2B9, 0x98E6, 0x181E, 0xB2BE, 0x189A, 0xC2F2, 0xC22F, 0x0F08

**CFG Block:**
- ID: 20100
- Entry: 100D:0E3E, Term: 100D:0E44
- Preds: [15411], Succs: [19352]

---

### `desert_collapse_cutscene` — seg000:0E77

**Status:** Never executed during discovery.

---

### `look_at_mirror` — seg000:0EA6

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0EA6 look_at_mirror
  call near 0xB2B9
  call near 0x98E6
  call near 0x181E
  mov AL,4
  xor DX,DX
  mov BP,0x0ED0
  jmp near 0xC108
  xor AX,AX
  mov byte ptr DS:[0x47C3],AL
  call near 0xB2BE
  mov byte ptr DS:[0x47A6],0xFF
  mov AL,4
  xor DX,DX
  call near 0x189A
  jmp near 0x2DB1
  mov AL,0x3B
  call near 0xC2F2
  mov AX,1
  call near 0xC22F
  call near 0x0F08
  mov AX,0x003B
  call near 0xC13E
  mov AX,2
  xor DX,DX
  xor BX,BX
  call near 0xC22F
  call near 0x1797
  mov SI,0x1D1E
  call near 0xD72B
  call near 0x98F5
  mov byte ptr DS:[0x1C06],0x80
  mov BP,0x20C2
  mov BX,0x0EB9
  jmp near 0xD338
  test word ptr DS:[0x0010],0x0080
  jne short 0x0F13
  jmp near 0x0960
  call near 0xC412
  mov word ptr DS:[0x47C4],7
  call near 0x9197
```

**Calls:** 0xB2B9, 0x98E6, 0x181E, 0xB2BE, 0x189A, 0xC2F2, 0xC22F, 0x0F08, 0xC13E, 0xC22F, 0x1797, 0xD72B, 0x98F5, 0xC412, 0x9197

**Called from:** 100D:B2B9

**CFG Block:**
- ID: 19952
- Entry: 100D:0EA6, Term: 100D:0EA6
- Preds: [15411], Succs: [16364, 19954]

---

### `menu_callback_choice_palace_look_away_from_mirror` — seg000:0EB9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0EB9 menu_callback_choice_palace_look_away_from_mirror
  xor AX,AX
  mov byte ptr DS:[0x47C3],AL
  call near 0xB2BE
  mov byte ptr DS:[0x47A6],0xFF
  mov AL,4
  xor DX,DX
  call near 0x189A
  jmp near 0x2DB1
  mov AL,0x3B
  call near 0xC2F2
  mov AX,1
  call near 0xC22F
  call near 0x0F08
  mov AX,0x003B
  call near 0xC13E
  mov AX,2
  xor DX,DX
  xor BX,BX
  call near 0xC22F
  call near 0x1797
  mov SI,0x1D1E
  call near 0xD72B
  call near 0x98F5
  mov byte ptr DS:[0x1C06],0x80
  mov BP,0x20C2
  mov BX,0x0EB9
  jmp near 0xD338
  test word ptr DS:[0x0010],0x0080
  jne short 0x0F13
  jmp near 0x0960
  call near 0xC412
  mov word ptr DS:[0x47C4],7
  call near 0x9197
  mov byte ptr DS:[0x478C],0
  add word ptr DS:[0x1BF2],0x000F
  call near 0x978E
  call near 0x998E
  mov word ptr DS:[0x22A6],0xFFFF
  inc byte ptr DS:[0x47C3]
  mov word ptr DS:[0x47C6],1
```

**Calls:** 0xB2BE, 0x189A, 0xC2F2, 0xC22F, 0x0F08, 0xC13E, 0xC22F, 0x1797, 0xD72B, 0x98F5, 0xC412, 0x9197, 0x978E, 0x998E

**CFG Block:**
- ID: 33359
- Entry: 100D:0EB9, Term: 100D:0EBE
- Preds: [15411], Succs: [14615, 33363]

---

### `menu_callback_choice_wait_for_evening` — seg000:0F48

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0F48 menu_callback_choice_wait_for_evening
  mov AX,word ptr DS:[2]
  mov BX,AX
  and AL,0x0F
  cmp AL,0x0C
  jae short 0x0F66
  push BX
  cmp AL,2
  jae short 0x0F5F
  mov AX,BX
  add AL,2
  call near 0x0FB2
  pop AX
  and AL,0xF0
  or AL,0x0C
  jmp short 0x0F84
  ret near
```

**Calls:** 0x0FB2

**CFG Block:**
- ID: 27959
- Entry: 100D:0F48, Term: 100D:0F51
- Preds: [15411], Succs: [27965]

---

### `menu_callback_choice_wait_for_morning` — seg000:0F67

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0F67 menu_callback_choice_wait_for_morning
  mov AX,word ptr DS:[2]
  mov BX,AX
  and AL,0x0F
  cmp AL,0x0B
  jb short 0x0F66
  push BX
  cmp AL,0x0D
  jae short 0x0F7E
  mov AX,BX
  add AL,2
  call near 0x0FB2
  pop AX
  and AL,0xF0
  add AX,0x0010
  cmp byte ptr DS:[0x002A],0x14
  jne short 0x0F95
  call near 0x0F95
  sub word ptr DS:[0xDC5A],0x03E8
  ret near
```

**Calls:** 0x0FB2, 0x0F95

**CFG Block:**
- ID: 32284
- Entry: 100D:0F67, Term: 100D:0F70
- Preds: [15411], Succs: [32290]

---

### `wait_advance_to_target_time` — seg000:0F84

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:0F84 wait_advance_to_target_time
  cmp byte ptr DS:[0x002A],0x14
  jne short 0x0F95
  call near 0x0F95
  sub word ptr DS:[0xDC5A],0x03E8
  ret near
```

**Calls:** 0x0F95

**CFG Block:**
- ID: 27974
- Entry: 100D:0F84, Term: 100D:0F89
- Preds: [27969, 32294], Succs: [27977, 32298]

---

### `restore_cursor_over_panel` — seg000:2EE5

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:2EE5 restore_cursor_over_panel
  mov AX,0xDBEC
  push AX
  call near 0xDBB2
  call near 0x2FFB
  call near 0xD763
  mov BP,0x1F0E
  mov BX,0x0F66
  jmp near 0xD338
  push DS
  pop ES
  mov DI,0x1F0F
  xor AL,AL
  stos byte ptr ES:[DI],AL
  mov BX,word ptr DS:[6]
  mov DX,word ptr DS:[4]
  cmp BL,0x80
  je short 0x2F13
  jmp near 0x2FAA
  mov SI,0x220C
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  cmp DL,1
  jne short 0x2F58
  cmp byte ptr DS:[0x002B],0
  je short 0x2F3D
  mov SI,0x2218
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  mov SI,0x2214
  lods AX,word ptr DS:[SI]
  cmp byte ptr DS:[0x002A],0x4F
  sbb AH,AH
  and AH,0x40
  stos word ptr ES:[DI],AX
  movs word ptr ES:[DI],word ptr DS:[SI]
  jmp short 0x2FA3
  push DI
  mov DI,word ptr DS:[0x114E]
```

**Calls:** 0xDBB2, 0x2FFB, 0xD763

**CFG Block:**
- ID: 14054
- Entry: 100D:2EE5, Term: 100D:2EE9
- Preds: [14050], Succs: [1223, 14058]

---

### `sun_flash_keeps_the_desert_compass_centre_hidden` — seg000:3056

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3056 sun_flash_keeps_the_desert_compass_centre_hidden
  mov byte ptr DS:[0x1CC4],AL
  mov CX,4
  lods AL,byte ptr DS:[SI]
  add DI,0x000E
  mov AH,0x20
  or AL,AL
  je short 0x306C
  cmp AL,0xFB
  jl short 0x306C
  mov AH,0x80
  mov byte ptr DS:[DI],AH
  loop 0x305C
  jmp near 0xD735
  mov DI,0x1B98
  mov word ptr DS:[DI],0x0023
  mov BX,0x001D
  mov CX,4
  add DI,0x000E
  mov word ptr DS:[DI],BX
  mov word ptr DS:[DI-2],0x0080
  inc BX
  loop 0x3080
  jmp near 0xD735
  call near 0x98E6
  call near 0x3127
  mov DI,0x1F0C
  add DI,4
  cmp word ptr DS:[DI],0
  jne short 0x3099
  mov word ptr DS:[0x0012],0
  push DS
  pop ES
  mov BP,0x30B9
  call near 0x36EE
  mov BP,0x3120
  call near 0x36EE
  xor AX,AX
  stos word ptr ES:[DI],AX
  ret near
```

**Calls:** 0x98E6, 0x3127, 0x36EE, 0x36EE

---

### `desert_walk_exhaustion_check` — seg000:3723

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3723 desert_walk_exhaustion_check
  and byte ptr DS:[0x4735],0x7F
  sub AL,0x94
  jb short 0x3722
  test AL,0x0F
  jne short 0x3722
  push AX
  call near 0xDBB2
  call near 0xC07C
  call near 0x37AD
  call near 0xC4DD
  pop AX
  xor AH,AH
  mov CL,4
  shr AX,CL
  inc AX
  cmp AL,0x0A
  jb short 0x374B
  xchg AL,AH
  call near 0xE387
  cmp byte ptr DS:[0x4735],0x37
  jb short 0x37AA
  jmp near 0x2DB1
  mov AL,0x22
  jmp near 0xC2F2
  call near 0x98E6
  call near 0x4D00
  mov word ptr DS:[0x472D],0
  call near 0x5BA8
  call near 0xC432
  mov AX,0xFFFF
  cmp byte ptr DS:[8],AL
  je short 0x37D5
  mov DX,word ptr DS:[4]
  call near 0x3EFE
  lods AL,byte ptr DS:[SI]
  or AX,AX
  js short 0x37DC
  jmp near 0x39EC
  call near 0x3AE9
  or byte ptr DS:[0x47A4],1
```

**Calls:** 0xDBB2, 0xC07C, 0x37AD, 0xC4DD, 0xE387, 0x98E6, 0x4D00, 0x5BA8, 0xC432, 0x3EFE, 0x3AE9

**CFG Block:**
- ID: 32184
- Entry: 100D:3723, Term: 100D:372A
- Preds: [32182], Succs: [32187, 32222]

---

### `fremen2_sprite_click_opens_their_dialogue` — seg000:9240

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9240 fremen2_sprite_click_opens_their_dialogue
  sub CL,0x0F
  mov AL,CL
  jmp near 0x9381
  cmp BP,0x1F7E
  jne short 0x9281
  call near 0x92C9
  jae short 0x9281
  cmp byte ptr DS:[0x000B],1
  jne short 0x9281
  cmp BX,0x0098
  jae short 0x9281
  cmp byte ptr DS:[8],0x21
  je short 0x9281
  cmp byte ptr DS:[0x002B],0
  jne short 0x9281
  jmp near 0x3F15
  ret near
```

**Calls:** 0x92C9

**CFG Block:**
- ID: 37528
- Entry: 100D:9240, Term: 100D:9245
- Preds: [37278], Succs: [37531]

---

### `click_sietch_game_area_enters_it` — seg000:9263

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9263 click_sietch_game_area_enters_it
  cmp byte ptr DS:[0x000B],1
  jne short 0x9281
  cmp BX,0x0098
  jae short 0x9281
  cmp byte ptr DS:[8],0x21
  je short 0x9281
  cmp byte ptr DS:[0x002B],0
  jne short 0x9281
  jmp near 0x3F15
  ret near
```

**CFG Block:**
- ID: 25206
- Entry: 100D:9263, Term: 100D:9268
- Preds: [25204], Succs: [14302, 32062]

---

### `ui_dialogue_related_to_harkonnen_captains` — seg000:932E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:932E ui_dialogue_related_to_harkonnen_captains
  mov SI,word ptr DS:[0x4768]
  call near 0x31F6
  call near 0x407E
  mov BP,0x0044
  cmp word ptr SS:[BP],0
  jne short 0x9356
  mov AX,word ptr DS:[0x00E2]
  cmp AX,0x001E
  jae short 0x936B
  mov BP,0x00E4
  mov SI,word ptr DS:[0x4768]
  mov AX,word ptr SS:[BP]
  mov word ptr DS:[SI+0x0C],AX
  push word ptr SS:[BP]
  call near 0x5323
  pop DI
  add AX,0x00DA
  push AX
  call near 0x331E
  call near 0x2E98
  pop word ptr DS:[0x11FD]
  mov AL,0x0C
  jmp short 0x93AA
  mov AL,0x0D
  jmp short 0x93AA
  mov SI,word ptr DS:[0x4756]
  call near 0x31F6
  mov AL,0x0E
  jmp short 0x93AA
  sub AX,0x0087
  cmp AL,9
  jb short 0x9387
  cmp AL,8
  jne short 0x9394
  mov AL,byte ptr DS:[0x476B]
  dec AL
  jns short 0x9394
  mov byte ptr DS:[0x476C],AL
  mov SI,0x4758
  xor AH,AH
```

**Calls:** 0x31F6, 0x407E, 0x5323, 0x331E, 0x2E98, 0x31F6

**CFG Block:**
- ID: 38254
- Entry: 100D:932E, Term: 100D:9332
- Preds: [15411], Succs: [22924, 38259]

---

### `ui_dialogue_related_to_fremen1` — seg000:9373

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9373 ui_dialogue_related_to_fremen1
  mov SI,word ptr DS:[0x4756]
  call near 0x31F6
  mov AL,0x0E
  jmp short 0x93AA
  sub AX,0x0087
  cmp AL,9
  jb short 0x9387
  cmp AL,8
  jne short 0x9394
  mov AL,byte ptr DS:[0x476B]
  dec AL
  jns short 0x9394
  mov byte ptr DS:[0x476C],AL
  mov SI,0x4758
  xor AH,AH
  add AX,AX
  add SI,AX
  mov SI,word ptr DS:[SI]
  call near 0x1EBE
  call near 0x31F6
  mov AL,0x0F
  xor AH,AH
  mov word ptr DS:[0x47E1],0
  push AX
  mov word ptr DS:[0x47C4],AX
  call near 0x91A0
  call near 0x3AF9
  call near 0x9197
  call near 0x9908
  mov SI,word ptr DS:[0x47C8]
  mov word ptr DS:[0x4540],0
  call near 0x9BAC
  call near 0x1834
  call near 0xC0F4
  call near 0xC4DD
  pop AX
  call near 0x93DF
  jmp near 0x9472
  mov CL,AL
  shl AL,1
```

**Calls:** 0x31F6, 0x1EBE, 0x31F6, 0x91A0, 0x3AF9, 0x9197, 0x9908, 0x9BAC, 0x1834, 0xC0F4, 0xC4DD, 0x93DF

**CFG Block:**
- ID: 23171
- Entry: 100D:9373, Term: 100D:9377
- Preds: [15411, 37281], Succs: [22924, 23174]

---

### `ui_dialogue_related_to_fremen2` — seg000:937E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:937E ui_dialogue_related_to_fremen2
  sub AX,0x0087
  cmp AL,9
  jb short 0x9387
  cmp AL,8
  jne short 0x9394
  mov AL,byte ptr DS:[0x476B]
  dec AL
  jns short 0x9394
  mov byte ptr DS:[0x476C],AL
  mov SI,0x4758
  xor AH,AH
  add AX,AX
  add SI,AX
  mov SI,word ptr DS:[SI]
  call near 0x1EBE
  call near 0x31F6
  mov AL,0x0F
  xor AH,AH
  mov word ptr DS:[0x47E1],0
  push AX
  mov word ptr DS:[0x47C4],AX
  call near 0x91A0
  call near 0x3AF9
  call near 0x9197
  call near 0x9908
  mov SI,word ptr DS:[0x47C8]
  mov word ptr DS:[0x4540],0
  call near 0x9BAC
  call near 0x1834
  call near 0xC0F4
  call near 0xC4DD
  pop AX
  call near 0x93DF
  jmp near 0x9472
  mov CL,AL
  shl AL,1
  shl AL,1
  shl AL,1
  mov word ptr DS:[0x47BE],AX
  mov AX,1
```

**Calls:** 0x1EBE, 0x31F6, 0x91A0, 0x3AF9, 0x9197, 0x9908, 0x9BAC, 0x1834, 0xC0F4, 0xC4DD, 0x93DF

**CFG Block:**
- ID: 26987
- Entry: 100D:937E, Term: 100D:937E
- Preds: [15411], Succs: [37531]

---

### `ui_dialogue_related_to_common_and_fremen2` — seg000:9381

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9381 ui_dialogue_related_to_common_and_fremen2
  cmp AL,9
  jb short 0x9387
  cmp AL,8
  jne short 0x9394
  mov AL,byte ptr DS:[0x476B]
  dec AL
  jns short 0x9394
  mov byte ptr DS:[0x476C],AL
  mov SI,0x4758
  xor AH,AH
  add AX,AX
  add SI,AX
  mov SI,word ptr DS:[SI]
  call near 0x1EBE
  call near 0x31F6
  mov AL,0x0F
  xor AH,AH
  mov word ptr DS:[0x47E1],0
  push AX
  mov word ptr DS:[0x47C4],AX
  call near 0x91A0
  call near 0x3AF9
  call near 0x9197
  call near 0x9908
  mov SI,word ptr DS:[0x47C8]
  mov word ptr DS:[0x4540],0
  call near 0x9BAC
  call near 0x1834
  call near 0xC0F4
  call near 0xC4DD
  pop AX
  call near 0x93DF
  jmp near 0x9472
  mov CL,AL
  shl AL,1
  shl AL,1
  shl AL,1
  mov word ptr DS:[0x47BE],AX
  mov AX,1
  shl AX,CL
```

**Calls:** 0x1EBE, 0x31F6, 0x91A0, 0x3AF9, 0x9197, 0x9908, 0x9BAC, 0x1834, 0xC0F4, 0xC4DD, 0x93DF

**CFG Block:**
- ID: 37531
- Entry: 100D:9381, Term: 100D:9383
- Preds: [26987, 37528], Succs: [26991]

---

### `menu_npc_actions_redraw_room` — seg000:9879

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9879 menu_npc_actions_redraw_room
  call near 0x2EFB
  cmp byte ptr DS:[0x11C9],0
  jne short 0x9886
  call near 0x3090
  call near 0x37B2
  call near 0xC412
  call near 0xC0F4
  call near 0x1834
  call near 0xC4DD
  jmp near 0x17E6
  mov BP,0x37B2
  call near 0xC097
  call near 0x36D3
  mov AX,0x00C8
  call near 0xE3A0
  mov word ptr DS:[0x1C06],0
  jmp short 0x9858
  call near 0x8C8A
  cmp byte ptr DS:[0x47C3],0
  jne short 0x98E5
  xor AX,AX
  mov word ptr DS:[0x4540],AX
  and byte ptr DS:[0x47D1],0x3F
  xchg AX,word ptr DS:[0x47C8]
  or AX,AX
  je short 0x98E5
  mov SI,0x1BF0
  mov word ptr DS:[SI+8],0
  mov word ptr DS:[0x1C06],0
  call near 0xC446
  mov SI,0x1BF0
  call near 0xC4F0
  jmp near 0x9B8B
  ret near
```

**Calls:** 0x2EFB, 0x3090, 0x37B2, 0xC412, 0xC0F4, 0x1834, 0xC4DD, 0xC097, 0x36D3, 0xE3A0, 0x8C8A, 0xC446, 0xC4F0

**Called from:** 100D:2EFB

**CFG Block:**
- ID: 16286
- Entry: 100D:9879, Term: 100D:9879
- Preds: [16281, 26000], Succs: [13589, 16288]

---

### `equal_priority_push_takes_the_incoming_cleanup` — seg000:D368

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D368 equal_priority_push_takes_the_incoming_cleanup
  mov word ptr DS:[SI],BP
  mov word ptr DS:[SI+2],BX
  mov SI,word ptr DS:[0x21DA]
  mov word ptr DS:[SI],BP
  mov SI,BP
  add BP,2
  cmp word ptr SS:[BP],0
  je short 0xD388
  and word ptr SS:[BP],0x7FFF
  add BP,4
  jmp short 0xD378
  cmp CX,5
  jae short 0xD397
  shl CX,1
  shl CX,1
  mov BX,CX
  or byte ptr DS:[BX+SI+3],0x80
  mov byte ptr DS:[0xDCE7],0xFF
  mov SI,word ptr DS:[0x21DA]
  mov SI,word ptr DS:[SI]
  inc SI
  lods AL,byte ptr DS:[SI]
  mov byte ptr DS:[0xDCE4],AL
  cbw
  add SI,AX
  xor CX,CX
  mov byte ptr DS:[0xDCE8],CL
  mov byte ptr DS:[0xDCE5],0xFF
  mov AX,word ptr DS:[SI]
  or AX,AX
  je short 0xD3EF
  cmp CL,4
  jb short 0xD3D9
  cmp byte ptr DS:[0xDCE4],0
  jne short 0xD3CD
  cmp word ptr DS:[SI+4],0
  je short 0xD3D9
  or byte ptr DS:[0xDCE4],0x80
  mov AX,0x00A0
  mov byte ptr DS:[0xDCE5],CL
```

**CFG Block:**
- ID: 14122
- Entry: 100D:D368, Term: 100D:D36A
- Preds: [15541, 16439], Succs: [16314]

---

### `dispatch_command_menu_slot` — seg000:D445

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D445 dispatch_command_menu_slot
  call near 0xD454
  or BX,BX
  je short 0xD453
  test AH,0x40
  jne short 0xD453
  jmp near BX
  mov SI,word ptr DS:[0x21DA]
  mov SI,word ptr DS:[SI]
  inc SI
  xor CH,CH
  cmp CL,byte ptr DS:[0xDCE5]
  je short 0xD475
  lods AL,byte ptr DS:[SI]
  cbw
  add SI,AX
  mov AX,CX
  shl AX,1
  shl AX,1
  add SI,AX
  mov AX,word ptr DS:[SI]
  mov BX,word ptr DS:[SI+2]
  ret near
```

**Calls:** 0xD454

**Called from:** 100D:D454

**CFG Block:**
- ID: 15403
- Entry: 100D:D445, Term: 100D:D445
- Preds: [15400, 16081, 16167, 16234, 17389], Succs: [15236, 15405]

---

### `slot_for_person_text_id` — seg000:D55D

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D55D slot_for_person_text_id
  mov BP,CX
  add BP,0x0078
  xor CX,CX
  call near 0xD454
  cmp AX,BP
  je short 0xD5DD
  inc CX
  cmp CL,byte ptr DS:[0xDCE8]
  jb short 0xD565
  jmp short 0xD5DB
  cmp BP,0x1F7E
  jne short 0xD5B1
  mov DI,0x1BE2
  cmp byte ptr DS:[DI+8],0
  jns short 0xD593
  xor CX,CX
  call near 0xD6FE
  jb short 0xD5DD
  mov DI,0x1BF0
  call near 0xD6FE
  jb short 0xD5DD
  cmp byte ptr DS:[0x1BF8],0
  jns short 0xD5B1
  mov DI,0x1BFE
  call near 0xD6FE
  mov CL,3
  jb short 0xD5DD
  call near 0x92C9
  jae short 0xD5B1
  cmp CX,word ptr DS:[0x47C4]
  mov CL,2
  je short 0xD5DD
  cmp BX,0x0098
  jb short 0xD5DB
  mov CL,0xFF
  mov DI,0x1B48
  cmp DX,word ptr DS:[DI]
  jb short 0xD5DD
  cmp DX,word ptr DS:[DI+4]
  jae short 0xD5DD
```

**Calls:** 0xD454, 0xD6FE, 0xD6FE, 0xD6FE, 0x92C9

**CFG Block:**
- ID: 23054
- Entry: 100D:D55D, Term: 100D:D563
- Preds: [23050, 25122, 25331], Succs: [23065]

---

### `verb_strip_hovered_slot` — seg000:D5B1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D5B1 verb_strip_hovered_slot
  cmp BX,0x0098
  jb short 0xD5DB
  mov CL,0xFF
  mov DI,0x1B48
  cmp DX,word ptr DS:[DI]
  jb short 0xD5DD
  cmp DX,word ptr DS:[DI+4]
  jae short 0xD5DD
  xor CX,CX
  cmp BX,word ptr DS:[DI+2]
  jbe short 0xD5DB
  cmp BX,word ptr DS:[DI+6]
  jbe short 0xD5DD
  add DI,0x000E
  inc CX
  cmp CL,byte ptr DS:[0xDCE8]
  jb short 0xD5C7
  mov CL,0xFF
  mov AL,CL
  xchg CL,byte ptr DS:[0xDCE7]
  cmp AL,CL
  je short 0xD610
  call near 0xDBB2
  or CL,CL
  js short 0xD5FC
  cmp CL,byte ptr DS:[0xDCE8]
  jae short 0xD5FC
  push AX
  call near 0xD454
  call near 0xD48A
  pop AX
  cmp AL,byte ptr DS:[0xDCE8]
  jae short 0xD60D
  mov CX,AX
  call near 0xD454
  or AH,0x80
  call near 0xD48A
  call near 0xDBEC
  pop BP
  pop DI
```

**Calls:** 0xDBB2, 0xD454, 0xD48A, 0xD454, 0xD48A, 0xDBEC

**CFG Block:**
- ID: 14310
- Entry: 100D:D5B1, Term: 100D:D5B5
- Preds: [14307, 15550, 15573, 37287], Succs: [14313, 14944]

---

### `cursor_hides_during_a_click_in_overlay_mode` — seg000:D8F4

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:D8F4 cursor_hides_during_a_click_in_overlay_mode
  call near 0xDBB2
  call near 0xE26F
  sub AL,3
  je short 0xD944
  cmp SI,word ptr DS:[0x2570]
  jne short 0xD90E
  call near 0xD6B7
  jb short 0xD918
  push SI
  call near 0x9215
  pop SI
  mov AL,byte ptr DS:[0xDC35]
  call near word ptr DS:[SI+2]
  jmp near 0xD820
  ret near
```

**Calls:** 0xDBB2, 0xE26F, 0xD6B7, 0x9215

**Called from:** 100D:DBB2

**CFG Block:**
- ID: 15313
- Entry: 100D:D8F4, Term: 100D:D8F4
- Preds: [15309], Succs: [1223, 15315]

---

## room_scene.rs (7 functions)

### `desert_tile_resource` — seg000:384A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:384A desert_tile_resource
  mov DI,word ptr DS:[0x1150]
  test byte ptr DS:[DI+0x0A],1
  jne short 0x3872
  call near 0x407E
  call near 0xB58B
  dec DI
  mov CX,4
  mov AL,byte ptr ES:[DI]
  inc DI
  and AL,0x30
  cmp AL,0x10
  je short 0x3872
  loop 0x385E
  mov BX,0x0013
  mov CX,0x0042
  jmp short 0x3878
  mov BX,0x000A
  mov CX,0x0088
  mov AX,word ptr DS:[6]
  xchg AL,AH
  xor AX,word ptr DS:[4]
  inc AX
  xor DX,DX
  div BX
  mov AX,DX
  add AX,CX
  jmp near 0xC2F2
  mov byte ptr DS:[0x46DF],1
  call near 0x395C
  cmp byte ptr DS:[0x46D7],0
  je short 0x38AD
  cmp byte ptr DS:[0x46D6],BL
  je short 0x38B3
  mov byte ptr DS:[0x46D7],0x30
  call near 0x3971
  jmp near 0x39B9
  call near 0x3971
  call near 0x398C
  ret near
```

**Calls:** 0x407E, 0xB58B, 0x395C, 0x3971, 0x3971, 0x398C

**CFG Block:**
- ID: 32189
- Entry: 100D:384A, Term: 100D:3852
- Preds: [20502, 27899], Succs: [32193, 40984]

---

### `draw_room_ornis` — seg000:3A24

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3A24 draw_room_ornis
  cmp byte ptr DS:[0x46DF],0
  je short 0x3A7C
  cmp byte ptr DS:[4],1
  jne short 0x3A7C
  cmp byte ptr DS:[0x4731],0xFF
  je short 0x3A7B
  mov CL,byte ptr DS:[0x46FF]
  xor CH,CH
  jcxz short 0x3A7B
  mov AX,0x388D
  push AX
  mov byte ptr DS:[0x4731],0
  test byte ptr DS:[0x47A4],0x81
  jne short 0x3A7B
  mov AX,0x0033
  call near 0xC13E
  call near 0x3A95
  mov AX,DX
  add AX,0x000C
  mov word ptr DS:[0x472D],AX
  mov AX,BX
  add AX,8
  mov word ptr DS:[0x472F],AX
  push CX
  push BX
  push DX
  call near 0x3AA9
  pop DX
  pop BX
  pop CX
  add DX,0x0046
  add BX,0x000A
  loop 0x3A6A
  ret near
```

**Calls:** 0xC13E, 0x3A95, 0x3AA9

**CFG Block:**
- ID: 6984
- Entry: 100D:3A24, Term: 100D:3A29
- Preds: [6767, 6980], Succs: [4710, 20179]

---

### `ui_click_move_room` — seg000:3F27

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3F27 ui_click_move_room
  push BP
  call near 0xD2BD
  call near 0xAC30
  call near 0xA7A5
  pop BP
  mov byte ptr DS:[0x47A9],0
  mov byte ptr DS:[0x0026],0
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  cmp BL,0x80
  je short 0x3F67
  mov AL,byte ptr DS:[0x4735]
  and AL,0x7F
  inc AL
  jns short 0x3F54
  or AL,0x80
  mov byte ptr DS:[0x4735],AL
  cmp byte ptr DS:[0x00F4],0x14
  jae short 0x3F64
  inc byte ptr DS:[0x00F4]
  jmp near 0x3FF5
  call near 0x3EFE
  mov DL,byte ptr SS:[BP+SI]
  or DL,DL
  je short 0x3F14
  js short 0x3FD2
  cmp byte ptr DS:[0x000B],1
  jne short 0x3F84
  call near 0xE270
  mov CL,2
  call near 0xB389
  call near 0xE283
  mov SI,word ptr DS:[0x114E]
  test byte ptr DS:[SI+0x0A],0x10
  jne short 0x3FAA
  or byte ptr DS:[SI+0x0A],0x10
  cmp DH,0x20
  adc byte ptr DS:[0x0025],0
  mov byte ptr DS:[0x0026],0xFF
  call near 0xE270
```

**Calls:** 0xD2BD, 0xAC30, 0xA7A5, 0x3EFE, 0xE270, 0xB389, 0xE283, 0xE270

**CFG Block:**
- ID: 19794
- Entry: 100D:3F27, Term: 100D:3F28
- Preds: [19791, 20170, 20194, 20389], Succs: [13221, 19797]

---

### `compass_move_target` — seg000:3F67

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3F67 compass_move_target
  call near 0x3EFE
  mov DL,byte ptr SS:[BP+SI]
  or DL,DL
  je short 0x3F14
  js short 0x3FD2
  cmp byte ptr DS:[0x000B],1
  jne short 0x3F84
  call near 0xE270
  mov CL,2
  call near 0xB389
  call near 0xE283
  mov SI,word ptr DS:[0x114E]
  test byte ptr DS:[SI+0x0A],0x10
  jne short 0x3FAA
  or byte ptr DS:[SI+0x0A],0x10
  cmp DH,0x20
  adc byte ptr DS:[0x0025],0
  mov byte ptr DS:[0x0026],0xFF
  call near 0xE270
  mov CL,3
  call near 0xB389
  call near 0xE283
  mov byte ptr DS:[0x000C],DL
  mov byte ptr DS:[0x0023],1
  call near 0xA1C4
  push BX
  push DX
  call near 0x36D3
  pop DX
  pop BX
  call near 0xA1E2
  je short 0x3FC3
  ret near
```

**Calls:** 0x3EFE, 0xE270, 0xB389, 0xE283, 0xE270, 0xB389, 0xE283, 0xA1C4, 0x36D3, 0xA1E2

**Called from:** 100D:3EFE

**CFG Block:**
- ID: 19809
- Entry: 100D:3F67, Term: 100D:3F67
- Preds: [19801], Succs: [6725, 19811]

---

### `desert_position_dispatch` — seg000:3FF5

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3FF5 desert_position_dispatch
  shl BP,1
  mov AX,word ptr SS:[BP+0x1454]
  call near 0xB5CF
  or BH,BH
  jne short 0x4057
  mov AX,BX
  cbw
  mov BX,AX
  call near 0xB532
  xor BH,BH
  test AL,0x40
  je short 0x4057
  call near 0x409A
  jne short 0x4057
  cmp DX,word ptr DS:[SI+2]
  jne short 0x4057
  mov AX,BX
  cbw
  mov BX,AX
  mov byte ptr DS:[0x4735],0
  mov word ptr DS:[0x114E],SI
  mov word ptr DS:[0x1150],SI
  mov DI,SI
  call near 0x503C
  mov word ptr DS:[0x009A],0
  mov word ptr DS:[0x0098],0
  call near 0x425B
  call near 0x40AE
  mov byte ptr DS:[8],DH
  mov byte ptr DS:[9],BH
  cmp DH,0x20
  jb short 0x4054
  or byte ptr DS:[SI+0x0A],0x10
  call near 0x2170
  call near 0x40C3
  mov word ptr DS:[4],DX
  mov AL,DL
  xchg AL,byte ptr DS:[0x000B]
  mov byte ptr DS:[0x000D],AL
  mov word ptr DS:[6],BX
```

**Calls:** 0xB5CF, 0xB532, 0x409A, 0x503C, 0x425B, 0x40AE, 0x2170, 0x40C3

**CFG Block:**
- ID: 28095
- Entry: 100D:3FF5, Term: 100D:3FFB
- Preds: [27836, 32252], Succs: [27851, 27863]

---

### `desert_check_arrival` — seg000:4002

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4002 desert_check_arrival
  mov AX,BX
  cbw
  mov BX,AX
  call near 0xB532
  xor BH,BH
  test AL,0x40
  je short 0x4057
  call near 0x409A
  jne short 0x4057
  cmp DX,word ptr DS:[SI+2]
  jne short 0x4057
  mov AX,BX
  cbw
  mov BX,AX
  mov byte ptr DS:[0x4735],0
  mov word ptr DS:[0x114E],SI
  mov word ptr DS:[0x1150],SI
  mov DI,SI
  call near 0x503C
  mov word ptr DS:[0x009A],0
  mov word ptr DS:[0x0098],0
  call near 0x425B
  call near 0x40AE
  mov byte ptr DS:[8],DH
  mov byte ptr DS:[9],BH
  cmp DH,0x20
  jb short 0x4054
  or byte ptr DS:[SI+0x0A],0x10
  call near 0x2170
  call near 0x40C3
  mov word ptr DS:[4],DX
  mov AL,DL
  xchg AL,byte ptr DS:[0x000B]
  mov byte ptr DS:[0x000D],AL
  mov word ptr DS:[6],BX
  cmp byte ptr DS:[0x46EB],0
  js short 0x4099
  cmp DX,0x3002
  jne short 0x407B
  jmp near 0x16FC
```

**Calls:** 0xB532, 0x409A, 0x503C, 0x425B, 0x40AE, 0x2170, 0x40C3

**CFG Block:**
- ID: 22564
- Entry: 100D:4002, Term: 100D:4007
- Preds: [22558, 27863], Succs: [20518, 22569]

---

### `arrive_at_location` — seg000:401F

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:401F arrive_at_location
  mov byte ptr DS:[0x4735],0
  mov word ptr DS:[0x114E],SI
  mov word ptr DS:[0x1150],SI
  mov DI,SI
  call near 0x503C
  mov word ptr DS:[0x009A],0
  mov word ptr DS:[0x0098],0
  call near 0x425B
  call near 0x40AE
  mov byte ptr DS:[8],DH
  mov byte ptr DS:[9],BH
  cmp DH,0x20
  jb short 0x4054
  or byte ptr DS:[SI+0x0A],0x10
  call near 0x2170
  call near 0x40C3
  mov word ptr DS:[4],DX
  mov AL,DL
  xchg AL,byte ptr DS:[0x000B]
  mov byte ptr DS:[0x000D],AL
  mov word ptr DS:[6],BX
  cmp byte ptr DS:[0x46EB],0
  js short 0x4099
  cmp DX,0x3002
  jne short 0x407B
  jmp near 0x16FC
  jmp near 0x2DBF
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  cmp BL,0x80
  jne short 0x4096
  mov SI,word ptr DS:[0x114E]
  mov DX,word ptr DS:[SI+2]
  mov BX,word ptr DS:[SI+4]
  ret near
```

**Calls:** 0x503C, 0x425B, 0x40AE, 0x2170, 0x40C3

---

## savegame.rs (6 functions)

### `menu_callback_choice_mirror_room_save_game` — seg000:B28C

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B28C menu_callback_choice_mirror_room_save_game
  mov BP,0x207A
  call near 0xB2AA
  mov CX,0x8000
  mov SI,0x207C
  call near 0xB30F
  jmp near 0xD397
  mov CX,0x4000
  mov SI,0x208C
  call near 0xB30F
  mov BP,0x208A
  call near 0xB2B9
  mov BX,0xB2B3
  jmp near 0xD323
  dec byte ptr DS:[0x2788]
  jns short 0xB2BD
  inc byte ptr DS:[0x2788]
  ret near
```

**Calls:** 0xB2AA, 0xB30F, 0xB30F, 0xB2B9

**CFG Block:**
- ID: 19344
- Entry: 100D:B28C, Term: 100D:B28F
- Preds: [15411], Succs: [19347, 19360]

---

### `menu_callback_choice_mirror_room_load_game` — seg000:B29E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B29E menu_callback_choice_mirror_room_load_game
  mov CX,0x4000
  mov SI,0x208C
  call near 0xB30F
  mov BP,0x208A
  call near 0xB2B9
  mov BX,0xB2B3
  jmp near 0xD323
  dec byte ptr DS:[0x2788]
  jns short 0xB2BD
  inc byte ptr DS:[0x2788]
  ret near
```

**Calls:** 0xB30F, 0xB2B9

**CFG Block:**
- ID: 20196
- Entry: 100D:B29E, Term: 100D:B2A4
- Preds: [15411], Succs: [19364, 20201]

---

### `menu_callback_choice_globe_save_game` — seg000:B35A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B35A menu_callback_choice_globe_save_game
  mov BX,word ptr DS:[2]
  mov word ptr DS:[0xD816],BX
  call near 0xDBB2
  call near 0xB2CD
  push CX
  call near 0xD48A
  pop CX
  call near 0xB389
  pushf
  mov AX,0x0113
  adc AL,0
  mov CX,4
  call near 0xD48A
  mov AX,0x012C
  call near 0xDDB0
  popf
  jb short 0xB388
  jmp near 0xD2E2
  add CL,0x31
  mov byte ptr DS:[0x38AF],CL
  call near 0xB427
  mov AX,word ptr DS:[2]
  push DS
  push ES
  pop DS
  mov SI,DI
  xor DI,DI
  stos word ptr ES:[DI],AX
  call near 0xB4EA
  pop DS
  mov DX,0x38A8
  call near 0xF2FC
  xor DI,DI
  add CX,2
  jmp near 0xF27C
  cmp byte ptr DS:[0x46D9],0
  je short 0xB3BA
  jmp near 0x0E49
  add CL,0x31
  mov byte ptr DS:[0x38AF],CL
```

**Calls:** 0xDBB2, 0xB2CD, 0xD48A, 0xB389, 0xD48A, 0xDDB0, 0xB427, 0xB4EA, 0xF2FC

**CFG Block:**
- ID: 19452
- Entry: 100D:B35A, Term: 100D:B362
- Preds: [15411], Succs: [1223, 19456]

---

### `pre_load_fixups` — seg000:B3B0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B3B0 pre_load_fixups
  cmp byte ptr DS:[0x46D9],0
  je short 0xB3BA
  jmp near 0x0E49
  add CL,0x31
  mov byte ptr DS:[0x38AF],CL
  mov CX,0x0578
  call near 0xF11C
  mov DX,0x38A8
  call near 0xF255
  mov AL,byte ptr DS:[0x00FB]
  push AX
  push DS
  push ES
  pop DS
  mov SI,DI
  add SI,CX
  dec SI
  mov DI,0x5779
  sub CX,2
  std
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  cld
  lea SI,DI+1
  xor DI,DI
  call near 0xB4BB
  mov SI,DI
  call near 0xB473
  pop DS
  call near 0x3AE9
  call near 0xDA53
  mov word ptr DS:[0x22A6],0xFFFF
  call near 0xB2BE
  pop AX
  mov byte ptr DS:[0x00FB],AL
  or AL,AL
  jns short 0xB41B
  cmp byte ptr DS:[0xDD02],0
  je short 0xB412
  call near 0xB915
  call near 0xB96B
```

**Calls:** 0xF11C, 0xF255, 0xB4BB, 0xB473, 0x3AE9, 0xDA53, 0xB2BE, 0xB915, 0xB96B

**CFG Block:**
- ID: 20206
- Entry: 100D:B3B0, Term: 100D:B3B5
- Preds: [15411, 37905], Succs: [20209, 37935]

---

### `load_game` — seg000:B3BA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B3BA load_game
  add CL,0x31
  mov byte ptr DS:[0x38AF],CL
  mov CX,0x0578
  call near 0xF11C
  mov DX,0x38A8
  call near 0xF255
  mov AL,byte ptr DS:[0x00FB]
  push AX
  push DS
  push ES
  pop DS
  mov SI,DI
  add SI,CX
  dec SI
  mov DI,0x5779
  sub CX,2
  std
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  cld
  lea SI,DI+1
  xor DI,DI
  call near 0xB4BB
  mov SI,DI
  call near 0xB473
  pop DS
  call near 0x3AE9
  call near 0xDA53
  mov word ptr DS:[0x22A6],0xFFFF
  call near 0xB2BE
  pop AX
  mov byte ptr DS:[0x00FB],AL
  or AL,AL
  jns short 0xB41B
  cmp byte ptr DS:[0xDD02],0
  je short 0xB412
  call near 0xB915
  call near 0xB96B
  call near 0xB8EA
  jmp near 0xBA9E
  call near 0xD2BD
```

**Calls:** 0xF11C, 0xF255, 0xB4BB, 0xB473, 0x3AE9, 0xDA53, 0xB2BE, 0xB915, 0xB96B, 0xB8EA, 0xD2BD

**CFG Block:**
- ID: 20209
- Entry: 100D:B3BA, Term: 100D:B3C4
- Preds: [20206], Succs: [516, 20214]

---

### `post_load_fixups` — seg000:B3F1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B3F1 post_load_fixups
  call near 0x3AE9
  call near 0xDA53
  mov word ptr DS:[0x22A6],0xFFFF
  call near 0xB2BE
  pop AX
  mov byte ptr DS:[0x00FB],AL
  or AL,AL
  jns short 0xB41B
  cmp byte ptr DS:[0xDD02],0
  je short 0xB412
  call near 0xB915
  call near 0xB96B
  call near 0xB8EA
  jmp near 0xBA9E
  call near 0xD2BD
  call near 0x1A0F
  call near 0xADBE
  jmp near 0x2DB1
  mov CX,0x0578
  call near 0xF11C
  mov DI,0x0100
  push DI
  push ES
  push DS
  lds SI,word ptr DS:[0xDCFE]
  xor SI,SI
  mov CX,0xC5FC
  shr CX,1
  shr CX,1
  mov AH,3
  lods AL,byte ptr DS:[SI]
  shl AL,1
  shl AL,1
  shl AX,1
  shl AX,1
  jae short 0xB442
  mov AL,AH
  stos byte ptr ES:[DI],AL
  loop 0xB440
  push CS
```

**Calls:** 0x3AE9, 0xDA53, 0xB2BE, 0xB915, 0xB96B, 0xB8EA, 0xD2BD, 0x1A0F, 0xADBE, 0xF11C

**Called from:** 100D:3AE9

---

## sequence.rs (7 functions)

### `sequence_action_07_show_spice_map` — seg000:13A0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:13A0 sequence_action_07_show_spice_map
  call near 0x1399
  or byte ptr DS:[0x46EB],0x40
  jmp short 0x13B6
  call near 0x58FA
  call near 0xC08E
  mov SI,0x18E9
  call near 0xC551
  mov AX,0x000F
  call near 0xC08E
  call near 0x9761
  call near 0x9EFD
  call near 0x9901
  jmp near 0xC07C
  lods AL,byte ptr CS:[SI]
  mov byte ptr DS:[4],AL
  mov word ptr DS:[0x4778],SI
  lods AL,byte ptr CS:[SI]
  xor AH,AH
  add SI,AX
  mov word ptr DS:[0x477A],SI
  call near 0x1392
  call near 0x2DB1
  jmp near 0x1707
  call near 0x1399
  push SI
  call near 0x8C8A
  pop SI
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  cmp AX,word ptr DS:[0x47C4]
  je short 0x1408
  cmp byte ptr DS:[0x47A4],AH
  jns short 0x1408
  push AX
  mov BP,0x2DB1
  call near 0xC097
  pop AX
  jmp near 0x9761
  call near 0x1392
```

**Calls:** 0x1399, 0x58FA, 0xC08E, 0xC551, 0xC08E, 0x9761, 0x9EFD, 0x9901, 0x1392, 0x2DB1, 0x1399, 0x8C8A, 0xC097, 0x1392

**Called from:** 100D:1399

**CFG Block:**
- ID: 28395
- Entry: 100D:13A0, Term: 100D:13A0
- Preds: [28390], Succs: [28397, 28400]

---

### `sequence_action_08_hide_spice_map` — seg000:13AA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:13AA sequence_action_08_hide_spice_map
  call near 0x58FA
  call near 0xC08E
  mov SI,0x18E9
  call near 0xC551
  mov AX,0x000F
  call near 0xC08E
  call near 0x9761
  call near 0x9EFD
  call near 0x9901
  jmp near 0xC07C
  lods AL,byte ptr CS:[SI]
  mov byte ptr DS:[4],AL
  mov word ptr DS:[0x4778],SI
  lods AL,byte ptr CS:[SI]
  xor AH,AH
  add SI,AX
  mov word ptr DS:[0x477A],SI
  call near 0x1392
  call near 0x2DB1
  jmp near 0x1707
  call near 0x1399
  push SI
  call near 0x8C8A
  pop SI
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  cmp AX,word ptr DS:[0x47C4]
  je short 0x1408
  cmp byte ptr DS:[0x47A4],AH
  jns short 0x1408
  push AX
  mov BP,0x2DB1
  call near 0xC097
  pop AX
  jmp near 0x9761
  call near 0x1392
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
```

**Calls:** 0x58FA, 0xC08E, 0xC551, 0xC08E, 0x9761, 0x9EFD, 0x9901, 0x1392, 0x2DB1, 0x1399, 0x8C8A, 0xC097, 0x1392

**Called from:** 100D:58FA

**CFG Block:**
- ID: 29004
- Entry: 100D:13AA, Term: 100D:13AA
- Preds: [28390], Succs: [23606, 29023]

---

### `sequence_present_line` — seg000:13B6

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:13B6 sequence_present_line
  mov AX,0x000F
  call near 0xC08E
  call near 0x9761
  call near 0x9EFD
  call near 0x9901
  jmp near 0xC07C
  lods AL,byte ptr CS:[SI]
  mov byte ptr DS:[4],AL
  mov word ptr DS:[0x4778],SI
  lods AL,byte ptr CS:[SI]
  xor AH,AH
  add SI,AX
  mov word ptr DS:[0x477A],SI
  call near 0x1392
  call near 0x2DB1
  jmp near 0x1707
  call near 0x1399
  push SI
  call near 0x8C8A
  pop SI
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  cmp AX,word ptr DS:[0x47C4]
  je short 0x1408
  cmp byte ptr DS:[0x47A4],AH
  jns short 0x1408
  push AX
  mov BP,0x2DB1
  call near 0xC097
  pop AX
  jmp near 0x9761
  call near 0x1392
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  mov word ptr DS:[0x47C4],AX
  call near 0x978E
  call near 0x9B8B
  jmp near 0x1707
```

**Calls:** 0xC08E, 0x9761, 0x9EFD, 0x9901, 0x1392, 0x2DB1, 0x1399, 0x8C8A, 0xC097, 0x1392, 0x978E, 0x9B8B

**CFG Block:**
- ID: 28403
- Entry: 100D:13B6, Term: 100D:13B9
- Preds: [16829, 28400, 29025], Succs: [737, 28406]

---

### `sequence_action_01_speaker_line` — seg000:13E4

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:13E4 sequence_action_01_speaker_line
  call near 0x1399
  push SI
  call near 0x8C8A
  pop SI
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  cmp AX,word ptr DS:[0x47C4]
  je short 0x1408
  cmp byte ptr DS:[0x47A4],AH
  jns short 0x1408
  push AX
  mov BP,0x2DB1
  call near 0xC097
  pop AX
  jmp near 0x9761
  call near 0x1392
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  mov word ptr DS:[0x47C4],AX
  call near 0x978E
  call near 0x9B8B
  jmp near 0x1707
  call near 0x1392
  call near 0x1AE0
  cmp AL,0x0D
  jae short 0x1434
  mov CX,1
  call near 0x0FD9
  jmp short 0x1422
  call near 0x390A
  call near 0x37B2
  call near 0xC412
  mov SI,0x2290
  jmp short 0x1465
  call near 0x1392
  call near 0x37B2
  mov ES,word ptr DS:[0xDBDE]
  push DS
```

**Calls:** 0x1399, 0x8C8A, 0xC097, 0x1392, 0x978E, 0x9B8B, 0x1392, 0x1AE0, 0x0FD9, 0x390A, 0x37B2, 0xC412, 0x1392, 0x37B2

**Called from:** 100D:1399

**CFG Block:**
- ID: 30394
- Entry: 100D:13E4, Term: 100D:13E4
- Preds: [28390], Succs: [28397, 30396]

---

### `sequence_action_03_set_speaker` — seg000:140B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:140B sequence_action_03_set_speaker
  call near 0x1392
  lods AL,byte ptr CS:[SI]
  inc word ptr DS:[0x477A]
  xor AH,AH
  mov word ptr DS:[0x47C4],AX
  call near 0x978E
  call near 0x9B8B
  jmp near 0x1707
  call near 0x1392
  call near 0x1AE0
  cmp AL,0x0D
  jae short 0x1434
  mov CX,1
  call near 0x0FD9
  jmp short 0x1422
  call near 0x390A
  call near 0x37B2
  call near 0xC412
  mov SI,0x2290
  jmp short 0x1465
  call near 0x1392
  call near 0x37B2
  mov ES,word ptr DS:[0xDBDE]
  push DS
  mov DS,word ptr DS:[0xDBDA]
  xor DX,DX
  mov BX,0x0032
  mov BP,3
  call far dword ptr SS:[0x3949]
  pop DS
  call near 0xC43E
  mov SI,0x2298
  mov AX,0x0027
  call near 0xC13E
  call near 0xC21B
  call near 0xC0F4
  jmp near 0xC4DD
  ret near
```

**Calls:** 0x1392, 0x978E, 0x9B8B, 0x1392, 0x1AE0, 0x0FD9, 0x390A, 0x37B2, 0xC412, 0x1392, 0x37B2, indirect, 0xC43E, 0xC13E, 0xC21B, 0xC0F4

**Called from:** 100D:1392

**CFG Block:**
- ID: 30417
- Entry: 100D:140B, Term: 100D:140B
- Preds: [28390], Succs: [30369, 30419]

---

### `menu_callback_choice_continue` — seg000:171A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:171A menu_callback_choice_continue
  mov byte ptr DS:[0xCE9D],0
  mov SI,word ptr DS:[0x477A]
  lods AL,byte ptr CS:[SI]
  cmp AL,0xFF
  je short 0x1736
  mov word ptr DS:[0x477A],SI
  xor AH,AH
  mov BX,AX
  jmp near word ptr CS:[BX+0x1475]
  mov SI,0x176B
  call near 0xDA5F
  mov AX,word ptr DS:[0x4776]
  mov byte ptr DS:[4],AL
  mov byte ptr DS:[0x46E0],AH
  xor AL,AL
  mov byte ptr DS:[0x4774],AL
  cmp byte ptr DS:[0x002A],0x48
  je short 0x1755
  call near 0xADBE
  call near 0xB2BE
  cmp byte ptr DS:[0x00FB],0
  js short 0x1762
  jmp near 0x0FA7
  call near 0xAD5E
  call near 0x68EB
  jmp near 0x780A
  xor byte ptr DS:[0x4775],0xFF
  ret near
```

**Calls:** 0xDA5F, 0xADBE, 0xB2BE, 0xAD5E, 0x68EB

**CFG Block:**
- ID: 28384
- Entry: 100D:171A, Term: 100D:1727
- Preds: [28376, 28382], Succs: [28390, 29028]

---

### `sequence_end` — seg000:1736

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:1736 sequence_end
  mov SI,0x176B
  call near 0xDA5F
  mov AX,word ptr DS:[0x4776]
  mov byte ptr DS:[4],AL
  mov byte ptr DS:[0x46E0],AH
  xor AL,AL
  mov byte ptr DS:[0x4774],AL
  cmp byte ptr DS:[0x002A],0x48
  je short 0x1755
  call near 0xADBE
  call near 0xB2BE
  cmp byte ptr DS:[0x00FB],0
  js short 0x1762
  jmp near 0x0FA7
  call near 0xAD5E
  call near 0x68EB
  jmp near 0x780A
  xor byte ptr DS:[0x4775],0xFF
  ret near
```

**Calls:** 0xDA5F, 0xADBE, 0xB2BE, 0xAD5E, 0x68EB

**CFG Block:**
- ID: 29028
- Entry: 100D:1736, Term: 100D:1739
- Preds: [28384], Succs: [1839, 29031]

---

## settings_ui.rs (11 functions)

### `open_mixer_panel` — seg000:A3F0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A3F0 open_mixer_panel
  mov AX,0x1AD6
  call near 0xD95E
  call near 0xD2BD
  push word ptr DS:[0xDBDA]
  call near 0xC08E
  mov AX,0x0055
  call near 0xC13E
  xor AX,AX
  mov DX,word ptr DS:[0x2886]
  mov BX,word ptr DS:[0x2888]
  call near 0xC22F
  pop word ptr DS:[0xDBDA]
  call near 0xA4C6
  call near 0xA47D
  call near 0xA42C
  call near 0xA44C
  call near 0xAC3A
  mov BX,0xA541
  jmp near 0xD32F
  mov AX,0x0055
  call near 0xC13E
  mov AL,byte ptr DS:[0xCEEB]
  push word ptr DS:[0xDBDA]
  call near 0xC08E
  cbw
  call near 0xA465
  shl AX,1
  add AL,0x1C
  call near 0xC22F
  pop word ptr DS:[0xDBDA]
  ret near
```

**Calls:** 0xD95E, 0xD2BD, 0xC08E, 0xC13E, 0xC22F, 0xA4C6, 0xA47D, 0xA42C, 0xA44C, 0xAC3A, 0xC13E, 0xC08E, 0xA465, 0xC22F

**CFG Block:**
- ID: 25335
- Entry: 100D:A3F0, Term: 100D:A3F3
- Preds: [15411], Succs: [18375, 25338]

---

### `settings_ui_draw` — seg000:A3F9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A3F9 settings_ui_draw
  push word ptr DS:[0xDBDA]
  call near 0xC08E
  mov AX,0x0055
  call near 0xC13E
  xor AX,AX
  mov DX,word ptr DS:[0x2886]
  mov BX,word ptr DS:[0x2888]
  call near 0xC22F
  pop word ptr DS:[0xDBDA]
  call near 0xA4C6
  call near 0xA47D
  call near 0xA42C
  call near 0xA44C
  call near 0xAC3A
  mov BX,0xA541
  jmp near 0xD32F
  mov AX,0x0055
  call near 0xC13E
  mov AL,byte ptr DS:[0xCEEB]
  push word ptr DS:[0xDBDA]
  call near 0xC08E
  cbw
  call near 0xA465
  shl AX,1
  add AL,0x1C
  call near 0xC22F
  pop word ptr DS:[0xDBDA]
  ret near
```

**Calls:** 0xC08E, 0xC13E, 0xC22F, 0xA4C6, 0xA47D, 0xA42C, 0xA44C, 0xAC3A, 0xC13E, 0xC08E, 0xA465, 0xC22F

**CFG Block:**
- ID: 25340
- Entry: 100D:A3F9, Term: 100D:A3FD
- Preds: [13230, 25338, 25656], Succs: [737, 25343]

---

### `settings_ui_play_test_voice` — seg000:A553

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A553 settings_ui_play_test_voice
  call near 0xAE2F
  je short 0xA540
  mov AX,4
  mov BX,5
  call near 0xA8BC
  call near 0xA83F
  call near 0xADE0
  mov byte ptr DS:[0xDC2B],1
  mov SI,0x3811
  call far dword ptr DS:[0x3991]
  jmp near 0xABA9
  mov DI,0x2886
  call near 0xD6FE
  jb short 0xA581
  call near 0xA453
  mov DI,0x28BF
  call near 0xD6FE
  jb short 0xA553
  mov DI,0x28C7
  call near 0xD6FE
  jb short 0xA5B0
  call near 0xA672
  jae short 0xA59F
  mov byte ptr DS:[0x28BE],1
  ret near
```

**Calls:** 0xAE2F, 0xA8BC, 0xA83F, 0xADE0, indirect, 0xD6FE, 0xA453, 0xD6FE, 0xD6FE, 0xA672

**Called from:** 100D:AE2F

**CFG Block:**
- ID: 25717
- Entry: 100D:A553, Term: 100D:A553
- Preds: [25541], Succs: [1792, 25719]

---

### `mixer_panel_click_interior` — seg000:A581

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A581 mixer_panel_click_interior
  call near 0xA453
  mov DI,0x28BF
  call near 0xD6FE
  jb short 0xA553
  mov DI,0x28C7
  call near 0xD6FE
  jb short 0xA5B0
  call near 0xA672
  jae short 0xA59F
  mov byte ptr DS:[0x28BE],1
  ret near
```

**Calls:** 0xA453, 0xD6FE, 0xD6FE, 0xA672

**Called from:** 100D:A453

**CFG Block:**
- ID: 25532
- Entry: 100D:A581, Term: 100D:A581
- Preds: [25530], Succs: [25534, 25538]

---

### `mixer_panel_button_grid_click` — seg000:A5B0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:A5B0 mixer_panel_button_grid_click
  sub BX,word ptr DS:[DI+2]
  mov AX,BX
  mov BL,7
  div BL
  mov BX,0x28CF
  xlat byte ptr DS:[BX+AL]
  cmp AL,7
  jb short 0xA5CA
  je short 0xA5DE
  sub AL,8
  mov byte ptr DS:[0x28E7],AL
  jmp short 0xA5DB
  cmp AL,byte ptr DS:[0xCEEB]
  je short 0xA5DE
  and byte ptr DS:[0x28E7],0xFD
  mov byte ptr DS:[0xCEEB],AL
  call near 0xCFE4
  jmp near 0xA3F9
  call near 0xA453
  sub BX,CX
  call near 0xA594
  cmp byte ptr DS:[0x28BE],1
  je short 0xA61A
  cmp byte ptr DS:[0x28BE],2
  jne short 0xA619
  cmp AX,6
  jae short 0xA5FC
  neg CX
  cmp BP,5
  jb short 0xA603
  neg DI
  mov AL,0x0A
  add CX,DI
  jns short 0xA60B
  neg AL
  add AL,byte ptr DS:[SI]
  cmp AL,0xF1
  jae short 0xA619
  mov byte ptr DS:[SI],AL
  push word ptr DS:[SI+6]
```

**Calls:** 0xCFE4, 0xA453, 0xA594

**CFG Block:**
- ID: 25641
- Entry: 100D:A5B0, Term: 100D:A5BF
- Preds: [25546], Succs: [25650, 25681]

---

### `menu_callback_choice_music_on_game_relative` — seg000:AC6E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AC6E menu_callback_choice_music_on_game_relative
  and byte ptr DS:[0x2943],0xEF
  mov byte ptr DS:[0x3810],0
  call near 0xD2E2
  jmp near 0xAD5E
  mov BP,0x206A
  mov BX,0xD917
  mov CL,byte ptr DS:[0x3810]
  and CX,2
  shr CL,1
  jmp near 0xD32F
  or byte ptr DS:[0x3810],3
  jmp short 0xACAE
  or byte ptr DS:[0x3810],1
  and byte ptr DS:[0x3810],0xFD
  push DS
  pop ES
  mov SI,0x3804
  mov DI,0x37FA
  mov CX,9
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  call near 0xAEB7
  call near 0xD2FD
  call near 0xD2E2
  and byte ptr DS:[0x2943],0xEF
  jmp short 0xAD21
  mov BP,0x37FA
  mov CX,0x0012
  mov BX,8
  call near 0xE3DF
  mov SI,AX
  mov AX,word ptr DS:[0xCE7A]
  xor AX,CX
  add word ptr DS:[0xD828],AX
  call near 0xE3DF
  mov DI,AX
  mov AL,byte ptr SS:[BP+SI]
  xchg AL,byte ptr SS:[BP+DI]
  mov byte ptr SS:[BP+SI],AL
  loop 0xACC5
  mov SI,BP
```

**Calls:** 0xD2E2, 0xAEB7, 0xD2FD, 0xD2E2, 0xE3DF, 0xE3DF

**CFG Block:**
- ID: 25799
- Entry: 100D:AC6E, Term: 100D:AC78
- Preds: [15411], Succs: [16237, 25803]

---

### `menu_callback_choice_music_on_cd_style` — seg000:AC7E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AC7E menu_callback_choice_music_on_cd_style
  mov BP,0x206A
  mov BX,0xD917
  mov CL,byte ptr DS:[0x3810]
  and CX,2
  shr CL,1
  jmp near 0xD32F
  or byte ptr DS:[0x3810],3
  jmp short 0xACAE
  or byte ptr DS:[0x3810],1
  and byte ptr DS:[0x3810],0xFD
  push DS
  pop ES
  mov SI,0x3804
  mov DI,0x37FA
  mov CX,9
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  call near 0xAEB7
  call near 0xD2FD
  call near 0xD2E2
  and byte ptr DS:[0x2943],0xEF
  jmp short 0xAD21
  mov BP,0x37FA
  mov CX,0x0012
  mov BX,8
  call near 0xE3DF
  mov SI,AX
  mov AX,word ptr DS:[0xCE7A]
  xor AX,CX
  add word ptr DS:[0xD828],AX
  call near 0xE3DF
  mov DI,AX
  mov AL,byte ptr SS:[BP+SI]
  xchg AL,byte ptr SS:[BP+DI]
  mov byte ptr SS:[BP+SI],AL
  loop 0xACC5
  mov SI,BP
  ret near
```

**Calls:** 0xAEB7, 0xD2FD, 0xD2E2, 0xE3DF, 0xE3DF

**CFG Block:**
- ID: 25744
- Entry: 100D:AC7E, Term: 100D:AC8D
- Preds: [15411], Succs: [25516]

---

### `menu_callback_choice_music_cd_order_shuffle` — seg000:AC90

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AC90 menu_callback_choice_music_cd_order_shuffle
  or byte ptr DS:[0x3810],3
  jmp short 0xACAE
  or byte ptr DS:[0x3810],1
  and byte ptr DS:[0x3810],0xFD
  push DS
  pop ES
  mov SI,0x3804
  mov DI,0x37FA
  mov CX,9
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  call near 0xAEB7
  call near 0xD2FD
  call near 0xD2E2
  and byte ptr DS:[0x2943],0xEF
  jmp short 0xAD21
  mov BP,0x37FA
  mov CX,0x0012
  mov BX,8
  call near 0xE3DF
  mov SI,AX
  mov AX,word ptr DS:[0xCE7A]
  xor AX,CX
  add word ptr DS:[0xD828],AX
  call near 0xE3DF
  mov DI,AX
  mov AL,byte ptr SS:[BP+SI]
  xchg AL,byte ptr SS:[BP+DI]
  mov byte ptr SS:[BP+SI],AL
  loop 0xACC5
  mov SI,BP
  ret near
```

**Calls:** 0xAEB7, 0xD2FD, 0xD2E2, 0xE3DF, 0xE3DF

**CFG Block:**
- ID: 25751
- Entry: 100D:AC90, Term: 100D:AC95
- Preds: [15411], Succs: [25754]

---

### `menu_callback_choice_music_cd_order_standard` — seg000:AC97

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AC97 menu_callback_choice_music_cd_order_standard
  or byte ptr DS:[0x3810],1
  and byte ptr DS:[0x3810],0xFD
  push DS
  pop ES
  mov SI,0x3804
  mov DI,0x37FA
  mov CX,9
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  call near 0xAEB7
  call near 0xD2FD
  call near 0xD2E2
  and byte ptr DS:[0x2943],0xEF
  jmp short 0xAD21
  mov BP,0x37FA
  mov CX,0x0012
  mov BX,8
  call near 0xE3DF
  mov SI,AX
  mov AX,word ptr DS:[0xCE7A]
  xor AX,CX
  add word ptr DS:[0xD828],AX
  call near 0xE3DF
  mov DI,AX
  mov AL,byte ptr SS:[BP+SI]
  xchg AL,byte ptr SS:[BP+DI]
  mov byte ptr SS:[BP+SI],AL
  loop 0xACC5
  mov SI,BP
  ret near
```

**Calls:** 0xAEB7, 0xD2FD, 0xD2E2, 0xE3DF, 0xE3DF

**CFG Block:**
- ID: 25805
- Entry: 100D:AC97, Term: 100D:ACAC
- Preds: [15411], Succs: [25754]

---

### `music_cd_start_selected_order` — seg000:ACAE

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:ACAE music_cd_start_selected_order
  call near 0xAEB7
  call near 0xD2FD
  call near 0xD2E2
  and byte ptr DS:[0x2943],0xEF
  jmp short 0xAD21
  mov BP,0x37FA
  mov CX,0x0012
  mov BX,8
  call near 0xE3DF
  mov SI,AX
  mov AX,word ptr DS:[0xCE7A]
  xor AX,CX
  add word ptr DS:[0xD828],AX
  call near 0xE3DF
  mov DI,AX
  mov AL,byte ptr SS:[BP+SI]
  xchg AL,byte ptr SS:[BP+DI]
  mov byte ptr SS:[BP+SI],AL
  loop 0xACC5
  mov SI,BP
  ret near
```

**Calls:** 0xAEB7, 0xD2FD, 0xD2E2, 0xE3DF, 0xE3DF

**Called from:** 100D:AEB7

**CFG Block:**
- ID: 25754
- Entry: 100D:ACAE, Term: 100D:ACAE
- Preds: [25751, 25805], Succs: [3389, 25756]

---

### `menu_callback_choice_music_off` — seg000:AEAF

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:AEAF menu_callback_choice_music_off
  or byte ptr DS:[0x2943],0x10
  call near 0xD2E2
  push AX
  mov byte ptr DS:[0xDBCB],0
  call far dword ptr DS:[0x3975]
  mov byte ptr DS:[0xDBCD],AL
  pop AX
  ret near
```

**Calls:** 0xD2E2, indirect

**CFG Block:**
- ID: 25815
- Entry: 100D:AEAF, Term: 100D:AEB4
- Preds: [15411], Succs: [3389, 16237]

---

## talking_head.rs (3 functions)

### `draw_talking_head_in_box` — seg000:7AC1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:7AC1 draw_talking_head_in_box
  mov SI,0x22B9
  add SI,AX
  lods AX,word ptr DS:[SI]
  mov word ptr DS:[0x46D2],AX
  lods AX,word ptr DS:[SI]
  mov word ptr DS:[0x46D4],AX
  push DS
  mov SI,word ptr SS:[0x47CA]
  mov DS,word ptr SS:[0xDBB2]
  add SI,word ptr DS:[BP+SI]
  mov DX,word ptr SS:[0x18F3]
  mov BX,word ptr SS:[0x18F5]
  inc BX
  inc DX
  mov word ptr SS:[0x47D4],DX
  mov word ptr SS:[0x47D6],BX
  add DX,0x003B
  add BX,0x003B
  mov word ptr SS:[0x47D8],DX
  mov word ptr SS:[0x47DA],BX
  call near 0x9D6A
  pop DS
  mov SI,0x47D4
  call near 0xC4AA
  jmp near 0xC13B
  mov byte ptr DS:[0x46D8],0
  push SI
  xchg SI,DI
  call near 0xC0E8
  pop SI
  mov ES,word ptr DS:[0xDBDA]
  mov AL,byte ptr DS:[SI+9]
  push SI
  call far dword ptr DS:[0x38DD]
  pop SI
  jmp near 0xC551
  cmp byte ptr DS:[0x46D8],0
  jne short 0x7B35
  jmp near 0xC0E8
  ret near
```

**Calls:** 0x9D6A, 0xC4AA, 0xC0E8, indirect

**CFG Block:**
- ID: 34548
- Entry: 100D:7AC1, Term: 100D:7B02
- Preds: [24192, 34545], Succs: [24223, 24280]

---

### `present_head_dirty_rect` — seg000:9A0D

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9A0D present_head_dirty_rect
  call near 0x908C
  mov SI,0xD834
  call near 0xDB74
  call near 0xC4F0
  jmp near 0xDB67
  ret near
```

**Calls:** 0x908C, 0xDB74, 0xC4F0

**Called from:** 100D:908C

**CFG Block:**
- ID: 9261
- Entry: 100D:9A0D, Term: 100D:9A0D
- Preds: [8367], Succs: [9010, 9263]

---

### `mouth_clip_rect` — seg000:9DF8

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:9DF8 mouth_clip_rect
  mov DI,0xD834
  call near 0x5B99
  mov DX,word ptr DS:[0x1BF0]
  mov BX,word ptr DS:[0x1BF2]
  add word ptr DS:[DI-8],DX
  add word ptr DS:[DI-6],BX
  add word ptr DS:[DI-4],DX
  add word ptr DS:[DI-2],BX
  mov SI,word ptr DS:[0x47D2]
  mov AH,byte ptr DS:[0x47D0]
  dec AH
  js short 0x9E2D
  cmp word ptr DS:[0x22A6],0x000D
  jne short 0x9E27
  add AL,AH
  shl AH,1
  shl AH,1
  add AL,AH
  xor AH,AH
  shl AX,1
  add SI,AX
  call near 0x9BEE
  mov SI,0x4608
  cmp byte ptr DS:[0x00EA],0
  jg short 0x9E74
  cmp word ptr DS:[SI],2
  jb short 0x9E57
  call near 0x9D2D
  call near 0x908C
  mov SI,0xD834
  call near 0xDB74
  call near 0xC4F0
  jmp near 0xDB67
  mov SI,0xD834
  call near 0xDB74
  push word ptr DS:[0xDBDA]
  call near 0xC08E
  mov SI,0x4608
  call near 0x9D2D
  call near 0x908C
```

**Calls:** 0x5B99, 0x9BEE, 0x9D2D, 0x908C, 0xDB74, 0xC4F0, 0xDB74, 0xC08E, 0x9D2D, 0x908C

**CFG Block:**
- ID: 8748
- Entry: 100D:9DF8, Term: 100D:9DFB
- Preds: [8743], Succs: [2679, 8751]

---

## travel_map_screen.rs (19 functions)

### `travel_settle_companion_dispatch` — seg000:35E9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:35E9 travel_settle_companion_dispatch
  xor AX,AX
  mov byte ptr DS:[0x001A],AL
  mov byte ptr DS:[0x47A7],AL
  mov byte ptr DS:[0x0023],AL
  xchg AL,byte ptr DS:[0x47A6]
  or AL,AL
  jne short 0x35AC
  cmp word ptr DS:[0x1152],-1
  je short 0x3637
  call near 0x40F9
  call near 0x4182
  cmp byte ptr DS:[0x0023],0
  je short 0x3636
  call near 0x366F
  js short 0x3636
  call near 0xDBB2
  call near 0x368B
  push AX
  mov AX,0x004B
  call near 0xE387
  pop AX
  push AX
  call near 0x96D8
  pop AX
  jb short 0x3636
  mov CL,0x10
  mul CL
  add AX,0x0FD8
  mov SI,AX
  call near 0x3551
  ret near
```

**Calls:** 0x40F9, 0x4182, 0x366F, 0xDBB2, 0x368B, 0xE387, 0x96D8, 0x3551

**CFG Block:**
- ID: 22071
- Entry: 100D:35E9, Term: 100D:35FA
- Preds: [14500], Succs: [14510, 22079]

---

### `menu_callback_choice_map_main_take_an_ornithopter` — seg000:42D9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:42D9 menu_callback_choice_map_main_take_an_ornithopter
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  mov DL,1
  call near 0x4057
  call near 0x186B
  call near 0x98B2
  call near 0x38E1
  mov AX,0x0024
  call near 0xC13E
  mov byte ptr DS:[0x473E],1
  mov byte ptr DS:[0x11C9],4
  mov word ptr DS:[0x487E],2
  mov BP,0x212E
  call near 0x49EA
  mov BX,0x4415
  call near 0xD323
  mov AX,0x1AC8
  call near 0xD95E
  call near 0x4ACA
  mov word ptr DS:[0x46FC],0
  call near 0x5B5D
  mov byte ptr DS:[0x46EB],1
  mov SI,0x1CCA
  call near 0xD72B
  mov SI,0x149C
  mov DI,0x46E3
  call near 0xDAAA
  call near 0x5B99
  call near 0x439F
  mov AX,0x02BC
  call near 0xAB4F
  call near 0x4658
  mov word ptr DS:[0x46ED],0x4377
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
  cmp byte ptr DS:[0x473E],0
  je short 0x436E
  mov AX,0x0024
```

**Calls:** 0x4057, 0x186B, 0x98B2, 0x38E1, 0xC13E, 0x49EA, 0xD323, 0xD95E, 0x4ACA, 0x5B5D, 0xD72B, 0xDAAA, 0x5B99, 0x439F, 0xAB4F, 0x4658, 0x5B93, 0xB6C3, 0xC137, 0x5DCE

**CFG Block:**
- ID: 28191
- Entry: 100D:42D9, Term: 100D:42E3
- Preds: [15411], Succs: [19910, 28196]

---

### `menu_callback_choice_map_main_take_an_ornithopter_notransition` — seg000:42E9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:42E9 menu_callback_choice_map_main_take_an_ornithopter_notransition
  call near 0x98B2
  call near 0x38E1
  mov AX,0x0024
  call near 0xC13E
  mov byte ptr DS:[0x473E],1
  mov byte ptr DS:[0x11C9],4
  mov word ptr DS:[0x487E],2
  mov BP,0x212E
  call near 0x49EA
  mov BX,0x4415
  call near 0xD323
  mov AX,0x1AC8
  call near 0xD95E
  call near 0x4ACA
  mov word ptr DS:[0x46FC],0
  call near 0x5B5D
  mov byte ptr DS:[0x46EB],1
  mov SI,0x1CCA
  call near 0xD72B
  mov SI,0x149C
  mov DI,0x46E3
  call near 0xDAAA
  call near 0x5B99
  call near 0x439F
  mov AX,0x02BC
  call near 0xAB4F
  call near 0x4658
  mov word ptr DS:[0x46ED],0x4377
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
  cmp byte ptr DS:[0x473E],0
  je short 0x436E
  mov AX,0x0024
  call near 0xC13E
  mov SI,0x14C0
  call near 0xC21B
  call near 0xC0F4
  call near 0xC4DD
```

**Calls:** 0x98B2, 0x38E1, 0xC13E, 0x49EA, 0xD323, 0xD95E, 0x4ACA, 0x5B5D, 0xD72B, 0xDAAA, 0x5B99, 0x439F, 0xAB4F, 0x4658, 0x5B93, 0xB6C3, 0xC137, 0x5DCE, 0xC13E, 0xC21B, 0xC0F4, 0xC4DD

**Called from:** 100D:98B2

**CFG Block:**
- ID: 20660
- Entry: 100D:42E9, Term: 100D:42E9
- Preds: [13209, 15411, 28196, 37525], Succs: [7865, 20662]

---

### `map_screen_open_with_cancel_menu` — seg000:4305

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4305 map_screen_open_with_cancel_menu
  mov BP,0x212E
  call near 0x49EA
  mov BX,0x4415
  call near 0xD323
  mov AX,0x1AC8
  call near 0xD95E
  call near 0x4ACA
  mov word ptr DS:[0x46FC],0
  call near 0x5B5D
  mov byte ptr DS:[0x46EB],1
  mov SI,0x1CCA
  call near 0xD72B
  mov SI,0x149C
  mov DI,0x46E3
  call near 0xDAAA
  call near 0x5B99
  call near 0x439F
  mov AX,0x02BC
  call near 0xAB4F
  call near 0x4658
  mov word ptr DS:[0x46ED],0x4377
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
  cmp byte ptr DS:[0x473E],0
  je short 0x436E
  mov AX,0x0024
  call near 0xC13E
  mov SI,0x14C0
  call near 0xC21B
  call near 0xC0F4
  call near 0xC4DD
  call near 0x445D
  jmp near 0xD280
  call near 0xC07C
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
```

**Calls:** 0x49EA, 0xD323, 0xD95E, 0x4ACA, 0x5B5D, 0xD72B, 0xDAAA, 0x5B99, 0x439F, 0xAB4F, 0x4658, 0x5B93, 0xB6C3, 0xC137, 0x5DCE, 0xC13E, 0xC21B, 0xC0F4, 0xC4DD, 0x445D, 0xC07C, 0x5B93, 0xB6C3, 0xC137, 0x5DCE

**CFG Block:**
- ID: 35119
- Entry: 100D:4305, Term: 100D:4308
- Preds: [20672, 35118], Succs: [20678, 20691]

---

### `map_screen_open` — seg000:430B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:430B map_screen_open
  mov BX,0x4415
  call near 0xD323
  mov AX,0x1AC8
  call near 0xD95E
  call near 0x4ACA
  mov word ptr DS:[0x46FC],0
  call near 0x5B5D
  mov byte ptr DS:[0x46EB],1
  mov SI,0x1CCA
  call near 0xD72B
  mov SI,0x149C
  mov DI,0x46E3
  call near 0xDAAA
  call near 0x5B99
  call near 0x439F
  mov AX,0x02BC
  call near 0xAB4F
  call near 0x4658
  mov word ptr DS:[0x46ED],0x4377
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
  cmp byte ptr DS:[0x473E],0
  je short 0x436E
  mov AX,0x0024
  call near 0xC13E
  mov SI,0x14C0
  call near 0xC21B
  call near 0xC0F4
  call near 0xC4DD
  call near 0x445D
  jmp near 0xD280
  call near 0xC07C
  call near 0x5B93
  call near 0xB6C3
  call near 0xC137
  call near 0x5DCE
  cmp byte ptr DS:[0x473E],0
  je short 0x4399
```

**Calls:** 0xD323, 0xD95E, 0x4ACA, 0x5B5D, 0xD72B, 0xDAAA, 0x5B99, 0x439F, 0xAB4F, 0x4658, 0x5B93, 0xB6C3, 0xC137, 0x5DCE, 0xC13E, 0xC21B, 0xC0F4, 0xC4DD, 0x445D, 0xC07C, 0x5B93, 0xB6C3, 0xC137, 0x5DCE

**CFG Block:**
- ID: 20691
- Entry: 100D:430B, Term: 100D:430E
- Preds: [20689, 28256, 35119], Succs: [19352, 20694]

---

### `map_confirm_travel_and_close` — seg000:4703

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4703 map_confirm_travel_and_close
  call near 0x4944
  call near 0x38E1
  mov AL,byte ptr DS:[0x11C9]
  push AX
  shr AL,1
  shr AL,1
  or byte ptr DS:[0x11C9],AL
  call near 0xAD5E
  cmp byte ptr DS:[0x002B],0
  je short 0x4727
  mov byte ptr DS:[0x002B],0
  call near 0x0B21
  call near 0xD2EA
  call near 0x4D00
  pop AX
  test AL,3
  jne short 0x478F
  mov word ptr DS:[0x472B],0
  push AX
  call near 0x41C5
  mov AL,byte ptr DS:[0x11C9]
  and AL,3
  dec AL
  jne short 0x4748
  call near 0x181E
  call near 0xC474
  call near 0x40D5
  pop AX
  mov BL,byte ptr DS:[0x11C7]
  push BX
  call near 0x4795
  pop AX
  mov byte ptr DS:[0x11C7],AL
  mov byte ptr DS:[8],0xFF
  call near 0x4B3B
  mov word ptr DS:[0x114E],0
  mov word ptr DS:[0x4729],0
  cmp byte ptr DS:[0x46EB],0
  js short 0x4779
  call near 0x2DBF
```

**Calls:** 0x4944, 0x38E1, 0xAD5E, 0x0B21, 0xD2EA, 0x4D00, 0x41C5, 0x181E, 0xC474, 0x40D5, 0x4795, 0x4B3B, 0x2DBF

**Called from:** 100D:4944

**CFG Block:**
- ID: 21484
- Entry: 100D:4703, Term: 100D:4703
- Preds: [21478, 26622], Succs: [21486, 21516]

---

### `orni_anim_loop` — seg000:47FB

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:47FB orni_anim_loop
  mov BP,0x4821
  mov AX,0x0014
  call near 0xE353
  add byte ptr DS:[0x4731],CL
  mov AL,byte ptr DS:[0x4731]
  cmp AL,0x1A
  jne short 0x4816
  or CL,CL
  js short 0x4816
  call near 0xAC30
  call near 0xAE04
  cmp byte ptr DS:[0x4731],0x21
  jb short 0x47FB
  ret near
```

**Calls:** 0xE353, 0xAC30, 0xAE04

**CFG Block:**
- ID: 21784
- Entry: 100D:47FB, Term: 100D:4801
- Preds: [21707, 21782], Succs: [21712, 21775]

---

### `menu_callback_choice_change_destination` — seg000:497A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:497A menu_callback_choice_change_destination
  call near 0x98E6
  mov BP,0x212E
  mov byte ptr DS:[0x4728],1
  jmp near 0x430B
  mov word ptr DS:[0x46FC],0
  call near 0x5B5D
  mov SI,0x148A
  mov DI,0x46E3
  call near 0x5B99
  mov word ptr DS:[0x46ED],0x49A0
  call near 0xC085
  call near 0x5B93
  mov byte ptr DS:[0x46EB],1
  call near 0xB6C3
  call near 0x5B69
  call near 0xC137
  call near 0x5DCE
  mov SI,word ptr DS:[0x11C5]
  or SI,SI
  je short 0x49CC
  call near 0x62C9
  jb short 0x49CC
  dec BX
  dec DX
  mov AX,0x002E
  call near 0xC22F
  mov byte ptr DS:[0x46EB],0
  jmp near 0xC07C
  call near 0x4988
  jmp short 0x49E3
  jmp short 0x4A5A
  mov byte ptr DS:[0x4728],0
  push CS
  pop ES
  mov DI,0xE40C
  mov AX,0x0800
  stos word ptr ES:[DI],AX
  stos word ptr ES:[DI],AX
  cmp DI,0xE85C
  jb short 0x49F7
```

**Calls:** 0x98E6, 0x5B5D, 0x5B99, 0xC085, 0x5B93, 0xB6C3, 0x5B69, 0xC137, 0x5DCE, 0x62C9, 0xC22F, 0x4988

**Called from:** 100D:98E6

**CFG Block:**
- ID: 28254
- Entry: 100D:497A, Term: 100D:497A
- Preds: [15411], Succs: [3504, 28256]

---

### `travel_minimap_redraw` — seg000:49A0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:49A0 travel_minimap_redraw
  call near 0xC085
  call near 0x5B93
  mov byte ptr DS:[0x46EB],1
  call near 0xB6C3
  call near 0x5B69
  call near 0xC137
  call near 0x5DCE
  mov SI,word ptr DS:[0x11C5]
  or SI,SI
  je short 0x49CC
  call near 0x62C9
  jb short 0x49CC
  dec BX
  dec DX
  mov AX,0x002E
  call near 0xC22F
  mov byte ptr DS:[0x46EB],0
  jmp near 0xC07C
  call near 0x4988
  jmp short 0x49E3
  jmp short 0x4A5A
  mov byte ptr DS:[0x4728],0
  push CS
  pop ES
  mov DI,0xE40C
  mov AX,0x0800
  stos word ptr ES:[DI],AX
  stos word ptr ES:[DI],AX
  cmp DI,0xE85C
  jb short 0x49F7
  ret near
```

**Calls:** 0xC085, 0x5B93, 0xB6C3, 0x5B69, 0xC137, 0x5DCE, 0x62C9, 0xC22F, 0x4988

**Called from:** 100D:C085

---

### `travel_refresh_view` — seg000:49D9

**Status:** Never executed during discovery.

---

### `hnm_present_flight_frame` — seg000:4AFD

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4AFD hnm_present_flight_frame
  cmp byte ptr DS:[0x227D],0
  jne short 0x4B16
  call near 0x4B2B
  mov ES,word ptr DS:[0xDBD8]
  mov SI,word ptr DS:[0xDBD6]
  call far dword ptr DS:[0x38FD]
  jmp near 0xDBE3
  mov AX,word ptr DS:[0xDBD8]
  mov SI,word ptr DS:[0xDBD6]
  cmp AX,SI
  je short 0x4B2A
  add AX,0x01E0
  mov ES,AX
  call far dword ptr DS:[0x38FD]
  ret near
```

**Calls:** 0x4B2B, indirect, indirect

**CFG Block:**
- ID: 6475
- Entry: 100D:4AFD, Term: 100D:4B02
- Preds: [6473], Succs: [6478, 22031]

---

### `travel_probe_terrain_ahead` — seg000:4E8E

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4E8E travel_probe_terrain_ahead
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  push word ptr DS:[0x11CC]
  call near 0x5206
  call near 0x5206
  call near 0x5206
  call near 0x5206
  call near 0x5206
  call near 0x5206
  call near 0xB532
  push AX
  call near 0x5206
  pop AX
  pop word ptr DS:[0x11CC]
  push AX
  call near 0xB532
  push AX
  call near 0x41E1
  pop AX
  pop BX
  add AL,BL
  shr AL,1
  push BX
  mov BX,word ptr DS:[0x487E]
  cmp BX,2
  jb short 0x4EED
  and AL,0x0F
  cmp AL,8
  mov AX,word ptr DS:[0xDC00]
  jae short 0x4EF3
  cmp AX,2
  jbe short 0x4EED
  mov BX,5
  cmp AX,4
  jbe short 0x4EED
  mov BX,2
  mov word ptr DS:[0x487E],BX
  mov word ptr DS:[0xDC02],BX
  pop BX
  ret near
```

**Calls:** 0x5206, 0x5206, 0x5206, 0x5206, 0x5206, 0x5206, 0xB532, 0x5206, 0xB532, 0x41E1

**CFG Block:**
- ID: 22237
- Entry: 100D:4E8E, Term: 100D:4E9A
- Preds: [22235], Succs: [21832, 22242]

---

### `travel_arrive` — seg000:4FB0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4FB0 travel_arrive
  mov word ptr DS:[0x1C06],0
  mov AL,byte ptr DS:[0x11C9]
  and AL,1
  mov byte ptr DS:[0x4732],AL
  jne short 0x4FC3
  call near 0xCA01
  call near 0xE3CC
  mov byte ptr DS:[0x00C5],AL
  xor AL,AL
  mov byte ptr DS:[0x4727],AL
  xchg AL,byte ptr DS:[0x11C9]
  and AL,3
  dec AL
  jne short 0x4FDF
  mov DI,word ptr DS:[0x11C5]
  inc byte ptr DS:[DI+0x15]
  call near 0x4AC4
  call near 0xDBB2
  call near 0xD717
  mov DI,word ptr DS:[0x11C5]
  mov BX,word ptr DS:[DI+4]
  mov DX,word ptr DS:[DI+2]
  mov word ptr DS:[0x11C5],0
  jmp near 0x4002
  mov word ptr DS:[0x1C06],0
  call near 0xCA01
  mov byte ptr DS:[0x11C8],0
  mov CX,0x00C8
  push CX
  call near 0x4B3B
  call near 0x407E
  call near 0xB58B
  mov SI,word ptr DS:[0x11C5]
  cmp DI,word ptr DS:[SI+6]
  je short 0x5039
  mov byte ptr DS:[0x0023],0
  call near 0x4182
  cmp byte ptr DS:[0x0023],0
  pop CX
  loope 0x500C
```

**Calls:** 0xCA01, 0xE3CC, 0x4AC4, 0xDBB2, 0xD717, 0xCA01, 0x4B3B, 0x407E, 0xB58B, 0x4182

**CFG Block:**
- ID: 22534
- Entry: 100D:4FB0, Term: 100D:4FBE
- Preds: [22189], Succs: [22540, 35283]

---

### `travel_finish_at_destination` — seg000:4FC3

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4FC3 travel_finish_at_destination
  call near 0xE3CC
  mov byte ptr DS:[0x00C5],AL
  xor AL,AL
  mov byte ptr DS:[0x4727],AL
  xchg AL,byte ptr DS:[0x11C9]
  and AL,3
  dec AL
  jne short 0x4FDF
  mov DI,word ptr DS:[0x11C5]
  inc byte ptr DS:[DI+0x15]
  call near 0x4AC4
  call near 0xDBB2
  call near 0xD717
  mov DI,word ptr DS:[0x11C5]
  mov BX,word ptr DS:[DI+4]
  mov DX,word ptr DS:[DI+2]
  mov word ptr DS:[0x11C5],0
  jmp near 0x4002
  mov word ptr DS:[0x1C06],0
  call near 0xCA01
  mov byte ptr DS:[0x11C8],0
  mov CX,0x00C8
  push CX
  call near 0x4B3B
  call near 0x407E
  call near 0xB58B
  mov SI,word ptr DS:[0x11C5]
  cmp DI,word ptr DS:[SI+6]
  je short 0x5039
  mov byte ptr DS:[0x0023],0
  call near 0x4182
  cmp byte ptr DS:[0x0023],0
  pop CX
  loope 0x500C
  je short 0x4FC3
  add byte ptr DS:[0x4726],0x20
  jmp near 0x2E52
  pop CX
  jmp short 0x4FC3
  mov byte ptr DS:[0x00FD],0
```

**Calls:** 0xE3CC, 0x4AC4, 0xDBB2, 0xD717, 0xCA01, 0x4B3B, 0x407E, 0xB58B, 0x4182

**Called from:** 100D:E3CC

**CFG Block:**
- ID: 22540
- Entry: 100D:4FC3, Term: 100D:4FC3
- Preds: [2517, 22534, 26038, 35283, 42036], Succs: [4756, 22542]

---

### `menu_callback_choice_skip_to_destination` — seg000:4FFB

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:4FFB menu_callback_choice_skip_to_destination
  mov word ptr DS:[0x1C06],0
  call near 0xCA01
  mov byte ptr DS:[0x11C8],0
  mov CX,0x00C8
  push CX
  call near 0x4B3B
  call near 0x407E
  call near 0xB58B
  mov SI,word ptr DS:[0x11C5]
  cmp DI,word ptr DS:[SI+6]
  je short 0x5039
  mov byte ptr DS:[0x0023],0
  call near 0x4182
  cmp byte ptr DS:[0x0023],0
  pop CX
  loope 0x500C
  je short 0x4FC3
  add byte ptr DS:[0x4726],0x20
  jmp near 0x2E52
  pop CX
  jmp short 0x4FC3
  mov byte ptr DS:[0x00FD],0
  mov byte ptr DS:[0x002B],0
  test byte ptr DS:[DI+0x0A],2
  jne short 0x5058
  call near 0x5D36
  jb short 0x5081
  call near 0x5098
  or DX,DX
  je short 0x507A
  inc byte ptr DS:[0x002B]
  call near 0x6144
  mov AL,byte ptr DS:[DI+8]
  mov AH,0x2F
  cmp AL,0x20
  jb short 0x5075
  inc AH
  cmp AL,0x30
  je short 0x5075
  sub AL,0x28
```

**Calls:** 0xCA01, 0x4B3B, 0x407E, 0xB58B, 0x4182, 0x5D36, 0x5098, 0x6144

**CFG Block:**
- ID: 26014
- Entry: 100D:4FFB, Term: 100D:5001
- Preds: [15411], Succs: [2512, 26017]

---

### `menu_callback_choice_back_to_starting_point` — seg000:50A5

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:50A5 menu_callback_choice_back_to_starting_point
  mov AX,word ptr DS:[0xDC00]
  call near 0xCA1B
  mov DI,word ptr DS:[0x1150]
  call near 0x407E
  call near 0x4965
  call near 0x4AC4
  call near 0x50BE
  jmp near 0x2EB2
  mov byte ptr DS:[0x11CB],0
  ret near
```

**Calls:** 0xCA1B, 0x407E, 0x4965, 0x4AC4, 0x50BE

**CFG Block:**
- ID: 30871
- Entry: 100D:50A5, Term: 100D:50A8
- Preds: [15411], Succs: [4115, 30874]

---

### `menu_callback_choice_towards_nearest_place` — seg000:50C4

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:50C4 menu_callback_choice_towards_nearest_place
  call near 0x407E
  call near 0x5344
  call near 0x4944
  call near 0x4AC4
  mov byte ptr DS:[0x11C8],0
  call near 0x50BE
  jmp near 0x2EB2
  mov word ptr DS:[0x487E],2
  mov byte ptr DS:[0x473E],1
  mov AL,4
  jmp short 0x50EF
  call near 0x4285
  mov AL,8
  mov DI,word ptr DS:[0x46F8]
  push DI
  push AX
  call near 0xD2BD
  call near 0x49EA
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  pop AX
  push AX
  cmp AL,4
  jne short 0x510B
  mov DL,1
  call near 0x4057
  call near 0x186B
  pop AX
  mov byte ptr DS:[0x11C9],AL
  pop DI
  jmp near 0x4703
  add byte ptr DS:[0x11C7],AL
  mov word ptr DS:[0x11CC],0x0080
  ret near
```

**Calls:** 0x407E, 0x5344, 0x4944, 0x4AC4, 0x50BE, 0x4285, 0xD2BD, 0x49EA, 0x4057, 0x186B

**Called from:** 100D:407E

**CFG Block:**
- ID: 37358
- Entry: 100D:50C4, Term: 100D:50C4
- Preds: [15411], Succs: [17418, 37360]

---

### `adjust_travel_heading` — seg000:5119

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5119 adjust_travel_heading
  add byte ptr DS:[0x11C7],AL
  mov word ptr DS:[0x11CC],0x0080
  ret near
  push DI
  call near 0x407E
  mov CX,word ptr DS:[DI+4]
  mov DI,word ptr DS:[DI+2]
  call near 0x5133
  pop DI
  ret near
```

**Calls:** 0x407E, 0x5133

**CFG Block:**
- ID: 21512
- Entry: 100D:5119, Term: 100D:5123
- Preds: [27061], Succs: [21516, 27126, 30879, 37405]

---

### `map_fill_window_rows_from` — seg000:B714

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:B714 map_fill_window_rows_from
  mov DI,0x4C60
  mov AX,word ptr DS:[0x46E7]
  sub AX,word ptr DS:[0x46E3]
  mov DX,AX
  shr DX,1
  add DX,word ptr DS:[0x46E3]
  mov word ptr DS:[0xDCF6],DX
  mov word ptr DS:[0xDCF2],AX
  mov AX,word ptr DS:[0x46E9]
  sub AX,word ptr DS:[0x46E5]
  dec AX
  mov BX,AX
  shr BX,1
  add BX,word ptr DS:[0x46E5]
  mov word ptr DS:[0xDCF8],BX
  inc AX
  mov word ptr DS:[0xDCF4],AX
  dec AX
  shr AX,1
  mov CX,AX
  mov BX,0x0056
  sub BX,AX
  mov AX,word ptr DS:[0x197E]
  or AX,AX
  mov DX,AX
  jns short 0xB75A
  neg AX
  cmp AX,BX
  jb short 0xB769
  mov AX,BX
  or DX,DX
  jns short 0xB766
  neg AX
  mov word ptr DS:[0x197E],AX
  mov BP,0x4948
  mov DX,word ptr DS:[0x197C]
  mov AX,word ptr DS:[0x197E]
  sub AX,CX
  push AX
  mov CX,word ptr DS:[0xDCF4]
```

**CFG Block:**
- ID: 20773
- Entry: 100D:B714, Term: 100D:B756
- Preds: [17518], Succs: [20800, 25221]

---

## troop_icons.rs (3 functions)

### `arm_troop_icon_anim_task` — seg000:5A66

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5A66 arm_troop_icon_anim_task
  mov SI,0x6B34
  mov BP,0x000F
  call near 0xDA25
  mov SI,0x1482
  mov DI,0x46E3
  call near 0x5B99
  call near 0x5B69
  call near 0x1797
  mov byte ptr DS:[0x46EB],0x80
  call near 0xAD5E
  mov word ptr DS:[0x2786],0xC835
  mov AX,0x5A9A
  mov word ptr DS:[0x46ED],AX
  call near AX
  call near 0xD792
  jmp near 0xD712
  call near 0xC07C
  call near 0x5B8D
  mov AL,0x80
  xchg AL,byte ptr DS:[0x46EB]
  push AX
  call near 0xB6C3
  call near 0xC13B
  call near 0x5DCE
  call near 0x6314
  call near 0xC412
  mov word ptr DS:[0x3CBE],0
  call near 0x6715
  mov SI,0x46E3
  call near 0xC6AD
  call near 0x878C
  pop AX
  mov byte ptr DS:[0x46EB],AL
  and AL,0x40
  je short 0x5AD3
  mov AX,0x1A9E
  call near 0xD95E
  mov SI,0x46E3
  jmp near 0xDAAA
  call near 0x7B36
```

**Calls:** 0xDA25, 0x5B99, 0x5B69, 0x1797, 0xAD5E, 0xD792, 0xC07C, 0x5B8D, 0xB6C3, 0xC13B, 0x5DCE, 0x6314, 0xC412, 0x6715, 0xC6AD, 0x878C, 0xD95E, 0x7B36

**CFG Block:**
- ID: 17446
- Entry: 100D:5A66, Term: 100D:5A6C
- Preds: [1843, 17444], Succs: [6166, 17450]

---

### `troop_icon_anim_step` — seg000:6B55

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6B55 troop_icon_anim_step
  test byte ptr DS:[DI+0x0C],1
  je short 0x6B84
  mov SI,word ptr DS:[DI+0x0D]
  lods AL,byte ptr DS:[SI]
  or AL,AL
  jne short 0x6B6D
  mov SI,word ptr DS:[DI+0x0F]
  lods AL,byte ptr DS:[SI]
  test byte ptr DS:[DI+0x0C],2
  jne short 0x6B84
  xor AH,AH
  mov word ptr DS:[DI+8],AX
  lods AL,byte ptr DS:[SI]
  cbw
  mov DX,AX
  lods AL,byte ptr DS:[SI]
  cbw
  mov BX,AX
  mov word ptr DS:[DI+0x0D],SI
  push CX
  push DI
  call near 0xC661
  pop DI
  pop CX
  add DI,0x0011
  loop 0x6B55
  ret near
```

**Calls:** 0xC661

**CFG Block:**
- ID: 24456
- Entry: 100D:6B55, Term: 100D:6B59
- Preds: [18496, 24517, 24518], Succs: [24459, 24518]

---

### `troop_icon_remove` — seg000:C58D

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:C58D troop_icon_remove
  mov SI,0x3CBE
  lods AX,word ptr DS:[SI]
  or AX,AX
  je short 0xC5CE
  mov AH,0x11
  mul AH
  add SI,AX
  cmp DI,SI
  jae short 0xC5CE
  or byte ptr DS:[DI+0x0C],0x80
  push SI
  push DI
  mov SI,DI
  call near 0xC6AD
  pop DI
  pop CX
  push DI
  lea SI,DI+0x11
  sub CX,SI
  je short 0xC5B8
  push DS
  pop ES
  rep movs byte ptr ES:[DI],byte ptr DS:[SI]
  dec word ptr DS:[0x3CBE]
  pop DI
  mov SI,0x4752
  mov CX,2
  lods AX,word ptr DS:[SI]
  cmp AX,DI
  jb short 0xC5CC
  sub word ptr DS:[SI-2],0x0011
  loop 0xC5C3
  ret near
```

**Calls:** 0xC6AD

**CFG Block:**
- ID: 10783
- Entry: 100D:C58D, Term: 100D:C593
- Preds: [5980, 10781], Succs: [10788]

---

## troop_map_screen.rs (28 functions)

### `menu_callback_choice_move_to_location_orni` — seg000:50DB

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:50DB menu_callback_choice_move_to_location_orni
  mov word ptr DS:[0x487E],2
  mov byte ptr DS:[0x473E],1
  mov AL,4
  jmp short 0x50EF
  call near 0x4285
  mov AL,8
  mov DI,word ptr DS:[0x46F8]
  push DI
  push AX
  call near 0xD2BD
  call near 0x49EA
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  pop AX
  push AX
  cmp AL,4
  jne short 0x510B
  mov DL,1
  call near 0x4057
  call near 0x186B
  pop AX
  mov byte ptr DS:[0x11C9],AL
  pop DI
  jmp near 0x4703
  add byte ptr DS:[0x11C7],AL
  mov word ptr DS:[0x11CC],0x0080
  ret near
```

**Calls:** 0x4285, 0xD2BD, 0x49EA, 0x4057, 0x186B

**CFG Block:**
- ID: 26573
- Entry: 100D:50DB, Term: 100D:50E8
- Preds: [15411], Succs: [26578]

---

### `menu_callback_choice_move_to_location_worm` — seg000:50EA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:50EA menu_callback_choice_move_to_location_worm
  call near 0x4285
  mov AL,8
  mov DI,word ptr DS:[0x46F8]
  push DI
  push AX
  call near 0xD2BD
  call near 0x49EA
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  pop AX
  push AX
  cmp AL,4
  jne short 0x510B
  mov DL,1
  call near 0x4057
  call near 0x186B
  pop AX
  mov byte ptr DS:[0x11C9],AL
  pop DI
  jmp near 0x4703
  add byte ptr DS:[0x11C7],AL
  mov word ptr DS:[0x11CC],0x0080
  ret near
```

**Calls:** 0x4285, 0xD2BD, 0x49EA, 0x4057, 0x186B

**Called from:** 100D:4285

**CFG Block:**
- ID: 36547
- Entry: 100D:50EA, Term: 100D:50EA
- Preds: [15411], Succs: [35089, 36550]

---

### `map_move_to_location_confirm` — seg000:50EF

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:50EF map_move_to_location_confirm
  mov DI,word ptr DS:[0x46F8]
  push DI
  push AX
  call near 0xD2BD
  call near 0x49EA
  mov DX,word ptr DS:[4]
  mov BX,word ptr DS:[6]
  pop AX
  push AX
  cmp AL,4
  jne short 0x510B
  mov DL,1
  call near 0x4057
  call near 0x186B
  pop AX
  mov byte ptr DS:[0x11C9],AL
  pop DI
  jmp near 0x4703
  add byte ptr DS:[0x11C7],AL
  mov word ptr DS:[0x11CC],0x0080
  ret near
```

**Calls:** 0xD2BD, 0x49EA, 0x4057, 0x186B

**CFG Block:**
- ID: 26578
- Entry: 100D:50EF, Term: 100D:50F5
- Preds: [26573, 36550], Succs: [13221, 26607]

---

### `menu_callback_choice_map_main_see_spice_density` — seg000:53F1

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:53F1 menu_callback_choice_map_main_see_spice_density
  mov byte ptr DS:[0x4722],0
  test byte ptr DS:[0x46EB],0x40
  je short 0x5400
  jmp near 0x58FA
  mov word ptr DS:[0x4720],0x1E6E
  mov DX,word ptr DS:[0x11C1]
  mov BX,word ptr DS:[0x11C3]
  mov word ptr DS:[0x4710],DX
  mov word ptr DS:[0x4712],BX
  call near 0x5BEB
  call near 0x5F79
  call near 0x79DE
  push word ptr DS:[0x197C]
  push word ptr DS:[0x197E]
  pop word ptr DS:[0x1982]
  pop word ptr DS:[0x1980]
  mov word ptr DS:[0x46FC],0
  mov word ptr DS:[0x479E],0
  call near 0x557B
  mov DI,0x46E3
  add DX,5
  add BX,7
  mov word ptr DS:[DI],DX
  mov word ptr DS:[DI+2],BX
  add DX,0x00A0
  mov word ptr DS:[DI+4],DX
  add BX,0x0059
  mov word ptr DS:[DI+6],BX
  mov SI,0x4710
  add DX,5
  mov word ptr DS:[SI+4],DX
  add BX,0x000C
  mov word ptr DS:[SI+6],BX
  call near 0xC13B
  call near 0x557B
  mov AX,0x008D
  call near 0xC22F
  call near 0xC07C
  call near 0x5B8D
  push word ptr DS:[0xDD00]
```

**Calls:** 0x5BEB, 0x5F79, 0x79DE, 0x557B, 0xC13B, 0x557B, 0xC22F, 0xC07C, 0x5B8D

**CFG Block:**
- ID: 30976
- Entry: 100D:53F1, Term: 100D:53FB
- Preds: [15411], Succs: [30980, 40583]

---

### `map_enter_spice_density_overlay` — seg000:5406

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5406 map_enter_spice_density_overlay
  mov DX,word ptr DS:[0x11C1]
  mov BX,word ptr DS:[0x11C3]
  mov word ptr DS:[0x4710],DX
  mov word ptr DS:[0x4712],BX
  call near 0x5BEB
  call near 0x5F79
  call near 0x79DE
  push word ptr DS:[0x197C]
  push word ptr DS:[0x197E]
  pop word ptr DS:[0x1982]
  pop word ptr DS:[0x1980]
  mov word ptr DS:[0x46FC],0
  mov word ptr DS:[0x479E],0
  call near 0x557B
  mov DI,0x46E3
  add DX,5
  add BX,7
  mov word ptr DS:[DI],DX
  mov word ptr DS:[DI+2],BX
  add DX,0x00A0
  mov word ptr DS:[DI+4],DX
  add BX,0x0059
  mov word ptr DS:[DI+6],BX
  mov SI,0x4710
  add DX,5
  mov word ptr DS:[SI+4],DX
  add BX,0x000C
  mov word ptr DS:[SI+6],BX
  call near 0xC13B
  call near 0x557B
  mov AX,0x008D
  call near 0xC22F
  call near 0xC07C
  call near 0x5B8D
  push word ptr DS:[0xDD00]
  mov AX,0x003A
  call near 0xC13E
  call near 0x5584
  push word ptr DS:[0xDBB2]
  pop word ptr DS:[0xDD00]
```

**Calls:** 0x5BEB, 0x5F79, 0x79DE, 0x557B, 0xC13B, 0x557B, 0xC22F, 0xC07C, 0x5B8D, 0xC13E, 0x5584

---

### `menu_callback_choice_give_orders_to_troop` — seg000:5A03

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5A03 menu_callback_choice_give_orders_to_troop
  call near 0x8C8A
  inc byte ptr DS:[0x46F3]
  call near 0x68EB
  mov byte ptr DS:[0x1954],AL
  not byte ptr DS:[0x00FB]
  call near 0x5A1A
  jmp near 0x8685
  mov byte ptr DS:[0x28E7],1
  call near 0x18BA
  call near 0x5B5D
  mov BP,0x5A56
  mov AL,0x34
  mov DX,0xFFFF
  call near 0xC108
  cmp byte ptr DS:[0x46F3],0
  jne short 0x5A3A
  call near 0x5BB0
  jmp near 0x17E6
  mov byte ptr DS:[0x00FB],0xFF
  call near 0xC13B
  call far dword ptr DS:[0x3935]
  mov BP,0x5A56
  mov AL,2
  xor DX,DX
  call near 0xC108
  jmp near 0xAE04
  cmp byte ptr DS:[0x46EB],0
  js short 0x5A9A
  call near 0xD2BD
  call near 0x4ACA
  call near 0xB930
  mov SI,0x6B34
  mov BP,0x000F
  call near 0xDA25
  mov SI,0x1482
  mov DI,0x46E3
  call near 0x5B99
  call near 0x5B69
  call near 0x1797
  mov byte ptr DS:[0x46EB],0x80
```

**Calls:** 0x8C8A, 0x68EB, 0x5A1A, 0x18BA, 0x5B5D, 0xC108, 0x5BB0, 0xC13B, indirect, 0xC108, 0xD2BD, 0x4ACA, 0xB930, 0xDA25, 0x5B99, 0x5B69, 0x1797

**Called from:** 100D:8C8A

**CFG Block:**
- ID: 23457
- Entry: 100D:5A03, Term: 100D:5A03
- Preds: [15411], Succs: [11835, 23459]

---

### `map_click_location_marker` — seg000:5FB0

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:5FB0 map_click_location_marker
  call near 0x58FA
  call near 0x7B36
  cmp DI,word ptr DS:[0x114E]
  je short 0x600E
  cmp byte ptr DS:[8],0xFF
  je short 0x5FF9
  cmp byte ptr DS:[0x000B],2
  jbe short 0x5FD8
  cmp byte ptr DS:[8],0x20
  jae short 0x600E
  cmp byte ptr DS:[8],0x28
  jae short 0x600E
  push DI
  mov DI,word ptr DS:[0x114E]
  call near 0x7F27
  pop DI
  mov BP,0x20DA
  mov AX,word ptr SS:[BP+2]
  and AH,0x1F
  cmp byte ptr DS:[0x46FF],0
  jne short 0x5FF4
  or AH,0x40
  mov word ptr SS:[BP+2],AX
  jmp short 0x6003
  test byte ptr DS:[0x000A],0x40
  je short 0x600E
  mov BP,0x20E6
  push BP
  call near 0x600E
  pop BP
  mov BX,0x5F91
  jmp near 0xD323
  call near 0xC08E
  push DI
  call near 0x5EE4
  pop DI
  mov word ptr DS:[0x46F8],DI
  call near 0xD068
  mov CL,0x9A
  mov CH,byte ptr DS:[0x1671]
```

**Calls:** 0x58FA, 0x7B36, 0x7F27, 0x600E, 0xC08E, 0x5EE4, 0xD068

**Called from:** 100D:58FA

**CFG Block:**
- ID: 26297
- Entry: 100D:5FB0, Term: 100D:5FB0
- Preds: [26295], Succs: [23606, 26299]

---

### `map_draw_vegetation_mark` — seg000:6375

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6375 map_draw_vegetation_mark
  mov AX,word ptr ES:[DI]
  and AX,0x3030
  cmp AL,0x10
  je short 0x6395
  add DX,4
  cmp DX,word ptr DS:[0x46E7]
  jae short 0x6394
  inc DI
  inc SI
  cmp SI,BP
  jb short 0x6375
  sub SI,BP
  sub DI,BP
  jmp short 0x6375
  ret near
```

**CFG Block:**
- ID: 18043
- Entry: 100D:6375, Term: 100D:637D
- Preds: [18028, 18039, 34095], Succs: [18035, 40811]

---

### `menu_callback_choice_map_troop_dialogue_change_troop_occupation` — seg000:69B3

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:69B3 menu_callback_choice_map_troop_dialogue_change_troop_occupation
  call near 0x68EB
  mov BP,0x215A
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,2
  je short 0x6A07
  call near 0x693B
  mov BP,0x216E
  cmp AX,1
  jb short 0x69F6
  mov BP,0x21A6
  jne short 0x69F6
  mov BP,0x2182
  and word ptr DS:[0x2188],0xBFFF
  cmp word ptr DS:[0x00E2],0x001E
  jb short 0x69E8
  or word ptr DS:[0x2188],0x4000
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,5
  jne short 0x69F6
  mov BP,0x219A
  jmp short 0x6A25
  and word ptr SS:[BP+2],0xBFFF
  cmp byte ptr DS:[0x002A],0x10
  jae short 0x6A07
  or word ptr SS:[BP+2],0x4000
  lea BX,BP-2
  add BX,4
  mov AX,word ptr DS:[BX]
  and AX,0x0FFF
  je short 0x6A25
  cmp AX,0x0077
  jne short 0x6A0A
  test byte ptr DS:[0x000A],0x20
  jne short 0x6A23
  or AX,0x4000
  mov word ptr DS:[BX],AX
  mov BX,0x0F66
  jmp near 0xD323
```

**Calls:** 0x68EB, 0x693B

**Called from:** 100D:68EB

**CFG Block:**
- ID: 24520
- Entry: 100D:69B3, Term: 100D:69B3
- Preds: [15411], Succs: [23462, 24522]

---

### `menu_callback_choice_troop_occupation_assembly_wind_trap` — seg000:6A2B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6A2B menu_callback_choice_troop_occupation_assembly_wind_trap
  mov AL,1
  jmp short 0x6A35
  mov AL,2
  jmp short 0x6A35
  mov AL,3
  push AX
  call near 0x68EB
  pop AX
  mov CL,byte ptr DS:[SI+3]
  and CL,0x0C
  or CL,AL
  jmp short 0x6A89
  mov AL,1
  call near 0x6A35
  mov byte ptr DS:[0x46D8],1
  call near 0x68EB
  and byte ptr DS:[SI+0x10],0xBF
  mov DI,word ptr DS:[SI+4]
  call near 0x331E
  mov DI,word ptr DS:[0x00E4]
  call near 0x82DA
  jne short 0x6AC5
  call near 0x8770
  jmp near 0x84A6
  call near 0x68EB
  xor CL,CL
  cmp SI,0x08E0
  jne short 0x6A89
  inc CX
  call near 0x6A89
  jmp near 0x2EBF
  mov CL,4
  jmp short 0x6A89
  mov CL,8
  call near 0x68EB
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6AB5
  push word ptr DS:[SI+3]
```

**Calls:** 0x68EB, 0x6A35, 0x68EB, 0x331E, 0x82DA, 0x8770, 0x68EB, 0x6A89, 0x68EB

**CFG Block:**
- ID: 39727
- Entry: 100D:6A2B, Term: 100D:6A2D
- Preds: [15411], Succs: [35461]

---

### `menu_callback_choice_troop_occupation_specialize_in_spice` — seg000:6A71

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6A71 menu_callback_choice_troop_occupation_specialize_in_spice
  call near 0x68EB
  xor CL,CL
  cmp SI,0x08E0
  jne short 0x6A89
  inc CX
  call near 0x6A89
  jmp near 0x2EBF
  mov CL,4
  jmp short 0x6A89
  mov CL,8
  call near 0x68EB
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6AB5
  push word ptr DS:[SI+3]
  push SI
  push word ptr DS:[SI+0x12]
  call near 0x6ACB
  call near 0xA1C4
  mov AL,0x0A
  call near 0x7BB9
  call near 0xA1E2
  pop AX
  pop SI
  pop CX
  je short 0x6AB8
  mov word ptr DS:[SI+0x12],AX
  call near 0x6ACB
  jmp near 0xD2E2
  call near 0x693B
  or AL,AL
  je short 0x6AB5
  and byte ptr DS:[SI+0x19],0x7F
  jmp short 0x6AB5
  mov CL,byte ptr DS:[SI+3]
  and CL,0xFC
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
```

**Calls:** 0x68EB, 0x6A89, 0x68EB, 0x6ACB, 0xA1C4, 0x7BB9, 0xA1E2, 0x6ACB, 0x693B

**Called from:** 100D:68EB

**CFG Block:**
- ID: 24555
- Entry: 100D:6A71, Term: 100D:6A71
- Preds: [15411], Succs: [23462, 24557]

---

### `menu_callback_choice_troop_occupation_specialize_in_army` — seg000:6A83

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6A83 menu_callback_choice_troop_occupation_specialize_in_army
  mov CL,4
  jmp short 0x6A89
  mov CL,8
  call near 0x68EB
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6AB5
  push word ptr DS:[SI+3]
  push SI
  push word ptr DS:[SI+0x12]
  call near 0x6ACB
  call near 0xA1C4
  mov AL,0x0A
  call near 0x7BB9
  call near 0xA1E2
  pop AX
  pop SI
  pop CX
  je short 0x6AB8
  mov word ptr DS:[SI+0x12],AX
  call near 0x6ACB
  jmp near 0xD2E2
  call near 0x693B
  or AL,AL
  je short 0x6AB5
  and byte ptr DS:[SI+0x19],0x7F
  jmp short 0x6AB5
  mov CL,byte ptr DS:[SI+3]
  and CL,0xFC
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6B24
  mov DI,word ptr DS:[SI+4]
  cmp CL,8
  jne short 0x6AEA
  cmp DI,0x07C8
  jne short 0x6AEA
  cmp byte ptr DS:[DI+0x1A],0
```

**Calls:** 0x68EB, 0x6ACB, 0xA1C4, 0x7BB9, 0xA1E2, 0x6ACB, 0x693B

**CFG Block:**
- ID: 24777
- Entry: 100D:6A83, Term: 100D:6A85
- Preds: [15411], Succs: [24561]

---

### `menu_callback_choice_troop_occupation_specialize_in_ecology` — seg000:6A87

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6A87 menu_callback_choice_troop_occupation_specialize_in_ecology
  mov CL,8
  call near 0x68EB
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6AB5
  push word ptr DS:[SI+3]
  push SI
  push word ptr DS:[SI+0x12]
  call near 0x6ACB
  call near 0xA1C4
  mov AL,0x0A
  call near 0x7BB9
  call near 0xA1E2
  pop AX
  pop SI
  pop CX
  je short 0x6AB8
  mov word ptr DS:[SI+0x12],AX
  call near 0x6ACB
  jmp near 0xD2E2
  call near 0x693B
  or AL,AL
  je short 0x6AB5
  and byte ptr DS:[SI+0x19],0x7F
  jmp short 0x6AB5
  mov CL,byte ptr DS:[SI+3]
  and CL,0xFC
  mov AL,byte ptr DS:[SI+3]
  and AL,0x0F
  cmp AL,CL
  je short 0x6B24
  mov DI,word ptr DS:[SI+4]
  cmp CL,8
  jne short 0x6AEA
  cmp DI,0x07C8
  jne short 0x6AEA
  cmp byte ptr DS:[DI+0x1A],0
  jne short 0x6AEA
  mov CL,0x0A
```

**Calls:** 0x68EB, 0x6ACB, 0xA1C4, 0x7BB9, 0xA1E2, 0x6ACB, 0x693B

**CFG Block:**
- ID: 39687
- Entry: 100D:6A87, Term: 100D:6A87
- Preds: [15411], Succs: [24561]

---

### `map_open_troop_info_popup` — seg000:78BC

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:78BC map_open_troop_info_popup
  mov DI,word ptr DS:[SI+4]
  call near 0x7C63
  cmp AX,word ptr DS:[0x1176]
  jae short 0x78BB
  call near 0x6917
  jne short 0x78BB
  call near 0xC08E
  mov word ptr DS:[0x46FA],SI
  push SI
  mov SI,0x18DF
  mov BX,word ptr DS:[DI+2]
  mov DX,word ptr DS:[DI]
  mov CX,0x0064
  call near 0x5F25
  pop SI
  mov AL,byte ptr DS:[SI]
  mov byte ptr DS:[0x1955],AL
  call near 0x6917
  je short 0x78F1
  call near 0xC08E
  call near 0x31F6
  add word ptr DS:[0x11F3],0x000C
  mov SI,0x18DF
  call near 0x7B1B
  call near 0xD075
  mov CL,0x9A
  mov CH,byte ptr DS:[0x18E8]
  mov DX,word ptr DS:[0x18DF]
  mov BX,word ptr DS:[0x18E1]
  add DX,0x000C
  add BX,4
  mov AX,0x003A
  test byte ptr DS:[0x0030],0x40
  je short 0x7924
  inc AX
  call near 0x8865
  mov CL,0x96
  sub DX,8
  add BX,9
  mov DI,word ptr DS:[0x002C]
```

**Calls:** 0x7C63, 0x6917, 0xC08E, 0x5F25, 0x6917, 0xC08E, 0x31F6, 0x7B1B, 0xD075, 0x8865

**CFG Block:**
- ID: 29978
- Entry: 100D:78BC, Term: 100D:78BF
- Preds: [29975], Succs: [23740, 29981]

---

### `map_draw_troop_info_panel_content` — seg000:78E9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:78E9 map_draw_troop_info_panel_content
  call near 0x6917
  je short 0x78F1
  call near 0xC08E
  call near 0x31F6
  add word ptr DS:[0x11F3],0x000C
  mov SI,0x18DF
  call near 0x7B1B
  call near 0xD075
  mov CL,0x9A
  mov CH,byte ptr DS:[0x18E8]
  mov DX,word ptr DS:[0x18DF]
  mov BX,word ptr DS:[0x18E1]
  add DX,0x000C
  add BX,4
  mov AX,0x003A
  test byte ptr DS:[0x0030],0x40
  je short 0x7924
  inc AX
  call near 0x8865
  mov CL,0x96
  sub DX,8
  add BX,9
  mov DI,word ptr DS:[0x002C]
  call near 0x62A6
  mov CL,0x9A
  add BX,0x000A
  mov AL,byte ptr DS:[0x0030]
  test AL,0x20
  je short 0x794C
  mov AX,0x003C
  call near 0x8865
  add BX,0x000F
  cmp byte ptr DS:[0x0030],2
  je short 0x79BC
  mov AL,byte ptr DS:[0x002F]
  shr AL,1
  and AX,6
  add AX,0x11F7
  mov SI,AX
  mov AX,word ptr DS:[SI]
```

**Calls:** 0x6917, 0xC08E, 0x31F6, 0x7B1B, 0xD075, 0x8865, 0x62A6, 0x8865

**Called from:** 100D:6917

---

### `map_draw_troop_contact_head` — seg000:7A6A

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:7A6A map_draw_troop_contact_head
  mov SI,word ptr DS:[0x46EF]
  test byte ptr DS:[SI+3],0x20
  je short 0x7A96
  mov DI,word ptr DS:[SI+4]
  test byte ptr DS:[DI+0x0A],2
  jne short 0x7A82
  call near 0x5D36
  jb short 0x7A96
  mov AX,0x000C
  mov word ptr DS:[0x47C4],AX
  call near 0x91A0
  call near 0xC0F4
  mov AX,0x000C
  mov BP,0
  jmp short 0x7AC1
  mov AX,0x000F
  mov word ptr DS:[0x47C4],AX
  mov word ptr DS:[0x4758],SI
  mov byte ptr DS:[0x476C],0
  call near 0x91A0
  call near 0xC0F4
  mov AX,word ptr DS:[0x22A6]
  sub AX,0x000E
  shl AX,1
  shl AX,1
  mov BL,byte ptr DS:[0x47D0]
  dec BL
  xor BH,BH
  shl BX,1
  mov BP,BX
  mov SI,0x22B9
  add SI,AX
  lods AX,word ptr DS:[SI]
  mov word ptr DS:[0x46D2],AX
  lods AX,word ptr DS:[SI]
  mov word ptr DS:[0x46D4],AX
  push DS
  mov SI,word ptr SS:[0x47CA]
  mov DS,word ptr SS:[0xDBB2]
  add SI,word ptr DS:[BP+SI]
```

**Calls:** 0x5D36, 0x91A0, 0xC0F4, 0x91A0, 0xC0F4

**CFG Block:**
- ID: 24180
- Entry: 100D:7A6A, Term: 100D:7A72
- Preds: [16829, 24156], Succs: [24184, 34528]

---

### `menu_callback_choice_multiple_move_troop` — seg000:8064

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:8064 menu_callback_choice_multiple_move_troop
  mov AX,0x1AAC
  call near 0xD95E
  call near 0x68EB
  cmp SI,0x08E0
  je short 0x8082
  mov AX,0x0054
  call near 0x80DF
  mov BP,0x212E
  mov BX,0x824D
  jmp near 0xD323
  push DS
  pop ES
  mov DI,0x4718
  mov SI,0x11D3
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  sub DI,6
  xor AX,AX
  mov CX,4
  repne scas AX,word ptr ES:[DI]
  sub CX,3
  neg CX
  mov byte ptr DS:[0x4738],CL
  mov AX,0x0055
  call near 0x80DF
  call near 0x80AC
  jmp near 0xD32F
  mov BP,0x2136
  and byte ptr SS:[BP+3],0xBF
  xor CX,CX
  mov AL,byte ptr DS:[0x4738]
  dec AL
  cmp AL,2
  jb short 0x80C3
  or byte ptr SS:[BP+3],0x40
  inc CX
  mov BX,0x824D
  ret near
```

**Calls:** 0xD95E, 0x68EB, 0x80DF, 0x80DF, 0x80AC

**CFG Block:**
- ID: 29064
- Entry: 100D:8064, Term: 100D:8067
- Preds: [15411], Succs: [18375, 29067]

---

### `menu_callback_choice_map_move_prospectors_give_new_destinations` — seg000:80D9

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:80D9 menu_callback_choice_map_move_prospectors_give_new_destinations
  call near 0x80C8
  jmp near 0x8286
  push AX
  call near 0xC08E
  call near 0x8FD1
  pop BX
  mov SI,0x2244
  mov AX,word ptr DS:[SI+2]
  push AX
  push word ptr DS:[SI+6]
  push BX
  cmp AX,0x0032
  jb short 0x80FA
  add AX,0x0026
  mov word ptr DS:[SI+2],AX
  mov word ptr DS:[SI+6],0x0019
  call near 0x9F82
  pop AX
  call near 0x88AF
  cmp byte ptr DS:[0x4774],0
  jne short 0x811E
  mov AX,0x010A
  add AX,word ptr DS:[0xD810]
  add word ptr DS:[0x4780],AX
  call near 0x9EFD
  pop word ptr DS:[0x224A]
  pop word ptr DS:[0x2246]
  call near 0xC07C
  mov word ptr DS:[0x4720],0x18F3
  mov byte ptr DS:[0x4722],0
  call near 0x541F
  mov word ptr DS:[0x1BEA],0
  ret near
```

**Calls:** 0x80C8, 0xC08E, 0x8FD1, 0x9F82, 0x88AF, 0x9EFD, 0xC07C, 0x541F

**Called from:** 100D:80C8

**CFG Block:**
- ID: 32111
- Entry: 100D:80D9, Term: 100D:80D9
- Preds: [15411], Succs: [32113, 32120]

---

### `menu_callback_choice_map_move_prospectors_done` — seg000:8214

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:8214 menu_callback_choice_map_move_prospectors_done
  call near 0x82B7
  call near 0x68EB
  cmp SI,0x08E0
  jne short 0x8235
  push SI
  mov SI,0x4718
  mov DI,0x11D3
  push DS
  pop ES
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  movs word ptr ES:[DI],word ptr DS:[SI]
  pop SI
  mov DI,word ptr DS:[0x11D3]
  or DI,DI
  je short 0x8246
  call near 0x82DA
  jne short 0x8246
  call near 0x84A6
  call near 0xD2FD
  call near 0x8250
  jmp near 0x878C
  call near 0xD2E2
  jmp near 0xC13B
  ret near
```

**Calls:** 0x82B7, 0x68EB, 0x82DA, 0x84A6, 0xD2FD, 0x8250, 0xD2E2

**Called from:** 100D:82B7

**CFG Block:**
- ID: 29368
- Entry: 100D:8214, Term: 100D:8214
- Preds: [15411, 29358], Succs: [29370, 29392]

---

### `map_select_troop` — seg000:8685

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:8685 map_select_troop
  mov byte ptr DS:[0x46D8],1
  call near 0x69A3
  call near 0x7B58
  call near 0x5F79
  call near 0x79DE
  call near 0x58FA
  mov AL,byte ptr DS:[0x1954]
  cmp AL,0x43
  ja short 0x86B8
  call near 0x6906
  jae short 0x86B8
  mov byte ptr DS:[0x1955],AL
  push SI
  call near 0x697C
  pop SI
  push SI
  call near 0x780A
  pop SI
  mov DI,word ptr DS:[SI+4]
  call near 0x7C02
  ret near
```

**Calls:** 0x69A3, 0x7B58, 0x5F79, 0x79DE, 0x58FA, 0x6906, 0x697C, 0x780A, 0x7C02

**CFG Block:**
- ID: 23576
- Entry: 100D:8685, Term: 100D:868A
- Preds: [23574, 30141, 35427], Succs: [23579, 23588]

---

### `map_contact_troop_at_current_location` — seg000:86B9

**Status:** Never executed during discovery.

---

### `menu_callback_choice_map_main_contact_fremen_troops` — seg000:86CC

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:86CC menu_callback_choice_map_main_contact_fremen_troops
  call near 0x5BEB
  cmp byte ptr DS:[0x0028],0
  je short 0x86B8
  cmp word ptr DS:[0x1176],2
  jb short 0x86B9
  mov AX,word ptr DS:[0x1954]
  or AL,AL
  jne short 0x86FA
  mov AL,AH
  or AL,AL
  je short 0x86FA
  mov byte ptr DS:[0x1954],AL
  call near 0x6906
  call near 0x6917
  je short 0x8685
  mov SI,0x3CBE
  lods AX,word ptr DS:[SI]
  mov CX,AX
  jcxz short 0x86B8
  mov AL,byte ptr DS:[0x1954]
  mov BH,0xFF
  xor DI,DI
  mov BP,word ptr DS:[SI+0x0A]
  cmp byte ptr SS:[BP+3],0x80
  jae short 0x8721
  mov AH,byte ptr SS:[BP]
  sub AH,AL
  je short 0x8721
  cmp AH,BH
  ja short 0x8721
  mov BH,AH
  mov DI,SI
  add SI,0x0011
  loop 0x8709
  or DI,DI
  je short 0x86B8
  mov SI,DI
  mov SI,word ptr DS:[SI+0x0A]
  mov AL,byte ptr DS:[SI]
  cmp word ptr DS:[0x1176],2
```

**Calls:** 0x5BEB, 0x6906, 0x6917

**Called from:** 100D:5BEB

**CFG Block:**
- ID: 35406
- Entry: 100D:86CC, Term: 100D:86CC
- Preds: [15411, 35404], Succs: [26205, 35408]

---

### `menu_callback_choice_map_troop_contact_next_troop` — seg000:86FA

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:86FA menu_callback_choice_map_troop_contact_next_troop
  mov SI,0x3CBE
  lods AX,word ptr DS:[SI]
  mov CX,AX
  jcxz short 0x86B8
  mov AL,byte ptr DS:[0x1954]
  mov BH,0xFF
  xor DI,DI
  mov BP,word ptr DS:[SI+0x0A]
  cmp byte ptr SS:[BP+3],0x80
  jae short 0x8721
  mov AH,byte ptr SS:[BP]
  sub AH,AL
  je short 0x8721
  cmp AH,BH
  ja short 0x8721
  mov BH,AH
  mov DI,SI
  add SI,0x0011
  loop 0x8709
  or DI,DI
  je short 0x86B8
  mov SI,DI
  mov SI,word ptr DS:[SI+0x0A]
  mov AL,byte ptr DS:[SI]
  cmp word ptr DS:[0x1176],2
  jae short 0x8741
  mov DI,word ptr DS:[SI+4]
  cmp DI,word ptr DS:[0x114E]
  jne short 0x8750
  cmp AL,byte ptr DS:[0x1954]
  je short 0x874D
  mov byte ptr DS:[0x1954],AL
  jmp near 0x8685
  jmp near 0x7C02
  ret near
```

**CFG Block:**
- ID: 34556
- Entry: 100D:86FA, Term: 100D:8700
- Preds: [15411, 35418], Succs: [34561]

---

### `map_click_troop_icon` — seg000:872C

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:872C map_click_troop_icon
  mov SI,word ptr DS:[SI+0x0A]
  mov AL,byte ptr DS:[SI]
  cmp word ptr DS:[0x1176],2
  jae short 0x8741
  mov DI,word ptr DS:[SI+4]
  cmp DI,word ptr DS:[0x114E]
  jne short 0x8750
  cmp AL,byte ptr DS:[0x1954]
  je short 0x874D
  mov byte ptr DS:[0x1954],AL
  jmp near 0x8685
  jmp near 0x7C02
  ret near
```

**CFG Block:**
- ID: 30129
- Entry: 100D:872C, Term: 100D:8736
- Preds: [30127, 34585], Succs: [30134, 30138]

---

### `xor_bracket_zoom_to_panel` — segvga:3602

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `xor_bracket_anim_setup` — segvga:36B0

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `xor_corner_brackets` — segvga:37B1

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

### `xor_bracket_zoom_from_panel` — segvga:3841

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---

## troops.rs (7 functions)

### `init_troop_locations` — seg000:01C8

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:01C8 init_troop_locations
  mov DI,0x0100
  mov BP,0x01E0
  mov DX,word ptr DS:[DI+2]
  mov BX,word ptr DS:[DI+4]
  call near 0x6603
  add DI,0x001C
  cmp byte ptr DS:[DI],0xFF
  jne short 0x01CB
  ret near
```

**Calls:** 0x6603

**CFG Block:**
- ID: 3067
- Entry: 100D:01C8, Term: 100D:01C8
- Preds: [3043], Succs: [3084]

---

### `init_room_persons_special` — seg000:3140

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:3140 init_room_persons_special
  mov BX,word ptr DS:[6]
  cmp BL,0x80
  jne short 0x316D
  mov DI,word ptr DS:[0x114E]
  mov DX,word ptr DS:[4]
  mov BP,0x316E
  call near 0x6603
  cmp byte ptr DS:[DI+8],0x21
  jne short 0x316A
  mov word ptr DS:[0x10A8],DX
  mov word ptr DS:[0x10AA],BX
  push DI
  call near 0x2318
  pop DI
  call near 0x331E
  ret near
```

**Calls:** 0x6603, 0x2318, 0x331E

---

### `keep_min` — seg000:52DD

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:52DD keep_min
  cmp CX,word ptr SS:[BP]
  jae short 0x52E8
  mov word ptr SS:[BP],CX
  mov word ptr SS:[BP+2],SI
  cmp CX,word ptr DS:[0x00CA]
  jae short 0x52F6
  mov word ptr DS:[0x00CA],CX
  mov word ptr DS:[0x00CC],SI
  add SI,0x001C
  jmp short 0x5290
  push DI
  mov BP,0x00DE
  call near 0x5323
  mov BP,0x00E4
  call near 0x5323
  mov BP,0x00D8
  call near 0x5323
  add AX,0x00DA
  mov word ptr DS:[0x11FD],AX
  mov BP,0x00CC
  call near 0x5323
  mov BP,0x00D2
  call near 0x5323
  pop DI
  pop SI
  ret near
```

**Calls:** 0x5323, 0x5323, 0x5323, 0x5323, 0x5323

**CFG Block:**
- ID: 13835
- Entry: 100D:52DD, Term: 100D:52E0
- Preds: [13828, 13832, 13849, 26985], Succs: [13838, 13845]

---

### `run_troop_occupation_callback` — seg000:6C26

**Status:** Never executed during discovery.

---

### `troop_travel_step_unless_selected` — seg000:6CED

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:6CED troop_travel_step_unless_selected
  mov AL,byte ptr DS:[SI]
  cmp AL,byte ptr DS:[0x1954]
  je short 0x6CC3
  push SI
  call near 0x8308
  pop SI
  jmp short 0x6CC3
  cmp byte ptr DS:[DI+8],0x20
  jae short 0x6D18
  cmp byte ptr DS:[DI+0x0B],0x0C
  jae short 0x6D18
  test byte ptr DS:[DI+0x0A],1
  jne short 0x6D18
  inc byte ptr DS:[DI+0x0B]
  push SI
  push DI
  call near 0x644E
  pop DI
  pop SI
  ret near
```

**Calls:** 0x8308, 0x644E

**CFG Block:**
- ID: 29726
- Entry: 100D:6CED, Term: 100D:6CF3
- Preds: [25125], Succs: [29730]

---

### `troop_turn_around_home` — seg000:841F

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:841F troop_turn_around_home
  mov DI,word ptr DS:[SI+4]
  cmp DI,word ptr DS:[SI+0x0C]
  je short 0x844D
  push SI
  call near 0x7F27
  pop SI
  mov BX,word ptr DS:[SI+0x0E]
  mov CX,BX
  xor BH,BH
  cmp byte ptr DS:[BX+0x46FE],0
  je short 0x8442
  dec byte ptr DS:[BX+DI+0x14]
  or byte ptr DS:[SI+0x19],CH
  xor CH,CH
  mov word ptr DS:[SI+0x0E],CX
  mov DI,word ptr DS:[SI+0x0C]
  mov word ptr DS:[SI+4],DI
  jmp short 0x8461
  and byte ptr DS:[SI+3],0xFC
  jmp near 0x83BC
  call near 0x6917
  je short 0x8467
  ret near
```

**Calls:** 0x7F27, 0x6917

**CFG Block:**
- ID: 31350
- Entry: 100D:841F, Term: 100D:8425
- Preds: [29855], Succs: [31354, 31388]

---

### `walk_facing_sprite` — seg000:913B

**Status:** Was executed during discovery but has no stub (possible partial coverage).

**Disassembly (first 40 instr):**

```asm
; 100D:913B walk_facing_sprite
  mov SI,word ptr DS:[0x4756]
  cmp AL,0x0E
  je short 0x9155
  cmp byte ptr DS:[0x002A],0xC8
  je short 0x9173
  mov AL,byte ptr DS:[0x476C]
  shl AX,1
  mov SI,AX
  mov SI,word ptr DS:[SI+0x4758]
  mov AL,byte ptr DS:[SI]
  push DX
  mov DL,3
  div DL
  mov DL,0x0F
  or AH,AH
  je short 0x9164
  mov DL,0x11
  cmp AL,DL
  jb short 0x916C
  sub AL,DL
  jmp short 0x9164
  pop DX
  xchg AL,AH
  add AL,0x0E
  inc AH
  mov byte ptr DS:[0x47D0],AH
  xor AH,AH
  ret near
```

**CFG Block:**
- ID: 22889
- Entry: 100D:913B, Term: 100D:9141
- Preds: [22887], Succs: [22893, 23483]

---

## zoom.rs (1 functions)

### `zoom_blit` — segvga:3A14

**Status:** In VGA BIOS segment - not present in any dump (separate code path).

---
