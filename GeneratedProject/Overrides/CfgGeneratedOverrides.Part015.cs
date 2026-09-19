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
    public virtual Action unknown_100D_998E_19A5E(int loadOffset)
    {
    label_100D_998E_19A5E_39809:
        CheckExternalEvents(cs1, 0x998E);
        // 100D:998E mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:9991 mov SI,0x1BF0
        SI = (ushort)0x1BF0;
        // 100D:9994 mov CX,4
        CX = (ushort)0x0004;
        // 100D:9997 call near 0x99B2
        NearCall(cs1, 0x999A, unknown_100D_99B2_19A82);
    label_100D_999A_19A6A_39834:
        CheckExternalEvents(cs1, 0x999A);
        // 100D:999A mov SI,0x22A6
        SI = (ushort)0x22A6;
        // 100D:999D mov CX,1
        CX = (ushort)0x0001;
        // 100D:99A0 call near 0x99B2
        NearCall(cs1, 0x99A3, unknown_100D_99B2_19A82);
    label_100D_99A3_19A73_39841:
        CheckExternalEvents(cs1, 0x99A3);
        // 100D:99A3 mov SI,0x4540
        SI = (ushort)0x4540;
        // 100D:99A6 mov CX,0x00C9
        CX = (ushort)0x00C9;
        // 100D:99A9 call near 0x99B2
        NearCall(cs1, 0x99AC, unknown_100D_99B2_19A82);
    label_100D_99AC_19A7C_39848:
        CheckExternalEvents(cs1, 0x99AC);
        // 100D:99AC mov SI,0x47C4
        SI = (ushort)0x47C4;
        // 100D:99AF mov CX,7
        CX = (ushort)0x0007;
        return unknown_100D_99B2_19A82(0x0000);
    }

    public virtual Action unknown_100D_99B2_19A82(int loadOffset)
    {
    label_100D_99B2_19A82_39815:
        CheckExternalEvents(cs1, 0x99B2);
        // 100D:99B2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:99B3 xchg AX,word ptr DS:[DI]
        ushort xchgOffset_100D_99B3_19A83 = DI;
        ushort temp_100D_99B3_19A83 = AX;
        AX = UInt16[DS, xchgOffset_100D_99B3_19A83];
        UInt16[DS, xchgOffset_100D_99B3_19A83] = unchecked((ushort)temp_100D_99B3_19A83);
        // 100D:99B5 mov word ptr DS:[SI-2],AX
        UInt16[DS, (ushort)(SI + (sbyte)-2)] = AX;
        // 100D:99B8 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:99BB loop 0x99B2
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_99B2_19A82_39815;
        }
    label_100D_99BD_19A8D_39822:
        CheckExternalEvents(cs1, 0x99BD);
        // 100D:99BD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_99BE_19A8E(int loadOffset)
    {
    entrydispatcher:
    label_100D_99BE_19A8E_8289:
        CheckExternalEvents(cs1, 0x99BE);
        // 100D:99BE cmp byte ptr DS:[0x47C3],0
        Alu8.Sub(UInt8[DS, (ushort)0x47C3], (byte)0x00);
        // 100D:99C3 je short 0x99DA
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_99DA_19AAA, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_99C5_19A95_39871:
        CheckExternalEvents(cs1, 0x99C5);
        // 100D:99C5 call near 0x998E
        NearCall(cs1, 0x99C8, unknown_100D_998E_19A5E);
    label_100D_99C8_19A98_39874:
        CheckExternalEvents(cs1, 0x99C8);
        // 100D:99C8 mov AX,7
        AX = (ushort)0x0007;
        // 100D:99CB call near 0x920F
        NearCall(cs1, 0x99CE, unknown_100D_920F_192DF);
    label_100D_99CE_19A9E_39879:
        CheckExternalEvents(cs1, 0x99CE);
        // 100D:99CE call near 0x99DA
        NearCall(cs1, 0x99D1, unknown_100D_99DA_19AAA);
    label_100D_99D1_19AA1_39882:
        CheckExternalEvents(cs1, 0x99D1);
        // 100D:99D1 call near 0x998E
        NearCall(cs1, 0x99D4, unknown_100D_998E_19A5E);
    label_100D_99D4_19AA4_39885:
        CheckExternalEvents(cs1, 0x99D4);
        // 100D:99D4 mov AX,0x002D
        AX = (ushort)0x002D;
        // 100D:99D7 call near 0x920F
        NearCall(cs1, 0x99DA, unknown_100D_920F_192DF);
        if (JumpDispatcher.Jump(unknown_100D_99DA_19AAA, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_99DA_19AAA(int loadOffset)
    {
    entrydispatcher:
    label_100D_99DA_19AAA_8292:
        CheckExternalEvents(cs1, 0x99DA);
        // 100D:99DA call near 0x9197
        NearCall(cs1, 0x99DD, unknown_100D_9197_19267);
    label_100D_99DD_19AAD_8294:
        CheckExternalEvents(cs1, 0x99DD);
        // 100D:99DD mov AL,byte ptr DS:[0x47D1]
        AL = UInt8[DS, (ushort)0x47D1];
        // 100D:99E0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:99E2 jns short 0x9A1C
        if (!SignFlag)
        {
            return unknown_100D_9A1C_19AEC(0x0000);
        }
    label_100D_99E4_19AB4_8298:
        CheckExternalEvents(cs1, 0x99E4);
        // 100D:99E4 test AL,0x10
        Alu8.And(AL, (byte)0x10);
        // 100D:99E6 jne short 0x9A40
        if (!ZeroFlag)
        {
            goto label_100D_9A40_19B10_9072;
        }
    label_100D_99E8_19AB8_8301:
        CheckExternalEvents(cs1, 0x99E8);
        // 100D:99E8 mov SI,word ptr DS:[0x47C6]
        SI = UInt16[DS, (ushort)0x47C6];
        // 100D:99EC mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
    label_100D_99F0_19AC0_8304:
        CheckExternalEvents(cs1, 0x99F0);
        // 100D:99F0 cmp byte ptr ES:[SI],0xFF
        Alu8.Sub(UInt8[ES, SI], (byte)0xFF);
        // 100D:99F4 je short 0x9A1D
        if (!(ZeroFlag))
        {
            if (JumpDispatcher.Jump(unknown_100D_99F6_19AC6, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9A1D_19AED_12851:
        CheckExternalEvents(cs1, 0x9A1D);
        // 100D:9A1D cmp word ptr DS:[0x47CE],0
        Alu16.Sub(UInt16[DS, (ushort)0x47CE], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:9A22 js short 0x9A3B
        if (SignFlag)
        {
            goto label_100D_9A3B_19B0B_12854;
        }
    label_100D_9A24_19AF4_12866:
        CheckExternalEvents(cs1, 0x9A24);
        // 100D:9A24 mov SI,word ptr DS:[0x47CA]
        SI = UInt16[DS, (ushort)0x47CA];
        // 100D:9A28 mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:9A2C call near 0x994F
        NearCall(cs1, 0x9A2F, unknown_100D_994F_19A1F);
    label_100D_9A2F_19AFF_12870:
        CheckExternalEvents(cs1, 0x9A2F);
        // 100D:9A2F add SI,word ptr ES:[BP+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BP + SI)]);
        // 100D:9A32 call near 0x996C
        NearCall(cs1, 0x9A35, unknown_100D_996C_19A3C);
    label_100D_9A35_19B05_12873:
        CheckExternalEvents(cs1, 0x9A35);
        // 100D:9A35 mov word ptr DS:[0x47C6],SI
        UInt16[DS, (ushort)0x47C6] = SI;
        // 100D:9A39 jmp short 0x99F0
        goto label_100D_99F0_19AC0_8304;
    label_100D_9A3B_19B0B_12854:
        CheckExternalEvents(cs1, 0x9A3B);
        // 100D:9A3B or byte ptr DS:[0x47D1],0x10
        UInt8[DS, (ushort)0x47D1] = Alu8.Or(UInt8[DS, (ushort)0x47D1], (byte)0x10);
    label_100D_9A40_19B10_9072:
        CheckExternalEvents(cs1, 0x9A40);
        // 100D:9A40 mov SI,word ptr DS:[0x47C6]
        SI = UInt16[DS, (ushort)0x47C6];
        // 100D:9A44 mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:9A48 cmp word ptr DS:[0x47CE],0
        Alu16.Sub(UInt16[DS, (ushort)0x47CE], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:9A4D jg short 0x99F6
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_99F6_19AC6, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9A4F_19B1F_9274:
        CheckExternalEvents(cs1, 0x9A4F);
        // 100D:9A4F call near 0x9AB4
        NearCall(cs1, 0x9A52, unknown_100D_9AB4_19B84);
    label_100D_9A52_19B22_9282:
        CheckExternalEvents(cs1, 0x9A52);
        // 100D:9A52 jb short 0x99F6
        if (CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_99F6_19AC6, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9A54_19B24_9284:
        CheckExternalEvents(cs1, 0x9A54);
        // 100D:9A54 call near 0x9A7B
        NearCall(cs1, 0x9A57, unknown_100D_9A7B_19B4B);
    label_100D_9A57_19B27_9286:
        CheckExternalEvents(cs1, 0x9A57);
        // 100D:9A57 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:9A59 jne short 0x9A1C
        if (!ZeroFlag)
        {
            return unknown_100D_9A1C_19AEC(0x0000);
        }
    label_100D_9A5B_19B2B_9289:
        CheckExternalEvents(cs1, 0x9A5B);
        // 100D:9A5B call near 0x9A60
        NearCall(cs1, 0x9A5E, unknown_100D_9A60_19B30);
    label_100D_9A5E_19B2E_9292:
        CheckExternalEvents(cs1, 0x9A5E);
        // 100D:9A5E jmp short 0x99F6
        if (JumpDispatcher.Jump(unknown_100D_99F6_19AC6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_99F6_19AC6(int loadOffset)
    {
    entrydispatcher:
    label_100D_99F6_19AC6_8306:
        CheckExternalEvents(cs1, 0x99F6);
        // 100D:99F6 dec word ptr DS:[0x47CE]
        UInt16[DS, (ushort)0x47CE] = Alu16.Dec(UInt16[DS, (ushort)0x47CE]);
        // 100D:99FA mov word ptr DS:[0x47C8],SI
        UInt16[DS, (ushort)0x47C8] = SI;
        // 100D:99FE call near 0x9BB1
        NearCall(cs1, 0x9A01, unknown_100D_9BB1_19C81);
    label_100D_9A01_19AD1_8366:
        CheckExternalEvents(cs1, 0x9A01);
        // 100D:9A01 mov word ptr DS:[0x47C6],SI
        UInt16[DS, (ushort)0x47C6] = SI;
        // 100D:9A05 cmp word ptr DS:[0xD834],0x013F
        Alu16.Sub(UInt16[DS, (ushort)0xD834], (ushort)0x013F);
        // 100D:9A0B je short 0x9A1C
        if (ZeroFlag)
        {
            return unknown_100D_9A1C_19AEC(0x0000);
        }
    label_100D_9A0D_19ADD_9260:
        CheckExternalEvents(cs1, 0x9A0D);
        // 100D:9A0D call near 0x908C
        NearCall(cs1, 0x9A10, unknown_100D_908C_1915C);
    label_100D_9A10_19AE0_9262:
        CheckExternalEvents(cs1, 0x9A10);
        // 100D:9A10 mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:9A13 call near 0xDB74
        NearCall(cs1, 0x9A16, unknown_100D_DB74_1DC44);
    label_100D_9A16_19AE6_9265:
        CheckExternalEvents(cs1, 0x9A16);
        // 100D:9A16 call near 0xC4F0
        NearCall(cs1, 0x9A19, unknown_100D_C4F0_1C5C0);
    label_100D_9A19_19AE9_9267:
        CheckExternalEvents(cs1, 0x9A19);
        // 100D:9A19 jmp near 0xDB67
        if (JumpDispatcher.Jump(unknown_100D_DB67_1DC37, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9A60_19B30(int loadOffset)
    {
    label_100D_9A60_19B30_8673:
        CheckExternalEvents(cs1, 0x9A60);
        // 100D:9A60 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9A62 je short 0x9A74
        if (ZeroFlag)
        {
            goto label_100D_9A74_19B44_8687;
        }
    label_100D_9A64_19B34_8676:
        CheckExternalEvents(cs1, 0x9A64);
        // 100D:9A64 mov BX,AX
        BX = AX;
        // 100D:9A66 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:9A68 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
        // 100D:9A6B mov DI,SI
        DI = SI;
    label_100D_9A6D_19B3D_8681:
        CheckExternalEvents(cs1, 0x9A6D);
        // 100D:9A6D repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_9A6D_19B3D = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_9A6D_19B3D)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_9A6D_19B3D = ZeroFlag == false;
        }
        // 100D:9A6F dec BX
        BX = Alu16.Dec(BX);
        // 100D:9A70 jne short 0x9A6D
        if (!ZeroFlag)
        {
            goto label_100D_9A6D_19B3D_8681;
        }
    label_100D_9A72_19B42_8685:
        CheckExternalEvents(cs1, 0x9A72);
        // 100D:9A72 mov SI,DI
        SI = DI;
    label_100D_9A74_19B44_8687:
        CheckExternalEvents(cs1, 0x9A74);
        // 100D:9A74 mov word ptr DS:[0x47CE],8
        UInt16[DS, (ushort)0x47CE] = (ushort)0x0008;
        // 100D:9A7A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9A7B_19B4B(int loadOffset)
    {
    label_100D_9A7B_19B4B_8650:
        CheckExternalEvents(cs1, 0x9A7B);
        // 100D:9A7B mov AL,byte ptr DS:[0x47D0]
        AL = UInt8[DS, (ushort)0x47D0];
        // 100D:9A7E mov BX,0x0F18
        BX = (ushort)0x0F18;
        // 100D:9A81 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9A83 jne short 0x9A9A
        if (!ZeroFlag)
        {
            goto label_100D_9A9A_19B6A_8660;
        }
    label_100D_9A85_19B55_8655:
        CheckExternalEvents(cs1, 0x9A85);
        // 100D:9A85 mov AL,5
        AL = (byte)0x05;
        // 100D:9A87 mov BX,0x0F38
        BX = (ushort)0x0F38;
        // 100D:9A8A cmp word ptr DS:[0x47C4],7
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:9A8F jne short 0x9A9A
        if (!ZeroFlag)
        {
            goto label_100D_9A9A_19B6A_8660;
        }
    label_100D_9A91_19B61_9940:
        CheckExternalEvents(cs1, 0x9A91);
        // 100D:9A91 cmp byte ptr DS:[0x002A],0xC8
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0xC8);
        // 100D:9A96 jb short 0x9A9A
        if (CarryFlag)
        {
            goto label_100D_9A9A_19B6A_8660;
        }
    label_100D_9A98_19B68_41309:
        CheckExternalEvents(cs1, 0x9A98);
        // 100D:9A98 inc AL
        AL = Alu8.Inc(AL);
    label_100D_9A9A_19B6A_8660:
        CheckExternalEvents(cs1, 0x9A9A);
        // 100D:9A9A dec AL
        AL = Alu8.Dec(AL);
        // 100D:9A9C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9A9E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9AA0 mov BP,AX
        BP = AX;
        // 100D:9AA2 add BP,word ptr DS:[0x00F0]
        BP = Alu16.Add(BP, UInt16[DS, (ushort)0x00F0]);
        // 100D:9AA6 mov SI,word ptr DS:[0x47CA]
        SI = UInt16[DS, (ushort)0x47CA];
        // 100D:9AAA mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:9AAE add SI,word ptr ES:[BP+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BP + SI)]);
        // 100D:9AB1 jmp near 0xE3B7
        return unknown_100D_E3B7_1E487(0x0000);
    }

    public virtual Action unknown_100D_9AB4_19B84(int loadOffset)
    {
    label_100D_9AB4_19B84_9276:
        CheckExternalEvents(cs1, 0x9AB4);
        // 100D:9AB4 mov AL,byte ptr DS:[0x47E1]
        AL = UInt8[DS, (ushort)0x47E1];
        // 100D:9AB7 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9AB9 je short 0x9B08
        if (ZeroFlag)
        {
            goto label_100D_9B08_19BD8_9280;
        }
    label_100D_9ABB_19B8B_30239:
        CheckExternalEvents(cs1, 0x9ABB);
        // 100D:9ABB js short 0x9ADB
        if (SignFlag)
        {
            goto label_100D_9ADB_19BAB_30259;
        }
    label_100D_9ABD_19B8D_30241:
        CheckExternalEvents(cs1, 0x9ABD);
        // 100D:9ABD or byte ptr DS:[0x47E1],0x80
        UInt8[DS, (ushort)0x47E1] = Alu8.Or(UInt8[DS, (ushort)0x47E1], (byte)0x80);
        // 100D:9AC2 call near 0x9B09
        NearCall(cs1, 0x9AC5, unknown_100D_9B09_19BD9);
    label_100D_9AC5_19B95_30250:
        CheckExternalEvents(cs1, 0x9AC5);
        // 100D:9AC5 mov AL,byte ptr DS:[0x47E2]
        AL = UInt8[DS, (ushort)0x47E2];
        // 100D:9AC8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9ACA mov BP,AX
        BP = AX;
        // 100D:9ACC mov SI,word ptr DS:[0x47CA]
        SI = UInt16[DS, (ushort)0x47CA];
        // 100D:9AD0 add SI,word ptr ES:[BP+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BP + SI)]);
        // 100D:9AD3 mov word ptr DS:[0x47CE],0x0014
        UInt16[DS, (ushort)0x47CE] = (ushort)0x0014;
        // 100D:9AD9 stc
        CarryFlag = true;
        // 100D:9ADA ret near
        return NearRet((ushort)0x0000);
    label_100D_9ADB_19BAB_30259:
        CheckExternalEvents(cs1, 0x9ADB);
        // 100D:9ADB shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:9ADD jae short 0x9B08
        if (!CarryFlag)
        {
            goto label_100D_9B08_19BD8_9280;
        }
    label_100D_9ADF_19BAF_30262:
        CheckExternalEvents(cs1, 0x9ADF);
        // 100D:9ADF mov byte ptr DS:[0x47E1],0x80
        UInt8[DS, (ushort)0x47E1] = (byte)0x80;
        // 100D:9AE4 call near 0xD075
        NearCall(cs1, 0x9AE7, unknown_100D_D075_1D145);
    label_100D_9AE7_19BB7_30265:
        CheckExternalEvents(cs1, 0x9AE7);
        // 100D:9AE7 mov SI,word ptr DS:[0x47E4]
        SI = UInt16[DS, (ushort)0x47E4];
        // 100D:9AEB cmp word ptr DS:[SI],0x0038
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)56)));
        // 100D:9AEE jae short 0x9B08
        if (!CarryFlag)
        {
            goto label_100D_9B08_19BD8_9280;
        }
    label_100D_9AF0_19BC0_30269:
        CheckExternalEvents(cs1, 0x9AF0);
        // 100D:9AF0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9AF1 mov CX,AX
        CX = AX;
        // 100D:9AF3 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9AF4 mov DX,AX
        DX = AX;
        // 100D:9AF6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9AF7 mov BX,AX
        BX = AX;
        // 100D:9AF9 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9AFA xchg CX,AX
        ushort temp_100D_9AFA_19BCA = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_9AFA_19BCA);
        // 100D:9AFB call near 0x8865
        NearCall(cs1, 0x9AFE, unknown_100D_8865_18935);
    label_100D_9AFE_19BCE_30279:
        CheckExternalEvents(cs1, 0x9AFE);
        // 100D:9AFE call near 0xD068
        NearCall(cs1, 0x9B01, unknown_100D_D068_1D138);
    label_100D_9B01_19BD1_30281:
        CheckExternalEvents(cs1, 0x9B01);
        // 100D:9B01 call near 0xDBB2
        NearCall(cs1, 0x9B04, unknown_100D_DBB2_1DC82);
    label_100D_9B04_19BD4_30283:
        CheckExternalEvents(cs1, 0x9B04);
        // 100D:9B04 call near 0xC4DD
        NearCall(cs1, 0x9B07, unknown_100D_C4DD_1C5AD);
    label_100D_9B07_19BD7_30285:
        CheckExternalEvents(cs1, 0x9B07);
        // 100D:9B07 clc
        CarryFlag = false;
    label_100D_9B08_19BD8_9280:
        CheckExternalEvents(cs1, 0x9B08);
        // 100D:9B08 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9B09_19BD9(int loadOffset)
    {
    label_100D_9B09_19BD9_30244:
        CheckExternalEvents(cs1, 0x9B09);
        // 100D:9B09 mov SI,word ptr DS:[0x47E4]
        SI = UInt16[DS, (ushort)0x47E4];
        // 100D:9B0D cmp word ptr DS:[SI],0x0038
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)56)));
        // 100D:9B10 jb short 0x9B48
        if (CarryFlag)
        {
            goto label_100D_9B48_19C18_30248;
        }
    label_100D_9B12_19BE2_33967:
        CheckExternalEvents(cs1, 0x9B12);
        // 100D:9B12 mov AX,word ptr DS:[0x0020]
        AX = UInt16[DS, (ushort)0x0020];
        // 100D:9B15 je short 0x9B1C
        if (ZeroFlag)
        {
            goto label_100D_9B1C_19BEC_33973;
        }
    label_100D_9B17_19BE7_33970:
        CheckExternalEvents(cs1, 0x9B17);
        // 100D:9B17 mov AL,byte ptr DS:[0x009D]
        AL = UInt8[DS, (ushort)0x009D];
        // 100D:9B1A xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_100D_9B1C_19BEC_33973:
        CheckExternalEvents(cs1, 0x9B1C);
        // 100D:9B1C call near 0x8A23
        NearCall(cs1, 0x9B1F, unknown_100D_8A23_18AF3);
    label_100D_9B1F_19BEF_33974:
        CheckExternalEvents(cs1, 0x9B1F);
        // 100D:9B1F mov CX,AX
        CX = AX;
        // 100D:9B21 les SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_9B21_19BF1 = (ushort)0xDBB0;
        ushort lxsValue_100D_9B21_19BF1 = UInt16[DS, lxsOffset_100D_9B21_19BF1];
        ushort lxsSegment_100D_9B21_19BF1 = UInt16[DS, (ushort)(lxsOffset_100D_9B21_19BF1 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_9B21_19BF1);
        ES = unchecked((ushort)lxsSegment_100D_9B21_19BF1);
        // 100D:9B25 mov DI,SI
        DI = SI;
        // 100D:9B27 mov BP,5
        BP = (ushort)0x0005;
    label_100D_9B2A_19BFA_33979:
        CheckExternalEvents(cs1, 0x9B2A);
        // 100D:9B2A and BX,0x000F
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:9B2D je short 0x9B32
        if (ZeroFlag)
        {
            goto label_100D_9B32_19C02_33981;
        }
    label_100D_9B2F_19BFF_33994:
        CheckExternalEvents(cs1, 0x9B2F);
        // 100D:9B2F mov BP,6
        BP = (ushort)0x0006;
    label_100D_9B32_19C02_33981:
        CheckExternalEvents(cs1, 0x9B32);
        // 100D:9B32 add BX,BP
        BX = Alu16.Add(BX, BP);
        // 100D:9B34 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:9B36 mov AX,word ptr ES:[BX+SI]
        AX = UInt16[ES, (ushort)(BX + SI)];
        // 100D:9B39 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:9B3A mov BL,DH
        BL = DH;
        // 100D:9B3C mov DH,DL
        DH = DL;
        // 100D:9B3E mov DL,CH
        DL = CH;
        // 100D:9B40 mov CH,CL
        CH = CL;
        // 100D:9B42 mov CL,0xFF
        CL = (byte)0xFF;
        // 100D:9B44 cmp BL,CL
        Alu8.Sub(BL, CL);
        // 100D:9B46 jne short 0x9B2A
        if (!ZeroFlag)
        {
            goto label_100D_9B2A_19BFA_33979;
        }
    label_100D_9B48_19C18_30248:
        CheckExternalEvents(cs1, 0x9B48);
        // 100D:9B48 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9B49_19C19(int loadOffset)
    {
    label_100D_9B49_19C19_15621:
        CheckExternalEvents(cs1, 0x9B49);
        // 100D:9B49 mov AX,word ptr DS:[0x47E1]
        AX = UInt16[DS, (ushort)0x47E1];
        // 100D:9B4C cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:9B4E jne short 0x9B84
        if (!ZeroFlag)
        {
            goto label_100D_9B84_19C54_15625;
        }
    label_100D_9B50_19C20_30295:
        CheckExternalEvents(cs1, 0x9B50);
        // 100D:9B50 push SI
        Stack.Push16(SI);
        // 100D:9B51 push AX
        Stack.Push16(AX);
        // 100D:9B52 call near 0x9197
        NearCall(cs1, 0x9B55, unknown_100D_9197_19267);
    label_100D_9B55_19C25_30299:
        CheckExternalEvents(cs1, 0x9B55);
        // 100D:9B55 pop AX
        AX = Stack.Pop16();
        // 100D:9B56 mov AL,AH
        AL = AH;
        // 100D:9B58 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9B5A inc AX
        AX = Alu16.Inc(AX);
        // 100D:9B5B inc AX
        AX = Alu16.Inc(AX);
        // 100D:9B5C mov BP,AX
        BP = AX;
        // 100D:9B5E mov SI,word ptr DS:[0x47CA]
        SI = UInt16[DS, (ushort)0x47CA];
        // 100D:9B62 mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:9B66 add SI,word ptr ES:[BP+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BP + SI)]);
        // 100D:9B69 mov byte ptr DS:[0x47E1],0x81
        UInt8[DS, (ushort)0x47E1] = (byte)0x81;
    label_100D_9B6E_19C3E_30310:
        CheckExternalEvents(cs1, 0x9B6E);
        // 100D:9B6E push ES
        Stack.Push16(ES);
        // 100D:9B6F mov BP,0x99F6
        BP = (ushort)0x99F6;
        // 100D:9B72 mov AX,0x000C
        AX = (ushort)0x000C;
        // 100D:9B75 call near 0xE353
        NearCall(cs1, 0x9B78, unknown_100D_E353_1E423);
    label_100D_9B78_19C48_30314:
        CheckExternalEvents(cs1, 0x9B78);
        // 100D:9B78 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9B79 mov SI,word ptr DS:[0x47C6]
        SI = UInt16[DS, (ushort)0x47C6];
        // 100D:9B7D cmp byte ptr ES:[SI],0xFF
        Alu8.Sub(UInt8[ES, SI], (byte)0xFF);
        // 100D:9B81 jne short 0x9B6E
        if (!ZeroFlag)
        {
            goto label_100D_9B6E_19C3E_30310;
        }
    label_100D_9B83_19C53_30320:
        CheckExternalEvents(cs1, 0x9B83);
        // 100D:9B83 pop SI
        SI = Stack.Pop16();
    label_100D_9B84_19C54_15625:
        CheckExternalEvents(cs1, 0x9B84);
        // 100D:9B84 mov word ptr DS:[0x47E1],0
        UInt16[DS, (ushort)0x47E1] = (ushort)0x0000;
        // 100D:9B8A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9B8B_19C5B(int loadOffset)
    {
    entrydispatcher:
    label_100D_9B8B_19C5B_3516:
        CheckExternalEvents(cs1, 0x9B8B);
        // 100D:9B8B call near 0xA7A5
        NearCall(cs1, 0x9B8E, unknown_100D_A7A5_1A875);
    label_100D_9B8E_19C5E_3580:
        CheckExternalEvents(cs1, 0x9B8E);
        // 100D:9B8E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:9B90 mov byte ptr DS:[0x47C3],0
        UInt8[DS, (ushort)0x47C3] = (byte)0x00;
        // 100D:9B95 mov word ptr DS:[0x47CE],AX
        UInt16[DS, (ushort)0x47CE] = AX;
        // 100D:9B98 and byte ptr DS:[0x47D1],0x7F
        UInt8[DS, (ushort)0x47D1] = Alu8.And(UInt8[DS, (ushort)0x47D1], (byte)0x7F);
        // 100D:9B9D xchg AX,word ptr DS:[0x47C6]
        ushort xchgOffset_100D_9B9D_19C6D = (ushort)0x47C6;
        ushort temp_100D_9B9D_19C6D = AX;
        AX = UInt16[DS, xchgOffset_100D_9B9D_19C6D];
        UInt16[DS, xchgOffset_100D_9B9D_19C6D] = unchecked((ushort)temp_100D_9B9D_19C6D);
        // 100D:9BA1 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:9BA3 je short 0x9BAB
        if (ZeroFlag)
        {
            goto label_100D_9BAB_19C7B_3588;
        }
    label_100D_9BA5_19C75_9335:
        CheckExternalEvents(cs1, 0x9BA5);
        // 100D:9BA5 mov SI,0x99BE
        SI = (ushort)0x99BE;
        // 100D:9BA8 jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    label_100D_9BAB_19C7B_3588:
        CheckExternalEvents(cs1, 0x9BAB);
        // 100D:9BAB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9BAC_19C7C(int loadOffset)
    {
    label_100D_9BAC_19C7C_8006:
        CheckExternalEvents(cs1, 0x9BAC);
        // 100D:9BAC push SI
        Stack.Push16(SI);
        // 100D:9BAD call near 0x9197
        NearCall(cs1, 0x9BB0, unknown_100D_9197_19267);
    label_100D_9BB0_19C80_8013:
        CheckExternalEvents(cs1, 0x9BB0);
        // 100D:9BB0 pop SI
        SI = Stack.Pop16();
        return unknown_100D_9BB1_19C81(0x0000);
    }

    public virtual Action unknown_100D_9BB1_19C81(int loadOffset)
    {
    label_100D_9BB1_19C81_8015:
        CheckExternalEvents(cs1, 0x9BB1);
        // 100D:9BB1 call near 0x9BEE
        NearCall(cs1, 0x9BB4, unknown_100D_9BEE_19CBE);
    label_100D_9BB4_19C84_8054:
        CheckExternalEvents(cs1, 0x9BB4);
        // 100D:9BB4 push SI
        Stack.Push16(SI);
        // 100D:9BB5 cmp word ptr DS:[0x4540],0
        Alu16.Sub(UInt16[DS, (ushort)0x4540], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:9BBA jne short 0x9BCC
        if (!ZeroFlag)
        {
            goto label_100D_9BCC_19C9C_8311;
        }
    label_100D_9BBC_19C8C_8058:
        CheckExternalEvents(cs1, 0x9BBC);
        // 100D:9BBC mov SI,0x1BF0
        SI = (ushort)0x1BF0;
        // 100D:9BBF mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:9BC2 call near 0x5B99
        NearCall(cs1, 0x9BC5, unknown_100D_5B99_15C69);
    label_100D_9BC5_19C95_8062:
        CheckExternalEvents(cs1, 0x9BC5);
        // 100D:9BC5 mov word ptr DS:[SI],0x0080
        UInt16[DS, SI] = (ushort)0x0080;
        // 100D:9BC9 jmp short 0x9BD7
        goto label_100D_9BD7_19CA7_8065;
    label_100D_9BCC_19C9C_8311:
        CheckExternalEvents(cs1, 0x9BCC);
        // 100D:9BCC call near 0x9C2D
        NearCall(cs1, 0x9BCF, unknown_100D_9C2D_19CFD);
    label_100D_9BCF_19C9F_8363:
        CheckExternalEvents(cs1, 0x9BCF);
        // 100D:9BCF cmp word ptr DS:[0xD834],0x013F
        Alu16.Sub(UInt16[DS, (ushort)0xD834], (ushort)0x013F);
        // 100D:9BD5 je short 0x9BEC
        if (ZeroFlag)
        {
            goto label_100D_9BEC_19CBC_8245;
        }
    label_100D_9BD7_19CA7_8065:
        CheckExternalEvents(cs1, 0x9BD7);
        // 100D:9BD7 mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:9BDA cmp word ptr DS:[SI+6],0x0098
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)6)], (ushort)0x0098);
        // 100D:9BDF jb short 0x9BE6
        if (CarryFlag)
        {
            goto label_100D_9BE6_19CB6_8071;
        }
    label_100D_9BE1_19CB1_8069:
        CheckExternalEvents(cs1, 0x9BE1);
        // 100D:9BE1 mov word ptr DS:[SI+6],0x0098
        UInt16[DS, (ushort)(SI + (sbyte)6)] = (ushort)0x0098;
    label_100D_9BE6_19CB6_8071:
        CheckExternalEvents(cs1, 0x9BE6);
        // 100D:9BE6 call near 0xC446
        NearCall(cs1, 0x9BE9, unknown_100D_C446_1C516);
    label_100D_9BE9_19CB9_8118:
        CheckExternalEvents(cs1, 0x9BE9);
        // 100D:9BE9 call near 0x9D16
        NearCall(cs1, 0x9BEC, unknown_100D_9D16_19DE6);
    label_100D_9BEC_19CBC_8245:
        CheckExternalEvents(cs1, 0x9BEC);
        // 100D:9BEC pop SI
        SI = Stack.Pop16();
        // 100D:9BED ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9BEE_19CBE(int loadOffset)
    {
    label_100D_9BEE_19CBE_8016:
        CheckExternalEvents(cs1, 0x9BEE);
        // 100D:9BEE xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:9BF0 push DS
        Stack.Push16(DS);
        // 100D:9BF1 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9BF2 mov DS,word ptr SS:[0xDBB2]
        DS = UInt16[SS, (ushort)0xDBB2];
        // 100D:9BF7 mov DI,0x460A
        DI = (ushort)0x460A;
    label_100D_9BFA_19CCA_8022:
        CheckExternalEvents(cs1, 0x9BFA);
        // 100D:9BFA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9BFB xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9BFD or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9BFF je short 0x9C25
        if (ZeroFlag)
        {
            goto label_100D_9C25_19CF5_8049;
        }
    label_100D_9C01_19CD1_8026:
        CheckExternalEvents(cs1, 0x9C01);
        // 100D:9C01 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:9C03 jne short 0x9C08
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9C03");
        }
    label_100D_9C08_19CD8_8029:
        CheckExternalEvents(cs1, 0x9C08);
        // 100D:9C08 push SI
        Stack.Push16(SI);
        // 100D:9C09 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:9C0C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9C0E mov BP,AX
        BP = AX;
        // 100D:9C10 mov SI,word ptr SS:[0x47CC]
        SI = UInt16[SS, (ushort)0x47CC];
        // 100D:9C15 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
    label_100D_9C18_19CE8_8036:
        CheckExternalEvents(cs1, 0x9C18);
        // 100D:9C18 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9C19 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9C1B je short 0x9C22
        if (ZeroFlag)
        {
            goto label_100D_9C22_19CF2_8045;
        }
    label_100D_9C1D_19CED_8039:
        CheckExternalEvents(cs1, 0x9C1D);
        // 100D:9C1D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:9C1E movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:9C1F inc CX
        CX = Alu16.Inc(CX);
        // 100D:9C20 jmp short 0x9C18
        goto label_100D_9C18_19CE8_8036;
    label_100D_9C22_19CF2_8045:
        CheckExternalEvents(cs1, 0x9C22);
        // 100D:9C22 pop SI
        SI = Stack.Pop16();
        // 100D:9C23 jmp short 0x9BFA
        goto label_100D_9BFA_19CCA_8022;
    label_100D_9C25_19CF5_8049:
        CheckExternalEvents(cs1, 0x9C25);
        // 100D:9C25 mov word ptr SS:[0x4608],CX
        UInt16[SS, (ushort)0x4608] = CX;
        // 100D:9C2A push SS
        Stack.Push16(SS);
        // 100D:9C2B pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9C2C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9C2D_19CFD(int loadOffset)
    {
    label_100D_9C2D_19CFD_8313:
        CheckExternalEvents(cs1, 0x9C2D);
        // 100D:9C2D mov word ptr DS:[0xD834],0x013F
        UInt16[DS, (ushort)0xD834] = (ushort)0x013F;
        // 100D:9C33 mov word ptr DS:[0xD836],0x00C7
        UInt16[DS, (ushort)0xD836] = (ushort)0x00C7;
        // 100D:9C39 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:9C3B mov word ptr DS:[0xD838],AX
        UInt16[DS, (ushort)0xD838] = AX;
        // 100D:9C3E mov word ptr DS:[0xD83A],AX
        UInt16[DS, (ushort)0xD83A] = AX;
        // 100D:9C41 mov AX,DS
        AX = DS;
        // 100D:9C43 mov ES,AX
        ES = AX;
        // 100D:9C45 mov SI,0x4540
        SI = (ushort)0x4540;
        // 100D:9C48 mov DI,0x4608
        DI = (ushort)0x4608;
        // 100D:9C4B call near 0x9C54
        NearCall(cs1, 0x9C4E, unknown_100D_9C54_19D24);
    label_100D_9C4E_19D1E_8360:
        CheckExternalEvents(cs1, 0x9C4E);
        // 100D:9C4E mov SI,0x4608
        SI = (ushort)0x4608;
        // 100D:9C51 mov DI,0x4540
        DI = (ushort)0x4540;
        return unknown_100D_9C54_19D24(0x0000);
    }

    public virtual Action unknown_100D_9C54_19D24(int loadOffset)
    {
    label_100D_9C54_19D24_8324:
        CheckExternalEvents(cs1, 0x9C54);
        // 100D:9C54 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9C55 mov CX,AX
        CX = AX;
    label_100D_9C57_19D27_8327:
        CheckExternalEvents(cs1, 0x9C57);
        // 100D:9C57 push CX
        Stack.Push16(CX);
        // 100D:9C58 push DI
        Stack.Push16(DI);
        // 100D:9C59 mov CX,word ptr DS:[DI]
        CX = UInt16[DS, DI];
        // 100D:9C5B add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_9C5E_19D2E_8331:
        CheckExternalEvents(cs1, 0x9C5E);
        // 100D:9C5E cmps word ptr DS:[SI],word ptr ES:[DI]
        Alu16.Sub(UInt16[DS, SI], UInt16[ES, DI]);
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:9C5F lahf
        AH = unchecked((byte)FlagRegister16);
        // 100D:9C60 cmps byte ptr DS:[SI],byte ptr ES:[DI]
        Alu8.Sub(UInt8[DS, SI], UInt8[ES, DI]);
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:9C61 mov AL,AH
        AL = AH;
        // 100D:9C63 lahf
        AH = unchecked((byte)FlagRegister16);
        // 100D:9C64 and AL,AH
        AL = Alu8.And(AL, AH);
        // 100D:9C66 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:9C68 jne short 0x9C75
        if (!ZeroFlag)
        {
            goto label_100D_9C75_19D45_8339;
        }
    label_100D_9C6A_19D3A_8344:
        CheckExternalEvents(cs1, 0x9C6A);
        // 100D:9C6A sub SI,3
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:9C6D loop 0x9C5E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_9C5E_19D2E_8331;
        }
    label_100D_9C6F_19D3F_9104:
        CheckExternalEvents(cs1, 0x9C6F);
        // 100D:9C6F call near 0x9CC6
        NearCall(cs1, 0x9C72, unknown_100D_9CC6_19D96);
    label_100D_9C72_19D42_9148:
        CheckExternalEvents(cs1, 0x9C72);
        // 100D:9C72 add SI,3
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
    label_100D_9C75_19D45_8339:
        CheckExternalEvents(cs1, 0x9C75);
        // 100D:9C75 pop DI
        DI = Stack.Pop16();
        // 100D:9C76 pop CX
        CX = Stack.Pop16();
        // 100D:9C77 loop 0x9C57
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_9C57_19D27_8327;
        }
    label_100D_9C79_19D49_8348:
        CheckExternalEvents(cs1, 0x9C79);
        // 100D:9C79 cmp byte ptr DS:[0x47E1],0x81
        Alu8.Sub(UInt8[DS, (ushort)0x47E1], (byte)0x81);
        // 100D:9C7E je short 0x9CA6
        if (ZeroFlag)
        {
            goto label_100D_9CA6_19D76_8355;
        }
    label_100D_9C80_19D50_8351:
        CheckExternalEvents(cs1, 0x9C80);
        // 100D:9C80 call near 0xABCC
        NearCall(cs1, 0x9C83, unknown_100D_ABCC_1AC9C);
    label_100D_9C83_19D53_8353:
        CheckExternalEvents(cs1, 0x9C83);
        // 100D:9C83 je short 0x9CA6
        if (ZeroFlag)
        {
            goto label_100D_9CA6_19D76_8355;
        }
    label_100D_9C85_19D55_9077:
        CheckExternalEvents(cs1, 0x9C85);
        // 100D:9C85 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:9C88 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:9C8A je short 0x9CC5
        if (ZeroFlag)
        {
            goto label_100D_9CC5_19D95_8358;
        }
    label_100D_9C8C_19D5C_9081:
        CheckExternalEvents(cs1, 0x9C8C);
        // 100D:9C8C cmp AL,0x0C
        Alu8.Sub(AL, (byte)0x0C);
        // 100D:9C8E je short 0x9CC5
        if (ZeroFlag)
        {
            goto label_100D_9CC5_19D95_8358;
        }
    label_100D_9C90_19D60_9084:
        CheckExternalEvents(cs1, 0x9C90);
        // 100D:9C90 mov SI,word ptr DS:[0xDC28]
        SI = UInt16[DS, (ushort)0xDC28];
        // 100D:9C94 mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:9C97 cmp AX,word ptr DS:[0xD83A]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xD83A]);
        // 100D:9C9B jae short 0x9CA6
        if (!CarryFlag)
        {
            goto label_100D_9CA6_19D76_8355;
        }
    label_100D_9C9D_19D6D_9943:
        CheckExternalEvents(cs1, 0x9C9D);
        // 100D:9C9D mov word ptr DS:[0xD83A],AX
        UInt16[DS, (ushort)0xD83A] = AX;
        // 100D:9CA0 cmp AX,word ptr DS:[0xD836]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xD836]);
        // 100D:9CA4 jle short 0x9CBF
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_9CBF_19D8F_9947;
        }
    label_100D_9CA6_19D76_8355:
        CheckExternalEvents(cs1, 0x9CA6);
        // 100D:9CA6 cmp byte ptr DS:[0x47E1],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x47E1], (byte)0x80);
        // 100D:9CAB jne short 0x9CC5
        if (!ZeroFlag)
        {
            goto label_100D_9CC5_19D95_8358;
        }
    label_100D_9CAD_19D7D_30287:
        CheckExternalEvents(cs1, 0x9CAD);
        // 100D:9CAD mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:9CB0 cmp AX,word ptr DS:[0xD83A]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xD83A]);
        // 100D:9CB4 jae short 0x9CC5
        if (!CarryFlag)
        {
            goto label_100D_9CC5_19D95_8358;
        }
    label_100D_9CB6_19D86_30291:
        CheckExternalEvents(cs1, 0x9CB6);
        // 100D:9CB6 mov word ptr DS:[0xD83A],AX
        UInt16[DS, (ushort)0xD83A] = AX;
        // 100D:9CB9 cmp AX,word ptr DS:[0xD836]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xD836]);
        // 100D:9CBD jg short 0x9CC5
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_9CC5_19D95_8358;
        }
    label_100D_9CBF_19D8F_9947:
        CheckExternalEvents(cs1, 0x9CBF);
        // 100D:9CBF mov word ptr DS:[0xD834],0x013F
        UInt16[DS, (ushort)0xD834] = (ushort)0x013F;
    label_100D_9CC5_19D95_8358:
        CheckExternalEvents(cs1, 0x9CC5);
        // 100D:9CC5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9CC6_19D96(int loadOffset)
    {
    label_100D_9CC6_19D96_9106:
        CheckExternalEvents(cs1, 0x9CC6);
        // 100D:9CC6 push SI
        Stack.Push16(SI);
        // 100D:9CC7 push DS
        Stack.Push16(DS);
        // 100D:9CC8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9CCA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9CCB mov BP,AX
        BP = AX;
        // 100D:9CCD dec BP
        BP = Alu16.Dec(BP);
        // 100D:9CCE lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9CCF mov DX,AX
        DX = AX;
        // 100D:9CD1 add DX,word ptr DS:[0x1BF0]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x1BF0]);
        // 100D:9CD5 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9CD6 mov BX,AX
        BX = AX;
        // 100D:9CD8 add BX,word ptr DS:[0x1BF2]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x1BF2]);
        // 100D:9CDC lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_9CDC_19DAC = (ushort)0xDBB0;
        ushort lxsValue_100D_9CDC_19DAC = UInt16[DS, lxsOffset_100D_9CDC_19DAC];
        ushort lxsSegment_100D_9CDC_19DAC = UInt16[DS, (ushort)(lxsOffset_100D_9CDC_19DAC + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_9CDC_19DAC);
        DS = unchecked((ushort)lxsSegment_100D_9CDC_19DAC);
        // 100D:9CE0 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:9CE2 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:9CE5 mov BP,0xD834
        BP = (ushort)0xD834;
        // 100D:9CE8 cmp word ptr SS:[BP],DX
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], DX);
        // 100D:9CEB jb short 0x9CF0
        if (CarryFlag)
        {
            goto label_100D_9CF0_19DC0_9127;
        }
    label_100D_9CED_19DBD_9125:
        CheckExternalEvents(cs1, 0x9CED);
        // 100D:9CED mov word ptr SS:[BP],DX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = DX;
    label_100D_9CF0_19DC0_9127:
        CheckExternalEvents(cs1, 0x9CF0);
        // 100D:9CF0 cmp word ptr SS:[BP+2],BX
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)2)], BX);
        // 100D:9CF3 jb short 0x9CF8
        if (CarryFlag)
        {
            goto label_100D_9CF8_19DC8_9131;
        }
    label_100D_9CF5_19DC5_9129:
        CheckExternalEvents(cs1, 0x9CF5);
        // 100D:9CF5 mov word ptr SS:[BP+2],BX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = BX;
    label_100D_9CF8_19DC8_9131:
        CheckExternalEvents(cs1, 0x9CF8);
        // 100D:9CF8 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9CF9 and AX,0x01FF
        AX = Alu16.And(AX, (ushort)0x01FF);
        // 100D:9CFC add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:9CFE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9CFF xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9D01 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:9D03 cmp word ptr SS:[BP+4],DX
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)4)], DX);
        // 100D:9D06 jae short 0x9D0B
        if (!CarryFlag)
        {
            goto label_100D_9D0B_19DDB_9141;
        }
    label_100D_9D08_19DD8_9139:
        CheckExternalEvents(cs1, 0x9D08);
        // 100D:9D08 mov word ptr SS:[BP+4],DX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = DX;
    label_100D_9D0B_19DDB_9141:
        CheckExternalEvents(cs1, 0x9D0B);
        // 100D:9D0B cmp word ptr SS:[BP+6],BX
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)6)], BX);
        // 100D:9D0E jae short 0x9D13
        if (!CarryFlag)
        {
            goto label_100D_9D13_19DE3_9145;
        }
    label_100D_9D10_19DE0_9143:
        CheckExternalEvents(cs1, 0x9D10);
        // 100D:9D10 mov word ptr SS:[BP+6],BX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = BX;
    label_100D_9D13_19DE3_9145:
        CheckExternalEvents(cs1, 0x9D13);
        // 100D:9D13 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9D14 pop SI
        SI = Stack.Pop16();
        // 100D:9D15 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9D16_19DE6(int loadOffset)
    {
    label_100D_9D16_19DE6_8120:
        CheckExternalEvents(cs1, 0x9D16);
        // 100D:9D16 push DS
        Stack.Push16(DS);
        // 100D:9D17 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9D18 mov DI,0x4540
        DI = (ushort)0x4540;
        // 100D:9D1B mov SI,0x4608
        SI = (ushort)0x4608;
        // 100D:9D1E mov CX,word ptr DS:[SI]
        CX = UInt16[DS, SI];
        // 100D:9D20 push SI
        Stack.Push16(SI);
        // 100D:9D21 mov AX,CX
        AX = CX;
        // 100D:9D23 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:9D25 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:9D27 add CX,2
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:9D2A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:9D2C pop SI
        SI = Stack.Pop16();
        return unknown_100D_9D2D_19DFD(0x0000);
    }

    public virtual Action unknown_100D_9D2D_19DFD(int loadOffset)
    {
    label_100D_9D2D_19DFD_8133:
        CheckExternalEvents(cs1, 0x9D2D);
        // 100D:9D2D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9D2E mov CX,AX
        CX = AX;
    label_100D_9D30_19E00_8135:
        CheckExternalEvents(cs1, 0x9D30);
        // 100D:9D30 push CX
        Stack.Push16(CX);
        // 100D:9D31 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D32 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9D34 mov BP,AX
        BP = AX;
        // 100D:9D36 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D37 mov DX,AX
        DX = AX;
        // 100D:9D39 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D3A mov BX,AX
        BX = AX;
        // 100D:9D3C add DX,word ptr DS:[0x1BF0]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x1BF0]);
        // 100D:9D40 add BX,word ptr DS:[0x1BF2]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x1BF2]);
        // 100D:9D44 push SI
        Stack.Push16(SI);
        // 100D:9D45 dec BP
        BP = Alu16.Dec(BP);
        // 100D:9D46 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:9D4A lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_9D4A_19E1A = (ushort)0xDBB0;
        ushort lxsValue_100D_9D4A_19E1A = UInt16[DS, lxsOffset_100D_9D4A_19E1A];
        ushort lxsSegment_100D_9D4A_19E1A = UInt16[DS, (ushort)(lxsOffset_100D_9D4A_19E1A + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_9D4A_19E1A);
        DS = unchecked((ushort)lxsSegment_100D_9D4A_19E1A);
        // 100D:9D4E shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:9D50 add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:9D53 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9D54 mov DI,AX
        DI = AX;
        // 100D:9D56 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9D57 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9D59 mov CX,AX
        CX = AX;
        // 100D:9D5B mov BP,0xD834
        BP = (ushort)0xD834;
        // 100D:9D5E call far dword ptr SS:[0x38CD]
        ushort targetSegment_8157 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_8157 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_8157 == cs2 && targetOffset_8157 == 0x0112)
        {
            FarCall(cs1, 0x9D63, cs2, unknown_3358_0112_33692);
            goto label_100D_9D63_19E33_8199;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8157:X4}:{targetOffset_8157:X4} at 100D:9D5E");
    label_100D_9D63_19E33_8199:
        CheckExternalEvents(cs1, 0x9D63);
        // 100D:9D63 push SS
        Stack.Push16(SS);
        // 100D:9D64 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9D65 pop SI
        SI = Stack.Pop16();
        // 100D:9D66 pop CX
        CX = Stack.Pop16();
        // 100D:9D67 loop 0x9D30
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_9D30_19E00_8135;
        }
    label_100D_9D69_19E39_8243:
        CheckExternalEvents(cs1, 0x9D69);
        // 100D:9D69 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9D6A_19E3A(int loadOffset)
    {
    label_100D_9D6A_19E3A_24222:
        CheckExternalEvents(cs1, 0x9D6A);
        // 100D:9D6A mov ES,word ptr SS:[0xDBD8]
        ES = UInt16[SS, (ushort)0xDBD8];
    label_100D_9D6F_19E3F_24224:
        CheckExternalEvents(cs1, 0x9D6F);
        // 100D:9D6F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D70 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9D72 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9D74 je short 0x9D93
        if (ZeroFlag)
        {
            return unknown_100D_9D93_19E63(0x0000);
        }
    label_100D_9D76_19E46_24228:
        CheckExternalEvents(cs1, 0x9D76);
        // 100D:9D76 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:9D78 jne short 0x9D7D
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9D78");
        }
    label_100D_9D7D_19E4D_24231:
        CheckExternalEvents(cs1, 0x9D7D);
        // 100D:9D7D push SI
        Stack.Push16(SI);
        // 100D:9D7E sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:9D81 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9D83 mov BP,AX
        BP = AX;
        // 100D:9D85 mov SI,word ptr SS:[0x47CC]
        SI = UInt16[SS, (ushort)0x47CC];
        // 100D:9D8A add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:9D8D call near 0x9D94
        NearCall(cs1, 0x9D90, unknown_100D_9D94_19E64);
    label_100D_9D90_19E60_24275:
        CheckExternalEvents(cs1, 0x9D90);
        // 100D:9D90 pop SI
        SI = Stack.Pop16();
        // 100D:9D91 jmp short 0x9D6F
        goto label_100D_9D6F_19E3F_24224;
    }

    public virtual Action unknown_100D_9D94_19E64(int loadOffset)
    {
    label_100D_9D94_19E64_24239:
        CheckExternalEvents(cs1, 0x9D94);
        // 100D:9D94 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D95 and AX,0x00FF
        AX = Alu16.And(AX, (ushort)0x00FF);
        // 100D:9D98 je short 0x9D93
        if (ZeroFlag)
        {
            return unknown_100D_9D93_19E63(0x0000);
        }
    label_100D_9D9A_19E6A_24243:
        CheckExternalEvents(cs1, 0x9D9A);
        // 100D:9D9A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9D9C mov BP,AX
        BP = AX;
        // 100D:9D9E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9D9F mov DX,AX
        DX = AX;
        // 100D:9DA1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9DA2 mov BX,AX
        BX = AX;
        // 100D:9DA4 add DX,word ptr SS:[0x1BF0]
        DX = Alu16.Add(DX, UInt16[SS, (ushort)0x1BF0]);
        // 100D:9DA9 add BX,word ptr SS:[0x1BF2]
        BX = Alu16.Add(BX, UInt16[SS, (ushort)0x1BF2]);
        // 100D:9DAE sub DX,word ptr SS:[0x46D2]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)0x46D2]);
        // 100D:9DB3 sub BX,word ptr SS:[0x46D4]
        BX = Alu16.Sub(BX, UInt16[SS, (ushort)0x46D4]);
        // 100D:9DB8 add DX,word ptr SS:[0x47D4]
        DX = Alu16.Add(DX, UInt16[SS, (ushort)0x47D4]);
        // 100D:9DBD add BX,word ptr SS:[0x47D6]
        BX = Alu16.Add(BX, UInt16[SS, (ushort)0x47D6]);
        // 100D:9DC2 push SI
        Stack.Push16(SI);
        // 100D:9DC3 push DS
        Stack.Push16(DS);
        // 100D:9DC4 dec BP
        BP = Alu16.Dec(BP);
        // 100D:9DC5 lds SI,word ptr SS:[0xDBB0]
        ushort lxsOffset_100D_9DC5_19E95 = (ushort)0xDBB0;
        ushort lxsValue_100D_9DC5_19E95 = UInt16[SS, lxsOffset_100D_9DC5_19E95];
        ushort lxsSegment_100D_9DC5_19E95 = UInt16[SS, (ushort)(lxsOffset_100D_9DC5_19E95 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_9DC5_19E95);
        DS = unchecked((ushort)lxsSegment_100D_9DC5_19E95);
        // 100D:9DCA shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:9DCC add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:9DCF lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9DD0 mov DI,AX
        DI = AX;
        // 100D:9DD2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9DD3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9DD5 mov CX,AX
        CX = AX;
        // 100D:9DD7 mov BP,0x47D4
        BP = (ushort)0x47D4;
        // 100D:9DDA call far dword ptr SS:[0x38CD]
        ushort targetSegment_24268 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_24268 = unchecked((ushort)(UInt16[SS, (ushort)0x38CD]));
        if (targetSegment_24268 == cs2 && targetOffset_24268 == 0x0112)
        {
            FarCall(cs1, 0x9DDF, cs2, unknown_3358_0112_33692);
            goto label_100D_9DDF_19EAF_24269;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_24268:X4}:{targetOffset_24268:X4} at 100D:9DDA");
    label_100D_9DDF_19EAF_24269:
        CheckExternalEvents(cs1, 0x9DDF);
        // 100D:9DDF pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9DE0 pop SI
        SI = Stack.Pop16();
        // 100D:9DE1 jmp short 0x9D94
        goto label_100D_9D94_19E64_24239;
    }

    public virtual Action unknown_100D_9EF1_19FC1(int loadOffset)
    {
    entrydispatcher:
    label_100D_9EF1_19FC1_16228:
        CheckExternalEvents(cs1, 0x9EF1);
        // 100D:9EF1 mov byte ptr DS:[0x47DC],AL
        UInt8[DS, (ushort)0x47DC] = AL;
        // 100D:9EF4 call near 0x9EFD
        NearCall(cs1, 0x9EF7, unknown_100D_9EFD_19FCD);
    label_100D_9EF7_19FC7_16230:
        CheckExternalEvents(cs1, 0x9EF7);
        // 100D:9EF7 mov byte ptr DS:[0x47DC],0
        UInt8[DS, (ushort)0x47DC] = (byte)0x00;
        // 100D:9EFC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9EFD_19FCD(int loadOffset)
    {
    entrydispatcher:
    label_100D_9EFD_19FCD_8375:
        CheckExternalEvents(cs1, 0x9EFD);
        // 100D:9EFD mov AL,byte ptr DS:[0x47DC]
        AL = UInt8[DS, (ushort)0x47DC];
        // 100D:9F00 mov byte ptr DS:[0x47DD],AL
        UInt8[DS, (ushort)0x47DD] = AL;
        // 100D:9F03 mov AX,word ptr DS:[0x4780]
        AX = UInt16[DS, (ushort)0x4780];
        // 100D:9F06 mov BX,word ptr DS:[0x47C4]
        BX = UInt16[DS, (ushort)0x47C4];
        // 100D:9F0A call near 0xA6CC
        NearCall(cs1, 0x9F0D, unknown_100D_A6CC_1A79C);
    label_100D_9F0D_19FDD_8638:
        CheckExternalEvents(cs1, 0x9F0D);
        // 100D:9F0D jae short 0x9EFC
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:9F0D");
        }
    label_100D_9F0F_19FDF_8640:
        CheckExternalEvents(cs1, 0x9F0F);
        // 100D:9F0F cmp word ptr DS:[0x47C4],0x0010
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:9F14 jae short 0x9F19
        if (!CarryFlag)
        {
            goto label_100D_9F19_19FE9_8692;
        }
    label_100D_9F16_19FE6_8643:
        CheckExternalEvents(cs1, 0x9F16);
        // 100D:9F16 call near 0x9F1C
        NearCall(cs1, 0x9F19, unknown_100D_9F1C_19FEC);
    label_100D_9F19_19FE9_8692:
        CheckExternalEvents(cs1, 0x9F19);
        // 100D:9F19 jmp near 0xA75C
        if (JumpDispatcher.Jump(unknown_100D_A75C_1A82C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9F1C_19FEC(int loadOffset)
    {
    label_100D_9F1C_19FEC_8645:
        CheckExternalEvents(cs1, 0x9F1C);
        // 100D:9F1C call near 0x9197
        NearCall(cs1, 0x9F1F, unknown_100D_9197_19267);
    label_100D_9F1F_19FEF_8647:
        CheckExternalEvents(cs1, 0x9F1F);
        // 100D:9F1F or byte ptr DS:[0x47D1],0x10
        UInt8[DS, (ushort)0x47D1] = Alu8.Or(UInt8[DS, (ushort)0x47D1], (byte)0x10);
        // 100D:9F24 call near 0x9A7B
        NearCall(cs1, 0x9F27, unknown_100D_9A7B_19B4B);
    label_100D_9F27_19FF7_8670:
        CheckExternalEvents(cs1, 0x9F27);
        // 100D:9F27 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9F29 call near 0x9A60
        NearCall(cs1, 0x9F2C, unknown_100D_9A60_19B30);
    label_100D_9F2C_19FFC_8689:
        CheckExternalEvents(cs1, 0x9F2C);
        // 100D:9F2C mov word ptr DS:[0x47C6],SI
        UInt16[DS, (ushort)0x47C6] = SI;
        // 100D:9F30 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9F31_1A001(int loadOffset)
    {
    entrydispatcher:
    label_100D_9F31_1A001_16177:
        CheckExternalEvents(cs1, 0x9F31);
        // 100D:9F31 mov SI,word ptr DS:[0x47BE]
        SI = UInt16[DS, (ushort)0x47BE];
        // 100D:9F35 and SI,-8
        SI = Alu16.And(SI, unchecked((ushort)unchecked((short)(sbyte)-8)));
        // 100D:9F38 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:9F3A shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:9F3C mov SI,word ptr DS:[SI-21898]
        SI = UInt16[DS, (ushort)(SI + (short)-21898)];
        if (JumpDispatcher.Jump(unknown_100D_9F40_1A010, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9F40_1A010(int loadOffset)
    {
    entrydispatcher:
    label_100D_9F40_1A010_15583:
        CheckExternalEvents(cs1, 0x9F40);
        // 100D:9F40 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:9F43 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:9F46 jne short 0x9F56
        if (!ZeroFlag)
        {
            goto label_100D_9F56_1A026_15587;
        }
    label_100D_9F48_1A018_33280:
        CheckExternalEvents(cs1, 0x9F48);
        // 100D:9F48 cmp byte ptr DS:[0x00C2],4
        Alu8.Sub(UInt8[DS, (ushort)0x00C2], (byte)0x04);
        // 100D:9F4D jne short 0x9F56
        if (!ZeroFlag)
        {
            goto label_100D_9F56_1A026_15587;
        }
    label_100D_9F4F_1A01F_41082:
        CheckExternalEvents(cs1, 0x9F4F);
        // 100D:9F4F push AX
        Stack.Push16(AX);
        // 100D:9F50 push SI
        Stack.Push16(SI);
        // 100D:9F51 call near 0x1243
        NearCall(cs1, 0x9F54, unknown_100D_1243_11313);
    label_100D_9F54_1A024_41148:
        CheckExternalEvents(cs1, 0x9F54);
        // 100D:9F54 pop SI
        SI = Stack.Pop16();
        // 100D:9F55 pop AX
        AX = Stack.Pop16();
    label_100D_9F56_1A026_15587:
        CheckExternalEvents(cs1, 0x9F56);
        // 100D:9F56 mov CL,0x10
        CL = (byte)0x10;
        // 100D:9F58 mul CL
        ushort result_100D_9F58_1A028 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_9F58_1A028 >> 8));
        AL = unchecked((byte)result_100D_9F58_1A028);
        // 100D:9F5A add AX,0x0FD8
        AX = Alu16.Add(AX, (ushort)0x0FD8);
        // 100D:9F5D mov word ptr DS:[0x47A2],AX
        UInt16[DS, (ushort)0x47A2] = AX;
        // 100D:9F60 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:9F65 jne short 0x9F82
        if (!ZeroFlag)
        {
            return unknown_100D_9F82_1A052(0x0000);
        }
    label_100D_9F67_1A037_15594:
        CheckExternalEvents(cs1, 0x9F67);
        // 100D:9F67 call near 0xC07C
        NearCall(cs1, 0x9F6A, unknown_100D_C07C_1C14C);
    label_100D_9F6A_1A03A_15596:
        CheckExternalEvents(cs1, 0x9F6A);
        // 100D:9F6A mov word ptr DS:[0x4784],0x0028
        UInt16[DS, (ushort)0x4784] = (ushort)0x0028;
        // 100D:9F70 mov word ptr DS:[0x4786],0x0010
        UInt16[DS, (ushort)0x4786] = (ushort)0x0010;
        // 100D:9F76 mov word ptr DS:[0x4788],0x0010
        UInt16[DS, (ushort)0x4788] = (ushort)0x0010;
        // 100D:9F7C mov word ptr DS:[0x478A],0x0010
        UInt16[DS, (ushort)0x478A] = (ushort)0x0010;
        return unknown_100D_9F82_1A052(0x0000);
    }

    public virtual Action unknown_100D_9F82_1A052(int loadOffset)
    {
    label_100D_9F82_1A052_15601:
        CheckExternalEvents(cs1, 0x9F82);
        // 100D:9F82 mov word ptr DS:[0xDBE4],0x00F0
        UInt16[DS, (ushort)0xDBE4] = (ushort)0x00F0;
        // 100D:9F88 jmp near 0xD068
        return unknown_100D_D068_1D138(0x0000);
    }

    public virtual Action unknown_100D_9F8B_1A05B(int loadOffset)
    {
    entrydispatcher:
    label_100D_9F8B_1A05B_16185:
        CheckExternalEvents(cs1, 0x9F8B);
        // 100D:9F8B push word ptr DS:[0x47C2]
        Stack.Push16(UInt16[DS, (ushort)0x47C2]);
        // 100D:9F8F mov byte ptr DS:[0x47C2],0x20
        UInt8[DS, (ushort)0x47C2] = (byte)0x20;
        // 100D:9F94 call near 0x9F9E
        NearCall(cs1, 0x9F97, unknown_100D_9F9E_1A06E);
    label_100D_9F97_1A067_16202:
        CheckExternalEvents(cs1, 0x9F97);
        // 100D:9F97 pop word ptr DS:[0x47C2]
        ushort popStackCheck_100D_9F97_1A067 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_9F97_1A067 = UInt16[DS, (ushort)0x47C2];
        ushort poppedValue_100D_9F97_1A067 = Stack.Pop16();
        UInt16[DS, (ushort)0x47C2] = unchecked((ushort)poppedValue_100D_9F97_1A067);
        // 100D:9F9B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9F9E_1A06E(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_9F9E_1A06E_3154;

    label_100D_9F9C_1A06C_15653:
        CheckExternalEvents(cs1, 0x9F9C);
        // 100D:9F9C stc
        CarryFlag = true;
        // 100D:9F9D ret near
        return NearRet((ushort)0x0000);
    label_100D_9F9E_1A06E_3154:
        CheckExternalEvents(cs1, 0x9F9E);
        // 100D:9F9E mov word ptr DS:[0x477C],SI
        UInt16[DS, (ushort)0x477C] = SI;
        // 100D:9FA2 call near 0x94F3
        NearCall(cs1, 0x9FA5, unknown_100D_94F3_195C3);
    label_100D_9FA5_1A075_3162:
        CheckExternalEvents(cs1, 0x9FA5);
        // 100D:9FA5 mov word ptr DS:[0x47BC],0xA6B0
        UInt16[DS, (ushort)0x47BC] = (ushort)0xA6B0;
    label_100D_9FAB_1A07B_3164:
        CheckExternalEvents(cs1, 0x9FAB);
        // 100D:9FAB mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:9FAD cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:9FB0 je short 0x9F9C
        if (ZeroFlag)
        {
            goto label_100D_9F9C_1A06C_15653;
        }
    label_100D_9FB2_1A082_3167:
        CheckExternalEvents(cs1, 0x9FB2);
        // 100D:9FB2 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:9FB4 je short 0x9FC0
        if (ZeroFlag)
        {
            goto label_100D_9FC0_1A090_3170;
        }
    label_100D_9FB6_1A086_3304:
        CheckExternalEvents(cs1, 0x9FB6);
        // 100D:9FB6 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:9FB8 jne short 0x9FC0
        if (!ZeroFlag)
        {
            goto label_100D_9FC0_1A090_3170;
        }
    label_100D_9FBA_1A08A_3307:
        CheckExternalEvents(cs1, 0x9FBA);
        // 100D:9FBA and AL,byte ptr DS:[0x47C2]
        AL = Alu8.And(AL, UInt8[DS, (ushort)0x47C2]);
        // 100D:9FBE jne short 0x9FD3
        if (!ZeroFlag)
        {
            goto label_100D_9FD3_1A0A3_3310;
        }
    label_100D_9FC0_1A090_3170:
        CheckExternalEvents(cs1, 0x9FC0);
        // 100D:9FC0 push SI
        Stack.Push16(SI);
        // 100D:9FC1 mov AL,AH
        AL = AH;
        // 100D:9FC3 mov AH,byte ptr DS:[SI+2]
        AH = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:9FC6 rol AH,1
        AH = Alu8.Rol(AH, unchecked((byte)1));
        // 100D:9FC8 rol AH,1
        AH = Alu8.Rol(AH, unchecked((byte)1));
        // 100D:9FCA and AH,3
        AH = Alu8.And(AH, (byte)0x03);
        // 100D:9FCD call near 0xA396
        NearCall(cs1, 0x9FD0, unknown_100D_A396_1A466);
    label_100D_9FD0_1A0A0_3215:
        CheckExternalEvents(cs1, 0x9FD0);
        // 100D:9FD0 pop SI
        SI = Stack.Pop16();
        // 100D:9FD1 jne short 0x9FD8
        if (!ZeroFlag)
        {
            goto label_100D_9FD8_1A0A8_3218;
        }
    label_100D_9FD3_1A0A3_3310:
        CheckExternalEvents(cs1, 0x9FD3);
        // 100D:9FD3 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:9FD6 jmp short 0x9FAB
        goto label_100D_9FAB_1A07B_3164;
    label_100D_9FD8_1A0A8_3218:
        CheckExternalEvents(cs1, 0x9FD8);
        // 100D:9FD8 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:9FDD jne short 0x9FF7
        if (!ZeroFlag)
        {
            goto label_100D_9FF7_1A0C7_3225;
        }
    label_100D_9FDF_1A0AF_3221:
        CheckExternalEvents(cs1, 0x9FDF);
        // 100D:9FDF mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:9FE2 cmp AX,0x0010
        Alu16.Sub(AX, (ushort)0x0010);
        // 100D:9FE5 jae short 0x9FF7
        if (!CarryFlag)
        {
            goto label_100D_9FF7_1A0C7_3225;
        }
    label_100D_9FE7_1A0B7_15667:
        CheckExternalEvents(cs1, 0x9FE7);
        // 100D:9FE7 push SI
        Stack.Push16(SI);
        // 100D:9FE8 push AX
        Stack.Push16(AX);
        // 100D:9FE9 call near 0xA0F1
        NearCall(cs1, 0x9FEC, unknown_100D_A0F1_1A1C1);
    label_100D_9FEC_1A0BC_15679:
        CheckExternalEvents(cs1, 0x9FEC);
        // 100D:9FEC call near 0x1803
        NearCall(cs1, 0x9FEF, unknown_100D_1803_118D3);
    label_100D_9FEF_1A0BF_15684:
        CheckExternalEvents(cs1, 0x9FEF);
        // 100D:9FEF call near 0x3AF9
        NearCall(cs1, 0x9FF2, unknown_100D_3AF9_13BC9);
    label_100D_9FF2_1A0C2_15688:
        CheckExternalEvents(cs1, 0x9FF2);
        // 100D:9FF2 pop AX
        AX = Stack.Pop16();
        // 100D:9FF3 call near 0x91A0
        NearCall(cs1, 0x9FF6, unknown_100D_91A0_19270);
    label_100D_9FF6_1A0C6_15691:
        CheckExternalEvents(cs1, 0x9FF6);
        // 100D:9FF6 pop SI
        SI = Stack.Pop16();
    label_100D_9FF7_1A0C7_3225:
        CheckExternalEvents(cs1, 0x9FF7);
        // 100D:9FF7 push SI
        Stack.Push16(SI);
        // 100D:9FF8 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9FF9 mov word ptr DS:[0x47DE],AX
        UInt16[DS, (ushort)0x47DE] = AX;
        // 100D:9FFC lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9FFD xchg AH,AL
        byte temp_100D_9FFD_1A0CD = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_9FFD_1A0CD);
        // 100D:9FFF and AX,0x03FF
        AX = Alu16.And(AX, (ushort)0x03FF);
        // 100D:A002 or AX,0x0800
        AX = Alu16.Or(AX, (ushort)0x0800);
        // 100D:A005 mov DI,word ptr DS:[0x47BC]
        DI = UInt16[DS, (ushort)0x47BC];
        // 100D:A009 cmp DI,0xA6B0
        Alu16.Sub(DI, (ushort)0xA6B0);
        // 100D:A00D je short 0xA034
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A00D");
        }
    label_100D_A034_1A104_3236:
        CheckExternalEvents(cs1, 0xA034);
        // 100D:A034 cmp byte ptr DS:[0x00C6],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C6], (byte)0x00);
        // 100D:A039 jne short 0xA03E
        if (!ZeroFlag)
        {
            goto label_100D_A03E_1A10E_3239;
        }
    label_100D_A03B_1A10B_15693:
        CheckExternalEvents(cs1, 0xA03B);
        // 100D:A03B call near 0x88AF
        NearCall(cs1, 0xA03E, unknown_100D_88AF_1897F);
    label_100D_A03E_1A10E_3239:
        CheckExternalEvents(cs1, 0xA03E);
        // 100D:A03E pop SI
        SI = Stack.Pop16();
        if (JumpDispatcher.Jump(unknown_100D_A03F_1A10F, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A03F_1A10F(int loadOffset)
    {
    entrydispatcher:
    label_100D_A03F_1A10F_3241:
        CheckExternalEvents(cs1, 0xA03F);
        // 100D:A03F call near 0xC85B
        NearCall(cs1, 0xA042, unknown_100D_C85B_1C92B);
    label_100D_A042_1A112_3247:
        CheckExternalEvents(cs1, 0xA042);
        // 100D:A042 cmp word ptr DS:[0x47B6],0
        Alu16.Sub(UInt16[DS, (ushort)0x47B6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A047 jne short 0xA0AA
        if (!ZeroFlag)
        {
            goto label_100D_A0AA_1A17A_3282;
        }
    label_100D_A049_1A119_3250:
        CheckExternalEvents(cs1, 0xA049);
        // 100D:A049 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:A04B and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:A04D je short 0xA05E
        if (ZeroFlag)
        {
            goto label_100D_A05E_1A12E_3254;
        }
    label_100D_A04F_1A11F_16189:
        CheckExternalEvents(cs1, 0xA04F);
        // 100D:A04F xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:A051 push SI
        Stack.Push16(SI);
        // 100D:A052 dec AX
        AX = Alu16.Dec(AX);
        // 100D:A053 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A055 mov BX,0xA107
        BX = (ushort)0xA107;
        // 100D:A058 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:A05A call near word ptr CS:[BX]
        switch ((ushort)(UInt16[CS, BX]))
        {
            case 0xA125:
                NearCall(cs1, 0xA05D, unknown_100D_A125_1A1F5);
                break;
            case 0xA157:
                NearCall(cs1, 0xA05D, unknown_100D_A157_1A227);
                break;
            case 0xA172:
                NearCall(cs1, 0xA05D, unknown_100D_A172_1A242);
                break;
            case 0xA1D0:
                NearCall(cs1, 0xA05D, unknown_100D_A1D0_1A2A0);
                break;
            case 0xA1D6:
                NearCall(cs1, 0xA05D, unknown_100D_A1D6_1A2A6);
                break;
            case 0xA1DC:
                NearCall(cs1, 0xA05D, unknown_100D_A1DC_1A2AC);
                break;
            case 0xA1E8:
                NearCall(cs1, 0xA05D, unknown_100D_A1E8_1A2B8);
                break;
            case 0xA1ED:
                NearCall(cs1, 0xA05D, unknown_100D_A1ED_1A2BD);
                break;
            case 0xA1F7:
                NearCall(cs1, 0xA05D, unknown_100D_A1F7_1A2C7);
                break;
            case 0xA219:
                NearCall(cs1, 0xA05D, unknown_100D_A219_1A2E9);
                break;
            case 0xA235:
                NearCall(cs1, 0xA05D, unknown_100D_A235_1A305);
                break;
            case 0xA244:
                NearCall(cs1, 0xA05D, unknown_100D_A244_1A314);
                break;
            case 0xA248:
                NearCall(cs1, 0xA05D, unknown_100D_A248_1A318);
                break;
            case 0xA25B:
                NearCall(cs1, 0xA05D, unknown_100D_A25B_1A32B);
                break;
            case 0xA28E:
                NearCall(cs1, 0xA05D, unknown_100D_A28E_1A35E);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, BX])):X4} at 100D:A05A");
        }
    label_100D_A05D_1A12D_16200:
        CheckExternalEvents(cs1, 0xA05D);
        // 100D:A05D pop SI
        SI = Stack.Pop16();
    label_100D_A05E_1A12E_3254:
        CheckExternalEvents(cs1, 0xA05E);
        // 100D:A05E mov AL,byte ptr DS:[SI+2]
        AL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:A061 and AL,0x0C
        AL = Alu8.And(AL, (byte)0x0C);
        // 100D:A063 je short 0xA092
        if (ZeroFlag)
        {
            goto label_100D_A092_1A162_3275;
        }
    label_100D_A065_1A135_3258:
        CheckExternalEvents(cs1, 0xA065);
        // 100D:A065 test byte ptr DS:[SI],0x80
        Alu8.And(UInt8[DS, SI], (byte)0x80);
        // 100D:A068 jne short 0xA092
        if (!ZeroFlag)
        {
            goto label_100D_A092_1A162_3275;
        }
    label_100D_A06A_1A13A_3261:
        CheckExternalEvents(cs1, 0xA06A);
        // 100D:A06A mov AX,SI
        AX = SI;
        // 100D:A06C sub AX,0xAA78
        AX = Alu16.Sub(AX, (ushort)0xAA78);
        // 100D:A06F shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:A071 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:A073 mov BL,byte ptr DS:[0x47C4]
        BL = UInt8[DS, (ushort)0x47C4];
        // 100D:A077 shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:A079 shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:A07B shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:A07D or AH,BL
        AH = Alu8.Or(AH, BL);
        // 100D:A07F mov BP,word ptr DS:[0x11BD]
        BP = UInt16[DS, (ushort)0x11BD];
        // 100D:A083 mov word ptr CS:[BP],AX
        UInt16[CS, (ushort)(BP + (sbyte)0)] = AX;
        // 100D:A087 mov word ptr CS:[BP+2],0
        UInt16[CS, (ushort)(BP + (sbyte)2)] = (ushort)0x0000;
        // 100D:A08D add word ptr DS:[0x11BD],2
        UInt16[DS, (ushort)0x11BD] = Alu16.Add(UInt16[DS, (ushort)0x11BD], unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_A092_1A162_3275:
        CheckExternalEvents(cs1, 0xA092);
        // 100D:A092 mov byte ptr DS:[0x0019],0xFF
        UInt8[DS, (ushort)0x0019] = (byte)0xFF;
        // 100D:A097 or byte ptr DS:[SI],0x80
        UInt8[DS, SI] = Alu8.Or(UInt8[DS, SI], (byte)0x80);
        // 100D:A09A add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:A09D xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:A09F xchg AL,byte ptr DS:[0x47A8]
        ushort xchgOffset_100D_A09F_1A16F = (ushort)0x47A8;
        byte temp_100D_A09F_1A16F = AL;
        AL = UInt8[DS, xchgOffset_100D_A09F_1A16F];
        UInt8[DS, xchgOffset_100D_A09F_1A16F] = unchecked((byte)temp_100D_A09F_1A16F);
        // 100D:A0A3 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:A0A5 je short 0xA0AA
        if (ZeroFlag)
        {
            goto label_100D_A0AA_1A17A_3282;
        }
    label_100D_A0A7_1A177_20443:
        CheckExternalEvents(cs1, 0xA0A7);
        // 100D:A0A7 mov SI,0xFFFF
        SI = (ushort)0xFFFF;
    label_100D_A0AA_1A17A_3282:
        CheckExternalEvents(cs1, 0xA0AA);
        // 100D:A0AA cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:A0AF jne short 0xA0E2
        if (!ZeroFlag)
        {
            goto label_100D_A0E2_1A1B2_3288;
        }
    label_100D_A0B1_1A181_3285:
        CheckExternalEvents(cs1, 0xA0B1);
        // 100D:A0B1 cmp word ptr DS:[0x47C4],0x0010
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:A0B6 jae short 0xA0E2
        if (!CarryFlag)
        {
            goto label_100D_A0E2_1A1B2_3288;
        }
    label_100D_A0B8_1A188_15734:
        CheckExternalEvents(cs1, 0xA0B8);
        // 100D:A0B8 push SI
        Stack.Push16(SI);
        // 100D:A0B9 call near 0x978E
        NearCall(cs1, 0xA0BC, unknown_100D_978E_1985E);
    label_100D_A0BC_1A18C_15749:
        CheckExternalEvents(cs1, 0xA0BC);
        // 100D:A0BC pop SI
        SI = Stack.Pop16();
        // 100D:A0BD cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:A0C2 je short 0xA0C9
        if (ZeroFlag)
        {
            goto label_100D_A0C9_1A199_15753;
        }
    label_100D_A0C4_1A194_30354:
        CheckExternalEvents(cs1, 0xA0C4);
        // 100D:A0C4 push SI
        Stack.Push16(SI);
        // 100D:A0C5 call near 0x2EBF
        NearCall(cs1, 0xA0C8, unknown_100D_2EBF_12F8F);
    label_100D_A0C8_1A198_30357:
        CheckExternalEvents(cs1, 0xA0C8);
        // 100D:A0C8 pop SI
        SI = Stack.Pop16();
    label_100D_A0C9_1A199_15753:
        CheckExternalEvents(cs1, 0xA0C9);
        // 100D:A0C9 cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:A0CE jg short 0xA0E2
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_A0E2_1A1B2_3288;
        }
    label_100D_A0D0_1A1A0_15756:
        CheckExternalEvents(cs1, 0xA0D0);
        // 100D:A0D0 call near 0xE270
        NearCall(cs1, 0xA0D3, unknown_100D_E270_1E340);
    label_100D_A0D3_1A1A3_15758:
        CheckExternalEvents(cs1, 0xA0D3);
        // 100D:A0D3 call near 0x9EFD
        NearCall(cs1, 0xA0D6, unknown_100D_9EFD_19FCD);
    label_100D_A0D6_1A1A6_15774:
        CheckExternalEvents(cs1, 0xA0D6);
        // 100D:A0D6 mov AX,0x0F66
        AX = (ushort)0x0F66;
        // 100D:A0D9 xchg AX,word ptr DS:[0x227E]
        ushort xchgOffset_100D_A0D9_1A1A9 = (ushort)0x227E;
        ushort temp_100D_A0D9_1A1A9 = AX;
        AX = UInt16[DS, xchgOffset_100D_A0D9_1A1A9];
        UInt16[DS, xchgOffset_100D_A0D9_1A1A9] = unchecked((ushort)temp_100D_A0D9_1A1A9);
        // 100D:A0DD call near AX
        switch ((ushort)(AX))
        {
            case 0x0F66:
                NearCall(cs1, 0xA0DF, unknown_100D_0F66_11036);
                break;
            case 0x2CCF:
                NearCall(cs1, 0xA0DF, unknown_100D_2CCF_12D9F);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(AX)):X4} at 100D:A0DD");
        }
    label_100D_A0DF_1A1AF_15778:
        CheckExternalEvents(cs1, 0xA0DF);
        // 100D:A0DF call near 0xE283
        NearCall(cs1, 0xA0E2, unknown_100D_E283_1E353);
    label_100D_A0E2_1A1B2_3288:
        CheckExternalEvents(cs1, 0xA0E2);
        // 100D:A0E2 cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:A0E7 js short 0xA0EF
        if (SignFlag)
        {
            goto label_100D_A0EF_1A1BF_3291;
        }
    label_100D_A0E9_1A1B9_15780:
        CheckExternalEvents(cs1, 0xA0E9);
        // 100D:A0E9 mov AL,byte ptr DS:[0x28E8]
        AL = UInt8[DS, (ushort)0x28E8];
        // 100D:A0EC mov byte ptr DS:[0x28E7],AL
        UInt8[DS, (ushort)0x28E7] = AL;
    label_100D_A0EF_1A1BF_3291:
        CheckExternalEvents(cs1, 0xA0EF);
        // 100D:A0EF clc
        CarryFlag = false;
        // 100D:A0F0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A0F1_1A1C1(int loadOffset)
    {
    entrydispatcher:
    label_100D_A0F1_1A1C1_15671:
        CheckExternalEvents(cs1, 0xA0F1);
        // 100D:A0F1 cmp byte ptr DS:[0x28E7],2
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x02);
        // 100D:A0F6 jne short 0xA103
        if (!ZeroFlag)
        {
            goto label_100D_A103_1A1D3_25838;
        }
    label_100D_A0F8_1A1C8_15674:
        CheckExternalEvents(cs1, 0xA0F8);
        // 100D:A0F8 test byte ptr DS:[SI+2],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x10);
        // 100D:A0FC je short 0xA104
        if (ZeroFlag)
        {
            goto label_100D_A104_1A1D4_15677;
        }
    label_100D_A0FE_1A1CE_33424:
        CheckExternalEvents(cs1, 0xA0FE);
        // 100D:A0FE mov byte ptr DS:[0x28E7],1
        UInt8[DS, (ushort)0x28E7] = (byte)0x01;
    label_100D_A103_1A1D3_25838:
        CheckExternalEvents(cs1, 0xA103);
        // 100D:A103 ret near
        return NearRet((ushort)0x0000);
    label_100D_A104_1A1D4_15677:
        CheckExternalEvents(cs1, 0xA104);
        // 100D:A104 jmp near 0x8C8A
        if (JumpDispatcher.Jump(unknown_100D_8C8A_18D5A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A125_1A1F5(int loadOffset)
    {
        goto label_100D_A125_1A1F5_32854;

    label_100D_2239_12309_32919:
        CheckExternalEvents(cs1, 0x2239);
        // 100D:2239 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:223B mov byte ptr DS:[0x009F],AL
        UInt8[DS, (ushort)0x009F] = AL;
        // 100D:223E mov word ptr DS:[0x0020],AX
        UInt16[DS, (ushort)0x0020] = AX;
        // 100D:2241 mov byte ptr DS:[0x001A],AL
        UInt8[DS, (ushort)0x001A] = AL;
        // 100D:2244 mov AX,word ptr DS:[0x00A0]
        AX = UInt16[DS, (ushort)0x00A0];
        // 100D:2247 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:2249 je short 0x2250
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:2249");
        }
    label_100D_224B_1231B_32927:
        CheckExternalEvents(cs1, 0x224B);
        // 100D:224B mov byte ptr DS:[0x009F],3
        UInt8[DS, (ushort)0x009F] = (byte)0x03;
        // 100D:2250 call near 0x22B1
        NearCall(cs1, 0x2253, unknown_100D_22B1_12381);
    label_100D_2253_12323_32960:
        CheckExternalEvents(cs1, 0x2253);
        // 100D:2253 mov SI,0x10D8
        SI = (ushort)0x10D8;
        // 100D:2256 call near 0x1AC5
        NearCall(cs1, 0x2259, unknown_100D_1AC5_11B95);
    label_100D_2259_12329_32963:
        CheckExternalEvents(cs1, 0x2259);
        // 100D:2259 xor DL,DL
        DL = Alu8.Xor(DL, DL);
    label_100D_225B_1232B_32965:
        CheckExternalEvents(cs1, 0x225B);
        // 100D:225B cmp word ptr DS:[SI+0x0E],0
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)14)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:225F je short 0x2274
        if (ZeroFlag)
        {
            goto label_100D_2274_12344_32967;
        }
    label_100D_2261_12331_34798:
        CheckExternalEvents(cs1, 0x2261);
        // 100D:2261 test byte ptr DS:[SI+2],0x60
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x60);
        // 100D:2265 jne short 0x2274
        if (!ZeroFlag)
        {
            goto label_100D_2274_12344_32967;
        }
    label_100D_2267_12337_34801:
        CheckExternalEvents(cs1, 0x2267);
        // 100D:2267 mov AH,AL
        AH = AL;
        // 100D:2269 sub AH,byte ptr DS:[SI+0x10]
        AH = Alu8.Sub(AH, UInt8[DS, (ushort)(SI + (sbyte)16)]);
        // 100D:226C cmp AH,DL
        Alu8.Sub(AH, DL);
        // 100D:226E jbe short 0x2274
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_2274_12344_32967;
        }
    label_100D_2270_12340_34806:
        CheckExternalEvents(cs1, 0x2270);
        // 100D:2270 mov DL,AH
        DL = AH;
        // 100D:2272 mov DI,SI
        DI = SI;
    label_100D_2274_12344_32967:
        CheckExternalEvents(cs1, 0x2274);
        // 100D:2274 add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:2277 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:227A jne short 0x225B
        if (!ZeroFlag)
        {
            goto label_100D_225B_1232B_32965;
        }
    label_100D_227C_1234C_32972:
        CheckExternalEvents(cs1, 0x227C);
        // 100D:227C or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:227E mov SI,DI
        SI = DI;
        // 100D:2280 jne short 0x22A3
        if (!ZeroFlag)
        {
            goto label_100D_22A3_12373_34809;
        }
    label_100D_2282_12352_32976:
        CheckExternalEvents(cs1, 0x2282);
        // 100D:2282 mov SI,word ptr DS:[0x113F]
        SI = UInt16[DS, (ushort)0x113F];
        // 100D:2286 jmp short 0x228E
        goto label_100D_228E_1235E_32979;
    label_100D_2288_12358_32986:
        CheckExternalEvents(cs1, 0x2288);
        // 100D:2288 cmp SI,word ptr DS:[0x113F]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x113F]);
        // 100D:228C je short 0x22B0
        if (ZeroFlag)
        {
            goto label_100D_22B0_12380_32991;
        }
    label_100D_228E_1235E_32979:
        CheckExternalEvents(cs1, 0x228E);
        // 100D:228E add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:2291 cmp byte ptr DS:[SI],0xFF
        Alu8.Sub(UInt8[DS, SI], (byte)0xFF);
        // 100D:2294 jne short 0x2299
        if (!ZeroFlag)
        {
            goto label_100D_2299_12369_32983;
        }
    label_100D_2296_12366_32989:
        CheckExternalEvents(cs1, 0x2296);
        // 100D:2296 mov SI,0x10D8
        SI = (ushort)0x10D8;
    label_100D_2299_12369_32983:
        CheckExternalEvents(cs1, 0x2299);
        // 100D:2299 cmp word ptr DS:[SI+0x0E],0
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)14)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:229D je short 0x2288
        if (ZeroFlag)
        {
            goto label_100D_2288_12358_32986;
        }
    label_100D_229F_1236F_38036:
        CheckExternalEvents(cs1, 0x229F);
        // 100D:229F mov word ptr DS:[0x113F],SI
        UInt16[DS, (ushort)0x113F] = SI;
    label_100D_22A3_12373_34809:
        CheckExternalEvents(cs1, 0x22A3);
        // 100D:22A3 call near 0x235F
        NearCall(cs1, 0x22A6, unknown_100D_235F_1242F);
    label_100D_22A6_12376_34811:
        CheckExternalEvents(cs1, 0x22A6);
        // 100D:22A6 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:22A8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:22AA add AX,0
        AX = Alu16.Add(AX, (ushort)0x0000);
        // 100D:22AD mov word ptr DS:[0x11F7],AX
        UInt16[DS, (ushort)0x11F7] = AX;
    label_100D_22B0_12380_32991:
        CheckExternalEvents(cs1, 0x22B0);
        // 100D:22B0 ret near
        return NearRet((ushort)0x0000);
    label_100D_2388_12458_33917:
        CheckExternalEvents(cs1, 0x2388);
        // 100D:2388 mov AL,0x3C
        AL = (byte)0x3C;
        // 100D:238A call near 0x121F
        NearCall(cs1, 0x238D, unknown_100D_121F_112EF);
    label_100D_238D_1245D_33920:
        CheckExternalEvents(cs1, 0x238D);
        // 100D:238D mov BX,3
        BX = (ushort)0x0003;
        // 100D:2390 call near 0xE3B7
        NearCall(cs1, 0x2393, unknown_100D_E3B7_1E487);
    label_100D_2393_12463_33923:
        CheckExternalEvents(cs1, 0x2393);
        // 100D:2393 mov byte ptr DS:[0x009E],AL
        UInt8[DS, (ushort)0x009E] = AL;
        // 100D:2396 call near 0x1AC5
        NearCall(cs1, 0x2399, unknown_100D_1AC5_11B95);
    label_100D_2399_12469_33926:
        CheckExternalEvents(cs1, 0x2399);
        // 100D:2399 mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:239D mov byte ptr DS:[DI+3],AL
        UInt8[DS, (ushort)(DI + (sbyte)3)] = AL;
        // 100D:23A0 mov byte ptr DS:[0x001A],0
        UInt8[DS, (ushort)0x001A] = (byte)0x00;
        // 100D:23A5 mov AX,word ptr DS:[0x11F1]
        AX = UInt16[DS, (ushort)0x11F1];
        // 100D:23A8 sub AX,0x00E8
        AX = Alu16.Sub(AX, (ushort)0x00E8);
        // 100D:23AB mov CX,2
        CX = (ushort)0x0002;
    label_100D_23AE_1247E_33933:
        CheckExternalEvents(cs1, 0x23AE);
        // 100D:23AE inc AX
        AX = Alu16.Inc(AX);
    label_100D_23AF_1247F_33934:
        CheckExternalEvents(cs1, 0x23AF);
        // 100D:23AF cmp AL,byte ptr DS:[0x1141]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1141]);
        // 100D:23B3 jb short 0x23BC
        if (CarryFlag)
        {
            goto label_100D_23BC_1248C_33936;
        }
    label_100D_23B5_12485_33941:
        CheckExternalEvents(cs1, 0x23B5);
        // 100D:23B5 sub AL,byte ptr DS:[0x1141]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x1141]);
        // 100D:23B9 loop 0x23AF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_23AF_1247F_33934;
        }
    label_100D_23BB_1248B_34062:
        CheckExternalEvents(cs1, 0x23BB);
        // 100D:23BB ret near
        return NearRet((ushort)0x0000);
    label_100D_23BC_1248C_33936:
        CheckExternalEvents(cs1, 0x23BC);
        // 100D:23BC mov BX,AX
        BX = AX;
        // 100D:23BE cmp byte ptr DS:[BX+DI+4],0
        Alu8.Sub(UInt8[DS, (ushort)(BX + DI + (sbyte)4)], (byte)0x00);
        // 100D:23C2 je short 0x23AE
        if (ZeroFlag)
        {
            goto label_100D_23AE_1247E_33933;
        }
    label_100D_23C4_12494_33945:
        CheckExternalEvents(cs1, 0x23C4);
        // 100D:23C4 add AX,0x00E8
        AX = Alu16.Add(AX, (ushort)0x00E8);
        // 100D:23C7 mov word ptr DS:[0x11F1],AX
        UInt16[DS, (ushort)0x11F1] = AX;
        // 100D:23CA mov AL,byte ptr DS:[BX+DI+9]
        AL = UInt8[DS, (ushort)(BX + DI + (sbyte)9)];
        // 100D:23CD and AL,0x7F
        AL = Alu8.And(AL, (byte)0x7F);
        // 100D:23CF shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:23D1 mov byte ptr DS:[0x009D],AL
        UInt8[DS, (ushort)0x009D] = AL;
        // 100D:23D4 ret near
        return NearRet((ushort)0x0000);
    label_100D_A125_1A1F5_32854:
        CheckExternalEvents(cs1, 0xA125);
        // 100D:A125 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:A128 cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:A12B je short 0xA186
        if (ZeroFlag)
        {
            goto label_100D_A186_1A256_32858;
        }
    label_100D_A12D_1A1FD_32914:
        CheckExternalEvents(cs1, 0xA12D);
        // 100D:A12D cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        // 100D:A130 jne short 0xA135
        if (!ZeroFlag)
        {
            goto label_100D_A135_1A205_33906;
        }
    label_100D_A132_1A202_32917:
        CheckExternalEvents(cs1, 0xA132);
        // 100D:A132 jmp near 0x2239
        goto label_100D_2239_12309_32919;
    label_100D_A135_1A205_33906:
        CheckExternalEvents(cs1, 0xA135);
        // 100D:A135 cmp AX,5
        Alu16.Sub(AX, (ushort)0x0005);
        // 100D:A138 jne short 0xA141
        if (!ZeroFlag)
        {
            goto label_100D_A141_1A211_33909;
        }
    label_100D_A13A_1A20A_35339:
        CheckExternalEvents(cs1, 0xA13A);
        // 100D:A13A mov word ptr DS:[0x227E],0x2CCF
        UInt16[DS, (ushort)0x227E] = (ushort)0x2CCF;
        // 100D:A140 ret near
        return NearRet((ushort)0x0000);
    label_100D_A141_1A211_33909:
        CheckExternalEvents(cs1, 0xA141);
        // 100D:A141 cmp AX,0x000C
        Alu16.Sub(AX, (ushort)0x000C);
        // 100D:A144 jne short 0xA14E
        if (!ZeroFlag)
        {
            goto label_100D_A14E_1A21E_33912;
        }
    label_100D_A146_1A216_40305:
        CheckExternalEvents(cs1, 0xA146);
        // 100D:A146 mov DI,word ptr DS:[0x11CE]
        DI = UInt16[DS, (ushort)0x11CE];
        // 100D:A14A and byte ptr DS:[DI+0x0A],0x7F
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x7F);
    label_100D_A14E_1A21E_33912:
        CheckExternalEvents(cs1, 0xA14E);
        // 100D:A14E cmp AX,0x000D
        Alu16.Sub(AX, (ushort)0x000D);
        // 100D:A151 jne short 0xA156
        if (!ZeroFlag)
        {
            return unknown_100D_A156_1A226(0x0000);
        }
    label_100D_A153_1A223_33915:
        CheckExternalEvents(cs1, 0xA153);
        // 100D:A153 jmp near 0x2388
        goto label_100D_2388_12458_33917;
    label_100D_A186_1A256_32858:
        CheckExternalEvents(cs1, 0xA186);
        // 100D:A186 test byte ptr DS:[0x000A],2
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x02);
        // 100D:A18B je short 0xA197
        if (ZeroFlag)
        {
            goto label_100D_A197_1A267_32861;
        }
    label_100D_A18D_1A25D_38054:
        CheckExternalEvents(cs1, 0xA18D);
        // 100D:A18D mov AL,0x28
        AL = (byte)0x28;
        // 100D:A18F call near 0x6F78
        NearCall(cs1, 0xA192, unknown_100D_6F78_17048);
    label_100D_A192_1A262_38059:
        CheckExternalEvents(cs1, 0xA192);
        // 100D:A192 mov AX,0xFFCE
        AX = (ushort)0xFFCE;
        // 100D:A195 jmp short 0xA1AA
        goto label_100D_A1AA_1A27A_32871;
    label_100D_A197_1A267_32861:
        CheckExternalEvents(cs1, 0xA197);
        // 100D:A197 mov AX,word ptr DS:[0x1176]
        AX = UInt16[DS, (ushort)0x1176];
        // 100D:A19A cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:A19D jne short 0xA1AA
        if (!ZeroFlag)
        {
            goto label_100D_A1AA_1A27A_32871;
        }
    label_100D_A19F_1A26F_32865:
        CheckExternalEvents(cs1, 0xA19F);
        // 100D:A19F add AX,0x000A
        AX = Alu16.Add(AX, (ushort)0x000A);
        // 100D:A1A2 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:A1A4 call near 0x6F78
        NearCall(cs1, 0xA1A7, unknown_100D_6F78_17048);
    label_100D_A1A7_1A277_32869:
        CheckExternalEvents(cs1, 0xA1A7);
        // 100D:A1A7 mov AX,0x000A
        AX = (ushort)0x000A;
    label_100D_A1AA_1A27A_32871:
        CheckExternalEvents(cs1, 0xA1AA);
        // 100D:A1AA add AX,0x0014
        AX = Alu16.Add(AX, (ushort)0x0014);
        // 100D:A1AD mov word ptr DS:[0x1176],AX
        UInt16[DS, (ushort)0x1176] = AX;
        // 100D:A1B0 xor BL,BL
        BL = Alu8.Xor(BL, BL);
        // 100D:A1B2 cmp AX,0x0064
        Alu16.Sub(AX, (ushort)0x0064);
        // 100D:A1B5 jae short 0xA1BF
        if (!CarryFlag)
        {
            goto label_100D_A1BF_1A28F_32881;
        }
    label_100D_A1B7_1A287_32876:
        CheckExternalEvents(cs1, 0xA1B7);
        // 100D:A1B7 mov BL,6
        BL = (byte)0x06;
        // 100D:A1B9 div BL
        byte divisor_100D_A1B9_1A289 = BL;
        ushort dividend_100D_A1B9_1A289 = AX;
        byte quotient_100D_A1B9_1A289 = Alu8.Div(unchecked((ushort)dividend_100D_A1B9_1A289), unchecked((byte)divisor_100D_A1B9_1A289));
        AL = unchecked((byte)quotient_100D_A1B9_1A289);
        AH = unchecked((byte)(dividend_100D_A1B9_1A289 % unchecked((ushort)divisor_100D_A1B9_1A289)));
        // 100D:A1BB mov BL,0x80
        BL = (byte)0x80;
        // 100D:A1BD sub BL,AL
        BL = Alu8.Sub(BL, AL);
    label_100D_A1BF_1A28F_32881:
        CheckExternalEvents(cs1, 0xA1BF);
        // 100D:A1BF mov byte ptr DS:[0x00D5],BL
        UInt8[DS, (ushort)0x00D5] = BL;
        // 100D:A1C3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A157_1A227(int loadOffset)
    {
        goto label_100D_A157_1A227_33020;

    label_100D_2419_124E9_41170:
        CheckExternalEvents(cs1, 0x2419);
        VerifySpeculativeEntryOrFail(cs1, 0x2419, [(byte)0xC3]);
        // 100D:2419 ret near
        return NearRet((ushort)0x0000);
    label_100D_24EE_125BE_33026:
        CheckExternalEvents(cs1, 0x24EE);
        // 100D:24EE cmp byte ptr DS:[0x009F],2
        Alu8.Sub(UInt8[DS, (ushort)0x009F], (byte)0x02);
        // 100D:24F3 je short 0x2541
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:24F3");
        }
    label_100D_24F5_125C5_33029:
        CheckExternalEvents(cs1, 0x24F5);
        // 100D:24F5 jae short 0x252D
        if (!CarryFlag)
        {
            goto label_100D_252D_125FD_38039;
        }
    label_100D_24F7_125C7_33031:
        CheckExternalEvents(cs1, 0x24F7);
        // 100D:24F7 cmp byte ptr DS:[0x476D],0
        Alu8.Sub(UInt8[DS, (ushort)0x476D], (byte)0x00);
        // 100D:24FC jne short 0x2517
        if (!ZeroFlag)
        {
            goto label_100D_2517_125E7_34835;
        }
    label_100D_24FE_125CE_33034:
        CheckExternalEvents(cs1, 0x24FE);
        // 100D:24FE mov AL,byte ptr DS:[0x001A]
        AL = UInt8[DS, (ushort)0x001A];
        // 100D:2501 dec AX
        AX = Alu16.Dec(AX);
        // 100D:2502 and AX,3
        AX = Alu16.And(AX, (ushort)0x0003);
        // 100D:2505 mov BX,AX
        BX = AX;
        // 100D:2507 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:2509 mov AX,word ptr DS:[BX+0x00B4]
        AX = UInt16[DS, (ushort)(BX + (short)180)];
        // 100D:250D mov word ptr DS:[0x00C0],AX
        UInt16[DS, (ushort)0x00C0] = AX;
        // 100D:2510 mov word ptr DS:[0x1158],0xFFFF
        UInt16[DS, (ushort)0x1158] = (ushort)0xFFFF;
        // 100D:2516 ret near
        return NearRet((ushort)0x0000);
    label_100D_2517_125E7_34835:
        CheckExternalEvents(cs1, 0x2517);
        // 100D:2517 mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:251B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:251D xchg AX,word ptr DS:[DI+0x0E]
        ushort xchgOffset_100D_251D_125ED = unchecked((ushort)(DI + (sbyte)14));
        ushort temp_100D_251D_125ED = AX;
        AX = UInt16[DS, xchgOffset_100D_251D_125ED];
        UInt16[DS, xchgOffset_100D_251D_125ED] = unchecked((ushort)temp_100D_251D_125ED);
        // 100D:2520 dec byte ptr DS:[0x0022]
        UInt8[DS, (ushort)0x0022] = Alu8.Dec(UInt8[DS, (ushort)0x0022]);
        return unknown_100D_2524_125F4(0x0000);
    label_100D_252D_125FD_38039:
        CheckExternalEvents(cs1, 0x252D);
        // 100D:252D cmp byte ptr DS:[0x476D],0
        Alu8.Sub(UInt8[DS, (ushort)0x476D], (byte)0x00);
        // 100D:2532 je short 0x2540
        if (ZeroFlag)
        {
            goto label_100D_2540_12610_38042;
        }
    label_100D_2534_12604_38044:
        CheckExternalEvents(cs1, 0x2534);
        // 100D:2534 mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:2538 and byte ptr DS:[DI+2],0x9F
        UInt8[DS, (ushort)(DI + (sbyte)2)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)2)], (byte)0x9F);
        // 100D:253C or byte ptr DS:[DI+2],0x20
        UInt8[DS, (ushort)(DI + (sbyte)2)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)2)], (byte)0x20);
    label_100D_2540_12610_38042:
        CheckExternalEvents(cs1, 0x2540);
        // 100D:2540 ret near
        return NearRet((ushort)0x0000);
    label_100D_2D2C_12DFC_41164:
        CheckExternalEvents(cs1, 0x2D2C);
        // 100D:2D2C inc byte ptr DS:[0x00C2]
        UInt8[DS, (ushort)0x00C2] = Alu8.Inc(UInt8[DS, (ushort)0x00C2]);
        // 100D:2D30 sub SP,0x0032
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:2D33 mov BX,SP
        BX = SP;
        // 100D:2D35 mov BP,0x2D62
        BP = (ushort)0x2D62;
        // 100D:2D38 call near 0x1258
        NearCall(cs1, 0x2D3B, unknown_100D_1258_11328);
    label_100D_2D3B_12E0B_41202:
        CheckExternalEvents(cs1, 0x2D3B);
        // 100D:2D3B mov word ptr DS:[BX],0
        UInt16[DS, BX] = (ushort)0x0000;
        // 100D:2D3F mov SI,SP
        SI = SP;
    label_100D_2D41_12E11_41205:
        CheckExternalEvents(cs1, 0x2D41);
        // 100D:2D41 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2D42 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:2D44 je short 0x2D5E
        if (ZeroFlag)
        {
            goto label_100D_2D5E_12E2E_41208;
        }
    label_100D_2D46_12E16_41210:
        CheckExternalEvents(cs1, 0x2D46);
        // 100D:2D46 push SI
        Stack.Push16(SI);
        // 100D:2D47 mov SI,AX
        SI = AX;
        // 100D:2D49 push SI
        Stack.Push16(SI);
        // 100D:2D4A mov DI,0x011C
        DI = (ushort)0x011C;
        // 100D:2D4D call near 0x84A6
        NearCall(cs1, 0x2D50, unknown_100D_84A6_18576);
    label_100D_2D50_12E20_41227:
        CheckExternalEvents(cs1, 0x2D50);
        // 100D:2D50 pop SI
        SI = Stack.Pop16();
        // 100D:2D51 call near 0x8308
        NearCall(cs1, 0x2D54, unknown_100D_8308_183D8);
    label_100D_2D54_12E24_41232:
        CheckExternalEvents(cs1, 0x2D54);
        // 100D:2D54 pop SI
        SI = Stack.Pop16();
        // 100D:2D55 mov AX,SP
        AX = SP;
        // 100D:2D57 add AX,0x000E
        AX = Alu16.Add(AX, (ushort)0x000E);
        // 100D:2D5A cmp SI,AX
        Alu16.Sub(SI, AX);
        // 100D:2D5C jb short 0x2D41
        if (CarryFlag)
        {
            goto label_100D_2D41_12E11_41205;
        }
    label_100D_2D5E_12E2E_41208:
        CheckExternalEvents(cs1, 0x2D5E);
        // 100D:2D5E add SP,0x0032
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:2D61 ret near
        return NearRet((ushort)0x0000);
    label_100D_A157_1A227_33020:
        CheckExternalEvents(cs1, 0xA157);
        // 100D:A157 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:A15A cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        // 100D:A15D jne short 0xA162
        if (!ZeroFlag)
        {
            goto label_100D_A162_1A232_41156;
        }
    label_100D_A15F_1A22F_33024:
        CheckExternalEvents(cs1, 0xA15F);
        // 100D:A15F jmp near 0x24EE
        goto label_100D_24EE_125BE_33026;
    label_100D_A162_1A232_41156:
        CheckExternalEvents(cs1, 0xA162);
        // 100D:A162 cmp AX,5
        Alu16.Sub(AX, (ushort)0x0005);
        // 100D:A165 jne short 0xA16A
        if (!ZeroFlag)
        {
            goto label_100D_A16A_1A23A_41159;
        }
    label_100D_A167_1A237_41161:
        CheckExternalEvents(cs1, 0xA167);
        // 100D:A167 jmp near 0x2D2C
        goto label_100D_2D2C_12DFC_41164;
    label_100D_A16A_1A23A_41159:
        CheckExternalEvents(cs1, 0xA16A);
        VerifySpeculativeEntryOrFail(cs1, 0xA16A, [(byte)0x3D, (byte)0x0D, (byte)0x00]);
        // 100D:A16A cmp AX,0x000D
        Alu16.Sub(AX, (ushort)0x000D);
        VerifySpeculativeEntryOrFail(cs1, 0xA16D, [(byte)0x75, (byte)0xE7]);
        // 100D:A16D jne short 0xA156
        if (!ZeroFlag)
        {
            return unknown_100D_A156_1A226(0x0000);
        }
    label_100D_A16F_1A23F_41167:
        CheckExternalEvents(cs1, 0xA16F);
        VerifySpeculativeEntryOrFail(cs1, 0xA16F, [(byte)0xE9, (byte)0xA7, (byte)0x82]);
        // 100D:A16F jmp near 0x2419
        goto label_100D_2419_124E9_41170;
    }

    public virtual Action unknown_100D_A172_1A242(int loadOffset)
    {
        goto label_100D_A172_1A242_26930;

    label_100D_24A3_12573_26939:
        CheckExternalEvents(cs1, 0x24A3);
        // 100D:24A3 cmp byte ptr DS:[0x002A],0x10
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x10);
        // 100D:24A8 jae short 0x24B0
        if (!CarryFlag)
        {
            goto label_100D_24B0_12580_33246;
        }
    label_100D_24AA_1257A_26942:
        CheckExternalEvents(cs1, 0x24AA);
        // 100D:24AA or byte ptr DS:[0x0FF7],0x10
        UInt8[DS, (ushort)0x0FF7] = Alu8.Or(UInt8[DS, (ushort)0x0FF7], (byte)0x10);
        // 100D:24AF ret near
        return NearRet((ushort)0x0000);
    label_100D_24B0_12580_33246:
        CheckExternalEvents(cs1, 0x24B0);
        // 100D:24B0 call near 0xA1E8
        NearCall(cs1, 0x24B3, unknown_100D_A1E8_1A2B8);
    label_100D_24B3_12583_33248:
        CheckExternalEvents(cs1, 0x24B3);
        // 100D:24B3 mov word ptr DS:[0x00C0],0
        UInt16[DS, (ushort)0x00C0] = (ushort)0x0000;
        // 100D:24B9 or byte ptr DS:[0x00BF],1
        UInt8[DS, (ushort)0x00BF] = Alu8.Or(UInt8[DS, (ushort)0x00BF], (byte)0x01);
        // 100D:24BE call near 0x24D2
        NearCall(cs1, 0x24C1, unknown_100D_24D2_125A2);
    label_100D_24C1_12591_33267:
        CheckExternalEvents(cs1, 0x24C1);
        // 100D:24C1 add AH,7
        AH = Alu8.Add(AH, (byte)0x07);
        // 100D:24C4 mov AL,0x0B
        AL = (byte)0x0B;
        // 100D:24C6 cmp AH,0x0C
        Alu8.Sub(AH, (byte)0x0C);
        // 100D:24C9 jne short 0x24CF
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:24C9");
        }
    label_100D_24CF_1259F_33272:
        CheckExternalEvents(cs1, 0x24CF);
        // 100D:24CF jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    label_100D_A172_1A242_26930:
        CheckExternalEvents(cs1, 0xA172);
        // 100D:A172 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:A175 cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:A178 jne short 0xA17E
        if (!ZeroFlag)
        {
            goto label_100D_A17E_1A24E_26934;
        }
    label_100D_A17A_1A24A_32279:
        CheckExternalEvents(cs1, 0xA17A);
        // 100D:A17A inc byte ptr DS:[0x00F5]
        UInt8[DS, (ushort)0x00F5] = Alu8.Inc(UInt8[DS, (ushort)0x00F5]);
    label_100D_A17E_1A24E_26934:
        CheckExternalEvents(cs1, 0xA17E);
        // 100D:A17E cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        // 100D:A181 jne short 0xA156
        if (!ZeroFlag)
        {
            return unknown_100D_A156_1A226(0x0000);
        }
    label_100D_A183_1A253_26937:
        CheckExternalEvents(cs1, 0xA183);
        // 100D:A183 jmp near 0x24A3
        goto label_100D_24A3_12573_26939;
    }

    public virtual Action unknown_100D_A1C4_1A294(int loadOffset)
    {
    label_100D_A1C4_1A294_16171:
        CheckExternalEvents(cs1, 0xA1C4);
        // 100D:A1C4 mov byte ptr DS:[0x47A5],0xFF
        UInt8[DS, (ushort)0x47A5] = (byte)0xFF;
        // 100D:A1C9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1D0_1A2A0(int loadOffset)
    {
    label_100D_A1D0_1A2A0_23087:
        CheckExternalEvents(cs1, 0xA1D0);
        // 100D:A1D0 mov byte ptr DS:[0x47A5],0xFF
        UInt8[DS, (ushort)0x47A5] = (byte)0xFF;
        // 100D:A1D5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1D6_1A2A6(int loadOffset)
    {
    label_100D_A1D6_1A2A6_16197:
        CheckExternalEvents(cs1, 0xA1D6);
        // 100D:A1D6 mov byte ptr DS:[0x47A5],0
        UInt8[DS, (ushort)0x47A5] = (byte)0x00;
        // 100D:A1DB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1DC_1A2AC(int loadOffset)
    {
    label_100D_A1DC_1A2AC_24893:
        CheckExternalEvents(cs1, 0xA1DC);
        // 100D:A1DC mov byte ptr DS:[0x47A5],0x80
        UInt8[DS, (ushort)0x47A5] = (byte)0x80;
        // 100D:A1E1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1E2_1A2B2(int loadOffset)
    {
    label_100D_A1E2_1A2B2_16209:
        CheckExternalEvents(cs1, 0xA1E2);
        // 100D:A1E2 cmp byte ptr DS:[0x47A5],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x47A5], (byte)0xFF);
        // 100D:A1E7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1E8_1A2B8(int loadOffset)
    {
    label_100D_A1E8_1A2B8_20440:
        CheckExternalEvents(cs1, 0xA1E8);
        // 100D:A1E8 inc byte ptr DS:[0x47A8]
        UInt8[DS, (ushort)0x47A8] = Alu8.Inc(UInt8[DS, (ushort)0x47A8]);
        // 100D:A1EC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1ED_1A2BD(int loadOffset)
    {
    label_100D_A1ED_1A2BD_41069:
        CheckExternalEvents(cs1, 0xA1ED);
        // 100D:A1ED test byte ptr DS:[SI],0x80
        Alu8.And(UInt8[DS, SI], (byte)0x80);
        // 100D:A1F0 jne short 0xA234
        if (!ZeroFlag)
        {
            return unknown_100D_A234_1A304(0x0000);
        }
    label_100D_A1F2_1A2C2_41073:
        CheckExternalEvents(cs1, 0xA1F2);
        // 100D:A1F2 inc byte ptr DS:[0x00C2]
        UInt8[DS, (ushort)0x00C2] = Alu8.Inc(UInt8[DS, (ushort)0x00C2]);
        // 100D:A1F6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A1F7_1A2C7(int loadOffset)
    {
    label_100D_A1F7_1A2C7_28331:
        CheckExternalEvents(cs1, 0xA1F7);
        // 100D:A1F7 mov BL,byte ptr DS:[0x002A]
        BL = UInt8[DS, (ushort)0x002A];
        // 100D:A1FB mov AX,0x12F8
        AX = (ushort)0x12F8;
        // 100D:A1FE cmp BL,0x14
        Alu8.Sub(BL, (byte)0x14);
        // 100D:A201 jb short 0xA216
        if (CarryFlag)
        {
            goto label_100D_A216_1A2E6_28336;
        }
    label_100D_A203_1A2D3_32849:
        CheckExternalEvents(cs1, 0xA203);
        // 100D:A203 mov AX,0x134F
        AX = (ushort)0x134F;
        // 100D:A206 cmp BL,0x18
        Alu8.Sub(BL, (byte)0x18);
        // 100D:A209 jb short 0xA216
        if (CarryFlag)
        {
            goto label_100D_A216_1A2E6_28336;
        }
    label_100D_A20B_1A2DB_33759:
        CheckExternalEvents(cs1, 0xA20B);
        // 100D:A20B mov AX,0x1370
        AX = (ushort)0x1370;
        // 100D:A20E cmp BL,0x30
        Alu8.Sub(BL, (byte)0x30);
        // 100D:A211 jb short 0xA216
        if (CarryFlag)
        {
            goto label_100D_A216_1A2E6_28336;
        }
    label_100D_A213_1A2E3_41079:
        CheckExternalEvents(cs1, 0xA213);
        // 100D:A213 mov AX,0x12DB
        AX = (ushort)0x12DB;
    label_100D_A216_1A2E6_28336:
        CheckExternalEvents(cs1, 0xA216);
        // 100D:A216 jmp near 0x1771
        return unknown_100D_1771_11841(0x0000);
    }

    public virtual Action unknown_100D_A219_1A2E9(int loadOffset)
    {
    label_100D_A219_1A2E9_23069:
        CheckExternalEvents(cs1, 0xA219);
        // 100D:A219 test byte ptr DS:[SI],0x80
        Alu8.And(UInt8[DS, SI], (byte)0x80);
        // 100D:A21C jne short 0xA234
        if (!ZeroFlag)
        {
            return unknown_100D_A234_1A304(0x0000);
        }
    label_100D_A21E_1A2EE_23072:
        CheckExternalEvents(cs1, 0xA21E);
        // 100D:A21E inc byte ptr DS:[0x002A]
        UInt8[DS, (ushort)0x002A] = Alu8.Inc(UInt8[DS, (ushort)0x002A]);
        // 100D:A222 mov byte ptr DS:[0x00FF],0
        UInt8[DS, (ushort)0x00FF] = (byte)0x00;
        // 100D:A227 call near 0xB17A
        NearCall(cs1, 0xA22A, unknown_100D_B17A_1B24A);
    label_100D_A22A_1A2FA_23076:
        CheckExternalEvents(cs1, 0xA22A);
        // 100D:A22A cmp byte ptr DS:[0x002A],1
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x01);
        // 100D:A22F jne short 0xA234
        if (!ZeroFlag)
        {
            return unknown_100D_A234_1A304(0x0000);
        }
    label_100D_A231_1A301_23079:
        CheckExternalEvents(cs1, 0xA231);
        // 100D:A231 call near 0x100B
        NearCall(cs1, 0xA234, unknown_100D_100B_110DB);
        return unknown_100D_A234_1A304(0x0000);
    }

    public virtual Action unknown_100D_A235_1A305(int loadOffset)
    {
    entrydispatcher:
    label_100D_A235_1A305_27410:
        CheckExternalEvents(cs1, 0xA235);
        // 100D:A235 test byte ptr DS:[SI],0x80
        Alu8.And(UInt8[DS, SI], (byte)0x80);
        // 100D:A238 jne short 0xA234
        if (!ZeroFlag)
        {
            return unknown_100D_A234_1A304(0x0000);
        }
    label_100D_A23A_1A30A_27413:
        CheckExternalEvents(cs1, 0xA23A);
        // 100D:A23A mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:A23D and AL,0xFC
        AL = Alu8.And(AL, (byte)0xFC);
        // 100D:A23F add AL,4
        AL = Alu8.Add(AL, (byte)0x04);
        // 100D:A241 jmp near 0x121F
        if (JumpDispatcher.Jump(unknown_100D_121F_112EF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A244_1A314(int loadOffset)
    {
    entrydispatcher:
    label_100D_A244_1A314_32993:
        CheckExternalEvents(cs1, 0xA244);
        // 100D:A244 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:A246 jmp short 0xA24A
        if (JumpDispatcher.Jump(unknown_100D_A24A_1A31A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A248_1A318(int loadOffset)
    {
    entrydispatcher:
    label_100D_A248_1A318_34830:
        CheckExternalEvents(cs1, 0xA248);
        // 100D:A248 mov AL,1
        AL = (byte)0x01;
        if (JumpDispatcher.Jump(unknown_100D_A24A_1A31A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A25B_1A32B(int loadOffset)
    {
    label_100D_A25B_1A32B_26945:
        CheckExternalEvents(cs1, 0xA25B);
        // 100D:A25B push SI
        Stack.Push16(SI);
        // 100D:A25C push DS
        Stack.Push16(DS);
        // 100D:A25D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:A25E mov AX,word ptr DS:[0x4780]
        AX = UInt16[DS, (ushort)0x4780];
        // 100D:A261 mov BX,0x0A01
        BX = (ushort)0x0A01;
        // 100D:A264 mov DI,0x197C
        DI = (ushort)0x197C;
    label_100D_A267_1A337_26952:
        CheckExternalEvents(cs1, 0xA267);
        // 100D:A267 add DI,8
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:A26A scas AX,word ptr ES:[DI]
        Alu16.Sub(AX, UInt16[ES, DI]);
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:A26B ja short 0xA267
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_A267_1A337_26952;
        }
    label_100D_A26D_1A33D_26956:
        CheckExternalEvents(cs1, 0xA26D);
        // 100D:A26D jne short 0xA28C
        if (!ZeroFlag)
        {
            return unknown_100D_A28C_1A35C(0x0000);
        }
    label_100D_A26F_1A33F_26958:
        CheckExternalEvents(cs1, 0xA26F);
        // 100D:A26F cmp word ptr DS:[DI],0x0038
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)56)));
        // 100D:A272 jne short 0xA276
        if (!ZeroFlag)
        {
            goto label_100D_A276_1A346_26961;
        }
    label_100D_A274_1A344_34832:
        CheckExternalEvents(cs1, 0xA274);
        // 100D:A274 mov BH,0x10
        BH = (byte)0x10;
    label_100D_A276_1A346_26961:
        CheckExternalEvents(cs1, 0xA276);
        // 100D:A276 mov AL,byte ptr DS:[0x47D0]
        AL = UInt8[DS, (ushort)0x47D0];
        // 100D:A279 dec AL
        AL = Alu8.Dec(AL);
        // 100D:A27B js short 0xA284
        if (SignFlag)
        {
            goto label_100D_A284_1A354_26965;
        }
    label_100D_A27D_1A34D_33962:
        CheckExternalEvents(cs1, 0xA27D);
        // 100D:A27D shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:A27F inc AX
        AX = Alu16.Inc(AX);
        // 100D:A280 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:A282 add BH,AL
        BH = Alu8.Add(BH, AL);
    label_100D_A284_1A354_26965:
        CheckExternalEvents(cs1, 0xA284);
        // 100D:A284 mov word ptr DS:[0x47E1],BX
        UInt16[DS, (ushort)0x47E1] = BX;
        // 100D:A288 mov word ptr DS:[0x47E4],DI
        UInt16[DS, (ushort)0x47E4] = DI;
        return unknown_100D_A28C_1A35C(0x0000);
    }

    public virtual Action unknown_100D_A28E_1A35E(int loadOffset)
    {
    label_100D_A28E_1A35E_33727:
        CheckExternalEvents(cs1, 0xA28E);
        // 100D:A28E push SI
        Stack.Push16(SI);
        // 100D:A28F cmp word ptr DS:[0x47C4],0x000E
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:A294 jb short 0xA2A0
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A294");
        }
    label_100D_A296_1A366_33731:
        CheckExternalEvents(cs1, 0xA296);
        // 100D:A296 mov DI,word ptr DS:[0x47E6]
        DI = UInt16[DS, (ushort)0x47E6];
        // 100D:A29A call near 0x456C
        NearCall(cs1, 0xA29D, unknown_100D_456C_1463C);
    label_100D_A29D_1A36D_33734:
        CheckExternalEvents(cs1, 0xA29D);
        // 100D:A29D mov word ptr DS:[0xDC30],AX
        UInt16[DS, (ushort)0xDC30] = AX;
        // 100D:A2A0 cmp byte ptr DS:[0x28E7],1
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x01);
        // 100D:A2A5 je short 0xA28C
        if (ZeroFlag)
        {
            return unknown_100D_A28C_1A35C(0x0000);
        }
    label_100D_A2A7_1A377_36625:
        CheckExternalEvents(cs1, 0xA2A7);
        // 100D:A2A7 mov AX,word ptr DS:[0x47E6]
        AX = UInt16[DS, (ushort)0x47E6];
        // 100D:A2AA cmp AX,word ptr DS:[0x114E]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x114E]);
        // 100D:A2AE je short 0xA28C
        if (ZeroFlag)
        {
            return unknown_100D_A28C_1A35C(0x0000);
        }
    label_100D_A2B0_1A380_36629:
        CheckExternalEvents(cs1, 0xA2B0);
        // 100D:A2B0 mov byte ptr DS:[0x47A4],0
        UInt8[DS, (ushort)0x47A4] = (byte)0x00;
        // 100D:A2B5 mov AX,0x0021
        AX = (ushort)0x0021;
        // 100D:A2B8 call near 0xC13E
        NearCall(cs1, 0xA2BB, unknown_100D_C13E_1C20E);
    label_100D_A2BB_1A38B_36633:
        CheckExternalEvents(cs1, 0xA2BB);
        // 100D:A2BB mov SI,0x22E4
        SI = (ushort)0x22E4;
        // 100D:A2BE call near 0xC21B
        NearCall(cs1, 0xA2C1, unknown_100D_C21B_1C2EB);
    label_100D_A2C1_1A391_36636:
        CheckExternalEvents(cs1, 0xA2C1);
        // 100D:A2C1 mov SI,word ptr DS:[0x22FC]
        SI = UInt16[DS, (ushort)0x22FC];
        // 100D:A2C5 mov CX,0x2A80
        CX = (ushort)0x2A80;
        // 100D:A2C8 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:A2CA mov DI,0xA5BF
        DI = (ushort)0xA5BF;
        // 100D:A2CD push DS
        Stack.Push16(DS);
        // 100D:A2CE pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:A2CF std
        DirectionFlag = true;
        // 100D:A2D0 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:A2D2 cld
        DirectionFlag = false;
        // 100D:A2D3 inc DI
        DI = Alu16.Inc(DI);
        // 100D:A2D4 mov word ptr DS:[0x22FC],DI
        UInt16[DS, (ushort)0x22FC] = DI;
        // 100D:A2D8 mov DI,word ptr DS:[0x47E6]
        DI = UInt16[DS, (ushort)0x47E6];
        // 100D:A2DC push DI
        Stack.Push16(DI);
        // 100D:A2DD call near 0x5B55
        NearCall(cs1, 0xA2E0, unknown_100D_5B55_15C25);
    label_100D_A2E0_1A3B0_36655:
        CheckExternalEvents(cs1, 0xA2E0);
        // 100D:A2E0 mov byte ptr DS:[0x46EB],1
        UInt8[DS, (ushort)0x46EB] = (byte)0x01;
        // 100D:A2E5 mov SI,0x22F4
        SI = (ushort)0x22F4;
        // 100D:A2E8 mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:A2EB call near 0x5B99
        NearCall(cs1, 0xA2EE, unknown_100D_5B99_15C69);
    label_100D_A2EE_1A3BE_36660:
        CheckExternalEvents(cs1, 0xA2EE);
        // 100D:A2EE call near 0x5B93
        NearCall(cs1, 0xA2F1, unknown_100D_5B93_15C63);
    label_100D_A2F1_1A3C1_36662:
        CheckExternalEvents(cs1, 0xA2F1);
        // 100D:A2F1 call near 0xB6C3
        NearCall(cs1, 0xA2F4, unknown_100D_B6C3_1B793);
    label_100D_A2F4_1A3C4_36664:
        CheckExternalEvents(cs1, 0xA2F4);
        // 100D:A2F4 call near 0xC137
        NearCall(cs1, 0xA2F7, unknown_100D_C137_1C207);
    label_100D_A2F7_1A3C7_36666:
        CheckExternalEvents(cs1, 0xA2F7);
        // 100D:A2F7 call near 0x5DCE
        NearCall(cs1, 0xA2FA, unknown_100D_5DCE_15E9E);
    label_100D_A2FA_1A3CA_36668:
        CheckExternalEvents(cs1, 0xA2FA);
        // 100D:A2FA pop SI
        SI = Stack.Pop16();
        // 100D:A2FB call near 0x62FE
        NearCall(cs1, 0xA2FE, unknown_100D_62FE_163CE);
    label_100D_A2FE_1A3CE_36672:
        CheckExternalEvents(cs1, 0xA2FE);
        // 100D:A2FE mov byte ptr DS:[0x46EB],0
        UInt8[DS, (ushort)0x46EB] = (byte)0x00;
        // 100D:A303 mov SI,0x22EC
        SI = (ushort)0x22EC;
        // 100D:A306 call near 0xC477
        NearCall(cs1, 0xA309, unknown_100D_C477_1C547);
    label_100D_A309_1A3D9_36676:
        CheckExternalEvents(cs1, 0xA309);
        // 100D:A309 pop SI
        SI = Stack.Pop16();
        // 100D:A30A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A30B_1A3DB(int loadOffset)
    {
    label_100D_A30B_1A3DB_3186:
        CheckExternalEvents(cs1, 0xA30B);
        // 100D:A30B lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:A30D cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:A30F jae short 0xA32A
        if (!CarryFlag)
        {
            goto label_100D_A32A_1A3FA_16089;
        }
    label_100D_A311_1A3E1_3190:
        CheckExternalEvents(cs1, 0xA311);
        // 100D:A311 push BX
        Stack.Push16(BX);
        // 100D:A312 mov BL,byte ptr ES:[SI]
        BL = UInt8[ES, SI];
        // 100D:A315 inc SI
        SI = Alu16.Inc(SI);
        // 100D:A316 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:A318 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:A31A je short 0xA322
        if (ZeroFlag)
        {
            goto label_100D_A322_1A3F2_3197;
        }
    label_100D_A31C_1A3EC_16115:
        CheckExternalEvents(cs1, 0xA31C);
        // 100D:A31C mov AX,word ptr DS:[BX]
        AX = UInt16[DS, (ushort)(BX + (short)0)];
        // 100D:A320 pop BX
        BX = Stack.Pop16();
        // 100D:A321 ret near
        return NearRet((ushort)0x0000);
    label_100D_A322_1A3F2_3197:
        CheckExternalEvents(cs1, 0xA322);
        // 100D:A322 mov AL,byte ptr DS:[BX]
        AL = UInt8[DS, (ushort)(BX + (short)0)];
        // 100D:A326 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:A328 pop BX
        BX = Stack.Pop16();
        // 100D:A329 ret near
        return NearRet((ushort)0x0000);
    label_100D_A32A_1A3FA_16089:
        CheckExternalEvents(cs1, 0xA32A);
        // 100D:A32A jne short 0xA331
        if (!ZeroFlag)
        {
            goto label_100D_A331_1A401_19863;
        }
    label_100D_A32C_1A3FC_16091:
        CheckExternalEvents(cs1, 0xA32C);
        // 100D:A32C lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:A32E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:A330 ret near
        return NearRet((ushort)0x0000);
    label_100D_A331_1A401_19863:
        CheckExternalEvents(cs1, 0xA331);
        // 100D:A331 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:A333 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A334_1A404(int loadOffset)
    {
    label_100D_A334_1A404_16097:
        CheckExternalEvents(cs1, 0xA334);
        // 100D:A334 and BX,0x001F
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)31)));
        // 100D:A337 jmp near word ptr CS:[BX-23690]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)-23690)]))
        {
            case 0xA33C:
                break;
            case 0xA33F:
                goto label_100D_A33F_1A40F_20391;
            case 0xA342:
                goto label_100D_A342_1A412_16122;
            case 0xA345:
                goto label_100D_A345_1A415_16119;
            case 0xA348:
                goto label_100D_A348_1A418_16100;
            case 0xA34F:
                goto label_100D_A34F_1A41F_16146;
            case 0xA356:
                goto label_100D_A356_1A426_16139;
            case 0xA35D:
                goto label_100D_A35D_1A42D_22917;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)-23690)])):X4} at 100D:A337");
        }
    label_100D_A33C_1A40C_24959:
        CheckExternalEvents(cs1, 0xA33C);
        // 100D:A33C add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:A33E ret near
        return NearRet((ushort)0x0000);
    label_100D_A33F_1A40F_20391:
        CheckExternalEvents(cs1, 0xA33F);
        // 100D:A33F sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:A341 ret near
        return NearRet((ushort)0x0000);
    label_100D_A342_1A412_16122:
        CheckExternalEvents(cs1, 0xA342);
        // 100D:A342 and DX,AX
        DX = Alu16.And(DX, AX);
        // 100D:A344 ret near
        return NearRet((ushort)0x0000);
    label_100D_A345_1A415_16119:
        CheckExternalEvents(cs1, 0xA345);
        // 100D:A345 or DX,AX
        DX = Alu16.Or(DX, AX);
        // 100D:A347 ret near
        return NearRet((ushort)0x0000);
    label_100D_A348_1A418_16100:
        CheckExternalEvents(cs1, 0xA348);
        // 100D:A348 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:A34A je short 0xA372
        if (ZeroFlag)
        {
            goto label_100D_A372_1A442_16125;
        }
    label_100D_A34C_1A41C_16103:
        CheckExternalEvents(cs1, 0xA34C);
        // 100D:A34C xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:A34E ret near
        return NearRet((ushort)0x0000);
    label_100D_A34F_1A41F_16146:
        CheckExternalEvents(cs1, 0xA34F);
        // 100D:A34F cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:A351 jb short 0xA372
        if (CarryFlag)
        {
            goto label_100D_A372_1A442_16125;
        }
    label_100D_A353_1A423_20394:
        CheckExternalEvents(cs1, 0xA353);
        // 100D:A353 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:A355 ret near
        return NearRet((ushort)0x0000);
    label_100D_A356_1A426_16139:
        CheckExternalEvents(cs1, 0xA356);
        // 100D:A356 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:A358 ja short 0xA372
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_A372_1A442_16125;
        }
    label_100D_A35A_1A42A_16142:
        CheckExternalEvents(cs1, 0xA35A);
        // 100D:A35A xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:A35C ret near
        return NearRet((ushort)0x0000);
    label_100D_A35D_1A42D_22917:
        CheckExternalEvents(cs1, 0xA35D);
        // 100D:A35D cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:A35F jne short 0xA372
        if (!ZeroFlag)
        {
            goto label_100D_A372_1A442_16125;
        }
    label_100D_A361_1A431_24339:
        CheckExternalEvents(cs1, 0xA361);
        // 100D:A361 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:A363 ret near
        return NearRet((ushort)0x0000);
    label_100D_A372_1A442_16125:
        CheckExternalEvents(cs1, 0xA372);
        // 100D:A372 mov DX,0xFFFF
        DX = (ushort)0xFFFF;
        // 100D:A375 ret near
        return NearRet((ushort)0x0000);
    }
}
