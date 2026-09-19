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
    public virtual Action unknown_100D_0771_10841(int loadOffset)
    {
    entrydispatcher:
    label_100D_0771_10841_9338:
        CheckExternalEvents(cs1, 0x0771);
        // 100D:0771 mov DX,0x2004
        DX = (ushort)0x2004;
        // 100D:0774 call near 0x0978
        NearCall(cs1, 0x0777, unknown_100D_0978_10A48);
    label_100D_0777_10847_9341:
        CheckExternalEvents(cs1, 0x0777);
        // 100D:0777 mov AL,1
        AL = (byte)0x01;
        // 100D:0779 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_077C_1084C(int loadOffset)
    {
    entrydispatcher:
    label_100D_077C_1084C_9572:
        CheckExternalEvents(cs1, 0x077C);
        // 100D:077C call near 0xC0AD
        NearCall(cs1, 0x077F, unknown_100D_C0AD_1C17D);
    label_100D_077F_1084F_9574:
        CheckExternalEvents(cs1, 0x077F);
        // 100D:077F mov BX,0x1080
        BX = (ushort)0x1080;
        // 100D:0782 mov DX,0x0803
        DX = (ushort)0x0803;
        // 100D:0785 jmp near 0x0981
        if (JumpDispatcher.Jump(unknown_100D_0981_10A51, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0788_10858(int loadOffset)
    {
    entrydispatcher:
    label_100D_0788_10858_9624:
        CheckExternalEvents(cs1, 0x0788);
        // 100D:0788 mov AL,7
        AL = (byte)0x07;
        // 100D:078A jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_078D_1085D(int loadOffset)
    {
    label_100D_078D_1085D_9627:
        CheckExternalEvents(cs1, 0x078D);
        // 100D:078D call near 0xC0F4
        NearCall(cs1, 0x0790, unknown_100D_C0F4_1C1C4);
    label_100D_0790_10860_9629:
        CheckExternalEvents(cs1, 0x0790);
        // 100D:0790 mov byte ptr DS:[0xDBE6],6
        UInt8[DS, (ushort)0xDBE6] = (byte)0x06;
        // 100D:0795 call near 0xC868
        NearCall(cs1, 0x0798, unknown_100D_C868_1C938);
        return unknown_100D_0798_10868(0x0000);
    }

    public virtual Action unknown_100D_0798_10868(int loadOffset)
    {
    label_100D_0798_10868_8372:
        CheckExternalEvents(cs1, 0x0798);
        // 100D:0798 mov word ptr DS:[0x4780],0x0190
        UInt16[DS, (ushort)0x4780] = (ushort)0x0190;
        // 100D:079E call near 0x9EFD
        NearCall(cs1, 0x07A1, unknown_100D_9EFD_19FCD);
    label_100D_07A1_10871_9048:
        CheckExternalEvents(cs1, 0x07A1);
        // 100D:07A1 clc
        CarryFlag = false;
        // 100D:07A2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_07A3_10873(int loadOffset)
    {
    entrydispatcher:
    label_100D_07A3_10873_9949:
        CheckExternalEvents(cs1, 0x07A3);
        // 100D:07A3 mov AX,0x002E
        AX = (ushort)0x002E;
        // 100D:07A6 call near 0xC13E
        NearCall(cs1, 0x07A9, unknown_100D_C13E_1C20E);
    label_100D_07A9_10879_9952:
        CheckExternalEvents(cs1, 0x07A9);
        // 100D:07A9 mov SI,0x1500
        SI = (ushort)0x1500;
        // 100D:07AC call near 0xC21B
        NearCall(cs1, 0x07AF, unknown_100D_C21B_1C2EB);
    label_100D_07AF_1087F_9955:
        CheckExternalEvents(cs1, 0x07AF);
        // 100D:07AF mov AX,1
        AX = (ushort)0x0001;
        // 100D:07B2 mov DX,0x0054
        DX = (ushort)0x0054;
        // 100D:07B5 mov BX,0x000B
        BX = (ushort)0x000B;
        // 100D:07B8 call near 0xC22F
        NearCall(cs1, 0x07BB, unknown_100D_C22F_1C2FF);
    label_100D_07BB_1088B_9960:
        CheckExternalEvents(cs1, 0x07BB);
        // 100D:07BB call near 0xC412
        NearCall(cs1, 0x07BE, unknown_100D_C412_1C4E2);
    label_100D_07BE_1088E_9962:
        CheckExternalEvents(cs1, 0x07BE);
        // 100D:07BE mov AL,6
        AL = (byte)0x06;
        // 100D:07C0 mov BP,0x0012
        BP = (ushort)0x0012;
        // 100D:07C3 jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_07C6_10896(int loadOffset)
    {
    entrydispatcher:
    label_100D_07C6_10896_10013:
        CheckExternalEvents(cs1, 0x07C6);
        // 100D:07C6 mov BX,0x1080
        BX = (ushort)0x1080;
        // 100D:07C9 mov DX,0x0802
        DX = (ushort)0x0802;
        // 100D:07CC mov word ptr DS:[0x0012],0x0100
        UInt16[DS, (ushort)0x0012] = (ushort)0x0100;
        // 100D:07D2 call near 0x0981
        NearCall(cs1, 0x07D5, unknown_100D_0981_10A51);
    label_100D_07D5_108A5_10022:
        CheckExternalEvents(cs1, 0x07D5);
        // 100D:07D5 mov word ptr DS:[0x0012],0
        UInt16[DS, (ushort)0x0012] = (ushort)0x0000;
        // 100D:07DB mov AL,5
        AL = (byte)0x05;
        // 100D:07DD jmp near 0x099D
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_07E0_108B0(int loadOffset)
    {
    entrydispatcher:
    label_100D_07E0_108B0_10987:
        CheckExternalEvents(cs1, 0x07E0);
        // 100D:07E0 mov AL,4
        AL = (byte)0x04;
        // 100D:07E2 call near 0xABDB
        NearCall(cs1, 0x07E5, unknown_100D_ABDB_1ACAB);
    label_100D_07E5_108B5_11001:
        CheckExternalEvents(cs1, 0x07E5);
        // 100D:07E5 mov DX,0x0804
        DX = (ushort)0x0804;
        // 100D:07E8 mov BX,0x1080
        BX = (ushort)0x1080;
        // 100D:07EB jmp near 0x0981
        if (JumpDispatcher.Jump(unknown_100D_0981_10A51, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_07EE_108BE(int loadOffset)
    {
    entrydispatcher:
    label_100D_07EE_108BE_9500:
        CheckExternalEvents(cs1, 0x07EE);
        // 100D:07EE mov AX,0x0030
        AX = (ushort)0x0030;
        // 100D:07F1 call near 0xC13E
        NearCall(cs1, 0x07F4, unknown_100D_C13E_1C20E);
    label_100D_07F4_108C4_9509:
        CheckExternalEvents(cs1, 0x07F4);
        // 100D:07F4 mov SI,0x1526
        SI = (ushort)0x1526;
        // 100D:07F7 call near 0xC21B
        NearCall(cs1, 0x07FA, unknown_100D_C21B_1C2EB);
    label_100D_07FA_108CA_9512:
        CheckExternalEvents(cs1, 0x07FA);
        // 100D:07FA jmp near 0x0960
        if (JumpDispatcher.Jump(unknown_100D_0960_10A30, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_07FD_108CD(int loadOffset)
    {
    label_100D_07FD_108CD_5961:
        CheckExternalEvents(cs1, 0x07FD);
        // 100D:07FD call near 0xC0AD
        NearCall(cs1, 0x0800, unknown_100D_C0AD_1C17D);
    label_100D_0800_108D0_5963:
        CheckExternalEvents(cs1, 0x0800);
        // 100D:0800 mov BL,8
        BL = (byte)0x08;
        return unknown_100D_0802_108D2(0x0000);
    }

    public virtual Action unknown_100D_0802_108D2(int loadOffset)
    {
    label_100D_0802_108D2_5965:
        CheckExternalEvents(cs1, 0x0802);
        // 100D:0802 call near 0x0820
        NearCall(cs1, 0x0805, unknown_100D_0820_108F0);
    label_100D_0805_108D5_5997:
        CheckExternalEvents(cs1, 0x0805);
        // 100D:0805 mov CX,0x00F0
        CX = (ushort)0x00F0;
        // 100D:0808 mov BX,0x0180
        BX = (ushort)0x0180;
        // 100D:080B call far dword ptr DS:[0x38BD]
        ushort targetSegment_6000 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_6000 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_6000 == cs2 && targetOffset_6000 == 0x0106)
        {
            FarCall(cs1, 0x080F, cs2, unknown_3358_0106_33686);
            goto label_100D_080F_108DF_6001;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_6000:X4}:{targetOffset_6000:X4} at 100D:080B");
    label_100D_080F_108DF_6001:
        CheckExternalEvents(cs1, 0x080F);
        // 100D:080F mov byte ptr DS:[0x46D7],0
        UInt8[DS, (ushort)0x46D7] = (byte)0x00;
        // 100D:0814 mov AX,0x002E
        AX = (ushort)0x002E;
        // 100D:0817 call near 0xC13E
        NearCall(cs1, 0x081A, unknown_100D_C13E_1C20E);
    label_100D_081A_108EA_6006:
        CheckExternalEvents(cs1, 0x081A);
        // 100D:081A mov SI,0x1500
        SI = (ushort)0x1500;
        // 100D:081D jmp near 0xC21B
        return unknown_100D_C21B_1C2EB(0x0000);
    }

    public virtual Action unknown_100D_0820_108F0(int loadOffset)
    {
    label_100D_0820_108F0_5966:
        CheckExternalEvents(cs1, 0x0820);
        // 100D:0820 mov AX,0x002E
        AX = (ushort)0x002E;
        // 100D:0823 jmp near 0x3978
        return unknown_100D_3978_13A48(0x0000);
    }

    public virtual Action unknown_100D_0826_108F6(int loadOffset)
    {
    label_100D_0826_108F6_6222:
        CheckExternalEvents(cs1, 0x0826);
        // 100D:0826 cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:082B jne short 0x0854
        if (!ZeroFlag)
        {
            goto label_100D_0854_10924_6268;
        }
    label_100D_082D_108FD_6225:
        CheckExternalEvents(cs1, 0x082D);
        // 100D:082D mov AL,byte ptr DS:[0x46D6]
        AL = UInt8[DS, (ushort)0x46D6];
        // 100D:0830 inc AX
        AX = Alu16.Inc(AX);
        // 100D:0831 cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:0833 je short 0x0857
        if (ZeroFlag)
        {
            goto label_100D_0857_10927_6350;
        }
    label_100D_0835_10905_6230:
        CheckExternalEvents(cs1, 0x0835);
        // 100D:0835 cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:0837 je short 0x0867
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:0837");
        }
    label_100D_0839_10909_6233:
        CheckExternalEvents(cs1, 0x0839);
        // 100D:0839 mov AH,0x0A
        AH = (byte)0x0A;
        // 100D:083B cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:083D je short 0x0841
        if (ZeroFlag)
        {
            goto label_100D_0841_10911_6239;
        }
    label_100D_083F_1090F_6237:
        CheckExternalEvents(cs1, 0x083F);
        // 100D:083F mov AH,0x1E
        AH = (byte)0x1E;
    label_100D_0841_10911_6239:
        CheckExternalEvents(cs1, 0x0841);
        // 100D:0841 mov byte ptr DS:[0x46D7],AH
        UInt8[DS, (ushort)0x46D7] = AH;
        // 100D:0845 mov BL,AL
        BL = AL;
        // 100D:0847 call near 0x0820
        NearCall(cs1, 0x084A, unknown_100D_0820_108F0);
    label_100D_084A_1091A_6242:
        CheckExternalEvents(cs1, 0x084A);
        // 100D:084A mov CX,0x00F0
        CX = (ushort)0x00F0;
        // 100D:084D mov BX,0x0180
        BX = (ushort)0x0180;
        // 100D:0850 call far dword ptr DS:[0x394D]
        ushort targetSegment_6245 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x394D + (ushort)0x0002)]));
        ushort targetOffset_6245 = unchecked((ushort)(UInt16[DS, (ushort)0x394D]));
        if (targetSegment_6245 == cs2 && targetOffset_6245 == 0x0172)
        {
            FarCall(cs1, 0x0854, cs2, unknown_3358_0172_336F2);
            goto label_100D_0854_10924_6268;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_6245:X4}:{targetOffset_6245:X4} at 100D:0850");
    label_100D_0854_10924_6268:
        CheckExternalEvents(cs1, 0x0854);
        // 100D:0854 jmp near 0x391D
        return unknown_100D_391D_139ED(0x0000);
    label_100D_0857_10927_6350:
        CheckExternalEvents(cs1, 0x0857);
        // 100D:0857 mov AX,9
        AX = (ushort)0x0009;
        // 100D:085A jmp near 0xC13E
        return unknown_100D_C13E_1C20E(0x0000);
    }

    public virtual Action unknown_100D_085D_1092D(int loadOffset)
    {
    label_100D_085D_1092D_6161:
        CheckExternalEvents(cs1, 0x085D);
        // 100D:085D mov SI,0x0826
        SI = (ushort)0x0826;
        // 100D:0860 mov BP,9
        BP = (ushort)0x0009;
        // 100D:0863 call near 0xDA25
        NearCall(cs1, 0x0866, unknown_100D_DA25_1DAF5);
    label_100D_0866_10936_6192:
        CheckExternalEvents(cs1, 0x0866);
        // 100D:0866 clc
        CarryFlag = false;
        // 100D:0867 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0868_10938(int loadOffset)
    {
    label_100D_0868_10938_10029:
        CheckExternalEvents(cs1, 0x0868);
        // 100D:0868 mov BL,0x0B
        BL = (byte)0x0B;
        // 100D:086A call near 0x0802
        NearCall(cs1, 0x086D, unknown_100D_0802_108D2);
    label_100D_086D_1093D_10033:
        CheckExternalEvents(cs1, 0x086D);
        // 100D:086D mov AX,7
        AX = (ushort)0x0007;
        // 100D:0870 mov DX,0x0013
        DX = (ushort)0x0013;
        // 100D:0873 mov BX,0x004A
        BX = (ushort)0x004A;
        // 100D:0876 call near 0xC22F
        NearCall(cs1, 0x0879, unknown_100D_C22F_1C2FF);
    label_100D_0879_10949_10038:
        CheckExternalEvents(cs1, 0x0879);
        // 100D:0879 clc
        CarryFlag = false;
        // 100D:087A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_087B_1094B(int loadOffset)
    {
    label_100D_087B_1094B_10041:
        CheckExternalEvents(cs1, 0x087B);
        // 100D:087B mov SI,0x0826
        SI = (ushort)0x0826;
        // 100D:087E mov BP,0x0010
        BP = (ushort)0x0010;
        // 100D:0881 call near 0xDA25
        NearCall(cs1, 0x0884, unknown_100D_DA25_1DAF5);
    label_100D_0884_10954_10045:
        CheckExternalEvents(cs1, 0x0884);
        // 100D:0884 clc
        CarryFlag = false;
        // 100D:0885 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0886_10956(int loadOffset)
    {
    entrydispatcher:
    label_100D_0886_10956_10049:
        CheckExternalEvents(cs1, 0x0886);
        // 100D:0886 mov AX,0x0030
        AX = (ushort)0x0030;
        // 100D:0889 call near 0xC13E
        NearCall(cs1, 0x088C, unknown_100D_C13E_1C20E);
    label_100D_088C_1095C_10052:
        CheckExternalEvents(cs1, 0x088C);
        // 100D:088C mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:088F mov AL,0xDE
        AL = (byte)0xDE;
        // 100D:0891 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:0895 call far dword ptr DS:[0x38DD]
        ushort targetSegment_10056 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_10056 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_10056 == cs2 && targetOffset_10056 == 0x011E)
        {
            FarCall(cs1, 0x0899, cs2, unknown_3358_011E_3369E);
            goto label_100D_0899_10969_10060;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10056:X4}:{targetOffset_10056:X4} at 100D:0895");
    label_100D_0899_10969_10060:
        CheckExternalEvents(cs1, 0x0899);
        // 100D:0899 mov SI,0x154E
        SI = (ushort)0x154E;
        // 100D:089C call near 0xC21B
        NearCall(cs1, 0x089F, unknown_100D_C21B_1C2EB);
    label_100D_089F_1096F_10063:
        CheckExternalEvents(cs1, 0x089F);
        // 100D:089F call near 0x5BA8
        NearCall(cs1, 0x08A2, unknown_100D_5BA8_15C78);
    label_100D_08A2_10972_10065:
        CheckExternalEvents(cs1, 0x08A2);
        // 100D:08A2 mov SI,0x155C
        SI = (ushort)0x155C;
        // 100D:08A5 call near 0xC32F
        NearCall(cs1, 0x08A8, unknown_100D_C32F_1C3FF);
    label_100D_08A8_10978_10124:
        CheckExternalEvents(cs1, 0x08A8);
        // 100D:08A8 call near 0xC412
        NearCall(cs1, 0x08AB, unknown_100D_C412_1C4E2);
    label_100D_08AB_1097B_10126:
        CheckExternalEvents(cs1, 0x08AB);
        // 100D:08AB mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:08AD mov DX,0x003A
        DX = (ushort)0x003A;
        // 100D:08B0 call near 0x09C7
        NearCall(cs1, 0x08B3, unknown_100D_09C7_10A97);
    label_100D_08B3_10983_10135:
        CheckExternalEvents(cs1, 0x08B3);
        // 100D:08B3 jmp near 0x978E
        if (JumpDispatcher.Jump(unknown_100D_978E_1985E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_08B6_10986(int loadOffset)
    {
    label_100D_08B6_10986_10165:
        CheckExternalEvents(cs1, 0x08B6);
        // 100D:08B6 mov AX,0x0030
        AX = (ushort)0x0030;
        // 100D:08B9 call near 0xC13E
        NearCall(cs1, 0x08BC, unknown_100D_C13E_1C20E);
    label_100D_08BC_1098C_10168:
        CheckExternalEvents(cs1, 0x08BC);
        // 100D:08BC call near 0xC412
        NearCall(cs1, 0x08BF, unknown_100D_C412_1C4E2);
    label_100D_08BF_1098F_10170:
        CheckExternalEvents(cs1, 0x08BF);
        // 100D:08BF call near 0x5BA8
        NearCall(cs1, 0x08C2, unknown_100D_5BA8_15C78);
    label_100D_08C2_10992_10172:
        CheckExternalEvents(cs1, 0x08C2);
        // 100D:08C2 mov DX,0xFFA0
        DX = (ushort)0xFFA0;
    label_100D_08C5_10995_10174:
        CheckExternalEvents(cs1, 0x08C5);
        // 100D:08C5 push DX
        Stack.Push16(DX);
        // 100D:08C6 call near 0xC43E
        NearCall(cs1, 0x08C9, unknown_100D_C43E_1C50E);
    label_100D_08C9_10999_10179:
        CheckExternalEvents(cs1, 0x08C9);
        // 100D:08C9 pop DX
        DX = Stack.Pop16();
        // 100D:08CA mov BX,0x000D
        BX = (ushort)0x000D;
        // 100D:08CD mov AX,5
        AX = (ushort)0x0005;
        // 100D:08D0 call near 0xC305
        NearCall(cs1, 0x08D3, unknown_100D_C305_1C3D5);
    label_100D_08D3_109A3_10192:
        CheckExternalEvents(cs1, 0x08D3);
        // 100D:08D3 mov AX,6
        AX = (ushort)0x0006;
        // 100D:08D6 call near 0xC305
        NearCall(cs1, 0x08D9, unknown_100D_C305_1C3D5);
    label_100D_08D9_109A9_10195:
        CheckExternalEvents(cs1, 0x08D9);
        // 100D:08D9 push DX
        Stack.Push16(DX);
        // 100D:08DA call near 0xC4DD
        NearCall(cs1, 0x08DD, unknown_100D_C4DD_1C5AD);
    label_100D_08DD_109AD_10198:
        CheckExternalEvents(cs1, 0x08DD);
        // 100D:08DD pop DX
        DX = Stack.Pop16();
        // 100D:08DE add DX,0x0020
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)32)));
        // 100D:08E1 jle short 0x08C5
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_08C5_10995_10174;
        }
    label_100D_08E3_109B3_10203:
        CheckExternalEvents(cs1, 0x08E3);
        // 100D:08E3 clc
        CarryFlag = false;
        // 100D:08E4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_08F0_109C0(int loadOffset)
    {
    label_100D_08F0_109C0_6601:
        CheckExternalEvents(cs1, 0x08F0);
        // 100D:08F0 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:08F2 mov byte ptr DS:[0x47A4],AL
        UInt8[DS, (ushort)0x47A4] = AL;
        // 100D:08F5 mov byte ptr DS:[0x46DF],AL
        UInt8[DS, (ushort)0x46DF] = AL;
        // 100D:08F8 mov word ptr DS:[4],DX
        UInt16[DS, (ushort)0x0004] = DX;
        // 100D:08FC mov word ptr DS:[6],BX
        UInt16[DS, (ushort)0x0006] = BX;
        // 100D:0900 mov byte ptr DS:[8],DH
        UInt8[DS, (ushort)0x0008] = DH;
        // 100D:0904 mov AL,0x1C
        AL = (byte)0x1C;
        // 100D:0906 mul BH
        ushort result_100D_0906_109D6 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)BH)));
        AH = unchecked((byte)(result_100D_0906_109D6 >> 8));
        AL = unchecked((byte)result_100D_0906_109D6);
        // 100D:0908 add AX,0x00E4
        AX = Alu16.Add(AX, (ushort)0x00E4);
        // 100D:090B mov word ptr DS:[0x114E],AX
        UInt16[DS, (ushort)0x114E] = AX;
        // 100D:090E jmp near 0x2D74
        return unknown_100D_2D74_12E44(0x0000);
    }

    public virtual Action unknown_100D_0911_109E1(int loadOffset)
    {
    label_100D_0911_109E1_3437:
        CheckExternalEvents(cs1, 0x0911);
        // 100D:0911 call near 0x39E6
        NearCall(cs1, 0x0914, unknown_100D_39E6_13AB6);
    label_100D_0914_109E4_3442:
        CheckExternalEvents(cs1, 0x0914);
        // 100D:0914 call near 0xB930
        NearCall(cs1, 0x0917, unknown_100D_B930_1BA00);
    label_100D_0917_109E7_3451:
        CheckExternalEvents(cs1, 0x0917);
        // 100D:0917 call near 0x0B21
        NearCall(cs1, 0x091A, unknown_100D_0B21_10BF1);
    label_100D_091A_109EA_3494:
        CheckExternalEvents(cs1, 0x091A);
        // 100D:091A call near 0x9985
        NearCall(cs1, 0x091D, unknown_100D_9985_19A55);
    label_100D_091D_109ED_3501:
        CheckExternalEvents(cs1, 0x091D);
        // 100D:091D call near 0x98E6
        NearCall(cs1, 0x0920, unknown_100D_98E6_199B6);
    label_100D_0920_109F0_3590:
        CheckExternalEvents(cs1, 0x0920);
        // 100D:0920 mov byte ptr DS:[0x22E3],1
        UInt8[DS, (ushort)0x22E3] = (byte)0x01;
        // 100D:0925 mov byte ptr DS:[0x46D7],0
        UInt8[DS, (ushort)0x46D7] = (byte)0x00;
        // 100D:092A mov SI,0x070C
        SI = (ushort)0x070C;
        // 100D:092D call near 0xDA5F
        NearCall(cs1, 0x0930, unknown_100D_DA5F_1DB2F);
    label_100D_0930_10A00_3595:
        CheckExternalEvents(cs1, 0x0930);
        // 100D:0930 mov SI,0x3916
        SI = (ushort)0x3916;
        // 100D:0933 call near 0xDA5F
        NearCall(cs1, 0x0936, unknown_100D_DA5F_1DB2F);
    label_100D_0936_10A06_3598:
        CheckExternalEvents(cs1, 0x0936);
        // 100D:0936 call near 0x0A3E
        NearCall(cs1, 0x0939, unknown_100D_0A3E_10B0E);
    label_100D_0939_10A09_3603:
        CheckExternalEvents(cs1, 0x0939);
        // 100D:0939 mov SI,0x0826
        SI = (ushort)0x0826;
        // 100D:093C jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    }

    public virtual Action unknown_100D_093F_10A0F(int loadOffset)
    {
    label_100D_093F_10A0F_3416:
        CheckExternalEvents(cs1, 0x093F);
        // 100D:093F mov SI,word ptr DS:[0x4854]
        SI = UInt16[DS, (ushort)0x4854];
        // 100D:0943 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        return unknown_100D_0945_10A15(0x0000);
    }

    public virtual Action unknown_100D_0945_10A15(int loadOffset)
    {
    label_100D_0945_10A15_3401:
        CheckExternalEvents(cs1, 0x0945);
        // 100D:0945 mov word ptr DS:[0x4854],SI
        UInt16[DS, (ushort)0x4854] = SI;
        // 100D:0949 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_094A_10A1A(int loadOffset)
    {
    label_100D_094A_10A1A_12771:
        CheckExternalEvents(cs1, 0x094A);
        // 100D:094A call near 0x38B4
        NearCall(cs1, 0x094D, unknown_100D_38B4_13984);
    label_100D_094D_10A1D_12841:
        CheckExternalEvents(cs1, 0x094D);
        // 100D:094D mov AX,0x002D
        AX = (ushort)0x002D;
        // 100D:0950 call near 0xC13E
        NearCall(cs1, 0x0953, unknown_100D_C13E_1C20E);
    label_100D_0953_10A23_12844:
        CheckExternalEvents(cs1, 0x0953);
        // 100D:0953 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0955 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:0957 mov BX,0x003C
        BX = (ushort)0x003C;
        // 100D:095A jmp near 0xC22F
        return unknown_100D_C22F_1C2FF(0x0000);
    }

    public virtual Action unknown_100D_095D_10A2D(int loadOffset)
    {
    entrydispatcher:
    label_100D_095D_10A2D_41854:
        CheckExternalEvents(cs1, 0x095D);
        // 100D:095D call near 0x094A
        NearCall(cs1, 0x0960, unknown_100D_094A_10A1A);
        if (JumpDispatcher.Jump(unknown_100D_0960_10A30, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0972_10A42(int loadOffset)
    {
    entrydispatcher:
    label_100D_0972_10A42_6594:
        CheckExternalEvents(cs1, 0x0972);
        // 100D:0972 call near 0xC0AD
        NearCall(cs1, 0x0975, unknown_100D_C0AD_1C17D);
    label_100D_0975_10A45_6596:
        CheckExternalEvents(cs1, 0x0975);
        // 100D:0975 mov DX,0x2002
        DX = (ushort)0x2002;
        if (JumpDispatcher.Jump(unknown_100D_0978_10A48, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0978_10A48(int loadOffset)
    {
    entrydispatcher:
    label_100D_0978_10A48_6598:
        CheckExternalEvents(cs1, 0x0978);
        // 100D:0978 mov word ptr DS:[0x0012],0
        UInt16[DS, (ushort)0x0012] = (ushort)0x0000;
        if (JumpDispatcher.Jump(unknown_100D_097E_10A4E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_097E_10A4E(int loadOffset)
    {
    entrydispatcher:
    label_100D_097E_10A4E_6599:
        CheckExternalEvents(cs1, 0x097E);
        // 100D:097E mov BX,0x0180
        BX = (ushort)0x0180;
        if (JumpDispatcher.Jump(unknown_100D_0981_10A51, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0981_10A51(int loadOffset)
    {
    entrydispatcher:
    label_100D_0981_10A51_6600:
        CheckExternalEvents(cs1, 0x0981);
        // 100D:0981 call near 0x08F0
        NearCall(cs1, 0x0984, unknown_100D_08F0_109C0);
    label_100D_0984_10A54_6656:
        CheckExternalEvents(cs1, 0x0984);
        // 100D:0984 call near 0x37B2
        NearCall(cs1, 0x0987, unknown_100D_37B2_13882);
    label_100D_0987_10A57_6986:
        CheckExternalEvents(cs1, 0x0987);
        // 100D:0987 jmp near 0xC412
        return unknown_100D_C412_1C4E2(0x0000);
    }

    public virtual Action unknown_100D_098A_10A5A(int loadOffset)
    {
    entrydispatcher:
    label_100D_098A_10A5A_7009:
        CheckExternalEvents(cs1, 0x098A);
        // 100D:098A mov word ptr DS:[0x0012],2
        UInt16[DS, (ushort)0x0012] = (ushort)0x0002;
        // 100D:0990 mov DX,0x2004
        DX = (ushort)0x2004;
        // 100D:0993 jmp short 0x097E
        if (JumpDispatcher.Jump(unknown_100D_097E_10A4E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0995_10A65(int loadOffset)
    {
    entrydispatcher:
    label_100D_0995_10A65_7833:
        CheckExternalEvents(cs1, 0x0995);
        // 100D:0995 mov DX,0x200A
        DX = (ushort)0x200A;
        // 100D:0998 call near 0x0978
        NearCall(cs1, 0x099B, unknown_100D_0978_10A48);
    label_100D_099B_10A6B_7843:
        CheckExternalEvents(cs1, 0x099B);
        // 100D:099B xor AL,AL
        AL = Alu8.Xor(AL, AL);
        if (JumpDispatcher.Jump(unknown_100D_099D_10A6D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_09A5_10A75(int loadOffset)
    {
    label_100D_09A5_10A75_9557:
        CheckExternalEvents(cs1, 0x09A5);
        // 100D:09A5 call near 0xC0AD
        NearCall(cs1, 0x09A8, unknown_100D_C0AD_1C17D);
    label_100D_09A8_10A78_9559:
        CheckExternalEvents(cs1, 0x09A8);
        // 100D:09A8 mov AL,0x62
        AL = (byte)0x62;
        // 100D:09AA jmp near 0xC2F2
        return unknown_100D_C2F2_1C3C2(0x0000);
    }

    public virtual Action unknown_100D_09AD_10A7D(int loadOffset)
    {
    entrydispatcher:
    label_100D_09AD_10A7D_10147:
        CheckExternalEvents(cs1, 0x09AD);
        // 100D:09AD mov AX,0x0030
        AX = (ushort)0x0030;
        // 100D:09B0 call near 0xC13E
        NearCall(cs1, 0x09B3, unknown_100D_C13E_1C20E);
    label_100D_09B3_10A83_10150:
        CheckExternalEvents(cs1, 0x09B3);
        // 100D:09B3 mov SI,0x153A
        SI = (ushort)0x153A;
        // 100D:09B6 call near 0xC21B
        NearCall(cs1, 0x09B9, unknown_100D_C21B_1C2EB);
    label_100D_09B9_10A89_10153:
        CheckExternalEvents(cs1, 0x09B9);
        // 100D:09B9 call near 0xC412
        NearCall(cs1, 0x09BC, unknown_100D_C412_1C4E2);
    label_100D_09BC_10A8C_10155:
        CheckExternalEvents(cs1, 0x09BC);
        // 100D:09BC mov AL,9
        AL = (byte)0x09;
        // 100D:09BE mov DX,0x0052
        DX = (ushort)0x0052;
        // 100D:09C1 call near 0x09C7
        NearCall(cs1, 0x09C4, unknown_100D_09C7_10A97);
    label_100D_09C4_10A94_10159:
        CheckExternalEvents(cs1, 0x09C4);
        // 100D:09C4 jmp near 0x978E
        if (JumpDispatcher.Jump(unknown_100D_978E_1985E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_09C7_10A97(int loadOffset)
    {
    label_100D_09C7_10A97_7847:
        CheckExternalEvents(cs1, 0x09C7);
        // 100D:09C7 push DX
        Stack.Push16(DX);
        // 100D:09C8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:09CA mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:09CD call near 0x91A0
        NearCall(cs1, 0x09D0, unknown_100D_91A0_19270);
    label_100D_09D0_10AA0_7913:
        CheckExternalEvents(cs1, 0x09D0);
        // 100D:09D0 mov byte ptr DS:[0x478C],0x1E
        UInt8[DS, (ushort)0x478C] = (byte)0x1E;
        // 100D:09D5 mov DI,0x1BF0
        DI = (ushort)0x1BF0;
        // 100D:09D8 pop AX
        AX = Stack.Pop16();
        // 100D:09D9 cmp word ptr DS:[DI],AX
        Alu16.Sub(UInt16[DS, DI], AX);
        // 100D:09DB jae short 0x09EE
        if (!CarryFlag)
        {
            goto label_100D_09EE_10ABE_7919;
        }
    label_100D_09DD_10AAD_10130:
        CheckExternalEvents(cs1, 0x09DD);
        // 100D:09DD add word ptr DS:[DI],AX
        UInt16[DS, DI] = Alu16.Add(UInt16[DS, DI], AX);
        // 100D:09DF add word ptr DS:[DI+4],AX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)4)], AX);
        // 100D:09E2 cmp word ptr DS:[DI+4],0x0140
        Alu16.Sub(UInt16[DS, (ushort)(DI + (sbyte)4)], (ushort)0x0140);
        // 100D:09E7 jle short 0x09EE
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_09EE_10ABE_7919;
        }
    label_100D_09E9_10AB9_39868:
        CheckExternalEvents(cs1, 0x09E9);
        // 100D:09E9 mov word ptr DS:[DI+4],0x0140
        UInt16[DS, (ushort)(DI + (sbyte)4)] = (ushort)0x0140;
    label_100D_09EE_10ABE_7919:
        CheckExternalEvents(cs1, 0x09EE);
        // 100D:09EE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_09EF_10ABF(int loadOffset)
    {
    entrydispatcher:
    label_100D_09EF_10ABF_11535:
        CheckExternalEvents(cs1, 0x09EF);
        // 100D:09EF mov AX,0x0014
        AX = (ushort)0x0014;
        // 100D:09F2 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_09F5_10AC5(int loadOffset)
    {
    label_100D_09F5_10AC5_40193:
        CheckExternalEvents(cs1, 0x09F5);
        // 100D:09F5 call near 0x09EF
        NearCall(cs1, 0x09F8, unknown_100D_09EF_10ABF);
    label_100D_09F8_10AC8_40202:
        CheckExternalEvents(cs1, 0x09F8);
        // 100D:09F8 call near 0xC0F4
        NearCall(cs1, 0x09FB, unknown_100D_C0F4_1C1C4);
    label_100D_09FB_10ACB_40205:
        CheckExternalEvents(cs1, 0x09FB);
        // 100D:09FB cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:0A00 jne short 0x0A09
        if (!ZeroFlag)
        {
            goto label_100D_0A09_10AD9_40208;
        }
    label_100D_0A02_10AD2_40210:
        CheckExternalEvents(cs1, 0x0A02);
        // 100D:0A02 test byte ptr DS:[0x3810],1
        Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0x01);
        // 100D:0A07 jne short 0x0A0C
        if (!ZeroFlag)
        {
            goto label_100D_0A0C_10ADC_40214;
        }
    label_100D_0A09_10AD9_40208:
        CheckExternalEvents(cs1, 0x0A09);
        // 100D:0A09 call near 0xAD50
        NearCall(cs1, 0x0A0C, unknown_100D_AD50_1AE20);
    label_100D_0A0C_10ADC_40214:
        CheckExternalEvents(cs1, 0x0A0C);
        // 100D:0A0C mov SI,0x0A16
        SI = (ushort)0x0A16;
        // 100D:0A0F xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:0A11 call near 0xDA25
        NearCall(cs1, 0x0A14, unknown_100D_DA25_1DAF5);
    label_100D_0A14_10AE4_40227:
        CheckExternalEvents(cs1, 0x0A14);
        // 100D:0A14 clc
        CarryFlag = false;
        // 100D:0A15 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0A16_10AE6(int loadOffset)
    {
    label_100D_0A16_10AE6_11547:
        CheckExternalEvents(cs1, 0x0A16);
        // 100D:0A16 push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:0A1A call near 0x0A23
        NearCall(cs1, 0x0A1D, unknown_100D_0A23_10AF3);
    label_100D_0A1D_10AED_11563:
        CheckExternalEvents(cs1, 0x0A1D);
        // 100D:0A1D pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_0A1D_10AED = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_0A1D_10AED = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_0A1D_10AED = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_0A1D_10AED);
        return unknown_100D_0A21_10AF1(0x0000);
    }

    public virtual Action unknown_100D_0A23_10AF3(int loadOffset)
    {
    entrydispatcher:
    label_100D_0A23_10AF3_11550:
        CheckExternalEvents(cs1, 0x0A23);
        // 100D:0A23 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:0A28 je short 0x0A30
        if (ZeroFlag)
        {
            goto label_100D_0A30_10B00_40241;
        }
    label_100D_0A2A_10AFA_11553:
        CheckExternalEvents(cs1, 0x0A2A);
        // 100D:0A2A call near 0xC08E
        NearCall(cs1, 0x0A2D, unknown_100D_C08E_1C15E);
    label_100D_0A2D_10AFD_11555:
        CheckExternalEvents(cs1, 0x0A2D);
        // 100D:0A2D jmp near 0xCA60
        if (JumpDispatcher.Jump(unknown_100D_CA60_1CB30, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_0A30_10B00_40241:
        CheckExternalEvents(cs1, 0x0A30);
        // 100D:0A30 call near 0xC07C
        NearCall(cs1, 0x0A33, unknown_100D_C07C_1C14C);
    label_100D_0A33_10B03_40244:
        CheckExternalEvents(cs1, 0x0A33);
        // 100D:0A33 call near 0xC9F4
        NearCall(cs1, 0x0A36, unknown_100D_C9F4_1CAC4);
    label_100D_0A36_10B06_40247:
        CheckExternalEvents(cs1, 0x0A36);
        // 100D:0A36 je short 0x0A21
        if (ZeroFlag)
        {
            return unknown_100D_0A21_10AF1(0x0000);
        }
    label_100D_0A38_10B08_40251:
        CheckExternalEvents(cs1, 0x0A38);
        // 100D:0A38 call near 0xC4DD
        NearCall(cs1, 0x0A3B, unknown_100D_C4DD_1C5AD);
    label_100D_0A3B_10B0B_40255:
        CheckExternalEvents(cs1, 0x0A3B);
        // 100D:0A3B jmp near 0xDBEC
        if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0A3E_10B0E(int loadOffset)
    {
    label_100D_0A3E_10B0E_3600:
        CheckExternalEvents(cs1, 0x0A3E);
        // 100D:0A3E mov SI,0x0A16
        SI = (ushort)0x0A16;
        // 100D:0A41 jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    }

    public virtual Action unknown_100D_0A44_10B14(int loadOffset)
    {
    label_100D_0A44_10B14_11610:
        CheckExternalEvents(cs1, 0x0A44);
        // 100D:0A44 mov AX,0x002C
        AX = (ushort)0x002C;
        // 100D:0A47 call near 0xC13E
        NearCall(cs1, 0x0A4A, unknown_100D_C13E_1C20E);
    label_100D_0A4A_10B1A_11613:
        CheckExternalEvents(cs1, 0x0A4A);
        // 100D:0A4A call near 0x5BA8
        NearCall(cs1, 0x0A4D, unknown_100D_5BA8_15C78);
    label_100D_0A4D_10B1D_11615:
        CheckExternalEvents(cs1, 0x0A4D);
        // 100D:0A4D call near 0xC07C
        NearCall(cs1, 0x0A50, unknown_100D_C07C_1C14C);
    label_100D_0A50_10B20_11617:
        CheckExternalEvents(cs1, 0x0A50);
        // 100D:0A50 push CX
        Stack.Push16(CX);
        // 100D:0A51 call near 0xC432
        NearCall(cs1, 0x0A54, unknown_100D_C432_1C502);
    label_100D_0A54_10B24_11620:
        CheckExternalEvents(cs1, 0x0A54);
        // 100D:0A54 pop AX
        AX = Stack.Pop16();
        // 100D:0A55 push AX
        Stack.Push16(AX);
        // 100D:0A56 mul AL
        ushort result_100D_0A56_10B26 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AL)));
        AH = unchecked((byte)(result_100D_0A56_10B26 >> 8));
        AL = unchecked((byte)result_100D_0A56_10B26);
        // 100D:0A58 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0A5A mov DX,AX
        DX = AX;
        // 100D:0A5C neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:0A5E push DX
        Stack.Push16(DX);
        // 100D:0A5F xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:0A61 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0A63 call near 0xC305
        NearCall(cs1, 0x0A66, unknown_100D_C305_1C3D5);
    label_100D_0A66_10B36_11631:
        CheckExternalEvents(cs1, 0x0A66);
        // 100D:0A66 mov AX,1
        AX = (ushort)0x0001;
        // 100D:0A69 add DX,0x0130
        DX = Alu16.Add(DX, (ushort)0x0130);
        // 100D:0A6D call near 0xC305
        NearCall(cs1, 0x0A70, unknown_100D_C305_1C3D5);
    label_100D_0A70_10B40_11644:
        CheckExternalEvents(cs1, 0x0A70);
        // 100D:0A70 mov AX,2
        AX = (ushort)0x0002;
        // 100D:0A73 add DX,0x0130
        DX = Alu16.Add(DX, (ushort)0x0130);
        // 100D:0A77 call near 0xC30D
        NearCall(cs1, 0x0A7A, unknown_100D_C30D_1C3DD);
    label_100D_0A7A_10B4A_11648:
        CheckExternalEvents(cs1, 0x0A7A);
        // 100D:0A7A pop DX
        DX = Stack.Pop16();
        // 100D:0A7B push DX
        Stack.Push16(DX);
        // 100D:0A7C shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:0A7E push DX
        Stack.Push16(DX);
        // 100D:0A7F shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:0A81 add DX,0x0045
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)69)));
        // 100D:0A84 mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:0A87 mov BX,0x004E
        BX = (ushort)0x004E;
        // 100D:0A8A call near 0xC343
        NearCall(cs1, 0x0A8D, unknown_100D_C343_1C413);
    label_100D_0A8D_10B5D_11680:
        CheckExternalEvents(cs1, 0x0A8D);
        // 100D:0A8D pop DX
        DX = Stack.Pop16();
        // 100D:0A8E pop CX
        CX = Stack.Pop16();
        // 100D:0A8F pop AX
        AX = Stack.Pop16();
        // 100D:0A90 push AX
        Stack.Push16(AX);
        // 100D:0A91 push CX
        Stack.Push16(CX);
        // 100D:0A92 add DX,0x03E2
        DX = Alu16.Add(DX, (ushort)0x03E2);
        // 100D:0A96 cmp AX,0x0014
        Alu16.Sub(AX, (ushort)0x0014);
        // 100D:0A99 ja short 0x0AA5
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_0AA5_10B75_11694;
        }
    label_100D_0A9B_10B6B_11689:
        CheckExternalEvents(cs1, 0x0A9B);
        // 100D:0A9B mov DX,AX
        DX = AX;
        // 100D:0A9D shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:0A9F shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:0AA1 add DX,0x00F2
        DX = Alu16.Add(DX, (ushort)0x00F2);
    label_100D_0AA5_10B75_11694:
        CheckExternalEvents(cs1, 0x0AA5);
        // 100D:0AA5 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0AA7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0AA9 add AX,0x0025
        AX = Alu16.Add(AX, (ushort)0x0025);
        // 100D:0AAC mov BX,0x0067
        BX = (ushort)0x0067;
        // 100D:0AAF call near 0xC343
        NearCall(cs1, 0x0AB2, unknown_100D_C343_1C413);
    label_100D_0AB2_10B82_11699:
        CheckExternalEvents(cs1, 0x0AB2);
        // 100D:0AB2 pop DX
        DX = Stack.Pop16();
        // 100D:0AB3 pop AX
        AX = Stack.Pop16();
        // 100D:0AB4 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:0AB6 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:0AB8 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:0ABA shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:0ABC shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:0ABE add DX,0x0080
        DX = Alu16.Add(DX, (ushort)0x0080);
        // 100D:0AC2 add AL,3
        AL = Alu8.Add(AL, (byte)0x03);
        // 100D:0AC4 mov BX,0x004F
        BX = (ushort)0x004F;
        // 100D:0AC7 call near 0xC343
        NearCall(cs1, 0x0ACA, unknown_100D_C343_1C413);
    label_100D_0ACA_10B9A_11711:
        CheckExternalEvents(cs1, 0x0ACA);
        // 100D:0ACA jmp near 0xC4DD
        return unknown_100D_C4DD_1C5AD(0x0000);
    }

    public virtual Action unknown_100D_0ACD_10B9D(int loadOffset)
    {
    label_100D_0ACD_10B9D_10206:
        CheckExternalEvents(cs1, 0x0ACD);
        // 100D:0ACD mov word ptr DS:[0x2786],0xC827
        UInt16[DS, (ushort)0x2786] = (ushort)0xC827;
        // 100D:0AD3 mov byte ptr CS:[0xC13C],0x2B
        UInt8[CS, (ushort)0xC13C] = (byte)0x2B;
        // 100D:0AD9 call near 0xC13B
        NearCall(cs1, 0x0ADC, unknown_100D_C13B_1C20B);
    label_100D_0ADC_10BAC_10212:
        CheckExternalEvents(cs1, 0x0ADC);
        // 100D:0ADC call near 0xC07C
        NearCall(cs1, 0x0ADF, unknown_100D_C07C_1C14C);
    label_100D_0ADF_10BAF_10214:
        CheckExternalEvents(cs1, 0x0ADF);
        // 100D:0ADF mov SI,0x1582
        SI = (ushort)0x1582;
        // 100D:0AE2 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:0AE6 mov AX,2
        AX = (ushort)0x0002;
        // 100D:0AE9 call near 0xC370
        NearCall(cs1, 0x0AEC, unknown_100D_C370_1C440);
    label_100D_0AEC_10BBC_10316:
        CheckExternalEvents(cs1, 0x0AEC);
        // 100D:0AEC mov SI,0x158A
        SI = (ushort)0x158A;
        // 100D:0AEF mov AX,3
        AX = (ushort)0x0003;
        // 100D:0AF2 call near 0xC370
        NearCall(cs1, 0x0AF5, unknown_100D_C370_1C440);
    label_100D_0AF5_10BC5_10320:
        CheckExternalEvents(cs1, 0x0AF5);
        // 100D:0AF5 mov SI,0x11DD
        SI = (ushort)0x11DD;
        // 100D:0AF8 call near 0xC21B
        NearCall(cs1, 0x0AFB, unknown_100D_C21B_1C2EB);
    label_100D_0AFB_10BCB_10323:
        CheckExternalEvents(cs1, 0x0AFB);
        // 100D:0AFB call near 0x5BA0
        NearCall(cs1, 0x0AFE, unknown_100D_5BA0_15C70);
    label_100D_0AFE_10BCE_10329:
        CheckExternalEvents(cs1, 0x0AFE);
        // 100D:0AFE mov DI,0x4856
        DI = (ushort)0x4856;
        // 100D:0B01 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0B03 push DS
        Stack.Push16(DS);
        // 100D:0B04 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:0B05 mov CX,8
        CX = (ushort)0x0008;
        // 100D:0B08 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:0B0A mov SI,0x0B45
        SI = (ushort)0x0B45;
        // 100D:0B0D call near 0xDA5F
        NearCall(cs1, 0x0B10, unknown_100D_DA5F_1DB2F);
    label_100D_0B10_10BE0_10338:
        CheckExternalEvents(cs1, 0x0B10);
        // 100D:0B10 mov SI,0x0B45
        SI = (ushort)0x0B45;
        // 100D:0B13 mov BP,3
        BP = (ushort)0x0003;
        // 100D:0B16 call near 0xDA25
        NearCall(cs1, 0x0B19, unknown_100D_DA25_1DAF5);
    label_100D_0B19_10BE9_10342:
        CheckExternalEvents(cs1, 0x0B19);
        // 100D:0B19 call near 0xC412
        NearCall(cs1, 0x0B1C, unknown_100D_C412_1C4E2);
    label_100D_0B1C_10BEC_10344:
        CheckExternalEvents(cs1, 0x0B1C);
        // 100D:0B1C mov AL,3
        AL = (byte)0x03;
        // 100D:0B1E jmp near 0xAB15
        return unknown_100D_AB15_1ABE5(0x0000);
    }

    public virtual Action unknown_100D_0B21_10BF1(int loadOffset)
    {
    label_100D_0B21_10BF1_3453:
        CheckExternalEvents(cs1, 0x0B21);
        // 100D:0B21 call near 0xAC30
        NearCall(cs1, 0x0B24, unknown_100D_AC30_1AD00);
    label_100D_0B24_10BF4_3484:
        CheckExternalEvents(cs1, 0x0B24);
        // 100D:0B24 mov byte ptr CS:[0xC13C],0x25
        UInt8[CS, (ushort)0xC13C] = (byte)0x25;
        // 100D:0B2A mov SI,0x0B45
        SI = (ushort)0x0B45;
        // 100D:0B2D call near 0xDA5F
        NearCall(cs1, 0x0B30, unknown_100D_DA5F_1DB2F);
    label_100D_0B30_10C00_3488:
        CheckExternalEvents(cs1, 0x0B30);
        // 100D:0B30 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:0B35 jne short 0x0B3E
        if (!ZeroFlag)
        {
            goto label_100D_0B3E_10C0E_3491;
        }
    label_100D_0B37_10C07_12954:
        CheckExternalEvents(cs1, 0x0B37);
        // 100D:0B37 cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:0B3C js short 0x0B44
        if (SignFlag)
        {
            goto label_100D_0B44_10C14_3493;
        }
    label_100D_0B3E_10C0E_3491:
        CheckExternalEvents(cs1, 0x0B3E);
        // 100D:0B3E mov word ptr DS:[0x3CBE],0
        UInt16[DS, (ushort)0x3CBE] = (ushort)0x0000;
    label_100D_0B44_10C14_3493:
        CheckExternalEvents(cs1, 0x0B44);
        // 100D:0B44 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0B45_10C15(int loadOffset)
    {
    label_100D_0B45_10C15_10398:
        CheckExternalEvents(cs1, 0x0B45);
        // 100D:0B45 mov SI,0x4856
        SI = (ushort)0x4856;
        // 100D:0B48 dec byte ptr DS:[SI+7]
        UInt8[DS, (ushort)(SI + (sbyte)7)] = Alu8.Dec(UInt8[DS, (ushort)(SI + (sbyte)7)]);
        // 100D:0B4B cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:0B50 jg short 0x0B5F
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_0B5F_10C2F_10407;
        }
    label_100D_0B52_10C22_10403:
        CheckExternalEvents(cs1, 0x0B52);
        // 100D:0B52 mov BL,byte ptr DS:[SI+7]
        BL = UInt8[DS, (ushort)(SI + (sbyte)7)];
        // 100D:0B55 cmp BL,0x10
        Alu8.Sub(BL, (byte)0x10);
        // 100D:0B58 ja short 0x0B5F
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_0B5F_10C2F_10407;
        }
    label_100D_0B5A_10C2A_10729:
        CheckExternalEvents(cs1, 0x0B5A);
        // 100D:0B5A push SI
        Stack.Push16(SI);
        // 100D:0B5B call near 0x0D0D
        NearCall(cs1, 0x0B5E, unknown_100D_0D0D_10DDD);
    label_100D_0B5E_10C2E_10761:
        CheckExternalEvents(cs1, 0x0B5E);
        // 100D:0B5E pop SI
        SI = Stack.Pop16();
    label_100D_0B5F_10C2F_10407:
        CheckExternalEvents(cs1, 0x0B5F);
        // 100D:0B5F mov AX,word ptr DS:[0x479E]
        AX = UInt16[DS, (ushort)0x479E];
        // 100D:0B62 or AL,byte ptr DS:[0x46EB]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0x46EB]);
        // 100D:0B66 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:0B68 je short 0x0B6B
        if (ZeroFlag)
        {
            goto label_100D_0B6B_10C3B_10412;
        }
    label_100D_0B6A_10C3A_36326:
        CheckExternalEvents(cs1, 0x0B6A);
        // 100D:0B6A ret near
        return NearRet((ushort)0x0000);
    label_100D_0B6B_10C3B_10412:
        CheckExternalEvents(cs1, 0x0B6B);
        // 100D:0B6B dec word ptr DS:[SI+4]
        UInt16[DS, (ushort)(SI + (sbyte)4)] = Alu16.Dec(UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:0B6E jns short 0x0BB7
        if (!SignFlag)
        {
            goto label_100D_0BB7_10C87_10427;
        }
    label_100D_0B70_10C40_10415:
        CheckExternalEvents(cs1, 0x0B70);
        // 100D:0B70 dec byte ptr DS:[SI+6]
        UInt8[DS, (ushort)(SI + (sbyte)6)] = Alu8.Dec(UInt8[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:0B73 jns short 0x0B86
        if (!SignFlag)
        {
            goto label_100D_0B86_10C56_10858;
        }
    label_100D_0B75_10C45_10418:
        CheckExternalEvents(cs1, 0x0B75);
        // 100D:0B75 call near 0xE3CC
        NearCall(cs1, 0x0B78, unknown_100D_E3CC_1E49C);
    label_100D_0B78_10C48_10420:
        CheckExternalEvents(cs1, 0x0B78);
        // 100D:0B78 and AL,0x7F
        AL = Alu8.And(AL, (byte)0x7F);
        // 100D:0B7A mov byte ptr DS:[SI+6],AL
        UInt8[DS, (ushort)(SI + (sbyte)6)] = AL;
        // 100D:0B7D mov AL,AH
        AL = AH;
        // 100D:0B7F xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:0B81 mov word ptr DS:[SI+4],AX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = AX;
        // 100D:0B84 jmp short 0x0BB7
        goto label_100D_0BB7_10C87_10427;
    label_100D_0B86_10C56_10858:
        CheckExternalEvents(cs1, 0x0B86);
        // 100D:0B86 call near 0xE3CC
        NearCall(cs1, 0x0B89, unknown_100D_E3CC_1E49C);
    label_100D_0B89_10C59_10860:
        CheckExternalEvents(cs1, 0x0B89);
        // 100D:0B89 mov BX,AX
        BX = AX;
        // 100D:0B8B mov DX,AX
        DX = AX;
        // 100D:0B8D and BX,0x007F
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)127)));
        // 100D:0B90 cmp BL,0x60
        Alu8.Sub(BL, (byte)0x60);
        // 100D:0B93 jae short 0x0BB7
        if (!CarryFlag)
        {
            goto label_100D_0BB7_10C87_10427;
        }
    label_100D_0B95_10C65_10866:
        CheckExternalEvents(cs1, 0x0B95);
        // 100D:0B95 cmp BL,0x30
        Alu8.Sub(BL, (byte)0x30);
        // 100D:0B98 jb short 0x0BB7
        if (CarryFlag)
        {
            goto label_100D_0BB7_10C87_10427;
        }
    label_100D_0B9A_10C6A_10869:
        CheckExternalEvents(cs1, 0x0B9A);
        // 100D:0B9A xchg DL,DH
        byte temp_100D_0B9A_10C6A = DL;
        DL = DH;
        DH = unchecked((byte)temp_100D_0B9A_10C6A);
        // 100D:0B9C rol DH,1
        DH = Alu8.Rol(DH, unchecked((byte)1));
        // 100D:0B9E and DX,0x01FF
        DX = Alu16.And(DX, (ushort)0x01FF);
        // 100D:0BA2 cmp DX,0x0140
        Alu16.Sub(DX, (ushort)0x0140);
        // 100D:0BA6 jae short 0x0BB7
        if (!CarryFlag)
        {
            goto label_100D_0BB7_10C87_10427;
        }
    label_100D_0BA8_10C78_10875:
        CheckExternalEvents(cs1, 0x0BA8);
        // 100D:0BA8 mov AX,BX
        AX = BX;
        // 100D:0BAA and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
        // 100D:0BAD add AX,0x001C
        AX = Alu16.Add(AX, (ushort)0x001C);
        // 100D:0BB0 push SI
        Stack.Push16(SI);
        // 100D:0BB1 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:0BB3 call near 0xC60B
        NearCall(cs1, 0x0BB6, unknown_100D_C60B_1C6DB);
    label_100D_0BB6_10C86_10882:
        CheckExternalEvents(cs1, 0x0BB6);
        // 100D:0BB6 pop SI
        SI = Stack.Pop16();
    label_100D_0BB7_10C87_10427:
        CheckExternalEvents(cs1, 0x0BB7);
        // 100D:0BB7 dec byte ptr DS:[SI]
        UInt8[DS, SI] = Alu8.Dec(UInt8[DS, SI]);
        // 100D:0BB9 jns short 0x0BBE
        if (!SignFlag)
        {
            goto label_100D_0BBE_10C8E_10526;
        }
    label_100D_0BBB_10C8B_10430:
        CheckExternalEvents(cs1, 0x0BBB);
        // 100D:0BBB call near 0x0C3B
        NearCall(cs1, 0x0BBE, unknown_100D_0C3B_10D0B);
    label_100D_0BBE_10C8E_10526:
        CheckExternalEvents(cs1, 0x0BBE);
        // 100D:0BBE mov DI,0x3CC0
        DI = (ushort)0x3CC0;
        // 100D:0BC1 mov CX,word ptr DS:[DI-2]
        CX = UInt16[DS, (ushort)(DI + (sbyte)-2)];
        // 100D:0BC4 jcxz short 0x0C3A
        if (CX == (ushort)0x0000)
        {
            goto label_100D_0C3A_10D0A_10727;
        }
    label_100D_0BC6_10C96_10530:
        CheckExternalEvents(cs1, 0x0BC6);
        // 100D:0BC6 mov AX,word ptr DS:[DI+8]
        AX = UInt16[DS, (ushort)(DI + (sbyte)8)];
        // 100D:0BC9 mov DX,word ptr DS:[DI+0x0A]
        DX = UInt16[DS, (ushort)(DI + (sbyte)10)];
        // 100D:0BCC push CX
        Stack.Push16(CX);
        // 100D:0BCD cmp AL,0x14
        Alu8.Sub(AL, (byte)0x14);
        // 100D:0BCF jb short 0x0BF9
        if (CarryFlag)
        {
            goto label_100D_0BF9_10CC9_10536;
        }
    label_100D_0BD1_10CA1_10884:
        CheckExternalEvents(cs1, 0x0BD1);
        // 100D:0BD1 cmp AL,0x1C
        Alu8.Sub(AL, (byte)0x1C);
        // 100D:0BD3 jb short 0x0BDC
        if (CarryFlag)
        {
            goto label_100D_0BDC_10CAC_36262;
        }
    label_100D_0BD5_10CA5_10887:
        CheckExternalEvents(cs1, 0x0BD5);
        // 100D:0BD5 inc AX
        AX = Alu16.Inc(AX);
        // 100D:0BD6 cmp AL,0x2D
        Alu8.Sub(AL, (byte)0x2D);
        // 100D:0BD8 jbe short 0x0C09
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_0C09_10CD9_10543;
        }
    label_100D_0BDA_10CAA_10897:
        CheckExternalEvents(cs1, 0x0BDA);
        // 100D:0BDA jmp short 0x0C2F
        goto label_100D_0C2F_10CFF_10777;
    label_100D_0BDC_10CAC_36262:
        CheckExternalEvents(cs1, 0x0BDC);
        // 100D:0BDC mov BX,word ptr DS:[DI+0x0D]
        BX = UInt16[DS, (ushort)(DI + (sbyte)13)];
        // 100D:0BDF call near 0x0CEA
        NearCall(cs1, 0x0BE2, unknown_100D_0CEA_10DBA);
    label_100D_0BE2_10CB2_36281:
        CheckExternalEvents(cs1, 0x0BE2);
        // 100D:0BE2 call near 0x0CEA
        NearCall(cs1, 0x0BE5, unknown_100D_0CEA_10DBA);
    label_100D_0BE5_10CB5_36289:
        CheckExternalEvents(cs1, 0x0BE5);
        // 100D:0BE5 mov word ptr DS:[DI+0x0D],BX
        UInt16[DS, (ushort)(DI + (sbyte)13)] = BX;
        // 100D:0BE8 mov AX,word ptr DS:[0]
        AX = UInt16[DS, (ushort)0x0000];
        // 100D:0BEB mov CL,3
        CL = (byte)0x03;
        // 100D:0BED rol AX,CL
        AX = Alu16.Rol(AX, CL);
        // 100D:0BEF mov word ptr DS:[0],AX
        UInt16[DS, (ushort)0x0000] = AX;
        // 100D:0BF2 and AX,7
        AX = Alu16.And(AX, (ushort)0x0007);
        // 100D:0BF5 add AL,0x14
        AL = Alu8.Add(AL, (byte)0x14);
        // 100D:0BF7 jmp short 0x0C09
        goto label_100D_0C09_10CD9_10543;
    label_100D_0BF9_10CC9_10536:
        CheckExternalEvents(cs1, 0x0BF9);
        // 100D:0BF9 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0BFB shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0BFD rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:0C01 rcl AX,1
        AX = Alu16.Rcl(AX, unchecked((byte)1));
        // 100D:0C03 rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:0C07 rcl AX,1
        AX = Alu16.Rcl(AX, unchecked((byte)1));
    label_100D_0C09_10CD9_10543:
        CheckExternalEvents(cs1, 0x0C09);
        // 100D:0C09 mov word ptr DS:[DI+8],AX
        UInt16[DS, (ushort)(DI + (sbyte)8)] = AX;
        // 100D:0C0C mov BL,DH
        BL = DH;
        // 100D:0C0E mov AX,BX
        AX = BX;
        // 100D:0C10 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:0C11 mov BX,AX
        BX = AX;
        // 100D:0C13 mov AX,DX
        AX = DX;
        // 100D:0C15 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:0C16 mov DX,AX
        DX = AX;
        // 100D:0C18 push DI
        Stack.Push16(DI);
        // 100D:0C19 call near 0xC661
        NearCall(cs1, 0x0C1C, unknown_100D_C661_1C731);
    label_100D_0C1C_10CEC_10712:
        CheckExternalEvents(cs1, 0x0C1C);
        // 100D:0C1C pop DI
        DI = Stack.Pop16();
        // 100D:0C1D cmp word ptr DS:[DI],0x0140
        Alu16.Sub(UInt16[DS, DI], (ushort)0x0140);
        // 100D:0C21 jae short 0x0C2F
        if (!CarryFlag)
        {
            goto label_100D_0C2F_10CFF_10777;
        }
    label_100D_0C23_10CF3_10716:
        CheckExternalEvents(cs1, 0x0C23);
        // 100D:0C23 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0C25 cmp word ptr DS:[DI+4],AX
        Alu16.Sub(UInt16[DS, (ushort)(DI + (sbyte)4)], AX);
        // 100D:0C28 js short 0x0C2F
        if (SignFlag)
        {
            goto label_100D_0C2F_10CFF_10777;
        }
    label_100D_0C2A_10CFA_10720:
        CheckExternalEvents(cs1, 0x0C2A);
        // 100D:0C2A cmp word ptr DS:[DI+6],AX
        Alu16.Sub(UInt16[DS, (ushort)(DI + (sbyte)6)], AX);
        // 100D:0C2D jns short 0x0C34
        if (!SignFlag)
        {
            goto label_100D_0C34_10D04_10723;
        }
    label_100D_0C2F_10CFF_10777:
        CheckExternalEvents(cs1, 0x0C2F);
        // 100D:0C2F push DI
        Stack.Push16(DI);
        // 100D:0C30 call near 0xC58A
        NearCall(cs1, 0x0C33, unknown_100D_C58A_1C65A);
    label_100D_0C33_10D03_10823:
        CheckExternalEvents(cs1, 0x0C33);
        // 100D:0C33 pop DI
        DI = Stack.Pop16();
    label_100D_0C34_10D04_10723:
        CheckExternalEvents(cs1, 0x0C34);
        // 100D:0C34 pop CX
        CX = Stack.Pop16();
        // 100D:0C35 add DI,0x0011
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:0C38 loop 0x0BC6
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_0BC6_10C96_10530;
        }
    label_100D_0C3A_10D0A_10727:
        CheckExternalEvents(cs1, 0x0C3A);
        // 100D:0C3A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0C3B_10D0B(int loadOffset)
    {
    label_100D_0C3B_10D0B_10432:
        CheckExternalEvents(cs1, 0x0C3B);
        // 100D:0C3B dec byte ptr DS:[SI+1]
        UInt8[DS, (ushort)(SI + (sbyte)1)] = Alu8.Dec(UInt8[DS, (ushort)(SI + (sbyte)1)]);
        // 100D:0C3E jns short 0x0C79
        if (!SignFlag)
        {
            goto label_100D_0C79_10D49_10457;
        }
    label_100D_0C40_10D10_10435:
        CheckExternalEvents(cs1, 0x0C40);
        // 100D:0C40 test word ptr DS:[0],3
        Alu16.And(UInt16[DS, (ushort)0x0000], (ushort)0x0003);
        // 100D:0C46 jne short 0x0C58
        if (!ZeroFlag)
        {
            goto label_100D_0C58_10D28_10442;
        }
    label_100D_0C48_10D18_10438:
        CheckExternalEvents(cs1, 0x0C48);
        // 100D:0C48 mov byte ptr DS:[SI+7],0x0B
        UInt8[DS, (ushort)(SI + (sbyte)7)] = (byte)0x0B;
        // 100D:0C4C test word ptr DS:[0],0x000C
        Alu16.And(UInt16[DS, (ushort)0x0000], (ushort)0x000C);
        // 100D:0C52 jne short 0x0C58
        if (!ZeroFlag)
        {
            goto label_100D_0C58_10D28_10442;
        }
    label_100D_0C54_10D24_36314:
        CheckExternalEvents(cs1, 0x0C54);
        // 100D:0C54 mov byte ptr DS:[SI+7],0x11
        UInt8[DS, (ushort)(SI + (sbyte)7)] = (byte)0x11;
    label_100D_0C58_10D28_10442:
        CheckExternalEvents(cs1, 0x0C58);
        // 100D:0C58 call near 0xE3CC
        NearCall(cs1, 0x0C5B, unknown_100D_E3CC_1E49C);
    label_100D_0C5B_10D2B_10444:
        CheckExternalEvents(cs1, 0x0C5B);
        // 100D:0C5B cmp byte ptr DS:[0x473A],0
        Alu8.Sub(UInt8[DS, (ushort)0x473A], (byte)0x00);
        // 100D:0C60 je short 0x0C64
        if (ZeroFlag)
        {
            goto label_100D_0C64_10D34_10447;
        }
    label_100D_0C62_10D32_39668:
        CheckExternalEvents(cs1, 0x0C62);
        // 100D:0C62 and AL,0xEF
        AL = Alu8.And(AL, (byte)0xEF);
    label_100D_0C64_10D34_10447:
        CheckExternalEvents(cs1, 0x0C64);
        // 100D:0C64 mov CX,AX
        CX = AX;
        // 100D:0C66 mov BX,7
        BX = (ushort)0x0007;
        // 100D:0C69 call near 0xE3B7
        NearCall(cs1, 0x0C6C, unknown_100D_E3B7_1E487);
    label_100D_0C6C_10D3C_10451:
        CheckExternalEvents(cs1, 0x0C6C);
        // 100D:0C6C mov byte ptr DS:[SI+1],AL
        UInt8[DS, (ushort)(SI + (sbyte)1)] = AL;
        // 100D:0C6F cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:0C71 jb short 0x0C76
        if (CarryFlag)
        {
            goto label_100D_0C76_10D46_10455;
        }
    label_100D_0C73_10D43_10772:
        CheckExternalEvents(cs1, 0x0C73);
        // 100D:0C73 or CH,0x40
        CH = Alu8.Or(CH, (byte)0x40);
    label_100D_0C76_10D46_10455:
        CheckExternalEvents(cs1, 0x0C76);
        // 100D:0C76 mov word ptr DS:[SI+2],CX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = CX;
    label_100D_0C79_10D49_10457:
        CheckExternalEvents(cs1, 0x0C79);
        // 100D:0C79 mov byte ptr DS:[SI],8
        UInt8[DS, SI] = (byte)0x08;
        // 100D:0C7C mov AL,byte ptr DS:[SI+2]
        AL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:0C7F mov DI,AX
        DI = AX;
        // 100D:0C81 mov BL,byte ptr DS:[SI+3]
        BL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:0C84 and AX,0x0010
        AX = Alu16.And(AX, (ushort)0x0010);
        // 100D:0C87 jne short 0x0C98
        if (!ZeroFlag)
        {
            goto label_100D_0C98_10D68_36246;
        }
    label_100D_0C89_10D59_10463:
        CheckExternalEvents(cs1, 0x0C89);
        // 100D:0C89 and BX,6
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:0C8C mov SI,word ptr DS:[BX+0x15A2]
        SI = UInt16[DS, (ushort)(BX + (short)5538)];
        // 100D:0C90 add BX,BX
        BX = Alu16.Add(BX, BX);
        // 100D:0C92 add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:0C94 add AL,4
        AL = Alu8.Add(AL, (byte)0x04);
        // 100D:0C96 jmp short 0x0CD6
        goto label_100D_0CD6_10DA6_10470;
    label_100D_0C98_10D68_36246:
        CheckExternalEvents(cs1, 0x0C98);
        // 100D:0C98 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:0C9B mov AH,AL
        AH = AL;
        // 100D:0C9D and AX,0xC03F
        AX = Alu16.And(AX, (ushort)0xC03F);
        // 100D:0CA0 test AH,0x40
        Alu8.And(AH, (byte)0x40);
        // 100D:0CA3 je short 0x0CCA
        if (ZeroFlag)
        {
            goto label_100D_0CCA_10D9A_36255;
        }
    label_100D_0CA5_10D75_36252:
        CheckExternalEvents(cs1, 0x0CA5);
        // 100D:0CA5 rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:0CA9 jae short 0x0CCA
        if (!CarryFlag)
        {
            goto label_100D_0CCA_10D9A_36255;
        }
    label_100D_0CAB_10D7B_36298:
        CheckExternalEvents(cs1, 0x0CAB);
        // 100D:0CAB mov CL,0x0A
        CL = (byte)0x0A;
        // 100D:0CAD or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:0CAF jns short 0x0CB3
        if (!SignFlag)
        {
            goto label_100D_0CB3_10D83_36302;
        }
    label_100D_0CB1_10D81_36316:
        CheckExternalEvents(cs1, 0x0CB1);
        // 100D:0CB1 neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
    label_100D_0CB3_10D83_36302:
        CheckExternalEvents(cs1, 0x0CB3);
        // 100D:0CB3 add AL,CL
        AL = Alu8.Add(AL, CL);
        // 100D:0CB5 jns short 0x0CBC
        if (!SignFlag)
        {
            goto label_100D_0CBC_10D8C_36305;
        }
    label_100D_0CB7_10D87_36321:
        CheckExternalEvents(cs1, 0x0CB7);
        // 100D:0CB7 xor AH,0x80
        AH = Alu8.Xor(AH, (byte)0x80);
        // 100D:0CBA xor AL,AL
        AL = Alu8.Xor(AL, AL);
    label_100D_0CBC_10D8C_36305:
        CheckExternalEvents(cs1, 0x0CBC);
        // 100D:0CBC cmp AL,0x40
        Alu8.Sub(AL, (byte)0x40);
        // 100D:0CBE jb short 0x0CC5
        if (CarryFlag)
        {
            goto label_100D_0CC5_10D95_36308;
        }
    label_100D_0CC0_10D90_36311:
        CheckExternalEvents(cs1, 0x0CC0);
        // 100D:0CC0 mov AL,0x3F
        AL = (byte)0x3F;
        // 100D:0CC2 xor AH,0x80
        AH = Alu8.Xor(AH, (byte)0x80);
    label_100D_0CC5_10D95_36308:
        CheckExternalEvents(cs1, 0x0CC5);
        // 100D:0CC5 or AH,AL
        AH = Alu8.Or(AH, AL);
        // 100D:0CC7 mov byte ptr DS:[SI+3],AH
        UInt8[DS, (ushort)(SI + (sbyte)3)] = AH;
    label_100D_0CCA_10D9A_36255:
        CheckExternalEvents(cs1, 0x0CCA);
        // 100D:0CCA add AL,0xE0
        AL = Alu8.Add(AL, (byte)0xE0);
        // 100D:0CCC call near 0x5198
        NearCall(cs1, 0x0CCF, unknown_100D_5198_15268);
    label_100D_0CCF_10D9F_36258:
        CheckExternalEvents(cs1, 0x0CCF);
        // 100D:0CCF mov DH,BL
        DH = BL;
        // 100D:0CD1 mov SI,DX
        SI = DX;
        // 100D:0CD3 mov AX,0x0014
        AX = (ushort)0x0014;
    label_100D_0CD6_10DA6_10470:
        CheckExternalEvents(cs1, 0x0CD6);
        // 100D:0CD6 and DI,0x000C
        DI = Alu16.And(DI, unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:0CD9 mov BX,word ptr DS:[DI+0x1594]
        BX = UInt16[DS, (ushort)(DI + (short)5524)];
        // 100D:0CDD mov DX,word ptr DS:[DI+0x1592]
        DX = UInt16[DS, (ushort)(DI + (short)5522)];
        // 100D:0CE1 call near 0xC60B
        NearCall(cs1, 0x0CE4, unknown_100D_C60B_1C6DB);
    label_100D_0CE4_10DB4_10523:
        CheckExternalEvents(cs1, 0x0CE4);
        // 100D:0CE4 mov word ptr DS:[DI+0x0D],0
        UInt16[DS, (ushort)(DI + (sbyte)13)] = (ushort)0x0000;
        // 100D:0CE9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0CEA_10DBA(int loadOffset)
    {
    label_100D_0CEA_10DBA_36265:
        CheckExternalEvents(cs1, 0x0CEA);
        // 100D:0CEA xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0CEC mov AL,DL
        AL = DL;
        // 100D:0CEE or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:0CF0 js short 0x0D05
        if (!(SignFlag))
        {
            return unknown_100D_0CF2_10DC2(0x0000);
        }
    label_100D_0D05_10DD5_36283:
        CheckExternalEvents(cs1, 0x0D05);
        // 100D:0D05 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
        // 100D:0D07 call near 0x0CF2
        NearCall(cs1, 0x0D0A, unknown_100D_0CF2_10DC2);
    label_100D_0D0A_10DDA_36286:
        CheckExternalEvents(cs1, 0x0D0A);
        // 100D:0D0A neg DH
        DH = Alu8.Sub((byte)0x00, DH);
        CarryFlag = DH != (byte)0x00;
        // 100D:0D0C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0CF2_10DC2(int loadOffset)
    {
    label_100D_0CF2_10DC2_36270:
        CheckExternalEvents(cs1, 0x0CF2);
        // 100D:0CF2 add AL,BL
        AL = Alu8.Add(AL, BL);
        // 100D:0CF4 mov CL,5
        CL = (byte)0x05;
        // 100D:0CF6 ror AX,CL
        AX = Alu16.Ror(AX, unchecked((int)CL));
        // 100D:0CF8 mov CL,3
        CL = (byte)0x03;
        // 100D:0CFA shr AH,CL
        AH = Alu8.Shr(AH, unchecked((int)CL));
        // 100D:0CFC mov BL,AH
        BL = AH;
        // 100D:0CFE mov DL,AL
        DL = AL;
        // 100D:0D00 xchg BL,BH
        byte temp_100D_0D00_10DD0 = BL;
        BL = BH;
        BH = unchecked((byte)temp_100D_0D00_10DD0);
        // 100D:0D02 xchg DL,DH
        byte temp_100D_0D02_10DD2 = DL;
        DL = DH;
        DH = unchecked((byte)temp_100D_0D02_10DD2);
        // 100D:0D04 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0D0D_10DDD(int loadOffset)
    {
    label_100D_0D0D_10DDD_10732:
        CheckExternalEvents(cs1, 0x0D0D);
        // 100D:0D0D mov AL,BL
        AL = BL;
        // 100D:0D0F mov BX,0x0180
        BX = (ushort)0x0180;
        // 100D:0D12 mov CX,0x0054
        CX = (ushort)0x0054;
        // 100D:0D15 mov DL,0x37
        DL = (byte)0x37;
        // 100D:0D17 je short 0x0D23
        if (ZeroFlag)
        {
            goto label_100D_0D23_10DF3_10742;
        }
    label_100D_0D19_10DE9_10738:
        CheckExternalEvents(cs1, 0x0D19);
        // 100D:0D19 dec DX
        DX = Alu16.Dec(DX);
        // 100D:0D1A cmp AL,0x0A
        Alu8.Sub(AL, (byte)0x0A);
        // 100D:0D1C je short 0x0D23
        if (ZeroFlag)
        {
            goto label_100D_0D23_10DF3_10742;
        }
    label_100D_0D1E_10DEE_10763:
        CheckExternalEvents(cs1, 0x0D1E);
        // 100D:0D1E call far dword ptr DS:[0x3951]
        ushort targetSegment_10763 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3951 + (ushort)0x0002)]));
        ushort targetOffset_10763 = unchecked((ushort)(UInt16[DS, (ushort)0x3951]));
        if (targetSegment_10763 == cs2 && targetOffset_10763 == 0x0175)
        {
            FarCall(cs1, 0x0D22, cs2, unknown_3358_0175_336F5);
            goto label_100D_0D22_10DF2_10765;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10763:X4}:{targetOffset_10763:X4} at 100D:0D1E");
    label_100D_0D22_10DF2_10765:
        CheckExternalEvents(cs1, 0x0D22);
        // 100D:0D22 ret near
        return NearRet((ushort)0x0000);
    label_100D_0D23_10DF3_10742:
        CheckExternalEvents(cs1, 0x0D23);
        // 100D:0D23 call near 0xC13B
        NearCall(cs1, 0x0D26, unknown_100D_C13B_1C20B);
    label_100D_0D26_10DF6_10744:
        CheckExternalEvents(cs1, 0x0D26);
        // 100D:0D26 mov AL,DL
        AL = DL;
        // 100D:0D28 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:0D2A call near 0xC1F4
        NearCall(cs1, 0x0D2D, unknown_100D_C1F4_1C2C4);
    label_100D_0D2D_10DFD_10748:
        CheckExternalEvents(cs1, 0x0D2D);
        // 100D:0D2D lea DX,SI+6
        DX = unchecked((ushort)(SI + (sbyte)6));
        // 100D:0D30 call far dword ptr DS:[0x38BD]
        ushort targetSegment_10750 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_10750 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_10750 == cs2 && targetOffset_10750 == 0x0106)
        {
            FarCall(cs1, 0x0D34, cs2, unknown_3358_0106_33686);
            goto label_100D_0D34_10E04_10751;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10750:X4}:{targetOffset_10750:X4} at 100D:0D30");
    label_100D_0D34_10E04_10751:
        CheckExternalEvents(cs1, 0x0D34);
        // 100D:0D34 call near 0xC0F4
        NearCall(cs1, 0x0D37, unknown_100D_C0F4_1C1C4);
    label_100D_0D37_10E07_10753:
        CheckExternalEvents(cs1, 0x0D37);
        // 100D:0D37 mov AX,0x0035
        AX = (ushort)0x0035;
        // 100D:0D3A call near 0xC1F4
        NearCall(cs1, 0x0D3D, unknown_100D_C1F4_1C2C4);
    label_100D_0D3D_10E0D_10756:
        CheckExternalEvents(cs1, 0x0D3D);
        // 100D:0D3D lea DX,SI+6
        DX = unchecked((ushort)(SI + (sbyte)6));
        // 100D:0D40 call far dword ptr DS:[0x394D]
        ushort targetSegment_10758 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x394D + (ushort)0x0002)]));
        ushort targetOffset_10758 = unchecked((ushort)(UInt16[DS, (ushort)0x394D]));
        if (targetSegment_10758 == cs2 && targetOffset_10758 == 0x0172)
        {
            FarCall(cs1, 0x0D44, cs2, unknown_3358_0172_336F2);
            goto label_100D_0D44_10E14_10759;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10758:X4}:{targetOffset_10758:X4} at 100D:0D40");
    label_100D_0D44_10E14_10759:
        CheckExternalEvents(cs1, 0x0D44);
        // 100D:0D44 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0D45_10E15(int loadOffset)
    {
    label_100D_0D45_10E15_37575:
        CheckExternalEvents(cs1, 0x0D45);
        // 100D:0D45 call near 0x395C
        NearCall(cs1, 0x0D48, unknown_100D_395C_13A2C);
    label_100D_0D48_10E18_37580:
        CheckExternalEvents(cs1, 0x0D48);
        // 100D:0D48 call near 0x3971
        NearCall(cs1, 0x0D4B, unknown_100D_3971_13A41);
    label_100D_0D4B_10E1B_37583:
        CheckExternalEvents(cs1, 0x0D4B);
        // 100D:0D4B call near 0x39B9
        NearCall(cs1, 0x0D4E, unknown_100D_39B9_13A89);
    label_100D_0D4E_10E1E_37586:
        CheckExternalEvents(cs1, 0x0D4E);
        // 100D:0D4E inc byte ptr DS:[0x227D]
        UInt8[DS, (ushort)0x227D] = Alu8.Inc(UInt8[DS, (ushort)0x227D]);
        // 100D:0D52 mov CX,3
        CX = (ushort)0x0003;
    label_100D_0D55_10E25_37589:
        CheckExternalEvents(cs1, 0x0D55);
        // 100D:0D55 push CX
        Stack.Push16(CX);
        // 100D:0D56 mov BL,0x28
        BL = (byte)0x28;
        // 100D:0D58 call near 0x3971
        NearCall(cs1, 0x0D5B, unknown_100D_3971_13A41);
    label_100D_0D5B_10E2B_37597:
        CheckExternalEvents(cs1, 0x0D5B);
        // 100D:0D5B call near 0x398C
        NearCall(cs1, 0x0D5E, unknown_100D_398C_13A5C);
    label_100D_0D5E_10E2E_37600:
        CheckExternalEvents(cs1, 0x0D5E);
        // 100D:0D5E call near 0xC0F4
        NearCall(cs1, 0x0D61, unknown_100D_C0F4_1C1C4);
    label_100D_0D61_10E31_37603:
        CheckExternalEvents(cs1, 0x0D61);
        // 100D:0D61 mov byte ptr DS:[0x46D7],0x20
        UInt8[DS, (ushort)0x46D7] = (byte)0x20;
    label_100D_0D66_10E36_37604:
        CheckExternalEvents(cs1, 0x0D66);
        // 100D:0D66 mov BP,0x391D
        BP = (ushort)0x391D;
        // 100D:0D69 mov AX,3
        AX = (ushort)0x0003;
        // 100D:0D6C call near 0xE353
        NearCall(cs1, 0x0D6F, unknown_100D_E353_1E423);
    label_100D_0D6F_10E3F_37651:
        CheckExternalEvents(cs1, 0x0D6F);
        // 100D:0D6F cmp byte ptr DS:[0x46D7],0x10
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x10);
        // 100D:0D74 jae short 0x0D66
        if (!CarryFlag)
        {
            goto label_100D_0D66_10E36_37604;
        }
    label_100D_0D76_10E46_37656:
        CheckExternalEvents(cs1, 0x0D76);
        // 100D:0D76 pop CX
        CX = Stack.Pop16();
        // 100D:0D77 loop 0x0D55
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_0D55_10E25_37589;
        }
    label_100D_0D79_10E49_37661:
        CheckExternalEvents(cs1, 0x0D79);
        // 100D:0D79 mov BP,0x391D
        BP = (ushort)0x391D;
        // 100D:0D7C mov AX,3
        AX = (ushort)0x0003;
        // 100D:0D7F call near 0xE353
        NearCall(cs1, 0x0D82, unknown_100D_E353_1E423);
    label_100D_0D82_10E52_37672:
        CheckExternalEvents(cs1, 0x0D82);
        // 100D:0D82 cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:0D87 jne short 0x0D79
        if (!ZeroFlag)
        {
            goto label_100D_0D79_10E49_37661;
        }
    label_100D_0D89_10E59_37676:
        CheckExternalEvents(cs1, 0x0D89);
        // 100D:0D89 dec byte ptr DS:[0x227D]
        UInt8[DS, (ushort)0x227D] = Alu8.Dec(UInt8[DS, (ushort)0x227D]);
        // 100D:0D8D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_0D8E_10E5E(int loadOffset)
    {
    entrydispatcher:
    label_100D_0D8E_10E5E_37542:
        CheckExternalEvents(cs1, 0x0D8E);
        // 100D:0D8E cmp byte ptr DS:[0x47A9],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A9], (byte)0x00);
        // 100D:0D93 jne short 0x0D9D
        if (!ZeroFlag)
        {
            goto label_100D_0D9D_10E6D_37546;
        }
    label_100D_0D95_10E65_37548:
        CheckExternalEvents(cs1, 0x0D95);
        // 100D:0D95 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0D97 cmp byte ptr DS:[0x46D9],AL
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], AL);
        // 100D:0D9B jns short 0x0D9E
        if (!SignFlag)
        {
            goto label_100D_0D9E_10E6E_37552;
        }
    label_100D_0D9D_10E6D_37546:
        CheckExternalEvents(cs1, 0x0D9D);
        // 100D:0D9D ret near
        return NearRet((ushort)0x0000);
    label_100D_0D9E_10E6E_37552:
        CheckExternalEvents(cs1, 0x0D9E);
        // 100D:0D9E mov byte ptr DS:[0x473B],AL
        UInt8[DS, (ushort)0x473B] = AL;
        // 100D:0DA1 mov byte ptr DS:[0x46EC],AL
        UInt8[DS, (ushort)0x46EC] = AL;
        // 100D:0DA4 cmp byte ptr DS:[0x00FB],AL
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], AL);
        // 100D:0DA8 jns short 0x0DB0
        if (!SignFlag)
        {
            goto label_100D_0DB0_10E80_37558;
        }
    label_100D_0DAA_10E7A_37560:
        CheckExternalEvents(cs1, 0x0DAA);
        VerifySpeculativeEntryOrFail(cs1, 0x0DAA, [(byte)0xE8, (byte)0x05, (byte)0xCE]);
        // 100D:0DAA call near 0xDBB2
        NearCall(cs1, 0x0DAD, unknown_100D_DBB2_1DC82);
        throw FailAsUntested("Call at 100D:0DAA returned to 100D:0DAD, but no continuation was observed during discovery.");
    label_100D_0DB0_10E80_37558:
        CheckExternalEvents(cs1, 0x0DB0);
        // 100D:0DB0 call near 0xD2BD
        NearCall(cs1, 0x0DB3, unknown_100D_D2BD_1D38D);
    label_100D_0DB3_10E83_37574:
        CheckExternalEvents(cs1, 0x0DB3);
        // 100D:0DB3 call near 0x0D45
        NearCall(cs1, 0x0DB6, unknown_100D_0D45_10E15);
    label_100D_0DB6_10E86_37682:
        CheckExternalEvents(cs1, 0x0DB6);
        // 100D:0DB6 call near 0xDBB2
        NearCall(cs1, 0x0DB9, unknown_100D_DBB2_1DC82);
    label_100D_0DB9_10E89_37685:
        CheckExternalEvents(cs1, 0x0DB9);
        // 100D:0DB9 call near 0x98E6
        NearCall(cs1, 0x0DBC, unknown_100D_98E6_199B6);
    label_100D_0DBC_10E8C_37688:
        CheckExternalEvents(cs1, 0x0DBC);
        // 100D:0DBC mov word ptr DS:[2],0x16C5
        UInt16[DS, (ushort)0x0002] = (ushort)0x16C5;
        // 100D:0DC2 call near 0x0E66
        NearCall(cs1, 0x0DC5, unknown_100D_0E66_10F36);
    label_100D_0DC5_10E95_37754:
        CheckExternalEvents(cs1, 0x0DC5);
        // 100D:0DC5 mov byte ptr DS:[0x11CA],1
        UInt8[DS, (ushort)0x11CA] = (byte)0x01;
        // 100D:0DCA call near 0x9F40
        NearCall(cs1, 0x0DCD, unknown_100D_9F40_1A010);
    label_100D_0DCD_10E9D_37759:
        CheckExternalEvents(cs1, 0x0DCD);
        // 100D:0DCD mov word ptr DS:[0x47C4],0xFFFF
        UInt16[DS, (ushort)0x47C4] = (ushort)0xFFFF;
        // 100D:0DD3 mov AL,0x80
        AL = (byte)0x80;
        // 100D:0DD5 xchg AL,byte ptr DS:[0x46D9]
        ushort xchgOffset_100D_0DD5_10EA5 = (ushort)0x46D9;
        byte temp_100D_0DD5_10EA5 = AL;
        AL = UInt8[DS, xchgOffset_100D_0DD5_10EA5];
        UInt8[DS, xchgOffset_100D_0DD5_10EA5] = unchecked((byte)temp_100D_0DD5_10EA5);
        // 100D:0DD9 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:0DDB push AX
        Stack.Push16(AX);
        // 100D:0DDC add AX,0x00BA
        AX = Alu16.Add(AX, (ushort)0x00BA);
        // 100D:0DDF call near 0x9901
        NearCall(cs1, 0x0DE2, unknown_100D_9901_199D1);
    label_100D_0DE2_10EB2_37774:
        CheckExternalEvents(cs1, 0x0DE2);
        // 100D:0DE2 call near 0x88AF
        NearCall(cs1, 0x0DE5, unknown_100D_88AF_1897F);
    label_100D_0DE5_10EB5_37796:
        CheckExternalEvents(cs1, 0x0DE5);
        // 100D:0DE5 call near 0x9901
        NearCall(cs1, 0x0DE8, unknown_100D_9901_199D1);
    label_100D_0DE8_10EB8_37799:
        CheckExternalEvents(cs1, 0x0DE8);
        // 100D:0DE8 mov SI,0x2254
        SI = (ushort)0x2254;
        // 100D:0DEB call near 0x7B1B
        NearCall(cs1, 0x0DEE, unknown_100D_7B1B_17BEB);
    label_100D_0DEE_10EBE_37804:
        CheckExternalEvents(cs1, 0x0DEE);
        // 100D:0DEE call near 0xDA53
        NearCall(cs1, 0x0DF1, unknown_100D_DA53_1DB23);
    label_100D_0DF1_10EC1_37807:
        CheckExternalEvents(cs1, 0x0DF1);
        // 100D:0DF1 pop AX
        AX = Stack.Pop16();
        // 100D:0DF2 mov BX,0x225D
        BX = (ushort)0x225D;
        // 100D:0DF5 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:0DF6 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:0DF8 js short 0x0E22
        if (SignFlag)
        {
            goto label_100D_0E22_10EF2_37813;
        }
    label_100D_0DFA_10ECA_37815:
        CheckExternalEvents(cs1, 0x0DFA);
        // 100D:0DFA call near 0x91A0
        NearCall(cs1, 0x0DFD, unknown_100D_91A0_19270);
    label_100D_0DFD_10ECD_37824:
        CheckExternalEvents(cs1, 0x0DFD);
        // 100D:0DFD les SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_0DFD_10ECD = (ushort)0xDBB0;
        ushort lxsValue_100D_0DFD_10ECD = UInt16[DS, lxsOffset_100D_0DFD_10ECD];
        ushort lxsSegment_100D_0DFD_10ECD = UInt16[DS, (ushort)(lxsOffset_100D_0DFD_10ECD + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_0DFD_10ECD);
        ES = unchecked((ushort)lxsSegment_100D_0DFD_10ECD);
        // 100D:0E01 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:0E03 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:0E05 sub AX,3
        AX = Alu16.Sub(AX, (ushort)0x0003);
        // 100D:0E08 mov DX,word ptr DS:[0x2254]
        DX = UInt16[DS, (ushort)0x2254];
        // 100D:0E0C mov BX,word ptr DS:[0x2256]
        BX = UInt16[DS, (ushort)0x2256];
        // 100D:0E10 inc DX
        DX = Alu16.Inc(DX);
        // 100D:0E11 inc BX
        BX = Alu16.Inc(BX);
        // 100D:0E12 push AX
        Stack.Push16(AX);
        // 100D:0E13 call near 0xC2FD
        NearCall(cs1, 0x0E16, unknown_100D_C2FD_1C3CD);
    label_100D_0E16_10EE6_37845:
        CheckExternalEvents(cs1, 0x0E16);
        // 100D:0E16 pop AX
        AX = Stack.Pop16();
        // 100D:0E17 inc AX
        AX = Alu16.Inc(AX);
        // 100D:0E18 call near 0xC22F
        NearCall(cs1, 0x0E1B, unknown_100D_C22F_1C2FF);
    label_100D_0E1B_10EEB_37852:
        CheckExternalEvents(cs1, 0x0E1B);
        // 100D:0E1B call far dword ptr DS:[0x3935]
        ushort targetSegment_37852 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_37852 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_37852 == cs2 && targetOffset_37852 == 0x0160)
        {
            FarCall(cs1, 0x0E1F, cs2, unknown_3358_0160_336E0);
            goto label_100D_0E1F_10EEF_37854;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_37852:X4}:{targetOffset_37852:X4} at 100D:0E1B");
    label_100D_0E1F_10EEF_37854:
        CheckExternalEvents(cs1, 0x0E1F);
        // 100D:0E1F call near 0x9EFD
        NearCall(cs1, 0x0E22, unknown_100D_9EFD_19FCD);
    label_100D_0E22_10EF2_37813:
        CheckExternalEvents(cs1, 0x0E22);
        // 100D:0E22 call near 0xC4CD
        NearCall(cs1, 0x0E25, unknown_100D_C4CD_1C59D);
    label_100D_0E25_10EF5_37876:
        CheckExternalEvents(cs1, 0x0E25);
        // 100D:0E25 mov byte ptr DS:[0x4727],0
        UInt8[DS, (ushort)0x4727] = (byte)0x00;
        // 100D:0E2A call near 0xD741
        NearCall(cs1, 0x0E2D, unknown_100D_D741_1D811);
    label_100D_0E2D_10EFD_37881:
        CheckExternalEvents(cs1, 0x0E2D);
        // 100D:0E2D mov byte ptr DS:[0x47A7],1
        UInt8[DS, (ushort)0x47A7] = (byte)0x01;
        // 100D:0E32 mov BP,0x20A2
        BP = (ushort)0x20A2;
        // 100D:0E35 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:0E38 call near 0xD323
        NearCall(cs1, 0x0E3B, unknown_100D_D323_1D3F3);
    label_100D_0E3B_10F0B_37890:
        CheckExternalEvents(cs1, 0x0E3B);
        // 100D:0E3B jmp near 0xDBEC
        if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0E66_10F36(int loadOffset)
    {
    entrydispatcher:
    label_100D_0E66_10F36_37691:
        CheckExternalEvents(cs1, 0x0E66);
        // 100D:0E66 call near 0xAD5E
        NearCall(cs1, 0x0E69, unknown_100D_AD5E_1AE2E);
    label_100D_0E69_10F39_37696:
        CheckExternalEvents(cs1, 0x0E69);
        // 100D:0E69 mov AX,0x000C
        AX = (ushort)0x000C;
        if (JumpDispatcher.Jump(unknown_100D_0E6C_10F3C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0E6C_10F3C(int loadOffset)
    {
    entrydispatcher:
    label_100D_0E6C_10F3C_37697:
        CheckExternalEvents(cs1, 0x0E6C);
        // 100D:0E6C push AX
        Stack.Push16(AX);
        // 100D:0E6D call near 0xA7A5
        NearCall(cs1, 0x0E70, unknown_100D_A7A5_1A875);
    label_100D_0E70_10F40_37703:
        CheckExternalEvents(cs1, 0x0E70);
        // 100D:0E70 pop AX
        AX = Stack.Pop16();
        // 100D:0E71 mov BP,0x181E
        BP = (ushort)0x181E;
        // 100D:0E74 jmp near 0xC8FB
        if (JumpDispatcher.Jump(unknown_100D_C8FB_1C9CB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
