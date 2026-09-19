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
    public virtual Action unknown_100D_AC14_1ACE4(int loadOffset)
    {
    label_100D_AC14_1ACE4_1828:
        CheckExternalEvents(cs1, 0xAC14);
        // 100D:AC14 push AX
        Stack.Push16(AX);
        // 100D:AC15 push BX
        Stack.Push16(BX);
        // 100D:AC16 push CX
        Stack.Push16(CX);
        // 100D:AC17 push SI
        Stack.Push16(SI);
        // 100D:AC18 push DI
        Stack.Push16(DI);
        // 100D:AC19 push BP
        Stack.Push16(BP);
        // 100D:AC1A push ES
        Stack.Push16(ES);
        // 100D:AC1B mov SI,0xAB92
        SI = (ushort)0xAB92;
        // 100D:AC1E call near 0xDA5F
        NearCall(cs1, 0xAC21, unknown_100D_DA5F_1DB2F);
    label_100D_AC21_1ACF1_1844:
        CheckExternalEvents(cs1, 0xAC21);
        // 100D:AC21 call near 0xA9A1
        NearCall(cs1, 0xAC24, unknown_100D_A9A1_1AA71);
    label_100D_AC24_1ACF4_1854:
        CheckExternalEvents(cs1, 0xAC24);
        // 100D:AC24 call far dword ptr DS:[0x3995]
        ushort targetSegment_1854 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3995 + (ushort)0x0002)]));
        ushort targetOffset_1854 = unchecked((ushort)(UInt16[DS, (ushort)0x3995]));
        if (targetSegment_1854 == cs3 && targetOffset_1854 == 0x0109)
        {
            FarCall(cs1, 0xAC28, cs3, unknown_5642_0109_56529);
            goto label_100D_AC28_1ACF8_1858;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_1854:X4}:{targetOffset_1854:X4} at 100D:AC24");
    label_100D_AC28_1ACF8_1858:
        CheckExternalEvents(cs1, 0xAC28);
        // 100D:AC28 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:AC29 pop BP
        BP = Stack.Pop16();
        // 100D:AC2A pop DI
        DI = Stack.Pop16();
        // 100D:AC2B pop SI
        SI = Stack.Pop16();
        // 100D:AC2C pop CX
        CX = Stack.Pop16();
        // 100D:AC2D pop BX
        BX = Stack.Pop16();
        // 100D:AC2E pop AX
        AX = Stack.Pop16();
        // 100D:AC2F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AC30_1AD00(int loadOffset)
    {
    label_100D_AC30_1AD00_3455:
        CheckExternalEvents(cs1, 0xAC30);
        // 100D:AC30 call far dword ptr DS:[0x3999]
        ushort targetSegment_3455 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3999 + (ushort)0x0002)]));
        ushort targetOffset_3455 = unchecked((ushort)(UInt16[DS, (ushort)0x3999]));
        if (targetSegment_3455 == cs3 && targetOffset_3455 == 0x010C)
        {
            FarCall(cs1, 0xAC34, cs3, unknown_5642_010C_5652C);
            goto label_100D_AC34_1AD04_3482;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3455:X4}:{targetOffset_3455:X4} at 100D:AC30");
    label_100D_AC34_1AD04_3482:
        CheckExternalEvents(cs1, 0xAC34);
        // 100D:AC34 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AC3A_1AD0A(int loadOffset)
    {
    label_100D_AC3A_1AD0A_25491:
        CheckExternalEvents(cs1, 0xAC3A);
        // 100D:AC3A mov BP,0x201A
        BP = (ushort)0x201A;
        // 100D:AC3D or byte ptr SS:[BP+3],0x40
        UInt8[SS, (ushort)(BP + (sbyte)3)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0x40);
        // 100D:AC41 or byte ptr SS:[BP+7],0x40
        UInt8[SS, (ushort)(BP + (sbyte)7)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)7)], (byte)0x40);
        // 100D:AC45 or byte ptr SS:[BP+0x0B],0x40
        UInt8[SS, (ushort)(BP + (sbyte)11)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)11)], (byte)0x40);
        // 100D:AC49 mov CL,0xFF
        CL = (byte)0xFF;
        // 100D:AC4B call near 0xAE28
        NearCall(cs1, 0xAC4E, unknown_100D_AE28_1AEF8);
    label_100D_AC4E_1AD1E_25498:
        CheckExternalEvents(cs1, 0xAC4E);
        // 100D:AC4E je short 0xAC6D
        if (ZeroFlag)
        {
            goto label_100D_AC6D_1AD3D_25511;
        }
    label_100D_AC50_1AD20_25500:
        CheckExternalEvents(cs1, 0xAC50);
        // 100D:AC50 and byte ptr SS:[BP+3],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)3)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0xBF);
        // 100D:AC54 and byte ptr SS:[BP+7],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)7)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)7)], (byte)0xBF);
        // 100D:AC58 and byte ptr SS:[BP+0x0B],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)11)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)11)], (byte)0xBF);
        // 100D:AC5C xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:AC5E test byte ptr DS:[0x2943],0x10
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x10);
        // 100D:AC63 jne short 0xAC6D
        if (!ZeroFlag)
        {
            goto label_100D_AC6D_1AD3D_25511;
        }
    label_100D_AC65_1AD35_25507:
        CheckExternalEvents(cs1, 0xAC65);
        // 100D:AC65 mov CL,byte ptr DS:[0x3810]
        CL = UInt8[DS, (ushort)0x3810];
        // 100D:AC69 and CL,1
        CL = Alu8.And(CL, (byte)0x01);
        // 100D:AC6C inc CX
        CX = Alu16.Inc(CX);
    label_100D_AC6D_1AD3D_25511:
        CheckExternalEvents(cs1, 0xAC6D);
        // 100D:AC6D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ACBF_1AD8F(int loadOffset)
    {
    label_100D_ACBF_1AD8F_25769:
        CheckExternalEvents(cs1, 0xACBF);
        // 100D:ACBF mov BP,0x37FA
        BP = (ushort)0x37FA;
        // 100D:ACC2 mov CX,0x0012
        CX = (ushort)0x0012;
    label_100D_ACC5_1AD95_25772:
        CheckExternalEvents(cs1, 0xACC5);
        // 100D:ACC5 mov BX,8
        BX = (ushort)0x0008;
        // 100D:ACC8 call near 0xE3DF
        NearCall(cs1, 0xACCB, unknown_100D_E3DF_1E4AF);
    label_100D_ACCB_1AD9B_25774:
        CheckExternalEvents(cs1, 0xACCB);
        // 100D:ACCB mov SI,AX
        SI = AX;
        // 100D:ACCD mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:ACD0 xor AX,CX
        AX = Alu16.Xor(AX, CX);
        // 100D:ACD2 add word ptr DS:[0xD828],AX
        UInt16[DS, (ushort)0xD828] = Alu16.Add(UInt16[DS, (ushort)0xD828], AX);
        // 100D:ACD6 call near 0xE3DF
        NearCall(cs1, 0xACD9, unknown_100D_E3DF_1E4AF);
    label_100D_ACD9_1ADA9_25780:
        CheckExternalEvents(cs1, 0xACD9);
        // 100D:ACD9 mov DI,AX
        DI = AX;
        // 100D:ACDB mov AL,byte ptr SS:[BP+SI]
        AL = UInt8[SS, (ushort)(BP + SI)];
        // 100D:ACDD xchg AL,byte ptr SS:[BP+DI]
        ushort xchgOffset_100D_ACDD_1ADAD = unchecked((ushort)(BP + DI));
        byte temp_100D_ACDD_1ADAD = AL;
        AL = UInt8[SS, xchgOffset_100D_ACDD_1ADAD];
        UInt8[SS, xchgOffset_100D_ACDD_1ADAD] = unchecked((byte)temp_100D_ACDD_1ADAD);
        // 100D:ACDF mov byte ptr SS:[BP+SI],AL
        UInt8[SS, (ushort)(BP + SI)] = AL;
        // 100D:ACE1 loop 0xACC5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_ACC5_1AD95_25772;
        }
    label_100D_ACE3_1ADB3_25788:
        CheckExternalEvents(cs1, 0xACE3);
        // 100D:ACE3 mov SI,BP
        SI = BP;
        // 100D:ACE5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ACE6_1ADB6(int loadOffset)
    {
    entrydispatcher:
    label_100D_ACE6_1ADB6_4771:
        CheckExternalEvents(cs1, 0xACE6);
        // 100D:ACE6 call near 0xABCC
        NearCall(cs1, 0xACE9, unknown_100D_ABCC_1AC9C);
    label_100D_ACE9_1ADB9_4773:
        CheckExternalEvents(cs1, 0xACE9);
        // 100D:ACE9 jne short 0xAD36
        if (!ZeroFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
    label_100D_ACEB_1ADBB_4775:
        CheckExternalEvents(cs1, 0xACEB);
        // 100D:ACEB test byte ptr DS:[0x3810],1
        Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0x01);
        // 100D:ACF0 je short 0xAD37
        if (ZeroFlag)
        {
            goto label_100D_AD37_1AE07_14683;
        }
    label_100D_ACF2_1ADC2_4778:
        CheckExternalEvents(cs1, 0xACF2);
        // 100D:ACF2 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:ACF7 jne short 0xAD36
        if (!ZeroFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
    label_100D_ACF9_1ADC9_25795:
        CheckExternalEvents(cs1, 0xACF9);
        // 100D:ACF9 cmp byte ptr DS:[0xDBCD],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCD], (byte)0x00);
        // 100D:ACFE js short 0xAD36
        if (SignFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
    label_100D_AD00_1ADD0_25817:
        CheckExternalEvents(cs1, 0xAD00);
        // 100D:AD00 mov AX,word ptr DS:[0xDBD2]
        AX = UInt16[DS, (ushort)0xDBD2];
        // 100D:AD03 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:AD05 jne short 0xAD0D
        if (!ZeroFlag)
        {
            goto label_100D_AD0D_1ADDD_25824;
        }
    label_100D_AD07_1ADD7_25821:
        CheckExternalEvents(cs1, 0xAD07);
        // 100D:AD07 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:AD0A mov word ptr DS:[0xDBD2],AX
        UInt16[DS, (ushort)0xDBD2] = AX;
    label_100D_AD0D_1ADDD_25824:
        CheckExternalEvents(cs1, 0xAD0D);
        // 100D:AD0D sub AX,word ptr DS:[0xCE7A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xCE7A]);
        // 100D:AD11 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:AD13 cmp AX,0x00C8
        Alu16.Sub(AX, (ushort)0x00C8);
        // 100D:AD16 jb short 0xAD36
        if (CarryFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
    label_100D_AD18_1ADE8_25829:
        CheckExternalEvents(cs1, 0xAD18);
        // 100D:AD18 mov SI,word ptr DS:[0x380E]
        SI = UInt16[DS, (ushort)0x380E];
        // 100D:AD1C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:AD1D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:AD1F jns short 0xAD30
        if (!SignFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xAD30))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        else
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xAD21))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_AD36_1AE06_4781:
        CheckExternalEvents(cs1, 0xAD36);
        // 100D:AD36 ret near
        return NearRet((ushort)0x0000);
    label_100D_AD37_1AE07_14683:
        CheckExternalEvents(cs1, 0xAD37);
        // 100D:AD37 call near 0xAEC6
        NearCall(cs1, 0xAD3A, unknown_100D_AEC6_1AF96);
    label_100D_AD3A_1AE0A_14685:
        CheckExternalEvents(cs1, 0xAD3A);
        // 100D:AD3A jb short 0xAD36
        if (CarryFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
    label_100D_AD3C_1AE0C_14687:
        CheckExternalEvents(cs1, 0xAD3C);
        // 100D:AD3C cmp byte ptr DS:[0xDBCD],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCD], (byte)0x00);
        // 100D:AD41 js short 0xAD36
        if (SignFlag)
        {
            goto label_100D_AD36_1AE06_4781;
        }
        else
        {
            return unknown_100D_AD43_1AE13(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_AD43_1AE13(int loadOffset)
    {
    label_100D_AD43_1AE13_14598:
        CheckExternalEvents(cs1, 0xAD43);
        // 100D:AD43 mov AL,byte ptr DS:[0xDBCC]
        AL = UInt8[DS, (ushort)0xDBCC];
        // 100D:AD46 mov byte ptr DS:[0xDBCB],0
        UInt8[DS, (ushort)0xDBCB] = (byte)0x00;
        // 100D:AD4B or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:AD4D jne short 0xAD95
        if (!ZeroFlag)
        {
            return unknown_100D_AD95_1AE65(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:AD4D");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_AD50_1AE20(int loadOffset)
    {
    label_100D_AD50_1AE20_11540:
        CheckExternalEvents(cs1, 0xAD50);
        // 100D:AD50 call near 0xAEB7
        NearCall(cs1, 0xAD53, unknown_100D_AEB7_1AF87);
    label_100D_AD53_1AE23_11542:
        CheckExternalEvents(cs1, 0xAD53);
        // 100D:AD53 mov AL,3
        AL = (byte)0x03;
        // 100D:AD55 jmp short 0xAD95
        return unknown_100D_AD95_1AE65(0x0000);
    }

    public virtual Action unknown_100D_AD57_1AE27(int loadOffset)
    {
    label_100D_AD57_1AE27_3622:
        CheckExternalEvents(cs1, 0xAD57);
        // 100D:AD57 call near 0xAEB7
        NearCall(cs1, 0xAD5A, unknown_100D_AEB7_1AF87);
    label_100D_AD5A_1AE2A_3624:
        CheckExternalEvents(cs1, 0xAD5A);
        // 100D:AD5A mov AL,6
        AL = (byte)0x06;
        // 100D:AD5C jmp short 0xAD95
        return unknown_100D_AD95_1AE65(0x0000);
    }

    public virtual Action unknown_100D_AD5E_1AE2E(int loadOffset)
    {
    label_100D_AD5E_1AE2E_14355:
        CheckExternalEvents(cs1, 0xAD5E);
        // 100D:AD5E call near 0xAEC6
        NearCall(cs1, 0xAD61, unknown_100D_AEC6_1AF96);
    label_100D_AD61_1AE31_14357:
        CheckExternalEvents(cs1, 0xAD61);
        // 100D:AD61 jb short 0xAD74
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AD61");
        }
    label_100D_AD63_1AE33_14359:
        CheckExternalEvents(cs1, 0xAD63);
        // 100D:AD63 call near 0xAA96
        NearCall(cs1, 0xAD66, unknown_100D_AA96_1AB66);
    label_100D_AD66_1AE36_14406:
        CheckExternalEvents(cs1, 0xAD66);
        // 100D:AD66 cmp byte ptr DS:[0x3810],0
        Alu8.Sub(UInt8[DS, (ushort)0x3810], (byte)0x00);
        // 100D:AD6B je short 0xAD75
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:AD6B");
        }
    label_100D_AD75_1AE45_14409:
        CheckExternalEvents(cs1, 0xAD75);
        // 100D:AD75 mov BX,0x375C
        BX = (ushort)0x375C;
        // 100D:AD78 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:AD79 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:AD7B je short 0xADBD
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AD7B");
        }
    label_100D_AD7D_1AE4D_14414:
        CheckExternalEvents(cs1, 0xAD7D);
        // 100D:AD7D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:AD7F js short 0xAD89
        if (SignFlag)
        {
            goto label_100D_AD89_1AE59_14417;
        }
    label_100D_AD81_1AE51_17485:
        CheckExternalEvents(cs1, 0xAD81);
        // 100D:AD81 mov byte ptr DS:[0xDBCC],AL
        UInt8[DS, (ushort)0xDBCC] = AL;
        // 100D:AD84 call far dword ptr DS:[0x3979]
        ushort targetSegment_17487 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3979 + (ushort)0x0002)]));
        ushort targetOffset_17487 = unchecked((ushort)(UInt16[DS, (ushort)0x3979]));
        if (targetSegment_17487 == cs4 && targetOffset_17487 == 0x0109)
        {
            FarCall(cs1, 0xAD88, cs4, unknown_5BAE_0109_5BBE9);
            goto label_100D_AD88_1AE58_17494;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_17487:X4}:{targetOffset_17487:X4} at 100D:AD84");
    label_100D_AD88_1AE58_17494:
        CheckExternalEvents(cs1, 0xAD88);
        // 100D:AD88 ret near
        return NearRet((ushort)0x0000);
    label_100D_AD89_1AE59_14417:
        CheckExternalEvents(cs1, 0xAD89);
        // 100D:AD89 and AL,0x3F
        AL = Alu8.And(AL, (byte)0x3F);
        // 100D:AD8B mov byte ptr DS:[0xDBCC],AL
        UInt8[DS, (ushort)0xDBCC] = AL;
        // 100D:AD8E cmp AL,byte ptr DS:[0xDBCB]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDBCB]);
        // 100D:AD92 jne short 0xADBE
        if (!ZeroFlag)
        {
            return unknown_100D_ADBE_1AE8E(0x0000);
        }
    label_100D_AD94_1AE64_19937:
        CheckExternalEvents(cs1, 0xAD94);
        // 100D:AD94 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AD95_1AE65(int loadOffset)
    {
    label_100D_AD95_1AE65_3627:
        CheckExternalEvents(cs1, 0xAD95);
        // 100D:AD95 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:AD97 call near 0xAEC6
        NearCall(cs1, 0xAD9A, unknown_100D_AEC6_1AF96);
    label_100D_AD9A_1AE6A_3640:
        CheckExternalEvents(cs1, 0xAD9A);
        // 100D:AD9A jb short 0xADBD
        if (CarryFlag)
        {
            return unknown_100D_ADBD_1AE8D(0x0000);
        }
    label_100D_AD9C_1AE6C_3642:
        CheckExternalEvents(cs1, 0xAD9C);
        // 100D:AD9C cmp AL,byte ptr DS:[0xDBCB]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDBCB]);
        // 100D:ADA0 je short 0xADBD
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ADA0");
        }
    label_100D_ADA2_1AE72_3645:
        CheckExternalEvents(cs1, 0xADA2);
        // 100D:ADA2 call near 0xAE62
        NearCall(cs1, 0xADA5, unknown_100D_AE62_1AF32);
    label_100D_ADA5_1AE75_3666:
        CheckExternalEvents(cs1, 0xADA5);
        // 100D:ADA5 mov byte ptr DS:[0xDBCB],AL
        UInt8[DS, (ushort)0xDBCB] = AL;
        // 100D:ADA8 les SI,word ptr DS:[0xDBB6]
        ushort lxsOffset_100D_ADA8_1AE78 = (ushort)0xDBB6;
        ushort lxsValue_100D_ADA8_1AE78 = UInt16[DS, lxsOffset_100D_ADA8_1AE78];
        ushort lxsSegment_100D_ADA8_1AE78 = UInt16[DS, (ushort)(lxsOffset_100D_ADA8_1AE78 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_ADA8_1AE78);
        ES = unchecked((ushort)lxsSegment_100D_ADA8_1AE78);
        // 100D:ADAC mov AL,byte ptr DS:[0x3810]
        AL = UInt8[DS, (ushort)0x3810];
        // 100D:ADAF and AL,1
        AL = Alu8.And(AL, (byte)0x01);
        // 100D:ADB1 call far dword ptr DS:[0x3971]
        ushort targetSegment_3671 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3971 + (ushort)0x0002)]));
        ushort targetOffset_3671 = unchecked((ushort)(UInt16[DS, (ushort)0x3971]));
        if (targetSegment_3671 == cs4 && targetOffset_3671 == 0x0103)
        {
            FarCall(cs1, 0xADB5, cs4, unknown_5BAE_0103_5BBE3);
            goto label_100D_ADB5_1AE85_4106;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3671:X4}:{targetOffset_3671:X4} at 100D:ADB1");
    label_100D_ADB5_1AE85_4106:
        CheckExternalEvents(cs1, 0xADB5);
        // 100D:ADB5 mov byte ptr DS:[0xDBCD],AL
        UInt8[DS, (ushort)0xDBCD] = AL;
        // 100D:ADB8 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:ADBA mov word ptr DS:[0xDBD2],AX
        UInt16[DS, (ushort)0xDBD2] = AX;
        return unknown_100D_ADBD_1AE8D(0x0000);
    }

    public virtual Action unknown_100D_ADBE_1AE8E(int loadOffset)
    {
    label_100D_ADBE_1AE8E_14422:
        CheckExternalEvents(cs1, 0xADBE);
        // 100D:ADBE call near 0xAEC6
        NearCall(cs1, 0xADC1, unknown_100D_AEC6_1AF96);
    label_100D_ADC1_1AE91_14424:
        CheckExternalEvents(cs1, 0xADC1);
        // 100D:ADC1 jb short 0xADBD
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ADC1");
        }
    label_100D_ADC3_1AE93_14426:
        CheckExternalEvents(cs1, 0xADC3);
        // 100D:ADC3 test byte ptr DS:[0x3810],1
        Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0x01);
        // 100D:ADC8 jne short 0xADBD
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ADC8");
        }
    label_100D_ADCA_1AE9A_14429:
        CheckExternalEvents(cs1, 0xADCA);
        // 100D:ADCA test byte ptr DS:[0xDBCD],0x40
        Alu8.And(UInt8[DS, (ushort)0xDBCD], (byte)0x40);
        // 100D:ADCF jne short 0xADBD
        if (!ZeroFlag)
        {
            return unknown_100D_ADBD_1AE8D(0x0000);
        }
    label_100D_ADD1_1AEA1_14432:
        CheckExternalEvents(cs1, 0xADD1);
        // 100D:ADD1 push BX
        Stack.Push16(BX);
        // 100D:ADD2 mov AX,0x012C
        AX = (ushort)0x012C;
        // 100D:ADD5 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:ADD7 call far dword ptr DS:[0x397D]
        ushort targetSegment_14436 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x397D + (ushort)0x0002)]));
        ushort targetOffset_14436 = unchecked((ushort)(UInt16[DS, (ushort)0x397D]));
        if (targetSegment_14436 == cs4 && targetOffset_14436 == 0x010C)
        {
            FarCall(cs1, 0xADDB, cs4, unknown_5BAE_010C_5BBEC);
            goto label_100D_ADDB_1AEAB_14440;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_14436:X4}:{targetOffset_14436:X4} at 100D:ADD7");
    label_100D_ADDB_1AEAB_14440:
        CheckExternalEvents(cs1, 0xADDB);
        // 100D:ADDB mov byte ptr DS:[0xDBCD],AL
        UInt8[DS, (ushort)0xDBCD] = AL;
        // 100D:ADDE pop BX
        BX = Stack.Pop16();
        // 100D:ADDF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ADE0_1AEB0(int loadOffset)
    {
    label_100D_ADE0_1AEB0_8589:
        CheckExternalEvents(cs1, 0xADE0);
        // 100D:ADE0 mov AX,0x0064
        AX = (ushort)0x0064;
        // 100D:ADE3 mov BL,byte ptr DS:[0x289E]
        BL = UInt8[DS, (ushort)0x289E];
        // 100D:ADE7 mov BH,byte ptr DS:[0x28B6]
        BH = UInt8[DS, (ushort)0x28B6];
        // 100D:ADEB jmp short 0xADF8
        return unknown_100D_ADF8_1AEC8(0x0000);
    }

    public virtual Action unknown_100D_ADED_1AEBD(int loadOffset)
    {
    label_100D_ADED_1AEBD_9321:
        CheckExternalEvents(cs1, 0xADED);
        // 100D:ADED mov AX,0x0190
        AX = (ushort)0x0190;
        // 100D:ADF0 mov BL,byte ptr DS:[0x2896]
        BL = UInt8[DS, (ushort)0x2896];
        // 100D:ADF4 mov BH,byte ptr DS:[0x28AE]
        BH = UInt8[DS, (ushort)0x28AE];
        return unknown_100D_ADF8_1AEC8(0x0000);
    }

    public virtual Action unknown_100D_AE04_1AED4(int loadOffset)
    {
    label_100D_AE04_1AED4_14584:
        CheckExternalEvents(cs1, 0xAE04);
        // 100D:AE04 call near 0xAEC6
        NearCall(cs1, 0xAE07, unknown_100D_AEC6_1AF96);
    label_100D_AE07_1AED7_14586:
        CheckExternalEvents(cs1, 0xAE07);
        // 100D:AE07 jb short 0xADBD
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE07");
        }
    label_100D_AE09_1AED9_14588:
        CheckExternalEvents(cs1, 0xAE09);
        // 100D:AE09 test byte ptr DS:[0x3810],1
        Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0x01);
        // 100D:AE0E jne short 0xADBD
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE0E");
        }
    label_100D_AE10_1AEE0_14591:
        CheckExternalEvents(cs1, 0xAE10);
        // 100D:AE10 cmp byte ptr DS:[0xDBCD],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCD], (byte)0x00);
        // 100D:AE15 jns short 0xAE1E
        if (!SignFlag)
        {
            goto label_100D_AE1E_1AEEE_14594;
        }
    label_100D_AE17_1AEE7_20165:
        CheckExternalEvents(cs1, 0xAE17);
        // 100D:AE17 test byte ptr DS:[0xDBCD],0x40
        Alu8.And(UInt8[DS, (ushort)0xDBCD], (byte)0x40);
        // 100D:AE1C je short 0xADBD
        if (ZeroFlag)
        {
            return unknown_100D_ADBD_1AE8D(0x0000);
        }
    label_100D_AE1E_1AEEE_14594:
        CheckExternalEvents(cs1, 0xAE1E);
        // 100D:AE1E call near 0xE270
        NearCall(cs1, 0xAE21, unknown_100D_E270_1E340);
    label_100D_AE21_1AEF1_14596:
        CheckExternalEvents(cs1, 0xAE21);
        // 100D:AE21 call near 0xAD43
        NearCall(cs1, 0xAE24, unknown_100D_AD43_1AE13);
    label_100D_AE24_1AEF4_14603:
        CheckExternalEvents(cs1, 0xAE24);
        // 100D:AE24 call near 0xE283
        NearCall(cs1, 0xAE27, unknown_100D_E283_1E353);
    label_100D_AE27_1AEF7_14605:
        CheckExternalEvents(cs1, 0xAE27);
        // 100D:AE27 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AE28_1AEF8(int loadOffset)
    {
    label_100D_AE28_1AEF8_2415:
        CheckExternalEvents(cs1, 0xAE28);
        // 100D:AE28 test word ptr DS:[0xDBC8],0x0100
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0100);
        // 100D:AE2E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AE2F_1AEFF(int loadOffset)
    {
    label_100D_AE2F_1AEFF_1791:
        CheckExternalEvents(cs1, 0xAE2F);
        // 100D:AE2F push AX
        Stack.Push16(AX);
        // 100D:AE30 push DS
        Stack.Push16(DS);
        // 100D:AE31 mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:AE34 mov DS,AX
        DS = AX;
        // 100D:AE36 test word ptr DS:[0xDBC8],1
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0001);
        // 100D:AE3C pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:AE3D pop AX
        AX = Stack.Pop16();
        // 100D:AE3E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AE3F_1AF0F(int loadOffset)
    {
    label_100D_AE3F_1AF0F_2413:
        CheckExternalEvents(cs1, 0xAE3F);
        // 100D:AE3F call near 0xAE28
        NearCall(cs1, 0xAE42, unknown_100D_AE28_1AEF8);
    label_100D_AE42_1AF12_2418:
        CheckExternalEvents(cs1, 0xAE42);
        // 100D:AE42 je short 0xAE3E
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE42");
        }
    label_100D_AE44_1AF14_2420:
        CheckExternalEvents(cs1, 0xAE44);
        // 100D:AE44 mov DI,0xDBB6
        DI = (ushort)0xDBB6;
        // 100D:AE47 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:AE49 or AX,word ptr DS:[DI+2]
        AX = Alu16.Or(AX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:AE4C jne short 0xAE3E
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE4C");
        }
    label_100D_AE4E_1AF1E_2425:
        CheckExternalEvents(cs1, 0xAE4E);
        // 100D:AE4E mov CX,0x9C40
        CX = (ushort)0x9C40;
        // 100D:AE51 jmp near 0xF0F6
        return unknown_100D_F0F6_1F1C6(0x0000);
    }

    public virtual Action unknown_100D_AE54_1AF24(int loadOffset)
    {
    label_100D_AE54_1AF24_1789:
        CheckExternalEvents(cs1, 0xAE54);
        // 100D:AE54 call near 0xAE2F
        NearCall(cs1, 0xAE57, unknown_100D_AE2F_1AEFF);
    label_100D_AE57_1AF27_1800:
        CheckExternalEvents(cs1, 0xAE57);
        // 100D:AE57 je short 0xAE3E
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE57");
        }
    label_100D_AE59_1AF29_1802:
        CheckExternalEvents(cs1, 0xAE59);
        // 100D:AE59 mov DI,0x3811
        DI = (ushort)0x3811;
        // 100D:AE5C mov CX,0x4E20
        CX = (ushort)0x4E20;
        // 100D:AE5F jmp near 0xF0F6
        return unknown_100D_F0F6_1F1C6(0x0000);
    }

    public virtual Action unknown_100D_AE62_1AF32(int loadOffset)
    {
    label_100D_AE62_1AF32_3647:
        CheckExternalEvents(cs1, 0xAE62);
        // 100D:AE62 cmp AL,byte ptr DS:[0xDBCA]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDBCA]);
        // 100D:AE66 je short 0xAE84
        if (ZeroFlag)
        {
            goto label_100D_AE84_1AF54_3665;
        }
    label_100D_AE68_1AF38_3650:
        CheckExternalEvents(cs1, 0xAE68);
        // 100D:AE68 call near 0xAEB7
        NearCall(cs1, 0xAE6B, unknown_100D_AEB7_1AF87);
    label_100D_AE6B_1AF3B_3652:
        CheckExternalEvents(cs1, 0xAE6B);
        // 100D:AE6B mov byte ptr DS:[0xDBCA],AL
        UInt8[DS, (ushort)0xDBCA] = AL;
        // 100D:AE6E push AX
        Stack.Push16(AX);
        // 100D:AE6F add AX,0x00A4
        AX = Alu16.Add(AX, (ushort)0x00A4);
        // 100D:AE72 mov SI,AX
        SI = AX;
        // 100D:AE74 les DI,word ptr DS:[0xDBB6]
        ushort lxsOffset_100D_AE74_1AF44 = (ushort)0xDBB6;
        ushort lxsValue_100D_AE74_1AF44 = UInt16[DS, lxsOffset_100D_AE74_1AF44];
        ushort lxsSegment_100D_AE74_1AF44 = UInt16[DS, (ushort)(lxsOffset_100D_AE74_1AF44 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_AE74_1AF44);
        ES = unchecked((ushort)lxsSegment_100D_AE74_1AF44);
        // 100D:AE78 mov AX,ES
        AX = ES;
        // 100D:AE7A cmp AX,word ptr DS:[0xCE68]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE68]);
        // 100D:AE7E jae short 0xAE85
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AE7E");
        }
    label_100D_AE80_1AF50_3661:
        CheckExternalEvents(cs1, 0xAE80);
        // 100D:AE80 call near 0xF0B9
        NearCall(cs1, 0xAE83, unknown_100D_F0B9_1F189);
    label_100D_AE83_1AF53_3663:
        CheckExternalEvents(cs1, 0xAE83);
        // 100D:AE83 pop AX
        AX = Stack.Pop16();
    label_100D_AE84_1AF54_3665:
        CheckExternalEvents(cs1, 0xAE84);
        // 100D:AE84 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AEB7_1AF87(int loadOffset)
    {
    label_100D_AEB7_1AF87_3388:
        CheckExternalEvents(cs1, 0xAEB7);
        // 100D:AEB7 push AX
        Stack.Push16(AX);
        // 100D:AEB8 mov byte ptr DS:[0xDBCB],0
        UInt8[DS, (ushort)0xDBCB] = (byte)0x00;
        // 100D:AEBD call far dword ptr DS:[0x3975]
        ushort targetSegment_3391 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3975 + (ushort)0x0002)]));
        ushort targetOffset_3391 = unchecked((ushort)(UInt16[DS, (ushort)0x3975]));
        if (targetSegment_3391 == cs4 && targetOffset_3391 == 0x0106)
        {
            FarCall(cs1, 0xAEC1, cs4, unknown_5BAE_0106_5BBE6);
            goto label_100D_AEC1_1AF91_3394;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_3391:X4}:{targetOffset_3391:X4} at 100D:AEBD");
    label_100D_AEC1_1AF91_3394:
        CheckExternalEvents(cs1, 0xAEC1);
        // 100D:AEC1 mov byte ptr DS:[0xDBCD],AL
        UInt8[DS, (ushort)0xDBCD] = AL;
        // 100D:AEC4 pop AX
        AX = Stack.Pop16();
        // 100D:AEC5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AEC6_1AF96(int loadOffset)
    {
    label_100D_AEC6_1AF96_3630:
        CheckExternalEvents(cs1, 0xAEC6);
        // 100D:AEC6 test byte ptr DS:[0x2943],0x10
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x10);
        // 100D:AECB jne short 0xAED4
        if (!ZeroFlag)
        {
            goto label_100D_AED4_1AFA4_25834;
        }
    label_100D_AECD_1AF9D_3633:
        CheckExternalEvents(cs1, 0xAECD);
        // 100D:AECD call near 0xAE28
        NearCall(cs1, 0xAED0, unknown_100D_AE28_1AEF8);
    label_100D_AED0_1AFA0_3635:
        CheckExternalEvents(cs1, 0xAED0);
        // 100D:AED0 je short 0xAED4
        if (ZeroFlag)
        {
            goto label_100D_AED4_1AFA4_25834;
        }
    label_100D_AED2_1AFA2_3637:
        CheckExternalEvents(cs1, 0xAED2);
        // 100D:AED2 clc
        CarryFlag = false;
        // 100D:AED3 ret near
        return NearRet((ushort)0x0000);
    label_100D_AED4_1AFA4_25834:
        CheckExternalEvents(cs1, 0xAED4);
        // 100D:AED4 stc
        CarryFlag = true;
        // 100D:AED5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AED6_1AFA6(int loadOffset)
    {
    label_100D_AED6_1AFA6_16319:
        CheckExternalEvents(cs1, 0xAED6);
        // 100D:AED6 cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:AEDB je short 0xAEDE
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:AEDB");
        }
    label_100D_AEDE_1AFAE_16322:
        CheckExternalEvents(cs1, 0xAEDE);
        // 100D:AEDE call near 0x18BA
        NearCall(cs1, 0xAEE1, unknown_100D_18BA_1198A);
    label_100D_AEE1_1AFB1_16345:
        CheckExternalEvents(cs1, 0xAEE1);
        // 100D:AEE1 call near 0x181E
        NearCall(cs1, 0xAEE4, unknown_100D_181E_118EE);
    label_100D_AEE4_1AFB4_16358:
        CheckExternalEvents(cs1, 0xAEE4);
        // 100D:AEE4 call near 0xDAA3
        NearCall(cs1, 0xAEE7, unknown_100D_DAA3_1DB73);
    label_100D_AEE7_1AFB7_16360:
        CheckExternalEvents(cs1, 0xAEE7);
        // 100D:AEE7 mov byte ptr DS:[0x00C6],1
        UInt8[DS, (ushort)0x00C6] = (byte)0x01;
        // 100D:AEEC call near 0xB2B9
        NearCall(cs1, 0xAEEF, unknown_100D_B2B9_1B389);
    label_100D_AEEF_1AFBF_16366:
        CheckExternalEvents(cs1, 0xAEEF);
        // 100D:AEEF call near 0xD95B
        NearCall(cs1, 0xAEF2, unknown_100D_D95B_1DA2B);
    label_100D_AEF2_1AFC2_16368:
        CheckExternalEvents(cs1, 0xAEF2);
        // 100D:AEF2 call near 0xAD5E
        NearCall(cs1, 0xAEF5, unknown_100D_AD5E_1AE2E);
    label_100D_AEF5_1AFC5_16370:
        CheckExternalEvents(cs1, 0xAEF5);
        // 100D:AEF5 mov AL,0x34
        AL = (byte)0x34;
        // 100D:AEF7 mov BP,0xAF26
        BP = (ushort)0xAF26;
        // 100D:AEFA call near 0xC108
        NearCall(cs1, 0xAEFD, unknown_100D_C108_1C1D8);
    label_100D_AEFD_1AFCD_16470:
        CheckExternalEvents(cs1, 0xAEFD);
        // 100D:AEFD jmp near 0xAE04
        return unknown_100D_AE04_1AED4(0x0000);
    }

    public virtual Action unknown_100D_AF00_1AFD0(int loadOffset)
    {
    label_100D_AF00_1AFD0_16384:
        CheckExternalEvents(cs1, 0xAF00);
        // 100D:AF00 mov BH,4
        BH = (byte)0x04;
    label_100D_AF02_1AFD2_16386:
        CheckExternalEvents(cs1, 0xAF02);
        // 100D:AF02 mov BL,0x1C
        BL = (byte)0x1C;
        // 100D:AF04 call near 0xB147
        NearCall(cs1, 0xAF07, unknown_100D_B147_1B217);
    label_100D_AF07_1AFD7_16414:
        CheckExternalEvents(cs1, 0xAF07);
        // 100D:AF07 mov AX,0x4000
        AX = (ushort)0x4000;
        // 100D:AF0A je short 0xAF0E
        if (ZeroFlag)
        {
            goto label_100D_AF0E_1AFDE_16419;
        }
    label_100D_AF0C_1AFDC_16417:
        CheckExternalEvents(cs1, 0xAF0C);
        // 100D:AF0C xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_100D_AF0E_1AFDE_16419:
        CheckExternalEvents(cs1, 0xAF0E);
        // 100D:AF0E xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:AF10 mov CL,BH
        CL = BH;
        // 100D:AF12 mov SI,0x2034
        SI = (ushort)0x2034;
        // 100D:AF15 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:AF17 and word ptr DS:[SI],0xBFFF
        UInt16[DS, SI] = Alu16.And(UInt16[DS, SI], (ushort)0xBFFF);
        // 100D:AF1B or word ptr DS:[SI],AX
        UInt16[DS, SI] = Alu16.Or(UInt16[DS, SI], AX);
        // 100D:AF1D add BH,4
        BH = Alu8.Add(BH, (byte)0x04);
        // 100D:AF20 cmp BH,0x0C
        Alu8.Sub(BH, (byte)0x0C);
        // 100D:AF23 jbe short 0xAF02
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_AF02_1AFD2_16386;
        }
    label_100D_AF25_1AFF5_16431:
        CheckExternalEvents(cs1, 0xAF25);
        // 100D:AF25 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AF26_1AFF6(int loadOffset)
    {
    label_100D_AF26_1AFF6_16374:
        CheckExternalEvents(cs1, 0xAF26);
        // 100D:AF26 call near 0xD7AD
        NearCall(cs1, 0xAF29, unknown_100D_D7AD_1D87D);
    label_100D_AF29_1AFF9_16379:
        CheckExternalEvents(cs1, 0xAF29);
        // 100D:AF29 mov SI,0x1E1A
        SI = (ushort)0x1E1A;
        // 100D:AF2C call near 0xD72B
        NearCall(cs1, 0xAF2F, unknown_100D_D72B_1D7FB);
    label_100D_AF2F_1AFFF_16382:
        CheckExternalEvents(cs1, 0xAF2F);
        // 100D:AF2F call near 0xAF00
        NearCall(cs1, 0xAF32, unknown_100D_AF00_1AFD0);
    label_100D_AF32_1B002_16433:
        CheckExternalEvents(cs1, 0xAF32);
        // 100D:AF32 mov word ptr DS:[0x2406],0
        UInt16[DS, (ushort)0x2406] = (ushort)0x0000;
        // 100D:AF38 mov BP,0x2032
        BP = (ushort)0x2032;
        // 100D:AF3B mov BX,0xD917
        BX = (ushort)0xD917;
        // 100D:AF3E xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:AF40 call near 0xD33A
        NearCall(cs1, 0xAF43, unknown_100D_D33A_1D40A);
        return unknown_100D_AF43_1B013(0x0000);
    }

    public virtual Action unknown_100D_AF43_1B013(int loadOffset)
    {
    label_100D_AF43_1B013_16453:
        CheckExternalEvents(cs1, 0xAF43);
        // 100D:AF43 or byte ptr DS:[0x00C6],2
        UInt8[DS, (ushort)0x00C6] = Alu8.Or(UInt8[DS, (ushort)0x00C6], (byte)0x02);
        // 100D:AF48 call near 0xC432
        NearCall(cs1, 0xAF4B, unknown_100D_C432_1C502);
    label_100D_AF4B_1B01B_16456:
        CheckExternalEvents(cs1, 0xAF4B);
        // 100D:AF4B mov AL,0x32
        AL = (byte)0x32;
        // 100D:AF4D call near 0xC2F2
        NearCall(cs1, 0xAF50, unknown_100D_C2F2_1C3C2);
    label_100D_AF50_1B020_16459:
        CheckExternalEvents(cs1, 0xAF50);
        // 100D:AF50 mov byte ptr DS:[0x1C30],0
        UInt8[DS, (ushort)0x1C30] = (byte)0x00;
        // 100D:AF55 jmp near 0x1797
        return unknown_100D_1797_11867(0x0000);
    }

    public virtual Action unknown_100D_AFB5_1B085(int loadOffset)
    {
    entrydispatcher:
    label_100D_AFB5_1B085_16503:
        CheckExternalEvents(cs1, 0xAFB5);
        // 100D:AFB5 mov CX,1
        CX = (ushort)0x0001;
        // 100D:AFB8 mov DX,2
        DX = (ushort)0x0002;
        // 100D:AFBB test byte ptr DS:[0x00C6],2
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x02);
        // 100D:AFC0 je short 0xAFE6
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_AFE6_1B0B6, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_AFC2_1B092_16507:
        CheckExternalEvents(cs1, 0xAFC2);
        // 100D:AFC2 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:AFC4 jmp short 0xAFE6
        if (JumpDispatcher.Jump(unknown_100D_AFE6_1B0B6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_AFC7_1B097(int loadOffset)
    {
    entrydispatcher:
    label_100D_AFC7_1B097_40161:
        CheckExternalEvents(cs1, 0xAFC7);
        // 100D:AFC7 test byte ptr DS:[0x00C6],2
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x02);
        // 100D:AFCC jne short 0xAFC6
        if (!ZeroFlag)
        {
            return unknown_100D_AFC6_1B096(0x0000);
        }
    label_100D_AFCE_1B09E_40166:
        CheckExternalEvents(cs1, 0xAFCE);
        // 100D:AFCE test byte ptr DS:[0x00C6],4
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x04);
        // 100D:AFD3 je short 0xAFE0
        if (ZeroFlag)
        {
            goto label_100D_AFE0_1B0B0_40169;
        }
    label_100D_AFD5_1B0A5_40171:
        CheckExternalEvents(cs1, 0xAFD5);
        // 100D:AFD5 add word ptr DS:[0x11BF],2
        UInt16[DS, (ushort)0x11BF] = Alu16.Add(UInt16[DS, (ushort)0x11BF], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:AFDA call near 0x0A3E
        NearCall(cs1, 0xAFDD, unknown_100D_0A3E_10B0E);
    label_100D_AFDD_1B0AD_40261:
        CheckExternalEvents(cs1, 0xAFDD);
        // 100D:AFDD call near 0xAD5E
        NearCall(cs1, 0xAFE0, unknown_100D_AD5E_1AE2E);
    label_100D_AFE0_1B0B0_40169:
        CheckExternalEvents(cs1, 0xAFE0);
        // 100D:AFE0 mov CX,1
        CX = (ushort)0x0001;
        // 100D:AFE3 mov DX,0xFFFE
        DX = (ushort)0xFFFE;
        if (JumpDispatcher.Jump(unknown_100D_AFE6_1B0B6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B024_1B0F4(int loadOffset)
    {
    entrydispatcher:
    label_100D_B024_1B0F4_17276:
        CheckExternalEvents(cs1, 0xB024);
        // 100D:B024 mov DH,0xFF
        DH = (byte)0xFF;
        // 100D:B026 call near 0xB1AF
        NearCall(cs1, 0xB029, unknown_100D_B1AF_1B27F);
    label_100D_B029_1B0F9_17282:
        CheckExternalEvents(cs1, 0xB029);
        // 100D:B029 mov BP,0xAF43
        BP = (ushort)0xAF43;
        if (JumpDispatcher.Jump(unknown_100D_B02C_1B0FC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B02C_1B0FC(int loadOffset)
    {
    entrydispatcher:
    label_100D_B02C_1B0FC_16558:
        CheckExternalEvents(cs1, 0xB02C);
        // 100D:B02C call near 0xAC14
        NearCall(cs1, 0xB02F, unknown_100D_AC14_1ACE4);
    label_100D_B02F_1B0FF_16560:
        CheckExternalEvents(cs1, 0xB02F);
        // 100D:B02F mov AL,2
        AL = (byte)0x02;
        // 100D:B031 call near 0xAB15
        NearCall(cs1, 0xB034, unknown_100D_AB15_1ABE5);
    label_100D_B034_1B104_16563:
        CheckExternalEvents(cs1, 0xB034);
        // 100D:B034 mov AL,0x0E
        AL = (byte)0x0E;
        // 100D:B036 jmp near 0xC108
        if (JumpDispatcher.Jump(unknown_100D_C108_1C1D8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B039_1B109(int loadOffset)
    {
    label_100D_B039_1B109_16566:
        CheckExternalEvents(cs1, 0xB039);
        // 100D:B039 and byte ptr DS:[0x00C6],0xF9
        UInt8[DS, (ushort)0x00C6] = Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0xF9);
        // 100D:B03E mov SI,0xA6B0
        SI = (ushort)0xA6B0;
        // 100D:B041 mov word ptr DS:[0x47BC],SI
        UInt16[DS, (ushort)0x47BC] = SI;
        // 100D:B045 push SI
        Stack.Push16(SI);
        // 100D:B046 mov SI,word ptr DS:[0x11BF]
        SI = UInt16[DS, (ushort)0x11BF];
        // 100D:B04A mov SI,word ptr CS:[SI]
        SI = UInt16[CS, SI];
        // 100D:B04D mov AX,SI
        AX = SI;
        // 100D:B04F call near 0xB254
        NearCall(cs1, 0xB052, unknown_100D_B254_1B324);
    label_100D_B052_1B122_16592:
        CheckExternalEvents(cs1, 0xB052);
        // 100D:B052 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:B054 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:B056 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:B058 mov AL,AH
        AL = AH;
        // 100D:B05A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:B05C add AX,0x00F3
        AX = Alu16.Add(AX, (ushort)0x00F3);
        // 100D:B05F call near 0xB126
        NearCall(cs1, 0xB062, unknown_100D_B126_1B1F6);
    label_100D_B062_1B132_16616:
        CheckExternalEvents(cs1, 0xB062);
        // 100D:B062 and SI,0x07FF
        SI = Alu16.And(SI, (ushort)0x07FF);
        // 100D:B066 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:B068 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:B06A add SI,0xAA7A
        SI = Alu16.Add(SI, (ushort)0xAA7A);
        // 100D:B06E mov word ptr DS:[0x477C],SI
        UInt16[DS, (ushort)0x477C] = SI;
        // 100D:B072 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:B073 pop SI
        SI = Stack.Pop16();
        // 100D:B074 push AX
        Stack.Push16(AX);
        // 100D:B075 xchg AL,AH
        byte temp_100D_B075_1B145 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_B075_1B145);
        // 100D:B077 and AH,3
        AH = Alu8.And(AH, (byte)0x03);
        // 100D:B07A or AH,8
        AH = Alu8.Or(AH, (byte)0x08);
        // 100D:B07D call near 0xB126
        NearCall(cs1, 0xB080, unknown_100D_B126_1B1F6);
    label_100D_B080_1B150_16635:
        CheckExternalEvents(cs1, 0xB080);
        // 100D:B080 mov DI,word ptr DS:[0x47BC]
        DI = UInt16[DS, (ushort)0x47BC];
        // 100D:B084 mov byte ptr DS:[DI-1],0xFF
        UInt8[DS, (ushort)(DI + (sbyte)-1)] = (byte)0xFF;
        // 100D:B088 call near 0x88E1
        NearCall(cs1, 0xB08B, unknown_100D_88E1_189B1);
    label_100D_B08B_1B15B_16743:
        CheckExternalEvents(cs1, 0xB08B);
        // 100D:B08B mov SI,0x2408
        SI = (ushort)0x2408;
        // 100D:B08E call near 0xC551
        NearCall(cs1, 0xB091, unknown_100D_C551_1C621);
    label_100D_B091_1B161_16833:
        CheckExternalEvents(cs1, 0xB091);
        // 100D:B091 call near 0x1797
        NearCall(cs1, 0xB094, unknown_100D_1797_11867);
    label_100D_B094_1B164_16835:
        CheckExternalEvents(cs1, 0xB094);
        // 100D:B094 mov AX,word ptr DS:[0xD82E]
        AX = UInt16[DS, (ushort)0xD82E];
        // 100D:B097 mov BX,0x008C
        BX = (ushort)0x008C;
        // 100D:B09A sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:B09C shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:B09E add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:B0A0 cmp BX,0x008A
        Alu16.Sub(BX, (ushort)0x008A);
        // 100D:B0A4 jae short 0xB0B5
        if (!CarryFlag)
        {
            goto label_100D_B0B5_1B185_16850;
        }
    label_100D_B0A6_1B176_16843:
        CheckExternalEvents(cs1, 0xB0A6);
        // 100D:B0A6 mov DX,0x0093
        DX = (ushort)0x0093;
        // 100D:B0A9 mov AX,0x0032
        AX = (ushort)0x0032;
        // 100D:B0AC call near 0xC13E
        NearCall(cs1, 0xB0AF, unknown_100D_C13E_1C20E);
    label_100D_B0AF_1B17F_16847:
        CheckExternalEvents(cs1, 0xB0AF);
        // 100D:B0AF mov AX,4
        AX = (ushort)0x0004;
        // 100D:B0B2 call near 0xC22F
        NearCall(cs1, 0xB0B5, unknown_100D_C22F_1C2FF);
    label_100D_B0B5_1B185_16850:
        CheckExternalEvents(cs1, 0xB0B5);
        // 100D:B0B5 pop AX
        AX = Stack.Pop16();
        // 100D:B0B6 cmp word ptr DS:[0x11BF],0x00AA
        Alu16.Sub(UInt16[DS, (ushort)0x11BF], (ushort)0x00AA);
        // 100D:B0BC je short 0xB0D4
        if (ZeroFlag)
        {
            goto label_100D_B0D4_1B1A4_16854;
        }
    label_100D_B0BE_1B18E_17368:
        CheckExternalEvents(cs1, 0xB0BE);
        // 100D:B0BE and AX,0x000C
        AX = Alu16.And(AX, (ushort)0x000C);
        // 100D:B0C1 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B0C3 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B0C5 add AX,0x0103
        AX = Alu16.Add(AX, (ushort)0x0103);
        // 100D:B0C8 mov BX,0x008B
        BX = (ushort)0x008B;
        // 100D:B0CB mov DX,0x00FA
        DX = (ushort)0x00FA;
        // 100D:B0CE mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:B0D1 call near 0xD194
        NearCall(cs1, 0xB0D4, unknown_100D_D194_1D264);
    label_100D_B0D4_1B1A4_16854:
        CheckExternalEvents(cs1, 0xB0D4);
        // 100D:B0D4 mov BX,3
        BX = (ushort)0x0003;
        // 100D:B0D7 mov DX,0x0132
        DX = (ushort)0x0132;
        // 100D:B0DA call near 0xD04E
        NearCall(cs1, 0xB0DD, unknown_100D_D04E_1D11E);
    label_100D_B0DD_1B1AD_16858:
        CheckExternalEvents(cs1, 0xB0DD);
        // 100D:B0DD mov word ptr DS:[0xDBE4],0x0053
        UInt16[DS, (ushort)0xDBE4] = (ushort)0x0053;
        // 100D:B0E3 mov AX,word ptr DS:[0x11BF]
        AX = UInt16[DS, (ushort)0x11BF];
        // 100D:B0E6 sub AX,0x00AA
        AX = Alu16.Sub(AX, (ushort)0x00AA);
        // 100D:B0E9 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B0EB inc AX
        AX = Alu16.Inc(AX);
        // 100D:B0EC aam
        byte v2_100D_B0EC_1B1BC = (byte)0x0A;
        byte v1_100D_B0EC_1B1BC = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_B0EC_1B1BC >> (byte)0x01)));
        if (v2_100D_B0EC_1B1BC == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_B0EC_1B1BC = unchecked((byte)(v1_100D_B0EC_1B1BC % v2_100D_B0EC_1B1BC));
        AH = unchecked((byte)(v1_100D_B0EC_1B1BC / v2_100D_B0EC_1B1BC));
        AL = unchecked((byte)result_100D_B0EC_1B1BC);
        Alu8.UpdateFlags(unchecked((byte)result_100D_B0EC_1B1BC));
        // 100D:B0EE add AX,0x3030
        AX = Alu16.Add(AX, (ushort)0x3030);
        // 100D:B0F1 xchg AL,AH
        byte temp_100D_B0F1_1B1C1 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_B0F1_1B1C1);
        // 100D:B0F3 cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:B0F5 jne short 0xB0F9
        if (!ZeroFlag)
        {
            goto label_100D_B0F9_1B1C9_16871;
        }
    label_100D_B0F7_1B1C7_16869:
        CheckExternalEvents(cs1, 0xB0F7);
        // 100D:B0F7 mov AL,0x20
        AL = (byte)0x20;
    label_100D_B0F9_1B1C9_16871:
        CheckExternalEvents(cs1, 0xB0F9);
        // 100D:B0F9 push AX
        Stack.Push16(AX);
        // 100D:B0FA call near 0xD12F
        NearCall(cs1, 0xB0FD, unknown_100D_D12F_1D1FF);
    label_100D_B0FD_1B1CD_16873:
        CheckExternalEvents(cs1, 0xB0FD);
        // 100D:B0FD pop AX
        AX = Stack.Pop16();
        // 100D:B0FE mov AL,AH
        AL = AH;
        // 100D:B100 call near 0xD12F
        NearCall(cs1, 0xB103, unknown_100D_D12F_1D1FF);
    label_100D_B103_1B1D3_16877:
        CheckExternalEvents(cs1, 0xB103);
        // 100D:B103 mov byte ptr DS:[0x1C30],0
        UInt8[DS, (ushort)0x1C30] = (byte)0x00;
        // 100D:B108 mov AX,word ptr DS:[0x243E]
        AX = UInt16[DS, (ushort)0x243E];
        // 100D:B10B or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:B10D je short 0xB125
        if (ZeroFlag)
        {
            goto label_100D_B125_1B1F5_16890;
        }
    label_100D_B10F_1B1DF_16882:
        CheckExternalEvents(cs1, 0xB10F);
        // 100D:B10F mov byte ptr DS:[0x1C30],0x80
        UInt8[DS, (ushort)0x1C30] = (byte)0x80;
        // 100D:B114 mov SI,0x2412
        SI = (ushort)0x2412;
        // 100D:B117 add AX,0xFFF5
        AX = Alu16.Add(AX, (ushort)0xFFF5);
        // 100D:B11A mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:B11C mov word ptr DS:[SI+6],AX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = AX;
        // 100D:B11F mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
        // 100D:B122 call near 0xC21B
        NearCall(cs1, 0xB125, unknown_100D_C21B_1C2EB);
    label_100D_B125_1B1F5_16890:
        CheckExternalEvents(cs1, 0xB125);
        // 100D:B125 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B126_1B1F6(int loadOffset)
    {
    label_100D_B126_1B1F6_16600:
        CheckExternalEvents(cs1, 0xB126);
        // 100D:B126 push SI
        Stack.Push16(SI);
        // 100D:B127 mov SI,AX
        SI = AX;
        // 100D:B129 call near 0xCF70
        NearCall(cs1, 0xB12C, unknown_100D_CF70_1D040);
    label_100D_B12C_1B1FC_16604:
        CheckExternalEvents(cs1, 0xB12C);
        // 100D:B12C mov DI,word ptr DS:[0x47BC]
        DI = UInt16[DS, (ushort)0x47BC];
        // 100D:B130 push DI
        Stack.Push16(DI);
        // 100D:B131 call near 0x88F1
        NearCall(cs1, 0xB134, unknown_100D_88F1_189C1);
    label_100D_B134_1B204_16608:
        CheckExternalEvents(cs1, 0xB134);
        // 100D:B134 pop DI
        DI = Stack.Pop16();
        // 100D:B135 cmp byte ptr DS:[SI],0x20
        Alu8.Sub(UInt8[DS, SI], (byte)0x20);
        // 100D:B138 je short 0xB141
        if (ZeroFlag)
        {
            goto label_100D_B141_1B211_16612;
        }
    label_100D_B13A_1B20A_16629:
        CheckExternalEvents(cs1, 0xB13A);
        // 100D:B13A call near 0x8944
        NearCall(cs1, 0xB13D, unknown_100D_8944_18A14);
    label_100D_B13D_1B20D_16631:
        CheckExternalEvents(cs1, 0xB13D);
        // 100D:B13D dec DI
        DI = Alu16.Dec(DI);
        // 100D:B13E mov AL,0x20
        AL = (byte)0x20;
        // 100D:B140 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_100D_B141_1B211_16612:
        CheckExternalEvents(cs1, 0xB141);
        // 100D:B141 mov word ptr DS:[0x47BC],DI
        UInt16[DS, (ushort)0x47BC] = DI;
        // 100D:B145 pop SI
        SI = Stack.Pop16();
        // 100D:B146 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B147_1B217(int loadOffset)
    {
    label_100D_B147_1B217_16388:
        CheckExternalEvents(cs1, 0xB147);
        // 100D:B147 mov SI,0x00A8
        SI = (ushort)0x00A8;
        // 100D:B14A mov DX,2
        DX = (ushort)0x0002;
        // 100D:B14D mov CX,1
        CX = (ushort)0x0001;
        return unknown_100D_B150_1B220(0x0000);
    }

    public virtual Action unknown_100D_B150_1B220(int loadOffset)
    {
    label_100D_B150_1B220_16392:
        CheckExternalEvents(cs1, 0xB150);
        // 100D:B150 xor DI,DI
        DI = Alu16.Xor(DI, DI);
    label_100D_B152_1B222_16393:
        CheckExternalEvents(cs1, 0xB152);
        // 100D:B152 add SI,DX
        SI = Alu16.Add(SI, DX);
        // 100D:B154 or DX,2
        DX = Alu16.Or(DX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:B157 mov BP,word ptr CS:[SI]
        BP = UInt16[CS, SI];
        // 100D:B15A and BP,0x07FF
        BP = Alu16.And(BP, (ushort)0x07FF);
        // 100D:B15E je short 0xB177
        if (ZeroFlag)
        {
            goto label_100D_B177_1B247_16411;
        }
    label_100D_B160_1B230_16398:
        CheckExternalEvents(cs1, 0xB160);
        // 100D:B160 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B162 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B164 add BP,0xAA78
        BP = Alu16.Add(BP, (ushort)0xAA78);
        // 100D:B168 mov AL,byte ptr SS:[BP+2]
        AL = UInt8[SS, (ushort)(BP + (sbyte)2)];
        // 100D:B16B and AL,BL
        AL = Alu8.And(AL, BL);
        // 100D:B16D je short 0xB173
        if (ZeroFlag)
        {
            goto label_100D_B173_1B243_16408;
        }
    label_100D_B16F_1B23F_16405:
        CheckExternalEvents(cs1, 0xB16F);
        // 100D:B16F cmp AL,BH
        Alu8.Sub(AL, BH);
        // 100D:B171 jne short 0xB152
        if (!ZeroFlag)
        {
            goto label_100D_B152_1B222_16393;
        }
    label_100D_B173_1B243_16408:
        CheckExternalEvents(cs1, 0xB173);
        // 100D:B173 mov DI,SI
        DI = SI;
        // 100D:B175 loop 0xB152
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B152_1B222_16393;
        }
    label_100D_B177_1B247_16411:
        CheckExternalEvents(cs1, 0xB177);
        // 100D:B177 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:B179 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B17A_1B24A(int loadOffset)
    {
    label_100D_B17A_1B24A_3141:
        CheckExternalEvents(cs1, 0xB17A);
        // 100D:B17A mov AL,byte ptr DS:[0x00C6]
        AL = UInt8[DS, (ushort)0x00C6];
        // 100D:B17D push AX
        Stack.Push16(AX);
        // 100D:B17E or AL,0x80
        AL = Alu8.Or(AL, (byte)0x80);
        // 100D:B180 mov byte ptr DS:[0x00C6],AL
        UInt8[DS, (ushort)0x00C6] = AL;
        // 100D:B183 call near 0x96B5
        NearCall(cs1, 0xB186, unknown_100D_96B5_19785);
    label_100D_B186_1B256_3298:
        CheckExternalEvents(cs1, 0xB186);
        // 100D:B186 pop AX
        AX = Stack.Pop16();
        // 100D:B187 mov byte ptr DS:[0x00C6],AL
        UInt8[DS, (ushort)0x00C6] = AL;
        // 100D:B18A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B1AF_1B27F(int loadOffset)
    {
    label_100D_B1AF_1B27F_16520:
        CheckExternalEvents(cs1, 0xB1AF);
        // 100D:B1AF push DX
        Stack.Push16(DX);
        // 100D:B1B0 call near 0xC08E
        NearCall(cs1, 0xB1B3, unknown_100D_C08E_1C15E);
    label_100D_B1B3_1B283_16523:
        CheckExternalEvents(cs1, 0xB1B3);
        // 100D:B1B3 call near 0xC137
        NearCall(cs1, 0xB1B6, unknown_100D_C137_1C207);
    label_100D_B1B6_1B286_16525:
        CheckExternalEvents(cs1, 0xB1B6);
        // 100D:B1B6 mov AX,0x000B
        AX = (ushort)0x000B;
        // 100D:B1B9 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:B1BB js short 0xB1BE
        if (SignFlag)
        {
            goto label_100D_B1BE_1B28E_16531;
        }
    label_100D_B1BD_1B28D_16529:
        CheckExternalEvents(cs1, 0xB1BD);
        // 100D:B1BD dec AX
        AX = Alu16.Dec(AX);
    label_100D_B1BE_1B28E_16531:
        CheckExternalEvents(cs1, 0xB1BE);
        // 100D:B1BE mov BX,0x009E
        BX = (ushort)0x009E;
        // 100D:B1C1 mov DX,0x001B
        DX = (ushort)0x001B;
        // 100D:B1C4 push AX
        Stack.Push16(AX);
        // 100D:B1C5 call near 0xC2FD
        NearCall(cs1, 0xB1C8, unknown_100D_C2FD_1C3CD);
    label_100D_B1C8_1B298_16535:
        CheckExternalEvents(cs1, 0xB1C8);
        // 100D:B1C8 mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:B1CB call near 0xE387
        NearCall(cs1, 0xB1CE, unknown_100D_E387_1E457);
    label_100D_B1CE_1B29E_16538:
        CheckExternalEvents(cs1, 0xB1CE);
        // 100D:B1CE pop AX
        AX = Stack.Pop16();
        // 100D:B1CF inc AX
        AX = Alu16.Inc(AX);
        // 100D:B1D0 cmp AX,0x000B
        Alu16.Sub(AX, (ushort)0x000B);
        // 100D:B1D3 je short 0xB1D8
        if (ZeroFlag)
        {
            goto label_100D_B1D8_1B2A8_16543;
        }
    label_100D_B1D5_1B2A5_17280:
        CheckExternalEvents(cs1, 0xB1D5);
        // 100D:B1D5 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
    label_100D_B1D8_1B2A8_16543:
        CheckExternalEvents(cs1, 0xB1D8);
        // 100D:B1D8 call near 0xC22F
        NearCall(cs1, 0xB1DB, unknown_100D_C22F_1C2FF);
    label_100D_B1DB_1B2AB_16545:
        CheckExternalEvents(cs1, 0xB1DB);
        // 100D:B1DB mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:B1DE call near 0xE387
        NearCall(cs1, 0xB1E1, unknown_100D_E387_1E457);
    label_100D_B1E1_1B2B1_16548:
        CheckExternalEvents(cs1, 0xB1E1);
        // 100D:B1E1 mov SI,0x1AF4
        SI = (ushort)0x1AF4;
        // 100D:B1E4 mov CX,1
        CX = (ushort)0x0001;
        // 100D:B1E7 call near 0xD1F2
        NearCall(cs1, 0xB1EA, unknown_100D_D1F2_1D2C2);
    label_100D_B1EA_1B2BA_16552:
        CheckExternalEvents(cs1, 0xB1EA);
        // 100D:B1EA pop DX
        DX = Stack.Pop16();
        // 100D:B1EB jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_B1EE_1B2BE(int loadOffset)
    {
    label_100D_B1EE_1B2BE_17125:
        CheckExternalEvents(cs1, 0xB1EE);
        // 100D:B1EE call far dword ptr DS:[0x3959]
        ushort targetSegment_17125 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_17125 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_17125 == cs2 && targetOffset_17125 == 0x017B)
        {
            FarCall(cs1, 0xB1F2, cs2, unknown_3358_017B_336FB);
            goto label_100D_B1F2_1B2C2_17127;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_17125:X4}:{targetOffset_17125:X4} at 100D:B1EE");
    label_100D_B1F2_1B2C2_17127:
        CheckExternalEvents(cs1, 0xB1F2);
        // 100D:B1F2 call near 0xAEB7
        NearCall(cs1, 0xB1F5, unknown_100D_AEB7_1AF87);
    label_100D_B1F5_1B2C5_17129:
        CheckExternalEvents(cs1, 0xB1F5);
        // 100D:B1F5 mov byte ptr DS:[0xDC2B],1
        UInt8[DS, (ushort)0xDC2B] = (byte)0x01;
        // 100D:B1FA mov AL,0x34
        AL = (byte)0x34;
        // 100D:B1FC mov BP,0xB236
        BP = (ushort)0xB236;
        // 100D:B1FF call near 0xC108
        NearCall(cs1, 0xB202, unknown_100D_C108_1C1D8);
    label_100D_B202_1B2D2_17139:
        CheckExternalEvents(cs1, 0xB202);
        // 100D:B202 call near 0xC08E
        NearCall(cs1, 0xB205, unknown_100D_C08E_1C15E);
    label_100D_B205_1B2D5_17141:
        CheckExternalEvents(cs1, 0xB205);
        // 100D:B205 mov byte ptr DS:[0xCE80],0
        UInt8[DS, (ushort)0xCE80] = (byte)0x00;
        // 100D:B20A call near 0xDE4E
        NearCall(cs1, 0xB20D, unknown_100D_DE4E_1DF1E);
    label_100D_B20D_1B2DD_17144:
        CheckExternalEvents(cs1, 0xB20D);
        // 100D:B20D call near 0xC9E8
        NearCall(cs1, 0xB210, unknown_100D_C9E8_1CAB8);
    label_100D_B210_1B2E0_17146:
        CheckExternalEvents(cs1, 0xB210);
        // 100D:B210 jb short 0xB217
        if (CarryFlag)
        {
            goto label_100D_B217_1B2E7_17204;
        }
    label_100D_B212_1B2E2_17148:
        CheckExternalEvents(cs1, 0xB212);
        // 100D:B212 call near 0xCC85
        NearCall(cs1, 0xB215, unknown_100D_CC85_1CD55);
    label_100D_B215_1B2E5_17150:
        CheckExternalEvents(cs1, 0xB215);
        // 100D:B215 je short 0xB20D
        if (ZeroFlag)
        {
            goto label_100D_B20D_1B2DD_17144;
        }
    label_100D_B217_1B2E7_17204:
        CheckExternalEvents(cs1, 0xB217);
        // 100D:B217 call near 0xCA01
        NearCall(cs1, 0xB21A, unknown_100D_CA01_1CAD1);
    label_100D_B21A_1B2EA_17206:
        CheckExternalEvents(cs1, 0xB21A);
        // 100D:B21A inc byte ptr DS:[0xCE80]
        UInt8[DS, (ushort)0xCE80] = Alu8.Inc(UInt8[DS, (ushort)0xCE80]);
        // 100D:B21E call near 0xAC14
        NearCall(cs1, 0xB221, unknown_100D_AC14_1ACE4);
    label_100D_B221_1B2F1_17209:
        CheckExternalEvents(cs1, 0xB221);
        // 100D:B221 call near 0xC07C
        NearCall(cs1, 0xB224, unknown_100D_C07C_1C14C);
    label_100D_B224_1B2F4_17211:
        CheckExternalEvents(cs1, 0xB224);
        // 100D:B224 call far dword ptr DS:[0x3969]
        ushort targetSegment_17211 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3969 + (ushort)0x0002)]));
        ushort targetOffset_17211 = unchecked((ushort)(UInt16[DS, (ushort)0x3969]));
        if (targetSegment_17211 == cs2 && targetOffset_17211 == 0x0187)
        {
            FarCall(cs1, 0xB228, cs2, unknown_3358_0187_33707);
            goto label_100D_B228_1B2F8_17247;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_17211:X4}:{targetOffset_17211:X4} at 100D:B224");
    label_100D_B228_1B2F8_17247:
        CheckExternalEvents(cs1, 0xB228);
        // 100D:B228 mov AL,0x34
        AL = (byte)0x34;
        // 100D:B22A mov BP,0xB23F
        BP = (ushort)0xB23F;
        // 100D:B22D call near 0xC108
        NearCall(cs1, 0xB230, unknown_100D_C108_1C1D8);
    label_100D_B230_1B300_17263:
        CheckExternalEvents(cs1, 0xB230);
        // 100D:B230 call near 0xC412
        NearCall(cs1, 0xB233, unknown_100D_C412_1C4E2);
    label_100D_B233_1B303_17265:
        CheckExternalEvents(cs1, 0xB233);
        // 100D:B233 jmp near 0xABC6
        return unknown_100D_ABC6_1AC96(0x0000);
    }

    public virtual Action unknown_100D_B236_1B306(int loadOffset)
    {
    entrydispatcher:
    label_100D_B236_1B306_17134:
        CheckExternalEvents(cs1, 0xB236);
        // 100D:B236 call near 0xC0AD
        NearCall(cs1, 0xB239, unknown_100D_C0AD_1C17D);
    label_100D_B239_1B309_17136:
        CheckExternalEvents(cs1, 0xB239);
        // 100D:B239 mov AX,word ptr DS:[0x243E]
        AX = UInt16[DS, (ushort)0x243E];
        // 100D:B23C jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B23F_1B30F(int loadOffset)
    {
    label_100D_B23F_1B30F_17251:
        CheckExternalEvents(cs1, 0xB23F);
        // 100D:B23F call near 0xC0AD
        NearCall(cs1, 0xB242, unknown_100D_C0AD_1C17D);
    label_100D_B242_1B312_17253:
        CheckExternalEvents(cs1, 0xB242);
        // 100D:B242 mov CX,0x0012
        CX = (ushort)0x0012;
        // 100D:B245 mov SI,0x1AE6
        SI = (ushort)0x1AE6;
        // 100D:B248 call near 0xD1F2
        NearCall(cs1, 0xB24B, unknown_100D_D1F2_1D2C2);
    label_100D_B24B_1B31B_17257:
        CheckExternalEvents(cs1, 0xB24B);
        // 100D:B24B call near 0xD397
        NearCall(cs1, 0xB24E, unknown_100D_D397_1D467);
    label_100D_B24E_1B31E_17259:
        CheckExternalEvents(cs1, 0xB24E);
        // 100D:B24E call near 0xB039
        NearCall(cs1, 0xB251, unknown_100D_B039_1B109);
    label_100D_B251_1B321_17261:
        CheckExternalEvents(cs1, 0xB251);
        // 100D:B251 jmp near 0x9901
        return unknown_100D_9901_199D1(0x0000);
    }

    public virtual Action unknown_100D_B254_1B324(int loadOffset)
    {
    label_100D_B254_1B324_16575:
        CheckExternalEvents(cs1, 0xB254);
        // 100D:B254 push AX
        Stack.Push16(AX);
        // 100D:B255 push SI
        Stack.Push16(SI);
        // 100D:B256 push DS
        Stack.Push16(DS);
        // 100D:B257 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B258 mov DI,0x2426
        DI = (ushort)0x2426;
        // 100D:B25B mov CX,0x000C
        CX = (ushort)0x000C;
        // 100D:B25E repne scas AX,word ptr ES:[DI]
        bool shouldContinue_100D_B25E_1B32E = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_B25E_1B32E)
        {
            Alu16.Sub(AX, UInt16[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_B25E_1B32E = ZeroFlag == false;
        }
        // 100D:B260 mov AX,0
        AX = (ushort)0x0000;
        // 100D:B263 jne short 0xB26A
        if (!ZeroFlag)
        {
            goto label_100D_B26A_1B33A_16588;
        }
    label_100D_B265_1B335_16585:
        CheckExternalEvents(cs1, 0xB265);
        // 100D:B265 mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:B268 sub AX,CX
        AX = Alu16.Sub(AX, CX);
    label_100D_B26A_1B33A_16588:
        CheckExternalEvents(cs1, 0xB26A);
        // 100D:B26A mov word ptr DS:[0x243E],AX
        UInt16[DS, (ushort)0x243E] = AX;
        // 100D:B26D pop SI
        SI = Stack.Pop16();
        // 100D:B26E pop AX
        AX = Stack.Pop16();
        // 100D:B26F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B2AA_1B37A(int loadOffset)
    {
    entrydispatcher:
    label_100D_B2AA_1B37A_19346:
        CheckExternalEvents(cs1, 0xB2AA);
        // 100D:B2AA call near 0xB2B9
        NearCall(cs1, 0xB2AD, unknown_100D_B2B9_1B389);
    label_100D_B2AD_1B37D_19348:
        CheckExternalEvents(cs1, 0xB2AD);
        // 100D:B2AD mov BX,0xB2B3
        BX = (ushort)0xB2B3;
        // 100D:B2B0 jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B2B3_1B383(int loadOffset)
    {
    label_100D_B2B3_1B383_19493:
        CheckExternalEvents(cs1, 0xB2B3);
        // 100D:B2B3 dec byte ptr DS:[0x2788]
        UInt8[DS, (ushort)0x2788] = Alu8.Dec(UInt8[DS, (ushort)0x2788]);
        // 100D:B2B7 jns short 0xB2BD
        if (!SignFlag)
        {
            return unknown_100D_B2BD_1B38D(0x0000);
        }
        else
        {
            return unknown_100D_B2B9_1B389(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_B2B9_1B389(int loadOffset)
    {
    label_100D_B2B9_1B389_16363:
        CheckExternalEvents(cs1, 0xB2B9);
        // 100D:B2B9 inc byte ptr DS:[0x2788]
        UInt8[DS, (ushort)0x2788] = Alu8.Inc(UInt8[DS, (ushort)0x2788]);
        return unknown_100D_B2BD_1B38D(0x0000);
    }

    public virtual Action unknown_100D_B2BE_1B38E(int loadOffset)
    {
    label_100D_B2BE_1B38E_14614:
        CheckExternalEvents(cs1, 0xB2BE);
        // 100D:B2BE mov byte ptr DS:[0x2788],0
        UInt8[DS, (ushort)0x2788] = (byte)0x00;
        // 100D:B2C3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B2C4_1B394(int loadOffset)
    {
    label_100D_B2C4_1B394_19389:
        CheckExternalEvents(cs1, 0xB2C4);
        // 100D:B2C4 cmp byte ptr DS:[0x38AF],0x32
        Alu8.Sub(UInt8[DS, (ushort)0x38AF], (byte)0x32);
        // 100D:B2C9 ja short 0xB30E
        if (!CarryFlag && !ZeroFlag)
        {
            return unknown_100D_B30E_1B3DE(0x0000);
        }
    label_100D_B2CB_1B39B_19392:
        CheckExternalEvents(cs1, 0xB2CB);
        // 100D:B2CB mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        return unknown_100D_B2CD_1B39D(0x0000);
    }

    public virtual Action unknown_100D_B2CD_1B39D(int loadOffset)
    {
    label_100D_B2CD_1B39D_19394:
        CheckExternalEvents(cs1, 0xB2CD);
        // 100D:B2CD call near 0xE270
        NearCall(cs1, 0xB2D0, unknown_100D_E270_1E340);
    label_100D_B2D0_1B3A0_19395:
        CheckExternalEvents(cs1, 0xB2D0);
        // 100D:B2D0 push ES
        Stack.Push16(ES);
        // 100D:B2D1 and AX,0x0FFF
        AX = Alu16.And(AX, (ushort)0x0FFF);
        // 100D:B2D4 mov SI,AX
        SI = AX;
        // 100D:B2D6 call near 0xCF70
        NearCall(cs1, 0xB2D9, unknown_100D_CF70_1D040);
    label_100D_B2D9_1B3A9_19400:
        CheckExternalEvents(cs1, 0xB2D9);
        // 100D:B2D9 call near 0xD03C
        NearCall(cs1, 0xB2DC, unknown_100D_D03C_1D10C);
    label_100D_B2DC_1B3AC_19402:
        CheckExternalEvents(cs1, 0xB2DC);
        // 100D:B2DC call near 0xD03C
        NearCall(cs1, 0xB2DF, unknown_100D_D03C_1D10C);
    label_100D_B2DF_1B3AF_19404:
        CheckExternalEvents(cs1, 0xB2DF);
        // 100D:B2DF mov AX,word ptr DS:[0xD816]
        AX = UInt16[DS, (ushort)0xD816];
        // 100D:B2E2 push AX
        Stack.Push16(AX);
        // 100D:B2E3 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 100D:B2E6 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B2E8 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B2EA shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B2EC shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B2EE inc AX
        AX = Alu16.Inc(AX);
        // 100D:B2EF call near 0xE2E3
        NearCall(cs1, 0xB2F2, unknown_100D_E2E3_1E3B3);
    label_100D_B2F2_1B3C2_19414:
        CheckExternalEvents(cs1, 0xB2F2);
        // 100D:B2F2 lea DI,SI+3
        DI = unchecked((ushort)(SI + (sbyte)3));
        // 100D:B2F5 mov SI,0x0117
        SI = (ushort)0x0117;
        // 100D:B2F8 call near 0xCF70
        NearCall(cs1, 0xB2FB, unknown_100D_CF70_1D040);
    label_100D_B2FB_1B3CB_19418:
        CheckExternalEvents(cs1, 0xB2FB);
        // 100D:B2FB pop AX
        AX = Stack.Pop16();
        // 100D:B2FC and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:B2FE mov AH,0x0A
        AH = (byte)0x0A;
        // 100D:B300 mul AH
        ushort result_100D_B300_1B3D0 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_B300_1B3D0 >> 8));
        AL = unchecked((byte)result_100D_B300_1B3D0);
        // 100D:B302 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:B304 mov CX,0x000A
        CX = (ushort)0x000A;
        // 100D:B307 rep movs byte ptr ES:[DI],byte ptr ES:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[ES, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B30A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B30B call near 0xE283
        NearCall(cs1, 0xB30E, unknown_100D_E283_1E353);
        return unknown_100D_B30E_1B3DE(0x0000);
    }

    public virtual Action unknown_100D_B30F_1B3DF(int loadOffset)
    {
    label_100D_B30F_1B3DF_19363:
        CheckExternalEvents(cs1, 0xB30F);
        // 100D:B30F mov DI,0x38A8
        DI = (ushort)0x38A8;
        // 100D:B312 mov byte ptr DS:[DI+7],0x31
        UInt8[DS, (ushort)(DI + (sbyte)7)] = (byte)0x31;
    label_100D_B316_1B3E6_19366:
        CheckExternalEvents(cs1, 0xB316);
        // 100D:B316 mov DX,DI
        DX = DI;
        // 100D:B318 call near 0xF2FC
        NearCall(cs1, 0xB31B, unknown_100D_F2FC_1F3CC);
    label_100D_B31B_1B3EB_19368:
        CheckExternalEvents(cs1, 0xB31B);
        // 100D:B31B mov AX,0x3D00
        AX = (ushort)0x3D00;
        // 100D:B31E int 0x21
        InterruptCall(cs1, 0xB320, unchecked((byte)((byte)0x21)));
    label_100D_B320_1B3F0_19371:
        CheckExternalEvents(cs1, 0xB320);
        // 100D:B320 jb short 0xB33C
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:B320");
        }
    label_100D_B322_1B3F2_19373:
        CheckExternalEvents(cs1, 0xB322);
        // 100D:B322 mov BX,AX
        BX = AX;
        // 100D:B324 mov DX,0xD816
        DX = (ushort)0xD816;
        // 100D:B327 push CX
        Stack.Push16(CX);
        // 100D:B328 mov CX,2
        CX = (ushort)0x0002;
        // 100D:B32B mov AH,0x3F
        AH = (byte)0x3F;
        // 100D:B32D int 0x21
        InterruptCall(cs1, 0xB32F, unchecked((byte)((byte)0x21)));
    label_100D_B32F_1B3FF_19380:
        CheckExternalEvents(cs1, 0xB32F);
        // 100D:B32F cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:B331 pop CX
        CX = Stack.Pop16();
        // 100D:B332 jb short 0xB33C
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:B332");
        }
    label_100D_B334_1B404_19384:
        CheckExternalEvents(cs1, 0xB334);
        // 100D:B334 mov AH,0x3E
        AH = (byte)0x3E;
        // 100D:B336 int 0x21
        InterruptCall(cs1, 0xB338, unchecked((byte)((byte)0x21)));
    label_100D_B338_1B408_19387:
        CheckExternalEvents(cs1, 0xB338);
        // 100D:B338 call near 0xB2C4
        NearCall(cs1, 0xB33B, unknown_100D_B2C4_1B394);
    label_100D_B33B_1B40B_19430:
        CheckExternalEvents(cs1, 0xB33B);
        // 100D:B33B clc
        CarryFlag = false;
        // 100D:B33C sbb AX,AX
        AX = Alu16.Sbb(AX, AX);
        // 100D:B33E cmp CH,0x80
        Alu8.Sub(CH, (byte)0x80);
        // 100D:B341 jne short 0xB345
        if (!ZeroFlag)
        {
            goto label_100D_B345_1B415_19437;
        }
    label_100D_B343_1B413_19435:
        CheckExternalEvents(cs1, 0xB343);
        // 100D:B343 not AX
        AX = unchecked((ushort)~AX);
    label_100D_B345_1B415_19437:
        CheckExternalEvents(cs1, 0xB345);
        // 100D:B345 and AX,CX
        AX = Alu16.And(AX, CX);
        // 100D:B347 and word ptr DS:[SI],0x3FFF
        UInt16[DS, SI] = Alu16.And(UInt16[DS, SI], (ushort)0x3FFF);
        // 100D:B34B or word ptr DS:[SI],AX
        UInt16[DS, SI] = Alu16.Or(UInt16[DS, SI], AX);
        // 100D:B34D add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:B350 inc byte ptr DS:[DI+7]
        UInt8[DS, (ushort)(DI + (sbyte)7)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (sbyte)7)]);
        // 100D:B353 cmp word ptr DS:[SI],0x00A3
        Alu16.Sub(UInt16[DS, SI], (ushort)0x00A3);
        // 100D:B357 jne short 0xB316
        if (!ZeroFlag)
        {
            goto label_100D_B316_1B3E6_19366;
        }
    label_100D_B359_1B429_19445:
        CheckExternalEvents(cs1, 0xB359);
        // 100D:B359 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B389_1B459(int loadOffset)
    {
    label_100D_B389_1B459_13059:
        CheckExternalEvents(cs1, 0xB389);
        // 100D:B389 add CL,0x31
        CL = Alu8.Add(CL, (byte)0x31);
        // 100D:B38C mov byte ptr DS:[0x38AF],CL
        UInt8[DS, (ushort)0x38AF] = CL;
        // 100D:B390 call near 0xB427
        NearCall(cs1, 0xB393, unknown_100D_B427_1B4F7);
    label_100D_B393_1B463_13106:
        CheckExternalEvents(cs1, 0xB393);
        // 100D:B393 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:B396 push DS
        Stack.Push16(DS);
        // 100D:B397 push ES
        Stack.Push16(ES);
        // 100D:B398 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B399 mov SI,DI
        SI = DI;
        // 100D:B39B xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:B39D stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:B39E call near 0xB4EA
        NearCall(cs1, 0xB3A1, unknown_100D_B4EA_1B5BA);
    label_100D_B3A1_1B471_13164:
        CheckExternalEvents(cs1, 0xB3A1);
        // 100D:B3A1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B3A2 mov DX,0x38A8
        DX = (ushort)0x38A8;
        // 100D:B3A5 call near 0xF2FC
        NearCall(cs1, 0xB3A8, unknown_100D_F2FC_1F3CC);
    label_100D_B3A8_1B478_13168:
        CheckExternalEvents(cs1, 0xB3A8);
        // 100D:B3A8 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:B3AA add CX,2
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:B3AD jmp near 0xF27C
    label_100D_F27C_1F34C_13172:
        CheckExternalEvents(cs1, 0xF27C);
        // 100D:F27C push CX
        Stack.Push16(CX);
        // 100D:F27D mov AH,0x3C
        AH = (byte)0x3C;
        // 100D:F27F xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:F281 int 0x21
        InterruptCall(cs1, 0xF283, unchecked((byte)((byte)0x21)));
    label_100D_F283_1F353_13177:
        CheckExternalEvents(cs1, 0xF283);
        // 100D:F283 pop CX
        CX = Stack.Pop16();
        // 100D:F284 jb short 0xF29A
        if (CarryFlag)
        {
            goto label_100D_F29A_1F36A_13196;
        }
    label_100D_F286_1F356_13180:
        CheckExternalEvents(cs1, 0xF286);
        // 100D:F286 mov BX,AX
        BX = AX;
        // 100D:F288 push DS
        Stack.Push16(DS);
        // 100D:F289 push ES
        Stack.Push16(ES);
        // 100D:F28A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F28B mov DX,DI
        DX = DI;
        // 100D:F28D mov AH,0x40
        AH = (byte)0x40;
        // 100D:F28F int 0x21
        InterruptCall(cs1, 0xF291, unchecked((byte)((byte)0x21)));
    label_100D_F291_1F361_13188:
        CheckExternalEvents(cs1, 0xF291);
        // 100D:F291 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F292 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:F294 pushf
        Stack.Push16(FlagRegister16);
        // 100D:F295 mov AH,0x3E
        AH = (byte)0x3E;
        // 100D:F297 int 0x21
        InterruptCall(cs1, 0xF299, unchecked((byte)((byte)0x21)));
    label_100D_F299_1F369_13194:
        CheckExternalEvents(cs1, 0xF299);
        // 100D:F299 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_F29A_1F36A_13196:
        CheckExternalEvents(cs1, 0xF29A);
        // 100D:F29A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B427_1B4F7(int loadOffset)
    {
    label_100D_B427_1B4F7_13063:
        CheckExternalEvents(cs1, 0xB427);
        // 100D:B427 mov CX,0x0578
        CX = (ushort)0x0578;
        // 100D:B42A call near 0xF11C
        NearCall(cs1, 0xB42D, unknown_100D_F11C_1F1EC);
    label_100D_B42D_1B4FD_13066:
        CheckExternalEvents(cs1, 0xB42D);
        // 100D:B42D mov DI,0x0100
        DI = (ushort)0x0100;
        // 100D:B430 push DI
        Stack.Push16(DI);
        // 100D:B431 push ES
        Stack.Push16(ES);
        // 100D:B432 push DS
        Stack.Push16(DS);
        // 100D:B433 lds SI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_B433_1B503 = (ushort)0xDCFE;
        ushort lxsValue_100D_B433_1B503 = UInt16[DS, lxsOffset_100D_B433_1B503];
        ushort lxsSegment_100D_B433_1B503 = UInt16[DS, (ushort)(lxsOffset_100D_B433_1B503 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_B433_1B503);
        DS = unchecked((ushort)lxsSegment_100D_B433_1B503);
        // 100D:B437 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:B439 mov CX,0xC5FC
        CX = (ushort)0xC5FC;
        // 100D:B43C shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:B43E shr CX,1
        CX = Alu16.Shr(CX, 1);
    label_100D_B440_1B510_13076:
        CheckExternalEvents(cs1, 0xB440);
        // 100D:B440 mov AH,3
        AH = (byte)0x03;
    label_100D_B442_1B512_13077:
        CheckExternalEvents(cs1, 0xB442);
        // 100D:B442 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B443 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:B445 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:B447 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B449 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B44B jae short 0xB442
        if (!CarryFlag)
        {
            goto label_100D_B442_1B512_13077;
        }
    label_100D_B44D_1B51D_13084:
        CheckExternalEvents(cs1, 0xB44D);
        // 100D:B44D mov AL,AH
        AL = AH;
        // 100D:B44F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B450 loop 0xB440
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B440_1B510_13076;
        }
    label_100D_B452_1B522_13089:
        CheckExternalEvents(cs1, 0xB452);
        // 100D:B452 push CS
        Stack.Push16(CS);
        // 100D:B453 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B454 mov SI,0x00AA
        SI = (ushort)0x00AA;
        // 100D:B457 mov CX,0x00A2
        CX = (ushort)0x00A2;
        // 100D:B45A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B45C pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B45D mov SI,0xAA76
        SI = (ushort)0xAA76;
        // 100D:B460 mov CX,0x11F8
        CX = (ushort)0x11F8;
        // 100D:B463 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B465 mov SI,0
        SI = (ushort)0x0000;
        // 100D:B468 mov CX,0x1261
        CX = (ushort)0x1261;
        // 100D:B46B rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B46D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B46E pop DI
        DI = Stack.Pop16();
        // 100D:B46F mov CX,0x567A
        CX = (ushort)0x567A;
        // 100D:B472 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B473_1B543(int loadOffset)
    {
    label_100D_B473_1B543_20320:
        CheckExternalEvents(cs1, 0xB473);
        // 100D:B473 mov ES,word ptr SS:[0xDD00]
        ES = UInt16[SS, (ushort)0xDD00];
        // 100D:B478 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:B47A mov BX,0xC5FC
        BX = (ushort)0xC5FC;
        // 100D:B47D shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:B47F shr BX,1
        BX = Alu16.Shr(BX, 1);
    label_100D_B481_1B551_20326:
        CheckExternalEvents(cs1, 0xB481);
        // 100D:B481 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B482 mov CX,4
        CX = (ushort)0x0004;
        // 100D:B485 mov AH,AL
        AH = AL;
        // 100D:B487 ror AH,1
        AH = Alu8.Ror(AH, 1);
        // 100D:B489 ror AH,1
        AH = Alu8.Ror(AH, 1);
    label_100D_B48B_1B55B_20331:
        CheckExternalEvents(cs1, 0xB48B);
        // 100D:B48B mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:B48E xor AL,AH
        AL = Alu8.Xor(AL, AH);
        // 100D:B490 and AL,0xCF
        AL = Alu8.And(AL, (byte)0xCF);
        // 100D:B492 xor AL,AH
        AL = Alu8.Xor(AL, AH);
        // 100D:B494 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B495 rol AH,1
        AH = Alu8.Rol(AH, unchecked((byte)1));
        // 100D:B497 rol AH,1
        AH = Alu8.Rol(AH, unchecked((byte)1));
        // 100D:B499 loop 0xB48B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B48B_1B55B_20331;
        }
    label_100D_B49B_1B56B_20340:
        CheckExternalEvents(cs1, 0xB49B);
        // 100D:B49B dec BX
        BX = Alu16.Dec(BX);
        // 100D:B49C jne short 0xB481
        if (!ZeroFlag)
        {
            goto label_100D_B481_1B551_20326;
        }
    label_100D_B49E_1B56E_20344:
        CheckExternalEvents(cs1, 0xB49E);
        // 100D:B49E push CS
        Stack.Push16(CS);
        // 100D:B49F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B4A0 mov DI,0x00AA
        DI = (ushort)0x00AA;
        // 100D:B4A3 mov CX,0x00A2
        CX = (ushort)0x00A2;
        // 100D:B4A6 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B4A8 push SS
        Stack.Push16(SS);
        // 100D:B4A9 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B4AA mov DI,0xAA76
        DI = (ushort)0xAA76;
        // 100D:B4AD mov CX,0x11F8
        CX = (ushort)0x11F8;
        // 100D:B4B0 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B4B2 mov DI,0
        DI = (ushort)0x0000;
        // 100D:B4B5 mov CX,0x1261
        CX = (ushort)0x1261;
        // 100D:B4B8 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B4BA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B4BB_1B58B(int loadOffset)
    {
    label_100D_B4BB_1B58B_20284:
        CheckExternalEvents(cs1, 0xB4BB);
        // 100D:B4BB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:B4BC mov BL,AL
        BL = AL;
        // 100D:B4BE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:B4BF mov CX,AX
        CX = AX;
        // 100D:B4C1 sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:B4C4 push DI
        Stack.Push16(DI);
    label_100D_B4C5_1B595_20291:
        CheckExternalEvents(cs1, 0xB4C5);
        // 100D:B4C5 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B4C6 cmp AL,BL
        Alu8.Sub(AL, BL);
        // 100D:B4C8 je short 0xB4D3
        if (ZeroFlag)
        {
            goto label_100D_B4D3_1B5A3_20294;
        }
    label_100D_B4CA_1B59A_20309:
        CheckExternalEvents(cs1, 0xB4CA);
        // 100D:B4CA stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B4CB loop 0xB4C5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B4C5_1B595_20291;
        }
    label_100D_B4CD_1B59D_20312:
        CheckExternalEvents(cs1, 0xB4CD);
        // 100D:B4CD pop CX
        CX = Stack.Pop16();
        // 100D:B4CE sub DI,CX
        DI = Alu16.Sub(DI, CX);
        // 100D:B4D0 xchg CX,DI
        ushort temp_100D_B4D0_1B5A0 = CX;
        CX = DI;
        DI = unchecked((ushort)temp_100D_B4D0_1B5A0);
        // 100D:B4D2 ret near
        return NearRet((ushort)0x0000);
    label_100D_B4D3_1B5A3_20294:
        CheckExternalEvents(cs1, 0xB4D3);
        // 100D:B4D3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B4D4 mov DX,CX
        DX = CX;
        // 100D:B4D6 mov CL,AL
        CL = AL;
        // 100D:B4D8 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:B4DA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B4DB rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B4DD mov CX,DX
        CX = DX;
        // 100D:B4DF sub CX,2
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:B4E2 jcxz short 0xB4CD
        if (CX == (ushort)0x0000)
        {
            goto label_100D_B4CD_1B59D_20312;
        }
    label_100D_B4E4_1B5B4_20304:
        CheckExternalEvents(cs1, 0xB4E4);
        // 100D:B4E4 jb short 0xB4CD
        if (CarryFlag)
        {
            goto label_100D_B4CD_1B59D_20312;
        }
    label_100D_B4E6_1B5B6_20306:
        CheckExternalEvents(cs1, 0xB4E6);
        // 100D:B4E6 loop 0xB4C5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B4C5_1B595_20291;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:B4E6");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }
}
