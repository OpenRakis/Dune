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
    public virtual Action queue_vision_message_f00(int loadOffset)
    {
    label_100D_71B2_17282_33665:
        CheckExternalEvents(cs1, 0x71B2);
        // 100D:71B2 mov AH,0x0F
        AH = (byte)0x0F;
        // 100D:71B4 push SI
        Stack.Push16(SI);
        // 100D:71B5 push DI
        Stack.Push16(DI);
        // 100D:71B6 call near 0x29F0
        NearCall(cs1, 0x71B9, queue_vision_message);
    label_100D_71B9_17289_33670:
        CheckExternalEvents(cs1, 0x71B9);
        // 100D:71B9 pop DI
        DI = Stack.Pop16();
        // 100D:71BA pop SI
        SI = Stack.Pop16();
        return unknown_100D_71BB_1728B(0x0000);
    }

    public virtual Action troop_randomize_saboteurs(int loadOffset)
    {
    label_100D_71BC_1728C_33371:
        CheckExternalEvents(cs1, 0x71BC);
        // 100D:71BC cmp byte ptr DS:[0x002A],0x35
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x35);
        // 100D:71C1 jb short 0x71EE
        if (CarryFlag)
        {
            goto label_100D_71EE_172BE_33374;
        }
    label_100D_71C3_17293_34074:
        CheckExternalEvents(cs1, 0x71C3);
        // 100D:71C3 test word ptr DS:[SI+0x12],0x0040
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0040);
        // 100D:71C8 je short 0x71EE
        if (ZeroFlag)
        {
            goto label_100D_71EE_172BE_33374;
        }
    label_100D_71CA_1729A_34077:
        CheckExternalEvents(cs1, 0x71CA);
        // 100D:71CA rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:71CE rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:71D2 rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:71D6 test word ptr DS:[0],7
        Alu16.And(UInt16[DS, (ushort)0x0000], (ushort)0x0007);
        // 100D:71DC jne short 0x71EE
        if (!ZeroFlag)
        {
            goto label_100D_71EE_172BE_33374;
        }
    label_100D_71DE_172AE_34840:
        CheckExternalEvents(cs1, 0x71DE);
        // 100D:71DE call near 0x719C
        NearCall(cs1, 0x71E1, troop_make_harvester_damaged);
    label_100D_71E1_172B1_34846:
        CheckExternalEvents(cs1, 0x71E1);
        // 100D:71E1 or word ptr DS:[SI+0x10],0x8000
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x8000);
        // 100D:71E6 or byte ptr DS:[DI+0x0A],4
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x04);
        // 100D:71EA mov AL,3
        AL = (byte)0x03;
        // 100D:71EC jmp short 0x71B2
        return queue_vision_message_f00(0x0000);
    label_100D_71EE_172BE_33374:
        CheckExternalEvents(cs1, 0x71EE);
        // 100D:71EE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_71EF_172BF(int loadOffset)
    {
        goto label_100D_71EF_172BF_33573;

    label_100D_6EDB_16FAB_33637:
        CheckExternalEvents(cs1, 0x6EDB);
        // 100D:6EDB mov AL,1
        AL = (byte)0x01;
        return troop_increase_spice_skill(0x0000);
    label_100D_71EF_172BF_33573:
        CheckExternalEvents(cs1, 0x71EF);
        // 100D:71EF call near 0x6E20
        NearCall(cs1, 0x71F2, unknown_100D_6E20_16EF0);
    label_100D_71F2_172C2_33575:
        CheckExternalEvents(cs1, 0x71F2);
        // 100D:71F2 and word ptr DS:[SI+0x10],0xFDFF
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0xFDFF);
        // 100D:71F7 test byte ptr DS:[DI+0x0A],4
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x04);
        // 100D:71FB jne short 0x725F
        if (!ZeroFlag)
        {
            goto label_100D_725F_1732F_35289;
        }
    label_100D_71FD_172CD_33579:
        CheckExternalEvents(cs1, 0x71FD);
        // 100D:71FD dec word ptr DS:[SI+0x0C]
        UInt16[DS, (ushort)(SI + (sbyte)12)] = Alu16.Dec(UInt16[DS, (ushort)(SI + (sbyte)12)]);
        // 100D:7200 js short 0x7203
        if (SignFlag)
        {
            goto label_100D_7203_172D3_33582;
        }
    label_100D_7202_172D2_33639:
        CheckExternalEvents(cs1, 0x7202);
        // 100D:7202 ret near
        return NearRet((ushort)0x0000);
    label_100D_7203_172D3_33582:
        CheckExternalEvents(cs1, 0x7203);
        // 100D:7203 cmp DI,word ptr DS:[0x473C]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x473C]);
        // 100D:7207 jne short 0x7212
        if (!ZeroFlag)
        {
            goto label_100D_7212_172E2_33585;
        }
    label_100D_7209_172D9_33799:
        CheckExternalEvents(cs1, 0x7209);
        // 100D:7209 or word ptr DS:[SI+0x10],0x0800
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0800);
        // 100D:720E mov AL,0xA0
        AL = (byte)0xA0;
        // 100D:7210 jmp short 0x721B
        goto label_100D_721B_172EB_33605;
    label_100D_7212_172E2_33585:
        CheckExternalEvents(cs1, 0x7212);
        // 100D:7212 call near 0x7298
        NearCall(cs1, 0x7215, unknown_100D_7298_17368);
    label_100D_7215_172E5_33600:
        CheckExternalEvents(cs1, 0x7215);
        // 100D:7215 mov AX,DX
        AX = DX;
        // 100D:7217 jcxz short 0x721B
        if (CX == (ushort)0x0000)
        {
            goto label_100D_721B_172EB_33605;
        }
    label_100D_7219_172E9_33603:
        CheckExternalEvents(cs1, 0x7219);
        // 100D:7219 div CL
        byte divisor_100D_7219_172E9 = CL;
        ushort dividend_100D_7219_172E9 = AX;
        byte quotient_100D_7219_172E9 = Alu8.Div(unchecked((ushort)dividend_100D_7219_172E9), unchecked((byte)divisor_100D_7219_172E9));
        AL = unchecked((byte)quotient_100D_7219_172E9);
        AH = unchecked((byte)(dividend_100D_7219_172E9 % unchecked((ushort)divisor_100D_7219_172E9)));
    label_100D_721B_172EB_33605:
        CheckExternalEvents(cs1, 0x721B);
        // 100D:721B xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:721D sub AL,byte ptr DS:[SI+0x17]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:7220 jae short 0x7224
        if (!CarryFlag)
        {
            goto label_100D_7224_172F4_33608;
        }
    label_100D_7222_172F2_33673:
        CheckExternalEvents(cs1, 0x7222);
        // 100D:7222 xor AL,AL
        AL = Alu8.Xor(AL, AL);
    label_100D_7224_172F4_33608:
        CheckExternalEvents(cs1, 0x7224);
        // 100D:7224 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:7226 mov CX,AX
        CX = AX;
        // 100D:7228 call near 0x6EFD
        NearCall(cs1, 0x722B, troop_compute_motivation_modifier);
    label_100D_722B_172FB_33612:
        CheckExternalEvents(cs1, 0x722B);
        // 100D:722B xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:722D cmp AL,0x1E
        Alu8.Sub(AL, (byte)0x1E);
        // 100D:722F jae short 0x7233
        if (!CarryFlag)
        {
            goto label_100D_7233_17303_33616;
        }
    label_100D_7231_17301_33654:
        CheckExternalEvents(cs1, 0x7231);
        // 100D:7231 mov AL,0x1E
        AL = (byte)0x1E;
    label_100D_7233_17303_33616:
        CheckExternalEvents(cs1, 0x7233);
        // 100D:7233 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:7235 mov BL,byte ptr DS:[SI+0x19]
        BL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7238 mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 100D:723B test BL,0x0C
        Alu8.And(BL, (byte)0x0C);
        // 100D:723E jne short 0x7252
        if (!ZeroFlag)
        {
            goto label_100D_7252_17322_33632;
        }
    label_100D_7240_17310_33622:
        CheckExternalEvents(cs1, 0x7240);
        // 100D:7240 mov AL,0xFA
        AL = (byte)0xFA;
        // 100D:7242 test BL,0x10
        Alu8.And(BL, (byte)0x10);
        // 100D:7245 jne short 0x7252
        if (!ZeroFlag)
        {
            goto label_100D_7252_17322_33632;
        }
    label_100D_7247_17317_33626:
        CheckExternalEvents(cs1, 0x7247);
        // 100D:7247 mov AX,0x012C
        AX = (ushort)0x012C;
        // 100D:724A test BL,0x20
        Alu8.And(BL, (byte)0x20);
        // 100D:724D jne short 0x7252
        if (!ZeroFlag)
        {
            goto label_100D_7252_17322_33632;
        }
    label_100D_724F_1731F_33630:
        CheckExternalEvents(cs1, 0x724F);
        // 100D:724F mov AX,0x0190
        AX = (ushort)0x0190;
    label_100D_7252_17322_33632:
        CheckExternalEvents(cs1, 0x7252);
        // 100D:7252 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:7254 div CX
        ushort divisor_100D_7254_17324 = CX;
        uint dividend_100D_7254_17324 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_7254_17324 = Alu16.Div(unchecked((uint)dividend_100D_7254_17324), unchecked((ushort)divisor_100D_7254_17324));
        AX = unchecked((ushort)quotient_100D_7254_17324);
        DX = unchecked((ushort)(dividend_100D_7254_17324 % unchecked((uint)divisor_100D_7254_17324)));
        // 100D:7256 mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
        // 100D:7259 mov BX,1
        BX = (ushort)0x0001;
        // 100D:725C jmp near 0x6EDB
        goto label_100D_6EDB_16FAB_33637;
    label_100D_725F_1732F_35289:
        CheckExternalEvents(cs1, 0x725F);
        // 100D:725F mov AX,word ptr DS:[SI+0x0E]
        AX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:7262 cmp AH,0xFF
        Alu8.Sub(AH, (byte)0xFF);
        // 100D:7265 je short 0x726D
        if (ZeroFlag)
        {
            goto label_100D_726D_1733D_35296;
        }
    label_100D_7267_17337_35293:
        CheckExternalEvents(cs1, 0x7267);
        // 100D:7267 mov AX,0xFF40
        AX = (ushort)0xFF40;
        // 100D:726A sub AL,byte ptr DS:[SI+0x17]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
    label_100D_726D_1733D_35296:
        CheckExternalEvents(cs1, 0x726D);
        // 100D:726D dec AL
        AL = Alu8.Dec(AL);
        // 100D:726F jns short 0x7279
        if (!SignFlag)
        {
            goto label_100D_7279_17349_35298;
        }
    label_100D_7271_17341_35590:
        CheckExternalEvents(cs1, 0x7271);
        // 100D:7271 call near 0x727D
        NearCall(cs1, 0x7274, unknown_100D_727D_1734D);
    label_100D_7274_17344_35604:
        CheckExternalEvents(cs1, 0x7274);
        // 100D:7274 or word ptr DS:[SI+0x12],CX
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)18)], CX);
        // 100D:7277 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_7279_17349_35298:
        CheckExternalEvents(cs1, 0x7279);
        // 100D:7279 mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
        // 100D:727C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_727D_1734D(int loadOffset)
    {
    entrydispatcher:
    label_100D_727D_1734D_35592:
        CheckExternalEvents(cs1, 0x727D);
        // 100D:727D and byte ptr DS:[DI+0x0A],0xFB
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0xFB);
        // 100D:7281 mov BP,0x7289
        BP = (ushort)0x7289;
        // 100D:7284 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:7286 jmp near 0x661D
        if (JumpDispatcher.Jump(for_each_hired_troop_in_location, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_7289_17359(int loadOffset)
    {
    label_100D_7289_17359_35597:
        CheckExternalEvents(cs1, 0x7289);
        // 100D:7289 test word ptr DS:[SI+0x12],0x0040
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0040);
        // 100D:728E je short 0x7297
        if (ZeroFlag)
        {
            goto label_100D_7297_17367_35603;
        }
    label_100D_7290_17360_35600:
        CheckExternalEvents(cs1, 0x7290);
        // 100D:7290 and word ptr DS:[SI+0x12],-65
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], unchecked((ushort)unchecked((short)(sbyte)-65)));
        // 100D:7294 mov CX,0x0100
        CX = (ushort)0x0100;
    label_100D_7297_17367_35603:
        CheckExternalEvents(cs1, 0x7297);
        // 100D:7297 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7298_17368(int loadOffset)
    {
    entrydispatcher:
    label_100D_7298_17368_33587:
        CheckExternalEvents(cs1, 0x7298);
        // 100D:7298 mov BP,0x72A2
        BP = (ushort)0x72A2;
        // 100D:729B xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:729D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:729F jmp near 0x661D
        if (JumpDispatcher.Jump(for_each_hired_troop_in_location, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_72A2_17372(int loadOffset)
    {
    label_100D_72A2_17372_33592:
        CheckExternalEvents(cs1, 0x72A2);
        // 100D:72A2 cmp byte ptr DS:[SI+3],4
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x04);
        // 100D:72A6 jne short 0x72AF
        if (!ZeroFlag)
        {
            goto label_100D_72AF_1737F_33599;
        }
    label_100D_72A8_17378_33595:
        CheckExternalEvents(cs1, 0x72A8);
        // 100D:72A8 inc CX
        CX = Alu16.Inc(CX);
        // 100D:72A9 add DL,byte ptr DS:[SI+0x17]
        DL = Alu8.Add(DL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:72AC adc DH,0
        DH = Alu8.Adc(DH, (byte)0x00);
    label_100D_72AF_1737F_33599:
        CheckExternalEvents(cs1, 0x72AF);
        // 100D:72AF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_72B0_17380(int loadOffset)
    {
    label_100D_72B0_17380_35491:
        CheckExternalEvents(cs1, 0x72B0);
        // 100D:72B0 mov BX,word ptr DS:[2]
        BX = UInt16[DS, (ushort)0x0002];
        // 100D:72B4 sub BX,word ptr DS:[SI+0x0A]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)10)]);
        // 100D:72B7 test byte ptr DS:[SI+0x10],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x40);
        // 100D:72BB jne short 0x72F7
        if (!ZeroFlag)
        {
            goto label_100D_72F7_173C7_35553;
        }
    label_100D_72BD_1738D_35496:
        CheckExternalEvents(cs1, 0x72BD);
        // 100D:72BD mov AL,0x50
        AL = (byte)0x50;
        // 100D:72BF sub AL,byte ptr DS:[SI+0x17]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:72C2 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:72C3 sar AX,1
        AX = Alu16.Sar(AX, 1);
        // 100D:72C5 mov BP,AX
        BP = AX;
        // 100D:72C7 sar AX,1
        AX = Alu16.Sar(AX, 1);
        // 100D:72C9 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:72CB jge short 0x72F7
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_72F7_173C7_35553;
        }
    label_100D_72CD_1739D_35505:
        CheckExternalEvents(cs1, 0x72CD);
        // 100D:72CD cmp word ptr DS:[SI+0x0C],0
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)12)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:72D1 jne short 0x72DF
        if (!ZeroFlag)
        {
            goto label_100D_72DF_173AF_35541;
        }
    label_100D_72D3_173A3_35508:
        CheckExternalEvents(cs1, 0x72D3);
        // 100D:72D3 push BX
        Stack.Push16(BX);
        // 100D:72D4 push BP
        Stack.Push16(BP);
        // 100D:72D5 call near 0x68D2
        NearCall(cs1, 0x72D8, unknown_100D_68D2_169A2);
    label_100D_72D8_173A8_35535:
        CheckExternalEvents(cs1, 0x72D8);
        // 100D:72D8 pop BP
        BP = Stack.Pop16();
        // 100D:72D9 pop BX
        BX = Stack.Pop16();
        // 100D:72DA jcxz short 0x72F3
        if (CX == (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:72DA");
        }
    label_100D_72DC_173AC_35539:
        CheckExternalEvents(cs1, 0x72DC);
        // 100D:72DC mov word ptr DS:[SI+0x0C],CX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = CX;
    label_100D_72DF_173AF_35541:
        CheckExternalEvents(cs1, 0x72DF);
        // 100D:72DF cmp BP,BX
        Alu16.Sub(BP, BX);
        // 100D:72E1 jge short 0x72F7
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_72F7_173C7_35553;
        }
    label_100D_72E3_173B3_35543:
        CheckExternalEvents(cs1, 0x72E3);
        // 100D:72E3 push BX
        Stack.Push16(BX);
        // 100D:72E4 call near 0x33BE
        NearCall(cs1, 0x72E7, unknown_100D_33BE_1348E);
    label_100D_72E7_173B7_35546:
        CheckExternalEvents(cs1, 0x72E7);
        // 100D:72E7 pop BX
        BX = Stack.Pop16();
        // 100D:72E8 mov AX,word ptr DS:[0x0094]
        AX = UInt16[DS, (ushort)0x0094];
        // 100D:72EB xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:72ED div word ptr DS:[SI+0x0C]
        ushort divisor_100D_72ED_173BD = UInt16[DS, (ushort)(SI + (sbyte)12)];
        uint dividend_100D_72ED_173BD = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_72ED_173BD = Alu16.Div(unchecked((uint)dividend_100D_72ED_173BD), unchecked((ushort)divisor_100D_72ED_173BD));
        AX = unchecked((ushort)quotient_100D_72ED_173BD);
        DX = unchecked((ushort)(dividend_100D_72ED_173BD % unchecked((uint)divisor_100D_72ED_173BD)));
        // 100D:72F0 mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
        // 100D:72F3 or byte ptr DS:[SI+0x10],0x40
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x40);
    label_100D_72F7_173C7_35553:
        CheckExternalEvents(cs1, 0x72F7);
        // 100D:72F7 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:72F9 cmp AL,byte ptr DS:[DI+9]
        Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)9)]);
        // 100D:72FC je short 0x7316
        if (ZeroFlag)
        {
            goto label_100D_7316_173E6_35562;
        }
    label_100D_72FE_173CE_35556:
        CheckExternalEvents(cs1, 0x72FE);
        // 100D:72FE mov AL,byte ptr DS:[SI+0x17]
        AL = UInt8[DS, (ushort)(SI + (sbyte)23)];
        // 100D:7301 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:7303 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:7305 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:7307 jae short 0x7316
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7307");
        }
    label_100D_7316_173E6_35562:
        CheckExternalEvents(cs1, 0x7316);
        // 100D:7316 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7399_17469(int loadOffset)
    {
    label_100D_7399_17469_41254:
        CheckExternalEvents(cs1, 0x7399);
        // 100D:7399 mov byte ptr DS:[SI+3],4
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0x04;
        // 100D:739D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_739E_1746E(int loadOffset)
    {
    entrydispatcher:
    label_100D_739E_1746E_34320:
        CheckExternalEvents(cs1, 0x739E);
        // 100D:739E or byte ptr DS:[0x11BC],1
        UInt8[DS, (ushort)0x11BC] = Alu8.Or(UInt8[DS, (ushort)0x11BC], (byte)0x01);
        // 100D:73A3 cmp DI,0x011C
        Alu16.Sub(DI, (ushort)0x011C);
        // 100D:73A7 jne short 0x73D9
        if (!ZeroFlag)
        {
            goto label_100D_73D9_174A9_34324;
        }
    label_100D_73A9_17479_41247:
        CheckExternalEvents(cs1, 0x73A9);
        // 100D:73A9 inc byte ptr DS:[0x00C2]
        UInt8[DS, (ushort)0x00C2] = Alu8.Inc(UInt8[DS, (ushort)0x00C2]);
        // 100D:73AD mov BP,0x7399
        BP = (ushort)0x7399;
        // 100D:73B0 call near 0x661D
        NearCall(cs1, 0x73B3, for_each_hired_troop_in_location);
    label_100D_73B3_17483_41258:
        CheckExternalEvents(cs1, 0x73B3);
        // 100D:73B3 call near 0x6E02
        NearCall(cs1, 0x73B6, unknown_100D_6E02_16ED2);
    label_100D_73B6_17486_41261:
        CheckExternalEvents(cs1, 0x73B6);
        // 100D:73B6 les DI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_73B6_17486 = (ushort)0xDCFE;
        ushort lxsValue_100D_73B6_17486 = UInt16[DS, lxsOffset_100D_73B6_17486];
        ushort lxsSegment_100D_73B6_17486 = UInt16[DS, (ushort)(lxsOffset_100D_73B6_17486 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_73B6_17486);
        ES = unchecked((ushort)lxsSegment_100D_73B6_17486);
        // 100D:73BA xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:73BC mov CX,0xC5F9
        CX = (ushort)0xC5F9;
    label_100D_73BF_1748F_41265:
        CheckExternalEvents(cs1, 0x73BF);
        // 100D:73BF mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:73C2 mov AH,AL
        AH = AL;
        // 100D:73C4 and AH,0x30
        AH = Alu8.And(AH, (byte)0x30);
        // 100D:73C7 cmp AH,0x30
        Alu8.Sub(AH, (byte)0x30);
        // 100D:73CA jne short 0x73CE
        if (!ZeroFlag)
        {
            goto label_100D_73CE_1749E_41270;
        }
    label_100D_73CC_1749C_41272:
        CheckExternalEvents(cs1, 0x73CC);
        // 100D:73CC and AL,0xEF
        AL = Alu8.And(AL, (byte)0xEF);
    label_100D_73CE_1749E_41270:
        CheckExternalEvents(cs1, 0x73CE);
        // 100D:73CE stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:73CF loop 0x73BF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_73BF_1748F_41265;
        }
    label_100D_73D1_174A1_41278:
        CheckExternalEvents(cs1, 0x73D1);
        // 100D:73D1 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:73D3 mov DI,0x011C
        DI = (ushort)0x011C;
        // 100D:73D6 jmp near 0x71B2
        return queue_vision_message_f00(0x0000);
    label_100D_73D9_174A9_34324:
        CheckExternalEvents(cs1, 0x73D9);
        // 100D:73D9 call near 0x33BE
        NearCall(cs1, 0x73DC, unknown_100D_33BE_1348E);
    label_100D_73DC_174AC_34356:
        CheckExternalEvents(cs1, 0x73DC);
        // 100D:73DC cmp word ptr DS:[0x0094],0
        Alu16.Sub(UInt16[DS, (ushort)0x0094], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:73E1 je short 0x7429
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7429_174F9, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_73E3_174B3_34359:
        CheckExternalEvents(cs1, 0x73E3);
        // 100D:73E3 call near 0xE3CC
        NearCall(cs1, 0x73E6, rand);
    label_100D_73E6_174B6_34361:
        CheckExternalEvents(cs1, 0x73E6);
        // 100D:73E6 cmp AL,byte ptr DS:[0x009C]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x009C]);
        // 100D:73EA jb short 0x73EF
        if (CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_73EF_174BF, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_73EC_174BC_34364:
        CheckExternalEvents(cs1, 0x73EC);
        // 100D:73EC jmp near 0x751D
        if (JumpDispatcher.Jump(unknown_100D_751D_175ED, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_7419_174E9(int loadOffset)
    {
    entrydispatcher:
    label_100D_7419_174E9_39579:
        CheckExternalEvents(cs1, 0x7419);
        // 100D:7419 cmp byte ptr DS:[SI+3],6
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x06);
        // 100D:741D jne short 0x7428
        if (!ZeroFlag)
        {
            goto label_100D_7428_174F8_39582;
        }
    label_100D_741F_174EF_39584:
        CheckExternalEvents(cs1, 0x741F);
        // 100D:741F cmp word ptr DS:[0x0094],0
        Alu16.Sub(UInt16[DS, (ushort)0x0094], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:7424 je short 0x7429
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7429_174F9, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_7426_174F6_39588:
        CheckExternalEvents(cs1, 0x7426);
        // 100D:7426 jmp short 0x73EF
        if (JumpDispatcher.Jump(unknown_100D_73EF_174BF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_7428_174F8_39582:
        CheckExternalEvents(cs1, 0x7428);
        // 100D:7428 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7443_17513(int loadOffset)
    {
    entrydispatcher:
    label_100D_7443_17513_36387:
        CheckExternalEvents(cs1, 0x7443);
        // 100D:7443 push SI
        Stack.Push16(SI);
        // 100D:7444 push DI
        Stack.Push16(DI);
        // 100D:7445 mov byte ptr DS:[DI+0x0B],5
        UInt8[DS, (ushort)(DI + (sbyte)11)] = (byte)0x05;
        // 100D:7449 call near 0x644E
        NearCall(cs1, 0x744C, unknown_100D_644E_1651E);
    label_100D_744C_1751C_36392:
        CheckExternalEvents(cs1, 0x744C);
        // 100D:744C pop DI
        DI = Stack.Pop16();
        // 100D:744D pop SI
        SI = Stack.Pop16();
        // 100D:744E call near 0x1AC5
        NearCall(cs1, 0x7451, unknown_100D_1AC5_11B95);
    label_100D_7451_17521_36396:
        CheckExternalEvents(cs1, 0x7451);
        // 100D:7451 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:7453 mov byte ptr DS:[DI+0x0B],AL
        UInt8[DS, (ushort)(DI + (sbyte)11)] = AL;
        // 100D:7456 mov AL,4
        AL = (byte)0x04;
        // 100D:7458 call near 0x6F78
        NearCall(cs1, 0x745B, increase_charisma);
    label_100D_745B_1752B_36401:
        CheckExternalEvents(cs1, 0x745B);
        // 100D:745B mov AL,1
        AL = (byte)0x01;
        // 100D:745D call near 0x6F56
        NearCall(cs1, 0x7460, unknown_100D_6F56_17026);
    label_100D_7460_17530_36404:
        CheckExternalEvents(cs1, 0x7460);
        // 100D:7460 or byte ptr DS:[DI+0x0A],8
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x08);
        // 100D:7464 push CX
        Stack.Push16(CX);
        // 100D:7465 mov CL,byte ptr DS:[DI]
        CL = UInt8[DS, DI];
        // 100D:7467 mov AX,0x8000
        AX = (ushort)0x8000;
        // 100D:746A rol AX,CL
        AX = Alu16.Rol(AX, CL);
        // 100D:746C mov word ptr DS:[0x115A],AX
        UInt16[DS, (ushort)0x115A] = AX;
        // 100D:746F pop CX
        CX = Stack.Pop16();
        // 100D:7470 mov BP,0x75AF
        BP = (ushort)0x75AF;
        // 100D:7473 call near 0x6603
        NearCall(cs1, 0x7476, for_each_troop_in_location);
    label_100D_7476_17546_36445:
        CheckExternalEvents(cs1, 0x7476);
        // 100D:7476 mov BP,0x75EA
        BP = (ushort)0x75EA;
        if (JumpDispatcher.Jump(unknown_100D_7479_17549, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_74B6_17586(int loadOffset)
    {
    label_100D_74B6_17586_34467:
        CheckExternalEvents(cs1, 0x74B6);
        // 100D:74B6 and byte ptr DS:[DI+0x0A],0xFD
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0xFD);
        // 100D:74BA cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:74BE je short 0x7500
        if (ZeroFlag)
        {
            goto label_100D_7500_175D0_40511;
        }
    label_100D_74C0_17590_34471:
        CheckExternalEvents(cs1, 0x74C0);
        // 100D:74C0 mov AL,byte ptr DS:[DI+8]
        AL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:74C3 cmp AL,0x28
        Alu8.Sub(AL, (byte)0x28);
        // 100D:74C5 jae short 0x74EB
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:74C5");
        }
    label_100D_74C7_17597_34475:
        CheckExternalEvents(cs1, 0x74C7);
        // 100D:74C7 and AL,7
        AL = Alu8.And(AL, (byte)0x07);
        // 100D:74C9 add AL,0x28
        AL = Alu8.Add(AL, (byte)0x28);
        // 100D:74CB mov byte ptr DS:[DI+8],AL
        UInt8[DS, (ushort)(DI + (sbyte)8)] = AL;
        // 100D:74CE dec byte ptr DS:[0x0027]
        UInt8[DS, (ushort)0x0027] = Alu8.Dec(UInt8[DS, (ushort)0x0027]);
        // 100D:74D2 push SI
        Stack.Push16(SI);
        // 100D:74D3 call near 0x40AE
        NearCall(cs1, 0x74D6, location_entry_room_codes);
    label_100D_74D6_175A6_34482:
        CheckExternalEvents(cs1, 0x74D6);
        // 100D:74D6 mov DL,3
        DL = (byte)0x03;
        // 100D:74D8 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:74DB mov CX,9
        CX = (ushort)0x0009;
    label_100D_74DE_175AE_34486:
        CheckExternalEvents(cs1, 0x74DE);
        // 100D:74DE cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:74E1 jne short 0x74E5
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:74E1");
        }
    label_100D_74E5_175B5_34488:
        CheckExternalEvents(cs1, 0x74E5);
        // 100D:74E5 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:74E8 loop 0x74DE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_74DE_175AE_34486;
        }
    label_100D_74EA_175BA_34492:
        CheckExternalEvents(cs1, 0x74EA);
        // 100D:74EA pop SI
        SI = Stack.Pop16();
        // 100D:74EB mov BP,0x7506
        BP = (ushort)0x7506;
        // 100D:74EE call near 0x6603
        NearCall(cs1, 0x74F1, for_each_troop_in_location);
    label_100D_74F1_175C1_34505:
        CheckExternalEvents(cs1, 0x74F1);
        // 100D:74F1 push DI
        Stack.Push16(DI);
        // 100D:74F2 mov CX,5
        CX = (ushort)0x0005;
        // 100D:74F5 call near 0x6447
        NearCall(cs1, 0x74F8, unknown_100D_6447_16517);
    label_100D_74F8_175C8_34513:
        CheckExternalEvents(cs1, 0x74F8);
        // 100D:74F8 pop DI
        DI = Stack.Pop16();
        // 100D:74F9 and byte ptr DS:[DI+0x0A],0xF6
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0xF6);
        // 100D:74FD jmp near 0x5D44
        return location_mark_map_and_minimap_dirty(0x0000);
    label_100D_7500_175D0_40511:
        CheckExternalEvents(cs1, 0x7500);
        // 100D:7500 mov byte ptr DS:[0x46D9],6
        UInt8[DS, (ushort)0x46D9] = (byte)0x06;
        // 100D:7505 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7506_175D6(int loadOffset)
    {
    label_100D_7506_175D6_34496:
        CheckExternalEvents(cs1, 0x7506);
        // 100D:7506 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:750A je short 0x7511
        if (ZeroFlag)
        {
            goto label_100D_7511_175E1_34499;
        }
    label_100D_750C_175DC_34502:
        CheckExternalEvents(cs1, 0x750C);
        // 100D:750C or byte ptr DS:[SI+0x10],0x10
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:7510 ret near
        return NearRet((ushort)0x0000);
    label_100D_7511_175E1_34499:
        CheckExternalEvents(cs1, 0x7511);
        // 100D:7511 or byte ptr DS:[SI+3],0x20
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:7515 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7516_175E6(int loadOffset)
    {
    entrydispatcher:
    label_100D_7516_175E6_40564:
        CheckExternalEvents(cs1, 0x7516);
        // 100D:7516 cmp byte ptr DS:[SI+3],6
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x06);
        // 100D:751A je short 0x751D
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_751D_175ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_751C_175EC_40568:
        CheckExternalEvents(cs1, 0x751C);
        // 100D:751C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7552_17622(int loadOffset)
    {
    label_100D_7552_17622_36157:
        CheckExternalEvents(cs1, 0x7552);
        // 100D:7552 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:7556 je short 0x758C
        if (ZeroFlag)
        {
            goto label_100D_758C_1765C_36167;
        }
    label_100D_7558_17628_36160:
        CheckExternalEvents(cs1, 0x7558);
        // 100D:7558 inc BX
        BX = Alu16.Inc(BX);
        // 100D:7559 call near 0x758D
        NearCall(cs1, 0x755C, unknown_100D_758D_1765D);
    label_100D_755C_1762C_36163:
        CheckExternalEvents(cs1, 0x755C);
        // 100D:755C add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:755E sub byte ptr DS:[SI+0x1A],AL
        UInt8[DS, (ushort)(SI + (sbyte)26)] = Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)26)], AL);
        // 100D:7561 ja short 0x758C
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_758C_1765C_36167;
        }
    label_100D_7563_17633_36358:
        CheckExternalEvents(cs1, 0x7563);
        // 100D:7563 or byte ptr DS:[SI+3],0x20
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:7567 or byte ptr DS:[SI+0x10],0x10
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:756B dec BX
        BX = Alu16.Dec(BX);
        // 100D:756C push BX
        Stack.Push16(BX);
        // 100D:756D push CX
        Stack.Push16(CX);
        // 100D:756E push DX
        Stack.Push16(DX);
        // 100D:756F mov BX,3
        BX = (ushort)0x0003;
        // 100D:7572 call near 0xE3B7
        NearCall(cs1, 0x7575, rand_masked);
    label_100D_7575_17645_36367:
        CheckExternalEvents(cs1, 0x7575);
        // 100D:7575 jne short 0x7581
        if (!ZeroFlag)
        {
            goto label_100D_7581_17651_36373;
        }
    label_100D_7577_17647_36369:
        CheckExternalEvents(cs1, 0x7577);
        // 100D:7577 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:757A and byte ptr DS:[SI+0x19],0xFB
        UInt8[DS, (ushort)(SI + (sbyte)25)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0xFB);
        // 100D:757E call near 0x7F75
        NearCall(cs1, 0x7581, troop_unregister_equipment_from_location);
    label_100D_7581_17651_36373:
        CheckExternalEvents(cs1, 0x7581);
        // 100D:7581 call near 0x6917
        NearCall(cs1, 0x7584, troop_find_icon);
    label_100D_7584_17654_36375:
        CheckExternalEvents(cs1, 0x7584);
        // 100D:7584 jne short 0x7589
        if (!ZeroFlag)
        {
            goto label_100D_7589_17659_36377;
        }
    label_100D_7586_17656_40038:
        CheckExternalEvents(cs1, 0x7586);
        // 100D:7586 call near 0xC58A
        NearCall(cs1, 0x7589, unknown_100D_C58A_1C65A);
    label_100D_7589_17659_36377:
        CheckExternalEvents(cs1, 0x7589);
        // 100D:7589 pop DX
        DX = Stack.Pop16();
        // 100D:758A pop CX
        CX = Stack.Pop16();
        // 100D:758B pop BX
        BX = Stack.Pop16();
    label_100D_758C_1765C_36167:
        CheckExternalEvents(cs1, 0x758C);
        // 100D:758C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_758D_1765D(int loadOffset)
    {
    label_100D_758D_1765D_34375:
        CheckExternalEvents(cs1, 0x758D);
        // 100D:758D push DX
        Stack.Push16(DX);
        // 100D:758E mov AX,DX
        AX = DX;
        // 100D:7590 mov DX,0x00FF
        DX = (ushort)0x00FF;
        // 100D:7593 sub DL,byte ptr DS:[SI+0x17]
        DL = Alu8.Sub(DL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:7596 sub DL,byte ptr DS:[SI+0x17]
        DL = Alu8.Sub(DL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:7599 mul DX
        uint result_100D_7599_17669 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_7599_17669 >> 16));
        AX = unchecked((ushort)result_100D_7599_17669);
        // 100D:759B mov AL,AH
        AL = AH;
        // 100D:759D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:759F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:75A1 je short 0x75A5
        if (ZeroFlag)
        {
            goto label_100D_75A5_17675_34388;
        }
    label_100D_75A3_17673_34386:
        CheckExternalEvents(cs1, 0x75A3);
        // 100D:75A3 mov AL,0xFF
        AL = (byte)0xFF;
    label_100D_75A5_17675_34388:
        CheckExternalEvents(cs1, 0x75A5);
        // 100D:75A5 pop DX
        DX = Stack.Pop16();
        // 100D:75A6 cmp AL,byte ptr DS:[SI+0x1A]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)26)]);
        // 100D:75A9 jbe short 0x75AE
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_75AE_1767E_34393;
        }
    label_100D_75AB_1767B_34391:
        CheckExternalEvents(cs1, 0x75AB);
        // 100D:75AB mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
    label_100D_75AE_1767E_34393:
        CheckExternalEvents(cs1, 0x75AE);
        // 100D:75AE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_75AF_1767F(int loadOffset)
    {
    entrydispatcher:
    label_100D_75AF_1767F_36414:
        CheckExternalEvents(cs1, 0x75AF);
        // 100D:75AF jae short 0x75E2
        if (!CarryFlag)
        {
            goto label_100D_75E2_176B2_36416;
        }
    label_100D_75B1_17681_36418:
        CheckExternalEvents(cs1, 0x75B1);
        // 100D:75B1 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:75B5 je short 0x75E3
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:75B5");
        }
    label_100D_75B7_17687_36421:
        CheckExternalEvents(cs1, 0x75B7);
        // 100D:75B7 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:75BB jne short 0x75DE
        if (!ZeroFlag)
        {
            goto label_100D_75DE_176AE_38142;
        }
    label_100D_75BD_1768D_36424:
        CheckExternalEvents(cs1, 0x75BD);
        // 100D:75BD or word ptr DS:[SI+0x10],0x0400
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0400);
        // 100D:75C2 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:75C6 jb short 0x75CC
        if (CarryFlag)
        {
            goto label_100D_75CC_1769C_36430;
        }
    label_100D_75C8_17698_36428:
        CheckExternalEvents(cs1, 0x75C8);
        // 100D:75C8 or word ptr DS:[SI+0x10],0x0020
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], unchecked((ushort)unchecked((short)(sbyte)32)));
    label_100D_75CC_1769C_36430:
        CheckExternalEvents(cs1, 0x75CC);
        // 100D:75CC mov AL,4
        AL = (byte)0x04;
        // 100D:75CE call near 0x6F48
        NearCall(cs1, 0x75D1, unknown_100D_6F48_17018);
    label_100D_75D1_176A1_36438:
        CheckExternalEvents(cs1, 0x75D1);
        // 100D:75D1 mov BX,1
        BX = (ushort)0x0001;
        // 100D:75D4 mov AL,3
        AL = (byte)0x03;
        // 100D:75D6 call near 0x6EDD
        NearCall(cs1, 0x75D9, troop_increase_spice_skill);
    label_100D_75D9_176A9_36442:
        CheckExternalEvents(cs1, 0x75D9);
        // 100D:75D9 mov CL,4
        CL = (byte)0x04;
        // 100D:75DB jmp near 0x6ACB
        if (JumpDispatcher.Jump(troop_set_occupation, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_75DE_176AE_38142:
        CheckExternalEvents(cs1, 0x75DE);
        // 100D:75DE mov byte ptr DS:[SI+3],0x22
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0x22;
    label_100D_75E2_176B2_36416:
        CheckExternalEvents(cs1, 0x75E2);
        // 100D:75E2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_75EA_176BA(int loadOffset)
    {
    entrydispatcher:
    label_100D_75EA_176BA_36448:
        CheckExternalEvents(cs1, 0x75EA);
        // 100D:75EA jb short 0x764C
        if (CarryFlag)
        {
            return unknown_100D_764C_1771C(0x0000);
        }
    label_100D_75EC_176BC_36450:
        CheckExternalEvents(cs1, 0x75EC);
        // 100D:75EC test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:75F0 je short 0x764C
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:75F0");
        }
    label_100D_75F2_176C2_36453:
        CheckExternalEvents(cs1, 0x75F2);
        // 100D:75F2 call near 0x858C
        NearCall(cs1, 0x75F5, troop_unlink_from_location_chain);
    label_100D_75F5_176C5_36455:
        CheckExternalEvents(cs1, 0x75F5);
        // 100D:75F5 and byte ptr DS:[SI+0x10],0x7F
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x7F);
        // 100D:75F9 call near 0x851F
        NearCall(cs1, 0x75FC, troop_link_into_location);
    label_100D_75FC_176CC_36458:
        CheckExternalEvents(cs1, 0x75FC);
        // 100D:75FC cmp CL,8
        Alu8.Sub(CL, (byte)0x08);
        // 100D:75FF jae short 0x7655
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7655_17725, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_7601_176D1_36461:
        CheckExternalEvents(cs1, 0x7601);
        // 100D:7601 mov byte ptr DS:[SI+3],0xA0
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0xA0;
        // 100D:7605 mov BX,0x0F7F
        BX = (ushort)0x0F7F;
        // 100D:7608 call near 0xE3B7
        NearCall(cs1, 0x760B, rand_masked);
    label_100D_760B_176DB_36465:
        CheckExternalEvents(cs1, 0x760B);
        // 100D:760B add AX,0x1464
        AX = Alu16.Add(AX, (ushort)0x1464);
        // 100D:760E mov byte ptr DS:[SI+0x1A],AL
        UInt8[DS, (ushort)(SI + (sbyte)26)] = AL;
        // 100D:7611 mov byte ptr DS:[SI+0x15],AH
        UInt8[DS, (ushort)(SI + (sbyte)21)] = AH;
        // 100D:7614 mov BX,0x1F1F
        BX = (ushort)0x1F1F;
        // 100D:7617 call near 0xE3B7
        NearCall(cs1, 0x761A, rand_masked);
    label_100D_761A_176EA_36471:
        CheckExternalEvents(cs1, 0x761A);
        // 100D:761A add AX,0x0A0A
        AX = Alu16.Add(AX, (ushort)0x0A0A);
        // 100D:761D mov byte ptr DS:[SI+0x16],AL
        UInt8[DS, (ushort)(SI + (sbyte)22)] = AL;
        // 100D:7620 mov byte ptr DS:[SI+0x17],AH
        UInt8[DS, (ushort)(SI + (sbyte)23)] = AH;
        // 100D:7623 mov byte ptr DS:[SI+0x19],0
        UInt8[DS, (ushort)(SI + (sbyte)25)] = (byte)0x00;
        // 100D:7627 jmp near 0x68E0
        if (JumpDispatcher.Jump(unknown_100D_68E0_169B0, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_762A_176FA(int loadOffset)
    {
    entrydispatcher:
    label_100D_762A_176FA_36485:
        CheckExternalEvents(cs1, 0x762A);
        // 100D:762A jb short 0x764C
        if (CarryFlag)
        {
            return unknown_100D_764C_1771C(0x0000);
        }
    label_100D_762C_176FC_36489:
        CheckExternalEvents(cs1, 0x762C);
        // 100D:762C test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:7630 je short 0x764C
        if (ZeroFlag)
        {
            return unknown_100D_764C_1771C(0x0000);
        }
    label_100D_7632_17702_37167:
        CheckExternalEvents(cs1, 0x7632);
        // 100D:7632 cmp CX,DX
        Alu16.Sub(CX, DX);
        // 100D:7634 jae short 0x7655
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7655_17725, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_7636_17706_37171:
        CheckExternalEvents(cs1, 0x7636);
        // 100D:7636 mov byte ptr DS:[SI+3],0xAC
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0xAC;
        // 100D:763A or byte ptr DS:[SI+0x10],0x10
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:763E mov byte ptr DS:[SI+0x1A],0
        UInt8[DS, (ushort)(SI + (sbyte)26)] = (byte)0x00;
        // 100D:7642 mov word ptr DS:[SI+0x0C],0
        UInt16[DS, (ushort)(SI + (sbyte)12)] = (ushort)0x0000;
        // 100D:7647 mov byte ptr DS:[SI+0x19],0
        UInt8[DS, (ushort)(SI + (sbyte)25)] = (byte)0x00;
        // 100D:764B inc CX
        CX = Alu16.Inc(CX);
        return unknown_100D_764C_1771C(0x0000);
    }

    public virtual Action unknown_100D_764D_1771D(int loadOffset)
    {
    entrydispatcher:
    label_100D_764D_1771D_36614:
        CheckExternalEvents(cs1, 0x764D);
        // 100D:764D jb short 0x765D
        if (CarryFlag)
        {
            return unknown_100D_765D_1772D(0x0000);
        }
    label_100D_764F_1771F_38322:
        CheckExternalEvents(cs1, 0x764F);
        // 100D:764F test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:7653 je short 0x765D
        if (ZeroFlag)
        {
            return unknown_100D_765D_1772D(0x0000);
        }
        else
        {
            if (JumpDispatcher.Jump(unknown_100D_7655_17725, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_765E_1772E(int loadOffset)
    {
    label_100D_765E_1772E_41017:
        CheckExternalEvents(cs1, 0x765E);
        // 100D:765E call near 0xE270
        NearCall(cs1, 0x7661, unknown_100D_E270_1E340);
    label_100D_7661_17731_41025:
        CheckExternalEvents(cs1, 0x7661);
        // 100D:7661 mov SI,0x0100
        SI = (ushort)0x0100;
        // 100D:7664 xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_100D_7666_17736_41028:
        CheckExternalEvents(cs1, 0x7666);
        // 100D:7666 add CL,byte ptr DS:[SI+0x19]
        CL = Alu8.Add(CL, UInt8[DS, (ushort)(SI + (sbyte)25)]);
        // 100D:7669 add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:766C cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:766F jne short 0x7666
        if (!ZeroFlag)
        {
            goto label_100D_7666_17736_41028;
        }
    label_100D_7671_17741_41034:
        CheckExternalEvents(cs1, 0x7671);
        // 100D:7671 sub CL,0x0A
        CL = Alu8.Sub(CL, (byte)0x0A);
        // 100D:7674 jb short 0x7679
        if (CarryFlag)
        {
            goto label_100D_7679_17749_41037;
        }
    label_100D_7676_17746_41039:
        CheckExternalEvents(cs1, 0x7676);
        // 100D:7676 add byte ptr DS:[DI+0x19],CL
        UInt8[DS, (ushort)(DI + (sbyte)25)] = Alu8.Add(UInt8[DS, (ushort)(DI + (sbyte)25)], CL);
    label_100D_7679_17749_41037:
        CheckExternalEvents(cs1, 0x7679);
        // 100D:7679 call near 0xE283
        NearCall(cs1, 0x767C, unknown_100D_E283_1E353);
    label_100D_767C_1774C_41052:
        CheckExternalEvents(cs1, 0x767C);
        // 100D:767C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_767D_1774D(int loadOffset)
    {
    entrydispatcher:
    label_100D_767D_1774D_40068:
        CheckExternalEvents(cs1, 0x767D);
        // 100D:767D cmp byte ptr DS:[DI+0x1A],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)26)], (byte)0x00);
        // 100D:7681 jne short 0x768D
        if (!ZeroFlag)
        {
            goto label_100D_768D_1775D_40071;
        }
    label_100D_7683_17753_40073:
        CheckExternalEvents(cs1, 0x7683);
        // 100D:7683 inc byte ptr DS:[0x00EC]
        UInt8[DS, (ushort)0x00EC] = Alu8.Inc(UInt8[DS, (ushort)0x00EC]);
        // 100D:7687 jne short 0x7692
        if (!ZeroFlag)
        {
            goto label_100D_7692_17762_40078;
        }
    label_100D_7689_17759_40080:
        CheckExternalEvents(cs1, 0x7689);
        // 100D:7689 mov byte ptr DS:[DI+0x1A],0x10
        UInt8[DS, (ushort)(DI + (sbyte)26)] = (byte)0x10;
    label_100D_768D_1775D_40071:
        CheckExternalEvents(cs1, 0x768D);
        // 100D:768D mov CL,8
        CL = (byte)0x08;
        // 100D:768F jmp near 0x6ACB
        if (JumpDispatcher.Jump(troop_set_occupation, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_7692_17762_40078:
        CheckExternalEvents(cs1, 0x7692);
        // 100D:7692 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7693_17763(int loadOffset)
    {
    entrydispatcher:
    label_100D_7693_17763_40015:
        CheckExternalEvents(cs1, 0x7693);
        // 100D:7693 test byte ptr DS:[SI+3],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x10);
        // 100D:7697 jne short 0x7706
        if (!ZeroFlag)
        {
            goto label_100D_7706_177D6_40018;
        }
    label_100D_7699_17769_40020:
        CheckExternalEvents(cs1, 0x7699);
        // 100D:7699 call near 0x6BD7
        NearCall(cs1, 0x769C, unknown_100D_6BD7_16CA7);
    label_100D_769C_1776C_40614:
        CheckExternalEvents(cs1, 0x769C);
        // 100D:769C jb short 0x7706
        if (CarryFlag)
        {
            goto label_100D_7706_177D6_40018;
        }
    label_100D_769E_1776E_40617:
        CheckExternalEvents(cs1, 0x769E);
        // 100D:769E mov byte ptr DS:[0x4737],0xFF
        UInt8[DS, (ushort)0x4737] = (byte)0xFF;
        // 100D:76A3 or word ptr DS:[SI+0x10],0x0100
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0100);
        // 100D:76A8 test byte ptr DS:[DI+0x0A],1
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x01);
        // 100D:76AC jne short 0x76CB
        if (!ZeroFlag)
        {
            goto label_100D_76CB_1779B_40622;
        }
    label_100D_76AE_1777E_40624:
        CheckExternalEvents(cs1, 0x76AE);
        // 100D:76AE or byte ptr DS:[DI+0x0A],1
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x01);
        // 100D:76B2 mov byte ptr DS:[DI+0x12],0
        UInt8[DS, (ushort)(DI + (sbyte)18)] = (byte)0x00;
        // 100D:76B6 mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:76B9 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:76BC mov word ptr DS:[DI+0x0C],DX
        UInt16[DS, (ushort)(DI + (sbyte)12)] = DX;
        // 100D:76BF xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:76C1 mov word ptr DS:[DI+0x0E],BX
        UInt16[DS, (ushort)(DI + (sbyte)14)] = BX;
        // 100D:76C4 mov byte ptr DS:[DI+0x0B],4
        UInt8[DS, (ushort)(DI + (sbyte)11)] = (byte)0x04;
        // 100D:76C8 jmp near 0x6515
        if (JumpDispatcher.Jump(unknown_100D_6515_165E5, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_76CB_1779B_40622:
        CheckExternalEvents(cs1, 0x76CB);
        // 100D:76CB call near 0x6E20
        NearCall(cs1, 0x76CE, unknown_100D_6E20_16EF0);
    label_100D_76CE_1779E_40869:
        CheckExternalEvents(cs1, 0x76CE);
        // 100D:76CE mov AL,byte ptr DS:[SI+0x18]
        AL = UInt8[DS, (ushort)(SI + (sbyte)24)];
        // 100D:76D1 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:76D3 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:76D5 jne short 0x76D8
        if (!ZeroFlag)
        {
            goto label_100D_76D8_177A8_40874;
        }
    label_100D_76D7_177A7_40876:
        CheckExternalEvents(cs1, 0x76D7);
        // 100D:76D7 inc AX
        AX = Alu16.Inc(AX);
    label_100D_76D8_177A8_40874:
        CheckExternalEvents(cs1, 0x76D8);
        // 100D:76D8 add byte ptr DS:[DI+0x0F],AL
        UInt8[DS, (ushort)(DI + (sbyte)15)] = Alu8.Add(UInt8[DS, (ushort)(DI + (sbyte)15)], AL);
        // 100D:76DB jae short 0x7706
        if (!CarryFlag)
        {
            goto label_100D_7706_177D6_40018;
        }
    label_100D_76DD_177AD_40881:
        CheckExternalEvents(cs1, 0x76DD);
        // 100D:76DD mov BX,2
        BX = (ushort)0x0002;
        // 100D:76E0 mov AL,1
        AL = (byte)0x01;
        // 100D:76E2 call near 0x6EDD
        NearCall(cs1, 0x76E5, troop_increase_spice_skill);
    label_100D_76E5_177B5_41994:
        CheckExternalEvents(cs1, 0x76E5);
        // 100D:76E5 sub byte ptr DS:[DI+0x1B],0x0C
        UInt8[DS, (ushort)(DI + (sbyte)27)] = Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)27)], (byte)0x0C);
        // 100D:76E9 jb short 0x7707
        if (CarryFlag)
        {
            goto label_100D_7707_177D7_41997;
        }
    label_100D_76EB_177BB_41999:
        CheckExternalEvents(cs1, 0x76EB);
        // 100D:76EB cmp byte ptr DS:[DI+0x0B],0x0C
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)11)], (byte)0x0C);
        // 100D:76EF jae short 0x76F4
        if (!CarryFlag)
        {
            goto label_100D_76F4_177C4_42004;
        }
    label_100D_76F1_177C1_42006:
        CheckExternalEvents(cs1, 0x76F1);
        // 100D:76F1 inc byte ptr DS:[DI+0x0B]
        UInt8[DS, (ushort)(DI + (sbyte)11)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (sbyte)11)]);
    label_100D_76F4_177C4_42004:
        CheckExternalEvents(cs1, 0x76F4);
        // 100D:76F4 mov AX,word ptr DS:[DI+0x0E]
        AX = UInt16[DS, (ushort)(DI + (sbyte)14)];
        // 100D:76F7 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:76F8 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:76FB cmp AX,0xFFAE
        Alu16.Sub(AX, (ushort)0xFFAE);
        // 100D:76FE jl short 0x7703
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_7703_177D3_42013;
        }
    label_100D_7700_177D0_42015:
        CheckExternalEvents(cs1, 0x7700);
        // 100D:7700 mov byte ptr DS:[DI+0x0E],AL
        UInt8[DS, (ushort)(DI + (sbyte)14)] = AL;
    label_100D_7703_177D3_42013:
        CheckExternalEvents(cs1, 0x7703);
        // 100D:7703 call near 0x6515
        NearCall(cs1, 0x7706, unknown_100D_6515_165E5);
    label_100D_7706_177D6_40018:
        CheckExternalEvents(cs1, 0x7706);
        // 100D:7706 ret near
        return NearRet((ushort)0x0000);
    label_100D_7707_177D7_41997:
        CheckExternalEvents(cs1, 0x7707);
        VerifySpeculativeEntryOrFail(cs1, 0x7707, [(byte)0xC6, (byte)0x45, (byte)0x1B, (byte)0x00]);
        // 100D:7707 mov byte ptr DS:[DI+0x1B],0
        UInt8[DS, (ushort)(DI + (sbyte)27)] = (byte)0x00;
        VerifySpeculativeEntryOrFail(cs1, 0x770B, [(byte)0xE8, (byte)0x77, (byte)0xF9]);
        // 100D:770B call near 0x7085
        NearCall(cs1, 0x770E, troop_make_stop_working);
        throw FailAsUntested("Call at 100D:770B returned to 100D:770E, but no continuation was observed during discovery.");
    }

    public virtual Action unknown_100D_7711_177E1(int loadOffset)
    {
    entrydispatcher:
    label_100D_7711_177E1_39733:
        CheckExternalEvents(cs1, 0x7711);
        // 100D:7711 test byte ptr DS:[DI+0x0A],0x20
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x20);
        // 100D:7715 jne short 0x7731
        if (!ZeroFlag)
        {
            goto label_100D_7731_17801_39736;
        }
    label_100D_7717_177E7_39738:
        CheckExternalEvents(cs1, 0x7717);
        // 100D:7717 mov AL,1
        AL = (byte)0x01;
        // 100D:7719 call near 0x6F48
        NearCall(cs1, 0x771C, unknown_100D_6F48_17018);
    label_100D_771C_177EC_39746:
        CheckExternalEvents(cs1, 0x771C);
        // 100D:771C call near 0x348A
        NearCall(cs1, 0x771F, unknown_100D_348A_1355A);
    label_100D_771F_177EF_39777:
        CheckExternalEvents(cs1, 0x771F);
        // 100D:771F add byte ptr DS:[DI+0x1B],AL
        UInt8[DS, (ushort)(DI + (sbyte)27)] = Alu8.Add(UInt8[DS, (ushort)(DI + (sbyte)27)], AL);
        // 100D:7722 jb short 0x7725
        if (CarryFlag)
        {
            goto label_100D_7725_177F5_39780;
        }
    label_100D_7724_177F4_39782:
        CheckExternalEvents(cs1, 0x7724);
        // 100D:7724 ret near
        return NearRet((ushort)0x0000);
    label_100D_7725_177F5_39780:
        CheckExternalEvents(cs1, 0x7725);
        // 100D:7725 or byte ptr DS:[DI+0x0A],0x20
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x20);
        // 100D:7729 or byte ptr DS:[DI+8],8
        UInt8[DS, (ushort)(DI + (sbyte)8)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x08);
        // 100D:772D mov byte ptr DS:[DI+0x1B],5
        UInt8[DS, (ushort)(DI + (sbyte)27)] = (byte)0x05;
    label_100D_7731_17801_39736:
        CheckExternalEvents(cs1, 0x7731);
        // 100D:7731 jmp near 0x6AC5
        if (JumpDispatcher.Jump(unknown_100D_6AC5_16B95, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_77D7_178A7(int loadOffset)
    {
    label_100D_77D7_178A7_31186:
        CheckExternalEvents(cs1, 0x77D7);
        // 100D:77D7 call near 0x68EB
        NearCall(cs1, 0x77DA, contact_verb_troop);
    label_100D_77DA_178AA_31188:
        CheckExternalEvents(cs1, 0x77DA);
        // 100D:77DA mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:77DD push BX
        Stack.Push16(BX);
        // 100D:77DE push SI
        Stack.Push16(SI);
        // 100D:77DF call near 0x7F27
        NearCall(cs1, 0x77E2, compute_location_available_equipment);
    label_100D_77E2_178B2_31193:
        CheckExternalEvents(cs1, 0x77E2);
        // 100D:77E2 pop SI
        SI = Stack.Pop16();
        // 100D:77E3 pop BX
        BX = Stack.Pop16();
        // 100D:77E4 mov AL,1
        AL = (byte)0x01;
        // 100D:77E6 cmp BX,1
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:77E9 jne short 0x77F3
        if (!ZeroFlag)
        {
            goto label_100D_77F3_178C3_31199;
        }
    label_100D_77EB_178BB_33440:
        CheckExternalEvents(cs1, 0x77EB);
        // 100D:77EB cmp DI,word ptr DS:[0x1150]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x1150]);
        // 100D:77EF jne short 0x77F3
        if (!ZeroFlag)
        {
            goto label_100D_77F3_178C3_31199;
        }
    label_100D_77F1_178C1_38328:
        CheckExternalEvents(cs1, 0x77F1);
        // 100D:77F1 inc AL
        AL = Alu8.Inc(AL);
    label_100D_77F3_178C3_31199:
        CheckExternalEvents(cs1, 0x77F3);
        // 100D:77F3 cmp byte ptr DS:[BX+0x46FE],AL
        Alu8.Sub(UInt8[DS, (ushort)(BX + (short)18174)], AL);
        // 100D:77F7 jb short 0x7809
        if (CarryFlag)
        {
            goto label_100D_7809_178D9_31202;
        }
    label_100D_77F9_178C9_33388:
        CheckExternalEvents(cs1, 0x77F9);
        // 100D:77F9 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:77FC mov byte ptr DS:[0x003D],AL
        UInt8[DS, (ushort)0x003D] = AL;
        // 100D:77FF mov AL,0x80
        AL = (byte)0x80;
        // 100D:7801 mov CL,BL
        CL = BL;
        // 100D:7803 shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 100D:7805 or byte ptr DS:[SI+0x19],AL
        UInt8[DS, (ushort)(SI + (sbyte)25)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)25)], AL);
        // 100D:7808 clc
        CarryFlag = false;
    label_100D_7809_178D9_31202:
        CheckExternalEvents(cs1, 0x7809);
        // 100D:7809 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_open_troop_contact_menu(int loadOffset)
    {
    entrydispatcher:
    label_100D_780A_178DA_23737:
        CheckExternalEvents(cs1, 0x780A);
        // 100D:780A call near 0x7C63
        NearCall(cs1, 0x780D, troop_distance_from_player);
    label_100D_780D_178DD_23762:
        CheckExternalEvents(cs1, 0x780D);
        // 100D:780D mov BP,0x2122
        BP = (ushort)0x2122;
        // 100D:7810 cmp AX,word ptr DS:[0x1176]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x1176]);
        // 100D:7814 ja short 0x783E
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_783E_1790E_23799;
        }
    label_100D_7816_178E6_23766:
        CheckExternalEvents(cs1, 0x7816);
        // 100D:7816 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:7819 test AL,0x20
        Alu8.And(AL, (byte)0x20);
        // 100D:781B je short 0x7821
        if (ZeroFlag)
        {
            goto label_100D_7821_178F1_23770;
        }
    label_100D_781D_178ED_35445:
        CheckExternalEvents(cs1, 0x781D);
        // 100D:781D cmp AL,0x22
        Alu8.Sub(AL, (byte)0x22);
        // 100D:781F jne short 0x783E
        if (!ZeroFlag)
        {
            goto label_100D_783E_1790E_23799;
        }
    label_100D_7821_178F1_23770:
        CheckExternalEvents(cs1, 0x7821);
        // 100D:7821 mov BP,0x214A
        BP = (ushort)0x214A;
        // 100D:7824 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:7828 jne short 0x783E
        if (!ZeroFlag)
        {
            goto label_100D_783E_1790E_23799;
        }
    label_100D_782A_178FA_23774:
        CheckExternalEvents(cs1, 0x782A);
        // 100D:782A mov BP,0x210A
        BP = (ushort)0x210A;
        // 100D:782D mov AX,0x0052
        AX = (ushort)0x0052;
        // 100D:7830 cmp byte ptr DS:[0x46F3],1
        Alu8.Sub(UInt8[DS, (ushort)0x46F3], (byte)0x01);
        // 100D:7835 adc AX,0
        AX = Alu16.Adc(AX, (ushort)0x0000);
        // 100D:7838 mov word ptr SS:[BP+0x12],AX
        UInt16[SS, (ushort)(BP + (sbyte)18)] = AX;
        // 100D:783B call near 0x7847
        NearCall(cs1, 0x783E, map_setup_troop_dialog_menu);
    label_100D_783E_1790E_23799:
        CheckExternalEvents(cs1, 0x783E);
        // 100D:783E mov BX,0x8751
        BX = (ushort)0x8751;
        // 100D:7841 call near 0xD323
        NearCall(cs1, 0x7844, stage_command_submenu);
    label_100D_7844_17914_23802:
        CheckExternalEvents(cs1, 0x7844);
        // 100D:7844 jmp near 0xC13B
        return open_onmap_spritesheet(0x0000);
    }

    public virtual Action map_setup_troop_dialog_menu(int loadOffset)
    {
    label_100D_7847_17917_23781:
        CheckExternalEvents(cs1, 0x7847);
        // 100D:7847 mov word ptr DS:[0x2110],0x404F
        UInt16[DS, (ushort)0x2110] = (ushort)0x404F;
        // 100D:784D or byte ptr DS:[0x2115],0x40
        UInt8[DS, (ushort)0x2115] = Alu8.Or(UInt8[DS, (ushort)0x2115], (byte)0x40);
        // 100D:7852 or byte ptr DS:[0x2119],0x40
        UInt8[DS, (ushort)0x2119] = Alu8.Or(UInt8[DS, (ushort)0x2119], (byte)0x40);
        // 100D:7857 test word ptr DS:[SI+0x12],0x0400
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0400);
        // 100D:785C jne short 0x78BB
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:785C");
        }
    label_100D_785E_1792E_23787:
        CheckExternalEvents(cs1, 0x785E);
        // 100D:785E mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:7861 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:7863 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:7865 je short 0x786C
        if (ZeroFlag)
        {
            goto label_100D_786C_1793C_23794;
        }
    label_100D_7867_17937_23792:
        CheckExternalEvents(cs1, 0x7867);
        // 100D:7867 and byte ptr DS:[0x2111],0xBF
        UInt8[DS, (ushort)0x2111] = Alu8.And(UInt8[DS, (ushort)0x2111], (byte)0xBF);
    label_100D_786C_1793C_23794:
        CheckExternalEvents(cs1, 0x786C);
        // 100D:786C cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:786E jne short 0x7876
        if (!ZeroFlag)
        {
            goto label_100D_7876_17946_24677;
        }
    label_100D_7870_17940_23796:
        CheckExternalEvents(cs1, 0x7870);
        // 100D:7870 mov byte ptr DS:[0x2110],0x56
        UInt8[DS, (ushort)0x2110] = (byte)0x56;
        // 100D:7875 ret near
        return NearRet((ushort)0x0000);
    label_100D_7876_17946_24677:
        CheckExternalEvents(cs1, 0x7876);
        // 100D:7876 cmp byte ptr DS:[0x002A],5
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x05);
        // 100D:787B jb short 0x7882
        if (CarryFlag)
        {
            goto label_100D_7882_17952_24680;
        }
    label_100D_787D_1794D_28329:
        CheckExternalEvents(cs1, 0x787D);
        // 100D:787D and byte ptr DS:[0x2119],0xBF
        UInt8[DS, (ushort)0x2119] = Alu8.And(UInt8[DS, (ushort)0x2119], (byte)0xBF);
    label_100D_7882_17952_24680:
        CheckExternalEvents(cs1, 0x7882);
        // 100D:7882 cmp byte ptr DS:[0x002A],4
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x04);
        // 100D:7887 jb short 0x78BB
        if (CarryFlag)
        {
            return unknown_100D_78BB_1798B(0x0000);
        }
    label_100D_7889_17959_27466:
        CheckExternalEvents(cs1, 0x7889);
        // 100D:7889 test word ptr DS:[SI+0x10],0x0200
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0200);
        // 100D:788E jne short 0x78BB
        if (!ZeroFlag)
        {
            return unknown_100D_78BB_1798B(0x0000);
        }
    label_100D_7890_17960_27469:
        CheckExternalEvents(cs1, 0x7890);
        // 100D:7890 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7893 test byte ptr DS:[DI+0x0A],8
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x08);
        // 100D:7897 jne short 0x789F
        if (!ZeroFlag)
        {
            goto label_100D_789F_1796F_27476;
        }
    label_100D_7899_17969_27473:
        CheckExternalEvents(cs1, 0x7899);
        // 100D:7899 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:789D jae short 0x78BB
        if (!CarryFlag)
        {
            return unknown_100D_78BB_1798B(0x0000);
        }
    label_100D_789F_1796F_27476:
        CheckExternalEvents(cs1, 0x789F);
        // 100D:789F push SI
        Stack.Push16(SI);
        // 100D:78A0 call near 0x7F27
        NearCall(cs1, 0x78A3, compute_location_available_equipment);
    label_100D_78A3_17973_27479:
        CheckExternalEvents(cs1, 0x78A3);
        // 100D:78A3 mov SI,0x46FE
        SI = (ushort)0x46FE;
        // 100D:78A6 mov CX,7
        CX = (ushort)0x0007;
        // 100D:78A9 xor AL,AL
        AL = Alu8.Xor(AL, AL);
    label_100D_78AB_1797B_27483:
        CheckExternalEvents(cs1, 0x78AB);
        // 100D:78AB or AL,byte ptr DS:[SI]
        AL = Alu8.Or(AL, UInt8[DS, SI]);
        // 100D:78AD inc SI
        SI = Alu16.Inc(SI);
        // 100D:78AE loop 0x78AB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_78AB_1797B_27483;
        }
    label_100D_78B0_17980_27487:
        CheckExternalEvents(cs1, 0x78B0);
        // 100D:78B0 pop SI
        SI = Stack.Pop16();
        // 100D:78B1 or AL,byte ptr DS:[SI+0x19]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)(SI + (sbyte)25)]);
        // 100D:78B4 je short 0x78BB
        if (ZeroFlag)
        {
            return unknown_100D_78BB_1798B(0x0000);
        }
    label_100D_78B6_17986_27491:
        CheckExternalEvents(cs1, 0x78B6);
        // 100D:78B6 and byte ptr DS:[0x2115],0xBF
        UInt8[DS, (ushort)0x2115] = Alu8.And(UInt8[DS, (ushort)0x2115], (byte)0xBF);
        return unknown_100D_78BB_1798B(0x0000);
    }

    public virtual Action map_close_troop_info_popup(int loadOffset)
    {
    entrydispatcher:
    label_100D_79DE_17AAE_13259:
        CheckExternalEvents(cs1, 0x79DE);
        // 100D:79DE xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:79E0 xchg AX,word ptr DS:[0x46FA]
        ushort xchgOffset_100D_79E0_17AB0 = (ushort)0x46FA;
        ushort temp_100D_79E0_17AB0 = AX;
        AX = UInt16[DS, xchgOffset_100D_79E0_17AB0];
        UInt16[DS, xchgOffset_100D_79E0_17AB0] = unchecked((ushort)temp_100D_79E0_17AB0);
        // 100D:79E4 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:79E6 je short 0x79DB
        if (ZeroFlag)
        {
            return unknown_100D_79DB_17AAB(0x0000);
        }
    label_100D_79E8_17AB8_30122:
        CheckExternalEvents(cs1, 0x79E8);
        // 100D:79E8 mov SI,0x18DF
        SI = (ushort)0x18DF;
        // 100D:79EB jmp near 0x5F9F
        if (JumpDispatcher.Jump(unknown_100D_5F9F_1606F, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_draw_troop_contact_popup(int loadOffset)
    {
    label_100D_79EE_17ABE_23819:
        CheckExternalEvents(cs1, 0x79EE);
        // 100D:79EE mov word ptr DS:[0x46EF],SI
        UInt16[DS, (ushort)0x46EF] = SI;
        // 100D:79F2 call near 0x6917
        NearCall(cs1, 0x79F5, troop_find_icon);
    label_100D_79F5_17AC5_23822:
        CheckExternalEvents(cs1, 0x79F5);
        // 100D:79F5 mov SI,0x18E9
        SI = (ushort)0x18E9;
        // 100D:79F8 jne short 0x7A1E
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:79F8");
        }
    label_100D_79FA_17ACA_23825:
        CheckExternalEvents(cs1, 0x79FA);
        // 100D:79FA mov AX,0x001E
        AX = (ushort)0x001E;
        // 100D:79FD mov BX,5
        BX = (ushort)0x0005;
        // 100D:7A00 cmp word ptr DS:[DI+2],0x004C
        Alu16.Sub(UInt16[DS, (ushort)(DI + (sbyte)2)], unchecked((ushort)unchecked((short)(sbyte)76)));
        // 100D:7A04 jge short 0x7A0C
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_7A0C_17ADC_23830;
        }
    label_100D_7A06_17AD6_33406:
        CheckExternalEvents(cs1, 0x7A06);
        // 100D:7A06 mov AX,0x000E
        AX = (ushort)0x000E;
        // 100D:7A09 mov BX,0x0050
        BX = (ushort)0x0050;
    label_100D_7A0C_17ADC_23830:
        CheckExternalEvents(cs1, 0x7A0C);
        // 100D:7A0C mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        // 100D:7A0F add BX,0x0043
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)67)));
        // 100D:7A12 mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:7A15 mov word ptr DS:[0x4710],0x005C
        UInt16[DS, (ushort)0x4710] = (ushort)0x005C;
        // 100D:7A1B mov word ptr DS:[0x4712],AX
        UInt16[DS, (ushort)0x4712] = AX;
        // 100D:7A1E mov word ptr DS:[0xDBE0],SI
        UInt16[DS, (ushort)0xDBE0] = SI;
        // 100D:7A22 mov AL,2
        AL = (byte)0x02;
        // 100D:7A24 call near 0x7B0F
        NearCall(cs1, 0x7A27, unknown_100D_7B0F_17BDF);
    label_100D_7A27_17AF7_24155:
        CheckExternalEvents(cs1, 0x7A27);
        // 100D:7A27 mov DI,0x18E9
        DI = (ushort)0x18E9;
        // 100D:7A2A mov SI,0x18F3
        SI = (ushort)0x18F3;
        // 100D:7A2D mov DX,word ptr DS:[DI]
        DX = UInt16[DS, DI];
        // 100D:7A2F mov BX,word ptr DS:[DI+2]
        BX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:7A32 mov AX,DX
        AX = DX;
        // 100D:7A34 add AX,0x0049
        AX = Alu16.Add(AX, (ushort)0x0049);
        // 100D:7A37 mov word ptr DS:[0x2244],AX
        UInt16[DS, (ushort)0x2244] = AX;
        // 100D:7A3A add BX,3
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:7A3D mov word ptr DS:[0x2246],BX
        UInt16[DS, (ushort)0x2246] = BX;
        // 100D:7A41 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:7A43 mov word ptr DS:[0x4784],AX
        UInt16[DS, (ushort)0x4784] = AX;
        // 100D:7A46 mov word ptr DS:[0x4786],5
        UInt16[DS, (ushort)0x4786] = (ushort)0x0005;
        // 100D:7A4C mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:7A4F inc AX
        AX = Alu16.Inc(AX);
        // 100D:7A50 mov word ptr DS:[0x478A],AX
        UInt16[DS, (ushort)0x478A] = AX;
        // 100D:7A53 add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:7A56 mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:7A58 mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        // 100D:7A5B add DX,0x003D
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)61)));
        // 100D:7A5E add BX,0x003D
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)61)));
        // 100D:7A61 mov word ptr DS:[SI+4],DX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DX;
        // 100D:7A64 mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:7A67 call near 0x7B1B
        NearCall(cs1, 0x7A6A, map_draw_panel_record);
    label_100D_7A6A_17B3A_24179:
        CheckExternalEvents(cs1, 0x7A6A);
        // 100D:7A6A mov SI,word ptr DS:[0x46EF]
        SI = UInt16[DS, (ushort)0x46EF];
        // 100D:7A6E test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:7A72 je short 0x7A96
        if (ZeroFlag)
        {
            goto label_100D_7A96_17B66_24183;
        }
    label_100D_7A74_17B44_34527:
        CheckExternalEvents(cs1, 0x7A74);
        // 100D:7A74 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7A77 test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:7A7B jne short 0x7A82
        if (!ZeroFlag)
        {
            goto label_100D_7A82_17B52_34535;
        }
    label_100D_7A7D_17B4D_34531:
        CheckExternalEvents(cs1, 0x7A7D);
        // 100D:7A7D call near 0x5D36
        NearCall(cs1, 0x7A80, location_is_atreides);
    label_100D_7A80_17B50_34533:
        CheckExternalEvents(cs1, 0x7A80);
        // 100D:7A80 jb short 0x7A96
        if (CarryFlag)
        {
            goto label_100D_7A96_17B66_24183;
        }
    label_100D_7A82_17B52_34535:
        CheckExternalEvents(cs1, 0x7A82);
        // 100D:7A82 mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:7A85 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:7A88 call near 0x91A0
        NearCall(cs1, 0x7A8B, unknown_100D_91A0_19270);
    label_100D_7A8B_17B5B_34542:
        CheckExternalEvents(cs1, 0x7A8B);
        // 100D:7A8B call near 0xC0F4
        NearCall(cs1, 0x7A8E, update_screen_palette);
    label_100D_7A8E_17B5E_34544:
        CheckExternalEvents(cs1, 0x7A8E);
        // 100D:7A8E mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:7A91 mov BP,0
        BP = (ushort)0x0000;
        // 100D:7A94 jmp short 0x7AC1
        goto label_100D_7AC1_17B91_24201;
    label_100D_7A96_17B66_24183:
        CheckExternalEvents(cs1, 0x7A96);
        // 100D:7A96 mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:7A99 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:7A9C mov word ptr DS:[0x4758],SI
        UInt16[DS, (ushort)0x4758] = SI;
        // 100D:7AA0 mov byte ptr DS:[0x476C],0
        UInt8[DS, (ushort)0x476C] = (byte)0x00;
        // 100D:7AA5 call near 0x91A0
        NearCall(cs1, 0x7AA8, unknown_100D_91A0_19270);
    label_100D_7AA8_17B78_24189:
        CheckExternalEvents(cs1, 0x7AA8);
        // 100D:7AA8 call near 0xC0F4
        NearCall(cs1, 0x7AAB, update_screen_palette);
    label_100D_7AAB_17B7B_24191:
        CheckExternalEvents(cs1, 0x7AAB);
        // 100D:7AAB mov AX,word ptr DS:[0x22A6]
        AX = UInt16[DS, (ushort)0x22A6];
        // 100D:7AAE sub AX,0x000E
        AX = Alu16.Sub(AX, (ushort)0x000E);
        // 100D:7AB1 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:7AB3 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:7AB5 mov BL,byte ptr DS:[0x47D0]
        BL = UInt8[DS, (ushort)0x47D0];
        // 100D:7AB9 dec BL
        BL = Alu8.Dec(BL);
        // 100D:7ABB xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:7ABD shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:7ABF mov BP,BX
        BP = BX;
    label_100D_7AC1_17B91_24201:
        CheckExternalEvents(cs1, 0x7AC1);
        // 100D:7AC1 mov SI,0x22B9
        SI = (ushort)0x22B9;
        // 100D:7AC4 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:7AC6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:7AC7 mov word ptr DS:[0x46D2],AX
        UInt16[DS, (ushort)0x46D2] = AX;
        // 100D:7ACA lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:7ACB mov word ptr DS:[0x46D4],AX
        UInt16[DS, (ushort)0x46D4] = AX;
        // 100D:7ACE push DS
        Stack.Push16(DS);
        // 100D:7ACF mov SI,word ptr SS:[0x47CA]
        SI = UInt16[SS, (ushort)0x47CA];
        // 100D:7AD4 mov DS,word ptr SS:[0xDBB2]
        DS = UInt16[SS, (ushort)0xDBB2];
        // 100D:7AD9 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:7ADC mov DX,word ptr SS:[0x18F3]
        DX = UInt16[SS, (ushort)0x18F3];
        // 100D:7AE1 mov BX,word ptr SS:[0x18F5]
        BX = UInt16[SS, (ushort)0x18F5];
        // 100D:7AE6 inc BX
        BX = Alu16.Inc(BX);
        // 100D:7AE7 inc DX
        DX = Alu16.Inc(DX);
        // 100D:7AE8 mov word ptr SS:[0x47D4],DX
        UInt16[SS, (ushort)0x47D4] = DX;
        // 100D:7AED mov word ptr SS:[0x47D6],BX
        UInt16[SS, (ushort)0x47D6] = BX;
        // 100D:7AF2 add DX,0x003B
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)59)));
        // 100D:7AF5 add BX,0x003B
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)59)));
        // 100D:7AF8 mov word ptr SS:[0x47D8],DX
        UInt16[SS, (ushort)0x47D8] = DX;
        // 100D:7AFD mov word ptr SS:[0x47DA],BX
        UInt16[SS, (ushort)0x47DA] = BX;
        // 100D:7B02 call near 0x9D6A
        NearCall(cs1, 0x7B05, unknown_100D_9D6A_19E3A);
    label_100D_7B05_17BD5_24279:
        CheckExternalEvents(cs1, 0x7B05);
        // 100D:7B05 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:7B06 mov SI,0x47D4
        SI = (ushort)0x47D4;
        // 100D:7B09 call near 0xC4AA
        NearCall(cs1, 0x7B0C, unknown_100D_C4AA_1C57A);
    label_100D_7B0C_17BDC_24283:
        CheckExternalEvents(cs1, 0x7B0C);
        // 100D:7B0C jmp near 0xC13B
        return open_onmap_spritesheet(0x0000);
    }

    public virtual Action unknown_100D_7B0F_17BDF(int loadOffset)
    {
    label_100D_7B0F_17BDF_23839:
        CheckExternalEvents(cs1, 0x7B0F);
        // 100D:7B0F mov byte ptr DS:[0x46D8],0
        UInt8[DS, (ushort)0x46D8] = (byte)0x00;
        // 100D:7B14 push SI
        Stack.Push16(SI);
        // 100D:7B15 xchg SI,DI
        ushort temp_100D_7B15_17BE5 = SI;
        SI = DI;
        DI = unchecked((ushort)temp_100D_7B15_17BE5);
        // 100D:7B17 call near 0xC0E8
        NearCall(cs1, 0x7B1A, unknown_100D_C0E8_1C1B8);
    label_100D_7B1A_17BEA_24153:
        CheckExternalEvents(cs1, 0x7B1A);
        // 100D:7B1A pop SI
        SI = Stack.Pop16();
        return map_draw_panel_record(0x0000);
    }

    public virtual Action map_draw_panel_record(int loadOffset)
    {
    label_100D_7B1B_17BEB_18405:
        CheckExternalEvents(cs1, 0x7B1B);
        // 100D:7B1B mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:7B1F mov AL,byte ptr DS:[SI+9]
        AL = UInt8[DS, (ushort)(SI + (sbyte)9)];
        // 100D:7B22 push SI
        Stack.Push16(SI);
        // 100D:7B23 call far dword ptr DS:[0x38DD]
        ushort targetSegment_18409 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_18409 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_18409 == cs2 && targetOffset_18409 == 0x011E)
        {
            FarCall(cs1, 0x7B27, cs2, unknown_3358_011E_3369E);
            goto label_100D_7B27_17BF7_18410;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_18409:X4}:{targetOffset_18409:X4} at 100D:7B23");
    label_100D_7B27_17BF7_18410:
        CheckExternalEvents(cs1, 0x7B27);
        // 100D:7B27 pop SI
        SI = Stack.Pop16();
        // 100D:7B28 jmp near 0xC551
        return unknown_100D_C551_1C621(0x0000);
    }

    public virtual Action unknown_100D_7B2B_17BFB(int loadOffset)
    {
    label_100D_7B2B_17BFB_25019:
        CheckExternalEvents(cs1, 0x7B2B);
        // 100D:7B2B cmp byte ptr DS:[0x46D8],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D8], (byte)0x00);
        // 100D:7B30 jne short 0x7B35
        if (!ZeroFlag)
        {
            goto label_100D_7B35_17C05_31336;
        }
    label_100D_7B32_17C02_25022:
        CheckExternalEvents(cs1, 0x7B32);
        // 100D:7B32 jmp near 0xC0E8
        return unknown_100D_C0E8_1C1B8(0x0000);
    label_100D_7B35_17C05_31336:
        CheckExternalEvents(cs1, 0x7B35);
        // 100D:7B35 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_dismiss_troop_popups(int loadOffset)
    {
    label_100D_7B36_17C06_13237:
        CheckExternalEvents(cs1, 0x7B36);
        // 100D:7B36 push SI
        Stack.Push16(SI);
        // 100D:7B37 push DI
        Stack.Push16(DI);
        // 100D:7B38 mov byte ptr DS:[0x46D8],1
        UInt8[DS, (ushort)0x46D8] = (byte)0x01;
        // 100D:7B3D mov byte ptr DS:[0xDCE6],0x80
        UInt8[DS, (ushort)0xDCE6] = (byte)0x80;
        // 100D:7B42 call near 0x8770
        NearCall(cs1, 0x7B45, menu_callback_choice_map_troop_contact_no_more_orders);
    label_100D_7B45_17C15_13248:
        CheckExternalEvents(cs1, 0x7B45);
        // 100D:7B45 call near 0x5F79
        NearCall(cs1, 0x7B48, map_close_location_troop_popup);
    label_100D_7B48_17C18_13257:
        CheckExternalEvents(cs1, 0x7B48);
        // 100D:7B48 call near 0x79DE
        NearCall(cs1, 0x7B4B, map_close_troop_info_popup);
    label_100D_7B4B_17C1B_13266:
        CheckExternalEvents(cs1, 0x7B4B);
        // 100D:7B4B mov byte ptr DS:[0xDCE6],0
        UInt8[DS, (ushort)0xDCE6] = (byte)0x00;
        // 100D:7B50 mov byte ptr DS:[0x46F4],0
        UInt8[DS, (ushort)0x46F4] = (byte)0x00;
        // 100D:7B55 pop DI
        DI = Stack.Pop16();
        // 100D:7B56 pop SI
        SI = Stack.Pop16();
        // 100D:7B57 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_close_troop_contact_popup(int loadOffset)
    {
    entrydispatcher:
    label_100D_7B58_17C28_23589:
        CheckExternalEvents(cs1, 0x7B58);
        // 100D:7B58 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        // 100D:7B5E mov byte ptr DS:[0x46F4],0
        UInt8[DS, (ushort)0x46F4] = (byte)0x00;
        // 100D:7B63 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:7B65 mov byte ptr DS:[0x004C],0
        UInt8[DS, (ushort)0x004C] = (byte)0x00;
        // 100D:7B6A xchg SI,word ptr DS:[0x46EF]
        ushort xchgOffset_100D_7B6A_17C3A = (ushort)0x46EF;
        ushort temp_100D_7B6A_17C3A = SI;
        SI = UInt16[DS, xchgOffset_100D_7B6A_17C3A];
        UInt16[DS, xchgOffset_100D_7B6A_17C3A] = unchecked((ushort)temp_100D_7B6A_17C3A);
        // 100D:7B6E or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:7B70 je short 0x7BA2
        if (ZeroFlag)
        {
            goto label_100D_7BA2_17C72_23597;
        }
    label_100D_7B72_17C42_24993:
        CheckExternalEvents(cs1, 0x7B72);
        // 100D:7B72 cmp byte ptr DS:[0x004C],0
        Alu8.Sub(UInt8[DS, (ushort)0x004C], (byte)0x00);
        // 100D:7B77 jne short 0x7B8C
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7B77");
        }
    label_100D_7B79_17C49_24996:
        CheckExternalEvents(cs1, 0x7B79);
        // 100D:7B79 call near 0x1EBE
        NearCall(cs1, 0x7B7C, game_phase_set_to_64_if_conditions_met);
    label_100D_7B7C_17C4C_25003:
        CheckExternalEvents(cs1, 0x7B7C);
        // 100D:7B7C and word ptr DS:[SI+0x10],0x03F0
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x03F0);
        // 100D:7B81 and word ptr DS:[SI+0x12],0xE5FF
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0xE5FF);
        // 100D:7B86 call near 0x1AC5
        NearCall(cs1, 0x7B89, unknown_100D_1AC5_11B95);
    label_100D_7B89_17C59_25007:
        CheckExternalEvents(cs1, 0x7B89);
        // 100D:7B89 mov byte ptr DS:[SI+0x14],AL
        UInt8[DS, (ushort)(SI + (sbyte)20)] = AL;
        // 100D:7B8C call near 0xA7A5
        NearCall(cs1, 0x7B8F, lip_sync_stop);
    label_100D_7B8F_17C5F_25010:
        CheckExternalEvents(cs1, 0x7B8F);
        // 100D:7B8F mov SI,0x18E9
        SI = (ushort)0x18E9;
        // 100D:7B92 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:7B94 mov word ptr DS:[0xDBE0],AX
        UInt16[DS, (ushort)0xDBE0] = AX;
        // 100D:7B97 mov word ptr DS:[0x47BA],AX
        UInt16[DS, (ushort)0x47BA] = AX;
        // 100D:7B9A call near 0xC6AD
        NearCall(cs1, 0x7B9D, troop_icons_update_dirty_rect);
    label_100D_7B9D_17C6D_25016:
        CheckExternalEvents(cs1, 0x7B9D);
        // 100D:7B9D mov AL,4
        AL = (byte)0x04;
        // 100D:7B9F call near 0x7B2B
        NearCall(cs1, 0x7BA2, unknown_100D_7B2B_17BFB);
    label_100D_7BA2_17C72_23597:
        CheckExternalEvents(cs1, 0x7BA2);
        // 100D:7BA2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_setup_troop_contact_popup(int loadOffset)
    {
    label_100D_7BA3_17C73_23810:
        CheckExternalEvents(cs1, 0x7BA3);
        // 100D:7BA3 call near 0xC08E
        NearCall(cs1, 0x7BA6, set_screen_as_active_framebuffer);
    label_100D_7BA6_17C76_23812:
        CheckExternalEvents(cs1, 0x7BA6);
        // 100D:7BA6 cmp SI,word ptr DS:[0x46EF]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x46EF]);
        // 100D:7BAA je short 0x7BB8
        if (ZeroFlag)
        {
            goto label_100D_7BB8_17C88_24290;
        }
    label_100D_7BAC_17C7C_23815:
        CheckExternalEvents(cs1, 0x7BAC);
        // 100D:7BAC push SI
        Stack.Push16(SI);
        // 100D:7BAD mov word ptr DS:[0x46F1],SI
        UInt16[DS, (ushort)0x46F1] = SI;
        // 100D:7BB1 call near 0x79EE
        NearCall(cs1, 0x7BB4, map_draw_troop_contact_popup);
    label_100D_7BB4_17C84_24285:
        CheckExternalEvents(cs1, 0x7BB4);
        // 100D:7BB4 call near 0x9F40
        NearCall(cs1, 0x7BB7, prepare_dialogue_presentation);
    label_100D_7BB7_17C87_24288:
        CheckExternalEvents(cs1, 0x7BB7);
        // 100D:7BB7 pop SI
        SI = Stack.Pop16();
    label_100D_7BB8_17C88_24290:
        CheckExternalEvents(cs1, 0x7BB8);
        // 100D:7BB8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_present_troop_reaction_line(int loadOffset)
    {
    entrydispatcher:
    label_100D_7BB9_17C89_24692:
        CheckExternalEvents(cs1, 0x7BB9);
        // 100D:7BB9 push AX
        Stack.Push16(AX);
        // 100D:7BBA call near 0x31F6
        NearCall(cs1, 0x7BBD, troop_prepare_troop_data_for_condit);
    label_100D_7BBD_17C8D_24734:
        CheckExternalEvents(cs1, 0x7BBD);
        // 100D:7BBD pop AX
        AX = Stack.Pop16();
        if (JumpDispatcher.Jump(unknown_100D_7BBE_17C8E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_7BBE_17C8E(int loadOffset)
    {
    entrydispatcher:
    label_100D_7BBE_17C8E_24736:
        CheckExternalEvents(cs1, 0x7BBE);
        // 100D:7BBE mov word ptr DS:[0x46F1],SI
        UInt16[DS, (ushort)0x46F1] = SI;
        // 100D:7BC2 mov byte ptr DS:[0x0023],AL
        UInt8[DS, (ushort)0x0023] = AL;
        // 100D:7BC5 mov word ptr DS:[0x47BA],0
        UInt16[DS, (ushort)0x47BA] = (ushort)0x0000;
        // 100D:7BCB call near 0xC08E
        NearCall(cs1, 0x7BCE, set_screen_as_active_framebuffer);
    label_100D_7BCE_17C9E_24740:
        CheckExternalEvents(cs1, 0x7BCE);
        // 100D:7BCE mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:7BD1 call near 0x96F1
        NearCall(cs1, 0x7BD4, present_room_person_line);
    label_100D_7BD4_17CA4_24743:
        CheckExternalEvents(cs1, 0x7BD4);
        // 100D:7BD4 jb short 0x7BD9
        if (CarryFlag)
        {
            goto label_100D_7BD9_17CA9_24747;
        }
    label_100D_7BD6_17CA6_24745:
        CheckExternalEvents(cs1, 0x7BD6);
        // 100D:7BD6 call near 0x9EFD
        NearCall(cs1, 0x7BD9, play_talking_head_voc);
    label_100D_7BD9_17CA9_24747:
        CheckExternalEvents(cs1, 0x7BD9);
        // 100D:7BD9 mov SI,word ptr DS:[0x46F1]
        SI = UInt16[DS, (ushort)0x46F1];
        // 100D:7BDD jmp short 0x7C56
        return unknown_100D_7C56_17D26(0x0000);
    }

    public virtual Action unknown_100D_7BE0_17CB0(int loadOffset)
    {
    entrydispatcher:
    label_100D_7BE0_17CB0_27506:
        CheckExternalEvents(cs1, 0x7BE0);
        // 100D:7BE0 cmp SI,word ptr DS:[0x46EF]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x46EF]);
        // 100D:7BE4 je short 0x7BE7
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7BE4");
        }
    label_100D_7BE7_17CB7_27509:
        CheckExternalEvents(cs1, 0x7BE7);
        // 100D:7BE7 mov word ptr DS:[0x47BA],0
        UInt16[DS, (ushort)0x47BA] = (ushort)0x0000;
        if (JumpDispatcher.Jump(menu_callback_choice_map_troop_dialogue_ask_for_more_information, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action menu_callback_choice_map_troop_dialogue_ask_for_more_information(int loadOffset)
    {
    entrydispatcher:
    label_100D_7BED_17CBD_24784:
        CheckExternalEvents(cs1, 0x7BED);
        // 100D:7BED cmp byte ptr DS:[0x46F4],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F4], (byte)0x00);
        // 100D:7BF2 je short 0x7BFE
        if (ZeroFlag)
        {
            goto label_100D_7BFE_17CCE_24787;
        }
    label_100D_7BF4_17CC4_24954:
        CheckExternalEvents(cs1, 0x7BF4);
        // 100D:7BF4 cmp byte ptr DS:[0x46F5],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F5], (byte)0x00);
        // 100D:7BF9 je short 0x7BFE
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7BF9");
        }
    label_100D_7BFE_17CCE_24787:
        CheckExternalEvents(cs1, 0x7BFE);
        // 100D:7BFE mov SI,word ptr DS:[0x46EF]
        SI = UInt16[DS, (ushort)0x46EF];
        if (JumpDispatcher.Jump(map_open_troop_contact_dialogue, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_open_troop_contact_dialogue(int loadOffset)
    {
    entrydispatcher:
    label_100D_7C02_17CD2_23808:
        CheckExternalEvents(cs1, 0x7C02);
        // 100D:7C02 call near 0x7BA3
        NearCall(cs1, 0x7C05, map_setup_troop_contact_popup);
    label_100D_7C05_17CD5_24291:
        CheckExternalEvents(cs1, 0x7C05);
        // 100D:7C05 call near 0x31F6
        NearCall(cs1, 0x7C08, troop_prepare_troop_data_for_condit);
    label_100D_7C08_17CD8_24293:
        CheckExternalEvents(cs1, 0x7C08);
        // 100D:7C08 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7C0B call near 0x2E98
        NearCall(cs1, 0x7C0E, stage_location_name_placeholders);
    label_100D_7C0E_17CDE_24296:
        CheckExternalEvents(cs1, 0x7C0E);
        // 100D:7C0E call near 0x7C63
        NearCall(cs1, 0x7C11, troop_distance_from_player);
    label_100D_7C11_17CE1_24298:
        CheckExternalEvents(cs1, 0x7C11);
        // 100D:7C11 cmp AX,word ptr DS:[0x1176]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x1176]);
        // 100D:7C15 jbe short 0x7C2D
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_7C2D_17CFD_24301;
        }
    label_100D_7C17_17CE7_33467:
        CheckExternalEvents(cs1, 0x7C17);
        // 100D:7C17 mov byte ptr DS:[0x004C],0xFF
        UInt8[DS, (ushort)0x004C] = (byte)0xFF;
        // 100D:7C1C mov DI,word ptr DS:[0x4752]
        DI = UInt16[DS, (ushort)0x4752];
        // 100D:7C20 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:7C22 je short 0x7C2D
        if (ZeroFlag)
        {
            goto label_100D_7C2D_17CFD_24301;
        }
    label_100D_7C24_17CF4_33472:
        CheckExternalEvents(cs1, 0x7C24);
        // 100D:7C24 mov AX,0x1916
        AX = (ushort)0x1916;
        // 100D:7C27 mov word ptr DS:[DI+0x0D],AX
        UInt16[DS, (ushort)(DI + (sbyte)13)] = AX;
        // 100D:7C2A mov word ptr DS:[DI+0x0F],AX
        UInt16[DS, (ushort)(DI + (sbyte)15)] = AX;
    label_100D_7C2D_17CFD_24301:
        CheckExternalEvents(cs1, 0x7C2D);
        // 100D:7C2D call near 0x9719
        NearCall(cs1, 0x7C30, map_present_troop_contact_line);
    label_100D_7C30_17D00_24400:
        CheckExternalEvents(cs1, 0x7C30);
        // 100D:7C30 mov SI,word ptr DS:[0x46EF]
        SI = UInt16[DS, (ushort)0x46EF];
        // 100D:7C34 jb short 0x7C2D
        if (CarryFlag)
        {
            goto label_100D_7C2D_17CFD_24301;
        }
    label_100D_7C36_17D06_24403:
        CheckExternalEvents(cs1, 0x7C36);
        // 100D:7C36 push SI
        Stack.Push16(SI);
        // 100D:7C37 call near 0x9EFD
        NearCall(cs1, 0x7C3A, play_talking_head_voc);
    label_100D_7C3A_17D0A_24441:
        CheckExternalEvents(cs1, 0x7C3A);
        // 100D:7C3A pop SI
        SI = Stack.Pop16();
        // 100D:7C3B mov byte ptr DS:[0x46F4],0
        UInt8[DS, (ushort)0x46F4] = (byte)0x00;
        // 100D:7C40 cmp byte ptr DS:[0x47A5],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x47A5], (byte)0x80);
        // 100D:7C45 jne short 0x7C56
        if (!ZeroFlag)
        {
            return unknown_100D_7C56_17D26(0x0000);
        }
    label_100D_7C47_17D17_24896:
        CheckExternalEvents(cs1, 0x7C47);
        // 100D:7C47 inc byte ptr DS:[0x46F4]
        UInt8[DS, (ushort)0x46F4] = Alu8.Inc(UInt8[DS, (ushort)0x46F4]);
        // 100D:7C4B call near 0x7EFB
        NearCall(cs1, 0x7C4E, unknown_100D_7EFB_17FCB);
    label_100D_7C4E_17D1E_24914:
        CheckExternalEvents(cs1, 0x7C4E);
        // 100D:7C4E push SI
        Stack.Push16(SI);
        // 100D:7C4F call near 0x7E1E
        NearCall(cs1, 0x7C52, unknown_100D_7E1E_17EEE);
    label_100D_7C52_17D22_24951:
        CheckExternalEvents(cs1, 0x7C52);
        // 100D:7C52 pop SI
        SI = Stack.Pop16();
        // 100D:7C53 jmp short 0x7C56
        return unknown_100D_7C56_17D26(0x0000);
    }

    public virtual Action troop_distance_from_player(int loadOffset)
    {
    label_100D_7C63_17D33_23739:
        CheckExternalEvents(cs1, 0x7C63);
        // 100D:7C63 push SI
        Stack.Push16(SI);
        // 100D:7C64 call near 0x407E
        NearCall(cs1, 0x7C67, get_map_position);
    label_100D_7C67_17D37_23742:
        CheckExternalEvents(cs1, 0x7C67);
        // 100D:7C67 pop SI
        SI = Stack.Pop16();
        // 100D:7C68 mov BP,BX
        BP = BX;
        // 100D:7C6A shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:7C6C jns short 0x7C70
        if (!SignFlag)
        {
            goto label_100D_7C70_17D40_23747;
        }
    label_100D_7C6E_17D3E_26191:
        CheckExternalEvents(cs1, 0x7C6E);
        // 100D:7C6E neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_7C70_17D40_23747:
        CheckExternalEvents(cs1, 0x7C70);
        // 100D:7C70 mov BP,word ptr SS:[BP+0x4880]
        BP = UInt16[SS, (ushort)(BP + (short)18560)];
        // 100D:7C74 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:7C77 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:7C79 jns short 0x7C7D
        if (!SignFlag)
        {
            goto label_100D_7C7D_17D4D_23752;
        }
    label_100D_7C7B_17D4B_30967:
        CheckExternalEvents(cs1, 0x7C7B);
        // 100D:7C7B neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_7C7D_17D4D_23752:
        CheckExternalEvents(cs1, 0x7C7D);
        // 100D:7C7D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:7C7F div BP
        ushort divisor_100D_7C7F_17D4F = BP;
        uint dividend_100D_7C7F_17D4F = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_7C7F_17D4F = Alu16.Div(unchecked((uint)dividend_100D_7C7F_17D4F), unchecked((ushort)divisor_100D_7C7F_17D4F));
        AX = unchecked((ushort)quotient_100D_7C7F_17D4F);
        DX = unchecked((ushort)(dividend_100D_7C7F_17D4F % unchecked((uint)divisor_100D_7C7F_17D4F)));
        // 100D:7C81 sub BX,word ptr DS:[SI+8]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)8)]);
        // 100D:7C84 jns short 0x7C88
        if (!SignFlag)
        {
            goto label_100D_7C88_17D58_23757;
        }
    label_100D_7C86_17D56_31343:
        CheckExternalEvents(cs1, 0x7C86);
        // 100D:7C86 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_7C88_17D58_23757:
        CheckExternalEvents(cs1, 0x7C88);
        // 100D:7C88 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:7C8A jae short 0x7C8E
        if (!CarryFlag)
        {
            goto label_100D_7C8E_17D5E_23760;
        }
    label_100D_7C8C_17D5C_33404:
        CheckExternalEvents(cs1, 0x7C8C);
        // 100D:7C8C mov AX,BX
        AX = BX;
    label_100D_7C8E_17D5E_23760:
        CheckExternalEvents(cs1, 0x7C8E);
        // 100D:7C8E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action location_distance_from_player(int loadOffset)
    {
    label_100D_7C8F_17D5F_18147:
        CheckExternalEvents(cs1, 0x7C8F);
        // 100D:7C8F push SI
        Stack.Push16(SI);
        // 100D:7C90 call near 0x407E
        NearCall(cs1, 0x7C93, get_map_position);
    label_100D_7C93_17D63_18150:
        CheckExternalEvents(cs1, 0x7C93);
        // 100D:7C93 pop SI
        SI = Stack.Pop16();
        // 100D:7C94 mov BP,BX
        BP = BX;
        // 100D:7C96 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:7C98 jns short 0x7C9C
        if (!SignFlag)
        {
            goto label_100D_7C9C_17D6C_18157;
        }
    label_100D_7C9A_17D6A_18155:
        CheckExternalEvents(cs1, 0x7C9A);
        // 100D:7C9A neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_7C9C_17D6C_18157:
        CheckExternalEvents(cs1, 0x7C9C);
        // 100D:7C9C mov BP,word ptr SS:[BP+0x4880]
        BP = UInt16[SS, (ushort)(BP + (short)18560)];
        // 100D:7CA0 mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:7CA3 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:7CA5 jns short 0x7CA9
        if (!SignFlag)
        {
            goto label_100D_7CA9_17D79_18161;
        }
    label_100D_7CA7_17D77_23503:
        CheckExternalEvents(cs1, 0x7CA7);
        // 100D:7CA7 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_7CA9_17D79_18161:
        CheckExternalEvents(cs1, 0x7CA9);
        // 100D:7CA9 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:7CAB div BP
        ushort divisor_100D_7CAB_17D7B = BP;
        uint dividend_100D_7CAB_17D7B = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_7CAB_17D7B = Alu16.Div(unchecked((uint)dividend_100D_7CAB_17D7B), unchecked((ushort)divisor_100D_7CAB_17D7B));
        AX = unchecked((ushort)quotient_100D_7CAB_17D7B);
        DX = unchecked((ushort)(dividend_100D_7CAB_17D7B % unchecked((uint)divisor_100D_7CAB_17D7B)));
        // 100D:7CAD sub BX,word ptr DS:[SI+4]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:7CB0 jns short 0x7CB4
        if (!SignFlag)
        {
            goto label_100D_7CB4_17D84_18166;
        }
    label_100D_7CB2_17D82_18180:
        CheckExternalEvents(cs1, 0x7CB2);
        // 100D:7CB2 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_7CB4_17D84_18166:
        CheckExternalEvents(cs1, 0x7CB4);
        // 100D:7CB4 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:7CB6 jae short 0x7CBA
        if (!CarryFlag)
        {
            goto label_100D_7CBA_17D8A_18169;
        }
    label_100D_7CB8_17D88_18182:
        CheckExternalEvents(cs1, 0x7CB8);
        // 100D:7CB8 mov AX,BX
        AX = BX;
    label_100D_7CBA_17D8A_18169:
        CheckExternalEvents(cs1, 0x7CBA);
        // 100D:7CBA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7D0C_17DDC(int loadOffset)
    {
    entrydispatcher:
    label_100D_7D0C_17DDC_27560:
        CheckExternalEvents(cs1, 0x7D0C);
        // 100D:7D0C call near 0xC08E
        NearCall(cs1, 0x7D0F, set_screen_as_active_framebuffer);
    label_100D_7D0F_17DDF_27561:
        CheckExternalEvents(cs1, 0x7D0F);
        // 100D:7D0F mov SI,0x1936
        SI = (ushort)0x1936;
        // 100D:7D12 call near 0x7B1B
        NearCall(cs1, 0x7D15, map_draw_panel_record);
    label_100D_7D15_17DE5_27564:
        CheckExternalEvents(cs1, 0x7D15);
        // 100D:7D15 mov SI,0x1940
        SI = (ushort)0x1940;
        // 100D:7D18 call near 0x7B1B
        NearCall(cs1, 0x7D1B, map_draw_panel_record);
    label_100D_7D1B_17DEB_27567:
        CheckExternalEvents(cs1, 0x7D1B);
        // 100D:7D1B call near 0x7E1E
        NearCall(cs1, 0x7D1E, unknown_100D_7E1E_17EEE);
    label_100D_7D1E_17DEE_27569:
        CheckExternalEvents(cs1, 0x7D1E);
        // 100D:7D1E push DS
        Stack.Push16(DS);
        // 100D:7D1F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:7D20 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:7D23 mov DI,0x4C7C
        DI = (ushort)0x4C7C;
        // 100D:7D26 mov CX,0x000E
        CX = (ushort)0x000E;
        // 100D:7D29 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:7D2B mov BX,word ptr DS:[0x1942]
        BX = UInt16[DS, (ushort)0x1942];
        // 100D:7D2F add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:7D32 mov DX,word ptr DS:[0x1940]
        DX = UInt16[DS, (ushort)0x1940];
        // 100D:7D36 add DX,0x0050
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)80)));
        // 100D:7D39 mov SI,0x46FE
        SI = (ushort)0x46FE;
        // 100D:7D3C mov BP,word ptr DS:[0x1946]
        BP = UInt16[DS, (ushort)0x1946];
        // 100D:7D40 mov CX,word ptr DS:[0x1948]
        CX = UInt16[DS, (ushort)0x1948];
        // 100D:7D44 mov word ptr DS:[0xDBE4],CX
        UInt16[DS, (ushort)0xDBE4] = CX;
        // 100D:7D48 call near 0x7E3D
        NearCall(cs1, 0x7D4B, map_draw_equipment_columns);
    label_100D_7D4B_17E1B_27663:
        CheckExternalEvents(cs1, 0x7D4B);
        // 100D:7D4B mov CX,word ptr DS:[0x1948]
        CX = UInt16[DS, (ushort)0x1948];
        // 100D:7D4F mov DX,word ptr DS:[0x1940]
        DX = UInt16[DS, (ushort)0x1940];
        // 100D:7D53 add DX,8
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:7D56 mov AX,0x006F
        AX = (ushort)0x006F;
        // 100D:7D59 call near 0xD194
        NearCall(cs1, 0x7D5C, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_7D5C_17E2C_27669:
        CheckExternalEvents(cs1, 0x7D5C);
        // 100D:7D5C call near 0xE270
        NearCall(cs1, 0x7D5F, unknown_100D_E270_1E340);
    label_100D_7D5F_17E2F_27671:
        CheckExternalEvents(cs1, 0x7D5F);
        // 100D:7D5F call near 0xD280
        NearCall(cs1, 0x7D62, play_pending_panel_fold);
    label_100D_7D62_17E32_27673:
        CheckExternalEvents(cs1, 0x7D62);
        // 100D:7D62 call near 0xE283
        NearCall(cs1, 0x7D65, unknown_100D_E283_1E353);
    label_100D_7D65_17E35_27675:
        CheckExternalEvents(cs1, 0x7D65);
        // 100D:7D65 jmp near 0xC07C
        return set_fb1_as_active_framebuffer(0x0000);
    }

    public virtual Action unknown_100D_7D68_17E38(int loadOffset)
    {
    entrydispatcher:
    label_100D_7D68_17E38_27770:
        CheckExternalEvents(cs1, 0x7D68);
        // 100D:7D68 mov byte ptr DS:[0x46F5],0
        UInt8[DS, (ushort)0x46F5] = (byte)0x00;
        // 100D:7D6D xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:7D6F mov word ptr DS:[0xDBE2],0
        UInt16[DS, (ushort)0xDBE2] = (ushort)0x0000;
        // 100D:7D75 mov SI,0x1940
        SI = (ushort)0x1940;
        // 100D:7D78 call near 0xC6AD
        NearCall(cs1, 0x7D7B, troop_icons_update_dirty_rect);
    label_100D_7D7B_17E4B_27776:
        CheckExternalEvents(cs1, 0x7D7B);
        // 100D:7D7B call near 0x68EB
        NearCall(cs1, 0x7D7E, contact_verb_troop);
    label_100D_7D7E_17E4E_27778:
        CheckExternalEvents(cs1, 0x7D7E);
        // 100D:7D7E call near 0x7F11
        NearCall(cs1, 0x7D81, unknown_100D_7F11_17FE1);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x7D81))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_7DD9_17EA9(int loadOffset)
    {
    label_100D_7DD9_17EA9_27523:
        CheckExternalEvents(cs1, 0x7DD9);
        // 100D:7DD9 mov SI,0x18E9
        SI = (ushort)0x18E9;
        // 100D:7DDC mov DI,0x1936
        DI = (ushort)0x1936;
        // 100D:7DDF mov BP,0x1940
        BP = (ushort)0x1940;
        // 100D:7DE2 mov word ptr DS:[0xDBE2],BP
        UInt16[DS, (ushort)0xDBE2] = BP;
        // 100D:7DE6 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:7DE8 add AX,0x0030
        AX = Alu16.Add(AX, (ushort)0x0030);
        // 100D:7DEB mov word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = AX;
        // 100D:7DEE add AX,0x004D
        AX = Alu16.Add(AX, (ushort)0x004D);
        // 100D:7DF1 mov word ptr DS:[DI],AX
        UInt16[DS, DI] = AX;
        // 100D:7DF3 mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7DF6 mov word ptr DS:[DI+4],AX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = AX;
        // 100D:7DF9 mov word ptr SS:[BP+4],AX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = AX;
        // 100D:7DFC mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:7DFF add AX,0x002B
        AX = Alu16.Add(AX, (ushort)0x002B);
        // 100D:7E02 mov word ptr DS:[DI+2],AX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = AX;
        // 100D:7E05 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:7E08 mov word ptr DS:[DI+6],AX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = AX;
        // 100D:7E0B inc AX
        AX = Alu16.Inc(AX);
        // 100D:7E0C cmp AX,0x0070
        Alu16.Sub(AX, (ushort)0x0070);
        // 100D:7E0F jb short 0x7E14
        if (CarryFlag)
        {
            goto label_100D_7E14_17EE4_27544;
        }
    label_100D_7E11_17EE1_35066:
        CheckExternalEvents(cs1, 0x7E11);
        // 100D:7E11 sub AX,0x006D
        AX = Alu16.Sub(AX, (ushort)0x006D);
    label_100D_7E14_17EE4_27544:
        CheckExternalEvents(cs1, 0x7E14);
        // 100D:7E14 mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:7E17 add AX,0x0028
        AX = Alu16.Add(AX, (ushort)0x0028);
        // 100D:7E1A mov word ptr SS:[BP+6],AX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = AX;
        // 100D:7E1D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7E1E_17EEE(int loadOffset)
    {
    label_100D_7E1E_17EEE_24917:
        CheckExternalEvents(cs1, 0x7E1E);
        // 100D:7E1E call near 0xD068
        NearCall(cs1, 0x7E21, font_select_tall_font);
    label_100D_7E21_17EF1_24919:
        CheckExternalEvents(cs1, 0x7E21);
        // 100D:7E21 mov SI,0x4705
        SI = (ushort)0x4705;
        // 100D:7E24 mov DX,word ptr DS:[0x18E9]
        DX = UInt16[DS, (ushort)0x18E9];
        // 100D:7E28 mov BX,word ptr DS:[0x18EB]
        BX = UInt16[DS, (ushort)0x18EB];
        // 100D:7E2C add DX,0x0080
        DX = Alu16.Add(DX, (ushort)0x0080);
        // 100D:7E30 add BX,0x002D
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)45)));
        // 100D:7E33 mov BP,word ptr DS:[0x18EF]
        BP = UInt16[DS, (ushort)0x18EF];
        // 100D:7E37 mov word ptr DS:[0xDBE4],0x00F0
        UInt16[DS, (ushort)0xDBE4] = (ushort)0x00F0;
        return map_draw_equipment_columns(0x0000);
    }

    public virtual Action map_draw_equipment_columns(int loadOffset)
    {
    label_100D_7E3D_17F0D_24927:
        CheckExternalEvents(cs1, 0x7E3D);
        // 100D:7E3D call near 0xC13B
        NearCall(cs1, 0x7E40, open_onmap_spritesheet);
    label_100D_7E40_17F10_24928:
        CheckExternalEvents(cs1, 0x7E40);
        // 100D:7E40 push DI
        Stack.Push16(DI);
        // 100D:7E41 push DS
        Stack.Push16(DS);
        // 100D:7E42 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:7E43 mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:7E46 mov CX,0x000E
        CX = (ushort)0x000E;
        // 100D:7E49 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:7E4B rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:7E4D mov DI,SI
        DI = SI;
        // 100D:7E4F mov CX,7
        CX = (ushort)0x0007;
        // 100D:7E52 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:7E54 repe scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_7E54_17F24 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_7E54_17F24)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_7E54_17F24 = ZeroFlag == true;
        }
        // 100D:7E56 jne short 0x7E69
        if (!ZeroFlag)
        {
            goto label_100D_7E69_17F39_27586;
        }
    label_100D_7E58_17F28_24941:
        CheckExternalEvents(cs1, 0x7E58);
        // 100D:7E58 add BX,5
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:7E5B add DX,0x000C
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:7E5E call near 0xD04E
        NearCall(cs1, 0x7E61, font_set_draw_position);
    label_100D_7E61_17F31_24945:
        CheckExternalEvents(cs1, 0x7E61);
        // 100D:7E61 mov AX,0x0069
        AX = (ushort)0x0069;
        // 100D:7E64 call near 0xD19B
        NearCall(cs1, 0x7E67, font_draw_phrase_or_command_string);
    label_100D_7E67_17F37_24948:
        CheckExternalEvents(cs1, 0x7E67);
        // 100D:7E67 pop DI
        DI = Stack.Pop16();
        // 100D:7E68 ret near
        return NearRet((ushort)0x0000);
    label_100D_7E69_17F39_27586:
        CheckExternalEvents(cs1, 0x7E69);
        // 100D:7E69 xor DI,DI
        DI = Alu16.Xor(DI, DI);
    label_100D_7E6B_17F3B_27588:
        CheckExternalEvents(cs1, 0x7E6B);
        // 100D:7E6B mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:7E6D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:7E6F je short 0x7E8E
        if (ZeroFlag)
        {
            goto label_100D_7E8E_17F5E_27654;
        }
    label_100D_7E71_17F41_27591:
        CheckExternalEvents(cs1, 0x7E71);
        // 100D:7E71 mov CL,AL
        CL = AL;
        // 100D:7E73 push SI
        Stack.Push16(SI);
        // 100D:7E74 push DI
        Stack.Push16(DI);
        // 100D:7E75 push BP
        Stack.Push16(BP);
        // 100D:7E76 mov AL,byte ptr DS:[DI+0x192F]
        AL = UInt8[DS, (ushort)(DI + (short)6447)];
        // 100D:7E7A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:7E7C shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:7E7E shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:7E80 mov word ptr DS:[DI+0x4C60],DX
        UInt16[DS, (ushort)(DI + (short)19552)] = DX;
        // 100D:7E84 call near 0x61D3
        NearCall(cs1, 0x7E87, unknown_100D_61D3_162A3);
    label_100D_7E87_17F57_27649:
        CheckExternalEvents(cs1, 0x7E87);
        // 100D:7E87 mov word ptr DS:[DI+0x4C62],DX
        UInt16[DS, (ushort)(DI + (short)19554)] = DX;
        // 100D:7E8B pop BP
        BP = Stack.Pop16();
        // 100D:7E8C pop DI
        DI = Stack.Pop16();
        // 100D:7E8D pop SI
        SI = Stack.Pop16();
    label_100D_7E8E_17F5E_27654:
        CheckExternalEvents(cs1, 0x7E8E);
        // 100D:7E8E inc SI
        SI = Alu16.Inc(SI);
        // 100D:7E8F inc DI
        DI = Alu16.Inc(DI);
        // 100D:7E90 cmp DI,7
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:7E93 jb short 0x7E6B
        if (CarryFlag)
        {
            goto label_100D_7E6B_17F3B_27588;
        }
    label_100D_7E95_17F65_27660:
        CheckExternalEvents(cs1, 0x7E95);
        // 100D:7E95 pop DI
        DI = Stack.Pop16();
        // 100D:7E96 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7EE2_17FB2(int loadOffset)
    {
    label_100D_7EE2_17FB2_27747:
        CheckExternalEvents(cs1, 0x7EE2);
        // 100D:7EE2 xor DI,DI
        DI = Alu16.Xor(DI, DI);
    label_100D_7EE4_17FB4_27749:
        CheckExternalEvents(cs1, 0x7EE4);
        // 100D:7EE4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:7EE5 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:7EE7 je short 0x7EF1
        if (ZeroFlag)
        {
            goto label_100D_7EF1_17FC1_33516;
        }
    label_100D_7EE9_17FB9_27752:
        CheckExternalEvents(cs1, 0x7EE9);
        // 100D:7EE9 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:7EEB jb short 0x7EF1
        if (CarryFlag)
        {
            goto label_100D_7EF1_17FC1_33516;
        }
    label_100D_7EED_17FBD_27755:
        CheckExternalEvents(cs1, 0x7EED);
        // 100D:7EED cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 100D:7EEF jb short 0x7EE1
        if (CarryFlag)
        {
            return unknown_100D_7EE1_17FB1(0x0000);
        }
    label_100D_7EF1_17FC1_33516:
        CheckExternalEvents(cs1, 0x7EF1);
        // 100D:7EF1 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:7EF4 inc DI
        DI = Alu16.Inc(DI);
        // 100D:7EF5 cmp DI,7
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:7EF8 jb short 0x7EE4
        if (CarryFlag)
        {
            goto label_100D_7EE4_17FB4_27749;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7EF8");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_7EFB_17FCB(int loadOffset)
    {
    label_100D_7EFB_17FCB_24899:
        CheckExternalEvents(cs1, 0x7EFB);
        // 100D:7EFB push DI
        Stack.Push16(DI);
        // 100D:7EFC push DS
        Stack.Push16(DS);
        // 100D:7EFD pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:7EFE mov DI,0x4705
        DI = (ushort)0x4705;
        // 100D:7F01 mov AH,byte ptr DS:[SI+0x19]
        AH = UInt8[DS, (ushort)(SI + (sbyte)25)];
    label_100D_7F04_17FD4_24905:
        CheckExternalEvents(cs1, 0x7F04);
        // 100D:7F04 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:7F06 rol AX,1
        AX = Alu16.Rol(AX, unchecked((byte)1));
        // 100D:7F08 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:7F09 cmp DI,0x470C
        Alu16.Sub(DI, (ushort)0x470C);
        // 100D:7F0D jb short 0x7F04
        if (CarryFlag)
        {
            goto label_100D_7F04_17FD4_24905;
        }
    label_100D_7F0F_17FDF_24911:
        CheckExternalEvents(cs1, 0x7F0F);
        // 100D:7F0F pop DI
        DI = Stack.Pop16();
        // 100D:7F10 ret near
        return NearRet((ushort)0x0000);
    }
}
