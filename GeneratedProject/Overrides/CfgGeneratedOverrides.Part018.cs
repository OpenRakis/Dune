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
    public virtual Action compress_sav(int loadOffset)
    {
    label_100D_B4EA_1B5BA_13115:
        CheckExternalEvents(cs1, 0xB4EA);
        // 100D:B4EA mov DL,0xF7
        DL = (byte)0xF7;
        // 100D:B4EC push DI
        Stack.Push16(DI);
        // 100D:B4ED add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
    label_100D_B4F0_1B5C0_13119:
        CheckExternalEvents(cs1, 0xB4F0);
        // 100D:B4F0 xor DH,DH
        DH = Alu8.Xor(DH, DH);
    label_100D_B4F2_1B5C2_13120:
        CheckExternalEvents(cs1, 0xB4F2);
        // 100D:B4F2 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:B4F3 inc DH
        DH = Alu8.Inc(DH);
        // 100D:B4F5 cmp AL,byte ptr DS:[SI]
        Alu8.Sub(AL, UInt8[DS, SI]);
        // 100D:B4F7 jne short 0xB504
        if (!ZeroFlag)
        {
            goto label_100D_B504_1B5D4_13132;
        }
    label_100D_B4F9_1B5C9_13124:
        CheckExternalEvents(cs1, 0xB4F9);
        // 100D:B4F9 cmp DH,0xFF
        Alu8.Sub(DH, (byte)0xFF);
        // 100D:B4FC je short 0xB504
        if (ZeroFlag)
        {
            goto label_100D_B504_1B5D4_13132;
        }
    label_100D_B4FE_1B5CE_13127:
        CheckExternalEvents(cs1, 0xB4FE);
        // 100D:B4FE dec CX
        CX = Alu16.Dec(CX);
        // 100D:B4FF or CX,CX
        CX = Alu16.Or(CX, CX);
        // 100D:B501 jne short 0xB4F2
        if (!ZeroFlag)
        {
            goto label_100D_B4F2_1B5C2_13120;
        }
    label_100D_B503_1B5D3_19464:
        CheckExternalEvents(cs1, 0xB503);
        // 100D:B503 inc CX
        CX = Alu16.Inc(CX);
    label_100D_B504_1B5D4_13132:
        CheckExternalEvents(cs1, 0xB504);
        // 100D:B504 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 100D:B506 je short 0xB512
        if (ZeroFlag)
        {
            goto label_100D_B512_1B5E2_13141;
        }
    label_100D_B508_1B5D8_13135:
        CheckExternalEvents(cs1, 0xB508);
        // 100D:B508 cmp DH,1
        Alu8.Sub(DH, (byte)0x01);
        // 100D:B50B je short 0xB51C
        if (ZeroFlag)
        {
            goto label_100D_B51C_1B5EC_13148;
        }
    label_100D_B50D_1B5DD_13138:
        CheckExternalEvents(cs1, 0xB50D);
        // 100D:B50D cmp DH,2
        Alu8.Sub(DH, (byte)0x02);
        // 100D:B510 je short 0xB52F
        if (ZeroFlag)
        {
            goto label_100D_B52F_1B5FF_13152;
        }
    label_100D_B512_1B5E2_13141:
        CheckExternalEvents(cs1, 0xB512);
        // 100D:B512 mov AH,AL
        AH = AL;
        // 100D:B514 mov AL,DL
        AL = DL;
        // 100D:B516 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B517 mov AL,DH
        AL = DH;
        // 100D:B519 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B51A mov AL,AH
        AL = AH;
    label_100D_B51C_1B5EC_13148:
        CheckExternalEvents(cs1, 0xB51C);
        // 100D:B51C stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B51D loop 0xB4F0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B4F0_1B5C0_13119;
        }
    label_100D_B51F_1B5EF_13155:
        CheckExternalEvents(cs1, 0xB51F);
        // 100D:B51F mov CX,DI
        CX = DI;
        // 100D:B521 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:B523 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:B524 pop DI
        DI = Stack.Pop16();
        // 100D:B525 sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 100D:B527 mov word ptr ES:[DI],DX
        UInt16[ES, DI] = DX;
        // 100D:B52A mov word ptr ES:[DI+2],CX
        UInt16[ES, (ushort)(DI + (sbyte)2)] = CX;
        // 100D:B52E ret near
        return NearRet((ushort)0x0000);
    label_100D_B52F_1B5FF_13152:
        CheckExternalEvents(cs1, 0xB52F);
        // 100D:B52F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:B530 jmp short 0xB51C
        goto label_100D_B51C_1B5EC_13148;
    }

    public virtual Action read_map_byte(int loadOffset)
    {
    label_100D_B532_1B602_20517:
        CheckExternalEvents(cs1, 0xB532);
        // 100D:B532 push DX
        Stack.Push16(DX);
        // 100D:B533 call near 0xB58B
        NearCall(cs1, 0xB536, map_position_to_offset);
    label_100D_B536_1B606_20520:
        CheckExternalEvents(cs1, 0xB536);
        // 100D:B536 pop DX
        DX = Stack.Pop16();
        // 100D:B537 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:B53A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B53B_1B60B(int loadOffset)
    {
    label_100D_B53B_1B60B_22288:
        CheckExternalEvents(cs1, 0xB53B);
        // 100D:B53B push BX
        Stack.Push16(BX);
        // 100D:B53C push CX
        Stack.Push16(CX);
        // 100D:B53D push DX
        Stack.Push16(DX);
        // 100D:B53E push AX
        Stack.Push16(AX);
        // 100D:B53F call near 0xB58B
        NearCall(cs1, 0xB542, map_position_to_offset);
    label_100D_B542_1B612_22294:
        CheckExternalEvents(cs1, 0xB542);
        // 100D:B542 pop AX
        AX = Stack.Pop16();
        // 100D:B543 mov CX,AX
        CX = AX;
        // 100D:B545 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B547 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 100D:B549 sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:B54B jae short 0xB551
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:B54B");
        }
    label_100D_B551_1B621_22301:
        CheckExternalEvents(cs1, 0xB551);
        // 100D:B551 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:B554 mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 100D:B556 mov word ptr DS:[SI+1],DI
        UInt16[DS, (ushort)(SI + (sbyte)1)] = DI;
        // 100D:B559 add SI,3
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:B55C inc DI
        DI = Alu16.Inc(DI);
        // 100D:B55D inc DX
        DX = Alu16.Inc(DX);
        // 100D:B55E cmp DX,BP
        Alu16.Sub(DX, BP);
        // 100D:B560 jb short 0xB566
        if (CarryFlag)
        {
            goto label_100D_B566_1B636_22310;
        }
    label_100D_B562_1B632_38317:
        CheckExternalEvents(cs1, 0xB562);
        // 100D:B562 sub DX,BP
        DX = Alu16.Sub(DX, BP);
        // 100D:B564 sub DI,BP
        DI = Alu16.Sub(DI, BP);
    label_100D_B566_1B636_22310:
        CheckExternalEvents(cs1, 0xB566);
        // 100D:B566 loop 0xB551
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B551_1B621_22301;
        }
    label_100D_B568_1B638_22312:
        CheckExternalEvents(cs1, 0xB568);
        // 100D:B568 pop DX
        DX = Stack.Pop16();
        // 100D:B569 pop CX
        CX = Stack.Pop16();
        // 100D:B56A pop BX
        BX = Stack.Pop16();
        // 100D:B56B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_build_cell_strip(int loadOffset)
    {
    label_100D_B56C_1B63C_22277:
        CheckExternalEvents(cs1, 0xB56C);
        // 100D:B56C push CX
        Stack.Push16(CX);
        // 100D:B56D mov SI,CX
        SI = CX;
        // 100D:B56F shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 100D:B571 sub BX,SI
        BX = Alu16.Sub(BX, SI);
        // 100D:B573 cmp BX,-98
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-98)));
        // 100D:B576 jge short 0xB57B
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:B576");
        }
    label_100D_B57B_1B64B_22284:
        CheckExternalEvents(cs1, 0xB57B);
        // 100D:B57B mov SI,0x9E68
        SI = (ushort)0x9E68;
    label_100D_B57E_1B64E_22286:
        CheckExternalEvents(cs1, 0xB57E);
        // 100D:B57E push AX
        Stack.Push16(AX);
        // 100D:B57F call near 0xB53B
        NearCall(cs1, 0xB582, unknown_100D_B53B_1B60B);
    label_100D_B582_1B652_22317:
        CheckExternalEvents(cs1, 0xB582);
        // 100D:B582 pop AX
        AX = Stack.Pop16();
        // 100D:B583 inc BX
        BX = Alu16.Inc(BX);
        // 100D:B584 loop 0xB57E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B57E_1B64E_22286;
        }
    label_100D_B586_1B656_22321:
        CheckExternalEvents(cs1, 0xB586);
        // 100D:B586 mov SI,0x9E68
        SI = (ushort)0x9E68;
        // 100D:B589 pop CX
        CX = Stack.Pop16();
        // 100D:B58A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_position_to_offset(int loadOffset)
    {
    label_100D_B58B_1B65B_3012:
        CheckExternalEvents(cs1, 0xB58B);
        // 100D:B58B call near 0xB5A0
        NearCall(cs1, 0xB58E, unknown_100D_B5A0_1B670);
    label_100D_B58E_1B65E_3028:
        CheckExternalEvents(cs1, 0xB58E);
        // 100D:B58E les DI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_B58E_1B65E = (ushort)0xDCFE;
        ushort lxsValue_100D_B58E_1B65E = UInt16[DS, lxsOffset_100D_B58E_1B65E];
        ushort lxsSegment_100D_B58E_1B65E = UInt16[DS, (ushort)(lxsOffset_100D_B58E_1B65E + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_B58E_1B65E);
        ES = unchecked((ushort)lxsSegment_100D_B58E_1B65E);
        // 100D:B592 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:B594 mov AX,BP
        AX = BP;
        // 100D:B596 mul DX
        uint result_100D_B596_1B666 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_B596_1B666 >> 16));
        AX = unchecked((ushort)result_100D_B596_1B666);
        // 100D:B598 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B59A adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:B59D add DI,DX
        DI = Alu16.Add(DI, DX);
        // 100D:B59F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B5A0_1B670(int loadOffset)
    {
    label_100D_B5A0_1B670_3014:
        CheckExternalEvents(cs1, 0xB5A0);
        // 100D:B5A0 push BX
        Stack.Push16(BX);
        // 100D:B5A1 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:B5A3 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:B5A5 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:B5A7 jns short 0xB5B9
        if (!SignFlag)
        {
            goto label_100D_B5B9_1B689_3060;
        }
    label_100D_B5A9_1B679_3020:
        CheckExternalEvents(cs1, 0xB5A9);
        // 100D:B5A9 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:B5AB mov AX,word ptr DS:[BX+0x4948]
        AX = UInt16[DS, (ushort)(BX + (short)18760)];
        // 100D:B5AF neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:B5B1 mov BP,word ptr DS:[BX+0x494A]
        BP = UInt16[DS, (ushort)(BX + (short)18762)];
        // 100D:B5B5 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B5B7 pop BX
        BX = Stack.Pop16();
        // 100D:B5B8 ret near
        return NearRet((ushort)0x0000);
    label_100D_B5B9_1B689_3060:
        CheckExternalEvents(cs1, 0xB5B9);
        // 100D:B5B9 mov AX,word ptr DS:[BX+0x4948]
        AX = UInt16[DS, (ushort)(BX + (short)18760)];
        // 100D:B5BD mov BP,word ptr DS:[BX+0x494A]
        BP = UInt16[DS, (ushort)(BX + (short)18762)];
        // 100D:B5C1 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B5C3 pop BX
        BX = Stack.Pop16();
        // 100D:B5C4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_offset_and_snap_x(int loadOffset)
    {
    label_100D_B5C5_1B695_3010:
        CheckExternalEvents(cs1, 0xB5C5);
        // 100D:B5C5 call near 0xB58B
        NearCall(cs1, 0xB5C8, map_position_to_offset);
    label_100D_B5C8_1B698_3037:
        CheckExternalEvents(cs1, 0xB5C8);
        // 100D:B5C8 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:B5CA div BP
        ushort divisor_100D_B5CA_1B69A = BP;
        uint dividend_100D_B5CA_1B69A = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_B5CA_1B69A = Alu16.Div(unchecked((uint)dividend_100D_B5CA_1B69A), unchecked((ushort)divisor_100D_B5CA_1B69A));
        AX = unchecked((ushort)quotient_100D_B5CA_1B69A);
        DX = unchecked((ushort)(dividend_100D_B5CA_1B69A % unchecked((uint)divisor_100D_B5CA_1B69A)));
        // 100D:B5CC mov DX,AX
        DX = AX;
        // 100D:B5CE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action desert_apply_step_delta(int loadOffset)
    {
    label_100D_B5CF_1B69F_27850:
        CheckExternalEvents(cs1, 0xB5CF);
        // 100D:B5CF or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:B5D1 je short 0xB5F5
        if (ZeroFlag)
        {
            goto label_100D_B5F5_1B6C5_27858;
        }
    label_100D_B5D3_1B6A3_27853:
        CheckExternalEvents(cs1, 0xB5D3);
        // 100D:B5D3 js short 0xB5E6
        if (SignFlag)
        {
            goto label_100D_B5E6_1B6B6_28096;
        }
    label_100D_B5D5_1B6A5_27855:
        CheckExternalEvents(cs1, 0xB5D5);
        // 100D:B5D5 add BH,AH
        BH = Alu8.Add(BH, AH);
        // 100D:B5D7 jae short 0xB5F5
        if (!CarryFlag)
        {
            goto label_100D_B5F5_1B6C5_27858;
        }
    label_100D_B5D9_1B6A9_38024:
        CheckExternalEvents(cs1, 0xB5D9);
        // 100D:B5D9 inc BL
        BL = Alu8.Inc(BL);
        // 100D:B5DB cmp BL,0x62
        Alu8.Sub(BL, (byte)0x62);
        // 100D:B5DE jl short 0xB5F5
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_B5F5_1B6C5_27858;
        }
    label_100D_B5E0_1B6B0_38029:
        CheckExternalEvents(cs1, 0xB5E0);
        VerifySpeculativeEntryOrFail(cs1, 0xB5E0, [(byte)0xFE, (byte)0xCB]);
        // 100D:B5E0 dec BL
        BL = Alu8.Dec(BL);
        VerifySpeculativeEntryOrFail(cs1, 0xB5E2, [(byte)0x2A, (byte)0xFC]);
        // 100D:B5E2 sub BH,AH
        BH = Alu8.Sub(BH, AH);
        VerifySpeculativeEntryOrFail(cs1, 0xB5E4, [(byte)0xEB, (byte)0x0F]);
        // 100D:B5E4 jmp short 0xB5F5
        goto label_100D_B5F5_1B6C5_27858;
    label_100D_B5E6_1B6B6_28096:
        CheckExternalEvents(cs1, 0xB5E6);
        // 100D:B5E6 add BH,AH
        BH = Alu8.Add(BH, AH);
        // 100D:B5E8 jb short 0xB5F5
        if (CarryFlag)
        {
            goto label_100D_B5F5_1B6C5_27858;
        }
    label_100D_B5EA_1B6BA_38013:
        CheckExternalEvents(cs1, 0xB5EA);
        // 100D:B5EA dec BL
        BL = Alu8.Dec(BL);
        // 100D:B5EC cmp BL,0x9E
        Alu8.Sub(BL, (byte)0x9E);
        // 100D:B5EF jg short 0xB5F5
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_B5F5_1B6C5_27858;
        }
    label_100D_B5F1_1B6C1_38018:
        CheckExternalEvents(cs1, 0xB5F1);
        VerifySpeculativeEntryOrFail(cs1, 0xB5F1, [(byte)0xFE, (byte)0xC3]);
        // 100D:B5F1 inc BL
        BL = Alu8.Inc(BL);
        VerifySpeculativeEntryOrFail(cs1, 0xB5F3, [(byte)0x2A, (byte)0xFC]);
        // 100D:B5F3 sub BH,AH
        BH = Alu8.Sub(BH, AH);
    label_100D_B5F5_1B6C5_27858:
        CheckExternalEvents(cs1, 0xB5F5);
        // 100D:B5F5 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:B5F6 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:B5F8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_screen_to_position(int loadOffset)
    {
    label_100D_B5F9_1B6C9_27022:
        CheckExternalEvents(cs1, 0xB5F9);
        // 100D:B5F9 sub DX,word ptr DS:[0xDCF6]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0xDCF6]);
        // 100D:B5FD sub BX,word ptr DS:[0xDCF8]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0xDCF8]);
        // 100D:B601 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:B603 test byte ptr DS:[0x46EB],0x80
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:B608 je short 0xB60C
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:B608");
        }
    label_100D_B60C_1B6DC_27028:
        CheckExternalEvents(cs1, 0xB60C);
        // 100D:B60C sar BX,CL
        BX = Alu16.Sar(BX, unchecked((int)CL));
        // 100D:B60E add BX,word ptr DS:[0x197E]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x197E]);
        // 100D:B612 mov AX,BX
        AX = BX;
        // 100D:B614 jns short 0xB618
        if (!SignFlag)
        {
            goto label_100D_B618_1B6E8_27033;
        }
    label_100D_B616_1B6E6_30895:
        CheckExternalEvents(cs1, 0xB616);
        // 100D:B616 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_B618_1B6E8_27033:
        CheckExternalEvents(cs1, 0xB618);
        // 100D:B618 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B61A shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B61C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B61E mov SI,0x4948
        SI = (ushort)0x4948;
        // 100D:B621 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:B623 jcxz short 0xB62C
        if (!(CX == (ushort)0x0000))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:B623");
        }
    label_100D_B62C_1B6FC_27040:
        CheckExternalEvents(cs1, 0xB62C);
        // 100D:B62C add DX,word ptr DS:[SI+6]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:B62F mov CX,word ptr DS:[SI+2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:B632 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:B634 cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:B636 jb short 0xB640
        if (CarryFlag)
        {
            goto label_100D_B640_1B710_27046;
        }
    label_100D_B638_1B708_37352:
        CheckExternalEvents(cs1, 0xB638);
        // 100D:B638 js short 0xB63E
        if (SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:B638");
        }
    label_100D_B63A_1B70A_37354:
        CheckExternalEvents(cs1, 0xB63A);
        // 100D:B63A sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:B63C jmp short 0xB640
    label_100D_B640_1B710_27046:
        CheckExternalEvents(cs1, 0xB640);
        // 100D:B640 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:B642 div CX
        ushort divisor_100D_B642_1B712 = CX;
        uint dividend_100D_B642_1B712 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_B642_1B712 = Alu16.Div(unchecked((uint)dividend_100D_B642_1B712), unchecked((ushort)divisor_100D_B642_1B712));
        AX = unchecked((ushort)quotient_100D_B642_1B712);
        DX = unchecked((ushort)(dividend_100D_B642_1B712 % unchecked((uint)divisor_100D_B642_1B712)));
        // 100D:B644 mov DX,AX
        DX = AX;
        // 100D:B646 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_position_to_screen(int loadOffset)
    {
    label_100D_B647_1B717_17970:
        CheckExternalEvents(cs1, 0xB647);
        // 100D:B647 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:B649 test byte ptr DS:[0x46EB],0x80
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:B64E je short 0xB652
        if (ZeroFlag)
        {
            goto label_100D_B652_1B722_17976;
        }
    label_100D_B650_1B720_17974:
        CheckExternalEvents(cs1, 0xB650);
        // 100D:B650 mov CL,2
        CL = (byte)0x02;
    label_100D_B652_1B722_17976:
        CheckExternalEvents(cs1, 0xB652);
        // 100D:B652 mov BP,BX
        BP = BX;
        // 100D:B654 sub BX,word ptr DS:[0x197E]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0x197E]);
        // 100D:B658 shl BX,CL
        BX = Alu16.Shl(BX, unchecked((int)CL));
        // 100D:B65A add BX,word ptr DS:[0xDCF8]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0xDCF8]);
        // 100D:B65E shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B660 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B662 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:B664 jns short 0xB668
        if (!SignFlag)
        {
            goto label_100D_B668_1B738_17986;
        }
    label_100D_B666_1B736_17984:
        CheckExternalEvents(cs1, 0xB666);
        // 100D:B666 neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_B668_1B738_17986:
        CheckExternalEvents(cs1, 0xB668);
        // 100D:B668 mov BP,word ptr SS:[BP+0x494A]
        BP = UInt16[SS, (ushort)(BP + (short)18762)];
        // 100D:B66C add BP,BP
        BP = Alu16.Add(BP, BP);
        // 100D:B66E sub DX,word ptr DS:[0x197C]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0x197C]);
        // 100D:B672 mov AX,DX
        AX = DX;
        // 100D:B674 imul BP
        int result_100D_B674_1B744 = Alu16.Imul(unchecked((short)AX), unchecked((short)BP));
        DX = unchecked((ushort)(result_100D_B674_1B744 >> 16));
        AX = unchecked((ushort)result_100D_B674_1B744);
        // 100D:B676 jcxz short 0xB67E
        if (CX == (ushort)0x0000)
        {
            goto label_100D_B67E_1B74E_17996;
        }
    label_100D_B678_1B748_17992:
        CheckExternalEvents(cs1, 0xB678);
        // 100D:B678 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B67A rcl DX,1
        DX = Alu16.Rcl(DX, unchecked((byte)1));
        // 100D:B67C loop 0xB678
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B678_1B748_17992;
        }
    label_100D_B67E_1B74E_17996:
        CheckExternalEvents(cs1, 0xB67E);
        // 100D:B67E add DX,word ptr DS:[0xDCF6]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0xDCF6]);
        // 100D:B682 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B683_1B753(int loadOffset)
    {
    label_100D_B683_1B753_19508:
        CheckExternalEvents(cs1, 0xB683);
        // 100D:B683 js short 0xB68B
        if (SignFlag)
        {
            goto label_100D_B68B_1B75B_19510;
        }
    label_100D_B685_1B755_34934:
        CheckExternalEvents(cs1, 0xB685);
        // 100D:B685 sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:B687 neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
        // 100D:B689 jmp short 0xB68F
        goto label_100D_B68F_1B75F_19513;
    label_100D_B68B_1B75B_19510:
        CheckExternalEvents(cs1, 0xB68B);
        // 100D:B68B xchg DX,BP
        ushort temp_100D_B68B_1B75B = DX;
        DX = BP;
        BP = unchecked((ushort)temp_100D_B68B_1B75B);
        // 100D:B68D add DX,BP
        DX = Alu16.Add(DX, BP);
    label_100D_B68F_1B75F_19513:
        CheckExternalEvents(cs1, 0xB68F);
        // 100D:B68F mov CX,BP
        CX = BP;
        // 100D:B691 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:B693 cmp CX,DX
        Alu16.Sub(CX, DX);
        // 100D:B695 jae short 0xB699
        if (!CarryFlag)
        {
            goto label_100D_B699_1B769_19519;
        }
    label_100D_B697_1B767_19517:
        CheckExternalEvents(cs1, 0xB697);
        // 100D:B697 mov DX,BP
        DX = BP;
    label_100D_B699_1B769_19519:
        CheckExternalEvents(cs1, 0xB699);
        // 100D:B699 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_overlay_swap_position(int loadOffset)
    {
    label_100D_B69A_1B76A_28513:
        CheckExternalEvents(cs1, 0xB69A);
        // 100D:B69A mov AX,word ptr DS:[0x197C]
        AX = UInt16[DS, (ushort)0x197C];
        // 100D:B69D xchg AX,word ptr DS:[0x1980]
        ushort xchgOffset_100D_B69D_1B76D = (ushort)0x1980;
        ushort temp_100D_B69D_1B76D = AX;
        AX = UInt16[DS, xchgOffset_100D_B69D_1B76D];
        UInt16[DS, xchgOffset_100D_B69D_1B76D] = unchecked((ushort)temp_100D_B69D_1B76D);
        // 100D:B6A1 mov word ptr DS:[0x197C],AX
        UInt16[DS, (ushort)0x197C] = AX;
        // 100D:B6A4 mov AX,word ptr DS:[0x197E]
        AX = UInt16[DS, (ushort)0x197E];
        // 100D:B6A7 xchg AX,word ptr DS:[0x1982]
        ushort xchgOffset_100D_B6A7_1B777 = (ushort)0x1982;
        ushort temp_100D_B6A7_1B777 = AX;
        AX = UInt16[DS, xchgOffset_100D_B6A7_1B777];
        UInt16[DS, xchgOffset_100D_B6A7_1B777] = unchecked((ushort)temp_100D_B6A7_1B777);
        // 100D:B6AB mov word ptr DS:[0x197E],AX
        UInt16[DS, (ushort)0x197E] = AX;
        // 100D:B6AE mov AX,word ptr DS:[0xDCF6]
        AX = UInt16[DS, (ushort)0xDCF6];
        // 100D:B6B1 xchg AX,word ptr DS:[0xDCFA]
        ushort xchgOffset_100D_B6B1_1B781 = (ushort)0xDCFA;
        ushort temp_100D_B6B1_1B781 = AX;
        AX = UInt16[DS, xchgOffset_100D_B6B1_1B781];
        UInt16[DS, xchgOffset_100D_B6B1_1B781] = unchecked((ushort)temp_100D_B6B1_1B781);
        // 100D:B6B5 mov word ptr DS:[0xDCF6],AX
        UInt16[DS, (ushort)0xDCF6] = AX;
        // 100D:B6B8 mov AX,word ptr DS:[0xDCF8]
        AX = UInt16[DS, (ushort)0xDCF8];
        // 100D:B6BB xchg AX,word ptr DS:[0xDCFC]
        ushort xchgOffset_100D_B6BB_1B78B = (ushort)0xDCFC;
        ushort temp_100D_B6BB_1B78B = AX;
        AX = UInt16[DS, xchgOffset_100D_B6BB_1B78B];
        UInt16[DS, xchgOffset_100D_B6BB_1B78B] = unchecked((ushort)temp_100D_B6BB_1B78B);
        // 100D:B6BF mov word ptr DS:[0xDCF8],AX
        UInt16[DS, (ushort)0xDCF8] = AX;
        // 100D:B6C2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_draw_zoomed_globe(int loadOffset)
    {
    label_100D_B6C3_1B793_17517:
        CheckExternalEvents(cs1, 0xB6C3);
        // 100D:B6C3 test byte ptr DS:[0x46EB],0x80
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:B6C8 je short 0xB714
        if (ZeroFlag)
        {
            goto label_100D_B714_1B7E4_20772;
        }
    label_100D_B6CA_1B79A_17520:
        CheckExternalEvents(cs1, 0xB6CA);
        // 100D:B6CA push DS
        Stack.Push16(DS);
        // 100D:B6CB pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B6CC mov word ptr DS:[0xDCF6],0x00A0
        UInt16[DS, (ushort)0xDCF6] = (ushort)0x00A0;
        // 100D:B6D2 mov word ptr DS:[0xDCF8],0x004C
        UInt16[DS, (ushort)0xDCF8] = (ushort)0x004C;
        // 100D:B6D8 mov CX,0x0012
        CX = (ushort)0x0012;
        // 100D:B6DB mov BX,0x004B
        BX = (ushort)0x004B;
        // 100D:B6DE mov AX,word ptr DS:[0x197E]
        AX = UInt16[DS, (ushort)0x197E];
        // 100D:B6E1 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:B6E3 mov DX,AX
        DX = AX;
        // 100D:B6E5 jns short 0xB6E9
        if (!SignFlag)
        {
            goto label_100D_B6E9_1B7B9_17533;
        }
    label_100D_B6E7_1B7B7_17531:
        CheckExternalEvents(cs1, 0xB6E7);
        // 100D:B6E7 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_B6E9_1B7B9_17533:
        CheckExternalEvents(cs1, 0xB6E9);
        // 100D:B6E9 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:B6EB jb short 0xB6F8
        if (CarryFlag)
        {
            goto label_100D_B6F8_1B7C8_17535;
        }
    label_100D_B6ED_1B7BD_36764:
        CheckExternalEvents(cs1, 0xB6ED);
        // 100D:B6ED mov AX,BX
        AX = BX;
        // 100D:B6EF or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:B6F1 jns short 0xB6F5
        if (!SignFlag)
        {
            goto label_100D_B6F5_1B7C5_36768;
        }
    label_100D_B6F3_1B7C3_36912:
        CheckExternalEvents(cs1, 0xB6F3);
        // 100D:B6F3 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_B6F5_1B7C5_36768:
        CheckExternalEvents(cs1, 0xB6F5);
        // 100D:B6F5 mov word ptr DS:[0x197E],AX
        UInt16[DS, (ushort)0x197E] = AX;
    label_100D_B6F8_1B7C8_17535:
        CheckExternalEvents(cs1, 0xB6F8);
        // 100D:B6F8 mov BP,0x4948
        BP = (ushort)0x4948;
        // 100D:B6FB mov DX,word ptr DS:[0x197C]
        DX = UInt16[DS, (ushort)0x197C];
        // 100D:B6FF mov AX,word ptr DS:[0x197E]
        AX = UInt16[DS, (ushort)0x197E];
        // 100D:B702 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:B704 les DI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_B704_1B7D4 = (ushort)0xDCFE;
        ushort lxsValue_100D_B704_1B7D4 = UInt16[DS, lxsOffset_100D_B704_1B7D4];
        ushort lxsSegment_100D_B704_1B7D4 = UInt16[DS, (ushort)(lxsOffset_100D_B704_1B7D4 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_B704_1B7D4);
        ES = unchecked((ushort)lxsSegment_100D_B704_1B7D4);
        // 100D:B708 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:B70B mov BX,word ptr DS:[0xDBDA]
        BX = UInt16[DS, (ushort)0xDBDA];
        // 100D:B70F call far dword ptr DS:[0x3929]
        ushort targetSegment_17543 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3929 + (ushort)0x0002)]));
        ushort targetOffset_17543 = unchecked((ushort)(UInt16[DS, (ushort)0x3929]));
        if (targetSegment_17543 == cs2 && targetOffset_17543 == 0x0157)
        {
            FarCall(cs1, 0xB713, cs2, unknown_3358_0157_336D7);
            goto label_100D_B713_1B7E3_17945;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_17543:X4}:{targetOffset_17543:X4} at 100D:B70F");
    label_100D_B713_1B7E3_17945:
        CheckExternalEvents(cs1, 0xB713);
        // 100D:B713 ret near
        return NearRet((ushort)0x0000);
    label_100D_B714_1B7E4_20772:
        CheckExternalEvents(cs1, 0xB714);
        // 100D:B714 mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:B717 mov AX,word ptr DS:[0x46E7]
        AX = UInt16[DS, (ushort)0x46E7];
        // 100D:B71A sub AX,word ptr DS:[0x46E3]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x46E3]);
        // 100D:B71E mov DX,AX
        DX = AX;
        // 100D:B720 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:B722 add DX,word ptr DS:[0x46E3]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x46E3]);
        // 100D:B726 mov word ptr DS:[0xDCF6],DX
        UInt16[DS, (ushort)0xDCF6] = DX;
        // 100D:B72A mov word ptr DS:[0xDCF2],AX
        UInt16[DS, (ushort)0xDCF2] = AX;
        // 100D:B72D mov AX,word ptr DS:[0x46E9]
        AX = UInt16[DS, (ushort)0x46E9];
        // 100D:B730 sub AX,word ptr DS:[0x46E5]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x46E5]);
        // 100D:B734 dec AX
        AX = Alu16.Dec(AX);
        // 100D:B735 mov BX,AX
        BX = AX;
        // 100D:B737 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:B739 add BX,word ptr DS:[0x46E5]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x46E5]);
        // 100D:B73D mov word ptr DS:[0xDCF8],BX
        UInt16[DS, (ushort)0xDCF8] = BX;
        // 100D:B741 inc AX
        AX = Alu16.Inc(AX);
        // 100D:B742 mov word ptr DS:[0xDCF4],AX
        UInt16[DS, (ushort)0xDCF4] = AX;
        // 100D:B745 dec AX
        AX = Alu16.Dec(AX);
        // 100D:B746 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B748 mov CX,AX
        CX = AX;
        // 100D:B74A mov BX,0x0056
        BX = (ushort)0x0056;
        // 100D:B74D sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:B74F mov AX,word ptr DS:[0x197E]
        AX = UInt16[DS, (ushort)0x197E];
        // 100D:B752 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:B754 mov DX,AX
        DX = AX;
        // 100D:B756 jns short 0xB75A
        if (!SignFlag)
        {
            goto label_100D_B75A_1B82A_20801;
        }
    label_100D_B758_1B828_20799:
        CheckExternalEvents(cs1, 0xB758);
        // 100D:B758 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_B75A_1B82A_20801:
        CheckExternalEvents(cs1, 0xB75A);
        // 100D:B75A cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:B75C jb short 0xB769
        if (CarryFlag)
        {
            goto label_100D_B769_1B839_20803;
        }
    label_100D_B75E_1B82E_33642:
        CheckExternalEvents(cs1, 0xB75E);
        // 100D:B75E mov AX,BX
        AX = BX;
        // 100D:B760 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:B762 jns short 0xB766
        if (!SignFlag)
        {
            goto label_100D_B766_1B836_33648;
        }
    label_100D_B764_1B834_33646:
        CheckExternalEvents(cs1, 0xB764);
        // 100D:B764 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_B766_1B836_33648:
        CheckExternalEvents(cs1, 0xB766);
        // 100D:B766 mov word ptr DS:[0x197E],AX
        UInt16[DS, (ushort)0x197E] = AX;
    label_100D_B769_1B839_20803:
        CheckExternalEvents(cs1, 0xB769);
        // 100D:B769 mov BP,0x4948
        BP = (ushort)0x4948;
        // 100D:B76C mov DX,word ptr DS:[0x197C]
        DX = UInt16[DS, (ushort)0x197C];
        // 100D:B770 mov AX,word ptr DS:[0x197E]
        AX = UInt16[DS, (ushort)0x197E];
        // 100D:B773 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:B775 push AX
        Stack.Push16(AX);
        // 100D:B776 mov CX,word ptr DS:[0xDCF4]
        CX = UInt16[DS, (ushort)0xDCF4];
        // 100D:B77A shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B77C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B77E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:B780 jns short 0xB79C
        if (!SignFlag)
        {
            goto label_100D_B79C_1B86C_32059;
        }
    label_100D_B782_1B852_20814:
        CheckExternalEvents(cs1, 0xB782);
        // 100D:B782 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:B784 add BP,AX
        BP = Alu16.Add(BP, AX);
    label_100D_B786_1B856_20817:
        CheckExternalEvents(cs1, 0xB786);
        // 100D:B786 push CX
        Stack.Push16(CX);
        // 100D:B787 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:B78A mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:B78D neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:B78F je short 0xB7A5
        if (ZeroFlag)
        {
            goto label_100D_B7A5_1B875_20869;
        }
    label_100D_B791_1B861_20822:
        CheckExternalEvents(cs1, 0xB791);
        // 100D:B791 call near 0xB7D2
        NearCall(cs1, 0xB794, unknown_100D_B7D2_1B8A2);
    label_100D_B794_1B864_20864:
        CheckExternalEvents(cs1, 0xB794);
        // 100D:B794 sub BP,8
        BP = Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:B797 pop CX
        CX = Stack.Pop16();
        // 100D:B798 loop 0xB786
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B786_1B856_20817;
        }
    label_100D_B79A_1B86A_33539:
        CheckExternalEvents(cs1, 0xB79A);
        // 100D:B79A jmp short 0xB7AE
        goto label_100D_B7AE_1B87E_20879;
    label_100D_B79C_1B86C_32059:
        CheckExternalEvents(cs1, 0xB79C);
        // 100D:B79C add BP,AX
        BP = Alu16.Add(BP, AX);
    label_100D_B79E_1B86E_20875:
        CheckExternalEvents(cs1, 0xB79E);
        // 100D:B79E push CX
        Stack.Push16(CX);
        // 100D:B79F mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:B7A2 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
    label_100D_B7A5_1B875_20869:
        CheckExternalEvents(cs1, 0xB7A5);
        // 100D:B7A5 call near 0xB7D2
        NearCall(cs1, 0xB7A8, unknown_100D_B7D2_1B8A2);
    label_100D_B7A8_1B878_20871:
        CheckExternalEvents(cs1, 0xB7A8);
        // 100D:B7A8 add BP,8
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:B7AB pop CX
        CX = Stack.Pop16();
        // 100D:B7AC loop 0xB79E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_B79E_1B86E_20875;
        }
    label_100D_B7AE_1B87E_20879:
        CheckExternalEvents(cs1, 0xB7AE);
        // 100D:B7AE mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:B7B2 mov DI,word ptr DS:[0xDCF2]
        DI = UInt16[DS, (ushort)0xDCF2];
        // 100D:B7B6 mov CX,word ptr DS:[0xDCF4]
        CX = UInt16[DS, (ushort)0xDCF4];
        // 100D:B7BA mov DX,word ptr DS:[0x46E3]
        DX = UInt16[DS, (ushort)0x46E3];
        // 100D:B7BE mov BX,word ptr DS:[0x46E5]
        BX = UInt16[DS, (ushort)0x46E5];
        // 100D:B7C2 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:B7C5 pop AX
        AX = Stack.Pop16();
        // 100D:B7C6 test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:B7CB jne short 0xB7D1
        if (!ZeroFlag)
        {
            goto label_100D_B7D1_1B8A1_20966;
        }
    label_100D_B7CD_1B89D_20889:
        CheckExternalEvents(cs1, 0xB7CD);
        // 100D:B7CD call far dword ptr DS:[0x390D]
        ushort targetSegment_20889 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x390D + (ushort)0x0002)]));
        ushort targetOffset_20889 = unchecked((ushort)(UInt16[DS, (ushort)0x390D]));
        if (targetSegment_20889 == cs2 && targetOffset_20889 == 0x0142)
        {
            FarCall(cs1, 0xB7D1, cs2, unknown_3358_0142_336C2);
            goto label_100D_B7D1_1B8A1_20966;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_20889:X4}:{targetOffset_20889:X4} at 100D:B7CD");
    label_100D_B7D1_1B8A1_20966:
        CheckExternalEvents(cs1, 0xB7D1);
        // 100D:B7D1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B7D2_1B8A2(int loadOffset)
    {
    label_100D_B7D2_1B8A2_20824:
        CheckExternalEvents(cs1, 0xB7D2);
        // 100D:B7D2 push DX
        Stack.Push16(DX);
        // 100D:B7D3 push DI
        Stack.Push16(DI);
        // 100D:B7D4 push DS
        Stack.Push16(DS);
        // 100D:B7D5 lds SI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_B7D5_1B8A5 = (ushort)0xDCFE;
        ushort lxsValue_100D_B7D5_1B8A5 = UInt16[DS, lxsOffset_100D_B7D5_1B8A5];
        ushort lxsSegment_100D_B7D5_1B8A5 = UInt16[DS, (ushort)(lxsOffset_100D_B7D5_1B8A5 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_B7D5_1B8A5);
        DS = unchecked((ushort)lxsSegment_100D_B7D5_1B8A5);
        // 100D:B7D9 push SS
        Stack.Push16(SS);
        // 100D:B7DA pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B7DB add SI,CX
        SI = Alu16.Add(SI, CX);
        // 100D:B7DD add BX,BX
        BX = Alu16.Add(BX, BX);
        // 100D:B7DF mov AX,DX
        AX = DX;
        // 100D:B7E1 mul BX
        uint result_100D_B7E1_1B8B1 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)BX)));
        DX = unchecked((ushort)(result_100D_B7E1_1B8B1 >> 16));
        AX = unchecked((ushort)result_100D_B7E1_1B8B1);
        // 100D:B7E3 mov word ptr SS:[BP+6],DX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = DX;
        // 100D:B7E6 mov AX,DX
        AX = DX;
        // 100D:B7E8 mov DX,word ptr SS:[0xDCF2]
        DX = UInt16[SS, (ushort)0xDCF2];
        // 100D:B7ED cmp BX,DX
        Alu16.Sub(BX, DX);
        // 100D:B7EF jae short 0xB7FB
        if (!CarryFlag)
        {
            goto label_100D_B7FB_1B8CB_20840;
        }
    label_100D_B7F1_1B8C1_33527:
        CheckExternalEvents(cs1, 0xB7F1);
        // 100D:B7F1 mov CX,DX
        CX = DX;
        // 100D:B7F3 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 100D:B7F5 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:B7F7 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 100D:B7F9 mov DX,BX
        DX = BX;
    label_100D_B7FB_1B8CB_20840:
        CheckExternalEvents(cs1, 0xB7FB);
        // 100D:B7FB mov CX,DX
        CX = DX;
        // 100D:B7FD shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:B7FF sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:B801 jns short 0xB805
        if (!SignFlag)
        {
            goto label_100D_B805_1B8D5_20847;
        }
    label_100D_B803_1B8D3_20845:
        CheckExternalEvents(cs1, 0xB803);
        // 100D:B803 add AX,BX
        AX = Alu16.Add(AX, BX);
    label_100D_B805_1B8D5_20847:
        CheckExternalEvents(cs1, 0xB805);
        // 100D:B805 mov CX,DX
        CX = DX;
        // 100D:B807 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:B809 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 100D:B80B jns short 0xB813
        if (!SignFlag)
        {
            goto label_100D_B813_1B8E3_20851;
        }
    label_100D_B80D_1B8DD_25247:
        CheckExternalEvents(cs1, 0xB80D);
        // 100D:B80D add CX,BX
        CX = Alu16.Add(CX, BX);
        // 100D:B80F add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:B811 jmp short 0xB81D
        goto label_100D_B81D_1B8ED_20858;
    label_100D_B813_1B8E3_20851:
        CheckExternalEvents(cs1, 0xB813);
        // 100D:B813 xchg BX,CX
        ushort temp_100D_B813_1B8E3 = BX;
        BX = CX;
        CX = unchecked((ushort)temp_100D_B813_1B8E3);
        // 100D:B815 push SI
        Stack.Push16(SI);
        // 100D:B816 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:B818 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B81A pop SI
        SI = Stack.Pop16();
        // 100D:B81B xchg BX,CX
        ushort temp_100D_B81B_1B8EB = BX;
        BX = CX;
        CX = unchecked((ushort)temp_100D_B81B_1B8EB);
    label_100D_B81D_1B8ED_20858:
        CheckExternalEvents(cs1, 0xB81D);
        // 100D:B81D rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:B81F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B820 pop DI
        DI = Stack.Pop16();
        // 100D:B821 pop DX
        DX = Stack.Pop16();
        // 100D:B822 add DI,0x00C8
        DI = Alu16.Add(DI, (ushort)0x00C8);
        // 100D:B826 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_globe_and_ui_to_front_buffer(int loadOffset)
    {
    label_100D_B827_1B8F7_18549:
        CheckExternalEvents(cs1, 0xB827);
        // 100D:B827 mov byte ptr DS:[0xDD02],0
        UInt8[DS, (ushort)0xDD02] = (byte)0x00;
        // 100D:B82C call near 0xB84A
        NearCall(cs1, 0xB82F, globe_fill_blue_background_to_front_buffer);
    label_100D_B82F_1B8FF_18559:
        CheckExternalEvents(cs1, 0xB82F);
        // 100D:B82F mov word ptr DS:[0xDD0F],0
        UInt16[DS, (ushort)0xDD0F] = (ushort)0x0000;
        // 100D:B835 call near 0xB87E
        NearCall(cs1, 0xB838, draw_globe_side_decorations);
    label_100D_B838_1B908_18581:
        CheckExternalEvents(cs1, 0xB838);
        // 100D:B838 call near 0x1797
        NearCall(cs1, 0xB83B, ui_hud_head_draw);
    label_100D_B83B_1B90B_18583:
        CheckExternalEvents(cs1, 0xB83B);
        // 100D:B83B call near 0xB941
        NearCall(cs1, 0xB83E, globe_menu_push);
    label_100D_B83E_1B90E_18596:
        CheckExternalEvents(cs1, 0xB83E);
        // 100D:B83E call near 0xD7B2
        NearCall(cs1, 0xB841, ui_set_and_draw_frieze_sides_globe);
    label_100D_B841_1B911_18601:
        CheckExternalEvents(cs1, 0xB841);
        // 100D:B841 mov SI,0x1DC6
        SI = (ushort)0x1DC6;
        // 100D:B844 call near 0xD72B
        NearCall(cs1, 0xB847, ui_install_nav_panel);
    label_100D_B847_1B917_18604:
        CheckExternalEvents(cs1, 0xB847);
        // 100D:B847 jmp near 0xAD5E
        return update_room_music(0x0000);
    }

    public virtual Action globe_fill_blue_background_to_front_buffer(int loadOffset)
    {
    label_100D_B84A_1B91A_18552:
        CheckExternalEvents(cs1, 0xB84A);
        // 100D:B84A call near 0xC07C
        NearCall(cs1, 0xB84D, set_fb1_as_active_framebuffer);
    label_100D_B84D_1B91D_18554:
        CheckExternalEvents(cs1, 0xB84D);
        // 100D:B84D mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:B851 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:B854 mov AL,0xF0
        AL = (byte)0xF0;
        // 100D:B856 call far dword ptr DS:[0x38DD]
        ushort targetSegment_18558 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_18558 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_18558 == cs2 && targetOffset_18558 == 0x011E)
        {
            FarCall(cs1, 0xB85A, cs2, unknown_3358_011E_3369E);
            return draw_globe_with_atmosphere(0x0000);
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_18558:X4}:{targetOffset_18558:X4} at 100D:B856");
    }

    public virtual Action draw_globe_with_atmosphere(int loadOffset)
    {
    label_100D_B85A_1B92A_12476:
        CheckExternalEvents(cs1, 0xB85A);
        // 100D:B85A mov AX,1
        AX = (ushort)0x0001;
        // 100D:B85D call near 0xC13E
        NearCall(cs1, 0xB860, open_sprite_bank);
    label_100D_B860_1B930_12479:
        CheckExternalEvents(cs1, 0xB860);
        // 100D:B860 mov DX,0x005B
        DX = (ushort)0x005B;
        // 100D:B863 mov BX,0x0014
        BX = (ushort)0x0014;
        // 100D:B866 mov AX,2
        AX = (ushort)0x0002;
        // 100D:B869 call near 0xC22F
        NearCall(cs1, 0xB86C, draw_active_bank_sprite);
    label_100D_B86C_1B93C_12484:
        CheckExternalEvents(cs1, 0xB86C);
        // 100D:B86C mov SI,0x2448
        SI = (ushort)0x2448;
        // 100D:B86F call near 0xDAAA
        NearCall(cs1, 0xB872, set_mouse_nav_rect);
    label_100D_B872_1B942_12490:
        CheckExternalEvents(cs1, 0xB872);
        // 100D:B872 mov SI,0x2440
        SI = (ushort)0x2440;
        // 100D:B875 mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:B878 call near 0x5B99
        NearCall(cs1, 0xB87B, unknown_100D_5B99_15C69);
    label_100D_B87B_1B94B_12494:
        CheckExternalEvents(cs1, 0xB87B);
        // 100D:B87B jmp near 0xB977
        return map_func_gfx(0x0000);
    }

    public virtual Action draw_globe_side_decorations(int loadOffset)
    {
    label_100D_B87E_1B94E_18562:
        CheckExternalEvents(cs1, 0xB87E);
        // 100D:B87E call near 0x5BA8
        NearCall(cs1, 0xB881, unknown_100D_5BA8_15C78);
    label_100D_B881_1B951_18564:
        CheckExternalEvents(cs1, 0xB881);
        // 100D:B881 mov AX,1
        AX = (ushort)0x0001;
        // 100D:B884 call near 0xC13E
        NearCall(cs1, 0xB887, open_sprite_bank);
    label_100D_B887_1B957_18567:
        CheckExternalEvents(cs1, 0xB887);
        // 100D:B887 mov DX,word ptr DS:[0xDD0F]
        DX = UInt16[DS, (ushort)0xDD0F];
        // 100D:B88B xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:B88D xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:B88F call near 0xC305
        NearCall(cs1, 0xB892, draw_sprite_from_sheet_clipped);
    label_100D_B892_1B962_18572:
        CheckExternalEvents(cs1, 0xB892);
        // 100D:B892 sub DX,0x00D6
        DX = Alu16.Sub(DX, (ushort)0x00D6);
        // 100D:B896 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:B898 mov AX,1
        AX = (ushort)0x0001;
        // 100D:B89B call near 0xC30D
        NearCall(cs1, 0xB89E, unknown_100D_C30D_1C3DD);
    label_100D_B89E_1B96E_18577:
        CheckExternalEvents(cs1, 0xB89E);
        // 100D:B89E mov SI,0x2440
        SI = (ushort)0x2440;
        // 100D:B8A1 mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:B8A4 jmp near 0x5B99
        return unknown_100D_5B99_15C69(0x0000);
    }

    public virtual Action setup_globe_draw(int loadOffset)
    {
    label_100D_B8A7_1B977_12385:
        CheckExternalEvents(cs1, 0xB8A7);
        // 100D:B8A7 push DS
        Stack.Push16(DS);
        // 100D:B8A8 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:B8A9 mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:B8AC mov SI,0x0092
        SI = (ushort)0x0092;
        // 100D:B8AF call near 0xF0B9
        NearCall(cs1, 0xB8B2, bank_filename);
    label_100D_B8B2_1B982_12391:
        CheckExternalEvents(cs1, 0xB8B2);
        // 100D:B8B2 mov DX,word ptr DS:[0x197C]
        DX = UInt16[DS, (ushort)0x197C];
        // 100D:B8B6 mov BX,word ptr DS:[0x197E]
        BX = UInt16[DS, (ushort)0x197E];
        // 100D:B8BA call near 0xBA75
        NearCall(cs1, 0xB8BD, set_globe_tilt_and_rotation);
    label_100D_B8BD_1B98D_12469:
        CheckExternalEvents(cs1, 0xB8BD);
        // 100D:B8BD mov AX,1
        AX = (ushort)0x0001;
        // 100D:B8C0 call near 0xC13E
        NearCall(cs1, 0xB8C3, open_sprite_bank);
    label_100D_B8C3_1B993_12472:
        CheckExternalEvents(cs1, 0xB8C3);
        // 100D:B8C3 jmp near 0xC0F4
        return update_screen_palette(0x0000);
    }

    public virtual Action callback_main_ui_element_00(int loadOffset)
    {
    label_100D_B8C6_1B996_18537:
        CheckExternalEvents(cs1, 0xB8C6);
        // 100D:B8C6 call near 0xD2BD
        NearCall(cs1, 0xB8C9, dismiss_stacked_menus);
    label_100D_B8C9_1B999_18539:
        CheckExternalEvents(cs1, 0xB8C9);
        // 100D:B8C9 call near 0x5ADF
        NearCall(cs1, 0xB8CC, reset_room_scene_state);
    label_100D_B8CC_1B99C_18541:
        CheckExternalEvents(cs1, 0xB8CC);
        // 100D:B8CC call near 0xB8A7
        NearCall(cs1, 0xB8CF, setup_globe_draw);
    label_100D_B8CF_1B99F_18543:
        CheckExternalEvents(cs1, 0xB8CF);
        // 100D:B8CF inc byte ptr DS:[0xDD03]
        UInt8[DS, (ushort)0xDD03] = Alu8.Inc(UInt8[DS, (ushort)0xDD03]);
        // 100D:B8D3 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:B8D5 mov DX,0xFFFF
        DX = (ushort)0xFFFF;
        // 100D:B8D8 mov BP,0xB827
        BP = (ushort)0xB827;
        // 100D:B8DB call near 0xC108
        NearCall(cs1, 0xB8DE, transition);
    label_100D_B8DE_1B9AE_18664:
        CheckExternalEvents(cs1, 0xB8DE);
        // 100D:B8DE call near 0xAE04
        NearCall(cs1, 0xB8E1, service_midi_music);
    label_100D_B8E1_1B9B1_18666:
        CheckExternalEvents(cs1, 0xB8E1);
        // 100D:B8E1 mov AX,0x2562
        AX = (ushort)0x2562;
        // 100D:B8E4 call near 0xD95E
        NearCall(cs1, 0xB8E7, unknown_100D_D95E_1DA2E);
    label_100D_B8E7_1B9B7_18669:
        CheckExternalEvents(cs1, 0xB8E7);
        // 100D:B8E7 call near 0x17E6
        NearCall(cs1, 0xB8EA, ui_hud_head_animate_up);
        return add_globe_rotation_frame_task(0x0000);
    }

    public virtual Action add_globe_rotation_frame_task(int loadOffset)
    {
    label_100D_B8EA_1B9BA_12712:
        CheckExternalEvents(cs1, 0xB8EA);
        // 100D:B8EA mov SI,0xB9AE
        SI = (ushort)0xB9AE;
        // 100D:B8ED mov BP,1
        BP = (ushort)0x0001;
        // 100D:B8F0 jmp near 0xDA25
        return add_frame_task(0x0000);
    }

    public virtual Action globe_slide_decorations_open(int loadOffset)
    {
    label_100D_B8F3_1B9C3_18842:
        CheckExternalEvents(cs1, 0xB8F3);
        // 100D:B8F3 call near 0xB84A
        NearCall(cs1, 0xB8F6, globe_fill_blue_background_to_front_buffer);
    label_100D_B8F6_1B9C6_18844:
        CheckExternalEvents(cs1, 0xB8F6);
        // 100D:B8F6 mov BP,0xBE1D
        BP = (ushort)0xBE1D;
        // 100D:B8F9 call near 0xC097
        NearCall(cs1, 0xB8FC, gfx_call_bp_with_front_buffer_as_screen);
    label_100D_B8FC_1B9CC_19229:
        CheckExternalEvents(cs1, 0xB8FC);
        // 100D:B8FC call near 0xC474
        NearCall(cs1, 0xB8FF, unknown_100D_C474_1C544);
    label_100D_B8FF_1B9CF_19245:
        CheckExternalEvents(cs1, 0xB8FF);
        // 100D:B8FF call near 0xC43E
        NearCall(cs1, 0xB902, copy_game_area_fb2_to_fb1);
    label_100D_B902_1B9D2_19247:
        CheckExternalEvents(cs1, 0xB902);
        // 100D:B902 call near 0xB87E
        NearCall(cs1, 0xB905, draw_globe_side_decorations);
    label_100D_B905_1B9D5_19249:
        CheckExternalEvents(cs1, 0xB905);
        // 100D:B905 call near 0xC4DD
        NearCall(cs1, 0xB908, present_game_area);
    label_100D_B908_1B9D8_19251:
        CheckExternalEvents(cs1, 0xB908);
        // 100D:B908 sub word ptr DS:[0xDD0F],0x0010
        UInt16[DS, (ushort)0xDD0F] = Alu16.Sub(UInt16[DS, (ushort)0xDD0F], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:B90D cmp word ptr DS:[0xDD0F],-106
        Alu16.Sub(UInt16[DS, (ushort)0xDD0F], unchecked((ushort)unchecked((short)(sbyte)-106)));
        // 100D:B912 jg short 0xB8FF
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_B8FF_1B9CF_19245;
        }
    label_100D_B914_1B9E4_19255:
        CheckExternalEvents(cs1, 0xB914);
        // 100D:B914 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action globe_slide_decorations_close(int loadOffset)
    {
    label_100D_B915_1B9E5_30559:
        CheckExternalEvents(cs1, 0xB915);
        // 100D:B915 call near 0xB93B
        NearCall(cs1, 0xB918, unknown_100D_B93B_1BA0B);
    label_100D_B918_1B9E8_30561:
        CheckExternalEvents(cs1, 0xB918);
        // 100D:B918 call near 0xC08E
        NearCall(cs1, 0xB91B, set_screen_as_active_framebuffer);
    label_100D_B91B_1B9EB_30563:
        CheckExternalEvents(cs1, 0xB91B);
        // 100D:B91B add word ptr DS:[0xDD0F],0x0010
        UInt16[DS, (ushort)0xDD0F] = Alu16.Add(UInt16[DS, (ushort)0xDD0F], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:B920 call near 0xB87E
        NearCall(cs1, 0xB923, draw_globe_side_decorations);
    label_100D_B923_1B9F3_30566:
        CheckExternalEvents(cs1, 0xB923);
        // 100D:B923 cmp word ptr DS:[0xDD0F],0
        Alu16.Sub(UInt16[DS, (ushort)0xDD0F], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:B928 jne short 0xB91B
        if (!ZeroFlag)
        {
            goto label_100D_B91B_1B9EB_30563;
        }
    label_100D_B92A_1B9FA_30569:
        CheckExternalEvents(cs1, 0xB92A);
        // 100D:B92A call near 0xC07C
        NearCall(cs1, 0xB92D, set_fb1_as_active_framebuffer);
    label_100D_B92D_1B9FD_30571:
        CheckExternalEvents(cs1, 0xB92D);
        // 100D:B92D jmp near 0xB87E
        return draw_globe_side_decorations(0x0000);
    }

    public virtual Action remove_globe_frame_tasks(int loadOffset)
    {
    label_100D_B930_1BA00_3444:
        CheckExternalEvents(cs1, 0xB930);
        // 100D:B930 mov byte ptr DS:[0xDD03],0
        UInt8[DS, (ushort)0xDD03] = (byte)0x00;
        // 100D:B935 mov SI,0xB9AE
        SI = (ushort)0xB9AE;
        // 100D:B938 call near 0xDA5F
        NearCall(cs1, 0xB93B, remove_frame_task);
        return unknown_100D_B93B_1BA0B(0x0000);
    }

    public virtual Action unknown_100D_B93B_1BA0B(int loadOffset)
    {
    label_100D_B93B_1BA0B_3448:
        CheckExternalEvents(cs1, 0xB93B);
        // 100D:B93B mov SI,0xBE57
        SI = (ushort)0xBE57;
        // 100D:B93E jmp near 0xDA5F
        return remove_frame_task(0x0000);
    }

    public virtual Action globe_menu_push(int loadOffset)
    {
    entrydispatcher:
    label_100D_B941_1BA11_18585:
        CheckExternalEvents(cs1, 0xB941);
        // 100D:B941 mov BP,0x204A
        BP = (ushort)0x204A;
        // 100D:B944 mov AX,0x00B1
        AX = (ushort)0x00B1;
        // 100D:B947 mov BX,0xB96B
        BX = (ushort)0xB96B;
        // 100D:B94A cmp byte ptr DS:[0xDD02],0
        Alu8.Sub(UInt8[DS, (ushort)0xDD02], (byte)0x00);
        // 100D:B94F je short 0xB955
        if (ZeroFlag)
        {
            goto label_100D_B955_1BA25_18591;
        }
    label_100D_B951_1BA21_19334:
        CheckExternalEvents(cs1, 0xB951);
        // 100D:B951 inc AX
        AX = Alu16.Inc(AX);
        // 100D:B952 mov BX,0xB961
        BX = (ushort)0xB961;
    label_100D_B955_1BA25_18591:
        CheckExternalEvents(cs1, 0xB955);
        // 100D:B955 mov word ptr SS:[BP+6],AX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = AX;
        // 100D:B958 mov word ptr SS:[BP+8],BX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = BX;
        // 100D:B95B mov BX,0xD917
        BX = (ushort)0xD917;
        // 100D:B95E jmp near 0xD338
        if (JumpDispatcher.Jump(menu_stack_push, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action menu_callback_choice_globe_see_results(int loadOffset)
    {
    entrydispatcher:
    label_100D_B96B_1BA3B_18840:
        CheckExternalEvents(cs1, 0xB96B);
        // 100D:B96B call near 0xB8F3
        NearCall(cs1, 0xB96E, globe_slide_decorations_open);
    label_100D_B96E_1BA3E_19257:
        CheckExternalEvents(cs1, 0xB96E);
        // 100D:B96E dec byte ptr DS:[0xDD02]
        UInt8[DS, (ushort)0xDD02] = Alu8.Dec(UInt8[DS, (ushort)0xDD02]);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xB972))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action map_func_gfx(int loadOffset)
    {
    label_100D_B977_1BA47_12496:
        CheckExternalEvents(cs1, 0xB977);
        // 100D:B977 mov BP,0x4948
        BP = (ushort)0x4948;
        // 100D:B97A mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:B97E mov AL,byte ptr DS:[0xDD02]
        AL = UInt8[DS, (ushort)0xDD02];
        // 100D:B981 lds SI,word ptr DS:[0xDCFE]
        ushort lxsOffset_100D_B981_1BA51 = (ushort)0xDCFE;
        ushort lxsValue_100D_B981_1BA51 = UInt16[DS, lxsOffset_100D_B981_1BA51];
        ushort lxsSegment_100D_B981_1BA51 = UInt16[DS, (ushort)(lxsOffset_100D_B981_1BA51 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_B981_1BA51);
        DS = unchecked((ushort)lxsSegment_100D_B981_1BA51);
        // 100D:B985 call far dword ptr SS:[0x3911]
        ushort targetSegment_12501 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3911 + (ushort)0x0002)]));
        ushort targetOffset_12501 = unchecked((ushort)(UInt16[SS, (ushort)0x3911]));
        if (targetSegment_12501 == cs2 && targetOffset_12501 == 0x0145)
        {
            FarCall(cs1, 0xB98A, cs2, unknown_3358_0145_336C5);
            goto label_100D_B98A_1BA5A_12705;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12501:X4}:{targetOffset_12501:X4} at 100D:B985");
    label_100D_B98A_1BA5A_12705:
        CheckExternalEvents(cs1, 0xB98A);
        // 100D:B98A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action globe_redraw_and_present(int loadOffset)
    {
    entrydispatcher:
    label_100D_B98B_1BA5B_19260:
        CheckExternalEvents(cs1, 0xB98B);
        // 100D:B98B call near 0xB977
        NearCall(cs1, 0xB98E, map_func_gfx);
        if (JumpDispatcher.Jump(globe_present_and_advance, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action tick_globe_rotation(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9AE_1BA7E_12724:
        CheckExternalEvents(cs1, 0xB9AE);
        // 100D:B9AE mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:B9B2 call far dword ptr DS:[0x3915]
        ushort targetSegment_12726 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3915 + (ushort)0x0002)]));
        ushort targetOffset_12726 = unchecked((ushort)(UInt16[DS, (ushort)0x3915]));
        if (targetSegment_12726 == cs2 && targetOffset_12726 == 0x0148)
        {
            FarCall(cs1, 0xB9B6, cs2, unknown_3358_0148_336C8);
            goto label_100D_B9B6_1BA86_12729;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12726:X4}:{targetOffset_12726:X4} at 100D:B9B2");
    label_100D_B9B6_1BA86_12729:
        CheckExternalEvents(cs1, 0xB9B6);
        // 100D:B9B6 jb short 0xB98E
        if (CarryFlag)
        {
            if (JumpDispatcher.Jump(globe_present_and_advance, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_B9B8_1BA88_12731:
        CheckExternalEvents(cs1, 0xB9B8);
        // 100D:B9B8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action callback_globe_tilt_up(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9B9_1BA89_36787:
        CheckExternalEvents(cs1, 0xB9B9);
        // 100D:B9B9 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B9BB mov AX,8
        AX = (ushort)0x0008;
        // 100D:B9BE jmp short 0xB9C5
        if (JumpDispatcher.Jump(unknown_100D_B9C5_1BA95, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action callback_globe_tilt_down(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9C0_1BA90_36777:
        CheckExternalEvents(cs1, 0xB9C0);
        // 100D:B9C0 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B9C2 mov AX,0xFFF8
        AX = (ushort)0xFFF8;
        if (JumpDispatcher.Jump(unknown_100D_B9C5_1BA95, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action callback_globe_rotate_east(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9CC_1BA9C_36802:
        CheckExternalEvents(cs1, 0xB9CC);
        // 100D:B9CC shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B9CE mov AX,0xFFE0
        AX = (ushort)0xFFE0;
        // 100D:B9D1 jmp short 0xB9D8
        if (JumpDispatcher.Jump(unknown_100D_B9D8_1BAA8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action callback_globe_rotate_west(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9D3_1BAA3_36792:
        CheckExternalEvents(cs1, 0xB9D3);
        // 100D:B9D3 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:B9D5 mov AX,0x0020
        AX = (ushort)0x0020;
        if (JumpDispatcher.Jump(unknown_100D_B9D8_1BAA8, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action globe_rotation_increment(int loadOffset)
    {
    label_100D_B9E0_1BAB0_12760:
        CheckExternalEvents(cs1, 0xB9E0);
        // 100D:B9E0 mov SI,0x494C
        SI = (ushort)0x494C;
        // 100D:B9E3 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:B9E5 mov CX,0x018E
        CX = (ushort)0x018E;
        // 100D:B9E8 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:B9EA jns short 0xB9EE
        if (!SignFlag)
        {
            goto label_100D_B9EE_1BABE_12766;
        }
    label_100D_B9EC_1BABC_34942:
        CheckExternalEvents(cs1, 0xB9EC);
        // 100D:B9EC add DX,CX
        DX = Alu16.Add(DX, CX);
    label_100D_B9EE_1BABE_12766:
        CheckExternalEvents(cs1, 0xB9EE);
        // 100D:B9EE cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:B9F0 js short 0xB9F4
        if (SignFlag)
        {
            goto label_100D_B9F4_1BAC4_12769;
        }
    label_100D_B9F2_1BAC2_36800:
        CheckExternalEvents(cs1, 0xB9F2);
        // 100D:B9F2 sub DX,CX
        DX = Alu16.Sub(DX, CX);
    label_100D_B9F4_1BAC4_12769:
        CheckExternalEvents(cs1, 0xB9F4);
        // 100D:B9F4 mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        return precalculate_globe_rotation_lookup_table(0x0000);
    }

    public virtual Action precalculate_globe_rotation_lookup_table(int loadOffset)
    {
    label_100D_B9F6_1BAC6_12411:
        CheckExternalEvents(cs1, 0xB9F6);
        // 100D:B9F6 mov AX,0x8000
        AX = (ushort)0x8000;
        // 100D:B9F9 mov CX,0x018E
        CX = (ushort)0x018E;
        // 100D:B9FC div CX
        ushort divisor_100D_B9FC_1BACC = CX;
        uint dividend_100D_B9FC_1BACC = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_B9FC_1BACC = Alu16.Div(unchecked((uint)dividend_100D_B9FC_1BACC), unchecked((ushort)divisor_100D_B9FC_1BACC));
        AX = unchecked((ushort)quotient_100D_B9FC_1BACC);
        DX = unchecked((ushort)(dividend_100D_B9FC_1BACC % unchecked((uint)divisor_100D_B9FC_1BACC)));
        // 100D:B9FE mov CX,0x0062
        CX = (ushort)0x0062;
        // 100D:BA01 mov BX,AX
        BX = AX;
    label_100D_BA03_1BAD3_12417:
        CheckExternalEvents(cs1, 0xBA03);
        // 100D:BA03 add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:BA06 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:BA07 mul BX
        uint result_100D_BA07_1BAD7 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)BX)));
        DX = unchecked((ushort)(result_100D_BA07_1BAD7 >> 16));
        AX = unchecked((ushort)result_100D_BA07_1BAD7);
        // 100D:BA09 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:BA0B adc DX,DX
        DX = Alu16.Adc(DX, DX);
        // 100D:BA0D mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:BA0F mov word ptr DS:[SI+2],AX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = AX;
        // 100D:BA12 loop 0xBA03
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA03_1BAD3_12417;
        }
    label_100D_BA14_1BAE4_12426:
        CheckExternalEvents(cs1, 0xBA14);
        // 100D:BA14 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action globe_increment_tilt(int loadOffset)
    {
    label_100D_BA15_1BAE5_19548:
        CheckExternalEvents(cs1, 0xBA15);
        // 100D:BA15 add AX,word ptr DS:[0x2460]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x2460]);
        // 100D:BA19 mov CX,0x0062
        CX = (ushort)0x0062;
        // 100D:BA1C cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:BA1E jl short 0xBA22
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_BA22_1BAF2_19553;
        }
    label_100D_BA20_1BAF0_36916:
        CheckExternalEvents(cs1, 0xBA20);
        // 100D:BA20 mov AX,CX
        AX = CX;
    label_100D_BA22_1BAF2_19553:
        CheckExternalEvents(cs1, 0xBA22);
        // 100D:BA22 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:BA24 cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:BA26 jg short 0xBA2A
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_BA2A_1BAFA_19557;
        }
    label_100D_BA28_1BAF8_36914:
        CheckExternalEvents(cs1, 0xBA28);
        // 100D:BA28 mov AX,CX
        AX = CX;
    label_100D_BA2A_1BAFA_19557:
        CheckExternalEvents(cs1, 0xBA2A);
        // 100D:BA2A mov word ptr DS:[0x2460],AX
        UInt16[DS, (ushort)0x2460] = AX;
        return unknown_100D_BA2D_1BAFD(0x0000);
    }

    public virtual Action set_globe_tilt_and_rotation(int loadOffset)
    {
    label_100D_BA75_1BB45_12395:
        CheckExternalEvents(cs1, 0xBA75);
        // 100D:BA75 mov SI,0x494C
        SI = (ushort)0x494C;
        // 100D:BA78 mov AX,0x018E
        AX = (ushort)0x018E;
        // 100D:BA7B mul DX
        uint result_100D_BA7B_1BB4B = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_BA7B_1BB4B >> 16));
        AX = unchecked((ushort)result_100D_BA7B_1BB4B);
        // 100D:BA7D mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:BA7F mov word ptr DS:[SI+2],0
        UInt16[DS, (ushort)(SI + (sbyte)2)] = (ushort)0x0000;
        // 100D:BA84 mov AX,BX
        AX = BX;
        // 100D:BA86 cmp AX,0x0020
        Alu16.Sub(AX, (ushort)0x0020);
        // 100D:BA89 jae short 0xBA8E
        if (!CarryFlag)
        {
            goto label_100D_BA8E_1BB5E_12404;
        }
    label_100D_BA8B_1BB5B_34886:
        CheckExternalEvents(cs1, 0xBA8B);
        // 100D:BA8B mov AX,0x0020
        AX = (ushort)0x0020;
    label_100D_BA8E_1BB5E_12404:
        CheckExternalEvents(cs1, 0xBA8E);
        // 100D:BA8E cmp AX,0xFFE0
        Alu16.Sub(AX, (ushort)0xFFE0);
        // 100D:BA91 jb short 0xBA96
        if (CarryFlag)
        {
            goto label_100D_BA96_1BB66_12409;
        }
    label_100D_BA93_1BB63_12407:
        CheckExternalEvents(cs1, 0xBA93);
        // 100D:BA93 mov AX,0xFFE0
        AX = (ushort)0xFFE0;
    label_100D_BA96_1BB66_12409:
        CheckExternalEvents(cs1, 0xBA96);
        // 100D:BA96 mov word ptr DS:[0x2460],AX
        UInt16[DS, (ushort)0x2460] = AX;
        // 100D:BA99 call near 0xB9F6
        NearCall(cs1, 0xBA9C, precalculate_globe_rotation_lookup_table);
    label_100D_BA9C_1BB6C_12428:
        CheckExternalEvents(cs1, 0xBA9C);
        // 100D:BA9C jmp short 0xBA2D
        return unknown_100D_BA2D_1BAFD(0x0000);
    }

    public virtual Action callback_globe_center_on_player(int loadOffset)
    {
    entrydispatcher:
    label_100D_BA9E_1BB6E_19499:
        CheckExternalEvents(cs1, 0xBA9E);
        // 100D:BA9E call near 0x407E
        NearCall(cs1, 0xBAA1, get_map_position);
    label_100D_BAA1_1BB71_19501:
        CheckExternalEvents(cs1, 0xBAA1);
        // 100D:BAA1 mov AX,0x018E
        AX = (ushort)0x018E;
        // 100D:BAA4 mul DX
        uint result_100D_BAA4_1BB74 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_BAA4_1BB74 >> 16));
        AX = unchecked((ushort)result_100D_BAA4_1BB74);
        // 100D:BAA6 mov BP,word ptr DS:[0x494A]
        BP = UInt16[DS, (ushort)0x494A];
        // 100D:BAAA add BP,BP
        BP = Alu16.Add(BP, BP);
        // 100D:BAAC sub DX,word ptr DS:[0x494C]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0x494C]);
        // 100D:BAB0 call near 0xB683
        NearCall(cs1, 0xBAB3, unknown_100D_B683_1B753);
    label_100D_BAB3_1BB83_19520:
        CheckExternalEvents(cs1, 0xBAB3);
        // 100D:BAB3 mov CX,1
        CX = (ushort)0x0001;
        // 100D:BAB6 mov AX,0x0020
        AX = (ushort)0x0020;
        // 100D:BAB9 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:BABB jl short 0xBAC0
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_BAC0_1BB90_19525;
        }
    label_100D_BABD_1BB8D_37926:
        CheckExternalEvents(cs1, 0xBABD);
        // 100D:BABD mov DX,AX
        DX = AX;
        // 100D:BABF inc CX
        CX = Alu16.Inc(CX);
    label_100D_BAC0_1BB90_19525:
        CheckExternalEvents(cs1, 0xBAC0);
        // 100D:BAC0 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:BAC2 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:BAC4 jg short 0xBAC9
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_BAC9_1BB99_19529;
        }
    label_100D_BAC6_1BB96_34939:
        CheckExternalEvents(cs1, 0xBAC6);
        // 100D:BAC6 mov DX,AX
        DX = AX;
        // 100D:BAC8 inc CX
        CX = Alu16.Inc(CX);
    label_100D_BAC9_1BB99_19529:
        CheckExternalEvents(cs1, 0xBAC9);
        // 100D:BAC9 sub BX,word ptr DS:[0x2460]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0x2460]);
        // 100D:BACD mov AX,0x0018
        AX = (ushort)0x0018;
        // 100D:BAD0 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:BAD2 jl short 0xBAD7
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_BAD7_1BBA7_19537;
        }
    label_100D_BAD4_1BBA4_19534:
        CheckExternalEvents(cs1, 0xBAD4);
        // 100D:BAD4 mov BX,AX
        BX = AX;
        // 100D:BAD6 inc CX
        CX = Alu16.Inc(CX);
    label_100D_BAD7_1BBA7_19537:
        CheckExternalEvents(cs1, 0xBAD7);
        // 100D:BAD7 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:BAD9 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:BADB jg short 0xBAE0
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_BAE0_1BBB0_19540;
        }
    label_100D_BADD_1BBAD_36772:
        CheckExternalEvents(cs1, 0xBADD);
        // 100D:BADD mov BX,AX
        BX = AX;
        // 100D:BADF inc CX
        CX = Alu16.Inc(CX);
    label_100D_BAE0_1BBB0_19540:
        CheckExternalEvents(cs1, 0xBAE0);
        // 100D:BAE0 mov AX,DX
        AX = DX;
        // 100D:BAE2 push CX
        Stack.Push16(CX);
        // 100D:BAE3 push BX
        Stack.Push16(BX);
        // 100D:BAE4 call near 0xB9E0
        NearCall(cs1, 0xBAE7, globe_rotation_increment);
    label_100D_BAE7_1BBB7_19545:
        CheckExternalEvents(cs1, 0xBAE7);
        // 100D:BAE7 pop AX
        AX = Stack.Pop16();
        // 100D:BAE8 call near 0xBA15
        NearCall(cs1, 0xBAEB, globe_increment_tilt);
    label_100D_BAEB_1BBBB_19559:
        CheckExternalEvents(cs1, 0xBAEB);
        // 100D:BAEB call near 0xB98B
        NearCall(cs1, 0xBAEE, globe_redraw_and_present);
    label_100D_BAEE_1BBBE_19561:
        CheckExternalEvents(cs1, 0xBAEE);
        // 100D:BAEE pop CX
        CX = Stack.Pop16();
        // 100D:BAEF loop 0xBA9E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA9E_1BB6E_19499;
        }
        else
        {
            return unknown_100D_BAF1_1BBC1(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action player_screen_pos(int loadOffset)
    {
    label_100D_BAF2_1BBC2_12735:
        CheckExternalEvents(cs1, 0xBAF2);
        // 100D:BAF2 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:BAF4 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:BAF9 jne short 0xBAF1
        if (!ZeroFlag)
        {
            return unknown_100D_BAF1_1BBC1(0x0000);
        }
    label_100D_BAFB_1BBCB_18702:
        CheckExternalEvents(cs1, 0xBAFB);
        // 100D:BAFB call near 0x407E
        NearCall(cs1, 0xBAFE, get_map_position);
    label_100D_BAFE_1BBCE_18704:
        CheckExternalEvents(cs1, 0xBAFE);
        // 100D:BAFE sub SP,0x000A
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:BB01 mov BP,SP
        BP = SP;
        // 100D:BB03 mov word ptr SS:[BP],0
        UInt16[SS, (ushort)(BP + (sbyte)0)] = (ushort)0x0000;
        // 100D:BB08 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BB0A shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BB0C shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:BB0E jns short 0xBB16
        if (!SignFlag)
        {
            goto label_100D_BB16_1BBE6_18715;
        }
    label_100D_BB10_1BBE0_18712:
        CheckExternalEvents(cs1, 0xBB10);
        // 100D:BB10 mov byte ptr SS:[BP+1],0xFF
        UInt8[SS, (ushort)(BP + (sbyte)1)] = (byte)0xFF;
        // 100D:BB14 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_BB16_1BBE6_18715:
        CheckExternalEvents(cs1, 0xBB16);
        // 100D:BB16 mov CX,word ptr DS:[BX+0x494A]
        CX = UInt16[DS, (ushort)(BX + (short)18762)];
        // 100D:BB1A mov AX,CX
        AX = CX;
        // 100D:BB1C add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:BB1E mul DX
        uint result_100D_BB1E_1BBEE = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_BB1E_1BBEE >> 16));
        AX = unchecked((ushort)result_100D_BB1E_1BBEE);
        // 100D:BB20 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:BB22 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:BB25 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:BB27 sub DX,word ptr DS:[BX+0x494C]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)(BX + (short)18764)]);
        // 100D:BB2B jns short 0xBB31
        if (!SignFlag)
        {
            goto label_100D_BB31_1BC01_18724;
        }
    label_100D_BB2D_1BBFD_19338:
        CheckExternalEvents(cs1, 0xBB2D);
        // 100D:BB2D neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:BB2F not AX
        AX = unchecked((ushort)~AX);
    label_100D_BB31_1BC01_18724:
        CheckExternalEvents(cs1, 0xBB31);
        // 100D:BB31 cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:BB33 jb short 0xBB3D
        if (CarryFlag)
        {
            goto label_100D_BB3D_1BC0D_18727;
        }
    label_100D_BB35_1BC05_34925:
        CheckExternalEvents(cs1, 0xBB35);
        // 100D:BB35 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:BB37 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:BB39 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 100D:BB3B not AX
        AX = unchecked((ushort)~AX);
    label_100D_BB3D_1BC0D_18727:
        CheckExternalEvents(cs1, 0xBB3D);
        // 100D:BB3D shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:BB3F cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:BB41 jb short 0xBB4D
        if (CarryFlag)
        {
            goto label_100D_BB4D_1BC1D_18731;
        }
    label_100D_BB43_1BC13_36097:
        CheckExternalEvents(cs1, 0xBB43);
        // 100D:BB43 mov byte ptr SS:[BP],0x80
        UInt8[SS, (ushort)(BP + (sbyte)0)] = (byte)0x80;
        // 100D:BB47 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:BB49 sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 100D:BB4B neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_BB4D_1BC1D_18731:
        CheckExternalEvents(cs1, 0xBB4D);
        // 100D:BB4D mov byte ptr SS:[BP+4],AL
        UInt8[SS, (ushort)(BP + (sbyte)4)] = AL;
        // 100D:BB50 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:BB52 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:BB54 push DS
        Stack.Push16(DS);
        // 100D:BB55 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:BB56 mov DI,0x593A
        DI = (ushort)0x593A;
        // 100D:BB59 mov AX,BX
        AX = BX;
        // 100D:BB5B mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:BB5E xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_BB60_1BC30_18741:
        CheckExternalEvents(cs1, 0xBB60);
        // 100D:BB60 repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_BB60_1BC30 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_BB60_1BC30)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_BB60_1BC30 = ZeroFlag == false;
        }
        // 100D:BB62 jne short 0xBB7A
        if (!ZeroFlag)
        {
            goto label_100D_BB7A_1BC4A_36775;
        }
    label_100D_BB64_1BC34_18743:
        CheckExternalEvents(cs1, 0xBB64);
        // 100D:BB64 inc CX
        CX = Alu16.Inc(CX);
        // 100D:BB65 cmp DL,byte ptr DS:[DI+0x63]
        Alu8.Sub(DL, UInt8[DS, (ushort)(DI + (sbyte)99)]);
        // 100D:BB68 jbe short 0xBB7D
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_BB7D_1BC4D_18754;
        }
    label_100D_BB6A_1BC3A_18747:
        CheckExternalEvents(cs1, 0xBB6A);
        // 100D:BB6A mov word ptr SS:[BP+2],CX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = CX;
        // 100D:BB6D inc BX
        BX = Alu16.Inc(BX);
        // 100D:BB6E add DI,0x00C7
        DI = Alu16.Add(DI, (ushort)0x00C7);
        // 100D:BB72 cmp DI,0x8B3B
        Alu16.Sub(DI, (ushort)0x8B3B);
        // 100D:BB76 jb short 0xBB60
        if (CarryFlag)
        {
            goto label_100D_BB60_1BC30_18741;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:BB76");
        }
    label_100D_BB7A_1BC4A_36775:
        CheckExternalEvents(cs1, 0xBB7A);
        // 100D:BB7A mov CX,word ptr SS:[BP+2]
        CX = UInt16[SS, (ushort)(BP + (sbyte)2)];
    label_100D_BB7D_1BC4D_18754:
        CheckExternalEvents(cs1, 0xBB7D);
        // 100D:BB7D mov AX,0x0064
        AX = (ushort)0x0064;
        // 100D:BB80 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:BB82 mov word ptr SS:[BP+2],BX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = BX;
        // 100D:BB85 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:BB88 mov AH,CH
        AH = CH;
        // 100D:BB8A or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:BB8C jns short 0xBB90
        if (!SignFlag)
        {
            goto label_100D_BB90_1BC60_18762;
        }
    label_100D_BB8E_1BC5E_36102:
        CheckExternalEvents(cs1, 0xBB8E);
        // 100D:BB8E neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_BB90_1BC60_18762:
        CheckExternalEvents(cs1, 0xBB90);
        // 100D:BB90 mov DI,0x8BBB
        DI = (ushort)0x8BBB;
        // 100D:BB93 mov CX,0x0080
        CX = (ushort)0x0080;
        // 100D:BB96 repne scas AX,word ptr ES:[DI]
        bool shouldContinue_100D_BB96_1BC66 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_BB96_1BC66)
        {
            Alu16.Sub(AX, UInt16[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_BB96_1BC66 = ZeroFlag == false;
        }
        // 100D:BB98 jne short 0xBBE6
        if (!ZeroFlag)
        {
            goto label_100D_BBE6_1BCB6_34930;
        }
    label_100D_BB9A_1BC6A_18767:
        CheckExternalEvents(cs1, 0xBB9A);
        // 100D:BB9A xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:BB9C sub DI,0x8C3D
        DI = Alu16.Sub(DI, (ushort)0x8C3D);
        // 100D:BBA0 jns short 0xBBA6
        if (!SignFlag)
        {
            goto label_100D_BBA6_1BC76_18774;
        }
    label_100D_BBA2_1BC72_18771:
        CheckExternalEvents(cs1, 0xBBA2);
        // 100D:BBA2 neg DI
        DI = Alu16.Sub((ushort)0x0000, DI);
        CarryFlag = DI != (ushort)0x0000;
        // 100D:BBA4 not AL
        AL = unchecked((byte)~AL);
    label_100D_BBA6_1BC76_18774:
        CheckExternalEvents(cs1, 0xBBA6);
        // 100D:BBA6 mov byte ptr SS:[BP+5],AL
        UInt8[SS, (ushort)(BP + (sbyte)5)] = AL;
        // 100D:BBA9 mov BX,0x0036
        BX = (ushort)0x0036;
        // 100D:BBAC mov AX,DI
        AX = DI;
        // 100D:BBAE shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BBB0 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:BBB3 mov DX,word ptr SS:[BP+2]
        DX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:BBB6 mov CL,AL
        CL = AL;
        // 100D:BBB8 mov CH,0xFF
        CH = (byte)0xFF;
        // 100D:BBBA xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_BBBC_1BC8C_18783:
        CheckExternalEvents(cs1, 0xBBBC);
        // 100D:BBBC lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:BBBD inc AL
        AL = Alu8.Inc(AL);
        // 100D:BBBF je short 0xBBE1
        if (ZeroFlag)
        {
            goto label_100D_BBE1_1BCB1_18807;
        }
    label_100D_BBC1_1BC91_18786:
        CheckExternalEvents(cs1, 0xBBC1);
        // 100D:BBC1 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
        // 100D:BBC3 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 100D:BBC5 jbe short 0xBBE1
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_BBE1_1BCB1_18807;
        }
    label_100D_BBC7_1BC97_18790:
        CheckExternalEvents(cs1, 0xBBC7);
        // 100D:BBC7 mov DI,SI
        DI = SI;
        // 100D:BBC9 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:BBCB add DI,DX
        DI = Alu16.Add(DI, DX);
        // 100D:BBCD mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:BBCF sub AL,CL
        AL = Alu8.Sub(AL, CL);
        // 100D:BBD1 cmp AL,CH
        Alu8.Sub(AL, CH);
        // 100D:BBD3 jae short 0xBBDE
        if (!CarryFlag)
        {
            goto label_100D_BBDE_1BCAE_18803;
        }
    label_100D_BBD5_1BCA5_18798:
        CheckExternalEvents(cs1, 0xBBD5);
        // 100D:BBD5 mov CH,AL
        CH = AL;
        // 100D:BBD7 mov word ptr SS:[BP+6],BX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = BX;
        // 100D:BBDA or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:BBDC je short 0xBBEC
        if (ZeroFlag)
        {
            goto label_100D_BBEC_1BCBC_18810;
        }
    label_100D_BBDE_1BCAE_18803:
        CheckExternalEvents(cs1, 0xBBDE);
        // 100D:BBDE dec BX
        BX = Alu16.Dec(BX);
        // 100D:BBDF jne short 0xBBBC
        if (!ZeroFlag)
        {
            goto label_100D_BBBC_1BC8C_18783;
        }
    label_100D_BBE1_1BCB1_18807:
        CheckExternalEvents(cs1, 0xBBE1);
        // 100D:BBE1 cmp CH,2
        Alu8.Sub(CH, (byte)0x02);
        // 100D:BBE4 jbe short 0xBBEC
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_BBEC_1BCBC_18810;
        }
    label_100D_BBE6_1BCB6_34930:
        CheckExternalEvents(cs1, 0xBBE6);
        // 100D:BBE6 add SP,0x000A
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:BBE9 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:BBEB ret near
        return NearRet((ushort)0x0000);
    label_100D_BBEC_1BCBC_18810:
        CheckExternalEvents(cs1, 0xBBEC);
        // 100D:BBEC mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:BBEF mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:BBF2 sub BX,0x0036
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)54)));
        // 100D:BBF5 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:BBF7 je short 0xBBFB
        if (ZeroFlag)
        {
            goto label_100D_BBFB_1BCCB_18818;
        }
    label_100D_BBF9_1BCC9_18816:
        CheckExternalEvents(cs1, 0xBBF9);
        // 100D:BBF9 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_BBFB_1BCCB_18818:
        CheckExternalEvents(cs1, 0xBBFB);
        // 100D:BBFB add BX,0x004F
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)79)));
        // 100D:BBFE or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:BC00 je short 0xBC04
        if (ZeroFlag)
        {
            goto label_100D_BC04_1BCD4_18821;
        }
    label_100D_BC02_1BCD2_19341:
        CheckExternalEvents(cs1, 0xBC02);
        // 100D:BC02 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_BC04_1BCD4_18821:
        CheckExternalEvents(cs1, 0xBC04);
        // 100D:BC04 add DX,0x00A0
        DX = Alu16.Add(DX, (ushort)0x00A0);
        // 100D:BC08 add SP,0x000A
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:BC0B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action draw_globe_cursor_at(int loadOffset)
    {
    label_100D_BC0C_1BCDC_18830:
        CheckExternalEvents(cs1, 0xBC0C);
        // 100D:BC0C call near 0xC08E
        NearCall(cs1, 0xBC0F, set_screen_as_active_framebuffer);
    label_100D_BC0F_1BCDF_18832:
        CheckExternalEvents(cs1, 0xBC0F);
        // 100D:BC0F call near 0xC137
        NearCall(cs1, 0xBC12, open_icones_spritesheet);
    label_100D_BC12_1BCE2_18834:
        CheckExternalEvents(cs1, 0xBC12);
        // 100D:BC12 mov AX,0x0036
        AX = (ushort)0x0036;
        // 100D:BC15 call near 0xC1F4
        NearCall(cs1, 0xBC18, unknown_100D_C1F4_1C2C4);
    label_100D_BC18_1BCE8_18837:
        CheckExternalEvents(cs1, 0xBC18);
        // 100D:BC18 sub BL,byte ptr ES:[SI+2]
        BL = Alu8.Sub(BL, UInt8[ES, (ushort)(SI + (sbyte)2)]);
        // 100D:BC1C jmp near 0xC22F
        return draw_active_bank_sprite(0x0000);
    }

    public virtual Action globe_mouse_idle(int loadOffset)
    {
    entrydispatcher:
    label_100D_BC1F_1BCEF_18671:
        CheckExternalEvents(cs1, 0xBC1F);
        // 100D:BC1F call near 0xD41B
        NearCall(cs1, 0xBC22, get_location_and_room);
    label_100D_BC22_1BCF2_18673:
        CheckExternalEvents(cs1, 0xBC22);
        // 100D:BC22 cmp BP,0x204A
        Alu16.Sub(BP, (ushort)0x204A);
        // 100D:BC26 je short 0xBC2C
        if (ZeroFlag)
        {
            goto label_100D_BC2C_1BCFC_18676;
        }
    label_100D_BC28_1BCF8_19449:
        CheckExternalEvents(cs1, 0xBC28);
        // 100D:BC28 cmp BP,0x2062
        Alu16.Sub(BP, (ushort)0x2062);
    label_100D_BC2C_1BCFC_18676:
        CheckExternalEvents(cs1, 0xBC2C);
        // 100D:BC2C jne short 0xBC4D
        if (!ZeroFlag)
        {
            goto label_100D_BC4D_1BD1D_18699;
        }
    label_100D_BC2E_1BCFE_18678:
        CheckExternalEvents(cs1, 0xBC2E);
        // 100D:BC2E call near 0xBC4E
        NearCall(cs1, 0xBC31, globe_disc_hit);
    label_100D_BC31_1BD01_18694:
        CheckExternalEvents(cs1, 0xBC31);
        // 100D:BC31 jb short 0xBC3C
        if (CarryFlag)
        {
            goto label_100D_BC3C_1BD0C_30537;
        }
    label_100D_BC33_1BD03_18696:
        CheckExternalEvents(cs1, 0xBC33);
        // 100D:BC33 cmp BP,0x204A
        Alu16.Sub(BP, (ushort)0x204A);
        // 100D:BC37 je short 0xBC4D
        if (ZeroFlag)
        {
            goto label_100D_BC4D_1BD1D_18699;
        }
    label_100D_BC39_1BD09_30545:
        CheckExternalEvents(cs1, 0xBC39);
        // 100D:BC39 jmp near 0xB941
        if (JumpDispatcher.Jump(globe_menu_push, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_BC3C_1BD0C_30537:
        CheckExternalEvents(cs1, 0xBC3C);
        // 100D:BC3C cmp BP,0x2062
        Alu16.Sub(BP, (ushort)0x2062);
        // 100D:BC40 je short 0xBC4D
        if (ZeroFlag)
        {
            goto label_100D_BC4D_1BD1D_18699;
        }
    label_100D_BC42_1BD12_30540:
        CheckExternalEvents(cs1, 0xBC42);
        // 100D:BC42 mov BP,0x2062
        BP = (ushort)0x2062;
        // 100D:BC45 mov BX,0xD917
        BX = (ushort)0xD917;
        // 100D:BC48 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:BC4A jmp near 0xD33A
        if (JumpDispatcher.Jump(unknown_100D_D33A_1D40A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_BC4D_1BD1D_18699:
        CheckExternalEvents(cs1, 0xBC4D);
        // 100D:BC4D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action globe_disc_hit(int loadOffset)
    {
    label_100D_BC4E_1BD1E_18680:
        CheckExternalEvents(cs1, 0xBC4E);
        // 100D:BC4E sub DX,0x0060
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)96)));
        // 100D:BC51 cmc
        CarryFlag = !CarryFlag;
        // 100D:BC52 jae short 0xBC63
        if (!CarryFlag)
        {
            goto label_100D_BC63_1BD33_18693;
        }
    label_100D_BC54_1BD24_18684:
        CheckExternalEvents(cs1, 0xBC54);
        // 100D:BC54 cmp DX,0x0080
        Alu16.Sub(DX, (ushort)0x0080);
        // 100D:BC58 jae short 0xBC63
        if (!CarryFlag)
        {
            goto label_100D_BC63_1BD33_18693;
        }
    label_100D_BC5A_1BD2A_18687:
        CheckExternalEvents(cs1, 0xBC5A);
        // 100D:BC5A sub BX,0x0019
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)25)));
        // 100D:BC5D cmc
        CarryFlag = !CarryFlag;
        // 100D:BC5E jae short 0xBC63
        if (!CarryFlag)
        {
            goto label_100D_BC63_1BD33_18693;
        }
    label_100D_BC60_1BD30_18691:
        CheckExternalEvents(cs1, 0xBC60);
        // 100D:BC60 cmp BX,0x006D
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)109)));
    label_100D_BC63_1BD33_18693:
        CheckExternalEvents(cs1, 0xBC63);
        // 100D:BC63 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action globe_mouse_lmb(int loadOffset)
    {
    entrydispatcher:
    label_100D_BC64_1BD34_36807:
        CheckExternalEvents(cs1, 0xBC64);
        // 100D:BC64 push BX
        Stack.Push16(BX);
        // 100D:BC65 push DX
        Stack.Push16(DX);
        // 100D:BC66 call near 0xBC4E
        NearCall(cs1, 0xBC69, globe_disc_hit);
    label_100D_BC69_1BD39_36811:
        CheckExternalEvents(cs1, 0xBC69);
        // 100D:BC69 jae short 0xBC7E
        if (!CarryFlag)
        {
            goto label_100D_BC7E_1BD4E_39679;
        }
    label_100D_BC6B_1BD3B_36813:
        CheckExternalEvents(cs1, 0xBC6B);
        // 100D:BC6B call near 0xBD25
        NearCall(cs1, 0xBC6E, pick_map_position);
    label_100D_BC6E_1BD3E_36901:
        CheckExternalEvents(cs1, 0xBC6E);
        // 100D:BC6E jae short 0xBC7E
        if (!CarryFlag)
        {
            goto label_100D_BC7E_1BD4E_39679;
        }
    label_100D_BC70_1BD40_36903:
        CheckExternalEvents(cs1, 0xBC70);
        // 100D:BC70 mov word ptr DS:[0x197C],AX
        UInt16[DS, (ushort)0x197C] = AX;
        // 100D:BC73 mov word ptr DS:[0x197E],BX
        UInt16[DS, (ushort)0x197E] = BX;
        // 100D:BC77 call near 0xB98B
        NearCall(cs1, 0xBC7A, globe_redraw_and_present);
    label_100D_BC7A_1BD4A_36907:
        CheckExternalEvents(cs1, 0xBC7A);
        // 100D:BC7A pop DX
        DX = Stack.Pop16();
        // 100D:BC7B pop BX
        BX = Stack.Pop16();
        // 100D:BC7C jmp short 0xBC8D
        if (JumpDispatcher.Jump(globe_zoom_out_to_map, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_BC7E_1BD4E_39679:
        CheckExternalEvents(cs1, 0xBC7E);
        // 100D:BC7E pop DX
        DX = Stack.Pop16();
        // 100D:BC7F pop BX
        BX = Stack.Pop16();
        // 100D:BC80 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action callback_ui_element_globe_exit(int loadOffset)
    {
    entrydispatcher:
    label_100D_BC81_1BD51_19497:
        CheckExternalEvents(cs1, 0xBC81);
        // 100D:BC81 call near 0xBA9E
        NearCall(cs1, 0xBC84, callback_globe_center_on_player);
    label_100D_BC84_1BD54_19567:
        CheckExternalEvents(cs1, 0xBC84);
        // 100D:BC84 call near 0x5B5D
        NearCall(cs1, 0xBC87, set_zoomed_globe_pos_from_map_position);
    label_100D_BC87_1BD57_19569:
        CheckExternalEvents(cs1, 0xBC87);
        // 100D:BC87 mov DX,0x00A0
        DX = (ushort)0x00A0;
        // 100D:BC8A mov BX,0x004F
        BX = (ushort)0x004F;
        if (JumpDispatcher.Jump(globe_zoom_out_to_map, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action globe_zoom_box_animation(int loadOffset)
    {
    label_100D_BC99_1BD69_19575:
        CheckExternalEvents(cs1, 0xBC99);
        // 100D:BC99 mov SI,0xDD06
        SI = (ushort)0xDD06;
        // 100D:BC9C mov word ptr DS:[SI],DX
        UInt16[DS, SI] = DX;
        // 100D:BC9E mov word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = BX;
        // 100D:BCA1 inc DX
        DX = Alu16.Inc(DX);
        // 100D:BCA2 inc DX
        DX = Alu16.Inc(DX);
        // 100D:BCA3 inc BX
        BX = Alu16.Inc(BX);
        // 100D:BCA4 mov word ptr DS:[SI+4],DX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DX;
        // 100D:BCA7 mov word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = BX;
        // 100D:BCAA mov byte ptr DS:[SI+8],7
        UInt8[DS, (ushort)(SI + (sbyte)8)] = (byte)0x07;
        // 100D:BCAE call near 0xC08E
        NearCall(cs1, 0xBCB1, set_screen_as_active_framebuffer);
    label_100D_BCB1_1BD81_19586:
        CheckExternalEvents(cs1, 0xBCB1);
        // 100D:BCB1 mov CX,8
        CX = (ushort)0x0008;
    label_100D_BCB4_1BD84_19588:
        CheckExternalEvents(cs1, 0xBCB4);
        // 100D:BCB4 push CX
        Stack.Push16(CX);
        // 100D:BCB5 mov SI,0xDD06
        SI = (ushort)0xDD06;
        // 100D:BCB8 mov DI,0x2440
        DI = (ushort)0x2440;
        // 100D:BCBB mov CX,2
        CX = (ushort)0x0002;
        // 100D:BCBE mov DX,0xFFFC
        DX = (ushort)0xFFFC;
    label_100D_BCC1_1BD91_19593:
        CheckExternalEvents(cs1, 0xBCC1);
        // 100D:BCC1 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:BCC3 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:BCC5 cmp AX,word ptr DS:[DI]
        Alu16.Sub(AX, UInt16[DS, DI]);
        // 100D:BCC7 jae short 0xBCCB
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:BCC7");
        }
    label_100D_BCCB_1BD9B_19597:
        CheckExternalEvents(cs1, 0xBCCB);
        // 100D:BCCB mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:BCCD add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:BCD0 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:BCD3 sar DX,1
        DX = Alu16.Sar(DX, 1);
        // 100D:BCD5 loop 0xBCC1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BCC1_1BD91_19593;
        }
    label_100D_BCD7_1BDA7_19604:
        CheckExternalEvents(cs1, 0xBCD7);
        // 100D:BCD7 mov CX,2
        CX = (ushort)0x0002;
        // 100D:BCDA mov DX,4
        DX = (ushort)0x0004;
    label_100D_BCDD_1BDAD_19607:
        CheckExternalEvents(cs1, 0xBCDD);
        // 100D:BCDD mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:BCDF add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:BCE1 cmp AX,word ptr DS:[DI]
        Alu16.Sub(AX, UInt16[DS, DI]);
        // 100D:BCE3 jb short 0xBCE7
        if (CarryFlag)
        {
            goto label_100D_BCE7_1BDB7_19611;
        }
    label_100D_BCE5_1BDB5_37350:
        CheckExternalEvents(cs1, 0xBCE5);
        // 100D:BCE5 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
    label_100D_BCE7_1BDB7_19611:
        CheckExternalEvents(cs1, 0xBCE7);
        // 100D:BCE7 mov word ptr DS:[SI],AX
        UInt16[DS, SI] = AX;
        // 100D:BCE9 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:BCEC add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:BCEF sar DX,1
        DX = Alu16.Sar(DX, 1);
        // 100D:BCF1 loop 0xBCDD
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BCDD_1BDAD_19607;
        }
    label_100D_BCF3_1BDC3_19618:
        CheckExternalEvents(cs1, 0xBCF3);
        // 100D:BCF3 mov SI,0xDD06
        SI = (ushort)0xDD06;
        // 100D:BCF6 call near 0xC551
        NearCall(cs1, 0xBCF9, unknown_100D_C551_1C621);
    label_100D_BCF9_1BDC9_19621:
        CheckExternalEvents(cs1, 0xBCF9);
        // 100D:BCF9 call near 0xBD00
        NearCall(cs1, 0xBCFC, unknown_100D_BD00_1BDD0);
    label_100D_BCFC_1BDCC_19705:
        CheckExternalEvents(cs1, 0xBCFC);
        // 100D:BCFC pop CX
        CX = Stack.Pop16();
        // 100D:BCFD loop 0xBCB4
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BCB4_1BD84_19588;
        }
    label_100D_BCFF_1BDCF_19710:
        CheckExternalEvents(cs1, 0xBCFF);
        // 100D:BCFF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_BD00_1BDD0(int loadOffset)
    {
    label_100D_BD00_1BDD0_19623:
        CheckExternalEvents(cs1, 0xBD00);
        // 100D:BD00 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:BD02 mov CX,0x000A
        CX = (ushort)0x000A;
        // 100D:BD05 mov SI,0xDD06
        SI = (ushort)0xDD06;
        // 100D:BD08 inc word ptr DS:[SI]
        UInt16[DS, SI] = Alu16.Inc(UInt16[DS, SI]);
        // 100D:BD0A inc word ptr DS:[SI+2]
        UInt16[DS, (ushort)(SI + (sbyte)2)] = Alu16.Inc(UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:BD0D dec word ptr DS:[SI+4]
        UInt16[DS, (ushort)(SI + (sbyte)4)] = Alu16.Dec(UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:BD10 dec word ptr DS:[SI+6]
        UInt16[DS, (ushort)(SI + (sbyte)6)] = Alu16.Dec(UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:BD13 call near 0xC0D5
        NearCall(cs1, 0xBD16, blit_fb1_to_screen_effect);
    label_100D_BD16_1BDE6_19698:
        CheckExternalEvents(cs1, 0xBD16);
        // 100D:BD16 mov SI,0xDD06
        SI = (ushort)0xDD06;
        // 100D:BD19 dec word ptr DS:[SI]
        UInt16[DS, SI] = Alu16.Dec(UInt16[DS, SI]);
        // 100D:BD1B dec word ptr DS:[SI+2]
        UInt16[DS, (ushort)(SI + (sbyte)2)] = Alu16.Dec(UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:BD1E inc word ptr DS:[SI+4]
        UInt16[DS, (ushort)(SI + (sbyte)4)] = Alu16.Inc(UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:BD21 inc word ptr DS:[SI+6]
        UInt16[DS, (ushort)(SI + (sbyte)6)] = Alu16.Inc(UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:BD24 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action pick_map_position(int loadOffset)
    {
    label_100D_BD25_1BDF5_36815:
        CheckExternalEvents(cs1, 0xBD25);
        // 100D:BD25 sub BX,0x0036
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)54)));
        // 100D:BD28 mov CX,BX
        CX = BX;
        // 100D:BD2A jns short 0xBD2E
        if (!SignFlag)
        {
            goto label_100D_BD2E_1BDFE_36821;
        }
    label_100D_BD2C_1BDFC_36819:
        CheckExternalEvents(cs1, 0xBD2C);
        // 100D:BD2C neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_BD2E_1BDFE_36821:
        CheckExternalEvents(cs1, 0xBD2E);
        // 100D:BD2E push DS
        Stack.Push16(DS);
        // 100D:BD2F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:BD30 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:BD33 inc CX
        CX = Alu16.Inc(CX);
        // 100D:BD34 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_BD36_1BE06_36826:
        CheckExternalEvents(cs1, 0xBD36);
        // 100D:BD36 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:BD38 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:BD39 inc AL
        AL = Alu8.Inc(AL);
        // 100D:BD3B neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
        // 100D:BD3D loopne 0xBD36
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_100D_BD36_1BE06_36826;
        }
    label_100D_BD3F_1BE0F_36832:
        CheckExternalEvents(cs1, 0xBD3F);
        // 100D:BD3F mov DI,SI
        DI = SI;
        // 100D:BD41 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 100D:BD43 sub DX,0x0040
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)64)));
        // 100D:BD46 mov AX,DX
        AX = DX;
        // 100D:BD48 jns short 0xBD4C
        if (!SignFlag)
        {
            goto label_100D_BD4C_1BE1C_36840;
        }
    label_100D_BD4A_1BE1A_36838:
        CheckExternalEvents(cs1, 0xBD4A);
        // 100D:BD4A neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_BD4C_1BE1C_36840:
        CheckExternalEvents(cs1, 0xBD4C);
        // 100D:BD4C add SI,DX
        SI = Alu16.Add(SI, DX);
        // 100D:BD4E cmp SI,DI
        Alu16.Sub(SI, DI);
        // 100D:BD50 jae short 0xBDBA
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:BD50");
        }
    label_100D_BD52_1BE22_36843:
        CheckExternalEvents(cs1, 0xBD52);
        // 100D:BD52 push AX
        Stack.Push16(AX);
        // 100D:BD53 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:BD54 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:BD56 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:BD58 js short 0xBD5C
        if (SignFlag)
        {
            goto label_100D_BD5C_1BE2C_36849;
        }
    label_100D_BD5A_1BE2A_37345:
        CheckExternalEvents(cs1, 0xBD5A);
        // 100D:BD5A neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_BD5C_1BE2C_36849:
        CheckExternalEvents(cs1, 0xBD5C);
        // 100D:BD5C mov SI,0x8C3B
        SI = (ushort)0x8C3B;
        // 100D:BD5F add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:BD61 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:BD63 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:BD64 push AX
        Stack.Push16(AX);
        // 100D:BD65 mov SI,0x593A
        SI = (ushort)0x593A;
        // 100D:BD68 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:BD69 mov BP,AX
        BP = AX;
        // 100D:BD6B or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:BD6D jns short 0xBD71
        if (!SignFlag)
        {
            goto label_100D_BD71_1BE41_36862;
        }
    label_100D_BD6F_1BE3F_36860:
        CheckExternalEvents(cs1, 0xBD6F);
        // 100D:BD6F neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_BD71_1BE41_36862:
        CheckExternalEvents(cs1, 0xBD71);
        // 100D:BD71 mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 100D:BD74 mul DX
        uint result_100D_BD74_1BE44 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_BD74_1BE44 >> 16));
        AX = unchecked((ushort)result_100D_BD74_1BE44);
        // 100D:BD76 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:BD78 mov BL,byte ptr SS:[BP+SI]
        BL = UInt8[SS, (ushort)(BP + SI)];
        // 100D:BD7A mov AL,byte ptr SS:[BP+SI+0x64]
        AL = UInt8[SS, (ushort)(BP + SI + (sbyte)100)];
        // 100D:BD7D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:BD7F xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:BD81 mov DI,BX
        DI = BX;
        // 100D:BD83 add DI,DI
        DI = Alu16.Add(DI, DI);
        // 100D:BD85 add DI,DI
        DI = Alu16.Add(DI, DI);
        // 100D:BD87 mov CX,word ptr DS:[DI+0x494A]
        CX = UInt16[DS, (ushort)(DI + (short)18762)];
        // 100D:BD8B pop DX
        DX = Stack.Pop16();
        // 100D:BD8C or DH,DH
        DH = Alu8.Or(DH, DH);
        // 100D:BD8E jns short 0xBD92
        if (!SignFlag)
        {
            goto label_100D_BD92_1BE62_36878;
        }
    label_100D_BD90_1BE60_36876:
        CheckExternalEvents(cs1, 0xBD90);
        // 100D:BD90 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_BD92_1BE62_36878:
        CheckExternalEvents(cs1, 0xBD92);
        // 100D:BD92 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:BD94 jns short 0xBD9A
        if (!SignFlag)
        {
            goto label_100D_BD9A_1BE6A_36883;
        }
    label_100D_BD96_1BE66_36880:
        CheckExternalEvents(cs1, 0xBD96);
        // 100D:BD96 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:BD98 add AX,CX
        AX = Alu16.Add(AX, CX);
    label_100D_BD9A_1BE6A_36883:
        CheckExternalEvents(cs1, 0xBD9A);
        // 100D:BD9A add CX,CX
        CX = Alu16.Add(CX, CX);
        // 100D:BD9C mov DX,word ptr DS:[DI+0x494C]
        DX = UInt16[DS, (ushort)(DI + (short)18764)];
        // 100D:BDA0 pop DI
        DI = Stack.Pop16();
        // 100D:BDA1 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:BDA3 jns short 0xBDA7
        if (!SignFlag)
        {
            goto label_100D_BDA7_1BE77_36890;
        }
    label_100D_BDA5_1BE75_36888:
        CheckExternalEvents(cs1, 0xBDA5);
        // 100D:BDA5 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_BDA7_1BE77_36890:
        CheckExternalEvents(cs1, 0xBDA7);
        // 100D:BDA7 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:BDA9 jns short 0xBDAD
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:BDA9");
        }
    label_100D_BDAD_1BE7D_36892:
        CheckExternalEvents(cs1, 0xBDAD);
        // 100D:BDAD cmp DX,CX
        Alu16.Sub(DX, CX);
        // 100D:BDAF jb short 0xBDB3
        if (CarryFlag)
        {
            goto label_100D_BDB3_1BE83_36895;
        }
    label_100D_BDB1_1BE81_37348:
        CheckExternalEvents(cs1, 0xBDB1);
        // 100D:BDB1 sub DX,CX
        DX = Alu16.Sub(DX, CX);
    label_100D_BDB3_1BE83_36895:
        CheckExternalEvents(cs1, 0xBDB3);
        // 100D:BDB3 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:BDB5 div CX
        ushort divisor_100D_BDB5_1BE85 = CX;
        uint dividend_100D_BDB5_1BE85 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_BDB5_1BE85 = Alu16.Div(unchecked((uint)dividend_100D_BDB5_1BE85), unchecked((ushort)divisor_100D_BDB5_1BE85));
        AX = unchecked((ushort)quotient_100D_BDB5_1BE85);
        DX = unchecked((ushort)(dividend_100D_BDB5_1BE85 % unchecked((uint)divisor_100D_BDB5_1BE85)));
        // 100D:BDB7 sar BX,1
        BX = Alu16.Sar(BX, 1);
        // 100D:BDB9 stc
        CarryFlag = true;
        // 100D:BDBA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_BDBB_1BE8B(int loadOffset)
    {
    label_100D_BDBB_1BE8B_36920:
        CheckExternalEvents(cs1, 0xBDBB);
        // 100D:BDBB cmp word ptr DS:[0xDD0F],0
        Alu16.Sub(UInt16[DS, (ushort)0xDD0F], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:BDC0 je short 0xBDF9
        if (ZeroFlag)
        {
            goto label_100D_BDF9_1BEC9_36923;
        }
    label_100D_BDC2_1BE92_36966:
        CheckExternalEvents(cs1, 0xBDC2);
        // 100D:BDC2 call near 0xC08E
        NearCall(cs1, 0xBDC5, set_screen_as_active_framebuffer);
    label_100D_BDC5_1BE95_36969:
        CheckExternalEvents(cs1, 0xBDC5);
        // 100D:BDC5 call near 0xDBB2
        NearCall(cs1, 0xBDC8, call_restore_cursor);
    label_100D_BDC8_1BE98_36972:
        CheckExternalEvents(cs1, 0xBDC8);
        // 100D:BDC8 call near 0xBDFA
        NearCall(cs1, 0xBDCB, ui_stats_draw_ingame_day_and_charisma);
    label_100D_BDCB_1BE9B_36975:
        CheckExternalEvents(cs1, 0xBDCB);
        // 100D:BDCB call near 0xBED7
        NearCall(cs1, 0xBDCE, results_update_gauge_targets);
    label_100D_BDCE_1BE9E_36978:
        CheckExternalEvents(cs1, 0xBDCE);
        // 100D:BDCE mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:BDD1 and AX,0xFFF0
        AX = Alu16.And(AX, (ushort)0xFFF0);
        // 100D:BDD4 mov word ptr DS:[0x115C],AX
        UInt16[DS, (ushort)0x115C] = AX;
        // 100D:BDD7 call near 0xD075
        NearCall(cs1, 0xBDDA, font_select_small_font);
    label_100D_BDDA_1BEAA_36987:
        CheckExternalEvents(cs1, 0xBDDA);
        // 100D:BDDA mov SI,0x2494
        SI = (ushort)0x2494;
        // 100D:BDDD call near 0xD1A6
        NearCall(cs1, 0xBDE0, unknown_100D_D1A6_1D276);
    label_100D_BDE0_1BEB0_36992:
        CheckExternalEvents(cs1, 0xBDE0);
        // 100D:BDE0 mov SI,0xDD11
        SI = (ushort)0xDD11;
        // 100D:BDE3 mov DI,0xDD17
        DI = (ushort)0xDD17;
        // 100D:BDE6 push DS
        Stack.Push16(DS);
        // 100D:BDE7 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:BDE8 mov CX,6
        CX = (ushort)0x0006;
    label_100D_BDEB_1BEBB_36998:
        CheckExternalEvents(cs1, 0xBDEB);
        // 100D:BDEB cmps byte ptr DS:[SI],byte ptr ES:[DI]
        Alu8.Sub(UInt8[DS, SI], UInt8[ES, DI]);
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:BDEC loopne 0xBDEB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_100D_BDEB_1BEBB_36998;
        }
    label_100D_BDEE_1BEBE_37002:
        CheckExternalEvents(cs1, 0xBDEE);
        // 100D:BDEE jne short 0xBDF9
        if (!ZeroFlag)
        {
            goto label_100D_BDF9_1BEC9_36923;
        }
    label_100D_BDF0_1BEC0_37005:
        CheckExternalEvents(cs1, 0xBDF0);
        // 100D:BDF0 dec byte ptr DS:[DI-1]
        UInt8[DS, (ushort)(DI + (sbyte)-1)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (sbyte)-1)]);
        // 100D:BDF3 inc CX
        CX = Alu16.Inc(CX);
        // 100D:BDF4 loop 0xBDEB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BDEB_1BEBB_36998;
        }
    label_100D_BDF6_1BEC6_37010:
        CheckExternalEvents(cs1, 0xBDF6);
        // 100D:BDF6 call near 0xDBEC
        NearCall(cs1, 0xBDF9, draw_mouse);
    label_100D_BDF9_1BEC9_36923:
        CheckExternalEvents(cs1, 0xBDF9);
        // 100D:BDF9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action ui_stats_draw_ingame_day_and_charisma(int loadOffset)
    {
    label_100D_BDFA_1BECA_19076:
        CheckExternalEvents(cs1, 0xBDFA);
        // 100D:BDFA mov SI,0x00C2
        SI = (ushort)0x00C2;
        // 100D:BDFD call near 0x1AD1
        NearCall(cs1, 0xBE00, get_ingame_day_in_ax);
    label_100D_BE00_1BED0_19079:
        CheckExternalEvents(cs1, 0xBE00);
        // 100D:BE00 inc AX
        AX = Alu16.Inc(AX);
        // 100D:BE01 call near 0xE2DB
        NearCall(cs1, 0xBE04, unknown_100D_E2DB_1E3AB);
    label_100D_BE04_1BED4_19089:
        CheckExternalEvents(cs1, 0xBE04);
        // 100D:BE04 call near 0xBFA7
        NearCall(cs1, 0xBE07, string_update_ordinal_suffix);
    label_100D_BE07_1BED7_19119:
        CheckExternalEvents(cs1, 0xBE07);
        // 100D:BE07 mov AL,byte ptr DS:[0x0029]
        AL = UInt8[DS, (ushort)0x0029];
        // 100D:BE0A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:BE0C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:BE0E mov SI,0x00C3
        SI = (ushort)0x00C3;
        // 100D:BE11 call near 0xE2DB
        NearCall(cs1, 0xBE14, unknown_100D_E2DB_1E3AB);
    label_100D_BE14_1BEE4_19125:
        CheckExternalEvents(cs1, 0xBE14);
        // 100D:BE14 call near 0xD068
        NearCall(cs1, 0xBE17, font_select_tall_font);
    label_100D_BE17_1BEE7_19127:
        CheckExternalEvents(cs1, 0xBE17);
        // 100D:BE17 mov SI,0x2482
        SI = (ushort)0x2482;
        // 100D:BE1A jmp near 0xD1A6
        return unknown_100D_D1A6_1D276(0x0000);
    }
}
