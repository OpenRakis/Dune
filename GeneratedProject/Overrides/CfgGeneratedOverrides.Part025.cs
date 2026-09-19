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
    public virtual Action unknown_3358_017B_336FB(int loadOffset)
    {
    label_3358_017B_336FB_3360:
        CheckExternalEvents(cs2, 0x017B);
        // 3358:017B jmp near 0x0A68
    label_3358_0A68_33FE8_3362:
        CheckExternalEvents(cs2, 0x0A68);
        // 3358:0A68 push CX
        Stack.Push16(CX);
        // 3358:0A69 push SI
        Stack.Push16(SI);
        // 3358:0A6A push DI
        Stack.Push16(DI);
        // 3358:0A6B push DS
        Stack.Push16(DS);
        // 3358:0A6C push ES
        Stack.Push16(ES);
        // 3358:0A6D call near 0x0A58
        NearCall(cs2, 0x0A70, unknown_3358_0A58_33FD8);
    label_3358_0A70_33FF0_3379:
        CheckExternalEvents(cs2, 0x0A70);
        // 3358:0A70 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A71 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A72 pop DI
        DI = Stack.Pop16();
        // 3358:0A73 pop SI
        SI = Stack.Pop16();
        // 3358:0A74 pop CX
        CX = Stack.Pop16();
        // 3358:0A75 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_017E_336FE(int loadOffset)
    {
    label_3358_017E_336FE_28591:
        CheckExternalEvents(cs2, 0x017E);
        // 3358:017E jmp near 0x2441
    label_3358_2441_359C1_28593:
        CheckExternalEvents(cs2, 0x2441);
        // 3358:2441 push BX
        Stack.Push16(BX);
        // 3358:2442 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 3358:2444 push DI
        Stack.Push16(DI);
        // 3358:2445 call near 0x0C10
        NearCall(cs2, 0x2448, unknown_3358_0C10_34190);
    label_3358_2448_359C8_28598:
        CheckExternalEvents(cs2, 0x2448);
        // 3358:2448 pop DX
        DX = Stack.Pop16();
        // 3358:2449 xchg CX,DX
        ushort temp_3358_2449_359C9 = CX;
        CX = DX;
        DX = unchecked((ushort)temp_3358_2449_359C9);
        // 3358:244B pop BX
        BX = Stack.Pop16();
        // 3358:244C or BH,BH
        BH = Alu8.Or(BH, BH);
        // 3358:244E jne short 0x2487
        if (!ZeroFlag)
        {
            goto label_3358_2487_35A07_31065;
        }
    label_3358_2450_359D0_28604:
        CheckExternalEvents(cs2, 0x2450);
        // 3358:2450 call near 0x24AD
        NearCall(cs2, 0x2453, unknown_3358_24AD_35A2D);
    label_3358_2453_359D3_28654:
        CheckExternalEvents(cs2, 0x2453);
        // 3358:2453 add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:2457 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:245B dec DX
        DX = Alu16.Dec(DX);
        // 3358:245C jne short 0x2450
        if (!ZeroFlag)
        {
            goto label_3358_2450_359D0_28604;
        }
    label_3358_245E_359DE_28661:
        CheckExternalEvents(cs2, 0x245E);
        // 3358:245E cmp byte ptr CS:[0x01BD],0
        Alu8.Sub(UInt8[CS, (ushort)0x01BD], (byte)0x00);
        // 3358:2464 je short 0x2486
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2464");
        }
    label_3358_2486_35A06_28664:
        CheckExternalEvents(cs2, 0x2486);
        // 3358:2486 ret far
        return FarRet((ushort)0x0000);
    label_3358_2487_35A07_31065:
        CheckExternalEvents(cs2, 0x2487);
        // 3358:2487 call near 0x24E9
        NearCall(cs2, 0x248A, unknown_3358_24E9_35A69);
    label_3358_248A_35A0A_31120:
        CheckExternalEvents(cs2, 0x248A);
        // 3358:248A add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:248E add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2492 push AX
        Stack.Push16(AX);
        // 3358:2493 lea BX,BP+0x0100
        BX = unchecked((ushort)(BP + (short)256));
    label_3358_2497_35A17_31125:
        CheckExternalEvents(cs2, 0x2497);
        // 3358:2497 dec BX
        BX = Alu16.Dec(BX);
        // 3358:2498 mov AL,byte ptr DS:[BX]
        AL = UInt8[DS, BX];
        // 3358:249A cmp AL,0x70
        Alu8.Sub(AL, (byte)0x70);
        // 3358:249C je short 0x24A4
        if (ZeroFlag)
        {
            goto label_3358_24A4_35A24_31129;
        }
    label_3358_249E_35A1E_31133:
        CheckExternalEvents(cs2, 0x249E);
        // 3358:249E rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 3358:24A0 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 3358:24A2 mov byte ptr DS:[BX],AL
        UInt8[DS, BX] = AL;
    label_3358_24A4_35A24_31129:
        CheckExternalEvents(cs2, 0x24A4);
        // 3358:24A4 cmp BX,BP
        Alu16.Sub(BX, BP);
        // 3358:24A6 ja short 0x2497
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_2497_35A17_31125;
        }
    label_3358_24A8_35A28_31137:
        CheckExternalEvents(cs2, 0x24A8);
        // 3358:24A8 pop AX
        AX = Stack.Pop16();
        // 3358:24A9 dec DX
        DX = Alu16.Dec(DX);
        // 3358:24AA jne short 0x2487
        if (!ZeroFlag)
        {
            goto label_3358_2487_35A07_31065;
        }
    label_3358_24AC_35A2C_31143:
        CheckExternalEvents(cs2, 0x24AC);
        // 3358:24AC ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0181_33701(int loadOffset)
    {
    label_3358_0181_33701_29134:
        CheckExternalEvents(cs2, 0x0181);
        // 3358:0181 jmp near 0x3724
    label_3358_3724_36CA4_29136:
        CheckExternalEvents(cs2, 0x3724);
        // 3358:3724 dec SI
        SI = Alu16.Dec(SI);
        // 3358:3725 push DS
        Stack.Push16(DS);
        // 3358:3726 push ES
        Stack.Push16(ES);
        // 3358:3727 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:3728 call near 0x3733
        NearCall(cs2, 0x372B, unknown_3358_3733_36CB3);
    label_3358_372B_36CAB_29142:
        CheckExternalEvents(cs2, 0x372B);
        // 3358:372B pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:372C ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0184_33704(int loadOffset)
    {
    label_3358_0184_33704_28986:
        CheckExternalEvents(cs2, 0x0184);
        // 3358:0184 jmp near 0x0C34
    label_3358_0C34_341B4_28988:
        CheckExternalEvents(cs2, 0x0C34);
        // 3358:0C34 call near 0x0C10
        NearCall(cs2, 0x0C37, unknown_3358_0C10_34190);
    label_3358_0C37_341B7_28990:
        CheckExternalEvents(cs2, 0x0C37);
        // 3358:0C37 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:0C3A ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0187_33707(int loadOffset)
    {
    label_3358_0187_33707_17213:
        CheckExternalEvents(cs2, 0x0187);
        // 3358:0187 jmp near 0x0A76
    label_3358_0A76_33FF6_17215:
        CheckExternalEvents(cs2, 0x0A76);
        // 3358:0A76 push AX
        Stack.Push16(AX);
        // 3358:0A77 push CX
        Stack.Push16(CX);
        // 3358:0A78 push SI
        Stack.Push16(SI);
        // 3358:0A79 push DI
        Stack.Push16(DI);
        // 3358:0A7A push DS
        Stack.Push16(DS);
        // 3358:0A7B push ES
        Stack.Push16(ES);
        // 3358:0A7C push CS
        Stack.Push16(CS);
        // 3358:0A7D push CS
        Stack.Push16(CS);
        // 3358:0A7E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A7F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A80 mov SI,0x05BF
        SI = (ushort)0x05BF;
        // 3358:0A83 mov DI,0x02BF
        DI = (ushort)0x02BF;
        // 3358:0A86 mov CX,0x0180
        CX = (ushort)0x0180;
    label_3358_0A89_34009_17229:
        CheckExternalEvents(cs2, 0x0A89);
        // 3358:0A89 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 3358:0A8B xchg AX,word ptr DS:[SI]
        ushort xchgOffset_3358_0A8B_3400B = SI;
        ushort temp_3358_0A8B_3400B = AX;
        AX = UInt16[DS, xchgOffset_3358_0A8B_3400B];
        UInt16[DS, xchgOffset_3358_0A8B_3400B] = unchecked((ushort)temp_3358_0A8B_3400B);
        // 3358:0A8D stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:0A8E add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:0A91 loop 0x0A89
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0A89_34009_17229;
        }
    label_3358_0A93_34013_17235:
        CheckExternalEvents(cs2, 0x0A93);
        // 3358:0A93 mov AL,1
        AL = (byte)0x01;
        // 3358:0A95 mov DI,0x01BE
        DI = (ushort)0x01BE;
        // 3358:0A98 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:0A9B rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0A9D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A9E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A9F pop DI
        DI = Stack.Pop16();
        // 3358:0AA0 pop SI
        SI = Stack.Pop16();
        // 3358:0AA1 pop CX
        CX = Stack.Pop16();
        // 3358:0AA2 pop AX
        AX = Stack.Pop16();
        // 3358:0AA3 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_09B8_33F38(int loadOffset)
    {
    label_3358_09B8_33F38_1024:
        CheckExternalEvents(cs2, 0x09B8);
        // 3358:09B8 mov AH,AL
        AH = AL;
        // 3358:09BA xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 3358:09BC mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_09BF_33F3F_1028:
        CheckExternalEvents(cs2, 0x09BF);
        // 3358:09BF inc SI
        SI = Alu16.Inc(SI);
        // 3358:09C0 jne short 0x09C3
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:09C0");
        }
    label_3358_09C3_33F43_1030:
        CheckExternalEvents(cs2, 0x09C3);
        // 3358:09C3 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 3358:09C4 and AL,8
        AL = Alu8.And(AL, (byte)0x08);
        // 3358:09C6 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 3358:09C8 jne short 0x09D7
        if (!ZeroFlag)
        {
            goto label_3358_09D7_33F57_1052;
        }
    label_3358_09CA_33F4A_1035:
        CheckExternalEvents(cs2, 0x09CA);
        // 3358:09CA push AX
        Stack.Push16(AX);
        // 3358:09CB mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:09CE sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:09D0 cmp AX,0x0064
        Alu16.Sub(AX, (ushort)0x0064);
        // 3358:09D3 pop AX
        AX = Stack.Pop16();
        // 3358:09D4 jb short 0x09BF
        if (CarryFlag)
        {
            goto label_3358_09BF_33F3F_1028;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:09D4");
        }
    label_3358_09D7_33F57_1052:
        CheckExternalEvents(cs2, 0x09D7);
        // 3358:09D7 stc
        CarryFlag = true;
        // 3358:09D8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0A21_33FA1(int loadOffset)
    {
    label_3358_0A21_33FA1_4161:
        CheckExternalEvents(cs2, 0x0A21);
        // 3358:0A21 push DX
        Stack.Push16(DX);
        // 3358:0A22 mov AX,BX
        AX = BX;
        // 3358:0A24 mov DL,3
        DL = (byte)0x03;
        // 3358:0A26 div DL
        byte divisor_3358_0A26_33FA6 = DL;
        ushort dividend_3358_0A26_33FA6 = AX;
        byte quotient_3358_0A26_33FA6 = Alu8.Div(unchecked((ushort)dividend_3358_0A26_33FA6), unchecked((byte)divisor_3358_0A26_33FA6));
        AL = unchecked((byte)quotient_3358_0A26_33FA6);
        AH = unchecked((byte)(dividend_3358_0A26_33FA6 % unchecked((ushort)divisor_3358_0A26_33FA6)));
        // 3358:0A28 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0A2A mov BX,AX
        BX = AX;
        // 3358:0A2C mov AX,CX
        AX = CX;
        // 3358:0A2E cmp AX,0x0300
        Alu16.Sub(AX, (ushort)0x0300);
        // 3358:0A31 jae short 0x0A3B
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:0A31");
        }
    label_3358_0A33_33FB3_4187:
        CheckExternalEvents(cs2, 0x0A33);
        // 3358:0A33 div DL
        byte divisor_3358_0A33_33FB3 = DL;
        ushort dividend_3358_0A33_33FB3 = AX;
        byte quotient_3358_0A33_33FB3 = Alu8.Div(unchecked((ushort)dividend_3358_0A33_33FB3), unchecked((byte)divisor_3358_0A33_33FB3));
        AL = unchecked((byte)quotient_3358_0A33_33FB3);
        AH = unchecked((byte)(dividend_3358_0A33_33FB3 % unchecked((ushort)divisor_3358_0A33_33FB3)));
        // 3358:0A35 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0A37 mov CX,AX
        CX = AX;
        // 3358:0A39 pop DX
        DX = Stack.Pop16();
        // 3358:0A3A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0A58_33FD8(int loadOffset)
    {
    label_3358_0A58_33FD8_3369:
        CheckExternalEvents(cs2, 0x0A58);
        // 3358:0A58 push CS
        Stack.Push16(CS);
        // 3358:0A59 push CS
        Stack.Push16(CS);
        // 3358:0A5A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A5B pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A5C mov SI,0x05BF
        SI = (ushort)0x05BF;
        // 3358:0A5F mov DI,0x02BF
        DI = (ushort)0x02BF;
        // 3358:0A62 mov CX,0x0180
        CX = (ushort)0x0180;
        // 3358:0A65 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0A67 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0B0C_3408C(int loadOffset)
    {
    label_3358_0B0C_3408C_1076:
        CheckExternalEvents(cs2, 0x0B0C);
        // 3358:0B0C cmp byte ptr CS:[0x01BE],0
        Alu8.Sub(UInt8[CS, (ushort)0x01BE], (byte)0x00);
        // 3358:0B12 je short 0x0B67
        if (ZeroFlag)
        {
            return unknown_3358_0B5F_340DF(0x0B67);
        }
    label_3358_0B14_34094_1079:
        CheckExternalEvents(cs2, 0x0B14);
        // 3358:0B14 mov byte ptr CS:[0x01BE],0
        UInt8[CS, (ushort)0x01BE] = (byte)0x00;
        // 3358:0B1A push AX
        Stack.Push16(AX);
        // 3358:0B1B push BX
        Stack.Push16(BX);
        // 3358:0B1C push CX
        Stack.Push16(CX);
        // 3358:0B1D push DX
        Stack.Push16(DX);
        // 3358:0B1E push SI
        Stack.Push16(SI);
        // 3358:0B1F push DI
        Stack.Push16(DI);
        // 3358:0B20 push BP
        Stack.Push16(BP);
        // 3358:0B21 push ES
        Stack.Push16(ES);
        // 3358:0B22 push CS
        Stack.Push16(CS);
        // 3358:0B23 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0B24 mov DI,0x01BF
        DI = (ushort)0x01BF;
        // 3358:0B27 mov CX,0x0100
        CX = (ushort)0x0100;
    label_3358_0B2A_340AA_1093:
        CheckExternalEvents(cs2, 0x0B2A);
        // 3358:0B2A xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:0B2C repe scas AL,byte ptr ES:[DI]
        bool shouldContinue_3358_0B2C_340AC = true;
        while (CX != (ushort)0x0000 && shouldContinue_3358_0B2C_340AC)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_3358_0B2C_340AC = ZeroFlag == true;
        }
        // 3358:0B2E je short 0x0B55
        if (ZeroFlag)
        {
            goto label_3358_0B55_340D5_1162;
        }
    label_3358_0B30_340B0_1096:
        CheckExternalEvents(cs2, 0x0B30);
        // 3358:0B30 dec DI
        DI = Alu16.Dec(DI);
        // 3358:0B31 inc CX
        CX = Alu16.Inc(CX);
        // 3358:0B32 mov BX,CX
        BX = CX;
        // 3358:0B34 repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_3358_0B34_340B4 = true;
        while (CX != (ushort)0x0000 && shouldContinue_3358_0B34_340B4)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_3358_0B34_340B4 = ZeroFlag == false;
        }
        // 3358:0B36 push CX
        Stack.Push16(CX);
        // 3358:0B37 jne short 0x0B3A
        if (!ZeroFlag)
        {
            goto label_3358_0B3A_340BA_1103;
        }
    label_3358_0B39_340B9_4674:
        CheckExternalEvents(cs2, 0x0B39);
        // 3358:0B39 inc CX
        CX = Alu16.Inc(CX);
    label_3358_0B3A_340BA_1103:
        CheckExternalEvents(cs2, 0x0B3A);
        // 3358:0B3A sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:0B3C neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:0B3E mov DX,0x0100
        DX = (ushort)0x0100;
        // 3358:0B41 sub DX,BX
        DX = Alu16.Sub(DX, BX);
        // 3358:0B43 mov BX,DX
        BX = DX;
        // 3358:0B45 add DX,DX
        DX = Alu16.Add(DX, DX);
        // 3358:0B47 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 3358:0B49 add DX,0x05BF
        DX = Alu16.Add(DX, (ushort)0x05BF);
        // 3358:0B4D call near 0x0B68
        NearCall(cs2, 0x0B50, unknown_3358_0B68_340E8);
    label_3358_0B50_340D0_1158:
        CheckExternalEvents(cs2, 0x0B50);
        // 3358:0B50 pop CX
        CX = Stack.Pop16();
        // 3358:0B51 or CX,CX
        CX = Alu16.Or(CX, CX);
        // 3358:0B53 jne short 0x0B2A
        if (!ZeroFlag)
        {
            goto label_3358_0B2A_340AA_1093;
        }
    label_3358_0B55_340D5_1162:
        CheckExternalEvents(cs2, 0x0B55);
        // 3358:0B55 mov DI,0x01BF
        DI = (ushort)0x01BF;
        // 3358:0B58 mov CX,0x0080
        CX = (ushort)0x0080;
        // 3358:0B5B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:0B5D rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        return unknown_3358_0B5F_340DF(0x0000);
    }

    public virtual Action unknown_3358_0B68_340E8(int loadOffset)
    {
    label_3358_0B68_340E8_1113:
        CheckExternalEvents(cs2, 0x0B68);
        // 3358:0B68 push SI
        Stack.Push16(SI);
        // 3358:0B69 push DS
        Stack.Push16(DS);
        // 3358:0B6A push ES
        Stack.Push16(ES);
        // 3358:0B6B pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0B6C mov SI,DX
        SI = DX;
        // 3358:0B6E pushf
        Stack.Push16(FlagRegister16);
        // 3358:0B6F cmp byte ptr DS:[0x01A1],0
        Alu8.Sub(UInt8[DS, (ushort)0x01A1], (byte)0x00);
        // 3358:0B74 je short 0x0B83
        if (ZeroFlag)
        {
            goto label_3358_0B83_34103_1128;
        }
    label_3358_0B76_340F6_1122:
        CheckExternalEvents(cs2, 0x0B76);
        // 3358:0B76 mov DX,word ptr DS:[0x019F]
        DX = UInt16[DS, (ushort)0x019F];
    label_3358_0B7A_340FA_1124:
        CheckExternalEvents(cs2, 0x0B7A);
        // 3358:0B7A in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 3358:0B7B and AL,8
        AL = Alu8.And(AL, (byte)0x08);
        // 3358:0B7D cmp AL,byte ptr DS:[0x01A2]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x01A2]);
        // 3358:0B81 jne short 0x0B7A
        if (!ZeroFlag)
        {
            goto label_3358_0B7A_340FA_1124;
        }
    label_3358_0B83_34103_1128:
        CheckExternalEvents(cs2, 0x0B83);
        // 3358:0B83 cli
        InterruptFlag = false;
        // 3358:0B84 mov DX,0x03C8
        DX = (ushort)0x03C8;
        // 3358:0B87 mov AL,BL
        AL = BL;
        // 3358:0B89 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 3358:0B8A jmp short 0x0B8C
    label_3358_0B8C_3410C_1134:
        CheckExternalEvents(cs2, 0x0B8C);
        // 3358:0B8C jmp short 0x0B8E
    label_3358_0B8E_3410E_1136:
        CheckExternalEvents(cs2, 0x0B8E);
        // 3358:0B8E jmp short 0x0B90
    label_3358_0B90_34110_1138:
        CheckExternalEvents(cs2, 0x0B90);
        // 3358:0B90 jmp short 0x0B92
    label_3358_0B92_34112_1140:
        CheckExternalEvents(cs2, 0x0B92);
        // 3358:0B92 inc DX
        DX = Alu16.Inc(DX);
        // 3358:0B93 cmp byte ptr CS:[0x01BD],0
        Alu8.Sub(UInt8[CS, (ushort)0x01BD], (byte)0x00);
        // 3358:0B99 jne short 0x0BA9
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:0B99");
        }
    label_3358_0B9B_3411B_1144:
        CheckExternalEvents(cs2, 0x0B9B);
        // 3358:0B9B mov AX,CX
        AX = CX;
        // 3358:0B9D add CX,CX
        CX = Alu16.Add(CX, CX);
        // 3358:0B9F add CX,AX
        CX = Alu16.Add(CX, AX);
    label_3358_0BA1_34121_1148:
        CheckExternalEvents(cs2, 0x0BA1);
        // 3358:0BA1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0BA2 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 3358:0BA3 loop 0x0BA1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0BA1_34121_1148;
        }
    label_3358_0BA5_34125_1152:
        CheckExternalEvents(cs2, 0x0BA5);
        // 3358:0BA5 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_0BA6_34126_1154:
        CheckExternalEvents(cs2, 0x0BA6);
        // 3358:0BA6 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0BA7 pop SI
        SI = Stack.Pop16();
        // 3358:0BA8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0BDC_3415C(int loadOffset)
    {
    label_3358_0BDC_3415C_32750:
        CheckExternalEvents(cs2, 0x0BDC);
        // 3358:0BDC push SI
        Stack.Push16(SI);
        // 3358:0BDD push DS
        Stack.Push16(DS);
        // 3358:0BDE push ES
        Stack.Push16(ES);
        // 3358:0BDF push CS
        Stack.Push16(CS);
        // 3358:0BE0 push CS
        Stack.Push16(CS);
        // 3358:0BE1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0BE2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0BE3 mov SI,0x073F
        SI = (ushort)0x073F;
        // 3358:0BE6 mov DX,SI
        DX = SI;
        // 3358:0BE8 mov DI,SI
        DI = SI;
        // 3358:0BEA lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:0BEB mov BL,byte ptr DS:[SI]
        BL = UInt8[DS, SI];
        // 3358:0BED inc SI
        SI = Alu16.Inc(SI);
        // 3358:0BEE mov CX,0x005E
        CX = (ushort)0x005E;
        // 3358:0BF1 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0BF3 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0BF4 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:0BF5 mov byte ptr DS:[DI],BL
        UInt8[DS, DI] = BL;
        // 3358:0BF7 mov BX,0x0080
        BX = (ushort)0x0080;
        // 3358:0BFA mov CX,0x0040
        CX = (ushort)0x0040;
        // 3358:0BFD call near 0x0B68
        NearCall(cs2, 0x0C00, unknown_3358_0B68_340E8);
    label_3358_0C00_34180_32772:
        CheckExternalEvents(cs2, 0x0C00);
        // 3358:0C00 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0C01 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0C02 pop SI
        SI = Stack.Pop16();
        // 3358:0C03 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0C10_34190(int loadOffset)
    {
    label_3358_0C10_34190_5323:
        CheckExternalEvents(cs2, 0x0C10);
        // 3358:0C10 cmp BX,0x00C8
        Alu16.Sub(BX, (ushort)0x00C8);
        // 3358:0C14 jb short 0x0C19
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:0C14");
        }
    label_3358_0C19_34199_5326:
        CheckExternalEvents(cs2, 0x0C19);
        // 3358:0C19 xchg BH,BL
        byte temp_3358_0C19_34199 = BH;
        BH = BL;
        BL = unchecked((byte)temp_3358_0C19_34199);
        // 3358:0C1B mov DI,BX
        DI = BX;
        // 3358:0C1D shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:0C1F shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:0C21 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:0C23 xchg BH,BL
        byte temp_3358_0C23_341A3 = BH;
        BH = BL;
        BL = unchecked((byte)temp_3358_0C23_341A3);
        // 3358:0C25 add DI,DX
        DI = Alu16.Add(DI, DX);
        // 3358:0C27 add DI,word ptr CS:[0x01A3]
        DI = Alu16.Add(DI, UInt16[CS, (ushort)0x01A3]);
        // 3358:0C2C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_1ADC_3505C(int loadOffset)
    {
        goto label_3358_1ADC_3505C_7515;

    label_3358_1A3A_34FBA_7620:
        CheckExternalEvents(cs2, 0x1A3A);
        // 3358:1A3A mov BX,word ptr CS:[0x0196]
        BX = UInt16[CS, (ushort)0x0196];
        // 3358:1A3F mov CX,DX
        CX = DX;
        // 3358:1A41 mov AX,word ptr CS:[0x0194]
        AX = UInt16[CS, (ushort)0x0194];
        // 3358:1A45 mov DX,AX
        DX = AX;
        // 3358:1A47 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:1A49 cmp AX,DX
        Alu16.Sub(AX, DX);
        // 3358:1A4B jg short 0x1A51
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_1A51_34FD1_7628;
        }
    label_3358_1A4D_34FCD_30162:
        CheckExternalEvents(cs2, 0x1A4D);
        // 3358:1A4D mov DX,AX
        DX = AX;
        // 3358:1A4F neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_3358_1A51_34FD1_7628:
        CheckExternalEvents(cs2, 0x1A51);
        // 3358:1A51 mov DI,word ptr CS:[0x0198]
        DI = UInt16[CS, (ushort)0x0198];
        // 3358:1A56 cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 3358:1A59 jl short 0x1A83
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1A83_35003_7656;
        }
    label_3358_1A5B_34FDB_7632:
        CheckExternalEvents(cs2, 0x1A5B);
        // 3358:1A5B cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 3358:1A5E jge short 0x1A83
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1A83_35003_7656;
        }
    label_3358_1A60_34FE0_7635:
        CheckExternalEvents(cs2, 0x1A60);
        // 3358:1A60 call near 0x0C10
        NearCall(cs2, 0x1A63, unknown_3358_0C10_34190);
    label_3358_1A63_34FE3_7637:
        CheckExternalEvents(cs2, 0x1A63);
        // 3358:1A63 inc CX
        CX = Alu16.Inc(CX);
        // 3358:1A64 mov AL,byte ptr CS:[0x019C]
        AL = UInt8[CS, (ushort)0x019C];
        // 3358:1A68 mov SI,word ptr CS:[0x0198]
        SI = UInt16[CS, (ushort)0x0198];
    label_3358_1A6D_34FED_7641:
        CheckExternalEvents(cs2, 0x1A6D);
        // 3358:1A6D rol word ptr CS:[0x019A],1
        UInt16[CS, (ushort)0x019A] = Alu16.Rol(UInt16[CS, (ushort)0x019A], unchecked((byte)1));
        // 3358:1A72 jae short 0x1A7F
        if (!CarryFlag)
        {
            goto label_3358_1A7F_34FFF_7652;
        }
    label_3358_1A74_34FF4_7643:
        CheckExternalEvents(cs2, 0x1A74);
        // 3358:1A74 cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 3358:1A76 jl short 0x1A7F
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1A7F_34FFF_7652;
        }
    label_3358_1A78_34FF8_7646:
        CheckExternalEvents(cs2, 0x1A78);
        // 3358:1A78 cmp DX,word ptr DS:[SI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 3358:1A7B jge short 0x1A7F
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1A7F_34FFF_7652;
        }
    label_3358_1A7D_34FFD_7649:
        CheckExternalEvents(cs2, 0x1A7D);
        // 3358:1A7D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1A7E dec DI
        DI = Alu16.Dec(DI);
    label_3358_1A7F_34FFF_7652:
        CheckExternalEvents(cs2, 0x1A7F);
        // 3358:1A7F inc DI
        DI = Alu16.Inc(DI);
        // 3358:1A80 inc DX
        DX = Alu16.Inc(DX);
        // 3358:1A81 loop 0x1A6D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1A6D_34FED_7641;
        }
    label_3358_1A83_35003_7656:
        CheckExternalEvents(cs2, 0x1A83);
        // 3358:1A83 pop SI
        SI = Stack.Pop16();
        // 3358:1A84 pop DI
        DI = Stack.Pop16();
        // 3358:1A85 ret near
        return NearRet((ushort)0x0000);
    label_3358_1A86_35006_16783:
        CheckExternalEvents(cs2, 0x1A86);
        // 3358:1A86 mov CX,BX
        CX = BX;
        // 3358:1A88 mov BX,word ptr CS:[0x0196]
        BX = UInt16[CS, (ushort)0x0196];
        // 3358:1A8D mov DX,word ptr CS:[0x0194]
        DX = UInt16[CS, (ushort)0x0194];
        // 3358:1A92 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:1A94 jns short 0x1A98
        if (!SignFlag)
        {
            goto label_3358_1A98_35018_16789;
        }
    label_3358_1A96_35016_40520:
        CheckExternalEvents(cs2, 0x1A96);
        // 3358:1A96 sub BX,CX
        BX = Alu16.Sub(BX, CX);
    label_3358_1A98_35018_16789:
        CheckExternalEvents(cs2, 0x1A98);
        // 3358:1A98 cmp BX,0x00C8
        Alu16.Sub(BX, (ushort)0x00C8);
        // 3358:1A9C jb short 0x1AA4
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1A9C");
        }
    label_3358_1AA4_35024_16792:
        CheckExternalEvents(cs2, 0x1AA4);
        // 3358:1AA4 mov DI,word ptr CS:[0x0198]
        DI = UInt16[CS, (ushort)0x0198];
        // 3358:1AA9 cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 3358:1AAB jl short 0x1AD9
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1AD9_35059_16820;
        }
    label_3358_1AAD_3502D_16796:
        CheckExternalEvents(cs2, 0x1AAD);
        // 3358:1AAD cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 3358:1AB0 jge short 0x1AD9
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1AD9_35059_16820;
        }
    label_3358_1AB2_35032_16799:
        CheckExternalEvents(cs2, 0x1AB2);
        // 3358:1AB2 call near 0x0C10
        NearCall(cs2, 0x1AB5, unknown_3358_0C10_34190);
    label_3358_1AB5_35035_16801:
        CheckExternalEvents(cs2, 0x1AB5);
        // 3358:1AB5 inc CX
        CX = Alu16.Inc(CX);
        // 3358:1AB6 mov AL,byte ptr CS:[0x019C]
        AL = UInt8[CS, (ushort)0x019C];
        // 3358:1ABA mov SI,word ptr CS:[0x0198]
        SI = UInt16[CS, (ushort)0x0198];
    label_3358_1ABF_3503F_16805:
        CheckExternalEvents(cs2, 0x1ABF);
        // 3358:1ABF rol word ptr CS:[0x019A],1
        UInt16[CS, (ushort)0x019A] = Alu16.Rol(UInt16[CS, (ushort)0x019A], unchecked((byte)1));
        // 3358:1AC4 jae short 0x1AD2
        if (!CarryFlag)
        {
            goto label_3358_1AD2_35052_16816;
        }
    label_3358_1AC6_35046_16807:
        CheckExternalEvents(cs2, 0x1AC6);
        // 3358:1AC6 cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 3358:1AC9 jl short 0x1AD2
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1AD2_35052_16816;
        }
    label_3358_1ACB_3504B_16810:
        CheckExternalEvents(cs2, 0x1ACB);
        // 3358:1ACB cmp BX,word ptr DS:[SI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 3358:1ACE jge short 0x1AD2
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1AD2_35052_16816;
        }
    label_3358_1AD0_35050_16813:
        CheckExternalEvents(cs2, 0x1AD0);
        // 3358:1AD0 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1AD1 dec DI
        DI = Alu16.Dec(DI);
    label_3358_1AD2_35052_16816:
        CheckExternalEvents(cs2, 0x1AD2);
        // 3358:1AD2 inc BX
        BX = Alu16.Inc(BX);
        // 3358:1AD3 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:1AD7 loop 0x1ABF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1ABF_3503F_16805;
        }
    label_3358_1AD9_35059_16820:
        CheckExternalEvents(cs2, 0x1AD9);
        // 3358:1AD9 pop SI
        SI = Stack.Pop16();
        // 3358:1ADA pop DI
        DI = Stack.Pop16();
        // 3358:1ADB ret near
        return NearRet((ushort)0x0000);
    label_3358_1ADC_3505C_7515:
        CheckExternalEvents(cs2, 0x1ADC);
        // 3358:1ADC push DI
        Stack.Push16(DI);
        // 3358:1ADD push SI
        Stack.Push16(SI);
        // 3358:1ADE or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:1AE0 jne short 0x1AE5
        if (!ZeroFlag)
        {
            goto label_3358_1AE5_35065_7520;
        }
    label_3358_1AE2_35062_7618:
        CheckExternalEvents(cs2, 0x1AE2);
        // 3358:1AE2 jmp near 0x1A3A
        goto label_3358_1A3A_34FBA_7620;
    label_3358_1AE5_35065_7520:
        CheckExternalEvents(cs2, 0x1AE5);
        // 3358:1AE5 mov AX,1
        AX = (ushort)0x0001;
        // 3358:1AE8 jns short 0x1AEE
        if (!SignFlag)
        {
            goto label_3358_1AEE_3506E_7526;
        }
    label_3358_1AEA_3506A_7523:
        CheckExternalEvents(cs2, 0x1AEA);
        // 3358:1AEA neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 3358:1AEC neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_3358_1AEE_3506E_7526:
        CheckExternalEvents(cs2, 0x1AEE);
        // 3358:1AEE or DX,DX
        DX = Alu16.Or(DX, DX);
        // 3358:1AF0 je short 0x1A86
        if (ZeroFlag)
        {
            goto label_3358_1A86_35006_16783;
        }
    label_3358_1AF2_35072_7528:
        CheckExternalEvents(cs2, 0x1AF2);
        // 3358:1AF2 mov CX,1
        CX = (ushort)0x0001;
        // 3358:1AF5 jns short 0x1AFB
        if (!SignFlag)
        {
            goto label_3358_1AFB_3507B_7531;
        }
    label_3358_1AF7_35077_7609:
        CheckExternalEvents(cs2, 0x1AF7);
        // 3358:1AF7 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1AF9 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_3358_1AFB_3507B_7531:
        CheckExternalEvents(cs2, 0x1AFB);
        // 3358:1AFB push AX
        Stack.Push16(AX);
        // 3358:1AFC push CX
        Stack.Push16(CX);
        // 3358:1AFD push AX
        Stack.Push16(AX);
        // 3358:1AFE push CX
        Stack.Push16(CX);
        // 3358:1AFF mov BP,SP
        BP = SP;
        // 3358:1B01 mov SI,BX
        SI = BX;
        // 3358:1B03 mov DI,DX
        DI = DX;
        // 3358:1B05 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:1B07 cmp DX,BX
        Alu16.Sub(DX, BX);
        // 3358:1B09 jbe short 0x1B10
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1B10_35090_29335;
        }
    label_3358_1B0B_3508B_7542:
        CheckExternalEvents(cs2, 0x1B0B);
        // 3358:1B0B mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 3358:1B0E jmp short 0x1B19
        goto label_3358_1B19_35099_7545;
    label_3358_1B10_35090_29335:
        CheckExternalEvents(cs2, 0x1B10);
        // 3358:1B10 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:1B12 je short 0x1B76
        if (ZeroFlag)
        {
            goto label_3358_1B76_350F6_7591;
        }
    label_3358_1B14_35094_29338:
        CheckExternalEvents(cs2, 0x1B14);
        // 3358:1B14 xchg DI,SI
        ushort temp_3358_1B14_35094 = DI;
        DI = SI;
        SI = unchecked((ushort)temp_3358_1B14_35094);
        // 3358:1B16 mov word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = AX;
    label_3358_1B19_35099_7545:
        CheckExternalEvents(cs2, 0x1B19);
        // 3358:1B19 mov AX,DI
        AX = DI;
        // 3358:1B1B mov CX,DI
        CX = DI;
        // 3358:1B1D shr AX,1
        AX = Alu16.Shr(AX, 1);
    label_3358_1B1F_3509F_7549:
        CheckExternalEvents(cs2, 0x1B1F);
        // 3358:1B1F add AX,SI
        AX = Alu16.Add(AX, SI);
        // 3358:1B21 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 3358:1B23 jb short 0x1B2F
        if (CarryFlag)
        {
            goto label_3358_1B2F_350AF_7552;
        }
    label_3358_1B25_350A5_7585:
        CheckExternalEvents(cs2, 0x1B25);
        // 3358:1B25 sub AX,DI
        AX = Alu16.Sub(AX, DI);
        // 3358:1B27 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1B2A mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:1B2D jmp short 0x1B35
        goto label_3358_1B35_350B5_7555;
    label_3358_1B2F_350AF_7552:
        CheckExternalEvents(cs2, 0x1B2F);
        // 3358:1B2F mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1B32 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
    label_3358_1B35_350B5_7555:
        CheckExternalEvents(cs2, 0x1B35);
        // 3358:1B35 add DX,word ptr CS:[0x0194]
        DX = Alu16.Add(DX, UInt16[CS, (ushort)0x0194]);
        // 3358:1B3A add BX,word ptr CS:[0x0196]
        BX = Alu16.Add(BX, UInt16[CS, (ushort)0x0196]);
        // 3358:1B3F mov word ptr CS:[0x0194],DX
        UInt16[CS, (ushort)0x0194] = DX;
        // 3358:1B44 mov word ptr CS:[0x0196],BX
        UInt16[CS, (ushort)0x0196] = BX;
        // 3358:1B49 push AX
        Stack.Push16(AX);
        // 3358:1B4A push DI
        Stack.Push16(DI);
        // 3358:1B4B rol word ptr CS:[0x019A],1
        UInt16[CS, (ushort)0x019A] = Alu16.Rol(UInt16[CS, (ushort)0x019A], unchecked((byte)1));
        // 3358:1B50 jae short 0x1B72
        if (!CarryFlag)
        {
            goto label_3358_1B72_350F2_7581;
        }
    label_3358_1B52_350D2_7563:
        CheckExternalEvents(cs2, 0x1B52);
        // 3358:1B52 mov DI,word ptr CS:[0x0198]
        DI = UInt16[CS, (ushort)0x0198];
        // 3358:1B57 cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 3358:1B59 jl short 0x1B72
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1B72_350F2_7581;
        }
    label_3358_1B5B_350DB_7567:
        CheckExternalEvents(cs2, 0x1B5B);
        // 3358:1B5B cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 3358:1B5E jl short 0x1B72
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_1B72_350F2_7581;
        }
    label_3358_1B60_350E0_7570:
        CheckExternalEvents(cs2, 0x1B60);
        // 3358:1B60 cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 3358:1B63 jge short 0x1B72
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1B72_350F2_7581;
        }
    label_3358_1B65_350E5_7573:
        CheckExternalEvents(cs2, 0x1B65);
        // 3358:1B65 cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 3358:1B68 jge short 0x1B72
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_1B72_350F2_7581;
        }
    label_3358_1B6A_350EA_7576:
        CheckExternalEvents(cs2, 0x1B6A);
        // 3358:1B6A call near 0x0C10
        NearCall(cs2, 0x1B6D, unknown_3358_0C10_34190);
    label_3358_1B6D_350ED_7578:
        CheckExternalEvents(cs2, 0x1B6D);
        // 3358:1B6D mov AL,byte ptr CS:[0x019C]
        AL = UInt8[CS, (ushort)0x019C];
        // 3358:1B71 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_3358_1B72_350F2_7581:
        CheckExternalEvents(cs2, 0x1B72);
        // 3358:1B72 pop DI
        DI = Stack.Pop16();
        // 3358:1B73 pop AX
        AX = Stack.Pop16();
        // 3358:1B74 loop 0x1B1F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1B1F_3509F_7549;
        }
    label_3358_1B76_350F6_7591:
        CheckExternalEvents(cs2, 0x1B76);
        // 3358:1B76 add SP,8
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:1B79 pop SI
        SI = Stack.Pop16();
        // 3358:1B7A pop DI
        DI = Stack.Pop16();
        // 3358:1B7B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_1B7C_350FC(int loadOffset)
    {
    label_3358_1B7C_350FC_2737:
        CheckExternalEvents(cs2, 0x1B7C);
        // 3358:1B7C push CX
        Stack.Push16(CX);
        // 3358:1B7D push SI
        Stack.Push16(SI);
        // 3358:1B7E push DI
        Stack.Push16(DI);
        // 3358:1B7F xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 3358:1B81 mov DI,SI
        DI = SI;
        // 3358:1B83 mov CX,0x7D00
        CX = (ushort)0x7D00;
        // 3358:1B86 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1B88 pop DI
        DI = Stack.Pop16();
        // 3358:1B89 pop SI
        SI = Stack.Pop16();
        // 3358:1B8A pop CX
        CX = Stack.Pop16();
        // 3358:1B8B ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_1B8E_3510E(int loadOffset)
    {
    label_3358_1B8E_3510E_8095:
        CheckExternalEvents(cs2, 0x1B8E);
        // 3358:1B8E call near 0x0C10
        NearCall(cs2, 0x1B91, unknown_3358_0C10_34190);
    label_3358_1B91_35111_8096:
        CheckExternalEvents(cs2, 0x1B91);
        // 3358:1B91 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:1B93 jb short 0x1BA9
        if (CarryFlag)
        {
            goto label_3358_1BA9_35129_9028;
        }
    label_3358_1B95_35115_8099:
        CheckExternalEvents(cs2, 0x1B95);
        // 3358:1B95 je short 0x1BBD
        if (ZeroFlag)
        {
            goto label_3358_1BBD_3513D_9041;
        }
    label_3358_1B97_35117_8101:
        CheckExternalEvents(cs2, 0x1B97);
        // 3358:1B97 mov DX,DI
        DX = DI;
    label_3358_1B99_35119_8103:
        CheckExternalEvents(cs2, 0x1B99);
        // 3358:1B99 mov SI,DX
        SI = DX;
        // 3358:1B9B mov DI,SI
        DI = SI;
        // 3358:1B9D mov CX,BP
        CX = BP;
        // 3358:1B9F rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1BA1 add DX,0x0140
        DX = Alu16.Add(DX, (ushort)0x0140);
        // 3358:1BA5 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1BA6 jne short 0x1B99
        if (!ZeroFlag)
        {
            goto label_3358_1B99_35119_8103;
        }
    label_3358_1BA8_35128_8111:
        CheckExternalEvents(cs2, 0x1BA8);
        // 3358:1BA8 ret far
        return FarRet((ushort)0x0000);
    label_3358_1BA9_35129_9028:
        CheckExternalEvents(cs2, 0x1BA9);
        // 3358:1BA9 je short 0x1BBE
        if (ZeroFlag)
        {
            goto label_3358_1BBE_3513E_10849;
        }
    label_3358_1BAB_3512B_9030:
        CheckExternalEvents(cs2, 0x1BAB);
        // 3358:1BAB mov DX,DI
        DX = DI;
    label_3358_1BAD_3512D_9032:
        CheckExternalEvents(cs2, 0x1BAD);
        // 3358:1BAD mov SI,DX
        SI = DX;
        // 3358:1BAF mov DI,SI
        DI = SI;
        // 3358:1BB1 mov CX,BP
        CX = BP;
        // 3358:1BB3 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1BB5 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1BB6 add DX,0x0140
        DX = Alu16.Add(DX, (ushort)0x0140);
        // 3358:1BBA dec AX
        AX = Alu16.Dec(AX);
        // 3358:1BBB jne short 0x1BAD
        if (!ZeroFlag)
        {
            goto label_3358_1BAD_3512D_9032;
        }
    label_3358_1BBD_3513D_9041:
        CheckExternalEvents(cs2, 0x1BBD);
        // 3358:1BBD ret far
        return FarRet((ushort)0x0000);
    label_3358_1BBE_3513E_10849:
        CheckExternalEvents(cs2, 0x1BBE);
        // 3358:1BBE mov CX,AX
        CX = AX;
    label_3358_1BC0_35140_10851:
        CheckExternalEvents(cs2, 0x1BC0);
        // 3358:1BC0 mov SI,DI
        SI = DI;
        // 3358:1BC2 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1BC3 add DI,0x013F
        DI = Alu16.Add(DI, (ushort)0x013F);
        // 3358:1BC7 loop 0x1BC0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1BC0_35140_10851;
        }
    label_3358_1BC9_35149_10856:
        CheckExternalEvents(cs2, 0x1BC9);
        // 3358:1BC9 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_1D07_35287(int loadOffset)
    {
    label_3358_1D07_35287_12540:
        CheckExternalEvents(cs2, 0x1D07);
        // 3358:1D07 mov DS,word ptr CS:[0x1CA2]
        DS = UInt16[CS, (ushort)0x1CA2];
        // 3358:1D0C mov DI,word ptr CS:[0x1CA6]
        DI = UInt16[CS, (ushort)0x1CA6];
        // 3358:1D11 mov AL,byte ptr SS:[DI]
        AL = UInt8[SS, DI];
        // 3358:1D14 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1D16 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1D17 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1D19 jns short 0x1D52
        if (!SignFlag)
        {
            goto label_3358_1D52_352D2_12548;
        }
    label_3358_1D1B_3529B_12661:
        CheckExternalEvents(cs2, 0x1D1B);
        // 3358:1D1B mov DI,word ptr CS:[0x1CA8]
        DI = UInt16[CS, (ushort)0x1CA8];
        // 3358:1D20 neg word ptr CS:[0x1CB4]
        UInt16[CS, (ushort)0x1CB4] = Alu16.Sub((ushort)0x0000, UInt16[CS, (ushort)0x1CB4]);
        CarryFlag = UInt16[CS, (ushort)0x1CB4] != (ushort)0x0000;
        // 3358:1D25 js short 0x1D5A
        if (SignFlag)
        {
            return unknown_3358_1D5A_352DA(0x0000);
        }
    label_3358_1D27_352A7_12665:
        CheckExternalEvents(cs2, 0x1D27);
        // 3358:1D27 mov word ptr CS:[0x1EA6],0xFEDB
        UInt16[CS, (ushort)0x1EA6] = (ushort)0xFEDB;
        // 3358:1D2E mov word ptr CS:[0x1F29],0xFE58
        UInt16[CS, (ushort)0x1F29] = (ushort)0xFE58;
        // 3358:1D35 mov AX,0x64A0
        AX = (ushort)0x64A0;
        // 3358:1D38 mov word ptr CS:[0x1CB0],AX
        UInt16[CS, (ushort)0x1CB0] = AX;
        // 3358:1D3C mov word ptr CS:[0x1CB2],AX
        UInt16[CS, (ushort)0x1CB2] = AX;
        // 3358:1D40 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1D41 mov word ptr CS:[0x1CAE],AX
        UInt16[CS, (ushort)0x1CAE] = AX;
        // 3358:1D45 mov AL,byte ptr SS:[DI-1]
        AL = UInt8[SS, (ushort)(DI + (sbyte)-1)];
        // 3358:1D49 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 3358:1D4A sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:1D4C mov AL,byte ptr SS:[DI]
        AL = UInt8[SS, DI];
        // 3358:1D4F xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1D51 inc DI
        DI = Alu16.Inc(DI);
    label_3358_1D52_352D2_12548:
        CheckExternalEvents(cs2, 0x1D52);
        // 3358:1D52 mov SI,word ptr CS:[0x1CAA]
        SI = UInt16[CS, (ushort)0x1CAA];
        // 3358:1D57 jmp near 0x1EA5
        goto label_3358_1EA5_35425_12680;
    label_3358_1D83_35303_12683:
        CheckExternalEvents(cs2, 0x1D83);
        // 3358:1D83 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_3358_1D85_35305_12553:
        CheckExternalEvents(cs2, 0x1D85);
        // 3358:1D85 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 3358:1D87 mov BP,word ptr CS:[0x1CAC]
        BP = UInt16[CS, (ushort)0x1CAC];
        // 3358:1D8C add BP,AX
        BP = Alu16.Add(BP, AX);
        // 3358:1D8E mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1D91 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:1D93 js short 0x1DE3
        if (SignFlag)
        {
            goto label_3358_1DE3_35363_12560;
        }
    label_3358_1D95_35315_12685:
        CheckExternalEvents(cs2, 0x1D95);
        // 3358:1D95 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 3358:1D96 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:1D98 jns short 0x1DC2
        if (!SignFlag)
        {
            goto label_3358_1DC2_35342_12689;
        }
    label_3358_1D9A_3531A_34905:
        CheckExternalEvents(cs2, 0x1D9A);
        // 3358:1D9A neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:1D9C mov BP,AX
        BP = AX;
        // 3358:1D9E mov BL,byte ptr SS:[BP+SI]
        BL = UInt8[SS, (ushort)(BP + SI)];
        // 3358:1DA0 mov AL,byte ptr SS:[BP+SI+0x64]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)100)];
        // 3358:1DA3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1DA5 mov BH,AH
        BH = AH;
        // 3358:1DA7 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DA9 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DAB mov BP,word ptr CS:[0x1CA4]
        BP = UInt16[CS, (ushort)0x1CA4];
        // 3358:1DB0 add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1DB2 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1DB5 mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1DB8 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1DBB neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:1DBD add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:1DBF jmp short 0x1E32
        goto label_3358_1E32_353B2_12578;
    label_3358_1DC2_35342_12689:
        CheckExternalEvents(cs2, 0x1DC2);
        // 3358:1DC2 mov BP,AX
        BP = AX;
        // 3358:1DC4 mov BL,byte ptr SS:[BP+SI]
        BL = UInt8[SS, (ushort)(BP + SI)];
        // 3358:1DC6 mov AL,byte ptr SS:[BP+SI+0x64]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)100)];
        // 3358:1DC9 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1DCB mov BH,AH
        BH = AH;
        // 3358:1DCD shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DCF shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DD1 mov BP,word ptr CS:[0x1CA4]
        BP = UInt16[CS, (ushort)0x1CA4];
        // 3358:1DD6 add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1DD8 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1DDB mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1DDE mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1DE1 jmp short 0x1E32
        goto label_3358_1E32_353B2_12578;
    label_3358_1DE3_35363_12560:
        CheckExternalEvents(cs2, 0x1DE3);
        // 3358:1DE3 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 3358:1DE4 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:1DE6 jns short 0x1E11
        if (!SignFlag)
        {
            goto label_3358_1E11_35391_12564;
        }
    label_3358_1DE8_35368_12642:
        CheckExternalEvents(cs2, 0x1DE8);
        // 3358:1DE8 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:1DEA mov BP,AX
        BP = AX;
        // 3358:1DEC mov BL,byte ptr SS:[BP+SI]
        BL = UInt8[SS, (ushort)(BP + SI)];
        // 3358:1DEE mov AL,byte ptr SS:[BP+SI+0x64]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)100)];
        // 3358:1DF1 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1DF3 mov BH,AH
        BH = AH;
        // 3358:1DF5 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DF7 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1DF9 mov BP,word ptr CS:[0x1CA4]
        BP = UInt16[CS, (ushort)0x1CA4];
        // 3358:1DFE add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1E00 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1E03 mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1E06 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1E09 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:1E0B add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:1E0D neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 3358:1E0F jmp short 0x1E32
        goto label_3358_1E32_353B2_12578;
    label_3358_1E11_35391_12564:
        CheckExternalEvents(cs2, 0x1E11);
        // 3358:1E11 mov BP,AX
        BP = AX;
        // 3358:1E13 mov BL,byte ptr SS:[BP+SI]
        BL = UInt8[SS, (ushort)(BP + SI)];
        // 3358:1E15 mov AL,byte ptr SS:[BP+SI+0x64]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)100)];
        // 3358:1E18 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1E1A mov BH,AH
        BH = AH;
        // 3358:1E1C shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1E1E shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:1E20 mov BP,word ptr CS:[0x1CA4]
        BP = UInt16[CS, (ushort)0x1CA4];
        // 3358:1E25 add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1E27 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1E2A mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1E2D mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1E30 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_3358_1E32_353B2_12578:
        CheckExternalEvents(cs2, 0x1E32);
        // 3358:1E32 add CX,CX
        CX = Alu16.Add(CX, CX);
        // 3358:1E34 mov BP,DX
        BP = DX;
        // 3358:1E36 sub BP,AX
        BP = Alu16.Sub(BP, AX);
        // 3358:1E38 jns short 0x1E3C
        if (!SignFlag)
        {
            goto label_3358_1E3C_353BC_12582;
        }
    label_3358_1E3A_353BA_12626:
        CheckExternalEvents(cs2, 0x1E3A);
        // 3358:1E3A add BP,CX
        BP = Alu16.Add(BP, CX);
    label_3358_1E3C_353BC_12582:
        CheckExternalEvents(cs2, 0x1E3C);
        // 3358:1E3C add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1E3E add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:1E40 push SI
        Stack.Push16(SI);
        // 3358:1E41 push DI
        Stack.Push16(DI);
        // 3358:1E42 mov SI,word ptr CS:[0x1CA0]
        SI = UInt16[CS, (ushort)0x1CA0];
        // 3358:1E47 mov AL,byte ptr DS:[BP+SI]
        AL = UInt8[DS, (ushort)(BP + SI)];
        // 3358:1E4A selector
        if (SelectorSignatureMatches(cs2, 0x1E4A, [(byte)0x90]))
        {
            goto label_3358_1E4A_353CA_12589;
        }
        if (SelectorSignatureMatches(cs2, 0x1E4A, [(byte)0xEB, (byte)0x7D]))
        {
            goto label_3358_1E4A_353CA_19264;
        }
        throw FailAsUntested("No selector signature matched at 3358:1E4A");
    label_3358_1E4A_353CA_12589:
        CheckExternalEvents(cs2, 0x1E4A);
        // 3358:1E4A nop
        // 3358:1E4B nop
        // 3358:1E4C mov AH,AL
        AH = AL;
        // 3358:1E4E and AX,0x300F
        AX = Alu16.And(AX, (ushort)0x300F);
        // 3358:1E51 cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 3358:1E54 jne short 0x1E5C
        if (!ZeroFlag)
        {
            goto label_3358_1E5C_353DC_12595;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1E54");
        }
    label_3358_1E4A_353CA_19264:
        CheckExternalEvents(cs2, 0x1E4A);
        // 3358:1E4A jmp short 0x1EC9
        goto label_3358_1EC9_35449_19268;
    label_3358_1E5C_353DC_12595:
        CheckExternalEvents(cs2, 0x1E5C);
        // 3358:1E5C add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 3358:1E5E mov DI,word ptr CS:[0x1CAE]
        DI = UInt16[CS, (ushort)0x1CAE];
        // 3358:1E63 std
        DirectionFlag = true;
        // 3358:1E64 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1E65 cld
        DirectionFlag = false;
        // 3358:1E66 mov word ptr CS:[0x1CAE],DI
        UInt16[CS, (ushort)0x1CAE] = DI;
        // 3358:1E6B mov BP,DX
        BP = DX;
        // 3358:1E6D sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1E6F jns short 0x1E73
        if (!SignFlag)
        {
            goto label_3358_1E73_353F3_12607;
        }
    label_3358_1E71_353F1_12605:
        CheckExternalEvents(cs2, 0x1E71);
        // 3358:1E71 add BP,CX
        BP = Alu16.Add(BP, CX);
    label_3358_1E73_353F3_12607:
        CheckExternalEvents(cs2, 0x1E73);
        // 3358:1E73 add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1E75 mov AL,byte ptr DS:[BP+SI]
        AL = UInt8[DS, (ushort)(BP + SI)];
        // 3358:1E78 mov AH,AL
        AH = AL;
        // 3358:1E7A and AX,0x300F
        AX = Alu16.And(AX, (ushort)0x300F);
        // 3358:1E7D cmp AH,0x10
        Alu8.Sub(AH, (byte)0x10);
        // 3358:1E80 jne short 0x1E88
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1E80");
        }
    label_3358_1E88_35408_12613:
        CheckExternalEvents(cs2, 0x1E88);
        // 3358:1E88 add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 3358:1E8A mov DI,word ptr CS:[0x1CB0]
        DI = UInt16[CS, (ushort)0x1CB0];
        // 3358:1E8F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1E90 mov word ptr CS:[0x1CB0],DI
        UInt16[CS, (ushort)0x1CB0] = DI;
        // 3358:1E95 pop DI
        DI = Stack.Pop16();
        // 3358:1E96 pop SI
        SI = Stack.Pop16();
        // 3358:1E97 add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:1E9B mov AL,byte ptr SS:[DI]
        AL = UInt8[SS, DI];
        // 3358:1E9E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1EA0 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1EA1 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1EA3 js short 0x1EA8
        if (SignFlag)
        {
            goto label_3358_1EA8_35428_12628;
        }
        else
        {
            goto label_3358_1EA5_35425_12680;
        }
    label_3358_1EA5_35425_12551:
        CheckExternalEvents(cs2, 0x1EA5);
        // 3358:1EA5 jmp near 0x1D85
        goto label_3358_1D85_35305_12553;
    label_3358_1EA5_35425_12680:
        CheckExternalEvents(cs2, 0x1EA5);
        // 3358:1EA5 selector
        if (SelectorSignatureMatches(cs2, 0x1EA5, [(byte)0xE9, (byte)0xDB, (byte)0xFE]))
        {
            goto label_3358_1EA5_35425_12679;
        }
        if (SelectorSignatureMatches(cs2, 0x1EA5, [(byte)0xE9, (byte)0xDD, (byte)0xFE]))
        {
            goto label_3358_1EA5_35425_12551;
        }
        throw FailAsUntested("No selector signature matched at 3358:1EA5");
    label_3358_1EA5_35425_12679:
        CheckExternalEvents(cs2, 0x1EA5);
        // 3358:1EA5 jmp near 0x1D83
        goto label_3358_1D83_35303_12683;
    label_3358_1EA8_35428_12628:
        CheckExternalEvents(cs2, 0x1EA8);
        // 3358:1EA8 mov word ptr CS:[0x1CA6],DI
        UInt16[CS, (ushort)0x1CA6] = DI;
        // 3358:1EAD mov AX,word ptr CS:[0x1CB4]
        AX = UInt16[CS, (ushort)0x1CB4];
        // 3358:1EB1 add AX,word ptr CS:[0x1CB2]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x1CB2]);
        // 3358:1EB6 mov word ptr CS:[0x1CB2],AX
        UInt16[CS, (ushort)0x1CB2] = AX;
        // 3358:1EBA mov word ptr CS:[0x1CB0],AX
        UInt16[CS, (ushort)0x1CB0] = AX;
        // 3358:1EBE dec AX
        AX = Alu16.Dec(AX);
        // 3358:1EBF mov word ptr CS:[0x1CAE],AX
        UInt16[CS, (ushort)0x1CAE] = AX;
        // 3358:1EC3 clc
        CarryFlag = false;
        // 3358:1EC4 mov AX,SS
        AX = SS;
        // 3358:1EC6 mov DS,AX
        DS = AX;
        // 3358:1EC8 ret far
        return FarRet((ushort)0x0000);
    label_3358_1EC9_35449_19268:
        CheckExternalEvents(cs2, 0x1EC9);
        // 3358:1EC9 mov AH,AL
        AH = AL;
        // 3358:1ECB and AX,0x300F
        AX = Alu16.And(AX, (ushort)0x300F);
        // 3358:1ECE or AL,0x10
        AL = Alu8.Or(AL, (byte)0x10);
        // 3358:1ED0 sub AH,0x10
        AH = Alu8.Sub(AH, (byte)0x10);
        // 3358:1ED3 jb short 0x1EDE
        if (CarryFlag)
        {
            goto label_3358_1EDE_3545E_19279;
        }
    label_3358_1ED5_35455_19274:
        CheckExternalEvents(cs2, 0x1ED5);
        // 3358:1ED5 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1ED7 and AH,0x10
        AH = Alu8.And(AH, (byte)0x10);
        // 3358:1EDA add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 3358:1EDC add AL,AH
        AL = Alu8.Add(AL, AH);
    label_3358_1EDE_3545E_19279:
        CheckExternalEvents(cs2, 0x1EDE);
        // 3358:1EDE mov DI,word ptr CS:[0x1CAE]
        DI = UInt16[CS, (ushort)0x1CAE];
        // 3358:1EE3 std
        DirectionFlag = true;
        // 3358:1EE4 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1EE5 cld
        DirectionFlag = false;
        // 3358:1EE6 mov word ptr CS:[0x1CAE],DI
        UInt16[CS, (ushort)0x1CAE] = DI;
        // 3358:1EEB mov BP,DX
        BP = DX;
        // 3358:1EED sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1EEF jns short 0x1EF3
        if (!SignFlag)
        {
            goto label_3358_1EF3_35473_19289;
        }
    label_3358_1EF1_35471_19287:
        CheckExternalEvents(cs2, 0x1EF1);
        // 3358:1EF1 add BP,CX
        BP = Alu16.Add(BP, CX);
    label_3358_1EF3_35473_19289:
        CheckExternalEvents(cs2, 0x1EF3);
        // 3358:1EF3 add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:1EF5 mov AL,byte ptr DS:[BP+SI]
        AL = UInt8[DS, (ushort)(BP + SI)];
        // 3358:1EF8 mov AH,AL
        AH = AL;
        // 3358:1EFA and AX,0x300F
        AX = Alu16.And(AX, (ushort)0x300F);
        // 3358:1EFD or AL,0x10
        AL = Alu8.Or(AL, (byte)0x10);
        // 3358:1EFF sub AH,0x10
        AH = Alu8.Sub(AH, (byte)0x10);
        // 3358:1F02 jb short 0x1F0D
        if (CarryFlag)
        {
            goto label_3358_1F0D_3548D_19301;
        }
    label_3358_1F04_35484_19296:
        CheckExternalEvents(cs2, 0x1F04);
        // 3358:1F04 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1F06 and AH,0x10
        AH = Alu8.And(AH, (byte)0x10);
        // 3358:1F09 add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 3358:1F0B add AL,AH
        AL = Alu8.Add(AL, AH);
    label_3358_1F0D_3548D_19301:
        CheckExternalEvents(cs2, 0x1F0D);
        // 3358:1F0D mov DI,word ptr CS:[0x1CB0]
        DI = UInt16[CS, (ushort)0x1CB0];
        // 3358:1F12 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1F13 mov word ptr CS:[0x1CB0],DI
        UInt16[CS, (ushort)0x1CB0] = DI;
        // 3358:1F18 pop DI
        DI = Stack.Pop16();
        // 3358:1F19 pop SI
        SI = Stack.Pop16();
        // 3358:1F1A add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:1F1E mov AL,byte ptr SS:[DI]
        AL = UInt8[SS, DI];
        // 3358:1F21 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1F23 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1F24 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1F26 js short 0x1F2B
        if (SignFlag)
        {
            goto label_3358_1F2B_354AB_19316;
        }
        else
        {
            goto label_3358_1F28_354A8_19329;
        }
    label_3358_1F28_354A8_19312:
        CheckExternalEvents(cs2, 0x1F28);
        // 3358:1F28 jmp near 0x1D85
        goto label_3358_1D85_35305_12553;
    label_3358_1F28_354A8_19329:
        CheckExternalEvents(cs2, 0x1F28);
        // 3358:1F28 selector
        if (SelectorSignatureMatches(cs2, 0x1F28, [(byte)0xE9, (byte)0x58, (byte)0xFE]))
        {
            goto label_3358_1F28_354A8_19328;
        }
        if (SelectorSignatureMatches(cs2, 0x1F28, [(byte)0xE9, (byte)0x5A, (byte)0xFE]))
        {
            goto label_3358_1F28_354A8_19312;
        }
        throw FailAsUntested("No selector signature matched at 3358:1F28");
    label_3358_1F28_354A8_19328:
        CheckExternalEvents(cs2, 0x1F28);
        // 3358:1F28 jmp near 0x1D83
        goto label_3358_1D83_35303_12683;
    label_3358_1F2B_354AB_19316:
        CheckExternalEvents(cs2, 0x1F2B);
        // 3358:1F2B mov word ptr CS:[0x1CA6],DI
        UInt16[CS, (ushort)0x1CA6] = DI;
        // 3358:1F30 mov AX,word ptr CS:[0x1CB4]
        AX = UInt16[CS, (ushort)0x1CB4];
        // 3358:1F34 add AX,word ptr CS:[0x1CB2]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x1CB2]);
        // 3358:1F39 mov word ptr CS:[0x1CB2],AX
        UInt16[CS, (ushort)0x1CB2] = AX;
        // 3358:1F3D mov word ptr CS:[0x1CB0],AX
        UInt16[CS, (ushort)0x1CB0] = AX;
        // 3358:1F41 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1F42 mov word ptr CS:[0x1CAE],AX
        UInt16[CS, (ushort)0x1CAE] = AX;
        // 3358:1F46 clc
        CarryFlag = false;
        // 3358:1F47 mov AX,SS
        AX = SS;
        // 3358:1F49 mov DS,AX
        DS = AX;
        // 3358:1F4B ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_1D5A_352DA(int loadOffset)
    {
    label_3358_1D5A_352DA_12524:
        CheckExternalEvents(cs2, 0x1D5A);
        // 3358:1D5A mov word ptr CS:[0x1CA6],DI
        UInt16[CS, (ushort)0x1CA6] = DI;
        // 3358:1D5F mov word ptr CS:[0x1EA6],0xFEDD
        UInt16[CS, (ushort)0x1EA6] = (ushort)0xFEDD;
        // 3358:1D66 mov word ptr CS:[0x1F29],0xFE5A
        UInt16[CS, (ushort)0x1F29] = (ushort)0xFE5A;
        // 3358:1D6D mov AX,0x6360
        AX = (ushort)0x6360;
        // 3358:1D70 mov word ptr CS:[0x1CB0],AX
        UInt16[CS, (ushort)0x1CB0] = AX;
        // 3358:1D74 mov word ptr CS:[0x1CB2],AX
        UInt16[CS, (ushort)0x1CB2] = AX;
        // 3358:1D78 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1D79 mov word ptr CS:[0x1CAE],AX
        UInt16[CS, (ushort)0x1CAE] = AX;
        // 3358:1D7D mov AX,SS
        AX = SS;
        // 3358:1D7F mov DS,AX
        DS = AX;
        // 3358:1D81 stc
        CarryFlag = true;
        // 3358:1D82 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2025_355A5(int loadOffset)
    {
    label_3358_2025_355A5_17569:
        CheckExternalEvents(cs2, 0x2025);
        // 3358:2025 push DX
        Stack.Push16(DX);
        // 3358:2026 push DS
        Stack.Push16(DS);
        // 3358:2027 lds SI,word ptr CS:[0x01A7]
        ushort lxsOffset_3358_2027_355A7 = (ushort)0x01A7;
        ushort lxsValue_3358_2027_355A7 = UInt16[CS, lxsOffset_3358_2027_355A7];
        ushort lxsSegment_3358_2027_355A7 = UInt16[CS, (ushort)(lxsOffset_3358_2027_355A7 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_3358_2027_355A7);
        DS = unchecked((ushort)lxsSegment_3358_2027_355A7);
        // 3358:202C mov AX,SS
        AX = SS;
        // 3358:202E mov ES,AX
        ES = AX;
        // 3358:2030 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:2032 add BX,BX
        BX = Alu16.Add(BX, BX);
        // 3358:2034 mov AX,DX
        AX = DX;
        // 3358:2036 mul BX
        uint result_3358_2036_355B6 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)BX)));
        DX = unchecked((ushort)(result_3358_2036_355B6 >> 16));
        AX = unchecked((ushort)result_3358_2036_355B6);
        // 3358:2038 mov word ptr SS:[BP+4],DX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = DX;
        // 3358:203B rol AX,1
        AX = Alu16.Rol(AX, unchecked((byte)1));
        // 3358:203D rol AX,1
        AX = Alu16.Rol(AX, unchecked((byte)1));
        // 3358:203F and AX,3
        AX = Alu16.And(AX, (ushort)0x0003);
        // 3358:2042 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2044 mov AX,DX
        AX = DX;
        // 3358:2046 mov CX,0x0058
        CX = (ushort)0x0058;
        // 3358:2049 cmp BX,CX
        Alu16.Sub(BX, CX);
        // 3358:204B jae short 0x2079
        if (!CarryFlag)
        {
            goto label_3358_2079_355F9_17588;
        }
    label_3358_204D_355CD_34973:
        CheckExternalEvents(cs2, 0x204D);
        // 3358:204D sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:204F shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 3358:2051 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:2053 mov CX,BX
        CX = BX;
        // 3358:2055 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2057 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 3358:2059 jns short 0x205D
        if (!SignFlag)
        {
            goto label_3358_205D_355DD_34983;
        }
    label_3358_205B_355DB_34981:
        CheckExternalEvents(cs2, 0x205B);
        // 3358:205B add AX,BX
        AX = Alu16.Add(AX, BX);
    label_3358_205D_355DD_34983:
        CheckExternalEvents(cs2, 0x205D);
        // 3358:205D mov CX,BX
        CX = BX;
        // 3358:205F sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:2061 inc CX
        CX = Alu16.Inc(CX);
        // 3358:2062 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:2064 jns short 0x209E
        if (!SignFlag)
        {
            goto label_3358_209E_3561E_17599;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2064");
        }
    label_3358_2079_355F9_17588:
        CheckExternalEvents(cs2, 0x2079);
        // 3358:2079 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:207B sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 3358:207D jns short 0x2081
        if (!SignFlag)
        {
            goto label_3358_2081_35601_17594;
        }
    label_3358_207F_355FF_17592:
        CheckExternalEvents(cs2, 0x207F);
        // 3358:207F add AX,BX
        AX = Alu16.Add(AX, BX);
    label_3358_2081_35601_17594:
        CheckExternalEvents(cs2, 0x2081);
        // 3358:2081 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:2083 mov CX,0x0058
        CX = (ushort)0x0058;
        // 3358:2086 inc CX
        CX = Alu16.Inc(CX);
        // 3358:2087 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:2089 jns short 0x209E
        if (!SignFlag)
        {
            goto label_3358_209E_3561E_17599;
        }
    label_3358_208B_3560B_23492:
        CheckExternalEvents(cs2, 0x208B);
        // 3358:208B add CX,BX
        CX = Alu16.Add(CX, BX);
        // 3358:208D add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:208F mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:2092 stc
        CarryFlag = true;
        // 3358:2093 adc AL,AL
        AL = Alu8.Adc(AL, AL);
        // 3358:2095 add AL,AL
        AL = Alu8.Add(AL, AL);
        // 3358:2097 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 3358:2099 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 3358:209B jmp short 0x20EB
        goto label_3358_20EB_3566B_17635;
    label_3358_209E_3561E_17599:
        CheckExternalEvents(cs2, 0x209E);
        // 3358:209E or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:20A0 je short 0x20EB
        if (ZeroFlag)
        {
            goto label_3358_20EB_3566B_17635;
        }
    label_3358_20A2_35622_17602:
        CheckExternalEvents(cs2, 0x20A2);
        // 3358:20A2 xchg CX,BX
        ushort temp_3358_20A2_35622 = CX;
        CX = BX;
        BX = unchecked((ushort)temp_3358_20A2_35622);
        // 3358:20A4 push SI
        Stack.Push16(SI);
        // 3358:20A5 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:20A7 mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:20AA stc
        CarryFlag = true;
        // 3358:20AB adc AL,AL
        AL = Alu8.Adc(AL, AL);
        // 3358:20AD add AL,AL
        AL = Alu8.Add(AL, AL);
        // 3358:20AF shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 3358:20B1 shl AL,1
        AL = Alu8.Shl(AL, 1);
    label_3358_20B3_35633_17612:
        CheckExternalEvents(cs2, 0x20B3);
        // 3358:20B3 mov DH,byte ptr DS:[SI]
        DH = UInt8[DS, SI];
        // 3358:20B5 inc SI
        SI = Alu16.Inc(SI);
        // 3358:20B6 stc
        CarryFlag = true;
        // 3358:20B7 adc DH,DH
        DH = Alu8.Adc(DH, DH);
        // 3358:20B9 add DH,DH
        DH = Alu8.Add(DH, DH);
        // 3358:20BB shl DH,1
        DH = Alu8.Shl(DH, 1);
        // 3358:20BD shl DH,1
        DH = Alu8.Shl(DH, 1);
        // 3358:20BF mov DL,DH
        DL = DH;
        // 3358:20C1 sub DL,AL
        DL = Alu8.Sub(DL, AL);
        // 3358:20C3 sar DL,1
        DL = Alu8.Sar(DL, 1);
        // 3358:20C5 sar DL,1
        DL = Alu8.Sar(DL, 1);
        // 3358:20C7 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:20C9 je short 0x20E0
        if (ZeroFlag)
        {
            goto label_3358_20E0_35660_17625;
        }
    label_3358_20CB_3564B_17680:
        CheckExternalEvents(cs2, 0x20CB);
        // 3358:20CB mov AH,AL
        AH = AL;
        // 3358:20CD add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:20CF stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:20D0 add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:20D2 mov AL,AH
        AL = AH;
        // 3358:20D4 add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:20D6 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:20D7 mov AL,DH
        AL = DH;
        // 3358:20D9 loop 0x20B3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_20B3_35633_17612;
        }
    label_3358_20DB_3565B_17897:
        CheckExternalEvents(cs2, 0x20DB);
        // 3358:20DB mov CX,BX
        CX = BX;
        // 3358:20DD pop SI
        SI = Stack.Pop16();
        // 3358:20DE jmp short 0x20EB
        goto label_3358_20EB_3566B_17635;
    label_3358_20E0_35660_17625:
        CheckExternalEvents(cs2, 0x20E0);
        // 3358:20E0 mov AH,AL
        AH = AL;
        // 3358:20E2 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:20E3 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:20E4 mov AL,DH
        AL = DH;
        // 3358:20E6 loop 0x20B3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_20B3_35633_17612;
        }
    label_3358_20E8_35668_17632:
        CheckExternalEvents(cs2, 0x20E8);
        // 3358:20E8 mov CX,BX
        CX = BX;
        // 3358:20EA pop SI
        SI = Stack.Pop16();
    label_3358_20EB_3566B_17635:
        CheckExternalEvents(cs2, 0x20EB);
        // 3358:20EB jcxz short 0x2115
        if (CX == (ushort)0x0000)
        {
            goto label_3358_2115_35695_17893;
        }
    label_3358_20ED_3566D_17636:
        CheckExternalEvents(cs2, 0x20ED);
        // 3358:20ED mov DH,byte ptr DS:[SI]
        DH = UInt8[DS, SI];
        // 3358:20EF inc SI
        SI = Alu16.Inc(SI);
        // 3358:20F0 stc
        CarryFlag = true;
        // 3358:20F1 adc DH,DH
        DH = Alu8.Adc(DH, DH);
        // 3358:20F3 add DH,DH
        DH = Alu8.Add(DH, DH);
        // 3358:20F5 shl DH,1
        DH = Alu8.Shl(DH, 1);
        // 3358:20F7 shl DH,1
        DH = Alu8.Shl(DH, 1);
        // 3358:20F9 mov DL,DH
        DL = DH;
        // 3358:20FB sub DL,AL
        DL = Alu8.Sub(DL, AL);
        // 3358:20FD sar DL,1
        DL = Alu8.Sar(DL, 1);
        // 3358:20FF sar DL,1
        DL = Alu8.Sar(DL, 1);
        // 3358:2101 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:2103 je short 0x2118
        if (ZeroFlag)
        {
            goto label_3358_2118_35698_17660;
        }
    label_3358_2105_35685_17650:
        CheckExternalEvents(cs2, 0x2105);
        // 3358:2105 mov AH,AL
        AH = AL;
        // 3358:2107 add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:2109 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:210A add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:210C mov AL,AH
        AL = AH;
        // 3358:210E add AH,DL
        AH = Alu8.Add(AH, DL);
        // 3358:2110 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2111 mov AL,DH
        AL = DH;
        // 3358:2113 loop 0x20ED
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_20ED_3566D_17636;
        }
    label_3358_2115_35695_17893:
        CheckExternalEvents(cs2, 0x2115);
        // 3358:2115 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2116 pop DX
        DX = Stack.Pop16();
        // 3358:2117 ret near
        return NearRet((ushort)0x0000);
    label_3358_2118_35698_17660:
        CheckExternalEvents(cs2, 0x2118);
        // 3358:2118 mov AH,AL
        AH = AL;
        // 3358:211A stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:211B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:211C mov AL,DH
        AL = DH;
        // 3358:211E loop 0x20ED
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_20ED_3566D_17636;
        }
    label_3358_2120_356A0_17666:
        CheckExternalEvents(cs2, 0x2120);
        // 3358:2120 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2121 pop DX
        DX = Stack.Pop16();
        // 3358:2122 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2123_356A3(int loadOffset)
    {
    label_3358_2123_356A3_17692:
        CheckExternalEvents(cs2, 0x2123);
        // 3358:2123 push DX
        Stack.Push16(DX);
        // 3358:2124 push BP
        Stack.Push16(BP);
        // 3358:2125 mov CX,word ptr SS:[BP+0x0A]
        CX = UInt16[SS, (ushort)(BP + (sbyte)10)];
        // 3358:2128 mov DX,word ptr SS:[BP+2]
        DX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:212B mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:2130 add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:2134 mov word ptr CS:[0x01B3],0x00B0
        UInt16[CS, (ushort)0x01B3] = (ushort)0x00B0;
        // 3358:213B mov SI,DI
        SI = DI;
        // 3358:213D mov AX,0x0190
        AX = (ushort)0x0190;
        // 3358:2140 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2142 mov BP,DI
        BP = DI;
        // 3358:2144 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2146 mov BX,DI
        BX = DI;
        // 3358:2148 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:214A mov word ptr CS:[0x01B5],DI
        UInt16[CS, (ushort)0x01B5] = DI;
        // 3358:214F add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2151 jmp short 0x2183
        return unknown_3358_2183_35703(0x0000);
    }

    public virtual Action unknown_3358_2153_356D3(int loadOffset)
    {
    label_3358_2153_356D3_17924:
        CheckExternalEvents(cs2, 0x2153);
        // 3358:2153 push DX
        Stack.Push16(DX);
        // 3358:2154 push BP
        Stack.Push16(BP);
        // 3358:2155 mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:2158 mov DX,word ptr SS:[BP-6]
        DX = UInt16[SS, (ushort)(BP + (sbyte)-6)];
        // 3358:215B mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:2160 add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:2164 mov word ptr CS:[0x01B3],0x00B0
        UInt16[CS, (ushort)0x01B3] = (ushort)0x00B0;
        // 3358:216B push DI
        Stack.Push16(DI);
        // 3358:216C mov AX,0x0190
        AX = (ushort)0x0190;
        // 3358:216F add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2171 mov word ptr CS:[0x01B5],DI
        UInt16[CS, (ushort)0x01B5] = DI;
        // 3358:2176 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2178 mov BX,DI
        BX = DI;
        // 3358:217A add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:217C mov BP,DI
        BP = DI;
        // 3358:217E add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2180 mov SI,DI
        SI = DI;
        // 3358:2182 pop DI
        DI = Stack.Pop16();
        return unknown_3358_2183_35703(0x0000);
    }

    public virtual Action unknown_3358_2343_358C3(int loadOffset)
    {
    label_3358_2343_358C3_17845:
        CheckExternalEvents(cs2, 0x2343);
        // 3358:2343 push DX
        Stack.Push16(DX);
        // 3358:2344 push BP
        Stack.Push16(BP);
        // 3358:2345 mov BH,4
        BH = (byte)0x04;
        // 3358:2347 mov BP,0x0F0F
        BP = (ushort)0x0F0F;
        // 3358:234A mov DX,0x1010
        DX = (ushort)0x1010;
    label_3358_234D_358CD_17851:
        CheckExternalEvents(cs2, 0x234D);
        // 3358:234D push CX
        Stack.Push16(CX);
        // 3358:234E shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2350 jae short 0x2360
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2350");
        }
    label_3358_2360_358E0_17854:
        CheckExternalEvents(cs2, 0x2360);
        // 3358:2360 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:2361 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:2363 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:2365 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:2367 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:2369 and AX,BP
        AX = Alu16.And(AX, BP);
        // 3358:236B add AX,DX
        AX = Alu16.Add(AX, DX);
        // 3358:236D stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:236E loop 0x2360
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2360_358E0_17854;
        }
    label_3358_2370_358F0_17864:
        CheckExternalEvents(cs2, 0x2370);
        // 3358:2370 pop CX
        CX = Stack.Pop16();
        // 3358:2371 sub DI,CX
        DI = Alu16.Sub(DI, CX);
        // 3358:2373 sub SI,CX
        SI = Alu16.Sub(SI, CX);
        // 3358:2375 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2379 add SI,0x0190
        SI = Alu16.Add(SI, (ushort)0x0190);
        // 3358:237D dec BH
        BH = Alu8.Dec(BH);
        // 3358:237F jne short 0x234D
        if (!ZeroFlag)
        {
            goto label_3358_234D_358CD_17851;
        }
    label_3358_2381_35901_17873:
        CheckExternalEvents(cs2, 0x2381);
        // 3358:2381 pop BP
        BP = Stack.Pop16();
        // 3358:2382 pop DX
        DX = Stack.Pop16();
        // 3358:2383 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2396_35916(int loadOffset)
    {
    label_3358_2396_35916_20918:
        CheckExternalEvents(cs2, 0x2396);
        // 3358:2396 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 3358:2398 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:239A jns short 0x239E
        if (!SignFlag)
        {
            goto label_3358_239E_3591E_20922;
        }
    label_3358_239C_3591C_20962:
        CheckExternalEvents(cs2, 0x239C);
        // 3358:239C neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_3358_239E_3591E_20922:
        CheckExternalEvents(cs2, 0x239E);
        // 3358:239E sub AX,0x0046
        AX = Alu16.Sub(AX, (ushort)0x0046);
        // 3358:23A1 jb short 0x23CB
        if (CarryFlag)
        {
            goto label_3358_23CB_3594B_20925;
        }
    label_3358_23A3_35923_32074:
        CheckExternalEvents(cs2, 0x23A3);
        // 3358:23A3 mov BX,0x2384
        BX = (ushort)0x2384;
        // 3358:23A6 xlat byte ptr CS:[BX+AL]
        AL = UInt8[CS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:23A8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:23AA mov DX,AX
        DX = AX;
        // 3358:23AC xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:23AE add SI,DX
        SI = Alu16.Add(SI, DX);
        // 3358:23B0 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 3358:23B2 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 3358:23B4 jb short 0x23CC
        if (CarryFlag)
        {
            goto label_3358_23CC_3594C_35040;
        }
    label_3358_23B6_35936_32084:
        CheckExternalEvents(cs2, 0x23B6);
        // 3358:23B6 push DX
        Stack.Push16(DX);
        // 3358:23B7 xchg CX,DX
        ushort temp_3358_23B7_35937 = CX;
        CX = DX;
        DX = unchecked((ushort)temp_3358_23B7_35937);
        // 3358:23B9 sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 3358:23BC jb short 0x23C4
        if (CarryFlag)
        {
            goto label_3358_23C4_35944_32093;
        }
    label_3358_23BE_3593E_32089:
        CheckExternalEvents(cs2, 0x23BE);
        // 3358:23BE rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:23C0 mov AX,0x191C
        AX = (ushort)0x191C;
        // 3358:23C3 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_3358_23C4_35944_32093:
        CheckExternalEvents(cs2, 0x23C4);
        // 3358:23C4 mov AX,0x1718
        AX = (ushort)0x1718;
        // 3358:23C7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:23C8 mov CX,DX
        CX = DX;
        // 3358:23CA pop DX
        DX = Stack.Pop16();
    label_3358_23CB_3594B_20925:
        CheckExternalEvents(cs2, 0x23CB);
        // 3358:23CB ret near
        return NearRet((ushort)0x0000);
    label_3358_23CC_3594C_35040:
        CheckExternalEvents(cs2, 0x23CC);
        // 3358:23CC add CX,DX
        CX = Alu16.Add(CX, DX);
        // 3358:23CE add CX,DX
        CX = Alu16.Add(CX, DX);
        // 3358:23D0 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:23D2 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 3358:23D4 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 3358:23D6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_23D7_35957(int loadOffset)
    {
    label_3358_23D7_35957_20944:
        CheckExternalEvents(cs2, 0x23D7);
        // 3358:23D7 jcxz short 0x23EA
        if (CX == (ushort)0x0000)
        {
            goto label_3358_23EA_3596A_20946;
        }
    label_3358_23D9_35959_32097:
        CheckExternalEvents(cs2, 0x23D9);
        // 3358:23D9 mov AX,0x1817
        AX = (ushort)0x1817;
        // 3358:23DC stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:23DD sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 3358:23E0 jb short 0x23EA
        if (CarryFlag)
        {
            goto label_3358_23EA_3596A_20946;
        }
    label_3358_23E2_35962_32102:
        CheckExternalEvents(cs2, 0x23E2);
        // 3358:23E2 mov AX,0x1C19
        AX = (ushort)0x1C19;
        // 3358:23E5 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:23E6 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:23E8 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_23EA_3596A_20946:
        CheckExternalEvents(cs2, 0x23EA);
        // 3358:23EA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2413_35993(int loadOffset)
    {
    label_3358_2413_35993_20911:
        CheckExternalEvents(cs2, 0x2413);
        // 3358:2413 push AX
        Stack.Push16(AX);
        // 3358:2414 push CX
        Stack.Push16(CX);
        // 3358:2415 push DX
        Stack.Push16(DX);
        // 3358:2416 push SI
        Stack.Push16(SI);
        // 3358:2417 push DI
        Stack.Push16(DI);
        // 3358:2418 call near 0x2396
        NearCall(cs2, 0x241B, unknown_3358_2396_35916);
    label_3358_241B_3599B_20927:
        CheckExternalEvents(cs2, 0x241B);
        // 3358:241B push DX
        Stack.Push16(DX);
        // 3358:241C mov BP,0x0F0F
        BP = (ushort)0x0F0F;
        // 3358:241F mov DX,0x1010
        DX = (ushort)0x1010;
        // 3358:2422 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2424 jae short 0x242C
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2424");
        }
    label_3358_242C_359AC_20933:
        CheckExternalEvents(cs2, 0x242C);
        // 3358:242C jcxz short 0x2436
        if (CX == (ushort)0x0000)
        {
            goto label_3358_2436_359B6_20941;
        }
    label_3358_242E_359AE_20935:
        CheckExternalEvents(cs2, 0x242E);
        // 3358:242E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:242F and AX,BP
        AX = Alu16.And(AX, BP);
        // 3358:2431 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 3358:2433 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2434 loop 0x242E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_242E_359AE_20935;
        }
    label_3358_2436_359B6_20941:
        CheckExternalEvents(cs2, 0x2436);
        // 3358:2436 pop CX
        CX = Stack.Pop16();
        // 3358:2437 call near 0x23D7
        NearCall(cs2, 0x243A, unknown_3358_23D7_35957);
    label_3358_243A_359BA_20948:
        CheckExternalEvents(cs2, 0x243A);
        // 3358:243A pop DI
        DI = Stack.Pop16();
        // 3358:243B pop SI
        SI = Stack.Pop16();
        // 3358:243C pop DX
        DX = Stack.Pop16();
        // 3358:243D pop CX
        CX = Stack.Pop16();
        // 3358:243E pop AX
        AX = Stack.Pop16();
        // 3358:243F dec AX
        AX = Alu16.Dec(AX);
        // 3358:2440 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_24AD_35A2D(int loadOffset)
    {
    label_3358_24AD_35A2D_28606:
        CheckExternalEvents(cs2, 0x24AD);
        // 3358:24AD push AX
        Stack.Push16(AX);
        // 3358:24AE push CX
        Stack.Push16(CX);
        // 3358:24AF push DX
        Stack.Push16(DX);
        // 3358:24B0 push SI
        Stack.Push16(SI);
        // 3358:24B1 push DI
        Stack.Push16(DI);
        // 3358:24B2 call near 0x2396
        NearCall(cs2, 0x24B5, unknown_3358_2396_35916);
    label_3358_24B5_35A35_28613:
        CheckExternalEvents(cs2, 0x24B5);
        // 3358:24B5 push DX
        Stack.Push16(DX);
        // 3358:24B6 mov BX,BP
        BX = BP;
        // 3358:24B8 mov AH,0x70
        AH = (byte)0x70;
        // 3358:24BA dec CX
        CX = Alu16.Dec(CX);
    label_3358_24BB_35A3B_28618:
        CheckExternalEvents(cs2, 0x24BB);
        // 3358:24BB lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:24BC cmp AL,byte ptr DS:[SI]
        Alu8.Sub(AL, UInt8[DS, SI]);
        // 3358:24BE jne short 0x24CC
        if (!ZeroFlag)
        {
            goto label_3358_24CC_35A4C_28629;
        }
    label_3358_24C0_35A40_28621:
        CheckExternalEvents(cs2, 0x24C0);
        // 3358:24C0 cmp AL,byte ptr DS:[SI+0x00C7]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (short)199)]);
        // 3358:24C4 jne short 0x24CC
        if (!ZeroFlag)
        {
            goto label_3358_24CC_35A4C_28629;
        }
    label_3358_24C6_35A46_28624:
        CheckExternalEvents(cs2, 0x24C6);
        // 3358:24C6 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:24C7 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:24C8 loop 0x24BB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_24BB_35A3B_28618;
        }
    label_3358_24CA_35A4A_28633:
        CheckExternalEvents(cs2, 0x24CA);
        // 3358:24CA jmp short 0x24D1
        goto label_3358_24D1_35A51_28635;
    label_3358_24CC_35A4C_28629:
        CheckExternalEvents(cs2, 0x24CC);
        // 3358:24CC mov AL,AH
        AL = AH;
        // 3358:24CE stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:24CF loop 0x24BB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_24BB_35A3B_28618;
        }
    label_3358_24D1_35A51_28635:
        CheckExternalEvents(cs2, 0x24D1);
        // 3358:24D1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:24D2 cmp AL,byte ptr DS:[SI+0x00C7]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (short)199)]);
        // 3358:24D6 jne short 0x24DB
        if (!ZeroFlag)
        {
            goto label_3358_24DB_35A5B_28659;
        }
    label_3358_24D8_35A58_28639:
        CheckExternalEvents(cs2, 0x24D8);
        // 3358:24D8 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:24D9 jmp short 0x24DD
        goto label_3358_24DD_35A5D_28642;
    label_3358_24DB_35A5B_28659:
        CheckExternalEvents(cs2, 0x24DB);
        // 3358:24DB mov AL,AH
        AL = AH;
    label_3358_24DD_35A5D_28642:
        CheckExternalEvents(cs2, 0x24DD);
        // 3358:24DD stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:24DE pop CX
        CX = Stack.Pop16();
        // 3358:24DF call near 0x23D7
        NearCall(cs2, 0x24E2, unknown_3358_23D7_35957);
    label_3358_24E2_35A62_28646:
        CheckExternalEvents(cs2, 0x24E2);
        // 3358:24E2 pop DI
        DI = Stack.Pop16();
        // 3358:24E3 pop SI
        SI = Stack.Pop16();
        // 3358:24E4 pop DX
        DX = Stack.Pop16();
        // 3358:24E5 pop CX
        CX = Stack.Pop16();
        // 3358:24E6 pop AX
        AX = Stack.Pop16();
        // 3358:24E7 inc AX
        AX = Alu16.Inc(AX);
        // 3358:24E8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_24E9_35A69(int loadOffset)
    {
    label_3358_24E9_35A69_31067:
        CheckExternalEvents(cs2, 0x24E9);
        // 3358:24E9 push AX
        Stack.Push16(AX);
        // 3358:24EA push CX
        Stack.Push16(CX);
        // 3358:24EB push DX
        Stack.Push16(DX);
        // 3358:24EC push SI
        Stack.Push16(SI);
        // 3358:24ED push DI
        Stack.Push16(DI);
        // 3358:24EE call near 0x2396
        NearCall(cs2, 0x24F1, unknown_3358_2396_35916);
    label_3358_24F1_35A71_31074:
        CheckExternalEvents(cs2, 0x24F1);
        // 3358:24F1 push DX
        Stack.Push16(DX);
        // 3358:24F2 mov BX,BP
        BX = BP;
        // 3358:24F4 mov AH,0x70
        AH = (byte)0x70;
        // 3358:24F6 dec CX
        CX = Alu16.Dec(CX);
    label_3358_24F7_35A77_31079:
        CheckExternalEvents(cs2, 0x24F7);
        // 3358:24F7 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:24F8 cmp AL,byte ptr DS:[SI]
        Alu8.Sub(AL, UInt8[DS, SI]);
        // 3358:24FA jne short 0x2510
        if (!ZeroFlag)
        {
            goto label_3358_2510_35A90_31093;
        }
    label_3358_24FC_35A7C_31082:
        CheckExternalEvents(cs2, 0x24FC);
        // 3358:24FC cmp AL,byte ptr DS:[SI+0x00C7]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (short)199)]);
        // 3358:2500 jne short 0x2510
        if (!ZeroFlag)
        {
            goto label_3358_2510_35A90_31093;
        }
    label_3358_2502_35A82_31085:
        CheckExternalEvents(cs2, 0x2502);
        // 3358:2502 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:2503 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 3358:2505 je short 0x2512
        if (ZeroFlag)
        {
            goto label_3358_2512_35A92_31089;
        }
    label_3358_2507_35A87_31095:
        CheckExternalEvents(cs2, 0x2507);
        // 3358:2507 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 3358:2509 add AL,0x71
        AL = Alu8.Add(AL, (byte)0x71);
        // 3358:250B stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:250C loop 0x24F7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_24F7_35A77_31079;
        }
    label_3358_250E_35A8E_35437:
        CheckExternalEvents(cs2, 0x250E);
        // 3358:250E jmp short 0x2515
        goto label_3358_2515_35A95_31100;
    label_3358_2510_35A90_31093:
        CheckExternalEvents(cs2, 0x2510);
        // 3358:2510 mov AL,AH
        AL = AH;
    label_3358_2512_35A92_31089:
        CheckExternalEvents(cs2, 0x2512);
        // 3358:2512 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2513 loop 0x24F7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_24F7_35A77_31079;
        }
    label_3358_2515_35A95_31100:
        CheckExternalEvents(cs2, 0x2515);
        // 3358:2515 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:2516 cmp AL,byte ptr DS:[SI+0x00C7]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (short)199)]);
        // 3358:251A jne short 0x2527
        if (!ZeroFlag)
        {
            goto label_3358_2527_35AA7_31141;
        }
    label_3358_251C_35A9C_31104:
        CheckExternalEvents(cs2, 0x251C);
        // 3358:251C xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 3358:251D cmp AL,AH
        Alu8.Sub(AL, AH);
        // 3358:251F je short 0x2529
        if (ZeroFlag)
        {
            goto label_3358_2529_35AA9_31108;
        }
    label_3358_2521_35AA1_35433:
        CheckExternalEvents(cs2, 0x2521);
        // 3358:2521 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 3358:2523 add AL,0x71
        AL = Alu8.Add(AL, (byte)0x71);
        // 3358:2525 jmp short 0x2529
        goto label_3358_2529_35AA9_31108;
    label_3358_2527_35AA7_31141:
        CheckExternalEvents(cs2, 0x2527);
        // 3358:2527 mov AL,AH
        AL = AH;
    label_3358_2529_35AA9_31108:
        CheckExternalEvents(cs2, 0x2529);
        // 3358:2529 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:252A pop CX
        CX = Stack.Pop16();
        // 3358:252B call near 0x23D7
        NearCall(cs2, 0x252E, unknown_3358_23D7_35957);
    label_3358_252E_35AAE_31112:
        CheckExternalEvents(cs2, 0x252E);
        // 3358:252E pop DI
        DI = Stack.Pop16();
        // 3358:252F pop SI
        SI = Stack.Pop16();
        // 3358:2530 pop DX
        DX = Stack.Pop16();
        // 3358:2531 pop CX
        CX = Stack.Pop16();
        // 3358:2532 pop AX
        AX = Stack.Pop16();
        // 3358:2533 inc AX
        AX = Alu16.Inc(AX);
        // 3358:2534 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_253D_35ABD(int loadOffset)
    {
    label_3358_253D_35ABD_18646:
        CheckExternalEvents(cs2, 0x253D);
        // 3358:253D cmp byte ptr CS:[0x01A1],0
        Alu8.Sub(UInt8[CS, (ushort)0x01A1], (byte)0x00);
        // 3358:2543 je short 0x2564
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:2543");
        }
    label_3358_2545_35AC5_18649:
        CheckExternalEvents(cs2, 0x2545);
        // 3358:2545 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2548 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:254A cmp AX,5
        Alu16.Sub(AX, (ushort)0x0005);
        // 3358:254D jb short 0x2545
        if (CarryFlag)
        {
            goto label_3358_2545_35AC5_18649;
        }
        else
        {
            return unknown_3358_254F_35ACF(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_3358_2572_35AF2(int loadOffset)
    {
    label_3358_2572_35AF2_6512:
        CheckExternalEvents(cs2, 0x2572);
        // 3358:2572 cmp byte ptr CS:[0x01A1],0
        Alu8.Sub(UInt8[CS, (ushort)0x01A1], (byte)0x00);
        // 3358:2578 jne short 0x254F
        if (!ZeroFlag)
        {
            return unknown_3358_254F_35ACF(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2578");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_3358_2588_35B08(int loadOffset)
    {
    label_3358_2588_35B08_41537:
        CheckExternalEvents(cs2, 0x2588);
        // 3358:2588 mov AX,word ptr CS:[0x2535]
        AX = UInt16[CS, (ushort)0x2535];
        // 3358:258C xchg AX,word ptr CS:[0x2537]
        ushort xchgOffset_3358_258C_35B0C = (ushort)0x2537;
        ushort temp_3358_258C_35B0C = AX;
        AX = UInt16[CS, xchgOffset_3358_258C_35B0C];
        UInt16[CS, xchgOffset_3358_258C_35B0C] = unchecked((ushort)temp_3358_258C_35B0C);
        // 3358:2591 mov word ptr CS:[0x2535],AX
        UInt16[CS, (ushort)0x2535] = AX;
        // 3358:2595 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2596_35B16(int loadOffset)
    {
    label_3358_2596_35B16_18611:
        CheckExternalEvents(cs2, 0x2596);
        // 3358:2596 push DS
        Stack.Push16(DS);
        // 3358:2597 push ES
        Stack.Push16(ES);
        // 3358:2598 mov DS,word ptr CS:[0x2539]
        DS = UInt16[CS, (ushort)0x2539];
        // 3358:259D mov ES,word ptr CS:[0x2535]
        ES = UInt16[CS, (ushort)0x2535];
        // 3358:25A2 push CS
        Stack.Push16(CS);
        // 3358:25A3 call near 0x1B7C
        NearCall(cs2, 0x25A6, unknown_3358_1B7C_350FC);
    label_3358_25A6_35B26_18618:
        CheckExternalEvents(cs2, 0x25A6);
        // 3358:25A6 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:25A7 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:25A8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_261D_35B9D(int loadOffset)
    {
    label_3358_261D_35B9D_4566:
        CheckExternalEvents(cs2, 0x261D);
        // 3358:261D cmp byte ptr DS:[0x01A1],0
        Alu8.Sub(UInt8[DS, (ushort)0x01A1], (byte)0x00);
        // 3358:2622 jne short 0x2627
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2622");
        }
    label_3358_2627_35BA7_4569:
        CheckExternalEvents(cs2, 0x2627);
        // 3358:2627 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_26E3_35C63(int loadOffset)
    {
    label_3358_26E3_35C63_4532:
        CheckExternalEvents(cs2, 0x26E3);
        // 3358:26E3 mov word ptr CS:[0x261B],AX
        UInt16[CS, (ushort)0x261B] = AX;
    label_3358_26E7_35C67_4534:
        CheckExternalEvents(cs2, 0x26E7);
        // 3358:26E7 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_3358_26E9_35C69_4535:
        CheckExternalEvents(cs2, 0x26E9);
        // 3358:26E9 push BX
        Stack.Push16(BX);
        // 3358:26EA push DX
        Stack.Push16(DX);
        // 3358:26EB push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:26EE mov SI,0x05BF
        SI = (ushort)0x05BF;
        // 3358:26F1 add SI,BX
        SI = Alu16.Add(SI, BX);
        // 3358:26F3 add SI,BX
        SI = Alu16.Add(SI, BX);
        // 3358:26F5 add SI,BX
        SI = Alu16.Add(SI, BX);
        // 3358:26F7 mov DI,SI
        DI = SI;
        // 3358:26F9 mov AX,word ptr CS:[0x261B]
        AX = UInt16[CS, (ushort)0x261B];
        // 3358:26FD push AX
        Stack.Push16(AX);
        // 3358:26FE mov CX,AX
        CX = AX;
        // 3358:2700 add CX,CX
        CX = Alu16.Add(CX, CX);
        // 3358:2702 add CX,AX
        CX = Alu16.Add(CX, AX);
    label_3358_2704_35C84_4548:
        CheckExternalEvents(cs2, 0x2704);
        // 3358:2704 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 3358:2706 sub AL,DH
        AL = Alu8.Sub(AL, DH);
        // 3358:2708 jns short 0x270C
        if (!SignFlag)
        {
            goto label_3358_270C_35C8C_4553;
        }
    label_3358_270A_35C8A_4551:
        CheckExternalEvents(cs2, 0x270A);
        // 3358:270A xor AL,AL
        AL = Alu8.Xor(AL, AL);
    label_3358_270C_35C8C_4553:
        CheckExternalEvents(cs2, 0x270C);
        // 3358:270C mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 3358:270E inc SI
        SI = Alu16.Inc(SI);
        // 3358:270F loop 0x2704
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2704_35C84_4548;
        }
    label_3358_2711_35C91_4558:
        CheckExternalEvents(cs2, 0x2711);
        // 3358:2711 pop CX
        CX = Stack.Pop16();
        // 3358:2712 mov DX,DI
        DX = DI;
        // 3358:2714 call near 0x0B68
        NearCall(cs2, 0x2717, unknown_3358_0B68_340E8);
    label_3358_2717_35C97_4563:
        CheckExternalEvents(cs2, 0x2717);
        // 3358:2717 pop BX
        BX = Stack.Pop16();
        // 3358:2718 call near 0x261D
        NearCall(cs2, 0x271B, unknown_3358_261D_35B9D);
    label_3358_271B_35C9B_4571:
        CheckExternalEvents(cs2, 0x271B);
        // 3358:271B pop DX
        DX = Stack.Pop16();
        // 3358:271C pop BX
        BX = Stack.Pop16();
        // 3358:271D mov AX,word ptr CS:[0x261B]
        AX = UInt16[CS, (ushort)0x261B];
        // 3358:2721 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 3358:2723 cmp BX,0x00FF
        Alu16.Sub(BX, (ushort)0x00FF);
        // 3358:2727 jb short 0x26E9
        if (CarryFlag)
        {
            goto label_3358_26E9_35C69_4535;
        }
    label_3358_2729_35CA9_4579:
        CheckExternalEvents(cs2, 0x2729);
        // 3358:2729 dec DL
        DL = Alu8.Dec(DL);
        // 3358:272B jne short 0x26E7
        if (!ZeroFlag)
        {
            goto label_3358_26E7_35C67_4534;
        }
    label_3358_272D_35CAD_4583:
        CheckExternalEvents(cs2, 0x272D);
        // 3358:272D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_27E6_35D66(int loadOffset)
    {
    label_3358_27E6_35D66_11077:
        CheckExternalEvents(cs2, 0x27E6);
        // 3358:27E6 call near 0x2802
        NearCall(cs2, 0x27E9, unknown_3358_2802_35D82);
    label_3358_27E9_35D69_11088:
        CheckExternalEvents(cs2, 0x27E9);
        // 3358:27E9 mov word ptr CS:[0x27E4],0x2823
        UInt16[CS, (ushort)0x27E4] = (ushort)0x2823;
        // 3358:27F0 push CX
        Stack.Push16(CX);
        // 3358:27F1 push SI
        Stack.Push16(SI);
        // 3358:27F2 push BX
        Stack.Push16(BX);
        // 3358:27F3 push BP
        Stack.Push16(BP);
        // 3358:27F4 mov DX,0x00B0
        DX = (ushort)0x00B0;
        // 3358:27F7 mov BX,0x005B
        BX = (ushort)0x005B;
        // 3358:27FA call near 0x28EC
        NearCall(cs2, 0x27FD, unknown_3358_28EC_35E6C);
    label_3358_27FD_35D7D_11274:
        CheckExternalEvents(cs2, 0x27FD);
        // 3358:27FD pop BP
        BP = Stack.Pop16();
        // 3358:27FE pop BX
        BX = Stack.Pop16();
        // 3358:27FF pop SI
        SI = Stack.Pop16();
        // 3358:2800 pop CX
        CX = Stack.Pop16();
        // 3358:2801 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2802_35D82(int loadOffset)
    {
    label_3358_2802_35D82_11079:
        CheckExternalEvents(cs2, 0x2802);
        // 3358:2802 push CX
        Stack.Push16(CX);
        // 3358:2803 push SI
        Stack.Push16(SI);
        // 3358:2804 sub CX,8
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2807 je short 0x2820
        if (ZeroFlag)
        {
            goto label_3358_2820_35DA0_11084;
        }
    label_3358_2809_35D89_11299:
        CheckExternalEvents(cs2, 0x2809);
        // 3358:2809 push BX
        Stack.Push16(BX);
        // 3358:280A push BP
        Stack.Push16(BP);
        // 3358:280B sub SI,1
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 3358:280E mov word ptr CS:[0x27E4],0x2887
        UInt16[CS, (ushort)0x27E4] = (ushort)0x2887;
        // 3358:2815 mov DX,0x00B0
        DX = (ushort)0x00B0;
        // 3358:2818 mov BX,0x005B
        BX = (ushort)0x005B;
        // 3358:281B call near 0x28EC
        NearCall(cs2, 0x281E, unknown_3358_28EC_35E6C);
    label_3358_281E_35D9E_11377:
        CheckExternalEvents(cs2, 0x281E);
        // 3358:281E pop BP
        BP = Stack.Pop16();
        // 3358:281F pop BX
        BX = Stack.Pop16();
    label_3358_2820_35DA0_11084:
        CheckExternalEvents(cs2, 0x2820);
        // 3358:2820 pop SI
        SI = Stack.Pop16();
        // 3358:2821 pop CX
        CX = Stack.Pop16();
        // 3358:2822 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2823_35DA3(int loadOffset)
    {
    label_3358_2823_35DA3_11151:
        CheckExternalEvents(cs2, 0x2823);
        // 3358:2823 push BX
        Stack.Push16(BX);
        // 3358:2824 mov AX,0x005B
        AX = (ushort)0x005B;
        // 3358:2827 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:2829 js short 0x2832
        if (SignFlag)
        {
            goto label_3358_2832_35DB2_11160;
        }
    label_3358_282B_35DAB_11156:
        CheckExternalEvents(cs2, 0x282B);
        // 3358:282B shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:282D mov BX,0x005B
        BX = (ushort)0x005B;
        // 3358:2830 sub BX,AX
        BX = Alu16.Sub(BX, AX);
    label_3358_2832_35DB2_11160:
        CheckExternalEvents(cs2, 0x2832);
        // 3358:2832 mov AX,BX
        AX = BX;
        // 3358:2834 sub AX,0x0047
        AX = Alu16.Sub(AX, (ushort)0x0047);
        // 3358:2837 cmp AX,0x004E
        Alu16.Sub(AX, (ushort)0x004E);
        // 3358:283A jae short 0x2885
        if (!CarryFlag)
        {
            return unknown_3358_2885_35E05(0x0000);
        }
    label_3358_283C_35DBC_11164:
        CheckExternalEvents(cs2, 0x283C);
        // 3358:283C cmp DX,0x0140
        Alu16.Sub(DX, (ushort)0x0140);
        // 3358:2840 jae short 0x2885
        if (!CarryFlag)
        {
            return unknown_3358_2885_35E05(0x0000);
        }
    label_3358_2842_35DC2_11167:
        CheckExternalEvents(cs2, 0x2842);
        // 3358:2842 push CX
        Stack.Push16(CX);
        // 3358:2843 push DI
        Stack.Push16(DI);
        // 3358:2844 call near 0x0C10
        NearCall(cs2, 0x2847, unknown_3358_0C10_34190);
    label_3358_2847_35DC7_11171:
        CheckExternalEvents(cs2, 0x2847);
        // 3358:2847 mov AX,word ptr ES:[DI]
        AX = UInt16[ES, DI];
        // 3358:284A and AX,word ptr ES:[DI+2]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (sbyte)2)]);
        // 3358:284E and AX,word ptr ES:[DI+0x0140]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)320)]);
        // 3358:2853 and AX,word ptr ES:[DI+0x0142]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)322)]);
        // 3358:2858 and AX,word ptr ES:[DI+0x0280]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)640)]);
        // 3358:285D and AX,word ptr ES:[DI+0x0282]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)642)]);
        // 3358:2862 and AX,word ptr ES:[DI+0x03C0]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)960)]);
        // 3358:2867 and AX,word ptr ES:[DI+0x03C2]
        AX = Alu16.And(AX, UInt16[ES, (ushort)(DI + (short)962)]);
        // 3358:286C and AL,AH
        AL = Alu8.And(AL, AH);
        // 3358:286E jns short 0x2883
        if (!SignFlag)
        {
            goto label_3358_2883_35E03_11194;
        }
    label_3358_2870_35DF0_11182:
        CheckExternalEvents(cs2, 0x2870);
        // 3358:2870 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 3358:2872 cmp AL,0xF0
        Alu8.Sub(AL, (byte)0xF0);
        // 3358:2874 jae short 0x2883
        if (!CarryFlag)
        {
            goto label_3358_2883_35E03_11194;
        }
    label_3358_2876_35DF6_11186:
        CheckExternalEvents(cs2, 0x2876);
        // 3358:2876 mov AH,AL
        AH = AL;
        // 3358:2878 mov CX,4
        CX = (ushort)0x0004;
    label_3358_287B_35DFB_11189:
        CheckExternalEvents(cs2, 0x287B);
        // 3358:287B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:287C stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:287D add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:2881 loop 0x287B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_287B_35DFB_11189;
        }
    label_3358_2883_35E03_11194:
        CheckExternalEvents(cs2, 0x2883);
        // 3358:2883 pop DI
        DI = Stack.Pop16();
        // 3358:2884 pop CX
        CX = Stack.Pop16();
        return unknown_3358_2885_35E05(0x0000);
    }

    public virtual Action unknown_3358_2887_35E07(int loadOffset)
    {
    label_3358_2887_35E07_11307:
        CheckExternalEvents(cs2, 0x2887);
        // 3358:2887 push BX
        Stack.Push16(BX);
        // 3358:2888 mov AX,0x005B
        AX = (ushort)0x005B;
        // 3358:288B sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:288D js short 0x2896
        if (SignFlag)
        {
            goto label_3358_2896_35E16_11316;
        }
    label_3358_288F_35E0F_11312:
        CheckExternalEvents(cs2, 0x288F);
        // 3358:288F shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:2891 mov BX,0x005B
        BX = (ushort)0x005B;
        // 3358:2894 sub BX,AX
        BX = Alu16.Sub(BX, AX);
    label_3358_2896_35E16_11316:
        CheckExternalEvents(cs2, 0x2896);
        // 3358:2896 mov AX,BX
        AX = BX;
        // 3358:2898 sub AX,0x0047
        AX = Alu16.Sub(AX, (ushort)0x0047);
        // 3358:289B cmp AX,0x004E
        Alu16.Sub(AX, (ushort)0x004E);
        // 3358:289E jae short 0x2885
        if (!CarryFlag)
        {
            return unknown_3358_2885_35E05(0x0000);
        }
    label_3358_28A0_35E20_11320:
        CheckExternalEvents(cs2, 0x28A0);
        // 3358:28A0 cmp DX,0x0140
        Alu16.Sub(DX, (ushort)0x0140);
        // 3358:28A4 jae short 0x2885
        if (!CarryFlag)
        {
            return unknown_3358_2885_35E05(0x0000);
        }
    label_3358_28A6_35E26_11323:
        CheckExternalEvents(cs2, 0x28A6);
        // 3358:28A6 push CX
        Stack.Push16(CX);
        // 3358:28A7 push SI
        Stack.Push16(SI);
        // 3358:28A8 push DI
        Stack.Push16(DI);
        // 3358:28A9 call near 0x0C10
        NearCall(cs2, 0x28AC, unknown_3358_0C10_34190);
    label_3358_28AC_35E2C_11328:
        CheckExternalEvents(cs2, 0x28AC);
        // 3358:28AC mov CX,4
        CX = (ushort)0x0004;
    label_3358_28AF_35E2F_11330:
        CheckExternalEvents(cs2, 0x28AF);
        // 3358:28AF mov SI,DI
        SI = DI;
        // 3358:28B1 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:28B4 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:28B6 jns short 0x28BB
        if (!SignFlag)
        {
            goto label_3358_28BB_35E3B_11338;
        }
    label_3358_28B8_35E38_11334:
        CheckExternalEvents(cs2, 0x28B8);
        // 3358:28B8 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:28B9 dec SI
        SI = Alu16.Dec(SI);
        // 3358:28BA dec DI
        DI = Alu16.Dec(DI);
    label_3358_28BB_35E3B_11338:
        CheckExternalEvents(cs2, 0x28BB);
        // 3358:28BB inc SI
        SI = Alu16.Inc(SI);
        // 3358:28BC inc DI
        DI = Alu16.Inc(DI);
        // 3358:28BD mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:28C0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:28C2 jns short 0x28C7
        if (!SignFlag)
        {
            goto label_3358_28C7_35E47_11347;
        }
    label_3358_28C4_35E44_11343:
        CheckExternalEvents(cs2, 0x28C4);
        // 3358:28C4 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:28C5 dec SI
        SI = Alu16.Dec(SI);
        // 3358:28C6 dec DI
        DI = Alu16.Dec(DI);
    label_3358_28C7_35E47_11347:
        CheckExternalEvents(cs2, 0x28C7);
        // 3358:28C7 inc SI
        SI = Alu16.Inc(SI);
        // 3358:28C8 inc DI
        DI = Alu16.Inc(DI);
        // 3358:28C9 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:28CC or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:28CE jns short 0x28D3
        if (!SignFlag)
        {
            goto label_3358_28D3_35E53_11356;
        }
    label_3358_28D0_35E50_11352:
        CheckExternalEvents(cs2, 0x28D0);
        // 3358:28D0 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:28D1 dec SI
        SI = Alu16.Dec(SI);
        // 3358:28D2 dec DI
        DI = Alu16.Dec(DI);
    label_3358_28D3_35E53_11356:
        CheckExternalEvents(cs2, 0x28D3);
        // 3358:28D3 inc SI
        SI = Alu16.Inc(SI);
        // 3358:28D4 inc DI
        DI = Alu16.Inc(DI);
        // 3358:28D5 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:28D8 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:28DA jns short 0x28DF
        if (!SignFlag)
        {
            goto label_3358_28DF_35E5F_11365;
        }
    label_3358_28DC_35E5C_11361:
        CheckExternalEvents(cs2, 0x28DC);
        // 3358:28DC movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:28DD dec SI
        SI = Alu16.Dec(SI);
        // 3358:28DE dec DI
        DI = Alu16.Dec(DI);
    label_3358_28DF_35E5F_11365:
        CheckExternalEvents(cs2, 0x28DF);
        // 3358:28DF inc SI
        SI = Alu16.Inc(SI);
        // 3358:28E0 inc DI
        DI = Alu16.Inc(DI);
        // 3358:28E1 add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:28E5 loop 0x28AF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_28AF_35E2F_11330;
        }
    label_3358_28E7_35E67_11370:
        CheckExternalEvents(cs2, 0x28E7);
        // 3358:28E7 pop DI
        DI = Stack.Pop16();
        // 3358:28E8 pop SI
        SI = Stack.Pop16();
        // 3358:28E9 pop CX
        CX = Stack.Pop16();
        // 3358:28EA pop BX
        BX = Stack.Pop16();
        // 3358:28EB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_28EC_35E6C(int loadOffset)
    {
    label_3358_28EC_35E6C_11097:
        CheckExternalEvents(cs2, 0x28EC);
        // 3358:28EC sub SP,0x0014
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 3358:28EF mov BP,SP
        BP = SP;
        // 3358:28F1 mov byte ptr CS:[0x29D3],0
        UInt8[CS, (ushort)0x29D3] = (byte)0x00;
        // 3358:28F7 push DX
        Stack.Push16(DX);
        // 3358:28F8 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:28FA mov DX,AX
        DX = AX;
        // 3358:28FC mov AH,CL
        AH = CL;
        // 3358:28FE mov DL,CH
        DL = CH;
        // 3358:2900 push AX
        Stack.Push16(AX);
        // 3358:2901 push DX
        Stack.Push16(DX);
        // 3358:2902 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 3358:2904 adc DX,DX
        DX = Alu16.Adc(DX, DX);
        // 3358:2906 add AH,2
        AH = Alu8.Add(AH, (byte)0x02);
        // 3358:2909 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 3358:290C mov word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = AX;
        // 3358:290F mov word ptr SS:[BP+2],DX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = DX;
        // 3358:2912 sub AH,4
        AH = Alu8.Sub(AH, (byte)0x04);
        // 3358:2915 sbb DX,0
        DX = Alu16.Sbb(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 3358:2918 mov word ptr SS:[BP+4],AX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = AX;
        // 3358:291B mov word ptr SS:[BP+6],DX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = DX;
        // 3358:291E pop DX
        DX = Stack.Pop16();
        // 3358:291F pop AX
        AX = Stack.Pop16();
        // 3358:2920 div SI
        ushort divisor_3358_2920_35EA0 = SI;
        uint dividend_3358_2920_35EA0 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_3358_2920_35EA0 = Alu16.Div(unchecked((uint)dividend_3358_2920_35EA0), unchecked((ushort)divisor_3358_2920_35EA0));
        AX = unchecked((ushort)quotient_3358_2920_35EA0);
        DX = unchecked((ushort)(dividend_3358_2920_35EA0 % unchecked((uint)divisor_3358_2920_35EA0)));
        // 3358:2922 mul AX
        uint result_3358_2922_35EA2 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)AX)));
        DX = unchecked((ushort)(result_3358_2922_35EA2 >> 16));
        AX = unchecked((ushort)result_3358_2922_35EA2);
        // 3358:2924 mov AL,AH
        AL = AH;
        // 3358:2926 mov AH,DL
        AH = DL;
        // 3358:2928 mov DL,DH
        DL = DH;
        // 3358:292A xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 3358:292C mov word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = AX;
        // 3358:292F mov word ptr SS:[BP+0x0A],DX
        UInt16[SS, (ushort)(BP + (sbyte)10)] = DX;
        // 3358:2932 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 3358:2934 adc DX,DX
        DX = Alu16.Adc(DX, DX);
        // 3358:2936 mov word ptr SS:[BP+0x0C],AX
        UInt16[SS, (ushort)(BP + (sbyte)12)] = AX;
        // 3358:2939 mov word ptr SS:[BP+0x0E],DX
        UInt16[SS, (ushort)(BP + (sbyte)14)] = DX;
        // 3358:293C pop DX
        DX = Stack.Pop16();
        // 3358:293D mov DI,DX
        DI = DX;
        // 3358:293F add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:2941 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 3358:2943 mov SI,BX
        SI = BX;
        // 3358:2945 jmp short 0x295E
        goto label_3358_295E_35EDE_11138;
    label_3358_2947_35EC7_11380:
        CheckExternalEvents(cs2, 0x2947);
        // 3358:2947 sub word ptr SS:[BP+4],0x0200
        UInt16[SS, (ushort)(BP + (sbyte)4)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)4)], (ushort)0x0200);
        // 3358:294C sbb word ptr SS:[BP+6],0
        UInt16[SS, (ushort)(BP + (sbyte)6)] = Alu16.Sbb(UInt16[SS, (ushort)(BP + (sbyte)6)], unchecked((ushort)unchecked((short)(sbyte)0)));
    label_3358_2950_35ED0_11383:
        CheckExternalEvents(cs2, 0x2950);
        // 3358:2950 mov AX,word ptr SS:[BP+0x0C]
        AX = UInt16[SS, (ushort)(BP + (sbyte)12)];
        // 3358:2953 add word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)8)], AX);
        // 3358:2956 mov AX,word ptr SS:[BP+0x0E]
        AX = UInt16[SS, (ushort)(BP + (sbyte)14)];
        // 3358:2959 adc word ptr SS:[BP+0x0A],AX
        UInt16[SS, (ushort)(BP + (sbyte)10)] = Alu16.Adc(UInt16[SS, (ushort)(BP + (sbyte)10)], AX);
        // 3358:295C inc BX
        BX = Alu16.Inc(BX);
        // 3358:295D dec SI
        SI = Alu16.Dec(SI);
    label_3358_295E_35EDE_11138:
        CheckExternalEvents(cs2, 0x295E);
        // 3358:295E call near 0x29D4
        NearCall(cs2, 0x2961, unknown_3358_29D4_35F54);
    label_3358_2961_35EE1_11202:
        CheckExternalEvents(cs2, 0x2961);
        // 3358:2961 mov AX,word ptr SS:[BP+8]
        AX = UInt16[SS, (ushort)(BP + (sbyte)8)];
        // 3358:2964 sub word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], AX);
        // 3358:2967 mov AX,word ptr SS:[BP+0x0A]
        AX = UInt16[SS, (ushort)(BP + (sbyte)10)];
        // 3358:296A sbb word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Sbb(UInt16[SS, (ushort)(BP + (sbyte)2)], AX);
        // 3358:296D jae short 0x2950
        if (!CarryFlag)
        {
            goto label_3358_2950_35ED0_11383;
        }
    label_3358_296F_35EEF_11208:
        CheckExternalEvents(cs2, 0x296F);
        // 3358:296F inc DX
        DX = Alu16.Inc(DX);
        // 3358:2970 dec DI
        DI = Alu16.Dec(DI);
        // 3358:2971 mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:2974 add word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)0)], AX);
        // 3358:2977 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:297A adc word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Adc(UInt16[SS, (ushort)(BP + (sbyte)2)], AX);
        // 3358:297D jb short 0x2947
        if (CarryFlag)
        {
            goto label_3358_2947_35EC7_11380;
        }
    label_3358_297F_35EFF_11216:
        CheckExternalEvents(cs2, 0x297F);
        // 3358:297F sub word ptr SS:[BP+4],0x0200
        UInt16[SS, (ushort)(BP + (sbyte)4)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)4)], (ushort)0x0200);
        // 3358:2984 sbb word ptr SS:[BP+6],0
        UInt16[SS, (ushort)(BP + (sbyte)6)] = Alu16.Sbb(UInt16[SS, (ushort)(BP + (sbyte)6)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 3358:2988 mov AX,word ptr SS:[BP+0x0C]
        AX = UInt16[SS, (ushort)(BP + (sbyte)12)];
        // 3358:298B add word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)8)], AX);
        // 3358:298E mov AX,word ptr SS:[BP+0x0E]
        AX = UInt16[SS, (ushort)(BP + (sbyte)14)];
        // 3358:2991 adc word ptr SS:[BP+0x0A],AX
        UInt16[SS, (ushort)(BP + (sbyte)10)] = Alu16.Adc(UInt16[SS, (ushort)(BP + (sbyte)10)], AX);
    label_3358_2994_35F14_11223:
        CheckExternalEvents(cs2, 0x2994);
        // 3358:2994 call near 0x29D4
        NearCall(cs2, 0x2997, unknown_3358_29D4_35F54);
    label_3358_2997_35F17_11232:
        CheckExternalEvents(cs2, 0x2997);
        // 3358:2997 inc DX
        DX = Alu16.Inc(DX);
        // 3358:2998 dec DI
        DI = Alu16.Dec(DI);
        // 3358:2999 mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:299C add word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)0)], AX);
        // 3358:299F mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:29A2 adc word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Adc(UInt16[SS, (ushort)(BP + (sbyte)2)], AX);
        // 3358:29A5 jae short 0x29C1
        if (!CarryFlag)
        {
            goto label_3358_29C1_35F41_11240;
        }
    label_3358_29A7_35F27_11257:
        CheckExternalEvents(cs2, 0x29A7);
        // 3358:29A7 inc BX
        BX = Alu16.Inc(BX);
        // 3358:29A8 dec SI
        SI = Alu16.Dec(SI);
        // 3358:29A9 mov AX,word ptr SS:[BP+8]
        AX = UInt16[SS, (ushort)(BP + (sbyte)8)];
        // 3358:29AC sub word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], AX);
        // 3358:29AF mov AX,word ptr SS:[BP+0x0A]
        AX = UInt16[SS, (ushort)(BP + (sbyte)10)];
        // 3358:29B2 sbb word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Sbb(UInt16[SS, (ushort)(BP + (sbyte)2)], AX);
        // 3358:29B5 mov AX,word ptr SS:[BP+0x0C]
        AX = UInt16[SS, (ushort)(BP + (sbyte)12)];
        // 3358:29B8 add word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = Alu16.Add(UInt16[SS, (ushort)(BP + (sbyte)8)], AX);
        // 3358:29BB mov AX,word ptr SS:[BP+0x0E]
        AX = UInt16[SS, (ushort)(BP + (sbyte)14)];
        // 3358:29BE adc word ptr SS:[BP+0x0A],AX
        UInt16[SS, (ushort)(BP + (sbyte)10)] = Alu16.Adc(UInt16[SS, (ushort)(BP + (sbyte)10)], AX);
    label_3358_29C1_35F41_11240:
        CheckExternalEvents(cs2, 0x29C1);
        // 3358:29C1 sub word ptr SS:[BP+4],0x0200
        UInt16[SS, (ushort)(BP + (sbyte)4)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)4)], (ushort)0x0200);
        // 3358:29C6 sbb word ptr SS:[BP+6],0
        UInt16[SS, (ushort)(BP + (sbyte)6)] = Alu16.Sbb(UInt16[SS, (ushort)(BP + (sbyte)6)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 3358:29CA jns short 0x2994
        if (!SignFlag)
        {
            goto label_3358_2994_35F14_11223;
        }
    label_3358_29CC_35F4C_11269:
        CheckExternalEvents(cs2, 0x29CC);
        // 3358:29CC call near 0x29D4
        NearCall(cs2, 0x29CF, unknown_3358_29D4_35F54);
    label_3358_29CF_35F4F_11271:
        CheckExternalEvents(cs2, 0x29CF);
        // 3358:29CF add SP,0x0014
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 3358:29D2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_29D4_35F54(int loadOffset)
    {
    label_3358_29D4_35F54_11140:
        CheckExternalEvents(cs2, 0x29D4);
        // 3358:29D4 inc byte ptr CS:[0x29D3]
        UInt8[CS, (ushort)0x29D3] = Alu8.Inc(UInt8[CS, (ushort)0x29D3]);
        // 3358:29D9 mov AL,byte ptr CS:[0x29D3]
        AL = UInt8[CS, (ushort)0x29D3];
        // 3358:29DD and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 3358:29DF je short 0x29F5
        if (ZeroFlag)
        {
            goto label_3358_29F5_35F75_11253;
        }
    label_3358_29E1_35F61_11145:
        CheckExternalEvents(cs2, 0x29E1);
        // 3358:29E1 cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 3358:29E3 jb short 0x29FB
        if (CarryFlag)
        {
            goto label_3358_29FB_35F7B_11148;
        }
    label_3358_29E5_35F65_11224:
        CheckExternalEvents(cs2, 0x29E5);
        // 3358:29E5 je short 0x2A05
        if (ZeroFlag)
        {
            goto label_3358_2A05_35F85_11226;
        }
    label_3358_29E7_35F67_11245:
        CheckExternalEvents(cs2, 0x29E7);
        // 3358:29E7 xchg DX,DI
        ushort temp_3358_29E7_35F67 = DX;
        DX = DI;
        DI = unchecked((ushort)temp_3358_29E7_35F67);
        // 3358:29E9 xchg BX,SI
        ushort temp_3358_29E9_35F69 = BX;
        BX = SI;
        SI = unchecked((ushort)temp_3358_29E9_35F69);
        // 3358:29EB call near word ptr CS:[0x27E4]
        switch ((ushort)(UInt16[CS, (ushort)0x27E4]))
        {
            case 0x2823:
                NearCall(cs2, 0x29F0, unknown_3358_2823_35DA3);
                break;
            case 0x2887:
                NearCall(cs2, 0x29F0, unknown_3358_2887_35E07);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x27E4])):X4} at 3358:29EB");
        }
    label_3358_29F0_35F70_11249:
        CheckExternalEvents(cs2, 0x29F0);
        // 3358:29F0 xchg BX,SI
        ushort temp_3358_29F0_35F70 = BX;
        BX = SI;
        SI = unchecked((ushort)temp_3358_29F0_35F70);
        // 3358:29F2 xchg DX,DI
        ushort temp_3358_29F2_35F72 = DX;
        DX = DI;
        DI = unchecked((ushort)temp_3358_29F2_35F72);
        // 3358:29F4 ret near
        return NearRet((ushort)0x0000);
    label_3358_29F5_35F75_11253:
        CheckExternalEvents(cs2, 0x29F5);
        // 3358:29F5 call near word ptr CS:[0x27E4]
        switch ((ushort)(UInt16[CS, (ushort)0x27E4]))
        {
            case 0x2823:
                NearCall(cs2, 0x29FA, unknown_3358_2823_35DA3);
                break;
            case 0x2887:
                NearCall(cs2, 0x29FA, unknown_3358_2887_35E07);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x27E4])):X4} at 3358:29F5");
        }
    label_3358_29FA_35F7A_11255:
        CheckExternalEvents(cs2, 0x29FA);
        // 3358:29FA ret near
        return NearRet((ushort)0x0000);
    label_3358_29FB_35F7B_11148:
        CheckExternalEvents(cs2, 0x29FB);
        // 3358:29FB xchg DX,DI
        ushort temp_3358_29FB_35F7B = DX;
        DX = DI;
        DI = unchecked((ushort)temp_3358_29FB_35F7B);
        // 3358:29FD call near word ptr CS:[0x27E4]
        switch ((ushort)(UInt16[CS, (ushort)0x27E4]))
        {
            case 0x2823:
                NearCall(cs2, 0x2A02, unknown_3358_2823_35DA3);
                break;
            case 0x2887:
                NearCall(cs2, 0x2A02, unknown_3358_2887_35E07);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x27E4])):X4} at 3358:29FD");
        }
    label_3358_2A02_35F82_11199:
        CheckExternalEvents(cs2, 0x2A02);
        // 3358:2A02 xchg DX,DI
        ushort temp_3358_2A02_35F82 = DX;
        DX = DI;
        DI = unchecked((ushort)temp_3358_2A02_35F82);
        // 3358:2A04 ret near
        return NearRet((ushort)0x0000);
    label_3358_2A05_35F85_11226:
        CheckExternalEvents(cs2, 0x2A05);
        // 3358:2A05 xchg BX,SI
        ushort temp_3358_2A05_35F85 = BX;
        BX = SI;
        SI = unchecked((ushort)temp_3358_2A05_35F85);
        // 3358:2A07 call near word ptr CS:[0x27E4]
        switch ((ushort)(UInt16[CS, (ushort)0x27E4]))
        {
            case 0x2823:
                NearCall(cs2, 0x2A0C, unknown_3358_2823_35DA3);
                break;
            case 0x2887:
                NearCall(cs2, 0x2A0C, unknown_3358_2887_35E07);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)0x27E4])):X4} at 3358:2A07");
        }
    label_3358_2A0C_35F8C_11229:
        CheckExternalEvents(cs2, 0x2A0C);
        // 3358:2A0C xchg BX,SI
        ushort temp_3358_2A0C_35F8C = BX;
        BX = SI;
        SI = unchecked((ushort)temp_3358_2A0C_35F8C);
        // 3358:2A0E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2AB0_36030(int loadOffset)
    {
    label_3358_2AB0_36030_19734:
        CheckExternalEvents(cs2, 0x2AB0);
        // 3358:2AB0 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2AB3 mov BX,DX
        BX = DX;
    label_3358_2AB5_36035_19737:
        CheckExternalEvents(cs2, 0x2AB5);
        // 3358:2AB5 mov CX,4
        CX = (ushort)0x0004;
    label_3358_2AB8_36038_19738:
        CheckExternalEvents(cs2, 0x2AB8);
        // 3358:2AB8 mov SI,DI
        SI = DI;
        // 3358:2ABA movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2ABB movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2ABC movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2ABD movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2ABE add DI,0x0138
        DI = Alu16.Add(DI, (ushort)0x0138);
        // 3358:2AC2 loop 0x2AB8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2AB8_36038_19738;
        }
    label_3358_2AC4_36044_19746:
        CheckExternalEvents(cs2, 0x2AC4);
        // 3358:2AC4 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2AC6 dec BX
        BX = Alu16.Dec(BX);
        // 3358:2AC7 jne short 0x2AB5
        if (!ZeroFlag)
        {
            goto label_3358_2AB5_36035_19737;
        }
    label_3358_2AC9_36049_19750:
        CheckExternalEvents(cs2, 0x2AC9);
        // 3358:2AC9 pop AX
        AX = Stack.Pop16();
    label_3358_2ACA_3604A_19752:
        CheckExternalEvents(cs2, 0x2ACA);
        // 3358:2ACA cmp AX,word ptr SS:[BP]
        Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2ACD je short 0x2ACA
        if (ZeroFlag)
        {
            goto label_3358_2ACA_3604A_19752;
        }
    label_3358_2ACF_3604F_19754:
        CheckExternalEvents(cs2, 0x2ACF);
        // 3358:2ACF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2B56_360D6(int loadOffset)
    {
    label_3358_2B56_360D6_17022:
        CheckExternalEvents(cs2, 0x2B56);
        // 3358:2B56 push DX
        Stack.Push16(DX);
        // 3358:2B57 mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 3358:2B5A neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 3358:2B5C add DX,0x0140
        DX = Alu16.Add(DX, (ushort)0x0140);
        // 3358:2B60 inc DX
        DX = Alu16.Inc(DX);
        // 3358:2B61 mul DX
        uint result_3358_2B61_360E1 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_3358_2B61_360E1 >> 16));
        AX = unchecked((ushort)result_3358_2B61_360E1);
        // 3358:2B63 mov SI,AX
        SI = AX;
        // 3358:2B65 mov AX,0x0098
        AX = (ushort)0x0098;
        // 3358:2B68 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:2B6A pop DX
        DX = Stack.Pop16();
        // 3358:2B6B cmp DX,AX
        Alu16.Sub(DX, AX);
        // 3358:2B6D jae short 0x2B73
        if (!CarryFlag)
        {
            goto label_3358_2B73_360F3_17035;
        }
    label_3358_2B6F_360EF_17116:
        CheckExternalEvents(cs2, 0x2B6F);
        // 3358:2B6F add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:2B71 sub SI,DX
        SI = Alu16.Sub(SI, DX);
    label_3358_2B73_360F3_17035:
        CheckExternalEvents(cs2, 0x2B73);
        // 3358:2B73 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:2B75 cmp AX,DX
        Alu16.Sub(AX, DX);
        // 3358:2B77 jb short 0x2B7B
        if (CarryFlag)
        {
            goto label_3358_2B7B_360FB_17039;
        }
    label_3358_2B79_360F9_17102:
        CheckExternalEvents(cs2, 0x2B79);
        // 3358:2B79 mov AX,DX
        AX = DX;
    label_3358_2B7B_360FB_17039:
        CheckExternalEvents(cs2, 0x2B7B);
        // 3358:2B7B mov DS,word ptr CS:[0x2535]
        DS = UInt16[CS, (ushort)0x2535];
        // 3358:2B80 sub DI,AX
        DI = Alu16.Sub(DI, AX);
    label_3358_2B82_36102_17042:
        CheckExternalEvents(cs2, 0x2B82);
        // 3358:2B82 mov CX,AX
        CX = AX;
        // 3358:2B84 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2B86 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2B88 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:2B8A sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2B8C add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:2B90 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2B94 dec AX
        AX = Alu16.Dec(AX);
        // 3358:2B95 mov CX,AX
        CX = AX;
        // 3358:2B97 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2B99 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2B9B movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2B9C sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:2B9E sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2BA0 add SI,0x00C8
        SI = Alu16.Add(SI, (ushort)0x00C8);
        // 3358:2BA4 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2BA8 dec AX
        AX = Alu16.Dec(AX);
        // 3358:2BA9 jg short 0x2B82
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_2B82_36102_17042;
        }
    label_3358_2BAB_3612B_17061:
        CheckExternalEvents(cs2, 0x2BAB);
        // 3358:2BAB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2BAC_3612C(int loadOffset)
    {
    label_3358_2BAC_3612C_16991:
        CheckExternalEvents(cs2, 0x2BAC);
        // 3358:2BAC mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:2BB1 mov AX,0x0098
        AX = (ushort)0x0098;
        // 3358:2BB4 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:2BB6 mov BX,DX
        BX = DX;
        // 3358:2BB8 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:2BBA jns short 0x2BBE
        if (!SignFlag)
        {
            goto label_3358_2BBE_3613E_16998;
        }
    label_3358_2BBC_3613C_17104:
        CheckExternalEvents(cs2, 0x2BBC);
        // 3358:2BBC add AX,BX
        AX = Alu16.Add(AX, BX);
    label_3358_2BBE_3613E_16998:
        CheckExternalEvents(cs2, 0x2BBE);
        // 3358:2BBE cmp DX,0x0138
        Alu16.Sub(DX, (ushort)0x0138);
        // 3358:2BC2 jbe short 0x2BDD
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_2BDD_3615D_17071;
        }
    label_3358_2BC4_36144_17001:
        CheckExternalEvents(cs2, 0x2BC4);
        // 3358:2BC4 xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_3358_2BC6_36146_17003:
        CheckExternalEvents(cs2, 0x2BC6);
        // 3358:2BC6 mov CX,DX
        CX = DX;
        // 3358:2BC8 mov SI,DI
        SI = DI;
        // 3358:2BCA rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2BCC sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 3358:2BCE add DI,0x013F
        DI = Alu16.Add(DI, (ushort)0x013F);
        // 3358:2BD2 inc DX
        DX = Alu16.Inc(DX);
        // 3358:2BD3 cmp DX,8
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2BD6 jb short 0x2BC6
        if (CarryFlag)
        {
            goto label_3358_2BC6_36146_17003;
        }
    label_3358_2BD8_36158_17012:
        CheckExternalEvents(cs2, 0x2BD8);
        // 3358:2BD8 sub AX,8
        AX = Alu16.Sub(AX, (ushort)0x0008);
        // 3358:2BDB jbe short 0x2C01
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_2C01_36181_17015;
        }
    label_3358_2BDD_3615D_17071:
        CheckExternalEvents(cs2, 0x2BDD);
        // 3358:2BDD mov SI,DI
        SI = DI;
        // 3358:2BDF mov CX,4
        CX = (ushort)0x0004;
        // 3358:2BE2 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2BE4 add DI,0x0137
        DI = Alu16.Add(DI, (ushort)0x0137);
        // 3358:2BE8 dec AX
        AX = Alu16.Dec(AX);
        // 3358:2BE9 jne short 0x2BDD
        if (!ZeroFlag)
        {
            goto label_3358_2BDD_3615D_17071;
        }
    label_3358_2BEB_3616B_17078:
        CheckExternalEvents(cs2, 0x2BEB);
        // 3358:2BEB or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:2BED jge short 0x2C01
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_2C01_36181_17015;
        }
    label_3358_2BEF_3616F_17106:
        CheckExternalEvents(cs2, 0x2BEF);
        // 3358:2BEF mov DX,8
        DX = (ushort)0x0008;
    label_3358_2BF2_36172_17108:
        CheckExternalEvents(cs2, 0x2BF2);
        // 3358:2BF2 mov CX,DX
        CX = DX;
        // 3358:2BF4 mov SI,DI
        SI = DI;
        // 3358:2BF6 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2BF8 sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 3358:2BFA add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2BFE dec DX
        DX = Alu16.Dec(DX);
        // 3358:2BFF jne short 0x2BF2
        if (!ZeroFlag)
        {
            goto label_3358_2BF2_36172_17108;
        }
    label_3358_2C01_36181_17015:
        CheckExternalEvents(cs2, 0x2C01);
        // 3358:2C01 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2C02_36182(int loadOffset)
    {
    label_3358_2C02_36182_17307:
        CheckExternalEvents(cs2, 0x2C02);
        // 3358:2C02 mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:2C07 mov AX,0x0098
        AX = (ushort)0x0098;
        // 3358:2C0A add AX,8
        AX = Alu16.Add(AX, (ushort)0x0008);
        // 3358:2C0D cmp DI,AX
        Alu16.Sub(DI, AX);
        // 3358:2C0F jb short 0x2C51
        if (CarryFlag)
        {
            goto label_3358_2C51_361D1_17313;
        }
    label_3358_2C11_36191_17329:
        CheckExternalEvents(cs2, 0x2C11);
        // 3358:2C11 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:2C13 sub AX,8
        AX = Alu16.Sub(AX, (ushort)0x0008);
        // 3358:2C16 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:2C18 jle short 0x2C3E
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_2C3E_361BE_17334;
        }
    label_3358_2C1A_3619A_17345:
        CheckExternalEvents(cs2, 0x2C1A);
        // 3358:2C1A add AX,8
        AX = Alu16.Add(AX, (ushort)0x0008);
        // 3358:2C1D sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:2C1F sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2C21 sub DI,0x0A00
        DI = Alu16.Sub(DI, (ushort)0x0A00);
        // 3358:2C25 mov DX,8
        DX = (ushort)0x0008;
    label_3358_2C28_361A8_17351:
        CheckExternalEvents(cs2, 0x2C28);
        // 3358:2C28 mov CX,AX
        CX = AX;
        // 3358:2C2A shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2C2C mov SI,DI
        SI = DI;
        // 3358:2C2E rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2C30 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2C32 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:2C36 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2C37 jne short 0x2C28
        if (!ZeroFlag)
        {
            goto label_3358_2C28_361A8_17351;
        }
    label_3358_2C39_361B9_17360:
        CheckExternalEvents(cs2, 0x2C39);
        // 3358:2C39 sub AX,8
        AX = Alu16.Sub(AX, (ushort)0x0008);
        // 3358:2C3C jmp short 0x2C43
        goto label_3358_2C43_361C3_17337;
    label_3358_2C3E_361BE_17334:
        CheckExternalEvents(cs2, 0x2C3E);
        // 3358:2C3E sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:2C40 sub DI,8
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
    label_3358_2C43_361C3_17337:
        CheckExternalEvents(cs2, 0x2C43);
        // 3358:2C43 mov SI,DI
        SI = DI;
        // 3358:2C45 mov CX,4
        CX = (ushort)0x0004;
        // 3358:2C48 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2C4A add DI,0x0138
        DI = Alu16.Add(DI, (ushort)0x0138);
        // 3358:2C4E dec AX
        AX = Alu16.Dec(AX);
        // 3358:2C4F jne short 0x2C43
        if (!ZeroFlag)
        {
            goto label_3358_2C43_361C3_17337;
        }
    label_3358_2C51_361D1_17313:
        CheckExternalEvents(cs2, 0x2C51);
        // 3358:2C51 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2C52_361D2(int loadOffset)
    {
    label_3358_2C52_361D2_16903:
        CheckExternalEvents(cs2, 0x2C52);
        // 3358:2C52 push ES
        Stack.Push16(ES);
        // 3358:2C53 mov ES,word ptr CS:[0x2535]
        ES = UInt16[CS, (ushort)0x2535];
        // 3358:2C58 mov SI,0xF9FF
        SI = (ushort)0xF9FF;
        // 3358:2C5B xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 3358:2C5D mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:2C60 mov BX,0x6062
        BX = (ushort)0x6062;
    label_3358_2C63_361E3_16910:
        CheckExternalEvents(cs2, 0x2C63);
        // 3358:2C63 push SI
        Stack.Push16(SI);
        // 3358:2C64 mov CX,0x0032
        CX = (ushort)0x0032;
    label_3358_2C67_361E7_16912:
        CheckExternalEvents(cs2, 0x2C67);
        // 3358:2C67 mov AH,byte ptr DS:[SI-320]
        AH = UInt8[DS, (ushort)(SI + (short)-320)];
        // 3358:2C6B cmp AH,BH
        Alu8.Sub(AH, BH);
        // 3358:2C6D jb short 0x2C76
        if (CarryFlag)
        {
            goto label_3358_2C76_361F6_16918;
        }
    label_3358_2C6F_361EF_16915:
        CheckExternalEvents(cs2, 0x2C6F);
        // 3358:2C6F cmp AH,BL
        Alu8.Sub(AH, BL);
        // 3358:2C71 jae short 0x2C76
        if (!CarryFlag)
        {
            goto label_3358_2C76_361F6_16918;
        }
    label_3358_2C73_361F3_40148:
        CheckExternalEvents(cs2, 0x2C73);
        // 3358:2C73 add AH,2
        AH = Alu8.Add(AH, (byte)0x02);
    label_3358_2C76_361F6_16918:
        CheckExternalEvents(cs2, 0x2C76);
        // 3358:2C76 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 3358:2C78 cmp AL,BH
        Alu8.Sub(AL, BH);
        // 3358:2C7A jb short 0x2C82
        if (CarryFlag)
        {
            goto label_3358_2C82_36202_16925;
        }
    label_3358_2C7C_361FC_16922:
        CheckExternalEvents(cs2, 0x2C7C);
        // 3358:2C7C cmp AL,BL
        Alu8.Sub(AL, BL);
        // 3358:2C7E jae short 0x2C82
        if (!CarryFlag)
        {
            goto label_3358_2C82_36202_16925;
        }
    label_3358_2C80_36200_40157:
        CheckExternalEvents(cs2, 0x2C80);
        // 3358:2C80 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
    label_3358_2C82_36202_16925:
        CheckExternalEvents(cs2, 0x2C82);
        // 3358:2C82 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2C83 mov AH,byte ptr DS:[SI-960]
        AH = UInt8[DS, (ushort)(SI + (short)-960)];
        // 3358:2C87 cmp AH,BH
        Alu8.Sub(AH, BH);
        // 3358:2C89 jb short 0x2C92
        if (CarryFlag)
        {
            goto label_3358_2C92_36212_16933;
        }
    label_3358_2C8B_3620B_16930:
        CheckExternalEvents(cs2, 0x2C8B);
        // 3358:2C8B cmp AH,BL
        Alu8.Sub(AH, BL);
        // 3358:2C8D jae short 0x2C92
        if (!CarryFlag)
        {
            goto label_3358_2C92_36212_16933;
        }
    label_3358_2C8F_3620F_40151:
        CheckExternalEvents(cs2, 0x2C8F);
        // 3358:2C8F add AH,2
        AH = Alu8.Add(AH, (byte)0x02);
    label_3358_2C92_36212_16933:
        CheckExternalEvents(cs2, 0x2C92);
        // 3358:2C92 mov AL,byte ptr DS:[SI-640]
        AL = UInt8[DS, (ushort)(SI + (short)-640)];
        // 3358:2C96 cmp AL,BH
        Alu8.Sub(AL, BH);
        // 3358:2C98 jb short 0x2CA0
        if (CarryFlag)
        {
            goto label_3358_2CA0_36220_16940;
        }
    label_3358_2C9A_3621A_16937:
        CheckExternalEvents(cs2, 0x2C9A);
        // 3358:2C9A cmp AL,BL
        Alu8.Sub(AL, BL);
        // 3358:2C9C jae short 0x2CA0
        if (!CarryFlag)
        {
            goto label_3358_2CA0_36220_16940;
        }
    label_3358_2C9E_3621E_40154:
        CheckExternalEvents(cs2, 0x2C9E);
        // 3358:2C9E add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
    label_3358_2CA0_36220_16940:
        CheckExternalEvents(cs2, 0x2CA0);
        // 3358:2CA0 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2CA1 sub SI,0x0500
        SI = Alu16.Sub(SI, (ushort)0x0500);
        // 3358:2CA5 loop 0x2C67
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2C67_361E7_16912;
        }
    label_3358_2CA7_36227_16945:
        CheckExternalEvents(cs2, 0x2CA7);
        // 3358:2CA7 pop SI
        SI = Stack.Pop16();
        // 3358:2CA8 dec SI
        SI = Alu16.Dec(SI);
        // 3358:2CA9 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2CAA jne short 0x2C63
        if (!ZeroFlag)
        {
            goto label_3358_2C63_361E3_16910;
        }
    label_3358_2CAC_3622C_16951:
        CheckExternalEvents(cs2, 0x2CAC);
        // 3358:2CAC push DS
        Stack.Push16(DS);
        // 3358:2CAD push ES
        Stack.Push16(ES);
        // 3358:2CAE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2CAF mov DI,0x62A0
        DI = (ushort)0x62A0;
        // 3358:2CB2 mov DX,0x0044
        DX = (ushort)0x0044;
    label_3358_2CB5_36235_16957:
        CheckExternalEvents(cs2, 0x2CB5);
        // 3358:2CB5 lea SI,DI-10800
        SI = unchecked((ushort)(DI + (short)-10800));
        // 3358:2CB9 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2CBA movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2CBB movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2CBC movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2CBD add DI,0x00C0
        DI = Alu16.Add(DI, (ushort)0x00C0);
        // 3358:2CC1 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2CC2 jne short 0x2CB5
        if (!ZeroFlag)
        {
            goto label_3358_2CB5_36235_16957;
        }
    label_3358_2CC4_36244_16966:
        CheckExternalEvents(cs2, 0x2CC4);
        // 3358:2CC4 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2CC5 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2CC6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2FC1_36541(int loadOffset)
    {
    label_3358_2FC1_36541_32437:
        CheckExternalEvents(cs2, 0x2FC1);
        // 3358:2FC1 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_2FC4_36544_32439:
        CheckExternalEvents(cs2, 0x2FC4);
        // 3358:2FC4 mov SI,0x2FB7
        SI = (ushort)0x2FB7;
    label_3358_2FC7_36547_32440:
        CheckExternalEvents(cs2, 0x2FC7);
        // 3358:2FC7 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:2FC9 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:2FCB js short 0x2FC4
        if (SignFlag)
        {
            goto label_3358_2FC4_36544_32439;
        }
    label_3358_2FCD_3654D_32443:
        CheckExternalEvents(cs2, 0x2FCD);
        // 3358:2FCD push SI
        Stack.Push16(SI);
        // 3358:2FCE mov SI,AX
        SI = AX;
        // 3358:2FD0 call near 0x30C5
        NearCall(cs2, 0x2FD3, unknown_3358_30C5_36645);
    label_3358_2FD3_36553_32479:
        CheckExternalEvents(cs2, 0x2FD3);
        // 3358:2FD3 pop SI
        SI = Stack.Pop16();
        // 3358:2FD4 jb short 0x2FC7
        if (CarryFlag)
        {
            goto label_3358_2FC7_36547_32440;
        }
    label_3358_2FD6_36556_32484:
        CheckExternalEvents(cs2, 0x2FD6);
        // 3358:2FD6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_2FF9_36579(int loadOffset)
    {
    label_3358_2FF9_36579_32518:
        CheckExternalEvents(cs2, 0x2FF9);
        // 3358:2FF9 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_2FFC_3657C_32520:
        CheckExternalEvents(cs2, 0x2FFC);
        // 3358:2FFC mov SI,0x2FD7
        SI = (ushort)0x2FD7;
    label_3358_2FFF_3657F_32521:
        CheckExternalEvents(cs2, 0x2FFF);
        // 3358:2FFF lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3001 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:3003 js short 0x2FFC
        if (SignFlag)
        {
            goto label_3358_2FFC_3657C_32520;
        }
    label_3358_3005_36585_32524:
        CheckExternalEvents(cs2, 0x3005);
        // 3358:3005 push SI
        Stack.Push16(SI);
        // 3358:3006 mov SI,AX
        SI = AX;
        // 3358:3008 call near 0x308C
        NearCall(cs2, 0x300B, unknown_3358_308C_3660C);
    label_3358_300B_3658B_32562:
        CheckExternalEvents(cs2, 0x300B);
        // 3358:300B pop SI
        SI = Stack.Pop16();
        // 3358:300C jb short 0x2FFF
        if (CarryFlag)
        {
            goto label_3358_2FFF_3657F_32521;
        }
    label_3358_300E_3658E_32567:
        CheckExternalEvents(cs2, 0x300E);
        // 3358:300E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_3031_365B1(int loadOffset)
    {
    label_3358_3031_365B1_32645:
        CheckExternalEvents(cs2, 0x3031);
        // 3358:3031 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_3034_365B4_32647:
        CheckExternalEvents(cs2, 0x3034);
        // 3358:3034 mov SI,0x300F
        SI = (ushort)0x300F;
    label_3358_3037_365B7_32648:
        CheckExternalEvents(cs2, 0x3037);
        // 3358:3037 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3039 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:303B js short 0x3034
        if (SignFlag)
        {
            goto label_3358_3034_365B4_32647;
        }
    label_3358_303D_365BD_32651:
        CheckExternalEvents(cs2, 0x303D);
        // 3358:303D push SI
        Stack.Push16(SI);
        // 3358:303E mov SI,AX
        SI = AX;
        // 3358:3040 call near 0x3047
        NearCall(cs2, 0x3043, unknown_3358_3047_365C7);
    label_3358_3043_365C3_32690:
        CheckExternalEvents(cs2, 0x3043);
        // 3358:3043 pop SI
        SI = Stack.Pop16();
        // 3358:3044 jb short 0x3037
        if (CarryFlag)
        {
            goto label_3358_3037_365B7_32648;
        }
    label_3358_3046_365C6_32695:
        CheckExternalEvents(cs2, 0x3046);
        // 3358:3046 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_3047_365C7(int loadOffset)
    {
    label_3358_3047_365C7_32655:
        CheckExternalEvents(cs2, 0x3047);
        // 3358:3047 push CX
        Stack.Push16(CX);
        // 3358:3048 mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:304D add SI,DI
        SI = Alu16.Add(SI, DI);
        // 3358:304F shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:3051 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:3053 shr CX,1
        CX = Alu16.Shr(CX, 1);
    label_3358_3055_365D5_32662:
        CheckExternalEvents(cs2, 0x3055);
        // 3358:3055 push CX
        Stack.Push16(CX);
        // 3358:3056 push SI
        Stack.Push16(SI);
        // 3358:3057 push DI
        Stack.Push16(DI);
        // 3358:3058 mov CX,0x0028
        CX = (ushort)0x0028;
    label_3358_305B_365DB_32666:
        CheckExternalEvents(cs2, 0x305B);
        // 3358:305B lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:305C add SI,7
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 3358:305F mov AH,AL
        AH = AL;
        // 3358:3061 mov DX,8
        DX = (ushort)0x0008;
    label_3358_3064_365E4_32670:
        CheckExternalEvents(cs2, 0x3064);
        // 3358:3064 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3065 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3066 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3067 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3068 add DI,0x0138
        DI = Alu16.Add(DI, (ushort)0x0138);
        // 3358:306C dec DX
        DX = Alu16.Dec(DX);
        // 3358:306D jne short 0x3064
        if (!ZeroFlag)
        {
            goto label_3358_3064_365E4_32670;
        }
    label_3358_306F_365EF_32678:
        CheckExternalEvents(cs2, 0x306F);
        // 3358:306F sub DI,0x09F8
        DI = Alu16.Sub(DI, (ushort)0x09F8);
        // 3358:3073 loop 0x305B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_305B_365DB_32666;
        }
    label_3358_3075_365F5_32682:
        CheckExternalEvents(cs2, 0x3075);
        // 3358:3075 pop DI
        DI = Stack.Pop16();
        // 3358:3076 pop SI
        SI = Stack.Pop16();
        // 3358:3077 pop CX
        CX = Stack.Pop16();
        // 3358:3078 add DI,0x0A00
        DI = Alu16.Add(DI, (ushort)0x0A00);
        // 3358:307C add SI,0x0A00
        SI = Alu16.Add(SI, (ushort)0x0A00);
        // 3358:3080 loop 0x3055
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3055_365D5_32662;
        }
        else
        {
            return unknown_3358_3082_36602(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_3358_308C_3660C(int loadOffset)
    {
    label_3358_308C_3660C_32528:
        CheckExternalEvents(cs2, 0x308C);
        // 3358:308C push CX
        Stack.Push16(CX);
        // 3358:308D shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:308F shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:3091 mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:3096 add SI,DI
        SI = Alu16.Add(SI, DI);
    label_3358_3098_36618_32534:
        CheckExternalEvents(cs2, 0x3098);
        // 3358:3098 push CX
        Stack.Push16(CX);
        // 3358:3099 push SI
        Stack.Push16(SI);
        // 3358:309A push DI
        Stack.Push16(DI);
        // 3358:309B mov CX,0x0050
        CX = (ushort)0x0050;
    label_3358_309E_3661E_32538:
        CheckExternalEvents(cs2, 0x309E);
        // 3358:309E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:309F add SI,3
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:30A2 mov AH,AL
        AH = AL;
        // 3358:30A4 mov DX,4
        DX = (ushort)0x0004;
    label_3358_30A7_36627_32542:
        CheckExternalEvents(cs2, 0x30A7);
        // 3358:30A7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:30A8 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:30A9 add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:30AD dec DX
        DX = Alu16.Dec(DX);
        // 3358:30AE jne short 0x30A7
        if (!ZeroFlag)
        {
            goto label_3358_30A7_36627_32542;
        }
    label_3358_30B0_36630_32548:
        CheckExternalEvents(cs2, 0x30B0);
        // 3358:30B0 sub DI,0x04FC
        DI = Alu16.Sub(DI, (ushort)0x04FC);
        // 3358:30B4 loop 0x309E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_309E_3661E_32538;
        }
    label_3358_30B6_36636_32552:
        CheckExternalEvents(cs2, 0x30B6);
        // 3358:30B6 pop DI
        DI = Stack.Pop16();
        // 3358:30B7 pop SI
        SI = Stack.Pop16();
        // 3358:30B8 pop CX
        CX = Stack.Pop16();
        // 3358:30B9 add SI,0x0500
        SI = Alu16.Add(SI, (ushort)0x0500);
        // 3358:30BD add DI,0x0500
        DI = Alu16.Add(DI, (ushort)0x0500);
        // 3358:30C1 loop 0x3098
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3098_36618_32534;
        }
    label_3358_30C3_36643_32560:
        CheckExternalEvents(cs2, 0x30C3);
        // 3358:30C3 jmp short 0x3082
        return unknown_3358_3082_36602(0x0000);
    }

    public virtual Action unknown_3358_30C5_36645(int loadOffset)
    {
    label_3358_30C5_36645_32447:
        CheckExternalEvents(cs2, 0x30C5);
        // 3358:30C5 push CX
        Stack.Push16(CX);
        // 3358:30C6 mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:30CB add SI,DI
        SI = Alu16.Add(SI, DI);
        // 3358:30CD shr CX,1
        CX = Alu16.Shr(CX, 1);
    label_3358_30CF_3664F_32452:
        CheckExternalEvents(cs2, 0x30CF);
        // 3358:30CF push CX
        Stack.Push16(CX);
        // 3358:30D0 push SI
        Stack.Push16(SI);
        // 3358:30D1 push DI
        Stack.Push16(DI);
        // 3358:30D2 mov CX,0x00A0
        CX = (ushort)0x00A0;
    label_3358_30D5_36655_32456:
        CheckExternalEvents(cs2, 0x30D5);
        // 3358:30D5 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:30D6 inc SI
        SI = Alu16.Inc(SI);
        // 3358:30D7 mov AH,AL
        AH = AL;
        // 3358:30D9 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:30DE stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:30DF loop 0x30D5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_30D5_36655_32456;
        }
    label_3358_30E1_36661_32463:
        CheckExternalEvents(cs2, 0x30E1);
        // 3358:30E1 pop DI
        DI = Stack.Pop16();
        // 3358:30E2 pop SI
        SI = Stack.Pop16();
        // 3358:30E3 pop CX
        CX = Stack.Pop16();
        // 3358:30E4 add SI,0x0280
        SI = Alu16.Add(SI, (ushort)0x0280);
        // 3358:30E8 add DI,0x0280
        DI = Alu16.Add(DI, (ushort)0x0280);
        // 3358:30EC loop 0x30CF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_30CF_3664F_32452;
        }
    label_3358_30EE_3666E_32471:
        CheckExternalEvents(cs2, 0x30EE);
        // 3358:30EE jmp short 0x3082
        return unknown_3358_3082_36602(0x0000);
    }

    public virtual Action unknown_3358_316D_366ED(int loadOffset)
    {
        goto label_3358_316D_366ED_20014;

    label_3358_311A_3669A_20087:
        CheckExternalEvents(cs2, 0x311A);
        // 3358:311A mov DI,word ptr CS:[0x3118]
        DI = UInt16[CS, (ushort)0x3118];
        // 3358:311F xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:3121 mov CX,0x12C0
        CX = (ushort)0x12C0;
        // 3358:3124 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:3126 mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:312B push CS
        Stack.Push16(CS);
        // 3358:312C call near 0x0B0C
        NearCall(cs2, 0x312F, unknown_3358_0B0C_3408C);
    label_3358_312F_366AF_20095:
        CheckExternalEvents(cs2, 0x312F);
        // 3358:312F ret near
        return NearRet((ushort)0x0000);
    label_3358_316D_366ED_20014:
        CheckExternalEvents(cs2, 0x316D);
        // 3358:316D cmp CL,9
        Alu8.Sub(CL, (byte)0x09);
        // 3358:3170 je short 0x311A
        if (ZeroFlag)
        {
            goto label_3358_311A_3669A_20087;
        }
    label_3358_3172_366F2_20017:
        CheckExternalEvents(cs2, 0x3172);
        // 3358:3172 mov word ptr CS:[0x3114],AX
        UInt16[CS, (ushort)0x3114] = AX;
        // 3358:3176 mov DI,0x5DC0
        DI = (ushort)0x5DC0;
        // 3358:3179 add DI,word ptr CS:[0x01A3]
        DI = Alu16.Add(DI, UInt16[CS, (ushort)0x01A3]);
        // 3358:317E lea BP,DI+0x0140
        BP = unchecked((ushort)(DI + (short)320));
        // 3358:3182 mov SI,DI
        SI = DI;
        // 3358:3184 mov BX,BP
        BX = BP;
        // 3358:3186 mov DX,0x004C
        DX = (ushort)0x004C;
        // 3358:3189 jmp short 0x3193
        goto label_3358_3193_36713_20026;
    label_3358_318B_3670B_20040:
        CheckExternalEvents(cs2, 0x318B);
        // 3358:318B sub SI,0x0280
        SI = Alu16.Sub(SI, (ushort)0x0280);
        // 3358:318F sub DI,0x0280
        DI = Alu16.Sub(DI, (ushort)0x0280);
    label_3358_3193_36713_20026:
        CheckExternalEvents(cs2, 0x3193);
        // 3358:3193 dec DX
        DX = Alu16.Dec(DX);
        // 3358:3194 js short 0x31C5
        if (SignFlag)
        {
            goto label_3358_31C5_36745_20055;
        }
    label_3358_3196_36716_20029:
        CheckExternalEvents(cs2, 0x3196);
        // 3358:3196 mov CX,0x00A0
        CX = (ushort)0x00A0;
        // 3358:3199 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:319B xchg DI,BP
        ushort temp_3358_319B_3671B = DI;
        DI = BP;
        BP = unchecked((ushort)temp_3358_319B_3671B);
        // 3358:319D xchg SI,BX
        ushort temp_3358_319D_3671D = SI;
        SI = BX;
        BX = unchecked((ushort)temp_3358_319D_3671D);
        // 3358:319F mov CX,0x00A0
        CX = (ushort)0x00A0;
        // 3358:31A2 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:31A4 xchg DI,BP
        ushort temp_3358_31A4_36724 = DI;
        DI = BP;
        BP = unchecked((ushort)temp_3358_31A4_36724);
        // 3358:31A6 xchg SI,BX
        ushort temp_3358_31A6_36726 = SI;
        SI = BX;
        BX = unchecked((ushort)temp_3358_31A6_36726);
        // 3358:31A8 dec AL
        AL = Alu8.Dec(AL);
        // 3358:31AA jne short 0x318B
        if (!ZeroFlag)
        {
            goto label_3358_318B_3670B_20040;
        }
    label_3358_31AC_3672C_20043:
        CheckExternalEvents(cs2, 0x31AC);
        // 3358:31AC mov CX,0x0140
        CX = (ushort)0x0140;
        // 3358:31AF sub DL,AH
        DL = Alu8.Sub(DL, AH);
        // 3358:31B1 jbe short 0x31C1
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_31C1_36741_20085;
        }
    label_3358_31B3_36733_20047:
        CheckExternalEvents(cs2, 0x31B3);
        // 3358:31B3 sub SI,CX
        SI = Alu16.Sub(SI, CX);
        // 3358:31B5 add BX,CX
        BX = Alu16.Add(BX, CX);
        // 3358:31B7 dec AH
        AH = Alu8.Dec(AH);
        // 3358:31B9 jne short 0x31B3
        if (!ZeroFlag)
        {
            goto label_3358_31B3_36733_20047;
        }
    label_3358_31BB_3673B_20052:
        CheckExternalEvents(cs2, 0x31BB);
        // 3358:31BB mov AX,word ptr CS:[0x3114]
        AX = UInt16[CS, (ushort)0x3114];
        // 3358:31BF jmp short 0x318B
        goto label_3358_318B_3670B_20040;
    label_3358_31C1_36741_20085:
        CheckExternalEvents(cs2, 0x31C1);
        // 3358:31C1 sub DI,0x0280
        DI = Alu16.Sub(DI, (ushort)0x0280);
    label_3358_31C5_36745_20055:
        CheckExternalEvents(cs2, 0x31C5);
        // 3358:31C5 mov BX,DI
        BX = DI;
        // 3358:31C7 xchg BX,word ptr CS:[0x3118]
        ushort xchgOffset_3358_31C7_36747 = (ushort)0x3118;
        ushort temp_3358_31C7_36747 = BX;
        BX = UInt16[CS, xchgOffset_3358_31C7_36747];
        UInt16[CS, xchgOffset_3358_31C7_36747] = unchecked((ushort)temp_3358_31C7_36747);
        // 3358:31CC xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_3358_31CE_3674E_20059:
        CheckExternalEvents(cs2, 0x31CE);
        // 3358:31CE cmp BX,DI
        Alu16.Sub(BX, DI);
        // 3358:31D0 jg short 0x31E5
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_31E5_36765_20071;
        }
    label_3358_31D2_36752_20061:
        CheckExternalEvents(cs2, 0x31D2);
        // 3358:31D2 mov CX,0x00A0
        CX = (ushort)0x00A0;
        // 3358:31D5 xchg BP,DI
        ushort temp_3358_31D5_36755 = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_31D5_36755);
        // 3358:31D7 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:31D9 xchg BP,DI
        ushort temp_3358_31D9_36759 = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_31D9_36759);
        // 3358:31DB mov CL,0xA0
        CL = (byte)0xA0;
        // 3358:31DD rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:31DF sub DI,0x0280
        DI = Alu16.Sub(DI, (ushort)0x0280);
        // 3358:31E3 jmp short 0x31CE
        goto label_3358_31CE_3674E_20059;
    label_3358_31E5_36765_20071:
        CheckExternalEvents(cs2, 0x31E5);
        // 3358:31E5 ret near
        return NearRet((ushort)0x0000);
    }
}
