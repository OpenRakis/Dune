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
    public virtual Action unknown_100D_1E43_11F13(int loadOffset)
    {
    label_100D_1E43_11F13_26670:
        CheckExternalEvents(cs1, 0x1E43);
        // 100D:1E43 call near 0x1AC5
        NearCall(cs1, 0x1E46, unknown_100D_1AC5_11B95);
    label_100D_1E46_11F16_26672:
        CheckExternalEvents(cs1, 0x1E46);
        // 100D:1E46 cmp AX,word ptr DS:[0x1156]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x1156]);
        // 100D:1E4A jb short 0x1EA8
        if (CarryFlag)
        {
            return unknown_100D_1EA8_11F78(0x0000);
        }
    label_100D_1E4C_11F1C_35685:
        CheckExternalEvents(cs1, 0x1E4C);
        // 100D:1E4C cmp byte ptr DS:[0x002A],0x5C
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x5C);
        // 100D:1E51 jne short 0x1EA8
        if (!ZeroFlag)
        {
            return unknown_100D_1EA8_11F78(0x0000);
        }
    label_100D_1E53_11F23_35688:
        CheckExternalEvents(cs1, 0x1E53);
        // 100D:1E53 cmp word ptr DS:[0x114E],0x07C8
        Alu16.Sub(UInt16[DS, (ushort)0x114E], (ushort)0x07C8);
        // 100D:1E59 je short 0x1EA8
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1E59");
        }
    label_100D_1E5B_11F2B_35691:
        CheckExternalEvents(cs1, 0x1E5B);
        // 100D:1E5B mov DI,0x0100
        DI = (ushort)0x0100;
        // 100D:1E5E xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_100D_1E60_11F30_35694:
        CheckExternalEvents(cs1, 0x1E60);
        // 100D:1E60 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:1E64 jae short 0x1E82
        if (!CarryFlag)
        {
            goto label_100D_1E82_11F52_35709;
        }
    label_100D_1E66_11F36_35696:
        CheckExternalEvents(cs1, 0x1E66);
        // 100D:1E66 test byte ptr DS:[DI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x80);
        // 100D:1E6A jne short 0x1E82
        if (!ZeroFlag)
        {
            goto label_100D_1E82_11F52_35709;
        }
    label_100D_1E6C_11F3C_35699:
        CheckExternalEvents(cs1, 0x1E6C);
        // 100D:1E6C cmp DI,0x02C0
        Alu16.Sub(DI, (ushort)0x02C0);
        // 100D:1E70 je short 0x1E82
        if (ZeroFlag)
        {
            goto label_100D_1E82_11F52_35709;
        }
    label_100D_1E72_11F42_35702:
        CheckExternalEvents(cs1, 0x1E72);
        // 100D:1E72 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:1E74 mov BP,0x1EA1
        BP = (ushort)0x1EA1;
        // 100D:1E77 call near 0x661D
        NearCall(cs1, 0x1E7A, unknown_100D_661D_166ED);
    label_100D_1E7A_11F4A_35706:
        CheckExternalEvents(cs1, 0x1E7A);
        // 100D:1E7A cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:1E7C jbe short 0x1E82
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_1E82_11F52_35709;
        }
    label_100D_1E7E_11F4E_35717:
        CheckExternalEvents(cs1, 0x1E7E);
        // 100D:1E7E mov CX,DX
        CX = DX;
        // 100D:1E80 mov BX,DI
        BX = DI;
    label_100D_1E82_11F52_35709:
        CheckExternalEvents(cs1, 0x1E82);
        // 100D:1E82 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:1E85 cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:1E88 jne short 0x1E60
        if (!ZeroFlag)
        {
            goto label_100D_1E60_11F30_35694;
        }
    label_100D_1E8A_11F5A_35720:
        CheckExternalEvents(cs1, 0x1E8A);
        // 100D:1E8A jcxz short 0x1EA8
        if (CX == (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1E8A");
        }
    label_100D_1E8C_11F5C_35722:
        CheckExternalEvents(cs1, 0x1E8C);
        // 100D:1E8C mov DI,BX
        DI = BX;
        // 100D:1E8E mov word ptr DS:[0x11DB],DI
        UInt16[DS, (ushort)0x11DB] = DI;
        // 100D:1E92 inc byte ptr DS:[0x00F8]
        UInt8[DS, (ushort)0x00F8] = Alu8.Inc(UInt8[DS, (ushort)0x00F8]);
        // 100D:1E96 mov BP,0x1EA9
        BP = (ushort)0x1EA9;
        // 100D:1E99 call near 0x661D
        NearCall(cs1, 0x1E9C, unknown_100D_661D_166ED);
    label_100D_1E9C_11F6C_35731:
        CheckExternalEvents(cs1, 0x1E9C);
        // 100D:1E9C mov AL,8
        AL = (byte)0x08;
        // 100D:1E9E jmp near 0x71B2
        return unknown_100D_71B2_17282(0x0000);
    }

    public virtual Action unknown_100D_1EA1_11F71(int loadOffset)
    {
    label_100D_1EA1_11F71_35714:
        CheckExternalEvents(cs1, 0x1EA1);
        // 100D:1EA1 cmp byte ptr DS:[SI+3],8
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x08);
        // 100D:1EA5 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        return unknown_100D_1EA8_11F78(0x0000);
    }

    public virtual Action unknown_100D_1EA9_11F79(int loadOffset)
    {
    label_100D_1EA9_11F79_35728:
        CheckExternalEvents(cs1, 0x1EA9);
        // 100D:1EA9 or word ptr DS:[SI+0x12],0x0400
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0400);
        // 100D:1EAE jmp near 0x7085
        return unknown_100D_7085_17155(0x0000);
    }

    public virtual Action unknown_100D_1EB1_11F81(int loadOffset)
    {
    label_100D_1EB1_11F81_35991:
        CheckExternalEvents(cs1, 0x1EB1);
        // 100D:1EB1 mov AX,word ptr DS:[SI+0x12]
        AX = UInt16[DS, (ushort)(SI + (sbyte)18)];
        // 100D:1EB4 and AX,0xFBFF
        AX = Alu16.And(AX, (ushort)0xFBFF);
        // 100D:1EB7 or AX,0x0800
        AX = Alu16.Or(AX, (ushort)0x0800);
        // 100D:1EBA mov word ptr DS:[SI+0x12],AX
        UInt16[DS, (ushort)(SI + (sbyte)18)] = AX;
        // 100D:1EBD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1EBE_11F8E(int loadOffset)
    {
    label_100D_1EBE_11F8E_24998:
        CheckExternalEvents(cs1, 0x1EBE);
        // 100D:1EBE test word ptr DS:[SI+0x12],0x0800
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0800);
        // 100D:1EC3 je short 0x1ED9
        if (ZeroFlag)
        {
            goto label_100D_1ED9_11FA9_25001;
        }
    label_100D_1EC5_11F95_36032:
        CheckExternalEvents(cs1, 0x1EC5);
        // 100D:1EC5 mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:1EC8 sub AL,0x60
        AL = Alu8.Sub(AL, (byte)0x60);
        // 100D:1ECA cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:1ECC jae short 0x1ED9
        if (!CarryFlag)
        {
            goto label_100D_1ED9_11FA9_25001;
        }
    label_100D_1ECE_11F9E_36037:
        CheckExternalEvents(cs1, 0x1ECE);
        // 100D:1ECE call near 0xE270
        NearCall(cs1, 0x1ED1, unknown_100D_E270_1E340);
    label_100D_1ED1_11FA1_36039:
        CheckExternalEvents(cs1, 0x1ED1);
        // 100D:1ED1 mov AL,0x64
        AL = (byte)0x64;
        // 100D:1ED3 call near 0x121F
        NearCall(cs1, 0x1ED6, unknown_100D_121F_112EF);
    label_100D_1ED6_11FA6_36086:
        CheckExternalEvents(cs1, 0x1ED6);
        // 100D:1ED6 call near 0xE283
        NearCall(cs1, 0x1ED9, unknown_100D_E283_1E353);
    label_100D_1ED9_11FA9_25001:
        CheckExternalEvents(cs1, 0x1ED9);
        // 100D:1ED9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1EDA_11FAA(int loadOffset)
    {
    label_100D_1EDA_11FAA_35772:
        CheckExternalEvents(cs1, 0x1EDA);
        // 100D:1EDA add byte ptr DS:[0x00F9],8
        UInt8[DS, (ushort)0x00F9] = Alu8.Add(UInt8[DS, (ushort)0x00F9], (byte)0x08);
        // 100D:1EDF jne short 0x1F12
        if (!ZeroFlag)
        {
            goto label_100D_1F12_11FE2_35775;
        }
    label_100D_1EE1_11FB1_35986:
        CheckExternalEvents(cs1, 0x1EE1);
        // 100D:1EE1 push CX
        Stack.Push16(CX);
        // 100D:1EE2 push SI
        Stack.Push16(SI);
        // 100D:1EE3 mov BP,0x1EB1
        BP = (ushort)0x1EB1;
        // 100D:1EE6 call near 0x6603
        NearCall(cs1, 0x1EE9, unknown_100D_6603_166D3);
    label_100D_1EE9_11FB9_35997:
        CheckExternalEvents(cs1, 0x1EE9);
        // 100D:1EE9 mov AX,0x0709
        AX = (ushort)0x0709;
        // 100D:1EEC call near 0x29F0
        NearCall(cs1, 0x1EEF, unknown_100D_29F0_12AC0);
    label_100D_1EEF_11FBF_36000:
        CheckExternalEvents(cs1, 0x1EEF);
        // 100D:1EEF dec byte ptr DS:[0x00F8]
        UInt8[DS, (ushort)0x00F8] = Alu8.Dec(UInt8[DS, (ushort)0x00F8]);
        // 100D:1EF3 mov DI,0x0100
        DI = (ushort)0x0100;
    label_100D_1EF6_11FC6_36003:
        CheckExternalEvents(cs1, 0x1EF6);
        // 100D:1EF6 call near 0x1E24
        NearCall(cs1, 0x1EF9, unknown_100D_1E24_11EF4);
    label_100D_1EF9_11FC9_36004:
        CheckExternalEvents(cs1, 0x1EF9);
        // 100D:1EF9 jb short 0x1F05
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1EF9");
        }
    label_100D_1EFB_11FCB_36006:
        CheckExternalEvents(cs1, 0x1EFB);
        // 100D:1EFB add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:1EFE cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:1F01 jne short 0x1EF6
        if (!ZeroFlag)
        {
            goto label_100D_1EF6_11FC6_36003;
        }
    label_100D_1F03_11FD3_36012:
        CheckExternalEvents(cs1, 0x1F03);
        // 100D:1F03 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:1F05 mov word ptr DS:[0x11DB],DI
        UInt16[DS, (ushort)0x11DB] = DI;
        // 100D:1F09 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:1F0B jne short 0x1F10
        if (!ZeroFlag)
        {
            goto label_100D_1F10_11FE0_36029;
        }
    label_100D_1F0D_11FDD_36017:
        CheckExternalEvents(cs1, 0x1F0D);
        // 100D:1F0D call near 0x11CB
        NearCall(cs1, 0x1F10, unknown_100D_11CB_1129B);
    label_100D_1F10_11FE0_36029:
        CheckExternalEvents(cs1, 0x1F10);
        // 100D:1F10 pop SI
        SI = Stack.Pop16();
        // 100D:1F11 pop CX
        CX = Stack.Pop16();
    label_100D_1F12_11FE2_35775:
        CheckExternalEvents(cs1, 0x1F12);
        // 100D:1F12 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2017_120E7(int loadOffset)
    {
    label_100D_2017_120E7_34132:
        CheckExternalEvents(cs1, 0x2017);
        // 100D:2017 mov DI,0x0100
        DI = (ushort)0x0100;
        // 100D:201A mov word ptr DS:[0xD816],0
        UInt16[DS, (ushort)0xD816] = (ushort)0x0000;
        // 100D:2020 mov BX,0x0064
        BX = (ushort)0x0064;
    label_100D_2023_120F3_34136:
        CheckExternalEvents(cs1, 0x2023);
        // 100D:2023 cmp byte ptr DS:[DI+8],0x20
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x20);
        // 100D:2027 jae short 0x207D
        if (!CarryFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2029_120F9_34143:
        CheckExternalEvents(cs1, 0x2029);
        // 100D:2029 test byte ptr DS:[DI+0x0A],0x82
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x82);
        // 100D:202D jne short 0x207D
        if (!ZeroFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_202F_120FF_34146:
        CheckExternalEvents(cs1, 0x202F);
        // 100D:202F cmp BX,word ptr DS:[DI+4]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:2032 jle short 0x207D
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2034_12104_34149:
        CheckExternalEvents(cs1, 0x2034);
        // 100D:2034 call near 0x1E24
        NearCall(cs1, 0x2037, unknown_100D_1E24_11EF4);
    label_100D_2037_12107_34167:
        CheckExternalEvents(cs1, 0x2037);
        // 100D:2037 jb short 0x207D
        if (CarryFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2039_12109_34169:
        CheckExternalEvents(cs1, 0x2039);
        // 100D:2039 push BX
        Stack.Push16(BX);
        // 100D:203A call near 0x331E
        NearCall(cs1, 0x203D, unknown_100D_331E_133EE);
    label_100D_203D_1210D_34172:
        CheckExternalEvents(cs1, 0x203D);
        // 100D:203D pop BX
        BX = Stack.Pop16();
        // 100D:203E mov AL,byte ptr DS:[0x0060]
        AL = UInt8[DS, (ushort)0x0060];
        // 100D:2041 sub AL,byte ptr DS:[0x0063]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x0063]);
        // 100D:2045 je short 0x207D
        if (ZeroFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2047_12117_34177:
        CheckExternalEvents(cs1, 0x2047);
        // 100D:2047 mov BP,word ptr DS:[0x00E4]
        BP = UInt16[DS, (ushort)0x00E4];
        // 100D:204B cmp word ptr DS:[0x00E2],0x001E
        Alu16.Sub(UInt16[DS, (ushort)0x00E2], unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:2050 jb short 0x205D
        if (CarryFlag)
        {
            goto label_100D_205D_1212D_34181;
        }
    label_100D_2052_12122_35786:
        CheckExternalEvents(cs1, 0x2052);
        // 100D:2052 cmp word ptr DS:[0x00DC],0x001E
        Alu16.Sub(UInt16[DS, (ushort)0x00DC], unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:2057 jae short 0x207D
        if (!CarryFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2059_12129_35789:
        CheckExternalEvents(cs1, 0x2059);
        // 100D:2059 mov BP,word ptr DS:[0x00DE]
        BP = UInt16[DS, (ushort)0x00DE];
    label_100D_205D_1212D_34181:
        CheckExternalEvents(cs1, 0x205D);
        // 100D:205D cmp BP,0x011C
        Alu16.Sub(BP, (ushort)0x011C);
        // 100D:2061 je short 0x207D
        if (ZeroFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2063_12133_34184:
        CheckExternalEvents(cs1, 0x2063);
        // 100D:2063 push DI
        Stack.Push16(DI);
        // 100D:2064 mov DI,BP
        DI = BP;
        // 100D:2066 call near 0x5098
        NearCall(cs1, 0x2069, unknown_100D_5098_15168);
    label_100D_2069_12139_34202:
        CheckExternalEvents(cs1, 0x2069);
        // 100D:2069 mov BP,DI
        BP = DI;
        // 100D:206B pop DI
        DI = Stack.Pop16();
        // 100D:206C jcxz short 0x207D
        if (CX == (ushort)0x0000)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_206E_1213E_34206:
        CheckExternalEvents(cs1, 0x206E);
        // 100D:206E or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:2070 jne short 0x207D
        if (!ZeroFlag)
        {
            goto label_100D_207D_1214D_34138;
        }
    label_100D_2072_12142_34209:
        CheckExternalEvents(cs1, 0x2072);
        // 100D:2072 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:2075 mov word ptr DS:[0xD816],DI
        UInt16[DS, (ushort)0xD816] = DI;
        // 100D:2079 mov word ptr DS:[0xD818],BP
        UInt16[DS, (ushort)0xD818] = BP;
    label_100D_207D_1214D_34138:
        CheckExternalEvents(cs1, 0x207D);
        // 100D:207D add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:2080 cmp byte ptr DS:[DI],8
        Alu8.Sub(UInt8[DS, DI], (byte)0x08);
        // 100D:2083 jb short 0x2023
        if (CarryFlag)
        {
            goto label_100D_2023_120F3_34136;
        }
    label_100D_2085_12155_34213:
        CheckExternalEvents(cs1, 0x2085);
        // 100D:2085 mov BP,word ptr DS:[0xD818]
        BP = UInt16[DS, (ushort)0xD818];
        // 100D:2089 mov DI,word ptr DS:[0xD816]
        DI = UInt16[DS, (ushort)0xD816];
        // 100D:208D or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:208F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2090_12160(int loadOffset)
    {
    label_100D_2090_12160_32317:
        CheckExternalEvents(cs1, 0x2090);
        // 100D:2090 call near 0x1AC5
        NearCall(cs1, 0x2093, unknown_100D_1AC5_11B95);
    label_100D_2093_12163_32319:
        CheckExternalEvents(cs1, 0x2093);
        // 100D:2093 mov word ptr DS:[0x118D],AX
        UInt16[DS, (ushort)0x118D] = AX;
        // 100D:2096 jmp short 0x20D2
        return unknown_100D_20D2_121A2(0x0000);
    }

    public virtual Action unknown_100D_2170_12240(int loadOffset)
    {
    label_100D_2170_12240_22628:
        CheckExternalEvents(cs1, 0x2170);
        // 100D:2170 call near 0xE270
        NearCall(cs1, 0x2173, unknown_100D_E270_1E340);
    label_100D_2173_12243_22630:
        CheckExternalEvents(cs1, 0x2173);
        // 100D:2173 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:2176 mov CX,9
        CX = (ushort)0x0009;
    label_100D_2179_12249_22633:
        CheckExternalEvents(cs1, 0x2179);
        // 100D:2179 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:217D jne short 0x21F1
        if (!ZeroFlag)
        {
            goto label_100D_21F1_122C1_22649;
        }
    label_100D_217F_1224F_22635:
        CheckExternalEvents(cs1, 0x217F);
        // 100D:217F mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:2181 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:2184 cmp SI,0x1008
        Alu16.Sub(SI, (ushort)0x1008);
        // 100D:2188 jne short 0x2194
        if (!ZeroFlag)
        {
            goto label_100D_2194_12264_22640;
        }
    label_100D_218A_1225A_22653:
        CheckExternalEvents(cs1, 0x218A);
        // 100D:218A cmp BX,0x0180
        Alu16.Sub(BX, (ushort)0x0180);
        // 100D:218E jne short 0x2194
        if (!ZeroFlag)
        {
            goto label_100D_2194_12264_22640;
        }
    label_100D_2190_12260_25321:
        CheckExternalEvents(cs1, 0x2190);
        // 100D:2190 mov DL,4
        DL = (byte)0x04;
        // 100D:2192 mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
    label_100D_2194_12264_22640:
        CheckExternalEvents(cs1, 0x2194);
        // 100D:2194 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:2197 jne short 0x21EE
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2197");
        }
    label_100D_2199_12269_22643:
        CheckExternalEvents(cs1, 0x2199);
        // 100D:2199 cmp DL,1
        Alu8.Sub(DL, (byte)0x01);
        // 100D:219C jne short 0x21DC
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:219C");
        }
    label_100D_21DC_122AC_22646:
        CheckExternalEvents(cs1, 0x21DC);
        // 100D:21DC cmp SI,0x1028
        Alu16.Sub(SI, (ushort)0x1028);
        // 100D:21E0 jb short 0x21F1
        if (CarryFlag)
        {
            goto label_100D_21F1_122C1_22649;
        }
    label_100D_21E2_122B2_22656:
        CheckExternalEvents(cs1, 0x21E2);
        // 100D:21E2 cmp BH,1
        Alu8.Sub(BH, (byte)0x01);
        // 100D:21E5 jne short 0x21F1
        if (!ZeroFlag)
        {
            goto label_100D_21F1_122C1_22649;
        }
    label_100D_21E7_122B7_32253:
        CheckExternalEvents(cs1, 0x21E7);
        // 100D:21E7 call near 0x21FA
        NearCall(cs1, 0x21EA, unknown_100D_21FA_122CA);
    label_100D_21EA_122BA_32276:
        CheckExternalEvents(cs1, 0x21EA);
        // 100D:21EA mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 100D:21EC jmp short 0x21F1
    label_100D_21F1_122C1_22649:
        CheckExternalEvents(cs1, 0x21F1);
        // 100D:21F1 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:21F4 loop 0x2179
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2179_12249_22633;
        }
    label_100D_21F6_122C6_22659:
        CheckExternalEvents(cs1, 0x21F6);
        // 100D:21F6 call near 0xE283
        NearCall(cs1, 0x21F9, unknown_100D_E283_1E353);
    label_100D_21F9_122C9_22661:
        CheckExternalEvents(cs1, 0x21F9);
        // 100D:21F9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_21FA_122CA(int loadOffset)
    {
    label_100D_21FA_122CA_32255:
        CheckExternalEvents(cs1, 0x21FA);
        // 100D:21FA mov BX,0x000A
        BX = (ushort)0x000A;
        // 100D:21FD call near 0xE3DF
        NearCall(cs1, 0x2200, unknown_100D_E3DF_1E4AF);
    label_100D_2200_122D0_32258:
        CheckExternalEvents(cs1, 0x2200);
        // 100D:2200 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:2202 cmp byte ptr DS:[0x002A],0x54
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x54);
        // 100D:2207 jae short 0x221C
        if (!CarryFlag)
        {
            goto label_100D_221C_122EC_32274;
        }
    label_100D_2209_122D9_32262:
        CheckExternalEvents(cs1, 0x2209);
        // 100D:2209 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:220B je short 0x21FA
        if (ZeroFlag)
        {
            goto label_100D_21FA_122CA_32255;
        }
    label_100D_220D_122DD_32265:
        CheckExternalEvents(cs1, 0x220D);
        // 100D:220D cmp byte ptr DS:[0x002A],0x24
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x24);
        // 100D:2212 jae short 0x221C
        if (!CarryFlag)
        {
            goto label_100D_221C_122EC_32274;
        }
    label_100D_2214_122E4_32268:
        CheckExternalEvents(cs1, 0x2214);
        // 100D:2214 cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:2216 je short 0x21FA
        if (ZeroFlag)
        {
            goto label_100D_21FA_122CA_32255;
        }
    label_100D_2218_122E8_32271:
        CheckExternalEvents(cs1, 0x2218);
        // 100D:2218 cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:221A je short 0x21FA
        if (ZeroFlag)
        {
            goto label_100D_21FA_122CA_32255;
        }
    label_100D_221C_122EC_32274:
        CheckExternalEvents(cs1, 0x221C);
        // 100D:221C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_22B1_12381(int loadOffset)
    {
    label_100D_22B1_12381_32930:
        CheckExternalEvents(cs1, 0x22B1);
        // 100D:22B1 mov BP,0x00B4
        BP = (ushort)0x00B4;
        // 100D:22B4 and byte ptr DS:[0x00BF],0xF9
        UInt8[DS, (ushort)0x00BF] = Alu8.And(UInt8[DS, (ushort)0x00BF], (byte)0xF9);
        // 100D:22B9 mov BX,word ptr DS:[0x00BC]
        BX = UInt16[DS, (ushort)0x00BC];
        // 100D:22BD mov CX,BX
        CX = BX;
        // 100D:22BF shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:22C1 add CX,BX
        CX = Alu16.Add(CX, BX);
        // 100D:22C3 mov DX,BX
        DX = BX;
        // 100D:22C5 add DX,DX
        DX = Alu16.Add(DX, DX);
        // 100D:22C7 mov SI,AX
        SI = AX;
        // 100D:22C9 shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 100D:22CB mov DI,AX
        DI = AX;
        // 100D:22CD shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 100D:22CF shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 100D:22D1 add DI,SI
        DI = Alu16.Add(DI, SI);
        // 100D:22D3 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:22D5 jb short 0x22F1
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:22D5");
        }
    label_100D_22D7_123A7_32947:
        CheckExternalEvents(cs1, 0x22D7);
        // 100D:22D7 mov word ptr SS:[BP],BX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = BX;
        // 100D:22DA mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:22DD cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:22DF jb short 0x2300
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:22DF");
        }
    label_100D_22E1_123B1_32952:
        CheckExternalEvents(cs1, 0x22E1);
        // 100D:22E1 cmp AX,DX
        Alu16.Sub(AX, DX);
        // 100D:22E3 jb short 0x230C
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:22E3");
        }
    label_100D_22E5_123B5_32955:
        CheckExternalEvents(cs1, 0x22E5);
        // 100D:22E5 mov word ptr SS:[BP+4],CX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = CX;
        // 100D:22E8 mov word ptr SS:[BP+6],DX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = DX;
        // 100D:22EB or byte ptr DS:[0x00BF],6
        UInt8[DS, (ushort)0x00BF] = Alu8.Or(UInt8[DS, (ushort)0x00BF], (byte)0x06);
        // 100D:22F0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2318_123E8(int loadOffset)
    {
    label_100D_2318_123E8_33841:
        CheckExternalEvents(cs1, 0x2318);
        // 100D:2318 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:231A mov SI,0x10C7
        SI = (ushort)0x10C7;
    label_100D_231D_123ED_33844:
        CheckExternalEvents(cs1, 0x231D);
        // 100D:231D add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:2320 cmp AL,byte ptr DS:[SI]
        Alu8.Sub(AL, UInt8[DS, SI]);
        // 100D:2322 jne short 0x231D
        if (!ZeroFlag)
        {
            goto label_100D_231D_123ED_33844;
        }
    label_100D_2324_123F4_33848:
        CheckExternalEvents(cs1, 0x2324);
        // 100D:2324 call near 0x235F
        NearCall(cs1, 0x2327, unknown_100D_235F_1242F);
    label_100D_2327_123F7_33863:
        CheckExternalEvents(cs1, 0x2327);
        // 100D:2327 call near 0x1AC5
        NearCall(cs1, 0x232A, unknown_100D_1AC5_11B95);
    label_100D_232A_123FA_33865:
        CheckExternalEvents(cs1, 0x232A);
        // 100D:232A sub AL,byte ptr DS:[SI+3]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)3)]);
        // 100D:232D test byte ptr DS:[SI+2],8
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x08);
        // 100D:2331 jne short 0x2339
        if (!ZeroFlag)
        {
            goto label_100D_2339_12409_33872;
        }
    label_100D_2333_12403_33869:
        CheckExternalEvents(cs1, 0x2333);
        // 100D:2333 mov AL,1
        AL = (byte)0x01;
        // 100D:2335 or byte ptr DS:[SI+2],8
        UInt8[DS, (ushort)(SI + (sbyte)2)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x08);
    label_100D_2339_12409_33872:
        CheckExternalEvents(cs1, 0x2339);
        // 100D:2339 mov byte ptr DS:[0x001E],AL
        UInt8[DS, (ushort)0x001E] = AL;
        // 100D:233C mov byte ptr DS:[0x009D],0
        UInt8[DS, (ushort)0x009D] = (byte)0x00;
        // 100D:2341 mov AX,word ptr DS:[0]
        AX = UInt16[DS, (ushort)0x0000];
        // 100D:2344 and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
    label_100D_2347_12417_33876:
        CheckExternalEvents(cs1, 0x2347);
        // 100D:2347 cmp AL,byte ptr DS:[0x1141]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1141]);
        // 100D:234B jb short 0x2353
        if (CarryFlag)
        {
            goto label_100D_2353_12423_33878;
        }
    label_100D_234D_1241D_34070:
        CheckExternalEvents(cs1, 0x234D);
        // 100D:234D sub AL,byte ptr DS:[0x1141]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x1141]);
        // 100D:2351 jmp short 0x2347
        goto label_100D_2347_12417_33876;
    label_100D_2353_12423_33878:
        CheckExternalEvents(cs1, 0x2353);
        // 100D:2353 add AX,0x00E8
        AX = Alu16.Add(AX, (ushort)0x00E8);
        // 100D:2356 mov word ptr DS:[0x11F1],AX
        UInt16[DS, (ushort)0x11F1] = AX;
        // 100D:2359 mov byte ptr DS:[0x009F],0
        UInt8[DS, (ushort)0x009F] = (byte)0x00;
        // 100D:235E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_235F_1242F(int loadOffset)
    {
    label_100D_235F_1242F_33850:
        CheckExternalEvents(cs1, 0x235F);
        // 100D:235F mov word ptr DS:[0x10B4],SI
        UInt16[DS, (ushort)0x10B4] = SI;
        // 100D:2363 mov AL,byte ptr DS:[SI+2]
        AL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:2366 mov byte ptr DS:[0x001C],AL
        UInt8[DS, (ushort)0x001C] = AL;
        // 100D:2369 mov AX,word ptr DS:[SI+0x0E]
        AX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:236C mov word ptr DS:[0x0020],AX
        UInt16[DS, (ushort)0x0020] = AX;
        // 100D:236F mov byte ptr DS:[0x001F],0
        UInt8[DS, (ushort)0x001F] = (byte)0x00;
        // 100D:2374 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:2376 je short 0x2381
        if (ZeroFlag)
        {
            goto label_100D_2381_12451_33859;
        }
    label_100D_2378_12448_34064:
        CheckExternalEvents(cs1, 0x2378);
        // 100D:2378 call near 0x1AC5
        NearCall(cs1, 0x237B, unknown_100D_1AC5_11B95);
    label_100D_237B_1244B_34066:
        CheckExternalEvents(cs1, 0x237B);
        // 100D:237B sub AL,byte ptr DS:[SI+0x10]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)16)]);
        // 100D:237E mov byte ptr DS:[0x001F],AL
        UInt8[DS, (ushort)0x001F] = AL;
    label_100D_2381_12451_33859:
        CheckExternalEvents(cs1, 0x2381);
        // 100D:2381 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:2384 mov byte ptr DS:[0x001D],AL
        UInt8[DS, (ushort)0x001D] = AL;
        // 100D:2387 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_23D5_124A5(int loadOffset)
    {
    label_100D_23D5_124A5_34046:
        CheckExternalEvents(cs1, 0x23D5);
        // 100D:23D5 mov AL,byte ptr DS:[0x009D]
        AL = UInt8[DS, (ushort)0x009D];
        // 100D:23D8 mov AH,AL
        AH = AL;
        // 100D:23DA shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:23DC shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:23DE shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:23E0 sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 100D:23E2 mov byte ptr DS:[0x009D],AL
        UInt8[DS, (ushort)0x009D] = AL;
        // 100D:23E5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_23E6_124B6(int loadOffset)
    {
    label_100D_23E6_124B6_33999:
        CheckExternalEvents(cs1, 0x23E6);
        // 100D:23E6 and byte ptr DS:[DI+2],0x9F
        UInt8[DS, (ushort)(DI + (sbyte)2)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)2)], (byte)0x9F);
        // 100D:23EA xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:23EC xchg AL,byte ptr DS:[0x009D]
        ushort xchgOffset_100D_23EC_124BC = (ushort)0x009D;
        byte temp_100D_23EC_124BC = AL;
        AL = UInt8[DS, xchgOffset_100D_23EC_124BC];
        UInt8[DS, xchgOffset_100D_23EC_124BC] = unchecked((byte)temp_100D_23EC_124BC);
        // 100D:23F0 add word ptr DS:[0x0020],AX
        UInt16[DS, (ushort)0x0020] = Alu16.Add(UInt16[DS, (ushort)0x0020], AX);
        // 100D:23F4 add word ptr DS:[DI+0x0E],AX
        UInt16[DS, (ushort)(DI + (sbyte)14)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)14)], AX);
        // 100D:23F7 cmp AX,word ptr DS:[DI+0x0E]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)14)]);
        // 100D:23FA jne short 0x2400
        if (!ZeroFlag)
        {
            goto label_100D_2400_124D0_34009;
        }
    label_100D_23FC_124CC_34007:
        CheckExternalEvents(cs1, 0x23FC);
        // 100D:23FC inc byte ptr DS:[0x0022]
        UInt8[DS, (ushort)0x0022] = Alu8.Inc(UInt8[DS, (ushort)0x0022]);
    label_100D_2400_124D0_34009:
        CheckExternalEvents(cs1, 0x2400);
        // 100D:2400 call near 0x1AC5
        NearCall(cs1, 0x2403, unknown_100D_1AC5_11B95);
    label_100D_2403_124D3_34010:
        CheckExternalEvents(cs1, 0x2403);
        // 100D:2403 mov byte ptr DS:[DI+0x10],AL
        UInt8[DS, (ushort)(DI + (sbyte)16)] = AL;
        // 100D:2406 mov AX,word ptr DS:[0x11F1]
        AX = UInt16[DS, (ushort)0x11F1];
        // 100D:2409 sub AX,0x00E8
        AX = Alu16.Sub(AX, (ushort)0x00E8);
        // 100D:240C mov BX,AX
        BX = AX;
        // 100D:240E dec byte ptr DS:[BX+DI+4]
        UInt8[DS, (ushort)(BX + DI + (sbyte)4)] = Alu8.Dec(UInt8[DS, (ushort)(BX + DI + (sbyte)4)]);
        // 100D:2411 mov SI,word ptr DS:[0x114E]
        SI = UInt16[DS, (ushort)0x114E];
        // 100D:2415 inc byte ptr DS:[BX+SI+0x14]
        UInt8[DS, (ushort)(BX + SI + (sbyte)20)] = Alu8.Inc(UInt8[DS, (ushort)(BX + SI + (sbyte)20)]);
        // 100D:2418 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_24D2_125A2(int loadOffset)
    {
    label_100D_24D2_125A2_33252:
        CheckExternalEvents(cs1, 0x24D2);
        // 100D:24D2 mov AL,byte ptr DS:[0x00BE]
        AL = UInt8[DS, (ushort)0x00BE];
        // 100D:24D5 xor CL,CL
        CL = Alu8.Xor(CL, CL);
        // 100D:24D7 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:24D9 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:24DB adc AH,CL
        AH = Alu8.Adc(AH, CL);
        // 100D:24DD cmp AL,0x40
        Alu8.Sub(AL, (byte)0x40);
        // 100D:24DF adc AH,CL
        AH = Alu8.Adc(AH, CL);
        // 100D:24E1 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:24E3 adc AH,CL
        AH = Alu8.Adc(AH, CL);
        // 100D:24E5 cmp AL,0x90
        Alu8.Sub(AL, (byte)0x90);
        // 100D:24E7 adc AH,CL
        AH = Alu8.Adc(AH, CL);
        // 100D:24E9 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:24EB adc AH,CL
        AH = Alu8.Adc(AH, CL);
        // 100D:24ED ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2524_125F4(int loadOffset)
    {
    label_100D_2524_125F4_33061:
        CheckExternalEvents(cs1, 0x2524);
        // 100D:2524 sub word ptr DS:[0x00A0],AX
        UInt16[DS, (ushort)0x00A0] = Alu16.Sub(UInt16[DS, (ushort)0x00A0], AX);
        // 100D:2528 add word ptr DS:[0x1172],AX
        UInt16[DS, (ushort)0x1172] = Alu16.Add(UInt16[DS, (ushort)0x1172], AX);
        // 100D:252C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2555_12625(int loadOffset)
    {
    label_100D_2555_12625_33117:
        CheckExternalEvents(cs1, 0x2555);
        // 100D:2555 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:2557 call near 0xAB15
        NearCall(cs1, 0x255A, unknown_100D_AB15_1ABE5);
    label_100D_255A_1262A_33120:
        CheckExternalEvents(cs1, 0x255A);
        // 100D:255A mov DX,0x008C
        DX = (ushort)0x008C;
        // 100D:255D mov BX,0x0027
        BX = (ushort)0x0027;
        // 100D:2560 mov AX,0x001B
        AX = (ushort)0x001B;
        // 100D:2563 jmp near 0xC22F
        return unknown_100D_C22F_1C2FF(0x0000);
    }

    public virtual Action unknown_100D_2566_12636(int loadOffset)
    {
    entrydispatcher:
    label_100D_2566_12636_33049:
        CheckExternalEvents(cs1, 0x2566);
        // 100D:2566 mov SI,0x1008
        SI = (ushort)0x1008;
        // 100D:2569 push AX
        Stack.Push16(AX);
        // 100D:256A call near 0x40E6
        NearCall(cs1, 0x256D, unknown_100D_40E6_141B6);
    label_100D_256D_1263D_33057:
        CheckExternalEvents(cs1, 0x256D);
        // 100D:256D pop AX
        AX = Stack.Pop16();
        // 100D:256E mov BX,AX
        BX = AX;
        // 100D:2570 call near 0x2524
        NearCall(cs1, 0x2573, unknown_100D_2524_125F4);
    label_100D_2573_12643_33065:
        CheckExternalEvents(cs1, 0x2573);
        // 100D:2573 mov AX,BX
        AX = BX;
        // 100D:2575 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:2577 xchg AL,AH
        byte temp_100D_2577_12647 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_2577_12647);
        // 100D:2579 xchg AL,DL
        byte temp_100D_2579_12649 = AL;
        AL = DL;
        DL = unchecked((byte)temp_100D_2579_12649);
        // 100D:257B div word ptr DS:[0x00BC]
        ushort divisor_100D_257B_1264B = UInt16[DS, (ushort)0x00BC];
        uint dividend_100D_257B_1264B = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_257B_1264B = Alu16.Div(unchecked((uint)dividend_100D_257B_1264B), unchecked((ushort)divisor_100D_257B_1264B));
        AX = unchecked((ushort)quotient_100D_257B_1264B);
        DX = unchecked((ushort)(dividend_100D_257B_1264B % unchecked((uint)divisor_100D_257B_1264B)));
        // 100D:257F cmp AX,0x0200
        Alu16.Sub(AX, (ushort)0x0200);
        // 100D:2582 jb short 0x2587
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2582");
        }
    label_100D_2587_12657_33073:
        CheckExternalEvents(cs1, 0x2587);
        // 100D:2587 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:2589 jne short 0x258D
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2589");
        }
    label_100D_258D_1265D_33076:
        CheckExternalEvents(cs1, 0x258D);
        // 100D:258D mov byte ptr DS:[0x00BE],AL
        UInt8[DS, (ushort)0x00BE] = AL;
        // 100D:2590 mov AH,0x40
        AH = (byte)0x40;
        // 100D:2592 mov BX,7
        BX = (ushort)0x0007;
        // 100D:2595 cmp AL,0xC0
        Alu8.Sub(AL, (byte)0xC0);
        // 100D:2597 jae short 0x25B3
        if (!CarryFlag)
        {
            goto label_100D_25B3_12683_33086;
        }
    label_100D_2599_12669_33082:
        CheckExternalEvents(cs1, 0x2599);
        // 100D:2599 dec BX
        BX = Alu16.Dec(BX);
        // 100D:259A cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:259C ja short 0x25B3
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_25B3_12683_33086;
        }
    label_100D_259E_1266E_40590:
        CheckExternalEvents(cs1, 0x259E);
        // 100D:259E dec BX
        BX = Alu16.Dec(BX);
        // 100D:259F xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:25A1 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:25A3 je short 0x25B3
        if (ZeroFlag)
        {
            goto label_100D_25B3_12683_33086;
        }
    label_100D_25A5_12675_40596:
        CheckExternalEvents(cs1, 0x25A5);
        VerifySpeculativeEntryOrFail(cs1, 0x25A5, [(byte)0x4B]);
        // 100D:25A5 dec BX
        BX = Alu16.Dec(BX);
        VerifySpeculativeEntryOrFail(cs1, 0x25A6, [(byte)0xB4, (byte)0x08]);
        // 100D:25A6 mov AH,8
        AH = (byte)0x08;
        VerifySpeculativeEntryOrFail(cs1, 0x25A8, [(byte)0x84, (byte)0x26, (byte)0xBF, (byte)0x00]);
        // 100D:25A8 and byte ptr DS:[0x00BF],AH
        Alu8.And(UInt8[DS, (ushort)0x00BF], AH);
        VerifySpeculativeEntryOrFail(cs1, 0x25AC, [(byte)0x74, (byte)0x05]);
        // 100D:25AC je short 0x25B3
        if (ZeroFlag)
        {
            goto label_100D_25B3_12683_33086;
        }
    label_100D_25AE_1267E_40602:
        CheckExternalEvents(cs1, 0x25AE);
        VerifySpeculativeEntryOrFail(cs1, 0x25AE, [(byte)0xC6, (byte)0x06, (byte)0xBE, (byte)0x00, (byte)0x00]);
        // 100D:25AE mov byte ptr DS:[0x00BE],0
        UInt8[DS, (ushort)0x00BE] = (byte)0x00;
    label_100D_25B3_12683_33086:
        CheckExternalEvents(cs1, 0x25B3);
        // 100D:25B3 or AH,0x80
        AH = Alu8.Or(AH, (byte)0x80);
        // 100D:25B6 mov byte ptr DS:[0x00BF],AH
        UInt8[DS, (ushort)0x00BF] = AH;
        // 100D:25BA mov SI,0x118D
        SI = (ushort)0x118D;
        // 100D:25BD add word ptr DS:[SI],BX
        UInt16[DS, SI] = Alu16.Add(UInt16[DS, SI], BX);
        // 100D:25BF mov BL,byte ptr DS:[0x00C3]
        BL = UInt8[DS, (ushort)0x00C3];
        // 100D:25C3 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 100D:25C5 and BX,3
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:25C8 call near 0xE3B7
        NearCall(cs1, 0x25CB, unknown_100D_E3B7_1E487);
    label_100D_25CB_1269B_33095:
        CheckExternalEvents(cs1, 0x25CB);
        // 100D:25CB add word ptr DS:[SI],AX
        UInt16[DS, SI] = Alu16.Add(UInt16[DS, SI], AX);
        // 100D:25CD call near 0x1AC5
        NearCall(cs1, 0x25D0, unknown_100D_1AC5_11B95);
    label_100D_25D0_126A0_33098:
        CheckExternalEvents(cs1, 0x25D0);
        // 100D:25D0 sub AX,word ptr DS:[SI]
        AX = Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:25D2 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:25D4 mov byte ptr DS:[0x00CF],AL
        UInt8[DS, (ushort)0x00CF] = AL;
        // 100D:25D7 mov word ptr DS:[0x1158],0
        UInt16[DS, (ushort)0x1158] = (ushort)0x0000;
        // 100D:25DD call near 0x2806
        NearCall(cs1, 0x25E0, unknown_100D_2806_128D6);
    label_100D_25E0_126B0_33104:
        CheckExternalEvents(cs1, 0x25E0);
        // 100D:25E0 call near 0x2795
        NearCall(cs1, 0x25E3, unknown_100D_2795_12865);
    label_100D_25E3_126B3_33106:
        CheckExternalEvents(cs1, 0x25E3);
        // 100D:25E3 call near 0xC49A
        NearCall(cs1, 0x25E6, unknown_100D_C49A_1C56A);
    label_100D_25E6_126B6_33108:
        CheckExternalEvents(cs1, 0x25E6);
        // 100D:25E6 mov AX,0x002C
        AX = (ushort)0x002C;
        // 100D:25E9 call near 0xC13E
        NearCall(cs1, 0x25EC, unknown_100D_C13E_1C20E);
    label_100D_25EC_126BC_33111:
        CheckExternalEvents(cs1, 0x25EC);
        // 100D:25EC call near 0xC0F4
        NearCall(cs1, 0x25EF, unknown_100D_C0F4_1C1C4);
    label_100D_25EF_126BF_33113:
        CheckExternalEvents(cs1, 0x25EF);
        // 100D:25EF mov BP,0x2555
        BP = (ushort)0x2555;
        // 100D:25F2 mov AL,8
        AL = (byte)0x08;
        // 100D:25F4 call near 0xC108
        NearCall(cs1, 0x25F7, unknown_100D_C108_1C1D8);
    label_100D_25F7_126C7_33125:
        CheckExternalEvents(cs1, 0x25F7);
        // 100D:25F7 mov AX,0x0064
        AX = (ushort)0x0064;
        // 100D:25FA call near 0xDDB0
        NearCall(cs1, 0x25FD, unknown_100D_DDB0_1DE80);
    label_100D_25FD_126CD_33128:
        CheckExternalEvents(cs1, 0x25FD);
        // 100D:25FD mov CX,0x0018
        CX = (ushort)0x0018;
        // 100D:2600 mov BP,0x0A44
        BP = (ushort)0x0A44;
        // 100D:2603 mov AL,6
        AL = (byte)0x06;
        // 100D:2605 call near 0xC108
        NearCall(cs1, 0x2608, unknown_100D_C108_1C1D8);
    label_100D_2608_126D8_33133:
        CheckExternalEvents(cs1, 0x2608);
        // 100D:2608 mov CX,0x0018
        CX = (ushort)0x0018;
    label_100D_260B_126DB_33135:
        CheckExternalEvents(cs1, 0x260B);
        // 100D:260B push CX
        Stack.Push16(CX);
        // 100D:260C mov BP,0x0A44
        BP = (ushort)0x0A44;
        // 100D:260F mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:2612 dec CX
        CX = Alu16.Dec(CX);
        // 100D:2613 call near 0xE353
        NearCall(cs1, 0x2616, unknown_100D_E353_1E423);
    label_100D_2616_126E6_33140:
        CheckExternalEvents(cs1, 0x2616);
        // 100D:2616 pop CX
        CX = Stack.Pop16();
        // 100D:2617 loop 0x260B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_260B_126DB_33135;
        }
    label_100D_2619_126E9_33145:
        CheckExternalEvents(cs1, 0x2619);
        // 100D:2619 mov AX,0x0027
        AX = (ushort)0x0027;
        // 100D:261C call near 0xAB4F
        NearCall(cs1, 0x261F, unknown_100D_AB4F_1AC1F);
    label_100D_261F_126EF_33148:
        CheckExternalEvents(cs1, 0x261F);
        // 100D:261F mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:2622 mov BP,0x15AA
        BP = (ushort)0x15AA;
        // 100D:2625 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:2629 call far dword ptr DS:[0x3919]
        ushort targetSegment_33152 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3919 + (ushort)0x0002)]));
        ushort targetOffset_33152 = unchecked((ushort)(UInt16[DS, (ushort)0x3919]));
        if (targetSegment_33152 == cs2 && targetOffset_33152 == 0x014B)
        {
            FarCall(cs1, 0x262D, cs2, unknown_3358_014B_336CB);
            goto label_100D_262D_126FD_33153;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_33152:X4}:{targetOffset_33152:X4} at 100D:2629");
    label_100D_262D_126FD_33153:
        CheckExternalEvents(cs1, 0x262D);
        // 100D:262D mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 100D:2630 call near 0xDDB0
        NearCall(cs1, 0x2633, unknown_100D_DDB0_1DE80);
    label_100D_2633_12703_33156:
        CheckExternalEvents(cs1, 0x2633);
        // 100D:2633 call near 0xABA9
        NearCall(cs1, 0x2636, unknown_100D_ABA9_1AC79);
    label_100D_2636_12706_33158:
        CheckExternalEvents(cs1, 0x2636);
        // 100D:2636 mov AL,1
        AL = (byte)0x01;
        // 100D:2638 call near 0xAB15
        NearCall(cs1, 0x263B, unknown_100D_AB15_1ABE5);
    label_100D_263B_1270B_33161:
        CheckExternalEvents(cs1, 0x263B);
        // 100D:263B mov CX,1
        CX = (ushort)0x0001;
        // 100D:263E push CX
        Stack.Push16(CX);
        // 100D:263F mov SI,0x15B2
        SI = (ushort)0x15B2;
    label_100D_2642_12712_33165:
        CheckExternalEvents(cs1, 0x2642);
        // 100D:2642 push SI
        Stack.Push16(SI);
        // 100D:2643 mov BP,0x26AC
        BP = (ushort)0x26AC;
        // 100D:2646 mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:2649 call near 0xE353
        NearCall(cs1, 0x264C, unknown_100D_E353_1E423);
    label_100D_264C_1271C_33193:
        CheckExternalEvents(cs1, 0x264C);
        // 100D:264C pop SI
        SI = Stack.Pop16();
        // 100D:264D cmp SI,0x161E
        Alu16.Sub(SI, (ushort)0x161E);
        // 100D:2651 jne short 0x2656
        if (!ZeroFlag)
        {
            goto label_100D_2656_12726_33197;
        }
    label_100D_2653_12723_33202:
        CheckExternalEvents(cs1, 0x2653);
        // 100D:2653 call near 0xAC30
        NearCall(cs1, 0x2656, unknown_100D_AC30_1AD00);
    label_100D_2656_12726_33197:
        CheckExternalEvents(cs1, 0x2656);
        // 100D:2656 add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:2659 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:265C jne short 0x2642
        if (!ZeroFlag)
        {
            goto label_100D_2642_12712_33165;
        }
    label_100D_265E_1272E_33204:
        CheckExternalEvents(cs1, 0x265E);
        // 100D:265E pop CX
        CX = Stack.Pop16();
        // 100D:265F loop 0x263E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:265F");
        }
    label_100D_2661_12731_33207:
        CheckExternalEvents(cs1, 0x2661);
        // 100D:2661 call near 0x26AC
        NearCall(cs1, 0x2664, unknown_100D_26AC_1277C);
    label_100D_2664_12734_33209:
        CheckExternalEvents(cs1, 0x2664);
        // 100D:2664 xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_100D_2666_12736_33211:
        CheckExternalEvents(cs1, 0x2666);
        // 100D:2666 inc CX
        CX = Alu16.Inc(CX);
        // 100D:2667 push CX
        Stack.Push16(CX);
        // 100D:2668 mov BP,0x0A44
        BP = (ushort)0x0A44;
        // 100D:266B mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:266E call near 0xE353
        NearCall(cs1, 0x2671, unknown_100D_E353_1E423);
    label_100D_2671_12741_33216:
        CheckExternalEvents(cs1, 0x2671);
        // 100D:2671 pop CX
        CX = Stack.Pop16();
        // 100D:2672 cmp CX,0x0019
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)25)));
        // 100D:2675 jb short 0x2666
        if (CarryFlag)
        {
            goto label_100D_2666_12736_33211;
        }
    label_100D_2677_12747_33221:
        CheckExternalEvents(cs1, 0x2677);
        // 100D:2677 mov byte ptr DS:[0x47A9],1
        UInt8[DS, (ushort)0x47A9] = (byte)0x01;
        // 100D:267C mov BP,0x2DB1
        BP = (ushort)0x2DB1;
        // 100D:267F call near 0xC097
        NearCall(cs1, 0x2682, unknown_100D_C097_1C167);
    label_100D_2682_12752_33225:
        CheckExternalEvents(cs1, 0x2682);
        // 100D:2682 mov AX,0x002C
        AX = (ushort)0x002C;
        // 100D:2685 call near 0xC13E
        NearCall(cs1, 0x2688, unknown_100D_C13E_1C20E);
    label_100D_2688_12758_33228:
        CheckExternalEvents(cs1, 0x2688);
        // 100D:2688 mov AL,6
        AL = (byte)0x06;
        // 100D:268A mov BP,0x2555
        BP = (ushort)0x2555;
        // 100D:268D call near 0xC108
        NearCall(cs1, 0x2690, unknown_100D_C108_1C1D8);
    label_100D_2690_12760_33232:
        CheckExternalEvents(cs1, 0x2690);
        // 100D:2690 mov BP,0x2DB1
        BP = (ushort)0x2DB1;
        // 100D:2693 call near 0xC097
        NearCall(cs1, 0x2696, unknown_100D_C097_1C167);
    label_100D_2696_12766_33235:
        CheckExternalEvents(cs1, 0x2696);
        // 100D:2696 mov byte ptr DS:[0x47A9],0
        UInt8[DS, (ushort)0x47A9] = (byte)0x00;
        // 100D:269B mov BP,0x26A6
        BP = (ushort)0x26A6;
        // 100D:269E mov AL,8
        AL = (byte)0x08;
        // 100D:26A0 call near 0xC108
        NearCall(cs1, 0x26A3, unknown_100D_C108_1C1D8);
    label_100D_26A3_12773_33244:
        CheckExternalEvents(cs1, 0x26A3);
        // 100D:26A3 jmp near 0x2773
        if (JumpDispatcher.Jump(unknown_100D_2773_12843, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_26A6_12776(int loadOffset)
    {
    label_100D_26A6_12776_33240:
        CheckExternalEvents(cs1, 0x26A6);
        // 100D:26A6 call near 0xC43E
        NearCall(cs1, 0x26A9, unknown_100D_C43E_1C50E);
    label_100D_26A9_12779_33242:
        CheckExternalEvents(cs1, 0x26A9);
        // 100D:26A9 jmp near 0x1797
        return unknown_100D_1797_11867(0x0000);
    }

    public virtual Action unknown_100D_26AC_1277C(int loadOffset)
    {
    label_100D_26AC_1277C_33169:
        CheckExternalEvents(cs1, 0x26AC);
        // 100D:26AC push SI
        Stack.Push16(SI);
        // 100D:26AD mov BP,0x15AA
        BP = (ushort)0x15AA;
        // 100D:26B0 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:26B3 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:26B7 call far dword ptr DS:[0x391D]
        ushort targetSegment_33174 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x391D + (ushort)0x0002)]));
        ushort targetOffset_33174 = unchecked((ushort)(UInt16[DS, (ushort)0x391D]));
        if (targetSegment_33174 == cs2 && targetOffset_33174 == 0x014E)
        {
            FarCall(cs1, 0x26BB, cs2, unknown_3358_014E_336CE);
            goto label_100D_26BB_1278B_33175;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_33174:X4}:{targetOffset_33174:X4} at 100D:26B7");
    label_100D_26BB_1278B_33175:
        CheckExternalEvents(cs1, 0x26BB);
        // 100D:26BB pop SI
        SI = Stack.Pop16();
        // 100D:26BC lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:26BD or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:26BF js short 0x26CB
        if (SignFlag)
        {
            goto label_100D_26CB_1279B_33187;
        }
    label_100D_26C1_12791_33180:
        CheckExternalEvents(cs1, 0x26C1);
        // 100D:26C1 mov BX,AX
        BX = AX;
        // 100D:26C3 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:26C4 mov DX,AX
        DX = AX;
        // 100D:26C6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:26C7 xchg BX,AX
        ushort temp_100D_26C7_12797 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_26C7_12797);
        // 100D:26C8 call near 0xC22F
        NearCall(cs1, 0x26CB, unknown_100D_C22F_1C2FF);
    label_100D_26CB_1279B_33187:
        CheckExternalEvents(cs1, 0x26CB);
        // 100D:26CB mov DX,0x007E
        DX = (ushort)0x007E;
        // 100D:26CE mov BX,0x004C
        BX = (ushort)0x004C;
        // 100D:26D1 mov BP,0x00C2
        BP = (ushort)0x00C2;
        // 100D:26D4 mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:26D7 jmp near 0xC526
        return unknown_100D_C526_1C5F6(0x0000);
    }

    public virtual Action unknown_100D_272F_127FF(int loadOffset)
    {
    label_100D_272F_127FF_35798:
        CheckExternalEvents(cs1, 0x272F);
        // 100D:272F mov CL,byte ptr DS:[0x00C8]
        CL = UInt8[DS, (ushort)0x00C8];
        // 100D:2733 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:2735 jcxz short 0x274D
        if (CX == (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2735");
        }
    label_100D_2737_12807_35802:
        CheckExternalEvents(cs1, 0x2737);
        // 100D:2737 mov SI,0x1179
        SI = (ushort)0x1179;
        // 100D:273A dec byte ptr DS:[0x00C8]
        UInt8[DS, (ushort)0x00C8] = Alu8.Dec(UInt8[DS, (ushort)0x00C8]);
        // 100D:273E mov DI,SI
        DI = SI;
        // 100D:2740 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:2743 push DS
        Stack.Push16(DS);
        // 100D:2744 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:2745 mov CX,9
        CX = (ushort)0x0009;
        // 100D:2748 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:274A xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:274C stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:274D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_274E_1281E(int loadOffset)
    {
    label_100D_274E_1281E_31612:
        CheckExternalEvents(cs1, 0x274E);
        // 100D:274E call near 0xC08E
        NearCall(cs1, 0x2751, unknown_100D_C08E_1C15E);
    label_100D_2751_12821_31614:
        CheckExternalEvents(cs1, 0x2751);
        // 100D:2751 mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:2754 call near 0xC13E
        NearCall(cs1, 0x2757, unknown_100D_C13E_1C20E);
    label_100D_2757_12827_31617:
        CheckExternalEvents(cs1, 0x2757);
        // 100D:2757 mov SI,0x14C8
        SI = (ushort)0x14C8;
        // 100D:275A call near 0xC21B
        NearCall(cs1, 0x275D, unknown_100D_C21B_1C2EB);
    label_100D_275D_1282D_31620:
        CheckExternalEvents(cs1, 0x275D);
        // 100D:275D mov AL,1
        AL = (byte)0x01;
        return unknown_100D_275F_1282F(0x0000);
    }

    public virtual Action unknown_100D_275F_1282F(int loadOffset)
    {
    label_100D_275F_1282F_31622:
        CheckExternalEvents(cs1, 0x275F);
        // 100D:275F call near 0xC08E
        NearCall(cs1, 0x2762, unknown_100D_C08E_1C15E);
    label_100D_2762_12832_31623:
        CheckExternalEvents(cs1, 0x2762);
        // 100D:2762 and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
        // 100D:2765 add AL,0x0B
        AL = Alu8.Add(AL, (byte)0x0B);
        // 100D:2767 mov BX,0x0056
        BX = (ushort)0x0056;
        // 100D:276A mov DX,0x0064
        DX = (ushort)0x0064;
        // 100D:276D call near 0xC22F
        NearCall(cs1, 0x2770, unknown_100D_C22F_1C2FF);
    label_100D_2770_12840_31629:
        CheckExternalEvents(cs1, 0x2770);
        // 100D:2770 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_2773_12843(int loadOffset)
    {
    entrydispatcher:
    label_100D_2773_12843_31958:
        CheckExternalEvents(cs1, 0x2773);
        // 100D:2773 mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:2776 call near 0xC13E
        NearCall(cs1, 0x2779, unknown_100D_C13E_1C20E);
    label_100D_2779_12849_31961:
        CheckExternalEvents(cs1, 0x2779);
        // 100D:2779 mov AL,9
        AL = (byte)0x09;
        // 100D:277B call near 0xAB15
        NearCall(cs1, 0x277E, unknown_100D_AB15_1ABE5);
    label_100D_277E_1284E_31964:
        CheckExternalEvents(cs1, 0x277E);
        // 100D:277E mov word ptr DS:[0xD816],4
        UInt16[DS, (ushort)0xD816] = (ushort)0x0004;
    label_100D_2784_12854_31966:
        CheckExternalEvents(cs1, 0x2784);
        // 100D:2784 mov BP,0x27B6
        BP = (ushort)0x27B6;
        // 100D:2787 mov AX,9
        AX = (ushort)0x0009;
        // 100D:278A call near 0xE353
        NearCall(cs1, 0x278D, unknown_100D_E353_1E423);
    label_100D_278D_1285D_31969:
        CheckExternalEvents(cs1, 0x278D);
        // 100D:278D dec word ptr DS:[0xD816]
        UInt16[DS, (ushort)0xD816] = Alu16.Dec(UInt16[DS, (ushort)0xD816]);
        // 100D:2791 jns short 0x2784
        if (!SignFlag)
        {
            goto label_100D_2784_12854_31966;
        }
    label_100D_2793_12863_31973:
        CheckExternalEvents(cs1, 0x2793);
        // 100D:2793 jmp short 0x274E
        return unknown_100D_274E_1281E(0x0000);
    }

    public virtual Action unknown_100D_2795_12865(int loadOffset)
    {
    label_100D_2795_12865_31800:
        CheckExternalEvents(cs1, 0x2795);
        // 100D:2795 mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:2798 call near 0xC13E
        NearCall(cs1, 0x279B, unknown_100D_C13E_1C20E);
    label_100D_279B_1286B_31803:
        CheckExternalEvents(cs1, 0x279B);
        // 100D:279B mov word ptr DS:[0xD816],0
        UInt16[DS, (ushort)0xD816] = (ushort)0x0000;
    label_100D_27A1_12871_31805:
        CheckExternalEvents(cs1, 0x27A1);
        // 100D:27A1 mov BP,0x27B6
        BP = (ushort)0x27B6;
        // 100D:27A4 mov AX,9
        AX = (ushort)0x0009;
        // 100D:27A7 call near 0xE353
        NearCall(cs1, 0x27AA, unknown_100D_E353_1E423);
    label_100D_27AA_1287A_31816:
        CheckExternalEvents(cs1, 0x27AA);
        // 100D:27AA inc word ptr DS:[0xD816]
        UInt16[DS, (ushort)0xD816] = Alu16.Inc(UInt16[DS, (ushort)0xD816]);
        // 100D:27AE cmp word ptr DS:[0xD816],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0xD816], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:27B3 jb short 0x27A1
        if (CarryFlag)
        {
            goto label_100D_27A1_12871_31805;
        }
    label_100D_27B5_12885_31824:
        CheckExternalEvents(cs1, 0x27B5);
        // 100D:27B5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_27B6_12886(int loadOffset)
    {
    label_100D_27B6_12886_31808:
        CheckExternalEvents(cs1, 0x27B6);
        // 100D:27B6 mov AX,word ptr DS:[0xD816]
        AX = UInt16[DS, (ushort)0xD816];
        // 100D:27B9 and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
        // 100D:27BC cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:27BE jb short 0x27C4
        if (CarryFlag)
        {
            goto label_100D_27C4_12894_31813;
        }
    label_100D_27C0_12890_31821:
        CheckExternalEvents(cs1, 0x27C0);
        // 100D:27C0 sub AL,8
        AL = Alu8.Sub(AL, (byte)0x08);
        // 100D:27C2 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_27C4_12894_31813:
        CheckExternalEvents(cs1, 0x27C4);
        // 100D:27C4 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:27C6 call near 0x275F
        NearCall(cs1, 0x27C9, unknown_100D_275F_1282F);
        return unknown_100D_27C9_12899(0x0000);
    }

    public virtual Action unknown_100D_27C9_12899(int loadOffset)
    {
    label_100D_27C9_12899_31645:
        CheckExternalEvents(cs1, 0x27C9);
        // 100D:27C9 call near 0xC08E
        NearCall(cs1, 0x27CC, unknown_100D_C08E_1C15E);
    label_100D_27CC_1289C_31647:
        CheckExternalEvents(cs1, 0x27CC);
        // 100D:27CC mov BX,0x0067
        BX = (ushort)0x0067;
    label_100D_27CF_1289F_31649:
        CheckExternalEvents(cs1, 0x27CF);
        // 100D:27CF push BX
        Stack.Push16(BX);
        // 100D:27D0 mov BX,0x000F
        BX = (ushort)0x000F;
    label_100D_27D3_128A3_31651:
        CheckExternalEvents(cs1, 0x27D3);
        // 100D:27D3 call near 0xE3B7
        NearCall(cs1, 0x27D6, unknown_100D_E3B7_1E487);
    label_100D_27D6_128A6_31652:
        CheckExternalEvents(cs1, 0x27D6);
        // 100D:27D6 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 100D:27D8 je short 0x27D3
        if (ZeroFlag)
        {
            goto label_100D_27D3_128A3_31651;
        }
    label_100D_27DA_128AA_31655:
        CheckExternalEvents(cs1, 0x27DA);
        // 100D:27DA mov DL,AL
        DL = AL;
        // 100D:27DC add AX,0x0017
        AX = Alu16.Add(AX, (ushort)0x0017);
        // 100D:27DF pop BX
        BX = Stack.Pop16();
        // 100D:27E0 push DX
        Stack.Push16(DX);
        // 100D:27E1 mov DX,0x00A3
        DX = (ushort)0x00A3;
        // 100D:27E4 call near 0xC2FD
        NearCall(cs1, 0x27E7, unknown_100D_C2FD_1C3CD);
    label_100D_27E7_128B7_31662:
        CheckExternalEvents(cs1, 0x27E7);
        // 100D:27E7 pop DX
        DX = Stack.Pop16();
        // 100D:27E8 add BX,3
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:27EB cmp BX,0x0070
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)112)));
        // 100D:27EE jbe short 0x27CF
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_27CF_1289F_31649;
        }
    label_100D_27F0_128C0_31668:
        CheckExternalEvents(cs1, 0x27F0);
        // 100D:27F0 mov SI,0x14CE
        SI = (ushort)0x14CE;
        // 100D:27F3 mov AX,word ptr DS:[0xD816]
        AX = UInt16[DS, (ushort)0xD816];
        // 100D:27F6 and AX,3
        AX = Alu16.And(AX, (ushort)0x0003);
        // 100D:27F9 add AL,0x13
        AL = Alu8.Add(AL, (byte)0x13);
        // 100D:27FB mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 100D:27FD mov byte ptr DS:[SI+6],AL
        UInt8[DS, (ushort)(SI + (sbyte)6)] = AL;
        // 100D:2800 call near 0xC21B
        NearCall(cs1, 0x2803, unknown_100D_C21B_1C2EB);
    label_100D_2803_128D3_31676:
        CheckExternalEvents(cs1, 0x2803);
        // 100D:2803 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_2806_128D6(int loadOffset)
    {
    label_100D_2806_128D6_31610:
        CheckExternalEvents(cs1, 0x2806);
        // 100D:2806 call near 0x274E
        NearCall(cs1, 0x2809, unknown_100D_274E_1281E);
    label_100D_2809_128D9_31631:
        CheckExternalEvents(cs1, 0x2809);
        // 100D:2809 mov AL,2
        AL = (byte)0x02;
        // 100D:280B call near 0x275F
        NearCall(cs1, 0x280E, unknown_100D_275F_1282F);
    label_100D_280E_128DE_31635:
        CheckExternalEvents(cs1, 0x280E);
        // 100D:280E mov CX,0x0014
        CX = (ushort)0x0014;
        // 100D:2811 call near 0x281C
        NearCall(cs1, 0x2814, unknown_100D_281C_128EC);
    label_100D_2814_128E4_31689:
        CheckExternalEvents(cs1, 0x2814);
        // 100D:2814 call near 0xABA9
        NearCall(cs1, 0x2817, unknown_100D_ABA9_1AC79);
    label_100D_2817_128E7_31691:
        CheckExternalEvents(cs1, 0x2817);
        // 100D:2817 mov AL,1
        AL = (byte)0x01;
        // 100D:2819 jmp near 0x275F
        return unknown_100D_275F_1282F(0x0000);
    }

    public virtual Action unknown_100D_281C_128EC(int loadOffset)
    {
    label_100D_281C_128EC_31638:
        CheckExternalEvents(cs1, 0x281C);
        // 100D:281C mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:281F call near 0xC13E
        NearCall(cs1, 0x2822, unknown_100D_C13E_1C20E);
    label_100D_2822_128F2_31641:
        CheckExternalEvents(cs1, 0x2822);
        // 100D:2822 mov word ptr DS:[0xD816],0
        UInt16[DS, (ushort)0xD816] = (ushort)0x0000;
    label_100D_2828_128F8_31643:
        CheckExternalEvents(cs1, 0x2828);
        // 100D:2828 push CX
        Stack.Push16(CX);
        // 100D:2829 call near 0x27C9
        NearCall(cs1, 0x282C, unknown_100D_27C9_12899);
    label_100D_282C_128FC_31678:
        CheckExternalEvents(cs1, 0x282C);
        // 100D:282C mov AX,9
        AX = (ushort)0x0009;
        // 100D:282F call near 0xE3A0
        NearCall(cs1, 0x2832, unknown_100D_E3A0_1E470);
    label_100D_2832_12902_31681:
        CheckExternalEvents(cs1, 0x2832);
        // 100D:2832 inc word ptr DS:[0xD816]
        UInt16[DS, (ushort)0xD816] = Alu16.Inc(UInt16[DS, (ushort)0xD816]);
        // 100D:2836 pop CX
        CX = Stack.Pop16();
        // 100D:2837 loop 0x2828
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2828_128F8_31643;
        }
    label_100D_2839_12909_31687:
        CheckExternalEvents(cs1, 0x2839);
        // 100D:2839 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_28A1_12971(int loadOffset)
    {
    entrydispatcher:
    label_100D_28A1_12971_31797:
        CheckExternalEvents(cs1, 0x28A1);
        // 100D:28A1 mov byte ptr DS:[0x47A9],AL
        UInt8[DS, (ushort)0x47A9] = AL;
        // 100D:28A4 call near 0x2795
        NearCall(cs1, 0x28A7, unknown_100D_2795_12865);
    label_100D_28A7_12977_31826:
        CheckExternalEvents(cs1, 0x28A7);
        // 100D:28A7 call near 0xC49A
        NearCall(cs1, 0x28AA, unknown_100D_C49A_1C56A);
    label_100D_28AA_1297A_31836:
        CheckExternalEvents(cs1, 0x28AA);
        // 100D:28AA call near 0xABA9
        NearCall(cs1, 0x28AD, unknown_100D_ABA9_1AC79);
    label_100D_28AD_1297D_31838:
        CheckExternalEvents(cs1, 0x28AD);
        // 100D:28AD mov BP,0x28B5
        BP = (ushort)0x28B5;
        // 100D:28B0 mov AL,8
        AL = (byte)0x08;
        // 100D:28B2 jmp near 0xC108
        if (JumpDispatcher.Jump(unknown_100D_C108_1C1D8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_28B5_12985(int loadOffset)
    {
    label_100D_28B5_12985_31842:
        CheckExternalEvents(cs1, 0x28B5);
        // 100D:28B5 mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:28B8 call near 0xC13E
        NearCall(cs1, 0x28BB, unknown_100D_C13E_1C20E);
    label_100D_28BB_1298B_31845:
        CheckExternalEvents(cs1, 0x28BB);
        // 100D:28BB mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:28BD call near 0xAB15
        NearCall(cs1, 0x28C0, unknown_100D_AB15_1ABE5);
    label_100D_28C0_12990_31848:
        CheckExternalEvents(cs1, 0x28C0);
        // 100D:28C0 mov AL,byte ptr DS:[0x47A9]
        AL = UInt8[DS, (ushort)0x47A9];
        // 100D:28C3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:28C5 mov SI,AX
        SI = AX;
        // 100D:28C7 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:28C9 mov DX,word ptr DS:[SI+0x225D]
        DX = UInt16[DS, (ushort)(SI + (short)8797)];
        // 100D:28CD xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:28CF xchg BL,DH
        byte temp_100D_28CF_1299F = BL;
        BL = DH;
        DH = unchecked((byte)temp_100D_28CF_1299F);
        // 100D:28D1 add AX,0x001E
        AX = Alu16.Add(AX, (ushort)0x001E);
        // 100D:28D4 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:28D6 mov word ptr DS:[SI+0x47F8],DX
        UInt16[DS, (ushort)(SI + (short)18424)] = DX;
        // 100D:28DA mov word ptr DS:[SI+0x47FA],BX
        UInt16[DS, (ushort)(SI + (short)18426)] = BX;
        // 100D:28DE jmp near 0xC22F
        return unknown_100D_C22F_1C2FF(0x0000);
    }

    public virtual Action unknown_100D_28E1_129B1(int loadOffset)
    {
    label_100D_28E1_129B1_31780:
        CheckExternalEvents(cs1, 0x28E1);
        // 100D:28E1 cmp byte ptr DS:[0x0024],0x0C
        Alu8.Sub(UInt8[DS, (ushort)0x0024], (byte)0x0C);
        // 100D:28E6 jne short 0x28EB
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:28E6");
        }
    label_100D_28EB_129BB_31783:
        CheckExternalEvents(cs1, 0x28EB);
        // 100D:28EB cmp byte ptr DS:[0x47A9],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A9], (byte)0x00);
        // 100D:28F0 je short 0x290A
        if (ZeroFlag)
        {
            goto label_100D_290A_129DA_31786;
        }
    label_100D_28F2_129C2_31948:
        CheckExternalEvents(cs1, 0x28F2);
        // 100D:28F2 call near 0xC49A
        NearCall(cs1, 0x28F5, unknown_100D_C49A_1C56A);
    label_100D_28F5_129C5_31950:
        CheckExternalEvents(cs1, 0x28F5);
        // 100D:28F5 mov byte ptr DS:[0x47A6],0xFF
        UInt8[DS, (ushort)0x47A6] = (byte)0xFF;
        // 100D:28FA mov AL,8
        AL = (byte)0x08;
        // 100D:28FC mov BP,0x2DD3
        BP = (ushort)0x2DD3;
        // 100D:28FF call near 0xC108
        NearCall(cs1, 0x2902, unknown_100D_C108_1C1D8);
    label_100D_2902_129D2_31955:
        CheckExternalEvents(cs1, 0x2902);
        // 100D:2902 mov byte ptr DS:[0x47A9],0
        UInt8[DS, (ushort)0x47A9] = (byte)0x00;
        // 100D:2907 call near 0x2773
        NearCall(cs1, 0x290A, unknown_100D_2773_12843);
    label_100D_290A_129DA_31786:
        CheckExternalEvents(cs1, 0x290A);
        // 100D:290A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2997_12A67(int loadOffset)
    {
    entrydispatcher:
    label_100D_2997_12A67_31982:
        CheckExternalEvents(cs1, 0x2997);
        // 100D:2997 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x2999))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_29EE_12ABE(int loadOffset)
    {
    label_100D_29EE_12ABE_32367:
        CheckExternalEvents(cs1, 0x29EE);
        // 100D:29EE xor DI,DI
        DI = Alu16.Xor(DI, DI);
        return unknown_100D_29F0_12AC0(0x0000);
    }

    public virtual Action unknown_100D_29F0_12AC0(int loadOffset)
    {
    label_100D_29F0_12AC0_32369:
        CheckExternalEvents(cs1, 0x29F0);
        // 100D:29F0 test byte ptr DS:[0x000A],1
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x01);
        // 100D:29F5 je short 0x2A33
        if (ZeroFlag)
        {
            goto label_100D_2A33_12B03_32387;
        }
    label_100D_29F7_12AC7_32371:
        CheckExternalEvents(cs1, 0x29F7);
        // 100D:29F7 mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:29FA mov CL,byte ptr DS:[SI]
        CL = UInt8[DS, SI];
        // 100D:29FC xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:29FE jcxz short 0x2A14
        if (CX == (ushort)0x0000)
        {
            goto label_100D_2A14_12AE4_32376;
        }
    label_100D_2A00_12AD0_33681:
        CheckExternalEvents(cs1, 0x2A00);
        // 100D:2A00 inc SI
        SI = Alu16.Inc(SI);
    label_100D_2A01_12AD1_33683:
        CheckExternalEvents(cs1, 0x2A01);
        // 100D:2A01 cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:2A03 jne short 0x2A0A
        if (!ZeroFlag)
        {
            goto label_100D_2A0A_12ADA_33685;
        }
    label_100D_2A05_12AD5_40557:
        CheckExternalEvents(cs1, 0x2A05);
        // 100D:2A05 cmp DI,word ptr DS:[SI+2]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:2A08 je short 0x2A33
        if (ZeroFlag)
        {
            goto label_100D_2A33_12B03_32387;
        }
    label_100D_2A0A_12ADA_33685:
        CheckExternalEvents(cs1, 0x2A0A);
        // 100D:2A0A add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:2A0D loop 0x2A01
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2A01_12AD1_33683;
        }
    label_100D_2A0F_12ADF_33688:
        CheckExternalEvents(cs1, 0x2A0F);
        // 100D:2A0F mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:2A12 mov CL,byte ptr DS:[SI]
        CL = UInt8[DS, SI];
    label_100D_2A14_12AE4_32376:
        CheckExternalEvents(cs1, 0x2A14);
        // 100D:2A14 cmp CX,0x000A
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:2A17 jb short 0x2A25
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2A17");
        }
    label_100D_2A25_12AF5_32379:
        CheckExternalEvents(cs1, 0x2A25);
        // 100D:2A25 inc byte ptr DS:[SI]
        UInt8[DS, SI] = Alu8.Inc(UInt8[DS, SI]);
        // 100D:2A27 inc SI
        SI = Alu16.Inc(SI);
        // 100D:2A28 add CX,CX
        CX = Alu16.Add(CX, CX);
        // 100D:2A2A add CX,CX
        CX = Alu16.Add(CX, CX);
        // 100D:2A2C add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:2A2E mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:2A30 mov word ptr DS:[SI+2],DI
        UInt16[DS, (ushort)(SI + (sbyte)2)] = DI;
    label_100D_2A33_12B03_32387:
        CheckExternalEvents(cs1, 0x2A33);
        // 100D:2A33 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2A34_12B04(int loadOffset)
    {
    label_100D_2A34_12B04_32717:
        CheckExternalEvents(cs1, 0x2A34);
        // 100D:2A34 mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:2A37 dec byte ptr DS:[SI]
        UInt8[DS, SI] = Alu8.Dec(UInt8[DS, SI]);
        // 100D:2A39 jne short 0x2A3F
        if (!ZeroFlag)
        {
            goto label_100D_2A3F_12B0F_32723;
        }
    label_100D_2A3B_12B0B_32721:
        CheckExternalEvents(cs1, 0x2A3B);
        // 100D:2A3B mov byte ptr DS:[SI-1],0
        UInt8[DS, (ushort)(SI + (sbyte)-1)] = (byte)0x00;
    label_100D_2A3F_12B0F_32723:
        CheckExternalEvents(cs1, 0x2A3F);
        // 100D:2A3F inc SI
        SI = Alu16.Inc(SI);
        // 100D:2A40 mov DI,SI
        DI = SI;
        // 100D:2A42 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:2A45 push DS
        Stack.Push16(DS);
        // 100D:2A46 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:2A47 mov CX,0x0012
        CX = (ushort)0x0012;
        // 100D:2A4A rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:2A4C xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2A4E stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A4F stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A50 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2A51_12B21(int loadOffset)
    {
    label_100D_2A51_12B21_24311:
        CheckExternalEvents(cs1, 0x2A51);
        // 100D:2A51 mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:2A54 mov DL,AL
        DL = AL;
        // 100D:2A56 mov BX,DI
        BX = DI;
        // 100D:2A58 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:2A5A xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:2A5C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:2A5D mov CL,AL
        CL = AL;
        // 100D:2A5F jcxz short 0x2AAE
        if (CX == (ushort)0x0000)
        {
            return unknown_100D_2A9E_12B6E(0x2AAE);
        }
    label_100D_2A61_12B31_34770:
        CheckExternalEvents(cs1, 0x2A61);
        // 100D:2A61 mov DI,SI
        DI = SI;
        // 100D:2A63 push DS
        Stack.Push16(DS);
        // 100D:2A64 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_2A65_12B35_34774:
        CheckExternalEvents(cs1, 0x2A65);
        // 100D:2A65 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2A66 cmp AH,DL
        Alu8.Sub(AH, DL);
        // 100D:2A68 jne short 0x2A78
        if (!ZeroFlag)
        {
            goto label_100D_2A78_12B48_34959;
        }
    label_100D_2A6A_12B3A_34777:
        CheckExternalEvents(cs1, 0x2A6A);
        // 100D:2A6A cmp DL,0x0F
        Alu8.Sub(DL, (byte)0x0F);
        // 100D:2A6D jne short 0x2A73
        if (!ZeroFlag)
        {
            goto label_100D_2A73_12B43_34780;
        }
    label_100D_2A6F_12B3F_35932:
        CheckExternalEvents(cs1, 0x2A6F);
        // 100D:2A6F cmp BX,word ptr DS:[SI]
        Alu16.Sub(BX, UInt16[DS, SI]);
        // 100D:2A71 jne short 0x2A78
        if (!ZeroFlag)
        {
            goto label_100D_2A78_12B48_34959;
        }
    label_100D_2A73_12B43_34780:
        CheckExternalEvents(cs1, 0x2A73);
        // 100D:2A73 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:2A76 jmp short 0x2A7B
        goto label_100D_2A7B_12B4B_34783;
    label_100D_2A78_12B48_34959:
        CheckExternalEvents(cs1, 0x2A78);
        // 100D:2A78 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A79 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A7A inc BP
        BP = Alu16.Inc(BP);
    label_100D_2A7B_12B4B_34783:
        CheckExternalEvents(cs1, 0x2A7B);
        // 100D:2A7B loop 0x2A65
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2A65_12B35_34774;
        }
    label_100D_2A7D_12B4D_34785:
        CheckExternalEvents(cs1, 0x2A7D);
        // 100D:2A7D jmp short 0x2A9E
        return unknown_100D_2A9E_12B6E(0x0000);
    }

    public virtual Action unknown_100D_2A7F_12B4F(int loadOffset)
    {
    label_100D_2A7F_12B4F_31696:
        CheckExternalEvents(cs1, 0x2A7F);
        // 100D:2A7F mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:2A82 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:2A84 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:2A86 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:2A87 mov CL,AL
        CL = AL;
        // 100D:2A89 jcxz short 0x2AAE
        if (CX == (ushort)0x0000)
        {
            return unknown_100D_2A9E_12B6E(0x2AAE);
        }
    label_100D_2A8B_12B5B_35818:
        CheckExternalEvents(cs1, 0x2A8B);
        // 100D:2A8B mov DI,SI
        DI = SI;
        // 100D:2A8D push DS
        Stack.Push16(DS);
        // 100D:2A8E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:2A8F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2A90 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:2A92 jne short 0x2A99
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2A92");
        }
    label_100D_2A99_12B69_35825:
        CheckExternalEvents(cs1, 0x2A99);
        // 100D:2A99 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A9A movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2A9B inc BP
        BP = Alu16.Inc(BP);
        // 100D:2A9C loop 0x2A8F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2A9C");
        }
        else
        {
            return unknown_100D_2A9E_12B6E(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_2AAF_12B7F(int loadOffset)
    {
    label_100D_2AAF_12B7F_19873:
        CheckExternalEvents(cs1, 0x2AAF);
        // 100D:2AAF push SI
        Stack.Push16(SI);
        // 100D:2AB0 mov SI,0x1190
        SI = (ushort)0x1190;
        // 100D:2AB3 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:2AB5 mov CL,byte ptr DS:[SI]
        CL = UInt8[DS, SI];
        // 100D:2AB7 jcxz short 0x2ACD
        if (CX == (ushort)0x0000)
        {
            goto label_100D_2ACD_12B9D_19879;
        }
    label_100D_2AB9_12B89_33691:
        CheckExternalEvents(cs1, 0x2AB9);
        // 100D:2AB9 inc SI
        SI = Alu16.Inc(SI);
    label_100D_2ABA_12B8A_33693:
        CheckExternalEvents(cs1, 0x2ABA);
        // 100D:2ABA cmp AL,byte ptr DS:[SI+1]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)1)]);
        // 100D:2ABD jne short 0x2AC8
        if (!ZeroFlag)
        {
            goto label_100D_2AC8_12B98_33695;
        }
    label_100D_2ABF_12B8F_34738:
        CheckExternalEvents(cs1, 0x2ABF);
        // 100D:2ABF cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 100D:2AC1 jne short 0x2AD0
        if (!ZeroFlag)
        {
            goto label_100D_2AD0_12BA0_34741;
        }
    label_100D_2AC3_12B93_40264:
        CheckExternalEvents(cs1, 0x2AC3);
        // 100D:2AC3 cmp DI,word ptr DS:[SI+2]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:2AC6 je short 0x2AD0
        if (ZeroFlag)
        {
            goto label_100D_2AD0_12BA0_34741;
        }
    label_100D_2AC8_12B98_33695:
        CheckExternalEvents(cs1, 0x2AC8);
        // 100D:2AC8 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:2ACB loop 0x2ABA
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2ABA_12B8A_33693;
        }
    label_100D_2ACD_12B9D_19879:
        CheckExternalEvents(cs1, 0x2ACD);
        // 100D:2ACD pop SI
        SI = Stack.Pop16();
        // 100D:2ACE clc
        CarryFlag = false;
        // 100D:2ACF ret near
        return NearRet((ushort)0x0000);
    label_100D_2AD0_12BA0_34741:
        CheckExternalEvents(cs1, 0x2AD0);
        // 100D:2AD0 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:2AD2 mov DI,word ptr DS:[SI+2]
        DI = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:2AD5 pop SI
        SI = Stack.Pop16();
        // 100D:2AD6 stc
        CarryFlag = true;
        // 100D:2AD7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2AD8_12BA8(int loadOffset)
    {
    label_100D_2AD8_12BA8_32401:
        CheckExternalEvents(cs1, 0x2AD8);
        // 100D:2AD8 push AX
        Stack.Push16(AX);
        // 100D:2AD9 mov AX,word ptr DS:[0x1191]
        AX = UInt16[DS, (ushort)0x1191];
        // 100D:2ADC mov BX,word ptr DS:[0x0012]
        BX = UInt16[DS, (ushort)0x0012];
        // 100D:2AE0 mov CL,AH
        CL = AH;
        // 100D:2AE2 shr BX,CL
        BX = Alu16.Shr(BX, unchecked((int)CL));
        // 100D:2AE4 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:2AE6 jae short 0x2AF7
        if (!CarryFlag)
        {
            goto label_100D_2AF7_12BC7_32409;
        }
    label_100D_2AE8_12BB8_40323:
        CheckExternalEvents(cs1, 0x2AE8);
        // 100D:2AE8 mov DI,word ptr DS:[0x1193]
        DI = UInt16[DS, (ushort)0x1193];
        // 100D:2AEC cmp CL,0x0F
        Alu8.Sub(CL, (byte)0x0F);
        // 100D:2AEF jne short 0x2AFA
        if (!ZeroFlag)
        {
            goto label_100D_2AFA_12BCA_40327;
        }
    label_100D_2AF1_12BC1_40329:
        CheckExternalEvents(cs1, 0x2AF1);
        // 100D:2AF1 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:2AF5 je short 0x2AFA
        if (ZeroFlag)
        {
            goto label_100D_2AFA_12BCA_40327;
        }
    label_100D_2AF7_12BC7_32409:
        CheckExternalEvents(cs1, 0x2AF7);
        // 100D:2AF7 pop AX
        AX = Stack.Pop16();
        // 100D:2AF8 clc
        CarryFlag = false;
        // 100D:2AF9 ret near
        return NearRet((ushort)0x0000);
    label_100D_2AFA_12BCA_40327:
        CheckExternalEvents(cs1, 0x2AFA);
        VerifySpeculativeEntryOrFail(cs1, 0x2AFA, [(byte)0x83, (byte)0xC4, (byte)0x02]);
        // 100D:2AFA add SP,2
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)2)));
        VerifySpeculativeEntryOrFail(cs1, 0x2AFD, [(byte)0xE8, (byte)0xB2, (byte)0xB0]);
        // 100D:2AFD call near 0xDBB2
        NearCall(cs1, 0x2B00, unknown_100D_DBB2_1DC82);
        throw FailAsUntested("Call at 100D:2AFD returned to 100D:2B00, but no continuation was observed during discovery.");
    }

    public virtual Action unknown_100D_2B00_12BD0(int loadOffset)
    {
    label_100D_2B00_12BD0_34749:
        CheckExternalEvents(cs1, 0x2B00);
        // 100D:2B00 push word ptr DS:[0x11CE]
        Stack.Push16(UInt16[DS, (ushort)0x11CE]);
        // 100D:2B04 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:2B06 je short 0x2B0D
        if (ZeroFlag)
        {
            goto label_100D_2B0D_12BDD_34753;
        }
    label_100D_2B08_12BD8_40270:
        CheckExternalEvents(cs1, 0x2B08);
        // 100D:2B08 push AX
        Stack.Push16(AX);
        // 100D:2B09 call near 0x331E
        NearCall(cs1, 0x2B0C, unknown_100D_331E_133EE);
    label_100D_2B0C_12BDC_40275:
        CheckExternalEvents(cs1, 0x2B0C);
        // 100D:2B0C pop AX
        AX = Stack.Pop16();
    label_100D_2B0D_12BDD_34753:
        CheckExternalEvents(cs1, 0x2B0D);
        // 100D:2B0D mov byte ptr DS:[0x00EA],AL
        UInt8[DS, (ushort)0x00EA] = AL;
        // 100D:2B10 mov AL,AH
        AL = AH;
        // 100D:2B12 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:2B14 call near 0x96D8
        NearCall(cs1, 0x2B17, unknown_100D_96D8_197A8);
    label_100D_2B17_12BE7_34758:
        CheckExternalEvents(cs1, 0x2B17);
        // 100D:2B17 call near 0x9945
        NearCall(cs1, 0x2B1A, unknown_100D_9945_19A15);
    label_100D_2B1A_12BEA_34760:
        CheckExternalEvents(cs1, 0x2B1A);
        // 100D:2B1A mov byte ptr DS:[0x00EA],0xFF
        UInt8[DS, (ushort)0x00EA] = (byte)0xFF;
        // 100D:2B1F mov AL,1
        AL = (byte)0x01;
        // 100D:2B21 call near 0x9EF1
        NearCall(cs1, 0x2B24, unknown_100D_9EF1_19FC1);
    label_100D_2B24_12BF4_34764:
        CheckExternalEvents(cs1, 0x2B24);
        // 100D:2B24 pop DI
        DI = Stack.Pop16();
        // 100D:2B25 call near 0x331E
        NearCall(cs1, 0x2B28, unknown_100D_331E_133EE);
    label_100D_2B28_12BF8_34767:
        CheckExternalEvents(cs1, 0x2B28);
        // 100D:2B28 stc
        CarryFlag = true;
        // 100D:2B29 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2B2A_12BFA(int loadOffset)
    {
    entrydispatcher:
    label_100D_2B2A_12BFA_14657:
        CheckExternalEvents(cs1, 0x2B2A);
        // 100D:2B2A mov AL,byte ptr DS:[0x46D9]
        AL = UInt8[DS, (ushort)0x46D9];
        // 100D:2B2D or AL,byte ptr DS:[0x4774]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0x4774]);
        // 100D:2B31 or AL,byte ptr DS:[0x11C9]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0x11C9]);
        // 100D:2B35 jne short 0x2B8F
        if (!ZeroFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B37_12C07_14662:
        CheckExternalEvents(cs1, 0x2B37);
        // 100D:2B37 call near 0xD41B
        NearCall(cs1, 0x2B3A, unknown_100D_D41B_1D4EB);
    label_100D_2B3A_12C0A_14664:
        CheckExternalEvents(cs1, 0x2B3A);
        // 100D:2B3A cmp BP,0x1F0E
        Alu16.Sub(BP, (ushort)0x1F0E);
        // 100D:2B3E jne short 0x2B8F
        if (!ZeroFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B40_12C10_14667:
        CheckExternalEvents(cs1, 0x2B40);
        // 100D:2B40 cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:2B45 js short 0x2B8F
        if (SignFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B47_12C17_14670:
        CheckExternalEvents(cs1, 0x2B47);
        // 100D:2B47 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:2B4A cmp byte ptr DS:[0x002A],0x14
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x14);
        // 100D:2B4F jb short 0x2B8F
        if (CarryFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B51_12C21_32045:
        CheckExternalEvents(cs1, 0x2B51);
        // 100D:2B51 je short 0x2BA1
        if (ZeroFlag)
        {
            goto label_100D_2BA1_12C71_32047;
        }
    label_100D_2B53_12C23_32392:
        CheckExternalEvents(cs1, 0x2B53);
        // 100D:2B53 cmp byte ptr DS:[0x1190],0
        Alu8.Sub(UInt8[DS, (ushort)0x1190], (byte)0x00);
        // 100D:2B58 je short 0x2B8F
        if (ZeroFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B5A_12C2A_32395:
        CheckExternalEvents(cs1, 0x2B5A);
        // 100D:2B5A sub AX,word ptr DS:[0xDC5A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDC5A]);
        // 100D:2B5E cmp AX,0x0032
        Alu16.Sub(AX, (ushort)0x0032);
        // 100D:2B61 jb short 0x2B8F
        if (CarryFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B63_12C33_32399:
        CheckExternalEvents(cs1, 0x2B63);
        // 100D:2B63 call near 0x2AD8
        NearCall(cs1, 0x2B66, unknown_100D_2AD8_12BA8);
    label_100D_2B66_12C36_32413:
        CheckExternalEvents(cs1, 0x2B66);
        // 100D:2B66 jae short 0x2B70
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2B66");
        }
    label_100D_2B70_12C40_32415:
        CheckExternalEvents(cs1, 0x2B70);
        // 100D:2B70 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:2B75 jne short 0x2BD2
        if (!ZeroFlag)
        {
            goto label_100D_2BD2_12CA2_32582;
        }
    label_100D_2B77_12C47_32418:
        CheckExternalEvents(cs1, 0x2B77);
        // 100D:2B77 mov BL,0x28
        BL = (byte)0x28;
        // 100D:2B79 cmp AX,0x0096
        Alu16.Sub(AX, (ushort)0x0096);
        // 100D:2B7C jb short 0x2B90
        if (CarryFlag)
        {
            goto label_100D_2B90_12C60_32422;
        }
    label_100D_2B7E_12C4E_32503:
        CheckExternalEvents(cs1, 0x2B7E);
        // 100D:2B7E cmp AX,0x00FA
        Alu16.Sub(AX, (ushort)0x00FA);
        // 100D:2B81 jb short 0x2B8F
        if (CarryFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2B83_12C53_32506:
        CheckExternalEvents(cs1, 0x2B83);
        // 100D:2B83 cmp AX,0x015E
        Alu16.Sub(AX, (ushort)0x015E);
        // 100D:2B86 mov BL,0x26
        BL = (byte)0x26;
        // 100D:2B88 jb short 0x2B90
        if (CarryFlag)
        {
            goto label_100D_2B90_12C60_32422;
        }
    label_100D_2B8A_12C5A_32579:
        CheckExternalEvents(cs1, 0x2B8A);
        // 100D:2B8A cmp AX,0x01C2
        Alu16.Sub(AX, (ushort)0x01C2);
        // 100D:2B8D jae short 0x2BD2
        if (!CarryFlag)
        {
            goto label_100D_2BD2_12CA2_32582;
        }
    label_100D_2B8F_12C5F_14674:
        CheckExternalEvents(cs1, 0x2B8F);
        // 100D:2B8F ret near
        return NearRet((ushort)0x0000);
    label_100D_2B90_12C60_32422:
        CheckExternalEvents(cs1, 0x2B90);
        // 100D:2B90 push BX
        Stack.Push16(BX);
        // 100D:2B91 call near 0xDBB2
        NearCall(cs1, 0x2B94, unknown_100D_DBB2_1DC82);
    label_100D_2B94_12C64_32425:
        CheckExternalEvents(cs1, 0x2B94);
        // 100D:2B94 call near 0xC49A
        NearCall(cs1, 0x2B97, unknown_100D_C49A_1C56A);
    label_100D_2B97_12C67_32427:
        CheckExternalEvents(cs1, 0x2B97);
        // 100D:2B97 pop AX
        AX = Stack.Pop16();
        // 100D:2B98 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:2B9B call near 0xC108
        NearCall(cs1, 0x2B9E, unknown_100D_C108_1C1D8);
    label_100D_2B9E_12C6E_32498:
        CheckExternalEvents(cs1, 0x2B9E);
        // 100D:2B9E jmp near 0xDBEC
        if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2BA1_12C71_32047:
        CheckExternalEvents(cs1, 0x2BA1);
        // 100D:2BA1 cmp word ptr DS:[0x0010],0
        Alu16.Sub(UInt16[DS, (ushort)0x0010], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:2BA6 jne short 0x2B8F
        if (!ZeroFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2BA8_12C78_32174:
        CheckExternalEvents(cs1, 0x2BA8);
        // 100D:2BA8 cmp byte ptr DS:[8],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0xFF);
        // 100D:2BAD jne short 0x2B8F
        if (!ZeroFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2BAF_12C7F_32177:
        CheckExternalEvents(cs1, 0x2BAF);
        // 100D:2BAF sub AX,word ptr DS:[0xDC5A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDC5A]);
        // 100D:2BB3 cmp AX,0x03E8
        Alu16.Sub(AX, (ushort)0x03E8);
        // 100D:2BB6 jb short 0x2B8F
        if (CarryFlag)
        {
            goto label_100D_2B8F_12C5F_14674;
        }
    label_100D_2BB8_12C88_32305:
        CheckExternalEvents(cs1, 0x2BB8);
        // 100D:2BB8 add word ptr DS:[0xDC5A],0x03B6
        UInt16[DS, (ushort)0xDC5A] = Alu16.Add(UInt16[DS, (ushort)0xDC5A], (ushort)0x03B6);
        // 100D:2BBE call near 0x1071
        NearCall(cs1, 0x2BC1, unknown_100D_1071_11141);
    label_100D_2BC1_12C91_32388:
        CheckExternalEvents(cs1, 0x2BC1);
        // 100D:2BC1 call near 0xB17A
        NearCall(cs1, 0x2BC4, unknown_100D_B17A_1B24A);
    label_100D_2BC4_12C94_32390:
        CheckExternalEvents(cs1, 0x2BC4);
        // 100D:2BC4 call near 0x2B2A
        NearCall(cs1, 0x2BC7, unknown_100D_2B2A_12BFA);
    label_100D_2BC7_12C97_32500:
        CheckExternalEvents(cs1, 0x2BC7);
        // 100D:2BC7 cmp byte ptr DS:[0x00EA],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0xFF);
        // 100D:2BCC jne short 0x2BC4
        if (!ZeroFlag)
        {
            goto label_100D_2BC4_12C94_32390;
        }
    label_100D_2BCE_12C9E_32843:
        CheckExternalEvents(cs1, 0x2BCE);
        // 100D:2BCE ret near
        return NearRet((ushort)0x0000);
    label_100D_2BD2_12CA2_32582:
        CheckExternalEvents(cs1, 0x2BD2);
        // 100D:2BD2 call near 0xDBB2
        NearCall(cs1, 0x2BD5, unknown_100D_DBB2_1DC82);
    label_100D_2BD5_12CA5_32584:
        CheckExternalEvents(cs1, 0x2BD5);
        // 100D:2BD5 call near 0xAD5E
        NearCall(cs1, 0x2BD8, unknown_100D_AD5E_1AE2E);
    label_100D_2BD8_12CA8_32586:
        CheckExternalEvents(cs1, 0x2BD8);
        // 100D:2BD8 mov DI,word ptr DS:[0x1193]
        DI = UInt16[DS, (ushort)0x1193];
        // 100D:2BDC or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:2BDE je short 0x2BF4
        if (ZeroFlag)
        {
            goto label_100D_2BF4_12CC4_32590;
        }
    label_100D_2BE0_12CB0_33699:
        CheckExternalEvents(cs1, 0x2BE0);
        // 100D:2BE0 mov AX,DI
        AX = DI;
        // 100D:2BE2 sub AX,0x0100
        AX = Alu16.Sub(AX, (ushort)0x0100);
        // 100D:2BE5 cmp AX,0x07AA
        Alu16.Sub(AX, (ushort)0x07AA);
        // 100D:2BE8 jb short 0x2BF1
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2BE8");
        }
    label_100D_2BF1_12CC1_33704:
        CheckExternalEvents(cs1, 0x2BF1);
        // 100D:2BF1 call near 0x331E
        NearCall(cs1, 0x2BF4, unknown_100D_331E_133EE);
    label_100D_2BF4_12CC4_32590:
        CheckExternalEvents(cs1, 0x2BF4);
        // 100D:2BF4 mov AX,word ptr DS:[0x1191]
        AX = UInt16[DS, (ushort)0x1191];
        // 100D:2BF7 mov byte ptr DS:[0x00EA],AL
        UInt8[DS, (ushort)0x00EA] = AL;
        // 100D:2BFA cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:2BFC jne short 0x2C01
        if (!ZeroFlag)
        {
            goto label_100D_2C01_12CD1_32597;
        }
    label_100D_2BFE_12CCE_32595:
        CheckExternalEvents(cs1, 0x2BFE);
        // 100D:2BFE mov byte ptr DS:[0x00EB],AL
        UInt8[DS, (ushort)0x00EB] = AL;
    label_100D_2C01_12CD1_32597:
        CheckExternalEvents(cs1, 0x2C01);
        // 100D:2C01 mov AL,AH
        AL = AH;
        // 100D:2C03 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:2C05 mov DI,word ptr DS:[0x1193]
        DI = UInt16[DS, (ushort)0x1193];
        // 100D:2C09 cmp AX,0x0010
        Alu16.Sub(AX, (ushort)0x0010);
        // 100D:2C0C jae short 0x2BCF
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2C0C");
        }
    label_100D_2C0E_12CDE_32602:
        CheckExternalEvents(cs1, 0x2C0E);
        // 100D:2C0E cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:2C10 jne short 0x2C16
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2C10");
        }
    label_100D_2C16_12CE6_32605:
        CheckExternalEvents(cs1, 0x2C16);
        // 100D:2C16 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:2C19 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:2C1B je short 0x2C47
        if (ZeroFlag)
        {
            goto label_100D_2C47_12D17_32609;
        }
    label_100D_2C1D_12CED_33707:
        CheckExternalEvents(cs1, 0x2C1D);
        // 100D:2C1D call near 0x331E
        NearCall(cs1, 0x2C20, unknown_100D_331E_133EE);
    label_100D_2C20_12CF0_33709:
        CheckExternalEvents(cs1, 0x2C20);
        // 100D:2C20 call near 0x2E98
        NearCall(cs1, 0x2C23, unknown_100D_2E98_12F68);
    label_100D_2C23_12CF3_33711:
        CheckExternalEvents(cs1, 0x2C23);
        // 100D:2C23 cmp word ptr DS:[0x47C4],0x000E
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:2C28 jb short 0x2C47
        if (CarryFlag)
        {
            goto label_100D_2C47_12D17_32609;
        }
    label_100D_2C2A_12CFA_33714:
        CheckExternalEvents(cs1, 0x2C2A);
        // 100D:2C2A mov AL,3
        AL = (byte)0x03;
        // 100D:2C2C cmp byte ptr DS:[0x00EA],0x0E
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x0E);
        // 100D:2C31 je short 0x2C3A
        if (ZeroFlag)
        {
            goto label_100D_2C3A_12D0A_33722;
        }
    label_100D_2C33_12D03_33718:
        CheckExternalEvents(cs1, 0x2C33);
        // 100D:2C33 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:2C36 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:2C38 je short 0x2C47
        if (ZeroFlag)
        {
            goto label_100D_2C47_12D17_32609;
        }
    label_100D_2C3A_12D0A_33722:
        CheckExternalEvents(cs1, 0x2C3A);
        // 100D:2C3A call near 0x6906
        NearCall(cs1, 0x2C3D, unknown_100D_6906_169D6);
    label_100D_2C3D_12D0D_33724:
        CheckExternalEvents(cs1, 0x2C3D);
        // 100D:2C3D mov word ptr DS:[0x47C4],0x000E
        UInt16[DS, (ushort)0x47C4] = (ushort)0x000E;
        // 100D:2C43 mov word ptr DS:[0x4756],SI
        UInt16[DS, (ushort)0x4756] = SI;
    label_100D_2C47_12D17_32609:
        CheckExternalEvents(cs1, 0x2C47);
        // 100D:2C47 call near 0x2C92
        NearCall(cs1, 0x2C4A, unknown_100D_2C92_12D62);
    label_100D_2C4A_12D1A_32709:
        CheckExternalEvents(cs1, 0x2C4A);
        // 100D:2C4A mov AL,1
        AL = (byte)0x01;
        // 100D:2C4C call near 0x9EF1
        NearCall(cs1, 0x2C4F, unknown_100D_9EF1_19FC1);
    label_100D_2C4F_12D1F_32715:
        CheckExternalEvents(cs1, 0x2C4F);
        // 100D:2C4F call near 0x2A34
        NearCall(cs1, 0x2C52, unknown_100D_2A34_12B04);
    label_100D_2C52_12D22_32734:
        CheckExternalEvents(cs1, 0x2C52);
        // 100D:2C52 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2C54 mov byte ptr DS:[0x1F0F],AL
        UInt8[DS, (ushort)0x1F0F] = AL;
        // 100D:2C57 mov word ptr DS:[0x1F10],AX
        UInt16[DS, (ushort)0x1F10] = AX;
        // 100D:2C5A call near 0xD397
        NearCall(cs1, 0x2C5D, unknown_100D_D397_1D467);
    label_100D_2C5D_12D2D_32739:
        CheckExternalEvents(cs1, 0x2C5D);
        // 100D:2C5D call near 0xB2B9
        NearCall(cs1, 0x2C60, unknown_100D_B2B9_1B389);
    label_100D_2C60_12D30_32741:
        CheckExternalEvents(cs1, 0x2C60);
        // 100D:2C60 mov AX,0x0BB8
        AX = (ushort)0x0BB8;
        // 100D:2C63 call near 0xDDB0
        NearCall(cs1, 0x2C66, unknown_100D_DDB0_1DE80);
    label_100D_2C66_12D36_32825:
        CheckExternalEvents(cs1, 0x2C66);
        // 100D:2C66 call near 0xB2B3
        NearCall(cs1, 0x2C69, unknown_100D_B2B3_1B383);
    label_100D_2C69_12D39_32827:
        CheckExternalEvents(cs1, 0x2C69);
        // 100D:2C69 mov SI,0x2CC7
        SI = (ushort)0x2CC7;
        // 100D:2C6C call near 0xDA5F
        NearCall(cs1, 0x2C6F, unknown_100D_DA5F_1DB2F);
    label_100D_2C6F_12D3F_32830:
        CheckExternalEvents(cs1, 0x2C6F);
        // 100D:2C6F call near 0x98E6
        NearCall(cs1, 0x2C72, unknown_100D_98E6_199B6);
    label_100D_2C72_12D42_32832:
        CheckExternalEvents(cs1, 0x2C72);
        // 100D:2C72 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2C74 mov word ptr DS:[0x479E],AX
        UInt16[DS, (ushort)0x479E] = AX;
        // 100D:2C77 mov word ptr DS:[0x4540],AX
        UInt16[DS, (ushort)0x4540] = AX;
        // 100D:2C7A mov byte ptr DS:[0x00EA],0xFF
        UInt8[DS, (ushort)0x00EA] = (byte)0xFF;
        // 100D:2C7F mov byte ptr DS:[0x00E8],0x0A
        UInt8[DS, (ushort)0x00E8] = (byte)0x0A;
        // 100D:2C84 mov word ptr DS:[0xDC30],0
        UInt16[DS, (ushort)0xDC30] = (ushort)0x0000;
        // 100D:2C8A mov AL,6
        AL = (byte)0x06;
        // 100D:2C8C call near 0x189A
        NearCall(cs1, 0x2C8F, unknown_100D_189A_1196A);
    label_100D_2C8F_12D5F_32841:
        CheckExternalEvents(cs1, 0x2C8F);
        // 100D:2C8F jmp near 0xC412
        return unknown_100D_C412_1C4E2(0x0000);
    }

    public virtual Action unknown_100D_2C92_12D62(int loadOffset)
    {
    entrydispatcher:
    label_100D_2C92_12D62_32611:
        CheckExternalEvents(cs1, 0x2C92);
        // 100D:2C92 mov AL,6
        AL = (byte)0x06;
        // 100D:2C94 mov BP,0x2C9A
        BP = (ushort)0x2C9A;
        // 100D:2C97 jmp near 0xC108
        if (JumpDispatcher.Jump(unknown_100D_C108_1C1D8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_2C9A_12D6A(int loadOffset)
    {
    label_100D_2C9A_12D6A_32615:
        CheckExternalEvents(cs1, 0x2C9A);
        // 100D:2C9A mov byte ptr DS:[0x00E8],0
        UInt8[DS, (ushort)0x00E8] = (byte)0x00;
        // 100D:2C9F mov AL,0x23
        AL = (byte)0x23;
        // 100D:2CA1 call near 0xC2F2
        NearCall(cs1, 0x2CA4, unknown_100D_C2F2_1C3C2);
    label_100D_2CA4_12D74_32619:
        CheckExternalEvents(cs1, 0x2CA4);
        // 100D:2CA4 call near 0xC412
        NearCall(cs1, 0x2CA7, unknown_100D_C412_1C4E2);
    label_100D_2CA7_12D77_32621:
        CheckExternalEvents(cs1, 0x2CA7);
        // 100D:2CA7 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:2CAA call near 0x96D8
        NearCall(cs1, 0x2CAD, unknown_100D_96D8_197A8);
    label_100D_2CAD_12D7D_32624:
        CheckExternalEvents(cs1, 0x2CAD);
        // 100D:2CAD xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2CAF mov word ptr DS:[0x1BEA],AX
        UInt16[DS, (ushort)0x1BEA] = AX;
        // 100D:2CB2 mov word ptr DS:[0x1BF8],AX
        UInt16[DS, (ushort)0x1BF8] = AX;
        // 100D:2CB5 mov byte ptr DS:[0x46DF],AL
        UInt8[DS, (ushort)0x46DF] = AL;
        // 100D:2CB8 mov SI,0xC0B6
        SI = (ushort)0xC0B6;
        // 100D:2CBB call near 0xDA5F
        NearCall(cs1, 0x2CBE, unknown_100D_DA5F_1DB2F);
    label_100D_2CBE_12D8E_32631:
        CheckExternalEvents(cs1, 0x2CBE);
        // 100D:2CBE mov SI,0x2CC7
        SI = (ushort)0x2CC7;
        // 100D:2CC1 mov BP,6
        BP = (ushort)0x0006;
        // 100D:2CC4 jmp near 0xDA25
        return unknown_100D_DA25_1DAF5(0x0000);
    }

    public virtual Action unknown_100D_2CC7_12D97(int loadOffset)
    {
    label_100D_2CC7_12D97_32744:
        CheckExternalEvents(cs1, 0x2CC7);
        // 100D:2CC7 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:2CC9 mov SI,0x1478
        SI = (ushort)0x1478;
        // 100D:2CCC jmp near 0xC0D5
        return unknown_100D_C0D5_1C1A5(0x0000);
    }

    public virtual Action unknown_100D_2CCF_12D9F(int loadOffset)
    {
    entrydispatcher:
    label_100D_2CCF_12D9F_35342:
        CheckExternalEvents(cs1, 0x2CCF);
        // 100D:2CCF or byte ptr DS:[0x000A],8
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x08);
        // 100D:2CD4 cmp byte ptr DS:[0x009F],1
        Alu8.Sub(UInt8[DS, (ushort)0x009F], (byte)0x01);
        // 100D:2CD9 jne short 0x2D2B
        if (!ZeroFlag)
        {
            goto label_100D_2D2B_12DFB_35346;
        }
    label_100D_2CDB_12DAB_37947:
        CheckExternalEvents(cs1, 0x2CDB);
        // 100D:2CDB call near 0xDBB2
        NearCall(cs1, 0x2CDE, unknown_100D_DBB2_1DC82);
    label_100D_2CDE_12DAE_37950:
        CheckExternalEvents(cs1, 0x2CDE);
        // 100D:2CDE call near 0xABCC
        NearCall(cs1, 0x2CE1, unknown_100D_ABCC_1AC9C);
    label_100D_2CE1_12DB1_37953:
        CheckExternalEvents(cs1, 0x2CE1);
        // 100D:2CE1 jne short 0x2CEB
        if (!ZeroFlag)
        {
            goto label_100D_2CEB_12DBB_37954;
        }
    label_100D_2CE3_12DB3_37957:
        CheckExternalEvents(cs1, 0x2CE3);
        VerifySpeculativeEntryOrFail(cs1, 0x2CE3, [(byte)0xB8, (byte)0x58, (byte)0x02]);
        // 100D:2CE3 mov AX,0x0258
        AX = (ushort)0x0258;
        VerifySpeculativeEntryOrFail(cs1, 0x2CE6, [(byte)0xE8, (byte)0xC7, (byte)0xB0]);
        // 100D:2CE6 call near 0xDDB0
        NearCall(cs1, 0x2CE9, unknown_100D_DDB0_1DE80);
        throw FailAsUntested("Call at 100D:2CE6 returned to 100D:2CE9, but no continuation was observed during discovery.");
    label_100D_2CEB_12DBB_37954:
        CheckExternalEvents(cs1, 0x2CEB);
        // 100D:2CEB call near 0xABD5
        NearCall(cs1, 0x2CEE, unknown_100D_ABD5_1ACA5);
    label_100D_2CEE_12DBE_37966:
        CheckExternalEvents(cs1, 0x2CEE);
        // 100D:2CEE cmp byte ptr DS:[0x0029],0x64
        Alu8.Sub(UInt8[DS, (ushort)0x0029], (byte)0x64);
        // 100D:2CF3 jb short 0x2D26
        if (CarryFlag)
        {
            goto label_100D_2D26_12DF6_37969;
        }
    label_100D_2CF5_12DC5_37971:
        CheckExternalEvents(cs1, 0x2CF5);
        // 100D:2CF5 or byte ptr DS:[0x000A],2
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x02);
        // 100D:2CFA mov byte ptr DS:[0x00D5],0xFF
        UInt8[DS, (ushort)0x00D5] = (byte)0xFF;
        // 100D:2CFF mov AL,0x38
        AL = (byte)0x38;
        // 100D:2D01 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:2D04 call near 0xC108
        NearCall(cs1, 0x2D07, unknown_100D_C108_1C1D8);
    label_100D_2D07_12DD7_37985:
        CheckExternalEvents(cs1, 0x2D07);
        // 100D:2D07 mov AX,0x03E8
        AX = (ushort)0x03E8;
        // 100D:2D0A call near 0xE387
        NearCall(cs1, 0x2D0D, unknown_100D_E387_1E457);
    label_100D_2D0D_12DDD_37990:
        CheckExternalEvents(cs1, 0x2D0D);
        // 100D:2D0D call near 0x8C8A
        NearCall(cs1, 0x2D10, unknown_100D_8C8A_18D5A);
    label_100D_2D10_12DE0_37993:
        CheckExternalEvents(cs1, 0x2D10);
        // 100D:2D10 mov AL,0x36
        AL = (byte)0x36;
        // 100D:2D12 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:2D15 call near 0xC108
        NearCall(cs1, 0x2D18, unknown_100D_C108_1C1D8);
    label_100D_2D18_12DE8_38000:
        CheckExternalEvents(cs1, 0x2D18);
        // 100D:2D18 mov CX,3
        CX = (ushort)0x0003;
        // 100D:2D1B call near 0x0FD9
        NearCall(cs1, 0x2D1E, unknown_100D_0FD9_110A9);
    label_100D_2D1E_12DEE_38005:
        CheckExternalEvents(cs1, 0x2D1E);
        // 100D:2D1E mov byte ptr DS:[0x0023],0x11
        UInt8[DS, (ushort)0x0023] = (byte)0x11;
        // 100D:2D23 jmp near 0x35AD
        if (JumpDispatcher.Jump(unknown_100D_35AD_1367D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2D26_12DF6_37969:
        CheckExternalEvents(cs1, 0x2D26);
        VerifySpeculativeEntryOrFail(cs1, 0x2D26, [(byte)0xC6, (byte)0x06, (byte)0xD9, (byte)0x46, (byte)0x03]);
        // 100D:2D26 mov byte ptr DS:[0x46D9],3
        UInt8[DS, (ushort)0x46D9] = (byte)0x03;
    label_100D_2D2B_12DFB_35346:
        CheckExternalEvents(cs1, 0x2D2B);
        // 100D:2D2B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2D62_12E32(int loadOffset)
    {
    label_100D_2D62_12E32_41183:
        CheckExternalEvents(cs1, 0x2D62);
        // 100D:2D62 cmp byte ptr DS:[SI+3],4
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x04);
        // 100D:2D66 jne short 0x2D73
        if (!ZeroFlag)
        {
            goto label_100D_2D73_12E43_41186;
        }
    label_100D_2D68_12E38_41188:
        CheckExternalEvents(cs1, 0x2D68);
        // 100D:2D68 test byte ptr DS:[SI+0x19],4
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x04);
        // 100D:2D6C je short 0x2D73
        if (ZeroFlag)
        {
            goto label_100D_2D73_12E43_41186;
        }
    label_100D_2D6E_12E3E_41192:
        CheckExternalEvents(cs1, 0x2D6E);
        // 100D:2D6E mov word ptr DS:[BX],SI
        UInt16[DS, BX] = SI;
        // 100D:2D70 add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_2D73_12E43_41186:
        CheckExternalEvents(cs1, 0x2D73);
        // 100D:2D73 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2D74_12E44(int loadOffset)
    {
    label_100D_2D74_12E44_6613:
        CheckExternalEvents(cs1, 0x2D74);
        // 100D:2D74 mov SI,word ptr DS:[0x114E]
        SI = UInt16[DS, (ushort)0x114E];
        // 100D:2D78 cmp SI,0x0100
        Alu16.Sub(SI, (ushort)0x0100);
        // 100D:2D7C jb short 0x2DB0
        if (CarryFlag)
        {
            goto label_100D_2DB0_12E80_6654;
        }
    label_100D_2D7E_12E4E_6617:
        CheckExternalEvents(cs1, 0x2D7E);
        // 100D:2D7E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2D80 call near 0x5E4F
        NearCall(cs1, 0x2D83, unknown_100D_5E4F_15F1F);
    label_100D_2D83_12E53_6630:
        CheckExternalEvents(cs1, 0x2D83);
        // 100D:2D83 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:2D86 jae short 0x2D8F
        if (!CarryFlag)
        {
            goto label_100D_2D8F_12E5F_6636;
        }
    label_100D_2D88_12E58_6633:
        CheckExternalEvents(cs1, 0x2D88);
        // 100D:2D88 test byte ptr DS:[0x4732],1
        Alu8.And(UInt8[DS, (ushort)0x4732], (byte)0x01);
        // 100D:2D8D jne short 0x2DB0
        if (!ZeroFlag)
        {
            goto label_100D_2DB0_12E80_6654;
        }
    label_100D_2D8F_12E5F_6636:
        CheckExternalEvents(cs1, 0x2D8F);
        // 100D:2D8F cmp AX,4
        Alu16.Sub(AX, (ushort)0x0004);
        // 100D:2D92 ja short 0x2DB0
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_2DB0_12E80_6654;
        }
    label_100D_2D94_12E64_6639:
        CheckExternalEvents(cs1, 0x2D94);
        // 100D:2D94 jne short 0x2D97
        if (!ZeroFlag)
        {
            goto label_100D_2D97_12E67_6641;
        }
    label_100D_2D96_12E66_41296:
        CheckExternalEvents(cs1, 0x2D96);
        // 100D:2D96 dec AX
        AX = Alu16.Dec(AX);
    label_100D_2D97_12E67_6641:
        CheckExternalEvents(cs1, 0x2D97);
        // 100D:2D97 cmp byte ptr DS:[0x144C],AL
        Alu8.Sub(UInt8[DS, (ushort)0x144C], AL);
        // 100D:2D9B je short 0x2DB0
        if (ZeroFlag)
        {
            goto label_100D_2DB0_12E80_6654;
        }
    label_100D_2D9D_12E6D_6644:
        CheckExternalEvents(cs1, 0x2D9D);
        // 100D:2D9D mov byte ptr DS:[0x144C],AL
        UInt8[DS, (ushort)0x144C] = AL;
        // 100D:2DA0 add AX,0x00A1
        AX = Alu16.Add(AX, (ushort)0x00A1);
        // 100D:2DA3 push DS
        Stack.Push16(DS);
        // 100D:2DA4 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:2DA5 mov DI,0xBC6E
        DI = (ushort)0xBC6E;
        // 100D:2DA8 mov SI,AX
        SI = AX;
        // 100D:2DAA call near 0xF0B9
        NearCall(cs1, 0x2DAD, unknown_100D_F0B9_1F189);
    label_100D_2DAD_12E7D_6652:
        CheckExternalEvents(cs1, 0x2DAD);
        // 100D:2DAD call near 0x0098
        NearCall(cs1, 0x2DB0, unknown_100D_0098_10168);
    label_100D_2DB0_12E80_6654:
        CheckExternalEvents(cs1, 0x2DB0);
        // 100D:2DB0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_2DB1_12E81(int loadOffset)
    {
    entrydispatcher:
    label_100D_2DB1_12E81_13520:
        CheckExternalEvents(cs1, 0x2DB1);
        // 100D:2DB1 mov BP,0xD717
        BP = (ushort)0xD717;
        // 100D:2DB4 call near 0xC097
        NearCall(cs1, 0x2DB7, unknown_100D_C097_1C167);
    label_100D_2DB7_12E87_13553:
        CheckExternalEvents(cs1, 0x2DB7);
        // 100D:2DB7 call near 0xD95B
        NearCall(cs1, 0x2DBA, unknown_100D_D95B_1DA2B);
    label_100D_2DBA_12E8A_13559:
        CheckExternalEvents(cs1, 0x2DBA);
        // 100D:2DBA mov byte ptr DS:[0x47A6],0xFF
        UInt8[DS, (ushort)0x47A6] = (byte)0xFF;
        if (JumpDispatcher.Jump(unknown_100D_2DBF_12E8F, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
