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
    public virtual Action unknown_100D_45DE_146AE(int loadOffset)
    {
    entrydispatcher:
    label_100D_45DE_146AE_21235:
        CheckExternalEvents(cs1, 0x45DE);
        // 100D:45DE push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:45E2 call near 0xC08E
        NearCall(cs1, 0x45E5, unknown_100D_C08E_1C15E);
    label_100D_45E5_146B5_21238:
        CheckExternalEvents(cs1, 0x45E5);
        // 100D:45E5 call near 0xDBB2
        NearCall(cs1, 0x45E8, unknown_100D_DBB2_1DC82);
    label_100D_45E8_146B8_21240:
        CheckExternalEvents(cs1, 0x45E8);
        // 100D:45E8 call near 0xD075
        NearCall(cs1, 0x45EB, unknown_100D_D075_1D145);
    label_100D_45EB_146BB_21242:
        CheckExternalEvents(cs1, 0x45EB);
        // 100D:45EB mov DX,0x0055
        DX = (ushort)0x0055;
        // 100D:45EE mov BX,0x0022
        BX = (ushort)0x0022;
        // 100D:45F1 mov CX,0xF5FE
        CX = (ushort)0xF5FE;
        // 100D:45F4 cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:45F9 je short 0x4600
        if (ZeroFlag)
        {
            goto label_100D_4600_146D0_21251;
        }
    label_100D_45FB_146CB_21248:
        CheckExternalEvents(cs1, 0x45FB);
        // 100D:45FB add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:45FE mov CH,0x20
        CH = (byte)0x20;
    label_100D_4600_146D0_21251:
        CheckExternalEvents(cs1, 0x4600);
        // 100D:4600 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:4602 je short 0x462A
        if (ZeroFlag)
        {
            goto label_100D_462A_146FA_21442;
        }
    label_100D_4604_146D4_21253:
        CheckExternalEvents(cs1, 0x4604);
        // 100D:4604 call near 0x469B
        NearCall(cs1, 0x4607, unknown_100D_469B_1476B);
    label_100D_4607_146D7_21268:
        CheckExternalEvents(cs1, 0x4607);
        // 100D:4607 cmp DI,-16
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:460A jb short 0x4636
        if (CarryFlag)
        {
            goto label_100D_4636_14706_21305;
        }
    label_100D_460C_146DC_21271:
        CheckExternalEvents(cs1, 0x460C);
        // 100D:460C mov AX,0x00A4
        AX = (ushort)0x00A4;
        // 100D:460F call near 0xD194
        NearCall(cs1, 0x4612, unknown_100D_D194_1D264);
    label_100D_4612_146E2_21274:
        CheckExternalEvents(cs1, 0x4612);
        // 100D:4612 sub DI,-16
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:4615 cmp DI,8
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:4618 jae short 0x4641
        if (!CarryFlag)
        {
            goto label_100D_4641_14711_21278;
        }
    label_100D_461A_146EA_21296:
        CheckExternalEvents(cs1, 0x461A);
        // 100D:461A mov AL,0x20
        AL = (byte)0x20;
        // 100D:461C call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x4620, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:461C");
        }
    label_100D_4620_146F0_21299:
        CheckExternalEvents(cs1, 0x4620);
        // 100D:4620 mov AX,DI
        AX = DI;
        // 100D:4622 add AX,0x00DA
        AX = Alu16.Add(AX, (ushort)0x00DA);
        // 100D:4625 call near 0xD19B
        NearCall(cs1, 0x4628, unknown_100D_D19B_1D26B);
    label_100D_4628_146F8_21303:
        CheckExternalEvents(cs1, 0x4628);
        // 100D:4628 jmp short 0x4641
        goto label_100D_4641_14711_21278;
    label_100D_462A_146FA_21442:
        CheckExternalEvents(cs1, 0x462A);
        // 100D:462A call near 0x4658
        NearCall(cs1, 0x462D, unknown_100D_4658_14728);
    label_100D_462D_146FD_21444:
        CheckExternalEvents(cs1, 0x462D);
        // 100D:462D mov word ptr DS:[0xDBE4],CX
        UInt16[DS, (ushort)0xDBE4] = CX;
        // 100D:4631 call near 0xD04E
        NearCall(cs1, 0x4634, unknown_100D_D04E_1D11E);
    label_100D_4634_14704_21447:
        CheckExternalEvents(cs1, 0x4634);
        // 100D:4634 jmp short 0x4641
        goto label_100D_4641_14711_21278;
    label_100D_4636_14706_21305:
        CheckExternalEvents(cs1, 0x4636);
        // 100D:4636 push CX
        Stack.Push16(CX);
        // 100D:4637 call near 0x629D
        NearCall(cs1, 0x463A, unknown_100D_629D_1636D);
    label_100D_463A_1470A_21322:
        CheckExternalEvents(cs1, 0x463A);
        // 100D:463A call near 0xD05F
        NearCall(cs1, 0x463D, unknown_100D_D05F_1D12F);
    label_100D_463D_1470D_21324:
        CheckExternalEvents(cs1, 0x463D);
        // 100D:463D pop CX
        CX = Stack.Pop16();
        // 100D:463E call near 0x62A6
        NearCall(cs1, 0x4641, unknown_100D_62A6_16376);
    label_100D_4641_14711_21278:
        CheckExternalEvents(cs1, 0x4641);
        // 100D:4641 cmp word ptr DS:[0xD82C],0x00ED
        Alu16.Sub(UInt16[DS, (ushort)0xD82C], (ushort)0x00ED);
        // 100D:4647 ja short 0x4651
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_4651_14721_21286;
        }
    label_100D_4649_14719_21281:
        CheckExternalEvents(cs1, 0x4649);
        // 100D:4649 mov AL,0x20
        AL = (byte)0x20;
        // 100D:464B call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0x464F, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:464B");
        }
    label_100D_464F_1471F_21284:
        CheckExternalEvents(cs1, 0x464F);
        // 100D:464F jmp short 0x4641
        goto label_100D_4641_14711_21278;
    label_100D_4651_14721_21286:
        CheckExternalEvents(cs1, 0x4651);
        // 100D:4651 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_4651_14721 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_4651_14721 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_4651_14721 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_4651_14721);
        // 100D:4655 jmp near 0xDBEC
        if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_4658_14728(int loadOffset)
    {
    label_100D_4658_14728_20739:
        CheckExternalEvents(cs1, 0x4658);
        // 100D:4658 cmp word ptr DS:[0x473F],0
        Alu16.Sub(UInt16[DS, (ushort)0x473F], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:465D jne short 0x469A
        if (!ZeroFlag)
        {
            goto label_100D_469A_1476A_20765;
        }
    label_100D_465F_1472F_20742:
        CheckExternalEvents(cs1, 0x465F);
        // 100D:465F call near 0xE270
        NearCall(cs1, 0x4662, unknown_100D_E270_1E340);
    label_100D_4662_14732_20744:
        CheckExternalEvents(cs1, 0x4662);
        // 100D:4662 mov SI,0x0057
        SI = (ushort)0x0057;
        // 100D:4665 call near 0xCF70
        NearCall(cs1, 0x4668, unknown_100D_CF70_1D040);
    label_100D_4668_14738_20747:
        CheckExternalEvents(cs1, 0x4668);
        // 100D:4668 mov word ptr DS:[0x4741],ES
        UInt16[DS, (ushort)0x4741] = ES;
        // 100D:466C mov word ptr DS:[0x473F],SI
        UInt16[DS, (ushort)0x473F] = SI;
        // 100D:4670 mov word ptr DS:[0x4743],0x0055
        UInt16[DS, (ushort)0x4743] = (ushort)0x0055;
        // 100D:4676 mov CX,0xF561
        CX = (ushort)0xF561;
        // 100D:4679 mov AX,0x0022
        AX = (ushort)0x0022;
        // 100D:467C cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:4681 je short 0x4687
        if (ZeroFlag)
        {
            goto label_100D_4687_14757_20758;
        }
    label_100D_4683_14753_20755:
        CheckExternalEvents(cs1, 0x4683);
        // 100D:4683 add AL,4
        AL = Alu8.Add(AL, (byte)0x04);
        // 100D:4685 mov CH,0x20
        CH = (byte)0x20;
    label_100D_4687_14757_20758:
        CheckExternalEvents(cs1, 0x4687);
        // 100D:4687 mov word ptr DS:[0x4745],AX
        UInt16[DS, (ushort)0x4745] = AX;
        // 100D:468A mov word ptr DS:[0x4747],CX
        UInt16[DS, (ushort)0x4747] = CX;
        // 100D:468E mov SI,0x46B5
        SI = (ushort)0x46B5;
        // 100D:4691 mov BP,0x0018
        BP = (ushort)0x0018;
        // 100D:4694 call near 0xDA25
        NearCall(cs1, 0x4697, unknown_100D_DA25_1DAF5);
    label_100D_4697_14767_20763:
        CheckExternalEvents(cs1, 0x4697);
        // 100D:4697 call near 0xE283
        NearCall(cs1, 0x469A, unknown_100D_E283_1E353);
    label_100D_469A_1476A_20765:
        CheckExternalEvents(cs1, 0x469A);
        // 100D:469A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_469B_1476B(int loadOffset)
    {
    label_100D_469B_1476B_21255:
        CheckExternalEvents(cs1, 0x469B);
        // 100D:469B cmp word ptr DS:[0x473F],0
        Alu16.Sub(UInt16[DS, (ushort)0x473F], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:46A0 je short 0x46B4
        if (ZeroFlag)
        {
            goto label_100D_46B4_14784_21266;
        }
    label_100D_46A2_14772_21258:
        CheckExternalEvents(cs1, 0x46A2);
        // 100D:46A2 mov word ptr DS:[0x473F],0
        UInt16[DS, (ushort)0x473F] = (ushort)0x0000;
        // 100D:46A8 call near 0xE270
        NearCall(cs1, 0x46AB, unknown_100D_E270_1E340);
    label_100D_46AB_1477B_21261:
        CheckExternalEvents(cs1, 0x46AB);
        // 100D:46AB mov SI,0x46B5
        SI = (ushort)0x46B5;
        // 100D:46AE call near 0xDA5F
        NearCall(cs1, 0x46B1, unknown_100D_DA5F_1DB2F);
    label_100D_46B1_14781_21264:
        CheckExternalEvents(cs1, 0x46B1);
        // 100D:46B1 call near 0xE283
        NearCall(cs1, 0x46B4, unknown_100D_E283_1E353);
    label_100D_46B4_14784_21266:
        CheckExternalEvents(cs1, 0x46B4);
        // 100D:46B4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_46B5_14785(int loadOffset)
    {
    label_100D_46B5_14785_21094:
        CheckExternalEvents(cs1, 0x46B5);
        // 100D:46B5 les SI,word ptr DS:[0x473F]
        ushort lxsOffset_100D_46B5_14785 = (ushort)0x473F;
        ushort lxsValue_100D_46B5_14785 = UInt16[DS, lxsOffset_100D_46B5_14785];
        ushort lxsSegment_100D_46B5_14785 = UInt16[DS, (ushort)(lxsOffset_100D_46B5_14785 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_46B5_14785);
        ES = unchecked((ushort)lxsSegment_100D_46B5_14785);
        // 100D:46B9 mov AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        // 100D:46BC or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:46BE js short 0x4702
        if (SignFlag)
        {
            goto label_100D_4702_147D2_21128;
        }
    label_100D_46C0_14790_21099:
        CheckExternalEvents(cs1, 0x46C0);
        // 100D:46C0 inc word ptr DS:[0x473F]
        UInt16[DS, (ushort)0x473F] = Alu16.Inc(UInt16[DS, (ushort)0x473F]);
        // 100D:46C4 mov SI,0x14A4
        SI = (ushort)0x14A4;
        // 100D:46C7 call near 0xDB74
        NearCall(cs1, 0x46CA, unknown_100D_DB74_1DC44);
    label_100D_46CA_1479A_21103:
        CheckExternalEvents(cs1, 0x46CA);
        // 100D:46CA push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:46CE call near 0xC08E
        NearCall(cs1, 0x46D1, unknown_100D_C08E_1C15E);
    label_100D_46D1_147A1_21106:
        CheckExternalEvents(cs1, 0x46D1);
        // 100D:46D1 mov DX,word ptr DS:[0x4743]
        DX = UInt16[DS, (ushort)0x4743];
        // 100D:46D5 mov BX,word ptr DS:[0x4745]
        BX = UInt16[DS, (ushort)0x4745];
        // 100D:46D9 call near 0xD04E
        NearCall(cs1, 0x46DC, unknown_100D_D04E_1D11E);
    label_100D_46DC_147AC_21110:
        CheckExternalEvents(cs1, 0x46DC);
        // 100D:46DC mov CX,word ptr DS:[0x4747]
        CX = UInt16[DS, (ushort)0x4747];
        // 100D:46E0 mov word ptr DS:[0xDBE4],CX
        UInt16[DS, (ushort)0xDBE4] = CX;
        // 100D:46E4 call near 0xD075
        NearCall(cs1, 0x46E7, unknown_100D_D075_1D145);
    label_100D_46E7_147B7_21114:
        CheckExternalEvents(cs1, 0x46E7);
        // 100D:46E7 push AX
        Stack.Push16(AX);
        // 100D:46E8 call near 0xD12F
        NearCall(cs1, 0x46EB, unknown_100D_D12F_1D1FF);
    label_100D_46EB_147BB_21117:
        CheckExternalEvents(cs1, 0x46EB);
        // 100D:46EB call near 0xD05F
        NearCall(cs1, 0x46EE, unknown_100D_D05F_1D12F);
    label_100D_46EE_147BE_21119:
        CheckExternalEvents(cs1, 0x46EE);
        // 100D:46EE mov word ptr DS:[0x4743],DX
        UInt16[DS, (ushort)0x4743] = DX;
        // 100D:46F2 mov word ptr DS:[0x4745],BX
        UInt16[DS, (ushort)0x4745] = BX;
        // 100D:46F6 pop AX
        AX = Stack.Pop16();
        // 100D:46F7 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_46F7_147C7 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_46F7_147C7 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_46F7_147C7 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_46F7_147C7);
        // 100D:46FB call near 0xDB67
        NearCall(cs1, 0x46FE, unknown_100D_DB67_1DC37);
    label_100D_46FE_147CE_21125:
        CheckExternalEvents(cs1, 0x46FE);
        // 100D:46FE cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:4700 je short 0x46B5
        if (ZeroFlag)
        {
            goto label_100D_46B5_14785_21094;
        }
    label_100D_4702_147D2_21128:
        CheckExternalEvents(cs1, 0x4702);
        // 100D:4702 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4795_14865(int loadOffset)
    {
    label_100D_4795_14865_21635:
        CheckExternalEvents(cs1, 0x4795);
        // 100D:4795 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:479A js short 0x47CD
        if (SignFlag)
        {
            goto label_100D_47CD_1489D_26626;
        }
    label_100D_479C_1486C_21638:
        CheckExternalEvents(cs1, 0x479C);
        // 100D:479C cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:479E je short 0x47CE
        if (ZeroFlag)
        {
            goto label_100D_47CE_1489E_21641;
        }
    label_100D_47A0_14870_35153:
        CheckExternalEvents(cs1, 0x47A0);
        // 100D:47A0 call near 0x98AF
        NearCall(cs1, 0x47A3, unknown_100D_98AF_1997F);
    label_100D_47A3_14873_35157:
        CheckExternalEvents(cs1, 0x47A3);
        // 100D:47A3 mov byte ptr DS:[0xCEE8],0
        UInt8[DS, (ushort)0xCEE8] = (byte)0x00;
        // 100D:47A8 mov AL,0x50
        AL = (byte)0x50;
        // 100D:47AA call near 0x121F
        NearCall(cs1, 0x47AD, unknown_100D_121F_112EF);
    label_100D_47AD_1487D_35167:
        CheckExternalEvents(cs1, 0x47AD);
        // 100D:47AD mov byte ptr DS:[0x00E8],0
        UInt8[DS, (ushort)0x00E8] = (byte)0x00;
        // 100D:47B2 call near 0x1797
        NearCall(cs1, 0x47B5, unknown_100D_1797_11867);
    label_100D_47B5_14885_35170:
        CheckExternalEvents(cs1, 0x47B5);
        // 100D:47B5 mov AL,0x10
        AL = (byte)0x10;
        // 100D:47B7 mov BP,0x4913
        BP = (ushort)0x4913;
        // 100D:47BA call near 0xC108
        NearCall(cs1, 0x47BD, unknown_100D_C108_1C1D8);
    label_100D_47BD_1488D_35179:
        CheckExternalEvents(cs1, 0x47BD);
        // 100D:47BD mov byte ptr DS:[0x227D],1
        UInt8[DS, (ushort)0x227D] = (byte)0x01;
        // 100D:47C2 call near 0x491C
        NearCall(cs1, 0x47C5, unknown_100D_491C_149EC);
    label_100D_47C5_14895_35201:
        CheckExternalEvents(cs1, 0x47C5);
        // 100D:47C5 mov byte ptr DS:[0x227D],0
        UInt8[DS, (ushort)0x227D] = (byte)0x00;
        // 100D:47CA jmp near 0xAC14
        return unknown_100D_AC14_1ACE4(0x0000);
    label_100D_47CD_1489D_26626:
        CheckExternalEvents(cs1, 0x47CD);
        // 100D:47CD ret near
        return NearRet((ushort)0x0000);
    label_100D_47CE_1489E_21641:
        CheckExternalEvents(cs1, 0x47CE);
        // 100D:47CE call near 0xCE53
        NearCall(cs1, 0x47D1, unknown_100D_CE53_1CF23);
    label_100D_47D1_148A1_21648:
        CheckExternalEvents(cs1, 0x47D1);
        // 100D:47D1 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:47D3 xchg AL,byte ptr DS:[0x4732]
        ushort xchgOffset_100D_47D3_148A3 = (ushort)0x4732;
        byte temp_100D_47D3_148A3 = AL;
        AL = UInt8[DS, xchgOffset_100D_47D3_148A3];
        UInt8[DS, xchgOffset_100D_47D3_148A3] = unchecked((byte)temp_100D_47D3_148A3);
        // 100D:47D7 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:47D9 jae short 0x47CD
        if (!CarryFlag)
        {
            goto label_100D_47CD_1489D_26626;
        }
    label_100D_47DB_148AB_21653:
        CheckExternalEvents(cs1, 0x47DB);
        // 100D:47DB call near 0x181E
        NearCall(cs1, 0x47DE, unknown_100D_181E_118EE);
    label_100D_47DE_148AE_21655:
        CheckExternalEvents(cs1, 0x47DE);
        // 100D:47DE mov byte ptr DS:[0x4731],0xFF
        UInt8[DS, (ushort)0x4731] = (byte)0xFF;
        // 100D:47E3 call near 0xC07C
        NearCall(cs1, 0x47E6, unknown_100D_C07C_1C14C);
    label_100D_47E6_148B6_21658:
        CheckExternalEvents(cs1, 0x47E6);
        // 100D:47E6 call near 0x37B2
        NearCall(cs1, 0x47E9, unknown_100D_37B2_13882);
    label_100D_47E9_148B9_21675:
        CheckExternalEvents(cs1, 0x47E9);
        // 100D:47E9 call near 0xC412
        NearCall(cs1, 0x47EC, unknown_100D_C412_1C4E2);
    label_100D_47EC_148BC_21677:
        CheckExternalEvents(cs1, 0x47EC);
        // 100D:47EC call near 0x5BA0
        NearCall(cs1, 0x47EF, unknown_100D_5BA0_15C70);
    label_100D_47EF_148BF_21679:
        CheckExternalEvents(cs1, 0x47EF);
        // 100D:47EF mov byte ptr DS:[0x4731],0
        UInt8[DS, (ushort)0x4731] = (byte)0x00;
        // 100D:47F4 mov AL,6
        AL = (byte)0x06;
        // 100D:47F6 call near 0xAB15
        NearCall(cs1, 0x47F9, unknown_100D_AB15_1ABE5);
    label_100D_47F9_148C9_21706:
        CheckExternalEvents(cs1, 0x47F9);
        // 100D:47F9 mov CL,1
        CL = (byte)0x01;
    label_100D_47FB_148CB_21708:
        CheckExternalEvents(cs1, 0x47FB);
        // 100D:47FB mov BP,0x4821
        BP = (ushort)0x4821;
        // 100D:47FE mov AX,0x0014
        AX = (ushort)0x0014;
        // 100D:4801 call near 0xE353
        NearCall(cs1, 0x4804, unknown_100D_E353_1E423);
    label_100D_4804_148D4_21774:
        CheckExternalEvents(cs1, 0x4804);
        // 100D:4804 add byte ptr DS:[0x4731],CL
        UInt8[DS, (ushort)0x4731] = Alu8.Add(UInt8[DS, (ushort)0x4731], CL);
        // 100D:4808 mov AL,byte ptr DS:[0x4731]
        AL = UInt8[DS, (ushort)0x4731];
        // 100D:480B cmp AL,0x1A
        Alu8.Sub(AL, (byte)0x1A);
        // 100D:480D jne short 0x4816
        if (!ZeroFlag)
        {
            goto label_100D_4816_148E6_21779;
        }
    label_100D_480F_148DF_21811:
        CheckExternalEvents(cs1, 0x480F);
        // 100D:480F or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:4811 js short 0x4816
        if (SignFlag)
        {
            goto label_100D_4816_148E6_21779;
        }
    label_100D_4813_148E3_21814:
        CheckExternalEvents(cs1, 0x4813);
        // 100D:4813 call near 0xAC30
        NearCall(cs1, 0x4816, unknown_100D_AC30_1AD00);
    label_100D_4816_148E6_21779:
        CheckExternalEvents(cs1, 0x4816);
        // 100D:4816 call near 0xAE04
        NearCall(cs1, 0x4819, unknown_100D_AE04_1AED4);
    label_100D_4819_148E9_21781:
        CheckExternalEvents(cs1, 0x4819);
        // 100D:4819 cmp byte ptr DS:[0x4731],0x21
        Alu8.Sub(UInt8[DS, (ushort)0x4731], (byte)0x21);
        // 100D:481E jb short 0x47FB
        if (CarryFlag)
        {
            goto label_100D_47FB_148CB_21708;
        }
    label_100D_4820_148F0_21816:
        CheckExternalEvents(cs1, 0x4820);
        // 100D:4820 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4821_148F1(int loadOffset)
    {
    label_100D_4821_148F1_21715:
        CheckExternalEvents(cs1, 0x4821);
        // 100D:4821 push CX
        Stack.Push16(CX);
        // 100D:4822 call near 0xC43E
        NearCall(cs1, 0x4825, unknown_100D_C43E_1C50E);
    label_100D_4825_148F5_21718:
        CheckExternalEvents(cs1, 0x4825);
        // 100D:4825 mov AX,0x002A
        AX = (ushort)0x002A;
        // 100D:4828 call near 0xC13E
        NearCall(cs1, 0x482B, unknown_100D_C13E_1C20E);
    label_100D_482B_148FB_21721:
        CheckExternalEvents(cs1, 0x482B);
        // 100D:482B call near 0xC0F4
        NearCall(cs1, 0x482E, unknown_100D_C0F4_1C1C4);
    label_100D_482E_148FE_21723:
        CheckExternalEvents(cs1, 0x482E);
        // 100D:482E call near 0xC07C
        NearCall(cs1, 0x4831, unknown_100D_C07C_1C14C);
    label_100D_4831_14901_21725:
        CheckExternalEvents(cs1, 0x4831);
        // 100D:4831 call near 0x3A95
        NearCall(cs1, 0x4834, unknown_100D_3A95_13B65);
    label_100D_4834_14904_21727:
        CheckExternalEvents(cs1, 0x4834);
        // 100D:4834 mov AL,byte ptr DS:[0x4731]
        AL = UInt8[DS, (ushort)0x4731];
        // 100D:4837 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:4839 jne short 0x4840
        if (!ZeroFlag)
        {
            goto label_100D_4840_14910_21731;
        }
    label_100D_483B_1490B_21785:
        CheckExternalEvents(cs1, 0x483B);
        // 100D:483B push AX
        Stack.Push16(AX);
        // 100D:483C call near 0xAC30
        NearCall(cs1, 0x483F, unknown_100D_AC30_1AD00);
    label_100D_483F_1490F_21788:
        CheckExternalEvents(cs1, 0x483F);
        // 100D:483F pop AX
        AX = Stack.Pop16();
    label_100D_4840_14910_21731:
        CheckExternalEvents(cs1, 0x4840);
        // 100D:4840 sub AL,0x0E
        AL = Alu8.Sub(AL, (byte)0x0E);
        // 100D:4842 jbe short 0x485D
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_485D_1492D_21734;
        }
    label_100D_4844_14914_21792:
        CheckExternalEvents(cs1, 0x4844);
        // 100D:4844 pop CX
        CX = Stack.Pop16();
        // 100D:4845 push CX
        Stack.Push16(CX);
        // 100D:4846 or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:4848 mov CX,5
        CX = (ushort)0x0005;
        // 100D:484B jns short 0x484F
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:484B");
        }
    label_100D_484F_1491F_21798:
        CheckExternalEvents(cs1, 0x484F);
        // 100D:484F mov AH,AL
        AH = AL;
    label_100D_4851_14921_21800:
        CheckExternalEvents(cs1, 0x4851);
        // 100D:4851 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:4853 dec AH
        AH = Alu8.Dec(AH);
        // 100D:4855 jne short 0x4851
        if (!ZeroFlag)
        {
            goto label_100D_4851_14921_21800;
        }
    label_100D_4857_14927_21803:
        CheckExternalEvents(cs1, 0x4857);
        // 100D:4857 mul AL
        ushort result_100D_4857_14927 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AL)));
        AH = unchecked((byte)(result_100D_4857_14927 >> 8));
        AL = unchecked((byte)result_100D_4857_14927);
        // 100D:4859 sar AX,1
        AX = Alu16.Sar(AX, 1);
        // 100D:485B sub BX,AX
        BX = Alu16.Sub(BX, AX);
    label_100D_485D_1492D_21734:
        CheckExternalEvents(cs1, 0x485D);
        // 100D:485D call near 0x3AA9
        NearCall(cs1, 0x4860, unknown_100D_3AA9_13B79);
    label_100D_4860_14930_21736:
        CheckExternalEvents(cs1, 0x4860);
        // 100D:4860 call near 0x3A95
        NearCall(cs1, 0x4863, unknown_100D_3A95_13B65);
    label_100D_4863_14933_21738:
        CheckExternalEvents(cs1, 0x4863);
        // 100D:4863 mov CL,byte ptr DS:[0x46FF]
        CL = UInt8[DS, (ushort)0x46FF];
        // 100D:4867 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:4869 jcxz short 0x487B
        if (CX == (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4869");
        }
    label_100D_486B_1493B_21742:
        CheckExternalEvents(cs1, 0x486B);
        // 100D:486B mov AL,byte ptr DS:[0x4731]
        AL = UInt8[DS, (ushort)0x4731];
        // 100D:486E push AX
        Stack.Push16(AX);
        // 100D:486F mov byte ptr DS:[0x4731],0
        UInt8[DS, (ushort)0x4731] = (byte)0x00;
        // 100D:4874 call near 0x3A73
        NearCall(cs1, 0x4877, unknown_100D_3A73_13B43);
    label_100D_4877_14947_21748:
        CheckExternalEvents(cs1, 0x4877);
        // 100D:4877 pop AX
        AX = Stack.Pop16();
        // 100D:4878 mov byte ptr DS:[0x4731],AL
        UInt8[DS, (ushort)0x4731] = AL;
        // 100D:487B call near 0xC4DD
        NearCall(cs1, 0x487E, unknown_100D_C4DD_1C5AD);
    label_100D_487E_1494E_21752:
        CheckExternalEvents(cs1, 0x487E);
        // 100D:487E cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:4883 je short 0x4888
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4883");
        }
    label_100D_4888_14958_21755:
        CheckExternalEvents(cs1, 0x4888);
        // 100D:4888 pop CX
        CX = Stack.Pop16();
        // 100D:4889 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_488A_1495A(int loadOffset)
    {
    label_100D_488A_1495A_22791:
        CheckExternalEvents(cs1, 0x488A);
        // 100D:488A mov AX,6
        AX = (ushort)0x0006;
        // 100D:488D mov SI,word ptr DS:[0x114E]
        SI = UInt16[DS, (ushort)0x114E];
        // 100D:4891 call near 0x5E4F
        NearCall(cs1, 0x4894, unknown_100D_5E4F_15F1F);
    label_100D_4894_14964_22795:
        CheckExternalEvents(cs1, 0x4894);
        // 100D:4894 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:4896 jae short 0x48E5
        if (!CarryFlag)
        {
            goto label_100D_48E5_149B5_42043;
        }
    label_100D_4898_14968_22798:
        CheckExternalEvents(cs1, 0x4898);
        // 100D:4898 mov BX,AX
        BX = AX;
        // 100D:489A call near 0xDBB2
        NearCall(cs1, 0x489D, unknown_100D_DBB2_1DC82);
    label_100D_489D_1496D_22801:
        CheckExternalEvents(cs1, 0x489D);
        // 100D:489D mov byte ptr DS:[0x4728],0x80
        UInt8[DS, (ushort)0x4728] = (byte)0x80;
    label_100D_48A2_14972_22803:
        CheckExternalEvents(cs1, 0x48A2);
        // 100D:48A2 push BX
        Stack.Push16(BX);
        // 100D:48A3 call near 0xCA60
        NearCall(cs1, 0x48A6, unknown_100D_CA60_1CB30);
    label_100D_48A6_14976_22805:
        CheckExternalEvents(cs1, 0x48A6);
        // 100D:48A6 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:48A8 call near 0x4EC6
        NearCall(cs1, 0x48AB, unknown_100D_4EC6_14F96);
    label_100D_48AB_1497B_22808:
        CheckExternalEvents(cs1, 0x48AB);
        // 100D:48AB pop BX
        BX = Stack.Pop16();
        // 100D:48AC cmp word ptr DS:[0xDC00],2
        Alu16.Sub(UInt16[DS, (ushort)0xDC00], (ushort)0x0002);
        // 100D:48B2 jne short 0x48A2
        if (!ZeroFlag)
        {
            goto label_100D_48A2_14972_22803;
        }
    label_100D_48B4_14984_22813:
        CheckExternalEvents(cs1, 0x48B4);
        // 100D:48B4 mov AX,0x003C
        AX = (ushort)0x003C;
        // 100D:48B7 cmp BX,6
        Alu16.Sub(BX, (ushort)0x0006);
        // 100D:48BB je short 0x48C0
        if (ZeroFlag)
        {
            goto label_100D_48C0_14990_22817;
        }
    label_100D_48BD_1498D_30217:
        CheckExternalEvents(cs1, 0x48BD);
        // 100D:48BD mov AX,0x0016
        AX = (ushort)0x0016;
    label_100D_48C0_14990_22817:
        CheckExternalEvents(cs1, 0x48C0);
        // 100D:48C0 cmp AX,word ptr DS:[0xDBEA]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBEA]);
        // 100D:48C4 jne short 0x48A2
        if (!ZeroFlag)
        {
            goto label_100D_48A2_14972_22803;
        }
    label_100D_48C6_14996_22821:
        CheckExternalEvents(cs1, 0x48C6);
        // 100D:48C6 call near 0xCE4B
        NearCall(cs1, 0x48C9, unknown_100D_CE4B_1CF1B);
    label_100D_48C9_14999_22827:
        CheckExternalEvents(cs1, 0x48C9);
        // 100D:48C9 call near 0xCA60
        NearCall(cs1, 0x48CC, unknown_100D_CA60_1CB30);
    label_100D_48CC_1499C_22829:
        CheckExternalEvents(cs1, 0x48CC);
        // 100D:48CC call near 0xCC85
        NearCall(cs1, 0x48CF, unknown_100D_CC85_1CD55);
    label_100D_48CF_1499F_22831:
        CheckExternalEvents(cs1, 0x48CF);
        // 100D:48CF je short 0x48C9
        if (ZeroFlag)
        {
            goto label_100D_48C9_14999_22827;
        }
    label_100D_48D1_149A1_22833:
        CheckExternalEvents(cs1, 0x48D1);
        // 100D:48D1 dec byte ptr DS:[0x46E0]
        UInt8[DS, (ushort)0x46E0] = Alu8.Dec(UInt8[DS, (ushort)0x46E0]);
        // 100D:48D5 mov byte ptr DS:[0x4732],0
        UInt8[DS, (ushort)0x4732] = (byte)0x00;
        // 100D:48DA jmp near 0x2D74
        return unknown_100D_2D74_12E44(0x0000);
    label_100D_48DD_149AD_42046:
        CheckExternalEvents(cs1, 0x48DD);
        // 100D:48DD mov BP,0xC4CD
        BP = (ushort)0xC4CD;
        // 100D:48E0 call near 0xC8FB
        NearCall(cs1, 0x48E3, unknown_100D_C8FB_1C9CB);
    label_100D_48E3_149B3_42057:
        CheckExternalEvents(cs1, 0x48E3);
        // 100D:48E3 jmp short 0x48D1
        goto label_100D_48D1_149A1_22833;
    label_100D_48E5_149B5_42043:
        CheckExternalEvents(cs1, 0x48E5);
        // 100D:48E5 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:48E7 je short 0x48DD
        if (ZeroFlag)
        {
            goto label_100D_48DD_149AD_42046;
        }
    label_100D_48E9_149B9_42048:
        CheckExternalEvents(cs1, 0x48E9);
        VerifySpeculativeEntryOrFail(cs1, 0x48E9, [(byte)0xC6, (byte)0x06, (byte)0x31, (byte)0x47, (byte)0xFF]);
        // 100D:48E9 mov byte ptr DS:[0x4731],0xFF
        UInt8[DS, (ushort)0x4731] = (byte)0xFF;
        VerifySpeculativeEntryOrFail(cs1, 0x48EE, [(byte)0xE8, (byte)0x8B, (byte)0x77]);
        // 100D:48EE call near 0xC07C
        NearCall(cs1, 0x48F1, unknown_100D_C07C_1C14C);
        throw FailAsUntested("Call at 100D:48EE returned to 100D:48F1, but no continuation was observed during discovery.");
    }

    public virtual Action unknown_100D_4913_149E3(int loadOffset)
    {
    label_100D_4913_149E3_35174:
        CheckExternalEvents(cs1, 0x4913);
        // 100D:4913 mov AX,0x000E
        AX = (ushort)0x000E;
        // 100D:4916 call near 0xCA1B
        NearCall(cs1, 0x4919, unknown_100D_CA1B_1CAEB);
    label_100D_4919_149E9_35177:
        CheckExternalEvents(cs1, 0x4919);
        // 100D:4919 jmp near 0x388D
        return unknown_100D_388D_1395D(0x0000);
    }

    public virtual Action unknown_100D_491C_149EC(int loadOffset)
    {
    label_100D_491C_149EC_35182:
        CheckExternalEvents(cs1, 0x491C);
        // 100D:491C call near 0xC08E
        NearCall(cs1, 0x491F, unknown_100D_C08E_1C15E);
    label_100D_491F_149EF_35184:
        CheckExternalEvents(cs1, 0x491F);
        // 100D:491F call near 0xC0F4
        NearCall(cs1, 0x4922, unknown_100D_C0F4_1C1C4);
    label_100D_4922_149F2_35186:
        CheckExternalEvents(cs1, 0x4922);
        // 100D:4922 mov AL,8
        AL = (byte)0x08;
        // 100D:4924 call near 0xAB15
        NearCall(cs1, 0x4927, unknown_100D_AB15_1ABE5);
    label_100D_4927_149F7_35189:
        CheckExternalEvents(cs1, 0x4927);
        // 100D:4927 call near 0xAE04
        NearCall(cs1, 0x492A, unknown_100D_AE04_1AED4);
    label_100D_492A_149FA_35191:
        CheckExternalEvents(cs1, 0x492A);
        // 100D:492A call near 0xC9E8
        NearCall(cs1, 0x492D, unknown_100D_C9E8_1CAB8);
    label_100D_492D_149FD_35193:
        CheckExternalEvents(cs1, 0x492D);
        // 100D:492D je short 0x4934
        if (ZeroFlag)
        {
            goto label_100D_4934_14A04_35199;
        }
    label_100D_492F_149FF_35195:
        CheckExternalEvents(cs1, 0x492F);
        // 100D:492F call near 0x4937
        NearCall(cs1, 0x4932, unknown_100D_4937_14A07);
    label_100D_4932_14A02_35197:
        CheckExternalEvents(cs1, 0x4932);
        // 100D:4932 je short 0x492A
        if (ZeroFlag)
        {
            goto label_100D_492A_149FA_35191;
        }
    label_100D_4934_14A04_35199:
        CheckExternalEvents(cs1, 0x4934);
        // 100D:4934 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_4937_14A07(int loadOffset)
    {
    label_100D_4937_14A07_11428:
        CheckExternalEvents(cs1, 0x4937);
        // 100D:4937 mov AX,word ptr DS:[0xDBE8]
        AX = UInt16[DS, (ushort)0xDBE8];
        // 100D:493A cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:493C jne short 0x4941
        if (!ZeroFlag)
        {
            goto label_100D_4941_14A11_11432;
        }
    label_100D_493E_14A0E_11443:
        CheckExternalEvents(cs1, 0x493E);
        // 100D:493E call near 0xAC30
        NearCall(cs1, 0x4941, unknown_100D_AC30_1AD00);
    label_100D_4941_14A11_11432:
        CheckExternalEvents(cs1, 0x4941);
        // 100D:4941 jmp near 0xCC85
        return unknown_100D_CC85_1CD55(0x0000);
    }

    public virtual Action unknown_100D_4944_14A14(int loadOffset)
    {
    label_100D_4944_14A14_21485:
        CheckExternalEvents(cs1, 0x4944);
        // 100D:4944 call near 0x50BE
        NearCall(cs1, 0x4947, unknown_100D_50BE_1518E);
    label_100D_4947_14A17_21490:
        CheckExternalEvents(cs1, 0x4947);
        // 100D:4947 cmp DI,-16
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:494A jb short 0x4965
        if (CarryFlag)
        {
            return unknown_100D_4965_14A35(0x0000);
        }
    label_100D_494C_14A1C_27019:
        CheckExternalEvents(cs1, 0x494C);
        // 100D:494C dec byte ptr DS:[0x11CB]
        UInt8[DS, (ushort)0x11CB] = Alu8.Dec(UInt8[DS, (ushort)0x11CB]);
        // 100D:4950 call near 0xB5F9
        NearCall(cs1, 0x4953, unknown_100D_B5F9_1B6C9);
    label_100D_4953_14A23_27051:
        CheckExternalEvents(cs1, 0x4953);
        // 100D:4953 mov CX,BX
        CX = BX;
        // 100D:4955 mov DI,DX
        DI = DX;
        // 100D:4957 call near 0x407E
        NearCall(cs1, 0x495A, unknown_100D_407E_1414E);
    label_100D_495A_14A2A_27055:
        CheckExternalEvents(cs1, 0x495A);
        // 100D:495A call near 0x5133
        NearCall(cs1, 0x495D, unknown_100D_5133_15203);
    label_100D_495D_14A2D_27057:
        CheckExternalEvents(cs1, 0x495D);
        // 100D:495D mov DI,word ptr DS:[0x1150]
        DI = UInt16[DS, (ushort)0x1150];
        // 100D:4961 mov CL,1
        CL = (byte)0x01;
        // 100D:4963 jmp short 0x496A
        return unknown_100D_496A_14A3A(0x0000);
    }

    public virtual Action unknown_100D_4965_14A35(int loadOffset)
    {
    label_100D_4965_14A35_21493:
        CheckExternalEvents(cs1, 0x4965);
        // 100D:4965 call near 0x5124
        NearCall(cs1, 0x4968, unknown_100D_5124_151F4);
    label_100D_4968_14A38_21505:
        CheckExternalEvents(cs1, 0x4968);
        // 100D:4968 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        return unknown_100D_496A_14A3A(0x0000);
    }

    public virtual Action unknown_100D_4988_14A58(int loadOffset)
    {
    label_100D_4988_14A58_21954:
        CheckExternalEvents(cs1, 0x4988);
        // 100D:4988 mov word ptr DS:[0x46FC],0
        UInt16[DS, (ushort)0x46FC] = (ushort)0x0000;
        // 100D:498E call near 0x5B5D
        NearCall(cs1, 0x4991, unknown_100D_5B5D_15C2D);
    label_100D_4991_14A61_21962:
        CheckExternalEvents(cs1, 0x4991);
        // 100D:4991 mov SI,0x148A
        SI = (ushort)0x148A;
        // 100D:4994 mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:4997 call near 0x5B99
        NearCall(cs1, 0x499A, unknown_100D_5B99_15C69);
    label_100D_499A_14A6A_21966:
        CheckExternalEvents(cs1, 0x499A);
        // 100D:499A mov word ptr DS:[0x46ED],0x49A0
        UInt16[DS, (ushort)0x46ED] = (ushort)0x49A0;
        // 100D:49A0 call near 0xC085
        NearCall(cs1, 0x49A3, unknown_100D_C085_1C155);
    label_100D_49A3_14A73_21973:
        CheckExternalEvents(cs1, 0x49A3);
        // 100D:49A3 call near 0x5B93
        NearCall(cs1, 0x49A6, unknown_100D_5B93_15C63);
    label_100D_49A6_14A76_21975:
        CheckExternalEvents(cs1, 0x49A6);
        // 100D:49A6 mov byte ptr DS:[0x46EB],1
        UInt8[DS, (ushort)0x46EB] = (byte)0x01;
        // 100D:49AB call near 0xB6C3
        NearCall(cs1, 0x49AE, unknown_100D_B6C3_1B793);
    label_100D_49AE_14A7E_21978:
        CheckExternalEvents(cs1, 0x49AE);
        // 100D:49AE call near 0x5B69
        NearCall(cs1, 0x49B1, unknown_100D_5B69_15C39);
    label_100D_49B1_14A81_21980:
        CheckExternalEvents(cs1, 0x49B1);
        // 100D:49B1 call near 0xC137
        NearCall(cs1, 0x49B4, unknown_100D_C137_1C207);
    label_100D_49B4_14A84_21982:
        CheckExternalEvents(cs1, 0x49B4);
        // 100D:49B4 call near 0x5DCE
        NearCall(cs1, 0x49B7, unknown_100D_5DCE_15E9E);
    label_100D_49B7_14A87_21984:
        CheckExternalEvents(cs1, 0x49B7);
        // 100D:49B7 mov SI,word ptr DS:[0x11C5]
        SI = UInt16[DS, (ushort)0x11C5];
        // 100D:49BB or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:49BD je short 0x49CC
        if (ZeroFlag)
        {
            goto label_100D_49CC_14A9C_21997;
        }
    label_100D_49BF_14A8F_21988:
        CheckExternalEvents(cs1, 0x49BF);
        // 100D:49BF call near 0x62C9
        NearCall(cs1, 0x49C2, unknown_100D_62C9_16399);
    label_100D_49C2_14A92_21990:
        CheckExternalEvents(cs1, 0x49C2);
        // 100D:49C2 jb short 0x49CC
        if (CarryFlag)
        {
            goto label_100D_49CC_14A9C_21997;
        }
    label_100D_49C4_14A94_21992:
        CheckExternalEvents(cs1, 0x49C4);
        // 100D:49C4 dec BX
        BX = Alu16.Dec(BX);
        // 100D:49C5 dec DX
        DX = Alu16.Dec(DX);
        // 100D:49C6 mov AX,0x002E
        AX = (ushort)0x002E;
        // 100D:49C9 call near 0xC22F
        NearCall(cs1, 0x49CC, unknown_100D_C22F_1C2FF);
    label_100D_49CC_14A9C_21997:
        CheckExternalEvents(cs1, 0x49CC);
        // 100D:49CC mov byte ptr DS:[0x46EB],0
        UInt8[DS, (ushort)0x46EB] = (byte)0x00;
        // 100D:49D1 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_49D4_14AA4(int loadOffset)
    {
    label_100D_49D4_14AA4_40953:
        CheckExternalEvents(cs1, 0x49D4);
        // 100D:49D4 call near 0x4988
        NearCall(cs1, 0x49D7, unknown_100D_4988_14A58);
    label_100D_49D7_14AA7_40967:
        CheckExternalEvents(cs1, 0x49D7);
        // 100D:49D7 jmp short 0x49E3
    label_100D_49E3_14AB3_40968:
        CheckExternalEvents(cs1, 0x49E3);
        // 100D:49E3 jmp short 0x4A5A
        return unknown_100D_4A5A_14B2A(0x0000);
    }

    public virtual Action unknown_100D_49EA_14ABA(int loadOffset)
    {
    label_100D_49EA_14ABA_20677:
        CheckExternalEvents(cs1, 0x49EA);
        // 100D:49EA mov byte ptr DS:[0x4728],0
        UInt8[DS, (ushort)0x4728] = (byte)0x00;
        // 100D:49EF push CS
        Stack.Push16(CS);
        // 100D:49F0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:49F1 mov DI,0xE40C
        DI = (ushort)0xE40C;
        // 100D:49F4 mov AX,0x0800
        AX = (ushort)0x0800;
    label_100D_49F7_14AC7_20683:
        CheckExternalEvents(cs1, 0x49F7);
        // 100D:49F7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:49F8 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:49F9 cmp DI,0xE85C
        Alu16.Sub(DI, (ushort)0xE85C);
        // 100D:49FD jb short 0x49F7
        if (CarryFlag)
        {
            goto label_100D_49F7_14AC7_20683;
        }
    label_100D_49FF_14ACF_20688:
        CheckExternalEvents(cs1, 0x49FF);
        // 100D:49FF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4A00_14AD0(int loadOffset)
    {
    label_100D_4A00_14AD0_22173:
        CheckExternalEvents(cs1, 0x4A00);
        // 100D:4A00 push CS
        Stack.Push16(CS);
        // 100D:4A01 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4A02 mov DI,word ptr DS:[0x149A]
        DI = UInt16[DS, (ushort)0x149A];
        // 100D:4A06 mov AX,DX
        AX = DX;
        // 100D:4A08 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:4A09 mov AX,BX
        AX = BX;
        // 100D:4A0B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:4A0C cmp DI,0xE85C
        Alu16.Sub(DI, (ushort)0xE85C);
        // 100D:4A10 jb short 0x4A15
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4A10");
        }
    label_100D_4A15_14AE5_22183:
        CheckExternalEvents(cs1, 0x4A15);
        // 100D:4A15 mov word ptr DS:[0x149A],DI
        UInt16[DS, (ushort)0x149A] = DI;
        // 100D:4A19 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4A1A_14AEA(int loadOffset)
    {
    label_100D_4A1A_14AEA_22148:
        CheckExternalEvents(cs1, 0x4A1A);
        // 100D:4A1A cmp byte ptr DS:[0x4728],0
        Alu8.Sub(UInt8[DS, (ushort)0x4728], (byte)0x00);
        // 100D:4A1F js short 0x4A59
        if (SignFlag)
        {
            goto label_100D_4A59_14B29_22167;
        }
    label_100D_4A21_14AF1_22151:
        CheckExternalEvents(cs1, 0x4A21);
        // 100D:4A21 mov SI,0x148A
        SI = (ushort)0x148A;
        // 100D:4A24 call near 0xDB74
        NearCall(cs1, 0x4A27, unknown_100D_DB74_1DC44);
    label_100D_4A27_14AF7_22154:
        CheckExternalEvents(cs1, 0x4A27);
        // 100D:4A27 mov SI,word ptr DS:[0x149A]
        SI = UInt16[DS, (ushort)0x149A];
        // 100D:4A2B cmp SI,0xE40C
        Alu16.Sub(SI, (ushort)0xE40C);
        // 100D:4A2F jne short 0x4A34
        if (!ZeroFlag)
        {
            goto label_100D_4A34_14B04_22160;
        }
    label_100D_4A31_14B01_22158:
        CheckExternalEvents(cs1, 0x4A31);
        // 100D:4A31 mov SI,0xE85C
        SI = (ushort)0xE85C;
    label_100D_4A34_14B04_22160:
        CheckExternalEvents(cs1, 0x4A34);
        // 100D:4A34 sub SI,4
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:4A37 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4A39 mov DX,AX
        DX = AX;
        // 100D:4A3B lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4A3D mov BX,AX
        BX = AX;
        // 100D:4A3F dec AH
        AH = Alu8.Dec(AH);
        // 100D:4A41 jns short 0x4A59
        if (!SignFlag)
        {
            goto label_100D_4A59_14B29_22167;
        }
    label_100D_4A43_14B13_22356:
        CheckExternalEvents(cs1, 0x4A43);
        // 100D:4A43 call near 0x62D6
        NearCall(cs1, 0x4A46, unknown_100D_62D6_163A6);
    label_100D_4A46_14B16_22358:
        CheckExternalEvents(cs1, 0x4A46);
        // 100D:4A46 jb short 0x4A59
        if (CarryFlag)
        {
            goto label_100D_4A59_14B29_22167;
        }
    label_100D_4A48_14B18_22360:
        CheckExternalEvents(cs1, 0x4A48);
        // 100D:4A48 dec BX
        BX = Alu16.Dec(BX);
        // 100D:4A49 dec DX
        DX = Alu16.Dec(DX);
        // 100D:4A4A call near 0xC137
        NearCall(cs1, 0x4A4D, unknown_100D_C137_1C207);
    label_100D_4A4D_14B1D_22364:
        CheckExternalEvents(cs1, 0x4A4D);
        // 100D:4A4D mov AX,0x002F
        AX = (ushort)0x002F;
        // 100D:4A50 call near 0xC085
        NearCall(cs1, 0x4A53, unknown_100D_C085_1C155);
    label_100D_4A53_14B23_22367:
        CheckExternalEvents(cs1, 0x4A53);
        // 100D:4A53 call near 0xC22F
        NearCall(cs1, 0x4A56, unknown_100D_C22F_1C2FF);
    label_100D_4A56_14B26_22369:
        CheckExternalEvents(cs1, 0x4A56);
        // 100D:4A56 call near 0xC07C
        NearCall(cs1, 0x4A59, unknown_100D_C07C_1C14C);
    label_100D_4A59_14B29_22167:
        CheckExternalEvents(cs1, 0x4A59);
        // 100D:4A59 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4A5A_14B2A(int loadOffset)
    {
    label_100D_4A5A_14B2A_22002:
        CheckExternalEvents(cs1, 0x4A5A);
        // 100D:4A5A call near 0xC137
        NearCall(cs1, 0x4A5D, unknown_100D_C137_1C207);
    label_100D_4A5D_14B2D_22004:
        CheckExternalEvents(cs1, 0x4A5D);
        // 100D:4A5D push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:4A61 call near 0xC085
        NearCall(cs1, 0x4A64, unknown_100D_C085_1C155);
    label_100D_4A64_14B34_22007:
        CheckExternalEvents(cs1, 0x4A64);
        // 100D:4A64 mov SI,word ptr DS:[0x149A]
        SI = UInt16[DS, (ushort)0x149A];
    label_100D_4A68_14B38_22009:
        CheckExternalEvents(cs1, 0x4A68);
        // 100D:4A68 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4A6A mov DX,AX
        DX = AX;
        // 100D:4A6C lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4A6E mov BX,AX
        BX = AX;
        // 100D:4A70 dec AH
        AH = Alu8.Dec(AH);
        // 100D:4A72 jns short 0x4A99
        if (!SignFlag)
        {
            goto label_100D_4A99_14B69_22015;
        }
    label_100D_4A74_14B44_27244:
        CheckExternalEvents(cs1, 0x4A74);
        // 100D:4A74 push SI
        Stack.Push16(SI);
        // 100D:4A75 call near 0x62D6
        NearCall(cs1, 0x4A78, unknown_100D_62D6_163A6);
    label_100D_4A78_14B48_27247:
        CheckExternalEvents(cs1, 0x4A78);
        // 100D:4A78 jb short 0x4A98
        if (CarryFlag)
        {
            goto label_100D_4A98_14B68_27266;
        }
    label_100D_4A7A_14B4A_27249:
        CheckExternalEvents(cs1, 0x4A7A);
        // 100D:4A7A dec BX
        BX = Alu16.Dec(BX);
        // 100D:4A7B dec DX
        DX = Alu16.Dec(DX);
        // 100D:4A7C cmp DX,0x00CC
        Alu16.Sub(DX, (ushort)0x00CC);
        // 100D:4A80 jl short 0x4A98
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_4A98_14B68_27266;
        }
    label_100D_4A82_14B52_27254:
        CheckExternalEvents(cs1, 0x4A82);
        // 100D:4A82 cmp BX,4
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:4A85 jl short 0x4A98
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_4A98_14B68_27266;
        }
    label_100D_4A87_14B57_27257:
        CheckExternalEvents(cs1, 0x4A87);
        // 100D:4A87 cmp DX,0x013A
        Alu16.Sub(DX, (ushort)0x013A);
        // 100D:4A8B jge short 0x4A98
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_4A98_14B68_27266;
        }
    label_100D_4A8D_14B5D_27260:
        CheckExternalEvents(cs1, 0x4A8D);
        // 100D:4A8D cmp BX,0x003A
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)58)));
        // 100D:4A90 jge short 0x4A98
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_4A98_14B68_27266;
        }
    label_100D_4A92_14B62_27263:
        CheckExternalEvents(cs1, 0x4A92);
        // 100D:4A92 mov AX,0x002F
        AX = (ushort)0x002F;
        // 100D:4A95 call near 0xC22F
        NearCall(cs1, 0x4A98, unknown_100D_C22F_1C2FF);
    label_100D_4A98_14B68_27266:
        CheckExternalEvents(cs1, 0x4A98);
        // 100D:4A98 pop SI
        SI = Stack.Pop16();
    label_100D_4A99_14B69_22015:
        CheckExternalEvents(cs1, 0x4A99);
        // 100D:4A99 cmp SI,0xE85C
        Alu16.Sub(SI, (ushort)0xE85C);
        // 100D:4A9D jb short 0x4AA2
        if (CarryFlag)
        {
            goto label_100D_4AA2_14B72_22018;
        }
    label_100D_4A9F_14B6F_22022:
        CheckExternalEvents(cs1, 0x4A9F);
        // 100D:4A9F mov SI,0xE40C
        SI = (ushort)0xE40C;
    label_100D_4AA2_14B72_22018:
        CheckExternalEvents(cs1, 0x4AA2);
        // 100D:4AA2 cmp SI,word ptr DS:[0x149A]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x149A]);
        // 100D:4AA6 jne short 0x4A68
        if (!ZeroFlag)
        {
            goto label_100D_4A68_14B38_22009;
        }
    label_100D_4AA8_14B78_22024:
        CheckExternalEvents(cs1, 0x4AA8);
        // 100D:4AA8 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_4AA8_14B78 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_4AA8_14B78 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_4AA8_14B78 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_4AA8_14B78);
        // 100D:4AAC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4AB8_14B88(int loadOffset)
    {
    label_100D_4AB8_14B88_22115:
        CheckExternalEvents(cs1, 0x4AB8);
        // 100D:4AB8 mov byte ptr DS:[0x4727],0xFF
        UInt8[DS, (ushort)0x4727] = (byte)0xFF;
        // 100D:4ABD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4ABE_14B8E(int loadOffset)
    {
    entrydispatcher:
    label_100D_4ABE_14B8E_27242:
        CheckExternalEvents(cs1, 0x4ABE);
        // 100D:4ABE call near 0x37F4
        NearCall(cs1, 0x4AC1, unknown_100D_37F4_138C4);
    label_100D_4AC1_14B91_27268:
        CheckExternalEvents(cs1, 0x4AC1);
        // 100D:4AC1 call near 0xC4DD
        NearCall(cs1, 0x4AC4, unknown_100D_C4DD_1C5AD);
        return unknown_100D_4AC4_14B94(0x0000);
    }

    public virtual Action unknown_100D_4AC4_14B94(int loadOffset)
    {
    label_100D_4AC4_14B94_21590:
        CheckExternalEvents(cs1, 0x4AC4);
        // 100D:4AC4 mov byte ptr DS:[0x11CA],0
        UInt8[DS, (ushort)0x11CA] = (byte)0x00;
        // 100D:4AC9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4ACA_14B9A(int loadOffset)
    {
    label_100D_4ACA_14B9A_7925:
        CheckExternalEvents(cs1, 0x4ACA);
        // 100D:4ACA mov byte ptr DS:[0x11CA],1
        UInt8[DS, (ushort)0x11CA] = (byte)0x01;
        // 100D:4ACF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4AEB_14BBB(int loadOffset)
    {
    label_100D_4AEB_14BBB_35206:
        CheckExternalEvents(cs1, 0x4AEB);
        // 100D:4AEB mov AX,0x0039
        AX = (ushort)0x0039;
        // 100D:4AEE call near 0xC13E
        NearCall(cs1, 0x4AF1, unknown_100D_C13E_1C20E);
    label_100D_4AF1_14BC1_35209:
        CheckExternalEvents(cs1, 0x4AF1);
        // 100D:4AF1 call near 0xC07C
        NearCall(cs1, 0x4AF4, unknown_100D_C07C_1C14C);
    label_100D_4AF4_14BC4_35211:
        CheckExternalEvents(cs1, 0x4AF4);
        // 100D:4AF4 call near 0x4D6C
        NearCall(cs1, 0x4AF7, unknown_100D_4D6C_14E3C);
    label_100D_4AF7_14BC7_35278:
        CheckExternalEvents(cs1, 0x4AF7);
        // 100D:4AF7 call near 0x4B2B
        NearCall(cs1, 0x4AFA, unknown_100D_4B2B_14BFB);
    label_100D_4AFA_14BCA_35280:
        CheckExternalEvents(cs1, 0x4AFA);
        // 100D:4AFA jmp near 0xC4DD
        return unknown_100D_C4DD_1C5AD(0x0000);
    }

    public virtual Action unknown_100D_4B16_14BE6(int loadOffset)
    {
    label_100D_4B16_14BE6_6477:
        CheckExternalEvents(cs1, 0x4B16);
        // 100D:4B16 mov AX,word ptr DS:[0xDBD8]
        AX = UInt16[DS, (ushort)0xDBD8];
        // 100D:4B19 mov SI,word ptr DS:[0xDBD6]
        SI = UInt16[DS, (ushort)0xDBD6];
        // 100D:4B1D cmp AX,SI
        Alu16.Sub(AX, SI);
        // 100D:4B1F je short 0x4B2A
        if (ZeroFlag)
        {
            goto label_100D_4B2A_14BFA_6482;
        }
    label_100D_4B21_14BF1_6575:
        CheckExternalEvents(cs1, 0x4B21);
        // 100D:4B21 add AX,0x01E0
        AX = Alu16.Add(AX, (ushort)0x01E0);
        // 100D:4B24 mov ES,AX
        ES = AX;
        // 100D:4B26 call far dword ptr DS:[0x38FD]
        ushort targetSegment_6578 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38FD + (ushort)0x0002)]));
        ushort targetOffset_6578 = unchecked((ushort)(UInt16[DS, (ushort)0x38FD]));
        if (targetSegment_6578 == cs2 && targetOffset_6578 == 0x0136)
        {
            FarCall(cs1, 0x4B2A, cs2, unknown_3358_0136_336B6);
            goto label_100D_4B2A_14BFA_6482;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_6578:X4}:{targetOffset_6578:X4} at 100D:4B26");
    label_100D_4B2A_14BFA_6482:
        CheckExternalEvents(cs1, 0x4B2A);
        // 100D:4B2A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4B2B_14BFB(int loadOffset)
    {
    label_100D_4B2B_14BFB_22032:
        CheckExternalEvents(cs1, 0x4B2B);
        // 100D:4B2B cmp byte ptr DS:[0x4728],0
        Alu8.Sub(UInt8[DS, (ushort)0x4728], (byte)0x00);
        // 100D:4B30 js short 0x4B38
        if (SignFlag)
        {
            goto label_100D_4B38_14C08_22042;
        }
    label_100D_4B32_14C02_22035:
        CheckExternalEvents(cs1, 0x4B32);
        // 100D:4B32 mov SI,0x1492
        SI = (ushort)0x1492;
        // 100D:4B35 call near 0xC46F
        NearCall(cs1, 0x4B38, unknown_100D_C46F_1C53F);
    label_100D_4B38_14C08_22042:
        CheckExternalEvents(cs1, 0x4B38);
        // 100D:4B38 jmp near 0xDBCA
    label_100D_DBCA_1DC9A_22044:
        CheckExternalEvents(cs1, 0xDBCA);
        // 100D:DBCA mov AX,word ptr DS:[0xDC44]
        AX = UInt16[DS, (ushort)0xDC44];
        // 100D:DBCD cmp AX,0x0098
        Alu16.Sub(AX, (ushort)0x0098);
        // 100D:DBD0 jae short 0xDBE2
        if (!CarryFlag)
        {
            goto label_100D_DBE2_1DCB2_22054;
        }
    label_100D_DBD2_1DCA2_22048:
        CheckExternalEvents(cs1, 0xDBD2);
        // 100D:DBD2 cmp AX,0x0088
        Alu16.Sub(AX, (ushort)0x0088);
        // 100D:DBD5 jae short 0xDBB2
        if (!CarryFlag)
        {
            return unknown_100D_DBB2_1DC82(0x0000);
        }
    label_100D_DBD7_1DCA7_22051:
        CheckExternalEvents(cs1, 0xDBD7);
        // 100D:DBD7 dec byte ptr DS:[0xDC46]
        UInt8[DS, (ushort)0xDC46] = Alu8.Dec(UInt8[DS, (ushort)0xDC46]);
        // 100D:DBDB js short 0xDBE2
        if (!(SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:DBDB");
        }
    label_100D_DBE2_1DCB2_22054:
        CheckExternalEvents(cs1, 0xDBE2);
        // 100D:DBE2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4B3B_14C0B(int loadOffset)
    {
    label_100D_4B3B_14C0B_21823:
        CheckExternalEvents(cs1, 0x4B3B);
        // 100D:4B3B inc word ptr DS:[0x472B]
        UInt16[DS, (ushort)0x472B] = Alu16.Inc(UInt16[DS, (ushort)0x472B]);
        // 100D:4B3F test word ptr DS:[0x472B],0x000F
        Alu16.And(UInt16[DS, (ushort)0x472B], (ushort)0x000F);
        // 100D:4B45 jne short 0x4B4D
        if (!ZeroFlag)
        {
            goto label_100D_4B4D_14C1D_21827;
        }
    label_100D_4B47_14C17_22490:
        CheckExternalEvents(cs1, 0x4B47);
        // 100D:4B47 mov CX,1
        CX = (ushort)0x0001;
        // 100D:4B4A call near 0x0FD9
        NearCall(cs1, 0x4B4D, unknown_100D_0FD9_110A9);
    label_100D_4B4D_14C1D_21827:
        CheckExternalEvents(cs1, 0x4B4D);
        // 100D:4B4D call near 0x407E
        NearCall(cs1, 0x4B50, unknown_100D_407E_1414E);
    label_100D_4B50_14C20_21829:
        CheckExternalEvents(cs1, 0x4B50);
        // 100D:4B50 call near 0x5206
        NearCall(cs1, 0x4B53, unknown_100D_5206_152D6);
    label_100D_4B53_14C23_21912:
        CheckExternalEvents(cs1, 0x4B53);
        // 100D:4B53 call near 0x40C3
        NearCall(cs1, 0x4B56, unknown_100D_40C3_14193);
    label_100D_4B56_14C26_21914:
        CheckExternalEvents(cs1, 0x4B56);
        // 100D:4B56 mov word ptr DS:[4],DX
        UInt16[DS, (ushort)0x0004] = DX;
        // 100D:4B5A mov word ptr DS:[6],BX
        UInt16[DS, (ushort)0x0006] = BX;
        // 100D:4B5E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4B5F_14C2F(int loadOffset)
    {
    label_100D_4B5F_14C2F_30725:
        CheckExternalEvents(cs1, 0x4B5F);
        // 100D:4B5F mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:4B62 mov AX,DX
        AX = DX;
        // 100D:4B64 add AX,word ptr DS:[0x487A]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x487A]);
        // 100D:4B68 cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 100D:4B6A jge short 0x4B6E
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B6A");
        }
    label_100D_4B6E_14C3E_30731:
        CheckExternalEvents(cs1, 0x4B6E);
        // 100D:4B6E cmp DX,word ptr DS:[SI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:4B71 jle short 0x4B76
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B71");
        }
    label_100D_4B76_14C46_30734:
        CheckExternalEvents(cs1, 0x4B76);
        // 100D:4B76 mov word ptr DS:[0x4860],DX
        UInt16[DS, (ushort)0x4860] = DX;
        // 100D:4B7A cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:4B7C jge short 0x4B80
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B7C");
        }
    label_100D_4B80_14C50_30738:
        CheckExternalEvents(cs1, 0x4B80);
        // 100D:4B80 cmp AX,word ptr DS:[SI+4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:4B83 jle short 0x4B88
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B83");
        }
    label_100D_4B88_14C58_30741:
        CheckExternalEvents(cs1, 0x4B88);
        // 100D:4B88 mov word ptr DS:[0x4864],AX
        UInt16[DS, (ushort)0x4864] = AX;
        // 100D:4B8B mov AX,BX
        AX = BX;
        // 100D:4B8D add AX,word ptr DS:[0x487C]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x487C]);
        // 100D:4B91 cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:4B94 jge short 0x4B99
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B94");
        }
    label_100D_4B99_14C69_30747:
        CheckExternalEvents(cs1, 0x4B99);
        // 100D:4B99 cmp BX,word ptr DS:[SI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:4B9C jle short 0x4BA1
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4B9C");
        }
    label_100D_4BA1_14C71_30750:
        CheckExternalEvents(cs1, 0x4BA1);
        // 100D:4BA1 mov word ptr DS:[0x4862],BX
        UInt16[DS, (ushort)0x4862] = BX;
        // 100D:4BA5 cmp AX,word ptr DS:[SI+2]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:4BA8 jge short 0x4BAD
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4BA8");
        }
    label_100D_4BAD_14C7D_30754:
        CheckExternalEvents(cs1, 0x4BAD);
        // 100D:4BAD cmp AX,word ptr DS:[SI+6]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:4BB0 jle short 0x4BB5
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4BB0");
        }
    label_100D_4BB2_14C82_30757:
        CheckExternalEvents(cs1, 0x4BB2);
        // 100D:4BB2 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:4BB5 mov word ptr DS:[0x4866],AX
        UInt16[DS, (ushort)0x4866] = AX;
        // 100D:4BB8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4BB9_14C89(int loadOffset)
    {
    label_100D_4BB9_14C89_30839:
        CheckExternalEvents(cs1, 0x4BB9);
        // 100D:4BB9 call near 0xD41B
        NearCall(cs1, 0x4BBC, unknown_100D_D41B_1D4EB);
    label_100D_4BBC_14C8C_30841:
        CheckExternalEvents(cs1, 0x4BBC);
        // 100D:4BBC cmp word ptr DS:[0x47C6],0
        Alu16.Sub(UInt16[DS, (ushort)0x47C6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:4BC1 jne short 0x4BDE
        if (!ZeroFlag)
        {
            goto label_100D_4BDE_14CAE_30859;
        }
    label_100D_4BC3_14C93_30844:
        CheckExternalEvents(cs1, 0x4BC3);
        // 100D:4BC3 cmp BP,0x1F0E
        Alu16.Sub(BP, (ushort)0x1F0E);
        // 100D:4BC7 jne short 0x4BDE
        if (!ZeroFlag)
        {
            goto label_100D_4BDE_14CAE_30859;
        }
    label_100D_4BC9_14C99_30847:
        CheckExternalEvents(cs1, 0x4BC9);
        // 100D:4BC9 mov SI,0x4860
        SI = (ushort)0x4860;
        // 100D:4BCC call near 0xC446
        NearCall(cs1, 0x4BCF, unknown_100D_C446_1C516);
    label_100D_4BCF_14C9F_30850:
        CheckExternalEvents(cs1, 0x4BCF);
        // 100D:4BCF call near 0x4BDF
        NearCall(cs1, 0x4BD2, unknown_100D_4BDF_14CAF);
    label_100D_4BD2_14CA2_30852:
        CheckExternalEvents(cs1, 0x4BD2);
        // 100D:4BD2 mov SI,0x4860
        SI = (ushort)0x4860;
        // 100D:4BD5 call near 0xDB74
        NearCall(cs1, 0x4BD8, unknown_100D_DB74_1DC44);
    label_100D_4BD8_14CA8_30855:
        CheckExternalEvents(cs1, 0x4BD8);
        // 100D:4BD8 call near 0xC4F0
        NearCall(cs1, 0x4BDB, unknown_100D_C4F0_1C5C0);
    label_100D_4BDB_14CAB_30857:
        CheckExternalEvents(cs1, 0x4BDB);
        // 100D:4BDB call near 0xDB67
        NearCall(cs1, 0x4BDE, unknown_100D_DB67_1DC37);
    label_100D_4BDE_14CAE_30859:
        CheckExternalEvents(cs1, 0x4BDE);
        // 100D:4BDE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4BDF_14CAF(int loadOffset)
    {
    label_100D_4BDF_14CAF_30704:
        CheckExternalEvents(cs1, 0x4BDF);
        // 100D:4BDF mov AX,word ptr DS:[0x485E]
        AX = UInt16[DS, (ushort)0x485E];
        // 100D:4BE2 call near 0xC13E
        NearCall(cs1, 0x4BE5, unknown_100D_C13E_1C20E);
    label_100D_4BE5_14CB5_30707:
        CheckExternalEvents(cs1, 0x4BE5);
        // 100D:4BE5 mov AX,word ptr DS:[0x4878]
        AX = UInt16[DS, (ushort)0x4878];
        // 100D:4BE8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4BEA add AX,word ptr DS:[0x4874]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x4874]);
        // 100D:4BEE mov word ptr DS:[0x4878],AX
        UInt16[DS, (ushort)0x4878] = AX;
        // 100D:4BF1 mov AL,AH
        AL = AH;
        // 100D:4BF3 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:4BF4 add word ptr DS:[0x4870],AX
        UInt16[DS, (ushort)0x4870] = Alu16.Add(UInt16[DS, (ushort)0x4870], AX);
        // 100D:4BF8 mov AX,word ptr DS:[0x4876]
        AX = UInt16[DS, (ushort)0x4876];
        // 100D:4BFB xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4BFD add AX,word ptr DS:[0x4872]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x4872]);
        // 100D:4C01 mov word ptr DS:[0x4876],AX
        UInt16[DS, (ushort)0x4876] = AX;
        // 100D:4C04 mov AL,AH
        AL = AH;
        // 100D:4C06 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:4C07 add word ptr DS:[0x486E],AX
        UInt16[DS, (ushort)0x486E] = Alu16.Add(UInt16[DS, (ushort)0x486E], AX);
        // 100D:4C0B mov DX,word ptr DS:[0x486E]
        DX = UInt16[DS, (ushort)0x486E];
        // 100D:4C0F mov BX,word ptr DS:[0x4870]
        BX = UInt16[DS, (ushort)0x4870];
        // 100D:4C13 call near 0x4B5F
        NearCall(cs1, 0x4C16, unknown_100D_4B5F_14C2F);
    label_100D_4C16_14CE6_30761:
        CheckExternalEvents(cs1, 0x4C16);
        // 100D:4C16 mov SI,word ptr DS:[0x486A]
        SI = UInt16[DS, (ushort)0x486A];
        // 100D:4C1A mov DS,word ptr SS:[0xDBB2]
        DS = UInt16[SS, (ushort)0xDBB2];
        // 100D:4C1F cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:4C22 jne short 0x4C29
        if (!ZeroFlag)
        {
            goto label_100D_4C29_14CF9_30766;
        }
    label_100D_4C24_14CF4_30861:
        CheckExternalEvents(cs1, 0x4C24);
        // 100D:4C24 mov SI,word ptr SS:[0x4868]
        SI = UInt16[SS, (ushort)0x4868];
    label_100D_4C29_14CF9_30766:
        CheckExternalEvents(cs1, 0x4C29);
        // 100D:4C29 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4C2A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4C2C or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:4C2E je short 0x4C3E
        if (ZeroFlag)
        {
            goto label_100D_4C3E_14D0E_30817;
        }
    label_100D_4C30_14D00_30771:
        CheckExternalEvents(cs1, 0x4C30);
        // 100D:4C30 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:4C32 jne short 0x4C37
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4C32");
        }
    label_100D_4C37_14D07_30774:
        CheckExternalEvents(cs1, 0x4C37);
        // 100D:4C37 push SI
        Stack.Push16(SI);
        // 100D:4C38 call near 0x4C45
        NearCall(cs1, 0x4C3B, unknown_100D_4C45_14D15);
    label_100D_4C3B_14D0B_30814:
        CheckExternalEvents(cs1, 0x4C3B);
        // 100D:4C3B pop SI
        SI = Stack.Pop16();
        // 100D:4C3C jmp short 0x4C29
        goto label_100D_4C29_14CF9_30766;
    label_100D_4C3E_14D0E_30817:
        CheckExternalEvents(cs1, 0x4C3E);
        // 100D:4C3E push SS
        Stack.Push16(SS);
        // 100D:4C3F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4C40 mov word ptr DS:[0x486A],SI
        UInt16[DS, (ushort)0x486A] = SI;
        // 100D:4C44 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4C45_14D15(int loadOffset)
    {
    label_100D_4C45_14D15_30777:
        CheckExternalEvents(cs1, 0x4C45);
        // 100D:4C45 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:4C48 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:4C4A mov BP,AX
        BP = AX;
        // 100D:4C4C mov SI,word ptr SS:[0x486C]
        SI = UInt16[SS, (ushort)0x486C];
        // 100D:4C51 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
    label_100D_4C54_14D24_30783:
        CheckExternalEvents(cs1, 0x4C54);
        // 100D:4C54 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4C55 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:4C57 je short 0x4C91
        if (ZeroFlag)
        {
            goto label_100D_4C91_14D61_30812;
        }
    label_100D_4C59_14D29_30786:
        CheckExternalEvents(cs1, 0x4C59);
        // 100D:4C59 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4C5B mov BP,AX
        BP = AX;
        // 100D:4C5D lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4C5E mov DX,AX
        DX = AX;
        // 100D:4C60 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4C61 mov BX,AX
        BX = AX;
        // 100D:4C63 add DX,word ptr SS:[0x486E]
        DX = Alu16.Add(DX, UInt16[SS, (ushort)0x486E]);
        // 100D:4C68 add BX,word ptr SS:[0x4870]
        BX = Alu16.Add(BX, UInt16[SS, (ushort)0x4870]);
        // 100D:4C6D push SI
        Stack.Push16(SI);
        // 100D:4C6E dec BP
        BP = Alu16.Dec(BP);
        // 100D:4C6F mov ES,word ptr SS:[0xDBDA]
        ES = UInt16[SS, (ushort)0xDBDA];
        // 100D:4C74 mov SI,word ptr SS:[0xDBB0]
        SI = UInt16[SS, (ushort)0xDBB0];
        // 100D:4C79 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:4C7B add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:4C7E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4C7F mov DI,AX
        DI = AX;
        // 100D:4C81 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4C82 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4C84 mov CX,AX
        CX = AX;
        // 100D:4C86 mov BP,0x4860
        BP = (ushort)0x4860;
        // 100D:4C89 call far dword ptr SS:[0x38CD]
        ushort targetSegment_30807 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_30807 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_30807 == cs2 && targetOffset_30807 == 0x0112)
        {
            FarCall(cs1, 0x4C8E, cs2, unknown_3358_0112_33692);
            goto label_100D_4C8E_14D5E_30808;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_30807:X4}:{targetOffset_30807:X4} at 100D:4C89");
    label_100D_4C8E_14D5E_30808:
        CheckExternalEvents(cs1, 0x4C8E);
        // 100D:4C8E pop SI
        SI = Stack.Pop16();
        // 100D:4C8F jmp short 0x4C54
        goto label_100D_4C54_14D24_30783;
    label_100D_4C91_14D61_30812:
        CheckExternalEvents(cs1, 0x4C91);
        // 100D:4C91 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4D00_14DD0(int loadOffset)
    {
    label_100D_4D00_14DD0_6662:
        CheckExternalEvents(cs1, 0x4D00);
        // 100D:4D00 mov SI,0x4BB9
        SI = (ushort)0x4BB9;
        // 100D:4D03 jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    }

    public virtual Action unknown_100D_4D57_14E27(int loadOffset)
    {
        goto label_100D_4D57_14E27_30648;

    label_100D_4C92_14D62_30658:
        CheckExternalEvents(cs1, 0x4C92);
        // 100D:4C92 push DS
        Stack.Push16(DS);
        // 100D:4C93 push AX
        Stack.Push16(AX);
        // 100D:4C94 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4C96 mov word ptr DS:[0x485E],AX
        UInt16[DS, (ushort)0x485E] = AX;
        // 100D:4C99 mov word ptr DS:[0x486E],DX
        UInt16[DS, (ushort)0x486E] = DX;
        // 100D:4C9D mov word ptr DS:[0x4870],BX
        UInt16[DS, (ushort)0x4870] = BX;
        // 100D:4CA1 mov word ptr DS:[0x4872],BP
        UInt16[DS, (ushort)0x4872] = BP;
        // 100D:4CA5 mov word ptr DS:[0x4874],CX
        UInt16[DS, (ushort)0x4874] = CX;
        // 100D:4CA9 mov word ptr DS:[0x4876],0
        UInt16[DS, (ushort)0x4876] = (ushort)0x0000;
        // 100D:4CAF mov word ptr DS:[0x4878],0
        UInt16[DS, (ushort)0x4878] = (ushort)0x0000;
        // 100D:4CB5 call near 0xC13E
        NearCall(cs1, 0x4CB8, unknown_100D_C13E_1C20E);
    label_100D_4CB8_14D88_30670:
        CheckExternalEvents(cs1, 0x4CB8);
        // 100D:4CB8 push DS
        Stack.Push16(DS);
        // 100D:4CB9 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4CBA lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_4CBA_14D8A = (ushort)0xDBB0;
        ushort lxsValue_100D_4CBA_14D8A = UInt16[DS, lxsOffset_100D_4CBA_14D8A];
        ushort lxsSegment_100D_4CBA_14D8A = UInt16[DS, (ushort)(lxsOffset_100D_4CBA_14D8A + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_4CBA_14D8A);
        DS = unchecked((ushort)lxsSegment_100D_4CBA_14D8A);
        // 100D:4CBE mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:4CC0 add SI,word ptr DS:[BX+SI-2]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BX + SI + (sbyte)-2)]);
        // 100D:4CC3 mov DI,0x4860
        DI = (ushort)0x4860;
        // 100D:4CC6 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:4CC9 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4CCA mov DX,AX
        DX = AX;
        // 100D:4CCC lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4CCD mov BX,AX
        BX = AX;
        // 100D:4CCF lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4CD0 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:4CD2 mov word ptr SS:[0x487A],AX
        UInt16[SS, (ushort)0x487A] = AX;
        // 100D:4CD6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4CD7 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:4CD9 mov word ptr SS:[0x487C],AX
        UInt16[SS, (ushort)0x487C] = AX;
        // 100D:4CDD mov AX,SI
        AX = SI;
        // 100D:4CDF add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:4CE2 mov word ptr SS:[0x486C],AX
        UInt16[SS, (ushort)0x486C] = AX;
        // 100D:4CE6 add SI,word ptr DS:[SI]
        SI = Alu16.Add(SI, UInt16[DS, SI]);
        // 100D:4CE8 pop AX
        AX = Stack.Pop16();
        // 100D:4CE9 mov AL,AH
        AL = AH;
        // 100D:4CEB xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4CED shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:4CEF mov BP,AX
        BP = AX;
        // 100D:4CF1 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:4CF4 mov word ptr SS:[0x4868],SI
        UInt16[SS, (ushort)0x4868] = SI;
        // 100D:4CF9 mov word ptr SS:[0x486A],SI
        UInt16[SS, (ushort)0x486A] = SI;
        // 100D:4CFE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4CFF ret near
        return NearRet((ushort)0x0000);
    label_100D_4D57_14E27_30648:
        CheckExternalEvents(cs1, 0x4D57);
        // 100D:4D57 mov AL,0x31
        AL = (byte)0x31;
        // 100D:4D59 mov DX,5
        DX = (ushort)0x0005;
        // 100D:4D5C shl BH,1
        BH = Alu8.Shl(BH, 1);
        // 100D:4D5E shl BH,1
        BH = Alu8.Shl(BH, 1);
        // 100D:4D60 add DL,BH
        DL = Alu8.Add(DL, BH);
        // 100D:4D62 mov BX,0x0029
        BX = (ushort)0x0029;
        // 100D:4D65 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:4D67 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:4D69 jmp near 0x4C92
        goto label_100D_4C92_14D62_30658;
    }

    public virtual Action unknown_100D_4D6C_14E3C(int loadOffset)
    {
    label_100D_4D6C_14E3C_35213:
        CheckExternalEvents(cs1, 0x4D6C);
        // 100D:4D6C mov SI,word ptr DS:[0xAA6E]
        SI = UInt16[DS, (ushort)0xAA6E];
        // 100D:4D70 cmp byte ptr CS:[SI],0xFF
        Alu8.Sub(UInt8[CS, SI], (byte)0xFF);
        // 100D:4D74 jne short 0x4D82
        if (!ZeroFlag)
        {
            goto label_100D_4D82_14E52_35217;
        }
    label_100D_4D76_14E46_40903:
        CheckExternalEvents(cs1, 0x4D76);
        // 100D:4D76 mov SI,word ptr CS:[0x0167]
        SI = UInt16[CS, (ushort)0x0167];
        // 100D:4D7B add SI,word ptr CS:[SI]
        SI = Alu16.Add(SI, UInt16[CS, SI]);
        // 100D:4D7E mov word ptr DS:[0xAA6E],SI
        UInt16[DS, (ushort)0xAA6E] = SI;
    label_100D_4D82_14E52_35217:
        CheckExternalEvents(cs1, 0x4D82);
        // 100D:4D82 push CS
        Stack.Push16(CS);
        // 100D:4D83 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_4D84_14E54_35220:
        CheckExternalEvents(cs1, 0x4D84);
        // 100D:4D84 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4D85 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4D87 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:4D89 je short 0x4D99
        if (ZeroFlag)
        {
            goto label_100D_4D99_14E69_35273;
        }
    label_100D_4D8B_14E5B_35224:
        CheckExternalEvents(cs1, 0x4D8B);
        // 100D:4D8B cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:4D8D jne short 0x4D92
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4D8D");
        }
    label_100D_4D92_14E62_35227:
        CheckExternalEvents(cs1, 0x4D92);
        // 100D:4D92 push SI
        Stack.Push16(SI);
        // 100D:4D93 call near 0x4DA0
        NearCall(cs1, 0x4D96, unknown_100D_4DA0_14E70);
    label_100D_4D96_14E66_35269:
        CheckExternalEvents(cs1, 0x4D96);
        // 100D:4D96 pop SI
        SI = Stack.Pop16();
        // 100D:4D97 jmp short 0x4D84
        goto label_100D_4D84_14E54_35220;
    label_100D_4D99_14E69_35273:
        CheckExternalEvents(cs1, 0x4D99);
        // 100D:4D99 push SS
        Stack.Push16(SS);
        // 100D:4D9A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4D9B mov word ptr DS:[0xAA6E],SI
        UInt16[DS, (ushort)0xAA6E] = SI;
        // 100D:4D9F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4DA0_14E70(int loadOffset)
    {
    label_100D_4DA0_14E70_35230:
        CheckExternalEvents(cs1, 0x4DA0);
        // 100D:4DA0 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:4DA3 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:4DA5 mov BP,AX
        BP = AX;
        // 100D:4DA7 mov SI,0x0169
        SI = (ushort)0x0169;
        // 100D:4DAA add SI,word ptr CS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[CS, (ushort)(BP + SI)]);
    label_100D_4DAD_14E7D_35236:
        CheckExternalEvents(cs1, 0x4DAD);
        // 100D:4DAD lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4DAE or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:4DB0 je short 0x4DEC
        if (ZeroFlag)
        {
            goto label_100D_4DEC_14EBC_35267;
        }
    label_100D_4DB2_14E82_35239:
        CheckExternalEvents(cs1, 0x4DB2);
        // 100D:4DB2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4DB4 mov BP,AX
        BP = AX;
        // 100D:4DB6 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4DB7 mov DX,AX
        DX = AX;
        // 100D:4DB9 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4DBA mov BX,AX
        BX = AX;
        // 100D:4DBC add DX,word ptr SS:[0xAA66]
        DX = Alu16.Add(DX, UInt16[SS, (ushort)0xAA66]);
        // 100D:4DC1 add BX,word ptr SS:[0xAA68]
        BX = Alu16.Add(BX, UInt16[SS, (ushort)0xAA68]);
        // 100D:4DC6 push SI
        Stack.Push16(SI);
        // 100D:4DC7 push DS
        Stack.Push16(DS);
        // 100D:4DC8 dec BP
        BP = Alu16.Dec(BP);
        // 100D:4DC9 mov ES,word ptr SS:[0xDBDA]
        ES = UInt16[SS, (ushort)0xDBDA];
        // 100D:4DCE lds SI,word ptr SS:[0xDBB0]
        ushort lxsOffset_100D_4DCE_14E9E = (ushort)0xDBB0;
        ushort lxsValue_100D_4DCE_14E9E = UInt16[SS, lxsOffset_100D_4DCE_14E9E];
        ushort lxsSegment_100D_4DCE_14E9E = UInt16[SS, (ushort)(lxsOffset_100D_4DCE_14E9E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_4DCE_14E9E);
        DS = unchecked((ushort)lxsSegment_100D_4DCE_14E9E);
        // 100D:4DD3 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:4DD5 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:4DD8 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4DD9 mov DI,AX
        DI = AX;
        // 100D:4DDB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4DDC xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4DDE mov CX,AX
        CX = AX;
        // 100D:4DE0 mov BP,0xAA66
        BP = (ushort)0xAA66;
        // 100D:4DE3 call far dword ptr SS:[0x38CD]
        ushort targetSegment_35261 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_35261 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_35261 == cs2 && targetOffset_35261 == 0x0112)
        {
            FarCall(cs1, 0x4DE8, cs2, unknown_3358_0112_33692);
            goto label_100D_4DE8_14EB8_35262;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_35261:X4}:{targetOffset_35261:X4} at 100D:4DE3");
    label_100D_4DE8_14EB8_35262:
        CheckExternalEvents(cs1, 0x4DE8);
        // 100D:4DE8 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4DE9 pop SI
        SI = Stack.Pop16();
        // 100D:4DEA jmp short 0x4DAD
        goto label_100D_4DAD_14E7D_35236;
    label_100D_4DEC_14EBC_35267:
        CheckExternalEvents(cs1, 0x4DEC);
        // 100D:4DEC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4DED_14EBD(int loadOffset)
    {
    label_100D_4DED_14EBD_27926:
        CheckExternalEvents(cs1, 0x4DED);
        // 100D:4DED xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:4DEF mov BP,0x4E04
        BP = (ushort)0x4E04;
        // 100D:4DF2 push SI
        Stack.Push16(SI);
        // 100D:4DF3 call near 0x661D
        NearCall(cs1, 0x4DF6, unknown_100D_661D_166ED);
    label_100D_4DF6_14EC6_27932:
        CheckExternalEvents(cs1, 0x4DF6);
        // 100D:4DF6 mov CH,byte ptr DS:[DI+0x14]
        CH = UInt8[DS, (ushort)(DI + (sbyte)20)];
        // 100D:4DF9 mov word ptr DS:[0x4733],CX
        UInt16[DS, (ushort)0x4733] = CX;
        // 100D:4DFD push ES
        Stack.Push16(ES);
        // 100D:4DFE call near 0x7F27
        NearCall(cs1, 0x4E01, unknown_100D_7F27_17FF7);
    label_100D_4E01_14ED1_27937:
        CheckExternalEvents(cs1, 0x4E01);
        // 100D:4E01 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4E02 pop SI
        SI = Stack.Pop16();
        // 100D:4E03 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4E04_14ED4(int loadOffset)
    {
    label_100D_4E04_14ED4_30626:
        CheckExternalEvents(cs1, 0x4E04);
        // 100D:4E04 cmp byte ptr DS:[SI+3],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x00);
        // 100D:4E08 jne short 0x4E11
        if (!ZeroFlag)
        {
            goto label_100D_4E11_14EE1_30634;
        }
    label_100D_4E0A_14EDA_30629:
        CheckExternalEvents(cs1, 0x4E0A);
        // 100D:4E0A test byte ptr DS:[SI+0x19],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x80);
        // 100D:4E0E je short 0x4E11
        if (ZeroFlag)
        {
            goto label_100D_4E11_14EE1_30634;
        }
    label_100D_4E10_14EE0_30632:
        CheckExternalEvents(cs1, 0x4E10);
        // 100D:4E10 inc CX
        CX = Alu16.Inc(CX);
    label_100D_4E11_14EE1_30634:
        CheckExternalEvents(cs1, 0x4E11);
        // 100D:4E11 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4E12_14EE2(int loadOffset)
    {
    label_100D_4E12_14EE2_20512:
        CheckExternalEvents(cs1, 0x4E12);
        // 100D:4E12 mov word ptr DS:[0x4733],0
        UInt16[DS, (ushort)0x4733] = (ushort)0x0000;
        // 100D:4E18 call near 0x407E
        NearCall(cs1, 0x4E1B, unknown_100D_407E_1414E);
    label_100D_4E1B_14EEB_20515:
        CheckExternalEvents(cs1, 0x4E1B);
        // 100D:4E1B call near 0xB532
        NearCall(cs1, 0x4E1E, unknown_100D_B532_1B602);
    label_100D_4E1E_14EEE_20524:
        CheckExternalEvents(cs1, 0x4E1E);
        // 100D:4E1E push AX
        Stack.Push16(AX);
        // 100D:4E1F call near 0x4EC6
        NearCall(cs1, 0x4E22, unknown_100D_4EC6_14F96);
    label_100D_4E22_14EF2_20536:
        CheckExternalEvents(cs1, 0x4E22);
        // 100D:4E22 mov word ptr DS:[0x196A],0
        UInt16[DS, (ushort)0x196A] = (ushort)0x0000;
        // 100D:4E28 pop AX
        AX = Stack.Pop16();
        // 100D:4E29 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:4E2B je short 0x4E78
        if (ZeroFlag)
        {
            goto label_100D_4E78_14F48_20558;
        }
    label_100D_4E2D_14EFD_20541:
        CheckExternalEvents(cs1, 0x4E2D);
        // 100D:4E2D call near 0x409A
        NearCall(cs1, 0x4E30, unknown_100D_409A_1416A);
    label_100D_4E30_14F00_20553:
        CheckExternalEvents(cs1, 0x4E30);
        // 100D:4E30 jne short 0x4E78
        if (!ZeroFlag)
        {
            goto label_100D_4E78_14F48_20558;
        }
    label_100D_4E32_14F02_20555:
        CheckExternalEvents(cs1, 0x4E32);
        // 100D:4E32 cmp byte ptr DS:[6],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x0006], (byte)0x80);
        // 100D:4E37 je short 0x4E78
        if (ZeroFlag)
        {
            goto label_100D_4E78_14F48_20558;
        }
    label_100D_4E39_14F09_27903:
        CheckExternalEvents(cs1, 0x4E39);
        // 100D:4E39 mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:4E3C sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:4E3E add AX,4
        AX = Alu16.Add(AX, (ushort)0x0004);
        // 100D:4E41 cmp AX,8
        Alu16.Sub(AX, (ushort)0x0008);
        // 100D:4E44 jae short 0x4E78
        if (!CarryFlag)
        {
            goto label_100D_4E78_14F48_20558;
        }
    label_100D_4E46_14F16_27909:
        CheckExternalEvents(cs1, 0x4E46);
        // 100D:4E46 mov word ptr DS:[0x1968],AX
        UInt16[DS, (ushort)0x1968] = AX;
        // 100D:4E49 inc AX
        AX = Alu16.Inc(AX);
        // 100D:4E4A mov word ptr DS:[0x1964],AX
        UInt16[DS, (ushort)0x1964] = AX;
        // 100D:4E4D sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:4E50 mov word ptr DS:[0x1960],AX
        UInt16[DS, (ushort)0x1960] = AX;
        // 100D:4E53 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:4E55 call near 0x5E4F
        NearCall(cs1, 0x4E58, unknown_100D_5E4F_15F1F);
    label_100D_4E58_14F28_27917:
        CheckExternalEvents(cs1, 0x4E58);
        // 100D:4E58 mov BX,0x196D
        BX = (ushort)0x196D;
        // 100D:4E5B xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:4E5C cmp AL,0x13
        Alu8.Sub(AL, (byte)0x13);
        // 100D:4E5E jb short 0x4E6E
        if (CarryFlag)
        {
            goto label_100D_4E6E_14F3E_27922;
        }
    label_100D_4E60_14F30_36535:
        CheckExternalEvents(cs1, 0x4E60);
        // 100D:4E60 sub CL,0x28
        CL = Alu8.Sub(CL, (byte)0x28);
        // 100D:4E63 and CL,0xFB
        CL = Alu8.And(CL, (byte)0xFB);
        // 100D:4E66 add AL,CL
        AL = Alu8.Add(AL, CL);
        // 100D:4E68 cmp AL,0x17
        Alu8.Sub(AL, (byte)0x17);
        // 100D:4E6A jb short 0x4E6E
        if (CarryFlag)
        {
            goto label_100D_4E6E_14F3E_27922;
        }
    label_100D_4E6C_14F3C_42031:
        CheckExternalEvents(cs1, 0x4E6C);
        // 100D:4E6C mov AL,0x17
        AL = (byte)0x17;
    label_100D_4E6E_14F3E_27922:
        CheckExternalEvents(cs1, 0x4E6E);
        // 100D:4E6E mov word ptr DS:[0x196A],AX
        UInt16[DS, (ushort)0x196A] = AX;
        // 100D:4E71 xchg SI,DI
        ushort temp_100D_4E71_14F41 = SI;
        SI = DI;
        DI = unchecked((ushort)temp_100D_4E71_14F41);
        // 100D:4E73 call near 0x4DED
        NearCall(cs1, 0x4E76, unknown_100D_4DED_14EBD);
    label_100D_4E76_14F46_27941:
        CheckExternalEvents(cs1, 0x4E76);
        // 100D:4E76 xchg SI,DI
        ushort temp_100D_4E76_14F46 = SI;
        SI = DI;
        DI = unchecked((ushort)temp_100D_4E76_14F46);
    label_100D_4E78_14F48_20558:
        CheckExternalEvents(cs1, 0x4E78);
        // 100D:4E78 mov AX,word ptr DS:[0x196A]
        AX = UInt16[DS, (ushort)0x196A];
        // 100D:4E7B or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:4E7D je short 0x4E8C
        if (ZeroFlag)
        {
            goto label_100D_4E8C_14F5C_20562;
        }
    label_100D_4E7F_14F4F_27943:
        CheckExternalEvents(cs1, 0x4E7F);
        // 100D:4E7F mov CX,word ptr DS:[0x4733]
        CX = UInt16[DS, (ushort)0x4733];
        // 100D:4E83 mov CL,byte ptr DS:[0x46FF]
        CL = UInt8[DS, (ushort)0x46FF];
        // 100D:4E87 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:4E89 jcxz short 0x4E8C
        if (CX == (ushort)0x0000)
        {
            goto label_100D_4E8C_14F5C_20562;
        }
    label_100D_4E8B_14F5B_27948:
        CheckExternalEvents(cs1, 0x4E8B);
        // 100D:4E8B nop
    label_100D_4E8C_14F5C_20562:
        CheckExternalEvents(cs1, 0x4E8C);
        // 100D:4E8C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4EC6_14F96(int loadOffset)
    {
    entrydispatcher:
    label_100D_4EC6_14F96_20527:
        CheckExternalEvents(cs1, 0x4EC6);
        // 100D:4EC6 push BX
        Stack.Push16(BX);
        // 100D:4EC7 mov BX,word ptr DS:[0x487E]
        BX = UInt16[DS, (ushort)0x487E];
        // 100D:4ECB cmp BX,2
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:4ECE jb short 0x4EED
        if (CarryFlag)
        {
            goto label_100D_4EED_14FBD_20532;
        }
    label_100D_4ED0_14FA0_21660:
        CheckExternalEvents(cs1, 0x4ED0);
        // 100D:4ED0 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:4ED2 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:4ED4 mov AX,word ptr DS:[0xDC00]
        AX = UInt16[DS, (ushort)0xDC00];
        // 100D:4ED7 jae short 0x4EF3
        if (!CarryFlag)
        {
            goto label_100D_4EF3_14FC3_22342;
        }
    label_100D_4ED9_14FA9_21665:
        CheckExternalEvents(cs1, 0x4ED9);
        // 100D:4ED9 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:4EDC jbe short 0x4EED
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_4EED_14FBD_20532;
        }
    label_100D_4EDE_14FAE_21668:
        CheckExternalEvents(cs1, 0x4EDE);
        // 100D:4EDE mov BX,5
        BX = (ushort)0x0005;
        // 100D:4EE1 cmp AX,4
        Alu16.Sub(AX, (ushort)0x0004);
        // 100D:4EE4 jbe short 0x4EED
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_4EED_14FBD_20532;
        }
    label_100D_4EE6_14FB6_21672:
        CheckExternalEvents(cs1, 0x4EE6);
        // 100D:4EE6 mov BX,2
        BX = (ushort)0x0002;
        // 100D:4EE9 mov word ptr DS:[0x487E],BX
        UInt16[DS, (ushort)0x487E] = BX;
    label_100D_4EED_14FBD_20532:
        CheckExternalEvents(cs1, 0x4EED);
        // 100D:4EED mov word ptr DS:[0xDC02],BX
        UInt16[DS, (ushort)0xDC02] = BX;
        // 100D:4EF1 pop BX
        BX = Stack.Pop16();
        // 100D:4EF2 ret near
        return NearRet((ushort)0x0000);
    label_100D_4EF3_14FC3_22342:
        CheckExternalEvents(cs1, 0x4EF3);
        // 100D:4EF3 mov BX,3
        BX = (ushort)0x0003;
        // 100D:4EF6 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:4EF9 jbe short 0x4F03
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_4F03_14FD3_22346;
        }
    label_100D_4EFB_14FCB_22444:
        CheckExternalEvents(cs1, 0x4EFB);
        // 100D:4EFB cmp AX,5
        Alu16.Sub(AX, (ushort)0x0005);
        // 100D:4EFE je short 0x4F03
        if (ZeroFlag)
        {
            goto label_100D_4F03_14FD3_22346;
        }
    label_100D_4F00_14FD0_22447:
        CheckExternalEvents(cs1, 0x4F00);
        // 100D:4F00 mov BX,4
        BX = (ushort)0x0004;
    label_100D_4F03_14FD3_22346:
        CheckExternalEvents(cs1, 0x4F03);
        // 100D:4F03 mov word ptr DS:[0xDC02],BX
        UInt16[DS, (ushort)0xDC02] = BX;
        // 100D:4F07 pop BX
        BX = Stack.Pop16();
        // 100D:4F08 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4F0C_14FDC(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_4F0C_14FDC_14698;

    label_100D_4E8E_14F5E_22236:
        CheckExternalEvents(cs1, 0x4E8E);
        // 100D:4E8E mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:4E92 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:4E96 push word ptr DS:[0x11CC]
        Stack.Push16(UInt16[DS, (ushort)0x11CC]);
        // 100D:4E9A call near 0x5206
        NearCall(cs1, 0x4E9D, unknown_100D_5206_152D6);
    label_100D_4E9D_14F6D_22241:
        CheckExternalEvents(cs1, 0x4E9D);
        // 100D:4E9D call near 0x5206
        NearCall(cs1, 0x4EA0, unknown_100D_5206_152D6);
    label_100D_4EA0_14F70_22243:
        CheckExternalEvents(cs1, 0x4EA0);
        // 100D:4EA0 call near 0x5206
        NearCall(cs1, 0x4EA3, unknown_100D_5206_152D6);
    label_100D_4EA3_14F73_22245:
        CheckExternalEvents(cs1, 0x4EA3);
        // 100D:4EA3 call near 0x5206
        NearCall(cs1, 0x4EA6, unknown_100D_5206_152D6);
    label_100D_4EA6_14F76_22247:
        CheckExternalEvents(cs1, 0x4EA6);
        // 100D:4EA6 call near 0x5206
        NearCall(cs1, 0x4EA9, unknown_100D_5206_152D6);
    label_100D_4EA9_14F79_22250:
        CheckExternalEvents(cs1, 0x4EA9);
        // 100D:4EA9 call near 0x5206
        NearCall(cs1, 0x4EAC, unknown_100D_5206_152D6);
    label_100D_4EAC_14F7C_22252:
        CheckExternalEvents(cs1, 0x4EAC);
        // 100D:4EAC call near 0xB532
        NearCall(cs1, 0x4EAF, unknown_100D_B532_1B602);
    label_100D_4EAF_14F7F_22254:
        CheckExternalEvents(cs1, 0x4EAF);
        // 100D:4EAF push AX
        Stack.Push16(AX);
        // 100D:4EB0 call near 0x5206
        NearCall(cs1, 0x4EB3, unknown_100D_5206_152D6);
    label_100D_4EB3_14F83_22257:
        CheckExternalEvents(cs1, 0x4EB3);
        // 100D:4EB3 pop AX
        AX = Stack.Pop16();
        // 100D:4EB4 pop word ptr DS:[0x11CC]
        ushort popStackCheck_100D_4EB4_14F84 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_4EB4_14F84 = UInt16[DS, (ushort)0x11CC];
        ushort poppedValue_100D_4EB4_14F84 = Stack.Pop16();
        UInt16[DS, (ushort)0x11CC] = unchecked((ushort)poppedValue_100D_4EB4_14F84);
        // 100D:4EB8 push AX
        Stack.Push16(AX);
        // 100D:4EB9 call near 0xB532
        NearCall(cs1, 0x4EBC, unknown_100D_B532_1B602);
    label_100D_4EBC_14F8C_22262:
        CheckExternalEvents(cs1, 0x4EBC);
        // 100D:4EBC push AX
        Stack.Push16(AX);
        // 100D:4EBD call near 0x41E1
        NearCall(cs1, 0x4EC0, unknown_100D_41E1_142B1);
    label_100D_4EC0_14F90_22337:
        CheckExternalEvents(cs1, 0x4EC0);
        // 100D:4EC0 pop AX
        AX = Stack.Pop16();
        // 100D:4EC1 pop BX
        BX = Stack.Pop16();
        // 100D:4EC2 add AL,BL
        AL = Alu8.Add(AL, BL);
        // 100D:4EC4 shr AL,1
        AL = Alu8.Shr(AL, 1);
        if (JumpDispatcher.Jump(unknown_100D_4EC6_14F96, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_4F0C_14FDC_14698:
        CheckExternalEvents(cs1, 0x4F0C);
        // 100D:4F0C cmp byte ptr DS:[0x4727],0
        Alu8.Sub(UInt8[DS, (ushort)0x4727], (byte)0x00);
        // 100D:4F11 je short 0x4F33
        if (ZeroFlag)
        {
            goto label_100D_4F33_15003_14701;
        }
    label_100D_4F13_14FE3_22129:
        CheckExternalEvents(cs1, 0x4F13);
        // 100D:4F13 cmp byte ptr DS:[0x11CA],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CA], (byte)0x00);
        // 100D:4F18 jne short 0x4F33
        if (!ZeroFlag)
        {
            goto label_100D_4F33_15003_14701;
        }
    label_100D_4F1A_14FEA_22132:
        CheckExternalEvents(cs1, 0x4F1A);
        // 100D:4F1A mov word ptr DS:[0x1C06],0x0080
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0080;
        // 100D:4F20 mov AX,0xDBEC
        AX = (ushort)0xDBEC;
        // 100D:4F23 push AX
        Stack.Push16(AX);
        // 100D:4F24 call near 0xCA60
        NearCall(cs1, 0x4F27, unknown_100D_CA60_1CB30);
    label_100D_4F27_14FF7_22137:
        CheckExternalEvents(cs1, 0x4F27);
        // 100D:4F27 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:4F2A sub AX,word ptr DS:[0x4729]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4729]);
        // 100D:4F2E cmp AX,0x0300
        Alu16.Sub(AX, (ushort)0x0300);
        // 100D:4F31 jae short 0x4F34
        if (!CarryFlag)
        {
            goto label_100D_4F34_15004_22142;
        }
    label_100D_4F33_15003_14701:
        CheckExternalEvents(cs1, 0x4F33);
        // 100D:4F33 ret near
        return NearRet((ushort)0x0000);
    label_100D_4F34_15004_22142:
        CheckExternalEvents(cs1, 0x4F34);
        // 100D:4F34 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:4F37 mov word ptr DS:[0x4729],AX
        UInt16[DS, (ushort)0x4729] = AX;
        // 100D:4F3A call near 0x4B3B
        NearCall(cs1, 0x4F3D, unknown_100D_4B3B_14C0B);
    label_100D_4F3D_1500D_22146:
        CheckExternalEvents(cs1, 0x4F3D);
        // 100D:4F3D call near 0x4A1A
        NearCall(cs1, 0x4F40, unknown_100D_4A1A_14AEA);
    label_100D_4F40_15010_22169:
        CheckExternalEvents(cs1, 0x4F40);
        // 100D:4F40 call near 0x407E
        NearCall(cs1, 0x4F43, unknown_100D_407E_1414E);
    label_100D_4F43_15013_22171:
        CheckExternalEvents(cs1, 0x4F43);
        // 100D:4F43 call near 0x4A00
        NearCall(cs1, 0x4F46, unknown_100D_4A00_14AD0);
    label_100D_4F46_15016_22186:
        CheckExternalEvents(cs1, 0x4F46);
        // 100D:4F46 call near 0xB58B
        NearCall(cs1, 0x4F49, unknown_100D_B58B_1B65B);
    label_100D_4F49_15019_22188:
        CheckExternalEvents(cs1, 0x4F49);
        // 100D:4F49 mov SI,word ptr DS:[0x11C5]
        SI = UInt16[DS, (ushort)0x11C5];
        // 100D:4F4D cmp DI,word ptr DS:[SI+6]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:4F50 je short 0x4FB0
        if (ZeroFlag)
        {
            goto label_100D_4FB0_15080_22533;
        }
    label_100D_4F52_15022_22192:
        CheckExternalEvents(cs1, 0x4F52);
        // 100D:4F52 call near 0x2E52
        NearCall(cs1, 0x4F55, unknown_100D_2E52_12F22);
    label_100D_4F55_15025_22194:
        CheckExternalEvents(cs1, 0x4F55);
        // 100D:4F55 cmp byte ptr DS:[0x47A7],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A7], (byte)0x00);
        // 100D:4F5A jne short 0x4F33
        if (!ZeroFlag)
        {
            goto label_100D_4F33_15003_14701;
        }
    label_100D_4F5C_1502C_22197:
        CheckExternalEvents(cs1, 0x4F5C);
        // 100D:4F5C cmp byte ptr DS:[0x4728],0
        Alu8.Sub(UInt8[DS, (ushort)0x4728], (byte)0x00);
        // 100D:4F61 js short 0x4FAD
        if (SignFlag)
        {
            goto label_100D_4FAD_1507D_22234;
        }
    label_100D_4F63_15033_22200:
        CheckExternalEvents(cs1, 0x4F63);
        // 100D:4F63 je short 0x4F70
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4F63");
        }
    label_100D_4F70_15040_22202:
        CheckExternalEvents(cs1, 0x4F70);
        // 100D:4F70 call near 0x407E
        NearCall(cs1, 0x4F73, unknown_100D_407E_1414E);
    label_100D_4F73_15043_22204:
        CheckExternalEvents(cs1, 0x4F73);
        // 100D:4F73 call near 0x62D6
        NearCall(cs1, 0x4F76, unknown_100D_62D6_163A6);
    label_100D_4F76_15046_22206:
        CheckExternalEvents(cs1, 0x4F76);
        // 100D:4F76 jb short 0x4FAD
        if (CarryFlag)
        {
            goto label_100D_4FAD_1507D_22234;
        }
    label_100D_4F78_15048_22208:
        CheckExternalEvents(cs1, 0x4F78);
        // 100D:4F78 cmp DX,0x00D6
        Alu16.Sub(DX, (ushort)0x00D6);
        // 100D:4F7C jl short 0x4F8E
        if (SignFlag != OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4F7C");
        }
    label_100D_4F7E_1504E_22211:
        CheckExternalEvents(cs1, 0x4F7E);
        // 100D:4F7E cmp BX,0x000A
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:4F81 jl short 0x4F8E
        if (SignFlag != OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4F81");
        }
    label_100D_4F83_15053_22214:
        CheckExternalEvents(cs1, 0x4F83);
        // 100D:4F83 cmp DX,0x0132
        Alu16.Sub(DX, (ushort)0x0132);
        // 100D:4F87 jge short 0x4F8E
        if (SignFlag == OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4F87");
        }
    label_100D_4F89_15059_22217:
        CheckExternalEvents(cs1, 0x4F89);
        // 100D:4F89 cmp BX,0x0036
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)54)));
        // 100D:4F8C jl short 0x4F95
        if (!(SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4F8C");
        }
    label_100D_4F95_15065_22220:
        CheckExternalEvents(cs1, 0x4F95);
        // 100D:4F95 cmp byte ptr DS:[0x11CA],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CA], (byte)0x00);
        // 100D:4F9A jne short 0x4FAD
        if (!ZeroFlag)
        {
            goto label_100D_4FAD_1507D_22234;
        }
    label_100D_4F9C_1506C_22223:
        CheckExternalEvents(cs1, 0x4F9C);
        // 100D:4F9C dec BX
        BX = Alu16.Dec(BX);
        // 100D:4F9D dec DX
        DX = Alu16.Dec(DX);
        // 100D:4F9E call near 0xC137
        NearCall(cs1, 0x4FA1, unknown_100D_C137_1C207);
    label_100D_4FA1_15071_22227:
        CheckExternalEvents(cs1, 0x4FA1);
        // 100D:4FA1 mov AX,0x0030
        AX = (ushort)0x0030;
        // 100D:4FA4 call near 0xC085
        NearCall(cs1, 0x4FA7, unknown_100D_C085_1C155);
    label_100D_4FA7_15077_22230:
        CheckExternalEvents(cs1, 0x4FA7);
        // 100D:4FA7 call near 0xC22F
        NearCall(cs1, 0x4FAA, unknown_100D_C22F_1C2FF);
    label_100D_4FAA_1507A_22232:
        CheckExternalEvents(cs1, 0x4FAA);
        // 100D:4FAA call near 0xC07C
        NearCall(cs1, 0x4FAD, unknown_100D_C07C_1C14C);
    label_100D_4FAD_1507D_22234:
        CheckExternalEvents(cs1, 0x4FAD);
        // 100D:4FAD jmp near 0x4E8E
        goto label_100D_4E8E_14F5E_22236;
    label_100D_4FB0_15080_22533:
        CheckExternalEvents(cs1, 0x4FB0);
        // 100D:4FB0 mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:4FB6 mov AL,byte ptr DS:[0x11C9]
        AL = UInt8[DS, (ushort)0x11C9];
        // 100D:4FB9 and AL,1
        AL = Alu8.And(AL, (byte)0x01);
        // 100D:4FBB mov byte ptr DS:[0x4732],AL
        UInt8[DS, (ushort)0x4732] = AL;
        // 100D:4FBE jne short 0x4FC3
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x4FC3))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_4FC0_15090_35282:
        CheckExternalEvents(cs1, 0x4FC0);
        // 100D:4FC0 call near 0xCA01
        NearCall(cs1, 0x4FC3, unknown_100D_CA01_1CAD1);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x4FC3))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_503C_1510C(int loadOffset)
    {
    label_100D_503C_1510C_22588:
        CheckExternalEvents(cs1, 0x503C);
        // 100D:503C mov byte ptr DS:[0x00FD],0
        UInt8[DS, (ushort)0x00FD] = (byte)0x00;
        // 100D:5041 mov byte ptr DS:[0x002B],0
        UInt8[DS, (ushort)0x002B] = (byte)0x00;
        // 100D:5046 test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:504A jne short 0x5058
        if (!ZeroFlag)
        {
            goto label_100D_5058_15128_36180;
        }
    label_100D_504C_1511C_22593:
        CheckExternalEvents(cs1, 0x504C);
        // 100D:504C call near 0x5D36
        NearCall(cs1, 0x504F, unknown_100D_5D36_15E06);
    label_100D_504F_1511F_22595:
        CheckExternalEvents(cs1, 0x504F);
        // 100D:504F jb short 0x5081
        if (CarryFlag)
        {
            goto label_100D_5081_15151_22597;
        }
    label_100D_5051_15121_36175:
        CheckExternalEvents(cs1, 0x5051);
        // 100D:5051 call near 0x5098
        NearCall(cs1, 0x5054, unknown_100D_5098_15168);
    label_100D_5054_15124_36177:
        CheckExternalEvents(cs1, 0x5054);
        // 100D:5054 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:5056 je short 0x507A
        if (ZeroFlag)
        {
            goto label_100D_507A_1514A_37534;
        }
    label_100D_5058_15128_36180:
        CheckExternalEvents(cs1, 0x5058);
        // 100D:5058 inc byte ptr DS:[0x002B]
        UInt8[DS, (ushort)0x002B] = Alu8.Inc(UInt8[DS, (ushort)0x002B]);
        // 100D:505C call near 0x6144
        NearCall(cs1, 0x505F, unknown_100D_6144_16214);
    label_100D_505F_1512F_36196:
        CheckExternalEvents(cs1, 0x505F);
        // 100D:505F mov AL,byte ptr DS:[DI+8]
        AL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:5062 mov AH,0x2F
        AH = (byte)0x2F;
        // 100D:5064 cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:5066 jb short 0x5075
        if (CarryFlag)
        {
            goto label_100D_5075_15145_36210;
        }
    label_100D_5068_15138_36201:
        CheckExternalEvents(cs1, 0x5068);
        // 100D:5068 inc AH
        AH = Alu8.Inc(AH);
        // 100D:506A cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:506C je short 0x5075
        if (ZeroFlag)
        {
            goto label_100D_5075_15145_36210;
        }
    label_100D_506E_1513E_36205:
        CheckExternalEvents(cs1, 0x506E);
        // 100D:506E sub AL,0x28
        AL = Alu8.Sub(AL, (byte)0x28);
        // 100D:5070 jb short 0x5075
        if (CarryFlag)
        {
            goto label_100D_5075_15145_36210;
        }
    label_100D_5072_15142_36208:
        CheckExternalEvents(cs1, 0x5072);
        // 100D:5072 add AH,3
        AH = Alu8.Add(AH, (byte)0x03);
    label_100D_5075_15145_36210:
        CheckExternalEvents(cs1, 0x5075);
        // 100D:5075 mov byte ptr DS:[0x11DD],AH
        UInt8[DS, (ushort)0x11DD] = AH;
        // 100D:5079 ret near
        return NearRet((ushort)0x0000);
    label_100D_507A_1514A_37534:
        CheckExternalEvents(cs1, 0x507A);
        // 100D:507A jcxz short 0x5081
        if (CX == (ushort)0x0000)
        {
            goto label_100D_5081_15151_22597;
        }
    label_100D_507C_1514C_37537:
        CheckExternalEvents(cs1, 0x507C);
        // 100D:507C mov byte ptr DS:[0x46D9],4
        UInt8[DS, (ushort)0x46D9] = (byte)0x04;
    label_100D_5081_15151_22597:
        CheckExternalEvents(cs1, 0x5081);
        // 100D:5081 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5082_15152(int loadOffset)
    {
    label_100D_5082_15152_34193:
        CheckExternalEvents(cs1, 0x5082);
        // 100D:5082 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:5086 jne short 0x5095
        if (!ZeroFlag)
        {
            goto label_100D_5095_15165_34460;
        }
    label_100D_5088_15158_34196:
        CheckExternalEvents(cs1, 0x5088);
        // 100D:5088 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:508C jne short 0x5096
        if (!ZeroFlag)
        {
            goto label_100D_5096_15166_34199;
        }
    label_100D_508E_1515E_36134:
        CheckExternalEvents(cs1, 0x508E);
        // 100D:508E cmp byte ptr DS:[SI+3],6
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x06);
        // 100D:5092 jne short 0x5095
        if (!ZeroFlag)
        {
            goto label_100D_5095_15165_34460;
        }
    label_100D_5094_15164_36137:
        CheckExternalEvents(cs1, 0x5094);
        // 100D:5094 inc DX
        DX = Alu16.Inc(DX);
    label_100D_5095_15165_34460:
        CheckExternalEvents(cs1, 0x5095);
        // 100D:5095 ret near
        return NearRet((ushort)0x0000);
    label_100D_5096_15166_34199:
        CheckExternalEvents(cs1, 0x5096);
        // 100D:5096 inc CX
        CX = Alu16.Inc(CX);
        // 100D:5097 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5098_15168(int loadOffset)
    {
    entrydispatcher:
    label_100D_5098_15168_34188:
        CheckExternalEvents(cs1, 0x5098);
        // 100D:5098 mov BP,0x5082
        BP = (ushort)0x5082;
        // 100D:509B xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:509D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:509F jmp near 0x6603
        if (JumpDispatcher.Jump(unknown_100D_6603_166D3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_50BE_1518E(int loadOffset)
    {
    label_100D_50BE_1518E_21487:
        CheckExternalEvents(cs1, 0x50BE);
        // 100D:50BE mov byte ptr DS:[0x11CB],0
        UInt8[DS, (ushort)0x11CB] = (byte)0x00;
        // 100D:50C3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5124_151F4(int loadOffset)
    {
    label_100D_5124_151F4_21495:
        CheckExternalEvents(cs1, 0x5124);
        // 100D:5124 push DI
        Stack.Push16(DI);
        // 100D:5125 call near 0x407E
        NearCall(cs1, 0x5128, unknown_100D_407E_1414E);
    label_100D_5128_151F8_21498:
        CheckExternalEvents(cs1, 0x5128);
        // 100D:5128 mov CX,word ptr DS:[DI+4]
        CX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:512B mov DI,word ptr DS:[DI+2]
        DI = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:512E call near 0x5133
        NearCall(cs1, 0x5131, unknown_100D_5133_15203);
    label_100D_5131_15201_21502:
        CheckExternalEvents(cs1, 0x5131);
        // 100D:5131 pop DI
        DI = Stack.Pop16();
        // 100D:5132 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5133_15203(int loadOffset)
    {
    label_100D_5133_15203_13870:
        CheckExternalEvents(cs1, 0x5133);
        // 100D:5133 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:5135 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:5137 sub DX,DI
        DX = Alu16.Sub(DX, DI);
        // 100D:5139 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:513B cmp BX,-128
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-128)));
        // 100D:513E jl short 0x5146
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_5146_15216_13926;
        }
    label_100D_5140_15210_13877:
        CheckExternalEvents(cs1, 0x5140);
        // 100D:5140 cmp BX,0x0080
        Alu16.Sub(BX, (ushort)0x0080);
        // 100D:5144 jl short 0x514A
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_514A_1521A_13880;
        }
    label_100D_5146_15216_13926:
        CheckExternalEvents(cs1, 0x5146);
        // 100D:5146 sar BX,1
        BX = Alu16.Sar(BX, 1);
        // 100D:5148 sar DX,1
        DX = Alu16.Sar(DX, 1);
    label_100D_514A_1521A_13880:
        CheckExternalEvents(cs1, 0x514A);
        // 100D:514A mov BH,BL
        BH = BL;
        // 100D:514C xor BL,BL
        BL = Alu8.Xor(BL, BL);
        return unknown_100D_514E_1521E(0x0000);
    }

    public virtual Action unknown_100D_514E_1521E(int loadOffset)
    {
    label_100D_514E_1521E_13883:
        CheckExternalEvents(cs1, 0x514E);
        // 100D:514E or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:5150 mov AX,BX
        AX = BX;
        // 100D:5152 jns short 0x5156
        if (!SignFlag)
        {
            goto label_100D_5156_15226_13888;
        }
    label_100D_5154_15224_13886:
        CheckExternalEvents(cs1, 0x5154);
        // 100D:5154 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_5156_15226_13888:
        CheckExternalEvents(cs1, 0x5156);
        // 100D:5156 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:5158 mov DI,DX
        DI = DX;
        // 100D:515A mov CX,DX
        CX = DX;
        // 100D:515C jns short 0x5160
        if (!SignFlag)
        {
            goto label_100D_5160_15230_13892;
        }
    label_100D_515E_1522E_13930:
        CheckExternalEvents(cs1, 0x515E);
        // 100D:515E neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_5160_15230_13892:
        CheckExternalEvents(cs1, 0x5160);
        // 100D:5160 cmp CX,AX
        Alu16.Sub(CX, AX);
        // 100D:5162 jb short 0x5180
        if (CarryFlag)
        {
            goto label_100D_5180_15250_13895;
        }
    label_100D_5164_15234_13932:
        CheckExternalEvents(cs1, 0x5164);
        // 100D:5164 cmp CX,1
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:5167 jb short 0x517F
        if (CarryFlag)
        {
            goto label_100D_517F_1524F_13946;
        }
    label_100D_5169_15239_13935:
        CheckExternalEvents(cs1, 0x5169);
        // 100D:5169 mov AX,0x0020
        AX = (ushort)0x0020;
        // 100D:516C mov CX,DX
        CX = DX;
        // 100D:516E imul BX
        int result_100D_516E_1523E = Alu16.Imul(unchecked((short)AX), unchecked((short)BX));
        DX = unchecked((ushort)(result_100D_516E_1523E >> 16));
        AX = unchecked((ushort)result_100D_516E_1523E);
        // 100D:5170 idiv CX
        short divisor_100D_5170_15240 = unchecked((short)CX);
        int dividend_100D_5170_15240 = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_5170_15240 = Alu16.Idiv(unchecked((int)dividend_100D_5170_15240), unchecked((short)divisor_100D_5170_15240));
        AX = unchecked((ushort)quotient_100D_5170_15240);
        DX = unchecked((ushort)(dividend_100D_5170_15240 % unchecked((int)divisor_100D_5170_15240)));
        // 100D:5172 mov DX,DI
        DX = DI;
        // 100D:5174 or CX,CX
        CX = Alu16.Or(CX, CX);
        // 100D:5176 js short 0x517C
        if (SignFlag)
        {
            goto label_100D_517C_1524C_13943;
        }
    label_100D_5178_15248_13952:
        CheckExternalEvents(cs1, 0x5178);
        // 100D:5178 add AL,0x40
        AL = Alu8.Add(AL, (byte)0x40);
        // 100D:517A clc
        CarryFlag = false;
        // 100D:517B ret near
        return NearRet((ushort)0x0000);
    label_100D_517C_1524C_13943:
        CheckExternalEvents(cs1, 0x517C);
        // 100D:517C add AL,0xC0
        AL = Alu8.Add(AL, (byte)0xC0);
        // 100D:517E clc
        CarryFlag = false;
    label_100D_517F_1524F_13946:
        CheckExternalEvents(cs1, 0x517F);
        // 100D:517F ret near
        return NearRet((ushort)0x0000);
    label_100D_5180_15250_13895:
        CheckExternalEvents(cs1, 0x5180);
        // 100D:5180 cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:5183 jb short 0x517F
        if (CarryFlag)
        {
            goto label_100D_517F_1524F_13946;
        }
    label_100D_5185_15255_13898:
        CheckExternalEvents(cs1, 0x5185);
        // 100D:5185 mov AX,0x0020
        AX = (ushort)0x0020;
        // 100D:5188 imul DX
        int result_100D_5188_15258 = Alu16.Imul(unchecked((short)AX), unchecked((short)DX));
        DX = unchecked((ushort)(result_100D_5188_15258 >> 16));
        AX = unchecked((ushort)result_100D_5188_15258);
        // 100D:518A idiv BX
        short divisor_100D_518A_1525A = unchecked((short)BX);
        int dividend_100D_518A_1525A = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_518A_1525A = Alu16.Idiv(unchecked((int)dividend_100D_518A_1525A), unchecked((short)divisor_100D_518A_1525A));
        AX = unchecked((ushort)quotient_100D_518A_1525A);
        DX = unchecked((ushort)(dividend_100D_518A_1525A % unchecked((int)divisor_100D_518A_1525A)));
        // 100D:518C mov DX,DI
        DX = DI;
        // 100D:518E or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:5190 js short 0x5194
        if (SignFlag)
        {
            goto label_100D_5194_15264_13905;
        }
    label_100D_5192_15262_21226:
        CheckExternalEvents(cs1, 0x5192);
        // 100D:5192 sub AL,0x80
        AL = Alu8.Sub(AL, (byte)0x80);
    label_100D_5194_15264_13905:
        CheckExternalEvents(cs1, 0x5194);
        // 100D:5194 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
        // 100D:5196 clc
        CarryFlag = false;
        // 100D:5197 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5198_15268(int loadOffset)
    {
    label_100D_5198_15268_21861:
        CheckExternalEvents(cs1, 0x5198);
        // 100D:5198 mov BX,AX
        BX = AX;
        // 100D:519A add BL,0x20
        BL = Alu8.Add(BL, (byte)0x20);
        // 100D:519D mov BH,BL
        BH = BL;
        // 100D:519F and BH,0x7F
        BH = Alu8.And(BH, (byte)0x7F);
        // 100D:51A2 cmp BH,0x40
        Alu8.Sub(BH, (byte)0x40);
        // 100D:51A5 jb short 0x51BA
        if (CarryFlag)
        {
            goto label_100D_51BA_1528A_21868;
        }
    label_100D_51A7_15277_22421:
        CheckExternalEvents(cs1, 0x51A7);
        // 100D:51A7 mov DX,0x0020
        DX = (ushort)0x0020;
        // 100D:51AA sub AL,0x40
        AL = Alu8.Sub(AL, (byte)0x40);
        // 100D:51AC or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:51AE jns short 0x51B6
        if (!SignFlag)
        {
            goto label_100D_51B6_15286_22426;
        }
    label_100D_51B0_15280_28249:
        CheckExternalEvents(cs1, 0x51B0);
        // 100D:51B0 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:51B2 sub AL,0x80
        AL = Alu8.Sub(AL, (byte)0x80);
        // 100D:51B4 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_51B6_15286_22426:
        CheckExternalEvents(cs1, 0x51B6);
        // 100D:51B6 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:51B7 mov BX,AX
        BX = AX;
        // 100D:51B9 ret near
        return NearRet((ushort)0x0000);
    label_100D_51BA_1528A_21868:
        CheckExternalEvents(cs1, 0x51BA);
        // 100D:51BA or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:51BC mov BX,0xFFE0
        BX = (ushort)0xFFE0;
        // 100D:51BF jns short 0x51C7
        if (!SignFlag)
        {
            goto label_100D_51C7_15297_21876;
        }
    label_100D_51C1_15291_21872:
        CheckExternalEvents(cs1, 0x51C1);
        // 100D:51C1 sub AL,0x80
        AL = Alu8.Sub(AL, (byte)0x80);
        // 100D:51C3 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
        // 100D:51C5 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_51C7_15297_21876:
        CheckExternalEvents(cs1, 0x51C7);
        // 100D:51C7 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:51C8 mov DX,AX
        DX = AX;
        // 100D:51CA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_51CB_1529B(int loadOffset)
    {
    label_100D_51CB_1529B_21833:
        CheckExternalEvents(cs1, 0x51CB);
        // 100D:51CB cmp byte ptr DS:[0x11CB],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CB], (byte)0x00);
        // 100D:51D0 jne short 0x51D9
        if (!ZeroFlag)
        {
            goto label_100D_51D9_152A9_27062;
        }
    label_100D_51D2_152A2_21836:
        CheckExternalEvents(cs1, 0x51D2);
        // 100D:51D2 cmp byte ptr DS:[0x11C8],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C8], (byte)0x00);
        // 100D:51D7 je short 0x51F5
        if (ZeroFlag)
        {
            goto label_100D_51F5_152C5_21839;
        }
    label_100D_51D9_152A9_27062:
        CheckExternalEvents(cs1, 0x51D9);
        // 100D:51D9 cmp BX,-77
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-77)));
        // 100D:51DC jl short 0x51E3
        if (SignFlag != OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:51DC");
        }
    label_100D_51DE_152AE_27065:
        CheckExternalEvents(cs1, 0x51DE);
        // 100D:51DE cmp BX,0x004D
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)77)));
        // 100D:51E1 jle short 0x5205
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_5205_152D5_21850;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:51E1");
        }
    label_100D_51F5_152C5_21839:
        CheckExternalEvents(cs1, 0x51F5);
        // 100D:51F5 mov DI,word ptr DS:[0x11C5]
        DI = UInt16[DS, (ushort)0x11C5];
        // 100D:51F9 push BX
        Stack.Push16(BX);
        // 100D:51FA push DX
        Stack.Push16(DX);
        // 100D:51FB call near 0x5124
        NearCall(cs1, 0x51FE, unknown_100D_5124_151F4);
    label_100D_51FE_152CE_21844:
        CheckExternalEvents(cs1, 0x51FE);
        // 100D:51FE pop DX
        DX = Stack.Pop16();
        // 100D:51FF pop BX
        BX = Stack.Pop16();
        // 100D:5200 jb short 0x5205
        if (CarryFlag)
        {
            goto label_100D_5205_152D5_21850;
        }
    label_100D_5202_152D2_21848:
        CheckExternalEvents(cs1, 0x5202);
        // 100D:5202 mov byte ptr DS:[0x11C7],AL
        UInt8[DS, (ushort)0x11C7] = AL;
    label_100D_5205_152D5_21850:
        CheckExternalEvents(cs1, 0x5205);
        // 100D:5205 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5206_152D6(int loadOffset)
    {
    label_100D_5206_152D6_21831:
        CheckExternalEvents(cs1, 0x5206);
        // 100D:5206 call near 0x51CB
        NearCall(cs1, 0x5209, unknown_100D_51CB_1529B);
    label_100D_5209_152D9_21851:
        CheckExternalEvents(cs1, 0x5209);
        // 100D:5209 mov AL,byte ptr DS:[0x11C7]
        AL = UInt8[DS, (ushort)0x11C7];
        // 100D:520C push DX
        Stack.Push16(DX);
        // 100D:520D push BX
        Stack.Push16(BX);
        // 100D:520E shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:5210 jns short 0x5214
        if (!SignFlag)
        {
            goto label_100D_5214_152E4_21859;
        }
    label_100D_5212_152E2_21857:
        CheckExternalEvents(cs1, 0x5212);
        // 100D:5212 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_5214_152E4_21859:
        CheckExternalEvents(cs1, 0x5214);
        // 100D:5214 mov BP,word ptr DS:[BX+0x4880]
        BP = UInt16[DS, (ushort)(BX + (short)18560)];
        // 100D:5218 call near 0x5198
        NearCall(cs1, 0x521B, unknown_100D_5198_15268);
    label_100D_521B_152EB_21879:
        CheckExternalEvents(cs1, 0x521B);
        // 100D:521B mov CX,0x0020
        CX = (ushort)0x0020;
        // 100D:521E mov AX,BP
        AX = BP;
        // 100D:5220 imul DX
        int result_100D_5220_152F0 = Alu16.Imul(unchecked((short)AX), unchecked((short)DX));
        DX = unchecked((ushort)(result_100D_5220_152F0 >> 16));
        AX = unchecked((ushort)result_100D_5220_152F0);
        // 100D:5222 idiv CX
        short divisor_100D_5222_152F2 = unchecked((short)CX);
        int dividend_100D_5222_152F2 = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_5222_152F2 = Alu16.Idiv(unchecked((int)dividend_100D_5222_152F2), unchecked((short)divisor_100D_5222_152F2));
        AX = unchecked((ushort)quotient_100D_5222_152F2);
        DX = unchecked((ushort)(dividend_100D_5222_152F2 % unchecked((int)divisor_100D_5222_152F2)));
        // 100D:5224 xchg BX,AX
        ushort temp_100D_5224_152F4 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_5224_152F4);
        // 100D:5225 imul BP
        int result_100D_5225_152F5 = Alu16.Imul(unchecked((short)AX), unchecked((short)BP));
        DX = unchecked((ushort)(result_100D_5225_152F5 >> 16));
        AX = unchecked((ushort)result_100D_5225_152F5);
        // 100D:5227 idiv CX
        short divisor_100D_5227_152F7 = unchecked((short)CX);
        int dividend_100D_5227_152F7 = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_5227_152F7 = Alu16.Idiv(unchecked((int)dividend_100D_5227_152F7), unchecked((short)divisor_100D_5227_152F7));
        AX = unchecked((ushort)quotient_100D_5227_152F7);
        DX = unchecked((ushort)(dividend_100D_5227_152F7 % unchecked((int)divisor_100D_5227_152F7)));
        // 100D:5229 mov DX,BX
        DX = BX;
        // 100D:522B mov BX,AX
        BX = AX;
        // 100D:522D or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:522F jns short 0x5233
        if (!SignFlag)
        {
            goto label_100D_5233_15303_21891;
        }
    label_100D_5231_15301_25242:
        CheckExternalEvents(cs1, 0x5231);
        // 100D:5231 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_5233_15303_21891:
        CheckExternalEvents(cs1, 0x5233);
        // 100D:5233 add AX,word ptr DS:[0x11CC]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x11CC]);
        // 100D:5237 cmp AH,1
        Alu8.Sub(AH, (byte)0x01);
        // 100D:523A jbe short 0x524E
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_524E_1531E_21895;
        }
    label_100D_523C_1530C_34963:
        CheckExternalEvents(cs1, 0x523C);
        // 100D:523C mov CX,AX
        CX = AX;
        // 100D:523E mov AX,DX
        AX = DX;
        // 100D:5240 cwd
        DX = unchecked((ushort)(unchecked((short)AX) >> 15));
        // 100D:5241 mov DL,AH
        DL = AH;
        // 100D:5243 mov AH,AL
        AH = AL;
        // 100D:5245 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:5247 idiv CX
        short divisor_100D_5247_15317 = unchecked((short)CX);
        int dividend_100D_5247_15317 = unchecked((int)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        short quotient_100D_5247_15317 = Alu16.Idiv(unchecked((int)dividend_100D_5247_15317), unchecked((short)divisor_100D_5247_15317));
        AX = unchecked((ushort)quotient_100D_5247_15317);
        DX = unchecked((ushort)(dividend_100D_5247_15317 % unchecked((int)divisor_100D_5247_15317)));
        // 100D:5249 mov DX,AX
        DX = AX;
        // 100D:524B mov AX,0x0100
        AX = (ushort)0x0100;
    label_100D_524E_1531E_21895:
        CheckExternalEvents(cs1, 0x524E);
        // 100D:524E mov byte ptr DS:[0x11CC],AL
        UInt8[DS, (ushort)0x11CC] = AL;
        // 100D:5251 mov AL,AH
        AL = AH;
        // 100D:5253 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:5254 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:5256 jns short 0x525A
        if (!SignFlag)
        {
            goto label_100D_525A_1532A_21901;
        }
    label_100D_5258_15328_25244:
        CheckExternalEvents(cs1, 0x5258);
        // 100D:5258 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_525A_1532A_21901:
        CheckExternalEvents(cs1, 0x525A);
        // 100D:525A pop BX
        BX = Stack.Pop16();
        // 100D:525B add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:525D pop AX
        AX = Stack.Pop16();
        // 100D:525E add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:5260 mov AX,BX
        AX = BX;
        // 100D:5262 add AX,0x0060
        AX = Alu16.Add(AX, (ushort)0x0060);
        // 100D:5265 cmp AX,0x00C0
        Alu16.Sub(AX, (ushort)0x00C0);
        // 100D:5268 jb short 0x5273
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5268");
        }
    label_100D_5273_15343_21910:
        CheckExternalEvents(cs1, 0x5273);
        // 100D:5273 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5274_15344(int loadOffset)
    {
    label_100D_5274_15344_13789:
        CheckExternalEvents(cs1, 0x5274);
        // 100D:5274 mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:5277 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:527A push SI
        Stack.Push16(SI);
        // 100D:527B mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:527E mov word ptr DS:[0x00CA],AX
        UInt16[DS, (ushort)0x00CA] = AX;
        // 100D:5281 mov word ptr DS:[0x00D0],AX
        UInt16[DS, (ushort)0x00D0] = AX;
        // 100D:5284 mov word ptr DS:[0x00D6],AX
        UInt16[DS, (ushort)0x00D6] = AX;
        // 100D:5287 mov word ptr DS:[0x00DC],AX
        UInt16[DS, (ushort)0x00DC] = AX;
        // 100D:528A mov word ptr DS:[0x00E2],AX
        UInt16[DS, (ushort)0x00E2] = AX;
        // 100D:528D mov SI,0x0100
        SI = (ushort)0x0100;
    label_100D_5290_15360_13800:
        CheckExternalEvents(cs1, 0x5290);
        // 100D:5290 cmp word ptr DS:[SI],-1
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:5293 je short 0x52FB
        if (ZeroFlag)
        {
            goto label_100D_52FB_153CB_13858;
        }
    label_100D_5295_15365_13802:
        CheckExternalEvents(cs1, 0x5295);
        // 100D:5295 cmp SI,DI
        Alu16.Sub(SI, DI);
        // 100D:5297 je short 0x52F6
        if (ZeroFlag)
        {
            goto label_100D_52F6_153C6_13805;
        }
    label_100D_5299_15369_13809:
        CheckExternalEvents(cs1, 0x5299);
        // 100D:5299 mov CX,word ptr DS:[SI+2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:529C sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 100D:529E jns short 0x52A2
        if (!SignFlag)
        {
            goto label_100D_52A2_15372_13813;
        }
    label_100D_52A0_15370_13846:
        CheckExternalEvents(cs1, 0x52A0);
        // 100D:52A0 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_52A2_15372_13813:
        CheckExternalEvents(cs1, 0x52A2);
        // 100D:52A2 mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:52A5 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:52A7 jns short 0x52AB
        if (!SignFlag)
        {
            goto label_100D_52AB_1537B_13819;
        }
    label_100D_52A9_15379_13817:
        CheckExternalEvents(cs1, 0x52A9);
        // 100D:52A9 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_52AB_1537B_13819:
        CheckExternalEvents(cs1, 0x52AB);
        // 100D:52AB mov CL,CH
        CL = CH;
        // 100D:52AD xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:52AF cmp CL,AL
        Alu8.Sub(CL, AL);
        // 100D:52B1 jae short 0x52B5
        if (!CarryFlag)
        {
            goto label_100D_52B5_15385_13825;
        }
    label_100D_52B3_15383_13823:
        CheckExternalEvents(cs1, 0x52B3);
        // 100D:52B3 mov CX,AX
        CX = AX;
    label_100D_52B5_15385_13825:
        CheckExternalEvents(cs1, 0x52B5);
        // 100D:52B5 cmp byte ptr DS:[SI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)8)], (byte)0x28);
        // 100D:52B9 jb short 0x52C9
        if (CarryFlag)
        {
            goto label_100D_52C9_15399_13848;
        }
    label_100D_52BB_1538B_13827:
        CheckExternalEvents(cs1, 0x52BB);
        // 100D:52BB mov BP,0x00E2
        BP = (ushort)0x00E2;
        // 100D:52BE test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:52C2 jne short 0x52DD
        if (!ZeroFlag)
        {
            goto label_100D_52DD_153AD_13834;
        }
    label_100D_52C4_15394_13831:
        CheckExternalEvents(cs1, 0x52C4);
        // 100D:52C4 mov BP,0x00DC
        BP = (ushort)0x00DC;
        // 100D:52C7 jmp short 0x52DD
        goto label_100D_52DD_153AD_13834;
    label_100D_52C9_15399_13848:
        CheckExternalEvents(cs1, 0x52C9);
        // 100D:52C9 mov BP,0x00D0
        BP = (ushort)0x00D0;
        // 100D:52CC test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:52D0 je short 0x52DD
        if (ZeroFlag)
        {
            goto label_100D_52DD_153AD_13834;
        }
    label_100D_52D2_153A2_13852:
        CheckExternalEvents(cs1, 0x52D2);
        // 100D:52D2 mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:52D5 cmp AL,byte ptr DS:[SI+0x0B]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)11)]);
        // 100D:52D8 jb short 0x52F6
        if (CarryFlag)
        {
            goto label_100D_52F6_153C6_13805;
        }
    label_100D_52DA_153AA_26984:
        CheckExternalEvents(cs1, 0x52DA);
        // 100D:52DA mov BP,0x00D6
        BP = (ushort)0x00D6;
    label_100D_52DD_153AD_13834:
        CheckExternalEvents(cs1, 0x52DD);
        // 100D:52DD cmp CX,word ptr SS:[BP]
        Alu16.Sub(CX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 100D:52E0 jae short 0x52E8
        if (!CarryFlag)
        {
            goto label_100D_52E8_153B8_13840;
        }
    label_100D_52E2_153B2_13837:
        CheckExternalEvents(cs1, 0x52E2);
        // 100D:52E2 mov word ptr SS:[BP],CX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = CX;
        // 100D:52E5 mov word ptr SS:[BP+2],SI
        UInt16[SS, (ushort)(BP + (sbyte)2)] = SI;
    label_100D_52E8_153B8_13840:
        CheckExternalEvents(cs1, 0x52E8);
        // 100D:52E8 cmp CX,word ptr DS:[0x00CA]
        Alu16.Sub(CX, UInt16[DS, (ushort)0x00CA]);
        // 100D:52EC jae short 0x52F6
        if (!CarryFlag)
        {
            goto label_100D_52F6_153C6_13805;
        }
    label_100D_52EE_153BE_13842:
        CheckExternalEvents(cs1, 0x52EE);
        // 100D:52EE mov word ptr DS:[0x00CA],CX
        UInt16[DS, (ushort)0x00CA] = CX;
        // 100D:52F2 mov word ptr DS:[0x00CC],SI
        UInt16[DS, (ushort)0x00CC] = SI;
    label_100D_52F6_153C6_13805:
        CheckExternalEvents(cs1, 0x52F6);
        // 100D:52F6 add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:52F9 jmp short 0x5290
        goto label_100D_5290_15360_13800;
    label_100D_52FB_153CB_13858:
        CheckExternalEvents(cs1, 0x52FB);
        // 100D:52FB push DI
        Stack.Push16(DI);
        // 100D:52FC mov BP,0x00DE
        BP = (ushort)0x00DE;
        // 100D:52FF call near 0x5323
        NearCall(cs1, 0x5302, unknown_100D_5323_153F3);
    label_100D_5302_153D2_13920:
        CheckExternalEvents(cs1, 0x5302);
        // 100D:5302 mov BP,0x00E4
        BP = (ushort)0x00E4;
        // 100D:5305 call near 0x5323
        NearCall(cs1, 0x5308, unknown_100D_5323_153F3);
    label_100D_5308_153D8_13923:
        CheckExternalEvents(cs1, 0x5308);
        // 100D:5308 mov BP,0x00D8
        BP = (ushort)0x00D8;
        // 100D:530B call near 0x5323
        NearCall(cs1, 0x530E, unknown_100D_5323_153F3);
    label_100D_530E_153DE_13947:
        CheckExternalEvents(cs1, 0x530E);
        // 100D:530E add AX,0x00DA
        AX = Alu16.Add(AX, (ushort)0x00DA);
        // 100D:5311 mov word ptr DS:[0x11FD],AX
        UInt16[DS, (ushort)0x11FD] = AX;
        // 100D:5314 mov BP,0x00CC
        BP = (ushort)0x00CC;
        // 100D:5317 call near 0x5323
        NearCall(cs1, 0x531A, unknown_100D_5323_153F3);
    label_100D_531A_153EA_13956:
        CheckExternalEvents(cs1, 0x531A);
        // 100D:531A mov BP,0x00D2
        BP = (ushort)0x00D2;
        // 100D:531D call near 0x5323
        NearCall(cs1, 0x5320, unknown_100D_5323_153F3);
    label_100D_5320_153F0_13959:
        CheckExternalEvents(cs1, 0x5320);
        // 100D:5320 pop DI
        DI = Stack.Pop16();
        // 100D:5321 pop SI
        SI = Stack.Pop16();
        // 100D:5322 ret near
        return NearRet((ushort)0x0000);
    }
}
