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
    public virtual Action unknown_100D_15DF_116AF(int loadOffset)
    {
    entrydispatcher:
    label_100D_15DF_116AF_41877:
        CheckExternalEvents(cs1, 0x15DF);
        // 100D:15DF mov DX,0x2006
        DX = (ushort)0x2006;
        // 100D:15E2 call near 0x097E
        NearCall(cs1, 0x15E5, unknown_100D_097E_10A4E);
    label_100D_15E5_116B5_41882:
        CheckExternalEvents(cs1, 0x15E5);
        // 100D:15E5 mov AL,4
        AL = (byte)0x04;
        // 100D:15E7 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_15EA_116BA(int loadOffset)
    {
    entrydispatcher:
    label_100D_15EA_116BA_41887:
        CheckExternalEvents(cs1, 0x15EA);
        // 100D:15EA mov DX,0x2004
        DX = (ushort)0x2004;
        // 100D:15ED call near 0x097E
        NearCall(cs1, 0x15F0, unknown_100D_097E_10A4E);
    label_100D_15F0_116C0_41892:
        CheckExternalEvents(cs1, 0x15F0);
        // 100D:15F0 mov AL,3
        AL = (byte)0x03;
        // 100D:15F2 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_15F5_116C5(int loadOffset)
    {
    entrydispatcher:
    label_100D_15F5_116C5_41897:
        CheckExternalEvents(cs1, 0x15F5);
        // 100D:15F5 mov DX,0x3002
        DX = (ushort)0x3002;
        // 100D:15F8 mov BX,0x0280
        BX = (ushort)0x0280;
        // 100D:15FB call near 0x0981
        NearCall(cs1, 0x15FE, unknown_100D_0981_10A51);
    label_100D_15FE_116CE_41904:
        CheckExternalEvents(cs1, 0x15FE);
        // 100D:15FE mov AL,0x0B
        AL = (byte)0x0B;
        // 100D:1600 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1603_116D3(int loadOffset)
    {
    entrydispatcher:
    label_100D_1603_116D3_41943:
        CheckExternalEvents(cs1, 0x1603);
        // 100D:1603 mov DX,0x3002
        DX = (ushort)0x3002;
        // 100D:1606 mov BX,0x0280
        BX = (ushort)0x0280;
        // 100D:1609 call near 0x0981
        NearCall(cs1, 0x160C, unknown_100D_0981_10A51);
    label_100D_160C_116DC_41950:
        CheckExternalEvents(cs1, 0x160C);
        // 100D:160C mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:160E mov DX,0x003A
        DX = (ushort)0x003A;
        // 100D:1611 call near 0x09C7
        NearCall(cs1, 0x1614, unknown_100D_09C7_10A97);
    label_100D_1614_116E4_41957:
        CheckExternalEvents(cs1, 0x1614);
        // 100D:1614 jmp near 0x978E
        if (JumpDispatcher.Jump(unknown_100D_978E_1985E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1617_116E7(int loadOffset)
    {
    entrydispatcher:
    label_100D_1617_116E7_41909:
        CheckExternalEvents(cs1, 0x1617);
        // 100D:1617 mov BX,0x1180
        BX = (ushort)0x1180;
        // 100D:161A mov DX,0x0703
        DX = (ushort)0x0703;
        // 100D:161D call near 0x0981
        NearCall(cs1, 0x1620, unknown_100D_0981_10A51);
    label_100D_1620_116F0_41916:
        CheckExternalEvents(cs1, 0x1620);
        // 100D:1620 mov AL,8
        AL = (byte)0x08;
        // 100D:1622 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1625_116F5(int loadOffset)
    {
    entrydispatcher:
    label_100D_1625_116F5_41921:
        CheckExternalEvents(cs1, 0x1625);
        // 100D:1625 mov DX,0x2008
        DX = (ushort)0x2008;
        // 100D:1628 call near 0x097E
        NearCall(cs1, 0x162B, unknown_100D_097E_10A4E);
    label_100D_162B_116FB_41926:
        CheckExternalEvents(cs1, 0x162B);
        // 100D:162B mov AL,2
        AL = (byte)0x02;
        // 100D:162D jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1630_11700(int loadOffset)
    {
    entrydispatcher:
    label_100D_1630_11700_41931:
        CheckExternalEvents(cs1, 0x1630);
        // 100D:1630 mov BX,0x1080
        BX = (ushort)0x1080;
        // 100D:1633 mov DX,0x0802
        DX = (ushort)0x0802;
        // 100D:1636 call near 0x0981
        NearCall(cs1, 0x1639, unknown_100D_0981_10A51);
    label_100D_1639_11709_41938:
        CheckExternalEvents(cs1, 0x1639);
        // 100D:1639 mov AL,5
        AL = (byte)0x05;
        // 100D:163B jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_163E_1170E(int loadOffset)
    {
    entrydispatcher:
    label_100D_163E_1170E_41972:
        CheckExternalEvents(cs1, 0x163E);
        // 100D:163E mov BX,0x3F80
        BX = (ushort)0x3F80;
        // 100D:1641 mov DX,0x1005
        DX = (ushort)0x1005;
        // 100D:1644 call near 0x0981
        NearCall(cs1, 0x1647, unknown_100D_0981_10A51);
    label_100D_1647_11717_41979:
        CheckExternalEvents(cs1, 0x1647);
        // 100D:1647 mov AL,6
        AL = (byte)0x06;
        // 100D:1649 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_164C_1171C(int loadOffset)
    {
    entrydispatcher:
    label_100D_164C_1171C_41960:
        CheckExternalEvents(cs1, 0x164C);
        // 100D:164C mov BX,0x1080
        BX = (ushort)0x1080;
        // 100D:164F mov DX,0x0803
        DX = (ushort)0x0803;
        // 100D:1652 call near 0x0981
        NearCall(cs1, 0x1655, unknown_100D_0981_10A51);
    label_100D_1655_11725_41967:
        CheckExternalEvents(cs1, 0x1655);
        // 100D:1655 mov AL,7
        AL = (byte)0x07;
        // 100D:1657 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1707_117D7(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_1707_117D7_28375;

    label_100D_13A0_11470_28394:
        CheckExternalEvents(cs1, 0x13A0);
        // 100D:13A0 call near 0x1399
        NearCall(cs1, 0x13A3, unknown_100D_1399_11469);
    label_100D_13A3_11473_28399:
        CheckExternalEvents(cs1, 0x13A3);
        // 100D:13A3 or byte ptr DS:[0x46EB],0x40
        UInt8[DS, (ushort)0x46EB] = Alu8.Or(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:13A8 jmp short 0x13B6
        goto label_100D_13B6_11486_28402;
    label_100D_13AA_1147A_29003:
        CheckExternalEvents(cs1, 0x13AA);
        // 100D:13AA call near 0x58FA
        NearCall(cs1, 0x13AD, unknown_100D_58FA_159CA);
    label_100D_13AD_1147D_29022:
        CheckExternalEvents(cs1, 0x13AD);
        // 100D:13AD call near 0xC08E
        NearCall(cs1, 0x13B0, unknown_100D_C08E_1C15E);
    label_100D_13B0_11480_29024:
        CheckExternalEvents(cs1, 0x13B0);
        // 100D:13B0 mov SI,0x18E9
        SI = (ushort)0x18E9;
        // 100D:13B3 call near 0xC551
        NearCall(cs1, 0x13B6, unknown_100D_C551_1C621);
    label_100D_13B6_11486_28402:
        CheckExternalEvents(cs1, 0x13B6);
        // 100D:13B6 mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:13B9 call near 0xC08E
        NearCall(cs1, 0x13BC, unknown_100D_C08E_1C15E);
    label_100D_13BC_1148C_28405:
        CheckExternalEvents(cs1, 0x13BC);
        // 100D:13BC call near 0x9761
        NearCall(cs1, 0x13BF, unknown_100D_9761_19831);
    label_100D_13BF_1148F_28903:
        CheckExternalEvents(cs1, 0x13BF);
        // 100D:13BF call near 0x9EFD
        NearCall(cs1, 0x13C2, unknown_100D_9EFD_19FCD);
    label_100D_13C2_11492_28905:
        CheckExternalEvents(cs1, 0x13C2);
        // 100D:13C2 call near 0x9901
        NearCall(cs1, 0x13C5, unknown_100D_9901_199D1);
    label_100D_13C5_11495_28907:
        CheckExternalEvents(cs1, 0x13C5);
        // 100D:13C5 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    label_100D_13E4_114B4_30393:
        CheckExternalEvents(cs1, 0x13E4);
        // 100D:13E4 call near 0x1399
        NearCall(cs1, 0x13E7, unknown_100D_1399_11469);
    label_100D_13E7_114B7_30395:
        CheckExternalEvents(cs1, 0x13E7);
        // 100D:13E7 push SI
        Stack.Push16(SI);
        // 100D:13E8 call near 0x8C8A
        NearCall(cs1, 0x13EB, unknown_100D_8C8A_18D5A);
    label_100D_13EB_114BB_30398:
        CheckExternalEvents(cs1, 0x13EB);
        // 100D:13EB pop SI
        SI = Stack.Pop16();
        // 100D:13EC lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:13EE inc word ptr DS:[0x477A]
        UInt16[DS, (ushort)0x477A] = Alu16.Inc(UInt16[DS, (ushort)0x477A]);
        // 100D:13F2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:13F4 cmp AX,word ptr DS:[0x47C4]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x47C4]);
        // 100D:13F8 je short 0x1408
        if (ZeroFlag)
        {
            goto label_100D_1408_114D8_30408;
        }
    label_100D_13FA_114CA_30405:
        CheckExternalEvents(cs1, 0x13FA);
        // 100D:13FA cmp byte ptr DS:[0x47A4],AH
        Alu8.Sub(UInt8[DS, (ushort)0x47A4], AH);
        // 100D:13FE jns short 0x1408
        if (!SignFlag)
        {
            goto label_100D_1408_114D8_30408;
        }
    label_100D_1400_114D0_30410:
        CheckExternalEvents(cs1, 0x1400);
        // 100D:1400 push AX
        Stack.Push16(AX);
        // 100D:1401 mov BP,0x2DB1
        BP = (ushort)0x2DB1;
        // 100D:1404 call near 0xC097
        NearCall(cs1, 0x1407, unknown_100D_C097_1C167);
    label_100D_1407_114D7_30414:
        CheckExternalEvents(cs1, 0x1407);
        // 100D:1407 pop AX
        AX = Stack.Pop16();
    label_100D_1408_114D8_30408:
        CheckExternalEvents(cs1, 0x1408);
        // 100D:1408 jmp near 0x9761
        if (JumpDispatcher.Jump(unknown_100D_9761_19831, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_140B_114DB_30416:
        CheckExternalEvents(cs1, 0x140B);
        // 100D:140B call near 0x1392
        NearCall(cs1, 0x140E, unknown_100D_1392_11462);
    label_100D_140E_114DE_30418:
        CheckExternalEvents(cs1, 0x140E);
        // 100D:140E lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:1410 inc word ptr DS:[0x477A]
        UInt16[DS, (ushort)0x477A] = Alu16.Inc(UInt16[DS, (ushort)0x477A]);
        // 100D:1414 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:1416 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:1419 call near 0x978E
        NearCall(cs1, 0x141C, unknown_100D_978E_1985E);
    label_100D_141C_114EC_30424:
        CheckExternalEvents(cs1, 0x141C);
        // 100D:141C call near 0x9B8B
        NearCall(cs1, 0x141F, unknown_100D_9B8B_19C5B);
    label_100D_141F_114EF_30426:
        CheckExternalEvents(cs1, 0x141F);
        // 100D:141F jmp near 0x1707
        goto label_100D_1707_117D7_28375;
    label_100D_1422_114F2_34621:
        CheckExternalEvents(cs1, 0x1422);
        // 100D:1422 call near 0x1392
        NearCall(cs1, 0x1425, unknown_100D_1392_11462);
    label_100D_1425_114F5_34623:
        CheckExternalEvents(cs1, 0x1425);
        // 100D:1425 call near 0x1AE0
        NearCall(cs1, 0x1428, unknown_100D_1AE0_11BB0);
    label_100D_1428_114F8_34625:
        CheckExternalEvents(cs1, 0x1428);
        // 100D:1428 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:142A jae short 0x1434
        if (!CarryFlag)
        {
            goto label_100D_1434_11504_34633;
        }
    label_100D_142C_114FC_34628:
        CheckExternalEvents(cs1, 0x142C);
        // 100D:142C mov CX,1
        CX = (ushort)0x0001;
        // 100D:142F call near 0x0FD9
        NearCall(cs1, 0x1432, unknown_100D_0FD9_110A9);
    label_100D_1432_11502_34631:
        CheckExternalEvents(cs1, 0x1432);
        // 100D:1432 jmp short 0x1422
        goto label_100D_1422_114F2_34621;
    label_100D_1434_11504_34633:
        CheckExternalEvents(cs1, 0x1434);
        // 100D:1434 call near 0x390A
        NearCall(cs1, 0x1437, unknown_100D_390A_139DA);
    label_100D_1437_11507_34639:
        CheckExternalEvents(cs1, 0x1437);
        // 100D:1437 call near 0x37B2
        NearCall(cs1, 0x143A, unknown_100D_37B2_13882);
    label_100D_143A_1150A_34641:
        CheckExternalEvents(cs1, 0x143A);
        // 100D:143A call near 0xC412
        NearCall(cs1, 0x143D, unknown_100D_C412_1C4E2);
    label_100D_143D_1150D_34643:
        CheckExternalEvents(cs1, 0x143D);
        // 100D:143D mov SI,0x2290
        SI = (ushort)0x2290;
        // 100D:1440 jmp short 0x1465
        goto label_100D_1465_11535_34646;
    label_100D_1442_11512_34655:
        CheckExternalEvents(cs1, 0x1442);
        // 100D:1442 call near 0x1392
        NearCall(cs1, 0x1445, unknown_100D_1392_11462);
    label_100D_1445_11515_34657:
        CheckExternalEvents(cs1, 0x1445);
        // 100D:1445 call near 0x37B2
        NearCall(cs1, 0x1448, unknown_100D_37B2_13882);
    label_100D_1448_11518_34659:
        CheckExternalEvents(cs1, 0x1448);
        // 100D:1448 mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:144C push DS
        Stack.Push16(DS);
        // 100D:144D mov DS,word ptr DS:[0xDBDA]
        DS = UInt16[DS, (ushort)0xDBDA];
        // 100D:1451 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:1453 mov BX,0x0032
        BX = (ushort)0x0032;
        // 100D:1456 mov BP,3
        BP = (ushort)0x0003;
        // 100D:1459 call far dword ptr SS:[0x3949]
        ushort targetSegment_34666 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3949 + (ushort)0x0002)]));
        ushort targetOffset_34666 = unchecked((ushort)(UInt16[SS, (ushort)0x3949]));
        if (targetSegment_34666 == cs2 && targetOffset_34666 == 0x016F)
        {
            FarCall(cs1, 0x145E, cs2, unknown_3358_016F_336EF);
            goto label_100D_145E_1152E_34667;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_34666:X4}:{targetOffset_34666:X4} at 100D:1459");
    label_100D_145E_1152E_34667:
        CheckExternalEvents(cs1, 0x145E);
        // 100D:145E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:145F call near 0xC43E
        NearCall(cs1, 0x1462, unknown_100D_C43E_1C50E);
    label_100D_1462_11532_34670:
        CheckExternalEvents(cs1, 0x1462);
        // 100D:1462 mov SI,0x2298
        SI = (ushort)0x2298;
    label_100D_1465_11535_34646:
        CheckExternalEvents(cs1, 0x1465);
        // 100D:1465 mov AX,0x0027
        AX = (ushort)0x0027;
        // 100D:1468 call near 0xC13E
        NearCall(cs1, 0x146B, unknown_100D_C13E_1C20E);
    label_100D_146B_1153B_34649:
        CheckExternalEvents(cs1, 0x146B);
        // 100D:146B call near 0xC21B
        NearCall(cs1, 0x146E, unknown_100D_C21B_1C2EB);
    label_100D_146E_1153E_34651:
        CheckExternalEvents(cs1, 0x146E);
        // 100D:146E call near 0xC0F4
        NearCall(cs1, 0x1471, unknown_100D_C0F4_1C1C4);
    label_100D_1471_11541_34653:
        CheckExternalEvents(cs1, 0x1471);
        // 100D:1471 jmp near 0xC4DD
        return unknown_100D_C4DD_1C5AD(0x0000);
    label_100D_1474_11544_30391:
        CheckExternalEvents(cs1, 0x1474);
        // 100D:1474 ret near
        return NearRet((ushort)0x0000);
    label_100D_148D_1155D_41312:
        CheckExternalEvents(cs1, 0x148D);
        // 100D:148D call near 0x1392
        NearCall(cs1, 0x1490, unknown_100D_1392_11462);
    label_100D_1490_11560_41315:
        CheckExternalEvents(cs1, 0x1490);
        // 100D:1490 mov AL,0x10
        AL = (byte)0x10;
        // 100D:1492 mov BP,0x1498
        BP = (ushort)0x1498;
        // 100D:1495 jmp near 0xC108
        if (JumpDispatcher.Jump(unknown_100D_C108_1C1D8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_14C9_11599_41335:
        CheckExternalEvents(cs1, 0x14C9);
        // 100D:14C9 mov SI,0x176B
        SI = (ushort)0x176B;
        // 100D:14CC call near 0xDA5F
        NearCall(cs1, 0x14CF, unknown_100D_DA5F_1DB2F);
    label_100D_14CF_1159F_41340:
        CheckExternalEvents(cs1, 0x14CF);
        // 100D:14CF mov CX,0x0150
        CX = (ushort)0x0150;
        // 100D:14D2 mov BX,0x0180
        BX = (ushort)0x0180;
        // 100D:14D5 mov BP,1
        BP = (ushort)0x0001;
        // 100D:14D8 mov AL,0x28
        AL = (byte)0x28;
        // 100D:14DA call near 0x157E
        NearCall(cs1, 0x14DD, unknown_100D_157E_1164E);
    label_100D_14DD_115AD_41388:
        CheckExternalEvents(cs1, 0x14DD);
        // 100D:14DD call near 0x1566
        NearCall(cs1, 0x14E0, unknown_100D_1566_11636);
    label_100D_14E0_115B0_41421:
        CheckExternalEvents(cs1, 0x14E0);
        // 100D:14E0 mov BP,0x14AC
        BP = (ushort)0x14AC;
        // 100D:14E3 call near 0xC097
        NearCall(cs1, 0x14E6, unknown_100D_C097_1C167);
    label_100D_14E6_115B6_41459:
        CheckExternalEvents(cs1, 0x14E6);
        // 100D:14E6 call far dword ptr DS:[0x3959]
        ushort targetSegment_41459 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_41459 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_41459 == cs2 && targetOffset_41459 == 0x017B)
        {
            FarCall(cs1, 0x14EA, cs2, unknown_3358_017B_336FB);
            goto label_100D_14EA_115BA_41461;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41459:X4}:{targetOffset_41459:X4} at 100D:14E6");
    label_100D_14EA_115BA_41461:
        CheckExternalEvents(cs1, 0x14EA);
        // 100D:14EA mov CX,0x00E4
        CX = (ushort)0x00E4;
        // 100D:14ED mov BX,0x0129
        BX = (ushort)0x0129;
        // 100D:14F0 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:14F2 mov AL,0x30
        AL = (byte)0x30;
        // 100D:14F4 call near 0x157E
        NearCall(cs1, 0x14F7, unknown_100D_157E_1164E);
    label_100D_14F7_115C7_41476:
        CheckExternalEvents(cs1, 0x14F7);
        // 100D:14F7 call far dword ptr DS:[0x3935]
        ushort targetSegment_41476 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_41476 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_41476 == cs2 && targetOffset_41476 == 0x0160)
        {
            FarCall(cs1, 0x14FB, cs2, unknown_3358_0160_336E0);
            goto label_100D_14FB_115CB_41478;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41476:X4}:{targetOffset_41476:X4} at 100D:14F7");
    label_100D_14FB_115CB_41478:
        CheckExternalEvents(cs1, 0x14FB);
        // 100D:14FB call near 0xC4DD
        NearCall(cs1, 0x14FE, unknown_100D_C4DD_1C5AD);
    label_100D_14FE_115CE_41481:
        CheckExternalEvents(cs1, 0x14FE);
        // 100D:14FE call near 0x1566
        NearCall(cs1, 0x1501, unknown_100D_1566_11636);
    label_100D_1501_115D1_41484:
        CheckExternalEvents(cs1, 0x1501);
        // 100D:1501 call near 0x9B8B
        NearCall(cs1, 0x1504, unknown_100D_9B8B_19C5B);
    label_100D_1504_115D4_41487:
        CheckExternalEvents(cs1, 0x1504);
        // 100D:1504 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:1507 mov AL,0x8F
        AL = (byte)0x8F;
        // 100D:1509 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:150D call far dword ptr DS:[0x38DD]
        ushort targetSegment_41491 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_41491 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_41491 == cs2 && targetOffset_41491 == 0x011E)
        {
            FarCall(cs1, 0x1511, cs2, unknown_3358_011E_3369E);
            goto label_100D_1511_115E1_41495;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41491:X4}:{targetOffset_41491:X4} at 100D:150D");
    label_100D_1511_115E1_41495:
        CheckExternalEvents(cs1, 0x1511);
        // 100D:1511 mov AX,0x001E
        AX = (ushort)0x001E;
        // 100D:1514 call near 0xC13E
        NearCall(cs1, 0x1517, unknown_100D_C13E_1C20E);
    label_100D_1517_115E7_41500:
        CheckExternalEvents(cs1, 0x1517);
        // 100D:1517 mov AX,3
        AX = (ushort)0x0003;
        // 100D:151A mov DX,0x0034
        DX = (ushort)0x0034;
        // 100D:151D xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:151F call near 0xC22F
        NearCall(cs1, 0x1522, unknown_100D_C22F_1C2FF);
    label_100D_1522_115F2_41509:
        CheckExternalEvents(cs1, 0x1522);
        // 100D:1522 mov AL,0x22
        AL = (byte)0x22;
        // 100D:1524 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:1527 call near 0xC108
        NearCall(cs1, 0x152A, unknown_100D_C108_1C1D8);
    label_100D_152A_115FA_41638:
        CheckExternalEvents(cs1, 0x152A);
        // 100D:152A mov AX,0x012C
        AX = (ushort)0x012C;
        // 100D:152D call near 0xE387
        NearCall(cs1, 0x1530, unknown_100D_E387_1E457);
    label_100D_1530_11600_41643:
        CheckExternalEvents(cs1, 0x1530);
        // 100D:1530 mov CX,0x002D
        CX = (ushort)0x002D;
        // 100D:1533 mov BX,0x01E0
        BX = (ushort)0x01E0;
        // 100D:1536 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:1538 mov AL,0x20
        AL = (byte)0x20;
        // 100D:153A call near 0x157E
        NearCall(cs1, 0x153D, unknown_100D_157E_1164E);
    label_100D_153D_1160D_41654:
        CheckExternalEvents(cs1, 0x153D);
        // 100D:153D mov AX,4
        AX = (ushort)0x0004;
        // 100D:1540 mov DX,0x005A
        DX = (ushort)0x005A;
        // 100D:1543 mov BX,0x0040
        BX = (ushort)0x0040;
        // 100D:1546 call near 0xC22F
        NearCall(cs1, 0x1549, unknown_100D_C22F_1C2FF);
    label_100D_1549_11619_41663:
        CheckExternalEvents(cs1, 0x1549);
        // 100D:1549 call far dword ptr DS:[0x3935]
        ushort targetSegment_41663 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_41663 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_41663 == cs2 && targetOffset_41663 == 0x0160)
        {
            FarCall(cs1, 0x154D, cs2, unknown_3358_0160_336E0);
            goto label_100D_154D_1161D_41665;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41663:X4}:{targetOffset_41663:X4} at 100D:1549");
    label_100D_154D_1161D_41665:
        CheckExternalEvents(cs1, 0x154D);
        // 100D:154D call near 0xC4DD
        NearCall(cs1, 0x1550, unknown_100D_C4DD_1C5AD);
    label_100D_1550_11620_41668:
        CheckExternalEvents(cs1, 0x1550);
        // 100D:1550 call near 0x1566
        NearCall(cs1, 0x1553, unknown_100D_1566_11636);
    label_100D_1553_11623_41671:
        CheckExternalEvents(cs1, 0x1553);
        // 100D:1553 jmp near 0x178E
        return unknown_100D_178E_1185E(0x0000);
    label_100D_167C_1174C_41675:
        CheckExternalEvents(cs1, 0x167C);
        // 100D:167C xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:167E mov byte ptr DS:[0x4774],AL
        UInt8[DS, (ushort)0x4774] = AL;
        // 100D:1681 mov word ptr DS:[0x0012],AX
        UInt16[DS, (ushort)0x0012] = AX;
        // 100D:1684 mov word ptr DS:[0x0010],AX
        UInt16[DS, (ushort)0x0010] = AX;
        // 100D:1687 dec AX
        AX = Alu16.Dec(AX);
        // 100D:1688 mov word ptr DS:[0x22A6],AX
        UInt16[DS, (ushort)0x22A6] = AX;
        // 100D:168B call near 0xC0AD
        NearCall(cs1, 0x168E, unknown_100D_C0AD_1C17D);
    label_100D_168E_1175E_41690:
        CheckExternalEvents(cs1, 0x168E);
        // 100D:168E inc byte ptr DS:[0x227D]
        UInt8[DS, (ushort)0x227D] = Alu8.Inc(UInt8[DS, (ushort)0x227D]);
        // 100D:1692 mov byte ptr DS:[0xCE80],0
        UInt8[DS, (ushort)0xCE80] = (byte)0x00;
        // 100D:1697 call near 0xC49A
        NearCall(cs1, 0x169A, unknown_100D_C49A_1C56A);
    label_100D_169A_1176A_41697:
        CheckExternalEvents(cs1, 0x169A);
        // 100D:169A mov AX,0x0012
        AX = (ushort)0x0012;
        // 100D:169D call far dword ptr DS:[0x3939]
        ushort targetSegment_41698 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3939 + (ushort)0x0002)]));
        ushort targetOffset_41698 = unchecked((ushort)(UInt16[DS, (ushort)0x3939]));
        if (targetSegment_41698 == cs2 && targetOffset_41698 == 0x0163)
        {
            FarCall(cs1, 0x16A1, cs2, unknown_3358_0163_336E3);
            goto label_100D_16A1_11771_41701;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41698:X4}:{targetOffset_41698:X4} at 100D:169D");
    label_100D_16A1_11771_41701:
        CheckExternalEvents(cs1, 0x16A1);
        // 100D:16A1 call near 0xAD50
        NearCall(cs1, 0x16A4, unknown_100D_AD50_1AE20);
    label_100D_16A4_11774_41704:
        CheckExternalEvents(cs1, 0x16A4);
        // 100D:16A4 mov word ptr DS:[0x11EB],0x0120
        UInt16[DS, (ushort)0x11EB] = (ushort)0x0120;
        // 100D:16AA mov SI,0x165A
        SI = (ushort)0x165A;
        // 100D:16AD call near 0x0945
        NearCall(cs1, 0x16B0, unknown_100D_0945_10A15);
    label_100D_16B0_11780_41711:
        CheckExternalEvents(cs1, 0x16B0);
        // 100D:16B0 mov byte ptr DS:[0xDBE7],0xFF
        UInt8[DS, (ushort)0xDBE7] = (byte)0xFF;
        // 100D:16B5 call near 0x093F
        NearCall(cs1, 0x16B8, unknown_100D_093F_10A0F);
    label_100D_16B8_11788_41716:
        CheckExternalEvents(cs1, 0x16B8);
        // 100D:16B8 mov BX,AX
        BX = AX;
        // 100D:16BA inc BX
        BX = Alu16.Inc(BX);
        // 100D:16BB je short 0x16F1
        if (ZeroFlag)
        {
            goto label_100D_16F1_117C1_41720;
        }
    label_100D_16BD_1178D_41722:
        CheckExternalEvents(cs1, 0x16BD);
        // 100D:16BD push AX
        Stack.Push16(AX);
        // 100D:16BE call near 0x0911
        NearCall(cs1, 0x16C1, unknown_100D_0911_109E1);
    label_100D_16C1_11791_41732:
        CheckExternalEvents(cs1, 0x16C1);
        // 100D:16C1 call far dword ptr DS:[0x3959]
        ushort targetSegment_41732 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_41732 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_41732 == cs2 && targetOffset_41732 == 0x017B)
        {
            FarCall(cs1, 0x16C5, cs2, unknown_3358_017B_336FB);
            goto label_100D_16C5_11795_41734;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41732:X4}:{targetOffset_41732:X4} at 100D:16C1");
    label_100D_16C5_11795_41734:
        CheckExternalEvents(cs1, 0x16C5);
        // 100D:16C5 call near 0xC0AD
        NearCall(cs1, 0x16C8, unknown_100D_C0AD_1C17D);
    label_100D_16C8_11798_41737:
        CheckExternalEvents(cs1, 0x16C8);
        // 100D:16C8 pop BP
        BP = Stack.Pop16();
        // 100D:16C9 call near 0xC097
        NearCall(cs1, 0x16CC, unknown_100D_C097_1C167);
    label_100D_16CC_1179C_41756:
        CheckExternalEvents(cs1, 0x16CC);
        // 100D:16CC inc word ptr DS:[0x11EB]
        UInt16[DS, (ushort)0x11EB] = Alu16.Inc(UInt16[DS, (ushort)0x11EB]);
        // 100D:16D0 call near 0xC07C
        NearCall(cs1, 0x16D3, unknown_100D_C07C_1C14C);
    label_100D_16D3_117A3_41761:
        CheckExternalEvents(cs1, 0x16D3);
        // 100D:16D3 call near 0x15A8
        NearCall(cs1, 0x16D6, unknown_100D_15A8_11678);
    label_100D_16D6_117A6_41826:
        CheckExternalEvents(cs1, 0x16D6);
        // 100D:16D6 mov AL,0x3A
        AL = (byte)0x3A;
        // 100D:16D8 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:16DB call near 0xC108
        NearCall(cs1, 0x16DE, unknown_100D_C108_1C1D8);
    label_100D_16DE_117AE_41833:
        CheckExternalEvents(cs1, 0x16DE);
        // 100D:16DE call near 0xC0F4
        NearCall(cs1, 0x16E1, unknown_100D_C0F4_1C1C4);
    label_100D_16E1_117B1_41836:
        CheckExternalEvents(cs1, 0x16E1);
        // 100D:16E1 mov AX,0x0258
        AX = (ushort)0x0258;
        // 100D:16E4 call near 0xDDB0
        NearCall(cs1, 0x16E7, unknown_100D_DDB0_1DE80);
    label_100D_16E7_117B7_41841:
        CheckExternalEvents(cs1, 0x16E7);
        // 100D:16E7 call near 0xCC85
        NearCall(cs1, 0x16EA, unknown_100D_CC85_1CD55);
    label_100D_16EA_117BA_41844:
        CheckExternalEvents(cs1, 0x16EA);
        // 100D:16EA je short 0x16E1
        if (ZeroFlag)
        {
            goto label_100D_16E1_117B1_41836;
        }
    label_100D_16EC_117BC_41847:
        CheckExternalEvents(cs1, 0x16EC);
        // 100D:16EC call near 0x9985
        NearCall(cs1, 0x16EF, unknown_100D_9985_19A55);
    label_100D_16EF_117BF_41851:
        CheckExternalEvents(cs1, 0x16EF);
        // 100D:16EF jmp short 0x16B0
        goto label_100D_16B0_11780_41711;
    label_100D_16F1_117C1_41720:
        CheckExternalEvents(cs1, 0x16F1);
        // 100D:16F1 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:16F4 call near 0xDDB0
        NearCall(cs1, 0x16F7, unknown_100D_DDB0_1DE80);
    label_100D_16F7_117C7_41986:
        CheckExternalEvents(cs1, 0x16F7);
        // 100D:16F7 jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_100D_16F1_117C1_41720;
        }
    label_100D_16F9_117C9_41989:
        CheckExternalEvents(cs1, 0x16F9);
        // 100D:16F9 jmp near 0x003A
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_1707_117D7_28375:
        CheckExternalEvents(cs1, 0x1707);
        // 100D:1707 cmp word ptr DS:[0x2220],0x1FAE
        Alu16.Sub(UInt16[DS, (ushort)0x2220], (ushort)0x1FAE);
        // 100D:170D jne short 0x171A
        if (!ZeroFlag)
        {
            goto label_100D_171A_117EA_28383;
        }
    label_100D_170F_117DF_28378:
        CheckExternalEvents(cs1, 0x170F);
        // 100D:170F mov DI,0x1B56
        DI = (ushort)0x1B56;
        // 100D:1712 call near 0xD6FE
        NearCall(cs1, 0x1715, unknown_100D_D6FE_1D7CE);
    label_100D_1715_117E5_28381:
        CheckExternalEvents(cs1, 0x1715);
        // 100D:1715 jae short 0x171A
        if (!CarryFlag)
        {
            goto label_100D_171A_117EA_28383;
        }
    label_100D_1717_117E7_41153:
        CheckExternalEvents(cs1, 0x1717);
        // 100D:1717 jmp near 0x9ED5
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9ED5))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_171A_117EA_28383:
        CheckExternalEvents(cs1, 0x171A);
        // 100D:171A mov byte ptr DS:[0xCE9D],0
        UInt8[DS, (ushort)0xCE9D] = (byte)0x00;
        // 100D:171F mov SI,word ptr DS:[0x477A]
        SI = UInt16[DS, (ushort)0x477A];
        // 100D:1723 lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:1725 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:1727 je short 0x1736
        if (ZeroFlag)
        {
            goto label_100D_1736_11806_29027;
        }
    label_100D_1729_117F9_28389:
        CheckExternalEvents(cs1, 0x1729);
        // 100D:1729 mov word ptr DS:[0x477A],SI
        UInt16[DS, (ushort)0x477A] = SI;
        // 100D:172D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:172F mov BX,AX
        BX = AX;
        // 100D:1731 jmp near word ptr CS:[BX+0x1475]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)5237)]))
        {
            case 0x13A0:
                goto label_100D_13A0_11470_28394;
            case 0x13AA:
                goto label_100D_13AA_1147A_29003;
            case 0x13C8:
                if (JumpDispatcher.Jump(unknown_100D_13C8_11498, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x13DB:
                if (JumpDispatcher.Jump(unknown_100D_13DB_114AB, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x13E4:
                goto label_100D_13E4_114B4_30393;
            case 0x140B:
                goto label_100D_140B_114DB_30416;
            case 0x1422:
                goto label_100D_1422_114F2_34621;
            case 0x1442:
                goto label_100D_1442_11512_34655;
            case 0x1474:
                goto label_100D_1474_11544_30391;
            case 0x148D:
                goto label_100D_148D_1155D_41312;
            case 0x14C9:
                goto label_100D_14C9_11599_41335;
            case 0x167C:
                goto label_100D_167C_1174C_41675;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)5237)])):X4} at 100D:1731");
        }
    label_100D_1736_11806_29027:
        CheckExternalEvents(cs1, 0x1736);
        // 100D:1736 mov SI,0x176B
        SI = (ushort)0x176B;
        // 100D:1739 call near 0xDA5F
        NearCall(cs1, 0x173C, unknown_100D_DA5F_1DB2F);
    label_100D_173C_1180C_29030:
        CheckExternalEvents(cs1, 0x173C);
        // 100D:173C mov AX,word ptr DS:[0x4776]
        AX = UInt16[DS, (ushort)0x4776];
        // 100D:173F mov byte ptr DS:[4],AL
        UInt8[DS, (ushort)0x0004] = AL;
        // 100D:1742 mov byte ptr DS:[0x46E0],AH
        UInt8[DS, (ushort)0x46E0] = AH;
        // 100D:1746 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:1748 mov byte ptr DS:[0x4774],AL
        UInt8[DS, (ushort)0x4774] = AL;
        // 100D:174B cmp byte ptr DS:[0x002A],0x48
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x48);
        // 100D:1750 je short 0x1755
        if (ZeroFlag)
        {
            goto label_100D_1755_11825_29040;
        }
    label_100D_1752_11822_29038:
        CheckExternalEvents(cs1, 0x1752);
        // 100D:1752 call near 0xADBE
        NearCall(cs1, 0x1755, unknown_100D_ADBE_1AE8E);
    label_100D_1755_11825_29040:
        CheckExternalEvents(cs1, 0x1755);
        // 100D:1755 call near 0xB2BE
        NearCall(cs1, 0x1758, unknown_100D_B2BE_1B38E);
    label_100D_1758_11828_29042:
        CheckExternalEvents(cs1, 0x1758);
        // 100D:1758 cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:175D js short 0x1762
        if (SignFlag)
        {
            goto label_100D_1762_11832_29045;
        }
    label_100D_175F_1182F_30428:
        CheckExternalEvents(cs1, 0x175F);
        // 100D:175F jmp near 0x0FA7
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x0FA7))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_1762_11832_29045:
        CheckExternalEvents(cs1, 0x1762);
        // 100D:1762 call near 0xAD5E
        NearCall(cs1, 0x1765, unknown_100D_AD5E_1AE2E);
    label_100D_1765_11835_29047:
        CheckExternalEvents(cs1, 0x1765);
        // 100D:1765 call near 0x68EB
        NearCall(cs1, 0x1768, unknown_100D_68EB_169BB);
    label_100D_1768_11838_29049:
        CheckExternalEvents(cs1, 0x1768);
        // 100D:1768 jmp near 0x780A
        if (JumpDispatcher.Jump(unknown_100D_780A_178DA, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_176B_1183B(int loadOffset)
    {
    label_100D_176B_1183B_28364:
        CheckExternalEvents(cs1, 0x176B);
        // 100D:176B xor byte ptr DS:[0x4775],0xFF
        UInt8[DS, (ushort)0x4775] = Alu8.Xor(UInt8[DS, (ushort)0x4775], (byte)0xFF);
        // 100D:1770 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1771_11841(int loadOffset)
    {
    label_100D_1771_11841_28338:
        CheckExternalEvents(cs1, 0x1771);
        // 100D:1771 mov word ptr DS:[0x477A],AX
        UInt16[DS, (ushort)0x477A] = AX;
        // 100D:1774 mov word ptr DS:[0x4778],0
        UInt16[DS, (ushort)0x4778] = (ushort)0x0000;
        // 100D:177A inc byte ptr DS:[0x4774]
        UInt8[DS, (ushort)0x4774] = Alu8.Inc(UInt8[DS, (ushort)0x4774]);
        // 100D:177E call near 0xB2B9
        NearCall(cs1, 0x1781, unknown_100D_B2B9_1B389);
    label_100D_1781_11851_28343:
        CheckExternalEvents(cs1, 0x1781);
        // 100D:1781 call near 0xAD5E
        NearCall(cs1, 0x1784, unknown_100D_AD5E_1AE2E);
    label_100D_1784_11854_28348:
        CheckExternalEvents(cs1, 0x1784);
        // 100D:1784 mov AL,byte ptr DS:[4]
        AL = UInt8[DS, (ushort)0x0004];
        // 100D:1787 mov AH,byte ptr DS:[0x46E0]
        AH = UInt8[DS, (ushort)0x46E0];
        // 100D:178B mov word ptr DS:[0x4776],AX
        UInt16[DS, (ushort)0x4776] = AX;
        return unknown_100D_178E_1185E(0x0000);
    }

    public virtual Action unknown_100D_1797_11867(int loadOffset)
    {
    label_100D_1797_11867_13039:
        CheckExternalEvents(cs1, 0x1797);
        // 100D:1797 push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:179B call near 0xC137
        NearCall(cs1, 0x179E, unknown_100D_C137_1C207);
    label_100D_179E_1186E_13042:
        CheckExternalEvents(cs1, 0x179E);
        // 100D:179E mov DX,0x007E
        DX = (ushort)0x007E;
        // 100D:17A1 mov BX,0x0094
        BX = (ushort)0x0094;
        // 100D:17A4 mov AX,0x000F
        AX = (ushort)0x000F;
        // 100D:17A7 call near 0xC22F
        NearCall(cs1, 0x17AA, unknown_100D_C22F_1C2FF);
    label_100D_17AA_1187A_13047:
        CheckExternalEvents(cs1, 0x17AA);
        // 100D:17AA mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:17AD add AL,byte ptr DS:[0x00E8]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x00E8]);
        // 100D:17B1 mov DX,0x0096
        DX = (ushort)0x0096;
        // 100D:17B4 mov BX,0x0089
        BX = (ushort)0x0089;
        // 100D:17B7 call near 0xC22F
        NearCall(cs1, 0x17BA, unknown_100D_C22F_1C2FF);
    label_100D_17BA_1188A_13053:
        CheckExternalEvents(cs1, 0x17BA);
        // 100D:17BA pop AX
        AX = Stack.Pop16();
        // 100D:17BB jmp near 0xC13E
        return unknown_100D_C13E_1C20E(0x0000);
    }

    public virtual Action unknown_100D_17BE_1188E(int loadOffset)
    {
    label_100D_17BE_1188E_14537:
        CheckExternalEvents(cs1, 0x17BE);
        // 100D:17BE call near 0xC07C
        NearCall(cs1, 0x17C1, unknown_100D_C07C_1C14C);
    label_100D_17C1_11891_14539:
        CheckExternalEvents(cs1, 0x17C1);
        // 100D:17C1 mov SI,0x1E6E
        SI = (ushort)0x1E6E;
        // 100D:17C4 push SI
        Stack.Push16(SI);
        // 100D:17C5 cmp byte ptr DS:[0xCE66],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE66], (byte)0x00);
        // 100D:17CA jne short 0x17D1
        if (!ZeroFlag)
        {
            goto label_100D_17D1_118A1_31410;
        }
    label_100D_17CC_1189C_14544:
        CheckExternalEvents(cs1, 0x17CC);
        // 100D:17CC call near 0xC446
        NearCall(cs1, 0x17CF, unknown_100D_C446_1C516);
    label_100D_17CF_1189F_14546:
        CheckExternalEvents(cs1, 0x17CF);
        // 100D:17CF jmp short 0x17DF
        goto label_100D_17DF_118AF_14548;
    label_100D_17D1_118A1_31410:
        CheckExternalEvents(cs1, 0x17D1);
        // 100D:17D1 mov BP,0x1E76
        BP = (ushort)0x1E76;
        // 100D:17D4 mov SI,0xCD9E
        SI = (ushort)0xCD9E;
        // 100D:17D7 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:17DB call far dword ptr DS:[0x391D]
        ushort targetSegment_31414 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x391D + (ushort)0x0002)]));
        ushort targetOffset_31414 = unchecked((ushort)(UInt16[DS, (ushort)0x391D]));
        if (targetSegment_31414 == cs2 && targetOffset_31414 == 0x014E)
        {
            FarCall(cs1, 0x17DF, cs2, unknown_3358_014E_336CE);
            goto label_100D_17DF_118AF_14548;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_31414:X4}:{targetOffset_31414:X4} at 100D:17DB");
    label_100D_17DF_118AF_14548:
        CheckExternalEvents(cs1, 0x17DF);
        // 100D:17DF call near 0x1797
        NearCall(cs1, 0x17E2, unknown_100D_1797_11867);
    label_100D_17E2_118B2_14550:
        CheckExternalEvents(cs1, 0x17E2);
        // 100D:17E2 pop SI
        SI = Stack.Pop16();
        // 100D:17E3 jmp near 0xC4F0
        return unknown_100D_C4F0_1C5C0(0x0000);
    }

    public virtual Action unknown_100D_17E6_118B6(int loadOffset)
    {
    entrydispatcher:
    label_100D_17E6_118B6_14528:
        CheckExternalEvents(cs1, 0x17E6);
        // 100D:17E6 cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:17EB jne short 0x181D
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_17ED_118BD_14531:
        CheckExternalEvents(cs1, 0x17ED);
        // 100D:17ED cmp byte ptr DS:[0x00E8],0x0A
        Alu8.Sub(UInt8[DS, (ushort)0x00E8], (byte)0x0A);
        // 100D:17F2 je short 0x181D
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_17F4_118C4_14534:
        CheckExternalEvents(cs1, 0x17F4);
        // 100D:17F4 inc byte ptr DS:[0x00E8]
        UInt8[DS, (ushort)0x00E8] = Alu8.Inc(UInt8[DS, (ushort)0x00E8]);
        // 100D:17F8 call near 0x17BE
        NearCall(cs1, 0x17FB, unknown_100D_17BE_1188E);
    label_100D_17FB_118CB_14573:
        CheckExternalEvents(cs1, 0x17FB);
        // 100D:17FB mov AX,8
        AX = (ushort)0x0008;
        // 100D:17FE call near 0xE387
        NearCall(cs1, 0x1801, unknown_100D_E387_1E457);
    label_100D_1801_118D1_14576:
        CheckExternalEvents(cs1, 0x1801);
        // 100D:1801 jmp short 0x17E6
        goto label_100D_17E6_118B6_14528;
    }

    public virtual Action unknown_100D_1803_118D3(int loadOffset)
    {
    entrydispatcher:
    label_100D_1803_118D3_15681:
        CheckExternalEvents(cs1, 0x1803);
        // 100D:1803 cmp byte ptr DS:[0x28E7],0
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x00);
        // 100D:1808 jne short 0x181D
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_180A_118DA_31404:
        CheckExternalEvents(cs1, 0x180A);
        // 100D:180A cmp byte ptr DS:[0x00E8],0
        Alu8.Sub(UInt8[DS, (ushort)0x00E8], (byte)0x00);
        // 100D:180F je short 0x181D
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_1811_118E1_31407:
        CheckExternalEvents(cs1, 0x1811);
        // 100D:1811 mov byte ptr DS:[0xCE66],1
        UInt8[DS, (ushort)0xCE66] = (byte)0x01;
        // 100D:1816 call near 0x181E
        NearCall(cs1, 0x1819, unknown_100D_181E_118EE);
    label_100D_1819_118E9_31415:
        CheckExternalEvents(cs1, 0x1819);
        // 100D:1819 dec byte ptr DS:[0xCE66]
        UInt8[DS, (ushort)0xCE66] = Alu8.Dec(UInt8[DS, (ushort)0xCE66]);
        if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_181E_118EE(int loadOffset)
    {
    entrydispatcher:
    label_100D_181E_118EE_16347:
        CheckExternalEvents(cs1, 0x181E);
        // 100D:181E cmp byte ptr DS:[0x00E8],0
        Alu8.Sub(UInt8[DS, (ushort)0x00E8], (byte)0x00);
        // 100D:1823 je short 0x181D
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_181D_118ED, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_1825_118F5_16350:
        CheckExternalEvents(cs1, 0x1825);
        // 100D:1825 dec byte ptr DS:[0x00E8]
        UInt8[DS, (ushort)0x00E8] = Alu8.Dec(UInt8[DS, (ushort)0x00E8]);
        // 100D:1829 call near 0x17BE
        NearCall(cs1, 0x182C, unknown_100D_17BE_1188E);
    label_100D_182C_118FC_16353:
        CheckExternalEvents(cs1, 0x182C);
        // 100D:182C mov AX,8
        AX = (ushort)0x0008;
        // 100D:182F call near 0xE387
        NearCall(cs1, 0x1832, unknown_100D_E387_1E457);
    label_100D_1832_11902_16356:
        CheckExternalEvents(cs1, 0x1832);
        // 100D:1832 jmp short 0x181E
        goto label_100D_181E_118EE_16347;
    }

    public virtual Action unknown_100D_1834_11904(int loadOffset)
    {
    label_100D_1834_11904_14446:
        CheckExternalEvents(cs1, 0x1834);
        // 100D:1834 mov SI,0xCD9E
        SI = (ushort)0xCD9E;
        // 100D:1837 mov BP,0x1E76
        BP = (ushort)0x1E76;
        // 100D:183A mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:183E call far dword ptr DS:[0x3919]
        ushort targetSegment_14450 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3919 + (ushort)0x0002)]));
        ushort targetOffset_14450 = unchecked((ushort)(UInt16[DS, (ushort)0x3919]));
        if (targetSegment_14450 == cs2 && targetOffset_14450 == 0x014B)
        {
            FarCall(cs1, 0x1842, cs2, unknown_3358_014B_336CB);
            goto label_100D_1842_11912_14483;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_14450:X4}:{targetOffset_14450:X4} at 100D:183E");
    label_100D_1842_11912_14483:
        CheckExternalEvents(cs1, 0x1842);
        // 100D:1842 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1843_11913(int loadOffset)
    {
    label_100D_1843_11913_13205:
        CheckExternalEvents(cs1, 0x1843);
        // 100D:1843 cmp byte ptr DS:[0x00E8],0
        Alu8.Sub(UInt8[DS, (ushort)0x00E8], (byte)0x00);
        // 100D:1848 je short 0x181D
        if (ZeroFlag)
        {
            return unknown_100D_181D_118ED(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1848");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_1860_11930(int loadOffset)
    {
    label_100D_1860_11930_13200:
        CheckExternalEvents(cs1, 0x1860);
        // 100D:1860 cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:1865 je short 0x1868
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1865");
        }
    label_100D_1868_11938_13203:
        CheckExternalEvents(cs1, 0x1868);
        // 100D:1868 call near 0x1843
        NearCall(cs1, 0x186B, unknown_100D_1843_11913);
        return unknown_100D_186B_1193B(0x0000);
    }

    public virtual Action unknown_100D_186B_1193B(int loadOffset)
    {
    entrydispatcher:
    label_100D_186B_1193B_13210:
        CheckExternalEvents(cs1, 0x186B);
        // 100D:186B call near 0xDAA3
        NearCall(cs1, 0x186E, unknown_100D_DAA3_1DB73);
    label_100D_186E_1193E_13215:
        CheckExternalEvents(cs1, 0x186E);
        // 100D:186E neg byte ptr DS:[0x00FB]
        UInt8[DS, (ushort)0x00FB] = Alu8.Sub((byte)0x00, UInt8[DS, (ushort)0x00FB]);
        CarryFlag = UInt8[DS, (ushort)0x00FB] != (byte)0x00;
        // 100D:1872 jns short 0x1877
        if (!SignFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x1877))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_1874_11944_17408:
        CheckExternalEvents(cs1, 0x1874);
        // 100D:1874 jmp near 0x5A1A
        if (JumpDispatcher.Jump(unknown_100D_5A1A_15AEA, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_189A_1196A(int loadOffset)
    {
    entrydispatcher:
    label_100D_189A_1196A_13514:
        CheckExternalEvents(cs1, 0x189A);
        // 100D:189A mov BP,0x2DB1
        BP = (ushort)0x2DB1;
        // 100D:189D cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:18A2 je short 0x18A6
        if (ZeroFlag)
        {
            goto label_100D_18A6_11976_13517;
        }
    label_100D_18A4_11974_40518:
        CheckExternalEvents(cs1, 0x18A4);
        // 100D:18A4 jmp near BP
        switch ((ushort)(BP))
        {
            case 0x2DB1:
                if (JumpDispatcher.Jump(unknown_100D_2DB1_12E81, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(BP)):X4} at 100D:18A4");
        }
    label_100D_18A6_11976_13517:
        CheckExternalEvents(cs1, 0x18A6);
        // 100D:18A6 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:18A8 call near 0xC108
        NearCall(cs1, 0x18AB, unknown_100D_C108_1C1D8);
    label_100D_18AB_1197B_14580:
        CheckExternalEvents(cs1, 0x18AB);
        // 100D:18AB call near 0xC07C
        NearCall(cs1, 0x18AE, unknown_100D_C07C_1C14C);
    label_100D_18AE_1197E_14582:
        CheckExternalEvents(cs1, 0x18AE);
        // 100D:18AE call near 0xAE04
        NearCall(cs1, 0x18B1, unknown_100D_AE04_1AED4);
    label_100D_18B1_11981_14607:
        CheckExternalEvents(cs1, 0x18B1);
        // 100D:18B1 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:18B4 mov word ptr DS:[0xDC5A],AX
        UInt16[DS, (ushort)0xDC5A] = AX;
        // 100D:18B7 jmp near 0x17E6
        if (JumpDispatcher.Jump(unknown_100D_17E6_118B6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_18BA_1198A(int loadOffset)
    {
    label_100D_18BA_1198A_16324:
        CheckExternalEvents(cs1, 0x18BA);
        // 100D:18BA mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:18C0 mov word ptr DS:[0x1C14],0
        UInt16[DS, (ushort)0x1C14] = (ushort)0x0000;
        // 100D:18C6 mov word ptr DS:[0x1C22],0
        UInt16[DS, (ushort)0x1C22] = (ushort)0x0000;
        // 100D:18CC call near 0x39E6
        NearCall(cs1, 0x18CF, unknown_100D_39E6_13AB6);
    label_100D_18CF_1199F_16329:
        CheckExternalEvents(cs1, 0x18CF);
        // 100D:18CF call near 0xAC30
        NearCall(cs1, 0x18D2, unknown_100D_AC30_1AD00);
    label_100D_18D2_119A2_16331:
        CheckExternalEvents(cs1, 0x18D2);
        // 100D:18D2 call near 0x4D00
        NearCall(cs1, 0x18D5, unknown_100D_4D00_14DD0);
    label_100D_18D5_119A5_16333:
        CheckExternalEvents(cs1, 0x18D5);
        // 100D:18D5 call near 0xD2BD
        NearCall(cs1, 0x18D8, unknown_100D_D2BD_1D38D);
    label_100D_18D8_119A8_16335:
        CheckExternalEvents(cs1, 0x18D8);
        // 100D:18D8 call near 0x4ACA
        NearCall(cs1, 0x18DB, unknown_100D_4ACA_14B9A);
    label_100D_18DB_119AB_16337:
        CheckExternalEvents(cs1, 0x18DB);
        // 100D:18DB call near 0x98E6
        NearCall(cs1, 0x18DE, unknown_100D_98E6_199B6);
    label_100D_18DE_119AE_16339:
        CheckExternalEvents(cs1, 0x18DE);
        // 100D:18DE mov byte ptr DS:[0x46DF],0
        UInt8[DS, (ushort)0x46DF] = (byte)0x00;
        // 100D:18E3 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:18E8 je short 0x18ED
        if (ZeroFlag)
        {
            goto label_100D_18ED_119BD_16343;
        }
    label_100D_18EA_119BA_38139:
        CheckExternalEvents(cs1, 0x18EA);
        // 100D:18EA call near 0x0B21
        NearCall(cs1, 0x18ED, unknown_100D_0B21_10BF1);
    label_100D_18ED_119BD_16343:
        CheckExternalEvents(cs1, 0x18ED);
        // 100D:18ED ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_18EE_119BE(int loadOffset)
    {
    entrydispatcher:
    label_100D_18EE_119BE_39038:
        CheckExternalEvents(cs1, 0x18EE);
        // 100D:18EE call near 0xD41B
        NearCall(cs1, 0x18F1, unknown_100D_D41B_1D4EB);
    label_100D_18F1_119C1_39041:
        CheckExternalEvents(cs1, 0x18F1);
        // 100D:18F1 cmp BP,0x2012
        Alu16.Sub(BP, (ushort)0x2012);
        // 100D:18F5 jne short 0x18FA
        if (!ZeroFlag)
        {
            goto label_100D_18FA_119CA_39044;
        }
    label_100D_18F7_119C7_39046:
        CheckExternalEvents(cs1, 0x18F7);
        // 100D:18F7 jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_18FA_119CA_39044:
        CheckExternalEvents(cs1, 0x18FA);
        // 100D:18FA mov AX,word ptr DS:[4]
        AX = UInt16[DS, (ushort)0x0004];
        // 100D:18FD cmp AH,0x20
        Alu8.Sub(AH, (byte)0x20);
        // 100D:1900 jne short 0x1947
        if (!ZeroFlag)
        {
            goto label_100D_1947_11A17_39051;
        }
    label_100D_1902_119D2_39053:
        CheckExternalEvents(cs1, 0x1902);
        // 100D:1902 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:1904 je short 0x1947
        if (ZeroFlag)
        {
            goto label_100D_1947_11A17_39051;
        }
    label_100D_1906_119D6_39057:
        CheckExternalEvents(cs1, 0x1906);
        // 100D:1906 mov AX,0x1ABA
        AX = (ushort)0x1ABA;
        // 100D:1909 call near 0xD95E
        NearCall(cs1, 0x190C, unknown_100D_D95E_1DA2E);
    label_100D_190C_119DC_39069:
        CheckExternalEvents(cs1, 0x190C);
        // 100D:190C call near 0xD2BD
        NearCall(cs1, 0x190F, unknown_100D_D2BD_1D38D);
    label_100D_190F_119DF_39072:
        CheckExternalEvents(cs1, 0x190F);
        // 100D:190F call near 0xC07C
        NearCall(cs1, 0x1912, unknown_100D_C07C_1C14C);
    label_100D_1912_119E2_39075:
        CheckExternalEvents(cs1, 0x1912);
        // 100D:1912 mov SI,0x143C
        SI = (ushort)0x143C;
        // 100D:1915 mov AL,0xF1
        AL = (byte)0xF1;
        // 100D:1917 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:191B call far dword ptr DS:[0x38DD]
        ushort targetSegment_39079 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_39079 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_39079 == cs2 && targetOffset_39079 == 0x011E)
        {
            FarCall(cs1, 0x191F, cs2, unknown_3358_011E_3369E);
            goto label_100D_191F_119EF_39083;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_39079:X4}:{targetOffset_39079:X4} at 100D:191B");
    label_100D_191F_119EF_39083:
        CheckExternalEvents(cs1, 0x191F);
        // 100D:191F mov SI,0x1444
        SI = (ushort)0x1444;
        // 100D:1922 mov AL,0xF7
        AL = (byte)0xF7;
        // 100D:1924 call near 0x5B6E
        NearCall(cs1, 0x1927, unknown_100D_5B6E_15C3E);
    label_100D_1927_119F7_39091:
        CheckExternalEvents(cs1, 0x1927);
        // 100D:1927 mov AX,0x0021
        AX = (ushort)0x0021;
        // 100D:192A call near 0xC13E
        NearCall(cs1, 0x192D, unknown_100D_C13E_1C20E);
    label_100D_192D_119FD_39096:
        CheckExternalEvents(cs1, 0x192D);
        // 100D:192D mov SI,0x120B
        SI = (ushort)0x120B;
        // 100D:1930 call near 0xC21B
        NearCall(cs1, 0x1933, unknown_100D_C21B_1C2EB);
    label_100D_1933_11A03_39101:
        CheckExternalEvents(cs1, 0x1933);
        // 100D:1933 call near 0x1948
        NearCall(cs1, 0x1936, unknown_100D_1948_11A18);
    label_100D_1936_11A06_39295:
        CheckExternalEvents(cs1, 0x1936);
        // 100D:1936 mov SI,0x143C
        SI = (ushort)0x143C;
        // 100D:1939 mov AL,0x10
        AL = (byte)0x10;
        // 100D:193B call near 0xC0D5
        NearCall(cs1, 0x193E, unknown_100D_C0D5_1C1A5);
    label_100D_193E_11A0E_39393:
        CheckExternalEvents(cs1, 0x193E);
        // 100D:193E mov BP,0x2012
        BP = (ushort)0x2012;
        // 100D:1941 mov BX,0x19FC
        BX = (ushort)0x19FC;
        // 100D:1944 jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_1947_11A17_39051:
        CheckExternalEvents(cs1, 0x1947);
        VerifySpeculativeEntryOrFail(cs1, 0x1947, [(byte)0xC3]);
        // 100D:1947 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1948_11A18(int loadOffset)
    {
    label_100D_1948_11A18_39102:
        CheckExternalEvents(cs1, 0x1948);
        // 100D:1948 sub SP,0x0024
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)36)));
        // 100D:194B mov DI,SP
        DI = SP;
        // 100D:194D push SS
        Stack.Push16(SS);
        // 100D:194E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:194F mov CX,0x0024
        CX = (ushort)0x0024;
        // 100D:1952 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:1954 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:1956 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:1959 mov DI,SP
        DI = SP;
        // 100D:195B mov CX,0x0010
        CX = (ushort)0x0010;
        // 100D:195E mov DH,byte ptr DS:[7]
        DH = UInt8[DS, (ushort)0x0007];
    label_100D_1962_11A32_39115:
        CheckExternalEvents(cs1, 0x1962);
        // 100D:1962 cmp DH,byte ptr DS:[SI+3]
        Alu8.Sub(DH, UInt8[DS, (ushort)(SI + (sbyte)3)]);
        // 100D:1965 jne short 0x1980
        if (!ZeroFlag)
        {
            goto label_100D_1980_11A50_39117;
        }
    label_100D_1967_11A37_39119:
        CheckExternalEvents(cs1, 0x1967);
        // 100D:1967 mov AL,byte ptr DS:[SI+0x0E]
        AL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:196A call near 0x127C
        NearCall(cs1, 0x196D, unknown_100D_127C_1134C);
    label_100D_196D_11A3D_39188:
        CheckExternalEvents(cs1, 0x196D);
        // 100D:196D jb short 0x1980
        if (CarryFlag)
        {
            goto label_100D_1980_11A50_39117;
        }
    label_100D_196F_11A3F_39191:
        CheckExternalEvents(cs1, 0x196F);
        // 100D:196F mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:1971 dec BL
        BL = Alu8.Dec(BL);
        // 100D:1973 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:1975 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:1979 je short 0x197E
        if (ZeroFlag)
        {
            goto label_100D_197E_11A4E_39197;
        }
    label_100D_197B_11A4B_39199:
        CheckExternalEvents(cs1, 0x197B);
        // 100D:197B add BX,0x000C
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)12)));
    label_100D_197E_11A4E_39197:
        CheckExternalEvents(cs1, 0x197E);
        // 100D:197E inc byte ptr DS:[BX+DI]
        UInt8[DS, (ushort)(BX + DI)] = Alu8.Inc(UInt8[DS, (ushort)(BX + DI)]);
    label_100D_1980_11A50_39117:
        CheckExternalEvents(cs1, 0x1980);
        // 100D:1980 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:1983 loop 0x1962
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_1962_11A32_39115;
        }
    label_100D_1985_11A55_39125:
        CheckExternalEvents(cs1, 0x1985);
        // 100D:1985 mov BX,word ptr DS:[4]
        BX = UInt16[DS, (ushort)0x0004];
        // 100D:1989 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:198B cmp BL,0x0C
        Alu8.Sub(BL, (byte)0x0C);
        // 100D:198E ja short 0x1995
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_1995_11A65_39131;
        }
    label_100D_1990_11A60_39133:
        CheckExternalEvents(cs1, 0x1990);
        // 100D:1990 add BL,0x17
        BL = Alu8.Add(BL, (byte)0x17);
        // 100D:1993 inc byte ptr DS:[BX+DI]
        UInt8[DS, (ushort)(BX + DI)] = Alu8.Inc(UInt8[DS, (ushort)(BX + DI)]);
    label_100D_1995_11A65_39131:
        CheckExternalEvents(cs1, 0x1995);
        // 100D:1995 mov CX,0x000B
        CX = (ushort)0x000B;
        // 100D:1998 inc DI
        DI = Alu16.Inc(DI);
        // 100D:1999 mov SI,0x1426
        SI = (ushort)0x1426;
    label_100D_199C_11A6C_39139:
        CheckExternalEvents(cs1, 0x199C);
        // 100D:199C mov DX,word ptr DS:[0x120D]
        DX = UInt16[DS, (ushort)0x120D];
        // 100D:19A0 mov BX,word ptr DS:[0x120F]
        BX = UInt16[DS, (ushort)0x120F];
        // 100D:19A4 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:19A5 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:19A7 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:19A9 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:19AA add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:19AC push CX
        Stack.Push16(CX);
        // 100D:19AD push SI
        Stack.Push16(SI);
        // 100D:19AE push DI
        Stack.Push16(DI);
        // 100D:19AF add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:19B2 add DX,3
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:19B5 mov CL,byte ptr DS:[DI]
        CL = UInt8[DS, DI];
        // 100D:19B7 call near 0x19DF
        NearCall(cs1, 0x19BA, unknown_100D_19DF_11AAF);
    label_100D_19BA_11A8A_39236:
        CheckExternalEvents(cs1, 0x19BA);
        // 100D:19BA add BX,7
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:19BD mov CL,byte ptr DS:[DI+0x0C]
        CL = UInt8[DS, (ushort)(DI + (sbyte)12)];
        // 100D:19C0 call near 0x19DF
        NearCall(cs1, 0x19C3, unknown_100D_19DF_11AAF);
    label_100D_19C3_11A93_39243:
        CheckExternalEvents(cs1, 0x19C3);
        // 100D:19C3 sub BX,4
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:19C6 add DX,9
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)9)));
        // 100D:19C9 cmp byte ptr DS:[DI+0x18],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)24)], (byte)0x00);
        // 100D:19CD je short 0x19D5
        if (ZeroFlag)
        {
            goto label_100D_19D5_11AA5_39248;
        }
    label_100D_19CF_11A9F_39250:
        CheckExternalEvents(cs1, 0x19CF);
        // 100D:19CF mov AX,1
        AX = (ushort)0x0001;
        // 100D:19D2 call near 0xC22F
        NearCall(cs1, 0x19D5, unknown_100D_C22F_1C2FF);
    label_100D_19D5_11AA5_39248:
        CheckExternalEvents(cs1, 0x19D5);
        // 100D:19D5 pop DI
        DI = Stack.Pop16();
        // 100D:19D6 pop SI
        SI = Stack.Pop16();
        // 100D:19D7 pop CX
        CX = Stack.Pop16();
        // 100D:19D8 inc DI
        DI = Alu16.Inc(DI);
        // 100D:19D9 loop 0x199C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_199C_11A6C_39139;
        }
    label_100D_19DB_11AAB_39260:
        CheckExternalEvents(cs1, 0x19DB);
        // 100D:19DB add SP,0x0024
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)36)));
        // 100D:19DE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_19DF_11AAF(int loadOffset)
    {
    label_100D_19DF_11AAF_39153:
        CheckExternalEvents(cs1, 0x19DF);
        // 100D:19DF xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:19E1 jcxz short 0x19FB
        if (CX == (ushort)0x0000)
        {
            goto label_100D_19FB_11ACB_39156;
        }
    label_100D_19E3_11AB3_39158:
        CheckExternalEvents(cs1, 0x19E3);
        // 100D:19E3 push DX
        Stack.Push16(DX);
        // 100D:19E4 push DI
        Stack.Push16(DI);
        // 100D:19E5 cmp CL,5
        Alu8.Sub(CL, (byte)0x05);
        // 100D:19E8 jbe short 0x19EC
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_19EC_11ABC_39163;
        }
    label_100D_19EA_11ABA_39165:
        CheckExternalEvents(cs1, 0x19EA);
        VerifySpeculativeEntryOrFail(cs1, 0x19EA, [(byte)0xB1, (byte)0x05]);
        // 100D:19EA mov CL,5
        CL = (byte)0x05;
    label_100D_19EC_11ABC_39163:
        CheckExternalEvents(cs1, 0x19EC);
        // 100D:19EC push CX
        Stack.Push16(CX);
        // 100D:19ED mov AX,2
        AX = (ushort)0x0002;
        // 100D:19F0 call near 0xC2FD
        NearCall(cs1, 0x19F3, unknown_100D_C2FD_1C3CD);
    label_100D_19F3_11AC3_39278:
        CheckExternalEvents(cs1, 0x19F3);
        // 100D:19F3 pop CX
        CX = Stack.Pop16();
        // 100D:19F4 add DX,4
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:19F7 loop 0x19EC
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_19EC_11ABC_39163;
        }
    label_100D_19F9_11AC9_39283:
        CheckExternalEvents(cs1, 0x19F9);
        // 100D:19F9 pop DI
        DI = Stack.Pop16();
        // 100D:19FA pop DX
        DX = Stack.Pop16();
    label_100D_19FB_11ACB_39156:
        CheckExternalEvents(cs1, 0x19FB);
        // 100D:19FB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_19FC_11ACC(int loadOffset)
    {
    label_100D_19FC_11ACC_39401:
        CheckExternalEvents(cs1, 0x19FC);
        // 100D:19FC call near 0xDAA3
        NearCall(cs1, 0x19FF, unknown_100D_DAA3_1DB73);
    label_100D_19FF_11ACF_39404:
        CheckExternalEvents(cs1, 0x19FF);
        // 100D:19FF mov SI,0x143C
        SI = (ushort)0x143C;
        // 100D:1A02 push SI
        Stack.Push16(SI);
        // 100D:1A03 call near 0xC446
        NearCall(cs1, 0x1A06, unknown_100D_C446_1C516);
    label_100D_1A06_11AD6_39411:
        CheckExternalEvents(cs1, 0x1A06);
        // 100D:1A06 pop SI
        SI = Stack.Pop16();
        // 100D:1A07 mov AL,0x12
        AL = (byte)0x12;
        // 100D:1A09 call near 0xC0D5
        NearCall(cs1, 0x1A0C, unknown_100D_C0D5_1C1A5);
    label_100D_1A0C_11ADC_39519:
        CheckExternalEvents(cs1, 0x1A0C);
        // 100D:1A0C jmp near 0xD95B
        return unknown_100D_D95B_1DA2B(0x0000);
    }

    public virtual Action unknown_100D_1A0F_11ADF(int loadOffset)
    {
    label_100D_1A0F_11ADF_14970:
        CheckExternalEvents(cs1, 0x1A0F);
        // 100D:1A0F cmp word ptr DS:[0x1AFE],0
        Alu16.Sub(UInt16[DS, (ushort)0x1AFE], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:1A14 jne short 0x1A33
        if (!ZeroFlag)
        {
            return unknown_100D_1A33_11B03(0x0000);
        }
    label_100D_1A16_11AE6_14973:
        CheckExternalEvents(cs1, 0x1A16);
        // 100D:1A16 call near 0xDBB2
        NearCall(cs1, 0x1A19, unknown_100D_DBB2_1DC82);
    label_100D_1A19_11AE9_15014:
        CheckExternalEvents(cs1, 0x1A19);
        // 100D:1A19 push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:1A1D call near 0xC137
        NearCall(cs1, 0x1A20, unknown_100D_C137_1C207);
    label_100D_1A20_11AF0_15017:
        CheckExternalEvents(cs1, 0x1A20);
        // 100D:1A20 mov SI,0x1AF4
        SI = (ushort)0x1AF4;
        // 100D:1A23 call near 0xD200
        NearCall(cs1, 0x1A26, unknown_100D_D200_1D2D0);
    label_100D_1A26_11AF6_15020:
        CheckExternalEvents(cs1, 0x1A26);
        // 100D:1A26 call near 0x1A34
        NearCall(cs1, 0x1A29, unknown_100D_1A34_11B04);
    label_100D_1A29_11AF9_15022:
        CheckExternalEvents(cs1, 0x1A29);
        // 100D:1A29 mov SI,0x1F06
        SI = (ushort)0x1F06;
        // 100D:1A2C call near 0xC4AA
        NearCall(cs1, 0x1A2F, unknown_100D_C4AA_1C57A);
    label_100D_1A2F_11AFF_15043:
        CheckExternalEvents(cs1, 0x1A2F);
        // 100D:1A2F pop AX
        AX = Stack.Pop16();
        // 100D:1A30 call near 0xC13E
        NearCall(cs1, 0x1A33, unknown_100D_C13E_1C20E);
        return unknown_100D_1A33_11B03(0x0000);
    }

    public virtual Action unknown_100D_1A34_11B04(int loadOffset)
    {
    label_100D_1A34_11B04_13313:
        CheckExternalEvents(cs1, 0x1A34);
        // 100D:1A34 cmp word ptr DS:[0x1AFE],0
        Alu16.Sub(UInt16[DS, (ushort)0x1AFE], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:1A39 jne short 0x1A33
        if (!ZeroFlag)
        {
            return unknown_100D_1A33_11B03(0x0000);
        }
    label_100D_1A3B_11B0B_13316:
        CheckExternalEvents(cs1, 0x1A3B);
        // 100D:1A3B push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:1A3F call near 0xC08E
        NearCall(cs1, 0x1A42, unknown_100D_C08E_1C15E);
    label_100D_1A42_11B12_13319:
        CheckExternalEvents(cs1, 0x1A42);
        // 100D:1A42 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1A45 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:1A48 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:1A4A shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:1A4C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:1A4E add AX,0x1E7E
        AX = Alu16.Add(AX, (ushort)0x1E7E);
        // 100D:1A51 mov SI,AX
        SI = AX;
        // 100D:1A53 mov AX,0x004A
        AX = (ushort)0x004A;
        // 100D:1A56 call near 0x1A9B
        NearCall(cs1, 0x1A59, unknown_100D_1A9B_11B6B);
    label_100D_1A59_11B29_13357:
        CheckExternalEvents(cs1, 0x1A59);
        // 100D:1A59 mov AX,0x004B
        AX = (ushort)0x004B;
        // 100D:1A5C call near 0x1A9B
        NearCall(cs1, 0x1A5F, unknown_100D_1A9B_11B6B);
    label_100D_1A5F_11B2F_13361:
        CheckExternalEvents(cs1, 0x1A5F);
        // 100D:1A5F call near 0xD075
        NearCall(cs1, 0x1A62, unknown_100D_D075_1D145);
    label_100D_1A62_11B32_13367:
        CheckExternalEvents(cs1, 0x1A62);
        // 100D:1A62 mov word ptr DS:[0xDBE4],0xF1FA
        UInt16[DS, (ushort)0xDBE4] = (ushort)0xF1FA;
        // 100D:1A68 call near 0x1AD1
        NearCall(cs1, 0x1A6B, unknown_100D_1AD1_11BA1);
    label_100D_1A6B_11B3B_13378:
        CheckExternalEvents(cs1, 0x1A6B);
        // 100D:1A6B mov BX,0x016D
        BX = (ushort)0x016D;
        // 100D:1A6E add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:1A70 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:1A72 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:1A74 jae short 0x1A70
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1A74");
        }
    label_100D_1A76_11B46_13384:
        CheckExternalEvents(cs1, 0x1A76);
        // 100D:1A76 inc AX
        AX = Alu16.Inc(AX);
        // 100D:1A77 mov DX,0x000B
        DX = (ushort)0x000B;
        // 100D:1A7A mov BX,0x00BE
        BX = (ushort)0x00BE;
        // 100D:1A7D cmp AX,0x0064
        Alu16.Sub(AX, (ushort)0x0064);
        // 100D:1A80 jae short 0x1A8D
        if (!CarryFlag)
        {
            goto label_100D_1A8D_11B5D_13396;
        }
    label_100D_1A82_11B52_13390:
        CheckExternalEvents(cs1, 0x1A82);
        // 100D:1A82 sub DL,2
        DL = Alu8.Sub(DL, (byte)0x02);
        // 100D:1A85 cmp AX,0x000A
        Alu16.Sub(AX, (ushort)0x000A);
        // 100D:1A88 jae short 0x1A8D
        if (!CarryFlag)
        {
            goto label_100D_1A8D_11B5D_13396;
        }
    label_100D_1A8A_11B5A_13394:
        CheckExternalEvents(cs1, 0x1A8A);
        // 100D:1A8A sub DL,2
        DL = Alu8.Sub(DL, (byte)0x02);
    label_100D_1A8D_11B5D_13396:
        CheckExternalEvents(cs1, 0x1A8D);
        // 100D:1A8D call near 0xE290
        NearCall(cs1, 0x1A90, unknown_100D_E290_1E360);
    label_100D_1A90_11B60_13487:
        CheckExternalEvents(cs1, 0x1A90);
        // 100D:1A90 mov AL,0x20
        AL = (byte)0x20;
        // 100D:1A92 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x1A96, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:1A92");
        }
    label_100D_1A96_11B66_13490:
        CheckExternalEvents(cs1, 0x1A96);
        // 100D:1A96 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_1A96_11B66 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_1A96_11B66 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_1A96_11B66 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_1A96_11B66);
        // 100D:1A9A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1A9B_11B6B(int loadOffset)
    {
    label_100D_1A9B_11B6B_13329:
        CheckExternalEvents(cs1, 0x1A9B);
        // 100D:1A9B push AX
        Stack.Push16(AX);
        // 100D:1A9C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:1A9D mov DX,AX
        DX = AX;
        // 100D:1A9F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:1AA0 mov BX,AX
        BX = AX;
        // 100D:1AA2 pop AX
        AX = Stack.Pop16();
        // 100D:1AA3 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:1AA5 je short 0x1AC4
        if (ZeroFlag)
        {
            goto label_100D_1AC4_11B94_13356;
        }
    label_100D_1AA7_11B77_13338:
        CheckExternalEvents(cs1, 0x1AA7);
        // 100D:1AA7 push SI
        Stack.Push16(SI);
        // 100D:1AA8 call near 0xC1F4
        NearCall(cs1, 0x1AAB, unknown_100D_C1F4_1C2C4);
    label_100D_1AAB_11B7B_13341:
        CheckExternalEvents(cs1, 0x1AAB);
        // 100D:1AAB push DS
        Stack.Push16(DS);
        // 100D:1AAC push ES
        Stack.Push16(ES);
        // 100D:1AAD mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:1AB1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:1AB2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:1AB3 mov DI,AX
        DI = AX;
        // 100D:1AB5 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:1AB6 mov CX,AX
        CX = AX;
        // 100D:1AB8 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:1ABA mov BP,0x1EFE
        BP = (ushort)0x1EFE;
        // 100D:1ABD call far dword ptr SS:[0x38CD]
        ushort targetSegment_13352 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_13352 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_13352 == cs2 && targetOffset_13352 == 0x0112)
        {
            FarCall(cs1, 0x1AC2, cs2, unknown_3358_0112_33692);
            goto label_100D_1AC2_11B92_13353;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_13352:X4}:{targetOffset_13352:X4} at 100D:1ABD");
    label_100D_1AC2_11B92_13353:
        CheckExternalEvents(cs1, 0x1AC2);
        // 100D:1AC2 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:1AC3 pop SI
        SI = Stack.Pop16();
    label_100D_1AC4_11B94_13356:
        CheckExternalEvents(cs1, 0x1AC4);
        // 100D:1AC4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1AC5_11B95(int loadOffset)
    {
    label_100D_1AC5_11B95_23027:
        CheckExternalEvents(cs1, 0x1AC5);
        // 100D:1AC5 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1AC8 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ACA shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ACC shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ACE shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1AD0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1AD1_11BA1(int loadOffset)
    {
    label_100D_1AD1_11BA1_13370:
        CheckExternalEvents(cs1, 0x1AD1);
        // 100D:1AD1 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1AD4 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 100D:1AD7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1AD9 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ADB shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ADD shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:1ADF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1AE0_11BB0(int loadOffset)
    {
    label_100D_1AE0_11BB0_15146:
        CheckExternalEvents(cs1, 0x1AE0);
        // 100D:1AE0 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1AE3 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:1AE6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1AE7_11BB7(int loadOffset)
    {
    label_100D_1AE7_11BB7_14951:
        CheckExternalEvents(cs1, 0x1AE7);
        // 100D:1AE7 call near 0xD41B
        NearCall(cs1, 0x1AEA, unknown_100D_D41B_1D4EB);
    label_100D_1AEA_11BBA_14953:
        CheckExternalEvents(cs1, 0x1AEA);
        // 100D:1AEA cmp BP,0x1F7E
        Alu16.Sub(BP, (ushort)0x1F7E);
        // 100D:1AEE jne short 0x1B0C
        if (!ZeroFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1AF0_11BC0_16057:
        CheckExternalEvents(cs1, 0x1AF0);
        // 100D:1AF0 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:1AF3 cmp AX,word ptr DS:[0x4770]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x4770]);
        // 100D:1AF7 je short 0x1B0C
        if (ZeroFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1AF9_11BC9_16061:
        CheckExternalEvents(cs1, 0x1AF9);
        // 100D:1AF9 mov word ptr DS:[0x4770],AX
        UInt16[DS, (ushort)0x4770] = AX;
        // 100D:1AFC sub AX,word ptr DS:[0x476E]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x476E]);
        // 100D:1B00 cmp AX,word ptr DS:[0x4772]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x4772]);
        // 100D:1B04 jb short 0x1B0C
        if (CarryFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1B06_11BD6_34816:
        CheckExternalEvents(cs1, 0x1B06);
        // 100D:1B06 call near 0xC85B
        NearCall(cs1, 0x1B09, unknown_100D_C85B_1C92B);
    label_100D_1B09_11BD9_34818:
        CheckExternalEvents(cs1, 0x1B09);
        // 100D:1B09 call near 0xC868
        NearCall(cs1, 0x1B0C, unknown_100D_C868_1C938);
        return unknown_100D_1B0C_11BDC(0x0000);
    }

    public virtual Action unknown_100D_1B0D_11BDD(int loadOffset)
    {
    entrydispatcher:
    label_100D_1B0D_11BDD_14645:
        CheckExternalEvents(cs1, 0x1B0D);
        // 100D:1B0D call near 0xABCC
        NearCall(cs1, 0x1B10, unknown_100D_ABCC_1AC9C);
    label_100D_1B10_11BE0_14647:
        CheckExternalEvents(cs1, 0x1B10);
        // 100D:1B10 jne short 0x1B0C
        if (!ZeroFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1B12_11BE2_14649:
        CheckExternalEvents(cs1, 0x1B12);
        // 100D:1B12 cmp byte ptr DS:[0x2788],0
        Alu8.Sub(UInt8[DS, (ushort)0x2788], (byte)0x00);
        // 100D:1B17 jne short 0x1B0C
        if (!ZeroFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1B19_11BE9_14652:
        CheckExternalEvents(cs1, 0x1B19);
        // 100D:1B19 cmp byte ptr DS:[0x002A],0xC8
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0xC8);
        // 100D:1B1E jae short 0x1B0C
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1B1E");
        }
    label_100D_1B20_11BF0_14655:
        CheckExternalEvents(cs1, 0x1B20);
        // 100D:1B20 call near 0x2B2A
        NearCall(cs1, 0x1B23, unknown_100D_2B2A_12BFA);
        if (JumpDispatcher.Jump(unknown_100D_1B23_11BF3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1B23_11BF3(int loadOffset)
    {
    entrydispatcher:
    label_100D_1B23_11BF3_14676:
        CheckExternalEvents(cs1, 0x1B23);
        // 100D:1B23 cmp byte ptr DS:[0x46DD],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DD], (byte)0x00);
        // 100D:1B28 je short 0x1B0C
        if (ZeroFlag)
        {
            return unknown_100D_1B0C_11BDC(0x0000);
        }
    label_100D_1B2A_11BFA_14959:
        CheckExternalEvents(cs1, 0x1B2A);
        // 100D:1B2A mov byte ptr DS:[0x46DD],0
        UInt8[DS, (ushort)0x46DD] = (byte)0x00;
        // 100D:1B2F mov AL,byte ptr DS:[0x00F4]
        AL = UInt8[DS, (ushort)0x00F4];
        // 100D:1B32 dec AL
        AL = Alu8.Dec(AL);
        // 100D:1B34 cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:1B36 jge short 0x1B3D
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_1B3D_11C0D_14968;
        }
    label_100D_1B38_11C08_14965:
        CheckExternalEvents(cs1, 0x1B38);
        // 100D:1B38 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:1B3A mov byte ptr DS:[0x00F5],AL
        UInt8[DS, (ushort)0x00F5] = AL;
    label_100D_1B3D_11C0D_14968:
        CheckExternalEvents(cs1, 0x1B3D);
        // 100D:1B3D mov byte ptr DS:[0x00F4],AL
        UInt8[DS, (ushort)0x00F4] = AL;
        // 100D:1B40 call near 0x1A0F
        NearCall(cs1, 0x1B43, unknown_100D_1A0F_11ADF);
    label_100D_1B43_11C13_15048:
        CheckExternalEvents(cs1, 0x1B43);
        // 100D:1B43 call near 0x38E1
        NearCall(cs1, 0x1B46, unknown_100D_38E1_139B1);
    label_100D_1B46_11C16_15053:
        CheckExternalEvents(cs1, 0x1B46);
        // 100D:1B46 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1B49 mov CX,AX
        CX = AX;
        // 100D:1B4B xchg AX,word ptr DS:[0x1174]
        ushort xchgOffset_100D_1B4B_11C1B = (ushort)0x1174;
        ushort temp_100D_1B4B_11C1B = AX;
        AX = UInt16[DS, xchgOffset_100D_1B4B_11C1B];
        UInt16[DS, xchgOffset_100D_1B4B_11C1B] = unchecked((ushort)temp_100D_1B4B_11C1B);
        // 100D:1B4F and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:1B51 and CL,0xF0
        CL = Alu8.And(CL, (byte)0xF0);
        // 100D:1B54 sub AL,CL
        AL = Alu8.Sub(AL, CL);
        // 100D:1B56 mov byte ptr DS:[0x46DE],AL
        UInt8[DS, (ushort)0x46DE] = AL;
        // 100D:1B59 je short 0x1B5E
        if (ZeroFlag)
        {
            goto label_100D_1B5E_11C2E_15062;
        }
    label_100D_1B5B_11C2B_26628:
        CheckExternalEvents(cs1, 0x1B5B);
        // 100D:1B5B call near 0x1C46
        NearCall(cs1, 0x1B5E, unknown_100D_1C46_11D16);
    label_100D_1B5E_11C2E_15062:
        CheckExternalEvents(cs1, 0x1B5E);
        // 100D:1B5E cmp byte ptr DS:[0x00C2],7
        Alu8.Sub(UInt8[DS, (ushort)0x00C2], (byte)0x07);
        // 100D:1B63 jae short 0x1BB2
        if (!CarryFlag)
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1B65_11C35_15065:
        CheckExternalEvents(cs1, 0x1B65);
        // 100D:1B65 call near 0x1D9F
        NearCall(cs1, 0x1B68, unknown_100D_1D9F_11E6F);
    label_100D_1B68_11C38_15083:
        CheckExternalEvents(cs1, 0x1B68);
        // 100D:1B68 push word ptr DS:[0x11F7]
        Stack.Push16(UInt16[DS, (ushort)0x11F7]);
        // 100D:1B6C push word ptr DS:[0x11CE]
        Stack.Push16(UInt16[DS, (ushort)0x11CE]);
        // 100D:1B70 call near 0x6C6F
        NearCall(cs1, 0x1B73, unknown_100D_6C6F_16D3F);
    label_100D_1B73_11C43_15137:
        CheckExternalEvents(cs1, 0x1B73);
        // 100D:1B73 call near 0x63F0
        NearCall(cs1, 0x1B76, unknown_100D_63F0_164C0);
    label_100D_1B76_11C46_15144:
        CheckExternalEvents(cs1, 0x1B76);
        // 100D:1B76 call near 0x1AE0
        NearCall(cs1, 0x1B79, unknown_100D_1AE0_11BB0);
    label_100D_1B79_11C49_15150:
        CheckExternalEvents(cs1, 0x1B79);
        // 100D:1B79 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:1B7B mov SI,AX
        SI = AX;
        // 100D:1B7D call near word ptr CS:[SI+0x1DB3]
        switch ((ushort)(UInt16[CS, (ushort)(SI + (short)7603)]))
        {
            case 0x1DD3:
                NearCall(cs1, 0x1B82, unknown_100D_1DD3_11EA3);
                break;
            case 0x1DD4:
                NearCall(cs1, 0x1B82, unknown_100D_1DD4_11EA4);
                break;
            case 0x1DD7:
                NearCall(cs1, 0x1B82, unknown_100D_1DD7_11EA7);
                break;
            case 0x1DDA:
                NearCall(cs1, 0x1B82, unknown_100D_1DDA_11EAA);
                break;
            case 0x1DFE:
                NearCall(cs1, 0x1B82, unknown_100D_1DFE_11ECE);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)(SI + (short)7603)])):X4} at 100D:1B7D");
        }
    label_100D_1B82_11C52_15161:
        CheckExternalEvents(cs1, 0x1B82);
        // 100D:1B82 call near 0x1C18
        NearCall(cs1, 0x1B85, unknown_100D_1C18_11CE8);
    label_100D_1B85_11C55_15173:
        CheckExternalEvents(cs1, 0x1B85);
        // 100D:1B85 pop DI
        DI = Stack.Pop16();
        // 100D:1B86 call near 0x331E
        NearCall(cs1, 0x1B89, unknown_100D_331E_133EE);
    label_100D_1B89_11C59_15176:
        CheckExternalEvents(cs1, 0x1B89);
        // 100D:1B89 pop word ptr DS:[0x11F7]
        ushort popStackCheck_100D_1B89_11C59 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_1B89_11C59 = UInt16[DS, (ushort)0x11F7];
        ushort poppedValue_100D_1B89_11C59 = Stack.Pop16();
        UInt16[DS, (ushort)0x11F7] = unchecked((ushort)poppedValue_100D_1B89_11C59);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x1B8D))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1BB2_11C82(int loadOffset)
    {
    label_100D_1BB2_11C82_15199:
        CheckExternalEvents(cs1, 0x1BB2);
        // 100D:1BB2 mov byte ptr DS:[0x473B],0
        UInt8[DS, (ushort)0x473B] = (byte)0x00;
        // 100D:1BB7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1BEC_11CBC(int loadOffset)
    {
    label_100D_1BEC_11CBC_15179:
        CheckExternalEvents(cs1, 0x1BEC);
        // 100D:1BEC cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:1BF1 je short 0x1C17
        if (ZeroFlag)
        {
            goto label_100D_1C17_11CE7_15182;
        }
    label_100D_1BF3_11CC3_36339:
        CheckExternalEvents(cs1, 0x1BF3);
        // 100D:1BF3 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:1BF7 call near 0x503C
        NearCall(cs1, 0x1BFA, unknown_100D_503C_1510C);
    label_100D_1BFA_11CCA_36342:
        CheckExternalEvents(cs1, 0x1BFA);
        // 100D:1BFA cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:1BFF je short 0x1C06
        if (ZeroFlag)
        {
            goto label_100D_1C06_11CD6_36345;
        }
    label_100D_1C01_11CD1_40515:
        CheckExternalEvents(cs1, 0x1C01);
        // 100D:1C01 mov byte ptr DS:[0x46D9],6
        UInt8[DS, (ushort)0x46D9] = (byte)0x06;
    label_100D_1C06_11CD6_36345:
        CheckExternalEvents(cs1, 0x1C06);
        // 100D:1C06 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:1C0B jne short 0x1C17
        if (!ZeroFlag)
        {
            goto label_100D_1C17_11CE7_15182;
        }
    label_100D_1C0D_11CDD_36508:
        CheckExternalEvents(cs1, 0x1C0D);
        // 100D:1C0D push DI
        Stack.Push16(DI);
        // 100D:1C0E call near 0x0B21
        NearCall(cs1, 0x1C11, unknown_100D_0B21_10BF1);
    label_100D_1C11_11CE1_36511:
        CheckExternalEvents(cs1, 0x1C11);
        // 100D:1C11 pop DI
        DI = Stack.Pop16();
        // 100D:1C12 or byte ptr DS:[0x473B],1
        UInt8[DS, (ushort)0x473B] = Alu8.Or(UInt8[DS, (ushort)0x473B], (byte)0x01);
    label_100D_1C17_11CE7_15182:
        CheckExternalEvents(cs1, 0x1C17);
        // 100D:1C17 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1C18_11CE8(int loadOffset)
    {
    label_100D_1C18_11CE8_15163:
        CheckExternalEvents(cs1, 0x1C18);
        // 100D:1C18 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:1C1D jns short 0x1C39
        if (!SignFlag)
        {
            goto label_100D_1C39_11D09_15166;
        }
    label_100D_1C1F_11CEF_28161:
        CheckExternalEvents(cs1, 0x1C1F);
        // 100D:1C1F call near 0xC13B
        NearCall(cs1, 0x1C22, unknown_100D_C13B_1C20B);
    label_100D_1C22_11CF2_28163:
        CheckExternalEvents(cs1, 0x1C22);
        // 100D:1C22 mov SI,word ptr DS:[0x46FA]
        SI = UInt16[DS, (ushort)0x46FA];
        // 100D:1C26 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:1C28 je short 0x1C2D
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1C28");
        }
    label_100D_1C2D_11CFD_28167:
        CheckExternalEvents(cs1, 0x1C2D);
        // 100D:1C2D mov DI,word ptr DS:[0x46F8]
        DI = UInt16[DS, (ushort)0x46F8];
        // 100D:1C31 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:1C33 je short 0x1C38
        if (ZeroFlag)
        {
            goto label_100D_1C38_11D08_28171;
        }
    label_100D_1C35_11D05_36757:
        CheckExternalEvents(cs1, 0x1C35);
        // 100D:1C35 call near 0x600E
        NearCall(cs1, 0x1C38, unknown_100D_600E_160DE);
    label_100D_1C38_11D08_28171:
        CheckExternalEvents(cs1, 0x1C38);
        // 100D:1C38 ret near
        return NearRet((ushort)0x0000);
    label_100D_1C39_11D09_15166:
        CheckExternalEvents(cs1, 0x1C39);
        // 100D:1C39 jne short 0x1C45
        if (!ZeroFlag)
        {
            goto label_100D_1C45_11D15_15171;
        }
    label_100D_1C3B_11D0B_15168:
        CheckExternalEvents(cs1, 0x1C3B);
        // 100D:1C3B cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:1C40 jns short 0x1C45
        if (!SignFlag)
        {
            goto label_100D_1C45_11D15_15171;
        }
    label_100D_1C42_11D12_36918:
        CheckExternalEvents(cs1, 0x1C42);
        // 100D:1C42 call near 0xBDBB
        NearCall(cs1, 0x1C45, unknown_100D_BDBB_1BE8B);
    label_100D_1C45_11D15_15171:
        CheckExternalEvents(cs1, 0x1C45);
        // 100D:1C45 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1C46_11D16(int loadOffset)
    {
    label_100D_1C46_11D16_26630:
        CheckExternalEvents(cs1, 0x1C46);
        // 100D:1C46 mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:1C49 mov AH,AL
        AH = AL;
        // 100D:1C4B xchg AL,byte ptr DS:[0x00FE]
        ushort xchgOffset_100D_1C4B_11D1B = (ushort)0x00FE;
        byte temp_100D_1C4B_11D1B = AL;
        AL = UInt8[DS, xchgOffset_100D_1C4B_11D1B];
        UInt8[DS, xchgOffset_100D_1C4B_11D1B] = unchecked((byte)temp_100D_1C4B_11D1B);
        // 100D:1C4F cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:1C51 je short 0x1C58
        if (ZeroFlag)
        {
            goto label_100D_1C58_11D28_26638;
        }
    label_100D_1C53_11D23_26636:
        CheckExternalEvents(cs1, 0x1C53);
        // 100D:1C53 mov byte ptr DS:[0x00FF],0
        UInt8[DS, (ushort)0x00FF] = (byte)0x00;
    label_100D_1C58_11D28_26638:
        CheckExternalEvents(cs1, 0x1C58);
        // 100D:1C58 inc byte ptr DS:[0x00FF]
        UInt8[DS, (ushort)0x00FF] = Alu8.Inc(UInt8[DS, (ushort)0x00FF]);
        // 100D:1C5C call near 0x1D66
        NearCall(cs1, 0x1C5F, unknown_100D_1D66_11E36);
    label_100D_1C5F_11D2F_26668:
        CheckExternalEvents(cs1, 0x1C5F);
        // 100D:1C5F call near 0x1E43
        NearCall(cs1, 0x1C62, unknown_100D_1E43_11F13);
    label_100D_1C62_11D32_26677:
        CheckExternalEvents(cs1, 0x1C62);
        // 100D:1C62 mov AL,byte ptr DS:[0x00D5]
        AL = UInt8[DS, (ushort)0x00D5];
        // 100D:1C65 inc AL
        AL = Alu8.Inc(AL);
        // 100D:1C67 cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:1C69 jb short 0x1C6E
        if (CarryFlag)
        {
            goto label_100D_1C6E_11D3E_26682;
        }
    label_100D_1C6B_11D3B_33433:
        CheckExternalEvents(cs1, 0x1C6B);
        // 100D:1C6B mov byte ptr DS:[0x00D5],AL
        UInt8[DS, (ushort)0x00D5] = AL;
    label_100D_1C6E_11D3E_26682:
        CheckExternalEvents(cs1, 0x1C6E);
        // 100D:1C6E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:1C70 xchg AX,word ptr DS:[0x1172]
        ushort xchgOffset_100D_1C70_11D40 = (ushort)0x1172;
        ushort temp_100D_1C70_11D40 = AX;
        AX = UInt16[DS, xchgOffset_100D_1C70_11D40];
        UInt16[DS, xchgOffset_100D_1C70_11D40] = unchecked((ushort)temp_100D_1C70_11D40);
        // 100D:1C74 mov BX,word ptr DS:[0x00A0]
        BX = UInt16[DS, (ushort)0x00A0];
        // 100D:1C78 add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:1C7A xchg BX,word ptr DS:[0x1170]
        ushort xchgOffset_100D_1C7A_11D4A = (ushort)0x1170;
        ushort temp_100D_1C7A_11D4A = BX;
        BX = UInt16[DS, xchgOffset_100D_1C7A_11D4A];
        UInt16[DS, xchgOffset_100D_1C7A_11D4A] = unchecked((ushort)temp_100D_1C7A_11D4A);
        // 100D:1C7E sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:1C80 jae short 0x1C84
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1C80");
        }
    label_100D_1C84_11D54_26690:
        CheckExternalEvents(cs1, 0x1C84);
        // 100D:1C84 mov word ptr DS:[0x00A6],AX
        UInt16[DS, (ushort)0x00A6] = AX;
        // 100D:1C87 xchg AX,word ptr DS:[0x00AE]
        ushort xchgOffset_100D_1C87_11D57 = (ushort)0x00AE;
        ushort temp_100D_1C87_11D57 = AX;
        AX = UInt16[DS, xchgOffset_100D_1C87_11D57];
        UInt16[DS, xchgOffset_100D_1C87_11D57] = unchecked((ushort)temp_100D_1C87_11D57);
        // 100D:1C8B xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:1C8D sub AX,word ptr DS:[0x00A6]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x00A6]);
        // 100D:1C91 jae short 0x1C96
        if (!CarryFlag)
        {
            goto label_100D_1C96_11D66_26699;
        }
    label_100D_1C93_11D63_26696:
        CheckExternalEvents(cs1, 0x1C93);
        // 100D:1C93 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:1C95 xchg BX,AX
        ushort temp_100D_1C95_11D65 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_1C95_11D65);
    label_100D_1C96_11D66_26699:
        CheckExternalEvents(cs1, 0x1C96);
        // 100D:1C96 mov word ptr DS:[0x00B2],AX
        UInt16[DS, (ushort)0x00B2] = AX;
        // 100D:1C99 mov word ptr DS:[0x00B0],BX
        UInt16[DS, (ushort)0x00B0] = BX;
        // 100D:1C9D call near 0x1CDA
        NearCall(cs1, 0x1CA0, unknown_100D_1CDA_11DAA);
    label_100D_1CA0_11D70_26736:
        CheckExternalEvents(cs1, 0x1CA0);
        // 100D:1CA0 call near 0xC02E
        NearCall(cs1, 0x1CA3, unknown_100D_C02E_1C0FE);
    label_100D_1CA3_11D73_26741:
        CheckExternalEvents(cs1, 0x1CA3);
        // 100D:1CA3 call near 0xBF26
        NearCall(cs1, 0x1CA6, unknown_100D_BF26_1BFF6);
    label_100D_1CA6_11D76_26747:
        CheckExternalEvents(cs1, 0x1CA6);
        // 100D:1CA6 call near 0xE3CC
        NearCall(cs1, 0x1CA9, unknown_100D_E3CC_1E49C);
    label_100D_1CA9_11D79_26749:
        CheckExternalEvents(cs1, 0x1CA9);
        // 100D:1CA9 mov BX,AX
        BX = AX;
        // 100D:1CAB mov SI,0x10D8
        SI = (ushort)0x10D8;
    label_100D_1CAE_11D7E_26752:
        CheckExternalEvents(cs1, 0x1CAE);
        // 100D:1CAE test byte ptr DS:[SI+2],8
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x08);
        // 100D:1CB2 je short 0x1CD1
        if (ZeroFlag)
        {
            goto label_100D_1CD1_11DA1_26754;
        }
    label_100D_1CB4_11D84_34098:
        CheckExternalEvents(cs1, 0x1CB4);
        // 100D:1CB4 mov BP,4
        BP = (ushort)0x0004;
    label_100D_1CB7_11D87_34100:
        CheckExternalEvents(cs1, 0x1CB7);
        // 100D:1CB7 cmp byte ptr SS:[BP+SI+4],0
        Alu8.Sub(UInt8[SS, (ushort)(BP + SI + (sbyte)4)], (byte)0x00);
        // 100D:1CBB jne short 0x1CCE
        if (!ZeroFlag)
        {
            goto label_100D_1CCE_11D9E_34102;
        }
    label_100D_1CBD_11D8D_34106:
        CheckExternalEvents(cs1, 0x1CBD);
        // 100D:1CBD cmp byte ptr SS:[BP+SI+9],0
        Alu8.Sub(UInt8[SS, (ushort)(BP + SI + (sbyte)9)], (byte)0x00);
        // 100D:1CC1 jns short 0x1CCE
        if (!SignFlag)
        {
            goto label_100D_1CCE_11D9E_34102;
        }
    label_100D_1CC3_11D93_34109:
        CheckExternalEvents(cs1, 0x1CC3);
        // 100D:1CC3 rol BX,1
        BX = Alu16.Rol(BX, unchecked((byte)1));
        // 100D:1CC5 rol BX,1
        BX = Alu16.Rol(BX, unchecked((byte)1));
        // 100D:1CC7 mov AL,BL
        AL = BL;
        // 100D:1CC9 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:1CCB mov byte ptr SS:[BP+SI+4],AL
        UInt8[SS, (ushort)(BP + SI + (sbyte)4)] = AL;
    label_100D_1CCE_11D9E_34102:
        CheckExternalEvents(cs1, 0x1CCE);
        // 100D:1CCE dec BP
        BP = Alu16.Dec(BP);
        // 100D:1CCF jns short 0x1CB7
        if (!SignFlag)
        {
            goto label_100D_1CB7_11D87_34100;
        }
    label_100D_1CD1_11DA1_26754:
        CheckExternalEvents(cs1, 0x1CD1);
        // 100D:1CD1 add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:1CD4 cmp byte ptr DS:[SI],0x14
        Alu8.Sub(UInt8[DS, SI], (byte)0x14);
        // 100D:1CD7 jb short 0x1CAE
        if (CarryFlag)
        {
            goto label_100D_1CAE_11D7E_26752;
        }
    label_100D_1CD9_11DA9_26759:
        CheckExternalEvents(cs1, 0x1CD9);
        // 100D:1CD9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1CDA_11DAA(int loadOffset)
    {
    label_100D_1CDA_11DAA_26702:
        CheckExternalEvents(cs1, 0x1CDA);
        // 100D:1CDA mov DI,0x0100
        DI = (ushort)0x0100;
        // 100D:1CDD xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:1CDF xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_100D_1CE1_11DB1_26706:
        CheckExternalEvents(cs1, 0x1CE1);
        // 100D:1CE1 call near 0x5D36
        NearCall(cs1, 0x1CE4, unknown_100D_5D36_15E06);
    label_100D_1CE4_11DB4_26707:
        CheckExternalEvents(cs1, 0x1CE4);
        // 100D:1CE4 jb short 0x1CF4
        if (CarryFlag)
        {
            goto label_100D_1CF4_11DC4_26709;
        }
    label_100D_1CE6_11DB6_26717:
        CheckExternalEvents(cs1, 0x1CE6);
        // 100D:1CE6 inc DX
        DX = Alu16.Inc(DX);
        // 100D:1CE7 mov AL,byte ptr DS:[DI+0x12]
        AL = UInt8[DS, (ushort)(DI + (sbyte)18)];
        // 100D:1CEA shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:1CEC shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:1CEE shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:1CF0 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:1CF2 add CX,AX
        CX = Alu16.Add(CX, AX);
    label_100D_1CF4_11DC4_26709:
        CheckExternalEvents(cs1, 0x1CF4);
        // 100D:1CF4 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:1CF7 cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:1CFA jne short 0x1CE1
        if (!ZeroFlag)
        {
            goto label_100D_1CE1_11DB1_26706;
        }
    label_100D_1CFC_11DCC_26725:
        CheckExternalEvents(cs1, 0x1CFC);
        // 100D:1CFC mov BX,CX
        BX = CX;
        // 100D:1CFE shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:1D00 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:1D02 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:1D04 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:1D06 call near 0xE3DF
        NearCall(cs1, 0x1D09, unknown_100D_E3DF_1E4AF);
    label_100D_1D09_11DD9_26732:
        CheckExternalEvents(cs1, 0x1D09);
        // 100D:1D09 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:1D0B mov word ptr DS:[0x00A8],CX
        UInt16[DS, (ushort)0x00A8] = CX;
        // 100D:1D0F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1D66_11E36(int loadOffset)
    {
    label_100D_1D66_11E36_26640:
        CheckExternalEvents(cs1, 0x1D66);
        // 100D:1D66 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:1D69 mov CX,0x000C
        CX = (ushort)0x000C;
    label_100D_1D6C_11E3C_26643:
        CheckExternalEvents(cs1, 0x1D6C);
        // 100D:1D6C mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:1D6F cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:1D71 jne short 0x1D99
        if (!ZeroFlag)
        {
            goto label_100D_1D99_11E69_26662;
        }
    label_100D_1D73_11E43_26646:
        CheckExternalEvents(cs1, 0x1D73);
        // 100D:1D73 cmp AH,0xFF
        Alu8.Sub(AH, (byte)0xFF);
        // 100D:1D76 je short 0x1D99
        if (ZeroFlag)
        {
            goto label_100D_1D99_11E69_26662;
        }
    label_100D_1D78_11E48_26649:
        CheckExternalEvents(cs1, 0x1D78);
        // 100D:1D78 mov AL,0x1C
        AL = (byte)0x1C;
        // 100D:1D7A mul AH
        ushort result_100D_1D7A_11E4A = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_1D7A_11E4A >> 8));
        AL = unchecked((byte)result_100D_1D7A_11E4A);
        // 100D:1D7C add AX,0x00E4
        AX = Alu16.Add(AX, (ushort)0x00E4);
        // 100D:1D7F mov DI,AX
        DI = AX;
        // 100D:1D81 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:1D83 mov BL,byte ptr DS:[DI+8]
        BL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:1D86 cmp AH,BL
        Alu8.Sub(AH, BL);
        // 100D:1D88 jne short 0x1D93
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1D88");
        }
    label_100D_1D8A_11E5A_26658:
        CheckExternalEvents(cs1, 0x1D8A);
        // 100D:1D8A xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:1D8C cmp AL,byte ptr CS:[BX+0x1D35]
        Alu8.Sub(AL, UInt8[CS, (ushort)(BX + (short)7477)]);
        // 100D:1D91 jbe short 0x1D99
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1D91");
        }
    label_100D_1D99_11E69_26662:
        CheckExternalEvents(cs1, 0x1D99);
        // 100D:1D99 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:1D9C loop 0x1D6C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_1D6C_11E3C_26643;
        }
    label_100D_1D9E_11E6E_26666:
        CheckExternalEvents(cs1, 0x1D9E);
        // 100D:1D9E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1D9F_11E6F(int loadOffset)
    {
    label_100D_1D9F_11E6F_15067:
        CheckExternalEvents(cs1, 0x1D9F);
        // 100D:1D9F test word ptr DS:[0x0012],0x0080
        Alu16.And(UInt16[DS, (ushort)0x0012], (ushort)0x0080);
        // 100D:1DA5 jne short 0x1DB2
        if (!ZeroFlag)
        {
            goto label_100D_1DB2_11E82_15081;
        }
    label_100D_1DA7_11E77_15070:
        CheckExternalEvents(cs1, 0x1DA7);
        // 100D:1DA7 mov SI,0x1048
        SI = (ushort)0x1048;
        // 100D:1DAA call near 0x1E01
        NearCall(cs1, 0x1DAD, unknown_100D_1E01_11ED1);
    label_100D_1DAD_11E7D_15079:
        CheckExternalEvents(cs1, 0x1DAD);
        // 100D:1DAD jae short 0x1DB2
        if (!CarryFlag)
        {
            goto label_100D_1DB2_11E82_15081;
        }
    label_100D_1DAF_11E7F_35770:
        CheckExternalEvents(cs1, 0x1DAF);
        // 100D:1DAF call near 0x1EDA
        NearCall(cs1, 0x1DB2, unknown_100D_1EDA_11FAA);
    label_100D_1DB2_11E82_15081:
        CheckExternalEvents(cs1, 0x1DB2);
        // 100D:1DB2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1DD3_11EA3(int loadOffset)
    {
    label_100D_1DD3_11EA3_22509:
        CheckExternalEvents(cs1, 0x1DD3);
        // 100D:1DD3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1DD4_11EA4(int loadOffset)
    {
    label_100D_1DD4_11EA4_15154:
        CheckExternalEvents(cs1, 0x1DD4);
        // 100D:1DD4 jmp near 0x20A4
        goto label_100D_20A4_12174_15156;
    label_100D_2098_12168_41057:
        CheckExternalEvents(cs1, 0x2098);
        // 100D:2098 sub AX,word ptr DS:[0x118D]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x118D]);
        // 100D:209C je short 0x20D1
        if (ZeroFlag)
        {
            goto label_100D_20D1_121A1_15159;
        }
    label_100D_209E_1216E_41061:
        CheckExternalEvents(cs1, 0x209E);
        // 100D:209E neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:20A0 mov byte ptr DS:[0x00CF],AL
        UInt8[DS, (ushort)0x00CF] = AL;
        // 100D:20A3 ret near
        return NearRet((ushort)0x0000);
    label_100D_20A4_12174_15156:
        CheckExternalEvents(cs1, 0x20A4);
        // 100D:20A4 test byte ptr DS:[0x00BF],0x80
        Alu8.And(UInt8[DS, (ushort)0x00BF], (byte)0x80);
        // 100D:20A9 je short 0x20D1
        if (ZeroFlag)
        {
            goto label_100D_20D1_121A1_15159;
        }
    label_100D_20AB_1217B_33333:
        CheckExternalEvents(cs1, 0x20AB);
        // 100D:20AB call near 0x1AC5
        NearCall(cs1, 0x20AE, unknown_100D_1AC5_11B95);
    label_100D_20AE_1217E_33335:
        CheckExternalEvents(cs1, 0x20AE);
        // 100D:20AE cmp byte ptr DS:[0x00C2],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C2], (byte)0x00);
        // 100D:20B3 jne short 0x2098
        if (!ZeroFlag)
        {
            goto label_100D_2098_12168_41057;
        }
    label_100D_20B5_12185_33338:
        CheckExternalEvents(cs1, 0x20B5);
        // 100D:20B5 test byte ptr DS:[0x00BF],0x10
        Alu8.And(UInt8[DS, (ushort)0x00BF], (byte)0x10);
        // 100D:20BA jne short 0x2131
        if (!ZeroFlag)
        {
            goto label_100D_2131_12201_34713;
        }
    label_100D_20BC_1218C_33341:
        CheckExternalEvents(cs1, 0x20BC);
        // 100D:20BC cmp byte ptr DS:[0x11BB],0
        Alu8.Sub(UInt8[DS, (ushort)0x11BB], (byte)0x00);
        // 100D:20C1 je short 0x20C6
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:20C1");
        }
    label_100D_20C6_12196_33344:
        CheckExternalEvents(cs1, 0x20C6);
        // 100D:20C6 sub AX,word ptr DS:[0x118D]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x118D]);
        // 100D:20CA je short 0x20D2
        if (ZeroFlag)
        {
            return unknown_100D_20D2_121A2(0x0000);
        }
    label_100D_20CC_1219C_33347:
        CheckExternalEvents(cs1, 0x20CC);
        // 100D:20CC neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:20CE mov byte ptr DS:[0x00CF],AL
        UInt8[DS, (ushort)0x00CF] = AL;
    label_100D_20D1_121A1_15159:
        CheckExternalEvents(cs1, 0x20D1);
        // 100D:20D1 ret near
        return NearRet((ushort)0x0000);
    label_100D_2131_12201_34713:
        CheckExternalEvents(cs1, 0x2131);
        // 100D:2131 sub AX,word ptr DS:[0x118D]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x118D]);
        // 100D:2135 je short 0x20D1
        if (ZeroFlag)
        {
            goto label_100D_20D1_121A1_15159;
        }
    label_100D_2137_12207_34716:
        CheckExternalEvents(cs1, 0x2137);
        // 100D:2137 cmp AX,4
        Alu16.Sub(AX, (ushort)0x0004);
        // 100D:213A jae short 0x215F
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:213A");
        }
    label_100D_213C_1220C_34719:
        CheckExternalEvents(cs1, 0x213C);
        // 100D:213C shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:213E shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:2140 mov BL,AL
        BL = AL;
        // 100D:2142 call near 0x24D2
        NearCall(cs1, 0x2145, unknown_100D_24D2_125A2);
    label_100D_2145_12215_34724:
        CheckExternalEvents(cs1, 0x2145);
        // 100D:2145 mov AL,AH
        AL = AH;
        // 100D:2147 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:2149 jb short 0x214D
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2149");
        }
    label_100D_214D_1221D_34728:
        CheckExternalEvents(cs1, 0x214D);
        // 100D:214D add AL,BL
        AL = Alu8.Add(AL, BL);
        // 100D:214F mov BX,0x2161
        BX = (ushort)0x2161;
        // 100D:2152 xlat byte ptr CS:[BX+AL]
        AL = UInt8[CS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:2154 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:2156 je short 0x215F
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2156");
        }
    label_100D_2158_12228_34734:
        CheckExternalEvents(cs1, 0x2158);
        // 100D:2158 mov AH,AL
        AH = AL;
        // 100D:215A mov AL,0x0B
        AL = (byte)0x0B;
        // 100D:215C jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_1DD7_11EA7(int loadOffset)
    {
    label_100D_1DD7_11EA7_22433:
        CheckExternalEvents(cs1, 0x1DD7);
        // 100D:1DD7 jmp near 0x1F64
    label_100D_1F64_12034_22435:
        CheckExternalEvents(cs1, 0x1F64);
        // 100D:1F64 cmp byte ptr DS:[0x002A],0x3C
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x3C);
        // 100D:1F69 jae short 0x1F79
        if (!CarryFlag)
        {
            goto label_100D_1F79_12049_34083;
        }
    label_100D_1F6B_1203B_22438:
        CheckExternalEvents(cs1, 0x1F6B);
        // 100D:1F6B mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:1F6E sub AX,word ptr DS:[0x1154]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x1154]);
        // 100D:1F72 jb short 0x1F91
        if (CarryFlag)
        {
            goto label_100D_1F91_12061_22442;
        }
    label_100D_1F74_12044_33557:
        CheckExternalEvents(cs1, 0x1F74);
        // 100D:1F74 cmp AX,0x0070
        Alu16.Sub(AX, (ushort)0x0070);
        // 100D:1F77 jb short 0x1F91
        if (CarryFlag)
        {
            goto label_100D_1F91_12061_22442;
        }
    label_100D_1F79_12049_34083:
        CheckExternalEvents(cs1, 0x1F79);
        // 100D:1F79 test word ptr DS:[2],0x0010
        Alu16.And(UInt16[DS, (ushort)0x0002], (ushort)0x0010);
        // 100D:1F7F jne short 0x1F91
        if (!ZeroFlag)
        {
            goto label_100D_1F91_12061_22442;
        }
    label_100D_1F81_12051_34122:
        CheckExternalEvents(cs1, 0x1F81);
        // 100D:1F81 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:1F83 xchg AL,byte ptr DS:[0x11BC]
        ushort xchgOffset_100D_1F83_12053 = (ushort)0x11BC;
        byte temp_100D_1F83_12053 = AL;
        AL = UInt8[DS, xchgOffset_100D_1F83_12053];
        UInt8[DS, xchgOffset_100D_1F83_12053] = unchecked((byte)temp_100D_1F83_12053);
        // 100D:1F87 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:1F89 jne short 0x1F91
        if (!ZeroFlag)
        {
            goto label_100D_1F91_12061_22442;
        }
    label_100D_1F8B_1205B_34127:
        CheckExternalEvents(cs1, 0x1F8B);
        // 100D:1F8B rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:1F8F jb short 0x1F92
        if (CarryFlag)
        {
            goto label_100D_1F92_12062_34130;
        }
    label_100D_1F91_12061_22442:
        CheckExternalEvents(cs1, 0x1F91);
        // 100D:1F91 ret near
        return NearRet((ushort)0x0000);
    label_100D_1F92_12062_34130:
        CheckExternalEvents(cs1, 0x1F92);
        // 100D:1F92 call near 0x2017
        NearCall(cs1, 0x1F95, unknown_100D_2017_120E7);
    label_100D_1F95_12065_34218:
        CheckExternalEvents(cs1, 0x1F95);
        // 100D:1F95 je short 0x2013
        if (ZeroFlag)
        {
            goto label_100D_2013_120E3_41009;
        }
    label_100D_1F97_12067_34220:
        CheckExternalEvents(cs1, 0x1F97);
        // 100D:1F97 inc byte ptr DS:[0x00C4]
        UInt8[DS, (ushort)0x00C4] = Alu8.Inc(UInt8[DS, (ushort)0x00C4]);
        // 100D:1F9B mov CX,2
        CX = (ushort)0x0002;
    label_100D_1F9E_1206E_34223:
        CheckExternalEvents(cs1, 0x1F9E);
        // 100D:1F9E mov AL,byte ptr SS:[BP+9]
        AL = UInt8[SS, (ushort)(BP + (sbyte)9)];
    label_100D_1FA1_12071_34224:
        CheckExternalEvents(cs1, 0x1FA1);
        // 100D:1FA1 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:1FA3 je short 0x1FCB
        if (ZeroFlag)
        {
            goto label_100D_1FCB_1209B_34259;
        }
    label_100D_1FA5_12075_34226:
        CheckExternalEvents(cs1, 0x1FA5);
        // 100D:1FA5 call near 0x6906
        NearCall(cs1, 0x1FA8, unknown_100D_6906_169D6);
    label_100D_1FA8_12078_34228:
        CheckExternalEvents(cs1, 0x1FA8);
        // 100D:1FA8 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:1FAB test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:1FAF je short 0x1FA1
        if (ZeroFlag)
        {
            goto label_100D_1FA1_12071_34224;
        }
    label_100D_1FB1_12081_34232:
        CheckExternalEvents(cs1, 0x1FB1);
        // 100D:1FB1 push CX
        Stack.Push16(CX);
        // 100D:1FB2 push BP
        Stack.Push16(BP);
        // 100D:1FB3 push SI
        Stack.Push16(SI);
        // 100D:1FB4 push DI
        Stack.Push16(DI);
        // 100D:1FB5 mov byte ptr DS:[SI+3],0x8D
        UInt8[DS, (ushort)(SI + (sbyte)3)] = (byte)0x8D;
        // 100D:1FB9 call near 0x84A6
        NearCall(cs1, 0x1FBC, unknown_100D_84A6_18576);
    label_100D_1FBC_1208C_34241:
        CheckExternalEvents(cs1, 0x1FBC);
        // 100D:1FBC pop DI
        DI = Stack.Pop16();
        // 100D:1FBD pop SI
        SI = Stack.Pop16();
        // 100D:1FBE and byte ptr DS:[SI+0x10],0xEF
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0xEF);
        // 100D:1FC2 push DI
        Stack.Push16(DI);
        // 100D:1FC3 call near 0x8357
        NearCall(cs1, 0x1FC6, unknown_100D_8357_18427);
    label_100D_1FC6_12096_34253:
        CheckExternalEvents(cs1, 0x1FC6);
        // 100D:1FC6 pop DI
        DI = Stack.Pop16();
        // 100D:1FC7 pop BP
        BP = Stack.Pop16();
        // 100D:1FC8 pop CX
        CX = Stack.Pop16();
        // 100D:1FC9 loop 0x1F9E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_1F9E_1206E_34223;
        }
    label_100D_1FCB_1209B_34259:
        CheckExternalEvents(cs1, 0x1FCB);
        // 100D:1FCB or byte ptr DS:[DI+0x0A],2
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:1FCF call near 0x83FD
        NearCall(cs1, 0x1FD2, unknown_100D_83FD_184CD);
    label_100D_1FD2_120A2_34281:
        CheckExternalEvents(cs1, 0x1FD2);
        // 100D:1FD2 call near 0x40AE
        NearCall(cs1, 0x1FD5, unknown_100D_40AE_1417E);
    label_100D_1FD5_120A5_34283:
        CheckExternalEvents(cs1, 0x1FD5);
        // 100D:1FD5 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:1FD8 mov CX,9
        CX = (ushort)0x0009;
    label_100D_1FDB_120AB_34286:
        CheckExternalEvents(cs1, 0x1FDB);
        // 100D:1FDB cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:1FDE jne short 0x1FE2
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1FDE");
        }
    label_100D_1FE2_120B2_34288:
        CheckExternalEvents(cs1, 0x1FE2);
        // 100D:1FE2 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:1FE5 loop 0x1FDB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_1FDB_120AB_34286;
        }
    label_100D_1FE7_120B7_34292:
        CheckExternalEvents(cs1, 0x1FE7);
        // 100D:1FE7 mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:1FE9 mov SI,0x08E0
        SI = (ushort)0x08E0;
        // 100D:1FEC cmp DI,word ptr DS:[SI+4]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:1FEF jne short 0x1FF3
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1FEF");
        }
    label_100D_1FF3_120C3_34297:
        CheckExternalEvents(cs1, 0x1FF3);
        // 100D:1FF3 push BX
        Stack.Push16(BX);
        // 100D:1FF4 push DX
        Stack.Push16(DX);
        // 100D:1FF5 call near 0x71B2
        NearCall(cs1, 0x1FF8, unknown_100D_71B2_17282);
    label_100D_1FF8_120C8_34301:
        CheckExternalEvents(cs1, 0x1FF8);
        // 100D:1FF8 pop DX
        DX = Stack.Pop16();
        // 100D:1FF9 pop BX
        BX = Stack.Pop16();
        // 100D:1FFA cmp BX,word ptr DS:[6]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x0006]);
        // 100D:1FFE jne short 0x2014
        if (!ZeroFlag)
        {
            goto label_100D_2014_120E4_34306;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1FFE");
        }
    label_100D_2013_120E3_41009:
        CheckExternalEvents(cs1, 0x2013);
        // 100D:2013 ret near
        return NearRet((ushort)0x0000);
    label_100D_2014_120E4_34306:
        CheckExternalEvents(cs1, 0x2014);
        // 100D:2014 jmp near 0x5D50
        return unknown_100D_5D50_15E20(0x0000);
    }

    public virtual Action unknown_100D_1DDA_11EAA(int loadOffset)
    {
    label_100D_1DDA_11EAA_22848:
        CheckExternalEvents(cs1, 0x1DDA);
        // 100D:1DDA test byte ptr DS:[0x00BF],0x10
        Alu8.And(UInt8[DS, (ushort)0x00BF], (byte)0x10);
        // 100D:1DDF je short 0x1DFD
        if (ZeroFlag)
        {
            goto label_100D_1DFD_11ECD_22851;
        }
    label_100D_1DE1_11EB1_34589:
        CheckExternalEvents(cs1, 0x1DE1);
        // 100D:1DE1 test word ptr DS:[0x0010],8
        Alu16.And(UInt16[DS, (ushort)0x0010], (ushort)0x0008);
        // 100D:1DE7 jne short 0x1DFD
        if (!ZeroFlag)
        {
            goto label_100D_1DFD_11ECD_22851;
        }
    label_100D_1DE9_11EB9_34592:
        CheckExternalEvents(cs1, 0x1DE9);
        // 100D:1DE9 cmp byte ptr DS:[0x000B],8
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x08);
        // 100D:1DEE je short 0x1DFD
        if (ZeroFlag)
        {
            goto label_100D_1DFD_11ECD_22851;
        }
    label_100D_1DF0_11EC0_34595:
        CheckExternalEvents(cs1, 0x1DF0);
        // 100D:1DF0 cmp byte ptr DS:[0x00C2],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C2], (byte)0x00);
        // 100D:1DF5 jne short 0x1DFD
        if (!ZeroFlag)
        {
            goto label_100D_1DFD_11ECD_22851;
        }
    label_100D_1DF7_11EC7_34598:
        CheckExternalEvents(cs1, 0x1DF7);
        // 100D:1DF7 mov AX,0x030B
        AX = (ushort)0x030B;
        // 100D:1DFA call near 0x29EE
        NearCall(cs1, 0x1DFD, unknown_100D_29EE_12ABE);
    label_100D_1DFD_11ECD_22851:
        CheckExternalEvents(cs1, 0x1DFD);
        // 100D:1DFD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1DFE_11ECE(int loadOffset)
    {
        goto label_100D_1DFE_11ECE_26006;

    label_100D_1D10_11DE0_26008:
        CheckExternalEvents(cs1, 0x1D10);
        // 100D:1D10 rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:1D14 jae short 0x1D34
        if (!CarryFlag)
        {
            goto label_100D_1D34_11E04_26011;
        }
    label_100D_1D16_11DE6_32135:
        CheckExternalEvents(cs1, 0x1D16);
        // 100D:1D16 mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_1D19_11DE9_32137:
        CheckExternalEvents(cs1, 0x1D19);
        // 100D:1D19 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:1D1D je short 0x1D2B
        if (ZeroFlag)
        {
            goto label_100D_1D2B_11DFB_32139;
        }
    label_100D_1D1F_11DEF_32144:
        CheckExternalEvents(cs1, 0x1D1F);
        // 100D:1D1F mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:1D22 dec AL
        AL = Alu8.Dec(AL);
        // 100D:1D24 cmp AL,0xC7
        Alu8.Sub(AL, (byte)0xC7);
        // 100D:1D26 jae short 0x1D2B
        if (!CarryFlag)
        {
            goto label_100D_1D2B_11DFB_32139;
        }
    label_100D_1D28_11DF8_32149:
        CheckExternalEvents(cs1, 0x1D28);
        // 100D:1D28 inc byte ptr DS:[SI+0x1A]
        UInt8[DS, (ushort)(SI + (sbyte)26)] = Alu8.Inc(UInt8[DS, (ushort)(SI + (sbyte)26)]);
    label_100D_1D2B_11DFB_32139:
        CheckExternalEvents(cs1, 0x1D2B);
        // 100D:1D2B add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:1D2E cmp SI,0x0FA0
        Alu16.Sub(SI, (ushort)0x0FA0);
        // 100D:1D32 jb short 0x1D19
        if (CarryFlag)
        {
            goto label_100D_1D19_11DE9_32137;
        }
    label_100D_1D34_11E04_26011:
        CheckExternalEvents(cs1, 0x1D34);
        // 100D:1D34 ret near
        return NearRet((ushort)0x0000);
    label_100D_1DFE_11ECE_26006:
        CheckExternalEvents(cs1, 0x1DFE);
        // 100D:1DFE jmp near 0x1D10
        goto label_100D_1D10_11DE0_26008;
    }

    public virtual Action unknown_100D_1E01_11ED1(int loadOffset)
    {
    label_100D_1E01_11ED1_15073:
        CheckExternalEvents(cs1, 0x1E01);
        // 100D:1E01 cmp byte ptr DS:[0x002A],0x5D
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x5D);
        // 100D:1E06 jne short 0x1E3E
        if (!ZeroFlag)
        {
            return unknown_100D_1E3E_11F0E(0x0000);
        }
    label_100D_1E08_11ED8_35745:
        CheckExternalEvents(cs1, 0x1E08);
        // 100D:1E08 cmp byte ptr DS:[SI+0x0E],7
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)14)], (byte)0x07);
        // 100D:1E0C jne short 0x1E3E
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1E0C");
        }
    label_100D_1E0E_11EDE_35748:
        CheckExternalEvents(cs1, 0x1E0E);
        // 100D:1E0E mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:1E11 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:1E14 jne short 0x1E3E
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1E14");
        }
    label_100D_1E16_11EE6_35752:
        CheckExternalEvents(cs1, 0x1E16);
        // 100D:1E16 mov byte ptr DS:[SI],2
        UInt8[DS, SI] = (byte)0x02;
        // 100D:1E19 jne short 0x1E3E
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1E19");
        }
    label_100D_1E1B_11EEB_35755:
        CheckExternalEvents(cs1, 0x1E1B);
        // 100D:1E1B mov AL,0x1C
        AL = (byte)0x1C;
        // 100D:1E1D mul BH
        ushort result_100D_1E1D_11EED = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)BH)));
        AH = unchecked((byte)(result_100D_1E1D_11EED >> 8));
        AL = unchecked((byte)result_100D_1E1D_11EED);
        // 100D:1E1F add AX,0x00E4
        AX = Alu16.Add(AX, (ushort)0x00E4);
        // 100D:1E22 mov DI,AX
        DI = AX;
        return unknown_100D_1E24_11EF4(0x0000);
    }

    public virtual Action unknown_100D_1E24_11EF4(int loadOffset)
    {
    label_100D_1E24_11EF4_34151:
        CheckExternalEvents(cs1, 0x1E24);
        // 100D:1E24 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:1E27 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:1E29 je short 0x1E3E
        if (ZeroFlag)
        {
            return unknown_100D_1E3E_11F0E(0x0000);
        }
    label_100D_1E2B_11EFB_34155:
        CheckExternalEvents(cs1, 0x1E2B);
        // 100D:1E2B push SI
        Stack.Push16(SI);
    label_100D_1E2C_11EFC_34157:
        CheckExternalEvents(cs1, 0x1E2C);
        // 100D:1E2C call near 0x6906
        NearCall(cs1, 0x1E2F, unknown_100D_6906_169D6);
    label_100D_1E2F_11EFF_34158:
        CheckExternalEvents(cs1, 0x1E2F);
        // 100D:1E2F test word ptr DS:[SI+0x12],0x0400
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0400);
        // 100D:1E34 jne short 0x1E40
        if (!ZeroFlag)
        {
            goto label_100D_1E40_11F10_35760;
        }
    label_100D_1E36_11F06_34161:
        CheckExternalEvents(cs1, 0x1E36);
        // 100D:1E36 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:1E39 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:1E3B jne short 0x1E2C
        if (!ZeroFlag)
        {
            goto label_100D_1E2C_11EFC_34157;
        }
    label_100D_1E3D_11F0D_34165:
        CheckExternalEvents(cs1, 0x1E3D);
        // 100D:1E3D pop SI
        SI = Stack.Pop16();
        return unknown_100D_1E3E_11F0E(0x0000);
    label_100D_1E40_11F10_35760:
        CheckExternalEvents(cs1, 0x1E40);
        // 100D:1E40 pop SI
        SI = Stack.Pop16();
        // 100D:1E41 stc
        CarryFlag = true;
        // 100D:1E42 ret near
        return NearRet((ushort)0x0000);
    }
}
