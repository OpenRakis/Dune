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
    public virtual Action unknown_100D_D01A_1D0EA(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_D01A_1D0EA_2903;
            case 0xD01C:
                goto label_100D_D01C_1D0EC_2905;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_D01A_1D0EA_2903:
        CheckExternalEvents(cs1, 0xD01A);
        // 100D:D01A mov AL,0x9A
        AL = (byte)0x9A;
    label_100D_D01C_1D0EC_2905:
        CheckExternalEvents(cs1, 0xD01C);
        // 100D:D01C add AL,byte ptr DS:[0xCEEB]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0xCEEB]);
        // 100D:D020 cmp AL,byte ptr DS:[0x477E]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x477E]);
        // 100D:D024 je short 0xD03B
        if (ZeroFlag)
        {
            goto label_100D_D03B_1D10B_2921;
        }
    label_100D_D026_1D0F6_2908:
        CheckExternalEvents(cs1, 0xD026);
        // 100D:D026 push SI
        Stack.Push16(SI);
        // 100D:D027 mov byte ptr DS:[0x477E],AL
        UInt8[DS, (ushort)0x477E] = AL;
        // 100D:D02A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D02C mov SI,AX
        SI = AX;
        // 100D:D02E les DI,word ptr DS:[0x47B0]
        ushort lxsOffset_100D_D02E_1D0FE = (ushort)0x47B0;
        ushort lxsValue_100D_D02E_1D0FE = UInt16[DS, lxsOffset_100D_D02E_1D0FE];
        ushort lxsSegment_100D_D02E_1D0FE = UInt16[DS, (ushort)(lxsOffset_100D_D02E_1D0FE + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_D02E_1D0FE);
        ES = unchecked((ushort)lxsSegment_100D_D02E_1D0FE);
        // 100D:D032 call near 0xF0B9
        NearCall(cs1, 0xD035, unknown_100D_F0B9_1F189);
    label_100D_D035_1D105_2915:
        CheckExternalEvents(cs1, 0xD035);
        // 100D:D035 push CX
        Stack.Push16(CX);
        // 100D:D036 call near 0x0098
        NearCall(cs1, 0xD039, unknown_100D_0098_10168);
    label_100D_D039_1D109_2918:
        CheckExternalEvents(cs1, 0xD039);
        // 100D:D039 pop CX
        CX = Stack.Pop16();
        // 100D:D03A pop SI
        SI = Stack.Pop16();
    label_100D_D03B_1D10B_2921:
        CheckExternalEvents(cs1, 0xD03B);
        // 100D:D03B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D1A5_1D275(int loadOffset)
    {
    label_100D_D1A5_1D275_14217:
        CheckExternalEvents(cs1, 0xD1A5);
        // 100D:D1A5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D23F_1D30F(int loadOffset)
    {
    label_100D_D23F_1D30F_15796:
        CheckExternalEvents(cs1, 0xD23F);
        // 100D:D23F mov SI,0x1AF4
        SI = (ushort)0x1AF4;
        // 100D:D242 mov AX,word ptr DS:[SI+0x0A]
        AX = UInt16[DS, (ushort)(SI + (sbyte)10)];
        // 100D:D245 sub AX,0
        AX = Alu16.Sub(AX, (ushort)0x0000);
        // 100D:D248 mov CL,3
        CL = (byte)0x03;
        // 100D:D24A div CL
        byte divisor_100D_D24A_1D31A = CL;
        ushort dividend_100D_D24A_1D31A = AX;
        byte quotient_100D_D24A_1D31A = Alu8.Div(unchecked((ushort)dividend_100D_D24A_1D31A), unchecked((byte)divisor_100D_D24A_1D31A));
        AL = unchecked((byte)quotient_100D_D24A_1D31A);
        AH = unchecked((byte)(dividend_100D_D24A_1D31A % unchecked((ushort)divisor_100D_D24A_1D31A)));
        // 100D:D24C cmp CH,AH
        Alu8.Sub(CH, AH);
        // 100D:D24E je short 0xD27F
        if (ZeroFlag)
        {
            goto label_100D_D27F_1D34F_15828;
        }
    label_100D_D250_1D320_15804:
        CheckExternalEvents(cs1, 0xD250);
        // 100D:D250 mov AX,1
        AX = (ushort)0x0001;
        // 100D:D253 jae short 0xD257
        if (!CarryFlag)
        {
            goto label_100D_D257_1D327_15807;
        }
    label_100D_D255_1D325_16024:
        CheckExternalEvents(cs1, 0xD255);
        // 100D:D255 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_D257_1D327_15807:
        CheckExternalEvents(cs1, 0xD257);
        // 100D:D257 push AX
        Stack.Push16(AX);
        // 100D:D258 push SI
        Stack.Push16(SI);
        // 100D:D259 add word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)10)], AX);
        // 100D:D25C add word ptr DS:[SI+0x18],AX
        UInt16[DS, (ushort)(SI + (sbyte)24)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)24)], AX);
        // 100D:D25F mov CX,2
        CX = (ushort)0x0002;
        // 100D:D262 call near 0xD1F2
        NearCall(cs1, 0xD265, unknown_100D_D1F2_1D2C2);
    label_100D_D265_1D335_15814:
        CheckExternalEvents(cs1, 0xD265);
        // 100D:D265 call near 0x1A34
        NearCall(cs1, 0xD268, unknown_100D_1A34_11B04);
    label_100D_D268_1D338_15816:
        CheckExternalEvents(cs1, 0xD268);
        // 100D:D268 mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:D26B call near 0xE387
        NearCall(cs1, 0xD26E, unknown_100D_E387_1E457);
    label_100D_D26E_1D33E_15819:
        CheckExternalEvents(cs1, 0xD26E);
        // 100D:D26E pop SI
        SI = Stack.Pop16();
        // 100D:D26F pop AX
        AX = Stack.Pop16();
        // 100D:D270 add word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)10)], AX);
        // 100D:D273 add word ptr DS:[SI+0x18],AX
        UInt16[DS, (ushort)(SI + (sbyte)24)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)24)], AX);
        // 100D:D276 mov CX,2
        CX = (ushort)0x0002;
        // 100D:D279 call near 0xD1F2
        NearCall(cs1, 0xD27C, unknown_100D_D1F2_1D2C2);
    label_100D_D27C_1D34C_15826:
        CheckExternalEvents(cs1, 0xD27C);
        // 100D:D27C call near 0x1A34
        NearCall(cs1, 0xD27F, unknown_100D_1A34_11B04);
    label_100D_D27F_1D34F_15828:
        CheckExternalEvents(cs1, 0xD27F);
        // 100D:D27F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D315_1D3E5(int loadOffset)
    {
    label_100D_D315_1D3E5_16315:
        CheckExternalEvents(cs1, 0xD315);
        // 100D:D315 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D410_1D4E0(int loadOffset)
    {
    entrydispatcher:
    label_100D_D410_1D4E0_14265:
        CheckExternalEvents(cs1, 0xD410);
        // 100D:D410 mov DX,word ptr DS:[0xDC36]
        DX = UInt16[DS, (ushort)0xDC36];
        // 100D:D414 mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:D418 jmp near 0xD50F
        if (JumpDispatcher.Jump(unknown_100D_D50F_1D5DF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_D621_1D6F1(int loadOffset)
    {
    entrydispatcher:
    label_100D_D621_1D6F1_3527:
        CheckExternalEvents(cs1, 0xD621);
        // 100D:D621 call near 0xE270
        NearCall(cs1, 0xD624, unknown_100D_E270_1E340);
    label_100D_D624_1D6F4_3541:
        CheckExternalEvents(cs1, 0xD624);
        // 100D:D624 call near 0xD41B
        NearCall(cs1, 0xD627, unknown_100D_D41B_1D4EB);
    label_100D_D627_1D6F7_3547:
        CheckExternalEvents(cs1, 0xD627);
        // 100D:D627 mov SI,0x1F7E
        SI = (ushort)0x1F7E;
        // 100D:D62A cmp word ptr DS:[SI+2],AX
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)2)], AX);
        // 100D:D62D mov word ptr DS:[SI+2],AX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = AX;
        // 100D:D630 je short 0xD649
        if (ZeroFlag)
        {
            goto label_100D_D649_1D719_3555;
        }
    label_100D_D632_1D702_3552:
        CheckExternalEvents(cs1, 0xD632);
        // 100D:D632 cmp BP,SI
        Alu16.Sub(BP, SI);
        // 100D:D634 jne short 0xD649
        if (!ZeroFlag)
        {
            goto label_100D_D649_1D719_3555;
        }
    label_100D_D636_1D706_15764:
        CheckExternalEvents(cs1, 0xD636);
        // 100D:D636 call near 0xDBB2
        NearCall(cs1, 0xD639, unknown_100D_DBB2_1DC82);
    label_100D_D639_1D709_15766:
        CheckExternalEvents(cs1, 0xD639);
        // 100D:D639 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:D63B call near 0xD454
        NearCall(cs1, 0xD63E, unknown_100D_D454_1D524);
    label_100D_D63E_1D70E_15769:
        CheckExternalEvents(cs1, 0xD63E);
        // 100D:D63E call near 0xD48A
        NearCall(cs1, 0xD641, unknown_100D_D48A_1D55A);
    label_100D_D641_1D711_15771:
        CheckExternalEvents(cs1, 0xD641);
        // 100D:D641 mov byte ptr DS:[0xDCE7],0xFF
        UInt8[DS, (ushort)0xDCE7] = (byte)0xFF;
        // 100D:D646 call near 0xDBEC
        NearCall(cs1, 0xD649, unknown_100D_DBEC_1DCBC);
    label_100D_D649_1D719_3555:
        CheckExternalEvents(cs1, 0xD649);
        // 100D:D649 call near 0xE283
        NearCall(cs1, 0xD64C, unknown_100D_E283_1E353);
    label_100D_D64C_1D71C_3568:
        CheckExternalEvents(cs1, 0xD64C);
        // 100D:D64C pop AX
        AX = Stack.Pop16();
        // 100D:D64D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D735_1D805(int loadOffset)
    {
    label_100D_D735_1D805_13536:
        CheckExternalEvents(cs1, 0xD735);
        // 100D:D735 call near 0xD741
        NearCall(cs1, 0xD738, unknown_100D_D741_1D811);
    label_100D_D738_1D808_13549:
        CheckExternalEvents(cs1, 0xD738);
        // 100D:D738 mov SI,0x1B8E
        SI = (ushort)0x1B8E;
        // 100D:D73B mov CX,6
        CX = (ushort)0x0006;
        // 100D:D73E jmp near 0xD1F2
        return unknown_100D_D1F2_1D2C2(0x0000);
    }

    public virtual Action unknown_100D_DBAB_1DC7B(int loadOffset)
    {
    label_100D_DBAB_1DC7B_9024:
        CheckExternalEvents(cs1, 0xDBAB);
        // 100D:DBAB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DDE7_1DEB7(int loadOffset)
    {
    label_100D_DDE7_1DEB7_4461:
        CheckExternalEvents(cs1, 0xDDE7);
        // 100D:DDE7 pushf
        Stack.Push16(FlagRegister16);
        // 100D:DDE8 call near 0xDE4E
        NearCall(cs1, 0xDDEB, unknown_100D_DE4E_1DF1E);
    label_100D_DDEB_1DEBB_4467:
        CheckExternalEvents(cs1, 0xDDEB);
        // 100D:DDEB popf
        FlagRegister16 = Stack.Pop16();
    label_100D_DDEC_1DEBC_4469:
        CheckExternalEvents(cs1, 0xDDEC);
        // 100D:DDEC call near 0xE283
        NearCall(cs1, 0xDDEF, unknown_100D_E283_1E353);
    label_100D_DDEF_1DEBF_4471:
        CheckExternalEvents(cs1, 0xDDEF);
        // 100D:DDEF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DE07_1DED7(int loadOffset)
    {
    label_100D_DE07_1DED7_3428:
        CheckExternalEvents(cs1, 0xDE07);
        // 100D:DE07 push AX
        Stack.Push16(AX);
        // 100D:DE08 or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
        // 100D:DE0A pop AX
        AX = Stack.Pop16();
        // 100D:DE0B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E0DA_1E1AA(int loadOffset)
    {
    label_100D_E0DA_1E1AA_38691:
        CheckExternalEvents(cs1, 0xE0DA);
        // 100D:E0DA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E171_1E241(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_E171_1E241_38614;
            case 0xE173:
                goto label_100D_E173_1E243_38616;
            case 0xE186:
                goto label_100D_E186_1E256_38623;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_E171_1E241_38614:
        CheckExternalEvents(cs1, 0xE171);
        // 100D:E171 sub SI,BX
        SI = Alu16.Sub(SI, BX);
    label_100D_E173_1E243_38616:
        CheckExternalEvents(cs1, 0xE173);
        // 100D:E173 jns short 0xE177
        if (!SignFlag)
        {
            goto label_100D_E177_1E247_38617;
        }
    label_100D_E175_1E245_38619:
        CheckExternalEvents(cs1, 0xE175);
        // 100D:E175 neg SI
        SI = Alu16.Sub((ushort)0x0000, SI);
        CarryFlag = SI != (ushort)0x0000;
    label_100D_E177_1E247_38617:
        CheckExternalEvents(cs1, 0xE177);
        // 100D:E177 cmp AX,6
        Alu16.Sub(AX, (ushort)0x0006);
        // 100D:E17A jl short 0xE186
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_E186_1E256_38623;
        }
    label_100D_E17C_1E24C_38625:
        CheckExternalEvents(cs1, 0xE17C);
        // 100D:E17C cmp SI,0x0032
        Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:E17F jae short 0xE186
        if (!CarryFlag)
        {
            goto label_100D_E186_1E256_38623;
        }
    label_100D_E181_1E251_38631:
        CheckExternalEvents(cs1, 0xE181);
        // 100D:E181 add AX,SI
        AX = Alu16.Add(AX, SI);
        // 100D:E183 add AX,SI
        AX = Alu16.Add(AX, SI);
        // 100D:E185 ret near
        return NearRet((ushort)0x0000);
    label_100D_E186_1E256_38623:
        CheckExternalEvents(cs1, 0xE186);
        // 100D:E186 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:E189 mov SI,AX
        SI = AX;
        // 100D:E18B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E297_1E367(int loadOffset)
    {
    label_100D_E297_1E367_13401:
        CheckExternalEvents(cs1, 0xE297);
        // 100D:E297 push CX
        Stack.Push16(CX);
        // 100D:E298 mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:E29B div CL
        byte divisor_100D_E29B_1E36B = CL;
        ushort dividend_100D_E29B_1E36B = AX;
        byte quotient_100D_E29B_1E36B = Alu8.Div(unchecked((ushort)dividend_100D_E29B_1E36B), unchecked((byte)divisor_100D_E29B_1E36B));
        AL = unchecked((byte)quotient_100D_E29B_1E36B);
        AH = unchecked((byte)(dividend_100D_E29B_1E36B % unchecked((ushort)divisor_100D_E29B_1E36B)));
        // 100D:E29D add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        // 100D:E29F cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:E2A1 jne short 0xE2A7
        if (!ZeroFlag)
        {
            goto label_100D_E2A7_1E377_13411;
        }
    label_100D_E2A3_1E373_13408:
        CheckExternalEvents(cs1, 0xE2A3);
        // 100D:E2A3 mov AL,0x20
        AL = (byte)0x20;
        // 100D:E2A5 dec CH
        CH = Alu8.Dec(CH);
    label_100D_E2A7_1E377_13411:
        CheckExternalEvents(cs1, 0xE2A7);
        // 100D:E2A7 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0xE2AB, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:E2A7");
        }
    label_100D_E2AB_1E37B_13467:
        CheckExternalEvents(cs1, 0xE2AB);
        // 100D:E2AB mov AL,AH
        AL = AH;
        // 100D:E2AD aam
        byte v2_100D_E2AD_1E37D = (byte)0x0A;
        byte v1_100D_E2AD_1E37D = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_E2AD_1E37D >> (byte)0x01)));
        if (v2_100D_E2AD_1E37D == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_E2AD_1E37D = unchecked((byte)(v1_100D_E2AD_1E37D % v2_100D_E2AD_1E37D));
        AH = unchecked((byte)(v1_100D_E2AD_1E37D / v2_100D_E2AD_1E37D));
        AL = unchecked((byte)result_100D_E2AD_1E37D);
        Alu8.UpdateFlags(unchecked((byte)result_100D_E2AD_1E37D));
        // 100D:E2AF xchg AL,AH
        byte temp_100D_E2AF_1E37F = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_E2AF_1E37F);
        // 100D:E2B1 add AX,0x3030
        AX = Alu16.Add(AX, (ushort)0x3030);
        // 100D:E2B4 or CH,CH
        CH = Alu8.Or(CH, CH);
        // 100D:E2B6 je short 0xE2BE
        if (ZeroFlag)
        {
            goto label_100D_E2BE_1E38E_13479;
        }
    label_100D_E2B8_1E388_13474:
        CheckExternalEvents(cs1, 0xE2B8);
        // 100D:E2B8 cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:E2BA jne short 0xE2BE
        if (!ZeroFlag)
        {
            goto label_100D_E2BE_1E38E_13479;
        }
    label_100D_E2BC_1E38C_13477:
        CheckExternalEvents(cs1, 0xE2BC);
        // 100D:E2BC mov AL,0x20
        AL = (byte)0x20;
    label_100D_E2BE_1E38E_13479:
        CheckExternalEvents(cs1, 0xE2BE);
        // 100D:E2BE call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0xE2C2, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:E2BE");
        }
    label_100D_E2C2_1E392_13480:
        CheckExternalEvents(cs1, 0xE2C2);
        // 100D:E2C2 mov AL,AH
        AL = AH;
        // 100D:E2C4 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0xE2C8, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:E2C4");
        }
    label_100D_E2C8_1E398_13484:
        CheckExternalEvents(cs1, 0xE2C8);
        // 100D:E2C8 pop CX
        CX = Stack.Pop16();
        // 100D:E2C9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_E2F6_1E3C6(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_E2F6_1E3C6_18447;
            case 0xE2FE:
                goto label_100D_E2FE_1E3CE_18452;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_E2F6_1E3C6_18447:
        CheckExternalEvents(cs1, 0xE2F6);
        // 100D:E2F6 cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:E2F8 jne short 0xE2FE
        if (!ZeroFlag)
        {
            goto label_100D_E2FE_1E3CE_18452;
        }
    label_100D_E2FA_1E3CA_18449:
        CheckExternalEvents(cs1, 0xE2FA);
        // 100D:E2FA mov AL,0x20
        AL = (byte)0x20;
        // 100D:E2FC xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_E2FE_1E3CE_18452:
        CheckExternalEvents(cs1, 0xE2FE);
        // 100D:E2FE mov byte ptr ES:[SI-3],AL
        UInt8[ES, (ushort)(SI + (sbyte)-3)] = AL;
        // 100D:E302 mov AL,AH
        AL = AH;
        // 100D:E304 aam
        byte v2_100D_E304_1E3D4 = (byte)0x0A;
        byte v1_100D_E304_1E3D4 = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_E304_1E3D4 >> (byte)0x01)));
        if (v2_100D_E304_1E3D4 == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_E304_1E3D4 = unchecked((byte)(v1_100D_E304_1E3D4 % v2_100D_E304_1E3D4));
        AH = unchecked((byte)(v1_100D_E304_1E3D4 / v2_100D_E304_1E3D4));
        AL = unchecked((byte)result_100D_E304_1E3D4);
        Alu8.UpdateFlags(unchecked((byte)result_100D_E304_1E3D4));
        // 100D:E306 xchg AL,AH
        byte temp_100D_E306_1E3D6 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_E306_1E3D6);
        // 100D:E308 add AX,0x3030
        AX = Alu16.Add(AX, (ushort)0x3030);
        // 100D:E30B or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:E30D jne short 0xE315
        if (!ZeroFlag)
        {
            goto label_100D_E315_1E3E5_18464;
        }
    label_100D_E30F_1E3DF_18459:
        CheckExternalEvents(cs1, 0xE30F);
        // 100D:E30F cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:E311 jne short 0xE315
        if (!ZeroFlag)
        {
            goto label_100D_E315_1E3E5_18464;
        }
    label_100D_E313_1E3E3_18462:
        CheckExternalEvents(cs1, 0xE313);
        // 100D:E313 mov AL,0x20
        AL = (byte)0x20;
    label_100D_E315_1E3E5_18464:
        CheckExternalEvents(cs1, 0xE315);
        // 100D:E315 mov word ptr ES:[SI-2],AX
        UInt16[ES, (ushort)(SI + (sbyte)-2)] = AX;
        // 100D:E319 pop CX
        CX = Stack.Pop16();
        // 100D:E31A pop BX
        BX = Stack.Pop16();
        // 100D:E31B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F228_1F2F8(int loadOffset)
    {
    label_100D_F228_1F2F8_231:
        CheckExternalEvents(cs1, 0xF228);
        // 100D:F228 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F435_1F505(int loadOffset)
    {
    label_100D_F435_1F505_629:
        CheckExternalEvents(cs1, 0xF435);
        // 100D:F435 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:F437 je short 0xF43E
        if (ZeroFlag)
        {
            goto label_100D_F43E_1F50E_631;
        }
    label_100D_F439_1F509_641:
        CheckExternalEvents(cs1, 0xF439);
        // 100D:F439 jae short 0xF446
        if (!CarryFlag)
        {
            goto label_100D_F446_1F516_643;
        }
    label_100D_F43B_1F50B_637:
        CheckExternalEvents(cs1, 0xF43B);
        // 100D:F43B movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:F43C jmp short 0xF435
        goto label_100D_F435_1F505_629;
    label_100D_F43E_1F50E_631:
        CheckExternalEvents(cs1, 0xF43E);
        // 100D:F43E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F43F mov BP,AX
        BP = AX;
        // 100D:F441 stc
        CarryFlag = true;
        // 100D:F442 rcr BP,1
        BP = Alu16.Rcr(BP, 1);
        // 100D:F444 jb short 0xF43B
        if (CarryFlag)
        {
            goto label_100D_F43B_1F50B_637;
        }
    label_100D_F446_1F516_643:
        CheckExternalEvents(cs1, 0xF446);
        // 100D:F446 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:F448 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:F44A jne short 0xF452
        if (!ZeroFlag)
        {
            goto label_100D_F452_1F522_647;
        }
    label_100D_F44C_1F51C_681:
        CheckExternalEvents(cs1, 0xF44C);
        // 100D:F44C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F44D mov BP,AX
        BP = AX;
        // 100D:F44F stc
        CarryFlag = true;
        // 100D:F450 rcr BP,1
        BP = Alu16.Rcr(BP, 1);
    label_100D_F452_1F522_647:
        CheckExternalEvents(cs1, 0xF452);
        // 100D:F452 jb short 0xF482
        if (CarryFlag)
        {
            goto label_100D_F482_1F552_686;
        }
    label_100D_F454_1F524_649:
        CheckExternalEvents(cs1, 0xF454);
        // 100D:F454 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:F456 jne short 0xF45E
        if (!ZeroFlag)
        {
            goto label_100D_F45E_1F52E_652;
        }
    label_100D_F458_1F528_671:
        CheckExternalEvents(cs1, 0xF458);
        // 100D:F458 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F459 mov BP,AX
        BP = AX;
        // 100D:F45B stc
        CarryFlag = true;
        // 100D:F45C rcr BP,1
        BP = Alu16.Rcr(BP, 1);
    label_100D_F45E_1F52E_652:
        CheckExternalEvents(cs1, 0xF45E);
        // 100D:F45E rcl CX,1
        CX = Alu16.Rcl(CX, unchecked((byte)1));
        // 100D:F460 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 100D:F462 jne short 0xF46A
        if (!ZeroFlag)
        {
            goto label_100D_F46A_1F53A_656;
        }
    label_100D_F464_1F534_676:
        CheckExternalEvents(cs1, 0xF464);
        // 100D:F464 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F465 mov BP,AX
        BP = AX;
        // 100D:F467 stc
        CarryFlag = true;
        // 100D:F468 rcr BP,1
        BP = Alu16.Rcr(BP, 1);
    label_100D_F46A_1F53A_656:
        CheckExternalEvents(cs1, 0xF46A);
        // 100D:F46A rcl CX,1
        CX = Alu16.Rcl(CX, unchecked((byte)1));
        // 100D:F46C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F46D mov AH,0xFF
        AH = (byte)0xFF;
    label_100D_F46F_1F53F_660:
        CheckExternalEvents(cs1, 0xF46F);
        // 100D:F46F add AX,DI
        AX = Alu16.Add(AX, DI);
        // 100D:F471 xchg SI,AX
        ushort temp_100D_F471_1F541 = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_F471_1F541);
        // 100D:F472 mov BX,DS
        BX = DS;
        // 100D:F474 mov DX,ES
        DX = ES;
        // 100D:F476 mov DS,DX
        DS = DX;
        // 100D:F478 inc CX
        CX = Alu16.Inc(CX);
        // 100D:F479 inc CX
        CX = Alu16.Inc(CX);
        // 100D:F47A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:F47C mov DS,BX
        DS = BX;
        // 100D:F47E mov SI,AX
        SI = AX;
        // 100D:F480 jmp short 0xF435
        goto label_100D_F435_1F505_629;
    label_100D_F482_1F552_686:
        CheckExternalEvents(cs1, 0xF482);
        // 100D:F482 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F483 mov CL,AL
        CL = AL;
        // 100D:F485 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F487 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F489 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F48B or AH,0xE0
        AH = Alu8.Or(AH, (byte)0xE0);
        // 100D:F48E and CL,7
        CL = Alu8.And(CL, (byte)0x07);
        // 100D:F491 jne short 0xF46F
        if (!ZeroFlag)
        {
            goto label_100D_F46F_1F53F_660;
        }
    label_100D_F493_1F563_695:
        CheckExternalEvents(cs1, 0xF493);
        // 100D:F493 mov BX,AX
        BX = AX;
        // 100D:F495 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F496 mov CL,AL
        CL = AL;
        // 100D:F498 mov AX,BX
        AX = BX;
        // 100D:F49A or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:F49C jne short 0xF46F
        if (!ZeroFlag)
        {
            goto label_100D_F46F_1F53F_660;
        }
    label_100D_F49E_1F56E_703:
        CheckExternalEvents(cs1, 0xF49E);
        // 100D:F49E stc
        CarryFlag = true;
        // 100D:F49F mov CX,DI
        CX = DI;
        // 100D:F4A1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F4A2 pop DI
        DI = Stack.Pop16();
        // 100D:F4A3 add SP,2
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F4A6 sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:F4A8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0B5F_340DF(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_3358_0B5F_340DF_1167;
            case 0x0B67:
                goto label_3358_0B67_340E7_1175;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_3358_0B5F_340DF_1167:
        CheckExternalEvents(cs2, 0x0B5F);
        // 3358:0B5F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0B60 pop BP
        BP = Stack.Pop16();
        // 3358:0B61 pop DI
        DI = Stack.Pop16();
        // 3358:0B62 pop SI
        SI = Stack.Pop16();
        // 3358:0B63 pop DX
        DX = Stack.Pop16();
        // 3358:0B64 pop CX
        CX = Stack.Pop16();
        // 3358:0B65 pop BX
        BX = Stack.Pop16();
        // 3358:0B66 pop AX
        AX = Stack.Pop16();
    label_3358_0B67_340E7_1175:
        CheckExternalEvents(cs2, 0x0B67);
        // 3358:0B67 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0C46_341C6(int loadOffset)
    {
        goto label_3358_0C46_341C6_6048;

    label_3358_0C3B_341BB_6159:
        CheckExternalEvents(cs2, 0x0C3B);
        // 3358:0C3B mov BP,word ptr [0x000341BC]
        BP = UInt16[unchecked((uint)(0x000341BCu))];
        // 3358:0C3E sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 3358:0C40 sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 3358:0C42 selector
        if (SelectorSignatureMatches(cs2, 0x0C42, [(byte)0x81, (byte)0xC7, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0C42_341C2_6085;
        }
        if (SelectorSignatureMatches(cs2, 0x0C42, [(byte)0x81, (byte)0xEF, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0C42_341C2_9620;
        }
        throw FailAsUntested("No selector signature matched at 3358:0C42");
    label_3358_0C42_341C2_6085:
        CheckExternalEvents(cs2, 0x0C42);
        // 3358:0C42 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        goto label_3358_0C46_341C6_6048;
    label_3358_0C42_341C2_9620:
        CheckExternalEvents(cs2, 0x0C42);
        // 3358:0C42 sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
    label_3358_0C46_341C6_6048:
        CheckExternalEvents(cs2, 0x0C46);
        // 3358:0C46 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0C47 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0C49 js short 0x0C85
        if (SignFlag)
        {
            goto label_3358_0C85_34205_6052;
        }
    label_3358_0C4B_341CB_6086:
        CheckExternalEvents(cs2, 0x0C4B);
        // 3358:0C4B mov CX,AX
        CX = AX;
        // 3358:0C4D xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0C4F inc CX
        CX = Alu16.Inc(CX);
        // 3358:0C50 sub BP,CX
        BP = Alu16.Sub(BP, CX);
    label_3358_0C52_341D2_6091:
        CheckExternalEvents(cs2, 0x0C52);
        // 3358:0C52 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0C53 mov AH,AL
        AH = AL;
        // 3358:0C55 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:0C57 je short 0x0C7B
        if (ZeroFlag)
        {
            goto label_3358_0C7B_341FB_6115;
        }
    label_3358_0C59_341D9_6095:
        CheckExternalEvents(cs2, 0x0C59);
        // 3358:0C59 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0C5B stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0C5C shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_0C5E_341DE_6099:
        CheckExternalEvents(cs2, 0x0C5E);
        // 3358:0C5E shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0C60 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0C62 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0C64 je short 0x0C80
        if (ZeroFlag)
        {
            goto label_3358_0C80_34200_6119;
        }
    label_3358_0C66_341E6_6103:
        CheckExternalEvents(cs2, 0x0C66);
        // 3358:0C66 mov AL,AH
        AL = AH;
        // 3358:0C68 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0C6A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0C6B loop 0x0C52
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0C52_341D2_6091;
        }
    label_3358_0C6D_341ED_6109:
        CheckExternalEvents(cs2, 0x0C6D);
        // 3358:0C6D or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0C6F ja short 0x0C46
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0C46_341C6_6048;
        }
    label_3358_0C71_341F1_6112:
        CheckExternalEvents(cs2, 0x0C71);
        // 3358:0C71 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0C72 jne short 0x0C3B
        if (!ZeroFlag)
        {
            goto label_3358_0C3B_341BB_6159;
        }
    label_3358_0C74_341F4_6149:
        CheckExternalEvents(cs2, 0x0C74);
        // 3358:0C74 mov byte ptr CS:[0x0C43],0xC7
        UInt8[CS, (ushort)0x0C43] = (byte)0xC7;
        // 3358:0C7A ret far
        return FarRet((ushort)0x0000);
    label_3358_0C7B_341FB_6115:
        CheckExternalEvents(cs2, 0x0C7B);
        // 3358:0C7B inc DI
        DI = Alu16.Inc(DI);
        // 3358:0C7C shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0C7E jne short 0x0C5E
        if (!ZeroFlag)
        {
            goto label_3358_0C5E_341DE_6099;
        }
    label_3358_0C80_34200_6119:
        CheckExternalEvents(cs2, 0x0C80);
        // 3358:0C80 inc DI
        DI = Alu16.Inc(DI);
        // 3358:0C81 loop 0x0C52
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0C52_341D2_6091;
        }
    label_3358_0C83_34203_6123:
        CheckExternalEvents(cs2, 0x0C83);
        // 3358:0C83 jmp short 0x0C6D
        goto label_3358_0C6D_341ED_6109;
    label_3358_0C85_34205_6052:
        CheckExternalEvents(cs2, 0x0C85);
        // 3358:0C85 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:0C88 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0C8A sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:0C8C sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:0C8E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0C8F shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0C91 je short 0x0CB6
        if (ZeroFlag)
        {
            goto label_3358_0CB6_34236_6125;
        }
    label_3358_0C93_34213_6060:
        CheckExternalEvents(cs2, 0x0C93);
        // 3358:0C93 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0C95 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0C97 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0C99 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0C9B je short 0x0CC0
        if (ZeroFlag)
        {
            goto label_3358_0CC0_34240_6130;
        }
    label_3358_0C9D_3421D_6066:
        CheckExternalEvents(cs2, 0x0C9D);
        // 3358:0C9D shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0C9F shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0CA1 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0CA3 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0CA5 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 3358:0CA7 je short 0x0CCF
        if (ZeroFlag)
        {
            goto label_3358_0CCF_3424F_6142;
        }
    label_3358_0CA9_34229_6073:
        CheckExternalEvents(cs2, 0x0CA9);
        // 3358:0CA9 add AH,DH
        AH = Alu8.Add(AH, DH);
        // 3358:0CAB rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_0CAD_3422D_6076:
        CheckExternalEvents(cs2, 0x0CAD);
        // 3358:0CAD or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0CAF ja short 0x0C46
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0C46_341C6_6048;
        }
    label_3358_0CB1_34231_6078:
        CheckExternalEvents(cs2, 0x0CB1);
        // 3358:0CB1 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0CB2 jne short 0x0C3B
        if (!ZeroFlag)
        {
            goto label_3358_0C3B_341BB_6159;
        }
    label_3358_0CB4_34234_6155:
        CheckExternalEvents(cs2, 0x0CB4);
        // 3358:0CB4 jmp short 0x0C74
        goto label_3358_0C74_341F4_6149;
    label_3358_0CB6_34236_6125:
        CheckExternalEvents(cs2, 0x0CB6);
        // 3358:0CB6 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 3358:0CB8 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:0CBA or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0CBC ja short 0x0C46
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0C46_341C6_6048;
        }
    label_3358_0CBE_3423E_6157:
        CheckExternalEvents(cs2, 0x0CBE);
        // 3358:0CBE jmp short 0x0CB1
        goto label_3358_0CB1_34231_6078;
    label_3358_0CC0_34240_6130:
        CheckExternalEvents(cs2, 0x0CC0);
        // 3358:0CC0 mov AL,AH
        AL = AH;
        // 3358:0CC2 add AL,DH
        AL = Alu8.Add(AL, DH);
    label_3358_0CC4_34244_6133:
        CheckExternalEvents(cs2, 0x0CC4);
        // 3358:0CC4 inc DI
        DI = Alu16.Inc(DI);
        // 3358:0CC5 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0CC6 loop 0x0CC4
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0CC4_34244_6133;
        }
    label_3358_0CC8_34248_6137:
        CheckExternalEvents(cs2, 0x0CC8);
        // 3358:0CC8 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0CCA jbe short 0x0CB1
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_0CB1_34231_6078;
        }
    label_3358_0CCC_3424C_6140:
        CheckExternalEvents(cs2, 0x0CCC);
        // 3358:0CCC jmp near 0x0C46
        goto label_3358_0C46_341C6_6048;
    label_3358_0CCF_3424F_6142:
        CheckExternalEvents(cs2, 0x0CCF);
        // 3358:0CCF stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0CD0 inc DI
        DI = Alu16.Inc(DI);
        // 3358:0CD1 loop 0x0CCF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0CCF_3424F_6142;
        }
    label_3358_0CD3_34253_6146:
        CheckExternalEvents(cs2, 0x0CD3);
        // 3358:0CD3 jmp short 0x0CAD
        goto label_3358_0CAD_3422D_6076;
    }

    public virtual Action unknown_3358_0D85_34305(int loadOffset)
    {
    label_3358_0D85_34305_7387:
        CheckExternalEvents(cs2, 0x0D85);
        // 3358:0D85 mov byte ptr CS:[0x019E],CH
        UInt8[CS, (ushort)0x019E] = CH;
        // 3358:0D8A xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0D8C and AX,0x03FF
        AX = Alu16.And(AX, (ushort)0x03FF);
        // 3358:0D8F mov word ptr CS:[0x0D81],AX
        UInt16[CS, (ushort)0x0D81] = AX;
        // 3358:0D93 mov AX,DI
        AX = DI;
        // 3358:0D95 and DI,0x01FF
        DI = Alu16.And(DI, (ushort)0x01FF);
        // 3358:0D99 add DI,3
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:0D9C shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:0D9E shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:0DA0 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 3358:0DA2 mov word ptr CS:[0x0DDE],DI
        UInt16[CS, (ushort)0x0DDE] = DI;
        // 3358:0DA7 mov byte ptr CS:[0x0E13],0xC7
        UInt8[CS, (ushort)0x0E13] = (byte)0xC7;
        // 3358:0DAD test AX,0x2000
        Alu16.And(AX, (ushort)0x2000);
        // 3358:0DB0 je short 0x0DBB
        if (ZeroFlag)
        {
            goto label_3358_0DBB_3433B_7402;
        }
    label_3358_0DB2_34332_9585:
        CheckExternalEvents(cs2, 0x0DB2);
        // 3358:0DB2 mov byte ptr CS:[0x0E13],0xEF
        UInt8[CS, (ushort)0x0E13] = (byte)0xEF;
        // 3358:0DB8 add BX,CX
        BX = Alu16.Add(BX, CX);
        // 3358:0DBA dec BX
        BX = Alu16.Dec(BX);
    label_3358_0DBB_3433B_7402:
        CheckExternalEvents(cs2, 0x0DBB);
        // 3358:0DBB mov byte ptr CS:[0x0E26],0x47
        UInt8[CS, (ushort)0x0E26] = (byte)0x47;
        // 3358:0DC1 test AX,0x4000
        Alu16.And(AX, (ushort)0x4000);
        // 3358:0DC4 je short 0x0DD3
        if (ZeroFlag)
        {
            goto label_3358_0DD3_34353_7411;
        }
    label_3358_0DC6_34346_7406:
        CheckExternalEvents(cs2, 0x0DC6);
        // 3358:0DC6 mov byte ptr CS:[0x0E26],0x4F
        UInt8[CS, (ushort)0x0E26] = (byte)0x4F;
        // 3358:0DCC add DX,word ptr CS:[0x0D81]
        DX = Alu16.Add(DX, UInt16[CS, (ushort)0x0D81]);
        // 3358:0DD1 dec DX
        DX = Alu16.Dec(DX);
        // 3358:0DD2 std
        DirectionFlag = true;
    label_3358_0DD3_34353_7411:
        CheckExternalEvents(cs2, 0x0DD3);
        // 3358:0DD3 call near 0x0C10
        NearCall(cs2, 0x0DD6, unknown_3358_0C10_34190);
    label_3358_0DD6_34356_7412:
        CheckExternalEvents(cs2, 0x0DD6);
        // 3358:0DD6 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 3358:0DD8 mov word ptr CS:[0x0D83],BX
        UInt16[CS, (ushort)0x0D83] = BX;
    label_3358_0DDD_3435D_7465:
        CheckExternalEvents(cs2, 0x0DDD);
        // 3358:0DDD mov AX,word ptr [0x0003435E]
        AX = UInt16[unchecked((uint)(0x0003435Eu))];
        // 3358:0DE0 push SI
        Stack.Push16(SI);
        // 3358:0DE1 mul BH
        ushort result_3358_0DE1_34361 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)BH)));
        AH = unchecked((byte)(result_3358_0DE1_34361 >> 8));
        AL = unchecked((byte)result_3358_0DE1_34361);
        // 3358:0DE3 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:0DE5 push DI
        Stack.Push16(DI);
        // 3358:0DE6 push CX
        Stack.Push16(CX);
        // 3358:0DE7 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 3358:0DE9 mov BX,SI
        BX = SI;
        // 3358:0DEB mov CX,word ptr CS:[0x0D81]
        CX = UInt16[CS, (ushort)0x0D81];
        // 3358:0DF0 mov AH,byte ptr CS:[0x019E]
        AH = UInt8[CS, (ushort)0x019E];
    label_3358_0DF5_34375_7425:
        CheckExternalEvents(cs2, 0x0DF5);
        // 3358:0DF5 mov AL,DH
        AL = DH;
        // 3358:0DF7 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0DF9 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:0DFA jae short 0x0E04
        if (!CarryFlag)
        {
            goto label_3358_0E04_34384_7429;
        }
    label_3358_0DFC_3437C_7437:
        CheckExternalEvents(cs2, 0x0DFC);
        // 3358:0DFC shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0DFE shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0E00 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0E02 shr AL,1
        AL = Alu8.Shr(AL, 1);
    label_3358_0E04_34384_7429:
        CheckExternalEvents(cs2, 0x0E04);
        // 3358:0E04 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 3358:0E06 je short 0x0E26
        if (ZeroFlag)
        {
            goto label_3358_0E26_343A6_7748;
        }
    label_3358_0E08_34388_7442:
        CheckExternalEvents(cs2, 0x0E08);
        // 3358:0E08 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:0E0A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0E0B add DX,BP
        DX = Alu16.Add(DX, BP);
        // 3358:0E0D loop 0x0DF5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0DF5_34375_7425;
        }
    label_3358_0E0F_3438F_7447:
        CheckExternalEvents(cs2, 0x0E0F);
        // 3358:0E0F pop CX
        CX = Stack.Pop16();
        // 3358:0E10 pop DI
        DI = Stack.Pop16();
        // 3358:0E11 pop SI
        SI = Stack.Pop16();
        // 3358:0E12 selector
        if (SelectorSignatureMatches(cs2, 0x0E12, [(byte)0x81, (byte)0xC7, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0E12_34392_7451;
        }
        if (SelectorSignatureMatches(cs2, 0x0E12, [(byte)0x81, (byte)0xEF, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0E12_34392_9589;
        }
        throw FailAsUntested("No selector signature matched at 3358:0E12");
    label_3358_0E12_34392_7451:
        CheckExternalEvents(cs2, 0x0E12);
        // 3358:0E12 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        goto label_3358_0E16_34396_7452;
    label_3358_0E12_34392_9589:
        CheckExternalEvents(cs2, 0x0E12);
        // 3358:0E12 sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
    label_3358_0E16_34396_7452:
        CheckExternalEvents(cs2, 0x0E16);
        // 3358:0E16 mov BX,word ptr CS:[0x0D83]
        BX = UInt16[CS, (ushort)0x0D83];
        // 3358:0E1B add BX,BP
        BX = Alu16.Add(BX, BP);
        // 3358:0E1D mov word ptr CS:[0x0D83],BX
        UInt16[CS, (ushort)0x0D83] = BX;
        // 3358:0E22 loop 0x0DDD
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0DDD_3435D_7465;
        }
    label_3358_0E24_343A4_7457:
        CheckExternalEvents(cs2, 0x0E24);
        // 3358:0E24 cld
        DirectionFlag = false;
        // 3358:0E25 ret far
        return FarRet((ushort)0x0000);
    label_3358_0E26_343A6_7432:
        CheckExternalEvents(cs2, 0x0E26);
        // 3358:0E26 dec DI
        DI = Alu16.Dec(DI);
        goto label_3358_0E27_343A7_7434;
    label_3358_0E26_343A6_7748:
        CheckExternalEvents(cs2, 0x0E26);
        // 3358:0E26 selector
        if (SelectorSignatureMatches(cs2, 0x0E26, [(byte)0x47]))
        {
            goto label_3358_0E26_343A6_7747;
        }
        if (SelectorSignatureMatches(cs2, 0x0E26, [(byte)0x4F]))
        {
            goto label_3358_0E26_343A6_7432;
        }
        throw FailAsUntested("No selector signature matched at 3358:0E26");
    label_3358_0E26_343A6_7747:
        CheckExternalEvents(cs2, 0x0E26);
        // 3358:0E26 inc DI
        DI = Alu16.Inc(DI);
    label_3358_0E27_343A7_7434:
        CheckExternalEvents(cs2, 0x0E27);
        // 3358:0E27 add DX,BP
        DX = Alu16.Add(DX, BP);
        // 3358:0E29 loop 0x0DF5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0DF5_34375_7425;
        }
    label_3358_0E2B_343AB_7466:
        CheckExternalEvents(cs2, 0x0E2B);
        // 3358:0E2B jmp short 0x0E0F
        goto label_3358_0E0F_3438F_7447;
    }

    public virtual Action unknown_3358_158A_34B0A(int loadOffset)
    {
    label_3358_158A_34B0A_7460:
        CheckExternalEvents(cs2, 0x158A);
        // 3358:158A mov BP,word ptr [0x00034B0B]
        BP = UInt16[unchecked((uint)(0x00034B0Bu))];
        // 3358:158D push DI
        Stack.Push16(DI);
    label_3358_158E_34B0E_7324:
        CheckExternalEvents(cs2, 0x158E);
        // 3358:158E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:158F mov BL,AL
        BL = AL;
        // 3358:1591 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:1593 je short 0x15CA
        if (ZeroFlag)
        {
            goto label_3358_15CA_34B4A_7328;
        }
    label_3358_1595_34B15_7355:
        CheckExternalEvents(cs2, 0x1595);
        // 3358:1595 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:1597 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1598 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:159A shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:159C shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:159E shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:15A0 je short 0x15D9
        if (ZeroFlag)
        {
            goto label_3358_15D9_34B59_7332;
        }
    label_3358_15A2_34B22_7363:
        CheckExternalEvents(cs2, 0x15A2);
        // 3358:15A2 mov AL,BL
        AL = BL;
    label_3358_15A4_34B24_7365:
        CheckExternalEvents(cs2, 0x15A4);
        // 3358:15A4 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:15A6 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:15A7 mov AL,AH
        AL = AH;
    label_3358_15A9_34B29_7337:
        CheckExternalEvents(cs2, 0x15A9);
        // 3358:15A9 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:15AB je short 0x15EE
        if (ZeroFlag)
        {
            goto label_3358_15EE_34B6E_7368;
        }
    label_3358_15AD_34B2D_7340:
        CheckExternalEvents(cs2, 0x15AD);
        // 3358:15AD add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:15AF stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:15B0 shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_15B2_34B32_7344:
        CheckExternalEvents(cs2, 0x15B2);
        // 3358:15B2 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:15B4 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:15B6 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:15B8 je short 0x15F5
        if (ZeroFlag)
        {
            goto label_3358_15F5_34B75_7461;
        }
    label_3358_15BA_34B3A_7348:
        CheckExternalEvents(cs2, 0x15BA);
        // 3358:15BA mov AL,AH
        AL = AH;
        // 3358:15BC add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:15BE stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:15BF dec BP
        BP = Alu16.Dec(BP);
        // 3358:15C0 jne short 0x158E
        if (!ZeroFlag)
        {
            goto label_3358_158E_34B0E_7324;
        }
    label_3358_15C2_34B42_7837:
        CheckExternalEvents(cs2, 0x15C2);
        // 3358:15C2 pop DI
        DI = Stack.Pop16();
        // 3358:15C3 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:15C7 loop 0x158A
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_158A_34B0A_7460;
        }
    label_3358_15C9_34B49_7841:
        CheckExternalEvents(cs2, 0x15C9);
        // 3358:15C9 ret far
        return FarRet((ushort)0x0000);
    label_3358_15CA_34B4A_7328:
        CheckExternalEvents(cs2, 0x15CA);
        // 3358:15CA inc DI
        DI = Alu16.Inc(DI);
        // 3358:15CB or AL,BL
        AL = Alu8.Or(AL, BL);
        // 3358:15CD je short 0x15D9
        if (ZeroFlag)
        {
            goto label_3358_15D9_34B59_7332;
        }
    label_3358_15CF_34B4F_7468:
        CheckExternalEvents(cs2, 0x15CF);
        // 3358:15CF shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:15D1 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:15D3 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:15D5 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:15D7 jmp short 0x15A4
        goto label_3358_15A4_34B24_7365;
    label_3358_15D9_34B59_7332:
        CheckExternalEvents(cs2, 0x15D9);
        // 3358:15D9 inc DI
        DI = Alu16.Inc(DI);
        // 3358:15DA mov AL,AH
        AL = AH;
        // 3358:15DC or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:15DE jne short 0x15A9
        if (!ZeroFlag)
        {
            goto label_3358_15A9_34B29_7337;
        }
    label_3358_15E0_34B60_7371:
        CheckExternalEvents(cs2, 0x15E0);
        // 3358:15E0 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:15E3 dec BP
        BP = Alu16.Dec(BP);
        // 3358:15E4 jne short 0x158E
        if (!ZeroFlag)
        {
            goto label_3358_158E_34B0E_7324;
        }
    label_3358_15E6_34B66_7375:
        CheckExternalEvents(cs2, 0x15E6);
        // 3358:15E6 pop DI
        DI = Stack.Pop16();
        // 3358:15E7 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:15EB loop 0x158A
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_158A_34B0A_7460;
        }
    label_3358_15ED_34B6D_7383:
        CheckExternalEvents(cs2, 0x15ED);
        // 3358:15ED ret far
        return FarRet((ushort)0x0000);
    label_3358_15EE_34B6E_7368:
        CheckExternalEvents(cs2, 0x15EE);
        // 3358:15EE shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:15F0 je short 0x15E0
        if (ZeroFlag)
        {
            goto label_3358_15E0_34B60_7371;
        }
    label_3358_15F2_34B72_7379:
        CheckExternalEvents(cs2, 0x15F2);
        // 3358:15F2 inc DI
        DI = Alu16.Inc(DI);
        // 3358:15F3 jmp short 0x15B2
        goto label_3358_15B2_34B32_7344;
    label_3358_15F5_34B75_7461:
        CheckExternalEvents(cs2, 0x15F5);
        // 3358:15F5 inc DI
        DI = Alu16.Inc(DI);
        // 3358:15F6 dec BP
        BP = Alu16.Dec(BP);
        // 3358:15F7 jne short 0x158E
        if (!ZeroFlag)
        {
            goto label_3358_158E_34B0E_7324;
        }
    label_3358_15F9_34B79_7616:
        CheckExternalEvents(cs2, 0x15F9);
        // 3358:15F9 jmp short 0x15E6
        goto label_3358_15E6_34B66_7375;
    }

    public virtual Action unknown_3358_197B_34EFB(int loadOffset)
    {
    label_3358_197B_34EFB_6682:
        CheckExternalEvents(cs2, 0x197B);
        // 3358:197B mov AH,AL
        AH = AL;
        // 3358:197D push AX
        Stack.Push16(AX);
        // 3358:197E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:197F mov DX,AX
        DX = AX;
        // 3358:1981 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1982 mov BX,AX
        BX = AX;
        // 3358:1984 call near 0x0C10
        NearCall(cs2, 0x1987, unknown_3358_0C10_34190);
    label_3358_1987_34F07_6689:
        CheckExternalEvents(cs2, 0x1987);
        // 3358:1987 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1988 mov BP,AX
        BP = AX;
        // 3358:198A sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 3358:198C jbe short 0x19C7
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_19C7_34F47_20202;
        }
    label_3358_198E_34F0E_6694:
        CheckExternalEvents(cs2, 0x198E);
        // 3358:198E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:198F sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:1991 jae short 0x19C7
        if (!CarryFlag)
        {
            goto label_3358_19C7_34F47_20202;
        }
    label_3358_1993_34F13_6698:
        CheckExternalEvents(cs2, 0x1993);
        // 3358:1993 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 3358:1995 pop AX
        AX = Stack.Pop16();
        // 3358:1996 mov SI,DI
        SI = DI;
        // 3358:1998 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:199A jb short 0x19AC
        if (CarryFlag)
        {
            goto label_3358_19AC_34F2C_14241;
        }
    label_3358_199C_34F1C_6704:
        CheckExternalEvents(cs2, 0x199C);
        // 3358:199C je short 0x19C6
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:199C");
        }
    label_3358_199E_34F1E_6706:
        CheckExternalEvents(cs2, 0x199E);
        // 3358:199E mov DI,SI
        DI = SI;
        // 3358:19A0 mov CX,BP
        CX = BP;
        // 3358:19A2 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:19A4 add SI,0x0140
        SI = Alu16.Add(SI, (ushort)0x0140);
        // 3358:19A8 dec BX
        BX = Alu16.Dec(BX);
        // 3358:19A9 jne short 0x199E
        if (!ZeroFlag)
        {
            goto label_3358_199E_34F1E_6706;
        }
    label_3358_19AB_34F2B_6713:
        CheckExternalEvents(cs2, 0x19AB);
        // 3358:19AB ret far
        return FarRet((ushort)0x0000);
    label_3358_19AC_34F2C_14241:
        CheckExternalEvents(cs2, 0x19AC);
        // 3358:19AC je short 0x19BD
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:19AC");
        }
    label_3358_19AE_34F2E_14243:
        CheckExternalEvents(cs2, 0x19AE);
        // 3358:19AE mov DI,SI
        DI = SI;
        // 3358:19B0 mov CX,BP
        CX = BP;
        // 3358:19B2 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:19B4 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:19B5 add SI,0x0140
        SI = Alu16.Add(SI, (ushort)0x0140);
        // 3358:19B9 dec BX
        BX = Alu16.Dec(BX);
        // 3358:19BA jne short 0x19AE
        if (!ZeroFlag)
        {
            goto label_3358_19AE_34F2E_14243;
        }
    label_3358_19BC_34F3C_14251:
        CheckExternalEvents(cs2, 0x19BC);
        // 3358:19BC ret far
        return FarRet((ushort)0x0000);
    label_3358_19C7_34F47_20202:
        CheckExternalEvents(cs2, 0x19C7);
        // 3358:19C7 pop AX
        AX = Stack.Pop16();
        // 3358:19C8 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2183_35703(int loadOffset)
    {
    label_3358_2183_35703_17710:
        CheckExternalEvents(cs2, 0x2183);
        // 3358:2183 push word ptr CS:[0x01B3]
        Stack.Push16(UInt16[CS, (ushort)0x01B3]);
        // 3358:2188 push DI
        Stack.Push16(DI);
        // 3358:2189 push word ptr CS:[0x01B5]
        Stack.Push16(UInt16[CS, (ushort)0x01B5]);
        // 3358:218E push BX
        Stack.Push16(BX);
        // 3358:218F push BP
        Stack.Push16(BP);
        // 3358:2190 push SI
        Stack.Push16(SI);
        // 3358:2191 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 3358:2193 mov AX,DS
        AX = DS;
        // 3358:2195 mov ES,AX
        ES = AX;
        // 3358:2197 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:2199 div CX
        ushort divisor_3358_2199_35719 = CX;
        uint dividend_3358_2199_35719 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_3358_2199_35719 = Alu16.Div(unchecked((uint)dividend_3358_2199_35719), unchecked((ushort)divisor_3358_2199_35719));
        AX = unchecked((ushort)quotient_3358_2199_35719);
        DX = unchecked((ushort)(dividend_3358_2199_35719 % unchecked((uint)divisor_3358_2199_35719)));
        // 3358:219B mov word ptr CS:[0x01AD],AX
        UInt16[CS, (ushort)0x01AD] = AX;
        // 3358:219F mov word ptr CS:[0x01AF],AX
        UInt16[CS, (ushort)0x01AF] = AX;
        // 3358:21A3 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:21A5 mov DX,AX
        DX = AX;
        // 3358:21A7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:21A9 mov CX,DX
        CX = DX;
        // 3358:21AB add CX,AX
        CX = Alu16.Add(CX, AX);
        // 3358:21AD add AX,0x0080
        AX = Alu16.Add(AX, (ushort)0x0080);
        // 3358:21B0 add CX,0x0080
        CX = Alu16.Add(CX, (ushort)0x0080);
        // 3358:21B4 add DX,0x0080
        DX = Alu16.Add(DX, (ushort)0x0080);
        // 3358:21B8 mov CL,CH
        CL = CH;
        // 3358:21BA mov CH,AH
        CH = AH;
        // 3358:21BC mov DL,DH
        DL = DH;
        // 3358:21BE mov word ptr CS:[0x01B1],CX
        UInt16[CS, (ushort)0x01B1] = CX;
    label_3358_21C3_35743_17736:
        CheckExternalEvents(cs2, 0x21C3);
        // 3358:21C3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:21C4 mov AH,byte ptr DS:[DI]
        AH = UInt8[DS, DI];
        // 3358:21C6 inc DI
        DI = Alu16.Inc(DI);
        // 3358:21C7 sub AH,AL
        AH = Alu8.Sub(AH, AL);
        // 3358:21C9 sar AH,1
        AH = Alu8.Sar(AH, 1);
        // 3358:21CB sar AH,1
        AH = Alu8.Sar(AH, 1);
        // 3358:21CD add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:21CF mov byte ptr SS:[BP],AL
        UInt8[SS, (ushort)(BP + (sbyte)0)] = AL;
        // 3358:21D2 inc BP
        BP = Alu16.Inc(BP);
        // 3358:21D3 add CH,byte ptr CS:[0x01B2]
        CH = Alu8.Add(CH, UInt8[CS, (ushort)0x01B2]);
        // 3358:21D8 jb short 0x220B
        if (CarryFlag)
        {
            goto label_3358_220B_3578B_32064;
        }
    label_3358_21DA_3575A_17747:
        CheckExternalEvents(cs2, 0x21DA);
        // 3358:21DA add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:21DC mov byte ptr DS:[BX],AL
        UInt8[DS, BX] = AL;
        // 3358:21DE inc BX
        BX = Alu16.Inc(BX);
        // 3358:21DF add DL,DH
        DL = Alu8.Add(DL, DH);
        // 3358:21E1 jb short 0x2211
        if (CarryFlag)
        {
            goto label_3358_2211_35791_26181;
        }
    label_3358_21E3_35763_17753:
        CheckExternalEvents(cs2, 0x21E3);
        // 3358:21E3 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:21E5 xchg DI,word ptr CS:[0x01B5]
        ushort xchgOffset_3358_21E5_35765 = (ushort)0x01B5;
        ushort temp_3358_21E5_35765 = DI;
        DI = UInt16[CS, xchgOffset_3358_21E5_35765];
        UInt16[CS, xchgOffset_3358_21E5_35765] = unchecked((ushort)temp_3358_21E5_35765);
        // 3358:21EA stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:21EB add CL,byte ptr CS:[0x01B1]
        CL = Alu8.Add(CL, UInt8[CS, (ushort)0x01B1]);
        // 3358:21F0 jb short 0x2216
        if (CarryFlag)
        {
            goto label_3358_2216_35796_17772;
        }
    label_3358_21F2_35772_17759:
        CheckExternalEvents(cs2, 0x21F2);
        // 3358:21F2 xchg DI,word ptr CS:[0x01B5]
        ushort xchgOffset_3358_21F2_35772 = (ushort)0x01B5;
        ushort temp_3358_21F2_35772 = DI;
        DI = UInt16[CS, xchgOffset_3358_21F2_35772];
        UInt16[CS, xchgOffset_3358_21F2_35772] = unchecked((ushort)temp_3358_21F2_35772);
        // 3358:21F7 mov AX,word ptr CS:[0x01AD]
        AX = UInt16[CS, (ushort)0x01AD];
        // 3358:21FB add word ptr CS:[0x01AF],AX
        UInt16[CS, (ushort)0x01AF] = Alu16.Add(UInt16[CS, (ushort)0x01AF], AX);
        // 3358:2200 jb short 0x2219
        if (CarryFlag)
        {
            goto label_3358_2219_35799_17768;
        }
    label_3358_2202_35782_17764:
        CheckExternalEvents(cs2, 0x2202);
        // 3358:2202 dec word ptr CS:[0x01B3]
        UInt16[CS, (ushort)0x01B3] = Alu16.Dec(UInt16[CS, (ushort)0x01B3]);
        // 3358:2207 jne short 0x21C3
        if (!ZeroFlag)
        {
            goto label_3358_21C3_35743_17736;
        }
    label_3358_2209_35789_17775:
        CheckExternalEvents(cs2, 0x2209);
        // 3358:2209 jmp short 0x2221
        goto label_3358_2221_357A1_17777;
    label_3358_220B_3578B_32064:
        CheckExternalEvents(cs2, 0x220B);
        // 3358:220B mov byte ptr SS:[BP],AL
        UInt8[SS, (ushort)(BP + (sbyte)0)] = AL;
        // 3358:220E inc BP
        BP = Alu16.Inc(BP);
        // 3358:220F jmp short 0x21DA
        goto label_3358_21DA_3575A_17747;
    label_3358_2211_35791_26181:
        CheckExternalEvents(cs2, 0x2211);
        // 3358:2211 mov byte ptr DS:[BX],AL
        UInt8[DS, BX] = AL;
        // 3358:2213 inc BX
        BX = Alu16.Inc(BX);
        // 3358:2214 jmp short 0x21E3
        goto label_3358_21E3_35763_17753;
    label_3358_2216_35796_17772:
        CheckExternalEvents(cs2, 0x2216);
        // 3358:2216 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2217 jmp short 0x21F2
        goto label_3358_21F2_35772_17759;
    label_3358_2219_35799_17768:
        CheckExternalEvents(cs2, 0x2219);
        // 3358:2219 inc DI
        DI = Alu16.Inc(DI);
        // 3358:221A dec word ptr CS:[0x01B3]
        UInt16[CS, (ushort)0x01B3] = Alu16.Dec(UInt16[CS, (ushort)0x01B3]);
        // 3358:221F jne short 0x21C3
        if (!ZeroFlag)
        {
            goto label_3358_21C3_35743_17736;
        }
    label_3358_2221_357A1_17777:
        CheckExternalEvents(cs2, 0x2221);
        // 3358:2221 pop SI
        SI = Stack.Pop16();
        // 3358:2222 pop BP
        BP = Stack.Pop16();
        // 3358:2223 pop BX
        BX = Stack.Pop16();
        // 3358:2224 pop word ptr CS:[0x01B5]
        ushort popStackCheck_3358_2224_357A4 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_3358_2224_357A4 = UInt16[CS, (ushort)0x01B5];
        ushort poppedValue_3358_2224_357A4 = Stack.Pop16();
        UInt16[CS, (ushort)0x01B5] = unchecked((ushort)poppedValue_3358_2224_357A4);
        // 3358:2229 pop DI
        DI = Stack.Pop16();
        // 3358:222A pop word ptr CS:[0x01B3]
        ushort popStackCheck_3358_222A_357AA = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_3358_222A_357AA = UInt16[CS, (ushort)0x01B3];
        ushort poppedValue_3358_222A_357AA = Stack.Pop16();
        UInt16[CS, (ushort)0x01B3] = unchecked((ushort)poppedValue_3358_222A_357AA);
        // 3358:222F mov CX,word ptr CS:[0x01B1]
        CX = UInt16[CS, (ushort)0x01B1];
        // 3358:2234 mov DL,DH
        DL = DH;
        // 3358:2236 mov AX,word ptr CS:[0x01AD]
        AX = UInt16[CS, (ushort)0x01AD];
        // 3358:223A mov word ptr CS:[0x01AF],AX
        UInt16[CS, (ushort)0x01AF] = AX;
        // 3358:223E dec SI
        SI = Alu16.Dec(SI);
        // 3358:223F dec DI
        DI = Alu16.Dec(DI);
        // 3358:2240 dec word ptr CS:[0x01B5]
        UInt16[CS, (ushort)0x01B5] = Alu16.Dec(UInt16[CS, (ushort)0x01B5]);
        // 3358:2245 std
        DirectionFlag = true;
    label_3358_2246_357C6_17792:
        CheckExternalEvents(cs2, 0x2246);
        // 3358:2246 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:2247 mov AH,byte ptr DS:[DI]
        AH = UInt8[DS, DI];
        // 3358:2249 dec DI
        DI = Alu16.Dec(DI);
        // 3358:224A sub AH,AL
        AH = Alu8.Sub(AH, AL);
        // 3358:224C sar AH,1
        AH = Alu8.Sar(AH, 1);
        // 3358:224E sar AH,1
        AH = Alu8.Sar(AH, 1);
        // 3358:2250 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:2252 dec BP
        BP = Alu16.Dec(BP);
        // 3358:2253 mov byte ptr SS:[BP],AL
        UInt8[SS, (ushort)(BP + (sbyte)0)] = AL;
        // 3358:2256 add CH,byte ptr CS:[0x01B2]
        CH = Alu8.Add(CH, UInt8[CS, (ushort)0x01B2]);
        // 3358:225B jb short 0x228F
        if (CarryFlag)
        {
            goto label_3358_228F_3580F_32068;
        }
    label_3358_225D_357DD_17803:
        CheckExternalEvents(cs2, 0x225D);
        // 3358:225D add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:225F dec BX
        BX = Alu16.Dec(BX);
        // 3358:2260 mov byte ptr DS:[BX],AL
        UInt8[DS, BX] = AL;
        // 3358:2262 add DL,DH
        DL = Alu8.Add(DL, DH);
        // 3358:2264 jb short 0x2295
        if (CarryFlag)
        {
            goto label_3358_2295_35815_26185;
        }
    label_3358_2266_357E6_17809:
        CheckExternalEvents(cs2, 0x2266);
        // 3358:2266 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 3358:2268 xchg DI,word ptr CS:[0x01B5]
        ushort xchgOffset_3358_2268_357E8 = (ushort)0x01B5;
        ushort temp_3358_2268_357E8 = DI;
        DI = UInt16[CS, xchgOffset_3358_2268_357E8];
        UInt16[CS, xchgOffset_3358_2268_357E8] = unchecked((ushort)temp_3358_2268_357E8);
        // 3358:226D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:226E add CL,byte ptr CS:[0x01B1]
        CL = Alu8.Add(CL, UInt8[CS, (ushort)0x01B1]);
        // 3358:2273 jb short 0x229A
        if (CarryFlag)
        {
            goto label_3358_229A_3581A_17827;
        }
    label_3358_2275_357F5_17815:
        CheckExternalEvents(cs2, 0x2275);
        // 3358:2275 xchg DI,word ptr CS:[0x01B5]
        ushort xchgOffset_3358_2275_357F5 = (ushort)0x01B5;
        ushort temp_3358_2275_357F5 = DI;
        DI = UInt16[CS, xchgOffset_3358_2275_357F5];
        UInt16[CS, xchgOffset_3358_2275_357F5] = unchecked((ushort)temp_3358_2275_357F5);
        // 3358:227A mov AX,word ptr CS:[0x01AD]
        AX = UInt16[CS, (ushort)0x01AD];
        // 3358:227E add word ptr CS:[0x01AF],AX
        UInt16[CS, (ushort)0x01AF] = Alu16.Add(UInt16[CS, (ushort)0x01AF], AX);
        // 3358:2283 jb short 0x229D
        if (CarryFlag)
        {
            goto label_3358_229D_3581D_17824;
        }
    label_3358_2285_35805_17820:
        CheckExternalEvents(cs2, 0x2285);
        // 3358:2285 dec word ptr CS:[0x01B3]
        UInt16[CS, (ushort)0x01B3] = Alu16.Dec(UInt16[CS, (ushort)0x01B3]);
        // 3358:228A jne short 0x2246
        if (!ZeroFlag)
        {
            goto label_3358_2246_357C6_17792;
        }
    label_3358_228C_3580C_17830:
        CheckExternalEvents(cs2, 0x228C);
        // 3358:228C cld
        DirectionFlag = false;
        // 3358:228D jmp short 0x22A0
        goto label_3358_22A0_35820_17833;
    label_3358_228F_3580F_32068:
        CheckExternalEvents(cs2, 0x228F);
        // 3358:228F dec BP
        BP = Alu16.Dec(BP);
        // 3358:2290 mov byte ptr SS:[BP],AL
        UInt8[SS, (ushort)(BP + (sbyte)0)] = AL;
        // 3358:2293 jmp short 0x225D
        goto label_3358_225D_357DD_17803;
    label_3358_2295_35815_26185:
        CheckExternalEvents(cs2, 0x2295);
        // 3358:2295 dec BX
        BX = Alu16.Dec(BX);
        // 3358:2296 mov byte ptr DS:[BX],AL
        UInt8[DS, BX] = AL;
        // 3358:2298 jmp short 0x2266
        goto label_3358_2266_357E6_17809;
    label_3358_229A_3581A_17827:
        CheckExternalEvents(cs2, 0x229A);
        // 3358:229A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:229B jmp short 0x2275
        goto label_3358_2275_357F5_17815;
    label_3358_229D_3581D_17824:
        CheckExternalEvents(cs2, 0x229D);
        // 3358:229D dec DI
        DI = Alu16.Dec(DI);
        // 3358:229E jmp short 0x2285
        goto label_3358_2285_35805_17820;
    label_3358_22A0_35820_17833:
        CheckExternalEvents(cs2, 0x22A0);
        // 3358:22A0 pop BP
        BP = Stack.Pop16();
        // 3358:22A1 push BP
        Stack.Push16(BP);
        // 3358:22A2 sub BP,word ptr CS:[0x01BB]
        BP = Alu16.Sub(BP, UInt16[CS, (ushort)0x01BB]);
        // 3358:22A7 jb short 0x230A
        if (CarryFlag)
        {
            goto label_3358_230A_3588A_17838;
        }
    label_3358_22A9_35829_34988:
        CheckExternalEvents(cs2, 0x22A9);
        // 3358:22A9 mov AX,CS
        AX = CS;
        // 3358:22AB mov DS,AX
        DS = AX;
        // 3358:22AD add BP,word ptr CS:[0x01B9]
        BP = Alu16.Add(BP, UInt16[CS, (ushort)0x01B9]);
        // 3358:22B2 mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:22B7 add DI,0x00A0
        DI = Alu16.Add(DI, (ushort)0x00A0);
        // 3358:22BB xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:22BD xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:22BF mov BL,4
        BL = (byte)0x04;
    label_3358_22C1_35841_34997:
        CheckExternalEvents(cs2, 0x22C1);
        // 3358:22C1 mov SI,0x08EF
        SI = (ushort)0x08EF;
        // 3358:22C4 mov CL,byte ptr CS:[BP]
        CL = UInt8[CS, (ushort)(BP + (sbyte)0)];
        // 3358:22C8 mov BH,CL
        BH = CL;
        // 3358:22CA sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 3358:22CD ja short 0x22D9
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_22D9_35859_35026;
        }
    label_3358_22CF_3584F_35002:
        CheckExternalEvents(cs2, 0x22CF);
        // 3358:22CF neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:22D1 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:22D3 mov CL,BH
        CL = BH;
        // 3358:22D5 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:22D7 jmp short 0x22DF
        goto label_3358_22DF_3585F_35008;
    label_3358_22D9_35859_35026:
        CheckExternalEvents(cs2, 0x22D9);
        // 3358:22D9 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:22DB rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:22DD movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:22DE movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_3358_22DF_3585F_35008:
        CheckExternalEvents(cs2, 0x22DF);
        // 3358:22DF mov CL,byte ptr CS:[BP+1]
        CL = UInt8[CS, (ushort)(BP + (sbyte)1)];
        // 3358:22E3 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:22E5 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:22E7 mov CL,BH
        CL = BH;
        // 3358:22E9 sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 3358:22EC ja short 0x22F6
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_22F6_35876_35031;
        }
    label_3358_22EE_3586E_35015:
        CheckExternalEvents(cs2, 0x22EE);
        // 3358:22EE mov CL,BH
        CL = BH;
        // 3358:22F0 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:22F2 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:22F4 jmp short 0x22FC
        goto label_3358_22FC_3587C_35020;
    label_3358_22F6_35876_35031:
        CheckExternalEvents(cs2, 0x22F6);
        // 3358:22F6 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:22F7 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:22F8 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:22FA rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_22FC_3587C_35020:
        CheckExternalEvents(cs2, 0x22FC);
        // 3358:22FC add DI,0x0058
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)88)));
        // 3358:22FF add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:2302 dec BL
        BL = Alu8.Dec(BL);
        // 3358:2304 jne short 0x22C1
        if (!ZeroFlag)
        {
            goto label_3358_22C1_35841_34997;
        }
    label_3358_2306_35886_35036:
        CheckExternalEvents(cs2, 0x2306);
        // 3358:2306 mov AX,SS
        AX = SS;
        // 3358:2308 mov DS,AX
        DS = AX;
    label_3358_230A_3588A_17838:
        CheckExternalEvents(cs2, 0x230A);
        // 3358:230A mov ES,word ptr CS:[0x01AB]
        ES = UInt16[CS, (ushort)0x01AB];
        // 3358:230F mov CX,0x0138
        CX = (ushort)0x0138;
        // 3358:2312 mov DI,word ptr CS:[0x1CB2]
        DI = UInt16[CS, (ushort)0x1CB2];
        // 3358:2317 mov SI,word ptr CS:[0x01A5]
        SI = UInt16[CS, (ushort)0x01A5];
        // 3358:231C add SI,0x00A0
        SI = Alu16.Add(SI, (ushort)0x00A0);
        // 3358:2320 call near 0x2343
        NearCall(cs2, 0x2323, unknown_3358_2343_358C3);
    label_3358_2323_358A3_17877:
        CheckExternalEvents(cs2, 0x2323);
        // 3358:2323 mov word ptr CS:[0x1CB2],DI
        UInt16[CS, (ushort)0x1CB2] = DI;
        // 3358:2328 mov AX,DS
        AX = DS;
        // 3358:232A mov ES,AX
        ES = AX;
        // 3358:232C mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:2331 add DI,0x008C
        DI = Alu16.Add(DI, (ushort)0x008C);
        // 3358:2335 mov SI,DI
        SI = DI;
        // 3358:2337 add SI,0x0640
        SI = Alu16.Add(SI, (ushort)0x0640);
        // 3358:233B mov CX,0x015E
        CX = (ushort)0x015E;
        // 3358:233E rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2340 pop BP
        BP = Stack.Pop16();
        // 3358:2341 pop DX
        DX = Stack.Pop16();
        // 3358:2342 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_254F_35ACF(int loadOffset)
    {
    label_3358_254F_35ACF_6515:
        CheckExternalEvents(cs2, 0x254F);
        // 3358:254F push DX
        Stack.Push16(DX);
        // 3358:2550 mov DX,word ptr CS:[0x019F]
        DX = UInt16[CS, (ushort)0x019F];
    label_3358_2555_35AD5_6518:
        CheckExternalEvents(cs2, 0x2555);
        // 3358:2555 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 3358:2556 and AL,8
        AL = Alu8.And(AL, (byte)0x08);
        // 3358:2558 cmp AL,byte ptr CS:[0x01A2]
        Alu8.Sub(AL, UInt8[CS, (ushort)0x01A2]);
        // 3358:255D jne short 0x2555
        if (!ZeroFlag)
        {
            goto label_3358_2555_35AD5_6518;
        }
    label_3358_255F_35ADF_6523:
        CheckExternalEvents(cs2, 0x255F);
        // 3358:255F pop DX
        DX = Stack.Pop16();
        // 3358:2560 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2563 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2885_35E05(int loadOffset)
    {
    label_3358_2885_35E05_11197:
        CheckExternalEvents(cs2, 0x2885);
        // 3358:2885 pop BX
        BX = Stack.Pop16();
        // 3358:2886 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_3082_36602(int loadOffset)
    {
    label_3358_3082_36602_32473:
        CheckExternalEvents(cs2, 0x3082);
        // 3358:3082 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:3085 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:3087 cmp AX,0x0024
        Alu16.Sub(AX, (ushort)0x0024);
        // 3358:308A pop CX
        CX = Stack.Pop16();
        // 3358:308B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_05A9_5C089(int loadOffset)
    {
    label_5BAE_05A9_5C089_5957:
        CheckExternalEvents(cs4, 0x05A9);
        // 5BAE:05A9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_07E9_5C2C9(int loadOffset)
    {
    label_5BAE_07E9_5C2C9_5027:
        CheckExternalEvents(cs4, 0x07E9);
        // 5BAE:07E9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0986_5C466(int loadOffset)
    {
    label_5BAE_0986_5C466_3794:
        CheckExternalEvents(cs4, 0x0986);
        // 5BAE:0986 mov AH,0x26
        AH = (byte)0x26;
        // 5BAE:0988 push DX
        Stack.Push16(DX);
        // 5BAE:0989 mov DX,word ptr CS:[0x02B3]
        DX = UInt16[CS, (ushort)0x02B3];
        // 5BAE:098E add DL,4
        DL = Alu8.Add(DL, (byte)0x04);
        // 5BAE:0991 xchg AL,AH
        byte temp_5BAE_0991_5C471 = AL;
        AL = AH;
        AH = unchecked((byte)temp_5BAE_0991_5C471);
        // 5BAE:0993 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5BAE:0994 inc DX
        DX = Alu16.Inc(DX);
        // 5BAE:0995 xchg AL,AH
        byte temp_5BAE_0995_5C475 = AL;
        AL = AH;
        AH = unchecked((byte)temp_5BAE_0995_5C475);
        // 5BAE:0997 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5BAE:0998 pop DX
        DX = Stack.Pop16();
        // 5BAE:0999 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_09DC_5C4BC(int loadOffset)
    {
    label_5BAE_09DC_5C4BC_3910:
        CheckExternalEvents(cs4, 0x09DC);
        // 5BAE:09DC and AH,3
        AH = Alu8.And(AH, (byte)0x03);
        // 5BAE:09DF mov AL,0xE0
        AL = (byte)0xE0;
        // 5BAE:09E1 add AL,DL
        AL = Alu8.Add(AL, DL);
        // 5BAE:09E3 call near 0x0AA2
        NearCall(cs4, 0x09E6, unknown_5BAE_0AA2_5C582);
    label_5BAE_09E6_5C4C6_3914:
        CheckExternalEvents(cs4, 0x09E6);
        // 5BAE:09E6 mov AH,byte ptr DS:[SI+8]
        AH = UInt8[DS, (ushort)(SI + (sbyte)8)];
        // 5BAE:09E9 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 5BAE:09EB shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 5BAE:09ED shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 5BAE:09EF ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:09F1 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:09F3 mov AL,0x40
        AL = (byte)0x40;
        // 5BAE:09F5 add AL,DL
        AL = Alu8.Add(AL, DL);
        // 5BAE:09F7 call near 0x0AA2
        NearCall(cs4, 0x09FA, unknown_5BAE_0AA2_5C582);
    label_5BAE_09FA_5C4DA_3924:
        CheckExternalEvents(cs4, 0x09FA);
        // 5BAE:09FA mov AH,byte ptr DS:[SI+3]
        AH = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 5BAE:09FD mov AL,byte ptr DS:[SI+6]
        AL = UInt8[DS, (ushort)(SI + (sbyte)6)];
        // 5BAE:0A00 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A02 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A04 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A06 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A08 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A0A shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A0C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A0E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A10 mov AL,0x60
        AL = (byte)0x60;
        // 5BAE:0A12 add AL,DL
        AL = Alu8.Add(AL, DL);
        // 5BAE:0A14 call near 0x0AA2
        NearCall(cs4, 0x0A17, unknown_5BAE_0AA2_5C582);
    label_5BAE_0A17_5C4F7_3938:
        CheckExternalEvents(cs4, 0x0A17);
        // 5BAE:0A17 mov AH,byte ptr DS:[SI+4]
        AH = UInt8[DS, (ushort)(SI + (sbyte)4)];
        // 5BAE:0A1A mov AL,byte ptr DS:[SI+7]
        AL = UInt8[DS, (ushort)(SI + (sbyte)7)];
        // 5BAE:0A1D shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A1F shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A21 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A23 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0A25 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A27 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A29 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A2B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0A2D mov AL,0x80
        AL = (byte)0x80;
        // 5BAE:0A2F add AL,DL
        AL = Alu8.Add(AL, DL);
        // 5BAE:0A31 call near 0x0AA2
        NearCall(cs4, 0x0A34, unknown_5BAE_0AA2_5C582);
    label_5BAE_0A34_5C514_3952:
        CheckExternalEvents(cs4, 0x0A34);
        // 5BAE:0A34 mov AL,byte ptr DS:[SI+0x0B]
        AL = UInt8[DS, (ushort)(SI + (sbyte)11)];
        // 5BAE:0A37 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0A39 mov AL,byte ptr DS:[SI+5]
        AL = UInt8[DS, (ushort)(SI + (sbyte)5)];
        // 5BAE:0A3C ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0A3E mov AL,byte ptr DS:[SI+0x0A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)10)];
        // 5BAE:0A41 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0A43 mov AL,byte ptr DS:[SI+9]
        AL = UInt8[DS, (ushort)(SI + (sbyte)9)];
        // 5BAE:0A46 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0A48 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 5BAE:0A4B and AX,0xF00F
        AX = Alu16.And(AX, (ushort)0xF00F);
        // 5BAE:0A4E or AH,AL
        AH = Alu8.Or(AH, AL);
        // 5BAE:0A50 mov AL,0x20
        AL = (byte)0x20;
        // 5BAE:0A52 add AL,DL
        AL = Alu8.Add(AL, DL);
        // 5BAE:0A54 call near 0x0AA2
        NearCall(cs4, 0x0A57, unknown_5BAE_0AA2_5C582);
    label_5BAE_0A57_5C537_3967:
        CheckExternalEvents(cs4, 0x0A57);
        // 5BAE:0A57 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0F13_10FE3(int loadOffset)
    {
    entrydispatcher:
    label_100D_0F13_10FE3_39793:
        CheckExternalEvents(cs1, 0x0F13);
        // 100D:0F13 call near 0xC412
        NearCall(cs1, 0x0F16, unknown_100D_C412_1C4E2);
    label_100D_0F16_10FE6_39796:
        CheckExternalEvents(cs1, 0x0F16);
        // 100D:0F16 mov word ptr DS:[0x47C4],7
        UInt16[DS, (ushort)0x47C4] = (ushort)0x0007;
        // 100D:0F1C call near 0x9197
        NearCall(cs1, 0x0F1F, unknown_100D_9197_19267);
    label_100D_0F1F_10FEF_39801:
        CheckExternalEvents(cs1, 0x0F1F);
        // 100D:0F1F mov byte ptr DS:[0x478C],0
        UInt8[DS, (ushort)0x478C] = (byte)0x00;
        // 100D:0F24 add word ptr DS:[0x1BF2],0x000F
        UInt16[DS, (ushort)0x1BF2] = Alu16.Add(UInt16[DS, (ushort)0x1BF2], unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:0F29 call near 0x978E
        NearCall(cs1, 0x0F2C, unknown_100D_978E_1985E);
    label_100D_0F2C_10FFC_39808:
        CheckExternalEvents(cs1, 0x0F2C);
        // 100D:0F2C call near 0x998E
        NearCall(cs1, 0x0F2F, unknown_100D_998E_19A5E);
    label_100D_0F2F_10FFF_39853:
        CheckExternalEvents(cs1, 0x0F2F);
        // 100D:0F2F mov word ptr DS:[0x22A6],0xFFFF
        UInt16[DS, (ushort)0x22A6] = (ushort)0xFFFF;
        // 100D:0F35 inc byte ptr DS:[0x47C3]
        UInt8[DS, (ushort)0x47C3] = Alu8.Inc(UInt8[DS, (ushort)0x47C3]);
        // 100D:0F39 mov word ptr DS:[0x47C6],1
        UInt16[DS, (ushort)0x47C6] = (ushort)0x0001;
        // 100D:0F3F call near 0xC412
        NearCall(cs1, 0x0F42, unknown_100D_C412_1C4E2);
    label_100D_0F42_11012_39862:
        CheckExternalEvents(cs1, 0x0F42);
        // 100D:0F42 mov DX,0x002D
        DX = (ushort)0x002D;
        // 100D:0F45 jmp near 0x0965
        if (JumpDispatcher.Jump(unknown_100D_0965_10A35, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0965_10A35(int loadOffset)
    {
    entrydispatcher:
    label_100D_0965_10A35_9518:
        CheckExternalEvents(cs1, 0x0965);
        // 100D:0965 mov AL,0x2D
        AL = (byte)0x2D;
        // 100D:0967 call near 0x09C7
        NearCall(cs1, 0x096A, unknown_100D_09C7_10A97);
    label_100D_096A_10A3A_9535:
        CheckExternalEvents(cs1, 0x096A);
        // 100D:096A mov byte ptr DS:[0x478C],1
        UInt8[DS, (ushort)0x478C] = (byte)0x01;
        // 100D:096F jmp near 0x978E
        if (JumpDispatcher.Jump(unknown_100D_978E_1985E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_26DA_127AA(int loadOffset)
    {
    label_100D_26DA_127AA_30912:
        CheckExternalEvents(cs1, 0x26DA);
        // 100D:26DA call near 0xE270
        NearCall(cs1, 0x26DD, unknown_100D_E270_1E340);
    label_100D_26DD_127AD_30914:
        CheckExternalEvents(cs1, 0x26DD);
        // 100D:26DD mov CL,byte ptr DS:[0x00C8]
        CL = UInt8[DS, (ushort)0x00C8];
        // 100D:26E1 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:26E3 jcxz short 0x26F1
        if (CX == (ushort)0x0000)
        {
            goto label_100D_26F1_127C1_30918;
        }
    label_100D_26E5_127B5_32356:
        CheckExternalEvents(cs1, 0x26E5);
        // 100D:26E5 mov SI,0x1179
        SI = (ushort)0x1179;
    label_100D_26E8_127B8_32358:
        CheckExternalEvents(cs1, 0x26E8);
        // 100D:26E8 cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:26EA je short 0x272B
        if (ZeroFlag)
        {
            goto label_100D_272B_127FB_30932;
        }
    label_100D_26EC_127BC_32360:
        CheckExternalEvents(cs1, 0x26EC);
        // 100D:26EC add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:26EF loop 0x26E8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_26E8_127B8_32358;
        }
    label_100D_26F1_127C1_30918:
        CheckExternalEvents(cs1, 0x26F1);
        // 100D:26F1 mov CL,byte ptr DS:[0x00C8]
        CL = UInt8[DS, (ushort)0x00C8];
        // 100D:26F5 mov SI,0x1179
        SI = (ushort)0x1179;
        // 100D:26F8 cmp CL,0x0A
        Alu8.Sub(CL, (byte)0x0A);
        // 100D:26FB jb short 0x2707
        if (CarryFlag)
        {
            goto label_100D_2707_127D7_30923;
        }
    label_100D_26FD_127CD_35795:
        CheckExternalEvents(cs1, 0x26FD);
        // 100D:26FD push AX
        Stack.Push16(AX);
        // 100D:26FE call near 0x272F
        NearCall(cs1, 0x2701, unknown_100D_272F_127FF);
    label_100D_2701_127D1_35814:
        CheckExternalEvents(cs1, 0x2701);
        // 100D:2701 mov CL,9
        CL = (byte)0x09;
        // 100D:2703 mov SI,0x1179
        SI = (ushort)0x1179;
        // 100D:2706 pop AX
        AX = Stack.Pop16();
    label_100D_2707_127D7_30923:
        CheckExternalEvents(cs1, 0x2707);
        // 100D:2707 add CL,CL
        CL = Alu8.Add(CL, CL);
        // 100D:2709 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:270B add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:270D mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:270F inc byte ptr DS:[0x00C8]
        UInt8[DS, (ushort)0x00C8] = Alu8.Inc(UInt8[DS, (ushort)0x00C8]);
        // 100D:2713 inc byte ptr DS:[0x00C9]
        UInt8[DS, (ushort)0x00C9] = Alu8.Inc(UInt8[DS, (ushort)0x00C9]);
        // 100D:2717 cmp byte ptr DS:[0x002A],0x38
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x38);
        // 100D:271C jb short 0x272B
        if (CarryFlag)
        {
            goto label_100D_272B_127FB_30932;
        }
    label_100D_271E_127EE_34116:
        CheckExternalEvents(cs1, 0x271E);
        // 100D:271E cmp byte ptr DS:[0x000B],8
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x08);
        // 100D:2723 je short 0x272B
        if (ZeroFlag)
        {
            goto label_100D_272B_127FB_30932;
        }
    label_100D_2725_127F5_34119:
        CheckExternalEvents(cs1, 0x2725);
        // 100D:2725 mov AX,0x0201
        AX = (ushort)0x0201;
        // 100D:2728 call near 0x29EE
        NearCall(cs1, 0x272B, unknown_100D_29EE_12ABE);
    label_100D_272B_127FB_30932:
        CheckExternalEvents(cs1, 0x272B);
        // 100D:272B call near 0xE283
        NearCall(cs1, 0x272E, unknown_100D_E283_1E353);
    label_100D_272E_127FE_30934:
        CheckExternalEvents(cs1, 0x272E);
        // 100D:272E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_68EA_169BA(int loadOffset)
    {
    label_100D_68EA_169BA_35533:
        CheckExternalEvents(cs1, 0x68EA);
        // 100D:68EA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7429_174F9(int loadOffset)
    {
    entrydispatcher:
    label_100D_7429_174F9_36381:
        CheckExternalEvents(cs1, 0x7429);
        // 100D:7429 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:742D je short 0x7434
        if (ZeroFlag)
        {
            goto label_100D_7434_17504_36384;
        }
    label_100D_742F_174FF_37120:
        CheckExternalEvents(cs1, 0x742F);
        // 100D:742F mov AL,7
        AL = (byte)0x07;
        // 100D:7431 call near 0x71B2
        NearCall(cs1, 0x7434, unknown_100D_71B2_17282);
    label_100D_7434_17504_36384:
        CheckExternalEvents(cs1, 0x7434);
        // 100D:7434 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:7438 jae short 0x7443
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7443_17513, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_743A_1750A_38331:
        CheckExternalEvents(cs1, 0x743A);
        // 100D:743A and byte ptr DS:[DI+0x0A],0xFD
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0xFD);
        // 100D:743E mov BP,0x75AF
        BP = (ushort)0x75AF;
        // 100D:7441 jmp short 0x7479
        if (JumpDispatcher.Jump(unknown_100D_7479_17549, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_7479_17549(int loadOffset)
    {
    entrydispatcher:
    label_100D_7479_17549_36447:
        CheckExternalEvents(cs1, 0x7479);
        // 100D:7479 call near 0x6603
        NearCall(cs1, 0x747C, unknown_100D_6603_166D3);
    label_100D_747C_1754C_36477:
        CheckExternalEvents(cs1, 0x747C);
        // 100D:747C xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:747E test word ptr DS:[0],3
        Alu16.And(UInt16[DS, (ushort)0x0000], (ushort)0x0003);
        // 100D:7484 jne short 0x7487
        if (!ZeroFlag)
        {
            goto label_100D_7487_17557_36481;
        }
    label_100D_7486_17556_38145:
        CheckExternalEvents(cs1, 0x7486);
        // 100D:7486 inc DX
        DX = Alu16.Inc(DX);
    label_100D_7487_17557_36481:
        CheckExternalEvents(cs1, 0x7487);
        // 100D:7487 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:7489 mov BP,0x762A
        BP = (ushort)0x762A;
        // 100D:748C call near 0x6603
        NearCall(cs1, 0x748F, unknown_100D_6603_166D3);
    label_100D_748F_1755F_36492:
        CheckExternalEvents(cs1, 0x748F);
        // 100D:748F cmp CX,DX
        Alu16.Sub(CX, DX);
        // 100D:7491 ja short 0x7487
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_7487_17557_36481;
        }
    label_100D_7493_17563_36495:
        CheckExternalEvents(cs1, 0x7493);
        // 100D:7493 push SI
        Stack.Push16(SI);
        // 100D:7494 push DI
        Stack.Push16(DI);
        // 100D:7495 call near 0x1CDA
        NearCall(cs1, 0x7498, unknown_100D_1CDA_11DAA);
    label_100D_7498_17568_36501:
        CheckExternalEvents(cs1, 0x7498);
        // 100D:7498 cmp DL,1
        Alu8.Sub(DL, (byte)0x01);
        // 100D:749B ja short 0x74B1
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_74B1_17581_36504;
        }
    label_100D_749D_1756D_41011:
        CheckExternalEvents(cs1, 0x749D);
        // 100D:749D mov byte ptr DS:[0x00C2],1
        UInt8[DS, (ushort)0x00C2] = (byte)0x01;
        // 100D:74A2 and byte ptr DS:[0x0FF7],0xFD
        UInt8[DS, (ushort)0x0FF7] = Alu8.And(UInt8[DS, (ushort)0x0FF7], (byte)0xFD);
        // 100D:74A7 and byte ptr DS:[0x1007],0xFD
        UInt8[DS, (ushort)0x1007] = Alu8.And(UInt8[DS, (ushort)0x1007], (byte)0xFD);
        // 100D:74AC pop DI
        DI = Stack.Pop16();
        // 100D:74AD call near 0x765E
        NearCall(cs1, 0x74B0, unknown_100D_765E_1772E);
    label_100D_74B0_17580_41054:
        CheckExternalEvents(cs1, 0x74B0);
        // 100D:74B0 push DI
        Stack.Push16(DI);
    label_100D_74B1_17581_36504:
        CheckExternalEvents(cs1, 0x74B1);
        // 100D:74B1 pop DI
        DI = Stack.Pop16();
        // 100D:74B2 pop SI
        SI = Stack.Pop16();
        // 100D:74B3 jmp near 0x5D50
        return unknown_100D_5D50_15E20(0x0000);
    }

    public virtual Action unknown_100D_765D_1772D(int loadOffset)
    {
    label_100D_765D_1772D_36616:
        CheckExternalEvents(cs1, 0x765D);
        // 100D:765D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A788_1A858(int loadOffset)
    {
    label_100D_A788_1A858_3578:
        CheckExternalEvents(cs1, 0xA788);
        // 100D:A788 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AFE6_1B0B6(int loadOffset)
    {
    entrydispatcher:
    label_100D_AFE6_1B0B6_16510:
        CheckExternalEvents(cs1, 0xAFE6);
        // 100D:AFE6 mov BX,word ptr DS:[0x2406]
        BX = UInt16[DS, (ushort)0x2406];
        // 100D:AFEA mov SI,word ptr DS:[0x11BF]
        SI = UInt16[DS, (ushort)0x11BF];
        // 100D:AFEE call near 0xB150
        NearCall(cs1, 0xAFF1, unknown_100D_B150_1B220);
    label_100D_AFF1_1B0C1_16515:
        CheckExternalEvents(cs1, 0xAFF1);
        // 100D:AFF1 je short 0xB006
        if (ZeroFlag)
        {
            goto label_100D_B006_1B0D6_40182;
        }
    label_100D_AFF3_1B0C3_16517:
        CheckExternalEvents(cs1, 0xAFF3);
        // 100D:AFF3 mov word ptr DS:[0x11BF],DI
        UInt16[DS, (ushort)0x11BF] = DI;
        // 100D:AFF7 call near 0xB1AF
        NearCall(cs1, 0xAFFA, unknown_100D_B1AF_1B27F);
    label_100D_AFFA_1B0CA_16555:
        CheckExternalEvents(cs1, 0xAFFA);
        // 100D:AFFA mov BP,0xB039
        BP = (ushort)0xB039;
        // 100D:AFFD call near 0xB02C
        NearCall(cs1, 0xB000, unknown_100D_B02C_1B0FC);
    label_100D_B000_1B0D0_17121:
        CheckExternalEvents(cs1, 0xB000);
        // 100D:B000 call near 0x9901
        NearCall(cs1, 0xB003, unknown_100D_9901_199D1);
    label_100D_B003_1B0D3_17123:
        CheckExternalEvents(cs1, 0xB003);
        // 100D:B003 jmp near 0xD397
        if (JumpDispatcher.Jump(unknown_100D_D397_1D467, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B006_1B0D6_40182:
        CheckExternalEvents(cs1, 0xB006);
        // 100D:B006 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:B008 js short 0xB024
        if (SignFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_B024_1B0F4, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_B00A_1B0DA_40186:
        CheckExternalEvents(cs1, 0xB00A);
        // 100D:B00A test byte ptr DS:[0x00C6],4
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x04);
        // 100D:B00F jne short 0xAFC6
        if (!ZeroFlag)
        {
            return unknown_100D_AFC6_1B096(0x0000);
        }
    label_100D_B011_1B0E1_40190:
        CheckExternalEvents(cs1, 0xB011);
        // 100D:B011 or byte ptr DS:[0x00C6],4
        UInt8[DS, (ushort)0x00C6] = Alu8.Or(UInt8[DS, (ushort)0x00C6], (byte)0x04);
        // 100D:B016 call near 0x09F5
        NearCall(cs1, 0xB019, unknown_100D_09F5_10AC5);
    label_100D_B019_1B0E9_40231:
        CheckExternalEvents(cs1, 0xB019);
        // 100D:B019 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:B01B call near 0xB1AF
        NearCall(cs1, 0xB01E, unknown_100D_B1AF_1B27F);
    label_100D_B01E_1B0EE_40236:
        CheckExternalEvents(cs1, 0xB01E);
        // 100D:B01E mov BP,0x1797
        BP = (ushort)0x1797;
        // 100D:B021 jmp short 0xB02C
        if (JumpDispatcher.Jump(unknown_100D_B02C_1B0FC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B9D8_1BAA8(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9D8_1BAA8_36795:
        CheckExternalEvents(cs1, 0xB9D8);
        // 100D:B9D8 jae short 0xB9DF
        if (!CarryFlag)
        {
            return unknown_100D_B9DF_1BAAF(0x0000);
        }
    label_100D_B9DA_1BAAA_36796:
        CheckExternalEvents(cs1, 0xB9DA);
        // 100D:B9DA call near 0xB9E0
        NearCall(cs1, 0xB9DD, unknown_100D_B9E0_1BAB0);
    label_100D_B9DD_1BAAD_36798:
        CheckExternalEvents(cs1, 0xB9DD);
        // 100D:B9DD jmp short 0xB98B
        if (JumpDispatcher.Jump(unknown_100D_B98B_1BA5B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_B9DF_1BAAF(int loadOffset)
    {
    label_100D_B9DF_1BAAF_36785:
        CheckExternalEvents(cs1, 0xB9DF);
        // 100D:B9DF ret near
        return NearRet((ushort)0x0000);
    }
}
