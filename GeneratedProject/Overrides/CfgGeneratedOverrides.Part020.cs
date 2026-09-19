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
    public virtual Action unknown_100D_C4F0_1C5C0(int loadOffset)
    {
    label_100D_C4F0_1C5C0_8262:
        CheckExternalEvents(cs1, 0xC4F0);
        // 100D:C4F0 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C4F2 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C4F5 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C4F8 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        return unknown_100D_C4FB_1C5CB(0x0000);
    }

    public virtual Action unknown_100D_C4FB_1C5CB(int loadOffset)
    {
    label_100D_C4FB_1C5CB_8267:
        CheckExternalEvents(cs1, 0xC4FB);
        // 100D:C4FB cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:C500 jne short 0xC51E
        if (!ZeroFlag)
        {
            return unknown_100D_C51E_1C5EE(0x0000);
        }
    label_100D_C502_1C5D2_14553:
        CheckExternalEvents(cs1, 0xC502);
        // 100D:C502 cmp AX,0x0089
        Alu16.Sub(AX, (ushort)0x0089);
        // 100D:C505 jl short 0xC51E
        if (SignFlag != OverflowFlag)
        {
            return unknown_100D_C51E_1C5EE(0x0000);
        }
    label_100D_C507_1C5D7_14556:
        CheckExternalEvents(cs1, 0xC507);
        // 100D:C507 cmp BP,0x007E
        Alu16.Sub(BP, (ushort)0x007E);
        // 100D:C50B jl short 0xC51E
        if (SignFlag != OverflowFlag)
        {
            return unknown_100D_C51E_1C5EE(0x0000);
        }
    label_100D_C50D_1C5DD_14559:
        CheckExternalEvents(cs1, 0xC50D);
        // 100D:C50D cmp DX,0x00C2
        Alu16.Sub(DX, (ushort)0x00C2);
        // 100D:C511 jge short 0xC51E
        if (SignFlag == OverflowFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C511");
        }
    label_100D_C513_1C5E3_14562:
        CheckExternalEvents(cs1, 0xC513);
        // 100D:C513 push AX
        Stack.Push16(AX);
        // 100D:C514 push BX
        Stack.Push16(BX);
        // 100D:C515 push DX
        Stack.Push16(DX);
        // 100D:C516 push BP
        Stack.Push16(BP);
        // 100D:C517 call near 0x1797
        NearCall(cs1, 0xC51A, unknown_100D_1797_11867);
    label_100D_C51A_1C5EA_14568:
        CheckExternalEvents(cs1, 0xC51A);
        // 100D:C51A pop BP
        BP = Stack.Pop16();
        // 100D:C51B pop DX
        DX = Stack.Pop16();
        // 100D:C51C pop BX
        BX = Stack.Pop16();
        // 100D:C51D pop AX
        AX = Stack.Pop16();
        return unknown_100D_C51E_1C5EE(0x0000);
    }

    public virtual Action unknown_100D_C51E_1C5EE(int loadOffset)
    {
    label_100D_C51E_1C5EE_8269:
        CheckExternalEvents(cs1, 0xC51E);
        // 100D:C51E sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:C520 jbe short 0xC53D
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C520");
        }
    label_100D_C522_1C5F2_8272:
        CheckExternalEvents(cs1, 0xC522);
        // 100D:C522 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C524 jbe short 0xC53D
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C524");
        }
        else
        {
            return unknown_100D_C526_1C5F6(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_C53E_1C60E(int loadOffset)
    {
    label_100D_C53E_1C60E_16765:
        CheckExternalEvents(cs1, 0xC53E);
        // 100D:C53E mov SI,0x276A
        SI = (ushort)0x276A;
        // 100D:C541 mov BP,word ptr DS:[0x2772]
        BP = UInt16[DS, (ushort)0x2772];
        // 100D:C545 mov AL,byte ptr DS:[0xDBE4]
        AL = UInt8[DS, (ushort)0xDBE4];
        // 100D:C548 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:C54C call far dword ptr DS:[0x3901]
        ushort targetSegment_16770 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3901 + (ushort)0x0002)]));
        ushort targetOffset_16770 = unchecked((ushort)(UInt16[DS, (ushort)0x3901]));
        if (targetSegment_16770 == cs2 && targetOffset_16770 == 0x0139)
        {
            FarCall(cs1, 0xC550, cs2, unknown_3358_0139_336B9);
            goto label_100D_C550_1C620_16771;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_16770:X4}:{targetOffset_16770:X4} at 100D:C54C");
    label_100D_C550_1C620_16771:
        CheckExternalEvents(cs1, 0xC550);
        // 100D:C550 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C551_1C621(int loadOffset)
    {
    label_100D_C551_1C621_16746:
        CheckExternalEvents(cs1, 0xC551);
        // 100D:C551 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C552 mov DX,AX
        DX = AX;
        // 100D:C554 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C555 mov BX,AX
        BX = AX;
        // 100D:C557 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C558 mov DI,AX
        DI = AX;
        // 100D:C55A dec DI
        DI = Alu16.Dec(DI);
        // 100D:C55B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C55C mov CX,AX
        CX = AX;
        // 100D:C55E dec CX
        CX = Alu16.Dec(CX);
        // 100D:C55F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        return unknown_100D_C560_1C630(0x0000);
    }

    public virtual Action unknown_100D_C560_1C630(int loadOffset)
    {
    label_100D_C560_1C630_16758:
        CheckExternalEvents(cs1, 0xC560);
        // 100D:C560 mov byte ptr DS:[0xDBE4],AL
        UInt8[DS, (ushort)0xDBE4] = AL;
        // 100D:C563 push BX
        Stack.Push16(BX);
        // 100D:C564 push CX
        Stack.Push16(CX);
        // 100D:C565 push DX
        Stack.Push16(DX);
        // 100D:C566 push DI
        Stack.Push16(DI);
        // 100D:C567 mov CX,BX
        CX = BX;
        // 100D:C569 call near 0xC53E
        NearCall(cs1, 0xC56C, unknown_100D_C53E_1C60E);
    label_100D_C56C_1C63C_16773:
        CheckExternalEvents(cs1, 0xC56C);
        // 100D:C56C mov BP,SP
        BP = SP;
        // 100D:C56E mov CX,word ptr SS:[BP+4]
        CX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:C571 mov BX,CX
        BX = CX;
        // 100D:C573 call near 0xC53E
        NearCall(cs1, 0xC576, unknown_100D_C53E_1C60E);
    label_100D_C576_1C646_16778:
        CheckExternalEvents(cs1, 0xC576);
        // 100D:C576 mov BP,SP
        BP = SP;
        // 100D:C578 mov DI,DX
        DI = DX;
        // 100D:C57A mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:C57D call near 0xC53E
        NearCall(cs1, 0xC580, unknown_100D_C53E_1C60E);
    label_100D_C580_1C650_16824:
        CheckExternalEvents(cs1, 0xC580);
        // 100D:C580 pop DI
        DI = Stack.Pop16();
        // 100D:C581 mov DX,DI
        DX = DI;
        // 100D:C583 call near 0xC53E
        NearCall(cs1, 0xC586, unknown_100D_C53E_1C60E);
    label_100D_C586_1C656_16828:
        CheckExternalEvents(cs1, 0xC586);
        // 100D:C586 pop DX
        DX = Stack.Pop16();
        // 100D:C587 pop CX
        CX = Stack.Pop16();
        // 100D:C588 pop BX
        BX = Stack.Pop16();
        // 100D:C589 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C58A_1C65A(int loadOffset)
    {
    entrydispatcher:
    label_100D_C58A_1C65A_10780:
        CheckExternalEvents(cs1, 0xC58A);
        // 100D:C58A call near 0xC13B
        NearCall(cs1, 0xC58D, unknown_100D_C13B_1C20B);
    label_100D_C58D_1C65D_10782:
        CheckExternalEvents(cs1, 0xC58D);
        // 100D:C58D mov SI,0x3CBE
        SI = (ushort)0x3CBE;
        // 100D:C590 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C591 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:C593 je short 0xC5CE
        if (ZeroFlag)
        {
            goto label_100D_C5CE_1C69E_10821;
        }
    label_100D_C595_1C665_10787:
        CheckExternalEvents(cs1, 0xC595);
        // 100D:C595 mov AH,0x11
        AH = (byte)0x11;
        // 100D:C597 mul AH
        ushort result_100D_C597_1C667 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_C597_1C667 >> 8));
        AL = unchecked((byte)result_100D_C597_1C667);
        // 100D:C599 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:C59B cmp DI,SI
        Alu16.Sub(DI, SI);
        // 100D:C59D jae short 0xC5CE
        if (!CarryFlag)
        {
            goto label_100D_C5CE_1C69E_10821;
        }
    label_100D_C59F_1C66F_10793:
        CheckExternalEvents(cs1, 0xC59F);
        // 100D:C59F or byte ptr DS:[DI+0x0C],0x80
        UInt8[DS, (ushort)(DI + (sbyte)12)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x80);
        // 100D:C5A3 push SI
        Stack.Push16(SI);
        // 100D:C5A4 push DI
        Stack.Push16(DI);
        // 100D:C5A5 mov SI,DI
        SI = DI;
        // 100D:C5A7 call near 0xC6AD
        NearCall(cs1, 0xC5AA, unknown_100D_C6AD_1C77D);
    label_100D_C5AA_1C67A_10800:
        CheckExternalEvents(cs1, 0xC5AA);
        // 100D:C5AA pop DI
        DI = Stack.Pop16();
        // 100D:C5AB pop CX
        CX = Stack.Pop16();
        // 100D:C5AC push DI
        Stack.Push16(DI);
        // 100D:C5AD lea SI,DI+0x11
        SI = unchecked((ushort)(DI + (sbyte)17));
        // 100D:C5B0 sub CX,SI
        CX = Alu16.Sub(CX, SI);
        // 100D:C5B2 je short 0xC5B8
        if (ZeroFlag)
        {
            goto label_100D_C5B8_1C688_10811;
        }
    label_100D_C5B4_1C684_10807:
        CheckExternalEvents(cs1, 0xC5B4);
        // 100D:C5B4 push DS
        Stack.Push16(DS);
        // 100D:C5B5 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C5B6 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_100D_C5B8_1C688_10811:
        CheckExternalEvents(cs1, 0xC5B8);
        // 100D:C5B8 dec word ptr DS:[0x3CBE]
        UInt16[DS, (ushort)0x3CBE] = Alu16.Dec(UInt16[DS, (ushort)0x3CBE]);
        // 100D:C5BC pop DI
        DI = Stack.Pop16();
        // 100D:C5BD mov SI,0x4752
        SI = (ushort)0x4752;
        // 100D:C5C0 mov CX,2
        CX = (ushort)0x0002;
    label_100D_C5C3_1C693_10815:
        CheckExternalEvents(cs1, 0xC5C3);
        // 100D:C5C3 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C5C4 cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:C5C6 jb short 0xC5CC
        if (CarryFlag)
        {
            goto label_100D_C5CC_1C69C_10818;
        }
    label_100D_C5C8_1C698_24632:
        CheckExternalEvents(cs1, 0xC5C8);
        // 100D:C5C8 sub word ptr DS:[SI-2],0x0011
        UInt16[DS, (ushort)(SI + (sbyte)-2)] = Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)-2)], unchecked((ushort)unchecked((short)(sbyte)17)));
    label_100D_C5CC_1C69C_10818:
        CheckExternalEvents(cs1, 0xC5CC);
        // 100D:C5CC loop 0xC5C3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_C5C3_1C693_10815;
        }
    label_100D_C5CE_1C69E_10821:
        CheckExternalEvents(cs1, 0xC5CE);
        // 100D:C5CE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C5CF_1C69F(int loadOffset)
    {
    label_100D_C5CF_1C69F_23527:
        CheckExternalEvents(cs1, 0xC5CF);
        // 100D:C5CF xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C5D1 mov AL,byte ptr SS:[BP]
        AL = UInt8[SS, (ushort)(BP + (sbyte)0)];
        // 100D:C5D4 cmp byte ptr SS:[BP+3],0
        Alu8.Sub(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0x00);
        // 100D:C5D8 je short 0xC60B
        if (ZeroFlag)
        {
            return unknown_100D_C60B_1C6DB(0x0000);
        }
    label_100D_C5DA_1C6AA_23671:
        CheckExternalEvents(cs1, 0xC5DA);
        // 100D:C5DA push BP
        Stack.Push16(BP);
        // 100D:C5DB call near 0xC60B
        NearCall(cs1, 0xC5DE, unknown_100D_C60B_1C6DB);
    label_100D_C5DE_1C6AE_23674:
        CheckExternalEvents(cs1, 0xC5DE);
        // 100D:C5DE pop BP
        BP = Stack.Pop16();
        // 100D:C5DF mov word ptr DS:[DI+0x0F],BP
        UInt16[DS, (ushort)(DI + (sbyte)15)] = BP;
        // 100D:C5E2 push SI
        Stack.Push16(SI);
        // 100D:C5E3 mov SI,BP
        SI = BP;
        // 100D:C5E5 mov BX,0xFFFF
        BX = (ushort)0xFFFF;
    label_100D_C5E8_1C6B8_23680:
        CheckExternalEvents(cs1, 0xC5E8);
        // 100D:C5E8 inc BX
        BX = Alu16.Inc(BX);
        // 100D:C5E9 js short 0xC609
        if (SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C5E9");
        }
    label_100D_C5EB_1C6BB_23682:
        CheckExternalEvents(cs1, 0xC5EB);
        // 100D:C5EB add SI,3
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 100D:C5EE cmp byte ptr DS:[SI],0
        Alu8.Sub(UInt8[DS, SI], (byte)0x00);
        // 100D:C5F1 jne short 0xC5E8
        if (!ZeroFlag)
        {
            goto label_100D_C5E8_1C6B8_23680;
        }
    label_100D_C5F3_1C6C3_23687:
        CheckExternalEvents(cs1, 0xC5F3);
        // 100D:C5F3 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:C5F5 je short 0xC609
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C5F5");
        }
    label_100D_C5F7_1C6C7_23690:
        CheckExternalEvents(cs1, 0xC5F7);
        // 100D:C5F7 call near 0xE3DF
        NearCall(cs1, 0xC5FA, unknown_100D_E3DF_1E4AF);
    label_100D_C5FA_1C6CA_23720:
        CheckExternalEvents(cs1, 0xC5FA);
        // 100D:C5FA mov BX,AX
        BX = AX;
        // 100D:C5FC shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:C5FE add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:C600 add BP,AX
        BP = Alu16.Add(BP, AX);
        // 100D:C602 mov word ptr DS:[DI+0x0D],BP
        UInt16[DS, (ushort)(DI + (sbyte)13)] = BP;
        // 100D:C605 or byte ptr DS:[DI+0x0C],1
        UInt8[DS, (ushort)(DI + (sbyte)12)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x01);
        // 100D:C609 pop SI
        SI = Stack.Pop16();
        // 100D:C60A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C60B_1C6DB(int loadOffset)
    {
    label_100D_C60B_1C6DB_10475:
        CheckExternalEvents(cs1, 0xC60B);
        // 100D:C60B push AX
        Stack.Push16(AX);
        // 100D:C60C call near 0xC13B
        NearCall(cs1, 0xC60F, unknown_100D_C13B_1C20B);
    label_100D_C60F_1C6DF_10478:
        CheckExternalEvents(cs1, 0xC60F);
        // 100D:C60F pop AX
        AX = Stack.Pop16();
        // 100D:C610 call near 0xC202
        NearCall(cs1, 0xC613, unknown_100D_C202_1C2D2);
    label_100D_C613_1C6E3_10497:
        CheckExternalEvents(cs1, 0xC613);
        // 100D:C613 push SI
        Stack.Push16(SI);
        // 100D:C614 mov DI,0x3CBE
        DI = (ushort)0x3CBE;
        // 100D:C617 mov BP,AX
        BP = AX;
        // 100D:C619 mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 100D:C61B inc word ptr DS:[DI]
        UInt16[DS, DI] = Alu16.Inc(UInt16[DS, DI]);
        // 100D:C61D mov AH,0x11
        AH = (byte)0x11;
        // 100D:C61F mul AH
        ushort result_100D_C61F_1C6EF = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_C61F_1C6EF >> 8));
        AL = unchecked((byte)result_100D_C61F_1C6EF);
        // 100D:C621 xchg BP,AX
        ushort temp_100D_C621_1C6F1 = BP;
        BP = AX;
        AX = unchecked((ushort)temp_100D_C621_1C6F1);
        // 100D:C622 lea DI,BP+DI+2
        DI = unchecked((ushort)(BP + DI + (sbyte)2));
        // 100D:C625 mov word ptr DS:[DI],DX
        UInt16[DS, DI] = DX;
        // 100D:C627 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:C62A mov word ptr DS:[DI+8],AX
        UInt16[DS, (ushort)(DI + (sbyte)8)] = AX;
        // 100D:C62D mov word ptr DS:[DI+0x0A],SI
        UInt16[DS, (ushort)(DI + (sbyte)10)] = SI;
        // 100D:C630 mov byte ptr DS:[DI+0x0C],0
        UInt8[DS, (ushort)(DI + (sbyte)12)] = (byte)0x00;
        // 100D:C634 call near 0xC1F4
        NearCall(cs1, 0xC637, unknown_100D_C1F4_1C2C4);
    label_100D_C637_1C707_10513:
        CheckExternalEvents(cs1, 0xC637);
        // 100D:C637 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C639 and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:C63C add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:C63E add BL,byte ptr ES:[SI]
        BL = Alu8.Add(BL, UInt8[ES, SI]);
        // 100D:C641 adc BH,0
        BH = Alu8.Adc(BH, (byte)0x00);
        // 100D:C644 mov word ptr DS:[DI+4],DX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = DX;
        // 100D:C647 mov word ptr DS:[DI+6],BX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = BX;
        // 100D:C64A pop SI
        SI = Stack.Pop16();
        // 100D:C64B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C661_1C731(int loadOffset)
    {
    entrydispatcher:
    label_100D_C661_1C731_10553:
        CheckExternalEvents(cs1, 0xC661);
        // 100D:C661 call near 0xC13B
        NearCall(cs1, 0xC664, unknown_100D_C13B_1C20B);
    label_100D_C664_1C734_10555:
        CheckExternalEvents(cs1, 0xC664);
        // 100D:C664 mov SI,DI
        SI = DI;
        // 100D:C666 sub SP,8
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:C669 mov DI,SP
        DI = SP;
        // 100D:C66B push DS
        Stack.Push16(DS);
        // 100D:C66C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C66D movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C66E movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C66F movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C670 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C671 sub SI,8
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:C674 sub DI,8
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:C677 add word ptr DS:[SI],DX
        UInt16[DS, SI] = Alu16.Add(UInt16[DS, SI], DX);
        // 100D:C679 add word ptr DS:[SI+2],BX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)2)], BX);
        // 100D:C67C add word ptr DS:[SI+4],DX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)4)], DX);
        // 100D:C67F add word ptr DS:[SI+6],BX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)6)], BX);
        // 100D:C682 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:C684 js short 0xC68E
        if (SignFlag)
        {
            goto label_100D_C68E_1C75E_10827;
        }
    label_100D_C686_1C756_10573:
        CheckExternalEvents(cs1, 0xC686);
        // 100D:C686 mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C689 mov word ptr DS:[DI+4],AX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = AX;
        // 100D:C68C jmp short 0xC692
        goto label_100D_C692_1C762_10577;
    label_100D_C68E_1C75E_10827:
        CheckExternalEvents(cs1, 0xC68E);
        // 100D:C68E mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:C690 mov word ptr DS:[DI],AX
        UInt16[DS, DI] = AX;
    label_100D_C692_1C762_10577:
        CheckExternalEvents(cs1, 0xC692);
        // 100D:C692 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:C694 js short 0xC69E
        if (SignFlag)
        {
            goto label_100D_C69E_1C76E_10580;
        }
    label_100D_C696_1C766_10892:
        CheckExternalEvents(cs1, 0xC696);
        // 100D:C696 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C699 mov word ptr DS:[DI+6],AX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = AX;
        // 100D:C69C jmp short 0xC6A4
        goto label_100D_C6A4_1C774_10583;
    label_100D_C69E_1C76E_10580:
        CheckExternalEvents(cs1, 0xC69E);
        // 100D:C69E mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C6A1 mov word ptr DS:[DI+2],AX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = AX;
    label_100D_C6A4_1C774_10583:
        CheckExternalEvents(cs1, 0xC6A4);
        // 100D:C6A4 mov SI,DI
        SI = DI;
        // 100D:C6A6 call near 0xC6AD
        NearCall(cs1, 0xC6A9, unknown_100D_C6AD_1C77D);
    label_100D_C6A9_1C779_10709:
        CheckExternalEvents(cs1, 0xC6A9);
        // 100D:C6A9 add SP,8
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)8)));
        if (JumpDispatcher.Jump(unknown_100D_C6AC_1C77C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_C6AD_1C77D(int loadOffset)
    {
    entrydispatcher:
    label_100D_C6AD_1C77D_10585:
        CheckExternalEvents(cs1, 0xC6AD);
        // 100D:C6AD call near 0xC13B
        NearCall(cs1, 0xC6B0, unknown_100D_C13B_1C20B);
    label_100D_C6B0_1C780_10587:
        CheckExternalEvents(cs1, 0xC6B0);
        // 100D:C6B0 cmp byte ptr DS:[0xDC46],0
        Alu8.Sub(UInt8[DS, (ushort)0xDC46], (byte)0x00);
        // 100D:C6B5 js short 0xC6E4
        if (SignFlag)
        {
            goto label_100D_C6E4_1C7B4_10590;
        }
    label_100D_C6B7_1C787_24512:
        CheckExternalEvents(cs1, 0xC6B7);
        // 100D:C6B7 mov AX,word ptr DS:[0xDC44]
        AX = UInt16[DS, (ushort)0xDC44];
        // 100D:C6BA cmp AX,word ptr DS:[SI+6]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:C6BD jge short 0xC6E4
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C6E4_1C7B4_10590;
        }
    label_100D_C6BF_1C78F_27709:
        CheckExternalEvents(cs1, 0xC6BF);
        // 100D:C6BF add AX,0x0010
        AX = Alu16.Add(AX, (ushort)0x0010);
        // 100D:C6C2 cmp AX,word ptr DS:[SI+2]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:C6C5 jle short 0xC6E4
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C6E4_1C7B4_10590;
        }
    label_100D_C6C7_1C797_27713:
        CheckExternalEvents(cs1, 0xC6C7);
        // 100D:C6C7 mov AX,word ptr DS:[0xDC42]
        AX = UInt16[DS, (ushort)0xDC42];
        // 100D:C6CA cmp AX,word ptr DS:[SI+4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:C6CD jge short 0xC6E4
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C6E4_1C7B4_10590;
        }
    label_100D_C6CF_1C79F_27717:
        CheckExternalEvents(cs1, 0xC6CF);
        // 100D:C6CF add AX,0x0010
        AX = Alu16.Add(AX, (ushort)0x0010);
        // 100D:C6D2 mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:C6D4 and BH,0x0F
        BH = Alu8.And(BH, (byte)0x0F);
        // 100D:C6D7 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:C6D9 jle short 0xC6E4
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C6E4_1C7B4_10590;
        }
    label_100D_C6DB_1C7AB_27723:
        CheckExternalEvents(cs1, 0xC6DB);
        // 100D:C6DB mov AX,0xDBEC
        AX = (ushort)0xDBEC;
        // 100D:C6DE push AX
        Stack.Push16(AX);
        // 100D:C6DF push SI
        Stack.Push16(SI);
        // 100D:C6E0 call near 0xDBB2
        NearCall(cs1, 0xC6E3, unknown_100D_DBB2_1DC82);
    label_100D_C6E3_1C7B3_27728:
        CheckExternalEvents(cs1, 0xC6E3);
        // 100D:C6E3 pop SI
        SI = Stack.Pop16();
    label_100D_C6E4_1C7B4_10590:
        CheckExternalEvents(cs1, 0xC6E4);
        // 100D:C6E4 mov AX,DS
        AX = DS;
        // 100D:C6E6 mov ES,AX
        ES = AX;
        // 100D:C6E8 mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:C6EB mov BX,8
        BX = (ushort)0x0008;
        // 100D:C6EE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C6EF cmp AX,word ptr DS:[BX+DI]
        Alu16.Sub(AX, UInt16[DS, (ushort)(BX + DI)]);
        // 100D:C6F1 jge short 0xC6F5
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C6F5_1C7C5_10598;
        }
    label_100D_C6F3_1C7C3_10899:
        CheckExternalEvents(cs1, 0xC6F3);
        // 100D:C6F3 mov AX,word ptr DS:[BX+DI]
        AX = UInt16[DS, (ushort)(BX + DI)];
    label_100D_C6F5_1C7C5_10598:
        CheckExternalEvents(cs1, 0xC6F5);
        // 100D:C6F5 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C6F6 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C6F7 cmp AX,word ptr DS:[BX+DI]
        Alu16.Sub(AX, UInt16[DS, (ushort)(BX + DI)]);
        // 100D:C6F9 jge short 0xC6FD
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C6FD_1C7CD_10603;
        }
    label_100D_C6FB_1C7CB_10774:
        CheckExternalEvents(cs1, 0xC6FB);
        // 100D:C6FB mov AX,word ptr DS:[BX+DI]
        AX = UInt16[DS, (ushort)(BX + DI)];
    label_100D_C6FD_1C7CD_10603:
        CheckExternalEvents(cs1, 0xC6FD);
        // 100D:C6FD stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C6FE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C6FF cmp AX,word ptr DS:[BX+DI]
        Alu16.Sub(AX, UInt16[DS, (ushort)(BX + DI)]);
        // 100D:C701 jle short 0xC705
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C705_1C7D5_10608;
        }
    label_100D_C703_1C7D3_10825:
        CheckExternalEvents(cs1, 0xC703);
        // 100D:C703 mov AX,word ptr DS:[BX+DI]
        AX = UInt16[DS, (ushort)(BX + DI)];
    label_100D_C705_1C7D5_10608:
        CheckExternalEvents(cs1, 0xC705);
        // 100D:C705 cmp AX,word ptr DS:[DI-4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)-4)]);
        // 100D:C708 jle short 0xC6AC
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_C6AC_1C77C, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_C70A_1C7DA_10611:
        CheckExternalEvents(cs1, 0xC70A);
        // 100D:C70A stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C70B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C70C cmp AX,word ptr DS:[BX+DI]
        Alu16.Sub(AX, UInt16[DS, (ushort)(BX + DI)]);
        // 100D:C70E jle short 0xC712
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C712_1C7E2_10616;
        }
    label_100D_C710_1C7E0_28317:
        CheckExternalEvents(cs1, 0xC710);
        // 100D:C710 mov AX,word ptr DS:[BX+DI]
        AX = UInt16[DS, (ushort)(BX + DI)];
    label_100D_C712_1C7E2_10616:
        CheckExternalEvents(cs1, 0xC712);
        // 100D:C712 cmp AX,word ptr DS:[DI-4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)-4)]);
        // 100D:C715 jle short 0xC6AC
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_C6AC_1C77C, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_C717_1C7E7_10619:
        CheckExternalEvents(cs1, 0xC717);
        // 100D:C717 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:C718 call near 0xC443
        NearCall(cs1, 0xC71B, unknown_100D_C443_1C513);
    label_100D_C71B_1C7EB_10624:
        CheckExternalEvents(cs1, 0xC71B);
        // 100D:C71B sub SP,0x0200
        SP = Alu16.Sub(SP, (ushort)0x0200);
        // 100D:C71F mov DI,SP
        DI = SP;
        // 100D:C721 mov CX,word ptr DS:[0x3CBE]
        CX = UInt16[DS, (ushort)0x3CBE];
        // 100D:C725 jcxz short 0xC780
        if (CX == (ushort)0x0000)
        {
            goto label_100D_C780_1C850_10693;
        }
    label_100D_C727_1C7F7_10629:
        CheckExternalEvents(cs1, 0xC727);
        // 100D:C727 mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:C72A lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C72B mov DX,AX
        DX = AX;
        // 100D:C72D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C72E mov BX,AX
        BX = AX;
        // 100D:C730 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C731 mov BP,AX
        BP = AX;
        // 100D:C733 mov AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        // 100D:C735 mov SI,0x3CC0
        SI = (ushort)0x3CC0;
    label_100D_C738_1C808_10639:
        CheckExternalEvents(cs1, 0xC738);
        // 100D:C738 cmp byte ptr DS:[SI+0x0C],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)12)], (byte)0x00);
        // 100D:C73C js short 0xC756
        if (SignFlag)
        {
            goto label_100D_C756_1C826_10656;
        }
    label_100D_C73E_1C80E_10641:
        CheckExternalEvents(cs1, 0xC73E);
        // 100D:C73E cmp word ptr DS:[SI],BP
        Alu16.Sub(UInt16[DS, SI], BP);
        // 100D:C740 jge short 0xC756
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C756_1C826_10656;
        }
    label_100D_C742_1C812_10644:
        CheckExternalEvents(cs1, 0xC742);
        // 100D:C742 cmp word ptr DS:[SI+2],AX
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)2)], AX);
        // 100D:C745 jge short 0xC756
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C756_1C826_10656;
        }
    label_100D_C747_1C817_10647:
        CheckExternalEvents(cs1, 0xC747);
        // 100D:C747 cmp word ptr DS:[SI+4],DX
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)4)], DX);
        // 100D:C74A jle short 0xC756
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C756_1C826_10656;
        }
    label_100D_C74C_1C81C_10650:
        CheckExternalEvents(cs1, 0xC74C);
        // 100D:C74C cmp word ptr DS:[SI+6],BX
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)6)], BX);
        // 100D:C74F jle short 0xC756
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C756_1C826_10656;
        }
    label_100D_C751_1C821_10653:
        CheckExternalEvents(cs1, 0xC751);
        // 100D:C751 mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 100D:C753 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_C756_1C826_10656:
        CheckExternalEvents(cs1, 0xC756);
        // 100D:C756 add SI,0x0011
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:C759 loop 0xC738
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_C738_1C808_10639;
        }
    label_100D_C75B_1C82B_10658:
        CheckExternalEvents(cs1, 0xC75B);
        // 100D:C75B mov CX,DI
        CX = DI;
        // 100D:C75D sub CX,SP
        CX = Alu16.Sub(CX, SP);
        // 100D:C75F shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:C761 je short 0xC780
        if (ZeroFlag)
        {
            goto label_100D_C780_1C850_10693;
        }
    label_100D_C763_1C833_10663:
        CheckExternalEvents(cs1, 0xC763);
        // 100D:C763 mov SI,SP
        SI = SP;
        // 100D:C765 push CX
        Stack.Push16(CX);
        // 100D:C766 call near word ptr DS:[0x2786]
        switch ((ushort)(UInt16[DS, (ushort)0x2786]))
        {
            case 0xC827:
                NearCall(cs1, 0xC76A, unknown_100D_C827_1C8F7);
                break;
            case 0xC835:
                NearCall(cs1, 0xC76A, unknown_100D_C835_1C905);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2786])):X4} at 100D:C766");
        }
    label_100D_C76A_1C83A_10678:
        CheckExternalEvents(cs1, 0xC76A);
        // 100D:C76A js short 0xC77F
        if (SignFlag)
        {
            goto label_100D_C77F_1C84F_10691;
        }
    label_100D_C76C_1C83C_10680:
        CheckExternalEvents(cs1, 0xC76C);
        // 100D:C76C xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:C76E xchg SI,word ptr DS:[BX-2]
        ushort xchgOffset_100D_C76E_1C83E = unchecked((ushort)(BX + (sbyte)-2));
        ushort temp_100D_C76E_1C83E = SI;
        SI = UInt16[DS, xchgOffset_100D_C76E_1C83E];
        UInt16[DS, xchgOffset_100D_C76E_1C83E] = unchecked((ushort)temp_100D_C76E_1C83E);
        // 100D:C771 mov AX,word ptr DS:[SI+8]
        AX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:C774 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C776 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C779 call near 0xC30D
        NearCall(cs1, 0xC77C, unknown_100D_C30D_1C3DD);
    label_100D_C77C_1C84C_10687:
        CheckExternalEvents(cs1, 0xC77C);
        // 100D:C77C pop CX
        CX = Stack.Pop16();
        // 100D:C77D jmp short 0xC763
        goto label_100D_C763_1C833_10663;
    label_100D_C77F_1C84F_10691:
        CheckExternalEvents(cs1, 0xC77F);
        // 100D:C77F pop CX
        CX = Stack.Pop16();
    label_100D_C780_1C850_10693:
        CheckExternalEvents(cs1, 0xC780);
        // 100D:C780 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:C785 jne short 0xC7A2
        if (!ZeroFlag)
        {
            goto label_100D_C7A2_1C872_10695;
        }
    label_100D_C787_1C857_18319:
        CheckExternalEvents(cs1, 0xC787);
        // 100D:C787 cmp word ptr DS:[0xD83A],0x0089
        Alu16.Sub(UInt16[DS, (ushort)0xD83A], (ushort)0x0089);
        // 100D:C78D jl short 0xC7A2
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_C7A2_1C872_10695;
        }
    label_100D_C78F_1C85F_18322:
        CheckExternalEvents(cs1, 0xC78F);
        // 100D:C78F cmp word ptr DS:[0xD838],0x007E
        Alu16.Sub(UInt16[DS, (ushort)0xD838], (ushort)0x007E);
        // 100D:C795 jl short 0xC7A2
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_C7A2_1C872_10695;
        }
    label_100D_C797_1C867_18325:
        CheckExternalEvents(cs1, 0xC797);
        // 100D:C797 cmp word ptr DS:[0xD834],0x00C2
        Alu16.Sub(UInt16[DS, (ushort)0xD834], (ushort)0x00C2);
        // 100D:C79D jge short 0xC7A2
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C7A2_1C872_10695;
        }
    label_100D_C79F_1C86F_18328:
        CheckExternalEvents(cs1, 0xC79F);
        // 100D:C79F call near 0x1797
        NearCall(cs1, 0xC7A2, unknown_100D_1797_11867);
    label_100D_C7A2_1C872_10695:
        CheckExternalEvents(cs1, 0xC7A2);
        // 100D:C7A2 mov SI,word ptr DS:[0xDBE0]
        SI = UInt16[DS, (ushort)0xDBE0];
        // 100D:C7A6 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:C7A8 je short 0xC7BE
        if (ZeroFlag)
        {
            goto label_100D_C7BE_1C88E_10699;
        }
    label_100D_C7AA_1C87A_24479:
        CheckExternalEvents(cs1, 0xC7AA);
        // 100D:C7AA mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:C7AD call near 0xC7D4
        NearCall(cs1, 0xC7B0, unknown_100D_C7D4_1C8A4);
    label_100D_C7B0_1C880_24503:
        CheckExternalEvents(cs1, 0xC7B0);
        // 100D:C7B0 mov SI,word ptr DS:[0xDBE2]
        SI = UInt16[DS, (ushort)0xDBE2];
        // 100D:C7B4 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:C7B6 je short 0xC7BE
        if (ZeroFlag)
        {
            goto label_100D_C7BE_1C88E_10699;
        }
    label_100D_C7B8_1C888_27677:
        CheckExternalEvents(cs1, 0xC7B8);
        // 100D:C7B8 mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:C7BB call near 0xC7D4
        NearCall(cs1, 0xC7BE, unknown_100D_C7D4_1C8A4);
    label_100D_C7BE_1C88E_10699:
        CheckExternalEvents(cs1, 0xC7BE);
        // 100D:C7BE mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:C7C1 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C7C3 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C7C6 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C7C9 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C7CC call near 0xC51E
        NearCall(cs1, 0xC7CF, unknown_100D_C51E_1C5EE);
    label_100D_C7CF_1C89F_10706:
        CheckExternalEvents(cs1, 0xC7CF);
        // 100D:C7CF add SP,0x0200
        SP = Alu16.Add(SP, (ushort)0x0200);
        // 100D:C7D3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C7D4_1C8A4(int loadOffset)
    {
    label_100D_C7D4_1C8A4_24482:
        CheckExternalEvents(cs1, 0xC7D4);
        // 100D:C7D4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C7D5 cmp AX,word ptr DS:[DI+4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:C7D8 jge short 0xC826
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C7DA_1C8AA_24486:
        CheckExternalEvents(cs1, 0xC7DA);
        // 100D:C7DA mov DX,AX
        DX = AX;
        // 100D:C7DC lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C7DD cmp AX,word ptr DS:[DI+6]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:C7E0 jge short 0xC826
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C7E2_1C8B2_24491:
        CheckExternalEvents(cs1, 0xC7E2);
        // 100D:C7E2 mov BX,AX
        BX = AX;
        // 100D:C7E4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C7E5 cmp AX,word ptr DS:[DI]
        Alu16.Sub(AX, UInt16[DS, DI]);
        // 100D:C7E7 jle short 0xC826
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C7E9_1C8B9_24496:
        CheckExternalEvents(cs1, 0xC7E9);
        // 100D:C7E9 mov BP,AX
        BP = AX;
        // 100D:C7EB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C7EC cmp AX,word ptr DS:[DI+2]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:C7EF jle short 0xC826
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C7F1_1C8C1_27680:
        CheckExternalEvents(cs1, 0xC7F1);
        // 100D:C7F1 cmp DX,word ptr DS:[DI]
        Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:C7F3 jae short 0xC7F7
        if (!CarryFlag)
        {
            goto label_100D_C7F7_1C8C7_27685;
        }
    label_100D_C7F5_1C8C5_27683:
        CheckExternalEvents(cs1, 0xC7F5);
        // 100D:C7F5 mov DX,word ptr DS:[DI]
        DX = UInt16[DS, DI];
    label_100D_C7F7_1C8C7_27685:
        CheckExternalEvents(cs1, 0xC7F7);
        // 100D:C7F7 cmp BP,word ptr DS:[DI+4]
        Alu16.Sub(BP, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:C7FA jb short 0xC7FF
        if (CarryFlag)
        {
            goto label_100D_C7FF_1C8CF_27689;
        }
    label_100D_C7FC_1C8CC_27687:
        CheckExternalEvents(cs1, 0xC7FC);
        // 100D:C7FC mov BP,word ptr DS:[DI+4]
        BP = UInt16[DS, (ushort)(DI + (sbyte)4)];
    label_100D_C7FF_1C8CF_27689:
        CheckExternalEvents(cs1, 0xC7FF);
        // 100D:C7FF cmp BX,word ptr DS:[DI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:C802 jae short 0xC807
        if (!CarryFlag)
        {
            goto label_100D_C807_1C8D7_27693;
        }
    label_100D_C804_1C8D4_27691:
        CheckExternalEvents(cs1, 0xC804);
        // 100D:C804 mov BX,word ptr DS:[DI+2]
        BX = UInt16[DS, (ushort)(DI + (sbyte)2)];
    label_100D_C807_1C8D7_27693:
        CheckExternalEvents(cs1, 0xC807);
        // 100D:C807 cmp AX,word ptr DS:[DI+6]
        Alu16.Sub(AX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:C80A jb short 0xC80F
        if (CarryFlag)
        {
            goto label_100D_C80F_1C8DF_27697;
        }
    label_100D_C80C_1C8DC_27695:
        CheckExternalEvents(cs1, 0xC80C);
        // 100D:C80C mov AX,word ptr DS:[DI+6]
        AX = UInt16[DS, (ushort)(DI + (sbyte)6)];
    label_100D_C80F_1C8DF_27697:
        CheckExternalEvents(cs1, 0xC80F);
        // 100D:C80F sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:C811 jbe short 0xC826
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C813_1C8E3_27699:
        CheckExternalEvents(cs1, 0xC813);
        // 100D:C813 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C815 jbe short 0xC826
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_C826_1C8F6_24501;
        }
    label_100D_C817_1C8E7_27702:
        CheckExternalEvents(cs1, 0xC817);
        // 100D:C817 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:C81B mov DS,word ptr DS:[0xDBD8]
        DS = UInt16[DS, (ushort)0xDBD8];
        // 100D:C81F call far dword ptr SS:[0x38F5]
        ushort targetSegment_27705 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38F5 + (ushort)0x0002)]));
        ushort targetOffset_27705 = unchecked((ushort)(UInt16[SS, (ushort)0x38F5]));
        if (targetSegment_27705 == cs2 && targetOffset_27705 == 0x0130)
        {
            FarCall(cs1, 0xC824, cs2, unknown_3358_0130_336B0);
            goto label_100D_C824_1C8F4_27706;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_27705:X4}:{targetOffset_27705:X4} at 100D:C81F");
    label_100D_C824_1C8F4_27706:
        CheckExternalEvents(cs1, 0xC824);
        // 100D:C824 push SS
        Stack.Push16(SS);
        // 100D:C825 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_C826_1C8F6_24501:
        CheckExternalEvents(cs1, 0xC826);
        // 100D:C826 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C827_1C8F7(int loadOffset)
    {
    label_100D_C827_1C8F7_10667:
        CheckExternalEvents(cs1, 0xC827);
        // 100D:C827 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C828 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:C82A loope 0xC827
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && ZeroFlag)
        {
            goto label_100D_C827_1C8F7_10667;
        }
    label_100D_C82C_1C8FC_10671:
        CheckExternalEvents(cs1, 0xC82C);
        // 100D:C82C je short 0xC833
        if (ZeroFlag)
        {
            goto label_100D_C833_1C903_10676;
        }
    label_100D_C82E_1C8FE_10673:
        CheckExternalEvents(cs1, 0xC82E);
        // 100D:C82E mov BX,SI
        BX = SI;
        // 100D:C830 mov AX,1
        AX = (ushort)0x0001;
    label_100D_C833_1C903_10676:
        CheckExternalEvents(cs1, 0xC833);
        // 100D:C833 dec AX
        AX = Alu16.Dec(AX);
        // 100D:C834 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C835_1C905(int loadOffset)
    {
    label_100D_C835_1C905_23535:
        CheckExternalEvents(cs1, 0xC835);
        // 100D:C835 mov DX,0xFFFF
        DX = (ushort)0xFFFF;
    label_100D_C838_1C908_23537:
        CheckExternalEvents(cs1, 0xC838);
        // 100D:C838 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C839 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:C83B je short 0xC856
        if (ZeroFlag)
        {
            goto label_100D_C856_1C926_23552;
        }
    label_100D_C83D_1C90D_23540:
        CheckExternalEvents(cs1, 0xC83D);
        // 100D:C83D mov DI,AX
        DI = AX;
        // 100D:C83F mov AX,word ptr DS:[DI+4]
        AX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:C842 add AX,word ptr DS:[DI+6]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)(DI + (sbyte)6)]);
        // 100D:C845 test byte ptr DS:[DI+0x0C],0x40
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x40);
        // 100D:C849 je short 0xC84E
        if (ZeroFlag)
        {
            goto label_100D_C84E_1C91E_23546;
        }
    label_100D_C84B_1C91B_24477:
        CheckExternalEvents(cs1, 0xC84B);
        // 100D:C84B mov AX,0x7FFF
        AX = (ushort)0x7FFF;
    label_100D_C84E_1C91E_23546:
        CheckExternalEvents(cs1, 0xC84E);
        // 100D:C84E cmp AX,DX
        Alu16.Sub(AX, DX);
        // 100D:C850 ja short 0xC856
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_C856_1C926_23552;
        }
    label_100D_C852_1C922_23549:
        CheckExternalEvents(cs1, 0xC852);
        // 100D:C852 mov DX,AX
        DX = AX;
        // 100D:C854 mov BX,SI
        BX = SI;
    label_100D_C856_1C926_23552:
        CheckExternalEvents(cs1, 0xC856);
        // 100D:C856 loop 0xC838
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_C838_1C908_23537;
        }
    label_100D_C858_1C928_23553:
        CheckExternalEvents(cs1, 0xC858);
        // 100D:C858 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:C85A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C85B_1C92B(int loadOffset)
    {
    label_100D_C85B_1C92B_3242:
        CheckExternalEvents(cs1, 0xC85B);
        // 100D:C85B mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:C85E mov word ptr DS:[0x476E],AX
        UInt16[DS, (ushort)0x476E] = AX;
        // 100D:C861 mov word ptr DS:[0x4772],0x1770
        UInt16[DS, (ushort)0x4772] = (ushort)0x1770;
        // 100D:C867 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C868_1C938(int loadOffset)
    {
    label_100D_C868_1C938_9632:
        CheckExternalEvents(cs1, 0xC868);
        // 100D:C868 call near 0xABCC
        NearCall(cs1, 0xC86B, unknown_100D_ABCC_1AC9C);
    label_100D_C86B_1C93B_9634:
        CheckExternalEvents(cs1, 0xC86B);
        // 100D:C86B jne short 0xC8C0
        if (!ZeroFlag)
        {
            goto label_100D_C8C0_1C990_9938;
        }
    label_100D_C86D_1C93D_9636:
        CheckExternalEvents(cs1, 0xC86D);
        // 100D:C86D mov SI,word ptr DS:[0x22A6]
        SI = UInt16[DS, (ushort)0x22A6];
        // 100D:C871 cmp SI,0x0011
        Alu16.Sub(SI, (ushort)0x0011);
        // 100D:C875 jae short 0xC8C0
        if (!CarryFlag)
        {
            goto label_100D_C8C0_1C990_9938;
        }
    label_100D_C877_1C947_9640:
        CheckExternalEvents(cs1, 0xC877);
        // 100D:C877 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C879 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C87B mov DX,word ptr DS:[SI+0x27B6]
        DX = UInt16[DS, (ushort)(SI + (short)10166)];
        // 100D:C87F mov BX,word ptr DS:[SI+0x27B8]
        BX = UInt16[DS, (ushort)(SI + (short)10168)];
        // 100D:C883 mov AX,BX
        AX = BX;
        // 100D:C885 or AX,DX
        AX = Alu16.Or(AX, DX);
        // 100D:C887 je short 0xC8C0
        if (ZeroFlag)
        {
            goto label_100D_C8C0_1C990_9938;
        }
    label_100D_C889_1C959_9648:
        CheckExternalEvents(cs1, 0xC889);
        // 100D:C889 mov SI,0x2792
        SI = (ushort)0x2792;
        // 100D:C88C cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:C891 jne short 0xC8A3
        if (!ZeroFlag)
        {
            goto label_100D_C8A3_1C973_9652;
        }
    label_100D_C893_1C963_34820:
        CheckExternalEvents(cs1, 0xC893);
        // 100D:C893 push BX
        Stack.Push16(BX);
        // 100D:C894 mov BX,1
        BX = (ushort)0x0001;
        // 100D:C897 call near 0xE3B7
        NearCall(cs1, 0xC89A, unknown_100D_E3B7_1E487);
    label_100D_C89A_1C96A_34824:
        CheckExternalEvents(cs1, 0xC89A);
        // 100D:C89A pop BX
        BX = Stack.Pop16();
        // 100D:C89B mov SI,0x2789
        SI = (ushort)0x2789;
        // 100D:C89E je short 0xC8A3
        if (ZeroFlag)
        {
            goto label_100D_C8A3_1C973_9652;
        }
    label_100D_C8A0_1C970_34828:
        CheckExternalEvents(cs1, 0xC8A0);
        // 100D:C8A0 mov SI,0x278E
        SI = (ushort)0x278E;
    label_100D_C8A3_1C973_9652:
        CheckExternalEvents(cs1, 0xC8A3);
        // 100D:C8A3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:C8A4 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:C8A6 je short 0xC8BD
        if (ZeroFlag)
        {
            goto label_100D_C8BD_1C98D_9936;
        }
    label_100D_C8A8_1C978_9656:
        CheckExternalEvents(cs1, 0xC8A8);
        // 100D:C8A8 jns short 0xC8B2
        if (!SignFlag)
        {
            goto label_100D_C8B2_1C982_9658;
        }
    label_100D_C8AA_1C97A_9728:
        CheckExternalEvents(cs1, 0xC8AA);
        // 100D:C8AA mov AX,0x012C
        AX = (ushort)0x012C;
        // 100D:C8AD call near 0xE387
        NearCall(cs1, 0xC8B0, unknown_100D_E387_1E457);
    label_100D_C8B0_1C980_9752:
        CheckExternalEvents(cs1, 0xC8B0);
        // 100D:C8B0 jmp short 0xC8A3
        goto label_100D_C8A3_1C973_9652;
    label_100D_C8B2_1C982_9658:
        CheckExternalEvents(cs1, 0xC8B2);
        // 100D:C8B2 push SI
        Stack.Push16(SI);
        // 100D:C8B3 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:C8B5 mov BP,AX
        BP = AX;
        // 100D:C8B7 call near 0xC8C1
        NearCall(cs1, 0xC8BA, unknown_100D_C8C1_1C991);
    label_100D_C8BA_1C98A_9725:
        CheckExternalEvents(cs1, 0xC8BA);
        // 100D:C8BA pop SI
        SI = Stack.Pop16();
        // 100D:C8BB jmp short 0xC8A3
        goto label_100D_C8A3_1C973_9652;
    label_100D_C8BD_1C98D_9936:
        CheckExternalEvents(cs1, 0xC8BD);
        // 100D:C8BD call near 0xC4DD
        NearCall(cs1, 0xC8C0, unknown_100D_C4DD_1C5AD);
    label_100D_C8C0_1C990_9938:
        CheckExternalEvents(cs1, 0xC8C0);
        // 100D:C8C0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C8C1_1C991(int loadOffset)
    {
    label_100D_C8C1_1C991_9663:
        CheckExternalEvents(cs1, 0xC8C1);
        // 100D:C8C1 push BX
        Stack.Push16(BX);
        // 100D:C8C2 push DX
        Stack.Push16(DX);
        // 100D:C8C3 push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
        // 100D:C8C7 mov SI,BP
        SI = BP;
        // 100D:C8C9 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C8CB shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:C8CD sub DX,word ptr DS:[SI+0x2796]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (short)10134)]);
        // 100D:C8D1 jae short 0xC8D5
        if (!CarryFlag)
        {
            goto label_100D_C8D5_1C9A5_9672;
        }
    label_100D_C8D3_1C9A3_9818:
        CheckExternalEvents(cs1, 0xC8D3);
        // 100D:C8D3 xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_100D_C8D5_1C9A5_9672:
        CheckExternalEvents(cs1, 0xC8D5);
        // 100D:C8D5 sub BX,word ptr DS:[SI+0x2798]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (short)10136)]);
        // 100D:C8D9 jae short 0xC8DD
        if (!CarryFlag)
        {
            goto label_100D_C8DD_1C9AD_9675;
        }
    label_100D_C8DB_1C9AB_9892:
        CheckExternalEvents(cs1, 0xC8DB);
        // 100D:C8DB xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_C8DD_1C9AD_9675:
        CheckExternalEvents(cs1, 0xC8DD);
        // 100D:C8DD push DS
        Stack.Push16(DS);
        // 100D:C8DE mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C8E2 mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C8E6 call far dword ptr SS:[0x3949]
        ushort targetSegment_9679 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x3949 + (ushort)0x0002)]));
        ushort targetOffset_9679 = unchecked((ushort)(UInt16[SS, (ushort)0x3949]));
        if (targetSegment_9679 == cs2 && targetOffset_9679 == 0x016F)
        {
            FarCall(cs1, 0xC8EB, cs2, unknown_3358_016F_336EF);
            goto label_100D_C8EB_1C9BB_9713;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_9679:X4}:{targetOffset_9679:X4} at 100D:C8E6");
    label_100D_C8EB_1C9BB_9713:
        CheckExternalEvents(cs1, 0xC8EB);
        // 100D:C8EB pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C8EC pop BX
        BX = Stack.Pop16();
    label_100D_C8ED_1C9BD_9716:
        CheckExternalEvents(cs1, 0xC8ED);
        // 100D:C8ED mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:C8F0 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C8F2 cmp AL,byte ptr DS:[0xDBE6]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDBE6]);
        // 100D:C8F6 jb short 0xC8ED
        if (CarryFlag)
        {
            goto label_100D_C8ED_1C9BD_9716;
        }
    label_100D_C8F8_1C9C8_9721:
        CheckExternalEvents(cs1, 0xC8F8);
        // 100D:C8F8 pop DX
        DX = Stack.Pop16();
        // 100D:C8F9 pop BX
        BX = Stack.Pop16();
        // 100D:C8FA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C8FB_1C9CB(int loadOffset)
    {
    entrydispatcher:
    label_100D_C8FB_1C9CB_37707:
        CheckExternalEvents(cs1, 0xC8FB);
        // 100D:C8FB call near 0xC07C
        NearCall(cs1, 0xC8FE, unknown_100D_C07C_1C14C);
    label_100D_C8FE_1C9CE_37713:
        CheckExternalEvents(cs1, 0xC8FE);
        // 100D:C8FE push BP
        Stack.Push16(BP);
        // 100D:C8FF call near 0xCA1B
        NearCall(cs1, 0xC902, unknown_100D_CA1B_1CAEB);
    label_100D_C902_1C9D2_37718:
        CheckExternalEvents(cs1, 0xC902);
        // 100D:C902 call near 0xC4DD
        NearCall(cs1, 0xC905, unknown_100D_C4DD_1C5AD);
    label_100D_C905_1C9D5_37721:
        CheckExternalEvents(cs1, 0xC905);
        // 100D:C905 call near 0xC0F4
        NearCall(cs1, 0xC908, unknown_100D_C0F4_1C1C4);
    label_100D_C908_1C9D8_37724:
        CheckExternalEvents(cs1, 0xC908);
        // 100D:C908 pop BP
        BP = Stack.Pop16();
        // 100D:C909 call near BP
        switch ((ushort)(BP))
        {
            case 0x181E:
                NearCall(cs1, 0xC90B, unknown_100D_181E_118EE);
                break;
            case 0xC4CD:
                NearCall(cs1, 0xC90B, unknown_100D_C4CD_1C59D);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(BP)):X4} at 100D:C909");
        }
    label_100D_C90B_1C9DB_37728:
        CheckExternalEvents(cs1, 0xC90B);
        // 100D:C90B call near 0xC9F4
        NearCall(cs1, 0xC90E, unknown_100D_C9F4_1CAC4);
    label_100D_C90E_1C9DE_37731:
        CheckExternalEvents(cs1, 0xC90E);
        // 100D:C90E je short 0xC90B
        if (ZeroFlag)
        {
            goto label_100D_C90B_1C9DB_37728;
        }
    label_100D_C910_1C9E0_37734:
        CheckExternalEvents(cs1, 0xC910);
        // 100D:C910 call near 0xC4DD
        NearCall(cs1, 0xC913, unknown_100D_C4DD_1C5AD);
    label_100D_C913_1C9E3_37738:
        CheckExternalEvents(cs1, 0xC913);
        // 100D:C913 call near 0xACE6
        NearCall(cs1, 0xC916, unknown_100D_ACE6_1ADB6);
    label_100D_C916_1C9E6_37741:
        CheckExternalEvents(cs1, 0xC916);
        // 100D:C916 call near 0xCC85
        NearCall(cs1, 0xC919, unknown_100D_CC85_1CD55);
    label_100D_C919_1C9E9_37744:
        CheckExternalEvents(cs1, 0xC919);
        // 100D:C919 je short 0xC90B
        if (ZeroFlag)
        {
            goto label_100D_C90B_1C9DB_37728;
        }
    label_100D_C91B_1C9EB_37747:
        CheckExternalEvents(cs1, 0xC91B);
        // 100D:C91B call near 0xC412
        NearCall(cs1, 0xC91E, unknown_100D_C412_1C4E2);
    label_100D_C91E_1C9EE_37751:
        CheckExternalEvents(cs1, 0xC91E);
        // 100D:C91E jmp near 0xCA01
        return unknown_100D_CA01_1CAD1(0x0000);
    }

    public virtual Action unknown_100D_C921_1C9F1(int loadOffset)
    {
    label_100D_C921_1C9F1_2484:
        CheckExternalEvents(cs1, 0xC921);
        // 100D:C921 mov BX,0x33A3
        BX = (ushort)0x33A3;
        // 100D:C924 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:C926 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:C928 mov BX,word ptr DS:[BX]
        BX = UInt16[DS, BX];
        // 100D:C92A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C92B_1C9FB(int loadOffset)
    {
    label_100D_C92B_1C9FB_2508:
        CheckExternalEvents(cs1, 0xC92B);
        // 100D:C92B mov word ptr DS:[0xDC00],AX
        UInt16[DS, (ushort)0xDC00] = AX;
        // 100D:C92E call near 0xCA01
        NearCall(cs1, 0xC931, unknown_100D_CA01_1CAD1);
    label_100D_C931_1CA01_2519:
        CheckExternalEvents(cs1, 0xC931);
        // 100D:C931 call near 0xCE1A
        NearCall(cs1, 0xC934, unknown_100D_CE1A_1CEEA);
    label_100D_C934_1CA04_2534:
        CheckExternalEvents(cs1, 0xC934);
        // 100D:C934 mov byte ptr DS:[0xDBE7],0
        UInt8[DS, (ushort)0xDBE7] = (byte)0x00;
        // 100D:C939 call near 0xCE01
        NearCall(cs1, 0xC93C, unknown_100D_CE01_1CED1);
    label_100D_C93C_1CA0C_2543:
        CheckExternalEvents(cs1, 0xC93C);
        // 100D:C93C mov AX,word ptr DS:[0xDC00]
        AX = UInt16[DS, (ushort)0xDC00];
        // 100D:C93F mov word ptr DS:[0xDC02],AX
        UInt16[DS, (ushort)0xDC02] = AX;
        // 100D:C942 call near 0xC921
        NearCall(cs1, 0xC945, unknown_100D_C921_1C9F1);
    label_100D_C945_1CA15_2547:
        CheckExternalEvents(cs1, 0xC945);
        // 100D:C945 mov AX,word ptr DS:[BX]
        AX = UInt16[DS, BX];
        // 100D:C947 mov word ptr DS:[0xDBFE],AX
        UInt16[DS, (ushort)0xDBFE] = AX;
        // 100D:C94A lea DX,BX+2
        DX = unchecked((ushort)(BX + (sbyte)2));
        // 100D:C94D call near 0xF229
        NearCall(cs1, 0xC950, unknown_100D_F229_1F2F9);
    label_100D_C950_1CA20_2552:
        CheckExternalEvents(cs1, 0xC950);
        // 100D:C950 mov word ptr DS:[0x35A6],BX
        UInt16[DS, (ushort)0x35A6] = BX;
        // 100D:C954 mov word ptr DS:[0xDC04],AX
        UInt16[DS, (ushort)0xDC04] = AX;
        // 100D:C957 mov word ptr DS:[0xDC06],DX
        UInt16[DS, (ushort)0xDC06] = DX;
        // 100D:C95B mov word ptr DS:[0xDC08],CX
        UInt16[DS, (ushort)0xDC08] = CX;
        // 100D:C95F mov word ptr DS:[0xDC0A],BP
        UInt16[DS, (ushort)0xDC0A] = BP;
        // 100D:C963 push word ptr DS:[0xDC1A]
        Stack.Push16(UInt16[DS, (ushort)0xDC1A]);
        // 100D:C967 push word ptr DS:[0xDC0C]
        Stack.Push16(UInt16[DS, (ushort)0xDC0C]);
        // 100D:C96B call near 0xCD8F
        NearCall(cs1, 0xC96E, unknown_100D_CD8F_1CE5F);
    label_100D_C96E_1CA3E_2599:
        CheckExternalEvents(cs1, 0xC96E);
        // 100D:C96E jb short 0xC988
        if (CarryFlag)
        {
            goto label_100D_C988_1CA58_2611;
        }
    label_100D_C970_1CA40_2601:
        CheckExternalEvents(cs1, 0xC970);
        // 100D:C970 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:C972 jb short 0xC97A
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C972");
        }
    label_100D_C974_1CA44_2604:
        CheckExternalEvents(cs1, 0xC974);
        // 100D:C974 cmp SI,word ptr DS:[0xCE74]
        Alu16.Sub(SI, UInt16[DS, (ushort)0xCE74]);
        // 100D:C978 jbe short 0xC980
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:C978");
        }
    label_100D_C980_1CA50_2607:
        CheckExternalEvents(cs1, 0xC980);
        // 100D:C980 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:C983 mov CX,AX
        CX = AX;
        // 100D:C985 call near 0xCDBF
        NearCall(cs1, 0xC988, unknown_100D_CDBF_1CE8F);
    label_100D_C988_1CA58_2611:
        CheckExternalEvents(cs1, 0xC988);
        // 100D:C988 pop word ptr DS:[0xDC0C]
        ushort popStackCheck_100D_C988_1CA58 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C988_1CA58 = UInt16[DS, (ushort)0xDC0C];
        ushort poppedValue_100D_C988_1CA58 = Stack.Pop16();
        UInt16[DS, (ushort)0xDC0C] = unchecked((ushort)poppedValue_100D_C988_1CA58);
        // 100D:C98C pop word ptr DS:[0xDC1A]
        ushort popStackCheck_100D_C98C_1CA5C = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_C98C_1CA5C = UInt16[DS, (ushort)0xDC1A];
        ushort poppedValue_100D_C98C_1CA5C = Stack.Pop16();
        UInt16[DS, (ushort)0xDC1A] = unchecked((ushort)poppedValue_100D_C98C_1CA5C);
        // 100D:C990 jb short 0xC9E7
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C990");
        }
    label_100D_C992_1CA62_2615:
        CheckExternalEvents(cs1, 0xC992);
        // 100D:C992 les SI,word ptr DS:[0xDC0C]
        ushort lxsOffset_100D_C992_1CA62 = (ushort)0xDC0C;
        ushort lxsValue_100D_C992_1CA62 = UInt16[DS, lxsOffset_100D_C992_1CA62];
        ushort lxsSegment_100D_C992_1CA62 = UInt16[DS, (ushort)(lxsOffset_100D_C992_1CA62 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_C992_1CA62);
        ES = unchecked((ushort)lxsSegment_100D_C992_1CA62);
        // 100D:C996 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:C998 add AX,SI
        AX = Alu16.Add(AX, SI);
        // 100D:C99A jb short 0xC9A2
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C99A");
        }
    label_100D_C99C_1CA6C_2620:
        CheckExternalEvents(cs1, 0xC99C);
        // 100D:C99C cmp AX,word ptr DS:[0xCE74]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE74]);
        // 100D:C9A0 jbe short 0xC9A4
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:C9A0");
        }
    label_100D_C9A4_1CA74_2623:
        CheckExternalEvents(cs1, 0xC9A4);
        // 100D:C9A4 mov byte ptr DS:[0xDBB4],0xFF
        UInt8[DS, (ushort)0xDBB4] = (byte)0xFF;
        // 100D:C9A9 call near 0xC1BA
        NearCall(cs1, 0xC9AC, unknown_100D_C1BA_1C28A);
    label_100D_C9AC_1CA7C_2642:
        CheckExternalEvents(cs1, 0xC9AC);
        // 100D:C9AC dec SI
        SI = Alu16.Dec(SI);
    label_100D_C9AD_1CA7D_2644:
        CheckExternalEvents(cs1, 0xC9AD);
        // 100D:C9AD inc SI
        SI = Alu16.Inc(SI);
        // 100D:C9AE cmp byte ptr ES:[SI],0xFF
        Alu8.Sub(UInt8[ES, SI], (byte)0xFF);
        // 100D:C9B2 je short 0xC9AD
        if (ZeroFlag)
        {
            goto label_100D_C9AD_1CA7D_2644;
        }
    label_100D_C9B4_1CA84_2647:
        CheckExternalEvents(cs1, 0xC9B4);
        // 100D:C9B4 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:C9B6 test byte ptr DS:[0xDBFE],4
        Alu8.And(UInt8[DS, (ushort)0xDBFE], (byte)0x04);
        // 100D:C9BB je short 0xC9BF
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:C9BB");
        }
    label_100D_C9BF_1CA8F_2651:
        CheckExternalEvents(cs1, 0xC9BF);
        // 100D:C9BF mov CX,word ptr ES:[BX+SI]
        CX = UInt16[ES, (ushort)(BX + SI)];
        // 100D:C9C2 mov BX,word ptr ES:[BX+SI+2]
        BX = UInt16[ES, (ushort)(BX + SI + (sbyte)2)];
        // 100D:C9C6 mov AX,word ptr DS:[0xDC04]
        AX = UInt16[DS, (ushort)0xDC04];
        // 100D:C9C9 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:C9CB mov word ptr DS:[0xDBF6],AX
        UInt16[DS, (ushort)0xDBF6] = AX;
        // 100D:C9CE mov AX,word ptr DS:[0xDC06]
        AX = UInt16[DS, (ushort)0xDC06];
        // 100D:C9D1 adc AX,BX
        AX = Alu16.Adc(AX, BX);
        // 100D:C9D3 mov word ptr DS:[0xDBF8],AX
        UInt16[DS, (ushort)0xDBF8] = AX;
        // 100D:C9D6 mov AX,word ptr DS:[0xDC08]
        AX = UInt16[DS, (ushort)0xDC08];
        // 100D:C9D9 sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 100D:C9DB mov word ptr DS:[0xDBFA],AX
        UInt16[DS, (ushort)0xDBFA] = AX;
        // 100D:C9DE mov AX,word ptr DS:[0xDC0A]
        AX = UInt16[DS, (ushort)0xDC0A];
        // 100D:C9E1 sbb AX,BX
        AX = Alu16.Sbb(AX, BX);
        // 100D:C9E3 mov word ptr DS:[0xDBFC],AX
        UInt16[DS, (ushort)0xDBFC] = AX;
        // 100D:C9E6 clc
        CarryFlag = false;
        // 100D:C9E7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C9E8_1CAB8(int loadOffset)
    {
    label_100D_C9E8_1CAB8_5362:
        CheckExternalEvents(cs1, 0xC9E8);
        // 100D:C9E8 call near 0xCA60
        NearCall(cs1, 0xC9EB, unknown_100D_CA60_1CB30);
    label_100D_C9EB_1CABB_5364:
        CheckExternalEvents(cs1, 0xC9EB);
        // 100D:C9EB call near 0xDD63
        NearCall(cs1, 0xC9EE, unknown_100D_DD63_1DE33);
    label_100D_C9EE_1CABE_5366:
        CheckExternalEvents(cs1, 0xC9EE);
        // 100D:C9EE jb short 0xC9F1
        if (CarryFlag)
        {
            goto label_100D_C9F1_1CAC1_17202;
        }
    label_100D_C9F0_1CAC0_5368:
        CheckExternalEvents(cs1, 0xC9F0);
        // 100D:C9F0 ret near
        return NearRet((ushort)0x0000);
    label_100D_C9F1_1CAC1_17202:
        CheckExternalEvents(cs1, 0xC9F1);
        // 100D:C9F1 jmp near 0xDE4E
        return unknown_100D_DE4E_1DF1E(0x0000);
    }

    public virtual Action unknown_100D_C9F4_1CAC4(int loadOffset)
    {
    label_100D_C9F4_1CAC4_4814:
        CheckExternalEvents(cs1, 0xC9F4);
        // 100D:C9F4 push word ptr DS:[0xDBE8]
        Stack.Push16(UInt16[DS, (ushort)0xDBE8]);
        // 100D:C9F8 call near 0xCA60
        NearCall(cs1, 0xC9FB, unknown_100D_CA60_1CB30);
    label_100D_C9FB_1CACB_4908:
        CheckExternalEvents(cs1, 0xC9FB);
        // 100D:C9FB pop AX
        AX = Stack.Pop16();
        // 100D:C9FC cmp AX,word ptr DS:[0xDBE8]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBE8]);
        // 100D:CA00 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CA01_1CAD1(int loadOffset)
    {
    label_100D_CA01_1CAD1_2511:
        CheckExternalEvents(cs1, 0xCA01);
        // 100D:CA01 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:CA03 xchg BX,word ptr DS:[0x35A6]
        ushort xchgOffset_100D_CA03_1CAD3 = (ushort)0x35A6;
        ushort temp_100D_CA03_1CAD3 = BX;
        BX = UInt16[DS, xchgOffset_100D_CA03_1CAD3];
        UInt16[DS, xchgOffset_100D_CA03_1CAD3] = unchecked((ushort)temp_100D_CA03_1CAD3);
        // 100D:CA07 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:CA09 je short 0xCA18
        if (ZeroFlag)
        {
            goto label_100D_CA18_1CAE8_2516;
        }
    label_100D_CA0B_1CADB_2694:
        CheckExternalEvents(cs1, 0xCA0B);
        // 100D:CA0B call near 0xCE01
        NearCall(cs1, 0xCA0E, unknown_100D_CE01_1CED1);
    label_100D_CA0E_1CADE_2696:
        CheckExternalEvents(cs1, 0xCA0E);
        // 100D:CA0E cmp BX,word ptr DS:[0xDBBA]
        Alu16.Sub(BX, UInt16[DS, (ushort)0xDBBA]);
        // 100D:CA12 je short 0xCA18
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CA12");
        }
    label_100D_CA18_1CAE8_2516:
        CheckExternalEvents(cs1, 0xCA18);
        // 100D:CA18 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:CA1A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CA1B_1CAEB(int loadOffset)
    {
    entrydispatcher:
    label_100D_CA1B_1CAEB_4114:
        CheckExternalEvents(cs1, 0xCA1B);
        // 100D:CA1B call near 0xC92B
        NearCall(cs1, 0xCA1E, unknown_100D_C92B_1C9FB);
    label_100D_CA1E_1CAEE_4210:
        CheckExternalEvents(cs1, 0xCA1E);
        // 100D:CA1E jb short 0xCA01
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CA1E");
        }
    label_100D_CA20_1CAF0_4212:
        CheckExternalEvents(cs1, 0xCA20);
        // 100D:CA20 call near 0xCDA0
        NearCall(cs1, 0xCA23, unknown_100D_CDA0_1CE70);
    label_100D_CA23_1CAF3_4229:
        CheckExternalEvents(cs1, 0xCA23);
        // 100D:CA23 jb short 0xCA01
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CA23");
        }
    label_100D_CA25_1CAF5_4231:
        CheckExternalEvents(cs1, 0xCA25);
        // 100D:CA25 mov byte ptr DS:[0xDCE6],0
        UInt8[DS, (ushort)0xDCE6] = (byte)0x00;
        // 100D:CA2A les SI,word ptr DS:[0xDC10]
        ushort lxsOffset_100D_CA2A_1CAFA = (ushort)0xDC10;
        ushort lxsValue_100D_CA2A_1CAFA = UInt16[DS, lxsOffset_100D_CA2A_1CAFA];
        ushort lxsSegment_100D_CA2A_1CAFA = UInt16[DS, (ushort)(lxsOffset_100D_CA2A_1CAFA + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_CA2A_1CAFA);
        ES = unchecked((ushort)lxsSegment_100D_CA2A_1CAFA);
        // 100D:CA2E lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CA30 mov BP,word ptr DS:[0xDBDE]
        BP = UInt16[DS, (ushort)0xDBDE];
        // 100D:CA34 call near 0xCCF4
        NearCall(cs1, 0xCA37, unknown_100D_CCF4_1CDC4);
    label_100D_CA37_1CB07_4278:
        CheckExternalEvents(cs1, 0xCA37);
        // 100D:CA37 call near 0xAA0F
        NearCall(cs1, 0xCA3A, unknown_100D_AA0F_1AADF);
    label_100D_CA3A_1CB0A_4286:
        CheckExternalEvents(cs1, 0xCA3A);
        // 100D:CA3A call near 0xCC96
        NearCall(cs1, 0xCA3D, unknown_100D_CC96_1CD66);
    label_100D_CA3D_1CB0D_4307:
        CheckExternalEvents(cs1, 0xCA3D);
        // 100D:CA3D call near 0xCE1A
        NearCall(cs1, 0xCA40, unknown_100D_CE1A_1CEEA);
    label_100D_CA40_1CB10_4309:
        CheckExternalEvents(cs1, 0xCA40);
        // 100D:CA40 inc word ptr DS:[0xDBE8]
        UInt16[DS, (ushort)0xDBE8] = Alu16.Inc(UInt16[DS, (ushort)0xDBE8]);
        // 100D:CA44 inc word ptr DS:[0xDBEA]
        UInt16[DS, (ushort)0xDBEA] = Alu16.Inc(UInt16[DS, (ushort)0xDBEA]);
        // 100D:CA48 test byte ptr DS:[0xDBFE],0x40
        Alu8.And(UInt8[DS, (ushort)0xDBFE], (byte)0x40);
        // 100D:CA4D jne short 0xCA59
        if (!ZeroFlag)
        {
            return unknown_100D_CA59_1CB29(0x0000);
        }
    label_100D_CA4F_1CB1F_4314:
        CheckExternalEvents(cs1, 0xCA4F);
        // 100D:CA4F mov CX,0x0032
        CX = (ushort)0x0032;
    label_100D_CA52_1CB22_4316:
        CheckExternalEvents(cs1, 0xCA52);
        // 100D:CA52 push CX
        Stack.Push16(CX);
        // 100D:CA53 call near 0xCB1A
        NearCall(cs1, 0xCA56, unknown_100D_CB1A_1CBEA);
    label_100D_CA56_1CB26_4377:
        CheckExternalEvents(cs1, 0xCA56);
        // 100D:CA56 pop CX
        CX = Stack.Pop16();
        // 100D:CA57 loop 0xCA52
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_CA52_1CB22_4316;
        }
        else
        {
            return unknown_100D_CA59_1CB29(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_CA59_1CB29(int loadOffset)
    {
    label_100D_CA59_1CB29_4423:
        CheckExternalEvents(cs1, 0xCA59);
        // 100D:CA59 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:CA5C mov word ptr DS:[0xDC22],AX
        UInt16[DS, (ushort)0xDC22] = AX;
        // 100D:CA5F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CA60_1CB30(int loadOffset)
    {
    entrydispatcher:
    label_100D_CA60_1CB30_4817:
        CheckExternalEvents(cs1, 0xCA60);
        // 100D:CA60 cmp word ptr DS:[0x35A6],0
        Alu16.Sub(UInt16[DS, (ushort)0x35A6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CA65 je short 0xCA9A
        if (ZeroFlag)
        {
            return unknown_100D_CA9A_1CB6A(0x0000);
        }
    label_100D_CA67_1CB37_4820:
        CheckExternalEvents(cs1, 0xCA67);
        // 100D:CA67 cmp byte ptr DS:[0xDBFE],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBFE], (byte)0x00);
        // 100D:CA6C jns short 0xCA71
        if (!SignFlag)
        {
            goto label_100D_CA71_1CB41_4823;
        }
    label_100D_CA6E_1CB3E_5676:
        CheckExternalEvents(cs1, 0xCA6E);
        // 100D:CA6E call near 0xCA8F
        NearCall(cs1, 0xCA71, unknown_100D_CA8F_1CB5F);
    label_100D_CA71_1CB41_4823:
        CheckExternalEvents(cs1, 0xCA71);
        // 100D:CA71 call near 0xCAA0
        NearCall(cs1, 0xCA74, unknown_100D_CAA0_1CB70);
    label_100D_CA74_1CB44_4849:
        CheckExternalEvents(cs1, 0xCA74);
        // 100D:CA74 jae short 0xCA7B
        if (!CarryFlag)
        {
            goto label_100D_CA7B_1CB4B_4851;
        }
    label_100D_CA76_1CB46_11557:
        CheckExternalEvents(cs1, 0xCA76);
        // 100D:CA76 call near 0xCB1A
        NearCall(cs1, 0xCA79, unknown_100D_CB1A_1CBEA);
    label_100D_CA79_1CB49_11559:
        CheckExternalEvents(cs1, 0xCA79);
        // 100D:CA79 jmp short 0xCA60
        goto label_100D_CA60_1CB30_4817;
    label_100D_CA7B_1CB4B_4851:
        CheckExternalEvents(cs1, 0xCA7B);
        // 100D:CA7B call near 0xCAD4
        NearCall(cs1, 0xCA7E, unknown_100D_CAD4_1CBA4);
    label_100D_CA7E_1CB4E_4867:
        CheckExternalEvents(cs1, 0xCA7E);
        // 100D:CA7E jb short 0xCA8F
        if (CarryFlag)
        {
            return unknown_100D_CA8F_1CB5F(0x0000);
        }
    label_100D_CA80_1CB50_4869:
        CheckExternalEvents(cs1, 0xCA80);
        // 100D:CA80 mov AX,word ptr DS:[0xDC1E]
        AX = UInt16[DS, (ushort)0xDC1E];
        // 100D:CA83 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CA84 je short 0xCA89
        if (ZeroFlag)
        {
            goto label_100D_CA89_1CB59_4873;
        }
    label_100D_CA86_1CB56_4999:
        CheckExternalEvents(cs1, 0xCA86);
        // 100D:CA86 call near 0xCE3B
        NearCall(cs1, 0xCA89, unknown_100D_CE3B_1CF0B);
    label_100D_CA89_1CB59_4873:
        CheckExternalEvents(cs1, 0xCA89);
        // 100D:CA89 call near 0xCC96
        NearCall(cs1, 0xCA8C, unknown_100D_CC96_1CD66);
    label_100D_CA8C_1CB5C_4875:
        CheckExternalEvents(cs1, 0xCA8C);
        // 100D:CA8C call near 0xCC4E
        NearCall(cs1, 0xCA8F, unknown_100D_CC4E_1CD1E);
        return unknown_100D_CA8F_1CB5F(0x0000);
    }

    public virtual Action unknown_100D_CA8F_1CB5F(int loadOffset)
    {
    label_100D_CA8F_1CB5F_4895:
        CheckExternalEvents(cs1, 0xCA8F);
        // 100D:CA8F mov AL,byte ptr DS:[0xDBFE]
        AL = UInt8[DS, (ushort)0xDBFE];
        // 100D:CA92 and AL,0x80
        AL = Alu8.And(AL, (byte)0x80);
        // 100D:CA94 mov byte ptr DS:[0xDBB5],AL
        UInt8[DS, (ushort)0xDBB5] = AL;
        // 100D:CA97 call near 0xCB1A
        NearCall(cs1, 0xCA9A, unknown_100D_CB1A_1CBEA);
        return unknown_100D_CA9A_1CB6A(0x0000);
    }

    public virtual Action unknown_100D_CA9A_1CB6A(int loadOffset)
    {
    label_100D_CA9A_1CB6A_4905:
        CheckExternalEvents(cs1, 0xCA9A);
        // 100D:CA9A mov byte ptr DS:[0xDBB5],0
        UInt8[DS, (ushort)0xDBB5] = (byte)0x00;
        // 100D:CA9F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CAA0_1CB70(int loadOffset)
    {
    label_100D_CAA0_1CB70_4825:
        CheckExternalEvents(cs1, 0xCAA0);
        // 100D:CAA0 cmp word ptr DS:[0xDC16],0
        Alu16.Sub(UInt16[DS, (ushort)0xDC16], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CAA5 ja short 0xCAD3
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_CAD3_1CBA3_4848;
        }
    label_100D_CAA7_1CB77_4828:
        CheckExternalEvents(cs1, 0xCAA7);
        // 100D:CAA7 mov CX,word ptr DS:[0xDC1A]
        CX = UInt16[DS, (ushort)0xDC1A];
        // 100D:CAAB stc
        CarryFlag = true;
        // 100D:CAAC jcxz short 0xCAD3
        if (CX == (ushort)0x0000)
        {
            goto label_100D_CAD3_1CBA3_4848;
        }
    label_100D_CAAE_1CB7E_4832:
        CheckExternalEvents(cs1, 0xCAAE);
        // 100D:CAAE les SI,word ptr DS:[0xDC10]
        ushort lxsOffset_100D_CAAE_1CB7E = (ushort)0xDC10;
        ushort lxsValue_100D_CAAE_1CB7E = UInt16[DS, lxsOffset_100D_CAAE_1CB7E];
        ushort lxsSegment_100D_CAAE_1CB7E = UInt16[DS, (ushort)(lxsOffset_100D_CAAE_1CB7E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_CAAE_1CB7E);
        ES = unchecked((ushort)lxsSegment_100D_CAAE_1CB7E);
        // 100D:CAB2 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CAB4 cmp word ptr ES:[SI],0x6D6D
        Alu16.Sub(UInt16[ES, SI], (ushort)0x6D6D);
        // 100D:CAB9 je short 0xCABF
        if (ZeroFlag)
        {
            goto label_100D_CABF_1CB8F_4840;
        }
    label_100D_CABB_1CB8B_4837:
        CheckExternalEvents(cs1, 0xCABB);
        // 100D:CABB cmp CX,AX
        Alu16.Sub(CX, AX);
        // 100D:CABD jb short 0xCAD3
        if (CarryFlag)
        {
            goto label_100D_CAD3_1CBA3_4848;
        }
    label_100D_CABF_1CB8F_4840:
        CheckExternalEvents(cs1, 0xCABF);
        // 100D:CABF mov BP,word ptr DS:[0xDBD6]
        BP = UInt16[DS, (ushort)0xDBD6];
        // 100D:CAC3 test byte ptr DS:[0xDBFE],0x40
        Alu8.And(UInt8[DS, (ushort)0xDBFE], (byte)0x40);
        // 100D:CAC8 je short 0xCACE
        if (ZeroFlag)
        {
            goto label_100D_CACE_1CB9E_4844;
        }
    label_100D_CACA_1CB9A_11561:
        CheckExternalEvents(cs1, 0xCACA);
        // 100D:CACA mov BP,word ptr DS:[0xDC32]
        BP = UInt16[DS, (ushort)0xDC32];
    label_100D_CACE_1CB9E_4844:
        CheckExternalEvents(cs1, 0xCACE);
        // 100D:CACE call near 0xCCF4
        NearCall(cs1, 0xCAD1, unknown_100D_CCF4_1CDC4);
    label_100D_CAD1_1CBA1_4846:
        CheckExternalEvents(cs1, 0xCAD1);
        // 100D:CAD1 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_CAD3_1CBA3_4848:
        CheckExternalEvents(cs1, 0xCAD3);
        // 100D:CAD3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CAD4_1CBA4(int loadOffset)
    {
    label_100D_CAD4_1CBA4_4853:
        CheckExternalEvents(cs1, 0xCAD4);
        // 100D:CAD4 mov AX,word ptr DS:[0xDC1C]
        AX = UInt16[DS, (ushort)0xDC1C];
        // 100D:CAD7 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CAD8 jne short 0xCAF0
        if (!ZeroFlag)
        {
            goto label_100D_CAF0_1CBC0_5678;
        }
    label_100D_CADA_1CBAA_4857:
        CheckExternalEvents(cs1, 0xCADA);
        // 100D:CADA mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:CADD sub AX,word ptr DS:[0xDC22]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xDC22]);
        // 100D:CAE1 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:CAE3 jne short 0xCAEB
        if (!ZeroFlag)
        {
            goto label_100D_CAEB_1CBBB_4862;
        }
    label_100D_CAE5_1CBB5_4928:
        CheckExternalEvents(cs1, 0xCAE5);
        // 100D:CAE5 cmp AL,byte ptr DS:[0xDBFF]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDBFF]);
        // 100D:CAE9 jb short 0xCAEF
        if (CarryFlag)
        {
            goto label_100D_CAEF_1CBBF_4866;
        }
    label_100D_CAEB_1CBBB_4862:
        CheckExternalEvents(cs1, 0xCAEB);
        // 100D:CAEB call near 0xCA59
        NearCall(cs1, 0xCAEE, unknown_100D_CA59_1CB29);
    label_100D_CAEE_1CBBE_4864:
        CheckExternalEvents(cs1, 0xCAEE);
        // 100D:CAEE clc
        CarryFlag = false;
    label_100D_CAEF_1CBBF_4866:
        CheckExternalEvents(cs1, 0xCAEF);
        // 100D:CAEF ret near
        return NearRet((ushort)0x0000);
    label_100D_CAF0_1CBC0_5678:
        CheckExternalEvents(cs1, 0xCAF0);
        // 100D:CAF0 mov SI,word ptr DS:[0x3824]
        SI = UInt16[DS, (ushort)0x3824];
        // 100D:CAF4 cmp byte ptr DS:[SI+6],1
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)6)], (byte)0x01);
        // 100D:CAF8 cmc
        CarryFlag = !CarryFlag;
        // 100D:CAF9 jb short 0xCAEF
        if (CarryFlag)
        {
            goto label_100D_CAEF_1CBBF_4866;
        }
    label_100D_CAFB_1CBCB_5683:
        CheckExternalEvents(cs1, 0xCAFB);
        // 100D:CAFB call near 0xA9F4
        NearCall(cs1, 0xCAFE, unknown_100D_A9F4_1AAC4);
    label_100D_CAFE_1CBCE_5696:
        CheckExternalEvents(cs1, 0xCAFE);
        // 100D:CAFE clc
        CarryFlag = false;
        // 100D:CAFF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CB1A_1CBEA(int loadOffset)
    {
        goto label_100D_CB1A_1CBEA_4318;

    label_100D_CB00_1CBD0_4321:
        CheckExternalEvents(cs1, 0xCB00);
        // 100D:CB00 mov AX,word ptr DS:[0xDBEA]
        AX = UInt16[DS, (ushort)0xDBEA];
        // 100D:CB03 cmp AX,word ptr DS:[0xDBEE]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBEE]);
        // 100D:CB07 je short 0xCB61
        if (ZeroFlag)
        {
            goto label_100D_CB61_1CC31_5101;
        }
    label_100D_CB09_1CBD9_4325:
        CheckExternalEvents(cs1, 0xCB09);
        // 100D:CB09 mov AX,word ptr DS:[0xDC08]
        AX = UInt16[DS, (ushort)0xDC08];
        // 100D:CB0C or AX,word ptr DS:[0xDC0A]
        AX = Alu16.Or(AX, UInt16[DS, (ushort)0xDC0A]);
        // 100D:CB10 je short 0xCB61
        if (ZeroFlag)
        {
            goto label_100D_CB61_1CC31_5101;
        }
    label_100D_CB12_1CBE2_4329:
        CheckExternalEvents(cs1, 0xCB12);
        // 100D:CB12 call near 0xCD8F
        NearCall(cs1, 0xCB15, unknown_100D_CD8F_1CE5F);
    label_100D_CB15_1CBE5_4331:
        CheckExternalEvents(cs1, 0xCB15);
        // 100D:CB15 jb short 0xCB44
        if (CarryFlag)
        {
            goto label_100D_CB44_1CC14_4421;
        }
    label_100D_CB17_1CBE7_4333:
        CheckExternalEvents(cs1, 0xCB17);
        // 100D:CB17 call near 0xCC0C
        NearCall(cs1, 0xCB1A, unknown_100D_CC0C_1CCDC);
    label_100D_CB1A_1CBEA_4318:
        CheckExternalEvents(cs1, 0xCB1A);
        // 100D:CB1A mov CX,word ptr DS:[0xDC20]
        CX = UInt16[DS, (ushort)0xDC20];
        // 100D:CB1E jcxz short 0xCB00
        if (CX == (ushort)0x0000)
        {
            goto label_100D_CB00_1CBD0_4321;
        }
    label_100D_CB20_1CBF0_4346:
        CheckExternalEvents(cs1, 0xCB20);
        // 100D:CB20 cmp byte ptr DS:[0xDBFE],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBFE], (byte)0x00);
        // 100D:CB25 js short 0xCB38
        if (SignFlag)
        {
            goto label_100D_CB38_1CC08_4358;
        }
    label_100D_CB27_1CBF7_4349:
        CheckExternalEvents(cs1, 0xCB27);
        // 100D:CB27 mov AX,word ptr DS:[0xDC04]
        AX = UInt16[DS, (ushort)0xDC04];
        // 100D:CB2A neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:CB2C and AX,0x07FF
        AX = Alu16.And(AX, (ushort)0x07FF);
        // 100D:CB2F add AH,8
        AH = Alu8.Add(AH, (byte)0x08);
        // 100D:CB32 cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:CB34 jae short 0xCB38
        if (!CarryFlag)
        {
            goto label_100D_CB38_1CC08_4358;
        }
    label_100D_CB36_1CC06_4356:
        CheckExternalEvents(cs1, 0xCB36);
        // 100D:CB36 mov CX,AX
        CX = AX;
    label_100D_CB38_1CC08_4358:
        CheckExternalEvents(cs1, 0xCB38);
        // 100D:CB38 call near 0xCC2B
        NearCall(cs1, 0xCB3B, unknown_100D_CC2B_1CCFB);
    label_100D_CB3B_1CC0B_4372:
        CheckExternalEvents(cs1, 0xCB3B);
        // 100D:CB3B jb short 0xCB44
        if (CarryFlag)
        {
            goto label_100D_CB44_1CC14_4421;
        }
    label_100D_CB3D_1CC0D_4374:
        CheckExternalEvents(cs1, 0xCB3D);
        // 100D:CB3D sub word ptr DS:[0xDC20],CX
        UInt16[DS, (ushort)0xDC20] = Alu16.Sub(UInt16[DS, (ushort)0xDC20], CX);
        // 100D:CB41 jmp near 0xCDBF
        return unknown_100D_CDBF_1CE8F(0x0000);
    label_100D_CB44_1CC14_4421:
        CheckExternalEvents(cs1, 0xCB44);
        // 100D:CB44 ret near
        return NearRet((ushort)0x0000);
    label_100D_CB4C_1CC1C_5104:
        CheckExternalEvents(cs1, 0xCB4C);
        // 100D:CB4C or byte ptr DS:[0xDBE7],1
        UInt8[DS, (ushort)0xDBE7] = Alu8.Or(UInt8[DS, (ushort)0xDBE7], (byte)0x01);
        // 100D:CB51 cmp word ptr DS:[0xDC1A],0
        Alu16.Sub(UInt16[DS, (ushort)0xDC1A], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CB56 jne short 0xCB60
        if (!ZeroFlag)
        {
            goto label_100D_CB60_1CC30_5108;
        }
    label_100D_CB58_1CC28_5112:
        CheckExternalEvents(cs1, 0xCB58);
        // 100D:CB58 or byte ptr DS:[0xDBE7],2
        UInt8[DS, (ushort)0xDBE7] = Alu8.Or(UInt8[DS, (ushort)0xDBE7], (byte)0x02);
        // 100D:CB5D call near 0xCA01
        NearCall(cs1, 0xCB60, unknown_100D_CA01_1CAD1);
    label_100D_CB60_1CC30_5108:
        CheckExternalEvents(cs1, 0xCB60);
        // 100D:CB60 ret near
        return NearRet((ushort)0x0000);
    label_100D_CB61_1CC31_5101:
        CheckExternalEvents(cs1, 0xCB61);
        // 100D:CB61 test byte ptr DS:[0xDBFE],1
        Alu8.And(UInt8[DS, (ushort)0xDBFE], (byte)0x01);
        // 100D:CB66 je short 0xCB4C
        if (ZeroFlag)
        {
            goto label_100D_CB4C_1CC1C_5104;
        }
    label_100D_CB68_1CC38_22375:
        CheckExternalEvents(cs1, 0xCB68);
        // 100D:CB68 mov CX,0x1000
        CX = (ushort)0x1000;
        // 100D:CB6B call near 0xCC2B
        NearCall(cs1, 0xCB6E, unknown_100D_CC2B_1CCFB);
    label_100D_CB6E_1CC3E_22378:
        CheckExternalEvents(cs1, 0xCB6E);
        // 100D:CB6E jb short 0xCB44
        if (CarryFlag)
        {
            goto label_100D_CB44_1CC14_4421;
        }
    label_100D_CB70_1CC40_22380:
        CheckExternalEvents(cs1, 0xCB70);
        // 100D:CB70 mov AX,word ptr DS:[0xDBEA]
        AX = UInt16[DS, (ushort)0xDBEA];
        // 100D:CB73 call near 0xCE07
        NearCall(cs1, 0xCB76, unknown_100D_CE07_1CED7);
    label_100D_CB76_1CC46_22384:
        CheckExternalEvents(cs1, 0xCB76);
        // 100D:CB76 mov word ptr DS:[0xDBEC],AX
        UInt16[DS, (ushort)0xDBEC] = AX;
        // 100D:CB79 call near 0xCA9A
        NearCall(cs1, 0xCB7C, unknown_100D_CA9A_1CB6A);
    label_100D_CB7C_1CC4C_22387:
        CheckExternalEvents(cs1, 0xCB7C);
        // 100D:CB7C mov AX,word ptr DS:[0xDC02]
        AX = UInt16[DS, (ushort)0xDC02];
        // 100D:CB7F cmp AX,word ptr DS:[0xDC00]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDC00]);
        // 100D:CB83 je short 0xCBA0
        if (ZeroFlag)
        {
            goto label_100D_CBA0_1CC70_22406;
        }
    label_100D_CB85_1CC55_22391:
        CheckExternalEvents(cs1, 0xCB85);
        // 100D:CB85 call near 0xC921
        NearCall(cs1, 0xCB88, unknown_100D_C921_1C9F1);
    label_100D_CB88_1CC58_22393:
        CheckExternalEvents(cs1, 0xCB88);
        // 100D:CB88 test byte ptr DS:[BX],8
        Alu8.And(UInt8[DS, BX], (byte)0x08);
        // 100D:CB8B je short 0xCB45
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CB8B");
        }
    label_100D_CB8D_1CC5D_22396:
        CheckExternalEvents(cs1, 0xCB8D);
        // 100D:CB8D cmp word ptr DS:[BX-6],0
        Alu16.Sub(UInt16[DS, (ushort)(BX + (sbyte)-6)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CB91 je short 0xCB45
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CB91");
        }
    label_100D_CB93_1CC63_22399:
        CheckExternalEvents(cs1, 0xCB93);
        // 100D:CB93 mov word ptr DS:[0xDC00],AX
        UInt16[DS, (ushort)0xDC00] = AX;
        // 100D:CB96 lea SI,BX-8
        SI = unchecked((ushort)(BX + (sbyte)-8));
        // 100D:CB99 mov DI,0xDBF6
        DI = (ushort)0xDBF6;
        // 100D:CB9C call near 0x5B99
        NearCall(cs1, 0xCB9F, unknown_100D_5B99_15C69);
    label_100D_CB9F_1CC6F_22404:
        CheckExternalEvents(cs1, 0xCB9F);
        // 100D:CB9F movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_100D_CBA0_1CC70_22406:
        CheckExternalEvents(cs1, 0xCBA0);
        // 100D:CBA0 mov AX,word ptr DS:[0xDBFA]
        AX = UInt16[DS, (ushort)0xDBFA];
        // 100D:CBA3 mov word ptr DS:[0xDC08],AX
        UInt16[DS, (ushort)0xDC08] = AX;
        // 100D:CBA6 mov AX,word ptr DS:[0xDBFC]
        AX = UInt16[DS, (ushort)0xDBFC];
        // 100D:CBA9 mov word ptr DS:[0xDC0A],AX
        UInt16[DS, (ushort)0xDC0A] = AX;
        // 100D:CBAC mov AX,word ptr DS:[0xDBF6]
        AX = UInt16[DS, (ushort)0xDBF6];
        // 100D:CBAF mov word ptr DS:[0xDC04],AX
        UInt16[DS, (ushort)0xDC04] = AX;
        // 100D:CBB2 mov AX,word ptr DS:[0xDBF8]
        AX = UInt16[DS, (ushort)0xDBF8];
        // 100D:CBB5 mov word ptr DS:[0xDC06],AX
        UInt16[DS, (ushort)0xDC06] = AX;
        // 100D:CBB8 test byte ptr DS:[0xDBFE],4
        Alu8.And(UInt8[DS, (ushort)0xDBFE], (byte)0x04);
        // 100D:CBBD je short 0xCC09
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CBBD");
        }
    label_100D_CC09_1CCD9_22416:
        CheckExternalEvents(cs1, 0xCC09);
        // 100D:CC09 jmp near 0xCB00
        goto label_100D_CB00_1CBD0_4321;
    }

    public virtual Action unknown_100D_CC0C_1CCDC(int loadOffset)
    {
    label_100D_CC0C_1CCDC_4335:
        CheckExternalEvents(cs1, 0xCC0C);
        // 100D:CC0C add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:CC0E jb short 0xCC16
        if (CarryFlag)
        {
            goto label_100D_CC16_1CCE6_4416;
        }
    label_100D_CC10_1CCE0_4338:
        CheckExternalEvents(cs1, 0xCC10);
        // 100D:CC10 cmp SI,word ptr DS:[0xCE74]
        Alu16.Sub(SI, UInt16[DS, (ushort)0xCE74]);
        // 100D:CC14 jbe short 0xCC20
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_CC20_1CCF0_4341;
        }
    label_100D_CC16_1CCE6_4416:
        CheckExternalEvents(cs1, 0xCC16);
        // 100D:CC16 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:CC18 xchg CX,word ptr DS:[0xDC0C]
        ushort xchgOffset_100D_CC18_1CCE8 = (ushort)0xDC0C;
        ushort temp_100D_CC18_1CCE8 = CX;
        CX = UInt16[DS, xchgOffset_100D_CC18_1CCE8];
        UInt16[DS, xchgOffset_100D_CC18_1CCE8] = unchecked((ushort)temp_100D_CC18_1CCE8);
        // 100D:CC1C mov word ptr DS:[0xDC18],CX
        UInt16[DS, (ushort)0xDC18] = CX;
    label_100D_CC20_1CCF0_4341:
        CheckExternalEvents(cs1, 0xCC20);
        // 100D:CC20 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:CC23 mov word ptr DS:[0xDC20],AX
        UInt16[DS, (ushort)0xDC20] = AX;
        // 100D:CC26 inc word ptr DS:[0xDBEA]
        UInt16[DS, (ushort)0xDBEA] = Alu16.Inc(UInt16[DS, (ushort)0xDBEA]);
        // 100D:CC2A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CC2B_1CCFB(int loadOffset)
    {
    label_100D_CC2B_1CCFB_4359:
        CheckExternalEvents(cs1, 0xCC2B);
        // 100D:CC2B mov AX,word ptr DS:[0xDC0C]
        AX = UInt16[DS, (ushort)0xDC0C];
        // 100D:CC2E mov BX,word ptr DS:[0xDC10]
        BX = UInt16[DS, (ushort)0xDC10];
        // 100D:CC32 cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:CC34 jae short 0xCC3F
        if (!CarryFlag)
        {
            goto label_100D_CC3F_1CD0F_4364;
        }
    label_100D_CC36_1CD06_4900:
        CheckExternalEvents(cs1, 0xCC36);
        // 100D:CC36 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:CC38 add AX,0x0012
        AX = Alu16.Add(AX, (ushort)0x0012);
        // 100D:CC3B cmp BX,AX
        Alu16.Sub(BX, AX);
        // 100D:CC3D jb short 0xCC4D
        if (CarryFlag)
        {
            goto label_100D_CC4D_1CD1D_4371;
        }
    label_100D_CC3F_1CD0F_4364:
        CheckExternalEvents(cs1, 0xCC3F);
        // 100D:CC3F mov AX,word ptr DS:[0xDC1A]
        AX = UInt16[DS, (ushort)0xDC1A];
        // 100D:CC42 add AX,0x000A
        AX = Alu16.Add(AX, (ushort)0x000A);
        // 100D:CC45 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:CC47 jb short 0xCC4D
        if (CarryFlag)
        {
            goto label_100D_CC4D_1CD1D_4371;
        }
    label_100D_CC49_1CD19_4369:
        CheckExternalEvents(cs1, 0xCC49);
        // 100D:CC49 cmp word ptr DS:[0xDC18],AX
        Alu16.Sub(UInt16[DS, (ushort)0xDC18], AX);
    label_100D_CC4D_1CD1D_4371:
        CheckExternalEvents(cs1, 0xCC4D);
        // 100D:CC4D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CC4E_1CD1E(int loadOffset)
    {
    label_100D_CC4E_1CD1E_4877:
        CheckExternalEvents(cs1, 0xCC4E);
        // 100D:CC4E les SI,word ptr DS:[0xDC10]
        ushort lxsOffset_100D_CC4E_1CD1E = (ushort)0xDC10;
        ushort lxsValue_100D_CC4E_1CD1E = UInt16[DS, lxsOffset_100D_CC4E_1CD1E];
        ushort lxsSegment_100D_CC4E_1CD1E = UInt16[DS, (ushort)(lxsOffset_100D_CC4E_1CD1E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_CC4E_1CD1E);
        ES = unchecked((ushort)lxsSegment_100D_CC4E_1CD1E);
        // 100D:CC52 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CC54 sub word ptr DS:[0xDC1A],AX
        UInt16[DS, (ushort)0xDC1A] = Alu16.Sub(UInt16[DS, (ushort)0xDC1A], AX);
        // 100D:CC58 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:CC5A jb short 0xCC62
        if (CarryFlag)
        {
            goto label_100D_CC62_1CD32_4938;
        }
    label_100D_CC5C_1CD2C_4883:
        CheckExternalEvents(cs1, 0xCC5C);
        // 100D:CC5C cmp SI,word ptr DS:[0xCE74]
        Alu16.Sub(SI, UInt16[DS, (ushort)0xCE74]);
        // 100D:CC60 jbe short 0xCC6A
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_CC6A_1CD3A_4886;
        }
    label_100D_CC62_1CD32_4938:
        CheckExternalEvents(cs1, 0xCC62);
        // 100D:CC62 sub AX,2
        AX = Alu16.Sub(AX, (ushort)0x0002);
        // 100D:CC65 mov word ptr DS:[0xDC10],AX
        UInt16[DS, (ushort)0xDC10] = AX;
        // 100D:CC68 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_CC6A_1CD3A_4886:
        CheckExternalEvents(cs1, 0xCC6A);
        // 100D:CC6A add word ptr DS:[0xDC10],AX
        UInt16[DS, (ushort)0xDC10] = Alu16.Add(UInt16[DS, (ushort)0xDC10], AX);
        // 100D:CC6E mov AX,word ptr DS:[0xDBE8]
        AX = UInt16[DS, (ushort)0xDBE8];
        // 100D:CC71 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CC72 cmp AX,word ptr DS:[0xDBEC]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xDBEC]);
        // 100D:CC76 jbe short 0xCC81
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_CC81_1CD51_4892;
        }
    label_100D_CC78_1CD48_22418:
        CheckExternalEvents(cs1, 0xCC78);
        // 100D:CC78 mov AX,1
        AX = (ushort)0x0001;
        // 100D:CC7B mov word ptr DS:[0xDBEC],0xFFFF
        UInt16[DS, (ushort)0xDBEC] = (ushort)0xFFFF;
    label_100D_CC81_1CD51_4892:
        CheckExternalEvents(cs1, 0xCC81);
        // 100D:CC81 mov word ptr DS:[0xDBE8],AX
        UInt16[DS, (ushort)0xDBE8] = AX;
        // 100D:CC84 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CC85_1CD55(int loadOffset)
    {
    label_100D_CC85_1CD55_4921:
        CheckExternalEvents(cs1, 0xCC85);
        // 100D:CC85 cmp byte ptr DS:[0xDBE7],0
        Alu8.Sub(UInt8[DS, (ushort)0xDBE7], (byte)0x00);
        // 100D:CC8A je short 0xCC91
        if (ZeroFlag)
        {
            goto label_100D_CC91_1CD61_4924;
        }
    label_100D_CC8C_1CD5C_5110:
        CheckExternalEvents(cs1, 0xCC8C);
        // 100D:CC8C cmp byte ptr DS:[0xDBE7],1
        Alu8.Sub(UInt8[DS, (ushort)0xDBE7], (byte)0x01);
    label_100D_CC91_1CD61_4924:
        CheckExternalEvents(cs1, 0xCC91);
        // 100D:CC91 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CC96_1CD66(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_CC96_1CD66_4288;

    label_100D_4AFD_14BCD_6474:
        CheckExternalEvents(cs1, 0x4AFD);
        // 100D:4AFD cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:4B02 jne short 0x4B16
        if (!ZeroFlag)
        {
            return unknown_100D_4B16_14BE6(0x0000);
        }
    label_100D_4B04_14BD4_22030:
        CheckExternalEvents(cs1, 0x4B04);
        // 100D:4B04 call near 0x4B2B
        NearCall(cs1, 0x4B07, unknown_100D_4B2B_14BFB);
    label_100D_4B07_14BD7_22056:
        CheckExternalEvents(cs1, 0x4B07);
        // 100D:4B07 mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:4B0B mov SI,word ptr DS:[0xDBD6]
        SI = UInt16[DS, (ushort)0xDBD6];
        // 100D:4B0F call far dword ptr DS:[0x38FD]
        ushort targetSegment_22059 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38FD + (ushort)0x0002)]));
        ushort targetOffset_22059 = unchecked((ushort)(UInt16[DS, (ushort)0x38FD]));
        if (targetSegment_22059 == cs2 && targetOffset_22059 == 0x0136)
        {
            FarCall(cs1, 0x4B13, cs2, unknown_3358_0136_336B6);
            goto label_100D_4B13_14BE3_22060;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_22059:X4}:{targetOffset_22059:X4} at 100D:4B0F");
    label_100D_4B13_14BE3_22060:
        CheckExternalEvents(cs1, 0x4B13);
        // 100D:4B13 jmp near 0xDBE3
        goto label_100D_DBE3_1DCB3_22062;
    label_100D_CC96_1CD66_4288:
        CheckExternalEvents(cs1, 0xCC96);
        // 100D:CC96 mov AX,word ptr DS:[0x38FB]
        AX = UInt16[DS, (ushort)0x38FB];
        // 100D:CC99 mov word ptr CS:[0xCC94],AX
        UInt16[CS, (ushort)0xCC94] = AX;
        // 100D:CC9D xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:CC9F xchg BP,word ptr DS:[0xDC16]
        ushort xchgOffset_100D_CC9F_1CD6F = (ushort)0xDC16;
        ushort temp_100D_CC9F_1CD6F = BP;
        BP = UInt16[DS, xchgOffset_100D_CC9F_1CD6F];
        UInt16[DS, xchgOffset_100D_CC9F_1CD6F] = unchecked((ushort)temp_100D_CC9F_1CD6F);
        // 100D:CCA3 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 100D:CCA5 je short 0xCC4D
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CCA5");
        }
    label_100D_CCA7_1CD77_4295:
        CheckExternalEvents(cs1, 0xCCA7);
        // 100D:CCA7 mov SI,word ptr DS:[0xDC14]
        SI = UInt16[DS, (ushort)0xDC14];
        // 100D:CCAB mov AL,byte ptr DS:[0xDBFE]
        AL = UInt8[DS, (ushort)0xDBFE];
        // 100D:CCAE test AL,0x30
        Alu8.And(AL, (byte)0x30);
        // 100D:CCB0 jne short 0xCCEA
        if (!ZeroFlag)
        {
            goto label_100D_CCEA_1CDBA_6469;
        }
    label_100D_CCB2_1CD82_4300:
        CheckExternalEvents(cs1, 0xCCB2);
        // 100D:CCB2 push DS
        Stack.Push16(DS);
        // 100D:CCB3 test word ptr DS:[0xDC24],0x0400
        Alu16.And(UInt16[DS, (ushort)0xDC24], (ushort)0x0400);
        // 100D:CCB9 jne short 0xCCE1
        if (!ZeroFlag)
        {
            goto label_100D_CCE1_1CDB1_4304;
        }
    label_100D_CCBB_1CD8B_5288:
        CheckExternalEvents(cs1, 0xCCBB);
        // 100D:CCBB mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:CCBF mov BX,word ptr DS:[0xDC00]
        BX = UInt16[DS, (ushort)0xDC00];
        // 100D:CCC3 mov DS,BP
        DS = BP;
        // 100D:CCC5 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CCC6 and AH,0xF9
        AH = Alu8.And(AH, (byte)0xF9);
        // 100D:CCC9 mov DI,AX
        DI = AX;
        // 100D:CCCB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CCCC mov CX,AX
        CX = AX;
        // 100D:CCCE or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:CCD0 je short 0xCCE1
        if (ZeroFlag)
        {
            goto label_100D_CCE1_1CDB1_4304;
        }
    label_100D_CCD2_1CDA2_5299:
        CheckExternalEvents(cs1, 0xCCD2);
        // 100D:CCD2 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CCD3 mov DX,AX
        DX = AX;
        // 100D:CCD5 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CCD6 xchg BX,AX
        ushort temp_100D_CCD6_1CDA6 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_CCD6_1CDA6);
        // 100D:CCD7 cmp AX,0x0019
        Alu16.Sub(AX, (ushort)0x0019);
        // 100D:CCDA jae short 0xCCE3
        if (!CarryFlag)
        {
            goto label_100D_CCE3_1CDB3_5594;
        }
    label_100D_CCDC_1CDAC_5306:
        CheckExternalEvents(cs1, 0xCCDC);
        // 100D:CCDC call far dword ptr SS:[0x38C9]
        ushort targetSegment_5306 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38C9 + (ushort)0x0002)]));
        ushort targetOffset_5306 = unchecked((ushort)(UInt16[SS, (ushort)0x38C9]));
        if (targetSegment_5306 == cs2 && targetOffset_5306 == 0x010F)
        {
            FarCall(cs1, 0xCCE1, cs2, unknown_3358_010F_3368F);
            goto label_100D_CCE1_1CDB1_4304;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5306:X4}:{targetOffset_5306:X4} at 100D:CCDC");
    label_100D_CCE1_1CDB1_4304:
        CheckExternalEvents(cs1, 0xCCE1);
        // 100D:CCE1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CCE2 ret near
        return NearRet((ushort)0x0000);
    label_100D_CCE3_1CDB3_5594:
        CheckExternalEvents(cs1, 0xCCE3);
        // 100D:CCE3 call far dword ptr CS:[0xCC92]
        ushort targetSegment_5594 = unchecked((ushort)(UInt16[CS, (ushort)((ushort)0xCC92 + (ushort)0x0002)]));
        ushort targetOffset_5594 = unchecked((ushort)(UInt16[CS, (ushort)0xCC92]));
        if (targetSegment_5594 == cs2 && targetOffset_5594 == 0x0133)
        {
            FarCall(cs1, 0xCCE8, cs2, unknown_3358_0133_336B3);
            goto label_100D_CCE8_1CDB8_5619;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5594:X4}:{targetOffset_5594:X4} at 100D:CCE3");
    label_100D_CCE8_1CDB8_5619:
        CheckExternalEvents(cs1, 0xCCE8);
        // 100D:CCE8 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CCE9 ret near
        return NearRet((ushort)0x0000);
    label_100D_CCEA_1CDBA_6469:
        CheckExternalEvents(cs1, 0xCCEA);
        // 100D:CCEA test AL,0x20
        Alu8.And(AL, (byte)0x20);
        // 100D:CCEC jne short 0xCCF1
        if (!ZeroFlag)
        {
            goto label_100D_CCF1_1CDC1_35204;
        }
    label_100D_CCEE_1CDBE_6472:
        CheckExternalEvents(cs1, 0xCCEE);
        // 100D:CCEE jmp near 0x4AFD
        goto label_100D_4AFD_14BCD_6474;
    label_100D_CCF1_1CDC1_35204:
        CheckExternalEvents(cs1, 0xCCF1);
        // 100D:CCF1 jmp near 0x4AEB
        return unknown_100D_4AEB_14BBB(0x0000);
    label_100D_DBE3_1DCB3_22062:
        CheckExternalEvents(cs1, 0xDBE3);
        // 100D:DBE3 mov AX,word ptr DS:[0xDC44]
        AX = UInt16[DS, (ushort)0xDC44];
        // 100D:DBE6 cmp AX,0x0098
        Alu16.Sub(AX, (ushort)0x0098);
        // 100D:DBE9 jb short 0xDBEC
        if (CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_DBEC_1DCBC, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_DBEB_1DCBB_22353:
        CheckExternalEvents(cs1, 0xDBEB);
        // 100D:DBEB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CCF4_1CDC4(int loadOffset)
    {
    label_100D_CCF4_1CDC4_4237:
        CheckExternalEvents(cs1, 0xCCF4);
        // 100D:CCF4 mov word ptr DS:[0xDC1C],0xFFFF
        UInt16[DS, (ushort)0xDC1C] = (ushort)0xFFFF;
        // 100D:CCFA mov word ptr DS:[0xDC1E],0xFFFF
        UInt16[DS, (ushort)0xDC1E] = (ushort)0xFFFF;
        // 100D:CD00 add AX,SI
        AX = Alu16.Add(AX, SI);
        // 100D:CD02 jb short 0xCD0A
        if (CarryFlag)
        {
            goto label_100D_CD0A_1CDDA_4936;
        }
    label_100D_CD04_1CDD4_4242:
        CheckExternalEvents(cs1, 0xCD04);
        // 100D:CD04 cmp AX,word ptr DS:[0xCE74]
        Alu16.Sub(AX, UInt16[DS, (ushort)0xCE74]);
        // 100D:CD08 jbe short 0xCD0C
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_CD0C_1CDDC_4245;
        }
    label_100D_CD0A_1CDDA_4936:
        CheckExternalEvents(cs1, 0xCD0A);
        // 100D:CD0A xor SI,SI
        SI = Alu16.Xor(SI, SI);
    label_100D_CD0C_1CDDC_4245:
        CheckExternalEvents(cs1, 0xCD0C);
        // 100D:CD0C lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CD0E cmp AX,0x6473
        Alu16.Sub(AX, (ushort)0x6473);
        // 100D:CD11 jne short 0xCD25
        if (!ZeroFlag)
        {
            goto label_100D_CD25_1CDF5_4249;
        }
    label_100D_CD13_1CDE3_5505:
        CheckExternalEvents(cs1, 0xCD13);
        // 100D:CD13 call near 0xAE2F
        NearCall(cs1, 0xCD16, unknown_100D_AE2F_1AEFF);
    label_100D_CD16_1CDE6_5507:
        CheckExternalEvents(cs1, 0xCD16);
        // 100D:CD16 je short 0xCD1C
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CD16");
        }
    label_100D_CD18_1CDE8_5509:
        CheckExternalEvents(cs1, 0xCD18);
        // 100D:CD18 mov word ptr DS:[0xDC1C],SI
        UInt16[DS, (ushort)0xDC1C] = SI;
        // 100D:CD1C lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CD1E sub AX,4
        AX = Alu16.Sub(AX, (ushort)0x0004);
        // 100D:CD21 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:CD23 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
    label_100D_CD25_1CDF5_4249:
        CheckExternalEvents(cs1, 0xCD25);
        // 100D:CD25 cmp AX,0x6C70
        Alu16.Sub(AX, (ushort)0x6C70);
        // 100D:CD28 jne short 0xCD37
        if (!ZeroFlag)
        {
            goto label_100D_CD37_1CE07_4252;
        }
    label_100D_CD2A_1CDFA_4993:
        CheckExternalEvents(cs1, 0xCD2A);
        // 100D:CD2A lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CD2C mov word ptr DS:[0xDC1E],SI
        UInt16[DS, (ushort)0xDC1E] = SI;
        // 100D:CD30 sub AX,4
        AX = Alu16.Sub(AX, (ushort)0x0004);
        // 100D:CD33 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:CD35 jmp short 0xCD0C
        goto label_100D_CD0C_1CDDC_4245;
    label_100D_CD37_1CE07_4252:
        CheckExternalEvents(cs1, 0xCD37);
        // 100D:CD37 cmp AX,0x6D6D
        Alu16.Sub(AX, (ushort)0x6D6D);
        // 100D:CD3A jne short 0xCD4E
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CD3A");
        }
    label_100D_CD4E_1CE1E_4255:
        CheckExternalEvents(cs1, 0xCD4E);
        // 100D:CD4E push DS
        Stack.Push16(DS);
        // 100D:CD4F push ES
        Stack.Push16(ES);
        // 100D:CD50 mov ES,BP
        ES = BP;
        // 100D:CD52 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:CD54 test AH,4
        Alu8.And(AH, (byte)0x04);
        // 100D:CD57 je short 0xCD5D
        if (ZeroFlag)
        {
            goto label_100D_CD5D_1CE2D_4264;
        }
    label_100D_CD59_1CE29_4262:
        CheckExternalEvents(cs1, 0xCD59);
        // 100D:CD59 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
    label_100D_CD5D_1CE2D_4264:
        CheckExternalEvents(cs1, 0xCD5D);
        // 100D:CD5D mov word ptr DS:[0xDC16],ES
        UInt16[DS, (ushort)0xDC16] = ES;
        // 100D:CD61 mov word ptr DS:[0xDC14],DI
        UInt16[DS, (ushort)0xDC14] = DI;
        // 100D:CD65 mov word ptr DS:[0xDC24],AX
        UInt16[DS, (ushort)0xDC24] = AX;
        // 100D:CD68 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CD69 mov CX,AX
        CX = AX;
        // 100D:CD6B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:CD6C xchg CX,AX
        ushort temp_100D_CD6C_1CE3C = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_CD6C_1CE3C);
        // 100D:CD6D test AH,4
        Alu8.And(AH, (byte)0x04);
        // 100D:CD70 jne short 0xCD7C
        if (!ZeroFlag)
        {
            goto label_100D_CD7C_1CE4C_4273;
        }
    label_100D_CD72_1CE42_5280:
        CheckExternalEvents(cs1, 0xCD72);
        // 100D:CD72 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:CD73 xchg CX,AX
        ushort temp_100D_CD73_1CE43 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_CD73_1CE43);
        // 100D:CD74 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:CD75 jcxz short 0xCD7F
        if (CX == (ushort)0x0000)
        {
            goto label_100D_CD7F_1CE4F_4275;
        }
    label_100D_CD77_1CE47_5285:
        CheckExternalEvents(cs1, 0xCD77);
        // 100D:CD77 test CH,2
        Alu8.And(CH, (byte)0x02);
        // 100D:CD7A je short 0xCD81
        if (ZeroFlag)
        {
            goto label_100D_CD81_1CE51_5481;
        }
    label_100D_CD7C_1CE4C_4273:
        CheckExternalEvents(cs1, 0xCD7C);
        // 100D:CD7C call near 0xF403
        NearCall(cs1, 0xCD7F, unknown_100D_F403_1F4D3);
    label_100D_CD7F_1CE4F_4275:
        CheckExternalEvents(cs1, 0xCD7F);
        // 100D:CD7F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CD80 ret near
        return NearRet((ushort)0x0000);
    label_100D_CD81_1CE51_5481:
        CheckExternalEvents(cs1, 0xCD81);
        // 100D:CD81 sub SI,4
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:CD84 mov AX,DS
        AX = DS;
        // 100D:CD86 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CD87 mov word ptr DS:[0xDC14],SI
        UInt16[DS, (ushort)0xDC14] = SI;
        // 100D:CD8B mov word ptr DS:[0xDC16],AX
        UInt16[DS, (ushort)0xDC16] = AX;
        // 100D:CD8E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CD8F_1CE5F(int loadOffset)
    {
    label_100D_CD8F_1CE5F_2561:
        CheckExternalEvents(cs1, 0xCD8F);
        // 100D:CD8F mov CX,2
        CX = (ushort)0x0002;
        // 100D:CD92 call near 0xCDBF
        NearCall(cs1, 0xCD95, unknown_100D_CDBF_1CE8F);
    label_100D_CD95_1CE65_2593:
        CheckExternalEvents(cs1, 0xCD95);
        // 100D:CD95 jb short 0xCD9F
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CD95");
        }
    label_100D_CD97_1CE67_2595:
        CheckExternalEvents(cs1, 0xCD97);
        // 100D:CD97 les SI,word ptr DS:[0xDC0C]
        ushort lxsOffset_100D_CD97_1CE67 = (ushort)0xDC0C;
        ushort lxsValue_100D_CD97_1CE67 = UInt16[DS, lxsOffset_100D_CD97_1CE67];
        ushort lxsSegment_100D_CD97_1CE67 = UInt16[DS, (ushort)(lxsOffset_100D_CD97_1CE67 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_CD97_1CE67);
        ES = unchecked((ushort)lxsSegment_100D_CD97_1CE67);
        // 100D:CD9B mov AX,word ptr ES:[SI-2]
        AX = UInt16[ES, (ushort)(SI + (sbyte)-2)];
        // 100D:CD9F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CDA0_1CE70(int loadOffset)
    {
    label_100D_CDA0_1CE70_4214:
        CheckExternalEvents(cs1, 0xCDA0);
        // 100D:CDA0 call near 0xCE1A
        NearCall(cs1, 0xCDA3, unknown_100D_CE1A_1CEEA);
    label_100D_CDA3_1CE73_4216:
        CheckExternalEvents(cs1, 0xCDA3);
        // 100D:CDA3 call near 0xCD8F
        NearCall(cs1, 0xCDA6, unknown_100D_CD8F_1CE5F);
    label_100D_CDA6_1CE76_4218:
        CheckExternalEvents(cs1, 0xCDA6);
        // 100D:CDA6 jb short 0xCE00
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CDA6");
        }
    label_100D_CDA8_1CE78_4220:
        CheckExternalEvents(cs1, 0xCDA8);
        // 100D:CDA8 mov DI,word ptr DS:[0xCE74]
        DI = UInt16[DS, (ushort)0xCE74];
        // 100D:CDAC sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 100D:CDAE sub DI,2
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:CDB1 mov word ptr DS:[0xDC10],DI
        UInt16[DS, (ushort)0xDC10] = DI;
        // 100D:CDB5 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:CDB6 mov word ptr DS:[0xDC0C],DI
        UInt16[DS, (ushort)0xDC0C] = DI;
        // 100D:CDBA mov CX,AX
        CX = AX;
        // 100D:CDBC sub CX,2
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        return unknown_100D_CDBF_1CE8F(0x0000);
    }

    public virtual Action unknown_100D_CDBF_1CE8F(int loadOffset)
    {
    label_100D_CDBF_1CE8F_2564:
        CheckExternalEvents(cs1, 0xCDBF);
        // 100D:CDBF mov BX,word ptr DS:[0x35A6]
        BX = UInt16[DS, (ushort)0x35A6];
        // 100D:CDC3 cmp BX,1
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:CDC6 jb short 0xCE00
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:CDC6");
        }
    label_100D_CDC8_1CE98_2568:
        CheckExternalEvents(cs1, 0xCDC8);
        // 100D:CDC8 push CX
        Stack.Push16(CX);
        // 100D:CDC9 mov CX,word ptr DS:[0xDC06]
        CX = UInt16[DS, (ushort)0xDC06];
        // 100D:CDCD mov DX,word ptr DS:[0xDC04]
        DX = UInt16[DS, (ushort)0xDC04];
        // 100D:CDD1 mov AX,0x4200
        AX = (ushort)0x4200;
        // 100D:CDD4 int 0x21
        InterruptCall(cs1, 0xCDD6, unchecked((byte)((byte)0x21)));
    label_100D_CDD6_1CEA6_2574:
        CheckExternalEvents(cs1, 0xCDD6);
        // 100D:CDD6 pop CX
        CX = Stack.Pop16();
        // 100D:CDD7 push DS
        Stack.Push16(DS);
        // 100D:CDD8 lds DX,word ptr DS:[0xDC0C]
        ushort lxsOffset_100D_CDD8_1CEA8 = (ushort)0xDC0C;
        ushort lxsValue_100D_CDD8_1CEA8 = UInt16[DS, lxsOffset_100D_CDD8_1CEA8];
        ushort lxsSegment_100D_CDD8_1CEA8 = UInt16[DS, (ushort)(lxsOffset_100D_CDD8_1CEA8 + (ushort)0x0002)];
        DX = unchecked((ushort)lxsValue_100D_CDD8_1CEA8);
        DS = unchecked((ushort)lxsSegment_100D_CDD8_1CEA8);
        // 100D:CDDC mov AH,0x3F
        AH = (byte)0x3F;
        // 100D:CDDE int 0x21
        InterruptCall(cs1, 0xCDE0, unchecked((byte)((byte)0x21)));
    label_100D_CDE0_1CEB0_2580:
        CheckExternalEvents(cs1, 0xCDE0);
        // 100D:CDE0 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CDE1 cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:CDE3 jb short 0xCDC8
        if (CarryFlag)
        {
            goto label_100D_CDC8_1CE98_2568;
        }
    label_100D_CDE5_1CEB5_2584:
        CheckExternalEvents(cs1, 0xCDE5);
        // 100D:CDE5 sub word ptr DS:[0xDC08],AX
        UInt16[DS, (ushort)0xDC08] = Alu16.Sub(UInt16[DS, (ushort)0xDC08], AX);
        // 100D:CDE9 sbb word ptr DS:[0xDC0A],0
        UInt16[DS, (ushort)0xDC0A] = Alu16.Sbb(UInt16[DS, (ushort)0xDC0A], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CDEE add word ptr DS:[0xDC04],AX
        UInt16[DS, (ushort)0xDC04] = Alu16.Add(UInt16[DS, (ushort)0xDC04], AX);
        // 100D:CDF2 adc word ptr DS:[0xDC06],0
        UInt16[DS, (ushort)0xDC06] = Alu16.Adc(UInt16[DS, (ushort)0xDC06], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:CDF7 add word ptr DS:[0xDC0C],AX
        UInt16[DS, (ushort)0xDC0C] = Alu16.Add(UInt16[DS, (ushort)0xDC0C], AX);
        // 100D:CDFB add word ptr DS:[0xDC1A],AX
        UInt16[DS, (ushort)0xDC1A] = Alu16.Add(UInt16[DS, (ushort)0xDC1A], AX);
        // 100D:CDFF clc
        CarryFlag = false;
        // 100D:CE00 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE01_1CED1(int loadOffset)
    {
    label_100D_CE01_1CED1_2537:
        CheckExternalEvents(cs1, 0xCE01);
        // 100D:CE01 mov word ptr DS:[0xDBE8],0
        UInt16[DS, (ushort)0xDBE8] = (ushort)0x0000;
        return unknown_100D_CE07_1CED7(0x0000);
    }

    public virtual Action unknown_100D_CE07_1CED7(int loadOffset)
    {
    label_100D_CE07_1CED7_2539:
        CheckExternalEvents(cs1, 0xCE07);
        // 100D:CE07 mov word ptr DS:[0xDBEA],0
        UInt16[DS, (ushort)0xDBEA] = (ushort)0x0000;
        // 100D:CE0D mov word ptr DS:[0xDBEC],0xFFFF
        UInt16[DS, (ushort)0xDBEC] = (ushort)0xFFFF;
        // 100D:CE13 mov word ptr DS:[0xDBEE],0xFFFF
        UInt16[DS, (ushort)0xDBEE] = (ushort)0xFFFF;
        // 100D:CE19 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE1A_1CEEA(int loadOffset)
    {
    label_100D_CE1A_1CEEA_2521:
        CheckExternalEvents(cs1, 0xCE1A);
        // 100D:CE1A mov AX,word ptr DS:[0xDBDE]
        AX = UInt16[DS, (ushort)0xDBDE];
        // 100D:CE1D mov word ptr DS:[0xDC0E],AX
        UInt16[DS, (ushort)0xDC0E] = AX;
        // 100D:CE20 mov word ptr DS:[0xDC12],AX
        UInt16[DS, (ushort)0xDC12] = AX;
        // 100D:CE23 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:CE25 mov word ptr DS:[0xDC0C],AX
        UInt16[DS, (ushort)0xDC0C] = AX;
        // 100D:CE28 mov word ptr DS:[0xDC10],AX
        UInt16[DS, (ushort)0xDC10] = AX;
        // 100D:CE2B mov word ptr DS:[0xDC1A],AX
        UInt16[DS, (ushort)0xDC1A] = AX;
        // 100D:CE2E mov word ptr DS:[0xDC20],AX
        UInt16[DS, (ushort)0xDC20] = AX;
        // 100D:CE31 mov word ptr DS:[0xDC16],AX
        UInt16[DS, (ushort)0xDC16] = AX;
        // 100D:CE34 mov AX,word ptr DS:[0xCE74]
        AX = UInt16[DS, (ushort)0xCE74];
        // 100D:CE37 mov word ptr DS:[0xDC18],AX
        UInt16[DS, (ushort)0xDC18] = AX;
        // 100D:CE3A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE3B_1CF0B(int loadOffset)
    {
    label_100D_CE3B_1CF0B_5001:
        CheckExternalEvents(cs1, 0xCE3B);
        // 100D:CE3B les SI,word ptr DS:[0xDC0C]
        ushort lxsOffset_100D_CE3B_1CF0B = (ushort)0xDC0C;
        ushort lxsValue_100D_CE3B_1CF0B = UInt16[DS, lxsOffset_100D_CE3B_1CF0B];
        ushort lxsSegment_100D_CE3B_1CF0B = UInt16[DS, (ushort)(lxsOffset_100D_CE3B_1CF0B + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_CE3B_1CF0B);
        ES = unchecked((ushort)lxsSegment_100D_CE3B_1CF0B);
        // 100D:CE3F mov SI,word ptr DS:[0xDC1E]
        SI = UInt16[DS, (ushort)0xDC1E];
        // 100D:CE43 call near 0xC1BA
        NearCall(cs1, 0xCE46, unknown_100D_C1BA_1C28A);
    label_100D_CE46_1CF16_5005:
        CheckExternalEvents(cs1, 0xCE46);
        // 100D:CE46 call far dword ptr DS:[0x3935]
        ushort targetSegment_5005 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3935 + (ushort)0x0002)]));
        ushort targetOffset_5005 = unchecked((ushort)(UInt16[DS, (ushort)0x3935]));
        if (targetSegment_5005 == cs2 && targetOffset_5005 == 0x0160)
        {
            FarCall(cs1, 0xCE4A, cs2, unknown_3358_0160_336E0);
            goto label_100D_CE4A_1CF1A_5007;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5005:X4}:{targetOffset_5005:X4} at 100D:CE46");
    label_100D_CE4A_1CF1A_5007:
        CheckExternalEvents(cs1, 0xCE4A);
        // 100D:CE4A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE4B_1CF1B(int loadOffset)
    {
    label_100D_CE4B_1CF1B_22823:
        CheckExternalEvents(cs1, 0xCE4B);
        // 100D:CE4B mov word ptr DS:[0xDC02],BX
        UInt16[DS, (ushort)0xDC02] = BX;
        // 100D:CE4F mov word ptr DS:[0xDBEE],AX
        UInt16[DS, (ushort)0xDBEE] = AX;
        // 100D:CE52 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE53_1CF23(int loadOffset)
    {
    label_100D_CE53_1CF23_21643:
        CheckExternalEvents(cs1, 0xCE53);
        // 100D:CE53 test byte ptr DS:[0x3403],4
        Alu8.And(UInt8[DS, (ushort)0x3403], (byte)0x04);
        // 100D:CE58 je short 0xCE6B
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CE58");
        }
    label_100D_CE6B_1CF3B_21646:
        CheckExternalEvents(cs1, 0xCE6B);
        // 100D:CE6B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CE6C_1CF3C(int loadOffset)
    {
    label_100D_CE6C_1CF3C_2475:
        CheckExternalEvents(cs1, 0xCE6C);
        // 100D:CE6C test byte ptr DS:[0x2943],2
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x02);
        // 100D:CE71 jne short 0xCE7B
        if (!ZeroFlag)
        {
            goto label_100D_CE7B_1CF4B_2481;
        }
    label_100D_CE73_1CF43_2478:
        CheckExternalEvents(cs1, 0xCE73);
        // 100D:CE73 cmp word ptr DS:[0x39A9],0x015E
        Alu16.Sub(UInt16[DS, (ushort)0x39A9], (ushort)0x015E);
        // 100D:CE79 jae short 0xCE8A
        if (!CarryFlag)
        {
            goto label_100D_CE8A_1CF5A_2496;
        }
    label_100D_CE7B_1CF4B_2481:
        CheckExternalEvents(cs1, 0xCE7B);
        // 100D:CE7B mov AX,2
        AX = (ushort)0x0002;
    label_100D_CE7E_1CF4E_2483:
        CheckExternalEvents(cs1, 0xCE7E);
        // 100D:CE7E call near 0xC921
        NearCall(cs1, 0xCE81, unknown_100D_C921_1C9F1);
    label_100D_CE81_1CF51_2490:
        CheckExternalEvents(cs1, 0xCE81);
        // 100D:CE81 and byte ptr DS:[BX],0xFB
        UInt8[DS, BX] = Alu8.And(UInt8[DS, BX], (byte)0xFB);
        // 100D:CE84 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CE85 cmp AX,9
        Alu16.Sub(AX, (ushort)0x0009);
        // 100D:CE88 jb short 0xCE7E
        if (CarryFlag)
        {
            goto label_100D_CE7E_1CF4E_2483;
        }
    label_100D_CE8A_1CF5A_2496:
        CheckExternalEvents(cs1, 0xCE8A);
        // 100D:CE8A test byte ptr DS:[0x2943],3
        Alu8.And(UInt8[DS, (ushort)0x2943], (byte)0x03);
        // 100D:CE8F je short 0xCE9F
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:CE8F");
        }
    label_100D_CE9F_1CF6F_2499:
        CheckExternalEvents(cs1, 0xCE9F);
        // 100D:CE9F mov AX,2
        AX = (ushort)0x0002;
    label_100D_CEA2_1CF72_2501:
        CheckExternalEvents(cs1, 0xCEA2);
        // 100D:CEA2 push AX
        Stack.Push16(AX);
        // 100D:CEA3 call near 0xCEB0
        NearCall(cs1, 0xCEA6, unknown_100D_CEB0_1CF80);
    label_100D_CEA6_1CF76_2688:
        CheckExternalEvents(cs1, 0xCEA6);
        // 100D:CEA6 pop AX
        AX = Stack.Pop16();
        // 100D:CEA7 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CEA8 cmp AX,8
        Alu16.Sub(AX, (ushort)0x0008);
        // 100D:CEAB jb short 0xCEA2
        if (CarryFlag)
        {
            goto label_100D_CEA2_1CF72_2501;
        }
    label_100D_CEAD_1CF7D_2699:
        CheckExternalEvents(cs1, 0xCEAD);
        // 100D:CEAD jmp near 0xCA01
        return unknown_100D_CA01_1CAD1(0x0000);
    }

    public virtual Action unknown_100D_CEB0_1CF80(int loadOffset)
    {
    label_100D_CEB0_1CF80_2503:
        CheckExternalEvents(cs1, 0xCEB0);
        // 100D:CEB0 call near 0xC921
        NearCall(cs1, 0xCEB3, unknown_100D_C921_1C9F1);
    label_100D_CEB3_1CF83_2505:
        CheckExternalEvents(cs1, 0xCEB3);
        // 100D:CEB3 push BX
        Stack.Push16(BX);
        // 100D:CEB4 call near 0xC92B
        NearCall(cs1, 0xCEB7, unknown_100D_C92B_1C9FB);
    label_100D_CEB7_1CF87_2668:
        CheckExternalEvents(cs1, 0xCEB7);
        // 100D:CEB7 pop DI
        DI = Stack.Pop16();
        // 100D:CEB8 jb short 0xCEC8
        if (CarryFlag)
        {
            goto label_100D_CEC8_1CF98_2686;
        }
    label_100D_CEBA_1CF8A_2671:
        CheckExternalEvents(cs1, 0xCEBA);
        // 100D:CEBA test byte ptr DS:[DI],8
        Alu8.And(UInt8[DS, DI], (byte)0x08);
        // 100D:CEBD je short 0xCEC8
        if (ZeroFlag)
        {
            goto label_100D_CEC8_1CF98_2686;
        }
    label_100D_CEBF_1CF8F_2674:
        CheckExternalEvents(cs1, 0xCEBF);
        // 100D:CEBF sub DI,8
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:CEC2 mov SI,0xDBF6
        SI = (ushort)0xDBF6;
        // 100D:CEC5 call near 0x5B99
        NearCall(cs1, 0xCEC8, unknown_100D_5B99_15C69);
    label_100D_CEC8_1CF98_2686:
        CheckExternalEvents(cs1, 0xCEC8);
        // 100D:CEC8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CEC9_1CF99(int loadOffset)
    {
    label_100D_CEC9_1CF99_5707:
        CheckExternalEvents(cs1, 0xCEC9);
        // 100D:CEC9 pushf
        Stack.Push16(FlagRegister16);
        // 100D:CECA push BX
        Stack.Push16(BX);
        // 100D:CECB push CX
        Stack.Push16(CX);
        // 100D:CECC push DX
        Stack.Push16(DX);
        // 100D:CECD push SI
        Stack.Push16(SI);
        // 100D:CECE push DI
        Stack.Push16(DI);
        // 100D:CECF push BP
        Stack.Push16(BP);
        // 100D:CED0 push ES
        Stack.Push16(ES);
        // 100D:CED1 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:CED3 xchg AL,byte ptr DS:[0xDBB5]
        ushort xchgOffset_100D_CED3_1CFA3 = (ushort)0xDBB5;
        byte temp_100D_CED3_1CFA3 = AL;
        AL = UInt8[DS, xchgOffset_100D_CED3_1CFA3];
        UInt8[DS, xchgOffset_100D_CED3_1CFA3] = unchecked((byte)temp_100D_CED3_1CFA3);
        // 100D:CED7 sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_CED8_1CFA8_5719:
        CheckExternalEvents(cs1, 0xCED8);
        // 100D:CED8 push AX
        Stack.Push16(AX);
        // 100D:CED9 call near 0xCAA0
        NearCall(cs1, 0xCEDC, unknown_100D_CAA0_1CB70);
    label_100D_CEDC_1CFAC_5722:
        CheckExternalEvents(cs1, 0xCEDC);
        // 100D:CEDC jbe short 0xCEEF
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_CEEF_1CFBF_5732;
        }
    label_100D_CEDE_1CFAE_5724:
        CheckExternalEvents(cs1, 0xCEDE);
        // 100D:CEDE mov AX,word ptr DS:[0xDC1E]
        AX = UInt16[DS, (ushort)0xDC1E];
        // 100D:CEE1 inc AX
        AX = Alu16.Inc(AX);
        // 100D:CEE2 jne short 0xCEEF
        if (!ZeroFlag)
        {
            goto label_100D_CEEF_1CFBF_5732;
        }
    label_100D_CEE4_1CFB4_5728:
        CheckExternalEvents(cs1, 0xCEE4);
        // 100D:CEE4 call near 0xCAD4
        NearCall(cs1, 0xCEE7, unknown_100D_CAD4_1CBA4);
    label_100D_CEE7_1CFB7_5730:
        CheckExternalEvents(cs1, 0xCEE7);
        // 100D:CEE7 jb short 0xCEEF
        if (CarryFlag)
        {
            goto label_100D_CEEF_1CFBF_5732;
        }
    label_100D_CEE9_1CFB9_5761:
        CheckExternalEvents(cs1, 0xCEE9);
        // 100D:CEE9 call near 0xCC96
        NearCall(cs1, 0xCEEC, unknown_100D_CC96_1CD66);
    label_100D_CEEC_1CFBC_5763:
        CheckExternalEvents(cs1, 0xCEEC);
        // 100D:CEEC call near 0xCC4E
        NearCall(cs1, 0xCEEF, unknown_100D_CC4E_1CD1E);
    label_100D_CEEF_1CFBF_5732:
        CheckExternalEvents(cs1, 0xCEEF);
        // 100D:CEEF pop AX
        AX = Stack.Pop16();
        // 100D:CEF0 mov byte ptr DS:[0xDBB5],AL
        UInt8[DS, (ushort)0xDBB5] = AL;
        // 100D:CEF3 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:CEF4 pop BP
        BP = Stack.Pop16();
        // 100D:CEF5 pop DI
        DI = Stack.Pop16();
        // 100D:CEF6 pop SI
        SI = Stack.Pop16();
        // 100D:CEF7 pop DX
        DX = Stack.Pop16();
        // 100D:CEF8 pop CX
        CX = Stack.Pop16();
        // 100D:CEF9 pop BX
        BX = Stack.Pop16();
    label_100D_CEFA_1CFCA_5742:
        CheckExternalEvents(cs1, 0xCEFA);
        // 100D:CEFA popf
        FlagRegister16 = Stack.Pop16();
    label_100D_CEFB_1CFCB_5744:
        CheckExternalEvents(cs1, 0xCEFB);
        // 100D:CEFB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_CEFC_1CFCC(int loadOffset)
    {
    entrydispatcher:
    label_100D_CEFC_1CFCC_5492:
        CheckExternalEvents(cs1, 0xCEFC);
        // 100D:CEFC mov AX,0x0069
        AX = (ushort)0x0069;
        // 100D:CEFF add AL,byte ptr DS:[0xCEEB]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)0xCEEB]);
        // 100D:CF03 call near 0xC13E
        NearCall(cs1, 0xCF06, unknown_100D_C13E_1C20E);
    label_100D_CF06_1CFD6_5496:
        CheckExternalEvents(cs1, 0xCF06);
        // 100D:CF06 mov word ptr DS:[0x3622],0x35A8
        UInt16[DS, (ushort)0x3622] = (ushort)0x35A8;
        // 100D:CF0C xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:CF0E call far dword ptr DS:[0x3939]
        ushort targetSegment_5499 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3939 + (ushort)0x0002)]));
        ushort targetOffset_5499 = unchecked((ushort)(UInt16[DS, (ushort)0x3939]));
        if (targetSegment_5499 == cs2 && targetOffset_5499 == 0x0163)
        {
            FarCall(cs1, 0xCF12, cs2, unknown_3358_0163_336E3);
            goto label_100D_CF12_1CFE2_5500;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5499:X4}:{targetOffset_5499:X4} at 100D:CF0E");
    label_100D_CF12_1CFE2_5500:
        CheckExternalEvents(cs1, 0xCF12);
        // 100D:CF12 call near 0xC0AD
        NearCall(cs1, 0xCF15, unknown_100D_C0AD_1C17D);
    label_100D_CF15_1CFE5_5502:
        CheckExternalEvents(cs1, 0xCF15);
        // 100D:CF15 mov AX,0x0019
        AX = (ushort)0x0019;
        // 100D:CF18 jmp near 0xCA1B
        if (JumpDispatcher.Jump(unknown_100D_CA1B_1CAEB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }
}
