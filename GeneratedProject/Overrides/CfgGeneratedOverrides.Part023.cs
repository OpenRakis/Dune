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
    public virtual Action unknown_100D_E0A2_1E172(int loadOffset)
    {
    label_100D_E0A2_1E172_38687:
        CheckExternalEvents(cs1, 0xE0A2);
        // 100D:E0A2 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:E0A7 jns short 0xE0DA
        if (!SignFlag)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E0A9_1E179_38693:
        CheckExternalEvents(cs1, 0xE0A9);
        VerifySpeculativeEntryOrFail(cs1, 0xE0A9, [(byte)0xBF, (byte)0xBE, (byte)0x3C]);
        // 100D:E0A9 mov DI,0x3CBE
        DI = (ushort)0x3CBE;
        VerifySpeculativeEntryOrFail(cs1, 0xE0AC, [(byte)0x8B, (byte)0x0D]);
        // 100D:E0AC mov CX,word ptr DS:[DI]
        CX = UInt16[DS, DI];
        VerifySpeculativeEntryOrFail(cs1, 0xE0AE, [(byte)0xE3, (byte)0x2A]);
        // 100D:E0AE jcxz short 0xE0DA
        if (CX == (ushort)0x0000)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E0B0_1E180_38698:
        CheckExternalEvents(cs1, 0xE0B0);
        VerifySpeculativeEntryOrFail(cs1, 0xE0B0, [(byte)0x83, (byte)0xC7, (byte)0x02]);
        // 100D:E0B0 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_E0B3_1E183_38700:
        CheckExternalEvents(cs1, 0xE0B3);
        VerifySpeculativeEntryOrFail(cs1, 0xE0B3, [(byte)0xF6, (byte)0x45, (byte)0x0C, (byte)0xC0]);
        // 100D:E0B3 test byte ptr DS:[DI+0x0C],0xC0
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0xC0);
        VerifySpeculativeEntryOrFail(cs1, 0xE0B7, [(byte)0x75, (byte)0x1C]);
        // 100D:E0B7 jne short 0xE0D5
        if (!ZeroFlag)
        {
            goto label_100D_E0D5_1E1A5_38702;
        }
    label_100D_E0B9_1E189_38704:
        CheckExternalEvents(cs1, 0xE0B9);
        VerifySpeculativeEntryOrFail(cs1, 0xE0B9, [(byte)0xE8, (byte)0x42, (byte)0xF6]);
        // 100D:E0B9 call near 0xD6FE
        NearCall(cs1, 0xE0BC, unknown_100D_D6FE_1D7CE);
        throw FailAsUntested("Call at 100D:E0B9 returned to 100D:E0BC, but no continuation was observed during discovery.");
    label_100D_E0D5_1E1A5_38702:
        CheckExternalEvents(cs1, 0xE0D5);
        VerifySpeculativeEntryOrFail(cs1, 0xE0D5, [(byte)0x83, (byte)0xC7, (byte)0x11]);
        // 100D:E0D5 add DI,0x0011
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)17)));
        VerifySpeculativeEntryOrFail(cs1, 0xE0D8, [(byte)0xE2, (byte)0xD9]);
        // 100D:E0D8 loop 0xE0B3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E0B3_1E183_38700;
        }
        else
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_E0DB_1E1AB(int loadOffset)
    {
    label_100D_E0DB_1E1AB_38715:
        CheckExternalEvents(cs1, 0xE0DB);
        // 100D:E0DB cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:E0E0 je short 0xE0DA
        if (ZeroFlag)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E0E2_1E1B2_38720:
        CheckExternalEvents(cs1, 0xE0E2);
        VerifySpeculativeEntryOrFail(cs1, 0xE0E2, [(byte)0xBF, (byte)0xC0, (byte)0xA5]);
        // 100D:E0E2 mov DI,0xA5C0
        DI = (ushort)0xA5C0;
    label_100D_E0E5_1E1B5_38722:
        CheckExternalEvents(cs1, 0xE0E5);
        VerifySpeculativeEntryOrFail(cs1, 0xE0E5, [(byte)0x83, (byte)0x3D, (byte)0x00]);
        // 100D:E0E5 cmp word ptr DS:[DI],0
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)0)));
        VerifySpeculativeEntryOrFail(cs1, 0xE0E8, [(byte)0x74, (byte)0xF0]);
        // 100D:E0E8 je short 0xE0DA
        if (ZeroFlag)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E0EA_1E1BA_38725:
        CheckExternalEvents(cs1, 0xE0EA);
        VerifySpeculativeEntryOrFail(cs1, 0xE0EA, [(byte)0x8B, (byte)0x75, (byte)0x04]);
        // 100D:E0EA mov SI,word ptr DS:[DI+4]
        SI = UInt16[DS, (ushort)(DI + (sbyte)4)];
        VerifySpeculativeEntryOrFail(cs1, 0xE0ED, [(byte)0x81, (byte)0xE6, (byte)0xFF, (byte)0x00]);
        // 100D:E0ED and SI,0x00FF
        SI = Alu16.And(SI, (ushort)0x00FF);
        VerifySpeculativeEntryOrFail(cs1, 0xE0F1, [(byte)0x8B, (byte)0x45, (byte)0x02]);
        // 100D:E0F1 mov AX,word ptr DS:[DI+2]
        AX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        VerifySpeculativeEntryOrFail(cs1, 0xE0F4, [(byte)0x3B, (byte)0xC2]);
        // 100D:E0F4 cmp AX,DX
        Alu16.Sub(AX, DX);
        VerifySpeculativeEntryOrFail(cs1, 0xE0F6, [(byte)0x75, (byte)0x04]);
        // 100D:E0F6 jne short 0xE0FC
        if (!ZeroFlag)
        {
            goto label_100D_E0FC_1E1CC_38731;
        }
    label_100D_E0F8_1E1C8_38733:
        CheckExternalEvents(cs1, 0xE0F8);
        VerifySpeculativeEntryOrFail(cs1, 0xE0F8, [(byte)0x3B, (byte)0xF3]);
        // 100D:E0F8 cmp SI,BX
        Alu16.Sub(SI, BX);
        VerifySpeculativeEntryOrFail(cs1, 0xE0FA, [(byte)0x74, (byte)0x1B]);
        // 100D:E0FA je short 0xE117
        if (ZeroFlag)
        {
            goto label_100D_E117_1E1E7_38736;
        }
    label_100D_E0FC_1E1CC_38731:
        CheckExternalEvents(cs1, 0xE0FC);
        VerifySpeculativeEntryOrFail(cs1, 0xE0FC, [(byte)0xFF, (byte)0x56, (byte)0x00]);
        // 100D:E0FC call near word ptr SS:[BP]
        throw FailAsUntested("Indirect call at 100D:E0FC has no observed targets.");
    label_100D_E117_1E1E7_38736:
        CheckExternalEvents(cs1, 0xE117);
        VerifySpeculativeEntryOrFail(cs1, 0xE117, [(byte)0x83, (byte)0xC7, (byte)0x06]);
        // 100D:E117 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        VerifySpeculativeEntryOrFail(cs1, 0xE11A, [(byte)0xEB, (byte)0xC9]);
        // 100D:E11A jmp short 0xE0E5
        goto label_100D_E0E5_1E1B5_38722;
    }

    public virtual Action unknown_100D_E11C_1E1EC(int loadOffset)
    {
    label_100D_E11C_1E1EC_38745:
        CheckExternalEvents(cs1, 0xE11C);
        // 100D:E11C test byte ptr DS:[0x46EB],1
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x01);
        // 100D:E121 je short 0xE0DA
        if (ZeroFlag)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E123_1E1F3_38750:
        CheckExternalEvents(cs1, 0xE123);
        VerifySpeculativeEntryOrFail(cs1, 0xE123, [(byte)0x83, (byte)0x3E, (byte)0x49, (byte)0x47, (byte)0x00]);
        // 100D:E123 cmp word ptr DS:[0x4749],0
        Alu16.Sub(UInt16[DS, (ushort)0x4749], unchecked((ushort)unchecked((short)(sbyte)0)));
        VerifySpeculativeEntryOrFail(cs1, 0xE128, [(byte)0x74, (byte)0xB0]);
        // 100D:E128 je short 0xE0DA
        if (ZeroFlag)
        {
            return unknown_100D_E0DA_1E1AA(0x0000);
        }
    label_100D_E12A_1E1FA_38754:
        CheckExternalEvents(cs1, 0xE12A);
        VerifySpeculativeEntryOrFail(cs1, 0xE12A, [(byte)0xBF, (byte)0x62, (byte)0x24]);
        // 100D:E12A mov DI,0x2462
        DI = (ushort)0x2462;
        VerifySpeculativeEntryOrFail(cs1, 0xE12D, [(byte)0xB9, (byte)0x08, (byte)0x00]);
        // 100D:E12D mov CX,8
        CX = (ushort)0x0008;
    label_100D_E130_1E200_38757:
        CheckExternalEvents(cs1, 0xE130);
        VerifySpeculativeEntryOrFail(cs1, 0xE130, [(byte)0x8B, (byte)0x05]);
        // 100D:E130 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        VerifySpeculativeEntryOrFail(cs1, 0xE132, [(byte)0x8B, (byte)0x75, (byte)0x02]);
        // 100D:E132 mov SI,word ptr DS:[DI+2]
        SI = UInt16[DS, (ushort)(DI + (sbyte)2)];
        VerifySpeculativeEntryOrFail(cs1, 0xE135, [(byte)0x3B, (byte)0xC2]);
        // 100D:E135 cmp AX,DX
        Alu16.Sub(AX, DX);
        VerifySpeculativeEntryOrFail(cs1, 0xE137, [(byte)0x75, (byte)0x04]);
        // 100D:E137 jne short 0xE13D
        if (!ZeroFlag)
        {
            goto label_100D_E13D_1E20D_38761;
        }
    label_100D_E139_1E209_38763:
        CheckExternalEvents(cs1, 0xE139);
        VerifySpeculativeEntryOrFail(cs1, 0xE139, [(byte)0x3B, (byte)0xF3]);
        // 100D:E139 cmp SI,BX
        Alu16.Sub(SI, BX);
        VerifySpeculativeEntryOrFail(cs1, 0xE13B, [(byte)0x74, (byte)0x16]);
        // 100D:E13B je short 0xE153
        if (ZeroFlag)
        {
            goto label_100D_E153_1E223_38766;
        }
    label_100D_E13D_1E20D_38761:
        CheckExternalEvents(cs1, 0xE13D);
        VerifySpeculativeEntryOrFail(cs1, 0xE13D, [(byte)0xFF, (byte)0x56, (byte)0x00]);
        // 100D:E13D call near word ptr SS:[BP]
        throw FailAsUntested("Indirect call at 100D:E13D has no observed targets.");
    label_100D_E153_1E223_38766:
        CheckExternalEvents(cs1, 0xE153);
        VerifySpeculativeEntryOrFail(cs1, 0xE153, [(byte)0x83, (byte)0xC7, (byte)0x04]);
        // 100D:E153 add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        VerifySpeculativeEntryOrFail(cs1, 0xE156, [(byte)0xE2, (byte)0xD8]);
        // 100D:E156 loop 0xE130
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E130_1E200_38757;
        }
    label_100D_E158_1E228_38772:
        CheckExternalEvents(cs1, 0xE158);
        VerifySpeculativeEntryOrFail(cs1, 0xE158, [(byte)0xC3]);
        // 100D:E158 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E159_1E229(int loadOffset)
    {
    label_100D_E159_1E229_38586:
        CheckExternalEvents(cs1, 0xE159);
        // 100D:E159 mov SI,word ptr DS:[DI+6]
        SI = UInt16[DS, (ushort)(DI + (sbyte)6)];
        // 100D:E15C mov AX,SI
        AX = SI;
        // 100D:E15E sub AX,word ptr DS:[DI+2]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:E161 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:E163 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:E165 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 100D:E167 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:E169 add AX,word ptr DS:[DI+4]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:E16C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:E16E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E16F_1E23F(int loadOffset)
    {
    label_100D_E16F_1E23F_38796:
        CheckExternalEvents(cs1, 0xE16F);
        // 100D:E16F sub AX,DX
        AX = Alu16.Sub(AX, DX);
        return unknown_100D_E171_1E241(0x0000);
    }

    public virtual Action unknown_100D_E18C_1E25C(int loadOffset)
    {
    label_100D_E18C_1E25C_38610:
        CheckExternalEvents(cs1, 0xE18C);
        // 100D:E18C sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:E18E neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:E190 jmp short 0xE171
        return unknown_100D_E171_1E241(0x0000);
    }

    public virtual Action unknown_100D_E192_1E262(int loadOffset)
    {
    label_100D_E192_1E262_39016:
        CheckExternalEvents(cs1, 0xE192);
        // 100D:E192 xchg SI,AX
        ushort temp_100D_E192_1E262 = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_E192_1E262);
        // 100D:E193 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:E195 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:E197 sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 100D:E199 jmp short 0xE173
        return unknown_100D_E171_1E241(0xE173);
    }

    public virtual Action unknown_100D_E19B_1E26B(int loadOffset)
    {
    label_100D_E19B_1E26B_39029:
        CheckExternalEvents(cs1, 0xE19B);
        // 100D:E19B xchg SI,AX
        ushort temp_100D_E19B_1E26B = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_E19B_1E26B);
        // 100D:E19C sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:E19E sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 100D:E1A0 jmp short 0xE173
        return unknown_100D_E171_1E241(0xE173);
    }

    public virtual Action unknown_100D_E1CB_1E29B(int loadOffset)
    {
        goto label_100D_E1CB_1E29B_38803;

    label_100D_E1A8_1E278_38807:
        CheckExternalEvents(cs1, 0xE1A8);
        // 100D:E1A8 cmp AX,6
        Alu16.Sub(AX, (ushort)0x0006);
        // 100D:E1AB jl short 0xE186
        if (SignFlag != OverflowFlag)
        {
            return unknown_100D_E171_1E241(0xE186);
        }
    label_100D_E1AD_1E27D_38811:
        CheckExternalEvents(cs1, 0xE1AD);
        // 100D:E1AD cmp SI,6
        Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:E1B0 jl short 0xE186
        if (SignFlag != OverflowFlag)
        {
            return unknown_100D_E171_1E241(0xE186);
        }
    label_100D_E1B2_1E282_38815:
        CheckExternalEvents(cs1, 0xE1B2);
        // 100D:E1B2 sub AX,SI
        AX = Alu16.Sub(AX, SI);
        // 100D:E1B4 jns short 0xE1B8
        if (!SignFlag)
        {
            goto label_100D_E1B8_1E288_38818;
        }
    label_100D_E1B6_1E286_38820:
        CheckExternalEvents(cs1, 0xE1B6);
        VerifySpeculativeEntryOrFail(cs1, 0xE1B6, [(byte)0xF7, (byte)0xD8]);
        // 100D:E1B6 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_E1B8_1E288_38818:
        CheckExternalEvents(cs1, 0xE1B8);
        // 100D:E1B8 ret near
        return NearRet((ushort)0x0000);
    label_100D_E1CB_1E29B_38803:
        CheckExternalEvents(cs1, 0xE1CB);
        // 100D:E1CB sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:E1CD sub SI,BX
        SI = Alu16.Sub(SI, BX);
        // 100D:E1CF jmp short 0xE1A8
        goto label_100D_E1A8_1E278_38807;
    }

    public virtual Action unknown_100D_E243_1E313(int loadOffset)
    {
    label_100D_E243_1E313_38504:
        CheckExternalEvents(cs1, 0xE243);
        VerifySpeculativeEntryOrFail(cs1, 0xE243, [(byte)0xF6, (byte)0xE9]);
        // 100D:E243 imul CL
        short result_100D_E243_1E313 = Alu8.Imul(unchecked((sbyte)AL), unchecked((sbyte)CL));
        AH = unchecked((byte)(result_100D_E243_1E313 >> 8));
        AL = unchecked((byte)result_100D_E243_1E313);
        VerifySpeculativeEntryOrFail(cs1, 0xE245, [(byte)0x0B, (byte)0xC0]);
        // 100D:E245 or AX,AX
        AX = Alu16.Or(AX, AX);
        VerifySpeculativeEntryOrFail(cs1, 0xE247, [(byte)0x78, (byte)0x11]);
        // 100D:E247 js short 0xE25A
        if (SignFlag)
        {
            goto label_100D_E25A_1E32A_38513;
        }
    label_100D_E249_1E319_38515:
        CheckExternalEvents(cs1, 0xE249);
        VerifySpeculativeEntryOrFail(cs1, 0xE249, [(byte)0x02, (byte)0x04]);
        // 100D:E249 add AL,byte ptr DS:[SI]
        AL = Alu8.Add(AL, UInt8[DS, SI]);
        VerifySpeculativeEntryOrFail(cs1, 0xE24B, [(byte)0x8A, (byte)0xE8]);
        // 100D:E24B mov CH,AL
        CH = AL;
        VerifySpeculativeEntryOrFail(cs1, 0xE24D, [(byte)0x80, (byte)0xE5, (byte)0x07]);
        // 100D:E24D and CH,7
        CH = Alu8.And(CH, (byte)0x07);
        VerifySpeculativeEntryOrFail(cs1, 0xE250, [(byte)0x88, (byte)0x2C]);
        // 100D:E250 mov byte ptr DS:[SI],CH
        UInt8[DS, SI] = CH;
        VerifySpeculativeEntryOrFail(cs1, 0xE252, [(byte)0x98]);
        // 100D:E252 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        VerifySpeculativeEntryOrFail(cs1, 0xE253, [(byte)0xD1, (byte)0xE8]);
        // 100D:E253 shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE255, [(byte)0xD1, (byte)0xE8]);
        // 100D:E255 shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE257, [(byte)0xD1, (byte)0xE8]);
        // 100D:E257 shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE259, [(byte)0xC3]);
        // 100D:E259 ret near
        return NearRet((ushort)0x0000);
    label_100D_E25A_1E32A_38513:
        CheckExternalEvents(cs1, 0xE25A);
        VerifySpeculativeEntryOrFail(cs1, 0xE25A, [(byte)0xF7, (byte)0xD8]);
        // 100D:E25A neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        VerifySpeculativeEntryOrFail(cs1, 0xE25C, [(byte)0x02, (byte)0x04]);
        // 100D:E25C add AL,byte ptr DS:[SI]
        AL = Alu8.Add(AL, UInt8[DS, SI]);
        VerifySpeculativeEntryOrFail(cs1, 0xE25E, [(byte)0x8A, (byte)0xE8]);
        // 100D:E25E mov CH,AL
        CH = AL;
        VerifySpeculativeEntryOrFail(cs1, 0xE260, [(byte)0x80, (byte)0xE5, (byte)0x07]);
        // 100D:E260 and CH,7
        CH = Alu8.And(CH, (byte)0x07);
        VerifySpeculativeEntryOrFail(cs1, 0xE263, [(byte)0x88, (byte)0x2C]);
        // 100D:E263 mov byte ptr DS:[SI],CH
        UInt8[DS, SI] = CH;
        VerifySpeculativeEntryOrFail(cs1, 0xE265, [(byte)0x98]);
        // 100D:E265 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        VerifySpeculativeEntryOrFail(cs1, 0xE266, [(byte)0xD1, (byte)0xE8]);
        // 100D:E266 shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE268, [(byte)0xD1, (byte)0xE8]);
        // 100D:E268 shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE26A, [(byte)0xD1, (byte)0xE8]);
        // 100D:E26A shr AX,1
        AX = Alu16.Shr(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xE26C, [(byte)0xF7, (byte)0xD8]);
        // 100D:E26C neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        VerifySpeculativeEntryOrFail(cs1, 0xE26E, [(byte)0xC3]);
        // 100D:E26E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E26F_1E33F(int loadOffset)
    {
    label_100D_E26F_1E33F_15316:
        CheckExternalEvents(cs1, 0xE26F);
        // 100D:E26F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E270_1E340(int loadOffset)
    {
    label_100D_E270_1E340_3528:
        CheckExternalEvents(cs1, 0xE270);
        // 100D:E270 push BX
        Stack.Push16(BX);
        // 100D:E271 push CX
        Stack.Push16(CX);
        // 100D:E272 push DX
        Stack.Push16(DX);
        // 100D:E273 push SI
        Stack.Push16(SI);
        // 100D:E274 push DI
        Stack.Push16(DI);
        // 100D:E275 push BP
        Stack.Push16(BP);
        // 100D:E276 mov BP,SP
        BP = SP;
        // 100D:E278 xchg AX,word ptr SS:[BP+0x0C]
        ushort xchgOffset_100D_E278_1E348 = unchecked((ushort)(BP + (sbyte)12));
        ushort temp_100D_E278_1E348 = AX;
        AX = UInt16[SS, xchgOffset_100D_E278_1E348];
        UInt16[SS, xchgOffset_100D_E278_1E348] = unchecked((ushort)temp_100D_E278_1E348);
        // 100D:E27B push AX
        Stack.Push16(AX);
        // 100D:E27C mov AX,word ptr SS:[BP+0x0C]
        AX = UInt16[SS, (ushort)(BP + (sbyte)12)];
        // 100D:E27F mov BP,word ptr SS:[BP]
        BP = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:E282 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E283_1E353(int loadOffset)
    {
    label_100D_E283_1E353_3557:
        CheckExternalEvents(cs1, 0xE283);
        // 100D:E283 pop AX
        AX = Stack.Pop16();
        // 100D:E284 mov BP,SP
        BP = SP;
        // 100D:E286 xchg AX,word ptr SS:[BP+0x0C]
        ushort xchgOffset_100D_E286_1E356 = unchecked((ushort)(BP + (sbyte)12));
        ushort temp_100D_E286_1E356 = AX;
        AX = UInt16[SS, xchgOffset_100D_E286_1E356];
        UInt16[SS, xchgOffset_100D_E286_1E356] = unchecked((ushort)temp_100D_E286_1E356);
        // 100D:E289 pop BP
        BP = Stack.Pop16();
        // 100D:E28A pop DI
        DI = Stack.Pop16();
        // 100D:E28B pop SI
        SI = Stack.Pop16();
        // 100D:E28C pop DX
        DX = Stack.Pop16();
        // 100D:E28D pop CX
        CX = Stack.Pop16();
        // 100D:E28E pop BX
        BX = Stack.Pop16();
        // 100D:E28F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E290_1E360(int loadOffset)
    {
    label_100D_E290_1E360_13397:
        CheckExternalEvents(cs1, 0xE290);
        // 100D:E290 call near 0xD04E
        NearCall(cs1, 0xE293, unknown_100D_D04E_1D11E);
    label_100D_E293_1E363_13399:
        CheckExternalEvents(cs1, 0xE293);
        // 100D:E293 jmp short 0xE297
        return unknown_100D_E297_1E367(0x0000);
    }

    public virtual Action unknown_100D_E295_1E365(int loadOffset)
    {
    label_100D_E295_1E365_35612:
        CheckExternalEvents(cs1, 0xE295);
        // 100D:E295 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        return unknown_100D_E297_1E367(0x0000);
    }

    public virtual Action unknown_100D_E2DB_1E3AB(int loadOffset)
    {
    label_100D_E2DB_1E3AB_19082:
        CheckExternalEvents(cs1, 0xE2DB);
        // 100D:E2DB push AX
        Stack.Push16(AX);
        // 100D:E2DC call near 0xCF70
        NearCall(cs1, 0xE2DF, unknown_100D_CF70_1D040);
    label_100D_E2DF_1E3AF_19085:
        CheckExternalEvents(cs1, 0xE2DF);
        // 100D:E2DF call near 0xD03C
        NearCall(cs1, 0xE2E2, unknown_100D_D03C_1D10C);
    label_100D_E2E2_1E3B2_19087:
        CheckExternalEvents(cs1, 0xE2E2);
        // 100D:E2E2 pop AX
        AX = Stack.Pop16();
        return unknown_100D_E2E3_1E3B3(0x0000);
    }

    public virtual Action unknown_100D_E2E3_1E3B3(int loadOffset)
    {
    label_100D_E2E3_1E3B3_18437:
        CheckExternalEvents(cs1, 0xE2E3);
        // 100D:E2E3 push BX
        Stack.Push16(BX);
        // 100D:E2E4 push CX
        Stack.Push16(CX);
        // 100D:E2E5 mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:E2E8 mov BX,CX
        BX = CX;
        // 100D:E2EA cmp AX,0x03E8
        Alu16.Sub(AX, (ushort)0x03E8);
        // 100D:E2ED jb short 0xE2F2
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E2ED");
        }
    label_100D_E2F2_1E3C2_18444:
        CheckExternalEvents(cs1, 0xE2F2);
        // 100D:E2F2 div CL
        byte divisor_100D_E2F2_1E3C2 = CL;
        ushort dividend_100D_E2F2_1E3C2 = AX;
        byte quotient_100D_E2F2_1E3C2 = Alu8.Div(unchecked((ushort)dividend_100D_E2F2_1E3C2), unchecked((byte)divisor_100D_E2F2_1E3C2));
        AL = unchecked((byte)quotient_100D_E2F2_1E3C2);
        AH = unchecked((byte)(dividend_100D_E2F2_1E3C2 % unchecked((ushort)divisor_100D_E2F2_1E3C2)));
        // 100D:E2F4 add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        return unknown_100D_E2F6_1E3C6(0x0000);
    }

    public virtual Action unknown_100D_E31C_1E3EC(int loadOffset)
    {
    label_100D_E31C_1E3EC_18994:
        CheckExternalEvents(cs1, 0xE31C);
        // 100D:E31C push BX
        Stack.Push16(BX);
        // 100D:E31D push CX
        Stack.Push16(CX);
        // 100D:E31E mov CX,0x03E8
        CX = (ushort)0x03E8;
        // 100D:E321 mov BX,CX
        BX = CX;
        // 100D:E323 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E325 div CX
        ushort divisor_100D_E325_1E3F5 = CX;
        uint dividend_100D_E325_1E3F5 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_E325_1E3F5 = Alu16.Div(unchecked((uint)dividend_100D_E325_1E3F5), unchecked((ushort)divisor_100D_E325_1E3F5));
        AX = unchecked((ushort)quotient_100D_E325_1E3F5);
        DX = unchecked((ushort)(dividend_100D_E325_1E3F5 % unchecked((uint)divisor_100D_E325_1E3F5)));
        // 100D:E327 aam
        byte v2_100D_E327_1E3F7 = (byte)0x0A;
        byte v1_100D_E327_1E3F7 = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_E327_1E3F7 >> (byte)0x01)));
        if (v2_100D_E327_1E3F7 == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_E327_1E3F7 = unchecked((byte)(v1_100D_E327_1E3F7 % v2_100D_E327_1E3F7));
        AH = unchecked((byte)(v1_100D_E327_1E3F7 / v2_100D_E327_1E3F7));
        AL = unchecked((byte)result_100D_E327_1E3F7);
        Alu8.UpdateFlags(unchecked((byte)result_100D_E327_1E3F7));
        // 100D:E329 xchg AL,AH
        byte temp_100D_E329_1E3F9 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_E329_1E3F9);
        // 100D:E32B add AX,0x3030
        AX = Alu16.Add(AX, (ushort)0x3030);
        // 100D:E32E cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:E330 jne short 0xE33D
        if (!ZeroFlag)
        {
            goto label_100D_E33D_1E40D_19013;
        }
    label_100D_E332_1E402_19006:
        CheckExternalEvents(cs1, 0xE332);
        // 100D:E332 mov AL,0x20
        AL = (byte)0x20;
        // 100D:E334 cmp AH,0x30
        Alu8.Sub(AH, (byte)0x30);
        // 100D:E337 jne short 0xE33D
        if (!ZeroFlag)
        {
            goto label_100D_E33D_1E40D_19013;
        }
    label_100D_E339_1E409_19010:
        CheckExternalEvents(cs1, 0xE339);
        // 100D:E339 mov AH,AL
        AH = AL;
        // 100D:E33B xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_E33D_1E40D_19013:
        CheckExternalEvents(cs1, 0xE33D);
        // 100D:E33D mov word ptr ES:[SI-5],AX
        UInt16[ES, (ushort)(SI + (sbyte)-5)] = AX;
        // 100D:E341 mov AX,DX
        AX = DX;
        // 100D:E343 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E345 mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:E348 div CL
        byte divisor_100D_E348_1E418 = CL;
        ushort dividend_100D_E348_1E418 = AX;
        byte quotient_100D_E348_1E418 = Alu8.Div(unchecked((ushort)dividend_100D_E348_1E418), unchecked((byte)divisor_100D_E348_1E418));
        AL = unchecked((byte)quotient_100D_E348_1E418);
        AH = unchecked((byte)(dividend_100D_E348_1E418 % unchecked((ushort)divisor_100D_E348_1E418)));
        // 100D:E34A add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        // 100D:E34C or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:E34E jne short 0xE2FE
        if (!ZeroFlag)
        {
            return unknown_100D_E2F6_1E3C6(0xE2FE);
        }
    label_100D_E350_1E420_19021:
        CheckExternalEvents(cs1, 0xE350);
        // 100D:E350 inc BX
        BX = Alu16.Inc(BX);
        // 100D:E351 jmp short 0xE2F6
        return unknown_100D_E2F6_1E3C6(0x0000);
    }

    public virtual Action unknown_100D_E353_1E423(int loadOffset)
    {
    label_100D_E353_1E423_21711:
        CheckExternalEvents(cs1, 0xE353);
        // 100D:E353 push AX
        Stack.Push16(AX);
        // 100D:E354 push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
        // 100D:E358 call near BP
        switch ((ushort)(BP))
        {
            case 0x0A44:
                NearCall(cs1, 0xE35A, unknown_100D_0A44_10B14);
                break;
            case 0x1556:
                NearCall(cs1, 0xE35A, unknown_100D_1556_11626);
                break;
            case 0x26AC:
                NearCall(cs1, 0xE35A, unknown_100D_26AC_1277C);
                break;
            case 0x27B6:
                NearCall(cs1, 0xE35A, unknown_100D_27B6_12886);
                break;
            case 0x391D:
                NearCall(cs1, 0xE35A, unknown_100D_391D_139ED);
                break;
            case 0x4821:
                NearCall(cs1, 0xE35A, unknown_100D_4821_148F1);
                break;
            case 0x99F6:
                NearCall(cs1, 0xE35A, unknown_100D_99F6_19AC6);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:E358");
        }
    label_100D_E35A_1E42A_21758:
        CheckExternalEvents(cs1, 0xE35A);
        // 100D:E35A pop BX
        BX = Stack.Pop16();
        // 100D:E35B pop BP
        BP = Stack.Pop16();
    label_100D_E35C_1E42C_21761:
        CheckExternalEvents(cs1, 0xE35C);
        // 100D:E35C cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:E361 je short 0xE378
        if (ZeroFlag)
        {
            goto label_100D_E378_1E448_21763;
        }
    label_100D_E363_1E433_37612:
        CheckExternalEvents(cs1, 0xE363);
        // 100D:E363 push BX
        Stack.Push16(BX);
        // 100D:E364 push CX
        Stack.Push16(CX);
        // 100D:E365 push DX
        Stack.Push16(DX);
        // 100D:E366 push SI
        Stack.Push16(SI);
        // 100D:E367 push DI
        Stack.Push16(DI);
        // 100D:E368 push BP
        Stack.Push16(BP);
        // 100D:E369 push ES
        Stack.Push16(ES);
        // 100D:E36A call near 0xDD63
        NearCall(cs1, 0xE36D, unknown_100D_DD63_1DE33);
    label_100D_E36D_1E43D_37629:
        CheckExternalEvents(cs1, 0xE36D);
        // 100D:E36D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:E36E pop BP
        BP = Stack.Pop16();
        // 100D:E36F pop DI
        DI = Stack.Pop16();
        // 100D:E370 pop SI
        SI = Stack.Pop16();
        // 100D:E371 pop DX
        DX = Stack.Pop16();
        // 100D:E372 pop CX
        CX = Stack.Pop16();
        // 100D:E373 pop BX
        BX = Stack.Pop16();
        // 100D:E374 jb short 0xE386
        if (CarryFlag)
        {
            goto label_100D_E386_1E456_21773;
        }
    label_100D_E376_1E446_37640:
        CheckExternalEvents(cs1, 0xE376);
        // 100D:E376 jmp short 0xE37B
        goto label_100D_E37B_1E44B_21765;
    label_100D_E378_1E448_21763:
        CheckExternalEvents(cs1, 0xE378);
        // 100D:E378 call near 0xDE7B
        NearCall(cs1, 0xE37B, unknown_100D_DE7B_1DF4B);
    label_100D_E37B_1E44B_21765:
        CheckExternalEvents(cs1, 0xE37B);
        // 100D:E37B mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:E37E sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:E380 cmp AX,BP
        Alu16.Sub(AX, BP);
        // 100D:E382 jb short 0xE35C
        if (CarryFlag)
        {
            goto label_100D_E35C_1E42C_21761;
        }
    label_100D_E384_1E454_21771:
        CheckExternalEvents(cs1, 0xE384);
        // 100D:E384 or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
    label_100D_E386_1E456_21773:
        CheckExternalEvents(cs1, 0xE386);
        // 100D:E386 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E387_1E457(int loadOffset)
    {
    label_100D_E387_1E457_9731:
        CheckExternalEvents(cs1, 0xE387);
        // 100D:E387 push AX
        Stack.Push16(AX);
        // 100D:E388 push CX
        Stack.Push16(CX);
        // 100D:E389 mov CX,AX
        CX = AX;
        // 100D:E38B jcxz short 0xE39D
        if (CX == (ushort)0x0000)
        {
            goto label_100D_E39D_1E46D_9748;
        }
    label_100D_E38D_1E45D_9736:
        CheckExternalEvents(cs1, 0xE38D);
        // 100D:E38D pushf
        Stack.Push16(FlagRegister16);
        // 100D:E38E sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_E38F_1E45F_9739:
        CheckExternalEvents(cs1, 0xE38F);
        // 100D:E38F mov AX,word ptr SS:[0xCE7A]
        AX = UInt16[SS, (ushort)0xCE7A];
    label_100D_E393_1E463_9741:
        CheckExternalEvents(cs1, 0xE393);
        // 100D:E393 cmp AX,word ptr SS:[0xCE7A]
        Alu16.Sub(AX, UInt16[SS, (ushort)0xCE7A]);
        // 100D:E398 je short 0xE393
        if (ZeroFlag)
        {
            goto label_100D_E393_1E463_9741;
        }
    label_100D_E39A_1E46A_9744:
        CheckExternalEvents(cs1, 0xE39A);
        // 100D:E39A loop 0xE38F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E38F_1E45F_9739;
        }
    label_100D_E39C_1E46C_9746:
        CheckExternalEvents(cs1, 0xE39C);
        // 100D:E39C popf
        FlagRegister16 = Stack.Pop16();
    label_100D_E39D_1E46D_9748:
        CheckExternalEvents(cs1, 0xE39D);
        // 100D:E39D pop CX
        CX = Stack.Pop16();
        // 100D:E39E pop AX
        AX = Stack.Pop16();
        // 100D:E39F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E3A0_1E470(int loadOffset)
    {
    label_100D_E3A0_1E470_21421:
        CheckExternalEvents(cs1, 0xE3A0);
        // 100D:E3A0 mov CX,AX
        CX = AX;
    label_100D_E3A2_1E472_21423:
        CheckExternalEvents(cs1, 0xE3A2);
        // 100D:E3A2 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
    label_100D_E3A5_1E475_21424:
        CheckExternalEvents(cs1, 0xE3A5);
        // 100D:E3A5 cmp AX,word ptr DS:[0xCE7A]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE7A]);
        // 100D:E3A9 je short 0xE3A5
        if (ZeroFlag)
        {
            goto label_100D_E3A5_1E475_21424;
        }
    label_100D_E3AB_1E47B_21427:
        CheckExternalEvents(cs1, 0xE3AB);
        // 100D:E3AB call near 0xE270
        NearCall(cs1, 0xE3AE, unknown_100D_E270_1E340);
    label_100D_E3AE_1E47E_21429:
        CheckExternalEvents(cs1, 0xE3AE);
        // 100D:E3AE call near 0xD9D2
        NearCall(cs1, 0xE3B1, unknown_100D_D9D2_1DAA2);
    label_100D_E3B1_1E481_21431:
        CheckExternalEvents(cs1, 0xE3B1);
        // 100D:E3B1 call near 0xE283
        NearCall(cs1, 0xE3B4, unknown_100D_E283_1E353);
    label_100D_E3B4_1E484_21433:
        CheckExternalEvents(cs1, 0xE3B4);
        // 100D:E3B4 loop 0xE3A2
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E3A2_1E472_21423;
        }
    label_100D_E3B6_1E486_21436:
        CheckExternalEvents(cs1, 0xE3B6);
        // 100D:E3B6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E3B7_1E487(int loadOffset)
    {
    label_100D_E3B7_1E487_7947:
        CheckExternalEvents(cs1, 0xE3B7);
        // 100D:E3B7 push DX
        Stack.Push16(DX);
        // 100D:E3B8 mov AX,word ptr DS:[0xD824]
        AX = UInt16[DS, (ushort)0xD824];
        // 100D:E3BB mov DX,0xE56D
        DX = (ushort)0xE56D;
        // 100D:E3BE mul DX
        uint result_100D_E3BE_1E48E = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_E3BE_1E48E >> 16));
        AX = unchecked((ushort)result_100D_E3BE_1E48E);
        // 100D:E3C0 inc AX
        AX = Alu16.Inc(AX);
        // 100D:E3C1 mov word ptr DS:[0xD824],AX
        UInt16[DS, (ushort)0xD824] = AX;
        // 100D:E3C4 mov AL,AH
        AL = AH;
        // 100D:E3C6 mov AH,DL
        AH = DL;
        // 100D:E3C8 and AX,BX
        AX = Alu16.And(AX, BX);
        // 100D:E3CA pop DX
        DX = Stack.Pop16();
        // 100D:E3CB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E3CC_1E49C(int loadOffset)
    {
    label_100D_E3CC_1E49C_4755:
        CheckExternalEvents(cs1, 0xE3CC);
        // 100D:E3CC push DX
        Stack.Push16(DX);
        // 100D:E3CD mov AX,word ptr DS:[0xD826]
        AX = UInt16[DS, (ushort)0xD826];
        // 100D:E3D0 mov DX,0xCBD1
        DX = (ushort)0xCBD1;
        // 100D:E3D3 mul DX
        uint result_100D_E3D3_1E4A3 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_E3D3_1E4A3 >> 16));
        AX = unchecked((ushort)result_100D_E3D3_1E4A3);
        // 100D:E3D5 inc AX
        AX = Alu16.Inc(AX);
        // 100D:E3D6 mov word ptr DS:[0xD826],AX
        UInt16[DS, (ushort)0xD826] = AX;
        // 100D:E3D9 mov AL,AH
        AL = AH;
        // 100D:E3DB mov AH,DL
        AH = DL;
        // 100D:E3DD pop DX
        DX = Stack.Pop16();
        // 100D:E3DE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E3DF_1E4AF(int loadOffset)
    {
    label_100D_E3DF_1E4AF_23692:
        CheckExternalEvents(cs1, 0xE3DF);
        // 100D:E3DF push CX
        Stack.Push16(CX);
        // 100D:E3E0 push DX
        Stack.Push16(DX);
        // 100D:E3E1 mov AX,BX
        AX = BX;
        // 100D:E3E3 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:E3E5 je short 0xE408
        if (ZeroFlag)
        {
            goto label_100D_E408_1E4D8_23716;
        }
    label_100D_E3E7_1E4B7_23698:
        CheckExternalEvents(cs1, 0xE3E7);
        // 100D:E3E7 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
    label_100D_E3EA_1E4BA_23700:
        CheckExternalEvents(cs1, 0xE3EA);
        // 100D:E3EA shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:E3EC shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:E3EE jne short 0xE3EA
        if (!ZeroFlag)
        {
            goto label_100D_E3EA_1E4BA_23700;
        }
    label_100D_E3F0_1E4C0_23704:
        CheckExternalEvents(cs1, 0xE3F0);
        // 100D:E3F0 not CX
        CX = unchecked((ushort)~CX);
    label_100D_E3F2_1E4C2_23706:
        CheckExternalEvents(cs1, 0xE3F2);
        // 100D:E3F2 mov AX,word ptr DS:[0xD828]
        AX = UInt16[DS, (ushort)0xD828];
        // 100D:E3F5 mov DX,0xCBD1
        DX = (ushort)0xCBD1;
        // 100D:E3F8 mul DX
        uint result_100D_E3F8_1E4C8 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_E3F8_1E4C8 >> 16));
        AX = unchecked((ushort)result_100D_E3F8_1E4C8);
        // 100D:E3FA inc AX
        AX = Alu16.Inc(AX);
        // 100D:E3FB mov word ptr DS:[0xD828],AX
        UInt16[DS, (ushort)0xD828] = AX;
        // 100D:E3FE mov AL,AH
        AL = AH;
        // 100D:E400 mov AH,DL
        AH = DL;
        // 100D:E402 and AX,CX
        AX = Alu16.And(AX, CX);
        // 100D:E404 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:E406 ja short 0xE3F2
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_E3F2_1E4C2_23706;
        }
    label_100D_E408_1E4D8_23716:
        CheckExternalEvents(cs1, 0xE408);
        // 100D:E408 pop DX
        DX = Stack.Pop16();
        // 100D:E409 pop CX
        CX = Stack.Pop16();
        // 100D:E40A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E4AD_1E57D(int loadOffset)
    {
    label_100D_E4AD_1E57D_3:
        CheckExternalEvents(cs1, 0xE4AD);
        // 100D:E4AD mov SI,0x0080
        SI = (ushort)0x0080;
        // 100D:E4B0 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:E4B1 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:E4B3 mov BP,AX
        BP = AX;
        // 100D:E4B5 add BP,SI
        BP = Alu16.Add(BP, SI);
    label_100D_E4B7_1E587_9:
        CheckExternalEvents(cs1, 0xE4B7);
        // 100D:E4B7 push CS
        Stack.Push16(CS);
        // 100D:E4B8 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_E4B9_1E589_11:
        CheckExternalEvents(cs1, 0xE4B9);
        // 100D:E4B9 call near 0xE56B
        NearCall(cs1, 0xE4BC, unknown_100D_E56B_1E63B);
    label_100D_E4BC_1E58C_23:
        CheckExternalEvents(cs1, 0xE4BC);
        // 100D:E4BC jb short 0xE4E5
        if (CarryFlag)
        {
            goto label_100D_E4E5_1E5B5_118;
        }
    label_100D_E4BE_1E58E_25:
        CheckExternalEvents(cs1, 0xE4BE);
        // 100D:E4BE je short 0xE4B9
        if (ZeroFlag)
        {
            goto label_100D_E4B9_1E589_11;
        }
    label_100D_E4C0_1E590_28:
        CheckExternalEvents(cs1, 0xE4C0);
        // 100D:E4C0 mov DL,AL
        DL = AL;
        // 100D:E4C2 call near 0xE56B
        NearCall(cs1, 0xE4C5, unknown_100D_E56B_1E63B);
    label_100D_E4C5_1E595_31:
        CheckExternalEvents(cs1, 0xE4C5);
        // 100D:E4C5 jbe short 0xE542
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_E542_1E612_107;
        }
    label_100D_E4C7_1E597_33:
        CheckExternalEvents(cs1, 0xE4C7);
        // 100D:E4C7 mov AH,AL
        AH = AL;
        // 100D:E4C9 call near 0xE56B
        NearCall(cs1, 0xE4CC, unknown_100D_E56B_1E63B);
    label_100D_E4CC_1E59C_36:
        CheckExternalEvents(cs1, 0xE4CC);
        // 100D:E4CC jbe short 0xE542
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_E542_1E612_107;
        }
    label_100D_E4CE_1E59E_38:
        CheckExternalEvents(cs1, 0xE4CE);
        // 100D:E4CE xchg AL,DL
        byte temp_100D_E4CE_1E59E = AL;
        AL = DL;
        DL = unchecked((byte)temp_100D_E4CE_1E59E);
        // 100D:E4D0 mov DI,0xE40C
        DI = (ushort)0xE40C;
        // 100D:E4D3 mov CX,0x0017
        CX = (ushort)0x0017;
    label_100D_E4D6_1E5A6_42:
        CheckExternalEvents(cs1, 0xE4D6);
        // 100D:E4D6 scas AX,word ptr ES:[DI]
        Alu16.Sub(AX, UInt16[ES, DI]);
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E4D7 jne short 0xE4DE
        if (!ZeroFlag)
        {
            goto label_100D_E4DE_1E5AE_44;
        }
    label_100D_E4D9_1E5A9_48:
        CheckExternalEvents(cs1, 0xE4D9);
        // 100D:E4D9 cmp DL,byte ptr ES:[DI]
        Alu8.Sub(DL, UInt8[ES, DI]);
        // 100D:E4DC je short 0xE4E6
        if (ZeroFlag)
        {
            goto label_100D_E4E6_1E5B6_51;
        }
    label_100D_E4DE_1E5AE_44:
        CheckExternalEvents(cs1, 0xE4DE);
        // 100D:E4DE add DI,5
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:E4E1 loop 0xE4D6
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E4D6_1E5A6_42;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E4E1");
        }
    label_100D_E4E5_1E5B5_118:
        CheckExternalEvents(cs1, 0xE4E5);
        // 100D:E4E5 ret near
        return NearRet((ushort)0x0000);
    label_100D_E4E6_1E5B6_51:
        CheckExternalEvents(cs1, 0xE4E6);
        // 100D:E4E6 mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:E4E9 mov ES,AX
        ES = AX;
        // 100D:E4EB mov BL,byte ptr CS:[DI+1]
        BL = UInt8[CS, (ushort)(DI + (sbyte)1)];
        // 100D:E4EF xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:E4F1 add BX,0x2942
        BX = Alu16.Add(BX, (ushort)0x2942);
        // 100D:E4F5 mov AL,byte ptr CS:[DI+2]
        AL = UInt8[CS, (ushort)(DI + (sbyte)2)];
        // 100D:E4F9 or byte ptr ES:[BX],AL
        UInt8[ES, BX] = Alu8.Or(UInt8[ES, BX], AL);
        // 100D:E4FC mov BX,word ptr CS:[DI+3]
        BX = UInt16[CS, (ushort)(DI + (sbyte)3)];
        // 100D:E500 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:E502 je short 0xE542
        if (ZeroFlag)
        {
            goto label_100D_E542_1E612_107;
        }
    label_100D_E504_1E5D4_62:
        CheckExternalEvents(cs1, 0xE504);
        // 100D:E504 call near 0xE56B
        NearCall(cs1, 0xE507, unknown_100D_E56B_1E63B);
    label_100D_E507_1E5D7_74:
        CheckExternalEvents(cs1, 0xE507);
        // 100D:E507 jb short 0xE4E5
        if (CarryFlag)
        {
            goto label_100D_E4E5_1E5B5_118;
        }
    label_100D_E509_1E5D9_76:
        CheckExternalEvents(cs1, 0xE509);
        // 100D:E509 je short 0xE542
        if (ZeroFlag)
        {
            goto label_100D_E542_1E612_107;
        }
    label_100D_E50B_1E5DB_78:
        CheckExternalEvents(cs1, 0xE50B);
        // 100D:E50B dec SI
        SI = Alu16.Dec(SI);
        // 100D:E50C cmp BX,0x3826
        Alu16.Sub(BX, (ushort)0x3826);
        // 100D:E510 je short 0xE54D
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E510");
        }
    label_100D_E512_1E5E2_82:
        CheckExternalEvents(cs1, 0xE512);
        // 100D:E512 xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_100D_E514_1E5E4_84:
        CheckExternalEvents(cs1, 0xE514);
        // 100D:E514 call near 0xE56B
        NearCall(cs1, 0xE517, unknown_100D_E56B_1E63B);
    label_100D_E517_1E5E7_85:
        CheckExternalEvents(cs1, 0xE517);
        // 100D:E517 mov AH,AL
        AH = AL;
        // 100D:E519 jbe short 0xE537
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_E537_1E607_102;
        }
    label_100D_E51B_1E5EB_88:
        CheckExternalEvents(cs1, 0xE51B);
        // 100D:E51B sub AL,0x30
        AL = Alu8.Sub(AL, (byte)0x30);
        // 100D:E51D jb short 0xE537
        if (CarryFlag)
        {
            goto label_100D_E537_1E607_102;
        }
    label_100D_E51F_1E5EF_91:
        CheckExternalEvents(cs1, 0xE51F);
        // 100D:E51F cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:E521 jbe short 0xE52B
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E521");
        }
    label_100D_E52B_1E5FB_94:
        CheckExternalEvents(cs1, 0xE52B);
        // 100D:E52B shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:E52D shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:E52F shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:E531 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:E533 or DL,AL
        DL = Alu8.Or(DL, AL);
        // 100D:E535 jmp short 0xE514
        goto label_100D_E514_1E5E4_84;
    label_100D_E537_1E607_102:
        CheckExternalEvents(cs1, 0xE537);
        // 100D:E537 mov word ptr ES:[BX],DX
        UInt16[ES, BX] = DX;
        // 100D:E53A add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:E53D cmp AH,0x20
        Alu8.Sub(AH, (byte)0x20);
        // 100D:E540 ja short 0xE512
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_E512_1E5E2_82;
        }
    label_100D_E542_1E612_107:
        CheckExternalEvents(cs1, 0xE542);
        // 100D:E542 dec SI
        SI = Alu16.Dec(SI);
    label_100D_E543_1E613_109:
        CheckExternalEvents(cs1, 0xE543);
        // 100D:E543 call near 0xE56B
        NearCall(cs1, 0xE546, unknown_100D_E56B_1E63B);
    label_100D_E546_1E616_110:
        CheckExternalEvents(cs1, 0xE546);
        // 100D:E546 jb short 0xE4E5
        if (CarryFlag)
        {
            goto label_100D_E4E5_1E5B5_118;
        }
    label_100D_E548_1E618_112:
        CheckExternalEvents(cs1, 0xE548);
        // 100D:E548 jne short 0xE543
        if (!ZeroFlag)
        {
            goto label_100D_E543_1E613_109;
        }
    label_100D_E54A_1E61A_114:
        CheckExternalEvents(cs1, 0xE54A);
        // 100D:E54A jmp near 0xE4B7
        goto label_100D_E4B7_1E587_9;
    }

    public virtual Action unknown_100D_E56B_1E63B(int loadOffset)
    {
    label_100D_E56B_1E63B_12:
        CheckExternalEvents(cs1, 0xE56B);
        // 100D:E56B mov AL,0x0D
        AL = (byte)0x0D;
        // 100D:E56D cmp SI,BP
        Alu16.Sub(SI, BP);
        // 100D:E56F jae short 0xE578
        if (!CarryFlag)
        {
            goto label_100D_E578_1E648_20;
        }
    label_100D_E571_1E641_16:
        CheckExternalEvents(cs1, 0xE571);
        // 100D:E571 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:E572 cmp AL,0x61
        Alu8.Sub(AL, (byte)0x61);
        // 100D:E574 jb short 0xE578
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E574");
        }
    label_100D_E578_1E648_20:
        CheckExternalEvents(cs1, 0xE578);
        // 100D:E578 cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:E57A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E57B_1E64B(int loadOffset)
    {
    label_100D_E57B_1E64B_497:
        CheckExternalEvents(cs1, 0xE57B);
        // 100D:E57B push CX
        Stack.Push16(CX);
        // 100D:E57C push SI
        Stack.Push16(SI);
        // 100D:E57D add AX,0x00C8
        AX = Alu16.Add(AX, (ushort)0x00C8);
        // 100D:E580 mov SI,AX
        SI = AX;
        // 100D:E582 call near 0xF0B9
        NearCall(cs1, 0xE585, unknown_100D_F0B9_1F189);
    label_100D_E585_1E655_713:
        CheckExternalEvents(cs1, 0xE585);
        // 100D:E585 pop SI
        SI = Stack.Pop16();
        // 100D:E586 pop CX
        CX = Stack.Pop16();
        // 100D:E587 mov AX,ES
        AX = ES;
        // 100D:E589 sub AX,0x0010
        AX = Alu16.Sub(AX, (ushort)0x0010);
    label_100D_E58C_1E65C_718:
        CheckExternalEvents(cs1, 0xE58C);
        // 100D:E58C mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:E58E add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:E591 loop 0xE58C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E58C_1E65C_718;
        }
    label_100D_E593_1E663_722:
        CheckExternalEvents(cs1, 0xE593);
        // 100D:E593 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E594_1E664(int loadOffset)
    {
    label_100D_E594_1E664_122:
        CheckExternalEvents(cs1, 0xE594);
        // 100D:E594 mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:E597 mov ES,AX
        ES = AX;
        // 100D:E599 mov CX,0xDD1D
        CX = (ushort)0xDD1D;
        // 100D:E59C mov DI,0x3CBC
        DI = (ushort)0x3CBC;
        // 100D:E59F sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:E5A1 cld
        DirectionFlag = false;
        // 100D:E5A2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E5A4 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:E5A6 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:E5A9 push ES
        Stack.Push16(ES);
        // 100D:E5AA pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:E5AB mov word ptr DS:[0xCE68],AX
        UInt16[DS, (ushort)0xCE68] = AX;
        // 100D:E5AE mov CX,0xDD1D
        CX = (ushort)0xDD1D;
        // 100D:E5B1 call near 0xF0FF
        NearCall(cs1, 0xE5B4, unknown_100D_F0FF_1F1CF);
    label_100D_E5B4_1E684_152:
        CheckExternalEvents(cs1, 0xE5B4);
        // 100D:E5B4 mov AX,0x4C6F
        AX = (ushort)0x4C6F;
        // 100D:E5B7 mov CL,4
        CL = (byte)0x04;
        // 100D:E5B9 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:E5BB mov CX,DS
        CX = DS;
        // 100D:E5BD add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:E5BF mov word ptr DS:[0xDC32],AX
        UInt16[DS, (ushort)0xDC32] = AX;
        // 100D:E5C2 mov AH,0x19
        AH = (byte)0x19;
        // 100D:E5C4 int 0x21
        InterruptCall(cs1, 0xE5C6, unchecked((byte)((byte)0x21)));
    label_100D_E5C6_1E696_174:
        CheckExternalEvents(cs1, 0xE5C6);
        // 100D:E5C6 mov byte ptr DS:[0xCE76],AL
        UInt8[DS, (ushort)0xCE76] = AL;
        // 100D:E5C9 mov byte ptr DS:[0xCE77],AL
        UInt8[DS, (ushort)0xCE77] = AL;
        // 100D:E5CC mov AX,0x3301
        AX = (ushort)0x3301;
        // 100D:E5CF int 0x21
        InterruptCall(cs1, 0xE5D1, unchecked((byte)((byte)0x21)));
    label_100D_E5D1_1E6A1_179:
        CheckExternalEvents(cs1, 0xE5D1);
        // 100D:E5D1 mov byte ptr DS:[0x2941],DL
        UInt8[DS, (ushort)0x2941] = DL;
        // 100D:E5D5 mov AX,0x3301
        AX = (ushort)0x3301;
        // 100D:E5D8 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E5DA int 0x21
        InterruptCall(cs1, 0xE5DC, unchecked((byte)((byte)0x21)));
    label_100D_E5DC_1E6AC_184:
        CheckExternalEvents(cs1, 0xE5DC);
        // 100D:E5DC call near 0xE675
        NearCall(cs1, 0xE5DF, unknown_100D_E675_1E745);
    label_100D_E5DF_1E6AF_491:
        CheckExternalEvents(cs1, 0xE5DF);
        // 100D:E5DF mov AL,byte ptr DS:[0x2942]
        AL = UInt8[DS, (ushort)0x2942];
        // 100D:E5E2 and AX,1
        AX = Alu16.And(AX, (ushort)0x0001);
        // 100D:E5E5 mov SI,0x38B7
        SI = (ushort)0x38B7;
        // 100D:E5E8 mov CX,0x002E
        CX = (ushort)0x002E;
        // 100D:E5EB call near 0xE57B
        NearCall(cs1, 0xE5EE, unknown_100D_E57B_1E64B);
    label_100D_E5EE_1E6BE_724:
        CheckExternalEvents(cs1, 0xE5EE);
        // 100D:E5EE call far dword ptr DS:[0x38B9]
        ushort targetSegment_724 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38B9 + (ushort)0x0002)]));
        ushort targetOffset_724 = unchecked((ushort)(UInt16[DS, (ushort)0x38B9]));
        if (targetSegment_724 == cs2 && targetOffset_724 == 0x0103)
        {
            FarCall(cs1, 0xE5F2, cs2, unknown_3358_0103_33683);
            goto label_100D_E5F2_1E6C2_733;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_724:X4}:{targetOffset_724:X4} at 100D:E5EE");
    label_100D_E5F2_1E6C2_733:
        CheckExternalEvents(cs1, 0xE5F2);
        // 100D:E5F2 mov word ptr DS:[0xDBD8],AX
        UInt16[DS, (ushort)0xDBD8] = AX;
        // 100D:E5F5 call near 0xC08E
        NearCall(cs1, 0xE5F8, unknown_100D_C08E_1C15E);
    label_100D_E5F8_1E6C8_740:
        CheckExternalEvents(cs1, 0xE5F8);
        // 100D:E5F8 mov word ptr DS:[0xCE74],CX
        UInt16[DS, (ushort)0xCE74] = CX;
        // 100D:E5FC mov DI,0xDBDC
        DI = (ushort)0xDBDC;
        // 100D:E5FF call near 0xF0F6
        NearCall(cs1, 0xE602, unknown_100D_F0F6_1F1C6);
    label_100D_E602_1E6D2_748:
        CheckExternalEvents(cs1, 0xE602);
        // 100D:E602 mov word ptr DS:[0xDBD6],BP
        UInt16[DS, (ushort)0xDBD6] = BP;
        // 100D:E606 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:E608 jne short 0xE610
        if (!ZeroFlag)
        {
            goto label_100D_E610_1E6E0_755;
        }
    label_100D_E60A_1E6DA_752:
        CheckExternalEvents(cs1, 0xE60A);
        // 100D:E60A mov DI,0xDBD4
        DI = (ushort)0xDBD4;
        // 100D:E60D call near 0xF0F6
        NearCall(cs1, 0xE610, unknown_100D_F0F6_1F1C6);
    label_100D_E610_1E6E0_755:
        CheckExternalEvents(cs1, 0xE610);
        // 100D:E610 call far dword ptr DS:[0x38B5]
        ushort targetSegment_755 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38B5 + (ushort)0x0002)]));
        ushort targetOffset_755 = unchecked((ushort)(UInt16[DS, (ushort)0x38B5]));
        if (targetSegment_755 == cs2 && targetOffset_755 == 0x0100)
        {
            FarCall(cs1, 0xE614, cs2, unknown_3358_0100_33680);
            goto label_100D_E614_1E6E4_774;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_755:X4}:{targetOffset_755:X4} at 100D:E610");
    label_100D_E614_1E6E4_774:
        CheckExternalEvents(cs1, 0xE614);
        // 100D:E614 mov AL,byte ptr DS:[0x2942]
        AL = UInt8[DS, (ushort)0x2942];
        // 100D:E617 push AX
        Stack.Push16(AX);
        // 100D:E618 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:E61A shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:E61C and AL,7
        AL = Alu8.And(AL, (byte)0x07);
        // 100D:E61E mov byte ptr DS:[0xCEEB],AL
        UInt8[DS, (ushort)0xCEEB] = AL;
        // 100D:E621 pop AX
        AX = Stack.Pop16();
        // 100D:E622 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:E624 jns short 0xE62B
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E624");
        }
    label_100D_E62B_1E6FB_784:
        CheckExternalEvents(cs1, 0xE62B);
        // 100D:E62B test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:E62D jne short 0xE632
        if (!ZeroFlag)
        {
            goto label_100D_E632_1E702_859;
        }
    label_100D_E62F_1E6FF_787:
        CheckExternalEvents(cs1, 0xE62F);
        // 100D:E62F call near 0xE97A
        NearCall(cs1, 0xE632, unknown_100D_E97A_1EA4A);
    label_100D_E632_1E702_859:
        CheckExternalEvents(cs1, 0xE632);
        // 100D:E632 call near 0xE85C
        NearCall(cs1, 0xE635, unknown_100D_E85C_1E92C);
    label_100D_E635_1E705_991:
        CheckExternalEvents(cs1, 0xE635);
        // 100D:E635 call near 0xEA7B
        NearCall(cs1, 0xE638, unknown_100D_EA7B_1EB4B);
    label_100D_E638_1E708_1004:
        CheckExternalEvents(cs1, 0xE638);
        // 100D:E638 mov AL,byte ptr DS:[0x2942]
        AL = UInt8[DS, (ushort)0x2942];
        // 100D:E63B and AL,2
        AL = Alu8.And(AL, (byte)0x02);
        // 100D:E63D mov BP,0xCE7A
        BP = (ushort)0xCE7A;
        // 100D:E640 call far dword ptr DS:[0x3925]
        ushort targetSegment_1008 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3925 + (ushort)0x0002)]));
        ushort targetOffset_1008 = unchecked((ushort)(UInt16[DS, (ushort)0x3925]));
        if (targetSegment_1008 == cs2 && targetOffset_1008 == 0x0154)
        {
            FarCall(cs1, 0xE644, cs2, unknown_3358_0154_336D4);
            goto label_100D_E644_1E714_1176;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_1008:X4}:{targetOffset_1008:X4} at 100D:E640");
    label_100D_E644_1E714_1176:
        CheckExternalEvents(cs1, 0xE644);
        // 100D:E644 mov word ptr DS:[0xDC48],0x271C
        UInt16[DS, (ushort)0xDC48] = (ushort)0x271C;
        // 100D:E64A mov byte ptr DS:[0xDC46],0xFF
        UInt8[DS, (ushort)0xDC46] = (byte)0xFF;
        // 100D:E64F xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E651 mov BX,0x00C7
        BX = (ushort)0x00C7;
        // 100D:E654 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:E656 mov DX,0x013F
        DX = (ushort)0x013F;
        // 100D:E659 call near 0xDB14
        NearCall(cs1, 0xE65C, unknown_100D_DB14_1DBE4);
    label_100D_E65C_1E72C_1216:
        CheckExternalEvents(cs1, 0xE65C);
        // 100D:E65C mov BX,0x00AB
        BX = (ushort)0x00AB;
        // 100D:E65F mov DX,0x00ED
        DX = (ushort)0x00ED;
        // 100D:E662 call near 0xDB03
        NearCall(cs1, 0xE665, unknown_100D_DB03_1DBD3);
    label_100D_E665_1E735_1259:
        CheckExternalEvents(cs1, 0xE665);
        // 100D:E665 call near 0xE76A
        NearCall(cs1, 0xE668, unknown_100D_E76A_1E83A);
    label_100D_E668_1E738_2473:
        CheckExternalEvents(cs1, 0xE668);
        // 100D:E668 call near 0xCE6C
        NearCall(cs1, 0xE66B, unknown_100D_CE6C_1CF3C);
    label_100D_E66B_1E73B_2701:
        CheckExternalEvents(cs1, 0xE66B);
        // 100D:E66B call near 0xC07C
        NearCall(cs1, 0xE66E, unknown_100D_C07C_1C14C);
    label_100D_E66E_1E73E_2707:
        CheckExternalEvents(cs1, 0xE66E);
        // 100D:E66E call near 0xC0AD
        NearCall(cs1, 0xE671, unknown_100D_C0AD_1C17D);
    label_100D_E671_1E741_2728:
        CheckExternalEvents(cs1, 0xE671);
        // 100D:E671 jmp near 0xC412
        return unknown_100D_C412_1C4E2(0x0000);
    }

    public virtual Action unknown_100D_E675_1E745(int loadOffset)
    {
    label_100D_E675_1E745_186:
        CheckExternalEvents(cs1, 0xE675);
        // 100D:E675 mov DX,0x37F2
        DX = (ushort)0x37F2;
        // 100D:E678 call near 0xF1FB
        NearCall(cs1, 0xE67B, unknown_100D_F1FB_1F2CB);
    label_100D_E67B_1E74B_233:
        CheckExternalEvents(cs1, 0xE67B);
        // 100D:E67B jb short 0xE692
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E67B");
        }
    label_100D_E692_1E762_235:
        CheckExternalEvents(cs1, 0xE692);
        // 100D:E692 mov SI,0x37F7
        SI = (ushort)0x37F7;
        // 100D:E695 inc byte ptr DS:[SI]
        UInt8[DS, SI] = Alu8.Inc(UInt8[DS, SI]);
        // 100D:E697 cmp byte ptr DS:[SI],0x39
        Alu8.Sub(UInt8[DS, SI], (byte)0x39);
        // 100D:E69A jbe short 0xE675
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_E675_1E745_186;
        }
    label_100D_E69C_1E76C_240:
        CheckExternalEvents(cs1, 0xE69C);
        // 100D:E69C mov DX,0x37E9
        DX = (ushort)0x37E9;
        // 100D:E69F mov AX,0x3D00
        AX = (ushort)0x3D00;
        // 100D:E6A2 int 0x21
        InterruptCall(cs1, 0xE6A4, unchecked((byte)((byte)0x21)));
    label_100D_E6A4_1E774_244:
        CheckExternalEvents(cs1, 0xE6A4);
        // 100D:E6A4 jb short 0xE674
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E6A4");
        }
    label_100D_E6A6_1E776_246:
        CheckExternalEvents(cs1, 0xE6A6);
        // 100D:E6A6 mov word ptr DS:[0xDBBA],AX
        UInt16[DS, (ushort)0xDBBA] = AX;
        // 100D:E6A9 call near 0xE741
        NearCall(cs1, 0xE6AC, unknown_100D_E741_1E811);
    label_100D_E6AC_1E77C_286:
        CheckExternalEvents(cs1, 0xE6AC);
        // 100D:E6AC mov SI,DI
        SI = DI;
        // 100D:E6AE mov BP,ES
        BP = ES;
        // 100D:E6B0 les DI,word ptr DS:[0x39B7]
        ushort lxsOffset_100D_E6B0_1E780 = (ushort)0x39B7;
        ushort lxsValue_100D_E6B0_1E780 = UInt16[DS, lxsOffset_100D_E6B0_1E780];
        ushort lxsSegment_100D_E6B0_1E780 = UInt16[DS, (ushort)(lxsOffset_100D_E6B0_1E780 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_E6B0_1E780);
        ES = unchecked((ushort)lxsSegment_100D_E6B0_1E780);
        // 100D:E6B4 mov word ptr DS:[0xDBBC],DI
        UInt16[DS, (ushort)0xDBBC] = DI;
        // 100D:E6B8 mov word ptr DS:[0xDBBE],ES
        UInt16[DS, (ushort)0xDBBE] = ES;
        // 100D:E6BC mov AX,0x0145
        AX = (ushort)0x0145;
        // 100D:E6BF stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E6C0 mov CX,0x014D
        CX = (ushort)0x014D;
        // 100D:E6C3 mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:E6C5 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:E6C7 mov word ptr DS:[0xD820],DI
        UInt16[DS, (ushort)0xD820] = DI;
        // 100D:E6CB push DS
        Stack.Push16(DS);
        // 100D:E6CC mov DS,BP
        DS = BP;
        // 100D:E6CE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
    label_100D_E6CF_1E79F_301:
        CheckExternalEvents(cs1, 0xE6CF);
        // 100D:E6CF push SI
        Stack.Push16(SI);
        // 100D:E6D0 call near 0xF314
        NearCall(cs1, 0xE6D3, unknown_100D_F314_1F3E4);
    label_100D_E6D3_1E7A3_357:
        CheckExternalEvents(cs1, 0xE6D3);
        // 100D:E6D3 pop SI
        SI = Stack.Pop16();
        // 100D:E6D4 jb short 0xE702
        if (CarryFlag)
        {
            goto label_100D_E702_1E7D2_416;
        }
    label_100D_E6D6_1E7A6_360:
        CheckExternalEvents(cs1, 0xE6D6);
        // 100D:E6D6 call near 0xF3A7
        NearCall(cs1, 0xE6D9, unknown_100D_F3A7_1F477);
    label_100D_E6D9_1E7A9_380:
        CheckExternalEvents(cs1, 0xE6D9);
        // 100D:E6D9 je short 0xE6F9
        if (ZeroFlag)
        {
            goto label_100D_E6F9_1E7C9_400;
        }
    label_100D_E6DB_1E7AB_382:
        CheckExternalEvents(cs1, 0xE6DB);
        // 100D:E6DB push AX
        Stack.Push16(AX);
        // 100D:E6DC push DX
        Stack.Push16(DX);
        // 100D:E6DD push SI
        Stack.Push16(SI);
        // 100D:E6DE push DI
        Stack.Push16(DI);
        // 100D:E6DF mov CX,word ptr SS:[0xD820]
        CX = UInt16[SS, (ushort)0xD820];
        // 100D:E6E4 mov SI,CX
        SI = CX;
        // 100D:E6E6 sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:E6E8 sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:E6EB lea DI,SI+0x0A
        DI = unchecked((ushort)(SI + (sbyte)10));
        // 100D:E6EE shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:E6F0 std
        DirectionFlag = true;
        // 100D:E6F1 rep movs word ptr ES:[DI],word ptr ES:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[ES, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:E6F4 cld
        DirectionFlag = false;
        // 100D:E6F5 pop DI
        DI = Stack.Pop16();
        // 100D:E6F6 pop SI
        SI = Stack.Pop16();
        // 100D:E6F7 pop DX
        DX = Stack.Pop16();
        // 100D:E6F8 pop AX
        AX = Stack.Pop16();
    label_100D_E6F9_1E7C9_400:
        CheckExternalEvents(cs1, 0xE6F9);
        // 100D:E6F9 call near 0xE75B
        NearCall(cs1, 0xE6FC, unknown_100D_E75B_1E82B);
    label_100D_E6FC_1E7CC_414:
        CheckExternalEvents(cs1, 0xE6FC);
        // 100D:E6FC add word ptr SS:[0xD820],0x000A
        UInt16[SS, (ushort)0xD820] = Alu16.Add(UInt16[SS, (ushort)0xD820], unchecked((ushort)unchecked((short)(sbyte)10)));
    label_100D_E702_1E7D2_416:
        CheckExternalEvents(cs1, 0xE702);
        // 100D:E702 add SI,0x0019
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)25)));
        // 100D:E705 cmp byte ptr DS:[SI],0
        Alu8.Sub(UInt8[DS, SI], (byte)0x00);
        // 100D:E708 jne short 0xE6CF
        if (!ZeroFlag)
        {
            goto label_100D_E6CF_1E79F_301;
        }
    label_100D_E70A_1E7DA_465:
        CheckExternalEvents(cs1, 0xE70A);
        // 100D:E70A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:E70B mov SI,0x0145
        SI = (ushort)0x0145;
        // 100D:E70E mov AX,word ptr DS:[0xD820]
        AX = UInt16[DS, (ushort)0xD820];
        // 100D:E711 sub AX,SI
        AX = Alu16.Sub(AX, SI);
        // 100D:E713 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E715 mov CX,0x0280
        CX = (ushort)0x0280;
        // 100D:E718 div CX
        ushort divisor_100D_E718_1E7E8 = CX;
        uint dividend_100D_E718_1E7E8 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_E718_1E7E8 = Alu16.Div(unchecked((uint)dividend_100D_E718_1E7E8), unchecked((ushort)divisor_100D_E718_1E7E8));
        AX = unchecked((ushort)quotient_100D_E718_1E7E8);
        DX = unchecked((ushort)(dividend_100D_E718_1E7E8 % unchecked((uint)divisor_100D_E718_1E7E8)));
        // 100D:E71A mov DX,0x000A
        DX = (ushort)0x000A;
        // 100D:E71D mul DX
        uint result_100D_E71D_1E7ED = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_E71D_1E7ED >> 16));
        AX = unchecked((ushort)result_100D_E71D_1E7ED);
        // 100D:E71F mov DX,AX
        DX = AX;
        // 100D:E721 les DI,word ptr SS:[0xDBBC]
        ushort lxsOffset_100D_E721_1E7F1 = (ushort)0xDBBC;
        ushort lxsValue_100D_E721_1E7F1 = UInt16[SS, lxsOffset_100D_E721_1E7F1];
        ushort lxsSegment_100D_E721_1E7F1 = UInt16[SS, (ushort)(lxsOffset_100D_E721_1E7F1 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_E721_1E7F1);
        ES = unchecked((ushort)lxsSegment_100D_E721_1E7F1);
        // 100D:E726 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_E729_1E7F9_478:
        CheckExternalEvents(cs1, 0xE729);
        // 100D:E729 add SI,DX
        SI = Alu16.Add(SI, DX);
        // 100D:E72B push SI
        Stack.Push16(SI);
        // 100D:E72C movs word ptr ES:[DI],word ptr ES:[SI]
        UInt16[ES, DI] = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E72E movs byte ptr ES:[DI],byte ptr ES:[SI]
        UInt8[ES, DI] = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:E730 pop SI
        SI = Stack.Pop16();
        // 100D:E731 mov AX,SI
        AX = SI;
        // 100D:E733 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E734 cmp DI,0x0140
        Alu16.Sub(DI, (ushort)0x0140);
        // 100D:E738 jb short 0xE729
        if (CarryFlag)
        {
            goto label_100D_E729_1E7F9_478;
        }
    label_100D_E73A_1E80A_488:
        CheckExternalEvents(cs1, 0xE73A);
        // 100D:E73A mov CX,word ptr DS:[0xD820]
        CX = UInt16[DS, (ushort)0xD820];
        // 100D:E73E jmp near 0xF0FF
        return unknown_100D_F0FF_1F1CF(0x0000);
    }

    public virtual Action unknown_100D_E741_1E811(int loadOffset)
    {
    label_100D_E741_1E811_249:
        CheckExternalEvents(cs1, 0xE741);
        // 100D:E741 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E743 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E745 call near 0xF2D6
        NearCall(cs1, 0xE748, unknown_100D_F2D6_1F3A6);
    label_100D_E748_1E818_263:
        CheckExternalEvents(cs1, 0xE748);
        // 100D:E748 mov AX,word ptr DS:[0x39B9]
        AX = UInt16[DS, (ushort)0x39B9];
        // 100D:E74B add AX,0x0800
        AX = Alu16.Add(AX, (ushort)0x0800);
        // 100D:E74E mov ES,AX
        ES = AX;
        // 100D:E750 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:E752 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
        // 100D:E755 call near 0xF2EA
        NearCall(cs1, 0xE758, unknown_100D_F2EA_1F3BA);
    label_100D_E758_1E828_282:
        CheckExternalEvents(cs1, 0xE758);
        // 100D:E758 jb short 0xE741
        if (CarryFlag)
        {
            goto label_100D_E741_1E811_249;
        }
    label_100D_E75A_1E82A_284:
        CheckExternalEvents(cs1, 0xE75A);
        // 100D:E75A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E75B_1E82B(int loadOffset)
    {
    label_100D_E75B_1E82B_401:
        CheckExternalEvents(cs1, 0xE75B);
        // 100D:E75B push SI
        Stack.Push16(SI);
        // 100D:E75C stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E75D mov AL,DL
        AL = DL;
        // 100D:E75F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:E760 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:E763 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E764 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:E765 inc SI
        SI = Alu16.Inc(SI);
        // 100D:E766 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E767 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:E768 pop SI
        SI = Stack.Pop16();
        // 100D:E769 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E76A_1E83A(int loadOffset)
    {
    label_100D_E76A_1E83A_1261:
        CheckExternalEvents(cs1, 0xE76A);
        // 100D:E76A mov AL,byte ptr DS:[0x2944]
        AL = UInt8[DS, (ushort)0x2944];
        // 100D:E76D mov CL,4
        CL = (byte)0x04;
        // 100D:E76F shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 100D:E771 add AL,7
        AL = Alu8.Add(AL, (byte)0x07);
        // 100D:E773 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:E775 mov SI,0x398B
        SI = (ushort)0x398B;
        // 100D:E778 mov CX,8
        CX = (ushort)0x0008;
        // 100D:E77B call near 0xE57B
        NearCall(cs1, 0xE77E, unknown_100D_E57B_1E64B);
    label_100D_E77E_1E84E_1270:
        CheckExternalEvents(cs1, 0xE77E);
        // 100D:E77E mov AX,word ptr DS:[0x39B5]
        AX = UInt16[DS, (ushort)0x39B5];
        // 100D:E781 call far dword ptr DS:[0x3989]
        ushort targetSegment_1272 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3989 + (ushort)0x0002)]));
        ushort targetOffset_1272 = unchecked((ushort)(UInt16[DS, (ushort)0x3989]));
        if (targetSegment_1272 == cs3 && targetOffset_1272 == 0x0100)
        {
            FarCall(cs1, 0xE785, cs3, unknown_5642_0100_56520);
            goto label_100D_E785_1E855_1721;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_1272:X4}:{targetOffset_1272:X4} at 100D:E781");
    label_100D_E785_1E855_1721:
        CheckExternalEvents(cs1, 0xE785);
        // 100D:E785 mov word ptr DS:[0xDBC8],BX
        UInt16[DS, (ushort)0xDBC8] = BX;
        // 100D:E789 call near 0xA637
        NearCall(cs1, 0xE78C, unknown_100D_A637_1A707);
    label_100D_E78C_1E85C_1787:
        CheckExternalEvents(cs1, 0xE78C);
        // 100D:E78C call near 0xAE54
        NearCall(cs1, 0xE78F, unknown_100D_AE54_1AF24);
    label_100D_E78F_1E85F_1806:
        CheckExternalEvents(cs1, 0xE78F);
        // 100D:E78F call near 0xE851
        NearCall(cs1, 0xE792, unknown_100D_E851_1E921);
    label_100D_E792_1E862_1813:
        CheckExternalEvents(cs1, 0xE792);
        // 100D:E792 jb short 0xE7BC
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E792");
        }
    label_100D_E7BC_1E88C_1815:
        CheckExternalEvents(cs1, 0xE7BC);
        // 100D:E7BC mov AX,word ptr DS:[0x3813]
        AX = UInt16[DS, (ushort)0x3813];
        // 100D:E7BF mov word ptr DS:[0x381B],AX
        UInt16[DS, (ushort)0x381B] = AX;
        // 100D:E7C2 call near 0xA87E
        NearCall(cs1, 0xE7C5, unknown_100D_A87E_1A94E);
    label_100D_E7C5_1E895_2204:
        CheckExternalEvents(cs1, 0xE7C5);
        // 100D:E7C5 mov AL,byte ptr DS:[0x2944]
        AL = UInt8[DS, (ushort)0x2944];
        // 100D:E7C8 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:E7CB add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:E7CE mov SI,0x396F
        SI = (ushort)0x396F;
        // 100D:E7D1 mov CX,7
        CX = (ushort)0x0007;
        // 100D:E7D4 call near 0xE57B
        NearCall(cs1, 0xE7D7, unknown_100D_E57B_1E64B);
    label_100D_E7D7_1E8A7_2211:
        CheckExternalEvents(cs1, 0xE7D7);
        // 100D:E7D7 mov BP,0x3349
        BP = (ushort)0x3349;
        // 100D:E7DA mov CX,0x000A
        CX = (ushort)0x000A;
        // 100D:E7DD mov AX,word ptr DS:[0x39B3]
        AX = UInt16[DS, (ushort)0x39B3];
        // 100D:E7E0 call far dword ptr DS:[0x396D]
        ushort targetSegment_2215 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x396D + (ushort)0x0002)]));
        ushort targetOffset_2215 = unchecked((ushort)(UInt16[DS, (ushort)0x396D]));
        if (targetSegment_2215 == cs4 && targetOffset_2215 == 0x0100)
        {
            FarCall(cs1, 0xE7E4, cs4, unknown_5BAE_0100_5BBE0);
            goto label_100D_E7E4_1E8B4_2354;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_2215:X4}:{targetOffset_2215:X4} at 100D:E7E0");
    label_100D_E7E4_1E8B4_2354:
        CheckExternalEvents(cs1, 0xE7E4);
        // 100D:E7E4 or word ptr DS:[0xDBC8],BX
        UInt16[DS, (ushort)0xDBC8] = Alu16.Or(UInt16[DS, (ushort)0xDBC8], BX);
        // 100D:E7E8 call near 0xA650
        NearCall(cs1, 0xE7EB, unknown_100D_A650_1A720);
    label_100D_E7EB_1E8BB_2411:
        CheckExternalEvents(cs1, 0xE7EB);
        // 100D:E7EB call near 0xAE3F
        NearCall(cs1, 0xE7EE, unknown_100D_AE3F_1AF0F);
    label_100D_E7EE_1E8BE_2428:
        CheckExternalEvents(cs1, 0xE7EE);
        // 100D:E7EE call near 0xE851
        NearCall(cs1, 0xE7F1, unknown_100D_E851_1E921);
    label_100D_E7F1_1E8C1_2430:
        CheckExternalEvents(cs1, 0xE7F1);
        // 100D:E7F1 jb short 0xE818
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E7F1");
        }
    label_100D_E818_1E8E8_2432:
        CheckExternalEvents(cs1, 0xE818);
        // 100D:E818 call near 0xAE28
        NearCall(cs1, 0xE81B, unknown_100D_AE28_1AEF8);
    label_100D_E81B_1E8EB_2434:
        CheckExternalEvents(cs1, 0xE81B);
        // 100D:E81B je short 0xE825
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E81B");
        }
    label_100D_E81D_1E8ED_2436:
        CheckExternalEvents(cs1, 0xE81D);
        // 100D:E81D call near 0xE826
        NearCall(cs1, 0xE820, unknown_100D_E826_1E8F6);
    label_100D_E820_1E8F0_2470:
        CheckExternalEvents(cs1, 0xE820);
        // 100D:E820 and byte ptr DS:[0x2943],0xEF
        UInt8[DS, (ushort)0x2943] = Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0xEF);
        // 100D:E825 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E826_1E8F6(int loadOffset)
    {
    label_100D_E826_1E8F6_2438:
        CheckExternalEvents(cs1, 0xE826);
        // 100D:E826 cmp word ptr DS:[0xDBBA],0
        Alu16.Sub(UInt16[DS, (ushort)0xDBBA], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:E82B je short 0xE850
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E82B");
        }
    label_100D_E82D_1E8FD_2441:
        CheckExternalEvents(cs1, 0xE82D);
        // 100D:E82D call near 0xE741
        NearCall(cs1, 0xE830, unknown_100D_E741_1E811);
    label_100D_E830_1E900_2443:
        CheckExternalEvents(cs1, 0xE830);
        // 100D:E830 push DS
        Stack.Push16(DS);
        // 100D:E831 mov SI,DI
        SI = DI;
        // 100D:E833 push ES
        Stack.Push16(ES);
        // 100D:E834 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:E835 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:E836 mov CX,0x00FA
        CX = (ushort)0x00FA;
    label_100D_E839_1E909_2450:
        CheckExternalEvents(cs1, 0xE839);
        // 100D:E839 push CX
        Stack.Push16(CX);
        // 100D:E83A push SI
        Stack.Push16(SI);
        // 100D:E83B call near 0xF314
        NearCall(cs1, 0xE83E, unknown_100D_F314_1F3E4);
    label_100D_E83E_1E90E_2453:
        CheckExternalEvents(cs1, 0xE83E);
        // 100D:E83E pop SI
        SI = Stack.Pop16();
        // 100D:E83F jb short 0xE849
        if (CarryFlag)
        {
            goto label_100D_E849_1E919_2462;
        }
    label_100D_E841_1E911_2456:
        CheckExternalEvents(cs1, 0xE841);
        // 100D:E841 call near 0xF3A7
        NearCall(cs1, 0xE844, unknown_100D_F3A7_1F477);
    label_100D_E844_1E914_2458:
        CheckExternalEvents(cs1, 0xE844);
        // 100D:E844 jne short 0xE849
        if (!ZeroFlag)
        {
            goto label_100D_E849_1E919_2462;
        }
    label_100D_E846_1E916_2460:
        CheckExternalEvents(cs1, 0xE846);
        // 100D:E846 call near 0xE75B
        NearCall(cs1, 0xE849, unknown_100D_E75B_1E82B);
    label_100D_E849_1E919_2462:
        CheckExternalEvents(cs1, 0xE849);
        // 100D:E849 add SI,0x0019
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)25)));
        // 100D:E84C pop CX
        CX = Stack.Pop16();
        // 100D:E84D loop 0xE839
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E839_1E909_2450;
        }
    label_100D_E84F_1E91F_2467:
        CheckExternalEvents(cs1, 0xE84F);
        // 100D:E84F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:E850 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E851_1E921(int loadOffset)
    {
    label_100D_E851_1E921_1808:
        CheckExternalEvents(cs1, 0xE851);
        // 100D:E851 mov AX,word ptr DS:[0x39B9]
        AX = UInt16[DS, (ushort)0x39B9];
        // 100D:E854 add AX,0x2F13
        AX = Alu16.Add(AX, (ushort)0x2F13);
        // 100D:E857 cmp AX,word ptr DS:[0xCE68]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE68]);
        // 100D:E85B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E85C_1E92C(int loadOffset)
    {
    label_100D_E85C_1E92C_861:
        CheckExternalEvents(cs1, 0xE85C);
        // 100D:E85C cli
        InterruptFlag = false;
        // 100D:E85D call near 0xE913
        NearCall(cs1, 0xE860, unknown_100D_E913_1E9E3);
    label_100D_E860_1E930_895:
        CheckExternalEvents(cs1, 0xE860);
        // 100D:E860 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E862 mov ES,AX
        ES = AX;
        // 100D:E864 mov DI,0x0020
        DI = (ushort)0x0020;
        // 100D:E867 mov word ptr ES:[DI],0xE8B8
        UInt16[ES, DI] = (ushort)0xE8B8;
        // 100D:E86C pushf
        Stack.Push16(FlagRegister16);
        // 100D:E86D sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_E86E_1E93E_902:
        CheckExternalEvents(cs1, 0xE86E);
        // 100D:E86E cmp byte ptr CS:[0xE8D4],0
        Alu8.Sub(UInt8[CS, (ushort)0xE8D4], (byte)0x00);
        // 100D:E874 je short 0xE86E
        if (ZeroFlag)
        {
            goto label_100D_E86E_1E93E_902;
        }
    label_100D_E876_1E946_950:
        CheckExternalEvents(cs1, 0xE876);
        // 100D:E876 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_E877_1E947_952:
        CheckExternalEvents(cs1, 0xE877);
        // 100D:E877 mov word ptr ES:[DI],0xEF6A
        UInt16[ES, DI] = (ushort)0xEF6A;
        // 100D:E87C mov AX,word ptr CS:[0xE8D2]
        AX = UInt16[CS, (ushort)0xE8D2];
        // 100D:E880 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:E882 je short 0xE8A5
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E882");
        }
    label_100D_E884_1E954_957:
        CheckExternalEvents(cs1, 0xE884);
        // 100D:E884 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:E886 je short 0xE8A5
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:E886");
        }
    label_100D_E888_1E958_960:
        CheckExternalEvents(cs1, 0xE888);
        // 100D:E888 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E88A mov CX,0x1745
        CX = (ushort)0x1745;
        // 100D:E88D div CX
        ushort divisor_100D_E88D_1E95D = CX;
        uint dividend_100D_E88D_1E95D = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_E88D_1E95D = Alu16.Div(unchecked((uint)dividend_100D_E88D_1E95D), unchecked((ushort)divisor_100D_E88D_1E95D));
        AX = unchecked((ushort)quotient_100D_E88D_1E95D);
        DX = unchecked((ushort)(dividend_100D_E88D_1E95D % unchecked((uint)divisor_100D_E88D_1E95D)));
        // 100D:E88F shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:E891 cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:E893 jb short 0xE896
        if (CarryFlag)
        {
            goto label_100D_E896_1E966_969;
        }
    label_100D_E895_1E965_967:
        CheckExternalEvents(cs1, 0xE895);
        // 100D:E895 inc AX
        AX = Alu16.Inc(AX);
    label_100D_E896_1E966_969:
        CheckExternalEvents(cs1, 0xE896);
        // 100D:E896 dec AX
        AX = Alu16.Dec(AX);
        // 100D:E897 jns short 0xE89A
        if (!SignFlag)
        {
            goto label_100D_E89A_1E96A_971;
        }
    label_100D_E899_1E969_34923:
        CheckExternalEvents(cs1, 0xE899);
        // 100D:E899 inc AX
        AX = Alu16.Inc(AX);
    label_100D_E89A_1E96A_971:
        CheckExternalEvents(cs1, 0xE89A);
        // 100D:E89A cmp AX,0x000A
        Alu16.Sub(AX, (ushort)0x000A);
        // 100D:E89D jb short 0xE8A1
        if (CarryFlag)
        {
            goto label_100D_E8A1_1E971_974;
        }
    label_100D_E89F_1E96F_34945:
        CheckExternalEvents(cs1, 0xE89F);
        // 100D:E89F mov AL,0x0A
        AL = (byte)0x0A;
    label_100D_E8A1_1E971_974:
        CheckExternalEvents(cs1, 0xE8A1);
        // 100D:E8A1 mov byte ptr CS:[0xEFD9],AL
        UInt8[CS, (ushort)0xEFD9] = AL;
        // 100D:E8A5 mov AX,0x1745
        AX = (ushort)0x1745;
        return unknown_100D_E8A8_1E978(0x0000);
    }

    public virtual Action unknown_100D_E8A8_1E978(int loadOffset)
    {
    label_100D_E8A8_1E978_977:
        CheckExternalEvents(cs1, 0xE8A8);
        // 100D:E8A8 pushf
        Stack.Push16(FlagRegister16);
        // 100D:E8A9 push AX
        Stack.Push16(AX);
    label_100D_E8AA_1E97A_979:
        CheckExternalEvents(cs1, 0xE8AA);
        // 100D:E8AA cli
        InterruptFlag = false;
        // 100D:E8AB mov AL,0x36
        AL = (byte)0x36;
        // 100D:E8AD out 0x43,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x43), AL);
        // 100D:E8AF pop AX
        AX = Stack.Pop16();
        // 100D:E8B0 out 0x40,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x40), AL);
        // 100D:E8B2 mov AL,AH
        AL = AH;
        // 100D:E8B4 out 0x40,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x40), AL);
    label_100D_E8B6_1E986_987:
        CheckExternalEvents(cs1, 0xE8B6);
        // 100D:E8B6 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_E8B7_1E987_989:
        CheckExternalEvents(cs1, 0xE8B7);
        // 100D:E8B7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E8B8_1E988(int loadOffset)
    {
    label_100D_E8B8_1E988_904:
        CheckExternalEvents(cs1, 0xE8B8);
        // 100D:E8B8 push AX
        Stack.Push16(AX);
        // 100D:E8B9 mov AL,0x36
        AL = (byte)0x36;
        // 100D:E8BB out 0x43,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x43), AL);
        // 100D:E8BD in AL,0x40
        AL = Machine.IoPortDispatcher.ReadByte(unchecked((ushort)(byte)0x40));
        // 100D:E8BF mov AH,AL
        AH = AL;
        // 100D:E8C1 in AL,0x40
        AL = Machine.IoPortDispatcher.ReadByte(unchecked((ushort)(byte)0x40));
        // 100D:E8C3 xchg AH,AL
        byte temp_100D_E8C3_1E993 = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_E8C3_1E993);
        // 100D:E8C5 mov word ptr CS:[0xE8D2],AX
        UInt16[CS, (ushort)0xE8D2] = AX;
        // 100D:E8C9 inc byte ptr CS:[0xE8D4]
        UInt8[CS, (ushort)0xE8D4] = Alu8.Inc(UInt8[CS, (ushort)0xE8D4]);
        // 100D:E8CE pop AX
        AX = Stack.Pop16();
        // 100D:E8CF jmp near 0xEF6A
        return unknown_100D_EF6A_1F03A(0x0000);
    }

    public virtual Action unknown_100D_E8D5_1E9A5(int loadOffset)
    {
    label_100D_E8D5_1E9A5_20111:
        CheckExternalEvents(cs1, 0xE8D5);
        // 100D:E8D5 cmp word ptr CS:[0xEE8A],0
        Alu16.Sub(UInt16[CS, (ushort)0xEE8A], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:E8DB je short 0xE8E2
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E8DB");
        }
    label_100D_E8E2_1E9B2_20114:
        CheckExternalEvents(cs1, 0xE8E2);
        // 100D:E8E2 cmp word ptr CS:[0xED3A],0
        Alu16.Sub(UInt16[CS, (ushort)0xED3A], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:E8E8 je short 0xE8EF
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E8E8");
        }
    label_100D_E8EF_1E9BF_20117:
        CheckExternalEvents(cs1, 0xE8EF);
        // 100D:E8EF mov DX,word ptr CS:[0xED3E]
        DX = UInt16[CS, (ushort)0xED3E];
        // 100D:E8F4 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:E8F6 je short 0xE8FD
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E8F6");
        }
    label_100D_E8FD_1E9CD_20121:
        CheckExternalEvents(cs1, 0xE8FD);
        // 100D:E8FD xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E8FF call near 0xE8A8
        NearCall(cs1, 0xE902, unknown_100D_E8A8_1E978);
    label_100D_E902_1E9D2_20125:
        CheckExternalEvents(cs1, 0xE902);
        // 100D:E902 mov DL,byte ptr DS:[0x2941]
        DL = UInt8[DS, (ushort)0x2941];
        // 100D:E906 mov AX,0x3301
        AX = (ushort)0x3301;
        // 100D:E909 int 0x21
        InterruptCall(cs1, 0xE90B, unchecked((byte)((byte)0x21)));
    label_100D_E90B_1E9DB_20129:
        CheckExternalEvents(cs1, 0xE90B);
        // 100D:E90B cmp byte ptr DS:[0xCE73],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE73], (byte)0x00);
        // 100D:E910 jne short 0xE913
        if (!ZeroFlag)
        {
            return unknown_100D_E913_1E9E3(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:E910");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_E913_1E9E3(int loadOffset)
    {
    label_100D_E913_1E9E3_864:
        CheckExternalEvents(cs1, 0xE913);
        // 100D:E913 xor byte ptr DS:[0xCE73],0xFF
        UInt8[DS, (ushort)0xCE73] = Alu8.Xor(UInt8[DS, (ushort)0xCE73], (byte)0xFF);
        // 100D:E918 mov SI,0x2913
        SI = (ushort)0x2913;
        // 100D:E91B pushf
        Stack.Push16(FlagRegister16);
    label_100D_E91C_1E9EC_868:
        CheckExternalEvents(cs1, 0xE91C);
        // 100D:E91C cli
        InterruptFlag = false;
        // 100D:E91D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
    label_100D_E91E_1E9EE_871:
        CheckExternalEvents(cs1, 0xE91E);
        // 100D:E91E mov DI,AX
        DI = AX;
        // 100D:E920 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:E921 xchg DI,AX
        ushort temp_100D_E921_1E9F1 = DI;
        DI = AX;
        AX = unchecked((ushort)temp_100D_E921_1E9F1);
        // 100D:E922 push SI
        Stack.Push16(SI);
        // 100D:E923 mov SI,AX
        SI = AX;
        // 100D:E925 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:E927 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:E929 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:E92B mov ES,AX
        ES = AX;
        // 100D:E92D mov AX,word ptr CS:[DI]
        AX = UInt16[CS, DI];
        // 100D:E930 xchg AX,word ptr ES:[SI]
        ushort xchgOffset_100D_E930_1EA00 = SI;
        ushort temp_100D_E930_1EA00 = AX;
        AX = UInt16[ES, xchgOffset_100D_E930_1EA00];
        UInt16[ES, xchgOffset_100D_E930_1EA00] = unchecked((ushort)temp_100D_E930_1EA00);
        // 100D:E933 mov word ptr CS:[DI],AX
        UInt16[CS, DI] = AX;
        // 100D:E936 mov AX,word ptr CS:[DI+2]
        AX = UInt16[CS, (ushort)(DI + (sbyte)2)];
        // 100D:E93A xchg AX,word ptr ES:[SI+2]
        ushort xchgOffset_100D_E93A_1EA0A = unchecked((ushort)(SI + (sbyte)2));
        ushort temp_100D_E93A_1EA0A = AX;
        AX = UInt16[ES, xchgOffset_100D_E93A_1EA0A];
        UInt16[ES, xchgOffset_100D_E93A_1EA0A] = unchecked((ushort)temp_100D_E93A_1EA0A);
        // 100D:E93E mov word ptr CS:[DI+2],AX
        UInt16[CS, (ushort)(DI + (sbyte)2)] = AX;
        // 100D:E942 pop SI
        SI = Stack.Pop16();
        // 100D:E943 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:E944 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:E946 jns short 0xE91E
        if (!SignFlag)
        {
            goto label_100D_E91E_1E9EE_871;
        }
    label_100D_E948_1EA18_891:
        CheckExternalEvents(cs1, 0xE948);
        // 100D:E948 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_E949_1EA19_893:
        CheckExternalEvents(cs1, 0xE949);
        // 100D:E949 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E97A_1EA4A(int loadOffset)
    {
    label_100D_E97A_1EA4A_789:
        CheckExternalEvents(cs1, 0xE97A);
        // 100D:E97A mov AX,0x3533
        AX = (ushort)0x3533;
        // 100D:E97D int 0x21
        InterruptCall(cs1, 0xE97F, unchecked((byte)((byte)0x21)));
    label_100D_E97F_1EA4F_792:
        CheckExternalEvents(cs1, 0xE97F);
        // 100D:E97F mov AX,ES
        AX = ES;
        // 100D:E981 or AX,BX
        AX = Alu16.Or(AX, BX);
        // 100D:E983 je short 0xE9F3
        if (ZeroFlag)
        {
            goto label_100D_E9F3_1EAC3_857;
        }
    label_100D_E985_1EA55_796:
        CheckExternalEvents(cs1, 0xE985);
        // 100D:E985 mov AX,0
        AX = (ushort)0x0000;
        // 100D:E988 int 0x33
        InterruptCall(cs1, 0xE98A, unchecked((byte)((byte)0x33)));
    label_100D_E98A_1EA5A_803:
        CheckExternalEvents(cs1, 0xE98A);
        // 100D:E98A inc AX
        AX = Alu16.Inc(AX);
        // 100D:E98B jne short 0xE9F3
        if (!ZeroFlag)
        {
            goto label_100D_E9F3_1EAC3_857;
        }
    label_100D_E98D_1EA5D_806:
        CheckExternalEvents(cs1, 0xE98D);
        // 100D:E98D xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:E98F xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:E991 mov AX,4
        AX = (ushort)0x0004;
        // 100D:E994 int 0x33
        InterruptCall(cs1, 0xE996, unchecked((byte)((byte)0x33)));
    label_100D_E996_1EA66_811:
        CheckExternalEvents(cs1, 0xE996);
        // 100D:E996 inc byte ptr DS:[0x2580]
        UInt8[DS, (ushort)0x2580] = Alu8.Inc(UInt8[DS, (ushort)0x2580]);
        // 100D:E99A js short 0xE9B3
        if (SignFlag)
        {
            goto label_100D_E9B3_1EA83_826;
        }
    label_100D_E99C_1EA6C_814:
        CheckExternalEvents(cs1, 0xE99C);
        // 100D:E99C mov CL,byte ptr DS:[0x2580]
        CL = UInt8[DS, (ushort)0x2580];
        // 100D:E9A0 mov AX,1
        AX = (ushort)0x0001;
        // 100D:E9A3 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:E9A5 mov CX,AX
        CX = AX;
        // 100D:E9A7 mov AX,4
        AX = (ushort)0x0004;
        // 100D:E9AA int 0x33
        InterruptCall(cs1, 0xE9AC, unchecked((byte)((byte)0x33)));
    label_100D_E9AC_1EA7C_821:
        CheckExternalEvents(cs1, 0xE9AC);
        // 100D:E9AC mov AX,3
        AX = (ushort)0x0003;
        // 100D:E9AF int 0x33
        InterruptCall(cs1, 0xE9B1, unchecked((byte)((byte)0x33)));
    label_100D_E9B1_1EA81_824:
        CheckExternalEvents(cs1, 0xE9B1);
        // 100D:E9B1 jcxz short 0xE996
        if (CX == (ushort)0x0000)
        {
            goto label_100D_E996_1EA66_811;
        }
    label_100D_E9B3_1EA83_826:
        CheckExternalEvents(cs1, 0xE9B3);
        // 100D:E9B3 inc byte ptr DS:[0x2581]
        UInt8[DS, (ushort)0x2581] = Alu8.Inc(UInt8[DS, (ushort)0x2581]);
        // 100D:E9B7 js short 0xE9D0
        if (SignFlag)
        {
            goto label_100D_E9D0_1EAA0_841;
        }
    label_100D_E9B9_1EA89_829:
        CheckExternalEvents(cs1, 0xE9B9);
        // 100D:E9B9 mov CL,byte ptr DS:[0x2581]
        CL = UInt8[DS, (ushort)0x2581];
        // 100D:E9BD mov DX,1
        DX = (ushort)0x0001;
        // 100D:E9C0 shl DX,CL
        DX = Alu16.Shl(DX, unchecked((int)CL));
        // 100D:E9C2 mov AX,4
        AX = (ushort)0x0004;
        // 100D:E9C5 int 0x33
        InterruptCall(cs1, 0xE9C7, unchecked((byte)((byte)0x33)));
    label_100D_E9C7_1EA97_835:
        CheckExternalEvents(cs1, 0xE9C7);
        // 100D:E9C7 mov AX,3
        AX = (ushort)0x0003;
        // 100D:E9CA int 0x33
        InterruptCall(cs1, 0xE9CC, unchecked((byte)((byte)0x33)));
    label_100D_E9CC_1EA9C_838:
        CheckExternalEvents(cs1, 0xE9CC);
        // 100D:E9CC or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:E9CE je short 0xE9B3
        if (ZeroFlag)
        {
            goto label_100D_E9B3_1EA83_826;
        }
    label_100D_E9D0_1EAA0_841:
        CheckExternalEvents(cs1, 0xE9D0);
        // 100D:E9D0 mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:E9D3 mov DX,AX
        DX = AX;
        // 100D:E9D5 and word ptr DS:[0x2580],0x7F7F
        UInt16[DS, (ushort)0x2580] = Alu16.And(UInt16[DS, (ushort)0x2580], (ushort)0x7F7F);
        // 100D:E9DB mov CX,word ptr DS:[0x2580]
        CX = UInt16[DS, (ushort)0x2580];
        // 100D:E9DF shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:E9E1 mov CL,CH
        CL = CH;
        // 100D:E9E3 shr DX,CL
        DX = Alu16.Shr(DX, unchecked((int)CL));
        // 100D:E9E5 mov CX,AX
        CX = AX;
        // 100D:E9E7 mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:E9EA push DX
        Stack.Push16(DX);
        // 100D:E9EB int 0x33
        InterruptCall(cs1, 0xE9ED, unchecked((byte)((byte)0x33)));
    label_100D_E9ED_1EABD_853:
        CheckExternalEvents(cs1, 0xE9ED);
        // 100D:E9ED pop DX
        DX = Stack.Pop16();
        // 100D:E9EE mov AX,0x0013
        AX = (ushort)0x0013;
        // 100D:E9F1 int 0x33
        InterruptCall(cs1, 0xE9F3, unchecked((byte)((byte)0x33)));
    label_100D_E9F3_1EAC3_857:
        CheckExternalEvents(cs1, 0xE9F3);
        // 100D:E9F3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_EA7B_1EB4B(int loadOffset)
    {
    label_100D_EA7B_1EB4B_993:
        CheckExternalEvents(cs1, 0xEA7B);
        // 100D:EA7B test byte ptr DS:[0x2943],0x80
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x80);
        // 100D:EA80 je short 0xEA85
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:EA80");
        }
    label_100D_EA85_1EB55_996:
        CheckExternalEvents(cs1, 0xEA85);
        // 100D:EA85 test byte ptr DS:[0x2943],0x48
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x48);
        // 100D:EA8A je short 0xEA8F
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:EA8A");
        }
    label_100D_EA8F_1EB5F_999:
        CheckExternalEvents(cs1, 0xEA8F);
        // 100D:EA8F test byte ptr DS:[0x2943],0xE8
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0xE8);
        // 100D:EA94 je short 0xEAB6
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:EA94");
        }
    label_100D_EAB6_1EB86_1002:
        CheckExternalEvents(cs1, 0xEAB6);
        // 100D:EAB6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_EF6A_1F03A(int loadOffset)
    {
    label_100D_EF6A_1F03A_916:
        CheckExternalEvents(cs1, 0xEF6A);
        // 100D:EF6A push AX
        Stack.Push16(AX);
        // 100D:EF6B push DS
        Stack.Push16(DS);
        // 100D:EF6C push ES
        Stack.Push16(ES);
        // 100D:EF6D mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:EF70 mov DS,AX
        DS = AX;
        // 100D:EF72 cld
        DirectionFlag = false;
        // 100D:EF73 cmp byte ptr DS:[0xCEEA],0
        Alu8.Sub(UInt8[DS, (ushort)0xCEEA], (byte)0x00);
        // 100D:EF78 jg short 0xEFA2
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_EFA2_1F072_940;
        }
    label_100D_EF7A_1F04A_925:
        CheckExternalEvents(cs1, 0xEF7A);
        // 100D:EF7A inc word ptr DS:[0xCE7A]
        UInt16[DS, (ushort)0xCE7A] = Alu16.Inc(UInt16[DS, (ushort)0xCE7A]);
        // 100D:EF7E jne short 0xEF84
        if (!ZeroFlag)
        {
            goto label_100D_EF84_1F054_928;
        }
    label_100D_EF80_1F050_10011:
        CheckExternalEvents(cs1, 0xEF80);
        // 100D:EF80 inc word ptr DS:[0xCE7C]
        UInt16[DS, (ushort)0xCE7C] = Alu16.Inc(UInt16[DS, (ushort)0xCE7C]);
    label_100D_EF84_1F054_928:
        CheckExternalEvents(cs1, 0xEF84);
        // 100D:EF84 cmp byte ptr DS:[0x2788],0
        Alu8.Sub(UInt8[DS, (ushort)0x2788], (byte)0x00);
        // 100D:EF89 jne short 0xEF9F
        if (!ZeroFlag)
        {
            goto label_100D_EF9F_1F06F_931;
        }
    label_100D_EF8B_1F05B_14929:
        CheckExternalEvents(cs1, 0xEF8B);
        // 100D:EF8B dec word ptr DS:[0x46DB]
        UInt16[DS, (ushort)0x46DB] = Alu16.Dec(UInt16[DS, (ushort)0x46DB]);
        // 100D:EF8F jns short 0xEF9F
        if (!SignFlag)
        {
            goto label_100D_EF9F_1F06F_931;
        }
    label_100D_EF91_1F061_14932:
        CheckExternalEvents(cs1, 0xEF91);
        // 100D:EF91 mov AX,word ptr DS:[0x146E]
        AX = UInt16[DS, (ushort)0x146E];
        // 100D:EF94 mov word ptr DS:[0x46DB],AX
        UInt16[DS, (ushort)0x46DB] = AX;
        // 100D:EF97 inc word ptr DS:[2]
        UInt16[DS, (ushort)0x0002] = Alu16.Inc(UInt16[DS, (ushort)0x0002]);
        // 100D:EF9B inc byte ptr DS:[0x46DD]
        UInt8[DS, (ushort)0x46DD] = Alu8.Inc(UInt8[DS, (ushort)0x46DD]);
    label_100D_EF9F_1F06F_931:
        CheckExternalEvents(cs1, 0xEF9F);
        // 100D:EF9F call near 0xEFBA
        NearCall(cs1, 0xEFA2, unknown_100D_EFBA_1F08A);
    label_100D_EFA2_1F072_940:
        CheckExternalEvents(cs1, 0xEFA2);
        // 100D:EFA2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:EFA3 dec byte ptr DS:[0xCE72]
        UInt8[DS, (ushort)0xCE72] = Alu8.Dec(UInt8[DS, (ushort)0xCE72]);
        // 100D:EFA7 js short 0xEFD5
        if (SignFlag)
        {
            goto label_100D_EFD5_1F0A5_1065;
        }
    label_100D_EFA9_1F079_1043:
        CheckExternalEvents(cs1, 0xEFA9);
        // 100D:EFA9 mov AL,0x20
        AL = (byte)0x20;
        // 100D:EFAB out 0x20,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x20), AL);
        // 100D:EFAD cmp byte ptr DS:[0xDBB5],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBB5], (byte)0x00);
        // 100D:EFB2 je short 0xEFB7
        if (ZeroFlag)
        {
            goto label_100D_EFB7_1F087_1048;
        }
    label_100D_EFB4_1F084_5705:
        CheckExternalEvents(cs1, 0xEFB4);
        // 100D:EFB4 call near 0xCEC9
        NearCall(cs1, 0xEFB7, unknown_100D_CEC9_1CF99);
    label_100D_EFB7_1F087_1048:
        CheckExternalEvents(cs1, 0xEFB7);
        // 100D:EFB7 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:EFB8 pop AX
        AX = Stack.Pop16();
        // 100D:EFB9 iret
        return InterruptRet();
    label_100D_EFD5_1F0A5_1065:
        CheckExternalEvents(cs1, 0xEFD5);
        // 100D:EFD5 mov byte ptr DS:[0xCE72],byte ptr [0x0001F0A9]
        UInt8[DS, (ushort)0xCE72] = UInt8[unchecked((uint)(0x0001F0A9u))];
        // 100D:EFDA pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:EFDB pop AX
        AX = Stack.Pop16();
        // 100D:EFDC jmp far F000:0006
        return provided_interrupt_handler_8_F000_0006_F0006(0x0000);
    }

    public virtual Action unknown_100D_EFBA_1F08A(int loadOffset)
    {
    label_100D_EFBA_1F08A_933:
        CheckExternalEvents(cs1, 0xEFBA);
        // 100D:EFBA push BX
        Stack.Push16(BX);
        // 100D:EFBB test byte ptr DS:[0x2943],0x10
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x10);
        // 100D:EFC0 jne short 0xEFD3
        if (!ZeroFlag)
        {
            goto label_100D_EFD3_1F0A3_937;
        }
    label_100D_EFC2_1F092_3326:
        CheckExternalEvents(cs1, 0xEFC2);
        // 100D:EFC2 push CX
        Stack.Push16(CX);
        // 100D:EFC3 call far dword ptr DS:[0x3981]
        ushort targetSegment_3328 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3981 + (ushort)0x0002)]));
        ushort targetOffset_3328 = unchecked((ushort)(UInt16[DS, (ushort)0x3981]));
        if (targetSegment_3328 == cs4 && targetOffset_3328 == 0x010F)
        {
            FarCall(cs1, 0xEFC7, cs4, unknown_5BAE_010F_5BBEF);
            goto label_100D_EFC7_1F097_3343;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3328:X4}:{targetOffset_3328:X4} at 100D:EFC3");
    label_100D_EFC7_1F097_3343:
        CheckExternalEvents(cs1, 0xEFC7);
        // 100D:EFC7 mov byte ptr DS:[0xDBCD],AL
        UInt8[DS, (ushort)0xDBCD] = AL;
        // 100D:EFCA mov word ptr DS:[0xDBCE],BX
        UInt16[DS, (ushort)0xDBCE] = BX;
        // 100D:EFCE mov word ptr DS:[0xDBD0],CX
        UInt16[DS, (ushort)0xDBD0] = CX;
        // 100D:EFD2 pop CX
        CX = Stack.Pop16();
    label_100D_EFD3_1F0A3_937:
        CheckExternalEvents(cs1, 0xEFD3);
        // 100D:EFD3 pop BX
        BX = Stack.Pop16();
        // 100D:EFD4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_EFE7_1F0B7(int loadOffset)
    {
    label_100D_EFE7_1F0B7_17152:
        CheckExternalEvents(cs1, 0xEFE7);
        // 100D:EFE7 push AX
        Stack.Push16(AX);
        // 100D:EFE8 push CX
        Stack.Push16(CX);
        // 100D:EFE9 push DI
        Stack.Push16(DI);
        // 100D:EFEA push DS
        Stack.Push16(DS);
        // 100D:EFEB mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:EFEE mov DS,AX
        DS = AX;
        // 100D:EFF0 cld
        DirectionFlag = false;
        // 100D:EFF1 in AL,0x60
        AL = Machine.IoPortDispatcher.ReadByte(unchecked((ushort)(byte)0x60));
        // 100D:EFF3 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:EFF5 je short 0xEFE1
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:EFF5");
        }
    label_100D_EFF7_1F0C7_17163:
        CheckExternalEvents(cs1, 0xEFF7);
        // 100D:EFF7 mov DI,AX
        DI = AX;
        // 100D:EFF9 and DI,0x007F
        DI = Alu16.And(DI, unchecked((ushort)unchecked((short)(sbyte)127)));
        // 100D:EFFC cmp DI,0x005A
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)90)));
        // 100D:EFFF jae short 0xF031
        if (!CarryFlag)
        {
            goto label_100D_F031_1F101_17184;
        }
    label_100D_F001_1F0D1_17168:
        CheckExternalEvents(cs1, 0xF001);
        // 100D:F001 add DI,0xCE81
        DI = Alu16.Add(DI, (ushort)0xCE81);
        // 100D:F005 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:F006 not AH
        AH = unchecked((byte)~AH);
        // 100D:F008 xchg AL,AH
        byte temp_100D_F008_1F0D8 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_F008_1F0D8);
        // 100D:F00A mov byte ptr DS:[DI],AL
        UInt8[DS, DI] = AL;
        // 100D:F00C or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:F00E je short 0xF031
        if (ZeroFlag)
        {
            goto label_100D_F031_1F101_17184;
        }
    label_100D_F010_1F0E0_17176:
        CheckExternalEvents(cs1, 0xF010);
        // 100D:F010 mov AL,AH
        AL = AH;
        // 100D:F012 mov byte ptr DS:[0xCEE8],AL
        UInt8[DS, (ushort)0xCEE8] = AL;
        // 100D:F015 cmp AL,0x53
        Alu8.Sub(AL, (byte)0x53);
        // 100D:F017 jne short 0xF026
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:F017");
        }
    label_100D_F026_1F0F6_17181:
        CheckExternalEvents(cs1, 0xF026);
        // 100D:F026 cmp AL,0x2E
        Alu8.Sub(AL, (byte)0x2E);
        // 100D:F028 jne short 0xF031
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:F028");
        }
    label_100D_F031_1F101_17184:
        CheckExternalEvents(cs1, 0xF031);
        // 100D:F031 cmp AL,0x70
        Alu8.Sub(AL, (byte)0x70);
        // 100D:F033 jae short 0xF049
        if (!CarryFlag)
        {
            goto label_100D_F049_1F119_36122;
        }
    label_100D_F035_1F105_17187:
        CheckExternalEvents(cs1, 0xF035);
        // 100D:F035 in AL,0x61
        AL = Machine.IoPortDispatcher.ReadByte(unchecked((ushort)(byte)0x61));
        // 100D:F037 or AL,0x80
        AL = Alu8.Or(AL, (byte)0x80);
        // 100D:F039 out 0x61,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x61), AL);
        // 100D:F03B and AL,0x7F
        AL = Alu8.And(AL, (byte)0x7F);
        // 100D:F03D out 0x61,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x61), AL);
        // 100D:F03F mov AL,0x20
        AL = (byte)0x20;
    label_100D_F041_1F111_17194:
        CheckExternalEvents(cs1, 0xF041);
        // 100D:F041 cli
        InterruptFlag = false;
        // 100D:F042 out 0x20,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x20), AL);
        // 100D:F044 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F045 pop DI
        DI = Stack.Pop16();
        // 100D:F046 pop CX
        CX = Stack.Pop16();
        // 100D:F047 pop AX
        AX = Stack.Pop16();
        // 100D:F048 iret
        return InterruptRet();
    label_100D_F049_1F119_36122:
        CheckExternalEvents(cs1, 0xF049);
        // 100D:F049 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F04A pop DI
        DI = Stack.Pop16();
        // 100D:F04B pop CX
        CX = Stack.Pop16();
        // 100D:F04C pop AX
        AX = Stack.Pop16();
        // 100D:F04D jmp far F000:0011
        return provided_interrupt_handler_9_F000_0011_F0011(0x0000);
    }

    public virtual Action unknown_100D_F0A0_1F170(int loadOffset)
    {
    label_100D_F0A0_1F170_2804:
        CheckExternalEvents(cs1, 0xF0A0);
        // 100D:F0A0 push DI
        Stack.Push16(DI);
        // 100D:F0A1 push ES
        Stack.Push16(ES);
        // 100D:F0A2 inc byte ptr DS:[0xCE71]
        UInt8[DS, (ushort)0xCE71] = Alu8.Inc(UInt8[DS, (ushort)0xCE71]);
        // 100D:F0A6 push DS
        Stack.Push16(DS);
        // 100D:F0A7 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F0A8 mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:F0AB call near 0xF0B9
        NearCall(cs1, 0xF0AE, unknown_100D_F0B9_1F189);
    label_100D_F0AE_1F17E_2813:
        CheckExternalEvents(cs1, 0xF0AE);
        // 100D:F0AE dec byte ptr DS:[0xCE71]
        UInt8[DS, (ushort)0xCE71] = Alu8.Dec(UInt8[DS, (ushort)0xCE71]);
        // 100D:F0B2 mov SI,DI
        SI = DI;
        // 100D:F0B4 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F0B5 pop DI
        DI = Stack.Pop16();
        // 100D:F0B6 jmp near 0xF403
        return unknown_100D_F403_1F4D3(0x0000);
    }

    public virtual Action unknown_100D_F0B9_1F189(int loadOffset)
    {
    label_100D_F0B9_1F189_503:
        CheckExternalEvents(cs1, 0xF0B9);
        // 100D:F0B9 mov word ptr DS:[0xCE78],SI
        UInt16[DS, (ushort)0xCE78] = SI;
        // 100D:F0BD shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:F0BF mov SI,word ptr DS:[SI+0x31FF]
        SI = UInt16[DS, (ushort)(SI + (short)12799)];
        // 100D:F0C3 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F0C4 mov DX,SI
        DX = SI;
        // 100D:F0C6 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:F0C8 je short 0xF0D6
        if (ZeroFlag)
        {
            return unknown_100D_F0D6_1F1A6(0x0000);
        }
    label_100D_F0CA_1F19A_511:
        CheckExternalEvents(cs1, 0xF0CA);
        // 100D:F0CA mov CX,AX
        CX = AX;
        // 100D:F0CC push DX
        Stack.Push16(DX);
        // 100D:F0CD call near 0xF11C
        NearCall(cs1, 0xF0D0, unknown_100D_F11C_1F1EC);
    label_100D_F0D0_1F1A0_523:
        CheckExternalEvents(cs1, 0xF0D0);
        // 100D:F0D0 pop DX
        DX = Stack.Pop16();
        // 100D:F0D1 call near 0xF0D6
        NearCall(cs1, 0xF0D4, unknown_100D_F0D6_1F1A6);
    label_100D_F0D4_1F1A4_711:
        CheckExternalEvents(cs1, 0xF0D4);
        // 100D:F0D4 jmp short 0xF0FF
        return unknown_100D_F0FF_1F1CF(0x0000);
    }

    public virtual Action unknown_100D_F0D6_1F1A6(int loadOffset)
    {
    label_100D_F0D6_1F1A6_526:
        CheckExternalEvents(cs1, 0xF0D6);
        // 100D:F0D6 mov AX,word ptr DS:[0xCE78]
        AX = UInt16[DS, (ushort)0xCE78];
        // 100D:F0D9 cmp AL,byte ptr DS:[0xCE70]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xCE70]);
        // 100D:F0DD jae short 0xF0E4
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:F0DD");
        }
    label_100D_F0E4_1F1B4_530:
        CheckExternalEvents(cs1, 0xF0E4);
        // 100D:F0E4 call near 0xF244
        NearCall(cs1, 0xF0E7, unknown_100D_F244_1F314);
    label_100D_F0E7_1F1B7_571:
        CheckExternalEvents(cs1, 0xF0E7);
        // 100D:F0E7 mov AX,word ptr DS:[0xCE78]
        AX = UInt16[DS, (ushort)0xCE78];
        // 100D:F0EA cmp AL,byte ptr DS:[0xCE70]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xCE70]);
        // 100D:F0EE jae short 0xF0F3
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:F0EE");
        }
    label_100D_F0F3_1F1C3_575:
        CheckExternalEvents(cs1, 0xF0F3);
        // 100D:F0F3 jmp near 0xF3D3
    label_100D_F3D3_1F4A3_577:
        CheckExternalEvents(cs1, 0xF3D3);
        // 100D:F3D3 cmp byte ptr DS:[0xCE71],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE71], (byte)0x00);
        // 100D:F3D8 jne short 0xF402
        if (!ZeroFlag)
        {
            goto label_100D_F402_1F4D2_2767;
        }
    label_100D_F3DA_1F4AA_580:
        CheckExternalEvents(cs1, 0xF3DA);
        // 100D:F3DA push CX
        Stack.Push16(CX);
        // 100D:F3DB push DI
        Stack.Push16(DI);
        // 100D:F3DC push DS
        Stack.Push16(DS);
        // 100D:F3DD push ES
        Stack.Push16(ES);
        // 100D:F3DE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F3DF mov DX,DI
        DX = DI;
        // 100D:F3E1 add DX,CX
        DX = Alu16.Add(DX, CX);
        // 100D:F3E3 mov CX,6
        CX = (ushort)0x0006;
        // 100D:F3E6 mov SI,DI
        SI = DI;
        // 100D:F3E8 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_F3EA_1F4BA_591:
        CheckExternalEvents(cs1, 0xF3EA);
        // 100D:F3EA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F3EB add AH,AL
        AH = Alu8.Add(AH, AL);
        // 100D:F3ED loop 0xF3EA
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_F3EA_1F4BA_591;
        }
    label_100D_F3EF_1F4BF_595:
        CheckExternalEvents(cs1, 0xF3EF);
        // 100D:F3EF cmp AH,0xAB
        Alu8.Sub(AH, (byte)0xAB);
        // 100D:F3F2 jne short 0xF3FE
        if (!ZeroFlag)
        {
            goto label_100D_F3FE_1F4CE_2762;
        }
    label_100D_F3F4_1F4C4_598:
        CheckExternalEvents(cs1, 0xF3F4);
        // 100D:F3F4 mov SI,DI
        SI = DI;
        // 100D:F3F6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F3F7 mov DI,AX
        DI = AX;
        // 100D:F3F9 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F3FA or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:F3FC je short 0xF40D
        if (ZeroFlag)
        {
            goto label_100D_F40D_1F4DD_605;
        }
    label_100D_F3FE_1F4CE_2762:
        CheckExternalEvents(cs1, 0xF3FE);
        // 100D:F3FE stc
        CarryFlag = true;
        // 100D:F3FF pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F400 pop DI
        DI = Stack.Pop16();
        // 100D:F401 pop CX
        CX = Stack.Pop16();
    label_100D_F402_1F4D2_2767:
        CheckExternalEvents(cs1, 0xF402);
        // 100D:F402 ret near
        return NearRet((ushort)0x0000);
    label_100D_F40D_1F4DD_605:
        CheckExternalEvents(cs1, 0xF40D);
        // 100D:F40D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F40E mov CX,AX
        CX = AX;
        // 100D:F410 sub SI,5
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:F413 mov BP,SI
        BP = SI;
        // 100D:F415 add DI,SI
        DI = Alu16.Add(DI, SI);
        // 100D:F417 add DI,0x0040
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)64)));
        // 100D:F41A add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:F41C dec SI
        SI = Alu16.Dec(SI);
        // 100D:F41D dec DI
        DI = Alu16.Dec(DI);
        // 100D:F41E sub CX,6
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:F421 std
        DirectionFlag = true;
        // 100D:F422 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:F424 jae short 0xF427
        if (!CarryFlag)
        {
            goto label_100D_F427_1F4F7_621;
        }
    label_100D_F426_1F4F6_619:
        CheckExternalEvents(cs1, 0xF426);
        // 100D:F426 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_100D_F427_1F4F7_621:
        CheckExternalEvents(cs1, 0xF427);
        // 100D:F427 dec SI
        SI = Alu16.Dec(SI);
        // 100D:F428 dec DI
        DI = Alu16.Dec(DI);
        // 100D:F429 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:F42B cld
        DirectionFlag = false;
        // 100D:F42C mov SI,DI
        SI = DI;
        // 100D:F42E add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F431 mov DI,BP
        DI = BP;
        // 100D:F433 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        return unknown_100D_F435_1F505(0x0000);
    }

    public virtual Action unknown_100D_F0F6_1F1C6(int loadOffset)
    {
    label_100D_F0F6_1F1C6_744:
        CheckExternalEvents(cs1, 0xF0F6);
        // 100D:F0F6 les SI,word ptr DS:[0x39B7]
        ushort lxsOffset_100D_F0F6_1F1C6 = (ushort)0x39B7;
        ushort lxsValue_100D_F0F6_1F1C6 = UInt16[DS, lxsOffset_100D_F0F6_1F1C6];
        ushort lxsSegment_100D_F0F6_1F1C6 = UInt16[DS, (ushort)(lxsOffset_100D_F0F6_1F1C6 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_F0F6_1F1C6);
        ES = unchecked((ushort)lxsSegment_100D_F0F6_1F1C6);
        // 100D:F0FA mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 100D:F0FC mov word ptr DS:[DI+2],ES
        UInt16[DS, (ushort)(DI + (sbyte)2)] = ES;
        return unknown_100D_F0FF_1F1CF(0x0000);
    }

    public virtual Action unknown_100D_F0FF_1F1CF(int loadOffset)
    {
    label_100D_F0FF_1F1CF_137:
        CheckExternalEvents(cs1, 0xF0FF);
        // 100D:F0FF mov AX,CX
        AX = CX;
        // 100D:F101 add AX,0x000F
        AX = Alu16.Add(AX, (ushort)0x000F);
        // 100D:F104 rcr AX,1
        AX = Alu16.Rcr(AX, 1);
        // 100D:F106 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F108 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F10A shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F10C add word ptr DS:[0x39B9],AX
        UInt16[DS, (ushort)0x39B9] = Alu16.Add(UInt16[DS, (ushort)0x39B9], AX);
        // 100D:F110 push AX
        Stack.Push16(AX);
        // 100D:F111 mov AX,word ptr DS:[0x39B9]
        AX = UInt16[DS, (ushort)0x39B9];
        // 100D:F114 cmp AX,word ptr DS:[0xCE68]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE68]);
        // 100D:F118 pop AX
        AX = Stack.Pop16();
        // 100D:F119 ja short 0xF131
        if (!CarryFlag && !ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F119");
        }
    label_100D_F11B_1F1EB_150:
        CheckExternalEvents(cs1, 0xF11B);
        // 100D:F11B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F11C_1F1EC(int loadOffset)
    {
    label_100D_F11C_1F1EC_515:
        CheckExternalEvents(cs1, 0xF11C);
        // 100D:F11C les DI,word ptr DS:[0x39B7]
        ushort lxsOffset_100D_F11C_1F1EC = (ushort)0x39B7;
        ushort lxsValue_100D_F11C_1F1EC = UInt16[DS, lxsOffset_100D_F11C_1F1EC];
        ushort lxsSegment_100D_F11C_1F1EC = UInt16[DS, (ushort)(lxsOffset_100D_F11C_1F1EC + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_F11C_1F1EC);
        ES = unchecked((ushort)lxsSegment_100D_F11C_1F1EC);
        // 100D:F120 mov AX,ES
        AX = ES;
        // 100D:F122 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:F124 cmp AX,word ptr DS:[0xCE68]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE68]);
        // 100D:F128 jae short 0xF12B
        if (!CarryFlag)
        {
            goto label_100D_F12B_1F1FB_6353;
        }
    label_100D_F12A_1F1FA_521:
        CheckExternalEvents(cs1, 0xF12A);
        // 100D:F12A ret near
        return NearRet((ushort)0x0000);
    label_100D_F12B_1F1FB_6353:
        CheckExternalEvents(cs1, 0xF12B);
        // 100D:F12B call near 0xF13F
        NearCall(cs1, 0xF12E, unknown_100D_F13F_1F20F);
    label_100D_F12E_1F1FE_6447:
        CheckExternalEvents(cs1, 0xF12E);
        // 100D:F12E jmp short 0xF11C
        goto label_100D_F11C_1F1EC_515;
    }
}
