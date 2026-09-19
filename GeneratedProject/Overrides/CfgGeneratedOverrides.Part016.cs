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
    public virtual Action unknown_100D_A396_1A466(int loadOffset)
    {
    label_100D_A396_1A466_3178:
        CheckExternalEvents(cs1, 0xA396);
        // 100D:A396 sub SP,0x0032
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:A399 mov BP,SP
        BP = SP;
        // 100D:A39B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A39D les SI,word ptr DS:[0xAA72]
        ushort lxsOffset_100D_A39D_1A46D = (ushort)0xAA72;
        ushort lxsValue_100D_A39D_1A46D = UInt16[DS, lxsOffset_100D_A39D_1A46D];
        ushort lxsSegment_100D_A39D_1A46D = UInt16[DS, (ushort)(lxsOffset_100D_A39D_1A46D + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_A39D_1A46D);
        ES = unchecked((ushort)lxsSegment_100D_A39D_1A46D);
        // 100D:A3A1 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:A3A3 mov SI,word ptr ES:[SI-2]
        SI = UInt16[ES, (ushort)(SI + (sbyte)-2)];
    label_100D_A3A7_1A477_3185:
        CheckExternalEvents(cs1, 0xA3A7);
        // 100D:A3A7 call near 0xA30B
        NearCall(cs1, 0xA3AA, unknown_100D_A30B_1A3DB);
    label_100D_A3AA_1A47A_3202:
        CheckExternalEvents(cs1, 0xA3AA);
        // 100D:A3AA mov DX,AX
        DX = AX;
    label_100D_A3AC_1A47C_3204:
        CheckExternalEvents(cs1, 0xA3AC);
        // 100D:A3AC lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:A3AE cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:A3B0 je short 0xA3CB
        if (ZeroFlag)
        {
            goto label_100D_A3CB_1A49B_3207;
        }
    label_100D_A3B2_1A482_16083:
        CheckExternalEvents(cs1, 0xA3B2);
        // 100D:A3B2 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 100D:A3B4 jne short 0xA3C0
        if (!ZeroFlag)
        {
            goto label_100D_A3C0_1A490_16109;
        }
    label_100D_A3B6_1A486_16086:
        CheckExternalEvents(cs1, 0xA3B6);
        // 100D:A3B6 mov BL,AL
        BL = AL;
        // 100D:A3B8 call near 0xA30B
        NearCall(cs1, 0xA3BB, unknown_100D_A30B_1A3DB);
    label_100D_A3BB_1A48B_16095:
        CheckExternalEvents(cs1, 0xA3BB);
        // 100D:A3BB call near 0xA334
        NearCall(cs1, 0xA3BE, unknown_100D_A334_1A404);
    label_100D_A3BE_1A48E_16106:
        CheckExternalEvents(cs1, 0xA3BE);
        // 100D:A3BE jmp short 0xA3AC
        goto label_100D_A3AC_1A47C_3204;
    label_100D_A3C0_1A490_16109:
        CheckExternalEvents(cs1, 0xA3C0);
        // 100D:A3C0 mov word ptr SS:[BP],DX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = DX;
        // 100D:A3C3 mov word ptr SS:[BP+2],AX
        UInt16[SS, (ushort)(BP + (sbyte)2)] = AX;
        // 100D:A3C6 add BP,4
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:A3C9 jmp short 0xA3A7
        goto label_100D_A3A7_1A477_3185;
    label_100D_A3CB_1A49B_3207:
        CheckExternalEvents(cs1, 0xA3CB);
        // 100D:A3CB mov SI,SP
        SI = SP;
        // 100D:A3CD cmp SI,BP
        Alu16.Sub(SI, BP);
        // 100D:A3CF je short 0xA3E2
        if (ZeroFlag)
        {
            goto label_100D_A3E2_1A4B2_3211;
        }
    label_100D_A3D1_1A4A1_16128:
        CheckExternalEvents(cs1, 0xA3D1);
        // 100D:A3D1 mov word ptr SS:[BP],DX
        UInt16[SS, (ushort)(BP + (sbyte)0)] = DX;
        // 100D:A3D4 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:A3D5 mov DX,AX
        DX = AX;
    label_100D_A3D7_1A4A7_16132:
        CheckExternalEvents(cs1, 0xA3D7);
        // 100D:A3D7 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:A3D8 mov BX,AX
        BX = AX;
        // 100D:A3DA lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:A3DB call near 0xA334
        NearCall(cs1, 0xA3DE, unknown_100D_A334_1A404);
    label_100D_A3DE_1A4AE_16136:
        CheckExternalEvents(cs1, 0xA3DE);
        // 100D:A3DE cmp SI,BP
        Alu16.Sub(SI, BP);
        // 100D:A3E0 jb short 0xA3D7
        if (CarryFlag)
        {
            goto label_100D_A3D7_1A4A7_16132;
        }
    label_100D_A3E2_1A4B2_3211:
        CheckExternalEvents(cs1, 0xA3E2);
        // 100D:A3E2 add SP,0x0032
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:A3E5 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:A3E7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A42C_1A4FC(int loadOffset)
    {
    label_100D_A42C_1A4FC_25452:
        CheckExternalEvents(cs1, 0xA42C);
        // 100D:A42C mov AX,0x0055
        AX = (ushort)0x0055;
        // 100D:A42F call near 0xC13E
        NearCall(cs1, 0xA432, unknown_100D_C13E_1C20E);
    label_100D_A432_1A502_25455:
        CheckExternalEvents(cs1, 0xA432);
        // 100D:A432 mov AL,byte ptr DS:[0xCEEB]
        AL = UInt8[DS, (ushort)0xCEEB];
        return unknown_100D_A435_1A505(0x0000);
    }

    public virtual Action unknown_100D_A44C_1A51C(int loadOffset)
    {
    label_100D_A44C_1A51C_25484:
        CheckExternalEvents(cs1, 0xA44C);
        // 100D:A44C mov AL,byte ptr DS:[0x28E7]
        AL = UInt8[DS, (ushort)0x28E7];
        // 100D:A44F add AL,8
        AL = Alu8.Add(AL, (byte)0x08);
        // 100D:A451 jmp short 0xA435
        return unknown_100D_A435_1A505(0x0000);
    }

    public virtual Action unknown_100D_A453_1A523(int loadOffset)
    {
    label_100D_A453_1A523_25533:
        CheckExternalEvents(cs1, 0xA453);
        // 100D:A453 sub DX,word ptr DS:[0x2886]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)0x2886]);
        // 100D:A457 sub BX,word ptr DS:[0x2888]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)0x2888]);
        // 100D:A45B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A45C_1A52C(int loadOffset)
    {
    label_100D_A45C_1A52C_25371:
        CheckExternalEvents(cs1, 0xA45C);
        // 100D:A45C add DX,word ptr DS:[0x2886]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x2886]);
        // 100D:A460 add BX,word ptr DS:[0x2888]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x2888]);
        // 100D:A464 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A465_1A535(int loadOffset)
    {
    label_100D_A465_1A535_25462:
        CheckExternalEvents(cs1, 0xA465);
        // 100D:A465 push AX
        Stack.Push16(AX);
        // 100D:A466 mov DX,word ptr DS:[0x28C7]
        DX = UInt16[DS, (ushort)0x28C7];
        // 100D:A46A mov BX,0x28DC
        BX = (ushort)0x28DC;
        // 100D:A46D xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:A46E mov BL,7
        BL = (byte)0x07;
        // 100D:A470 mul BL
        ushort result_100D_A470_1A540 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)BL)));
        AH = unchecked((byte)(result_100D_A470_1A540 >> 8));
        AL = unchecked((byte)result_100D_A470_1A540);
        // 100D:A472 mov BX,AX
        BX = AX;
        // 100D:A474 add BX,word ptr DS:[0x28C9]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0x28C9]);
        // 100D:A478 call near 0xA45C
        NearCall(cs1, 0xA47B, unknown_100D_A45C_1A52C);
    label_100D_A47B_1A54B_25472:
        CheckExternalEvents(cs1, 0xA47B);
        // 100D:A47B pop AX
        AX = Stack.Pop16();
        // 100D:A47C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A47D_1A54D(int loadOffset)
    {
    entrydispatcher:
    label_100D_A47D_1A54D_25414:
        CheckExternalEvents(cs1, 0xA47D);
        // 100D:A47D test word ptr DS:[0xDBC8],8
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0008);
        // 100D:A483 je short 0xA48B
        if (ZeroFlag)
        {
            goto label_100D_A48B_1A55B_25442;
        }
    label_100D_A485_1A555_25417:
        CheckExternalEvents(cs1, 0xA485);
        // 100D:A485 mov SI,0x28A6
        SI = (ushort)0x28A6;
        // 100D:A488 call near 0xA49C
        NearCall(cs1, 0xA48B, unknown_100D_A49C_1A56C);
    label_100D_A48B_1A55B_25442:
        CheckExternalEvents(cs1, 0xA48B);
        // 100D:A48B test word ptr DS:[0xDBC8],0x0800
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0800);
        // 100D:A491 je short 0xA4C5
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A491");
        }
    label_100D_A493_1A563_25445:
        CheckExternalEvents(cs1, 0xA493);
        // 100D:A493 mov SI,0x28AE
        SI = (ushort)0x28AE;
        // 100D:A496 call near 0xA49C
        NearCall(cs1, 0xA499, unknown_100D_A49C_1A56C);
    label_100D_A499_1A569_25448:
        CheckExternalEvents(cs1, 0xA499);
        // 100D:A499 mov SI,0x28B6
        SI = (ushort)0x28B6;
        if (JumpDispatcher.Jump(unknown_100D_A49C_1A56C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A49C_1A56C(int loadOffset)
    {
    entrydispatcher:
    label_100D_A49C_1A56C_25420:
        CheckExternalEvents(cs1, 0xA49C);
        // 100D:A49C push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:A4A0 call near 0xC08E
        NearCall(cs1, 0xA4A3, unknown_100D_C08E_1C15E);
    label_100D_A4A3_1A573_25423:
        CheckExternalEvents(cs1, 0xA4A3);
        // 100D:A4A3 mov AX,0x0055
        AX = (ushort)0x0055;
        // 100D:A4A6 call near 0xC13E
        NearCall(cs1, 0xA4A9, unknown_100D_C13E_1C20E);
    label_100D_A4A9_1A579_25426:
        CheckExternalEvents(cs1, 0xA4A9);
        // 100D:A4A9 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:A4AA aam
        byte v2_100D_A4AA_1A57A = (byte)0x0A;
        byte v1_100D_A4AA_1A57A = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_A4AA_1A57A >> (byte)0x01)));
        if (v2_100D_A4AA_1A57A == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_A4AA_1A57A = unchecked((byte)(v1_100D_A4AA_1A57A % v2_100D_A4AA_1A57A));
        AH = unchecked((byte)(v1_100D_A4AA_1A57A / v2_100D_A4AA_1A57A));
        AL = unchecked((byte)result_100D_A4AA_1A57A);
        Alu8.UpdateFlags(unchecked((byte)result_100D_A4AA_1A57A));
        // 100D:A4AC mov AL,AH
        AL = AH;
        // 100D:A4AE xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:A4B0 add AL,3
        AL = Alu8.Add(AL, (byte)0x03);
        // 100D:A4B2 mov byte ptr DS:[SI],1
        UInt8[DS, SI] = (byte)0x01;
        // 100D:A4B5 inc SI
        SI = Alu16.Inc(SI);
        // 100D:A4B6 mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:A4B8 mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:A4BB call near 0xA45C
        NearCall(cs1, 0xA4BE, unknown_100D_A45C_1A52C);
    label_100D_A4BE_1A58E_25437:
        CheckExternalEvents(cs1, 0xA4BE);
        // 100D:A4BE call near 0xC22F
        NearCall(cs1, 0xA4C1, unknown_100D_C22F_1C2FF);
    label_100D_A4C1_1A591_25439:
        CheckExternalEvents(cs1, 0xA4C1);
        // 100D:A4C1 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_A4C1_1A591 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_A4C1_1A591 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_A4C1_1A591 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_A4C1_1A591);
        // 100D:A4C5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A4C6_1A596(int loadOffset)
    {
    entrydispatcher:
    label_100D_A4C6_1A596_25353:
        CheckExternalEvents(cs1, 0xA4C6);
        // 100D:A4C6 call near 0xAE2F
        NearCall(cs1, 0xA4C9, unknown_100D_AE2F_1AEFF);
    label_100D_A4C9_1A599_25355:
        CheckExternalEvents(cs1, 0xA4C9);
        // 100D:A4C9 je short 0xA4DE
        if (ZeroFlag)
        {
            goto label_100D_A4DE_1A5AE_25398;
        }
    label_100D_A4CB_1A59B_25357:
        CheckExternalEvents(cs1, 0xA4CB);
        // 100D:A4CB mov SI,0x288E
        SI = (ushort)0x288E;
        // 100D:A4CE call near 0xA502
        NearCall(cs1, 0xA4D1, unknown_100D_A502_1A5D2);
    label_100D_A4D1_1A5A1_25395:
        CheckExternalEvents(cs1, 0xA4D1);
        // 100D:A4D1 test word ptr DS:[0xDBC8],4
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0004);
        // 100D:A4D7 jne short 0xA4DE
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A4D7");
        }
    label_100D_A4DE_1A5AE_25398:
        CheckExternalEvents(cs1, 0xA4DE);
        // 100D:A4DE call near 0xAE28
        NearCall(cs1, 0xA4E1, unknown_100D_AE28_1AEF8);
    label_100D_A4E1_1A5B1_25400:
        CheckExternalEvents(cs1, 0xA4E1);
        // 100D:A4E1 je short 0xA540
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A4E1");
        }
    label_100D_A4E3_1A5B3_25402:
        CheckExternalEvents(cs1, 0xA4E3);
        // 100D:A4E3 mov SI,0x2896
        SI = (ushort)0x2896;
        // 100D:A4E6 call near 0xA502
        NearCall(cs1, 0xA4E9, unknown_100D_A502_1A5D2);
    label_100D_A4E9_1A5B9_25405:
        CheckExternalEvents(cs1, 0xA4E9);
        // 100D:A4E9 mov SI,0x289E
        SI = (ushort)0x289E;
        // 100D:A4EC call near 0xA502
        NearCall(cs1, 0xA4EF, unknown_100D_A502_1A5D2);
    label_100D_A4EF_1A5BF_25408:
        CheckExternalEvents(cs1, 0xA4EF);
        // 100D:A4EF test word ptr DS:[0xDBC8],0x0400
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0400);
        // 100D:A4F5 jne short 0xA540
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_A540_1A610, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A4F5");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_A502_1A5D2(int loadOffset)
    {
    entrydispatcher:
    label_100D_A502_1A5D2_25360:
        CheckExternalEvents(cs1, 0xA502);
        // 100D:A502 push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:A506 call near 0xC08E
        NearCall(cs1, 0xA509, unknown_100D_C08E_1C15E);
    label_100D_A509_1A5D9_25363:
        CheckExternalEvents(cs1, 0xA509);
        // 100D:A509 push SI
        Stack.Push16(SI);
        // 100D:A50A mov AX,0x0055
        AX = (ushort)0x0055;
        // 100D:A50D call near 0xC13E
        NearCall(cs1, 0xA510, unknown_100D_C13E_1C20E);
    label_100D_A510_1A5E0_25367:
        CheckExternalEvents(cs1, 0xA510);
        // 100D:A510 mov DX,word ptr DS:[SI+2]
        DX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:A513 mov BX,0x0022
        BX = (ushort)0x0022;
        // 100D:A516 call near 0xA45C
        NearCall(cs1, 0xA519, unknown_100D_A45C_1A52C);
    label_100D_A519_1A5E9_25375:
        CheckExternalEvents(cs1, 0xA519);
        // 100D:A519 mov AX,1
        AX = (ushort)0x0001;
        // 100D:A51C call near 0xC2FD
        NearCall(cs1, 0xA51F, unknown_100D_C2FD_1C3CD);
    label_100D_A51F_1A5EF_25378:
        CheckExternalEvents(cs1, 0xA51F);
        // 100D:A51F pop SI
        SI = Stack.Pop16();
        // 100D:A520 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:A521 mov byte ptr DS:[SI],1
        UInt8[DS, SI] = (byte)0x01;
        // 100D:A524 not AX
        AX = unchecked((ushort)~AX);
        // 100D:A526 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:A528 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:A52A cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:A52B add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:A52D mov BX,AX
        BX = AX;
        // 100D:A52F sub AX,word ptr DS:[0x2888]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x2888]);
        // 100D:A533 mov word ptr DS:[SI+3],AX
        UInt16[DS, (ushort)(SI + (sbyte)3)] = AX;
        // 100D:A536 mov AX,2
        AX = (ushort)0x0002;
        // 100D:A539 call near 0xC22F
        NearCall(cs1, 0xA53C, unknown_100D_C22F_1C2FF);
    label_100D_A53C_1A60C_25392:
        CheckExternalEvents(cs1, 0xA53C);
        // 100D:A53C pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_A53C_1A60C = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_A53C_1A60C = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_A53C_1A60C = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_A53C_1A60C);
        if (JumpDispatcher.Jump(unknown_100D_A540_1A610, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A541_1A611(int loadOffset)
    {
    label_100D_A541_1A611_25657:
        CheckExternalEvents(cs1, 0xA541);
        // 100D:A541 mov AL,byte ptr DS:[0x28E7]
        AL = UInt8[DS, (ushort)0x28E7];
        // 100D:A544 mov byte ptr DS:[0x28E8],AL
        UInt8[DS, (ushort)0x28E8] = AL;
        // 100D:A547 call near 0xDAA3
        NearCall(cs1, 0xA54A, unknown_100D_DAA3_1DB73);
    label_100D_A54A_1A61A_25661:
        CheckExternalEvents(cs1, 0xA54A);
        // 100D:A54A call near 0xD95B
        NearCall(cs1, 0xA54D, unknown_100D_D95B_1DA2B);
    label_100D_A54D_1A61D_25663:
        CheckExternalEvents(cs1, 0xA54D);
        // 100D:A54D mov SI,0x2886
        SI = (ushort)0x2886;
        // 100D:A550 jmp near 0xC4F0
        return unknown_100D_C4F0_1C5C0(0x0000);
    }

    public virtual Action unknown_100D_A576_1A646(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_A576_1A646_25526;

    label_100D_A553_1A623_25716:
        CheckExternalEvents(cs1, 0xA553);
        // 100D:A553 call near 0xAE2F
        NearCall(cs1, 0xA556, unknown_100D_AE2F_1AEFF);
    label_100D_A556_1A626_25718:
        CheckExternalEvents(cs1, 0xA556);
        // 100D:A556 je short 0xA540
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A556");
        }
    label_100D_A558_1A628_25720:
        CheckExternalEvents(cs1, 0xA558);
        // 100D:A558 mov AX,4
        AX = (ushort)0x0004;
        // 100D:A55B mov BX,5
        BX = (ushort)0x0005;
        // 100D:A55E call near 0xA8BC
        NearCall(cs1, 0xA561, unknown_100D_A8BC_1A98C);
    label_100D_A561_1A631_25724:
        CheckExternalEvents(cs1, 0xA561);
        // 100D:A561 call near 0xA83F
        NearCall(cs1, 0xA564, unknown_100D_A83F_1A90F);
    label_100D_A564_1A634_25726:
        CheckExternalEvents(cs1, 0xA564);
        // 100D:A564 call near 0xADE0
        NearCall(cs1, 0xA567, unknown_100D_ADE0_1AEB0);
    label_100D_A567_1A637_25728:
        CheckExternalEvents(cs1, 0xA567);
        // 100D:A567 mov byte ptr DS:[0xDC2B],1
        UInt8[DS, (ushort)0xDC2B] = (byte)0x01;
        // 100D:A56C mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:A56F call far dword ptr DS:[0x3991]
        ushort targetSegment_25731 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_25731 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_25731 == cs3 && targetOffset_25731 == 0x0106)
        {
            FarCall(cs1, 0xA573, cs3, unknown_5642_0106_56526);
            goto label_100D_A573_1A643_25732;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_25731:X4}:{targetOffset_25731:X4} at 100D:A56F");
    label_100D_A573_1A643_25732:
        CheckExternalEvents(cs1, 0xA573);
        // 100D:A573 jmp near 0xABA9
        return unknown_100D_ABA9_1AC79(0x0000);
    label_100D_A576_1A646_25526:
        CheckExternalEvents(cs1, 0xA576);
        // 100D:A576 mov DI,0x2886
        DI = (ushort)0x2886;
        // 100D:A579 call near 0xD6FE
        NearCall(cs1, 0xA57C, unknown_100D_D6FE_1D7CE);
    label_100D_A57C_1A64C_25529:
        CheckExternalEvents(cs1, 0xA57C);
        // 100D:A57C jb short 0xA581
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A57C");
        }
    label_100D_A581_1A651_25531:
        CheckExternalEvents(cs1, 0xA581);
        // 100D:A581 call near 0xA453
        NearCall(cs1, 0xA584, unknown_100D_A453_1A523);
    label_100D_A584_1A654_25537:
        CheckExternalEvents(cs1, 0xA584);
        // 100D:A584 mov DI,0x28BF
        DI = (ushort)0x28BF;
        // 100D:A587 call near 0xD6FE
        NearCall(cs1, 0xA58A, unknown_100D_D6FE_1D7CE);
    label_100D_A58A_1A65A_25540:
        CheckExternalEvents(cs1, 0xA58A);
        // 100D:A58A jb short 0xA553
        if (CarryFlag)
        {
            goto label_100D_A553_1A623_25716;
        }
    label_100D_A58C_1A65C_25542:
        CheckExternalEvents(cs1, 0xA58C);
        // 100D:A58C mov DI,0x28C7
        DI = (ushort)0x28C7;
        // 100D:A58F call near 0xD6FE
        NearCall(cs1, 0xA592, unknown_100D_D6FE_1D7CE);
    label_100D_A592_1A662_25545:
        CheckExternalEvents(cs1, 0xA592);
        // 100D:A592 jb short 0xA5B0
        if (!(CarryFlag))
        {
            return unknown_100D_A594_1A664(0x0000);
        }
    label_100D_A5B0_1A680_25640:
        CheckExternalEvents(cs1, 0xA5B0);
        // 100D:A5B0 sub BX,word ptr DS:[DI+2]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:A5B3 mov AX,BX
        AX = BX;
        // 100D:A5B5 mov BL,7
        BL = (byte)0x07;
        // 100D:A5B7 div BL
        byte divisor_100D_A5B7_1A687 = BL;
        ushort dividend_100D_A5B7_1A687 = AX;
        byte quotient_100D_A5B7_1A687 = Alu8.Div(unchecked((ushort)dividend_100D_A5B7_1A687), unchecked((byte)divisor_100D_A5B7_1A687));
        AL = unchecked((byte)quotient_100D_A5B7_1A687);
        AH = unchecked((byte)(dividend_100D_A5B7_1A687 % unchecked((ushort)divisor_100D_A5B7_1A687)));
        // 100D:A5B9 mov BX,0x28CF
        BX = (ushort)0x28CF;
        // 100D:A5BC xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:A5BD cmp AL,7
        Alu8.Sub(AL, (byte)0x07);
        // 100D:A5BF jb short 0xA5CA
        if (CarryFlag)
        {
            goto label_100D_A5CA_1A69A_25680;
        }
    label_100D_A5C1_1A691_25649:
        CheckExternalEvents(cs1, 0xA5C1);
        // 100D:A5C1 je short 0xA5DE
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A5C1");
        }
    label_100D_A5C3_1A693_25651:
        CheckExternalEvents(cs1, 0xA5C3);
        // 100D:A5C3 sub AL,8
        AL = Alu8.Sub(AL, (byte)0x08);
        // 100D:A5C5 mov byte ptr DS:[0x28E7],AL
        UInt8[DS, (ushort)0x28E7] = AL;
        // 100D:A5C8 jmp short 0xA5DB
        goto label_100D_A5DB_1A6AB_25655;
    label_100D_A5CA_1A69A_25680:
        CheckExternalEvents(cs1, 0xA5CA);
        // 100D:A5CA cmp AL,byte ptr DS:[0xCEEB]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xCEEB]);
        // 100D:A5CE je short 0xA5DE
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A5CE");
        }
    label_100D_A5D0_1A6A0_25683:
        CheckExternalEvents(cs1, 0xA5D0);
        // 100D:A5D0 and byte ptr DS:[0x28E7],0xFD
        UInt8[DS, (ushort)0x28E7] = Alu8.And(UInt8[DS, (ushort)0x28E7], (byte)0xFD);
        // 100D:A5D5 mov byte ptr DS:[0xCEEB],AL
        UInt8[DS, (ushort)0xCEEB] = AL;
        // 100D:A5D8 call near 0xCFE4
        NearCall(cs1, 0xA5DB, unknown_100D_CFE4_1D0B4);
    label_100D_A5DB_1A6AB_25655:
        CheckExternalEvents(cs1, 0xA5DB);
        // 100D:A5DB jmp near 0xA3F9
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0xA3F9))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A594_1A664(int loadOffset)
    {
    label_100D_A594_1A664_25547:
        CheckExternalEvents(cs1, 0xA594);
        // 100D:A594 call near 0xA672
        NearCall(cs1, 0xA597, unknown_100D_A672_1A742);
    label_100D_A597_1A667_25569:
        CheckExternalEvents(cs1, 0xA597);
        // 100D:A597 jae short 0xA59F
        if (!CarryFlag)
        {
            goto label_100D_A59F_1A66F_25606;
        }
    label_100D_A599_1A669_25571:
        CheckExternalEvents(cs1, 0xA599);
        // 100D:A599 mov byte ptr DS:[0x28BE],1
        UInt8[DS, (ushort)0x28BE] = (byte)0x01;
        // 100D:A59E ret near
        return NearRet((ushort)0x0000);
    label_100D_A59F_1A66F_25606:
        CheckExternalEvents(cs1, 0xA59F);
        // 100D:A59F call near 0xA69F
        NearCall(cs1, 0xA5A2, unknown_100D_A69F_1A76F);
    label_100D_A5A2_1A672_25635:
        CheckExternalEvents(cs1, 0xA5A2);
        // 100D:A5A2 jae short 0xA5AA
        if (!CarryFlag)
        {
            return unknown_100D_A5AA_1A67A(0x0000);
        }
    label_100D_A5A4_1A674_25689:
        CheckExternalEvents(cs1, 0xA5A4);
        // 100D:A5A4 mov byte ptr DS:[0x28BE],2
        UInt8[DS, (ushort)0x28BE] = (byte)0x02;
        // 100D:A5A9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A5AA_1A67A(int loadOffset)
    {
    label_100D_A5AA_1A67A_25521:
        CheckExternalEvents(cs1, 0xA5AA);
        // 100D:A5AA mov byte ptr DS:[0x28BE],0
        UInt8[DS, (ushort)0x28BE] = (byte)0x00;
        // 100D:A5AF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A5DF_1A6AF(int loadOffset)
    {
    entrydispatcher:
    label_100D_A5DF_1A6AF_25574:
        CheckExternalEvents(cs1, 0xA5DF);
        // 100D:A5DF call near 0xA453
        NearCall(cs1, 0xA5E2, unknown_100D_A453_1A523);
    label_100D_A5E2_1A6B2_25576:
        CheckExternalEvents(cs1, 0xA5E2);
        // 100D:A5E2 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:A5E4 call near 0xA594
        NearCall(cs1, 0xA5E7, unknown_100D_A594_1A664);
    label_100D_A5E7_1A6B7_25579:
        CheckExternalEvents(cs1, 0xA5E7);
        // 100D:A5E7 cmp byte ptr DS:[0x28BE],1
        Alu8.Sub(UInt8[DS, (ushort)0x28BE], (byte)0x01);
        // 100D:A5EC je short 0xA61A
        if (ZeroFlag)
        {
            goto label_100D_A61A_1A6EA_25582;
        }
    label_100D_A5EE_1A6BE_25637:
        CheckExternalEvents(cs1, 0xA5EE);
        // 100D:A5EE cmp byte ptr DS:[0x28BE],2
        Alu8.Sub(UInt8[DS, (ushort)0x28BE], (byte)0x02);
        // 100D:A5F3 jne short 0xA619
        if (!ZeroFlag)
        {
            goto label_100D_A619_1A6E9_25597;
        }
    label_100D_A5F5_1A6C5_25692:
        CheckExternalEvents(cs1, 0xA5F5);
        // 100D:A5F5 cmp AX,6
        Alu16.Sub(AX, (ushort)0x0006);
        // 100D:A5F8 jae short 0xA5FC
        if (!CarryFlag)
        {
            goto label_100D_A5FC_1A6CC_25697;
        }
    label_100D_A5FA_1A6CA_25695:
        CheckExternalEvents(cs1, 0xA5FA);
        // 100D:A5FA neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_A5FC_1A6CC_25697:
        CheckExternalEvents(cs1, 0xA5FC);
        // 100D:A5FC cmp BP,5
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:A5FF jb short 0xA603
        if (CarryFlag)
        {
            goto label_100D_A603_1A6D3_25699;
        }
    label_100D_A601_1A6D1_25713:
        CheckExternalEvents(cs1, 0xA601);
        // 100D:A601 neg DI
        DI = Alu16.Sub((ushort)0x0000, DI);
        CarryFlag = DI != (ushort)0x0000;
    label_100D_A603_1A6D3_25699:
        CheckExternalEvents(cs1, 0xA603);
        // 100D:A603 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:A605 add CX,DI
        CX = Alu16.Add(CX, DI);
        // 100D:A607 jns short 0xA60B
        if (!SignFlag)
        {
            goto label_100D_A60B_1A6DB_25705;
        }
    label_100D_A609_1A6D9_25703:
        CheckExternalEvents(cs1, 0xA609);
        // 100D:A609 neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_A60B_1A6DB_25705:
        CheckExternalEvents(cs1, 0xA60B);
        // 100D:A60B add AL,byte ptr DS:[SI]
        AL = Alu8.Add(AL, UInt8[DS, SI]);
        // 100D:A60D cmp AL,0xF1
        Alu8.Sub(AL, (byte)0xF1);
        // 100D:A60F jae short 0xA619
        if (!CarryFlag)
        {
            goto label_100D_A619_1A6E9_25597;
        }
    label_100D_A611_1A6E1_25708:
        CheckExternalEvents(cs1, 0xA611);
        // 100D:A611 mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 100D:A613 push word ptr DS:[SI+6]
        Stack.Push16(UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:A616 jmp near 0xA49C
        if (JumpDispatcher.Jump(unknown_100D_A49C_1A56C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_A619_1A6E9_25597:
        CheckExternalEvents(cs1, 0xA619);
        // 100D:A619 ret near
        return NearRet((ushort)0x0000);
    label_100D_A61A_1A6EA_25582:
        CheckExternalEvents(cs1, 0xA61A);
        // 100D:A61A jcxz short 0xA619
        if (CX == (ushort)0x0000)
        {
            goto label_100D_A619_1A6E9_25597;
        }
    label_100D_A61C_1A6EC_25584:
        CheckExternalEvents(cs1, 0xA61C);
        // 100D:A61C mov AX,word ptr DS:[SI+4]
        AX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:A61F add AX,CX
        AX = Alu16.Add(AX, CX);
        // 100D:A621 sub AX,0x0022
        AX = Alu16.Sub(AX, (ushort)0x0022);
        // 100D:A624 cmp AX,0x0040
        Alu16.Sub(AX, (ushort)0x0040);
        // 100D:A627 jae short 0xA619
        if (!CarryFlag)
        {
            goto label_100D_A619_1A6E9_25597;
        }
    label_100D_A629_1A6F9_25590:
        CheckExternalEvents(cs1, 0xA629);
        // 100D:A629 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A62B shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A62D not AX
        AX = unchecked((ushort)~AX);
        // 100D:A62F mov byte ptr DS:[SI],AL
        UInt8[DS, SI] = AL;
        // 100D:A631 push word ptr DS:[SI+6]
        Stack.Push16(UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:A634 jmp near 0xA502
        if (JumpDispatcher.Jump(unknown_100D_A502_1A5D2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_A637_1A707(int loadOffset)
    {
    entrydispatcher:
    label_100D_A637_1A707_1724:
        CheckExternalEvents(cs1, 0xA637);
        // 100D:A637 test word ptr DS:[0xDBC8],4
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0004);
        // 100D:A63D jne short 0xA644
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A63D");
        }
    label_100D_A644_1A714_1727:
        CheckExternalEvents(cs1, 0xA644);
        // 100D:A644 mov AL,byte ptr DS:[0x288E]
        AL = UInt8[DS, (ushort)0x288E];
        // 100D:A647 mov AH,byte ptr DS:[0x28A6]
        AH = UInt8[DS, (ushort)0x28A6];
        // 100D:A64B call far dword ptr DS:[0x39A5]
        ushort targetSegment_1730 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x39A5 + (ushort)0x0002)]));
        ushort targetOffset_1730 = unchecked((ushort)(UInt16[DS, (ushort)0x39A5]));
        if (targetSegment_1730 == cs3 && targetOffset_1730 == 0x0115)
        {
            FarCall(cs1, 0xA64F, cs3, unknown_5642_0115_56535);
            goto label_100D_A64F_1A71F_1785;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_1730:X4}:{targetOffset_1730:X4} at 100D:A64B");
    label_100D_A64F_1A71F_1785:
        CheckExternalEvents(cs1, 0xA64F);
        // 100D:A64F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A650_1A720(int loadOffset)
    {
    entrydispatcher:
    label_100D_A650_1A720_2357:
        CheckExternalEvents(cs1, 0xA650);
        // 100D:A650 test word ptr DS:[0xDBC8],0x0400
        Alu16.And(UInt16[DS, (ushort)0xDBC8], (ushort)0x0400);
        // 100D:A656 jne short 0xA660
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A656");
        }
    label_100D_A660_1A730_2360:
        CheckExternalEvents(cs1, 0xA660);
        // 100D:A660 mov AH,byte ptr DS:[0x28AE]
        AH = UInt8[DS, (ushort)0x28AE];
        // 100D:A664 mov AL,byte ptr DS:[0x2896]
        AL = UInt8[DS, (ushort)0x2896];
        // 100D:A667 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:A669 jae short 0xA66D
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A669");
        }
    label_100D_A66D_1A73D_2365:
        CheckExternalEvents(cs1, 0xA66D);
        // 100D:A66D call far dword ptr DS:[0x3985]
        ushort targetSegment_2365 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3985 + (ushort)0x0002)]));
        ushort targetOffset_2365 = unchecked((ushort)(UInt16[DS, (ushort)0x3985]));
        if (targetSegment_2365 == cs4 && targetOffset_2365 == 0x0112)
        {
            FarCall(cs1, 0xA671, cs4, unknown_5BAE_0112_5BBF2);
            goto label_100D_A671_1A741_2409;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_2365:X4}:{targetOffset_2365:X4} at 100D:A66D");
    label_100D_A671_1A741_2409:
        CheckExternalEvents(cs1, 0xA671);
        // 100D:A671 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A672_1A742(int loadOffset)
    {
    label_100D_A672_1A742_25549:
        CheckExternalEvents(cs1, 0xA672);
        // 100D:A672 mov SI,0x288E
        SI = (ushort)0x288E;
        // 100D:A675 call near 0xA685
        NearCall(cs1, 0xA678, unknown_100D_A685_1A755);
    label_100D_A678_1A748_25566:
        CheckExternalEvents(cs1, 0xA678);
        // 100D:A678 jb short 0xA69E
        if (CarryFlag)
        {
            return unknown_100D_A69E_1A76E(0x0000);
        }
    label_100D_A67A_1A74A_25599:
        CheckExternalEvents(cs1, 0xA67A);
        // 100D:A67A mov SI,0x2896
        SI = (ushort)0x2896;
        // 100D:A67D call near 0xA685
        NearCall(cs1, 0xA680, unknown_100D_A685_1A755);
    label_100D_A680_1A750_25602:
        CheckExternalEvents(cs1, 0xA680);
        // 100D:A680 jb short 0xA69E
        if (CarryFlag)
        {
            return unknown_100D_A69E_1A76E(0x0000);
        }
    label_100D_A682_1A752_25604:
        CheckExternalEvents(cs1, 0xA682);
        // 100D:A682 mov SI,0x289E
        SI = (ushort)0x289E;
        return unknown_100D_A685_1A755(0x0000);
    }

    public virtual Action unknown_100D_A685_1A755(int loadOffset)
    {
    label_100D_A685_1A755_25552:
        CheckExternalEvents(cs1, 0xA685);
        // 100D:A685 cmp byte ptr DS:[SI+1],1
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)1)], (byte)0x01);
        // 100D:A689 cmc
        CarryFlag = !CarryFlag;
        // 100D:A68A jae short 0xA69E
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A68A");
        }
    label_100D_A68C_1A75C_25556:
        CheckExternalEvents(cs1, 0xA68C);
        // 100D:A68C mov AX,DX
        AX = DX;
        // 100D:A68E sub AX,word ptr DS:[SI+2]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:A691 mov BP,BX
        BP = BX;
        // 100D:A693 sub BP,word ptr DS:[SI+4]
        BP = Alu16.Sub(BP, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:A696 cmp AX,0x0016
        Alu16.Sub(AX, (ushort)0x0016);
        // 100D:A699 jae short 0xA69E
        if (!CarryFlag)
        {
            return unknown_100D_A69E_1A76E(0x0000);
        }
    label_100D_A69B_1A76B_25563:
        CheckExternalEvents(cs1, 0xA69B);
        // 100D:A69B cmp BP,5
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)5)));
        return unknown_100D_A69E_1A76E(0x0000);
    }

    public virtual Action unknown_100D_A69F_1A76F(int loadOffset)
    {
    label_100D_A69F_1A76F_25608:
        CheckExternalEvents(cs1, 0xA69F);
        // 100D:A69F mov SI,0x28A6
        SI = (ushort)0x28A6;
        // 100D:A6A2 call near 0xA6B2
        NearCall(cs1, 0xA6A5, unknown_100D_A6B2_1A782);
    label_100D_A6A5_1A775_25625:
        CheckExternalEvents(cs1, 0xA6A5);
        // 100D:A6A5 jb short 0xA6CB
        if (CarryFlag)
        {
            return unknown_100D_A6CB_1A79B(0x0000);
        }
    label_100D_A6A7_1A777_25627:
        CheckExternalEvents(cs1, 0xA6A7);
        // 100D:A6A7 mov SI,0x28AE
        SI = (ushort)0x28AE;
        // 100D:A6AA call near 0xA6B2
        NearCall(cs1, 0xA6AD, unknown_100D_A6B2_1A782);
    label_100D_A6AD_1A77D_25631:
        CheckExternalEvents(cs1, 0xA6AD);
        // 100D:A6AD jb short 0xA6CB
        if (CarryFlag)
        {
            return unknown_100D_A6CB_1A79B(0x0000);
        }
    label_100D_A6AF_1A77F_25633:
        CheckExternalEvents(cs1, 0xA6AF);
        // 100D:A6AF mov SI,0x28B6
        SI = (ushort)0x28B6;
        return unknown_100D_A6B2_1A782(0x0000);
    }

    public virtual Action unknown_100D_A6B2_1A782(int loadOffset)
    {
    label_100D_A6B2_1A782_25611:
        CheckExternalEvents(cs1, 0xA6B2);
        // 100D:A6B2 cmp byte ptr DS:[SI+1],1
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)1)], (byte)0x01);
        // 100D:A6B6 cmc
        CarryFlag = !CarryFlag;
        // 100D:A6B7 jae short 0xA6CB
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A6B7");
        }
    label_100D_A6B9_1A789_25615:
        CheckExternalEvents(cs1, 0xA6B9);
        // 100D:A6B9 mov AX,DX
        AX = DX;
        // 100D:A6BB sub AX,word ptr DS:[SI+2]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:A6BE mov BP,BX
        BP = BX;
        // 100D:A6C0 sub BP,word ptr DS:[SI+4]
        BP = Alu16.Sub(BP, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:A6C3 cmp AX,0x000D
        Alu16.Sub(AX, (ushort)0x000D);
        // 100D:A6C6 jae short 0xA6CB
        if (!CarryFlag)
        {
            return unknown_100D_A6CB_1A79B(0x0000);
        }
    label_100D_A6C8_1A798_25622:
        CheckExternalEvents(cs1, 0xA6C8);
        // 100D:A6C8 cmp BP,0x000B
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)11)));
        return unknown_100D_A6CB_1A79B(0x0000);
    }

    public virtual Action unknown_100D_A6CC_1A79C(int loadOffset)
    {
    label_100D_A6CC_1A79C_8381:
        CheckExternalEvents(cs1, 0xA6CC);
        // 100D:A6CC cmp BX,-1
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:A6CF jne short 0xA6E6
        if (!ZeroFlag)
        {
            goto label_100D_A6E6_1A7B6_8384;
        }
    label_100D_A6D1_1A7A1_37931:
        CheckExternalEvents(cs1, 0xA6D1);
        // 100D:A6D1 mov AX,word ptr [0x0001A7A2]
        AX = UInt16[unchecked((uint)(0x0001A7A2u))];
        // 100D:A6D4 xor byte ptr CS:[0xA6D3],0x10
        UInt8[CS, (ushort)0xA6D3] = Alu8.Xor(UInt8[CS, (ushort)0xA6D3], (byte)0x10);
        // 100D:A6DA mov BX,word ptr DS:[0x22A6]
        BX = UInt16[DS, (ushort)0x22A6];
        // 100D:A6DE call near 0xA8BC
        NearCall(cs1, 0xA6E1, unknown_100D_A8BC_1A98C);
    label_100D_A6E1_1A7B1_37866:
        CheckExternalEvents(cs1, 0xA6E1);
        // 100D:A6E1 call near 0xA7A5
        NearCall(cs1, 0xA6E4, unknown_100D_A7A5_1A875);
    label_100D_A6E4_1A7B4_37869:
        CheckExternalEvents(cs1, 0xA6E4);
        // 100D:A6E4 jmp short 0xA740
        goto label_100D_A740_1A810_8464;
    label_100D_A6E6_1A7B6_8384:
        CheckExternalEvents(cs1, 0xA6E6);
        // 100D:A6E6 push BX
        Stack.Push16(BX);
        // 100D:A6E7 cmp BL,0x0E
        Alu8.Sub(BL, (byte)0x0E);
        // 100D:A6EA jb short 0xA6EE
        if (CarryFlag)
        {
            goto label_100D_A6EE_1A7BE_8388;
        }
    label_100D_A6EC_1A7BC_23181:
        CheckExternalEvents(cs1, 0xA6EC);
        // 100D:A6EC mov BL,0x0E
        BL = (byte)0x0E;
    label_100D_A6EE_1A7BE_8388:
        CheckExternalEvents(cs1, 0xA6EE);
        // 100D:A6EE and AH,0xF3
        AH = Alu8.And(AH, (byte)0xF3);
        // 100D:A6F1 cmp byte ptr DS:[0x47DC],0
        Alu8.Sub(UInt8[DS, (ushort)0x47DC], (byte)0x00);
        // 100D:A6F6 je short 0xA701
        if (ZeroFlag)
        {
            goto label_100D_A701_1A7D1_8392;
        }
    label_100D_A6F8_1A7C8_27199:
        CheckExternalEvents(cs1, 0xA6F8);
        // 100D:A6F8 sub AX,word ptr DS:[0xD814]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0xD814]);
        // 100D:A6FC add AX,0x03E7
        AX = Alu16.Add(AX, (ushort)0x03E7);
        // 100D:A6FF jmp short 0xA710
        goto label_100D_A710_1A7E0_8395;
    label_100D_A701_1A7D1_8392:
        CheckExternalEvents(cs1, 0xA701);
        // 100D:A701 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:A706 jne short 0xA710
        if (!ZeroFlag)
        {
            goto label_100D_A710_1A7E0_8395;
        }
    label_100D_A708_1A7D8_15760:
        CheckExternalEvents(cs1, 0xA708);
        // 100D:A708 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:A70A sub AX,word ptr DS:[BX-10252]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(BX + (short)-10252)]);
        // 100D:A70E shr BX,1
        BX = Alu16.Shr(BX, 1);
    label_100D_A710_1A7E0_8395:
        CheckExternalEvents(cs1, 0xA710);
        // 100D:A710 cmp BL,0x0E
        Alu8.Sub(BL, (byte)0x0E);
        // 100D:A713 jne short 0xA727
        if (!ZeroFlag)
        {
            goto label_100D_A727_1A7F7_8398;
        }
    label_100D_A715_1A7E5_23183:
        CheckExternalEvents(cs1, 0xA715);
        // 100D:A715 mov CX,AX
        CX = AX;
        // 100D:A717 and CL,0xFE
        CL = Alu8.And(CL, (byte)0xFE);
        // 100D:A71A cmp CL,0x2C
        Alu8.Sub(CL, (byte)0x2C);
        // 100D:A71D jne short 0xA727
        if (!ZeroFlag)
        {
            goto label_100D_A727_1A7F7_8398;
        }
    label_100D_A71F_1A7EF_34549:
        CheckExternalEvents(cs1, 0xA71F);
        // 100D:A71F pop CX
        CX = Stack.Pop16();
        // 100D:A720 mov CL,0x0C
        CL = (byte)0x0C;
        // 100D:A722 mov word ptr DS:[0x47C4],CX
        UInt16[DS, (ushort)0x47C4] = CX;
        // 100D:A726 push CX
        Stack.Push16(CX);
    label_100D_A727_1A7F7_8398:
        CheckExternalEvents(cs1, 0xA727);
        // 100D:A727 call near 0xA8BC
        NearCall(cs1, 0xA72A, unknown_100D_A8BC_1A98C);
    label_100D_A72A_1A7FA_8452:
        CheckExternalEvents(cs1, 0xA72A);
        // 100D:A72A call near 0xA7A5
        NearCall(cs1, 0xA72D, unknown_100D_A7A5_1A875);
    label_100D_A72D_1A7FD_8454:
        CheckExternalEvents(cs1, 0xA72D);
        // 100D:A72D pop AX
        AX = Stack.Pop16();
        // 100D:A72E call near 0x9123
        NearCall(cs1, 0xA731, unknown_100D_9123_191F3);
    label_100D_A731_1A801_8457:
        CheckExternalEvents(cs1, 0xA731);
        // 100D:A731 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A733 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A735 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A737 add AX,0x27FA
        AX = Alu16.Add(AX, (ushort)0x27FA);
        // 100D:A73A mov SI,AX
        SI = AX;
        // 100D:A73C mov word ptr DS:[0xDC28],SI
        UInt16[DS, (ushort)0xDC28] = SI;
    label_100D_A740_1A810_8464:
        CheckExternalEvents(cs1, 0xA740);
        // 100D:A740 mov byte ptr DS:[0xDC2A],0xFF
        UInt8[DS, (ushort)0xDC2A] = (byte)0xFF;
        // 100D:A745 call near 0xA83F
        NearCall(cs1, 0xA748, unknown_100D_A83F_1A90F);
    label_100D_A748_1A818_8585:
        CheckExternalEvents(cs1, 0xA748);
        // 100D:A748 jb short 0xA754
        if (CarryFlag)
        {
            goto label_100D_A754_1A824_8587;
        }
    label_100D_A74A_1A81A_30145:
        CheckExternalEvents(cs1, 0xA74A);
        // 100D:A74A xor byte ptr DS:[0x37E2],6
        UInt8[DS, (ushort)0x37E2] = Alu8.Xor(UInt8[DS, (ushort)0x37E2], (byte)0x06);
        // 100D:A74F call near 0xA83F
        NearCall(cs1, 0xA752, unknown_100D_A83F_1A90F);
    label_100D_A752_1A822_30148:
        CheckExternalEvents(cs1, 0xA752);
        // 100D:A752 jae short 0xA75B
        if (!CarryFlag)
        {
            goto label_100D_A75B_1A82B_8637;
        }
    label_100D_A754_1A824_8587:
        CheckExternalEvents(cs1, 0xA754);
        // 100D:A754 call near 0xADE0
        NearCall(cs1, 0xA757, unknown_100D_ADE0_1AEB0);
    label_100D_A757_1A827_8628:
        CheckExternalEvents(cs1, 0xA757);
        // 100D:A757 call near 0xD617
        NearCall(cs1, 0xA75A, unknown_100D_D617_1D6E7);
    label_100D_A75A_1A82A_8635:
        CheckExternalEvents(cs1, 0xA75A);
        // 100D:A75A stc
        CarryFlag = true;
    label_100D_A75B_1A82B_8637:
        CheckExternalEvents(cs1, 0xA75B);
        // 100D:A75B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A7A5_1A875(int loadOffset)
    {
    entrydispatcher:
    label_100D_A7A5_1A875_3518:
        CheckExternalEvents(cs1, 0xA7A5);
        // 100D:A7A5 mov SI,0xA7C2
        SI = (ushort)0xA7C2;
        // 100D:A7A8 call near 0xDA5F
        NearCall(cs1, 0xA7AB, unknown_100D_DA5F_1DB2F);
    label_100D_A7AB_1A87B_3521:
        CheckExternalEvents(cs1, 0xA7AB);
        // 100D:A7AB mov word ptr DS:[0xDC26],0
        UInt16[DS, (ushort)0xDC26] = (ushort)0x0000;
        // 100D:A7B1 call near 0xD61D
        NearCall(cs1, 0xA7B4, unknown_100D_D61D_1D6ED);
    label_100D_A7B4_1A884_3571:
        CheckExternalEvents(cs1, 0xA7B4);
        // 100D:A7B4 call near 0xABCC
        NearCall(cs1, 0xA7B7, unknown_100D_ABCC_1AC9C);
    label_100D_A7B7_1A887_3576:
        CheckExternalEvents(cs1, 0xA7B7);
        // 100D:A7B7 je short 0xA788
        if (ZeroFlag)
        {
            return unknown_100D_A788_1A858(0x0000);
        }
    label_100D_A7B9_1A889_9309:
        CheckExternalEvents(cs1, 0xA7B9);
        // 100D:A7B9 call near 0xABC6
        NearCall(cs1, 0xA7BC, unknown_100D_ABC6_1AC96);
    label_100D_A7BC_1A88C_9314:
        CheckExternalEvents(cs1, 0xA7BC);
        // 100D:A7BC call near 0xA9A1
        NearCall(cs1, 0xA7BF, unknown_100D_A9A1_1AA71);
    label_100D_A7BF_1A88F_9319:
        CheckExternalEvents(cs1, 0xA7BF);
        // 100D:A7BF jmp near 0xADED
        return unknown_100D_ADED_1AEBD(0x0000);
    }

    public virtual Action unknown_100D_A7C2_1A892(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_A7C2_1A892_9052;

    label_100D_A789_1A859_9297:
        CheckExternalEvents(cs1, 0xA789);
        // 100D:A789 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:A78B xchg AX,word ptr DS:[0xDC30]
        ushort xchgOffset_100D_A78B_1A85B = (ushort)0xDC30;
        ushort temp_100D_A78B_1A85B = AX;
        AX = UInt16[DS, xchgOffset_100D_A78B_1A85B];
        UInt16[DS, xchgOffset_100D_A78B_1A85B] = unchecked((ushort)temp_100D_A78B_1A85B);
        // 100D:A78F or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:A791 je short 0xA7A5
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_A7A5_1A875, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_A793_1A863_37290:
        CheckExternalEvents(cs1, 0xA793);
        // 100D:A793 push AX
        Stack.Push16(AX);
        // 100D:A794 call near 0xA7A5
        NearCall(cs1, 0xA797, unknown_100D_A7A5_1A875);
    label_100D_A797_1A867_37293:
        CheckExternalEvents(cs1, 0xA797);
        // 100D:A797 pop AX
        AX = Stack.Pop16();
        // 100D:A798 add AX,word ptr DS:[0xD810]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0xD810]);
        // 100D:A79C mov BL,0x0E
        BL = (byte)0x0E;
        // 100D:A79E call near 0xA6CC
        NearCall(cs1, 0xA7A1, unknown_100D_A6CC_1A79C);
    label_100D_A7A1_1A871_37299:
        CheckExternalEvents(cs1, 0xA7A1);
        // 100D:A7A1 jae short 0xA788
        if (!CarryFlag)
        {
            return unknown_100D_A788_1A858(0x0000);
        }
    label_100D_A7A3_1A873_40278:
        CheckExternalEvents(cs1, 0xA7A3);
        // 100D:A7A3 jmp short 0xA75C
        if (JumpDispatcher.Jump(unknown_100D_A75C_1A82C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_A7C2_1A892_9052:
        CheckExternalEvents(cs1, 0xA7C2);
        // 100D:A7C2 call near 0xABCC
        NearCall(cs1, 0xA7C5, unknown_100D_ABCC_1AC9C);
    label_100D_A7C5_1A895_9054:
        CheckExternalEvents(cs1, 0xA7C5);
        // 100D:A7C5 je short 0xA788
        if (ZeroFlag)
        {
            return unknown_100D_A788_1A858(0x0000);
        }
    label_100D_A7C7_1A897_9056:
        CheckExternalEvents(cs1, 0xA7C7);
        // 100D:A7C7 cmp word ptr DS:[0xDC26],0
        Alu16.Sub(UInt16[DS, (ushort)0xDC26], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A7CC jne short 0xA7D5
        if (!ZeroFlag)
        {
            goto label_100D_A7D5_1A8A5_9059;
        }
    label_100D_A7CE_1A89E_33477:
        CheckExternalEvents(cs1, 0xA7CE);
        // 100D:A7CE call near 0xA9E7
        NearCall(cs1, 0xA7D1, unknown_100D_A9E7_1AAB7);
    label_100D_A7D1_1A8A1_33479:
        CheckExternalEvents(cs1, 0xA7D1);
        // 100D:A7D1 jne short 0xA789
        if (!ZeroFlag)
        {
            goto label_100D_A789_1A859_9297;
        }
    label_100D_A7D3_1A8A3_33481:
        CheckExternalEvents(cs1, 0xA7D3);
        // 100D:A7D3 jmp short 0xA811
        goto label_100D_A811_1A8E1_9070;
    label_100D_A7D5_1A8A5_9059:
        CheckExternalEvents(cs1, 0xA7D5);
        // 100D:A7D5 mov DX,word ptr DS:[0xCE7A]
        DX = UInt16[DS, (ushort)0xCE7A];
        // 100D:A7D9 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:A7DB mov BX,word ptr DS:[0xDC2C]
        BX = UInt16[DS, (ushort)0xDC2C];
        // 100D:A7DF mov BP,word ptr DS:[0xDC2E]
        BP = UInt16[DS, (ushort)0xDC2E];
        // 100D:A7E3 mov CX,word ptr DS:[0x2882]
        CX = UInt16[DS, (ushort)0x2882];
        // 100D:A7E7 mov SI,word ptr DS:[0x2884]
        SI = UInt16[DS, (ushort)0x2884];
        // 100D:A7EB add BP,SI
        BP = Alu16.Add(BP, SI);
        // 100D:A7ED adc BX,CX
        BX = Alu16.Adc(BX, CX);
        // 100D:A7EF sub DX,BX
        DX = Alu16.Sub(DX, BX);
        // 100D:A7F1 js short 0xA811
        if (SignFlag)
        {
            goto label_100D_A811_1A8E1_9070;
        }
    label_100D_A7F3_1A8C3_9090:
        CheckExternalEvents(cs1, 0xA7F3);
        // 100D:A7F3 push DI
        Stack.Push16(DI);
        // 100D:A7F4 call near 0xA814
        NearCall(cs1, 0xA7F7, unknown_100D_A814_1A8E4);
    label_100D_A7F7_1A8C7_9093:
        CheckExternalEvents(cs1, 0xA7F7);
        // 100D:A7F7 pop DI
        DI = Stack.Pop16();
        // 100D:A7F8 jae short 0xA789
        if (!CarryFlag)
        {
            goto label_100D_A789_1A859_9297;
        }
    label_100D_A7FA_1A8CA_9096:
        CheckExternalEvents(cs1, 0xA7FA);
        // 100D:A7FA sub DI,SI
        DI = Alu16.Sub(DI, SI);
        // 100D:A7FC sbb DX,CX
        DX = Alu16.Sbb(DX, CX);
        // 100D:A7FE jb short 0xA806
        if (CarryFlag)
        {
            goto label_100D_A806_1A8D6_9100;
        }
    label_100D_A800_1A8D0_24545:
        CheckExternalEvents(cs1, 0xA800);
        // 100D:A800 add BP,SI
        BP = Alu16.Add(BP, SI);
        // 100D:A802 adc BX,CX
        BX = Alu16.Adc(BX, CX);
        // 100D:A804 jmp short 0xA7F3
        goto label_100D_A7F3_1A8C3_9090;
    label_100D_A806_1A8D6_9100:
        CheckExternalEvents(cs1, 0xA806);
        // 100D:A806 mov word ptr DS:[0xDC2C],BX
        UInt16[DS, (ushort)0xDC2C] = BX;
        // 100D:A80A mov word ptr DS:[0xDC2E],BP
        UInt16[DS, (ushort)0xDC2E] = BP;
        // 100D:A80E call near 0xA82E
        NearCall(cs1, 0xA811, unknown_100D_A82E_1A8FE);
    label_100D_A811_1A8E1_9070:
        CheckExternalEvents(cs1, 0xA811);
        // 100D:A811 jmp near 0xA9B9
        return unknown_100D_A9B9_1AA89(0x0000);
    }

    public virtual Action unknown_100D_A814_1A8E4(int loadOffset)
    {
    label_100D_A814_1A8E4_8710:
        CheckExternalEvents(cs1, 0xA814);
        // 100D:A814 mov DI,word ptr DS:[0xDC26]
        DI = UInt16[DS, (ushort)0xDC26];
        // 100D:A818 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:A81A je short 0xA82D
        if (ZeroFlag)
        {
            goto label_100D_A82D_1A8FD_8723;
        }
    label_100D_A81C_1A8EC_8714:
        CheckExternalEvents(cs1, 0xA81C);
        // 100D:A81C mov ES,word ptr DS:[0x3813]
        ES = UInt16[DS, (ushort)0x3813];
        // 100D:A820 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 100D:A823 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:A825 jae short 0xA82D
        if (!CarryFlag)
        {
            goto label_100D_A82D_1A8FD_8723;
        }
    label_100D_A827_1A8F7_8719:
        CheckExternalEvents(cs1, 0xA827);
        // 100D:A827 inc DI
        DI = Alu16.Inc(DI);
        // 100D:A828 mov word ptr DS:[0xDC26],DI
        UInt16[DS, (ushort)0xDC26] = DI;
        // 100D:A82C stc
        CarryFlag = true;
    label_100D_A82D_1A8FD_8723:
        CheckExternalEvents(cs1, 0xA82D);
        // 100D:A82D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A82E_1A8FE(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_A82E_1A8FE_8728;

    label_100D_9DE3_19EB3_8735:
        CheckExternalEvents(cs1, 0x9DE3);
        // 100D:9DE3 cmp word ptr DS:[0x47C4],0x0010
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:9DE8 jae short 0x9D93
        if (!CarryFlag)
        {
            return unknown_100D_9D93_19E63(0x0000);
        }
    label_100D_9DEA_19EBA_8738:
        CheckExternalEvents(cs1, 0x9DEA);
        // 100D:9DEA push AX
        Stack.Push16(AX);
        // 100D:9DEB push SI
        Stack.Push16(SI);
        // 100D:9DEC call near 0x9197
        NearCall(cs1, 0x9DEF, unknown_100D_9197_19267);
    label_100D_9DEF_19EBF_8742:
        CheckExternalEvents(cs1, 0x9DEF);
        // 100D:9DEF pop SI
        SI = Stack.Pop16();
        // 100D:9DF0 pop AX
        AX = Stack.Pop16();
        // 100D:9DF1 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:9DF6 js short 0x9E75
        if (SignFlag)
        {
            goto label_100D_9E75_19F45_24406;
        }
    label_100D_9DF8_19EC8_8747:
        CheckExternalEvents(cs1, 0x9DF8);
        // 100D:9DF8 mov DI,0xD834
        DI = (ushort)0xD834;
        // 100D:9DFB call near 0x5B99
        NearCall(cs1, 0x9DFE, unknown_100D_5B99_15C69);
    label_100D_9DFE_19ECE_8750:
        CheckExternalEvents(cs1, 0x9DFE);
        // 100D:9DFE mov DX,word ptr DS:[0x1BF0]
        DX = UInt16[DS, (ushort)0x1BF0];
        // 100D:9E02 mov BX,word ptr DS:[0x1BF2]
        BX = UInt16[DS, (ushort)0x1BF2];
        // 100D:9E06 add word ptr DS:[DI-8],DX
        UInt16[DS, (ushort)(DI + (sbyte)-8)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)-8)], DX);
        // 100D:9E09 add word ptr DS:[DI-6],BX
        UInt16[DS, (ushort)(DI + (sbyte)-6)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)-6)], BX);
        // 100D:9E0C add word ptr DS:[DI-4],DX
        UInt16[DS, (ushort)(DI + (sbyte)-4)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)-4)], DX);
        // 100D:9E0F add word ptr DS:[DI-2],BX
        UInt16[DS, (ushort)(DI + (sbyte)-2)] = Alu16.Add(UInt16[DS, (ushort)(DI + (sbyte)-2)], BX);
        // 100D:9E12 mov SI,word ptr DS:[0x47D2]
        SI = UInt16[DS, (ushort)0x47D2];
        // 100D:9E16 mov AH,byte ptr DS:[0x47D0]
        AH = UInt8[DS, (ushort)0x47D0];
        // 100D:9E1A dec AH
        AH = Alu8.Dec(AH);
        // 100D:9E1C js short 0x9E2D
        if (SignFlag)
        {
            goto label_100D_9E2D_19EFD_8790;
        }
    label_100D_9E1E_19EEE_23188:
        CheckExternalEvents(cs1, 0x9E1E);
        // 100D:9E1E cmp word ptr DS:[0x22A6],0x000D
        Alu16.Sub(UInt16[DS, (ushort)0x22A6], unchecked((ushort)unchecked((short)(sbyte)13)));
        // 100D:9E23 jne short 0x9E27
        if (!ZeroFlag)
        {
            goto label_100D_9E27_19EF7_23191;
        }
    label_100D_9E25_19EF5_33904:
        CheckExternalEvents(cs1, 0x9E25);
        // 100D:9E25 add AL,AH
        AL = Alu8.Add(AL, AH);
    label_100D_9E27_19EF7_23191:
        CheckExternalEvents(cs1, 0x9E27);
        // 100D:9E27 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 100D:9E29 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 100D:9E2B add AL,AH
        AL = Alu8.Add(AL, AH);
    label_100D_9E2D_19EFD_8790:
        CheckExternalEvents(cs1, 0x9E2D);
        // 100D:9E2D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9E2F shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9E31 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:9E33 call near 0x9BEE
        NearCall(cs1, 0x9E36, unknown_100D_9BEE_19CBE);
    label_100D_9E36_19F06_8795:
        CheckExternalEvents(cs1, 0x9E36);
        // 100D:9E36 mov SI,0x4608
        SI = (ushort)0x4608;
        // 100D:9E39 cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:9E3E jg short 0x9E74
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_9E74_19F44_32713;
        }
    label_100D_9E40_19F10_8799:
        CheckExternalEvents(cs1, 0x9E40);
        // 100D:9E40 cmp word ptr DS:[SI],2
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:9E43 jb short 0x9E57
        if (CarryFlag)
        {
            goto label_100D_9E57_19F27_9350;
        }
    label_100D_9E45_19F15_8802:
        CheckExternalEvents(cs1, 0x9E45);
        // 100D:9E45 call near 0x9D2D
        NearCall(cs1, 0x9E48, unknown_100D_9D2D_19DFD);
    label_100D_9E48_19F18_9007:
        CheckExternalEvents(cs1, 0x9E48);
        // 100D:9E48 call near 0x908C
        NearCall(cs1, 0x9E4B, unknown_100D_908C_1915C);
    label_100D_9E4B_19F1B_9018:
        CheckExternalEvents(cs1, 0x9E4B);
        // 100D:9E4B mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:9E4E call near 0xDB74
        NearCall(cs1, 0x9E51, unknown_100D_DB74_1DC44);
    label_100D_9E51_19F21_9026:
        CheckExternalEvents(cs1, 0x9E51);
        // 100D:9E51 call near 0xC4F0
        NearCall(cs1, 0x9E54, unknown_100D_C4F0_1C5C0);
    label_100D_9E54_19F24_9043:
        CheckExternalEvents(cs1, 0x9E54);
        // 100D:9E54 jmp near 0xDB67
        if (JumpDispatcher.Jump(unknown_100D_DB67_1DC37, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9E57_19F27_9350:
        CheckExternalEvents(cs1, 0x9E57);
        // 100D:9E57 mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:9E5A call near 0xDB74
        NearCall(cs1, 0x9E5D, unknown_100D_DB74_1DC44);
    label_100D_9E5D_19F2D_9353:
        CheckExternalEvents(cs1, 0x9E5D);
        // 100D:9E5D push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:9E61 call near 0xC08E
        NearCall(cs1, 0x9E64, unknown_100D_C08E_1C15E);
    label_100D_9E64_19F34_9356:
        CheckExternalEvents(cs1, 0x9E64);
        // 100D:9E64 mov SI,0x4608
        SI = (ushort)0x4608;
        // 100D:9E67 call near 0x9D2D
        NearCall(cs1, 0x9E6A, unknown_100D_9D2D_19DFD);
    label_100D_9E6A_19F3A_9359:
        CheckExternalEvents(cs1, 0x9E6A);
        // 100D:9E6A call near 0x908C
        NearCall(cs1, 0x9E6D, unknown_100D_908C_1915C);
    label_100D_9E6D_19F3D_9361:
        CheckExternalEvents(cs1, 0x9E6D);
        // 100D:9E6D pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_9E6D_19F3D = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_9E6D_19F3D = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_9E6D_19F3D = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_9E6D_19F3D);
        // 100D:9E71 jmp near 0xDB67
        if (JumpDispatcher.Jump(unknown_100D_DB67_1DC37, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9E74_19F44_32713:
        CheckExternalEvents(cs1, 0x9E74);
        // 100D:9E74 ret near
        return NearRet((ushort)0x0000);
    label_100D_9E75_19F45_24406:
        CheckExternalEvents(cs1, 0x9E75);
        // 100D:9E75 mov SI,word ptr DS:[0x47D2]
        SI = UInt16[DS, (ushort)0x47D2];
        // 100D:9E79 cmp word ptr DS:[0x47C4],0x000C
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)12)));
        // 100D:9E7E je short 0x9E8C
        if (ZeroFlag)
        {
            goto label_100D_9E8C_19F5C_24416;
        }
    label_100D_9E80_19F50_24410:
        CheckExternalEvents(cs1, 0x9E80);
        // 100D:9E80 mov AH,byte ptr DS:[0x47D0]
        AH = UInt8[DS, (ushort)0x47D0];
        // 100D:9E84 dec AH
        AH = Alu8.Dec(AH);
        // 100D:9E86 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 100D:9E88 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 100D:9E8A add AL,AH
        AL = Alu8.Add(AL, AH);
    label_100D_9E8C_19F5C_24416:
        CheckExternalEvents(cs1, 0x9E8C);
        // 100D:9E8C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9E8E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9E90 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 100D:9E92 push SI
        Stack.Push16(SI);
        // 100D:9E93 mov SI,0x47D4
        SI = (ushort)0x47D4;
        // 100D:9E96 call near 0xDB74
        NearCall(cs1, 0x9E99, unknown_100D_DB74_1DC44);
    label_100D_9E99_19F69_24422:
        CheckExternalEvents(cs1, 0x9E99);
        // 100D:9E99 pop SI
        SI = Stack.Pop16();
        // 100D:9E9A push DS
        Stack.Push16(DS);
        // 100D:9E9B mov DS,word ptr SS:[0xDBB2]
        DS = UInt16[SS, (ushort)0xDBB2];
        // 100D:9EA0 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9EA1 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9EA3 sub AL,2
        AL = Alu8.Sub(AL, (byte)0x02);
        // 100D:9EA5 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9EA7 mov BP,AX
        BP = AX;
        // 100D:9EA9 mov SI,word ptr SS:[0x47CC]
        SI = UInt16[SS, (ushort)0x47CC];
        // 100D:9EAE add SI,word ptr DS:[BP+SI]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BP + SI)]);
        // 100D:9EB1 cmp byte ptr DS:[SI+3],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x00);
        // 100D:9EB5 je short 0x9EC9
        if (ZeroFlag)
        {
            goto label_100D_9EC9_19F99_24435;
        }
    label_100D_9EB7_19F87_26193:
        CheckExternalEvents(cs1, 0x9EB7);
        // 100D:9EB7 mov ES,word ptr SS:[0xDBD6]
        ES = UInt16[SS, (ushort)0xDBD6];
        // 100D:9EBC call near 0x9D94
        NearCall(cs1, 0x9EBF, unknown_100D_9D94_19E64);
    label_100D_9EBF_19F8F_26196:
        CheckExternalEvents(cs1, 0x9EBF);
        // 100D:9EBF pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9EC0 mov SI,0x47D4
        SI = (ushort)0x47D4;
        // 100D:9EC3 call near 0xC4F0
        NearCall(cs1, 0x9EC6, unknown_100D_C4F0_1C5C0);
    label_100D_9EC6_19F96_26200:
        CheckExternalEvents(cs1, 0x9EC6);
        // 100D:9EC6 jmp near 0xDB67
        if (JumpDispatcher.Jump(unknown_100D_DB67_1DC37, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9EC9_19F99_24435:
        CheckExternalEvents(cs1, 0x9EC9);
        // 100D:9EC9 mov ES,word ptr SS:[0xDBD8]
        ES = UInt16[SS, (ushort)0xDBD8];
        // 100D:9ECE call near 0x9D94
        NearCall(cs1, 0x9ED1, unknown_100D_9D94_19E64);
    label_100D_9ED1_19FA1_24438:
        CheckExternalEvents(cs1, 0x9ED1);
        // 100D:9ED1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9ED2 jmp near 0xDB67
        if (JumpDispatcher.Jump(unknown_100D_DB67_1DC37, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_A82E_1A8FE_8728:
        CheckExternalEvents(cs1, 0xA82E);
        // 100D:A82E cmp AL,byte ptr DS:[0xDC2A]
        Alu8.Sub(AL, UInt8[DS, (ushort)0xDC2A]);
        // 100D:A832 je short 0xA83E
        if (ZeroFlag)
        {
            goto label_100D_A83E_1A90E_9269;
        }
    label_100D_A834_1A904_8731:
        CheckExternalEvents(cs1, 0xA834);
        // 100D:A834 mov byte ptr DS:[0xDC2A],AL
        UInt8[DS, (ushort)0xDC2A] = AL;
        // 100D:A837 mov SI,word ptr DS:[0xDC28]
        SI = UInt16[DS, (ushort)0xDC28];
        // 100D:A83B jmp near 0x9DE3
        goto label_100D_9DE3_19EB3_8735;
    label_100D_A83E_1A90E_9269:
        CheckExternalEvents(cs1, 0xA83E);
        // 100D:A83E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A83F_1A90F(int loadOffset)
    {
    label_100D_A83F_1A90F_8466:
        CheckExternalEvents(cs1, 0xA83F);
        // 100D:A83F mov word ptr DS:[0xDC26],0
        UInt16[DS, (ushort)0xDC26] = (ushort)0x0000;
        // 100D:A845 call near 0xAE2F
        NearCall(cs1, 0xA848, unknown_100D_AE2F_1AEFF);
    label_100D_A848_1A918_8469:
        CheckExternalEvents(cs1, 0xA848);
        // 100D:A848 je short 0xA87D
        if (ZeroFlag)
        {
            goto label_100D_A87D_1A94D_8584;
        }
    label_100D_A84A_1A91A_8471:
        CheckExternalEvents(cs1, 0xA84A);
        // 100D:A84A call near 0xAC14
        NearCall(cs1, 0xA84D, unknown_100D_AC14_1ACE4);
    label_100D_A84D_1A91D_8473:
        CheckExternalEvents(cs1, 0xA84D);
        // 100D:A84D call near 0xA90B
        NearCall(cs1, 0xA850, unknown_100D_A90B_1A9DB);
    label_100D_A850_1A920_8535:
        CheckExternalEvents(cs1, 0xA850);
        // 100D:A850 cmc
        CarryFlag = !CarryFlag;
        // 100D:A851 jae short 0xA87D
        if (!CarryFlag)
        {
            goto label_100D_A87D_1A94D_8584;
        }
    label_100D_A853_1A923_8538:
        CheckExternalEvents(cs1, 0xA853);
        // 100D:A853 les DI,word ptr DS:[0x3811]
        ushort lxsOffset_100D_A853_1A923 = (ushort)0x3811;
        ushort lxsValue_100D_A853_1A923 = UInt16[DS, lxsOffset_100D_A853_1A923];
        ushort lxsSegment_100D_A853_1A923 = UInt16[DS, (ushort)(lxsOffset_100D_A853_1A923 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_A853_1A923);
        ES = unchecked((ushort)lxsSegment_100D_A853_1A923);
        // 100D:A857 add DI,0x001A
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)26)));
        // 100D:A85A cmp byte ptr ES:[DI],5
        Alu8.Sub(UInt8[ES, DI], (byte)0x05);
        // 100D:A85E jne short 0xA871
        if (!ZeroFlag)
        {
            goto label_100D_A871_1A941_8550;
        }
    label_100D_A860_1A930_8543:
        CheckExternalEvents(cs1, 0xA860);
        // 100D:A860 mov CX,word ptr ES:[DI+1]
        CX = UInt16[ES, (ushort)(DI + (sbyte)1)];
        // 100D:A864 add DI,4
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:A867 mov AX,DI
        AX = DI;
        // 100D:A869 add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:A86C mov word ptr DS:[0xDC26],AX
        UInt16[DS, (ushort)0xDC26] = AX;
        // 100D:A86F add DI,CX
        DI = Alu16.Add(DI, CX);
    label_100D_A871_1A941_8550:
        CheckExternalEvents(cs1, 0xA871);
        // 100D:A871 mov word ptr DS:[0x3811],DI
        UInt16[DS, (ushort)0x3811] = DI;
        // 100D:A875 sub word ptr DS:[0x3815],DI
        UInt16[DS, (ushort)0x3815] = Alu16.Sub(UInt16[DS, (ushort)0x3815], DI);
        // 100D:A879 call near 0xA9B9
        NearCall(cs1, 0xA87C, unknown_100D_A9B9_1AA89);
    label_100D_A87C_1A94C_8582:
        CheckExternalEvents(cs1, 0xA87C);
        // 100D:A87C stc
        CarryFlag = true;
    label_100D_A87D_1A94D_8584:
        CheckExternalEvents(cs1, 0xA87D);
        // 100D:A87D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A87E_1A94E(int loadOffset)
    {
    label_100D_A87E_1A94E_1819:
        CheckExternalEvents(cs1, 0xA87E);
        // 100D:A87E pushf
        Stack.Push16(FlagRegister16);
        // 100D:A87F sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_100D_A880_1A950_1822:
        CheckExternalEvents(cs1, 0xA880);
        // 100D:A880 call near 0xAE2F
        NearCall(cs1, 0xA883, unknown_100D_AE2F_1AEFF);
    label_100D_A883_1A953_1824:
        CheckExternalEvents(cs1, 0xA883);
        // 100D:A883 je short 0xA8AF
        if (ZeroFlag)
        {
            goto label_100D_A8AF_1A97F_2200;
        }
    label_100D_A885_1A955_1826:
        CheckExternalEvents(cs1, 0xA885);
        // 100D:A885 call near 0xAC14
        NearCall(cs1, 0xA888, unknown_100D_AC14_1ACE4);
    label_100D_A888_1A958_1867:
        CheckExternalEvents(cs1, 0xA888);
        // 100D:A888 mov AL,0x0B
        AL = (byte)0x0B;
        // 100D:A88A call near 0xABE9
        NearCall(cs1, 0xA88D, unknown_100D_ABE9_1ACB9);
    label_100D_A88D_1A95D_1885:
        CheckExternalEvents(cs1, 0xA88D);
        // 100D:A88D mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:A890 call far dword ptr DS:[0x3991]
        ushort targetSegment_1887 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_1887 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_1887 == cs3 && targetOffset_1887 == 0x0106)
        {
            FarCall(cs1, 0xA894, cs3, unknown_5642_0106_56526);
            goto label_100D_A894_1A964_2071;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_1887:X4}:{targetOffset_1887:X4} at 100D:A890");
    label_100D_A894_1A964_2071:
        CheckExternalEvents(cs1, 0xA894);
        // 100D:A894 push word ptr DS:[0xCE7A]
        Stack.Push16(UInt16[DS, (ushort)0xCE7A]);
    label_100D_A898_1A968_2073:
        CheckExternalEvents(cs1, 0xA898);
        // 100D:A898 call near 0xA9E7
        NearCall(cs1, 0xA89B, unknown_100D_A9E7_1AAB7);
    label_100D_A89B_1A96B_2079:
        CheckExternalEvents(cs1, 0xA89B);
        // 100D:A89B je short 0xA898
        if (ZeroFlag)
        {
            goto label_100D_A898_1A968_2073;
        }
    label_100D_A89D_1A96D_2192:
        CheckExternalEvents(cs1, 0xA89D);
        // 100D:A89D mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:A8A0 pop BX
        BX = Stack.Pop16();
        // 100D:A8A1 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:A8A3 mov CX,0x0800
        CX = (ushort)0x0800;
        // 100D:A8A6 mul CX
        uint result_100D_A8A6_1A976 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)CX)));
        DX = unchecked((ushort)(result_100D_A8A6_1A976 >> 16));
        AX = unchecked((ushort)result_100D_A8A6_1A976);
        // 100D:A8A8 mov word ptr DS:[0x2882],DX
        UInt16[DS, (ushort)0x2882] = DX;
        // 100D:A8AC mov word ptr DS:[0x2884],AX
        UInt16[DS, (ushort)0x2884] = AX;
    label_100D_A8AF_1A97F_2200:
        CheckExternalEvents(cs1, 0xA8AF);
        // 100D:A8AF popf
        FlagRegister16 = Stack.Pop16();
    label_100D_A8B0_1A980_2202:
        CheckExternalEvents(cs1, 0xA8B0);
        // 100D:A8B0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A8B1_1A981(int loadOffset)
    {
    label_100D_A8B1_1A981_8415:
        CheckExternalEvents(cs1, 0xA8B1);
        // 100D:A8B1 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:A8B3 add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        // 100D:A8B5 cmp AL,0x39
        Alu8.Sub(AL, (byte)0x39);
        // 100D:A8B7 jbe short 0xA8BB
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_A8BB_1A98B_8420;
        }
    label_100D_A8B9_1A989_20734:
        CheckExternalEvents(cs1, 0xA8B9);
        // 100D:A8B9 add AL,7
        AL = Alu8.Add(AL, (byte)0x07);
    label_100D_A8BB_1A98B_8420:
        CheckExternalEvents(cs1, 0xA8BB);
        // 100D:A8BB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A8BC_1A98C(int loadOffset)
    {
    label_100D_A8BC_1A98C_8400:
        CheckExternalEvents(cs1, 0xA8BC);
        // 100D:A8BC mov DI,0x37DB
        DI = (ushort)0x37DB;
        // 100D:A8BF push DS
        Stack.Push16(DS);
        // 100D:A8C0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:A8C1 push AX
        Stack.Push16(AX);
        // 100D:A8C2 mov AL,BL
        AL = BL;
        // 100D:A8C4 add AL,0x41
        AL = Alu8.Add(AL, (byte)0x41);
        // 100D:A8C6 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8C7 inc DI
        DI = Alu16.Inc(DI);
        // 100D:A8C8 inc DI
        DI = Alu16.Inc(DI);
        // 100D:A8C9 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8CA pop BX
        BX = Stack.Pop16();
        // 100D:A8CB mov CL,4
        CL = (byte)0x04;
        // 100D:A8CD mov AL,BH
        AL = BH;
        // 100D:A8CF call near 0xA8B1
        NearCall(cs1, 0xA8D2, unknown_100D_A8B1_1A981);
    label_100D_A8D2_1A9A2_8422:
        CheckExternalEvents(cs1, 0xA8D2);
        // 100D:A8D2 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8D3 mov AL,BL
        AL = BL;
        // 100D:A8D5 shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 100D:A8D7 call near 0xA8B1
        NearCall(cs1, 0xA8DA, unknown_100D_A8B1_1A981);
    label_100D_A8DA_1A9AA_8427:
        CheckExternalEvents(cs1, 0xA8DA);
        // 100D:A8DA stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8DB mov AL,BL
        AL = BL;
        // 100D:A8DD call near 0xA8B1
        NearCall(cs1, 0xA8E0, unknown_100D_A8B1_1A981);
    label_100D_A8E0_1A9B0_8431:
        CheckExternalEvents(cs1, 0xA8E0);
        // 100D:A8E0 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8E1 mov AL,0x4F
        AL = (byte)0x4F;
        // 100D:A8E3 cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:A8E8 jg short 0xA8FA
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_A8FA_1A9CA_8444;
        }
    label_100D_A8EA_1A9BA_8436:
        CheckExternalEvents(cs1, 0xA8EA);
        // 100D:A8EA cmp byte ptr DS:[6],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x0006], (byte)0x80);
        // 100D:A8EF jne short 0xA8FA
        if (!ZeroFlag)
        {
            goto label_100D_A8FA_1A9CA_8444;
        }
    label_100D_A8F1_1A9C1_8439:
        CheckExternalEvents(cs1, 0xA8F1);
        // 100D:A8F1 cmp byte ptr DS:[4],1
        Alu8.Sub(UInt8[DS, (ushort)0x0004], (byte)0x01);
        // 100D:A8F6 je short 0xA8FA
        if (ZeroFlag)
        {
            goto label_100D_A8FA_1A9CA_8444;
        }
    label_100D_A8F8_1A9C8_8442:
        CheckExternalEvents(cs1, 0xA8F8);
        // 100D:A8F8 mov AL,0x49
        AL = (byte)0x49;
    label_100D_A8FA_1A9CA_8444:
        CheckExternalEvents(cs1, 0xA8FA);
        // 100D:A8FA stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:A8FB mov AL,0x20
        AL = (byte)0x20;
        // 100D:A8FD shr BH,CL
        BH = Alu8.Shr(BH, unchecked((int)CL));
        // 100D:A8FF or BH,byte ptr DS:[0x47E0]
        BH = Alu8.Or(BH, UInt8[DS, (ushort)0x47E0]);
        // 100D:A903 je short 0xA909
        if (ZeroFlag)
        {
            goto label_100D_A909_1A9D9_8449;
        }
    label_100D_A905_1A9D5_23218:
        CheckExternalEvents(cs1, 0xA905);
        // 100D:A905 mov AL,BH
        AL = BH;
        // 100D:A907 add AL,0x41
        AL = Alu8.Add(AL, (byte)0x41);
    label_100D_A909_1A9D9_8449:
        CheckExternalEvents(cs1, 0xA909);
        // 100D:A909 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        return unknown_100D_A90A_1A9DA(0x0000);
    }

    public virtual Action unknown_100D_A90B_1A9DB(int loadOffset)
    {
    label_100D_A90B_1A9DB_8475:
        CheckExternalEvents(cs1, 0xA90B);
        // 100D:A90B mov DX,0x37DA
        DX = (ushort)0x37DA;
        // 100D:A90E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:A910 mov word ptr DS:[0x3811],AX
        UInt16[DS, (ushort)0x3811] = AX;
        // 100D:A913 mov word ptr DS:[0x3817],AX
        UInt16[DS, (ushort)0x3817] = AX;
        // 100D:A916 mov word ptr DS:[0x381F],AX
        UInt16[DS, (ushort)0x381F] = AX;
        // 100D:A919 mov byte ptr DS:[0x3823],AL
        UInt8[DS, (ushort)0x3823] = AL;
        // 100D:A91C call near 0xF1FB
        NearCall(cs1, 0xA91F, unknown_100D_F1FB_1F2CB);
    label_100D_A91F_1A9EF_8483:
        CheckExternalEvents(cs1, 0xA91F);
        // 100D:A91F jb short 0xA90A
        if (CarryFlag)
        {
            return unknown_100D_A90A_1A9DA(0x0000);
        }
    label_100D_A921_1A9F1_8485:
        CheckExternalEvents(cs1, 0xA921);
        // 100D:A921 mov word ptr DS:[0x3821],BX
        UInt16[DS, (ushort)0x3821] = BX;
        // 100D:A925 sub CX,1
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:A928 sbb BP,0
        BP = Alu16.Sbb(BP, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A92B mov word ptr DS:[0xDBC4],CX
        UInt16[DS, (ushort)0xDBC4] = CX;
        // 100D:A92F mov word ptr DS:[0xDBC6],BP
        UInt16[DS, (ushort)0xDBC6] = BP;
        // 100D:A933 mov word ptr DS:[0xDBC0],AX
        UInt16[DS, (ushort)0xDBC0] = AX;
        // 100D:A936 mov word ptr DS:[0xDBC2],DX
        UInt16[DS, (ushort)0xDBC2] = DX;
        // 100D:A93A mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:A93D les DX,word ptr DS:[SI]
        ushort lxsOffset_100D_A93D_1AA0D = SI;
        ushort lxsValue_100D_A93D_1AA0D = UInt16[DS, lxsOffset_100D_A93D_1AA0D];
        ushort lxsSegment_100D_A93D_1AA0D = UInt16[DS, (ushort)(lxsOffset_100D_A93D_1AA0D + (ushort)0x0002)];
        DX = unchecked((ushort)lxsValue_100D_A93D_1AA0D);
        ES = unchecked((ushort)lxsSegment_100D_A93D_1AA0D);
        return unknown_100D_A93F_1AA0F(0x0000);
    }

    public virtual Action unknown_100D_A93F_1AA0F(int loadOffset)
    {
    label_100D_A93F_1AA0F_8495:
        CheckExternalEvents(cs1, 0xA93F);
        // 100D:A93F push DX
        Stack.Push16(DX);
        // 100D:A940 mov DX,word ptr DS:[0xDBC0]
        DX = UInt16[DS, (ushort)0xDBC0];
        // 100D:A944 mov CX,word ptr DS:[0xDBC2]
        CX = UInt16[DS, (ushort)0xDBC2];
        // 100D:A948 mov AX,0x4200
        AX = (ushort)0x4200;
        // 100D:A94B int 0x21
        InterruptCall(cs1, 0xA94D, unchecked((byte)((byte)0x21)));
    label_100D_A94D_1AA1D_8500:
        CheckExternalEvents(cs1, 0xA94D);
        // 100D:A94D pop DX
        DX = Stack.Pop16();
        // 100D:A94E push SI
        Stack.Push16(SI);
        // 100D:A94F push DS
        Stack.Push16(DS);
        // 100D:A950 mov CX,0x2000
        CX = (ushort)0x2000;
        // 100D:A953 mov AX,word ptr DS:[0xDBC4]
        AX = UInt16[DS, (ushort)0xDBC4];
        // 100D:A956 sub word ptr DS:[0xDBC4],CX
        UInt16[DS, (ushort)0xDBC4] = Alu16.Sub(UInt16[DS, (ushort)0xDBC4], CX);
        // 100D:A95A sbb word ptr DS:[0xDBC6],0
        UInt16[DS, (ushort)0xDBC6] = Alu16.Sbb(UInt16[DS, (ushort)0xDBC6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A95F jae short 0xA964
        if (!CarryFlag)
        {
            goto label_100D_A964_1AA34_8509;
        }
    label_100D_A961_1AA31_10137:
        CheckExternalEvents(cs1, 0xA961);
        // 100D:A961 mov CX,AX
        CX = AX;
        // 100D:A963 inc CX
        CX = Alu16.Inc(CX);
    label_100D_A964_1AA34_8509:
        CheckExternalEvents(cs1, 0xA964);
        // 100D:A964 push ES
        Stack.Push16(ES);
        // 100D:A965 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:A966 mov AH,0x3F
        AH = (byte)0x3F;
        // 100D:A968 int 0x21
        InterruptCall(cs1, 0xA96A, unchecked((byte)((byte)0x21)));
    label_100D_A96A_1AA3A_8514:
        CheckExternalEvents(cs1, 0xA96A);
        // 100D:A96A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:A96B pop SI
        SI = Stack.Pop16();
        // 100D:A96C mov word ptr DS:[SI+4],AX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = AX;
        // 100D:A96F jb short 0xA9B8
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A96F");
        }
    label_100D_A971_1AA41_8519:
        CheckExternalEvents(cs1, 0xA971);
        // 100D:A971 add word ptr DS:[0xDBC0],AX
        UInt16[DS, (ushort)0xDBC0] = Alu16.Add(UInt16[DS, (ushort)0xDBC0], AX);
        // 100D:A975 adc word ptr DS:[0xDBC2],0
        UInt16[DS, (ushort)0xDBC2] = Alu16.Adc(UInt16[DS, (ushort)0xDBC2], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A97A mov byte ptr DS:[0x376A],0xFF
        UInt8[DS, (ushort)0x376A] = (byte)0xFF;
        // 100D:A97F mov byte ptr DS:[SI+6],1
        UInt8[DS, (ushort)(SI + (sbyte)6)] = (byte)0x01;
        // 100D:A983 mov BL,byte ptr DS:[0x3823]
        BL = UInt8[DS, (ushort)0x3823];
        // 100D:A987 cmp BL,0x3F
        Alu8.Sub(BL, (byte)0x3F);
        // 100D:A98A jae short 0xA992
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:A98A");
        }
    label_100D_A98C_1AA5C_8527:
        CheckExternalEvents(cs1, 0xA98C);
        // 100D:A98C inc byte ptr DS:[0x3823]
        UInt8[DS, (ushort)0x3823] = Alu8.Inc(UInt8[DS, (ushort)0x3823]);
        // 100D:A990 inc BL
        BL = Alu8.Inc(BL);
        // 100D:A992 mov byte ptr DS:[SI+7],BL
        UInt8[DS, (ushort)(SI + (sbyte)7)] = BL;
        // 100D:A995 cmp word ptr DS:[0xDBC6],0
        Alu16.Sub(UInt16[DS, (ushort)0xDBC6], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:A99A clc
        CarryFlag = false;
        // 100D:A99B jns short 0xA9B8
        if (!SignFlag)
        {
            return unknown_100D_A9B8_1AA88(0x0000);
        }
    label_100D_A99D_1AA6D_10140:
        CheckExternalEvents(cs1, 0xA99D);
        // 100D:A99D or byte ptr DS:[SI+7],0x80
        UInt8[DS, (ushort)(SI + (sbyte)7)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)7)], (byte)0x80);
        return unknown_100D_A9A1_1AA71(0x0000);
    }

    public virtual Action unknown_100D_A9A1_1AA71(int loadOffset)
    {
    label_100D_A9A1_1AA71_1846:
        CheckExternalEvents(cs1, 0xA9A1);
        // 100D:A9A1 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:A9A3 xchg BX,word ptr DS:[0x3821]
        ushort xchgOffset_100D_A9A3_1AA73 = (ushort)0x3821;
        ushort temp_100D_A9A3_1AA73 = BX;
        BX = UInt16[DS, xchgOffset_100D_A9A3_1AA73];
        UInt16[DS, xchgOffset_100D_A9A3_1AA73] = unchecked((ushort)temp_100D_A9A3_1AA73);
        // 100D:A9A7 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:A9A9 je short 0xA9B7
        if (ZeroFlag)
        {
            goto label_100D_A9B7_1AA87_1851;
        }
    label_100D_A9AB_1AA7B_9316:
        CheckExternalEvents(cs1, 0xA9AB);
        // 100D:A9AB cmp BX,word ptr DS:[0xDBBA]
        Alu16.Sub(BX, UInt16[DS, (ushort)0xDBBA]);
        // 100D:A9AF je short 0xA9B7
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:A9AF");
        }
    label_100D_A9B7_1AA87_1851:
        CheckExternalEvents(cs1, 0xA9B7);
        // 100D:A9B7 clc
        CarryFlag = false;
        return unknown_100D_A9B8_1AA88(0x0000);
    }

    public virtual Action unknown_100D_A9B9_1AA89(int loadOffset)
    {
    label_100D_A9B9_1AA89_8553:
        CheckExternalEvents(cs1, 0xA9B9);
        // 100D:A9B9 call near 0xABA3
        NearCall(cs1, 0xA9BC, unknown_100D_ABA3_1AC73);
    label_100D_A9BC_1AA8C_8555:
        CheckExternalEvents(cs1, 0xA9BC);
        // 100D:A9BC je short 0xA9E6
        if (ZeroFlag)
        {
            goto label_100D_A9E6_1AAB6_8580;
        }
    label_100D_A9BE_1AA8E_8557:
        CheckExternalEvents(cs1, 0xA9BE);
        // 100D:A9BE mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:A9C1 cmp byte ptr DS:[0x3817],0
        Alu8.Sub(UInt8[DS, (ushort)0x3817], (byte)0x00);
        // 100D:A9C6 je short 0xA9D2
        if (ZeroFlag)
        {
            goto label_100D_A9D2_1AAA2_8566;
        }
    label_100D_A9C8_1AA98_8561:
        CheckExternalEvents(cs1, 0xA9C8);
        // 100D:A9C8 cmp byte ptr DS:[0x381F],0
        Alu8.Sub(UInt8[DS, (ushort)0x381F], (byte)0x00);
        // 100D:A9CD jne short 0xA9E6
        if (!ZeroFlag)
        {
            goto label_100D_A9E6_1AAB6_8580;
        }
    label_100D_A9CF_1AA9F_8564:
        CheckExternalEvents(cs1, 0xA9CF);
        // 100D:A9CF mov SI,0x3819
        SI = (ushort)0x3819;
    label_100D_A9D2_1AAA2_8566:
        CheckExternalEvents(cs1, 0xA9D2);
        // 100D:A9D2 mov BX,word ptr DS:[0x3821]
        BX = UInt16[DS, (ushort)0x3821];
        // 100D:A9D6 les DX,word ptr DS:[SI]
        ushort lxsOffset_100D_A9D6_1AAA6 = SI;
        ushort lxsValue_100D_A9D6_1AAA6 = UInt16[DS, lxsOffset_100D_A9D6_1AAA6];
        ushort lxsSegment_100D_A9D6_1AAA6 = UInt16[DS, (ushort)(lxsOffset_100D_A9D6_1AAA6 + (ushort)0x0002)];
        DX = unchecked((ushort)lxsValue_100D_A9D6_1AAA6);
        ES = unchecked((ushort)lxsSegment_100D_A9D6_1AAA6);
        // 100D:A9D8 add DX,6
        DX = Alu16.Add(DX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:A9DB push SI
        Stack.Push16(SI);
        // 100D:A9DC call near 0xA93F
        NearCall(cs1, 0xA9DF, unknown_100D_A93F_1AA0F);
    label_100D_A9DF_1AAAF_8572:
        CheckExternalEvents(cs1, 0xA9DF);
        // 100D:A9DF pop SI
        SI = Stack.Pop16();
        // 100D:A9E0 jb short 0xA9E6
        if (CarryFlag)
        {
            goto label_100D_A9E6_1AAB6_8580;
        }
    label_100D_A9E2_1AAB2_8575:
        CheckExternalEvents(cs1, 0xA9E2);
        // 100D:A9E2 call far dword ptr DS:[0x39A1]
        ushort targetSegment_8575 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x39A1 + (ushort)0x0002)]));
        ushort targetOffset_8575 = unchecked((ushort)(UInt16[DS, (ushort)0x39A1]));
        if (targetSegment_8575 == cs3 && targetOffset_8575 == 0x0112)
        {
            FarCall(cs1, 0xA9E6, cs3, unknown_5642_0112_56532);
            goto label_100D_A9E6_1AAB6_8580;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8575:X4}:{targetOffset_8575:X4} at 100D:A9E2");
    label_100D_A9E6_1AAB6_8580:
        CheckExternalEvents(cs1, 0xA9E6);
        // 100D:A9E6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A9E7_1AAB7(int loadOffset)
    {
    label_100D_A9E7_1AAB7_2074:
        CheckExternalEvents(cs1, 0xA9E7);
        // 100D:A9E7 cmp byte ptr DS:[0x3817],3
        Alu8.Sub(UInt8[DS, (ushort)0x3817], (byte)0x03);
        // 100D:A9EC je short 0xA9F3
        if (ZeroFlag)
        {
            goto label_100D_A9F3_1AAC3_2077;
        }
    label_100D_A9EE_1AABE_2190:
        CheckExternalEvents(cs1, 0xA9EE);
        // 100D:A9EE cmp byte ptr DS:[0x381F],3
        Alu8.Sub(UInt8[DS, (ushort)0x381F], (byte)0x03);
    label_100D_A9F3_1AAC3_2077:
        CheckExternalEvents(cs1, 0xA9F3);
        // 100D:A9F3 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A9F4_1AAC4(int loadOffset)
    {
    label_100D_A9F4_1AAC4_5685:
        CheckExternalEvents(cs1, 0xA9F4);
        // 100D:A9F4 mov SI,word ptr DS:[0x3824]
        SI = UInt16[DS, (ushort)0x3824];
        // 100D:A9F8 les DI,word ptr DS:[SI]
        ushort lxsOffset_100D_A9F8_1AAC8 = SI;
        ushort lxsValue_100D_A9F8_1AAC8 = UInt16[DS, lxsOffset_100D_A9F8_1AAC8];
        ushort lxsSegment_100D_A9F8_1AAC8 = UInt16[DS, (ushort)(lxsOffset_100D_A9F8_1AAC8 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_A9F8_1AAC8);
        ES = unchecked((ushort)lxsSegment_100D_A9F8_1AAC8);
        // 100D:A9FA add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:A9FD call near 0xAA70
        NearCall(cs1, 0xAA00, unknown_100D_AA70_1AB40);
    label_100D_AA00_1AAD0_5690:
        CheckExternalEvents(cs1, 0xAA00);
        // 100D:AA00 call far dword ptr DS:[0x39A1]
        ushort targetSegment_5690 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x39A1 + (ushort)0x0002)]));
        ushort targetOffset_5690 = unchecked((ushort)(UInt16[DS, (ushort)0x39A1]));
        if (targetSegment_5690 == cs3 && targetOffset_5690 == 0x0112)
        {
            FarCall(cs1, 0xAA04, cs3, unknown_5642_0112_56532);
            goto label_100D_AA04_1AAD4_5692;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5690:X4}:{targetOffset_5690:X4} at 100D:AA00");
    label_100D_AA04_1AAD4_5692:
        CheckExternalEvents(cs1, 0xAA04);
        // 100D:AA04 mov AX,0x3811
        AX = (ushort)0x3811;
        // 100D:AA07 xor AX,0x3819
        AX = Alu16.Xor(AX, (ushort)0x3819);
        // 100D:AA0A xor word ptr DS:[0x3824],AX
        UInt16[DS, (ushort)0x3824] = Alu16.Xor(UInt16[DS, (ushort)0x3824], AX);
        return unknown_100D_AA0E_1AADE(0x0000);
    }

    public virtual Action unknown_100D_AA0F_1AADF(int loadOffset)
    {
    label_100D_AA0F_1AADF_4280:
        CheckExternalEvents(cs1, 0xAA0F);
        // 100D:AA0F mov AX,word ptr DS:[0xDC1C]
        AX = UInt16[DS, (ushort)0xDC1C];
        // 100D:AA12 inc AX
        AX = Alu16.Inc(AX);
        // 100D:AA13 je short 0xAA0E
        if (ZeroFlag)
        {
            return unknown_100D_AA0E_1AADE(0x0000);
        }
    label_100D_AA15_1AAE5_5515:
        CheckExternalEvents(cs1, 0xAA15);
        // 100D:AA15 mov byte ptr DS:[0x376A],0xFF
        UInt8[DS, (ushort)0x376A] = (byte)0xFF;
        // 100D:AA1A call near 0xAC14
        NearCall(cs1, 0xAA1D, unknown_100D_AC14_1ACE4);
    label_100D_AA1D_1AAED_5518:
        CheckExternalEvents(cs1, 0xAA1D);
        // 100D:AA1D xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:AA1F mov word ptr DS:[0x3811],AX
        UInt16[DS, (ushort)0x3811] = AX;
        // 100D:AA22 mov word ptr DS:[0x3817],AX
        UInt16[DS, (ushort)0x3817] = AX;
        // 100D:AA25 mov word ptr DS:[0x381F],AX
        UInt16[DS, (ushort)0x381F] = AX;
        // 100D:AA28 mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:AA2B les DI,word ptr DS:[SI]
        ushort lxsOffset_100D_AA2B_1AAFB = SI;
        ushort lxsValue_100D_AA2B_1AAFB = UInt16[DS, lxsOffset_100D_AA2B_1AAFB];
        ushort lxsSegment_100D_AA2B_1AAFB = UInt16[DS, (ushort)(lxsOffset_100D_AA2B_1AAFB + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_AA2B_1AAFB);
        ES = unchecked((ushort)lxsSegment_100D_AA2B_1AAFB);
        // 100D:AA2D call near 0xAA70
        NearCall(cs1, 0xAA30, unknown_100D_AA70_1AB40);
    label_100D_AA30_1AB00_5544:
        CheckExternalEvents(cs1, 0xAA30);
        // 100D:AA30 sub word ptr DS:[0x3815],0x0020
        UInt16[DS, (ushort)0x3815] = Alu16.Sub(UInt16[DS, (ushort)0x3815], unchecked((ushort)unchecked((short)(sbyte)32)));
        // 100D:AA35 mov CX,word ptr DS:[0x3815]
        CX = UInt16[DS, (ushort)0x3815];
        // 100D:AA39 mov word ptr DS:[0x381D],CX
        UInt16[DS, (ushort)0x381D] = CX;
        // 100D:AA3D add CX,6
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:AA40 mov SI,0x001A
        SI = (ushort)0x001A;
        // 100D:AA43 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:AA45 rep movs byte ptr ES:[DI],byte ptr ES:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[ES, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:AA48 les DI,word ptr DS:[0x3819]
        ushort lxsOffset_100D_AA48_1AB18 = (ushort)0x3819;
        ushort lxsValue_100D_AA48_1AB18 = UInt16[DS, lxsOffset_100D_AA48_1AB18];
        ushort lxsSegment_100D_AA48_1AB18 = UInt16[DS, (ushort)(lxsOffset_100D_AA48_1AB18 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_AA48_1AB18);
        ES = unchecked((ushort)lxsSegment_100D_AA48_1AB18);
        // 100D:AA4C mov CX,word ptr DS:[0x3815]
        CX = UInt16[DS, (ushort)0x3815];
        // 100D:AA50 push DS
        Stack.Push16(DS);
        // 100D:AA51 lds SI,word ptr DS:[0x3811]
        ushort lxsOffset_100D_AA51_1AB21 = (ushort)0x3811;
        ushort lxsValue_100D_AA51_1AB21 = UInt16[DS, lxsOffset_100D_AA51_1AB21];
        ushort lxsSegment_100D_AA51_1AB21 = UInt16[DS, (ushort)(lxsOffset_100D_AA51_1AB21 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_AA51_1AB21);
        DS = unchecked((ushort)lxsSegment_100D_AA51_1AB21);
        // 100D:AA55 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:AA56 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:AA57 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:AA58 mov AL,0x80
        AL = (byte)0x80;
        // 100D:AA5A rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:AA5C pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:AA5D mov SI,0x3819
        SI = (ushort)0x3819;
        // 100D:AA60 mov word ptr DS:[0x3824],SI
        UInt16[DS, (ushort)0x3824] = SI;
        // 100D:AA64 call far dword ptr DS:[0x3991]
        ushort targetSegment_5564 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_5564 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_5564 == cs3 && targetOffset_5564 == 0x0106)
        {
            FarCall(cs1, 0xAA68, cs3, unknown_5642_0106_56526);
            goto label_100D_AA68_1AB38_5568;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5564:X4}:{targetOffset_5564:X4} at 100D:AA64");
    label_100D_AA68_1AB38_5568:
        CheckExternalEvents(cs1, 0xAA68);
        // 100D:AA68 mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:AA6B call far dword ptr DS:[0x39A1]
        ushort targetSegment_5570 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x39A1 + (ushort)0x0002)]));
        ushort targetOffset_5570 = unchecked((ushort)(UInt16[DS, (ushort)0x39A1]));
        if (targetSegment_5570 == cs3 && targetOffset_5570 == 0x0112)
        {
            FarCall(cs1, 0xAA6F, cs3, unknown_5642_0112_56532);
            goto label_100D_AA6F_1AB3F_5592;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_5570:X4}:{targetOffset_5570:X4} at 100D:AA6B");
    label_100D_AA6F_1AB3F_5592:
        CheckExternalEvents(cs1, 0xAA6F);
        // 100D:AA6F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AA70_1AB40(int loadOffset)
    {
    label_100D_AA70_1AB40_5526:
        CheckExternalEvents(cs1, 0xAA70);
        // 100D:AA70 push SI
        Stack.Push16(SI);
        // 100D:AA71 push DS
        Stack.Push16(DS);
        // 100D:AA72 mov SI,word ptr DS:[0xDC1C]
        SI = UInt16[DS, (ushort)0xDC1C];
        // 100D:AA76 mov DS,word ptr DS:[0xDBDE]
        DS = UInt16[DS, (ushort)0xDBDE];
        // 100D:AA7A lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:AA7B sub AX,4
        AX = Alu16.Sub(AX, (ushort)0x0004);
        // 100D:AA7E mov CX,AX
        CX = AX;
        // 100D:AA80 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 100D:AA82 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:AA84 adc CL,CL
        CL = Alu8.Adc(CL, CL);
        // 100D:AA86 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:AA88 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:AA89 pop SI
        SI = Stack.Pop16();
        // 100D:AA8A mov word ptr DS:[SI+4],AX
        UInt16[DS, (ushort)(SI + (sbyte)4)] = AX;
        // 100D:AA8D mov byte ptr DS:[SI+6],1
        UInt8[DS, (ushort)(SI + (sbyte)6)] = (byte)0x01;
        // 100D:AA91 mov byte ptr DS:[SI+7],0x41
        UInt8[DS, (ushort)(SI + (sbyte)7)] = (byte)0x41;
        // 100D:AA95 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AA96_1AB66(int loadOffset)
    {
    label_100D_AA96_1AB66_14361:
        CheckExternalEvents(cs1, 0xAA96);
        // 100D:AA96 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:AA98 cmp byte ptr DS:[0x4774],AH
        Alu8.Sub(UInt8[DS, (ushort)0x4774], AH);
        // 100D:AA9C je short 0xAAA7
        if (ZeroFlag)
        {
            goto label_100D_AAA7_1AB77_14365;
        }
    label_100D_AA9E_1AB6E_28345:
        CheckExternalEvents(cs1, 0xAA9E);
        // 100D:AA9E cmp byte ptr DS:[0x002A],0x48
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x48);
        // 100D:AAA3 jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAA5_1AB75_34607:
        CheckExternalEvents(cs1, 0xAAA5);
        // 100D:AAA5 jmp short 0xAB12
        goto label_100D_AB12_1ABE2_34609;
    label_100D_AAA7_1AB77_14365:
        CheckExternalEvents(cs1, 0xAAA7);
        // 100D:AAA7 mov AL,0x0D
        AL = (byte)0x0D;
        // 100D:AAA9 cmp byte ptr DS:[0x46D9],AH
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], AH);
        // 100D:AAAD jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAAF_1AB7F_14369:
        CheckExternalEvents(cs1, 0xAAAF);
        // 100D:AAAF mov AL,1
        AL = (byte)0x01;
        // 100D:AAB1 cmp byte ptr DS:[0xDD03],AH
        Alu8.Sub(UInt8[DS, (ushort)0xDD03], AH);
        // 100D:AAB5 jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAB7_1AB87_14373:
        CheckExternalEvents(cs1, 0xAAB7);
        // 100D:AAB7 inc AX
        AX = Alu16.Inc(AX);
        // 100D:AAB8 cmp byte ptr DS:[0x00FB],AH
        Alu8.Sub(UInt8[DS, (ushort)0x00FB], AH);
        // 100D:AABC js short 0xAB14
        if (SignFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AABE_1AB8E_14377:
        CheckExternalEvents(cs1, 0xAABE);
        // 100D:AABE inc AX
        AX = Alu16.Inc(AX);
        // 100D:AABF cmp byte ptr DS:[0x00C6],AH
        Alu8.Sub(UInt8[DS, (ushort)0x00C6], AH);
        // 100D:AAC3 jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAC5_1AB95_14381:
        CheckExternalEvents(cs1, 0xAAC5);
        // 100D:AAC5 inc AX
        AX = Alu16.Inc(AX);
        // 100D:AAC6 cmp byte ptr DS:[0x00EA],AH
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], AH);
        // 100D:AACA jg short 0xAB14
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AACC_1AB9C_14385:
        CheckExternalEvents(cs1, 0xAACC);
        // 100D:AACC inc AX
        AX = Alu16.Inc(AX);
        // 100D:AACD mov DX,word ptr DS:[4]
        DX = UInt16[DS, (ushort)0x0004];
        // 100D:AAD1 mov BX,word ptr DS:[6]
        BX = UInt16[DS, (ushort)0x0006];
        // 100D:AAD5 cmp BL,0x80
        Alu8.Sub(BL, (byte)0x80);
        // 100D:AAD8 jne short 0xAADF
        if (!ZeroFlag)
        {
            goto label_100D_AADF_1ABAF_20655;
        }
    label_100D_AADA_1ABAA_14391:
        CheckExternalEvents(cs1, 0xAADA);
        // 100D:AADA cmp DL,1
        Alu8.Sub(DL, (byte)0x01);
        // 100D:AADD jne short 0xAAEF
        if (!ZeroFlag)
        {
            goto label_100D_AAEF_1ABBF_14394;
        }
    label_100D_AADF_1ABAF_20655:
        CheckExternalEvents(cs1, 0xAADF);
        // 100D:AADF mov BL,byte ptr DS:[0x11C9]
        BL = UInt8[DS, (ushort)0x11C9];
        // 100D:AAE3 and BL,3
        BL = Alu8.And(BL, (byte)0x03);
        // 100D:AAE6 je short 0xAB14
        if (ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAE8_1ABB8_21524:
        CheckExternalEvents(cs1, 0xAAE8);
        // 100D:AAE8 inc AX
        AX = Alu16.Inc(AX);
        // 100D:AAE9 dec BL
        BL = Alu8.Dec(BL);
        // 100D:AAEB je short 0xAB14
        if (ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AAED_1ABBD_35140:
        CheckExternalEvents(cs1, 0xAAED);
        // 100D:AAED inc AX
        AX = Alu16.Inc(AX);
        // 100D:AAEE ret near
        return NearRet((ushort)0x0000);
    label_100D_AAEF_1ABBF_14394:
        CheckExternalEvents(cs1, 0xAAEF);
        // 100D:AAEF cmp DH,0x20
        Alu8.Sub(DH, (byte)0x20);
        // 100D:AAF2 jae short 0xAB08
        if (!CarryFlag)
        {
            goto label_100D_AB08_1ABD8_14397;
        }
    label_100D_AAF4_1ABC4_22911:
        CheckExternalEvents(cs1, 0xAAF4);
        // 100D:AAF4 mov AL,9
        AL = (byte)0x09;
        // 100D:AAF6 cmp DH,7
        Alu8.Sub(DH, (byte)0x07);
        // 100D:AAF9 sbb AL,0
        AL = Alu8.Sbb(AL, (byte)0x00);
        // 100D:AAFB cmp byte ptr DS:[0x002A],0x48
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x48);
        // 100D:AB00 jb short 0xAB14
        if (CarryFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AB02_1ABD2_34881:
        CheckExternalEvents(cs1, 0xAB02);
        // 100D:AB02 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 100D:AB04 jb short 0xAB14
        if (CarryFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AB06_1ABD6_34884:
        CheckExternalEvents(cs1, 0xAB06);
        // 100D:AB06 jmp short 0xAB12
        goto label_100D_AB12_1ABE2_34609;
    label_100D_AB08_1ABD8_14397:
        CheckExternalEvents(cs1, 0xAB08);
        // 100D:AB08 mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:AB0A jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AB0C_1ABDC_14400:
        CheckExternalEvents(cs1, 0xAB0C);
        // 100D:AB0C dec AX
        AX = Alu16.Dec(AX);
        // 100D:AB0D cmp DL,3
        Alu8.Sub(DL, (byte)0x03);
        // 100D:AB10 jne short 0xAB14
        if (!ZeroFlag)
        {
            goto label_100D_AB14_1ABE4_14404;
        }
    label_100D_AB12_1ABE2_34609:
        CheckExternalEvents(cs1, 0xAB12);
        // 100D:AB12 mov AL,0x0A
        AL = (byte)0x0A;
    label_100D_AB14_1ABE4_14404:
        CheckExternalEvents(cs1, 0xAB14);
        // 100D:AB14 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AB15_1ABE5(int loadOffset)
    {
    label_100D_AB15_1ABE5_10347:
        CheckExternalEvents(cs1, 0xAB15);
        // 100D:AB15 call near 0xABCC
        NearCall(cs1, 0xAB18, unknown_100D_ABCC_1AC9C);
    label_100D_AB18_1ABE8_10349:
        CheckExternalEvents(cs1, 0xAB18);
        // 100D:AB18 jne short 0xAB44
        if (!ZeroFlag)
        {
            return unknown_100D_AB44_1AC14(0x0000);
        }
    label_100D_AB1A_1ABEA_10351:
        CheckExternalEvents(cs1, 0xAB1A);
        // 100D:AB1A call near 0xAE2F
        NearCall(cs1, 0xAB1D, unknown_100D_AE2F_1AEFF);
    label_100D_AB1D_1ABED_10353:
        CheckExternalEvents(cs1, 0xAB1D);
        // 100D:AB1D je short 0xAB44
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AB1D");
        }
    label_100D_AB1F_1ABEF_10355:
        CheckExternalEvents(cs1, 0xAB1F);
        // 100D:AB1F push ES
        Stack.Push16(ES);
        // 100D:AB20 call near 0xE270
        NearCall(cs1, 0xAB23, unknown_100D_E270_1E340);
    label_100D_AB23_1ABF3_10358:
        CheckExternalEvents(cs1, 0xAB23);
        // 100D:AB23 cmp AL,byte ptr DS:[0x376A]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x376A]);
        // 100D:AB27 je short 0xAB35
        if (ZeroFlag)
        {
            goto label_100D_AB35_1AC05_11392;
        }
    label_100D_AB29_1ABF9_10361:
        CheckExternalEvents(cs1, 0xAB29);
        // 100D:AB29 call near 0xAC14
        NearCall(cs1, 0xAB2C, unknown_100D_AC14_1ACE4);
    label_100D_AB2C_1ABFC_10363:
        CheckExternalEvents(cs1, 0xAB2C);
        // 100D:AB2C or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:AB2E je short 0xAB40
        if (ZeroFlag)
        {
            goto label_100D_AB40_1AC10_10393;
        }
    label_100D_AB30_1AC00_10366:
        CheckExternalEvents(cs1, 0xAB30);
        // 100D:AB30 call near 0xABE9
        NearCall(cs1, 0xAB33, unknown_100D_ABE9_1ACB9);
    label_100D_AB33_1AC03_10368:
        CheckExternalEvents(cs1, 0xAB33);
        // 100D:AB33 jmp short 0xAB39
        goto label_100D_AB39_1AC09_10370;
    label_100D_AB35_1AC05_11392:
        CheckExternalEvents(cs1, 0xAB35);
        // 100D:AB35 les DI,word ptr DS:[0x3811]
        ushort lxsOffset_100D_AB35_1AC05 = (ushort)0x3811;
        ushort lxsValue_100D_AB35_1AC05 = UInt16[DS, lxsOffset_100D_AB35_1AC05];
        ushort lxsSegment_100D_AB35_1AC05 = UInt16[DS, (ushort)(lxsOffset_100D_AB35_1AC05 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_AB35_1AC05);
        ES = unchecked((ushort)lxsSegment_100D_AB35_1AC05);
    label_100D_AB39_1AC09_10370:
        CheckExternalEvents(cs1, 0xAB39);
        // 100D:AB39 mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:AB3C call far dword ptr DS:[0x3991]
        ushort targetSegment_10372 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_10372 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_10372 == cs3 && targetOffset_10372 == 0x0106)
        {
            FarCall(cs1, 0xAB40, cs3, unknown_5642_0106_56526);
            goto label_100D_AB40_1AC10_10393;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_10372:X4}:{targetOffset_10372:X4} at 100D:AB3C");
    label_100D_AB40_1AC10_10393:
        CheckExternalEvents(cs1, 0xAB40);
        // 100D:AB40 call near 0xE283
        NearCall(cs1, 0xAB43, unknown_100D_E283_1E353);
    label_100D_AB43_1AC13_10395:
        CheckExternalEvents(cs1, 0xAB43);
        // 100D:AB43 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        return unknown_100D_AB44_1AC14(0x0000);
    }

    public virtual Action unknown_100D_AB45_1AC15(int loadOffset)
    {
    label_100D_AB45_1AC15_21405:
        CheckExternalEvents(cs1, 0xAB45);
        // 100D:AB45 call near 0xAE2F
        NearCall(cs1, 0xAB48, unknown_100D_AE2F_1AEFF);
    label_100D_AB48_1AC18_21407:
        CheckExternalEvents(cs1, 0xAB48);
        // 100D:AB48 je short 0xAB44
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AB48");
        }
    label_100D_AB4A_1AC1A_21409:
        CheckExternalEvents(cs1, 0xAB4A);
        // 100D:AB4A push AX
        Stack.Push16(AX);
        // 100D:AB4B call near 0xADE0
        NearCall(cs1, 0xAB4E, unknown_100D_ADE0_1AEB0);
    label_100D_AB4E_1AC1E_21412:
        CheckExternalEvents(cs1, 0xAB4E);
        // 100D:AB4E pop AX
        AX = Stack.Pop16();
        return unknown_100D_AB4F_1AC1F(0x0000);
    }

    public virtual Action unknown_100D_AB4F_1AC1F(int loadOffset)
    {
    label_100D_AB4F_1AC1F_12287:
        CheckExternalEvents(cs1, 0xAB4F);
        // 100D:AB4F mov byte ptr DS:[0x47E0],0
        UInt8[DS, (ushort)0x47E0] = (byte)0x00;
        // 100D:AB54 mov BX,0x0019
        BX = (ushort)0x0019;
        // 100D:AB57 call near 0xA8BC
        NearCall(cs1, 0xAB5A, unknown_100D_A8BC_1A98C);
    label_100D_AB5A_1AC2A_12291:
        CheckExternalEvents(cs1, 0xAB5A);
        // 100D:AB5A mov byte ptr DS:[0x37E2],0x49
        UInt8[DS, (ushort)0x37E2] = (byte)0x49;
        // 100D:AB5F call near 0xABCC
        NearCall(cs1, 0xAB62, unknown_100D_ABCC_1AC9C);
    label_100D_AB62_1AC32_12294:
        CheckExternalEvents(cs1, 0xAB62);
        // 100D:AB62 jne short 0xAB44
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AB62");
        }
    label_100D_AB64_1AC34_12296:
        CheckExternalEvents(cs1, 0xAB64);
        // 100D:AB64 call near 0xAE2F
        NearCall(cs1, 0xAB67, unknown_100D_AE2F_1AEFF);
    label_100D_AB67_1AC37_12298:
        CheckExternalEvents(cs1, 0xAB67);
        // 100D:AB67 je short 0xAB44
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:AB67");
        }
    label_100D_AB69_1AC39_12300:
        CheckExternalEvents(cs1, 0xAB69);
        // 100D:AB69 push ES
        Stack.Push16(ES);
        // 100D:AB6A call near 0xE270
        NearCall(cs1, 0xAB6D, unknown_100D_E270_1E340);
    label_100D_AB6D_1AC3D_12303:
        CheckExternalEvents(cs1, 0xAB6D);
        // 100D:AB6D call near 0xAC14
        NearCall(cs1, 0xAB70, unknown_100D_AC14_1ACE4);
    label_100D_AB70_1AC40_12305:
        CheckExternalEvents(cs1, 0xAB70);
        // 100D:AB70 call near 0xA90B
        NearCall(cs1, 0xAB73, unknown_100D_A90B_1A9DB);
    label_100D_AB73_1AC43_12307:
        CheckExternalEvents(cs1, 0xAB73);
        // 100D:AB73 jb short 0xAB8D
        if (CarryFlag)
        {
            goto label_100D_AB8D_1AC5D_12319;
        }
    label_100D_AB75_1AC45_12309:
        CheckExternalEvents(cs1, 0xAB75);
        // 100D:AB75 add word ptr DS:[0x3811],0x001A
        UInt16[DS, (ushort)0x3811] = Alu16.Add(UInt16[DS, (ushort)0x3811], unchecked((ushort)unchecked((short)(sbyte)26)));
        // 100D:AB7A call near 0xA9B9
        NearCall(cs1, 0xAB7D, unknown_100D_A9B9_1AA89);
    label_100D_AB7D_1AC4D_12312:
        CheckExternalEvents(cs1, 0xAB7D);
        // 100D:AB7D mov SI,0xAB92
        SI = (ushort)0xAB92;
        // 100D:AB80 mov BP,1
        BP = (ushort)0x0001;
        // 100D:AB83 call near 0xDA25
        NearCall(cs1, 0xAB86, unknown_100D_DA25_1DAF5);
    label_100D_AB86_1AC56_12316:
        CheckExternalEvents(cs1, 0xAB86);
        // 100D:AB86 mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:AB89 call far dword ptr DS:[0x3991]
        ushort targetSegment_12318 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_12318 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_12318 == cs3 && targetOffset_12318 == 0x0106)
        {
            FarCall(cs1, 0xAB8D, cs3, unknown_5642_0106_56526);
            goto label_100D_AB8D_1AC5D_12319;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_12318:X4}:{targetOffset_12318:X4} at 100D:AB89");
    label_100D_AB8D_1AC5D_12319:
        CheckExternalEvents(cs1, 0xAB8D);
        // 100D:AB8D call near 0xE283
        NearCall(cs1, 0xAB90, unknown_100D_E283_1E353);
    label_100D_AB90_1AC60_12321:
        CheckExternalEvents(cs1, 0xAB90);
        // 100D:AB90 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:AB91 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AB92_1AC62(int loadOffset)
    {
    label_100D_AB92_1AC62_12334:
        CheckExternalEvents(cs1, 0xAB92);
        // 100D:AB92 call near 0xA9B9
        NearCall(cs1, 0xAB95, unknown_100D_A9B9_1AA89);
    label_100D_AB95_1AC65_12336:
        CheckExternalEvents(cs1, 0xAB95);
        // 100D:AB95 call near 0xABA3
        NearCall(cs1, 0xAB98, unknown_100D_ABA3_1AC73);
    label_100D_AB98_1AC68_12338:
        CheckExternalEvents(cs1, 0xAB98);
        // 100D:AB98 jne short 0xAB44
        if (!ZeroFlag)
        {
            return unknown_100D_AB44_1AC14(0x0000);
        }
    label_100D_AB9A_1AC6A_12341:
        CheckExternalEvents(cs1, 0xAB9A);
        // 100D:AB9A call near 0xADED
        NearCall(cs1, 0xAB9D, unknown_100D_ADED_1AEBD);
    label_100D_AB9D_1AC6D_12343:
        CheckExternalEvents(cs1, 0xAB9D);
        // 100D:AB9D mov SI,0xAB92
        SI = (ushort)0xAB92;
        // 100D:ABA0 jmp near 0xDA5F
        return unknown_100D_DA5F_1DB2F(0x0000);
    }

    public virtual Action unknown_100D_ABA3_1AC73(int loadOffset)
    {
    label_100D_ABA3_1AC73_5132:
        CheckExternalEvents(cs1, 0xABA3);
        // 100D:ABA3 cmp word ptr DS:[0x3821],0
        Alu16.Sub(UInt16[DS, (ushort)0x3821], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:ABA8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ABA9_1AC79(int loadOffset)
    {
    label_100D_ABA9_1AC79_21464:
        CheckExternalEvents(cs1, 0xABA9);
        // 100D:ABA9 call near 0xAE2F
        NearCall(cs1, 0xABAC, unknown_100D_AE2F_1AEFF);
    label_100D_ABAC_1AC7C_21466:
        CheckExternalEvents(cs1, 0xABAC);
        // 100D:ABAC je short 0xAB44
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ABAC");
        }
    label_100D_ABAE_1AC7E_21468:
        CheckExternalEvents(cs1, 0xABAE);
        // 100D:ABAE mov BX,word ptr DS:[0xCE7A]
        BX = UInt16[DS, (ushort)0xCE7A];
    label_100D_ABB2_1AC82_21470:
        CheckExternalEvents(cs1, 0xABB2);
        // 100D:ABB2 push BX
        Stack.Push16(BX);
        // 100D:ABB3 call near 0xAB92
        NearCall(cs1, 0xABB6, unknown_100D_AB92_1AC62);
    label_100D_ABB6_1AC86_21472:
        CheckExternalEvents(cs1, 0xABB6);
        // 100D:ABB6 call near 0xABA3
        NearCall(cs1, 0xABB9, unknown_100D_ABA3_1AC73);
    label_100D_ABB9_1AC89_21474:
        CheckExternalEvents(cs1, 0xABB9);
        // 100D:ABB9 pop BX
        BX = Stack.Pop16();
        // 100D:ABBA je short 0xABC6
        if (ZeroFlag)
        {
            return unknown_100D_ABC6_1AC96(0x0000);
        }
    label_100D_ABBC_1AC8C_25734:
        CheckExternalEvents(cs1, 0xABBC);
        // 100D:ABBC mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:ABBF sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:ABC1 cmp AX,0x03E8
        Alu16.Sub(AX, (ushort)0x03E8);
        // 100D:ABC4 jb short 0xABB2
        if (CarryFlag)
        {
            goto label_100D_ABB2_1AC82_21470;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:ABC4");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_ABC6_1AC96(int loadOffset)
    {
    label_100D_ABC6_1AC96_9311:
        CheckExternalEvents(cs1, 0xABC6);
        // 100D:ABC6 mov byte ptr DS:[0xDC2B],0
        UInt8[DS, (ushort)0xDC2B] = (byte)0x00;
        // 100D:ABCB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ABCC_1AC9C(int loadOffset)
    {
    label_100D_ABCC_1AC9C_3573:
        CheckExternalEvents(cs1, 0xABCC);
        // 100D:ABCC cmp byte ptr DS:[0xDC2B],0
        Alu8.Sub(UInt8[DS, (ushort)0xDC2B], (byte)0x00);
        // 100D:ABD1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ABD5_1ACA5(int loadOffset)
    {
        goto label_100D_ABD5_1ACA5_19898;

    label_100D_ABD2_1ACA2_37963:
        CheckExternalEvents(cs1, 0xABD2);
        // 100D:ABD2 call near 0xA7C2
        NearCall(cs1, 0xABD5, unknown_100D_A7C2_1A892);
    label_100D_ABD5_1ACA5_19898:
        CheckExternalEvents(cs1, 0xABD5);
        // 100D:ABD5 call near 0xABCC
        NearCall(cs1, 0xABD8, unknown_100D_ABCC_1AC9C);
    label_100D_ABD8_1ACA8_19900:
        CheckExternalEvents(cs1, 0xABD8);
        // 100D:ABD8 jne short 0xABD2
        if (!ZeroFlag)
        {
            goto label_100D_ABD2_1ACA2_37963;
        }
    label_100D_ABDA_1ACAA_19902:
        CheckExternalEvents(cs1, 0xABDA);
        // 100D:ABDA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ABDB_1ACAB(int loadOffset)
    {
    label_100D_ABDB_1ACAB_10990:
        CheckExternalEvents(cs1, 0xABDB);
        // 100D:ABDB call near 0xAEC6
        NearCall(cs1, 0xABDE, unknown_100D_AEC6_1AF96);
    label_100D_ABDE_1ACAE_10992:
        CheckExternalEvents(cs1, 0xABDE);
        // 100D:ABDE jb short 0xAC13
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ABDE");
        }
    label_100D_ABE0_1ACB0_10994:
        CheckExternalEvents(cs1, 0xABE0);
        // 100D:ABE0 call near 0xAE2F
        NearCall(cs1, 0xABE3, unknown_100D_AE2F_1AEFF);
    label_100D_ABE3_1ACB3_10996:
        CheckExternalEvents(cs1, 0xABE3);
        // 100D:ABE3 stc
        CarryFlag = true;
        // 100D:ABE4 je short 0xAC13
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:ABE4");
        }
    label_100D_ABE6_1ACB6_10999:
        CheckExternalEvents(cs1, 0xABE6);
        // 100D:ABE6 call near 0xA9A1
        NearCall(cs1, 0xABE9, unknown_100D_A9A1_1AA71);
        return unknown_100D_ABE9_1ACB9(0x0000);
    }

    public virtual Action unknown_100D_ABE9_1ACB9(int loadOffset)
    {
    label_100D_ABE9_1ACB9_1870:
        CheckExternalEvents(cs1, 0xABE9);
        // 100D:ABE9 mov word ptr DS:[0x3811],0
        UInt16[DS, (ushort)0x3811] = (ushort)0x0000;
        // 100D:ABEF les DI,word ptr DS:[0x3811]
        ushort lxsOffset_100D_ABEF_1ACBF = (ushort)0x3811;
        ushort lxsValue_100D_ABEF_1ACBF = UInt16[DS, lxsOffset_100D_ABEF_1ACBF];
        ushort lxsSegment_100D_ABEF_1ACBF = UInt16[DS, (ushort)(lxsOffset_100D_ABEF_1ACBF + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_ABEF_1ACBF);
        ES = unchecked((ushort)lxsSegment_100D_ABEF_1ACBF);
        // 100D:ABF3 add word ptr DS:[0x3811],0x001A
        UInt16[DS, (ushort)0x3811] = Alu16.Add(UInt16[DS, (ushort)0x3811], unchecked((ushort)unchecked((short)(sbyte)26)));
        // 100D:ABF8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:ABFA mov SI,AX
        SI = AX;
        // 100D:ABFC add SI,0x00AE
        SI = Alu16.Add(SI, (ushort)0x00AE);
        // 100D:AC00 mov byte ptr DS:[0x376A],AL
        UInt8[DS, (ushort)0x376A] = AL;
        // 100D:AC03 call near 0xF0B9
        NearCall(cs1, 0xAC06, unknown_100D_F0B9_1F189);
    label_100D_AC06_1ACD6_1880:
        CheckExternalEvents(cs1, 0xAC06);
        // 100D:AC06 sub CX,0x001A
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)26)));
        // 100D:AC09 mov word ptr DS:[0x3815],CX
        UInt16[DS, (ushort)0x3815] = CX;
        // 100D:AC0D mov word ptr DS:[0x3817],0x8101
        UInt16[DS, (ushort)0x3817] = (ushort)0x8101;
        // 100D:AC13 ret near
        return NearRet((ushort)0x0000);
    }
}
