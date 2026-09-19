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
    public virtual Action provided_interrupt_handler_C_F000_006C_F006C(int loadOffset)
    {
    label_F000_006C_F006C_36939:
        CheckExternalEvents(cs5, 0x006C);
        // F000:006C callback 0x0105
        Callback(unchecked((ushort)((ushort)0x0105)));
    label_F000_0070_F0070_36940:
        CheckExternalEvents(cs5, 0x0070);
        // F000:0070 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_D_F000_0071_F0071(int loadOffset)
    {
    label_F000_0071_F0071_36943:
        CheckExternalEvents(cs5, 0x0071);
        // F000:0071 callback 0x0106
        Callback(unchecked((ushort)((ushort)0x0106)));
    label_F000_0075_F0075_36944:
        CheckExternalEvents(cs5, 0x0075);
        // F000:0075 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_F_F000_0076_F0076(int loadOffset)
    {
    label_F000_0076_F0076_36947:
        CheckExternalEvents(cs5, 0x0076);
        // F000:0076 callback 0x0107
        Callback(unchecked((ushort)((ushort)0x0107)));
    label_F000_007A_F007A_36948:
        CheckExternalEvents(cs5, 0x007A);
        // F000:007A iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_72_F000_007B_F007B(int loadOffset)
    {
    label_F000_007B_F007B_36955:
        CheckExternalEvents(cs5, 0x007B);
        // F000:007B callback 0x0108
        Callback(unchecked((ushort)((ushort)0x0108)));
    label_F000_007F_F007F_36956:
        CheckExternalEvents(cs5, 0x007F);
        // F000:007F iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_73_F000_0080_F0080(int loadOffset)
    {
    label_F000_0080_F0080_36959:
        CheckExternalEvents(cs5, 0x0080);
        // F000:0080 callback 0x0109
        Callback(unchecked((ushort)((ushort)0x0109)));
    label_F000_0084_F0084_36960:
        CheckExternalEvents(cs5, 0x0084);
        // F000:0084 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_21_F000_0090_F0090(int loadOffset)
    {
    label_F000_0090_F0090_161:
        CheckExternalEvents(cs5, 0x0090);
        // F000:0090 cmp AH,7
        Alu8.Sub(AH, (byte)0x07);
        // F000:0093 je short 0x00A4
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at F000:0093");
        }
    label_F000_0095_F0095_164:
        CheckExternalEvents(cs5, 0x0095);
        // F000:0095 cmp AH,8
        Alu8.Sub(AH, (byte)0x08);
        // F000:0098 je short 0x00A4
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at F000:0098");
        }
    label_F000_009A_F009A_167:
        CheckExternalEvents(cs5, 0x009A);
        // F000:009A cmp AH,0x0A
        Alu8.Sub(AH, (byte)0x0A);
        // F000:009D je short 0x00A4
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at F000:009D");
        }
    label_F000_009F_F009F_170:
        CheckExternalEvents(cs5, 0x009F);
        // F000:009F callback 0x0021
        Callback(unchecked((ushort)((ushort)0x0021)));
    label_F000_00A3_F00A3_172:
        CheckExternalEvents(cs5, 0x00A3);
        // F000:00A3 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_33_F000_00DD_F00DD(int loadOffset)
    {
    label_F000_00DD_F00DD_799:
        CheckExternalEvents(cs5, 0x00DD);
        // F000:00DD callback 0x0033
        Callback(unchecked((ushort)((ushort)0x0033)));
    label_F000_00E1_F00E1_801:
        CheckExternalEvents(cs5, 0x00E1);
        // F000:00E1 iret
        return InterruptRet();
    }

    public virtual Action unknown_F000_00E2_F00E2(int loadOffset)
    {
    label_F000_00E2_F00E2_4683:
        CheckExternalEvents(cs5, 0x00E2);
        // F000:00E2 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action provided_mouse_driver_F000_00E3_F00E3(int loadOffset)
    {
    label_F000_00E3_F00E3_4678:
        CheckExternalEvents(cs5, 0x00E3);
        // F000:00E3 callback 0x010C
        Callback(unchecked((ushort)((ushort)0x010C)));
    label_F000_00E7_F00E7_4681:
        CheckExternalEvents(cs5, 0x00E7);
        // F000:00E7 call far F000:00E2
        FarCall(cs5, 0x00EC, cs5, unknown_F000_00E2_F00E2);
    label_F000_00EC_F00EC_4685:
        CheckExternalEvents(cs5, 0x00EC);
        // F000:00EC callback 0x010D
        Callback(unchecked((ushort)((ushort)0x010D)));
    label_F000_00F0_F00F0_4687:
        CheckExternalEvents(cs5, 0x00F0);
        // F000:00F0 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_003A_1010A(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_003A_1010A_20103;
            case 0x0FA7:
                goto label_100D_0FA7_11077_28006;
            case 0x1877:
                goto label_100D_1877_11947_13218;
            case 0x1B8D:
                goto label_100D_1B8D_11C5D_15178;
            case 0x2993:
                goto label_100D_2993_12A63_31927;
            case 0x2999:
                goto label_100D_2999_12A69_31930;
            case 0x3F27:
                goto label_100D_3F27_13FF7_19793;
            case 0x42E9:
                goto label_100D_42E9_143B9_20659;
            case 0x4703:
                goto label_100D_4703_147D3_21483;
            case 0x4FC3:
                goto label_100D_4FC3_15093_22539;
            case 0x7D81:
                goto label_100D_7D81_17E51_27795;
            case 0x8214:
                goto label_100D_8214_182E4_29367;
            case 0x8246:
                goto label_100D_8246_18316_30173;
            case 0x8286:
                goto label_100D_8286_18356_29311;
            case 0x8296:
                goto label_100D_8296_18366_29354;
            case 0x829E:
                goto label_100D_829E_1836E_29364;
            case 0x872C:
                goto label_100D_872C_187FC_30128;
            case 0x92FC:
                goto label_100D_92FC_193CC_33283;
            case 0x9301:
                goto label_100D_9301_193D1_26927;
            case 0x9306:
                goto label_100D_9306_193D6_23066;
            case 0x930B:
                goto label_100D_930B_193DB_33492;
            case 0x936F:
                goto label_100D_936F_1943F_33901;
            case 0x9373:
                goto label_100D_9373_19443_23170;
            case 0x9381:
                goto label_100D_9381_19451_26988;
            case 0x93AA:
                goto label_100D_93AA_1947A_15415;
            case 0x9472:
                goto label_100D_9472_19542_15581;
            case 0x956C:
                goto label_100D_956C_1963C_25978;
            case 0x961A:
                goto label_100D_961A_196EA_16214;
            case 0x96EB:
                goto label_100D_96EB_197BB_27205;
            case 0x9ED5:
                goto label_100D_9ED5_19FA5_16216;
            case 0xA3F9:
                goto label_100D_A3F9_1A4C9_25339;
            case 0xAD21:
                goto label_100D_AD21_1ADF1_25762;
            case 0xAD30:
                goto label_100D_AD30_1AE00_25793;
            case 0xB972:
                goto label_100D_B972_1BA42_19259;
            case 0xD445:
                goto label_100D_D445_1D515_15402;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_003A_1010A_20103:
        CheckExternalEvents(cs1, 0x003A);
        // 100D:003A cld
        DirectionFlag = false;
        // 100D:003B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:003D int 0x33
        InterruptCall(cs1, 0x003F, unchecked((byte)((byte)0x33)));
    label_100D_003F_1010F_20107:
        CheckExternalEvents(cs1, 0x003F);
        // 100D:003F mov AX,0x1F58
        AX = (ushort)0x1F58;
        // 100D:0042 mov DS,AX
        DS = AX;
        // 100D:0044 call near 0xE8D5
        NearCall(cs1, 0x0047, unknown_100D_E8D5_1E9A5);
    label_100D_0047_10117_20132:
        CheckExternalEvents(cs1, 0x0047);
        // 100D:0047 cmp word ptr DS:[0x3977],0
        Alu16.Sub(UInt16[DS, (ushort)0x3977], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:004C je short 0x0056
        if (ZeroFlag)
        {
            goto label_100D_0056_10126_20141;
        }
    label_100D_004E_1011E_20135:
        CheckExternalEvents(cs1, 0x004E);
        // 100D:004E call far dword ptr DS:[0x3975]
        ushort targetSegment_20135 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3975 + (ushort)0x0002)]));
        ushort targetOffset_20135 = unchecked((ushort)(UInt16[DS, (ushort)0x3975]));
        if (targetSegment_20135 == cs4 && targetOffset_20135 == 0x0106)
        {
            FarCall(cs1, 0x0052, cs4, unknown_5BAE_0106_5BBE6);
            goto label_100D_0052_10122_20137;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_20135:X4}:{targetOffset_20135:X4} at 100D:004E");
    label_100D_0052_10122_20137:
        CheckExternalEvents(cs1, 0x0052);
        // 100D:0052 call far dword ptr DS:[0x398D]
        ushort targetSegment_20137 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x398D + (ushort)0x0002)]));
        ushort targetOffset_20137 = unchecked((ushort)(UInt16[DS, (ushort)0x398D]));
        if (targetSegment_20137 == cs3 && targetOffset_20137 == 0x0103)
        {
            FarCall(cs1, 0x0056, cs3, unknown_5642_0103_56523);
            goto label_100D_0056_10126_20141;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_20137:X4}:{targetOffset_20137:X4} at 100D:0052");
    label_100D_0056_10126_20141:
        CheckExternalEvents(cs1, 0x0056);
        // 100D:0056 mov AX,3
        AX = (ushort)0x0003;
        // 100D:0059 int 0x10
        InterruptCall(cs1, 0x005B, unchecked((byte)((byte)0x10)));
    label_100D_005B_1012B_20144:
        CheckExternalEvents(cs1, 0x005B);
        // 100D:005B mov SI,word ptr DS:[0x3CBC]
        SI = UInt16[DS, (ushort)0x3CBC];
        // 100D:005F or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:0061 je short 0x006E
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:0061");
        }
    label_100D_006E_1013E_20148:
        CheckExternalEvents(cs1, 0x006E);
        // 100D:006E mov AX,0x0E0D
        AX = (ushort)0x0E0D;
        // 100D:0071 int 0x10
        InterruptCall(cs1, 0x0073, unchecked((byte)((byte)0x10)));
    label_100D_0073_10143_20151:
        CheckExternalEvents(cs1, 0x0073);
        // 100D:0073 mov AX,0x0E0A
        AX = (ushort)0x0E0A;
        // 100D:0076 int 0x10
        InterruptCall(cs1, 0x0078, unchecked((byte)((byte)0x10)));
    label_100D_0078_10148_20154:
        CheckExternalEvents(cs1, 0x0078);
        // 100D:0078 mov DL,0xFF
        DL = (byte)0xFF;
        // 100D:007A mov AX,0x0C06
        AX = (ushort)0x0C06;
        // 100D:007D int 0x21
        InterruptCall(cs1, 0x007F, unchecked((byte)((byte)0x21)));
    label_100D_007F_1014F_20158:
        CheckExternalEvents(cs1, 0x007F);
        // 100D:007F mov AH,0x4C
        AH = (byte)0x4C;
        // 100D:0081 int 0x21
        InterruptCall(cs1, 0x0083, unchecked((byte)((byte)0x21)));
        throw FailAsUntested("Call at 100D:0081 returned to 100D:0083, but no continuation was observed during discovery.");
    label_100D_0E3E_10F0E_20099:
        CheckExternalEvents(cs1, 0x0E3E);
        // 100D:0E3E mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:0E41 mov BP,0x20B6
        BP = (ushort)0x20B6;
        // 100D:0E44 jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_0E47_10F17_37899:
        CheckExternalEvents(cs1, 0x0E47);
        // 100D:0E47 mov CL,0xFF
        CL = (byte)0xFF;
    label_100D_0E49_10F19_37900:
        CheckExternalEvents(cs1, 0x0E49);
        // 100D:0E49 push CX
        Stack.Push16(CX);
        // 100D:0E4A cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:0E4F je short 0x0E62
        if (ZeroFlag)
        {
            goto label_100D_0E62_10F32_37904;
        }
    label_100D_0E51_10F21_37906:
        CheckExternalEvents(cs1, 0x0E51);
        // 100D:0E51 mov AX,0x000D
        AX = (ushort)0x000D;
        // 100D:0E54 call near 0x0E6C
        NearCall(cs1, 0x0E57, unknown_100D_0E6C_10F3C);
    label_100D_0E57_10F27_37918:
        CheckExternalEvents(cs1, 0x0E57);
        // 100D:0E57 mov byte ptr DS:[0x46D9],0
        UInt8[DS, (ushort)0x46D9] = (byte)0x00;
        // 100D:0E5C mov word ptr DS:[0x47C4],0
        UInt16[DS, (ushort)0x47C4] = (ushort)0x0000;
    label_100D_0E62_10F32_37904:
        CheckExternalEvents(cs1, 0x0E62);
        // 100D:0E62 pop CX
        CX = Stack.Pop16();
        // 100D:0E63 jmp near 0xB3B0
        goto label_100D_B3B0_1B480_20205;
    label_100D_0EA6_10F76_19951:
        CheckExternalEvents(cs1, 0x0EA6);
        // 100D:0EA6 call near 0xB2B9
        NearCall(cs1, 0x0EA9, unknown_100D_B2B9_1B389);
    label_100D_0EA9_10F79_19953:
        CheckExternalEvents(cs1, 0x0EA9);
        // 100D:0EA9 call near 0x98E6
        NearCall(cs1, 0x0EAC, unknown_100D_98E6_199B6);
    label_100D_0EAC_10F7C_19955:
        CheckExternalEvents(cs1, 0x0EAC);
        // 100D:0EAC call near 0x181E
        NearCall(cs1, 0x0EAF, unknown_100D_181E_118EE);
    label_100D_0EAF_10F7F_19957:
        CheckExternalEvents(cs1, 0x0EAF);
        // 100D:0EAF mov AL,4
        AL = (byte)0x04;
        // 100D:0EB1 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:0EB3 mov BP,0x0ED0
        BP = (ushort)0x0ED0;
        // 100D:0EB6 jmp near 0xC108
        if (JumpDispatcher.Jump(unknown_100D_C108_1C1D8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_0EB9_10F89_33358:
        CheckExternalEvents(cs1, 0x0EB9);
        // 100D:0EB9 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:0EBB mov byte ptr DS:[0x47C3],AL
        UInt8[DS, (ushort)0x47C3] = AL;
        // 100D:0EBE call near 0xB2BE
        NearCall(cs1, 0x0EC1, unknown_100D_B2BE_1B38E);
    label_100D_0EC1_10F91_33362:
        CheckExternalEvents(cs1, 0x0EC1);
        // 100D:0EC1 mov byte ptr DS:[0x47A6],0xFF
        UInt8[DS, (ushort)0x47A6] = (byte)0xFF;
        // 100D:0EC6 mov AL,4
        AL = (byte)0x04;
        // 100D:0EC8 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:0ECA call near 0x189A
        NearCall(cs1, 0x0ECD, unknown_100D_189A_1196A);
    label_100D_0ECD_10F9D_33367:
        CheckExternalEvents(cs1, 0x0ECD);
        // 100D:0ECD jmp near 0x2DB1
        if (JumpDispatcher.Jump(unknown_100D_2DB1_12E81, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_0F48_11018_27958:
        CheckExternalEvents(cs1, 0x0F48);
        // 100D:0F48 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:0F4B mov BX,AX
        BX = AX;
        // 100D:0F4D and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:0F4F cmp AL,0x0C
        Alu8.Sub(AL, (byte)0x0C);
        // 100D:0F51 jae short 0x0F66
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:0F51");
        }
    label_100D_0F53_11023_27964:
        CheckExternalEvents(cs1, 0x0F53);
        // 100D:0F53 push BX
        Stack.Push16(BX);
        // 100D:0F54 cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:0F56 jae short 0x0F5F
        if (!CarryFlag)
        {
            goto label_100D_0F5F_1102F_27968;
        }
    label_100D_0F58_11028_36572:
        CheckExternalEvents(cs1, 0x0F58);
        // 100D:0F58 mov AX,BX
        AX = BX;
        // 100D:0F5A add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:0F5C call near 0x0FB2
        NearCall(cs1, 0x0F5F, unknown_100D_0FB2_11082);
    label_100D_0F5F_1102F_27968:
        CheckExternalEvents(cs1, 0x0F5F);
        // 100D:0F5F pop AX
        AX = Stack.Pop16();
        // 100D:0F60 and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:0F62 or AL,0x0C
        AL = Alu8.Or(AL, (byte)0x0C);
        // 100D:0F64 jmp short 0x0F84
        goto label_100D_0F84_11054_27973;
    label_100D_0F67_11037_32283:
        CheckExternalEvents(cs1, 0x0F67);
        // 100D:0F67 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:0F6A mov BX,AX
        BX = AX;
        // 100D:0F6C and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:0F6E cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:0F70 jb short 0x0F66
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:0F70");
        }
    label_100D_0F72_11042_32289:
        CheckExternalEvents(cs1, 0x0F72);
        // 100D:0F72 push BX
        Stack.Push16(BX);
        // 100D:0F73 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:0F75 jae short 0x0F7E
        if (!CarryFlag)
        {
            goto label_100D_0F7E_1104E_32293;
        }
    label_100D_0F77_11047_36552:
        CheckExternalEvents(cs1, 0x0F77);
        // 100D:0F77 mov AX,BX
        AX = BX;
        // 100D:0F79 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:0F7B call near 0x0FB2
        NearCall(cs1, 0x0F7E, unknown_100D_0FB2_11082);
    label_100D_0F7E_1104E_32293:
        CheckExternalEvents(cs1, 0x0F7E);
        // 100D:0F7E pop AX
        AX = Stack.Pop16();
        // 100D:0F7F and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:0F81 add AX,0x0010
        AX = Alu16.Add(AX, (ushort)0x0010);
    label_100D_0F84_11054_27973:
        CheckExternalEvents(cs1, 0x0F84);
        // 100D:0F84 cmp byte ptr DS:[0x002A],0x14
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x14);
        // 100D:0F89 jne short 0x0F95
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_0F95_11065, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_0F8B_1105B_32297:
        CheckExternalEvents(cs1, 0x0F8B);
        // 100D:0F8B call near 0x0F95
        NearCall(cs1, 0x0F8E, unknown_100D_0F95_11065);
    label_100D_0F8E_1105E_32302:
        CheckExternalEvents(cs1, 0x0F8E);
        // 100D:0F8E sub word ptr DS:[0xDC5A],0x03E8
        UInt16[DS, (ushort)0xDC5A] = Alu16.Sub(UInt16[DS, (ushort)0xDC5A], (ushort)0x03E8);
        // 100D:0F94 ret near
        return NearRet((ushort)0x0000);
    label_100D_0FA7_11077_28006:
        CheckExternalEvents(cs1, 0x0FA7);
        // 100D:0FA7 call near 0xDBB2
        NearCall(cs1, 0x0FAA, unknown_100D_DBB2_1DC82);
    label_100D_0FAA_1107A_28008:
        CheckExternalEvents(cs1, 0x0FAA);
        // 100D:0FAA mov AL,0x2A
        AL = (byte)0x2A;
        // 100D:0FAC call near 0x189A
        NearCall(cs1, 0x0FAF, unknown_100D_189A_1196A);
    label_100D_0FAF_1107F_28080:
        CheckExternalEvents(cs1, 0x0FAF);
        // 100D:0FAF jmp near 0xD763
        return unknown_100D_D763_1D833(0x0000);
    label_100D_0FC5_11095_36348:
        CheckExternalEvents(cs1, 0x0FC5);
        // 100D:0FC5 mov CX,0x0010
        CX = (ushort)0x0010;
    label_100D_0FC8_11098_36350:
        CheckExternalEvents(cs1, 0x0FC8);
        // 100D:0FC8 push CX
        Stack.Push16(CX);
        // 100D:0FC9 mov CX,1
        CX = (ushort)0x0001;
        // 100D:0FCC call near 0x0FD9
        NearCall(cs1, 0x0FCF, unknown_100D_0FD9_110A9);
    label_100D_0FCF_1109F_36353:
        CheckExternalEvents(cs1, 0x0FCF);
        // 100D:0FCF pop CX
        CX = Stack.Pop16();
        // 100D:0FD0 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:0FD5 loopne 0x0FC8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_100D_0FC8_11098_36350;
        }
    label_100D_0FD7_110A7_36520:
        CheckExternalEvents(cs1, 0x0FD7);
        // 100D:0FD7 jmp short 0x0FA7
        goto label_100D_0FA7_11077_28006;
    label_100D_1877_11947_13218:
        CheckExternalEvents(cs1, 0x1877);
        // 100D:1877 call near 0xD2BD
        NearCall(cs1, 0x187A, unknown_100D_D2BD_1D38D);
    label_100D_187A_1194A_13233:
        CheckExternalEvents(cs1, 0x187A);
        // 100D:187A call near 0x5ADF
        NearCall(cs1, 0x187D, unknown_100D_5ADF_15BAF);
    label_100D_187D_1194D_13284:
        CheckExternalEvents(cs1, 0x187D);
        // 100D:187D mov AL,byte ptr DS:[0x28E8]
        AL = UInt8[DS, (ushort)0x28E8];
        // 100D:1880 mov byte ptr DS:[0x28E7],AL
        UInt8[DS, (ushort)0x28E7] = AL;
        // 100D:1883 call near 0xB930
        NearCall(cs1, 0x1886, unknown_100D_B930_1BA00);
    label_100D_1886_11956_13288:
        CheckExternalEvents(cs1, 0x1886);
        // 100D:1886 mov word ptr DS:[0x1C14],0x0080
        UInt16[DS, (ushort)0x1C14] = (ushort)0x0080;
        // 100D:188C mov word ptr DS:[0x1C22],0x0080
        UInt16[DS, (ushort)0x1C22] = (ushort)0x0080;
        // 100D:1892 mov BP,0xD75A
        BP = (ushort)0xD75A;
        // 100D:1895 call near 0xC097
        NearCall(cs1, 0x1898, unknown_100D_C097_1C167);
    label_100D_1898_11968_13512:
        CheckExternalEvents(cs1, 0x1898);
        // 100D:1898 mov AL,0x34
        AL = (byte)0x34;
        if (JumpDispatcher.Jump(unknown_100D_189A_1196A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_1B8D_11C5D_15178:
        CheckExternalEvents(cs1, 0x1B8D);
        // 100D:1B8D call near 0x1BEC
        NearCall(cs1, 0x1B90, unknown_100D_1BEC_11CBC);
    label_100D_1B90_11C60_15184:
        CheckExternalEvents(cs1, 0x1B90);
        // 100D:1B90 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:1B95 jne short 0x1BB2
        if (!ZeroFlag)
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1B97_11C67_15187:
        CheckExternalEvents(cs1, 0x1B97);
        // 100D:1B97 cmp byte ptr DS:[0x46EC],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EC], (byte)0x00);
        // 100D:1B9C je short 0x1BA1
        if (ZeroFlag)
        {
            goto label_100D_1BA1_11C71_15190;
        }
    label_100D_1B9E_11C6E_35968:
        CheckExternalEvents(cs1, 0x1B9E);
        // 100D:1B9E call near 0x5D6D
        NearCall(cs1, 0x1BA1, unknown_100D_5D6D_15E3D);
    label_100D_1BA1_11C71_15190:
        CheckExternalEvents(cs1, 0x1BA1);
        // 100D:1BA1 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:1BA5 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:1BA7 je short 0x1BB2
        if (ZeroFlag)
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1BA9_11C79_15194:
        CheckExternalEvents(cs1, 0x1BA9);
        // 100D:1BA9 cmp byte ptr DS:[0x473B],0
        Alu8.Sub(UInt8[DS, (ushort)0x473B], (byte)0x00);
        // 100D:1BAE js short 0x1BD2
        if (SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:1BAE");
        }
    label_100D_1BB0_11C80_15197:
        CheckExternalEvents(cs1, 0x1BB0);
        // 100D:1BB0 ja short 0x1BB8
        if (!(!CarryFlag && !ZeroFlag))
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1BB8_11C88_36514:
        CheckExternalEvents(cs1, 0x1BB8);
        // 100D:1BB8 cmp byte ptr DS:[0x00FB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], (byte)0x00);
        // 100D:1BBD js short 0x1BB2
        if (SignFlag)
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1BBF_11C8F_36517:
        CheckExternalEvents(cs1, 0x1BBF);
        // 100D:1BBF cmp byte ptr DS:[0x46DA],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DA], (byte)0x00);
        // 100D:1BC4 jne short 0x1BB2
        if (!ZeroFlag)
        {
            return unknown_100D_1BB2_11C82(0x0000);
        }
    label_100D_1BC6_11C96_38148:
        CheckExternalEvents(cs1, 0x1BC6);
        // 100D:1BC6 call near 0xDBB2
        NearCall(cs1, 0x1BC9, unknown_100D_DBB2_1DC82);
    label_100D_1BC9_11C99_38151:
        CheckExternalEvents(cs1, 0x1BC9);
        // 100D:1BC9 call near 0x1BB2
        NearCall(cs1, 0x1BCC, unknown_100D_1BB2_11C82);
    label_100D_1BCC_11C9C_38154:
        CheckExternalEvents(cs1, 0x1BCC);
        // 100D:1BCC call near 0x0B21
        NearCall(cs1, 0x1BCF, unknown_100D_0B21_10BF1);
    label_100D_1BCF_11C9F_38157:
        CheckExternalEvents(cs1, 0x1BCF);
        // 100D:1BCF jmp near 0x2DB1
        if (JumpDispatcher.Jump(unknown_100D_2DB1_12E81, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_241A_124EA_33014:
        CheckExternalEvents(cs1, 0x241A);
        // 100D:241A cmp word ptr DS:[0x47C4],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:241F je short 0x2426
        if (ZeroFlag)
        {
            goto label_100D_2426_124F6_33996;
        }
    label_100D_2421_124F1_33017:
        CheckExternalEvents(cs1, 0x2421);
        // 100D:2421 mov AL,1
        AL = (byte)0x01;
        // 100D:2423 jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_2426_124F6_33996:
        CheckExternalEvents(cs1, 0x2426);
        // 100D:2426 mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:242A call near 0x23E6
        NearCall(cs1, 0x242D, unknown_100D_23E6_124B6);
    label_100D_242D_124FD_34019:
        CheckExternalEvents(cs1, 0x242D);
        // 100D:242D mov AL,1
        AL = (byte)0x01;
        // 100D:242F jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_2432_12502_35333:
        CheckExternalEvents(cs1, 0x2432);
        // 100D:2432 cmp word ptr DS:[0x47C4],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:2437 je short 0x243E
        if (ZeroFlag)
        {
            goto label_100D_243E_1250E_37259;
        }
    label_100D_2439_12509_35336:
        CheckExternalEvents(cs1, 0x2439);
        // 100D:2439 mov AL,2
        AL = (byte)0x02;
        // 100D:243B jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_243E_1250E_37259:
        CheckExternalEvents(cs1, 0x243E);
        // 100D:243E mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:2442 mov BX,7
        BX = (ushort)0x0007;
        // 100D:2445 call near 0xE3B7
        NearCall(cs1, 0x2448, unknown_100D_E3B7_1E487);
    label_100D_2448_12518_37266:
        CheckExternalEvents(cs1, 0x2448);
        // 100D:2448 je short 0x246B
        if (ZeroFlag)
        {
            goto label_100D_246B_1253B_34057;
        }
    label_100D_244A_1251A_37269:
        CheckExternalEvents(cs1, 0x244A);
        // 100D:244A mov byte ptr DS:[0x009D],0
        UInt8[DS, (ushort)0x009D] = (byte)0x00;
        // 100D:244F mov AL,2
        AL = (byte)0x02;
        // 100D:2451 jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_2453_12523_33002:
        CheckExternalEvents(cs1, 0x2453);
        // 100D:2453 cmp word ptr DS:[0x47C4],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:2458 je short 0x245F
        if (ZeroFlag)
        {
            goto label_100D_245F_1252F_34031;
        }
    label_100D_245A_1252A_33005:
        CheckExternalEvents(cs1, 0x245A);
        // 100D:245A mov AL,3
        AL = (byte)0x03;
        // 100D:245C jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_245F_1252F_34031:
        CheckExternalEvents(cs1, 0x245F);
        // 100D:245F mov DI,word ptr DS:[0x10B4]
        DI = UInt16[DS, (ushort)0x10B4];
        // 100D:2463 mov BX,3
        BX = (ushort)0x0003;
        // 100D:2466 call near 0xE3B7
        NearCall(cs1, 0x2469, unknown_100D_E3B7_1E487);
    label_100D_2469_12539_34035:
        CheckExternalEvents(cs1, 0x2469);
        // 100D:2469 jne short 0x2474
        if (!ZeroFlag)
        {
            goto label_100D_2474_12544_34037;
        }
    label_100D_246B_1253B_34057:
        CheckExternalEvents(cs1, 0x246B);
        // 100D:246B or byte ptr DS:[0x009E],0x10
        UInt8[DS, (ushort)0x009E] = Alu8.Or(UInt8[DS, (ushort)0x009E], (byte)0x10);
        // 100D:2470 mov AL,3
        AL = (byte)0x03;
        // 100D:2472 jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_2474_12544_34037:
        CheckExternalEvents(cs1, 0x2474);
        // 100D:2474 inc byte ptr DS:[0x009E]
        UInt8[DS, (ushort)0x009E] = Alu8.Inc(UInt8[DS, (ushort)0x009E]);
        // 100D:2478 and byte ptr DS:[0x009E],3
        UInt8[DS, (ushort)0x009E] = Alu8.And(UInt8[DS, (ushort)0x009E], (byte)0x03);
        // 100D:247D and AL,1
        AL = Alu8.And(AL, (byte)0x01);
        // 100D:247F add AL,byte ptr DS:[0x001A]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x001A]);
        // 100D:2483 sub AL,byte ptr DS:[DI+1]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)1)]);
        // 100D:2486 jb short 0x2491
        if (CarryFlag)
        {
            goto label_100D_2491_12561_34044;
        }
    label_100D_2488_12558_37516:
        CheckExternalEvents(cs1, 0x2488);
        // 100D:2488 mov byte ptr DS:[0x009D],0
        UInt8[DS, (ushort)0x009D] = (byte)0x00;
        // 100D:248D mov AL,3
        AL = (byte)0x03;
        // 100D:248F jmp short 0x2496
        goto label_100D_2496_12566_33008;
    label_100D_2491_12561_34044:
        CheckExternalEvents(cs1, 0x2491);
        // 100D:2491 call near 0x23D5
        NearCall(cs1, 0x2494, unknown_100D_23D5_124A5);
    label_100D_2494_12564_34055:
        CheckExternalEvents(cs1, 0x2494);
        // 100D:2494 mov AL,3
        AL = (byte)0x03;
    label_100D_2496_12566_33008:
        CheckExternalEvents(cs1, 0x2496);
        // 100D:2496 mov byte ptr DS:[0x009F],AL
        UInt8[DS, (ushort)0x009F] = AL;
        // 100D:2499 inc byte ptr DS:[0x001A]
        UInt8[DS, (ushort)0x001A] = Alu8.Inc(UInt8[DS, (ushort)0x001A]);
        // 100D:249D call near 0xD2E2
        NearCall(cs1, 0x24A0, unknown_100D_D2E2_1D3B2);
    label_100D_24A0_12570_33012:
        CheckExternalEvents(cs1, 0x24A0);
        // 100D:24A0 jmp near 0x9472
        goto label_100D_9472_19542_15581;
    label_100D_283A_1290A_31598:
        CheckExternalEvents(cs1, 0x283A);
        // 100D:283A xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:283C jmp short 0x2841
        goto label_100D_2841_12911_31601;
    label_100D_283E_1290E_38312:
        CheckExternalEvents(cs1, 0x283E);
        // 100D:283E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2840 dec AX
        AX = Alu16.Dec(AX);
    label_100D_2841_12911_31601:
        CheckExternalEvents(cs1, 0x2841);
        // 100D:2841 mov byte ptr DS:[0x00DB],AL
        UInt8[DS, (ushort)0x00DB] = AL;
        // 100D:2844 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:2846 add AL,0x2A
        AL = Alu8.Add(AL, (byte)0x2A);
        // 100D:2848 call near 0xAB45
        NearCall(cs1, 0x284B, unknown_100D_AB45_1AC15);
    label_100D_284B_1291B_31606:
        CheckExternalEvents(cs1, 0x284B);
        // 100D:284B call near 0x98B2
        NearCall(cs1, 0x284E, unknown_100D_98B2_19982);
    label_100D_284E_1291E_31608:
        CheckExternalEvents(cs1, 0x284E);
        // 100D:284E call near 0x2806
        NearCall(cs1, 0x2851, unknown_100D_2806_128D6);
    label_100D_2851_12921_31694:
        CheckExternalEvents(cs1, 0x2851);
        // 100D:2851 call near 0x2A7F
        NearCall(cs1, 0x2854, unknown_100D_2A7F_12B4F);
    label_100D_2854_12924_31703:
        CheckExternalEvents(cs1, 0x2854);
        // 100D:2854 call near 0x3AE9
        NearCall(cs1, 0x2857, unknown_100D_3AE9_13BB9);
    label_100D_2857_12927_31705:
        CheckExternalEvents(cs1, 0x2857);
        // 100D:2857 mov byte ptr DS:[0x00E9],0
        UInt8[DS, (ushort)0x00E9] = (byte)0x00;
        // 100D:285C push DS
        Stack.Push16(DS);
        // 100D:285D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:285E mov DI,0x1FC3
        DI = (ushort)0x1FC3;
        // 100D:2861 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:2863 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:2864 mov SI,0x1179
        SI = (ushort)0x1179;
        // 100D:2867 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:2869 mov CL,byte ptr DS:[0x00C8]
        CL = UInt8[DS, (ushort)0x00C8];
        // 100D:286D add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:286F add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:2871 mov BL,byte ptr DS:[0x00DB]
        BL = UInt8[DS, (ushort)0x00DB];
    label_100D_2875_12945_31718:
        CheckExternalEvents(cs1, 0x2875);
        // 100D:2875 sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:2878 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:287A mov AH,AL
        AH = AL;
        // 100D:287C xor AH,BL
        AH = Alu8.Xor(AH, BL);
        // 100D:287E js short 0x288B
        if (SignFlag)
        {
            goto label_100D_288B_1295B_31729;
        }
    label_100D_2880_12950_31723:
        CheckExternalEvents(cs1, 0x2880);
        // 100D:2880 and AX,0x003F
        AX = Alu16.And(AX, (ushort)0x003F);
        // 100D:2883 add AX,0x0078
        AX = Alu16.Add(AX, (ushort)0x0078);
        // 100D:2886 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2887 mov AX,0x290B
        AX = (ushort)0x290B;
        // 100D:288A stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_100D_288B_1295B_31729:
        CheckExternalEvents(cs1, 0x288B);
        // 100D:288B loop 0x2875
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2875_12945_31718;
        }
    label_100D_288D_1295D_31730:
        CheckExternalEvents(cs1, 0x288D);
        // 100D:288D mov AX,0x00A3
        AX = (ushort)0x00A3;
        // 100D:2890 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2891 mov AX,0x29D4
        AX = (ushort)0x29D4;
        // 100D:2894 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2895 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2897 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2898 mov BP,0x1FC2
        BP = (ushort)0x1FC2;
        // 100D:289B mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:289E jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_290B_129DB_31740:
        CheckExternalEvents(cs1, 0x290B);
        // 100D:290B mov AL,byte ptr DS:[0x1FC3]
        AL = UInt8[DS, (ushort)0x1FC3];
        // 100D:290E cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:290F shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:2911 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:2913 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:2915 inc CX
        CX = Alu16.Inc(CX);
        // 100D:2916 mov SI,0x1179
        SI = (ushort)0x1179;
        // 100D:2919 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:291B mov AL,byte ptr DS:[0x00C8]
        AL = UInt8[DS, (ushort)0x00C8];
        // 100D:291E add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:2920 add SI,AX
        SI = Alu16.Add(SI, AX);
    label_100D_2922_129F2_31752:
        CheckExternalEvents(cs1, 0x2922);
        // 100D:2922 sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:2925 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:2927 xor AL,byte ptr DS:[0x00DB]
        AL = Alu8.Xor(AL, UInt8[DS, (ushort)0x00DB]);
        // 100D:292B js short 0x2922
        if (SignFlag)
        {
            goto label_100D_2922_129F2_31752;
        }
    label_100D_292D_129FD_31756:
        CheckExternalEvents(cs1, 0x292D);
        // 100D:292D loop 0x2922
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_2922_129F2_31752;
        }
    label_100D_292F_129FF_31758:
        CheckExternalEvents(cs1, 0x292F);
        // 100D:292F mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:2931 mov byte ptr DS:[0x0024],AH
        UInt8[DS, (ushort)0x0024] = AH;
        // 100D:2935 and AL,0x3F
        AL = Alu8.And(AL, (byte)0x3F);
        // 100D:2937 cmp byte ptr DS:[0x00DB],0
        Alu8.Sub(UInt8[DS, (ushort)0x00DB], (byte)0x00);
        // 100D:293C jne short 0x2956
        if (!ZeroFlag)
        {
            goto label_100D_2956_12A26_31773;
        }
    label_100D_293E_12A0E_31764:
        CheckExternalEvents(cs1, 0x293E);
        // 100D:293E or byte ptr DS:[SI],0x80
        UInt8[DS, SI] = Alu8.Or(UInt8[DS, SI], (byte)0x80);
        // 100D:2941 dec byte ptr DS:[0x00C9]
        UInt8[DS, (ushort)0x00C9] = Alu8.Dec(UInt8[DS, (ushort)0x00C9]);
        // 100D:2945 cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:2947 jne short 0x2956
        if (!ZeroFlag)
        {
            goto label_100D_2956_12A26_31773;
        }
    label_100D_2949_12A19_31769:
        CheckExternalEvents(cs1, 0x2949);
        // 100D:2949 sub AH,2
        AH = Alu8.Sub(AH, (byte)0x02);
        // 100D:294C cmp AH,2
        Alu8.Sub(AH, (byte)0x02);
        // 100D:294F jae short 0x2956
        if (!CarryFlag)
        {
            goto label_100D_2956_12A26_31773;
        }
    label_100D_2951_12A21_32847:
        CheckExternalEvents(cs1, 0x2951);
        // 100D:2951 or byte ptr DS:[0x00BF],0x20
        UInt8[DS, (ushort)0x00BF] = Alu8.Or(UInt8[DS, (ushort)0x00BF], (byte)0x20);
    label_100D_2956_12A26_31773:
        CheckExternalEvents(cs1, 0x2956);
        // 100D:2956 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:2958 cmp AL,byte ptr DS:[0x47A9]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x47A9]);
        // 100D:295C je short 0x2970
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:295C");
        }
    label_100D_295E_12A2E_31777:
        CheckExternalEvents(cs1, 0x295E);
        // 100D:295E push AX
        Stack.Push16(AX);
        // 100D:295F call near 0x28E1
        NearCall(cs1, 0x2962, unknown_100D_28E1_129B1);
    label_100D_2962_12A32_31788:
        CheckExternalEvents(cs1, 0x2962);
        // 100D:2962 pop AX
        AX = Stack.Pop16();
        // 100D:2963 push AX
        Stack.Push16(AX);
        // 100D:2964 add AX,0x001A
        AX = Alu16.Add(AX, (ushort)0x001A);
        // 100D:2967 call near 0xAB45
        NearCall(cs1, 0x296A, unknown_100D_AB45_1AC15);
    label_100D_296A_12A3A_31793:
        CheckExternalEvents(cs1, 0x296A);
        // 100D:296A pop AX
        AX = Stack.Pop16();
        // 100D:296B push AX
        Stack.Push16(AX);
        // 100D:296C call near 0x28A1
        NearCall(cs1, 0x296F, unknown_100D_28A1_12971);
    label_100D_296F_12A3F_31909:
        CheckExternalEvents(cs1, 0x296F);
        // 100D:296F pop AX
        AX = Stack.Pop16();
        // 100D:2970 mov byte ptr DS:[0x00E9],AL
        UInt8[DS, (ushort)0x00E9] = AL;
        // 100D:2973 xor BL,BL
        BL = Alu8.Xor(BL, BL);
        // 100D:2975 xchg BL,byte ptr DS:[0x46D9]
        ushort xchgOffset_100D_2975_12A45 = (ushort)0x46D9;
        byte temp_100D_2975_12A45 = BL;
        BL = UInt8[DS, xchgOffset_100D_2975_12A45];
        UInt8[DS, xchgOffset_100D_2975_12A45] = unchecked((byte)temp_100D_2975_12A45);
        // 100D:2979 push BX
        Stack.Push16(BX);
        // 100D:297A call near 0x96F1
        NearCall(cs1, 0x297D, unknown_100D_96F1_197C1);
    label_100D_297D_12A4D_31916:
        CheckExternalEvents(cs1, 0x297D);
        // 100D:297D call near 0x98F5
        NearCall(cs1, 0x2980, unknown_100D_98F5_199C5);
    label_100D_2980_12A50_31918:
        CheckExternalEvents(cs1, 0x2980);
        // 100D:2980 mov byte ptr DS:[0x1C06],0x80
        UInt8[DS, (ushort)0x1C06] = (byte)0x80;
        // 100D:2985 mov BP,0x1FF2
        BP = (ushort)0x1FF2;
        // 100D:2988 mov BX,0x2997
        BX = (ushort)0x2997;
        // 100D:298B call near 0xD323
        NearCall(cs1, 0x298E, unknown_100D_D323_1D3F3);
    label_100D_298E_12A5E_31923:
        CheckExternalEvents(cs1, 0x298E);
        // 100D:298E pop AX
        AX = Stack.Pop16();
        // 100D:298F mov byte ptr DS:[0x46D9],AL
        UInt8[DS, (ushort)0x46D9] = AL;
    label_100D_2992_12A62_31926:
        CheckExternalEvents(cs1, 0x2992);
        // 100D:2992 ret near
        return NearRet((ushort)0x0000);
    label_100D_2993_12A63_31927:
        CheckExternalEvents(cs1, 0x2993);
        // 100D:2993 mov AL,6
        AL = (byte)0x06;
        // 100D:2995 jmp short 0x2999
    label_100D_2999_12A69_31930:
        CheckExternalEvents(cs1, 0x2999);
        // 100D:2999 mov BL,byte ptr DS:[0x00C9]
        BL = UInt8[DS, (ushort)0x00C9];
        // 100D:299D mov byte ptr DS:[0x00EB],BL
        UInt8[DS, (ushort)0x00EB] = BL;
        // 100D:29A1 cmp byte ptr DS:[0x47A9],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A9], (byte)0x00);
        // 100D:29A6 je short 0x2992
        if (ZeroFlag)
        {
            goto label_100D_2992_12A62_31926;
        }
    label_100D_29A8_12A78_31935:
        CheckExternalEvents(cs1, 0x29A8);
        // 100D:29A8 push AX
        Stack.Push16(AX);
        // 100D:29A9 call near 0x97CF
        NearCall(cs1, 0x29AC, unknown_100D_97CF_1989F);
    label_100D_29AC_12A7C_31940:
        CheckExternalEvents(cs1, 0x29AC);
        // 100D:29AC call near 0x98F5
        NearCall(cs1, 0x29AF, unknown_100D_98F5_199C5);
    label_100D_29AF_12A7F_31942:
        CheckExternalEvents(cs1, 0x29AF);
        // 100D:29AF call near 0xC08E
        NearCall(cs1, 0x29B2, unknown_100D_C08E_1C15E);
    label_100D_29B2_12A82_31944:
        CheckExternalEvents(cs1, 0x29B2);
        // 100D:29B2 call near 0x28B5
        NearCall(cs1, 0x29B5, unknown_100D_28B5_12985);
    label_100D_29B5_12A85_31946:
        CheckExternalEvents(cs1, 0x29B5);
        // 100D:29B5 call near 0x28E1
        NearCall(cs1, 0x29B8, unknown_100D_28E1_129B1);
    label_100D_29B8_12A88_31975:
        CheckExternalEvents(cs1, 0x29B8);
        // 100D:29B8 mov byte ptr DS:[0x0024],0
        UInt8[DS, (ushort)0x0024] = (byte)0x00;
        // 100D:29BD pop AX
        AX = Stack.Pop16();
        // 100D:29BE mov byte ptr DS:[0x0023],AL
        UInt8[DS, (ushort)0x0023] = AL;
        // 100D:29C1 call near 0xD316
        NearCall(cs1, 0x29C4, unknown_100D_D316_1D3E6);
    label_100D_29C4_12A94_31980:
        CheckExternalEvents(cs1, 0x29C4);
        // 100D:29C4 call near 0x2EB2
        NearCall(cs1, 0x29C7, unknown_100D_2EB2_12F82);
    label_100D_29C7_12A97_31985:
        CheckExternalEvents(cs1, 0x29C7);
        // 100D:29C7 call near 0x2DD3
        NearCall(cs1, 0x29CA, unknown_100D_2DD3_12EA3);
    label_100D_29CA_12A9A_31987:
        CheckExternalEvents(cs1, 0x29CA);
        // 100D:29CA cmp byte ptr DS:[0x47A7],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A7], (byte)0x00);
        // 100D:29CF jne short 0x2992
        if (!ZeroFlag)
        {
            goto label_100D_2992_12A62_31926;
        }
    label_100D_29D1_12AA1_31990:
        CheckExternalEvents(cs1, 0x29D1);
        // 100D:29D1 jmp near 0xD280
        if (JumpDispatcher.Jump(unknown_100D_D280_1D350, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_29D4_12AA4_36734:
        CheckExternalEvents(cs1, 0x29D4);
        // 100D:29D4 mov AX,0x0029
        AX = (ushort)0x0029;
        // 100D:29D7 call near 0xAB45
        NearCall(cs1, 0x29DA, unknown_100D_AB45_1AC15);
    label_100D_29DA_12AAA_36737:
        CheckExternalEvents(cs1, 0x29DA);
        // 100D:29DA mov byte ptr DS:[0x47A6],0xFF
        UInt8[DS, (ushort)0x47A6] = (byte)0xFF;
        // 100D:29DF mov BP,0x2DBF
        BP = (ushort)0x2DBF;
        // 100D:29E2 call near 0xC097
        NearCall(cs1, 0x29E5, unknown_100D_C097_1C167);
    label_100D_29E5_12AB5_36741:
        CheckExternalEvents(cs1, 0x29E5);
        // 100D:29E5 call near 0xD316
        NearCall(cs1, 0x29E8, unknown_100D_D316_1D3E6);
    label_100D_29E8_12AB8_36743:
        CheckExternalEvents(cs1, 0x29E8);
        // 100D:29E8 call near 0xD280
        NearCall(cs1, 0x29EB, unknown_100D_D280_1D350);
    label_100D_29EB_12ABB_36745:
        CheckExternalEvents(cs1, 0x29EB);
        // 100D:29EB jmp near 0xABA9
        return unknown_100D_ABA9_1AC79(0x0000);
    label_100D_3F27_13FF7_19793:
        CheckExternalEvents(cs1, 0x3F27);
        // 100D:3F27 push BP
        Stack.Push16(BP);
        // 100D:3F28 call near 0xD2BD
        NearCall(cs1, 0x3F2B, unknown_100D_D2BD_1D38D);
    label_100D_3F2B_13FFB_19796:
        CheckExternalEvents(cs1, 0x3F2B);
        // 100D:3F2B call near 0xAC30
        NearCall(cs1, 0x3F2E, unknown_100D_AC30_1AD00);
    label_100D_3F2E_13FFE_19798:
        CheckExternalEvents(cs1, 0x3F2E);
        // 100D:3F2E call near 0xA7A5
        NearCall(cs1, 0x3F31, unknown_100D_A7A5_1A875);
    label_100D_3F31_14001_19800:
        CheckExternalEvents(cs1, 0x3F31);
        // 100D:3F31 pop BP
        BP = Stack.Pop16();
        // 100D:3F32 mov byte ptr DS:[0x47A9],0
        UInt8[DS, (ushort)0x47A9] = (byte)0x00;
        // 100D:3F37 mov byte ptr DS:[0x0026],0
        UInt8[DS, (ushort)0x0026] = (byte)0x00;
        // 100D:3F3C mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:3F40 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:3F44 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:3F47 je short 0x3F67
        if (ZeroFlag)
        {
            goto label_100D_3F67_14037_19808;
        }
    label_100D_3F49_14019_28082:
        CheckExternalEvents(cs1, 0x3F49);
        // 100D:3F49 mov AL,byte ptr DS:[0x4735]
        AL = UInt8[DS, (ushort)0x4735];
        // 100D:3F4C and AL,0x7F
        AL = Alu8.And(AL, (byte)0x7F);
        // 100D:3F4E inc AL
        AL = Alu8.Inc(AL);
        // 100D:3F50 jns short 0x3F54
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3F50");
        }
    label_100D_3F54_14024_28087:
        CheckExternalEvents(cs1, 0x3F54);
        // 100D:3F54 or AL,0x80
        AL = Alu8.Or(AL, (byte)0x80);
        // 100D:3F56 mov byte ptr DS:[0x4735],AL
        UInt8[DS, (ushort)0x4735] = AL;
        // 100D:3F59 cmp byte ptr DS:[0x00F4],0x14
        Alu8.Sub(UInt8[DS, (ushort)0x00F4], (byte)0x14);
        // 100D:3F5E jae short 0x3F64
        if (!CarryFlag)
        {
            goto label_100D_3F64_14034_28094;
        }
    label_100D_3F60_14030_28092:
        CheckExternalEvents(cs1, 0x3F60);
        // 100D:3F60 inc byte ptr DS:[0x00F4]
        UInt8[DS, (ushort)0x00F4] = Alu8.Inc(UInt8[DS, (ushort)0x00F4]);
    label_100D_3F64_14034_28094:
        CheckExternalEvents(cs1, 0x3F64);
        // 100D:3F64 jmp near 0x3FF5
        goto label_100D_3FF5_140C5_27847;
    label_100D_3F67_14037_19808:
        CheckExternalEvents(cs1, 0x3F67);
        // 100D:3F67 call near 0x3EFE
        NearCall(cs1, 0x3F6A, unknown_100D_3EFE_13FCE);
    label_100D_3F6A_1403A_19810:
        CheckExternalEvents(cs1, 0x3F6A);
        // 100D:3F6A mov DL,byte ptr SS:[BP+SI]
        DL = UInt8[SS, (ushort)(BP + SI)];
        // 100D:3F6C or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:3F6E je short 0x3F14
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:3F6E");
        }
    label_100D_3F70_14040_19814:
        CheckExternalEvents(cs1, 0x3F70);
        // 100D:3F70 js short 0x3FD2
        if (SignFlag)
        {
            goto label_100D_3FD2_140A2_27835;
        }
    label_100D_3F72_14042_19816:
        CheckExternalEvents(cs1, 0x3F72);
        // 100D:3F72 cmp byte ptr DS:[0x000B],1
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x01);
        // 100D:3F77 jne short 0x3F84
        if (!ZeroFlag)
        {
            goto label_100D_3F84_14054_19819;
        }
    label_100D_3F79_14049_22853:
        CheckExternalEvents(cs1, 0x3F79);
        // 100D:3F79 call near 0xE270
        NearCall(cs1, 0x3F7C, unknown_100D_E270_1E340);
    label_100D_3F7C_1404C_22855:
        CheckExternalEvents(cs1, 0x3F7C);
        // 100D:3F7C mov CL,2
        CL = (byte)0x02;
        // 100D:3F7E call near 0xB389
        NearCall(cs1, 0x3F81, unknown_100D_B389_1B459);
    label_100D_3F81_14051_22858:
        CheckExternalEvents(cs1, 0x3F81);
        // 100D:3F81 call near 0xE283
        NearCall(cs1, 0x3F84, unknown_100D_E283_1E353);
    label_100D_3F84_14054_19819:
        CheckExternalEvents(cs1, 0x3F84);
        // 100D:3F84 mov SI,word ptr DS:[0x114E]
        SI = UInt16[DS, (ushort)0x114E];
        // 100D:3F88 test byte ptr DS:[SI+0x0A],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x10);
        // 100D:3F8C jne short 0x3FAA
        if (!ZeroFlag)
        {
            goto label_100D_3FAA_1407A_19823;
        }
    label_100D_3F8E_1405E_22860:
        CheckExternalEvents(cs1, 0x3F8E);
        // 100D:3F8E or byte ptr DS:[SI+0x0A],0x10
        UInt8[DS, (ushort)(SI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x10);
        // 100D:3F92 cmp DH,0x20
        Alu8.Sub(DH, (byte)0x20);
        // 100D:3F95 adc byte ptr DS:[0x0025],0
        UInt8[DS, (ushort)0x0025] = Alu8.Adc(UInt8[DS, (ushort)0x0025], (byte)0x00);
        // 100D:3F9A mov byte ptr DS:[0x0026],0xFF
        UInt8[DS, (ushort)0x0026] = (byte)0xFF;
        // 100D:3F9F call near 0xE270
        NearCall(cs1, 0x3FA2, unknown_100D_E270_1E340);
    label_100D_3FA2_14072_22866:
        CheckExternalEvents(cs1, 0x3FA2);
        // 100D:3FA2 mov CL,3
        CL = (byte)0x03;
        // 100D:3FA4 call near 0xB389
        NearCall(cs1, 0x3FA7, unknown_100D_B389_1B459);
    label_100D_3FA7_14077_22869:
        CheckExternalEvents(cs1, 0x3FA7);
        // 100D:3FA7 call near 0xE283
        NearCall(cs1, 0x3FAA, unknown_100D_E283_1E353);
    label_100D_3FAA_1407A_19823:
        CheckExternalEvents(cs1, 0x3FAA);
        // 100D:3FAA mov byte ptr DS:[0x000C],DL
        UInt8[DS, (ushort)0x000C] = DL;
        // 100D:3FAE mov byte ptr DS:[0x0023],1
        UInt8[DS, (ushort)0x0023] = (byte)0x01;
        // 100D:3FB3 call near 0xA1C4
        NearCall(cs1, 0x3FB6, unknown_100D_A1C4_1A294);
    label_100D_3FB6_14086_19827:
        CheckExternalEvents(cs1, 0x3FB6);
        // 100D:3FB6 push BX
        Stack.Push16(BX);
        // 100D:3FB7 push DX
        Stack.Push16(DX);
        // 100D:3FB8 call near 0x36D3
        NearCall(cs1, 0x3FBB, unknown_100D_36D3_137A3);
    label_100D_3FBB_1408B_19888:
        CheckExternalEvents(cs1, 0x3FBB);
        // 100D:3FBB pop DX
        DX = Stack.Pop16();
        // 100D:3FBC pop BX
        BX = Stack.Pop16();
        // 100D:3FBD call near 0xA1E2
        NearCall(cs1, 0x3FC0, unknown_100D_A1E2_1A2B2);
    label_100D_3FC0_14090_19892:
        CheckExternalEvents(cs1, 0x3FC0);
        // 100D:3FC0 je short 0x3FC3
        if (ZeroFlag)
        {
            goto label_100D_3FC3_14093_19894;
        }
    label_100D_3FC2_14092_32912:
        CheckExternalEvents(cs1, 0x3FC2);
        // 100D:3FC2 ret near
        return NearRet((ushort)0x0000);
    label_100D_3FC3_14093_19894:
        CheckExternalEvents(cs1, 0x3FC3);
        // 100D:3FC3 push BX
        Stack.Push16(BX);
        // 100D:3FC4 push DX
        Stack.Push16(DX);
        // 100D:3FC5 call near 0xABD5
        NearCall(cs1, 0x3FC8, unknown_100D_ABD5_1ACA5);
    label_100D_3FC8_14098_19904:
        CheckExternalEvents(cs1, 0x3FC8);
        // 100D:3FC8 pop DX
        DX = Stack.Pop16();
        // 100D:3FC9 pop BX
        BX = Stack.Pop16();
        // 100D:3FCA mov byte ptr DS:[0x0023],5
        UInt8[DS, (ushort)0x0023] = (byte)0x05;
        // 100D:3FCF jmp near 0x4057
        if (JumpDispatcher.Jump(unknown_100D_4057_14127, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_3FD2_140A2_27835:
        CheckExternalEvents(cs1, 0x3FD2);
        // 100D:3FD2 mov byte ptr DS:[0x00E7],0
        UInt8[DS, (ushort)0x00E7] = (byte)0x00;
        // 100D:3FD7 xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 100D:3FD9 neg DL
        DL = Alu8.Sub((byte)0x00, DL);
        CarryFlag = DL != (byte)0x00;
        // 100D:3FDB mov BP,DX
        BP = DX;
        // 100D:3FDD xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:3FDF xchg SI,word ptr DS:[0x114E]
        ushort xchgOffset_100D_3FDF_140AF = (ushort)0x114E;
        ushort temp_100D_3FDF_140AF = SI;
        SI = UInt16[DS, xchgOffset_100D_3FDF_140AF];
        UInt16[DS, xchgOffset_100D_3FDF_140AF] = unchecked((ushort)temp_100D_3FDF_140AF);
        // 100D:3FE3 mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:3FE6 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:3FE9 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:3FEB mov byte ptr DS:[8],0xFF
        UInt8[DS, (ushort)0x0008] = (byte)0xFF;
        // 100D:3FF0 mov byte ptr DS:[9],0xFF
        UInt8[DS, (ushort)0x0009] = (byte)0xFF;
    label_100D_3FF5_140C5_27847:
        CheckExternalEvents(cs1, 0x3FF5);
        // 100D:3FF5 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:3FF7 mov AX,word ptr SS:[BP+0x1454]
        AX = UInt16[SS, (ushort)(BP + (short)5204)];
        // 100D:3FFB call near 0xB5CF
        NearCall(cs1, 0x3FFE, unknown_100D_B5CF_1B69F);
    label_100D_3FFE_140CE_27862:
        CheckExternalEvents(cs1, 0x3FFE);
        // 100D:3FFE or BH,BH
        BH = Alu8.Or(BH, BH);
        // 100D:4000 jne short 0x4057
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_4057_14127, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_4002_140D2_22563:
        CheckExternalEvents(cs1, 0x4002);
        // 100D:4002 mov AX,BX
        AX = BX;
        // 100D:4004 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:4005 mov BX,AX
        BX = AX;
        // 100D:4007 call near 0xB532
        NearCall(cs1, 0x400A, unknown_100D_B532_1B602);
    label_100D_400A_140DA_22568:
        CheckExternalEvents(cs1, 0x400A);
        // 100D:400A xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:400C test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:400E je short 0x4057
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:400E");
        }
    label_100D_4010_140E0_22572:
        CheckExternalEvents(cs1, 0x4010);
        // 100D:4010 call near 0x409A
        NearCall(cs1, 0x4013, unknown_100D_409A_1416A);
    label_100D_4013_140E3_22574:
        CheckExternalEvents(cs1, 0x4013);
        // 100D:4013 jne short 0x4057
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4013");
        }
    label_100D_4015_140E5_22576:
        CheckExternalEvents(cs1, 0x4015);
        // 100D:4015 cmp DX,word ptr DS:[SI+2]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:4018 jne short 0x4057
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_4057_14127, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_401A_140EA_22579:
        CheckExternalEvents(cs1, 0x401A);
        // 100D:401A mov AX,BX
        AX = BX;
        // 100D:401C cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:401D mov BX,AX
        BX = AX;
        // 100D:401F mov byte ptr DS:[0x4735],0
        UInt8[DS, (ushort)0x4735] = (byte)0x00;
        // 100D:4024 mov word ptr DS:[0x114E],SI
        UInt16[DS, (ushort)0x114E] = SI;
        // 100D:4028 mov word ptr DS:[0x1150],SI
        UInt16[DS, (ushort)0x1150] = SI;
        // 100D:402C mov DI,SI
        DI = SI;
        // 100D:402E call near 0x503C
        NearCall(cs1, 0x4031, unknown_100D_503C_1510C);
    label_100D_4031_14101_22599:
        CheckExternalEvents(cs1, 0x4031);
        // 100D:4031 mov word ptr DS:[0x009A],0
        UInt16[DS, (ushort)0x009A] = (ushort)0x0000;
        // 100D:4037 mov word ptr DS:[0x0098],0
        UInt16[DS, (ushort)0x0098] = (ushort)0x0000;
        // 100D:403D call near 0x425B
        NearCall(cs1, 0x4040, unknown_100D_425B_1432B);
    label_100D_4040_14110_22608:
        CheckExternalEvents(cs1, 0x4040);
        // 100D:4040 call near 0x40AE
        NearCall(cs1, 0x4043, unknown_100D_40AE_1417E);
    label_100D_4043_14113_22621:
        CheckExternalEvents(cs1, 0x4043);
        // 100D:4043 mov byte ptr DS:[8],DH
        UInt8[DS, (ushort)0x0008] = DH;
        // 100D:4047 mov byte ptr DS:[9],BH
        UInt8[DS, (ushort)0x0009] = BH;
        // 100D:404B cmp DH,0x20
        Alu8.Sub(DH, (byte)0x20);
        // 100D:404E jb short 0x4054
        if (CarryFlag)
        {
            goto label_100D_4054_14124_22626;
        }
    label_100D_4050_14120_26922:
        CheckExternalEvents(cs1, 0x4050);
        // 100D:4050 or byte ptr DS:[SI+0x0A],0x10
        UInt8[DS, (ushort)(SI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x10);
    label_100D_4054_14124_22626:
        CheckExternalEvents(cs1, 0x4054);
        // 100D:4054 call near 0x2170
        NearCall(cs1, 0x4057, unknown_100D_2170_12240);
        if (JumpDispatcher.Jump(unknown_100D_4057_14127, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_42D1_143A1_35084:
        CheckExternalEvents(cs1, 0x42D1);
        // 100D:42D1 call near 0x98B2
        NearCall(cs1, 0x42D4, unknown_100D_98B2_19982);
    label_100D_42D4_143A4_35086:
        CheckExternalEvents(cs1, 0x42D4);
        // 100D:42D4 call near 0x4285
        NearCall(cs1, 0x42D7, unknown_100D_4285_14355);
    label_100D_42D7_143A7_35117:
        CheckExternalEvents(cs1, 0x42D7);
        // 100D:42D7 jmp short 0x4305
        goto label_100D_4305_143D5_20675;
    label_100D_42D9_143A9_28190:
        CheckExternalEvents(cs1, 0x42D9);
        // 100D:42D9 mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:42DD mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:42E1 mov DL,1
        DL = (byte)0x01;
        // 100D:42E3 call near 0x4057
        NearCall(cs1, 0x42E6, unknown_100D_4057_14127);
    label_100D_42E6_143B6_28195:
        CheckExternalEvents(cs1, 0x42E6);
        // 100D:42E6 call near 0x186B
        NearCall(cs1, 0x42E9, unknown_100D_186B_1193B);
    label_100D_42E9_143B9_20659:
        CheckExternalEvents(cs1, 0x42E9);
        // 100D:42E9 call near 0x98B2
        NearCall(cs1, 0x42EC, unknown_100D_98B2_19982);
    label_100D_42EC_143BC_20661:
        CheckExternalEvents(cs1, 0x42EC);
        // 100D:42EC call near 0x38E1
        NearCall(cs1, 0x42EF, unknown_100D_38E1_139B1);
    label_100D_42EF_143BF_20668:
        CheckExternalEvents(cs1, 0x42EF);
        // 100D:42EF mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:42F2 call near 0xC13E
        NearCall(cs1, 0x42F5, unknown_100D_C13E_1C20E);
    label_100D_42F5_143C5_20671:
        CheckExternalEvents(cs1, 0x42F5);
        // 100D:42F5 mov byte ptr DS:[0x473E],1
        UInt8[DS, (ushort)0x473E] = (byte)0x01;
        // 100D:42FA mov byte ptr DS:[0x11C9],4
        UInt8[DS, (ushort)0x11C9] = (byte)0x04;
        // 100D:42FF mov word ptr DS:[0x487E],2
        UInt16[DS, (ushort)0x487E] = (ushort)0x0002;
    label_100D_4305_143D5_20675:
        CheckExternalEvents(cs1, 0x4305);
        // 100D:4305 mov BP,0x212E
        BP = (ushort)0x212E;
        // 100D:4308 call near 0x49EA
        NearCall(cs1, 0x430B, unknown_100D_49EA_14ABA);
    label_100D_430B_143DB_20690:
        CheckExternalEvents(cs1, 0x430B);
        // 100D:430B mov BX,0x4415
        BX = (ushort)0x4415;
        // 100D:430E call near 0xD323
        NearCall(cs1, 0x4311, unknown_100D_D323_1D3F3);
    label_100D_4311_143E1_20693:
        CheckExternalEvents(cs1, 0x4311);
        // 100D:4311 mov AX,0x1AC8
        AX = (ushort)0x1AC8;
        // 100D:4314 call near 0xD95E
        NearCall(cs1, 0x4317, unknown_100D_D95E_1DA2E);
    label_100D_4317_143E7_20696:
        CheckExternalEvents(cs1, 0x4317);
        // 100D:4317 call near 0x4ACA
        NearCall(cs1, 0x431A, unknown_100D_4ACA_14B9A);
    label_100D_431A_143EA_20698:
        CheckExternalEvents(cs1, 0x431A);
        // 100D:431A mov word ptr DS:[0x46FC],0
        UInt16[DS, (ushort)0x46FC] = (ushort)0x0000;
        // 100D:4320 call near 0x5B5D
        NearCall(cs1, 0x4323, unknown_100D_5B5D_15C2D);
    label_100D_4323_143F3_20701:
        CheckExternalEvents(cs1, 0x4323);
        // 100D:4323 mov byte ptr DS:[0x46EB],1
        UInt8[DS, (ushort)0x46EB] = (byte)0x01;
        // 100D:4328 mov SI,0x1CCA
        SI = (ushort)0x1CCA;
        // 100D:432B call near 0xD72B
        NearCall(cs1, 0x432E, unknown_100D_D72B_1D7FB);
    label_100D_432E_143FE_20705:
        CheckExternalEvents(cs1, 0x432E);
        // 100D:432E mov SI,0x149C
        SI = (ushort)0x149C;
        // 100D:4331 mov DI,0x46E3
        DI = (ushort)0x46E3;
        // 100D:4334 call near 0xDAAA
        NearCall(cs1, 0x4337, unknown_100D_DAAA_1DB7A);
    label_100D_4337_14407_20709:
        CheckExternalEvents(cs1, 0x4337);
        // 100D:4337 call near 0x5B99
        NearCall(cs1, 0x433A, unknown_100D_5B99_15C69);
    label_100D_433A_1440A_20711:
        CheckExternalEvents(cs1, 0x433A);
        // 100D:433A call near 0x439F
        NearCall(cs1, 0x433D, unknown_100D_439F_1446F);
    label_100D_433D_1440D_20731:
        CheckExternalEvents(cs1, 0x433D);
        // 100D:433D mov AX,0x02BC
        AX = (ushort)0x02BC;
        // 100D:4340 call near 0xAB4F
        NearCall(cs1, 0x4343, unknown_100D_AB4F_1AC1F);
    label_100D_4343_14413_20737:
        CheckExternalEvents(cs1, 0x4343);
        // 100D:4343 call near 0x4658
        NearCall(cs1, 0x4346, unknown_100D_4658_14728);
    label_100D_4346_14416_20767:
        CheckExternalEvents(cs1, 0x4346);
        // 100D:4346 mov word ptr DS:[0x46ED],0x4377
        UInt16[DS, (ushort)0x46ED] = (ushort)0x4377;
        // 100D:434C call near 0x5B93
        NearCall(cs1, 0x434F, unknown_100D_5B93_15C63);
    label_100D_434F_1441F_20770:
        CheckExternalEvents(cs1, 0x434F);
        // 100D:434F call near 0xB6C3
        NearCall(cs1, 0x4352, unknown_100D_B6C3_1B793);
    label_100D_4352_14422_20968:
        CheckExternalEvents(cs1, 0x4352);
        // 100D:4352 call near 0xC137
        NearCall(cs1, 0x4355, unknown_100D_C137_1C207);
    label_100D_4355_14425_20970:
        CheckExternalEvents(cs1, 0x4355);
        // 100D:4355 call near 0x5DCE
        NearCall(cs1, 0x4358, unknown_100D_5DCE_15E9E);
    label_100D_4358_14428_20975:
        CheckExternalEvents(cs1, 0x4358);
        // 100D:4358 cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:435D je short 0x436E
        if (ZeroFlag)
        {
            goto label_100D_436E_1443E_20986;
        }
    label_100D_435F_1442F_20978:
        CheckExternalEvents(cs1, 0x435F);
        // 100D:435F mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:4362 call near 0xC13E
        NearCall(cs1, 0x4365, unknown_100D_C13E_1C20E);
    label_100D_4365_14435_20981:
        CheckExternalEvents(cs1, 0x4365);
        // 100D:4365 mov SI,0x14C0
        SI = (ushort)0x14C0;
        // 100D:4368 call near 0xC21B
        NearCall(cs1, 0x436B, unknown_100D_C21B_1C2EB);
    label_100D_436B_1443B_20984:
        CheckExternalEvents(cs1, 0x436B);
        // 100D:436B call near 0xC0F4
        NearCall(cs1, 0x436E, unknown_100D_C0F4_1C1C4);
    label_100D_436E_1443E_20986:
        CheckExternalEvents(cs1, 0x436E);
        // 100D:436E call near 0xC4DD
        NearCall(cs1, 0x4371, unknown_100D_C4DD_1C5AD);
    label_100D_4371_14441_20988:
        CheckExternalEvents(cs1, 0x4371);
        // 100D:4371 call near 0x445D
        NearCall(cs1, 0x4374, unknown_100D_445D_1452D);
    label_100D_4374_14444_21066:
        CheckExternalEvents(cs1, 0x4374);
        // 100D:4374 jmp near 0xD280
        if (JumpDispatcher.Jump(unknown_100D_D280_1D350, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_4703_147D3_21483:
        CheckExternalEvents(cs1, 0x4703);
        // 100D:4703 call near 0x4944
        NearCall(cs1, 0x4706, unknown_100D_4944_14A14);
    label_100D_4706_147D6_21515:
        CheckExternalEvents(cs1, 0x4706);
        // 100D:4706 call near 0x38E1
        NearCall(cs1, 0x4709, unknown_100D_38E1_139B1);
    label_100D_4709_147D9_21517:
        CheckExternalEvents(cs1, 0x4709);
        // 100D:4709 mov AL,byte ptr DS:[0x11C9]
        AL = UInt8[DS, (ushort)0x11C9];
        // 100D:470C push AX
        Stack.Push16(AX);
        // 100D:470D shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:470F shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:4711 or byte ptr DS:[0x11C9],AL
        UInt8[DS, (ushort)0x11C9] = Alu8.Or(UInt8[DS, (ushort)0x11C9], AL);
        // 100D:4715 call near 0xAD5E
        NearCall(cs1, 0x4718, unknown_100D_AD5E_1AE2E);
    label_100D_4718_147E8_21528:
        CheckExternalEvents(cs1, 0x4718);
        // 100D:4718 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:471D je short 0x4727
        if (ZeroFlag)
        {
            goto label_100D_4727_147F7_21531;
        }
    label_100D_471F_147EF_40895:
        CheckExternalEvents(cs1, 0x471F);
        // 100D:471F mov byte ptr DS:[0x002B],0
        UInt8[DS, (ushort)0x002B] = (byte)0x00;
        // 100D:4724 call near 0x0B21
        NearCall(cs1, 0x4727, unknown_100D_0B21_10BF1);
    label_100D_4727_147F7_21531:
        CheckExternalEvents(cs1, 0x4727);
        // 100D:4727 call near 0xD2EA
        NearCall(cs1, 0x472A, unknown_100D_D2EA_1D3BA);
    label_100D_472A_147FA_21593:
        CheckExternalEvents(cs1, 0x472A);
        // 100D:472A call near 0x4D00
        NearCall(cs1, 0x472D, unknown_100D_4D00_14DD0);
    label_100D_472D_147FD_21595:
        CheckExternalEvents(cs1, 0x472D);
        // 100D:472D pop AX
        AX = Stack.Pop16();
        // 100D:472E test AL,3
        Alu8.And(AL, (byte)0x03);
        // 100D:4730 jne short 0x478F
        if (!ZeroFlag)
        {
            goto label_100D_478F_1485F_28263;
        }
    label_100D_4732_14802_21599:
        CheckExternalEvents(cs1, 0x4732);
        // 100D:4732 mov word ptr DS:[0x472B],0
        UInt16[DS, (ushort)0x472B] = (ushort)0x0000;
        // 100D:4738 push AX
        Stack.Push16(AX);
        // 100D:4739 call near 0x41C5
        NearCall(cs1, 0x473C, unknown_100D_41C5_14295);
    label_100D_473C_1480C_21611:
        CheckExternalEvents(cs1, 0x473C);
        // 100D:473C mov AL,byte ptr DS:[0x11C9]
        AL = UInt8[DS, (ushort)0x11C9];
        // 100D:473F and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:4741 dec AL
        AL = Alu8.Dec(AL);
        // 100D:4743 jne short 0x4748
        if (!ZeroFlag)
        {
            goto label_100D_4748_14818_21618;
        }
    label_100D_4745_14815_21616:
        CheckExternalEvents(cs1, 0x4745);
        // 100D:4745 call near 0x181E
        NearCall(cs1, 0x4748, unknown_100D_181E_118EE);
    label_100D_4748_14818_21618:
        CheckExternalEvents(cs1, 0x4748);
        // 100D:4748 call near 0xC474
        NearCall(cs1, 0x474B, unknown_100D_C474_1C544);
    label_100D_474B_1481B_21620:
        CheckExternalEvents(cs1, 0x474B);
        // 100D:474B call near 0x40D5
        NearCall(cs1, 0x474E, unknown_100D_40D5_141A5);
    label_100D_474E_1481E_21630:
        CheckExternalEvents(cs1, 0x474E);
        // 100D:474E pop AX
        AX = Stack.Pop16();
        // 100D:474F mov BL,byte ptr DS:[0x11C7]
        BL = UInt8[DS, (ushort)0x11C7];
        // 100D:4753 push BX
        Stack.Push16(BX);
        // 100D:4754 call near 0x4795
        NearCall(cs1, 0x4757, unknown_100D_4795_14865);
    label_100D_4757_14827_21818:
        CheckExternalEvents(cs1, 0x4757);
        // 100D:4757 pop AX
        AX = Stack.Pop16();
        // 100D:4758 mov byte ptr DS:[0x11C7],AL
        UInt8[DS, (ushort)0x11C7] = AL;
        // 100D:475B mov byte ptr DS:[8],0xFF
        UInt8[DS, (ushort)0x0008] = (byte)0xFF;
        // 100D:4760 call near 0x4B3B
        NearCall(cs1, 0x4763, unknown_100D_4B3B_14C0B);
    label_100D_4763_14833_21918:
        CheckExternalEvents(cs1, 0x4763);
        // 100D:4763 mov word ptr DS:[0x114E],0
        UInt16[DS, (ushort)0x114E] = (ushort)0x0000;
        // 100D:4769 mov word ptr DS:[0x4729],0
        UInt16[DS, (ushort)0x4729] = (ushort)0x0000;
        // 100D:476F cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:4774 js short 0x4779
        if (SignFlag)
        {
            goto label_100D_4779_14849_22113;
        }
    label_100D_4776_14846_21923:
        CheckExternalEvents(cs1, 0x4776);
        // 100D:4776 call near 0x2DBF
        NearCall(cs1, 0x4779, unknown_100D_2DBF_12E8F);
    label_100D_4779_14849_22113:
        CheckExternalEvents(cs1, 0x4779);
        // 100D:4779 call near 0x4AB8
        NearCall(cs1, 0x477C, unknown_100D_4AB8_14B88);
    label_100D_477C_1484C_22118:
        CheckExternalEvents(cs1, 0x477C);
        // 100D:477C mov AL,byte ptr DS:[0x11C9]
        AL = UInt8[DS, (ushort)0x11C9];
        // 100D:477F and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:4781 dec AL
        AL = Alu8.Dec(AL);
        // 100D:4783 jne short 0x478F
        if (!ZeroFlag)
        {
            goto label_100D_478F_1485F_28263;
        }
    label_100D_4785_14855_22123:
        CheckExternalEvents(cs1, 0x4785);
        // 100D:4785 mov DI,word ptr DS:[0x1150]
        DI = UInt16[DS, (ushort)0x1150];
        // 100D:4789 dec byte ptr DS:[DI+0x15]
        UInt8[DS, (ushort)(DI + (sbyte)21)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (sbyte)21)]);
        // 100D:478C jmp near 0xAC14
        return unknown_100D_AC14_1ACE4(0x0000);
    label_100D_478F_1485F_28263:
        CheckExternalEvents(cs1, 0x478F);
        // 100D:478F call near 0x2EB2
        NearCall(cs1, 0x4792, unknown_100D_2EB2_12F82);
    label_100D_4792_14862_28265:
        CheckExternalEvents(cs1, 0x4792);
        // 100D:4792 jmp near 0xC0F4
        return unknown_100D_C0F4_1C1C4(0x0000);
    label_100D_497A_14A4A_28253:
        CheckExternalEvents(cs1, 0x497A);
        // 100D:497A call near 0x98E6
        NearCall(cs1, 0x497D, unknown_100D_98E6_199B6);
    label_100D_497D_14A4D_28255:
        CheckExternalEvents(cs1, 0x497D);
        // 100D:497D mov BP,0x212E
        BP = (ushort)0x212E;
        // 100D:4980 mov byte ptr DS:[0x4728],1
        UInt8[DS, (ushort)0x4728] = (byte)0x01;
        // 100D:4985 jmp near 0x430B
        goto label_100D_430B_143DB_20690;
    label_100D_4FC3_15093_22539:
        CheckExternalEvents(cs1, 0x4FC3);
        // 100D:4FC3 call near 0xE3CC
        NearCall(cs1, 0x4FC6, unknown_100D_E3CC_1E49C);
    label_100D_4FC6_15096_22541:
        CheckExternalEvents(cs1, 0x4FC6);
        // 100D:4FC6 mov byte ptr DS:[0x00C5],AL
        UInt8[DS, (ushort)0x00C5] = AL;
        // 100D:4FC9 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:4FCB mov byte ptr DS:[0x4727],AL
        UInt8[DS, (ushort)0x4727] = AL;
        // 100D:4FCE xchg AL,byte ptr DS:[0x11C9]
        ushort xchgOffset_100D_4FCE_1509E = (ushort)0x11C9;
        byte temp_100D_4FCE_1509E = AL;
        AL = UInt8[DS, xchgOffset_100D_4FCE_1509E];
        UInt8[DS, xchgOffset_100D_4FCE_1509E] = unchecked((byte)temp_100D_4FCE_1509E);
        // 100D:4FD2 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:4FD4 dec AL
        AL = Alu8.Dec(AL);
        // 100D:4FD6 jne short 0x4FDF
        if (!ZeroFlag)
        {
            goto label_100D_4FDF_150AF_22552;
        }
    label_100D_4FD8_150A8_22549:
        CheckExternalEvents(cs1, 0x4FD8);
        // 100D:4FD8 mov DI,word ptr DS:[0x11C5]
        DI = UInt16[DS, (ushort)0x11C5];
        // 100D:4FDC inc byte ptr DS:[DI+0x15]
        UInt8[DS, (ushort)(DI + (sbyte)21)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (sbyte)21)]);
    label_100D_4FDF_150AF_22552:
        CheckExternalEvents(cs1, 0x4FDF);
        // 100D:4FDF call near 0x4AC4
        NearCall(cs1, 0x4FE2, unknown_100D_4AC4_14B94);
    label_100D_4FE2_150B2_22553:
        CheckExternalEvents(cs1, 0x4FE2);
        // 100D:4FE2 call near 0xDBB2
        NearCall(cs1, 0x4FE5, unknown_100D_DBB2_1DC82);
    label_100D_4FE5_150B5_22555:
        CheckExternalEvents(cs1, 0x4FE5);
        // 100D:4FE5 call near 0xD717
        NearCall(cs1, 0x4FE8, unknown_100D_D717_1D7E7);
    label_100D_4FE8_150B8_22557:
        CheckExternalEvents(cs1, 0x4FE8);
        // 100D:4FE8 mov DI,word ptr DS:[0x11C5]
        DI = UInt16[DS, (ushort)0x11C5];
        // 100D:4FEC mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:4FEF mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:4FF2 mov word ptr DS:[0x11C5],0
        UInt16[DS, (ushort)0x11C5] = (ushort)0x0000;
        // 100D:4FF8 jmp near 0x4002
        goto label_100D_4002_140D2_22563;
    label_100D_4FFB_150CB_26013:
        CheckExternalEvents(cs1, 0x4FFB);
        // 100D:4FFB mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:5001 call near 0xCA01
        NearCall(cs1, 0x5004, unknown_100D_CA01_1CAD1);
    label_100D_5004_150D4_26016:
        CheckExternalEvents(cs1, 0x5004);
        // 100D:5004 mov byte ptr DS:[0x11C8],0
        UInt8[DS, (ushort)0x11C8] = (byte)0x00;
        // 100D:5009 mov CX,0x00C8
        CX = (ushort)0x00C8;
    label_100D_500C_150DC_26019:
        CheckExternalEvents(cs1, 0x500C);
        // 100D:500C push CX
        Stack.Push16(CX);
        // 100D:500D call near 0x4B3B
        NearCall(cs1, 0x5010, unknown_100D_4B3B_14C0B);
    label_100D_5010_150E0_26021:
        CheckExternalEvents(cs1, 0x5010);
        // 100D:5010 call near 0x407E
        NearCall(cs1, 0x5013, unknown_100D_407E_1414E);
    label_100D_5013_150E3_26023:
        CheckExternalEvents(cs1, 0x5013);
        // 100D:5013 call near 0xB58B
        NearCall(cs1, 0x5016, unknown_100D_B58B_1B65B);
    label_100D_5016_150E6_26025:
        CheckExternalEvents(cs1, 0x5016);
        // 100D:5016 mov SI,word ptr DS:[0x11C5]
        SI = UInt16[DS, (ushort)0x11C5];
        // 100D:501A cmp DI,word ptr DS:[SI+6]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:501D je short 0x5039
        if (ZeroFlag)
        {
            goto label_100D_5039_15109_26037;
        }
    label_100D_501F_150EF_26029:
        CheckExternalEvents(cs1, 0x501F);
        // 100D:501F mov byte ptr DS:[0x0023],0
        UInt8[DS, (ushort)0x0023] = (byte)0x00;
        // 100D:5024 call near 0x4182
        NearCall(cs1, 0x5027, unknown_100D_4182_14252);
    label_100D_5027_150F7_26032:
        CheckExternalEvents(cs1, 0x5027);
        // 100D:5027 cmp byte ptr DS:[0x0023],0
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x00);
        // 100D:502C pop CX
        CX = Stack.Pop16();
        // 100D:502D loope 0x500C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && ZeroFlag)
        {
            goto label_100D_500C_150DC_26019;
        }
    label_100D_502F_150FF_42034:
        CheckExternalEvents(cs1, 0x502F);
        // 100D:502F je short 0x4FC3
        if (ZeroFlag)
        {
            goto label_100D_4FC3_15093_22539;
        }
    label_100D_5031_15101_42037:
        CheckExternalEvents(cs1, 0x5031);
        // 100D:5031 add byte ptr DS:[0x4726],0x20
        UInt8[DS, (ushort)0x4726] = Alu8.Add(UInt8[DS, (ushort)0x4726], (byte)0x20);
        // 100D:5036 jmp near 0x2E52
        if (JumpDispatcher.Jump(unknown_100D_2E52_12F22, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5039_15109_26037:
        CheckExternalEvents(cs1, 0x5039);
        // 100D:5039 pop CX
        CX = Stack.Pop16();
        // 100D:503A jmp short 0x4FC3
        goto label_100D_4FC3_15093_22539;
    label_100D_50A5_15175_30870:
        CheckExternalEvents(cs1, 0x50A5);
        // 100D:50A5 mov AX,word ptr DS:[0xDC00]
        AX = UInt16[DS, (ushort)0xDC00];
        // 100D:50A8 call near 0xCA1B
        NearCall(cs1, 0x50AB, unknown_100D_CA1B_1CAEB);
    label_100D_50AB_1517B_30873:
        CheckExternalEvents(cs1, 0x50AB);
        // 100D:50AB mov DI,word ptr DS:[0x1150]
        DI = UInt16[DS, (ushort)0x1150];
        // 100D:50AF call near 0x407E
        NearCall(cs1, 0x50B2, unknown_100D_407E_1414E);
    label_100D_50B2_15182_30876:
        CheckExternalEvents(cs1, 0x50B2);
        // 100D:50B2 call near 0x4965
        NearCall(cs1, 0x50B5, unknown_100D_4965_14A35);
    label_100D_50B5_15185_30878:
        CheckExternalEvents(cs1, 0x50B5);
        // 100D:50B5 call near 0x4AC4
        NearCall(cs1, 0x50B8, unknown_100D_4AC4_14B94);
    label_100D_50B8_15188_30880:
        CheckExternalEvents(cs1, 0x50B8);
        // 100D:50B8 call near 0x50BE
        NearCall(cs1, 0x50BB, unknown_100D_50BE_1518E);
    label_100D_50BB_1518B_30882:
        CheckExternalEvents(cs1, 0x50BB);
        // 100D:50BB jmp near 0x2EB2
        if (JumpDispatcher.Jump(unknown_100D_2EB2_12F82, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_50C4_15194_37357:
        CheckExternalEvents(cs1, 0x50C4);
        // 100D:50C4 call near 0x407E
        NearCall(cs1, 0x50C7, unknown_100D_407E_1414E);
    label_100D_50C7_15197_37359:
        CheckExternalEvents(cs1, 0x50C7);
        // 100D:50C7 call near 0x5344
        NearCall(cs1, 0x50CA, unknown_100D_5344_15414);
    label_100D_50CA_1519A_37402:
        CheckExternalEvents(cs1, 0x50CA);
        // 100D:50CA call near 0x4944
        NearCall(cs1, 0x50CD, unknown_100D_4944_14A14);
    label_100D_50CD_1519D_37404:
        CheckExternalEvents(cs1, 0x50CD);
        // 100D:50CD call near 0x4AC4
        NearCall(cs1, 0x50D0, unknown_100D_4AC4_14B94);
    label_100D_50D0_151A0_37406:
        CheckExternalEvents(cs1, 0x50D0);
        // 100D:50D0 mov byte ptr DS:[0x11C8],0
        UInt8[DS, (ushort)0x11C8] = (byte)0x00;
        // 100D:50D5 call near 0x50BE
        NearCall(cs1, 0x50D8, unknown_100D_50BE_1518E);
    label_100D_50D8_151A8_37409:
        CheckExternalEvents(cs1, 0x50D8);
        // 100D:50D8 jmp near 0x2EB2
        if (JumpDispatcher.Jump(unknown_100D_2EB2_12F82, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_50DB_151AB_26572:
        CheckExternalEvents(cs1, 0x50DB);
        // 100D:50DB mov word ptr DS:[0x487E],2
        UInt16[DS, (ushort)0x487E] = (ushort)0x0002;
        // 100D:50E1 mov byte ptr DS:[0x473E],1
        UInt8[DS, (ushort)0x473E] = (byte)0x01;
        // 100D:50E6 mov AL,4
        AL = (byte)0x04;
        // 100D:50E8 jmp short 0x50EF
        goto label_100D_50EF_151BF_26577;
    label_100D_50EA_151BA_36546:
        CheckExternalEvents(cs1, 0x50EA);
        // 100D:50EA call near 0x4285
        NearCall(cs1, 0x50ED, unknown_100D_4285_14355);
    label_100D_50ED_151BD_36549:
        CheckExternalEvents(cs1, 0x50ED);
        // 100D:50ED mov AL,8
        AL = (byte)0x08;
    label_100D_50EF_151BF_26577:
        CheckExternalEvents(cs1, 0x50EF);
        // 100D:50EF mov DI,word ptr DS:[0x46F8]
        DI = UInt16[DS, (ushort)0x46F8];
        // 100D:50F3 push DI
        Stack.Push16(DI);
        // 100D:50F4 push AX
        Stack.Push16(AX);
        // 100D:50F5 call near 0xD2BD
        NearCall(cs1, 0x50F8, unknown_100D_D2BD_1D38D);
    label_100D_50F8_151C8_26606:
        CheckExternalEvents(cs1, 0x50F8);
        // 100D:50F8 call near 0x49EA
        NearCall(cs1, 0x50FB, unknown_100D_49EA_14ABA);
    label_100D_50FB_151CB_26608:
        CheckExternalEvents(cs1, 0x50FB);
        // 100D:50FB mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:50FF mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:5103 pop AX
        AX = Stack.Pop16();
        // 100D:5104 push AX
        Stack.Push16(AX);
        // 100D:5105 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:5107 jne short 0x510B
        if (!ZeroFlag)
        {
            goto label_100D_510B_151DB_26617;
        }
    label_100D_5109_151D9_26615:
        CheckExternalEvents(cs1, 0x5109);
        // 100D:5109 mov DL,1
        DL = (byte)0x01;
    label_100D_510B_151DB_26617:
        CheckExternalEvents(cs1, 0x510B);
        // 100D:510B call near 0x4057
        NearCall(cs1, 0x510E, unknown_100D_4057_14127);
    label_100D_510E_151DE_26619:
        CheckExternalEvents(cs1, 0x510E);
        // 100D:510E call near 0x186B
        NearCall(cs1, 0x5111, unknown_100D_186B_1193B);
    label_100D_5111_151E1_26621:
        CheckExternalEvents(cs1, 0x5111);
        // 100D:5111 pop AX
        AX = Stack.Pop16();
        // 100D:5112 mov byte ptr DS:[0x11C9],AL
        UInt8[DS, (ushort)0x11C9] = AL;
        // 100D:5115 pop DI
        DI = Stack.Pop16();
        // 100D:5116 jmp near 0x4703
        goto label_100D_4703_147D3_21483;
    label_100D_53F1_154C1_30975:
        CheckExternalEvents(cs1, 0x53F1);
        // 100D:53F1 mov byte ptr DS:[0x4722],0
        UInt8[DS, (ushort)0x4722] = (byte)0x00;
        // 100D:53F6 test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:53FB je short 0x5400
        if (ZeroFlag)
        {
            goto label_100D_5400_154D0_30979;
        }
    label_100D_53FD_154CD_40581:
        CheckExternalEvents(cs1, 0x53FD);
        // 100D:53FD jmp near 0x58FA
        if (JumpDispatcher.Jump(unknown_100D_58FA_159CA, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5400_154D0_30979:
        CheckExternalEvents(cs1, 0x5400);
        // 100D:5400 mov word ptr DS:[0x4720],0x1E6E
        UInt16[DS, (ushort)0x4720] = (ushort)0x1E6E;
        // 100D:5406 mov DX,word ptr DS:[0x11C1]
        DX = UInt16[DS, (ushort)0x11C1];
        // 100D:540A mov BX,word ptr DS:[0x11C3]
        BX = UInt16[DS, (ushort)0x11C3];
        // 100D:540E mov word ptr DS:[0x4710],DX
        UInt16[DS, (ushort)0x4710] = DX;
        // 100D:5412 mov word ptr DS:[0x4712],BX
        UInt16[DS, (ushort)0x4712] = BX;
        // 100D:5416 call near 0x5BEB
        NearCall(cs1, 0x5419, unknown_100D_5BEB_15CBB);
    label_100D_5419_154E9_30986:
        CheckExternalEvents(cs1, 0x5419);
        // 100D:5419 call near 0x5F79
        NearCall(cs1, 0x541C, unknown_100D_5F79_16049);
    label_100D_541C_154EC_30988:
        CheckExternalEvents(cs1, 0x541C);
        // 100D:541C call near 0x79DE
        NearCall(cs1, 0x541F, unknown_100D_79DE_17AAE);
        if (JumpDispatcher.Jump(unknown_100D_541F_154EF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_5A03_15AD3_23456:
        CheckExternalEvents(cs1, 0x5A03);
        // 100D:5A03 call near 0x8C8A
        NearCall(cs1, 0x5A06, unknown_100D_8C8A_18D5A);
    label_100D_5A06_15AD6_23458:
        CheckExternalEvents(cs1, 0x5A06);
        // 100D:5A06 inc byte ptr DS:[0x46F3]
        UInt8[DS, (ushort)0x46F3] = Alu8.Inc(UInt8[DS, (ushort)0x46F3]);
        // 100D:5A0A call near 0x68EB
        NearCall(cs1, 0x5A0D, unknown_100D_68EB_169BB);
    label_100D_5A0D_15ADD_23474:
        CheckExternalEvents(cs1, 0x5A0D);
        // 100D:5A0D mov byte ptr DS:[0x1954],AL
        UInt8[DS, (ushort)0x1954] = AL;
        // 100D:5A10 not byte ptr DS:[0x00FB]
        UInt8[DS, (ushort)0x00FB] = unchecked((byte)~UInt8[DS, (ushort)0x00FB]);
        // 100D:5A14 call near 0x5A1A
        NearCall(cs1, 0x5A17, unknown_100D_5A1A_15AEA);
    label_100D_5A17_15AE7_23573:
        CheckExternalEvents(cs1, 0x5A17);
        // 100D:5A17 jmp near 0x8685
        goto label_100D_8685_18755_23575;
    label_100D_5B1E_15BEE_35379:
        CheckExternalEvents(cs1, 0x5B1E);
        // 100D:5B1E mov byte ptr DS:[0x1955],3
        UInt8[DS, (ushort)0x1955] = (byte)0x03;
        // 100D:5B23 mov SI,0x08E0
        SI = (ushort)0x08E0;
        // 100D:5B26 mov DX,word ptr DS:[SI+6]
        DX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:5B29 mov BX,word ptr DS:[SI+8]
        BX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:5B2C push SI
        Stack.Push16(SI);
        // 100D:5B2D call near 0x5B60
        NearCall(cs1, 0x5B30, unknown_100D_5B60_15C30);
    label_100D_5B30_15C00_35386:
        CheckExternalEvents(cs1, 0x5B30);
        // 100D:5B30 call near 0x5B10
        NearCall(cs1, 0x5B33, unknown_100D_5B10_15BE0);
    label_100D_5B33_15C03_35396:
        CheckExternalEvents(cs1, 0x5B33);
        // 100D:5B33 pop SI
        SI = Stack.Pop16();
        // 100D:5B34 cmp word ptr DS:[0x1176],1
        Alu16.Sub(UInt16[DS, (ushort)0x1176], unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:5B39 ja short 0x5B4A
        if (!(!CarryFlag && !ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5B39");
        }
    label_100D_5B4A_15C1A_35400:
        CheckExternalEvents(cs1, 0x5B4A);
        // 100D:5B4A test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:5B4F je short 0x5B52
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:5B4F");
        }
    label_100D_5B52_15C22_35403:
        CheckExternalEvents(cs1, 0x5B52);
        // 100D:5B52 jmp near 0x86CC
        goto label_100D_86CC_1879C_35405;
    label_100D_69B3_16A83_24519:
        CheckExternalEvents(cs1, 0x69B3);
        // 100D:69B3 call near 0x68EB
        NearCall(cs1, 0x69B6, unknown_100D_68EB_169BB);
    label_100D_69B6_16A86_24521:
        CheckExternalEvents(cs1, 0x69B6);
        // 100D:69B6 mov BP,0x215A
        BP = (ushort)0x215A;
        // 100D:69B9 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:69BC and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:69BE cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:69C0 je short 0x6A07
        if (ZeroFlag)
        {
            goto label_100D_6A07_16AD7_24527;
        }
    label_100D_69C2_16A92_24764:
        CheckExternalEvents(cs1, 0x69C2);
        // 100D:69C2 call near 0x693B
        NearCall(cs1, 0x69C5, unknown_100D_693B_16A0B);
    label_100D_69C5_16A95_24766:
        CheckExternalEvents(cs1, 0x69C5);
        // 100D:69C5 mov BP,0x216E
        BP = (ushort)0x216E;
        // 100D:69C8 cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:69CB jb short 0x69F6
        if (CarryFlag)
        {
            goto label_100D_69F6_16AC6_24770;
        }
    label_100D_69CD_16A9D_33560:
        CheckExternalEvents(cs1, 0x69CD);
        // 100D:69CD mov BP,0x21A6
        BP = (ushort)0x21A6;
        // 100D:69D0 jne short 0x69F6
        if (!ZeroFlag)
        {
            goto label_100D_69F6_16AC6_24770;
        }
    label_100D_69D2_16AA2_33563:
        CheckExternalEvents(cs1, 0x69D2);
        // 100D:69D2 mov BP,0x2182
        BP = (ushort)0x2182;
        // 100D:69D5 and word ptr DS:[0x2188],0xBFFF
        UInt16[DS, (ushort)0x2188] = Alu16.And(UInt16[DS, (ushort)0x2188], (ushort)0xBFFF);
        // 100D:69DB cmp word ptr DS:[0x00E2],0x001E
        Alu16.Sub(UInt16[DS, (ushort)0x00E2], unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:69E0 jb short 0x69E8
        if (CarryFlag)
        {
            goto label_100D_69E8_16AB8_33568;
        }
    label_100D_69E2_16AB2_34672:
        CheckExternalEvents(cs1, 0x69E2);
        // 100D:69E2 or word ptr DS:[0x2188],0x4000
        UInt16[DS, (ushort)0x2188] = Alu16.Or(UInt16[DS, (ushort)0x2188], (ushort)0x4000);
    label_100D_69E8_16AB8_33568:
        CheckExternalEvents(cs1, 0x69E8);
        // 100D:69E8 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:69EB and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:69ED cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:69EF jne short 0x69F6
        if (!ZeroFlag)
        {
            goto label_100D_69F6_16AC6_24770;
        }
    label_100D_69F1_16AC1_40028:
        CheckExternalEvents(cs1, 0x69F1);
        // 100D:69F1 mov BP,0x219A
        BP = (ushort)0x219A;
        // 100D:69F4 jmp short 0x6A25
        goto label_100D_6A25_16AF5_24543;
    label_100D_69F6_16AC6_24770:
        CheckExternalEvents(cs1, 0x69F6);
        // 100D:69F6 and word ptr SS:[BP+2],0xBFFF
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.And(UInt16[SS, (ushort)(BP + (sbyte)2)], (ushort)0xBFFF);
        // 100D:69FB cmp byte ptr DS:[0x002A],0x10
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x10);
        // 100D:6A00 jae short 0x6A07
        if (!CarryFlag)
        {
            goto label_100D_6A07_16AD7_24527;
        }
    label_100D_6A02_16AD2_24774:
        CheckExternalEvents(cs1, 0x6A02);
        // 100D:6A02 or word ptr SS:[BP+2],0x4000
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Or(UInt16[SS, (ushort)(BP + (sbyte)2)], (ushort)0x4000);
    label_100D_6A07_16AD7_24527:
        CheckExternalEvents(cs1, 0x6A07);
        // 100D:6A07 lea BX,BP-2
        BX = unchecked((ushort)(BP + (sbyte)-2));
    label_100D_6A0A_16ADA_24529:
        CheckExternalEvents(cs1, 0x6A0A);
        // 100D:6A0A add BX,4
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:6A0D mov AX,word ptr DS:[BX]
        AX = UInt16[DS, BX];
        // 100D:6A0F and AX,0x0FFF
        AX = Alu16.And(AX, (ushort)0x0FFF);
        // 100D:6A12 je short 0x6A25
        if (ZeroFlag)
        {
            goto label_100D_6A25_16AF5_24543;
        }
    label_100D_6A14_16AE4_24533:
        CheckExternalEvents(cs1, 0x6A14);
        // 100D:6A14 cmp AX,0x0077
        Alu16.Sub(AX, (ushort)0x0077);
        // 100D:6A17 jne short 0x6A0A
        if (!ZeroFlag)
        {
            goto label_100D_6A0A_16ADA_24529;
        }
    label_100D_6A19_16AE9_24537:
        CheckExternalEvents(cs1, 0x6A19);
        // 100D:6A19 test byte ptr DS:[0x000A],0x20
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x20);
        // 100D:6A1E jne short 0x6A23
        if (!ZeroFlag)
        {
            goto label_100D_6A23_16AF3_24542;
        }
    label_100D_6A20_16AF0_24540:
        CheckExternalEvents(cs1, 0x6A20);
        // 100D:6A20 or AX,0x4000
        AX = Alu16.Or(AX, (ushort)0x4000);
    label_100D_6A23_16AF3_24542:
        CheckExternalEvents(cs1, 0x6A23);
        // 100D:6A23 mov word ptr DS:[BX],AX
        UInt16[DS, BX] = AX;
    label_100D_6A25_16AF5_24543:
        CheckExternalEvents(cs1, 0x6A25);
        // 100D:6A25 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:6A28 jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A2B_16AFB_39725:
        CheckExternalEvents(cs1, 0x6A2B);
        // 100D:6A2B mov AL,1
        AL = (byte)0x01;
        // 100D:6A2D jmp short 0x6A35
        if (JumpDispatcher.Jump(unknown_100D_6A35_16B05, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A2F_16AFF_40033:
        CheckExternalEvents(cs1, 0x6A2F);
        // 100D:6A2F mov AL,2
        AL = (byte)0x02;
        // 100D:6A31 jmp short 0x6A35
        if (JumpDispatcher.Jump(unknown_100D_6A35_16B05, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A45_16B15_35458:
        CheckExternalEvents(cs1, 0x6A45);
        // 100D:6A45 mov AL,1
        AL = (byte)0x01;
        // 100D:6A47 call near 0x6A35
        NearCall(cs1, 0x6A4A, unknown_100D_6A35_16B05);
    label_100D_6A4A_16B1A_35462:
        CheckExternalEvents(cs1, 0x6A4A);
        // 100D:6A4A mov byte ptr DS:[0x46D8],1
        UInt8[DS, (ushort)0x46D8] = (byte)0x01;
        // 100D:6A4F call near 0x68EB
        NearCall(cs1, 0x6A52, unknown_100D_68EB_169BB);
    label_100D_6A52_16B22_35465:
        CheckExternalEvents(cs1, 0x6A52);
        // 100D:6A52 and byte ptr DS:[SI+0x10],0xBF
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0xBF);
        // 100D:6A56 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6A59 call near 0x331E
        NearCall(cs1, 0x6A5C, unknown_100D_331E_133EE);
    label_100D_6A5C_16B2C_35469:
        CheckExternalEvents(cs1, 0x6A5C);
        // 100D:6A5C mov DI,word ptr DS:[0x00E4]
        DI = UInt16[DS, (ushort)0x00E4];
        // 100D:6A60 call near 0x82DA
        NearCall(cs1, 0x6A63, unknown_100D_82DA_183AA);
    label_100D_6A63_16B33_35472:
        CheckExternalEvents(cs1, 0x6A63);
        // 100D:6A63 jne short 0x6AC5
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6AC5_16B95, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6A65_16B35_35474:
        CheckExternalEvents(cs1, 0x6A65);
        // 100D:6A65 call near 0x8770
        NearCall(cs1, 0x6A68, unknown_100D_8770_18840);
    label_100D_6A68_16B38_35476:
        CheckExternalEvents(cs1, 0x6A68);
        // 100D:6A68 jmp near 0x84A6
        if (JumpDispatcher.Jump(unknown_100D_84A6_18576, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A71_16B41_24554:
        CheckExternalEvents(cs1, 0x6A71);
        // 100D:6A71 call near 0x68EB
        NearCall(cs1, 0x6A74, unknown_100D_68EB_169BB);
    label_100D_6A74_16B44_24556:
        CheckExternalEvents(cs1, 0x6A74);
        // 100D:6A74 xor CL,CL
        CL = Alu8.Xor(CL, CL);
        // 100D:6A76 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:6A7A jne short 0x6A89
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6A89_16B59, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6A7C_16B4C_28319:
        CheckExternalEvents(cs1, 0x6A7C);
        // 100D:6A7C inc CX
        CX = Alu16.Inc(CX);
        // 100D:6A7D call near 0x6A89
        NearCall(cs1, 0x6A80, unknown_100D_6A89_16B59);
    label_100D_6A80_16B50_28358:
        CheckExternalEvents(cs1, 0x6A80);
        // 100D:6A80 jmp near 0x2EBF
        if (JumpDispatcher.Jump(unknown_100D_2EBF_12F8F, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A83_16B53_24776:
        CheckExternalEvents(cs1, 0x6A83);
        // 100D:6A83 mov CL,4
        CL = (byte)0x04;
        // 100D:6A85 jmp short 0x6A89
        if (JumpDispatcher.Jump(unknown_100D_6A89_16B59, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6A87_16B57_39685:
        CheckExternalEvents(cs1, 0x6A87);
        // 100D:6A87 mov CL,8
        CL = (byte)0x08;
        if (JumpDispatcher.Jump(unknown_100D_6A89_16B59, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_7317_173E7_39534:
        CheckExternalEvents(cs1, 0x7317);
        // 100D:7317 mov byte ptr DS:[0x473A],1
        UInt8[DS, (ushort)0x473A] = (byte)0x01;
        // 100D:731C mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:7320 call near 0x33BE
        NearCall(cs1, 0x7323, unknown_100D_33BE_1348E);
    label_100D_7323_173F3_39541:
        CheckExternalEvents(cs1, 0x7323);
        // 100D:7323 mov AX,word ptr DS:[0x0094]
        AX = UInt16[DS, (ushort)0x0094];
        // 100D:7326 mov word ptr DS:[0x0098],AX
        UInt16[DS, (ushort)0x0098] = AX;
        // 100D:7329 mov AX,word ptr DS:[0x0096]
        AX = UInt16[DS, (ushort)0x0096];
        // 100D:732C mov word ptr DS:[0x009A],AX
        UInt16[DS, (ushort)0x009A] = AX;
        // 100D:732F call near 0xE3CC
        NearCall(cs1, 0x7332, unknown_100D_E3CC_1E49C);
    label_100D_7332_17402_39552:
        CheckExternalEvents(cs1, 0x7332);
        // 100D:7332 cmp AL,byte ptr DS:[0x009C]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x009C]);
        // 100D:7336 mov BP,0x7516
        BP = (ushort)0x7516;
        // 100D:7339 jae short 0x733E
        if (!CarryFlag)
        {
            goto label_100D_733E_1740E_39556;
        }
    label_100D_733B_1740B_39558:
        CheckExternalEvents(cs1, 0x733B);
        // 100D:733B mov BP,0x7419
        BP = (ushort)0x7419;
    label_100D_733E_1740E_39556:
        CheckExternalEvents(cs1, 0x733E);
        // 100D:733E mov CX,0x0010
        CX = (ushort)0x0010;
    label_100D_7341_17411_39560:
        CheckExternalEvents(cs1, 0x7341);
        // 100D:7341 push CX
        Stack.Push16(CX);
        // 100D:7342 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:7346 push BP
        Stack.Push16(BP);
        // 100D:7347 call near 0x33BE
        NearCall(cs1, 0x734A, unknown_100D_33BE_1348E);
    label_100D_734A_1741A_39574:
        CheckExternalEvents(cs1, 0x734A);
        // 100D:734A pop BP
        BP = Stack.Pop16();
        // 100D:734B call near 0x6603
        NearCall(cs1, 0x734E, unknown_100D_6603_166D3);
    label_100D_734E_1741E_39596:
        CheckExternalEvents(cs1, 0x734E);
        // 100D:734E pop CX
        CX = Stack.Pop16();
        // 100D:734F cmp word ptr DS:[0x0094],0
        Alu16.Sub(UInt16[DS, (ushort)0x0094], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:7354 je short 0x735F
        if (ZeroFlag)
        {
            goto label_100D_735F_1742F_39600;
        }
    label_100D_7356_17426_39602:
        CheckExternalEvents(cs1, 0x7356);
        // 100D:7356 cmp word ptr DS:[0x0096],0
        Alu16.Sub(UInt16[DS, (ushort)0x0096], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:735B je short 0x735F
        if (ZeroFlag)
        {
            goto label_100D_735F_1742F_39600;
        }
    label_100D_735D_1742D_39607:
        CheckExternalEvents(cs1, 0x735D);
        // 100D:735D loop 0x7341
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_7341_17411_39560;
        }
    label_100D_735F_1742F_39600:
        CheckExternalEvents(cs1, 0x735F);
        // 100D:735F call near 0x33BE
        NearCall(cs1, 0x7362, unknown_100D_33BE_1348E);
    label_100D_7362_17432_39618:
        CheckExternalEvents(cs1, 0x7362);
        // 100D:7362 mov AX,word ptr DS:[0x0094]
        AX = UInt16[DS, (ushort)0x0094];
        // 100D:7365 sub word ptr DS:[0x0098],AX
        UInt16[DS, (ushort)0x0098] = Alu16.Sub(UInt16[DS, (ushort)0x0098], AX);
        // 100D:7369 mov AX,word ptr DS:[0x0096]
        AX = UInt16[DS, (ushort)0x0096];
        // 100D:736C sub word ptr DS:[0x009A],AX
        UInt16[DS, (ushort)0x009A] = Alu16.Sub(UInt16[DS, (ushort)0x009A], AX);
        // 100D:7370 mov CX,0x0014
        CX = (ushort)0x0014;
    label_100D_7373_17443_39624:
        CheckExternalEvents(cs1, 0x7373);
        // 100D:7373 push CX
        Stack.Push16(CX);
        // 100D:7374 mov BX,0x0201
        BX = (ushort)0x0201;
        // 100D:7377 call near 0xE3B7
        NearCall(cs1, 0x737A, unknown_100D_E3B7_1E487);
    label_100D_737A_1744A_39635:
        CheckExternalEvents(cs1, 0x737A);
        // 100D:737A or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:737C mov AL,0x0B
        AL = (byte)0x0B;
        // 100D:737E je short 0x7382
        if (ZeroFlag)
        {
            goto label_100D_7382_17452_39639;
        }
    label_100D_7380_17450_39641:
        CheckExternalEvents(cs1, 0x7380);
        // 100D:7380 mov AL,0x11
        AL = (byte)0x11;
    label_100D_7382_17452_39639:
        CheckExternalEvents(cs1, 0x7382);
        // 100D:7382 mov byte ptr DS:[0x485D],AL
        UInt8[DS, (ushort)0x485D] = AL;
        // 100D:7385 mov AL,AH
        AL = AH;
        // 100D:7387 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:7389 add AL,0x28
        AL = Alu8.Add(AL, (byte)0x28);
        // 100D:738B call near 0xDDB0
        NearCall(cs1, 0x738E, unknown_100D_DDB0_1DE80);
    label_100D_738E_1745E_39656:
        CheckExternalEvents(cs1, 0x738E);
        // 100D:738E pop CX
        CX = Stack.Pop16();
        // 100D:738F loop 0x7373
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_7373_17443_39624;
        }
    label_100D_7391_17461_39661:
        CheckExternalEvents(cs1, 0x7391);
        // 100D:7391 mov byte ptr DS:[0x473A],0
        UInt8[DS, (ushort)0x473A] = (byte)0x00;
        // 100D:7396 jmp near 0x1B8D
        goto label_100D_1B8D_11C5D_15178;
    label_100D_7734_17804_34674:
        CheckExternalEvents(cs1, 0x7734);
        // 100D:7734 call near 0x68EB
        NearCall(cs1, 0x7737, unknown_100D_68EB_169BB);
    label_100D_7737_17807_34676:
        CheckExternalEvents(cs1, 0x7737);
        // 100D:7737 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:773A mov BX,2
        BX = (ushort)0x0002;
        // 100D:773D mov CL,0x20
        CL = (byte)0x20;
        // 100D:773F and CL,AL
        Alu8.And(CL, AL);
        // 100D:7741 je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_7743_17813_34682:
        CheckExternalEvents(cs1, 0x7743);
        // 100D:7743 inc BX
        BX = Alu16.Inc(BX);
        // 100D:7744 shr CL,1
        CL = Alu8.Shr(CL, 1);
        // 100D:7746 and CL,AL
        Alu8.And(CL, AL);
        // 100D:7748 je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_774A_1781A_34687:
        CheckExternalEvents(cs1, 0x774A);
        // 100D:774A inc BX
        BX = Alu16.Inc(BX);
        // 100D:774B shr CL,1
        CL = Alu8.Shr(CL, 1);
        // 100D:774D and CL,AL
        Alu8.And(CL, AL);
        // 100D:774F je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_7751_17821_38292:
        CheckExternalEvents(cs1, 0x7751);
        // 100D:7751 inc BX
        BX = Alu16.Inc(BX);
        // 100D:7752 shr CL,1
        CL = Alu8.Shr(CL, 1);
        // 100D:7754 and CL,AL
        Alu8.And(CL, AL);
        // 100D:7756 je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_7758_17828_38298:
        CheckExternalEvents(cs1, 0x7758);
        // 100D:7758 mov AL,0x0F
        AL = (byte)0x0F;
        // 100D:775A jmp short 0x77CA
        goto label_100D_77CA_1789A_33806;
    label_100D_775C_1782C_40118:
        CheckExternalEvents(cs1, 0x775C);
        // 100D:775C call near 0x68EB
        NearCall(cs1, 0x775F, unknown_100D_68EB_169BB);
    label_100D_775F_1782F_40121:
        CheckExternalEvents(cs1, 0x775F);
        // 100D:775F mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7762 mov BX,6
        BX = (ushort)0x0006;
        // 100D:7765 test AL,2
        Alu8.And(AL, (byte)0x02);
        // 100D:7767 je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_7769_17839_40127:
        CheckExternalEvents(cs1, 0x7769);
        // 100D:7769 mov AL,0x0F
        AL = (byte)0x0F;
        // 100D:776B jmp short 0x77CA
        goto label_100D_77CA_1789A_33806;
    label_100D_776D_1783D_31173:
        CheckExternalEvents(cs1, 0x776D);
        // 100D:776D call near 0x68EB
        NearCall(cs1, 0x7770, unknown_100D_68EB_169BB);
    label_100D_7770_17840_31175:
        CheckExternalEvents(cs1, 0x7770);
        // 100D:7770 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7773 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:7775 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:7777 je short 0x7780
        if (ZeroFlag)
        {
            goto label_100D_7780_17850_31180;
        }
    label_100D_7779_17849_33435:
        CheckExternalEvents(cs1, 0x7779);
        // 100D:7779 inc BX
        BX = Alu16.Inc(BX);
        // 100D:777A test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:777C mov AL,0x0F
        AL = (byte)0x0F;
        // 100D:777E jne short 0x77CA
        if (!ZeroFlag)
        {
            goto label_100D_77CA_1789A_33806;
        }
    label_100D_7780_17850_31180:
        CheckExternalEvents(cs1, 0x7780);
        // 100D:7780 push SI
        Stack.Push16(SI);
        // 100D:7781 mov AX,BX
        AX = BX;
        // 100D:7783 add AX,0x00E8
        AX = Alu16.Add(AX, (ushort)0x00E8);
        // 100D:7786 mov word ptr DS:[0x1203],AX
        UInt16[DS, (ushort)0x1203] = AX;
        // 100D:7789 call near 0x77D7
        NearCall(cs1, 0x778C, unknown_100D_77D7_178A7);
    label_100D_778C_1785C_31204:
        CheckExternalEvents(cs1, 0x778C);
        // 100D:778C jb short 0x7792
        if (CarryFlag)
        {
            goto label_100D_7792_17862_31206;
        }
    label_100D_778E_1785E_33396:
        CheckExternalEvents(cs1, 0x778E);
        // 100D:778E pop SI
        SI = Stack.Pop16();
        // 100D:778F jmp near 0x7D81
        goto label_100D_7D81_17E51_27795;
    label_100D_7792_17862_31206:
        CheckExternalEvents(cs1, 0x7792);
        // 100D:7792 call near 0x7F90
        NearCall(cs1, 0x7795, unknown_100D_7F90_18060);
    label_100D_7795_17865_31296:
        CheckExternalEvents(cs1, 0x7795);
        // 100D:7795 pop SI
        SI = Stack.Pop16();
        // 100D:7796 cmp word ptr DS:[0x470C],-1
        Alu16.Sub(UInt16[DS, (ushort)0x470C], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:779B je short 0x77C8
        if (ZeroFlag)
        {
            goto label_100D_77C8_17898_33804;
        }
    label_100D_779D_1786D_31300:
        CheckExternalEvents(cs1, 0x779D);
        // 100D:779D mov CL,BL
        CL = BL;
        // 100D:779F mov BH,0x80
        BH = (byte)0x80;
        // 100D:77A1 shr BH,CL
        BH = Alu8.Shr(BH, unchecked((int)CL));
        // 100D:77A3 push BX
        Stack.Push16(BX);
        // 100D:77A4 push SI
        Stack.Push16(SI);
        // 100D:77A5 push word ptr DS:[0x470E]
        Stack.Push16(UInt16[DS, (ushort)0x470E]);
        // 100D:77A9 call near 0x6A33
        NearCall(cs1, 0x77AC, unknown_100D_6A33_16B03);
    label_100D_77AC_1787C_31320:
        CheckExternalEvents(cs1, 0x77AC);
        // 100D:77AC pop DI
        DI = Stack.Pop16();
        // 100D:77AD pop SI
        SI = Stack.Pop16();
        // 100D:77AE pop AX
        AX = Stack.Pop16();
        // 100D:77AF call near 0xA1E2
        NearCall(cs1, 0x77B2, unknown_100D_A1E2_1A2B2);
    label_100D_77B2_17882_31325:
        CheckExternalEvents(cs1, 0x77B2);
        // 100D:77B2 jne short 0x77D4
        if (!ZeroFlag)
        {
            goto label_100D_77D4_178A4_33461;
        }
    label_100D_77B4_17884_31327:
        CheckExternalEvents(cs1, 0x77B4);
        // 100D:77B4 mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
        // 100D:77B7 mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:77BA mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
        // 100D:77BD call near 0x84A6
        NearCall(cs1, 0x77C0, unknown_100D_84A6_18576);
    label_100D_77C0_17890_31333:
        CheckExternalEvents(cs1, 0x77C0);
        // 100D:77C0 mov byte ptr DS:[0x46D8],1
        UInt8[DS, (ushort)0x46D8] = (byte)0x01;
        // 100D:77C5 jmp near 0x8770
        if (JumpDispatcher.Jump(unknown_100D_8770_18840, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_77C8_17898_33804:
        CheckExternalEvents(cs1, 0x77C8);
        // 100D:77C8 mov AL,0x0E
        AL = (byte)0x0E;
    label_100D_77CA_1789A_33806:
        CheckExternalEvents(cs1, 0x77CA);
        // 100D:77CA push AX
        Stack.Push16(AX);
        // 100D:77CB push SI
        Stack.Push16(SI);
        // 100D:77CC call near 0xD2FD
        NearCall(cs1, 0x77CF, unknown_100D_D2FD_1D3CD);
    label_100D_77CF_1789F_33809:
        CheckExternalEvents(cs1, 0x77CF);
        // 100D:77CF pop SI
        SI = Stack.Pop16();
        // 100D:77D0 pop AX
        AX = Stack.Pop16();
        // 100D:77D1 call near 0x7BB9
        NearCall(cs1, 0x77D4, unknown_100D_7BB9_17C89);
    label_100D_77D4_178A4_33461:
        CheckExternalEvents(cs1, 0x77D4);
        // 100D:77D4 jmp near 0xC13B
        return unknown_100D_C13B_1C20B(0x0000);
    label_100D_7CBB_17D8B_27493:
        CheckExternalEvents(cs1, 0x7CBB);
        // 100D:7CBB mov byte ptr DS:[0x46F5],1
        UInt8[DS, (ushort)0x46F5] = (byte)0x01;
        // 100D:7CC0 mov BP,0x2012
        BP = (ushort)0x2012;
        // 100D:7CC3 mov BX,0x7D68
        BX = (ushort)0x7D68;
        // 100D:7CC6 call near 0xD323
        NearCall(cs1, 0x7CC9, unknown_100D_D323_1D3F3);
    label_100D_7CC9_17D99_27498:
        CheckExternalEvents(cs1, 0x7CC9);
        // 100D:7CC9 call near 0xC13B
        NearCall(cs1, 0x7CCC, unknown_100D_C13B_1C20B);
    label_100D_7CCC_17D9C_27500:
        CheckExternalEvents(cs1, 0x7CCC);
        // 100D:7CCC cmp byte ptr DS:[0x46F4],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F4], (byte)0x00);
        // 100D:7CD1 jne short 0x7CF1
        if (!ZeroFlag)
        {
            goto label_100D_7CF1_17DC1_27521;
        }
    label_100D_7CD3_17DA3_27503:
        CheckExternalEvents(cs1, 0x7CD3);
        // 100D:7CD3 mov SI,word ptr DS:[0x46EF]
        SI = UInt16[DS, (ushort)0x46EF];
        // 100D:7CD7 call near 0x7BE0
        NearCall(cs1, 0x7CDA, unknown_100D_7BE0_17CB0);
    label_100D_7CDA_17DAA_27511:
        CheckExternalEvents(cs1, 0x7CDA);
        // 100D:7CDA call near 0x7C02
        NearCall(cs1, 0x7CDD, unknown_100D_7C02_17CD2);
    label_100D_7CDD_17DAD_27518:
        CheckExternalEvents(cs1, 0x7CDD);
        // 100D:7CDD cmp byte ptr DS:[0x46F4],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F4], (byte)0x00);
        // 100D:7CE2 jne short 0x7CF1
        if (!ZeroFlag)
        {
            goto label_100D_7CF1_17DC1_27521;
        }
    label_100D_7CE4_17DB4_35059:
        CheckExternalEvents(cs1, 0x7CE4);
        // 100D:7CE4 call near 0x7C02
        NearCall(cs1, 0x7CE7, unknown_100D_7C02_17CD2);
    label_100D_7CE7_17DB7_35061:
        CheckExternalEvents(cs1, 0x7CE7);
        // 100D:7CE7 cmp byte ptr DS:[0x46F4],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F4], (byte)0x00);
        // 100D:7CEC jne short 0x7CF1
        if (!ZeroFlag)
        {
            goto label_100D_7CF1_17DC1_27521;
        }
    label_100D_7CEE_17DBE_35064:
        CheckExternalEvents(cs1, 0x7CEE);
        // 100D:7CEE call near 0x7C02
        NearCall(cs1, 0x7CF1, unknown_100D_7C02_17CD2);
    label_100D_7CF1_17DC1_27521:
        CheckExternalEvents(cs1, 0x7CF1);
        // 100D:7CF1 call near 0x7DD9
        NearCall(cs1, 0x7CF4, unknown_100D_7DD9_17EA9);
    label_100D_7CF4_17DC4_27549:
        CheckExternalEvents(cs1, 0x7CF4);
        // 100D:7CF4 call near 0x68EB
        NearCall(cs1, 0x7CF7, unknown_100D_68EB_169BB);
    label_100D_7CF7_17DC7_27551:
        CheckExternalEvents(cs1, 0x7CF7);
        // 100D:7CF7 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7CFA mov byte ptr DS:[0x003D],AL
        UInt8[DS, (ushort)0x003D] = AL;
        // 100D:7CFD call near 0x7EFB
        NearCall(cs1, 0x7D00, unknown_100D_7EFB_17FCB);
    label_100D_7D00_17DD0_27555:
        CheckExternalEvents(cs1, 0x7D00);
        // 100D:7D00 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7D03 call near 0x7F27
        NearCall(cs1, 0x7D06, unknown_100D_7F27_17FF7);
    label_100D_7D06_17DD6_27558:
        CheckExternalEvents(cs1, 0x7D06);
        // 100D:7D06 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        if (JumpDispatcher.Jump(unknown_100D_7D0C_17DDC, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_7D81_17E51_27795:
        CheckExternalEvents(cs1, 0x7D81);
        // 100D:7D81 call near 0x8461
        NearCall(cs1, 0x7D84, unknown_100D_8461_18531);
    label_100D_7D84_17E54_27805:
        CheckExternalEvents(cs1, 0x7D84);
        // 100D:7D84 mov AH,byte ptr DS:[SI+0x19]
        AH = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7D87 mov AL,byte ptr DS:[0x003D]
        AL = UInt8[DS, (ushort)0x003D];
        // 100D:7D8A mov BL,AL
        BL = AL;
        // 100D:7D8C xor BL,AH
        BL = Alu8.Xor(BL, AH);
        // 100D:7D8E and AH,BL
        AH = Alu8.And(AH, BL);
        // 100D:7D90 mov byte ptr DS:[0x003D],AH
        UInt8[DS, (ushort)0x003D] = AH;
        // 100D:7D94 and AL,BL
        AL = Alu8.And(AL, BL);
        // 100D:7D96 mov byte ptr DS:[0x003E],AL
        UInt8[DS, (ushort)0x003E] = AL;
        // 100D:7D99 mov byte ptr DS:[0x003F],0
        UInt8[DS, (ushort)0x003F] = (byte)0x00;
        // 100D:7D9E test AH,0x40
        Alu8.And(AH, (byte)0x40);
        // 100D:7DA1 je short 0x7DB1
        if (ZeroFlag)
        {
            goto label_100D_7DB1_17E81_27817;
        }
    label_100D_7DA3_17E73_37028:
        CheckExternalEvents(cs1, 0x7DA3);
        // 100D:7DA3 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7DA6 cmp DI,word ptr DS:[0x1150]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x1150]);
        // 100D:7DAA jne short 0x7DB1
        if (!ZeroFlag)
        {
            goto label_100D_7DB1_17E81_27817;
        }
    label_100D_7DAC_17E7C_37033:
        CheckExternalEvents(cs1, 0x7DAC);
        // 100D:7DAC mov byte ptr DS:[0x003F],0x40
        UInt8[DS, (ushort)0x003F] = (byte)0x40;
    label_100D_7DB1_17E81_27817:
        CheckExternalEvents(cs1, 0x7DB1);
        // 100D:7DB1 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:7DB4 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:7DB6 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:7DB8 jne short 0x7DBD
        if (!ZeroFlag)
        {
            goto label_100D_7DBD_17E8D_27822;
        }
    label_100D_7DBA_17E8A_40608:
        CheckExternalEvents(cs1, 0x7DBA);
        // 100D:7DBA call near 0x6C15
        NearCall(cs1, 0x7DBD, unknown_100D_6C15_16CE5);
    label_100D_7DBD_17E8D_27822:
        CheckExternalEvents(cs1, 0x7DBD);
        // 100D:7DBD mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:7DBF call near 0x7BB9
        NearCall(cs1, 0x7DC2, unknown_100D_7BB9_17C89);
    label_100D_7DC2_17E92_27829:
        CheckExternalEvents(cs1, 0x7DC2);
        // 100D:7DC2 mov byte ptr DS:[0x46F4],0
        UInt8[DS, (ushort)0x46F4] = (byte)0x00;
        // 100D:7DC7 cmp word ptr DS:[0x1BEA],0
        Alu16.Sub(UInt16[DS, (ushort)0x1BEA], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:7DCC jne short 0x7DD8
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7DCC");
        }
    label_100D_7DD8_17EA8_27833:
        CheckExternalEvents(cs1, 0x7DD8);
        // 100D:7DD8 ret near
        return NearRet((ushort)0x0000);
    label_100D_8064_18134_29063:
        CheckExternalEvents(cs1, 0x8064);
        // 100D:8064 mov AX,0x1AAC
        AX = (ushort)0x1AAC;
        // 100D:8067 call near 0xD95E
        NearCall(cs1, 0x806A, unknown_100D_D95E_1DA2E);
    label_100D_806A_1813A_29066:
        CheckExternalEvents(cs1, 0x806A);
        // 100D:806A call near 0x68EB
        NearCall(cs1, 0x806D, unknown_100D_68EB_169BB);
    label_100D_806D_1813D_29068:
        CheckExternalEvents(cs1, 0x806D);
        // 100D:806D cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:8071 je short 0x8082
        if (ZeroFlag)
        {
            goto label_100D_8082_18152_29071;
        }
    label_100D_8073_18143_30154:
        CheckExternalEvents(cs1, 0x8073);
        // 100D:8073 mov AX,0x0054
        AX = (ushort)0x0054;
        // 100D:8076 call near 0x80DF
        NearCall(cs1, 0x8079, unknown_100D_80DF_181AF);
    label_100D_8079_18149_30165:
        CheckExternalEvents(cs1, 0x8079);
        // 100D:8079 mov BP,0x212E
        BP = (ushort)0x212E;
        // 100D:807C mov BX,0x824D
        BX = (ushort)0x824D;
        // 100D:807F jmp near 0xD323
        if (JumpDispatcher.Jump(unknown_100D_D323_1D3F3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_8082_18152_29071:
        CheckExternalEvents(cs1, 0x8082);
        // 100D:8082 push DS
        Stack.Push16(DS);
        // 100D:8083 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8084 mov DI,0x4718
        DI = (ushort)0x4718;
        // 100D:8087 mov SI,0x11D3
        SI = (ushort)0x11D3;
        // 100D:808A movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:808B movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:808C movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:808D sub DI,6
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:8090 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:8092 mov CX,4
        CX = (ushort)0x0004;
        // 100D:8095 repne scas AX,word ptr ES:[DI]
        bool shouldContinue_100D_8095_18165 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_8095_18165)
        {
            Alu16.Sub(AX, UInt16[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_8095_18165 = ZeroFlag == false;
        }
        // 100D:8097 sub CX,3
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:809A neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:809C mov byte ptr DS:[0x4738],CL
        UInt8[DS, (ushort)0x4738] = CL;
        // 100D:80A0 mov AX,0x0055
        AX = (ushort)0x0055;
        // 100D:80A3 call near 0x80DF
        NearCall(cs1, 0x80A6, unknown_100D_80DF_181AF);
    label_100D_80A6_18176_29093:
        CheckExternalEvents(cs1, 0x80A6);
        // 100D:80A6 call near 0x80AC
        NearCall(cs1, 0x80A9, unknown_100D_80AC_1817C);
    label_100D_80A9_18179_29108:
        CheckExternalEvents(cs1, 0x80A9);
        // 100D:80A9 jmp near 0xD32F
        goto label_100D_D32F_1D3FF_25515;
    label_100D_80D9_181A9_32110:
        CheckExternalEvents(cs1, 0x80D9);
        // 100D:80D9 call near 0x80C8
        NearCall(cs1, 0x80DC, unknown_100D_80C8_18198);
    label_100D_80DC_181AC_32119:
        CheckExternalEvents(cs1, 0x80DC);
        // 100D:80DC jmp near 0x8286
        goto label_100D_8286_18356_29311;
    label_100D_8214_182E4_29367:
        CheckExternalEvents(cs1, 0x8214);
        // 100D:8214 call near 0x82B7
        NearCall(cs1, 0x8217, unknown_100D_82B7_18387);
    label_100D_8217_182E7_29391:
        CheckExternalEvents(cs1, 0x8217);
        // 100D:8217 call near 0x68EB
        NearCall(cs1, 0x821A, unknown_100D_68EB_169BB);
    label_100D_821A_182EA_29393:
        CheckExternalEvents(cs1, 0x821A);
        // 100D:821A cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:821E jne short 0x8235
        if (!ZeroFlag)
        {
            goto label_100D_8235_18305_29409;
        }
    label_100D_8220_182F0_29396:
        CheckExternalEvents(cs1, 0x8220);
        // 100D:8220 push SI
        Stack.Push16(SI);
        // 100D:8221 mov SI,0x4718
        SI = (ushort)0x4718;
        // 100D:8224 mov DI,0x11D3
        DI = (ushort)0x11D3;
        // 100D:8227 push DS
        Stack.Push16(DS);
        // 100D:8228 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8229 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:822A movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:822B movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:822C pop SI
        SI = Stack.Pop16();
        // 100D:822D mov DI,word ptr DS:[0x11D3]
        DI = UInt16[DS, (ushort)0x11D3];
        // 100D:8231 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:8233 je short 0x8246
        if (ZeroFlag)
        {
            goto label_100D_8246_18316_30173;
        }
    label_100D_8235_18305_29409:
        CheckExternalEvents(cs1, 0x8235);
        // 100D:8235 call near 0x82DA
        NearCall(cs1, 0x8238, unknown_100D_82DA_183AA);
    label_100D_8238_18308_29454:
        CheckExternalEvents(cs1, 0x8238);
        // 100D:8238 jne short 0x8246
        if (!ZeroFlag)
        {
            goto label_100D_8246_18316_30173;
        }
    label_100D_823A_1830A_29456:
        CheckExternalEvents(cs1, 0x823A);
        // 100D:823A call near 0x84A6
        NearCall(cs1, 0x823D, unknown_100D_84A6_18576);
    label_100D_823D_1830D_29680:
        CheckExternalEvents(cs1, 0x823D);
        // 100D:823D call near 0xD2FD
        NearCall(cs1, 0x8240, unknown_100D_D2FD_1D3CD);
    label_100D_8240_18310_29682:
        CheckExternalEvents(cs1, 0x8240);
        // 100D:8240 call near 0x8250
        NearCall(cs1, 0x8243, unknown_100D_8250_18320);
    label_100D_8243_18313_29688:
        CheckExternalEvents(cs1, 0x8243);
        // 100D:8243 jmp near 0x878C
        if (JumpDispatcher.Jump(unknown_100D_878C_1885C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_8246_18316_30173:
        CheckExternalEvents(cs1, 0x8246);
        // 100D:8246 call near 0xD2E2
        NearCall(cs1, 0x8249, unknown_100D_D2E2_1D3B2);
    label_100D_8249_18319_30177:
        CheckExternalEvents(cs1, 0x8249);
        // 100D:8249 jmp near 0xC13B
        return unknown_100D_C13B_1C20B(0x0000);
    label_100D_8286_18356_29311:
        CheckExternalEvents(cs1, 0x8286);
        // 100D:8286 call near 0x542F
        NearCall(cs1, 0x8289, unknown_100D_542F_154FF);
    label_100D_8289_18359_29346:
        CheckExternalEvents(cs1, 0x8289);
        // 100D:8289 call near 0x80AC
        NearCall(cs1, 0x828C, unknown_100D_80AC_1817C);
    label_100D_828C_1835C_29349:
        CheckExternalEvents(cs1, 0x828C);
        // 100D:828C call near 0xD33A
        NearCall(cs1, 0x828F, unknown_100D_D33A_1D40A);
    label_100D_828F_1835F_29351:
        CheckExternalEvents(cs1, 0x828F);
        // 100D:828F cmp byte ptr DS:[0x4738],3
        Alu8.Sub(UInt8[DS, (ushort)0x4738], (byte)0x03);
        // 100D:8294 jae short 0x8298
        if (!CarryFlag)
        {
            goto label_100D_8298_18368_29361;
        }
    label_100D_8296_18366_29354:
        CheckExternalEvents(cs1, 0x8296);
        // 100D:8296 stc
        CarryFlag = true;
        // 100D:8297 ret near
        return NearRet((ushort)0x0000);
    label_100D_8298_18368_29361:
        CheckExternalEvents(cs1, 0x8298);
        // 100D:8298 mov AX,0x0032
        AX = (ushort)0x0032;
        // 100D:829B call near 0xE3A0
        NearCall(cs1, 0x829E, unknown_100D_E3A0_1E470);
    label_100D_829E_1836E_29364:
        CheckExternalEvents(cs1, 0x829E);
        // 100D:829E clc
        CarryFlag = false;
        // 100D:829F ret near
        return NearRet((ushort)0x0000);
    label_100D_8685_18755_23575:
        CheckExternalEvents(cs1, 0x8685);
        // 100D:8685 mov byte ptr DS:[0x46D8],1
        UInt8[DS, (ushort)0x46D8] = (byte)0x01;
        // 100D:868A call near 0x69A3
        NearCall(cs1, 0x868D, unknown_100D_69A3_16A73);
    label_100D_868D_1875D_23587:
        CheckExternalEvents(cs1, 0x868D);
        // 100D:868D call near 0x7B58
        NearCall(cs1, 0x8690, unknown_100D_7B58_17C28);
    label_100D_8690_18760_23599:
        CheckExternalEvents(cs1, 0x8690);
        // 100D:8690 call near 0x5F79
        NearCall(cs1, 0x8693, unknown_100D_5F79_16049);
    label_100D_8693_18763_23601:
        CheckExternalEvents(cs1, 0x8693);
        // 100D:8693 call near 0x79DE
        NearCall(cs1, 0x8696, unknown_100D_79DE_17AAE);
    label_100D_8696_18766_23603:
        CheckExternalEvents(cs1, 0x8696);
        // 100D:8696 call near 0x58FA
        NearCall(cs1, 0x8699, unknown_100D_58FA_159CA);
    label_100D_8699_18769_23610:
        CheckExternalEvents(cs1, 0x8699);
        // 100D:8699 mov AL,byte ptr DS:[0x1954]
        AL = UInt8[DS, (ushort)0x1954];
        // 100D:869C cmp AL,0x43
        Alu8.Sub(AL, (byte)0x43);
        // 100D:869E ja short 0x86B8
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_86B8_18788_24453;
        }
    label_100D_86A0_18770_23614:
        CheckExternalEvents(cs1, 0x86A0);
        // 100D:86A0 call near 0x6906
        NearCall(cs1, 0x86A3, unknown_100D_6906_169D6);
    label_100D_86A3_18773_23616:
        CheckExternalEvents(cs1, 0x86A3);
        // 100D:86A3 jae short 0x86B8
        if (!CarryFlag)
        {
            goto label_100D_86B8_18788_24453;
        }
    label_100D_86A5_18775_23618:
        CheckExternalEvents(cs1, 0x86A5);
        // 100D:86A5 mov byte ptr DS:[0x1955],AL
        UInt8[DS, (ushort)0x1955] = AL;
        // 100D:86A8 push SI
        Stack.Push16(SI);
        // 100D:86A9 call near 0x697C
        NearCall(cs1, 0x86AC, unknown_100D_697C_16A4C);
    label_100D_86AC_1877C_23733:
        CheckExternalEvents(cs1, 0x86AC);
        // 100D:86AC pop SI
        SI = Stack.Pop16();
        // 100D:86AD push SI
        Stack.Push16(SI);
        // 100D:86AE call near 0x780A
        NearCall(cs1, 0x86B1, unknown_100D_780A_178DA);
    label_100D_86B1_18781_23804:
        CheckExternalEvents(cs1, 0x86B1);
        // 100D:86B1 pop SI
        SI = Stack.Pop16();
        // 100D:86B2 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:86B5 call near 0x7C02
        NearCall(cs1, 0x86B8, unknown_100D_7C02_17CD2);
    label_100D_86B8_18788_24453:
        CheckExternalEvents(cs1, 0x86B8);
        // 100D:86B8 ret near
        return NearRet((ushort)0x0000);
    label_100D_86CC_1879C_35405:
        CheckExternalEvents(cs1, 0x86CC);
        // 100D:86CC call near 0x5BEB
        NearCall(cs1, 0x86CF, unknown_100D_5BEB_15CBB);
    label_100D_86CF_1879F_35407:
        CheckExternalEvents(cs1, 0x86CF);
        // 100D:86CF cmp byte ptr DS:[0x0028],0
        Alu8.Sub(UInt8[DS, (ushort)0x0028], (byte)0x00);
        // 100D:86D4 je short 0x86B8
        if (ZeroFlag)
        {
            goto label_100D_86B8_18788_24453;
        }
    label_100D_86D6_187A6_35410:
        CheckExternalEvents(cs1, 0x86D6);
        // 100D:86D6 cmp word ptr DS:[0x1176],2
        Alu16.Sub(UInt16[DS, (ushort)0x1176], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:86DB jb short 0x86B9
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:86DB");
        }
    label_100D_86DD_187AD_35413:
        CheckExternalEvents(cs1, 0x86DD);
        // 100D:86DD mov AX,word ptr DS:[0x1954]
        AX = UInt16[DS, (ushort)0x1954];
        // 100D:86E0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:86E2 jne short 0x86FA
        if (!ZeroFlag)
        {
            goto label_100D_86FA_187CA_34555;
        }
    label_100D_86E4_187B4_35417:
        CheckExternalEvents(cs1, 0x86E4);
        // 100D:86E4 mov AL,AH
        AL = AH;
        // 100D:86E6 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:86E8 je short 0x86FA
        if (ZeroFlag)
        {
            goto label_100D_86FA_187CA_34555;
        }
    label_100D_86EA_187BA_35421:
        CheckExternalEvents(cs1, 0x86EA);
        // 100D:86EA mov byte ptr DS:[0x1954],AL
        UInt8[DS, (ushort)0x1954] = AL;
        // 100D:86ED call near 0x6906
        NearCall(cs1, 0x86F0, unknown_100D_6906_169D6);
    label_100D_86F0_187C0_35424:
        CheckExternalEvents(cs1, 0x86F0);
        // 100D:86F0 call near 0x6917
        NearCall(cs1, 0x86F3, unknown_100D_6917_169E7);
    label_100D_86F3_187C3_35426:
        CheckExternalEvents(cs1, 0x86F3);
        // 100D:86F3 je short 0x8685
        if (ZeroFlag)
        {
            goto label_100D_8685_18755_23575;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:86F3");
        }
    label_100D_86FA_187CA_34555:
        CheckExternalEvents(cs1, 0x86FA);
        // 100D:86FA mov SI,0x3CBE
        SI = (ushort)0x3CBE;
        // 100D:86FD lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:86FE mov CX,AX
        CX = AX;
        // 100D:8700 jcxz short 0x86B8
        if (CX == (ushort)0x0000)
        {
            goto label_100D_86B8_18788_24453;
        }
    label_100D_8702_187D2_34560:
        CheckExternalEvents(cs1, 0x8702);
        // 100D:8702 mov AL,byte ptr DS:[0x1954]
        AL = UInt8[DS, (ushort)0x1954];
        // 100D:8705 mov BH,0xFF
        BH = (byte)0xFF;
        // 100D:8707 xor DI,DI
        DI = Alu16.Xor(DI, DI);
    label_100D_8709_187D9_34564:
        CheckExternalEvents(cs1, 0x8709);
        // 100D:8709 mov BP,word ptr DS:[SI+0x0A]
        BP = UInt16[DS, (ushort)(SI + (sbyte)10)];
        // 100D:870C cmp byte ptr SS:[BP+3],0x80
        Alu8.Sub(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0x80);
        // 100D:8710 jae short 0x8721
        if (!CarryFlag)
        {
            goto label_100D_8721_187F1_34571;
        }
    label_100D_8712_187E2_34567:
        CheckExternalEvents(cs1, 0x8712);
        // 100D:8712 mov AH,byte ptr SS:[BP]
        AH = UInt8[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8715 sub AH,AL
        AH = Alu8.Sub(AH, AL);
        // 100D:8717 je short 0x8721
        if (ZeroFlag)
        {
            goto label_100D_8721_187F1_34571;
        }
    label_100D_8719_187E9_34575:
        CheckExternalEvents(cs1, 0x8719);
        // 100D:8719 cmp AH,BH
        Alu8.Sub(AH, BH);
        // 100D:871B ja short 0x8721
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_8721_187F1_34571;
        }
    label_100D_871D_187ED_34578:
        CheckExternalEvents(cs1, 0x871D);
        // 100D:871D mov BH,AH
        BH = AH;
        // 100D:871F mov DI,SI
        DI = SI;
    label_100D_8721_187F1_34571:
        CheckExternalEvents(cs1, 0x8721);
        // 100D:8721 add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:8724 loop 0x8709
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_8709_187D9_34564;
        }
    label_100D_8726_187F6_34581:
        CheckExternalEvents(cs1, 0x8726);
        // 100D:8726 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:8728 je short 0x86B8
        if (ZeroFlag)
        {
            goto label_100D_86B8_18788_24453;
        }
    label_100D_872A_187FA_34584:
        CheckExternalEvents(cs1, 0x872A);
        // 100D:872A mov SI,DI
        SI = DI;
    label_100D_872C_187FC_30128:
        CheckExternalEvents(cs1, 0x872C);
        // 100D:872C mov SI,word ptr DS:[SI+0x0A]
        SI = UInt16[DS, (ushort)(SI + (sbyte)10)];
        // 100D:872F mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:8731 cmp word ptr DS:[0x1176],2
        Alu16.Sub(UInt16[DS, (ushort)0x1176], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:8736 jae short 0x8741
        if (!CarryFlag)
        {
            goto label_100D_8741_18811_30137;
        }
    label_100D_8738_18808_30133:
        CheckExternalEvents(cs1, 0x8738);
        // 100D:8738 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:873B cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:873F jne short 0x8750
        if (!ZeroFlag)
        {
            goto label_100D_8750_18820_30969;
        }
    label_100D_8741_18811_30137:
        CheckExternalEvents(cs1, 0x8741);
        // 100D:8741 cmp AL,byte ptr DS:[0x1954]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1954]);
        // 100D:8745 je short 0x874D
        if (ZeroFlag)
        {
            goto label_100D_874D_1881D_40136;
        }
    label_100D_8747_18817_30140:
        CheckExternalEvents(cs1, 0x8747);
        // 100D:8747 mov byte ptr DS:[0x1954],AL
        UInt8[DS, (ushort)0x1954] = AL;
        // 100D:874A jmp near 0x8685
        goto label_100D_8685_18755_23575;
    label_100D_874D_1881D_40136:
        CheckExternalEvents(cs1, 0x874D);
        // 100D:874D jmp near 0x7C02
        if (JumpDispatcher.Jump(unknown_100D_7C02_17CD2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_8750_18820_30969:
        CheckExternalEvents(cs1, 0x8750);
        // 100D:8750 ret near
        return NearRet((ushort)0x0000);
    label_100D_92F2_193C2_15412:
        CheckExternalEvents(cs1, 0x92F2);
        // 100D:92F2 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:92F4 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_92F7_193C7_20397:
        CheckExternalEvents(cs1, 0x92F7);
        // 100D:92F7 mov AL,1
        AL = (byte)0x01;
        // 100D:92F9 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_92FC_193CC_33283:
        CheckExternalEvents(cs1, 0x92FC);
        // 100D:92FC mov AL,2
        AL = (byte)0x02;
        // 100D:92FE jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_9301_193D1_26927:
        CheckExternalEvents(cs1, 0x9301);
        // 100D:9301 mov AL,3
        AL = (byte)0x03;
        // 100D:9303 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_9306_193D6_23066:
        CheckExternalEvents(cs1, 0x9306);
        // 100D:9306 mov AL,4
        AL = (byte)0x04;
        // 100D:9308 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_930B_193DB_33492:
        CheckExternalEvents(cs1, 0x930B);
        // 100D:930B mov AL,5
        AL = (byte)0x05;
        // 100D:930D jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_9310_193E0_35316:
        CheckExternalEvents(cs1, 0x9310);
        // 100D:9310 mov AL,6
        AL = (byte)0x06;
        // 100D:9312 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_9315_193E5_34586:
        CheckExternalEvents(cs1, 0x9315);
        // 100D:9315 mov AL,7
        AL = (byte)0x07;
        // 100D:9317 jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_931A_193EA_32039:
        CheckExternalEvents(cs1, 0x931A);
        // 100D:931A mov AL,8
        AL = (byte)0x08;
        // 100D:931C jmp near 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_932E_193FE_38252:
        CheckExternalEvents(cs1, 0x932E);
        // 100D:932E mov SI,word ptr DS:[0x4768]
        SI = UInt16[DS, (ushort)0x4768];
        // 100D:9332 call near 0x31F6
        NearCall(cs1, 0x9335, unknown_100D_31F6_132C6);
    label_100D_9335_19405_38257:
        CheckExternalEvents(cs1, 0x9335);
        // 100D:9335 call near 0x407E
        NearCall(cs1, 0x9338, unknown_100D_407E_1414E);
    label_100D_9338_19408_38260:
        CheckExternalEvents(cs1, 0x9338);
        // 100D:9338 mov BP,0x0044
        BP = (ushort)0x0044;
        // 100D:933B cmp word ptr SS:[BP],0
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:933F jne short 0x9356
        if (!ZeroFlag)
        {
            goto label_100D_9356_19426_38264;
        }
    label_100D_9341_19411_38266:
        CheckExternalEvents(cs1, 0x9341);
        // 100D:9341 mov AX,word ptr DS:[0x00E2]
        AX = UInt16[DS, (ushort)0x00E2];
        // 100D:9344 cmp AX,0x001E
        Alu16.Sub(AX, (ushort)0x001E);
        // 100D:9347 jae short 0x936B
        if (!CarryFlag)
        {
            goto label_100D_936B_1943B_38272;
        }
    label_100D_9349_19419_38274:
        CheckExternalEvents(cs1, 0x9349);
        // 100D:9349 mov BP,0x00E4
        BP = (ushort)0x00E4;
        // 100D:934C mov SI,word ptr DS:[0x4768]
        SI = UInt16[DS, (ushort)0x4768];
        // 100D:9350 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:9353 mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
    label_100D_9356_19426_38264:
        CheckExternalEvents(cs1, 0x9356);
        // 100D:9356 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 100D:9359 call near 0x5323
        NearCall(cs1, 0x935C, unknown_100D_5323_153F3);
    label_100D_935C_1942C_40290:
        CheckExternalEvents(cs1, 0x935C);
        // 100D:935C pop DI
        DI = Stack.Pop16();
        // 100D:935D add AX,0x00DA
        AX = Alu16.Add(AX, (ushort)0x00DA);
        // 100D:9360 push AX
        Stack.Push16(AX);
        // 100D:9361 call near 0x331E
        NearCall(cs1, 0x9364, unknown_100D_331E_133EE);
    label_100D_9364_19434_40299:
        CheckExternalEvents(cs1, 0x9364);
        // 100D:9364 call near 0x2E98
        NearCall(cs1, 0x9367, unknown_100D_2E98_12F68);
    label_100D_9367_19437_40302:
        CheckExternalEvents(cs1, 0x9367);
        // 100D:9367 pop word ptr DS:[0x11FD]
        ushort popStackCheck_100D_9367_19437 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_9367_19437 = UInt16[DS, (ushort)0x11FD];
        ushort poppedValue_100D_9367_19437 = Stack.Pop16();
        UInt16[DS, (ushort)0x11FD] = unchecked((ushort)poppedValue_100D_9367_19437);
    label_100D_936B_1943B_38272:
        CheckExternalEvents(cs1, 0x936B);
        // 100D:936B mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:936D jmp short 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_936F_1943F_33901:
        CheckExternalEvents(cs1, 0x936F);
        // 100D:936F mov AL,0x0D
        AL = (byte)0x0D;
        // 100D:9371 jmp short 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_9373_19443_23170:
        CheckExternalEvents(cs1, 0x9373);
        // 100D:9373 mov SI,word ptr DS:[0x4756]
        SI = UInt16[DS, (ushort)0x4756];
        // 100D:9377 call near 0x31F6
        NearCall(cs1, 0x937A, unknown_100D_31F6_132C6);
    label_100D_937A_1944A_23173:
        CheckExternalEvents(cs1, 0x937A);
        // 100D:937A mov AL,0x0E
        AL = (byte)0x0E;
        // 100D:937C jmp short 0x93AA
        goto label_100D_93AA_1947A_15415;
    label_100D_937E_1944E_26986:
        CheckExternalEvents(cs1, 0x937E);
        // 100D:937E sub AX,0x0087
        AX = Alu16.Sub(AX, (ushort)0x0087);
    label_100D_9381_19451_26988:
        CheckExternalEvents(cs1, 0x9381);
        // 100D:9381 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:9383 jb short 0x9387
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9383");
        }
    label_100D_9387_19457_26990:
        CheckExternalEvents(cs1, 0x9387);
        // 100D:9387 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:9389 jne short 0x9394
        if (!ZeroFlag)
        {
            goto label_100D_9394_19464_26993;
        }
    label_100D_938B_1945B_32035:
        CheckExternalEvents(cs1, 0x938B);
        // 100D:938B mov AL,byte ptr DS:[0x476B]
        AL = UInt8[DS, (ushort)0x476B];
        // 100D:938E dec AL
        AL = Alu8.Dec(AL);
        // 100D:9390 jns short 0x9394
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9390");
        }
    label_100D_9394_19464_26993:
        CheckExternalEvents(cs1, 0x9394);
        // 100D:9394 mov byte ptr DS:[0x476C],AL
        UInt8[DS, (ushort)0x476C] = AL;
        // 100D:9397 mov SI,0x4758
        SI = (ushort)0x4758;
        // 100D:939A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:939C add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:939E add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:93A0 mov SI,word ptr DS:[SI]
        SI = UInt16[DS, SI];
        // 100D:93A2 call near 0x1EBE
        NearCall(cs1, 0x93A5, unknown_100D_1EBE_11F8E);
    label_100D_93A5_19475_27001:
        CheckExternalEvents(cs1, 0x93A5);
        // 100D:93A5 call near 0x31F6
        NearCall(cs1, 0x93A8, unknown_100D_31F6_132C6);
    label_100D_93A8_19478_27011:
        CheckExternalEvents(cs1, 0x93A8);
        // 100D:93A8 mov AL,0x0F
        AL = (byte)0x0F;
    label_100D_93AA_1947A_15415:
        CheckExternalEvents(cs1, 0x93AA);
        // 100D:93AA xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:93AC mov word ptr DS:[0x47E1],0
        UInt16[DS, (ushort)0x47E1] = (ushort)0x0000;
        // 100D:93B2 push AX
        Stack.Push16(AX);
        // 100D:93B3 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:93B6 call near 0x91A0
        NearCall(cs1, 0x93B9, unknown_100D_91A0_19270);
    label_100D_93B9_19489_15421:
        CheckExternalEvents(cs1, 0x93B9);
        // 100D:93B9 call near 0x3AF9
        NearCall(cs1, 0x93BC, unknown_100D_3AF9_13BC9);
    label_100D_93BC_1948C_15462:
        CheckExternalEvents(cs1, 0x93BC);
        // 100D:93BC call near 0x9197
        NearCall(cs1, 0x93BF, unknown_100D_9197_19267);
    label_100D_93BF_1948F_15464:
        CheckExternalEvents(cs1, 0x93BF);
        // 100D:93BF call near 0x9908
        NearCall(cs1, 0x93C2, unknown_100D_9908_199D8);
    label_100D_93C2_19492_15466:
        CheckExternalEvents(cs1, 0x93C2);
        // 100D:93C2 mov SI,word ptr DS:[0x47C8]
        SI = UInt16[DS, (ushort)0x47C8];
        // 100D:93C6 mov word ptr DS:[0x4540],0
        UInt16[DS, (ushort)0x4540] = (ushort)0x0000;
        // 100D:93CC call near 0x9BAC
        NearCall(cs1, 0x93CF, unknown_100D_9BAC_19C7C);
    label_100D_93CF_1949F_15470:
        CheckExternalEvents(cs1, 0x93CF);
        // 100D:93CF call near 0x1834
        NearCall(cs1, 0x93D2, unknown_100D_1834_11904);
    label_100D_93D2_194A2_15472:
        CheckExternalEvents(cs1, 0x93D2);
        // 100D:93D2 call near 0xC0F4
        NearCall(cs1, 0x93D5, unknown_100D_C0F4_1C1C4);
    label_100D_93D5_194A5_15474:
        CheckExternalEvents(cs1, 0x93D5);
        // 100D:93D5 call near 0xC4DD
        NearCall(cs1, 0x93D8, unknown_100D_C4DD_1C5AD);
    label_100D_93D8_194A8_15476:
        CheckExternalEvents(cs1, 0x93D8);
        // 100D:93D8 pop AX
        AX = Stack.Pop16();
        // 100D:93D9 call near 0x93DF
        NearCall(cs1, 0x93DC, unknown_100D_93DF_194AF);
    label_100D_93DC_194AC_15579:
        CheckExternalEvents(cs1, 0x93DC);
        // 100D:93DC jmp near 0x9472
    label_100D_9472_19542_15581:
        CheckExternalEvents(cs1, 0x9472);
        // 100D:9472 call near 0x9F40
        NearCall(cs1, 0x9475, unknown_100D_9F40_1A010);
    label_100D_9475_19545_15603:
        CheckExternalEvents(cs1, 0x9475);
        // 100D:9475 mov byte ptr DS:[0x226D],0x0A
        UInt8[DS, (ushort)0x226D] = (byte)0x0A;
        // 100D:947A mov byte ptr DS:[0x001B],0
        UInt8[DS, (ushort)0x001B] = (byte)0x00;
        // 100D:947F cmp word ptr DS:[0x47B6],0
        Alu16.Sub(UInt16[DS, (ushort)0x47B6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:9484 jne short 0x94DD
        if (!ZeroFlag)
        {
            goto label_100D_94DD_195AD_26970;
        }
    label_100D_9486_19556_15608:
        CheckExternalEvents(cs1, 0x9486);
        // 100D:9486 mov SI,word ptr DS:[0x47BA]
        SI = UInt16[DS, (ushort)0x47BA];
        // 100D:948A or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:948C jne short 0x949A
        if (!ZeroFlag)
        {
            goto label_100D_949A_1956A_15617;
        }
    label_100D_948E_1955E_15612:
        CheckExternalEvents(cs1, 0x948E);
        // 100D:948E mov SI,word ptr DS:[0x47BE]
        SI = UInt16[DS, (ushort)0x47BE];
    label_100D_9492_19562_15614:
        CheckExternalEvents(cs1, 0x9492);
        // 100D:9492 mov AX,SI
        AX = SI;
        // 100D:9494 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:9496 mov SI,word ptr DS:[SI-21898]
        SI = UInt16[DS, (ushort)(SI + (short)-21898)];
    label_100D_949A_1956A_15617:
        CheckExternalEvents(cs1, 0x949A);
        // 100D:949A cmp SI,-1
        Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:949D je short 0x94B9
        if (ZeroFlag)
        {
            goto label_100D_94B9_19589_20445;
        }
    label_100D_949F_1956F_15619:
        CheckExternalEvents(cs1, 0x949F);
        // 100D:949F call near 0x9B49
        NearCall(cs1, 0x94A2, unknown_100D_9B49_19C19);
    label_100D_94A2_19572_15628:
        CheckExternalEvents(cs1, 0x94A2);
        // 100D:94A2 call near 0x9F9E
        NearCall(cs1, 0x94A5, unknown_100D_9F9E_1A06E);
    label_100D_94A5_19575_15656:
        CheckExternalEvents(cs1, 0x94A5);
        // 100D:94A5 mov word ptr DS:[0x47BA],SI
        UInt16[DS, (ushort)0x47BA] = SI;
        // 100D:94A9 jae short 0x94DA
        if (!CarryFlag)
        {
            goto label_100D_94DA_195AA_15783;
        }
    label_100D_94AB_1957B_15659:
        CheckExternalEvents(cs1, 0x94AB);
        // 100D:94AB mov AX,word ptr DS:[0x47BE]
        AX = UInt16[DS, (ushort)0x47BE];
        // 100D:94AE inc AX
        AX = Alu16.Inc(AX);
        // 100D:94AF mov word ptr DS:[0x47BE],AX
        UInt16[DS, (ushort)0x47BE] = AX;
        // 100D:94B2 mov SI,AX
        SI = AX;
        // 100D:94B4 and AX,3
        AX = Alu16.And(AX, (ushort)0x0003);
        // 100D:94B7 jne short 0x9492
        if (!ZeroFlag)
        {
            goto label_100D_9492_19562_15614;
        }
    label_100D_94B9_19589_20445:
        CheckExternalEvents(cs1, 0x94B9);
        // 100D:94B9 cmp word ptr DS:[0x47C4],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:94BE je short 0x94C3
        if (ZeroFlag)
        {
            goto label_100D_94C3_19593_34022;
        }
    label_100D_94C0_19590_20448:
        CheckExternalEvents(cs1, 0x94C0);
        // 100D:94C0 jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_94C3_19593_34022:
        CheckExternalEvents(cs1, 0x94C3);
        // 100D:94C3 cmp SI,-1
        Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:94C6 jne short 0x94CC
        if (!ZeroFlag)
        {
            goto label_100D_94CC_1959C_34027;
        }
    label_100D_94C8_19598_34025:
        CheckExternalEvents(cs1, 0x94C8);
        // 100D:94C8 mov SI,word ptr DS:[0x47BE]
        SI = UInt16[DS, (ushort)0x47BE];
    label_100D_94CC_1959C_34027:
        CheckExternalEvents(cs1, 0x94CC);
        // 100D:94CC and SI,-8
        SI = Alu16.And(SI, unchecked((ushort)unchecked((short)(sbyte)-8)));
        // 100D:94CF mov word ptr DS:[0x47BE],SI
        UInt16[DS, (ushort)0x47BE] = SI;
        // 100D:94D3 mov byte ptr DS:[0x47C2],0x20
        UInt8[DS, (ushort)0x47C2] = (byte)0x20;
        // 100D:94D8 jmp short 0x9492
        goto label_100D_9492_19562_15614;
    label_100D_94DA_195AA_15783:
        CheckExternalEvents(cs1, 0x94DA);
        // 100D:94DA jmp near 0xD280
        if (JumpDispatcher.Jump(unknown_100D_D280_1D350, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_94DD_195AD_26970:
        CheckExternalEvents(cs1, 0x94DD);
        // 100D:94DD lds SI,word ptr DS:[0x47B6]
        ushort lxsOffset_100D_94DD_195AD = (ushort)0x47B6;
        ushort lxsValue_100D_94DD_195AD = UInt16[DS, lxsOffset_100D_94DD_195AD];
        ushort lxsSegment_100D_94DD_195AD = UInt16[DS, (ushort)(lxsOffset_100D_94DD_195AD + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_94DD_195AD);
        DS = unchecked((ushort)lxsSegment_100D_94DD_195AD);
        // 100D:94E1 call near 0x88D2
        NearCall(cs1, 0x94E4, unknown_100D_88D2_189A2);
    label_100D_94E4_195B4_26977:
        CheckExternalEvents(cs1, 0x94E4);
        // 100D:94E4 mov SI,word ptr DS:[0x47BA]
        SI = UInt16[DS, (ushort)0x47BA];
        // 100D:94E8 add word ptr DS:[0x4780],0x1000
        UInt16[DS, (ushort)0x4780] = Alu16.Add(UInt16[DS, (ushort)0x4780], (ushort)0x1000);
        // 100D:94EE call near 0xA03F
        NearCall(cs1, 0x94F1, unknown_100D_A03F_1A10F);
    label_100D_94F1_195C1_26982:
        CheckExternalEvents(cs1, 0x94F1);
        // 100D:94F1 jmp short 0x94A5
        goto label_100D_94A5_19575_15656;
    label_100D_9533_19603_25901:
        CheckExternalEvents(cs1, 0x9533);
        // 100D:9533 call near 0xA1C4
        NearCall(cs1, 0x9536, unknown_100D_A1C4_1A294);
    label_100D_9536_19606_25903:
        CheckExternalEvents(cs1, 0x9536);
        // 100D:9536 mov AX,6
        AX = (ushort)0x0006;
        // 100D:9539 call near 0x9F31
        NearCall(cs1, 0x953C, unknown_100D_9F31_1A001);
    label_100D_953C_1960C_25906:
        CheckExternalEvents(cs1, 0x953C);
        // 100D:953C call near 0x9F8B
        NearCall(cs1, 0x953F, unknown_100D_9F8B_1A05B);
    label_100D_953F_1960F_25959:
        CheckExternalEvents(cs1, 0x953F);
        // 100D:953F inc byte ptr DS:[0x001B]
        UInt8[DS, (ushort)0x001B] = Alu8.Inc(UInt8[DS, (ushort)0x001B]);
        // 100D:9543 call near 0xA1E2
        NearCall(cs1, 0x9546, unknown_100D_A1E2_1A2B2);
    label_100D_9546_19616_25962:
        CheckExternalEvents(cs1, 0x9546);
        // 100D:9546 jne short 0x956C
        if (!ZeroFlag)
        {
            goto label_100D_956C_1963C_25978;
        }
    label_100D_9548_19618_25964:
        CheckExternalEvents(cs1, 0x9548);
        // 100D:9548 mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:954C call near 0x1E01
        NearCall(cs1, 0x954F, unknown_100D_1E01_11ED1);
    label_100D_954F_1961F_25967:
        CheckExternalEvents(cs1, 0x954F);
        // 100D:954F jae short 0x9556
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_9556_19626, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9551_19621_35764:
        CheckExternalEvents(cs1, 0x9551);
        // 100D:9551 add byte ptr DS:[0x00F9],0x10
        UInt8[DS, (ushort)0x00F9] = Alu8.Add(UInt8[DS, (ushort)0x00F9], (byte)0x10);
        if (JumpDispatcher.Jump(unknown_100D_9556_19626, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_956C_1963C_25978:
        CheckExternalEvents(cs1, 0x956C);
        // 100D:956C ret near
        return NearRet((ushort)0x0000);
    label_100D_9584_19654_38206:
        CheckExternalEvents(cs1, 0x9584);
        // 100D:9584 mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:9588 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:958B mov AX,1
        AX = (ushort)0x0001;
        // 100D:958E shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:9590 and word ptr DS:[0x00EE],AX
        Alu16.And(UInt16[DS, (ushort)0x00EE], AX);
        // 100D:9594 jne short 0x95B4
        if (!ZeroFlag)
        {
            goto label_100D_95B4_19684_38213;
        }
    label_100D_9596_19666_38215:
        CheckExternalEvents(cs1, 0x9596);
        // 100D:9596 or word ptr DS:[0x00EE],AX
        UInt16[DS, (ushort)0x00EE] = Alu16.Or(UInt16[DS, (ushort)0x00EE], AX);
        // 100D:959A mov SI,word ptr DS:[0x4768]
        SI = UInt16[DS, (ushort)0x4768];
        // 100D:959E mov AL,0x20
        AL = (byte)0x20;
        // 100D:95A0 sub byte ptr DS:[SI+0x15],0x29
        UInt8[DS, (ushort)(SI + (sbyte)21)] = Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x29);
        // 100D:95A4 sub byte ptr DS:[0x00ED],0x29
        UInt8[DS, (ushort)0x00ED] = Alu8.Sub(UInt8[DS, (ushort)0x00ED], (byte)0x29);
        // 100D:95A9 jns short 0x95B4
        if (!SignFlag)
        {
            goto label_100D_95B4_19684_38213;
        }
    label_100D_95AB_1967B_38227:
        CheckExternalEvents(cs1, 0x95AB);
        // 100D:95AB or byte ptr DS:[SI+3],0x10
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x10);
        // 100D:95AF or byte ptr DS:[0x10A7],0x10
        UInt8[DS, (ushort)0x10A7] = Alu8.Or(UInt8[DS, (ushort)0x10A7], (byte)0x10);
    label_100D_95B4_19684_38213:
        CheckExternalEvents(cs1, 0x95B4);
        // 100D:95B4 mov AX,0x0085
        AX = (ushort)0x0085;
        // 100D:95B7 inc byte ptr DS:[0x47DC]
        UInt8[DS, (ushort)0x47DC] = Alu8.Inc(UInt8[DS, (ushort)0x47DC]);
        // 100D:95BB call near 0x970B
        NearCall(cs1, 0x95BE, unknown_100D_970B_197DB);
    label_100D_95BE_1968E_38247:
        CheckExternalEvents(cs1, 0x95BE);
        // 100D:95BE jmp near 0x96EB
        goto label_100D_96EB_197BB_27205;
    label_100D_95C1_19691_23195:
        CheckExternalEvents(cs1, 0x95C1);
        // 100D:95C1 mov AX,0x0064
        AX = (ushort)0x0064;
        // 100D:95C4 cmp word ptr DS:[0x00AC],0x03E8
        Alu16.Sub(UInt16[DS, (ushort)0x00AC], (ushort)0x03E8);
        // 100D:95CA jb short 0x95DE
        if (CarryFlag)
        {
            goto label_100D_95DE_196AE_23207;
        }
    label_100D_95CC_1969C_23199:
        CheckExternalEvents(cs1, 0x95CC);
        // 100D:95CC sub AL,byte ptr DS:[0x0029]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x0029]);
        // 100D:95D0 jb short 0x95DE
        if (CarryFlag)
        {
            goto label_100D_95DE_196AE_23207;
        }
    label_100D_95D2_196A2_23202:
        CheckExternalEvents(cs1, 0x95D2);
        // 100D:95D2 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:95D4 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:95D6 cmp AL,byte ptr DS:[0x0036]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x0036]);
        // 100D:95DA jbe short 0x95DE
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_95DE_196AE_23207;
        }
    label_100D_95DC_196AC_26004:
        CheckExternalEvents(cs1, 0x95DC);
        // 100D:95DC mov AH,2
        AH = (byte)0x02;
    label_100D_95DE_196AE_23207:
        CheckExternalEvents(cs1, 0x95DE);
        // 100D:95DE mov byte ptr DS:[0x0023],AH
        UInt8[DS, (ushort)0x0023] = AH;
    label_100D_95E2_196B2_16169:
        CheckExternalEvents(cs1, 0x95E2);
        // 100D:95E2 call near 0xA1C4
        NearCall(cs1, 0x95E5, unknown_100D_A1C4_1A294);
    label_100D_95E5_196B5_16174:
        CheckExternalEvents(cs1, 0x95E5);
        // 100D:95E5 mov AX,5
        AX = (ushort)0x0005;
        // 100D:95E8 call near 0x9F31
        NearCall(cs1, 0x95EB, unknown_100D_9F31_1A001);
    label_100D_95EB_196BB_16183:
        CheckExternalEvents(cs1, 0x95EB);
        // 100D:95EB call near 0x9F8B
        NearCall(cs1, 0x95EE, unknown_100D_9F8B_1A05B);
    label_100D_95EE_196BE_16205:
        CheckExternalEvents(cs1, 0x95EE);
        // 100D:95EE inc byte ptr DS:[0x001B]
        UInt8[DS, (ushort)0x001B] = Alu8.Inc(UInt8[DS, (ushort)0x001B]);
        // 100D:95F2 mov byte ptr DS:[0x0023],0
        UInt8[DS, (ushort)0x0023] = (byte)0x00;
        // 100D:95F7 call near 0xA1E2
        NearCall(cs1, 0x95FA, unknown_100D_A1E2_1A2B2);
    label_100D_95FA_196CA_16212:
        CheckExternalEvents(cs1, 0x95FA);
        // 100D:95FA jne short 0x961A
        if (!ZeroFlag)
        {
            goto label_100D_961A_196EA_16214;
        }
    label_100D_95FC_196CC_23090:
        CheckExternalEvents(cs1, 0x95FC);
        // 100D:95FC mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:9600 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:9603 cmp CL,0x0E
        Alu8.Sub(CL, (byte)0x0E);
        // 100D:9606 je short 0x961B
        if (ZeroFlag)
        {
            goto label_100D_961B_196EB_23221;
        }
    label_100D_9608_196D8_23095:
        CheckExternalEvents(cs1, 0x9608);
        // 100D:9608 or byte ptr DS:[SI+0x0F],0x40
        UInt8[DS, (ushort)(SI + (sbyte)15)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:960C xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:960E call near 0x956D
        NearCall(cs1, 0x9611, unknown_100D_956D_1963D);
    label_100D_9611_196E1_23110:
        CheckExternalEvents(cs1, 0x9611);
        // 100D:9611 mov AX,1
        AX = (ushort)0x0001;
        // 100D:9614 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:9616 or word ptr DS:[0x0010],AX
        UInt16[DS, (ushort)0x0010] = Alu16.Or(UInt16[DS, (ushort)0x0010], AX);
    label_100D_961A_196EA_16214:
        CheckExternalEvents(cs1, 0x961A);
        // 100D:961A ret near
        return NearRet((ushort)0x0000);
    label_100D_961B_196EB_23221:
        CheckExternalEvents(cs1, 0x961B);
        // 100D:961B mov SI,word ptr DS:[0x4756]
        SI = UInt16[DS, (ushort)0x4756];
        // 100D:961F push SI
        Stack.Push16(SI);
        // 100D:9620 call near 0x66CE
        NearCall(cs1, 0x9623, unknown_100D_66CE_1679E);
    label_100D_9623_196F3_23393:
        CheckExternalEvents(cs1, 0x9623);
        // 100D:9623 call near 0x2EFB
        NearCall(cs1, 0x9626, unknown_100D_2EFB_12FCB);
    label_100D_9626_196F6_23395:
        CheckExternalEvents(cs1, 0x9626);
        // 100D:9626 call near 0x3093
        NearCall(cs1, 0x9629, unknown_100D_3093_13163);
    label_100D_9629_196F9_23438:
        CheckExternalEvents(cs1, 0x9629);
        // 100D:9629 pop SI
        SI = Stack.Pop16();
        // 100D:962A cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:962E jne short 0x9639
        if (!ZeroFlag)
        {
            goto label_100D_9639_19709_23442;
        }
    label_100D_9630_19700_28311:
        CheckExternalEvents(cs1, 0x9630);
        // 100D:9630 add byte ptr DS:[SI+0x15],0x18
        UInt8[DS, (ushort)(SI + (sbyte)21)] = Alu8.Add(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x18);
        // 100D:9634 add byte ptr DS:[0x0036],0x18
        UInt8[DS, (ushort)0x0036] = Alu8.Add(UInt8[DS, (ushort)0x0036], (byte)0x18);
    label_100D_9639_19709_23442:
        CheckExternalEvents(cs1, 0x9639);
        // 100D:9639 mov AX,SI
        AX = SI;
        // 100D:963B mov CX,8
        CX = (ushort)0x0008;
        // 100D:963E push DS
        Stack.Push16(DS);
        // 100D:963F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9640 mov DI,0x4758
        DI = (ushort)0x4758;
        // 100D:9643 repne scas AX,word ptr ES:[DI]
        bool shouldContinue_100D_9643_19713 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_9643_19713)
        {
            Alu16.Sub(AX, UInt16[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_9643_19713 = ZeroFlag == false;
        }
        // 100D:9645 mov AL,7
        AL = (byte)0x07;
        // 100D:9647 sub AL,CL
        AL = Alu8.Sub(AL, CL);
        // 100D:9649 mov byte ptr DS:[0x476C],AL
        UInt8[DS, (ushort)0x476C] = AL;
        // 100D:964C mov SI,0x10C8
        SI = (ushort)0x10C8;
        // 100D:964F call near 0x90BD
        NearCall(cs1, 0x9652, unknown_100D_90BD_1918D);
    label_100D_9652_19722_23454:
        CheckExternalEvents(cs1, 0x9652);
        // 100D:9652 jmp near 0xD280
        if (JumpDispatcher.Jump(unknown_100D_D280_1D350, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_96EB_197BB_27205:
        CheckExternalEvents(cs1, 0x96EB);
        // 100D:96EB mov byte ptr DS:[0x47DC],0
        UInt8[DS, (ushort)0x47DC] = (byte)0x00;
        // 100D:96F0 ret near
        return NearRet((ushort)0x0000);
    label_100D_9ED5_19FA5_16216:
        CheckExternalEvents(cs1, 0x9ED5);
        // 100D:9ED5 cmp word ptr DS:[0x47C4],0x0010
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:9EDA jae short 0x9EEB
        if (!CarryFlag)
        {
            goto label_100D_9EEB_19FBB_16224;
        }
    label_100D_9EDC_19FAC_16219:
        CheckExternalEvents(cs1, 0x9EDC);
        // 100D:9EDC call near 0x9985
        NearCall(cs1, 0x9EDF, unknown_100D_9985_19A55);
    label_100D_9EDF_19FAF_16221:
        CheckExternalEvents(cs1, 0x9EDF);
        // 100D:9EDF cmp byte ptr DS:[0x47E1],0x81
        Alu8.Sub(UInt8[DS, (ushort)0x47E1], (byte)0x81);
        // 100D:9EE4 jne short 0x9EEB
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9EE4");
        }
    label_100D_9EEB_19FBB_16224:
        CheckExternalEvents(cs1, 0x9EEB);
        // 100D:9EEB call near 0xC85B
        NearCall(cs1, 0x9EEE, unknown_100D_C85B_1C92B);
    label_100D_9EEE_19FBE_16226:
        CheckExternalEvents(cs1, 0x9EEE);
        // 100D:9EEE mov AL,byte ptr DS:[0x47DD]
        AL = UInt8[DS, (ushort)0x47DD];
        if (JumpDispatcher.Jump(unknown_100D_9EF1_19FC1, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_A3F0_1A4C0_25334:
        CheckExternalEvents(cs1, 0xA3F0);
        // 100D:A3F0 mov AX,0x1AD6
        AX = (ushort)0x1AD6;
        // 100D:A3F3 call near 0xD95E
        NearCall(cs1, 0xA3F6, unknown_100D_D95E_1DA2E);
    label_100D_A3F6_1A4C6_25337:
        CheckExternalEvents(cs1, 0xA3F6);
        // 100D:A3F6 call near 0xD2BD
        NearCall(cs1, 0xA3F9, unknown_100D_D2BD_1D38D);
    label_100D_A3F9_1A4C9_25339:
        CheckExternalEvents(cs1, 0xA3F9);
        // 100D:A3F9 push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:A3FD call near 0xC08E
        NearCall(cs1, 0xA400, unknown_100D_C08E_1C15E);
    label_100D_A400_1A4D0_25342:
        CheckExternalEvents(cs1, 0xA400);
        // 100D:A400 mov AX,0x0055
        AX = (ushort)0x0055;
        // 100D:A403 call near 0xC13E
        NearCall(cs1, 0xA406, unknown_100D_C13E_1C20E);
    label_100D_A406_1A4D6_25345:
        CheckExternalEvents(cs1, 0xA406);
        // 100D:A406 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:A408 mov DX,word ptr DS:[0x2886]
        DX = UInt16[DS, (ushort)0x2886];
        // 100D:A40C mov BX,word ptr DS:[0x2888]
        BX = UInt16[DS, (ushort)0x2888];
        // 100D:A410 call near 0xC22F
        NearCall(cs1, 0xA413, unknown_100D_C22F_1C2FF);
    label_100D_A413_1A4E3_25350:
        CheckExternalEvents(cs1, 0xA413);
        // 100D:A413 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_A413_1A4E3 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_A413_1A4E3 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_A413_1A4E3 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_A413_1A4E3);
        // 100D:A417 call near 0xA4C6
        NearCall(cs1, 0xA41A, unknown_100D_A4C6_1A596);
    label_100D_A41A_1A4EA_25412:
        CheckExternalEvents(cs1, 0xA41A);
        // 100D:A41A call near 0xA47D
        NearCall(cs1, 0xA41D, unknown_100D_A47D_1A54D);
    label_100D_A41D_1A4ED_25450:
        CheckExternalEvents(cs1, 0xA41D);
        // 100D:A41D call near 0xA42C
        NearCall(cs1, 0xA420, unknown_100D_A42C_1A4FC);
    label_100D_A420_1A4F0_25482:
        CheckExternalEvents(cs1, 0xA420);
        // 100D:A420 call near 0xA44C
        NearCall(cs1, 0xA423, unknown_100D_A44C_1A51C);
    label_100D_A423_1A4F3_25489:
        CheckExternalEvents(cs1, 0xA423);
        // 100D:A423 call near 0xAC3A
        NearCall(cs1, 0xA426, unknown_100D_AC3A_1AD0A);
    label_100D_A426_1A4F6_25512:
        CheckExternalEvents(cs1, 0xA426);
        // 100D:A426 mov BX,0xA541
        BX = (ushort)0xA541;
        // 100D:A429 jmp near 0xD32F
        goto label_100D_D32F_1D3FF_25515;
    label_100D_AC6E_1AD3E_25798:
        CheckExternalEvents(cs1, 0xAC6E);
        // 100D:AC6E and byte ptr DS:[0x2943],0xEF
        UInt8[DS, (ushort)0x2943] = Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0xEF);
        // 100D:AC73 mov byte ptr DS:[0x3810],0
        UInt8[DS, (ushort)0x3810] = (byte)0x00;
        // 100D:AC78 call near 0xD2E2
        NearCall(cs1, 0xAC7B, unknown_100D_D2E2_1D3B2);
    label_100D_AC7B_1AD4B_25802:
        CheckExternalEvents(cs1, 0xAC7B);
        // 100D:AC7B jmp near 0xAD5E
        return unknown_100D_AD5E_1AE2E(0x0000);
    label_100D_AC7E_1AD4E_25743:
        CheckExternalEvents(cs1, 0xAC7E);
        // 100D:AC7E mov BP,0x206A
        BP = (ushort)0x206A;
        // 100D:AC81 mov BX,0xD917
        BX = (ushort)0xD917;
        // 100D:AC84 mov CL,byte ptr DS:[0x3810]
        CL = UInt8[DS, (ushort)0x3810];
        // 100D:AC88 and CX,2
        CX = Alu16.And(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:AC8B shr CL,1
        CL = Alu8.Shr(CL, 1);
        // 100D:AC8D jmp near 0xD32F
        goto label_100D_D32F_1D3FF_25515;
    label_100D_AC90_1AD60_25750:
        CheckExternalEvents(cs1, 0xAC90);
        // 100D:AC90 or byte ptr DS:[0x3810],3
        UInt8[DS, (ushort)0x3810] = Alu8.Or(UInt8[DS, (ushort)0x3810], (byte)0x03);
        // 100D:AC95 jmp short 0xACAE
        goto label_100D_ACAE_1AD7E_25753;
    label_100D_AC97_1AD67_25804:
        CheckExternalEvents(cs1, 0xAC97);
        // 100D:AC97 or byte ptr DS:[0x3810],1
        UInt8[DS, (ushort)0x3810] = Alu8.Or(UInt8[DS, (ushort)0x3810], (byte)0x01);
        // 100D:AC9C and byte ptr DS:[0x3810],0xFD
        UInt8[DS, (ushort)0x3810] = Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0xFD);
        // 100D:ACA1 push DS
        Stack.Push16(DS);
        // 100D:ACA2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:ACA3 mov SI,0x3804
        SI = (ushort)0x3804;
        // 100D:ACA6 mov DI,0x37FA
        DI = (ushort)0x37FA;
        // 100D:ACA9 mov CX,9
        CX = (ushort)0x0009;
        // 100D:ACAC rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_100D_ACAE_1AD7E_25753:
        CheckExternalEvents(cs1, 0xACAE);
        // 100D:ACAE call near 0xAEB7
        NearCall(cs1, 0xACB1, unknown_100D_AEB7_1AF87);
    label_100D_ACB1_1AD81_25755:
        CheckExternalEvents(cs1, 0xACB1);
        // 100D:ACB1 call near 0xD2FD
        NearCall(cs1, 0xACB4, unknown_100D_D2FD_1D3CD);
    label_100D_ACB4_1AD84_25757:
        CheckExternalEvents(cs1, 0xACB4);
        // 100D:ACB4 call near 0xD2E2
        NearCall(cs1, 0xACB7, unknown_100D_D2E2_1D3B2);
    label_100D_ACB7_1AD87_25759:
        CheckExternalEvents(cs1, 0xACB7);
        // 100D:ACB7 and byte ptr DS:[0x2943],0xEF
        UInt8[DS, (ushort)0x2943] = Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0xEF);
        // 100D:ACBC jmp short 0xAD21
    label_100D_AD21_1ADF1_25762:
        CheckExternalEvents(cs1, 0xAD21);
        // 100D:AD21 mov SI,0x37FA
        SI = (ushort)0x37FA;
        // 100D:AD24 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:AD25 test byte ptr DS:[0x3810],2
        Alu8.And(UInt8[DS, (ushort)0x3810], (byte)0x02);
        // 100D:AD2A je short 0xAD30
        if (ZeroFlag)
        {
            goto label_100D_AD30_1AE00_25793;
        }
    label_100D_AD2C_1ADFC_25767:
        CheckExternalEvents(cs1, 0xAD2C);
        // 100D:AD2C call near 0xACBF
        NearCall(cs1, 0xAD2F, unknown_100D_ACBF_1AD8F);
    label_100D_AD2F_1ADFF_25791:
        CheckExternalEvents(cs1, 0xAD2F);
        // 100D:AD2F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
    label_100D_AD30_1AE00_25793:
        CheckExternalEvents(cs1, 0xAD30);
        // 100D:AD30 mov word ptr DS:[0x380E],SI
        UInt16[DS, (ushort)0x380E] = SI;
        // 100D:AD34 jmp short 0xAD95
        return unknown_100D_AD95_1AE65(0x0000);
    label_100D_AEAF_1AF7F_25814:
        CheckExternalEvents(cs1, 0xAEAF);
        // 100D:AEAF or byte ptr DS:[0x2943],0x10
        UInt8[DS, (ushort)0x2943] = Alu8.Or(UInt8[DS, (ushort)0x2943], (byte)0x10);
        // 100D:AEB4 call near 0xD2E2
        NearCall(cs1, 0xAEB7, unknown_100D_D2E2_1D3B2);
        return unknown_100D_AEB7_1AF87(0x0000);
    label_100D_AF58_1B028_39527:
        CheckExternalEvents(cs1, 0xAF58);
        // 100D:AF58 mov BX,0
        BX = (ushort)0x0000;
        // 100D:AF5B mov BP,0
        BP = (ushort)0x0000;
        // 100D:AF5E jmp short 0xAF76
        goto label_100D_AF76_1B046_16476;
    label_100D_AF60_1B030_16472:
        CheckExternalEvents(cs1, 0xAF60);
        // 100D:AF60 mov BX,0x041C
        BX = (ushort)0x041C;
        // 100D:AF63 mov BP,4
        BP = (ushort)0x0004;
        // 100D:AF66 jmp short 0xAF76
        goto label_100D_AF76_1B046_16476;
    label_100D_AF68_1B038_17267:
        CheckExternalEvents(cs1, 0xAF68);
        // 100D:AF68 mov BX,0x081C
        BX = (ushort)0x081C;
        // 100D:AF6B mov BP,8
        BP = (ushort)0x0008;
        // 100D:AF6E jmp short 0xAF76
        goto label_100D_AF76_1B046_16476;
    label_100D_AF70_1B040_39522:
        CheckExternalEvents(cs1, 0xAF70);
        // 100D:AF70 mov BX,0x0C1C
        BX = (ushort)0x0C1C;
        // 100D:AF73 mov BP,0x000C
        BP = (ushort)0x000C;
    label_100D_AF76_1B046_16476:
        CheckExternalEvents(cs1, 0xAF76);
        // 100D:AF76 push BP
        Stack.Push16(BP);
        // 100D:AF77 test byte ptr DS:[0x00C6],2
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x02);
        // 100D:AF7C jne short 0xAF86
        if (!ZeroFlag)
        {
            goto label_100D_AF86_1B056_16480;
        }
    label_100D_AF7E_1B04E_17271:
        CheckExternalEvents(cs1, 0xAF7E);
        // 100D:AF7E push BX
        Stack.Push16(BX);
        // 100D:AF7F call near 0x0A3E
        NearCall(cs1, 0xAF82, unknown_100D_0A3E_10B0E);
    label_100D_AF82_1B052_17274:
        CheckExternalEvents(cs1, 0xAF82);
        // 100D:AF82 call near 0xB024
        NearCall(cs1, 0xAF85, unknown_100D_B024_1B0F4);
    label_100D_AF85_1B055_17365:
        CheckExternalEvents(cs1, 0xAF85);
        // 100D:AF85 pop BX
        BX = Stack.Pop16();
    label_100D_AF86_1B056_16480:
        CheckExternalEvents(cs1, 0xAF86);
        // 100D:AF86 call near 0xB147
        NearCall(cs1, 0xAF89, unknown_100D_B147_1B217);
    label_100D_AF89_1B059_16482:
        CheckExternalEvents(cs1, 0xAF89);
        // 100D:AF89 pop BP
        BP = Stack.Pop16();
        // 100D:AF8A je short 0xAFC6
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AF8A");
        }
    label_100D_AF8C_1B05C_16485:
        CheckExternalEvents(cs1, 0xAF8C);
        // 100D:AF8C mov word ptr DS:[0x2406],BX
        UInt16[DS, (ushort)0x2406] = BX;
        // 100D:AF90 mov AX,0x00A8
        AX = (ushort)0x00A8;
        // 100D:AF93 test byte ptr DS:[0x00C6],2
        Alu8.And(UInt8[DS, (ushort)0x00C6], (byte)0x02);
        // 100D:AF98 je short 0xAF9D
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AF98");
        }
    label_100D_AF9A_1B06A_16490:
        CheckExternalEvents(cs1, 0xAF9A);
        // 100D:AF9A add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:AF9D mov word ptr DS:[0x11BF],AX
        UInt16[DS, (ushort)0x11BF] = AX;
        // 100D:AFA0 mov SI,0x2034
        SI = (ushort)0x2034;
        // 100D:AFA3 mov CX,4
        CX = (ushort)0x0004;
        // 100D:AFA6 push SI
        Stack.Push16(SI);
    label_100D_AFA7_1B077_16496:
        CheckExternalEvents(cs1, 0xAFA7);
        // 100D:AFA7 and word ptr DS:[SI],0x7FFF
        UInt16[DS, SI] = Alu16.And(UInt16[DS, SI], (ushort)0x7FFF);
        // 100D:AFAB add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:AFAE loop 0xAFA7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_AFA7_1B077_16496;
        }
    label_100D_AFB0_1B080_16500:
        CheckExternalEvents(cs1, 0xAFB0);
        // 100D:AFB0 pop SI
        SI = Stack.Pop16();
        // 100D:AFB1 or word ptr SS:[BP+SI],0x8000
        UInt16[SS, (ushort)(BP + SI)] = Alu16.Or(UInt16[SS, (ushort)(BP + SI)], (ushort)0x8000);
        if (JumpDispatcher.Jump(unknown_100D_AFB5_1B085, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B18B_1B25B_17391:
        CheckExternalEvents(cs1, 0xB18B);
        // 100D:B18B call near 0xADBE
        NearCall(cs1, 0xB18E, unknown_100D_ADBE_1AE8E);
    label_100D_B18E_1B25E_17393:
        CheckExternalEvents(cs1, 0xB18E);
        // 100D:B18E mov byte ptr DS:[0x2788],0
        UInt8[DS, (ushort)0x2788] = (byte)0x00;
        // 100D:B193 mov byte ptr DS:[0x00C6],0
        UInt8[DS, (ushort)0x00C6] = (byte)0x00;
        // 100D:B198 mov byte ptr DS:[0x1C30],0
        UInt8[DS, (ushort)0x1C30] = (byte)0x00;
        // 100D:B19D call near 0xCA01
        NearCall(cs1, 0xB1A0, unknown_100D_CA01_1CAD1);
    label_100D_B1A0_1B270_17398:
        CheckExternalEvents(cs1, 0xB1A0);
        // 100D:B1A0 call near 0x0A3E
        NearCall(cs1, 0xB1A3, unknown_100D_0A3E_10B0E);
    label_100D_B1A3_1B273_17400:
        CheckExternalEvents(cs1, 0xB1A3);
        // 100D:B1A3 call near 0x9901
        NearCall(cs1, 0xB1A6, unknown_100D_9901_199D1);
    label_100D_B1A6_1B276_17402:
        CheckExternalEvents(cs1, 0xB1A6);
        // 100D:B1A6 mov AX,0x0026
        AX = (ushort)0x0026;
        // 100D:B1A9 call near 0xC13E
        NearCall(cs1, 0xB1AC, unknown_100D_C13E_1C20E);
    label_100D_B1AC_1B27C_17405:
        CheckExternalEvents(cs1, 0xB1AC);
        // 100D:B1AC jmp near 0x1877
        goto label_100D_1877_11947_13218;
    label_100D_B28C_1B35C_19343:
        CheckExternalEvents(cs1, 0xB28C);
        // 100D:B28C mov BP,0x207A
        BP = (ushort)0x207A;
        // 100D:B28F call near 0xB2AA
        NearCall(cs1, 0xB292, unknown_100D_B2AA_1B37A);
    label_100D_B292_1B362_19359:
        CheckExternalEvents(cs1, 0xB292);
        // 100D:B292 mov CX,0x8000
        CX = (ushort)0x8000;
        // 100D:B295 mov SI,0x207C
        SI = (ushort)0x207C;
        // 100D:B298 call near 0xB30F
        NearCall(cs1, 0xB29B, unknown_100D_B30F_1B3DF);
    label_100D_B29B_1B36B_19447:
        CheckExternalEvents(cs1, 0xB29B);
        // 100D:B29B jmp near 0xD397
        if (JumpDispatcher.Jump(unknown_100D_D397_1D467, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B29E_1B36E_20195:
        CheckExternalEvents(cs1, 0xB29E);
        // 100D:B29E mov CX,0x4000
        CX = (ushort)0x4000;
        // 100D:B2A1 mov SI,0x208C
        SI = (ushort)0x208C;
        // 100D:B2A4 call near 0xB30F
        NearCall(cs1, 0xB2A7, unknown_100D_B30F_1B3DF);
    label_100D_B2A7_1B377_20200:
        CheckExternalEvents(cs1, 0xB2A7);
        // 100D:B2A7 mov BP,0x208A
        BP = (ushort)0x208A;
        if (JumpDispatcher.Jump(unknown_100D_B2AA_1B37A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B35A_1B42A_19451:
        CheckExternalEvents(cs1, 0xB35A);
        // 100D:B35A mov BX,word ptr DS:[2]
        BX = UInt16[DS, (ushort)0x0002];
        // 100D:B35E mov word ptr DS:[0xD816],BX
        UInt16[DS, (ushort)0xD816] = BX;
        // 100D:B362 call near 0xDBB2
        NearCall(cs1, 0xB365, unknown_100D_DBB2_1DC82);
    label_100D_B365_1B435_19455:
        CheckExternalEvents(cs1, 0xB365);
        // 100D:B365 call near 0xB2CD
        NearCall(cs1, 0xB368, unknown_100D_B2CD_1B39D);
    label_100D_B368_1B438_19458:
        CheckExternalEvents(cs1, 0xB368);
        // 100D:B368 push CX
        Stack.Push16(CX);
        // 100D:B369 call near 0xD48A
        NearCall(cs1, 0xB36C, unknown_100D_D48A_1D55A);
    label_100D_B36C_1B43C_19461:
        CheckExternalEvents(cs1, 0xB36C);
        // 100D:B36C pop CX
        CX = Stack.Pop16();
        // 100D:B36D call near 0xB389
        NearCall(cs1, 0xB370, unknown_100D_B389_1B459);
    label_100D_B370_1B440_19466:
        CheckExternalEvents(cs1, 0xB370);
        // 100D:B370 pushf
        Stack.Push16(FlagRegister16);
        // 100D:B371 mov AX,0x0113
        AX = (ushort)0x0113;
        // 100D:B374 adc AL,0
        AL = Alu8.Adc(AL, (byte)0x00);
        // 100D:B376 mov CX,4
        CX = (ushort)0x0004;
        // 100D:B379 call near 0xD48A
        NearCall(cs1, 0xB37C, unknown_100D_D48A_1D55A);
    label_100D_B37C_1B44C_19472:
        CheckExternalEvents(cs1, 0xB37C);
        // 100D:B37C mov AX,0x012C
        AX = (ushort)0x012C;
        // 100D:B37F call near 0xDDB0
        NearCall(cs1, 0xB382, unknown_100D_DDB0_1DE80);
    label_100D_B382_1B452_19487:
        CheckExternalEvents(cs1, 0xB382);
        // 100D:B382 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_B383_1B453_19489:
        CheckExternalEvents(cs1, 0xB383);
        // 100D:B383 jb short 0xB388
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:B383");
        }
    label_100D_B385_1B455_19491:
        CheckExternalEvents(cs1, 0xB385);
        // 100D:B385 jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B3B0_1B480_20205:
        CheckExternalEvents(cs1, 0xB3B0);
        // 100D:B3B0 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:B3B5 je short 0xB3BA
        if (ZeroFlag)
        {
            goto label_100D_B3BA_1B48A_20208;
        }
    label_100D_B3B7_1B487_37933:
        CheckExternalEvents(cs1, 0xB3B7);
        // 100D:B3B7 jmp near 0x0E49
        goto label_100D_0E49_10F19_37900;
    label_100D_B3BA_1B48A_20208:
        CheckExternalEvents(cs1, 0xB3BA);
        // 100D:B3BA add CL,0x31
        CL = Alu8.Add(CL, (byte)0x31);
        // 100D:B3BD mov byte ptr DS:[0x38AF],CL
        UInt8[DS, (ushort)0x38AF] = CL;
        // 100D:B3C1 mov CX,0x0578
        CX = (ushort)0x0578;
        // 100D:B3C4 call near 0xF11C
        NearCall(cs1, 0xB3C7, unknown_100D_F11C_1F1EC);
    label_100D_B3C7_1B497_20213:
        CheckExternalEvents(cs1, 0xB3C7);
        // 100D:B3C7 mov DX,0x38A8
        DX = (ushort)0x38A8;
        // 100D:B3CA call near 0xF255
        NearCall(cs1, 0xB3CD, unknown_100D_F255_1F325);
    label_100D_B3CD_1B49D_20267:
        CheckExternalEvents(cs1, 0xB3CD);
        // 100D:B3CD mov AL,byte ptr DS:[0x00FB]
        AL = UInt8[DS, (ushort)0x00FB];
        // 100D:B3D0 push AX
        Stack.Push16(AX);
        // 100D:B3D1 push DS
        Stack.Push16(DS);
        // 100D:B3D2 push ES
        Stack.Push16(ES);
        // 100D:B3D3 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B3D4 mov SI,DI
        SI = DI;
        // 100D:B3D6 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:B3D8 dec SI
        SI = Alu16.Dec(SI);
        // 100D:B3D9 mov DI,0x5779
        DI = (ushort)0x5779;
        // 100D:B3DC sub CX,2
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:B3DF std
        DirectionFlag = true;
        // 100D:B3E0 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B3E2 cld
        DirectionFlag = false;
        // 100D:B3E3 lea SI,DI+1
        SI = unchecked((ushort)(DI + (sbyte)1));
        // 100D:B3E6 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:B3E8 call near 0xB4BB
        NearCall(cs1, 0xB3EB, unknown_100D_B4BB_1B58B);
    label_100D_B3EB_1B4BB_20317:
        CheckExternalEvents(cs1, 0xB3EB);
        // 100D:B3EB mov SI,DI
        SI = DI;
        // 100D:B3ED call near 0xB473
        NearCall(cs1, 0xB3F0, unknown_100D_B473_1B543);
    label_100D_B3F0_1B4C0_20359:
        CheckExternalEvents(cs1, 0xB3F0);
        // 100D:B3F0 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B3F1 call near 0x3AE9
        NearCall(cs1, 0xB3F4, unknown_100D_3AE9_13BB9);
    label_100D_B3F4_1B4C4_20362:
        CheckExternalEvents(cs1, 0xB3F4);
        // 100D:B3F4 call near 0xDA53
        NearCall(cs1, 0xB3F7, unknown_100D_DA53_1DB23);
    label_100D_B3F7_1B4C7_20364:
        CheckExternalEvents(cs1, 0xB3F7);
        // 100D:B3F7 mov word ptr DS:[0x22A6],0xFFFF
        UInt16[DS, (ushort)0x22A6] = (ushort)0xFFFF;
        // 100D:B3FD call near 0xB2BE
        NearCall(cs1, 0xB400, unknown_100D_B2BE_1B38E);
    label_100D_B400_1B4D0_20367:
        CheckExternalEvents(cs1, 0xB400);
        // 100D:B400 pop AX
        AX = Stack.Pop16();
        // 100D:B401 mov byte ptr DS:[0x00FB],AL
        UInt8[DS, (ushort)0x00FB] = AL;
        // 100D:B404 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:B406 jns short 0xB41B
        if (!SignFlag)
        {
            goto label_100D_B41B_1B4EB_20372;
        }
    label_100D_B408_1B4D8_30547:
        CheckExternalEvents(cs1, 0xB408);
        // 100D:B408 cmp byte ptr DS:[0xDD02],0
        Alu8.Sub(UInt8[DS, (ushort)0xDD02], (byte)0x00);
        // 100D:B40D je short 0xB412
        if (ZeroFlag)
        {
            goto label_100D_B412_1B4E2_30550;
        }
    label_100D_B40F_1B4DF_36963:
        CheckExternalEvents(cs1, 0xB40F);
        // 100D:B40F call near 0xB915
        NearCall(cs1, 0xB412, unknown_100D_B915_1B9E5);
    label_100D_B412_1B4E2_30550:
        CheckExternalEvents(cs1, 0xB412);
        // 100D:B412 call near 0xB96B
        NearCall(cs1, 0xB415, unknown_100D_B96B_1BA3B);
    label_100D_B415_1B4E5_30553:
        CheckExternalEvents(cs1, 0xB415);
        // 100D:B415 call near 0xB8EA
        NearCall(cs1, 0xB418, unknown_100D_B8EA_1B9BA);
    label_100D_B418_1B4E8_30555:
        CheckExternalEvents(cs1, 0xB418);
        // 100D:B418 jmp near 0xBA9E
        if (JumpDispatcher.Jump(unknown_100D_BA9E_1BB6E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B41B_1B4EB_20372:
        CheckExternalEvents(cs1, 0xB41B);
        // 100D:B41B call near 0xD2BD
        NearCall(cs1, 0xB41E, unknown_100D_D2BD_1D38D);
    label_100D_B41E_1B4EE_20382:
        CheckExternalEvents(cs1, 0xB41E);
        // 100D:B41E call near 0x1A0F
        NearCall(cs1, 0xB421, unknown_100D_1A0F_11ADF);
    label_100D_B421_1B4F1_20384:
        CheckExternalEvents(cs1, 0xB421);
        // 100D:B421 call near 0xADBE
        NearCall(cs1, 0xB424, unknown_100D_ADBE_1AE8E);
    label_100D_B424_1B4F4_20386:
        CheckExternalEvents(cs1, 0xB424);
        // 100D:B424 jmp near 0x2DB1
        if (JumpDispatcher.Jump(unknown_100D_2DB1_12E81, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_B961_1BA31_30557:
        CheckExternalEvents(cs1, 0xB961);
        // 100D:B961 call near 0xB915
        NearCall(cs1, 0xB964, unknown_100D_B915_1B9E5);
    label_100D_B964_1BA34_30573:
        CheckExternalEvents(cs1, 0xB964);
        // 100D:B964 mov byte ptr DS:[0xDD02],0
        UInt8[DS, (ushort)0xDD02] = (byte)0x00;
        // 100D:B969 jmp short 0xB972
    label_100D_B972_1BA42_19259:
        CheckExternalEvents(cs1, 0xB972);
        // 100D:B972 call near 0xB98B
        NearCall(cs1, 0xB975, unknown_100D_B98B_1BA5B);
    label_100D_B975_1BA45_19332:
        CheckExternalEvents(cs1, 0xB975);
        // 100D:B975 jmp short 0xB941
        if (JumpDispatcher.Jump(unknown_100D_B941_1BA11, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_D32F_1D3FF_25515:
        CheckExternalEvents(cs1, 0xD32F);
        // 100D:D32F call near 0xD316
        NearCall(cs1, 0xD332, unknown_100D_D316_1D3E6);
    label_100D_D332_1D402_25517:
        CheckExternalEvents(cs1, 0xD332);
        // 100D:D332 call near 0xD33A
        NearCall(cs1, 0xD335, unknown_100D_D33A_1D40A);
    label_100D_D335_1D405_25519:
        CheckExternalEvents(cs1, 0xD335);
        // 100D:D335 jmp near 0xD280
        if (JumpDispatcher.Jump(unknown_100D_D280_1D350, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_D423_1D4F3_32162:
        CheckExternalEvents(cs1, 0xD423);
        // 100D:D423 add byte ptr DS:[SI],0x10
        UInt8[DS, SI] = Alu8.Add(UInt8[DS, SI], (byte)0x10);
        // 100D:D426 jmp near 0xD397
        if (JumpDispatcher.Jump(unknown_100D_D397_1D467, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_D429_1D4F9_33302:
        CheckExternalEvents(cs1, 0xD429);
        // 100D:D429 mov byte ptr DS:[SI],0
        UInt8[DS, SI] = (byte)0x00;
        // 100D:D42C jmp near 0xD397
        if (JumpDispatcher.Jump(unknown_100D_D397_1D467, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_D445_1D515_15402:
        CheckExternalEvents(cs1, 0xD445);
        // 100D:D445 call near 0xD454
        NearCall(cs1, 0xD448, unknown_100D_D454_1D524);
    label_100D_D448_1D518_15404:
        CheckExternalEvents(cs1, 0xD448);
        // 100D:D448 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:D44A je short 0xD453
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D44A");
        }
    label_100D_D44C_1D51C_15407:
        CheckExternalEvents(cs1, 0xD44C);
        // 100D:D44C test AH,0x40
        Alu8.And(AH, (byte)0x40);
        // 100D:D44F jne short 0xD453
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D44F");
        }
    label_100D_D451_1D521_15410:
        CheckExternalEvents(cs1, 0xD451);
        // 100D:D451 jmp near BX
        switch ((ushort)(BX))
        {
            case 0x003A:
                goto label_100D_003A_1010A_20103;
            case 0x0E3E:
                goto label_100D_0E3E_10F0E_20099;
            case 0x0E47:
                goto label_100D_0E47_10F17_37899;
            case 0x0EA6:
                goto label_100D_0EA6_10F76_19951;
            case 0x0EB9:
                goto label_100D_0EB9_10F89_33358;
            case 0x0F48:
                goto label_100D_0F48_11018_27958;
            case 0x0F67:
                goto label_100D_0F67_11037_32283;
            case 0x0FC5:
                goto label_100D_0FC5_11095_36348;
            case 0x186B:
                if (JumpDispatcher.Jump(unknown_100D_186B_1193B, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x241A:
                goto label_100D_241A_124EA_33014;
            case 0x2432:
                goto label_100D_2432_12502_35333;
            case 0x2453:
                goto label_100D_2453_12523_33002;
            case 0x283A:
                goto label_100D_283A_1290A_31598;
            case 0x283E:
                goto label_100D_283E_1290E_38312;
            case 0x290B:
                goto label_100D_290B_129DB_31740;
            case 0x2993:
                goto label_100D_2993_12A63_31927;
            case 0x29D4:
                goto label_100D_29D4_12AA4_36734;
            case 0x42D1:
                goto label_100D_42D1_143A1_35084;
            case 0x42D9:
                goto label_100D_42D9_143A9_28190;
            case 0x42E9:
                goto label_100D_42E9_143B9_20659;
            case 0x497A:
                goto label_100D_497A_14A4A_28253;
            case 0x4FFB:
                goto label_100D_4FFB_150CB_26013;
            case 0x50A5:
                goto label_100D_50A5_15175_30870;
            case 0x50C4:
                goto label_100D_50C4_15194_37357;
            case 0x50DB:
                goto label_100D_50DB_151AB_26572;
            case 0x50EA:
                goto label_100D_50EA_151BA_36546;
            case 0x53F1:
                goto label_100D_53F1_154C1_30975;
            case 0x5A03:
                goto label_100D_5A03_15AD3_23456;
            case 0x5B1E:
                goto label_100D_5B1E_15BEE_35379;
            case 0x69B3:
                goto label_100D_69B3_16A83_24519;
            case 0x6A2B:
                goto label_100D_6A2B_16AFB_39725;
            case 0x6A2F:
                goto label_100D_6A2F_16AFF_40033;
            case 0x6A45:
                goto label_100D_6A45_16B15_35458;
            case 0x6A71:
                goto label_100D_6A71_16B41_24554;
            case 0x6A83:
                goto label_100D_6A83_16B53_24776;
            case 0x6A87:
                goto label_100D_6A87_16B57_39685;
            case 0x7317:
                goto label_100D_7317_173E7_39534;
            case 0x7734:
                goto label_100D_7734_17804_34674;
            case 0x775C:
                goto label_100D_775C_1782C_40118;
            case 0x776D:
                goto label_100D_776D_1783D_31173;
            case 0x7BED:
                if (JumpDispatcher.Jump(unknown_100D_7BED_17CBD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x7CBB:
                goto label_100D_7CBB_17D8B_27493;
            case 0x8064:
                goto label_100D_8064_18134_29063;
            case 0x80D9:
                goto label_100D_80D9_181A9_32110;
            case 0x8214:
                goto label_100D_8214_182E4_29367;
            case 0x86CC:
                goto label_100D_86CC_1879C_35405;
            case 0x86FA:
                goto label_100D_86FA_187CA_34555;
            case 0x8763:
                if (JumpDispatcher.Jump(unknown_100D_8763_18833, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x8770:
                if (JumpDispatcher.Jump(unknown_100D_8770_18840, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x92F2:
                goto label_100D_92F2_193C2_15412;
            case 0x92F7:
                goto label_100D_92F7_193C7_20397;
            case 0x92FC:
                goto label_100D_92FC_193CC_33283;
            case 0x9301:
                goto label_100D_9301_193D1_26927;
            case 0x9306:
                goto label_100D_9306_193D6_23066;
            case 0x930B:
                goto label_100D_930B_193DB_33492;
            case 0x9310:
                goto label_100D_9310_193E0_35316;
            case 0x9315:
                goto label_100D_9315_193E5_34586;
            case 0x931A:
                goto label_100D_931A_193EA_32039;
            case 0x932E:
                goto label_100D_932E_193FE_38252;
            case 0x936F:
                goto label_100D_936F_1943F_33901;
            case 0x9373:
                goto label_100D_9373_19443_23170;
            case 0x937E:
                goto label_100D_937E_1944E_26986;
            case 0x9472:
                goto label_100D_9472_19542_15581;
            case 0x9533:
                goto label_100D_9533_19603_25901;
            case 0x9584:
                goto label_100D_9584_19654_38206;
            case 0x95C1:
                goto label_100D_95C1_19691_23195;
            case 0x95E2:
                goto label_100D_95E2_196B2_16169;
            case 0x9ED5:
                goto label_100D_9ED5_19FA5_16216;
            case 0xA3F0:
                goto label_100D_A3F0_1A4C0_25334;
            case 0xAC6E:
                goto label_100D_AC6E_1AD3E_25798;
            case 0xAC7E:
                goto label_100D_AC7E_1AD4E_25743;
            case 0xAC90:
                goto label_100D_AC90_1AD60_25750;
            case 0xAC97:
                goto label_100D_AC97_1AD67_25804;
            case 0xAEAF:
                goto label_100D_AEAF_1AF7F_25814;
            case 0xAF58:
                goto label_100D_AF58_1B028_39527;
            case 0xAF60:
                goto label_100D_AF60_1B030_16472;
            case 0xAF68:
                goto label_100D_AF68_1B038_17267;
            case 0xAF70:
                goto label_100D_AF70_1B040_39522;
            case 0xB18B:
                goto label_100D_B18B_1B25B_17391;
            case 0xB28C:
                goto label_100D_B28C_1B35C_19343;
            case 0xB29E:
                goto label_100D_B29E_1B36E_20195;
            case 0xB35A:
                goto label_100D_B35A_1B42A_19451;
            case 0xB3B0:
                goto label_100D_B3B0_1B480_20205;
            case 0xB961:
                goto label_100D_B961_1BA31_30557;
            case 0xB96B:
                if (JumpDispatcher.Jump(unknown_100D_B96B_1BA3B, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0xBC81:
                if (JumpDispatcher.Jump(unknown_100D_BC81_1BD51, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0xD2E2:
                if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0xD423:
                goto label_100D_D423_1D4F3_32162;
            case 0xD429:
                goto label_100D_D429_1D4F9_33302;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(BX)):X4} at 100D:D451");
        }
    }

    public virtual Action unknown_100D_06F3_107C3(int loadOffset)
    {
    entrydispatcher:
    label_100D_06F3_107C3_6466:
        CheckExternalEvents(cs1, 0x06F3);
        // 100D:06F3 add word ptr DS:[0xDBDA],0x01E0
        UInt16[DS, (ushort)0xDBDA] = Alu16.Add(UInt16[DS, (ushort)0xDBDA], (ushort)0x01E0);
        // 100D:06F9 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0739_10809(int loadOffset)
    {
    label_100D_0739_10809_10965:
        CheckExternalEvents(cs1, 0x0739);
        // 100D:0739 jmp near 0xC2F2
        return unknown_100D_C2F2_1C3C2(0x0000);
    }

    public virtual Action unknown_100D_0960_10A30(int loadOffset)
    {
    entrydispatcher:
    label_100D_0960_10A30_9514:
        CheckExternalEvents(cs1, 0x0960);
        // 100D:0960 call near 0xC412
        NearCall(cs1, 0x0963, unknown_100D_C412_1C4E2);
    label_100D_0963_10A33_9516:
        CheckExternalEvents(cs1, 0x0963);
        // 100D:0963 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        if (JumpDispatcher.Jump(unknown_100D_0965_10A35, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_099D_10A6D(int loadOffset)
    {
    entrydispatcher:
    label_100D_099D_10A6D_7845:
        CheckExternalEvents(cs1, 0x099D);
        // 100D:099D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:099F call near 0x09C7
        NearCall(cs1, 0x09A2, unknown_100D_09C7_10A97);
    label_100D_09A2_10A72_7921:
        CheckExternalEvents(cs1, 0x09A2);
        // 100D:09A2 jmp near 0x978E
        if (JumpDispatcher.Jump(unknown_100D_978E_1985E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_0A21_10AF1(int loadOffset)
    {
    label_100D_0A21_10AF1_11565:
        CheckExternalEvents(cs1, 0x0A21);
        // 100D:0A21 clc
        CarryFlag = false;
        // 100D:0A22 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_13DB_114AB(int loadOffset)
    {
    entrydispatcher:
    label_100D_13DB_114AB_30367:
        CheckExternalEvents(cs1, 0x13DB);
        // 100D:13DB call near 0x1392
        NearCall(cs1, 0x13DE, unknown_100D_1392_11462);
    label_100D_13DE_114AE_30371:
        CheckExternalEvents(cs1, 0x13DE);
        // 100D:13DE call near 0x2DB1
        NearCall(cs1, 0x13E1, unknown_100D_2DB1_12E81);
    label_100D_13E1_114B1_30389:
        CheckExternalEvents(cs1, 0x13E1);
        // 100D:13E1 jmp near 0x1707
        if (JumpDispatcher.Jump(unknown_100D_1707_117D7, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_178E_1185E(int loadOffset)
    {
    label_100D_178E_1185E_28352:
        CheckExternalEvents(cs1, 0x178E);
        // 100D:178E mov BP,0x0064
        BP = (ushort)0x0064;
        // 100D:1791 mov SI,0x176B
        SI = (ushort)0x176B;
        // 100D:1794 jmp near 0xDA25
        return unknown_100D_DA25_1DAF5(0x0000);
    }

    public virtual Action unknown_100D_181D_118ED(int loadOffset)
    {
    entrydispatcher:
    label_100D_181D_118ED_13208:
        CheckExternalEvents(cs1, 0x181D);
        // 100D:181D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1A33_11B03(int loadOffset)
    {
    label_100D_1A33_11B03_15046:
        CheckExternalEvents(cs1, 0x1A33);
        // 100D:1A33 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1B0C_11BDC(int loadOffset)
    {
    label_100D_1B0C_11BDC_14679:
        CheckExternalEvents(cs1, 0x1B0C);
        // 100D:1B0C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1E3E_11F0E(int loadOffset)
    {
    label_100D_1E3E_11F0E_15076:
        CheckExternalEvents(cs1, 0x1E3E);
        // 100D:1E3E clc
        CarryFlag = false;
        // 100D:1E3F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_1EA8_11F78(int loadOffset)
    {
    label_100D_1EA8_11F78_26675:
        CheckExternalEvents(cs1, 0x1EA8);
        // 100D:1EA8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_20D2_121A2(int loadOffset)
    {
    label_100D_20D2_121A2_32322:
        CheckExternalEvents(cs1, 0x20D2);
        // 100D:20D2 mov AL,byte ptr DS:[0x00C3]
        AL = UInt8[DS, (ushort)0x00C3];
        // 100D:20D5 inc byte ptr DS:[0x00C3]
        UInt8[DS, (ushort)0x00C3] = Alu8.Inc(UInt8[DS, (ushort)0x00C3]);
        // 100D:20D9 mov BX,0x0096
        BX = (ushort)0x0096;
        // 100D:20DC mul BX
        uint result_100D_20DC_121AC = Alu16.Mul(AX, unchecked((ushort)unchecked((short)BX)));
        DX = unchecked((ushort)(result_100D_20DC_121AC >> 16));
        AX = unchecked((ushort)result_100D_20DC_121AC);
        // 100D:20DE or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:20E0 jne short 0x2111
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:20E0");
        }
    label_100D_20E2_121B2_32329:
        CheckExternalEvents(cs1, 0x20E2);
        // 100D:20E2 add AX,0x0064
        AX = Alu16.Add(AX, (ushort)0x0064);
        // 100D:20E5 jb short 0x2111
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:20E5");
        }
    label_100D_20E7_121B7_32332:
        CheckExternalEvents(cs1, 0x20E7);
        // 100D:20E7 mov CX,AX
        CX = AX;
        // 100D:20E9 mov BX,0x003F
        BX = (ushort)0x003F;
        // 100D:20EC call near 0xE3B7
        NearCall(cs1, 0x20EF, unknown_100D_E3B7_1E487);
    label_100D_20EF_121BF_32336:
        CheckExternalEvents(cs1, 0x20EF);
        // 100D:20EF add AX,0x00E0
        AX = Alu16.Add(AX, (ushort)0x00E0);
        // 100D:20F2 mul CX
        uint result_100D_20F2_121C2 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)CX)));
        DX = unchecked((ushort)(result_100D_20F2_121C2 >> 16));
        AX = unchecked((ushort)result_100D_20F2_121C2);
        // 100D:20F4 or DH,DH
        DH = Alu8.Or(DH, DH);
        // 100D:20F6 jne short 0x2111
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:20F6");
        }
    label_100D_20F8_121C8_32341:
        CheckExternalEvents(cs1, 0x20F8);
        // 100D:20F8 mov DH,DL
        DH = DL;
        // 100D:20FA mov DL,AH
        DL = AH;
        // 100D:20FC mov AL,byte ptr DS:[0x00BE]
        AL = UInt8[DS, (ushort)0x00BE];
        // 100D:20FF shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:2101 jb short 0x2114
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2101");
        }
    label_100D_2114_121E4_32347:
        CheckExternalEvents(cs1, 0x2114);
        // 100D:2114 mov word ptr DS:[0x00BC],DX
        UInt16[DS, (ushort)0x00BC] = DX;
        // 100D:2118 mov byte ptr DS:[0x00CF],0
        UInt8[DS, (ushort)0x00CF] = (byte)0x00;
        // 100D:211D or byte ptr DS:[0x00BF],0x90
        UInt8[DS, (ushort)0x00BF] = Alu8.Or(UInt8[DS, (ushort)0x00BF], (byte)0x90);
        // 100D:2122 mov AX,0x020B
        AX = (ushort)0x020B;
        // 100D:2125 cmp byte ptr DS:[0x00BE],0
        Alu8.Sub(UInt8[DS, (ushort)0x00BE], (byte)0x00);
        // 100D:212A js short 0x212E
        if (!(SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:212A");
        }
    label_100D_212E_121FE_32354:
        CheckExternalEvents(cs1, 0x212E);
        // 100D:212E jmp near 0x26DA
        return unknown_100D_26DA_127AA(0x0000);
    }

    public virtual Action unknown_100D_2A9E_12B6E(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_2A9E_12B6E_34787;
            case 0x2AAE:
                goto label_100D_2AAE_12B7E_24320;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_2A9E_12B6E_34787:
        CheckExternalEvents(cs1, 0x2A9E);
        // 100D:2A9E mov CX,BP
        CX = BP;
        // 100D:2AA0 mov CH,CL
        CH = CL;
        // 100D:2AA2 xchg CL,byte ptr DS:[0x1190]
        ushort xchgOffset_100D_2AA2_12B72 = (ushort)0x1190;
        byte temp_100D_2AA2_12B72 = CL;
        CL = UInt8[DS, xchgOffset_100D_2AA2_12B72];
        UInt8[DS, xchgOffset_100D_2AA2_12B72] = unchecked((byte)temp_100D_2AA2_12B72);
        // 100D:2AA6 cmp CL,CH
        Alu8.Sub(CL, CH);
        // 100D:2AA8 je short 0x2AAE
        if (ZeroFlag)
        {
            goto label_100D_2AAE_12B7E_24320;
        }
    label_100D_2AAA_12B7A_34793:
        CheckExternalEvents(cs1, 0x2AAA);
        // 100D:2AAA xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2AAC stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2AAD stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_100D_2AAE_12B7E_24320:
        CheckExternalEvents(cs1, 0x2AAE);
        // 100D:2AAE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_301D_130ED(int loadOffset)
    {
    label_100D_301D_130ED_21584:
        CheckExternalEvents(cs1, 0x301D);
        // 100D:301D jmp near 0xD72B
        return unknown_100D_D72B_1D7FB(0x0000);
    }

    public virtual Action unknown_100D_30CA_1319A(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_30CA_1319A_14009;
            case 0x311F:
                goto label_100D_311F_131EF_14021;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_30CA_1319A_14009:
        CheckExternalEvents(cs1, 0x30CA);
        // 100D:30CA mov AL,byte ptr DS:[SI+0x0E]
        AL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:30CD mov CL,AL
        CL = AL;
        // 100D:30CF xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:30D1 add AX,0x0078
        AX = Alu16.Add(AX, (ushort)0x0078);
        // 100D:30D4 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:30D5 mov AX,1
        AX = (ushort)0x0001;
        // 100D:30D8 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:30DA or word ptr DS:[0x0012],AX
        UInt16[DS, (ushort)0x0012] = Alu16.Or(UInt16[DS, (ushort)0x0012], AX);
        // 100D:30DE mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:30E1 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:30E2 cmp CL,0x0F
        Alu8.Sub(CL, (byte)0x0F);
        // 100D:30E5 jne short 0x311F
        if (!ZeroFlag)
        {
            goto label_100D_311F_131EF_14021;
        }
    label_100D_30E7_131B7_23430:
        CheckExternalEvents(cs1, 0x30E7);
        // 100D:30E7 mov CL,byte ptr DS:[0x476A]
        CL = UInt8[DS, (ushort)0x476A];
        // 100D:30EB xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:30ED dec CX
        CX = Alu16.Dec(CX);
        // 100D:30EE jle short 0x30FE
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_30FE_131CE_23435;
        }
    label_100D_30F0_131C0_32016:
        CheckExternalEvents(cs1, 0x30F0);
        // 100D:30F0 push SI
        Stack.Push16(SI);
        // 100D:30F1 mov SI,AX
        SI = AX;
        // 100D:30F3 mov AX,0x0087
        AX = (ushort)0x0087;
    label_100D_30F6_131C6_32020:
        CheckExternalEvents(cs1, 0x30F6);
        // 100D:30F6 inc AX
        AX = Alu16.Inc(AX);
        // 100D:30F7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:30F8 xchg SI,AX
        ushort temp_100D_30F8_131C8 = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_30F8_131C8);
        // 100D:30F9 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:30FA xchg SI,AX
        ushort temp_100D_30FA_131CA = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_30FA_131CA);
        // 100D:30FB loop 0x30F6
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_30F6_131C6_32020;
        }
    label_100D_30FD_131CD_32026:
        CheckExternalEvents(cs1, 0x30FD);
        // 100D:30FD pop SI
        SI = Stack.Pop16();
    label_100D_30FE_131CE_23435:
        CheckExternalEvents(cs1, 0x30FE);
        // 100D:30FE cmp byte ptr DS:[0x002A],5
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x05);
        // 100D:3103 jb short 0x311F
        if (CarryFlag)
        {
            goto label_100D_311F_131EF_14021;
        }
    label_100D_3105_131D5_28297:
        CheckExternalEvents(cs1, 0x3105);
        // 100D:3105 mov AL,byte ptr DS:[0x476B]
        AL = UInt8[DS, (ushort)0x476B];
        // 100D:3108 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:310A je short 0x311F
        if (ZeroFlag)
        {
            goto label_100D_311F_131EF_14021;
        }
    label_100D_310C_131DC_28301:
        CheckExternalEvents(cs1, 0x310C);
        // 100D:310C push DI
        Stack.Push16(DI);
        // 100D:310D dec AL
        AL = Alu8.Dec(AL);
        // 100D:310F sub AL,byte ptr DS:[0x476A]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x476A]);
        // 100D:3113 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:3114 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3116 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3118 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:311A mov word ptr DS:[DI],0x008F
        UInt16[DS, DI] = (ushort)0x008F;
        // 100D:311E pop DI
        DI = Stack.Pop16();
    label_100D_311F_131EF_14021:
        CheckExternalEvents(cs1, 0x311F);
        // 100D:311F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_316D_1323D(int loadOffset)
    {
    label_100D_316D_1323D_13966:
        CheckExternalEvents(cs1, 0x316D);
        // 100D:316D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_33BD_1348D(int loadOffset)
    {
    label_100D_33BD_1348D_13785:
        CheckExternalEvents(cs1, 0x33BD);
        // 100D:33BD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_347A_1354A(int loadOffset)
    {
    label_100D_347A_1354A_22752:
        CheckExternalEvents(cs1, 0x347A);
        // 100D:347A mov AL,AH
        AL = AH;
        // 100D:347C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:347E or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:3480 jne short 0x3489
        if (!ZeroFlag)
        {
            goto label_100D_3489_13559_22757;
        }
    label_100D_3482_13552_25324:
        CheckExternalEvents(cs1, 0x3482);
        // 100D:3482 cmp byte ptr DS:[SI+0x1A],1
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)26)], (byte)0x01);
        // 100D:3486 cmc
        CarryFlag = !CarryFlag;
        // 100D:3487 adc AL,AH
        AL = Alu8.Adc(AL, AH);
    label_100D_3489_13559_22757:
        CheckExternalEvents(cs1, 0x3489);
        // 100D:3489 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_351A_135EA(int loadOffset)
    {
    label_100D_351A_135EA_23429:
        CheckExternalEvents(cs1, 0x351A);
        // 100D:351A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_35AC_1367C(int loadOffset)
    {
    label_100D_35AC_1367C_14509:
        CheckExternalEvents(cs1, 0x35AC);
        // 100D:35AC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3722_137F2(int loadOffset)
    {
    label_100D_3722_137F2_14036:
        CheckExternalEvents(cs1, 0x3722);
        // 100D:3722 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_38E0_139B0(int loadOffset)
    {
    label_100D_38E0_139B0_12839:
        CheckExternalEvents(cs1, 0x38E0);
        // 100D:38E0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3978_13A48(int loadOffset)
    {
    label_100D_3978_13A48_5969:
        CheckExternalEvents(cs1, 0x3978);
        // 100D:3978 mov byte ptr DS:[0xDBB4],AL
        UInt8[DS, (ushort)0xDBB4] = AL;
        // 100D:397B call near 0xC13E
        NearCall(cs1, 0x397E, unknown_100D_C13E_1C20E);
    label_100D_397E_13A4E_5981:
        CheckExternalEvents(cs1, 0x397E);
        // 100D:397E mov AL,BL
        AL = BL;
        // 100D:3980 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3982 mov byte ptr DS:[0x46D6],AL
        UInt8[DS, (ushort)0x46D6] = AL;
        // 100D:3985 call near 0xC1F4
        NearCall(cs1, 0x3988, unknown_100D_C1F4_1C2C4);
    label_100D_3988_13A58_5994:
        CheckExternalEvents(cs1, 0x3988);
        // 100D:3988 lea DX,SI+6
        DX = unchecked((ushort)(SI + (sbyte)6));
        // 100D:398B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3A6A_13B3A(int loadOffset)
    {
    entrydispatcher:
    label_100D_3A6A_13B3A_20610:
        CheckExternalEvents(cs1, 0x3A6A);
        // 100D:3A6A push CX
        Stack.Push16(CX);
        // 100D:3A6B push BX
        Stack.Push16(BX);
        // 100D:3A6C push DX
        Stack.Push16(DX);
        // 100D:3A6D call near 0x3AA9
        NearCall(cs1, 0x3A70, unknown_100D_3AA9_13B79);
    label_100D_3A70_13B40_20646:
        CheckExternalEvents(cs1, 0x3A70);
        // 100D:3A70 pop DX
        DX = Stack.Pop16();
        // 100D:3A71 pop BX
        BX = Stack.Pop16();
        // 100D:3A72 pop CX
        CX = Stack.Pop16();
        if (JumpDispatcher.Jump(unknown_100D_3A73_13B43, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_3A7B_13B4B(int loadOffset)
    {
    label_100D_3A7B_13B4B_20653:
        CheckExternalEvents(cs1, 0x3A7B);
        // 100D:3A7B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4099_14169(int loadOffset)
    {
    label_100D_4099_14169_21961:
        CheckExternalEvents(cs1, 0x4099);
        // 100D:4099 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4181_14251(int loadOffset)
    {
    label_100D_4181_14251_25288:
        CheckExternalEvents(cs1, 0x4181);
        // 100D:4181 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_496A_14A3A(int loadOffset)
    {
    label_100D_496A_14A3A_21507:
        CheckExternalEvents(cs1, 0x496A);
        // 100D:496A mov word ptr DS:[0x11C5],DI
        UInt16[DS, (ushort)0x11C5] = DI;
        // 100D:496E mov byte ptr DS:[0x11C8],CL
        UInt8[DS, (ushort)0x11C8] = CL;
        // 100D:4972 mov byte ptr DS:[0x11C7],0
        UInt8[DS, (ushort)0x11C7] = (byte)0x00;
        // 100D:4977 jmp near 0x5119
    label_100D_5119_151E9_21511:
        CheckExternalEvents(cs1, 0x5119);
        // 100D:5119 add byte ptr DS:[0x11C7],AL
        UInt8[DS, (ushort)0x11C7] = Alu8.Add(UInt8[DS, (ushort)0x11C7], AL);
        // 100D:511D mov word ptr DS:[0x11CC],0x0080
        UInt16[DS, (ushort)0x11CC] = (ushort)0x0080;
        // 100D:5123 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5719_157E9(int loadOffset)
    {
    label_100D_5719_157E9_29240:
        CheckExternalEvents(cs1, 0x5719);
        // 100D:5719 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_578A_1585A(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_578A_1585A_28937;
            case 0x57B5:
                goto label_100D_57B5_15885_28933;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_578A_1585A_28937:
        CheckExternalEvents(cs1, 0x578A);
        // 100D:578A ret near
        return NearRet((ushort)0x0000);
    label_100D_57B5_15885_28933:
        CheckExternalEvents(cs1, 0x57B5);
        // 100D:57B5 mov AL,CL
        AL = CL;
        // 100D:57B7 xchg AL,byte ptr DS:[0x4725]
        ushort xchgOffset_100D_57B7_15887 = (ushort)0x4725;
        byte temp_100D_57B7_15887 = AL;
        AL = UInt8[DS, xchgOffset_100D_57B7_15887];
        UInt8[DS, xchgOffset_100D_57B7_15887] = unchecked((byte)temp_100D_57B7_15887);
        // 100D:57BB cmp AL,CL
        Alu8.Sub(AL, CL);
        // 100D:57BD je short 0x578A
        if (ZeroFlag)
        {
            goto label_100D_578A_1585A_28937;
        }
    label_100D_57BF_1588F_28958:
        CheckExternalEvents(cs1, 0x57BF);
        // 100D:57BF push BX
        Stack.Push16(BX);
        // 100D:57C0 push DX
        Stack.Push16(DX);
        // 100D:57C1 call near 0xC08E
        NearCall(cs1, 0x57C4, unknown_100D_C08E_1C15E);
    label_100D_57C4_15894_28962:
        CheckExternalEvents(cs1, 0x57C4);
        // 100D:57C4 call near 0x557B
        NearCall(cs1, 0x57C7, unknown_100D_557B_1564B);
    label_100D_57C7_15897_28964:
        CheckExternalEvents(cs1, 0x57C7);
        // 100D:57C7 add BX,0x0062
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)98)));
        // 100D:57CA add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:57CD mov AX,0x0065
        AX = (ushort)0x0065;
        // 100D:57D0 cmp byte ptr DS:[0x4722],0
        Alu8.Sub(UInt8[DS, (ushort)0x4722], (byte)0x00);
        // 100D:57D5 je short 0x57DA
        if (ZeroFlag)
        {
            goto label_100D_57DA_158AA_28970;
        }
    label_100D_57D7_158A7_31148:
        CheckExternalEvents(cs1, 0x57D7);
        // 100D:57D7 mov AX,0x0068
        AX = (ushort)0x0068;
    label_100D_57DA_158AA_28970:
        CheckExternalEvents(cs1, 0x57DA);
        // 100D:57DA call near 0xDBB2
        NearCall(cs1, 0x57DD, unknown_100D_DBB2_1DC82);
    label_100D_57DD_158AD_28972:
        CheckExternalEvents(cs1, 0x57DD);
        // 100D:57DD call near 0xD194
        NearCall(cs1, 0x57E0, unknown_100D_D194_1D264);
    label_100D_57E0_158B0_28974:
        CheckExternalEvents(cs1, 0x57E0);
        // 100D:57E0 pop DX
        DX = Stack.Pop16();
        // 100D:57E1 pop BX
        BX = Stack.Pop16();
        // 100D:57E2 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_5922_159F2(int loadOffset)
    {
    label_100D_5922_159F2_23608:
        CheckExternalEvents(cs1, 0x5922);
        // 100D:5922 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5A02_15AD2(int loadOffset)
    {
    label_100D_5A02_15AD2_18510:
        CheckExternalEvents(cs1, 0x5A02);
        // 100D:5A02 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_BC8D_1BD5D(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_BC8D_1BD5D_19572;

    label_100D_5A3D_15B0D_19716:
        CheckExternalEvents(cs1, 0x5A3D);
        // 100D:5A3D mov byte ptr DS:[0x00FB],0xFF
        UInt8[DS, (ushort)0x00FB] = (byte)0xFF;
        // 100D:5A42 call near 0xC13B
        NearCall(cs1, 0x5A45, unknown_100D_C13B_1C20B);
    label_100D_5A45_15B15_19719:
        CheckExternalEvents(cs1, 0x5A45);
        // 100D:5A45 call far dword ptr DS:[0x3935]
        ushort targetSegment_19719 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_19719 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_19719 == cs2 && targetOffset_19719 == 0x0160)
        {
            FarCall(cs1, 0x5A49, cs2, unknown_3358_0160_336E0);
            goto label_100D_5A49_15B19_19721;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_19719:X4}:{targetOffset_19719:X4} at 100D:5A45");
    label_100D_5A49_15B19_19721:
        CheckExternalEvents(cs1, 0x5A49);
        // 100D:5A49 mov BP,0x5A56
        BP = (ushort)0x5A56;
        // 100D:5A4C mov AL,2
        AL = (byte)0x02;
        // 100D:5A4E xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:5A50 call near 0xC108
        NearCall(cs1, 0x5A53, unknown_100D_C108_1C1D8);
    label_100D_5A53_15B23_19787:
        CheckExternalEvents(cs1, 0x5A53);
        // 100D:5A53 jmp near 0xAE04
        return unknown_100D_AE04_1AED4(0x0000);
    label_100D_BC8D_1BD5D_19572:
        CheckExternalEvents(cs1, 0xBC8D);
        // 100D:BC8D call near 0xDBB2
        NearCall(cs1, 0xBC90, unknown_100D_DBB2_1DC82);
    label_100D_BC90_1BD60_19573:
        CheckExternalEvents(cs1, 0xBC90);
        // 100D:BC90 call near 0xBC99
        NearCall(cs1, 0xBC93, unknown_100D_BC99_1BD69);
    label_100D_BC93_1BD63_19712:
        CheckExternalEvents(cs1, 0xBC93);
        // 100D:BC93 call near 0xADBE
        NearCall(cs1, 0xBC96, unknown_100D_ADBE_1AE8E);
    label_100D_BC96_1BD66_19714:
        CheckExternalEvents(cs1, 0xBC96);
        // 100D:BC96 jmp near 0x5A3D
        goto label_100D_5A3D_15B0D_19716;
    }

    public virtual Action unknown_100D_5CE3_15DB3(int loadOffset)
    {
    label_100D_5CE3_15DB3_26281:
        CheckExternalEvents(cs1, 0x5CE3);
        // 100D:5CE3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_5D44_15E14(int loadOffset)
    {
    label_100D_5D44_15E14_34517:
        CheckExternalEvents(cs1, 0x5D44);
        // 100D:5D44 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:5D49 je short 0x5D50
        if (ZeroFlag)
        {
            return unknown_100D_5D50_15E20(0x0000);
        }
    label_100D_5D4B_15E1B_34520:
        CheckExternalEvents(cs1, 0x5D4B);
        // 100D:5D4B or byte ptr DS:[0x4728],1
        UInt8[DS, (ushort)0x4728] = Alu8.Or(UInt8[DS, (ushort)0x4728], (byte)0x01);
        return unknown_100D_5D50_15E20(0x0000);
    }

    public virtual Action unknown_100D_5F9F_1606F(int loadOffset)
    {
    entrydispatcher:
    label_100D_5F9F_1606F_26586:
        CheckExternalEvents(cs1, 0x5F9F);
        // 100D:5F9F call near 0xC07C
        NearCall(cs1, 0x5FA2, unknown_100D_C07C_1C14C);
    label_100D_5FA2_16072_26587:
        CheckExternalEvents(cs1, 0x5FA2);
        // 100D:5FA2 mov word ptr DS:[0xDBE0],0
        UInt16[DS, (ushort)0xDBE0] = (ushort)0x0000;
        // 100D:5FA8 call near 0xC6AD
        NearCall(cs1, 0x5FAB, unknown_100D_C6AD_1C77D);
    label_100D_5FAB_1607B_26590:
        CheckExternalEvents(cs1, 0x5FAB);
        // 100D:5FAB mov AL,8
        AL = (byte)0x08;
        // 100D:5FAD jmp near 0x7B2B
        return unknown_100D_7B2B_17BFB(0x0000);
    }

    public virtual Action unknown_100D_62F1_163C1(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_62F1_163C1_18012;
            case 0x6322:
                goto label_100D_6322_163F2_18199;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_62F1_163C1_18012:
        CheckExternalEvents(cs1, 0x62F1);
        // 100D:62F1 ret near
        return NearRet((ushort)0x0000);
    label_100D_6322_163F2_18199:
        CheckExternalEvents(cs1, 0x6322);
        // 100D:6322 jb short 0x62F1
        if (CarryFlag)
        {
            goto label_100D_62F1_163C1_18012;
        }
    label_100D_6324_163F4_18201:
        CheckExternalEvents(cs1, 0x6324);
        // 100D:6324 push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:6328 push AX
        Stack.Push16(AX);
        // 100D:6329 call near 0xC137
        NearCall(cs1, 0x632C, unknown_100D_C137_1C207);
    label_100D_632C_163FC_18205:
        CheckExternalEvents(cs1, 0x632C);
        // 100D:632C pop AX
        AX = Stack.Pop16();
        // 100D:632D call near 0xC1F4
        NearCall(cs1, 0x6330, unknown_100D_C1F4_1C2C4);
    label_100D_6330_16400_18208:
        CheckExternalEvents(cs1, 0x6330);
        // 100D:6330 sub BL,byte ptr ES:[SI+2]
        BL = Alu8.Sub(BL, UInt8[ES, (ushort)(SI + (sbyte)2)]);
        // 100D:6334 call near 0xC30D
        NearCall(cs1, 0x6337, unknown_100D_C30D_1C3DD);
    label_100D_6337_16407_18211:
        CheckExternalEvents(cs1, 0x6337);
        // 100D:6337 pop AX
        AX = Stack.Pop16();
        // 100D:6338 jmp near 0xC13E
        return unknown_100D_C13E_1C20E(0x0000);
    }

    public virtual Action unknown_100D_6394_16464(int loadOffset)
    {
    label_100D_6394_16464_18044:
        CheckExternalEvents(cs1, 0x6394);
        // 100D:6394 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6458_16528(int loadOffset)
    {
    entrydispatcher:
    label_100D_6458_16528_23278:
        CheckExternalEvents(cs1, 0x6458);
        // 100D:6458 mov word ptr CS:[0x64ED],0x646F
        UInt16[CS, (ushort)0x64ED] = (ushort)0x646F;
        // 100D:645F mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:6462 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:6465 mov word ptr DS:[0xD81C],DX
        UInt16[DS, (ushort)0xD81C] = DX;
        // 100D:6469 mov word ptr DS:[0xD818],BX
        UInt16[DS, (ushort)0xD818] = BX;
        // 100D:646D jmp short 0x64B2
        if (JumpDispatcher.Jump(unknown_100D_64B2_16582, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
