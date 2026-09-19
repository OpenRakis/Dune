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
    public virtual Action draw_room_game_screen_scene_reload(int loadOffset)
    {
    entrydispatcher:
    label_100D_2DBF_12E8F_13561:
        CheckExternalEvents(cs1, 0x2DBF);
        // 100D:2DBF call near 0x2D74
        NearCall(cs1, 0x2DC2, unknown_100D_2D74_12E44);
    label_100D_2DC2_12E92_13562:
        CheckExternalEvents(cs1, 0x2DC2);
        // 100D:2DC2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2DC4 mov byte ptr DS:[0xDCE6],AL
        UInt8[DS, (ushort)0xDCE6] = AL;
        // 100D:2DC7 mov byte ptr DS:[0x47A4],AL
        UInt8[DS, (ushort)0x47A4] = AL;
        // 100D:2DCA mov word ptr DS:[0x47AA],AX
        UInt16[DS, (ushort)0x47AA] = AX;
        // 100D:2DCD mov BP,0x2EB2
        BP = (ushort)0x2EB2;
        // 100D:2DD0 call near 0xC097
        NearCall(cs1, 0x2DD3, gfx_call_bp_with_front_buffer_as_screen);
        if (JumpDispatcher.Jump(draw_room_scene_and_present, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action draw_room_scene_and_present(int loadOffset)
    {
    entrydispatcher:
    label_100D_2DD3_12EA3_14333:
        CheckExternalEvents(cs1, 0x2DD3);
        // 100D:2DD3 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:2DD8 je short 0x2DFB
        if (ZeroFlag)
        {
            goto label_100D_2DFB_12ECB_14336;
        }
    label_100D_2DDA_12EAA_36231:
        CheckExternalEvents(cs1, 0x2DDA);
        // 100D:2DDA mov byte ptr DS:[0x4732],0
        UInt8[DS, (ushort)0x4732] = (byte)0x00;
        // 100D:2DDF call near 0x2D74
        NearCall(cs1, 0x2DE2, unknown_100D_2D74_12E44);
    label_100D_2DE2_12EB2_36234:
        CheckExternalEvents(cs1, 0x2DE2);
        // 100D:2DE2 or byte ptr DS:[0x11BC],1
        UInt8[DS, (ushort)0x11BC] = Alu8.Or(UInt8[DS, (ushort)0x11BC], (byte)0x01);
        // 100D:2DE7 mov byte ptr DS:[0x46DF],0
        UInt8[DS, (ushort)0x46DF] = (byte)0x00;
        // 100D:2DEC call near 0x0ACD
        NearCall(cs1, 0x2DEF, night_attack_start);
    label_100D_2DEF_12EBF_36238:
        CheckExternalEvents(cs1, 0x2DEF);
        // 100D:2DEF call near 0x1797
        NearCall(cs1, 0x2DF2, ui_hud_head_draw);
    label_100D_2DF2_12EC2_36240:
        CheckExternalEvents(cs1, 0x2DF2);
        // 100D:2DF2 call near 0xC4CD
        NearCall(cs1, 0x2DF5, gfx_copy_whole_framebuf_to_screen);
    label_100D_2DF5_12EC5_36242:
        CheckExternalEvents(cs1, 0x2DF5);
        // 100D:2DF5 call near 0xC0F4
        NearCall(cs1, 0x2DF8, update_screen_palette);
    label_100D_2DF8_12EC8_36244:
        CheckExternalEvents(cs1, 0x2DF8);
        // 100D:2DF8 jmp near 0x17E6
        if (JumpDispatcher.Jump(ui_hud_head_animate_up, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2DFB_12ECB_14336:
        CheckExternalEvents(cs1, 0x2DFB);
        // 100D:2DFB test byte ptr DS:[0x4732],1
        Alu8.And(UInt8[DS, (ushort)0x4732], (byte)0x01);
        // 100D:2E00 je short 0x2E05
        if (ZeroFlag)
        {
            goto label_100D_2E05_12ED5_14339;
        }
    label_100D_2E02_12ED2_22789:
        CheckExternalEvents(cs1, 0x2E02);
        // 100D:2E02 call near 0x488A
        NearCall(cs1, 0x2E05, travel_arrival_landing_sequence);
    label_100D_2E05_12ED5_14339:
        CheckExternalEvents(cs1, 0x2E05);
        // 100D:2E05 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2E07 mov word ptr DS:[0x0014],AX
        UInt16[DS, (ushort)0x0014] = AX;
        // 100D:2E0A mov byte ptr DS:[0x46DF],AL
        UInt8[DS, (ushort)0x46DF] = AL;
        // 100D:2E0D call near 0xC07C
        NearCall(cs1, 0x2E10, set_fb1_as_active_framebuffer);
    label_100D_2E10_12EE0_14344:
        CheckExternalEvents(cs1, 0x2E10);
        // 100D:2E10 call near 0x5BA0
        NearCall(cs1, 0x2E13, copy_game_area_rect_to_unknown_rect);
    label_100D_2E13_12EE3_14346:
        CheckExternalEvents(cs1, 0x2E13);
        // 100D:2E13 call near 0x37B2
        NearCall(cs1, 0x2E16, draw_room_scene);
    label_100D_2E16_12EE6_14348:
        CheckExternalEvents(cs1, 0x2E16);
        // 100D:2E16 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:2E1B jne short 0x2E20
        if (!ZeroFlag)
        {
            goto label_100D_2E20_12EF0_14353;
        }
    label_100D_2E1D_12EED_14351:
        CheckExternalEvents(cs1, 0x2E1D);
        // 100D:2E1D call near 0xC412
        NearCall(cs1, 0x2E20, copy_active_framebuffer_to_framebuffer_2);
    label_100D_2E20_12EF0_14353:
        CheckExternalEvents(cs1, 0x2E20);
        // 100D:2E20 call near 0xAD5E
        NearCall(cs1, 0x2E23, update_room_music);
    label_100D_2E23_12EF3_14444:
        CheckExternalEvents(cs1, 0x2E23);
        // 100D:2E23 call near 0x1834
        NearCall(cs1, 0x2E26, ui_hud_head_save_rect);
    label_100D_2E26_12EF6_14485:
        CheckExternalEvents(cs1, 0x2E26);
        // 100D:2E26 call near 0x1797
        NearCall(cs1, 0x2E29, ui_hud_head_draw);
    label_100D_2E29_12EF9_14487:
        CheckExternalEvents(cs1, 0x2E29);
        // 100D:2E29 mov AL,byte ptr DS:[0x46DF]
        AL = UInt8[DS, (ushort)0x46DF];
        // 100D:2E2C mov AH,AL
        AH = AL;
        // 100D:2E2E xchg AL,byte ptr DS:[0x46E0]
        ushort xchgOffset_100D_2E2E_12EFE = (ushort)0x46E0;
        byte temp_100D_2E2E_12EFE = AL;
        AL = UInt8[DS, xchgOffset_100D_2E2E_12EFE];
        UInt8[DS, xchgOffset_100D_2E2E_12EFE] = unchecked((byte)temp_100D_2E2E_12EFE);
        // 100D:2E32 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:2E34 je short 0x2E4C
        if (ZeroFlag)
        {
            goto label_100D_2E4C_12F1C_14493;
        }
    label_100D_2E36_12F06_20181:
        CheckExternalEvents(cs1, 0x2E36);
        // 100D:2E36 mov AX,word ptr DS:[0xDBD6]
        AX = UInt16[DS, (ushort)0xDBD6];
        // 100D:2E39 cmp AX,word ptr DS:[0xDBD8]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBD8]);
        // 100D:2E3D je short 0x2E52
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_2E52_12F22, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_2E3F_12F0F_20185:
        CheckExternalEvents(cs1, 0x2E3F);
        // 100D:2E3F mov AL,0x10
        AL = (byte)0x10;
        // 100D:2E41 mov BP,0x0F66
        BP = (ushort)0x0F66;
        // 100D:2E44 call near 0xC108
        NearCall(cs1, 0x2E47, transition);
    label_100D_2E47_12F17_20189:
        CheckExternalEvents(cs1, 0x2E47);
        // 100D:2E47 call near 0xAE04
        NearCall(cs1, 0x2E4A, service_midi_music);
    label_100D_2E4A_12F1A_20191:
        CheckExternalEvents(cs1, 0x2E4A);
        // 100D:2E4A jmp short 0x2E52
        if (JumpDispatcher.Jump(unknown_100D_2E52_12F22, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2E4C_12F1C_14493:
        CheckExternalEvents(cs1, 0x2E4C);
        // 100D:2E4C call near 0xC0F4
        NearCall(cs1, 0x2E4F, update_screen_palette);
    label_100D_2E4F_12F1F_14495:
        CheckExternalEvents(cs1, 0x2E4F);
        // 100D:2E4F call near 0xC4CD
        NearCall(cs1, 0x2E52, gfx_copy_whole_framebuf_to_screen);
        if (JumpDispatcher.Jump(unknown_100D_2E52_12F22, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_2E52_12F22(int loadOffset)
    {
    entrydispatcher:
    label_100D_2E52_12F22_14497:
        CheckExternalEvents(cs1, 0x2E52);
        // 100D:2E52 call near 0x35AD
        NearCall(cs1, 0x2E55, finish_room_screen_setup);
    label_100D_2E55_12F25_14511:
        CheckExternalEvents(cs1, 0x2E55);
        // 100D:2E55 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:2E58 mov word ptr DS:[0xDC5A],AX
        UInt16[DS, (ushort)0xDC5A] = AX;
        // 100D:2E5B cmp byte ptr DS:[0x47A7],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A7], (byte)0x00);
        // 100D:2E60 jne short 0x2E97
        if (!ZeroFlag)
        {
            goto label_100D_2E97_12F67_22111;
        }
    label_100D_2E62_12F32_14516:
        CheckExternalEvents(cs1, 0x2E62);
        // 100D:2E62 mov AL,byte ptr DS:[0x4735]
        AL = UInt8[DS, (ushort)0x4735];
        // 100D:2E65 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:2E67 jns short 0x2E6C
        if (!SignFlag)
        {
            goto label_100D_2E6C_12F3C_14520;
        }
    label_100D_2E69_12F39_32181:
        CheckExternalEvents(cs1, 0x2E69);
        // 100D:2E69 jmp near 0x3723
        goto label_100D_3723_137F3_32183;
    label_100D_2E6C_12F3C_14520:
        CheckExternalEvents(cs1, 0x2E6C);
        // 100D:2E6C cmp byte ptr DS:[8],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0xFF);
        // 100D:2E71 je short 0x2E7D
        if (ZeroFlag)
        {
            goto label_100D_2E7D_12F4D_22108;
        }
    label_100D_2E73_12F43_14523:
        CheckExternalEvents(cs1, 0x2E73);
        // 100D:2E73 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:2E78 jne short 0x2E97
        if (!ZeroFlag)
        {
            goto label_100D_2E97_12F67_22111;
        }
    label_100D_2E7A_12F4A_14526:
        CheckExternalEvents(cs1, 0x2E7A);
        // 100D:2E7A jmp near 0x17E6
        if (JumpDispatcher.Jump(ui_hud_head_animate_up, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2E7D_12F4D_22108:
        CheckExternalEvents(cs1, 0x2E7D);
        // 100D:2E7D cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:2E82 jne short 0x2E97
        if (!ZeroFlag)
        {
            goto label_100D_2E97_12F67_22111;
        }
    label_100D_2E84_12F54_27954:
        CheckExternalEvents(cs1, 0x2E84);
        // 100D:2E84 mov SI,word ptr DS:[0x47AA]
        SI = UInt16[DS, (ushort)0x47AA];
        // 100D:2E88 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:2E8A je short 0x2E97
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:2E8A");
        }
    label_100D_2E97_12F67_22111:
        CheckExternalEvents(cs1, 0x2E97);
        // 100D:2E97 ret near
        return NearRet((ushort)0x0000);
    label_100D_3723_137F3_32183:
        CheckExternalEvents(cs1, 0x3723);
        // 100D:3723 and byte ptr DS:[0x4735],0x7F
        UInt8[DS, (ushort)0x4735] = Alu8.And(UInt8[DS, (ushort)0x4735], (byte)0x7F);
        // 100D:3728 sub AL,0x94
        AL = Alu8.Sub(AL, (byte)0x94);
        // 100D:372A jb short 0x3722
        if (CarryFlag)
        {
            return unknown_100D_3722_137F2(0x0000);
        }
    label_100D_372C_137FC_32221:
        CheckExternalEvents(cs1, 0x372C);
        // 100D:372C test AL,0x0F
        Alu8.And(AL, (byte)0x0F);
        // 100D:372E jne short 0x3722
        if (!ZeroFlag)
        {
            return unknown_100D_3722_137F2(0x0000);
        }
    label_100D_3730_13800_32224:
        CheckExternalEvents(cs1, 0x3730);
        // 100D:3730 push AX
        Stack.Push16(AX);
        // 100D:3731 call near 0xDBB2
        NearCall(cs1, 0x3734, call_restore_cursor);
    label_100D_3734_13804_32227:
        CheckExternalEvents(cs1, 0x3734);
        // 100D:3734 call near 0xC07C
        NearCall(cs1, 0x3737, set_fb1_as_active_framebuffer);
    label_100D_3737_13807_32229:
        CheckExternalEvents(cs1, 0x3737);
        // 100D:3737 call near 0x37AD
        NearCall(cs1, 0x373A, unknown_100D_37AD_1387D);
    label_100D_373A_1380A_32234:
        CheckExternalEvents(cs1, 0x373A);
        // 100D:373A call near 0xC4DD
        NearCall(cs1, 0x373D, present_game_area);
    label_100D_373D_1380D_32236:
        CheckExternalEvents(cs1, 0x373D);
        // 100D:373D pop AX
        AX = Stack.Pop16();
        // 100D:373E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3740 mov CL,4
        CL = (byte)0x04;
        // 100D:3742 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:3744 inc AX
        AX = Alu16.Inc(AX);
        // 100D:3745 cmp AL,0x0A
        Alu8.Sub(AL, (byte)0x0A);
        // 100D:3747 jb short 0x374B
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3747");
        }
    label_100D_374B_1381B_32244:
        CheckExternalEvents(cs1, 0x374B);
        // 100D:374B xchg AL,AH
        byte temp_100D_374B_1381B = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_374B_1381B);
        // 100D:374D call near 0xE387
        NearCall(cs1, 0x3750, wait_frame_tasks_for_ticks);
    label_100D_3750_13820_32247:
        CheckExternalEvents(cs1, 0x3750);
        // 100D:3750 cmp byte ptr DS:[0x4735],0x37
        Alu8.Sub(UInt8[DS, (ushort)0x4735], (byte)0x37);
        // 100D:3755 jb short 0x37AA
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:3755");
        }
    label_100D_37AA_1387A_32250:
        CheckExternalEvents(cs1, 0x37AA);
        // 100D:37AA jmp near 0x2DB1
        if (JumpDispatcher.Jump(draw_room_game_screen, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action stage_location_name_placeholders(int loadOffset)
    {
    label_100D_2E98_12F68_13575:
        CheckExternalEvents(cs1, 0x2E98);
        // 100D:2E98 mov word ptr DS:[0x47E6],DI
        UInt16[DS, (ushort)0x47E6] = DI;
        // 100D:2E9C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:2E9E mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:2EA0 add AX,0
        AX = Alu16.Add(AX, (ushort)0x0000);
        // 100D:2EA3 mov word ptr DS:[0x11ED],AX
        UInt16[DS, (ushort)0x11ED] = AX;
        // 100D:2EA6 mov AL,byte ptr DS:[DI+1]
        AL = UInt8[DS, (ushort)(DI + (sbyte)1)];
        // 100D:2EA9 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:2EAB add AX,0x000C
        AX = Alu16.Add(AX, (ushort)0x000C);
        // 100D:2EAE mov word ptr DS:[0x11EF],AX
        UInt16[DS, (ushort)0x11EF] = AX;
        // 100D:2EB1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_draw_room_command_panel(int loadOffset)
    {
    entrydispatcher:
    label_100D_2EB2_12F82_13569:
        CheckExternalEvents(cs1, 0x2EB2);
        // 100D:2EB2 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:2EB7 je short 0x2EC9
        if (ZeroFlag)
        {
            goto label_100D_2EC9_12F99_13572;
        }
    label_100D_2EB9_12F89_30373:
        CheckExternalEvents(cs1, 0x2EB9);
        // 100D:2EB9 call near 0x301A
        NearCall(cs1, 0x2EBC, draw_dialogue_panel);
    label_100D_2EBC_12F8C_30375:
        CheckExternalEvents(cs1, 0x2EBC);
        // 100D:2EBC call near 0x98E6
        NearCall(cs1, 0x2EBF, reset_scene_lip_sync_state);
        if (JumpDispatcher.Jump(sequence_push_continue_menu, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_2EC9_12F99_13572:
        CheckExternalEvents(cs1, 0x2EC9);
        // 100D:2EC9 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:2ECD call near 0x2E98
        NearCall(cs1, 0x2ED0, stage_location_name_placeholders);
    label_100D_2ED0_12FA0_13586:
        CheckExternalEvents(cs1, 0x2ED0);
        // 100D:2ED0 call near 0x2EFB
        NearCall(cs1, 0x2ED3, build_room_command_records);
    label_100D_2ED3_12FA3_13622:
        CheckExternalEvents(cs1, 0x2ED3);
        // 100D:2ED3 cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:2ED8 jne short 0x2EDD
        if (!ZeroFlag)
        {
            goto label_100D_2EDD_12FAD_14049;
        }
    label_100D_2EDA_12FAA_13625:
        CheckExternalEvents(cs1, 0x2EDA);
        // 100D:2EDA call near 0x3090
        NearCall(cs1, 0x2EDD, build_persons_in_room_records);
    label_100D_2EDD_12FAD_14049:
        CheckExternalEvents(cs1, 0x2EDD);
        // 100D:2EDD mov AX,word ptr DS:[0xDC38]
        AX = UInt16[DS, (ushort)0xDC38];
        // 100D:2EE0 cmp AX,0x0074
        Alu16.Sub(AX, (ushort)0x0074);
        // 100D:2EE3 jb short 0x2EEC
        if (CarryFlag)
        {
            goto label_100D_2EEC_12FBC_14057;
        }
    label_100D_2EE5_12FB5_14053:
        CheckExternalEvents(cs1, 0x2EE5);
        // 100D:2EE5 mov AX,0xDBEC
        AX = (ushort)0xDBEC;
        // 100D:2EE8 push AX
        Stack.Push16(AX);
        // 100D:2EE9 call near 0xDBB2
        NearCall(cs1, 0x2EEC, call_restore_cursor);
    label_100D_2EEC_12FBC_14057:
        CheckExternalEvents(cs1, 0x2EEC);
        // 100D:2EEC call near 0x2FFB
        NearCall(cs1, 0x2EEF, rebuild_and_draw_room_nav_panel);
    label_100D_2EEF_12FBF_14108:
        CheckExternalEvents(cs1, 0x2EEF);
        // 100D:2EEF call near 0xD763
        NearCall(cs1, 0x2EF2, ui_hud_draw_companions);
    label_100D_2EF2_12FC2_14110:
        CheckExternalEvents(cs1, 0x2EF2);
        // 100D:2EF2 mov BP,0x1F0E
        BP = (ushort)0x1F0E;
        // 100D:2EF5 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:2EF8 jmp near 0xD338
        if (JumpDispatcher.Jump(menu_stack_push, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action sequence_push_continue_menu(int loadOffset)
    {
    entrydispatcher:
    label_100D_2EBF_12F8F_28360:
        CheckExternalEvents(cs1, 0x2EBF);
        // 100D:2EBF mov BP,word ptr DS:[0x2220]
        BP = UInt16[DS, (ushort)0x2220];
        // 100D:2EC3 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:2EC6 jmp near 0xD338
        if (JumpDispatcher.Jump(menu_stack_push, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action build_room_command_records(int loadOffset)
    {
    label_100D_2EFB_12FCB_13588:
        CheckExternalEvents(cs1, 0x2EFB);
        // 100D:2EFB push DS
        Stack.Push16(DS);
        // 100D:2EFC pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:2EFD mov DI,0x1F0F
        DI = (ushort)0x1F0F;
        // 100D:2F00 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:2F02 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:2F03 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:2F07 mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:2F0B cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:2F0E je short 0x2F13
        if (ZeroFlag)
        {
            goto label_100D_2F13_12FE3_13598;
        }
    label_100D_2F10_12FE0_21925:
        CheckExternalEvents(cs1, 0x2F10);
        // 100D:2F10 jmp near 0x2FAA
        goto label_100D_2FAA_1307A_21927;
    label_100D_2F13_12FE3_13598:
        CheckExternalEvents(cs1, 0x2F13);
        // 100D:2F13 mov SI,0x220C
        SI = (ushort)0x220C;
        // 100D:2F16 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F17 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F18 cmp DL,1
        Alu8.Sub(DL, (byte)0x01);
        // 100D:2F1B jne short 0x2F58
        if (!ZeroFlag)
        {
            goto label_100D_2F58_13028_13604;
        }
    label_100D_2F1D_12FED_20460:
        CheckExternalEvents(cs1, 0x2F1D);
        // 100D:2F1D cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:2F22 je short 0x2F3D
        if (ZeroFlag)
        {
            goto label_100D_2F3D_1300D_20463;
        }
    label_100D_2F24_12FF4_36212:
        CheckExternalEvents(cs1, 0x2F24);
        // 100D:2F24 mov SI,0x2218
        SI = (ushort)0x2218;
        // 100D:2F27 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F28 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F29 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F2A movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F2B mov SI,0x2214
        SI = (ushort)0x2214;
        // 100D:2F2E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2F2F cmp byte ptr DS:[0x002A],0x4F
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x4F);
        // 100D:2F34 sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:2F36 and AH,0x40
        AH = Alu8.And(AH, (byte)0x40);
        // 100D:2F39 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F3A movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F3B jmp short 0x2FA3
        goto label_100D_2FA3_13073_13613;
    label_100D_2F3D_1300D_20463:
        CheckExternalEvents(cs1, 0x2F3D);
        // 100D:2F3D push DI
        Stack.Push16(DI);
        // 100D:2F3E mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:2F42 call near 0x7F27
        NearCall(cs1, 0x2F45, compute_location_available_equipment);
    label_100D_2F45_13015_20467:
        CheckExternalEvents(cs1, 0x2F45);
        // 100D:2F45 pop DI
        DI = Stack.Pop16();
        // 100D:2F46 mov SI,0x21DC
        SI = (ushort)0x21DC;
        // 100D:2F49 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2F4A cmp byte ptr DS:[0x46FF],1
        Alu8.Sub(UInt8[DS, (ushort)0x46FF], (byte)0x01);
        // 100D:2F4F sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:2F51 and AH,0x40
        AH = Alu8.And(AH, (byte)0x40);
        // 100D:2F54 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F55 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F56 jmp short 0x2FA3
        goto label_100D_2FA3_13073_13613;
    label_100D_2F58_13028_13604:
        CheckExternalEvents(cs1, 0x2F58);
        // 100D:2F58 cmp BH,1
        Alu8.Sub(BH, (byte)0x01);
        // 100D:2F5B jne short 0x2FA3
        if (!ZeroFlag)
        {
            goto label_100D_2FA3_13073_13613;
        }
    label_100D_2F5D_1302D_13607:
        CheckExternalEvents(cs1, 0x2F5D);
        // 100D:2F5D cmp DL,8
        Alu8.Sub(DL, (byte)0x08);
        // 100D:2F60 jne short 0x2F99
        if (!ZeroFlag)
        {
            goto label_100D_2F99_13069_13610;
        }
    label_100D_2F62_13032_30341:
        CheckExternalEvents(cs1, 0x2F62);
        // 100D:2F62 cmp byte ptr DS:[0x00C8],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C8], (byte)0x00);
        // 100D:2F67 je short 0x2FA3
        if (ZeroFlag)
        {
            goto label_100D_2FA3_13073_13613;
        }
    label_100D_2F69_13039_31576:
        CheckExternalEvents(cs1, 0x2F69);
        // 100D:2F69 mov SI,0x21E8
        SI = (ushort)0x21E8;
        // 100D:2F6C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2F6D mov CL,byte ptr DS:[0x00C9]
        CL = UInt8[DS, (ushort)0x00C9];
        // 100D:2F71 mov CH,0x27
        CH = (byte)0x27;
        // 100D:2F73 cmp CL,1
        Alu8.Sub(CL, (byte)0x01);
        // 100D:2F76 sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:2F78 add CH,AH
        CH = Alu8.Add(CH, AH);
        // 100D:2F7A cmp byte ptr DS:[0x47A9],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A9], (byte)0x00);
        // 100D:2F7F je short 0x2F83
        if (ZeroFlag)
        {
            goto label_100D_2F83_13053_31586;
        }
    label_100D_2F81_13051_31938:
        CheckExternalEvents(cs1, 0x2F81);
        // 100D:2F81 mov CH,0x28
        CH = (byte)0x28;
    label_100D_2F83_13053_31586:
        CheckExternalEvents(cs1, 0x2F83);
        // 100D:2F83 mov byte ptr DS:[0x1248],CH
        UInt8[DS, (ushort)0x1248] = CH;
        // 100D:2F87 and AH,0x40
        AH = Alu8.And(AH, (byte)0x40);
        // 100D:2F8A stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F8B movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F8C lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2F8D cmp CL,byte ptr DS:[0x00C8]
        Alu8.Sub(CL, UInt8[DS, (ushort)0x00C8]);
        // 100D:2F91 cmc
        CarryFlag = !CarryFlag;
        // 100D:2F92 sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:2F94 and AH,0x40
        AH = Alu8.And(AH, (byte)0x40);
        // 100D:2F97 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2F98 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_100D_2F99_13069_13610:
        CheckExternalEvents(cs1, 0x2F99);
        // 100D:2F99 cmp DL,9
        Alu8.Sub(DL, (byte)0x09);
        // 100D:2F9C jne short 0x2FA3
        if (!ZeroFlag)
        {
            goto label_100D_2FA3_13073_13613;
        }
    label_100D_2F9E_1306E_19933:
        CheckExternalEvents(cs1, 0x2F9E);
        // 100D:2F9E mov SI,0x21F0
        SI = (ushort)0x21F0;
        // 100D:2FA1 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FA2 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_100D_2FA3_13073_13613:
        CheckExternalEvents(cs1, 0x2FA3);
        // 100D:2FA3 mov SI,0x21F4
        SI = (ushort)0x21F4;
        // 100D:2FA6 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FA7 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FA8 jmp short 0x2FF7
        goto label_100D_2FF7_130C7_13618;
    label_100D_2FAA_1307A_21927:
        CheckExternalEvents(cs1, 0x2FAA);
        // 100D:2FAA test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:2FAF jne short 0x2FD7
        if (!ZeroFlag)
        {
            goto label_100D_2FD7_130A7_21930;
        }
    label_100D_2FB1_13081_27865:
        CheckExternalEvents(cs1, 0x2FB1);
        // 100D:2FB1 mov SI,0x220C
        SI = (ushort)0x220C;
        // 100D:2FB4 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FB5 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FB6 mov SI,0x2214
        SI = (ushort)0x2214;
        // 100D:2FB9 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:2FBA cmp byte ptr DS:[0x002A],0x4F
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x4F);
        // 100D:2FBF sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:2FC1 and AH,0x40
        AH = Alu8.And(AH, (byte)0x40);
        // 100D:2FC4 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FC5 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FC6 call near 0x1AE0
        NearCall(cs1, 0x2FC9, get_ingame_time_of_day);
    label_100D_2FC9_13099_27877:
        CheckExternalEvents(cs1, 0x2FC9);
        // 100D:2FC9 mov SI,0x21E0
        SI = (ushort)0x21E0;
        // 100D:2FCC cmp AL,0x0B
        Alu8.Sub(AL, (byte)0x0B);
        // 100D:2FCE jb short 0x2FD3
        if (CarryFlag)
        {
            goto label_100D_2FD3_130A3_27881;
        }
    label_100D_2FD0_130A0_28012:
        CheckExternalEvents(cs1, 0x2FD0);
        // 100D:2FD0 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
    label_100D_2FD3_130A3_27881:
        CheckExternalEvents(cs1, 0x2FD3);
        // 100D:2FD3 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FD4 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FD5 jmp short 0x2FA3
        goto label_100D_2FA3_13073_13613;
    label_100D_2FD7_130A7_21930:
        CheckExternalEvents(cs1, 0x2FD7);
        // 100D:2FD7 mov SI,0x21FC
        SI = (ushort)0x21FC;
        // 100D:2FDA cmp byte ptr DS:[0x11CB],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CB], (byte)0x00);
        // 100D:2FDF je short 0x2FF0
        if (ZeroFlag)
        {
            goto label_100D_2FF0_130C0_21934;
        }
    label_100D_2FE1_130B1_27069:
        CheckExternalEvents(cs1, 0x2FE1);
        // 100D:2FE1 mov SI,0x2200
        SI = (ushort)0x2200;
        // 100D:2FE4 cmp byte ptr DS:[0x002A],0x32
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x32);
        // 100D:2FE9 jb short 0x2FF0
        if (CarryFlag)
        {
            goto label_100D_2FF0_130C0_21934;
        }
    label_100D_2FEB_130BB_33828:
        CheckExternalEvents(cs1, 0x2FEB);
        // 100D:2FEB movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FEC movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FED mov SI,0x2204
        SI = (ushort)0x2204;
    label_100D_2FF0_130C0_21934:
        CheckExternalEvents(cs1, 0x2FF0);
        // 100D:2FF0 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FF1 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FF2 mov SI,0x21F8
        SI = (ushort)0x21F8;
        // 100D:2FF5 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FF6 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
    label_100D_2FF7_130C7_13618:
        CheckExternalEvents(cs1, 0x2FF7);
        // 100D:2FF7 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:2FF9 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:2FFA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action rebuild_and_draw_room_nav_panel(int loadOffset)
    {
    label_100D_2FFB_130CB_14059:
        CheckExternalEvents(cs1, 0x2FFB);
        // 100D:2FFB cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:3000 jne short 0x301A
        if (!ZeroFlag)
        {
            return draw_dialogue_panel(0x0000);
        }
    label_100D_3002_130D2_14062:
        CheckExternalEvents(cs1, 0x3002);
        // 100D:3002 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:3007 je short 0x3020
        if (ZeroFlag)
        {
            goto label_100D_3020_130F0_14065;
        }
    label_100D_3009_130D9_21579:
        CheckExternalEvents(cs1, 0x3009);
        // 100D:3009 cmp byte ptr DS:[0x11CA],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CA], (byte)0x00);
        // 100D:300E jne short 0x301A
        if (!ZeroFlag)
        {
            return draw_dialogue_panel(0x0000);
        }
    label_100D_3010_130E0_21940:
        CheckExternalEvents(cs1, 0x3010);
        // 100D:3010 mov SI,0x1D72
        SI = (ushort)0x1D72;
        // 100D:3013 cmp byte ptr DS:[0x11CB],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CB], (byte)0x00);
        // 100D:3018 jne short 0x301D
        if (!ZeroFlag)
        {
            return unknown_100D_301D_130ED(0x0000);
        }
        else
        {
            return draw_dialogue_panel(0x0000);
        }
    label_100D_3020_130F0_14065:
        CheckExternalEvents(cs1, 0x3020);
        // 100D:3020 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:3024 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:3027 jne short 0x3073
        if (!ZeroFlag)
        {
            goto label_100D_3073_13143_27885;
        }
    label_100D_3029_130F9_14069:
        CheckExternalEvents(cs1, 0x3029);
        // 100D:3029 mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:302D cmp DH,0x21
        Alu8.Sub(DH, (byte)0x21);
        // 100D:3030 je short 0x3073
        if (ZeroFlag)
        {
            goto label_100D_3073_13143_27885;
        }
    label_100D_3032_13102_14073:
        CheckExternalEvents(cs1, 0x3032);
        // 100D:3032 call near 0x3EFE
        NearCall(cs1, 0x3035, unknown_100D_3EFE_13FCE);
    label_100D_3035_13105_14075:
        CheckExternalEvents(cs1, 0x3035);
        // 100D:3035 inc SI
        SI = Alu16.Inc(SI);
        // 100D:3036 mov DI,0x1B96
        DI = (ushort)0x1B96;
        // 100D:3039 mov AL,0x20
        AL = (byte)0x20;
        // 100D:303B cmp word ptr DS:[0x114E],0x0100
        Alu16.Sub(UInt16[DS, (ushort)0x114E], (ushort)0x0100);
        // 100D:3041 jne short 0x3045
        if (!ZeroFlag)
        {
            goto label_100D_3045_13115_14083;
        }
    label_100D_3043_13113_14081:
        CheckExternalEvents(cs1, 0x3043);
        // 100D:3043 mov AL,0x80
        AL = (byte)0x80;
    label_100D_3045_13115_14083:
        CheckExternalEvents(cs1, 0x3045);
        // 100D:3045 mov BX,0x0021
        BX = (ushort)0x0021;
        // 100D:3048 cmp DL,1
        Alu8.Sub(DL, (byte)0x01);
        // 100D:304B jne short 0x3050
        if (!ZeroFlag)
        {
            goto label_100D_3050_13120_14086;
        }
    label_100D_304D_1311D_20477:
        CheckExternalEvents(cs1, 0x304D);
        // 100D:304D inc BX
        BX = Alu16.Inc(BX);
        // 100D:304E mov AL,0x20
        AL = (byte)0x20;
    label_100D_3050_13120_14086:
        CheckExternalEvents(cs1, 0x3050);
        // 100D:3050 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:3053 mov byte ptr DS:[DI+0x46],AL
        UInt8[DS, (ushort)(DI + (sbyte)70)] = AL;
        // 100D:3056 mov byte ptr DS:[0x1CC4],AL
        UInt8[DS, (ushort)0x1CC4] = AL;
        // 100D:3059 mov CX,4
        CX = (ushort)0x0004;
    label_100D_305C_1312C_14091:
        CheckExternalEvents(cs1, 0x305C);
        // 100D:305C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:305D add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:3060 mov AH,0x20
        AH = (byte)0x20;
        // 100D:3062 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:3064 je short 0x306C
        if (ZeroFlag)
        {
            goto label_100D_306C_1313C_14101;
        }
    label_100D_3066_13136_14096:
        CheckExternalEvents(cs1, 0x3066);
        // 100D:3066 cmp AL,0xFB
        Alu8.Sub(AL, (byte)0xFB);
        // 100D:3068 jl short 0x306C
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_306C_1313C_14101;
        }
    label_100D_306A_1313A_14099:
        CheckExternalEvents(cs1, 0x306A);
        // 100D:306A mov AH,0x80
        AH = (byte)0x80;
    label_100D_306C_1313C_14101:
        CheckExternalEvents(cs1, 0x306C);
        // 100D:306C mov byte ptr DS:[DI],AH
        UInt8[DS, DI] = AH;
        // 100D:306E loop 0x305C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_305C_1312C_14091;
        }
    label_100D_3070_13140_14105:
        CheckExternalEvents(cs1, 0x3070);
        // 100D:3070 jmp near 0xD735
        return ui_draw_nav_panel(0x0000);
    label_100D_3073_13143_27885:
        CheckExternalEvents(cs1, 0x3073);
        // 100D:3073 mov DI,0x1B98
        DI = (ushort)0x1B98;
        // 100D:3076 mov word ptr DS:[DI],0x0023
        UInt16[DS, DI] = (ushort)0x0023;
        // 100D:307A mov BX,0x001D
        BX = (ushort)0x001D;
        // 100D:307D mov CX,4
        CX = (ushort)0x0004;
    label_100D_3080_13150_27890:
        CheckExternalEvents(cs1, 0x3080);
        // 100D:3080 add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:3083 mov word ptr DS:[DI],BX
        UInt16[DS, DI] = BX;
        // 100D:3085 mov word ptr DS:[DI-2],0x0080
        UInt16[DS, (ushort)(DI + (sbyte)-2)] = (ushort)0x0080;
        // 100D:308A inc BX
        BX = Alu16.Inc(BX);
        // 100D:308B loop 0x3080
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_3080_13150_27890;
        }
    label_100D_308D_1315D_27896:
        CheckExternalEvents(cs1, 0x308D);
        // 100D:308D jmp near 0xD735
        return ui_draw_nav_panel(0x0000);
    }

    public virtual Action draw_dialogue_panel(int loadOffset)
    {
    label_100D_301A_130EA_21582:
        CheckExternalEvents(cs1, 0x301A);
        // 100D:301A mov SI,0x1D1E
        SI = (ushort)0x1D1E;
        return unknown_100D_301D_130ED(0x0000);
    }

    public virtual Action build_persons_in_room_records(int loadOffset)
    {
    entrydispatcher:
    label_100D_3090_13160_13627:
        CheckExternalEvents(cs1, 0x3090);
        // 100D:3090 call near 0x98E6
        NearCall(cs1, 0x3093, reset_scene_lip_sync_state);
        if (JumpDispatcher.Jump(rebuild_persons_in_room_records, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action rebuild_persons_in_room_records(int loadOffset)
    {
    entrydispatcher:
    label_100D_3093_13163_13629:
        CheckExternalEvents(cs1, 0x3093);
        // 100D:3093 call near 0x3127
        NearCall(cs1, 0x3096, init_room_persons);
    label_100D_3096_13166_13968:
        CheckExternalEvents(cs1, 0x3096);
        // 100D:3096 mov DI,0x1F0C
        DI = (ushort)0x1F0C;
    label_100D_3099_13169_13970:
        CheckExternalEvents(cs1, 0x3099);
        // 100D:3099 add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:309C cmp word ptr DS:[DI],0
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:309F jne short 0x3099
        if (!ZeroFlag)
        {
            goto label_100D_3099_13169_13970;
        }
    label_100D_30A1_13171_13974:
        CheckExternalEvents(cs1, 0x30A1);
        // 100D:30A1 mov word ptr DS:[0x0012],0
        UInt16[DS, (ushort)0x0012] = (ushort)0x0000;
        // 100D:30A7 push DS
        Stack.Push16(DS);
        // 100D:30A8 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:30A9 mov BP,0x30B9
        BP = (ushort)0x30B9;
        // 100D:30AC call near 0x36EE
        NearCall(cs1, 0x30AF, scan_current_room_npcs);
    label_100D_30AF_1317F_14037:
        CheckExternalEvents(cs1, 0x30AF);
        // 100D:30AF mov BP,0x3120
        BP = (ushort)0x3120;
        // 100D:30B2 call near 0x36EE
        NearCall(cs1, 0x30B5, scan_current_room_npcs);
    label_100D_30B5_13185_14045:
        CheckExternalEvents(cs1, 0x30B5);
        // 100D:30B5 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:30B7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:30B8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action build_room_person_record_a(int loadOffset)
    {
    label_100D_30B9_13189_14001:
        CheckExternalEvents(cs1, 0x30B9);
        // 100D:30B9 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:30BD jne short 0x311F
        if (!ZeroFlag)
        {
            return build_room_person_record_body(0x311F);
        }
    label_100D_30BF_1318F_14004:
        CheckExternalEvents(cs1, 0x30BF);
        // 100D:30BF cmp word ptr DS:[0x47AA],0
        Alu16.Sub(UInt16[DS, (ushort)0x47AA], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:30C4 jne short 0x30CA
        if (!ZeroFlag)
        {
            return build_room_person_record_body(0x0000);
        }
    label_100D_30C6_13196_14007:
        CheckExternalEvents(cs1, 0x30C6);
        // 100D:30C6 mov word ptr DS:[0x47AA],SI
        UInt16[DS, (ushort)0x47AA] = SI;
        return build_room_person_record_body(0x0000);
    }

    public virtual Action build_room_person_record_b(int loadOffset)
    {
    label_100D_3120_131F0_14040:
        CheckExternalEvents(cs1, 0x3120);
        // 100D:3120 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:3124 jne short 0x30CA
        if (!ZeroFlag)
        {
            return build_room_person_record_body(0x0000);
        }
    label_100D_3126_131F6_14043:
        CheckExternalEvents(cs1, 0x3126);
        // 100D:3126 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action init_room_persons(int loadOffset)
    {
    label_100D_3127_131F7_13631:
        CheckExternalEvents(cs1, 0x3127);
        // 100D:3127 mov byte ptr DS:[0x476B],0
        UInt8[DS, (ushort)0x476B] = (byte)0x00;
        // 100D:312C mov byte ptr DS:[0x476A],0
        UInt8[DS, (ushort)0x476A] = (byte)0x00;
        // 100D:3131 mov AX,0x7F80
        AX = (ushort)0x7F80;
        // 100D:3134 mov word ptr DS:[0x10CA],AX
        UInt16[DS, (ushort)0x10CA] = AX;
        // 100D:3137 mov word ptr DS:[0x10BA],AX
        UInt16[DS, (ushort)0x10BA] = AX;
        // 100D:313A mov word ptr DS:[0x10AA],AX
        UInt16[DS, (ushort)0x10AA] = AX;
        // 100D:313D mov word ptr DS:[0x109A],AX
        UInt16[DS, (ushort)0x109A] = AX;
        // 100D:3140 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:3144 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:3147 jne short 0x316D
        if (!ZeroFlag)
        {
            return unknown_100D_316D_1323D(0x0000);
        }
    label_100D_3149_13219_13642:
        CheckExternalEvents(cs1, 0x3149);
        // 100D:3149 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:314D mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:3151 mov BP,0x316E
        BP = (ushort)0x316E;
        // 100D:3154 call near 0x6603
        NearCall(cs1, 0x3157, for_each_troop_in_location);
    label_100D_3157_13227_13647:
        CheckExternalEvents(cs1, 0x3157);
        // 100D:3157 cmp byte ptr DS:[DI+8],0x21
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x21);
        // 100D:315B jne short 0x316A
        if (!ZeroFlag)
        {
            goto label_100D_316A_1323A_13650;
        }
    label_100D_315D_1322D_33836:
        CheckExternalEvents(cs1, 0x315D);
        // 100D:315D mov word ptr DS:[0x10A8],DX
        UInt16[DS, (ushort)0x10A8] = DX;
        // 100D:3161 mov word ptr DS:[0x10AA],BX
        UInt16[DS, (ushort)0x10AA] = BX;
        // 100D:3165 push DI
        Stack.Push16(DI);
        // 100D:3166 call near 0x2318
        NearCall(cs1, 0x3169, unknown_100D_2318_123E8);
    label_100D_3169_13239_33883:
        CheckExternalEvents(cs1, 0x3169);
        // 100D:3169 pop DI
        DI = Stack.Pop16();
    label_100D_316A_1323A_13650:
        CheckExternalEvents(cs1, 0x316A);
        // 100D:316A call near 0x331E
        NearCall(cs1, 0x316D, prepare_location_data_for_condit);
        return unknown_100D_316D_1323D(0x0000);
    }

    public virtual Action classify_troop_for_room(int loadOffset)
    {
    label_100D_316E_1323E_22680:
        CheckExternalEvents(cs1, 0x316E);
        // 100D:316E mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:3171 mov AH,2
        AH = (byte)0x02;
        // 100D:3173 test AL,0x20
        Alu8.And(AL, (byte)0x20);
        // 100D:3175 je short 0x3181
        if (ZeroFlag)
        {
            goto label_100D_3181_13251_22685;
        }
    label_100D_3177_13247_36522:
        CheckExternalEvents(cs1, 0x3177);
        // 100D:3177 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:317B jb short 0x3190
        if (CarryFlag)
        {
            goto label_100D_3190_13260_22691;
        }
    label_100D_317D_1324D_36525:
        CheckExternalEvents(cs1, 0x317D);
        // 100D:317D inc AH
        AH = Alu8.Inc(AH);
        // 100D:317F jmp short 0x3190
        goto label_100D_3190_13260_22691;
    label_100D_3181_13251_22685:
        CheckExternalEvents(cs1, 0x3181);
        // 100D:3181 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:3185 jne short 0x316D
        if (!ZeroFlag)
        {
            return unknown_100D_316D_1323D(0x0000);
        }
    label_100D_3187_13257_22688:
        CheckExternalEvents(cs1, 0x3187);
        // 100D:3187 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:318C je short 0x3190
        if (ZeroFlag)
        {
            goto label_100D_3190_13260_22691;
        }
    label_100D_318E_1325E_36226:
        CheckExternalEvents(cs1, 0x318E);
        // 100D:318E dec AH
        AH = Alu8.Dec(AH);
    label_100D_3190_13260_22691:
        CheckExternalEvents(cs1, 0x3190);
        // 100D:3190 cmp AH,DL
        Alu8.Sub(AH, DL);
        // 100D:3192 jne short 0x316D
        if (!ZeroFlag)
        {
            return unknown_100D_316D_1323D(0x0000);
        }
    label_100D_3194_13264_22871:
        CheckExternalEvents(cs1, 0x3194);
        // 100D:3194 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:3198 jne short 0x31C9
        if (!ZeroFlag)
        {
            goto label_100D_31C9_13299_38160;
        }
    label_100D_319A_1326A_22874:
        CheckExternalEvents(cs1, 0x319A);
        // 100D:319A mov BP,0x10B8
        BP = (ushort)0x10B8;
        // 100D:319D mov DI,0x4756
        DI = (ushort)0x4756;
        // 100D:31A0 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:31A2 jae short 0x31ED
        if (!CarryFlag)
        {
            goto label_100D_31ED_132BD_22879;
        }
    label_100D_31A4_13274_23397:
        CheckExternalEvents(cs1, 0x31A4);
        // 100D:31A4 mov BP,0x10C8
        BP = (ushort)0x10C8;
        // 100D:31A7 mov DI,0x4758
        DI = (ushort)0x4758;
        // 100D:31AA and byte ptr DS:[0x476A],7
        UInt8[DS, (ushort)0x476A] = Alu8.And(UInt8[DS, (ushort)0x476A], (byte)0x07);
        // 100D:31AF mov AL,byte ptr DS:[0x476A]
        AL = UInt8[DS, (ushort)0x476A];
        // 100D:31B2 inc byte ptr DS:[0x476A]
        UInt8[DS, (ushort)0x476A] = Alu8.Inc(UInt8[DS, (ushort)0x476A]);
        // 100D:31B6 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:31B8 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:31BC jne short 0x31C3
        if (!ZeroFlag)
        {
            goto label_100D_31C3_13293_23406;
        }
    label_100D_31BE_1328E_28293:
        CheckExternalEvents(cs1, 0x31BE);
        // 100D:31BE inc AX
        AX = Alu16.Inc(AX);
        // 100D:31BF mov byte ptr DS:[0x476B],AL
        UInt8[DS, (ushort)0x476B] = AL;
        // 100D:31C2 dec AX
        AX = Alu16.Dec(AX);
    label_100D_31C3_13293_23406:
        CheckExternalEvents(cs1, 0x31C3);
        // 100D:31C3 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:31C5 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:31C7 jmp short 0x31ED
        goto label_100D_31ED_132BD_22879;
    label_100D_31C9_13299_38160:
        CheckExternalEvents(cs1, 0x31C9);
        // 100D:31C9 mov BP,0x1098
        BP = (ushort)0x1098;
        // 100D:31CC mov DI,0x4768
        DI = (ushort)0x4768;
        // 100D:31CF mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:31D2 and AL,0x10
        AL = Alu8.And(AL, (byte)0x10);
        // 100D:31D4 and byte ptr SS:[BP+0x0F],0xEF
        UInt8[SS, (ushort)(BP + (sbyte)15)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)15)], (byte)0xEF);
        // 100D:31D8 or byte ptr SS:[BP+0x0F],AL
        UInt8[SS, (ushort)(BP + (sbyte)15)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)15)], AL);
        // 100D:31DB mov word ptr DS:[0x00EE],0
        UInt16[DS, (ushort)0x00EE] = (ushort)0x0000;
        // 100D:31E1 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:31E3 mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:31E5 jne short 0x31EA
        if (!ZeroFlag)
        {
            goto label_100D_31EA_132BA_38171;
        }
    label_100D_31E7_132B7_38173:
        CheckExternalEvents(cs1, 0x31E7);
        // 100D:31E7 mov AL,byte ptr DS:[SI+0x15]
        AL = UInt8[DS, (ushort)(SI + (sbyte)21)];
    label_100D_31EA_132BA_38171:
        CheckExternalEvents(cs1, 0x31EA);
        // 100D:31EA mov byte ptr DS:[0x00ED],AL
        UInt8[DS, (ushort)0x00ED] = AL;
    label_100D_31ED_132BD_22879:
        CheckExternalEvents(cs1, 0x31ED);
        // 100D:31ED mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 100D:31EF mov word ptr SS:[BP],DX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = DX;
        // 100D:31F2 mov word ptr SS:[BP+2],BX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = BX;
        // 100D:31F5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_prepare_troop_data_for_condit(int loadOffset)
    {
    label_100D_31F6_132C6_22923:
        CheckExternalEvents(cs1, 0x31F6);
        // 100D:31F6 call near 0xE270
        NearCall(cs1, 0x31F9, unknown_100D_E270_1E340);
    label_100D_31F9_132C9_22925:
        CheckExternalEvents(cs1, 0x31F9);
        // 100D:31F9 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:31FC mov word ptr DS:[0x002C],DI
        UInt16[DS, (ushort)0x002C] = DI;
        // 100D:3200 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:3202 mov byte ptr DS:[0x002E],AL
        UInt8[DS, (ushort)0x002E] = AL;
        // 100D:3205 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:3208 mov byte ptr DS:[0x0030],AL
        UInt8[DS, (ushort)0x0030] = AL;
        // 100D:320B and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:320E mov byte ptr DS:[0x002F],AL
        UInt8[DS, (ushort)0x002F] = AL;
        // 100D:3211 add AX,0x0018
        AX = Alu16.Add(AX, (ushort)0x0018);
        // 100D:3214 mov word ptr DS:[0x11F3],AX
        UInt16[DS, (ushort)0x11F3] = AX;
        // 100D:3217 call near 0x32C7
        NearCall(cs1, 0x321A, unknown_100D_32C7_13397);
    label_100D_321A_132EA_22959:
        CheckExternalEvents(cs1, 0x321A);
        // 100D:321A call near 0x329D
        NearCall(cs1, 0x321D, troop_condit_stage_harvest_rates);
    label_100D_321D_132ED_22968:
        CheckExternalEvents(cs1, 0x321D);
        // 100D:321D mov word ptr DS:[0x0048],AX
        UInt16[DS, (ushort)0x0048] = AX;
        // 100D:3220 mov AX,word ptr DS:[SI+0x10]
        AX = UInt16[DS, (ushort)(SI + (sbyte)16)];
        // 100D:3223 mov word ptr DS:[0x0032],AX
        UInt16[DS, (ushort)0x0032] = AX;
        // 100D:3226 mov AX,word ptr DS:[SI+0x12]
        AX = UInt16[DS, (ushort)(SI + (sbyte)18)];
        // 100D:3229 mov word ptr DS:[0x0034],AX
        UInt16[DS, (ushort)0x0034] = AX;
        // 100D:322C and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:322F mov byte ptr DS:[0x0031],AL
        UInt8[DS, (ushort)0x0031] = AL;
        // 100D:3232 add AX,0
        AX = Alu16.Add(AX, (ushort)0x0000);
        // 100D:3235 mov word ptr DS:[0x11FF],AX
        UInt16[DS, (ushort)0x11FF] = AX;
        // 100D:3238 call near 0x6EFD
        NearCall(cs1, 0x323B, troop_compute_motivation_modifier);
    label_100D_323B_1330B_22979:
        CheckExternalEvents(cs1, 0x323B);
        // 100D:323B mov byte ptr DS:[0x0036],AL
        UInt8[DS, (ushort)0x0036] = AL;
        // 100D:323E mov AL,byte ptr DS:[SI+0x16]
        AL = UInt8[DS, (ushort)(SI + (sbyte)22)];
        // 100D:3241 mov byte ptr DS:[0x0038],AL
        UInt8[DS, (ushort)0x0038] = AL;
        // 100D:3244 call near 0x3310
        NearCall(cs1, 0x3247, get_command_string_index_from_troop_skill);
    label_100D_3247_13317_22992:
        CheckExternalEvents(cs1, 0x3247);
        // 100D:3247 mov word ptr DS:[0x11F7],AX
        UInt16[DS, (ushort)0x11F7] = AX;
        // 100D:324A mov AL,byte ptr DS:[SI+0x17]
        AL = UInt8[DS, (ushort)(SI + (sbyte)23)];
        // 100D:324D mov byte ptr DS:[0x0039],AL
        UInt8[DS, (ushort)0x0039] = AL;
        // 100D:3250 call near 0x3310
        NearCall(cs1, 0x3253, get_command_string_index_from_troop_skill);
    label_100D_3253_13323_22997:
        CheckExternalEvents(cs1, 0x3253);
        // 100D:3253 mov word ptr DS:[0x11F9],AX
        UInt16[DS, (ushort)0x11F9] = AX;
        // 100D:3256 mov AL,byte ptr DS:[SI+0x18]
        AL = UInt8[DS, (ushort)(SI + (sbyte)24)];
        // 100D:3259 mov byte ptr DS:[0x003A],AL
        UInt8[DS, (ushort)0x003A] = AL;
        // 100D:325C call near 0x3310
        NearCall(cs1, 0x325F, get_command_string_index_from_troop_skill);
    label_100D_325F_1332F_23002:
        CheckExternalEvents(cs1, 0x325F);
        // 100D:325F mov word ptr DS:[0x11FB],AX
        UInt16[DS, (ushort)0x11FB] = AX;
        // 100D:3262 mov AX,word ptr DS:[SI+0x0C]
        AX = UInt16[DS, (ushort)(SI + (sbyte)12)];
        // 100D:3265 mov word ptr DS:[0x0044],AX
        UInt16[DS, (ushort)0x0044] = AX;
        // 100D:3268 mov AX,word ptr DS:[SI+0x0E]
        AX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:326B mov word ptr DS:[0x0046],AX
        UInt16[DS, (ushort)0x0046] = AX;
        // 100D:326E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3270 add AX,0x00E8
        AX = Alu16.Add(AX, (ushort)0x00E8);
        // 100D:3273 mov word ptr DS:[0x11F1],AX
        UInt16[DS, (ushort)0x11F1] = AX;
        // 100D:3276 call near 0x693B
        NearCall(cs1, 0x3279, troop_get_occupation_bits_2_and_3);
    label_100D_3279_13349_23018:
        CheckExternalEvents(cs1, 0x3279);
        // 100D:3279 mov BP,AX
        BP = AX;
        // 100D:327B mov AL,byte ptr SS:[BP+SI+0x16]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)22)];
        // 100D:327E mov byte ptr DS:[0x0037],AL
        UInt8[DS, (ushort)0x0037] = AL;
        // 100D:3281 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:3284 mov byte ptr DS:[0x003B],AL
        UInt8[DS, (ushort)0x003B] = AL;
        // 100D:3287 mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:328A mov byte ptr DS:[0x003C],AL
        UInt8[DS, (ushort)0x003C] = AL;
        // 100D:328D call near 0x1AC5
        NearCall(cs1, 0x3290, unknown_100D_1AC5_11B95);
    label_100D_3290_13360_23034:
        CheckExternalEvents(cs1, 0x3290);
        // 100D:3290 sub AL,byte ptr DS:[SI+0x14]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)20)]);
        // 100D:3293 mov byte ptr DS:[0x0040],AL
        UInt8[DS, (ushort)0x0040] = AL;
        // 100D:3296 call near 0x331E
        NearCall(cs1, 0x3299, prepare_location_data_for_condit);
    label_100D_3299_13369_23038:
        CheckExternalEvents(cs1, 0x3299);
        // 100D:3299 call near 0xE283
        NearCall(cs1, 0x329C, unknown_100D_E283_1E353);
    label_100D_329C_1336C_23040:
        CheckExternalEvents(cs1, 0x329C);
        // 100D:329C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_condit_stage_harvest_rates(int loadOffset)
    {
    label_100D_329D_1336D_22961:
        CheckExternalEvents(cs1, 0x329D);
        // 100D:329D cmp byte ptr DS:[SI+3],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x00);
        // 100D:32A1 je short 0x32AA
        if (ZeroFlag)
        {
            goto label_100D_32AA_1337A_24695;
        }
    label_100D_32A3_13373_22964:
        CheckExternalEvents(cs1, 0x32A3);
        // 100D:32A3 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:32A5 and word ptr DS:[SI+0x10],-13
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], unchecked((ushort)unchecked((short)(sbyte)-13)));
        // 100D:32A9 ret near
        return NearRet((ushort)0x0000);
    label_100D_32AA_1337A_24695:
        CheckExternalEvents(cs1, 0x32AA);
        // 100D:32AA mov AX,word ptr DS:[0x0042]
        AX = UInt16[DS, (ushort)0x0042];
        // 100D:32AD or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:32AF je short 0x32C1
        if (ZeroFlag)
        {
            goto label_100D_32C1_13391_24699;
        }
    label_100D_32B1_13381_27003:
        CheckExternalEvents(cs1, 0x32B1);
        // 100D:32B1 mov CX,AX
        CX = AX;
        // 100D:32B3 mov AX,word ptr DS:[SI+0x0E]
        AX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:32B6 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:32B8 div CX
        ushort divisor_100D_32B8_13388 = CX;
        uint dividend_100D_32B8_13388 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_32B8_13388 = Alu16.Div(unchecked((uint)dividend_100D_32B8_13388), unchecked((ushort)divisor_100D_32B8_13388));
        AX = unchecked((ushort)quotient_100D_32B8_13388);
        DX = unchecked((ushort)(dividend_100D_32B8_13388 % unchecked((uint)divisor_100D_32B8_13388)));
        // 100D:32BA shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:32BC cmp CX,DX
        Alu16.Sub(CX, DX);
        // 100D:32BE adc AX,0
        AX = Alu16.Adc(AX, (ushort)0x0000);
    label_100D_32C1_13391_24699:
        CheckExternalEvents(cs1, 0x32C1);
        // 100D:32C1 mov word ptr DS:[0x004A],AX
        UInt16[DS, (ushort)0x004A] = AX;
        // 100D:32C4 jmp near 0x708A
        return troop_update_harvest_rate(0x0000);
    }

    public virtual Action unknown_100D_32C7_13397(int loadOffset)
    {
    label_100D_32C7_13397_22937:
        CheckExternalEvents(cs1, 0x32C7);
        // 100D:32C7 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:32CA sub AX,word ptr DS:[SI+0x0A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)10)]);
        // 100D:32CD mov word ptr DS:[0x0042],AX
        UInt16[DS, (ushort)0x0042] = AX;
        // 100D:32D0 mov DX,AX
        DX = AX;
        // 100D:32D2 mov CL,4
        CL = (byte)0x04;
        // 100D:32D4 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:32D6 mov byte ptr DS:[0x0041],AL
        UInt8[DS, (ushort)0x0041] = AL;
        // 100D:32D9 mov AX,0x0074
        AX = (ushort)0x0074;
        // 100D:32DC test byte ptr DS:[SI+3],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x10);
        // 100D:32E0 jne short 0x330C
        if (!ZeroFlag)
        {
            goto label_100D_330C_133DC_22956;
        }
    label_100D_32E2_133B2_22948:
        CheckExternalEvents(cs1, 0x32E2);
        // 100D:32E2 mov AX,0x0070
        AX = (ushort)0x0070;
        // 100D:32E5 cmp DX,3
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:32E8 jb short 0x330C
        if (CarryFlag)
        {
            goto label_100D_330C_133DC_22956;
        }
    label_100D_32EA_133BA_22952:
        CheckExternalEvents(cs1, 0x32EA);
        // 100D:32EA inc AX
        AX = Alu16.Inc(AX);
        // 100D:32EB cmp DX,0x0010
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:32EE jb short 0x330C
        if (CarryFlag)
        {
            goto label_100D_330C_133DC_22956;
        }
    label_100D_32F0_133C0_27275:
        CheckExternalEvents(cs1, 0x32F0);
        // 100D:32F0 inc AX
        AX = Alu16.Inc(AX);
        // 100D:32F1 cmp DX,0x0020
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)32)));
        // 100D:32F4 jb short 0x330C
        if (CarryFlag)
        {
            goto label_100D_330C_133DC_22956;
        }
    label_100D_32F6_133C6_28273:
        CheckExternalEvents(cs1, 0x32F6);
        // 100D:32F6 inc AX
        AX = Alu16.Inc(AX);
        // 100D:32F7 push AX
        Stack.Push16(AX);
        // 100D:32F8 push SI
        Stack.Push16(SI);
        // 100D:32F9 mov SI,AX
        SI = AX;
        // 100D:32FB call near 0xCF70
        NearCall(cs1, 0x32FE, get_phrase_or_command_string);
    label_100D_32FE_133CE_28279:
        CheckExternalEvents(cs1, 0x32FE);
        // 100D:32FE call near 0xD03C
        NearCall(cs1, 0x3301, command_string_replace_number);
    label_100D_3301_133D1_28281:
        CheckExternalEvents(cs1, 0x3301);
        // 100D:3301 mov AX,DX
        AX = DX;
        // 100D:3303 mov CL,4
        CL = (byte)0x04;
        // 100D:3305 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:3307 call near 0xE2E3
        NearCall(cs1, 0x330A, write_stat_number_3);
    label_100D_330A_133DA_28286:
        CheckExternalEvents(cs1, 0x330A);
        // 100D:330A pop SI
        SI = Stack.Pop16();
        // 100D:330B pop AX
        AX = Stack.Pop16();
    label_100D_330C_133DC_22956:
        CheckExternalEvents(cs1, 0x330C);
        // 100D:330C mov word ptr DS:[0x11F5],AX
        UInt16[DS, (ushort)0x11F5] = AX;
        // 100D:330F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_command_string_index_from_troop_skill(int loadOffset)
    {
    label_100D_3310_133E0_22984:
        CheckExternalEvents(cs1, 0x3310);
        // 100D:3310 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3312 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3314 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3316 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3318 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:331A add AX,0x00D1
        AX = Alu16.Add(AX, (ushort)0x00D1);
        // 100D:331D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action prepare_location_data_for_condit(int loadOffset)
    {
    label_100D_331E_133EE_13652:
        CheckExternalEvents(cs1, 0x331E);
        // 100D:331E mov word ptr DS:[0x11CE],DI
        UInt16[DS, (ushort)0x11CE] = DI;
        // 100D:3322 push SI
        Stack.Push16(SI);
        // 100D:3323 push DI
        Stack.Push16(DI);
        // 100D:3324 mov AH,byte ptr DS:[DI]
        AH = UInt8[DS, DI];
        // 100D:3326 mov AL,byte ptr DS:[DI+1]
        AL = UInt8[DS, (ushort)(DI + (sbyte)1)];
        // 100D:3329 mov word ptr DS:[0x004E],AX
        UInt16[DS, (ushort)0x004E] = AX;
        // 100D:332C mov BX,0x1141
        BX = (ushort)0x1141;
        // 100D:332F xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:3330 mov byte ptr DS:[0x0050],AL
        UInt8[DS, (ushort)0x0050] = AL;
        // 100D:3333 mov AL,byte ptr DS:[DI+0x0A]
        AL = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:3336 mov byte ptr DS:[0x0051],AL
        UInt8[DS, (ushort)0x0051] = AL;
        // 100D:3339 mov AL,byte ptr DS:[DI+0x12]
        AL = UInt8[DS, (ushort)(DI + (sbyte)18)];
        // 100D:333C mov byte ptr DS:[0x0052],AL
        UInt8[DS, (ushort)0x0052] = AL;
        // 100D:333F mov AL,byte ptr DS:[DI+0x1B]
        AL = UInt8[DS, (ushort)(DI + (sbyte)27)];
        // 100D:3342 mov byte ptr DS:[0x0054],AL
        UInt8[DS, (ushort)0x0054] = AL;
        // 100D:3345 mov AL,byte ptr DS:[DI+8]
        AL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:3348 mov byte ptr DS:[0x004D],AL
        UInt8[DS, (ushort)0x004D] = AL;
        // 100D:334B push DS
        Stack.Push16(DS);
        // 100D:334C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:334D push DI
        Stack.Push16(DI);
        // 100D:334E lea SI,DI+0x14
        SI = unchecked((ushort)(DI + (sbyte)20));
        // 100D:3351 mov DI,0x0055
        DI = (ushort)0x0055;
        // 100D:3354 mov CX,7
        CX = (ushort)0x0007;
        // 100D:3357 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:3359 pop DI
        DI = Stack.Pop16();
        // 100D:335A call near 0x33BE
        NearCall(cs1, 0x335D, unknown_100D_33BE_1348E);
    label_100D_335D_1342D_13709:
        CheckExternalEvents(cs1, 0x335D);
        // 100D:335D call near 0x34A5
        NearCall(cs1, 0x3360, unknown_100D_34A5_13575);
    label_100D_3360_13430_13748:
        CheckExternalEvents(cs1, 0x3360);
        // 100D:3360 call near 0x7F27
        NearCall(cs1, 0x3363, compute_location_available_equipment);
    label_100D_3363_13433_13765:
        CheckExternalEvents(cs1, 0x3363);
        // 100D:3363 mov DI,0x46FE
        DI = (ushort)0x46FE;
        // 100D:3366 mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:3368 mov CX,7
        CX = (ushort)0x0007;
    label_100D_336B_1343B_13769:
        CheckExternalEvents(cs1, 0x336B);
        // 100D:336B cmp byte ptr DS:[DI],1
        Alu8.Sub(UInt8[DS, DI], (byte)0x01);
        // 100D:336E rcl AL,1
        AL = Alu8.Rcl(AL, unchecked((byte)1));
        // 100D:3370 inc DI
        DI = Alu16.Inc(DI);
        // 100D:3371 loop 0x336B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_336B_1343B_13769;
        }
    label_100D_3373_13443_13774:
        CheckExternalEvents(cs1, 0x3373);
        // 100D:3373 not AL
        AL = unchecked((byte)~AL);
        // 100D:3375 mov CL,1
        CL = (byte)0x01;
        // 100D:3377 shl AL,CL
        AL = Alu8.Shl(AL, unchecked((int)CL));
        // 100D:3379 mov byte ptr DS:[0x0053],AL
        UInt8[DS, (ushort)0x0053] = AL;
        // 100D:337C pop DI
        DI = Stack.Pop16();
        // 100D:337D call near 0x3385
        NearCall(cs1, 0x3380, unknown_100D_3385_13455);
    label_100D_3380_13450_13787:
        CheckExternalEvents(cs1, 0x3380);
        // 100D:3380 call near 0x5274
        NearCall(cs1, 0x3383, condit_scan_nearest_locations);
    label_100D_3383_13453_13963:
        CheckExternalEvents(cs1, 0x3383);
        // 100D:3383 pop SI
        SI = Stack.Pop16();
        // 100D:3384 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3385_13455(int loadOffset)
    {
    label_100D_3385_13455_13781:
        CheckExternalEvents(cs1, 0x3385);
        // 100D:3385 mov byte ptr DS:[0x00F7],0
        UInt8[DS, (ushort)0x00F7] = (byte)0x00;
        // 100D:338A cmp DI,word ptr DS:[0x1150]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x1150]);
        // 100D:338E je short 0x33BD
        if (ZeroFlag)
        {
            return unknown_100D_33BD_1348D(0x0000);
        }
    label_100D_3390_13460_29421:
        CheckExternalEvents(cs1, 0x3390);
        // 100D:3390 mov AX,DI
        AX = DI;
        // 100D:3392 sub AX,0x0100
        AX = Alu16.Sub(AX, (ushort)0x0100);
        // 100D:3395 mov BL,0x1C
        BL = (byte)0x1C;
        // 100D:3397 div BL
        byte divisor_100D_3397_13467 = BL;
        ushort dividend_100D_3397_13467 = AX;
        byte quotient_100D_3397_13467 = Alu8.Div(unchecked((ushort)dividend_100D_3397_13467), unchecked((byte)divisor_100D_3397_13467));
        AL = unchecked((byte)quotient_100D_3397_13467);
        AH = unchecked((byte)(dividend_100D_3397_13467 % unchecked((ushort)divisor_100D_3397_13467)));
        // 100D:3399 inc AX
        AX = Alu16.Inc(AX);
        // 100D:339A mov BH,AL
        BH = AL;
        // 100D:339C mov BL,0x80
        BL = (byte)0x80;
        // 100D:339E mov SI,0x1018
        SI = (ushort)0x1018;
        // 100D:33A1 call near 0x33AD
        NearCall(cs1, 0x33A4, unknown_100D_33AD_1347D);
    label_100D_33A4_13474_29434:
        CheckExternalEvents(cs1, 0x33A4);
        // 100D:33A4 mov SI,0x1028
        SI = (ushort)0x1028;
        // 100D:33A7 call near 0x33AD
        NearCall(cs1, 0x33AA, unknown_100D_33AD_1347D);
    label_100D_33AA_1347A_29437:
        CheckExternalEvents(cs1, 0x33AA);
        // 100D:33AA mov SI,0x1048
        SI = (ushort)0x1048;
        return unknown_100D_33AD_1347D(0x0000);
    }

    public virtual Action unknown_100D_33AD_1347D(int loadOffset)
    {
    label_100D_33AD_1347D_29431:
        CheckExternalEvents(cs1, 0x33AD);
        // 100D:33AD cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:33B0 jne short 0x33BD
        if (!ZeroFlag)
        {
            return unknown_100D_33BD_1348D(0x0000);
        }
    label_100D_33B2_13482_34708:
        CheckExternalEvents(cs1, 0x33B2);
        // 100D:33B2 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:33B5 mov AL,1
        AL = (byte)0x01;
        // 100D:33B7 shl AL,CL
        AL = Alu8.Shl(AL, unchecked((int)CL));
        // 100D:33B9 or byte ptr DS:[0x00F7],AL
        UInt8[DS, (ushort)0x00F7] = Alu8.Or(UInt8[DS, (ushort)0x00F7], AL);
        return unknown_100D_33BD_1348D(0x0000);
    }

    public virtual Action unknown_100D_33BE_1348E(int loadOffset)
    {
    label_100D_33BE_1348E_13679:
        CheckExternalEvents(cs1, 0x33BE);
        // 100D:33BE xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:33C0 mov word ptr DS:[0x0094],AX
        UInt16[DS, (ushort)0x0094] = AX;
        // 100D:33C3 mov word ptr DS:[0x0096],AX
        UInt16[DS, (ushort)0x0096] = AX;
        // 100D:33C6 mov word ptr DS:[0x005C],AX
        UInt16[DS, (ushort)0x005C] = AX;
        // 100D:33C9 mov word ptr DS:[0x005E],AX
        UInt16[DS, (ushort)0x005E] = AX;
        // 100D:33CC mov BP,0x3406
        BP = (ushort)0x3406;
        // 100D:33CF call near 0x6603
        NearCall(cs1, 0x33D2, for_each_troop_in_location);
    label_100D_33D2_134A2_13687:
        CheckExternalEvents(cs1, 0x33D2);
        // 100D:33D2 call near 0x33D9
        NearCall(cs1, 0x33D5, unknown_100D_33D9_134A9);
    label_100D_33D5_134A5_13706:
        CheckExternalEvents(cs1, 0x33D5);
        // 100D:33D5 mov byte ptr DS:[0x009C],AL
        UInt8[DS, (ushort)0x009C] = AL;
        // 100D:33D8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_33D9_134A9(int loadOffset)
    {
    label_100D_33D9_134A9_13689:
        CheckExternalEvents(cs1, 0x33D9);
        // 100D:33D9 mov AX,word ptr DS:[0x0096]
        AX = UInt16[DS, (ushort)0x0096];
        // 100D:33DC mov DX,word ptr DS:[0x0094]
        DX = UInt16[DS, (ushort)0x0094];
        // 100D:33E0 cmp AX,DX
        Alu16.Sub(AX, DX);
        // 100D:33E2 pushf
        Stack.Push16(FlagRegister16);
        // 100D:33E3 jae short 0x33E6
        if (!CarryFlag)
        {
            goto label_100D_33E6_134B6_13695;
        }
    label_100D_33E5_134B5_34341:
        CheckExternalEvents(cs1, 0x33E5);
        // 100D:33E5 xchg DX,AX
        ushort temp_100D_33E5_134B5 = DX;
        DX = AX;
        AX = unchecked((ushort)temp_100D_33E5_134B5);
    label_100D_33E6_134B6_13695:
        CheckExternalEvents(cs1, 0x33E6);
        // 100D:33E6 mov CX,DX
        CX = DX;
        // 100D:33E8 jcxz short 0x33FD
        if (CX == (ushort)0x0000)
        {
            goto label_100D_33FD_134CD_13698;
        }
    label_100D_33EA_134BA_34343:
        CheckExternalEvents(cs1, 0x33EA);
        // 100D:33EA xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:33EC xchg AH,DL
        byte temp_100D_33EC_134BC = AH;
        AH = DL;
        DL = unchecked((byte)temp_100D_33EC_134BC);
        // 100D:33EE xchg AL,AH
        byte temp_100D_33EE_134BE = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_33EE_134BE);
        // 100D:33F0 cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:33F2 jae short 0x33FD
        if (!CarryFlag)
        {
            goto label_100D_33FD_134CD_13698;
        }
    label_100D_33F4_134C4_34349:
        CheckExternalEvents(cs1, 0x33F4);
        // 100D:33F4 div CX
        ushort divisor_100D_33F4_134C4 = CX;
        uint dividend_100D_33F4_134C4 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_33F4_134C4 = Alu16.Div(unchecked((uint)dividend_100D_33F4_134C4), unchecked((ushort)divisor_100D_33F4_134C4));
        AX = unchecked((ushort)quotient_100D_33F4_134C4);
        DX = unchecked((ushort)(dividend_100D_33F4_134C4 % unchecked((uint)divisor_100D_33F4_134C4)));
        // 100D:33F6 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:33F8 cmp AX,0x00FC
        Alu16.Sub(AX, (ushort)0x00FC);
        // 100D:33FB jb short 0x3400
        if (CarryFlag)
        {
            goto label_100D_3400_134D0_13700;
        }
    label_100D_33FD_134CD_13698:
        CheckExternalEvents(cs1, 0x33FD);
        // 100D:33FD mov AX,0x00FC
        AX = (ushort)0x00FC;
    label_100D_3400_134D0_13700:
        CheckExternalEvents(cs1, 0x3400);
        // 100D:3400 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_3401_134D1_13702:
        CheckExternalEvents(cs1, 0x3401);
        // 100D:3401 jae short 0x3405
        if (!CarryFlag)
        {
            goto label_100D_3405_134D5_13704;
        }
    label_100D_3403_134D3_34354:
        CheckExternalEvents(cs1, 0x3403);
        // 100D:3403 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_3405_134D5_13704:
        CheckExternalEvents(cs1, 0x3405);
        // 100D:3405 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_3406_134D6(int loadOffset)
    {
    label_100D_3406_134D6_22694:
        CheckExternalEvents(cs1, 0x3406);
        // 100D:3406 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:340A jne short 0x342C
        if (!ZeroFlag)
        {
            goto label_100D_342C_134FC_34340;
        }
    label_100D_340C_134DC_22697:
        CheckExternalEvents(cs1, 0x340C);
        // 100D:340C call near 0x342D
        NearCall(cs1, 0x340F, unknown_100D_342D_134FD);
    label_100D_340F_134DF_22759:
        CheckExternalEvents(cs1, 0x340F);
        // 100D:340F test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:3413 jne short 0x3428
        if (!ZeroFlag)
        {
            goto label_100D_3428_134F8_34338;
        }
    label_100D_3415_134E5_22762:
        CheckExternalEvents(cs1, 0x3415);
        // 100D:3415 add word ptr DS:[0x0096],AX
        UInt16[DS, (ushort)0x0096] = Alu16.Add(UInt16[DS, (ushort)0x0096], AX);
        // 100D:3419 mov AX,word ptr DS:[SI+0x10]
        AX = UInt16[DS, (ushort)(SI + (sbyte)16)];
        // 100D:341C or word ptr DS:[0x005C],AX
        UInt16[DS, (ushort)0x005C] = Alu16.Or(UInt16[DS, (ushort)0x005C], AX);
        // 100D:3420 mov AX,word ptr DS:[SI+0x12]
        AX = UInt16[DS, (ushort)(SI + (sbyte)18)];
        // 100D:3423 or word ptr DS:[0x005E],AX
        UInt16[DS, (ushort)0x005E] = Alu16.Or(UInt16[DS, (ushort)0x005E], AX);
        // 100D:3427 ret near
        return NearRet((ushort)0x0000);
    label_100D_3428_134F8_34338:
        CheckExternalEvents(cs1, 0x3428);
        // 100D:3428 add word ptr DS:[0x0094],AX
        UInt16[DS, (ushort)0x0094] = Alu16.Add(UInt16[DS, (ushort)0x0094], AX);
    label_100D_342C_134FC_34340:
        CheckExternalEvents(cs1, 0x342C);
        // 100D:342C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_342D_134FD(int loadOffset)
    {
    label_100D_342D_134FD_22699:
        CheckExternalEvents(cs1, 0x342D);
        // 100D:342D call near 0x6EFD
        NearCall(cs1, 0x3430, troop_compute_motivation_modifier);
    label_100D_3430_13500_22722:
        CheckExternalEvents(cs1, 0x3430);
        // 100D:3430 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3432 add AL,AL
        AL = Alu8.Add(AL, AL);
        // 100D:3434 add AL,byte ptr DS:[SI+0x17]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)(SI + (sbyte)23)]);
        // 100D:3437 jae short 0x343B
        if (!CarryFlag)
        {
            goto label_100D_343B_1350B_22727;
        }
    label_100D_3439_13509_39790:
        CheckExternalEvents(cs1, 0x3439);
        // 100D:3439 mov AL,0xFF
        AL = (byte)0xFF;
    label_100D_343B_1350B_22727:
        CheckExternalEvents(cs1, 0x343B);
        // 100D:343B mul byte ptr DS:[SI+0x1A]
        ushort result_100D_343B_1350B = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)UInt8[DS, (ushort)(SI + (sbyte)26)])));
        AH = unchecked((byte)(result_100D_343B_1350B >> 8));
        AL = unchecked((byte)result_100D_343B_1350B);
        // 100D:343E shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3440 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3442 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3444 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:3446 mov DX,AX
        DX = AX;
        // 100D:3448 mov BL,byte ptr DS:[SI+0x19]
        BL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:344B shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:344D shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:344F shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:3451 shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:3453 jae short 0x3459
        if (!CarryFlag)
        {
            goto label_100D_3459_13529_22740;
        }
    label_100D_3455_13525_33522:
        CheckExternalEvents(cs1, 0x3455);
        // 100D:3455 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:3457 jb short 0x3477
        if (CarryFlag)
        {
            goto label_100D_3477_13547_40091;
        }
    label_100D_3459_13529_22740:
        CheckExternalEvents(cs1, 0x3459);
        // 100D:3459 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:345B shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:345D jae short 0x3463
        if (!CarryFlag)
        {
            goto label_100D_3463_13533_22744;
        }
    label_100D_345F_1352F_34332:
        CheckExternalEvents(cs1, 0x345F);
        // 100D:345F add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:3461 jb short 0x3477
        if (CarryFlag)
        {
            goto label_100D_3477_13547_40091;
        }
    label_100D_3463_13533_22744:
        CheckExternalEvents(cs1, 0x3463);
        // 100D:3463 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:3465 shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:3467 jae short 0x346D
        if (!CarryFlag)
        {
            goto label_100D_346D_1353D_22748;
        }
    label_100D_3469_13539_34335:
        CheckExternalEvents(cs1, 0x3469);
        // 100D:3469 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:346B jb short 0x3477
        if (CarryFlag)
        {
            goto label_100D_3477_13547_40091;
        }
    label_100D_346D_1353D_22748:
        CheckExternalEvents(cs1, 0x346D);
        // 100D:346D shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:346F shl BL,1
        BL = Alu8.Shl(BL, 1);
        // 100D:3471 jae short 0x347A
        if (!CarryFlag)
        {
            return unknown_100D_347A_1354A(0x0000);
        }
    label_100D_3473_13543_40087:
        CheckExternalEvents(cs1, 0x3473);
        // 100D:3473 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:3475 jae short 0x347A
        if (!CarryFlag)
        {
            return unknown_100D_347A_1354A(0x0000);
        }
    label_100D_3477_13547_40091:
        CheckExternalEvents(cs1, 0x3477);
        // 100D:3477 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        return unknown_100D_347A_1354A(0x0000);
    }

    public virtual Action unknown_100D_348A_1355A(int loadOffset)
    {
    label_100D_348A_1355A_39747:
        CheckExternalEvents(cs1, 0x348A);
        // 100D:348A call near 0x6EFD
        NearCall(cs1, 0x348D, troop_compute_motivation_modifier);
    label_100D_348D_1355D_39752:
        CheckExternalEvents(cs1, 0x348D);
        // 100D:348D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:348F add AL,AL
        AL = Alu8.Add(AL, AL);
        // 100D:3491 add AL,byte ptr DS:[SI+0x16]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)(SI + (sbyte)22)]);
        // 100D:3494 jae short 0x3498
        if (!CarryFlag)
        {
            goto label_100D_3498_13568_39757;
        }
    label_100D_3496_13566_39759:
        CheckExternalEvents(cs1, 0x3496);
        VerifySpeculativeEntryOrFail(cs1, 0x3496, [(byte)0xB0, (byte)0xFF]);
        // 100D:3496 mov AL,0xFF
        AL = (byte)0xFF;
    label_100D_3498_13568_39757:
        CheckExternalEvents(cs1, 0x3498);
        // 100D:3498 mul byte ptr DS:[SI+0x1A]
        ushort result_100D_3498_13568 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)UInt8[DS, (ushort)(SI + (sbyte)26)])));
        AH = unchecked((byte)(result_100D_3498_13568 >> 8));
        AL = unchecked((byte)result_100D_3498_13568);
        // 100D:349B shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:349D shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:349F shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:34A1 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:34A3 jmp short 0x347A
        return unknown_100D_347A_1354A(0x0000);
    }

    public virtual Action unknown_100D_34A5_13575(int loadOffset)
    {
    label_100D_34A5_13575_13711:
        CheckExternalEvents(cs1, 0x34A5);
        // 100D:34A5 push SI
        Stack.Push16(SI);
        // 100D:34A6 push DS
        Stack.Push16(DS);
        // 100D:34A7 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:34A8 push DI
        Stack.Push16(DI);
        // 100D:34A9 mov DI,0x0060
        DI = (ushort)0x0060;
        // 100D:34AC mov CX,0x0033
        CX = (ushort)0x0033;
        // 100D:34AF xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:34B1 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:34B3 pop DI
        DI = Stack.Pop16();
        // 100D:34B4 mov BP,0x34D0
        BP = (ushort)0x34D0;
        // 100D:34B7 call near 0x6639
        NearCall(cs1, 0x34BA, unknown_100D_6639_16709);
    label_100D_34BA_1358A_13739:
        CheckExternalEvents(cs1, 0x34BA);
        // 100D:34BA mov AL,byte ptr DS:[0x0060]
        AL = UInt8[DS, (ushort)0x0060];
        // 100D:34BD add AL,byte ptr DS:[0x007E]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x007E]);
        // 100D:34C1 mov byte ptr DS:[0x0091],AL
        UInt8[DS, (ushort)0x0091] = AL;
        // 100D:34C4 mov AL,byte ptr DS:[0x0061]
        AL = UInt8[DS, (ushort)0x0061];
        // 100D:34C7 add AL,byte ptr DS:[0x007F]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0x007F]);
        // 100D:34CB mov byte ptr DS:[0x0092],AL
        UInt8[DS, (ushort)0x0092] = AL;
        // 100D:34CE pop SI
        SI = Stack.Pop16();
        // 100D:34CF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_34D0_135A0(int loadOffset)
    {
    label_100D_34D0_135A0_22769:
        CheckExternalEvents(cs1, 0x34D0);
        // 100D:34D0 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:34D4 jne short 0x351A
        if (!ZeroFlag)
        {
            return unknown_100D_351A_135EA(0x0000);
        }
    label_100D_34D6_135A6_22772:
        CheckExternalEvents(cs1, 0x34D6);
        // 100D:34D6 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:34D9 mov DX,0x0061
        DX = (ushort)0x0061;
        // 100D:34DC test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:34DE je short 0x34E3
        if (ZeroFlag)
        {
            goto label_100D_34E3_135B3_22777;
        }
    label_100D_34E0_135B0_29775:
        CheckExternalEvents(cs1, 0x34E0);
        // 100D:34E0 mov DX,0x007F
        DX = (ushort)0x007F;
    label_100D_34E3_135B3_22777:
        CheckExternalEvents(cs1, 0x34E3);
        // 100D:34E3 mov BX,DX
        BX = DX;
        // 100D:34E5 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:34E9 jne short 0x34F0
        if (!ZeroFlag)
        {
            goto label_100D_34F0_135C0_23410;
        }
    label_100D_34EB_135BB_22781:
        CheckExternalEvents(cs1, 0x34EB);
        // 100D:34EB dec BX
        BX = Alu16.Dec(BX);
        // 100D:34EC cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:34EE je short 0x351B
        if (ZeroFlag)
        {
            goto label_100D_351B_135EB_22785;
        }
    label_100D_34F0_135C0_23410:
        CheckExternalEvents(cs1, 0x34F0);
        // 100D:34F0 inc byte ptr DS:[BX]
        UInt8[DS, BX] = Alu8.Inc(UInt8[DS, BX]);
        // 100D:34F2 mov AH,AL
        AH = AL;
        // 100D:34F4 and AX,0x030F
        AX = Alu16.And(AX, (ushort)0x030F);
        // 100D:34F7 cmp AH,3
        Alu8.Sub(AH, (byte)0x03);
        // 100D:34FA jne short 0x34FE
        if (!ZeroFlag)
        {
            goto label_100D_34FE_135CE_23416;
        }
    label_100D_34FC_135CC_31318:
        CheckExternalEvents(cs1, 0x34FC);
        // 100D:34FC and AL,0xFC
        AL = Alu8.And(AL, (byte)0xFC);
    label_100D_34FE_135CE_23416:
        CheckExternalEvents(cs1, 0x34FE);
        // 100D:34FE xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3500 mov BX,DX
        BX = DX;
        // 100D:3502 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:3504 inc byte ptr DS:[BX+1]
        UInt8[DS, (ushort)(BX + (sbyte)1)] = Alu8.Inc(UInt8[DS, (ushort)(BX + (sbyte)1)]);
        // 100D:3507 cmp BX,0x007F
        Alu16.Sub(BX, (ushort)0x007F);
        // 100D:350B jae short 0x351A
        if (!CarryFlag)
        {
            return unknown_100D_351A_135EA(0x0000);
        }
    label_100D_350D_135DD_23423:
        CheckExternalEvents(cs1, 0x350D);
        // 100D:350D mov AX,word ptr DS:[SI+0x12]
        AX = UInt16[DS, (ushort)(SI + (sbyte)18)];
        // 100D:3510 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:3513 mov BX,0x0071
        BX = (ushort)0x0071;
        // 100D:3516 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:3518 inc byte ptr DS:[BX]
        UInt8[DS, BX] = Alu8.Inc(UInt8[DS, BX]);
        return unknown_100D_351A_135EA(0x0000);
    label_100D_351B_135EB_22785:
        CheckExternalEvents(cs1, 0x351B);
        // 100D:351B inc byte ptr DS:[0x0090]
        UInt8[DS, (ushort)0x0090] = Alu8.Inc(UInt8[DS, (ushort)0x0090]);
        // 100D:351F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action npc_auto_dialogue(int loadOffset)
    {
    entrydispatcher:
    label_100D_3520_135F0_19840:
        CheckExternalEvents(cs1, 0x3520);
        // 100D:3520 cmp byte ptr DS:[0x47A7],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A7], (byte)0x00);
        // 100D:3525 jne short 0x351A
        if (!ZeroFlag)
        {
            return unknown_100D_351A_135EA(0x0000);
        }
    label_100D_3527_135F7_19843:
        CheckExternalEvents(cs1, 0x3527);
        // 100D:3527 mov AL,byte ptr DS:[SI+0x0E]
        AL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:352A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:352C push SI
        Stack.Push16(SI);
        // 100D:352D call near 0x96F1
        NearCall(cs1, 0x3530, present_room_person_line);
    label_100D_3530_13600_19866:
        CheckExternalEvents(cs1, 0x3530);
        // 100D:3530 pop SI
        SI = Stack.Pop16();
        // 100D:3531 jae short 0x3542
        if (!CarryFlag)
        {
            goto label_100D_3542_13612_30219;
        }
    label_100D_3533_13603_19869:
        CheckExternalEvents(cs1, 0x3533);
        // 100D:3533 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:3536 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:353A call near 0x2AAF
        NearCall(cs1, 0x353D, find_vision_message_from_person);
    label_100D_353D_1360D_19883:
        CheckExternalEvents(cs1, 0x353D);
        // 100D:353D jae short 0x35AC
        if (!CarryFlag)
        {
            return unknown_100D_35AC_1367C(0x0000);
        }
    label_100D_353F_1360F_34747:
        CheckExternalEvents(cs1, 0x353F);
        // 100D:353F call near 0x2B00
        NearCall(cs1, 0x3542, present_vision_message);
    label_100D_3542_13612_30219:
        CheckExternalEvents(cs1, 0x3542);
        // 100D:3542 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:3545 mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:3549 call near 0x2A51
        NearCall(cs1, 0x354C, purge_vision_messages_of_class);
    label_100D_354C_1361C_30223:
        CheckExternalEvents(cs1, 0x354C);
        // 100D:354C mov byte ptr DS:[0x00E7],0
        UInt8[DS, (ushort)0x00E7] = (byte)0x00;
        if (JumpDispatcher.Jump(install_pending_room_action_menu, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action install_pending_room_action_menu(int loadOffset)
    {
    entrydispatcher:
    label_100D_3551_13621_27216:
        CheckExternalEvents(cs1, 0x3551);
        // 100D:3551 inc byte ptr DS:[0x47A7]
        UInt8[DS, (ushort)0x47A7] = Alu8.Inc(UInt8[DS, (ushort)0x47A7]);
        // 100D:3555 cmp byte ptr DS:[0x0023],3
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x03);
        // 100D:355A jne short 0x3572
        if (!ZeroFlag)
        {
            goto label_100D_3572_13642_30225;
        }
    label_100D_355C_1362C_27220:
        CheckExternalEvents(cs1, 0x355C);
        // 100D:355C mov BP,0x1F92
        BP = (ushort)0x1F92;
        // 100D:355F mov BX,0x97CF
        BX = (ushort)0x97CF;
        // 100D:3562 call near 0xD323
        NearCall(cs1, 0x3565, stage_command_submenu);
    label_100D_3565_13635_27224:
        CheckExternalEvents(cs1, 0x3565);
        // 100D:3565 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        // 100D:356B mov word ptr DS:[0x1BF8],0
        UInt16[DS, (ushort)0x1BF8] = (ushort)0x0000;
        // 100D:3571 ret near
        return NearRet((ushort)0x0000);
    label_100D_3572_13642_30225:
        CheckExternalEvents(cs1, 0x3572);
        // 100D:3572 cmp byte ptr DS:[0x0023],4
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x04);
        // 100D:3577 jne short 0x3595
        if (!ZeroFlag)
        {
            goto label_100D_3595_13665_30228;
        }
    label_100D_3579_13649_37335:
        CheckExternalEvents(cs1, 0x3579);
        // 100D:3579 mov BP,0x1F9E
        BP = (ushort)0x1F9E;
        // 100D:357C and byte ptr SS:[BP+0x0B],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)11)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)11)], (byte)0xBF);
        // 100D:3580 mov BX,0x97CF
        BX = (ushort)0x97CF;
        // 100D:3583 call near 0xD323
        NearCall(cs1, 0x3586, stage_command_submenu);
    label_100D_3586_13656_37340:
        CheckExternalEvents(cs1, 0x3586);
        // 100D:3586 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        // 100D:358C mov word ptr DS:[0x1BF8],0
        UInt16[DS, (ushort)0x1BF8] = (ushort)0x0000;
        // 100D:3592 jmp near 0x2FFB
        return rebuild_and_draw_room_nav_panel(0x0000);
    label_100D_3595_13665_30228:
        CheckExternalEvents(cs1, 0x3595);
        // 100D:3595 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:359A jne short 0x35AC
        if (!ZeroFlag)
        {
            return unknown_100D_35AC_1367C(0x0000);
        }
    label_100D_359C_1366C_30231:
        CheckExternalEvents(cs1, 0x359C);
        // 100D:359C cmp byte ptr DS:[0x0023],0x64
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x64);
        // 100D:35A1 jae short 0x35AC
        if (!CarryFlag)
        {
            return unknown_100D_35AC_1367C(0x0000);
        }
    label_100D_35A3_13673_30234:
        CheckExternalEvents(cs1, 0x35A3);
        // 100D:35A3 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:35A6 call near 0x93DF
        NearCall(cs1, 0x35A9, set_dialogue_speaker);
    label_100D_35A9_13679_30237:
        CheckExternalEvents(cs1, 0x35A9);
        // 100D:35A9 call near 0xD280
        NearCall(cs1, 0x35AC, play_pending_panel_fold);
        return unknown_100D_35AC_1367C(0x0000);
    }

    public virtual Action finish_room_screen_setup(int loadOffset)
    {
    entrydispatcher:
    label_100D_35AD_1367D_14499:
        CheckExternalEvents(cs1, 0x35AD);
        // 100D:35AD cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:35B2 jne short 0x35E9
        if (!ZeroFlag)
        {
            goto label_100D_35E9_136B9_22070;
        }
    label_100D_35B4_13684_14502:
        CheckExternalEvents(cs1, 0x35B4);
        // 100D:35B4 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:35B6 mov byte ptr DS:[0x001A],AL
        UInt8[DS, (ushort)0x001A] = AL;
        // 100D:35B9 mov byte ptr DS:[0x47A7],AL
        UInt8[DS, (ushort)0x47A7] = AL;
        // 100D:35BC xchg AL,byte ptr DS:[0x47A6]
        ushort xchgOffset_100D_35BC_1368C = (ushort)0x47A6;
        byte temp_100D_35BC_1368C = AL;
        AL = UInt8[DS, xchgOffset_100D_35BC_1368C];
        UInt8[DS, xchgOffset_100D_35BC_1368C] = unchecked((byte)temp_100D_35BC_1368C);
        // 100D:35C0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:35C2 jne short 0x35AC
        if (!ZeroFlag)
        {
            return unknown_100D_35AC_1367C(0x0000);
        }
    label_100D_35C4_13694_19939:
        CheckExternalEvents(cs1, 0x35C4);
        // 100D:35C4 inc byte ptr DS:[0x001A]
        UInt8[DS, (ushort)0x001A] = Alu8.Inc(UInt8[DS, (ushort)0x001A]);
        // 100D:35C8 cmp byte ptr DS:[0x000B],8
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x08);
        // 100D:35CD jne short 0x35E3
        if (!ZeroFlag)
        {
            goto label_100D_35E3_136B3_19943;
        }
    label_100D_35CF_1369F_30344:
        CheckExternalEvents(cs1, 0x35CF);
        // 100D:35CF mov AX,word ptr DS:[0x00C0]
        AX = UInt16[DS, (ushort)0x00C0];
        // 100D:35D2 and AX,word ptr DS:[0x1158]
        AX = Alu16.And(AX, UInt16[DS, (ushort)0x1158]);
        // 100D:35D6 je short 0x35E3
        if (ZeroFlag)
        {
            goto label_100D_35E3_136B3_19943;
        }
    label_100D_35D8_136A8_33044:
        CheckExternalEvents(cs1, 0x35D8);
        // 100D:35D8 test word ptr DS:[0x0012],8
        Alu16.And(UInt16[DS, (ushort)0x0012], (ushort)0x0008);
        // 100D:35DE je short 0x35E3
        if (ZeroFlag)
        {
            goto label_100D_35E3_136B3_19943;
        }
    label_100D_35E0_136B0_33047:
        CheckExternalEvents(cs1, 0x35E0);
        // 100D:35E0 call near 0x2566
        NearCall(cs1, 0x35E3, unknown_100D_2566_12636);
    label_100D_35E3_136B3_19943:
        CheckExternalEvents(cs1, 0x35E3);
        // 100D:35E3 mov BP,0x3520
        BP = (ushort)0x3520;
        // 100D:35E6 jmp near 0x36EE
        if (JumpDispatcher.Jump(scan_current_room_npcs, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_35E9_136B9_22070:
        CheckExternalEvents(cs1, 0x35E9);
        // 100D:35E9 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:35EB mov byte ptr DS:[0x001A],AL
        UInt8[DS, (ushort)0x001A] = AL;
        // 100D:35EE mov byte ptr DS:[0x47A7],AL
        UInt8[DS, (ushort)0x47A7] = AL;
        // 100D:35F1 mov byte ptr DS:[0x0023],AL
        UInt8[DS, (ushort)0x0023] = AL;
        // 100D:35F4 xchg AL,byte ptr DS:[0x47A6]
        ushort xchgOffset_100D_35F4_136C4 = (ushort)0x47A6;
        byte temp_100D_35F4_136C4 = AL;
        AL = UInt8[DS, xchgOffset_100D_35F4_136C4];
        UInt8[DS, xchgOffset_100D_35F4_136C4] = unchecked((byte)temp_100D_35F4_136C4);
        // 100D:35F8 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:35FA jne short 0x35AC
        if (!ZeroFlag)
        {
            return unknown_100D_35AC_1367C(0x0000);
        }
    label_100D_35FC_136CC_22078:
        CheckExternalEvents(cs1, 0x35FC);
        // 100D:35FC cmp word ptr DS:[0x1152],-1
        Alu16.Sub(UInt16[DS, (ushort)0x1152], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:3601 je short 0x3637
        if (ZeroFlag)
        {
            goto label_100D_3637_13707_22081;
        }
    label_100D_3603_136D3_25252:
        CheckExternalEvents(cs1, 0x3603);
        // 100D:3603 call near 0x40F9
        NearCall(cs1, 0x3606, travel_scan_nearby_location);
    label_100D_3606_136D6_25290:
        CheckExternalEvents(cs1, 0x3606);
        // 100D:3606 call near 0x4182
        NearCall(cs1, 0x3609, travel_route_hostile_zone_check);
    label_100D_3609_136D9_25292:
        CheckExternalEvents(cs1, 0x3609);
        // 100D:3609 cmp byte ptr DS:[0x0023],0
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x00);
        // 100D:360E je short 0x3636
        if (ZeroFlag)
        {
            goto label_100D_3636_13706_22106;
        }
    label_100D_3610_136E0_27133:
        CheckExternalEvents(cs1, 0x3610);
        // 100D:3610 call near 0x366F
        NearCall(cs1, 0x3613, travel_pick_speaking_companion);
    label_100D_3613_136E3_27146:
        CheckExternalEvents(cs1, 0x3613);
        // 100D:3613 js short 0x3636
        if (SignFlag)
        {
            goto label_100D_3636_13706_22106;
        }
    label_100D_3615_136E5_27148:
        CheckExternalEvents(cs1, 0x3615);
        // 100D:3615 call near 0xDBB2
        NearCall(cs1, 0x3618, call_restore_cursor);
    label_100D_3618_136E8_27150:
        CheckExternalEvents(cs1, 0x3618);
        // 100D:3618 call near 0x368B
        NearCall(cs1, 0x361B, travel_show_companion_cabin);
    label_100D_361B_136EB_27186:
        CheckExternalEvents(cs1, 0x361B);
        // 100D:361B push AX
        Stack.Push16(AX);
        // 100D:361C mov AX,0x004B
        AX = (ushort)0x004B;
        // 100D:361F call near 0xE387
        NearCall(cs1, 0x3622, wait_frame_tasks_for_ticks);
    label_100D_3622_136F2_27190:
        CheckExternalEvents(cs1, 0x3622);
        // 100D:3622 pop AX
        AX = Stack.Pop16();
        // 100D:3623 push AX
        Stack.Push16(AX);
        // 100D:3624 call near 0x96D8
        NearCall(cs1, 0x3627, travel_play_flyover_line);
    label_100D_3627_136F7_27207:
        CheckExternalEvents(cs1, 0x3627);
        // 100D:3627 pop AX
        AX = Stack.Pop16();
        // 100D:3628 jb short 0x3636
        if (CarryFlag)
        {
            goto label_100D_3636_13706_22106;
        }
    label_100D_362A_136FA_27210:
        CheckExternalEvents(cs1, 0x362A);
        // 100D:362A mov CL,0x10
        CL = (byte)0x10;
        // 100D:362C mul CL
        ushort result_100D_362C_136FC = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_362C_136FC >> 8));
        AL = unchecked((byte)result_100D_362C_136FC);
        // 100D:362E add AX,0x0FD8
        AX = Alu16.Add(AX, (ushort)0x0FD8);
        // 100D:3631 mov SI,AX
        SI = AX;
        // 100D:3633 call near 0x3551
        NearCall(cs1, 0x3636, install_pending_room_action_menu);
    label_100D_3636_13706_22106:
        CheckExternalEvents(cs1, 0x3636);
        // 100D:3636 ret near
        return NearRet((ushort)0x0000);
    label_100D_3637_13707_22081:
        CheckExternalEvents(cs1, 0x3637);
        // 100D:3637 call near 0x4182
        NearCall(cs1, 0x363A, travel_route_hostile_zone_check);
    label_100D_363A_1370A_22103:
        CheckExternalEvents(cs1, 0x363A);
        // 100D:363A cmp byte ptr DS:[0x0023],0
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x00);
        // 100D:363F je short 0x3636
        if (ZeroFlag)
        {
            goto label_100D_3636_13706_22106;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:363F");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action travel_pick_speaking_companion(int loadOffset)
    {
    label_100D_366F_1373F_27135:
        CheckExternalEvents(cs1, 0x366F);
        // 100D:366F mov AX,word ptr DS:[0x1152]
        AX = UInt16[DS, (ushort)0x1152];
        // 100D:3672 cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:3675 je short 0x3688
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:3675");
        }
    label_100D_3677_13747_27139:
        CheckExternalEvents(cs1, 0x3677);
        // 100D:3677 cmp AH,0xFF
        Alu8.Sub(AH, (byte)0xFF);
        // 100D:367A je short 0x3686
        if (ZeroFlag)
        {
            goto label_100D_3686_13756_27142;
        }
    label_100D_367C_1374C_33649:
        CheckExternalEvents(cs1, 0x367C);
        // 100D:367C test word ptr DS:[0],0x0080
        Alu16.And(UInt16[DS, (ushort)0x0000], (ushort)0x0080);
        // 100D:3682 jne short 0x3686
        if (!ZeroFlag)
        {
            goto label_100D_3686_13756_27142;
        }
    label_100D_3684_13754_33652:
        CheckExternalEvents(cs1, 0x3684);
        // 100D:3684 xchg AL,AH
        byte temp_100D_3684_13754 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_3684_13754);
    label_100D_3686_13756_27142:
        CheckExternalEvents(cs1, 0x3686);
        // 100D:3686 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:3688 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:368A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action travel_show_companion_cabin(int loadOffset)
    {
    label_100D_368B_1375B_27152:
        CheckExternalEvents(cs1, 0x368B);
        // 100D:368B call near 0xE270
        NearCall(cs1, 0x368E, unknown_100D_E270_1E340);
    label_100D_368E_1375E_27154:
        CheckExternalEvents(cs1, 0x368E);
        // 100D:368E or byte ptr DS:[0x4728],1
        UInt8[DS, (ushort)0x4728] = Alu8.Or(UInt8[DS, (ushort)0x4728], (byte)0x01);
        // 100D:3693 mov BL,byte ptr DS:[0x11C9]
        BL = UInt8[DS, (ushort)0x11C9];
        // 100D:3697 and BL,3
        BL = Alu8.And(BL, (byte)0x03);
        // 100D:369A cmp BL,2
        Alu8.Sub(BL, (byte)0x02);
        // 100D:369D je short 0x36CB
        if (ZeroFlag)
        {
            goto label_100D_36CB_1379B_40910;
        }
    label_100D_369F_1376F_27160:
        CheckExternalEvents(cs1, 0x369F);
        // 100D:369F dec BL
        BL = Alu8.Dec(BL);
        // 100D:36A1 jne short 0x36C7
        if (!ZeroFlag)
        {
            goto label_100D_36C7_13797_27182;
        }
    label_100D_36A3_13773_27163:
        CheckExternalEvents(cs1, 0x36A3);
        // 100D:36A3 mov byte ptr DS:[0x473E],1
        UInt8[DS, (ushort)0x473E] = (byte)0x01;
        // 100D:36A8 mov byte ptr DS:[0x47A4],1
        UInt8[DS, (ushort)0x47A4] = (byte)0x01;
        // 100D:36AD push AX
        Stack.Push16(AX);
        // 100D:36AE mov AL,0x34
        AL = (byte)0x34;
        // 100D:36B0 call near 0xC2F2
        NearCall(cs1, 0x36B3, open_resource_and_draw_sprite0);
    label_100D_36B3_13783_27169:
        CheckExternalEvents(cs1, 0x36B3);
        // 100D:36B3 call near 0xC0F4
        NearCall(cs1, 0x36B6, update_screen_palette);
    label_100D_36B6_13786_27171:
        CheckExternalEvents(cs1, 0x36B6);
        // 100D:36B6 call near 0xC412
        NearCall(cs1, 0x36B9, copy_active_framebuffer_to_framebuffer_2);
    label_100D_36B9_13789_27173:
        CheckExternalEvents(cs1, 0x36B9);
        // 100D:36B9 pop AX
        AX = Stack.Pop16();
        // 100D:36BA or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:36BC js short 0x36C4
        if (SignFlag)
        {
            goto label_100D_36C4_13794_27180;
        }
    label_100D_36BE_1378E_27177:
        CheckExternalEvents(cs1, 0x36BE);
        // 100D:36BE mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:36C1 call near 0x978E
        NearCall(cs1, 0x36C4, start_room_lip_sync);
    label_100D_36C4_13794_27180:
        CheckExternalEvents(cs1, 0x36C4);
        // 100D:36C4 call near 0xC4DD
        NearCall(cs1, 0x36C7, present_game_area);
    label_100D_36C7_13797_27182:
        CheckExternalEvents(cs1, 0x36C7);
        // 100D:36C7 call near 0xE283
        NearCall(cs1, 0x36CA, unknown_100D_E283_1E353);
    label_100D_36CA_1379A_27184:
        CheckExternalEvents(cs1, 0x36CA);
        // 100D:36CA ret near
        return NearRet((ushort)0x0000);
    label_100D_36CB_1379B_40910:
        CheckExternalEvents(cs1, 0x36CB);
        // 100D:36CB call near 0x4AEB
        NearCall(cs1, 0x36CE, unknown_100D_4AEB_14BBB);
    label_100D_36CE_1379E_40913:
        CheckExternalEvents(cs1, 0x36CE);
        // 100D:36CE call near 0xC474
        NearCall(cs1, 0x36D1, unknown_100D_C474_1C544);
    label_100D_36D1_137A1_40916:
        CheckExternalEvents(cs1, 0x36D1);
        // 100D:36D1 jmp short 0x36C7
        goto label_100D_36C7_13797_27182;
    }

    public virtual Action run_room_leave_dialogue_scan(int loadOffset)
    {
    label_100D_36D3_137A3_19831:
        CheckExternalEvents(cs1, 0x36D3);
        // 100D:36D3 cmp byte ptr DS:[0x0023],0
        Alu8.Sub(UInt8[DS, (ushort)0x0023], (byte)0x00);
        // 100D:36D8 je short 0x36ED
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:36D8");
        }
    label_100D_36DA_137AA_19834:
        CheckExternalEvents(cs1, 0x36DA);
        // 100D:36DA call near 0x98B2
        NearCall(cs1, 0x36DD, tear_down_prior_talking_head_overlay);
    label_100D_36DD_137AD_19836:
        CheckExternalEvents(cs1, 0x36DD);
        // 100D:36DD mov byte ptr DS:[0x47A7],0
        UInt8[DS, (ushort)0x47A7] = (byte)0x00;
        // 100D:36E2 mov BP,0x3520
        BP = (ushort)0x3520;
        // 100D:36E5 call near 0x36EE
        NearCall(cs1, 0x36E8, scan_current_room_npcs);
    label_100D_36E8_137B8_19885:
        CheckExternalEvents(cs1, 0x36E8);
        // 100D:36E8 mov byte ptr DS:[0x0023],0
        UInt8[DS, (ushort)0x0023] = (byte)0x00;
        // 100D:36ED ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action scan_current_room_npcs(int loadOffset)
    {
    entrydispatcher:
    label_100D_36EE_137BE_13980:
        CheckExternalEvents(cs1, 0x36EE);
        // 100D:36EE push BX
        Stack.Push16(BX);
        // 100D:36EF push DX
        Stack.Push16(DX);
        // 100D:36F0 mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:36F3 mov CX,0x0010
        CX = (ushort)0x0010;
        // 100D:36F6 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:36FA mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
    label_100D_36FE_137CE_13987:
        CheckExternalEvents(cs1, 0x36FE);
        // 100D:36FE cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:3701 jne short 0x371B
        if (!ZeroFlag)
        {
            goto label_100D_371B_137EB_14029;
        }
    label_100D_3703_137D3_13989:
        CheckExternalEvents(cs1, 0x3703);
        // 100D:3703 cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 100D:3705 jne short 0x371B
        if (!ZeroFlag)
        {
            goto label_100D_371B_137EB_14029;
        }
    label_100D_3707_137D7_13992:
        CheckExternalEvents(cs1, 0x3707);
        // 100D:3707 pop DX
        DX = Stack.Pop16();
        // 100D:3708 pop BX
        BX = Stack.Pop16();
        // 100D:3709 push BX
        Stack.Push16(BX);
        // 100D:370A push DX
        Stack.Push16(DX);
        // 100D:370B push CX
        Stack.Push16(CX);
        // 100D:370C push SI
        Stack.Push16(SI);
        // 100D:370D push BP
        Stack.Push16(BP);
        // 100D:370E call near BP
        switch ((ushort)(BP))
        {
            case 0x30B9:
                NearCall(cs1, 0x3710, build_room_person_record_a);
                break;
            case 0x3120:
                NearCall(cs1, 0x3710, build_room_person_record_b);
                break;
            case 0x3520:
                NearCall(cs1, 0x3710, npc_auto_dialogue);
                break;
            case 0x40C9:
                NearCall(cs1, 0x3710, unknown_100D_40C9_14199);
                break;
            case 0x40E6:
                NearCall(cs1, 0x3710, npc_travel_detach_companion);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:370E");
        }
    label_100D_3710_137E0_14023:
        CheckExternalEvents(cs1, 0x3710);
        // 100D:3710 pop BP
        BP = Stack.Pop16();
        // 100D:3711 pop SI
        SI = Stack.Pop16();
        // 100D:3712 pop CX
        CX = Stack.Pop16();
        // 100D:3713 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:3717 mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
    label_100D_371B_137EB_14029:
        CheckExternalEvents(cs1, 0x371B);
        // 100D:371B add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:371E loop 0x36FE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_36FE_137CE_13987;
        }
    label_100D_3720_137F0_14033:
        CheckExternalEvents(cs1, 0x3720);
        // 100D:3720 pop DX
        DX = Stack.Pop16();
        // 100D:3721 pop BX
        BX = Stack.Pop16();
        return unknown_100D_3722_137F2(0x0000);
    }

    public virtual Action unknown_100D_37AD_1387D(int loadOffset)
    {
    label_100D_37AD_1387D_32231:
        CheckExternalEvents(cs1, 0x37AD);
        // 100D:37AD mov AL,0x22
        AL = (byte)0x22;
        // 100D:37AF jmp near 0xC2F2
        return open_resource_and_draw_sprite0(0x0000);
    }

    public virtual Action draw_room_scene(int loadOffset)
    {
    entrydispatcher:
    label_100D_37B2_13882_6658:
        CheckExternalEvents(cs1, 0x37B2);
        // 100D:37B2 call near 0x98E6
        NearCall(cs1, 0x37B5, reset_scene_lip_sync_state);
        if (JumpDispatcher.Jump(unknown_100D_37B5_13885, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_37B5_13885(int loadOffset)
    {
    entrydispatcher:
    label_100D_37B5_13885_6660:
        CheckExternalEvents(cs1, 0x37B5);
        // 100D:37B5 call near 0x4D00
        NearCall(cs1, 0x37B8, unknown_100D_4D00_14DD0);
    label_100D_37B8_13888_6665:
        CheckExternalEvents(cs1, 0x37B8);
        // 100D:37B8 mov word ptr DS:[0x472D],0
        UInt16[DS, (ushort)0x472D] = (ushort)0x0000;
        // 100D:37BE call near 0x5BA8
        NearCall(cs1, 0x37C1, unknown_100D_5BA8_15C78);
    label_100D_37C1_13891_6672:
        CheckExternalEvents(cs1, 0x37C1);
        // 100D:37C1 call near 0xC432
        NearCall(cs1, 0x37C4, clear_game_area);
    label_100D_37C4_13894_6717:
        CheckExternalEvents(cs1, 0x37C4);
        // 100D:37C4 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 100D:37C7 cmp byte ptr DS:[8],AL
        Alu8.Sub(UInt8[DS, (ushort)0x0008], AL);
        // 100D:37CB je short 0x37D5
        if (ZeroFlag)
        {
            goto label_100D_37D5_138A5_6738;
        }
    label_100D_37CD_1389D_6721:
        CheckExternalEvents(cs1, 0x37CD);
        // 100D:37CD mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:37D1 call near 0x3EFE
        NearCall(cs1, 0x37D4, unknown_100D_3EFE_13FCE);
    label_100D_37D4_138A4_6736:
        CheckExternalEvents(cs1, 0x37D4);
        // 100D:37D4 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
    label_100D_37D5_138A5_6738:
        CheckExternalEvents(cs1, 0x37D5);
        // 100D:37D5 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:37D7 js short 0x37DC
        if (SignFlag)
        {
            goto label_100D_37DC_138AC_21945;
        }
    label_100D_37D9_138A9_6740:
        CheckExternalEvents(cs1, 0x37D9);
        // 100D:37D9 jmp near 0x39EC
        goto label_100D_39EC_13ABC_6742;
    label_100D_37DC_138AC_21945:
        CheckExternalEvents(cs1, 0x37DC);
        // 100D:37DC call near 0x3AE9
        NearCall(cs1, 0x37DF, unknown_100D_3AE9_13BB9);
    label_100D_37DF_138AF_21947:
        CheckExternalEvents(cs1, 0x37DF);
        // 100D:37DF or byte ptr DS:[0x47A4],1
        UInt8[DS, (ushort)0x47A4] = Alu8.Or(UInt8[DS, (ushort)0x47A4], (byte)0x01);
        // 100D:37E4 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:37E9 jne short 0x37F4
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(travel_load_flight_view, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        else
        {
            if (JumpDispatcher.Jump(draw_desert_view, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_39EC_13ABC_6742:
        CheckExternalEvents(cs1, 0x39EC);
        // 100D:39EC mov byte ptr DS:[0x22E3],1
        UInt8[DS, (ushort)0x22E3] = (byte)0x01;
        // 100D:39F1 push AX
        Stack.Push16(AX);
        // 100D:39F2 call near 0x3AE9
        NearCall(cs1, 0x39F5, unknown_100D_3AE9_13BB9);
    label_100D_39F5_13AC5_6756:
        CheckExternalEvents(cs1, 0x39F5);
        // 100D:39F5 mov AX,word ptr DS:[4]
        AX = UInt16[DS, (ushort)0x0004];
        // 100D:39F8 cmp AX,0x2005
        Alu16.Sub(AX, (ushort)0x2005);
        // 100D:39FB je short 0x3A1D
        if (ZeroFlag)
        {
            goto label_100D_3A1D_13AED_20172;
        }
    label_100D_39FD_13ACD_6760:
        CheckExternalEvents(cs1, 0x39FD);
        // 100D:39FD cmp AX,0x1005
        Alu16.Sub(AX, (ushort)0x1005);
        // 100D:3A00 je short 0x3A18
        if (ZeroFlag)
        {
            goto label_100D_3A18_13AE8_35328;
        }
    label_100D_3A02_13AD2_6763:
        CheckExternalEvents(cs1, 0x3A02);
        // 100D:3A02 dec AL
        AL = Alu8.Dec(AL);
        // 100D:3A04 jne short 0x3A20
        if (!ZeroFlag)
        {
            goto label_100D_3A20_13AF0_6766;
        }
    label_100D_3A06_13AD6_20480:
        CheckExternalEvents(cs1, 0x3A06);
        // 100D:3A06 cmp AH,0x21
        Alu8.Sub(AH, (byte)0x21);
        // 100D:3A09 jne short 0x3A13
        if (!ZeroFlag)
        {
            goto label_100D_3A13_13AE3_20483;
        }
    label_100D_3A0B_13ADB_33885:
        CheckExternalEvents(cs1, 0x3A0B);
        // 100D:3A0B pop AX
        AX = Stack.Pop16();
        // 100D:3A0C mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:3A10 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:3A12 push AX
        Stack.Push16(AX);
    label_100D_3A13_13AE3_20483:
        CheckExternalEvents(cs1, 0x3A13);
        // 100D:3A13 call near 0x37EB
        NearCall(cs1, 0x3A16, draw_desert_view);
    label_100D_3A16_13AE6_20574:
        CheckExternalEvents(cs1, 0x3A16);
        // 100D:3A16 jmp short 0x3A20
        goto label_100D_3A20_13AF0_6766;
    label_100D_3A18_13AE8_35328:
        CheckExternalEvents(cs1, 0x3A18);
        // 100D:3A18 mov byte ptr DS:[0x22E3],0
        UInt8[DS, (ushort)0x22E3] = (byte)0x00;
    label_100D_3A1D_13AED_20172:
        CheckExternalEvents(cs1, 0x3A1D);
        // 100D:3A1D call near 0x38B4
        NearCall(cs1, 0x3A20, draw_sky);
    label_100D_3A20_13AF0_6766:
        CheckExternalEvents(cs1, 0x3A20);
        // 100D:3A20 pop AX
        AX = Stack.Pop16();
        // 100D:3A21 call near 0x3B59
        NearCall(cs1, 0x3A24, draw_sal_room);
    label_100D_3A24_13AF4_6983:
        CheckExternalEvents(cs1, 0x3A24);
        // 100D:3A24 cmp byte ptr DS:[0x46DF],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DF], (byte)0x00);
        // 100D:3A29 je short 0x3A7C
        if (ZeroFlag)
        {
            return add_room_frame_task(0x0000);
        }
    label_100D_3A2B_13AFB_20178:
        CheckExternalEvents(cs1, 0x3A2B);
        // 100D:3A2B cmp byte ptr DS:[4],1
        Alu8.Sub(UInt8[DS, (ushort)0x0004], (byte)0x01);
        // 100D:3A30 jne short 0x3A7C
        if (!ZeroFlag)
        {
            return add_room_frame_task(0x0000);
        }
    label_100D_3A32_13B02_20576:
        CheckExternalEvents(cs1, 0x3A32);
        // 100D:3A32 cmp byte ptr DS:[0x4731],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x4731], (byte)0xFF);
        // 100D:3A37 je short 0x3A7B
        if (ZeroFlag)
        {
            return unknown_100D_3A7B_13B4B(0x0000);
        }
    label_100D_3A39_13B09_20579:
        CheckExternalEvents(cs1, 0x3A39);
        // 100D:3A39 mov CL,byte ptr DS:[0x46FF]
        CL = UInt8[DS, (ushort)0x46FF];
        // 100D:3A3D xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:3A3F jcxz short 0x3A7B
        if (CX == (ushort)0x0000)
        {
            return unknown_100D_3A7B_13B4B(0x0000);
        }
    label_100D_3A41_13B11_20583:
        CheckExternalEvents(cs1, 0x3A41);
        // 100D:3A41 mov AX,0x388D
        AX = (ushort)0x388D;
        // 100D:3A44 push AX
        Stack.Push16(AX);
        // 100D:3A45 mov byte ptr DS:[0x4731],0
        UInt8[DS, (ushort)0x4731] = (byte)0x00;
        // 100D:3A4A test byte ptr DS:[0x47A4],0x81
        Alu8.And(UInt8[DS, (ushort)0x47A4], (byte)0x81);
        // 100D:3A4F jne short 0x3A7B
        if (!ZeroFlag)
        {
            return unknown_100D_3A7B_13B4B(0x0000);
        }
    label_100D_3A51_13B21_20589:
        CheckExternalEvents(cs1, 0x3A51);
        // 100D:3A51 mov AX,0x0033
        AX = (ushort)0x0033;
        // 100D:3A54 call near 0xC13E
        NearCall(cs1, 0x3A57, open_sprite_bank);
    label_100D_3A57_13B27_20592:
        CheckExternalEvents(cs1, 0x3A57);
        // 100D:3A57 call near 0x3A95
        NearCall(cs1, 0x3A5A, get_orni_position);
    label_100D_3A5A_13B2A_20603:
        CheckExternalEvents(cs1, 0x3A5A);
        // 100D:3A5A mov AX,DX
        AX = DX;
        // 100D:3A5C add AX,0x000C
        AX = Alu16.Add(AX, (ushort)0x000C);
        // 100D:3A5F mov word ptr DS:[0x472D],AX
        UInt16[DS, (ushort)0x472D] = AX;
        // 100D:3A62 mov AX,BX
        AX = BX;
        // 100D:3A64 add AX,8
        AX = Alu16.Add(AX, (ushort)0x0008);
        // 100D:3A67 mov word ptr DS:[0x472F],AX
        UInt16[DS, (ushort)0x472F] = AX;
        return draw_ornis_loop(0x0000);
    }

    public virtual Action draw_desert_view(int loadOffset)
    {
    entrydispatcher:
    label_100D_37EB_138BB_20485:
        CheckExternalEvents(cs1, 0x37EB);
        // 100D:37EB call near 0x380C
        NearCall(cs1, 0x37EE, draw_outdoor_backdrop);
    label_100D_37EE_138BE_20510:
        CheckExternalEvents(cs1, 0x37EE);
        // 100D:37EE call near 0x4E12
        NearCall(cs1, 0x37F1, unknown_100D_4E12_14EE2);
    label_100D_37F1_138C1_20564:
        CheckExternalEvents(cs1, 0x37F1);
        // 100D:37F1 jmp near 0x4D06
    label_100D_4D06_14DD6_20566:
        CheckExternalEvents(cs1, 0x4D06);
        // 100D:4D06 mov byte ptr DS:[0x00F6],0
        UInt8[DS, (ushort)0x00F6] = (byte)0x00;
        // 100D:4D0B mov DI,word ptr DS:[0x1150]
        DI = UInt16[DS, (ushort)0x1150];
        // 100D:4D0F mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:4D12 cmp DX,word ptr DS:[4]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x0004]);
        // 100D:4D16 jne short 0x4D56
        if (!ZeroFlag)
        {
            goto label_100D_4D56_14E26_20572;
        }
    label_100D_4D18_14DE8_27950:
        CheckExternalEvents(cs1, 0x4D18);
        // 100D:4D18 mov AX,word ptr DS:[0x4733]
        AX = UInt16[DS, (ushort)0x4733];
        // 100D:4D1B or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:4D1D je short 0x4D56
        if (ZeroFlag)
        {
            goto label_100D_4D56_14E26_20572;
        }
    label_100D_4D1F_14DEF_30635:
        CheckExternalEvents(cs1, 0x4D1F);
        // 100D:4D1F mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:4D23 cmp BL,byte ptr DS:[DI+4]
        Alu8.Sub(BL, UInt8[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:4D26 jne short 0x4D56
        if (!ZeroFlag)
        {
            goto label_100D_4D56_14E26_20572;
        }
    label_100D_4D28_14DF8_30639:
        CheckExternalEvents(cs1, 0x4D28);
        // 100D:4D28 cmp BH,AH
        Alu8.Sub(BH, AH);
        // 100D:4D2A ja short 0x4D56
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_4D56_14E26_20572;
        }
    label_100D_4D2C_14DFC_30642:
        CheckExternalEvents(cs1, 0x4D2C);
        // 100D:4D2C push AX
        Stack.Push16(AX);
        // 100D:4D2D push BX
        Stack.Push16(BX);
        // 100D:4D2E inc byte ptr DS:[0x00F6]
        UInt8[DS, (ushort)0x00F6] = Alu8.Inc(UInt8[DS, (ushort)0x00F6]);
        // 100D:4D32 mov AH,1
        AH = (byte)0x01;
        // 100D:4D34 call near 0x4D57
        NearCall(cs1, 0x4D37, unknown_100D_4D57_14E27);
    label_100D_4D37_14E07_30702:
        CheckExternalEvents(cs1, 0x4D37);
        // 100D:4D37 call near 0x4BDF
        NearCall(cs1, 0x4D3A, unknown_100D_4BDF_14CAF);
    label_100D_4D3A_14E0A_30822:
        CheckExternalEvents(cs1, 0x4D3A);
        // 100D:4D3A call near 0xC412
        NearCall(cs1, 0x4D3D, copy_active_framebuffer_to_framebuffer_2);
    label_100D_4D3D_14E0D_30824:
        CheckExternalEvents(cs1, 0x4D3D);
        // 100D:4D3D pop BX
        BX = Stack.Pop16();
        // 100D:4D3E pop AX
        AX = Stack.Pop16();
        // 100D:4D3F cmp BH,AL
        Alu8.Sub(BH, AL);
        // 100D:4D41 ja short 0x4D56
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_4D56_14E26_20572;
        }
    label_100D_4D43_14E13_30829:
        CheckExternalEvents(cs1, 0x4D43);
        // 100D:4D43 mov AL,5
        AL = (byte)0x05;
        // 100D:4D45 call near 0xAB15
        NearCall(cs1, 0x4D48, audio_start_voc);
    label_100D_4D48_14E18_30832:
        CheckExternalEvents(cs1, 0x4D48);
        // 100D:4D48 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:4D4A call near 0x4D57
        NearCall(cs1, 0x4D4D, unknown_100D_4D57_14E27);
    label_100D_4D4D_14E1D_30835:
        CheckExternalEvents(cs1, 0x4D4D);
        // 100D:4D4D mov SI,0x4BB9
        SI = (ushort)0x4BB9;
        // 100D:4D50 mov BP,0x0010
        BP = (ushort)0x0010;
        // 100D:4D53 call near 0xDA25
        NearCall(cs1, 0x4D56, add_frame_task);
    label_100D_4D56_14E26_20572:
        CheckExternalEvents(cs1, 0x4D56);
        // 100D:4D56 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action travel_load_flight_view(int loadOffset)
    {
    entrydispatcher:
    label_100D_37F4_138C4_21951:
        CheckExternalEvents(cs1, 0x37F4);
        // 100D:37F4 mov byte ptr DS:[0x4728],0
        UInt8[DS, (ushort)0x4728] = (byte)0x00;
        // 100D:37F9 call near 0x4988
        NearCall(cs1, 0x37FC, travel_minimap_setup);
    label_100D_37FC_138CC_22000:
        CheckExternalEvents(cs1, 0x37FC);
        // 100D:37FC call near 0x4A5A
        NearCall(cs1, 0x37FF, travel_trail_redraw);
    label_100D_37FF_138CF_22027:
        CheckExternalEvents(cs1, 0x37FF);
        // 100D:37FF mov AX,word ptr DS:[0x487E]
        AX = UInt16[DS, (ushort)0x487E];
        // 100D:3802 call near 0xCA1B
        NearCall(cs1, 0x3805, hnm_load_first_frame);
    label_100D_3805_138D5_22066:
        CheckExternalEvents(cs1, 0x3805);
        // 100D:3805 call far dword ptr DS:[0x3959]
        ushort targetSegment_22066 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3959 + (ushort)0x0002)]));
        ushort targetOffset_22066 = unchecked((ushort)(UInt16[DS, (ushort)0x3959]));
        if (targetSegment_22066 == cs2 && targetOffset_22066 == 0x017B)
        {
            FarCall(cs1, 0x3809, cs2, unknown_3358_017B_336FB);
            goto label_100D_3809_138D9_22068;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_22066:X4}:{targetOffset_22066:X4} at 100D:3805");
    label_100D_3809_138D9_22068:
        CheckExternalEvents(cs1, 0x3809);
        // 100D:3809 jmp near 0x388D
        return set_sky_palette(0x0000);
    }

    public virtual Action draw_outdoor_backdrop(int loadOffset)
    {
    label_100D_380C_138DC_20487:
        CheckExternalEvents(cs1, 0x380C);
        // 100D:380C mov byte ptr DS:[0x22E3],1
        UInt8[DS, (ushort)0x22E3] = (byte)0x01;
        // 100D:3811 call near 0x388D
        NearCall(cs1, 0x3814, set_sky_palette);
    label_100D_3814_138E4_20490:
        CheckExternalEvents(cs1, 0x3814);
        // 100D:3814 mov SI,word ptr DS:[0x1150]
        SI = UInt16[DS, (ushort)0x1150];
        // 100D:3818 mov AX,0x1972
        AX = (ushort)0x1972;
        // 100D:381B call near 0x5E4F
        NearCall(cs1, 0x381E, calc_sal_index);
    label_100D_381E_138EE_20494:
        CheckExternalEvents(cs1, 0x381E);
        // 100D:381E mov BX,AX
        BX = AX;
        // 100D:3820 mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:3824 mov AX,word ptr DS:[6]
        AX = UInt16[DS, (ushort)0x0006];
        // 100D:3827 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:3829 mov AL,0
        AL = (byte)0x00;
        // 100D:382B je short 0x3834
        if (ZeroFlag)
        {
            goto label_100D_3834_13904_20501;
        }
    label_100D_382D_138FD_27898:
        CheckExternalEvents(cs1, 0x382D);
        // 100D:382D cmp DX,word ptr DS:[SI+2]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:3830 jne short 0x384A
        if (!ZeroFlag)
        {
            goto label_100D_384A_1391A_32188;
        }
    label_100D_3832_13902_27901:
        CheckExternalEvents(cs1, 0x3832);
        // 100D:3832 mov AL,AH
        AL = AH;
    label_100D_3834_13904_20501:
        CheckExternalEvents(cs1, 0x3834);
        // 100D:3834 cmp AL,byte ptr DS:[BX+5]
        Alu8.Sub(AL, UInt8[DS, (ushort)(BX + (sbyte)5)]);
        // 100D:3837 jae short 0x384A
        if (!CarryFlag)
        {
            goto label_100D_384A_1391A_32188;
        }
    label_100D_3839_13909_20504:
        CheckExternalEvents(cs1, 0x3839);
        // 100D:3839 add AL,byte ptr DS:[BX]
        AL = Alu8.Add(AL, UInt8[DS, BX]);
        // 100D:383B cmp AL,0x7F
        Alu8.Sub(AL, (byte)0x7F);
        // 100D:383D jne short 0x3847
        if (!ZeroFlag)
        {
            goto label_100D_3847_13917_20508;
        }
    label_100D_383F_1390F_33890:
        CheckExternalEvents(cs1, 0x383F);
        // 100D:383F mov AH,byte ptr DS:[SI]
        AH = UInt8[DS, SI];
        // 100D:3841 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:3843 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 100D:3845 sub AL,5
        AL = Alu8.Sub(AL, (byte)0x05);
    label_100D_3847_13917_20508:
        CheckExternalEvents(cs1, 0x3847);
        // 100D:3847 jmp near 0xC2F2
        return open_resource_and_draw_sprite0(0x0000);
    label_100D_384A_1391A_32188:
        CheckExternalEvents(cs1, 0x384A);
        // 100D:384A mov DI,word ptr DS:[0x1150]
        DI = UInt16[DS, (ushort)0x1150];
        // 100D:384E test byte ptr DS:[DI+0x0A],1
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x01);
        // 100D:3852 jne short 0x3872
        if (!ZeroFlag)
        {
            goto label_100D_3872_13942_40982;
        }
    label_100D_3854_13924_32192:
        CheckExternalEvents(cs1, 0x3854);
        // 100D:3854 call near 0x407E
        NearCall(cs1, 0x3857, get_map_position);
    label_100D_3857_13927_32194:
        CheckExternalEvents(cs1, 0x3857);
        // 100D:3857 call near 0xB58B
        NearCall(cs1, 0x385A, map_position_to_offset);
    label_100D_385A_1392A_32196:
        CheckExternalEvents(cs1, 0x385A);
        // 100D:385A dec DI
        DI = Alu16.Dec(DI);
        // 100D:385B mov CX,4
        CX = (ushort)0x0004;
    label_100D_385E_1392E_32199:
        CheckExternalEvents(cs1, 0x385E);
        // 100D:385E mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:3861 inc DI
        DI = Alu16.Inc(DI);
        // 100D:3862 and AL,0x30
        AL = Alu8.And(AL, (byte)0x30);
        // 100D:3864 cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:3866 je short 0x3872
        if (ZeroFlag)
        {
            goto label_100D_3872_13942_40982;
        }
    label_100D_3868_13938_32204:
        CheckExternalEvents(cs1, 0x3868);
        // 100D:3868 loop 0x385E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_385E_1392E_32199;
        }
    label_100D_386A_1393A_32207:
        CheckExternalEvents(cs1, 0x386A);
        // 100D:386A mov BX,0x0013
        BX = (ushort)0x0013;
        // 100D:386D mov CX,0x0042
        CX = (ushort)0x0042;
        // 100D:3870 jmp short 0x3878
        goto label_100D_3878_13948_32211;
    label_100D_3872_13942_40982:
        CheckExternalEvents(cs1, 0x3872);
        // 100D:3872 mov BX,0x000A
        BX = (ushort)0x000A;
        // 100D:3875 mov CX,0x0088
        CX = (ushort)0x0088;
    label_100D_3878_13948_32211:
        CheckExternalEvents(cs1, 0x3878);
        // 100D:3878 mov AX,word ptr DS:[6]
        AX = UInt16[DS, (ushort)0x0006];
        // 100D:387B xchg AL,AH
        byte temp_100D_387B_1394B = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_387B_1394B);
        // 100D:387D xor AX,word ptr DS:[4]
        AX = Alu16.Xor(AX, UInt16[DS, (ushort)0x0004]);
        // 100D:3881 inc AX
        AX = Alu16.Inc(AX);
        // 100D:3882 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:3884 div BX
        ushort divisor_100D_3884_13954 = BX;
        uint dividend_100D_3884_13954 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_3884_13954 = Alu16.Div(unchecked((uint)dividend_100D_3884_13954), unchecked((ushort)divisor_100D_3884_13954));
        AX = unchecked((ushort)quotient_100D_3884_13954);
        DX = unchecked((ushort)(dividend_100D_3884_13954 % unchecked((uint)divisor_100D_3884_13954)));
        // 100D:3886 mov AX,DX
        AX = DX;
        // 100D:3888 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:388A jmp near 0xC2F2
        return open_resource_and_draw_sprite0(0x0000);
    }

    public virtual Action set_sky_palette(int loadOffset)
    {
    label_100D_388D_1395D_12775:
        CheckExternalEvents(cs1, 0x388D);
        // 100D:388D mov byte ptr DS:[0x46DF],1
        UInt8[DS, (ushort)0x46DF] = (byte)0x01;
        // 100D:3892 call near 0x395C
        NearCall(cs1, 0x3895, sky_palette_id_from_game_time);
    label_100D_3895_13965_12789:
        CheckExternalEvents(cs1, 0x3895);
        // 100D:3895 cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:389A je short 0x38AD
        if (ZeroFlag)
        {
            goto label_100D_38AD_1397D_12792;
        }
    label_100D_389C_1396C_26924:
        CheckExternalEvents(cs1, 0x389C);
        // 100D:389C cmp byte ptr DS:[0x46D6],BL
        Alu8.Sub(UInt8[DS, (ushort)0x46D6], BL);
        // 100D:38A0 je short 0x38B3
        if (ZeroFlag)
        {
            goto label_100D_38B3_13983_12811;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:38A0");
        }
    label_100D_38AD_1397D_12792:
        CheckExternalEvents(cs1, 0x38AD);
        // 100D:38AD call near 0x3971
        NearCall(cs1, 0x38B0, unknown_100D_3971_13A41);
    label_100D_38B0_13980_12794:
        CheckExternalEvents(cs1, 0x38B0);
        // 100D:38B0 call near 0x398C
        NearCall(cs1, 0x38B3, unknown_100D_398C_13A5C);
    label_100D_38B3_13983_12811:
        CheckExternalEvents(cs1, 0x38B3);
        // 100D:38B3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_38A2_13972(int loadOffset)
    {
    label_100D_38A2_13972_10914:
        CheckExternalEvents(cs1, 0x38A2);
        // 100D:38A2 mov byte ptr DS:[0x46D7],0x30
        UInt8[DS, (ushort)0x46D7] = (byte)0x30;
        // 100D:38A7 call near 0x3971
        NearCall(cs1, 0x38AA, unknown_100D_3971_13A41);
    label_100D_38AA_1397A_10920:
        CheckExternalEvents(cs1, 0x38AA);
        // 100D:38AA jmp near 0x39B9
        return unknown_100D_39B9_13A89(0x0000);
    }

    public virtual Action draw_sky(int loadOffset)
    {
    label_100D_38B4_13984_12773:
        CheckExternalEvents(cs1, 0x38B4);
        // 100D:38B4 call near 0x388D
        NearCall(cs1, 0x38B7, set_sky_palette);
    label_100D_38B7_13987_12813:
        CheckExternalEvents(cs1, 0x38B7);
        // 100D:38B7 mov AX,0x0028
        AX = (ushort)0x0028;
        // 100D:38BA call near 0xC13E
        NearCall(cs1, 0x38BD, open_sprite_bank);
    label_100D_38BD_1398D_12816:
        CheckExternalEvents(cs1, 0x38BD);
        // 100D:38BD xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:38BF mov BP,0x0014
        BP = (ushort)0x0014;
        // 100D:38C2 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:38C4 mov CX,4
        CX = (ushort)0x0004;
    label_100D_38C7_13997_12821:
        CheckExternalEvents(cs1, 0x38C7);
        // 100D:38C7 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:38C9 push CX
        Stack.Push16(CX);
        // 100D:38CA push BP
        Stack.Push16(BP);
    label_100D_38CB_1399B_12824:
        CheckExternalEvents(cs1, 0x38CB);
        // 100D:38CB push AX
        Stack.Push16(AX);
        // 100D:38CC call near 0xC2FD
        NearCall(cs1, 0x38CF, unknown_100D_C2FD_1C3CD);
    label_100D_38CF_1399F_12826:
        CheckExternalEvents(cs1, 0x38CF);
        // 100D:38CF pop AX
        AX = Stack.Pop16();
        // 100D:38D0 add DX,0x0028
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)40)));
        // 100D:38D3 cmp DX,0x0140
        Alu16.Sub(DX, (ushort)0x0140);
        // 100D:38D7 jb short 0x38CB
        if (CarryFlag)
        {
            goto label_100D_38CB_1399B_12824;
        }
    label_100D_38D9_139A9_12832:
        CheckExternalEvents(cs1, 0x38D9);
        // 100D:38D9 pop BP
        BP = Stack.Pop16();
        // 100D:38DA pop CX
        CX = Stack.Pop16();
        // 100D:38DB inc AX
        AX = Alu16.Inc(AX);
        // 100D:38DC add BX,BP
        BX = Alu16.Add(BX, BP);
        // 100D:38DE loop 0x38C7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_38C7_13997_12821;
        }
        else
        {
            return unknown_100D_38E0_139B0(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action loc_038e1_sky_refresh(int loadOffset)
    {
    label_100D_38E1_139B1_15050:
        CheckExternalEvents(cs1, 0x38E1);
        // 100D:38E1 cmp byte ptr DS:[0x46DF],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DF], (byte)0x00);
        // 100D:38E6 je short 0x38E0
        if (ZeroFlag)
        {
            return unknown_100D_38E0_139B0(0x0000);
        }
    label_100D_38E8_139B8_20663:
        CheckExternalEvents(cs1, 0x38E8);
        // 100D:38E8 call near 0x395C
        NearCall(cs1, 0x38EB, sky_palette_id_from_game_time);
    label_100D_38EB_139BB_20665:
        CheckExternalEvents(cs1, 0x38EB);
        // 100D:38EB cmp byte ptr DS:[0x46D6],BL
        Alu8.Sub(UInt8[DS, (ushort)0x46D6], BL);
        // 100D:38EF je short 0x38E0
        if (ZeroFlag)
        {
            return unknown_100D_38E0_139B0(0x0000);
        }
        else
        {
            return arm_sky_palette_fade(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action arm_sky_palette_fade(int loadOffset)
    {
    label_100D_38F1_139C1_12925:
        CheckExternalEvents(cs1, 0x38F1);
        // 100D:38F1 call near 0x3971
        NearCall(cs1, 0x38F4, unknown_100D_3971_13A41);
    label_100D_38F4_139C4_12927:
        CheckExternalEvents(cs1, 0x38F4);
        // 100D:38F4 call near 0x39B9
        NearCall(cs1, 0x38F7, unknown_100D_39B9_13A89);
    label_100D_38F7_139C7_12929:
        CheckExternalEvents(cs1, 0x38F7);
        // 100D:38F7 mov AL,0x40
        AL = (byte)0x40;
        // 100D:38F9 xchg AL,byte ptr DS:[0x46D7]
        ushort xchgOffset_100D_38F9_139C9 = (ushort)0x46D7;
        byte temp_100D_38F9_139C9 = AL;
        AL = UInt8[DS, xchgOffset_100D_38F9_139C9];
        UInt8[DS, xchgOffset_100D_38F9_139C9] = unchecked((byte)temp_100D_38F9_139C9);
        // 100D:38FD or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:38FF jne short 0x38E0
        if (!ZeroFlag)
        {
            return unknown_100D_38E0_139B0(0x0000);
        }
        else
        {
            return unknown_100D_3901_139D1(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_3901_139D1(int loadOffset)
    {
    label_100D_3901_139D1_10943:
        CheckExternalEvents(cs1, 0x3901);
        // 100D:3901 mov SI,0x3916
        SI = (ushort)0x3916;
        // 100D:3904 mov BP,0x0010
        BP = (ushort)0x0010;
        // 100D:3907 jmp near 0xDA25
        return add_frame_task(0x0000);
    }

    public virtual Action drain_sky_fade(int loadOffset)
    {
    label_100D_390A_139DA_27979:
        CheckExternalEvents(cs1, 0x390A);
        // 100D:390A cmp byte ptr DS:[0x46D7],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D7], (byte)0x00);
        // 100D:390F je short 0x38E0
        if (ZeroFlag)
        {
            return unknown_100D_38E0_139B0(0x0000);
        }
    label_100D_3911_139E1_34635:
        CheckExternalEvents(cs1, 0x3911);
        // 100D:3911 call near 0x3916
        NearCall(cs1, 0x3914, tick_sky_fade);
    label_100D_3914_139E4_34637:
        CheckExternalEvents(cs1, 0x3914);
        // 100D:3914 jmp short 0x390A
        goto label_100D_390A_139DA_27979;
    }

    public virtual Action tick_sky_fade(int loadOffset)
    {
    label_100D_3916_139E6_10947:
        CheckExternalEvents(cs1, 0x3916);
        // 100D:3916 cmp byte ptr DS:[0x46DF],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DF], (byte)0x00);
        // 100D:391B je short 0x3950
        if (ZeroFlag)
        {
            return unknown_100D_3950_13A20(0x0000);
        }
        else
        {
            return sky_palette_fade_step(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }
}
