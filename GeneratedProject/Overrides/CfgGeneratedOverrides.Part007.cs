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
    public virtual Action sky_palette_fade_step(int loadOffset)
    {
    label_100D_391D_139ED_6270:
        CheckExternalEvents(cs1, 0x391D);
        // 100D:391D mov CX,0x01C5
        CX = (ushort)0x01C5;
        // 100D:3920 mov BX,0x00DB
        BX = (ushort)0x00DB;
        // 100D:3923 cmp byte ptr DS:[0x22E3],0
        Alu8.Sub(UInt8[DS, (ushort)0x22E3], (byte)0x00);
        // 100D:3928 jne short 0x3930
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3928");
        }
    label_100D_3930_13A00_6275:
        CheckExternalEvents(cs1, 0x3930);
        // 100D:3930 mov AL,byte ptr DS:[0x46D7]
        AL = UInt8[DS, (ushort)0x46D7];
        // 100D:3933 push AX
        Stack.Push16(AX);
        // 100D:3934 call far dword ptr DS:[0x3951]
        ushort targetSegment_6278 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3951 + (ushort)0x0002)]));
        ushort targetOffset_6278 = unchecked((ushort)(UInt16[DS, (ushort)0x3951]));
        if (targetSegment_6278 == cs2 && targetOffset_6278 == 0x0175)
        {
            FarCall(cs1, 0x3938, cs2, unknown_3358_0175_336F5);
            goto label_100D_3938_13A08_6322;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_6278:X4}:{targetOffset_6278:X4} at 100D:3934");
    label_100D_3938_13A08_6322:
        CheckExternalEvents(cs1, 0x3938);
        // 100D:3938 pop AX
        AX = Stack.Pop16();
        // 100D:3939 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:393E jne short 0x394A
        if (!ZeroFlag)
        {
            goto label_100D_394A_13A1A_6326;
        }
    label_100D_3940_13A10_25317:
        CheckExternalEvents(cs1, 0x3940);
        // 100D:3940 mov CX,0x0030
        CX = (ushort)0x0030;
        // 100D:3943 mov BX,0x02D0
        BX = (ushort)0x02D0;
        // 100D:3946 call far dword ptr DS:[0x3951]
        ushort targetSegment_25320 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3951 + (ushort)0x0002)]));
        ushort targetOffset_25320 = unchecked((ushort)(UInt16[DS, (ushort)0x3951]));
        if (targetSegment_25320 == cs2 && targetOffset_25320 == 0x0175)
        {
            FarCall(cs1, 0x394A, cs2, unknown_3358_0175_336F5);
            goto label_100D_394A_13A1A_6326;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_25320:X4}:{targetOffset_25320:X4} at 100D:3946");
    label_100D_394A_13A1A_6326:
        CheckExternalEvents(cs1, 0x394A);
        // 100D:394A dec byte ptr DS:[0x46D7]
        UInt8[DS, (ushort)0x46D7] = Alu8.Dec(UInt8[DS, (ushort)0x46D7]);
        // 100D:394E jne short 0x395B
        if (!(!ZeroFlag))
        {
            return unknown_100D_3950_13A20(0x0000);
        }
    label_100D_395B_13A2B_6329:
        CheckExternalEvents(cs1, 0x395B);
        // 100D:395B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3950_13A20(int loadOffset)
    {
    label_100D_3950_13A20_6339:
        CheckExternalEvents(cs1, 0x3950);
        // 100D:3950 mov byte ptr DS:[0x46D7],0
        UInt8[DS, (ushort)0x46D7] = (byte)0x00;
        // 100D:3955 mov SI,0x3916
        SI = (ushort)0x3916;
        // 100D:3958 jmp near 0xDA5F
        return remove_frame_task(0x0000);
    }

    public virtual Action sky_palette_id_from_game_time(int loadOffset)
    {
    label_100D_395C_13A2C_12778:
        CheckExternalEvents(cs1, 0x395C);
        // 100D:395C mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        return unknown_100D_395F_13A2F(0x0000);
    }

    public virtual Action unknown_100D_395F_13A2F(int loadOffset)
    {
    label_100D_395F_13A2F_12780:
        CheckExternalEvents(cs1, 0x395F);
        // 100D:395F mov AH,AL
        AH = AL;
        // 100D:3961 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:3963 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:3965 and AX,0x1C0F
        AX = Alu16.And(AX, (ushort)0x1C0F);
        // 100D:3968 mov BX,0x2280
        BX = (ushort)0x2280;
        // 100D:396B xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:396C add AL,AH
        AL = Alu8.Add(AL, AH);
        // 100D:396E mov BL,AL
        BL = AL;
        // 100D:3970 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3971_13A41(int loadOffset)
    {
    label_100D_3971_13A41_10917:
        CheckExternalEvents(cs1, 0x3971);
        // 100D:3971 mov AX,0x0028
        AX = (ushort)0x0028;
        // 100D:3974 add AL,byte ptr DS:[0x22E3]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x22E3]);
        return open_sky_palette(0x0000);
    }

    public virtual Action unknown_100D_398C_13A5C(int loadOffset)
    {
    label_100D_398C_13A5C_12796:
        CheckExternalEvents(cs1, 0x398C);
        // 100D:398C mov CX,0x01C5
        CX = (ushort)0x01C5;
        // 100D:398F mov BX,0x00DB
        BX = (ushort)0x00DB;
        // 100D:3992 cmp byte ptr DS:[0x22E3],0
        Alu8.Sub(UInt8[DS, (ushort)0x22E3], (byte)0x00);
        // 100D:3997 jne short 0x399F
        if (!ZeroFlag)
        {
            goto label_100D_399F_13A6F_12801;
        }
    label_100D_3999_13A69_35330:
        CheckExternalEvents(cs1, 0x3999);
        // 100D:3999 mov CX,0x00F0
        CX = (ushort)0x00F0;
        // 100D:399C mov BX,0x0180
        BX = (ushort)0x0180;
    label_100D_399F_13A6F_12801:
        CheckExternalEvents(cs1, 0x399F);
        // 100D:399F push CX
        Stack.Push16(CX);
        // 100D:39A0 call far dword ptr DS:[0x38BD]
        ushort targetSegment_12803 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_12803 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_12803 == cs2 && targetOffset_12803 == 0x0106)
        {
            FarCall(cs1, 0x39A4, cs2, unknown_3358_0106_33686);
            goto label_100D_39A4_13A74_12804;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12803:X4}:{targetOffset_12803:X4} at 100D:39A0");
    label_100D_39A4_13A74_12804:
        CheckExternalEvents(cs1, 0x39A4);
        // 100D:39A4 pop CX
        CX = Stack.Pop16();
        // 100D:39A5 add DX,CX
        DX = Alu16.Add(DX, CX);
        // 100D:39A7 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:39AC jne short 0x39B8
        if (!ZeroFlag)
        {
            goto label_100D_39B8_13A88_12809;
        }
    label_100D_39AE_13A7E_20174:
        CheckExternalEvents(cs1, 0x39AE);
        // 100D:39AE mov CX,0x0030
        CX = (ushort)0x0030;
        // 100D:39B1 mov BX,0x02D0
        BX = (ushort)0x02D0;
        // 100D:39B4 call far dword ptr DS:[0x38BD]
        ushort targetSegment_20177 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38BD + (ushort)0x0002)]));
        ushort targetOffset_20177 = unchecked((ushort)(UInt16[DS, (ushort)0x38BD]));
        if (targetSegment_20177 == cs2 && targetOffset_20177 == 0x0106)
        {
            FarCall(cs1, 0x39B8, cs2, unknown_3358_0106_33686);
            goto label_100D_39B8_13A88_12809;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_20177:X4}:{targetOffset_20177:X4} at 100D:39B4");
    label_100D_39B8_13A88_12809:
        CheckExternalEvents(cs1, 0x39B8);
        // 100D:39B8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_39B9_13A89(int loadOffset)
    {
    label_100D_39B9_13A89_10922:
        CheckExternalEvents(cs1, 0x39B9);
        // 100D:39B9 mov CX,0x01C5
        CX = (ushort)0x01C5;
        // 100D:39BC mov BX,0x00DB
        BX = (ushort)0x00DB;
        // 100D:39BF cmp byte ptr DS:[0x22E3],0
        Alu8.Sub(UInt8[DS, (ushort)0x22E3], (byte)0x00);
        // 100D:39C4 jne short 0x39CC
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:39C4");
        }
    label_100D_39CC_13A9C_10927:
        CheckExternalEvents(cs1, 0x39CC);
        // 100D:39CC push CX
        Stack.Push16(CX);
        // 100D:39CD call far dword ptr DS:[0x394D]
        ushort targetSegment_10929 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x394D + (ushort)0x0002)]));
        ushort targetOffset_10929 = unchecked((ushort)(UInt16[DS, (ushort)0x394D]));
        if (targetSegment_10929 == cs2 && targetOffset_10929 == 0x0172)
        {
            FarCall(cs1, 0x39D1, cs2, unknown_3358_0172_336F2);
            goto label_100D_39D1_13AA1_10930;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10929:X4}:{targetOffset_10929:X4} at 100D:39CD");
    label_100D_39D1_13AA1_10930:
        CheckExternalEvents(cs1, 0x39D1);
        // 100D:39D1 pop CX
        CX = Stack.Pop16();
        // 100D:39D2 add DX,CX
        DX = Alu16.Add(DX, CX);
        // 100D:39D4 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:39D9 jne short 0x39E5
        if (!ZeroFlag)
        {
            goto label_100D_39E5_13AB5_10935;
        }
    label_100D_39DB_13AAB_25313:
        CheckExternalEvents(cs1, 0x39DB);
        // 100D:39DB mov CX,0x0030
        CX = (ushort)0x0030;
        // 100D:39DE mov BX,0x02D0
        BX = (ushort)0x02D0;
        // 100D:39E1 call far dword ptr DS:[0x394D]
        ushort targetSegment_25316 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x394D + (ushort)0x0002)]));
        ushort targetOffset_25316 = unchecked((ushort)(UInt16[DS, (ushort)0x394D]));
        if (targetSegment_25316 == cs2 && targetOffset_25316 == 0x0172)
        {
            FarCall(cs1, 0x39E5, cs2, unknown_3358_0172_336F2);
            goto label_100D_39E5_13AB5_10935;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_25316:X4}:{targetOffset_25316:X4} at 100D:39E1");
    label_100D_39E5_13AB5_10935:
        CheckExternalEvents(cs1, 0x39E5);
        // 100D:39E5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action remove_room_frame_task(int loadOffset)
    {
    label_100D_39E6_13AB6_3439:
        CheckExternalEvents(cs1, 0x39E6);
        // 100D:39E6 mov SI,0xC0B6
        SI = (ushort)0xC0B6;
        // 100D:39E9 jmp near 0xDA5F
        return remove_frame_task(0x0000);
    }

    public virtual Action draw_ornis(int loadOffset)
    {
    entrydispatcher:
    label_100D_3A73_13B43_20650:
        CheckExternalEvents(cs1, 0x3A73);
        // 100D:3A73 add DX,0x0046
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)70)));
        // 100D:3A76 add BX,0x000A
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:3A79 loop 0x3A6A
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            if (JumpDispatcher.Jump(draw_ornis_loop, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        else
        {
            return unknown_100D_3A7B_13B4B(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action add_room_frame_task(int loadOffset)
    {
    label_100D_3A7C_13B4C_4709:
        CheckExternalEvents(cs1, 0x3A7C);
        // 100D:3A7C call near 0x39E6
        NearCall(cs1, 0x3A7F, remove_room_frame_task);
    label_100D_3A7F_13B4F_4711:
        CheckExternalEvents(cs1, 0x3A7F);
        // 100D:3A7F mov AX,word ptr DS:[4]
        AX = UInt16[DS, (ushort)0x0004];
        // 100D:3A82 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:3A84 jne short 0x3A94
        if (!ZeroFlag)
        {
            goto label_100D_3A94_13B64_4715;
        }
    label_100D_3A86_13B56_7830:
        CheckExternalEvents(cs1, 0x3A86);
        // 100D:3A86 cmp AH,0x20
        Alu8.Sub(AH, (byte)0x20);
        // 100D:3A89 jae short 0x3A94
        if (!CarryFlag)
        {
            goto label_100D_3A94_13B64_4715;
        }
    label_100D_3A8B_13B5B_11038:
        CheckExternalEvents(cs1, 0x3A8B);
        // 100D:3A8B mov SI,0xC0B6
        SI = (ushort)0xC0B6;
        // 100D:3A8E mov BP,0x000C
        BP = (ushort)0x000C;
        // 100D:3A91 call near 0xDA25
        NearCall(cs1, 0x3A94, add_frame_task);
    label_100D_3A94_13B64_4715:
        CheckExternalEvents(cs1, 0x3A94);
        // 100D:3A94 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_orni_position(int loadOffset)
    {
    label_100D_3A95_13B65_20594:
        CheckExternalEvents(cs1, 0x3A95);
        // 100D:3A95 mov DX,0x0095
        DX = (ushort)0x0095;
        // 100D:3A98 mov BX,0x0039
        BX = (ushort)0x0039;
        // 100D:3A9B cmp byte ptr DS:[5],0x20
        Alu8.Sub(UInt8[DS, (ushort)0x0005], (byte)0x20);
        // 100D:3AA0 jb short 0x3AA8
        if (CarryFlag)
        {
            goto label_100D_3AA8_13B78_20602;
        }
    label_100D_3AA2_13B72_20599:
        CheckExternalEvents(cs1, 0x3AA2);
        // 100D:3AA2 mov DX,0x00CA
        DX = (ushort)0x00CA;
        // 100D:3AA5 mov BX,0x0049
        BX = (ushort)0x0049;
    label_100D_3AA8_13B78_20602:
        CheckExternalEvents(cs1, 0x3AA8);
        // 100D:3AA8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_orni(int loadOffset)
    {
    label_100D_3AA9_13B79_20614:
        CheckExternalEvents(cs1, 0x3AA9);
        // 100D:3AA9 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:3AAB call near 0xC305
        NearCall(cs1, 0x3AAE, draw_sprite_from_sheet_clipped);
    label_100D_3AAE_13B7E_20617:
        CheckExternalEvents(cs1, 0x3AAE);
        // 100D:3AAE add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:3AB1 add BX,0x001E
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:3AB4 mov AX,1
        AX = (ushort)0x0001;
        // 100D:3AB7 call near 0xC305
        NearCall(cs1, 0x3ABA, draw_sprite_from_sheet_clipped);
    label_100D_3ABA_13B8A_20622:
        CheckExternalEvents(cs1, 0x3ABA);
        // 100D:3ABA sub DX,2
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:3ABD add BX,0x0014
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 100D:3AC0 mov AL,byte ptr DS:[0x4731]
        AL = UInt8[DS, (ushort)0x4731];
        // 100D:3AC3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3AC5 push AX
        Stack.Push16(AX);
        // 100D:3AC6 sub AL,0x0F
        AL = Alu8.Sub(AL, (byte)0x0F);
        // 100D:3AC8 jae short 0x3ACC
        if (!CarryFlag)
        {
            goto label_100D_3ACC_13B9C_20632;
        }
    label_100D_3ACA_13B9A_20630:
        CheckExternalEvents(cs1, 0x3ACA);
        // 100D:3ACA xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_3ACC_13B9C_20632:
        CheckExternalEvents(cs1, 0x3ACC);
        // 100D:3ACC cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:3ACE jbe short 0x3AD2
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_3AD2_13BA2_20634;
        }
    label_100D_3AD0_13BA0_21809:
        CheckExternalEvents(cs1, 0x3AD0);
        // 100D:3AD0 mov AL,5
        AL = (byte)0x05;
    label_100D_3AD2_13BA2_20634:
        CheckExternalEvents(cs1, 0x3AD2);
        // 100D:3AD2 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:3AD4 call near 0xC305
        NearCall(cs1, 0x3AD7, draw_sprite_from_sheet_clipped);
    label_100D_3AD7_13BA7_20637:
        CheckExternalEvents(cs1, 0x3AD7);
        // 100D:3AD7 sub DX,0x0055
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)85)));
        // 100D:3ADA sub BX,0x0035
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)53)));
        // 100D:3ADD pop AX
        AX = Stack.Pop16();
        // 100D:3ADE cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:3AE0 jb short 0x3AE4
        if (CarryFlag)
        {
            goto label_100D_3AE4_13BB4_20643;
        }
    label_100D_3AE2_13BB2_21790:
        CheckExternalEvents(cs1, 0x3AE2);
        // 100D:3AE2 mov AL,0x0E
        AL = (byte)0x0E;
    label_100D_3AE4_13BB4_20643:
        CheckExternalEvents(cs1, 0x3AE4);
        // 100D:3AE4 add AL,8
        AL = Alu8.Add(AL, (byte)0x08);
        // 100D:3AE6 jmp near 0xC30D
        return unknown_100D_C30D_1C3DD(0x0000);
    }

    public virtual Action unknown_100D_3AE9_13BB9(int loadOffset)
    {
    label_100D_3AE9_13BB9_6746:
        CheckExternalEvents(cs1, 0x3AE9);
        // 100D:3AE9 push AX
        Stack.Push16(AX);
        // 100D:3AEA push DS
        Stack.Push16(DS);
        // 100D:3AEB pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:3AEC mov CX,0x002E
        CX = (ushort)0x002E;
        // 100D:3AEF mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:3AF2 mov DI,0x47F8
        DI = (ushort)0x47F8;
        // 100D:3AF5 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:3AF7 pop AX
        AX = Stack.Pop16();
        // 100D:3AF8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action dialogue_zoom_room(int loadOffset)
    {
    label_100D_3AF9_13BC9_15423:
        CheckExternalEvents(cs1, 0x3AF9);
        // 100D:3AF9 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:3AFE je short 0x3B03
        if (ZeroFlag)
        {
            goto label_100D_3B03_13BD3_15426;
        }
    label_100D_3B00_13BD0_36324:
        CheckExternalEvents(cs1, 0x3B00);
        // 100D:3B00 jmp near 0xC43E
        return copy_game_area_fb2_to_fb1(0x0000);
    label_100D_3B03_13BD3_15426:
        CheckExternalEvents(cs1, 0x3B03);
        // 100D:3B03 cmp byte ptr DS:[0x47A4],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A4], (byte)0x00);
        // 100D:3B08 js short 0x3B58
        if (SignFlag)
        {
            goto label_100D_3B58_13C28_15686;
        }
    label_100D_3B0A_13BDA_15429:
        CheckExternalEvents(cs1, 0x3B0A);
        // 100D:3B0A mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:3B0D cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 100D:3B0F jne short 0x3B15
        if (!ZeroFlag)
        {
            goto label_100D_3B15_13BE5_15433;
        }
    label_100D_3B11_13BE1_27013:
        CheckExternalEvents(cs1, 0x3B11);
        // 100D:3B11 add AL,byte ptr DS:[0x476C]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x476C]);
    label_100D_3B15_13BE5_15433:
        CheckExternalEvents(cs1, 0x3B15);
        // 100D:3B15 mov DI,AX
        DI = AX;
        // 100D:3B17 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:3B19 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:3B1B mov DX,word ptr DS:[DI+0x47F8]
        DX = UInt16[DS, (ushort)(DI + (short)18424)];
        // 100D:3B1F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:3B21 js short 0x3B58
        if (SignFlag)
        {
            goto label_100D_3B58_13C28_15686;
        }
    label_100D_3B23_13BF3_15440:
        CheckExternalEvents(cs1, 0x3B23);
        // 100D:3B23 push word ptr DS:[DI+0x47FA]
        Stack.Push16(UInt16[DS, (ushort)(DI + (short)18426)]);
        // 100D:3B27 push DX
        Stack.Push16(DX);
        // 100D:3B28 or byte ptr DS:[0x47A4],0x80
        UInt8[DS, (ushort)0x47A4] = Alu8.Or(UInt8[DS, (ushort)0x47A4], (byte)0x80);
        // 100D:3B2D call near 0x37B5
        NearCall(cs1, 0x3B30, unknown_100D_37B5_13885);
    label_100D_3B30_13C00_15445:
        CheckExternalEvents(cs1, 0x3B30);
        // 100D:3B30 pop DX
        DX = Stack.Pop16();
        // 100D:3B31 pop BX
        BX = Stack.Pop16();
        // 100D:3B32 cmp DX,0x00F0
        Alu16.Sub(DX, (ushort)0x00F0);
        // 100D:3B36 jb short 0x3B3B
        if (CarryFlag)
        {
            goto label_100D_3B3B_13C0B_15450;
        }
    label_100D_3B38_13C08_27279:
        CheckExternalEvents(cs1, 0x3B38);
        // 100D:3B38 mov DX,0x00F0
        DX = (ushort)0x00F0;
    label_100D_3B3B_13C0B_15450:
        CheckExternalEvents(cs1, 0x3B3B);
        // 100D:3B3B cmp BX,0x0071
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)113)));
        // 100D:3B3E jb short 0x3B43
        if (CarryFlag)
        {
            goto label_100D_3B43_13C13_15453;
        }
    label_100D_3B40_13C10_35307:
        CheckExternalEvents(cs1, 0x3B40);
        // 100D:3B40 mov BX,0x0071
        BX = (ushort)0x0071;
    label_100D_3B43_13C13_15453:
        CheckExternalEvents(cs1, 0x3B43);
        // 100D:3B43 mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:3B47 push DS
        Stack.Push16(DS);
        // 100D:3B48 mov DS,word ptr DS:[0xDBDA]
        DS = UInt16[DS, (ushort)0xDBDA];
        // 100D:3B4C mov BP,6
        BP = (ushort)0x0006;
        // 100D:3B4F call far dword ptr SS:[0x3949]
        ushort targetSegment_15458 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3949 + (ushort)0x0002)]));
        ushort targetOffset_15458 = unchecked((ushort)(UInt16[SS, (ushort)0x3949]));
        if (targetSegment_15458 == cs2 && targetOffset_15458 == 0x016F)
        {
            FarCall(cs1, 0x3B54, cs2, unknown_3358_016F_336EF);
            goto label_100D_3B54_13C24_15459;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_15458:X4}:{targetOffset_15458:X4} at 100D:3B4F");
    label_100D_3B54_13C24_15459:
        CheckExternalEvents(cs1, 0x3B54);
        // 100D:3B54 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:3B55 jmp near 0xC43E
        return copy_game_area_fb2_to_fb1(0x0000);
    label_100D_3B58_13C28_15686:
        CheckExternalEvents(cs1, 0x3B58);
        // 100D:3B58 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_sal_room(int loadOffset)
    {
    label_100D_3B59_13C29_6769:
        CheckExternalEvents(cs1, 0x3B59);
        // 100D:3B59 sub SP,0x0018
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)24)));
        // 100D:3B5C mov word ptr DS:[0x47F6],SP
        UInt16[DS, (ushort)0x47F6] = SP;
        // 100D:3B60 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3B62 dec AX
        AX = Alu16.Dec(AX);
        // 100D:3B63 push AX
        Stack.Push16(AX);
        // 100D:3B64 mov CL,4
        CL = (byte)0x04;
        // 100D:3B66 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:3B68 je short 0x3B70
        if (ZeroFlag)
        {
            goto label_100D_3B70_13C40_6781;
        }
    label_100D_3B6A_13C3A_6778:
        CheckExternalEvents(cs1, 0x3B6A);
        // 100D:3B6A add AX,0x0013
        AX = Alu16.Add(AX, (ushort)0x0013);
        // 100D:3B6D call near 0xC13E
        NearCall(cs1, 0x3B70, open_sprite_bank);
    label_100D_3B70_13C40_6781:
        CheckExternalEvents(cs1, 0x3B70);
        // 100D:3B70 pop AX
        AX = Stack.Pop16();
        // 100D:3B71 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:3B74 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3B76 mov SI,0xBC6E
        SI = (ushort)0xBC6E;
        // 100D:3B79 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:3B7B mov SI,word ptr DS:[SI]
        SI = UInt16[DS, SI];
        // 100D:3B7D call near 0x3D83
        NearCall(cs1, 0x3B80, sal_position_markers);
    label_100D_3B80_13C50_6827:
        CheckExternalEvents(cs1, 0x3B80);
        // 100D:3B80 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3B81 cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:3B84 je short 0x3BB5
        if (ZeroFlag)
        {
            goto label_100D_3BB5_13C85_6979;
        }
    label_100D_3B86_13C56_6831:
        CheckExternalEvents(cs1, 0x3B86);
        // 100D:3B86 js short 0x3BBF
        if (SignFlag)
        {
            goto label_100D_3BBF_13C8F_7029;
        }
    label_100D_3B88_13C58_6833:
        CheckExternalEvents(cs1, 0x3B88);
        // 100D:3B88 mov DI,AX
        DI = AX;
        // 100D:3B8A shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:3B8C and AH,1
        AH = Alu8.And(AH, (byte)0x01);
        // 100D:3B8F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3B90 mov DX,AX
        DX = AX;
        // 100D:3B92 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3B93 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3B95 mov BX,AX
        BX = AX;
        // 100D:3B97 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3B98 push SI
        Stack.Push16(SI);
        // 100D:3B99 mov byte ptr CS:[0xC21A],AL
        UInt8[CS, (ushort)0xC21A] = AL;
        // 100D:3B9D mov AX,DI
        AX = DI;
        // 100D:3B9F and AX,0xFDFF
        AX = Alu16.And(AX, (ushort)0xFDFF);
        // 100D:3BA2 dec AX
        AX = Alu16.Dec(AX);
        // 100D:3BA3 and DI,0x01FF
        DI = Alu16.And(DI, (ushort)0x01FF);
        // 100D:3BA7 cmp DI,1
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:3BAA jne short 0x3BAF
        if (!ZeroFlag)
        {
            goto label_100D_3BAF_13C7F_6851;
        }
    label_100D_3BAC_13C7C_6966:
        CheckExternalEvents(cs1, 0x3BAC);
        // 100D:3BAC jmp near 0x3D12
        goto label_100D_3D12_13DE2_6968;
    label_100D_3BAF_13C7F_6851:
        CheckExternalEvents(cs1, 0x3BAF);
        // 100D:3BAF call near 0xC22F
        NearCall(cs1, 0x3BB2, draw_active_bank_sprite);
    label_100D_3BB2_13C82_6853:
        CheckExternalEvents(cs1, 0x3BB2);
        // 100D:3BB2 pop SI
        SI = Stack.Pop16();
        // 100D:3BB3 jmp short 0x3B80
        goto label_100D_3B80_13C50_6827;
    label_100D_3BB5_13C85_6979:
        CheckExternalEvents(cs1, 0x3BB5);
        // 100D:3BB5 mov byte ptr CS:[0xC21A],0
        UInt8[CS, (ushort)0xC21A] = (byte)0x00;
        // 100D:3BBB add SP,0x0018
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)24)));
        // 100D:3BBE ret near
        return NearRet((ushort)0x0000);
    label_100D_3BBF_13C8F_7029:
        CheckExternalEvents(cs1, 0x3BBF);
        // 100D:3BBF cmp AH,0xC0
        Alu8.Sub(AH, (byte)0xC0);
        // 100D:3BC2 je short 0x3BC9
        if (ZeroFlag)
        {
            goto label_100D_3BC9_13C99_7481;
        }
    label_100D_3BC4_13C94_7032:
        CheckExternalEvents(cs1, 0x3BC4);
        // 100D:3BC4 call near 0x3BE9
        NearCall(cs1, 0x3BC7, unknown_100D_3BE9_13CB9);
    label_100D_3BC7_13C97_7242:
        CheckExternalEvents(cs1, 0x3BC7);
        // 100D:3BC7 jmp short 0x3B80
        goto label_100D_3B80_13C50_6827;
    label_100D_3BC9_13C99_7481:
        CheckExternalEvents(cs1, 0x3BC9);
        // 100D:3BC9 push AX
        Stack.Push16(AX);
        // 100D:3BCA mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:3BCE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3BCF mov DX,AX
        DX = AX;
        // 100D:3BD1 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3BD2 mov BX,AX
        BX = AX;
        // 100D:3BD4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3BD5 mov DI,AX
        DI = AX;
        // 100D:3BD7 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3BD8 mov CX,AX
        CX = AX;
        // 100D:3BDA pop AX
        AX = Stack.Pop16();
        // 100D:3BDB push SI
        Stack.Push16(SI);
        // 100D:3BDC mov BP,0xFFFF
        BP = (ushort)0xFFFF;
        // 100D:3BDF mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:3BE2 call far dword ptr DS:[0x3901]
        ushort targetSegment_7496 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3901 + (ushort)0x0002)]));
        ushort targetOffset_7496 = unchecked((ushort)(UInt16[DS, (ushort)0x3901]));
        if (targetSegment_7496 == cs2 && targetOffset_7496 == 0x0139)
        {
            FarCall(cs1, 0x3BE6, cs2, unknown_3358_0139_336B9);
            goto label_100D_3BE6_13CB6_7604;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_7496:X4}:{targetOffset_7496:X4} at 100D:3BE2");
    label_100D_3BE6_13CB6_7604:
        CheckExternalEvents(cs1, 0x3BE6);
        // 100D:3BE6 pop SI
        SI = Stack.Pop16();
        // 100D:3BE7 jmp short 0x3B80
        goto label_100D_3B80_13C50_6827;
    label_100D_3D12_13DE2_6968:
        CheckExternalEvents(cs1, 0x3D12);
        // 100D:3D12 test byte ptr DS:[0x47A4],0x81
        Alu8.And(UInt8[DS, (ushort)0x47A4], (byte)0x81);
        // 100D:3D17 jne short 0x3D2B
        if (!ZeroFlag)
        {
            goto label_100D_3D2B_13DFB_6976;
        }
    label_100D_3D19_13DE9_6971:
        CheckExternalEvents(cs1, 0x3D19);
        // 100D:3D19 mov DI,word ptr DS:[0x47F6]
        DI = UInt16[DS, (ushort)0x47F6];
        // 100D:3D1D dec word ptr DS:[0x47F6]
        UInt16[DS, (ushort)0x47F6] = Alu16.Dec(UInt16[DS, (ushort)0x47F6]);
        // 100D:3D21 cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:3D24 je short 0x3D2B
        if (ZeroFlag)
        {
            goto label_100D_3D2B_13DFB_6976;
        }
    label_100D_3D26_13DF6_7756:
        CheckExternalEvents(cs1, 0x3D26);
        // 100D:3D26 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:3D28 call near 0x3D2F
        NearCall(cs1, 0x3D2B, draw_character);
    label_100D_3D2B_13DFB_6976:
        CheckExternalEvents(cs1, 0x3D2B);
        // 100D:3D2B pop SI
        SI = Stack.Pop16();
        // 100D:3D2C jmp near 0x3B80
        goto label_100D_3B80_13C50_6827;
    }

    public virtual Action unknown_100D_3BE9_13CB9(int loadOffset)
    {
    label_100D_3BE9_13CB9_7034:
        CheckExternalEvents(cs1, 0x3BE9);
        // 100D:3BE9 mov word ptr DS:[0x22D9],0x4C60
        UInt16[DS, (ushort)0x22D9] = (ushort)0x4C60;
        // 100D:3BEF push DS
        Stack.Push16(DS);
        // 100D:3BF0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:3BF1 mov AL,byte ptr DS:[SI-2]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-2)];
        // 100D:3BF4 mov byte ptr DS:[0x47ED],AL
        UInt8[DS, (ushort)0x47ED] = AL;
        // 100D:3BF7 mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 100D:3BFA mov byte ptr DS:[0x47EC],AL
        UInt8[DS, (ushort)0x47EC] = AL;
        // 100D:3BFD lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3BFE cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:3BFF shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C01 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C03 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C05 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C07 mov word ptr DS:[0x22DB],AX
        UInt16[DS, (ushort)0x22DB] = AX;
        // 100D:3C0A lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3C0B cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:3C0C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C0E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C10 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C12 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3C14 mov word ptr DS:[0x22DD],AX
        UInt16[DS, (ushort)0x22DD] = AX;
        // 100D:3C17 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C18 mov DX,AX
        DX = AX;
        // 100D:3C1A lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C1B mov BX,AX
        BX = AX;
        // 100D:3C1D mov word ptr DS:[0x47EE],DX
        UInt16[DS, (ushort)0x47EE] = DX;
        // 100D:3C21 mov word ptr DS:[0x47F0],BX
        UInt16[DS, (ushort)0x47F0] = BX;
    label_100D_3C25_13CF5_7062:
        CheckExternalEvents(cs1, 0x3C25);
        // 100D:3C25 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C26 push AX
        Stack.Push16(AX);
        // 100D:3C27 and AX,0x3FFF
        AX = Alu16.And(AX, (ushort)0x3FFF);
        // 100D:3C2A mov DI,AX
        DI = AX;
        // 100D:3C2C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C2D mov CX,AX
        CX = AX;
        // 100D:3C2F call near 0x3E13
        NearCall(cs1, 0x3C32, unknown_100D_3E13_13EE3);
    label_100D_3C32_13D02_7118:
        CheckExternalEvents(cs1, 0x3C32);
        // 100D:3C32 mov DX,DI
        DX = DI;
        // 100D:3C34 mov BX,CX
        BX = CX;
        // 100D:3C36 pop AX
        AX = Stack.Pop16();
        // 100D:3C37 test AX,0x4000
        Alu16.And(AX, (ushort)0x4000);
        // 100D:3C3A je short 0x3C25
        if (ZeroFlag)
        {
            goto label_100D_3C25_13CF5_7062;
        }
    label_100D_3C3C_13D0C_7124:
        CheckExternalEvents(cs1, 0x3C3C);
        // 100D:3C3C mov word ptr DS:[0x47F2],DI
        UInt16[DS, (ushort)0x47F2] = DI;
        // 100D:3C40 mov word ptr DS:[0x47F4],CX
        UInt16[DS, (ushort)0x47F4] = CX;
        // 100D:3C44 mov DX,word ptr DS:[0x47EE]
        DX = UInt16[DS, (ushort)0x47EE];
        // 100D:3C48 mov BX,word ptr DS:[0x47F0]
        BX = UInt16[DS, (ushort)0x47F0];
        // 100D:3C4C mov word ptr DS:[0x22D9],0x4C62
        UInt16[DS, (ushort)0x22D9] = (ushort)0x4C62;
        // 100D:3C52 test AX,0x8000
        Alu16.And(AX, (ushort)0x8000);
        // 100D:3C55 jne short 0x3C71
        if (!ZeroFlag)
        {
            goto label_100D_3C71_13D41_7165;
        }
    label_100D_3C57_13D27_7132:
        CheckExternalEvents(cs1, 0x3C57);
        // 100D:3C57 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C58 push AX
        Stack.Push16(AX);
        // 100D:3C59 and AX,0x3FFF
        AX = Alu16.And(AX, (ushort)0x3FFF);
        // 100D:3C5C mov DI,AX
        DI = AX;
        // 100D:3C5E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3C5F mov CX,AX
        CX = AX;
        // 100D:3C61 call near 0x3E13
        NearCall(cs1, 0x3C64, unknown_100D_3E13_13EE3);
    label_100D_3C64_13D34_7156:
        CheckExternalEvents(cs1, 0x3C64);
        // 100D:3C64 mov DX,DI
        DX = DI;
        // 100D:3C66 mov BX,CX
        BX = CX;
        // 100D:3C68 pop AX
        AX = Stack.Pop16();
        // 100D:3C69 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:3C6B jns short 0x3C57
        if (!SignFlag)
        {
            goto label_100D_3C57_13D27_7132;
        }
    label_100D_3C6D_13D3D_7162:
        CheckExternalEvents(cs1, 0x3C6D);
        // 100D:3C6D mov DX,DI
        DX = DI;
        // 100D:3C6F mov BX,CX
        BX = CX;
    label_100D_3C71_13D41_7165:
        CheckExternalEvents(cs1, 0x3C71);
        // 100D:3C71 mov DI,word ptr DS:[0x47F2]
        DI = UInt16[DS, (ushort)0x47F2];
        // 100D:3C75 mov CX,word ptr DS:[0x47F4]
        CX = UInt16[DS, (ushort)0x47F4];
        // 100D:3C79 call near 0x3E13
        NearCall(cs1, 0x3C7C, unknown_100D_3E13_13EE3);
    label_100D_3C7C_13D4C_7169:
        CheckExternalEvents(cs1, 0x3C7C);
        // 100D:3C7C mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:3C80 push SI
        Stack.Push16(SI);
        // 100D:3C81 mov BX,word ptr DS:[0x47F0]
        BX = UInt16[DS, (ushort)0x47F0];
        // 100D:3C85 mov BP,word ptr DS:[0x47F4]
        BP = UInt16[DS, (ushort)0x47F4];
        // 100D:3C89 sub BP,BX
        BP = Alu16.Sub(BP, BX);
        // 100D:3C8B lea SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:3C8F mov CX,BP
        CX = BP;
        // 100D:3C91 mov BP,0
        BP = (ushort)0x0000;
        // 100D:3C94 mov AH,byte ptr DS:[0x47EC]
        AH = UInt8[DS, (ushort)0x47EC];
        // 100D:3C98 and AH,0x3E
        AH = Alu8.And(AH, (byte)0x3E);
        // 100D:3C9B je short 0x3CA0
        if (ZeroFlag)
        {
            goto label_100D_3CA0_13D70_7181;
        }
    label_100D_3C9D_13D6D_9579:
        CheckExternalEvents(cs1, 0x3C9D);
        // 100D:3C9D mov BP,1
        BP = (ushort)0x0001;
    label_100D_3CA0_13D70_7181:
        CheckExternalEvents(cs1, 0x3CA0);
        // 100D:3CA0 mov AL,2
        AL = (byte)0x02;
        // 100D:3CA2 mov word ptr DS:[0x22DF],AX
        UInt16[DS, (ushort)0x22DF] = AX;
        // 100D:3CA5 mov AH,byte ptr DS:[0x47ED]
        AH = UInt8[DS, (ushort)0x47ED];
        // 100D:3CA9 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:3CAB test byte ptr DS:[0x47EC],1
        Alu8.And(UInt8[DS, (ushort)0x47EC], (byte)0x01);
        // 100D:3CB0 jne short 0x3CE0
        if (!ZeroFlag)
        {
            goto label_100D_3CE0_13DB0_11005;
        }
    label_100D_3CB2_13D82_7188:
        CheckExternalEvents(cs1, 0x3CB2);
        // 100D:3CB2 push CX
        Stack.Push16(CX);
        // 100D:3CB3 push AX
        Stack.Push16(AX);
        // 100D:3CB4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3CB5 mov DX,AX
        DX = AX;
        // 100D:3CB7 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3CB8 mov CX,AX
        CX = AX;
        // 100D:3CBA pop AX
        AX = Stack.Pop16();
        // 100D:3CBB cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:3CBD jb short 0x3CC1
        if (CarryFlag)
        {
            goto label_100D_3CC1_13D91_7200;
        }
    label_100D_3CBF_13D8F_7198:
        CheckExternalEvents(cs1, 0x3CBF);
        // 100D:3CBF xchg DX,CX
        ushort temp_100D_3CBF_13D8F = DX;
        DX = CX;
        CX = unchecked((ushort)temp_100D_3CBF_13D8F);
    label_100D_3CC1_13D91_7200:
        CheckExternalEvents(cs1, 0x3CC1);
        // 100D:3CC1 inc CX
        CX = Alu16.Inc(CX);
        // 100D:3CC2 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 100D:3CC4 je short 0x3CD6
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:3CC4");
        }
    label_100D_3CC6_13D96_7203:
        CheckExternalEvents(cs1, 0x3CC6);
        // 100D:3CC6 push SI
        Stack.Push16(SI);
        // 100D:3CC7 push BX
        Stack.Push16(BX);
        // 100D:3CC8 mov SI,word ptr DS:[0x22DF]
        SI = UInt16[DS, (ushort)0x22DF];
        // 100D:3CCC mov DI,word ptr DS:[0x22DB]
        DI = UInt16[DS, (ushort)0x22DB];
        // 100D:3CD0 call far dword ptr DS:[0x3945]
        ushort targetSegment_7208 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3945 + (ushort)0x0002)]));
        ushort targetOffset_7208 = unchecked((ushort)(UInt16[DS, (ushort)0x3945]));
        if (targetSegment_7208 == cs2 && targetOffset_7208 == 0x016C)
        {
            FarCall(cs1, 0x3CD4, cs2, unknown_3358_016C_336EC);
            goto label_100D_3CD4_13DA4_7232;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_7208:X4}:{targetOffset_7208:X4} at 100D:3CD0");
    label_100D_3CD4_13DA4_7232:
        CheckExternalEvents(cs1, 0x3CD4);
        // 100D:3CD4 pop BX
        BX = Stack.Pop16();
        // 100D:3CD5 pop SI
        SI = Stack.Pop16();
        // 100D:3CD6 add AX,word ptr DS:[0x22DD]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x22DD]);
        // 100D:3CDA inc BX
        BX = Alu16.Inc(BX);
        // 100D:3CDB pop CX
        CX = Stack.Pop16();
        // 100D:3CDC loop 0x3CB2
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_3CB2_13D82_7188;
        }
    label_100D_3CDE_13DAE_7239:
        CheckExternalEvents(cs1, 0x3CDE);
        // 100D:3CDE pop SI
        SI = Stack.Pop16();
        // 100D:3CDF ret near
        return NearRet((ushort)0x0000);
    label_100D_3CE0_13DB0_11005:
        CheckExternalEvents(cs1, 0x3CE0);
        // 100D:3CE0 push CX
        Stack.Push16(CX);
        // 100D:3CE1 push AX
        Stack.Push16(AX);
        // 100D:3CE2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3CE3 mov DX,AX
        DX = AX;
        // 100D:3CE5 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:3CE6 mov CX,AX
        CX = AX;
        // 100D:3CE8 pop AX
        AX = Stack.Pop16();
        // 100D:3CE9 cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:3CEB jae short 0x3CEF
        if (!CarryFlag)
        {
            goto label_100D_3CEF_13DBF_11015;
        }
    label_100D_3CED_13DBD_26040:
        CheckExternalEvents(cs1, 0x3CED);
        // 100D:3CED xchg DX,CX
        ushort temp_100D_3CED_13DBD = DX;
        DX = CX;
        CX = unchecked((ushort)temp_100D_3CED_13DBD);
    label_100D_3CEF_13DBF_11015:
        CheckExternalEvents(cs1, 0x3CEF);
        // 100D:3CEF dec CX
        CX = Alu16.Dec(CX);
        // 100D:3CF0 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 100D:3CF2 je short 0x3D08
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:3CF2");
        }
    label_100D_3CF4_13DC4_11019:
        CheckExternalEvents(cs1, 0x3CF4);
        // 100D:3CF4 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:3CF6 push SI
        Stack.Push16(SI);
        // 100D:3CF7 push BX
        Stack.Push16(BX);
        // 100D:3CF8 mov SI,word ptr DS:[0x22DF]
        SI = UInt16[DS, (ushort)0x22DF];
        // 100D:3CFC mov DI,word ptr DS:[0x22DB]
        DI = UInt16[DS, (ushort)0x22DB];
        // 100D:3D00 std
        DirectionFlag = true;
        // 100D:3D01 call far dword ptr DS:[0x3945]
        ushort targetSegment_11026 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3945 + (ushort)0x0002)]));
        ushort targetOffset_11026 = unchecked((ushort)(UInt16[DS, (ushort)0x3945]));
        if (targetSegment_11026 == cs2 && targetOffset_11026 == 0x016C)
        {
            FarCall(cs1, 0x3D05, cs2, unknown_3358_016C_336EC);
            goto label_100D_3D05_13DD5_11027;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_11026:X4}:{targetOffset_11026:X4} at 100D:3D01");
    label_100D_3D05_13DD5_11027:
        CheckExternalEvents(cs1, 0x3D05);
        // 100D:3D05 pop BX
        BX = Stack.Pop16();
        // 100D:3D06 pop SI
        SI = Stack.Pop16();
        // 100D:3D07 cld
        DirectionFlag = false;
        // 100D:3D08 add AX,word ptr DS:[0x22DD]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x22DD]);
        // 100D:3D0C inc BX
        BX = Alu16.Inc(BX);
        // 100D:3D0D pop CX
        CX = Stack.Pop16();
        // 100D:3D0E loop 0x3CE0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_3CE0_13DB0_11005;
        }
    label_100D_3D10_13DE0_11035:
        CheckExternalEvents(cs1, 0x3D10);
        // 100D:3D10 pop SI
        SI = Stack.Pop16();
        // 100D:3D11 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_character(int loadOffset)
    {
    label_100D_3D2F_13DFF_7759:
        CheckExternalEvents(cs1, 0x3D2F);
        // 100D:3D2F push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:3D33 push AX
        Stack.Push16(AX);
        // 100D:3D34 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3D36 mov DI,AX
        DI = AX;
        // 100D:3D38 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:3D3A shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:3D3C mov word ptr DS:[DI+0x47F8],DX
        UInt16[DS, (ushort)(DI + (short)18424)] = DX;
        // 100D:3D40 mov word ptr DS:[DI+0x47FA],BX
        UInt16[DS, (ushort)(DI + (short)18426)] = BX;
        // 100D:3D44 mov AX,0x0026
        AX = (ushort)0x0026;
        // 100D:3D47 call near 0xC13E
        NearCall(cs1, 0x3D4A, open_sprite_bank);
    label_100D_3D4A_13E1A_7771:
        CheckExternalEvents(cs1, 0x3D4A);
        // 100D:3D4A pop AX
        AX = Stack.Pop16();
        // 100D:3D4B mov CH,AH
        CH = AH;
        // 100D:3D4D cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 100D:3D4F jb short 0x3D58
        if (CarryFlag)
        {
            goto label_100D_3D58_13E28_7776;
        }
    label_100D_3D51_13E21_23478:
        CheckExternalEvents(cs1, 0x3D51);
        // 100D:3D51 sub AL,0x0F
        AL = Alu8.Sub(AL, (byte)0x0F);
        // 100D:3D53 mov byte ptr DS:[0x476C],AL
        UInt8[DS, (ushort)0x476C] = AL;
        // 100D:3D56 mov AL,0x0F
        AL = (byte)0x0F;
    label_100D_3D58_13E28_7776:
        CheckExternalEvents(cs1, 0x3D58);
        // 100D:3D58 call near 0x9123
        NearCall(cs1, 0x3D5B, character_sprite_map);
    label_100D_3D5B_13E2B_7789:
        CheckExternalEvents(cs1, 0x3D5B);
        // 100D:3D5B call near 0x127C
        NearCall(cs1, 0x3D5E, is_gurney_between_phases_15_and_20);
    label_100D_3D5E_13E2E_7797:
        CheckExternalEvents(cs1, 0x3D5E);
        // 100D:3D5E jae short 0x3D65
        if (!CarryFlag)
        {
            goto label_100D_3D65_13E35_7799;
        }
    label_100D_3D60_13E30_32892:
        CheckExternalEvents(cs1, 0x3D60);
        // 100D:3D60 mov AL,0x11
        AL = (byte)0x11;
        // 100D:3D62 add BX,0x0035
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)53)));
    label_100D_3D65_13E35_7799:
        CheckExternalEvents(cs1, 0x3D65);
        // 100D:3D65 cmp AL,0x0C
        Alu8.Sub(AL, (byte)0x0C);
        // 100D:3D67 jne short 0x3D72
        if (!ZeroFlag)
        {
            goto label_100D_3D72_13E42_7802;
        }
    label_100D_3D69_13E39_38188:
        CheckExternalEvents(cs1, 0x3D69);
        // 100D:3D69 test byte ptr DS:[0x10A7],0x10
        Alu8.And(UInt8[DS, (ushort)0x10A7], (byte)0x10);
        // 100D:3D6E je short 0x3D72
        if (ZeroFlag)
        {
            goto label_100D_3D72_13E42_7802;
        }
    label_100D_3D70_13E40_38192:
        CheckExternalEvents(cs1, 0x3D70);
        // 100D:3D70 mov AL,0x12
        AL = (byte)0x12;
    label_100D_3D72_13E42_7802:
        CheckExternalEvents(cs1, 0x3D72);
        // 100D:3D72 mov AH,CH
        AH = CH;
        // 100D:3D74 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:3D76 push AX
        Stack.Push16(AX);
        // 100D:3D77 call near 0xC2FD
        NearCall(cs1, 0x3D7A, unknown_100D_C2FD_1C3CD);
    label_100D_3D7A_13E4A_7815:
        CheckExternalEvents(cs1, 0x3D7A);
        // 100D:3D7A pop AX
        AX = Stack.Pop16();
        // 100D:3D7B inc AX
        AX = Alu16.Inc(AX);
        // 100D:3D7C call near 0xC22F
        NearCall(cs1, 0x3D7F, draw_active_bank_sprite);
    label_100D_3D7F_13E4F_7819:
        CheckExternalEvents(cs1, 0x3D7F);
        // 100D:3D7F pop AX
        AX = Stack.Pop16();
        // 100D:3D80 jmp near 0xC13E
        return open_sprite_bank(0x0000);
    }

    public virtual Action sal_position_markers(int loadOffset)
    {
    label_100D_3D83_13E53_6789:
        CheckExternalEvents(cs1, 0x3D83);
        // 100D:3D83 push DS
        Stack.Push16(DS);
        // 100D:3D84 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:3D85 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:3D88 mov CX,0x0017
        CX = (ushort)0x0017;
        // 100D:3D8B mov DI,word ptr DS:[0x47F6]
        DI = UInt16[DS, (ushort)0x47F6];
        // 100D:3D8F rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:3D91 mov DI,word ptr DS:[0x47F6]
        DI = UInt16[DS, (ushort)0x47F6];
        // 100D:3D95 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:3D9A je short 0x3DB0
        if (ZeroFlag)
        {
            goto label_100D_3DB0_13E80_6799;
        }
    label_100D_3D9C_13E6C_30377:
        CheckExternalEvents(cs1, 0x3D9C);
        // 100D:3D9C mov AX,word ptr DS:[0x4778]
        AX = UInt16[DS, (ushort)0x4778];
        // 100D:3D9F or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:3DA1 je short 0x3DB0
        if (ZeroFlag)
        {
            goto label_100D_3DB0_13E80_6799;
        }
    label_100D_3DA3_13E73_30381:
        CheckExternalEvents(cs1, 0x3DA3);
        // 100D:3DA3 push SI
        Stack.Push16(SI);
        // 100D:3DA4 mov SI,AX
        SI = AX;
        // 100D:3DA6 lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3DA8 mov CL,AL
        CL = AL;
        // 100D:3DAA rep movs byte ptr ES:[DI],byte ptr CS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[CS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:3DAD pop SI
        SI = Stack.Pop16();
        // 100D:3DAE jmp short 0x3DE5
        goto label_100D_3DE5_13EB5_6819;
    label_100D_3DB0_13E80_6799:
        CheckExternalEvents(cs1, 0x3DB0);
        // 100D:3DB0 mov DX,word ptr DS:[0x0012]
        DX = UInt16[DS, (ushort)0x0012];
        // 100D:3DB4 xor DX,word ptr DS:[0x0010]
        DX = Alu16.Xor(DX, UInt16[DS, (ushort)0x0010]);
        // 100D:3DB8 mov CL,byte ptr DS:[SI]
        CL = UInt8[DS, SI];
        // 100D:3DBA or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:3DBC je short 0x3DE5
        if (ZeroFlag)
        {
            goto label_100D_3DE5_13EB5_6819;
        }
    label_100D_3DBE_13E8E_6805:
        CheckExternalEvents(cs1, 0x3DBE);
        // 100D:3DBE mov CH,byte ptr DS:[0x00C5]
        CH = UInt8[DS, (ushort)0x00C5];
        // 100D:3DC2 and CH,0x0F
        CH = Alu8.And(CH, (byte)0x0F);
        // 100D:3DC5 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
    label_100D_3DC8_13E98_6809:
        CheckExternalEvents(cs1, 0x3DC8);
        // 100D:3DC8 inc AX
        AX = Alu16.Inc(AX);
        // 100D:3DC9 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:3DCB jae short 0x3DD0
        if (!CarryFlag)
        {
            goto label_100D_3DD0_13EA0_6812;
        }
    label_100D_3DCD_13E9D_7015:
        CheckExternalEvents(cs1, 0x3DCD);
        // 100D:3DCD call near 0x3DF4
        NearCall(cs1, 0x3DD0, assign_position_marker);
    label_100D_3DD0_13EA0_6812:
        CheckExternalEvents(cs1, 0x3DD0);
        // 100D:3DD0 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:3DD2 jne short 0x3DC8
        if (!ZeroFlag)
        {
            goto label_100D_3DC8_13E98_6809;
        }
    label_100D_3DD4_13EA4_6815:
        CheckExternalEvents(cs1, 0x3DD4);
        // 100D:3DD4 mov DL,byte ptr DS:[0x476A]
        DL = UInt8[DS, (ushort)0x476A];
        // 100D:3DD8 dec DX
        DX = Alu16.Dec(DX);
        // 100D:3DD9 jle short 0x3DE5
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_3DE5_13EB5_6819;
        }
    label_100D_3DDB_13EAB_32028:
        CheckExternalEvents(cs1, 0x3DDB);
        // 100D:3DDB mov AX,0x000F
        AX = (ushort)0x000F;
    label_100D_3DDE_13EAE_32030:
        CheckExternalEvents(cs1, 0x3DDE);
        // 100D:3DDE inc AX
        AX = Alu16.Inc(AX);
        // 100D:3DDF call near 0x3DF4
        NearCall(cs1, 0x3DE2, assign_position_marker);
    label_100D_3DE2_13EB2_32032:
        CheckExternalEvents(cs1, 0x3DE2);
        // 100D:3DE2 dec DX
        DX = Alu16.Dec(DX);
        // 100D:3DE3 jne short 0x3DDE
        if (!ZeroFlag)
        {
            goto label_100D_3DDE_13EAE_32030;
        }
    label_100D_3DE5_13EB5_6819:
        CheckExternalEvents(cs1, 0x3DE5);
        // 100D:3DE5 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:3DE6 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3DE8 mov DI,word ptr DS:[0x47F6]
        DI = UInt16[DS, (ushort)0x47F6];
        // 100D:3DEC dec AX
        AX = Alu16.Dec(AX);
        // 100D:3DED add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:3DEF mov word ptr DS:[0x47F6],DI
        UInt16[DS, (ushort)0x47F6] = DI;
        // 100D:3DF3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action assign_position_marker(int loadOffset)
    {
    label_100D_3DF4_13EC4_7017:
        CheckExternalEvents(cs1, 0x3DF4);
        // 100D:3DF4 mov BX,AX
        BX = AX;
        // 100D:3DF6 add BL,CH
        BL = Alu8.Add(BL, CH);
    label_100D_3DF8_13EC8_7020:
        CheckExternalEvents(cs1, 0x3DF8);
        // 100D:3DF8 sub BL,CL
        BL = Alu8.Sub(BL, CL);
        // 100D:3DFA jae short 0x3DF8
        if (!CarryFlag)
        {
            goto label_100D_3DF8_13EC8_7020;
        }
    label_100D_3DFC_13ECC_7022:
        CheckExternalEvents(cs1, 0x3DFC);
        // 100D:3DFC add BL,CL
        BL = Alu8.Add(BL, CL);
        // 100D:3DFE cmp byte ptr DS:[BX+DI],0xFF
        Alu8.Sub(UInt8[DS, (ushort)(BX + DI)], (byte)0xFF);
        // 100D:3E01 je short 0x3E10
        if (ZeroFlag)
        {
            goto label_100D_3E10_13EE0_7026;
        }
    label_100D_3E03_13ED3_32895:
        CheckExternalEvents(cs1, 0x3E03);
        // 100D:3E03 mov BX,0xFFFF
        BX = (ushort)0xFFFF;
    label_100D_3E06_13ED6_32897:
        CheckExternalEvents(cs1, 0x3E06);
        // 100D:3E06 inc BX
        BX = Alu16.Inc(BX);
        // 100D:3E07 cmp BL,CL
        Alu8.Sub(BL, CL);
        // 100D:3E09 jae short 0x3E12
        if (!CarryFlag)
        {
            goto label_100D_3E12_13EE2_7028;
        }
    label_100D_3E0B_13EDB_32900:
        CheckExternalEvents(cs1, 0x3E0B);
        // 100D:3E0B cmp byte ptr DS:[BX+DI],0xFF
        Alu8.Sub(UInt8[DS, (ushort)(BX + DI)], (byte)0xFF);
        // 100D:3E0E jne short 0x3E06
        if (!ZeroFlag)
        {
            goto label_100D_3E06_13ED6_32897;
        }
    label_100D_3E10_13EE0_7026:
        CheckExternalEvents(cs1, 0x3E10);
        // 100D:3E10 mov byte ptr DS:[BX+DI],AL
        UInt8[DS, (ushort)(BX + DI)] = AL;
    label_100D_3E12_13EE2_7028:
        CheckExternalEvents(cs1, 0x3E12);
        // 100D:3E12 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3E13_13EE3(int loadOffset)
    {
    label_100D_3E13_13EE3_7069:
        CheckExternalEvents(cs1, 0x3E13);
        // 100D:3E13 push BX
        Stack.Push16(BX);
        // 100D:3E14 push CX
        Stack.Push16(CX);
        // 100D:3E15 push DX
        Stack.Push16(DX);
        // 100D:3E16 push DI
        Stack.Push16(DI);
        // 100D:3E17 mov word ptr DS:[0x47E8],DX
        UInt16[DS, (ushort)0x47E8] = DX;
        // 100D:3E1B mov word ptr DS:[0x47EA],BX
        UInt16[DS, (ushort)0x47EA] = BX;
        // 100D:3E1F sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:3E21 sub DX,DI
        DX = Alu16.Sub(DX, DI);
        // 100D:3E23 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:3E25 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:3E27 call near 0x3E80
        NearCall(cs1, 0x3E2A, unknown_100D_3E80_13F50);
    label_100D_3E2A_13EFA_7112:
        CheckExternalEvents(cs1, 0x3E2A);
        // 100D:3E2A pop DI
        DI = Stack.Pop16();
        // 100D:3E2B pop DX
        DX = Stack.Pop16();
        // 100D:3E2C pop CX
        CX = Stack.Pop16();
        // 100D:3E2D pop BX
        BX = Stack.Pop16();
        // 100D:3E2E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3E80_13F50(int loadOffset)
    {
        goto label_100D_3E80_13F50_7081;

    label_100D_3E2F_13EFF_7140:
        CheckExternalEvents(cs1, 0x3E2F);
        // 100D:3E2F mov BX,word ptr DS:[0x47EA]
        BX = UInt16[DS, (ushort)0x47EA];
        // 100D:3E33 mov CX,DX
        CX = DX;
        // 100D:3E35 mov DX,word ptr DS:[0x47E8]
        DX = UInt16[DS, (ushort)0x47E8];
        // 100D:3E39 add word ptr DS:[0x47E8],CX
        UInt16[DS, (ushort)0x47E8] = Alu16.Add(UInt16[DS, (ushort)0x47E8], CX);
        // 100D:3E3D jae short 0x3E41
        if (!CarryFlag)
        {
            goto label_100D_3E41_13F11_7148;
        }
    label_100D_3E3F_13F0F_7146:
        CheckExternalEvents(cs1, 0x3E3F);
        // 100D:3E3F add DX,CX
        DX = Alu16.Add(DX, CX);
    label_100D_3E41_13F11_7148:
        CheckExternalEvents(cs1, 0x3E41);
        // 100D:3E41 mov DI,word ptr DS:[0x22D9]
        DI = UInt16[DS, (ushort)0x22D9];
        // 100D:3E45 mov AX,DX
        AX = DX;
        // 100D:3E47 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:3E48 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:3E4B mov word ptr DS:[0x22D9],DI
        UInt16[DS, (ushort)0x22D9] = DI;
        // 100D:3E4F pop SI
        SI = Stack.Pop16();
        // 100D:3E50 pop DI
        DI = Stack.Pop16();
        // 100D:3E51 ret near
        return NearRet((ushort)0x0000);
    label_100D_3E52_13F22_7092:
        CheckExternalEvents(cs1, 0x3E52);
        // 100D:3E52 mov CX,BX
        CX = BX;
        // 100D:3E54 mov BX,word ptr DS:[0x47EA]
        BX = UInt16[DS, (ushort)0x47EA];
        // 100D:3E58 mov DX,word ptr DS:[0x47E8]
        DX = UInt16[DS, (ushort)0x47E8];
        // 100D:3E5C or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:3E5E jns short 0x3E68
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3E5E");
        }
    label_100D_3E68_13F38_7098:
        CheckExternalEvents(cs1, 0x3E68);
        // 100D:3E68 add word ptr DS:[0x47EA],CX
        UInt16[DS, (ushort)0x47EA] = Alu16.Add(UInt16[DS, (ushort)0x47EA], CX);
        // 100D:3E6C inc CX
        CX = Alu16.Inc(CX);
        // 100D:3E6D mov DI,word ptr DS:[0x22D9]
        DI = UInt16[DS, (ushort)0x22D9];
        // 100D:3E71 mov AX,DX
        AX = DX;
    label_100D_3E73_13F43_7103:
        CheckExternalEvents(cs1, 0x3E73);
        // 100D:3E73 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:3E74 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:3E77 loop 0x3E73
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_3E73_13F43_7103;
        }
    label_100D_3E79_13F49_7107:
        CheckExternalEvents(cs1, 0x3E79);
        // 100D:3E79 mov word ptr DS:[0x22D9],DI
        UInt16[DS, (ushort)0x22D9] = DI;
        // 100D:3E7D pop SI
        SI = Stack.Pop16();
        // 100D:3E7E pop DI
        DI = Stack.Pop16();
        // 100D:3E7F ret near
        return NearRet((ushort)0x0000);
    label_100D_3E80_13F50_7081:
        CheckExternalEvents(cs1, 0x3E80);
        // 100D:3E80 push DI
        Stack.Push16(DI);
        // 100D:3E81 push SI
        Stack.Push16(SI);
        // 100D:3E82 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:3E84 je short 0x3E2F
        if (ZeroFlag)
        {
            goto label_100D_3E2F_13EFF_7140;
        }
    label_100D_3E86_13F56_7086:
        CheckExternalEvents(cs1, 0x3E86);
        // 100D:3E86 mov AX,1
        AX = (ushort)0x0001;
        // 100D:3E89 jns short 0x3E8F
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3E89");
        }
    label_100D_3E8F_13F5F_7089:
        CheckExternalEvents(cs1, 0x3E8F);
        // 100D:3E8F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:3E91 je short 0x3E52
        if (ZeroFlag)
        {
            goto label_100D_3E52_13F22_7092;
        }
    label_100D_3E93_13F63_7244:
        CheckExternalEvents(cs1, 0x3E93);
        // 100D:3E93 mov CX,1
        CX = (ushort)0x0001;
        // 100D:3E96 jns short 0x3E9C
        if (!SignFlag)
        {
            goto label_100D_3E9C_13F6C_7247;
        }
    label_100D_3E98_13F68_7300:
        CheckExternalEvents(cs1, 0x3E98);
        // 100D:3E98 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:3E9A neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_3E9C_13F6C_7247:
        CheckExternalEvents(cs1, 0x3E9C);
        // 100D:3E9C push AX
        Stack.Push16(AX);
        // 100D:3E9D push CX
        Stack.Push16(CX);
        // 100D:3E9E push AX
        Stack.Push16(AX);
        // 100D:3E9F push CX
        Stack.Push16(CX);
        // 100D:3EA0 mov BP,SP
        BP = SP;
        // 100D:3EA2 mov SI,BX
        SI = BX;
        // 100D:3EA4 mov DI,DX
        DI = DX;
        // 100D:3EA6 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:3EA8 cmp DX,BX
        Alu16.Sub(DX, BX);
        // 100D:3EAA jbe short 0x3EB1
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_3EB1_13F81_7475;
        }
    label_100D_3EAC_13F7C_7258:
        CheckExternalEvents(cs1, 0x3EAC);
        // 100D:3EAC mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:3EAF jmp short 0x3EBA
        goto label_100D_3EBA_13F8A_7261;
    label_100D_3EB1_13F81_7475:
        CheckExternalEvents(cs1, 0x3EB1);
        // 100D:3EB1 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:3EB3 je short 0x3EF8
        if (ZeroFlag)
        {
            goto label_100D_3EF8_13FC8_7294;
        }
    label_100D_3EB5_13F85_7478:
        CheckExternalEvents(cs1, 0x3EB5);
        // 100D:3EB5 xchg DI,SI
        ushort temp_100D_3EB5_13F85 = DI;
        DI = SI;
        SI = unchecked((ushort)temp_100D_3EB5_13F85);
        // 100D:3EB7 mov word ptr SS:[BP],AX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = AX;
    label_100D_3EBA_13F8A_7261:
        CheckExternalEvents(cs1, 0x3EBA);
        // 100D:3EBA mov AX,DI
        AX = DI;
        // 100D:3EBC mov CX,DI
        CX = DI;
        // 100D:3EBE shr AX,1
        AX = Alu16.Shr(AX, 1);
    label_100D_3EC0_13F90_7265:
        CheckExternalEvents(cs1, 0x3EC0);
        // 100D:3EC0 add AX,SI
        AX = Alu16.Add(AX, SI);
        // 100D:3EC2 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:3EC4 jb short 0x3ED0
        if (CarryFlag)
        {
            goto label_100D_3ED0_13FA0_7268;
        }
    label_100D_3EC6_13F96_7278:
        CheckExternalEvents(cs1, 0x3EC6);
        // 100D:3EC6 sub AX,DI
        AX = Alu16.Sub(AX, DI);
        // 100D:3EC8 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:3ECB mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:3ECE jmp short 0x3ED6
        goto label_100D_3ED6_13FA6_7271;
    label_100D_3ED0_13FA0_7268:
        CheckExternalEvents(cs1, 0x3ED0);
        // 100D:3ED0 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:3ED3 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
    label_100D_3ED6_13FA6_7271:
        CheckExternalEvents(cs1, 0x3ED6);
        // 100D:3ED6 add DX,word ptr DS:[0x47E8]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x47E8]);
        // 100D:3EDA cmp BX,1
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:3EDD jne short 0x3EF2
        if (!ZeroFlag)
        {
            goto label_100D_3EF2_13FC2_7274;
        }
    label_100D_3EDF_13FAF_7284:
        CheckExternalEvents(cs1, 0x3EDF);
        // 100D:3EDF push DI
        Stack.Push16(DI);
        // 100D:3EE0 push AX
        Stack.Push16(AX);
        // 100D:3EE1 mov DI,word ptr DS:[0x22D9]
        DI = UInt16[DS, (ushort)0x22D9];
        // 100D:3EE5 mov AX,word ptr DS:[0x47E8]
        AX = UInt16[DS, (ushort)0x47E8];
        // 100D:3EE8 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:3EE9 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:3EEC mov word ptr DS:[0x22D9],DI
        UInt16[DS, (ushort)0x22D9] = DI;
        // 100D:3EF0 pop AX
        AX = Stack.Pop16();
        // 100D:3EF1 pop DI
        DI = Stack.Pop16();
    label_100D_3EF2_13FC2_7274:
        CheckExternalEvents(cs1, 0x3EF2);
        // 100D:3EF2 mov word ptr DS:[0x47E8],DX
        UInt16[DS, (ushort)0x47E8] = DX;
        // 100D:3EF6 loop 0x3EC0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_3EC0_13F90_7265;
        }
    label_100D_3EF8_13FC8_7294:
        CheckExternalEvents(cs1, 0x3EF8);
        // 100D:3EF8 add SP,8
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:3EFB pop SI
        SI = Stack.Pop16();
        // 100D:3EFC pop DI
        DI = Stack.Pop16();
        // 100D:3EFD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3EFE_13FCE(int loadOffset)
    {
    label_100D_3EFE_13FCE_6724:
        CheckExternalEvents(cs1, 0x3EFE);
        // 100D:3EFE mov AL,DH
        AL = DH;
        // 100D:3F00 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3F02 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:3F04 mov SI,AX
        SI = AX;
        // 100D:3F06 mov SI,word ptr DS:[SI+0x13C4]
        SI = UInt16[DS, (ushort)(SI + (short)5060)];
        // 100D:3F0A mov AL,DL
        AL = DL;
        // 100D:3F0C dec AL
        AL = Alu8.Dec(AL);
        // 100D:3F0E mov AH,5
        AH = (byte)0x05;
        // 100D:3F10 mul AH
        ushort result_100D_3F10_13FE0 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_3F10_13FE0 >> 8));
        AL = unchecked((byte)result_100D_3F10_13FE0);
        // 100D:3F12 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:3F14 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_click_move_up(int loadOffset)
    {
    entrydispatcher:
    label_100D_3F15_13FE5_19790:
        CheckExternalEvents(cs1, 0x3F15);
        // 100D:3F15 mov BP,1
        BP = (ushort)0x0001;
        // 100D:3F18 jmp short 0x3F27
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x3F27))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action ui_click_move_right(int loadOffset)
    {
    entrydispatcher:
    label_100D_3F1A_13FEA_20169:
        CheckExternalEvents(cs1, 0x3F1A);
        // 100D:3F1A mov BP,2
        BP = (ushort)0x0002;
        // 100D:3F1D jmp short 0x3F27
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x3F27))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action ui_click_move_down(int loadOffset)
    {
    entrydispatcher:
    label_100D_3F1F_13FEF_20388:
        CheckExternalEvents(cs1, 0x3F1F);
        // 100D:3F1F mov BP,3
        BP = (ushort)0x0003;
        // 100D:3F22 jmp short 0x3F27
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x3F27))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action ui_click_move_left(int loadOffset)
    {
    entrydispatcher:
    label_100D_3F24_13FF4_20193:
        CheckExternalEvents(cs1, 0x3F24);
        // 100D:3F24 mov BP,4
        BP = (ushort)0x0004;
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x3F27))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action commit_room_move(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_4057_14127_19909;

    label_100D_16FC_117CC_41300:
        CheckExternalEvents(cs1, 0x16FC);
        // 100D:16FC mov byte ptr DS:[0x002A],0xC8
        UInt8[DS, (ushort)0x002A] = (byte)0xC8;
        // 100D:1701 mov AX,0x128F
        AX = (ushort)0x128F;
        // 100D:1704 call near 0x1771
        NearCall(cs1, 0x1707, start_scripted_dialogue);
        if (JumpDispatcher.Jump(menu_callback_choice_continue_for_sequence, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_4057_14127_19909:
        CheckExternalEvents(cs1, 0x4057);
        // 100D:4057 call near 0x40C3
        NearCall(cs1, 0x405A, move_all_npcs_whose_bit_6_of_flags_is_set);
    label_100D_405A_1412A_19919:
        CheckExternalEvents(cs1, 0x405A);
        // 100D:405A mov word ptr DS:[4],DX
        UInt16[DS, (ushort)0x0004] = DX;
        // 100D:405E mov AL,DL
        AL = DL;
        // 100D:4060 xchg AL,byte ptr DS:[0x000B]
        ushort xchgOffset_100D_4060_14130 = (ushort)0x000B;
        byte temp_100D_4060_14130 = AL;
        AL = UInt8[DS, xchgOffset_100D_4060_14130];
        UInt8[DS, xchgOffset_100D_4060_14130] = unchecked((byte)temp_100D_4060_14130);
        // 100D:4064 mov byte ptr DS:[0x000D],AL
        UInt8[DS, (ushort)0x000D] = AL;
        // 100D:4067 mov word ptr DS:[6],BX
        UInt16[DS, (ushort)0x0006] = BX;
        // 100D:406B cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:4070 js short 0x4099
        if (SignFlag)
        {
            return unknown_100D_4099_14169(0x0000);
        }
    label_100D_4072_14142_19927:
        CheckExternalEvents(cs1, 0x4072);
        // 100D:4072 cmp DX,0x3002
        Alu16.Sub(DX, (ushort)0x3002);
        // 100D:4076 jne short 0x407B
        if (!ZeroFlag)
        {
            goto label_100D_407B_1414B_19930;
        }
    label_100D_4078_14148_41299:
        CheckExternalEvents(cs1, 0x4078);
        // 100D:4078 jmp near 0x16FC
        goto label_100D_16FC_117CC_41300;
    label_100D_407B_1414B_19930:
        CheckExternalEvents(cs1, 0x407B);
        // 100D:407B jmp near 0x2DBF
        if (JumpDispatcher.Jump(draw_room_game_screen_scene_reload, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action get_map_position(int loadOffset)
    {
    label_100D_407E_1414E_17417:
        CheckExternalEvents(cs1, 0x407E);
        // 100D:407E mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:4082 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:4086 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:4089 jne short 0x4096
        if (!ZeroFlag)
        {
            goto label_100D_4096_14166_21957;
        }
    label_100D_408B_1415B_17422:
        CheckExternalEvents(cs1, 0x408B);
        // 100D:408B mov SI,word ptr DS:[0x114E]
        SI = UInt16[DS, (ushort)0x114E];
        // 100D:408F mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:4092 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:4095 ret near
        return NearRet((ushort)0x0000);
    label_100D_4096_14166_21957:
        CheckExternalEvents(cs1, 0x4096);
        // 100D:4096 xchg BX,AX
        ushort temp_100D_4096_14166 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_4096_14166);
        // 100D:4097 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:4098 xchg BX,AX
        ushort temp_100D_4098_14168 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_4098_14168);
        return unknown_100D_4099_14169(0x0000);
    }

    public virtual Action find_location_by_map_offset(int loadOffset)
    {
    label_100D_409A_1416A_20543:
        CheckExternalEvents(cs1, 0x409A);
        // 100D:409A mov SI,0x00E4
        SI = (ushort)0x00E4;
    label_100D_409D_1416D_20545:
        CheckExternalEvents(cs1, 0x409D);
        // 100D:409D add SI,0x001C
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:40A0 cmp word ptr DS:[SI],-1
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:40A3 je short 0x40AB
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:40A3");
        }
    label_100D_40A5_14175_20548:
        CheckExternalEvents(cs1, 0x40A5);
        // 100D:40A5 cmp DI,word ptr DS:[SI+6]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:40A8 jne short 0x409D
        if (!ZeroFlag)
        {
            goto label_100D_409D_1416D_20545;
        }
    label_100D_40AA_1417A_20551:
        CheckExternalEvents(cs1, 0x40AA);
        // 100D:40AA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action location_entry_room_codes(int loadOffset)
    {
    label_100D_40AE_1417E_22610:
        CheckExternalEvents(cs1, 0x40AE);
        // 100D:40AE mov AX,DI
        AX = DI;
        // 100D:40B0 sub AX,0x0100
        AX = Alu16.Sub(AX, (ushort)0x0100);
        // 100D:40B3 mov BL,0x1C
        BL = (byte)0x1C;
        // 100D:40B5 div BL
        byte divisor_100D_40B5_14185 = BL;
        ushort dividend_100D_40B5_14185 = AX;
        byte quotient_100D_40B5_14185 = Alu8.Div(unchecked((ushort)dividend_100D_40B5_14185), unchecked((byte)divisor_100D_40B5_14185));
        AL = unchecked((byte)quotient_100D_40B5_14185);
        AH = unchecked((byte)(dividend_100D_40B5_14185 % unchecked((ushort)divisor_100D_40B5_14185)));
        // 100D:40B7 mov BH,AL
        BH = AL;
        // 100D:40B9 inc BH
        BH = Alu8.Inc(BH);
        // 100D:40BB mov BL,0x80
        BL = (byte)0x80;
        // 100D:40BD mov DH,byte ptr DS:[DI+8]
        DH = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:40C0 mov DL,1
        DL = (byte)0x01;
        // 100D:40C2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action move_all_npcs_whose_bit_6_of_flags_is_set(int loadOffset)
    {
    entrydispatcher:
    label_100D_40C3_14193_19911:
        CheckExternalEvents(cs1, 0x40C3);
        // 100D:40C3 mov BP,0x40C9
        BP = (ushort)0x40C9;
        // 100D:40C6 jmp near 0x36EE
        if (JumpDispatcher.Jump(scan_current_room_npcs, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_40C9_14199(int loadOffset)
    {
    label_100D_40C9_14199_19914:
        CheckExternalEvents(cs1, 0x40C9);
        // 100D:40C9 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:40CD je short 0x40D4
        if (ZeroFlag)
        {
            goto label_100D_40D4_141A4_19917;
        }
    label_100D_40CF_1419F_25218:
        CheckExternalEvents(cs1, 0x40CF);
        // 100D:40CF mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:40D1 mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
    label_100D_40D4_141A4_19917:
        CheckExternalEvents(cs1, 0x40D4);
        // 100D:40D4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action run_travel_departure_npc_scans(int loadOffset)
    {
    entrydispatcher:
    label_100D_40D5_141A5_21622:
        CheckExternalEvents(cs1, 0x40D5);
        // 100D:40D5 mov byte ptr DS:[0x0023],7
        UInt8[DS, (ushort)0x0023] = (byte)0x07;
        // 100D:40DA call near 0x36D3
        NearCall(cs1, 0x40DD, run_room_leave_dialogue_scan);
    label_100D_40DD_141AD_21625:
        CheckExternalEvents(cs1, 0x40DD);
        // 100D:40DD call near 0x4AC4
        NearCall(cs1, 0x40E0, unknown_100D_4AC4_14B94);
    label_100D_40E0_141B0_21627:
        CheckExternalEvents(cs1, 0x40E0);
        // 100D:40E0 mov BP,0x40E6
        BP = (ushort)0x40E6;
        // 100D:40E3 jmp near 0x36EE
        if (JumpDispatcher.Jump(scan_current_room_npcs, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action npc_travel_detach_companion(int loadOffset)
    {
    label_100D_40E6_141B6_25233:
        CheckExternalEvents(cs1, 0x40E6);
        // 100D:40E6 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:40EA je short 0x40F8
        if (ZeroFlag)
        {
            goto label_100D_40F8_141C8_25239;
        }
    label_100D_40EC_141BC_25236:
        CheckExternalEvents(cs1, 0x40EC);
        // 100D:40EC test byte ptr DS:[SI+0x0F],2
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x02);
        // 100D:40F0 je short 0x40F8
        if (ZeroFlag)
        {
            goto label_100D_40F8_141C8_25239;
        }
    label_100D_40F2_141C2_33053:
        CheckExternalEvents(cs1, 0x40F2);
        // 100D:40F2 call near 0x9556
        NearCall(cs1, 0x40F5, npc_clear_travelling);
    label_100D_40F5_141C5_33055:
        CheckExternalEvents(cs1, 0x40F5);
        // 100D:40F5 call near 0x9655
        NearCall(cs1, 0x40F8, npc_remove_companion_slot);
    label_100D_40F8_141C8_25239:
        CheckExternalEvents(cs1, 0x40F8);
        // 100D:40F8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action travel_scan_nearby_location(int loadOffset)
    {
    label_100D_40F9_141C9_25254:
        CheckExternalEvents(cs1, 0x40F9);
        // 100D:40F9 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:40FE jne short 0x4101
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:40FE");
        }
    label_100D_4101_141D1_25257:
        CheckExternalEvents(cs1, 0x4101);
        // 100D:4101 cmp word ptr DS:[0x0010],0
        Alu16.Sub(UInt16[DS, (ushort)0x0010], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:4106 je short 0x4181
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:4106");
        }
    label_100D_4108_141D8_25260:
        CheckExternalEvents(cs1, 0x4108);
        // 100D:4108 call near 0x407E
        NearCall(cs1, 0x410B, get_map_position);
    label_100D_410B_141DB_25262:
        CheckExternalEvents(cs1, 0x410B);
        // 100D:410B mov CX,9
        CX = (ushort)0x0009;
        // 100D:410E mov AX,9
        AX = (ushort)0x0009;
        // 100D:4111 call near 0xB56C
        NearCall(cs1, 0x4114, map_build_cell_strip);
    label_100D_4114_141E4_25266:
        CheckExternalEvents(cs1, 0x4114);
        // 100D:4114 mov CX,0x0051
        CX = (ushort)0x0051;
    label_100D_4117_141E7_25268:
        CheckExternalEvents(cs1, 0x4117);
        // 100D:4117 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:4118 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:411A je short 0x417C
        if (ZeroFlag)
        {
            goto label_100D_417C_1424C_25271;
        }
    label_100D_411C_141EC_25275:
        CheckExternalEvents(cs1, 0x411C);
        // 100D:411C mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:411E push CX
        Stack.Push16(CX);
        // 100D:411F push SI
        Stack.Push16(SI);
        // 100D:4120 call near 0x409A
        NearCall(cs1, 0x4123, find_location_by_map_offset);
    label_100D_4123_141F3_25280:
        CheckExternalEvents(cs1, 0x4123);
        // 100D:4123 jne short 0x417A
        if (!ZeroFlag)
        {
            goto label_100D_417A_1424A_25285;
        }
    label_100D_4125_141F5_25282:
        CheckExternalEvents(cs1, 0x4125);
        // 100D:4125 test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:4129 je short 0x417A
        if (ZeroFlag)
        {
            goto label_100D_417A_1424A_25285;
        }
    label_100D_412B_141FB_27086:
        CheckExternalEvents(cs1, 0x412B);
        // 100D:412B mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:412E cmp AL,byte ptr DS:[SI+0x0B]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)11)]);
        // 100D:4131 jb short 0x417A
        if (CarryFlag)
        {
            goto label_100D_417A_1424A_25285;
        }
    label_100D_4133_14203_27090:
        CheckExternalEvents(cs1, 0x4133);
        // 100D:4133 mov DI,SI
        DI = SI;
        // 100D:4135 call near 0x5124
        NearCall(cs1, 0x4138, compass_angle_to_location);
    label_100D_4138_14208_27093:
        CheckExternalEvents(cs1, 0x4138);
        // 100D:4138 jb short 0x417A
        if (CarryFlag)
        {
            goto label_100D_417A_1424A_25285;
        }
    label_100D_413A_1420A_27095:
        CheckExternalEvents(cs1, 0x413A);
        // 100D:413A sub AL,byte ptr DS:[0x11C7]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x11C7]);
        // 100D:413E add AL,0x60
        AL = Alu8.Add(AL, (byte)0x60);
        // 100D:4140 cmp AL,0xC0
        Alu8.Sub(AL, (byte)0xC0);
        // 100D:4142 jae short 0x417A
        if (!CarryFlag)
        {
            goto label_100D_417A_1424A_25285;
        }
    label_100D_4144_14214_27100:
        CheckExternalEvents(cs1, 0x4144);
        // 100D:4144 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4146 mov CX,0x00CE
        CX = (ushort)0x00CE;
        // 100D:4149 cmp AL,0x60
        Alu8.Sub(AL, (byte)0x60);
        // 100D:414B jb short 0x4152
        if (CarryFlag)
        {
            goto label_100D_4152_14222_27105;
        }
    label_100D_414D_1421D_33426:
        CheckExternalEvents(cs1, 0x414D);
        // 100D:414D inc AH
        AH = Alu8.Inc(AH);
        // 100D:414F add CX,2
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_4152_14222_27105:
        CheckExternalEvents(cs1, 0x4152);
        // 100D:4152 mov word ptr DS:[0x11F5],CX
        UInt16[DS, (ushort)0x11F5] = CX;
        // 100D:4156 mov byte ptr DS:[0x00E1],AH
        UInt8[DS, (ushort)0x00E1] = AH;
        // 100D:415A call near 0x6231
        NearCall(cs1, 0x415D, get_location_type_string_offset);
    label_100D_415D_1422D_27109:
        CheckExternalEvents(cs1, 0x415D);
        // 100D:415D add AX,0x0048
        AX = Alu16.Add(AX, (ushort)0x0048);
        // 100D:4160 mov word ptr DS:[0x11F3],AX
        UInt16[DS, (ushort)0x11F3] = AX;
        // 100D:4163 mov byte ptr DS:[0x0023],3
        UInt8[DS, (ushort)0x0023] = (byte)0x03;
        // 100D:4168 call near 0x425B
        NearCall(cs1, 0x416B, location_mark_discovered);
    label_100D_416B_1423B_27123:
        CheckExternalEvents(cs1, 0x416B);
        // 100D:416B call near 0x4944
        NearCall(cs1, 0x416E, arm_pending_travel);
    label_100D_416E_1423E_27125:
        CheckExternalEvents(cs1, 0x416E);
        // 100D:416E call near 0xDBB2
        NearCall(cs1, 0x4171, call_restore_cursor);
    label_100D_4171_14241_27127:
        CheckExternalEvents(cs1, 0x4171);
        // 100D:4171 call near 0x2EFB
        NearCall(cs1, 0x4174, build_room_command_records);
    label_100D_4174_14244_27129:
        CheckExternalEvents(cs1, 0x4174);
        // 100D:4174 call near 0x2FFB
        NearCall(cs1, 0x4177, rebuild_and_draw_room_nav_panel);
    label_100D_4177_14247_27131:
        CheckExternalEvents(cs1, 0x4177);
        // 100D:4177 call near 0xD397
        NearCall(cs1, 0x417A, redraw_active_command_menu);
    label_100D_417A_1424A_25285:
        CheckExternalEvents(cs1, 0x417A);
        // 100D:417A pop SI
        SI = Stack.Pop16();
        // 100D:417B pop CX
        CX = Stack.Pop16();
    label_100D_417C_1424C_25271:
        CheckExternalEvents(cs1, 0x417C);
        // 100D:417C add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:417F loop 0x4117
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_4117_141E7_25268;
        }
        else
        {
            return unknown_100D_4181_14251(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action travel_route_hostile_zone_check(int loadOffset)
    {
    label_100D_4182_14252_22083:
        CheckExternalEvents(cs1, 0x4182);
        // 100D:4182 mov AL,byte ptr DS:[0x11C9]
        AL = UInt8[DS, (ushort)0x11C9];
        // 100D:4185 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:4187 dec AL
        AL = Alu8.Dec(AL);
        // 100D:4189 jne short 0x4181
        if (!ZeroFlag)
        {
            return unknown_100D_4181_14251(0x0000);
        }
    label_100D_418B_1425B_22088:
        CheckExternalEvents(cs1, 0x418B);
        // 100D:418B cmp byte ptr DS:[0x11CB],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CB], (byte)0x00);
        // 100D:4190 jne short 0x419B
        if (!ZeroFlag)
        {
            goto label_100D_419B_1426B_27074;
        }
    label_100D_4192_14262_22091:
        CheckExternalEvents(cs1, 0x4192);
        // 100D:4192 mov DI,word ptr DS:[0x11C5]
        DI = UInt16[DS, (ushort)0x11C5];
        // 100D:4196 call near 0x5D36
        NearCall(cs1, 0x4199, location_is_atreides);
    label_100D_4199_14269_22099:
        CheckExternalEvents(cs1, 0x4199);
        // 100D:4199 jb short 0x41C5
        if (CarryFlag)
        {
            return ungrey_skip_to_destination_verb(0x0000);
        }
    label_100D_419B_1426B_27074:
        CheckExternalEvents(cs1, 0x419B);
        // 100D:419B call near 0x407E
        NearCall(cs1, 0x419E, get_map_position);
    label_100D_419E_1426E_27076:
        CheckExternalEvents(cs1, 0x419E);
        // 100D:419E call near 0xB532
        NearCall(cs1, 0x41A1, read_map_byte);
    label_100D_41A1_14271_27078:
        CheckExternalEvents(cs1, 0x41A1);
        // 100D:41A1 and AL,0x30
        AL = Alu8.And(AL, (byte)0x30);
        // 100D:41A3 cmp AL,0x30
        Alu8.Sub(AL, (byte)0x30);
        // 100D:41A5 jb short 0x41C5
        if (CarryFlag)
        {
            return ungrey_skip_to_destination_verb(0x0000);
        }
    label_100D_41A7_14277_37324:
        CheckExternalEvents(cs1, 0x41A7);
        // 100D:41A7 cmp byte ptr DS:[0x4726],0
        Alu8.Sub(UInt8[DS, (ushort)0x4726], (byte)0x00);
        // 100D:41AC jne short 0x41B3
        if (!ZeroFlag)
        {
            goto label_100D_41B3_14283_37329;
        }
    label_100D_41AE_1427E_37327:
        CheckExternalEvents(cs1, 0x41AE);
        // 100D:41AE mov byte ptr DS:[0x0023],4
        UInt8[DS, (ushort)0x0023] = (byte)0x04;
    label_100D_41B3_14283_37329:
        CheckExternalEvents(cs1, 0x41B3);
        // 100D:41B3 mov AL,0x40
        AL = (byte)0x40;
        // 100D:41B5 call near 0x41CC
        NearCall(cs1, 0x41B8, set_skip_to_destination_verb_flags);
    label_100D_41B8_14288_37332:
        CheckExternalEvents(cs1, 0x41B8);
        // 100D:41B8 sub byte ptr DS:[0x4726],0x20
        UInt8[DS, (ushort)0x4726] = Alu8.Sub(UInt8[DS, (ushort)0x4726], (byte)0x20);
        // 100D:41BD jne short 0x4181
        if (!ZeroFlag)
        {
            return unknown_100D_4181_14251(0x0000);
        }
    label_100D_41BF_1428F_42060:
        CheckExternalEvents(cs1, 0x41BF);
        // 100D:41BF mov byte ptr DS:[0x46D9],2
        UInt8[DS, (ushort)0x46D9] = (byte)0x02;
        // 100D:41C4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ungrey_skip_to_destination_verb(int loadOffset)
    {
    label_100D_41C5_14295_21603:
        CheckExternalEvents(cs1, 0x41C5);
        // 100D:41C5 mov byte ptr DS:[0x4726],0
        UInt8[DS, (ushort)0x4726] = (byte)0x00;
        // 100D:41CA xor AL,AL
        AL = Alu8.Xor(AL, AL);
        return set_skip_to_destination_verb_flags(0x0000);
    }

    public virtual Action set_skip_to_destination_verb_flags(int loadOffset)
    {
    label_100D_41CC_1429C_21606:
        CheckExternalEvents(cs1, 0x41CC);
        // 100D:41CC mov byte ptr DS:[0x21FD],AL
        UInt8[DS, (ushort)0x21FD] = AL;
        // 100D:41CF cmp word ptr DS:[0x1F12],0x4FFB
        Alu16.Sub(UInt16[DS, (ushort)0x1F12], (ushort)0x4FFB);
        // 100D:41D5 jne short 0x41DA
        if (!ZeroFlag)
        {
            goto label_100D_41DA_142AA_21609;
        }
    label_100D_41D7_142A7_22101:
        CheckExternalEvents(cs1, 0x41D7);
        // 100D:41D7 mov byte ptr DS:[0x1F11],AL
        UInt8[DS, (ushort)0x1F11] = AL;
    label_100D_41DA_142AA_21609:
        CheckExternalEvents(cs1, 0x41DA);
        // 100D:41DA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action travel_flyover_detect(int loadOffset)
    {
        goto label_100D_41E1_142B1_22265;

    label_100D_41DB_142AB_22517:
        CheckExternalEvents(cs1, 0x41DB);
        // 100D:41DB dec byte ptr DS:[0x196C]
        UInt8[DS, (ushort)0x196C] = Alu8.Dec(UInt8[DS, (ushort)0x196C]);
        // 100D:41DF clc
        CarryFlag = false;
        // 100D:41E0 ret near
        return NearRet((ushort)0x0000);
    label_100D_41E1_142B1_22265:
        CheckExternalEvents(cs1, 0x41E1);
        // 100D:41E1 cmp byte ptr DS:[0x196C],0
        Alu8.Sub(UInt8[DS, (ushort)0x196C], (byte)0x00);
        // 100D:41E6 jne short 0x41DB
        if (!ZeroFlag)
        {
            goto label_100D_41DB_142AB_22517;
        }
    label_100D_41E8_142B8_22268:
        CheckExternalEvents(cs1, 0x41E8);
        // 100D:41E8 mov AL,byte ptr DS:[0x11C7]
        AL = UInt8[DS, (ushort)0x11C7];
        // 100D:41EB add AL,0x20
        AL = Alu8.Add(AL, (byte)0x20);
        // 100D:41ED test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:41EF mov CX,1
        CX = (ushort)0x0001;
        // 100D:41F2 mov AX,8
        AX = (ushort)0x0008;
        // 100D:41F5 je short 0x41F8
        if (ZeroFlag)
        {
            goto label_100D_41F8_142C8_22275;
        }
    label_100D_41F7_142C7_22430:
        CheckExternalEvents(cs1, 0x41F7);
        // 100D:41F7 xchg CX,AX
        ushort temp_100D_41F7_142C7 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_41F7_142C7);
    label_100D_41F8_142C8_22275:
        CheckExternalEvents(cs1, 0x41F8);
        // 100D:41F8 call near 0xB56C
        NearCall(cs1, 0x41FB, map_build_cell_strip);
    label_100D_41FB_142CB_22325:
        CheckExternalEvents(cs1, 0x41FB);
        // 100D:41FB mov CX,8
        CX = (ushort)0x0008;
    label_100D_41FE_142CE_22327:
        CheckExternalEvents(cs1, 0x41FE);
        // 100D:41FE lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:41FF test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:4201 jne short 0x420A
        if (!ZeroFlag)
        {
            goto label_100D_420A_142DA_22449;
        }
    label_100D_4203_142D3_22330:
        CheckExternalEvents(cs1, 0x4203);
        // 100D:4203 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:4206 loop 0x41FE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_41FE_142CE_22327;
        }
    label_100D_4208_142D8_22334:
        CheckExternalEvents(cs1, 0x4208);
        // 100D:4208 clc
        CarryFlag = false;
        // 100D:4209 ret near
        return NearRet((ushort)0x0000);
    label_100D_420A_142DA_22449:
        CheckExternalEvents(cs1, 0x420A);
        // 100D:420A mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:420C push CX
        Stack.Push16(CX);
        // 100D:420D push SI
        Stack.Push16(SI);
        // 100D:420E call near 0x409A
        NearCall(cs1, 0x4211, find_location_by_map_offset);
    label_100D_4211_142E1_22455:
        CheckExternalEvents(cs1, 0x4211);
        // 100D:4211 jne short 0x4257
        if (!ZeroFlag)
        {
            goto label_100D_4257_14327_30866;
        }
    label_100D_4213_142E3_22457:
        CheckExternalEvents(cs1, 0x4213);
        // 100D:4213 test byte ptr DS:[SI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)10)], (byte)0x80);
        // 100D:4217 je short 0x4221
        if (ZeroFlag)
        {
            goto label_100D_4221_142F1_22460;
        }
    label_100D_4219_142E9_27082:
        CheckExternalEvents(cs1, 0x4219);
        // 100D:4219 mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:421C cmp AL,byte ptr DS:[SI+0x0B]
        Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)11)]);
        // 100D:421F jb short 0x4257
        if (CarryFlag)
        {
            goto label_100D_4257_14327_30866;
        }
    label_100D_4221_142F1_22460:
        CheckExternalEvents(cs1, 0x4221);
        // 100D:4221 mov DI,SI
        DI = SI;
        // 100D:4223 call near 0x5124
        NearCall(cs1, 0x4226, compass_angle_to_location);
    label_100D_4226_142F6_22463:
        CheckExternalEvents(cs1, 0x4226);
        // 100D:4226 jb short 0x4257
        if (CarryFlag)
        {
            goto label_100D_4257_14327_30866;
        }
    label_100D_4228_142F8_22465:
        CheckExternalEvents(cs1, 0x4228);
        // 100D:4228 sub AL,byte ptr DS:[0x11C7]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0x11C7]);
        // 100D:422C add AL,0x20
        AL = Alu8.Add(AL, (byte)0x20);
        // 100D:422E cmp AL,0x40
        Alu8.Sub(AL, (byte)0x40);
        // 100D:4230 jae short 0x4257
        if (!CarryFlag)
        {
            goto label_100D_4257_14327_30866;
        }
    label_100D_4232_14302_22470:
        CheckExternalEvents(cs1, 0x4232);
        // 100D:4232 sub AL,0x20
        AL = Alu8.Sub(AL, (byte)0x20);
        // 100D:4234 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:4235 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:4237 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:4239 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:423B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:423D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:423F mov word ptr DS:[0x1968],AX
        UInt16[DS, (ushort)0x1968] = AX;
        // 100D:4242 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:4244 call near 0x5E4F
        NearCall(cs1, 0x4247, calc_sal_index);
    label_100D_4247_14317_22481:
        CheckExternalEvents(cs1, 0x4247);
        // 100D:4247 mov BX,0x196D
        BX = (ushort)0x196D;
        // 100D:424A xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:424B mov word ptr DS:[0x196A],AX
        UInt16[DS, (ushort)0x196A] = AX;
        // 100D:424E pop SI
        SI = Stack.Pop16();
        // 100D:424F pop CX
        CX = Stack.Pop16();
        // 100D:4250 mov byte ptr DS:[0x196C],6
        UInt8[DS, (ushort)0x196C] = (byte)0x06;
        // 100D:4255 stc
        CarryFlag = true;
        // 100D:4256 ret near
        return NearRet((ushort)0x0000);
    label_100D_4257_14327_30866:
        CheckExternalEvents(cs1, 0x4257);
        // 100D:4257 pop SI
        SI = Stack.Pop16();
        // 100D:4258 pop CX
        CX = Stack.Pop16();
        // 100D:4259 jmp short 0x4203
        goto label_100D_4203_142D3_22330;
    }

    public virtual Action location_mark_discovered(int loadOffset)
    {
    entrydispatcher:
    label_100D_425B_1432B_22603:
        CheckExternalEvents(cs1, 0x425B);
        // 100D:425B test byte ptr DS:[DI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x80);
        // 100D:425F je short 0x4284
        if (ZeroFlag)
        {
            goto label_100D_4284_14354_22606;
        }
    label_100D_4261_14331_27114:
        CheckExternalEvents(cs1, 0x4261);
        // 100D:4261 and byte ptr DS:[DI+0x0A],0x7F
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x7F);
        // 100D:4265 mov byte ptr DS:[DI+0x0B],0
        UInt8[DS, (ushort)(DI + (sbyte)11)] = (byte)0x00;
        // 100D:4269 cmp byte ptr DS:[DI+8],0x20
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x20);
        // 100D:426D jae short 0x4284
        if (!CarryFlag)
        {
            goto label_100D_4284_14354_22606;
        }
    label_100D_426F_1433F_27119:
        CheckExternalEvents(cs1, 0x426F);
        // 100D:426F inc byte ptr DS:[0x0027]
        UInt8[DS, (ushort)0x0027] = Alu8.Inc(UInt8[DS, (ushort)0x0027]);
        // 100D:4273 cmp word ptr DS:[DI],0x0603
        Alu16.Sub(UInt16[DS, DI], (ushort)0x0603);
        // 100D:4277 jne short 0x4284
        if (!ZeroFlag)
        {
            goto label_100D_4284_14354_22606;
        }
    label_100D_4279_14349_30901:
        CheckExternalEvents(cs1, 0x4279);
        // 100D:4279 call near 0xE270
        NearCall(cs1, 0x427C, unknown_100D_E270_1E340);
    label_100D_427C_1434C_30903:
        CheckExternalEvents(cs1, 0x427C);
        // 100D:427C mov AL,0x10
        AL = (byte)0x10;
        // 100D:427E call near 0x121F
        NearCall(cs1, 0x4281, set_game_phase_and_trigger_callbacks);
    label_100D_4281_14351_30936:
        CheckExternalEvents(cs1, 0x4281);
        // 100D:4281 call near 0xE283
        NearCall(cs1, 0x4284, unknown_100D_E283_1E353);
    label_100D_4284_14354_22606:
        CheckExternalEvents(cs1, 0x4284);
        // 100D:4284 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_4285_14355(int loadOffset)
    {
    label_100D_4285_14355_35088:
        CheckExternalEvents(cs1, 0x4285);
        // 100D:4285 mov DI,0x015F
        DI = (ushort)0x015F;
        // 100D:4288 cmp word ptr CS:[DI+2],0
        Alu16.Sub(UInt16[CS, (ushort)(DI + (sbyte)2)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:428D jne short 0x42AA
        if (!ZeroFlag)
        {
            goto label_100D_42AA_1437A_35105;
        }
    label_100D_428F_1435F_35092:
        CheckExternalEvents(cs1, 0x428F);
        // 100D:428F push CS
        Stack.Push16(CS);
        // 100D:4290 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:4291 mov SI,0x00BE
        SI = (ushort)0x00BE;
        // 100D:4294 call near 0xF0B9
        NearCall(cs1, 0x4297, bank_filename);
    label_100D_4297_14367_35097:
        CheckExternalEvents(cs1, 0x4297);
        // 100D:4297 mov SI,0x015F
        SI = (ushort)0x015F;
        // 100D:429A mov DI,0xAA66
        DI = (ushort)0xAA66;
        // 100D:429D push DS
        Stack.Push16(DS);
        // 100D:429E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:429F mov CX,4
        CX = (ushort)0x0004;
        // 100D:42A2 rep movs word ptr ES:[DI],word ptr CS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[CS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:42A5 add word ptr CS:[SI],0x0167
        UInt16[CS, SI] = Alu16.Add(UInt16[CS, SI], (ushort)0x0167);
    label_100D_42AA_1437A_35105:
        CheckExternalEvents(cs1, 0x42AA);
        // 100D:42AA mov word ptr DS:[0x487E],1
        UInt16[DS, (ushort)0x487E] = (ushort)0x0001;
        // 100D:42B0 mov byte ptr DS:[0x473E],0
        UInt8[DS, (ushort)0x473E] = (byte)0x00;
        // 100D:42B5 mov byte ptr DS:[0x11C9],8
        UInt8[DS, (ushort)0x11C9] = (byte)0x08;
        // 100D:42BA mov SI,word ptr CS:[0x0167]
        SI = UInt16[CS, (ushort)0x0167];
        // 100D:42BF add SI,word ptr CS:[SI]
        SI = Alu16.Add(SI, UInt16[CS, SI]);
        // 100D:42C2 mov word ptr DS:[0xAA6E],SI
        UInt16[DS, (ushort)0xAA6E] = SI;
        // 100D:42C6 mov AX,0x0039
        AX = (ushort)0x0039;
        // 100D:42C9 call near 0xC13E
        NearCall(cs1, 0x42CC, open_sprite_bank);
    label_100D_42CC_1439C_35113:
        CheckExternalEvents(cs1, 0x42CC);
        // 100D:42CC call far dword ptr DS:[0x3935]
        ushort targetSegment_35113 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_35113 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_35113 == cs2 && targetOffset_35113 == 0x0160)
        {
            FarCall(cs1, 0x42D0, cs2, unknown_3358_0160_336E0);
            goto label_100D_42D0_143A0_35115;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_35113:X4}:{targetOffset_35113:X4} at 100D:42CC");
    label_100D_42D0_143A0_35115:
        CheckExternalEvents(cs1, 0x42D0);
        // 100D:42D0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_view_redraw(int loadOffset)
    {
    entrydispatcher:
    label_100D_4377_14447_28219:
        CheckExternalEvents(cs1, 0x4377);
        // 100D:4377 call near 0xC07C
        NearCall(cs1, 0x437A, set_fb1_as_active_framebuffer);
    label_100D_437A_1444A_28221:
        CheckExternalEvents(cs1, 0x437A);
        // 100D:437A call near 0x5B93
        NearCall(cs1, 0x437D, map_view_clip_rect);
    label_100D_437D_1444D_28223:
        CheckExternalEvents(cs1, 0x437D);
        // 100D:437D call near 0xB6C3
        NearCall(cs1, 0x4380, map_draw_zoomed_globe);
    label_100D_4380_14450_28225:
        CheckExternalEvents(cs1, 0x4380);
        // 100D:4380 call near 0xC137
        NearCall(cs1, 0x4383, open_icones_spritesheet);
    label_100D_4383_14453_28227:
        CheckExternalEvents(cs1, 0x4383);
        // 100D:4383 call near 0x5DCE
        NearCall(cs1, 0x4386, map_build_and_draw_location_markers);
    label_100D_4386_14456_28229:
        CheckExternalEvents(cs1, 0x4386);
        // 100D:4386 cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:438B je short 0x4399
        if (ZeroFlag)
        {
            goto label_100D_4399_14469_28238;
        }
    label_100D_438D_1445D_28232:
        CheckExternalEvents(cs1, 0x438D);
        // 100D:438D mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:4390 call near 0xC13E
        NearCall(cs1, 0x4393, open_sprite_bank);
    label_100D_4393_14463_28235:
        CheckExternalEvents(cs1, 0x4393);
        // 100D:4393 mov SI,0x14C0
        SI = (ushort)0x14C0;
        // 100D:4396 call near 0xC21B
        NearCall(cs1, 0x4399, draw_icons_list_at_si);
    label_100D_4399_14469_28238:
        CheckExternalEvents(cs1, 0x4399);
        // 100D:4399 call near 0xC4ED
        NearCall(cs1, 0x439C, unknown_100D_C4ED_1C5BD);
    label_100D_439C_1446C_28240:
        CheckExternalEvents(cs1, 0x439C);
        // 100D:439C jmp near 0x445D
        if (JumpDispatcher.Jump(map_arm_player_marker_task, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_screen_draw_base(int loadOffset)
    {
    label_100D_439F_1446F_20713:
        CheckExternalEvents(cs1, 0x439F);
        // 100D:439F call near 0xC07C
        NearCall(cs1, 0x43A2, set_fb1_as_active_framebuffer);
    label_100D_43A2_14472_20715:
        CheckExternalEvents(cs1, 0x43A2);
        // 100D:43A2 cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:43A7 jne short 0x43CC
        if (!ZeroFlag)
        {
            goto label_100D_43CC_1449C_20718;
        }
    label_100D_43A9_14479_35120:
        CheckExternalEvents(cs1, 0x43A9);
        // 100D:43A9 mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:43AC call near 0xC13E
        NearCall(cs1, 0x43AF, open_sprite_bank);
    label_100D_43AF_1447F_35123:
        CheckExternalEvents(cs1, 0x43AF);
        // 100D:43AF call near 0xC49A
        NearCall(cs1, 0x43B2, unknown_100D_C49A_1C56A);
    label_100D_43B2_14482_35125:
        CheckExternalEvents(cs1, 0x43B2);
        // 100D:43B2 call near 0xC412
        NearCall(cs1, 0x43B5, copy_active_framebuffer_to_framebuffer_2);
    label_100D_43B5_14485_35127:
        CheckExternalEvents(cs1, 0x43B5);
        // 100D:43B5 call far dword ptr DS:[0x3935]
        ushort targetSegment_35127 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_35127 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_35127 == cs2 && targetOffset_35127 == 0x0160)
        {
            FarCall(cs1, 0x43B9, cs2, unknown_3358_0160_336E0);
            goto label_100D_43B9_14489_35129;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_35127:X4}:{targetOffset_35127:X4} at 100D:43B5");
    label_100D_43B9_14489_35129:
        CheckExternalEvents(cs1, 0x43B9);
        // 100D:43B9 call near 0x5B69
        NearCall(cs1, 0x43BC, draw_map_view_border);
    label_100D_43BC_1448C_35131:
        CheckExternalEvents(cs1, 0x43BC);
        // 100D:43BC mov SI,0x14A4
        SI = (ushort)0x14A4;
        // 100D:43BF mov AL,0xF5
        AL = (byte)0xF5;
        // 100D:43C1 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:43C5 call far dword ptr DS:[0x38DD]
        ushort targetSegment_35135 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_35135 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_35135 == cs2 && targetOffset_35135 == 0x011E)
        {
            FarCall(cs1, 0x43C9, cs2, unknown_3358_011E_3369E);
            goto label_100D_43C9_14499_35136;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_35135:X4}:{targetOffset_35135:X4} at 100D:43C5");
    label_100D_43C9_14499_35136:
        CheckExternalEvents(cs1, 0x43C9);
        // 100D:43C9 jmp near 0xC4DD
        return present_game_area(0x0000);
    label_100D_43CC_1449C_20718:
        CheckExternalEvents(cs1, 0x43CC);
        // 100D:43CC cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:43D1 jne short 0x43D6
        if (!ZeroFlag)
        {
            goto label_100D_43D6_144A6_20723;
        }
    label_100D_43D3_144A3_20721:
        CheckExternalEvents(cs1, 0x43D3);
        // 100D:43D3 call near 0x38B4
        NearCall(cs1, 0x43D6, draw_sky);
    label_100D_43D6_144A6_20723:
        CheckExternalEvents(cs1, 0x43D6);
        // 100D:43D6 mov AX,0x0024
        AX = (ushort)0x0024;
        // 100D:43D9 call near 0xC13E
        NearCall(cs1, 0x43DC, open_sprite_bank);
    label_100D_43DC_144AC_20726:
        CheckExternalEvents(cs1, 0x43DC);
        // 100D:43DC mov SI,0x14B4
        SI = (ushort)0x14B4;
        // 100D:43DF call near 0xC21B
        NearCall(cs1, 0x43E2, draw_icons_list_at_si);
    label_100D_43E2_144B2_20729:
        CheckExternalEvents(cs1, 0x43E2);
        // 100D:43E2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_screen_restore_room_view(int loadOffset)
    {
    label_100D_43E3_144B3_21550:
        CheckExternalEvents(cs1, 0x43E3);
        // 100D:43E3 cmp byte ptr DS:[0x473E],0
        Alu8.Sub(UInt8[DS, (ushort)0x473E], (byte)0x00);
        // 100D:43E8 jne short 0x43FC
        if (!ZeroFlag)
        {
            goto label_100D_43FC_144CC_21553;
        }
    label_100D_43EA_144BA_35143:
        CheckExternalEvents(cs1, 0x43EA);
        // 100D:43EA cmp word ptr DS:[0xDBEA],0
        Alu16.Sub(UInt16[DS, (ushort)0xDBEA], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:43EF jne short 0x440F
        if (!ZeroFlag)
        {
            goto label_100D_440F_144DF_28259;
        }
    label_100D_43F1_144C1_35146:
        CheckExternalEvents(cs1, 0x43F1);
        // 100D:43F1 mov SI,0x14AC
        SI = (ushort)0x14AC;
        // 100D:43F4 push SI
        Stack.Push16(SI);
        // 100D:43F5 call near 0xC446
        NearCall(cs1, 0x43F8, unknown_100D_C446_1C516);
    label_100D_43F8_144C8_35150:
        CheckExternalEvents(cs1, 0x43F8);
        // 100D:43F8 pop SI
        SI = Stack.Pop16();
        // 100D:43F9 jmp near 0xC4F0
        return present_screen_rect(0x0000);
    label_100D_43FC_144CC_21553:
        CheckExternalEvents(cs1, 0x43FC);
        // 100D:43FC cmp byte ptr DS:[6],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x0006], (byte)0x80);
        // 100D:4401 jne short 0x440F
        if (!ZeroFlag)
        {
            goto label_100D_440F_144DF_28259;
        }
    label_100D_4403_144D3_21556:
        CheckExternalEvents(cs1, 0x4403);
        // 100D:4403 call near 0x388D
        NearCall(cs1, 0x4406, set_sky_palette);
    label_100D_4406_144D6_21558:
        CheckExternalEvents(cs1, 0x4406);
        // 100D:4406 call near 0xC43E
        NearCall(cs1, 0x4409, copy_game_area_fb2_to_fb1);
    label_100D_4409_144D9_21560:
        CheckExternalEvents(cs1, 0x4409);
        // 100D:4409 call near 0xC4DD
        NearCall(cs1, 0x440C, present_game_area);
    label_100D_440C_144DC_21564:
        CheckExternalEvents(cs1, 0x440C);
        // 100D:440C jmp near 0xC0F4
        return update_screen_palette(0x0000);
    label_100D_440F_144DF_28259:
        CheckExternalEvents(cs1, 0x440F);
        // 100D:440F call near 0x4ABE
        NearCall(cs1, 0x4412, travel_resume_flight_view);
    label_100D_4412_144E2_28261:
        CheckExternalEvents(cs1, 0x4412);
        // 100D:4412 jmp near 0xC0F4
        return update_screen_palette(0x0000);
    }

    public virtual Action map_screen_cleanup(int loadOffset)
    {
    label_100D_4415_144E5_21533:
        CheckExternalEvents(cs1, 0x4415);
        // 100D:4415 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:4417 xchg AL,byte ptr DS:[0x46EB]
        ushort xchgOffset_100D_4417_144E7 = (ushort)0x46EB;
        byte temp_100D_4417_144E7 = AL;
        AL = UInt8[DS, xchgOffset_100D_4417_144E7];
        UInt8[DS, xchgOffset_100D_4417_144E7] = unchecked((byte)temp_100D_4417_144E7);
        // 100D:441B or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:441D jne short 0x4420
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:441D");
        }
    label_100D_4420_144F0_21538:
        CheckExternalEvents(cs1, 0x4420);
        // 100D:4420 mov word ptr DS:[0xA5C0],0
        UInt16[DS, (ushort)0xA5C0] = (ushort)0x0000;
        // 100D:4426 call near 0xDAA3
        NearCall(cs1, 0x4429, clear_mouse_nav_rect);
    label_100D_4429_144F9_21541:
        CheckExternalEvents(cs1, 0x4429);
        // 100D:4429 mov SI,0x44AB
        SI = (ushort)0x44AB;
        // 100D:442C call near 0xDA5F
        NearCall(cs1, 0x442F, remove_frame_task);
    label_100D_442F_144FF_21544:
        CheckExternalEvents(cs1, 0x442F);
        // 100D:442F call near 0x469B
        NearCall(cs1, 0x4432, map_remove_select_destination_text_task);
    label_100D_4432_14502_21546:
        CheckExternalEvents(cs1, 0x4432);
        // 100D:4432 call near 0x5BA0
        NearCall(cs1, 0x4435, copy_game_area_rect_to_unknown_rect);
    label_100D_4435_14505_21548:
        CheckExternalEvents(cs1, 0x4435);
        // 100D:4435 call near 0x43E3
        NearCall(cs1, 0x4438, map_screen_restore_room_view);
    label_100D_4438_14508_21566:
        CheckExternalEvents(cs1, 0x4438);
        // 100D:4438 call near 0xC0F4
        NearCall(cs1, 0x443B, update_screen_palette);
    label_100D_443B_1450B_21568:
        CheckExternalEvents(cs1, 0x443B);
        // 100D:443B cmp word ptr DS:[0x11C5],0
        Alu16.Sub(UInt16[DS, (ushort)0x11C5], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:4440 jne short 0x4447
        if (!ZeroFlag)
        {
            goto label_100D_4447_14517_21571;
        }
    label_100D_4442_14512_25666:
        CheckExternalEvents(cs1, 0x4442);
        // 100D:4442 mov byte ptr DS:[0x11C9],0
        UInt8[DS, (ushort)0x11C9] = (byte)0x00;
    label_100D_4447_14517_21571:
        CheckExternalEvents(cs1, 0x4447);
        // 100D:4447 call near 0xD95B
        NearCall(cs1, 0x444A, select_room_ui_table);
    label_100D_444A_1451A_21573:
        CheckExternalEvents(cs1, 0x444A);
        // 100D:444A call near 0xD717
        NearCall(cs1, 0x444D, ui_setup_and_draw_nav_panel);
    label_100D_444D_1451D_21577:
        CheckExternalEvents(cs1, 0x444D);
        // 100D:444D call near 0x2FFB
        NearCall(cs1, 0x4450, rebuild_and_draw_room_nav_panel);
    label_100D_4450_14520_21585:
        CheckExternalEvents(cs1, 0x4450);
        // 100D:4450 cmp byte ptr DS:[0x4728],0
        Alu8.Sub(UInt8[DS, (ushort)0x4728], (byte)0x00);
        // 100D:4455 jle short 0x445A
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:4455");
        }
    label_100D_445A_1452A_21588:
        CheckExternalEvents(cs1, 0x445A);
        // 100D:445A jmp near 0x4AC4
        return unknown_100D_4AC4_14B94(0x0000);
    }

    public virtual Action map_arm_player_marker_task(int loadOffset)
    {
    entrydispatcher:
    label_100D_445D_1452D_20990:
        CheckExternalEvents(cs1, 0x445D);
        // 100D:445D mov SI,0x44AB
        SI = (ushort)0x44AB;
        // 100D:4460 call near 0xDA5F
        NearCall(cs1, 0x4463, remove_frame_task);
    label_100D_4463_14533_20993:
        CheckExternalEvents(cs1, 0x4463);
        // 100D:4463 call near 0x407E
        NearCall(cs1, 0x4466, get_map_position);
    label_100D_4466_14536_20995:
        CheckExternalEvents(cs1, 0x4466);
        // 100D:4466 call near 0x62D6
        NearCall(cs1, 0x4469, map_position_to_screen_if_visible);
    label_100D_4469_14539_20997:
        CheckExternalEvents(cs1, 0x4469);
        // 100D:4469 jae short 0x4472
        if (!CarryFlag)
        {
            goto label_100D_4472_14542_20999;
        }
    label_100D_446B_1453B_33486:
        CheckExternalEvents(cs1, 0x446B);
        // 100D:446B mov word ptr DS:[0x4749],0
        UInt16[DS, (ushort)0x4749] = (ushort)0x0000;
        // 100D:4471 ret near
        return NearRet((ushort)0x0000);
    label_100D_4472_14542_20999:
        CheckExternalEvents(cs1, 0x4472);
        // 100D:4472 call near 0xC137
        NearCall(cs1, 0x4475, open_icones_spritesheet);
    label_100D_4475_14545_21001:
        CheckExternalEvents(cs1, 0x4475);
        // 100D:4475 mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:4478 call near 0xC1F4
        NearCall(cs1, 0x447B, unknown_100D_C1F4_1C2C4);
    label_100D_447B_1454B_21004:
        CheckExternalEvents(cs1, 0x447B);
        // 100D:447B lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:447D and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:4480 mov BP,AX
        BP = AX;
        // 100D:4482 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:4484 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4486 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:4488 sub DX,0x000D
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:448B add BP,DX
        BP = Alu16.Add(BP, DX);
        // 100D:448D add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:448F mov DI,0x4749
        DI = (ushort)0x4749;
        // 100D:4492 mov word ptr DS:[DI],DX
        UInt16[DS, DI] = DX;
        // 100D:4494 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:4497 mov word ptr DS:[DI+4],BP
        UInt16[DS, (ushort)(DI + (sbyte)4)] = BP;
        // 100D:449A mov word ptr DS:[DI+6],AX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = AX;
        // 100D:449D mov SI,0x44AB
        SI = (ushort)0x44AB;
        // 100D:44A0 mov BP,0x012C
        BP = (ushort)0x012C;
        // 100D:44A3 call near 0xDA25
        NearCall(cs1, 0x44A6, add_frame_task);
    label_100D_44A6_14576_21022:
        CheckExternalEvents(cs1, 0x44A6);
        // 100D:44A6 mov byte ptr DS:[0x4751],0
        UInt8[DS, (ushort)0x4751] = (byte)0x00;
        if (JumpDispatcher.Jump(tick_map_player_marker, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action tick_map_player_marker(int loadOffset)
    {
    entrydispatcher:
    label_100D_44AB_1457B_21024:
        CheckExternalEvents(cs1, 0x44AB);
        // 100D:44AB inc byte ptr DS:[0x4751]
        UInt8[DS, (ushort)0x4751] = Alu8.Inc(UInt8[DS, (ushort)0x4751]);
        // 100D:44AF push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:44B3 call near 0xC08E
        NearCall(cs1, 0x44B6, set_screen_as_active_framebuffer);
    label_100D_44B6_14586_21027:
        CheckExternalEvents(cs1, 0x44B6);
        // 100D:44B6 call near 0x5B93
        NearCall(cs1, 0x44B9, map_view_clip_rect);
    label_100D_44B9_14589_21029:
        CheckExternalEvents(cs1, 0x44B9);
        // 100D:44B9 call near 0xC137
        NearCall(cs1, 0x44BC, open_icones_spritesheet);
    label_100D_44BC_1458C_21031:
        CheckExternalEvents(cs1, 0x44BC);
        // 100D:44BC mov SI,0x4749
        SI = (ushort)0x4749;
        // 100D:44BF call near 0xDB74
        NearCall(cs1, 0x44C2, restore_mouse_if_rect_intersects);
    label_100D_44C2_14592_21034:
        CheckExternalEvents(cs1, 0x44C2);
        // 100D:44C2 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:44C4 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:44C7 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:44CA mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:44CD mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:44D0 cmp BP,word ptr DS:[SI+4]
        Alu16.Sub(BP, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:44D3 jb short 0x44D8
        if (CarryFlag)
        {
            goto label_100D_44D8_145A8_21042;
        }
    label_100D_44D5_145A5_33775:
        CheckExternalEvents(cs1, 0x44D5);
        // 100D:44D5 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
    label_100D_44D8_145A8_21042:
        CheckExternalEvents(cs1, 0x44D8);
        // 100D:44D8 cmp AX,word ptr DS:[SI+6]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:44DB jb short 0x44E0
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:44DB");
        }
    label_100D_44E0_145B0_21045:
        CheckExternalEvents(cs1, 0x44E0);
        // 100D:44E0 cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 100D:44E2 jae short 0x44E6
        if (!CarryFlag)
        {
            goto label_100D_44E6_145B6_21048;
        }
    label_100D_44E4_145B4_33658:
        CheckExternalEvents(cs1, 0x44E4);
        // 100D:44E4 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
    label_100D_44E6_145B6_21048:
        CheckExternalEvents(cs1, 0x44E6);
        // 100D:44E6 cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:44E9 jae short 0x44EE
        if (!CarryFlag)
        {
            goto label_100D_44EE_145BE_21051;
        }
    label_100D_44EB_145BB_36732:
        CheckExternalEvents(cs1, 0x44EB);
        // 100D:44EB mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
    label_100D_44EE_145BE_21051:
        CheckExternalEvents(cs1, 0x44EE);
        // 100D:44EE call near 0xC4FB
        NearCall(cs1, 0x44F1, unknown_100D_C4FB_1C5CB);
    label_100D_44F1_145C1_21054:
        CheckExternalEvents(cs1, 0x44F1);
        // 100D:44F1 mov BL,byte ptr DS:[0x4751]
        BL = UInt8[DS, (ushort)0x4751];
        // 100D:44F5 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 100D:44F7 jae short 0x4507
        if (!CarryFlag)
        {
            goto label_100D_4507_145D7_21063;
        }
    label_100D_44F9_145C9_21058:
        CheckExternalEvents(cs1, 0x44F9);
        // 100D:44F9 mov AX,0x004C
        AX = (ushort)0x004C;
        // 100D:44FC mov DX,word ptr DS:[0x4749]
        DX = UInt16[DS, (ushort)0x4749];
        // 100D:4500 mov BX,word ptr DS:[0x474B]
        BX = UInt16[DS, (ushort)0x474B];
        // 100D:4504 call near 0xC30D
        NearCall(cs1, 0x4507, unknown_100D_C30D_1C3DD);
    label_100D_4507_145D7_21063:
        CheckExternalEvents(cs1, 0x4507);
        // 100D:4507 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_4507_145D7 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_4507_145D7 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_4507_145D7 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_4507_145D7);
        // 100D:450B jmp near 0xDB67
        if (JumpDispatcher.Jump(draw_mouse_cursor_if_needed, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_mouse_lmb_select_destination(int loadOffset)
    {
    entrydispatcher:
    label_100D_450E_145DE_21362:
        CheckExternalEvents(cs1, 0x450E);
        // 100D:450E test byte ptr DS:[0x11C9],0x0F
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x0F);
        // 100D:4513 je short 0x4533
        if (ZeroFlag)
        {
            goto label_100D_4533_14603_35448;
        }
    label_100D_4515_145E5_21365:
        CheckExternalEvents(cs1, 0x4515);
        // 100D:4515 push BX
        Stack.Push16(BX);
        // 100D:4516 push DX
        Stack.Push16(DX);
        // 100D:4517 call near 0x4586
        NearCall(cs1, 0x451A, map_mouse_hover_tracker);
    label_100D_451A_145EA_21369:
        CheckExternalEvents(cs1, 0x451A);
        // 100D:451A pop DX
        DX = Stack.Pop16();
        // 100D:451B pop BX
        BX = Stack.Pop16();
        // 100D:451C mov DI,word ptr DS:[0x46FC]
        DI = UInt16[DS, (ushort)0x46FC];
        // 100D:4520 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:4522 je short 0x4533
        if (ZeroFlag)
        {
            goto label_100D_4533_14603_35448;
        }
    label_100D_4524_145F4_21375:
        CheckExternalEvents(cs1, 0x4524);
        // 100D:4524 js short 0x4534
        if (SignFlag)
        {
            goto label_100D_4534_14604_21383;
        }
    label_100D_4526_145F6_21377:
        CheckExternalEvents(cs1, 0x4526);
        // 100D:4526 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:452B jne short 0x4534
        if (!ZeroFlag)
        {
            goto label_100D_4534_14604_21383;
        }
    label_100D_452D_145FD_21380:
        CheckExternalEvents(cs1, 0x452D);
        // 100D:452D cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:4531 jne short 0x4534
        if (!ZeroFlag)
        {
            goto label_100D_4534_14604_21383;
        }
    label_100D_4533_14603_35448:
        CheckExternalEvents(cs1, 0x4533);
        // 100D:4533 ret near
        return NearRet((ushort)0x0000);
    label_100D_4534_14604_21383:
        CheckExternalEvents(cs1, 0x4534);
        // 100D:4534 push BX
        Stack.Push16(BX);
        // 100D:4535 push DX
        Stack.Push16(DX);
        // 100D:4536 push DI
        Stack.Push16(DI);
        // 100D:4537 call near 0x456C
        NearCall(cs1, 0x453A, map_hover_narration_clip);
    label_100D_453A_1460A_21403:
        CheckExternalEvents(cs1, 0x453A);
        // 100D:453A call near 0xAB45
        NearCall(cs1, 0x453D, duck_music_and_start_narration_voice_clip);
    label_100D_453D_1460D_21414:
        CheckExternalEvents(cs1, 0x453D);
        // 100D:453D pop DI
        DI = Stack.Pop16();
        // 100D:453E mov CX,9
        CX = (ushort)0x0009;
    label_100D_4541_14611_21417:
        CheckExternalEvents(cs1, 0x4541);
        // 100D:4541 push CX
        Stack.Push16(CX);
        // 100D:4542 push DI
        Stack.Push16(DI);
        // 100D:4543 mov AX,0x0014
        AX = (ushort)0x0014;
        // 100D:4546 call near 0xE3A0
        NearCall(cs1, 0x4549, tick_one_frame);
    label_100D_4549_14619_21438:
        CheckExternalEvents(cs1, 0x4549);
        // 100D:4549 push DI
        Stack.Push16(DI);
        // 100D:454A xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:454C call near 0x45DE
        NearCall(cs1, 0x454F, map_draw_hover_label);
    label_100D_454F_1461F_21449:
        CheckExternalEvents(cs1, 0x454F);
        // 100D:454F pop DI
        DI = Stack.Pop16();
        // 100D:4550 mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:4553 call near 0xE3A0
        NearCall(cs1, 0x4556, tick_one_frame);
    label_100D_4556_14626_21454:
        CheckExternalEvents(cs1, 0x4556);
        // 100D:4556 call near 0x45DE
        NearCall(cs1, 0x4559, map_draw_hover_label);
    label_100D_4559_14629_21456:
        CheckExternalEvents(cs1, 0x4559);
        // 100D:4559 pop DI
        DI = Stack.Pop16();
        // 100D:455A pop CX
        CX = Stack.Pop16();
        // 100D:455B loop 0x4541
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_4541_14611_21417;
        }
    label_100D_455D_1462D_21461:
        CheckExternalEvents(cs1, 0x455D);
        // 100D:455D push DI
        Stack.Push16(DI);
        // 100D:455E call near 0xABA9
        NearCall(cs1, 0x4561, wait_for_narration_voice_clip);
    label_100D_4561_14631_21477:
        CheckExternalEvents(cs1, 0x4561);
        // 100D:4561 pop DI
        DI = Stack.Pop16();
        // 100D:4562 pop DX
        DX = Stack.Pop16();
        // 100D:4563 pop BX
        BX = Stack.Pop16();
        // 100D:4564 mov byte ptr DS:[0x4732],0x80
        UInt8[DS, (ushort)0x4732] = (byte)0x80;
        // 100D:4569 jmp near 0x4703
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x4703))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_hover_narration_clip(int loadOffset)
    {
    label_100D_456C_1463C_21388:
        CheckExternalEvents(cs1, 0x456C);
        // 100D:456C mov AX,DI
        AX = DI;
        // 100D:456E cmp AH,0xFF
        Alu8.Sub(AH, (byte)0xFF);
        // 100D:4571 je short 0x4582
        if (ZeroFlag)
        {
            goto label_100D_4582_14652_21401;
        }
    label_100D_4573_14643_21392:
        CheckExternalEvents(cs1, 0x4573);
        // 100D:4573 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:4575 dec AX
        AX = Alu16.Dec(AX);
        // 100D:4576 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:4578 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:457A shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:457C shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:457E or AL,AH
        AL = Alu8.Or(AL, AH);
        // 100D:4580 xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_100D_4582_14652_21401:
        CheckExternalEvents(cs1, 0x4582);
        // 100D:4582 add AX,0x02BC
        AX = Alu16.Add(AX, (ushort)0x02BC);
        // 100D:4585 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_mouse_hover_tracker(int loadOffset)
    {
    entrydispatcher:
    label_100D_4586_14656_21068:
        CheckExternalEvents(cs1, 0x4586);
        // 100D:4586 call near 0x5D1D
        NearCall(cs1, 0x4589, unknown_100D_5D1D_15DED);
    label_100D_4589_14659_21084:
        CheckExternalEvents(cs1, 0x4589);
        // 100D:4589 mov DI,0
        DI = (ushort)0x0000;
        // 100D:458C jae short 0x45D3
        if (!CarryFlag)
        {
            goto label_100D_45D3_146A3_21087;
        }
    label_100D_458E_1465E_21159:
        CheckExternalEvents(cs1, 0x458E);
        // 100D:458E mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:4590 call near 0x5E6D
        NearCall(cs1, 0x4593, find_nearest_location_marker);
    label_100D_4593_14663_21210:
        CheckExternalEvents(cs1, 0x4593);
        // 100D:4593 cmp AX,9
        Alu16.Sub(AX, (ushort)0x0009);
        // 100D:4596 jb short 0x45D3
        if (CarryFlag)
        {
            goto label_100D_45D3_146A3_21087;
        }
    label_100D_4598_14668_21213:
        CheckExternalEvents(cs1, 0x4598);
        // 100D:4598 mov DI,0xFFFF
        DI = (ushort)0xFFFF;
        // 100D:459B mov DX,word ptr DS:[0x4749]
        DX = UInt16[DS, (ushort)0x4749];
        // 100D:459F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:45A1 je short 0x45D3
        if (ZeroFlag)
        {
            goto label_100D_45D3_146A3_21087;
        }
    label_100D_45A3_14673_21218:
        CheckExternalEvents(cs1, 0x45A3);
        // 100D:45A3 add DX,0x000B
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)11)));
        // 100D:45A6 sub DX,word ptr DS:[0xDC36]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0xDC36]);
        // 100D:45AA neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:45AC mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:45B0 sub BX,word ptr DS:[0x474F]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0x474F]);
        // 100D:45B4 call near 0x514E
        NearCall(cs1, 0x45B7, compass_angle_from_delta);
    label_100D_45B7_14687_21228:
        CheckExternalEvents(cs1, 0x45B7);
        // 100D:45B7 add AL,3
        AL = Alu8.Add(AL, (byte)0x03);
        // 100D:45B9 mov AH,AL
        AH = AL;
        // 100D:45BB and AH,0x1F
        AH = Alu8.And(AH, (byte)0x1F);
        // 100D:45BE cmp AH,6
        Alu8.Sub(AH, (byte)0x06);
        // 100D:45C1 mov DI,0xFFFF
        DI = (ushort)0xFFFF;
        // 100D:45C4 jae short 0x45D3
        if (!CarryFlag)
        {
            goto label_100D_45D3_146A3_21087;
        }
    label_100D_45C6_14696_21289:
        CheckExternalEvents(cs1, 0x45C6);
        // 100D:45C6 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:45C8 rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:45CA rol AL,1
        AL = Alu8.Rol(AL, unchecked((byte)1));
        // 100D:45CC and AL,7
        AL = Alu8.And(AL, (byte)0x07);
        // 100D:45CE or AX,0xFFF0
        AX = Alu16.Or(AX, (ushort)0xFFF0);
        // 100D:45D1 mov DI,AX
        DI = AX;
    label_100D_45D3_146A3_21087:
        CheckExternalEvents(cs1, 0x45D3);
        // 100D:45D3 mov AX,DI
        AX = DI;
        // 100D:45D5 xchg AX,word ptr DS:[0x46FC]
        ushort xchgOffset_100D_45D5_146A5 = (ushort)0x46FC;
        ushort temp_100D_45D5_146A5 = AX;
        AX = UInt16[DS, xchgOffset_100D_45D5_146A5];
        UInt16[DS, xchgOffset_100D_45D5_146A5] = unchecked((ushort)temp_100D_45D5_146A5);
        // 100D:45D9 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:45DB jne short 0x45DE
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(map_draw_hover_label, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_45DD_146AD_21092:
        CheckExternalEvents(cs1, 0x45DD);
        // 100D:45DD ret near
        return NearRet((ushort)0x0000);
    }
}
