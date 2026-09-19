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
    public virtual Action unknown_5642_07F9_56C19(int loadOffset)
    {
    label_5642_07F9_56C19_10830:
        CheckExternalEvents(cs3, 0x07F9);
        // 5642:07F9 mov BX,word ptr DS:[0x02AB]
        BX = UInt16[DS, (ushort)0x02AB];
        // 5642:07FD or BX,BX
        BX = Alu16.Or(BX, BX);
        // 5642:07FF je short 0x0826
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:07FF");
        }
    label_5642_0801_56C21_10834:
        CheckExternalEvents(cs3, 0x0801);
        // 5642:0801 cmp word ptr DS:[BX+0x02AB],0
        Alu16.Sub(UInt16[DS, (ushort)(BX + (short)683)], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:0806 je short 0x0821
        if (ZeroFlag)
        {
            goto label_5642_0821_56C41_11445;
        }
    label_5642_0808_56C28_10837:
        CheckExternalEvents(cs3, 0x0808);
        // 5642:0808 mov DI,0x0293
        DI = (ushort)0x0293;
        // 5642:080B mov SI,0x02B3
        SI = (ushort)0x02B3;
        // 5642:080E add SI,BX
        SI = Alu16.Add(SI, BX);
        // 5642:0810 add SI,BX
        SI = Alu16.Add(SI, BX);
        // 5642:0812 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5642:0813 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5642:0814 cmp word ptr DS:[BX+0x02AB],-1
        Alu16.Sub(UInt16[DS, (ushort)(BX + (short)683)], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 5642:0819 je short 0x0829
        if (ZeroFlag)
        {
            goto label_5642_0829_56C49_10846;
        }
    label_5642_081B_56C3B_11440:
        CheckExternalEvents(cs3, 0x081B);
        // 5642:081B dec word ptr DS:[BX+0x02AB]
        UInt16[DS, (ushort)(BX + (short)683)] = Alu16.Dec(UInt16[DS, (ushort)(BX + (short)683)]);
        // 5642:081F jmp short 0x0829
        goto label_5642_0829_56C49_10846;
    label_5642_0821_56C41_11445:
        CheckExternalEvents(cs3, 0x0821);
        // 5642:0821 sub word ptr DS:[0x02AB],2
        UInt16[DS, (ushort)0x02AB] = Alu16.Sub(UInt16[DS, (ushort)0x02AB], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5642:0826 call near 0x0677
        NearCall(cs3, 0x0829, unknown_5642_0677_56A97);
    label_5642_0829_56C49_10846:
        CheckExternalEvents(cs3, 0x0829);
        // 5642:0829 stc
        CarryFlag = true;
        // 5642:082A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_082B_56C4B(int loadOffset)
    {
    label_5642_082B_56C4B_1283:
        CheckExternalEvents(cs3, 0x082B);
        // 5642:082B push CX
        Stack.Push16(CX);
        // 5642:082C push DX
        Stack.Push16(DX);
        // 5642:082D push SI
        Stack.Push16(SI);
        // 5642:082E push DI
        Stack.Push16(DI);
        // 5642:082F push BP
        Stack.Push16(BP);
        // 5642:0830 push DS
        Stack.Push16(DS);
        // 5642:0831 push ES
        Stack.Push16(ES);
        // 5642:0832 push CS
        Stack.Push16(CS);
        // 5642:0833 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0834 mov word ptr DS:[0x028F],ES
        UInt16[DS, (ushort)0x028F] = ES;
        // 5642:0838 push CS
        Stack.Push16(CS);
        // 5642:0839 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:083A cmp BX,0x000E
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)14)));
        // 5642:083D jae short 0x0858
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:083D");
        }
    label_5642_083F_56C5F_1298:
        CheckExternalEvents(cs3, 0x083F);
        // 5642:083F cmp BL,4
        Alu8.Sub(BL, (byte)0x04);
        // 5642:0842 jb short 0x0850
        if (CarryFlag)
        {
            goto label_5642_0850_56C70_1301;
        }
    label_5642_0844_56C64_1348:
        CheckExternalEvents(cs3, 0x0844);
        // 5642:0844 cmp BL,0x0D
        Alu8.Sub(BL, (byte)0x0D);
        // 5642:0847 je short 0x0850
        if (ZeroFlag)
        {
            goto label_5642_0850_56C70_1301;
        }
    label_5642_0849_56C69_1705:
        CheckExternalEvents(cs3, 0x0849);
        // 5642:0849 cmp byte ptr DS:[0x028E],0
        Alu8.Sub(UInt8[DS, (ushort)0x028E], (byte)0x00);
        // 5642:084E je short 0x0858
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:084E");
        }
    label_5642_0850_56C70_1301:
        CheckExternalEvents(cs3, 0x0850);
        // 5642:0850 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 5642:0852 call near word ptr DS:[BX+0x02E0]
        switch ((ushort)(UInt16[DS, (ushort)(BX + (short)736)]))
        {
            case 0x0867:
                NearCall(cs3, 0x0856, unknown_5642_0867_56C87);
                break;
            case 0x087B:
                NearCall(cs3, 0x0856, unknown_5642_087B_56C9B);
                break;
            case 0x0895:
                NearCall(cs3, 0x0856, unknown_5642_0895_56CB5);
                break;
            case 0x08B4:
                NearCall(cs3, 0x0856, unknown_5642_08B4_56CD4);
                break;
            case 0x08E8:
                NearCall(cs3, 0x0856, unknown_5642_08E8_56D08);
                break;
            case 0x0925:
                NearCall(cs3, 0x0856, unknown_5642_0925_56D45);
                break;
            case 0x095F:
                NearCall(cs3, 0x0856, unknown_5642_095F_56D7F);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(BX + (short)736)])):X4} at 5642:0852");
        }
    label_5642_0856_56C76_1314:
        CheckExternalEvents(cs3, 0x0856);
        // 5642:0856 jmp short 0x085B
    label_5642_085B_56C7B_1316:
        CheckExternalEvents(cs3, 0x085B);
        // 5642:085B pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:085C pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:085D pop BP
        BP = Stack.Pop16();
        // 5642:085E pop DI
        DI = Stack.Pop16();
        // 5642:085F pop SI
        SI = Stack.Pop16();
        // 5642:0860 pop DX
        DX = Stack.Pop16();
        // 5642:0861 pop CX
        CX = Stack.Pop16();
        // 5642:0862 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0867_56C87(int loadOffset)
    {
    label_5642_0867_56C87_1334:
        CheckExternalEvents(cs3, 0x0867);
        // 5642:0867 and AX,0xFFF8
        AX = Alu16.And(AX, (ushort)0xFFF8);
        // 5642:086A mov BX,AX
        BX = AX;
        // 5642:086C sub AX,0x0210
        AX = Alu16.Sub(AX, (ushort)0x0210);
        // 5642:086F cmp AX,0x0050
        Alu16.Sub(AX, (ushort)0x0050);
        // 5642:0872 ja short 0x08B0
        if (!CarryFlag && !ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:0872");
        }
    label_5642_0874_56C94_1340:
        CheckExternalEvents(cs3, 0x0874);
        // 5642:0874 mov word ptr DS:[0x0285],BX
        UInt16[DS, (ushort)0x0285] = BX;
        // 5642:0878 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:087A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_087B_56C9B(int loadOffset)
    {
    label_5642_087B_56C9B_1304:
        CheckExternalEvents(cs3, 0x087B);
        // 5642:087B cmp AL,0x0A
        Alu8.Sub(AL, (byte)0x0A);
        // 5642:087D je short 0x088F
        if (ZeroFlag)
        {
            goto label_5642_088F_56CAF_1310;
        }
    label_5642_087F_56C9F_1307:
        CheckExternalEvents(cs3, 0x087F);
        // 5642:087F cmp AL,7
        Alu8.Sub(AL, (byte)0x07);
        // 5642:0881 je short 0x088F
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0881");
        }
    label_5642_088F_56CAF_1310:
        CheckExternalEvents(cs3, 0x088F);
        // 5642:088F mov byte ptr DS:[0x0287],AL
        UInt8[DS, (ushort)0x0287] = AL;
        // 5642:0892 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0894 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0895_56CB5(int loadOffset)
    {
    label_5642_0895_56CB5_1351:
        CheckExternalEvents(cs3, 0x0895);
        // 5642:0895 and AL,7
        AL = Alu8.And(AL, (byte)0x07);
        // 5642:0897 dec AL
        AL = Alu8.Dec(AL);
        // 5642:0899 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 5642:089B ja short 0x08B0
        if (!CarryFlag && !ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:089B");
        }
    label_5642_089D_56CBD_1356:
        CheckExternalEvents(cs3, 0x089D);
        // 5642:089D cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 5642:089F je short 0x08B0
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:089F");
        }
    label_5642_08A1_56CC1_1359:
        CheckExternalEvents(cs3, 0x08A1);
        // 5642:08A1 mov byte ptr DS:[0x0288],AL
        UInt8[DS, (ushort)0x0288] = AL;
        // 5642:08A4 push BX
        Stack.Push16(BX);
        // 5642:08A5 mov BX,0x028A
        BX = (ushort)0x028A;
        // 5642:08A8 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 5642:08A9 mov byte ptr DS:[0x0289],AL
        UInt8[DS, (ushort)0x0289] = AL;
        // 5642:08AC pop BX
        BX = Stack.Pop16();
        // 5642:08AD xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:08AF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_08B4_56CD4(int loadOffset)
    {
    label_5642_08B4_56CD4_1371:
        CheckExternalEvents(cs3, 0x08B4);
        // 5642:08B4 pushf
        Stack.Push16(FlagRegister16);
        // 5642:08B5 sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_5642_08B6_56CD6_1374:
        CheckExternalEvents(cs3, 0x08B6);
        // 5642:08B6 call near 0x035C
        NearCall(cs3, 0x08B9, unknown_5642_035C_5677C);
    label_5642_08B9_56CD9_1415:
        CheckExternalEvents(cs3, 0x08B9);
        // 5642:08B9 jne short 0x08D1
        if (!ZeroFlag)
        {
            goto label_5642_08D1_56CF1_1690;
        }
    label_5642_08BB_56CDB_1417:
        CheckExternalEvents(cs3, 0x08BB);
        // 5642:08BB call near 0x0385
        NearCall(cs3, 0x08BE, unknown_5642_0385_567A5);
    label_5642_08BE_56CDE_1457:
        CheckExternalEvents(cs3, 0x08BE);
        // 5642:08BE jne short 0x08D1
        if (!ZeroFlag)
        {
            goto label_5642_08D1_56CF1_1690;
        }
    label_5642_08C0_56CE0_1459:
        CheckExternalEvents(cs3, 0x08C0);
        // 5642:08C0 call near 0x041C
        NearCall(cs3, 0x08C3, unknown_5642_041C_5683C);
    label_5642_08C3_56CE3_1497:
        CheckExternalEvents(cs3, 0x08C3);
        // 5642:08C3 jne short 0x08D1
        if (!ZeroFlag)
        {
            goto label_5642_08D1_56CF1_1690;
        }
    label_5642_08C5_56CE5_1499:
        CheckExternalEvents(cs3, 0x08C5);
        // 5642:08C5 call near 0x03D1
        NearCall(cs3, 0x08C8, unknown_5642_03D1_567F1);
    label_5642_08C8_56CE8_1672:
        CheckExternalEvents(cs3, 0x08C8);
        // 5642:08C8 jne short 0x08D1
        if (!ZeroFlag)
        {
            goto label_5642_08D1_56CF1_1690;
        }
    label_5642_08CA_56CEA_1674:
        CheckExternalEvents(cs3, 0x08CA);
        // 5642:08CA mov AL,1
        AL = (byte)0x01;
        // 5642:08CC call near 0x08D3
        NearCall(cs3, 0x08CF, unknown_5642_08D3_56CF3);
    label_5642_08CF_56CEF_1688:
        CheckExternalEvents(cs3, 0x08CF);
        // 5642:08CF xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_5642_08D1_56CF1_1690:
        CheckExternalEvents(cs3, 0x08D1);
        // 5642:08D1 popf
        FlagRegister16 = Stack.Pop16();
    label_5642_08D2_56CF2_1692:
        CheckExternalEvents(cs3, 0x08D2);
        // 5642:08D2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_08D3_56CF3(int loadOffset)
    {
    label_5642_08D3_56CF3_1677:
        CheckExternalEvents(cs3, 0x08D3);
        // 5642:08D3 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:08D7 add DL,0x0C
        DL = Alu8.Add(DL, (byte)0x0C);
        // 5642:08DA or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5642:08DC mov AL,0xD1
        AL = (byte)0xD1;
        // 5642:08DE jne short 0x08E2
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:08DE");
        }
    label_5642_08E2_56D02_1683:
        CheckExternalEvents(cs3, 0x08E2);
        // 5642:08E2 call near 0x033A
        NearCall(cs3, 0x08E5, unknown_5642_033A_5675A);
    label_5642_08E5_56D05_1685:
        CheckExternalEvents(cs3, 0x08E5);
        // 5642:08E5 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:08E7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_08E8_56D08(int loadOffset)
    {
        goto label_5642_08E8_56D08_1907;

    label_5642_08B0_56CD0_30863:
        CheckExternalEvents(cs3, 0x08B0);
        // 5642:08B0 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 5642:08B3 ret near
        return NearRet((ushort)0x0000);
    label_5642_08E8_56D08_1907:
        CheckExternalEvents(cs3, 0x08E8);
        // 5642:08E8 cmp byte ptr DS:[0x0292],0
        Alu8.Sub(UInt8[DS, (ushort)0x0292], (byte)0x00);
        // 5642:08ED jne short 0x08B0
        if (!ZeroFlag)
        {
            goto label_5642_08B0_56CD0_30863;
        }
    label_5642_08EF_56D0F_1910:
        CheckExternalEvents(cs3, 0x08EF);
        // 5642:08EF inc byte ptr DS:[0x0292]
        UInt8[DS, (ushort)0x0292] = Alu8.Inc(UInt8[DS, (ushort)0x0292]);
        // 5642:08F3 mov DX,word ptr DS:[0x028F]
        DX = UInt16[DS, (ushort)0x028F];
        // 5642:08F7 mov AX,DI
        AX = DI;
        // 5642:08F9 call near 0x06BD
        NearCall(cs3, 0x08FC, unknown_5642_06BD_56ADD);
    label_5642_08FC_56D1C_1925:
        CheckExternalEvents(cs3, 0x08FC);
        // 5642:08FC mov word ptr DS:[0x0295],DX
        UInt16[DS, (ushort)0x0295] = DX;
        // 5642:0900 mov word ptr DS:[0x0293],AX
        UInt16[DS, (ushort)0x0293] = AX;
        // 5642:0903 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0905 mov byte ptr DS:[0x02A7],AL
        UInt8[DS, (ushort)0x02A7] = AL;
        // 5642:0908 mov word ptr DS:[0x02AB],AX
        UInt16[DS, (ushort)0x02AB] = AX;
        // 5642:090B mov word ptr DS:[0x02AD],AX
        UInt16[DS, (ushort)0x02AD] = AX;
        // 5642:090E mov AX,0x0591
        AX = (ushort)0x0591;
        // 5642:0911 call near 0x04D8
        NearCall(cs3, 0x0914, unknown_5642_04D8_568F8);
    label_5642_0914_56D34_1934:
        CheckExternalEvents(cs3, 0x0914);
        // 5642:0914 mov word ptr DS:[0x0283],0xFFFF
        UInt16[DS, (ushort)0x0283] = (ushort)0xFFFF;
        // 5642:091A call near 0x065F
        NearCall(cs3, 0x091D, unknown_5642_065F_56A7F);
    label_5642_091D_56D3D_2064:
        CheckExternalEvents(cs3, 0x091D);
        // 5642:091D mov byte ptr DS:[0x02FE],0
        UInt8[DS, (ushort)0x02FE] = (byte)0x00;
        // 5642:0922 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0924 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0925_56D45(int loadOffset)
    {
    label_5642_0925_56D45_1708:
        CheckExternalEvents(cs3, 0x0925);
        // 5642:0925 mov AX,1
        AX = (ushort)0x0001;
        // 5642:0928 cmp byte ptr DS:[0x0292],0
        Alu8.Sub(UInt8[DS, (ushort)0x0292], (byte)0x00);
        // 5642:092D je short 0x0937
        if (ZeroFlag)
        {
            goto label_5642_0937_56D57_1712;
        }
    label_5642_092F_56D4F_5853:
        CheckExternalEvents(cs3, 0x092F);
        // 5642:092F call near 0x0432
        NearCall(cs3, 0x0932, unknown_5642_0432_56852);
    label_5642_0932_56D52_5877:
        CheckExternalEvents(cs3, 0x0932);
        // 5642:0932 call near 0x0640
        NearCall(cs3, 0x0935, unknown_5642_0640_56A60);
    label_5642_0935_56D55_5879:
        CheckExternalEvents(cs3, 0x0935);
        // 5642:0935 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_5642_0937_56D57_1712:
        CheckExternalEvents(cs3, 0x0937);
        // 5642:0937 mov byte ptr DS:[0x02FE],1
        UInt8[DS, (ushort)0x02FE] = (byte)0x01;
        // 5642:093C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_095F_56D7F(int loadOffset)
    {
    label_5642_095F_56D7F_3465:
        CheckExternalEvents(cs3, 0x095F);
        // 5642:095F mov CX,AX
        CX = AX;
        // 5642:0961 mov AX,1
        AX = (ushort)0x0001;
        // 5642:0964 pushf
        Stack.Push16(FlagRegister16);
    label_5642_0965_56D85_3469:
        CheckExternalEvents(cs3, 0x0965);
        // 5642:0965 cli
        InterruptFlag = false;
        // 5642:0966 mov BX,word ptr DS:[0x02AB]
        BX = UInt16[DS, (ushort)0x02AB];
        // 5642:096A or BX,BX
        BX = Alu16.Or(BX, BX);
        // 5642:096C je short 0x0990
        if (ZeroFlag)
        {
            goto label_5642_0990_56DB0_3474;
        }
    label_5642_096E_56D8E_10901:
        CheckExternalEvents(cs3, 0x096E);
        // 5642:096E xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0970 mov word ptr DS:[BX+0x02AB],AX
        UInt16[DS, (ushort)(BX + (short)683)] = AX;
        // 5642:0974 jcxz short 0x098E
        if (!(CX == (ushort)0x0000))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0974");
        }
    label_5642_098E_56DAE_10905:
        CheckExternalEvents(cs3, 0x098E);
        // 5642:098E xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_5642_0990_56DB0_3474:
        CheckExternalEvents(cs3, 0x0990);
        // 5642:0990 popf
        FlagRegister16 = Stack.Pop16();
    label_5642_0991_56DB1_3476:
        CheckExternalEvents(cs3, 0x0991);
        // 5642:0991 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0100_5BBE0(int loadOffset)
    {
    label_5BAE_0100_5BBE0_2216:
        CheckExternalEvents(cs4, 0x0100);
        // 5BAE:0100 jmp near 0x02D8
    label_5BAE_02D8_5BDB8_2218:
        CheckExternalEvents(cs4, 0x02D8);
        // 5BAE:02D8 and AX,0x0FFF
        AX = Alu16.And(AX, (ushort)0x0FFF);
        // 5BAE:02DB je short 0x02E1
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5BAE:02DB");
        }
    label_5BAE_02DD_5BDBD_2221:
        CheckExternalEvents(cs4, 0x02DD);
        // 5BAE:02DD mov word ptr CS:[0x02B3],AX
        UInt16[CS, (ushort)0x02B3] = AX;
        // 5BAE:02E1 call near 0x02B5
        NearCall(cs4, 0x02E4, unknown_5BAE_02B5_5BD95);
    label_5BAE_02E4_5BDC4_2246:
        CheckExternalEvents(cs4, 0x02E4);
        // 5BAE:02E4 mov AX,0x2001
        AX = (ushort)0x2001;
        // 5BAE:02E7 call near 0x0AA2
        NearCall(cs4, 0x02EA, unknown_5BAE_0AA2_5C582);
    label_5BAE_02EA_5BDCA_2300:
        CheckExternalEvents(cs4, 0x02EA);
        // 5BAE:02EA mov AX,0x00BD
        AX = (ushort)0x00BD;
        // 5BAE:02ED call near 0x0AA2
        NearCall(cs4, 0x02F0, unknown_5BAE_0AA2_5C582);
    label_5BAE_02F0_5BDD0_2303:
        CheckExternalEvents(cs4, 0x02F0);
        // 5BAE:02F0 mov AX,0x4008
        AX = (ushort)0x4008;
        // 5BAE:02F3 call near 0x0AA2
        NearCall(cs4, 0x02F6, unknown_5BAE_0AA2_5C582);
    label_5BAE_02F6_5BDD6_2306:
        CheckExternalEvents(cs4, 0x02F6);
        // 5BAE:02F6 push CS
        Stack.Push16(CS);
        // 5BAE:02F7 call near 0x02FE
        NearCall(cs4, 0x02FA, unknown_5BAE_02FE_5BDDE);
    label_5BAE_02FA_5BDDA_2351:
        CheckExternalEvents(cs4, 0x02FA);
        // 5BAE:02FA mov BX,0x0F00
        BX = (ushort)0x0F00;
        // 5BAE:02FD ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0103_5BBE3(int loadOffset)
    {
    label_5BAE_0103_5BBE3_3672:
        CheckExternalEvents(cs4, 0x0103);
        // 5BAE:0103 jmp near 0x03B2
    label_5BAE_03B2_5BE92_3674:
        CheckExternalEvents(cs4, 0x03B2);
        // 5BAE:03B2 push DS
        Stack.Push16(DS);
        // 5BAE:03B3 push CS
        Stack.Push16(CS);
        // 5BAE:03B4 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:03B5 mov byte ptr DS:[0x019B],AL
        UInt8[DS, (ushort)0x019B] = AL;
        // 5BAE:03B8 mov AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        // 5BAE:03BB mov DI,0x03A8
        DI = (ushort)0x03A8;
        // 5BAE:03BE mov word ptr DS:[DI],SI
        UInt16[DS, DI] = SI;
        // 5BAE:03C0 mov word ptr DS:[DI+2],ES
        UInt16[DS, (ushort)(DI + (sbyte)2)] = ES;
        // 5BAE:03C3 mov word ptr DS:[DI+4],AX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = AX;
        // 5BAE:03C6 mov AX,word ptr ES:[SI+0x4000]
        AX = UInt16[ES, (ushort)(SI + (short)16384)];
        // 5BAE:03CB mov word ptr DS:[DI+6],AX
        UInt16[DS, (ushort)(DI + (sbyte)6)] = AX;
        // 5BAE:03CE mov AX,word ptr ES:[SI-32768]
        AX = UInt16[ES, (ushort)(SI + (short)-32768)];
        // 5BAE:03D3 mov word ptr DS:[DI+8],AX
        UInt16[DS, (ushort)(DI + (sbyte)8)] = AX;
        // 5BAE:03D6 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5BAE:03D9 mov word ptr DS:[0x0115],SI
        UInt16[DS, (ushort)0x0115] = SI;
        // 5BAE:03DD mov word ptr DS:[0x0117],ES
        UInt16[DS, (ushort)0x0117] = ES;
        // 5BAE:03E1 sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5BAE:03E4 add SI,word ptr ES:[SI]
        SI = Alu16.Add(SI, UInt16[ES, SI]);
        // 5BAE:03E7 mov word ptr DS:[0x0119],SI
        UInt16[DS, (ushort)0x0119] = SI;
        // 5BAE:03EB mov word ptr DS:[0x011B],ES
        UInt16[DS, (ushort)0x011B] = ES;
        // 5BAE:03EF call near 0x099A
        NearCall(cs4, 0x03F2, unknown_5BAE_099A_5C47A);
    label_5BAE_03F2_5BED2_3708:
        CheckExternalEvents(cs4, 0x03F2);
        // 5BAE:03F2 call near 0x0413
        NearCall(cs4, 0x03F5, unknown_5BAE_0413_5BEF3);
    label_5BAE_03F5_5BED5_3788:
        CheckExternalEvents(cs4, 0x03F5);
        // 5BAE:03F5 mov AL,byte ptr DS:[0x019E]
        AL = UInt8[DS, (ushort)0x019E];
        // 5BAE:03F8 mov byte ptr DS:[0x019C],AL
        UInt8[DS, (ushort)0x019C] = AL;
        // 5BAE:03FB call near 0x0982
        NearCall(cs4, 0x03FE, unknown_5BAE_0982_5C462);
    label_5BAE_03FE_5BEDE_3805:
        CheckExternalEvents(cs4, 0x03FE);
        // 5BAE:03FE mov byte ptr DS:[0x019D],AL
        UInt8[DS, (ushort)0x019D] = AL;
        // 5BAE:0401 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5BAE:0403 mov word ptr DS:[0x011D],AX
        UInt16[DS, (ushort)0x011D] = AX;
        // 5BAE:0406 mov word ptr DS:[0x0123],AX
        UInt16[DS, (ushort)0x0123] = AX;
        // 5BAE:0409 call near 0x04D3
        NearCall(cs4, 0x040C, unknown_5BAE_04D3_5BFB3);
    label_5BAE_040C_5BEEC_4101:
        CheckExternalEvents(cs4, 0x040C);
        // 5BAE:040C mov AL,0x80
        AL = (byte)0x80;
        // 5BAE:040E mov byte ptr DS:[0x019A],AL
        UInt8[DS, (ushort)0x019A] = AL;
        // 5BAE:0411 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:0412 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0106_5BBE6(int loadOffset)
    {
    label_5BAE_0106_5BBE6_3392:
        CheckExternalEvents(cs4, 0x0106);
        // 5BAE:0106 jmp near 0x02FE
        return unknown_5BAE_02FE_5BDDE(0x0000);
    }

    public virtual Action unknown_5BAE_0109_5BBE9(int loadOffset)
    {
    label_5BAE_0109_5BBE9_17488:
        CheckExternalEvents(cs4, 0x0109);
        // 5BAE:0109 jmp near 0x039C
    label_5BAE_039C_5BE7C_17490:
        CheckExternalEvents(cs4, 0x039C);
        // 5BAE:039C mov byte ptr CS:[0x019B],1
        UInt8[CS, (ushort)0x019B] = (byte)0x01;
        // 5BAE:03A2 mov AL,byte ptr CS:[0x019A]
        AL = UInt8[CS, (ushort)0x019A];
        // 5BAE:03A6 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_010C_5BBEC(int loadOffset)
    {
    label_5BAE_010C_5BBEC_8599:
        CheckExternalEvents(cs4, 0x010C);
        // 5BAE:010C jmp near 0x035B
    label_5BAE_035B_5BE3B_8601:
        CheckExternalEvents(cs4, 0x035B);
        // 5BAE:035B push AX
        Stack.Push16(AX);
        // 5BAE:035C mov AX,BX
        AX = BX;
        // 5BAE:035E call near 0x030B
        NearCall(cs4, 0x0361, unknown_5BAE_030B_5BDEB);
    label_5BAE_0361_5BE41_8607:
        CheckExternalEvents(cs4, 0x0361);
        // 5BAE:0361 mov byte ptr CS:[0x019D],AL
        UInt8[CS, (ushort)0x019D] = AL;
        // 5BAE:0365 pop AX
        AX = Stack.Pop16();
        // 5BAE:0366 mov BX,0xFFFF
        BX = (ushort)0xFFFF;
        // 5BAE:0369 cmp AX,0x0060
        Alu16.Sub(AX, (ushort)0x0060);
        // 5BAE:036C jb short 0x0388
        if (CarryFlag)
        {
            goto label_5BAE_0388_5BE68_8617;
        }
    label_5BAE_036E_5BE4E_8613:
        CheckExternalEvents(cs4, 0x036E);
        // 5BAE:036E mov BX,0xAAAA
        BX = (ushort)0xAAAA;
        // 5BAE:0371 cmp AX,0x00C0
        Alu16.Sub(AX, (ushort)0x00C0);
        // 5BAE:0374 jb short 0x0388
        if (CarryFlag)
        {
            goto label_5BAE_0388_5BE68_8617;
        }
    label_5BAE_0376_5BE56_9325:
        CheckExternalEvents(cs4, 0x0376);
        // 5BAE:0376 mov BX,0x8888
        BX = (ushort)0x8888;
        // 5BAE:0379 cmp AX,0x0180
        Alu16.Sub(AX, (ushort)0x0180);
        // 5BAE:037C jb short 0x0388
        if (CarryFlag)
        {
            goto label_5BAE_0388_5BE68_8617;
        }
    label_5BAE_037E_5BE5E_9329:
        CheckExternalEvents(cs4, 0x037E);
        // 5BAE:037E mov BX,0x8080
        BX = (ushort)0x8080;
        // 5BAE:0381 cmp AX,0x0300
        Alu16.Sub(AX, (ushort)0x0300);
        // 5BAE:0384 jb short 0x0388
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:0384");
        }
    label_5BAE_0388_5BE68_8617:
        CheckExternalEvents(cs4, 0x0388);
        // 5BAE:0388 mov word ptr CS:[0x019F],BX
        UInt16[CS, (ushort)0x019F] = BX;
        // 5BAE:038D mov AL,byte ptr CS:[0x019A]
        AL = UInt8[CS, (ushort)0x019A];
        // 5BAE:0391 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5BAE:0393 jns short 0x039B
        if (!SignFlag)
        {
            goto label_5BAE_039B_5BE7B_8625;
        }
    label_5BAE_0395_5BE75_8622:
        CheckExternalEvents(cs4, 0x0395);
        // 5BAE:0395 or AL,0x40
        AL = Alu8.Or(AL, (byte)0x40);
        // 5BAE:0397 mov byte ptr CS:[0x019A],AL
        UInt8[CS, (ushort)0x019A] = AL;
    label_5BAE_039B_5BE7B_8625:
        CheckExternalEvents(cs4, 0x039B);
        // 5BAE:039B ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_010F_5BBEF(int loadOffset)
    {
    label_5BAE_010F_5BBEF_3329:
        CheckExternalEvents(cs4, 0x010F);
        // 5BAE:010F jmp near 0x0473
    label_5BAE_0473_5BF53_3331:
        CheckExternalEvents(cs4, 0x0473);
        // 5BAE:0473 push DS
        Stack.Push16(DS);
        // 5BAE:0474 mov AX,CS
        AX = CS;
        // 5BAE:0476 mov DS,AX
        DS = AX;
        // 5BAE:0478 cmp byte ptr DS:[0x019A],0
        Alu8.Sub(UInt8[DS, (ushort)0x019A], (byte)0x00);
        // 5BAE:047D jns short 0x04A0
        if (!SignFlag)
        {
            goto label_5BAE_04A0_5BF80_3337;
        }
    label_5BAE_047F_5BF5F_4163:
        CheckExternalEvents(cs4, 0x047F);
        // 5BAE:047F dec byte ptr DS:[0x011E]
        UInt8[DS, (ushort)0x011E] = Alu8.Dec(UInt8[DS, (ushort)0x011E]);
        // 5BAE:0483 jns short 0x0497
        if (!SignFlag)
        {
            goto label_5BAE_0497_5BF77_4166;
        }
    label_5BAE_0485_5BF65_4382:
        CheckExternalEvents(cs4, 0x0485);
        // 5BAE:0485 call near 0x04AD
        NearCall(cs4, 0x0488, unknown_5BAE_04AD_5BF8D);
    label_5BAE_0488_5BF68_4401:
        CheckExternalEvents(cs4, 0x0488);
        // 5BAE:0488 jne short 0x04A0
        if (!ZeroFlag)
        {
            goto label_5BAE_04A0_5BF80_3337;
        }
    label_5BAE_048A_5BF6A_4403:
        CheckExternalEvents(cs4, 0x048A);
        // 5BAE:048A push DX
        Stack.Push16(DX);
        // 5BAE:048B push SI
        Stack.Push16(SI);
        // 5BAE:048C push DI
        Stack.Push16(DI);
        // 5BAE:048D push BP
        Stack.Push16(BP);
        // 5BAE:048E push ES
        Stack.Push16(ES);
        // 5BAE:048F call near 0x04D3
        NearCall(cs4, 0x0492, unknown_5BAE_04D3_5BFB3);
    label_5BAE_0492_5BF72_4410:
        CheckExternalEvents(cs4, 0x0492);
        // 5BAE:0492 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:0493 pop BP
        BP = Stack.Pop16();
        // 5BAE:0494 pop DI
        DI = Stack.Pop16();
        // 5BAE:0495 pop SI
        SI = Stack.Pop16();
        // 5BAE:0496 pop DX
        DX = Stack.Pop16();
    label_5BAE_0497_5BF77_4166:
        CheckExternalEvents(cs4, 0x0497);
        // 5BAE:0497 rol word ptr DS:[0x019F],1
        UInt16[DS, (ushort)0x019F] = Alu16.Rol(UInt16[DS, (ushort)0x019F], unchecked((byte)1));
        // 5BAE:049B jae short 0x04A0
        if (!CarryFlag)
        {
            goto label_5BAE_04A0_5BF80_3337;
        }
    label_5BAE_049D_5BF7D_4169:
        CheckExternalEvents(cs4, 0x049D);
        // 5BAE:049D call near 0x092D
        NearCall(cs4, 0x04A0, unknown_5BAE_092D_5C40D);
    label_5BAE_04A0_5BF80_3337:
        CheckExternalEvents(cs4, 0x04A0);
        // 5BAE:04A0 mov AL,byte ptr DS:[0x019A]
        AL = UInt8[DS, (ushort)0x019A];
        // 5BAE:04A3 mov BX,word ptr DS:[0x011F]
        BX = UInt16[DS, (ushort)0x011F];
        // 5BAE:04A7 mov CX,word ptr DS:[0x0121]
        CX = UInt16[DS, (ushort)0x0121];
        // 5BAE:04AB pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:04AC ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0112_5BBF2(int loadOffset)
    {
    label_5BAE_0112_5BBF2_2367:
        CheckExternalEvents(cs4, 0x0112);
        // 5BAE:0112 jmp near 0x0348
    label_5BAE_0348_5BE28_2369:
        CheckExternalEvents(cs4, 0x0348);
        // 5BAE:0348 call near 0x030B
        NearCall(cs4, 0x034B, unknown_5BAE_030B_5BDEB);
    label_5BAE_034B_5BE2B_2404:
        CheckExternalEvents(cs4, 0x034B);
        // 5BAE:034B mov byte ptr CS:[0x019E],AL
        UInt8[CS, (ushort)0x019E] = AL;
        // 5BAE:034F mov byte ptr CS:[0x019D],AL
        UInt8[CS, (ushort)0x019D] = AL;
        // 5BAE:0353 mov word ptr CS:[0x019F],0xFFFF
        UInt16[CS, (ushort)0x019F] = (ushort)0xFFFF;
        // 5BAE:035A ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_02B5_5BD95(int loadOffset)
    {
    label_5BAE_02B5_5BD95_2224:
        CheckExternalEvents(cs4, 0x02B5);
        // 5BAE:02B5 push SS
        Stack.Push16(SS);
        // 5BAE:02B6 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:02B7 mov SI,BP
        SI = BP;
    label_5BAE_02B9_5BD99_2228:
        CheckExternalEvents(cs4, 0x02B9);
        // 5BAE:02B9 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 5BAE:02BB add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 5BAE:02BE mov DI,AX
        DI = AX;
        // 5BAE:02C0 push CX
        Stack.Push16(CX);
        // 5BAE:02C1 mov CX,9
        CX = (ushort)0x0009;
        // 5BAE:02C4 mov AL,0x2E
        AL = (byte)0x2E;
        // 5BAE:02C6 repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_5BAE_02C6_5BDA6 = true;
        while (CX != (ushort)0x0000 && shouldContinue_5BAE_02C6_5BDA6)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_5BAE_02C6_5BDA6 = ZeroFlag == false;
        }
        // 5BAE:02C8 pop CX
        CX = Stack.Pop16();
        // 5BAE:02C9 jne short 0x02D5
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5BAE:02C9");
        }
    label_5BAE_02CB_5BDAB_2237:
        CheckExternalEvents(cs4, 0x02CB);
        // 5BAE:02CB mov AX,word ptr CS:[0x02B0]
        AX = UInt16[CS, (ushort)0x02B0];
        // 5BAE:02CF stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5BAE:02D0 mov AL,byte ptr CS:[0x02B2]
        AL = UInt8[CS, (ushort)0x02B2];
        // 5BAE:02D4 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 5BAE:02D5 loop 0x02B9
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_02B9_5BD99_2228;
        }
    label_5BAE_02D7_5BDB7_2244:
        CheckExternalEvents(cs4, 0x02D7);
        // 5BAE:02D7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_02FE_5BDDE(int loadOffset)
    {
    label_5BAE_02FE_5BDDE_2309:
        CheckExternalEvents(cs4, 0x02FE);
        // 5BAE:02FE pushf
        Stack.Push16(FlagRegister16);
    label_5BAE_02FF_5BDDF_2311:
        CheckExternalEvents(cs4, 0x02FF);
        // 5BAE:02FF cli
        InterruptFlag = false;
        // 5BAE:0300 call near 0x091B
        NearCall(cs4, 0x0303, unknown_5BAE_091B_5C3FB);
    label_5BAE_0303_5BDE3_2344:
        CheckExternalEvents(cs4, 0x0303);
        // 5BAE:0303 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5BAE:0305 mov byte ptr CS:[0x019A],AL
        UInt8[CS, (ushort)0x019A] = AL;
    label_5BAE_0309_5BDE9_2347:
        CheckExternalEvents(cs4, 0x0309);
        // 5BAE:0309 popf
        FlagRegister16 = Stack.Pop16();
    label_5BAE_030A_5BDEA_2349:
        CheckExternalEvents(cs4, 0x030A);
        // 5BAE:030A ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_030B_5BDEB(int loadOffset)
    {
    label_5BAE_030B_5BDEB_2371:
        CheckExternalEvents(cs4, 0x030B);
        // 5BAE:030B push BX
        Stack.Push16(BX);
        // 5BAE:030C push DX
        Stack.Push16(DX);
        // 5BAE:030D shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5BAE:030F shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5BAE:0311 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5BAE:0313 mov DX,AX
        DX = AX;
        // 5BAE:0315 mov BX,0xF078
        BX = (ushort)0xF078;
        // 5BAE:0318 cmp AH,BL
        Alu8.Sub(AH, BL);
        // 5BAE:031A jbe short 0x031E
        if (CarryFlag || ZeroFlag)
        {
            goto label_5BAE_031E_5BDFE_2381;
        }
    label_5BAE_031C_5BDFC_8605:
        CheckExternalEvents(cs4, 0x031C);
        // 5BAE:031C mov AH,BL
        AH = BL;
    label_5BAE_031E_5BDFE_2381:
        CheckExternalEvents(cs4, 0x031E);
        // 5BAE:031E xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5BAE:0320 div BH
        byte divisor_5BAE_0320_5BE00 = BH;
        ushort dividend_5BAE_0320_5BE00 = AX;
        byte quotient_5BAE_0320_5BE00 = Alu8.Div(unchecked((ushort)dividend_5BAE_0320_5BE00), unchecked((byte)divisor_5BAE_0320_5BE00));
        AL = unchecked((byte)quotient_5BAE_0320_5BE00);
        AH = unchecked((byte)(dividend_5BAE_0320_5BE00 % unchecked((ushort)divisor_5BAE_0320_5BE00)));
        // 5BAE:0322 mul DL
        ushort result_5BAE_0322_5BE02 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)DL)));
        AH = unchecked((byte)(result_5BAE_0322_5BE02 >> 8));
        AL = unchecked((byte)result_5BAE_0322_5BE02);
        // 5BAE:0324 xchg AH,DH
        byte temp_5BAE_0324_5BE04 = AH;
        AH = DH;
        DH = unchecked((byte)temp_5BAE_0324_5BE04);
        // 5BAE:0326 sub AH,BH
        AH = Alu8.Sub(AH, BH);
        // 5BAE:0328 neg AH
        AH = Alu8.Sub((byte)0x00, AH);
        CarryFlag = AH != (byte)0x00;
        // 5BAE:032A cmp AH,BL
        Alu8.Sub(AH, BL);
        // 5BAE:032C jbe short 0x0330
        if (CarryFlag || ZeroFlag)
        {
            goto label_5BAE_0330_5BE10_2390;
        }
    label_5BAE_032E_5BE0E_14437:
        CheckExternalEvents(cs4, 0x032E);
        // 5BAE:032E mov AH,BL
        AH = BL;
    label_5BAE_0330_5BE10_2390:
        CheckExternalEvents(cs4, 0x0330);
        // 5BAE:0330 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5BAE:0332 div BH
        byte divisor_5BAE_0332_5BE12 = BH;
        ushort dividend_5BAE_0332_5BE12 = AX;
        byte quotient_5BAE_0332_5BE12 = Alu8.Div(unchecked((ushort)dividend_5BAE_0332_5BE12), unchecked((byte)divisor_5BAE_0332_5BE12));
        AL = unchecked((byte)quotient_5BAE_0332_5BE12);
        AH = unchecked((byte)(dividend_5BAE_0332_5BE12 % unchecked((ushort)divisor_5BAE_0332_5BE12)));
        // 5BAE:0334 mul DL
        ushort result_5BAE_0334_5BE14 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)DL)));
        AH = unchecked((byte)(result_5BAE_0334_5BE14 >> 8));
        AL = unchecked((byte)result_5BAE_0334_5BE14);
        // 5BAE:0336 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5BAE:0338 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5BAE:033A shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5BAE:033C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5BAE:033E mov AH,DH
        AH = DH;
        // 5BAE:0340 and AX,0x0FF0
        AX = Alu16.And(AX, (ushort)0x0FF0);
        // 5BAE:0343 or AL,AH
        AL = Alu8.Or(AL, AH);
        // 5BAE:0345 pop DX
        DX = Stack.Pop16();
        // 5BAE:0346 pop BX
        BX = Stack.Pop16();
        // 5BAE:0347 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0413_5BEF3(int loadOffset)
    {
    label_5BAE_0413_5BEF3_3710:
        CheckExternalEvents(cs4, 0x0413);
        // 5BAE:0413 push DS
        Stack.Push16(DS);
        // 5BAE:0414 push DS
        Stack.Push16(DS);
        // 5BAE:0415 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:0416 lds SI,word ptr DS:[0x0115]
        ushort lxsOffset_5BAE_0416_5BEF6 = (ushort)0x0115;
        ushort lxsValue_5BAE_0416_5BEF6 = UInt16[DS, lxsOffset_5BAE_0416_5BEF6];
        ushort lxsSegment_5BAE_0416_5BEF6 = UInt16[DS, (ushort)(lxsOffset_5BAE_0416_5BEF6 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5BAE_0416_5BEF6);
        DS = unchecked((ushort)lxsSegment_5BAE_0416_5BEF6);
        // 5BAE:041A mov BP,SI
        BP = SI;
        // 5BAE:041C mov DI,0x01C6
        DI = (ushort)0x01C6;
        // 5BAE:041F mov CX,9
        CX = (ushort)0x0009;
    label_5BAE_0422_5BF02_3718:
        CheckExternalEvents(cs4, 0x0422);
        // 5BAE:0422 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 5BAE:0423 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 5BAE:0425 je short 0x0429
        if (ZeroFlag)
        {
            goto label_5BAE_0429_5BF09_3723;
        }
    label_5BAE_0427_5BF07_3721:
        CheckExternalEvents(cs4, 0x0427);
        // 5BAE:0427 add AX,BP
        AX = Alu16.Add(AX, BP);
    label_5BAE_0429_5BF09_3723:
        CheckExternalEvents(cs4, 0x0429);
        // 5BAE:0429 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5BAE:042A loop 0x0422
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_0422_5BF02_3718;
        }
    label_5BAE_042C_5BF0C_3726:
        CheckExternalEvents(cs4, 0x042C);
        // 5BAE:042C mov DI,0x01D8
        DI = (ushort)0x01D8;
        // 5BAE:042F mov CL,9
        CL = (byte)0x09;
        // 5BAE:0431 mov AX,0x00FF
        AX = (ushort)0x00FF;
        // 5BAE:0434 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 5BAE:0436 mov DI,0x01FC
        DI = (ushort)0x01FC;
        // 5BAE:0439 mov CL,9
        CL = (byte)0x09;
        // 5BAE:043B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5BAE:043D rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 5BAE:043F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:0440 les SI,word ptr DS:[0x0115]
        ushort lxsOffset_5BAE_0440_5BF20 = (ushort)0x0115;
        ushort lxsValue_5BAE_0440_5BF20 = UInt16[DS, lxsOffset_5BAE_0440_5BF20];
        ushort lxsSegment_5BAE_0440_5BF20 = UInt16[DS, (ushort)(lxsOffset_5BAE_0440_5BF20 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5BAE_0440_5BF20);
        ES = unchecked((ushort)lxsSegment_5BAE_0440_5BF20);
        return unknown_5BAE_0444_5BF24(0x0000);
    }

    public virtual Action unknown_5BAE_0444_5BF24(int loadOffset)
    {
    label_5BAE_0444_5BF24_3737:
        CheckExternalEvents(cs4, 0x0444);
        // 5BAE:0444 mov word ptr DS:[0x011F],1
        UInt16[DS, (ushort)0x011F] = (ushort)0x0001;
        // 5BAE:044A mov word ptr DS:[0x0121],0x0060
        UInt16[DS, (ushort)0x0121] = (ushort)0x0060;
        // 5BAE:0450 mov CX,9
        CX = (ushort)0x0009;
        // 5BAE:0453 mov DI,0x01A2
        DI = (ushort)0x01A2;
    label_5BAE_0456_5BF36_3741:
        CheckExternalEvents(cs4, 0x0456);
        // 5BAE:0456 mov SI,word ptr DS:[DI+0x24]
        SI = UInt16[DS, (ushort)(DI + (sbyte)36)];
        // 5BAE:0459 mov word ptr DS:[DI+0x12],SI
        UInt16[DS, (ushort)(DI + (sbyte)18)] = SI;
        // 5BAE:045C mov word ptr DS:[DI],0xFFFF
        UInt16[DS, DI] = (ushort)0xFFFF;
        // 5BAE:0460 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 5BAE:0462 je short 0x046D
        if (ZeroFlag)
        {
            goto label_5BAE_046D_5BF4D_3763;
        }
    label_5BAE_0464_5BF44_3746:
        CheckExternalEvents(cs4, 0x0464);
        // 5BAE:0464 mov AX,CX
        AX = CX;
        // 5BAE:0466 call near 0x08E1
        NearCall(cs4, 0x0469, unknown_5BAE_08E1_5C3C1);
    label_5BAE_0469_5BF49_3760:
        CheckExternalEvents(cs4, 0x0469);
        // 5BAE:0469 inc word ptr DS:[DI]
        UInt16[DS, DI] = Alu16.Inc(UInt16[DS, DI]);
        // 5BAE:046B mov CX,AX
        CX = AX;
    label_5BAE_046D_5BF4D_3763:
        CheckExternalEvents(cs4, 0x046D);
        // 5BAE:046D add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5BAE:0470 loop 0x0456
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_0456_5BF36_3741;
        }
    label_5BAE_0472_5BF52_3786:
        CheckExternalEvents(cs4, 0x0472);
        // 5BAE:0472 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_04AD_5BF8D(int loadOffset)
    {
    label_5BAE_04AD_5BF8D_4384:
        CheckExternalEvents(cs4, 0x04AD);
        // 5BAE:04AD push SI
        Stack.Push16(SI);
        // 5BAE:04AE push ES
        Stack.Push16(ES);
        // 5BAE:04AF les SI,word ptr DS:[0x03A8]
        ushort lxsOffset_5BAE_04AF_5BF8F = (ushort)0x03A8;
        ushort lxsValue_5BAE_04AF_5BF8F = UInt16[DS, lxsOffset_5BAE_04AF_5BF8F];
        ushort lxsSegment_5BAE_04AF_5BF8F = UInt16[DS, (ushort)(lxsOffset_5BAE_04AF_5BF8F + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5BAE_04AF_5BF8F);
        ES = unchecked((ushort)lxsSegment_5BAE_04AF_5BF8F);
        // 5BAE:04B3 mov AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        // 5BAE:04B6 cmp word ptr DS:[0x03AC],AX
        Alu16.Sub(UInt16[DS, (ushort)0x03AC], AX);
        // 5BAE:04BA jne short 0x04D0
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5BAE:04BA");
        }
    label_5BAE_04BC_5BF9C_4391:
        CheckExternalEvents(cs4, 0x04BC);
        // 5BAE:04BC mov AX,word ptr ES:[SI+0x4000]
        AX = UInt16[ES, (ushort)(SI + (short)16384)];
        // 5BAE:04C1 cmp word ptr DS:[0x03AE],AX
        Alu16.Sub(UInt16[DS, (ushort)0x03AE], AX);
        // 5BAE:04C5 jne short 0x04D0
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5BAE:04C5");
        }
    label_5BAE_04C7_5BFA7_4395:
        CheckExternalEvents(cs4, 0x04C7);
        // 5BAE:04C7 mov AX,word ptr ES:[SI-32768]
        AX = UInt16[ES, (ushort)(SI + (short)-32768)];
        // 5BAE:04CC cmp word ptr DS:[0x03B0],AX
        Alu16.Sub(UInt16[DS, (ushort)0x03B0], AX);
        // 5BAE:04D0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:04D1 pop SI
        SI = Stack.Pop16();
        // 5BAE:04D2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_04D3_5BFB3(int loadOffset)
    {
    label_5BAE_04D3_5BFB3_3811:
        CheckExternalEvents(cs4, 0x04D3);
        // 5BAE:04D3 les BX,word ptr DS:[0x0115]
        ushort lxsOffset_5BAE_04D3_5BFB3 = (ushort)0x0115;
        ushort lxsValue_5BAE_04D3_5BFB3 = UInt16[DS, lxsOffset_5BAE_04D3_5BFB3];
        ushort lxsSegment_5BAE_04D3_5BFB3 = UInt16[DS, (ushort)(lxsOffset_5BAE_04D3_5BFB3 + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_5BAE_04D3_5BFB3);
        ES = unchecked((ushort)lxsSegment_5BAE_04D3_5BFB3);
        // 5BAE:04D7 mov AX,word ptr ES:[BX+0x30]
        AX = UInt16[ES, (ushort)(BX + (sbyte)48)];
        // 5BAE:04DB add word ptr DS:[0x011D],AX
        UInt16[DS, (ushort)0x011D] = Alu16.Add(UInt16[DS, (ushort)0x011D], AX);
        // 5BAE:04DF mov DI,0x01A2
        DI = (ushort)0x01A2;
        // 5BAE:04E2 call near 0x0553
        NearCall(cs4, 0x04E5, unknown_5BAE_0553_5C033);
    label_5BAE_04E5_5BFC5_3826:
        CheckExternalEvents(cs4, 0x04E5);
        // 5BAE:04E5 mov CX,9
        CX = (ushort)0x0009;
    label_5BAE_04E8_5BFC8_3828:
        CheckExternalEvents(cs4, 0x04E8);
        // 5BAE:04E8 dec word ptr DS:[DI]
        UInt16[DS, DI] = Alu16.Dec(UInt16[DS, DI]);
        // 5BAE:04EA jne short 0x052A
        if (!ZeroFlag)
        {
            goto label_5BAE_052A_5C00A_4093;
        }
    label_5BAE_04EC_5BFCC_3830:
        CheckExternalEvents(cs4, 0x04EC);
        // 5BAE:04EC mov SI,word ptr DS:[DI+0x12]
        SI = UInt16[DS, (ushort)(DI + (sbyte)18)];
        // 5BAE:04EF or SI,SI
        SI = Alu16.Or(SI, SI);
        // 5BAE:04F1 je short 0x0515
        if (ZeroFlag)
        {
            goto label_5BAE_0515_5BFF5_4089;
        }
    label_5BAE_04F3_5BFD3_3834:
        CheckExternalEvents(cs4, 0x04F3);
        // 5BAE:04F3 push CX
        Stack.Push16(CX);
        // 5BAE:04F4 push DI
        Stack.Push16(DI);
        // 5BAE:04F5 lods AX,word ptr ES:[SI]
        AX = UInt16[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 5BAE:04F7 mov DX,DI
        DX = DI;
        // 5BAE:04F9 sub DX,0x01A2
        DX = Alu16.Sub(DX, (ushort)0x01A2);
        // 5BAE:04FD shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 5BAE:04FF mov BX,AX
        BX = AX;
        // 5BAE:0501 and BX,0x0070
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)112)));
        // 5BAE:0504 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5BAE:0506 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5BAE:0508 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5BAE:050A call near word ptr DS:[BX+0x0125]
        switch ((ushort)(UInt16[DS, (ushort)(BX + (short)293)]))
        {
            case 0x05AA:
                NearCall(cs4, 0x050E, unknown_5BAE_05AA_5C08A);
                break;
            case 0x062C:
                NearCall(cs4, 0x050E, unknown_5BAE_062C_5C10C);
                break;
            case 0x065B:
                NearCall(cs4, 0x050E, unknown_5BAE_065B_5C13B);
                break;
            case 0x066F:
                NearCall(cs4, 0x050E, unknown_5BAE_066F_5C14F);
                break;
            case 0x06A8:
                NearCall(cs4, 0x050E, unknown_5BAE_06A8_5C188);
                break;
            case 0x07EA:
                NearCall(cs4, 0x050E, unknown_5BAE_07EA_5C2CA);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(BX + (short)293)])):X4} at 5BAE:050A");
        }
    label_5BAE_050E_5BFEE_3978:
        CheckExternalEvents(cs4, 0x050E);
        // 5BAE:050E pop DI
        DI = Stack.Pop16();
        // 5BAE:050F pop CX
        CX = Stack.Pop16();
        // 5BAE:0510 cmp word ptr DS:[DI],0
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5BAE:0513 je short 0x04EC
        if (ZeroFlag)
        {
            goto label_5BAE_04EC_5BFCC_3830;
        }
    label_5BAE_0515_5BFF5_4089:
        CheckExternalEvents(cs4, 0x0515);
        // 5BAE:0515 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5BAE:0518 loop 0x04E8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_04E8_5BFC8_3828;
        }
    label_5BAE_051A_5BFFA_4096:
        CheckExternalEvents(cs4, 0x051A);
        // 5BAE:051A dec byte ptr DS:[0x0121]
        UInt8[DS, (ushort)0x0121] = Alu8.Dec(UInt8[DS, (ushort)0x0121]);
        // 5BAE:051E jne short 0x0529
        if (!ZeroFlag)
        {
            goto label_5BAE_0529_5C009_4099;
        }
    label_5BAE_0520_5C000_4933:
        CheckExternalEvents(cs4, 0x0520);
        // 5BAE:0520 mov byte ptr DS:[0x0121],0x60
        UInt8[DS, (ushort)0x0121] = (byte)0x60;
        // 5BAE:0525 inc word ptr DS:[0x011F]
        UInt16[DS, (ushort)0x011F] = Alu16.Inc(UInt16[DS, (ushort)0x011F]);
    label_5BAE_0529_5C009_4099:
        CheckExternalEvents(cs4, 0x0529);
        // 5BAE:0529 ret near
        return NearRet((ushort)0x0000);
    label_5BAE_052A_5C00A_4093:
        CheckExternalEvents(cs4, 0x052A);
        // 5BAE:052A cmp byte ptr DS:[DI+0x5A],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)90)], (byte)0x00);
        // 5BAE:052E je short 0x0515
        if (ZeroFlag)
        {
            goto label_5BAE_0515_5BFF5_4089;
        }
    label_5BAE_0530_5C010_5029:
        CheckExternalEvents(cs4, 0x0530);
        // 5BAE:0530 mov SI,word ptr DS:[DI+0x12]
        SI = UInt16[DS, (ushort)(DI + (sbyte)18)];
        // 5BAE:0533 or SI,SI
        SI = Alu16.Or(SI, SI);
        // 5BAE:0535 je short 0x0515
        if (ZeroFlag)
        {
            goto label_5BAE_0515_5BFF5_4089;
        }
    label_5BAE_0537_5C017_5033:
        CheckExternalEvents(cs4, 0x0537);
        // 5BAE:0537 push CX
        Stack.Push16(CX);
        // 5BAE:0538 push DI
        Stack.Push16(DI);
        // 5BAE:0539 dec byte ptr DS:[DI+0x5A]
        UInt8[DS, (ushort)(DI + (sbyte)90)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (sbyte)90)]);
        // 5BAE:053C mov AX,word ptr DS:[DI+0x6C]
        AX = UInt16[DS, (ushort)(DI + (sbyte)108)];
        // 5BAE:053F add AL,AH
        AL = Alu8.Add(AL, AH);
        // 5BAE:0541 mov byte ptr DS:[DI+0x6C],AL
        UInt8[DS, (ushort)(DI + (sbyte)108)] = AL;
        // 5BAE:0544 mov DX,DI
        DX = DI;
        // 5BAE:0546 sub DX,0x01A2
        DX = Alu16.Sub(DX, (ushort)0x01A2);
        // 5BAE:054A shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 5BAE:054C call near 0x07EF
        NearCall(cs4, 0x054F, unknown_5BAE_07EF_5C2CF);
    label_5BAE_054F_5C02F_5092:
        CheckExternalEvents(cs4, 0x054F);
        // 5BAE:054F pop DI
        DI = Stack.Pop16();
        // 5BAE:0550 pop CX
        CX = Stack.Pop16();
        // 5BAE:0551 jmp short 0x0515
        goto label_5BAE_0515_5BFF5_4089;
    }

    public virtual Action unknown_5BAE_0553_5C033(int loadOffset)
    {
    label_5BAE_0553_5C033_3817:
        CheckExternalEvents(cs4, 0x0553);
        // 5BAE:0553 cmp word ptr DS:[0x0123],0
        Alu16.Sub(UInt16[DS, (ushort)0x0123], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5BAE:0558 jne short 0x0585
        if (!ZeroFlag)
        {
            goto label_5BAE_0585_5C065_11575;
        }
    label_5BAE_055A_5C03A_3820:
        CheckExternalEvents(cs4, 0x055A);
        // 5BAE:055A mov AX,word ptr ES:[BX+0x2A]
        AX = UInt16[ES, (ushort)(BX + (sbyte)42)];
        // 5BAE:055E cmp AX,word ptr DS:[0x011F]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x011F]);
        // 5BAE:0562 jne short 0x0584
        if (!ZeroFlag)
        {
            goto label_5BAE_0584_5C064_3824;
        }
    label_5BAE_0564_5C044_5175:
        CheckExternalEvents(cs4, 0x0564);
        // 5BAE:0564 cmp word ptr DS:[0x0121],0x0060
        Alu16.Sub(UInt16[DS, (ushort)0x0121], unchecked((ushort)unchecked((short)(sbyte)96)));
        // 5BAE:0569 jne short 0x0584
        if (!ZeroFlag)
        {
            goto label_5BAE_0584_5C064_3824;
        }
    label_5BAE_056B_5C04B_5178:
        CheckExternalEvents(cs4, 0x056B);
        // 5BAE:056B push DI
        Stack.Push16(DI);
        // 5BAE:056C push ES
        Stack.Push16(ES);
        // 5BAE:056D mov SI,DI
        SI = DI;
        // 5BAE:056F add DI,0x00EA
        DI = Alu16.Add(DI, (ushort)0x00EA);
        // 5BAE:0573 push DS
        Stack.Push16(DS);
        // 5BAE:0574 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:0575 mov CX,0x0012
        CX = (ushort)0x0012;
        // 5BAE:0578 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 5BAE:057A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:057B pop DI
        DI = Stack.Pop16();
        // 5BAE:057C mov AX,word ptr ES:[BX+0x2E]
        AX = UInt16[ES, (ushort)(BX + (sbyte)46)];
        // 5BAE:0580 dec AX
        AX = Alu16.Dec(AX);
        // 5BAE:0581 mov word ptr DS:[0x0123],AX
        UInt16[DS, (ushort)0x0123] = AX;
    label_5BAE_0584_5C064_3824:
        CheckExternalEvents(cs4, 0x0584);
        // 5BAE:0584 ret near
        return NearRet((ushort)0x0000);
    label_5BAE_0585_5C065_11575:
        CheckExternalEvents(cs4, 0x0585);
        // 5BAE:0585 mov AX,word ptr ES:[BX+0x2C]
        AX = UInt16[ES, (ushort)(BX + (sbyte)44)];
        // 5BAE:0589 cmp AX,word ptr DS:[0x011F]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x011F]);
        // 5BAE:058D jne short 0x0584
        if (!ZeroFlag)
        {
            goto label_5BAE_0584_5C064_3824;
        }
    label_5BAE_058F_5C06F_32002:
        CheckExternalEvents(cs4, 0x058F);
        // 5BAE:058F dec word ptr DS:[0x0123]
        UInt16[DS, (ushort)0x0123] = Alu16.Dec(UInt16[DS, (ushort)0x0123]);
        // 5BAE:0593 push DI
        Stack.Push16(DI);
        // 5BAE:0594 push ES
        Stack.Push16(ES);
        // 5BAE:0595 lea SI,DI+0x00EA
        SI = unchecked((ushort)(DI + (short)234));
        // 5BAE:0599 push DS
        Stack.Push16(DS);
        // 5BAE:059A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:059B mov CX,0x0012
        CX = (ushort)0x0012;
        // 5BAE:059E rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 5BAE:05A0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:05A1 pop DI
        DI = Stack.Pop16();
        // 5BAE:05A2 mov AX,word ptr ES:[BX+0x2A]
        AX = UInt16[ES, (ushort)(BX + (sbyte)42)];
        // 5BAE:05A6 mov word ptr DS:[0x011F],AX
        UInt16[DS, (ushort)0x011F] = AX;
        return unknown_5BAE_05A9_5C089(0x0000);
    }

    public virtual Action unknown_5BAE_05AA_5C08A(int loadOffset)
    {
    label_5BAE_05AA_5C08A_3847:
        CheckExternalEvents(cs4, 0x05AA);
        // 5BAE:05AA call near 0x08E1
        NearCall(cs4, 0x05AD, unknown_5BAE_08E1_5C3C1);
    label_5BAE_05AD_5C08D_3849:
        CheckExternalEvents(cs4, 0x05AD);
        // 5BAE:05AD cmp byte ptr DS:[DI+0x36],AH
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)54)], AH);
        // 5BAE:05B0 je short 0x05A9
        if (ZeroFlag)
        {
            return unknown_5BAE_05A9_5C089(0x0000);
        }
    label_5BAE_05B2_5C092_3852:
        CheckExternalEvents(cs4, 0x05B2);
        // 5BAE:05B2 mov byte ptr DS:[DI+0x36],AH
        UInt8[DS, (ushort)(DI + (sbyte)54)] = AH;
        // 5BAE:05B5 mov AL,0x28
        AL = (byte)0x28;
        // 5BAE:05B7 mul AH
        ushort result_5BAE_05B7_5C097 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_5BAE_05B7_5C097 >> 8));
        AL = unchecked((byte)result_5BAE_05B7_5C097);
        // 5BAE:05B9 les SI,word ptr DS:[0x0119]
        ushort lxsOffset_5BAE_05B9_5C099 = (ushort)0x0119;
        ushort lxsValue_5BAE_05B9_5C099 = UInt16[DS, lxsOffset_5BAE_05B9_5C099];
        ushort lxsSegment_5BAE_05B9_5C099 = UInt16[DS, (ushort)(lxsOffset_5BAE_05B9_5C099 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5BAE_05B9_5C099);
        ES = unchecked((ushort)lxsSegment_5BAE_05B9_5C099);
        // 5BAE:05BD add SI,AX
        SI = Alu16.Add(SI, AX);
        // 5BAE:05BF mov AX,word ptr ES:[SI+0x21]
        AX = UInt16[ES, (ushort)(SI + (sbyte)33)];
        // 5BAE:05C3 mov word ptr DS:[DI+0x48],AX
        UInt16[DS, (ushort)(DI + (sbyte)72)] = AX;
        // 5BAE:05C6 mov AH,byte ptr ES:[SI+0x17]
        AH = UInt8[ES, (ushort)(SI + (sbyte)23)];
        // 5BAE:05CA mov AL,byte ptr ES:[SI+0x0A]
        AL = UInt8[ES, (ushort)(SI + (sbyte)10)];
        // 5BAE:05CE mov BH,byte ptr ES:[SI+2]
        BH = UInt8[ES, (ushort)(SI + (sbyte)2)];
        // 5BAE:05D2 mov BL,byte ptr ES:[SI+0x0F]
        BL = UInt8[ES, (ushort)(SI + (sbyte)15)];
        // 5BAE:05D6 and BX,0x0303
        BX = Alu16.And(BX, (ushort)0x0303);
        // 5BAE:05DA ror BX,1
        BX = Alu16.Ror(BX, 1);
        // 5BAE:05DC ror BX,1
        BX = Alu16.Ror(BX, 1);
        // 5BAE:05DE or AX,BX
        AX = Alu16.Or(AX, BX);
        // 5BAE:05E0 mov word ptr DS:[DI+0x0090],AX
        UInt16[DS, (ushort)(DI + (short)144)] = AX;
        // 5BAE:05E4 mov AX,word ptr ES:[SI+0x1E]
        AX = UInt16[ES, (ushort)(SI + (sbyte)30)];
        // 5BAE:05E8 mov word ptr DS:[DI+0x7E],AX
        UInt16[DS, (ushort)(DI + (sbyte)126)] = AX;
        // 5BAE:05EB mov AX,word ptr ES:[SI+0x26]
        AX = UInt16[ES, (ushort)(SI + (sbyte)38)];
        // 5BAE:05EF mov word ptr DS:[DI+0x00C6],AX
        UInt16[DS, (ushort)(DI + (short)198)] = AX;
        // 5BAE:05F3 mov AL,byte ptr ES:[SI+0x0E]
        AL = UInt8[ES, (ushort)(SI + (sbyte)14)];
        // 5BAE:05F7 not AL
        AL = unchecked((byte)~AL);
        // 5BAE:05F9 ror AL,1
        AL = Alu8.Ror(AL, 1);
        // 5BAE:05FB mov AH,byte ptr ES:[SI+4]
        AH = UInt8[ES, (ushort)(SI + (sbyte)4)];
        // 5BAE:05FF shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0601 mov AL,byte ptr ES:[SI+0x20]
        AL = UInt8[ES, (ushort)(SI + (sbyte)32)];
        // 5BAE:0605 mov word ptr DS:[DI+0x00B4],AX
        UInt16[DS, (ushort)(DI + (short)180)] = AX;
        // 5BAE:0609 mov AL,byte ptr ES:[SI+0x1B]
        AL = UInt8[ES, (ushort)(SI + (sbyte)27)];
        // 5BAE:060D mov word ptr DS:[DI+0x00D8],AX
        UInt16[DS, (ushort)(DI + (short)216)] = AX;
        // 5BAE:0611 mov AX,word ptr ES:[SI+0x23]
        AX = UInt16[ES, (ushort)(SI + (sbyte)35)];
        // 5BAE:0615 mov byte ptr DS:[DI+0x6D],AH
        UInt8[DS, (ushort)(DI + (sbyte)109)] = AH;
        // 5BAE:0618 mov AH,AL
        AH = AL;
        // 5BAE:061A xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5BAE:061C mov word ptr DS:[DI+0x5A],AX
        UInt16[DS, (ushort)(DI + (sbyte)90)] = AX;
        // 5BAE:061F push DS
        Stack.Push16(DS);
        // 5BAE:0620 mov AX,ES
        AX = ES;
        // 5BAE:0622 mov DS,AX
        DS = AX;
        // 5BAE:0624 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5BAE:0627 call near 0x09AB
        NearCall(cs4, 0x062A, unknown_5BAE_09AB_5C48B);
    label_5BAE_062A_5C10A_3975:
        CheckExternalEvents(cs4, 0x062A);
        // 5BAE:062A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:062B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_062C_5C10C(int loadOffset)
    {
    label_5BAE_062C_5C10C_3983:
        CheckExternalEvents(cs4, 0x062C);
        // 5BAE:062C lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:062E call near 0x08E1
        NearCall(cs4, 0x0631, unknown_5BAE_08E1_5C3C1);
    label_5BAE_0631_5C111_3986:
        CheckExternalEvents(cs4, 0x0631);
        // 5BAE:0631 push AX
        Stack.Push16(AX);
        // 5BAE:0632 call near 0x0740
        NearCall(cs4, 0x0635, unknown_5BAE_0740_5C220);
    label_5BAE_0635_5C115_4052:
        CheckExternalEvents(cs4, 0x0635);
        // 5BAE:0635 cmp byte ptr DS:[DI+0x37],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)55)], (byte)0x00);
        // 5BAE:0639 je short 0x0640
        if (ZeroFlag)
        {
            goto label_5BAE_0640_5C120_4055;
        }
    label_5BAE_063B_5C11B_4988:
        CheckExternalEvents(cs4, 0x063B);
        // 5BAE:063B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5BAE:063D call near 0x0A8F
        NearCall(cs4, 0x0640, unknown_5BAE_0A8F_5C56F);
    label_5BAE_0640_5C120_4055:
        CheckExternalEvents(cs4, 0x0640);
        // 5BAE:0640 pop AX
        AX = Stack.Pop16();
        // 5BAE:0641 mov AL,AH
        AL = AH;
        // 5BAE:0643 add AL,byte ptr DS:[DI+0x49]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)(DI + (sbyte)73)]);
        // 5BAE:0646 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5BAE:0648 mov byte ptr DS:[DI+0x37],AL
        UInt8[DS, (ushort)(DI + (sbyte)55)] = AL;
        // 5BAE:064B sub AX,0x0048
        AX = Alu16.Sub(AX, (ushort)0x0048);
        // 5BAE:064E mov CL,byte ptr DS:[DI+0x5B]
        CL = UInt8[DS, (ushort)(DI + (sbyte)91)];
        // 5BAE:0651 mov byte ptr DS:[DI+0x5A],CL
        UInt8[DS, (ushort)(DI + (sbyte)90)] = CL;
        // 5BAE:0654 mov byte ptr DS:[DI+0x6C],0x40
        UInt8[DS, (ushort)(DI + (sbyte)108)] = (byte)0x40;
        // 5BAE:0658 jmp near 0x0A58
    label_5BAE_0A58_5C538_4066:
        CheckExternalEvents(cs4, 0x0A58);
        // 5BAE:0A58 add AX,0x0030
        AX = Alu16.Add(AX, (ushort)0x0030);
        // 5BAE:0A5B cmp AX,0x0060
        Alu16.Sub(AX, (ushort)0x0060);
        // 5BAE:0A5E jb short 0x0A62
        if (CarryFlag)
        {
            goto label_5BAE_0A62_5C542_4072;
        }
    label_5BAE_0A60_5C540_4070:
        CheckExternalEvents(cs4, 0x0A60);
        // 5BAE:0A60 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_5BAE_0A62_5C542_4072:
        CheckExternalEvents(cs4, 0x0A62);
        // 5BAE:0A62 mov BL,0x0C
        BL = (byte)0x0C;
        // 5BAE:0A64 div BL
        byte divisor_5BAE_0A64_5C544 = BL;
        ushort dividend_5BAE_0A64_5C544 = AX;
        byte quotient_5BAE_0A64_5C544 = Alu8.Div(unchecked((ushort)dividend_5BAE_0A64_5C544), unchecked((byte)divisor_5BAE_0A64_5C544));
        AL = unchecked((byte)quotient_5BAE_0A64_5C544);
        AH = unchecked((byte)(dividend_5BAE_0A64_5C544 % unchecked((ushort)divisor_5BAE_0A64_5C544)));
        // 5BAE:0A66 mov CL,AL
        CL = AL;
        // 5BAE:0A68 xchg AH,AL
        byte temp_5BAE_0A68_5C548 = AH;
        AH = AL;
        AL = unchecked((byte)temp_5BAE_0A68_5C548);
        // 5BAE:0A6A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5BAE:0A6C add AX,AX
        AX = Alu16.Add(AX, AX);
        // 5BAE:0A6E mov SI,AX
        SI = AX;
        // 5BAE:0A70 mov AX,word ptr DS:[SI+0x0147]
        AX = UInt16[DS, (ushort)(SI + (short)327)];
        // 5BAE:0A74 shl CL,1
        CL = Alu8.Shl(CL, 1);
        // 5BAE:0A76 shl CL,1
        CL = Alu8.Shl(CL, 1);
        // 5BAE:0A78 or AH,CL
        AH = Alu8.Or(AH, CL);
        // 5BAE:0A7A mov SI,DX
        SI = DX;
        // 5BAE:0A7C add SI,SI
        SI = Alu16.Add(SI, SI);
        // 5BAE:0A7E mov word ptr DS:[SI+0x015F],AX
        UInt16[DS, (ushort)(SI + (short)351)] = AX;
        // 5BAE:0A82 or AH,0x20
        AH = Alu8.Or(AH, (byte)0x20);
        // 5BAE:0A85 jmp short 0x0A8F
        return unknown_5BAE_0A8F_5C56F(0x0000);
    }

    public virtual Action unknown_5BAE_065B_5C13B(int loadOffset)
    {
    label_5BAE_065B_5C13B_4944:
        CheckExternalEvents(cs4, 0x065B);
        // 5BAE:065B inc SI
        SI = Alu16.Inc(SI);
        // 5BAE:065C call near 0x08E1
        NearCall(cs4, 0x065F, unknown_5BAE_08E1_5C3C1);
    label_5BAE_065F_5C13F_4947:
        CheckExternalEvents(cs4, 0x065F);
        // 5BAE:065F add AH,byte ptr DS:[DI+0x49]
        AH = Alu8.Add(AH, UInt8[DS, (ushort)(DI + (sbyte)73)]);
        // 5BAE:0662 cmp byte ptr DS:[DI+0x37],AH
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)55)], AH);
        // 5BAE:0665 jne short 0x066E
        if (!ZeroFlag)
        {
            goto label_5BAE_066E_5C14E_5953;
        }
    label_5BAE_0667_5C147_4951:
        CheckExternalEvents(cs4, 0x0667);
        // 5BAE:0667 mov byte ptr DS:[DI+0x37],0
        UInt8[DS, (ushort)(DI + (sbyte)55)] = (byte)0x00;
        // 5BAE:066B jmp near 0x0A87
        return unknown_5BAE_0A87_5C567(0x0000);
    label_5BAE_066E_5C14E_5953:
        CheckExternalEvents(cs4, 0x066E);
        // 5BAE:066E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_066F_5C14F(int loadOffset)
    {
    label_5BAE_066F_5C14F_5260:
        CheckExternalEvents(cs4, 0x066F);
        // 5BAE:066F mov word ptr DS:[DI],0xFFFF
        UInt16[DS, DI] = (ushort)0xFFFF;
        // 5BAE:0673 sub byte ptr DS:[DI+0x12],2
        UInt8[DS, (ushort)(DI + (sbyte)18)] = Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)18)], (byte)0x02);
        // 5BAE:0677 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 5BAE:0679 jne short 0x0696
        if (!ZeroFlag)
        {
            goto label_5BAE_0696_5C176_5265;
        }
    label_5BAE_067B_5C15B_5746:
        CheckExternalEvents(cs4, 0x067B);
        // 5BAE:067B dec byte ptr DS:[0x019B]
        UInt8[DS, (ushort)0x019B] = Alu8.Dec(UInt8[DS, (ushort)0x019B]);
        // 5BAE:067F je short 0x0697
        if (ZeroFlag)
        {
            goto label_5BAE_0697_5C177_5749;
        }
    label_5BAE_0681_5C161_22521:
        CheckExternalEvents(cs4, 0x0681);
        // 5BAE:0681 jns short 0x0687
        if (!SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5BAE:0681");
        }
    label_5BAE_0683_5C163_22523:
        CheckExternalEvents(cs4, 0x0683);
        // 5BAE:0683 inc byte ptr DS:[0x019B]
        UInt8[DS, (ushort)0x019B] = Alu8.Inc(UInt8[DS, (ushort)0x019B]);
        // 5BAE:0687 call near 0x0444
        NearCall(cs4, 0x068A, unknown_5BAE_0444_5BF24);
    label_5BAE_068A_5C16A_22527:
        CheckExternalEvents(cs4, 0x068A);
        // 5BAE:068A les BX,word ptr DS:[0x0115]
        ushort lxsOffset_5BAE_068A_5C16A = (ushort)0x0115;
        ushort lxsValue_5BAE_068A_5C16A = UInt16[DS, lxsOffset_5BAE_068A_5C16A];
        ushort lxsSegment_5BAE_068A_5C16A = UInt16[DS, (ushort)(lxsOffset_5BAE_068A_5C16A + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_5BAE_068A_5C16A);
        ES = unchecked((ushort)lxsSegment_5BAE_068A_5C16A);
        // 5BAE:068E mov DI,0x01A2
        DI = (ushort)0x01A2;
        // 5BAE:0691 call near 0x0553
        NearCall(cs4, 0x0694, unknown_5BAE_0553_5C033);
    label_5BAE_0694_5C174_22531:
        CheckExternalEvents(cs4, 0x0694);
        // 5BAE:0694 dec word ptr DS:[DI]
        UInt16[DS, DI] = Alu16.Dec(UInt16[DS, DI]);
    label_5BAE_0696_5C176_5265:
        CheckExternalEvents(cs4, 0x0696);
        // 5BAE:0696 ret near
        return NearRet((ushort)0x0000);
    label_5BAE_0697_5C177_5749:
        CheckExternalEvents(cs4, 0x0697);
        // 5BAE:0697 mov AX,0xFFFF
        AX = (ushort)0xFFFF;
        // 5BAE:069A push ES
        Stack.Push16(ES);
        // 5BAE:069B push DS
        Stack.Push16(DS);
        // 5BAE:069C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:069D mov CX,9
        CX = (ushort)0x0009;
        // 5BAE:06A0 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 5BAE:06A2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:06A3 push CS
        Stack.Push16(CS);
        // 5BAE:06A4 call near 0x02FE
        NearCall(cs4, 0x06A7, unknown_5BAE_02FE_5BDDE);
    label_5BAE_06A7_5C187_5759:
        CheckExternalEvents(cs4, 0x06A7);
        // 5BAE:06A7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_06A8_5C188(int loadOffset)
    {
    label_5BAE_06A8_5C188_4954:
        CheckExternalEvents(cs4, 0x06A8);
        // 5BAE:06A8 call near 0x08E1
        NearCall(cs4, 0x06AB, unknown_5BAE_08E1_5C3C1);
    label_5BAE_06AB_5C18B_4956:
        CheckExternalEvents(cs4, 0x06AB);
        // 5BAE:06AB mov AL,0x80
        AL = (byte)0x80;
        // 5BAE:06AD sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 5BAE:06AF xchg AL,AH
        byte temp_5BAE_06AF_5C18F = AL;
        AL = AH;
        AH = unchecked((byte)temp_5BAE_06AF_5C18F);
        // 5BAE:06B1 mov BX,word ptr DS:[DI+0x00A2]
        BX = UInt16[DS, (ushort)(DI + (short)162)];
        // 5BAE:06B5 mov CX,word ptr DS:[DI+0x00C6]
        CX = UInt16[DS, (ushort)(DI + (short)198)];
        // 5BAE:06B9 or CL,CL
        CL = Alu8.Or(CL, CL);
        // 5BAE:06BB je short 0x06E7
        if (ZeroFlag)
        {
            goto label_5BAE_06E7_5C1C7_4964;
        }
    label_5BAE_06BD_5C19D_5220:
        CheckExternalEvents(cs4, 0x06BD);
        // 5BAE:06BD push AX
        Stack.Push16(AX);
        // 5BAE:06BE jns short 0x06C4
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:06BE");
        }
    label_5BAE_06C4_5C1A4_5223:
        CheckExternalEvents(cs4, 0x06C4);
        // 5BAE:06C4 sub CL,4
        CL = Alu8.Sub(CL, (byte)0x04);
        // 5BAE:06C7 neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
        // 5BAE:06C9 shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:06CB mov AH,BL
        AH = BL;
        // 5BAE:06CD and AH,0x3F
        AH = Alu8.And(AH, (byte)0x3F);
        // 5BAE:06D0 sub AH,AL
        AH = Alu8.Sub(AH, AL);
        // 5BAE:06D2 jae short 0x06D6
        if (!CarryFlag)
        {
            goto label_5BAE_06D6_5C1B6_5231;
        }
    label_5BAE_06D4_5C1B4_5241:
        CheckExternalEvents(cs4, 0x06D4);
        // 5BAE:06D4 xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_5BAE_06D6_5C1B6_5231:
        CheckExternalEvents(cs4, 0x06D6);
        // 5BAE:06D6 and BL,0xC0
        BL = Alu8.And(BL, (byte)0xC0);
        // 5BAE:06D9 or AH,BL
        AH = Alu8.Or(AH, BL);
        // 5BAE:06DB mov SI,0x0171
        SI = (ushort)0x0171;
        // 5BAE:06DE add SI,DX
        SI = Alu16.Add(SI, DX);
        // 5BAE:06E0 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:06E1 add AL,0x40
        AL = Alu8.Add(AL, (byte)0x40);
        // 5BAE:06E3 call near 0x0AA2
        NearCall(cs4, 0x06E6, unknown_5BAE_0AA2_5C582);
    label_5BAE_06E6_5C1C6_5239:
        CheckExternalEvents(cs4, 0x06E6);
        // 5BAE:06E6 pop AX
        AX = Stack.Pop16();
    label_5BAE_06E7_5C1C7_4964:
        CheckExternalEvents(cs4, 0x06E7);
        // 5BAE:06E7 or CH,CH
        CH = Alu8.Or(CH, CH);
        // 5BAE:06E9 je short 0x0714
        if (ZeroFlag)
        {
            goto label_5BAE_0714_5C1F4_4967;
        }
    label_5BAE_06EB_5C1CB_6988:
        CheckExternalEvents(cs4, 0x06EB);
        // 5BAE:06EB push AX
        Stack.Push16(AX);
        // 5BAE:06EC jns short 0x06F2
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:06EC");
        }
    label_5BAE_06F2_5C1D2_6991:
        CheckExternalEvents(cs4, 0x06F2);
        // 5BAE:06F2 mov CL,4
        CL = (byte)0x04;
        // 5BAE:06F4 sub CL,CH
        CL = Alu8.Sub(CL, CH);
        // 5BAE:06F6 shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:06F8 mov AH,BH
        AH = BH;
        // 5BAE:06FA and AH,0x3F
        AH = Alu8.And(AH, (byte)0x3F);
        // 5BAE:06FD sub AH,AL
        AH = Alu8.Sub(AH, AL);
        // 5BAE:06FF jae short 0x0703
        if (!CarryFlag)
        {
            goto label_5BAE_0703_5C1E3_6999;
        }
    label_5BAE_0701_5C1E1_9272:
        CheckExternalEvents(cs4, 0x0701);
        // 5BAE:0701 xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_5BAE_0703_5C1E3_6999:
        CheckExternalEvents(cs4, 0x0703);
        // 5BAE:0703 and BH,0xC0
        BH = Alu8.And(BH, (byte)0xC0);
        // 5BAE:0706 or AH,BH
        AH = Alu8.Or(AH, BH);
        // 5BAE:0708 mov SI,0x017A
        SI = (ushort)0x017A;
        // 5BAE:070B add SI,DX
        SI = Alu16.Add(SI, DX);
        // 5BAE:070D lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:070E add AL,0x40
        AL = Alu8.Add(AL, (byte)0x40);
        // 5BAE:0710 call near 0x0AA2
        NearCall(cs4, 0x0713, unknown_5BAE_0AA2_5C582);
    label_5BAE_0713_5C1F3_7007:
        CheckExternalEvents(cs4, 0x0713);
        // 5BAE:0713 pop AX
        AX = Stack.Pop16();
    label_5BAE_0714_5C1F4_4967:
        CheckExternalEvents(cs4, 0x0714);
        // 5BAE:0714 mov CX,word ptr DS:[DI+0x00D8]
        CX = UInt16[DS, (ushort)(DI + (short)216)];
        // 5BAE:0718 or CL,CL
        CL = Alu8.Or(CL, CL);
        // 5BAE:071A jne short 0x071D
        if (!ZeroFlag)
        {
            goto label_5BAE_071D_5C1FD_4971;
        }
    label_5BAE_071C_5C1FC_4991:
        CheckExternalEvents(cs4, 0x071C);
        // 5BAE:071C ret near
        return NearRet((ushort)0x0000);
    label_5BAE_071D_5C1FD_4971:
        CheckExternalEvents(cs4, 0x071D);
        // 5BAE:071D jns short 0x0723
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:071D");
        }
    label_5BAE_0723_5C203_4973:
        CheckExternalEvents(cs4, 0x0723);
        // 5BAE:0723 sub CL,6
        CL = Alu8.Sub(CL, (byte)0x06);
        // 5BAE:0726 neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
        // 5BAE:0728 shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:072A and AL,0xFE
        AL = Alu8.And(AL, (byte)0xFE);
        // 5BAE:072C add AL,CH
        AL = Alu8.Add(AL, CH);
        // 5BAE:072E cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 5BAE:0730 jbe short 0x0736
        if (CarryFlag || ZeroFlag)
        {
            goto label_5BAE_0736_5C216_4981;
        }
    label_5BAE_0732_5C212_16163:
        CheckExternalEvents(cs4, 0x0732);
        // 5BAE:0732 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 5BAE:0734 or AL,0x0E
        AL = Alu8.Or(AL, (byte)0x0E);
    label_5BAE_0736_5C216_4981:
        CheckExternalEvents(cs4, 0x0736);
        // 5BAE:0736 mov AH,AL
        AH = AL;
        // 5BAE:0738 mov AL,DL
        AL = DL;
        // 5BAE:073A add AL,0xC0
        AL = Alu8.Add(AL, (byte)0xC0);
        // 5BAE:073C call near 0x0AA2
        NearCall(cs4, 0x073F, unknown_5BAE_0AA2_5C582);
    label_5BAE_073F_5C21F_4986:
        CheckExternalEvents(cs4, 0x073F);
        // 5BAE:073F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_0740_5C220(int loadOffset)
    {
    label_5BAE_0740_5C220_3989:
        CheckExternalEvents(cs4, 0x0740);
        // 5BAE:0740 mov AH,AL
        AH = AL;
        // 5BAE:0742 mov AL,0x80
        AL = (byte)0x80;
        // 5BAE:0744 sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 5BAE:0746 mov BX,word ptr DS:[DI+0x0090]
        BX = UInt16[DS, (ushort)(DI + (short)144)];
        // 5BAE:074A mov CX,word ptr DS:[DI+0x7E]
        CX = UInt16[DS, (ushort)(DI + (sbyte)126)];
        // 5BAE:074D or CL,CL
        CL = Alu8.Or(CL, CL);
        // 5BAE:074F je short 0x0780
        if (ZeroFlag)
        {
            goto label_5BAE_0780_5C260_4020;
        }
    label_5BAE_0751_5C231_3997:
        CheckExternalEvents(cs4, 0x0751);
        // 5BAE:0751 push AX
        Stack.Push16(AX);
        // 5BAE:0752 jns short 0x0758
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:0752");
        }
    label_5BAE_0758_5C238_4000:
        CheckExternalEvents(cs4, 0x0758);
        // 5BAE:0758 sub CL,4
        CL = Alu8.Sub(CL, (byte)0x04);
        // 5BAE:075B neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
        // 5BAE:075D shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:075F mov AH,BL
        AH = BL;
        // 5BAE:0761 and AH,0x3F
        AH = Alu8.And(AH, (byte)0x3F);
        // 5BAE:0764 add AH,AL
        AH = Alu8.Add(AH, AL);
        // 5BAE:0766 cmp AH,0x3F
        Alu8.Sub(AH, (byte)0x3F);
        // 5BAE:0769 jbe short 0x076D
        if (CarryFlag || ZeroFlag)
        {
            goto label_5BAE_076D_5C24D_4009;
        }
    label_5BAE_076B_5C24B_28185:
        CheckExternalEvents(cs4, 0x076B);
        // 5BAE:076B mov AH,0x3F
        AH = (byte)0x3F;
    label_5BAE_076D_5C24D_4009:
        CheckExternalEvents(cs4, 0x076D);
        // 5BAE:076D and BL,0xC0
        BL = Alu8.And(BL, (byte)0xC0);
        // 5BAE:0770 or BL,AH
        BL = Alu8.Or(BL, AH);
        // 5BAE:0772 mov AH,BL
        AH = BL;
        // 5BAE:0774 mov SI,0x0171
        SI = (ushort)0x0171;
        // 5BAE:0777 add SI,DX
        SI = Alu16.Add(SI, DX);
        // 5BAE:0779 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:077A add AL,0x40
        AL = Alu8.Add(AL, (byte)0x40);
        // 5BAE:077C call near 0x0AA2
        NearCall(cs4, 0x077F, unknown_5BAE_0AA2_5C582);
    label_5BAE_077F_5C25F_4018:
        CheckExternalEvents(cs4, 0x077F);
        // 5BAE:077F pop AX
        AX = Stack.Pop16();
    label_5BAE_0780_5C260_4020:
        CheckExternalEvents(cs4, 0x0780);
        // 5BAE:0780 or CH,CH
        CH = Alu8.Or(CH, CH);
        // 5BAE:0782 je short 0x07B2
        if (ZeroFlag)
        {
            goto label_5BAE_07B2_5C292_4045;
        }
    label_5BAE_0784_5C264_4022:
        CheckExternalEvents(cs4, 0x0784);
        // 5BAE:0784 push AX
        Stack.Push16(AX);
        // 5BAE:0785 jns short 0x078B
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:0785");
        }
    label_5BAE_078B_5C26B_4025:
        CheckExternalEvents(cs4, 0x078B);
        // 5BAE:078B mov CL,4
        CL = (byte)0x04;
        // 5BAE:078D sub CL,CH
        CL = Alu8.Sub(CL, CH);
        // 5BAE:078F shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:0791 mov AH,BH
        AH = BH;
        // 5BAE:0793 and AH,0x3F
        AH = Alu8.And(AH, (byte)0x3F);
        // 5BAE:0796 add AH,AL
        AH = Alu8.Add(AH, AL);
        // 5BAE:0798 cmp AH,0x3F
        Alu8.Sub(AH, (byte)0x3F);
        // 5BAE:079B jbe short 0x079F
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:079B");
        }
    label_5BAE_079F_5C27F_4034:
        CheckExternalEvents(cs4, 0x079F);
        // 5BAE:079F and BH,0xC0
        BH = Alu8.And(BH, (byte)0xC0);
        // 5BAE:07A2 or BH,AH
        BH = Alu8.Or(BH, AH);
        // 5BAE:07A4 mov AH,BH
        AH = BH;
        // 5BAE:07A6 mov SI,0x017A
        SI = (ushort)0x017A;
        // 5BAE:07A9 add SI,DX
        SI = Alu16.Add(SI, DX);
        // 5BAE:07AB lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:07AC add AL,0x40
        AL = Alu8.Add(AL, (byte)0x40);
        // 5BAE:07AE call near 0x0AA2
        NearCall(cs4, 0x07B1, unknown_5BAE_0AA2_5C582);
    label_5BAE_07B1_5C291_4043:
        CheckExternalEvents(cs4, 0x07B1);
        // 5BAE:07B1 pop AX
        AX = Stack.Pop16();
    label_5BAE_07B2_5C292_4045:
        CheckExternalEvents(cs4, 0x07B2);
        // 5BAE:07B2 mov word ptr DS:[DI+0x00A2],BX
        UInt16[DS, (ushort)(DI + (short)162)] = BX;
        // 5BAE:07B6 mov CX,word ptr DS:[DI+0x00B4]
        CX = UInt16[DS, (ushort)(DI + (short)180)];
        // 5BAE:07BA or CL,CL
        CL = Alu8.Or(CL, CL);
        // 5BAE:07BC jne short 0x07C3
        if (!ZeroFlag)
        {
            goto label_5BAE_07C3_5C2A3_5009;
        }
    label_5BAE_07BE_5C29E_4049:
        CheckExternalEvents(cs4, 0x07BE);
        // 5BAE:07BE mov byte ptr DS:[DI+0x00D9],CH
        UInt8[DS, (ushort)(DI + (short)217)] = CH;
        // 5BAE:07C2 ret near
        return NearRet((ushort)0x0000);
    label_5BAE_07C3_5C2A3_5009:
        CheckExternalEvents(cs4, 0x07C3);
        // 5BAE:07C3 jns short 0x07C9
        if (!SignFlag)
        {
            goto label_5BAE_07C9_5C2A9_5014;
        }
    label_5BAE_07C5_5C2A5_5011:
        CheckExternalEvents(cs4, 0x07C5);
        // 5BAE:07C5 neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
        // 5BAE:07C7 mov AL,AH
        AL = AH;
    label_5BAE_07C9_5C2A9_5014:
        CheckExternalEvents(cs4, 0x07C9);
        // 5BAE:07C9 sub CL,6
        CL = Alu8.Sub(CL, (byte)0x06);
        // 5BAE:07CC neg CL
        CL = Alu8.Sub((byte)0x00, CL);
        CarryFlag = CL != (byte)0x00;
        // 5BAE:07CE shr AL,CL
        AL = Alu8.Shr(AL, unchecked((int)CL));
        // 5BAE:07D0 and AL,0xFE
        AL = Alu8.And(AL, (byte)0xFE);
        // 5BAE:07D2 add AL,CH
        AL = Alu8.Add(AL, CH);
        // 5BAE:07D4 cmp AL,0x0F
        Alu8.Sub(AL, (byte)0x0F);
        // 5BAE:07D6 jbe short 0x07DC
        if (!(CarryFlag || ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:07D6");
        }
    label_5BAE_07DC_5C2BC_5021:
        CheckExternalEvents(cs4, 0x07DC);
        // 5BAE:07DC mov AH,AL
        AH = AL;
        // 5BAE:07DE mov byte ptr DS:[DI+0x00D9],AL
        UInt8[DS, (ushort)(DI + (short)217)] = AL;
        // 5BAE:07E2 mov AL,DL
        AL = DL;
        // 5BAE:07E4 add AL,0xC0
        AL = Alu8.Add(AL, (byte)0xC0);
        // 5BAE:07E6 call near 0x0AA2
        NearCall(cs4, 0x07E9, unknown_5BAE_0AA2_5C582);
        return unknown_5BAE_07E9_5C2C9(0x0000);
    }

    public virtual Action unknown_5BAE_07EA_5C2CA(int loadOffset)
    {
    label_5BAE_07EA_5C2CA_11461:
        CheckExternalEvents(cs4, 0x07EA);
        // 5BAE:07EA mov AL,AH
        AL = AH;
        // 5BAE:07EC call near 0x08E1
        NearCall(cs4, 0x07EF, unknown_5BAE_08E1_5C3C1);
        return unknown_5BAE_07EF_5C2CF(0x0000);
    }

    public virtual Action unknown_5BAE_07EF_5C2CF(int loadOffset)
    {
    label_5BAE_07EF_5C2CF_5044:
        CheckExternalEvents(cs4, 0x07EF);
        // 5BAE:07EF mov CL,byte ptr DS:[DI+0x37]
        CL = UInt8[DS, (ushort)(DI + (sbyte)55)];
        // 5BAE:07F2 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 5BAE:07F4 jcxz short 0x07E9
        if (CX == (ushort)0x0000)
        {
            return unknown_5BAE_07E9_5C2C9(0x0000);
        }
    label_5BAE_07F6_5C2D6_5048:
        CheckExternalEvents(cs4, 0x07F6);
        // 5BAE:07F6 mov AH,CH
        AH = CH;
        // 5BAE:07F8 xchg CX,AX
        ushort temp_5BAE_07F8_5C2D8 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_5BAE_07F8_5C2D8);
        // 5BAE:07F9 sub AL,0x18
        AL = Alu8.Sub(AL, (byte)0x18);
        // 5BAE:07FB mov BH,0x0C
        BH = (byte)0x0C;
        // 5BAE:07FD div BH
        byte divisor_5BAE_07FD_5C2DD = BH;
        ushort dividend_5BAE_07FD_5C2DD = AX;
        byte quotient_5BAE_07FD_5C2DD = Alu8.Div(unchecked((ushort)dividend_5BAE_07FD_5C2DD), unchecked((byte)divisor_5BAE_07FD_5C2DD));
        AL = unchecked((byte)quotient_5BAE_07FD_5C2DD);
        AH = unchecked((byte)(dividend_5BAE_07FD_5C2DD % unchecked((ushort)divisor_5BAE_07FD_5C2DD)));
        // 5BAE:07FF xchg CX,AX
        ushort temp_5BAE_07FF_5C2DF = CX;
        CX = AX;
        AX = unchecked((ushort)temp_5BAE_07FF_5C2DF);
        // 5BAE:0800 cmp byte ptr DS:[DI+0x48],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)72)], (byte)0x00);
        // 5BAE:0804 jne short 0x0865
        if (!ZeroFlag)
        {
            goto label_5BAE_0865_5C345_12878;
        }
    label_5BAE_0806_5C2E6_5057:
        CheckExternalEvents(cs4, 0x0806);
        // 5BAE:0806 sub AX,0x0040
        AX = Alu16.Sub(AX, (ushort)0x0040);
        // 5BAE:0809 jae short 0x0842
        if (!CarryFlag)
        {
            goto label_5BAE_0842_5C322_5925;
        }
    label_5BAE_080B_5C2EB_5060:
        CheckExternalEvents(cs4, 0x080B);
        // 5BAE:080B neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 5BAE:080D ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:080F ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0811 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0813 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0815 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0817 sub CH,AL
        CH = Alu8.Sub(CH, AL);
        // 5BAE:0819 jae short 0x0824
        if (!CarryFlag)
        {
            goto label_5BAE_0824_5C304_5069;
        }
    label_5BAE_081B_5C2FB_9346:
        CheckExternalEvents(cs4, 0x081B);
        // 5BAE:081B add CH,0x0C
        CH = Alu8.Add(CH, (byte)0x0C);
        // 5BAE:081E dec CL
        CL = Alu8.Dec(CL);
        // 5BAE:0820 jns short 0x0824
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:0820");
        }
    label_5BAE_0824_5C304_5069:
        CheckExternalEvents(cs4, 0x0824);
        // 5BAE:0824 mov AL,CH
        AL = CH;
        // 5BAE:0826 mov BX,0x0183
        BX = (ushort)0x0183;
        // 5BAE:0829 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 5BAE:082A mul AH
        ushort result_5BAE_082A_5C30A = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_5BAE_082A_5C30A >> 8));
        AL = unchecked((byte)result_5BAE_082A_5C30A);
        // 5BAE:082C mov AL,AH
        AL = AH;
        // 5BAE:082E xchg AL,CH
        byte temp_5BAE_082E_5C30E = AL;
        AL = CH;
        CH = unchecked((byte)temp_5BAE_082E_5C30E);
        // 5BAE:0830 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5BAE:0832 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 5BAE:0834 mov SI,AX
        SI = AX;
        // 5BAE:0836 mov AX,word ptr DS:[SI+0x0147]
        AX = UInt16[DS, (ushort)(SI + (short)327)];
        // 5BAE:083A sub AL,CH
        AL = Alu8.Sub(AL, CH);
        // 5BAE:083C sbb AH,0
        AH = Alu8.Sbb(AH, (byte)0x00);
        // 5BAE:083F jmp near 0x08CD
        goto label_5BAE_08CD_5C3AD_5083;
    label_5BAE_0842_5C322_5925:
        CheckExternalEvents(cs4, 0x0842);
        // 5BAE:0842 inc AX
        AX = Alu16.Inc(AX);
        // 5BAE:0843 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0845 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0847 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:0849 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:084B ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 5BAE:084D add CH,AL
        CH = Alu8.Add(CH, AL);
        // 5BAE:084F cmp CH,0x0C
        Alu8.Sub(CH, (byte)0x0C);
        // 5BAE:0852 jb short 0x0859
        if (CarryFlag)
        {
            goto label_5BAE_0859_5C339_5935;
        }
    label_5BAE_0854_5C334_28173:
        CheckExternalEvents(cs4, 0x0854);
        // 5BAE:0854 sub CH,0x0C
        CH = Alu8.Sub(CH, (byte)0x0C);
        // 5BAE:0857 inc CL
        CL = Alu8.Inc(CL);
    label_5BAE_0859_5C339_5935:
        CheckExternalEvents(cs4, 0x0859);
        // 5BAE:0859 mov AL,CH
        AL = CH;
        // 5BAE:085B mov BX,0x0184
        BX = (ushort)0x0184;
        // 5BAE:085E xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 5BAE:085F mul AH
        ushort result_5BAE_085F_5C33F = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_5BAE_085F_5C33F >> 8));
        AL = unchecked((byte)result_5BAE_085F_5C33F);
        // 5BAE:0861 mov AL,AH
        AL = AH;
        // 5BAE:0863 jmp short 0x08BC
        goto label_5BAE_08BC_5C39C_5942;
    label_5BAE_0865_5C345_12878:
        CheckExternalEvents(cs4, 0x0865);
        // 5BAE:0865 sub AX,0x0040
        AX = Alu16.Sub(AX, (ushort)0x0040);
        // 5BAE:0868 jae short 0x089E
        if (!CarryFlag)
        {
            goto label_5BAE_089E_5C37E_17081;
        }
    label_5BAE_086A_5C34A_12881:
        CheckExternalEvents(cs4, 0x086A);
        // 5BAE:086A neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 5BAE:086C mov BH,5
        BH = (byte)0x05;
        // 5BAE:086E div BH
        byte divisor_5BAE_086E_5C34E = BH;
        ushort dividend_5BAE_086E_5C34E = AX;
        byte quotient_5BAE_086E_5C34E = Alu8.Div(unchecked((ushort)dividend_5BAE_086E_5C34E), unchecked((byte)divisor_5BAE_086E_5C34E));
        AL = unchecked((byte)quotient_5BAE_086E_5C34E);
        AH = unchecked((byte)(dividend_5BAE_086E_5C34E % unchecked((ushort)divisor_5BAE_086E_5C34E)));
        // 5BAE:0870 sub CH,AL
        CH = Alu8.Sub(CH, AL);
        // 5BAE:0872 jae short 0x087D
        if (!CarryFlag)
        {
            goto label_5BAE_087D_5C35D_12891;
        }
    label_5BAE_0874_5C354_12887:
        CheckExternalEvents(cs4, 0x0874);
        // 5BAE:0874 add CH,0x0C
        CH = Alu8.Add(CH, (byte)0x0C);
        // 5BAE:0877 dec CL
        CL = Alu8.Dec(CL);
        // 5BAE:0879 jns short 0x087D
        if (!SignFlag)
        {
            goto label_5BAE_087D_5C35D_12891;
        }
    label_5BAE_087B_5C35B_28179:
        CheckExternalEvents(cs4, 0x087B);
        // 5BAE:087B xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_5BAE_087D_5C35D_12891:
        CheckExternalEvents(cs4, 0x087D);
        // 5BAE:087D mov AL,AH
        AL = AH;
        // 5BAE:087F mov BX,0x0190
        BX = (ushort)0x0190;
        // 5BAE:0882 cmp CH,6
        Alu8.Sub(CH, (byte)0x06);
        // 5BAE:0885 jb short 0x088A
        if (CarryFlag)
        {
            goto label_5BAE_088A_5C36A_12898;
        }
    label_5BAE_0887_5C367_12896:
        CheckExternalEvents(cs4, 0x0887);
        // 5BAE:0887 add BX,5
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)5)));
    label_5BAE_088A_5C36A_12898:
        CheckExternalEvents(cs4, 0x088A);
        // 5BAE:088A xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 5BAE:088B xchg AL,CH
        byte temp_5BAE_088B_5C36B = AL;
        AL = CH;
        CH = unchecked((byte)temp_5BAE_088B_5C36B);
        // 5BAE:088D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5BAE:088F add AX,AX
        AX = Alu16.Add(AX, AX);
        // 5BAE:0891 mov SI,AX
        SI = AX;
        // 5BAE:0893 mov AX,word ptr DS:[SI+0x0147]
        AX = UInt16[DS, (ushort)(SI + (short)327)];
        // 5BAE:0897 sub AL,CH
        AL = Alu8.Sub(AL, CH);
        // 5BAE:0899 sbb AH,0
        AH = Alu8.Sbb(AH, (byte)0x00);
        // 5BAE:089C jmp short 0x08CD
        goto label_5BAE_08CD_5C3AD_5083;
    label_5BAE_089E_5C37E_17081:
        CheckExternalEvents(cs4, 0x089E);
        // 5BAE:089E mov BH,5
        BH = (byte)0x05;
        // 5BAE:08A0 div BH
        byte divisor_5BAE_08A0_5C380 = BH;
        ushort dividend_5BAE_08A0_5C380 = AX;
        byte quotient_5BAE_08A0_5C380 = Alu8.Div(unchecked((ushort)dividend_5BAE_08A0_5C380), unchecked((byte)divisor_5BAE_08A0_5C380));
        AL = unchecked((byte)quotient_5BAE_08A0_5C380);
        AH = unchecked((byte)(dividend_5BAE_08A0_5C380 % unchecked((ushort)divisor_5BAE_08A0_5C380)));
        // 5BAE:08A2 add CH,AL
        CH = Alu8.Add(CH, AL);
        // 5BAE:08A4 cmp CH,0x0C
        Alu8.Sub(CH, (byte)0x0C);
        // 5BAE:08A7 jb short 0x08AE
        if (CarryFlag)
        {
            goto label_5BAE_08AE_5C38E_17087;
        }
    label_5BAE_08A9_5C389_17096:
        CheckExternalEvents(cs4, 0x08A9);
        // 5BAE:08A9 sub CH,0x0C
        CH = Alu8.Sub(CH, (byte)0x0C);
        // 5BAE:08AC inc CL
        CL = Alu8.Inc(CL);
    label_5BAE_08AE_5C38E_17087:
        CheckExternalEvents(cs4, 0x08AE);
        // 5BAE:08AE mov AL,AH
        AL = AH;
        // 5BAE:08B0 mov BX,0x0190
        BX = (ushort)0x0190;
        // 5BAE:08B3 cmp CH,6
        Alu8.Sub(CH, (byte)0x06);
        // 5BAE:08B6 jb short 0x08BB
        if (CarryFlag)
        {
            goto label_5BAE_08BB_5C39B_17092;
        }
    label_5BAE_08B8_5C398_17094:
        CheckExternalEvents(cs4, 0x08B8);
        // 5BAE:08B8 add BX,5
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)5)));
    label_5BAE_08BB_5C39B_17092:
        CheckExternalEvents(cs4, 0x08BB);
        // 5BAE:08BB xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
    label_5BAE_08BC_5C39C_5942:
        CheckExternalEvents(cs4, 0x08BC);
        // 5BAE:08BC xchg AL,CH
        byte temp_5BAE_08BC_5C39C = AL;
        AL = CH;
        CH = unchecked((byte)temp_5BAE_08BC_5C39C);
        // 5BAE:08BE xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5BAE:08C0 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 5BAE:08C2 mov SI,AX
        SI = AX;
        // 5BAE:08C4 mov AX,word ptr DS:[SI+0x0147]
        AX = UInt16[DS, (ushort)(SI + (short)327)];
        // 5BAE:08C8 add AL,CH
        AL = Alu8.Add(AL, CH);
        // 5BAE:08CA adc AH,0
        AH = Alu8.Adc(AH, (byte)0x00);
    label_5BAE_08CD_5C3AD_5083:
        CheckExternalEvents(cs4, 0x08CD);
        // 5BAE:08CD shl CL,1
        CL = Alu8.Shl(CL, 1);
        // 5BAE:08CF shl CL,1
        CL = Alu8.Shl(CL, 1);
        // 5BAE:08D1 or AH,CL
        AH = Alu8.Or(AH, CL);
        // 5BAE:08D3 mov SI,DX
        SI = DX;
        // 5BAE:08D5 add SI,SI
        SI = Alu16.Add(SI, SI);
        // 5BAE:08D7 mov word ptr DS:[SI+0x015F],AX
        UInt16[DS, (ushort)(SI + (short)351)] = AX;
        // 5BAE:08DB or AH,0x20
        AH = Alu8.Or(AH, (byte)0x20);
        // 5BAE:08DE jmp near 0x0A8F
        return unknown_5BAE_0A8F_5C56F(0x0000);
    }

    public virtual Action unknown_5BAE_08E1_5C3C1(int loadOffset)
    {
    label_5BAE_08E1_5C3C1_3749:
        CheckExternalEvents(cs4, 0x08E1);
        // 5BAE:08E1 push AX
        Stack.Push16(AX);
        // 5BAE:08E2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5BAE:08E4 lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:08E6 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5BAE:08E8 jns short 0x0914
        if (!SignFlag)
        {
            goto label_5BAE_0914_5C3F4_3755;
        }
    label_5BAE_08EA_5C3CA_3766:
        CheckExternalEvents(cs4, 0x08EA);
        // 5BAE:08EA xor CX,CX
        CX = Alu16.Xor(CX, CX);
    label_5BAE_08EC_5C3CC_3768:
        CheckExternalEvents(cs4, 0x08EC);
        // 5BAE:08EC mov CH,CL
        CH = CL;
        // 5BAE:08EE mov CL,AH
        CL = AH;
        // 5BAE:08F0 mov AH,AL
        AH = AL;
        // 5BAE:08F2 lods AL,byte ptr ES:[SI]
        AL = UInt8[ES, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:08F4 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5BAE:08F6 js short 0x08EC
        if (SignFlag)
        {
            goto label_5BAE_08EC_5C3CC_3768;
        }
    label_5BAE_08F8_5C3D8_3774:
        CheckExternalEvents(cs4, 0x08F8);
        // 5BAE:08F8 and AX,0x7F7F
        AX = Alu16.And(AX, (ushort)0x7F7F);
        // 5BAE:08FB and CX,0x7F7F
        CX = Alu16.And(CX, (ushort)0x7F7F);
        // 5BAE:08FF shl CL,1
        CL = Alu8.Shl(CL, 1);
        // 5BAE:0901 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 5BAE:0903 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5BAE:0905 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:0907 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 5BAE:0909 rcr AX,1
        AX = Alu16.Rcr(AX, 1);
        // 5BAE:090B shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 5BAE:090D rcr AX,1
        AX = Alu16.Rcr(AX, 1);
        // 5BAE:090F jcxz short 0x0914
        if (!(CX == (ushort)0x0000))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5BAE:090F");
        }
    label_5BAE_0914_5C3F4_3755:
        CheckExternalEvents(cs4, 0x0914);
        // 5BAE:0914 mov word ptr DS:[DI],AX
        UInt16[DS, DI] = AX;
        // 5BAE:0916 mov word ptr DS:[DI+0x12],SI
        UInt16[DS, (ushort)(DI + (sbyte)18)] = SI;
        // 5BAE:0919 pop AX
        AX = Stack.Pop16();
        // 5BAE:091A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_091B_5C3FB(int loadOffset)
    {
    label_5BAE_091B_5C3FB_2314:
        CheckExternalEvents(cs4, 0x091B);
        // 5BAE:091B push DS
        Stack.Push16(DS);
        // 5BAE:091C push CS
        Stack.Push16(CS);
        // 5BAE:091D pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:091E mov CX,9
        CX = (ushort)0x0009;
    label_5BAE_0921_5C401_2319:
        CheckExternalEvents(cs4, 0x0921);
        // 5BAE:0921 push CX
        Stack.Push16(CX);
        // 5BAE:0922 mov DX,CX
        DX = CX;
        // 5BAE:0924 dec DX
        DX = Alu16.Dec(DX);
        // 5BAE:0925 call near 0x0A87
        NearCall(cs4, 0x0928, unknown_5BAE_0A87_5C567);
    label_5BAE_0928_5C408_2337:
        CheckExternalEvents(cs4, 0x0928);
        // 5BAE:0928 pop CX
        CX = Stack.Pop16();
        // 5BAE:0929 loop 0x0921
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_0921_5C401_2319;
        }
    label_5BAE_092B_5C40B_2341:
        CheckExternalEvents(cs4, 0x092B);
        // 5BAE:092B pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5BAE:092C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_092D_5C40D(int loadOffset)
    {
    label_5BAE_092D_5C40D_4171:
        CheckExternalEvents(cs4, 0x092D);
        // 5BAE:092D mov AL,byte ptr DS:[0x019C]
        AL = UInt8[DS, (ushort)0x019C];
        // 5BAE:0930 cmp AL,byte ptr DS:[0x019D]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x019D]);
        // 5BAE:0934 jne short 0x0942
        if (!ZeroFlag)
        {
            goto label_5BAE_0942_5C422_8757;
        }
    label_5BAE_0936_5C416_4175:
        CheckExternalEvents(cs4, 0x0936);
        // 5BAE:0936 mov word ptr DS:[0x019F],1
        UInt16[DS, (ushort)0x019F] = (ushort)0x0001;
        // 5BAE:093C and byte ptr DS:[0x019A],0xBF
        UInt8[DS, (ushort)0x019A] = Alu8.And(UInt8[DS, (ushort)0x019A], (byte)0xBF);
        // 5BAE:0941 ret near
        return NearRet((ushort)0x0000);
    label_5BAE_0942_5C422_8757:
        CheckExternalEvents(cs4, 0x0942);
        // 5BAE:0942 mov AH,AL
        AH = AL;
        // 5BAE:0944 mov BL,byte ptr DS:[0x019D]
        BL = UInt8[DS, (ushort)0x019D];
        // 5BAE:0948 mov BH,BL
        BH = BL;
        // 5BAE:094A and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 5BAE:094C and BL,0x0F
        BL = Alu8.And(BL, (byte)0x0F);
        // 5BAE:094F cmp AL,BL
        Alu8.Sub(AL, BL);
        // 5BAE:0951 je short 0x095B
        if (ZeroFlag)
        {
            goto label_5BAE_095B_5C43B_8771;
        }
    label_5BAE_0953_5C433_8765:
        CheckExternalEvents(cs4, 0x0953);
        // 5BAE:0953 inc AH
        AH = Alu8.Inc(AH);
        // 5BAE:0955 jb short 0x095B
        if (CarryFlag)
        {
            goto label_5BAE_095B_5C43B_8771;
        }
    label_5BAE_0957_5C437_8768:
        CheckExternalEvents(cs4, 0x0957);
        // 5BAE:0957 dec AH
        AH = Alu8.Dec(AH);
        // 5BAE:0959 dec AH
        AH = Alu8.Dec(AH);
    label_5BAE_095B_5C43B_8771:
        CheckExternalEvents(cs4, 0x095B);
        // 5BAE:095B mov AL,AH
        AL = AH;
        // 5BAE:095D and AH,0xF0
        AH = Alu8.And(AH, (byte)0xF0);
        // 5BAE:0960 and BH,0xF0
        BH = Alu8.And(BH, (byte)0xF0);
        // 5BAE:0963 cmp AH,BH
        Alu8.Sub(AH, BH);
        // 5BAE:0965 je short 0x096F
        if (ZeroFlag)
        {
            goto label_5BAE_096F_5C44F_8782;
        }
    label_5BAE_0967_5C447_8776:
        CheckExternalEvents(cs4, 0x0967);
        // 5BAE:0967 add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 5BAE:0969 cmp AH,BH
        Alu8.Sub(AH, BH);
        // 5BAE:096B jb short 0x096F
        if (CarryFlag)
        {
            goto label_5BAE_096F_5C44F_8782;
        }
    label_5BAE_096D_5C44D_8780:
        CheckExternalEvents(cs4, 0x096D);
        // 5BAE:096D sub AL,0x20
        AL = Alu8.Sub(AL, (byte)0x20);
    label_5BAE_096F_5C44F_8782:
        CheckExternalEvents(cs4, 0x096F);
        // 5BAE:096F mov byte ptr DS:[0x019C],AL
        UInt8[DS, (ushort)0x019C] = AL;
        // 5BAE:0972 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5BAE:0974 jne short 0x0986
        if (!ZeroFlag)
        {
            return unknown_5BAE_0986_5C466(0x0000);
        }
    label_5BAE_0976_5C456_16462:
        CheckExternalEvents(cs4, 0x0976);
        // 5BAE:0976 push DX
        Stack.Push16(DX);
        // 5BAE:0977 push SI
        Stack.Push16(SI);
        // 5BAE:0978 call near 0x091B
        NearCall(cs4, 0x097B, unknown_5BAE_091B_5C3FB);
    label_5BAE_097B_5C45B_16466:
        CheckExternalEvents(cs4, 0x097B);
        // 5BAE:097B pop SI
        SI = Stack.Pop16();
        // 5BAE:097C pop DX
        DX = Stack.Pop16();
        // 5BAE:097D mov byte ptr DS:[0x019A],0
        UInt8[DS, (ushort)0x019A] = (byte)0x00;
        return unknown_5BAE_0982_5C462(0x0000);
    }

    public virtual Action unknown_5BAE_0982_5C462(int loadOffset)
    {
    label_5BAE_0982_5C462_3792:
        CheckExternalEvents(cs4, 0x0982);
        // 5BAE:0982 mov AL,byte ptr CS:[0x019C]
        AL = UInt8[CS, (ushort)0x019C];
        return unknown_5BAE_0986_5C466(0x0000);
    }

    public virtual Action unknown_5BAE_099A_5C47A(int loadOffset)
    {
    label_5BAE_099A_5C47A_3696:
        CheckExternalEvents(cs4, 0x099A);
        // 5BAE:099A mov SI,0x0171
        SI = (ushort)0x0171;
        // 5BAE:099D mov CX,0x0012
        CX = (ushort)0x0012;
        // 5BAE:09A0 mov AH,0xFF
        AH = (byte)0xFF;
    label_5BAE_09A2_5C482_3700:
        CheckExternalEvents(cs4, 0x09A2);
        // 5BAE:09A2 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5BAE:09A3 add AL,0x80
        AL = Alu8.Add(AL, (byte)0x80);
        // 5BAE:09A5 call near 0x0AA2
        NearCall(cs4, 0x09A8, unknown_5BAE_0AA2_5C582);
    label_5BAE_09A8_5C488_3703:
        CheckExternalEvents(cs4, 0x09A8);
        // 5BAE:09A8 loop 0x09A2
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5BAE_09A2_5C482_3700;
        }
    label_5BAE_09AA_5C48A_3706:
        CheckExternalEvents(cs4, 0x09AA);
        // 5BAE:09AA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5BAE_09AB_5C48B(int loadOffset)
    {
    label_5BAE_09AB_5C48B_3892:
        CheckExternalEvents(cs4, 0x09AB);
        // 5BAE:09AB add DX,DX
        DX = Alu16.Add(DX, DX);
        // 5BAE:09AD mov BX,DX
        BX = DX;
        // 5BAE:09AF mov DX,word ptr CS:[BX+0x0135]
        DX = UInt16[CS, (ushort)(BX + (short)309)];
        // 5BAE:09B4 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5BAE:09B6 call near 0x09C3
        NearCall(cs4, 0x09B9, unknown_5BAE_09C3_5C4A3);
    label_5BAE_09B9_5C499_3969:
        CheckExternalEvents(cs4, 0x09B9);
        // 5BAE:09B9 xchg DH,DL
        byte temp_5BAE_09B9_5C499 = DH;
        DH = DL;
        DL = unchecked((byte)temp_5BAE_09B9_5C499);
        // 5BAE:09BB mov AH,byte ptr DS:[SI+0x1B]
        AH = UInt8[DS, (ushort)(SI + (sbyte)27)];
        // 5BAE:09BE add SI,0x000D
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)13)));
        // 5BAE:09C1 jmp short 0x09DC
        return unknown_5BAE_09DC_5C4BC(0x0000);
    }

    public virtual Action unknown_5BAE_09C3_5C4A3(int loadOffset)
    {
    label_5BAE_09C3_5C4A3_3898:
        CheckExternalEvents(cs4, 0x09C3);
        // 5BAE:09C3 mov AH,byte ptr DS:[SI+0x0C]
        AH = UInt8[DS, (ushort)(SI + (sbyte)12)];
        // 5BAE:09C6 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5BAE:09C8 mov AH,byte ptr DS:[SI+2]
        AH = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 5BAE:09CB not AL
        AL = unchecked((byte)~AL);
        // 5BAE:09CD shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5BAE:09CF and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 5BAE:09D2 mov AL,0xC0
        AL = (byte)0xC0;
        // 5BAE:09D4 add AL,BL
        AL = Alu8.Add(AL, BL);
        // 5BAE:09D6 call near 0x0AA2
        NearCall(cs4, 0x09D9, unknown_5BAE_0AA2_5C582);
    label_5BAE_09D9_5C4B9_3908:
        CheckExternalEvents(cs4, 0x09D9);
        // 5BAE:09D9 mov AH,byte ptr DS:[SI+0x1A]
        AH = UInt8[DS, (ushort)(SI + (sbyte)26)];
        return unknown_5BAE_09DC_5C4BC(0x0000);
    }

    public virtual Action unknown_5BAE_0A87_5C567(int loadOffset)
    {
    label_5BAE_0A87_5C567_2323:
        CheckExternalEvents(cs4, 0x0A87);
        // 5BAE:0A87 mov SI,DX
        SI = DX;
        // 5BAE:0A89 add SI,SI
        SI = Alu16.Add(SI, SI);
        // 5BAE:0A8B mov AX,word ptr DS:[SI+0x015F]
        AX = UInt16[DS, (ushort)(SI + (short)351)];
        return unknown_5BAE_0A8F_5C56F(0x0000);
    }

    public virtual Action unknown_5BAE_0A8F_5C56F(int loadOffset)
    {
    label_5BAE_0A8F_5C56F_2327:
        CheckExternalEvents(cs4, 0x0A8F);
        // 5BAE:0A8F mov CX,AX
        CX = AX;
        // 5BAE:0A91 mov AL,DL
        AL = DL;
        // 5BAE:0A93 add AL,0xA0
        AL = Alu8.Add(AL, (byte)0xA0);
        // 5BAE:0A95 mov AH,CL
        AH = CL;
        // 5BAE:0A97 mov SI,AX
        SI = AX;
        // 5BAE:0A99 call near 0x0AA2
        NearCall(cs4, 0x0A9C, unknown_5BAE_0AA2_5C582);
    label_5BAE_0A9C_5C57C_2333:
        CheckExternalEvents(cs4, 0x0A9C);
        // 5BAE:0A9C mov AX,SI
        AX = SI;
        // 5BAE:0A9E add AL,0x10
        AL = Alu8.Add(AL, (byte)0x10);
        // 5BAE:0AA0 mov AH,CH
        AH = CH;
        return unknown_5BAE_0AA2_5C582(0x0000);
    }

    public virtual Action unknown_5BAE_0AA2_5C582(int loadOffset)
    {
    label_5BAE_0AA2_5C582_2249:
        CheckExternalEvents(cs4, 0x0AA2);
        // 5BAE:0AA2 push DX
        Stack.Push16(DX);
        // 5BAE:0AA3 mov DX,0x0388
        DX = (ushort)0x0388;
        // 5BAE:0AA6 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5BAE:0AA7 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AA8 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AA9 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AAA in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AAB in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AAC in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AAD in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AAE inc DX
        DX = Alu16.Inc(DX);
        // 5BAE:0AAF mov AL,AH
        AL = AH;
        // 5BAE:0AB1 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5BAE:0AB2 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB3 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB4 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB5 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB6 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB7 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB8 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AB9 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABA in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABB in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABC in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABD in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABE in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ABF in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC0 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC1 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC2 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC3 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC4 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC5 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC6 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC7 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC8 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AC9 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACA in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACB in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACC in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACD in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACE in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0ACF in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD0 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD1 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD2 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD3 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD4 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5BAE:0AD5 pop DX
        DX = Stack.Pop16();
        // 5BAE:0AD6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action provided_interrupt_handler_10_F000_0000_F0000(int loadOffset)
    {
    label_F000_0000_F0000_762:
        CheckExternalEvents(cs5, 0x0000);
        // F000:0000 callback 0x0010
        Callback(unchecked((ushort)((ushort)0x0010)));
    label_F000_0004_F0004_764:
        CheckExternalEvents(cs5, 0x0004);
        // F000:0004 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_1C_F000_0005_F0005(int loadOffset)
    {
    label_F000_0005_F0005_68:
        CheckExternalEvents(cs5, 0x0005);
        // F000:0005 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_8_F000_0006_F0006(int loadOffset)
    {
    label_F000_0006_F0006_64:
        CheckExternalEvents(cs5, 0x0006);
        // F000:0006 callback 8
        Callback(unchecked((ushort)((ushort)0x0008)));
    label_F000_000A_F000A_65:
        CheckExternalEvents(cs5, 0x000A);
        // F000:000A int 0x1C
        InterruptCall(cs5, 0x000C, unchecked((byte)((byte)0x1C)));
    label_F000_000C_F000C_70:
        CheckExternalEvents(cs5, 0x000C);
        // F000:000C callback 0x0101
        Callback(unchecked((ushort)((ushort)0x0101)));
    label_F000_0010_F0010_72:
        CheckExternalEvents(cs5, 0x0010);
        // F000:0010 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_9_F000_0011_F0011(int loadOffset)
    {
    label_F000_0011_F0011_36128:
        CheckExternalEvents(cs5, 0x0011);
        // F000:0011 callback 9
        Callback(unchecked((ushort)((ushort)0x0009)));
    label_F000_0015_F0015_36130:
        CheckExternalEvents(cs5, 0x0015);
        // F000:0015 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_70_F000_0057_F0057(int loadOffset)
    {
    label_F000_0057_F0057_36951:
        CheckExternalEvents(cs5, 0x0057);
        // F000:0057 callback 0x0070
        Callback(unchecked((ushort)((ushort)0x0070)));
    label_F000_005B_F005B_36952:
        CheckExternalEvents(cs5, 0x005B);
        // F000:005B iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_74_F000_005D_F005D(int loadOffset)
    {
    label_F000_005D_F005D_4677:
        CheckExternalEvents(cs5, 0x005D);
        // F000:005D call far F000:00E3
        FarCall(cs5, 0x0062, cs5, provided_mouse_driver_F000_00E3_F00E3);
    label_F000_0062_F0062_4689:
        CheckExternalEvents(cs5, 0x0062);
        // F000:0062 callback 0x0074
        Callback(unchecked((ushort)((ushort)0x0074)));
    label_F000_0066_F0066_4691:
        CheckExternalEvents(cs5, 0x0066);
        // F000:0066 iret
        return InterruptRet();
    }

    public virtual Action provided_interrupt_handler_B_F000_0067_F0067(int loadOffset)
    {
    label_F000_0067_F0067_36935:
        CheckExternalEvents(cs5, 0x0067);
        // F000:0067 callback 0x0104
        Callback(unchecked((ushort)((ushort)0x0104)));
    label_F000_006B_F006B_36936:
        CheckExternalEvents(cs5, 0x006B);
        // F000:006B iret
        return InterruptRet();
    }
}
