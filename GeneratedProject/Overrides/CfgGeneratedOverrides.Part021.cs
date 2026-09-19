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
    public virtual Action stage_06_play(int loadOffset)
    {
    label_100D_CF1B_1CFEB_5666:
        CheckExternalEvents(cs1, 0xCF1B);
        // 100D:CF1B push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:CF1F call near 0xC08E
        NearCall(cs1, 0xCF22, set_screen_as_active_framebuffer);
    label_100D_CF22_1CFF2_5669:
        CheckExternalEvents(cs1, 0xCF22);
        // 100D:CF22 mov SI,word ptr DS:[0x3622]
        SI = UInt16[DS, (ushort)0x3622];
        // 100D:CF26 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CF27 cmp AX,word ptr DS:[0xDBE8]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBE8]);
        // 100D:CF2B ja short 0xCF30
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_CF30_1D000_5674;
        }
    label_100D_CF2D_1CFFD_5765:
        CheckExternalEvents(cs1, 0xCF2D);
        // 100D:CF2D call near 0xCF4B
        NearCall(cs1, 0xCF30, unknown_100D_CF4B_1D01B);
    label_100D_CF30_1D000_5674:
        CheckExternalEvents(cs1, 0xCF30);
        // 100D:CF30 call near 0xC9E8
        NearCall(cs1, 0xCF33, hnm_do_frame_skippable);
    label_100D_CF33_1D003_5699:
        CheckExternalEvents(cs1, 0xCF33);
        // 100D:CF33 jb short 0xCF3B
        if (CarryFlag)
        {
            goto label_100D_CF3B_1D00B_5849;
        }
    label_100D_CF35_1D005_5701:
        CheckExternalEvents(cs1, 0xCF35);
        // 100D:CF35 call near 0xCC85
        NearCall(cs1, 0xCF38, unknown_100D_CC85_1CD55);
    label_100D_CF38_1D008_5703:
        CheckExternalEvents(cs1, 0xCF38);
        // 100D:CF38 je short 0xCF22
        if (ZeroFlag)
        {
            goto label_100D_CF22_1CFF2_5669;
        }
    label_100D_CF3A_1D00A_5847:
        CheckExternalEvents(cs1, 0xCF3A);
        // 100D:CF3A clc
        CarryFlag = false;
    label_100D_CF3B_1D00B_5849:
        CheckExternalEvents(cs1, 0xCF3B);
        // 100D:CF3B pushf
        Stack.Push16(FlagRegister16);
        // 100D:CF3C call near 0xCA01
        NearCall(cs1, 0xCF3F, hnm_close);
    label_100D_CF3F_1D00F_5851:
        CheckExternalEvents(cs1, 0xCF3F);
        // 100D:CF3F call near 0xAC14
        NearCall(cs1, 0xCF42, pcm_stop_voc);
    label_100D_CF42_1D012_5881:
        CheckExternalEvents(cs1, 0xCF42);
        // 100D:CF42 call near 0xAD57
        NearCall(cs1, 0xCF45, play_music_morning_hsq);
    label_100D_CF45_1D015_5883:
        CheckExternalEvents(cs1, 0xCF45);
        // 100D:CF45 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_CF46_1D016_5885:
        CheckExternalEvents(cs1, 0xCF46);
        // 100D:CF46 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_CF46_1D016 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_CF46_1D016 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_CF46_1D016 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_CF46_1D016);
        // 100D:CF4A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CF4B_1D01B(int loadOffset)
    {
    label_100D_CF4B_1D01B_5767:
        CheckExternalEvents(cs1, 0xCF4B);
        // 100D:CF4B mov AX,SI
        AX = SI;
        // 100D:CF4D mov word ptr DS:[0x3622],AX
        UInt16[DS, (ushort)0x3622] = AX;
        // 100D:CF50 sub AX,0x35A8
        AX = Alu16.Sub(AX, (ushort)0x35A8);
        // 100D:CF53 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:CF55 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:CF57 jae short 0xCF61
        if (!CarryFlag)
        {
            goto label_100D_CF61_1D031_5838;
        }
    label_100D_CF59_1D029_5774:
        CheckExternalEvents(cs1, 0xCF59);
        // 100D:CF59 mov BX,0x00BE
        BX = (ushort)0x00BE;
        // 100D:CF5C xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:CF5E jmp near 0xC22F
        return draw_active_bank_sprite(0x0000);
    label_100D_CF61_1D031_5838:
        CheckExternalEvents(cs1, 0xCF61);
        // 100D:CF61 mov DI,0xED80
        DI = (ushort)0xED80;
        // 100D:CF64 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:CF68 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:CF6A mov CX,0x0B40
        CX = (ushort)0x0B40;
        // 100D:CF6D rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:CF6F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_phrase_or_command_string(int loadOffset)
    {
    label_100D_CF70_1D040_11739:
        CheckExternalEvents(cs1, 0xCF70);
        // 100D:CF70 push BX
        Stack.Push16(BX);
        // 100D:CF71 dec SI
        SI = Alu16.Dec(SI);
        // 100D:CF72 test SI,0x0800
        Alu16.And(SI, (ushort)0x0800);
        // 100D:CF76 je short 0xCF95
        if (ZeroFlag)
        {
            goto label_100D_CF95_1D065_11744;
        }
    label_100D_CF78_1D048_15695:
        CheckExternalEvents(cs1, 0xCF78);
        // 100D:CF78 call near 0xD00F
        NearCall(cs1, 0xCF7B, load_phrasexx_hsq);
    label_100D_CF7B_1D04B_15703:
        CheckExternalEvents(cs1, 0xCF7B);
        // 100D:CF7B les BX,word ptr DS:[0x47B0]
        ushort lxsOffset_100D_CF7B_1D04B = (ushort)0x47B0;
        ushort lxsValue_100D_CF7B_1D04B = UInt16[DS, lxsOffset_100D_CF7B_1D04B];
        ushort lxsSegment_100D_CF7B_1D04B = UInt16[DS, (ushort)(lxsOffset_100D_CF7B_1D04B + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_100D_CF7B_1D04B);
        ES = unchecked((ushort)lxsSegment_100D_CF7B_1D04B);
        // 100D:CF7F and SI,0x07FF
        SI = Alu16.And(SI, (ushort)0x07FF);
        // 100D:CF83 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:CF85 mov SI,word ptr ES:[BX+SI]
        SI = UInt16[ES, (ushort)(BX + SI)];
        // 100D:CF88 mov BX,word ptr ES:[BX]
        BX = UInt16[ES, BX];
        // 100D:CF8B mov BX,word ptr ES:[BX-2]
        BX = UInt16[ES, (ushort)(BX + (sbyte)-2)];
        // 100D:CF8F mov word ptr DS:[0x47B4],BX
        UInt16[DS, (ushort)0x47B4] = BX;
        // 100D:CF93 pop BX
        BX = Stack.Pop16();
        // 100D:CF94 ret near
        return NearRet((ushort)0x0000);
    label_100D_CF95_1D065_11744:
        CheckExternalEvents(cs1, 0xCF95);
        // 100D:CF95 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:CF97 les BX,word ptr DS:[0x47AC]
        ushort lxsOffset_100D_CF97_1D067 = (ushort)0x47AC;
        ushort lxsValue_100D_CF97_1D067 = UInt16[DS, lxsOffset_100D_CF97_1D067];
        ushort lxsSegment_100D_CF97_1D067 = UInt16[DS, (ushort)(lxsOffset_100D_CF97_1D067 + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_100D_CF97_1D067);
        ES = unchecked((ushort)lxsSegment_100D_CF97_1D067);
        // 100D:CF9B mov SI,word ptr ES:[BX+SI]
        SI = UInt16[ES, (ushort)(BX + SI)];
        // 100D:CF9E pop BX
        BX = Stack.Pop16();
        // 100D:CF9F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action check_amr_or_eng_language(int loadOffset)
    {
    label_100D_CFA0_1D070_12973:
        CheckExternalEvents(cs1, 0xCFA0);
        // 100D:CFA0 call near 0xAE2F
        NearCall(cs1, 0xCFA3, check_pcm_enabled);
    label_100D_CFA3_1D073_12975:
        CheckExternalEvents(cs1, 0xCFA3);
        // 100D:CFA3 je short 0xCFB8
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CFA3");
        }
    label_100D_CFA5_1D075_12977:
        CheckExternalEvents(cs1, 0xCFA5);
        // 100D:CFA5 mov AL,byte ptr DS:[0xCEEB]
        AL = UInt8[DS, (ushort)0xCEEB];
        // 100D:CFA8 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:CFAA je short 0xCFB0
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CFAA");
        }
    label_100D_CFB0_1D080_12981:
        CheckExternalEvents(cs1, 0xCFB0);
        // 100D:CFB0 mov AL,2
        AL = (byte)0x02;
        // 100D:CFB2 mov byte ptr DS:[0x28E7],AL
        UInt8[DS, (ushort)0x28E7] = AL;
        // 100D:CFB5 mov byte ptr DS:[0x28E8],AL
        UInt8[DS, (ushort)0x28E8] = AL;
        // 100D:CFB8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action build_voc_base_table(int loadOffset)
    {
    label_100D_CFB9_1D089_2860:
        CheckExternalEvents(cs1, 0xCFB9);
        // 100D:CFB9 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:CFBB mov DI,0xD7F4
        DI = (ushort)0xD7F4;
        // 100D:CFBE push DS
        Stack.Push16(DS);
        // 100D:CFBF pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_CFC0_1D090_2865:
        CheckExternalEvents(cs1, 0xCFC0);
        // 100D:CFC0 mov SI,word ptr DS:[BX-21898]
        SI = UInt16[DS, (ushort)(BX + (short)-21898)];
        // 100D:CFC4 cmp word ptr DS:[SI],-1
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:CFC7 jne short 0xCFCE
        if (!ZeroFlag)
        {
            goto label_100D_CFCE_1D09E_2872;
        }
    label_100D_CFC9_1D099_2868:
        CheckExternalEvents(cs1, 0xCFC9);
        // 100D:CFC9 add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:CFCC jmp short 0xCFC0
        goto label_100D_CFC0_1D090_2865;
    label_100D_CFCE_1D09E_2872:
        CheckExternalEvents(cs1, 0xCFCE);
        // 100D:CFCE mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:CFD1 xchg AL,AH
        byte temp_100D_CFD1_1D0A1 = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_CFD1_1D0A1);
        // 100D:CFD3 and AX,0x03FF
        AX = Alu16.And(AX, (ushort)0x03FF);
        // 100D:CFD6 dec AX
        AX = Alu16.Dec(AX);
        // 100D:CFD7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:CFD8 and BX,-16
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:CFDB add BX,0x0010
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:CFDE cmp BX,0x0110
        Alu16.Sub(BX, (ushort)0x0110);
        // 100D:CFE2 jb short 0xCFC0
        if (CarryFlag)
        {
            goto label_100D_CFC0_1D090_2865;
        }
        else
        {
            return settings_ui_reload_language(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action settings_ui_reload_language(int loadOffset)
    {
    label_100D_CFE4_1D0B4_2882:
        CheckExternalEvents(cs1, 0xCFE4);
        // 100D:CFE4 mov AL,byte ptr DS:[0xCEEB]
        AL = UInt8[DS, (ushort)0xCEEB];
        // 100D:CFE7 mov SI,0x00BB
        SI = (ushort)0x00BB;
        // 100D:CFEA cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:CFEC jne short 0xCFF1
        if (!ZeroFlag)
        {
            goto label_100D_CFF1_1D0C1_2887;
        }
    label_100D_CFEE_1D0BE_25687:
        CheckExternalEvents(cs1, 0xCFEE);
        // 100D:CFEE mov SI,0x00C7
        SI = (ushort)0x00C7;
    label_100D_CFF1_1D0C1_2887:
        CheckExternalEvents(cs1, 0xCFF1);
        // 100D:CFF1 mov DI,0xCEEC
        DI = (ushort)0xCEEC;
        // 100D:CFF4 push DS
        Stack.Push16(DS);
        // 100D:CFF5 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CFF6 call near 0xF0B9
        NearCall(cs1, 0xCFF9, bank_filename);
    label_100D_CFF9_1D0C9_2892:
        CheckExternalEvents(cs1, 0xCFF9);
        // 100D:CFF9 mov AL,0xC0
        AL = (byte)0xC0;
        // 100D:CFFB add AL,byte ptr DS:[0xCEEB]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0xCEEB]);
        // 100D:CFFF xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D001 mov SI,AX
        SI = AX;
        // 100D:D003 les DI,word ptr DS:[0x47AC]
        ushort lxsOffset_100D_D003_1D0D3 = (ushort)0x47AC;
        ushort lxsValue_100D_D003_1D0D3 = UInt16[DS, lxsOffset_100D_D003_1D0D3];
        ushort lxsSegment_100D_D003_1D0D3 = UInt16[DS, (ushort)(lxsOffset_100D_D003_1D0D3 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_D003_1D0D3);
        ES = unchecked((ushort)lxsSegment_100D_D003_1D0D3);
        // 100D:D007 call near 0xF0B9
        NearCall(cs1, 0xD00A, bank_filename);
    label_100D_D00A_1D0DA_2899:
        CheckExternalEvents(cs1, 0xD00A);
        // 100D:D00A call near 0x0098
        NearCall(cs1, 0xD00D, unknown_100D_0098_10168);
    label_100D_D00D_1D0DD_2901:
        CheckExternalEvents(cs1, 0xD00D);
        // 100D:D00D jmp short 0xD01A
        return unknown_100D_D01A_1D0EA(0x0000);
    }

    public virtual Action load_phrasexx_hsq(int loadOffset)
    {
    label_100D_D00F_1D0DF_15697:
        CheckExternalEvents(cs1, 0xD00F);
        // 100D:D00F mov AX,word ptr DS:[0x477C]
        AX = UInt16[DS, (ushort)0x477C];
        // 100D:D012 cmp AX,word ptr DS:[0xAAD6]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xAAD6]);
        // 100D:D016 mov AL,0x93
        AL = (byte)0x93;
        // 100D:D018 jb short 0xD01C
        if (CarryFlag)
        {
            return unknown_100D_D01A_1D0EA(0xD01C);
        }
        else
        {
            return unknown_100D_D01A_1D0EA(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action command_string_replace_number(int loadOffset)
    {
    label_100D_D03C_1D10C_18420:
        CheckExternalEvents(cs1, 0xD03C);
        // 100D:D03C lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D03E sub AL,0x30
        AL = Alu8.Sub(AL, (byte)0x30);
        // 100D:D040 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:D042 ja short 0xD03C
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_D03C_1D10C_18420;
        }
    label_100D_D044_1D114_18425:
        CheckExternalEvents(cs1, 0xD044);
        // 100D:D044 lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D046 sub AL,0x30
        AL = Alu8.Sub(AL, (byte)0x30);
        // 100D:D048 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:D04A jbe short 0xD044
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D044_1D114_18425;
        }
    label_100D_D04C_1D11C_18430:
        CheckExternalEvents(cs1, 0xD04C);
        // 100D:D04C dec SI
        SI = Alu16.Dec(SI);
        // 100D:D04D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_set_draw_position(int loadOffset)
    {
    label_100D_D04E_1D11E_12069:
        CheckExternalEvents(cs1, 0xD04E);
        // 100D:D04E mov word ptr DS:[0xD82C],DX
        UInt16[DS, (ushort)0xD82C] = DX;
        // 100D:D052 mov word ptr DS:[0xD82E],BX
        UInt16[DS, (ushort)0xD82E] = BX;
        // 100D:D056 mov word ptr DS:[0xD830],DX
        UInt16[DS, (ushort)0xD830] = DX;
        // 100D:D05A mov word ptr DS:[0xD832],BX
        UInt16[DS, (ushort)0xD832] = BX;
        // 100D:D05E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_get_draw_position(int loadOffset)
    {
    label_100D_D05F_1D12F_12165:
        CheckExternalEvents(cs1, 0xD05F);
        // 100D:D05F mov DX,word ptr DS:[0xD82C]
        DX = UInt16[DS, (ushort)0xD82C];
        // 100D:D063 mov BX,word ptr DS:[0xD82E]
        BX = UInt16[DS, (ushort)0xD82E];
        // 100D:D067 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_select_tall_font(int loadOffset)
    {
    label_100D_D068_1D138_11717:
        CheckExternalEvents(cs1, 0xD068);
        // 100D:D068 mov word ptr DS:[0x2518],0xD096
        UInt16[DS, (ushort)0x2518] = (ushort)0xD096;
        // 100D:D06E mov word ptr DS:[0x47A0],0xCEEC
        UInt16[DS, (ushort)0x47A0] = (ushort)0xCEEC;
        // 100D:D074 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_select_small_font(int loadOffset)
    {
    label_100D_D075_1D145_13363:
        CheckExternalEvents(cs1, 0xD075);
        // 100D:D075 mov word ptr DS:[0x2518],0xD12F
        UInt16[DS, (ushort)0x2518] = (ushort)0xD12F;
        // 100D:D07B mov word ptr DS:[0x47A0],0xCF6C
        UInt16[DS, (ushort)0x47A0] = (ushort)0xCF6C;
        // 100D:D081 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_select_book_font(int loadOffset)
    {
    label_100D_D082_1D152_16650:
        CheckExternalEvents(cs1, 0xD082);
        // 100D:D082 mov word ptr DS:[0x2518],0xD0FF
        UInt16[DS, (ushort)0x2518] = (ushort)0xD0FF;
        // 100D:D088 mov word ptr DS:[0x47A0],0xCEEC
        UInt16[DS, (ushort)0x47A0] = (ushort)0xCEEC;
        // 100D:D08E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D08F_1D15F(int loadOffset)
    {
    label_100D_D08F_1D15F_41765:
        CheckExternalEvents(cs1, 0xD08F);
        // 100D:D08F mov word ptr DS:[0x2518],0xD16A
        UInt16[DS, (ushort)0x2518] = (ushort)0xD16A;
        // 100D:D095 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_draw_glyph(int loadOffset)
    {
    label_100D_D096_1D166_12146:
        CheckExternalEvents(cs1, 0xD096);
        // 100D:D096 push AX
        Stack.Push16(AX);
        // 100D:D097 push BX
        Stack.Push16(BX);
        // 100D:D098 push CX
        Stack.Push16(CX);
        // 100D:D099 push DX
        Stack.Push16(DX);
        // 100D:D09A push SI
        Stack.Push16(SI);
        // 100D:D09B push DI
        Stack.Push16(DI);
        // 100D:D09C push BP
        Stack.Push16(BP);
        // 100D:D09D push ES
        Stack.Push16(ES);
        // 100D:D09E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D0A0 mov SI,AX
        SI = AX;
        // 100D:D0A2 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D0A4 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D0A6 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D0A8 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:D0AA add SI,word ptr DS:[0x2514]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)0x2514]);
        // 100D:D0AE mov BX,0xCEEC
        BX = (ushort)0xCEEC;
        // 100D:D0B1 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:D0B2 call near 0xD05F
        NearCall(cs1, 0xD0B5, font_get_draw_position);
    label_100D_D0B5_1D185_12169:
        CheckExternalEvents(cs1, 0xD0B5);
        // 100D:D0B5 add word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = Alu16.Add(UInt16[DS, (ushort)0xD82C], AX);
        // 100D:D0B9 mov CL,AL
        CL = AL;
        // 100D:D0BB mov CH,9
        CH = (byte)0x09;
        // 100D:D0BD mov AX,word ptr DS:[0xDBE4]
        AX = UInt16[DS, (ushort)0xDBE4];
        // 100D:D0C0 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:D0C4 call far dword ptr DS:[0x38D1]
        ushort targetSegment_12175 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D1 + (ushort)0x0002)]));
        ushort targetOffset_12175 = unchecked((ushort)(UInt16[DS, (ushort)0x38D1]));
        if (targetSegment_12175 == cs2 && targetOffset_12175 == 0x0115)
        {
            FarCall(cs1, 0xD0C8, cs2, unknown_3358_0115_33695);
            goto label_100D_D0C8_1D198_12208;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12175:X4}:{targetOffset_12175:X4} at 100D:D0C4");
    label_100D_D0C8_1D198_12208:
        CheckExternalEvents(cs1, 0xD0C8);
        // 100D:D0C8 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D0C9 pop BP
        BP = Stack.Pop16();
        // 100D:D0CA pop DI
        DI = Stack.Pop16();
        // 100D:D0CB pop SI
        SI = Stack.Pop16();
        // 100D:D0CC pop DX
        DX = Stack.Pop16();
        // 100D:D0CD pop CX
        CX = Stack.Pop16();
        // 100D:D0CE pop BX
        BX = Stack.Pop16();
        // 100D:D0CF pop AX
        AX = Stack.Pop16();
        // 100D:D0D0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action drop_cap(int loadOffset)
    {
    label_100D_D0E3_1D1B3_16661:
        CheckExternalEvents(cs1, 0xD0E3);
        // 100D:D0E3 push CX
        Stack.Push16(CX);
        // 100D:D0E4 push DI
        Stack.Push16(DI);
        // 100D:D0E5 push ES
        Stack.Push16(ES);
        // 100D:D0E6 push CS
        Stack.Push16(CS);
        // 100D:D0E7 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D0E8 mov DI,0xD0D1
        DI = (ushort)0xD0D1;
        // 100D:D0EB mov CX,9
        CX = (ushort)0x0009;
        // 100D:D0EE repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_D0EE_1D1BE = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_D0EE_1D1BE)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_D0EE_1D1BE = ZeroFlag == false;
        }
        // 100D:D0F0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D0F1 stc
        CarryFlag = true;
        // 100D:D0F2 jne short 0xD0FC
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D0F2");
        }
    label_100D_D0F4_1D1C4_16673:
        CheckExternalEvents(cs1, 0xD0F4);
        // 100D:D0F4 mov AL,byte ptr CS:[DI+8]
        AL = UInt8[CS, (ushort)(DI + (sbyte)8)];
        // 100D:D0F8 mov AH,0x0D
        AH = (byte)0x0D;
        // 100D:D0FA sub AH,CL
        AH = Alu8.Sub(AH, CL);
        // 100D:D0FC pop DI
        DI = Stack.Pop16();
        // 100D:D0FD pop CX
        CX = Stack.Pop16();
        // 100D:D0FE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D0FF_1D1CF(int loadOffset)
    {
    label_100D_D0FF_1D1CF_16713:
        CheckExternalEvents(cs1, 0xD0FF);
        // 100D:D0FF call near 0xD068
        NearCall(cs1, 0xD102, font_select_tall_font);
    label_100D_D102_1D1D2_16715:
        CheckExternalEvents(cs1, 0xD102);
        // 100D:D102 call near 0xD0E3
        NearCall(cs1, 0xD105, drop_cap);
    label_100D_D105_1D1D5_16717:
        CheckExternalEvents(cs1, 0xD105);
        // 100D:D105 jb short 0xD096
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D105");
        }
    label_100D_D107_1D1D7_16719:
        CheckExternalEvents(cs1, 0xD107);
        // 100D:D107 call near 0xE270
        NearCall(cs1, 0xD10A, unknown_100D_E270_1E340);
    label_100D_D10A_1D1DA_16721:
        CheckExternalEvents(cs1, 0xD10A);
        // 100D:D10A push ES
        Stack.Push16(ES);
        // 100D:D10B push AX
        Stack.Push16(AX);
        // 100D:D10C mov AX,0x0032
        AX = (ushort)0x0032;
        // 100D:D10F call near 0xC13E
        NearCall(cs1, 0xD112, open_sprite_bank);
    label_100D_D112_1D1E2_16726:
        CheckExternalEvents(cs1, 0xD112);
        // 100D:D112 call near 0xD05F
        NearCall(cs1, 0xD115, font_get_draw_position);
    label_100D_D115_1D1E5_16728:
        CheckExternalEvents(cs1, 0xD115);
        // 100D:D115 pop AX
        AX = Stack.Pop16();
        // 100D:D116 mov CL,AH
        CL = AH;
        // 100D:D118 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D11A add word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = Alu16.Add(UInt16[DS, (ushort)0xD82C], AX);
        // 100D:D11E mov AL,CL
        AL = CL;
        // 100D:D120 sub BX,0x0013
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)19)));
        // 100D:D123 jae short 0xD127
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D123");
        }
    label_100D_D127_1D1F7_16736:
        CheckExternalEvents(cs1, 0xD127);
        // 100D:D127 call near 0xC22F
        NearCall(cs1, 0xD12A, draw_active_bank_sprite);
    label_100D_D12A_1D1FA_16738:
        CheckExternalEvents(cs1, 0xD12A);
        // 100D:D12A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D12B call near 0xE283
        NearCall(cs1, 0xD12E, unknown_100D_E283_1E353);
    label_100D_D12E_1D1FE_16741:
        CheckExternalEvents(cs1, 0xD12E);
        // 100D:D12E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D12F_1D1FF(int loadOffset)
    {
    label_100D_D12F_1D1FF_13412:
        CheckExternalEvents(cs1, 0xD12F);
        // 100D:D12F push AX
        Stack.Push16(AX);
        // 100D:D130 push BX
        Stack.Push16(BX);
        // 100D:D131 push CX
        Stack.Push16(CX);
        // 100D:D132 push DX
        Stack.Push16(DX);
        // 100D:D133 push SI
        Stack.Push16(SI);
        // 100D:D134 push DI
        Stack.Push16(DI);
        // 100D:D135 push BP
        Stack.Push16(BP);
        // 100D:D136 push ES
        Stack.Push16(ES);
        // 100D:D137 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D139 mov SI,AX
        SI = AX;
        // 100D:D13B shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D13D shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D13F shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:D141 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 100D:D143 add SI,word ptr DS:[0x2516]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)0x2516]);
        // 100D:D147 mov BX,0xCF6C
        BX = (ushort)0xCF6C;
        // 100D:D14A xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:D14B call near 0xD05F
        NearCall(cs1, 0xD14E, font_get_draw_position);
    label_100D_D14E_1D21E_13431:
        CheckExternalEvents(cs1, 0xD14E);
        // 100D:D14E add word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = Alu16.Add(UInt16[DS, (ushort)0xD82C], AX);
        // 100D:D152 mov CL,AL
        CL = AL;
        // 100D:D154 mov CH,7
        CH = (byte)0x07;
        // 100D:D156 mov AX,word ptr DS:[0xDBE4]
        AX = UInt16[DS, (ushort)0xDBE4];
        // 100D:D159 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:D15D call far dword ptr DS:[0x38D1]
        ushort targetSegment_13437 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D1 + (ushort)0x0002)]));
        ushort targetOffset_13437 = unchecked((ushort)(UInt16[DS, (ushort)0x38D1]));
        if (targetSegment_13437 == cs2 && targetOffset_13437 == 0x0115)
        {
            FarCall(cs1, 0xD161, cs2, unknown_3358_0115_33695);
            goto label_100D_D161_1D231_13457;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_13437:X4}:{targetOffset_13437:X4} at 100D:D15D");
    label_100D_D161_1D231_13457:
        CheckExternalEvents(cs1, 0xD161);
        // 100D:D161 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D162 pop BP
        BP = Stack.Pop16();
        // 100D:D163 pop DI
        DI = Stack.Pop16();
        // 100D:D164 pop SI
        SI = Stack.Pop16();
        // 100D:D165 pop DX
        DX = Stack.Pop16();
        // 100D:D166 pop CX
        CX = Stack.Pop16();
        // 100D:D167 pop BX
        BX = Stack.Pop16();
        // 100D:D168 pop AX
        AX = Stack.Pop16();
        // 100D:D169 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D16A_1D23A(int loadOffset)
    {
    label_100D_D16A_1D23A_41780:
        CheckExternalEvents(cs1, 0xD16A);
        // 100D:D16A call near 0xE270
        NearCall(cs1, 0xD16D, unknown_100D_E270_1E340);
    label_100D_D16D_1D23D_41783:
        CheckExternalEvents(cs1, 0xD16D);
        // 100D:D16D push ES
        Stack.Push16(ES);
        // 100D:D16E xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D170 sub AL,0x20
        AL = Alu8.Sub(AL, (byte)0x20);
        // 100D:D172 push AX
        Stack.Push16(AX);
        // 100D:D173 mov AX,0x0013
        AX = (ushort)0x0013;
        // 100D:D176 call near 0xC13E
        NearCall(cs1, 0xD179, open_sprite_bank);
    label_100D_D179_1D249_41796:
        CheckExternalEvents(cs1, 0xD179);
        // 100D:D179 pop AX
        AX = Stack.Pop16();
        // 100D:D17A push AX
        Stack.Push16(AX);
        // 100D:D17B call near 0xC1F4
        NearCall(cs1, 0xD17E, unknown_100D_C1F4_1C2C4);
    label_100D_D17E_1D24E_41803:
        CheckExternalEvents(cs1, 0xD17E);
        // 100D:D17E lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D180 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:D182 add AL,2
        AL = Alu8.Add(AL, (byte)0x02);
        // 100D:D184 call near 0xD05F
        NearCall(cs1, 0xD187, font_get_draw_position);
    label_100D_D187_1D257_41812:
        CheckExternalEvents(cs1, 0xD187);
        // 100D:D187 add word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = Alu16.Add(UInt16[DS, (ushort)0xD82C], AX);
        // 100D:D18B pop AX
        AX = Stack.Pop16();
        // 100D:D18C call near 0xC22F
        NearCall(cs1, 0xD18F, draw_active_bank_sprite);
    label_100D_D18F_1D25F_41819:
        CheckExternalEvents(cs1, 0xD18F);
        // 100D:D18F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D190 call near 0xE283
        NearCall(cs1, 0xD193, unknown_100D_E283_1E353);
    label_100D_D193_1D263_41824:
        CheckExternalEvents(cs1, 0xD193);
        // 100D:D193 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action font_draw_phrase_or_command_string_with_color_at_pos(int loadOffset)
    {
    label_100D_D194_1D264_17377:
        CheckExternalEvents(cs1, 0xD194);
        // 100D:D194 mov word ptr DS:[0xDBE4],CX
        UInt16[DS, (ushort)0xDBE4] = CX;
        // 100D:D198 call near 0xD04E
        NearCall(cs1, 0xD19B, font_set_draw_position);
        return font_draw_phrase_or_command_string(0x0000);
    }

    public virtual Action font_draw_phrase_or_command_string(int loadOffset)
    {
    label_100D_D19B_1D26B_17380:
        CheckExternalEvents(cs1, 0xD19B);
        // 100D:D19B push SI
        Stack.Push16(SI);
        // 100D:D19C mov SI,AX
        SI = AX;
        // 100D:D19E call near 0xCF70
        NearCall(cs1, 0xD1A1, get_phrase_or_command_string);
    label_100D_D1A1_1D271_17384:
        CheckExternalEvents(cs1, 0xD1A1);
        // 100D:D1A1 call near 0xD1BB
        NearCall(cs1, 0xD1A4, font_draw_string);
    label_100D_D1A4_1D274_17386:
        CheckExternalEvents(cs1, 0xD1A4);
        // 100D:D1A4 pop SI
        SI = Stack.Pop16();
        return unknown_100D_D1A5_1D275(0x0000);
    }

    public virtual Action unknown_100D_D1A6_1D276(int loadOffset)
    {
    label_100D_D1A6_1D276_19130:
        CheckExternalEvents(cs1, 0xD1A6);
        // 100D:D1A6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D1A7 mov CX,AX
        CX = AX;
        // 100D:D1A9 inc AX
        AX = Alu16.Inc(AX);
        // 100D:D1AA je short 0xD1A5
        if (ZeroFlag)
        {
            return unknown_100D_D1A5_1D275(0x0000);
        }
    label_100D_D1AC_1D27C_19135:
        CheckExternalEvents(cs1, 0xD1AC);
        // 100D:D1AC lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D1AD mov DX,AX
        DX = AX;
        // 100D:D1AF lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D1B0 mov BX,AX
        BX = AX;
        // 100D:D1B2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D1B3 xchg CX,AX
        ushort temp_100D_D1B3_1D283 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_D1B3_1D283);
        // 100D:D1B4 push SI
        Stack.Push16(SI);
        // 100D:D1B5 call near 0xD194
        NearCall(cs1, 0xD1B8, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_D1B8_1D288_19144:
        CheckExternalEvents(cs1, 0xD1B8);
        // 100D:D1B8 pop SI
        SI = Stack.Pop16();
        // 100D:D1B9 jmp short 0xD1A6
        goto label_100D_D1A6_1D276_19130;
    }

    public virtual Action font_draw_string(int loadOffset)
    {
    label_100D_D1BB_1D28B_14203:
        CheckExternalEvents(cs1, 0xD1BB);
        // 100D:D1BB lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D1BD cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:D1BF je short 0xD1A5
        if (ZeroFlag)
        {
            return unknown_100D_D1A5_1D275(0x0000);
        }
    label_100D_D1C1_1D291_14207:
        CheckExternalEvents(cs1, 0xD1C1);
        // 100D:D1C1 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:D1C3 je short 0xD1D1
        if (ZeroFlag)
        {
            goto label_100D_D1D1_1D2A1_18476;
        }
    label_100D_D1C5_1D295_14210:
        CheckExternalEvents(cs1, 0xD1C5);
        // 100D:D1C5 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:D1C7 jns short 0xD1CB
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D1C7");
        }
    label_100D_D1CB_1D29B_14213:
        CheckExternalEvents(cs1, 0xD1CB);
        // 100D:D1CB call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD096:
                NearCall(cs1, 0xD1CF, font_draw_glyph);
                break;
            case 0xD12F:
                NearCall(cs1, 0xD1CF, unknown_100D_D12F_1D1FF);
                break;
            case 0xD16A:
                NearCall(cs1, 0xD1CF, unknown_100D_D16A_1D23A);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:D1CB");
        }
    label_100D_D1CF_1D29F_14215:
        CheckExternalEvents(cs1, 0xD1CF);
        // 100D:D1CF jmp short 0xD1BB
        goto label_100D_D1BB_1D28B_14203;
    label_100D_D1D1_1D2A1_18476:
        CheckExternalEvents(cs1, 0xD1D1);
        // 100D:D1D1 mov AX,word ptr DS:[0xD830]
        AX = UInt16[DS, (ushort)0xD830];
        // 100D:D1D4 mov word ptr DS:[0xD82C],AX
        UInt16[DS, (ushort)0xD82C] = AX;
        // 100D:D1D7 mov AX,0x000A
        AX = (ushort)0x000A;
        // 100D:D1DA cmp word ptr DS:[0x2518],0xD12F
        Alu16.Sub(UInt16[DS, (ushort)0x2518], (ushort)0xD12F);
        // 100D:D1E0 jne short 0xD1E5
        if (!ZeroFlag)
        {
            goto label_100D_D1E5_1D2B5_18482;
        }
    label_100D_D1E2_1D2B2_30064:
        CheckExternalEvents(cs1, 0xD1E2);
        // 100D:D1E2 mov AX,7
        AX = (ushort)0x0007;
    label_100D_D1E5_1D2B5_18482:
        CheckExternalEvents(cs1, 0xD1E5);
        // 100D:D1E5 add word ptr DS:[0xD832],AX
        UInt16[DS, (ushort)0xD832] = Alu16.Add(UInt16[DS, (ushort)0xD832], AX);
        // 100D:D1E9 add word ptr DS:[0xD82E],AX
        UInt16[DS, (ushort)0xD82E] = Alu16.Add(UInt16[DS, (ushort)0xD82E], AX);
        // 100D:D1ED jmp short 0xD1BB
        goto label_100D_D1BB_1D28B_14203;
    }

    public virtual Action draw_all_ui_elements(int loadOffset)
    {
    label_100D_D1EF_1D2BF_12994:
        CheckExternalEvents(cs1, 0xD1EF);
        // 100D:D1EF lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D1F0 mov CX,AX
        CX = AX;
        return draw_ui_elements_list(0x0000);
    }

    public virtual Action draw_ui_elements_list(int loadOffset)
    {
    label_100D_D1F2_1D2C2_12997:
        CheckExternalEvents(cs1, 0xD1F2);
        // 100D:D1F2 call near 0xC137
        NearCall(cs1, 0xD1F5, open_icones_spritesheet);
    label_100D_D1F5_1D2C5_12998:
        CheckExternalEvents(cs1, 0xD1F5);
        // 100D:D1F5 push CX
        Stack.Push16(CX);
        // 100D:D1F6 call near 0xD200
        NearCall(cs1, 0xD1F9, draw_ui_element);
    label_100D_D1F9_1D2C9_13028:
        CheckExternalEvents(cs1, 0xD1F9);
        // 100D:D1F9 pop CX
        CX = Stack.Pop16();
        // 100D:D1FA add SI,0x000E
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D1FD loop 0xD1F5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D1F5_1D2C5_12998;
        }
    label_100D_D1FF_1D2CF_13035:
        CheckExternalEvents(cs1, 0xD1FF);
        // 100D:D1FF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_ui_element(int loadOffset)
    {
    label_100D_D200_1D2D0_13001:
        CheckExternalEvents(cs1, 0xD200);
        // 100D:D200 push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:D204 call near 0xC08E
        NearCall(cs1, 0xD207, set_screen_as_active_framebuffer);
    label_100D_D207_1D2D7_13004:
        CheckExternalEvents(cs1, 0xD207);
        // 100D:D207 push SI
        Stack.Push16(SI);
        // 100D:D208 test byte ptr DS:[SI+8],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)8)], (byte)0x40);
        // 100D:D20C je short 0xD218
        if (ZeroFlag)
        {
            goto label_100D_D218_1D2E8_13008;
        }
    label_100D_D20E_1D2DE_18383:
        CheckExternalEvents(cs1, 0xD20E);
        // 100D:D20E mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:D212 push SI
        Stack.Push16(SI);
        // 100D:D213 call far dword ptr DS:[0x38D9]
        ushort targetSegment_18386 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38D9 + (ushort)0x0002)]));
        ushort targetOffset_18386 = unchecked((ushort)(UInt16[DS, (ushort)0x38D9]));
        if (targetSegment_18386 == cs2 && targetOffset_18386 == 0x011B)
        {
            FarCall(cs1, 0xD217, cs2, unknown_3358_011B_3369B);
            goto label_100D_D217_1D2E7_18387;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_18386:X4}:{targetOffset_18386:X4} at 100D:D213");
    label_100D_D217_1D2E7_18387:
        CheckExternalEvents(cs1, 0xD217);
        // 100D:D217 pop SI
        SI = Stack.Pop16();
    label_100D_D218_1D2E8_13008:
        CheckExternalEvents(cs1, 0xD218);
        // 100D:D218 test byte ptr DS:[SI+8],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)8)], (byte)0x20);
        // 100D:D21C jne short 0xD233
        if (!ZeroFlag)
        {
            goto label_100D_D233_1D303_13024;
        }
    label_100D_D21E_1D2EE_13011:
        CheckExternalEvents(cs1, 0xD21E);
        // 100D:D21E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D21F mov DX,AX
        DX = AX;
        // 100D:D221 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D222 mov BX,AX
        BX = AX;
        // 100D:D224 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D225 mov DI,AX
        DI = AX;
        // 100D:D227 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D228 mov CX,AX
        CX = AX;
        // 100D:D22A lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D22B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D22C inc AX
        AX = Alu16.Inc(AX);
        // 100D:D22D je short 0xD233
        if (ZeroFlag)
        {
            goto label_100D_D233_1D303_13024;
        }
    label_100D_D22F_1D2FF_13032:
        CheckExternalEvents(cs1, 0xD22F);
        // 100D:D22F dec AX
        AX = Alu16.Dec(AX);
        // 100D:D230 call near 0xC22F
        NearCall(cs1, 0xD233, draw_active_bank_sprite);
    label_100D_D233_1D303_13024:
        CheckExternalEvents(cs1, 0xD233);
        // 100D:D233 pop SI
        SI = Stack.Pop16();
        // 100D:D234 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_D234_1D304 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_D234_1D304 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_D234_1D304 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_D234_1D304);
        // 100D:D238 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_hud_open_hands(int loadOffset)
    {
    label_100D_D239_1D309_15793:
        CheckExternalEvents(cs1, 0xD239);
        // 100D:D239 mov CH,2
        CH = (byte)0x02;
        // 100D:D23B jmp short 0xD23F
        return ui_hud_animate_hands(0x0000);
    }

    public virtual Action ui_hud_close_hands(int loadOffset)
    {
    label_100D_D23D_1D30D_16022:
        CheckExternalEvents(cs1, 0xD23D);
        // 100D:D23D xor CX,CX
        CX = Alu16.Xor(CX, CX);
        return ui_hud_animate_hands(0x0000);
    }

    public virtual Action play_pending_panel_fold(int loadOffset)
    {
    entrydispatcher:
    label_100D_D280_1D350_15785:
        CheckExternalEvents(cs1, 0xD280);
        // 100D:D280 cmp byte ptr DS:[0xDCE6],0
        Alu8.Sub(UInt8[DS, (ushort)0xDCE6], (byte)0x00);
        // 100D:D285 jle short 0xD2BC
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_D2BC_1D38C_16028;
        }
    label_100D_D287_1D357_15788:
        CheckExternalEvents(cs1, 0xD287);
        // 100D:D287 call near 0xE270
        NearCall(cs1, 0xD28A, unknown_100D_E270_1E340);
    label_100D_D28A_1D35A_15790:
        CheckExternalEvents(cs1, 0xD28A);
        // 100D:D28A mov byte ptr DS:[0xDCE6],0
        UInt8[DS, (ushort)0xDCE6] = (byte)0x00;
        // 100D:D28F call near 0xD239
        NearCall(cs1, 0xD292, ui_hud_open_hands);
    label_100D_D292_1D362_15830:
        CheckExternalEvents(cs1, 0xD292);
        // 100D:D292 mov CX,0x0011
        CX = (ushort)0x0011;
    label_100D_D295_1D365_15832:
        CheckExternalEvents(cs1, 0xD295);
        // 100D:D295 push CX
        Stack.Push16(CX);
        // 100D:D296 push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
        // 100D:D29A mov SI,word ptr DS:[0xDBDE]
        SI = UInt16[DS, (ushort)0xDBDE];
        // 100D:D29E mov AL,0x18
        AL = (byte)0x18;
        // 100D:D2A0 call near 0xC0D5
        NearCall(cs1, 0xD2A3, blit_fb1_to_screen_effect);
    label_100D_D2A3_1D373_15961:
        CheckExternalEvents(cs1, 0xD2A3);
        // 100D:D2A3 pop BX
        BX = Stack.Pop16();
    label_100D_D2A4_1D374_15963:
        CheckExternalEvents(cs1, 0xD2A4);
        // 100D:D2A4 push BX
        Stack.Push16(BX);
        // 100D:D2A5 call near 0xA7C2
        NearCall(cs1, 0xD2A8, tick_talking_head_voc);
    label_100D_D2A8_1D378_15965:
        CheckExternalEvents(cs1, 0xD2A8);
        // 100D:D2A8 pop BX
        BX = Stack.Pop16();
        // 100D:D2A9 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D2AC sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:D2AE cmp AX,6
        Alu16.Sub(AX, (ushort)0x0006);
        // 100D:D2B1 jb short 0xD2A4
        if (CarryFlag)
        {
            goto label_100D_D2A4_1D374_15963;
        }
    label_100D_D2B3_1D383_15972:
        CheckExternalEvents(cs1, 0xD2B3);
        // 100D:D2B3 pop CX
        CX = Stack.Pop16();
        // 100D:D2B4 loop 0xD295
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D295_1D365_15832;
        }
    label_100D_D2B6_1D386_16020:
        CheckExternalEvents(cs1, 0xD2B6);
        // 100D:D2B6 call near 0xD23D
        NearCall(cs1, 0xD2B9, ui_hud_close_hands);
    label_100D_D2B9_1D389_16026:
        CheckExternalEvents(cs1, 0xD2B9);
        // 100D:D2B9 call near 0xE283
        NearCall(cs1, 0xD2BC, unknown_100D_E283_1E353);
    label_100D_D2BC_1D38C_16028:
        CheckExternalEvents(cs1, 0xD2BC);
        // 100D:D2BC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action dismiss_stacked_menus(int loadOffset)
    {
    label_100D_D2BD_1D38D_13220:
        CheckExternalEvents(cs1, 0xD2BD);
        // 100D:D2BD mov AL,byte ptr DS:[0xDCE6]
        AL = UInt8[DS, (ushort)0xDCE6];
        // 100D:D2C0 push AX
        Stack.Push16(AX);
    label_100D_D2C1_1D391_13223:
        CheckExternalEvents(cs1, 0xD2C1);
        // 100D:D2C1 mov byte ptr DS:[0xDCE6],0x80
        UInt8[DS, (ushort)0xDCE6] = (byte)0x80;
        // 100D:D2C6 mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D2CA mov SI,word ptr DS:[SI]
        SI = UInt16[DS, SI];
        // 100D:D2CC lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D2CD cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:D2CF je short 0xD2DA
        if (ZeroFlag)
        {
            goto label_100D_D2DA_1D3AA_13229;
        }
    label_100D_D2D1_1D3A1_20374:
        CheckExternalEvents(cs1, 0xD2D1);
        // 100D:D2D1 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:D2D3 je short 0xD2DA
        if (ZeroFlag)
        {
            goto label_100D_D2DA_1D3AA_13229;
        }
    label_100D_D2D5_1D3A5_20377:
        CheckExternalEvents(cs1, 0xD2D5);
        // 100D:D2D5 call near 0xD2EA
        NearCall(cs1, 0xD2D8, menu_stack_pop_and_cleanup);
    label_100D_D2D8_1D3A8_20379:
        CheckExternalEvents(cs1, 0xD2D8);
        // 100D:D2D8 jmp short 0xD2C1
        goto label_100D_D2C1_1D391_13223;
    label_100D_D2DA_1D3AA_13229:
        CheckExternalEvents(cs1, 0xD2DA);
        // 100D:D2DA pop AX
        AX = Stack.Pop16();
        // 100D:D2DB mov byte ptr DS:[0xDCE6],AL
        UInt8[DS, (ushort)0xDCE6] = AL;
        // 100D:D2DE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action menu_callback_choice_exit_menu(int loadOffset)
    {
    entrydispatcher:
    label_100D_D2E2_1D3B2_16236:
        CheckExternalEvents(cs1, 0xD2E2);
        // 100D:D2E2 call near 0xD316
        NearCall(cs1, 0xD2E5, screen_overlay_request_transition);
    label_100D_D2E5_1D3B5_16238:
        CheckExternalEvents(cs1, 0xD2E5);
        // 100D:D2E5 call near 0xD2EA
        NearCall(cs1, 0xD2E8, menu_stack_pop_and_cleanup);
    label_100D_D2E8_1D3B8_16317:
        CheckExternalEvents(cs1, 0xD2E8);
        // 100D:D2E8 jmp short 0xD280
        if (JumpDispatcher.Jump(play_pending_panel_fold, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action menu_stack_pop_and_cleanup(int loadOffset)
    {
    entrydispatcher:
    label_100D_D2EA_1D3BA_16240:
        CheckExternalEvents(cs1, 0xD2EA);
        // 100D:D2EA mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D2EE mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:D2F0 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:D2F2 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:D2F4 cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 100D:D2F6 je short 0xD315
        if (ZeroFlag)
        {
            return unknown_100D_D315_1D3E5(0x0000);
        }
    label_100D_D2F8_1D3C8_16247:
        CheckExternalEvents(cs1, 0xD2F8);
        // 100D:D2F8 mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:D2FB call near AX
        switch ((ushort)(AX))
        {
            case 0x0F66:
                NearCall(cs1, 0xD2FD, globe_mouse_noop);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x19FC:
                NearCall(cs1, 0xD2FD, palace_plan_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x4415:
                NearCall(cs1, 0xD2FD, map_screen_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x5F91:
                NearCall(cs1, 0xD2FD, map_close_location_popup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x7D68:
                NearCall(cs1, 0xD2FD, unknown_100D_7D68_17E38);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x824D:
                NearCall(cs1, 0xD2FD, move_troop_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x8751:
                NearCall(cs1, 0xD2FD, map_troop_contact_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x97CF:
                NearCall(cs1, 0xD2FD, menu_npc_actions_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0xA541:
                NearCall(cs1, 0xD2FD, settings_ui_cleanup);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0xB2B3:
                NearCall(cs1, 0xD2FD, unknown_100D_B2B3_1B383);
                if (JumpDispatcher.Jump(unknown_100D_D2FD_1D3CD, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(AX)):X4} at 100D:D2FB");
        }
    }

    public virtual Action unknown_100D_D2FD_1D3CD(int loadOffset)
    {
    entrydispatcher:
    label_100D_D2FD_1D3CD_16304:
        CheckExternalEvents(cs1, 0xD2FD);
        // 100D:D2FD mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D301 cmp SI,0x21BE
        Alu16.Sub(SI, (ushort)0x21BE);
        // 100D:D305 je short 0xD315
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D305");
        }
    label_100D_D307_1D3D7_16308:
        CheckExternalEvents(cs1, 0xD307);
        // 100D:D307 sub SI,4
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D30A mov word ptr DS:[0x21DA],SI
        UInt16[DS, (ushort)0x21DA] = SI;
        // 100D:D30E mov BP,word ptr DS:[SI]
        BP = UInt16[DS, SI];
        // 100D:D310 mov CL,0xFF
        CL = (byte)0xFF;
        // 100D:D312 call near 0xD36D
        NearCall(cs1, 0xD315, unknown_100D_D36D_1D43D);
        return unknown_100D_D315_1D3E5(0x0000);
    }

    public virtual Action screen_overlay_request_transition(int loadOffset)
    {
    label_100D_D316_1D3E6_15526:
        CheckExternalEvents(cs1, 0xD316);
        // 100D:D316 cmp word ptr DS:[0x35A6],0
        Alu16.Sub(UInt16[DS, (ushort)0x35A6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:D31B jne short 0xD322
        if (!ZeroFlag)
        {
            goto label_100D_D322_1D3F2_15531;
        }
    label_100D_D31D_1D3ED_15529:
        CheckExternalEvents(cs1, 0xD31D);
        // 100D:D31D or byte ptr DS:[0xDCE6],1
        UInt8[DS, (ushort)0xDCE6] = Alu8.Or(UInt8[DS, (ushort)0xDCE6], (byte)0x01);
    label_100D_D322_1D3F2_15531:
        CheckExternalEvents(cs1, 0xD322);
        // 100D:D322 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action stage_command_submenu(int loadOffset)
    {
    entrydispatcher:
    label_100D_D323_1D3F3_19351:
        CheckExternalEvents(cs1, 0xD323);
        // 100D:D323 call near 0xD316
        NearCall(cs1, 0xD326, screen_overlay_request_transition);
    label_100D_D326_1D3F6_19353:
        CheckExternalEvents(cs1, 0xD326);
        // 100D:D326 call near 0xD338
        NearCall(cs1, 0xD329, menu_stack_push);
    label_100D_D329_1D3F9_19355:
        CheckExternalEvents(cs1, 0xD329);
        // 100D:D329 call near 0xD280
        NearCall(cs1, 0xD32C, play_pending_panel_fold);
    label_100D_D32C_1D3FC_19357:
        CheckExternalEvents(cs1, 0xD32C);
        // 100D:D32C jmp near 0xD410
        if (JumpDispatcher.Jump(unknown_100D_D410_1D4E0, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action menu_stack_push(int loadOffset)
    {
    entrydispatcher:
    label_100D_D338_1D408_14114:
        CheckExternalEvents(cs1, 0xD338);
        // 100D:D338 mov CL,0xFF
        CL = (byte)0xFF;
        if (JumpDispatcher.Jump(unknown_100D_D33A_1D40A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_D33A_1D40A(int loadOffset)
    {
    entrydispatcher:
    label_100D_D33A_1D40A_14116:
        CheckExternalEvents(cs1, 0xD33A);
        // 100D:D33A mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D33E mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:D340 mov AL,byte ptr SS:[BP]
        AL = UInt8[SS, (ushort)(BP + (sbyte)0)];
        // 100D:D343 cmp AL,byte ptr DS:[DI]
        Alu8.Sub(AL, UInt8[DS, DI]);
        // 100D:D345 je short 0xD368
        if (ZeroFlag)
        {
            goto label_100D_D368_1D438_14121;
        }
    label_100D_D347_1D417_15535:
        CheckExternalEvents(cs1, 0xD347);
        // 100D:D347 jb short 0xD35B
        if (CarryFlag)
        {
            goto label_100D_D35B_1D42B_15537;
        }
    label_100D_D349_1D419_24977:
        CheckExternalEvents(cs1, 0xD349);
        // 100D:D349 push BP
        Stack.Push16(BP);
        // 100D:D34A push BX
        Stack.Push16(BX);
        // 100D:D34B push CX
        Stack.Push16(CX);
        // 100D:D34C mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:D34F call near AX
        switch ((ushort)(AX))
        {
            case 0x0F66:
                NearCall(cs1, 0xD351, globe_mouse_noop);
                break;
            case 0x2997:
                NearCall(cs1, 0xD351, comm_viewed_cleanup);
                break;
            case 0x7D68:
                NearCall(cs1, 0xD351, unknown_100D_7D68_17E38);
                break;
            case 0x8751:
                NearCall(cs1, 0xD351, map_troop_contact_cleanup);
                break;
            case 0xB2B3:
                NearCall(cs1, 0xD351, unknown_100D_B2B3_1B383);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(AX)):X4} at 100D:D34F");
        }
    label_100D_D351_1D421_25096:
        CheckExternalEvents(cs1, 0xD351);
        // 100D:D351 sub word ptr DS:[0x21DA],4
        UInt16[DS, (ushort)0x21DA] = Alu16.Sub(UInt16[DS, (ushort)0x21DA], unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D356 pop CX
        CX = Stack.Pop16();
        // 100D:D357 pop BX
        BX = Stack.Pop16();
        // 100D:D358 pop BP
        BP = Stack.Pop16();
        // 100D:D359 jmp short 0xD33A
        goto label_100D_D33A_1D40A_14116;
    label_100D_D35B_1D42B_15537:
        CheckExternalEvents(cs1, 0xD35B);
        // 100D:D35B cmp SI,0x21D6
        Alu16.Sub(SI, (ushort)0x21D6);
        // 100D:D35F je short 0xD368
        if (ZeroFlag)
        {
            goto label_100D_D368_1D438_14121;
        }
    label_100D_D361_1D431_15540:
        CheckExternalEvents(cs1, 0xD361);
        // 100D:D361 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D364 mov word ptr DS:[0x21DA],SI
        UInt16[DS, (ushort)0x21DA] = SI;
    label_100D_D368_1D438_14121:
        CheckExternalEvents(cs1, 0xD368);
        // 100D:D368 mov word ptr DS:[SI],BP
        UInt16[DS, SI] = BP;
        // 100D:D36A mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        if (JumpDispatcher.Jump(unknown_100D_D36D_1D43D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_D36D_1D43D(int loadOffset)
    {
    entrydispatcher:
    label_100D_D36D_1D43D_14124:
        CheckExternalEvents(cs1, 0xD36D);
        // 100D:D36D mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D371 mov word ptr DS:[SI],BP
        UInt16[DS, SI] = BP;
        // 100D:D373 mov SI,BP
        SI = BP;
        // 100D:D375 add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_D378_1D448_14128:
        CheckExternalEvents(cs1, 0xD378);
        // 100D:D378 cmp word ptr SS:[BP],0
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:D37C je short 0xD388
        if (ZeroFlag)
        {
            goto label_100D_D388_1D458_14135;
        }
    label_100D_D37E_1D44E_14130:
        CheckExternalEvents(cs1, 0xD37E);
        // 100D:D37E and word ptr SS:[BP],0x7FFF
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.And(UInt16[SS, (ushort)(BP + (sbyte)0)], (ushort)0x7FFF);
        // 100D:D383 add BP,4
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D386 jmp short 0xD378
        goto label_100D_D378_1D448_14128;
    label_100D_D388_1D458_14135:
        CheckExternalEvents(cs1, 0xD388);
        // 100D:D388 cmp CX,5
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:D38B jae short 0xD397
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(redraw_active_command_menu, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_D38D_1D45D_16440:
        CheckExternalEvents(cs1, 0xD38D);
        // 100D:D38D shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:D38F shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:D391 mov BX,CX
        BX = CX;
        // 100D:D393 or byte ptr DS:[BX+SI+3],0x80
        UInt8[DS, (ushort)(BX + SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(BX + SI + (sbyte)3)], (byte)0x80);
        if (JumpDispatcher.Jump(redraw_active_command_menu, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action redraw_active_command_menu(int loadOffset)
    {
    entrydispatcher:
    label_100D_D397_1D467_14138:
        CheckExternalEvents(cs1, 0xD397);
        // 100D:D397 mov byte ptr DS:[0xDCE7],0xFF
        UInt8[DS, (ushort)0xDCE7] = (byte)0xFF;
        // 100D:D39C mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D3A0 mov SI,word ptr DS:[SI]
        SI = UInt16[DS, SI];
        // 100D:D3A2 inc SI
        SI = Alu16.Inc(SI);
        // 100D:D3A3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D3A4 mov byte ptr DS:[0xDCE4],AL
        UInt8[DS, (ushort)0xDCE4] = AL;
        // 100D:D3A7 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:D3A8 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:D3AA xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:D3AC mov byte ptr DS:[0xDCE8],CL
        UInt8[DS, (ushort)0xDCE8] = CL;
        // 100D:D3B0 mov byte ptr DS:[0xDCE5],0xFF
        UInt8[DS, (ushort)0xDCE5] = (byte)0xFF;
    label_100D_D3B5_1D485_14150:
        CheckExternalEvents(cs1, 0xD3B5);
        // 100D:D3B5 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:D3B7 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:D3B9 je short 0xD3EF
        if (ZeroFlag)
        {
            goto label_100D_D3EF_1D4BF_14253;
        }
    label_100D_D3BB_1D48B_14153:
        CheckExternalEvents(cs1, 0xD3BB);
        // 100D:D3BB cmp CL,4
        Alu8.Sub(CL, (byte)0x04);
        // 100D:D3BE jb short 0xD3D9
        if (CarryFlag)
        {
            goto label_100D_D3D9_1D4A9_14156;
        }
    label_100D_D3C0_1D490_16445:
        CheckExternalEvents(cs1, 0xD3C0);
        // 100D:D3C0 cmp byte ptr DS:[0xDCE4],0
        Alu8.Sub(UInt8[DS, (ushort)0xDCE4], (byte)0x00);
        // 100D:D3C5 jne short 0xD3CD
        if (!ZeroFlag)
        {
            goto label_100D_D3CD_1D49D_32151;
        }
    label_100D_D3C7_1D497_16448:
        CheckExternalEvents(cs1, 0xD3C7);
        // 100D:D3C7 cmp word ptr DS:[SI+4],0
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)4)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:D3CB je short 0xD3D9
        if (ZeroFlag)
        {
            goto label_100D_D3D9_1D4A9_14156;
        }
    label_100D_D3CD_1D49D_32151:
        CheckExternalEvents(cs1, 0xD3CD);
        // 100D:D3CD or byte ptr DS:[0xDCE4],0x80
        UInt8[DS, (ushort)0xDCE4] = Alu8.Or(UInt8[DS, (ushort)0xDCE4], (byte)0x80);
        // 100D:D3D2 mov AX,0x00A0
        AX = (ushort)0x00A0;
        // 100D:D3D5 mov byte ptr DS:[0xDCE5],CL
        UInt8[DS, (ushort)0xDCE5] = CL;
    label_100D_D3D9_1D4A9_14156:
        CheckExternalEvents(cs1, 0xD3D9);
        // 100D:D3D9 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D3DC push CX
        Stack.Push16(CX);
        // 100D:D3DD push SI
        Stack.Push16(SI);
        // 100D:D3DE inc byte ptr DS:[0xDCE8]
        UInt8[DS, (ushort)0xDCE8] = Alu8.Inc(UInt8[DS, (ushort)0xDCE8]);
        // 100D:D3E2 call near 0xD48A
        NearCall(cs1, 0xD3E5, draw_command_menu_item);
    label_100D_D3E5_1D4B5_14234:
        CheckExternalEvents(cs1, 0xD3E5);
        // 100D:D3E5 pop SI
        SI = Stack.Pop16();
        // 100D:D3E6 pop CX
        CX = Stack.Pop16();
        // 100D:D3E7 inc CX
        CX = Alu16.Inc(CX);
        // 100D:D3E8 cmp CL,5
        Alu8.Sub(CL, (byte)0x05);
        // 100D:D3EB jb short 0xD3B5
        if (CarryFlag)
        {
            goto label_100D_D3B5_1D485_14150;
        }
    label_100D_D3ED_1D4BD_16451:
        CheckExternalEvents(cs1, 0xD3ED);
        // 100D:D3ED jmp short 0xD410
        if (JumpDispatcher.Jump(unknown_100D_D410_1D4E0, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_D3EF_1D4BF_14253:
        CheckExternalEvents(cs1, 0xD3EF);
        // 100D:D3EF cmp byte ptr DS:[0xDCE4],0
        Alu8.Sub(UInt8[DS, (ushort)0xDCE4], (byte)0x00);
        // 100D:D3F4 je short 0xD403
        if (ZeroFlag)
        {
            goto label_100D_D403_1D4D3_14256;
        }
    label_100D_D3F6_1D4C6_32165:
        CheckExternalEvents(cs1, 0xD3F6);
        // 100D:D3F6 mov AX,0x00A0
        AX = (ushort)0x00A0;
        // 100D:D3F9 mov byte ptr DS:[0xDCE5],CL
        UInt8[DS, (ushort)0xDCE5] = CL;
        // 100D:D3FD inc byte ptr DS:[0xDCE8]
        UInt8[DS, (ushort)0xDCE8] = Alu8.Inc(UInt8[DS, (ushort)0xDCE8]);
        // 100D:D401 jmp short 0xD405
        goto label_100D_D405_1D4D5_14258;
    label_100D_D403_1D4D3_14256:
        CheckExternalEvents(cs1, 0xD403);
        // 100D:D403 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_D405_1D4D5_14258:
        CheckExternalEvents(cs1, 0xD405);
        // 100D:D405 push CX
        Stack.Push16(CX);
        // 100D:D406 call near 0xD48A
        NearCall(cs1, 0xD409, draw_command_menu_item);
    label_100D_D409_1D4D9_14260:
        CheckExternalEvents(cs1, 0xD409);
        // 100D:D409 pop CX
        CX = Stack.Pop16();
        // 100D:D40A inc CX
        CX = Alu16.Inc(CX);
        // 100D:D40B cmp CL,5
        Alu8.Sub(CL, (byte)0x05);
        // 100D:D40E jb short 0xD403
        if (CarryFlag)
        {
            goto label_100D_D403_1D4D3_14256;
        }
        else
        {
            if (JumpDispatcher.Jump(unknown_100D_D410_1D4E0, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action get_location_and_room(int loadOffset)
    {
    label_100D_D41B_1D4EB_3543:
        CheckExternalEvents(cs1, 0xD41B);
        // 100D:D41B mov BP,word ptr DS:[0x21DA]
        BP = UInt16[DS, (ushort)0x21DA];
        // 100D:D41F mov BP,word ptr SS:[BP]
        BP = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:D422 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action dispatch_command_menu_slot_4(int loadOffset)
    {
    entrydispatcher:
    label_100D_D42F_1D4FF_17388:
        CheckExternalEvents(cs1, 0xD42F);
        // 100D:D42F mov CX,4
        CX = (ushort)0x0004;
        // 100D:D432 jmp short 0xD445
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xD445))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action dispatch_command_menu_slot_3(int loadOffset)
    {
    entrydispatcher:
    label_100D_D434_1D504_16233:
        CheckExternalEvents(cs1, 0xD434);
        // 100D:D434 mov CX,3
        CX = (ushort)0x0003;
        // 100D:D437 jmp short 0xD445
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xD445))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action dispatch_command_menu_slot_2(int loadOffset)
    {
    entrydispatcher:
    label_100D_D439_1D509_15399:
        CheckExternalEvents(cs1, 0xD439);
        // 100D:D439 mov CX,2
        CX = (ushort)0x0002;
        // 100D:D43C jmp short 0xD445
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xD445))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action dispatch_command_menu_slot_1(int loadOffset)
    {
    entrydispatcher:
    label_100D_D43E_1D50E_16166:
        CheckExternalEvents(cs1, 0xD43E);
        // 100D:D43E mov CX,1
        CX = (ushort)0x0001;
        // 100D:D441 jmp short 0xD445
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xD445))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action dispatch_command_menu_slot_0(int loadOffset)
    {
    entrydispatcher:
    label_100D_D443_1D513_16080:
        CheckExternalEvents(cs1, 0xD443);
        // 100D:D443 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xD445))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action slot_text_id(int loadOffset)
    {
    label_100D_D454_1D524_15235:
        CheckExternalEvents(cs1, 0xD454);
        // 100D:D454 mov SI,word ptr DS:[0x21DA]
        SI = UInt16[DS, (ushort)0x21DA];
        // 100D:D458 mov SI,word ptr DS:[SI]
        SI = UInt16[DS, SI];
        // 100D:D45A inc SI
        SI = Alu16.Inc(SI);
        // 100D:D45B xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:D45D cmp CL,byte ptr DS:[0xDCE5]
        Alu8.Sub(CL, UInt8[DS, (ushort)0xDCE5]);
        // 100D:D461 je short 0xD475
        if (ZeroFlag)
        {
            goto label_100D_D475_1D545_32155;
        }
    label_100D_D463_1D533_15242:
        CheckExternalEvents(cs1, 0xD463);
        // 100D:D463 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:D464 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:D465 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:D467 mov AX,CX
        AX = CX;
        // 100D:D469 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:D46B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:D46D add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:D46F mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:D471 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:D474 ret near
        return NearRet((ushort)0x0000);
    label_100D_D475_1D545_32155:
        CheckExternalEvents(cs1, 0xD475);
        // 100D:D475 mov AX,0x00A0
        AX = (ushort)0x00A0;
        // 100D:D478 mov BX,0xD423
        BX = (ushort)0xD423;
        // 100D:D47B cmp byte ptr DS:[0xDCE4],0
        Alu8.Sub(UInt8[DS, (ushort)0xDCE4], (byte)0x00);
        // 100D:D480 js short 0xD489
        if (SignFlag)
        {
            goto label_100D_D489_1D559_32160;
        }
    label_100D_D482_1D552_32171:
        CheckExternalEvents(cs1, 0xD482);
        // 100D:D482 mov BX,0xD429
        BX = (ushort)0xD429;
        // 100D:D485 jg short 0xD489
        if (!(!ZeroFlag && SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D485");
        }
    label_100D_D489_1D559_32160:
        CheckExternalEvents(cs1, 0xD489);
        // 100D:D489 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_command_menu_item(int loadOffset)
    {
    label_100D_D48A_1D55A_14162:
        CheckExternalEvents(cs1, 0xD48A);
        // 100D:D48A push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:D48E call near 0xC08E
        NearCall(cs1, 0xD491, set_screen_as_active_framebuffer);
    label_100D_D491_1D561_14165:
        CheckExternalEvents(cs1, 0xD491);
        // 100D:D491 cmp byte ptr DS:[0xDCE6],0
        Alu8.Sub(UInt8[DS, (ushort)0xDCE6], (byte)0x00);
        // 100D:D496 jle short 0xD49B
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_D49B_1D56B_14168;
        }
    label_100D_D498_1D568_15543:
        CheckExternalEvents(cs1, 0xD498);
        // 100D:D498 call near 0xC07C
        NearCall(cs1, 0xD49B, set_fb1_as_active_framebuffer);
    label_100D_D49B_1D56B_14168:
        CheckExternalEvents(cs1, 0xD49B);
        // 100D:D49B call near 0xD075
        NearCall(cs1, 0xD49E, font_select_small_font);
    label_100D_D49E_1D56E_14170:
        CheckExternalEvents(cs1, 0xD49E);
        // 100D:D49E mov SI,AX
        SI = AX;
        // 100D:D4A0 mov AL,0x0E
        AL = (byte)0x0E;
        // 100D:D4A2 mul CL
        ushort result_100D_D4A2_1D572 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_D4A2_1D572 >> 8));
        AL = unchecked((byte)result_100D_D4A2_1D572);
        // 100D:D4A4 mov DI,AX
        DI = AX;
        // 100D:D4A6 add DI,0x1B48
        DI = Alu16.Add(DI, (ushort)0x1B48);
        // 100D:D4AA mov BX,word ptr DS:[DI+2]
        BX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:D4AD inc BX
        BX = Alu16.Inc(BX);
        // 100D:D4AE mov DX,0x005D
        DX = (ushort)0x005D;
        // 100D:D4B1 call near 0xD04E
        NearCall(cs1, 0xD4B4, font_set_draw_position);
    label_100D_D4B4_1D584_14180:
        CheckExternalEvents(cs1, 0xD4B4);
        // 100D:D4B4 mov byte ptr DS:[0xDBE5],0xF3
        UInt8[DS, (ushort)0xDBE5] = (byte)0xF3;
        // 100D:D4B9 and byte ptr DS:[DI+8],0x7F
        UInt8[DS, (ushort)(DI + (sbyte)8)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x7F);
        // 100D:D4BD mov AX,SI
        AX = SI;
        // 100D:D4BF and SI,0x3FFF
        SI = Alu16.And(SI, (ushort)0x3FFF);
        // 100D:D4C3 je short 0xD4E9
        if (ZeroFlag)
        {
            goto label_100D_D4E9_1D5B9_14219;
        }
    label_100D_D4C5_1D595_14186:
        CheckExternalEvents(cs1, 0xD4C5);
        // 100D:D4C5 mov AL,0xF5
        AL = (byte)0xF5;
        // 100D:D4C7 test AH,0x40
        Alu8.And(AH, (byte)0x40);
        // 100D:D4CA jne short 0xD4DA
        if (!ZeroFlag)
        {
            goto label_100D_D4DA_1D5AA_14195;
        }
    label_100D_D4CC_1D59C_14190:
        CheckExternalEvents(cs1, 0xD4CC);
        // 100D:D4CC or byte ptr DS:[DI+8],0x80
        UInt8[DS, (ushort)(DI + (sbyte)8)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x80);
        // 100D:D4D0 mov AL,0xFA
        AL = (byte)0xFA;
        // 100D:D4D2 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:D4D4 jns short 0xD4DA
        if (!SignFlag)
        {
            goto label_100D_D4DA_1D5AA_14195;
        }
    label_100D_D4D6_1D5A6_15256:
        CheckExternalEvents(cs1, 0xD4D6);
        // 100D:D4D6 xchg AL,byte ptr DS:[0xDBE5]
        ushort xchgOffset_100D_D4D6_1D5A6 = (ushort)0xDBE5;
        byte temp_100D_D4D6_1D5A6 = AL;
        AL = UInt8[DS, xchgOffset_100D_D4D6_1D5A6];
        UInt8[DS, xchgOffset_100D_D4D6_1D5A6] = unchecked((byte)temp_100D_D4D6_1D5A6);
    label_100D_D4DA_1D5AA_14195:
        CheckExternalEvents(cs1, 0xD4DA);
        // 100D:D4DA mov byte ptr DS:[0xDBE4],AL
        UInt8[DS, (ushort)0xDBE4] = AL;
        // 100D:D4DD call near 0xCF70
        NearCall(cs1, 0xD4E0, get_phrase_or_command_string);
    label_100D_D4E0_1D5B0_14198:
        CheckExternalEvents(cs1, 0xD4E0);
        // 100D:D4E0 mov AL,0x20
        AL = (byte)0x20;
        // 100D:D4E2 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD12F:
                NearCall(cs1, 0xD4E6, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:D4E2");
        }
    label_100D_D4E6_1D5B6_14201:
        CheckExternalEvents(cs1, 0xD4E6);
        // 100D:D4E6 call near 0xD1BB
        NearCall(cs1, 0xD4E9, font_draw_string);
    label_100D_D4E9_1D5B9_14219:
        CheckExternalEvents(cs1, 0xD4E9);
        // 100D:D4E9 call near 0xD05F
        NearCall(cs1, 0xD4EC, font_get_draw_position);
    label_100D_D4EC_1D5BC_14221:
        CheckExternalEvents(cs1, 0xD4EC);
        // 100D:D4EC mov SI,0xDCE9
        SI = (ushort)0xDCE9;
        // 100D:D4EF mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:D4F1 mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        // 100D:D4F4 mov word ptr DS:[SI+4],0x00E3
        UInt16[DS, (ushort)(SI + (sbyte)4)] = (ushort)0x00E3;
        // 100D:D4F9 add BX,7
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:D4FC mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:D4FF mov AL,byte ptr DS:[0xDBE5]
        AL = UInt8[DS, (ushort)0xDBE5];
        // 100D:D502 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:D506 call far dword ptr DS:[0x38DD]
        ushort targetSegment_14230 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_14230 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_14230 == cs2 && targetOffset_14230 == 0x011E)
        {
            FarCall(cs1, 0xD50A, cs2, unknown_3358_011E_3369E);
            goto label_100D_D50A_1D5DA_14231;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_14230:X4}:{targetOffset_14230:X4} at 100D:D506");
    label_100D_D50A_1D5DA_14231:
        CheckExternalEvents(cs1, 0xD50A);
        // 100D:D50A pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_D50A_1D5DA = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_D50A_1D5DA = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_D50A_1D5DA = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_D50A_1D5DA);
        // 100D:D50E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action highlight_hovered_text_action_item(int loadOffset)
    {
    entrydispatcher:
    label_100D_D50F_1D5DF_14269:
        CheckExternalEvents(cs1, 0xD50F);
        // 100D:D50F push BX
        Stack.Push16(BX);
        // 100D:D510 push CX
        Stack.Push16(CX);
        // 100D:D511 push DX
        Stack.Push16(DX);
        // 100D:D512 push SI
        Stack.Push16(SI);
        // 100D:D513 push DI
        Stack.Push16(DI);
        // 100D:D514 push BP
        Stack.Push16(BP);
        // 100D:D515 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:D51A je short 0xD523
        if (ZeroFlag)
        {
            goto label_100D_D523_1D5F3_14278;
        }
    label_100D_D51C_1D5EC_28355:
        CheckExternalEvents(cs1, 0xD51C);
        // 100D:D51C mov CL,byte ptr DS:[0x4775]
        CL = UInt8[DS, (ushort)0x4775];
        // 100D:D520 jmp near 0xD5DD
        goto label_100D_D5DD_1D6AD_14320;
    label_100D_D523_1D5F3_14278:
        CheckExternalEvents(cs1, 0xD523);
        // 100D:D523 call near 0xD41B
        NearCall(cs1, 0xD526, get_location_and_room);
    label_100D_D526_1D5F6_14280:
        CheckExternalEvents(cs1, 0xD526);
        // 100D:D526 cmp BP,0x1F0E
        Alu16.Sub(BP, (ushort)0x1F0E);
        // 100D:D52A jne short 0xD575
        if (!ZeroFlag)
        {
            goto label_100D_D575_1D645_14306;
        }
    label_100D_D52C_1D5FC_14283:
        CheckExternalEvents(cs1, 0xD52C);
        // 100D:D52C cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:D531 jne short 0xD575
        if (!ZeroFlag)
        {
            goto label_100D_D575_1D645_14306;
        }
    label_100D_D533_1D603_14286:
        CheckExternalEvents(cs1, 0xD533);
        // 100D:D533 mov DI,0x1BF0
        DI = (ushort)0x1BF0;
        // 100D:D536 cmp byte ptr DS:[DI+8],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x00);
        // 100D:D53A jns short 0xD545
        if (!SignFlag)
        {
            goto label_100D_D545_1D615_14290;
        }
    label_100D_D53C_1D60C_25119:
        CheckExternalEvents(cs1, 0xD53C);
        // 100D:D53C call near 0xD6FE
        NearCall(cs1, 0xD53F, contains_interior);
    label_100D_D53F_1D60F_25121:
        CheckExternalEvents(cs1, 0xD53F);
        // 100D:D53F mov CX,word ptr DS:[0x47C4]
        CX = UInt16[DS, (ushort)0x47C4];
        // 100D:D543 jb short 0xD55D
        if (CarryFlag)
        {
            goto label_100D_D55D_1D62D_23053;
        }
    label_100D_D545_1D615_14290:
        CheckExternalEvents(cs1, 0xD545);
        // 100D:D545 push BP
        Stack.Push16(BP);
        // 100D:D546 call near 0x9285
        NearCall(cs1, 0xD549, person_hit_test);
    label_100D_D549_1D619_14303:
        CheckExternalEvents(cs1, 0xD549);
        // 100D:D549 pop BP
        BP = Stack.Pop16();
        // 100D:D54A jae short 0xD575
        if (!CarryFlag)
        {
            goto label_100D_D575_1D645_14306;
        }
    label_100D_D54C_1D61C_23049:
        CheckExternalEvents(cs1, 0xD54C);
        // 100D:D54C mov AL,CL
        AL = CL;
        // 100D:D54E sub AL,0x0F
        AL = Alu8.Sub(AL, (byte)0x0F);
        // 100D:D550 jb short 0xD55D
        if (CarryFlag)
        {
            goto label_100D_D55D_1D62D_23053;
        }
    label_100D_D552_1D622_25330:
        CheckExternalEvents(cs1, 0xD552);
        // 100D:D552 inc AL
        AL = Alu8.Inc(AL);
        // 100D:D554 cmp AL,byte ptr DS:[0x476B]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x476B]);
        // 100D:D558 jne short 0xD55D
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D558");
        }
    label_100D_D55D_1D62D_23053:
        CheckExternalEvents(cs1, 0xD55D);
        // 100D:D55D mov BP,CX
        BP = CX;
        // 100D:D55F add BP,0x0078
        BP = Alu16.Add(BP, (ushort)0x0078);
        // 100D:D563 xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_100D_D565_1D635_23057:
        CheckExternalEvents(cs1, 0xD565);
        // 100D:D565 call near 0xD454
        NearCall(cs1, 0xD568, slot_text_id);
    label_100D_D568_1D638_23058:
        CheckExternalEvents(cs1, 0xD568);
        // 100D:D568 cmp AX,BP
        Alu16.Sub(AX, BP);
        // 100D:D56A je short 0xD5DD
        if (ZeroFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D56C_1D63C_23061:
        CheckExternalEvents(cs1, 0xD56C);
        // 100D:D56C inc CX
        CX = Alu16.Inc(CX);
        // 100D:D56D cmp CL,byte ptr DS:[0xDCE8]
        Alu8.Sub(CL, UInt8[DS, (ushort)0xDCE8]);
        // 100D:D571 jb short 0xD565
        if (CarryFlag)
        {
            goto label_100D_D565_1D635_23057;
        }
    label_100D_D573_1D643_34524:
        CheckExternalEvents(cs1, 0xD573);
        // 100D:D573 jmp short 0xD5DB
        goto label_100D_D5DB_1D6AB_14943;
    label_100D_D575_1D645_14306:
        CheckExternalEvents(cs1, 0xD575);
        // 100D:D575 cmp BP,0x1F7E
        Alu16.Sub(BP, (ushort)0x1F7E);
        // 100D:D579 jne short 0xD5B1
        if (!ZeroFlag)
        {
            goto label_100D_D5B1_1D681_14309;
        }
    label_100D_D57B_1D64B_15545:
        CheckExternalEvents(cs1, 0xD57B);
        // 100D:D57B mov DI,0x1BE2
        DI = (ushort)0x1BE2;
        // 100D:D57E cmp byte ptr DS:[DI+8],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x00);
        // 100D:D582 jns short 0xD593
        if (!SignFlag)
        {
            goto label_100D_D593_1D663_15549;
        }
    label_100D_D584_1D654_16044:
        CheckExternalEvents(cs1, 0xD584);
        // 100D:D584 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:D586 call near 0xD6FE
        NearCall(cs1, 0xD589, contains_interior);
    label_100D_D589_1D659_16050:
        CheckExternalEvents(cs1, 0xD589);
        // 100D:D589 jb short 0xD5DD
        if (CarryFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D58B_1D65B_16052:
        CheckExternalEvents(cs1, 0xD58B);
        // 100D:D58B mov DI,0x1BF0
        DI = (ushort)0x1BF0;
        // 100D:D58E call near 0xD6FE
        NearCall(cs1, 0xD591, contains_interior);
    label_100D_D591_1D661_16055:
        CheckExternalEvents(cs1, 0xD591);
        // 100D:D591 jb short 0xD5DD
        if (CarryFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D593_1D663_15549:
        CheckExternalEvents(cs1, 0xD593);
        // 100D:D593 cmp byte ptr DS:[0x1BF8],0
        Alu8.Sub(UInt8[DS, (ushort)0x1BF8], (byte)0x00);
        // 100D:D598 jns short 0xD5B1
        if (!SignFlag)
        {
            goto label_100D_D5B1_1D681_14309;
        }
    label_100D_D59A_1D66A_15552:
        CheckExternalEvents(cs1, 0xD59A);
        // 100D:D59A mov DI,0x1BFE
        DI = (ushort)0x1BFE;
        // 100D:D59D call near 0xD6FE
        NearCall(cs1, 0xD5A0, contains_interior);
    label_100D_D5A0_1D670_15567:
        CheckExternalEvents(cs1, 0xD5A0);
        // 100D:D5A0 mov CL,3
        CL = (byte)0x03;
        // 100D:D5A2 jb short 0xD5DD
        if (CarryFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D5A4_1D674_15570:
        CheckExternalEvents(cs1, 0xD5A4);
        // 100D:D5A4 call near 0x92C9
        NearCall(cs1, 0xD5A7, companion_slot_hit_test);
    label_100D_D5A7_1D677_15572:
        CheckExternalEvents(cs1, 0xD5A7);
        // 100D:D5A7 jae short 0xD5B1
        if (!CarryFlag)
        {
            goto label_100D_D5B1_1D681_14309;
        }
    label_100D_D5A9_1D679_37286:
        CheckExternalEvents(cs1, 0xD5A9);
        // 100D:D5A9 cmp CX,word ptr DS:[0x47C4]
        Alu16.Sub(CX, UInt16[DS, (ushort)0x47C4]);
        // 100D:D5AD mov CL,2
        CL = (byte)0x02;
        // 100D:D5AF je short 0xD5DD
        if (ZeroFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D5B1_1D681_14309:
        CheckExternalEvents(cs1, 0xD5B1);
        // 100D:D5B1 cmp BX,0x0098
        Alu16.Sub(BX, (ushort)0x0098);
        // 100D:D5B5 jb short 0xD5DB
        if (CarryFlag)
        {
            goto label_100D_D5DB_1D6AB_14943;
        }
    label_100D_D5B7_1D687_14312:
        CheckExternalEvents(cs1, 0xD5B7);
        // 100D:D5B7 mov CL,0xFF
        CL = (byte)0xFF;
        // 100D:D5B9 mov DI,0x1B48
        DI = (ushort)0x1B48;
        // 100D:D5BC cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:D5BE jb short 0xD5DD
        if (CarryFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D5C0_1D690_14317:
        CheckExternalEvents(cs1, 0xD5C0);
        // 100D:D5C0 cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:D5C3 jae short 0xD5DD
        if (!CarryFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D5C5_1D695_15217:
        CheckExternalEvents(cs1, 0xD5C5);
        // 100D:D5C5 xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_100D_D5C7_1D697_15219:
        CheckExternalEvents(cs1, 0xD5C7);
        // 100D:D5C7 cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:D5CA jbe short 0xD5DB
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D5DB_1D6AB_14943;
        }
    label_100D_D5CC_1D69C_15221:
        CheckExternalEvents(cs1, 0xD5CC);
        // 100D:D5CC cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:D5CF jbe short 0xD5DD
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D5DD_1D6AD_14320;
        }
    label_100D_D5D1_1D6A1_15284:
        CheckExternalEvents(cs1, 0xD5D1);
        // 100D:D5D1 add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D5D4 inc CX
        CX = Alu16.Inc(CX);
        // 100D:D5D5 cmp CL,byte ptr DS:[0xDCE8]
        Alu8.Sub(CL, UInt8[DS, (ushort)0xDCE8]);
        // 100D:D5D9 jb short 0xD5C7
        if (CarryFlag)
        {
            goto label_100D_D5C7_1D697_15219;
        }
    label_100D_D5DB_1D6AB_14943:
        CheckExternalEvents(cs1, 0xD5DB);
        // 100D:D5DB mov CL,0xFF
        CL = (byte)0xFF;
    label_100D_D5DD_1D6AD_14320:
        CheckExternalEvents(cs1, 0xD5DD);
        // 100D:D5DD mov AL,CL
        AL = CL;
        // 100D:D5DF xchg CL,byte ptr DS:[0xDCE7]
        ushort xchgOffset_100D_D5DF_1D6AF = (ushort)0xDCE7;
        byte temp_100D_D5DF_1D6AF = CL;
        CL = UInt8[DS, xchgOffset_100D_D5DF_1D6AF];
        UInt8[DS, xchgOffset_100D_D5DF_1D6AF] = unchecked((byte)temp_100D_D5DF_1D6AF);
        // 100D:D5E3 cmp AL,CL
        Alu8.Sub(AL, CL);
        // 100D:D5E5 je short 0xD610
        if (ZeroFlag)
        {
            goto label_100D_D610_1D6E0_14325;
        }
    label_100D_D5E7_1D6B7_15224:
        CheckExternalEvents(cs1, 0xD5E7);
        // 100D:D5E7 call near 0xDBB2
        NearCall(cs1, 0xD5EA, call_restore_cursor);
    label_100D_D5EA_1D6BA_15226:
        CheckExternalEvents(cs1, 0xD5EA);
        // 100D:D5EA or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:D5EC js short 0xD5FC
        if (SignFlag)
        {
            goto label_100D_D5FC_1D6CC_15229;
        }
    label_100D_D5EE_1D6BE_15290:
        CheckExternalEvents(cs1, 0xD5EE);
        // 100D:D5EE cmp CL,byte ptr DS:[0xDCE8]
        Alu8.Sub(CL, UInt8[DS, (ushort)0xDCE8]);
        // 100D:D5F2 jae short 0xD5FC
        if (!CarryFlag)
        {
            goto label_100D_D5FC_1D6CC_15229;
        }
    label_100D_D5F4_1D6C4_15293:
        CheckExternalEvents(cs1, 0xD5F4);
        // 100D:D5F4 push AX
        Stack.Push16(AX);
        // 100D:D5F5 call near 0xD454
        NearCall(cs1, 0xD5F8, slot_text_id);
    label_100D_D5F8_1D6C8_15296:
        CheckExternalEvents(cs1, 0xD5F8);
        // 100D:D5F8 call near 0xD48A
        NearCall(cs1, 0xD5FB, draw_command_menu_item);
    label_100D_D5FB_1D6CB_15298:
        CheckExternalEvents(cs1, 0xD5FB);
        // 100D:D5FB pop AX
        AX = Stack.Pop16();
    label_100D_D5FC_1D6CC_15229:
        CheckExternalEvents(cs1, 0xD5FC);
        // 100D:D5FC cmp AL,byte ptr DS:[0xDCE8]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDCE8]);
        // 100D:D600 jae short 0xD60D
        if (!CarryFlag)
        {
            goto label_100D_D60D_1D6DD_15258;
        }
    label_100D_D602_1D6D2_15232:
        CheckExternalEvents(cs1, 0xD602);
        // 100D:D602 mov CX,AX
        CX = AX;
        // 100D:D604 call near 0xD454
        NearCall(cs1, 0xD607, slot_text_id);
    label_100D_D607_1D6D7_15253:
        CheckExternalEvents(cs1, 0xD607);
        // 100D:D607 or AH,0x80
        AH = Alu8.Or(AH, (byte)0x80);
        // 100D:D60A call near 0xD48A
        NearCall(cs1, 0xD60D, draw_command_menu_item);
    label_100D_D60D_1D6DD_15258:
        CheckExternalEvents(cs1, 0xD60D);
        // 100D:D60D call near 0xDBEC
        NearCall(cs1, 0xD610, draw_mouse);
    label_100D_D610_1D6E0_14325:
        CheckExternalEvents(cs1, 0xD610);
        // 100D:D610 pop BP
        BP = Stack.Pop16();
        // 100D:D611 pop DI
        DI = Stack.Pop16();
        // 100D:D612 pop SI
        SI = Stack.Pop16();
        // 100D:D613 pop DX
        DX = Stack.Pop16();
        // 100D:D614 pop CX
        CX = Stack.Pop16();
        // 100D:D615 pop BX
        BX = Stack.Pop16();
        // 100D:D616 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D617_1D6E7(int loadOffset)
    {
    entrydispatcher:
    label_100D_D617_1D6E7_8630:
        CheckExternalEvents(cs1, 0xD617);
        // 100D:D617 push AX
        Stack.Push16(AX);
        // 100D:D618 mov AX,0x0090
        AX = (ushort)0x0090;
        // 100D:D61B jmp short 0xD621
        if (JumpDispatcher.Jump(set_talk_to_me_verb_text, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_D61D_1D6ED(int loadOffset)
    {
    entrydispatcher:
    label_100D_D61D_1D6ED_3524:
        CheckExternalEvents(cs1, 0xD61D);
        // 100D:D61D push AX
        Stack.Push16(AX);
        // 100D:D61E mov AX,0x009F
        AX = (ushort)0x009F;
        if (JumpDispatcher.Jump(set_talk_to_me_verb_text, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
