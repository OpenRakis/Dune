using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.Exceptions;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.ReverseEngineer;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;
using System;
using System.Collections.Generic;

namespace Spice86.Generated;

public partial class CfgGeneratedOverrides
{
    public virtual Action results_draw_text_and_icones(int loadOffset)
    {
    label_100D_BE1D_1BEED_18847:
        CheckExternalEvents(cs1, 0xBE1D);
        // 100D:BE1D mov AX,1
        AX = (ushort)0x0001;
        // 100D:BE20 call near 0xC13E
        NearCall(cs1, 0xBE23, open_sprite_bank);
    label_100D_BE23_1BEF3_18850:
        CheckExternalEvents(cs1, 0xBE23);
        // 100D:BE23 mov SI,0x2506
        SI = (ushort)0x2506;
        // 100D:BE26 call near 0xC21B
        NearCall(cs1, 0xBE29, draw_icons_list_at_si);
    label_100D_BE29_1BEF9_18853:
        CheckExternalEvents(cs1, 0xBE29);
        // 100D:BE29 call near 0xBED7
        NearCall(cs1, 0xBE2C, results_update_gauge_targets);
    label_100D_BE2C_1BEFC_19074:
        CheckExternalEvents(cs1, 0xBE2C);
        // 100D:BE2C call near 0xBDFA
        NearCall(cs1, 0xBE2F, ui_stats_draw_ingame_day_and_charisma);
    label_100D_BE2F_1BEFF_19147:
        CheckExternalEvents(cs1, 0xBE2F);
        // 100D:BE2F mov SI,0xDD17
        SI = (ushort)0xDD17;
        // 100D:BE32 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:BE34 mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:BE36 mov word ptr DS:[SI+2],AX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = AX;
        // 100D:BE39 mov word ptr DS:[SI+4],AX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = AX;
        // 100D:BE3C mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:BE3F and AX,0xFFF0
        AX = Alu16.And(AX, (ushort)0xFFF0);
        // 100D:BE42 mov word ptr DS:[0x115C],AX
        UInt16[DS, (ushort)0x115C] = AX;
        // 100D:BE45 call near 0xD075
        NearCall(cs1, 0xBE48, font_select_small_font);
    label_100D_BE48_1BF18_19157:
        CheckExternalEvents(cs1, 0xBE48);
        // 100D:BE48 mov SI,0x2494
        SI = (ushort)0x2494;
        // 100D:BE4B call near 0xD1A6
        NearCall(cs1, 0xBE4E, unknown_100D_D1A6_1D276);
    label_100D_BE4E_1BF1E_19160:
        CheckExternalEvents(cs1, 0xBE4E);
        // 100D:BE4E mov SI,0xBE57
        SI = (ushort)0xBE57;
        // 100D:BE51 mov BP,0x000C
        BP = (ushort)0x000C;
        // 100D:BE54 call near 0xDA25
        NearCall(cs1, 0xBE57, add_frame_task);
        return tick_results_gauges(0x0000);
    }

    public virtual Action tick_results_gauges(int loadOffset)
    {
    label_100D_BE57_1BF27_19164:
        CheckExternalEvents(cs1, 0xBE57);
        // 100D:BE57 call near 0xC08E
        NearCall(cs1, 0xBE5A, set_screen_as_active_framebuffer);
    label_100D_BE5A_1BF2A_19166:
        CheckExternalEvents(cs1, 0xBE5A);
        // 100D:BE5A mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:BE5D call near 0xDB74
        NearCall(cs1, 0xBE60, restore_mouse_if_rect_intersects);
    label_100D_BE60_1BF30_19169:
        CheckExternalEvents(cs1, 0xBE60);
        // 100D:BE60 call near 0xC137
        NearCall(cs1, 0xBE63, open_icones_spritesheet);
    label_100D_BE63_1BF33_19171:
        CheckExternalEvents(cs1, 0xBE63);
        // 100D:BE63 mov SI,0xDD11
        SI = (ushort)0xDD11;
        // 100D:BE66 xor BP,BP
        BP = Alu16.Xor(BP, BP);
    label_100D_BE68_1BF38_19174:
        CheckExternalEvents(cs1, 0xBE68);
        // 100D:BE68 mov CL,byte ptr DS:[SI]
        CL = UInt8[DS, SI];
        // 100D:BE6A sub CL,byte ptr DS:[SI+6]
        CL = Alu8.Sub(CL, UInt8[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:BE6D je short 0xBECD
        if (ZeroFlag)
        {
            goto label_100D_BECD_1BF9D_19209;
        }
    label_100D_BE6F_1BF3F_19177:
        CheckExternalEvents(cs1, 0xBE6F);
        // 100D:BE6F mov AL,1
        AL = (byte)0x01;
        // 100D:BE71 jae short 0xBE75
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:BE71");
        }
    label_100D_BE75_1BF45_19180:
        CheckExternalEvents(cs1, 0xBE75);
        // 100D:BE75 add byte ptr DS:[SI+6],AL
        UInt8[DS, (ushort)(SI + (sbyte)6)] = Alu8.Add(UInt8[DS, (ushort)(SI + (sbyte)6)], AL);
        // 100D:BE78 mov AL,byte ptr DS:[SI+6]
        AL = UInt8[DS, (ushort)(SI + (sbyte)6)];
        // 100D:BE7B cmp AL,0x1E
        Alu8.Sub(AL, (byte)0x1E);
        // 100D:BE7D jb short 0xBE81
        if (CarryFlag)
        {
            goto label_100D_BE81_1BF51_19185;
        }
    label_100D_BE7F_1BF4F_36770:
        CheckExternalEvents(cs1, 0xBE7F);
        // 100D:BE7F mov AL,0x1E
        AL = (byte)0x1E;
    label_100D_BE81_1BF51_19185:
        CheckExternalEvents(cs1, 0xBE81);
        // 100D:BE81 mov BX,BP
        BX = BP;
        // 100D:BE83 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BE85 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BE87 mov DX,word ptr DS:[BX+0x24EE]
        DX = UInt16[DS, (ushort)(BX + (short)9454)];
        // 100D:BE8B mov BX,word ptr DS:[BX+0x24F0]
        BX = UInt16[DS, (ushort)(BX + (short)9456)];
        // 100D:BE8F xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:BE91 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:BE93 push SI
        Stack.Push16(SI);
        // 100D:BE94 push BP
        Stack.Push16(BP);
        // 100D:BE95 mov AX,0x0037
        AX = (ushort)0x0037;
        // 100D:BE98 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:BE9A adc AX,0
        AX = Alu16.Adc(AX, (ushort)0x0000);
        // 100D:BE9D call near 0xC2FD
        NearCall(cs1, 0xBEA0, unknown_100D_C2FD_1C3CD);
    label_100D_BEA0_1BF70_19199:
        CheckExternalEvents(cs1, 0xBEA0);
        // 100D:BEA0 sub BX,0x000A
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:BEA3 mov AX,0x0039
        AX = (ushort)0x0039;
        // 100D:BEA6 call near 0xC2FD
        NearCall(cs1, 0xBEA9, unknown_100D_C2FD_1C3CD);
    label_100D_BEA9_1BF79_19203:
        CheckExternalEvents(cs1, 0xBEA9);
        // 100D:BEA9 pop BP
        BP = Stack.Pop16();
        // 100D:BEAA pop SI
        SI = Stack.Pop16();
        // 100D:BEAB mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:BEAD cmp AL,byte ptr DS:[SI+6]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:BEB0 jne short 0xBECD
        if (!ZeroFlag)
        {
            goto label_100D_BECD_1BF9D_19209;
        }
    label_100D_BEB2_1BF82_19215:
        CheckExternalEvents(cs1, 0xBEB2);
        // 100D:BEB2 test BP,1
        Alu16.And(BP, (ushort)0x0001);
        // 100D:BEB6 mov AX,0x003F
        AX = (ushort)0x003F;
        // 100D:BEB9 je short 0xBEBD
        if (ZeroFlag)
        {
            goto label_100D_BEBD_1BF8D_19221;
        }
    label_100D_BEBB_1BF8B_19219:
        CheckExternalEvents(cs1, 0xBEBB);
        // 100D:BEBB mov AL,0x25
        AL = (byte)0x25;
    label_100D_BEBD_1BF8D_19221:
        CheckExternalEvents(cs1, 0xBEBD);
        // 100D:BEBD mov word ptr DS:[0xDBE4],AX
        UInt16[DS, (ushort)0xDBE4] = AX;
        // 100D:BEC0 add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:BEC3 call near 0xD04E
        NearCall(cs1, 0xBEC6, font_set_draw_position);
    label_100D_BEC6_1BF96_19224:
        CheckExternalEvents(cs1, 0xBEC6);
        // 100D:BEC6 mov AL,byte ptr SS:[BP+0x116A]
        AL = UInt8[SS, (ushort)(BP + (short)4458)];
        // 100D:BECA call near 0xD12F
        NearCall(cs1, 0xBECD, unknown_100D_D12F_1D1FF);
    label_100D_BECD_1BF9D_19209:
        CheckExternalEvents(cs1, 0xBECD);
        // 100D:BECD inc SI
        SI = Alu16.Inc(SI);
        // 100D:BECE inc BP
        BP = Alu16.Inc(BP);
        // 100D:BECF cmp BP,6
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:BED2 jb short 0xBE68
        if (CarryFlag)
        {
            goto label_100D_BE68_1BF38_19174;
        }
    label_100D_BED4_1BFA4_19227:
        CheckExternalEvents(cs1, 0xBED4);
        // 100D:BED4 jmp near 0xC07C
        return set_fb1_as_active_framebuffer(0x0000);
    }

    public virtual Action results_update_gauge_targets(int loadOffset)
    {
    label_100D_BED7_1BFA7_18855:
        CheckExternalEvents(cs1, 0xBED7);
        // 100D:BED7 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:BEDA and AX,0xFFF0
        AX = Alu16.And(AX, (ushort)0xFFF0);
        // 100D:BEDD mov word ptr DS:[0x115C],AX
        UInt16[DS, (ushort)0x115C] = AX;
        // 100D:BEE0 call near 0xC02E
        NearCall(cs1, 0xBEE3, recompute_condit_statistics);
    label_100D_BEE3_1BFB3_18936:
        CheckExternalEvents(cs1, 0xBEE3);
        // 100D:BEE3 call near 0xBF26
        NearCall(cs1, 0xBEE6, results_update_percent_strings);
    label_100D_BEE6_1BFB6_19039:
        CheckExternalEvents(cs1, 0xBEE6);
        // 100D:BEE6 push DS
        Stack.Push16(DS);
        // 100D:BEE7 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:BEE8 mov DI,0xDD11
        DI = (ushort)0xDD11;
        // 100D:BEEB mov AX,word ptr DS:[0x00A4]
        AX = UInt16[DS, (ushort)0x00A4];
        // 100D:BEEE shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BEF0 inc AX
        AX = Alu16.Inc(AX);
        // 100D:BEF1 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BEF2 mov AX,word ptr DS:[0x00A2]
        AX = UInt16[DS, (ushort)0x00A2];
        // 100D:BEF5 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BEF7 inc AX
        AX = Alu16.Inc(AX);
        // 100D:BEF8 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BEF9 mov AX,word ptr DS:[0x00A8]
        AX = UInt16[DS, (ushort)0x00A8];
        // 100D:BEFC shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BEFE shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF00 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF02 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF04 inc AL
        AL = Alu8.Inc(AL);
        // 100D:BF06 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BF07 mov AX,word ptr DS:[0x00A6]
        AX = UInt16[DS, (ushort)0x00A6];
        // 100D:BF0A shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF0C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF0E shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF10 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BF12 inc AL
        AL = Alu8.Inc(AL);
        // 100D:BF14 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BF15 mov AX,word ptr DS:[0x00AC]
        AX = UInt16[DS, (ushort)0x00AC];
        // 100D:BF18 mov AL,AH
        AL = AH;
        // 100D:BF1A inc AL
        AL = Alu8.Inc(AL);
        // 100D:BF1C stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BF1D mov AX,word ptr DS:[0x00AA]
        AX = UInt16[DS, (ushort)0x00AA];
        // 100D:BF20 mov AL,AH
        AL = AH;
        // 100D:BF22 inc AL
        AL = Alu8.Inc(AL);
        // 100D:BF24 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BF25 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action results_update_percent_strings(int loadOffset)
    {
    label_100D_BF26_1BFF6_18938:
        CheckExternalEvents(cs1, 0xBF26);
        // 100D:BF26 mov DI,0x115E
        DI = (ushort)0x115E;
        // 100D:BF29 mov BP,0x116A
        BP = (ushort)0x116A;
        // 100D:BF2C mov SI,0x00C4
        SI = (ushort)0x00C4;
        // 100D:BF2F call near 0xCF70
        NearCall(cs1, 0xBF32, get_phrase_or_command_string);
    label_100D_BF32_1C002_18943:
        CheckExternalEvents(cs1, 0xBF32);
        // 100D:BF32 mov AX,word ptr DS:[0x00A4]
        AX = UInt16[DS, (ushort)0x00A4];
        // 100D:BF35 call near 0xBF73
        NearCall(cs1, 0xBF38, unknown_100D_BF73_1C043);
    label_100D_BF38_1C008_18972:
        CheckExternalEvents(cs1, 0xBF38);
        // 100D:BF38 mov AX,word ptr DS:[0x00A2]
        AX = UInt16[DS, (ushort)0x00A2];
        // 100D:BF3B call near 0xBF73
        NearCall(cs1, 0xBF3E, unknown_100D_BF73_1C043);
    label_100D_BF3E_1C00E_18981:
        CheckExternalEvents(cs1, 0xBF3E);
        // 100D:BF3E mov AX,word ptr DS:[0x00A8]
        AX = UInt16[DS, (ushort)0x00A8];
        // 100D:BF41 call near 0xBF61
        NearCall(cs1, 0xBF44, unknown_100D_BF61_1C031);
    label_100D_BF44_1C014_19029:
        CheckExternalEvents(cs1, 0xBF44);
        // 100D:BF44 mov AX,word ptr DS:[0x00A6]
        AX = UInt16[DS, (ushort)0x00A6];
        // 100D:BF47 call near 0xBF61
        NearCall(cs1, 0xBF4A, unknown_100D_BF61_1C031);
    label_100D_BF4A_1C01A_19032:
        CheckExternalEvents(cs1, 0xBF4A);
        // 100D:BF4A mov AX,word ptr DS:[0x00AC]
        AX = UInt16[DS, (ushort)0x00AC];
        // 100D:BF4D call near 0xBF61
        NearCall(cs1, 0xBF50, unknown_100D_BF61_1C031);
    label_100D_BF50_1C020_19036:
        CheckExternalEvents(cs1, 0xBF50);
        // 100D:BF50 mov AX,word ptr DS:[0x00AA]
        AX = UInt16[DS, (ushort)0x00AA];
        // 100D:BF53 jmp short 0xBF61
        return unknown_100D_BF61_1C031(0x0000);
    }

    public virtual Action unknown_100D_BF61_1C031(int loadOffset)
    {
    label_100D_BF61_1C031_18984:
        CheckExternalEvents(cs1, 0xBF61);
        // 100D:BF61 push DI
        Stack.Push16(DI);
        // 100D:BF62 push AX
        Stack.Push16(AX);
        // 100D:BF63 call near 0xD03C
        NearCall(cs1, 0xBF66, command_string_replace_number);
    label_100D_BF66_1C036_18988:
        CheckExternalEvents(cs1, 0xBF66);
        // 100D:BF66 dec SI
        SI = Alu16.Dec(SI);
        // 100D:BF67 mov byte ptr ES:[SI],0x30
        UInt8[ES, SI] = (byte)0x30;
        // 100D:BF6B pop AX
        AX = Stack.Pop16();
        // 100D:BF6C push AX
        Stack.Push16(AX);
        // 100D:BF6D call near 0xE31C
        NearCall(cs1, 0xBF70, write_stat_number_5);
    label_100D_BF70_1C040_19026:
        CheckExternalEvents(cs1, 0xBF70);
        // 100D:BF70 inc SI
        SI = Alu16.Inc(SI);
        // 100D:BF71 jmp short 0xBF7D
        return unknown_100D_BF7D_1C04D(0x0000);
    }

    public virtual Action unknown_100D_BF73_1C043(int loadOffset)
    {
    label_100D_BF73_1C043_18946:
        CheckExternalEvents(cs1, 0xBF73);
        // 100D:BF73 push DI
        Stack.Push16(DI);
        // 100D:BF74 push AX
        Stack.Push16(AX);
        // 100D:BF75 call near 0xD03C
        NearCall(cs1, 0xBF78, command_string_replace_number);
    label_100D_BF78_1C048_18950:
        CheckExternalEvents(cs1, 0xBF78);
        // 100D:BF78 pop AX
        AX = Stack.Pop16();
        // 100D:BF79 push AX
        Stack.Push16(AX);
        // 100D:BF7A call near 0xE2E3
        NearCall(cs1, 0xBF7D, write_stat_number_3);
        return unknown_100D_BF7D_1C04D(0x0000);
    }

    public virtual Action string_update_ordinal_suffix(int loadOffset)
    {
    label_100D_BFA7_1C077_19091:
        CheckExternalEvents(cs1, 0xBFA7);
        // 100D:BFA7 mov BL,byte ptr DS:[0xCEEB]
        BL = UInt8[DS, (ushort)0xCEEB];
        // 100D:BFAB xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:BFAD shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BFAF shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BFB1 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BFB3 add BX,0x251A
        BX = Alu16.Add(BX, (ushort)0x251A);
        // 100D:BFB7 mov AX,word ptr ES:[SI-2]
        AX = UInt16[ES, (ushort)(SI + (sbyte)-2)];
        // 100D:BFBB xchg AL,AH
        byte temp_100D_BFBB_1C08B = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_BFBB_1C08B);
        // 100D:BFBD and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:BFBF cmp AH,0x31
        Alu8.Sub(AH, (byte)0x31);
        // 100D:BFC2 je short 0xBFDD
        if (ZeroFlag)
        {
            goto label_100D_BFDD_1C0AD_19116;
        }
    label_100D_BFC4_1C094_19103:
        CheckExternalEvents(cs1, 0xBFC4);
        // 100D:BFC4 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:BFC6 jae short 0xBFDD
        if (!CarryFlag)
        {
            goto label_100D_BFDD_1C0AD_19116;
        }
    label_100D_BFC8_1C098_19106:
        CheckExternalEvents(cs1, 0xBFC8);
        // 100D:BFC8 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:BFCA jne short 0xBFD7
        if (!ZeroFlag)
        {
            goto label_100D_BFD7_1C0A7_19112;
        }
    label_100D_BFCC_1C09C_19109:
        CheckExternalEvents(cs1, 0xBFCC);
        // 100D:BFCC cmp BX,0x2522
        Alu16.Sub(BX, (ushort)0x2522);
        // 100D:BFD0 jne short 0xBFD7
        if (!ZeroFlag)
        {
            goto label_100D_BFD7_1C0A7_19112;
        }
    label_100D_BFD2_1C0A2_40572:
        CheckExternalEvents(cs1, 0xBFD2);
        // 100D:BFD2 cmp AH,0x20
        Alu8.Sub(AH, (byte)0x20);
        // 100D:BFD5 jne short 0xBFDD
        if (!ZeroFlag)
        {
            goto label_100D_BFDD_1C0AD_19116;
        }
    label_100D_BFD7_1C0A7_19112:
        CheckExternalEvents(cs1, 0xBFD7);
        // 100D:BFD7 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:BFD9 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:BFDB add BX,AX
        BX = Alu16.Add(BX, AX);
    label_100D_BFDD_1C0AD_19116:
        CheckExternalEvents(cs1, 0xBFDD);
        // 100D:BFDD mov AX,word ptr DS:[BX]
        AX = UInt16[DS, BX];
        // 100D:BFDF mov word ptr ES:[SI],AX
        UInt16[ES, SI] = AX;
        // 100D:BFE2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action compute_area_controlled_percentages(int loadOffset)
    {
    label_100D_BFE3_1C0B3_18862:
        CheckExternalEvents(cs1, 0xBFE3);
        // 100D:BFE3 push DS
        Stack.Push16(DS);
        // 100D:BFE4 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:BFE6 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:BFE8 mov CX,0xC5F9
        CX = (ushort)0xC5F9;
        // 100D:BFEB xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:BFED mov DS,word ptr DS:[0xDD00]
        DS = UInt16[DS, (ushort)0xDD00];
    label_100D_BFF1_1C0C1_18869:
        CheckExternalEvents(cs1, 0xBFF1);
        // 100D:BFF1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:BFF2 and AL,0x30
        AL = Alu8.And(AL, (byte)0x30);
        // 100D:BFF4 je short 0xBFFC
        if (ZeroFlag)
        {
            goto label_100D_BFFC_1C0CC_18872;
        }
    label_100D_BFF6_1C0C6_18875:
        CheckExternalEvents(cs1, 0xBFF6);
        // 100D:BFF6 inc DX
        DX = Alu16.Inc(DX);
        // 100D:BFF7 cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:BFF9 je short 0xBFFC
        if (ZeroFlag)
        {
            goto label_100D_BFFC_1C0CC_18872;
        }
    label_100D_BFFB_1C0CB_18879:
        CheckExternalEvents(cs1, 0xBFFB);
        // 100D:BFFB inc BX
        BX = Alu16.Inc(BX);
    label_100D_BFFC_1C0CC_18872:
        CheckExternalEvents(cs1, 0xBFFC);
        // 100D:BFFC loop 0xBFF1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BFF1_1C0C1_18869;
        }
    label_100D_BFFE_1C0CE_18881:
        CheckExternalEvents(cs1, 0xBFFE);
        // 100D:BFFE sub DX,BX
        DX = Alu16.Sub(DX, BX);
        // 100D:C000 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:C002 sub SI,0x0188
        SI = Alu16.Sub(SI, (ushort)0x0188);
        // 100D:C006 inc SI
        SI = Alu16.Inc(SI);
        // 100D:C007 div SI
        ushort divisor_100D_C007_1C0D7 = SI;
        uint dividend_100D_C007_1C0D7 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_C007_1C0D7 = Alu16.Div(unchecked((uint)dividend_100D_C007_1C0D7), unchecked((ushort)divisor_100D_C007_1C0D7));
        AX = unchecked((ushort)quotient_100D_C007_1C0D7);
        DX = unchecked((ushort)(dividend_100D_C007_1C0D7 % unchecked((uint)divisor_100D_C007_1C0D7)));
        // 100D:C009 mov DX,0x0064
        DX = (ushort)0x0064;
        // 100D:C00C mul DX
        uint result_100D_C00C_1C0DC = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_C00C_1C0DC >> 16));
        AX = unchecked((ushort)result_100D_C00C_1C0DC);
        // 100D:C00E add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:C010 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:C013 xchg DX,BX
        ushort temp_100D_C013_1C0E3 = DX;
        DX = BX;
        BX = unchecked((ushort)temp_100D_C013_1C0E3);
        // 100D:C015 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:C017 div SI
        ushort divisor_100D_C017_1C0E7 = SI;
        uint dividend_100D_C017_1C0E7 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_C017_1C0E7 = Alu16.Div(unchecked((uint)dividend_100D_C017_1C0E7), unchecked((ushort)divisor_100D_C017_1C0E7));
        AX = unchecked((ushort)quotient_100D_C017_1C0E7);
        DX = unchecked((ushort)(dividend_100D_C017_1C0E7 % unchecked((uint)divisor_100D_C017_1C0E7)));
        // 100D:C019 mov DX,0x0064
        DX = (ushort)0x0064;
        // 100D:C01C mul DX
        uint result_100D_C01C_1C0EC = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_C01C_1C0EC >> 16));
        AX = unchecked((ushort)result_100D_C01C_1C0EC);
        // 100D:C01E add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:C020 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:C023 inc DX
        DX = Alu16.Inc(DX);
        // 100D:C024 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C025 mov word ptr DS:[0x00A2],DX
        UInt16[DS, (ushort)0x00A2] = DX;
        // 100D:C029 mov word ptr DS:[0x00A4],BX
        UInt16[DS, (ushort)0x00A4] = BX;
        // 100D:C02D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action recompute_condit_statistics(int loadOffset)
    {
    label_100D_C02E_1C0FE_18860:
        CheckExternalEvents(cs1, 0xC02E);
        // 100D:C02E call near 0xBFE3
        NearCall(cs1, 0xC031, compute_area_controlled_percentages);
    label_100D_C031_1C101_18903:
        CheckExternalEvents(cs1, 0xC031);
        // 100D:C031 mov AX,word ptr DS:[0x00A0]
        AX = UInt16[DS, (ushort)0x00A0];
        // 100D:C034 add AX,word ptr DS:[0x1172]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x1172]);
        // 100D:C038 sub AX,word ptr DS:[0x1170]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x1170]);
        // 100D:C03C jae short 0xC040
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:C03C");
        }
    label_100D_C040_1C110_18908:
        CheckExternalEvents(cs1, 0xC040);
        // 100D:C040 cmp AX,word ptr DS:[0x00A6]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x00A6]);
        // 100D:C044 jb short 0xC049
        if (CarryFlag)
        {
            goto label_100D_C049_1C119_18913;
        }
    label_100D_C046_1C116_18911:
        CheckExternalEvents(cs1, 0xC046);
        // 100D:C046 mov word ptr DS:[0x00A6],AX
        UInt16[DS, (ushort)0x00A6] = AX;
    label_100D_C049_1C119_18913:
        CheckExternalEvents(cs1, 0xC049);
        // 100D:C049 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:C04B mov word ptr DS:[0x00AA],AX
        UInt16[DS, (ushort)0x00AA] = AX;
        // 100D:C04E mov word ptr DS:[0x00AC],AX
        UInt16[DS, (ushort)0x00AC] = AX;
        // 100D:C051 mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_C054_1C124_18917:
        CheckExternalEvents(cs1, 0xC054);
        // 100D:C054 mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:C057 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:C05B jne short 0xC073
        if (!ZeroFlag)
        {
            goto label_100D_C073_1C143_18926;
        }
    label_100D_C05D_1C12D_18920:
        CheckExternalEvents(cs1, 0xC05D);
        // 100D:C05D test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:C061 je short 0xC069
        if (ZeroFlag)
        {
            goto label_100D_C069_1C139_18923;
        }
    label_100D_C063_1C133_18931:
        CheckExternalEvents(cs1, 0xC063);
        // 100D:C063 add word ptr DS:[0x00AC],AX
        UInt16[DS, (ushort)0x00AC] = Alu16.Add(UInt16[DS, (ushort)0x00AC], AX);
        // 100D:C067 jmp short 0xC073
        goto label_100D_C073_1C143_18926;
    label_100D_C069_1C139_18923:
        CheckExternalEvents(cs1, 0xC069);
        // 100D:C069 test byte ptr DS:[SI+3],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x80);
        // 100D:C06D jne short 0xC073
        if (!ZeroFlag)
        {
            goto label_100D_C073_1C143_18926;
        }
    label_100D_C06F_1C13F_26739:
        CheckExternalEvents(cs1, 0xC06F);
        // 100D:C06F add word ptr DS:[0x00AA],AX
        UInt16[DS, (ushort)0x00AA] = Alu16.Add(UInt16[DS, (ushort)0x00AA], AX);
    label_100D_C073_1C143_18926:
        CheckExternalEvents(cs1, 0xC073);
        // 100D:C073 add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:C076 cmp byte ptr DS:[SI],0
        Alu8.Sub(UInt8[DS, SI], (byte)0x00);
        // 100D:C079 jne short 0xC054
        if (!ZeroFlag)
        {
            goto label_100D_C054_1C124_18917;
        }
    label_100D_C07B_1C14B_18934:
        CheckExternalEvents(cs1, 0xC07B);
        // 100D:C07B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action set_fb1_as_active_framebuffer(int loadOffset)
    {
    label_100D_C07C_1C14C_2703:
        CheckExternalEvents(cs1, 0xC07C);
        // 100D:C07C push word ptr DS:[0xDBD6]
        Stack.Push16(UInt16[DS, (ushort)0xDBD6]);
        // 100D:C080 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_C080_1C150 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C080_1C150 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_C080_1C150 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_C080_1C150);
        // 100D:C084 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action set_backbuffer_as_frame_buffer(int loadOffset)
    {
    label_100D_C085_1C155_21969:
        CheckExternalEvents(cs1, 0xC085);
        // 100D:C085 push word ptr DS:[0xDC32]
        Stack.Push16(UInt16[DS, (ushort)0xDC32]);
        // 100D:C089 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_C089_1C159 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C089_1C159 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_C089_1C159 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_C089_1C159);
        // 100D:C08D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action set_screen_as_active_framebuffer(int loadOffset)
    {
    label_100D_C08E_1C15E_736:
        CheckExternalEvents(cs1, 0xC08E);
        // 100D:C08E push word ptr DS:[0xDBD8]
        Stack.Push16(UInt16[DS, (ushort)0xDBD8]);
        // 100D:C092 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_C092_1C162 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C092_1C162 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_C092_1C162 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_C092_1C162);
        // 100D:C096 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action gfx_call_bp_with_front_buffer_as_screen(int loadOffset)
    {
    entrydispatcher:
    label_100D_C097_1C167_3613:
        CheckExternalEvents(cs1, 0xC097);
        // 100D:C097 call near 0xC07C
        NearCall(cs1, 0xC09A, set_fb1_as_active_framebuffer);
    label_100D_C09A_1C16A_3615:
        CheckExternalEvents(cs1, 0xC09A);
        // 100D:C09A push word ptr DS:[0xDBD8]
        Stack.Push16(UInt16[DS, (ushort)0xDBD8]);
        // 100D:C09E push word ptr DS:[0xDBD6]
        Stack.Push16(UInt16[DS, (ushort)0xDBD6]);
        // 100D:C0A2 pop word ptr DS:[0xDBD8]
        ushort popStackCheck_100D_C0A2_1C172 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C0A2_1C172 = UInt16[DS, (ushort)0xDBD8];
        ushort poppedValue_100D_C0A2_1C172 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBD8] = unchecked((ushort)poppedValue_100D_C0A2_1C172);
        // 100D:C0A6 call near BP
        switch ((ushort)(BP))
        {
            case 0x02C1:
                NearCall(cs1, 0xC0A8, intro_floppy_render_scene);
                break;
            case 0x0301:
                NearCall(cs1, 0xC0A8, intro_floppy_draw_xplain9);
                break;
            case 0x061C:
                NearCall(cs1, 0xC0A8, stage_00_init);
                break;
            case 0x064D:
                NearCall(cs1, 0xC0A8, stage_02_init);
                break;
            case 0x0658:
                NearCall(cs1, 0xC0A8, stage_03_init);
                break;
            case 0x0678:
                NearCall(cs1, 0xC0A8, stage_05_init);
                break;
            case 0x069E:
                NearCall(cs1, 0xC0A8, stage_08_init);
                break;
            case 0x06CE:
                NearCall(cs1, 0xC0A8, stage_12_init);
                break;
            case 0x06D3:
                NearCall(cs1, 0xC0A8, unknown_100D_06D3_107A3);
                break;
            case 0x06D8:
                NearCall(cs1, 0xC0A8, stage_29_init);
                break;
            case 0x06EA:
                NearCall(cs1, 0xC0A8, unknown_100D_06EA_107BA);
                break;
            case 0x0711:
                NearCall(cs1, 0xC0A8, stage_41_init);
                break;
            case 0x0737:
                NearCall(cs1, 0xC0A8, unknown_100D_0737_10807);
                break;
            case 0x073C:
                NearCall(cs1, 0xC0A8, unknown_100D_073C_1080C);
                break;
            case 0x0740:
                NearCall(cs1, 0xC0A8, unknown_100D_0740_10810);
                break;
            case 0x0747:
                NearCall(cs1, 0xC0A8, unknown_100D_0747_10817);
                break;
            case 0x074B:
                NearCall(cs1, 0xC0A8, unknown_100D_074B_1081B);
                break;
            case 0x0752:
                NearCall(cs1, 0xC0A8, unknown_100D_0752_10822);
                break;
            case 0x0756:
                NearCall(cs1, 0xC0A8, unknown_100D_0756_10826);
                break;
            case 0x075A:
                NearCall(cs1, 0xC0A8, unknown_100D_075A_1082A);
                break;
            case 0x075E:
                NearCall(cs1, 0xC0A8, unknown_100D_075E_1082E);
                break;
            case 0x0762:
                NearCall(cs1, 0xC0A8, unknown_100D_0762_10832);
                break;
            case 0x0766:
                NearCall(cs1, 0xC0A8, unknown_100D_0766_10836);
                break;
            case 0x076A:
                NearCall(cs1, 0xC0A8, intro_floppy_scene_back);
                break;
            case 0x0771:
                NearCall(cs1, 0xC0A8, stage_16_init);
                break;
            case 0x077C:
                NearCall(cs1, 0xC0A8, stage_20_init);
                break;
            case 0x0788:
                NearCall(cs1, 0xC0A8, stage_21_init);
                break;
            case 0x07A3:
                NearCall(cs1, 0xC0A8, stage_22_init);
                break;
            case 0x07C6:
                NearCall(cs1, 0xC0A8, stage_23_init);
                break;
            case 0x07E0:
                NearCall(cs1, 0xC0A8, stage_38_init);
                break;
            case 0x07EE:
                NearCall(cs1, 0xC0A8, stage_17_init);
                break;
            case 0x07FD:
                NearCall(cs1, 0xC0A8, stage_11_init);
                break;
            case 0x0868:
                NearCall(cs1, 0xC0A8, stage_24_init);
                break;
            case 0x0886:
                NearCall(cs1, 0xC0A8, stage_25_init);
                break;
            case 0x095D:
                NearCall(cs1, 0xC0A8, unknown_100D_095D_10A2D);
                break;
            case 0x0972:
                NearCall(cs1, 0xC0A8, stage_13_init);
                break;
            case 0x098A:
                NearCall(cs1, 0xC0A8, stage_14_init);
                break;
            case 0x0995:
                NearCall(cs1, 0xC0A8, stage_15_init);
                break;
            case 0x09A5:
                NearCall(cs1, 0xC0A8, stage_18_init);
                break;
            case 0x09AD:
                NearCall(cs1, 0xC0A8, stage_26_init);
                break;
            case 0x09EF:
                NearCall(cs1, 0xC0A8, unknown_100D_09EF_10ABF);
                break;
            case 0x09F5:
                NearCall(cs1, 0xC0A8, book_play_credits_scroll);
                break;
            case 0x0A44:
                NearCall(cs1, 0xC0A8, unknown_100D_0A44_10B14);
                break;
            case 0x0ACD:
                NearCall(cs1, 0xC0A8, night_attack_start);
                break;
            case 0x0ED0:
                NearCall(cs1, 0xC0A8, callback_transition_look_at_mirror);
                break;
            case 0x0F66:
                NearCall(cs1, 0xC0A8, globe_mouse_noop);
                break;
            case 0x1498:
                NearCall(cs1, 0xC0A8, unknown_100D_1498_11568);
                break;
            case 0x14AC:
                NearCall(cs1, 0xC0A8, unknown_100D_14AC_1157C);
                break;
            case 0x15B7:
                NearCall(cs1, 0xC0A8, unknown_100D_15B7_11687);
                break;
            case 0x15C9:
                NearCall(cs1, 0xC0A8, unknown_100D_15C9_11699);
                break;
            case 0x15D4:
                NearCall(cs1, 0xC0A8, unknown_100D_15D4_116A4);
                break;
            case 0x15DF:
                NearCall(cs1, 0xC0A8, unknown_100D_15DF_116AF);
                break;
            case 0x15EA:
                NearCall(cs1, 0xC0A8, unknown_100D_15EA_116BA);
                break;
            case 0x15F5:
                NearCall(cs1, 0xC0A8, unknown_100D_15F5_116C5);
                break;
            case 0x1603:
                NearCall(cs1, 0xC0A8, unknown_100D_1603_116D3);
                break;
            case 0x1617:
                NearCall(cs1, 0xC0A8, unknown_100D_1617_116E7);
                break;
            case 0x1625:
                NearCall(cs1, 0xC0A8, unknown_100D_1625_116F5);
                break;
            case 0x1630:
                NearCall(cs1, 0xC0A8, unknown_100D_1630_11700);
                break;
            case 0x163E:
                NearCall(cs1, 0xC0A8, unknown_100D_163E_1170E);
                break;
            case 0x164C:
                NearCall(cs1, 0xC0A8, unknown_100D_164C_1171C);
                break;
            case 0x1797:
                NearCall(cs1, 0xC0A8, ui_hud_head_draw);
                break;
            case 0x2555:
                NearCall(cs1, 0xC0A8, unknown_100D_2555_12625);
                break;
            case 0x26A6:
                NearCall(cs1, 0xC0A8, unknown_100D_26A6_12776);
                break;
            case 0x28B5:
                NearCall(cs1, 0xC0A8, comm_draw_message_face);
                break;
            case 0x2C9A:
                NearCall(cs1, 0xC0A8, vision_dream_backdrop);
                break;
            case 0x2DB1:
                NearCall(cs1, 0xC0A8, draw_room_game_screen);
                break;
            case 0x2DBF:
                NearCall(cs1, 0xC0A8, draw_room_game_screen_scene_reload);
                break;
            case 0x2DD3:
                NearCall(cs1, 0xC0A8, draw_room_scene_and_present);
                break;
            case 0x2EB2:
                NearCall(cs1, 0xC0A8, ui_draw_room_command_panel);
                break;
            case 0x37B2:
                NearCall(cs1, 0xC0A8, draw_room_scene);
                break;
            case 0x4913:
                NearCall(cs1, 0xC0A8, unknown_100D_4913_149E3);
                break;
            case 0x5A56:
                NearCall(cs1, 0xC0A8, callback_transition_dune_map_view);
                break;
            case 0x98B2:
                NearCall(cs1, 0xC0A8, tear_down_prior_talking_head_overlay);
                break;
            case 0xAF26:
                NearCall(cs1, 0xC0A8, callback_transition_book_open);
                break;
            case 0xAF43:
                NearCall(cs1, 0xC0A8, callback_transition_book_cover);
                break;
            case 0xB039:
                NearCall(cs1, 0xC0A8, book_draw_current_page);
                break;
            case 0xB236:
                NearCall(cs1, 0xC0A8, callback_transition_book_video_load);
                break;
            case 0xB23F:
                NearCall(cs1, 0xC0A8, callback_transition_book_video_done);
                break;
            case 0xB827:
                NearCall(cs1, 0xC0A8, draw_globe_and_ui_to_front_buffer);
                break;
            case 0xBE1D:
                NearCall(cs1, 0xC0A8, results_draw_text_and_icones);
                break;
            case 0xC0AD:
                NearCall(cs1, 0xC0A8, gfx_clear_active_framebuffer);
                break;
            case 0xCEFC:
                NearCall(cs1, 0xC0A8, stage_06_init);
                break;
            case 0xD1EF:
                NearCall(cs1, 0xC0A8, draw_all_ui_elements);
                break;
            case 0xD717:
                NearCall(cs1, 0xC0A8, ui_setup_and_draw_nav_panel);
                break;
            case 0xD75A:
                NearCall(cs1, 0xC0A8, ui_set_and_draw_frieze_sides_closed_book);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:C0A6");
        }
    label_100D_C0A8_1C178_4427:
        CheckExternalEvents(cs1, 0xC0A8);
        // 100D:C0A8 pop word ptr DS:[0xDBD8]
        ushort popStackCheck_100D_C0A8_1C178 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C0A8_1C178 = UInt16[DS, (ushort)0xDBD8];
        ushort poppedValue_100D_C0A8_1C178 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBD8] = unchecked((ushort)poppedValue_100D_C0A8_1C178);
        // 100D:C0AC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action gfx_clear_active_framebuffer(int loadOffset)
    {
    label_100D_C0AD_1C17D_2709:
        CheckExternalEvents(cs1, 0xC0AD);
        // 100D:C0AD mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C0B1 call far dword ptr DS:[0x38D5]
        ushort targetSegment_2711 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D5 + (ushort)0x0002)]));
        ushort targetOffset_2711 = unchecked((ushort)(UInt16[DS, (ushort)0x38D5]));
        if (targetSegment_2711 == cs2 && targetOffset_2711 == 0x0118)
        {
            FarCall(cs1, 0xC0B5, cs2, unknown_3358_0118_33698);
            goto label_100D_C0B5_1C185_2726;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_2711:X4}:{targetOffset_2711:X4} at 100D:C0B1");
    label_100D_C0B5_1C185_2726:
        CheckExternalEvents(cs1, 0xC0B5);
        // 100D:C0B5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action tick_room(int loadOffset)
    {
    label_100D_C0B6_1C186_11042:
        CheckExternalEvents(cs1, 0xC0B6);
        // 100D:C0B6 call near 0xD41B
        NearCall(cs1, 0xC0B9, get_location_and_room);
    label_100D_C0B9_1C189_11044:
        CheckExternalEvents(cs1, 0xC0B9);
        // 100D:C0B9 cmp BP,0x2012
        Alu16.Sub(BP, (ushort)0x2012);
        // 100D:C0BD je short 0xC0D4
        if (ZeroFlag)
        {
            goto label_100D_C0D4_1C1A4_11297;
        }
    label_100D_C0BF_1C18F_11047:
        CheckExternalEvents(cs1, 0xC0BF);
        // 100D:C0BF cmp BP,0x201A
        Alu16.Sub(BP, (ushort)0x201A);
        // 100D:C0C3 je short 0xC0D4
        if (ZeroFlag)
        {
            goto label_100D_C0D4_1C1A4_11297;
        }
    label_100D_C0C5_1C195_11050:
        CheckExternalEvents(cs1, 0xC0C5);
        // 100D:C0C5 mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:C0C7 call near 0xC0D5
        NearCall(cs1, 0xC0CA, blit_fb1_to_screen_effect);
    label_100D_C0CA_1C19A_11294:
        CheckExternalEvents(cs1, 0xC0CA);
        // 100D:C0CA cmp CX,0x0018
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)24)));
        // 100D:C0CD jne short 0xC0D4
        if (!ZeroFlag)
        {
            goto label_100D_C0D4_1C1A4_11297;
        }
    label_100D_C0CF_1C19F_11389:
        CheckExternalEvents(cs1, 0xC0CF);
        // 100D:C0CF mov AL,4
        AL = (byte)0x04;
        // 100D:C0D1 jmp near 0xAB15
        return audio_start_voc(0x0000);
    label_100D_C0D4_1C1A4_11297:
        CheckExternalEvents(cs1, 0xC0D4);
        // 100D:C0D4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action blit_fb1_to_screen_effect(int loadOffset)
    {
    label_100D_C0D5_1C1A5_11053:
        CheckExternalEvents(cs1, 0xC0D5);
        // 100D:C0D5 push DS
        Stack.Push16(DS);
        // 100D:C0D6 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C0DA mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C0DE mov BP,0xCE7A
        BP = (ushort)0xCE7A;
        // 100D:C0E1 call far dword ptr SS:[0x392D]
        ushort targetSegment_11058 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x392D + (ushort)0x0002)]));
        ushort targetOffset_11058 = unchecked((ushort)(UInt16[SS, (ushort)0x392D]));
        if (targetSegment_11058 == cs2 && targetOffset_11058 == 0x015A)
        {
            FarCall(cs1, 0xC0E6, cs2, unknown_3358_015A_336DA);
            goto label_100D_C0E6_1C1B6_11291;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11058:X4}:{targetOffset_11058:X4} at 100D:C0E1");
    label_100D_C0E6_1C1B6_11291:
        CheckExternalEvents(cs1, 0xC0E6);
        // 100D:C0E6 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C0E7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C0E8_1C1B8(int loadOffset)
    {
    label_100D_C0E8_1C1B8_23844:
        CheckExternalEvents(cs1, 0xC0E8);
        // 100D:C0E8 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C0EC mov BP,0xCE7A
        BP = (ushort)0xCE7A;
        // 100D:C0EF call far dword ptr DS:[0x392D]
        ushort targetSegment_23847 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x392D + (ushort)0x0002)]));
        ushort targetOffset_23847 = unchecked((ushort)(UInt16[DS, (ushort)0x392D]));
        if (targetSegment_23847 == cs2 && targetOffset_23847 == 0x015A)
        {
            FarCall(cs1, 0xC0F3, cs2, unknown_3358_015A_336DA);
            goto label_100D_C0F3_1C1C3_24151;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_23847:X4}:{targetOffset_23847:X4} at 100D:C0EF");
    label_100D_C0F3_1C1C3_24151:
        CheckExternalEvents(cs1, 0xC0F3);
        // 100D:C0F3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action update_screen_palette(int loadOffset)
    {
    label_100D_C0F4_1C1C4_4698:
        CheckExternalEvents(cs1, 0xC0F4);
        // 100D:C0F4 mov AX,word ptr DS:[0xDBD6]
        AX = UInt16[DS, (ushort)0xDBD6];
        // 100D:C0F7 cmp AX,word ptr DS:[0xDBD8]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBD8]);
        // 100D:C0FB je short 0xC101
        if (ZeroFlag)
        {
            goto label_100D_C101_1C1D1_4705;
        }
    label_100D_C0FD_1C1CD_4702:
        CheckExternalEvents(cs1, 0xC0FD);
        // 100D:C0FD call far dword ptr DS:[0x3935]
        ushort targetSegment_4702 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_4702 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_4702 == cs2 && targetOffset_4702 == 0x0160)
        {
            FarCall(cs1, 0xC101, cs2, unknown_3358_0160_336E0);
            goto label_100D_C101_1C1D1_4705;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_4702:X4}:{targetOffset_4702:X4} at 100D:C0FD");
    label_100D_C101_1C1D1_4705:
        CheckExternalEvents(cs1, 0xC101);
        // 100D:C101 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action intro_floppy_render_and_transition_to_scene(int loadOffset)
    {
    label_100D_C102_1C1D2_11531:
        CheckExternalEvents(cs1, 0xC102);
        // 100D:C102 call far dword ptr DS:[0x3959]
        ushort targetSegment_11531 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_11531 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_11531 == cs2 && targetOffset_11531 == 0x017B)
        {
            FarCall(cs1, 0xC106, cs2, unknown_3358_017B_336FB);
            goto label_100D_C106_1C1D6_11533;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11531:X4}:{targetOffset_11531:X4} at 100D:C102");
    label_100D_C106_1C1D6_11533:
        CheckExternalEvents(cs1, 0xC106);
        // 100D:C106 mov AL,0x3A
        AL = (byte)0x3A;
        return transition(0x0000);
    }

    public virtual Action transition(int loadOffset)
    {
    entrydispatcher:
    label_100D_C108_1C1D8_4483:
        CheckExternalEvents(cs1, 0xC108);
        // 100D:C108 mov byte ptr DS:[0xDCE6],0x80
        UInt8[DS, (ushort)0xDCE6] = (byte)0x80;
        // 100D:C10D push AX
        Stack.Push16(AX);
        // 100D:C10E push DX
        Stack.Push16(DX);
        // 100D:C10F call near 0xC097
        NearCall(cs1, 0xC112, gfx_call_bp_with_front_buffer_as_screen);
    label_100D_C112_1C1E2_4490:
        CheckExternalEvents(cs1, 0xC112);
        // 100D:C112 pop DX
        DX = Stack.Pop16();
        // 100D:C113 pop AX
        AX = Stack.Pop16();
        // 100D:C114 push DS
        Stack.Push16(DS);
        // 100D:C115 mov SI,word ptr DS:[0xDBDE]
        SI = UInt16[DS, (ushort)0xDBDE];
        // 100D:C119 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C11D mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C121 mov BP,0xCE7A
        BP = (ushort)0xCE7A;
        // 100D:C124 call far dword ptr SS:[0x3921]
        ushort targetSegment_4498 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3921 + (ushort)0x0002)]));
        ushort targetOffset_4498 = unchecked((ushort)(UInt16[SS, (ushort)0x3921]));
        if (targetSegment_4498 == cs2 && targetOffset_4498 == 0x0151)
        {
            FarCall(cs1, 0xC129, cs2, unknown_3358_0151_336D1);
            goto label_100D_C129_1C1F9_4657;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_4498:X4}:{targetOffset_4498:X4} at 100D:C124");
    label_100D_C129_1C1F9_4657:
        CheckExternalEvents(cs1, 0xC129);
        // 100D:C129 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C12A call near 0xC4CD
        NearCall(cs1, 0xC12D, gfx_copy_whole_framebuf_to_screen);
    label_100D_C12D_1C1FD_4670:
        CheckExternalEvents(cs1, 0xC12D);
        // 100D:C12D call far dword ptr DS:[0x3935]
        ushort targetSegment_4670 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_4670 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_4670 == cs2 && targetOffset_4670 == 0x0160)
        {
            FarCall(cs1, 0xC131, cs2, unknown_3358_0160_336E0);
            goto label_100D_C131_1C201_4693;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_4670:X4}:{targetOffset_4670:X4} at 100D:C12D");
    label_100D_C131_1C201_4693:
        CheckExternalEvents(cs1, 0xC131);
        // 100D:C131 mov byte ptr DS:[0xDCE6],0
        UInt8[DS, (ushort)0xDCE6] = (byte)0x00;
        // 100D:C136 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action open_icones_spritesheet(int loadOffset)
    {
    label_100D_C137_1C207_2924:
        CheckExternalEvents(cs1, 0xC137);
        // 100D:C137 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:C139 jmp short 0xC13E
        return open_sprite_bank(0x0000);
    }

    public virtual Action open_onmap_spritesheet(int loadOffset)
    {
    label_100D_C13B_1C20B_17949:
        CheckExternalEvents(cs1, 0xC13B);
        // 100D:C13B mov AX,word ptr [0x0001C20C]
        AX = UInt16[unchecked((uint)(0x0001C20Cu))];
        return open_sprite_bank(0x0000);
    }

    public virtual Action open_sprite_bank(int loadOffset)
    {
    label_100D_C13E_1C20E_2927:
        CheckExternalEvents(cs1, 0xC13E);
        // 100D:C13E or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:C140 js short 0xC1A9
        if (SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C140");
        }
    label_100D_C142_1C212_2930:
        CheckExternalEvents(cs1, 0xC142);
        // 100D:C142 push BX
        Stack.Push16(BX);
        // 100D:C143 mov BX,AX
        BX = AX;
        // 100D:C145 xchg BX,word ptr DS:[0x2784]
        ushort xchgOffset_100D_C145_1C215 = (ushort)0x2784;
        ushort temp_100D_C145_1C215 = BX;
        BX = UInt16[DS, xchgOffset_100D_C145_1C215];
        UInt16[DS, xchgOffset_100D_C145_1C215] = unchecked((ushort)temp_100D_C145_1C215);
        // 100D:C149 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:C14B je short 0xC1A8
        if (ZeroFlag)
        {
            goto label_100D_C1A8_1C278_2978;
        }
    label_100D_C14D_1C21D_2936:
        CheckExternalEvents(cs1, 0xC14D);
        // 100D:C14D push SI
        Stack.Push16(SI);
        // 100D:C14E push DI
        Stack.Push16(DI);
        // 100D:C14F shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:C151 js short 0xC15B
        if (SignFlag)
        {
            goto label_100D_C15B_1C22B_2941;
        }
    label_100D_C153_1C223_2985:
        CheckExternalEvents(cs1, 0xC153);
        // 100D:C153 mov SI,word ptr DS:[0xCE7B]
        SI = UInt16[DS, (ushort)0xCE7B];
        // 100D:C157 mov word ptr DS:[BX-9588],SI
        UInt16[DS, (ushort)(BX + (short)-9588)] = SI;
    label_100D_C15B_1C22B_2941:
        CheckExternalEvents(cs1, 0xC15B);
        // 100D:C15B mov SI,AX
        SI = AX;
        // 100D:C15D shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C15F shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C161 add SI,0xD844
        SI = Alu16.Add(SI, (ushort)0xD844);
        // 100D:C165 les DI,word ptr DS:[SI]
        ushort lxsOffset_100D_C165_1C235 = SI;
        ushort lxsValue_100D_C165_1C235 = UInt16[DS, lxsOffset_100D_C165_1C235];
        ushort lxsSegment_100D_C165_1C235 = UInt16[DS, (ushort)(lxsOffset_100D_C165_1C235 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_C165_1C235);
        ES = unchecked((ushort)lxsSegment_100D_C165_1C235);
        // 100D:C167 mov BX,ES
        BX = ES;
        // 100D:C169 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:C16B je short 0xC177
        if (ZeroFlag)
        {
            goto label_100D_C177_1C247_2950;
        }
    label_100D_C16D_1C23D_7822:
        CheckExternalEvents(cs1, 0xC16D);
        // 100D:C16D cmp DI,2
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:C170 jbe short 0xC19E
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C19E_1C26E_2974;
        }
    label_100D_C172_1C242_7825:
        CheckExternalEvents(cs1, 0xC172);
        // 100D:C172 call near 0xC1AA
        NearCall(cs1, 0xC175, apply_sprite_sheet_palette);
    label_100D_C175_1C245_7827:
        CheckExternalEvents(cs1, 0xC175);
        // 100D:C175 jmp short 0xC19E
        goto label_100D_C19E_1C26E_2974;
    label_100D_C177_1C247_2950:
        CheckExternalEvents(cs1, 0xC177);
        // 100D:C177 push CX
        Stack.Push16(CX);
        // 100D:C178 push DX
        Stack.Push16(DX);
        // 100D:C179 push BP
        Stack.Push16(BP);
        // 100D:C17A push SI
        Stack.Push16(SI);
        // 100D:C17B mov SI,AX
        SI = AX;
        // 100D:C17D call near 0xF0B9
        NearCall(cs1, 0xC180, bank_filename);
    label_100D_C180_1C250_2957:
        CheckExternalEvents(cs1, 0xC180);
        // 100D:C180 cmp word ptr ES:[DI],2
        Alu16.Sub(UInt16[ES, DI], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:C184 jbe short 0xC189
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C189_1C259_2960;
        }
    label_100D_C186_1C256_5972:
        CheckExternalEvents(cs1, 0xC186);
        // 100D:C186 call near 0xC1AA
        NearCall(cs1, 0xC189, apply_sprite_sheet_palette);
    label_100D_C189_1C259_2960:
        CheckExternalEvents(cs1, 0xC189);
        // 100D:C189 pop SI
        SI = Stack.Pop16();
        // 100D:C18A mov DI,word ptr ES:[DI]
        DI = UInt16[ES, DI];
        // 100D:C18D sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:C18F mov word ptr DS:[SI],DI
        UInt16[DS, SI] = DI;
        // 100D:C191 mov word ptr DS:[SI+2],ES
        UInt16[DS, (ushort)(SI + (sbyte)2)] = ES;
        // 100D:C194 mov AX,word ptr DS:[0x2784]
        AX = UInt16[DS, (ushort)0x2784];
        // 100D:C197 call far dword ptr DS:[0x3905]
        ushort targetSegment_2967 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3905 + (ushort)0x0002)]));
        ushort targetOffset_2967 = unchecked((ushort)(UInt16[DS, (ushort)0x3905]));
        if (targetSegment_2967 == cs2 && targetOffset_2967 == 0x013C)
        {
            FarCall(cs1, 0xC19B, cs2, unknown_3358_013C_336BC);
            goto label_100D_C19B_1C26B_2970;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_2967:X4}:{targetOffset_2967:X4} at 100D:C197");
    label_100D_C19B_1C26B_2970:
        CheckExternalEvents(cs1, 0xC19B);
        // 100D:C19B pop BP
        BP = Stack.Pop16();
        // 100D:C19C pop DX
        DX = Stack.Pop16();
        // 100D:C19D pop CX
        CX = Stack.Pop16();
    label_100D_C19E_1C26E_2974:
        CheckExternalEvents(cs1, 0xC19E);
        // 100D:C19E mov word ptr DS:[0xDBB0],DI
        UInt16[DS, (ushort)0xDBB0] = DI;
        // 100D:C1A2 mov word ptr DS:[0xDBB2],ES
        UInt16[DS, (ushort)0xDBB2] = ES;
        // 100D:C1A6 pop DI
        DI = Stack.Pop16();
        // 100D:C1A7 pop SI
        SI = Stack.Pop16();
    label_100D_C1A8_1C278_2978:
        CheckExternalEvents(cs1, 0xC1A8);
        // 100D:C1A8 pop BX
        BX = Stack.Pop16();
        return unknown_100D_C1A9_1C279(0x0000);
    }

    public virtual Action apply_sprite_sheet_palette(int loadOffset)
    {
    label_100D_C1AA_1C27A_5974:
        CheckExternalEvents(cs1, 0xC1AA);
        // 100D:C1AA mov AX,word ptr DS:[0x2784]
        AX = UInt16[DS, (ushort)0x2784];
        // 100D:C1AD mov AH,AL
        AH = AL;
        // 100D:C1AF xchg AL,byte ptr DS:[0xDBB4]
        ushort xchgOffset_100D_C1AF_1C27F = (ushort)0xDBB4;
        byte temp_100D_C1AF_1C27F = AL;
        AL = UInt8[DS, xchgOffset_100D_C1AF_1C27F];
        UInt8[DS, xchgOffset_100D_C1AF_1C27F] = unchecked((byte)temp_100D_C1AF_1C27F);
        // 100D:C1B3 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:C1B5 je short 0xC1A9
        if (ZeroFlag)
        {
            return unknown_100D_C1A9_1C279(0x0000);
        }
    label_100D_C1B7_1C287_6449:
        CheckExternalEvents(cs1, 0xC1B7);
        // 100D:C1B7 mov SI,2
        SI = (ushort)0x0002;
        return apply_palette_update(0x0000);
    }

    public virtual Action apply_palette_update(int loadOffset)
    {
    label_100D_C1BA_1C28A_2626:
        CheckExternalEvents(cs1, 0xC1BA);
        // 100D:C1BA push CX
        Stack.Push16(CX);
        // 100D:C1BB push DX
        Stack.Push16(DX);
        // 100D:C1BC push DI
        Stack.Push16(DI);
    label_100D_C1BD_1C28D_2630:
        CheckExternalEvents(cs1, 0xC1BD);
        // 100D:C1BD lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C1BF cmp AX,0x0100
        Alu16.Sub(AX, (ushort)0x0100);
        // 100D:C1C2 jne short 0xC1C9
        if (!ZeroFlag)
        {
            goto label_100D_C1C9_1C299_2633;
        }
    label_100D_C1C4_1C294_6451:
        CheckExternalEvents(cs1, 0xC1C4);
        // 100D:C1C4 add SI,3
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:C1C7 jmp short 0xC1BD
        goto label_100D_C1BD_1C28D_2630;
    label_100D_C1C9_1C299_2633:
        CheckExternalEvents(cs1, 0xC1C9);
        // 100D:C1C9 mov BX,AX
        BX = AX;
        // 100D:C1CB inc AX
        AX = Alu16.Inc(AX);
        // 100D:C1CC je short 0xC1F0
        if (ZeroFlag)
        {
            goto label_100D_C1F0_1C2C0_2637;
        }
    label_100D_C1CE_1C29E_4116:
        CheckExternalEvents(cs1, 0xC1CE);
        // 100D:C1CE mov CL,BH
        CL = BH;
        // 100D:C1D0 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:C1D2 and CX,0x00FF
        CX = Alu16.And(CX, (ushort)0x00FF);
        // 100D:C1D6 jne short 0xC1DA
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:C1D6");
        }
    label_100D_C1DA_1C2AA_4121:
        CheckExternalEvents(cs1, 0xC1DA);
        // 100D:C1DA mov AX,BX
        AX = BX;
        // 100D:C1DC add BX,BX
        BX = Alu16.Add(BX, BX);
        // 100D:C1DE add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:C1E0 mov AX,CX
        AX = CX;
        // 100D:C1E2 add CX,CX
        CX = Alu16.Add(CX, CX);
        // 100D:C1E4 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:C1E6 mov DX,SI
        DX = SI;
        // 100D:C1E8 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:C1EA call far dword ptr DS:[0x38BD]
        ushort targetSegment_4130 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_4130 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_4130 == cs2 && targetOffset_4130 == 0x0106)
        {
            FarCall(cs1, 0xC1EE, cs2, unknown_3358_0106_33686);
            goto label_100D_C1EE_1C2BE_4206;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_4130:X4}:{targetOffset_4130:X4} at 100D:C1EA");
    label_100D_C1EE_1C2BE_4206:
        CheckExternalEvents(cs1, 0xC1EE);
        // 100D:C1EE jmp short 0xC1BD
        goto label_100D_C1BD_1C28D_2630;
    label_100D_C1F0_1C2C0_2637:
        CheckExternalEvents(cs1, 0xC1F0);
        // 100D:C1F0 pop DI
        DI = Stack.Pop16();
        // 100D:C1F1 pop DX
        DX = Stack.Pop16();
        // 100D:C1F2 pop CX
        CX = Stack.Pop16();
        // 100D:C1F3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C1F4_1C2C4(int loadOffset)
    {
    label_100D_C1F4_1C2C4_5986:
        CheckExternalEvents(cs1, 0xC1F4);
        // 100D:C1F4 push BX
        Stack.Push16(BX);
        // 100D:C1F5 les SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_C1F5_1C2C5 = (ushort)0xDBB0;
        ushort lxsValue_100D_C1F5_1C2C5 = UInt16[DS, lxsOffset_100D_C1F5_1C2C5];
        ushort lxsSegment_100D_C1F5_1C2C5 = UInt16[DS, (ushort)(lxsOffset_100D_C1F5_1C2C5 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C1F5_1C2C5);
        ES = unchecked((ushort)lxsSegment_100D_C1F5_1C2C5);
        // 100D:C1F9 mov BX,AX
        BX = AX;
        // 100D:C1FB shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:C1FD add SI,word ptr ES:[BX+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BX + SI)]);
        // 100D:C200 pop BX
        BX = Stack.Pop16();
        // 100D:C201 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action sprite_center_coords(int loadOffset)
    {
    label_100D_C202_1C2D2_10481:
        CheckExternalEvents(cs1, 0xC202);
        // 100D:C202 push AX
        Stack.Push16(AX);
        // 100D:C203 push SI
        Stack.Push16(SI);
        // 100D:C204 call near 0xC1F4
        NearCall(cs1, 0xC207, unknown_100D_C1F4_1C2C4);
    label_100D_C207_1C2D7_10485:
        CheckExternalEvents(cs1, 0xC207);
        // 100D:C207 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C209 and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:C20C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:C20E sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:C210 lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:C212 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:C214 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:C215 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:C217 pop SI
        SI = Stack.Pop16();
        // 100D:C218 pop AX
        AX = Stack.Pop16();
        // 100D:C219 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_icons_list_at_si(int loadOffset)
    {
    label_100D_C21B_1C2EB_6009:
        CheckExternalEvents(cs1, 0xC21B);
        // 100D:C21B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C21C cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:C21F je short 0xC26A
        if (ZeroFlag)
        {
            return unknown_100D_C26A_1C33A(0x0000);
        }
    label_100D_C221_1C2F1_6013:
        CheckExternalEvents(cs1, 0xC221);
        // 100D:C221 mov BX,AX
        BX = AX;
        // 100D:C223 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C224 mov DX,AX
        DX = AX;
        // 100D:C226 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C227 xchg BX,AX
        ushort temp_100D_C227_1C2F7 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_C227_1C2F7);
        // 100D:C228 push SI
        Stack.Push16(SI);
        // 100D:C229 call near 0xC22F
        NearCall(cs1, 0xC22C, draw_active_bank_sprite);
    label_100D_C22C_1C2FC_6152:
        CheckExternalEvents(cs1, 0xC22C);
        // 100D:C22C pop SI
        SI = Stack.Pop16();
        // 100D:C22D jmp short 0xC21B
        goto label_100D_C21B_1C2EB_6009;
    }

    public virtual Action draw_active_bank_sprite(int loadOffset)
    {
    label_100D_C22F_1C2FF_5778:
        CheckExternalEvents(cs1, 0xC22F);
        // 100D:C22F mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C233 lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_C233_1C303 = (ushort)0xDBB0;
        ushort lxsValue_100D_C233_1C303 = UInt16[DS, lxsOffset_100D_C233_1C303];
        ushort lxsSegment_100D_C233_1C303 = UInt16[DS, (ushort)(lxsOffset_100D_C233_1C303 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C233_1C303);
        DS = unchecked((ushort)lxsSegment_100D_C233_1C303);
        // 100D:C237 mov BP,AX
        BP = AX;
        // 100D:C239 and BP,0x01FF
        BP = Alu16.And(BP, (ushort)0x01FF);
        // 100D:C23D shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:C23F add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:C242 mov CX,AX
        CX = AX;
        // 100D:C244 push AX
        Stack.Push16(AX);
        // 100D:C245 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C246 and CH,0x60
        CH = Alu8.And(CH, (byte)0x60);
        // 100D:C249 or AH,CH
        AH = Alu8.Or(AH, CH);
        // 100D:C24B mov DI,AX
        DI = AX;
        // 100D:C24D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C24E mov CX,AX
        CX = AX;
        // 100D:C250 cmp byte ptr CS:[0xC21A],0
        Alu8.Sub(UInt8[CS, (ushort)0xC21A], (byte)0x00);
        // 100D:C256 je short 0xC25D
        if (ZeroFlag)
        {
            goto label_100D_C25D_1C32D_5795;
        }
    label_100D_C258_1C328_9583:
        CheckExternalEvents(cs1, 0xC258);
        // 100D:C258 mov CH,byte ptr CS:[0xC21A]
        CH = UInt8[CS, (ushort)0xC21A];
    label_100D_C25D_1C32D_5795:
        CheckExternalEvents(cs1, 0xC25D);
        // 100D:C25D pop AX
        AX = Stack.Pop16();
        // 100D:C25E and AX,0x1C00
        AX = Alu16.And(AX, (ushort)0x1C00);
        // 100D:C261 jne short 0xC26B
        if (!ZeroFlag)
        {
            goto label_100D_C26B_1C33B_7660;
        }
    label_100D_C263_1C333_5799:
        CheckExternalEvents(cs1, 0xC263);
        // 100D:C263 call far dword ptr SS:[0x38C9]
        ushort targetSegment_5799 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38C9 + (ushort)0x0002)]));
        ushort targetOffset_5799 = unchecked((ushort)(UInt16[SS, (ushort)0x38C9]));
        if (targetSegment_5799 == cs2 && targetOffset_5799 == 0x010F)
        {
            FarCall(cs1, 0xC268, cs2, unknown_3358_010F_3368F);
            goto label_100D_C268_1C338_5834;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5799:X4}:{targetOffset_5799:X4} at 100D:C263");
    label_100D_C268_1C338_5834:
        CheckExternalEvents(cs1, 0xC268);
        // 100D:C268 push SS
        Stack.Push16(SS);
        // 100D:C269 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        return unknown_100D_C26A_1C33A(0x0000);
    label_100D_C26B_1C33B_7660:
        CheckExternalEvents(cs1, 0xC26B);
        // 100D:C26B xchg AH,AL
        byte temp_100D_C26B_1C33B = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_C26B_1C33B);
        // 100D:C26D mov BP,AX
        BP = AX;
        // 100D:C26F shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:C271 mov BP,word ptr SS:[BP+0x2774]
        BP = UInt16[SS, (ushort)(BP + (short)10100)];
        // 100D:C275 mov AX,DI
        AX = DI;
        // 100D:C277 and AX,0x01FF
        AX = Alu16.And(AX, (ushort)0x01FF);
        // 100D:C27A push DX
        Stack.Push16(DX);
        // 100D:C27B xchg AH,AL
        byte temp_100D_C27B_1C34B = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_C27B_1C34B);
        // 100D:C27D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:C27F div BP
        ushort divisor_100D_C27F_1C34F = BP;
        uint dividend_100D_C27F_1C34F = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_C27F_1C34F = Alu16.Div(unchecked((uint)dividend_100D_C27F_1C34F), unchecked((ushort)divisor_100D_C27F_1C34F));
        AX = unchecked((ushort)quotient_100D_C27F_1C34F);
        DX = unchecked((ushort)(dividend_100D_C27F_1C34F % unchecked((uint)divisor_100D_C27F_1C34F)));
        // 100D:C281 pop DX
        DX = Stack.Pop16();
        // 100D:C282 push AX
        Stack.Push16(AX);
        // 100D:C283 mov AX,CX
        AX = CX;
        // 100D:C285 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C287 push DX
        Stack.Push16(DX);
        // 100D:C288 xchg AH,AL
        byte temp_100D_C288_1C358 = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_C288_1C358);
        // 100D:C28A xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:C28C div BP
        ushort divisor_100D_C28C_1C35C = BP;
        uint dividend_100D_C28C_1C35C = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_C28C_1C35C = Alu16.Div(unchecked((uint)dividend_100D_C28C_1C35C), unchecked((ushort)divisor_100D_C28C_1C35C));
        AX = unchecked((ushort)quotient_100D_C28C_1C35C);
        DX = unchecked((ushort)(dividend_100D_C28C_1C35C % unchecked((uint)divisor_100D_C28C_1C35C)));
        // 100D:C28E pop DX
        DX = Stack.Pop16();
        // 100D:C28F mov CL,AL
        CL = AL;
        // 100D:C291 pop AX
        AX = Stack.Pop16();
        // 100D:C292 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:C294 jns short 0xC299
        if (!SignFlag)
        {
            goto label_100D_C299_1C369_7742;
        }
    label_100D_C296_1C366_7684:
        CheckExternalEvents(cs1, 0xC296);
        // 100D:C296 call near 0xC2A1
        NearCall(cs1, 0xC299, unknown_100D_C2A1_1C371);
    label_100D_C299_1C369_7742:
        CheckExternalEvents(cs1, 0xC299);
        // 100D:C299 call far dword ptr SS:[0x3941]
        ushort targetSegment_7742 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3941 + (ushort)0x0002)]));
        ushort targetOffset_7742 = unchecked((ushort)(UInt16[SS, (ushort)0x3941]));
        if (targetSegment_7742 == cs2 && targetOffset_7742 == 0x0169)
        {
            FarCall(cs1, 0xC29E, cs2, unknown_3358_0169_336E9);
            goto label_100D_C29E_1C36E_7752;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_7742:X4}:{targetOffset_7742:X4} at 100D:C299");
    label_100D_C29E_1C36E_7752:
        CheckExternalEvents(cs1, 0xC29E);
        // 100D:C29E push SS
        Stack.Push16(SS);
        // 100D:C29F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C2A0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C2A1_1C371(int loadOffset)
    {
    label_100D_C2A1_1C371_7686:
        CheckExternalEvents(cs1, 0xC2A1);
        // 100D:C2A1 push AX
        Stack.Push16(AX);
        // 100D:C2A2 push BX
        Stack.Push16(BX);
        // 100D:C2A3 push CX
        Stack.Push16(CX);
        // 100D:C2A4 push DI
        Stack.Push16(DI);
        // 100D:C2A5 push ES
        Stack.Push16(ES);
        // 100D:C2A6 push BP
        Stack.Push16(BP);
        // 100D:C2A7 push SS
        Stack.Push16(SS);
        // 100D:C2A8 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C2A9 mov BP,DI
        BP = DI;
        // 100D:C2AB mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:C2AE and BP,0x01FF
        BP = Alu16.And(BP, (ushort)0x01FF);
        // 100D:C2B2 add BP,3
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:C2B5 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:C2B7 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:C2B9 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:C2BB mov CX,word ptr DS:[SI-2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)-2)];
        // 100D:C2BE xor CH,CH
        CH = Alu8.Xor(CH, CH);
    label_100D_C2C0_1C390_7704:
        CheckExternalEvents(cs1, 0xC2C0);
        // 100D:C2C0 push CX
        Stack.Push16(CX);
        // 100D:C2C1 mov BX,BP
        BX = BP;
    label_100D_C2C3_1C393_7706:
        CheckExternalEvents(cs1, 0xC2C3);
        // 100D:C2C3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:C2C4 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:C2C6 jne short 0xC2D6
        if (!ZeroFlag)
        {
            goto label_100D_C2D6_1C3A6_7709;
        }
    label_100D_C2C8_1C398_7718:
        CheckExternalEvents(cs1, 0xC2C8);
        // 100D:C2C8 mov CL,1
        CL = (byte)0x01;
        // 100D:C2CA add CL,AL
        CL = Alu8.Add(CL, AL);
        // 100D:C2CC xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:C2CE sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:C2D0 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:C2D2 jne short 0xC2C3
        if (!ZeroFlag)
        {
            goto label_100D_C2C3_1C393_7706;
        }
    label_100D_C2D4_1C3A4_7725:
        CheckExternalEvents(cs1, 0xC2D4);
        // 100D:C2D4 jmp short 0xC2E3
        goto label_100D_C2E3_1C3B3_7727;
    label_100D_C2D6_1C3A6_7709:
        CheckExternalEvents(cs1, 0xC2D6);
        // 100D:C2D6 mov CL,1
        CL = (byte)0x01;
        // 100D:C2D8 sub CL,AL
        CL = Alu8.Sub(CL, AL);
        // 100D:C2DA xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:C2DC sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:C2DE lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:C2DF rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:C2E1 jne short 0xC2C3
        if (!ZeroFlag)
        {
            goto label_100D_C2C3_1C393_7706;
        }
    label_100D_C2E3_1C3B3_7727:
        CheckExternalEvents(cs1, 0xC2E3);
        // 100D:C2E3 pop CX
        CX = Stack.Pop16();
        // 100D:C2E4 loop 0xC2C0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_C2C0_1C390_7704;
        }
    label_100D_C2E6_1C3B6_7731:
        CheckExternalEvents(cs1, 0xC2E6);
        // 100D:C2E6 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:C2E9 push SS
        Stack.Push16(SS);
        // 100D:C2EA pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C2EB pop BP
        BP = Stack.Pop16();
        // 100D:C2EC pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C2ED pop DI
        DI = Stack.Pop16();
        // 100D:C2EE pop CX
        CX = Stack.Pop16();
        // 100D:C2EF pop BX
        BX = Stack.Pop16();
        // 100D:C2F0 pop AX
        AX = Stack.Pop16();
        // 100D:C2F1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action open_resource_and_draw_sprite0(int loadOffset)
    {
    label_100D_C2F2_1C3C2_9562:
        CheckExternalEvents(cs1, 0xC2F2);
        // 100D:C2F2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C2F4 call near 0xC13E
        NearCall(cs1, 0xC2F7, open_sprite_bank);
    label_100D_C2F7_1C3C7_9565:
        CheckExternalEvents(cs1, 0xC2F7);
        // 100D:C2F7 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:C2F9 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:C2FB xor DX,DX
        DX = Alu16.Xor(DX, DX);
        return unknown_100D_C2FD_1C3CD(0x0000);
    }

    public virtual Action unknown_100D_C2FD_1C3CD(int loadOffset)
    {
    label_100D_C2FD_1C3CD_7807:
        CheckExternalEvents(cs1, 0xC2FD);
        // 100D:C2FD push BX
        Stack.Push16(BX);
        // 100D:C2FE push DX
        Stack.Push16(DX);
        // 100D:C2FF call near 0xC22F
        NearCall(cs1, 0xC302, draw_active_bank_sprite);
    label_100D_C302_1C3D2_7811:
        CheckExternalEvents(cs1, 0xC302);
        // 100D:C302 pop DX
        DX = Stack.Pop16();
        // 100D:C303 pop BX
        BX = Stack.Pop16();
        // 100D:C304 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_sprite_from_sheet_clipped(int loadOffset)
    {
    label_100D_C305_1C3D5_10184:
        CheckExternalEvents(cs1, 0xC305);
        // 100D:C305 push BX
        Stack.Push16(BX);
        // 100D:C306 push DX
        Stack.Push16(DX);
        // 100D:C307 call near 0xC30D
        NearCall(cs1, 0xC30A, unknown_100D_C30D_1C3DD);
    label_100D_C30A_1C3DA_10188:
        CheckExternalEvents(cs1, 0xC30A);
        // 100D:C30A pop DX
        DX = Stack.Pop16();
        // 100D:C30B pop BX
        BX = Stack.Pop16();
        // 100D:C30C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C30D_1C3DD(int loadOffset)
    {
    label_100D_C30D_1C3DD_10080:
        CheckExternalEvents(cs1, 0xC30D);
        // 100D:C30D mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C311 lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_C311_1C3E1 = (ushort)0xDBB0;
        ushort lxsValue_100D_C311_1C3E1 = UInt16[DS, lxsOffset_100D_C311_1C3E1];
        ushort lxsSegment_100D_C311_1C3E1 = UInt16[DS, (ushort)(lxsOffset_100D_C311_1C3E1 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C311_1C3E1);
        DS = unchecked((ushort)lxsSegment_100D_C311_1C3E1);
        // 100D:C315 mov BP,AX
        BP = AX;
        // 100D:C317 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:C319 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:C31C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C31D mov DI,AX
        DI = AX;
        // 100D:C31F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C320 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C322 mov CX,AX
        CX = AX;
        // 100D:C324 mov BP,0xD834
        BP = (ushort)0xD834;
        // 100D:C327 call far dword ptr SS:[0x38CD]
        ushort targetSegment_10092 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_10092 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_10092 == cs2 && targetOffset_10092 == 0x0112)
        {
            FarCall(cs1, 0xC32C, cs2, unknown_3358_0112_33692);
            goto label_100D_C32C_1C3FC_10109;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10092:X4}:{targetOffset_10092:X4} at 100D:C327");
    label_100D_C32C_1C3FC_10109:
        CheckExternalEvents(cs1, 0xC32C);
        // 100D:C32C push SS
        Stack.Push16(SS);
        // 100D:C32D pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        return unknown_100D_C32E_1C3FE(0x0000);
    }

    public virtual Action draw_sprite_list_clipped_to_game_area(int loadOffset)
    {
    label_100D_C32F_1C3FF_10068:
        CheckExternalEvents(cs1, 0xC32F);
        // 100D:C32F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C330 cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:C333 je short 0xC32E
        if (ZeroFlag)
        {
            return unknown_100D_C32E_1C3FE(0x0000);
        }
    label_100D_C335_1C405_10072:
        CheckExternalEvents(cs1, 0xC335);
        // 100D:C335 mov BX,AX
        BX = AX;
        // 100D:C337 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C338 mov DX,AX
        DX = AX;
        // 100D:C33A lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C33B xchg BX,AX
        ushort temp_100D_C33B_1C40B = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_C33B_1C40B);
        // 100D:C33C push SI
        Stack.Push16(SI);
        // 100D:C33D call near 0xC30D
        NearCall(cs1, 0xC340, unknown_100D_C30D_1C3DD);
    label_100D_C340_1C410_10113:
        CheckExternalEvents(cs1, 0xC340);
        // 100D:C340 pop SI
        SI = Stack.Pop16();
        // 100D:C341 jmp short 0xC32F
        goto label_100D_C32F_1C3FF_10068;
    }

    public virtual Action draw_sprite_centered_clipped(int loadOffset)
    {
    label_100D_C343_1C413_11658:
        CheckExternalEvents(cs1, 0xC343);
        // 100D:C343 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C347 lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_C347_1C417 = (ushort)0xDBB0;
        ushort lxsValue_100D_C347_1C417 = UInt16[DS, lxsOffset_100D_C347_1C417];
        ushort lxsSegment_100D_C347_1C417 = UInt16[DS, (ushort)(lxsOffset_100D_C347_1C417 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C347_1C417);
        DS = unchecked((ushort)lxsSegment_100D_C347_1C417);
        // 100D:C34B mov BP,AX
        BP = AX;
        // 100D:C34D shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:C34F add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:C352 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C353 mov DI,AX
        DI = AX;
        // 100D:C355 and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:C358 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:C35A sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:C35C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C35D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C35F mov CX,AX
        CX = AX;
        // 100D:C361 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:C363 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:C365 mov BP,0xD834
        BP = (ushort)0xD834;
        // 100D:C368 call far dword ptr SS:[0x38CD]
        ushort targetSegment_11675 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_11675 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_11675 == cs2 && targetOffset_11675 == 0x0112)
        {
            FarCall(cs1, 0xC36D, cs2, unknown_3358_0112_33692);
            goto label_100D_C36D_1C43D_11676;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11675:X4}:{targetOffset_11675:X4} at 100D:C368");
    label_100D_C36D_1C43D_11676:
        CheckExternalEvents(cs1, 0xC36D);
        // 100D:C36D push SS
        Stack.Push16(SS);
        // 100D:C36E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C36F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action blit_repeated_x(int loadOffset)
    {
    label_100D_C370_1C440_10219:
        CheckExternalEvents(cs1, 0xC370);
        // 100D:C370 push DS
        Stack.Push16(DS);
        // 100D:C371 push DS
        Stack.Push16(DS);
        // 100D:C372 push AX
        Stack.Push16(AX);
        // 100D:C373 push SI
        Stack.Push16(SI);
        // 100D:C374 call far dword ptr DS:[0x38D9]
        ushort targetSegment_10224 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D9 + (ushort)0x0002)]));
        ushort targetOffset_10224 = unchecked((ushort)(UInt16[DS, (ushort)0x38D9]));
        if (targetSegment_10224 == cs2 && targetOffset_10224 == 0x011B)
        {
            FarCall(cs1, 0xC378, cs2, unknown_3358_011B_3369B);
            goto label_100D_C378_1C448_10225;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10224:X4}:{targetOffset_10224:X4} at 100D:C374");
    label_100D_C378_1C448_10225:
        CheckExternalEvents(cs1, 0xC378);
        // 100D:C378 pop SI
        SI = Stack.Pop16();
        // 100D:C379 pop AX
        AX = Stack.Pop16();
        // 100D:C37A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C37B mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C37D push DX
        Stack.Push16(DX);
        // 100D:C37E mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C381 push BX
        Stack.Push16(BX);
        // 100D:C382 mov CX,word ptr DS:[SI+4]
        CX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C385 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 100D:C387 push CX
        Stack.Push16(CX);
        // 100D:C388 mov CX,word ptr DS:[SI+6]
        CX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C38B sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 100D:C38D push CX
        Stack.Push16(CX);
        // 100D:C38E lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_C38E_1C45E = (ushort)0xDBB0;
        ushort lxsValue_100D_C38E_1C45E = UInt16[DS, lxsOffset_100D_C38E_1C45E];
        ushort lxsSegment_100D_C38E_1C45E = UInt16[DS, (ushort)(lxsOffset_100D_C38E_1C45E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C38E_1C45E);
        DS = unchecked((ushort)lxsSegment_100D_C38E_1C45E);
        // 100D:C392 mov BP,AX
        BP = AX;
        // 100D:C394 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:C396 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:C399 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C39A mov DI,AX
        DI = AX;
        // 100D:C39C and AX,0x01FF
        AX = Alu16.And(AX, (ushort)0x01FF);
        // 100D:C39F push AX
        Stack.Push16(AX);
        // 100D:C3A0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C3A1 mov CX,AX
        CX = AX;
        // 100D:C3A3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C3A5 push AX
        Stack.Push16(AX);
        // 100D:C3A6 call far dword ptr SS:[0x38C9]
        ushort targetSegment_10251 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38C9 + (ushort)0x0002)]));
        ushort targetOffset_10251 = unchecked((ushort)(UInt16[SS, (ushort)0x38C9]));
        if (targetSegment_10251 == cs2 && targetOffset_10251 == 0x010F)
        {
            FarCall(cs1, 0xC3AB, cs2, unknown_3358_010F_3368F);
            goto label_100D_C3AB_1C47B_10252;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10251:X4}:{targetOffset_10251:X4} at 100D:C3A6");
    label_100D_C3AB_1C47B_10252:
        CheckExternalEvents(cs1, 0xC3AB);
        // 100D:C3AB push ES
        Stack.Push16(ES);
        // 100D:C3AC pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C3AD mov BP,SP
        BP = SP;
        // 100D:C3AF mov DX,word ptr SS:[BP+0x0A]
        DX = UInt16[SS, (ushort)(BP + (sbyte)10)];
        // 100D:C3B2 mov BX,word ptr SS:[BP+8]
        BX = UInt16[SS, (ushort)(BP + (sbyte)8)];
        // 100D:C3B5 push BX
        Stack.Push16(BX);
        // 100D:C3B6 push DX
        Stack.Push16(DX);
        // 100D:C3B7 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 100D:C3BA push word ptr SS:[BP+2]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)2)]);
        // 100D:C3BD push BX
        Stack.Push16(BX);
        // 100D:C3BE push DX
        Stack.Push16(DX);
        // 100D:C3BF mov BP,SP
        BP = SP;
        // 100D:C3C1 mov DX,word ptr SS:[BP+0x12]
        DX = UInt16[SS, (ushort)(BP + (sbyte)18)];
        // 100D:C3C4 sub DX,word ptr SS:[BP+4]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)4)]);
    label_100D_C3C7_1C497_10267:
        CheckExternalEvents(cs1, 0xC3C7);
        // 100D:C3C7 mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:C3CA add word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)8)], AX);
        // 100D:C3CD sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:C3CF jae short 0xC3D4
        if (!CarryFlag)
        {
            goto label_100D_C3D4_1C4A4_10271;
        }
    label_100D_C3D1_1C4A1_16694:
        CheckExternalEvents(cs1, 0xC3D1);
        // 100D:C3D1 add word ptr SS:[BP+4],DX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)4)], DX);
    label_100D_C3D4_1C4A4_10271:
        CheckExternalEvents(cs1, 0xC3D4);
        // 100D:C3D4 push DX
        Stack.Push16(DX);
        // 100D:C3D5 call far dword ptr SS:[0x3931]
        ushort targetSegment_10273 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3931 + (ushort)0x0002)]));
        ushort targetOffset_10273 = unchecked((ushort)(UInt16[SS, (ushort)0x3931]));
        if (targetSegment_10273 == cs2 && targetOffset_10273 == 0x015D)
        {
            FarCall(cs1, 0xC3DA, cs2, unknown_3358_015D_336DD);
            goto label_100D_C3DA_1C4AA_10299;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10273:X4}:{targetOffset_10273:X4} at 100D:C3D5");
    label_100D_C3DA_1C4AA_10299:
        CheckExternalEvents(cs1, 0xC3DA);
        // 100D:C3DA pop DX
        DX = Stack.Pop16();
        // 100D:C3DB cmp DX,0
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:C3DE jg short 0xC3C7
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_C3C7_1C497_10267;
        }
    label_100D_C3E0_1C4B0_10304:
        CheckExternalEvents(cs1, 0xC3E0);
        // 100D:C3E0 mov AX,word ptr SS:[BP+0x12]
        AX = UInt16[SS, (ushort)(BP + (sbyte)18)];
        // 100D:C3E3 mov word ptr SS:[BP+4],AX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = AX;
        // 100D:C3E6 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:C3E9 mov word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = AX;
        // 100D:C3EC mov BX,word ptr SS:[BP+0x10]
        BX = UInt16[SS, (ushort)(BP + (sbyte)16)];
        // 100D:C3EF sub BX,word ptr SS:[BP+6]
        BX = Alu16.Sub(BX, UInt16[SS, (ushort)(BP + (sbyte)6)]);
        // 100D:C3F2 je short 0xC40D
        if (ZeroFlag)
        {
            goto label_100D_C40D_1C4DD_10312;
        }
    label_100D_C3F4_1C4C4_16696:
        CheckExternalEvents(cs1, 0xC3F4);
        // 100D:C3F4 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:C3F7 add word ptr SS:[BP+0x0A],AX
        UInt16[SS, (ushort)(BP + (sbyte)10)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)10)], AX);
        // 100D:C3FA sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:C3FC jae short 0xC401
        if (!CarryFlag)
        {
            goto label_100D_C401_1C4D1_16701;
        }
    label_100D_C3FE_1C4CE_16708:
        CheckExternalEvents(cs1, 0xC3FE);
        // 100D:C3FE add word ptr SS:[BP+6],BX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)6)], BX);
    label_100D_C401_1C4D1_16701:
        CheckExternalEvents(cs1, 0xC401);
        // 100D:C401 push BX
        Stack.Push16(BX);
        // 100D:C402 call far dword ptr SS:[0x3931]
        ushort targetSegment_16703 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3931 + (ushort)0x0002)]));
        ushort targetOffset_16703 = unchecked((ushort)(UInt16[SS, (ushort)0x3931]));
        if (targetSegment_16703 == cs2 && targetOffset_16703 == 0x015D)
        {
            FarCall(cs1, 0xC407, cs2, unknown_3358_015D_336DD);
            goto label_100D_C407_1C4D7_16704;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_16703:X4}:{targetOffset_16703:X4} at 100D:C402");
    label_100D_C407_1C4D7_16704:
        CheckExternalEvents(cs1, 0xC407);
        // 100D:C407 pop BX
        BX = Stack.Pop16();
        // 100D:C408 cmp BX,0
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:C40B jg short 0xC3F4
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_C3F4_1C4C4_16696;
        }
    label_100D_C40D_1C4DD_10312:
        CheckExternalEvents(cs1, 0xC40D);
        // 100D:C40D add SP,0x0018
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)24)));
        // 100D:C410 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C411 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action copy_active_framebuffer_to_framebuffer_2(int loadOffset)
    {
    label_100D_C412_1C4E2_2730:
        CheckExternalEvents(cs1, 0xC412);
        // 100D:C412 push DS
        Stack.Push16(DS);
        // 100D:C413 mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:C417 mov DS,word ptr DS:[0xDBDA]
        DS = UInt16[DS, (ushort)0xDBDA];
        // 100D:C41B call far dword ptr SS:[0x38E1]
        ushort targetSegment_2734 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38E1 + (ushort)0x0002)]));
        ushort targetOffset_2734 = unchecked((ushort)(UInt16[SS, (ushort)0x38E1]));
        if (targetSegment_2734 == cs2 && targetOffset_2734 == 0x0121)
        {
            FarCall(cs1, 0xC420, cs2, unknown_3358_0121_336A1);
            goto label_100D_C420_1C4F0_2749;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_2734:X4}:{targetOffset_2734:X4} at 100D:C41B");
    label_100D_C420_1C4F0_2749:
        CheckExternalEvents(cs1, 0xC420);
        // 100D:C420 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C421 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action clear_game_area(int loadOffset)
    {
    label_100D_C432_1C502_6674:
        CheckExternalEvents(cs1, 0xC432);
        // 100D:C432 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:C435 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C439 call far dword ptr DS:[0x38D9]
        ushort targetSegment_6677 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D9 + (ushort)0x0002)]));
        ushort targetOffset_6677 = unchecked((ushort)(UInt16[DS, (ushort)0x38D9]));
        if (targetSegment_6677 == cs2 && targetOffset_6677 == 0x011B)
        {
            FarCall(cs1, 0xC43D, cs2, unknown_3358_011B_3369B);
            goto label_100D_C43D_1C50D_6715;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_6677:X4}:{targetOffset_6677:X4} at 100D:C439");
    label_100D_C43D_1C50D_6715:
        CheckExternalEvents(cs1, 0xC43D);
        // 100D:C43D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action copy_game_area_fb2_to_fb1(int loadOffset)
    {
    label_100D_C43E_1C50E_10176:
        CheckExternalEvents(cs1, 0xC43E);
        // 100D:C43E mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:C441 jmp short 0xC446
        return unknown_100D_C446_1C516(0x0000);
    }

    public virtual Action unknown_100D_C443_1C513(int loadOffset)
    {
    label_100D_C443_1C513_10622:
        CheckExternalEvents(cs1, 0xC443);
        // 100D:C443 mov SI,0xD834
        SI = (ushort)0xD834;
        return unknown_100D_C446_1C516(0x0000);
    }

    public virtual Action unknown_100D_C446_1C516(int loadOffset)
    {
    label_100D_C446_1C516_8072:
        CheckExternalEvents(cs1, 0xC446);
        // 100D:C446 mov AX,word ptr DS:[0xDBDE]
        AX = UInt16[DS, (ushort)0xDBDE];
        return unknown_100D_C449_1C519(0x0000);
    }

    public virtual Action unknown_100D_C46F_1C53F(int loadOffset)
    {
    label_100D_C46F_1C53F_22038:
        CheckExternalEvents(cs1, 0xC46F);
        // 100D:C46F mov AX,word ptr DS:[0xDC32]
        AX = UInt16[DS, (ushort)0xDC32];
        // 100D:C472 jmp short 0xC449
        return unknown_100D_C449_1C519(0x0000);
    }

    public virtual Action unknown_100D_C474_1C544(int loadOffset)
    {
    label_100D_C474_1C544_19231:
        CheckExternalEvents(cs1, 0xC474);
        // 100D:C474 mov SI,0x1470
        SI = (ushort)0x1470;
        return unknown_100D_C477_1C547(0x0000);
    }

    public virtual Action unknown_100D_C477_1C547(int loadOffset)
    {
    label_100D_C477_1C547_15740:
        CheckExternalEvents(cs1, 0xC477);
        // 100D:C477 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C479 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C47C mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C47F mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C482 sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:C484 jbe short 0xC499
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C499_1C569_15747;
        }
    label_100D_C486_1C556_19233:
        CheckExternalEvents(cs1, 0xC486);
        // 100D:C486 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C488 jbe short 0xC499
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C499_1C569_15747;
        }
    label_100D_C48A_1C55A_19236:
        CheckExternalEvents(cs1, 0xC48A);
        // 100D:C48A mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:C48E push DS
        Stack.Push16(DS);
        // 100D:C48F mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C493 call far dword ptr SS:[0x38E5]
        ushort targetSegment_19240 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38E5 + (ushort)0x0002)]));
        ushort targetOffset_19240 = unchecked((ushort)(UInt16[SS, (ushort)0x38E5]));
        if (targetSegment_19240 == cs2 && targetOffset_19240 == 0x0124)
        {
            FarCall(cs1, 0xC498, cs2, unknown_3358_0124_336A4);
            goto label_100D_C498_1C568_19243;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_19240:X4}:{targetOffset_19240:X4} at 100D:C493");
    label_100D_C498_1C568_19243:
        CheckExternalEvents(cs1, 0xC498);
        // 100D:C498 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_C499_1C569_15747:
        CheckExternalEvents(cs1, 0xC499);
        // 100D:C499 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C49A_1C56A(int loadOffset)
    {
    label_100D_C49A_1C56A_31828:
        CheckExternalEvents(cs1, 0xC49A);
        // 100D:C49A push DS
        Stack.Push16(DS);
        // 100D:C49B mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:C49F mov DS,word ptr DS:[0xDBD8]
        DS = UInt16[DS, (ushort)0xDBD8];
        // 100D:C4A3 call far dword ptr SS:[0x38F1]
        ushort targetSegment_31832 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38F1 + (ushort)0x0002)]));
        ushort targetOffset_31832 = unchecked((ushort)(UInt16[SS, (ushort)0x38F1]));
        if (targetSegment_31832 == cs2 && targetOffset_31832 == 0x012D)
        {
            FarCall(cs1, 0xC4A8, cs2, unknown_3358_012D_336AD);
            goto label_100D_C4A8_1C578_31833;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_31832:X4}:{targetOffset_31832:X4} at 100D:C4A3");
    label_100D_C4A8_1C578_31833:
        CheckExternalEvents(cs1, 0xC4A8);
        // 100D:C4A8 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C4A9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C4AA_1C57A(int loadOffset)
    {
    label_100D_C4AA_1C57A_15025:
        CheckExternalEvents(cs1, 0xC4AA);
        // 100D:C4AA mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C4AC mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C4AF mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C4B2 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C4B5 sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:C4B7 jbe short 0xC4CC
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C4B7");
        }
    label_100D_C4B9_1C589_15032:
        CheckExternalEvents(cs1, 0xC4B9);
        // 100D:C4B9 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C4BB jbe short 0xC4CC
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C4BB");
        }
    label_100D_C4BD_1C58D_15035:
        CheckExternalEvents(cs1, 0xC4BD);
        // 100D:C4BD push DS
        Stack.Push16(DS);
        // 100D:C4BE mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:C4C2 mov DS,word ptr DS:[0xDBD8]
        DS = UInt16[DS, (ushort)0xDBD8];
        // 100D:C4C6 call far dword ptr SS:[0x38F5]
        ushort targetSegment_15039 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38F5 + (ushort)0x0002)]));
        ushort targetOffset_15039 = unchecked((ushort)(UInt16[SS, (ushort)0x38F5]));
        if (targetSegment_15039 == cs2 && targetOffset_15039 == 0x0130)
        {
            FarCall(cs1, 0xC4CB, cs2, unknown_3358_0130_336B0);
            goto label_100D_C4CB_1C59B_15040;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_15039:X4}:{targetOffset_15039:X4} at 100D:C4C6");
    label_100D_C4CB_1C59B_15040:
        CheckExternalEvents(cs1, 0xC4CB);
        // 100D:C4CB pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C4CC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action gfx_copy_whole_framebuf_to_screen(int loadOffset)
    {
    label_100D_C4CD_1C59D_4660:
        CheckExternalEvents(cs1, 0xC4CD);
        // 100D:C4CD push DS
        Stack.Push16(DS);
        // 100D:C4CE mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C4D2 mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C4D6 call far dword ptr SS:[0x38F1]
        ushort targetSegment_4664 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38F1 + (ushort)0x0002)]));
        ushort targetOffset_4664 = unchecked((ushort)(UInt16[SS, (ushort)0x38F1]));
        if (targetSegment_4664 == cs2 && targetOffset_4664 == 0x012D)
        {
            FarCall(cs1, 0xC4DB, cs2, unknown_3358_012D_336AD);
            goto label_100D_C4DB_1C5AB_4667;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_4664:X4}:{targetOffset_4664:X4} at 100D:C4D6");
    label_100D_C4DB_1C5AB_4667:
        CheckExternalEvents(cs1, 0xC4DB);
        // 100D:C4DB pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C4DC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action present_game_area(int loadOffset)
    {
    label_100D_C4DD_1C5AD_8255:
        CheckExternalEvents(cs1, 0xC4DD);
        // 100D:C4DD mov AX,word ptr DS:[0xDC38]
        AX = UInt16[DS, (ushort)0xDC38];
        // 100D:C4E0 cmp AX,0x0098
        Alu16.Sub(AX, (ushort)0x0098);
        // 100D:C4E3 jae short 0xC4E8
        if (!CarryFlag)
        {
            goto label_100D_C4E8_1C5B8_8259;
        }
    label_100D_C4E5_1C5B5_21562:
        CheckExternalEvents(cs1, 0xC4E5);
        // 100D:C4E5 call near 0xDBB2
        NearCall(cs1, 0xC4E8, call_restore_cursor);
    label_100D_C4E8_1C5B8_8259:
        CheckExternalEvents(cs1, 0xC4E8);
        // 100D:C4E8 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:C4EB jmp short 0xC4F0
        return present_screen_rect(0x0000);
    }

    public virtual Action unknown_100D_C4ED_1C5BD(int loadOffset)
    {
    label_100D_C4ED_1C5BD_12748:
        CheckExternalEvents(cs1, 0xC4ED);
        // 100D:C4ED mov SI,0xD834
        SI = (ushort)0xD834;
        return present_screen_rect(0x0000);
    }
}
