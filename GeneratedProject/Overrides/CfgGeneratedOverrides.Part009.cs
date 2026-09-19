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
    public virtual Action unknown_100D_5323_153F3(int loadOffset)
    {
    label_100D_5323_153F3_13862:
        CheckExternalEvents(cs1, 0x5323);
        // 100D:5323 push BX
        Stack.Push16(BX);
        // 100D:5324 push DX
        Stack.Push16(DX);
        // 100D:5325 mov DI,word ptr SS:[BP]
        DI = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:5328 mov CX,word ptr DS:[DI+4]
        CX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:532B mov DI,word ptr DS:[DI+2]
        DI = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:532E push BP
        Stack.Push16(BP);
        // 100D:532F call near 0x5133
        NearCall(cs1, 0x5332, unknown_100D_5133_15203);
    label_100D_5332_15402_13909:
        CheckExternalEvents(cs1, 0x5332);
        // 100D:5332 pop BP
        BP = Stack.Pop16();
        // 100D:5333 add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 100D:5335 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:5337 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:5339 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:533B and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
        // 100D:533E mov byte ptr SS:[BP+2],AL
        UInt8[SS, (ushort)(BP + (sbyte)2)] = AL;
        // 100D:5341 pop DX
        DX = Stack.Pop16();
        // 100D:5342 pop BX
        BX = Stack.Pop16();
        // 100D:5343 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5344_15414(int loadOffset)
    {
    label_100D_5344_15414_37361:
        CheckExternalEvents(cs1, 0x5344);
        // 100D:5344 push SI
        Stack.Push16(SI);
        // 100D:5345 mov BP,0xFFFF
        BP = (ushort)0xFFFF;
        // 100D:5348 mov SI,0x0100
        SI = (ushort)0x0100;
    label_100D_534B_1541B_37365:
        CheckExternalEvents(cs1, 0x534B);
        // 100D:534B cmp word ptr DS:[SI],-1
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:534E je short 0x537F
        if (ZeroFlag)
        {
            goto label_100D_537F_1544F_37399;
        }
    label_100D_5350_15420_37367:
        CheckExternalEvents(cs1, 0x5350);
        // 100D:5350 test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:5354 jne short 0x537A
        if (!ZeroFlag)
        {
            goto label_100D_537A_1544A_37389;
        }
    label_100D_5356_15426_37370:
        CheckExternalEvents(cs1, 0x5356);
        // 100D:5356 mov CX,word ptr DS:[SI+2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:5359 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 100D:535B jns short 0x535F
        if (!SignFlag)
        {
            goto label_100D_535F_1542F_37374;
        }
    label_100D_535D_1542D_37397:
        CheckExternalEvents(cs1, 0x535D);
        // 100D:535D neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_535F_1542F_37374:
        CheckExternalEvents(cs1, 0x535F);
        // 100D:535F mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:5362 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:5364 jns short 0x5368
        if (!SignFlag)
        {
            goto label_100D_5368_15438_37378;
        }
    label_100D_5366_15436_37392:
        CheckExternalEvents(cs1, 0x5366);
        // 100D:5366 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_5368_15438_37378:
        CheckExternalEvents(cs1, 0x5368);
        // 100D:5368 mov CL,CH
        CL = CH;
        // 100D:536A xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:536C cmp CL,AL
        Alu8.Sub(CL, AL);
        // 100D:536E jae short 0x5372
        if (!CarryFlag)
        {
            goto label_100D_5372_15442_37383;
        }
    label_100D_5370_15440_37395:
        CheckExternalEvents(cs1, 0x5370);
        // 100D:5370 mov CX,AX
        CX = AX;
    label_100D_5372_15442_37383:
        CheckExternalEvents(cs1, 0x5372);
        // 100D:5372 cmp CX,BP
        Alu16.Sub(CX, BP);
        // 100D:5374 jae short 0x537A
        if (!CarryFlag)
        {
            goto label_100D_537A_1544A_37389;
        }
    label_100D_5376_15446_37386:
        CheckExternalEvents(cs1, 0x5376);
        // 100D:5376 mov BP,CX
        BP = CX;
        // 100D:5378 mov DI,SI
        DI = SI;
    label_100D_537A_1544A_37389:
        CheckExternalEvents(cs1, 0x537A);
        // 100D:537A add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:537D jmp short 0x534B
        goto label_100D_534B_1541B_37365;
    label_100D_537F_1544F_37399:
        CheckExternalEvents(cs1, 0x537F);
        // 100D:537F pop SI
        SI = Stack.Pop16();
        // 100D:5380 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_541F_154EF(int loadOffset)
    {
    entrydispatcher:
    label_100D_541F_154EF_28458:
        CheckExternalEvents(cs1, 0x541F);
        // 100D:541F push word ptr DS:[0x197C]
        Stack.Push16(UInt16[DS, (ushort)0x197C]);
        // 100D:5423 push word ptr DS:[0x197E]
        Stack.Push16(UInt16[DS, (ushort)0x197E]);
        // 100D:5427 pop word ptr DS:[0x1982]
        ushort popStackCheck_100D_5427_154F7 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_5427_154F7 = UInt16[DS, (ushort)0x1982];
        ushort poppedValue_100D_5427_154F7 = Stack.Pop16();
        UInt16[DS, (ushort)0x1982] = unchecked((ushort)poppedValue_100D_5427_154F7);
        // 100D:542B pop word ptr DS:[0x1980]
        ushort popStackCheck_100D_542B_154FB = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_542B_154FB = UInt16[DS, (ushort)0x1980];
        ushort poppedValue_100D_542B_154FB = Stack.Pop16();
        UInt16[DS, (ushort)0x1980] = unchecked((ushort)poppedValue_100D_542B_154FB);
        if (JumpDispatcher.Jump(unknown_100D_542F_154FF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_542F_154FF(int loadOffset)
    {
    entrydispatcher:
    label_100D_542F_154FF_28463:
        CheckExternalEvents(cs1, 0x542F);
        // 100D:542F mov word ptr DS:[0x46FC],0
        UInt16[DS, (ushort)0x46FC] = (ushort)0x0000;
        // 100D:5435 mov word ptr DS:[0x479E],0
        UInt16[DS, (ushort)0x479E] = (ushort)0x0000;
        // 100D:543B call near 0x557B
        NearCall(cs1, 0x543E, unknown_100D_557B_1564B);
    label_100D_543E_1550E_28470:
        CheckExternalEvents(cs1, 0x543E);
        // 100D:543E mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:5441 add DX,5
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:5444 add BX,7
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:5447 mov word ptr DS:[DI],DX
        UInt16[DS, DI] = DX;
        // 100D:5449 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:544C add DX,0x00A0
        DX = Alu16.Add(DX, (ushort)0x00A0);
        // 100D:5450 mov word ptr DS:[DI+4],DX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = DX;
        // 100D:5453 add BX,0x0059
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)89)));
        // 100D:5456 mov word ptr DS:[DI+6],BX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = BX;
        // 100D:5459 mov SI,0x4710
        SI = (ushort)0x4710;
        // 100D:545C add DX,5
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:545F mov word ptr DS:[SI+4],DX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DX;
        // 100D:5462 add BX,0x000C
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:5465 mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:5468 call near 0xC13B
        NearCall(cs1, 0x546B, unknown_100D_C13B_1C20B);
    label_100D_546B_1553B_28486:
        CheckExternalEvents(cs1, 0x546B);
        // 100D:546B call near 0x557B
        NearCall(cs1, 0x546E, unknown_100D_557B_1564B);
    label_100D_546E_1553E_28488:
        CheckExternalEvents(cs1, 0x546E);
        // 100D:546E mov AX,0x008D
        AX = (ushort)0x008D;
        // 100D:5471 call near 0xC22F
        NearCall(cs1, 0x5474, unknown_100D_C22F_1C2FF);
    label_100D_5474_15544_28491:
        CheckExternalEvents(cs1, 0x5474);
        // 100D:5474 call near 0xC07C
        NearCall(cs1, 0x5477, unknown_100D_C07C_1C14C);
    label_100D_5477_15547_28493:
        CheckExternalEvents(cs1, 0x5477);
        // 100D:5477 call near 0x5B8D
        NearCall(cs1, 0x547A, unknown_100D_5B8D_15C5D);
    label_100D_547A_1554A_28495:
        CheckExternalEvents(cs1, 0x547A);
        // 100D:547A push word ptr DS:[0xDD00]
        Stack.Push16(UInt16[DS, (ushort)0xDD00]);
        // 100D:547E mov AX,0x003A
        AX = (ushort)0x003A;
        // 100D:5481 call near 0xC13E
        NearCall(cs1, 0x5484, unknown_100D_C13E_1C20E);
    label_100D_5484_15554_28499:
        CheckExternalEvents(cs1, 0x5484);
        // 100D:5484 call near 0x5584
        NearCall(cs1, 0x5487, unknown_100D_5584_15654);
    label_100D_5487_15557_28508:
        CheckExternalEvents(cs1, 0x5487);
        // 100D:5487 push word ptr DS:[0xDBB2]
        Stack.Push16(UInt16[DS, (ushort)0xDBB2]);
        // 100D:548B pop word ptr DS:[0xDD00]
        ushort popStackCheck_100D_548B_1555B = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_548B_1555B = UInt16[DS, (ushort)0xDD00];
        ushort poppedValue_100D_548B_1555B = Stack.Pop16();
        UInt16[DS, (ushort)0xDD00] = unchecked((ushort)poppedValue_100D_548B_1555B);
        // 100D:548F mov byte ptr DS:[0x46EB],0x40
        UInt8[DS, (ushort)0x46EB] = (byte)0x40;
        // 100D:5494 call near 0xB69A
        NearCall(cs1, 0x5497, unknown_100D_B69A_1B76A);
    label_100D_5497_15567_28527:
        CheckExternalEvents(cs1, 0x5497);
        // 100D:5497 call near 0xB6C3
        NearCall(cs1, 0x549A, unknown_100D_B6C3_1B793);
    label_100D_549A_1556A_28529:
        CheckExternalEvents(cs1, 0x549A);
        // 100D:549A pop word ptr DS:[0xDD00]
        ushort popStackCheck_100D_549A_1556A = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_549A_1556A = UInt16[DS, (ushort)0xDD00];
        ushort poppedValue_100D_549A_1556A = Stack.Pop16();
        UInt16[DS, (ushort)0xDD00] = unchecked((ushort)poppedValue_100D_549A_1556A);
        // 100D:549E call near 0x58E4
        NearCall(cs1, 0x54A1, unknown_100D_58E4_159B4);
    label_100D_54A1_15571_28669:
        CheckExternalEvents(cs1, 0x54A1);
        // 100D:54A1 call near 0xC137
        NearCall(cs1, 0x54A4, unknown_100D_C137_1C207);
    label_100D_54A4_15574_28671:
        CheckExternalEvents(cs1, 0x54A4);
        // 100D:54A4 call near 0x5DCE
        NearCall(cs1, 0x54A7, unknown_100D_5DCE_15E9E);
    label_100D_54A7_15577_28682:
        CheckExternalEvents(cs1, 0x54A7);
        // 100D:54A7 call near 0x5605
        NearCall(cs1, 0x54AA, unknown_100D_5605_156D5);
    label_100D_54AA_1557A_28712:
        CheckExternalEvents(cs1, 0x54AA);
        // 100D:54AA call near 0x563E
        NearCall(cs1, 0x54AD, unknown_100D_563E_1570E);
    label_100D_54AD_1557D_28748:
        CheckExternalEvents(cs1, 0x54AD);
        // 100D:54AD mov word ptr DS:[0x2772],0x5555
        UInt16[DS, (ushort)0x2772] = (ushort)0x5555;
        // 100D:54B3 mov DX,word ptr DS:[0x1980]
        DX = UInt16[DS, (ushort)0x1980];
        // 100D:54B7 mov BX,word ptr DS:[0x1982]
        BX = UInt16[DS, (ushort)0x1982];
        // 100D:54BB call near 0xB647
        NearCall(cs1, 0x54BE, unknown_100D_B647_1B717);
    label_100D_54BE_1558E_28753:
        CheckExternalEvents(cs1, 0x54BE);
        // 100D:54BE mov CX,BX
        CX = BX;
        // 100D:54C0 mov DI,DX
        DI = DX;
        // 100D:54C2 sub BX,0x0014
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 100D:54C5 add CX,0x0013
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)19)));
        // 100D:54C8 sub DX,0x0028
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)40)));
        // 100D:54CB add DI,0x0027
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)39)));
        // 100D:54CE mov AX,word ptr DS:[0x4710]
        AX = UInt16[DS, (ushort)0x4710];
        // 100D:54D1 add AX,5
        AX = Alu16.Add(AX, (ushort)0x0005);
        // 100D:54D4 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:54D6 jge short 0x54DA
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_54DA_155AA_28764;
        }
    label_100D_54D8_155A8_33787:
        CheckExternalEvents(cs1, 0x54D8);
        // 100D:54D8 mov DX,AX
        DX = AX;
    label_100D_54DA_155AA_28764:
        CheckExternalEvents(cs1, 0x54DA);
        // 100D:54DA cmp DI,AX
        Alu16.Sub(DI, AX);
        // 100D:54DC jge short 0x54E0
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_54E0_155B0_28767;
        }
    label_100D_54DE_155AE_33789:
        CheckExternalEvents(cs1, 0x54DE);
        // 100D:54DE mov DI,AX
        DI = AX;
    label_100D_54E0_155B0_28767:
        CheckExternalEvents(cs1, 0x54E0);
        // 100D:54E0 add AX,0x009F
        AX = Alu16.Add(AX, (ushort)0x009F);
        // 100D:54E3 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:54E5 jbe short 0x54E9
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_54E9_155B9_28771;
        }
    label_100D_54E7_155B7_33791:
        CheckExternalEvents(cs1, 0x54E7);
        // 100D:54E7 mov DX,AX
        DX = AX;
    label_100D_54E9_155B9_28771:
        CheckExternalEvents(cs1, 0x54E9);
        // 100D:54E9 cmp DI,AX
        Alu16.Sub(DI, AX);
        // 100D:54EB jbe short 0x54EF
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_54EF_155BF_28774;
        }
    label_100D_54ED_155BD_33793:
        CheckExternalEvents(cs1, 0x54ED);
        // 100D:54ED mov DI,AX
        DI = AX;
    label_100D_54EF_155BF_28774:
        CheckExternalEvents(cs1, 0x54EF);
        // 100D:54EF mov AX,word ptr DS:[0x4712]
        AX = UInt16[DS, (ushort)0x4712];
        // 100D:54F2 add AX,7
        AX = Alu16.Add(AX, (ushort)0x0007);
        // 100D:54F5 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:54F7 jge short 0x54FB
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_54FB_155CB_28779;
        }
    label_100D_54F9_155C9_33785:
        CheckExternalEvents(cs1, 0x54F9);
        // 100D:54F9 mov BX,AX
        BX = AX;
    label_100D_54FB_155CB_28779:
        CheckExternalEvents(cs1, 0x54FB);
        // 100D:54FB cmp CX,AX
        Alu16.Sub(CX, AX);
        // 100D:54FD jge short 0x5501
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_5501_155D1_28782;
        }
    label_100D_54FF_155CF_39909:
        CheckExternalEvents(cs1, 0x54FF);
        // 100D:54FF mov CX,AX
        CX = AX;
    label_100D_5501_155D1_28782:
        CheckExternalEvents(cs1, 0x5501);
        // 100D:5501 add AX,0x0058
        AX = Alu16.Add(AX, (ushort)0x0058);
        // 100D:5504 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:5506 jbe short 0x550A
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_550A_155DA_28786;
        }
    label_100D_5508_155D8_35048:
        CheckExternalEvents(cs1, 0x5508);
        // 100D:5508 mov BX,AX
        BX = AX;
    label_100D_550A_155DA_28786:
        CheckExternalEvents(cs1, 0x550A);
        // 100D:550A cmp CX,AX
        Alu16.Sub(CX, AX);
        // 100D:550C jbe short 0x5510
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_5510_155E0_28789;
        }
    label_100D_550E_155DE_34706:
        CheckExternalEvents(cs1, 0x550E);
        // 100D:550E mov CX,AX
        CX = AX;
    label_100D_5510_155E0_28789:
        CheckExternalEvents(cs1, 0x5510);
        // 100D:5510 cmp BX,CX
        Alu16.Sub(BX, CX);
        // 100D:5512 je short 0x551D
        if (ZeroFlag)
        {
            goto label_100D_551D_155ED_28800;
        }
    label_100D_5514_155E4_28792:
        CheckExternalEvents(cs1, 0x5514);
        // 100D:5514 cmp DX,DI
        Alu16.Sub(DX, DI);
        // 100D:5516 je short 0x551D
        if (ZeroFlag)
        {
            goto label_100D_551D_155ED_28800;
        }
    label_100D_5518_155E8_28795:
        CheckExternalEvents(cs1, 0x5518);
        // 100D:5518 mov AL,0xFB
        AL = (byte)0xFB;
        // 100D:551A call near 0xC560
        NearCall(cs1, 0x551D, unknown_100D_C560_1C630);
    label_100D_551D_155ED_28800:
        CheckExternalEvents(cs1, 0x551D);
        // 100D:551D mov word ptr DS:[0x2772],0xFFFF
        UInt16[DS, (ushort)0x2772] = (ushort)0xFFFF;
        // 100D:5523 mov SI,0x4710
        SI = (ushort)0x4710;
        // 100D:5526 mov DI,0xDBE0
        DI = (ushort)0xDBE0;
        // 100D:5529 cmp word ptr DS:[DI],0
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:552C je short 0x5535
        if (ZeroFlag)
        {
            goto label_100D_5535_15605_28811;
        }
    label_100D_552E_155FE_28806:
        CheckExternalEvents(cs1, 0x552E);
        // 100D:552E cmp word ptr DS:[DI],SI
        Alu16.Sub(UInt16[DS, DI], SI);
        // 100D:5530 je short 0x5535
        if (ZeroFlag)
        {
            goto label_100D_5535_15605_28811;
        }
    label_100D_5532_15602_28809:
        CheckExternalEvents(cs1, 0x5532);
        // 100D:5532 mov DI,0xDBE2
        DI = (ushort)0xDBE2;
    label_100D_5535_15605_28811:
        CheckExternalEvents(cs1, 0x5535);
        // 100D:5535 mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 100D:5537 cmp DI,0xDBE2
        Alu16.Sub(DI, (ushort)0xDBE2);
        // 100D:553B pushf
        Stack.Push16(FlagRegister16);
        // 100D:553C xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:553E xchg DI,word ptr DS:[0x4720]
        ushort xchgOffset_100D_553E_1560E = (ushort)0x4720;
        ushort temp_100D_553E_1560E = DI;
        DI = UInt16[DS, xchgOffset_100D_553E_1560E];
        UInt16[DS, xchgOffset_100D_553E_1560E] = unchecked((ushort)temp_100D_553E_1560E);
        // 100D:5542 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5544 je short 0x554D
        if (ZeroFlag)
        {
            goto label_100D_554D_1561D_28824;
        }
    label_100D_5546_15616_28818:
        CheckExternalEvents(cs1, 0x5546);
        // 100D:5546 xchg SI,DI
        ushort temp_100D_5546_15616 = SI;
        SI = DI;
        DI = unchecked((ushort)temp_100D_5546_15616);
        // 100D:5548 mov AL,6
        AL = (byte)0x06;
        // 100D:554A call near 0xC0E8
        NearCall(cs1, 0x554D, unknown_100D_C0E8_1C1B8);
    label_100D_554D_1561D_28824:
        CheckExternalEvents(cs1, 0x554D);
        // 100D:554D popf
        FlagRegister16 = Stack.Pop16();
    label_100D_554E_1561E_28826:
        CheckExternalEvents(cs1, 0x554E);
        // 100D:554E jne short 0x5558
        if (!ZeroFlag)
        {
            goto label_100D_5558_15628_31001;
        }
    label_100D_5550_15620_28828:
        CheckExternalEvents(cs1, 0x5550);
        // 100D:5550 call near 0x62F2
        NearCall(cs1, 0x5553, unknown_100D_62F2_163C2);
    label_100D_5553_15623_28841:
        CheckExternalEvents(cs1, 0x5553);
        // 100D:5553 call near 0x813E
        NearCall(cs1, 0x5556, unknown_100D_813E_1820E);
    label_100D_5556_15626_28883:
        CheckExternalEvents(cs1, 0x5556);
        // 100D:5556 jmp short 0x555B
        goto label_100D_555B_1562B_28885;
    label_100D_5558_15628_31001:
        CheckExternalEvents(cs1, 0x5558);
        // 100D:5558 call near 0x6314
        NearCall(cs1, 0x555B, unknown_100D_6314_163E4);
    label_100D_555B_1562B_28885:
        CheckExternalEvents(cs1, 0x555B);
        // 100D:555B mov SI,0x4710
        SI = (ushort)0x4710;
        // 100D:555E call near 0xC4F0
        NearCall(cs1, 0x5561, unknown_100D_C4F0_1C5C0);
    label_100D_5561_15631_28888:
        CheckExternalEvents(cs1, 0x5561);
        // 100D:5561 call near 0xB69A
        NearCall(cs1, 0x5564, unknown_100D_B69A_1B76A);
    label_100D_5564_15634_28890:
        CheckExternalEvents(cs1, 0x5564);
        // 100D:5564 mov byte ptr DS:[0x46EB],0xC0
        UInt8[DS, (ushort)0x46EB] = (byte)0xC0;
        // 100D:5569 mov SI,0x1482
        SI = (ushort)0x1482;
        // 100D:556C mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:556F call near 0x5B99
        NearCall(cs1, 0x5572, unknown_100D_5B99_15C69);
    label_100D_5572_15642_28895:
        CheckExternalEvents(cs1, 0x5572);
        // 100D:5572 call near 0x5B8D
        NearCall(cs1, 0x5575, unknown_100D_5B8D_15C5D);
    label_100D_5575_15645_28897:
        CheckExternalEvents(cs1, 0x5575);
        // 100D:5575 mov SI,0x4710
        SI = (ushort)0x4710;
        // 100D:5578 jmp near 0xDAAA
        return unknown_100D_DAAA_1DB7A(0x0000);
    }

    public virtual Action unknown_100D_557B_1564B(int loadOffset)
    {
    label_100D_557B_1564B_28466:
        CheckExternalEvents(cs1, 0x557B);
        // 100D:557B mov DX,word ptr DS:[0x4710]
        DX = UInt16[DS, (ushort)0x4710];
        // 100D:557F mov BX,word ptr DS:[0x4712]
        BX = UInt16[DS, (ushort)0x4712];
        // 100D:5583 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5584_15654(int loadOffset)
    {
    label_100D_5584_15654_28501:
        CheckExternalEvents(cs1, 0x5584);
        // 100D:5584 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:5586 xchg AX,word ptr DS:[0x115A]
        ushort xchgOffset_100D_5586_15656 = (ushort)0x115A;
        ushort temp_100D_5586_15656 = AX;
        AX = UInt16[DS, xchgOffset_100D_5586_15656];
        UInt16[DS, xchgOffset_100D_5586_15656] = unchecked((ushort)temp_100D_5586_15656);
        // 100D:558A or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:558C je short 0x55BF
        if (ZeroFlag)
        {
            goto label_100D_55BF_1568F_28506;
        }
    label_100D_558E_1565E_36679:
        CheckExternalEvents(cs1, 0x558E);
        // 100D:558E call near 0xE270
        NearCall(cs1, 0x5591, unknown_100D_E270_1E340);
    label_100D_5591_15661_36681:
        CheckExternalEvents(cs1, 0x5591);
        // 100D:5591 push DS
        Stack.Push16(DS);
        // 100D:5592 push ES
        Stack.Push16(ES);
        // 100D:5593 mov CL,0x0C
        CL = (byte)0x0C;
    label_100D_5595_15665_36685:
        CheckExternalEvents(cs1, 0x5595);
        // 100D:5595 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:5597 jae short 0x55B8
        if (!CarryFlag)
        {
            goto label_100D_55B8_15688_36687;
        }
    label_100D_5599_15669_36690:
        CheckExternalEvents(cs1, 0x5599);
        // 100D:5599 push AX
        Stack.Push16(AX);
        // 100D:559A push CX
        Stack.Push16(CX);
        // 100D:559B mov BL,0x0D
        BL = (byte)0x0D;
        // 100D:559D sub BL,CL
        BL = Alu8.Sub(BL, CL);
        // 100D:559F mov DI,0x0100
        DI = (ushort)0x0100;
    label_100D_55A2_15672_36696:
        CheckExternalEvents(cs1, 0x55A2);
        // 100D:55A2 cmp byte ptr DS:[DI],BL
        Alu8.Sub(UInt8[DS, DI], BL);
        // 100D:55A4 jne short 0x55AB
        if (!ZeroFlag)
        {
            goto label_100D_55AB_1567B_36698;
        }
    label_100D_55A6_15676_36703:
        CheckExternalEvents(cs1, 0x55A6);
        // 100D:55A6 call near 0x5D36
        NearCall(cs1, 0x55A9, unknown_100D_5D36_15E06);
    label_100D_55A9_15679_36705:
        CheckExternalEvents(cs1, 0x55A9);
        // 100D:55A9 jae short 0x55B6
        if (!CarryFlag)
        {
            goto label_100D_55B6_15686_36707;
        }
    label_100D_55AB_1567B_36698:
        CheckExternalEvents(cs1, 0x55AB);
        // 100D:55AB add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:55AE cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:55B1 jne short 0x55A2
        if (!ZeroFlag)
        {
            goto label_100D_55A2_15672_36696;
        }
    label_100D_55B3_15683_37180:
        CheckExternalEvents(cs1, 0x55B3);
        // 100D:55B3 call near 0x55C0
        NearCall(cs1, 0x55B6, unknown_100D_55C0_15690);
    label_100D_55B6_15686_36707:
        CheckExternalEvents(cs1, 0x55B6);
        // 100D:55B6 pop CX
        CX = Stack.Pop16();
        // 100D:55B7 pop AX
        AX = Stack.Pop16();
    label_100D_55B8_15688_36687:
        CheckExternalEvents(cs1, 0x55B8);
        // 100D:55B8 loop 0x5595
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_5595_15665_36685;
        }
    label_100D_55BA_1568A_36710:
        CheckExternalEvents(cs1, 0x55BA);
        // 100D:55BA pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:55BB pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:55BC call near 0xE283
        NearCall(cs1, 0x55BF, unknown_100D_E283_1E353);
    label_100D_55BF_1568F_28506:
        CheckExternalEvents(cs1, 0x55BF);
        // 100D:55BF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_55C0_15690(int loadOffset)
    {
    label_100D_55C0_15690_37181:
        CheckExternalEvents(cs1, 0x55C0);
        // 100D:55C0 mov SI,0x0100
        SI = (ushort)0x0100;
    label_100D_55C3_15693_37184:
        CheckExternalEvents(cs1, 0x55C3);
        // 100D:55C3 cmp byte ptr DS:[SI],BL
        Alu8.Sub(UInt8[DS, SI], BL);
        // 100D:55C5 jne short 0x55CD
        if (!ZeroFlag)
        {
            goto label_100D_55CD_1569D_37186;
        }
    label_100D_55C7_15697_37188:
        CheckExternalEvents(cs1, 0x55C7);
        // 100D:55C7 mov AL,byte ptr DS:[SI+0x10]
        AL = UInt8[DS, (ushort)(SI + (sbyte)16)];
        // 100D:55CA call near 0x55DD
        NearCall(cs1, 0x55CD, unknown_100D_55DD_156AD);
    label_100D_55CD_1569D_37186:
        CheckExternalEvents(cs1, 0x55CD);
        // 100D:55CD add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:55D0 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:55D3 jne short 0x55C3
        if (!ZeroFlag)
        {
            goto label_100D_55C3_15693_37184;
        }
    label_100D_55D5_156A5_37197:
        CheckExternalEvents(cs1, 0x55D5);
        // 100D:55D5 mov AL,0x42
        AL = (byte)0x42;
        // 100D:55D7 cmp BL,7
        Alu8.Sub(BL, (byte)0x07);
        // 100D:55DA je short 0x55DD
        if (ZeroFlag)
        {
            return unknown_100D_55DD_156AD(0x0000);
        }
    label_100D_55DC_156AC_37208:
        CheckExternalEvents(cs1, 0x55DC);
        // 100D:55DC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_55DD_156AD(int loadOffset)
    {
    label_100D_55DD_156AD_37193:
        CheckExternalEvents(cs1, 0x55DD);
        // 100D:55DD push DS
        Stack.Push16(DS);
        // 100D:55DE or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:55E0 je short 0x5603
        if (ZeroFlag)
        {
            goto label_100D_5603_156D3_37203;
        }
    label_100D_55E2_156B2_37205:
        CheckExternalEvents(cs1, 0x55E2);
        // 100D:55E2 les DI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_55E2_156B2 = (ushort)0xDBB0;
        ushort lxsValue_100D_55E2_156B2 = UInt16[DS, lxsOffset_100D_55E2_156B2];
        ushort lxsSegment_100D_55E2_156B2 = UInt16[DS, (ushort)(lxsOffset_100D_55E2_156B2 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_55E2_156B2);
        ES = unchecked((ushort)lxsSegment_100D_55E2_156B2);
        // 100D:55E6 mov DS,word ptr DS:[0xDD00]
        DS = UInt16[DS, (ushort)0xDD00];
        // 100D:55EA mov CX,0xC5F9
        CX = (ushort)0xC5F9;
    label_100D_55ED_156BD_37213:
        CheckExternalEvents(cs1, 0x55ED);
        // 100D:55ED repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_55ED_156BD = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_55ED_156BD)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_55ED_156BD = ZeroFlag == false;
        }
        // 100D:55EF jne short 0x5603
        if (!ZeroFlag)
        {
            goto label_100D_5603_156D3_37203;
        }
    label_100D_55F1_156C1_37216:
        CheckExternalEvents(cs1, 0x55F1);
        // 100D:55F1 mov AH,byte ptr DS:[DI-1]
        AH = UInt8[DS, (ushort)(DI + (sbyte)-1)];
        // 100D:55F4 and AH,0x30
        AH = Alu8.And(AH, (byte)0x30);
        // 100D:55F7 cmp AH,0x30
        Alu8.Sub(AH, (byte)0x30);
        // 100D:55FA jne short 0x5600
        if (!ZeroFlag)
        {
            goto label_100D_5600_156D0_37221;
        }
    label_100D_55FC_156CC_37223:
        CheckExternalEvents(cs1, 0x55FC);
        // 100D:55FC and byte ptr DS:[DI-1],0xEF
        UInt8[DS, (ushort)(DI + (sbyte)-1)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)-1)], (byte)0xEF);
    label_100D_5600_156D0_37221:
        CheckExternalEvents(cs1, 0x5600);
        // 100D:5600 inc CX
        CX = Alu16.Inc(CX);
        // 100D:5601 loop 0x55ED
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_55ED_156BD_37213;
        }
    label_100D_5603_156D3_37203:
        CheckExternalEvents(cs1, 0x5603);
        // 100D:5603 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:5604 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5605_156D5(int loadOffset)
    {
    label_100D_5605_156D5_28684:
        CheckExternalEvents(cs1, 0x5605);
        // 100D:5605 sub SP,8
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:5608 mov SI,0x4710
        SI = (ushort)0x4710;
        // 100D:560B mov DI,SP
        DI = SP;
        // 100D:560D push DS
        Stack.Push16(DS);
        // 100D:560E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:560F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:5610 add AX,6
        AX = Alu16.Add(AX, (ushort)0x0006);
        // 100D:5613 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5614 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:5615 add AX,0x0062
        AX = Alu16.Add(AX, (ushort)0x0062);
        // 100D:5618 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5619 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:561A sub AX,6
        AX = Alu16.Sub(AX, (ushort)0x0006);
        // 100D:561D stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:561E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:561F sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:5622 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5623 lea SI,DI-8
        SI = unchecked((ushort)(DI + (sbyte)-8));
        // 100D:5626 mov AL,0xF5
        AL = (byte)0xF5;
        // 100D:5628 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:562C call far dword ptr DS:[0x38DD]
        ushort targetSegment_28705 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_28705 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_28705 == cs2 && targetOffset_28705 == 0x011E)
        {
            FarCall(cs1, 0x5630, cs2, unknown_3358_011E_3369E);
            goto label_100D_5630_15700_28706;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_28705:X4}:{targetOffset_28705:X4} at 100D:562C");
    label_100D_5630_15700_28706:
        CheckExternalEvents(cs1, 0x5630);
        // 100D:5630 mov byte ptr DS:[0x4724],0xFF
        UInt8[DS, (ushort)0x4724] = (byte)0xFF;
        // 100D:5635 call near 0xD075
        NearCall(cs1, 0x5638, unknown_100D_D075_1D145);
    label_100D_5638_15708_28709:
        CheckExternalEvents(cs1, 0x5638);
        // 100D:5638 add SP,8
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:563B jmp near 0x557B
        return unknown_100D_557B_1564B(0x0000);
    }

    public virtual Action unknown_100D_563E_1570E(int loadOffset)
    {
    label_100D_563E_1570E_28714:
        CheckExternalEvents(cs1, 0x563E);
        // 100D:563E add BX,0x0062
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)98)));
        // 100D:5641 add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:5644 mov CX,0xF5FE
        CX = (ushort)0xF5FE;
        // 100D:5647 mov byte ptr DS:[0x4725],CL
        UInt8[DS, (ushort)0x4725] = CL;
        // 100D:564B cmp byte ptr DS:[0x4722],0
        Alu8.Sub(UInt8[DS, (ushort)0x4722], (byte)0x00);
        // 100D:5650 jne short 0x568C
        if (!ZeroFlag)
        {
            goto label_100D_568C_1575C_31145;
        }
    label_100D_5652_15722_28721:
        CheckExternalEvents(cs1, 0x5652);
        // 100D:5652 push DX
        Stack.Push16(DX);
        // 100D:5653 mov AX,0x0065
        AX = (ushort)0x0065;
        // 100D:5656 call near 0xD194
        NearCall(cs1, 0x5659, unknown_100D_D194_1D264);
    label_100D_5659_15729_28725:
        CheckExternalEvents(cs1, 0x5659);
        // 100D:5659 pop AX
        AX = Stack.Pop16();
        // 100D:565A add AX,0x0053
        AX = Alu16.Add(AX, (ushort)0x0053);
        // 100D:565D mov word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = AX;
        // 100D:5660 mov AL,0x2D
        AL = (byte)0x2D;
        // 100D:5662 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x5666, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:5662");
        }
    label_100D_5666_15736_28731:
        CheckExternalEvents(cs1, 0x5666);
        // 100D:5666 add word ptr DS:[0xD82C],0x0041
        UInt16[DS, (ushort)0xD82C] = Alu16.Add(UInt16[DS, (ushort)0xD82C], unchecked((ushort)unchecked((short)(sbyte)65)));
        // 100D:566B mov AL,0x2B
        AL = (byte)0x2B;
        // 100D:566D call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x5671, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:566D");
        }
    label_100D_5671_15741_28735:
        CheckExternalEvents(cs1, 0x5671);
        // 100D:5671 call near 0xC13B
        NearCall(cs1, 0x5674, unknown_100D_C13B_1C20B);
    label_100D_5674_15744_28737:
        CheckExternalEvents(cs1, 0x5674);
        // 100D:5674 call near 0x557B
        NearCall(cs1, 0x5677, unknown_100D_557B_1564B);
    label_100D_5677_15747_28739:
        CheckExternalEvents(cs1, 0x5677);
        // 100D:5677 add DX,0x005F
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)95)));
        // 100D:567A add BX,0x0063
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)99)));
        // 100D:567D mov AX,0x0080
        AX = (ushort)0x0080;
        // 100D:5680 call near 0xC2FD
        NearCall(cs1, 0x5683, unknown_100D_C2FD_1C3CD);
    label_100D_5683_15753_28744:
        CheckExternalEvents(cs1, 0x5683);
        // 100D:5683 add DX,0x003C
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)60)));
        // 100D:5686 mov AX,0x0081
        AX = (ushort)0x0081;
        // 100D:5689 jmp near 0xC22F
        return unknown_100D_C22F_1C2FF(0x0000);
    label_100D_568C_1575C_31145:
        CheckExternalEvents(cs1, 0x568C);
        // 100D:568C mov AX,0x0068
        AX = (ushort)0x0068;
        // 100D:568F jmp near 0xD194
        return unknown_100D_D194_1D264(0x0000);
    }

    public virtual Action unknown_100D_5692_15762(int loadOffset)
    {
    label_100D_5692_15762_29161:
        CheckExternalEvents(cs1, 0x5692);
        // 100D:5692 push DI
        Stack.Push16(DI);
        // 100D:5693 call near 0x5605
        NearCall(cs1, 0x5696, unknown_100D_5605_156D5);
    label_100D_5696_15766_29164:
        CheckExternalEvents(cs1, 0x5696);
        // 100D:5696 pop DI
        DI = Stack.Pop16();
        // 100D:5697 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5699 je short 0x563E
        if (ZeroFlag)
        {
            return unknown_100D_563E_1570E(0x0000);
        }
    label_100D_569B_1576B_29168:
        CheckExternalEvents(cs1, 0x569B);
        // 100D:569B add BX,0x0062
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)98)));
        // 100D:569E add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:56A1 mov CX,0xF5FE
        CX = (ushort)0xF5FE;
        // 100D:56A4 call near 0x629D
        NearCall(cs1, 0x56A7, unknown_100D_629D_1636D);
    label_100D_56A7_15777_29173:
        CheckExternalEvents(cs1, 0x56A7);
        // 100D:56A7 call near 0xD05F
        NearCall(cs1, 0x56AA, unknown_100D_D05F_1D12F);
    label_100D_56AA_1577A_29175:
        CheckExternalEvents(cs1, 0x56AA);
        // 100D:56AA mov CX,0xF5FE
        CX = (ushort)0xF5FE;
        // 100D:56AD call near 0x62A6
        NearCall(cs1, 0x56B0, unknown_100D_62A6_16376);
    label_100D_56B0_15780_29178:
        CheckExternalEvents(cs1, 0x56B0);
        // 100D:56B0 cmp DI,0x0138
        Alu16.Sub(DI, (ushort)0x0138);
        // 100D:56B4 jb short 0x5719
        if (CarryFlag)
        {
            return unknown_100D_5719_157E9(0x0000);
        }
    label_100D_56B6_15786_29181:
        CheckExternalEvents(cs1, 0x56B6);
        // 100D:56B6 cmp byte ptr DS:[DI+8],0x21
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x21);
        // 100D:56BA je short 0x5719
        if (ZeroFlag)
        {
            return unknown_100D_5719_157E9(0x0000);
        }
    label_100D_56BC_1578C_29184:
        CheckExternalEvents(cs1, 0x56BC);
        // 100D:56BC xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:56BE xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:56C0 mov BP,0x5728
        BP = (ushort)0x5728;
        // 100D:56C3 call near 0x6639
        NearCall(cs1, 0x56C6, unknown_100D_6639_16709);
    label_100D_56C6_15796_29203:
        CheckExternalEvents(cs1, 0x56C6);
        // 100D:56C6 mov DX,word ptr DS:[0x4710]
        DX = UInt16[DS, (ushort)0x4710];
        // 100D:56CA add DX,0x0071
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)113)));
        // 100D:56CD mov AX,CX
        AX = CX;
        // 100D:56CF or AX,BX
        AX = Alu16.Or(AX, BX);
        // 100D:56D1 je short 0x571A
        if (ZeroFlag)
        {
            goto label_100D_571A_157EA_29256;
        }
    label_100D_56D3_157A3_29209:
        CheckExternalEvents(cs1, 0x56D3);
        // 100D:56D3 call near 0xC13B
        NearCall(cs1, 0x56D6, unknown_100D_C13B_1C20B);
    label_100D_56D6_157A6_29211:
        CheckExternalEvents(cs1, 0x56D6);
        // 100D:56D6 sub byte ptr DS:[0xDBE4],3
        UInt8[DS, (ushort)0xDBE4] = Alu8.Sub(UInt8[DS, (ushort)0xDBE4], (byte)0x03);
        // 100D:56DB xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:56DD call near 0x56ED
        NearCall(cs1, 0x56E0, unknown_100D_56ED_157BD);
    label_100D_56E0_157B0_29241:
        CheckExternalEvents(cs1, 0x56E0);
        // 100D:56E0 mov BL,CH
        BL = CH;
        // 100D:56E2 mov AX,1
        AX = (ushort)0x0001;
        // 100D:56E5 call near 0x56ED
        NearCall(cs1, 0x56E8, unknown_100D_56ED_157BD);
    label_100D_56E8_157B8_29246:
        CheckExternalEvents(cs1, 0x56E8);
        // 100D:56E8 mov BL,CL
        BL = CL;
        // 100D:56EA mov AX,2
        AX = (ushort)0x0002;
        return unknown_100D_56ED_157BD(0x0000);
    label_100D_571A_157EA_29256:
        CheckExternalEvents(cs1, 0x571A);
        // 100D:571A push DX
        Stack.Push16(DX);
        // 100D:571B call near 0xD05F
        NearCall(cs1, 0x571E, unknown_100D_D05F_1D12F);
    label_100D_571E_157EE_29259:
        CheckExternalEvents(cs1, 0x571E);
        // 100D:571E pop DX
        DX = Stack.Pop16();
        // 100D:571F mov CX,0xF5FB
        CX = (ushort)0xF5FB;
        // 100D:5722 mov AX,0x0066
        AX = (ushort)0x0066;
        // 100D:5725 jmp near 0xD194
        return unknown_100D_D194_1D264(0x0000);
    }

    public virtual Action unknown_100D_56ED_157BD(int loadOffset)
    {
    label_100D_56ED_157BD_29215:
        CheckExternalEvents(cs1, 0x56ED);
        // 100D:56ED or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:56EF je short 0x5719
        if (ZeroFlag)
        {
            return unknown_100D_5719_157E9(0x0000);
        }
    label_100D_56F1_157C1_29218:
        CheckExternalEvents(cs1, 0x56F1);
        // 100D:56F1 push CX
        Stack.Push16(CX);
        // 100D:56F2 push DX
        Stack.Push16(DX);
        // 100D:56F3 push BX
        Stack.Push16(BX);
        // 100D:56F4 mov BX,word ptr DS:[0x4712]
        BX = UInt16[DS, (ushort)0x4712];
        // 100D:56F8 add BX,0x0062
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)98)));
        // 100D:56FB add AX,0x0082
        AX = Alu16.Add(AX, (ushort)0x0082);
        // 100D:56FE call near 0xC2FD
        NearCall(cs1, 0x5701, unknown_100D_C2FD_1C3CD);
    label_100D_5701_157D1_29226:
        CheckExternalEvents(cs1, 0x5701);
        // 100D:5701 add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:5704 call near 0xD04E
        NearCall(cs1, 0x5707, unknown_100D_D04E_1D11E);
    label_100D_5707_157D7_29229:
        CheckExternalEvents(cs1, 0x5707);
        // 100D:5707 mov AL,0x3A
        AL = (byte)0x3A;
        // 100D:5709 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x570D, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:5709");
        }
    label_100D_570D_157DD_29232:
        CheckExternalEvents(cs1, 0x570D);
        // 100D:570D pop AX
        AX = Stack.Pop16();
        // 100D:570E add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        // 100D:5710 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x5714, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:5710");
        }
    label_100D_5714_157E4_29236:
        CheckExternalEvents(cs1, 0x5714);
        // 100D:5714 pop DX
        DX = Stack.Pop16();
        // 100D:5715 pop CX
        CX = Stack.Pop16();
        // 100D:5716 add DX,0x0012
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)18)));
        return unknown_100D_5719_157E9(0x0000);
    }

    public virtual Action unknown_100D_5728_157F8(int loadOffset)
    {
    label_100D_5728_157F8_29189:
        CheckExternalEvents(cs1, 0x5728);
        // 100D:5728 jae short 0x5745
        if (!CarryFlag)
        {
            goto label_100D_5745_15815_29254;
        }
    label_100D_572A_157FA_29191:
        CheckExternalEvents(cs1, 0x572A);
        // 100D:572A mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:572D and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:572F cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:5731 je short 0x5745
        if (ZeroFlag)
        {
            goto label_100D_5745_15815_29254;
        }
    label_100D_5733_15803_29196:
        CheckExternalEvents(cs1, 0x5733);
        // 100D:5733 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:5735 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:5737 jne short 0x573C
        if (!ZeroFlag)
        {
            goto label_100D_573C_1580C_33533;
        }
    label_100D_5739_15809_29200:
        CheckExternalEvents(cs1, 0x5739);
        // 100D:5739 inc BL
        BL = Alu8.Inc(BL);
        // 100D:573B ret near
        return NearRet((ushort)0x0000);
    label_100D_573C_1580C_33533:
        CheckExternalEvents(cs1, 0x573C);
        // 100D:573C cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:573E jne short 0x5743
        if (!ZeroFlag)
        {
            goto label_100D_5743_15813_39730;
        }
    label_100D_5740_15810_33536:
        CheckExternalEvents(cs1, 0x5740);
        // 100D:5740 inc CH
        CH = Alu8.Inc(CH);
        // 100D:5742 ret near
        return NearRet((ushort)0x0000);
    label_100D_5743_15813_39730:
        CheckExternalEvents(cs1, 0x5743);
        // 100D:5743 inc CL
        CL = Alu8.Inc(CL);
    label_100D_5745_15815_29254:
        CheckExternalEvents(cs1, 0x5745);
        // 100D:5745 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5746_15816(int loadOffset)
    {
    label_100D_5746_15816_28926:
        CheckExternalEvents(cs1, 0x5746);
        // 100D:5746 mov DI,0x4710
        DI = (ushort)0x4710;
        // 100D:5749 call near 0xD6FE
        NearCall(cs1, 0x574C, unknown_100D_D6FE_1D7CE);
    label_100D_574C_1581C_28929:
        CheckExternalEvents(cs1, 0x574C);
        // 100D:574C jae short 0x57B2
        if (!CarryFlag)
        {
            return unknown_100D_57B2_15882(0x0000);
        }
    label_100D_574E_1581E_28949:
        CheckExternalEvents(cs1, 0x574E);
        // 100D:574E mov AX,word ptr DS:[0x4716]
        AX = UInt16[DS, (ushort)0x4716];
        // 100D:5751 sub AX,0x000A
        AX = Alu16.Sub(AX, (ushort)0x000A);
        // 100D:5754 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:5756 jae short 0x57AD
        if (!CarryFlag)
        {
            goto label_100D_57AD_1587D_28954;
        }
    label_100D_5758_15828_28978:
        CheckExternalEvents(cs1, 0x5758);
        // 100D:5758 call near 0x57B2
        NearCall(cs1, 0x575B, unknown_100D_57B2_15882);
    label_100D_575B_1582B_28980:
        CheckExternalEvents(cs1, 0x575B);
        // 100D:575B cmp byte ptr DS:[0x4722],0
        Alu8.Sub(UInt8[DS, (ushort)0x4722], (byte)0x00);
        // 100D:5760 jne short 0x578A
        if (!ZeroFlag)
        {
            return unknown_100D_578A_1585A(0x0000);
        }
    label_100D_5762_15832_28983:
        CheckExternalEvents(cs1, 0x5762);
        // 100D:5762 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:5766 call far dword ptr DS:[0x3965]
        ushort targetSegment_28985 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3965 + (ushort)0x0002)]));
        ushort targetOffset_28985 = unchecked((ushort)(UInt16[DS, (ushort)0x3965]));
        if (targetSegment_28985 == cs2 && targetOffset_28985 == 0x0184)
        {
            FarCall(cs1, 0x576A, cs2, unknown_3358_0184_33704);
            goto label_100D_576A_1583A_28993;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_28985:X4}:{targetOffset_28985:X4} at 100D:5766");
    label_100D_576A_1583A_28993:
        CheckExternalEvents(cs1, 0x576A);
        // 100D:576A sub AL,0x50
        AL = Alu8.Sub(AL, (byte)0x50);
        // 100D:576C cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:576E jb short 0x5772
        if (CarryFlag)
        {
            goto label_100D_5772_15842_28999;
        }
    label_100D_5770_15840_28997:
        CheckExternalEvents(cs1, 0x5770);
        // 100D:5770 mov AL,0xFF
        AL = (byte)0xFF;
    label_100D_5772_15842_28999:
        CheckExternalEvents(cs1, 0x5772);
        // 100D:5772 mov AH,AL
        AH = AL;
        // 100D:5774 xchg AL,byte ptr DS:[0x4724]
        ushort xchgOffset_100D_5774_15844 = (ushort)0x4724;
        byte temp_100D_5774_15844 = AL;
        AL = UInt8[DS, xchgOffset_100D_5774_15844];
        UInt8[DS, xchgOffset_100D_5774_15844] = unchecked((byte)temp_100D_5774_15844);
        // 100D:5778 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:577A je short 0x578A
        if (ZeroFlag)
        {
            return unknown_100D_578A_1585A(0x0000);
        }
    label_100D_577C_1584C_29111:
        CheckExternalEvents(cs1, 0x577C);
        // 100D:577C call near 0xDBB2
        NearCall(cs1, 0x577F, unknown_100D_DBB2_1DC82);
    label_100D_577F_1584F_29113:
        CheckExternalEvents(cs1, 0x577F);
        // 100D:577F call near 0x578B
        NearCall(cs1, 0x5782, unknown_100D_578B_1585B);
    label_100D_5782_15852_29118:
        CheckExternalEvents(cs1, 0x5782);
        // 100D:5782 mov AL,AH
        AL = AH;
        // 100D:5784 call near 0x578B
        NearCall(cs1, 0x5787, unknown_100D_578B_1585B);
    label_100D_5787_15857_29148:
        CheckExternalEvents(cs1, 0x5787);
        // 100D:5787 call near 0xDBEC
        NearCall(cs1, 0x578A, unknown_100D_DBEC_1DCBC);
        return unknown_100D_578A_1585A(0x0000);
    label_100D_57AD_1587D_28954:
        CheckExternalEvents(cs1, 0x57AD);
        // 100D:57AD mov CX,0xFEF5
        CX = (ushort)0xFEF5;
        // 100D:57B0 jmp short 0x57B5
        return unknown_100D_578A_1585A(0x57B5);
    }

    public virtual Action unknown_100D_578B_1585B(int loadOffset)
    {
    label_100D_578B_1585B_29115:
        CheckExternalEvents(cs1, 0x578B);
        // 100D:578B or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:578D js short 0x578A
        if (SignFlag)
        {
            return unknown_100D_578A_1585A(0x0000);
        }
    label_100D_578F_1585F_29121:
        CheckExternalEvents(cs1, 0x578F);
        // 100D:578F push AX
        Stack.Push16(AX);
        // 100D:5790 call near 0x557B
        NearCall(cs1, 0x5793, unknown_100D_557B_1564B);
    label_100D_5793_15863_29124:
        CheckExternalEvents(cs1, 0x5793);
        // 100D:5793 add DX,0x005E
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)94)));
        // 100D:5796 add BX,0x0062
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)98)));
        // 100D:5799 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:579B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:579D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:579F add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:57A1 mov SI,5
        SI = (ushort)0x0005;
        // 100D:57A4 mov CX,7
        CX = (ushort)0x0007;
        // 100D:57A7 call far dword ptr DS:[0x3961]
        ushort targetSegment_29133 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3961 + (ushort)0x0002)]));
        ushort targetOffset_29133 = unchecked((ushort)(UInt16[DS, (ushort)0x3961]));
        if (targetSegment_29133 == cs2 && targetOffset_29133 == 0x0181)
        {
            FarCall(cs1, 0x57AB, cs2, unknown_3358_0181_33701);
            goto label_100D_57AB_1587B_29145;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_29133:X4}:{targetOffset_29133:X4} at 100D:57A7");
    label_100D_57AB_1587B_29145:
        CheckExternalEvents(cs1, 0x57AB);
        // 100D:57AB pop AX
        AX = Stack.Pop16();
        // 100D:57AC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_57B2_15882(int loadOffset)
    {
    label_100D_57B2_15882_28931:
        CheckExternalEvents(cs1, 0x57B2);
        // 100D:57B2 mov CX,0xF5FE
        CX = (ushort)0xF5FE;
        return unknown_100D_578A_1585A(0x57B5);
    }

    public virtual Action unknown_100D_57E5_158B5(int loadOffset)
    {
    label_100D_57E5_158B5_28536:
        CheckExternalEvents(cs1, 0x57E5);
        // 100D:57E5 call near 0xE270
        NearCall(cs1, 0x57E8, unknown_100D_E270_1E340);
    label_100D_57E8_158B8_28538:
        CheckExternalEvents(cs1, 0x57E8);
        // 100D:57E8 push ES
        Stack.Push16(ES);
        // 100D:57E9 mov AX,0x003A
        AX = (ushort)0x003A;
        // 100D:57EC call near 0xC13E
        NearCall(cs1, 0x57EF, unknown_100D_C13E_1C20E);
    label_100D_57EF_158BF_28542:
        CheckExternalEvents(cs1, 0x57EF);
        // 100D:57EF push DS
        Stack.Push16(DS);
        // 100D:57F0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:57F1 mov DI,BP
        DI = BP;
        // 100D:57F3 mov AL,0x70
        AL = (byte)0x70;
        // 100D:57F5 mov CX,0x0100
        CX = (ushort)0x0100;
        // 100D:57F8 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:57FA cmp byte ptr DS:[0x4722],0
        Alu8.Sub(UInt8[DS, (ushort)0x4722], (byte)0x00);
        // 100D:57FF jne short 0x583F
        if (!ZeroFlag)
        {
            goto label_100D_583F_1590F_31014;
        }
    label_100D_5801_158D1_28551:
        CheckExternalEvents(cs1, 0x5801);
        // 100D:5801 mov SI,0x0100
        SI = (ushort)0x0100;
        // 100D:5804 mov DI,BP
        DI = BP;
        // 100D:5806 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_5808_158D8_28555:
        CheckExternalEvents(cs1, 0x5808);
        // 100D:5808 mov AL,byte ptr DS:[SI+0x0A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)10)];
        // 100D:580B test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:580D jne short 0x5832
        if (!ZeroFlag)
        {
            goto label_100D_5832_15902_28571;
        }
    label_100D_580F_158DF_28558:
        CheckExternalEvents(cs1, 0x580F);
        // 100D:580F mov BL,byte ptr DS:[SI+0x10]
        BL = UInt8[DS, (ushort)(SI + (sbyte)16)];
        // 100D:5812 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:5814 pushf
        Stack.Push16(FlagRegister16);
        // 100D:5815 mov AL,0x75
        AL = (byte)0x75;
        // 100D:5817 test byte ptr DS:[0x2942],2
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x02);
        // 100D:581C je short 0x5820
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:581C");
        }
    label_100D_5820_158F0_28565:
        CheckExternalEvents(cs1, 0x5820);
        // 100D:5820 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_5821_158F1_28567:
        CheckExternalEvents(cs1, 0x5821);
        // 100D:5821 je short 0x5830
        if (ZeroFlag)
        {
            goto label_100D_5830_15900_28569;
        }
    label_100D_5823_158F3_28576:
        CheckExternalEvents(cs1, 0x5823);
        // 100D:5823 mov AL,byte ptr DS:[SI+0x12]
        AL = UInt8[DS, (ushort)(SI + (sbyte)18)];
        // 100D:5826 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:5828 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:582A shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:582C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:582E add AL,0x50
        AL = Alu8.Add(AL, (byte)0x50);
    label_100D_5830_15900_28569:
        CheckExternalEvents(cs1, 0x5830);
        // 100D:5830 mov byte ptr DS:[BX+DI],AL
        UInt8[DS, (ushort)(BX + DI)] = AL;
    label_100D_5832_15902_28571:
        CheckExternalEvents(cs1, 0x5832);
        // 100D:5832 add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:5835 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:5838 jne short 0x5808
        if (!ZeroFlag)
        {
            goto label_100D_5808_158D8_28555;
        }
    label_100D_583A_1590A_28583:
        CheckExternalEvents(cs1, 0x583A);
        // 100D:583A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:583B call near 0xE283
        NearCall(cs1, 0x583E, unknown_100D_E283_1E353);
    label_100D_583E_1590E_28586:
        CheckExternalEvents(cs1, 0x583E);
        // 100D:583E ret near
        return NearRet((ushort)0x0000);
    label_100D_583F_1590F_31014:
        CheckExternalEvents(cs1, 0x583F);
        // 100D:583F mov DI,0x0100
        DI = (ushort)0x0100;
    label_100D_5842_15912_31016:
        CheckExternalEvents(cs1, 0x5842);
        // 100D:5842 mov AL,byte ptr DS:[DI+0x0A]
        AL = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:5845 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:5847 jne short 0x5861
        if (!ZeroFlag)
        {
            goto label_100D_5861_15931_31050;
        }
    label_100D_5849_15919_31019:
        CheckExternalEvents(cs1, 0x5849);
        // 100D:5849 push BP
        Stack.Push16(BP);
        // 100D:584A xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:584C xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:584E mov BP,0x5728
        BP = (ushort)0x5728;
        // 100D:5851 call near 0x6639
        NearCall(cs1, 0x5854, unknown_100D_6639_16709);
    label_100D_5854_15924_31025:
        CheckExternalEvents(cs1, 0x5854);
        // 100D:5854 pop BP
        BP = Stack.Pop16();
        // 100D:5855 call near 0x586E
        NearCall(cs1, 0x5858, unknown_100D_586E_1593E);
    label_100D_5858_15928_31045:
        CheckExternalEvents(cs1, 0x5858);
        // 100D:5858 mov AL,byte ptr DS:[DI+0x10]
        AL = UInt8[DS, (ushort)(DI + (sbyte)16)];
        // 100D:585B xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:585D mov SI,AX
        SI = AX;
        // 100D:585F mov byte ptr SS:[BP+SI],BH
        UInt8[SS, (ushort)(BP + SI)] = BH;
    label_100D_5861_15931_31050:
        CheckExternalEvents(cs1, 0x5861);
        // 100D:5861 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:5864 cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:5867 jne short 0x5842
        if (!ZeroFlag)
        {
            goto label_100D_5842_15912_31016;
        }
    label_100D_5869_15939_31060:
        CheckExternalEvents(cs1, 0x5869);
        // 100D:5869 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:586A call near 0xE283
        NearCall(cs1, 0x586D, unknown_100D_E283_1E353);
    label_100D_586D_1593D_31063:
        CheckExternalEvents(cs1, 0x586D);
        // 100D:586D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_586E_1593E(int loadOffset)
    {
    label_100D_586E_1593E_31028:
        CheckExternalEvents(cs1, 0x586E);
        // 100D:586E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:5870 or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:5872 je short 0x5876
        if (ZeroFlag)
        {
            goto label_100D_5876_15946_31032;
        }
    label_100D_5874_15944_31055:
        CheckExternalEvents(cs1, 0x5874);
        // 100D:5874 mov AL,1
        AL = (byte)0x01;
    label_100D_5876_15946_31032:
        CheckExternalEvents(cs1, 0x5876);
        // 100D:5876 or CH,CH
        CH = Alu8.Or(CH, CH);
        // 100D:5878 je short 0x587C
        if (ZeroFlag)
        {
            goto label_100D_587C_1594C_31035;
        }
    label_100D_587A_1594A_35428:
        CheckExternalEvents(cs1, 0x587A);
        // 100D:587A add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
    label_100D_587C_1594C_31035:
        CheckExternalEvents(cs1, 0x587C);
        // 100D:587C or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:587E je short 0x5882
        if (ZeroFlag)
        {
            goto label_100D_5882_15952_31038;
        }
    label_100D_5880_15950_39890:
        CheckExternalEvents(cs1, 0x5880);
        // 100D:5880 add AL,4
        AL = Alu8.Add(AL, (byte)0x04);
    label_100D_5882_15952_31038:
        CheckExternalEvents(cs1, 0x5882);
        // 100D:5882 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:5884 mov SI,AX
        SI = AX;
        // 100D:5886 jmp near word ptr CS:[SI+0x588B]
        switch ((ushort)(UInt16[CS, (ushort)(SI + (short)22667)]))
        {
            case 0x589B:
                break;
            case 0x589E:
                goto label_100D_589E_1596E_31057;
            case 0x58A1:
                goto label_100D_58A1_15971_35430;
            case 0x58A4:
                goto label_100D_58A4_15974_37306;
            case 0x58B1:
                goto label_100D_58B1_15981_40000;
            case 0x58B4:
                goto label_100D_58B4_15984_40102;
            case 0x58C1:
                goto label_100D_58C1_15991_39893;
            case 0x58CE:
                goto label_100D_58CE_1599E_40526;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(SI + (short)22667)])):X4} at 100D:5886");
        }
    label_100D_589B_1596B_31042:
        CheckExternalEvents(cs1, 0x589B);
        // 100D:589B xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:589D ret near
        return NearRet((ushort)0x0000);
    label_100D_589E_1596E_31057:
        CheckExternalEvents(cs1, 0x589E);
        // 100D:589E mov BH,0x55
        BH = (byte)0x55;
        // 100D:58A0 ret near
        return NearRet((ushort)0x0000);
    label_100D_58A1_15971_35430:
        CheckExternalEvents(cs1, 0x58A1);
        // 100D:58A1 mov BH,0xAA
        BH = (byte)0xAA;
        // 100D:58A3 ret near
        return NearRet((ushort)0x0000);
    label_100D_58A4_15974_37306:
        CheckExternalEvents(cs1, 0x58A4);
        // 100D:58A4 mov BH,0x66
        BH = (byte)0x66;
        // 100D:58A6 cmp BL,CH
        Alu8.Sub(BL, CH);
        // 100D:58A8 je short 0x58B0
        if (ZeroFlag)
        {
            goto label_100D_58B0_15980_37310;
        }
    label_100D_58AA_1597A_38065:
        CheckExternalEvents(cs1, 0x58AA);
        // 100D:58AA mov BH,0x9A
        BH = (byte)0x9A;
        // 100D:58AC jb short 0x58B0
        if (CarryFlag)
        {
            goto label_100D_58B0_15980_37310;
        }
    label_100D_58AE_1597E_38069:
        CheckExternalEvents(cs1, 0x58AE);
        // 100D:58AE not BH
        BH = unchecked((byte)~BH);
    label_100D_58B0_15980_37310:
        CheckExternalEvents(cs1, 0x58B0);
        // 100D:58B0 ret near
        return NearRet((ushort)0x0000);
    label_100D_58B1_15981_40000:
        CheckExternalEvents(cs1, 0x58B1);
        // 100D:58B1 mov BH,0xFF
        BH = (byte)0xFF;
        // 100D:58B3 ret near
        return NearRet((ushort)0x0000);
    label_100D_58B4_15984_40102:
        CheckExternalEvents(cs1, 0x58B4);
        // 100D:58B4 mov BH,0x77
        BH = (byte)0x77;
        // 100D:58B6 cmp BL,CL
        Alu8.Sub(BL, CL);
        // 100D:58B8 je short 0x58C0
        if (ZeroFlag)
        {
            goto label_100D_58C0_15990_40106;
        }
    label_100D_58BA_1598A_40108:
        CheckExternalEvents(cs1, 0x58BA);
        // 100D:58BA mov BH,0xDF
        BH = (byte)0xDF;
        // 100D:58BC jb short 0x58C0
        if (CarryFlag)
        {
            goto label_100D_58C0_15990_40106;
        }
    label_100D_58BE_1598E_40112:
        CheckExternalEvents(cs1, 0x58BE);
        // 100D:58BE mov BH,0x75
        BH = (byte)0x75;
    label_100D_58C0_15990_40106:
        CheckExternalEvents(cs1, 0x58C0);
        // 100D:58C0 ret near
        return NearRet((ushort)0x0000);
    label_100D_58C1_15991_39893:
        CheckExternalEvents(cs1, 0x58C1);
        // 100D:58C1 mov BH,0xBB
        BH = (byte)0xBB;
        // 100D:58C3 cmp CH,CL
        Alu8.Sub(CH, CL);
        // 100D:58C5 je short 0x58CD
        if (ZeroFlag)
        {
            goto label_100D_58CD_1599D_39897;
        }
    label_100D_58C7_15997_39899:
        CheckExternalEvents(cs1, 0x58C7);
        VerifySpeculativeEntryOrFail(cs1, 0x58C7, [(byte)0xB7, (byte)0xEF]);
        // 100D:58C7 mov BH,0xEF
        BH = (byte)0xEF;
        VerifySpeculativeEntryOrFail(cs1, 0x58C9, [(byte)0x72, (byte)0x02]);
        // 100D:58C9 jb short 0x58CD
        if (CarryFlag)
        {
            goto label_100D_58CD_1599D_39897;
        }
    label_100D_58CB_1599B_39903:
        CheckExternalEvents(cs1, 0x58CB);
        VerifySpeculativeEntryOrFail(cs1, 0x58CB, [(byte)0xB7, (byte)0xBA]);
        // 100D:58CB mov BH,0xBA
        BH = (byte)0xBA;
    label_100D_58CD_1599D_39897:
        CheckExternalEvents(cs1, 0x58CD);
        // 100D:58CD ret near
        return NearRet((ushort)0x0000);
    label_100D_58CE_1599E_40526:
        CheckExternalEvents(cs1, 0x58CE);
        // 100D:58CE cmp BL,CH
        Alu8.Sub(BL, CH);
        // 100D:58D0 jae short 0x58DB
        if (!CarryFlag)
        {
            goto label_100D_58DB_159AB_40529;
        }
    label_100D_58D2_159A2_40531:
        CheckExternalEvents(cs1, 0x58D2);
        VerifySpeculativeEntryOrFail(cs1, 0x58D2, [(byte)0xB7, (byte)0xDE]);
        // 100D:58D2 mov BH,0xDE
        BH = (byte)0xDE;
        VerifySpeculativeEntryOrFail(cs1, 0x58D4, [(byte)0x3A, (byte)0xE9]);
        // 100D:58D4 cmp CH,CL
        Alu8.Sub(CH, CL);
        VerifySpeculativeEntryOrFail(cs1, 0x58D6, [(byte)0x72, (byte)0x02]);
        // 100D:58D6 jb short 0x58DA
        if (CarryFlag)
        {
            goto label_100D_58DA_159AA_40541;
        }
    label_100D_58D8_159A8_40543:
        CheckExternalEvents(cs1, 0x58D8);
        VerifySpeculativeEntryOrFail(cs1, 0x58D8, [(byte)0xB7, (byte)0x9B]);
        // 100D:58D8 mov BH,0x9B
        BH = (byte)0x9B;
    label_100D_58DA_159AA_40541:
        CheckExternalEvents(cs1, 0x58DA);
        VerifySpeculativeEntryOrFail(cs1, 0x58DA, [(byte)0xC3]);
        // 100D:58DA ret near
        return NearRet((ushort)0x0000);
    label_100D_58DB_159AB_40529:
        CheckExternalEvents(cs1, 0x58DB);
        // 100D:58DB mov BH,0x7B
        BH = (byte)0x7B;
        // 100D:58DD cmp BL,CL
        Alu8.Sub(BL, CL);
        // 100D:58DF jb short 0x58E3
        if (CarryFlag)
        {
            goto label_100D_58E3_159B3_40537;
        }
    label_100D_58E1_159B1_40539:
        CheckExternalEvents(cs1, 0x58E1);
        // 100D:58E1 mov BH,0x67
        BH = (byte)0x67;
    label_100D_58E3_159B3_40537:
        CheckExternalEvents(cs1, 0x58E3);
        // 100D:58E3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_58E4_159B4(int loadOffset)
    {
    label_100D_58E4_159B4_28532:
        CheckExternalEvents(cs1, 0x58E4);
        // 100D:58E4 sub SP,0x0100
        SP = Alu16.Sub(SP, (ushort)0x0100);
        // 100D:58E8 mov BP,SP
        BP = SP;
        // 100D:58EA call near 0x57E5
        NearCall(cs1, 0x58ED, unknown_100D_57E5_158B5);
    label_100D_58ED_159BD_28588:
        CheckExternalEvents(cs1, 0x58ED);
        // 100D:58ED mov BH,byte ptr DS:[0x4722]
        BH = UInt8[DS, (ushort)0x4722];
        // 100D:58F1 call far dword ptr DS:[0x395D]
        ushort targetSegment_28590 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x395D + (ushort)0x0002)]));
        ushort targetOffset_28590 = unchecked((ushort)(UInt16[DS, (ushort)0x395D]));
        if (targetSegment_28590 == cs2 && targetOffset_28590 == 0x017E)
        {
            FarCall(cs1, 0x58F5, cs2, unknown_3358_017E_336FE);
            goto label_100D_58F5_159C5_28666;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_28590:X4}:{targetOffset_28590:X4} at 100D:58F1");
    label_100D_58F5_159C5_28666:
        CheckExternalEvents(cs1, 0x58F5);
        // 100D:58F5 add SP,0x0100
        SP = Alu16.Add(SP, (ushort)0x0100);
        // 100D:58F9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_58FA_159CA(int loadOffset)
    {
    entrydispatcher:
    label_100D_58FA_159CA_23605:
        CheckExternalEvents(cs1, 0x58FA);
        // 100D:58FA test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:58FF je short 0x5922
        if (ZeroFlag)
        {
            return unknown_100D_5922_159F2(0x0000);
        }
    label_100D_5901_159D1_29005:
        CheckExternalEvents(cs1, 0x5901);
        // 100D:5901 call near 0xE270
        NearCall(cs1, 0x5904, unknown_100D_E270_1E340);
    label_100D_5904_159D4_29007:
        CheckExternalEvents(cs1, 0x5904);
        // 100D:5904 and byte ptr DS:[0x46EB],0xBF
        UInt8[DS, (ushort)0x46EB] = Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0xBF);
        // 100D:5909 mov DI,0xDBE0
        DI = (ushort)0xDBE0;
        // 100D:590C cmp word ptr DS:[DI],0x4710
        Alu16.Sub(UInt16[DS, DI], (ushort)0x4710);
        // 100D:5910 je short 0x5915
        if (ZeroFlag)
        {
            goto label_100D_5915_159E5_29014;
        }
    label_100D_5912_159E2_29012:
        CheckExternalEvents(cs1, 0x5912);
        // 100D:5912 mov DI,0xDBE2
        DI = (ushort)0xDBE2;
    label_100D_5915_159E5_29014:
        CheckExternalEvents(cs1, 0x5915);
        // 100D:5915 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:5917 xchg SI,word ptr DS:[DI]
        ushort xchgOffset_100D_5917_159E7 = DI;
        ushort temp_100D_5917_159E7 = SI;
        SI = UInt16[DS, xchgOffset_100D_5917_159E7];
        UInt16[DS, xchgOffset_100D_5917_159E7] = unchecked((ushort)temp_100D_5917_159E7);
        // 100D:5919 call near 0xC6AD
        NearCall(cs1, 0x591C, unknown_100D_C6AD_1C77D);
    label_100D_591C_159EC_29018:
        CheckExternalEvents(cs1, 0x591C);
        // 100D:591C call near 0x5AD9
        NearCall(cs1, 0x591F, unknown_100D_5AD9_15BA9);
    label_100D_591F_159EF_29020:
        CheckExternalEvents(cs1, 0x591F);
        // 100D:591F call near 0xE283
        NearCall(cs1, 0x5922, unknown_100D_E283_1E353);
        return unknown_100D_5922_159F2(0x0000);
    }

    public virtual Action unknown_100D_5944_15A14(int loadOffset)
    {
    entrydispatcher:
    label_100D_5944_15A14_29273:
        CheckExternalEvents(cs1, 0x5944);
        // 100D:5944 mov AX,BX
        AX = BX;
        // 100D:5946 sub AX,word ptr DS:[0x4712]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4712]);
        // 100D:594A sub AX,7
        AX = Alu16.Sub(AX, (ushort)0x0007);
        // 100D:594D jb short 0x5955
        if (CarryFlag)
        {
            goto label_100D_5955_15A25_31150;
        }
    label_100D_594F_15A1F_29278:
        CheckExternalEvents(cs1, 0x594F);
        // 100D:594F sub AX,0x0059
        AX = Alu16.Sub(AX, (ushort)0x0059);
        // 100D:5952 jae short 0x596D
        if (!CarryFlag)
        {
            goto label_100D_596D_15A3D_31010;
        }
    label_100D_5954_15A24_29281:
        CheckExternalEvents(cs1, 0x5954);
        // 100D:5954 ret near
        return NearRet((ushort)0x0000);
    label_100D_5955_15A25_31150:
        CheckExternalEvents(cs1, 0x5955);
        // 100D:5955 add SP,2
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:5958 mov AX,DX
        AX = DX;
        // 100D:595A sub AX,word ptr DS:[0x4710]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4710]);
        // 100D:595E sub AX,0x000A
        AX = Alu16.Sub(AX, (ushort)0x000A);
        // 100D:5961 jae short 0x5978
        if (!CarryFlag)
        {
            goto label_100D_5978_15A48_34695;
        }
    label_100D_5963_15A33_31156:
        CheckExternalEvents(cs1, 0x5963);
        // 100D:5963 call near 0x82A0
        NearCall(cs1, 0x5966, unknown_100D_82A0_18370);
    label_100D_5966_15A36_31168:
        CheckExternalEvents(cs1, 0x5966);
        // 100D:5966 je short 0x596A
        if (ZeroFlag)
        {
            goto label_100D_596A_15A3A_40025;
        }
    label_100D_5968_15A38_31170:
        CheckExternalEvents(cs1, 0x5968);
        // 100D:5968 jmp short 0x58FA
        if (JumpDispatcher.Jump(unknown_100D_58FA_159CA, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_596A_15A3A_40025:
        CheckExternalEvents(cs1, 0x596A);
        // 100D:596A jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_596D_15A3D_31010:
        CheckExternalEvents(cs1, 0x596D);
        // 100D:596D add SP,2
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:5970 xor byte ptr DS:[0x4722],0xFF
        UInt8[DS, (ushort)0x4722] = Alu8.Xor(UInt8[DS, (ushort)0x4722], (byte)0xFF);
        // 100D:5975 jmp near 0x542F
        if (JumpDispatcher.Jump(unknown_100D_542F_154FF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5978_15A48_34695:
        CheckExternalEvents(cs1, 0x5978);
        // 100D:5978 call near 0x82A0
        NearCall(cs1, 0x597B, unknown_100D_82A0_18370);
    label_100D_597B_15A4B_34702:
        CheckExternalEvents(cs1, 0x597B);
        // 100D:597B je short 0x599E
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:597B");
        }
    label_100D_599E_15A6E_34704:
        CheckExternalEvents(cs1, 0x599E);
        // 100D:599E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_599F_15A6F(int loadOffset)
    {
    label_100D_599F_15A6F_18505:
        CheckExternalEvents(cs1, 0x599F);
        // 100D:599F xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:59A1 xchg AL,byte ptr DS:[0x4723]
        ushort xchgOffset_100D_59A1_15A71 = (ushort)0x4723;
        byte temp_100D_59A1_15A71 = AL;
        AL = UInt8[DS, xchgOffset_100D_59A1_15A71];
        UInt8[DS, xchgOffset_100D_59A1_15A71] = unchecked((byte)temp_100D_59A1_15A71);
        // 100D:59A5 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:59A7 je short 0x5A02
        if (ZeroFlag)
        {
            return unknown_100D_5A02_15AD2(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:59A7");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_59C1_15A91(int loadOffset)
    {
    label_100D_59C1_15A91_28187:
        CheckExternalEvents(cs1, 0x59C1);
        // 100D:59C1 cmp byte ptr DS:[0x4723],0
        Alu8.Sub(UInt8[DS, (ushort)0x4723], (byte)0x00);
        // 100D:59C6 je short 0x5A02
        if (ZeroFlag)
        {
            return unknown_100D_5A02_15AD2(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:59C6");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_5A1A_15AEA(int loadOffset)
    {
    entrydispatcher:
    label_100D_5A1A_15AEA_17410:
        CheckExternalEvents(cs1, 0x5A1A);
        // 100D:5A1A mov byte ptr DS:[0x28E7],1
        UInt8[DS, (ushort)0x28E7] = (byte)0x01;
        // 100D:5A1F call near 0x18BA
        NearCall(cs1, 0x5A22, unknown_100D_18BA_1198A);
    label_100D_5A22_15AF2_17413:
        CheckExternalEvents(cs1, 0x5A22);
        // 100D:5A22 call near 0x5B5D
        NearCall(cs1, 0x5A25, unknown_100D_5B5D_15C2D);
    label_100D_5A25_15AF5_17431:
        CheckExternalEvents(cs1, 0x5A25);
        // 100D:5A25 mov BP,0x5A56
        BP = (ushort)0x5A56;
        // 100D:5A28 mov AL,0x34
        AL = (byte)0x34;
        // 100D:5A2A mov DX,0xFFFF
        DX = (ushort)0xFFFF;
        // 100D:5A2D call near 0xC108
        NearCall(cs1, 0x5A30, unknown_100D_C108_1C1D8);
    label_100D_5A30_15B00_18394:
        CheckExternalEvents(cs1, 0x5A30);
        // 100D:5A30 cmp byte ptr DS:[0x46F3],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F3], (byte)0x00);
        // 100D:5A35 jne short 0x5A3A
        if (!ZeroFlag)
        {
            goto label_100D_5A3A_15B0A_18488;
        }
    label_100D_5A37_15B07_18397:
        CheckExternalEvents(cs1, 0x5A37);
        // 100D:5A37 call near 0x5BB0
        NearCall(cs1, 0x5A3A, unknown_100D_5BB0_15C80);
    label_100D_5A3A_15B0A_18488:
        CheckExternalEvents(cs1, 0x5A3A);
        // 100D:5A3A jmp near 0x17E6
        if (JumpDispatcher.Jump(unknown_100D_17E6_118B6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_5A56_15B26(int loadOffset)
    {
    label_100D_5A56_15B26_17436:
        CheckExternalEvents(cs1, 0x5A56);
        // 100D:5A56 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:5A5B js short 0x5A9A
        if (SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:5A5B");
        }
    label_100D_5A5D_15B2D_17439:
        CheckExternalEvents(cs1, 0x5A5D);
        // 100D:5A5D call near 0xD2BD
        NearCall(cs1, 0x5A60, unknown_100D_D2BD_1D38D);
    label_100D_5A60_15B30_17441:
        CheckExternalEvents(cs1, 0x5A60);
        // 100D:5A60 call near 0x4ACA
        NearCall(cs1, 0x5A63, unknown_100D_4ACA_14B9A);
    label_100D_5A63_15B33_17443:
        CheckExternalEvents(cs1, 0x5A63);
        // 100D:5A63 call near 0xB930
        NearCall(cs1, 0x5A66, unknown_100D_B930_1BA00);
    label_100D_5A66_15B36_17445:
        CheckExternalEvents(cs1, 0x5A66);
        // 100D:5A66 mov SI,0x6B34
        SI = (ushort)0x6B34;
        // 100D:5A69 mov BP,0x000F
        BP = (ushort)0x000F;
        // 100D:5A6C call near 0xDA25
        NearCall(cs1, 0x5A6F, unknown_100D_DA25_1DAF5);
    label_100D_5A6F_15B3F_17449:
        CheckExternalEvents(cs1, 0x5A6F);
        // 100D:5A6F mov SI,0x1482
        SI = (ushort)0x1482;
        // 100D:5A72 mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:5A75 call near 0x5B99
        NearCall(cs1, 0x5A78, unknown_100D_5B99_15C69);
    label_100D_5A78_15B48_17453:
        CheckExternalEvents(cs1, 0x5A78);
        // 100D:5A78 call near 0x5B69
        NearCall(cs1, 0x5A7B, unknown_100D_5B69_15C39);
    label_100D_5A7B_15B4B_17480:
        CheckExternalEvents(cs1, 0x5A7B);
        // 100D:5A7B call near 0x1797
        NearCall(cs1, 0x5A7E, unknown_100D_1797_11867);
    label_100D_5A7E_15B4E_17482:
        CheckExternalEvents(cs1, 0x5A7E);
        // 100D:5A7E mov byte ptr DS:[0x46EB],0x80
        UInt8[DS, (ushort)0x46EB] = (byte)0x80;
        // 100D:5A83 call near 0xAD5E
        NearCall(cs1, 0x5A86, unknown_100D_AD5E_1AE2E);
    label_100D_5A86_15B56_17496:
        CheckExternalEvents(cs1, 0x5A86);
        // 100D:5A86 mov word ptr DS:[0x2786],0xC835
        UInt16[DS, (ushort)0x2786] = (ushort)0xC835;
        // 100D:5A8C mov AX,0x5A9A
        AX = (ushort)0x5A9A;
        // 100D:5A8F mov word ptr DS:[0x46ED],AX
        UInt16[DS, (ushort)0x46ED] = AX;
        // 100D:5A92 call near AX
        switch ((ushort)(AX))
        {
            case 0x5A9A:
                NearCall(cs1, 0x5A94, unknown_100D_5A9A_15B6A);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(AX)):X4} at 100D:5A92");
        }
    label_100D_5A94_15B64_18379:
        CheckExternalEvents(cs1, 0x5A94);
        // 100D:5A94 call near 0xD792
        NearCall(cs1, 0x5A97, unknown_100D_D792_1D862);
    label_100D_5A97_15B67_18389:
        CheckExternalEvents(cs1, 0x5A97);
        // 100D:5A97 jmp near 0xD712
    label_100D_D712_1D7E2_18391:
        CheckExternalEvents(cs1, 0xD712);
        // 100D:D712 mov SI,0x1CCA
        SI = (ushort)0x1CCA;
        // 100D:D715 jmp short 0xD72B
        return unknown_100D_D72B_1D7FB(0x0000);
    }

    public virtual Action unknown_100D_5A9A_15B6A(int loadOffset)
    {
    label_100D_5A9A_15B6A_17501:
        CheckExternalEvents(cs1, 0x5A9A);
        // 100D:5A9A call near 0xC07C
        NearCall(cs1, 0x5A9D, unknown_100D_C07C_1C14C);
    label_100D_5A9D_15B6D_17503:
        CheckExternalEvents(cs1, 0x5A9D);
        // 100D:5A9D call near 0x5B8D
        NearCall(cs1, 0x5AA0, unknown_100D_5B8D_15C5D);
    label_100D_5AA0_15B70_17512:
        CheckExternalEvents(cs1, 0x5AA0);
        // 100D:5AA0 mov AL,0x80
        AL = (byte)0x80;
        // 100D:5AA2 xchg AL,byte ptr DS:[0x46EB]
        ushort xchgOffset_100D_5AA2_15B72 = (ushort)0x46EB;
        byte temp_100D_5AA2_15B72 = AL;
        AL = UInt8[DS, xchgOffset_100D_5AA2_15B72];
        UInt8[DS, xchgOffset_100D_5AA2_15B72] = unchecked((byte)temp_100D_5AA2_15B72);
        // 100D:5AA6 push AX
        Stack.Push16(AX);
        // 100D:5AA7 call near 0xB6C3
        NearCall(cs1, 0x5AAA, unknown_100D_B6C3_1B793);
    label_100D_5AAA_15B7A_17947:
        CheckExternalEvents(cs1, 0x5AAA);
        // 100D:5AAA call near 0xC13B
        NearCall(cs1, 0x5AAD, unknown_100D_C13B_1C20B);
    label_100D_5AAD_15B7D_17950:
        CheckExternalEvents(cs1, 0x5AAD);
        // 100D:5AAD call near 0x5DCE
        NearCall(cs1, 0x5AB0, unknown_100D_5DCE_15E9E);
    label_100D_5AB0_15B80_18187:
        CheckExternalEvents(cs1, 0x5AB0);
        // 100D:5AB0 call near 0x6314
        NearCall(cs1, 0x5AB3, unknown_100D_6314_163E4);
    label_100D_5AB3_15B83_18214:
        CheckExternalEvents(cs1, 0x5AB3);
        // 100D:5AB3 call near 0xC412
        NearCall(cs1, 0x5AB6, unknown_100D_C412_1C4E2);
    label_100D_5AB6_15B86_18216:
        CheckExternalEvents(cs1, 0x5AB6);
        // 100D:5AB6 mov word ptr DS:[0x3CBE],0
        UInt16[DS, (ushort)0x3CBE] = (ushort)0x0000;
        // 100D:5ABC call near 0x6715
        NearCall(cs1, 0x5ABF, unknown_100D_6715_167E5);
    label_100D_5ABF_15B8F_18316:
        CheckExternalEvents(cs1, 0x5ABF);
        // 100D:5ABF mov SI,0x46E3
        SI = (ushort)0x46E3;
        // 100D:5AC2 call near 0xC6AD
        NearCall(cs1, 0x5AC5, unknown_100D_C6AD_1C77D);
    label_100D_5AC5_15B95_18330:
        CheckExternalEvents(cs1, 0x5AC5);
        // 100D:5AC5 call near 0x878C
        NearCall(cs1, 0x5AC8, unknown_100D_878C_1885C);
    label_100D_5AC8_15B98_18367:
        CheckExternalEvents(cs1, 0x5AC8);
        // 100D:5AC8 pop AX
        AX = Stack.Pop16();
        // 100D:5AC9 mov byte ptr DS:[0x46EB],AL
        UInt8[DS, (ushort)0x46EB] = AL;
        // 100D:5ACC and AL,0x40
        AL = Alu8.And(AL, (byte)0x40);
        // 100D:5ACE je short 0x5AD3
        if (ZeroFlag)
        {
            return unknown_100D_5AD3_15BA3(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5ACE");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_5AD3_15BA3(int loadOffset)
    {
    label_100D_5AD3_15BA3_18372:
        CheckExternalEvents(cs1, 0x5AD3);
        // 100D:5AD3 mov AX,0x1A9E
        AX = (ushort)0x1A9E;
        // 100D:5AD6 call near 0xD95E
        NearCall(cs1, 0x5AD9, unknown_100D_D95E_1DA2E);
        return unknown_100D_5AD9_15BA9(0x0000);
    }

    public virtual Action unknown_100D_5AD9_15BA9(int loadOffset)
    {
    label_100D_5AD9_15BA9_18376:
        CheckExternalEvents(cs1, 0x5AD9);
        // 100D:5AD9 mov SI,0x46E3
        SI = (ushort)0x46E3;
        // 100D:5ADC jmp near 0xDAAA
        return unknown_100D_DAAA_1DB7A(0x0000);
    }

    public virtual Action unknown_100D_5ADF_15BAF(int loadOffset)
    {
    label_100D_5ADF_15BAF_13235:
        CheckExternalEvents(cs1, 0x5ADF);
        // 100D:5ADF call near 0x7B36
        NearCall(cs1, 0x5AE2, unknown_100D_7B36_17C06);
    label_100D_5AE2_15BB2_13272:
        CheckExternalEvents(cs1, 0x5AE2);
        // 100D:5AE2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:5AE4 mov byte ptr DS:[0x46EB],AL
        UInt8[DS, (ushort)0x46EB] = AL;
        // 100D:5AE7 mov byte ptr DS:[0x46F3],AL
        UInt8[DS, (ushort)0x46F3] = AL;
        // 100D:5AEA mov word ptr DS:[0x3CBE],AX
        UInt16[DS, (ushort)0x3CBE] = AX;
        // 100D:5AED mov word ptr DS:[0xA5C0],AX
        UInt16[DS, (ushort)0xA5C0] = AX;
        // 100D:5AF0 mov word ptr DS:[0xDBE0],AX
        UInt16[DS, (ushort)0xDBE0] = AX;
        // 100D:5AF3 mov word ptr DS:[0xDBE2],AX
        UInt16[DS, (ushort)0xDBE2] = AX;
        // 100D:5AF6 mov word ptr DS:[0x1954],AX
        UInt16[DS, (ushort)0x1954] = AX;
        // 100D:5AF9 mov word ptr DS:[0x2786],0xC827
        UInt16[DS, (ushort)0x2786] = (ushort)0xC827;
        // 100D:5AFF mov SI,0x6B34
        SI = (ushort)0x6B34;
        // 100D:5B02 jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    }

    public virtual Action unknown_100D_5B05_15BD5(int loadOffset)
    {
    entrydispatcher:
    label_100D_5B05_15BD5_37314:
        CheckExternalEvents(cs1, 0x5B05);
        // 100D:5B05 call near 0x82A0
        NearCall(cs1, 0x5B08, unknown_100D_82A0_18370);
    label_100D_5B08_15BD8_37316:
        CheckExternalEvents(cs1, 0x5B08);
        // 100D:5B08 jne short 0x5B0D
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5B08");
        }
    label_100D_5B0D_15BDD_37318:
        CheckExternalEvents(cs1, 0x5B0D);
        // 100D:5B0D call near 0x5B5D
        NearCall(cs1, 0x5B10, unknown_100D_5B5D_15C2D);
        if (JumpDispatcher.Jump(unknown_100D_5B10_15BE0, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_5B10_15BE0(int loadOffset)
    {
    entrydispatcher:
    label_100D_5B10_15BE0_35388:
        CheckExternalEvents(cs1, 0x5B10);
        // 100D:5B10 call near 0x8850
        NearCall(cs1, 0x5B13, unknown_100D_8850_18920);
    label_100D_5B13_15BE3_35391:
        CheckExternalEvents(cs1, 0x5B13);
        // 100D:5B13 test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:5B18 je short 0x5B1D
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5B18");
        }
    label_100D_5B1D_15BED_35394:
        CheckExternalEvents(cs1, 0x5B1D);
        // 100D:5B1D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5B55_15C25(int loadOffset)
    {
    label_100D_5B55_15C25_36651:
        CheckExternalEvents(cs1, 0x5B55);
        // 100D:5B55 mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:5B58 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:5B5B jmp short 0x5B60
        return unknown_100D_5B60_15C30(0x0000);
    }

    public virtual Action unknown_100D_5B5D_15C2D(int loadOffset)
    {
    label_100D_5B5D_15C2D_17415:
        CheckExternalEvents(cs1, 0x5B5D);
        // 100D:5B5D call near 0x407E
        NearCall(cs1, 0x5B60, unknown_100D_407E_1414E);
        return unknown_100D_5B60_15C30(0x0000);
    }

    public virtual Action unknown_100D_5B60_15C30(int loadOffset)
    {
    label_100D_5B60_15C30_17427:
        CheckExternalEvents(cs1, 0x5B60);
        // 100D:5B60 mov word ptr DS:[0x197E],BX
        UInt16[DS, (ushort)0x197E] = BX;
        // 100D:5B64 mov word ptr DS:[0x197C],DX
        UInt16[DS, (ushort)0x197C] = DX;
        // 100D:5B68 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5B69_15C39(int loadOffset)
    {
    label_100D_5B69_15C39_17455:
        CheckExternalEvents(cs1, 0x5B69);
        // 100D:5B69 mov SI,0x46E3
        SI = (ushort)0x46E3;
        // 100D:5B6C mov AL,0xFC
        AL = (byte)0xFC;
        return unknown_100D_5B6E_15C3E(0x0000);
    }

    public virtual Action unknown_100D_5B6E_15C3E(int loadOffset)
    {
    label_100D_5B6E_15C3E_17458:
        CheckExternalEvents(cs1, 0x5B6E);
        // 100D:5B6E mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:5B70 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:5B73 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:5B76 mov CX,word ptr DS:[SI+6]
        CX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:5B79 mov BP,4
        BP = (ushort)0x0004;
    label_100D_5B7C_15C4C_17463:
        CheckExternalEvents(cs1, 0x5B7C);
        // 100D:5B7C push AX
        Stack.Push16(AX);
        // 100D:5B7D push BP
        Stack.Push16(BP);
        // 100D:5B7E dec DX
        DX = Alu16.Dec(DX);
        // 100D:5B7F dec BX
        BX = Alu16.Dec(BX);
        // 100D:5B80 call near 0xC560
        NearCall(cs1, 0x5B83, unknown_100D_C560_1C630);
    label_100D_5B83_15C53_17469:
        CheckExternalEvents(cs1, 0x5B83);
        // 100D:5B83 pop BP
        BP = Stack.Pop16();
        // 100D:5B84 pop AX
        AX = Stack.Pop16();
        // 100D:5B85 inc DI
        DI = Alu16.Inc(DI);
        // 100D:5B86 inc CX
        CX = Alu16.Inc(CX);
        // 100D:5B87 sub AL,2
        AL = Alu8.Sub(AL, (byte)0x02);
        // 100D:5B89 dec BP
        BP = Alu16.Dec(BP);
        // 100D:5B8A jne short 0x5B7C
        if (!ZeroFlag)
        {
            goto label_100D_5B7C_15C4C_17463;
        }
    label_100D_5B8C_15C5C_17478:
        CheckExternalEvents(cs1, 0x5B8C);
        // 100D:5B8C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5B8D_15C5D(int loadOffset)
    {
    label_100D_5B8D_15C5D_17505:
        CheckExternalEvents(cs1, 0x5B8D);
        // 100D:5B8D mov DI,0xD83C
        DI = (ushort)0xD83C;
        // 100D:5B90 call near 0x5B96
        NearCall(cs1, 0x5B93, unknown_100D_5B96_15C66);
        return unknown_100D_5B93_15C63(0x0000);
    }

    public virtual Action unknown_100D_5B93_15C63(int loadOffset)
    {
    label_100D_5B93_15C63_17510:
        CheckExternalEvents(cs1, 0x5B93);
        // 100D:5B93 mov DI,0xD834
        DI = (ushort)0xD834;
        return unknown_100D_5B96_15C66(0x0000);
    }

    public virtual Action unknown_100D_5B96_15C66(int loadOffset)
    {
    label_100D_5B96_15C66_17508:
        CheckExternalEvents(cs1, 0x5B96);
        // 100D:5B96 mov SI,0x46E3
        SI = (ushort)0x46E3;
        return unknown_100D_5B99_15C69(0x0000);
    }

    public virtual Action unknown_100D_5B99_15C69(int loadOffset)
    {
    label_100D_5B99_15C69_2678:
        CheckExternalEvents(cs1, 0x5B99);
        // 100D:5B99 push DS
        Stack.Push16(DS);
        // 100D:5B9A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:5B9B movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5B9C movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5B9D movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5B9E movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:5B9F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5BA0_15C70(int loadOffset)
    {
    label_100D_5BA0_15C70_10325:
        CheckExternalEvents(cs1, 0x5BA0);
        // 100D:5BA0 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:5BA3 mov DI,0xD83C
        DI = (ushort)0xD83C;
        // 100D:5BA6 jmp short 0x5B99
        return unknown_100D_5B99_15C69(0x0000);
    }

    public virtual Action unknown_100D_5BA8_15C78(int loadOffset)
    {
    label_100D_5BA8_15C78_6668:
        CheckExternalEvents(cs1, 0x5BA8);
        // 100D:5BA8 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:5BAB mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:5BAE jmp short 0x5B99
        return unknown_100D_5B99_15C69(0x0000);
    }

    public virtual Action unknown_100D_5BB0_15C80(int loadOffset)
    {
    label_100D_5BB0_15C80_18399:
        CheckExternalEvents(cs1, 0x5BB0);
        // 100D:5BB0 call near 0xC08E
        NearCall(cs1, 0x5BB3, unknown_100D_C08E_1C15E);
    label_100D_5BB3_15C83_18401:
        CheckExternalEvents(cs1, 0x5BB3);
        // 100D:5BB3 mov SI,0x194A
        SI = (ushort)0x194A;
        // 100D:5BB6 mov word ptr DS:[0xDBE0],SI
        UInt16[DS, (ushort)0xDBE0] = SI;
        // 100D:5BBA call near 0x7B1B
        NearCall(cs1, 0x5BBD, unknown_100D_7B1B_17BEB);
    label_100D_5BBD_15C8D_18413:
        CheckExternalEvents(cs1, 0x5BBD);
        // 100D:5BBD call near 0xD068
        NearCall(cs1, 0x5BC0, unknown_100D_D068_1D138);
    label_100D_5BC0_15C90_18415:
        CheckExternalEvents(cs1, 0x5BC0);
        // 100D:5BC0 mov SI,0x00E2
        SI = (ushort)0x00E2;
        // 100D:5BC3 call near 0xCF70
        NearCall(cs1, 0x5BC6, unknown_100D_CF70_1D040);
    label_100D_5BC6_15C96_18418:
        CheckExternalEvents(cs1, 0x5BC6);
        // 100D:5BC6 call near 0xD03C
        NearCall(cs1, 0x5BC9, unknown_100D_D03C_1D10C);
    label_100D_5BC9_15C99_18433:
        CheckExternalEvents(cs1, 0x5BC9);
        // 100D:5BC9 mov AL,byte ptr DS:[0x0028]
        AL = UInt8[DS, (ushort)0x0028];
        // 100D:5BCC xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:5BCE call near 0xE2E3
        NearCall(cs1, 0x5BD1, unknown_100D_E2E3_1E3B3);
    label_100D_5BD1_15CA1_18468:
        CheckExternalEvents(cs1, 0x5BD1);
        // 100D:5BD1 mov DX,word ptr DS:[0x194A]
        DX = UInt16[DS, (ushort)0x194A];
        // 100D:5BD5 mov BX,word ptr DS:[0x194C]
        BX = UInt16[DS, (ushort)0x194C];
        // 100D:5BD9 add DX,0x000A
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:5BDC add BX,8
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:5BDF mov CX,0x00F0
        CX = (ushort)0x00F0;
        // 100D:5BE2 mov AX,0x00E2
        AX = (ushort)0x00E2;
        // 100D:5BE5 call near 0xD194
        NearCall(cs1, 0x5BE8, unknown_100D_D194_1D264);
    label_100D_5BE8_15CB8_18486:
        CheckExternalEvents(cs1, 0x5BE8);
        // 100D:5BE8 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_5BEB_15CBB(int loadOffset)
    {
    label_100D_5BEB_15CBB_26204:
        CheckExternalEvents(cs1, 0x5BEB);
        // 100D:5BEB cmp word ptr DS:[0xDBE0],0x194A
        Alu16.Sub(UInt16[DS, (ushort)0xDBE0], (ushort)0x194A);
        // 100D:5BF1 jne short 0x5C02
        if (!ZeroFlag)
        {
            goto label_100D_5C02_15CD2_26207;
        }
    label_100D_5BF3_15CC3_26283:
        CheckExternalEvents(cs1, 0x5BF3);
        // 100D:5BF3 call near 0xE270
        NearCall(cs1, 0x5BF6, unknown_100D_E270_1E340);
    label_100D_5BF6_15CC6_26285:
        CheckExternalEvents(cs1, 0x5BF6);
        // 100D:5BF6 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:5BF8 xchg SI,word ptr DS:[0xDBE0]
        ushort xchgOffset_100D_5BF8_15CC8 = (ushort)0xDBE0;
        ushort temp_100D_5BF8_15CC8 = SI;
        SI = UInt16[DS, xchgOffset_100D_5BF8_15CC8];
        UInt16[DS, xchgOffset_100D_5BF8_15CC8] = unchecked((ushort)temp_100D_5BF8_15CC8);
        // 100D:5BFC call near 0xC6AD
        NearCall(cs1, 0x5BFF, unknown_100D_C6AD_1C77D);
    label_100D_5BFF_15CCF_26289:
        CheckExternalEvents(cs1, 0x5BFF);
        // 100D:5BFF call near 0xE283
        NearCall(cs1, 0x5C02, unknown_100D_E283_1E353);
    label_100D_5C02_15CD2_26207:
        CheckExternalEvents(cs1, 0x5C02);
        // 100D:5C02 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5C03_15CD3(int loadOffset)
    {
    entrydispatcher:
    label_100D_5C03_15CD3_18512:
        CheckExternalEvents(cs1, 0x5C03);
        // 100D:5C03 mov DI,word ptr DS:[0xDBE0]
        DI = UInt16[DS, (ushort)0xDBE0];
        // 100D:5C07 cmp DI,0x194A
        Alu16.Sub(DI, (ushort)0x194A);
        // 100D:5C0B jne short 0x5C22
        if (!ZeroFlag)
        {
            goto label_100D_5C22_15CF2_18521;
        }
    label_100D_5C0D_15CDD_18516:
        CheckExternalEvents(cs1, 0x5C0D);
        // 100D:5C0D mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:5C10 sub AX,word ptr DS:[0xDC5A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDC5A]);
        // 100D:5C14 cmp AX,0x03E8
        Alu16.Sub(AX, (ushort)0x03E8);
        // 100D:5C17 jb short 0x5C22
        if (CarryFlag)
        {
            goto label_100D_5C22_15CF2_18521;
        }
    label_100D_5C19_15CE9_38073:
        CheckExternalEvents(cs1, 0x5C19);
        // 100D:5C19 call near 0xDBB2
        NearCall(cs1, 0x5C1C, unknown_100D_DBB2_1DC82);
    label_100D_5C1C_15CEC_38076:
        CheckExternalEvents(cs1, 0x5C1C);
        // 100D:5C1C call near 0x5BEB
        NearCall(cs1, 0x5C1F, unknown_100D_5BEB_15CBB);
    label_100D_5C1F_15CEF_38079:
        CheckExternalEvents(cs1, 0x5C1F);
        // 100D:5C1F jmp near 0xDBEC
        if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5C22_15CF2_18521:
        CheckExternalEvents(cs1, 0x5C22);
        // 100D:5C22 cmp DI,0x4710
        Alu16.Sub(DI, (ushort)0x4710);
        // 100D:5C26 je short 0x5C32
        if (ZeroFlag)
        {
            goto label_100D_5C32_15D02_28911;
        }
    label_100D_5C28_15CF8_18524:
        CheckExternalEvents(cs1, 0x5C28);
        // 100D:5C28 mov DI,word ptr DS:[0xDBE2]
        DI = UInt16[DS, (ushort)0xDBE2];
        // 100D:5C2C cmp DI,0x4710
        Alu16.Sub(DI, (ushort)0x4710);
        // 100D:5C30 jne short 0x5C75
        if (!ZeroFlag)
        {
            goto label_100D_5C75_15D45_18528;
        }
    label_100D_5C32_15D02_28911:
        CheckExternalEvents(cs1, 0x5C32);
        // 100D:5C32 call near 0xD6FE
        NearCall(cs1, 0x5C35, unknown_100D_D6FE_1D7CE);
    label_100D_5C35_15D05_28913:
        CheckExternalEvents(cs1, 0x5C35);
        // 100D:5C35 jae short 0x5C4B
        if (!CarryFlag)
        {
            goto label_100D_5C4B_15D1B_28915;
        }
    label_100D_5C37_15D07_28941:
        CheckExternalEvents(cs1, 0x5C37);
        // 100D:5C37 mov byte ptr DS:[0x46EB],0x40
        UInt8[DS, (ushort)0x46EB] = (byte)0x40;
        // 100D:5C3C mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:5C3E call near 0x5E6D
        NearCall(cs1, 0x5C41, unknown_100D_5E6D_15F3D);
    label_100D_5C41_15D11_28945:
        CheckExternalEvents(cs1, 0x5C41);
        // 100D:5C41 mov byte ptr DS:[0x46EB],0xC0
        UInt8[DS, (ushort)0x46EB] = (byte)0xC0;
        // 100D:5C46 cmp AX,9
        Alu16.Sub(AX, (ushort)0x0009);
        // 100D:5C49 jb short 0x5C4D
        if (CarryFlag)
        {
            goto label_100D_5C4D_15D1D_28917;
        }
    label_100D_5C4B_15D1B_28915:
        CheckExternalEvents(cs1, 0x5C4B);
        // 100D:5C4B xor DI,DI
        DI = Alu16.Xor(DI, DI);
    label_100D_5C4D_15D1D_28917:
        CheckExternalEvents(cs1, 0x5C4D);
        // 100D:5C4D mov AX,DI
        AX = DI;
        // 100D:5C4F xchg AX,word ptr DS:[0x46FC]
        ushort xchgOffset_100D_5C4F_15D1F = (ushort)0x46FC;
        ushort temp_100D_5C4F_15D1F = AX;
        AX = UInt16[DS, xchgOffset_100D_5C4F_15D1F];
        UInt16[DS, xchgOffset_100D_5C4F_15D1F] = unchecked((ushort)temp_100D_5C4F_15D1F);
        // 100D:5C53 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:5C55 je short 0x5C6E
        if (ZeroFlag)
        {
            goto label_100D_5C6E_15D3E_28921;
        }
    label_100D_5C57_15D27_29151:
        CheckExternalEvents(cs1, 0x5C57);
        // 100D:5C57 push BX
        Stack.Push16(BX);
        // 100D:5C58 push DX
        Stack.Push16(DX);
        // 100D:5C59 push DI
        Stack.Push16(DI);
        // 100D:5C5A push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:5C5E call near 0xDBB2
        NearCall(cs1, 0x5C61, unknown_100D_DBB2_1DC82);
    label_100D_5C61_15D31_29157:
        CheckExternalEvents(cs1, 0x5C61);
        // 100D:5C61 call near 0xC08E
        NearCall(cs1, 0x5C64, unknown_100D_C08E_1C15E);
    label_100D_5C64_15D34_29159:
        CheckExternalEvents(cs1, 0x5C64);
        // 100D:5C64 call near 0x5692
        NearCall(cs1, 0x5C67, unknown_100D_5692_15762);
    label_100D_5C67_15D37_29249:
        CheckExternalEvents(cs1, 0x5C67);
        // 100D:5C67 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_5C67_15D37 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_5C67_15D37 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_5C67_15D37 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_5C67_15D37);
        // 100D:5C6B pop DI
        DI = Stack.Pop16();
        // 100D:5C6C pop DX
        DX = Stack.Pop16();
        // 100D:5C6D pop BX
        BX = Stack.Pop16();
    label_100D_5C6E_15D3E_28921:
        CheckExternalEvents(cs1, 0x5C6E);
        // 100D:5C6E or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5C70 jne short 0x5C75
        if (!ZeroFlag)
        {
            goto label_100D_5C75_15D45_18528;
        }
    label_100D_5C72_15D42_28924:
        CheckExternalEvents(cs1, 0x5C72);
        // 100D:5C72 call near 0x5746
        NearCall(cs1, 0x5C75, unknown_100D_5746_15816);
    label_100D_5C75_15D45_18528:
        CheckExternalEvents(cs1, 0x5C75);
        // 100D:5C75 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5C76_15D46(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_5C76_15D46_26202;

    label_100D_5923_159F3_31008:
        CheckExternalEvents(cs1, 0x5923);
        // 100D:5923 call near 0x5944
        NearCall(cs1, 0x5926, unknown_100D_5944_15A14);
    label_100D_5926_159F6_38343:
        CheckExternalEvents(cs1, 0x5926);
        // 100D:5926 push BX
        Stack.Push16(BX);
        // 100D:5927 call near 0x5C03
        NearCall(cs1, 0x592A, unknown_100D_5C03_15CD3);
    label_100D_592A_159FA_38348:
        CheckExternalEvents(cs1, 0x592A);
        // 100D:592A pop BX
        BX = Stack.Pop16();
        // 100D:592B mov DI,word ptr DS:[0x46FC]
        DI = UInt16[DS, (ushort)0x46FC];
        // 100D:592F or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5931 je short 0x5922
        if (ZeroFlag)
        {
            return unknown_100D_5922_159F2(0x0000);
        }
    label_100D_5933_15A03_38354:
        CheckExternalEvents(cs1, 0x5933);
        // 100D:5933 and byte ptr DS:[0x46EB],0xBF
        UInt8[DS, (ushort)0x46EB] = Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0xBF);
        // 100D:5938 mov word ptr DS:[0xDBE0],0
        UInt16[DS, (ushort)0xDBE0] = (ushort)0x0000;
        // 100D:593E call near 0x5B55
        NearCall(cs1, 0x5941, unknown_100D_5B55_15C25);
    label_100D_5941_15A11_38365:
        CheckExternalEvents(cs1, 0x5941);
        // 100D:5941 jmp near 0x8850
        if (JumpDispatcher.Jump(unknown_100D_8850_18920, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5C76_15D46_26202:
        CheckExternalEvents(cs1, 0x5C76);
        // 100D:5C76 call near 0x5BEB
        NearCall(cs1, 0x5C79, unknown_100D_5BEB_15CBB);
    label_100D_5C79_15D49_26209:
        CheckExternalEvents(cs1, 0x5C79);
        // 100D:5C79 call near 0xC13B
        NearCall(cs1, 0x5C7C, unknown_100D_C13B_1C20B);
    label_100D_5C7C_15D4C_26211:
        CheckExternalEvents(cs1, 0x5C7C);
        // 100D:5C7C mov DI,word ptr DS:[0xDBE0]
        DI = UInt16[DS, (ushort)0xDBE0];
        // 100D:5C80 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5C82 je short 0x5C95
        if (ZeroFlag)
        {
            goto label_100D_5C95_15D65_26219;
        }
    label_100D_5C84_15D54_26215:
        CheckExternalEvents(cs1, 0x5C84);
        // 100D:5C84 call near 0xD6FE
        NearCall(cs1, 0x5C87, unknown_100D_D6FE_1D7CE);
    label_100D_5C87_15D57_26217:
        CheckExternalEvents(cs1, 0x5C87);
        // 100D:5C87 jae short 0x5C95
        if (!CarryFlag)
        {
            goto label_100D_5C95_15D65_26219;
        }
    label_100D_5C89_15D59_31003:
        CheckExternalEvents(cs1, 0x5C89);
        // 100D:5C89 cmp DI,0x4710
        Alu16.Sub(DI, (ushort)0x4710);
        // 100D:5C8D jne short 0x5C92
        if (!ZeroFlag)
        {
            goto label_100D_5C92_15D62_33399;
        }
    label_100D_5C8F_15D5F_31006:
        CheckExternalEvents(cs1, 0x5C8F);
        // 100D:5C8F jmp near 0x5923
        goto label_100D_5923_159F3_31008;
    label_100D_5C92_15D62_33399:
        CheckExternalEvents(cs1, 0x5C92);
        // 100D:5C92 jmp near 0x7E97
        goto label_100D_7E97_17F67_33401;
    label_100D_5C95_15D65_26219:
        CheckExternalEvents(cs1, 0x5C95);
        // 100D:5C95 mov DI,word ptr DS:[0xDBE2]
        DI = UInt16[DS, (ushort)0xDBE2];
        // 100D:5C99 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5C9B je short 0x5CA5
        if (ZeroFlag)
        {
            goto label_100D_5CA5_15D75_26223;
        }
    label_100D_5C9D_15D6D_27730:
        CheckExternalEvents(cs1, 0x5C9D);
        // 100D:5C9D call near 0xD6FE
        NearCall(cs1, 0x5CA0, unknown_100D_D6FE_1D7CE);
    label_100D_5CA0_15D70_27732:
        CheckExternalEvents(cs1, 0x5CA0);
        // 100D:5CA0 jae short 0x5CA5
        if (!CarryFlag)
        {
            goto label_100D_5CA5_15D75_26223;
        }
    label_100D_5CA2_15D72_27734:
        CheckExternalEvents(cs1, 0x5CA2);
        // 100D:5CA2 jmp near 0x7EB8
        goto label_100D_7EB8_17F88_27736;
    label_100D_5CA5_15D75_26223:
        CheckExternalEvents(cs1, 0x5CA5);
        // 100D:5CA5 cmp byte ptr DS:[0x46F5],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F5], (byte)0x00);
        // 100D:5CAA je short 0x5CAF
        if (ZeroFlag)
        {
            goto label_100D_5CAF_15D7F_26226;
        }
    label_100D_5CAC_15D7C_33525:
        CheckExternalEvents(cs1, 0x5CAC);
        // 100D:5CAC jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5CAF_15D7F_26226:
        CheckExternalEvents(cs1, 0x5CAF);
        // 100D:5CAF call near 0x6946
        NearCall(cs1, 0x5CB2, unknown_100D_6946_16A16);
    label_100D_5CB2_15D82_26258:
        CheckExternalEvents(cs1, 0x5CB2);
        // 100D:5CB2 jae short 0x5CB7
        if (!CarryFlag)
        {
            goto label_100D_5CB7_15D87_26260;
        }
    label_100D_5CB4_15D84_30126:
        CheckExternalEvents(cs1, 0x5CB4);
        // 100D:5CB4 jmp near 0x872C
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x872C))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5CB7_15D87_26260:
        CheckExternalEvents(cs1, 0x5CB7);
        // 100D:5CB7 mov AL,0x31
        AL = (byte)0x31;
        // 100D:5CB9 call near 0x5E6D
        NearCall(cs1, 0x5CBC, unknown_100D_5E6D_15F3D);
    label_100D_5CBC_15D8C_26263:
        CheckExternalEvents(cs1, 0x5CBC);
        // 100D:5CBC cmp AX,0x0014
        Alu16.Sub(AX, (ushort)0x0014);
        // 100D:5CBF jae short 0x5CCA
        if (!CarryFlag)
        {
            goto label_100D_5CCA_15D9A_26266;
        }
    label_100D_5CC1_15D91_26291:
        CheckExternalEvents(cs1, 0x5CC1);
        // 100D:5CC1 cmp DI,word ptr DS:[0x46F8]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x46F8]);
        // 100D:5CC5 je short 0x5CCA
        if (ZeroFlag)
        {
            goto label_100D_5CCA_15D9A_26266;
        }
    label_100D_5CC7_15D97_26294:
        CheckExternalEvents(cs1, 0x5CC7);
        // 100D:5CC7 jmp near 0x5FB0
        goto label_100D_5FB0_16080_26296;
    label_100D_5CCA_15D9A_26266:
        CheckExternalEvents(cs1, 0x5CCA);
        // 100D:5CCA call near 0x5F79
        NearCall(cs1, 0x5CCD, unknown_100D_5F79_16049);
    label_100D_5CCD_15D9D_26268:
        CheckExternalEvents(cs1, 0x5CCD);
        // 100D:5CCD call near 0x79DE
        NearCall(cs1, 0x5CD0, unknown_100D_79DE_17AAE);
    label_100D_5CD0_15DA0_26270:
        CheckExternalEvents(cs1, 0x5CD0);
        // 100D:5CD0 call near 0x58FA
        NearCall(cs1, 0x5CD3, unknown_100D_58FA_159CA);
    label_100D_5CD3_15DA3_26272:
        CheckExternalEvents(cs1, 0x5CD3);
        // 100D:5CD3 cmp byte ptr DS:[0x1954],0
        Alu8.Sub(UInt8[DS, (ushort)0x1954], (byte)0x00);
        // 100D:5CD8 je short 0x5CE3
        if (ZeroFlag)
        {
            return unknown_100D_5CE3_15DB3(0x0000);
        }
    label_100D_5CDA_15DAA_26275:
        CheckExternalEvents(cs1, 0x5CDA);
        // 100D:5CDA call near 0xD316
        NearCall(cs1, 0x5CDD, unknown_100D_D316_1D3E6);
    label_100D_5CDD_15DAD_26277:
        CheckExternalEvents(cs1, 0x5CDD);
        // 100D:5CDD call near 0x8763
        NearCall(cs1, 0x5CE0, unknown_100D_8763_18833);
    label_100D_5CE0_15DB0_26279:
        CheckExternalEvents(cs1, 0x5CE0);
        // 100D:5CE0 call near 0xD280
        NearCall(cs1, 0x5CE3, unknown_100D_D280_1D350);
        return unknown_100D_5CE3_15DB3(0x0000);
    label_100D_5FB0_16080_26296:
        CheckExternalEvents(cs1, 0x5FB0);
        // 100D:5FB0 call near 0x58FA
        NearCall(cs1, 0x5FB3, unknown_100D_58FA_159CA);
    label_100D_5FB3_16083_26298:
        CheckExternalEvents(cs1, 0x5FB3);
        // 100D:5FB3 call near 0x7B36
        NearCall(cs1, 0x5FB6, unknown_100D_7B36_17C06);
    label_100D_5FB6_16086_26300:
        CheckExternalEvents(cs1, 0x5FB6);
        // 100D:5FB6 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:5FBA je short 0x600E
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_600E_160DE, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_5FBC_1608C_26303:
        CheckExternalEvents(cs1, 0x5FBC);
        // 100D:5FBC cmp byte ptr DS:[8],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0xFF);
        // 100D:5FC1 je short 0x5FF9
        if (ZeroFlag)
        {
            goto label_100D_5FF9_160C9_36541;
        }
    label_100D_5FC3_16093_26306:
        CheckExternalEvents(cs1, 0x5FC3);
        // 100D:5FC3 cmp byte ptr DS:[0x000B],2
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x02);
        // 100D:5FC8 jbe short 0x5FD8
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_5FD8_160A8_26309;
        }
    label_100D_5FCA_1609A_35845:
        CheckExternalEvents(cs1, 0x5FCA);
        // 100D:5FCA cmp byte ptr DS:[8],0x20
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0x20);
        // 100D:5FCF jae short 0x600E
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_600E_160DE, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_5FD1_160A1_37412:
        CheckExternalEvents(cs1, 0x5FD1);
        // 100D:5FD1 cmp byte ptr DS:[8],0x28
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0x28);
        // 100D:5FD6 jae short 0x600E
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_600E_160DE, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_5FD8_160A8_26309:
        CheckExternalEvents(cs1, 0x5FD8);
        // 100D:5FD8 push DI
        Stack.Push16(DI);
        // 100D:5FD9 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:5FDD call near 0x7F27
        NearCall(cs1, 0x5FE0, unknown_100D_7F27_17FF7);
    label_100D_5FE0_160B0_26313:
        CheckExternalEvents(cs1, 0x5FE0);
        // 100D:5FE0 pop DI
        DI = Stack.Pop16();
        // 100D:5FE1 mov BP,0x20DA
        BP = (ushort)0x20DA;
        // 100D:5FE4 mov AX,word ptr SS:[BP+2]
        AX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:5FE7 and AH,0x1F
        AH = Alu8.And(AH, (byte)0x1F);
        // 100D:5FEA cmp byte ptr DS:[0x46FF],0
        Alu8.Sub(UInt8[DS, (ushort)0x46FF], (byte)0x00);
        // 100D:5FEF jne short 0x5FF4
        if (!ZeroFlag)
        {
            goto label_100D_5FF4_160C4_26320;
        }
    label_100D_5FF1_160C1_36533:
        CheckExternalEvents(cs1, 0x5FF1);
        // 100D:5FF1 or AH,0x40
        AH = Alu8.Or(AH, (byte)0x40);
    label_100D_5FF4_160C4_26320:
        CheckExternalEvents(cs1, 0x5FF4);
        // 100D:5FF4 mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:5FF7 jmp short 0x6003
        goto label_100D_6003_160D3_26323;
    label_100D_5FF9_160C9_36541:
        CheckExternalEvents(cs1, 0x5FF9);
        // 100D:5FF9 test byte ptr DS:[0x000A],0x40
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x40);
        // 100D:5FFE je short 0x600E
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:5FFE");
        }
    label_100D_6000_160D0_36544:
        CheckExternalEvents(cs1, 0x6000);
        // 100D:6000 mov BP,0x20E6
        BP = (ushort)0x20E6;
    label_100D_6003_160D3_26323:
        CheckExternalEvents(cs1, 0x6003);
        // 100D:6003 push BP
        Stack.Push16(BP);
        // 100D:6004 call near 0x600E
        NearCall(cs1, 0x6007, unknown_100D_600E_160DE);
    label_100D_6007_160D7_26568:
        CheckExternalEvents(cs1, 0x6007);
        // 100D:6007 pop BP
        BP = Stack.Pop16();
        // 100D:6008 mov BX,0x5F91
        BX = (ushort)0x5F91;
        // 100D:600B jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_7E97_17F67_33401:
        CheckExternalEvents(cs1, 0x7E97);
        // 100D:7E97 cmp byte ptr DS:[0x46F5],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F5], (byte)0x00);
        // 100D:7E9C je short 0x7EE1
        if (ZeroFlag)
        {
            return unknown_100D_7EE1_17FB1(0x0000);
        }
    label_100D_7E9E_17F6E_35068:
        CheckExternalEvents(cs1, 0x7E9E);
        // 100D:7E9E mov DI,0x1936
        DI = (ushort)0x1936;
        // 100D:7EA1 call near 0xD6FE
        NearCall(cs1, 0x7EA4, unknown_100D_D6FE_1D7CE);
    label_100D_7EA4_17F74_35071:
        CheckExternalEvents(cs1, 0x7EA4);
        // 100D:7EA4 jae short 0x7EE1
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7EA4");
        }
    label_100D_7EA6_17F76_35073:
        CheckExternalEvents(cs1, 0x7EA6);
        // 100D:7EA6 mov SI,0x4C7C
        SI = (ushort)0x4C7C;
        // 100D:7EA9 call near 0x7EE2
        NearCall(cs1, 0x7EAC, unknown_100D_7EE2_17FB2);
    label_100D_7EAC_17F7C_35076:
        CheckExternalEvents(cs1, 0x7EAC);
        // 100D:7EAC jae short 0x7EE1
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7EAC");
        }
    label_100D_7EAE_17F7E_35078:
        CheckExternalEvents(cs1, 0x7EAE);
        // 100D:7EAE dec byte ptr DS:[DI+0x4705]
        UInt8[DS, (ushort)(DI + (short)18181)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (short)18181)]);
        // 100D:7EB2 inc byte ptr DS:[DI+0x46FE]
        UInt8[DS, (ushort)(DI + (short)18174)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (short)18174)]);
        // 100D:7EB6 jmp short 0x7EDE
        goto label_100D_7EDE_17FAE_27768;
    label_100D_7EB8_17F88_27736:
        CheckExternalEvents(cs1, 0x7EB8);
        // 100D:7EB8 cmp byte ptr DS:[0x46F5],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F5], (byte)0x00);
        // 100D:7EBD je short 0x7EE1
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7EBD");
        }
    label_100D_7EBF_17F8F_27739:
        CheckExternalEvents(cs1, 0x7EBF);
        // 100D:7EBF mov DI,0x1940
        DI = (ushort)0x1940;
        // 100D:7EC2 call near 0xD6FE
        NearCall(cs1, 0x7EC5, unknown_100D_D6FE_1D7CE);
    label_100D_7EC5_17F95_27742:
        CheckExternalEvents(cs1, 0x7EC5);
        // 100D:7EC5 jae short 0x7EE1
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7EC5");
        }
    label_100D_7EC7_17F97_27744:
        CheckExternalEvents(cs1, 0x7EC7);
        // 100D:7EC7 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:7ECA call near 0x7EE2
        NearCall(cs1, 0x7ECD, unknown_100D_7EE2_17FB2);
    label_100D_7ECD_17F9D_27760:
        CheckExternalEvents(cs1, 0x7ECD);
        // 100D:7ECD jae short 0x7EE1
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:7ECD");
        }
    label_100D_7ECF_17F9F_27762:
        CheckExternalEvents(cs1, 0x7ECF);
        // 100D:7ECF cmp byte ptr DS:[DI+0x4705],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (short)18181)], (byte)0x00);
        // 100D:7ED4 jne short 0x7EE1
        if (!ZeroFlag)
        {
            return unknown_100D_7EE1_17FB1(0x0000);
        }
    label_100D_7ED6_17FA6_27765:
        CheckExternalEvents(cs1, 0x7ED6);
        // 100D:7ED6 inc byte ptr DS:[DI+0x4705]
        UInt8[DS, (ushort)(DI + (short)18181)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (short)18181)]);
        // 100D:7EDA dec byte ptr DS:[DI+0x46FE]
        UInt8[DS, (ushort)(DI + (short)18174)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (short)18174)]);
    label_100D_7EDE_17FAE_27768:
        CheckExternalEvents(cs1, 0x7EDE);
        // 100D:7EDE call near 0x7D0C
        NearCall(cs1, 0x7EE1, unknown_100D_7D0C_17DDC);
        return unknown_100D_7EE1_17FB1(0x0000);
    }

    public virtual Action unknown_100D_5CE4_15DB4(int loadOffset)
    {
    entrydispatcher:
    label_100D_5CE4_15DB4_29948:
        CheckExternalEvents(cs1, 0x5CE4);
        // 100D:5CE4 call near 0x5BEB
        NearCall(cs1, 0x5CE7, unknown_100D_5BEB_15CBB);
    label_100D_5CE7_15DB7_29950:
        CheckExternalEvents(cs1, 0x5CE7);
        // 100D:5CE7 call near 0xC13B
        NearCall(cs1, 0x5CEA, unknown_100D_C13B_1C20B);
    label_100D_5CEA_15DBA_29952:
        CheckExternalEvents(cs1, 0x5CEA);
        // 100D:5CEA cmp word ptr DS:[0xDBE2],0
        Alu16.Sub(UInt16[DS, (ushort)0xDBE2], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:5CEF jne short 0x5CE3
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:5CEF");
        }
    label_100D_5CF1_15DC1_29955:
        CheckExternalEvents(cs1, 0x5CF1);
        // 100D:5CF1 mov DI,word ptr DS:[0xDBE0]
        DI = UInt16[DS, (ushort)0xDBE0];
        // 100D:5CF5 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:5CF7 je short 0x5D04
        if (ZeroFlag)
        {
            goto label_100D_5D04_15DD4_29959;
        }
    label_100D_5CF9_15DC9_30113:
        CheckExternalEvents(cs1, 0x5CF9);
        // 100D:5CF9 cmp DI,0x18DF
        Alu16.Sub(DI, (ushort)0x18DF);
        // 100D:5CFD jne short 0x5CE3
        if (!ZeroFlag)
        {
            return unknown_100D_5CE3_15DB3(0x0000);
        }
    label_100D_5CFF_15DCF_30116:
        CheckExternalEvents(cs1, 0x5CFF);
        // 100D:5CFF call near 0xD6FE
        NearCall(cs1, 0x5D02, unknown_100D_D6FE_1D7CE);
    label_100D_5D02_15DD2_30118:
        CheckExternalEvents(cs1, 0x5D02);
        // 100D:5D02 jb short 0x5D1A
        if (CarryFlag)
        {
            goto label_100D_5D1A_15DEA_30120;
        }
    label_100D_5D04_15DD4_29959:
        CheckExternalEvents(cs1, 0x5D04);
        // 100D:5D04 call near 0x6946
        NearCall(cs1, 0x5D07, unknown_100D_6946_16A16);
    label_100D_5D07_15DD7_29965:
        CheckExternalEvents(cs1, 0x5D07);
        // 100D:5D07 jae short 0x5CE3
        if (!CarryFlag)
        {
            return unknown_100D_5CE3_15DB3(0x0000);
        }
    label_100D_5D09_15DD9_29967:
        CheckExternalEvents(cs1, 0x5D09);
        // 100D:5D09 mov SI,word ptr DS:[SI+0x0A]
        SI = UInt16[DS, (ushort)(SI + (sbyte)10)];
        // 100D:5D0C cmp SI,word ptr DS:[0x46FA]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x46FA]);
        // 100D:5D10 je short 0x5D1A
        if (ZeroFlag)
        {
            goto label_100D_5D1A_15DEA_30120;
        }
    label_100D_5D12_15DE2_29971:
        CheckExternalEvents(cs1, 0x5D12);
        // 100D:5D12 push SI
        Stack.Push16(SI);
        // 100D:5D13 call near 0x7B36
        NearCall(cs1, 0x5D16, unknown_100D_7B36_17C06);
    label_100D_5D16_15DE6_29974:
        CheckExternalEvents(cs1, 0x5D16);
        // 100D:5D16 pop SI
        SI = Stack.Pop16();
        // 100D:5D17 jmp near 0x78BC
        goto label_100D_78BC_1798C_29977;
    label_100D_5D1A_15DEA_30120:
        CheckExternalEvents(cs1, 0x5D1A);
        // 100D:5D1A jmp near 0x79DE
        if (JumpDispatcher.Jump(unknown_100D_79DE_17AAE, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_78BC_1798C_29977:
        CheckExternalEvents(cs1, 0x78BC);
        // 100D:78BC mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:78BF call near 0x7C63
        NearCall(cs1, 0x78C2, unknown_100D_7C63_17D33);
    label_100D_78C2_17992_29980:
        CheckExternalEvents(cs1, 0x78C2);
        // 100D:78C2 cmp AX,word ptr DS:[0x1176]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x1176]);
        // 100D:78C6 jae short 0x78BB
        if (!CarryFlag)
        {
            return unknown_100D_78BB_1798B(0x0000);
        }
    label_100D_78C8_17998_29983:
        CheckExternalEvents(cs1, 0x78C8);
        // 100D:78C8 call near 0x6917
        NearCall(cs1, 0x78CB, unknown_100D_6917_169E7);
    label_100D_78CB_1799B_29985:
        CheckExternalEvents(cs1, 0x78CB);
        // 100D:78CB jne short 0x78BB
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:78CB");
        }
    label_100D_78CD_1799D_29987:
        CheckExternalEvents(cs1, 0x78CD);
        // 100D:78CD call near 0xC08E
        NearCall(cs1, 0x78D0, unknown_100D_C08E_1C15E);
    label_100D_78D0_179A0_29989:
        CheckExternalEvents(cs1, 0x78D0);
        // 100D:78D0 mov word ptr DS:[0x46FA],SI
        UInt16[DS, (ushort)0x46FA] = SI;
        // 100D:78D4 push SI
        Stack.Push16(SI);
        // 100D:78D5 mov SI,0x18DF
        SI = (ushort)0x18DF;
        // 100D:78D8 mov BX,word ptr DS:[DI+2]
        BX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:78DB mov DX,word ptr DS:[DI]
        DX = UInt16[DS, DI];
        // 100D:78DD mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:78E0 call near 0x5F25
        NearCall(cs1, 0x78E3, unknown_100D_5F25_15FF5);
    label_100D_78E3_179B3_29997:
        CheckExternalEvents(cs1, 0x78E3);
        // 100D:78E3 pop SI
        SI = Stack.Pop16();
        // 100D:78E4 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:78E6 mov byte ptr DS:[0x1955],AL
        UInt8[DS, (ushort)0x1955] = AL;
        // 100D:78E9 call near 0x6917
        NearCall(cs1, 0x78EC, unknown_100D_6917_169E7);
    label_100D_78EC_179BC_30002:
        CheckExternalEvents(cs1, 0x78EC);
        // 100D:78EC je short 0x78F1
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:78EC");
        }
    label_100D_78F1_179C1_30004:
        CheckExternalEvents(cs1, 0x78F1);
        // 100D:78F1 call near 0xC08E
        NearCall(cs1, 0x78F4, unknown_100D_C08E_1C15E);
    label_100D_78F4_179C4_30006:
        CheckExternalEvents(cs1, 0x78F4);
        // 100D:78F4 call near 0x31F6
        NearCall(cs1, 0x78F7, unknown_100D_31F6_132C6);
    label_100D_78F7_179C7_30008:
        CheckExternalEvents(cs1, 0x78F7);
        // 100D:78F7 add word ptr DS:[0x11F3],0x000C
        UInt16[DS, (ushort)0x11F3] = Alu16.Add(UInt16[DS, (ushort)0x11F3], unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:78FC mov SI,0x18DF
        SI = (ushort)0x18DF;
        // 100D:78FF call near 0x7B1B
        NearCall(cs1, 0x7902, unknown_100D_7B1B_17BEB);
    label_100D_7902_179D2_30012:
        CheckExternalEvents(cs1, 0x7902);
        // 100D:7902 call near 0xD075
        NearCall(cs1, 0x7905, unknown_100D_D075_1D145);
    label_100D_7905_179D5_30014:
        CheckExternalEvents(cs1, 0x7905);
        // 100D:7905 mov CL,0x9A
        CL = (byte)0x9A;
        // 100D:7907 mov CH,byte ptr DS:[0x18E8]
        CH = UInt8[DS, (ushort)0x18E8];
        // 100D:790B mov DX,word ptr DS:[0x18DF]
        DX = UInt16[DS, (ushort)0x18DF];
        // 100D:790F mov BX,word ptr DS:[0x18E1]
        BX = UInt16[DS, (ushort)0x18E1];
        // 100D:7913 add DX,0x000C
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:7916 add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:7919 mov AX,0x003A
        AX = (ushort)0x003A;
        // 100D:791C test byte ptr DS:[0x0030],0x40
        Alu8.And(UInt8[DS, (ushort)0x0030], (byte)0x40);
        // 100D:7921 je short 0x7924
        if (ZeroFlag)
        {
            goto label_100D_7924_179F4_30024;
        }
    label_100D_7923_179F3_37312:
        CheckExternalEvents(cs1, 0x7923);
        // 100D:7923 inc AX
        AX = Alu16.Inc(AX);
    label_100D_7924_179F4_30024:
        CheckExternalEvents(cs1, 0x7924);
        // 100D:7924 call near 0x8865
        NearCall(cs1, 0x7927, unknown_100D_8865_18935);
    label_100D_7927_179F7_30049:
        CheckExternalEvents(cs1, 0x7927);
        // 100D:7927 mov CL,0x96
        CL = (byte)0x96;
        // 100D:7929 sub DX,8
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:792C add BX,9
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)9)));
        // 100D:792F mov DI,word ptr DS:[0x002C]
        DI = UInt16[DS, (ushort)0x002C];
        // 100D:7933 call near 0x62A6
        NearCall(cs1, 0x7936, unknown_100D_62A6_16376);
    label_100D_7936_17A06_30055:
        CheckExternalEvents(cs1, 0x7936);
        // 100D:7936 mov CL,0x9A
        CL = (byte)0x9A;
        // 100D:7938 add BX,0x000A
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:793B mov AL,byte ptr DS:[0x0030]
        AL = UInt8[DS, (ushort)0x0030];
        // 100D:793E test AL,0x20
        Alu8.And(AL, (byte)0x20);
        // 100D:7940 je short 0x794C
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7940");
        }
    label_100D_794C_17A1C_30061:
        CheckExternalEvents(cs1, 0x794C);
        // 100D:794C mov AX,0x003C
        AX = (ushort)0x003C;
        // 100D:794F call near 0x8865
        NearCall(cs1, 0x7952, unknown_100D_8865_18935);
    label_100D_7952_17A22_30066:
        CheckExternalEvents(cs1, 0x7952);
        // 100D:7952 add BX,0x000F
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:7955 cmp byte ptr DS:[0x0030],2
        Alu8.Sub(UInt8[DS, (ushort)0x0030], (byte)0x02);
        // 100D:795A je short 0x79BC
        if (ZeroFlag)
        {
            goto label_100D_79BC_17A8C_30101;
        }
    label_100D_795C_17A2C_30070:
        CheckExternalEvents(cs1, 0x795C);
        // 100D:795C mov AL,byte ptr DS:[0x002F]
        AL = UInt8[DS, (ushort)0x002F];
        // 100D:795F shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:7961 and AX,6
        AX = Alu16.And(AX, (ushort)0x0006);
        // 100D:7964 add AX,0x11F7
        AX = Alu16.Add(AX, (ushort)0x11F7);
        // 100D:7967 mov SI,AX
        SI = AX;
        // 100D:7969 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:796B call near 0xD194
        NearCall(cs1, 0x796E, unknown_100D_D194_1D264);
    label_100D_796E_17A3E_30078:
        CheckExternalEvents(cs1, 0x796E);
        // 100D:796E add BX,0x000A
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:7971 test byte ptr DS:[0x0030],0x40
        Alu8.And(UInt8[DS, (ushort)0x0030], (byte)0x40);
        // 100D:7976 jne short 0x79BC
        if (!ZeroFlag)
        {
            goto label_100D_79BC_17A8C_30101;
        }
    label_100D_7978_17A48_30082:
        CheckExternalEvents(cs1, 0x7978);
        // 100D:7978 mov AX,0x003F
        AX = (ushort)0x003F;
        // 100D:797B test word ptr DS:[0x0032],0x0200
        Alu16.And(UInt16[DS, (ushort)0x0032], (ushort)0x0200);
        // 100D:7981 jne short 0x79B6
        if (!ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_7983_17A53_30086:
        CheckExternalEvents(cs1, 0x7983);
        // 100D:7983 mov AX,0x0040
        AX = (ushort)0x0040;
        // 100D:7986 test word ptr DS:[0x0032],0x0100
        Alu16.And(UInt16[DS, (ushort)0x0032], (ushort)0x0100);
        // 100D:798C je short 0x79B6
        if (ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_798E_17A5E_30090:
        CheckExternalEvents(cs1, 0x798E);
        // 100D:798E test word ptr DS:[0x0034],0x0030
        Alu16.And(UInt16[DS, (ushort)0x0034], (ushort)0x0030);
        // 100D:7994 jne short 0x79B6
        if (!ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_7996_17A66_30093:
        CheckExternalEvents(cs1, 0x7996);
        // 100D:7996 mov AX,0x003D
        AX = (ushort)0x003D;
        // 100D:7999 cmp byte ptr DS:[0x0030],0
        Alu8.Sub(UInt8[DS, (ushort)0x0030], (byte)0x00);
        // 100D:799E je short 0x79B6
        if (ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_79A0_17A70_36104:
        CheckExternalEvents(cs1, 0x79A0);
        // 100D:79A0 mov AX,0x0043
        AX = (ushort)0x0043;
        // 100D:79A3 cmp byte ptr DS:[0x002F],1
        Alu8.Sub(UInt8[DS, (ushort)0x002F], (byte)0x01);
        // 100D:79A8 je short 0x79B6
        if (ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_79AA_17A7A_36108:
        CheckExternalEvents(cs1, 0x79AA);
        // 100D:79AA mov AX,0x003E
        AX = (ushort)0x003E;
        // 100D:79AD cmp byte ptr DS:[0x0030],6
        Alu8.Sub(UInt8[DS, (ushort)0x0030], (byte)0x06);
        // 100D:79B2 je short 0x79B6
        if (ZeroFlag)
        {
            goto label_100D_79B6_17A86_30097;
        }
    label_100D_79B4_17A84_36112:
        CheckExternalEvents(cs1, 0x79B4);
        // 100D:79B4 jmp short 0x79BC
        goto label_100D_79BC_17A8C_30101;
    label_100D_79B6_17A86_30097:
        CheckExternalEvents(cs1, 0x79B6);
        // 100D:79B6 call near 0x8865
        NearCall(cs1, 0x79B9, unknown_100D_8865_18935);
    label_100D_79B9_17A89_30099:
        CheckExternalEvents(cs1, 0x79B9);
        // 100D:79B9 add BX,0x0011
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)17)));
    label_100D_79BC_17A8C_30101:
        CheckExternalEvents(cs1, 0x79BC);
        // 100D:79BC add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:79BF mov AX,0x006E
        AX = (ushort)0x006E;
        // 100D:79C2 mov CL,0x96
        CL = (byte)0x96;
        // 100D:79C4 call near 0xD194
        NearCall(cs1, 0x79C7, unknown_100D_D194_1D264);
    label_100D_79C7_17A97_30105:
        CheckExternalEvents(cs1, 0x79C7);
        // 100D:79C7 add BX,8
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:79CA mov SI,word ptr DS:[0x46FA]
        SI = UInt16[DS, (ushort)0x46FA];
        // 100D:79CE call near 0x7EFB
        NearCall(cs1, 0x79D1, unknown_100D_7EFB_17FCB);
    label_100D_79D1_17AA1_30109:
        CheckExternalEvents(cs1, 0x79D1);
        // 100D:79D1 mov SI,0x4705
        SI = (ushort)0x4705;
        // 100D:79D4 mov BP,word ptr DS:[0x18E5]
        BP = UInt16[DS, (ushort)0x18E5];
        // 100D:79D8 call near 0x7E3D
        NearCall(cs1, 0x79DB, unknown_100D_7E3D_17F0D);
        return unknown_100D_79DB_17AAB(0x0000);
    }

    public virtual Action unknown_100D_5D1D_15DED(int loadOffset)
    {
    label_100D_5D1D_15DED_21070:
        CheckExternalEvents(cs1, 0x5D1D);
        // 100D:5D1D cmp DX,word ptr DS:[0x46E3]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E3]);
        // 100D:5D21 cmc
        CarryFlag = !CarryFlag;
        // 100D:5D22 jae short 0x5D35
        if (!CarryFlag)
        {
            goto label_100D_5D35_15E05_21083;
        }
    label_100D_5D24_15DF4_21074:
        CheckExternalEvents(cs1, 0x5D24);
        // 100D:5D24 cmp DX,word ptr DS:[0x46E7]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x46E7]);
        // 100D:5D28 jae short 0x5D35
        if (!CarryFlag)
        {
            goto label_100D_5D35_15E05_21083;
        }
    label_100D_5D2A_15DFA_21077:
        CheckExternalEvents(cs1, 0x5D2A);
        // 100D:5D2A cmp BX,word ptr DS:[0x46E5]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x46E5]);
        // 100D:5D2E cmc
        CarryFlag = !CarryFlag;
        // 100D:5D2F jae short 0x5D35
        if (!CarryFlag)
        {
            goto label_100D_5D35_15E05_21083;
        }
    label_100D_5D31_15E01_21081:
        CheckExternalEvents(cs1, 0x5D31);
        // 100D:5D31 cmp BX,word ptr DS:[0x46E9]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x46E9]);
    label_100D_5D35_15E05_21083:
        CheckExternalEvents(cs1, 0x5D35);
        // 100D:5D35 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5D36_15E06(int loadOffset)
    {
    label_100D_5D36_15E06_22094:
        CheckExternalEvents(cs1, 0x5D36);
        // 100D:5D36 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:5D3A jb short 0x5D43
        if (CarryFlag)
        {
            goto label_100D_5D43_15E13_22097;
        }
    label_100D_5D3C_15E0C_26714:
        CheckExternalEvents(cs1, 0x5D3C);
        // 100D:5D3C test byte ptr DS:[DI+0x0A],8
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x08);
        // 100D:5D40 je short 0x5D43
        if (ZeroFlag)
        {
            goto label_100D_5D43_15E13_22097;
        }
    label_100D_5D42_15E12_36499:
        CheckExternalEvents(cs1, 0x5D42);
        // 100D:5D42 stc
        CarryFlag = true;
    label_100D_5D43_15E13_22097:
        CheckExternalEvents(cs1, 0x5D43);
        // 100D:5D43 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5D50_15E20(int loadOffset)
    {
    label_100D_5D50_15E20_34308:
        CheckExternalEvents(cs1, 0x5D50);
        // 100D:5D50 push SI
        Stack.Push16(SI);
        // 100D:5D51 push DI
        Stack.Push16(DI);
        // 100D:5D52 test byte ptr DS:[DI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x80);
        // 100D:5D56 jne short 0x5D6A
        if (!ZeroFlag)
        {
            goto label_100D_5D6A_15E3A_34316;
        }
    label_100D_5D58_15E28_34313:
        CheckExternalEvents(cs1, 0x5D58);
        // 100D:5D58 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:5D5D je short 0x5D6A
        if (ZeroFlag)
        {
            goto label_100D_5D6A_15E3A_34316;
        }
    label_100D_5D5F_15E2F_35950:
        CheckExternalEvents(cs1, 0x5D5F);
        // 100D:5D5F mov SI,DI
        SI = DI;
        // 100D:5D61 call near 0x62C9
        NearCall(cs1, 0x5D64, unknown_100D_62C9_16399);
    label_100D_5D64_15E34_35953:
        CheckExternalEvents(cs1, 0x5D64);
        // 100D:5D64 jb short 0x5D6A
        if (CarryFlag)
        {
            goto label_100D_5D6A_15E3A_34316;
        }
    label_100D_5D66_15E36_35955:
        CheckExternalEvents(cs1, 0x5D66);
        // 100D:5D66 inc byte ptr DS:[0x46EC]
        UInt8[DS, (ushort)0x46EC] = Alu8.Inc(UInt8[DS, (ushort)0x46EC]);
    label_100D_5D6A_15E3A_34316:
        CheckExternalEvents(cs1, 0x5D6A);
        // 100D:5D6A pop DI
        DI = Stack.Pop16();
        // 100D:5D6B pop SI
        SI = Stack.Pop16();
        // 100D:5D6C ret near
        return NearRet((ushort)0x0000);
    }
}
