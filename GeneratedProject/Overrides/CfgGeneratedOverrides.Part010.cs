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
    public virtual Action map_view_refresh_after_events(int loadOffset)
    {
    label_100D_5D6D_15E3D_35970:
        CheckExternalEvents(cs1, 0x5D6D);
        // 100D:5D6D mov byte ptr DS:[0x46EC],0
        UInt8[DS, (ushort)0x46EC] = (byte)0x00;
        // 100D:5D72 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:5D77 js short 0x5D82
        if (SignFlag)
        {
            goto label_100D_5D82_15E52_37039;
        }
    label_100D_5D79_15E49_35974:
        CheckExternalEvents(cs1, 0x5D79);
        // 100D:5D79 je short 0x5DCD
        if (ZeroFlag)
        {
            goto label_100D_5DCD_15E9D_35976;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5D79");
        }
    label_100D_5D82_15E52_37039:
        CheckExternalEvents(cs1, 0x5D82);
        // 100D:5D82 call near 0xC07C
        NearCall(cs1, 0x5D85, set_fb1_as_active_framebuffer);
    label_100D_5D85_15E55_37042:
        CheckExternalEvents(cs1, 0x5D85);
        // 100D:5D85 call near 0xDBB2
        NearCall(cs1, 0x5D88, call_restore_cursor);
    label_100D_5D88_15E58_37045:
        CheckExternalEvents(cs1, 0x5D88);
        // 100D:5D88 call near 0x5B8D
        NearCall(cs1, 0x5D8B, unknown_100D_5B8D_15C5D);
    label_100D_5D8B_15E5B_37048:
        CheckExternalEvents(cs1, 0x5D8B);
        // 100D:5D8B mov AL,0x80
        AL = (byte)0x80;
        // 100D:5D8D xchg AL,byte ptr DS:[0x46EB]
        ushort xchgOffset_100D_5D8D_15E5D = (ushort)0x46EB;
        byte temp_100D_5D8D_15E5D = AL;
        AL = UInt8[DS, xchgOffset_100D_5D8D_15E5D];
        UInt8[DS, xchgOffset_100D_5D8D_15E5D] = unchecked((byte)temp_100D_5D8D_15E5D);
        // 100D:5D91 push AX
        Stack.Push16(AX);
        // 100D:5D92 push word ptr DS:[0x46EF]
        Stack.Push16(UInt16[DS, (ushort)0x46EF]);
        // 100D:5D96 call near 0xB6C3
        NearCall(cs1, 0x5D99, map_draw_zoomed_globe);
    label_100D_5D99_15E69_37059:
        CheckExternalEvents(cs1, 0x5D99);
        // 100D:5D99 call near 0xC13B
        NearCall(cs1, 0x5D9C, open_onmap_spritesheet);
    label_100D_5D9C_15E6C_37062:
        CheckExternalEvents(cs1, 0x5D9C);
        // 100D:5D9C call near 0x5DCE
        NearCall(cs1, 0x5D9F, map_build_and_draw_location_markers);
    label_100D_5D9F_15E6F_37065:
        CheckExternalEvents(cs1, 0x5D9F);
        // 100D:5D9F call near 0x6314
        NearCall(cs1, 0x5DA2, map_draw_player_position_sprite);
    label_100D_5DA2_15E72_37068:
        CheckExternalEvents(cs1, 0x5DA2);
        // 100D:5DA2 call near 0xC412
        NearCall(cs1, 0x5DA5, copy_active_framebuffer_to_framebuffer_2);
    label_100D_5DA5_15E75_37071:
        CheckExternalEvents(cs1, 0x5DA5);
        // 100D:5DA5 mov word ptr DS:[0x3CBE],0
        UInt16[DS, (ushort)0x3CBE] = (ushort)0x0000;
        // 100D:5DAB call near 0x6715
        NearCall(cs1, 0x5DAE, map_spawn_troop_icons);
    label_100D_5DAE_15E7E_37076:
        CheckExternalEvents(cs1, 0x5DAE);
        // 100D:5DAE mov SI,0x46E3
        SI = (ushort)0x46E3;
        // 100D:5DB1 call near 0xC6AD
        NearCall(cs1, 0x5DB4, troop_icons_update_dirty_rect);
    label_100D_5DB4_15E84_37081:
        CheckExternalEvents(cs1, 0x5DB4);
        // 100D:5DB4 pop SI
        SI = Stack.Pop16();
        // 100D:5DB5 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:5DB7 je short 0x5DBC
        if (ZeroFlag)
        {
            goto label_100D_5DBC_15E8C_37085;
        }
    label_100D_5DB9_15E89_37087:
        CheckExternalEvents(cs1, 0x5DB9);
        // 100D:5DB9 call near 0x697C
        NearCall(cs1, 0x5DBC, map_focus_troop_icon);
    label_100D_5DBC_15E8C_37085:
        CheckExternalEvents(cs1, 0x5DBC);
        // 100D:5DBC call near 0x1C18
        NearCall(cs1, 0x5DBF, redraw_period_sensitive_view_content);
    label_100D_5DBF_15E8F_37094:
        CheckExternalEvents(cs1, 0x5DBF);
        // 100D:5DBF pop AX
        AX = Stack.Pop16();
        // 100D:5DC0 mov byte ptr DS:[0x46EB],AL
        UInt8[DS, (ushort)0x46EB] = AL;
        // 100D:5DC3 and AL,0x40
        AL = Alu8.And(AL, (byte)0x40);
        // 100D:5DC5 je short 0x5DCA
        if (ZeroFlag)
        {
            goto label_100D_5DCA_15E9A_37099;
        }
    label_100D_5DC7_15E97_37101:
        CheckExternalEvents(cs1, 0x5DC7);
        // 100D:5DC7 call near 0x542F
        NearCall(cs1, 0x5DCA, map_draw_spice_density_overlay);
    label_100D_5DCA_15E9A_37099:
        CheckExternalEvents(cs1, 0x5DCA);
        // 100D:5DCA jmp near 0xC13B
        return open_onmap_spritesheet(0x0000);
    label_100D_5DCD_15E9D_35976:
        CheckExternalEvents(cs1, 0x5DCD);
        // 100D:5DCD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_build_and_draw_location_markers(int loadOffset)
    {
    label_100D_5DCE_15E9E_17952:
        CheckExternalEvents(cs1, 0x5DCE);
        // 100D:5DCE mov AL,byte ptr DS:[0x46EB]
        AL = UInt8[DS, (ushort)0x46EB];
        // 100D:5DD1 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:5DD3 jns short 0x5DDA
        if (!SignFlag)
        {
            goto label_100D_5DDA_15EAA_18093;
        }
    label_100D_5DD5_15EA5_17956:
        CheckExternalEvents(cs1, 0x5DD5);
        // 100D:5DD5 push AX
        Stack.Push16(AX);
        // 100D:5DD6 call near 0x633B
        NearCall(cs1, 0x5DD9, map_draw_vegetation_marks);
    label_100D_5DD9_15EA9_18091:
        CheckExternalEvents(cs1, 0x5DD9);
        // 100D:5DD9 pop AX
        AX = Stack.Pop16();
    label_100D_5DDA_15EAA_18093:
        CheckExternalEvents(cs1, 0x5DDA);
        // 100D:5DDA mov DI,0xA5C0
        DI = (ushort)0xA5C0;
        // 100D:5DDD and AL,0x40
        AL = Alu8.And(AL, (byte)0x40);
        // 100D:5DDF je short 0x5DF1
        if (ZeroFlag)
        {
            goto label_100D_5DF1_15EC1_18096;
        }
    label_100D_5DE1_15EB1_28673:
        CheckExternalEvents(cs1, 0x5DE1);
        // 100D:5DE1 sub DI,6
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_100D_5DE4_15EB4_28675:
        CheckExternalEvents(cs1, 0x5DE4);
        // 100D:5DE4 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:5DE7 cmp word ptr DS:[DI],0
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:5DEA je short 0x5DF1
        if (ZeroFlag)
        {
            goto label_100D_5DF1_15EC1_18096;
        }
    label_100D_5DEC_15EBC_28678:
        CheckExternalEvents(cs1, 0x5DEC);
        // 100D:5DEC and byte ptr DS:[DI+5],AL
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)5)], AL);
        // 100D:5DEF je short 0x5DE4
        if (ZeroFlag)
        {
            goto label_100D_5DE4_15EB4_28675;
        }
    label_100D_5DF1_15EC1_18096:
        CheckExternalEvents(cs1, 0x5DF1);
        // 100D:5DF1 mov SI,0x0100
        SI = (ushort)0x0100;
    label_100D_5DF4_15EC4_18098:
        CheckExternalEvents(cs1, 0x5DF4);
        // 100D:5DF4 cmp word ptr DS:[SI],-1
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:5DF7 je short 0x5E3D
        if (ZeroFlag)
        {
            goto label_100D_5E3D_15F0D_18184;
        }
    label_100D_5DF9_15EC9_18100:
        CheckExternalEvents(cs1, 0x5DF9);
        // 100D:5DF9 test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:5DFD jne short 0x5E38
        if (!ZeroFlag)
        {
            goto label_100D_5E38_15F08_18137;
        }
    label_100D_5DFF_15ECF_18103:
        CheckExternalEvents(cs1, 0x5DFF);
        // 100D:5DFF call near 0x62C9
        NearCall(cs1, 0x5E02, location_visible_on_map);
    label_100D_5E02_15ED2_18111:
        CheckExternalEvents(cs1, 0x5E02);
        // 100D:5E02 jb short 0x5E38
        if (CarryFlag)
        {
            goto label_100D_5E38_15F08_18137;
        }
    label_100D_5E04_15ED4_18113:
        CheckExternalEvents(cs1, 0x5E04);
        // 100D:5E04 mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 100D:5E06 mov word ptr DS:[DI+2],DX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = DX;
        // 100D:5E09 mov BH,byte ptr DS:[0x46EB]
        BH = UInt8[DS, (ushort)0x46EB];
        // 100D:5E0D mov word ptr DS:[DI+4],BX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = BX;
        // 100D:5E10 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:5E12 call near 0x5E42
        NearCall(cs1, 0x5E15, calc_location_marker_sprite);
    label_100D_5E15_15EE5_18126:
        CheckExternalEvents(cs1, 0x5E15);
        // 100D:5E15 cmp CL,0x20
        Alu8.Sub(CL, (byte)0x20);
        // 100D:5E18 jae short 0x5E2E
        if (!CarryFlag)
        {
            goto label_100D_5E2E_15EFE_18129;
        }
    label_100D_5E1A_15EEA_18141:
        CheckExternalEvents(cs1, 0x5E1A);
        // 100D:5E1A push AX
        Stack.Push16(AX);
        // 100D:5E1B push BX
        Stack.Push16(BX);
        // 100D:5E1C push DX
        Stack.Push16(DX);
        // 100D:5E1D push SI
        Stack.Push16(SI);
        // 100D:5E1E call near 0x7C8F
        NearCall(cs1, 0x5E21, location_distance_from_player);
    label_100D_5E21_15EF1_18171:
        CheckExternalEvents(cs1, 0x5E21);
        // 100D:5E21 cmp AX,word ptr DS:[0x1176]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x1176]);
        // 100D:5E25 pop SI
        SI = Stack.Pop16();
        // 100D:5E26 pop DX
        DX = Stack.Pop16();
        // 100D:5E27 pop BX
        BX = Stack.Pop16();
        // 100D:5E28 pop AX
        AX = Stack.Pop16();
        // 100D:5E29 jbe short 0x5E2E
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_5E2E_15EFE_18129;
        }
    label_100D_5E2B_15EFB_18178:
        CheckExternalEvents(cs1, 0x5E2B);
        // 100D:5E2B add AX,5
        AX = Alu16.Add(AX, (ushort)0x0005);
    label_100D_5E2E_15EFE_18129:
        CheckExternalEvents(cs1, 0x5E2E);
        // 100D:5E2E push SI
        Stack.Push16(SI);
        // 100D:5E2F push DI
        Stack.Push16(DI);
        // 100D:5E30 call near 0xC343
        NearCall(cs1, 0x5E33, draw_sprite_centered_clipped);
    label_100D_5E33_15F03_18133:
        CheckExternalEvents(cs1, 0x5E33);
        // 100D:5E33 pop DI
        DI = Stack.Pop16();
        // 100D:5E34 pop SI
        SI = Stack.Pop16();
        // 100D:5E35 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_100D_5E38_15F08_18137:
        CheckExternalEvents(cs1, 0x5E38);
        // 100D:5E38 add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:5E3B jmp short 0x5DF4
        goto label_100D_5DF4_15EC4_18098;
    label_100D_5E3D_15F0D_18184:
        CheckExternalEvents(cs1, 0x5E3D);
        // 100D:5E3D mov word ptr DS:[DI],0
        UInt16[DS, DI] = (ushort)0x0000;
        // 100D:5E41 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action calc_location_marker_sprite(int loadOffset)
    {
    label_100D_5E42_15F12_18120:
        CheckExternalEvents(cs1, 0x5E42);
        // 100D:5E42 mov AX,0x003A
        AX = (ushort)0x003A;
        // 100D:5E45 test byte ptr DS:[0x46EB],0x80
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:5E4A je short 0x5E4F
        if (ZeroFlag)
        {
            return calc_sal_index(0x0000);
        }
    label_100D_5E4C_15F1C_18124:
        CheckExternalEvents(cs1, 0x5E4C);
        // 100D:5E4C mov AX,0x007A
        AX = (ushort)0x007A;
        return calc_sal_index(0x0000);
    }

    public virtual Action calc_sal_index(int loadOffset)
    {
    label_100D_5E4F_15F1F_6620:
        CheckExternalEvents(cs1, 0x5E4F);
        // 100D:5E4F mov CL,byte ptr DS:[SI+8]
        CL = UInt8[DS, (ushort)(SI + (sbyte)8)];
        // 100D:5E52 cmp CL,0x20
        Alu8.Sub(CL, (byte)0x20);
        // 100D:5E55 jb short 0x5E6A
        if (CarryFlag)
        {
            goto label_100D_5E6A_15F3A_6628;
        }
    label_100D_5E57_15F27_6624:
        CheckExternalEvents(cs1, 0x5E57);
        // 100D:5E57 inc AX
        AX = Alu16.Inc(AX);
        // 100D:5E58 cmp CL,0x21
        Alu8.Sub(CL, (byte)0x21);
        // 100D:5E5B jb short 0x5E6A
        if (CarryFlag)
        {
            goto label_100D_5E6A_15F3A_6628;
        }
    label_100D_5E5D_15F2D_30990:
        CheckExternalEvents(cs1, 0x5E5D);
        // 100D:5E5D inc AX
        AX = Alu16.Inc(AX);
        // 100D:5E5E cmp CL,0x28
        Alu8.Sub(CL, (byte)0x28);
        // 100D:5E61 jb short 0x5E6A
        if (CarryFlag)
        {
            goto label_100D_5E6A_15F3A_6628;
        }
    label_100D_5E63_15F33_30994:
        CheckExternalEvents(cs1, 0x5E63);
        // 100D:5E63 inc AX
        AX = Alu16.Inc(AX);
        // 100D:5E64 cmp CL,0x30
        Alu8.Sub(CL, (byte)0x30);
        // 100D:5E67 jb short 0x5E6A
        if (CarryFlag)
        {
            goto label_100D_5E6A_15F3A_6628;
        }
    label_100D_5E69_15F39_30998:
        CheckExternalEvents(cs1, 0x5E69);
        // 100D:5E69 inc AX
        AX = Alu16.Inc(AX);
    label_100D_5E6A_15F3A_6628:
        CheckExternalEvents(cs1, 0x5E6A);
        // 100D:5E6A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action find_nearest_location_marker(int loadOffset)
    {
    label_100D_5E6D_15F3D_21162:
        CheckExternalEvents(cs1, 0x5E6D);
        // 100D:5E6D push SI
        Stack.Push16(SI);
        // 100D:5E6E mov BP,SP
        BP = SP;
        // 100D:5E70 sub SP,8
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:5E73 mov word ptr SS:[BP-8],0xFFFF
        UInt16[SS, (ushort)(BP + (sbyte)-8)] = (ushort)0xFFFF;
        // 100D:5E78 mov word ptr SS:[BP-6],DX
        UInt16[SS, (ushort)(BP + (sbyte)-6)] = DX;
        // 100D:5E7B mov word ptr SS:[BP-4],BX
        UInt16[SS, (ushort)(BP + (sbyte)-4)] = BX;
        // 100D:5E7E mov word ptr SS:[BP-2],0
        UInt16[SS, (ushort)(BP + (sbyte)-2)] = (ushort)0x0000;
        // 100D:5E83 mov SI,0xA5BA
        SI = (ushort)0xA5BA;
    label_100D_5E86_15F56_21171:
        CheckExternalEvents(cs1, 0x5E86);
        // 100D:5E86 add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:5E89 mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:5E8B or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5E8D je short 0x5EBF
        if (ZeroFlag)
        {
            goto label_100D_5EBF_15F8F_21202;
        }
    label_100D_5E8F_15F5F_21175:
        CheckExternalEvents(cs1, 0x5E8F);
        // 100D:5E8F cmp byte ptr DS:[DI+8],AL
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], AL);
        // 100D:5E92 jae short 0x5E86
        if (!CarryFlag)
        {
            goto label_100D_5E86_15F56_21171;
        }
    label_100D_5E94_15F64_21178:
        CheckExternalEvents(cs1, 0x5E94);
        // 100D:5E94 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:5E97 cmp BH,byte ptr DS:[0x46EB]
        Alu8.Sub(BH, UInt8[DS, (ushort)0x46EB]);
        // 100D:5E9B jne short 0x5E86
        if (!ZeroFlag)
        {
            goto label_100D_5E86_15F56_21171;
        }
    label_100D_5E9D_15F6D_21182:
        CheckExternalEvents(cs1, 0x5E9D);
        // 100D:5E9D xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:5E9F mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:5EA2 sub DX,word ptr SS:[BP-6]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)-6)]);
        // 100D:5EA5 jns short 0x5EA9
        if (!SignFlag)
        {
            goto label_100D_5EA9_15F79_21189;
        }
    label_100D_5EA7_15F77_21187:
        CheckExternalEvents(cs1, 0x5EA7);
        // 100D:5EA7 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_5EA9_15F79_21189:
        CheckExternalEvents(cs1, 0x5EA9);
        // 100D:5EA9 sub BX,word ptr SS:[BP-4]
        BX = Alu16.Sub(BX, UInt16[SS, (ushort)(BP + (sbyte)-4)]);
        // 100D:5EAC jns short 0x5EB0
        if (!SignFlag)
        {
            goto label_100D_5EB0_15F80_21193;
        }
    label_100D_5EAE_15F7E_21191:
        CheckExternalEvents(cs1, 0x5EAE);
        // 100D:5EAE neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_5EB0_15F80_21193:
        CheckExternalEvents(cs1, 0x5EB0);
        // 100D:5EB0 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 100D:5EB2 cmp DX,word ptr SS:[BP-8]
        Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)-8)]);
        // 100D:5EB5 jae short 0x5E86
        if (!CarryFlag)
        {
            goto label_100D_5E86_15F56_21171;
        }
    label_100D_5EB7_15F87_21196:
        CheckExternalEvents(cs1, 0x5EB7);
        // 100D:5EB7 mov word ptr SS:[BP-8],DX
        UInt16[SS, (ushort)(BP + (sbyte)-8)] = DX;
        // 100D:5EBA mov word ptr SS:[BP-2],DI
        UInt16[SS, (ushort)(BP + (sbyte)-2)] = DI;
        // 100D:5EBD jmp short 0x5E86
        goto label_100D_5E86_15F56_21171;
    label_100D_5EBF_15F8F_21202:
        CheckExternalEvents(cs1, 0x5EBF);
        // 100D:5EBF mov DI,word ptr SS:[BP-2]
        DI = UInt16[SS, (ushort)(BP + (sbyte)-2)];
        // 100D:5EC2 mov AX,word ptr SS:[BP-8]
        AX = UInt16[SS, (ushort)(BP + (sbyte)-8)];
        // 100D:5EC5 mov DX,word ptr SS:[BP-6]
        DX = UInt16[SS, (ushort)(BP + (sbyte)-6)];
        // 100D:5EC8 mov BX,word ptr SS:[BP-4]
        BX = UInt16[SS, (ushort)(BP + (sbyte)-4)];
        // 100D:5ECB add SP,8
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:5ECE pop SI
        SI = Stack.Pop16();
        // 100D:5ECF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5ED0_15FA0(int loadOffset)
    {
    label_100D_5ED0_15FA0_23650:
        CheckExternalEvents(cs1, 0x5ED0);
        // 100D:5ED0 mov BP,0xA5BA
        BP = (ushort)0xA5BA;
    label_100D_5ED3_15FA3_23652:
        CheckExternalEvents(cs1, 0x5ED3);
        // 100D:5ED3 add BP,6
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:5ED6 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:5ED9 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:5EDB je short 0x5EE3
        if (ZeroFlag)
        {
            goto label_100D_5EE3_15FB3_23660;
        }
    label_100D_5EDD_15FAD_23656:
        CheckExternalEvents(cs1, 0x5EDD);
        // 100D:5EDD or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:5EDF jne short 0x5ED3
        if (!ZeroFlag)
        {
            goto label_100D_5ED3_15FA3_23652;
        }
    label_100D_5EE1_15FB1_35525:
        CheckExternalEvents(cs1, 0x5EE1);
        // 100D:5EE1 or BP,BP
        BP = Alu16.Or(BP, BP);
    label_100D_5EE3_15FB3_23660:
        CheckExternalEvents(cs1, 0x5EE3);
        // 100D:5EE3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_place_location_panel(int loadOffset)
    {
    label_100D_5EE4_15FB4_26331:
        CheckExternalEvents(cs1, 0x5EE4);
        // 100D:5EE4 call near 0x5ED0
        NearCall(cs1, 0x5EE7, unknown_100D_5ED0_15FA0);
    label_100D_5EE7_15FB7_26333:
        CheckExternalEvents(cs1, 0x5EE7);
        // 100D:5EE7 jne short 0x5EE3
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:5EE7");
        }
    label_100D_5EE9_15FB9_26335:
        CheckExternalEvents(cs1, 0x5EE9);
        // 100D:5EE9 mov SI,0x1668
        SI = (ushort)0x1668;
        // 100D:5EEC call near 0x6252
        NearCall(cs1, 0x5EEF, location_class);
    label_100D_5EEF_15FBF_26382:
        CheckExternalEvents(cs1, 0x5EEF);
        // 100D:5EEF mov BX,AX
        BX = AX;
        // 100D:5EF1 inc AX
        AX = Alu16.Inc(AX);
        // 100D:5EF2 cmp DI,word ptr DS:[0x46F8]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x46F8]);
        // 100D:5EF6 jne short 0x5F12
        if (!ZeroFlag)
        {
            goto label_100D_5F12_15FE2_26387;
        }
    label_100D_5EF8_15FC8_36759:
        CheckExternalEvents(cs1, 0x5EF8);
        // 100D:5EF8 cmp AL,byte ptr DS:[0x46F7]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x46F7]);
        // 100D:5EFC jne short 0x5F01
        if (!ZeroFlag)
        {
            goto label_100D_5F01_15FD1_40041;
        }
    label_100D_5EFE_15FCE_36762:
        CheckExternalEvents(cs1, 0x5EFE);
        // 100D:5EFE jmp near 0x7B1B
        return map_draw_panel_record(0x0000);
    label_100D_5F01_15FD1_40041:
        CheckExternalEvents(cs1, 0x5F01);
        // 100D:5F01 call near 0xE270
        NearCall(cs1, 0x5F04, unknown_100D_E270_1E340);
    label_100D_5F04_15FD4_40044:
        CheckExternalEvents(cs1, 0x5F04);
        // 100D:5F04 mov byte ptr DS:[0x46D8],1
        UInt8[DS, (ushort)0x46D8] = (byte)0x01;
        // 100D:5F09 call near 0x5F91
        NearCall(cs1, 0x5F0C, map_close_location_popup);
    label_100D_5F0C_15FDC_40049:
        CheckExternalEvents(cs1, 0x5F0C);
        // 100D:5F0C call near 0xC08E
        NearCall(cs1, 0x5F0F, set_screen_as_active_framebuffer);
    label_100D_5F0F_15FDF_40052:
        CheckExternalEvents(cs1, 0x5F0F);
        // 100D:5F0F call near 0xE283
        NearCall(cs1, 0x5F12, unknown_100D_E283_1E353);
    label_100D_5F12_15FE2_26387:
        CheckExternalEvents(cs1, 0x5F12);
        // 100D:5F12 mov byte ptr DS:[0x46F7],AL
        UInt8[DS, (ushort)0x46F7] = AL;
        // 100D:5F15 mov CL,byte ptr DS:[BX+0x11D0]
        CL = UInt8[DS, (ushort)(BX + (short)4560)];
        // 100D:5F19 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:5F1B mov DX,word ptr SS:[BP+2]
        DX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:5F1E mov BX,word ptr SS:[BP+4]
        BX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:5F21 or BH,BH
        BH = Alu8.Or(BH, BH);
        // 100D:5F23 jns short 0x5EE3
        if (!SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:5F23");
        }
        else
        {
            return map_place_popup_panel(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action map_place_popup_panel(int loadOffset)
    {
    label_100D_5F25_15FF5_26395:
        CheckExternalEvents(cs1, 0x5F25);
        // 100D:5F25 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:5F27 push BX
        Stack.Push16(BX);
        // 100D:5F28 push DX
        Stack.Push16(DX);
        // 100D:5F29 mov AX,CX
        AX = CX;
        // 100D:5F2B shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:5F2D sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:5F2F cmp BX,4
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:5F32 jge short 0x5F37
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_5F37_16007_26404;
        }
    label_100D_5F34_16004_32072:
        CheckExternalEvents(cs1, 0x5F34);
        // 100D:5F34 mov BX,4
        BX = (ushort)0x0004;
    label_100D_5F37_16007_26404:
        CheckExternalEvents(cs1, 0x5F37);
        // 100D:5F37 mov AX,0x0094
        AX = (ushort)0x0094;
        // 100D:5F3A sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:5F3C cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:5F3E jl short 0x5F42
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_5F42_16012_26411;
        }
    label_100D_5F40_16010_26409:
        CheckExternalEvents(cs1, 0x5F40);
        // 100D:5F40 mov BX,AX
        BX = AX;
    label_100D_5F42_16012_26411:
        CheckExternalEvents(cs1, 0x5F42);
        // 100D:5F42 add DX,0x000F
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:5F45 cmp DX,0x00D2
        Alu16.Sub(DX, (ushort)0x00D2);
        // 100D:5F49 jl short 0x5F4F
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_5F4F_1601F_26414;
        }
    label_100D_5F4B_1601B_29709:
        CheckExternalEvents(cs1, 0x5F4B);
        // 100D:5F4B sub DX,0x0082
        DX = Alu16.Sub(DX, (ushort)0x0082);
    label_100D_5F4F_1601F_26414:
        CheckExternalEvents(cs1, 0x5F4F);
        // 100D:5F4F mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:5F51 mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        // 100D:5F54 add DX,0x006A
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)106)));
        // 100D:5F57 mov word ptr DS:[SI+4],DX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DX;
        // 100D:5F5A add BX,CX
        BX = Alu16.Add(BX, CX);
        // 100D:5F5C mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:5F5F mov word ptr DS:[0xDBE0],SI
        UInt16[DS, (ushort)0xDBE0] = SI;
        // 100D:5F63 pop DX
        DX = Stack.Pop16();
        // 100D:5F64 pop BX
        BX = Stack.Pop16();
        // 100D:5F65 mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:5F68 sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:5F6A sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:5F6C mov DI,0xD816
        DI = (ushort)0xD816;
        // 100D:5F6F mov word ptr DS:[DI],DX
        UInt16[DS, DI] = DX;
        // 100D:5F71 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:5F74 mov AL,6
        AL = (byte)0x06;
        // 100D:5F76 jmp near 0x7B0F
        return unknown_100D_7B0F_17BDF(0x0000);
    }

    public virtual Action map_close_location_troop_popup(int loadOffset)
    {
    entrydispatcher:
    label_100D_5F79_16049_13250:
        CheckExternalEvents(cs1, 0x5F79);
        // 100D:5F79 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:5F7B xchg AX,word ptr DS:[0x46F8]
        ushort xchgOffset_100D_5F7B_1604B = (ushort)0x46F8;
        ushort temp_100D_5F7B_1604B = AX;
        AX = UInt16[DS, xchgOffset_100D_5F7B_1604B];
        UInt16[DS, xchgOffset_100D_5F7B_1604B] = unchecked((ushort)temp_100D_5F7B_1604B);
        // 100D:5F7F or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:5F81 je short 0x5F90
        if (ZeroFlag)
        {
            goto label_100D_5F90_16060_13255;
        }
    label_100D_5F83_16053_30961:
        CheckExternalEvents(cs1, 0x5F83);
        // 100D:5F83 call near 0xD41B
        NearCall(cs1, 0x5F86, get_location_and_room);
    label_100D_5F86_16056_30963:
        CheckExternalEvents(cs1, 0x5F86);
        // 100D:5F86 mov AL,byte ptr SS:[BP]
        AL = UInt8[SS, (ushort)(BP + (sbyte)0)];
        // 100D:5F89 inc AL
        AL = Alu8.Inc(AL);
        // 100D:5F8B je short 0x5F91
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(map_close_location_popup, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_5F8D_1605D_31338:
        CheckExternalEvents(cs1, 0x5F8D);
        // 100D:5F8D jmp near 0xD2E2
        if (JumpDispatcher.Jump(menu_callback_choice_exit_menu, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5F90_16060_13255:
        CheckExternalEvents(cs1, 0x5F90);
        // 100D:5F90 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_close_location_popup(int loadOffset)
    {
    entrydispatcher:
    label_100D_5F91_16061_26582:
        CheckExternalEvents(cs1, 0x5F91);
        // 100D:5F91 mov word ptr DS:[0x46F8],0
        UInt16[DS, (ushort)0x46F8] = (ushort)0x0000;
        // 100D:5F97 mov byte ptr DS:[0x46F7],0
        UInt8[DS, (ushort)0x46F7] = (byte)0x00;
        // 100D:5F9C mov SI,0x1668
        SI = (ushort)0x1668;
        if (JumpDispatcher.Jump(unknown_100D_5F9F_1606F, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_draw_location_popup(int loadOffset)
    {
    entrydispatcher:
    label_100D_600E_160DE_26326:
        CheckExternalEvents(cs1, 0x600E);
        // 100D:600E call near 0xC08E
        NearCall(cs1, 0x6011, set_screen_as_active_framebuffer);
    label_100D_6011_160E1_26328:
        CheckExternalEvents(cs1, 0x6011);
        // 100D:6011 push DI
        Stack.Push16(DI);
        // 100D:6012 call near 0x5EE4
        NearCall(cs1, 0x6015, map_place_location_panel);
    label_100D_6015_160E5_26543:
        CheckExternalEvents(cs1, 0x6015);
        // 100D:6015 pop DI
        DI = Stack.Pop16();
        // 100D:6016 mov word ptr DS:[0x46F8],DI
        UInt16[DS, (ushort)0x46F8] = DI;
        // 100D:601A call near 0xD068
        NearCall(cs1, 0x601D, font_select_tall_font);
    label_100D_601D_160ED_26547:
        CheckExternalEvents(cs1, 0x601D);
        // 100D:601D mov CL,0x9A
        CL = (byte)0x9A;
        // 100D:601F mov CH,byte ptr DS:[0x1671]
        CH = UInt8[DS, (ushort)0x1671];
        // 100D:6023 mov DX,word ptr DS:[0x1668]
        DX = UInt16[DS, (ushort)0x1668];
        // 100D:6027 mov BX,word ptr DS:[0x166A]
        BX = UInt16[DS, (ushort)0x166A];
        // 100D:602B add DX,0x000C
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:602E add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:6031 call near 0x629D
        NearCall(cs1, 0x6034, draw_string_location_type);
    label_100D_6034_16104_26555:
        CheckExternalEvents(cs1, 0x6034);
        // 100D:6034 mov CL,0x96
        CL = (byte)0x96;
        // 100D:6036 sub DX,8
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:6039 add BX,9
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)9)));
        // 100D:603C call near 0x62A6
        NearCall(cs1, 0x603F, draw_location_name);
    label_100D_603F_1610F_26561:
        CheckExternalEvents(cs1, 0x603F);
        // 100D:603F call near 0x6252
        NearCall(cs1, 0x6042, location_class);
    label_100D_6042_16112_26563:
        CheckExternalEvents(cs1, 0x6042);
        // 100D:6042 cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:6044 je short 0x6059
        if (ZeroFlag)
        {
            goto label_100D_6059_16129_26566;
        }
    label_100D_6046_16116_29785:
        CheckExternalEvents(cs1, 0x6046);
        // 100D:6046 test byte ptr DS:[0x000A],0x20
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x20);
        // 100D:604B je short 0x6056
        if (ZeroFlag)
        {
            goto label_100D_6056_16126_29788;
        }
    label_100D_604D_1611D_35350:
        CheckExternalEvents(cs1, 0x604D);
        // 100D:604D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:604F jne short 0x6056
        if (!ZeroFlag)
        {
            goto label_100D_6056_16126_29788;
        }
    label_100D_6051_16121_35353:
        CheckExternalEvents(cs1, 0x6051);
        // 100D:6051 push AX
        Stack.Push16(AX);
        // 100D:6052 call near 0x605C
        NearCall(cs1, 0x6055, unknown_100D_605C_1612C);
    label_100D_6055_16125_35377:
        CheckExternalEvents(cs1, 0x6055);
        // 100D:6055 pop AX
        AX = Stack.Pop16();
    label_100D_6056_16126_29788:
        CheckExternalEvents(cs1, 0x6056);
        // 100D:6056 call near 0x60AC
        NearCall(cs1, 0x6059, map_draw_location_equipment_or_battle);
    label_100D_6059_16129_26566:
        CheckExternalEvents(cs1, 0x6059);
        // 100D:6059 jmp near 0xC07C
        return set_fb1_as_active_framebuffer(0x0000);
    }

    public virtual Action unknown_100D_605C_1612C(int loadOffset)
    {
    label_100D_605C_1612C_35356:
        CheckExternalEvents(cs1, 0x605C);
        // 100D:605C call near 0xD075
        NearCall(cs1, 0x605F, font_select_small_font);
    label_100D_605F_1612F_35358:
        CheckExternalEvents(cs1, 0x605F);
        // 100D:605F mov CL,0x90
        CL = (byte)0x90;
        // 100D:6061 add BX,0x000A
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:6064 mov DX,word ptr DS:[0x1668]
        DX = UInt16[DS, (ushort)0x1668];
        // 100D:6068 add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:606B mov AX,0x006C
        AX = (ushort)0x006C;
        // 100D:606E call near 0xD194
        NearCall(cs1, 0x6071, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_6071_16141_35365:
        CheckExternalEvents(cs1, 0x6071);
        // 100D:6071 mov AL,byte ptr DS:[DI+0x1B]
        AL = UInt8[DS, (ushort)(DI + (sbyte)27)];
        // 100D:6074 mov SI,0x0075
        SI = (ushort)0x0075;
        // 100D:6077 mov BP,0x006D
        BP = (ushort)0x006D;
        // 100D:607A test byte ptr DS:[DI+0x0A],0x20
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x20);
        // 100D:607E je short 0x609D
        if (ZeroFlag)
        {
            goto label_100D_609D_1616D_35371;
        }
    label_100D_6080_16150_35607:
        CheckExternalEvents(cs1, 0x6080);
        // 100D:6080 push CX
        Stack.Push16(CX);
        // 100D:6081 push AX
        Stack.Push16(AX);
        // 100D:6082 push SI
        Stack.Push16(SI);
        // 100D:6083 call near 0xE295
        NearCall(cs1, 0x6086, unknown_100D_E295_1E365);
    label_100D_6086_16156_35615:
        CheckExternalEvents(cs1, 0x6086);
        // 100D:6086 pop AX
        AX = Stack.Pop16();
        // 100D:6087 pop CX
        CX = Stack.Pop16();
        // 100D:6088 add BX,7
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:608B mov DX,word ptr DS:[0x1668]
        DX = UInt16[DS, (ushort)0x1668];
        // 100D:608F add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:6092 mov BP,word ptr DS:[0x166C]
        BP = UInt16[DS, (ushort)0x166C];
        // 100D:6096 push BX
        Stack.Push16(BX);
        // 100D:6097 call near 0x617A
        NearCall(cs1, 0x609A, unknown_100D_617A_1624A);
    label_100D_609A_1616A_35681:
        CheckExternalEvents(cs1, 0x609A);
        // 100D:609A pop BX
        BX = Stack.Pop16();
        // 100D:609B pop CX
        CX = Stack.Pop16();
        // 100D:609C ret near
        return NearRet((ushort)0x0000);
    label_100D_609D_1616D_35371:
        CheckExternalEvents(cs1, 0x609D);
        // 100D:609D mov AX,BP
        AX = BP;
        // 100D:609F add BX,7
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:60A2 mov DX,word ptr DS:[0x1668]
        DX = UInt16[DS, (ushort)0x1668];
        // 100D:60A6 add DX,0x000A
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:60A9 jmp near 0xD194
        return font_draw_phrase_or_command_string_with_color_at_pos(0x0000);
    }

    public virtual Action map_draw_location_equipment_or_battle(int loadOffset)
    {
    label_100D_60AC_1617C_29790:
        CheckExternalEvents(cs1, 0x60AC);
        // 100D:60AC call near 0xC13B
        NearCall(cs1, 0x60AF, open_onmap_spritesheet);
    label_100D_60AF_1617F_29792:
        CheckExternalEvents(cs1, 0x60AF);
        // 100D:60AF call near 0xD068
        NearCall(cs1, 0x60B2, font_select_tall_font);
    label_100D_60B2_16182_29794:
        CheckExternalEvents(cs1, 0x60B2);
        // 100D:60B2 mov CL,0x9A
        CL = (byte)0x9A;
        // 100D:60B4 mov DX,word ptr DS:[0x1668]
        DX = UInt16[DS, (ushort)0x1668];
        // 100D:60B8 add BX,0x000C
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:60BB add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:60BE call near 0x627E
        NearCall(cs1, 0x60C1, location_has_battle);
    label_100D_60C1_16191_29800:
        CheckExternalEvents(cs1, 0x60C1);
        // 100D:60C1 jb short 0x60D6
        if (CarryFlag)
        {
            goto label_100D_60D6_161A6_35853;
        }
    label_100D_60C3_16193_29802:
        CheckExternalEvents(cs1, 0x60C3);
        // 100D:60C3 mov AX,0x006E
        AX = (ushort)0x006E;
        // 100D:60C6 call near 0xD194
        NearCall(cs1, 0x60C9, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_60C9_16199_29805:
        CheckExternalEvents(cs1, 0x60C9);
        // 100D:60C9 add BX,0x000A
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:60CC lea SI,DI+0x14
        SI = unchecked((ushort)(DI + (sbyte)20));
        // 100D:60CF mov BP,word ptr DS:[0x166E]
        BP = UInt16[DS, (ushort)0x166E];
        // 100D:60D3 jmp near 0x7E3D
        return map_draw_equipment_columns(0x0000);
    label_100D_60D6_161A6_35853:
        CheckExternalEvents(cs1, 0x60D6);
        // 100D:60D6 mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:60D9 call near 0xD194
        NearCall(cs1, 0x60DC, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_60DC_161AC_35856:
        CheckExternalEvents(cs1, 0x60DC);
        // 100D:60DC add BX,6
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:60DF add DX,0x002F
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)47)));
        // 100D:60E2 push BX
        Stack.Push16(BX);
        // 100D:60E3 push DX
        Stack.Push16(DX);
        // 100D:60E4 call near 0x60F8
        NearCall(cs1, 0x60E7, location_battle_gauge);
    label_100D_60E7_161B7_35923:
        CheckExternalEvents(cs1, 0x60E7);
        // 100D:60E7 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:60E9 add AX,0x000F
        AX = Alu16.Add(AX, (ushort)0x000F);
        // 100D:60EC mov CL,5
        CL = (byte)0x05;
        // 100D:60EE shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:60F0 add AX,0x008E
        AX = Alu16.Add(AX, (ushort)0x008E);
        // 100D:60F3 pop DX
        DX = Stack.Pop16();
        // 100D:60F4 pop BX
        BX = Stack.Pop16();
        // 100D:60F5 jmp near 0xC22F
        return draw_active_bank_sprite(0x0000);
    }

    public virtual Action location_battle_gauge(int loadOffset)
    {
    label_100D_60F8_161C8_35862:
        CheckExternalEvents(cs1, 0x60F8);
        // 100D:60F8 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:60FA xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:60FC xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:60FE mov word ptr DS:[0xD81C],DX
        UInt16[DS, (ushort)0xD81C] = DX;
        // 100D:6102 mov BP,0x6155
        BP = (ushort)0x6155;
        // 100D:6105 call near 0x6603
        NearCall(cs1, 0x6108, for_each_troop_in_location);
    label_100D_6108_161D8_35888:
        CheckExternalEvents(cs1, 0x6108);
        // 100D:6108 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:610A add BX,DX
        BX = Alu16.Add(BX, DX);
        // 100D:610C je short 0x6114
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:610C");
        }
    label_100D_610E_161DE_35892:
        CheckExternalEvents(cs1, 0x610E);
        // 100D:610E xchg AH,DL
        byte temp_100D_610E_161DE = AH;
        AH = DL;
        DL = unchecked((byte)temp_100D_610E_161DE);
        // 100D:6110 xchg DH,DL
        byte temp_100D_6110_161E0 = DH;
        DH = DL;
        DL = unchecked((byte)temp_100D_6110_161E0);
        // 100D:6112 div BX
        ushort divisor_100D_6112_161E2 = BX;
        uint dividend_100D_6112_161E2 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_6112_161E2 = Alu16.Div(unchecked((uint)dividend_100D_6112_161E2), unchecked((ushort)divisor_100D_6112_161E2));
        AX = unchecked((ushort)quotient_100D_6112_161E2);
        DX = unchecked((ushort)(dividend_100D_6112_161E2 % unchecked((uint)divisor_100D_6112_161E2)));
        // 100D:6114 mov BX,AX
        BX = AX;
        // 100D:6116 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:6118 mov DX,word ptr DS:[0xD81C]
        DX = UInt16[DS, (ushort)0xD81C];
        // 100D:611C add CX,DX
        CX = Alu16.Add(CX, DX);
        // 100D:611E je short 0x6126
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:611E");
        }
    label_100D_6120_161F0_35901:
        CheckExternalEvents(cs1, 0x6120);
        // 100D:6120 xchg AH,DL
        byte temp_100D_6120_161F0 = AH;
        AH = DL;
        DL = unchecked((byte)temp_100D_6120_161F0);
        // 100D:6122 xchg DH,DL
        byte temp_100D_6122_161F2 = DH;
        DH = DL;
        DL = unchecked((byte)temp_100D_6122_161F2);
        // 100D:6124 div CX
        ushort divisor_100D_6124_161F4 = CX;
        uint dividend_100D_6124_161F4 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_6124_161F4 = Alu16.Div(unchecked((uint)dividend_100D_6124_161F4), unchecked((ushort)divisor_100D_6124_161F4));
        AX = unchecked((ushort)quotient_100D_6124_161F4);
        DX = unchecked((ushort)(dividend_100D_6124_161F4 % unchecked((uint)divisor_100D_6124_161F4)));
        // 100D:6126 mov CX,AX
        CX = AX;
        // 100D:6128 mov SI,BX
        SI = BX;
        // 100D:612A cmp SI,CX
        Alu16.Sub(SI, CX);
        // 100D:612C jae short 0x6130
        if (!CarryFlag)
        {
            goto label_100D_6130_16200_35911;
        }
    label_100D_612E_161FE_35909:
        CheckExternalEvents(cs1, 0x612E);
        // 100D:612E mov SI,CX
        SI = CX;
    label_100D_6130_16200_35911:
        CheckExternalEvents(cs1, 0x6130);
        // 100D:6130 mov AX,BX
        AX = BX;
        // 100D:6132 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:6134 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:6136 je short 0x613F
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6136");
        }
    label_100D_6138_16208_35915:
        CheckExternalEvents(cs1, 0x6138);
        // 100D:6138 cwd
        DX = unchecked((ushort)(unchecked((short)AX) >> 15));
        // 100D:6139 xchg AL,AH
        byte temp_100D_6139_16209 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_6139_16209);
        // 100D:613B xchg AL,DL
        byte temp_100D_613B_1620B = AL;
        AL = DL;
        DL = unchecked((byte)temp_100D_613B_1620B);
        // 100D:613D idiv SI
        short divisor_100D_613D_1620D = unchecked((short)SI);
        int dividend_100D_613D_1620D = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_613D_1620D = Alu16.Idiv(unchecked((int)dividend_100D_613D_1620D), unchecked((short)divisor_100D_613D_1620D));
        AX = unchecked((ushort)quotient_100D_613D_1620D);
        DX = unchecked((ushort)(dividend_100D_613D_1620D % unchecked((int)divisor_100D_613D_1620D)));
        // 100D:613F sar AX,1
        AX = Alu16.Sar(AX, 1);
        // 100D:6141 add AL,0x80
        AL = Alu8.Add(AL, (byte)0x80);
        // 100D:6143 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6144_16214(int loadOffset)
    {
    label_100D_6144_16214_36183:
        CheckExternalEvents(cs1, 0x6144);
        // 100D:6144 call near 0xE270
        NearCall(cs1, 0x6147, unknown_100D_E270_1E340);
    label_100D_6147_16217_36185:
        CheckExternalEvents(cs1, 0x6147);
        // 100D:6147 push ES
        Stack.Push16(ES);
        // 100D:6148 call near 0x60F8
        NearCall(cs1, 0x614B, location_battle_gauge);
    label_100D_614B_1621B_36189:
        CheckExternalEvents(cs1, 0x614B);
        // 100D:614B or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
        // 100D:614D mov byte ptr DS:[0x00FD],AL
        UInt8[DS, (ushort)0x00FD] = AL;
        // 100D:6150 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:6151 call near 0xE283
        NearCall(cs1, 0x6154, unknown_100D_E283_1E353);
    label_100D_6154_16224_36194:
        CheckExternalEvents(cs1, 0x6154);
        // 100D:6154 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6155_16225(int loadOffset)
    {
    label_100D_6155_16225_35869:
        CheckExternalEvents(cs1, 0x6155);
        // 100D:6155 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:6157 mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:615A test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:615E je short 0x6165
        if (ZeroFlag)
        {
            goto label_100D_6165_16235_35874;
        }
    label_100D_6160_16230_35885:
        CheckExternalEvents(cs1, 0x6160);
        // 100D:6160 add word ptr DS:[0xD81C],AX
        UInt16[DS, (ushort)0xD81C] = Alu16.Add(UInt16[DS, (ushort)0xD81C], AX);
        // 100D:6164 ret near
        return NearRet((ushort)0x0000);
    label_100D_6165_16235_35874:
        CheckExternalEvents(cs1, 0x6165);
        // 100D:6165 cmp byte ptr DS:[SI+3],6
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x06);
        // 100D:6169 jne short 0x6179
        if (!ZeroFlag)
        {
            goto label_100D_6179_16249_35884;
        }
    label_100D_616B_1623B_35877:
        CheckExternalEvents(cs1, 0x616B);
        // 100D:616B test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:616F jne short 0x6173
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:616F");
        }
    label_100D_6171_16241_35880:
        CheckExternalEvents(cs1, 0x6171);
        // 100D:6171 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:6173 add CX,word ptr DS:[SI+0x0C]
        CX = Alu16.Add(CX, UInt16[DS, (ushort)(SI + (sbyte)12)]);
        // 100D:6176 add BX,word ptr DS:[SI+0x0E]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)(SI + (sbyte)14)]);
    label_100D_6179_16249_35884:
        CheckExternalEvents(cs1, 0x6179);
        // 100D:6179 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_617A_1624A(int loadOffset)
    {
    label_100D_617A_1624A_35624:
        CheckExternalEvents(cs1, 0x617A);
        // 100D:617A and CX,0x00FF
        CX = Alu16.And(CX, (ushort)0x00FF);
        // 100D:617E je short 0x61D2
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:617E");
        }
    label_100D_6180_16250_35627:
        CheckExternalEvents(cs1, 0x6180);
        // 100D:6180 push BX
        Stack.Push16(BX);
        // 100D:6181 push DI
        Stack.Push16(DI);
        // 100D:6182 push AX
        Stack.Push16(AX);
        // 100D:6183 push DX
        Stack.Push16(DX);
        // 100D:6184 call near 0xC1F4
        NearCall(cs1, 0x6187, unknown_100D_C1F4_1C2C4);
    label_100D_6187_16257_35633:
        CheckExternalEvents(cs1, 0x6187);
        // 100D:6187 mov DI,BP
        DI = BP;
        // 100D:6189 sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 100D:618B mov BP,word ptr ES:[SI]
        BP = UInt16[ES, SI];
        // 100D:618E and BP,0x0FFF
        BP = Alu16.And(BP, (ushort)0x0FFF);
        // 100D:6192 add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:6195 mov AX,DI
        AX = DI;
        // 100D:6197 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:6199 div CX
        ushort divisor_100D_6199_16269 = CX;
        uint dividend_100D_6199_16269 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_6199_16269 = Alu16.Div(unchecked((uint)dividend_100D_6199_16269), unchecked((ushort)divisor_100D_6199_16269));
        AX = unchecked((ushort)quotient_100D_6199_16269);
        DX = unchecked((ushort)(dividend_100D_6199_16269 % unchecked((uint)divisor_100D_6199_16269)));
        // 100D:619B cmp AX,BP
        Alu16.Sub(AX, BP);
        // 100D:619D jae short 0x61B5
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:619D");
        }
    label_100D_619F_1626F_35644:
        CheckExternalEvents(cs1, 0x619F);
        // 100D:619F sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 100D:61A1 mov AX,DI
        AX = DI;
        // 100D:61A3 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:61A5 div CX
        ushort divisor_100D_61A5_16275 = CX;
        uint dividend_100D_61A5_16275 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_61A5_16275 = Alu16.Div(unchecked((uint)dividend_100D_61A5_16275), unchecked((ushort)divisor_100D_61A5_16275));
        AX = unchecked((ushort)quotient_100D_61A5_16275);
        DX = unchecked((ushort)(dividend_100D_61A5_16275 % unchecked((uint)divisor_100D_61A5_16275)));
        // 100D:61A7 mov BP,AX
        BP = AX;
        // 100D:61A9 cmp BP,2
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:61AC jae short 0x61B5
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:61AC");
        }
    label_100D_61AE_1627E_35652:
        CheckExternalEvents(cs1, 0x61AE);
        // 100D:61AE mov BP,2
        BP = (ushort)0x0002;
        // 100D:61B1 mov CX,DI
        CX = DI;
        // 100D:61B3 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:61B5 pop DX
        DX = Stack.Pop16();
        // 100D:61B6 pop AX
        AX = Stack.Pop16();
    label_100D_61B7_16287_35658:
        CheckExternalEvents(cs1, 0x61B7);
        // 100D:61B7 push AX
        Stack.Push16(AX);
        // 100D:61B8 push BX
        Stack.Push16(BX);
        // 100D:61B9 push CX
        Stack.Push16(CX);
        // 100D:61BA push DX
        Stack.Push16(DX);
        // 100D:61BB push BP
        Stack.Push16(BP);
        // 100D:61BC call near 0xC22F
        NearCall(cs1, 0x61BF, draw_active_bank_sprite);
    label_100D_61BF_1628F_35664:
        CheckExternalEvents(cs1, 0x61BF);
        // 100D:61BF pop BP
        BP = Stack.Pop16();
        // 100D:61C0 pop DX
        DX = Stack.Pop16();
        // 100D:61C1 pop CX
        CX = Stack.Pop16();
        // 100D:61C2 pop BX
        BX = Stack.Pop16();
        // 100D:61C3 pop AX
        AX = Stack.Pop16();
        // 100D:61C4 add DX,BP
        DX = Alu16.Add(DX, BP);
        // 100D:61C6 loop 0x61B7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_61B7_16287_35658;
        }
    label_100D_61C8_16298_35673:
        CheckExternalEvents(cs1, 0x61C8);
        // 100D:61C8 pop DI
        DI = Stack.Pop16();
        // 100D:61C9 pop BX
        BX = Stack.Pop16();
        // 100D:61CA call near 0xC1F4
        NearCall(cs1, 0x61CD, unknown_100D_C1F4_1C2C4);
    label_100D_61CD_1629D_35677:
        CheckExternalEvents(cs1, 0x61CD);
        // 100D:61CD add BL,byte ptr ES:[SI+2]
        BL = Alu8.Add(BL, UInt8[ES, (ushort)(SI + (sbyte)2)]);
        // 100D:61D1 inc BX
        BX = Alu16.Inc(BX);
        // 100D:61D2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_61D3_162A3(int loadOffset)
    {
    label_100D_61D3_162A3_27602:
        CheckExternalEvents(cs1, 0x61D3);
        // 100D:61D3 and CX,0x00FF
        CX = Alu16.And(CX, (ushort)0x00FF);
        // 100D:61D7 je short 0x61D2
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:61D7");
        }
    label_100D_61D9_162A9_27605:
        CheckExternalEvents(cs1, 0x61D9);
        // 100D:61D9 push BX
        Stack.Push16(BX);
        // 100D:61DA push DI
        Stack.Push16(DI);
        // 100D:61DB push AX
        Stack.Push16(AX);
        // 100D:61DC push DX
        Stack.Push16(DX);
        // 100D:61DD call near 0xC1F4
        NearCall(cs1, 0x61E0, unknown_100D_C1F4_1C2C4);
    label_100D_61E0_162B0_27611:
        CheckExternalEvents(cs1, 0x61E0);
        // 100D:61E0 mov DI,BP
        DI = BP;
        // 100D:61E2 sub DI,BX
        DI = Alu16.Sub(DI, BX);
        // 100D:61E4 mov BP,word ptr ES:[SI+2]
        BP = UInt16[ES, (ushort)(SI + (sbyte)2)];
        // 100D:61E8 and BP,0x00FF
        BP = Alu16.And(BP, (ushort)0x00FF);
        // 100D:61EC add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:61EF mov AX,DI
        AX = DI;
        // 100D:61F1 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:61F3 div CX
        ushort divisor_100D_61F3_162C3 = CX;
        uint dividend_100D_61F3_162C3 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_61F3_162C3 = Alu16.Div(unchecked((uint)dividend_100D_61F3_162C3), unchecked((ushort)divisor_100D_61F3_162C3));
        AX = unchecked((ushort)quotient_100D_61F3_162C3);
        DX = unchecked((ushort)(dividend_100D_61F3_162C3 % unchecked((uint)divisor_100D_61F3_162C3)));
        // 100D:61F5 cmp AX,BP
        Alu16.Sub(AX, BP);
        // 100D:61F7 jae short 0x620F
        if (!CarryFlag)
        {
            goto label_100D_620F_162DF_27622;
        }
    label_100D_61F9_162C9_35450:
        CheckExternalEvents(cs1, 0x61F9);
        // 100D:61F9 sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 100D:61FB mov AX,DI
        AX = DI;
        // 100D:61FD xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:61FF div CX
        ushort divisor_100D_61FF_162CF = CX;
        uint dividend_100D_61FF_162CF = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_61FF_162CF = Alu16.Div(unchecked((uint)dividend_100D_61FF_162CF), unchecked((ushort)divisor_100D_61FF_162CF));
        AX = unchecked((ushort)quotient_100D_61FF_162CF);
        DX = unchecked((ushort)(dividend_100D_61FF_162CF % unchecked((uint)divisor_100D_61FF_162CF)));
        // 100D:6201 mov BP,AX
        BP = AX;
        // 100D:6203 cmp BP,2
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:6206 jae short 0x620F
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6206");
        }
    label_100D_620F_162DF_27622:
        CheckExternalEvents(cs1, 0x620F);
        // 100D:620F pop DX
        DX = Stack.Pop16();
        // 100D:6210 pop AX
        AX = Stack.Pop16();
    label_100D_6211_162E1_27625:
        CheckExternalEvents(cs1, 0x6211);
        // 100D:6211 push AX
        Stack.Push16(AX);
        // 100D:6212 push BX
        Stack.Push16(BX);
        // 100D:6213 push CX
        Stack.Push16(CX);
        // 100D:6214 push DX
        Stack.Push16(DX);
        // 100D:6215 push BP
        Stack.Push16(BP);
        // 100D:6216 call near 0xC22F
        NearCall(cs1, 0x6219, draw_active_bank_sprite);
    label_100D_6219_162E9_27631:
        CheckExternalEvents(cs1, 0x6219);
        // 100D:6219 pop BP
        BP = Stack.Pop16();
        // 100D:621A pop DX
        DX = Stack.Pop16();
        // 100D:621B pop CX
        CX = Stack.Pop16();
        // 100D:621C pop BX
        BX = Stack.Pop16();
        // 100D:621D pop AX
        AX = Stack.Pop16();
        // 100D:621E add BX,BP
        BX = Alu16.Add(BX, BP);
        // 100D:6220 loop 0x6211
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6211_162E1_27625;
        }
    label_100D_6222_162F2_27639:
        CheckExternalEvents(cs1, 0x6222);
        // 100D:6222 pop DI
        DI = Stack.Pop16();
        // 100D:6223 pop BX
        BX = Stack.Pop16();
        // 100D:6224 call near 0xC1F4
        NearCall(cs1, 0x6227, unknown_100D_C1F4_1C2C4);
    label_100D_6227_162F7_27643:
        CheckExternalEvents(cs1, 0x6227);
        // 100D:6227 mov AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        // 100D:622A and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:622D add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:622F inc DX
        DX = Alu16.Inc(DX);
        // 100D:6230 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_location_type_string_offset(int loadOffset)
    {
    label_100D_6231_16301_21310:
        CheckExternalEvents(cs1, 0x6231);
        // 100D:6231 push BX
        Stack.Push16(BX);
        // 100D:6232 mov BL,byte ptr DS:[DI+8]
        BL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:6235 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:6237 cmp BL,0x20
        Alu8.Sub(BL, (byte)0x20);
        // 100D:623A jb short 0x6250
        if (CarryFlag)
        {
            goto label_100D_6250_16320_21316;
        }
    label_100D_623C_1630C_26366:
        CheckExternalEvents(cs1, 0x623C);
        // 100D:623C inc AX
        AX = Alu16.Inc(AX);
        // 100D:623D cmp BL,0x21
        Alu8.Sub(BL, (byte)0x21);
        // 100D:6240 jb short 0x6250
        if (CarryFlag)
        {
            goto label_100D_6250_16320_21316;
        }
    label_100D_6242_16312_33832:
        CheckExternalEvents(cs1, 0x6242);
        // 100D:6242 inc AX
        AX = Alu16.Inc(AX);
        // 100D:6243 cmp BL,0x28
        Alu8.Sub(BL, (byte)0x28);
        // 100D:6246 jb short 0x6250
        if (CarryFlag)
        {
            goto label_100D_6250_16320_21316;
        }
    label_100D_6248_16318_35766:
        CheckExternalEvents(cs1, 0x6248);
        // 100D:6248 inc AX
        AX = Alu16.Inc(AX);
        // 100D:6249 cmp BL,0x30
        Alu8.Sub(BL, (byte)0x30);
        // 100D:624C jb short 0x6250
        if (CarryFlag)
        {
            goto label_100D_6250_16320_21316;
        }
    label_100D_624E_1631E_37322:
        CheckExternalEvents(cs1, 0x624E);
        // 100D:624E sub AL,2
        AL = Alu8.Sub(AL, (byte)0x02);
    label_100D_6250_16320_21316:
        CheckExternalEvents(cs1, 0x6250);
        // 100D:6250 pop BX
        BX = Stack.Pop16();
        // 100D:6251 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action location_class(int loadOffset)
    {
    label_100D_6252_16322_26338:
        CheckExternalEvents(cs1, 0x6252);
        // 100D:6252 call near 0x627E
        NearCall(cs1, 0x6255, location_has_battle);
    label_100D_6255_16325_26354:
        CheckExternalEvents(cs1, 0x6255);
        // 100D:6255 jb short 0x627A
        if (CarryFlag)
        {
            goto label_100D_627A_1634A_35442;
        }
    label_100D_6257_16327_26356:
        CheckExternalEvents(cs1, 0x6257);
        // 100D:6257 call near 0x5D36
        NearCall(cs1, 0x625A, location_is_atreides);
    label_100D_625A_1632A_26358:
        CheckExternalEvents(cs1, 0x625A);
        // 100D:625A mov AX,2
        AX = (ushort)0x0002;
        // 100D:625D jb short 0x6260
        if (CarryFlag)
        {
            goto label_100D_6260_16330_26361;
        }
    label_100D_625F_1632F_37320:
        CheckExternalEvents(cs1, 0x625F);
        // 100D:625F ret near
        return NearRet((ushort)0x0000);
    label_100D_6260_16330_26361:
        CheckExternalEvents(cs1, 0x6260);
        // 100D:6260 test byte ptr DS:[DI+0x0A],0x10
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x10);
        // 100D:6264 je short 0x627D
        if (ZeroFlag)
        {
            goto label_100D_627D_1634D_26380;
        }
    label_100D_6266_16336_26364:
        CheckExternalEvents(cs1, 0x6266);
        // 100D:6266 call near 0x6231
        NearCall(cs1, 0x6269, get_location_type_string_offset);
    label_100D_6269_16339_26370:
        CheckExternalEvents(cs1, 0x6269);
        // 100D:6269 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:626B je short 0x627D
        if (ZeroFlag)
        {
            goto label_100D_627D_1634D_26380;
        }
    label_100D_626D_1633D_26373:
        CheckExternalEvents(cs1, 0x626D);
        // 100D:626D cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:626F jne short 0x6274
        if (!ZeroFlag)
        {
            goto label_100D_6274_16344_26376;
        }
    label_100D_6271_16341_36750:
        CheckExternalEvents(cs1, 0x6271);
        // 100D:6271 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:6273 ret near
        return NearRet((ushort)0x0000);
    label_100D_6274_16344_26376:
        CheckExternalEvents(cs1, 0x6274);
        // 100D:6274 cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:6276 mov AL,2
        AL = (byte)0x02;
        // 100D:6278 jne short 0x627D
        if (!ZeroFlag)
        {
            goto label_100D_627D_1634D_26380;
        }
    label_100D_627A_1634A_35442:
        CheckExternalEvents(cs1, 0x627A);
        // 100D:627A mov AX,1
        AX = (ushort)0x0001;
    label_100D_627D_1634D_26380:
        CheckExternalEvents(cs1, 0x627D);
        // 100D:627D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action location_has_battle(int loadOffset)
    {
    label_100D_627E_1634E_26340:
        CheckExternalEvents(cs1, 0x627E);
        // 100D:627E call near 0xE270
        NearCall(cs1, 0x6281, unknown_100D_E270_1E340);
    label_100D_6281_16351_26342:
        CheckExternalEvents(cs1, 0x6281);
        // 100D:6281 test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:6285 jne short 0x6293
        if (!ZeroFlag)
        {
            goto label_100D_6293_16363_35848;
        }
    label_100D_6287_16357_26345:
        CheckExternalEvents(cs1, 0x6287);
        // 100D:6287 call near 0x5D36
        NearCall(cs1, 0x628A, location_is_atreides);
    label_100D_628A_1635A_26347:
        CheckExternalEvents(cs1, 0x628A);
        // 100D:628A jb short 0x6298
        if (CarryFlag)
        {
            goto label_100D_6298_16368_26349;
        }
    label_100D_628C_1635C_36719:
        CheckExternalEvents(cs1, 0x628C);
        // 100D:628C call near 0x5098
        NearCall(cs1, 0x628F, unknown_100D_5098_15168);
    label_100D_628F_1635F_36721:
        CheckExternalEvents(cs1, 0x628F);
        // 100D:628F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:6291 je short 0x6298
        if (ZeroFlag)
        {
            goto label_100D_6298_16368_26349;
        }
    label_100D_6293_16363_35848:
        CheckExternalEvents(cs1, 0x6293);
        // 100D:6293 call near 0xE283
        NearCall(cs1, 0x6296, unknown_100D_E283_1E353);
    label_100D_6296_16366_35850:
        CheckExternalEvents(cs1, 0x6296);
        // 100D:6296 stc
        CarryFlag = true;
        // 100D:6297 ret near
        return NearRet((ushort)0x0000);
    label_100D_6298_16368_26349:
        CheckExternalEvents(cs1, 0x6298);
        // 100D:6298 call near 0xE283
        NearCall(cs1, 0x629B, unknown_100D_E283_1E353);
    label_100D_629B_1636B_26351:
        CheckExternalEvents(cs1, 0x629B);
        // 100D:629B clc
        CarryFlag = false;
        // 100D:629C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_string_location_type(int loadOffset)
    {
    label_100D_629D_1636D_21308:
        CheckExternalEvents(cs1, 0x629D);
        // 100D:629D call near 0x6231
        NearCall(cs1, 0x62A0, get_location_type_string_offset);
    label_100D_62A0_16370_21319:
        CheckExternalEvents(cs1, 0x62A0);
        // 100D:62A0 add AX,0x0044
        AX = Alu16.Add(AX, (ushort)0x0044);
        // 100D:62A3 jmp near 0xD194
        return font_draw_phrase_or_command_string_with_color_at_pos(0x0000);
    }

    public virtual Action draw_location_name(int loadOffset)
    {
    label_100D_62A6_16376_21327:
        CheckExternalEvents(cs1, 0x62A6);
        // 100D:62A6 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:62A8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:62AA add AX,0
        AX = Alu16.Add(AX, (ushort)0x0000);
        // 100D:62AD call near 0xD194
        NearCall(cs1, 0x62B0, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_62B0_16380_21332:
        CheckExternalEvents(cs1, 0x62B0);
        // 100D:62B0 cmp byte ptr DS:[DI+1],3
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)1)], (byte)0x03);
        // 100D:62B4 mov AL,0x20
        AL = (byte)0x20;
        // 100D:62B6 jb short 0x62BA
        if (CarryFlag)
        {
            goto label_100D_62BA_1638A_21338;
        }
    label_100D_62B8_16388_21336:
        CheckExternalEvents(cs1, 0x62B8);
        // 100D:62B8 mov AL,0x2D
        AL = (byte)0x2D;
    label_100D_62BA_1638A_21338:
        CheckExternalEvents(cs1, 0x62BA);
        // 100D:62BA call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD096:
                NearCall(cs1, 0x62BE, font_draw_glyph);
                break;
            case 0xD12F:
                NearCall(cs1, 0x62BE, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:62BA");
        }
    label_100D_62BE_1638E_21339:
        CheckExternalEvents(cs1, 0x62BE);
        // 100D:62BE mov AL,byte ptr DS:[DI+1]
        AL = UInt8[DS, (ushort)(DI + (sbyte)1)];
        // 100D:62C1 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:62C3 add AX,0x000C
        AX = Alu16.Add(AX, (ushort)0x000C);
        // 100D:62C6 jmp near 0xD19B
        return font_draw_phrase_or_command_string(0x0000);
    }

    public virtual Action location_visible_on_map(int loadOffset)
    {
    label_100D_62C9_16399_18105:
        CheckExternalEvents(cs1, 0x62C9);
        // 100D:62C9 cmp byte ptr DS:[0x46EB],1
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x01);
        // 100D:62CE jb short 0x62F1
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:62CE");
        }
    label_100D_62D0_163A0_18108:
        CheckExternalEvents(cs1, 0x62D0);
        // 100D:62D0 mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:62D3 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        return map_position_to_screen_if_visible(0x0000);
    }

    public virtual Action map_position_to_screen_if_visible(int loadOffset)
    {
    label_100D_62D6_163A6_17968:
        CheckExternalEvents(cs1, 0x62D6);
        // 100D:62D6 call near 0xB647
        NearCall(cs1, 0x62D9, map_position_to_screen);
    label_100D_62D9_163A9_17999:
        CheckExternalEvents(cs1, 0x62D9);
        // 100D:62D9 cmp DX,word ptr DS:[0x46E3]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E3]);
        // 100D:62DD jb short 0x62F1
        if (CarryFlag)
        {
            return unknown_100D_62F1_163C1(0x0000);
        }
    label_100D_62DF_163AF_18002:
        CheckExternalEvents(cs1, 0x62DF);
        // 100D:62DF cmp DX,word ptr DS:[0x46E7]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E7]);
        // 100D:62E3 cmc
        CarryFlag = !CarryFlag;
        // 100D:62E4 jb short 0x62F1
        if (CarryFlag)
        {
            return unknown_100D_62F1_163C1(0x0000);
        }
    label_100D_62E6_163B6_18006:
        CheckExternalEvents(cs1, 0x62E6);
        // 100D:62E6 cmp BX,word ptr DS:[0x46E5]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x46E5]);
        // 100D:62EA jb short 0x62F1
        if (CarryFlag)
        {
            return unknown_100D_62F1_163C1(0x0000);
        }
    label_100D_62EC_163BC_18009:
        CheckExternalEvents(cs1, 0x62EC);
        // 100D:62EC cmp BX,word ptr DS:[0x46E9]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x46E9]);
        // 100D:62F0 cmc
        CarryFlag = !CarryFlag;
        return unknown_100D_62F1_163C1(0x0000);
    }

    public virtual Action unknown_100D_62F2_163C2(int loadOffset)
    {
    label_100D_62F2_163C2_28830:
        CheckExternalEvents(cs1, 0x62F2);
        // 100D:62F2 call near 0x68EB
        NearCall(cs1, 0x62F5, contact_verb_troop);
    label_100D_62F5_163C5_28832:
        CheckExternalEvents(cs1, 0x62F5);
        // 100D:62F5 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:62F9 jne short 0x6306
        if (!ZeroFlag)
        {
            goto label_100D_6306_163D6_34866;
        }
    label_100D_62FB_163CB_28835:
        CheckExternalEvents(cs1, 0x62FB);
        // 100D:62FB mov SI,word ptr DS:[SI+4]
        SI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        return unknown_100D_62FE_163CE(0x0000);
    label_100D_6306_163D6_34866:
        CheckExternalEvents(cs1, 0x6306);
        // 100D:6306 mov DX,word ptr DS:[SI+6]
        DX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:6309 mov BX,word ptr DS:[SI+8]
        BX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:630C call near 0x62D6
        NearCall(cs1, 0x630F, map_position_to_screen_if_visible);
    label_100D_630F_163DF_34870:
        CheckExternalEvents(cs1, 0x630F);
        // 100D:630F mov AX,0x0036
        AX = (ushort)0x0036;
        // 100D:6312 jmp short 0x6322
        return unknown_100D_62F1_163C1(0x6322);
    }

    public virtual Action unknown_100D_62FE_163CE(int loadOffset)
    {
    label_100D_62FE_163CE_28837:
        CheckExternalEvents(cs1, 0x62FE);
        // 100D:62FE call near 0x62C9
        NearCall(cs1, 0x6301, location_visible_on_map);
    label_100D_6301_163D1_28838:
        CheckExternalEvents(cs1, 0x6301);
        // 100D:6301 mov AX,0x0036
        AX = (ushort)0x0036;
        // 100D:6304 jmp short 0x6322
        return unknown_100D_62F1_163C1(0x6322);
    }

    public virtual Action map_draw_player_position_sprite(int loadOffset)
    {
    label_100D_6314_163E4_18189:
        CheckExternalEvents(cs1, 0x6314);
        // 100D:6314 call near 0x407E
        NearCall(cs1, 0x6317, get_map_position);
    label_100D_6317_163E7_18191:
        CheckExternalEvents(cs1, 0x6317);
        // 100D:6317 call near 0x62D6
        NearCall(cs1, 0x631A, map_position_to_screen_if_visible);
    label_100D_631A_163EA_18193:
        CheckExternalEvents(cs1, 0x631A);
        // 100D:631A mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:631D pushf
        Stack.Push16(FlagRegister16);
        // 100D:631E sub DX,0x000D
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)13)));
    label_100D_6321_163F1_18197:
        CheckExternalEvents(cs1, 0x6321);
        // 100D:6321 popf
        FlagRegister16 = Stack.Pop16();
        return unknown_100D_62F1_163C1(0x6322);
    }

    public virtual Action map_draw_vegetation_marks(int loadOffset)
    {
    label_100D_633B_1640B_17959:
        CheckExternalEvents(cs1, 0x633B);
        // 100D:633B mov DX,word ptr DS:[0x197C]
        DX = UInt16[DS, (ushort)0x197C];
        // 100D:633F mov BX,word ptr DS:[0x197E]
        BX = UInt16[DS, (ushort)0x197E];
        // 100D:6343 sub BX,0x0012
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)18)));
    label_100D_6346_16416_17963:
        CheckExternalEvents(cs1, 0x6346);
        // 100D:6346 call near 0x634D
        NearCall(cs1, 0x6349, map_draw_vegetation_marks_row);
    label_100D_6349_16419_18083:
        CheckExternalEvents(cs1, 0x6349);
        // 100D:6349 inc BX
        BX = Alu16.Inc(BX);
        // 100D:634A jae short 0x6346
        if (!CarryFlag)
        {
            goto label_100D_6346_16416_17963;
        }
    label_100D_634C_1641C_18089:
        CheckExternalEvents(cs1, 0x634C);
        // 100D:634C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_draw_vegetation_marks_row(int loadOffset)
    {
    label_100D_634D_1641D_17964:
        CheckExternalEvents(cs1, 0x634D);
        // 100D:634D push BX
        Stack.Push16(BX);
        // 100D:634E push DX
        Stack.Push16(DX);
        // 100D:634F call near 0x62D6
        NearCall(cs1, 0x6352, map_position_to_screen_if_visible);
    label_100D_6352_16422_18013:
        CheckExternalEvents(cs1, 0x6352);
        // 100D:6352 pop SI
        SI = Stack.Pop16();
        // 100D:6353 pop CX
        CX = Stack.Pop16();
        // 100D:6354 jb short 0x6369
        if (CarryFlag)
        {
            goto label_100D_6369_16439_18082;
        }
    label_100D_6356_16426_18017:
        CheckExternalEvents(cs1, 0x6356);
        // 100D:6356 push BX
        Stack.Push16(BX);
        // 100D:6357 push CX
        Stack.Push16(CX);
        // 100D:6358 push DX
        Stack.Push16(DX);
        // 100D:6359 push SI
        Stack.Push16(SI);
        // 100D:635A call near 0x636A
        NearCall(cs1, 0x635D, unknown_100D_636A_1643A);
    label_100D_635D_1642D_18046:
        CheckExternalEvents(cs1, 0x635D);
        // 100D:635D pop SI
        SI = Stack.Pop16();
        // 100D:635E pop DX
        DX = Stack.Pop16();
        // 100D:635F pop CX
        CX = Stack.Pop16();
        // 100D:6360 pop BX
        BX = Stack.Pop16();
        // 100D:6361 push CX
        Stack.Push16(CX);
        // 100D:6362 push SI
        Stack.Push16(SI);
        // 100D:6363 call near 0x639A
        NearCall(cs1, 0x6366, unknown_100D_639A_1646A);
    label_100D_6366_16436_18078:
        CheckExternalEvents(cs1, 0x6366);
        // 100D:6366 pop DX
        DX = Stack.Pop16();
        // 100D:6367 pop BX
        BX = Stack.Pop16();
        // 100D:6368 clc
        CarryFlag = false;
    label_100D_6369_16439_18082:
        CheckExternalEvents(cs1, 0x6369);
        // 100D:6369 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_636A_1643A(int loadOffset)
    {
    label_100D_636A_1643A_18023:
        CheckExternalEvents(cs1, 0x636A);
        // 100D:636A xchg DX,SI
        ushort temp_100D_636A_1643A = DX;
        DX = SI;
        SI = unchecked((ushort)temp_100D_636A_1643A);
        // 100D:636C xchg BX,CX
        ushort temp_100D_636C_1643C = BX;
        BX = CX;
        CX = unchecked((ushort)temp_100D_636C_1643C);
        // 100D:636E call near 0xB58B
        NearCall(cs1, 0x6371, map_position_to_offset);
    label_100D_6371_16441_18027:
        CheckExternalEvents(cs1, 0x6371);
        // 100D:6371 xchg DX,SI
        ushort temp_100D_6371_16441 = DX;
        DX = SI;
        SI = unchecked((ushort)temp_100D_6371_16441);
        // 100D:6373 mov BX,CX
        BX = CX;
    label_100D_6375_16445_18030:
        CheckExternalEvents(cs1, 0x6375);
        // 100D:6375 mov AX,word ptr ES:[DI]
        AX = UInt16[ES, DI];
        // 100D:6378 and AX,0x3030
        AX = Alu16.And(AX, (ushort)0x3030);
        // 100D:637B cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:637D je short 0x6395
        if (ZeroFlag)
        {
            goto label_100D_6395_16465_40809;
        }
    label_100D_637F_1644F_18034:
        CheckExternalEvents(cs1, 0x637F);
        // 100D:637F add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:6382 cmp DX,word ptr DS:[0x46E7]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E7]);
        // 100D:6386 jae short 0x6394
        if (!CarryFlag)
        {
            return unknown_100D_6394_16464(0x0000);
        }
    label_100D_6388_16458_18038:
        CheckExternalEvents(cs1, 0x6388);
        // 100D:6388 inc DI
        DI = Alu16.Inc(DI);
        // 100D:6389 inc SI
        SI = Alu16.Inc(SI);
        // 100D:638A cmp SI,BP
        Alu16.Sub(SI, BP);
        // 100D:638C jb short 0x6375
        if (CarryFlag)
        {
            goto label_100D_6375_16445_18030;
        }
    label_100D_638E_1645E_34094:
        CheckExternalEvents(cs1, 0x638E);
        // 100D:638E sub SI,BP
        SI = Alu16.Sub(SI, BP);
        // 100D:6390 sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 100D:6392 jmp short 0x6375
        goto label_100D_6375_16445_18030;
    label_100D_6395_16465_40809:
        CheckExternalEvents(cs1, 0x6395);
        // 100D:6395 call near 0x63C7
        NearCall(cs1, 0x6398, unknown_100D_63C7_16497);
    label_100D_6398_16468_40865:
        CheckExternalEvents(cs1, 0x6398);
        // 100D:6398 jmp short 0x637F
        goto label_100D_637F_1644F_18034;
    }

    public virtual Action unknown_100D_639A_1646A(int loadOffset)
    {
    label_100D_639A_1646A_18054:
        CheckExternalEvents(cs1, 0x639A);
        // 100D:639A xchg DX,SI
        ushort temp_100D_639A_1646A = DX;
        DX = SI;
        SI = unchecked((ushort)temp_100D_639A_1646A);
        // 100D:639C xchg BX,CX
        ushort temp_100D_639C_1646C = BX;
        BX = CX;
        CX = unchecked((ushort)temp_100D_639C_1646C);
        // 100D:639E call near 0xB58B
        NearCall(cs1, 0x63A1, map_position_to_offset);
    label_100D_63A1_16471_18058:
        CheckExternalEvents(cs1, 0x63A1);
        // 100D:63A1 xchg DX,SI
        ushort temp_100D_63A1_16471 = DX;
        DX = SI;
        SI = unchecked((ushort)temp_100D_63A1_16471);
        // 100D:63A3 mov BX,CX
        BX = CX;
    label_100D_63A5_16475_18061:
        CheckExternalEvents(cs1, 0x63A5);
        // 100D:63A5 mov AX,word ptr ES:[DI]
        AX = UInt16[ES, DI];
        // 100D:63A8 and AX,0x3030
        AX = Alu16.And(AX, (ushort)0x3030);
        // 100D:63AB cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:63AD je short 0x63C2
        if (ZeroFlag)
        {
            goto label_100D_63C2_16492_40976;
        }
    label_100D_63AF_1647F_18065:
        CheckExternalEvents(cs1, 0x63AF);
        // 100D:63AF sub DX,4
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:63B2 cmp DX,word ptr DS:[0x46E3]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E3]);
        // 100D:63B6 jb short 0x6394
        if (CarryFlag)
        {
            return unknown_100D_6394_16464(0x0000);
        }
    label_100D_63B8_16488_18069:
        CheckExternalEvents(cs1, 0x63B8);
        // 100D:63B8 dec DI
        DI = Alu16.Dec(DI);
        // 100D:63B9 dec SI
        SI = Alu16.Dec(SI);
        // 100D:63BA jns short 0x63A5
        if (!SignFlag)
        {
            goto label_100D_63A5_16475_18061;
        }
    label_100D_63BC_1648C_18074:
        CheckExternalEvents(cs1, 0x63BC);
        // 100D:63BC add SI,BP
        SI = Alu16.Add(SI, BP);
        // 100D:63BE add DI,BP
        DI = Alu16.Add(DI, BP);
        // 100D:63C0 jmp short 0x63A5
        goto label_100D_63A5_16475_18061;
    label_100D_63C2_16492_40976:
        CheckExternalEvents(cs1, 0x63C2);
        // 100D:63C2 call near 0x63C7
        NearCall(cs1, 0x63C5, unknown_100D_63C7_16497);
    label_100D_63C5_16495_40979:
        CheckExternalEvents(cs1, 0x63C5);
        // 100D:63C5 jmp short 0x63AF
        goto label_100D_63AF_1647F_18065;
    }

    public virtual Action unknown_100D_63C7_16497(int loadOffset)
    {
    label_100D_63C7_16497_40810:
        CheckExternalEvents(cs1, 0x63C7);
        // 100D:63C7 push BX
        Stack.Push16(BX);
        // 100D:63C8 push DX
        Stack.Push16(DX);
        // 100D:63C9 push SI
        Stack.Push16(SI);
        // 100D:63CA push DI
        Stack.Push16(DI);
        // 100D:63CB push BP
        Stack.Push16(BP);
        // 100D:63CC push ES
        Stack.Push16(ES);
        // 100D:63CD cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 100D:63D0 mov AX,0x0078
        AX = (ushort)0x0078;
        // 100D:63D3 jne short 0x63D6
        if (!ZeroFlag)
        {
            goto label_100D_63D6_164A6_40821;
        }
    label_100D_63D5_164A5_40823:
        CheckExternalEvents(cs1, 0x63D5);
        VerifySpeculativeEntryOrFail(cs1, 0x63D5, [(byte)0x40]);
        // 100D:63D5 inc AX
        AX = Alu16.Inc(AX);
    label_100D_63D6_164A6_40821:
        CheckExternalEvents(cs1, 0x63D6);
        // 100D:63D6 add BP,DI
        BP = Alu16.Add(BP, DI);
        // 100D:63D8 and DI,3
        DI = Alu16.And(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:63DB shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:63DD shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:63DF and BP,3
        BP = Alu16.And(BP, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:63E2 add BX,DI
        BX = Alu16.Add(BX, DI);
        // 100D:63E4 add DX,BP
        DX = Alu16.Add(DX, BP);
        // 100D:63E6 call near 0xC343
        NearCall(cs1, 0x63E9, draw_sprite_centered_clipped);
    label_100D_63E9_164B9_40851:
        CheckExternalEvents(cs1, 0x63E9);
        // 100D:63E9 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:63EA pop BP
        BP = Stack.Pop16();
        // 100D:63EB pop DI
        DI = Stack.Pop16();
        // 100D:63EC pop SI
        SI = Stack.Pop16();
        // 100D:63ED pop DX
        DX = Stack.Pop16();
        // 100D:63EE pop BX
        BX = Stack.Pop16();
        // 100D:63EF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action locations_new_day_ecology_walk(int loadOffset)
    {
    label_100D_63F0_164C0_15139:
        CheckExternalEvents(cs1, 0x63F0);
        // 100D:63F0 cmp byte ptr DS:[0x46DE],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DE], (byte)0x00);
        // 100D:63F5 je short 0x642D
        if (ZeroFlag)
        {
            goto label_100D_642D_164FD_15142;
        }
    label_100D_63F7_164C7_26847:
        CheckExternalEvents(cs1, 0x63F7);
        // 100D:63F7 mov ES,word ptr DS:[0xDD00]
        ES = UInt16[DS, (ushort)0xDD00];
        // 100D:63FB mov DI,0x0100
        DI = (ushort)0x0100;
    label_100D_63FE_164CE_26850:
        CheckExternalEvents(cs1, 0x63FE);
        // 100D:63FE mov AL,byte ptr DS:[DI+0x0A]
        AL = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:6401 test AL,0x20
        Alu8.And(AL, (byte)0x20);
        // 100D:6403 je short 0x6422
        if (ZeroFlag)
        {
            goto label_100D_6422_164F2_26853;
        }
    label_100D_6405_164D5_26858:
        CheckExternalEvents(cs1, 0x6405);
        // 100D:6405 mov BL,byte ptr DS:[DI+0x1B]
        BL = UInt8[DS, (ushort)(DI + (sbyte)27)];
        // 100D:6408 mov BH,0xFA
        BH = (byte)0xFA;
        // 100D:640A cmp BL,BH
        Alu8.Sub(BL, BH);
        // 100D:640C jae short 0x6422
        if (!CarryFlag)
        {
            goto label_100D_6422_164F2_26853;
        }
    label_100D_640E_164DE_26863:
        CheckExternalEvents(cs1, 0x640E);
        // 100D:640E mov SI,word ptr DS:[DI+6]
        SI = UInt16[DS, (ushort)(DI + (sbyte)6)];
        // 100D:6411 call near 0x642E
        NearCall(cs1, 0x6414, unknown_100D_642E_164FE);
    label_100D_6414_164E4_26882:
        CheckExternalEvents(cs1, 0x6414);
        // 100D:6414 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:6416 inc DX
        DX = Alu16.Inc(DX);
        // 100D:6417 add BL,DL
        BL = Alu8.Add(BL, DL);
        // 100D:6419 cmp BL,BH
        Alu8.Sub(BL, BH);
        // 100D:641B jb short 0x641F
        if (CarryFlag)
        {
            goto label_100D_641F_164EF_26888;
        }
    label_100D_641D_164ED_39676:
        CheckExternalEvents(cs1, 0x641D);
        // 100D:641D mov BL,BH
        BL = BH;
    label_100D_641F_164EF_26888:
        CheckExternalEvents(cs1, 0x641F);
        // 100D:641F mov byte ptr DS:[DI+0x1B],BL
        UInt8[DS, (ushort)(DI + (sbyte)27)] = BL;
    label_100D_6422_164F2_26853:
        CheckExternalEvents(cs1, 0x6422);
        // 100D:6422 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:6425 cmp word ptr DS:[DI],-1
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:6428 jne short 0x63FE
        if (!ZeroFlag)
        {
            goto label_100D_63FE_164CE_26850;
        }
    label_100D_642A_164FA_26890:
        CheckExternalEvents(cs1, 0x642A);
        // 100D:642A jmp near 0x65B6
        goto label_100D_65B6_16686_26892;
    label_100D_642D_164FD_15142:
        CheckExternalEvents(cs1, 0x642D);
        // 100D:642D ret near
        return NearRet((ushort)0x0000);
    label_100D_65B6_16686_26892:
        CheckExternalEvents(cs1, 0x65B6);
        // 100D:65B6 mov ES,word ptr DS:[0xDD00]
        ES = UInt16[DS, (ushort)0xDD00];
        // 100D:65BA mov SI,word ptr CS:[0x65B4]
        SI = UInt16[CS, (ushort)0x65B4];
        // 100D:65BF xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:65C1 mov CX,0x0046
        CX = (ushort)0x0046;
    label_100D_65C4_16694_26897:
        CheckExternalEvents(cs1, 0x65C4);
        // 100D:65C4 shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 100D:65C6 jae short 0x65CC
        if (!CarryFlag)
        {
            goto label_100D_65CC_1669C_26901;
        }
    label_100D_65C8_16698_26899:
        CheckExternalEvents(cs1, 0x65C8);
        // 100D:65C8 xor SI,0x0402
        SI = Alu16.Xor(SI, (ushort)0x0402);
    label_100D_65CC_1669C_26901:
        CheckExternalEvents(cs1, 0x65CC);
        // 100D:65CC mov DI,SI
        DI = SI;
    label_100D_65CE_1669E_26902:
        CheckExternalEvents(cs1, 0x65CE);
        // 100D:65CE mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:65D1 mov AH,AL
        AH = AL;
        // 100D:65D3 and AH,0x30
        AH = Alu8.And(AH, (byte)0x30);
        // 100D:65D6 cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 100D:65D9 jne short 0x65E2
        if (!ZeroFlag)
        {
            goto label_100D_65E2_166B2_26907;
        }
    label_100D_65DB_166AB_40988:
        CheckExternalEvents(cs1, 0x65DB);
        // 100D:65DB and AL,0xCF
        AL = Alu8.And(AL, (byte)0xCF);
        // 100D:65DD or AL,0x20
        AL = Alu8.Or(AL, (byte)0x20);
        // 100D:65DF stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:65E0 dec DI
        DI = Alu16.Dec(DI);
        // 100D:65E1 inc BP
        BP = Alu16.Inc(BP);
    label_100D_65E2_166B2_26907:
        CheckExternalEvents(cs1, 0x65E2);
        // 100D:65E2 add DI,0x07FF
        DI = Alu16.Add(DI, (ushort)0x07FF);
        // 100D:65E6 cmp DI,0xC5F9
        Alu16.Sub(DI, (ushort)0xC5F9);
        // 100D:65EA jb short 0x65CE
        if (CarryFlag)
        {
            goto label_100D_65CE_1669E_26902;
        }
    label_100D_65EC_166BC_26912:
        CheckExternalEvents(cs1, 0x65EC);
        // 100D:65EC loop 0x65C4
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_65C4_16694_26897;
        }
    label_100D_65EE_166BE_26916:
        CheckExternalEvents(cs1, 0x65EE);
        // 100D:65EE mov word ptr CS:[0x65B4],SI
        UInt16[CS, (ushort)0x65B4] = SI;
        // 100D:65F3 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:65F5 je short 0x6602
        if (ZeroFlag)
        {
            goto label_100D_6602_166D2_26920;
        }
    label_100D_65F7_166C7_40999:
        CheckExternalEvents(cs1, 0x65F7);
        // 100D:65F7 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:65FC jns short 0x6602
        if (!SignFlag)
        {
            goto label_100D_6602_166D2_26920;
        }
    label_100D_65FE_166CE_41003:
        CheckExternalEvents(cs1, 0x65FE);
        VerifySpeculativeEntryOrFail(cs1, 0x65FE, [(byte)0xFE, (byte)0x06, (byte)0xEC, (byte)0x46]);
        // 100D:65FE inc byte ptr DS:[0x46EC]
        UInt8[DS, (ushort)0x46EC] = Alu8.Inc(UInt8[DS, (ushort)0x46EC]);
    label_100D_6602_166D2_26920:
        CheckExternalEvents(cs1, 0x6602);
        // 100D:6602 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_642E_164FE(int loadOffset)
    {
    label_100D_642E_164FE_26866:
        CheckExternalEvents(cs1, 0x642E);
        // 100D:642E mov CX,3
        CX = (ushort)0x0003;
        // 100D:6431 dec SI
        SI = Alu16.Dec(SI);
        // 100D:6432 xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_100D_6434_16504_26870:
        CheckExternalEvents(cs1, 0x6434);
        // 100D:6434 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:6436 and AX,0x3030
        AX = Alu16.And(AX, (ushort)0x3030);
        // 100D:6439 cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 100D:643C jne short 0x643F
        if (!ZeroFlag)
        {
            goto label_100D_643F_1650F_26874;
        }
    label_100D_643E_1650E_40892:
        CheckExternalEvents(cs1, 0x643E);
        // 100D:643E inc DX
        DX = Alu16.Inc(DX);
    label_100D_643F_1650F_26874:
        CheckExternalEvents(cs1, 0x643F);
        // 100D:643F cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:6441 jne short 0x6444
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6441");
        }
    label_100D_6444_16514_26877:
        CheckExternalEvents(cs1, 0x6444);
        // 100D:6444 loop 0x6434
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6434_16504_26870;
        }
    label_100D_6446_16516_26880:
        CheckExternalEvents(cs1, 0x6446);
        // 100D:6446 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6447_16517(int loadOffset)
    {
    entrydispatcher:
    label_100D_6447_16517_34509:
        CheckExternalEvents(cs1, 0x6447);
        // 100D:6447 mov byte ptr DS:[0x4739],0x30
        UInt8[DS, (ushort)0x4739] = (byte)0x30;
        // 100D:644C jmp short 0x6458
        if (JumpDispatcher.Jump(unknown_100D_6458_16528, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_644E_1651E(int loadOffset)
    {
    entrydispatcher:
    label_100D_644E_1651E_23274:
        CheckExternalEvents(cs1, 0x644E);
        // 100D:644E mov byte ptr DS:[0x4739],0x20
        UInt8[DS, (ushort)0x4739] = (byte)0x20;
        // 100D:6453 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:6455 mov CL,byte ptr DS:[DI+0x0B]
        CL = UInt8[DS, (ushort)(DI + (sbyte)11)];
        if (JumpDispatcher.Jump(unknown_100D_6458_16528, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_646F_1653F(int loadOffset)
    {
    label_100D_646F_1653F_23319:
        CheckExternalEvents(cs1, 0x646F);
        // 100D:646F add BX,word ptr DS:[0xD818]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0xD818]);
        // 100D:6473 cmp BX,0x005D
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)93)));
        // 100D:6476 jg short 0x64B1
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_64B1_16581_23350;
        }
    label_100D_6478_16548_23323:
        CheckExternalEvents(cs1, 0x6478);
        // 100D:6478 cmp BX,-93
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-93)));
        // 100D:647B jl short 0x64B1
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_64B1_16581_23350;
        }
    label_100D_647D_1654D_23326:
        CheckExternalEvents(cs1, 0x647D);
        // 100D:647D push DX
        Stack.Push16(DX);
        // 100D:647E mov DX,word ptr DS:[0xD81C]
        DX = UInt16[DS, (ushort)0xD81C];
        // 100D:6482 call near 0xB58B
        NearCall(cs1, 0x6485, map_position_to_offset);
    label_100D_6485_16555_23330:
        CheckExternalEvents(cs1, 0x6485);
        // 100D:6485 pop AX
        AX = Stack.Pop16();
        // 100D:6486 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:6488 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:648A jns short 0x6492
        if (!SignFlag)
        {
            goto label_100D_6492_16562_23335;
        }
    label_100D_648C_1655C_35978:
        CheckExternalEvents(cs1, 0x648C);
        // 100D:648C add DI,BP
        DI = Alu16.Add(DI, BP);
        // 100D:648E add DX,BP
        DX = Alu16.Add(DX, BP);
        // 100D:6490 js short 0x648C
        if (SignFlag)
        {
            goto label_100D_648C_1655C_35978;
        }
    label_100D_6492_16562_23335:
        CheckExternalEvents(cs1, 0x6492);
        // 100D:6492 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:6495 mov AH,AL
        AH = AL;
        // 100D:6497 and AH,0x30
        AH = Alu8.And(AH, (byte)0x30);
        // 100D:649A cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 100D:649D je short 0x64A5
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:649D");
        }
    label_100D_649F_1656F_23341:
        CheckExternalEvents(cs1, 0x649F);
        // 100D:649F xor AL,AH
        AL = Alu8.Xor(AL, AH);
        // 100D:64A1 or AL,byte ptr DS:[0x4739]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0x4739]);
        // 100D:64A5 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:64A6 inc DX
        DX = Alu16.Inc(DX);
        // 100D:64A7 cmp DX,BP
        Alu16.Sub(DX, BP);
        // 100D:64A9 jb short 0x64AF
        if (CarryFlag)
        {
            goto label_100D_64AF_1657F_23348;
        }
    label_100D_64AB_1657B_35982:
        CheckExternalEvents(cs1, 0x64AB);
        // 100D:64AB sub DX,BP
        DX = Alu16.Sub(DX, BP);
        // 100D:64AD sub DI,BP
        DI = Alu16.Sub(DI, BP);
    label_100D_64AF_1657F_23348:
        CheckExternalEvents(cs1, 0x64AF);
        // 100D:64AF loop 0x6492
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6492_16562_23335;
        }
    label_100D_64B1_16581_23350:
        CheckExternalEvents(cs1, 0x64B1);
        // 100D:64B1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_64B2_16582(int loadOffset)
    {
    entrydispatcher:
    label_100D_64B2_16582_23284:
        CheckExternalEvents(cs1, 0x64B2);
        // 100D:64B2 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:64B4 mov DX,BX
        DX = BX;
        // 100D:64B6 mov DI,DX
        DI = DX;
        // 100D:64B8 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:64BA mov SI,CX
        SI = CX;
        // 100D:64BC dec SI
        SI = Alu16.Dec(SI);
        // 100D:64BD mov AX,CX
        AX = CX;
        // 100D:64BF xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:64C1 jmp short 0x64C6
        goto label_100D_64C6_16596_23294;
    label_100D_64C3_16593_23297:
        CheckExternalEvents(cs1, 0x64C3);
        // 100D:64C3 inc BP
        BP = Alu16.Inc(BP);
        // 100D:64C4 inc DX
        DX = Alu16.Inc(DX);
        // 100D:64C5 dec DI
        DI = Alu16.Dec(DI);
    label_100D_64C6_16596_23294:
        CheckExternalEvents(cs1, 0x64C6);
        // 100D:64C6 sub AX,BP
        AX = Alu16.Sub(AX, BP);
        // 100D:64C8 jns short 0x64C3
        if (!SignFlag)
        {
            goto label_100D_64C3_16593_23297;
        }
    label_100D_64CA_1659A_23301:
        CheckExternalEvents(cs1, 0x64CA);
        // 100D:64CA call near 0x64EF
        NearCall(cs1, 0x64CD, unknown_100D_64EF_165BF);
    label_100D_64CD_1659D_23366:
        CheckExternalEvents(cs1, 0x64CD);
        // 100D:64CD inc BX
        BX = Alu16.Inc(BX);
        // 100D:64CE dec SI
        SI = Alu16.Dec(SI);
        // 100D:64CF add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:64D1 js short 0x64D5
        if (SignFlag)
        {
            goto label_100D_64D5_165A5_23373;
        }
    label_100D_64D3_165A3_23371:
        CheckExternalEvents(cs1, 0x64D3);
        // 100D:64D3 loop 0x64C3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_64C3_16593_23297;
        }
    label_100D_64D5_165A5_23373:
        CheckExternalEvents(cs1, 0x64D5);
        // 100D:64D5 inc BP
        BP = Alu16.Inc(BP);
        // 100D:64D6 dec CX
        CX = Alu16.Dec(CX);
        // 100D:64D7 jmp short 0x64DE
        goto label_100D_64DE_165AE_23377;
    label_100D_64D9_165A9_30577:
        CheckExternalEvents(cs1, 0x64D9);
        // 100D:64D9 inc DX
        DX = Alu16.Inc(DX);
        // 100D:64DA dec DI
        DI = Alu16.Dec(DI);
        // 100D:64DB sub AX,BP
        AX = Alu16.Sub(AX, BP);
        // 100D:64DD inc BP
        BP = Alu16.Inc(BP);
    label_100D_64DE_165AE_23377:
        CheckExternalEvents(cs1, 0x64DE);
        // 100D:64DE call near 0x64EF
        NearCall(cs1, 0x64E1, unknown_100D_64EF_165BF);
    label_100D_64E1_165B1_23379:
        CheckExternalEvents(cs1, 0x64E1);
        // 100D:64E1 inc BX
        BX = Alu16.Inc(BX);
        // 100D:64E2 dec SI
        SI = Alu16.Dec(SI);
        // 100D:64E3 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:64E5 jb short 0x64E9
        if (CarryFlag)
        {
            goto label_100D_64E9_165B9_23386;
        }
    label_100D_64E7_165B7_23384:
        CheckExternalEvents(cs1, 0x64E7);
        // 100D:64E7 loop 0x64DE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_64DE_165AE_23377;
        }
    label_100D_64E9_165B9_23386:
        CheckExternalEvents(cs1, 0x64E9);
        // 100D:64E9 dec CX
        CX = Alu16.Dec(CX);
        // 100D:64EA jns short 0x64D9
        if (!SignFlag)
        {
            goto label_100D_64D9_165A9_30577;
        }
    label_100D_64EC_165BC_23389:
        CheckExternalEvents(cs1, 0x64EC);
        // 100D:64EC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_64EF_165BF(int loadOffset)
    {
    label_100D_64EF_165BF_23303:
        CheckExternalEvents(cs1, 0x64EF);
        // 100D:64EF push AX
        Stack.Push16(AX);
        // 100D:64F0 push BX
        Stack.Push16(BX);
        // 100D:64F1 push CX
        Stack.Push16(CX);
        // 100D:64F2 push DX
        Stack.Push16(DX);
        // 100D:64F3 push SI
        Stack.Push16(SI);
        // 100D:64F4 push DI
        Stack.Push16(DI);
        // 100D:64F5 push BP
        Stack.Push16(BP);
        // 100D:64F6 mov CX,DX
        CX = DX;
        // 100D:64F8 sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:64FA inc CX
        CX = Alu16.Inc(CX);
        // 100D:64FB mov DX,DI
        DX = DI;
        // 100D:64FD push SI
        Stack.Push16(SI);
        // 100D:64FE push CX
        Stack.Push16(CX);
        // 100D:64FF push DX
        Stack.Push16(DX);
        // 100D:6500 call near word ptr CS:[0x64ED]
        switch ((ushort)(UInt16[CS, (ushort)0x64ED]))
        {
            case 0x646F:
                NearCall(cs1, 0x6505, unknown_100D_646F_1653F);
                break;
            case 0x653A:
                NearCall(cs1, 0x6505, unknown_100D_653A_1660A);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x64ED])):X4} at 100D:6500");
        }
    label_100D_6505_165D5_23352:
        CheckExternalEvents(cs1, 0x6505);
        // 100D:6505 pop DX
        DX = Stack.Pop16();
        // 100D:6506 pop CX
        CX = Stack.Pop16();
        // 100D:6507 pop BX
        BX = Stack.Pop16();
        // 100D:6508 call near word ptr CS:[0x64ED]
        switch ((ushort)(UInt16[CS, (ushort)0x64ED]))
        {
            case 0x646F:
                NearCall(cs1, 0x650D, unknown_100D_646F_1653F);
                break;
            case 0x653A:
                NearCall(cs1, 0x650D, unknown_100D_653A_1660A);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x64ED])):X4} at 100D:6508");
        }
    label_100D_650D_165DD_23357:
        CheckExternalEvents(cs1, 0x650D);
        // 100D:650D pop BP
        BP = Stack.Pop16();
        // 100D:650E pop DI
        DI = Stack.Pop16();
        // 100D:650F pop SI
        SI = Stack.Pop16();
        // 100D:6510 pop DX
        DX = Stack.Pop16();
        // 100D:6511 pop CX
        CX = Stack.Pop16();
        // 100D:6512 pop BX
        BX = Stack.Pop16();
        // 100D:6513 pop AX
        AX = Stack.Pop16();
        // 100D:6514 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6515_165E5(int loadOffset)
    {
    entrydispatcher:
    label_100D_6515_165E5_40635:
        CheckExternalEvents(cs1, 0x6515);
        // 100D:6515 call near 0x5D50
        NearCall(cs1, 0x6518, location_mark_map_view_dirty);
    label_100D_6518_165E8_40652:
        CheckExternalEvents(cs1, 0x6518);
        // 100D:6518 mov byte ptr DS:[0x4736],0x44
        UInt8[DS, (ushort)0x4736] = (byte)0x44;
        // 100D:651D xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:651F mov CL,byte ptr DS:[DI+0x0B]
        CL = UInt8[DS, (ushort)(DI + (sbyte)11)];
        // 100D:6522 mov word ptr CS:[0x64ED],0x653A
        UInt16[CS, (ushort)0x64ED] = (ushort)0x653A;
        // 100D:6529 mov AX,word ptr DS:[DI+0x0C]
        AX = UInt16[DS, (ushort)(DI + (sbyte)12)];
        // 100D:652C mov word ptr DS:[0xD81C],AX
        UInt16[DS, (ushort)0xD81C] = AX;
        // 100D:652F mov AX,word ptr DS:[DI+0x0E]
        AX = UInt16[DS, (ushort)(DI + (sbyte)14)];
        // 100D:6532 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:6533 mov word ptr DS:[0xD818],AX
        UInt16[DS, (ushort)0xD818] = AX;
        // 100D:6536 call near 0x64B2
        NearCall(cs1, 0x6539, unknown_100D_64B2_16582);
    label_100D_6539_16609_40804:
        CheckExternalEvents(cs1, 0x6539);
        // 100D:6539 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_653A_1660A(int loadOffset)
    {
    label_100D_653A_1660A_40673:
        CheckExternalEvents(cs1, 0x653A);
        // 100D:653A add BX,word ptr DS:[0xD818]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0xD818]);
        // 100D:653E cmp BX,0x0056
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)86)));
        // 100D:6541 jg short 0x65B3
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_65B3_16683_40677;
        }
    label_100D_6543_16613_40679:
        CheckExternalEvents(cs1, 0x6543);
        // 100D:6543 cmp BX,-86
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-86)));
        // 100D:6546 jl short 0x65B3
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_65B3_16683_40677;
        }
    label_100D_6548_16618_40683:
        CheckExternalEvents(cs1, 0x6548);
        // 100D:6548 push DX
        Stack.Push16(DX);
        // 100D:6549 mov DX,word ptr DS:[0xD81C]
        DX = UInt16[DS, (ushort)0xD81C];
        // 100D:654D call near 0xB58B
        NearCall(cs1, 0x6550, map_position_to_offset);
    label_100D_6550_16620_40695:
        CheckExternalEvents(cs1, 0x6550);
        // 100D:6550 pop AX
        AX = Stack.Pop16();
        // 100D:6551 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:6553 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:6555 jns short 0x655D
        if (!SignFlag)
        {
            goto label_100D_655D_1662D_40700;
        }
    label_100D_6557_16627_40702:
        CheckExternalEvents(cs1, 0x6557);
        VerifySpeculativeEntryOrFail(cs1, 0x6557, [(byte)0x03, (byte)0xFD]);
        // 100D:6557 add DI,BP
        DI = Alu16.Add(DI, BP);
        VerifySpeculativeEntryOrFail(cs1, 0x6559, [(byte)0x03, (byte)0xD5]);
        // 100D:6559 add DX,BP
        DX = Alu16.Add(DX, BP);
        VerifySpeculativeEntryOrFail(cs1, 0x655B, [(byte)0x78, (byte)0xFA]);
        // 100D:655B js short 0x6557
        if (SignFlag)
        {
            goto label_100D_6557_16627_40702;
        }
    label_100D_655D_1662D_40700:
        CheckExternalEvents(cs1, 0x655D);
        // 100D:655D mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:6560 mov AH,AL
        AH = AL;
        // 100D:6562 and AL,0x30
        AL = Alu8.And(AL, (byte)0x30);
        // 100D:6564 cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:6566 mov AL,AH
        AL = AH;
        // 100D:6568 je short 0x65A7
        if (ZeroFlag)
        {
            goto label_100D_65A7_16677_40713;
        }
    label_100D_656A_1663A_40715:
        CheckExternalEvents(cs1, 0x656A);
        // 100D:656A test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:656C je short 0x6593
        if (ZeroFlag)
        {
            goto label_100D_6593_16663_40720;
        }
    label_100D_656E_1663E_40722:
        CheckExternalEvents(cs1, 0x656E);
        // 100D:656E call near 0x409A
        NearCall(cs1, 0x6571, find_location_by_map_offset);
    label_100D_6571_16641_40772:
        CheckExternalEvents(cs1, 0x6571);
        // 100D:6571 jne short 0x6593
        if (!ZeroFlag)
        {
            goto label_100D_6593_16663_40720;
        }
    label_100D_6573_16643_40775:
        CheckExternalEvents(cs1, 0x6573);
        // 100D:6573 mov byte ptr DS:[SI+0x12],0
        UInt8[DS, (ushort)(SI + (sbyte)18)] = (byte)0x00;
        // 100D:6577 call near 0xE270
        NearCall(cs1, 0x657A, unknown_100D_E270_1E340);
    label_100D_657A_1664A_40781:
        CheckExternalEvents(cs1, 0x657A);
        // 100D:657A push ES
        Stack.Push16(ES);
        // 100D:657B mov DI,SI
        DI = SI;
        // 100D:657D call near 0x5D36
        NearCall(cs1, 0x6580, location_is_atreides);
    label_100D_6580_16650_40788:
        CheckExternalEvents(cs1, 0x6580);
        // 100D:6580 jb short 0x658F
        if (CarryFlag)
        {
            goto label_100D_658F_1665F_40789;
        }
    label_100D_6582_16652_40792:
        CheckExternalEvents(cs1, 0x6582);
        VerifySpeculativeEntryOrFail(cs1, 0x6582, [(byte)0x81, (byte)0xFF, (byte)0x38, (byte)0x01]);
        // 100D:6582 cmp DI,0x0138
        Alu16.Sub(DI, (ushort)0x0138);
        VerifySpeculativeEntryOrFail(cs1, 0x6586, [(byte)0x72, (byte)0x07]);
        // 100D:6586 jb short 0x658F
        if (CarryFlag)
        {
            goto label_100D_658F_1665F_40789;
        }
    label_100D_6588_16658_40798:
        CheckExternalEvents(cs1, 0x6588);
        VerifySpeculativeEntryOrFail(cs1, 0x6588, [(byte)0x80, (byte)0x65, (byte)0x0A, (byte)0x7F]);
        // 100D:6588 and byte ptr DS:[DI+0x0A],0x7F
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x7F);
        VerifySpeculativeEntryOrFail(cs1, 0x658C, [(byte)0xE8, (byte)0xB4, (byte)0x0E]);
        // 100D:658C call near 0x7443
        NearCall(cs1, 0x658F, unknown_100D_7443_17513);
        throw FailAsUntested("Call at 100D:658C returned to 100D:658F, but no continuation was observed during discovery.");
    label_100D_658F_1665F_40789:
        CheckExternalEvents(cs1, 0x658F);
        // 100D:658F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:6590 call near 0xE283
        NearCall(cs1, 0x6593, unknown_100D_E283_1E353);
    label_100D_6593_16663_40720:
        CheckExternalEvents(cs1, 0x6593);
        // 100D:6593 and AX,0x0ECF
        AX = Alu16.And(AX, (ushort)0x0ECF);
        // 100D:6596 or AL,0x20
        AL = Alu8.Or(AL, (byte)0x20);
        // 100D:6598 cmp AH,8
        Alu8.Sub(AH, (byte)0x08);
        // 100D:659B jae short 0x65A7
        if (!CarryFlag)
        {
            goto label_100D_65A7_16677_40713;
        }
    label_100D_659D_1666D_40738:
        CheckExternalEvents(cs1, 0x659D);
        // 100D:659D rol byte ptr DS:[0x4736],1
        UInt8[DS, (ushort)0x4736] = Alu8.Rol(UInt8[DS, (ushort)0x4736], unchecked((byte)1));
        // 100D:65A1 jae short 0x65A7
        if (!CarryFlag)
        {
            goto label_100D_65A7_16677_40713;
        }
    label_100D_65A3_16673_40742:
        CheckExternalEvents(cs1, 0x65A3);
        // 100D:65A3 and AL,0xCF
        AL = Alu8.And(AL, (byte)0xCF);
        // 100D:65A5 or AL,0x10
        AL = Alu8.Or(AL, (byte)0x10);
    label_100D_65A7_16677_40713:
        CheckExternalEvents(cs1, 0x65A7);
        // 100D:65A7 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:65A8 inc DX
        DX = Alu16.Inc(DX);
        // 100D:65A9 cmp DX,BP
        Alu16.Sub(DX, BP);
        // 100D:65AB jb short 0x65B1
        if (CarryFlag)
        {
            goto label_100D_65B1_16681_40727;
        }
    label_100D_65AD_1667D_40729:
        CheckExternalEvents(cs1, 0x65AD);
        VerifySpeculativeEntryOrFail(cs1, 0x65AD, [(byte)0x2B, (byte)0xD5]);
        // 100D:65AD sub DX,BP
        DX = Alu16.Sub(DX, BP);
        VerifySpeculativeEntryOrFail(cs1, 0x65AF, [(byte)0x2B, (byte)0xFD]);
        // 100D:65AF sub DI,BP
        DI = Alu16.Sub(DI, BP);
    label_100D_65B1_16681_40727:
        CheckExternalEvents(cs1, 0x65B1);
        // 100D:65B1 loop 0x655D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_655D_1662D_40700;
        }
    label_100D_65B3_16683_40677:
        CheckExternalEvents(cs1, 0x65B3);
        // 100D:65B3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action for_each_troop_in_location(int loadOffset)
    {
    entrydispatcher:
    label_100D_6603_166D3_3072:
        CheckExternalEvents(cs1, 0x6603);
        // 100D:6603 push SI
        Stack.Push16(SI);
        // 100D:6604 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
    label_100D_6607_166D7_3075:
        CheckExternalEvents(cs1, 0x6607);
        // 100D:6607 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6609 je short 0x661B
        if (ZeroFlag)
        {
            goto label_100D_661B_166EB_3077;
        }
    label_100D_660B_166DB_3085:
        CheckExternalEvents(cs1, 0x660B);
        // 100D:660B call near 0x6906
        NearCall(cs1, 0x660E, unknown_100D_6906_169D6);
    label_100D_660E_166DE_3096:
        CheckExternalEvents(cs1, 0x660E);
        // 100D:660E push SI
        Stack.Push16(SI);
        // 100D:660F push DI
        Stack.Push16(DI);
        // 100D:6610 push BP
        Stack.Push16(BP);
        // 100D:6611 call near BP
        switch ((ushort)(BP))
        {
            case 0x01E0:
                NearCall(cs1, 0x6613, unknown_100D_01E0_102B0);
                break;
            case 0x1EB1:
                NearCall(cs1, 0x6613, unknown_100D_1EB1_11F81);
                break;
            case 0x316E:
                NearCall(cs1, 0x6613, classify_troop_for_room);
                break;
            case 0x3406:
                NearCall(cs1, 0x6613, unknown_100D_3406_134D6);
                break;
            case 0x34D0:
                NearCall(cs1, 0x6613, unknown_100D_34D0_135A0);
                break;
            case 0x5082:
                NearCall(cs1, 0x6613, unknown_100D_5082_15152);
                break;
            case 0x5728:
                NearCall(cs1, 0x6613, unknown_100D_5728_157F8);
                break;
            case 0x6155:
                NearCall(cs1, 0x6613, unknown_100D_6155_16225);
                break;
            case 0x68DA:
                NearCall(cs1, 0x6613, unknown_100D_68DA_169AA);
                break;
            case 0x6E0F:
                NearCall(cs1, 0x6613, unknown_100D_6E0F_16EDF);
                break;
            case 0x7419:
                NearCall(cs1, 0x6613, unknown_100D_7419_174E9);
                break;
            case 0x7506:
                NearCall(cs1, 0x6613, unknown_100D_7506_175D6);
                break;
            case 0x7516:
                NearCall(cs1, 0x6613, unknown_100D_7516_175E6);
                break;
            case 0x7552:
                NearCall(cs1, 0x6613, unknown_100D_7552_17622);
                break;
            case 0x75AF:
                NearCall(cs1, 0x6613, unknown_100D_75AF_1767F);
                break;
            case 0x75EA:
                NearCall(cs1, 0x6613, unknown_100D_75EA_176BA);
                break;
            case 0x762A:
                NearCall(cs1, 0x6613, unknown_100D_762A_176FA);
                break;
            case 0x764D:
                NearCall(cs1, 0x6613, unknown_100D_764D_1771D);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:6611");
        }
    label_100D_6613_166E3_3114:
        CheckExternalEvents(cs1, 0x6613);
        // 100D:6613 pop BP
        BP = Stack.Pop16();
        // 100D:6614 pop DI
        DI = Stack.Pop16();
        // 100D:6615 pop SI
        SI = Stack.Pop16();
        // 100D:6616 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:6619 jmp short 0x6607
        goto label_100D_6607_166D7_3075;
    label_100D_661B_166EB_3077:
        CheckExternalEvents(cs1, 0x661B);
        // 100D:661B pop SI
        SI = Stack.Pop16();
        // 100D:661C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action for_each_hired_troop_in_location(int loadOffset)
    {
    entrydispatcher:
    label_100D_661D_166ED_26798:
        CheckExternalEvents(cs1, 0x661D);
        // 100D:661D push SI
        Stack.Push16(SI);
        // 100D:661E mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
    label_100D_6621_166F1_26801:
        CheckExternalEvents(cs1, 0x6621);
        // 100D:6621 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6623 je short 0x6637
        if (ZeroFlag)
        {
            goto label_100D_6637_16707_26839;
        }
    label_100D_6625_166F5_26803:
        CheckExternalEvents(cs1, 0x6625);
        // 100D:6625 call near 0x6906
        NearCall(cs1, 0x6628, unknown_100D_6906_169D6);
    label_100D_6628_166F8_26805:
        CheckExternalEvents(cs1, 0x6628);
        // 100D:6628 jae short 0x6632
        if (!CarryFlag)
        {
            goto label_100D_6632_16702_26836;
        }
    label_100D_662A_166FA_26807:
        CheckExternalEvents(cs1, 0x662A);
        // 100D:662A push SI
        Stack.Push16(SI);
        // 100D:662B push DI
        Stack.Push16(DI);
        // 100D:662C push BP
        Stack.Push16(BP);
        // 100D:662D call near BP
        switch ((ushort)(BP))
        {
            case 0x1269:
                NearCall(cs1, 0x662F, unknown_100D_1269_11339);
                break;
            case 0x1EA1:
                NearCall(cs1, 0x662F, unknown_100D_1EA1_11F71);
                break;
            case 0x1EA9:
                NearCall(cs1, 0x662F, unknown_100D_1EA9_11F79);
                break;
            case 0x2D62:
                NearCall(cs1, 0x662F, unknown_100D_2D62_12E32);
                break;
            case 0x4E04:
                NearCall(cs1, 0x662F, unknown_100D_4E04_14ED4);
                break;
            case 0x6D5F:
                NearCall(cs1, 0x662F, unknown_100D_6D5F_16E2F);
                break;
            case 0x6E82:
                NearCall(cs1, 0x662F, unknown_100D_6E82_16F52);
                break;
            case 0x6ECB:
                NearCall(cs1, 0x662F, unknown_100D_6ECB_16F9B);
                break;
            case 0x7289:
                NearCall(cs1, 0x662F, unknown_100D_7289_17359);
                break;
            case 0x72A2:
                NearCall(cs1, 0x662F, unknown_100D_72A2_17372);
                break;
            case 0x7399:
                NearCall(cs1, 0x662F, unknown_100D_7399_17469);
                break;
            case 0x8403:
                NearCall(cs1, 0x662F, unknown_100D_8403_184D3);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:662D");
        }
    label_100D_662F_166FF_26832:
        CheckExternalEvents(cs1, 0x662F);
        // 100D:662F pop BP
        BP = Stack.Pop16();
        // 100D:6630 pop DI
        DI = Stack.Pop16();
        // 100D:6631 pop SI
        SI = Stack.Pop16();
    label_100D_6632_16702_26836:
        CheckExternalEvents(cs1, 0x6632);
        // 100D:6632 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:6635 jmp short 0x6621
        goto label_100D_6621_166F1_26801;
    label_100D_6637_16707_26839:
        CheckExternalEvents(cs1, 0x6637);
        // 100D:6637 pop SI
        SI = Stack.Pop16();
        // 100D:6638 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6639_16709(int loadOffset)
    {
    label_100D_6639_16709_13723:
        CheckExternalEvents(cs1, 0x6639);
        // 100D:6639 call near 0x6603
        NearCall(cs1, 0x663C, for_each_troop_in_location);
    label_100D_663C_1670C_13725:
        CheckExternalEvents(cs1, 0x663C);
        // 100D:663C push SI
        Stack.Push16(SI);
        // 100D:663D mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_6640_16710_13728:
        CheckExternalEvents(cs1, 0x6640);
        // 100D:6640 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6643 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:6645 je short 0x6665
        if (ZeroFlag)
        {
            goto label_100D_6665_16735_13731;
        }
    label_100D_6647_16717_29715:
        CheckExternalEvents(cs1, 0x6647);
        // 100D:6647 push BX
        Stack.Push16(BX);
        // 100D:6648 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:664B and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:664D cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:664F jne short 0x6654
        if (!ZeroFlag)
        {
            goto label_100D_6654_16724_29721;
        }
    label_100D_6651_16721_31345:
        CheckExternalEvents(cs1, 0x6651);
        // 100D:6651 mov BX,word ptr DS:[SI+0x0C]
        BX = UInt16[DS, (ushort)(SI + (sbyte)12)];
    label_100D_6654_16724_29721:
        CheckExternalEvents(cs1, 0x6654);
        // 100D:6654 cmp BX,DI
        Alu16.Sub(BX, DI);
        // 100D:6656 pop BX
        BX = Stack.Pop16();
        // 100D:6657 jne short 0x6665
        if (!ZeroFlag)
        {
            goto label_100D_6665_16735_13731;
        }
    label_100D_6659_16729_29769:
        CheckExternalEvents(cs1, 0x6659);
        // 100D:6659 push SI
        Stack.Push16(SI);
        // 100D:665A push DI
        Stack.Push16(DI);
        // 100D:665B push BP
        Stack.Push16(BP);
        // 100D:665C cmp byte ptr DS:[SI+3],0x80
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x80);
        // 100D:6660 call near BP
        switch ((ushort)(BP))
        {
            case 0x34D0:
                NearCall(cs1, 0x6662, unknown_100D_34D0_135A0);
                break;
            case 0x5728:
                NearCall(cs1, 0x6662, unknown_100D_5728_157F8);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:6660");
        }
    label_100D_6662_16732_29778:
        CheckExternalEvents(cs1, 0x6662);
        // 100D:6662 pop BP
        BP = Stack.Pop16();
        // 100D:6663 pop DI
        DI = Stack.Pop16();
        // 100D:6664 pop SI
        SI = Stack.Pop16();
    label_100D_6665_16735_13731:
        CheckExternalEvents(cs1, 0x6665);
        // 100D:6665 add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:6668 cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:666C jb short 0x6640
        if (CarryFlag)
        {
            goto label_100D_6640_16710_13728;
        }
    label_100D_666E_1673E_13736:
        CheckExternalEvents(cs1, 0x666E);
        // 100D:666E pop SI
        SI = Stack.Pop16();
        // 100D:666F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_668F_1675F(int loadOffset)
    {
    label_100D_668F_1675F_34405:
        CheckExternalEvents(cs1, 0x668F);
        // 100D:668F test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:6693 jne short 0x66B0
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6693");
        }
    label_100D_6695_16765_34408:
        CheckExternalEvents(cs1, 0x6695);
        // 100D:6695 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:6699 jne short 0x66B0
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6699");
        }
    label_100D_669B_1676B_34411:
        CheckExternalEvents(cs1, 0x669B);
        // 100D:669B or byte ptr DS:[SI+3],0x20
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:669F mov byte ptr DS:[SI+0x19],0
        UInt8[DS, (ushort)(SI + (sbyte)25)] = (byte)0x00;
        // 100D:66A3 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:66A6 mov word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = AX;
        // 100D:66A9 push DI
        Stack.Push16(DI);
        // 100D:66AA mov AL,4
        AL = (byte)0x04;
        // 100D:66AC call near 0x6FB0
        NearCall(cs1, 0x66AF, unknown_100D_6FB0_17080);
    label_100D_66AF_1677F_34455:
        CheckExternalEvents(cs1, 0x66AF);
        // 100D:66AF pop DI
        DI = Stack.Pop16();
        // 100D:66B0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_remove_from_play(int loadOffset)
    {
    label_100D_66B1_16781_37129:
        CheckExternalEvents(cs1, 0x66B1);
        // 100D:66B1 call near 0x858C
        NearCall(cs1, 0x66B4, troop_unlink_from_location_chain);
    label_100D_66B4_16784_37135:
        CheckExternalEvents(cs1, 0x66B4);
        // 100D:66B4 push SI
        Stack.Push16(SI);
        // 100D:66B5 push DI
        Stack.Push16(DI);
        // 100D:66B6 call near 0x6917
        NearCall(cs1, 0x66B9, troop_find_icon);
    label_100D_66B9_16789_37142:
        CheckExternalEvents(cs1, 0x66B9);
        // 100D:66B9 jne short 0x66BE
        if (!ZeroFlag)
        {
            goto label_100D_66BE_1678E_37143;
        }
    label_100D_66BB_1678B_37146:
        CheckExternalEvents(cs1, 0x66BB);
        // 100D:66BB call near 0xC58A
        NearCall(cs1, 0x66BE, unknown_100D_C58A_1C65A);
    label_100D_66BE_1678E_37143:
        CheckExternalEvents(cs1, 0x66BE);
        // 100D:66BE pop DI
        DI = Stack.Pop16();
        // 100D:66BF pop SI
        SI = Stack.Pop16();
        // 100D:66C0 mov word ptr DS:[SI+4],0x0FBC
        UInt16[DS, (ushort)(SI + (sbyte)4)] = (ushort)0x0FBC;
        // 100D:66C5 mov byte ptr DS:[SI+3],0xA0
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0xA0;
        // 100D:66C9 mov byte ptr DS:[SI+0x1A],0
        UInt8[DS, (ushort)(SI + (sbyte)26)] = (byte)0x00;
        // 100D:66CD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_rally_troop(int loadOffset)
    {
    label_100D_66CE_1679E_23225:
        CheckExternalEvents(cs1, 0x66CE);
        // 100D:66CE test byte ptr DS:[SI+3],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x80);
        // 100D:66D2 je short 0x6714
        if (ZeroFlag)
        {
            goto label_100D_6714_167E4_23391;
        }
    label_100D_66D4_167A4_23228:
        CheckExternalEvents(cs1, 0x66D4);
        // 100D:66D4 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:66D8 jne short 0x6714
        if (!ZeroFlag)
        {
            goto label_100D_6714_167E4_23391;
        }
    label_100D_66DA_167AA_23231:
        CheckExternalEvents(cs1, 0x66DA);
        // 100D:66DA inc byte ptr DS:[0x0028]
        UInt8[DS, (ushort)0x0028] = Alu8.Inc(UInt8[DS, (ushort)0x0028]);
        // 100D:66DE mov AL,byte ptr DS:[0x0028]
        AL = UInt8[DS, (ushort)0x0028];
        // 100D:66E1 cmp AL,byte ptr DS:[0x1178]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1178]);
        // 100D:66E5 jb short 0x66EE
        if (CarryFlag)
        {
            goto label_100D_66EE_167BE_23236;
        }
    label_100D_66E7_167B7_34947:
        CheckExternalEvents(cs1, 0x66E7);
        // 100D:66E7 push SI
        Stack.Push16(SI);
        // 100D:66E8 mov AL,0x4C
        AL = (byte)0x4C;
        // 100D:66EA call near 0x121F
        NearCall(cs1, 0x66ED, set_game_phase_and_trigger_callbacks);
    label_100D_66ED_167BD_34957:
        CheckExternalEvents(cs1, 0x66ED);
        // 100D:66ED pop SI
        SI = Stack.Pop16();
    label_100D_66EE_167BE_23236:
        CheckExternalEvents(cs1, 0x66EE);
        // 100D:66EE mov AL,1
        AL = (byte)0x01;
        // 100D:66F0 call near 0x6F78
        NearCall(cs1, 0x66F3, increase_charisma);
    label_100D_66F3_167C3_23253:
        CheckExternalEvents(cs1, 0x66F3);
        // 100D:66F3 and byte ptr DS:[SI+3],0x20
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:66F7 or byte ptr DS:[SI+3],2
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x02);
        // 100D:66FB call near 0x6B25
        NearCall(cs1, 0x66FE, troop_reset_occupation_clocks);
    label_100D_66FE_167CE_23264:
        CheckExternalEvents(cs1, 0x66FE);
        // 100D:66FE call near 0x1AC5
        NearCall(cs1, 0x6701, unknown_100D_1AC5_11B95);
    label_100D_6701_167D1_23266:
        CheckExternalEvents(cs1, 0x6701);
        // 100D:6701 mov byte ptr DS:[SI+0x14],AL
        UInt8[DS, (ushort)(SI + (sbyte)20)] = AL;
        // 100D:6704 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6707 cmp byte ptr DS:[DI+0x0B],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)11)], (byte)0x00);
        // 100D:670B jne short 0x6714
        if (!ZeroFlag)
        {
            goto label_100D_6714_167E4_23391;
        }
    label_100D_670D_167DD_23271:
        CheckExternalEvents(cs1, 0x670D);
        // 100D:670D mov byte ptr DS:[DI+0x0B],2
        UInt8[DS, (ushort)(DI + (sbyte)11)] = (byte)0x02;
        // 100D:6711 call near 0x644E
        NearCall(cs1, 0x6714, unknown_100D_644E_1651E);
    label_100D_6714_167E4_23391:
        CheckExternalEvents(cs1, 0x6714);
        // 100D:6714 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_spawn_troop_icons(int loadOffset)
    {
    label_100D_6715_167E5_18219:
        CheckExternalEvents(cs1, 0x6715);
        // 100D:6715 mov BP,0xA5C0
        BP = (ushort)0xA5C0;
    label_100D_6718_167E8_18221:
        CheckExternalEvents(cs1, 0x6718);
        // 100D:6718 mov DI,word ptr SS:[BP]
        DI = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:671B or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:671D je short 0x6737
        if (ZeroFlag)
        {
            goto label_100D_6737_16807_18302;
        }
    label_100D_671F_167EF_18224:
        CheckExternalEvents(cs1, 0x671F);
        // 100D:671F mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:6722 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6724 je short 0x6732
        if (ZeroFlag)
        {
            goto label_100D_6732_16802_18228;
        }
    label_100D_6726_167F6_18232:
        CheckExternalEvents(cs1, 0x6726);
        // 100D:6726 push BP
        Stack.Push16(BP);
        // 100D:6727 call near 0x6757
        NearCall(cs1, 0x672A, map_spawn_troop_icon);
    label_100D_672A_167FA_18297:
        CheckExternalEvents(cs1, 0x672A);
        // 100D:672A pop BP
        BP = Stack.Pop16();
        // 100D:672B mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:672E or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6730 jne short 0x6726
        if (!ZeroFlag)
        {
            goto label_100D_6726_167F6_18232;
        }
    label_100D_6732_16802_18228:
        CheckExternalEvents(cs1, 0x6732);
        // 100D:6732 add BP,6
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:6735 jmp short 0x6718
        goto label_100D_6718_167E8_18221;
    label_100D_6737_16807_18302:
        CheckExternalEvents(cs1, 0x6737);
        // 100D:6737 mov SI,0x088F
        SI = (ushort)0x088F;
    label_100D_673A_1680A_18304:
        CheckExternalEvents(cs1, 0x673A);
        // 100D:673A add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:673D cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:6741 jae short 0x6756
        if (!CarryFlag)
        {
            goto label_100D_6756_16826_18314;
        }
    label_100D_6743_16813_18307:
        CheckExternalEvents(cs1, 0x6743);
        // 100D:6743 test byte ptr DS:[SI+0x10],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:6747 jne short 0x673A
        if (!ZeroFlag)
        {
            goto label_100D_673A_1680A_18304;
        }
    label_100D_6749_16819_18310:
        CheckExternalEvents(cs1, 0x6749);
        // 100D:6749 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:674D je short 0x673A
        if (ZeroFlag)
        {
            goto label_100D_673A_1680A_18304;
        }
    label_100D_674F_1681F_29703:
        CheckExternalEvents(cs1, 0x674F);
        // 100D:674F mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:6751 call near 0x6757
        NearCall(cs1, 0x6754, map_spawn_troop_icon);
    label_100D_6754_16824_29706:
        CheckExternalEvents(cs1, 0x6754);
        // 100D:6754 jmp short 0x673A
        goto label_100D_673A_1680A_18304;
    label_100D_6756_16826_18314:
        CheckExternalEvents(cs1, 0x6756);
        // 100D:6756 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_spawn_troop_icon(int loadOffset)
    {
    label_100D_6757_16827_18235:
        CheckExternalEvents(cs1, 0x6757);
        // 100D:6757 call near 0x6906
        NearCall(cs1, 0x675A, unknown_100D_6906_169D6);
    label_100D_675A_1682A_18237:
        CheckExternalEvents(cs1, 0x675A);
        // 100D:675A call near 0x686E
        NearCall(cs1, 0x675D, troop_icon_screen_pos);
    label_100D_675D_1682D_18270:
        CheckExternalEvents(cs1, 0x675D);
        // 100D:675D jb short 0x676D
        if (CarryFlag)
        {
            goto label_100D_676D_1683D_18295;
        }
    label_100D_675F_1682F_18272:
        CheckExternalEvents(cs1, 0x675F);
        // 100D:675F call near 0x6770
        NearCall(cs1, 0x6762, troop_icon_pick_script);
    label_100D_6762_16832_18292:
        CheckExternalEvents(cs1, 0x6762);
        // 100D:6762 cmp BP,1
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:6765 jb short 0x676D
        if (CarryFlag)
        {
            goto label_100D_676D_1683D_18295;
        }
    label_100D_6767_16837_23524:
        CheckExternalEvents(cs1, 0x6767);
        // 100D:6767 push SI
        Stack.Push16(SI);
        // 100D:6768 call near 0xC5CF
        NearCall(cs1, 0x676B, troop_icon_spawn_with_anim);
    label_100D_676B_1683B_23532:
        CheckExternalEvents(cs1, 0x676B);
        // 100D:676B pop SI
        SI = Stack.Pop16();
        // 100D:676C clc
        CarryFlag = false;
    label_100D_676D_1683D_18295:
        CheckExternalEvents(cs1, 0x676D);
        // 100D:676D ret near
        return NearRet((ushort)0x0000);
    }
}
