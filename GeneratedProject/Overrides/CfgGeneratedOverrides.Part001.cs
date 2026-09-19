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
    public virtual Action entry_100D_0000_100D0(int loadOffset)
    {
    label_100D_0000_100D0_0:
        CheckExternalEvents(cs1, 0x0000);
        // 100D:0000 mov AX,0xDD1D
        AX = (ushort)0xDD1D;
        // 100D:0003 call near 0xE4AD
        NearCall(cs1, 0x0006, unknown_100D_E4AD_1E57D);
    label_100D_0006_100D6_120:
        CheckExternalEvents(cs1, 0x0006);
        // 100D:0006 call near 0xE594
        NearCall(cs1, 0x0009, unknown_100D_E594_1E664);
    label_100D_0009_100D9_2752:
        CheckExternalEvents(cs1, 0x0009);
        // 100D:0009 call near 0x00B0
        NearCall(cs1, 0x000C, unknown_100D_00B0_10180);
    label_100D_000C_100DC_3322:
        CheckExternalEvents(cs1, 0x000C);
        // 100D:000C sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_000D_100DD_3324:
        CheckExternalEvents(cs1, 0x000D);
        // 100D:000D call near 0x0580
        NearCall(cs1, 0x0010, unknown_100D_0580_10650);
    label_100D_0010_100E0_11515:
        CheckExternalEvents(cs1, 0x0010);
        // 100D:0010 call near 0x0309
        NearCall(cs1, 0x0013, unknown_100D_0309_103D9);
    label_100D_0013_100E3_11586:
        CheckExternalEvents(cs1, 0x0013);
        // 100D:0013 call near 0x021C
        NearCall(cs1, 0x0016, unknown_100D_021C_102EC);
    label_100D_0016_100E6_12965:
        CheckExternalEvents(cs1, 0x0016);
        // 100D:0016 call near 0xAEB7
        NearCall(cs1, 0x0019, unknown_100D_AEB7_1AF87);
    label_100D_0019_100E9_12967:
        CheckExternalEvents(cs1, 0x0019);
        // 100D:0019 mov byte ptr DS:[0x3810],0
        UInt8[DS, (ushort)0x3810] = (byte)0x00;
        // 100D:001E mov word ptr DS:[2],2
        UInt16[DS, (ushort)0x0002] = (ushort)0x0002;
        // 100D:0024 call near 0x0083
        NearCall(cs1, 0x0027, unknown_100D_0083_10153);
    label_100D_0027_100F7_13056:
        CheckExternalEvents(cs1, 0x0027);
        // 100D:0027 mov CL,0xFF
        CL = (byte)0xFF;
        // 100D:0029 call near 0xB389
        NearCall(cs1, 0x002C, unknown_100D_B389_1B459);
    label_100D_002C_100FC_13198:
        CheckExternalEvents(cs1, 0x002C);
        // 100D:002C call near 0x1860
        NearCall(cs1, 0x002F, unknown_100D_1860_11930);
    label_100D_002F_100FF_14611:
        CheckExternalEvents(cs1, 0x002F);
        // 100D:002F mov byte ptr DS:[0xCE80],0xFF
        UInt8[DS, (ushort)0xCE80] = (byte)0xFF;
        // 100D:0034 call near 0xB2BE
        NearCall(cs1, 0x0037, unknown_100D_B2BE_1B38E);
    label_100D_0037_10107_14617:
        CheckExternalEvents(cs1, 0x0037);
        // 100D:0037 call near 0xD815
        NearCall(cs1, 0x003A, unknown_100D_D815_1D8E5);
        throw FailAsUntested("Call at 100D:0037 returned to 100D:003A, but no continuation was observed during discovery.");
    }

    public virtual Action unknown_100D_0083_10153(int loadOffset)
    {
    label_100D_0083_10153_12971:
        CheckExternalEvents(cs1, 0x0083);
        // 100D:0083 call near 0xCFA0
        NearCall(cs1, 0x0086, unknown_100D_CFA0_1D070);
    label_100D_0086_10156_12986:
        CheckExternalEvents(cs1, 0x0086);
        // 100D:0086 call near 0xC07C
        NearCall(cs1, 0x0089, unknown_100D_C07C_1C14C);
    label_100D_0089_10159_12988:
        CheckExternalEvents(cs1, 0x0089);
        // 100D:0089 call near 0xC0AD
        NearCall(cs1, 0x008C, unknown_100D_C0AD_1C17D);
    label_100D_008C_1015C_12990:
        CheckExternalEvents(cs1, 0x008C);
        // 100D:008C mov SI,0x1AE4
        SI = (ushort)0x1AE4;
        // 100D:008F mov BP,0xD1EF
        BP = (ushort)0xD1EF;
        // 100D:0092 call near 0xC097
        NearCall(cs1, 0x0095, unknown_100D_C097_1C167);
    label_100D_0095_10165_13037:
        CheckExternalEvents(cs1, 0x0095);
        // 100D:0095 jmp near 0x1797
        return unknown_100D_1797_11867(0x0000);
    }

    public virtual Action unknown_100D_0098_10168(int loadOffset)
    {
    label_100D_0098_10168_2828:
        CheckExternalEvents(cs1, 0x0098);
        // 100D:0098 mov CX,word ptr ES:[DI]
        CX = UInt16[ES, DI];
        // 100D:009B shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:009D mov BX,DI
        BX = DI;
    label_100D_009F_1016F_2832:
        CheckExternalEvents(cs1, 0x009F);
        // 100D:009F mov AX,word ptr ES:[DI]
        AX = UInt16[ES, DI];
        // 100D:00A2 add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:00A4 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:00A5 loop 0x009F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_009F_1016F_2832;
        }
    label_100D_00A7_10177_2837:
        CheckExternalEvents(cs1, 0x00A7);
        // 100D:00A7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_00B0_10180(int loadOffset)
    {
    label_100D_00B0_10180_2754:
        CheckExternalEvents(cs1, 0x00B0);
        // 100D:00B0 call near 0x00D1
        NearCall(cs1, 0x00B3, unknown_100D_00D1_101A1);
    label_100D_00B3_10183_2980:
        CheckExternalEvents(cs1, 0x00B3);
        // 100D:00B3 call near 0x0169
        NearCall(cs1, 0x00B6, unknown_100D_0169_10239);
    label_100D_00B6_10186_3133:
        CheckExternalEvents(cs1, 0x00B6);
        // 100D:00B6 call near 0xDA53
        NearCall(cs1, 0x00B9, unknown_100D_DA53_1DB23);
    label_100D_00B9_10189_3139:
        CheckExternalEvents(cs1, 0x00B9);
        // 100D:00B9 call near 0xB17A
        NearCall(cs1, 0x00BC, unknown_100D_B17A_1B24A);
    label_100D_00BC_1018C_3302:
        CheckExternalEvents(cs1, 0x00BC);
        // 100D:00BC call near 0xB17A
        NearCall(cs1, 0x00BF, unknown_100D_B17A_1B24A);
    label_100D_00BF_1018F_3314:
        CheckExternalEvents(cs1, 0x00BF);
        // 100D:00BF xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:00C1 mov ES,AX
        ES = AX;
        // 100D:00C3 mov AX,word ptr ES:[0x046C]
        AX = UInt16[ES, (ushort)0x046C];
        // 100D:00C7 mov word ptr DS:[0xD824],AX
        UInt16[DS, (ushort)0xD824] = AX;
        // 100D:00CA mov word ptr DS:[0xD826],AX
        UInt16[DS, (ushort)0xD826] = AX;
        // 100D:00CD mov word ptr DS:[0xD828],AX
        UInt16[DS, (ushort)0xD828] = AX;
        // 100D:00D0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_00D1_101A1(int loadOffset)
    {
    label_100D_00D1_101A1_2756:
        CheckExternalEvents(cs1, 0x00D1);
        // 100D:00D1 push DS
        Stack.Push16(DS);
        // 100D:00D2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:00D3 mov DI,0x4948
        DI = (ushort)0x4948;
        // 100D:00D6 mov SI,0x00BA
        SI = (ushort)0x00BA;
        // 100D:00D9 call near 0xF0B9
        NearCall(cs1, 0x00DC, unknown_100D_F0B9_1F189);
    label_100D_00DC_101AC_2768:
        CheckExternalEvents(cs1, 0x00DC);
        // 100D:00DC mov CX,0x018C
        CX = (ushort)0x018C;
        // 100D:00DF mov SI,DI
        SI = DI;
    label_100D_00E1_101B1_2771:
        CheckExternalEvents(cs1, 0x00E1);
        // 100D:00E1 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:00E2 xchg AH,AL
        byte temp_100D_00E2_101B2 = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_00E2_101B2);
        // 100D:00E4 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:00E5 loop 0x00E1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_00E1_101B1_2771;
        }
    label_100D_00E7_101B7_2776:
        CheckExternalEvents(cs1, 0x00E7);
        // 100D:00E7 mov DI,0x4880
        DI = (ushort)0x4880;
        // 100D:00EA mov CX,0x0063
        CX = (ushort)0x0063;
        // 100D:00ED mov SI,0x494A
        SI = (ushort)0x494A;
    label_100D_00F0_101C0_2780:
        CheckExternalEvents(cs1, 0x00F0);
        // 100D:00F0 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:00F2 mov DX,1
        DX = (ushort)0x0001;
        // 100D:00F5 mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:00F7 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:00F9 div BX
        ushort divisor_100D_00F9_101C9 = BX;
        uint dividend_100D_00F9_101C9 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_00F9_101C9 = Alu16.Div(unchecked((uint)dividend_100D_00F9_101C9), unchecked((ushort)divisor_100D_00F9_101C9));
        AX = unchecked((ushort)quotient_100D_00F9_101C9);
        DX = unchecked((ushort)(dividend_100D_00F9_101C9 % unchecked((uint)divisor_100D_00F9_101C9)));
        // 100D:00FB cmp word ptr DS:[SI],DX
        Alu16.Sub(UInt16[DS, SI], DX);
        // 100D:00FD adc AX,0
        AX = Alu16.Adc(AX, (ushort)0x0000);
        // 100D:0100 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:0101 add SI,8
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:0104 loop 0x00F0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_00F0_101C0_2780;
        }
    label_100D_0106_101D6_2791:
        CheckExternalEvents(cs1, 0x0106);
        // 100D:0106 mov SI,0x00BF
        SI = (ushort)0x00BF;
        // 100D:0109 call near 0xF0B9
        NearCall(cs1, 0x010C, unknown_100D_F0B9_1F189);
    label_100D_010C_101DC_2794:
        CheckExternalEvents(cs1, 0x010C);
        // 100D:010C mov AX,DI
        AX = DI;
        // 100D:010E add AX,0x62FC
        AX = Alu16.Add(AX, (ushort)0x62FC);
        // 100D:0111 mov word ptr DS:[0xDCFE],AX
        UInt16[DS, (ushort)0xDCFE] = AX;
        // 100D:0114 mov word ptr DS:[0xDD00],ES
        UInt16[DS, (ushort)0xDD00] = ES;
        // 100D:0118 push DS
        Stack.Push16(DS);
        // 100D:0119 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:011A mov DI,0xAA76
        DI = (ushort)0xAA76;
        // 100D:011D mov SI,0x00BD
        SI = (ushort)0x00BD;
        // 100D:0120 call near 0xF0A0
        NearCall(cs1, 0x0123, unknown_100D_F0A0_1F170);
    label_100D_0123_101F3_2826:
        CheckExternalEvents(cs1, 0x0123);
        // 100D:0123 call near 0x0098
        NearCall(cs1, 0x0126, unknown_100D_0098_10168);
    label_100D_0126_101F6_2839:
        CheckExternalEvents(cs1, 0x0126);
        // 100D:0126 mov SI,0x00BC
        SI = (ushort)0x00BC;
        // 100D:0129 call near 0xF0B9
        NearCall(cs1, 0x012C, unknown_100D_F0B9_1F189);
    label_100D_012C_101FC_2842:
        CheckExternalEvents(cs1, 0x012C);
        // 100D:012C mov word ptr DS:[0xAA72],DI
        UInt16[DS, (ushort)0xAA72] = DI;
        // 100D:0130 mov word ptr DS:[0xAA74],ES
        UInt16[DS, (ushort)0xAA74] = ES;
        // 100D:0134 call near 0x0098
        NearCall(cs1, 0x0137, unknown_100D_0098_10168);
    label_100D_0137_10207_2846:
        CheckExternalEvents(cs1, 0x0137);
        // 100D:0137 les AX,word ptr DS:[0x39B7]
        ushort lxsOffset_100D_0137_10207 = (ushort)0x39B7;
        ushort lxsValue_100D_0137_10207 = UInt16[DS, lxsOffset_100D_0137_10207];
        ushort lxsSegment_100D_0137_10207 = UInt16[DS, (ushort)(lxsOffset_100D_0137_10207 + (ushort)0x0002)];
        AX = unchecked((ushort)lxsValue_100D_0137_10207);
        ES = unchecked((ushort)lxsSegment_100D_0137_10207);
        // 100D:013B mov word ptr DS:[0x47AC],AX
        UInt16[DS, (ushort)0x47AC] = AX;
        // 100D:013E mov word ptr DS:[0x47AE],ES
        UInt16[DS, (ushort)0x47AE] = ES;
        // 100D:0142 mov CX,0x1D4C
        CX = (ushort)0x1D4C;
        // 100D:0145 call near 0xF0FF
        NearCall(cs1, 0x0148, unknown_100D_F0FF_1F1CF);
    label_100D_0148_10218_2852:
        CheckExternalEvents(cs1, 0x0148);
        // 100D:0148 les AX,word ptr DS:[0x39B7]
        ushort lxsOffset_100D_0148_10218 = (ushort)0x39B7;
        ushort lxsValue_100D_0148_10218 = UInt16[DS, lxsOffset_100D_0148_10218];
        ushort lxsSegment_100D_0148_10218 = UInt16[DS, (ushort)(lxsOffset_100D_0148_10218 + (ushort)0x0002)];
        AX = unchecked((ushort)lxsValue_100D_0148_10218);
        ES = unchecked((ushort)lxsSegment_100D_0148_10218);
        // 100D:014C mov word ptr DS:[0x47B0],AX
        UInt16[DS, (ushort)0x47B0] = AX;
        // 100D:014F mov word ptr DS:[0x47B2],ES
        UInt16[DS, (ushort)0x47B2] = ES;
        // 100D:0153 mov CX,0xADD4
        CX = (ushort)0xADD4;
        // 100D:0156 call near 0xF0FF
        NearCall(cs1, 0x0159, unknown_100D_F0FF_1F1CF);
    label_100D_0159_10229_2858:
        CheckExternalEvents(cs1, 0x0159);
        // 100D:0159 call near 0xCFB9
        NearCall(cs1, 0x015C, unknown_100D_CFB9_1D089);
    label_100D_015C_1022C_2922:
        CheckExternalEvents(cs1, 0x015C);
        // 100D:015C jmp near 0xC137
        return unknown_100D_C137_1C207(0x0000);
    }

    public virtual Action unknown_100D_0169_10239(int loadOffset)
    {
    label_100D_0169_10239_2982:
        CheckExternalEvents(cs1, 0x0169);
        // 100D:0169 mov AX,0x003A
        AX = (ushort)0x003A;
        // 100D:016C call near 0xC13E
        NearCall(cs1, 0x016F, unknown_100D_C13E_1C20E);
    label_100D_016F_1023F_2988:
        CheckExternalEvents(cs1, 0x016F);
        // 100D:016F push DS
        Stack.Push16(DS);
        // 100D:0170 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:0171 mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:0174 push DI
        Stack.Push16(DI);
        // 100D:0175 mov AX,7
        AX = (ushort)0x0007;
        // 100D:0178 mov CX,0x0100
        CX = (ushort)0x0100;
        // 100D:017B rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:017D pop DI
        DI = Stack.Pop16();
        // 100D:017E les SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_017E_1024E = (ushort)0xDBB0;
        ushort lxsValue_100D_017E_1024E = UInt16[DS, lxsOffset_100D_017E_1024E];
        ushort lxsSegment_100D_017E_1024E = UInt16[DS, (ushort)(lxsOffset_100D_017E_1024E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_017E_1024E);
        ES = unchecked((ushort)lxsSegment_100D_017E_1024E);
        // 100D:0182 mov CX,0xC5F9
        CX = (ushort)0xC5F9;
    label_100D_0185_10255_2999:
        CheckExternalEvents(cs1, 0x0185);
        // 100D:0185 lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:0187 mov BX,AX
        BX = AX;
        // 100D:0189 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:018B inc word ptr DS:[BX+DI]
        UInt16[DS, (ushort)(BX + DI)] = Alu16.Inc(UInt16[DS, (ushort)(BX + DI)]);
        // 100D:018D loop 0x0185
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_0185_10255_2999;
        }
    label_100D_018F_1025F_3005:
        CheckExternalEvents(cs1, 0x018F);
        // 100D:018F mov SI,0x0100
        SI = (ushort)0x0100;
    label_100D_0192_10262_3007:
        CheckExternalEvents(cs1, 0x0192);
        // 100D:0192 mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:0195 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:0198 call near 0xB5C5
        NearCall(cs1, 0x019B, unknown_100D_B5C5_1B695);
    label_100D_019B_1026B_3042:
        CheckExternalEvents(cs1, 0x019B);
        // 100D:019B mov word ptr DS:[SI+2],DX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = DX;
        // 100D:019E mov word ptr DS:[SI+6],DI
        UInt16[DS, (ushort)(SI + (sbyte)6)] = DI;
        // 100D:01A1 or byte ptr ES:[DI],0x40
        UInt8[ES, DI] = Alu8.Or(UInt8[ES, DI], (byte)0x40);
        // 100D:01A5 mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:01A9 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:01AC mov byte ptr DS:[SI+0x10],AL
        UInt8[DS, (ushort)(SI + (sbyte)16)] = AL;
        // 100D:01AF xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:01B1 mov BL,AL
        BL = AL;
        // 100D:01B3 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:01B5 mov AX,word ptr DS:[BX+0x4C60]
        AX = UInt16[DS, (ushort)(BX + (short)19552)];
        // 100D:01B9 mov CL,4
        CL = (byte)0x04;
        // 100D:01BB shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:01BD mov byte ptr DS:[SI+0x11],AL
        UInt8[DS, (ushort)(SI + (sbyte)17)] = AL;
        // 100D:01C0 add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:01C3 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:01C6 jne short 0x0192
        if (!ZeroFlag)
        {
            goto label_100D_0192_10262_3007;
        }
    label_100D_01C8_10298_3066:
        CheckExternalEvents(cs1, 0x01C8);
        // 100D:01C8 mov DI,0x0100
        DI = (ushort)0x0100;
    label_100D_01CB_1029B_3068:
        CheckExternalEvents(cs1, 0x01CB);
        // 100D:01CB mov BP,0x01E0
        BP = (ushort)0x01E0;
        // 100D:01CE mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:01D1 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:01D4 call near 0x6603
        NearCall(cs1, 0x01D7, unknown_100D_6603_166D3);
    label_100D_01D7_102A7_3080:
        CheckExternalEvents(cs1, 0x01D7);
        // 100D:01D7 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:01DA cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:01DD jne short 0x01CB
        if (!ZeroFlag)
        {
            goto label_100D_01CB_1029B_3068;
        }
    label_100D_01DF_102AF_3131:
        CheckExternalEvents(cs1, 0x01DF);
        // 100D:01DF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_01E0_102B0(int loadOffset)
    {
    label_100D_01E0_102B0_3101:
        CheckExternalEvents(cs1, 0x01E0);
        // 100D:01E0 mov word ptr DS:[SI+4],DI
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DI;
        // 100D:01E3 mov word ptr DS:[SI+6],DX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = DX;
        // 100D:01E6 mov word ptr DS:[SI+8],BX
        UInt16[DS, (ushort)(SI + (sbyte)8)] = BX;
        // 100D:01E9 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:01EB mov AH,byte ptr DS:[SI+0x12]
        AH = UInt8[DS, (ushort)(SI + (sbyte)18)];
        // 100D:01EE and AX,0x700F
        AX = Alu16.And(AX, (ushort)0x700F);
        // 100D:01F1 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:01F3 jbe short 0x0206
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_0206_102D6_3110;
        }
    label_100D_01F5_102C5_3121:
        CheckExternalEvents(cs1, 0x01F5);
        // 100D:01F5 xor AH,0x80
        AH = Alu8.Xor(AH, (byte)0x80);
        // 100D:01F8 cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:01FA jbe short 0x0206
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_0206_102D6_3110;
        }
    label_100D_01FC_102CC_3125:
        CheckExternalEvents(cs1, 0x01FC);
        // 100D:01FC xor AH,0x80
        AH = Alu8.Xor(AH, (byte)0x80);
        // 100D:01FF cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:0201 jbe short 0x0206
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_0206_102D6_3110;
        }
    label_100D_0203_102D3_3129:
        CheckExternalEvents(cs1, 0x0203);
        // 100D:0203 xor AH,0x80
        AH = Alu8.Xor(AH, (byte)0x80);
    label_100D_0206_102D6_3110:
        CheckExternalEvents(cs1, 0x0206);
        // 100D:0206 or AL,AH
        AL = Alu8.Or(AL, AH);
        // 100D:0208 mov byte ptr DS:[SI+0x12],AL
        UInt8[DS, (ushort)(SI + (sbyte)18)] = AL;
        // 100D:020B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_021C_102EC(int loadOffset)
    {
    label_100D_021C_102EC_11588:
        CheckExternalEvents(cs1, 0x021C);
        // 100D:021C mov byte ptr DS:[0x289E],0x8C
        UInt8[DS, (ushort)0x289E] = (byte)0x8C;
        // 100D:0221 mov byte ptr DS:[0x28E7],1
        UInt8[DS, (ushort)0x28E7] = (byte)0x01;
        // 100D:0226 je short 0x0292
        if (ZeroFlag)
        {
            goto label_100D_0292_10362_12945;
        }
    label_100D_0228_102F8_11592:
        CheckExternalEvents(cs1, 0x0228);
        // 100D:0228 call near 0xAD50
        NearCall(cs1, 0x022B, unknown_100D_AD50_1AE20);
    label_100D_022B_102FB_11594:
        CheckExternalEvents(cs1, 0x022B);
        // 100D:022B mov AX,0x03E8
        AX = (ushort)0x03E8;
        // 100D:022E mov SI,1
        SI = (ushort)0x0001;
    label_100D_0231_10301_11597:
        CheckExternalEvents(cs1, 0x0231);
        // 100D:0231 push SI
        Stack.Push16(SI);
        // 100D:0232 mov BP,0x02C1
        BP = (ushort)0x02C1;
        // 100D:0235 call near 0xC102
        NearCall(cs1, 0x0238, unknown_100D_C102_1C1D2);
    label_100D_0238_10308_12281:
        CheckExternalEvents(cs1, 0x0238);
        // 100D:0238 call near 0xADE0
        NearCall(cs1, 0x023B, unknown_100D_ADE0_1AEB0);
    label_100D_023B_1030B_12283:
        CheckExternalEvents(cs1, 0x023B);
        // 100D:023B pop AX
        AX = Stack.Pop16();
        // 100D:023C push AX
        Stack.Push16(AX);
        // 100D:023D call near 0xAB4F
        NearCall(cs1, 0x0240, unknown_100D_AB4F_1AC1F);
    label_100D_0240_10310_12324:
        CheckExternalEvents(cs1, 0x0240);
        // 100D:0240 pop SI
        SI = Stack.Pop16();
        // 100D:0241 call near 0xDE54
        NearCall(cs1, 0x0244, unknown_100D_DE54_1DF24);
    label_100D_0244_10314_12327:
        CheckExternalEvents(cs1, 0x0244);
        // 100D:0244 je short 0x0292
        if (ZeroFlag)
        {
            goto label_100D_0292_10362_12945;
        }
    label_100D_0246_10316_12329:
        CheckExternalEvents(cs1, 0x0246);
        // 100D:0246 push SI
        Stack.Push16(SI);
        // 100D:0247 mov AX,0x0320
        AX = (ushort)0x0320;
        // 100D:024A mov AX,0x0FA0
        AX = (ushort)0x0FA0;
        // 100D:024D call near 0xDDB0
        NearCall(cs1, 0x0250, unknown_100D_DDB0_1DE80);
    label_100D_0250_10320_12346:
        CheckExternalEvents(cs1, 0x0250);
        // 100D:0250 pushf
        Stack.Push16(FlagRegister16);
        // 100D:0251 call near 0x0911
        NearCall(cs1, 0x0254, unknown_100D_0911_109E1);
    label_100D_0254_10324_12349:
        CheckExternalEvents(cs1, 0x0254);
        // 100D:0254 call near 0xAC14
        NearCall(cs1, 0x0257, unknown_100D_AC14_1ACE4);
    label_100D_0257_10327_12351:
        CheckExternalEvents(cs1, 0x0257);
        // 100D:0257 call near 0xADED
        NearCall(cs1, 0x025A, unknown_100D_ADED_1AEBD);
    label_100D_025A_1032A_12353:
        CheckExternalEvents(cs1, 0x025A);
        // 100D:025A popf
        FlagRegister16 = Stack.Pop16();
    label_100D_025B_1032B_12355:
        CheckExternalEvents(cs1, 0x025B);
        // 100D:025B pop SI
        SI = Stack.Pop16();
        // 100D:025C je short 0x0292
        if (ZeroFlag)
        {
            goto label_100D_0292_10362_12945;
        }
    label_100D_025E_1032E_12358:
        CheckExternalEvents(cs1, 0x025E);
        // 100D:025E inc SI
        SI = Alu16.Inc(SI);
        // 100D:025F cmp SI,8
        Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:0262 jbe short 0x0231
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_0231_10301_11597;
        }
    label_100D_0264_10334_12910:
        CheckExternalEvents(cs1, 0x0264);
        // 100D:0264 mov BP,0x0301
        BP = (ushort)0x0301;
        // 100D:0267 mov AL,0x10
        AL = (byte)0x10;
        // 100D:0269 call near 0xC108
        NearCall(cs1, 0x026C, unknown_100D_C108_1C1D8);
    label_100D_026C_1033C_12919:
        CheckExternalEvents(cs1, 0x026C);
        // 100D:026C mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 100D:026F call near 0xDDB0
        NearCall(cs1, 0x0272, unknown_100D_DDB0_1DE80);
    label_100D_0272_10342_12922:
        CheckExternalEvents(cs1, 0x0272);
        // 100D:0272 mov BL,0x0C
        BL = (byte)0x0C;
        // 100D:0274 call near 0x38F1
        NearCall(cs1, 0x0277, unknown_100D_38F1_139C1);
    label_100D_0277_10347_12934:
        CheckExternalEvents(cs1, 0x0277);
        // 100D:0277 mov byte ptr DS:[0x46DF],1
        UInt8[DS, (ushort)0x46DF] = (byte)0x01;
        // 100D:027C mov AX,0x04B0
        AX = (ushort)0x04B0;
        // 100D:027F call near 0xDDB0
        NearCall(cs1, 0x0282, unknown_100D_DDB0_1DE80);
    label_100D_0282_10352_12938:
        CheckExternalEvents(cs1, 0x0282);
        // 100D:0282 call near 0x3950
        NearCall(cs1, 0x0285, unknown_100D_3950_13A20);
    label_100D_0285_10355_12940:
        CheckExternalEvents(cs1, 0x0285);
        // 100D:0285 mov byte ptr DS:[0x46DF],0
        UInt8[DS, (ushort)0x46DF] = (byte)0x00;
        // 100D:028A mov BP,0xC0AD
        BP = (ushort)0xC0AD;
        // 100D:028D mov AL,0x10
        AL = (byte)0x10;
        // 100D:028F call near 0xC108
        NearCall(cs1, 0x0292, unknown_100D_C108_1C1D8);
    label_100D_0292_10362_12945:
        CheckExternalEvents(cs1, 0x0292);
        // 100D:0292 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:0296 call far dword ptr DS:[0x38D5]
        ushort targetSegment_12947 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D5 + (ushort)0x0002)]));
        ushort targetOffset_12947 = unchecked((ushort)(UInt16[DS, (ushort)0x38D5]));
        if (targetSegment_12947 == cs2 && targetOffset_12947 == 0x0118)
        {
            FarCall(cs1, 0x029A, cs2, unknown_3358_0118_33698);
            goto label_100D_029A_1036A_12948;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12947:X4}:{targetOffset_12947:X4} at 100D:0296");
    label_100D_029A_1036A_12948:
        CheckExternalEvents(cs1, 0x029A);
        // 100D:029A call near 0xAC14
        NearCall(cs1, 0x029D, unknown_100D_AC14_1ACE4);
    label_100D_029D_1036D_12950:
        CheckExternalEvents(cs1, 0x029D);
        // 100D:029D mov byte ptr DS:[0x227D],0
        UInt8[DS, (ushort)0x227D] = (byte)0x00;
        // 100D:02A2 mov byte ptr DS:[0x00C5],0
        UInt8[DS, (ushort)0x00C5] = (byte)0x00;
        // 100D:02A7 call near 0x0911
        NearCall(cs1, 0x02AA, unknown_100D_0911_109E1);
    label_100D_02AA_1037A_12958:
        CheckExternalEvents(cs1, 0x02AA);
        // 100D:02AA mov byte ptr DS:[0x28E7],0
        UInt8[DS, (ushort)0x28E7] = (byte)0x00;
        // 100D:02AF mov byte ptr DS:[0xDBE6],6
        UInt8[DS, (ushort)0xDBE6] = (byte)0x06;
        // 100D:02B4 inc byte ptr DS:[0x0115]
        UInt8[DS, (ushort)0x0115] = Alu8.Inc(UInt8[DS, (ushort)0x0115]);
        // 100D:02B8 mov DX,0x200A
        DX = (ushort)0x200A;
        // 100D:02BB mov BX,0x0180
        BX = (ushort)0x0180;
        // 100D:02BE jmp near 0x08F0
        return unknown_100D_08F0_109C0(0x0000);
    }

    public virtual Action unknown_100D_02C1_10391(int loadOffset)
    {
    label_100D_02C1_10391_11600:
        CheckExternalEvents(cs1, 0x02C1);
        // 100D:02C1 push SI
        Stack.Push16(SI);
        // 100D:02C2 call near 0xC0AD
        NearCall(cs1, 0x02C5, unknown_100D_C0AD_1C17D);
    label_100D_02C5_10395_11603:
        CheckExternalEvents(cs1, 0x02C5);
        // 100D:02C5 add SI,SI
        SI = Alu16.Add(SI, SI);
        // 100D:02C7 mov BP,word ptr CS:[SI+0x020A]
        BP = UInt16[CS, (ushort)(SI + (short)522)];
        // 100D:02CC call near BP
        switch ((ushort)(BP))
        {
            case 0x02DE:
                NearCall(cs1, 0x02CE, unknown_100D_02DE_103AE);
                break;
            case 0x02E3:
                NearCall(cs1, 0x02CE, unknown_100D_02E3_103B3);
                break;
            case 0x02F8:
                NearCall(cs1, 0x02CE, unknown_100D_02F8_103C8);
                break;
            case 0x02FB:
                NearCall(cs1, 0x02CE, unknown_100D_02FB_103CB);
                break;
            case 0x02FE:
                NearCall(cs1, 0x02CE, unknown_100D_02FE_103CE);
                break;
            case 0x094A:
                NearCall(cs1, 0x02CE, unknown_100D_094A_10A1A);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:02CC");
        }
    label_100D_02CE_1039E_11713:
        CheckExternalEvents(cs1, 0x02CE);
        // 100D:02CE pop AX
        AX = Stack.Pop16();
        // 100D:02CF add AX,0x0117
        AX = Alu16.Add(AX, (ushort)0x0117);
        // 100D:02D2 call near 0xD068
        NearCall(cs1, 0x02D5, unknown_100D_D068_1D138);
    label_100D_02D5_103A5_11721:
        CheckExternalEvents(cs1, 0x02D5);
        // 100D:02D5 call near 0x9901
        NearCall(cs1, 0x02D8, unknown_100D_9901_199D1);
    label_100D_02D8_103A8_11726:
        CheckExternalEvents(cs1, 0x02D8);
        // 100D:02D8 call near 0x88AF
        NearCall(cs1, 0x02DB, unknown_100D_88AF_1897F);
    label_100D_02DB_103AB_12279:
        CheckExternalEvents(cs1, 0x02DB);
        // 100D:02DB jmp near 0x9901
        return unknown_100D_9901_199D1(0x0000);
    }

    public virtual Action intro_floppy_scene_stars_100D_02DE_103AE(int loadOffset)
    {
    label_100D_02DE_103AE_11607:
        CheckExternalEvents(cs1, 0x02DE);
        // 100D:02DE xor CX,CX
        CX = Alu16.Xor(CX, CX);
        return unknown_100D_02E0_103B0(0x0000);
    }

    public virtual Action unknown_100D_02E0_103B0(int loadOffset)
    {
    label_100D_02E0_103B0_11609:
        CheckExternalEvents(cs1, 0x02E0);
        // 100D:02E0 jmp near 0x0A44
        return unknown_100D_0A44_10B14(0x0000);
    }

    public virtual Action unknown_100D_02E3_103B3(int loadOffset)
    {
    label_100D_02E3_103B3_12363:
        CheckExternalEvents(cs1, 0x02E3);
        // 100D:02E3 mov CX,0x0020
        CX = (ushort)0x0020;
        // 100D:02E6 call near 0x02E0
        NearCall(cs1, 0x02E9, unknown_100D_02E0_103B0);
    label_100D_02E9_103B9_12383:
        CheckExternalEvents(cs1, 0x02E9);
        // 100D:02E9 call near 0xB8A7
        NearCall(cs1, 0x02EC, unknown_100D_B8A7_1B977);
    label_100D_02EC_103BC_12474:
        CheckExternalEvents(cs1, 0x02EC);
        // 100D:02EC call near 0xB85A
        NearCall(cs1, 0x02EF, unknown_100D_B85A_1B92A);
    label_100D_02EF_103BF_12707:
        CheckExternalEvents(cs1, 0x02EF);
        // 100D:02EF mov AX,0x002C
        AX = (ushort)0x002C;
        // 100D:02F2 call near 0xC13E
        NearCall(cs1, 0x02F5, unknown_100D_C13E_1C20E);
    label_100D_02F5_103C5_12710:
        CheckExternalEvents(cs1, 0x02F5);
        // 100D:02F5 jmp near 0xB8EA
        return unknown_100D_B8EA_1B9BA(0x0000);
    }

    public virtual Action unknown_100D_02F8_103C8(int loadOffset)
    {
    entrydispatcher:
    label_100D_02F8_103C8_12849:
        CheckExternalEvents(cs1, 0x02F8);
        // 100D:02F8 jmp near 0x07EE
        if (JumpDispatcher.Jump(unknown_100D_07EE_108BE, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_02FB_103CB(int loadOffset)
    {
    entrydispatcher:
    label_100D_02FB_103CB_12856:
        CheckExternalEvents(cs1, 0x02FB);
        // 100D:02FB jmp near 0x09AD
        if (JumpDispatcher.Jump(unknown_100D_09AD_10A7D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_02FE_103CE(int loadOffset)
    {
    label_100D_02FE_103CE_12908:
        CheckExternalEvents(cs1, 0x02FE);
        // 100D:02FE jmp near 0x076A
        return unknown_100D_076A_1083A(0x0000);
    }

    public virtual Action unknown_100D_0301_103D1(int loadOffset)
    {
    label_100D_0301_103D1_12914:
        CheckExternalEvents(cs1, 0x0301);
        // 100D:0301 call near 0xC0AD
        NearCall(cs1, 0x0304, unknown_100D_C0AD_1C17D);
    label_100D_0304_103D4_12916:
        CheckExternalEvents(cs1, 0x0304);
        // 100D:0304 mov AL,0x1B
        AL = (byte)0x1B;
        // 100D:0306 jmp near 0xC2F2
        return unknown_100D_C2F2_1C3C2(0x0000);
    }

    public virtual Action unknown_100D_0309_103D9(int loadOffset)
    {
    label_100D_0309_103D9_11517:
        CheckExternalEvents(cs1, 0x0309);
        // 100D:0309 je short 0x0331
        if (ZeroFlag)
        {
            goto label_100D_0331_10401_11579;
        }
    label_100D_030B_103DB_11519:
        CheckExternalEvents(cs1, 0x030B);
        // 100D:030B call near 0xDE4E
        NearCall(cs1, 0x030E, unknown_100D_DE4E_1DF1E);
    label_100D_030E_103DE_11521:
        CheckExternalEvents(cs1, 0x030E);
        // 100D:030E call near 0xC07C
        NearCall(cs1, 0x0311, unknown_100D_C07C_1C14C);
    label_100D_0311_103E1_11523:
        CheckExternalEvents(cs1, 0x0311);
        // 100D:0311 call near 0xC0AD
        NearCall(cs1, 0x0314, unknown_100D_C0AD_1C17D);
    label_100D_0314_103E4_11525:
        CheckExternalEvents(cs1, 0x0314);
        // 100D:0314 mov AX,0x0018
        AX = (ushort)0x0018;
        // 100D:0317 call far dword ptr DS:[0x3939]
        ushort targetSegment_11527 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3939 + (ushort)0x0002)]));
        ushort targetOffset_11527 = unchecked((ushort)(UInt16[DS, (ushort)0x3939]));
        if (targetSegment_11527 == cs2 && targetOffset_11527 == 0x0163)
        {
            FarCall(cs1, 0x031B, cs2, unknown_3358_0163_336E3);
            goto label_100D_031B_103EB_11528;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11527:X4}:{targetOffset_11527:X4} at 100D:0317");
    label_100D_031B_103EB_11528:
        CheckExternalEvents(cs1, 0x031B);
        // 100D:031B mov BP,0x09EF
        BP = (ushort)0x09EF;
        // 100D:031E call near 0xC102
        NearCall(cs1, 0x0321, unknown_100D_C102_1C1D2);
    label_100D_0321_103F1_11538:
        CheckExternalEvents(cs1, 0x0321);
        // 100D:0321 call near 0xAD50
        NearCall(cs1, 0x0324, unknown_100D_AD50_1AE20);
    label_100D_0324_103F4_11545:
        CheckExternalEvents(cs1, 0x0324);
        // 100D:0324 call near 0x0A16
        NearCall(cs1, 0x0327, unknown_100D_0A16_10AE6);
    label_100D_0327_103F7_11567:
        CheckExternalEvents(cs1, 0x0327);
        // 100D:0327 call near 0xCC85
        NearCall(cs1, 0x032A, unknown_100D_CC85_1CD55);
    label_100D_032A_103FA_11569:
        CheckExternalEvents(cs1, 0x032A);
        // 100D:032A jne short 0x0331
        if (!ZeroFlag)
        {
            goto label_100D_0331_10401_11579;
        }
    label_100D_032C_103FC_11571:
        CheckExternalEvents(cs1, 0x032C);
        // 100D:032C call near 0xDD63
        NearCall(cs1, 0x032F, unknown_100D_DD63_1DE33);
    label_100D_032F_103FF_11573:
        CheckExternalEvents(cs1, 0x032F);
        // 100D:032F jae short 0x0324
        if (!CarryFlag)
        {
            goto label_100D_0324_103F4_11545;
        }
    label_100D_0331_10401_11579:
        CheckExternalEvents(cs1, 0x0331);
        // 100D:0331 pushf
        Stack.Push16(FlagRegister16);
        // 100D:0332 call near 0x0579
        NearCall(cs1, 0x0335, unknown_100D_0579_10649);
    label_100D_0335_10405_11582:
        CheckExternalEvents(cs1, 0x0335);
        // 100D:0335 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_0336_10406_11584:
        CheckExternalEvents(cs1, 0x0336);
        // 100D:0336 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0579_10649(int loadOffset)
    {
    label_100D_0579_10649_5269:
        CheckExternalEvents(cs1, 0x0579);
        // 100D:0579 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:057B call far dword ptr DS:[0x3939]
        ushort targetSegment_5271 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3939 + (ushort)0x0002)]));
        ushort targetOffset_5271 = unchecked((ushort)(UInt16[DS, (ushort)0x3939]));
        if (targetSegment_5271 == cs2 && targetOffset_5271 == 0x0163)
        {
            FarCall(cs1, 0x057F, cs2, unknown_3358_0163_336E3);
            goto label_100D_057F_1064F_5272;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5271:X4}:{targetOffset_5271:X4} at 100D:057B");
    label_100D_057F_1064F_5272:
        CheckExternalEvents(cs1, 0x057F);
        // 100D:057F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0580_10650(int loadOffset)
    {
    label_100D_0580_10650_3348:
        CheckExternalEvents(cs1, 0x0580);
        // 100D:0580 call near 0xDE54
        NearCall(cs1, 0x0583, unknown_100D_DE54_1DF24);
    label_100D_0583_10653_3356:
        CheckExternalEvents(cs1, 0x0583);
        // 100D:0583 je short 0x05FD
        if (ZeroFlag)
        {
            goto label_100D_05FD_106CD_11495;
        }
    label_100D_0585_10655_3358:
        CheckExternalEvents(cs1, 0x0585);
        // 100D:0585 call far dword ptr DS:[0x3959]
        ushort targetSegment_3358 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_3358 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_3358 == cs2 && targetOffset_3358 == 0x017B)
        {
            FarCall(cs1, 0x0589, cs2, unknown_3358_017B_336FB);
            goto label_100D_0589_10659_3386;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3358:X4}:{targetOffset_3358:X4} at 100D:0585");
    label_100D_0589_10659_3386:
        CheckExternalEvents(cs1, 0x0589);
        // 100D:0589 call near 0xAEB7
        NearCall(cs1, 0x058C, unknown_100D_AEB7_1AF87);
    label_100D_058C_1065C_3398:
        CheckExternalEvents(cs1, 0x058C);
        // 100D:058C mov SI,0x0337
        SI = (ushort)0x0337;
        // 100D:058F call near 0x0945
        NearCall(cs1, 0x0592, unknown_100D_0945_10A15);
    label_100D_0592_10662_3404:
        CheckExternalEvents(cs1, 0x0592);
        // 100D:0592 mov AX,0x0018
        AX = (ushort)0x0018;
        // 100D:0595 call far dword ptr DS:[0x3939]
        ushort targetSegment_3406 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3939 + (ushort)0x0002)]));
        ushort targetOffset_3406 = unchecked((ushort)(UInt16[DS, (ushort)0x3939]));
        if (targetSegment_3406 == cs2 && targetOffset_3406 == 0x0163)
        {
            FarCall(cs1, 0x0599, cs2, unknown_3358_0163_336E3);
            goto label_100D_0599_10669_3414;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3406:X4}:{targetOffset_3406:X4} at 100D:0595");
    label_100D_0599_10669_3414:
        CheckExternalEvents(cs1, 0x0599);
        // 100D:0599 call near 0x093F
        NearCall(cs1, 0x059C, unknown_100D_093F_10A0F);
    label_100D_059C_1066C_3419:
        CheckExternalEvents(cs1, 0x059C);
        // 100D:059C mov BX,AX
        BX = AX;
        // 100D:059E inc AX
        AX = Alu16.Inc(AX);
        // 100D:059F jne short 0x05A3
        if (!ZeroFlag)
        {
            goto label_100D_05A3_10673_3423;
        }
    label_100D_05A1_10671_11488:
        CheckExternalEvents(cs1, 0x05A1);
        // 100D:05A1 jmp short 0x0580
        goto label_100D_0580_10650_3348;
    label_100D_05A3_10673_3423:
        CheckExternalEvents(cs1, 0x05A3);
        // 100D:05A3 call near 0xDE0C
        NearCall(cs1, 0x05A6, unknown_100D_DE0C_1DEDC);
    label_100D_05A6_10676_3433:
        CheckExternalEvents(cs1, 0x05A6);
        // 100D:05A6 jb short 0x05FD
        if (CarryFlag)
        {
            goto label_100D_05FD_106CD_11495;
        }
    label_100D_05A8_10678_3435:
        CheckExternalEvents(cs1, 0x05A8);
        // 100D:05A8 call near 0x0911
        NearCall(cs1, 0x05AB, unknown_100D_0911_109E1);
    label_100D_05AB_1067B_3606:
        CheckExternalEvents(cs1, 0x05AB);
        // 100D:05AB call far dword ptr DS:[0x3959]
        ushort targetSegment_3606 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_3606 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_3606 == cs2 && targetOffset_3606 == 0x017B)
        {
            FarCall(cs1, 0x05AF, cs2, unknown_3358_017B_336FB);
            goto label_100D_05AF_1067F_3608;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3606:X4}:{targetOffset_3606:X4} at 100D:05AB");
    label_100D_05AF_1067F_3608:
        CheckExternalEvents(cs1, 0x05AF);
        // 100D:05AF call near 0x093F
        NearCall(cs1, 0x05B2, unknown_100D_093F_10A0F);
    label_100D_05B2_10682_3610:
        CheckExternalEvents(cs1, 0x05B2);
        // 100D:05B2 mov BP,AX
        BP = AX;
        // 100D:05B4 call near 0xC097
        NearCall(cs1, 0x05B7, unknown_100D_C097_1C167);
    label_100D_05B7_10687_4430:
        CheckExternalEvents(cs1, 0x05B7);
        // 100D:05B7 and byte ptr DS:[0x47D1],0x7F
        UInt8[DS, (ushort)0x47D1] = Alu8.And(UInt8[DS, (ushort)0x47D1], (byte)0x7F);
        // 100D:05BC call near 0x39E6
        NearCall(cs1, 0x05BF, unknown_100D_39E6_13AB6);
    label_100D_05BF_1068F_4433:
        CheckExternalEvents(cs1, 0x05BF);
        // 100D:05BF call near 0x093F
        NearCall(cs1, 0x05C2, unknown_100D_093F_10A0F);
    label_100D_05C2_10692_4435:
        CheckExternalEvents(cs1, 0x05C2);
        // 100D:05C2 mov BX,AX
        BX = AX;
        // 100D:05C4 call near 0xDE0C
        NearCall(cs1, 0x05C7, unknown_100D_DE0C_1DEDC);
    label_100D_05C7_10697_4473:
        CheckExternalEvents(cs1, 0x05C7);
        // 100D:05C7 jb short 0x05FD
        if (CarryFlag)
        {
            goto label_100D_05FD_106CD_11495;
        }
    label_100D_05C9_10699_4475:
        CheckExternalEvents(cs1, 0x05C9);
        // 100D:05C9 call near 0x093F
        NearCall(cs1, 0x05CC, unknown_100D_093F_10A0F);
    label_100D_05CC_1069C_4477:
        CheckExternalEvents(cs1, 0x05CC);
        // 100D:05CC or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:05CE js short 0x05DC
        if (SignFlag)
        {
            goto label_100D_05DC_106AC_4717;
        }
    label_100D_05D0_106A0_4480:
        CheckExternalEvents(cs1, 0x05D0);
        // 100D:05D0 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:05D3 call near 0xC108
        NearCall(cs1, 0x05D6, unknown_100D_C108_1C1D8);
    label_100D_05D6_106A6_4696:
        CheckExternalEvents(cs1, 0x05D6);
        // 100D:05D6 call near 0xC0F4
        NearCall(cs1, 0x05D9, unknown_100D_C0F4_1C1C4);
    label_100D_05D9_106A9_4707:
        CheckExternalEvents(cs1, 0x05D9);
        // 100D:05D9 call near 0x3A7C
        NearCall(cs1, 0x05DC, unknown_100D_3A7C_13B4C);
    label_100D_05DC_106AC_4717:
        CheckExternalEvents(cs1, 0x05DC);
        // 100D:05DC call near 0xC07C
        NearCall(cs1, 0x05DF, unknown_100D_C07C_1C14C);
    label_100D_05DF_106AF_4719:
        CheckExternalEvents(cs1, 0x05DF);
        // 100D:05DF or byte ptr DS:[0x47D1],0x80
        UInt8[DS, (ushort)0x47D1] = Alu8.Or(UInt8[DS, (ushort)0x47D1], (byte)0x80);
        // 100D:05E4 call near 0xDD63
        NearCall(cs1, 0x05E7, unknown_100D_DD63_1DE33);
    label_100D_05E7_106B7_4799:
        CheckExternalEvents(cs1, 0x05E7);
        // 100D:05E7 jb short 0x05FD
        if (CarryFlag)
        {
            goto label_100D_05FD_106CD_11495;
        }
    label_100D_05E9_106B9_4801:
        CheckExternalEvents(cs1, 0x05E9);
        // 100D:05E9 call near 0x093F
        NearCall(cs1, 0x05EC, unknown_100D_093F_10A0F);
    label_100D_05EC_106BC_4803:
        CheckExternalEvents(cs1, 0x05EC);
        // 100D:05EC clc
        CarryFlag = false;
        // 100D:05ED call near AX
        switch ((ushort)(AX))
        {
            case 0x0625:
                NearCall(cs1, 0x05EF, unknown_100D_0625_106F5);
                break;
            case 0x0661:
                NearCall(cs1, 0x05EF, unknown_100D_0661_10731);
                break;
            case 0x0684:
                NearCall(cs1, 0x05EF, unknown_100D_0684_10754);
                break;
            case 0x06AA:
                NearCall(cs1, 0x05EF, unknown_100D_06AA_1077A);
                break;
            case 0x06BD:
                NearCall(cs1, 0x05EF, unknown_100D_06BD_1078D);
                break;
            case 0x06FC:
                NearCall(cs1, 0x05EF, unknown_100D_06FC_107CC);
                break;
            case 0x0704:
                NearCall(cs1, 0x05EF, unknown_100D_0704_107D4);
                break;
            case 0x071D:
                NearCall(cs1, 0x05EF, unknown_100D_071D_107ED);
                break;
            case 0x078D:
                NearCall(cs1, 0x05EF, unknown_100D_078D_1085D);
                break;
            case 0x0798:
                NearCall(cs1, 0x05EF, unknown_100D_0798_10868);
                break;
            case 0x085D:
                NearCall(cs1, 0x05EF, unknown_100D_085D_1092D);
                break;
            case 0x087B:
                NearCall(cs1, 0x05EF, unknown_100D_087B_1094B);
                break;
            case 0x08B6:
                NearCall(cs1, 0x05EF, unknown_100D_08B6_10986);
                break;
            case 0x0F66:
                NearCall(cs1, 0x05EF, unknown_100D_0F66_11036);
                break;
            case 0xCF1B:
                NearCall(cs1, 0x05EF, unknown_100D_CF1B_1CFEB);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(AX)):X4} at 100D:05ED");
        }
    label_100D_05EF_106BF_5118:
        CheckExternalEvents(cs1, 0x05EF);
        // 100D:05EF jb short 0x05FD
        if (CarryFlag)
        {
            goto label_100D_05FD_106CD_11495;
        }
    label_100D_05F1_106C1_5120:
        CheckExternalEvents(cs1, 0x05F1);
        // 100D:05F1 call near 0x093F
        NearCall(cs1, 0x05F4, unknown_100D_093F_10A0F);
    label_100D_05F4_106C4_5122:
        CheckExternalEvents(cs1, 0x05F4);
        // 100D:05F4 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:05F6 je short 0x0592
        if (ZeroFlag)
        {
            goto label_100D_0592_10662_3404;
        }
    label_100D_05F8_106C8_5125:
        CheckExternalEvents(cs1, 0x05F8);
        // 100D:05F8 call near 0xDDF0
        NearCall(cs1, 0x05FB, unknown_100D_DDF0_1DEC0);
    label_100D_05FB_106CB_5168:
        CheckExternalEvents(cs1, 0x05FB);
        // 100D:05FB jae short 0x0592
        if (!CarryFlag)
        {
            goto label_100D_0592_10662_3404;
        }
    label_100D_05FD_106CD_11495:
        CheckExternalEvents(cs1, 0x05FD);
        // 100D:05FD pushf
        Stack.Push16(FlagRegister16);
        // 100D:05FE call near 0x9985
        NearCall(cs1, 0x0601, unknown_100D_9985_19A55);
    label_100D_0601_106D1_11498:
        CheckExternalEvents(cs1, 0x0601);
        // 100D:0601 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:0605 call far dword ptr DS:[0x38D5]
        ushort targetSegment_11500 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D5 + (ushort)0x0002)]));
        ushort targetOffset_11500 = unchecked((ushort)(UInt16[DS, (ushort)0x38D5]));
        if (targetSegment_11500 == cs2 && targetOffset_11500 == 0x0118)
        {
            FarCall(cs1, 0x0609, cs2, unknown_3358_0118_33698);
            goto label_100D_0609_106D9_11501;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11500:X4}:{targetOffset_11500:X4} at 100D:0605");
    label_100D_0609_106D9_11501:
        CheckExternalEvents(cs1, 0x0609);
        // 100D:0609 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_060A_106DA_11503:
        CheckExternalEvents(cs1, 0x060A);
        // 100D:060A pushf
        Stack.Push16(FlagRegister16);
        // 100D:060B call near 0x0579
        NearCall(cs1, 0x060E, unknown_100D_0579_10649);
    label_100D_060E_106DE_11506:
        CheckExternalEvents(cs1, 0x060E);
        // 100D:060E call near 0xCA01
        NearCall(cs1, 0x0611, unknown_100D_CA01_1CAD1);
    label_100D_0611_106E1_11508:
        CheckExternalEvents(cs1, 0x0611);
        // 100D:0611 mov word ptr DS:[2],2
        UInt16[DS, (ushort)0x0002] = (ushort)0x0002;
        // 100D:0617 call near 0x0911
        NearCall(cs1, 0x061A, unknown_100D_0911_109E1);
    label_100D_061A_106EA_11511:
        CheckExternalEvents(cs1, 0x061A);
        // 100D:061A popf
        FlagRegister16 = Stack.Pop16();
    label_100D_061B_106EB_11513:
        CheckExternalEvents(cs1, 0x061B);
        // 100D:061B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_061C_106EC(int loadOffset)
    {
    entrydispatcher:
    label_100D_061C_106EC_3620:
        CheckExternalEvents(cs1, 0x061C);
        // 100D:061C call near 0xAD57
        NearCall(cs1, 0x061F, unknown_100D_AD57_1AE27);
    label_100D_061F_106EF_4111:
        CheckExternalEvents(cs1, 0x061F);
        // 100D:061F mov AX,0x0015
        AX = (ushort)0x0015;
        // 100D:0622 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0625_106F5(int loadOffset)
    {
    label_100D_0625_106F5_4806:
        CheckExternalEvents(cs1, 0x0625);
        // 100D:0625 call near 0xC07C
        NearCall(cs1, 0x0628, unknown_100D_C07C_1C14C);
    label_100D_0628_106F8_4808:
        CheckExternalEvents(cs1, 0x0628);
        // 100D:0628 call near 0xDD63
        NearCall(cs1, 0x062B, unknown_100D_DD63_1DE33);
    label_100D_062B_106FB_4810:
        CheckExternalEvents(cs1, 0x062B);
        // 100D:062B jb short 0x064C
        if (CarryFlag)
        {
            goto label_100D_064C_1071C_5117;
        }
    label_100D_062D_106FD_4812:
        CheckExternalEvents(cs1, 0x062D);
        // 100D:062D call near 0xC9F4
        NearCall(cs1, 0x0630, unknown_100D_C9F4_1CAC4);
    label_100D_0630_10700_4912:
        CheckExternalEvents(cs1, 0x0630);
        // 100D:0630 je short 0x0628
        if (ZeroFlag)
        {
            goto label_100D_0628_106F8_4808;
        }
    label_100D_0632_10702_4914:
        CheckExternalEvents(cs1, 0x0632);
        // 100D:0632 call near 0xC4CD
        NearCall(cs1, 0x0635, unknown_100D_C4CD_1C59D);
    label_100D_0635_10705_4916:
        CheckExternalEvents(cs1, 0x0635);
        // 100D:0635 cmp word ptr DS:[0xDBCE],8
        Alu16.Sub(UInt16[DS, (ushort)0xDBCE], unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:063A jb short 0x0646
        if (CarryFlag)
        {
            goto label_100D_0646_10716_4919;
        }
    label_100D_063C_1070C_5096:
        CheckExternalEvents(cs1, 0x063C);
        // 100D:063C cmp byte ptr DS:[0xDBCB],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCB], (byte)0x00);
        // 100D:0641 je short 0x0646
        if (ZeroFlag)
        {
            goto label_100D_0646_10716_4919;
        }
    label_100D_0643_10713_5099:
        CheckExternalEvents(cs1, 0x0643);
        // 100D:0643 call near 0xAEB7
        NearCall(cs1, 0x0646, unknown_100D_AEB7_1AF87);
    label_100D_0646_10716_4919:
        CheckExternalEvents(cs1, 0x0646);
        // 100D:0646 call near 0xCC85
        NearCall(cs1, 0x0649, unknown_100D_CC85_1CD55);
    label_100D_0649_10719_4926:
        CheckExternalEvents(cs1, 0x0649);
        // 100D:0649 je short 0x0628
        if (ZeroFlag)
        {
            goto label_100D_0628_106F8_4808;
        }
    label_100D_064B_1071B_5115:
        CheckExternalEvents(cs1, 0x064B);
        // 100D:064B clc
        CarryFlag = false;
    label_100D_064C_1071C_5117:
        CheckExternalEvents(cs1, 0x064C);
        // 100D:064C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_064D_1071D(int loadOffset)
    {
    entrydispatcher:
    label_100D_064D_1071D_5170:
        CheckExternalEvents(cs1, 0x064D);
        // 100D:064D mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:064F call near 0xAD95
        NearCall(cs1, 0x0652, unknown_100D_AD95_1AE65);
    label_100D_0652_10722_5192:
        CheckExternalEvents(cs1, 0x0652);
        // 100D:0652 mov AX,0x0016
        AX = (ushort)0x0016;
        // 100D:0655 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0658_10728(int loadOffset)
    {
    entrydispatcher:
    label_100D_0658_10728_5246:
        CheckExternalEvents(cs1, 0x0658);
        // 100D:0658 call near 0xC0AD
        NearCall(cs1, 0x065B, unknown_100D_C0AD_1C17D);
    label_100D_065B_1072B_5248:
        CheckExternalEvents(cs1, 0x065B);
        // 100D:065B mov AX,0x0017
        AX = (ushort)0x0017;
        // 100D:065E jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0661_10731(int loadOffset)
    {
    label_100D_0661_10731_5204:
        CheckExternalEvents(cs1, 0x0661);
        // 100D:0661 call near 0xC07C
        NearCall(cs1, 0x0664, unknown_100D_C07C_1C14C);
    label_100D_0664_10734_5206:
        CheckExternalEvents(cs1, 0x0664);
        // 100D:0664 call near 0xDD63
        NearCall(cs1, 0x0667, unknown_100D_DD63_1DE33);
    label_100D_0667_10737_5208:
        CheckExternalEvents(cs1, 0x0667);
        // 100D:0667 jb short 0x064C
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:0667");
        }
    label_100D_0669_10739_5210:
        CheckExternalEvents(cs1, 0x0669);
        // 100D:0669 call near 0xC9F4
        NearCall(cs1, 0x066C, unknown_100D_C9F4_1CAC4);
    label_100D_066C_1073C_5212:
        CheckExternalEvents(cs1, 0x066C);
        // 100D:066C je short 0x0664
        if (ZeroFlag)
        {
            goto label_100D_0664_10734_5206;
        }
    label_100D_066E_1073E_5214:
        CheckExternalEvents(cs1, 0x066E);
        // 100D:066E call near 0xC4CD
        NearCall(cs1, 0x0671, unknown_100D_C4CD_1C59D);
    label_100D_0671_10741_5216:
        CheckExternalEvents(cs1, 0x0671);
        // 100D:0671 call near 0xCC85
        NearCall(cs1, 0x0674, unknown_100D_CC85_1CD55);
    label_100D_0674_10744_5218:
        CheckExternalEvents(cs1, 0x0674);
        // 100D:0674 je short 0x0664
        if (ZeroFlag)
        {
            goto label_100D_0664_10734_5206;
        }
    label_100D_0676_10746_5243:
        CheckExternalEvents(cs1, 0x0676);
        // 100D:0676 clc
        CarryFlag = false;
        // 100D:0677 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0678_10748(int loadOffset)
    {
    entrydispatcher:
    label_100D_0678_10748_5267:
        CheckExternalEvents(cs1, 0x0678);
        // 100D:0678 call near 0x0579
        NearCall(cs1, 0x067B, unknown_100D_0579_10649);
    label_100D_067B_1074B_5274:
        CheckExternalEvents(cs1, 0x067B);
        // 100D:067B call near 0xC0AD
        NearCall(cs1, 0x067E, unknown_100D_C0AD_1C17D);
    label_100D_067E_1074E_5276:
        CheckExternalEvents(cs1, 0x067E);
        // 100D:067E mov AX,0x0018
        AX = (ushort)0x0018;
        // 100D:0681 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0684_10754(int loadOffset)
    {
    label_100D_0684_10754_5354:
        CheckExternalEvents(cs1, 0x0684);
        // 100D:0684 jmp short 0x06BD
        return unknown_100D_06BD_1078D(0x0000);
    }

    public virtual Action unknown_100D_069E_1076E(int loadOffset)
    {
    entrydispatcher:
    label_100D_069E_1076E_5888:
        CheckExternalEvents(cs1, 0x069E);
        // 100D:069E call near 0xC07C
        NearCall(cs1, 0x06A1, unknown_100D_C07C_1C14C);
    label_100D_06A1_10771_5890:
        CheckExternalEvents(cs1, 0x06A1);
        // 100D:06A1 call near 0x0579
        NearCall(cs1, 0x06A4, unknown_100D_0579_10649);
    label_100D_06A4_10774_5892:
        CheckExternalEvents(cs1, 0x06A4);
        // 100D:06A4 mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:06A7 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_06AA_1077A(int loadOffset)
    {
    label_100D_06AA_1077A_5912:
        CheckExternalEvents(cs1, 0x06AA);
        // 100D:06AA call near 0x0579
        NearCall(cs1, 0x06AD, unknown_100D_0579_10649);
    label_100D_06AD_1077D_5914:
        CheckExternalEvents(cs1, 0x06AD);
        // 100D:06AD call near 0xC08E
        NearCall(cs1, 0x06B0, unknown_100D_C08E_1C15E);
    label_100D_06B0_10780_5916:
        CheckExternalEvents(cs1, 0x06B0);
        // 100D:06B0 call near 0xC9E8
        NearCall(cs1, 0x06B3, unknown_100D_C9E8_1CAB8);
    label_100D_06B3_10783_5920:
        CheckExternalEvents(cs1, 0x06B3);
        // 100D:06B3 jb short 0x06BC
        if (CarryFlag)
        {
            goto label_100D_06BC_1078C_5955;
        }
    label_100D_06B5_10785_5922:
        CheckExternalEvents(cs1, 0x06B5);
        // 100D:06B5 cmp word ptr DS:[0xDBE8],0x0056
        Alu16.Sub(UInt16[DS, (ushort)0xDBE8], unchecked((ushort)unchecked((short)(sbyte)86)));
        // 100D:06BA jne short 0x06B0
        if (!ZeroFlag)
        {
            goto label_100D_06B0_10780_5916;
        }
    label_100D_06BC_1078C_5955:
        CheckExternalEvents(cs1, 0x06BC);
        // 100D:06BC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_06BD_1078D(int loadOffset)
    {
    label_100D_06BD_1078D_5356:
        CheckExternalEvents(cs1, 0x06BD);
        // 100D:06BD call near 0x0579
        NearCall(cs1, 0x06C0, unknown_100D_0579_10649);
    label_100D_06C0_10790_5358:
        CheckExternalEvents(cs1, 0x06C0);
        // 100D:06C0 call near 0xC08E
        NearCall(cs1, 0x06C3, unknown_100D_C08E_1C15E);
    label_100D_06C3_10793_5360:
        CheckExternalEvents(cs1, 0x06C3);
        // 100D:06C3 call near 0xC9E8
        NearCall(cs1, 0x06C6, unknown_100D_C9E8_1CAB8);
    label_100D_06C6_10796_5370:
        CheckExternalEvents(cs1, 0x06C6);
        // 100D:06C6 jb short 0x06BC
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:06C6");
        }
    label_100D_06C8_10798_5372:
        CheckExternalEvents(cs1, 0x06C8);
        // 100D:06C8 call near 0xCC85
        NearCall(cs1, 0x06CB, unknown_100D_CC85_1CD55);
    label_100D_06CB_1079B_5374:
        CheckExternalEvents(cs1, 0x06CB);
        // 100D:06CB je short 0x06C3
        if (ZeroFlag)
        {
            goto label_100D_06C3_10793_5360;
        }
    label_100D_06CD_1079D_5490:
        CheckExternalEvents(cs1, 0x06CD);
        // 100D:06CD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_06CE_1079E(int loadOffset)
    {
    entrydispatcher:
    label_100D_06CE_1079E_6463:
        CheckExternalEvents(cs1, 0x06CE);
        // 100D:06CE mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:06D1 jmp short 0x06F3
        if (JumpDispatcher.Jump(unknown_100D_06F3_107C3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_06D3_107A3(int loadOffset)
    {
    entrydispatcher:
    label_100D_06D3_107A3_9569:
        CheckExternalEvents(cs1, 0x06D3);
        // 100D:06D3 mov AX,0x0011
        AX = (ushort)0x0011;
        // 100D:06D6 jmp short 0x06F3
        if (JumpDispatcher.Jump(unknown_100D_06F3_107C3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_06D8_107A8(int loadOffset)
    {
    entrydispatcher:
    label_100D_06D8_107A8_10907:
        CheckExternalEvents(cs1, 0x06D8);
        // 100D:06D8 call near 0xAC14
        NearCall(cs1, 0x06DB, unknown_100D_AC14_1ACE4);
    label_100D_06DB_107AB_10909:
        CheckExternalEvents(cs1, 0x06DB);
        // 100D:06DB mov AL,1
        AL = (byte)0x01;
        // 100D:06DD mov byte ptr DS:[0x46DF],AL
        UInt8[DS, (ushort)0x46DF] = AL;
        // 100D:06E0 mov BL,0x12
        BL = (byte)0x12;
        // 100D:06E2 call near 0x38A2
        NearCall(cs1, 0x06E5, unknown_100D_38A2_13972);
    label_100D_06E5_107B5_10937:
        CheckExternalEvents(cs1, 0x06E5);
        // 100D:06E5 mov AX,0x0012
        AX = (ushort)0x0012;
        // 100D:06E8 jmp short 0x06F3
        if (JumpDispatcher.Jump(unknown_100D_06F3_107C3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_06EA_107BA(int loadOffset)
    {
    entrydispatcher:
    label_100D_06EA_107BA_11403:
        CheckExternalEvents(cs1, 0x06EA);
        // 100D:06EA mov word ptr DS:[4],2
        UInt16[DS, (ushort)0x0004] = (ushort)0x0002;
        // 100D:06F0 mov AX,0x0013
        AX = (ushort)0x0013;
        if (JumpDispatcher.Jump(unknown_100D_06F3_107C3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_06FC_107CC(int loadOffset)
    {
    label_100D_06FC_107CC_10940:
        CheckExternalEvents(cs1, 0x06FC);
        // 100D:06FC mov byte ptr DS:[0x46D7],0x3F
        UInt8[DS, (ushort)0x46D7] = (byte)0x3F;
        // 100D:0701 call near 0x3901
        NearCall(cs1, 0x0704, unknown_100D_3901_139D1);
        return unknown_100D_0704_107D4(0x0000);
    }

    public virtual Action unknown_100D_0704_107D4(int loadOffset)
    {
    label_100D_0704_107D4_6569:
        CheckExternalEvents(cs1, 0x0704);
        // 100D:0704 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:0706 mov SI,0x070C
        SI = (ushort)0x070C;
        // 100D:0709 call near 0xDA25
        NearCall(cs1, 0x070C, unknown_100D_DA25_1DAF5);
        return unknown_100D_070C_107DC(0x0000);
    }

    public virtual Action unknown_100D_070C_107DC(int loadOffset)
    {
    label_100D_070C_107DC_6573:
        CheckExternalEvents(cs1, 0x070C);
        // 100D:070C call near 0xCA60
        NearCall(cs1, 0x070F, unknown_100D_CA60_1CB30);
    label_100D_070F_107DF_6590:
        CheckExternalEvents(cs1, 0x070F);
        // 100D:070F clc
        CarryFlag = false;
        // 100D:0710 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0711_107E1(int loadOffset)
    {
    entrydispatcher:
    label_100D_0711_107E1_11411:
        CheckExternalEvents(cs1, 0x0711);
        // 100D:0711 add word ptr DS:[0xDBDA],0x01E0
        UInt16[DS, (ushort)0xDBDA] = Alu16.Add(UInt16[DS, (ushort)0xDBDA], (ushort)0x01E0);
        // 100D:0717 mov AX,0x000E
        AX = (ushort)0x000E;
        // 100D:071A jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_071D_107ED(int loadOffset)
    {
    label_100D_071D_107ED_11415:
        CheckExternalEvents(cs1, 0x071D);
        // 100D:071D mov AL,8
        AL = (byte)0x08;
        // 100D:071F call near 0xAB15
        NearCall(cs1, 0x0722, unknown_100D_AB15_1ABE5);
    label_100D_0722_107F2_11418:
        CheckExternalEvents(cs1, 0x0722);
        // 100D:0722 jmp short 0x072C
        goto label_100D_072C_107FC_11420;
    label_100D_0724_107F4_11424:
        CheckExternalEvents(cs1, 0x0724);
        // 100D:0724 call near 0x4B16
        NearCall(cs1, 0x0727, unknown_100D_4B16_14BE6);
    label_100D_0727_107F7_11426:
        CheckExternalEvents(cs1, 0x0727);
        // 100D:0727 call near 0x4937
        NearCall(cs1, 0x072A, unknown_100D_4937_14A07);
    label_100D_072A_107FA_11434:
        CheckExternalEvents(cs1, 0x072A);
        // 100D:072A jne short 0x0736
        if (!ZeroFlag)
        {
            goto label_100D_0736_10806_11448;
        }
    label_100D_072C_107FC_11420:
        CheckExternalEvents(cs1, 0x072C);
        // 100D:072C call near 0xC9F4
        NearCall(cs1, 0x072F, unknown_100D_C9F4_1CAC4);
    label_100D_072F_107FF_11422:
        CheckExternalEvents(cs1, 0x072F);
        // 100D:072F jne short 0x0724
        if (!ZeroFlag)
        {
            goto label_100D_0724_107F4_11424;
        }
    label_100D_0731_10801_11436:
        CheckExternalEvents(cs1, 0x0731);
        // 100D:0731 call near 0xDD63
        NearCall(cs1, 0x0734, unknown_100D_DD63_1DE33);
    label_100D_0734_10804_11438:
        CheckExternalEvents(cs1, 0x0734);
        // 100D:0734 ja short 0x0724
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_0724_107F4_11424;
        }
    label_100D_0736_10806_11448:
        CheckExternalEvents(cs1, 0x0736);
        // 100D:0736 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0737_10807(int loadOffset)
    {
    label_100D_0737_10807_10982:
        CheckExternalEvents(cs1, 0x0737);
        // 100D:0737 mov AL,0x56
        AL = (byte)0x56;
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_073C_1080C(int loadOffset)
    {
    label_100D_073C_1080C_10973:
        CheckExternalEvents(cs1, 0x073C);
        // 100D:073C mov AL,0x57
        AL = (byte)0x57;
        // 100D:073E jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0740_10810(int loadOffset)
    {
    label_100D_0740_10810_10960:
        CheckExternalEvents(cs1, 0x0740);
        // 100D:0740 call near 0xC0AD
        NearCall(cs1, 0x0743, unknown_100D_C0AD_1C17D);
    label_100D_0743_10813_10962:
        CheckExternalEvents(cs1, 0x0743);
        // 100D:0743 mov AL,0x58
        AL = (byte)0x58;
        // 100D:0745 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0747_10817(int loadOffset)
    {
    label_100D_0747_10817_10984:
        CheckExternalEvents(cs1, 0x0747);
        // 100D:0747 mov AL,0x59
        AL = (byte)0x59;
        // 100D:0749 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_074B_1081B(int loadOffset)
    {
    label_100D_074B_1081B_11406:
        CheckExternalEvents(cs1, 0x074B);
        // 100D:074B call near 0xC0AD
        NearCall(cs1, 0x074E, unknown_100D_C0AD_1C17D);
    label_100D_074E_1081E_11408:
        CheckExternalEvents(cs1, 0x074E);
        // 100D:074E mov AL,0x5A
        AL = (byte)0x5A;
        // 100D:0750 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0752_10822(int loadOffset)
    {
    label_100D_0752_10822_10970:
        CheckExternalEvents(cs1, 0x0752);
        // 100D:0752 mov AL,0x5B
        AL = (byte)0x5B;
        // 100D:0754 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0756_10826(int loadOffset)
    {
    label_100D_0756_10826_10976:
        CheckExternalEvents(cs1, 0x0756);
        // 100D:0756 mov AL,0x5C
        AL = (byte)0x5C;
        // 100D:0758 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_075A_1082A(int loadOffset)
    {
    label_100D_075A_1082A_10967:
        CheckExternalEvents(cs1, 0x075A);
        // 100D:075A mov AL,0x5D
        AL = (byte)0x5D;
        // 100D:075C jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_075E_1082E(int loadOffset)
    {
    label_100D_075E_1082E_10979:
        CheckExternalEvents(cs1, 0x075E);
        // 100D:075E mov AL,0x5E
        AL = (byte)0x5E;
        // 100D:0760 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0762_10832(int loadOffset)
    {
    label_100D_0762_10832_11455:
        CheckExternalEvents(cs1, 0x0762);
        // 100D:0762 mov AL,0x5F
        AL = (byte)0x5F;
        // 100D:0764 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_0766_10836(int loadOffset)
    {
    label_100D_0766_10836_11458:
        CheckExternalEvents(cs1, 0x0766);
        // 100D:0766 mov AL,0x60
        AL = (byte)0x60;
        // 100D:0768 jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_076A_1083A(int loadOffset)
    {
    label_100D_076A_1083A_11450:
        CheckExternalEvents(cs1, 0x076A);
        // 100D:076A call near 0xC0AD
        NearCall(cs1, 0x076D, unknown_100D_C0AD_1C17D);
    label_100D_076D_1083D_11452:
        CheckExternalEvents(cs1, 0x076D);
        // 100D:076D mov AL,0x61
        AL = (byte)0x61;
        // 100D:076F jmp short 0x0739
        return unknown_100D_0739_10809(0x0000);
    }

    public virtual Action unknown_100D_02DE_103AE(int loadOffset)
    {
    label_100D_02DE_103AE_11607:
        CheckExternalEvents(cs1, 0x02DE);
        // 100D:02DE xor CX,CX
        CX = Alu16.Xor(CX, CX);
        return unknown_100D_02E0_103B0(0x0000);
    }
}
