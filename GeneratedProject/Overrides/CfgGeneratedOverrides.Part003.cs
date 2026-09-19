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
    public virtual Action unknown_100D_0ED0_10FA0(int loadOffset)
    {
    entrydispatcher:
    label_100D_0ED0_10FA0_19962:
        CheckExternalEvents(cs1, 0x0ED0);
        // 100D:0ED0 mov AL,0x3B
        AL = (byte)0x3B;
        // 100D:0ED2 call near 0xC2F2
        NearCall(cs1, 0x0ED5, unknown_100D_C2F2_1C3C2);
    label_100D_0ED5_10FA5_19965:
        CheckExternalEvents(cs1, 0x0ED5);
        // 100D:0ED5 mov AX,1
        AX = (ushort)0x0001;
        // 100D:0ED8 call near 0xC22F
        NearCall(cs1, 0x0EDB, unknown_100D_C22F_1C2FF);
    label_100D_0EDB_10FAB_19968:
        CheckExternalEvents(cs1, 0x0EDB);
        // 100D:0EDB call near 0x0F08
        NearCall(cs1, 0x0EDE, unknown_100D_0F08_10FD8);
    label_100D_0EDE_10FAE_19975:
        CheckExternalEvents(cs1, 0x0EDE);
        // 100D:0EDE mov AX,0x003B
        AX = (ushort)0x003B;
        // 100D:0EE1 call near 0xC13E
        NearCall(cs1, 0x0EE4, unknown_100D_C13E_1C20E);
    label_100D_0EE4_10FB4_19978:
        CheckExternalEvents(cs1, 0x0EE4);
        // 100D:0EE4 mov AX,2
        AX = (ushort)0x0002;
        // 100D:0EE7 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:0EE9 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:0EEB call near 0xC22F
        NearCall(cs1, 0x0EEE, unknown_100D_C22F_1C2FF);
    label_100D_0EEE_10FBE_19983:
        CheckExternalEvents(cs1, 0x0EEE);
        // 100D:0EEE call near 0x1797
        NearCall(cs1, 0x0EF1, unknown_100D_1797_11867);
    label_100D_0EF1_10FC1_19985:
        CheckExternalEvents(cs1, 0x0EF1);
        // 100D:0EF1 mov SI,0x1D1E
        SI = (ushort)0x1D1E;
        // 100D:0EF4 call near 0xD72B
        NearCall(cs1, 0x0EF7, unknown_100D_D72B_1D7FB);
    label_100D_0EF7_10FC7_19988:
        CheckExternalEvents(cs1, 0x0EF7);
        // 100D:0EF7 call near 0x98F5
        NearCall(cs1, 0x0EFA, unknown_100D_98F5_199C5);
    label_100D_0EFA_10FCA_19990:
        CheckExternalEvents(cs1, 0x0EFA);
        // 100D:0EFA mov byte ptr DS:[0x1C06],0x80
        UInt8[DS, (ushort)0x1C06] = (byte)0x80;
        // 100D:0EFF mov BP,0x20C2
        BP = (ushort)0x20C2;
        // 100D:0F02 mov BX,0x0EB9
        BX = (ushort)0x0EB9;
        // 100D:0F05 jmp near 0xD338
        if (JumpDispatcher.Jump(unknown_100D_D338_1D408, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0F08_10FD8(int loadOffset)
    {
    entrydispatcher:
    label_100D_0F08_10FD8_19970:
        CheckExternalEvents(cs1, 0x0F08);
        // 100D:0F08 test word ptr DS:[0x0010],0x0080
        Alu16.And(UInt16[DS, (ushort)0x0010], (ushort)0x0080);
        // 100D:0F0E jne short 0x0F13
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_0F13_10FE3, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_0F10_10FE0_19973:
        CheckExternalEvents(cs1, 0x0F10);
        // 100D:0F10 jmp near 0x0960
        if (JumpDispatcher.Jump(unknown_100D_0960_10A30, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0F66_11036(int loadOffset)
    {
    label_100D_0F66_11036_4488:
        CheckExternalEvents(cs1, 0x0F66);
        // 100D:0F66 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0F95_11065(int loadOffset)
    {
    entrydispatcher:
    label_100D_0F95_11065_27976:
        CheckExternalEvents(cs1, 0x0F95);
        // 100D:0F95 push AX
        Stack.Push16(AX);
        // 100D:0F96 call near 0x390A
        NearCall(cs1, 0x0F99, unknown_100D_390A_139DA);
    label_100D_0F99_11069_27982:
        CheckExternalEvents(cs1, 0x0F99);
        // 100D:0F99 call near 0x4D00
        NearCall(cs1, 0x0F9C, unknown_100D_4D00_14DD0);
    label_100D_0F9C_1106C_27984:
        CheckExternalEvents(cs1, 0x0F9C);
        // 100D:0F9C call near 0xB2BE
        NearCall(cs1, 0x0F9F, unknown_100D_B2BE_1B38E);
    label_100D_0F9F_1106F_27986:
        CheckExternalEvents(cs1, 0x0F9F);
        // 100D:0F9F pop CX
        CX = Stack.Pop16();
        // 100D:0FA0 sub CX,word ptr DS:[2]
        CX = Alu16.Sub(CX, UInt16[DS, (ushort)0x0002]);
        // 100D:0FA4 call near 0x0FD9
        NearCall(cs1, 0x0FA7, unknown_100D_0FD9_110A9);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x0FA7))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0FB2_11082(int loadOffset)
    {
    label_100D_0FB2_11082_36556:
        CheckExternalEvents(cs1, 0x0FB2);
        // 100D:0FB2 call near 0x395F
        NearCall(cs1, 0x0FB5, unknown_100D_395F_13A2F);
    label_100D_0FB5_11085_36559:
        CheckExternalEvents(cs1, 0x0FB5);
        // 100D:0FB5 call near 0x3971
        NearCall(cs1, 0x0FB8, unknown_100D_3971_13A41);
    label_100D_0FB8_11088_36561:
        CheckExternalEvents(cs1, 0x0FB8);
        // 100D:0FB8 cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:0FBD je short 0x0FC2
        if (ZeroFlag)
        {
            goto label_100D_0FC2_11092_36564;
        }
    label_100D_0FBF_1108F_36576:
        CheckExternalEvents(cs1, 0x0FBF);
        // 100D:0FBF jmp near 0x39B9
        return unknown_100D_39B9_13A89(0x0000);
    label_100D_0FC2_11092_36564:
        CheckExternalEvents(cs1, 0x0FC2);
        // 100D:0FC2 jmp near 0x398C
        return unknown_100D_398C_13A5C(0x0000);
    }

    public virtual Action unknown_100D_0FD9_110A9(int loadOffset)
    {
    label_100D_0FD9_110A9_22493:
        CheckExternalEvents(cs1, 0x0FD9);
        // 100D:0FD9 mov byte ptr DS:[0x46DA],1
        UInt8[DS, (ushort)0x46DA] = (byte)0x01;
        // 100D:0FDE call near 0xB2BE
        NearCall(cs1, 0x0FE1, unknown_100D_B2BE_1B38E);
    label_100D_0FE1_110B1_22496:
        CheckExternalEvents(cs1, 0x0FE1);
        // 100D:0FE1 or CX,CX
        CX = Alu16.Or(CX, CX);
        // 100D:0FE3 jle short 0x1005
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_1005_110D5_22514;
        }
    label_100D_0FE5_110B5_22499:
        CheckExternalEvents(cs1, 0x0FE5);
        // 100D:0FE5 push CX
        Stack.Push16(CX);
        // 100D:0FE6 mov AX,word ptr DS:[0x146E]
        AX = UInt16[DS, (ushort)0x146E];
        // 100D:0FE9 mov word ptr DS:[0x46DB],AX
        UInt16[DS, (ushort)0x46DB] = AX;
        // 100D:0FEC cmp byte ptr DS:[0x46DD],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DD], (byte)0x00);
        // 100D:0FF1 je short 0x0FF6
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:0FF1");
        }
    label_100D_0FF6_110C6_22505:
        CheckExternalEvents(cs1, 0x0FF6);
        // 100D:0FF6 inc word ptr DS:[2]
        UInt16[DS, (ushort)0x0002] = Alu16.Inc(UInt16[DS, (ushort)0x0002]);
        // 100D:0FFA mov byte ptr DS:[0x46DD],1
        UInt8[DS, (ushort)0x46DD] = (byte)0x01;
        // 100D:0FFF call near 0x1B23
        NearCall(cs1, 0x1002, unknown_100D_1B23_11BF3);
    label_100D_1002_110D2_22511:
        CheckExternalEvents(cs1, 0x1002);
        // 100D:1002 pop CX
        CX = Stack.Pop16();
        // 100D:1003 loop 0x0FD9
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_0FD9_110A9_22493;
        }
    label_100D_1005_110D5_22514:
        CheckExternalEvents(cs1, 0x1005);
        // 100D:1005 mov byte ptr DS:[0x46DA],0
        UInt8[DS, (ushort)0x46DA] = (byte)0x00;
        // 100D:100A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_100B_110DB(int loadOffset)
    {
    label_100D_100B_110DB_23081:
        CheckExternalEvents(cs1, 0x100B);
        // 100D:100B mov byte ptr DS:[0x100B],1
        UInt8[DS, (ushort)0x100B] = (byte)0x01;
        // 100D:1010 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1011_110E1(int loadOffset)
    {
    label_100D_1011_110E1_27433:
        CheckExternalEvents(cs1, 0x1011);
        // 100D:1011 dec byte ptr DS:[0x122A]
        UInt8[DS, (ushort)0x122A] = Alu8.Dec(UInt8[DS, (ushort)0x122A]);
        // 100D:1015 mov SI,0x1021
        SI = (ushort)0x1021;
        // 100D:1018 call near 0x105B
        NearCall(cs1, 0x101B, unknown_100D_105B_1112B);
        return unknown_100D_101B_110EB(0x0000);
    }

    public virtual Action unknown_100D_101B_110EB(int loadOffset)
    {
    label_100D_101B_110EB_27448:
        CheckExternalEvents(cs1, 0x101B);
        // 100D:101B mov byte ptr DS:[0x0FE8],9
        UInt8[DS, (ushort)0x0FE8] = (byte)0x09;
        // 100D:1020 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1027_110F7(int loadOffset)
    {
    label_100D_1027_110F7_30338:
        CheckExternalEvents(cs1, 0x1027);
        // 100D:1027 and byte ptr DS:[0x122E],0x7F
        UInt8[DS, (ushort)0x122E] = Alu8.And(UInt8[DS, (ushort)0x122E], (byte)0x7F);
        // 100D:102C jmp near 0x2FFB
        return unknown_100D_2FFB_130CB(0x0000);
    }

    public virtual Action unknown_100D_102F_110FF(int loadOffset)
    {
    label_100D_102F_110FF_30348:
        CheckExternalEvents(cs1, 0x102F);
        // 100D:102F and byte ptr DS:[0x124A],0x7F
        UInt8[DS, (ushort)0x124A] = Alu8.And(UInt8[DS, (ushort)0x124A], (byte)0x7F);
        // 100D:1034 and byte ptr DS:[0x1247],0x7F
        UInt8[DS, (ushort)0x1247] = Alu8.And(UInt8[DS, (ushort)0x1247], (byte)0x7F);
        // 100D:1039 mov word ptr DS:[0x121D],0xFFFF
        UInt16[DS, (ushort)0x121D] = (ushort)0xFFFF;
        // 100D:103F mov AX,0x1321
        AX = (ushort)0x1321;
        // 100D:1042 jmp near 0x1771
        return unknown_100D_1771_11841(0x0000);
    }

    public virtual Action unknown_100D_1045_11115(int loadOffset)
    {
    label_100D_1045_11115_30906:
        CheckExternalEvents(cs1, 0x1045);
        // 100D:1045 mov byte ptr DS:[0x0FD8],5
        UInt8[DS, (ushort)0x0FD8] = (byte)0x05;
        // 100D:104A call near 0x101B
        NearCall(cs1, 0x104D, unknown_100D_101B_110EB);
    label_100D_104D_1111D_30909:
        CheckExternalEvents(cs1, 0x104D);
        // 100D:104D mov AX,0x010B
        AX = (ushort)0x010B;
        // 100D:1050 jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_1053_11123(int loadOffset)
    {
    entrydispatcher:
    label_100D_1053_11123_32042:
        CheckExternalEvents(cs1, 0x1053);
        // 100D:1053 mov byte ptr DS:[0x0FD8],0x0A
        UInt8[DS, (ushort)0x0FD8] = (byte)0x0A;
        // 100D:1058 mov SI,0x1069
        SI = (ushort)0x1069;
        if (JumpDispatcher.Jump(unknown_100D_105B_1112B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_105B_1112B(int loadOffset)
    {
    entrydispatcher:
    label_100D_105B_1112B_27437:
        CheckExternalEvents(cs1, 0x105B);
        // 100D:105B lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:105D or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:105F je short 0x1068
        if (ZeroFlag)
        {
            goto label_100D_1068_11138_27446;
        }
    label_100D_1061_11131_27441:
        CheckExternalEvents(cs1, 0x1061);
        // 100D:1061 mov DI,AX
        DI = AX;
        // 100D:1063 call near 0x425B
        NearCall(cs1, 0x1066, unknown_100D_425B_1432B);
    label_100D_1066_11136_27444:
        CheckExternalEvents(cs1, 0x1066);
        // 100D:1066 jmp short 0x105B
        goto label_100D_105B_1112B_27437;
    label_100D_1068_11138_27446:
        CheckExternalEvents(cs1, 0x1068);
        // 100D:1068 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1071_11141(int loadOffset)
    {
    label_100D_1071_11141_32308:
        CheckExternalEvents(cs1, 0x1071);
        // 100D:1071 mov byte ptr DS:[0x00FF],0
        UInt8[DS, (ushort)0x00FF] = (byte)0x00;
        // 100D:1076 mov byte ptr DS:[0x002A],0x15
        UInt8[DS, (ushort)0x002A] = (byte)0x15;
        // 100D:107B mov byte ptr DS:[0x0FDB],1
        UInt8[DS, (ushort)0x0FDB] = (byte)0x01;
        // 100D:1080 mov word ptr DS:[0x1018],0x200B
        UInt16[DS, (ushort)0x1018] = (ushort)0x200B;
        // 100D:1086 mov word ptr DS:[0x101A],0x0180
        UInt16[DS, (ushort)0x101A] = (ushort)0x0180;
        // 100D:108C mov byte ptr DS:[0x0FE8],0x0A
        UInt8[DS, (ushort)0x0FE8] = (byte)0x0A;
        // 100D:1091 mov byte ptr DS:[0x00D5],0xFF
        UInt8[DS, (ushort)0x00D5] = (byte)0xFF;
        // 100D:1096 call near 0x2090
        NearCall(cs1, 0x1099, unknown_100D_2090_12160);
    label_100D_1099_11169_32363:
        CheckExternalEvents(cs1, 0x1099);
        // 100D:1099 or byte ptr DS:[0x000A],1
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x01);
        // 100D:109E mov AX,1
        AX = (ushort)0x0001;
        // 100D:10A1 jmp near 0x29EE
        return unknown_100D_29EE_12ABE(0x0000);
    }

    public virtual Action unknown_100D_10A4_11174(int loadOffset)
    {
    label_100D_10A4_11174_32885:
        CheckExternalEvents(cs1, 0x10A4);
        // 100D:10A4 and byte ptr DS:[0x1245],0x7F
        UInt8[DS, (ushort)0x1245] = Alu8.And(UInt8[DS, (ushort)0x1245], (byte)0x7F);
        // 100D:10A9 mov word ptr DS:[0x1217],0xFFFF
        UInt16[DS, (ushort)0x1217] = (ushort)0xFFFF;
        // 100D:10AF jmp near 0x2FFB
        return unknown_100D_2FFB_130CB(0x0000);
    }

    public virtual Action unknown_100D_10B2_11182(int loadOffset)
    {
    label_100D_10B2_11182_33278:
        CheckExternalEvents(cs1, 0x10B2);
        // 100D:10B2 mov byte ptr DS:[0x0FFB],1
        UInt8[DS, (ushort)0x0FFB] = (byte)0x01;
        return unknown_100D_10B7_11187(0x0000);
    }

    public virtual Action unknown_100D_10B7_11187(int loadOffset)
    {
    label_100D_10B7_11187_32883:
        CheckExternalEvents(cs1, 0x10B7);
        // 100D:10B7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_10B8_11188(int loadOffset)
    {
    entrydispatcher:
    label_100D_10B8_11188_33483:
        CheckExternalEvents(cs1, 0x10B8);
        // 100D:10B8 mov DI,0x0800
        DI = (ushort)0x0800;
        // 100D:10BB jmp near 0x425B
        if (JumpDispatcher.Jump(unknown_100D_425B_1432B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_10BE_1118E(int loadOffset)
    {
    entrydispatcher:
    label_100D_10BE_1118E_33495:
        CheckExternalEvents(cs1, 0x10BE);
        // 100D:10BE mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:10C1 mov word ptr DS:[0x1154],AX
        UInt16[DS, (ushort)0x1154] = AX;
        // 100D:10C4 mov word ptr DS:[0x1018],0x2006
        UInt16[DS, (ushort)0x1018] = (ushort)0x2006;
        // 100D:10CA mov word ptr DS:[0x0FF8],0x2008
        UInt16[DS, (ushort)0x0FF8] = (ushort)0x2008;
        // 100D:10D0 mov word ptr DS:[0x0FFA],0x0180
        UInt16[DS, (ushort)0x0FFA] = (ushort)0x0180;
        // 100D:10D6 mov byte ptr DS:[0x0FE8],0x0A
        UInt8[DS, (ushort)0x0FE8] = (byte)0x0A;
        // 100D:10DB mov word ptr DS:[0x0FEA],0x0180
        UInt16[DS, (ushort)0x0FEA] = (ushort)0x0180;
        // 100D:10E1 mov word ptr DS:[0x1201],0x0109
        UInt16[DS, (ushort)0x1201] = (ushort)0x0109;
        // 100D:10E7 mov AL,0x14
        AL = (byte)0x14;
        // 100D:10E9 call near 0x6F78
        NearCall(cs1, 0x10EC, unknown_100D_6F78_17048);
    label_100D_10EC_111BC_33506:
        CheckExternalEvents(cs1, 0x10EC);
        // 100D:10EC or byte ptr DS:[0x000A],0x10
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x10);
        // 100D:10F1 mov SI,0x10F7
        SI = (ushort)0x10F7;
        // 100D:10F4 jmp near 0x105B
        if (JumpDispatcher.Jump(unknown_100D_105B_1112B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1103_111D3(int loadOffset)
    {
    label_100D_1103_111D3_33779:
        CheckExternalEvents(cs1, 0x1103);
        // 100D:1103 mov AX,4
        AX = (ushort)0x0004;
        // 100D:1106 call near 0x29EE
        NearCall(cs1, 0x1109, unknown_100D_29EE_12ABE);
    label_100D_1109_111D9_33782:
        CheckExternalEvents(cs1, 0x1109);
        // 100D:1109 mov AX,0x1409
        AX = (ushort)0x1409;
        // 100D:110C jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_110F_111DF(int loadOffset)
    {
    label_100D_110F_111DF_33817:
        CheckExternalEvents(cs1, 0x110F);
        // 100D:110F cmp byte ptr DS:[0x0FE8],8
        Alu8.Sub(UInt8[DS, (ushort)0x0FE8], (byte)0x08);
        // 100D:1114 je short 0x1121
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1114");
        }
    label_100D_1116_111E6_33820:
        CheckExternalEvents(cs1, 0x1116);
        // 100D:1116 mov byte ptr DS:[0x0FE8],0x0A
        UInt8[DS, (ushort)0x0FE8] = (byte)0x0A;
        // 100D:111B mov word ptr DS:[0x0FEA],0x0180
        UInt16[DS, (ushort)0x0FEA] = (ushort)0x0180;
        // 100D:1121 mov AX,0x280A
        AX = (ushort)0x280A;
        // 100D:1124 jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_1127_111F7(int loadOffset)
    {
    label_100D_1127_111F7_33825:
        CheckExternalEvents(cs1, 0x1127);
        // 100D:1127 mov byte ptr DS:[0x0FDB],0xFF
        UInt8[DS, (ushort)0x0FDB] = (byte)0xFF;
        // 100D:112C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_112D_111FD(int loadOffset)
    {
    label_100D_112D_111FD_34088:
        CheckExternalEvents(cs1, 0x112D);
        // 100D:112D or byte ptr DS:[0x1067],2
        UInt8[DS, (ushort)0x1067] = Alu8.Or(UInt8[DS, (ushort)0x1067], (byte)0x02);
        // 100D:1132 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1133_11203(int loadOffset)
    {
    entrydispatcher:
    label_100D_1133_11203_34091:
        CheckExternalEvents(cs1, 0x1133);
        // 100D:1133 mov DI,0x03D8
        DI = (ushort)0x03D8;
        // 100D:1136 jmp near 0x425B
        if (JumpDispatcher.Jump(unknown_100D_425B_1432B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1139_11209(int loadOffset)
    {
    entrydispatcher:
    label_100D_1139_11209_34601:
        CheckExternalEvents(cs1, 0x1139);
        // 100D:1139 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:113B call near 0x6F78
        NearCall(cs1, 0x113E, unknown_100D_6F78_17048);
    label_100D_113E_1120E_34604:
        CheckExternalEvents(cs1, 0x113E);
        // 100D:113E mov AX,0x1313
        AX = (ushort)0x1313;
        // 100D:1141 call near 0x1771
        NearCall(cs1, 0x1144, unknown_100D_1771_11841);
    label_100D_1144_11214_34611:
        CheckExternalEvents(cs1, 0x1144);
        // 100D:1144 mov AL,byte ptr DS:[0x1057]
        AL = UInt8[DS, (ushort)0x1057];
        // 100D:1147 or AL,0x10
        AL = Alu8.Or(AL, (byte)0x10);
        // 100D:1149 and AL,0xFD
        AL = Alu8.And(AL, (byte)0xFD);
        // 100D:114B mov byte ptr DS:[0x1057],AL
        UInt8[DS, (ushort)0x1057] = AL;
        // 100D:114E mov AL,byte ptr DS:[0x0028]
        AL = UInt8[DS, (ushort)0x0028];
        // 100D:1151 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:1153 mov byte ptr DS:[0x1178],AL
        UInt8[DS, (ushort)0x1178] = AL;
        // 100D:1156 mov SI,0x115C
        SI = (ushort)0x115C;
        // 100D:1159 jmp near 0x105B
        if (JumpDispatcher.Jump(unknown_100D_105B_1112B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1166_11236(int loadOffset)
    {
    label_100D_1166_11236_34951:
        CheckExternalEvents(cs1, 0x1166);
        // 100D:1166 inc byte ptr DS:[0x1141]
        UInt8[DS, (ushort)0x1141] = Alu8.Inc(UInt8[DS, (ushort)0x1141]);
        // 100D:116A mov byte ptr DS:[0x0FE8],2
        UInt8[DS, (ushort)0x0FE8] = (byte)0x02;
        // 100D:116F mov word ptr DS:[0x0FEA],0x0180
        UInt16[DS, (ushort)0x0FEA] = (ushort)0x0180;
        // 100D:1175 mov AX,0x0105
        AX = (ushort)0x0105;
        // 100D:1178 jmp near 0x29EE
        return unknown_100D_29EE_12ABE(0x0000);
    }

    public virtual Action unknown_100D_117B_1124B(int loadOffset)
    {
    label_100D_117B_1124B_35161:
        CheckExternalEvents(cs1, 0x117B);
        // 100D:117B or byte ptr DS:[0x000A],0x40
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x40);
        // 100D:1180 mov AL,0x28
        AL = (byte)0x28;
        // 100D:1182 call near 0x6F78
        NearCall(cs1, 0x1185, unknown_100D_6F78_17048);
    label_100D_1185_11255_35165:
        CheckExternalEvents(cs1, 0x1185);
        // 100D:1185 jmp near 0x101B
        return unknown_100D_101B_110EB(0x0000);
    }

    public virtual Action unknown_100D_1188_11258(int loadOffset)
    {
    label_100D_1188_11258_35285:
        CheckExternalEvents(cs1, 0x1188);
        // 100D:1188 and byte ptr DS:[0x1259],0x7F
        UInt8[DS, (ushort)0x1259] = Alu8.And(UInt8[DS, (ushort)0x1259], (byte)0x7F);
        // 100D:118D mov word ptr DS:[0x1211],0xFFFF
        UInt16[DS, (ushort)0x1211] = (ushort)0xFFFF;
        // 100D:1193 jmp near 0x2FFB
        return unknown_100D_2FFB_130CB(0x0000);
    }

    public virtual Action unknown_100D_1196_11266(int loadOffset)
    {
    entrydispatcher:
    label_100D_1196_11266_35309:
        CheckExternalEvents(cs1, 0x1196);
        // 100D:1196 or byte ptr DS:[0x000A],0x20
        UInt8[DS, (ushort)0x000A] = Alu8.Or(UInt8[DS, (ushort)0x000A], (byte)0x20);
        // 100D:119B mov AX,0x12FB
        AX = (ushort)0x12FB;
        // 100D:119E call near 0x1771
        NearCall(cs1, 0x11A1, unknown_100D_1771_11841);
    label_100D_11A1_11271_35313:
        CheckExternalEvents(cs1, 0x11A1);
        // 100D:11A1 mov SI,0x11A7
        SI = (ushort)0x11A7;
        // 100D:11A4 jmp near 0x105B
        if (JumpDispatcher.Jump(unknown_100D_105B_1112B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_11B3_11283(int loadOffset)
    {
    label_100D_11B3_11283_35319:
        CheckExternalEvents(cs1, 0x11B3);
        // 100D:11B3 mov byte ptr DS:[0x1038],5
        UInt8[DS, (ushort)0x1038] = (byte)0x05;
        // 100D:11B8 add byte ptr DS:[0x11D0],0x0C
        UInt8[DS, (ushort)0x11D0] = Alu8.Add(UInt8[DS, (ushort)0x11D0], (byte)0x0C);
        // 100D:11BD call near 0x1AC5
        NearCall(cs1, 0x11C0, unknown_100D_1AC5_11B95);
    label_100D_11C0_11290_35323:
        CheckExternalEvents(cs1, 0x11C0);
        // 100D:11C0 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 100D:11C3 mov word ptr DS:[0x1156],AX
        UInt16[DS, (ushort)0x1156] = AX;
        // 100D:11C6 inc byte ptr DS:[0x1141]
        UInt8[DS, (ushort)0x1141] = Alu8.Inc(UInt8[DS, (ushort)0x1141]);
        // 100D:11CA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_11CB_1129B(int loadOffset)
    {
    label_100D_11CB_1129B_36019:
        CheckExternalEvents(cs1, 0x11CB);
        // 100D:11CB mov byte ptr DS:[0x00FF],0
        UInt8[DS, (ushort)0x00FF] = (byte)0x00;
        // 100D:11D0 mov byte ptr DS:[0x002A],0x60
        UInt8[DS, (ushort)0x002A] = (byte)0x60;
        // 100D:11D5 mov DI,0x011C
        DI = (ushort)0x011C;
        // 100D:11D8 call near 0x40AE
        NearCall(cs1, 0x11DB, unknown_100D_40AE_1417E);
    label_100D_11DB_112AB_36024:
        CheckExternalEvents(cs1, 0x11DB);
        // 100D:11DB mov DL,2
        DL = (byte)0x02;
        // 100D:11DD mov word ptr DS:[0x1048],DX
        UInt16[DS, (ushort)0x1048] = DX;
        // 100D:11E1 mov word ptr DS:[0x104A],BX
        UInt16[DS, (ushort)0x104A] = BX;
        // 100D:11E5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_11E6_112B6(int loadOffset)
    {
    label_100D_11E6_112B6_36042:
        CheckExternalEvents(cs1, 0x11E6);
        // 100D:11E6 jmp near 0x1F13
    label_100D_1F13_11FE3_36044:
        CheckExternalEvents(cs1, 0x1F13);
        // 100D:1F13 mov DI,0x0138
        DI = (ushort)0x0138;
        // 100D:1F16 mov BX,0xFF9C
        BX = (ushort)0xFF9C;
    label_100D_1F19_11FE9_36047:
        CheckExternalEvents(cs1, 0x1F19);
        // 100D:1F19 mov AX,word ptr DS:[DI+4]
        AX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:1F1C cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:1F1E jle short 0x1F37
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_1F37_12007_36066;
        }
    label_100D_1F20_11FF0_36050:
        CheckExternalEvents(cs1, 0x1F20);
        // 100D:1F20 call near 0x5D36
        NearCall(cs1, 0x1F23, unknown_100D_5D36_15E06);
    label_100D_1F23_11FF3_36052:
        CheckExternalEvents(cs1, 0x1F23);
        // 100D:1F23 jb short 0x1F37
        if (CarryFlag)
        {
            goto label_100D_1F37_12007_36066;
        }
    label_100D_1F25_11FF5_36054:
        CheckExternalEvents(cs1, 0x1F25);
        // 100D:1F25 call near 0x5098
        NearCall(cs1, 0x1F28, unknown_100D_5098_15168);
    label_100D_1F28_11FF8_36056:
        CheckExternalEvents(cs1, 0x1F28);
        // 100D:1F28 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:1F2A jne short 0x1F37
        if (!ZeroFlag)
        {
            goto label_100D_1F37_12007_36066;
        }
    label_100D_1F2C_11FFC_36059:
        CheckExternalEvents(cs1, 0x1F2C);
        // 100D:1F2C mov AX,word ptr DS:[DI+4]
        AX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:1F2F cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:1F31 jle short 0x1F37
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_1F37_12007_36066;
        }
    label_100D_1F33_12003_36063:
        CheckExternalEvents(cs1, 0x1F33);
        // 100D:1F33 mov BX,AX
        BX = AX;
        // 100D:1F35 mov SI,DI
        SI = DI;
    label_100D_1F37_12007_36066:
        CheckExternalEvents(cs1, 0x1F37);
        // 100D:1F37 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:1F3A cmp byte ptr DS:[DI],8
        Alu8.Sub(UInt8[DS, DI], (byte)0x08);
        // 100D:1F3D jb short 0x1F19
        if (CarryFlag)
        {
            goto label_100D_1F19_11FE9_36047;
        }
    label_100D_1F3F_1200F_36071:
        CheckExternalEvents(cs1, 0x1F3F);
        // 100D:1F3F cmp BX,-100
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-100)));
        // 100D:1F42 jne short 0x1F47
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:1F42");
        }
    label_100D_1F47_12017_36074:
        CheckExternalEvents(cs1, 0x1F47);
        // 100D:1F47 mov DI,SI
        DI = SI;
        // 100D:1F49 call near 0x40AE
        NearCall(cs1, 0x1F4C, unknown_100D_40AE_1417E);
    label_100D_1F4C_1201C_36077:
        CheckExternalEvents(cs1, 0x1F4C);
        // 100D:1F4C mov DL,3
        DL = (byte)0x03;
        // 100D:1F4E mov word ptr DS:[0x1048],DX
        UInt16[DS, (ushort)0x1048] = DX;
        // 100D:1F52 mov word ptr DS:[0x104A],BX
        UInt16[DS, (ushort)0x104A] = BX;
        // 100D:1F56 mov AH,byte ptr DS:[DI]
        AH = UInt8[DS, DI];
        // 100D:1F58 mov AL,byte ptr DS:[DI+1]
        AL = UInt8[DS, (ushort)(DI + (sbyte)1)];
        // 100D:1F5B mov word ptr DS:[0x00F2],AX
        UInt16[DS, (ushort)0x00F2] = AX;
        // 100D:1F5E mov AX,0x2B0A
        AX = (ushort)0x2B0A;
        // 100D:1F61 jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_121F_112EF(int loadOffset)
    {
    entrydispatcher:
    label_100D_121F_112EF_27418:
        CheckExternalEvents(cs1, 0x121F);
        // 100D:121F cmp AL,byte ptr DS:[0x002A]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x002A]);
        // 100D:1223 jbe short 0x1242
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_1242_11312_27451;
        }
    label_100D_1225_112F5_27421:
        CheckExternalEvents(cs1, 0x1225);
        // 100D:1225 mov byte ptr DS:[0x002A],AL
        UInt8[DS, (ushort)0x002A] = AL;
        // 100D:1228 mov byte ptr DS:[0x00FF],0
        UInt8[DS, (ushort)0x00FF] = (byte)0x00;
        // 100D:122D call near 0xB17A
        NearCall(cs1, 0x1230, unknown_100D_B17A_1B24A);
    label_100D_1230_11300_27425:
        CheckExternalEvents(cs1, 0x1230);
        // 100D:1230 mov BL,byte ptr DS:[0x002A]
        BL = UInt8[DS, (ushort)0x002A];
        // 100D:1234 cmp BL,0x6C
        Alu8.Sub(BL, (byte)0x6C);
        // 100D:1237 ja short 0x1242
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_1242_11312_27451;
        }
    label_100D_1239_11309_27429:
        CheckExternalEvents(cs1, 0x1239);
        // 100D:1239 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:123B shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:123D call near word ptr CS:[BX+0x11E7]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)4583)]))
        {
            case 0x1011:
                NearCall(cs1, 0x1242, unknown_100D_1011_110E1);
                break;
            case 0x1027:
                NearCall(cs1, 0x1242, unknown_100D_1027_110F7);
                break;
            case 0x102F:
                NearCall(cs1, 0x1242, unknown_100D_102F_110FF);
                break;
            case 0x1045:
                NearCall(cs1, 0x1242, unknown_100D_1045_11115);
                break;
            case 0x1053:
                NearCall(cs1, 0x1242, unknown_100D_1053_11123);
                break;
            case 0x10A4:
                NearCall(cs1, 0x1242, unknown_100D_10A4_11174);
                break;
            case 0x10B2:
                NearCall(cs1, 0x1242, unknown_100D_10B2_11182);
                break;
            case 0x10B7:
                NearCall(cs1, 0x1242, unknown_100D_10B7_11187);
                break;
            case 0x10B8:
                NearCall(cs1, 0x1242, unknown_100D_10B8_11188);
                break;
            case 0x10BE:
                NearCall(cs1, 0x1242, unknown_100D_10BE_1118E);
                break;
            case 0x1103:
                NearCall(cs1, 0x1242, unknown_100D_1103_111D3);
                break;
            case 0x110F:
                NearCall(cs1, 0x1242, unknown_100D_110F_111DF);
                break;
            case 0x1127:
                NearCall(cs1, 0x1242, unknown_100D_1127_111F7);
                break;
            case 0x112D:
                NearCall(cs1, 0x1242, unknown_100D_112D_111FD);
                break;
            case 0x1133:
                NearCall(cs1, 0x1242, unknown_100D_1133_11203);
                break;
            case 0x1139:
                NearCall(cs1, 0x1242, unknown_100D_1139_11209);
                break;
            case 0x1166:
                NearCall(cs1, 0x1242, unknown_100D_1166_11236);
                break;
            case 0x117B:
                NearCall(cs1, 0x1242, unknown_100D_117B_1124B);
                break;
            case 0x1188:
                NearCall(cs1, 0x1242, unknown_100D_1188_11258);
                break;
            case 0x1196:
                NearCall(cs1, 0x1242, unknown_100D_1196_11266);
                break;
            case 0x11B3:
                NearCall(cs1, 0x1242, unknown_100D_11B3_11283);
                break;
            case 0x11E6:
                NearCall(cs1, 0x1242, unknown_100D_11E6_112B6);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)4583)])):X4} at 100D:123D");
        }
    label_100D_1242_11312_27451:
        CheckExternalEvents(cs1, 0x1242);
        // 100D:1242 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1243_11313(int loadOffset)
    {
    label_100D_1243_11313_41086:
        CheckExternalEvents(cs1, 0x1243);
        // 100D:1243 mov BP,0x1269
        BP = (ushort)0x1269;
        // 100D:1246 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:1248 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:124A call near 0x1258
        NearCall(cs1, 0x124D, unknown_100D_1258_11328);
    label_100D_124D_1131D_41137:
        CheckExternalEvents(cs1, 0x124D);
        // 100D:124D cmp BX,0x03E8
        Alu16.Sub(BX, (ushort)0x03E8);
        // 100D:1251 jb short 0x1257
        if (CarryFlag)
        {
            goto label_100D_1257_11327_41140;
        }
    label_100D_1253_11323_41142:
        CheckExternalEvents(cs1, 0x1253);
        // 100D:1253 inc byte ptr DS:[0x00C2]
        UInt8[DS, (ushort)0x00C2] = Alu8.Inc(UInt8[DS, (ushort)0x00C2]);
    label_100D_1257_11327_41140:
        CheckExternalEvents(cs1, 0x1257);
        // 100D:1257 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1258_11328(int loadOffset)
    {
    label_100D_1258_11328_41091:
        CheckExternalEvents(cs1, 0x1258);
        // 100D:1258 mov DI,0x0138
        DI = (ushort)0x0138;
        // 100D:125B mov CX,3
        CX = (ushort)0x0003;
    label_100D_125E_1132E_41094:
        CheckExternalEvents(cs1, 0x125E);
        // 100D:125E push CX
        Stack.Push16(CX);
        // 100D:125F call near 0x661D
        NearCall(cs1, 0x1262, unknown_100D_661D_166ED);
    label_100D_1262_11332_41126:
        CheckExternalEvents(cs1, 0x1262);
        // 100D:1262 pop CX
        CX = Stack.Pop16();
        // 100D:1263 add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:1266 loop 0x125E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_125E_1132E_41094;
        }
    label_100D_1268_11338_41132:
        CheckExternalEvents(cs1, 0x1268);
        // 100D:1268 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1269_11339(int loadOffset)
    {
    label_100D_1269_11339_41107:
        CheckExternalEvents(cs1, 0x1269);
        // 100D:1269 cmp byte ptr DS:[SI+3],4
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x04);
        // 100D:126D jne short 0x127B
        if (!ZeroFlag)
        {
            goto label_100D_127B_1134B_41110;
        }
    label_100D_126F_1133F_41112:
        CheckExternalEvents(cs1, 0x126F);
        // 100D:126F test byte ptr DS:[SI+0x19],4
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x04);
        // 100D:1273 je short 0x127B
        if (ZeroFlag)
        {
            goto label_100D_127B_1134B_41110;
        }
    label_100D_1275_11345_41116:
        CheckExternalEvents(cs1, 0x1275);
        // 100D:1275 add BL,byte ptr DS:[SI+0x1A]
        BL = Alu8.Add(BL, UInt8[DS, (ushort)(SI + (sbyte)26)]);
        // 100D:1278 adc BH,0
        BH = Alu8.Adc(BH, (byte)0x00);
    label_100D_127B_1134B_41110:
        CheckExternalEvents(cs1, 0x127B);
        // 100D:127B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_127C_1134C(int loadOffset)
    {
    label_100D_127C_1134C_7791:
        CheckExternalEvents(cs1, 0x127C);
        // 100D:127C cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:127E jne short 0x128D
        if (!ZeroFlag)
        {
            goto label_100D_128D_1135D_7794;
        }
    label_100D_1280_11350_22908:
        CheckExternalEvents(cs1, 0x1280);
        // 100D:1280 cmp byte ptr DS:[0x002A],0x15
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x15);
        // 100D:1285 jb short 0x128D
        if (CarryFlag)
        {
            goto label_100D_128D_1135D_7794;
        }
    label_100D_1287_11357_32889:
        CheckExternalEvents(cs1, 0x1287);
        // 100D:1287 cmp byte ptr DS:[0x002A],0x20
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x20);
        // 100D:128C ret near
        return NearRet((ushort)0x0000);
    label_100D_128D_1135D_7794:
        CheckExternalEvents(cs1, 0x128D);
        // 100D:128D clc
        CarryFlag = false;
        // 100D:128E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1392_11462(int loadOffset)
    {
    label_100D_1392_11462_30368:
        CheckExternalEvents(cs1, 0x1392);
        // 100D:1392 mov word ptr DS:[0x2220],0x1FBA
        UInt16[DS, (ushort)0x2220] = (ushort)0x1FBA;
        // 100D:1398 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1399_11469(int loadOffset)
    {
    label_100D_1399_11469_28396:
        CheckExternalEvents(cs1, 0x1399);
        // 100D:1399 mov word ptr DS:[0x2220],0x1FAE
        UInt16[DS, (ushort)0x2220] = (ushort)0x1FAE;
        // 100D:139F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_13C8_11498(int loadOffset)
    {
    entrydispatcher:
    label_100D_13C8_11498_30359:
        CheckExternalEvents(cs1, 0x13C8);
        // 100D:13C8 lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:13CA mov byte ptr DS:[4],AL
        UInt8[DS, (ushort)0x0004] = AL;
        // 100D:13CD mov word ptr DS:[0x4778],SI
        UInt16[DS, (ushort)0x4778] = SI;
        // 100D:13D1 lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:13D3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:13D5 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:13D7 mov word ptr DS:[0x477A],SI
        UInt16[DS, (ushort)0x477A] = SI;
        if (JumpDispatcher.Jump(unknown_100D_13DB_114AB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1498_11568(int loadOffset)
    {
    entrydispatcher:
    label_100D_1498_11568_41322:
        CheckExternalEvents(cs1, 0x1498);
        // 100D:1498 call near 0x13C8
        NearCall(cs1, 0x149B, unknown_100D_13C8_11498);
    label_100D_149B_1156B_41325:
        CheckExternalEvents(cs1, 0x149B);
        // 100D:149B mov byte ptr DS:[0x00E8],0
        UInt8[DS, (ushort)0x00E8] = (byte)0x00;
        // 100D:14A0 mov word ptr DS:[0x1152],0xFFFF
        UInt16[DS, (ushort)0x1152] = (ushort)0xFFFF;
        // 100D:14A6 call near 0xD763
        NearCall(cs1, 0x14A9, unknown_100D_D763_1D833);
    label_100D_14A9_11579_41332:
        CheckExternalEvents(cs1, 0x14A9);
        // 100D:14A9 jmp near 0x0F13
        if (JumpDispatcher.Jump(unknown_100D_0F13_10FE3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_14AC_1157C(int loadOffset)
    {
    entrydispatcher:
    label_100D_14AC_1157C_41426:
        CheckExternalEvents(cs1, 0x14AC);
        // 100D:14AC mov AX,0x001E
        AX = (ushort)0x001E;
        // 100D:14AF call near 0xC13E
        NearCall(cs1, 0x14B2, unknown_100D_C13E_1C20E);
    label_100D_14B2_11582_41431:
        CheckExternalEvents(cs1, 0x14B2);
        // 100D:14B2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_14B4_11584_41432:
        CheckExternalEvents(cs1, 0x14B4);
        // 100D:14B4 push AX
        Stack.Push16(AX);
        // 100D:14B5 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:14B7 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:14B9 call near 0xC22F
        NearCall(cs1, 0x14BC, unknown_100D_C22F_1C2FF);
    label_100D_14BC_1158C_41442:
        CheckExternalEvents(cs1, 0x14BC);
        // 100D:14BC pop AX
        AX = Stack.Pop16();
        // 100D:14BD inc AX
        AX = Alu16.Inc(AX);
        // 100D:14BE cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        // 100D:14C1 jb short 0x14B4
        if (CarryFlag)
        {
            goto label_100D_14B4_11584_41432;
        }
    label_100D_14C3_11593_41449:
        CheckExternalEvents(cs1, 0x14C3);
        // 100D:14C3 call near 0x9B8B
        NearCall(cs1, 0x14C6, unknown_100D_9B8B_19C5B);
    label_100D_14C6_11596_41456:
        CheckExternalEvents(cs1, 0x14C6);
        // 100D:14C6 jmp near 0x0F13
        if (JumpDispatcher.Jump(unknown_100D_0F13_10FE3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_1556_11626(int loadOffset)
    {
    label_100D_1556_11626_41400:
        CheckExternalEvents(cs1, 0x1556);
        // 100D:1556 mov AL,byte ptr DS:[0x46D7]
        AL = UInt8[DS, (ushort)0x46D7];
        // 100D:1559 mov BX,word ptr DS:[0xD818]
        BX = UInt16[DS, (ushort)0xD818];
        // 100D:155D mov CX,word ptr DS:[0xD81A]
        CX = UInt16[DS, (ushort)0xD81A];
        // 100D:1561 call far dword ptr DS:[0x3951]
        ushort targetSegment_41404 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3951 + (ushort)0x0002)]));
        ushort targetOffset_41404 = unchecked((ushort)(UInt16[DS, (ushort)0x3951]));
        if (targetSegment_41404 == cs2 && targetOffset_41404 == 0x0175)
        {
            FarCall(cs1, 0x1565, cs2, unknown_3358_0175_336F5);
            goto label_100D_1565_11635_41408;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41404:X4}:{targetOffset_41404:X4} at 100D:1561");
    label_100D_1565_11635_41408:
        CheckExternalEvents(cs1, 0x1565);
        // 100D:1565 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1566_11636(int loadOffset)
    {
    label_100D_1566_11636_41389:
        CheckExternalEvents(cs1, 0x1566);
        // 100D:1566 inc byte ptr DS:[0x227D]
        UInt8[DS, (ushort)0x227D] = Alu8.Inc(UInt8[DS, (ushort)0x227D]);
    label_100D_156A_1163A_41392:
        CheckExternalEvents(cs1, 0x156A);
        // 100D:156A mov BP,0x1556
        BP = (ushort)0x1556;
        // 100D:156D mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:1570 call near 0xE353
        NearCall(cs1, 0x1573, unknown_100D_E353_1E423);
    label_100D_1573_11643_41410:
        CheckExternalEvents(cs1, 0x1573);
        // 100D:1573 dec byte ptr DS:[0x46D7]
        UInt8[DS, (ushort)0x46D7] = Alu8.Dec(UInt8[DS, (ushort)0x46D7]);
        // 100D:1577 jne short 0x156A
        if (!ZeroFlag)
        {
            goto label_100D_156A_1163A_41392;
        }
    label_100D_1579_11649_41415:
        CheckExternalEvents(cs1, 0x1579);
        // 100D:1579 dec byte ptr DS:[0x227D]
        UInt8[DS, (ushort)0x227D] = Alu8.Dec(UInt8[DS, (ushort)0x227D]);
        // 100D:157D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_157E_1164E(int loadOffset)
    {
    label_100D_157E_1164E_41346:
        CheckExternalEvents(cs1, 0x157E);
        // 100D:157E mov byte ptr DS:[0x46D7],AL
        UInt8[DS, (ushort)0x46D7] = AL;
        // 100D:1581 mov word ptr DS:[0xD81A],CX
        UInt16[DS, (ushort)0xD81A] = CX;
        // 100D:1585 mov word ptr DS:[0xD818],BX
        UInt16[DS, (ushort)0xD818] = BX;
        // 100D:1589 sub SP,CX
        SP = Alu16.Sub(SP, CX);
        // 100D:158B push SS
        Stack.Push16(SS);
        // 100D:158C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:158D mov DI,SP
        DI = SP;
        // 100D:158F xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:1591 push CX
        Stack.Push16(CX);
        // 100D:1592 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:1594 pop CX
        CX = Stack.Pop16();
        // 100D:1595 mov DX,SP
        DX = SP;
        // 100D:1597 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:1599 jne short 0x15A1
        if (!ZeroFlag)
        {
            goto label_100D_15A1_11671_41361;
        }
    label_100D_159B_1166B_41363:
        CheckExternalEvents(cs1, 0x159B);
        // 100D:159B call far dword ptr DS:[0x38BD]
        ushort targetSegment_41363 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_41363 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_41363 == cs2 && targetOffset_41363 == 0x0106)
        {
            FarCall(cs1, 0x159F, cs2, unknown_3358_0106_33686);
            goto label_100D_159F_1166F_41473;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41363:X4}:{targetOffset_41363:X4} at 100D:159B");
    label_100D_159F_1166F_41473:
        CheckExternalEvents(cs1, 0x159F);
        // 100D:159F jmp short 0x15A5
        goto label_100D_15A5_11675_41384;
    label_100D_15A1_11671_41361:
        CheckExternalEvents(cs1, 0x15A1);
        // 100D:15A1 call far dword ptr DS:[0x394D]
        ushort targetSegment_41361 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x394D + (ushort)0x0002)]));
        ushort targetOffset_41361 = unchecked((ushort)(UInt16[DS, (ushort)0x394D]));
        if (targetSegment_41361 == cs2 && targetOffset_41361 == 0x0172)
        {
            FarCall(cs1, 0x15A5, cs2, unknown_3358_0172_336F2);
            goto label_100D_15A5_11675_41384;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_41361:X4}:{targetOffset_41361:X4} at 100D:15A1");
    label_100D_15A5_11675_41384:
        CheckExternalEvents(cs1, 0x15A5);
        // 100D:15A5 add SP,CX
        SP = Alu16.Add(SP, CX);
        // 100D:15A7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_15A8_11678(int loadOffset)
    {
    label_100D_15A8_11678_41762:
        CheckExternalEvents(cs1, 0x15A8);
        // 100D:15A8 call near 0xD08F
        NearCall(cs1, 0x15AB, unknown_100D_D08F_1D15F);
    label_100D_15AB_1167B_41771:
        CheckExternalEvents(cs1, 0x15AB);
        // 100D:15AB mov AX,word ptr DS:[0x11EB]
        AX = UInt16[DS, (ushort)0x11EB];
        // 100D:15AE mov DX,0x000A
        DX = (ushort)0x000A;
        // 100D:15B1 mov BX,0x009D
        BX = (ushort)0x009D;
        // 100D:15B4 jmp near 0xD194
        return unknown_100D_D194_1D264(0x0000);
    }

    public virtual Action unknown_100D_15B7_11687(int loadOffset)
    {
    label_100D_15B7_11687_41742:
        CheckExternalEvents(cs1, 0x15B7);
        // 100D:15B7 mov AX,0x001E
        AX = (ushort)0x001E;
        // 100D:15BA call near 0xC13E
        NearCall(cs1, 0x15BD, unknown_100D_C13E_1C20E);
    label_100D_15BD_1168D_41747:
        CheckExternalEvents(cs1, 0x15BD);
        // 100D:15BD mov AX,5
        AX = (ushort)0x0005;
        // 100D:15C0 mov DX,0x0040
        DX = (ushort)0x0040;
        // 100D:15C3 mov BX,0x0034
        BX = (ushort)0x0034;
        // 100D:15C6 jmp near 0xC22F
        return unknown_100D_C22F_1C2FF(0x0000);
    }

    public virtual Action unknown_100D_15C9_11699(int loadOffset)
    {
    entrydispatcher:
    label_100D_15C9_11699_41857:
        CheckExternalEvents(cs1, 0x15C9);
        // 100D:15C9 mov DX,0x200A
        DX = (ushort)0x200A;
        // 100D:15CC call near 0x097E
        NearCall(cs1, 0x15CF, unknown_100D_097E_10A4E);
    label_100D_15CF_1169F_41862:
        CheckExternalEvents(cs1, 0x15CF);
        // 100D:15CF xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:15D1 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_15D4_116A4(int loadOffset)
    {
    entrydispatcher:
    label_100D_15D4_116A4_41867:
        CheckExternalEvents(cs1, 0x15D4);
        // 100D:15D4 mov DX,0x2003
        DX = (ushort)0x2003;
        // 100D:15D7 call near 0x097E
        NearCall(cs1, 0x15DA, unknown_100D_097E_10A4E);
    label_100D_15DA_116AA_41872:
        CheckExternalEvents(cs1, 0x15DA);
        // 100D:15DA mov AL,1
        AL = (byte)0x01;
        // 100D:15DC jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
