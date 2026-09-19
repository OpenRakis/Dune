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
    public virtual Action unknown_100D_8AC3_18B93(int loadOffset)
    {
    label_100D_8AC3_18B93_23214:
        CheckExternalEvents(cs1, 0x8AC3);
        // 100D:8AC3 mov byte ptr DS:[0x47E0],AL
        UInt8[DS, (ushort)0x47E0] = AL;
        // 100D:8AC6 and byte ptr DS:[0x47DE],0xEF
        UInt8[DS, (ushort)0x47DE] = Alu8.And(UInt8[DS, (ushort)0x47DE], (byte)0xEF);
        // 100D:8ACB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8ACC_18B9C(int loadOffset)
    {
    label_100D_8ACC_18B9C_24822:
        CheckExternalEvents(cs1, 0x8ACC);
        // 100D:8ACC test byte ptr SS:[0x47DE],0x10
        Alu8.And(UInt8[SS, (ushort)0x47DE], (byte)0x10);
        // 100D:8AD2 je short 0x8AC2
        if (ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x8AC2);
        }
    label_100D_8AD4_18BA4_24825:
        CheckExternalEvents(cs1, 0x8AD4);
        // 100D:8AD4 push BX
        Stack.Push16(BX);
        // 100D:8AD5 lea BP,BP
        BP = unchecked((ushort)(BP + (short)0));
        // 100D:8AD9 cmp BP,0x00CF
        Alu16.Sub(BP, (ushort)0x00CF);
        // 100D:8ADD je short 0x8AFF
        if (ZeroFlag)
        {
            goto label_100D_8AFF_18BCF_33275;
        }
    label_100D_8ADF_18BAF_24830:
        CheckExternalEvents(cs1, 0x8ADF);
        // 100D:8ADF cmp BP,0x0055
        Alu16.Sub(BP, (ushort)0x0055);
        // 100D:8AE3 je short 0x8B07
        if (ZeroFlag)
        {
            goto label_100D_8B07_18BD7_40310;
        }
    label_100D_8AE5_18BB5_24833:
        CheckExternalEvents(cs1, 0x8AE5);
        // 100D:8AE5 cmp BP,0x0061
        Alu16.Sub(BP, (ushort)0x0061);
        // 100D:8AE9 je short 0x8B07
        if (ZeroFlag)
        {
            goto label_100D_8B07_18BD7_40310;
        }
    label_100D_8AEB_18BBB_24836:
        CheckExternalEvents(cs1, 0x8AEB);
        // 100D:8AEB cmp BP,0x0044
        Alu16.Sub(BP, (ushort)0x0044);
        // 100D:8AEF jne short 0x8AC1
        if (!ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x8AC1);
        }
    label_100D_8AF1_18BC1_35565:
        CheckExternalEvents(cs1, 0x8AF1);
        // 100D:8AF1 mov BH,byte ptr SS:[0x47DE]
        BH = UInt8[SS, (ushort)0x47DE];
        // 100D:8AF6 and BH,0x0F
        BH = Alu8.And(BH, (byte)0x0F);
        // 100D:8AF9 cmp BH,1
        Alu8.Sub(BH, (byte)0x01);
        // 100D:8AFC jne short 0x8AC1
        if (!ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x8AC1);
        }
    label_100D_8AFE_18BCE_35570:
        CheckExternalEvents(cs1, 0x8AFE);
        // 100D:8AFE dec AX
        AX = Alu16.Dec(AX);
    label_100D_8AFF_18BCF_33275:
        CheckExternalEvents(cs1, 0x8AFF);
        // 100D:8AFF cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:8B01 jbe short 0x8ABE
        if (CarryFlag || ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
    label_100D_8B03_18BD3_36747:
        CheckExternalEvents(cs1, 0x8B03);
        // 100D:8B03 mov AL,8
        AL = (byte)0x08;
        // 100D:8B05 jmp short 0x8ABE
        return unknown_100D_8ABE_18B8E(0x0000);
    label_100D_8B07_18BD7_40310:
        CheckExternalEvents(cs1, 0x8B07);
        // 100D:8B07 dec AX
        AX = Alu16.Dec(AX);
        // 100D:8B08 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:8B0A jbe short 0x8ABE
        if (CarryFlag || ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
    label_100D_8B0C_18BDC_40315:
        CheckExternalEvents(cs1, 0x8B0C);
        VerifySpeculativeEntryOrFail(cs1, 0x8B0C, [(byte)0xB0, (byte)0x04]);
        // 100D:8B0C mov AL,4
        AL = (byte)0x04;
        VerifySpeculativeEntryOrFail(cs1, 0x8B0E, [(byte)0xEB, (byte)0xAE]);
        // 100D:8B0E jmp short 0x8ABE
        return unknown_100D_8ABE_18B8E(0x0000);
    }

    public virtual Action unknown_100D_8B11_18BE1(int loadOffset)
    {
    label_100D_8B11_18BE1_11831:
        CheckExternalEvents(cs1, 0x8B11);
        // 100D:8B11 push SI
        Stack.Push16(SI);
        // 100D:8B12 call near 0x8C8A
        NearCall(cs1, 0x8B15, unknown_100D_8C8A_18D5A);
    label_100D_8B15_18BE5_11841:
        CheckExternalEvents(cs1, 0x8B15);
        // 100D:8B15 pop SI
        SI = Stack.Pop16();
        // 100D:8B16 call near 0x8CCD
        NearCall(cs1, 0x8B19, unknown_100D_8CCD_18D9D);
    label_100D_8B19_18BE9_11993:
        CheckExternalEvents(cs1, 0x8B19);
        // 100D:8B19 jb short 0x8B10
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8B19");
        }
    label_100D_8B1B_18BEB_11995:
        CheckExternalEvents(cs1, 0x8B1B);
        // 100D:8B1B call near 0x8F28
        NearCall(cs1, 0x8B1E, unknown_100D_8F28_18FF8);
    label_100D_8B1E_18BEE_12042:
        CheckExternalEvents(cs1, 0x8B1E);
        // 100D:8B1E call near 0x8DF0
        NearCall(cs1, 0x8B21, unknown_100D_8DF0_18EC0);
    label_100D_8B21_18BF1_12065:
        CheckExternalEvents(cs1, 0x8B21);
        // 100D:8B21 mov DX,word ptr DS:[0x4791]
        DX = UInt16[DS, (ushort)0x4791];
        // 100D:8B25 mov BX,word ptr DS:[0x4793]
        BX = UInt16[DS, (ushort)0x4793];
        // 100D:8B29 call near 0xD04E
        NearCall(cs1, 0x8B2C, unknown_100D_D04E_1D11E);
    label_100D_8B2C_18BFC_12075:
        CheckExternalEvents(cs1, 0x8B2C);
        // 100D:8B2C mov BP,0xA9D0
        BP = (ushort)0xA9D0;
        // 100D:8B2F mov word ptr DS:[0x479A],0x000A
        UInt16[DS, (ushort)0x479A] = (ushort)0x000A;
        // 100D:8B35 mov AL,byte ptr DS:[0x4799]
        AL = UInt8[DS, (ushort)0x4799];
        // 100D:8B38 and AL,0x0C
        AL = Alu8.And(AL, (byte)0x0C);
        // 100D:8B3A je short 0x8B8B
        if (ZeroFlag)
        {
            goto label_100D_8B8B_18C5B_12103;
        }
    label_100D_8B3C_18C0C_12081:
        CheckExternalEvents(cs1, 0x8B3C);
        // 100D:8B3C cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:8B3E jae short 0x8B66
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8B3E");
        }
    label_100D_8B66_18C36_12084:
        CheckExternalEvents(cs1, 0x8B66);
        // 100D:8B66 pushf
        Stack.Push16(FlagRegister16);
        // 100D:8B67 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8B6A mov AH,0x0A
        AH = (byte)0x0A;
        // 100D:8B6C mul AH
        ushort result_100D_8B6C_18C3C = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_8B6C_18C3C >> 8));
        AL = unchecked((byte)result_100D_8B6C_18C3C);
        // 100D:8B6E mov BX,word ptr DS:[0x478D]
        BX = UInt16[DS, (ushort)0x478D];
        // 100D:8B72 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 100D:8B74 jae short 0x8B78
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8B74");
        }
    label_100D_8B78_18C48_12092:
        CheckExternalEvents(cs1, 0x8B78);
        // 100D:8B78 mov word ptr DS:[0x478D],AX
        UInt16[DS, (ushort)0x478D] = AX;
    label_100D_8B7B_18C4B_12094:
        CheckExternalEvents(cs1, 0x8B7B);
        // 100D:8B7B popf
        FlagRegister16 = Stack.Pop16();
    label_100D_8B7C_18C4C_12096:
        CheckExternalEvents(cs1, 0x8B7C);
        // 100D:8B7C jne short 0x8B80
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8B7C");
        }
    label_100D_8B7E_18C4E_12098:
        CheckExternalEvents(cs1, 0x8B7E);
        // 100D:8B7E shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 100D:8B80 mov DX,word ptr DS:[0xD82C]
        DX = UInt16[DS, (ushort)0xD82C];
        // 100D:8B84 add BX,word ptr DS:[0xD82E]
        BX = Alu16.Add(BX, UInt16[DS, (ushort)0xD82E]);
        // 100D:8B88 call near 0xD04E
        NearCall(cs1, 0x8B8B, unknown_100D_D04E_1D11E);
    label_100D_8B8B_18C5B_12103:
        CheckExternalEvents(cs1, 0x8B8B);
        // 100D:8B8B mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8B8E add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_8B91_18C61_12106:
        CheckExternalEvents(cs1, 0x8B91);
        // 100D:8B91 push DX
        Stack.Push16(DX);
        // 100D:8B92 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8B95 add BP,2
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:8B98 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8B9B mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:8B9E add BP,4
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:8BA1 jcxz short 0x8C0C
        if (CX == (ushort)0x0000)
        {
            goto label_100D_8C0C_18CDC_24891;
        }
    label_100D_8BA3_18C73_12113:
        CheckExternalEvents(cs1, 0x8BA3);
        // 100D:8BA3 test byte ptr DS:[0x4799],2
        Alu8.And(UInt8[DS, (ushort)0x4799], (byte)0x02);
        // 100D:8BA8 je short 0x8BD1
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8BA8");
        }
    label_100D_8BD1_18CA1_12116:
        CheckExternalEvents(cs1, 0x8BD1);
        // 100D:8BD1 pop AX
        AX = Stack.Pop16();
        // 100D:8BD2 push AX
        Stack.Push16(AX);
        // 100D:8BD3 cmp AX,1
        Alu16.Sub(AX, (ushort)0x0001);
        // 100D:8BD6 je short 0x8BDF
        if (ZeroFlag)
        {
            goto label_100D_8BDF_18CAF_12258;
        }
    label_100D_8BD8_18CA8_12121:
        CheckExternalEvents(cs1, 0x8BD8);
        // 100D:8BD8 test byte ptr DS:[0x4799],1
        Alu8.And(UInt8[DS, (ushort)0x4799], (byte)0x01);
        // 100D:8BDD jne short 0x8BE5
        if (!ZeroFlag)
        {
            goto label_100D_8BE5_18CB5_12124;
        }
    label_100D_8BDF_18CAF_12258:
        CheckExternalEvents(cs1, 0x8BDF);
        // 100D:8BDF mov DX,6
        DX = (ushort)0x0006;
        // 100D:8BE2 mov BX,0
        BX = (ushort)0x0000;
    label_100D_8BE5_18CB5_12124:
        CheckExternalEvents(cs1, 0x8BE5);
        // 100D:8BE5 mov word ptr DS:[0x479C],BX
        UInt16[DS, (ushort)0x479C] = BX;
    label_100D_8BE9_18CB9_12126:
        CheckExternalEvents(cs1, 0x8BE9);
        // 100D:8BE9 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:8BEA or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8BEC js short 0x8C26
        if (SignFlag)
        {
            goto label_100D_8C26_18CF6_12227;
        }
    label_100D_8BEE_18CBE_12129:
        CheckExternalEvents(cs1, 0x8BEE);
        // 100D:8BEE cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:8BF0 je short 0x8C19
        if (ZeroFlag)
        {
            goto label_100D_8C19_18CE9_12221;
        }
    label_100D_8BF2_18CC2_12132:
        CheckExternalEvents(cs1, 0x8BF2);
        // 100D:8BF2 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:8BF4 je short 0x8C19
        if (ZeroFlag)
        {
            goto label_100D_8C19_18CE9_12221;
        }
    label_100D_8BF6_18CC6_12135:
        CheckExternalEvents(cs1, 0x8BF6);
        // 100D:8BF6 cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:8BF8 je short 0x8C0F
        if (ZeroFlag)
        {
            goto label_100D_8C0F_18CDF_27462;
        }
    label_100D_8BFA_18CCA_12138:
        CheckExternalEvents(cs1, 0x8BFA);
        // 100D:8BFA cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:8BFC je short 0x8C14
        if (ZeroFlag)
        {
            goto label_100D_8C14_18CE4_31998;
        }
    label_100D_8BFE_18CCE_12141:
        CheckExternalEvents(cs1, 0x8BFE);
        // 100D:8BFE cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:8C00 jne short 0x8C41
        if (!ZeroFlag)
        {
            goto label_100D_8C41_18D11_12144;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8C00");
        }
    label_100D_8C0C_18CDC_24891:
        CheckExternalEvents(cs1, 0x8C0C);
        // 100D:8C0C jmp short 0x8C47
        goto label_100D_8C47_18D17_12242;
    label_100D_8C0F_18CDF_27462:
        CheckExternalEvents(cs1, 0x8C0F);
        // 100D:8C0F call near 0xD075
        NearCall(cs1, 0x8C12, unknown_100D_D075_1D145);
    label_100D_8C12_18CE2_27464:
        CheckExternalEvents(cs1, 0x8C12);
        // 100D:8C12 jmp short 0x8BE9
        goto label_100D_8BE9_18CB9_12126;
    label_100D_8C14_18CE4_31998:
        CheckExternalEvents(cs1, 0x8C14);
        // 100D:8C14 call near 0xD068
        NearCall(cs1, 0x8C17, unknown_100D_D068_1D138);
    label_100D_8C17_18CE7_32000:
        CheckExternalEvents(cs1, 0x8C17);
        // 100D:8C17 jmp short 0x8BE9
        goto label_100D_8BE9_18CB9_12126;
    label_100D_8C19_18CE9_12221:
        CheckExternalEvents(cs1, 0x8C19);
        // 100D:8C19 cmp byte ptr DS:[SI],0x20
        Alu8.Sub(UInt8[DS, SI], (byte)0x20);
        // 100D:8C1C je short 0x8C23
        if (ZeroFlag)
        {
            goto label_100D_8C23_18CF3_12261;
        }
    label_100D_8C1E_18CEE_12224:
        CheckExternalEvents(cs1, 0x8C1E);
        // 100D:8C1E cmp byte ptr DS:[SI],0x0D
        Alu8.Sub(UInt8[DS, SI], (byte)0x0D);
        // 100D:8C21 jne short 0x8C26
        if (!ZeroFlag)
        {
            goto label_100D_8C26_18CF6_12227;
        }
    label_100D_8C23_18CF3_12261:
        CheckExternalEvents(cs1, 0x8C23);
        // 100D:8C23 inc SI
        SI = Alu16.Inc(SI);
        // 100D:8C24 jmp short 0x8C19
        goto label_100D_8C19_18CE9_12221;
    label_100D_8C26_18CF6_12227:
        CheckExternalEvents(cs1, 0x8C26);
        // 100D:8C26 dec CX
        CX = Alu16.Dec(CX);
        // 100D:8C27 je short 0x8C47
        if (ZeroFlag)
        {
            goto label_100D_8C47_18D17_12242;
        }
    label_100D_8C29_18CF9_12230:
        CheckExternalEvents(cs1, 0x8C29);
        // 100D:8C29 push DX
        Stack.Push16(DX);
        // 100D:8C2A add DX,word ptr DS:[0xD82C]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0xD82C]);
        // 100D:8C2E cmp word ptr DS:[0x479C],0
        Alu16.Sub(UInt16[DS, (ushort)0x479C], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:8C33 je short 0x8C3A
        if (ZeroFlag)
        {
            goto label_100D_8C3A_18D0A_12238;
        }
    label_100D_8C35_18D05_12235:
        CheckExternalEvents(cs1, 0x8C35);
        // 100D:8C35 inc DX
        DX = Alu16.Inc(DX);
        // 100D:8C36 dec word ptr DS:[0x479C]
        UInt16[DS, (ushort)0x479C] = Alu16.Dec(UInt16[DS, (ushort)0x479C]);
    label_100D_8C3A_18D0A_12238:
        CheckExternalEvents(cs1, 0x8C3A);
        // 100D:8C3A mov word ptr DS:[0xD82C],DX
        UInt16[DS, (ushort)0xD82C] = DX;
        // 100D:8C3E pop DX
        DX = Stack.Pop16();
        // 100D:8C3F jmp short 0x8BE9
        goto label_100D_8BE9_18CB9_12126;
    label_100D_8C41_18D11_12144:
        CheckExternalEvents(cs1, 0x8C41);
        // 100D:8C41 call near word ptr DS:[0x2518]
        switch ((ushort)(UInt16[DS, (ushort)0x2518]))
        {
            case 0xD096:
                NearCall(cs1, 0x8C45, unknown_100D_D096_1D166);
                break;
            case 0xD0FF:
                NearCall(cs1, 0x8C45, unknown_100D_D0FF_1D1CF);
                break;
            case 0xD12F:
                NearCall(cs1, 0x8C45, unknown_100D_D12F_1D1FF);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x2518])):X4} at 100D:8C41");
        }
    label_100D_8C45_18D15_12218:
        CheckExternalEvents(cs1, 0x8C45);
        // 100D:8C45 jmp short 0x8BE9
        goto label_100D_8BE9_18CB9_12126;
    label_100D_8C47_18D17_12242:
        CheckExternalEvents(cs1, 0x8C47);
        // 100D:8C47 mov DX,word ptr DS:[0xD830]
        DX = UInt16[DS, (ushort)0xD830];
        // 100D:8C4B mov BX,word ptr DS:[0xD832]
        BX = UInt16[DS, (ushort)0xD832];
        // 100D:8C4F mov AX,word ptr DS:[0x479A]
        AX = UInt16[DS, (ushort)0x479A];
        // 100D:8C52 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:8C54 sub word ptr DS:[0x478D],AX
        UInt16[DS, (ushort)0x478D] = Alu16.Sub(UInt16[DS, (ushort)0x478D], AX);
        // 100D:8C58 jae short 0x8C60
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8C58");
        }
    label_100D_8C60_18D30_12249:
        CheckExternalEvents(cs1, 0x8C60);
        // 100D:8C60 call near 0xD04E
        NearCall(cs1, 0x8C63, unknown_100D_D04E_1D11E);
    label_100D_8C63_18D33_12251:
        CheckExternalEvents(cs1, 0x8C63);
        // 100D:8C63 pop DX
        DX = Stack.Pop16();
        // 100D:8C64 dec DX
        DX = Alu16.Dec(DX);
        // 100D:8C65 je short 0x8C6A
        if (ZeroFlag)
        {
            goto label_100D_8C6A_18D3A_12264;
        }
    label_100D_8C67_18D37_12255:
        CheckExternalEvents(cs1, 0x8C67);
        // 100D:8C67 jmp near 0x8B91
        goto label_100D_8B91_18C61_12106;
    label_100D_8C6A_18D3A_12264:
        CheckExternalEvents(cs1, 0x8C6A);
        // 100D:8C6A mov DX,word ptr DS:[0xD830]
        DX = UInt16[DS, (ushort)0xD830];
        // 100D:8C6E mov BX,word ptr DS:[0xD832]
        BX = UInt16[DS, (ushort)0xD832];
        // 100D:8C72 mov word ptr DS:[0x4791],DX
        UInt16[DS, (ushort)0x4791] = DX;
        // 100D:8C76 mov word ptr DS:[0x4793],BX
        UInt16[DS, (ushort)0x4793] = BX;
        // 100D:8C7A dec SI
        SI = Alu16.Dec(SI);
        // 100D:8C7B cmp word ptr DS:[0x479E],0x223C
        Alu16.Sub(UInt16[DS, (ushort)0x479E], (ushort)0x223C);
        // 100D:8C81 jne short 0x8C89
        if (!ZeroFlag)
        {
            goto label_100D_8C89_18D59_12272;
        }
    label_100D_8C83_18D53_31443:
        CheckExternalEvents(cs1, 0x8C83);
        // 100D:8C83 call near 0x9046
        NearCall(cs1, 0x8C86, unknown_100D_9046_19116);
    label_100D_8C86_18D56_31482:
        CheckExternalEvents(cs1, 0x8C86);
        // 100D:8C86 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    label_100D_8C89_18D59_12272:
        CheckExternalEvents(cs1, 0x8C89);
        // 100D:8C89 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8C8A_18D5A(int loadOffset)
    {
    entrydispatcher:
    label_100D_8C8A_18D5A_11834:
        CheckExternalEvents(cs1, 0x8C8A);
        // 100D:8C8A xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:8C8C xchg AX,word ptr DS:[0x479E]
        ushort xchgOffset_100D_8C8C_18D5C = (ushort)0x479E;
        ushort temp_100D_8C8C_18D5C = AX;
        AX = UInt16[DS, xchgOffset_100D_8C8C_18D5C];
        UInt16[DS, xchgOffset_100D_8C8C_18D5C] = unchecked((ushort)temp_100D_8C8C_18D5C);
        // 100D:8C90 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:8C93 jb short 0x8CCC
        if (CarryFlag)
        {
            goto label_100D_8CCC_18D9C_11839;
        }
    label_100D_8C95_18D65_25908:
        CheckExternalEvents(cs1, 0x8C95);
        // 100D:8C95 mov SI,0x1470
        SI = (ushort)0x1470;
        // 100D:8C98 cmp byte ptr DS:[0x28E7],0
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x00);
        // 100D:8C9D je short 0x8CB5
        if (ZeroFlag)
        {
            goto label_100D_8CB5_18D85_25947;
        }
    label_100D_8C9F_18D6F_25912:
        CheckExternalEvents(cs1, 0x8C9F);
        // 100D:8C9F mov BP,0x1BE2
        BP = (ushort)0x1BE2;
        // 100D:8CA2 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:8CA5 mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:8CA9 call far dword ptr DS:[0x391D]
        ushort targetSegment_25916 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x391D + (ushort)0x0002)]));
        ushort targetOffset_25916 = unchecked((ushort)(UInt16[DS, (ushort)0x391D]));
        if (targetSegment_25916 == cs2 && targetOffset_25916 == 0x014E)
        {
            FarCall(cs1, 0x8CAD, cs2, unknown_3358_014E_336CE);
            goto label_100D_8CAD_18D7D_25944;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_25916:X4}:{targetOffset_25916:X4} at 100D:8CA9");
    label_100D_8CAD_18D7D_25944:
        CheckExternalEvents(cs1, 0x8CAD);
        // 100D:8CAD mov SI,0x1BE2
        SI = (ushort)0x1BE2;
        // 100D:8CB0 mov word ptr DS:[SI+8],0
        UInt16[DS, (ushort)(SI + (sbyte)8)] = (ushort)0x0000;
    label_100D_8CB5_18D85_25947:
        CheckExternalEvents(cs1, 0x8CB5);
        // 100D:8CB5 call near 0xC446
        NearCall(cs1, 0x8CB8, unknown_100D_C446_1C516);
    label_100D_8CB8_18D88_25948:
        CheckExternalEvents(cs1, 0x8CB8);
        // 100D:8CB8 mov SI,word ptr DS:[0x47C8]
        SI = UInt16[DS, (ushort)0x47C8];
        // 100D:8CBC or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:8CBE je short 0x8CC9
        if (ZeroFlag)
        {
            goto label_100D_8CC9_18D99_25955;
        }
    label_100D_8CC0_18D90_25952:
        CheckExternalEvents(cs1, 0x8CC0);
        // 100D:8CC0 mov word ptr DS:[0x4540],0
        UInt16[DS, (ushort)0x4540] = (ushort)0x0000;
        // 100D:8CC6 call near 0x9BAC
        NearCall(cs1, 0x8CC9, unknown_100D_9BAC_19C7C);
    label_100D_8CC9_18D99_25955:
        CheckExternalEvents(cs1, 0x8CC9);
        // 100D:8CC9 call near 0xC4DD
        NearCall(cs1, 0x8CCC, unknown_100D_C4DD_1C5AD);
    label_100D_8CCC_18D9C_11839:
        CheckExternalEvents(cs1, 0x8CCC);
        // 100D:8CCC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8CCD_18D9D(int loadOffset)
    {
    label_100D_8CCD_18D9D_11844:
        CheckExternalEvents(cs1, 0x8CCD);
        // 100D:8CCD mov byte ptr DS:[0x4799],9
        UInt8[DS, (ushort)0x4799] = (byte)0x09;
        // 100D:8CD2 mov word ptr DS:[0xDBE4],0x00F0
        UInt16[DS, (ushort)0xDBE4] = (ushort)0x00F0;
        // 100D:8CD8 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:8CDD je short 0x8CFB
        if (ZeroFlag)
        {
            goto label_100D_8CFB_18DCB_11849;
        }
    label_100D_8CDF_18DAF_24375:
        CheckExternalEvents(cs1, 0x8CDF);
        // 100D:8CDF cmp word ptr DS:[0x46EF],0
        Alu16.Sub(UInt16[DS, (ushort)0x46EF], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:8CE4 jne short 0x8CF5
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8CE4");
        }
    label_100D_8CF5_18DC5_24378:
        CheckExternalEvents(cs1, 0x8CF5);
        // 100D:8CF5 mov BP,0x2244
        BP = (ushort)0x2244;
        // 100D:8CF8 jmp near 0x8DDB
        goto label_100D_8DDB_18EAB_11867;
    label_100D_8CFB_18DCB_11849:
        CheckExternalEvents(cs1, 0x8CFB);
        // 100D:8CFB cmp word ptr DS:[0x47C4],-1
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:8D00 jne short 0x8D1B
        if (!ZeroFlag)
        {
            goto label_100D_8D1B_18DEB_11852;
        }
    label_100D_8D02_18DD2_37777:
        CheckExternalEvents(cs1, 0x8D02);
        // 100D:8D02 mov AX,0x0048
        AX = (ushort)0x0048;
        // 100D:8D05 mov word ptr DS:[0x4784],AX
        UInt16[DS, (ushort)0x4784] = AX;
        // 100D:8D08 mov AL,0x10
        AL = (byte)0x10;
        // 100D:8D0A mov word ptr DS:[0x4786],AX
        UInt16[DS, (ushort)0x4786] = AX;
        // 100D:8D0D mov AL,8
        AL = (byte)0x08;
        // 100D:8D0F mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:8D12 mov word ptr DS:[0x478A],AX
        UInt16[DS, (ushort)0x478A] = AX;
        // 100D:8D15 mov BP,0x224C
        BP = (ushort)0x224C;
        // 100D:8D18 jmp near 0x8DDB
        goto label_100D_8DDB_18EAB_11867;
    label_100D_8D1B_18DEB_11852:
        CheckExternalEvents(cs1, 0x8D1B);
        // 100D:8D1B cmp byte ptr DS:[0x00C6],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C6], (byte)0x00);
        // 100D:8D20 je short 0x8D43
        if (ZeroFlag)
        {
            goto label_100D_8D43_18E13_11855;
        }
    label_100D_8D22_18DF2_16639:
        CheckExternalEvents(cs1, 0x8D22);
        // 100D:8D22 mov BP,0x2265
        BP = (ushort)0x2265;
        // 100D:8D25 mov AX,0x003C
        AX = (ushort)0x003C;
        // 100D:8D28 mov word ptr DS:[0x4784],AX
        UInt16[DS, (ushort)0x4784] = AX;
        // 100D:8D2B mov AL,0x32
        AL = (byte)0x32;
        // 100D:8D2D mov word ptr DS:[0x4786],AX
        UInt16[DS, (ushort)0x4786] = AX;
        // 100D:8D30 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:8D32 mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:8D35 mov word ptr DS:[0x478A],AX
        UInt16[DS, (ushort)0x478A] = AX;
        // 100D:8D38 mov byte ptr DS:[0xDBE4],0x64
        UInt8[DS, (ushort)0xDBE4] = (byte)0x64;
        // 100D:8D3D call near 0xD082
        NearCall(cs1, 0x8D40, unknown_100D_D082_1D152);
    label_100D_8D40_18E10_16654:
        CheckExternalEvents(cs1, 0x8D40);
        // 100D:8D40 jmp near 0x8DDB
        goto label_100D_8DDB_18EAB_11867;
    label_100D_8D43_18E13_11855:
        CheckExternalEvents(cs1, 0x8D43);
        // 100D:8D43 cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:8D48 je short 0x8D62
        if (ZeroFlag)
        {
            goto label_100D_8D62_18E32_25840;
        }
    label_100D_8D4A_18E1A_11858:
        CheckExternalEvents(cs1, 0x8D4A);
        // 100D:8D4A mov byte ptr DS:[0xDBE4],6
        UInt8[DS, (ushort)0xDBE4] = (byte)0x06;
        // 100D:8D4F mov BP,0x2275
        BP = (ushort)0x2275;
        // 100D:8D52 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:8D54 mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:8D57 mov word ptr DS:[0x478A],AX
        UInt16[DS, (ushort)0x478A] = AX;
        // 100D:8D5A mov word ptr DS:[0x4784],AX
        UInt16[DS, (ushort)0x4784] = AX;
        // 100D:8D5D mov word ptr DS:[0x4786],AX
        UInt16[DS, (ushort)0x4786] = AX;
        // 100D:8D60 jmp short 0x8DDB
        goto label_100D_8DDB_18EAB_11867;
    label_100D_8D62_18E32_25840:
        CheckExternalEvents(cs1, 0x8D62);
        // 100D:8D62 cmp byte ptr DS:[0x28E7],0
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x00);
        // 100D:8D67 jne short 0x8D8A
        if (!ZeroFlag)
        {
            goto label_100D_8D8A_18E5A_25843;
        }
    label_100D_8D69_18E39_31417:
        CheckExternalEvents(cs1, 0x8D69);
        // 100D:8D69 mov byte ptr DS:[0x4799],1
        UInt8[DS, (ushort)0x4799] = (byte)0x01;
        // 100D:8D6E mov byte ptr DS:[0xDBE4],0x0F
        UInt8[DS, (ushort)0xDBE4] = (byte)0x0F;
        // 100D:8D73 mov BP,0x223C
        BP = (ushort)0x223C;
        // 100D:8D76 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:8D78 mov word ptr DS:[0x478A],AX
        UInt16[DS, (ushort)0x478A] = AX;
        // 100D:8D7B inc AX
        AX = Alu16.Inc(AX);
        // 100D:8D7C mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:8D7F mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:8D82 mov word ptr DS:[0x4784],AX
        UInt16[DS, (ushort)0x4784] = AX;
        // 100D:8D85 mov word ptr DS:[0x4786],AX
        UInt16[DS, (ushort)0x4786] = AX;
        // 100D:8D88 jmp short 0x8DDB
        goto label_100D_8DDB_18EAB_11867;
    label_100D_8D8A_18E5A_25843:
        CheckExternalEvents(cs1, 0x8D8A);
        // 100D:8D8A mov BP,0x2224
        BP = (ushort)0x2224;
        // 100D:8D8D mov CX,3
        CX = (ushort)0x0003;
    label_100D_8D90_18E60_25846:
        CheckExternalEvents(cs1, 0x8D90);
        // 100D:8D90 mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:8D93 sub AX,word ptr DS:[0x4784]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4784]);
        // 100D:8D97 sub AX,word ptr DS:[0x4786]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4786]);
        // 100D:8D9B mov word ptr DS:[0x478F],AX
        UInt16[DS, (ushort)0x478F] = AX;
        // 100D:8D9E push SI
        Stack.Push16(SI);
        // 100D:8D9F push CX
        Stack.Push16(CX);
        // 100D:8DA0 call near 0x8E16
        NearCall(cs1, 0x8DA3, unknown_100D_8E16_18EE6);
    label_100D_8DA3_18E73_25853:
        CheckExternalEvents(cs1, 0x8DA3);
        // 100D:8DA3 pop CX
        CX = Stack.Pop16();
        // 100D:8DA4 pop SI
        SI = Stack.Pop16();
        // 100D:8DA5 mov AX,word ptr DS:[0xA9D0]
        AX = UInt16[DS, (ushort)0xA9D0];
        // 100D:8DA8 mov AH,0x0A
        AH = (byte)0x0A;
        // 100D:8DAA mul AH
        ushort result_100D_8DAA_18E7A = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_8DAA_18E7A >> 8));
        AL = unchecked((byte)result_100D_8DAA_18E7A);
        // 100D:8DAC add AX,word ptr DS:[0x4788]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x4788]);
        // 100D:8DB0 add AX,word ptr DS:[0x478A]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x478A]);
        // 100D:8DB4 cmp AX,word ptr SS:[BP+6]
        Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)6)]);
        // 100D:8DB7 jb short 0x8DCD
        if (CarryFlag)
        {
            goto label_100D_8DCD_18E9D_25867;
        }
    label_100D_8DB9_18E89_25863:
        CheckExternalEvents(cs1, 0x8DB9);
        // 100D:8DB9 add BP,8
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:8DBC loop 0x8D90
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_8D90_18E60_25846;
        }
    label_100D_8DBE_18E8E_27403:
        CheckExternalEvents(cs1, 0x8DBE);
        // 100D:8DBE sub BP,8
        BP = Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:8DC1 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:8DC3 mov word ptr DS:[0x4788],AX
        UInt16[DS, (ushort)0x4788] = AX;
        // 100D:8DC6 xchg AX,word ptr DS:[0x478A]
        ushort xchgOffset_100D_8DC6_18E96 = (ushort)0x478A;
        ushort temp_100D_8DC6_18E96 = AX;
        AX = UInt16[DS, xchgOffset_100D_8DC6_18E96];
        UInt16[DS, xchgOffset_100D_8DC6_18E96] = unchecked((ushort)temp_100D_8DC6_18E96);
        // 100D:8DCA or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:8DCC ret near
        return NearRet((ushort)0x0000);
    label_100D_8DCD_18E9D_25867:
        CheckExternalEvents(cs1, 0x8DCD);
        // 100D:8DCD dec CX
        CX = Alu16.Dec(CX);
        // 100D:8DCE je short 0x8DEE
        if (ZeroFlag)
        {
            goto label_100D_8DEE_18EBE_11991;
        }
    label_100D_8DD0_18EA0_25870:
        CheckExternalEvents(cs1, 0x8DD0);
        // 100D:8DD0 mov BX,1
        BX = (ushort)0x0001;
        // 100D:8DD3 call near 0xE3B7
        NearCall(cs1, 0x8DD6, unknown_100D_E3B7_1E487);
    label_100D_8DD6_18EA6_25873:
        CheckExternalEvents(cs1, 0x8DD6);
        // 100D:8DD6 je short 0x8DEE
        if (ZeroFlag)
        {
            goto label_100D_8DEE_18EBE_11991;
        }
    label_100D_8DD8_18EA8_25957:
        CheckExternalEvents(cs1, 0x8DD8);
        // 100D:8DD8 add BP,8
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
    label_100D_8DDB_18EAB_11867:
        CheckExternalEvents(cs1, 0x8DDB);
        // 100D:8DDB mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:8DDE sub AX,word ptr DS:[0x4784]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4784]);
        // 100D:8DE2 sub AX,word ptr DS:[0x4786]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4786]);
        // 100D:8DE6 mov word ptr DS:[0x478F],AX
        UInt16[DS, (ushort)0x478F] = AX;
        // 100D:8DE9 push SI
        Stack.Push16(SI);
        // 100D:8DEA call near 0x8E16
        NearCall(cs1, 0x8DED, unknown_100D_8E16_18EE6);
    label_100D_8DED_18EBD_11989:
        CheckExternalEvents(cs1, 0x8DED);
        // 100D:8DED pop SI
        SI = Stack.Pop16();
    label_100D_8DEE_18EBE_11991:
        CheckExternalEvents(cs1, 0x8DEE);
        // 100D:8DEE clc
        CarryFlag = false;
        // 100D:8DEF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8DF0_18EC0(int loadOffset)
    {
    label_100D_8DF0_18EC0_12044:
        CheckExternalEvents(cs1, 0x8DF0);
        // 100D:8DF0 test byte ptr DS:[0x4799],1
        Alu8.And(UInt8[DS, (ushort)0x4799], (byte)0x01);
        // 100D:8DF5 je short 0x8E15
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8DF5");
        }
    label_100D_8DF7_18EC7_12047:
        CheckExternalEvents(cs1, 0x8DF7);
        // 100D:8DF7 push SI
        Stack.Push16(SI);
        // 100D:8DF8 mov SI,0xA9D0
        SI = (ushort)0xA9D0;
        // 100D:8DFB lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8DFC mov CX,AX
        CX = AX;
    label_100D_8DFE_18ECE_12052:
        CheckExternalEvents(cs1, 0x8DFE);
        // 100D:8DFE lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8DFF or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:8E01 je short 0x8E08
        if (ZeroFlag)
        {
            goto label_100D_8E08_18ED8_12058;
        }
    label_100D_8E03_18ED3_12055:
        CheckExternalEvents(cs1, 0x8E03);
        // 100D:8E03 cmp word ptr DS:[SI],0x001E
        Alu16.Sub(UInt16[DS, SI], unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:8E06 jae short 0x8E0F
        if (!CarryFlag)
        {
            goto label_100D_8E0F_18EDF_27271;
        }
    label_100D_8E08_18ED8_12058:
        CheckExternalEvents(cs1, 0x8E08);
        // 100D:8E08 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:8E0B loop 0x8DFE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_8DFE_18ECE_12052;
        }
    label_100D_8E0D_18EDD_12062:
        CheckExternalEvents(cs1, 0x8E0D);
        // 100D:8E0D pop SI
        SI = Stack.Pop16();
        // 100D:8E0E ret near
        return NearRet((ushort)0x0000);
    label_100D_8E0F_18EDF_27271:
        CheckExternalEvents(cs1, 0x8E0F);
        // 100D:8E0F and byte ptr DS:[0x4799],0xFE
        UInt8[DS, (ushort)0x4799] = Alu8.And(UInt8[DS, (ushort)0x4799], (byte)0xFE);
        // 100D:8E14 pop SI
        SI = Stack.Pop16();
        // 100D:8E15 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8E16_18EE6(int loadOffset)
    {
    label_100D_8E16_18EE6_11874:
        CheckExternalEvents(cs1, 0x8E16);
        // 100D:8E16 push DS
        Stack.Push16(DS);
        // 100D:8E17 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8E18 mov byte ptr DS:[0x478C],0
        UInt8[DS, (ushort)0x478C] = (byte)0x00;
        // 100D:8E1D mov DI,0xA9D2
        DI = (ushort)0xA9D2;
        // 100D:8E20 xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 100D:8E22 mov BX,word ptr DS:[0x478F]
        BX = UInt16[DS, (ushort)0x478F];
        // 100D:8E26 xor DL,DL
        DL = Alu8.Xor(DL, DL);
    label_100D_8E28_18EF8_11882:
        CheckExternalEvents(cs1, 0x8E28);
        // 100D:8E28 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:8E2A or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8E2C js short 0x8E74
        if (SignFlag)
        {
            goto label_100D_8E74_18F44_11975;
        }
    label_100D_8E2E_18EFE_11885:
        CheckExternalEvents(cs1, 0x8E2E);
        // 100D:8E2E cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:8E30 je short 0x8E39
        if (ZeroFlag)
        {
            goto label_100D_8E39_18F09_12716;
        }
    label_100D_8E32_18F02_11888:
        CheckExternalEvents(cs1, 0x8E32);
        // 100D:8E32 cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:8E34 jne short 0x8E4B
        if (!ZeroFlag)
        {
            goto label_100D_8E4B_18F1B_11891;
        }
    label_100D_8E36_18F06_11934:
        CheckExternalEvents(cs1, 0x8E36);
        // 100D:8E36 inc SI
        SI = Alu16.Inc(SI);
        // 100D:8E37 jmp short 0x8E28
        goto label_100D_8E28_18EF8_11882;
    label_100D_8E39_18F09_12716:
        CheckExternalEvents(cs1, 0x8E39);
        // 100D:8E39 call near 0x8E9E
        NearCall(cs1, 0x8E3C, unknown_100D_8E9E_18F6E);
    label_100D_8E3C_18F0C_12718:
        CheckExternalEvents(cs1, 0x8E3C);
        // 100D:8E3C mov word ptr DS:[DI-4],6
        UInt16[DS, (ushort)(DI + (sbyte)-4)] = (ushort)0x0006;
        // 100D:8E41 mov word ptr DS:[DI-2],0
        UInt16[DS, (ushort)(DI + (sbyte)-2)] = (ushort)0x0000;
        // 100D:8E46 xor DL,DL
        DL = Alu8.Xor(DL, DL);
        // 100D:8E48 inc SI
        SI = Alu16.Inc(SI);
        // 100D:8E49 jmp short 0x8E28
        goto label_100D_8E28_18EF8_11882;
    label_100D_8E4B_18F1B_11891:
        CheckExternalEvents(cs1, 0x8E4B);
        // 100D:8E4B call near 0x8ED3
        NearCall(cs1, 0x8E4E, unknown_100D_8ED3_18FA3);
    label_100D_8E4E_18F1E_11923:
        CheckExternalEvents(cs1, 0x8E4E);
        // 100D:8E4E or CX,CX
        CX = Alu16.Or(CX, CX);
        // 100D:8E50 je short 0x8E28
        if (ZeroFlag)
        {
            goto label_100D_8E28_18EF8_11882;
        }
    label_100D_8E52_18F22_11926:
        CheckExternalEvents(cs1, 0x8E52);
        // 100D:8E52 add CX,6
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_100D_8E55_18F25_11928:
        CheckExternalEvents(cs1, 0x8E55);
        // 100D:8E55 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:8E57 jb short 0x8E5D
        if (CarryFlag)
        {
            goto label_100D_8E5D_18F2D_11937;
        }
    label_100D_8E59_18F29_11930:
        CheckExternalEvents(cs1, 0x8E59);
        // 100D:8E59 inc DL
        DL = Alu8.Inc(DL);
        // 100D:8E5B jmp short 0x8E28
        goto label_100D_8E28_18EF8_11882;
    label_100D_8E5D_18F2D_11937:
        CheckExternalEvents(cs1, 0x8E5D);
        // 100D:8E5D add BX,6
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:8E60 js short 0x8E69
        if (SignFlag)
        {
            goto label_100D_8E69_18F39_11940;
        }
    label_100D_8E62_18F32_12858:
        CheckExternalEvents(cs1, 0x8E62);
        // 100D:8E62 inc DL
        DL = Alu8.Inc(DL);
        // 100D:8E64 call near 0x8E9E
        NearCall(cs1, 0x8E67, unknown_100D_8E9E_18F6E);
    label_100D_8E67_18F37_12861:
        CheckExternalEvents(cs1, 0x8E67);
        // 100D:8E67 jmp short 0x8E28
        goto label_100D_8E28_18EF8_11882;
    label_100D_8E69_18F39_11940:
        CheckExternalEvents(cs1, 0x8E69);
        // 100D:8E69 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:8E6B je short 0x8E97
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8E6B");
        }
    label_100D_8E6D_18F3D_11943:
        CheckExternalEvents(cs1, 0x8E6D);
        // 100D:8E6D add BX,CX
        BX = Alu16.Add(BX, CX);
        // 100D:8E6F call near 0x8E9E
        NearCall(cs1, 0x8E72, unknown_100D_8E9E_18F6E);
    label_100D_8E72_18F42_11972:
        CheckExternalEvents(cs1, 0x8E72);
        // 100D:8E72 jmp short 0x8E55
        goto label_100D_8E55_18F25_11928;
    label_100D_8E74_18F44_11975:
        CheckExternalEvents(cs1, 0x8E74);
        // 100D:8E74 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 100D:8E76 je short 0x8E7B
        if (ZeroFlag)
        {
            goto label_100D_8E7B_18F4B_11980;
        }
    label_100D_8E78_18F48_11978:
        CheckExternalEvents(cs1, 0x8E78);
        // 100D:8E78 call near 0x8E9E
        NearCall(cs1, 0x8E7B, unknown_100D_8E9E_18F6E);
    label_100D_8E7B_18F4B_11980:
        CheckExternalEvents(cs1, 0x8E7B);
        // 100D:8E7B mov word ptr DS:[DI-4],6
        UInt16[DS, (ushort)(DI + (sbyte)-4)] = (ushort)0x0006;
        // 100D:8E80 mov word ptr DS:[DI-2],0
        UInt16[DS, (ushort)(DI + (sbyte)-2)] = (ushort)0x0000;
        // 100D:8E85 mov word ptr DS:[DI],0
        UInt16[DS, DI] = (ushort)0x0000;
        // 100D:8E89 mov word ptr DS:[DI+2],0
        UInt16[DS, (ushort)(DI + (sbyte)2)] = (ushort)0x0000;
        // 100D:8E8E xor DL,DL
        DL = Alu8.Xor(DL, DL);
        // 100D:8E90 xchg DH,DL
        byte temp_100D_8E90_18F60 = DH;
        DH = DL;
        DL = unchecked((byte)temp_100D_8E90_18F60);
        // 100D:8E92 mov word ptr DS:[0xA9D0],DX
        UInt16[DS, (ushort)0xA9D0] = DX;
        // 100D:8E96 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8E9E_18F6E(int loadOffset)
    {
    label_100D_8E9E_18F6E_11946:
        CheckExternalEvents(cs1, 0x8E9E);
        // 100D:8E9E mov AX,DX
        AX = DX;
        // 100D:8EA0 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:8EA2 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8EA3 add byte ptr DS:[0x478C],AL
        UInt8[DS, (ushort)0x478C] = Alu8.Add(UInt8[DS, (ushort)0x478C], AL);
        // 100D:8EA7 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:8EA9 je short 0x8ECA
        if (ZeroFlag)
        {
            goto label_100D_8ECA_18F9A_24885;
        }
    label_100D_8EAB_18F7B_11953:
        CheckExternalEvents(cs1, 0x8EAB);
        // 100D:8EAB push DX
        Stack.Push16(DX);
        // 100D:8EAC mov AX,BX
        AX = BX;
        // 100D:8EAE mov BX,DX
        BX = DX;
        // 100D:8EB0 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:8EB2 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8EB4 dec BX
        BX = Alu16.Dec(BX);
        // 100D:8EB5 je short 0x8EB9
        if (ZeroFlag)
        {
            goto label_100D_8EB9_18F89_11963;
        }
    label_100D_8EB7_18F87_11961:
        CheckExternalEvents(cs1, 0x8EB7);
        // 100D:8EB7 div BX
        ushort divisor_100D_8EB7_18F87 = BX;
        uint dividend_100D_8EB7_18F87 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_8EB7_18F87 = Alu16.Div(unchecked((uint)dividend_100D_8EB7_18F87), unchecked((ushort)divisor_100D_8EB7_18F87));
        AX = unchecked((ushort)quotient_100D_8EB7_18F87);
        DX = unchecked((ushort)(dividend_100D_8EB7_18F87 % unchecked((uint)divisor_100D_8EB7_18F87)));
    label_100D_8EB9_18F89_11963:
        CheckExternalEvents(cs1, 0x8EB9);
        // 100D:8EB9 add AX,6
        AX = Alu16.Add(AX, (ushort)0x0006);
        // 100D:8EBC stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8EBD mov AX,DX
        AX = DX;
        // 100D:8EBF stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8EC0 pop DX
        DX = Stack.Pop16();
        // 100D:8EC1 inc DH
        DH = Alu8.Inc(DH);
        // 100D:8EC3 xor DL,DL
        DL = Alu8.Xor(DL, DL);
        // 100D:8EC5 mov BX,word ptr DS:[0x478F]
        BX = UInt16[DS, (ushort)0x478F];
        // 100D:8EC9 ret near
        return NearRet((ushort)0x0000);
    label_100D_8ECA_18F9A_24885:
        CheckExternalEvents(cs1, 0x8ECA);
        // 100D:8ECA stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8ECB stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8ECC inc DH
        DH = Alu8.Inc(DH);
        // 100D:8ECE mov BX,word ptr DS:[0x478F]
        BX = UInt16[DS, (ushort)0x478F];
        // 100D:8ED2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8ED3_18FA3(int loadOffset)
    {
    label_100D_8ED3_18FA3_11893:
        CheckExternalEvents(cs1, 0x8ED3);
        // 100D:8ED3 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:8ED5 push BX
        Stack.Push16(BX);
        // 100D:8ED6 mov BX,word ptr DS:[0x47A0]
        BX = UInt16[DS, (ushort)0x47A0];
    label_100D_8EDA_18FAA_11897:
        CheckExternalEvents(cs1, 0x8EDA);
        // 100D:8EDA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:8EDB cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:8EDD je short 0x8F25
        if (ZeroFlag)
        {
            goto label_100D_8F25_18FF5_11919;
        }
    label_100D_8EDF_18FAF_11900:
        CheckExternalEvents(cs1, 0x8EDF);
        // 100D:8EDF cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:8EE1 je short 0x8F25
        if (ZeroFlag)
        {
            goto label_100D_8F25_18FF5_11919;
        }
    label_100D_8EE3_18FB3_11903:
        CheckExternalEvents(cs1, 0x8EE3);
        // 100D:8EE3 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8EE5 je short 0x8EED
        if (ZeroFlag)
        {
            goto label_100D_8EED_18FBD_11911;
        }
    label_100D_8EE7_18FB7_11906:
        CheckExternalEvents(cs1, 0x8EE7);
        // 100D:8EE7 cmp AL,9
        Alu8.Sub(AL, (byte)0x09);
        // 100D:8EE9 jb short 0x8F09
        if (CarryFlag)
        {
            goto label_100D_8F09_18FD9_27453;
        }
    label_100D_8EEB_18FBB_11909:
        CheckExternalEvents(cs1, 0x8EEB);
        // 100D:8EEB js short 0x8F25
        if (SignFlag)
        {
            goto label_100D_8F25_18FF5_11919;
        }
    label_100D_8EED_18FBD_11911:
        CheckExternalEvents(cs1, 0x8EED);
        // 100D:8EED cmp word ptr DS:[0x2518],0xD0FF
        Alu16.Sub(UInt16[DS, (ushort)0x2518], (ushort)0xD0FF);
        // 100D:8EF3 jne short 0x8F04
        if (!ZeroFlag)
        {
            goto label_100D_8F04_18FD4_11914;
        }
    label_100D_8EF5_18FC5_16656:
        CheckExternalEvents(cs1, 0x8EF5);
        // 100D:8EF5 cmp SI,0xA6B1
        Alu16.Sub(SI, (ushort)0xA6B1);
        // 100D:8EF9 jne short 0x8F04
        if (!ZeroFlag)
        {
            goto label_100D_8F04_18FD4_11914;
        }
    label_100D_8EFB_18FCB_16659:
        CheckExternalEvents(cs1, 0x8EFB);
        // 100D:8EFB call near 0xD0E3
        NearCall(cs1, 0x8EFE, unknown_100D_D0E3_1D1B3);
    label_100D_8EFE_18FCE_16680:
        CheckExternalEvents(cs1, 0x8EFE);
        // 100D:8EFE jb short 0x8F04
        if (CarryFlag)
        {
            goto label_100D_8F04_18FD4_11914;
        }
    label_100D_8F00_18FD0_16682:
        CheckExternalEvents(cs1, 0x8F00);
        // 100D:8F00 add CL,AL
        CL = Alu8.Add(CL, AL);
        // 100D:8F02 jmp short 0x8EDA
        goto label_100D_8EDA_18FAA_11897;
    label_100D_8F04_18FD4_11914:
        CheckExternalEvents(cs1, 0x8F04);
        // 100D:8F04 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:8F05 add CL,AL
        CL = Alu8.Add(CL, AL);
        // 100D:8F07 jmp short 0x8EDA
        goto label_100D_8EDA_18FAA_11897;
    label_100D_8F09_18FD9_27453:
        CheckExternalEvents(cs1, 0x8F09);
        // 100D:8F09 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:8F0B je short 0x8F25
        if (ZeroFlag)
        {
            goto label_100D_8F25_18FF5_11919;
        }
    label_100D_8F0D_18FDD_27456:
        CheckExternalEvents(cs1, 0x8F0D);
        // 100D:8F0D cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:8F0F je short 0x8F1D
        if (ZeroFlag)
        {
            goto label_100D_8F1D_18FED_27459;
        }
    label_100D_8F11_18FE1_31992:
        CheckExternalEvents(cs1, 0x8F11);
        // 100D:8F11 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:8F13 jne short 0x8EDA
        if (!ZeroFlag)
        {
            goto label_100D_8EDA_18FAA_11897;
        }
    label_100D_8F15_18FE5_31995:
        CheckExternalEvents(cs1, 0x8F15);
        // 100D:8F15 mov word ptr DS:[0x47A0],0xCEEC
        UInt16[DS, (ushort)0x47A0] = (ushort)0xCEEC;
        // 100D:8F1B jmp short 0x8EDA
        goto label_100D_8EDA_18FAA_11897;
    label_100D_8F1D_18FED_27459:
        CheckExternalEvents(cs1, 0x8F1D);
        // 100D:8F1D mov word ptr DS:[0x47A0],0xCF6C
        UInt16[DS, (ushort)0x47A0] = (ushort)0xCF6C;
        // 100D:8F23 jmp short 0x8EDA
        goto label_100D_8EDA_18FAA_11897;
    label_100D_8F25_18FF5_11919:
        CheckExternalEvents(cs1, 0x8F25);
        // 100D:8F25 dec SI
        SI = Alu16.Dec(SI);
        // 100D:8F26 pop BX
        BX = Stack.Pop16();
        // 100D:8F27 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8F28_18FF8(int loadOffset)
    {
    label_100D_8F28_18FF8_11997:
        CheckExternalEvents(cs1, 0x8F28);
        // 100D:8F28 mov word ptr DS:[0x479E],BP
        UInt16[DS, (ushort)0x479E] = BP;
        // 100D:8F2C mov DI,0x1BE2
        DI = (ushort)0x1BE2;
        // 100D:8F2F push DS
        Stack.Push16(DS);
        // 100D:8F30 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8F31 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:8F34 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8F35 mov DX,AX
        DX = AX;
        // 100D:8F37 add AX,word ptr DS:[0x4784]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x4784]);
        // 100D:8F3B mov word ptr DS:[0x4791],AX
        UInt16[DS, (ushort)0x4791] = AX;
        // 100D:8F3E mov word ptr DS:[0x4795],AX
        UInt16[DS, (ushort)0x4795] = AX;
        // 100D:8F41 mov AX,word ptr SS:[BP+2]
        AX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:8F44 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8F45 mov BX,AX
        BX = AX;
        // 100D:8F47 add AX,word ptr DS:[0x4788]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x4788]);
        // 100D:8F4B mov word ptr DS:[0x4793],AX
        UInt16[DS, (ushort)0x4793] = AX;
        // 100D:8F4E mov word ptr DS:[0x4797],AX
        UInt16[DS, (ushort)0x4797] = AX;
        // 100D:8F51 mov AX,word ptr SS:[BP+4]
        AX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:8F54 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 100D:8F56 sub AX,word ptr DS:[0x4784]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4784]);
        // 100D:8F5A sub AX,word ptr DS:[0x4786]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4786]);
        // 100D:8F5E mov word ptr DS:[0x478F],AX
        UInt16[DS, (ushort)0x478F] = AX;
        // 100D:8F61 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 100D:8F64 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:8F66 sub AX,word ptr DS:[0x4788]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x4788]);
        // 100D:8F6A sub AX,word ptr DS:[0x478A]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x478A]);
        // 100D:8F6E mov word ptr DS:[0x478D],AX
        UInt16[DS, (ushort)0x478D] = AX;
        // 100D:8F71 mov AX,DX
        AX = DX;
        // 100D:8F73 cmp AX,0x0140
        Alu16.Sub(AX, (ushort)0x0140);
        // 100D:8F76 jb short 0x8F7B
        if (CarryFlag)
        {
            goto label_100D_8F7B_1904B_12029;
        }
    label_100D_8F78_19048_12027:
        CheckExternalEvents(cs1, 0x8F78);
        // 100D:8F78 mov AX,0x0140
        AX = (ushort)0x0140;
    label_100D_8F7B_1904B_12029:
        CheckExternalEvents(cs1, 0x8F7B);
        // 100D:8F7B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8F7C mov AX,BX
        AX = BX;
        // 100D:8F7E stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8F7F cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:8F84 jne short 0x8FD1
        if (!ZeroFlag)
        {
            return unknown_100D_8FD1_190A1(0x0000);
        }
    label_100D_8F86_19056_12034:
        CheckExternalEvents(cs1, 0x8F86);
        // 100D:8F86 cmp byte ptr DS:[0x00C6],0
        Alu8.Sub(UInt8[DS, (ushort)0x00C6], (byte)0x00);
        // 100D:8F8B jne short 0x8FF5
        if (!ZeroFlag)
        {
            goto label_100D_8FF5_190C5_16685;
        }
    label_100D_8F8D_1905D_12037:
        CheckExternalEvents(cs1, 0x8F8D);
        // 100D:8F8D cmp byte ptr DS:[0x227D],0
        Alu8.Sub(UInt8[DS, (ushort)0x227D], (byte)0x00);
        // 100D:8F92 jne short 0x8FD0
        if (!ZeroFlag)
        {
            goto label_100D_8FD0_190A0_12040;
        }
    label_100D_8F94_19064_25876:
        CheckExternalEvents(cs1, 0x8F94);
        // 100D:8F94 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:8F99 jne short 0x8FD0
        if (!ZeroFlag)
        {
            goto label_100D_8FD0_190A0_12040;
        }
    label_100D_8F9B_1906B_25879:
        CheckExternalEvents(cs1, 0x8F9B);
        // 100D:8F9B cmp byte ptr DS:[0x28E7],0
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x00);
        // 100D:8FA0 je short 0x900B
        if (ZeroFlag)
        {
            goto label_100D_900B_190DB_31429;
        }
    label_100D_8FA2_19072_25882:
        CheckExternalEvents(cs1, 0x8FA2);
        // 100D:8FA2 push SI
        Stack.Push16(SI);
        // 100D:8FA3 mov SI,0x4C60
        SI = (ushort)0x4C60;
        // 100D:8FA6 mov BP,0x1BE2
        BP = (ushort)0x1BE2;
        // 100D:8FA9 mov AX,0x0080
        AX = (ushort)0x0080;
        // 100D:8FAC mov word ptr SS:[BP+8],AX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = AX;
        // 100D:8FAF mov word ptr DS:[0x1C06],AX
        UInt16[DS, (ushort)0x1C06] = AX;
        // 100D:8FB2 mov word ptr SS:[BP+0x0C],0x9468
        UInt16[SS, (ushort)(BP + (sbyte)12)] = (ushort)0x9468;
        // 100D:8FB7 mov ES,word ptr DS:[0xDBDE]
        ES = UInt16[DS, (ushort)0xDBDE];
        // 100D:8FBB call far dword ptr DS:[0x3919]
        ushort targetSegment_25891 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3919 + (ushort)0x0002)]));
        ushort targetOffset_25891 = unchecked((ushort)(UInt16[DS, (ushort)0x3919]));
        if (targetSegment_25891 == cs2 && targetOffset_25891 == 0x014B)
        {
            FarCall(cs1, 0x8FBF, cs2, unknown_3358_014B_336CB);
            goto label_100D_8FBF_1908F_25892;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_25891:X4}:{targetOffset_25891:X4} at 100D:8FBB");
    label_100D_8FBF_1908F_25892:
        CheckExternalEvents(cs1, 0x8FBF);
        // 100D:8FBF call near 0xC137
        NearCall(cs1, 0x8FC2, unknown_100D_C137_1C207);
    label_100D_8FC2_19092_25894:
        CheckExternalEvents(cs1, 0x8FC2);
        // 100D:8FC2 mov SI,0x1BE2
        SI = (ushort)0x1BE2;
        // 100D:8FC5 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:8FC9 mov AX,0x001C
        AX = (ushort)0x001C;
        // 100D:8FCC call near 0xC370
        NearCall(cs1, 0x8FCF, unknown_100D_C370_1C440);
    label_100D_8FCF_1909F_25899:
        CheckExternalEvents(cs1, 0x8FCF);
        // 100D:8FCF pop SI
        SI = Stack.Pop16();
    label_100D_8FD0_190A0_12040:
        CheckExternalEvents(cs1, 0x8FD0);
        // 100D:8FD0 ret near
        return NearRet((ushort)0x0000);
    label_100D_8FF5_190C5_16685:
        CheckExternalEvents(cs1, 0x8FF5);
        // 100D:8FF5 push SI
        Stack.Push16(SI);
        // 100D:8FF6 mov AX,0x0032
        AX = (ushort)0x0032;
        // 100D:8FF9 call near 0xC13E
        NearCall(cs1, 0x8FFC, unknown_100D_C13E_1C20E);
    label_100D_8FFC_190CC_16689:
        CheckExternalEvents(cs1, 0x8FFC);
        // 100D:8FFC mov AX,3
        AX = (ushort)0x0003;
        // 100D:8FFF mov SI,0x2265
        SI = (ushort)0x2265;
        // 100D:9002 mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:9006 call near 0xC370
        NearCall(cs1, 0x9009, unknown_100D_C370_1C440);
    label_100D_9009_190D9_16710:
        CheckExternalEvents(cs1, 0x9009);
        // 100D:9009 pop SI
        SI = Stack.Pop16();
        // 100D:900A ret near
        return NearRet((ushort)0x0000);
    label_100D_900B_190DB_31429:
        CheckExternalEvents(cs1, 0x900B);
        // 100D:900B mov DI,0x4C60
        DI = (ushort)0x4C60;
        // 100D:900E mov CX,0x5960
        CX = (ushort)0x5960;
        // 100D:9011 push DS
        Stack.Push16(DS);
        // 100D:9012 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9013 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:9015 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:9017 mov AX,0x4C6F
        AX = (ushort)0x4C6F;
        // 100D:901A and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:901C mov word ptr DS:[0x22FC],AX
        UInt16[DS, (ushort)0x22FC] = AX;
        // 100D:901F call near 0xC085
        NearCall(cs1, 0x9022, unknown_100D_C085_1C155);
    label_100D_9022_190F2_31440:
        CheckExternalEvents(cs1, 0x9022);
        // 100D:9022 jmp near 0x8895
        return unknown_100D_8895_18965(0x0000);
    }

    public virtual Action unknown_100D_8FD1_190A1(int loadOffset)
    {
    label_100D_8FD1_190A1_24382:
        CheckExternalEvents(cs1, 0x8FD1);
        // 100D:8FD1 push SI
        Stack.Push16(SI);
        // 100D:8FD2 mov SI,0x1BE2
        SI = (ushort)0x1BE2;
        // 100D:8FD5 mov word ptr DS:[SI+8],0x0080
        UInt16[DS, (ushort)(SI + (sbyte)8)] = (ushort)0x0080;
        // 100D:8FDA mov word ptr DS:[SI+0x0C],0x7BED
        UInt16[DS, (ushort)(SI + (sbyte)12)] = (ushort)0x7BED;
        // 100D:8FDF sub word ptr DS:[SI+2],2
        UInt16[DS, (ushort)(SI + (sbyte)2)] = Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)2)], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:8FE3 mov AL,byte ptr DS:[0x18F2]
        AL = UInt8[DS, (ushort)0x18F2];
        // 100D:8FE6 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:8FEA call far dword ptr DS:[0x38DD]
        ushort targetSegment_24390 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38DD + (ushort)0x0002)]));
        ushort targetOffset_24390 = unchecked((ushort)(UInt16[DS, (ushort)0x38DD]));
        if (targetSegment_24390 == cs2 && targetOffset_24390 == 0x011E)
        {
            FarCall(cs1, 0x8FEE, cs2, unknown_3358_011E_3369E);
            goto label_100D_8FEE_190BE_24391;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_24390:X4}:{targetOffset_24390:X4} at 100D:8FEA");
    label_100D_8FEE_190BE_24391:
        CheckExternalEvents(cs1, 0x8FEE);
        // 100D:8FEE add word ptr DS:[0x1BE4],2
        UInt16[DS, (ushort)0x1BE4] = Alu16.Add(UInt16[DS, (ushort)0x1BE4], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:8FF3 pop SI
        SI = Stack.Pop16();
        // 100D:8FF4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9025_190F5(int loadOffset)
    {
    label_100D_9025_190F5_31486:
        CheckExternalEvents(cs1, 0x9025);
        // 100D:9025 mov CX,word ptr DS:[0x4793]
        CX = UInt16[DS, (ushort)0x4793];
        // 100D:9029 mov BX,0x0092
        BX = (ushort)0x0092;
        // 100D:902C sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:902E xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:9030 mov CH,0xFF
        CH = (byte)0xFF;
        // 100D:9032 mov DI,0x0140
        DI = (ushort)0x0140;
        // 100D:9035 mov SI,word ptr DS:[0x22FC]
        SI = UInt16[DS, (ushort)0x22FC];
        // 100D:9039 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:903D mov word ptr DS:[0x4782],BX
        UInt16[DS, (ushort)0x4782] = BX;
        // 100D:9041 call far dword ptr DS:[0x38C9]
        ushort targetSegment_31496 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38C9 + (ushort)0x0002)]));
        ushort targetOffset_31496 = unchecked((ushort)(UInt16[DS, (ushort)0x38C9]));
        if (targetSegment_31496 == cs2 && targetOffset_31496 == 0x010F)
        {
            FarCall(cs1, 0x9045, cs2, unknown_3358_010F_3368F);
            goto label_100D_9045_19115_31497;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_31496:X4}:{targetOffset_31496:X4} at 100D:9041");
    label_100D_9045_19115_31497:
        CheckExternalEvents(cs1, 0x9045);
        // 100D:9045 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9046_19116(int loadOffset)
    {
    label_100D_9046_19116_31445:
        CheckExternalEvents(cs1, 0x9046);
        // 100D:9046 push DS
        Stack.Push16(DS);
        // 100D:9047 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9048 mov AX,word ptr DS:[0x4793]
        AX = UInt16[DS, (ushort)0x4793];
        // 100D:904B mul word ptr DS:[0x2240]
        uint result_100D_904B_1911B = Alu16.Mul(AX, unchecked((ushort)unchecked((short)UInt16[DS, (ushort)0x2240])));
        DX = unchecked((ushort)(result_100D_904B_1911B >> 16));
        AX = unchecked((ushort)result_100D_904B_1911B);
        // 100D:904F mov CX,AX
        CX = AX;
        // 100D:9051 mov DI,word ptr DS:[0x22FC]
        DI = UInt16[DS, (ushort)0x22FC];
        // 100D:9055 mov AX,0xF00F
        AX = (ushort)0xF00F;
        // 100D:9058 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:905A cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:905F jle short 0x9063
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_9063_19133_31456;
        }
    label_100D_9061_19131_37469:
        CheckExternalEvents(cs1, 0x9061);
        // 100D:9061 mov AH,8
        AH = (byte)0x08;
    label_100D_9063_19133_31456:
        CheckExternalEvents(cs1, 0x9063);
        // 100D:9063 repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_9063_19133 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_9063_19133)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_9063_19133 = ZeroFlag == false;
        }
        // 100D:9065 jne short 0x908B
        if (!ZeroFlag)
        {
            goto label_100D_908B_1915B_31480;
        }
    label_100D_9067_19137_31459:
        CheckExternalEvents(cs1, 0x9067);
        // 100D:9067 cmp byte ptr DS:[DI-2],BL
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)-2)], BL);
        // 100D:906A jne short 0x906F
        if (!ZeroFlag)
        {
            goto label_100D_906F_1913F_31464;
        }
    label_100D_906C_1913C_31462:
        CheckExternalEvents(cs1, 0x906C);
        // 100D:906C mov byte ptr DS:[DI-2],AH
        UInt8[DS, (ushort)(DI + (sbyte)-2)] = AH;
    label_100D_906F_1913F_31464:
        CheckExternalEvents(cs1, 0x906F);
        // 100D:906F cmp byte ptr DS:[DI],BL
        Alu8.Sub(UInt8[DS, DI], BL);
        // 100D:9071 jne short 0x9075
        if (!ZeroFlag)
        {
            goto label_100D_9075_19145_31468;
        }
    label_100D_9073_19143_31466:
        CheckExternalEvents(cs1, 0x9073);
        // 100D:9073 mov byte ptr DS:[DI],AH
        UInt8[DS, DI] = AH;
    label_100D_9075_19145_31468:
        CheckExternalEvents(cs1, 0x9075);
        // 100D:9075 cmp byte ptr DS:[DI-321],BL
        Alu8.Sub(UInt8[DS, (ushort)(DI + (short)-321)], BL);
        // 100D:9079 jne short 0x907F
        if (!ZeroFlag)
        {
            goto label_100D_907F_1914F_31472;
        }
    label_100D_907B_1914B_31470:
        CheckExternalEvents(cs1, 0x907B);
        // 100D:907B mov byte ptr DS:[DI-321],AH
        UInt8[DS, (ushort)(DI + (short)-321)] = AH;
    label_100D_907F_1914F_31472:
        CheckExternalEvents(cs1, 0x907F);
        // 100D:907F cmp byte ptr DS:[DI+0x013F],BL
        Alu8.Sub(UInt8[DS, (ushort)(DI + (short)319)], BL);
        // 100D:9083 jne short 0x9063
        if (!ZeroFlag)
        {
            goto label_100D_9063_19133_31456;
        }
    label_100D_9085_19155_31475:
        CheckExternalEvents(cs1, 0x9085);
        // 100D:9085 mov byte ptr DS:[DI+0x013F],AH
        UInt8[DS, (ushort)(DI + (short)319)] = AH;
        // 100D:9089 jmp short 0x9063
        goto label_100D_9063_19133_31456;
    label_100D_908B_1915B_31480:
        CheckExternalEvents(cs1, 0x908B);
        // 100D:908B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_908C_1915C(int loadOffset)
    {
    label_100D_908C_1915C_9009:
        CheckExternalEvents(cs1, 0x908C);
        // 100D:908C mov AX,word ptr DS:[0xD83A]
        AX = UInt16[DS, (ushort)0xD83A];
        // 100D:908F cmp AX,word ptr DS:[0x4782]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x4782]);
        // 100D:9093 jbe short 0x90BC
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_90BC_1918C_9016;
        }
    label_100D_9095_19165_9013:
        CheckExternalEvents(cs1, 0x9095);
        // 100D:9095 cmp word ptr DS:[0x479E],0x223C
        Alu16.Sub(UInt16[DS, (ushort)0x479E], (ushort)0x223C);
        // 100D:909B jne short 0x90BC
        if (!ZeroFlag)
        {
            goto label_100D_90BC_1918C_9016;
        }
    label_100D_909D_1916D_31499:
        CheckExternalEvents(cs1, 0x909D);
        // 100D:909D mov CX,word ptr DS:[0x4793]
        CX = UInt16[DS, (ushort)0x4793];
        // 100D:90A1 mov BX,0x0092
        BX = (ushort)0x0092;
        // 100D:90A4 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 100D:90A6 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:90A8 mov CH,0xFF
        CH = (byte)0xFF;
        // 100D:90AA mov DI,0x0140
        DI = (ushort)0x0140;
        // 100D:90AD mov SI,word ptr DS:[0x22FC]
        SI = UInt16[DS, (ushort)0x22FC];
        // 100D:90B1 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:90B5 mov BP,0xD834
        BP = (ushort)0xD834;
        // 100D:90B8 call far dword ptr DS:[0x38CD]
        ushort targetSegment_31509 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38CD + (ushort)0x0002)]));
        ushort targetOffset_31509 = unchecked((ushort)(UInt16[DS, (ushort)0x38CD]));
        if (targetSegment_31509 == cs2 && targetOffset_31509 == 0x0112)
        {
            FarCall(cs1, 0x90BC, cs2, unknown_3358_0112_33692);
            goto label_100D_90BC_1918C_9016;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_31509:X4}:{targetOffset_31509:X4} at 100D:90B8");
    label_100D_90BC_1918C_9016:
        CheckExternalEvents(cs1, 0x90BC);
        // 100D:90BC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_90BD_1918D(int loadOffset)
    {
    entrydispatcher:
    label_100D_90BD_1918D_15496:
        CheckExternalEvents(cs1, 0x90BD);
        // 100D:90BD mov AL,byte ptr DS:[SI+0x0E]
        AL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:90C0 cmp AL,0x0C
        Alu8.Sub(AL, (byte)0x0C);
        // 100D:90C2 je short 0x90D9
        if (ZeroFlag)
        {
            goto label_100D_90D9_191A9_15503;
        }
    label_100D_90C4_19194_15500:
        CheckExternalEvents(cs1, 0x90C4);
        // 100D:90C4 test word ptr DS:[0x0012],0x1000
        Alu16.And(UInt16[DS, (ushort)0x0012], (ushort)0x1000);
        // 100D:90CA je short 0x90D9
        if (ZeroFlag)
        {
            goto label_100D_90D9_191A9_15503;
        }
    label_100D_90CC_1919C_38196:
        CheckExternalEvents(cs1, 0x90CC);
        // 100D:90CC mov BX,0x009C
        BX = (ushort)0x009C;
        // 100D:90CF mov DX,0x9584
        DX = (ushort)0x9584;
        // 100D:90D2 test byte ptr DS:[0x10A7],0x10
        Alu8.And(UInt8[DS, (ushort)0x10A7], (byte)0x10);
        // 100D:90D7 je short 0x9111
        if (ZeroFlag)
        {
            goto label_100D_9111_191E1_15521;
        }
    label_100D_90D9_191A9_15503:
        CheckExternalEvents(cs1, 0x90D9);
        // 100D:90D9 cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 100D:90DB mov BX,0x0093
        BX = (ushort)0x0093;
        // 100D:90DE mov DX,0x5A03
        DX = (ushort)0x5A03;
        // 100D:90E1 je short 0x9111
        if (ZeroFlag)
        {
            goto label_100D_9111_191E1_15521;
        }
    label_100D_90E3_191B3_15508:
        CheckExternalEvents(cs1, 0x90E3);
        // 100D:90E3 cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:90E5 jne short 0x90F7
        if (!ZeroFlag)
        {
            goto label_100D_90F7_191C7_15511;
        }
    label_100D_90E7_191B7_23176:
        CheckExternalEvents(cs1, 0x90E7);
        // 100D:90E7 mov BX,0x0096
        BX = (ushort)0x0096;
        // 100D:90EA mov DX,0x95C1
        DX = (ushort)0x95C1;
        // 100D:90ED test byte ptr DS:[0x000A],0x10
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x10);
        // 100D:90F2 je short 0x9111
        if (ZeroFlag)
        {
            goto label_100D_9111_191E1_15521;
        }
    label_100D_90F4_191C4_33510:
        CheckExternalEvents(cs1, 0x90F4);
        // 100D:90F4 inc BX
        BX = Alu16.Inc(BX);
        // 100D:90F5 jmp short 0x9111
        goto label_100D_9111_191E1_15521;
    label_100D_90F7_191C7_15511:
        CheckExternalEvents(cs1, 0x90F7);
        // 100D:90F7 mov CL,byte ptr DS:[SI+0x0F]
        CL = UInt8[DS, (ushort)(SI + (sbyte)15)];
        // 100D:90FA mov BX,0x4091
        BX = (ushort)0x4091;
        // 100D:90FD test CL,0x80
        Alu8.And(CL, (byte)0x80);
        // 100D:9100 jne short 0x9111
        if (!ZeroFlag)
        {
            goto label_100D_9111_191E1_15521;
        }
    label_100D_9102_191D2_15516:
        CheckExternalEvents(cs1, 0x9102);
        // 100D:9102 and BH,0xBF
        BH = Alu8.And(BH, (byte)0xBF);
        // 100D:9105 mov DX,0x95E2
        DX = (ushort)0x95E2;
        // 100D:9108 test CL,0x40
        Alu8.And(CL, (byte)0x40);
        // 100D:910B je short 0x9111
        if (ZeroFlag)
        {
            goto label_100D_9111_191E1_15521;
        }
    label_100D_910D_191DD_25107:
        CheckExternalEvents(cs1, 0x910D);
        // 100D:910D inc BX
        BX = Alu16.Inc(BX);
        // 100D:910E mov DX,0x9533
        DX = (ushort)0x9533;
    label_100D_9111_191E1_15521:
        CheckExternalEvents(cs1, 0x9111);
        // 100D:9111 mov BP,0x1F7E
        BP = (ushort)0x1F7E;
        // 100D:9114 mov word ptr SS:[BP+6],BX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = BX;
        // 100D:9117 mov word ptr SS:[BP+8],DX
        UInt16[SS, (ushort)(BP + (sbyte)8)] = DX;
        // 100D:911A call near 0xD316
        NearCall(cs1, 0x911D, unknown_100D_D316_1D3E6);
    label_100D_911D_191ED_15532:
        CheckExternalEvents(cs1, 0x911D);
        // 100D:911D mov BX,0x97CF
        BX = (ushort)0x97CF;
        // 100D:9120 jmp near 0xD338
        if (JumpDispatcher.Jump(unknown_100D_D338_1D408, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9123_191F3(int loadOffset)
    {
    label_100D_9123_191F3_7778:
        CheckExternalEvents(cs1, 0x9123);
        // 100D:9123 cmp AL,0x11
        Alu8.Sub(AL, (byte)0x11);
        // 100D:9125 jae short 0x917A
        if (!CarryFlag)
        {
            goto label_100D_917A_1924A_9520;
        }
    label_100D_9127_191F7_7781:
        CheckExternalEvents(cs1, 0x9127);
        // 100D:9127 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9129 cmp AL,0x0D
        Alu8.Sub(AL, (byte)0x0D);
        // 100D:912B jb short 0x9173
        if (CarryFlag)
        {
            goto label_100D_9173_19243_7785;
        }
    label_100D_912D_191FD_22886:
        CheckExternalEvents(cs1, 0x912D);
        // 100D:912D jne short 0x913B
        if (!ZeroFlag)
        {
            goto label_100D_913B_1920B_22888;
        }
    label_100D_912F_191FF_33895:
        CheckExternalEvents(cs1, 0x912F);
        // 100D:912F mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:9133 mov AH,byte ptr DS:[DI]
        AH = UInt8[DS, DI];
        // 100D:9135 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 100D:9137 inc AH
        AH = Alu8.Inc(AH);
        // 100D:9139 jmp short 0x9173
        goto label_100D_9173_19243_7785;
    label_100D_913B_1920B_22888:
        CheckExternalEvents(cs1, 0x913B);
        // 100D:913B mov SI,word ptr DS:[0x4756]
        SI = UInt16[DS, (ushort)0x4756];
        // 100D:913F cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:9141 je short 0x9155
        if (ZeroFlag)
        {
            goto label_100D_9155_19225_22892;
        }
    label_100D_9143_19213_23482:
        CheckExternalEvents(cs1, 0x9143);
        // 100D:9143 cmp byte ptr DS:[0x002A],0xC8
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0xC8);
        // 100D:9148 je short 0x9173
        if (ZeroFlag)
        {
            goto label_100D_9173_19243_7785;
        }
    label_100D_914A_1921A_23485:
        CheckExternalEvents(cs1, 0x914A);
        // 100D:914A mov AL,byte ptr DS:[0x476C]
        AL = UInt8[DS, (ushort)0x476C];
        // 100D:914D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:914F mov SI,AX
        SI = AX;
        // 100D:9151 mov SI,word ptr DS:[SI+0x4758]
        SI = UInt16[DS, (ushort)(SI + (short)18264)];
    label_100D_9155_19225_22892:
        CheckExternalEvents(cs1, 0x9155);
        // 100D:9155 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:9157 push DX
        Stack.Push16(DX);
        // 100D:9158 mov DL,3
        DL = (byte)0x03;
        // 100D:915A div DL
        byte divisor_100D_915A_1922A = DL;
        ushort dividend_100D_915A_1922A = AX;
        byte quotient_100D_915A_1922A = Alu8.Div(unchecked((ushort)dividend_100D_915A_1922A), unchecked((byte)divisor_100D_915A_1922A));
        AL = unchecked((byte)quotient_100D_915A_1922A);
        AH = unchecked((byte)(dividend_100D_915A_1922A % unchecked((ushort)divisor_100D_915A_1922A)));
        // 100D:915C mov DL,0x0F
        DL = (byte)0x0F;
        // 100D:915E or AH,AH
        AH = Alu8.Or(AH, AH);
        // 100D:9160 je short 0x9164
        if (ZeroFlag)
        {
            goto label_100D_9164_19234_22902;
        }
    label_100D_9162_19232_22900:
        CheckExternalEvents(cs1, 0x9162);
        // 100D:9162 mov DL,0x11
        DL = (byte)0x11;
    label_100D_9164_19234_22902:
        CheckExternalEvents(cs1, 0x9164);
        // 100D:9164 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 100D:9166 jb short 0x916C
        if (CarryFlag)
        {
            goto label_100D_916C_1923C_22904;
        }
    label_100D_9168_19238_36528:
        CheckExternalEvents(cs1, 0x9168);
        // 100D:9168 sub AL,DL
        AL = Alu8.Sub(AL, DL);
        // 100D:916A jmp short 0x9164
        goto label_100D_9164_19234_22902;
    label_100D_916C_1923C_22904:
        CheckExternalEvents(cs1, 0x916C);
        // 100D:916C pop DX
        DX = Stack.Pop16();
        // 100D:916D xchg AL,AH
        byte temp_100D_916D_1923D = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_916D_1923D);
        // 100D:916F add AL,0x0E
        AL = Alu8.Add(AL, (byte)0x0E);
    label_100D_9171_19241_9533:
        CheckExternalEvents(cs1, 0x9171);
        // 100D:9171 inc AH
        AH = Alu8.Inc(AH);
    label_100D_9173_19243_7785:
        CheckExternalEvents(cs1, 0x9173);
        // 100D:9173 mov byte ptr DS:[0x47D0],AH
        UInt8[DS, (ushort)0x47D0] = AH;
        // 100D:9177 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9179 ret near
        return NearRet((ushort)0x0000);
    label_100D_917A_1924A_9520:
        CheckExternalEvents(cs1, 0x917A);
        // 100D:917A mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:917D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:917F shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9181 cmp AH,8
        Alu8.Sub(AH, (byte)0x08);
        // 100D:9184 jb short 0x9188
        if (CarryFlag)
        {
            goto label_100D_9188_19258_9526;
        }
    label_100D_9186_19256_38340:
        CheckExternalEvents(cs1, 0x9186);
        // 100D:9186 mov AH,8
        AH = (byte)0x08;
    label_100D_9188_19258_9526:
        CheckExternalEvents(cs1, 0x9188);
        // 100D:9188 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 100D:918A cmp byte ptr DS:[0x00F4],0x10
        Alu8.Sub(UInt8[DS, (ushort)0x00F4], (byte)0x10);
        // 100D:918F cmc
        CarryFlag = !CarryFlag;
        // 100D:9190 adc AH,0
        AH = Alu8.Adc(AH, (byte)0x00);
        // 100D:9193 mov AL,0x2D
        AL = (byte)0x2D;
        // 100D:9195 jmp short 0x9171
        goto label_100D_9171_19241_9533;
    }

    public virtual Action unknown_100D_9197_19267(int loadOffset)
    {
    entrydispatcher:
    label_100D_9197_19267_8009:
        CheckExternalEvents(cs1, 0x9197);
        // 100D:9197 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:919A cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:919D jne short 0x91A0
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_91A0_19270, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_919F_1926F_37873:
        CheckExternalEvents(cs1, 0x919F);
        // 100D:919F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_91A0_19270(int loadOffset)
    {
    entrydispatcher:
    label_100D_91A0_19270_7852:
        CheckExternalEvents(cs1, 0x91A0);
        // 100D:91A0 mov word ptr DS:[0x00F0],0
        UInt16[DS, (ushort)0x00F0] = (ushort)0x0000;
        // 100D:91A6 cmp AX,0x000C
        Alu16.Sub(AX, (ushort)0x000C);
        // 100D:91A9 jne short 0x91B8
        if (!ZeroFlag)
        {
            goto label_100D_91B8_19288_7856;
        }
    label_100D_91AB_1927B_34539:
        CheckExternalEvents(cs1, 0x91AB);
        // 100D:91AB test byte ptr DS:[0x10A7],0x10
        Alu8.And(UInt8[DS, (ushort)0x10A7], (byte)0x10);
        // 100D:91B0 je short 0x91B8
        if (ZeroFlag)
        {
            goto label_100D_91B8_19288_7856;
        }
    label_100D_91B2_19282_38289:
        CheckExternalEvents(cs1, 0x91B2);
        // 100D:91B2 mov word ptr DS:[0x00F0],0x000A
        UInt16[DS, (ushort)0x00F0] = (ushort)0x000A;
    label_100D_91B8_19288_7856:
        CheckExternalEvents(cs1, 0x91B8);
        // 100D:91B8 call near 0x9123
        NearCall(cs1, 0x91BB, unknown_100D_9123_191F3);
    label_100D_91BB_1928B_7858:
        CheckExternalEvents(cs1, 0x91BB);
        // 100D:91BB cmp AX,word ptr DS:[0x22A6]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x22A6]);
        // 100D:91BF je short 0x920F
        if (ZeroFlag)
        {
            return unknown_100D_920F_192DF(0x0000);
        }
    label_100D_91C1_19291_7861:
        CheckExternalEvents(cs1, 0x91C1);
        // 100D:91C1 push AX
        Stack.Push16(AX);
        // 100D:91C2 call near 0x98B2
        NearCall(cs1, 0x91C5, unknown_100D_98B2_19982);
    label_100D_91C5_19295_7876:
        CheckExternalEvents(cs1, 0x91C5);
        // 100D:91C5 pop AX
        AX = Stack.Pop16();
        // 100D:91C6 mov word ptr DS:[0x22A6],AX
        UInt16[DS, (ushort)0x22A6] = AX;
        // 100D:91C9 mov SI,AX
        SI = AX;
        // 100D:91CB call near 0x920F
        NearCall(cs1, 0x91CE, unknown_100D_920F_192DF);
    label_100D_91CE_1929E_7884:
        CheckExternalEvents(cs1, 0x91CE);
        // 100D:91CE mov AL,byte ptr DS:[SI+0x22A8]
        AL = UInt8[DS, (ushort)(SI + (short)8872)];
        // 100D:91D2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:91D4 mov word ptr DS:[0x2224],AX
        UInt16[DS, (ushort)0x2224] = AX;
        // 100D:91D7 mov word ptr DS:[0x222C],AX
        UInt16[DS, (ushort)0x222C] = AX;
        // 100D:91DA mov word ptr DS:[0x2234],AX
        UInt16[DS, (ushort)0x2234] = AX;
        // 100D:91DD push DS
        Stack.Push16(DS);
        // 100D:91DE push DS
        Stack.Push16(DS);
        // 100D:91DF pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:91E0 lds SI,word ptr DS:[0xDBB0]
        ushort lxsOffset_100D_91E0_192B0 = (ushort)0xDBB0;
        ushort lxsValue_100D_91E0_192B0 = UInt16[DS, lxsOffset_100D_91E0_192B0];
        ushort lxsSegment_100D_91E0_192B0 = UInt16[DS, (ushort)(lxsOffset_100D_91E0_192B0 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_100D_91E0_192B0);
        DS = unchecked((ushort)lxsSegment_100D_91E0_192B0);
        // 100D:91E4 mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:91E6 add SI,word ptr DS:[BX+SI-2]
        SI = Alu16.Add(SI, UInt16[DS, (ushort)(BX + SI + (sbyte)-2)]);
        // 100D:91E9 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:91EC mov DI,0x1BF0
        DI = (ushort)0x1BF0;
        // 100D:91EF movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:91F0 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:91F1 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:91F2 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:91F3 mov AX,SI
        AX = SI;
        // 100D:91F5 add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:91F8 mov word ptr SS:[0x47CC],AX
        UInt16[SS, (ushort)0x47CC] = AX;
        // 100D:91FC add SI,word ptr DS:[SI]
        SI = Alu16.Add(SI, UInt16[DS, SI]);
        // 100D:91FE mov BX,word ptr DS:[SI]
        BX = UInt16[DS, SI];
        // 100D:9200 mov DI,SI
        DI = SI;
        // 100D:9202 add DI,word ptr DS:[BX+SI-2]
        DI = Alu16.Add(DI, UInt16[DS, (ushort)(BX + SI + (sbyte)-2)]);
        // 100D:9205 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:9206 mov word ptr DS:[0x47CA],SI
        UInt16[DS, (ushort)0x47CA] = SI;
        // 100D:920A mov word ptr DS:[0x47D2],DI
        UInt16[DS, (ushort)0x47D2] = DI;
        // 100D:920E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_920F_192DF(int loadOffset)
    {
    label_100D_920F_192DF_7881:
        CheckExternalEvents(cs1, 0x920F);
        // 100D:920F add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 100D:9212 jmp near 0xC13E
        return unknown_100D_C13E_1C20E(0x0000);
    }

    public virtual Action unknown_100D_9215_192E5(int loadOffset)
    {
    entrydispatcher:
    label_100D_9215_192E5_21350:
        CheckExternalEvents(cs1, 0x9215);
        // 100D:9215 call near 0xD41B
        NearCall(cs1, 0x9218, unknown_100D_D41B_1D4EB);
    label_100D_9218_192E8_21352:
        CheckExternalEvents(cs1, 0x9218);
        // 100D:9218 cmp BP,0x1F0E
        Alu16.Sub(BP, (ushort)0x1F0E);
        // 100D:921C jne short 0x9248
        if (!ZeroFlag)
        {
            goto label_100D_9248_19318_21355;
        }
    label_100D_921E_192EE_25198:
        CheckExternalEvents(cs1, 0x921E);
        // 100D:921E cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:9223 jne short 0x9281
        if (!ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_9225_192F5_25201:
        CheckExternalEvents(cs1, 0x9225);
        // 100D:9225 call near 0x9285
        NearCall(cs1, 0x9228, unknown_100D_9285_19355);
    label_100D_9228_192F8_25203:
        CheckExternalEvents(cs1, 0x9228);
        // 100D:9228 jae short 0x9263
        if (!CarryFlag)
        {
            goto label_100D_9263_19333_25205;
        }
    label_100D_922A_192FA_37274:
        CheckExternalEvents(cs1, 0x922A);
        // 100D:922A cmp CL,0x2F
        Alu8.Sub(CL, (byte)0x2F);
        // 100D:922D je short 0x9282
        if (ZeroFlag)
        {
            goto label_100D_9282_19352_37523;
        }
    label_100D_922F_192FF_37277:
        CheckExternalEvents(cs1, 0x922F);
        // 100D:922F cmp CL,0x0F
        Alu8.Sub(CL, (byte)0x0F);
        // 100D:9232 jae short 0x9240
        if (!CarryFlag)
        {
            goto label_100D_9240_19310_37526;
        }
    label_100D_9234_19304_37280:
        CheckExternalEvents(cs1, 0x9234);
        // 100D:9234 mov AL,0x10
        AL = (byte)0x10;
        // 100D:9236 mul CL
        ushort result_100D_9236_19306 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_9236_19306 >> 8));
        AL = unchecked((byte)result_100D_9236_19306);
        // 100D:9238 add AX,0x0FD8
        AX = Alu16.Add(AX, (ushort)0x0FD8);
        // 100D:923B mov SI,AX
        SI = AX;
        // 100D:923D jmp near word ptr DS:[SI+4]
        switch ((ushort)(UInt16[DS, (ushort)(SI + (sbyte)4)]))
        {
            case 0x92FC:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x92FC))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x9301:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9301))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x9306:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9306))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x930B:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x930B))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x936F:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x936F))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x9373:
                if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9373))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[DS, (ushort)(SI + (sbyte)4)])):X4} at 100D:923D");
        }
    label_100D_9240_19310_37526:
        CheckExternalEvents(cs1, 0x9240);
        // 100D:9240 sub CL,0x0F
        CL = Alu8.Sub(CL, (byte)0x0F);
        // 100D:9243 mov AL,CL
        AL = CL;
        // 100D:9245 jmp near 0x9381
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9381))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9248_19318_21355:
        CheckExternalEvents(cs1, 0x9248);
        // 100D:9248 cmp BP,0x1F7E
        Alu16.Sub(BP, (ushort)0x1F7E);
        // 100D:924C jne short 0x9281
        if (!ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_924E_1931E_28289:
        CheckExternalEvents(cs1, 0x924E);
        // 100D:924E call near 0x92C9
        NearCall(cs1, 0x9251, unknown_100D_92C9_19399);
    label_100D_9251_19321_28291:
        CheckExternalEvents(cs1, 0x9251);
        // 100D:9251 jae short 0x9281
        if (!CarryFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9251");
        }
    label_100D_9263_19333_25205:
        CheckExternalEvents(cs1, 0x9263);
        // 100D:9263 cmp byte ptr DS:[0x000B],1
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x01);
        // 100D:9268 jne short 0x9281
        if (!ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_926A_1933A_32061:
        CheckExternalEvents(cs1, 0x926A);
        // 100D:926A cmp BX,0x0098
        Alu16.Sub(BX, (ushort)0x0098);
        // 100D:926E jae short 0x9281
        if (!CarryFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_9270_19340_40055:
        CheckExternalEvents(cs1, 0x9270);
        // 100D:9270 cmp byte ptr DS:[8],0x21
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0x21);
        // 100D:9275 je short 0x9281
        if (ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_9277_19347_40059:
        CheckExternalEvents(cs1, 0x9277);
        // 100D:9277 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:927C jne short 0x9281
        if (!ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_927E_1934E_40063:
        CheckExternalEvents(cs1, 0x927E);
        // 100D:927E jmp near 0x3F15
        if (JumpDispatcher.Jump(unknown_100D_3F15_13FE5, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9282_19352_37523:
        CheckExternalEvents(cs1, 0x9282);
        // 100D:9282 jmp near 0x42E9
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x42E9))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9285_19355(int loadOffset)
    {
    label_100D_9285_19355_14293:
        CheckExternalEvents(cs1, 0x9285);
        // 100D:9285 cmp BX,0x0098
        Alu16.Sub(BX, (ushort)0x0098);
        // 100D:9289 jae short 0x92C9
        if (!CarryFlag)
        {
            return unknown_100D_92C9_19399(0x0000);
        }
    label_100D_928B_1935B_14913:
        CheckExternalEvents(cs1, 0x928B);
        // 100D:928B mov SI,0x47F8
        SI = (ushort)0x47F8;
        // 100D:928E mov CX,0x0017
        CX = (ushort)0x0017;
    label_100D_9291_19361_14916:
        CheckExternalEvents(cs1, 0x9291);
        // 100D:9291 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9292 mov DI,AX
        DI = AX;
        // 100D:9294 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:9295 mov BP,AX
        BP = AX;
        // 100D:9297 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:9299 js short 0x92A9
        if (SignFlag)
        {
            goto label_100D_92A9_19379_14926;
        }
    label_100D_929B_1936B_14922:
        CheckExternalEvents(cs1, 0x929B);
        // 100D:929B sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 100D:929D cmp DI,-32
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)-32)));
        // 100D:92A0 jb short 0x92A9
        if (CarryFlag)
        {
            goto label_100D_92A9_19379_14926;
        }
    label_100D_92A2_19372_15213:
        CheckExternalEvents(cs1, 0x92A2);
        // 100D:92A2 sub BP,BX
        BP = Alu16.Sub(BP, BX);
        // 100D:92A4 cmp BP,-80
        Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)-80)));
        // 100D:92A7 jae short 0x92EB
        if (!CarryFlag)
        {
            goto label_100D_92EB_193BB_23044;
        }
    label_100D_92A9_19379_14926:
        CheckExternalEvents(cs1, 0x92A9);
        // 100D:92A9 loop 0x9291
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_9291_19361_14916;
        }
    label_100D_92AB_1937B_14937:
        CheckExternalEvents(cs1, 0x92AB);
        // 100D:92AB mov AX,word ptr DS:[0x472D]
        AX = UInt16[DS, (ushort)0x472D];
        // 100D:92AE or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:92B0 je short 0x92C8
        if (ZeroFlag)
        {
            goto label_100D_92C8_19398_14941;
        }
    label_100D_92B2_19382_22838:
        CheckExternalEvents(cs1, 0x92B2);
        // 100D:92B2 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:92B4 cmp AX,0xFFB2
        Alu16.Sub(AX, (ushort)0xFFB2);
        // 100D:92B7 cmc
        CarryFlag = !CarryFlag;
        // 100D:92B8 jae short 0x92C8
        if (!CarryFlag)
        {
            goto label_100D_92C8_19398_14941;
        }
    label_100D_92BA_1938A_22843:
        CheckExternalEvents(cs1, 0x92BA);
        // 100D:92BA mov AX,BX
        AX = BX;
        // 100D:92BC sub AX,word ptr DS:[0x472F]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x472F]);
        // 100D:92C0 cmp AX,0x003C
        Alu16.Sub(AX, (ushort)0x003C);
        // 100D:92C3 jae short 0x92C8
        if (!CarryFlag)
        {
            goto label_100D_92C8_19398_14941;
        }
    label_100D_92C5_19395_25328:
        CheckExternalEvents(cs1, 0x92C5);
        // 100D:92C5 mov CX,0x002F
        CX = (ushort)0x002F;
    label_100D_92C8_19398_14941:
        CheckExternalEvents(cs1, 0x92C8);
        // 100D:92C8 ret near
        return NearRet((ushort)0x0000);
    label_100D_92EB_193BB_23044:
        CheckExternalEvents(cs1, 0x92EB);
        // 100D:92EB sub CX,0x0017
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)23)));
        // 100D:92EE neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:92F0 stc
        CarryFlag = true;
        // 100D:92F1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_92C9_19399(int loadOffset)
    {
    label_100D_92C9_19399_14296:
        CheckExternalEvents(cs1, 0x92C9);
        // 100D:92C9 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:92CB mov CL,byte ptr DS:[0x1152]
        CL = UInt8[DS, (ushort)0x1152];
        // 100D:92CF cmp CL,0xFF
        Alu8.Sub(CL, (byte)0xFF);
        // 100D:92D2 je short 0x9281
        if (ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_92D4_193A4_23128:
        CheckExternalEvents(cs1, 0x92D4);
        // 100D:92D4 mov DI,0x1C0C
        DI = (ushort)0x1C0C;
        // 100D:92D7 call near 0xD6FE
        NearCall(cs1, 0x92DA, unknown_100D_D6FE_1D7CE);
    label_100D_92DA_193AA_23131:
        CheckExternalEvents(cs1, 0x92DA);
        // 100D:92DA jb short 0x9281
        if (CarryFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_92DC_193AC_23133:
        CheckExternalEvents(cs1, 0x92DC);
        // 100D:92DC mov CL,byte ptr DS:[0x1153]
        CL = UInt8[DS, (ushort)0x1153];
        // 100D:92E0 cmp CL,0xFF
        Alu8.Sub(CL, (byte)0xFF);
        // 100D:92E3 je short 0x9281
        if (ZeroFlag)
        {
            return unknown_100D_9281_19351(0x0000);
        }
    label_100D_92E5_193B5_30329:
        CheckExternalEvents(cs1, 0x92E5);
        // 100D:92E5 mov DI,0x1C1A
        DI = (ushort)0x1C1A;
        // 100D:92E8 jmp near 0xD6FE
        return unknown_100D_D6FE_1D7CE(0x0000);
    }

    public virtual Action unknown_100D_93DF_194AF(int loadOffset)
    {
    label_100D_93DF_194AF_15479:
        CheckExternalEvents(cs1, 0x93DF);
        // 100D:93DF mov CL,AL
        CL = AL;
        // 100D:93E1 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:93E3 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:93E5 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:93E7 mov word ptr DS:[0x47BE],AX
        UInt16[DS, (ushort)0x47BE] = AX;
        // 100D:93EA mov AX,1
        AX = (ushort)0x0001;
        // 100D:93ED shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:93EF or word ptr DS:[0x000E],AX
        UInt16[DS, (ushort)0x000E] = Alu16.Or(UInt16[DS, (ushort)0x000E], AX);
        // 100D:93F3 or word ptr DS:[0x0014],AX
        UInt16[DS, (ushort)0x0014] = Alu16.Or(UInt16[DS, (ushort)0x0014], AX);
        // 100D:93F7 mov AL,0x10
        AL = (byte)0x10;
        // 100D:93F9 mul CL
        ushort result_100D_93F9_194C9 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_93F9_194C9 >> 8));
        AL = unchecked((byte)result_100D_93F9_194C9);
        // 100D:93FB add AX,0x0FD8
        AX = Alu16.Add(AX, (ushort)0x0FD8);
        // 100D:93FE mov word ptr DS:[0x47A2],AX
        UInt16[DS, (ushort)0x47A2] = AX;
        // 100D:9401 mov SI,AX
        SI = AX;
        // 100D:9403 mov word ptr DS:[0x47BA],0
        UInt16[DS, (ushort)0x47BA] = (ushort)0x0000;
        // 100D:9409 call near 0x90BD
        NearCall(cs1, 0x940C, unknown_100D_90BD_1918D);
    label_100D_940C_194DC_15574:
        CheckExternalEvents(cs1, 0x940C);
        // 100D:940C mov word ptr DS:[0x47B6],0
        UInt16[DS, (ushort)0x47B6] = (ushort)0x0000;
        // 100D:9412 mov byte ptr DS:[0x47C2],0x80
        UInt8[DS, (ushort)0x47C2] = (byte)0x80;
        // 100D:9417 mov byte ptr DS:[0x0019],0
        UInt8[DS, (ushort)0x0019] = (byte)0x00;
        // 100D:941C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_941D_194ED(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_941D_194ED_37472;

    label_100D_4AAD_14B7D_40944:
        CheckExternalEvents(cs1, 0x4AAD);
        // 100D:4AAD xor byte ptr DS:[0x4728],0x80
        UInt8[DS, (ushort)0x4728] = Alu8.Xor(UInt8[DS, (ushort)0x4728], (byte)0x80);
        // 100D:4AB2 js short 0x4AB7
        if (SignFlag)
        {
            goto label_100D_4AB7_14B87_40949;
        }
    label_100D_4AB4_14B84_40951:
        CheckExternalEvents(cs1, 0x4AB4);
        // 100D:4AB4 call near 0x49D4
        NearCall(cs1, 0x4AB7, unknown_100D_49D4_14AA4);
    label_100D_4AB7_14B87_40949:
        CheckExternalEvents(cs1, 0x4AB7);
        // 100D:4AB7 ret near
        return NearRet((ushort)0x0000);
    label_100D_941D_194ED_37472:
        CheckExternalEvents(cs1, 0x941D);
        // 100D:941D cmp byte ptr DS:[0x47A9],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A9], (byte)0x00);
        // 100D:9422 je short 0x9427
        if (ZeroFlag)
        {
            goto label_100D_9427_194F7_37475;
        }
    label_100D_9424_194F4_37477:
        CheckExternalEvents(cs1, 0x9424);
        // 100D:9424 jmp near 0x2993
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x2993))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9427_194F7_37475:
        CheckExternalEvents(cs1, 0x9427);
        // 100D:9427 call near 0xD41B
        NearCall(cs1, 0x942A, unknown_100D_D41B_1D4EB);
    label_100D_942A_194FA_40920:
        CheckExternalEvents(cs1, 0x942A);
        // 100D:942A cmp BP,0x20C2
        Alu16.Sub(BP, (ushort)0x20C2);
        // 100D:942E jne short 0x9436
        if (!ZeroFlag)
        {
            goto label_100D_9436_19506_40923;
        }
    label_100D_9430_19500_40925:
        CheckExternalEvents(cs1, 0x9430);
        VerifySpeculativeEntryOrFail(cs1, 0x9430, [(byte)0xE8, (byte)0xB7, (byte)0x3E]);
        // 100D:9430 call near 0xD2EA
        NearCall(cs1, 0x9433, unknown_100D_D2EA_1D3BA);
        throw FailAsUntested("Call at 100D:9430 returned to 100D:9433, but no continuation was observed during discovery.");
    label_100D_9436_19506_40923:
        CheckExternalEvents(cs1, 0x9436);
        // 100D:9436 test byte ptr DS:[0x11C9],3
        Alu8.And(UInt8[DS, (ushort)0x11C9], (byte)0x03);
        // 100D:943B je short 0x9447
        if (ZeroFlag)
        {
            goto label_100D_9447_19517_40929;
        }
    label_100D_943D_1950D_40931:
        CheckExternalEvents(cs1, 0x943D);
        // 100D:943D cmp byte ptr DS:[0x11CA],0
        Alu8.Sub(UInt8[DS, (ushort)0x11CA], (byte)0x00);
        // 100D:9442 jne short 0x9447
        if (!ZeroFlag)
        {
            goto label_100D_9447_19517_40929;
        }
    label_100D_9444_19514_40940:
        CheckExternalEvents(cs1, 0x9444);
        // 100D:9444 jmp near 0x4AAD
        goto label_100D_4AAD_14B7D_40944;
    label_100D_9447_19517_40929:
        CheckExternalEvents(cs1, 0x9447);
        VerifySpeculativeEntryOrFail(cs1, 0x9447, [(byte)0x83, (byte)0x3E, (byte)0x9E, (byte)0x47, (byte)0x00]);
        // 100D:9447 cmp word ptr DS:[0x479E],0
        Alu16.Sub(UInt16[DS, (ushort)0x479E], unchecked((ushort)unchecked((short)(sbyte)0)));
        VerifySpeculativeEntryOrFail(cs1, 0x944C, [(byte)0x75, (byte)0x0A]);
        // 100D:944C jne short 0x9458
        if (!ZeroFlag)
        {
            goto label_100D_9458_19528_40935;
        }
    label_100D_944E_1951E_40937:
        CheckExternalEvents(cs1, 0x944E);
        VerifySpeculativeEntryOrFail(cs1, 0x944E, [(byte)0x53]);
        // 100D:944E push BX
        Stack.Push16(BX);
        VerifySpeculativeEntryOrFail(cs1, 0x944F, [(byte)0x52]);
        // 100D:944F push DX
        Stack.Push16(DX);
        VerifySpeculativeEntryOrFail(cs1, 0x9450, [(byte)0xE8, (byte)0x5E, (byte)0x99]);
        // 100D:9450 call near 0x2DB1
        NearCall(cs1, 0x9453, unknown_100D_2DB1_12E81);
        throw FailAsUntested("Call at 100D:9450 returned to 100D:9453, but no continuation was observed during discovery.");
    label_100D_9458_19528_40935:
        CheckExternalEvents(cs1, 0x9458);
        VerifySpeculativeEntryOrFail(cs1, 0x9458, [(byte)0xE9, (byte)0x87, (byte)0x3E]);
        // 100D:9458 jmp near 0xD2E2
        if (JumpDispatcher.Jump(unknown_100D_D2E2_1D3B2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_945B_1952B(int loadOffset)
    {
    entrydispatcher:
    label_100D_945B_1952B_38371:
        CheckExternalEvents(cs1, 0x945B);
        // 100D:945B cmp word ptr DS:[0x479E],0
        Alu16.Sub(UInt16[DS, (ushort)0x479E], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:9460 jne short 0x9468
        if (!ZeroFlag)
        {
            goto label_100D_9468_19538_38374;
        }
    label_100D_9462_19532_38376:
        CheckExternalEvents(cs1, 0x9462);
        VerifySpeculativeEntryOrFail(cs1, 0x9462, [(byte)0xA1, (byte)0xC4, (byte)0x47]);
        // 100D:9462 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        VerifySpeculativeEntryOrFail(cs1, 0x9465, [(byte)0xE9, (byte)0x42, (byte)0xFF]);
        // 100D:9465 jmp near 0x93AA
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x93AA))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9468_19538_38374:
        CheckExternalEvents(cs1, 0x9468);
        // 100D:9468 call near 0xD41B
        NearCall(cs1, 0x946B, unknown_100D_D41B_1D4EB);
    label_100D_946B_1953B_38383:
        CheckExternalEvents(cs1, 0x946B);
        // 100D:946B cmp BP,0x1FFE
        Alu16.Sub(BP, (ushort)0x1FFE);
        // 100D:946F jne short 0x9472
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x9472))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9471_19541_38387:
        CheckExternalEvents(cs1, 0x9471);
        VerifySpeculativeEntryOrFail(cs1, 0x9471, [(byte)0xC3]);
        // 100D:9471 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_94F3_195C3(int loadOffset)
    {
    label_100D_94F3_195C3_3157:
        CheckExternalEvents(cs1, 0x94F3);
        // 100D:94F3 cmp word ptr DS:[0x47C4],0x0010
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:94F8 jae short 0x9532
        if (!CarryFlag)
        {
            goto label_100D_9532_19602_3160;
        }
    label_100D_94FA_195CA_15630:
        CheckExternalEvents(cs1, 0x94FA);
        // 100D:94FA push SI
        Stack.Push16(SI);
        // 100D:94FB mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:94FF mov AL,byte ptr DS:[SI+0x0F]
        AL = UInt8[DS, (ushort)(SI + (sbyte)15)];
        // 100D:9502 mov byte ptr DS:[0x0018],AL
        UInt8[DS, (ushort)0x0018] = AL;
        // 100D:9505 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:9507 mov AX,word ptr DS:[SI+8]
        AX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:950A jne short 0x950F
        if (!ZeroFlag)
        {
            goto label_100D_950F_195DF_15640;
        }
    label_100D_950C_195DC_15638:
        CheckExternalEvents(cs1, 0x950C);
        // 100D:950C mov AX,word ptr DS:[SI+0x0A]
        AX = UInt16[DS, (ushort)(SI + (sbyte)10)];
    label_100D_950F_195DF_15640:
        CheckExternalEvents(cs1, 0x950F);
        // 100D:950F sub AX,word ptr DS:[2]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)0x0002]);
        // 100D:9513 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 100D:9515 mov word ptr DS:[0x0016],AX
        UInt16[DS, (ushort)0x0016] = AX;
        // 100D:9518 pop SI
        SI = Stack.Pop16();
        // 100D:9519 cmp byte ptr DS:[0x002A],0x64
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x64);
        // 100D:951E jae short 0x9532
        if (!CarryFlag)
        {
            goto label_100D_9532_19602_3160;
        }
    label_100D_9520_195F0_15646:
        CheckExternalEvents(cs1, 0x9520);
        // 100D:9520 cmp word ptr DS:[0x47C4],9
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)9)));
        // 100D:9525 jae short 0x9532
        if (!CarryFlag)
        {
            goto label_100D_9532_19602_3160;
        }
    label_100D_9527_195F7_15649:
        CheckExternalEvents(cs1, 0x9527);
        // 100D:9527 mov DI,word ptr DS:[0x11DB]
        DI = UInt16[DS, (ushort)0x11DB];
        // 100D:952B or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:952D je short 0x9532
        if (ZeroFlag)
        {
            goto label_100D_9532_19602_3160;
        }
    label_100D_952F_195FF_35743:
        CheckExternalEvents(cs1, 0x952F);
        // 100D:952F call near 0x2E98
        NearCall(cs1, 0x9532, unknown_100D_2E98_12F68);
    label_100D_9532_19602_3160:
        CheckExternalEvents(cs1, 0x9532);
        // 100D:9532 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9556_19626(int loadOffset)
    {
    entrydispatcher:
    label_100D_9556_19626_25969:
        CheckExternalEvents(cs1, 0x9556);
        // 100D:9556 and byte ptr DS:[SI+0x0F],0xBF
        UInt8[DS, (ushort)(SI + (sbyte)15)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0xBF);
        // 100D:955A mov BX,2
        BX = (ushort)0x0002;
        // 100D:955D call near 0x956D
        NearCall(cs1, 0x9560, unknown_100D_956D_1963D);
    label_100D_9560_19630_25973:
        CheckExternalEvents(cs1, 0x9560);
        // 100D:9560 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:9563 mov AX,0xFFFE
        AX = (ushort)0xFFFE;
        // 100D:9566 rol AX,CL
        AX = Alu16.Rol(AX, CL);
        // 100D:9568 and word ptr DS:[0x0010],AX
        UInt16[DS, (ushort)0x0010] = Alu16.And(UInt16[DS, (ushort)0x0010], AX);
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x956C))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_956D_1963D(int loadOffset)
    {
    label_100D_956D_1963D_23099:
        CheckExternalEvents(cs1, 0x956D);
        // 100D:956D mov BP,BX
        BP = BX;
        // 100D:956F xor BP,2
        BP = Alu16.Xor(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:9572 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:9575 sub AX,word ptr SS:[BP+SI+8]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + SI + (sbyte)8)]);
        // 100D:9578 cmp AX,2
        Alu16.Sub(AX, (ushort)0x0002);
        // 100D:957B jb short 0x9583
        if (CarryFlag)
        {
            goto label_100D_9583_19653_23109;
        }
    label_100D_957D_1964D_23106:
        CheckExternalEvents(cs1, 0x957D);
        // 100D:957D mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:9580 mov word ptr DS:[BX+SI+8],AX
        UInt16[DS, (ushort)(BX + SI + (sbyte)8)] = AX;
    label_100D_9583_19653_23109:
        CheckExternalEvents(cs1, 0x9583);
        // 100D:9583 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9655_19725(int loadOffset)
    {
    entrydispatcher:
    label_100D_9655_19725_25981:
        CheckExternalEvents(cs1, 0x9655);
        // 100D:9655 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:9658 mov DI,0x1153
        DI = (ushort)0x1153;
        // 100D:965B mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:965D cmp byte ptr DS:[DI],CL
        Alu8.Sub(UInt8[DS, DI], CL);
        // 100D:965F je short 0x9669
        if (ZeroFlag)
        {
            goto label_100D_9669_19739_25993;
        }
    label_100D_9661_19731_25987:
        CheckExternalEvents(cs1, 0x9661);
        // 100D:9661 dec DI
        DI = Alu16.Dec(DI);
        // 100D:9662 cmp byte ptr DS:[DI],CL
        Alu8.Sub(UInt8[DS, DI], CL);
        // 100D:9664 jne short 0x961A
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x961A))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9666_19736_25991:
        CheckExternalEvents(cs1, 0x9666);
        // 100D:9666 xchg AL,byte ptr DS:[DI+1]
        ushort xchgOffset_100D_9666_19736 = unchecked((ushort)(DI + (sbyte)1));
        byte temp_100D_9666_19736 = AL;
        AL = UInt8[DS, xchgOffset_100D_9666_19736];
        UInt8[DS, xchgOffset_100D_9666_19736] = unchecked((byte)temp_100D_9666_19736);
    label_100D_9669_19739_25993:
        CheckExternalEvents(cs1, 0x9669);
        // 100D:9669 mov byte ptr DS:[DI],AL
        UInt8[DS, DI] = AL;
        // 100D:966B mov byte ptr DS:[DI+0x10D0],0
        UInt8[DS, (ushort)(DI + (short)4304)] = (byte)0x00;
        // 100D:9670 jmp near 0xD763
        return unknown_100D_D763_1D833(0x0000);
    }

    public virtual Action unknown_100D_9673_19743(int loadOffset)
    {
    entrydispatcher:
    label_100D_9673_19743_23116:
        CheckExternalEvents(cs1, 0x9673);
        // 100D:9673 mov CL,byte ptr DS:[SI+0x0E]
        CL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:9676 mov DI,0x1152
        DI = (ushort)0x1152;
        // 100D:9679 cmp byte ptr DS:[DI],CL
        Alu8.Sub(UInt8[DS, DI], CL);
        // 100D:967B je short 0x961A
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x961A))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_967D_1974D_23121:
        CheckExternalEvents(cs1, 0x967D);
        // 100D:967D cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:9680 je short 0x96AB
        if (ZeroFlag)
        {
            goto label_100D_96AB_1977B_23124;
        }
    label_100D_9682_19752_30322:
        CheckExternalEvents(cs1, 0x9682);
        // 100D:9682 inc DI
        DI = Alu16.Inc(DI);
        // 100D:9683 cmp byte ptr DS:[DI],CL
        Alu8.Sub(UInt8[DS, DI], CL);
        // 100D:9685 je short 0x961A
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x961A))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_9687_19757_30326:
        CheckExternalEvents(cs1, 0x9687);
        // 100D:9687 cmp byte ptr DS:[DI],0xFF
        Alu8.Sub(UInt8[DS, DI], (byte)0xFF);
        // 100D:968A je short 0x96AB
        if (ZeroFlag)
        {
            goto label_100D_96AB_1977B_23124;
        }
    label_100D_968C_1975C_33305:
        CheckExternalEvents(cs1, 0x968C);
        // 100D:968C dec DI
        DI = Alu16.Dec(DI);
        // 100D:968D push CX
        Stack.Push16(CX);
        // 100D:968E mov CL,byte ptr DS:[DI]
        CL = UInt8[DS, DI];
        // 100D:9690 mov AL,0x10
        AL = (byte)0x10;
        // 100D:9692 mul CL
        ushort result_100D_9692_19762 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_9692_19762 >> 8));
        AL = unchecked((byte)result_100D_9692_19762);
        // 100D:9694 add AX,0x0FD8
        AX = Alu16.Add(AX, (ushort)0x0FD8);
        // 100D:9697 mov SI,AX
        SI = AX;
        // 100D:9699 mov AL,byte ptr DS:[SI+0x0E]
        AL = UInt8[DS, (ushort)(SI + (sbyte)14)];
        // 100D:969C add AL,0x64
        AL = Alu8.Add(AL, (byte)0x64);
        // 100D:969E mov byte ptr DS:[0x0023],AL
        UInt8[DS, (ushort)0x0023] = AL;
        // 100D:96A1 call near 0x9556
        NearCall(cs1, 0x96A4, unknown_100D_9556_19626);
    label_100D_96A4_19774_33317:
        CheckExternalEvents(cs1, 0x96A4);
        // 100D:96A4 pop CX
        CX = Stack.Pop16();
        // 100D:96A5 inc DI
        DI = Alu16.Inc(DI);
        // 100D:96A6 mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:96A8 mov byte ptr DS:[DI-1],AL
        UInt8[DS, (ushort)(DI + (sbyte)-1)] = AL;
    label_100D_96AB_1977B_23124:
        CheckExternalEvents(cs1, 0x96AB);
        // 100D:96AB mov byte ptr DS:[DI],CL
        UInt8[DS, DI] = CL;
        // 100D:96AD mov byte ptr DS:[DI+0x10D0],0x10
        UInt8[DS, (ushort)(DI + (short)4304)] = (byte)0x10;
        // 100D:96B2 jmp near 0xD763
        return unknown_100D_D763_1D833(0x0000);
    }

    public virtual Action unknown_100D_96B5_19785(int loadOffset)
    {
    label_100D_96B5_19785_3147:
        CheckExternalEvents(cs1, 0x96B5);
        // 100D:96B5 push word ptr DS:[0x47C4]
        Stack.Push16(UInt16[DS, (ushort)0x47C4]);
        // 100D:96B9 push word ptr DS:[0x47C2]
        Stack.Push16(UInt16[DS, (ushort)0x47C2]);
        // 100D:96BD mov word ptr DS:[0x47C4],0x0010
        UInt16[DS, (ushort)0x47C4] = (ushort)0x0010;
        // 100D:96C3 mov byte ptr DS:[0x47C2],0x80
        UInt8[DS, (ushort)0x47C2] = (byte)0x80;
        // 100D:96C8 mov SI,word ptr DS:[0xAB84]
        SI = UInt16[DS, (ushort)0xAB84];
        // 100D:96CC call near 0x9F9E
        NearCall(cs1, 0x96CF, unknown_100D_9F9E_1A06E);
    label_100D_96CF_1979F_3294:
        CheckExternalEvents(cs1, 0x96CF);
        // 100D:96CF pop word ptr DS:[0x47C2]
        ushort popStackCheck_100D_96CF_1979F = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_96CF_1979F = UInt16[DS, (ushort)0x47C2];
        ushort poppedValue_100D_96CF_1979F = Stack.Pop16();
        UInt16[DS, (ushort)0x47C2] = unchecked((ushort)poppedValue_100D_96CF_1979F);
        // 100D:96D3 pop word ptr DS:[0x47C4]
        ushort popStackCheck_100D_96D3_197A3 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_96D3_197A3 = UInt16[DS, (ushort)0x47C4];
        ushort poppedValue_100D_96D3_197A3 = Stack.Pop16();
        UInt16[DS, (ushort)0x47C4] = unchecked((ushort)poppedValue_100D_96D3_197A3);
        // 100D:96D7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_96D8_197A8(int loadOffset)
    {
    entrydispatcher:
    label_100D_96D8_197A8_27194:
        CheckExternalEvents(cs1, 0x96D8);
        // 100D:96D8 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:96DB inc byte ptr DS:[0x47DC]
        UInt8[DS, (ushort)0x47DC] = Alu8.Inc(UInt8[DS, (ushort)0x47DC]);
        // 100D:96DF mov AX,0x0010
        AX = (ushort)0x0010;
        // 100D:96E2 call near 0x9702
        NearCall(cs1, 0x96E5, unknown_100D_9702_197D2);
    label_100D_96E5_197B5_27203:
        CheckExternalEvents(cs1, 0x96E5);
        // 100D:96E5 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x96EB))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_96F1_197C1(int loadOffset)
    {
    entrydispatcher:
    label_100D_96F1_197C1_19848:
        CheckExternalEvents(cs1, 0x96F1);
        // 100D:96F1 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:96F4 cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:96F6 jne short 0x9702
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_9702_197D2, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_96F8_197C8_22920:
        CheckExternalEvents(cs1, 0x96F8);
        // 100D:96F8 mov SI,word ptr DS:[0x4756]
        SI = UInt16[DS, (ushort)0x4756];
        // 100D:96FC call near 0x31F6
        NearCall(cs1, 0x96FF, unknown_100D_31F6_132C6);
    label_100D_96FF_197CF_23042:
        CheckExternalEvents(cs1, 0x96FF);
        // 100D:96FF mov AX,0x000E
        AX = (ushort)0x000E;
        if (JumpDispatcher.Jump(unknown_100D_9702_197D2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9702_197D2(int loadOffset)
    {
    entrydispatcher:
    label_100D_9702_197D2_19852:
        CheckExternalEvents(cs1, 0x9702);
        // 100D:9702 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9704 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9706 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9708 or AX,4
        AX = Alu16.Or(AX, (ushort)0x0004);
        if (JumpDispatcher.Jump(unknown_100D_970B_197DB, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_970B_197DB(int loadOffset)
    {
    entrydispatcher:
    label_100D_970B_197DB_19857:
        CheckExternalEvents(cs1, 0x970B);
        // 100D:970B mov SI,AX
        SI = AX;
        // 100D:970D shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:970F mov SI,word ptr DS:[SI-21898]
        SI = UInt16[DS, (ushort)(SI + (short)-21898)];
        // 100D:9713 call near 0x9F40
        NearCall(cs1, 0x9716, unknown_100D_9F40_1A010);
    label_100D_9716_197E6_19861:
        CheckExternalEvents(cs1, 0x9716);
        // 100D:9716 jmp near 0x9F8B
        if (JumpDispatcher.Jump(unknown_100D_9F8B_1A05B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_9719_197E9(int loadOffset)
    {
    label_100D_9719_197E9_24303:
        CheckExternalEvents(cs1, 0x9719);
        // 100D:9719 cmp byte ptr DS:[0x004C],0
        Alu8.Sub(UInt8[DS, (ushort)0x004C], (byte)0x00);
        // 100D:971E js short 0x972C
        if (SignFlag)
        {
            goto label_100D_972C_197FC_24322;
        }
    label_100D_9720_197F0_24306:
        CheckExternalEvents(cs1, 0x9720);
        // 100D:9720 mov SI,word ptr DS:[0x46EF]
        SI = UInt16[DS, (ushort)0x46EF];
        // 100D:9724 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:9727 mov AL,0x0F
        AL = (byte)0x0F;
        // 100D:9729 call near 0x2A51
        NearCall(cs1, 0x972C, unknown_100D_2A51_12B21);
    label_100D_972C_197FC_24322:
        CheckExternalEvents(cs1, 0x972C);
        // 100D:972C call near 0x9F82
        NearCall(cs1, 0x972F, unknown_100D_9F82_1A052);
    label_100D_972F_197FF_24324:
        CheckExternalEvents(cs1, 0x972F);
        // 100D:972F mov word ptr DS:[0x47C4],0x000F
        UInt16[DS, (ushort)0x47C4] = (ushort)0x000F;
        // 100D:9735 mov word ptr DS:[0x47A2],0x10C8
        UInt16[DS, (ushort)0x47A2] = (ushort)0x10C8;
        // 100D:973B call near 0xA1C4
        NearCall(cs1, 0x973E, unknown_100D_A1C4_1A294);
    label_100D_973E_1980E_24328:
        CheckExternalEvents(cs1, 0x973E);
        // 100D:973E mov SI,word ptr DS:[0x47BA]
        SI = UInt16[DS, (ushort)0x47BA];
        // 100D:9742 inc SI
        SI = Alu16.Inc(SI);
        // 100D:9743 je short 0x9748
        if (ZeroFlag)
        {
            goto label_100D_9748_19818_24335;
        }
    label_100D_9745_19815_24332:
        CheckExternalEvents(cs1, 0x9745);
        // 100D:9745 dec SI
        SI = Alu16.Dec(SI);
        // 100D:9746 jne short 0x974C
        if (!ZeroFlag)
        {
            goto label_100D_974C_1981C_24337;
        }
    label_100D_9748_19818_24335:
        CheckExternalEvents(cs1, 0x9748);
        // 100D:9748 mov SI,word ptr DS:[0xAB6A]
        SI = UInt16[DS, (ushort)0xAB6A];
    label_100D_974C_1981C_24337:
        CheckExternalEvents(cs1, 0x974C);
        // 100D:974C mov byte ptr DS:[0x47C2],0x20
        UInt8[DS, (ushort)0x47C2] = (byte)0x20;
        // 100D:9751 call near 0x9F9E
        NearCall(cs1, 0x9754, unknown_100D_9F9E_1A06E);
    label_100D_9754_19824_24395:
        CheckExternalEvents(cs1, 0x9754);
        // 100D:9754 mov word ptr DS:[0x47BA],SI
        UInt16[DS, (ushort)0x47BA] = SI;
        // 100D:9758 jae short 0x9760
        if (!CarryFlag)
        {
            goto label_100D_9760_19830_24398;
        }
    label_100D_975A_1982A_24965:
        CheckExternalEvents(cs1, 0x975A);
        // 100D:975A mov word ptr DS:[0x47BA],0
        UInt16[DS, (ushort)0x47BA] = (ushort)0x0000;
    label_100D_9760_19830_24398:
        CheckExternalEvents(cs1, 0x9760);
        // 100D:9760 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9761_19831(int loadOffset)
    {
    entrydispatcher:
    label_100D_9761_19831_28407:
        CheckExternalEvents(cs1, 0x9761);
        // 100D:9761 mov word ptr DS:[0x47C4],AX
        UInt16[DS, (ushort)0x47C4] = AX;
        // 100D:9764 cmp AL,0x0E
        Alu8.Sub(AL, (byte)0x0E);
        // 100D:9766 jne short 0x9772
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:9766");
        }
    label_100D_9772_19842_28411:
        CheckExternalEvents(cs1, 0x9772);
        // 100D:9772 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9774 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9776 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9778 or AX,7
        AX = Alu16.Or(AX, (ushort)0x0007);
        // 100D:977B mov SI,AX
        SI = AX;
        // 100D:977D shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 100D:977F mov SI,word ptr DS:[SI-21898]
        SI = UInt16[DS, (ushort)(SI + (short)-21898)];
        // 100D:9783 call near 0x9F40
        NearCall(cs1, 0x9786, unknown_100D_9F40_1A010);
    label_100D_9786_19856_28420:
        CheckExternalEvents(cs1, 0x9786);
        // 100D:9786 mov byte ptr DS:[0x47C2],0x80
        UInt8[DS, (ushort)0x47C2] = (byte)0x80;
        // 100D:978B jmp near 0x9F9E
        if (JumpDispatcher.Jump(unknown_100D_9F9E_1A06E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_978E_1985E(int loadOffset)
    {
    entrydispatcher:
    label_100D_978E_1985E_7923:
        CheckExternalEvents(cs1, 0x978E);
        // 100D:978E call near 0x4ACA
        NearCall(cs1, 0x9791, unknown_100D_4ACA_14B9A);
    label_100D_9791_19861_7928:
        CheckExternalEvents(cs1, 0x9791);
        // 100D:9791 mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:9794 cmp AX,0xFFFF
        Alu16.Sub(AX, (ushort)0xFFFF);
        // 100D:9797 je short 0x97CE
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:9797");
        }
    label_100D_9799_19869_7932:
        CheckExternalEvents(cs1, 0x9799);
        // 100D:9799 call near 0x91A0
        NearCall(cs1, 0x979C, unknown_100D_91A0_19270);
    label_100D_979C_1986C_7934:
        CheckExternalEvents(cs1, 0x979C);
        // 100D:979C call near 0x9908
        NearCall(cs1, 0x979F, unknown_100D_9908_199D8);
    label_100D_979F_1986F_7996:
        CheckExternalEvents(cs1, 0x979F);
        // 100D:979F cmp word ptr DS:[0x479E],0
        Alu16.Sub(UInt16[DS, (ushort)0x479E], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:97A4 je short 0x97AC
        if (ZeroFlag)
        {
            goto label_100D_97AC_1987C_7999;
        }
    label_100D_97A6_19876_15737:
        CheckExternalEvents(cs1, 0x97A6);
        // 100D:97A6 mov SI,0x1BE2
        SI = (ushort)0x1BE2;
        // 100D:97A9 call near 0xC477
        NearCall(cs1, 0x97AC, unknown_100D_C477_1C547);
    label_100D_97AC_1987C_7999:
        CheckExternalEvents(cs1, 0x97AC);
        // 100D:97AC mov SI,word ptr DS:[0x47C8]
        SI = UInt16[DS, (ushort)0x47C8];
        // 100D:97B0 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:97B2 je short 0x97C8
        if (ZeroFlag)
        {
            goto label_100D_97C8_19898_8251;
        }
    label_100D_97B4_19884_8003:
        CheckExternalEvents(cs1, 0x97B4);
        // 100D:97B4 mov word ptr DS:[0x4540],0
        UInt16[DS, (ushort)0x4540] = (ushort)0x0000;
        // 100D:97BA call near 0x9BAC
        NearCall(cs1, 0x97BD, unknown_100D_9BAC_19C7C);
    label_100D_97BD_1988D_8248:
        CheckExternalEvents(cs1, 0x97BD);
        // 100D:97BD cmp word ptr DS:[0x479E],0x223C
        Alu16.Sub(UInt16[DS, (ushort)0x479E], (ushort)0x223C);
        // 100D:97C3 jne short 0x97C8
        if (!ZeroFlag)
        {
            goto label_100D_97C8_19898_8251;
        }
    label_100D_97C5_19895_31484:
        CheckExternalEvents(cs1, 0x97C5);
        // 100D:97C5 call near 0x9025
        NearCall(cs1, 0x97C8, unknown_100D_9025_190F5);
    label_100D_97C8_19898_8251:
        CheckExternalEvents(cs1, 0x97C8);
        // 100D:97C8 call near 0xC0F4
        NearCall(cs1, 0x97CB, unknown_100D_C0F4_1C1C4);
    label_100D_97CB_1989B_8253:
        CheckExternalEvents(cs1, 0x97CB);
        // 100D:97CB jmp near 0xC4DD
        return unknown_100D_C4DD_1C5AD(0x0000);
    }

    public virtual Action unknown_100D_97CF_1989F(int loadOffset)
    {
    entrydispatcher:
    label_100D_97CF_1989F_16250:
        CheckExternalEvents(cs1, 0x97CF);
        // 100D:97CF call near 0xA7A5
        NearCall(cs1, 0x97D2, unknown_100D_A7A5_1A875);
    label_100D_97D2_198A2_16252:
        CheckExternalEvents(cs1, 0x97D2);
        // 100D:97D2 cmp word ptr DS:[0x47C4],-1
        Alu16.Sub(UInt16[DS, (ushort)0x47C4], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:97D7 je short 0x97CE
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:97D7");
        }
    label_100D_97D9_198A9_16255:
        CheckExternalEvents(cs1, 0x97D9);
        // 100D:97D9 mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:97DD or byte ptr DS:[SI+0x0F],0x20
        UInt8[DS, (ushort)(SI + (sbyte)15)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x20);
        // 100D:97E1 and byte ptr DS:[SI+0x0F],0xFB
        UInt8[DS, (ushort)(SI + (sbyte)15)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0xFB);
        // 100D:97E5 mov word ptr DS:[0x47E1],0
        UInt16[DS, (ushort)0x47E1] = (ushort)0x0000;
        // 100D:97EB cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:97F0 je short 0x980C
        if (ZeroFlag)
        {
            goto label_100D_980C_198DC_16262;
        }
    label_100D_97F2_198C2_27228:
        CheckExternalEvents(cs1, 0x97F2);
        // 100D:97F2 call near 0x8C8A
        NearCall(cs1, 0x97F5, unknown_100D_8C8A_18D5A);
    label_100D_97F5_198C5_27230:
        CheckExternalEvents(cs1, 0x97F5);
        // 100D:97F5 mov BP,0x98B2
        BP = (ushort)0x98B2;
        // 100D:97F8 call near 0xC097
        NearCall(cs1, 0x97FB, unknown_100D_C097_1C167);
    label_100D_97FB_198CB_27233:
        CheckExternalEvents(cs1, 0x97FB);
        // 100D:97FB xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:97FD xchg AL,byte ptr DS:[0x11CA]
        ushort xchgOffset_100D_97FD_198CD = (ushort)0x11CA;
        byte temp_100D_97FD_198CD = AL;
        AL = UInt8[DS, xchgOffset_100D_97FD_198CD];
        UInt8[DS, xchgOffset_100D_97FD_198CD] = unchecked((byte)temp_100D_97FD_198CD);
        // 100D:9801 push AX
        Stack.Push16(AX);
        // 100D:9802 call near 0x2FFB
        NearCall(cs1, 0x9805, unknown_100D_2FFB_130CB);
    label_100D_9805_198D5_27238:
        CheckExternalEvents(cs1, 0x9805);
        // 100D:9805 pop AX
        AX = Stack.Pop16();
        // 100D:9806 mov byte ptr DS:[0x11CA],AL
        UInt8[DS, (ushort)0x11CA] = AL;
        // 100D:9809 jmp near 0x4ABE
        if (JumpDispatcher.Jump(unknown_100D_4ABE_14B8E, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_980C_198DC_16262:
        CheckExternalEvents(cs1, 0x980C);
        // 100D:980C call near 0x8C8A
        NearCall(cs1, 0x980F, unknown_100D_8C8A_18D5A);
    label_100D_980F_198DF_16264:
        CheckExternalEvents(cs1, 0x980F);
        // 100D:980F cmp byte ptr DS:[0x47A4],0
        Alu8.Sub(UInt8[DS, (ushort)0x47A4], (byte)0x00);
        // 100D:9814 mov SI,word ptr DS:[0x47A2]
        SI = UInt16[DS, (ushort)0x47A2];
        // 100D:9818 js short 0x9849
        if (SignFlag)
        {
            goto label_100D_9849_19919_16268;
        }
    label_100D_981A_198EA_25111:
        CheckExternalEvents(cs1, 0x981A);
        // 100D:981A cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:981F je short 0x9825
        if (ZeroFlag)
        {
            goto label_100D_9825_198F5_25114;
        }
    label_100D_9821_198F1_36328:
        CheckExternalEvents(cs1, 0x9821);
        // 100D:9821 mov AX,0x9840
        AX = (ushort)0x9840;
        // 100D:9824 push AX
        Stack.Push16(AX);
    label_100D_9825_198F5_25114:
        CheckExternalEvents(cs1, 0x9825);
        // 100D:9825 test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:9829 je short 0x982E
        if (ZeroFlag)
        {
            goto label_100D_982E_198FE_25979;
        }
    label_100D_982B_198FB_25117:
        CheckExternalEvents(cs1, 0x982B);
        // 100D:982B jmp near 0x9673
        if (JumpDispatcher.Jump(unknown_100D_9673_19743, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_982E_198FE_25979:
        CheckExternalEvents(cs1, 0x982E);
        // 100D:982E call near 0x9655
        NearCall(cs1, 0x9831, unknown_100D_9655_19725);
    label_100D_9831_19901_25996:
        CheckExternalEvents(cs1, 0x9831);
        // 100D:9831 cmp byte ptr DS:[0x002B],0
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x00);
        // 100D:9836 jne short 0x983F
        if (!ZeroFlag)
        {
            goto label_100D_983F_1990F_36331;
        }
    label_100D_9838_19908_25999:
        CheckExternalEvents(cs1, 0x9838);
        // 100D:9838 test byte ptr DS:[0x47A4],1
        Alu8.And(UInt8[DS, (ushort)0x47A4], (byte)0x01);
        // 100D:983D je short 0x9879
        if (ZeroFlag)
        {
            goto label_100D_9879_19949_16285;
        }
    label_100D_983F_1990F_36331:
        CheckExternalEvents(cs1, 0x983F);
        // 100D:983F ret near
        return NearRet((ushort)0x0000);
    label_100D_9849_19919_16268:
        CheckExternalEvents(cs1, 0x9849);
        // 100D:9849 mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:984F test byte ptr DS:[SI+0x0F],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)15)], (byte)0x40);
        // 100D:9853 je short 0x9858
        if (ZeroFlag)
        {
            goto label_100D_9858_19928_16272;
        }
    label_100D_9855_19925_23114:
        CheckExternalEvents(cs1, 0x9855);
        // 100D:9855 call near 0x9673
        NearCall(cs1, 0x9858, unknown_100D_9673_19743);
    label_100D_9858_19928_16272:
        CheckExternalEvents(cs1, 0x9858);
        // 100D:9858 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:985A mov word ptr DS:[0x4540],AX
        UInt16[DS, (ushort)0x4540] = AX;
        // 100D:985D mov word ptr DS:[0x479E],AX
        UInt16[DS, (ushort)0x479E] = AX;
        // 100D:9860 and byte ptr DS:[0x47D1],0x3F
        UInt8[DS, (ushort)0x47D1] = Alu8.And(UInt8[DS, (ushort)0x47D1], (byte)0x3F);
        // 100D:9865 mov word ptr DS:[0x47C8],AX
        UInt16[DS, (ushort)0x47C8] = AX;
        // 100D:9868 and byte ptr DS:[0x47A4],0x7F
        UInt8[DS, (ushort)0x47A4] = Alu8.And(UInt8[DS, (ushort)0x47A4], (byte)0x7F);
        // 100D:986D call near 0x9B8B
        NearCall(cs1, 0x9870, unknown_100D_9B8B_19C5B);
    label_100D_9870_19940_16280:
        CheckExternalEvents(cs1, 0x9870);
        // 100D:9870 mov AL,byte ptr DS:[0x0023]
        AL = UInt8[DS, (ushort)0x0023];
        // 100D:9873 sub AL,0x64
        AL = Alu8.Sub(AL, (byte)0x64);
        // 100D:9875 cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 100D:9877 jb short 0x9898
        if (CarryFlag)
        {
            goto label_100D_9898_19968_33322;
        }
    label_100D_9879_19949_16285:
        CheckExternalEvents(cs1, 0x9879);
        // 100D:9879 call near 0x2EFB
        NearCall(cs1, 0x987C, unknown_100D_2EFB_12FCB);
    label_100D_987C_1994C_16287:
        CheckExternalEvents(cs1, 0x987C);
        // 100D:987C cmp byte ptr DS:[0x11C9],0
        Alu8.Sub(UInt8[DS, (ushort)0x11C9], (byte)0x00);
        // 100D:9881 jne short 0x9886
        if (!ZeroFlag)
        {
            goto label_100D_9886_19956_16292;
        }
    label_100D_9883_19953_16290:
        CheckExternalEvents(cs1, 0x9883);
        // 100D:9883 call near 0x3090
        NearCall(cs1, 0x9886, unknown_100D_3090_13160);
    label_100D_9886_19956_16292:
        CheckExternalEvents(cs1, 0x9886);
        // 100D:9886 call near 0x37B2
        NearCall(cs1, 0x9889, unknown_100D_37B2_13882);
    label_100D_9889_19959_16294:
        CheckExternalEvents(cs1, 0x9889);
        // 100D:9889 call near 0xC412
        NearCall(cs1, 0x988C, unknown_100D_C412_1C4E2);
    label_100D_988C_1995C_16296:
        CheckExternalEvents(cs1, 0x988C);
        // 100D:988C call near 0xC0F4
        NearCall(cs1, 0x988F, unknown_100D_C0F4_1C1C4);
    label_100D_988F_1995F_16298:
        CheckExternalEvents(cs1, 0x988F);
        // 100D:988F call near 0x1834
        NearCall(cs1, 0x9892, unknown_100D_1834_11904);
    label_100D_9892_19962_16300:
        CheckExternalEvents(cs1, 0x9892);
        // 100D:9892 call near 0xC4DD
        NearCall(cs1, 0x9895, unknown_100D_C4DD_1C5AD);
    label_100D_9895_19965_16302:
        CheckExternalEvents(cs1, 0x9895);
        // 100D:9895 jmp near 0x17E6
        if (JumpDispatcher.Jump(unknown_100D_17E6_118B6, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_9898_19968_33322:
        CheckExternalEvents(cs1, 0x9898);
        // 100D:9898 mov BP,0x37B2
        BP = (ushort)0x37B2;
        // 100D:989B call near 0xC097
        NearCall(cs1, 0x989E, unknown_100D_C097_1C167);
    label_100D_989E_1996E_33325:
        CheckExternalEvents(cs1, 0x989E);
        // 100D:989E call near 0x36D3
        NearCall(cs1, 0x98A1, unknown_100D_36D3_137A3);
    label_100D_98A1_19971_33327:
        CheckExternalEvents(cs1, 0x98A1);
        // 100D:98A1 mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 100D:98A4 call near 0xE3A0
        NearCall(cs1, 0x98A7, unknown_100D_E3A0_1E470);
    label_100D_98A7_19977_33330:
        CheckExternalEvents(cs1, 0x98A7);
        // 100D:98A7 mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:98AD jmp short 0x9858
        goto label_100D_9858_19928_16272;
    }

    public virtual Action unknown_100D_9840_19910(int loadOffset)
    {
    entrydispatcher:
    label_100D_9840_19910_36333:
        CheckExternalEvents(cs1, 0x9840);
        // 100D:9840 call near 0x9B8B
        NearCall(cs1, 0x9843, unknown_100D_9B8B_19C5B);
    label_100D_9843_19913_36335:
        CheckExternalEvents(cs1, 0x9843);
        // 100D:9843 call near 0xC43E
        NearCall(cs1, 0x9846, unknown_100D_C43E_1C50E);
    label_100D_9846_19916_36337:
        CheckExternalEvents(cs1, 0x9846);
        // 100D:9846 jmp near 0xC4DD
        return unknown_100D_C4DD_1C5AD(0x0000);
    }

    public virtual Action unknown_100D_98AF_1997F(int loadOffset)
    {
    entrydispatcher:
    label_100D_98AF_1997F_35155:
        CheckExternalEvents(cs1, 0x98AF);
        // 100D:98AF call near 0x8C8A
        NearCall(cs1, 0x98B2, unknown_100D_8C8A_18D5A);
        if (JumpDispatcher.Jump(unknown_100D_98B2_19982, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_98B2_19982(int loadOffset)
    {
    entrydispatcher:
    label_100D_98B2_19982_7864:
        CheckExternalEvents(cs1, 0x98B2);
        // 100D:98B2 cmp byte ptr DS:[0x47C3],0
        Alu8.Sub(UInt8[DS, (ushort)0x47C3], (byte)0x00);
        // 100D:98B7 jne short 0x98E5
        if (!ZeroFlag)
        {
            goto label_100D_98E5_199B5_7874;
        }
    label_100D_98B9_19989_7867:
        CheckExternalEvents(cs1, 0x98B9);
        // 100D:98B9 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:98BB mov word ptr DS:[0x4540],AX
        UInt16[DS, (ushort)0x4540] = AX;
        // 100D:98BE and byte ptr DS:[0x47D1],0x3F
        UInt8[DS, (ushort)0x47D1] = Alu8.And(UInt8[DS, (ushort)0x47D1], (byte)0x3F);
        // 100D:98C3 xchg AX,word ptr DS:[0x47C8]
        ushort xchgOffset_100D_98C3_19993 = (ushort)0x47C8;
        ushort temp_100D_98C3_19993 = AX;
        AX = UInt16[DS, xchgOffset_100D_98C3_19993];
        UInt16[DS, xchgOffset_100D_98C3_19993] = unchecked((ushort)temp_100D_98C3_19993);
        // 100D:98C7 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:98C9 je short 0x98E5
        if (ZeroFlag)
        {
            goto label_100D_98E5_199B5_7874;
        }
    label_100D_98CB_1999B_25208:
        CheckExternalEvents(cs1, 0x98CB);
        // 100D:98CB mov SI,0x1BF0
        SI = (ushort)0x1BF0;
        // 100D:98CE mov word ptr DS:[SI+8],0
        UInt16[DS, (ushort)(SI + (sbyte)8)] = (ushort)0x0000;
        // 100D:98D3 mov word ptr DS:[0x1C06],0
        UInt16[DS, (ushort)0x1C06] = (ushort)0x0000;
        // 100D:98D9 call near 0xC446
        NearCall(cs1, 0x98DC, unknown_100D_C446_1C516);
    label_100D_98DC_199AC_25213:
        CheckExternalEvents(cs1, 0x98DC);
        // 100D:98DC mov SI,0x1BF0
        SI = (ushort)0x1BF0;
        // 100D:98DF call near 0xC4F0
        NearCall(cs1, 0x98E2, unknown_100D_C4F0_1C5C0);
    label_100D_98E2_199B2_25216:
        CheckExternalEvents(cs1, 0x98E2);
        // 100D:98E2 jmp near 0x9B8B
        if (JumpDispatcher.Jump(unknown_100D_9B8B_19C5B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_98E5_199B5_7874:
        CheckExternalEvents(cs1, 0x98E5);
        // 100D:98E5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_98E6_199B6(int loadOffset)
    {
    entrydispatcher:
    label_100D_98E6_199B6_3503:
        CheckExternalEvents(cs1, 0x98E6);
        // 100D:98E6 call near 0x98F5
        NearCall(cs1, 0x98E9, unknown_100D_98F5_199C5);
    label_100D_98E9_199B9_3511:
        CheckExternalEvents(cs1, 0x98E9);
        // 100D:98E9 mov word ptr DS:[0x47C8],AX
        UInt16[DS, (ushort)0x47C8] = AX;
        // 100D:98EC mov word ptr DS:[0x47AA],AX
        UInt16[DS, (ushort)0x47AA] = AX;
        // 100D:98EF mov word ptr DS:[0x479E],AX
        UInt16[DS, (ushort)0x479E] = AX;
        // 100D:98F2 jmp near 0x9B8B
        if (JumpDispatcher.Jump(unknown_100D_9B8B_19C5B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_98F5_199C5(int loadOffset)
    {
    label_100D_98F5_199C5_3505:
        CheckExternalEvents(cs1, 0x98F5);
        // 100D:98F5 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:98F7 mov word ptr DS:[0x1C06],AX
        UInt16[DS, (ushort)0x1C06] = AX;
        // 100D:98FA mov word ptr DS:[0x1BF8],AX
        UInt16[DS, (ushort)0x1BF8] = AX;
        // 100D:98FD mov word ptr DS:[0x1BEA],AX
        UInt16[DS, (ushort)0x1BEA] = AX;
        // 100D:9900 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9901_199D1(int loadOffset)
    {
    label_100D_9901_199D1_11723:
        CheckExternalEvents(cs1, 0x9901);
        // 100D:9901 mov word ptr DS:[0x479E],0
        UInt16[DS, (ushort)0x479E] = (ushort)0x0000;
        // 100D:9907 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9908_199D8(int loadOffset)
    {
    label_100D_9908_199D8_7936:
        CheckExternalEvents(cs1, 0x9908);
        // 100D:9908 mov SI,word ptr DS:[0x47CA]
        SI = UInt16[DS, (ushort)0x47CA];
        // 100D:990C mov ES,word ptr DS:[0xDBB2]
        ES = UInt16[DS, (ushort)0xDBB2];
        // 100D:9910 call near 0x994F
        NearCall(cs1, 0x9913, unknown_100D_994F_19A1F);
    label_100D_9913_199E3_7963:
        CheckExternalEvents(cs1, 0x9913);
        // 100D:9913 mov byte ptr DS:[0x47D1],0xC0
        UInt8[DS, (ushort)0x47D1] = (byte)0xC0;
        // 100D:9918 mov AL,byte ptr DS:[0x478C]
        AL = UInt8[DS, (ushort)0x478C];
        // 100D:991B xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:991D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:991F shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9921 mov word ptr DS:[0x47CE],AX
        UInt16[DS, (ushort)0x47CE] = AX;
        // 100D:9924 add SI,word ptr ES:[BP+SI]
        SI = Alu16.Add(SI, UInt16[ES, (ushort)(BP + SI)]);
        // 100D:9927 call near 0x996C
        NearCall(cs1, 0x992A, unknown_100D_996C_19A3C);
    label_100D_992A_199FA_7977:
        CheckExternalEvents(cs1, 0x992A);
        // 100D:992A mov word ptr DS:[0x47C8],SI
        UInt16[DS, (ushort)0x47C8] = SI;
        // 100D:992E xchg SI,word ptr DS:[0x47C6]
        ushort xchgOffset_100D_992E_199FE = (ushort)0x47C6;
        ushort temp_100D_992E_199FE = SI;
        SI = UInt16[DS, xchgOffset_100D_992E_199FE];
        UInt16[DS, xchgOffset_100D_992E_199FE] = unchecked((ushort)temp_100D_992E_199FE);
        // 100D:9932 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 100D:9934 jne short 0x994E
        if (!ZeroFlag)
        {
            return unknown_100D_994E_19A1E(0x0000);
        }
    label_100D_9936_19A06_7982:
        CheckExternalEvents(cs1, 0x9936);
        // 100D:9936 cmp byte ptr DS:[0x00EA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00EA], (byte)0x00);
        // 100D:993B jg short 0x994E
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            return unknown_100D_994E_19A1E(0x0000);
        }
    label_100D_993D_19A0D_7985:
        CheckExternalEvents(cs1, 0x993D);
        // 100D:993D mov AX,word ptr DS:[0x47C4]
        AX = UInt16[DS, (ushort)0x47C4];
        // 100D:9940 call near 0x127C
        NearCall(cs1, 0x9943, unknown_100D_127C_1134C);
    label_100D_9943_19A13_7988:
        CheckExternalEvents(cs1, 0x9943);
        // 100D:9943 jb short 0x994E
        if (CarryFlag)
        {
            return unknown_100D_994E_19A1E(0x0000);
        }
        else
        {
            return unknown_100D_9945_19A15(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_9945_19A15(int loadOffset)
    {
    label_100D_9945_19A15_7990:
        CheckExternalEvents(cs1, 0x9945);
        // 100D:9945 mov SI,0x99BE
        SI = (ushort)0x99BE;
        // 100D:9948 mov BP,0x0010
        BP = (ushort)0x0010;
        // 100D:994B call near 0xDA25
        NearCall(cs1, 0x994E, unknown_100D_DA25_1DAF5);
        return unknown_100D_994E_19A1E(0x0000);
    }

    public virtual Action unknown_100D_994F_19A1F(int loadOffset)
    {
    label_100D_994F_19A1F_7940:
        CheckExternalEvents(cs1, 0x994F);
        // 100D:994F mov AL,byte ptr DS:[0x47D0]
        AL = UInt8[DS, (ushort)0x47D0];
        // 100D:9952 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:9954 jne short 0x9963
        if (!ZeroFlag)
        {
            goto label_100D_9963_19A33_9538;
        }
    label_100D_9956_19A26_7944:
        CheckExternalEvents(cs1, 0x9956);
        // 100D:9956 mov BX,6
        BX = (ushort)0x0006;
        // 100D:9959 call near 0xE3B7
        NearCall(cs1, 0x995C, unknown_100D_E3B7_1E487);
    label_100D_995C_19A2C_7959:
        CheckExternalEvents(cs1, 0x995C);
        // 100D:995C mov BP,AX
        BP = AX;
        // 100D:995E add BP,word ptr DS:[0x00F0]
        BP = Alu16.Add(BP, UInt16[DS, (ushort)0x00F0]);
        // 100D:9962 ret near
        return NearRet((ushort)0x0000);
    label_100D_9963_19A33_9538:
        CheckExternalEvents(cs1, 0x9963);
        // 100D:9963 dec AL
        AL = Alu8.Dec(AL);
        // 100D:9965 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:9967 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:9969 mov BP,AX
        BP = AX;
        // 100D:996B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_996C_19A3C(int loadOffset)
    {
    label_100D_996C_19A3C_7972:
        CheckExternalEvents(cs1, 0x996C);
        // 100D:996C cmp byte ptr DS:[0x47D0],0
        Alu8.Sub(UInt8[DS, (ushort)0x47D0], (byte)0x00);
        // 100D:9971 je short 0x9981
        if (ZeroFlag)
        {
            goto label_100D_9981_19A51_7975;
        }
    label_100D_9973_19A43_9544:
        CheckExternalEvents(cs1, 0x9973);
        // 100D:9973 mov CX,0x0020
        CX = (ushort)0x0020;
        // 100D:9976 push ES
        Stack.Push16(ES);
        // 100D:9977 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_9978_19A48_9548:
        CheckExternalEvents(cs1, 0x9978);
        // 100D:9978 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:9979 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:997B jne short 0x9978
        if (!ZeroFlag)
        {
            goto label_100D_9978_19A48_9548;
        }
    label_100D_997D_19A4D_9552:
        CheckExternalEvents(cs1, 0x997D);
        // 100D:997D loop 0x9978
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_9978_19A48_9548;
        }
    label_100D_997F_19A4F_9554:
        CheckExternalEvents(cs1, 0x997F);
        // 100D:997F push SS
        Stack.Push16(SS);
        // 100D:9980 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_9981_19A51_7975:
        CheckExternalEvents(cs1, 0x9981);
        // 100D:9981 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9985_19A55(int loadOffset)
    {
        goto label_100D_9985_19A55_3496;

    label_100D_9982_19A52_9498:
        CheckExternalEvents(cs1, 0x9982);
        // 100D:9982 call near 0x99BE
        NearCall(cs1, 0x9985, unknown_100D_99BE_19A8E);
    label_100D_9985_19A55_3496:
        CheckExternalEvents(cs1, 0x9985);
        // 100D:9985 test word ptr DS:[0x47CE],7
        Alu16.And(UInt16[DS, (ushort)0x47CE], (ushort)0x0007);
        // 100D:998B jne short 0x9982
        if (!ZeroFlag)
        {
            goto label_100D_9982_19A52_9498;
        }
    label_100D_998D_19A5D_3499:
        CheckExternalEvents(cs1, 0x998D);
        // 100D:998D ret near
        return NearRet((ushort)0x0000);
    }
}
