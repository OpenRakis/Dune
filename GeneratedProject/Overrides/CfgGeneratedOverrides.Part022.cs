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
    public virtual Action unknown_100D_D64E_1D71E(int loadOffset)
    {
    label_100D_D64E_1D71E_19477:
        CheckExternalEvents(cs1, 0xD64E);
        // 100D:D64E push BX
        Stack.Push16(BX);
        // 100D:D64F push DX
        Stack.Push16(DX);
        // 100D:D650 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:D652 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:D654 call near 0xD50F
        NearCall(cs1, 0xD657, highlight_hovered_text_action_item);
    label_100D_D657_1D727_19483:
        CheckExternalEvents(cs1, 0xD657);
        // 100D:D657 pop DX
        DX = Stack.Pop16();
        // 100D:D658 pop BX
        BX = Stack.Pop16();
        // 100D:D659 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D65A_1D72A(int loadOffset)
    {
    label_100D_D65A_1D72A_15384:
        CheckExternalEvents(cs1, 0xD65A);
        // 100D:D65A test byte ptr DS:[DI+9],0x20
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)9)], (byte)0x20);
        // 100D:D65E je short 0xD676
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D65E");
        }
    label_100D_D676_1D746_15387:
        CheckExternalEvents(cs1, 0xD676);
        // 100D:D676 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D694_1D764(int loadOffset)
    {
    label_100D_D694_1D764_15328:
        CheckExternalEvents(cs1, 0xD694);
        // 100D:D694 mov AX,word ptr DS:[0x2582]
        AX = UInt16[DS, (ushort)0x2582];
        // 100D:D697 mov DI,0x1B9C
        DI = (ushort)0x1B9C;
        // 100D:D69A cmp AX,0x260C
        Alu16.Sub(AX, (ushort)0x260C);
        // 100D:D69D je short 0xD6B5
        if (ZeroFlag)
        {
            goto label_100D_D6B5_1D785_15344;
        }
    label_100D_D69F_1D76F_15333:
        CheckExternalEvents(cs1, 0xD69F);
        // 100D:D69F add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D6A2 cmp AX,0x2650
        Alu16.Sub(AX, (ushort)0x2650);
        // 100D:D6A5 je short 0xD6B5
        if (ZeroFlag)
        {
            goto label_100D_D6B5_1D785_15344;
        }
    label_100D_D6A7_1D777_15337:
        CheckExternalEvents(cs1, 0xD6A7);
        // 100D:D6A7 add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D6AA cmp AX,0x2694
        Alu16.Sub(AX, (ushort)0x2694);
        // 100D:D6AD je short 0xD6B5
        if (ZeroFlag)
        {
            goto label_100D_D6B5_1D785_15344;
        }
    label_100D_D6AF_1D77F_15341:
        CheckExternalEvents(cs1, 0xD6AF);
        // 100D:D6AF add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D6B2 cmp AX,0x26D8
        Alu16.Sub(AX, (ushort)0x26D8);
    label_100D_D6B5_1D785_15344:
        CheckExternalEvents(cs1, 0xD6B5);
        // 100D:D6B5 stc
        CarryFlag = true;
        // 100D:D6B6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action hit_test_ui_elements(int loadOffset)
    {
    label_100D_D6B7_1D787_15326:
        CheckExternalEvents(cs1, 0xD6B7);
        // 100D:D6B7 call near 0xD694
        NearCall(cs1, 0xD6BA, unknown_100D_D694_1D764);
    label_100D_D6BA_1D78A_15346:
        CheckExternalEvents(cs1, 0xD6BA);
        // 100D:D6BA je short 0xD6FD
        if (ZeroFlag)
        {
            goto label_100D_D6FD_1D7CD_15377;
        }
    label_100D_D6BC_1D78C_15348:
        CheckExternalEvents(cs1, 0xD6BC);
        // 100D:D6BC mov DI,0x1AE4
        DI = (ushort)0x1AE4;
        // 100D:D6BF mov CX,word ptr DS:[DI]
        CX = UInt16[DS, DI];
        // 100D:D6C1 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:D6C4 cmp word ptr DS:[0x2570],0x1AD6
        Alu16.Sub(UInt16[DS, (ushort)0x2570], (ushort)0x1AD6);
        // 100D:D6CA jne short 0xD6CF
        if (!ZeroFlag)
        {
            goto label_100D_D6CF_1D79F_15354;
        }
    label_100D_D6CC_1D79C_25524:
        CheckExternalEvents(cs1, 0xD6CC);
        // 100D:D6CC sub CX,5
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)5)));
    label_100D_D6CF_1D79F_15354:
        CheckExternalEvents(cs1, 0xD6CF);
        // 100D:D6CF cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:D6D4 je short 0xD6DC
        if (ZeroFlag)
        {
            goto label_100D_D6DC_1D7AC_15357;
        }
    label_100D_D6D6_1D7A6_37894:
        CheckExternalEvents(cs1, 0xD6D6);
        // 100D:D6D6 mov CX,5
        CX = (ushort)0x0005;
        // 100D:D6D9 mov DI,0x1B48
        DI = (ushort)0x1B48;
    label_100D_D6DC_1D7AC_15357:
        CheckExternalEvents(cs1, 0xD6DC);
        // 100D:D6DC cmp byte ptr DS:[DI+8],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x00);
        // 100D:D6E0 jns short 0xD6F7
        if (!SignFlag)
        {
            goto label_100D_D6F7_1D7C7_15360;
        }
    label_100D_D6E2_1D7B2_15363:
        CheckExternalEvents(cs1, 0xD6E2);
        // 100D:D6E2 cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:D6E4 jbe short 0xD6F7
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D6F7_1D7C7_15360;
        }
    label_100D_D6E6_1D7B6_15366:
        CheckExternalEvents(cs1, 0xD6E6);
        // 100D:D6E6 cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:D6E9 jae short 0xD6F7
        if (!CarryFlag)
        {
            goto label_100D_D6F7_1D7C7_15360;
        }
    label_100D_D6EB_1D7BB_15369:
        CheckExternalEvents(cs1, 0xD6EB);
        // 100D:D6EB cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:D6EE jbe short 0xD6F7
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D6F7_1D7C7_15360;
        }
    label_100D_D6F0_1D7C0_15372:
        CheckExternalEvents(cs1, 0xD6F0);
        // 100D:D6F0 dec BX
        BX = Alu16.Dec(BX);
        // 100D:D6F1 cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:D6F4 inc BX
        BX = Alu16.Inc(BX);
        // 100D:D6F5 jb short 0xD6FD
        if (CarryFlag)
        {
            goto label_100D_D6FD_1D7CD_15377;
        }
    label_100D_D6F7_1D7C7_15360:
        CheckExternalEvents(cs1, 0xD6F7);
        // 100D:D6F7 add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:D6FA loop 0xD6DC
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D6DC_1D7AC_15357;
        }
    label_100D_D6FC_1D7CC_21345:
        CheckExternalEvents(cs1, 0xD6FC);
        // 100D:D6FC clc
        CarryFlag = false;
    label_100D_D6FD_1D7CD_15377:
        CheckExternalEvents(cs1, 0xD6FD);
        // 100D:D6FD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action contains_interior(int loadOffset)
    {
    label_100D_D6FE_1D7CE_15555:
        CheckExternalEvents(cs1, 0xD6FE);
        // 100D:D6FE cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:D700 jbe short 0xD710
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D710_1D7E0_16047;
        }
    label_100D_D702_1D7D2_15558:
        CheckExternalEvents(cs1, 0xD702);
        // 100D:D702 cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:D705 jae short 0xD710
        if (!CarryFlag)
        {
            goto label_100D_D710_1D7E0_16047;
        }
    label_100D_D707_1D7D7_15561:
        CheckExternalEvents(cs1, 0xD707);
        // 100D:D707 cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:D70A jbe short 0xD710
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_D710_1D7E0_16047;
        }
    label_100D_D70C_1D7DC_15564:
        CheckExternalEvents(cs1, 0xD70C);
        // 100D:D70C cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:D70F ret near
        return NearRet((ushort)0x0000);
    label_100D_D710_1D7E0_16047:
        CheckExternalEvents(cs1, 0xD710);
        // 100D:D710 clc
        CarryFlag = false;
        // 100D:D711 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_setup_and_draw_nav_panel(int loadOffset)
    {
    label_100D_D717_1D7E7_13523:
        CheckExternalEvents(cs1, 0xD717);
        // 100D:D717 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:D71C jne short 0xD712
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:D71C");
        }
    label_100D_D71E_1D7EE_13526:
        CheckExternalEvents(cs1, 0xD71E);
        // 100D:D71E mov SI,0x1C76
        SI = (ushort)0x1C76;
        // 100D:D721 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:D726 je short 0xD72B
        if (ZeroFlag)
        {
            return ui_install_nav_panel(0x0000);
        }
    label_100D_D728_1D7F8_21575:
        CheckExternalEvents(cs1, 0xD728);
        // 100D:D728 mov SI,0x1D72
        SI = (ushort)0x1D72;
        return ui_install_nav_panel(0x0000);
    }

    public virtual Action ui_install_nav_panel(int loadOffset)
    {
    label_100D_D72B_1D7FB_13530:
        CheckExternalEvents(cs1, 0xD72B);
        // 100D:D72B push DS
        Stack.Push16(DS);
        // 100D:D72C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D72D mov DI,0x1B8E
        DI = (ushort)0x1B8E;
        // 100D:D730 mov CX,0x002A
        CX = (ushort)0x002A;
        // 100D:D733 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        return ui_draw_nav_panel(0x0000);
    }

    public virtual Action unknown_100D_D741_1D811(int loadOffset)
    {
    label_100D_D741_1D811_13537:
        CheckExternalEvents(cs1, 0xD741);
        // 100D:D741 mov AX,word ptr DS:[0x1B0C]
        AX = UInt16[DS, (ushort)0x1B0C];
        // 100D:D744 sub AX,3
        AX = Alu16.Sub(AX, (ushort)0x0003);
        // 100D:D747 cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        // 100D:D74A jae short 0xD759
        if (!CarryFlag)
        {
            goto label_100D_D759_1D829_13547;
        }
    label_100D_D74C_1D81C_13542:
        CheckExternalEvents(cs1, 0xD74C);
        // 100D:D74C mov SI,0x2458
        SI = (ushort)0x2458;
        // 100D:D74F mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:D753 mov AL,0xF0
        AL = (byte)0xF0;
        // 100D:D755 call far dword ptr DS:[0x38DD]
        ushort targetSegment_13546 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_13546 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_13546 == cs2 && targetOffset_13546 == 0x011E)
        {
            FarCall(cs1, 0xD759, cs2, unknown_3358_011E_3369E);
            goto label_100D_D759_1D829_13547;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_13546:X4}:{targetOffset_13546:X4} at 100D:D755");
    label_100D_D759_1D829_13547:
        CheckExternalEvents(cs1, 0xD759);
        // 100D:D759 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_set_and_draw_frieze_sides_closed_book(int loadOffset)
    {
    label_100D_D75A_1D82A_13293:
        CheckExternalEvents(cs1, 0xD75A);
        // 100D:D75A mov SI,0x1C36
        SI = (ushort)0x1C36;
        // 100D:D75D call near 0xD795
        NearCall(cs1, 0xD760, ui_set_and_draw_frieze_sides);
    label_100D_D760_1D830_13311:
        CheckExternalEvents(cs1, 0xD760);
        // 100D:D760 call near 0x1A34
        NearCall(cs1, 0xD763, ui_draw_date_and_time_indicator);
        return ui_hud_draw_companions(0x0000);
    }

    public virtual Action ui_hud_draw_companions(int loadOffset)
    {
    label_100D_D763_1D833_13493:
        CheckExternalEvents(cs1, 0xD763);
        // 100D:D763 mov SI,0x1C0C
        SI = (ushort)0x1C0C;
        // 100D:D766 mov AX,0x0040
        AX = (ushort)0x0040;
        // 100D:D769 mov word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = AX;
        // 100D:D76C mov word ptr DS:[SI+0x18],AX
        UInt16[DS, (ushort)(SI + (sbyte)24)] = AX;
        // 100D:D76F mov CX,2
        CX = (ushort)0x0002;
        // 100D:D772 call near 0xD1F2
        NearCall(cs1, 0xD775, draw_ui_elements_list);
    label_100D_D775_1D845_13500:
        CheckExternalEvents(cs1, 0xD775);
        // 100D:D775 mov SI,0x1C0C
        SI = (ushort)0x1C0C;
        // 100D:D778 mov AL,byte ptr DS:[0x1152]
        AL = UInt8[DS, (ushort)0x1152];
        // 100D:D77B cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:D77C add AX,0x0041
        AX = Alu16.Add(AX, (ushort)0x0041);
        // 100D:D77F mov word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = AX;
        // 100D:D782 mov AL,byte ptr DS:[0x1153]
        AL = UInt8[DS, (ushort)0x1153];
        // 100D:D785 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:D786 add AX,0x0041
        AX = Alu16.Add(AX, (ushort)0x0041);
        // 100D:D789 mov word ptr DS:[SI+0x18],AX
        UInt16[DS, (ushort)(SI + (sbyte)24)] = AX;
        // 100D:D78C mov CX,2
        CX = (ushort)0x0002;
        // 100D:D78F jmp near 0xD1F2
        return draw_ui_elements_list(0x0000);
    }

    public virtual Action ui_set_and_draw_frieze_sides_map(int loadOffset)
    {
    label_100D_D792_1D862_18381:
        CheckExternalEvents(cs1, 0xD792);
        // 100D:D792 mov SI,0x1C66
        SI = (ushort)0x1C66;
        return ui_set_and_draw_frieze_sides(0x0000);
    }

    public virtual Action ui_set_and_draw_frieze_sides(int loadOffset)
    {
    label_100D_D795_1D865_13296:
        CheckExternalEvents(cs1, 0xD795);
        // 100D:D795 push DS
        Stack.Push16(DS);
        // 100D:D796 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:D797 mov DI,0x1AEE
        DI = (ushort)0x1AEE;
        // 100D:D79A mov CX,4
        CX = (ushort)0x0004;
    label_100D_D79D_1D86D_13301:
        CheckExternalEvents(cs1, 0xD79D);
        // 100D:D79D movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:D79E movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:D79F add DI,0x000A
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:D7A2 loop 0xD79D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D79D_1D86D_13301;
        }
    label_100D_D7A4_1D874_13306:
        CheckExternalEvents(cs1, 0xD7A4);
        // 100D:D7A4 mov SI,0x1AE6
        SI = (ushort)0x1AE6;
        // 100D:D7A7 mov CX,3
        CX = (ushort)0x0003;
        // 100D:D7AA jmp near 0xD1F2
        return draw_ui_elements_list(0x0000);
    }

    public virtual Action ui_set_and_draw_frieze_sides_open_book(int loadOffset)
    {
    label_100D_D7AD_1D87D_16376:
        CheckExternalEvents(cs1, 0xD7AD);
        // 100D:D7AD mov SI,0x1C56
        SI = (ushort)0x1C56;
        // 100D:D7B0 jmp short 0xD795
        return ui_set_and_draw_frieze_sides(0x0000);
    }

    public virtual Action ui_set_and_draw_frieze_sides_globe(int loadOffset)
    {
    label_100D_D7B2_1D882_18598:
        CheckExternalEvents(cs1, 0xD7B2);
        // 100D:D7B2 mov SI,0x1C46
        SI = (ushort)0x1C46;
        // 100D:D7B5 jmp short 0xD795
        return ui_set_and_draw_frieze_sides(0x0000);
    }

    public virtual Action ui_hud_companion_blink_task(int loadOffset)
    {
    label_100D_D7B7_1D887_14630:
        CheckExternalEvents(cs1, 0xD7B7);
        // 100D:D7B7 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D7BA shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:D7BC shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:D7BE cmp AH,byte ptr DS:[0xDCF1]
        Alu8.Sub(AH, UInt8[DS, (ushort)0xDCF1]);
        // 100D:D7C2 je short 0xD814
        if (ZeroFlag)
        {
            goto label_100D_D814_1D8E4_14641;
        }
    label_100D_D7C4_1D894_14636:
        CheckExternalEvents(cs1, 0xD7C4);
        // 100D:D7C4 mov byte ptr DS:[0xDCF1],AH
        UInt8[DS, (ushort)0xDCF1] = AH;
        // 100D:D7C8 mov AX,word ptr DS:[0x2222]
        AX = UInt16[DS, (ushort)0x2222];
        // 100D:D7CB or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:D7CD je short 0xD814
        if (ZeroFlag)
        {
            goto label_100D_D814_1D8E4_14641;
        }
    label_100D_D7CF_1D89F_23137:
        CheckExternalEvents(cs1, 0xD7CF);
        // 100D:D7CF mov BX,word ptr DS:[0x1152]
        BX = UInt16[DS, (ushort)0x1152];
        // 100D:D7D3 push BX
        Stack.Push16(BX);
        // 100D:D7D4 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:D7D6 je short 0xD7E0
        if (ZeroFlag)
        {
            goto label_100D_D7E0_1D8B0_23148;
        }
    label_100D_D7D8_1D8A8_23142:
        CheckExternalEvents(cs1, 0xD7D8);
        // 100D:D7D8 dec AL
        AL = Alu8.Dec(AL);
        // 100D:D7DA test AL,1
        Alu8.And(AL, (byte)0x01);
        // 100D:D7DC je short 0xD7E0
        if (ZeroFlag)
        {
            goto label_100D_D7E0_1D8B0_23148;
        }
    label_100D_D7DE_1D8AE_23146:
        CheckExternalEvents(cs1, 0xD7DE);
        // 100D:D7DE mov BL,0xFF
        BL = (byte)0xFF;
    label_100D_D7E0_1D8B0_23148:
        CheckExternalEvents(cs1, 0xD7E0);
        // 100D:D7E0 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:D7E2 je short 0xD7ED
        if (ZeroFlag)
        {
            goto label_100D_D7ED_1D8BD_23150;
        }
    label_100D_D7E4_1D8B4_30332:
        CheckExternalEvents(cs1, 0xD7E4);
        // 100D:D7E4 dec AH
        AH = Alu8.Dec(AH);
        // 100D:D7E6 test AH,1
        Alu8.And(AH, (byte)0x01);
        // 100D:D7E9 je short 0xD7ED
        if (ZeroFlag)
        {
            goto label_100D_D7ED_1D8BD_23150;
        }
    label_100D_D7EB_1D8BB_30336:
        CheckExternalEvents(cs1, 0xD7EB);
        // 100D:D7EB mov BH,0xFF
        BH = (byte)0xFF;
    label_100D_D7ED_1D8BD_23150:
        CheckExternalEvents(cs1, 0xD7ED);
        // 100D:D7ED mov word ptr DS:[0x2222],AX
        UInt16[DS, (ushort)0x2222] = AX;
        // 100D:D7F0 mov word ptr DS:[0x1152],BX
        UInt16[DS, (ushort)0x1152] = BX;
        // 100D:D7F4 cmp word ptr DS:[0x1AFE],0
        Alu16.Sub(UInt16[DS, (ushort)0x1AFE], (ushort)0x0000);
        // 100D:D7FA jne short 0xD810
        if (!ZeroFlag)
        {
            goto label_100D_D810_1D8E0_23167;
        }
    label_100D_D7FC_1D8CC_23155:
        CheckExternalEvents(cs1, 0xD7FC);
        // 100D:D7FC push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:D800 call near 0xC137
        NearCall(cs1, 0xD803, open_icones_spritesheet);
    label_100D_D803_1D8D3_23158:
        CheckExternalEvents(cs1, 0xD803);
        // 100D:D803 call near 0xDBB2
        NearCall(cs1, 0xD806, call_restore_cursor);
    label_100D_D806_1D8D6_23160:
        CheckExternalEvents(cs1, 0xD806);
        // 100D:D806 call near 0xD763
        NearCall(cs1, 0xD809, ui_hud_draw_companions);
    label_100D_D809_1D8D9_23162:
        CheckExternalEvents(cs1, 0xD809);
        // 100D:D809 call near 0xDBEC
        NearCall(cs1, 0xD80C, draw_mouse);
    label_100D_D80C_1D8DC_23164:
        CheckExternalEvents(cs1, 0xD80C);
        // 100D:D80C pop AX
        AX = Stack.Pop16();
        // 100D:D80D call near 0xC13E
        NearCall(cs1, 0xD810, open_sprite_bank);
    label_100D_D810_1D8E0_23167:
        CheckExternalEvents(cs1, 0xD810);
        // 100D:D810 pop word ptr DS:[0x1152]
        ushort popStackCheck_100D_D810_1D8E0 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_D810_1D8E0 = UInt16[DS, (ushort)0x1152];
        ushort poppedValue_100D_D810_1D8E0 = Stack.Pop16();
        UInt16[DS, (ushort)0x1152] = unchecked((ushort)poppedValue_100D_D810_1D8E0);
    label_100D_D814_1D8E4_14641:
        CheckExternalEvents(cs1, 0xD814);
        // 100D:D814 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action exit_to_dos(int loadOffset)
    {
    entrydispatcher:
    label_100D_D815_1D8E5_14619:
        CheckExternalEvents(cs1, 0xD815);
        // 100D:D815 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D818 mov word ptr DS:[0xDC68],AX
        UInt16[DS, (ushort)0xDC68] = AX;
        // 100D:D81B mov byte ptr DS:[0xDC4B],0
        UInt8[DS, (ushort)0xDC4B] = (byte)0x00;
    label_100D_D820_1D8F0_14623:
        CheckExternalEvents(cs1, 0xD820);
        // 100D:D820 cmp byte ptr DS:[0xCEE8],0x2F
        Alu8.Sub(UInt8[DS, (ushort)0xCEE8], (byte)0x2F);
        // 100D:D825 jne short 0xD831
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:D825");
        }
    label_100D_D831_1D901_14625:
        CheckExternalEvents(cs1, 0xD831);
        // 100D:D831 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:D836 jne short 0xD83E
        if (!ZeroFlag)
        {
            goto label_100D_D83E_1D90E_14681;
        }
    label_100D_D838_1D908_14628:
        CheckExternalEvents(cs1, 0xD838);
        // 100D:D838 call near 0xD7B7
        NearCall(cs1, 0xD83B, ui_hud_companion_blink_task);
    label_100D_D83B_1D90B_14643:
        CheckExternalEvents(cs1, 0xD83B);
        // 100D:D83B call near 0x1B0D
        NearCall(cs1, 0xD83E, unknown_100D_1B0D_11BDD);
    label_100D_D83E_1D90E_14681:
        CheckExternalEvents(cs1, 0xD83E);
        // 100D:D83E call near 0xD9D2
        NearCall(cs1, 0xD841, process_frame_tasks);
    label_100D_D841_1D911_14690:
        CheckExternalEvents(cs1, 0xD841);
        // 100D:D841 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:D846 je short 0xD84B
        if (ZeroFlag)
        {
            goto label_100D_D84B_1D91B_14693;
        }
    label_100D_D848_1D918_37541:
        CheckExternalEvents(cs1, 0xD848);
        // 100D:D848 call near 0x0D8E
        NearCall(cs1, 0xD84B, unknown_100D_0D8E_10E5E);
    label_100D_D84B_1D91B_14693:
        CheckExternalEvents(cs1, 0xD84B);
        // 100D:D84B call near 0xE3CC
        NearCall(cs1, 0xD84E, rand);
    label_100D_D84E_1D91E_14695:
        CheckExternalEvents(cs1, 0xD84E);
        // 100D:D84E mov word ptr DS:[0],AX
        UInt16[DS, (ushort)0x0000] = AX;
        // 100D:D851 call near 0x4F0C
        NearCall(cs1, 0xD854, travel_pump);
    label_100D_D854_1D924_14703:
        CheckExternalEvents(cs1, 0xD854);
        // 100D:D854 cmp byte ptr DS:[0xDC4B],0
        Alu8.Sub(UInt8[DS, (ushort)0xDC4B], (byte)0x00);
        // 100D:D859 je short 0xD860
        if (ZeroFlag)
        {
            goto label_100D_D860_1D930_14706;
        }
    label_100D_D85B_1D92B_38848:
        CheckExternalEvents(cs1, 0xD85B);
        // 100D:D85B call near 0xD962
        NearCall(cs1, 0xD85E, unknown_100D_D962_1DA32);
    label_100D_D85E_1D92E_38958:
        CheckExternalEvents(cs1, 0xD85E);
        // 100D:D85E jmp short 0xD866
        goto label_100D_D866_1D936_14778;
    label_100D_D860_1D930_14706:
        CheckExternalEvents(cs1, 0xD860);
        // 100D:D860 call near 0xDF1E
        NearCall(cs1, 0xD863, get_mouse_pos_etc);
    label_100D_D863_1D933_14764:
        CheckExternalEvents(cs1, 0xD863);
        // 100D:D863 call near 0xDB4C
        NearCall(cs1, 0xD866, mouse_stuff);
    label_100D_D866_1D936_14778:
        CheckExternalEvents(cs1, 0xD866);
        // 100D:D866 call near 0xDC20
        NearCall(cs1, 0xD869, redraw_mouse);
    label_100D_D869_1D939_14899:
        CheckExternalEvents(cs1, 0xD869);
        // 100D:D869 mov DI,DX
        DI = DX;
        // 100D:D86B xchg DI,word ptr DS:[0xDC62]
        ushort xchgOffset_100D_D86B_1D93B = (ushort)0xDC62;
        ushort temp_100D_D86B_1D93B = DI;
        DI = UInt16[DS, xchgOffset_100D_D86B_1D93B];
        UInt16[DS, xchgOffset_100D_D86B_1D93B] = unchecked((ushort)temp_100D_D86B_1D93B);
        // 100D:D86F mov CX,BX
        CX = BX;
        // 100D:D871 xchg CX,word ptr DS:[0xDC64]
        ushort xchgOffset_100D_D871_1D941 = (ushort)0xDC64;
        ushort temp_100D_D871_1D941 = CX;
        CX = UInt16[DS, xchgOffset_100D_D871_1D941];
        UInt16[DS, xchgOffset_100D_D871_1D941] = unchecked((ushort)temp_100D_D871_1D941);
        // 100D:D875 sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 100D:D877 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 100D:D879 neg DI
        DI = Alu16.Sub((ushort)0x0000, DI);
        CarryFlag = DI != (ushort)0x0000;
        // 100D:D87B neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:D87D mov SI,word ptr DS:[0x2570]
        SI = UInt16[DS, (ushort)0x2570];
        // 100D:D881 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:D884 jne short 0xD893
        if (!ZeroFlag)
        {
            goto label_100D_D893_1D963_15300;
        }
    label_100D_D886_1D956_14911:
        CheckExternalEvents(cs1, 0xD886);
        // 100D:D886 call near 0xD50F
        NearCall(cs1, 0xD889, highlight_hovered_text_action_item);
    label_100D_D889_1D959_14945:
        CheckExternalEvents(cs1, 0xD889);
        // 100D:D889 mov AX,CX
        AX = CX;
        // 100D:D88B or AX,DI
        AX = Alu16.Or(AX, DI);
        // 100D:D88D je short 0xD88F
    label_100D_D88F_1D95F_14949:
        CheckExternalEvents(cs1, 0xD88F);
        // 100D:D88F call near word ptr DS:[SI]
        switch ((ushort)(UInt16[DS, SI]))
        {
            case 0x0F66:
                NearCall(cs1, 0xD891, globe_mouse_noop);
                break;
            case 0x1AE7:
                NearCall(cs1, 0xD891, room_mouse_idle);
                break;
            case 0x4586:
                NearCall(cs1, 0xD891, map_mouse_hover_tracker);
                break;
            case 0x5C03:
                NearCall(cs1, 0xD891, dune_map_mouse_idle);
                break;
            case 0xBC1F:
                NearCall(cs1, 0xD891, globe_mouse_idle);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, SI])):X4} at 100D:D88F");
        }
    label_100D_D891_1D961_14956:
        CheckExternalEvents(cs1, 0xD891);
        // 100D:D891 jmp short 0xD820
        goto label_100D_D820_1D8F0_14623;
    label_100D_D893_1D963_15300:
        CheckExternalEvents(cs1, 0xD893);
        // 100D:D893 mov BP,word ptr DS:[0xCE7A]
        BP = UInt16[DS, (ushort)0xCE7A];
        // 100D:D897 mov word ptr DS:[0xDC5A],BP
        UInt16[DS, (ushort)0xDC5A] = BP;
        // 100D:D89B cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:D8A0 je short 0xD8B1
        if (ZeroFlag)
        {
            goto label_100D_D8B1_1D981_15305;
        }
    label_100D_D8A2_1D972_28367:
        CheckExternalEvents(cs1, 0xD8A2);
        // 100D:D8A2 and AL,5
        AL = Alu8.And(AL, (byte)0x05);
        // 100D:D8A4 cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:D8A6 jne short 0xD8D7
        if (!ZeroFlag)
        {
            goto label_100D_D8D7_1D9A7_16158;
        }
    label_100D_D8A8_1D978_28371:
        CheckExternalEvents(cs1, 0xD8A8);
        // 100D:D8A8 call near 0xDBB2
        NearCall(cs1, 0xD8AB, call_restore_cursor);
    label_100D_D8AB_1D97B_28373:
        CheckExternalEvents(cs1, 0xD8AB);
        // 100D:D8AB call near 0x1707
        NearCall(cs1, 0xD8AE, menu_callback_choice_continue_for_sequence);
    label_100D_D8AE_1D97E_28909:
        CheckExternalEvents(cs1, 0xD8AE);
        // 100D:D8AE jmp near 0xD820
        goto label_100D_D820_1D8F0_14623;
    label_100D_D8B1_1D981_15305:
        CheckExternalEvents(cs1, 0xD8B1);
        // 100D:D8B1 test AL,5
        Alu8.And(AL, (byte)0x05);
        // 100D:D8B3 jne short 0xD8BA
        if (!ZeroFlag)
        {
            goto label_100D_D8BA_1D98A_15308;
        }
    label_100D_D8B5_1D985_29944:
        CheckExternalEvents(cs1, 0xD8B5);
        // 100D:D8B5 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:D8B8 shr AX,1
        AX = Alu16.Shr(AX, 1);
    label_100D_D8BA_1D98A_15308:
        CheckExternalEvents(cs1, 0xD8BA);
        // 100D:D8BA and AL,5
        AL = Alu8.And(AL, (byte)0x05);
        // 100D:D8BC dec AL
        AL = Alu8.Dec(AL);
        // 100D:D8BE jne short 0xD8F4
        if (!ZeroFlag)
        {
            goto label_100D_D8F4_1D9C4_15312;
        }
    label_100D_D8C0_1D990_16150:
        CheckExternalEvents(cs1, 0xD8C0);
        // 100D:D8C0 mov BP,word ptr DS:[0xDC5C]
        BP = UInt16[DS, (ushort)0xDC5C];
        // 100D:D8C4 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:D8C6 jne short 0xD8DA
        if (!ZeroFlag)
        {
            goto label_100D_D8DA_1D9AA_28244;
        }
    label_100D_D8C8_1D998_16154:
        CheckExternalEvents(cs1, 0xD8C8);
        // 100D:D8C8 mov AX,CX
        AX = CX;
        // 100D:D8CA or AX,DI
        AX = Alu16.Or(AX, DI);
        // 100D:D8CC je short 0xD8D7
        if (ZeroFlag)
        {
            goto label_100D_D8D7_1D9A7_16158;
        }
    label_100D_D8CE_1D99E_19946:
        CheckExternalEvents(cs1, 0xD8CE);
        // 100D:D8CE call near 0xDBB2
        NearCall(cs1, 0xD8D1, call_restore_cursor);
    label_100D_D8D1_1D9A1_19948:
        CheckExternalEvents(cs1, 0xD8D1);
        // 100D:D8D1 mov AL,byte ptr DS:[0xDC35]
        AL = UInt8[DS, (ushort)0xDC35];
        // 100D:D8D4 call near word ptr DS:[SI+0x0A]
        switch ((ushort)(UInt16[DS, (ushort)(SI + (sbyte)10)]))
        {
            case 0x0F66:
                NearCall(cs1, 0xD8D7, globe_mouse_noop);
                break;
            case 0x4586:
                NearCall(cs1, 0xD8D7, map_mouse_hover_tracker);
                break;
            case 0x59C1:
                NearCall(cs1, 0xD8D7, dune_map_mouse_drag);
                break;
            case 0xA5DF:
                NearCall(cs1, 0xD8D7, unknown_100D_A5DF_1A6AF);
                break;
            case 0xD917:
                NearCall(cs1, 0xD8D7, room_mouse_lmb);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(SI + (sbyte)10)])):X4} at 100D:D8D4");
        }
    label_100D_D8D7_1D9A7_16158:
        CheckExternalEvents(cs1, 0xD8D7);
        // 100D:D8D7 jmp near 0xD820
        goto label_100D_D820_1D8F0_14623;
    label_100D_D8DA_1D9AA_28244:
        CheckExternalEvents(cs1, 0xD8DA);
        // 100D:D8DA mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D8DD sub AX,word ptr DS:[0xDC5E]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDC5E]);
        // 100D:D8E1 cmp AX,0x0032
        Alu16.Sub(AX, (ushort)0x0032);
        // 100D:D8E4 jb short 0xD8D7
        if (CarryFlag)
        {
            goto label_100D_D8D7_1D9A7_16158;
        }
    label_100D_D8E6_1D9B6_33413:
        CheckExternalEvents(cs1, 0xD8E6);
        // 100D:D8E6 call near 0xD6B7
        NearCall(cs1, 0xD8E9, hit_test_ui_elements);
    label_100D_D8E9_1D9B9_33415:
        CheckExternalEvents(cs1, 0xD8E9);
        // 100D:D8E9 jae short 0xD8D7
        if (!CarryFlag)
        {
            goto label_100D_D8D7_1D9A7_16158;
        }
    label_100D_D8EB_1D9BB_33417:
        CheckExternalEvents(cs1, 0xD8EB);
        // 100D:D8EB cmp DI,BP
        Alu16.Sub(DI, BP);
        // 100D:D8ED jne short 0xD8D7
        if (!ZeroFlag)
        {
            goto label_100D_D8D7_1D9A7_16158;
        }
    label_100D_D8EF_1D9BF_33420:
        CheckExternalEvents(cs1, 0xD8EF);
        // 100D:D8EF call near 0xDBB2
        NearCall(cs1, 0xD8F2, call_restore_cursor);
    label_100D_D8F2_1D9C2_33422:
        CheckExternalEvents(cs1, 0xD8F2);
        // 100D:D8F2 jmp short 0xD92B
        goto label_100D_D92B_1D9FB_15392;
    label_100D_D8F4_1D9C4_15312:
        CheckExternalEvents(cs1, 0xD8F4);
        // 100D:D8F4 call near 0xDBB2
        NearCall(cs1, 0xD8F7, call_restore_cursor);
    label_100D_D8F7_1D9C7_15314:
        CheckExternalEvents(cs1, 0xD8F7);
        // 100D:D8F7 call near 0xE26F
        NearCall(cs1, 0xD8FA, unknown_100D_E26F_1E33F);
    label_100D_D8FA_1D9CA_15318:
        CheckExternalEvents(cs1, 0xD8FA);
        // 100D:D8FA sub AL,3
        AL = Alu8.Sub(AL, (byte)0x03);
        // 100D:D8FC je short 0xD944
        if (ZeroFlag)
        {
            goto label_100D_D944_1DA14_16032;
        }
    label_100D_D8FE_1D9CE_15321:
        CheckExternalEvents(cs1, 0xD8FE);
        // 100D:D8FE cmp SI,word ptr DS:[0x2570]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x2570]);
        // 100D:D902 jne short 0xD90E
        if (!ZeroFlag)
        {
            goto label_100D_D90E_1D9DE_21360;
        }
    label_100D_D904_1D9D4_15324:
        CheckExternalEvents(cs1, 0xD904);
        // 100D:D904 call near 0xD6B7
        NearCall(cs1, 0xD907, hit_test_ui_elements);
    label_100D_D907_1D9D7_15379:
        CheckExternalEvents(cs1, 0xD907);
        // 100D:D907 jb short 0xD918
        if (CarryFlag)
        {
            goto label_100D_D918_1D9E8_15381;
        }
    label_100D_D909_1D9D9_21347:
        CheckExternalEvents(cs1, 0xD909);
        // 100D:D909 push SI
        Stack.Push16(SI);
        // 100D:D90A call near 0x9215
        NearCall(cs1, 0xD90D, callback_main_ui_element_21_22);
    label_100D_D90D_1D9DD_21358:
        CheckExternalEvents(cs1, 0xD90D);
        // 100D:D90D pop SI
        SI = Stack.Pop16();
    label_100D_D90E_1D9DE_21360:
        CheckExternalEvents(cs1, 0xD90E);
        // 100D:D90E mov AL,byte ptr DS:[0xDC35]
        AL = UInt8[DS, (ushort)0xDC35];
        // 100D:D911 call near word ptr DS:[SI+2]
        switch ((ushort)(UInt16[DS, (ushort)(SI + (sbyte)2)]))
        {
            case 0x450E:
                NearCall(cs1, 0xD914, map_mouse_lmb_select_destination);
                break;
            case 0x5C76:
                NearCall(cs1, 0xD914, dune_map_mouse_lmb);
                break;
            case 0x5CE4:
                NearCall(cs1, 0xD914, dune_map_mouse_rmb);
                break;
            case 0x81EC:
                NearCall(cs1, 0xD914, move_troop_pick_lmb);
                break;
            case 0xA576:
                NearCall(cs1, 0xD914, mixer_panel_lmb);
                break;
            case 0xBC64:
                NearCall(cs1, 0xD914, globe_mouse_lmb);
                break;
            case 0xD917:
                NearCall(cs1, 0xD914, room_mouse_lmb);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(SI + (sbyte)2)])):X4} at 100D:D911");
        }
    label_100D_D914_1D9E4_22127:
        CheckExternalEvents(cs1, 0xD914);
        // 100D:D914 jmp near 0xD820
        goto label_100D_D820_1D8F0_14623;
    label_100D_D918_1D9E8_15381:
        CheckExternalEvents(cs1, 0xD918);
        // 100D:D918 mov word ptr DS:[0xDC60],DI
        UInt16[DS, (ushort)0xDC60] = DI;
        // 100D:D91C call near 0xD65A
        NearCall(cs1, 0xD91F, unknown_100D_D65A_1D72A);
    label_100D_D91F_1D9EF_15389:
        CheckExternalEvents(cs1, 0xD91F);
        // 100D:D91F test byte ptr DS:[DI+9],0x40
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)9)], (byte)0x40);
        // 100D:D923 je short 0xD92B
        if (ZeroFlag)
        {
            goto label_100D_D92B_1D9FB_15392;
        }
    label_100D_D925_1D9F5_28198:
        CheckExternalEvents(cs1, 0xD925);
        // 100D:D925 mov word ptr DS:[0xDC5C],DI
        UInt16[DS, (ushort)0xDC5C] = DI;
        // 100D:D929 jmp short 0xD935
        goto label_100D_D935_1DA05_15395;
    label_100D_D92B_1D9FB_15392:
        CheckExternalEvents(cs1, 0xD92B);
        // 100D:D92B mov byte ptr DS:[0xCE9D],0
        UInt8[DS, (ushort)0xCE9D] = (byte)0x00;
        // 100D:D930 mov byte ptr DS:[0xCEBA],0
        UInt8[DS, (ushort)0xCEBA] = (byte)0x00;
    label_100D_D935_1DA05_15395:
        CheckExternalEvents(cs1, 0xD935);
        // 100D:D935 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D938 mov word ptr DS:[0xDC5E],AX
        UInt16[DS, (ushort)0xDC5E] = AX;
        // 100D:D93B mov AL,byte ptr DS:[0xDC35]
        AL = UInt8[DS, (ushort)0xDC35];
        // 100D:D93E call near word ptr DS:[DI+0x0C]
        switch ((ushort)(UInt16[DS, (ushort)(DI + (sbyte)12)]))
        {
            case 0x18EE:
                NearCall(cs1, 0xD941, ui_draw_palace_plan);
                break;
            case 0x3F15:
                NearCall(cs1, 0xD941, ui_click_move_up);
                break;
            case 0x3F1A:
                NearCall(cs1, 0xD941, ui_click_move_right);
                break;
            case 0x3F1F:
                NearCall(cs1, 0xD941, ui_click_move_down);
                break;
            case 0x3F24:
                NearCall(cs1, 0xD941, ui_click_move_left);
                break;
            case 0x5B05:
                NearCall(cs1, 0xD941, ui_click_map_center);
                break;
            case 0x7BED:
                NearCall(cs1, 0xD941, menu_callback_choice_map_troop_dialogue_ask_for_more_information);
                break;
            case 0x881F:
                NearCall(cs1, 0xD941, ui_click_map_left);
                break;
            case 0x8824:
                NearCall(cs1, 0xD941, ui_click_map_right);
                break;
            case 0x8829:
                NearCall(cs1, 0xD941, ui_click_map_up);
                break;
            case 0x882E:
                NearCall(cs1, 0xD941, ui_click_map_down);
                break;
            case 0x9215:
                NearCall(cs1, 0xD941, callback_main_ui_element_21_22);
                break;
            case 0x941D:
                NearCall(cs1, 0xD941, game_area_click);
                break;
            case 0x945B:
                NearCall(cs1, 0xD941, callback_main_ui_element_19);
                break;
            case 0xAED6:
                NearCall(cs1, 0xD941, callback_main_ui_element_03);
                break;
            case 0xAFB5:
                NearCall(cs1, 0xD941, callback_ui_element_book_next_page);
                break;
            case 0xAFC7:
                NearCall(cs1, 0xD941, callback_ui_element_book_prev_page);
                break;
            case 0xB1EE:
                NearCall(cs1, 0xD941, callback_main_ui_element_23);
                break;
            case 0xB8C6:
                NearCall(cs1, 0xD941, callback_main_ui_element_00);
                break;
            case 0xB9B9:
                NearCall(cs1, 0xD941, callback_globe_tilt_up);
                break;
            case 0xB9C0:
                NearCall(cs1, 0xD941, callback_globe_tilt_down);
                break;
            case 0xB9CC:
                NearCall(cs1, 0xD941, callback_globe_rotate_east);
                break;
            case 0xB9D3:
                NearCall(cs1, 0xD941, callback_globe_rotate_west);
                break;
            case 0xBC81:
                NearCall(cs1, 0xD941, callback_ui_element_globe_exit);
                break;
            case 0xD42F:
                NearCall(cs1, 0xD941, dispatch_command_menu_slot_4);
                break;
            case 0xD434:
                NearCall(cs1, 0xD941, dispatch_command_menu_slot_3);
                break;
            case 0xD439:
                NearCall(cs1, 0xD941, dispatch_command_menu_slot_2);
                break;
            case 0xD43E:
                NearCall(cs1, 0xD941, dispatch_command_menu_slot_1);
                break;
            case 0xD443:
                NearCall(cs1, 0xD941, dispatch_command_menu_slot_0);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(DI + (sbyte)12)])):X4} at 100D:D93E");
        }
    label_100D_D941_1DA11_16030:
        CheckExternalEvents(cs1, 0xD941);
        // 100D:D941 jmp near 0xD820
        goto label_100D_D820_1D8F0_14623;
    label_100D_D944_1DA14_16032:
        CheckExternalEvents(cs1, 0xD944);
        // 100D:D944 mov DI,word ptr DS:[0xDC5C]
        DI = UInt16[DS, (ushort)0xDC5C];
        // 100D:D948 mov word ptr DS:[0xDC5C],0
        UInt16[DS, (ushort)0xDC5C] = (ushort)0x0000;
        // 100D:D94E or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:D950 jne short 0xD92B
        if (!ZeroFlag)
        {
            goto label_100D_D92B_1D9FB_15392;
        }
    label_100D_D952_1DA22_16037:
        CheckExternalEvents(cs1, 0xD952);
        // 100D:D952 mov AL,byte ptr DS:[0xDC35]
        AL = UInt8[DS, (ushort)0xDC35];
        // 100D:D955 call near word ptr DS:[SI+6]
        switch ((ushort)(UInt16[DS, (ushort)(SI + (sbyte)6)]))
        {
            case 0x0F66:
                NearCall(cs1, 0xD958, globe_mouse_noop);
                break;
            case 0x599F:
                NearCall(cs1, 0xD958, dune_map_mouse_release);
                break;
            case 0xA5AA:
                NearCall(cs1, 0xD958, mixer_panel_release);
                break;
            case 0xD917:
                NearCall(cs1, 0xD958, room_mouse_lmb);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(SI + (sbyte)6)])):X4} at 100D:D955");
        }
    label_100D_D958_1DA28_16042:
        CheckExternalEvents(cs1, 0xD958);
        // 100D:D958 jmp near 0xD820
        goto label_100D_D820_1D8F0_14623;
    }

    public virtual Action room_mouse_lmb(int loadOffset)
    {
    label_100D_D917_1D9E7_16040:
        CheckExternalEvents(cs1, 0xD917);
        // 100D:D917 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action select_room_ui_table(int loadOffset)
    {
    label_100D_D95B_1DA2B_13555:
        CheckExternalEvents(cs1, 0xD95B);
        // 100D:D95B mov AX,0x2572
        AX = (ushort)0x2572;
        return unknown_100D_D95E_1DA2E(0x0000);
    }

    public virtual Action unknown_100D_D95E_1DA2E(int loadOffset)
    {
    label_100D_D95E_1DA2E_13557:
        CheckExternalEvents(cs1, 0xD95E);
        // 100D:D95E mov word ptr DS:[0x2570],AX
        UInt16[DS, (ushort)0x2570] = AX;
        // 100D:D961 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_D962_1DA32(int loadOffset)
    {
    label_100D_D962_1DA32_38849:
        CheckExternalEvents(cs1, 0xD962);
        // 100D:D962 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D965 sub AL,byte ptr DS:[0xDC4A]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)0xDC4A]);
        // 100D:D969 cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:D96B jb short 0xD9CF
        if (CarryFlag)
        {
            goto label_100D_D9CF_1DA9F_38855;
        }
    label_100D_D96D_1DA3D_38857:
        CheckExternalEvents(cs1, 0xD96D);
        // 100D:D96D mov CX,2
        CX = (ushort)0x0002;
        // 100D:D970 cmp AL,0x0C
        Alu8.Sub(AL, (byte)0x0C);
        // 100D:D972 jb short 0xD97A
        if (CarryFlag)
        {
            goto label_100D_D97A_1DA4A_38862;
        }
    label_100D_D974_1DA44_38864:
        CheckExternalEvents(cs1, 0xD974);
        VerifySpeculativeEntryOrFail(cs1, 0xD974, [(byte)0x49]);
        // 100D:D974 dec CX
        CX = Alu16.Dec(CX);
        VerifySpeculativeEntryOrFail(cs1, 0xD975, [(byte)0x3C, (byte)0x18]);
        // 100D:D975 cmp AL,0x18
        Alu8.Sub(AL, (byte)0x18);
        VerifySpeculativeEntryOrFail(cs1, 0xD977, [(byte)0x72, (byte)0x01]);
        // 100D:D977 jb short 0xD97A
        if (CarryFlag)
        {
            goto label_100D_D97A_1DA4A_38862;
        }
    label_100D_D979_1DA49_38872:
        CheckExternalEvents(cs1, 0xD979);
        VerifySpeculativeEntryOrFail(cs1, 0xD979, [(byte)0x49]);
        // 100D:D979 dec CX
        CX = Alu16.Dec(CX);
    label_100D_D97A_1DA4A_38862:
        CheckExternalEvents(cs1, 0xD97A);
        // 100D:D97A mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D97D mov byte ptr DS:[0xDC4A],AL
        UInt8[DS, (ushort)0xDC4A] = AL;
        // 100D:D980 dec byte ptr DS:[0xDC4B]
        UInt8[DS, (ushort)0xDC4B] = Alu8.Dec(UInt8[DS, (ushort)0xDC4B]);
        // 100D:D984 mov DX,word ptr DS:[0xDC4C]
        DX = UInt16[DS, (ushort)0xDC4C];
        // 100D:D988 mov BX,word ptr DS:[0xDC4E]
        BX = UInt16[DS, (ushort)0xDC4E];
        // 100D:D98C sub DX,word ptr DS:[0xDC36]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0xDC36]);
        // 100D:D990 je short 0xD9A3
        if (ZeroFlag)
        {
            goto label_100D_D9A3_1DA73_38878;
        }
    label_100D_D992_1DA62_38880:
        CheckExternalEvents(cs1, 0xD992);
        // 100D:D992 jcxz short 0xD99B
        if (CX == (ushort)0x0000)
        {
            goto label_100D_D99B_1DA6B_38883;
        }
    label_100D_D994_1DA64_38885:
        CheckExternalEvents(cs1, 0xD994);
        // 100D:D994 sar DX,CL
        DX = Alu16.Sar(DX, unchecked((int)CL));
        // 100D:D996 or DL,1
        DL = Alu8.Or(DL, (byte)0x01);
        // 100D:D999 jmp short 0xD9A3
        goto label_100D_D9A3_1DA73_38878;
    label_100D_D99B_1DA6B_38883:
        CheckExternalEvents(cs1, 0xD99B);
        VerifySpeculativeEntryOrFail(cs1, 0xD99B, [(byte)0x8B, (byte)0xC2]);
        // 100D:D99B mov AX,DX
        AX = DX;
        VerifySpeculativeEntryOrFail(cs1, 0xD99D, [(byte)0xD1, (byte)0xF8]);
        // 100D:D99D sar AX,1
        AX = Alu16.Sar(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xD99F, [(byte)0xD1, (byte)0xF8]);
        // 100D:D99F sar AX,1
        AX = Alu16.Sar(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xD9A1, [(byte)0x2B, (byte)0xD0]);
        // 100D:D9A1 sub DX,AX
        DX = Alu16.Sub(DX, AX);
    label_100D_D9A3_1DA73_38878:
        CheckExternalEvents(cs1, 0xD9A3);
        // 100D:D9A3 sub BX,word ptr DS:[0xDC38]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0xDC38]);
        // 100D:D9A7 je short 0xD9BA
        if (ZeroFlag)
        {
            goto label_100D_D9BA_1DA8A_38887;
        }
    label_100D_D9A9_1DA79_38889:
        CheckExternalEvents(cs1, 0xD9A9);
        // 100D:D9A9 jcxz short 0xD9B2
        if (CX == (ushort)0x0000)
        {
            goto label_100D_D9B2_1DA82_38894;
        }
    label_100D_D9AB_1DA7B_38896:
        CheckExternalEvents(cs1, 0xD9AB);
        // 100D:D9AB sar BX,CL
        BX = Alu16.Sar(BX, unchecked((int)CL));
        // 100D:D9AD or BL,1
        BL = Alu8.Or(BL, (byte)0x01);
        // 100D:D9B0 jmp short 0xD9BA
        goto label_100D_D9BA_1DA8A_38887;
    label_100D_D9B2_1DA82_38894:
        CheckExternalEvents(cs1, 0xD9B2);
        VerifySpeculativeEntryOrFail(cs1, 0xD9B2, [(byte)0x8B, (byte)0xC3]);
        // 100D:D9B2 mov AX,BX
        AX = BX;
        VerifySpeculativeEntryOrFail(cs1, 0xD9B4, [(byte)0xD1, (byte)0xF8]);
        // 100D:D9B4 sar AX,1
        AX = Alu16.Sar(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xD9B6, [(byte)0xD1, (byte)0xF8]);
        // 100D:D9B6 sar AX,1
        AX = Alu16.Sar(AX, 1);
        VerifySpeculativeEntryOrFail(cs1, 0xD9B8, [(byte)0x2B, (byte)0xD8]);
        // 100D:D9B8 sub BX,AX
        BX = Alu16.Sub(BX, AX);
    label_100D_D9BA_1DA8A_38887:
        CheckExternalEvents(cs1, 0xD9BA);
        // 100D:D9BA mov AX,BX
        AX = BX;
        // 100D:D9BC or AX,DX
        AX = Alu16.Or(AX, DX);
        // 100D:D9BE jne short 0xD9C7
        if (!ZeroFlag)
        {
            goto label_100D_D9C7_1DA97_38905;
        }
    label_100D_D9C0_1DA90_38907:
        CheckExternalEvents(cs1, 0xD9C0);
        // 100D:D9C0 mov byte ptr DS:[0xDC4B],0
        UInt8[DS, (ushort)0xDC4B] = (byte)0x00;
        // 100D:D9C5 jmp short 0xD9CF
        goto label_100D_D9CF_1DA9F_38855;
    label_100D_D9C7_1DA97_38905:
        CheckExternalEvents(cs1, 0xD9C7);
        // 100D:D9C7 call near 0xDAAF
        NearCall(cs1, 0xD9CA, unknown_100D_DAAF_1DB7F);
    label_100D_D9CA_1DA9A_39003:
        CheckExternalEvents(cs1, 0xD9CA);
        // 100D:D9CA mov byte ptr DS:[0xDC34],0
        UInt8[DS, (ushort)0xDC34] = (byte)0x00;
    label_100D_D9CF_1DA9F_38855:
        CheckExternalEvents(cs1, 0xD9CF);
        // 100D:D9CF jmp near 0xDB4C
        return mouse_stuff(0x0000);
    }

    public virtual Action process_frame_tasks(int loadOffset)
    {
    label_100D_D9D2_1DAA2_4769:
        CheckExternalEvents(cs1, 0xD9D2);
        // 100D:D9D2 call near 0xACE6
        NearCall(cs1, 0xD9D5, music_cd_playlist_service);
    label_100D_D9D5_1DAA5_4783:
        CheckExternalEvents(cs1, 0xD9D5);
        // 100D:D9D5 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:D9D8 mov CX,AX
        CX = AX;
        // 100D:D9DA mov BX,AX
        BX = AX;
        // 100D:D9DC mov SI,0xDC68
        SI = (ushort)0xDC68;
        // 100D:D9DF xchg CX,word ptr DS:[SI]
        ushort xchgOffset_100D_D9DF_1DAAF = SI;
        ushort temp_100D_D9DF_1DAAF = CX;
        CX = UInt16[DS, xchgOffset_100D_D9DF_1DAAF];
        UInt16[DS, xchgOffset_100D_D9DF_1DAAF] = unchecked((ushort)temp_100D_D9DF_1DAAF);
        // 100D:D9E1 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:D9E3 mov CX,word ptr DS:[SI+2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:D9E6 jcxz short 0xDA03
        if (CX == (ushort)0x0000)
        {
            goto label_100D_DA03_1DAD3_4792;
        }
    label_100D_D9E8_1DAB8_6195:
        CheckExternalEvents(cs1, 0xD9E8);
        // 100D:D9E8 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
    label_100D_D9EB_1DABB_6197:
        CheckExternalEvents(cs1, 0xD9EB);
        // 100D:D9EB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:D9EC mov BP,AX
        BP = AX;
        // 100D:D9EE mov AX,BX
        AX = BX;
        // 100D:D9F0 add AX,word ptr DS:[SI]
        AX = Alu16.Add(AX, UInt16[DS, SI]);
        // 100D:D9F2 cmp AX,BP
        Alu16.Sub(AX, BP);
        // 100D:D9F4 jae short 0xDA04
        if (!CarryFlag)
        {
            goto label_100D_DA04_1DAD4_6209;
        }
    label_100D_D9F6_1DAC6_6203:
        CheckExternalEvents(cs1, 0xD9F6);
        // 100D:D9F6 mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:D9F8 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:D9FB loop 0xD9EB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D9EB_1DABB_6197;
        }
    label_100D_D9FD_1DACD_6207:
        CheckExternalEvents(cs1, 0xD9FD);
        // 100D:D9FD mov word ptr DS:[0xDC66],0
        UInt16[DS, (ushort)0xDC66] = (ushort)0x0000;
    label_100D_DA03_1DAD3_4792:
        CheckExternalEvents(cs1, 0xDA03);
        // 100D:DA03 ret near
        return NearRet((ushort)0x0000);
    label_100D_DA04_1DAD4_6209:
        CheckExternalEvents(cs1, 0xDA04);
        // 100D:DA04 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:DA06 je short 0xDA0E
        if (ZeroFlag)
        {
            goto label_100D_DA0E_1DADE_6216;
        }
    label_100D_DA08_1DAD8_6212:
        CheckExternalEvents(cs1, 0xDA08);
        // 100D:DA08 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:DA0A div BP
        ushort divisor_100D_DA0A_1DADA = BP;
        uint dividend_100D_DA0A_1DADA = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_DA0A_1DADA = Alu16.Div(unchecked((uint)dividend_100D_DA0A_1DADA), unchecked((ushort)divisor_100D_DA0A_1DADA));
        AX = unchecked((ushort)quotient_100D_DA0A_1DADA);
        DX = unchecked((ushort)(dividend_100D_DA0A_1DADA % unchecked((uint)divisor_100D_DA0A_1DADA)));
        // 100D:DA0C mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
    label_100D_DA0E_1DADE_6216:
        CheckExternalEvents(cs1, 0xDA0E);
        // 100D:DA0E sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:DA11 push BX
        Stack.Push16(BX);
        // 100D:DA12 push CX
        Stack.Push16(CX);
        // 100D:DA13 push SI
        Stack.Push16(SI);
        // 100D:DA14 mov word ptr DS:[0xDC66],SP
        UInt16[DS, (ushort)0xDC66] = SP;
        // 100D:DA18 call near word ptr DS:[SI+4]
        switch ((ushort)(UInt16[DS, (ushort)(SI + (sbyte)4)]))
        {
            case 0x070C:
                NearCall(cs1, 0xDA1B, unknown_100D_070C_107DC);
                break;
            case 0x0826:
                NearCall(cs1, 0xDA1B, add_sky_palette_cycler);
                break;
            case 0x0A16:
                NearCall(cs1, 0xDA1B, credits_scroll_frame_task);
                break;
            case 0x0B45:
                NearCall(cs1, 0xDA1B, tick_intro_night_attack);
                break;
            case 0x176B:
                NearCall(cs1, 0xDA1B, tick_sequence_blink);
                break;
            case 0x2CC7:
                NearCall(cs1, 0xDA1B, tick_vision_shimmer);
                break;
            case 0x3916:
                NearCall(cs1, 0xDA1B, tick_sky_fade);
                break;
            case 0x44AB:
                NearCall(cs1, 0xDA1B, tick_map_player_marker);
                break;
            case 0x46B5:
                NearCall(cs1, 0xDA1B, tick_map_caption);
                break;
            case 0x4BB9:
                NearCall(cs1, 0xDA1B, unknown_100D_4BB9_14C89);
                break;
            case 0x6B34:
                NearCall(cs1, 0xDA1B, tick_troop_icon_anim);
                break;
            case 0x99BE:
                NearCall(cs1, 0xDA1B, tick_talking_head_idle);
                break;
            case 0xA7C2:
                NearCall(cs1, 0xDA1B, tick_talking_head_voc);
                break;
            case 0xAB92:
                NearCall(cs1, 0xDA1B, tick_pcm_voice_music_restore);
                break;
            case 0xB9AE:
                NearCall(cs1, 0xDA1B, tick_globe_rotation);
                break;
            case 0xBE57:
                NearCall(cs1, 0xDA1B, tick_results_gauges);
                break;
            case 0xC0B6:
                NearCall(cs1, 0xDA1B, tick_room);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(SI + (sbyte)4)])):X4} at 100D:DA18");
        }
    label_100D_DA1B_1DAEB_6331:
        CheckExternalEvents(cs1, 0xDA1B);
        // 100D:DA1B pop SI
        SI = Stack.Pop16();
        // 100D:DA1C pop CX
        CX = Stack.Pop16();
        // 100D:DA1D pop BX
        BX = Stack.Pop16();
        // 100D:DA1E add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:DA21 loop 0xD9EB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_D9EB_1DABB_6197;
        }
    label_100D_DA23_1DAF3_6337:
        CheckExternalEvents(cs1, 0xDA23);
        // 100D:DA23 jmp short 0xD9FD
        goto label_100D_D9FD_1DACD_6207;
    }

    public virtual Action add_frame_task(int loadOffset)
    {
    label_100D_DA25_1DAF5_6165:
        CheckExternalEvents(cs1, 0xDA25);
        // 100D:DA25 push DS
        Stack.Push16(DS);
        // 100D:DA26 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:DA27 mov DI,0xDC6A
        DI = (ushort)0xDC6A;
        // 100D:DA2A mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:DA2C inc AX
        AX = Alu16.Inc(AX);
        // 100D:DA2D cmp AX,0x0014
        Alu16.Sub(AX, (ushort)0x0014);
        // 100D:DA30 ja short 0xDA52
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_DA52_1DB22_6190;
        }
    label_100D_DA32_1DB02_6173:
        CheckExternalEvents(cs1, 0xDA32);
        // 100D:DA32 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:DA33 dec AX
        AX = Alu16.Dec(AX);
        // 100D:DA34 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:DA36 mov BX,AX
        BX = AX;
        // 100D:DA38 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:DA3A add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:DA3C add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:DA3E mov AX,BP
        AX = BP;
        // 100D:DA40 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:DA41 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:DA43 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:DA44 mov AX,SI
        AX = SI;
        // 100D:DA46 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:DA47 mov BP,word ptr DS:[0xDC66]
        BP = UInt16[DS, (ushort)0xDC66];
        // 100D:DA4B or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:DA4D je short 0xDA52
        if (ZeroFlag)
        {
            goto label_100D_DA52_1DB22_6190;
        }
    label_100D_DA4F_1DB1F_40281:
        CheckExternalEvents(cs1, 0xDA4F);
        // 100D:DA4F inc word ptr SS:[BP+2]
        UInt16[SS, (ushort)(BP + (sbyte)2)] = Alu16.Inc(UInt16[SS, (ushort)(BP + (sbyte)2)]);
    label_100D_DA52_1DB22_6190:
        CheckExternalEvents(cs1, 0xDA52);
        // 100D:DA52 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DA53_1DB23(int loadOffset)
    {
    label_100D_DA53_1DB23_3135:
        CheckExternalEvents(cs1, 0xDA53);
        // 100D:DA53 mov word ptr DS:[0xDC6A],0
        UInt16[DS, (ushort)0xDC6A] = (ushort)0x0000;
        // 100D:DA59 mov byte ptr DS:[0x46D7],0
        UInt8[DS, (ushort)0x46D7] = (byte)0x00;
        // 100D:DA5E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action remove_frame_task(int loadOffset)
    {
    label_100D_DA5F_1DB2F_1838:
        CheckExternalEvents(cs1, 0xDA5F);
        // 100D:DA5F mov DI,0xDC6A
        DI = (ushort)0xDC6A;
        // 100D:DA62 mov CX,word ptr DS:[DI]
        CX = UInt16[DS, DI];
        // 100D:DA64 jcxz short 0xDA72
        if (CX == (ushort)0x0000)
        {
            goto label_100D_DA72_1DB42_1842;
        }
    label_100D_DA66_1DB36_6343:
        CheckExternalEvents(cs1, 0xDA66);
        // 100D:DA66 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_100D_DA69_1DB39_6345:
        CheckExternalEvents(cs1, 0xDA69);
        // 100D:DA69 cmp word ptr DS:[DI],SI
        Alu16.Sub(UInt16[DS, DI], SI);
        // 100D:DA6B je short 0xDA73
        if (ZeroFlag)
        {
            goto label_100D_DA73_1DB43_6454;
        }
    label_100D_DA6D_1DB3D_6347:
        CheckExternalEvents(cs1, 0xDA6D);
        // 100D:DA6D add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:DA70 loop 0xDA69
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_DA69_1DB39_6345;
        }
    label_100D_DA72_1DB42_1842:
        CheckExternalEvents(cs1, 0xDA72);
        // 100D:DA72 ret near
        return NearRet((ushort)0x0000);
    label_100D_DA73_1DB43_6454:
        CheckExternalEvents(cs1, 0xDA73);
        // 100D:DA73 sub DI,4
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:DA76 dec word ptr DS:[0xDC6A]
        UInt16[DS, (ushort)0xDC6A] = Alu16.Dec(UInt16[DS, (ushort)0xDC6A]);
        // 100D:DA7A mov BP,word ptr DS:[0xDC66]
        BP = UInt16[DS, (ushort)0xDC66];
        // 100D:DA7E or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:DA80 je short 0xDA90
        if (ZeroFlag)
        {
            goto label_100D_DA90_1DB60_6460;
        }
    label_100D_DA82_1DB52_9303:
        CheckExternalEvents(cs1, 0xDA82);
        // 100D:DA82 cmp DI,word ptr SS:[BP]
        Alu16.Sub(DI, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 100D:DA85 ja short 0xDA8D
        if (!CarryFlag && !ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:DA85");
        }
    label_100D_DA87_1DB57_9306:
        CheckExternalEvents(cs1, 0xDA87);
        // 100D:DA87 sub word ptr SS:[BP],6
        UInt16[SS, (ushort)(BP + (sbyte)0)] = Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)0)], unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:DA8B jmp short 0xDA90
    label_100D_DA90_1DB60_6460:
        CheckExternalEvents(cs1, 0xDA90);
        // 100D:DA90 dec CX
        CX = Alu16.Dec(CX);
        // 100D:DA91 je short 0xDA72
        if (ZeroFlag)
        {
            goto label_100D_DA72_1DB42_1842;
        }
    label_100D_DA93_1DB63_10950:
        CheckExternalEvents(cs1, 0xDA93);
        // 100D:DA93 mov AX,CX
        AX = CX;
        // 100D:DA95 add CX,CX
        CX = Alu16.Add(CX, CX);
        // 100D:DA97 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:DA99 mov SI,DI
        SI = DI;
        // 100D:DA9B add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:DA9E push DS
        Stack.Push16(DS);
        // 100D:DA9F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:DAA0 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:DAA2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action clear_mouse_nav_rect(int loadOffset)
    {
    label_100D_DAA3_1DB73_13212:
        CheckExternalEvents(cs1, 0xDAA3);
        // 100D:DAA3 mov word ptr DS:[0xDC58],0
        UInt16[DS, (ushort)0xDC58] = (ushort)0x0000;
        // 100D:DAA9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action set_mouse_nav_rect(int loadOffset)
    {
    label_100D_DAAA_1DB7A_12487:
        CheckExternalEvents(cs1, 0xDAAA);
        // 100D:DAAA mov word ptr DS:[0xDC58],SI
        UInt16[DS, (ushort)0xDC58] = SI;
        // 100D:DAAE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DAAF_1DB7F(int loadOffset)
    {
    label_100D_DAAF_1DB7F_38912:
        CheckExternalEvents(cs1, 0xDAAF);
        // 100D:DAAF mov SI,0xDC3A
        SI = (ushort)0xDC3A;
        // 100D:DAB2 mov AX,word ptr DS:[0xDC36]
        AX = UInt16[DS, (ushort)0xDC36];
        // 100D:DAB5 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:DAB7 cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:DAB9 jge short 0xDABD
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DABD_1DB8D_38923;
        }
    label_100D_DABB_1DB8B_38925:
        CheckExternalEvents(cs1, 0xDABB);
        VerifySpeculativeEntryOrFail(cs1, 0xDABB, [(byte)0x8B, (byte)0x04]);
        // 100D:DABB mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
    label_100D_DABD_1DB8D_38923:
        CheckExternalEvents(cs1, 0xDABD);
        // 100D:DABD add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:DAC0 cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:DAC2 jle short 0xDAC6
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_DAC6_1DB96_38930;
        }
    label_100D_DAC4_1DB94_38932:
        CheckExternalEvents(cs1, 0xDAC4);
        VerifySpeculativeEntryOrFail(cs1, 0xDAC4, [(byte)0x8B, (byte)0x04]);
        // 100D:DAC4 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
    label_100D_DAC6_1DB96_38930:
        CheckExternalEvents(cs1, 0xDAC6);
        // 100D:DAC6 mov word ptr DS:[0xDC36],AX
        UInt16[DS, (ushort)0xDC36] = AX;
        // 100D:DAC9 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:DACC mov AX,word ptr DS:[0xDC38]
        AX = UInt16[DS, (ushort)0xDC38];
        // 100D:DACF add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:DAD1 cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:DAD3 jge short 0xDAD7
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DAD7_1DBA7_38940;
        }
    label_100D_DAD5_1DBA5_38942:
        CheckExternalEvents(cs1, 0xDAD5);
        VerifySpeculativeEntryOrFail(cs1, 0xDAD5, [(byte)0x8B, (byte)0x04]);
        // 100D:DAD5 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
    label_100D_DAD7_1DBA7_38940:
        CheckExternalEvents(cs1, 0xDAD7);
        // 100D:DAD7 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:DADA cmp AX,word ptr DS:[SI]
        Alu16.Sub(AX, UInt16[DS, SI]);
        // 100D:DADC jle short 0xDAE0
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_DAE0_1DBB0_38947;
        }
    label_100D_DADE_1DBAE_38949:
        CheckExternalEvents(cs1, 0xDADE);
        VerifySpeculativeEntryOrFail(cs1, 0xDADE, [(byte)0x8B, (byte)0x04]);
        // 100D:DADE mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
    label_100D_DAE0_1DBB0_38947:
        CheckExternalEvents(cs1, 0xDAE0);
        // 100D:DAE0 mov word ptr DS:[0xDC38],AX
        UInt16[DS, (ushort)0xDC38] = AX;
        return unknown_100D_DAE3_1DBB3(0x0000);
    }

    public virtual Action unknown_100D_DAE3_1DBB3(int loadOffset)
    {
    label_100D_DAE3_1DBB3_1237:
        CheckExternalEvents(cs1, 0xDAE3);
        // 100D:DAE3 test byte ptr DS:[0x2942],0x40
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x40);
        // 100D:DAE8 jne short 0xDB02
        if (!ZeroFlag)
        {
            goto label_100D_DB02_1DBD2_1250;
        }
    label_100D_DAEA_1DBBA_1240:
        CheckExternalEvents(cs1, 0xDAEA);
        // 100D:DAEA mov AX,word ptr DS:[0xDC36]
        AX = UInt16[DS, (ushort)0xDC36];
        // 100D:DAED mov DX,word ptr DS:[0xDC38]
        DX = UInt16[DS, (ushort)0xDC38];
        // 100D:DAF1 mov CX,word ptr DS:[0x2580]
        CX = UInt16[DS, (ushort)0x2580];
        // 100D:DAF5 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:DAF7 mov CL,CH
        CL = CH;
        // 100D:DAF9 shl DX,CL
        DX = Alu16.Shl(DX, unchecked((int)CL));
        // 100D:DAFB mov CX,AX
        CX = AX;
        // 100D:DAFD mov AX,4
        AX = (ushort)0x0004;
        // 100D:DB00 int 0x33
        InterruptCall(cs1, 0xDB02, unchecked((byte)((byte)0x33)));
    label_100D_DB02_1DBD2_1250:
        CheckExternalEvents(cs1, 0xDB02);
        // 100D:DB02 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DB03_1DBD3(int loadOffset)
    {
    label_100D_DB03_1DBD3_1220:
        CheckExternalEvents(cs1, 0xDB03);
        // 100D:DB03 call near 0xDBB2
        NearCall(cs1, 0xDB06, call_restore_cursor);
    label_100D_DB06_1DBD6_1233:
        CheckExternalEvents(cs1, 0xDB06);
        // 100D:DB06 mov word ptr DS:[0xDC36],DX
        UInt16[DS, (ushort)0xDC36] = DX;
        // 100D:DB0A mov word ptr DS:[0xDC38],BX
        UInt16[DS, (ushort)0xDC38] = BX;
        // 100D:DB0E call near 0xDAE3
        NearCall(cs1, 0xDB11, unknown_100D_DAE3_1DBB3);
    label_100D_DB11_1DBE1_1252:
        CheckExternalEvents(cs1, 0xDB11);
        // 100D:DB11 jmp near 0xDBEC
        return draw_mouse(0x0000);
    }

    public virtual Action unknown_100D_DB14_1DBE4(int loadOffset)
    {
    label_100D_DB14_1DBE4_1184:
        CheckExternalEvents(cs1, 0xDB14);
        // 100D:DB14 mov DI,0xDC3A
        DI = (ushort)0xDC3A;
        // 100D:DB17 mov word ptr DS:[DI],CX
        UInt16[DS, DI] = CX;
        // 100D:DB19 mov word ptr DS:[DI+2],DX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = DX;
        // 100D:DB1C mov word ptr DS:[DI+4],AX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = AX;
        // 100D:DB1F mov word ptr DS:[DI+6],BX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = BX;
        // 100D:DB22 test byte ptr DS:[0x2942],0x40
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x40);
        // 100D:DB27 jne short 0xDB43
        if (!ZeroFlag)
        {
            goto label_100D_DB43_1DC13_1214;
        }
    label_100D_DB29_1DBF9_1192:
        CheckExternalEvents(cs1, 0xDB29);
        // 100D:DB29 push AX
        Stack.Push16(AX);
        // 100D:DB2A push BX
        Stack.Push16(BX);
        // 100D:DB2B mov AL,byte ptr DS:[0x2580]
        AL = UInt8[DS, (ushort)0x2580];
        // 100D:DB2E call near 0xDB44
        NearCall(cs1, 0xDB31, unknown_100D_DB44_1DC14);
    label_100D_DB31_1DC01_1203:
        CheckExternalEvents(cs1, 0xDB31);
        // 100D:DB31 mov AX,7
        AX = (ushort)0x0007;
        // 100D:DB34 int 0x33
        InterruptCall(cs1, 0xDB36, unchecked((byte)((byte)0x33)));
    label_100D_DB36_1DC06_1206:
        CheckExternalEvents(cs1, 0xDB36);
        // 100D:DB36 pop DX
        DX = Stack.Pop16();
        // 100D:DB37 pop CX
        CX = Stack.Pop16();
        // 100D:DB38 mov AL,byte ptr DS:[0x2581]
        AL = UInt8[DS, (ushort)0x2581];
        // 100D:DB3B call near 0xDB44
        NearCall(cs1, 0xDB3E, unknown_100D_DB44_1DC14);
    label_100D_DB3E_1DC0E_1211:
        CheckExternalEvents(cs1, 0xDB3E);
        // 100D:DB3E mov AX,8
        AX = (ushort)0x0008;
        // 100D:DB41 int 0x33
        InterruptCall(cs1, 0xDB43, unchecked((byte)((byte)0x33)));
    label_100D_DB43_1DC13_1214:
        CheckExternalEvents(cs1, 0xDB43);
        // 100D:DB43 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_DB44_1DC14(int loadOffset)
    {
    label_100D_DB44_1DC14_1197:
        CheckExternalEvents(cs1, 0xDB44);
        // 100D:DB44 xchg CX,AX
        ushort temp_100D_DB44_1DC14 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_DB44_1DC14);
        // 100D:DB45 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:DB47 shl DX,CL
        DX = Alu16.Shl(DX, unchecked((int)CL));
        // 100D:DB49 mov CX,AX
        CX = AX;
        // 100D:DB4B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action mouse_stuff(int loadOffset)
    {
    label_100D_DB4C_1DC1C_14766:
        CheckExternalEvents(cs1, 0xDB4C);
        // 100D:DB4C mov AX,word ptr DS:[0xDC34]
        AX = UInt16[DS, (ushort)0xDC34];
        // 100D:DB4F and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:DB51 mov byte ptr DS:[0xDC35],AL
        UInt8[DS, (ushort)0xDC35] = AL;
        // 100D:DB54 xor AH,AL
        AH = Alu8.Xor(AH, AL);
        // 100D:DB56 add AH,AH
        AH = Alu8.Add(AH, AH);
        // 100D:DB58 add AH,AH
        AH = Alu8.Add(AH, AH);
        // 100D:DB5A or AL,AH
        AL = Alu8.Or(AL, AH);
        // 100D:DB5C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:DB5E mov DX,word ptr DS:[0xDC36]
        DX = UInt16[DS, (ushort)0xDC36];
        // 100D:DB62 mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:DB66 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_mouse_cursor_if_needed(int loadOffset)
    {
    entrydispatcher:
    label_100D_DB67_1DC37_9045:
        CheckExternalEvents(cs1, 0xDB67);
        // 100D:DB67 cmp byte ptr DS:[0xDC47],0
        Alu8.Sub(UInt8[DS, (ushort)0xDC47], (byte)0x00);
        // 100D:DB6C jns short 0xDBAB
        if (!SignFlag)
        {
            return unknown_100D_DBAB_1DC7B(0x0000);
        }
    label_100D_DB6E_1DC3E_25230:
        CheckExternalEvents(cs1, 0xDB6E);
        // 100D:DB6E inc byte ptr DS:[0xDC47]
        UInt8[DS, (ushort)0xDC47] = Alu8.Inc(UInt8[DS, (ushort)0xDC47]);
        // 100D:DB72 jmp short 0xDBEC
        if (JumpDispatcher.Jump(draw_mouse, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action restore_mouse_if_rect_intersects(int loadOffset)
    {
    label_100D_DB74_1DC44_9021:
        CheckExternalEvents(cs1, 0xDB74);
        // 100D:DB74 cmp byte ptr DS:[0xDC46],0
        Alu8.Sub(UInt8[DS, (ushort)0xDC46], (byte)0x00);
        // 100D:DB79 js short 0xDBAB
        if (SignFlag)
        {
            return unknown_100D_DBAB_1DC7B(0x0000);
        }
    label_100D_DB7B_1DC4B_16066:
        CheckExternalEvents(cs1, 0xDB7B);
        // 100D:DB7B push BX
        Stack.Push16(BX);
        // 100D:DB7C push DX
        Stack.Push16(DX);
        // 100D:DB7D mov BX,word ptr DS:[0x2582]
        BX = UInt16[DS, (ushort)0x2582];
        // 100D:DB81 mov DX,word ptr DS:[0xDC42]
        DX = UInt16[DS, (ushort)0xDC42];
        // 100D:DB85 sub DX,word ptr DS:[BX]
        DX = Alu16.Sub(DX, UInt16[DS, BX]);
        // 100D:DB87 mov BX,word ptr DS:[BX+2]
        BX = UInt16[DS, (ushort)(BX + (sbyte)2)];
        // 100D:DB8A neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:DB8C add BX,word ptr DS:[0xDC44]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0xDC44]);
        // 100D:DB90 cmp DX,word ptr DS:[SI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:DB93 jge short 0xDBA9
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DBA9_1DC79_16077;
        }
    label_100D_DB95_1DC65_18825:
        CheckExternalEvents(cs1, 0xDB95);
        // 100D:DB95 cmp BX,word ptr DS:[SI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:DB98 jge short 0xDBA9
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DBA9_1DC79_16077;
        }
    label_100D_DB9A_1DC6A_22371:
        CheckExternalEvents(cs1, 0xDB9A);
        // 100D:DB9A add DX,0x0010
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:DB9D cmp DX,word ptr DS:[SI]
        Alu16.Sub(DX, UInt16[DS, SI]);
        // 100D:DB9F jle short 0xDBA9
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_DBA9_1DC79_16077;
        }
    label_100D_DBA1_1DC71_25222:
        CheckExternalEvents(cs1, 0xDBA1);
        // 100D:DBA1 add BX,0x0010
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:DBA4 cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:DBA7 jg short 0xDBAC
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_DBAC_1DC7C_25226;
        }
    label_100D_DBA9_1DC79_16077:
        CheckExternalEvents(cs1, 0xDBA9);
        // 100D:DBA9 pop DX
        DX = Stack.Pop16();
        // 100D:DBAA pop BX
        BX = Stack.Pop16();
        return unknown_100D_DBAB_1DC7B(0x0000);
    label_100D_DBAC_1DC7C_25226:
        CheckExternalEvents(cs1, 0xDBAC);
        // 100D:DBAC pop DX
        DX = Stack.Pop16();
        // 100D:DBAD pop BX
        BX = Stack.Pop16();
        // 100D:DBAE dec byte ptr DS:[0xDC47]
        UInt8[DS, (ushort)0xDC47] = Alu8.Dec(UInt8[DS, (ushort)0xDC47]);
        return call_restore_cursor(0x0000);
    }

    public virtual Action call_restore_cursor(int loadOffset)
    {
    label_100D_DBB2_1DC82_1222:
        CheckExternalEvents(cs1, 0xDBB2);
        // 100D:DBB2 push AX
        Stack.Push16(AX);
        // 100D:DBB3 mov AL,byte ptr DS:[0xDC46]
        AL = UInt8[DS, (ushort)0xDC46];
        // 100D:DBB6 dec byte ptr DS:[0xDC46]
        UInt8[DS, (ushort)0xDC46] = Alu8.Dec(UInt8[DS, (ushort)0xDC46]);
        // 100D:DBBA js short 0xDBC0
        if (!(SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:DBBA");
        }
    label_100D_DBC0_1DC90_1227:
        CheckExternalEvents(cs1, 0xDBC0);
        // 100D:DBC0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:DBC2 js short 0xDBC8
        if (SignFlag)
        {
            goto label_100D_DBC8_1DC98_1230;
        }
    label_100D_DBC4_1DC94_14975:
        CheckExternalEvents(cs1, 0xDBC4);
        // 100D:DBC4 call far dword ptr DS:[0x38C5]
        ushort targetSegment_14975 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38C5 + (ushort)0x0002)]));
        ushort targetOffset_14975 = unchecked((ushort)(UInt16[DS, (ushort)0x38C5]));
        if (targetSegment_14975 == cs2 && targetOffset_14975 == 0x010C)
        {
            FarCall(cs1, 0xDBC8, cs2, unknown_3358_010C_3368C);
            goto label_100D_DBC8_1DC98_1230;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_14975:X4}:{targetOffset_14975:X4} at 100D:DBC4");
    label_100D_DBC8_1DC98_1230:
        CheckExternalEvents(cs1, 0xDBC8);
        // 100D:DBC8 pop AX
        AX = Stack.Pop16();
        // 100D:DBC9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_mouse(int loadOffset)
    {
    entrydispatcher:
    label_100D_DBEC_1DCBC_1254:
        CheckExternalEvents(cs1, 0xDBEC);
        // 100D:DBEC inc byte ptr DS:[0xDC46]
        UInt8[DS, (ushort)0xDC46] = Alu8.Inc(UInt8[DS, (ushort)0xDC46]);
        // 100D:DBF0 js short 0xDC1A
        if (SignFlag)
        {
            goto label_100D_DC1A_1DCEA_1257;
        }
    label_100D_DBF2_1DCC2_15260:
        CheckExternalEvents(cs1, 0xDBF2);
        // 100D:DBF2 jne short 0xDC1B
        if (!ZeroFlag)
        {
            goto label_100D_DC1B_1DCEB_22350;
        }
    label_100D_DBF4_1DCC4_15262:
        CheckExternalEvents(cs1, 0xDBF4);
        // 100D:DBF4 push AX
        Stack.Push16(AX);
        // 100D:DBF5 push BX
        Stack.Push16(BX);
        // 100D:DBF6 push CX
        Stack.Push16(CX);
        // 100D:DBF7 push DX
        Stack.Push16(DX);
        // 100D:DBF8 push SI
        Stack.Push16(SI);
        // 100D:DBF9 push DI
        Stack.Push16(DI);
        // 100D:DBFA push BP
        Stack.Push16(BP);
        // 100D:DBFB mov DX,word ptr DS:[0xDC36]
        DX = UInt16[DS, (ushort)0xDC36];
        // 100D:DBFF mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:DC03 mov word ptr DS:[0xDC42],DX
        UInt16[DS, (ushort)0xDC42] = DX;
        // 100D:DC07 mov word ptr DS:[0xDC44],BX
        UInt16[DS, (ushort)0xDC44] = BX;
        // 100D:DC0B mov SI,word ptr DS:[0x2582]
        SI = UInt16[DS, (ushort)0x2582];
        // 100D:DC0F call far dword ptr DS:[0x38C1]
        ushort targetSegment_15275 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38C1 + (ushort)0x0002)]));
        ushort targetOffset_15275 = unchecked((ushort)(UInt16[DS, (ushort)0x38C1]));
        if (targetSegment_15275 == cs2 && targetOffset_15275 == 0x0109)
        {
            FarCall(cs1, 0xDC13, cs2, unknown_3358_0109_33689);
            goto label_100D_DC13_1DCE3_15276;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_15275:X4}:{targetOffset_15275:X4} at 100D:DC0F");
    label_100D_DC13_1DCE3_15276:
        CheckExternalEvents(cs1, 0xDC13);
        // 100D:DC13 pop BP
        BP = Stack.Pop16();
        // 100D:DC14 pop DI
        DI = Stack.Pop16();
        // 100D:DC15 pop SI
        SI = Stack.Pop16();
        // 100D:DC16 pop DX
        DX = Stack.Pop16();
        // 100D:DC17 pop CX
        CX = Stack.Pop16();
        // 100D:DC18 pop BX
        BX = Stack.Pop16();
        // 100D:DC19 pop AX
        AX = Stack.Pop16();
    label_100D_DC1A_1DCEA_1257:
        CheckExternalEvents(cs1, 0xDC1A);
        // 100D:DC1A ret near
        return NearRet((ushort)0x0000);
    label_100D_DC1B_1DCEB_22350:
        CheckExternalEvents(cs1, 0xDC1B);
        // 100D:DC1B dec byte ptr DS:[0xDC46]
        UInt8[DS, (ushort)0xDC46] = Alu8.Dec(UInt8[DS, (ushort)0xDC46]);
        // 100D:DC1F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action redraw_mouse(int loadOffset)
    {
    label_100D_DC20_1DCF0_14780:
        CheckExternalEvents(cs1, 0xDC20);
        // 100D:DC20 push AX
        Stack.Push16(AX);
        // 100D:DC21 push BX
        Stack.Push16(BX);
        // 100D:DC22 push CX
        Stack.Push16(CX);
        // 100D:DC23 push DX
        Stack.Push16(DX);
        // 100D:DC24 push SI
        Stack.Push16(SI);
        // 100D:DC25 push DI
        Stack.Push16(DI);
        // 100D:DC26 push BP
        Stack.Push16(BP);
        // 100D:DC27 mov DX,word ptr DS:[0xDC36]
        DX = UInt16[DS, (ushort)0xDC36];
        // 100D:DC2B mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:DC2F call near 0xDC6A
        NearCall(cs1, 0xDC32, get_mouse_cursor_image);
    label_100D_DC32_1DD02_14805:
        CheckExternalEvents(cs1, 0xDC32);
        // 100D:DC32 mov SI,BP
        SI = BP;
        // 100D:DC34 xchg BP,word ptr DS:[0x2582]
        ushort xchgOffset_100D_DC34_1DD04 = (ushort)0x2582;
        ushort temp_100D_DC34_1DD04 = BP;
        BP = UInt16[DS, xchgOffset_100D_DC34_1DD04];
        UInt16[DS, xchgOffset_100D_DC34_1DD04] = unchecked((ushort)temp_100D_DC34_1DD04);
        // 100D:DC38 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:DC3A xchg AL,byte ptr DS:[0xDC46]
        ushort xchgOffset_100D_DC3A_1DD0A = (ushort)0xDC46;
        byte temp_100D_DC3A_1DD0A = AL;
        AL = UInt8[DS, xchgOffset_100D_DC3A_1DD0A];
        UInt8[DS, xchgOffset_100D_DC3A_1DD0A] = unchecked((byte)temp_100D_DC3A_1DD0A);
        // 100D:DC3E or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:DC40 js short 0xDC56
        if (SignFlag)
        {
            goto label_100D_DC56_1DD26_14812;
        }
    label_100D_DC42_1DD12_15202:
        CheckExternalEvents(cs1, 0xDC42);
        // 100D:DC42 cmp DX,word ptr DS:[0xDC42]
        Alu16.Sub(DX, UInt16[DS, (ushort)0xDC42]);
        // 100D:DC46 jne short 0xDC52
        if (!ZeroFlag)
        {
            goto label_100D_DC52_1DD22_15211;
        }
    label_100D_DC48_1DD18_15205:
        CheckExternalEvents(cs1, 0xDC48);
        // 100D:DC48 cmp BX,word ptr DS:[0xDC44]
        Alu16.Sub(BX, UInt16[DS, (ushort)0xDC44]);
        // 100D:DC4C jne short 0xDC52
        if (!ZeroFlag)
        {
            goto label_100D_DC52_1DD22_15211;
        }
    label_100D_DC4E_1DD1E_15208:
        CheckExternalEvents(cs1, 0xDC4E);
        // 100D:DC4E cmp SI,BP
        Alu16.Sub(SI, BP);
        // 100D:DC50 je short 0xDC62
        if (ZeroFlag)
        {
            goto label_100D_DC62_1DD32_14890;
        }
    label_100D_DC52_1DD22_15211:
        CheckExternalEvents(cs1, 0xDC52);
        // 100D:DC52 call far dword ptr DS:[0x38C5]
        ushort targetSegment_15211 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38C5 + (ushort)0x0002)]));
        ushort targetOffset_15211 = unchecked((ushort)(UInt16[DS, (ushort)0x38C5]));
        if (targetSegment_15211 == cs2 && targetOffset_15211 == 0x010C)
        {
            FarCall(cs1, 0xDC56, cs2, unknown_3358_010C_3368C);
            goto label_100D_DC56_1DD26_14812;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_15211:X4}:{targetOffset_15211:X4} at 100D:DC52");
    label_100D_DC56_1DD26_14812:
        CheckExternalEvents(cs1, 0xDC56);
        // 100D:DC56 mov word ptr DS:[0xDC42],DX
        UInt16[DS, (ushort)0xDC42] = DX;
        // 100D:DC5A mov word ptr DS:[0xDC44],BX
        UInt16[DS, (ushort)0xDC44] = BX;
        // 100D:DC5E call far dword ptr DS:[0x38C1]
        ushort targetSegment_14815 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38C1 + (ushort)0x0002)]));
        ushort targetOffset_14815 = unchecked((ushort)(UInt16[DS, (ushort)0x38C1]));
        if (targetSegment_14815 == cs2 && targetOffset_14815 == 0x0109)
        {
            FarCall(cs1, 0xDC62, cs2, unknown_3358_0109_33689);
            goto label_100D_DC62_1DD32_14890;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_14815:X4}:{targetOffset_14815:X4} at 100D:DC5E");
    label_100D_DC62_1DD32_14890:
        CheckExternalEvents(cs1, 0xDC62);
        // 100D:DC62 pop BP
        BP = Stack.Pop16();
        // 100D:DC63 pop DI
        DI = Stack.Pop16();
        // 100D:DC64 pop SI
        SI = Stack.Pop16();
        // 100D:DC65 pop DX
        DX = Stack.Pop16();
        // 100D:DC66 pop CX
        CX = Stack.Pop16();
        // 100D:DC67 pop BX
        BX = Stack.Pop16();
        // 100D:DC68 pop AX
        AX = Stack.Pop16();
        // 100D:DC69 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_mouse_cursor_image(int loadOffset)
    {
    label_100D_DC6A_1DD3A_14791:
        CheckExternalEvents(cs1, 0xDC6A);
        // 100D:DC6A cmp byte ptr DS:[0x28BE],0
        Alu8.Sub(UInt8[DS, (ushort)0x28BE], (byte)0x00);
        // 100D:DC6F mov BP,0x25C8
        BP = (ushort)0x25C8;
        // 100D:DC72 jne short 0xDCDF
        if (!ZeroFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DC74_1DD44_14795:
        CheckExternalEvents(cs1, 0xDC74);
        // 100D:DC74 mov BP,0x2584
        BP = (ushort)0x2584;
        // 100D:DC77 cmp byte ptr DS:[0x4723],0
        Alu8.Sub(UInt8[DS, (ushort)0x4723], (byte)0x00);
        // 100D:DC7C jne short 0xDCDF
        if (!ZeroFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DC7E_1DD4E_14799:
        CheckExternalEvents(cs1, 0xDC7E);
        // 100D:DC7E mov DI,word ptr DS:[0xDC58]
        DI = UInt16[DS, (ushort)0xDC58];
        // 100D:DC82 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:DC84 je short 0xDCDF
        if (ZeroFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DC86_1DD56_18502:
        CheckExternalEvents(cs1, 0xDC86);
        // 100D:DC86 cmp BX,0x009B
        Alu16.Sub(BX, (ushort)0x009B);
        // 100D:DC8A jge short 0xDCDF
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DC8C_1DD5C_21130:
        CheckExternalEvents(cs1, 0xDC8C);
        // 100D:DC8C call near 0xD6FE
        NearCall(cs1, 0xDC8F, contains_interior);
    label_100D_DC8F_1DD5F_21132:
        CheckExternalEvents(cs1, 0xDC8F);
        // 100D:DC8F mov BP,0x25C8
        BP = (ushort)0x25C8;
        // 100D:DC92 jb short 0xDCDF
        if (CarryFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DC94_1DD64_21135:
        CheckExternalEvents(cs1, 0xDC94);
        // 100D:DC94 cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:DC97 jl short 0xDCB9
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_DCB9_1DD89_21141;
        }
    label_100D_DC99_1DD69_21138:
        CheckExternalEvents(cs1, 0xDC99);
        // 100D:DC99 cmp BX,word ptr DS:[DI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:DC9C jge short 0xDCB9
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DCB9_1DD89_21141;
        }
    label_100D_DC9E_1DD6E_28142:
        CheckExternalEvents(cs1, 0xDC9E);
        // 100D:DC9E mov BP,0x26D8
        BP = (ushort)0x26D8;
        // 100D:DCA1 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:DCA3 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:DCA5 cmp AX,0x0032
        Alu16.Sub(AX, (ushort)0x0032);
        // 100D:DCA8 jb short 0xDCDF
        if (CarryFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DCAA_1DD7A_28148:
        CheckExternalEvents(cs1, 0xDCAA);
        // 100D:DCAA mov BP,0x2650
        BP = (ushort)0x2650;
        // 100D:DCAD mov AX,DX
        AX = DX;
        // 100D:DCAF sub AX,word ptr DS:[DI+4]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:DCB2 cmp AX,0x0032
        Alu16.Sub(AX, (ushort)0x0032);
        // 100D:DCB5 jb short 0xDCDF
        if (CarryFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DCB7_1DD87_29690:
        CheckExternalEvents(cs1, 0xDCB7);
        // 100D:DCB7 jmp short 0xDCDC
        goto label_100D_DCDC_1DDAC_29692;
    label_100D_DCB9_1DD89_21141:
        CheckExternalEvents(cs1, 0xDCB9);
        // 100D:DCB9 cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:DCBB jl short 0xDCDC
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_DCDC_1DDAC_29692;
        }
    label_100D_DCBD_1DD8D_21144:
        CheckExternalEvents(cs1, 0xDCBD);
        // 100D:DCBD cmp DX,word ptr DS:[DI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:DCC0 jge short 0xDCDC
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_DCDC_1DDAC_29692;
        }
    label_100D_DCC2_1DD92_21147:
        CheckExternalEvents(cs1, 0xDCC2);
        // 100D:DCC2 mov BP,0x260C
        BP = (ushort)0x260C;
        // 100D:DCC5 mov AX,word ptr DS:[DI+2]
        AX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:DCC8 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:DCCA cmp AX,0x0019
        Alu16.Sub(AX, (ushort)0x0019);
        // 100D:DCCD jb short 0xDCDF
        if (CarryFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DCCF_1DD9F_21153:
        CheckExternalEvents(cs1, 0xDCCF);
        // 100D:DCCF mov BP,0x2694
        BP = (ushort)0x2694;
        // 100D:DCD2 mov AX,BX
        AX = BX;
        // 100D:DCD4 sub AX,word ptr DS:[DI+6]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:DCD7 cmp AX,0x0019
        Alu16.Sub(AX, (ushort)0x0019);
        // 100D:DCDA jb short 0xDCDF
        if (CarryFlag)
        {
            goto label_100D_DCDF_1DDAF_14803;
        }
    label_100D_DCDC_1DDAC_29692:
        CheckExternalEvents(cs1, 0xDCDC);
        // 100D:DCDC mov BP,0x2584
        BP = (ushort)0x2584;
    label_100D_DCDF_1DDAF_14803:
        CheckExternalEvents(cs1, 0xDCDF);
        // 100D:DCDF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action get_and_reset_key_scancode(int loadOffset)
    {
    label_100D_DD5A_1DE2A_40412:
        CheckExternalEvents(cs1, 0xDD5A);
        // 100D:DD5A xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:DD5C xchg AL,byte ptr DS:[0xCEE8]
        ushort xchgOffset_100D_DD5C_1DE2C = (ushort)0xCEE8;
        byte temp_100D_DD5C_1DE2C = AL;
        AL = UInt8[DS, xchgOffset_100D_DD5C_1DE2C];
        UInt8[DS, xchgOffset_100D_DD5C_1DE2C] = unchecked((byte)temp_100D_DD5C_1DE2C);
        // 100D:DD60 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:DD62 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action any_key_pressed(int loadOffset)
    {
    label_100D_DD63_1DE33_4722:
        CheckExternalEvents(cs1, 0xDD63);
        // 100D:DD63 call near 0xDE7B
        NearCall(cs1, 0xDD66, pause_if_p_key_pressed);
    label_100D_DD66_1DE36_4729:
        CheckExternalEvents(cs1, 0xDD66);
        // 100D:DD66 call near 0xDE54
        NearCall(cs1, 0xDD69, kb_check_for_esc_key_hit);
    label_100D_DD69_1DE39_4731:
        CheckExternalEvents(cs1, 0xDD69);
        // 100D:DD69 je short 0xDDAE
        if (ZeroFlag)
        {
            goto label_100D_DDAE_1DE7E_11491;
        }
    label_100D_DD6B_1DE3B_4733:
        CheckExternalEvents(cs1, 0xDD6B);
        // 100D:DD6B cmp byte ptr DS:[0xCEE8],0
        Alu8.Sub(UInt8[DS, (ushort)0xCEE8], (byte)0x00);
        // 100D:DD70 jne short 0xDDAE
        if (!ZeroFlag)
        {
            goto label_100D_DDAE_1DE7E_11491;
        }
    label_100D_DD72_1DE42_4736:
        CheckExternalEvents(cs1, 0xDD72);
        // 100D:DD72 test byte ptr DS:[0x2942],0x40
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x40);
        // 100D:DD77 jne short 0xDD89
        if (!ZeroFlag)
        {
            goto label_100D_DD89_1DE59_4748;
        }
    label_100D_DD79_1DE49_4739:
        CheckExternalEvents(cs1, 0xDD79);
        // 100D:DD79 mov AX,3
        AX = (ushort)0x0003;
        // 100D:DD7C int 0x33
        InterruptCall(cs1, 0xDD7E, unchecked((byte)((byte)0x33)));
    label_100D_DD7E_1DE4E_4742:
        CheckExternalEvents(cs1, 0xDD7E);
        // 100D:DD7E xchg BX,SI
        ushort temp_100D_DD7E_1DE4E = BX;
        BX = SI;
        SI = unchecked((ushort)temp_100D_DD7E_1DE4E);
        // 100D:DD80 xor BX,SI
        BX = Alu16.Xor(BX, SI);
        // 100D:DD82 and BX,SI
        BX = Alu16.And(BX, SI);
        // 100D:DD84 and BL,7
        BL = Alu8.And(BL, (byte)0x07);
        // 100D:DD87 jne short 0xDDAE
        if (!ZeroFlag)
        {
            goto label_100D_DDAE_1DE7E_11491;
        }
    label_100D_DD89_1DE59_4748:
        CheckExternalEvents(cs1, 0xDD89);
        // 100D:DD89 test byte ptr DS:[0x2942],0x80
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x80);
        // 100D:DD8E je short 0xDD9E
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:DD8E");
        }
    label_100D_DD9E_1DE6E_4751:
        CheckExternalEvents(cs1, 0xDD9E);
        // 100D:DD9E push SI
        Stack.Push16(SI);
        // 100D:DD9F push DI
        Stack.Push16(DI);
        // 100D:DDA0 call near 0xE3CC
        NearCall(cs1, 0xDDA3, rand);
    label_100D_DDA3_1DE73_4766:
        CheckExternalEvents(cs1, 0xDDA3);
        // 100D:DDA3 mov word ptr DS:[0],AX
        UInt16[DS, (ushort)0x0000] = AX;
        // 100D:DDA6 call near 0xD9D2
        NearCall(cs1, 0xDDA9, process_frame_tasks);
    label_100D_DDA9_1DE79_4794:
        CheckExternalEvents(cs1, 0xDDA9);
        // 100D:DDA9 pop DI
        DI = Stack.Pop16();
        // 100D:DDAA pop SI
        SI = Stack.Pop16();
        // 100D:DDAB or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
        // 100D:DDAD ret near
        return NearRet((ushort)0x0000);
    label_100D_DDAE_1DE7E_11491:
        CheckExternalEvents(cs1, 0xDDAE);
        // 100D:DDAE stc
        CarryFlag = true;
        // 100D:DDAF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action wait_interruptable(int loadOffset)
    {
    label_100D_DDB0_1DE80_5137:
        CheckExternalEvents(cs1, 0xDDB0);
        // 100D:DDB0 call near 0xE270
        NearCall(cs1, 0xDDB3, unknown_100D_E270_1E340);
    label_100D_DDB3_1DE83_5139:
        CheckExternalEvents(cs1, 0xDDB3);
        // 100D:DDB3 push AX
        Stack.Push16(AX);
        // 100D:DDB4 mov byte ptr DS:[0xCEE8],0
        UInt8[DS, (ushort)0xCEE8] = (byte)0x00;
        // 100D:DDB9 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:DDBE jne short 0xDDC3
        if (!ZeroFlag)
        {
            goto label_100D_DDC3_1DE93_5144;
        }
    label_100D_DDC0_1DE90_19475:
        CheckExternalEvents(cs1, 0xDDC0);
        // 100D:DDC0 call near 0xD64E
        NearCall(cs1, 0xDDC3, unknown_100D_D64E_1D71E);
    label_100D_DDC3_1DE93_5144:
        CheckExternalEvents(cs1, 0xDDC3);
        // 100D:DDC3 mov SI,0xFFFF
        SI = (ushort)0xFFFF;
        // 100D:DDC6 mov DI,SI
        DI = SI;
        // 100D:DDC8 pop CX
        CX = Stack.Pop16();
        // 100D:DDC9 sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_DDCA_1DE9A_5149:
        CheckExternalEvents(cs1, 0xDDCA);
        // 100D:DDCA push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
        // 100D:DDCE push CX
        Stack.Push16(CX);
        // 100D:DDCF call near 0xDD63
        NearCall(cs1, 0xDDD2, any_key_pressed);
    label_100D_DDD2_1DEA2_5153:
        CheckExternalEvents(cs1, 0xDDD2);
        // 100D:DDD2 pop CX
        CX = Stack.Pop16();
        // 100D:DDD3 pop AX
        AX = Stack.Pop16();
        // 100D:DDD4 jb short 0xDDE7
        if (CarryFlag)
        {
            return unknown_100D_DDE7_1DEB7(0x0000);
        }
    label_100D_DDD6_1DEA6_5157:
        CheckExternalEvents(cs1, 0xDDD6);
        // 100D:DDD6 mov BX,AX
        BX = AX;
    label_100D_DDD8_1DEA8_5159:
        CheckExternalEvents(cs1, 0xDDD8);
        // 100D:DDD8 mov AX,BX
        AX = BX;
        // 100D:DDDA sub AX,word ptr SS:[0xCE7A]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)0xCE7A]);
        // 100D:DDDF je short 0xDDD8
        if (ZeroFlag)
        {
            goto label_100D_DDD8_1DEA8_5159;
        }
    label_100D_DDE1_1DEB1_5163:
        CheckExternalEvents(cs1, 0xDDE1);
        // 100D:DDE1 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 100D:DDE3 jb short 0xDDCA
        if (CarryFlag)
        {
            goto label_100D_DDCA_1DE9A_5149;
        }
    label_100D_DDE5_1DEB5_5166:
        CheckExternalEvents(cs1, 0xDDE5);
        // 100D:DDE5 or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
        return unknown_100D_DDE7_1DEB7(0x0000);
    }

    public virtual Action wait_for_pcm_voice_interruptable(int loadOffset)
    {
    label_100D_DDF0_1DEC0_5127:
        CheckExternalEvents(cs1, 0xDDF0);
        // 100D:DDF0 cmp byte ptr DS:[0xDBCD],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCD], (byte)0x00);
        // 100D:DDF5 js short 0xDE07
        if (SignFlag)
        {
            return unknown_100D_DE07_1DED7(0x0000);
        }
    label_100D_DDF7_1DEC7_5130:
        CheckExternalEvents(cs1, 0xDDF7);
        // 100D:DDF7 call near 0xABA3
        NearCall(cs1, 0xDDFA, unknown_100D_ABA3_1AC73);
    label_100D_DDFA_1DECA_5135:
        CheckExternalEvents(cs1, 0xDDFA);
        // 100D:DDFA je short 0xDDB0
        if (ZeroFlag)
        {
            return wait_interruptable(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:DDFA");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action midi_wait_until(int loadOffset)
    {
    label_100D_DE0C_1DEDC_3425:
        CheckExternalEvents(cs1, 0xDE0C);
        // 100D:DE0C cmp byte ptr DS:[0xDBCD],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBCD], (byte)0x00);
        // 100D:DE11 jns short 0xDE07
        if (!SignFlag)
        {
            return unknown_100D_DE07_1DED7(0x0000);
        }
    label_100D_DE13_1DEE3_4438:
        CheckExternalEvents(cs1, 0xDE13);
        // 100D:DE13 call near 0xE270
        NearCall(cs1, 0xDE16, unknown_100D_E270_1E340);
    label_100D_DE16_1DEE6_4440:
        CheckExternalEvents(cs1, 0xDE16);
        // 100D:DE16 mov byte ptr DS:[0xCEE8],0
        UInt8[DS, (ushort)0xCEE8] = (byte)0x00;
        // 100D:DE1B mov SI,0xFFFF
        SI = (ushort)0xFFFF;
        // 100D:DE1E mov DI,SI
        DI = SI;
    label_100D_DE20_1DEF0_4444:
        CheckExternalEvents(cs1, 0xDE20);
        // 100D:DE20 mov AX,0x0060
        AX = (ushort)0x0060;
        // 100D:DE23 sub AX,word ptr DS:[0xDBD0]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDBD0]);
        // 100D:DE27 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:DE29 mov DL,6
        DL = (byte)0x06;
        // 100D:DE2B div DL
        byte divisor_100D_DE2B_1DEFB = DL;
        ushort dividend_100D_DE2B_1DEFB = AX;
        byte quotient_100D_DE2B_1DEFB = Alu8.Div(unchecked((ushort)dividend_100D_DE2B_1DEFB), unchecked((byte)divisor_100D_DE2B_1DEFB));
        AL = unchecked((byte)quotient_100D_DE2B_1DEFB);
        AH = unchecked((byte)(dividend_100D_DE2B_1DEFB % unchecked((ushort)divisor_100D_DE2B_1DEFB)));
        // 100D:DE2D and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:DE2F mov DX,word ptr DS:[0xDBCE]
        DX = UInt16[DS, (ushort)0xDBCE];
        // 100D:DE33 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:DE35 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:DE37 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:DE39 shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 100D:DE3B or DL,AL
        DL = Alu8.Or(DL, AL);
        // 100D:DE3D cmp BX,DX
        Alu16.Sub(BX, DX);
        // 100D:DE3F jbe short 0xDE4A
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_DE4A_1DF1A_4458;
        }
    label_100D_DE41_1DF11_5251:
        CheckExternalEvents(cs1, 0xDE41);
        // 100D:DE41 push BX
        Stack.Push16(BX);
        // 100D:DE42 call near 0xDD63
        NearCall(cs1, 0xDE45, any_key_pressed);
    label_100D_DE45_1DF15_5254:
        CheckExternalEvents(cs1, 0xDE45);
        // 100D:DE45 pop BX
        BX = Stack.Pop16();
        // 100D:DE46 jb short 0xDDE7
        if (CarryFlag)
        {
            return unknown_100D_DDE7_1DEB7(0x0000);
        }
    label_100D_DE48_1DF18_5257:
        CheckExternalEvents(cs1, 0xDE48);
        // 100D:DE48 jmp short 0xDE20
        goto label_100D_DE20_1DEF0_4444;
    label_100D_DE4A_1DF1A_4458:
        CheckExternalEvents(cs1, 0xDE4A);
        // 100D:DE4A or AL,1
        AL = Alu8.Or(AL, (byte)0x01);
        // 100D:DE4C jmp short 0xDDE7
        return unknown_100D_DDE7_1DEB7(0x0000);
    }

    public virtual Action kb_clear_scancode(int loadOffset)
    {
    label_100D_DE4E_1DF1E_4464:
        CheckExternalEvents(cs1, 0xDE4E);
        // 100D:DE4E mov byte ptr DS:[0xCEE8],0
        UInt8[DS, (ushort)0xCEE8] = (byte)0x00;
        // 100D:DE53 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action kb_check_for_esc_key_hit(int loadOffset)
    {
    label_100D_DE54_1DF24_3350:
        CheckExternalEvents(cs1, 0xDE54);
        // 100D:DE54 mov byte ptr DS:[0xCEE9],0
        UInt8[DS, (ushort)0xCEE9] = (byte)0x00;
        // 100D:DE59 cmp byte ptr DS:[0xCEE8],1
        Alu8.Sub(UInt8[DS, (ushort)0xCEE8], (byte)0x01);
        // 100D:DE5E jne short 0xDE67
        if (!ZeroFlag)
        {
            goto label_100D_DE67_1DF37_3354;
        }
    label_100D_DE60_1DF30_20162:
        CheckExternalEvents(cs1, 0xDE60);
        // 100D:DE60 mov byte ptr DS:[0xCEE9],1
        UInt8[DS, (ushort)0xCEE9] = (byte)0x01;
        // 100D:DE65 jmp short 0xDE4E
        return kb_clear_scancode(0x0000);
    label_100D_DE67_1DF37_3354:
        CheckExternalEvents(cs1, 0xDE67);
        // 100D:DE67 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action kb_drain_and_clear(int loadOffset)
    {
    label_100D_DE68_1DF38_40410:
        CheckExternalEvents(cs1, 0xDE68);
        // 100D:DE68 call near 0xDD5A
        NearCall(cs1, 0xDE6B, get_and_reset_key_scancode);
    label_100D_DE6B_1DF3B_40424:
        CheckExternalEvents(cs1, 0xDE6B);
        // 100D:DE6B jne short 0xDE68
        if (!ZeroFlag)
        {
            goto label_100D_DE68_1DF38_40410;
        }
    label_100D_DE6D_1DF3D_40427:
        CheckExternalEvents(cs1, 0xDE6D);
        // 100D:DE6D jmp near 0xF08E
    label_100D_F08E_1F15E_40429:
        CheckExternalEvents(cs1, 0xF08E);
        // 100D:F08E push ES
        Stack.Push16(ES);
        // 100D:F08F push DS
        Stack.Push16(DS);
        // 100D:F090 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F091 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:F093 mov byte ptr DS:[0xCEE8],AL
        UInt8[DS, (ushort)0xCEE8] = AL;
        // 100D:F096 mov DI,0xCE81
        DI = (ushort)0xCE81;
        // 100D:F099 mov CX,0x0067
        CX = (ushort)0x0067;
        // 100D:F09C rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:F09E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F09F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action pause_if_p_key_pressed(int loadOffset)
    {
        goto label_100D_DE7B_1DF4B_4724;

    label_100D_DE7A_1DF4A_4727:
        CheckExternalEvents(cs1, 0xDE7A);
        // 100D:DE7A ret near
        return NearRet((ushort)0x0000);
    label_100D_DE7B_1DF4B_4724:
        CheckExternalEvents(cs1, 0xDE7B);
        // 100D:DE7B cmp byte ptr DS:[0xCE9A],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE9A], (byte)0x00);
        // 100D:DE80 je short 0xDE7A
        if (ZeroFlag)
        {
            goto label_100D_DE7A_1DF4A_4727;
        }
    label_100D_DE82_1DF52_40340:
        CheckExternalEvents(cs1, 0xDE82);
        // 100D:DE82 cmp byte ptr DS:[0xCE80],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE80], (byte)0x00);
        // 100D:DE87 je short 0xDE7A
        if (ZeroFlag)
        {
            goto label_100D_DE7A_1DF4A_4727;
        }
    label_100D_DE89_1DF59_40344:
        CheckExternalEvents(cs1, 0xDE89);
        // 100D:DE89 call near 0xE270
        NearCall(cs1, 0xDE8C, unknown_100D_E270_1E340);
    label_100D_DE8C_1DF5C_40349:
        CheckExternalEvents(cs1, 0xDE8C);
        // 100D:DE8C mov AL,1
        AL = (byte)0x01;
        // 100D:DE8E xchg AL,byte ptr DS:[0x2788]
        ushort xchgOffset_100D_DE8E_1DF5E = (ushort)0x2788;
        byte temp_100D_DE8E_1DF5E = AL;
        AL = UInt8[DS, xchgOffset_100D_DE8E_1DF5E];
        UInt8[DS, xchgOffset_100D_DE8E_1DF5E] = unchecked((byte)temp_100D_DE8E_1DF5E);
        // 100D:DE92 push AX
        Stack.Push16(AX);
        // 100D:DE93 push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
        // 100D:DE97 call near 0xDBB2
        NearCall(cs1, 0xDE9A, call_restore_cursor);
    label_100D_DE9A_1DF6A_40360:
        CheckExternalEvents(cs1, 0xDE9A);
        // 100D:DE9A push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:DE9E call near 0xC08E
        NearCall(cs1, 0xDEA1, set_screen_as_active_framebuffer);
    label_100D_DEA1_1DF71_40365:
        CheckExternalEvents(cs1, 0xDEA1);
        // 100D:DEA1 push word ptr DS:[0xDBD6]
        Stack.Push16(UInt16[DS, (ushort)0xDBD6]);
        // 100D:DEA5 call far dword ptr DS:[0x38B9]
        ushort targetSegment_40366 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38B9 + (ushort)0x0002)]));
        ushort targetOffset_40366 = unchecked((ushort)(UInt16[DS, (ushort)0x38B9]));
        if (targetSegment_40366 == cs2 && targetOffset_40366 == 0x0103)
        {
            FarCall(cs1, 0xDEA9, cs2, unknown_3358_0103_33683);
            goto label_100D_DEA9_1DF79_40369;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_40366:X4}:{targetOffset_40366:X4} at 100D:DEA5");
    label_100D_DEA9_1DF79_40369:
        CheckExternalEvents(cs1, 0xDEA9);
        // 100D:DEA9 mov word ptr DS:[0xDBD6],AX
        UInt16[DS, (ushort)0xDBD6] = AX;
        // 100D:DEAC mov SI,0x2945
        SI = (ushort)0x2945;
        // 100D:DEAF call near 0x7B1B
        NearCall(cs1, 0xDEB2, map_draw_panel_record);
    label_100D_DEB2_1DF82_40376:
        CheckExternalEvents(cs1, 0xDEB2);
        // 100D:DEB2 mov CX,0xF1FE
        CX = (ushort)0xF1FE;
        // 100D:DEB5 mov DX,0x0082
        DX = (ushort)0x0082;
        // 100D:DEB8 mov BX,0x00A9
        BX = (ushort)0x00A9;
        // 100D:DEBB mov AX,0x0115
        AX = (ushort)0x0115;
        // 100D:DEBE call near 0xD068
        NearCall(cs1, 0xDEC1, font_select_tall_font);
    label_100D_DEC1_1DF91_40387:
        CheckExternalEvents(cs1, 0xDEC1);
        // 100D:DEC1 call near 0xD194
        NearCall(cs1, 0xDEC4, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_DEC4_1DF94_40390:
        CheckExternalEvents(cs1, 0xDEC4);
        // 100D:DEC4 call near 0xD075
        NearCall(cs1, 0xDEC7, font_select_small_font);
    label_100D_DEC7_1DF97_40393:
        CheckExternalEvents(cs1, 0xDEC7);
        // 100D:DEC7 mov DX,0x0060
        DX = (ushort)0x0060;
        // 100D:DECA mov BX,0x00B8
        BX = (ushort)0x00B8;
        // 100D:DECD mov AX,0x0116
        AX = (ushort)0x0116;
        // 100D:DED0 mov CX,0xF1F7
        CX = (ushort)0xF1F7;
        // 100D:DED3 call near 0xD194
        NearCall(cs1, 0xDED6, font_draw_phrase_or_command_string_with_color_at_pos);
    label_100D_DED6_1DFA6_40404:
        CheckExternalEvents(cs1, 0xDED6);
        // 100D:DED6 cmp byte ptr DS:[0xCE9A],0
        Alu8.Sub(UInt8[DS, (ushort)0xCE9A], (byte)0x00);
        // 100D:DEDB jne short 0xDED6
        if (!ZeroFlag)
        {
            goto label_100D_DED6_1DFA6_40404;
        }
    label_100D_DEDD_1DFAD_40408:
        CheckExternalEvents(cs1, 0xDEDD);
        // 100D:DEDD call near 0xDE68
        NearCall(cs1, 0xDEE0, kb_drain_and_clear);
    label_100D_DEE0_1DFB0_40451:
        CheckExternalEvents(cs1, 0xDEE0);
        // 100D:DEE0 call near 0xDD5A
        NearCall(cs1, 0xDEE3, get_and_reset_key_scancode);
    label_100D_DEE3_1DFB3_40454:
        CheckExternalEvents(cs1, 0xDEE3);
        // 100D:DEE3 je short 0xDEE0
        if (ZeroFlag)
        {
            goto label_100D_DEE0_1DFB0_40451;
        }
    label_100D_DEE5_1DFB5_40457:
        CheckExternalEvents(cs1, 0xDEE5);
        // 100D:DEE5 push AX
        Stack.Push16(AX);
        // 100D:DEE6 call near 0xDE68
        NearCall(cs1, 0xDEE9, kb_drain_and_clear);
    label_100D_DEE9_1DFB9_40463:
        CheckExternalEvents(cs1, 0xDEE9);
        // 100D:DEE9 call near 0xDF07
        NearCall(cs1, 0xDEEC, pause_remove_window);
    label_100D_DEEC_1DFBC_40486:
        CheckExternalEvents(cs1, 0xDEEC);
        // 100D:DEEC pop AX
        AX = Stack.Pop16();
        // 100D:DEED dec AL
        AL = Alu8.Dec(AL);
        // 100D:DEEF je short 0xDEE0
        if (ZeroFlag)
        {
            goto label_100D_DEE0_1DFB0_40451;
        }
    label_100D_DEF1_1DFC1_40491:
        CheckExternalEvents(cs1, 0xDEF1);
        // 100D:DEF1 pop word ptr DS:[0xDBD6]
        ushort popStackCheck_100D_DEF1_1DFC1 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_DEF1_1DFC1 = UInt16[DS, (ushort)0xDBD6];
        ushort poppedValue_100D_DEF1_1DFC1 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBD6] = unchecked((ushort)poppedValue_100D_DEF1_1DFC1);
        // 100D:DEF5 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_DEF5_1DFC5 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_DEF5_1DFC5 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_DEF5_1DFC5 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_DEF5_1DFC5);
        // 100D:DEF9 pop word ptr DS:[0xCE7A]
        ushort popStackCheck_100D_DEF9_1DFC9 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_DEF9_1DFC9 = UInt16[DS, (ushort)0xCE7A];
        ushort poppedValue_100D_DEF9_1DFC9 = Stack.Pop16();
        UInt16[DS, (ushort)0xCE7A] = unchecked((ushort)poppedValue_100D_DEF9_1DFC9);
        // 100D:DEFD pop AX
        AX = Stack.Pop16();
        // 100D:DEFE mov byte ptr DS:[0x2788],AL
        UInt8[DS, (ushort)0x2788] = AL;
        // 100D:DF01 call near 0xE283
        NearCall(cs1, 0xDF04, unknown_100D_E283_1E353);
    label_100D_DF04_1DFD4_40507:
        CheckExternalEvents(cs1, 0xDF04);
        // 100D:DF04 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:DF06 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action pause_remove_window(int loadOffset)
    {
    entrydispatcher:
    label_100D_DF07_1DFD7_40464:
        CheckExternalEvents(cs1, 0xDF07);
        // 100D:DF07 push word ptr DS:[0x2784]
        Stack.Push16(UInt16[DS, (ushort)0x2784]);
        // 100D:DF0B mov SI,0x1B48
        SI = (ushort)0x1B48;
        // 100D:DF0E mov CX,5
        CX = (ushort)0x0005;
        // 100D:DF11 call near 0xD1F2
        NearCall(cs1, 0xDF14, draw_ui_elements_list);
    label_100D_DF14_1DFE4_40475:
        CheckExternalEvents(cs1, 0xDF14);
        // 100D:DF14 pop AX
        AX = Stack.Pop16();
        // 100D:DF15 call near 0xC13E
        NearCall(cs1, 0xDF18, open_sprite_bank);
    label_100D_DF18_1DFE8_40480:
        CheckExternalEvents(cs1, 0xDF18);
        // 100D:DF18 call near 0xD397
        NearCall(cs1, 0xDF1B, redraw_active_command_menu);
    label_100D_DF1B_1DFEB_40483:
        CheckExternalEvents(cs1, 0xDF1B);
        // 100D:DF1B jmp near 0xDBEC
        if (JumpDispatcher.Jump(draw_mouse, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action get_mouse_pos_etc(int loadOffset)
    {
    label_100D_DF1E_1DFEE_14708:
        CheckExternalEvents(cs1, 0xDF1E);
        // 100D:DF1E call near 0xDE7B
        NearCall(cs1, 0xDF21, pause_if_p_key_pressed);
    label_100D_DF21_1DFF1_14710:
        CheckExternalEvents(cs1, 0xDF21);
        // 100D:DF21 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:DF23 test byte ptr DS:[0x2942],0x40
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x40);
        // 100D:DF28 jne short 0xDF49
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:DF28");
        }
    label_100D_DF2A_1DFFA_14714:
        CheckExternalEvents(cs1, 0xDF2A);
        // 100D:DF2A mov AX,3
        AX = (ushort)0x0003;
        // 100D:DF2D int 0x33
        InterruptCall(cs1, 0xDF2F, unchecked((byte)((byte)0x33)));
    label_100D_DF2F_1DFFF_14717:
        CheckExternalEvents(cs1, 0xDF2F);
        // 100D:DF2F mov AX,CX
        AX = CX;
        // 100D:DF31 mov CX,word ptr DS:[0x2580]
        CX = UInt16[DS, (ushort)0x2580];
        // 100D:DF35 shr AX,CL
        AX = Alu16.Shr(AX, unchecked((int)CL));
        // 100D:DF37 mov CL,CH
        CL = CH;
        // 100D:DF39 shr DX,CL
        DX = Alu16.Shr(DX, unchecked((int)CL));
        // 100D:DF3B mov CX,AX
        CX = AX;
        // 100D:DF3D mov AL,BL
        AL = BL;
        // 100D:DF3F and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:DF41 mov word ptr DS:[0xDC36],CX
        UInt16[DS, (ushort)0xDC36] = CX;
        // 100D:DF45 mov word ptr DS:[0xDC38],DX
        UInt16[DS, (ushort)0xDC38] = DX;
        // 100D:DF49 mov byte ptr DS:[0xDC34],AL
        UInt8[DS, (ushort)0xDC34] = AL;
        // 100D:DF4C test byte ptr DS:[0x2942],0x80
        Alu8.And(UInt8[DS, (ushort)0x2942], (byte)0x80);
        // 100D:DF51 je short 0xDF56
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:DF51");
        }
    label_100D_DF56_1E026_14731:
        CheckExternalEvents(cs1, 0xDF56);
        // 100D:DF56 mov SI,0xCEC8
        SI = (ushort)0xCEC8;
        // 100D:DF59 mov DI,word ptr DS:[0xDC48]
        DI = UInt16[DS, (ushort)0xDC48];
        // 100D:DF5D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:DF5F mov BX,DX
        BX = DX;
        // 100D:DF61 mov AX,DX
        AX = DX;
        // 100D:DF63 mov CX,0x000D
        CX = (ushort)0x000D;
    label_100D_DF66_1E036_14738:
        CheckExternalEvents(cs1, 0xDF66);
        // 100D:DF66 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:DF67 or AL,byte ptr DS:[SI+0x12]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)(SI + (sbyte)18)]);
        // 100D:DF6A je short 0xDF74
        if (ZeroFlag)
        {
            goto label_100D_DF74_1E044_14741;
        }
    label_100D_DF6C_1E03C_38390:
        CheckExternalEvents(cs1, 0xDF6C);
        // 100D:DF6C or AH,byte ptr DS:[DI]
        AH = Alu8.Or(AH, UInt8[DS, DI]);
        // 100D:DF6E add DX,word ptr DS:[DI+2]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:DF71 add BX,word ptr DS:[DI+4]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
    label_100D_DF74_1E044_14741:
        CheckExternalEvents(cs1, 0xDF74);
        // 100D:DF74 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:DF77 loop 0xDF66
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_DF66_1E036_14738;
        }
    label_100D_DF79_1E049_14745:
        CheckExternalEvents(cs1, 0xDF79);
        // 100D:DF79 mov AL,byte ptr DS:[0xCEBA]
        AL = UInt8[DS, (ushort)0xCEBA];
        // 100D:DF7C or AL,byte ptr DS:[0xCE9D]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0xCE9D]);
        // 100D:DF80 or AL,byte ptr DS:[0xCEE6]
        AL = Alu8.Or(AL, UInt8[DS, (ushort)0xCEE6]);
        // 100D:DF84 and AL,1
        AL = Alu8.And(AL, (byte)0x01);
        // 100D:DF86 mov AH,AL
        AH = AL;
        // 100D:DF88 xchg AL,byte ptr DS:[0xDC57]
        ushort xchgOffset_100D_DF88_1E058 = (ushort)0xDC57;
        byte temp_100D_DF88_1E058 = AL;
        AL = UInt8[DS, xchgOffset_100D_DF88_1E058];
        UInt8[DS, xchgOffset_100D_DF88_1E058] = unchecked((byte)temp_100D_DF88_1E058);
        // 100D:DF8C not AL
        AL = unchecked((byte)~AL);
        // 100D:DF8E and AL,byte ptr DS:[0xDC34]
        AL = Alu8.And(AL, UInt8[DS, (ushort)0xDC34]);
        // 100D:DF92 or AL,AH
        AL = Alu8.Or(AL, AH);
        // 100D:DF94 mov byte ptr DS:[0xDC34],AL
        UInt8[DS, (ushort)0xDC34] = AL;
        // 100D:DF97 mov AX,DX
        AX = DX;
        // 100D:DF99 or AX,BX
        AX = Alu16.Or(AX, BX);
        // 100D:DF9B jne short 0xDFB7
        if (!ZeroFlag)
        {
            goto label_100D_DFB7_1E087_38397;
        }
    label_100D_DF9D_1E06D_14759:
        CheckExternalEvents(cs1, 0xDF9D);
        // 100D:DF9D mov word ptr DS:[0xDC51],AX
        UInt16[DS, (ushort)0xDC51] = AX;
        // 100D:DFA0 mov word ptr DS:[0xDC53],AX
        UInt16[DS, (ushort)0xDC53] = AX;
        // 100D:DFA3 mov word ptr DS:[0xDC55],AX
        UInt16[DS, (ushort)0xDC55] = AX;
    label_100D_DFA6_1E076_14763:
        CheckExternalEvents(cs1, 0xDFA6);
        // 100D:DFA6 ret near
        return NearRet((ushort)0x0000);
    label_100D_DFB7_1E087_38397:
        CheckExternalEvents(cs1, 0xDFB7);
        // 100D:DFB7 cmp byte ptr DS:[0xCE9E],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0xCE9E], (byte)0xFF);
        // 100D:DFBC jne short 0xDFC1
        if (!ZeroFlag)
        {
            goto label_100D_DFC1_1E091_38400;
        }
    label_100D_DFBE_1E08E_38402:
        CheckExternalEvents(cs1, 0xDFBE);
        VerifySpeculativeEntryOrFail(cs1, 0xDFBE, [(byte)0xE9, (byte)0x10, (byte)0x02]);
        // 100D:DFBE jmp near 0xE1D1
        goto label_100D_E1D1_1E2A1_38405;
    label_100D_DFC1_1E091_38400:
        CheckExternalEvents(cs1, 0xDFC1);
        // 100D:DFC1 mov DI,0xDFA9
        DI = (ushort)0xDFA9;
        // 100D:DFC4 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:DFC6 je short 0xDFDB
        if (ZeroFlag)
        {
            goto label_100D_DFDB_1E0AB_38409;
        }
    label_100D_DFC8_1E098_38411:
        CheckExternalEvents(cs1, 0xDFC8);
        // 100D:DFC8 jns short 0xDFCD
        if (!SignFlag)
        {
            goto label_100D_DFCD_1E09D_38418;
        }
    label_100D_DFCA_1E09A_38420:
        CheckExternalEvents(cs1, 0xDFCA);
        // 100D:DFCA add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_100D_DFCD_1E09D_38418:
        CheckExternalEvents(cs1, 0xDFCD);
        // 100D:DFCD or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:DFCF je short 0xDFE7
        if (ZeroFlag)
        {
            goto label_100D_DFE7_1E0B7_38436;
        }
    label_100D_DFD1_1E0A1_38438:
        CheckExternalEvents(cs1, 0xDFD1);
        // 100D:DFD1 lea DI,DI-2
        DI = unchecked((ushort)(DI + (sbyte)-2));
        // 100D:DFD4 js short 0xDFE7
        if (SignFlag)
        {
            goto label_100D_DFE7_1E0B7_38436;
        }
    label_100D_DFD6_1E0A6_38461:
        CheckExternalEvents(cs1, 0xDFD6);
        // 100D:DFD6 add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:DFD9 jmp short 0xDFE7
        goto label_100D_DFE7_1E0B7_38436;
    label_100D_DFDB_1E0AB_38409:
        CheckExternalEvents(cs1, 0xDFDB);
        // 100D:DFDB mov DI,0xDFB3
        DI = (ushort)0xDFB3;
        // 100D:DFDE or BL,BL
        BL = Alu8.Or(BL, BL);
        // 100D:DFE0 je short 0xDFA6
        if (ZeroFlag)
        {
            goto label_100D_DFA6_1E076_14763;
        }
    label_100D_DFE2_1E0B2_38434:
        CheckExternalEvents(cs1, 0xDFE2);
        // 100D:DFE2 js short 0xDFE7
        if (SignFlag)
        {
            goto label_100D_DFE7_1E0B7_38436;
        }
    label_100D_DFE4_1E0B4_38447:
        CheckExternalEvents(cs1, 0xDFE4);
        // 100D:DFE4 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_DFE7_1E0B7_38436:
        CheckExternalEvents(cs1, 0xDFE7);
        // 100D:DFE7 mov BX,word ptr CS:[DI]
        BX = UInt16[CS, DI];
        // 100D:DFEA sub SP,0x000A
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:DFED mov BP,SP
        BP = SP;
        // 100D:DFEF mov word ptr SS:[BP],BX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = BX;
        // 100D:DFF2 call near 0xDE4E
        NearCall(cs1, 0xDFF5, kb_clear_scancode);
    label_100D_DFF5_1E0C5_38548:
        CheckExternalEvents(cs1, 0xDFF5);
        // 100D:DFF5 mov DX,word ptr DS:[0xDC36]
        DX = UInt16[DS, (ushort)0xDC36];
        // 100D:DFF9 mov BX,word ptr DS:[0xDC38]
        BX = UInt16[DS, (ushort)0xDC38];
        // 100D:DFFD mov DI,0x1AE4
        DI = (ushort)0x1AE4;
        // 100D:E000 mov CX,word ptr DS:[DI]
        CX = UInt16[DS, DI];
        // 100D:E002 mov word ptr SS:[BP+2],0x8000
        UInt16[SS, (ushort)(BP + (sbyte)2)] = (ushort)0x8000;
        // 100D:E007 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_E00A_1E0DA_38555:
        CheckExternalEvents(cs1, 0xE00A);
        // 100D:E00A test byte ptr DS:[DI+8],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x80);
        // 100D:E00E je short 0xE02C
        if (ZeroFlag)
        {
            goto label_100D_E02C_1E0FC_38557;
        }
    label_100D_E010_1E0E0_38559:
        CheckExternalEvents(cs1, 0xE010);
        // 100D:E010 call near 0xD6FE
        NearCall(cs1, 0xE013, contains_interior);
    label_100D_E013_1E0E3_38581:
        CheckExternalEvents(cs1, 0xE013);
        // 100D:E013 jb short 0xE02C
        if (CarryFlag)
        {
            goto label_100D_E02C_1E0FC_38557;
        }
    label_100D_E015_1E0E5_38584:
        CheckExternalEvents(cs1, 0xE015);
        // 100D:E015 call near 0xE159
        NearCall(cs1, 0xE018, unknown_100D_E159_1E229);
    label_100D_E018_1E0E8_38608:
        CheckExternalEvents(cs1, 0xE018);
        // 100D:E018 call near word ptr SS:[BP]
        switch ((ushort)(UInt16[SS, (ushort)(BP + (sbyte)0)]))
        {
            case 0xE16F:
                NearCall(cs1, 0xE01B, unknown_100D_E16F_1E23F);
                break;
            case 0xE18C:
                NearCall(cs1, 0xE01B, unknown_100D_E18C_1E25C);
                break;
            case 0xE192:
                NearCall(cs1, 0xE01B, unknown_100D_E192_1E262);
                break;
            case 0xE19B:
                NearCall(cs1, 0xE01B, unknown_100D_E19B_1E26B);
                break;
            case 0xE1CB:
                NearCall(cs1, 0xE01B, unknown_100D_E1CB_1E29B);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[SS, (ushort)(BP + (sbyte)0)])):X4} at 100D:E018");
        }
    label_100D_E01B_1E0EB_38646:
        CheckExternalEvents(cs1, 0xE01B);
        // 100D:E01B cmp AX,word ptr SS:[BP+2]
        Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)2)]);
        // 100D:E01E jae short 0xE02C
        if (!CarryFlag)
        {
            goto label_100D_E02C_1E0FC_38557;
        }
    label_100D_E020_1E0F0_38650:
        CheckExternalEvents(cs1, 0xE020);
        // 100D:E020 mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:E023 call near 0xE159
        NearCall(cs1, 0xE026, unknown_100D_E159_1E229);
    label_100D_E026_1E0F6_38834:
        CheckExternalEvents(cs1, 0xE026);
        // 100D:E026 mov word ptr SS:[BP+4],AX
        UInt16[SS, (ushort)(BP + (sbyte)4)] = AX;
        // 100D:E029 mov word ptr SS:[BP+6],SI
        UInt16[SS, (ushort)(BP + (sbyte)6)] = SI;
    label_100D_E02C_1E0FC_38557:
        CheckExternalEvents(cs1, 0xE02C);
        // 100D:E02C add DI,0x000E
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 100D:E02F loop 0xE00A
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_E00A_1E0DA_38555;
        }
    label_100D_E031_1E101_38565:
        CheckExternalEvents(cs1, 0xE031);
        // 100D:E031 call near 0xE068
        NearCall(cs1, 0xE034, unknown_100D_E068_1E138);
    label_100D_E034_1E104_38686:
        CheckExternalEvents(cs1, 0xE034);
        // 100D:E034 call near 0xE0A2
        NearCall(cs1, 0xE037, unknown_100D_E0A2_1E172);
    label_100D_E037_1E107_38714:
        CheckExternalEvents(cs1, 0xE037);
        // 100D:E037 call near 0xE0DB
        NearCall(cs1, 0xE03A, unknown_100D_E0DB_1E1AB);
    label_100D_E03A_1E10A_38744:
        CheckExternalEvents(cs1, 0xE03A);
        // 100D:E03A call near 0xE11C
        NearCall(cs1, 0xE03D, unknown_100D_E11C_1E1EC);
    label_100D_E03D_1E10D_38776:
        CheckExternalEvents(cs1, 0xE03D);
        // 100D:E03D cmp word ptr SS:[BP+2],0
        Alu16.Sub(UInt16[SS, (ushort)(BP + (sbyte)2)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:E041 js short 0xE064
        if (SignFlag)
        {
            goto label_100D_E064_1E134_38779;
        }
    label_100D_E043_1E113_38781:
        CheckExternalEvents(cs1, 0xE043);
        // 100D:E043 mov byte ptr DS:[0xCEBA],0
        UInt8[DS, (ushort)0xCEBA] = (byte)0x00;
        // 100D:E048 or byte ptr DS:[0xCE9D],0
        UInt8[DS, (ushort)0xCE9D] = Alu8.Or(UInt8[DS, (ushort)0xCE9D], (byte)0x00);
        // 100D:E04D mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:E050 mov word ptr DS:[0xDC4C],AX
        UInt16[DS, (ushort)0xDC4C] = AX;
        // 100D:E053 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:E056 mov word ptr DS:[0xDC4E],AX
        UInt16[DS, (ushort)0xDC4E] = AX;
        // 100D:E059 mov byte ptr DS:[0xDC4B],0x64
        UInt8[DS, (ushort)0xDC4B] = (byte)0x64;
        // 100D:E05E mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:E061 mov byte ptr DS:[0xDC4A],AL
        UInt8[DS, (ushort)0xDC4A] = AL;
    label_100D_E064_1E134_38779:
        CheckExternalEvents(cs1, 0xE064);
        // 100D:E064 add SP,0x000A
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:E067 ret near
        return NearRet((ushort)0x0000);
    label_100D_E1D1_1E2A1_38405:
        CheckExternalEvents(cs1, 0xE1D1);
        VerifySpeculativeEntryOrFail(cs1, 0xE1D1, [(byte)0x0A, (byte)0xD2]);
        // 100D:E1D1 or DL,DL
        DL = Alu8.Or(DL, DL);
        VerifySpeculativeEntryOrFail(cs1, 0xE1D3, [(byte)0x74, (byte)0x1E]);
        // 100D:E1D3 je short 0xE1F3
        if (ZeroFlag)
        {
            goto label_100D_E1F3_1E2C3_38413;
        }
    label_100D_E1D5_1E2A5_38415:
        CheckExternalEvents(cs1, 0xE1D5);
        VerifySpeculativeEntryOrFail(cs1, 0xE1D5, [(byte)0xA1, (byte)0x51, (byte)0xDC]);
        // 100D:E1D5 mov AX,word ptr DS:[0xDC51]
        AX = UInt16[DS, (ushort)0xDC51];
        VerifySpeculativeEntryOrFail(cs1, 0xE1D8, [(byte)0x0B, (byte)0xC0]);
        // 100D:E1D8 or AX,AX
        AX = Alu16.Or(AX, AX);
        VerifySpeculativeEntryOrFail(cs1, 0xE1DA, [(byte)0x79, (byte)0x02]);
        // 100D:E1DA jns short 0xE1DE
        if (!SignFlag)
        {
            goto label_100D_E1DE_1E2AE_38442;
        }
    label_100D_E1DC_1E2AC_38444:
        CheckExternalEvents(cs1, 0xE1DC);
        VerifySpeculativeEntryOrFail(cs1, 0xE1DC, [(byte)0xF7, (byte)0xD8]);
        // 100D:E1DC neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_E1DE_1E2AE_38442:
        CheckExternalEvents(cs1, 0xE1DE);
        VerifySpeculativeEntryOrFail(cs1, 0xE1DE, [(byte)0x3D, (byte)0x04, (byte)0x00]);
        // 100D:E1DE cmp AX,4
        Alu16.Sub(AX, (ushort)0x0004);
        VerifySpeculativeEntryOrFail(cs1, 0xE1E1, [(byte)0x72, (byte)0x10]);
        // 100D:E1E1 jb short 0xE1F3
        if (CarryFlag)
        {
            goto label_100D_E1F3_1E2C3_38413;
        }
    label_100D_E1E3_1E2B3_38467:
        CheckExternalEvents(cs1, 0xE1E3);
        VerifySpeculativeEntryOrFail(cs1, 0xE1E3, [(byte)0x02, (byte)0xD2]);
        // 100D:E1E3 add DL,DL
        DL = Alu8.Add(DL, DL);
        VerifySpeculativeEntryOrFail(cs1, 0xE1E5, [(byte)0x3D, (byte)0x0C, (byte)0x00]);
        // 100D:E1E5 cmp AX,0x000C
        Alu16.Sub(AX, (ushort)0x000C);
        VerifySpeculativeEntryOrFail(cs1, 0xE1E8, [(byte)0x72, (byte)0x09]);
        // 100D:E1E8 jb short 0xE1F3
        if (CarryFlag)
        {
            goto label_100D_E1F3_1E2C3_38413;
        }
    label_100D_E1EA_1E2BA_38488:
        CheckExternalEvents(cs1, 0xE1EA);
        VerifySpeculativeEntryOrFail(cs1, 0xE1EA, [(byte)0x02, (byte)0xD2]);
        // 100D:E1EA add DL,DL
        DL = Alu8.Add(DL, DL);
        VerifySpeculativeEntryOrFail(cs1, 0xE1EC, [(byte)0x3D, (byte)0x24, (byte)0x00]);
        // 100D:E1EC cmp AX,0x0024
        Alu16.Sub(AX, (ushort)0x0024);
        VerifySpeculativeEntryOrFail(cs1, 0xE1EF, [(byte)0x72, (byte)0x02]);
        // 100D:E1EF jb short 0xE1F3
        if (CarryFlag)
        {
            goto label_100D_E1F3_1E2C3_38413;
        }
    label_100D_E1F1_1E2C1_38502:
        CheckExternalEvents(cs1, 0xE1F1);
        VerifySpeculativeEntryOrFail(cs1, 0xE1F1, [(byte)0x02, (byte)0xD2]);
        // 100D:E1F1 add DL,DL
        DL = Alu8.Add(DL, DL);
    label_100D_E1F3_1E2C3_38413:
        CheckExternalEvents(cs1, 0xE1F3);
        VerifySpeculativeEntryOrFail(cs1, 0xE1F3, [(byte)0x0A, (byte)0xDB]);
        // 100D:E1F3 or BL,BL
        BL = Alu8.Or(BL, BL);
        VerifySpeculativeEntryOrFail(cs1, 0xE1F5, [(byte)0x74, (byte)0x1C]);
        // 100D:E1F5 je short 0xE213
        if (ZeroFlag)
        {
            goto label_100D_E213_1E2E3_38427;
        }
    label_100D_E1F7_1E2C7_38429:
        CheckExternalEvents(cs1, 0xE1F7);
        VerifySpeculativeEntryOrFail(cs1, 0xE1F7, [(byte)0xA1, (byte)0x53, (byte)0xDC]);
        // 100D:E1F7 mov AX,word ptr DS:[0xDC53]
        AX = UInt16[DS, (ushort)0xDC53];
        VerifySpeculativeEntryOrFail(cs1, 0xE1FA, [(byte)0x79, (byte)0x02]);
        // 100D:E1FA jns short 0xE1FE
        if (!SignFlag)
        {
            goto label_100D_E1FE_1E2CE_38452;
        }
    label_100D_E1FC_1E2CC_38454:
        CheckExternalEvents(cs1, 0xE1FC);
        VerifySpeculativeEntryOrFail(cs1, 0xE1FC, [(byte)0xF7, (byte)0xD8]);
        // 100D:E1FC neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_E1FE_1E2CE_38452:
        CheckExternalEvents(cs1, 0xE1FE);
        VerifySpeculativeEntryOrFail(cs1, 0xE1FE, [(byte)0x3D, (byte)0x03, (byte)0x00]);
        // 100D:E1FE cmp AX,3
        Alu16.Sub(AX, (ushort)0x0003);
        VerifySpeculativeEntryOrFail(cs1, 0xE201, [(byte)0x72, (byte)0x10]);
        // 100D:E201 jb short 0xE213
        if (CarryFlag)
        {
            goto label_100D_E213_1E2E3_38427;
        }
    label_100D_E203_1E2D3_38473:
        CheckExternalEvents(cs1, 0xE203);
        VerifySpeculativeEntryOrFail(cs1, 0xE203, [(byte)0x02, (byte)0xDB]);
        // 100D:E203 add BL,BL
        BL = Alu8.Add(BL, BL);
        VerifySpeculativeEntryOrFail(cs1, 0xE205, [(byte)0x3D, (byte)0x0A, (byte)0x00]);
        // 100D:E205 cmp AX,0x000A
        Alu16.Sub(AX, (ushort)0x000A);
        VerifySpeculativeEntryOrFail(cs1, 0xE208, [(byte)0x72, (byte)0x09]);
        // 100D:E208 jb short 0xE213
        if (CarryFlag)
        {
            goto label_100D_E213_1E2E3_38427;
        }
    label_100D_E20A_1E2DA_38493:
        CheckExternalEvents(cs1, 0xE20A);
        VerifySpeculativeEntryOrFail(cs1, 0xE20A, [(byte)0x02, (byte)0xDB]);
        // 100D:E20A add BL,BL
        BL = Alu8.Add(BL, BL);
        VerifySpeculativeEntryOrFail(cs1, 0xE20C, [(byte)0x3D, (byte)0x1C, (byte)0x00]);
        // 100D:E20C cmp AX,0x001C
        Alu16.Sub(AX, (ushort)0x001C);
        VerifySpeculativeEntryOrFail(cs1, 0xE20F, [(byte)0x72, (byte)0x02]);
        // 100D:E20F jb short 0xE213
        if (CarryFlag)
        {
            goto label_100D_E213_1E2E3_38427;
        }
    label_100D_E211_1E2E1_38507:
        CheckExternalEvents(cs1, 0xE211);
        VerifySpeculativeEntryOrFail(cs1, 0xE211, [(byte)0x02, (byte)0xDB]);
        // 100D:E211 add BL,BL
        BL = Alu8.Add(BL, BL);
    label_100D_E213_1E2E3_38427:
        CheckExternalEvents(cs1, 0xE213);
        VerifySpeculativeEntryOrFail(cs1, 0xE213, [(byte)0xA0, (byte)0x7A, (byte)0xCE]);
        // 100D:E213 mov AL,byte ptr DS:[0xCE7A]
        AL = UInt8[DS, (ushort)0xCE7A];
        VerifySpeculativeEntryOrFail(cs1, 0xE216, [(byte)0x8A, (byte)0xE0]);
        // 100D:E216 mov AH,AL
        AH = AL;
        VerifySpeculativeEntryOrFail(cs1, 0xE218, [(byte)0x86, (byte)0x26, (byte)0x50, (byte)0xDC]);
        // 100D:E218 xchg AH,byte ptr DS:[0xDC50]
        ushort xchgOffset_100D_E218_1E2E8 = (ushort)0xDC50;
        byte temp_100D_E218_1E2E8 = AH;
        AH = UInt8[DS, xchgOffset_100D_E218_1E2E8];
        UInt8[DS, xchgOffset_100D_E218_1E2E8] = unchecked((byte)temp_100D_E218_1E2E8);
        VerifySpeculativeEntryOrFail(cs1, 0xE21C, [(byte)0x2A, (byte)0xC4]);
        // 100D:E21C sub AL,AH
        AL = Alu8.Sub(AL, AH);
        VerifySpeculativeEntryOrFail(cs1, 0xE21E, [(byte)0x3C, (byte)0x08]);
        // 100D:E21E cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        VerifySpeculativeEntryOrFail(cs1, 0xE220, [(byte)0x72, (byte)0x02]);
        // 100D:E220 jb short 0xE224
        if (CarryFlag)
        {
            goto label_100D_E224_1E2F4_38482;
        }
    label_100D_E222_1E2F2_38484:
        CheckExternalEvents(cs1, 0xE222);
        VerifySpeculativeEntryOrFail(cs1, 0xE222, [(byte)0xB0, (byte)0x08]);
        // 100D:E222 mov AL,8
        AL = (byte)0x08;
    label_100D_E224_1E2F4_38482:
        CheckExternalEvents(cs1, 0xE224);
        VerifySpeculativeEntryOrFail(cs1, 0xE224, [(byte)0x8A, (byte)0xC8]);
        // 100D:E224 mov CL,AL
        CL = AL;
        VerifySpeculativeEntryOrFail(cs1, 0xE226, [(byte)0xBE, (byte)0x55, (byte)0xDC]);
        // 100D:E226 mov SI,0xDC55
        SI = (ushort)0xDC55;
        VerifySpeculativeEntryOrFail(cs1, 0xE229, [(byte)0x8A, (byte)0xC2]);
        // 100D:E229 mov AL,DL
        AL = DL;
        VerifySpeculativeEntryOrFail(cs1, 0xE22B, [(byte)0xE8, (byte)0x15, (byte)0x00]);
        // 100D:E22B call near 0xE243
        NearCall(cs1, 0xE22E, unknown_100D_E243_1E313);
        throw FailAsUntested("Call at 100D:E22B returned to 100D:E22E, but no continuation was observed during discovery.");
    }

    public virtual Action unknown_100D_E068_1E138(int loadOffset)
    {
    label_100D_E068_1E138_38567:
        CheckExternalEvents(cs1, 0xE068);
        // 100D:E068 push BP
        Stack.Push16(BP);
        // 100D:E069 call near 0xD41B
        NearCall(cs1, 0xE06C, get_location_and_room);
    label_100D_E06C_1E13C_38658:
        CheckExternalEvents(cs1, 0xE06C);
        // 100D:E06C cmp BP,0x201A
        Alu16.Sub(BP, (ushort)0x201A);
        // 100D:E070 pop BP
        BP = Stack.Pop16();
        // 100D:E071 jne short 0xE0A1
        if (!ZeroFlag)
        {
            goto label_100D_E0A1_1E171_38662;
        }
    label_100D_E073_1E143_38664:
        CheckExternalEvents(cs1, 0xE073);
        VerifySpeculativeEntryOrFail(cs1, 0xE073, [(byte)0xBF, (byte)0xE9, (byte)0x28]);
        // 100D:E073 mov DI,0x28E9
        DI = (ushort)0x28E9;
    label_100D_E076_1E146_38666:
        CheckExternalEvents(cs1, 0xE076);
        VerifySpeculativeEntryOrFail(cs1, 0xE076, [(byte)0x8B, (byte)0x75, (byte)0x02]);
        // 100D:E076 mov SI,word ptr DS:[DI+2]
        SI = UInt16[DS, (ushort)(DI + (sbyte)2)];
        VerifySpeculativeEntryOrFail(cs1, 0xE079, [(byte)0x8B, (byte)0x05]);
        // 100D:E079 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        VerifySpeculativeEntryOrFail(cs1, 0xE07B, [(byte)0x3B, (byte)0xC2]);
        // 100D:E07B cmp AX,DX
        Alu16.Sub(AX, DX);
        VerifySpeculativeEntryOrFail(cs1, 0xE07D, [(byte)0x75, (byte)0x04]);
        // 100D:E07D jne short 0xE083
        if (!ZeroFlag)
        {
            goto label_100D_E083_1E153_38670;
        }
    label_100D_E07F_1E14F_38672:
        CheckExternalEvents(cs1, 0xE07F);
        VerifySpeculativeEntryOrFail(cs1, 0xE07F, [(byte)0x3B, (byte)0xF3]);
        // 100D:E07F cmp SI,BX
        Alu16.Sub(SI, BX);
        VerifySpeculativeEntryOrFail(cs1, 0xE081, [(byte)0x74, (byte)0x16]);
        // 100D:E081 je short 0xE099
        if (ZeroFlag)
        {
            goto label_100D_E099_1E169_38675;
        }
    label_100D_E083_1E153_38670:
        CheckExternalEvents(cs1, 0xE083);
        VerifySpeculativeEntryOrFail(cs1, 0xE083, [(byte)0xFF, (byte)0x56, (byte)0x00]);
        // 100D:E083 call near word ptr SS:[BP]
        throw FailAsUntested("Indirect call at 100D:E083 has no observed targets.");
    label_100D_E099_1E169_38675:
        CheckExternalEvents(cs1, 0xE099);
        VerifySpeculativeEntryOrFail(cs1, 0xE099, [(byte)0x83, (byte)0xC7, (byte)0x04]);
        // 100D:E099 add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        VerifySpeculativeEntryOrFail(cs1, 0xE09C, [(byte)0x83, (byte)0x3D, (byte)0xFF]);
        // 100D:E09C cmp word ptr DS:[DI],-1
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        VerifySpeculativeEntryOrFail(cs1, 0xE09F, [(byte)0x75, (byte)0xD5]);
        // 100D:E09F jne short 0xE076
        if (!ZeroFlag)
        {
            goto label_100D_E076_1E146_38666;
        }
    label_100D_E0A1_1E171_38662:
        CheckExternalEvents(cs1, 0xE0A1);
        // 100D:E0A1 ret near
        return NearRet((ushort)0x0000);
    }
}
