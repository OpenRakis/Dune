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
    public virtual Action unknown_100D_68E0_169B0(int loadOffset)
    {
    entrydispatcher:
    label_100D_68E0_169B0_35519:
        CheckExternalEvents(cs1, 0x68E0);
        // 100D:68E0 and byte ptr DS:[SI+0x10],0xEF
        UInt8[DS, (ushort)(SI + (sbyte)16)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0xEF);
        // 100D:68E4 inc CX
        CX = Alu16.Inc(CX);
        // 100D:68E5 push CX
        Stack.Push16(CX);
        // 100D:68E6 call near 0x846C
        NearCall(cs1, 0x68E9, unknown_100D_846C_1853C);
    label_100D_68E9_169B9_35531:
        CheckExternalEvents(cs1, 0x68E9);
        // 100D:68E9 pop CX
        CX = Stack.Pop16();
        return unknown_100D_68EA_169BA(0x0000);
    }

    public virtual Action unknown_100D_6912_169E2(int loadOffset)
    {
    label_100D_6912_169E2_3094:
        CheckExternalEvents(cs1, 0x6912);
        // 100D:6912 cmp byte ptr DS:[SI+3],0x80
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x80);
        // 100D:6916 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6B24_16BF4(int loadOffset)
    {
    label_100D_6B24_16BF4_24685:
        CheckExternalEvents(cs1, 0x6B24);
        // 100D:6B24 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6BB6_16C86(int loadOffset)
    {
    entrydispatcher:
    label_100D_6BB6_16C86_24609:
        CheckExternalEvents(cs1, 0x6BB6);
        // 100D:6BB6 pushf
        Stack.Push16(FlagRegister16);
        // 100D:6BB7 sbb AH,AH
        AH = Alu8.Sbb(AH, AH);
        // 100D:6BB9 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6BBC and AX,0x1010
        AX = Alu16.And(AX, (ushort)0x1010);
        // 100D:6BBF cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:6BC1 je short 0x6BD5
        if (ZeroFlag)
        {
            goto label_100D_6BD5_16CA5_24616;
        }
    label_100D_6BC3_16C93_28118:
        CheckExternalEvents(cs1, 0x6BC3);
        // 100D:6BC3 xor byte ptr DS:[SI+3],0x10
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Xor(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x10);
        // 100D:6BC7 push AX
        Stack.Push16(AX);
        // 100D:6BC8 push DI
        Stack.Push16(DI);
        // 100D:6BC9 call near 0x8461
        NearCall(cs1, 0x6BCC, unknown_100D_8461_18531);
    label_100D_6BCC_16C9C_28136:
        CheckExternalEvents(cs1, 0x6BCC);
        // 100D:6BCC pop DI
        DI = Stack.Pop16();
        // 100D:6BCD pop AX
        AX = Stack.Pop16();
        // 100D:6BCE test AL,0x10
        Alu8.And(AL, (byte)0x10);
        // 100D:6BD0 je short 0x6BD5
        if (ZeroFlag)
        {
            goto label_100D_6BD5_16CA5_24616;
        }
    label_100D_6BD2_16CA2_30624:
        CheckExternalEvents(cs1, 0x6BD2);
        // 100D:6BD2 call near 0x6B25
        NearCall(cs1, 0x6BD5, unknown_100D_6B25_16BF5);
    label_100D_6BD5_16CA5_24616:
        CheckExternalEvents(cs1, 0x6BD5);
        // 100D:6BD5 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_6BD6_16CA6_24618:
        CheckExternalEvents(cs1, 0x6BD6);
        // 100D:6BD6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_71BB_1728B(int loadOffset)
    {
    label_100D_71BB_1728B_25153:
        CheckExternalEvents(cs1, 0x71BB);
        // 100D:71BB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_73EF_174BF(int loadOffset)
    {
    entrydispatcher:
    label_100D_73EF_174BF_36132:
        CheckExternalEvents(cs1, 0x73EF);
        // 100D:73EF call near 0x5098
        NearCall(cs1, 0x73F2, unknown_100D_5098_15168);
    label_100D_73F2_174C2_36139:
        CheckExternalEvents(cs1, 0x73F2);
        // 100D:73F2 push CX
        Stack.Push16(CX);
        // 100D:73F3 call near 0x342D
        NearCall(cs1, 0x73F6, unknown_100D_342D_134FD);
    label_100D_73F6_174C6_36142:
        CheckExternalEvents(cs1, 0x73F6);
        // 100D:73F6 pop CX
        CX = Stack.Pop16();
        // 100D:73F7 jcxz short 0x73FD
        if (CX == (ushort)0x0000)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:73F7");
        }
    label_100D_73F9_174C9_36145:
        CheckExternalEvents(cs1, 0x73F9);
        // 100D:73F9 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:73FB div CX
        ushort divisor_100D_73FB_174CB = CX;
        uint dividend_100D_73FB_174CB = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_73FB_174CB = Alu16.Div(unchecked((uint)dividend_100D_73FB_174CB), unchecked((ushort)divisor_100D_73FB_174CB));
        AX = unchecked((ushort)quotient_100D_73FB_174CB);
        DX = unchecked((ushort)(dividend_100D_73FB_174CB % unchecked((uint)divisor_100D_73FB_174CB)));
        // 100D:73FD mov DL,AL
        DL = AL;
        // 100D:73FF inc DL
        DL = Alu8.Inc(DL);
        // 100D:7401 jne short 0x7405
        if (!ZeroFlag)
        {
            goto label_100D_7405_174D5_36151;
        }
    label_100D_7403_174D3_40900:
        CheckExternalEvents(cs1, 0x7403);
        // 100D:7403 dec DL
        DL = Alu8.Dec(DL);
    label_100D_7405_174D5_36151:
        CheckExternalEvents(cs1, 0x7405);
        // 100D:7405 xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 100D:7407 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:7409 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:740B mov BP,0x7552
        BP = (ushort)0x7552;
        // 100D:740E call near 0x6603
        NearCall(cs1, 0x7411, unknown_100D_6603_166D3);
    label_100D_7411_174E1_36169:
        CheckExternalEvents(cs1, 0x7411);
        // 100D:7411 add word ptr DS:[SI+0x0C],CX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)12)], CX);
        // 100D:7414 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:7416 je short 0x7429
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_7429_174F9, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_7418_174E8_36173:
        CheckExternalEvents(cs1, 0x7418);
        // 100D:7418 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_751D_175ED(int loadOffset)
    {
    entrydispatcher:
    label_100D_751D_175ED_34366:
        CheckExternalEvents(cs1, 0x751D);
        // 100D:751D mov AX,word ptr DS:[0x0094]
        AX = UInt16[DS, (ushort)0x0094];
        // 100D:7520 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:7522 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:7524 mov CL,byte ptr DS:[0x0060]
        CL = UInt8[DS, (ushort)0x0060];
        // 100D:7528 jcxz short 0x752C
        if (CX == (ushort)0x0000)
        {
            goto label_100D_752C_175FC_34372;
        }
    label_100D_752A_175FA_35792:
        CheckExternalEvents(cs1, 0x752A);
        // 100D:752A div CX
        ushort divisor_100D_752A_175FA = CX;
        uint dividend_100D_752A_175FA = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_752A_175FA = Alu16.Div(unchecked((uint)dividend_100D_752A_175FA), unchecked((ushort)divisor_100D_752A_175FA));
        AX = unchecked((ushort)quotient_100D_752A_175FA);
        DX = unchecked((ushort)(dividend_100D_752A_175FA % unchecked((uint)divisor_100D_752A_175FA)));
    label_100D_752C_175FC_34372:
        CheckExternalEvents(cs1, 0x752C);
        // 100D:752C mov DX,AX
        DX = AX;
        // 100D:752E call near 0x758D
        NearCall(cs1, 0x7531, unknown_100D_758D_1765D);
    label_100D_7531_17601_34394:
        CheckExternalEvents(cs1, 0x7531);
        // 100D:7531 add word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)14)], AX);
        // 100D:7534 sub byte ptr DS:[SI+0x1A],AL
        UInt8[DS, (ushort)(SI + (sbyte)26)] = Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)26)], AL);
        // 100D:7537 ja short 0x7551
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_7551_17621_34522;
        }
    label_100D_7539_17609_34398:
        CheckExternalEvents(cs1, 0x7539);
        // 100D:7539 mov BX,0x007F
        BX = (ushort)0x007F;
        // 100D:753C call near 0xE3B7
        NearCall(cs1, 0x753F, unknown_100D_E3B7_1E487);
    label_100D_753F_1760F_34401:
        CheckExternalEvents(cs1, 0x753F);
        // 100D:753F add AL,0x1E
        AL = Alu8.Add(AL, (byte)0x1E);
        // 100D:7541 mov byte ptr DS:[SI+0x1A],AL
        UInt8[DS, (ushort)(SI + (sbyte)26)] = AL;
        // 100D:7544 call near 0x668F
        NearCall(cs1, 0x7547, unknown_100D_668F_1675F);
    label_100D_7547_17617_34458:
        CheckExternalEvents(cs1, 0x7547);
        // 100D:7547 call near 0x5098
        NearCall(cs1, 0x754A, unknown_100D_5098_15168);
    label_100D_754A_1761A_34462:
        CheckExternalEvents(cs1, 0x754A);
        // 100D:754A or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:754C jne short 0x7551
        if (!ZeroFlag)
        {
            goto label_100D_7551_17621_34522;
        }
    label_100D_754E_1761E_34465:
        CheckExternalEvents(cs1, 0x754E);
        // 100D:754E call near 0x74B6
        NearCall(cs1, 0x7551, unknown_100D_74B6_17586);
    label_100D_7551_17621_34522:
        CheckExternalEvents(cs1, 0x7551);
        // 100D:7551 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_764C_1771C(int loadOffset)
    {
    label_100D_764C_1771C_36487:
        CheckExternalEvents(cs1, 0x764C);
        // 100D:764C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7655_17725(int loadOffset)
    {
    entrydispatcher:
    label_100D_7655_17725_37125:
        CheckExternalEvents(cs1, 0x7655);
        // 100D:7655 push CX
        Stack.Push16(CX);
        // 100D:7656 push DX
        Stack.Push16(DX);
        // 100D:7657 call near 0x66B1
        NearCall(cs1, 0x765A, unknown_100D_66B1_16781);
    label_100D_765A_1772A_37160:
        CheckExternalEvents(cs1, 0x765A);
        // 100D:765A pop DX
        DX = Stack.Pop16();
        // 100D:765B pop CX
        CX = Stack.Pop16();
        // 100D:765C inc CX
        CX = Alu16.Inc(CX);
        return unknown_100D_765D_1772D(0x0000);
    }

    public virtual Action unknown_100D_78BB_1798B(int loadOffset)
    {
    label_100D_78BB_1798B_24683:
        CheckExternalEvents(cs1, 0x78BB);
        // 100D:78BB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_79DB_17AAB(int loadOffset)
    {
    label_100D_79DB_17AAB_13264:
        CheckExternalEvents(cs1, 0x79DB);
        // 100D:79DB jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_7C56_17D26(int loadOffset)
    {
    label_100D_7C56_17D26_24446:
        CheckExternalEvents(cs1, 0x7C56);
        // 100D:7C56 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:7C5B jns short 0x7C60
        if (!SignFlag)
        {
            goto label_100D_7C60_17D30_24451;
        }
    label_100D_7C5D_17D2D_24449:
        CheckExternalEvents(cs1, 0x7C5D);
        // 100D:7C5D call near 0x9901
        NearCall(cs1, 0x7C60, unknown_100D_9901_199D1);
    label_100D_7C60_17D30_24451:
        CheckExternalEvents(cs1, 0x7C60);
        // 100D:7C60 jmp near 0xC07C
        return unknown_100D_C07C_1C14C(0x0000);
    }

    public virtual Action unknown_100D_7EE1_17FB1(int loadOffset)
    {
    label_100D_7EE1_17FB1_27758:
        CheckExternalEvents(cs1, 0x7EE1);
        // 100D:7EE1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8313_183E3(int loadOffset)
    {
    entrydispatcher:
    label_100D_8313_183E3_29600:
        CheckExternalEvents(cs1, 0x8313);
        // 100D:8313 push CX
        Stack.Push16(CX);
        // 100D:8314 call near 0x8604
        NearCall(cs1, 0x8317, unknown_100D_8604_186D4);
    label_100D_8317_183E7_29651:
        CheckExternalEvents(cs1, 0x8317);
        // 100D:8317 pop CX
        CX = Stack.Pop16();
        // 100D:8318 mov AX,BX
        AX = BX;
        // 100D:831A or AX,DX
        AX = Alu16.Or(AX, DX);
        // 100D:831C je short 0x8357
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_8357_18427, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_831E_183EE_29656:
        CheckExternalEvents(cs1, 0x831E);
        // 100D:831E add word ptr DS:[SI+6],DX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)6)], DX);
        // 100D:8321 add word ptr DS:[SI+8],BX
        UInt16[DS, (ushort)(SI + (sbyte)8)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)8)], BX);
        // 100D:8324 loop 0x8313
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_8313_183E3_29600;
        }
    label_100D_8326_183F6_29662:
        CheckExternalEvents(cs1, 0x8326);
        // 100D:8326 call near 0x686E
        NearCall(cs1, 0x8329, unknown_100D_686E_1693E);
    label_100D_8329_183F9_29664:
        CheckExternalEvents(cs1, 0x8329);
        // 100D:8329 jb short 0x8333
        if (CarryFlag)
        {
            goto label_100D_8333_18403_29757;
        }
    label_100D_832B_183FB_29666:
        CheckExternalEvents(cs1, 0x832B);
        // 100D:832B call near 0x6917
        NearCall(cs1, 0x832E, unknown_100D_6917_169E7);
    label_100D_832E_183FE_29668:
        CheckExternalEvents(cs1, 0x832E);
        // 100D:832E jne short 0x833C
        if (!ZeroFlag)
        {
            goto label_100D_833C_1840C_35573;
        }
    label_100D_8330_18400_29670:
        CheckExternalEvents(cs1, 0x8330);
        // 100D:8330 jmp near 0xC653
        goto label_100D_C653_1C723_29672;
    label_100D_8333_18403_29757:
        CheckExternalEvents(cs1, 0x8333);
        // 100D:8333 call near 0x6917
        NearCall(cs1, 0x8336, unknown_100D_6917_169E7);
    label_100D_8336_18406_29762:
        CheckExternalEvents(cs1, 0x8336);
        // 100D:8336 jne short 0x833B
        if (!ZeroFlag)
        {
            goto label_100D_833B_1840B_29764;
        }
    label_100D_8338_18408_37941:
        CheckExternalEvents(cs1, 0x8338);
        // 100D:8338 jmp near 0xC58A
        if (JumpDispatcher.Jump(unknown_100D_C58A_1C65A, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_833B_1840B_29764:
        CheckExternalEvents(cs1, 0x833B);
        // 100D:833B ret near
        return NearRet((ushort)0x0000);
    label_100D_833C_1840C_35573:
        CheckExternalEvents(cs1, 0x833C);
        // 100D:833C call near 0x6827
        NearCall(cs1, 0x833F, unknown_100D_6827_168F7);
    label_100D_833F_1840F_35575:
        CheckExternalEvents(cs1, 0x833F);
        // 100D:833F call near 0xC5CF
        NearCall(cs1, 0x8342, unknown_100D_C5CF_1C69F);
    label_100D_8342_18412_35577:
        CheckExternalEvents(cs1, 0x8342);
        // 100D:8342 mov SI,DI
        SI = DI;
        // 100D:8344 jmp near 0xC6AD
        if (JumpDispatcher.Jump(unknown_100D_C6AD_1C77D, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_C653_1C723_29672:
        CheckExternalEvents(cs1, 0xC653);
        // 100D:C653 call near 0xC13B
        NearCall(cs1, 0xC656, unknown_100D_C13B_1C20B);
    label_100D_C656_1C726_29674:
        CheckExternalEvents(cs1, 0xC656);
        // 100D:C656 mov AX,word ptr DS:[DI+8]
        AX = UInt16[DS, (ushort)(DI + (sbyte)8)];
        // 100D:C659 call near 0xC202
        NearCall(cs1, 0xC65C, unknown_100D_C202_1C2D2);
    label_100D_C65C_1C72C_29677:
        CheckExternalEvents(cs1, 0xC65C);
        // 100D:C65C sub DX,word ptr DS:[DI]
        DX = Alu16.Sub(DX, UInt16[DS, DI]);
        // 100D:C65E sub BX,word ptr DS:[DI+2]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)2)]);
        if (JumpDispatcher.Jump(unknown_100D_C661_1C731, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8831_18901(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_8831_18901_28205;
            case 0x8857:
                goto label_100D_8857_18927_28242;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_8831_18901_28205:
        CheckExternalEvents(cs1, 0x8831);
        // 100D:8831 test AL,1
        Alu8.And(AL, (byte)0x01);
        // 100D:8833 je short 0x8857
        if (ZeroFlag)
        {
            goto label_100D_8857_18927_28242;
        }
    label_100D_8835_18905_28208:
        CheckExternalEvents(cs1, 0x8835);
        // 100D:8835 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:883A jns short 0x8846
        if (!SignFlag)
        {
            goto label_100D_8846_18916_28211;
        }
    label_100D_883C_1890C_29698:
        CheckExternalEvents(cs1, 0x883C);
        // 100D:883C test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:8841 jne short 0x8858
        if (!ZeroFlag)
        {
            goto label_100D_8858_18928_32122;
        }
    label_100D_8843_18913_29701:
        CheckExternalEvents(cs1, 0x8843);
        // 100D:8843 call near 0x5BEB
        NearCall(cs1, 0x8846, unknown_100D_5BEB_15CBB);
    label_100D_8846_18916_28211:
        CheckExternalEvents(cs1, 0x8846);
        // 100D:8846 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8847 add word ptr DS:[0x197C],AX
        UInt16[DS, (ushort)0x197C] = Alu16.Add(UInt16[DS, (ushort)0x197C], AX);
        // 100D:884B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:884C add word ptr DS:[0x197E],AX
        UInt16[DS, (ushort)0x197E] = Alu16.Add(UInt16[DS, (ushort)0x197E], AX);
        if (JumpDispatcher.Jump(unknown_100D_8850_18920, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_8857_18927_28242:
        CheckExternalEvents(cs1, 0x8857);
        // 100D:8857 ret near
        return NearRet((ushort)0x0000);
    label_100D_8858_18928_32122:
        CheckExternalEvents(cs1, 0x8858);
        // 100D:8858 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8859 add word ptr DS:[0x1980],AX
        UInt16[DS, (ushort)0x1980] = Alu16.Add(UInt16[DS, (ushort)0x1980], AX);
        // 100D:885D lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:885E add word ptr DS:[0x1982],AX
        UInt16[DS, (ushort)0x1982] = Alu16.Add(UInt16[DS, (ushort)0x1982], AX);
        // 100D:8862 jmp near 0x542F
        if (JumpDispatcher.Jump(unknown_100D_542F_154FF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8895_18965(int loadOffset)
    {
    label_100D_8895_18965_15718:
        CheckExternalEvents(cs1, 0x8895);
        // 100D:8895 mov AL,byte ptr DS:[0x00FB]
        AL = UInt8[DS, (ushort)0x00FB];
        // 100D:8898 not AL
        AL = unchecked((byte)~AL);
        // 100D:889A and AL,0x80
        AL = Alu8.And(AL, (byte)0x80);
        // 100D:889C mov byte ptr DS:[0x1C06],AL
        UInt8[DS, (ushort)0x1C06] = AL;
        // 100D:889F push DS
        Stack.Push16(DS);
        // 100D:88A0 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:88A1 mov DI,0x1BE2
        DI = (ushort)0x1BE2;
        // 100D:88A4 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:88A6 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:88A7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:88A8 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:88A9 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:88AA mov AL,0x80
        AL = (byte)0x80;
        // 100D:88AC stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:88AD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8ABE_18B8E(int loadOffset)
    {
    entrydispatcher:
        switch (loadOffset)
        {
            case 0x0000:
                goto label_100D_8ABE_18B8E_24803;
            case 0x8AC1:
                goto label_100D_8AC1_18B91_24372;
            case 0x8AC2:
                goto label_100D_8AC2_18B92_24374;
            default:
                throw FailAsUntested($"Unknown generated entry loadOffset 0x{loadOffset:X4}");
        }

    label_100D_8ABE_18B8E_24803:
        CheckExternalEvents(cs1, 0x8ABE);
        // 100D:8ABE call near 0x8AC3
        NearCall(cs1, 0x8AC1, unknown_100D_8AC3_18B93);
    label_100D_8AC1_18B91_24372:
        CheckExternalEvents(cs1, 0x8AC1);
        // 100D:8AC1 pop BX
        BX = Stack.Pop16();
    label_100D_8AC2_18B92_24374:
        CheckExternalEvents(cs1, 0x8AC2);
        // 100D:8AC2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9281_19351(int loadOffset)
    {
    label_100D_9281_19351_14301:
        CheckExternalEvents(cs1, 0x9281);
        // 100D:9281 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_994E_19A1E(int loadOffset)
    {
    label_100D_994E_19A1E_7994:
        CheckExternalEvents(cs1, 0x994E);
        // 100D:994E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9A1C_19AEC(int loadOffset)
    {
    label_100D_9A1C_19AEC_8370:
        CheckExternalEvents(cs1, 0x9A1C);
        // 100D:9A1C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_9D93_19E63(int loadOffset)
    {
    label_100D_9D93_19E63_24273:
        CheckExternalEvents(cs1, 0x9D93);
        // 100D:9D93 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A156_1A226(int loadOffset)
    {
    label_100D_A156_1A226_32281:
        CheckExternalEvents(cs1, 0xA156);
        // 100D:A156 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A234_1A304(int loadOffset)
    {
    label_100D_A234_1A304_23084:
        CheckExternalEvents(cs1, 0xA234);
        // 100D:A234 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A24A_1A31A(int loadOffset)
    {
    entrydispatcher:
    label_100D_A24A_1A31A_32996:
        CheckExternalEvents(cs1, 0xA24A);
        // 100D:A24A mov byte ptr DS:[0x476D],AL
        UInt8[DS, (ushort)0x476D] = AL;
        // 100D:A24D mov byte ptr DS:[0x009F],0
        UInt8[DS, (ushort)0x009F] = (byte)0x00;
        // 100D:A252 mov BP,0x1FFE
        BP = (ushort)0x1FFE;
        // 100D:A255 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:A258 call near 0xD323
        NearCall(cs1, 0xA25B, unknown_100D_D323_1D3F3);
        return unknown_100D_A25B_1A32B(0x0000);
    }

    public virtual Action unknown_100D_A28C_1A35C(int loadOffset)
    {
    label_100D_A28C_1A35C_26968:
        CheckExternalEvents(cs1, 0xA28C);
        // 100D:A28C pop SI
        SI = Stack.Pop16();
        // 100D:A28D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A435_1A505(int loadOffset)
    {
    label_100D_A435_1A505_25457:
        CheckExternalEvents(cs1, 0xA435);
        // 100D:A435 push word ptr DS:[0xDBDA]
        Stack.Push16(UInt16[DS, (ushort)0xDBDA]);
        // 100D:A439 call near 0xC08E
        NearCall(cs1, 0xA43C, unknown_100D_C08E_1C15E);
    label_100D_A43C_1A50C_25459:
        CheckExternalEvents(cs1, 0xA43C);
        // 100D:A43C cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:A43D call near 0xA465
        NearCall(cs1, 0xA440, unknown_100D_A465_1A535);
    label_100D_A440_1A510_25475:
        CheckExternalEvents(cs1, 0xA440);
        // 100D:A440 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:A442 add AL,0x1C
        AL = Alu8.Add(AL, (byte)0x1C);
        // 100D:A444 call near 0xC22F
        NearCall(cs1, 0xA447, unknown_100D_C22F_1C2FF);
    label_100D_A447_1A517_25479:
        CheckExternalEvents(cs1, 0xA447);
        // 100D:A447 pop word ptr DS:[0xDBDA]
        ushort popStackCheck_100D_A447_1A517 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_A447_1A517 = UInt16[DS, (ushort)0xDBDA];
        ushort poppedValue_100D_A447_1A517 = Stack.Pop16();
        UInt16[DS, (ushort)0xDBDA] = unchecked((ushort)poppedValue_100D_A447_1A517);
        // 100D:A44B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A540_1A610(int loadOffset)
    {
    entrydispatcher:
    label_100D_A540_1A610_25394:
        CheckExternalEvents(cs1, 0xA540);
        // 100D:A540 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A69E_1A76E(int loadOffset)
    {
    label_100D_A69E_1A76E_25565:
        CheckExternalEvents(cs1, 0xA69E);
        // 100D:A69E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A6CB_1A79B(int loadOffset)
    {
    label_100D_A6CB_1A79B_25624:
        CheckExternalEvents(cs1, 0xA6CB);
        // 100D:A6CB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A75C_1A82C(int loadOffset)
    {
    entrydispatcher:
    label_100D_A75C_1A82C_8694:
        CheckExternalEvents(cs1, 0xA75C);
        // 100D:A75C call near 0x9197
        NearCall(cs1, 0xA75F, unknown_100D_9197_19267);
    label_100D_A75F_1A82F_8696:
        CheckExternalEvents(cs1, 0xA75F);
        // 100D:A75F mov BP,0
        BP = (ushort)0x0000;
        // 100D:A762 mov SI,0xA7C2
        SI = (ushort)0xA7C2;
        // 100D:A765 call near 0xDA25
        NearCall(cs1, 0xA768, unknown_100D_DA25_1DAF5);
    label_100D_A768_1A838_8700:
        CheckExternalEvents(cs1, 0xA768);
        // 100D:A768 mov byte ptr DS:[0xDC2B],1
        UInt8[DS, (ushort)0xDC2B] = (byte)0x01;
        // 100D:A76D mov SI,0x3811
        SI = (ushort)0x3811;
        // 100D:A770 call far dword ptr DS:[0x3991]
        ushort targetSegment_8703 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3991 + (ushort)0x0002)]));
        ushort targetOffset_8703 = unchecked((ushort)(UInt16[DS, (ushort)0x3991]));
        if (targetSegment_8703 == cs3 && targetOffset_8703 == 0x0106)
        {
            FarCall(cs1, 0xA774, cs3, unknown_5642_0106_56526);
            goto label_100D_A774_1A844_8705;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8703:X4}:{targetOffset_8703:X4} at 100D:A770");
    label_100D_A774_1A844_8705:
        CheckExternalEvents(cs1, 0xA774);
        // 100D:A774 mov AX,word ptr DS:[0xCE7A]
        AX = UInt16[DS, (ushort)0xCE7A];
        // 100D:A777 mov word ptr DS:[0xDC2C],AX
        UInt16[DS, (ushort)0xDC2C] = AX;
        // 100D:A77A mov word ptr DS:[0xDC2E],0x8000
        UInt16[DS, (ushort)0xDC2E] = (ushort)0x8000;
        // 100D:A780 call near 0xA814
        NearCall(cs1, 0xA783, unknown_100D_A814_1A8E4);
    label_100D_A783_1A853_8724:
        CheckExternalEvents(cs1, 0xA783);
        // 100D:A783 jae short 0xA788
        if (!CarryFlag)
        {
            return unknown_100D_A788_1A858(0x0000);
        }
    label_100D_A785_1A855_8726:
        CheckExternalEvents(cs1, 0xA785);
        // 100D:A785 call near 0xA82E
        NearCall(cs1, 0xA788, unknown_100D_A82E_1A8FE);
        return unknown_100D_A788_1A858(0x0000);
    }

    public virtual Action unknown_100D_A90A_1A9DA(int loadOffset)
    {
    label_100D_A90A_1A9DA_8451:
        CheckExternalEvents(cs1, 0xA90A);
        // 100D:A90A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_A9B8_1AA88(int loadOffset)
    {
    label_100D_A9B8_1AA88_1853:
        CheckExternalEvents(cs1, 0xA9B8);
        // 100D:A9B8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AA0E_1AADE(int loadOffset)
    {
    label_100D_AA0E_1AADE_4284:
        CheckExternalEvents(cs1, 0xAA0E);
        // 100D:AA0E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AB44_1AC14(int loadOffset)
    {
    label_100D_AB44_1AC14_10397:
        CheckExternalEvents(cs1, 0xAB44);
        // 100D:AB44 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ADBD_1AE8D(int loadOffset)
    {
    label_100D_ADBD_1AE8D_4110:
        CheckExternalEvents(cs1, 0xADBD);
        // 100D:ADBD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_ADF8_1AEC8(int loadOffset)
    {
    label_100D_ADF8_1AEC8_8594:
        CheckExternalEvents(cs1, 0xADF8);
        // 100D:ADF8 cmp BL,4
        Alu8.Sub(BL, (byte)0x04);
        // 100D:ADFB jae short 0xADFF
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:ADFB");
        }
    label_100D_ADFF_1AECF_8597:
        CheckExternalEvents(cs1, 0xADFF);
        // 100D:ADFF call far dword ptr DS:[0x397D]
        ushort targetSegment_8597 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x397D + (ushort)0x0002)]));
        ushort targetOffset_8597 = unchecked((ushort)(UInt16[DS, (ushort)0x397D]));
        if (targetSegment_8597 == cs4 && targetOffset_8597 == 0x010C)
        {
            FarCall(cs1, 0xAE03, cs4, unknown_5BAE_010C_5BBEC);
            goto label_100D_AE03_1AED3_8626;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8597:X4}:{targetOffset_8597:X4} at 100D:ADFF");
    label_100D_AE03_1AED3_8626:
        CheckExternalEvents(cs1, 0xAE03);
        // 100D:AE03 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_AFC6_1B096(int loadOffset)
    {
    label_100D_AFC6_1B096_40164:
        CheckExternalEvents(cs1, 0xAFC6);
        // 100D:AFC6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B2BD_1B38D(int loadOffset)
    {
    label_100D_B2BD_1B38D_16365:
        CheckExternalEvents(cs1, 0xB2BD);
        // 100D:B2BD ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B30E_1B3DE(int loadOffset)
    {
    label_100D_B30E_1B3DE_19428:
        CheckExternalEvents(cs1, 0xB30E);
        // 100D:B30E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_B98E_1BA5E(int loadOffset)
    {
    entrydispatcher:
    label_100D_B98E_1BA5E_12733:
        CheckExternalEvents(cs1, 0xB98E);
        // 100D:B98E call near 0xBAF2
        NearCall(cs1, 0xB991, unknown_100D_BAF2_1BBC2);
    label_100D_B991_1BA61_12741:
        CheckExternalEvents(cs1, 0xB991);
        // 100D:B991 push BX
        Stack.Push16(BX);
        // 100D:B992 push DX
        Stack.Push16(DX);
        // 100D:B993 mov SI,0xD834
        SI = (ushort)0xD834;
        // 100D:B996 call near 0xDB74
        NearCall(cs1, 0xB999, unknown_100D_DB74_1DC44);
    label_100D_B999_1BA69_12746:
        CheckExternalEvents(cs1, 0xB999);
        // 100D:B999 call near 0xC4ED
        NearCall(cs1, 0xB99C, unknown_100D_C4ED_1C5BD);
    label_100D_B99C_1BA6C_12750:
        CheckExternalEvents(cs1, 0xB99C);
        // 100D:B99C pop DX
        DX = Stack.Pop16();
        // 100D:B99D pop BX
        BX = Stack.Pop16();
        // 100D:B99E or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:B9A0 je short 0xB9A5
        if (ZeroFlag)
        {
            goto label_100D_B9A5_1BA75_12755;
        }
    label_100D_B9A2_1BA72_18828:
        CheckExternalEvents(cs1, 0xB9A2);
        // 100D:B9A2 call near 0xBC0C
        NearCall(cs1, 0xB9A5, unknown_100D_BC0C_1BCDC);
    label_100D_B9A5_1BA75_12755:
        CheckExternalEvents(cs1, 0xB9A5);
        // 100D:B9A5 call near 0xDB67
        NearCall(cs1, 0xB9A8, unknown_100D_DB67_1DC37);
    label_100D_B9A8_1BA78_12757:
        CheckExternalEvents(cs1, 0xB9A8);
        // 100D:B9A8 mov AX,1
        AX = (ushort)0x0001;
        // 100D:B9AB jmp short 0xB9E0
        return unknown_100D_B9E0_1BAB0(0x0000);
    }

    public virtual Action unknown_100D_B9C5_1BA95(int loadOffset)
    {
    entrydispatcher:
    label_100D_B9C5_1BA95_36780:
        CheckExternalEvents(cs1, 0xB9C5);
        // 100D:B9C5 jae short 0xB9DF
        if (!CarryFlag)
        {
            return unknown_100D_B9DF_1BAAF(0x0000);
        }
    label_100D_B9C7_1BA97_36781:
        CheckExternalEvents(cs1, 0xB9C7);
        // 100D:B9C7 call near 0xBA15
        NearCall(cs1, 0xB9CA, unknown_100D_BA15_1BAE5);
    label_100D_B9CA_1BA9A_36783:
        CheckExternalEvents(cs1, 0xB9CA);
        // 100D:B9CA jmp short 0xB98B
        if (JumpDispatcher.Jump(unknown_100D_B98B_1BA5B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_BA2D_1BAFD(int loadOffset)
    {
    label_100D_BA2D_1BAFD_12430:
        CheckExternalEvents(cs1, 0xBA2D);
        // 100D:BA2D push DS
        Stack.Push16(DS);
        // 100D:BA2E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:BA2F mov DI,0x8B77
        DI = (ushort)0x8B77;
        // 100D:BA32 mov BX,0x0062
        BX = (ushort)0x0062;
        // 100D:BA35 mov CX,0x00C4
        CX = (ushort)0x00C4;
        // 100D:BA38 mov AX,word ptr DS:[0x2460]
        AX = UInt16[DS, (ushort)0x2460];
        // 100D:BA3B add AX,BX
        AX = Alu16.Add(AX, BX);
        // 100D:BA3D cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:BA3F jle short 0xBA55
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_BA55_1BB25_12440;
        }
    label_100D_BA41_1BB11_34889:
        CheckExternalEvents(cs1, 0xBA41);
        // 100D:BA41 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:BA43 add AL,BL
        AL = Alu8.Add(AL, BL);
        // 100D:BA45 add AL,BL
        AL = Alu8.Add(AL, BL);
    label_100D_BA47_1BB17_34893:
        CheckExternalEvents(cs1, 0xBA47);
        // 100D:BA47 dec AL
        AL = Alu8.Dec(AL);
        // 100D:BA49 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:BA4A cmp AL,BL
        Alu8.Sub(AL, BL);
        // 100D:BA4C jle short 0xBA50
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_BA50_1BB20_34900;
        }
    label_100D_BA4E_1BB1E_34897:
        CheckExternalEvents(cs1, 0xBA4E);
        // 100D:BA4E loop 0xBA47
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA47_1BB17_34893;
        }
    label_100D_BA50_1BB20_34900:
        CheckExternalEvents(cs1, 0xBA50);
        // 100D:BA50 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:BA52 mov AX,BX
        AX = BX;
        // 100D:BA54 dec CX
        CX = Alu16.Dec(CX);
    label_100D_BA55_1BB25_12440:
        CheckExternalEvents(cs1, 0xBA55);
        // 100D:BA55 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:BA56 dec AL
        AL = Alu8.Dec(AL);
        // 100D:BA58 js short 0xBA5C
        if (SignFlag)
        {
            goto label_100D_BA5C_1BB2C_12446;
        }
    label_100D_BA5A_1BB2A_12444:
        CheckExternalEvents(cs1, 0xBA5A);
        // 100D:BA5A loop 0xBA55
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA55_1BB25_12440;
        }
    label_100D_BA5C_1BB2C_12446:
        CheckExternalEvents(cs1, 0xBA5C);
        // 100D:BA5C dec CX
        CX = Alu16.Dec(CX);
        // 100D:BA5D jle short 0xBA74
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_BA74_1BB44_12467;
        }
    label_100D_BA5F_1BB2F_12449:
        CheckExternalEvents(cs1, 0xBA5F);
        // 100D:BA5F neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_BA61_1BB31_12451:
        CheckExternalEvents(cs1, 0xBA61);
        // 100D:BA61 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:BA62 inc AL
        AL = Alu8.Inc(AL);
        // 100D:BA64 cmp AL,BL
        Alu8.Sub(AL, BL);
        // 100D:BA66 jg short 0xBA6A
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_BA6A_1BB3A_12458;
        }
    label_100D_BA68_1BB38_12455:
        CheckExternalEvents(cs1, 0xBA68);
        // 100D:BA68 loop 0xBA61
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA61_1BB31_12451;
        }
    label_100D_BA6A_1BB3A_12458:
        CheckExternalEvents(cs1, 0xBA6A);
        // 100D:BA6A dec CX
        CX = Alu16.Dec(CX);
        // 100D:BA6B jle short 0xBA74
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_BA74_1BB44_12467;
        }
    label_100D_BA6D_1BB3D_12461:
        CheckExternalEvents(cs1, 0xBA6D);
        // 100D:BA6D neg AL
        AL = Alu8.Sub((byte)0x00, AL);
        CarryFlag = AL != (byte)0x00;
    label_100D_BA6F_1BB3F_12463:
        CheckExternalEvents(cs1, 0xBA6F);
        // 100D:BA6F inc AL
        AL = Alu8.Inc(AL);
        // 100D:BA71 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:BA72 loop 0xBA6F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_BA6F_1BB3F_12463;
        }
    label_100D_BA74_1BB44_12467:
        CheckExternalEvents(cs1, 0xBA74);
        // 100D:BA74 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_BAF1_1BBC1(int loadOffset)
    {
    label_100D_BAF1_1BBC1_12739:
        CheckExternalEvents(cs1, 0xBAF1);
        // 100D:BAF1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_BF7D_1C04D(int loadOffset)
    {
    label_100D_BF7D_1C04D_18955:
        CheckExternalEvents(cs1, 0xBF7D);
        // 100D:BF7D pop AX
        AX = Stack.Pop16();
        // 100D:BF7E pop DI
        DI = Stack.Pop16();
        // 100D:BF7F mov DX,AX
        DX = AX;
        // 100D:BF81 xchg AX,word ptr DS:[DI]
        ushort xchgOffset_100D_BF81_1C051 = DI;
        ushort temp_100D_BF81_1C051 = AX;
        AX = UInt16[DS, xchgOffset_100D_BF81_1C051];
        UInt16[DS, xchgOffset_100D_BF81_1C051] = unchecked((ushort)temp_100D_BF81_1C051);
        // 100D:BF83 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 100D:BF85 mov AL,3
        AL = (byte)0x03;
        // 100D:BF87 jne short 0xBF99
        if (!ZeroFlag)
        {
            goto label_100D_BF99_1C069_18963;
        }
    label_100D_BF89_1C059_18975:
        CheckExternalEvents(cs1, 0xBF89);
        // 100D:BF89 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:BF8C and AX,0xFFF0
        AX = Alu16.And(AX, (ushort)0xFFF0);
        // 100D:BF8F cmp word ptr DS:[0x115C],AX
        Alu16.Sub(UInt16[DS, (ushort)0x115C], AX);
        // 100D:BF93 je short 0xBFA2
        if (ZeroFlag)
        {
            goto label_100D_BFA2_1C072_18969;
        }
    label_100D_BF95_1C065_26743:
        CheckExternalEvents(cs1, 0xBF95);
        // 100D:BF95 mov AL,3
        AL = (byte)0x03;
        // 100D:BF97 jmp short 0xBF9F
        goto label_100D_BF9F_1C06F_18968;
    label_100D_BF99_1C069_18963:
        CheckExternalEvents(cs1, 0xBF99);
        // 100D:BF99 mov AL,2
        AL = (byte)0x02;
        // 100D:BF9B jb short 0xBF9F
        if (CarryFlag)
        {
            goto label_100D_BF9F_1C06F_18968;
        }
    label_100D_BF9D_1C06D_18966:
        CheckExternalEvents(cs1, 0xBF9D);
        // 100D:BF9D dec AL
        AL = Alu8.Dec(AL);
    label_100D_BF9F_1C06F_18968:
        CheckExternalEvents(cs1, 0xBF9F);
        // 100D:BF9F mov byte ptr SS:[BP],AL
        UInt8[SS, (ushort)(BP + (sbyte)0)] = AL;
    label_100D_BFA2_1C072_18969:
        CheckExternalEvents(cs1, 0xBFA2);
        // 100D:BFA2 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:BFA5 inc BP
        BP = Alu16.Inc(BP);
        // 100D:BFA6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C1A9_1C279(int loadOffset)
    {
    label_100D_C1A9_1C279_2979:
        CheckExternalEvents(cs1, 0xC1A9);
        // 100D:C1A9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C26A_1C33A(int loadOffset)
    {
    label_100D_C26A_1C33A_5837:
        CheckExternalEvents(cs1, 0xC26A);
        // 100D:C26A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C32E_1C3FE(int loadOffset)
    {
    label_100D_C32E_1C3FE_10112:
        CheckExternalEvents(cs1, 0xC32E);
        // 100D:C32E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C449_1C519(int loadOffset)
    {
    label_100D_C449_1C519_8074:
        CheckExternalEvents(cs1, 0xC449);
        // 100D:C449 push CX
        Stack.Push16(CX);
        // 100D:C44A mov CX,AX
        CX = AX;
        // 100D:C44C mov DX,word ptr DS:[SI]
        DX = UInt16[DS, SI];
        // 100D:C44E mov BX,word ptr DS:[SI+2]
        BX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:C451 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:C454 mov AX,word ptr DS:[SI+6]
        AX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:C457 sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 100D:C459 jbe short 0xC46D
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C459");
        }
    label_100D_C45B_1C52B_8082:
        CheckExternalEvents(cs1, 0xC45B);
        // 100D:C45B sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 100D:C45D jbe short 0xC46D
        if (CarryFlag || ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:C45D");
        }
    label_100D_C45F_1C52F_8085:
        CheckExternalEvents(cs1, 0xC45F);
        // 100D:C45F mov ES,word ptr DS:[0xDBD6]
        ES = UInt16[DS, (ushort)0xDBD6];
        // 100D:C463 push SI
        Stack.Push16(SI);
        // 100D:C464 push DS
        Stack.Push16(DS);
        // 100D:C465 mov SI,CX
        SI = CX;
        // 100D:C467 call far dword ptr DS:[0x38ED]
        ushort targetSegment_8090 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x38ED + (ushort)0x0002)]));
        ushort targetOffset_8090 = unchecked((ushort)(UInt16[DS, (ushort)0x38ED]));
        if (targetSegment_8090 == cs2 && targetOffset_8090 == 0x012A)
        {
            FarCall(cs1, 0xC46B, cs2, unknown_3358_012A_336AA);
            goto label_100D_C46B_1C53B_8113;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8090:X4}:{targetOffset_8090:X4} at 100D:C467");
    label_100D_C46B_1C53B_8113:
        CheckExternalEvents(cs1, 0xC46B);
        // 100D:C46B pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:C46C pop SI
        SI = Stack.Pop16();
        // 100D:C46D pop CX
        CX = Stack.Pop16();
        // 100D:C46E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C526_1C5F6(int loadOffset)
    {
    label_100D_C526_1C5F6_8275:
        CheckExternalEvents(cs1, 0xC526);
        // 100D:C526 cmp word ptr DS:[0x2570],0x1AD6
        Alu16.Sub(UInt16[DS, (ushort)0x2570], (ushort)0x1AD6);
        // 100D:C52C je short 0xC53D
        if (ZeroFlag)
        {
            goto label_100D_C53D_1C60D_8288;
        }
    label_100D_C52E_1C5FE_8278:
        CheckExternalEvents(cs1, 0xC52E);
        // 100D:C52E push DS
        Stack.Push16(DS);
        // 100D:C52F mov ES,word ptr DS:[0xDBD8]
        ES = UInt16[DS, (ushort)0xDBD8];
        // 100D:C533 mov DS,word ptr DS:[0xDBD6]
        DS = UInt16[DS, (ushort)0xDBD6];
        // 100D:C537 call far dword ptr SS:[0x38F5]
        ushort targetSegment_8282 = unchecked((ushort)(UInt16[SS, (ushort)((ushort)0x38F5 + (ushort)0x0002)]));
        ushort targetOffset_8282 = unchecked((ushort)(UInt16[SS, (ushort)0x38F5]));
        if (targetSegment_8282 == cs2 && targetOffset_8282 == 0x0130)
        {
            FarCall(cs1, 0xC53C, cs2, unknown_3358_0130_336B0);
            goto label_100D_C53C_1C60C_8286;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_8282:X4}:{targetOffset_8282:X4} at 100D:C537");
    label_100D_C53C_1C60C_8286:
        CheckExternalEvents(cs1, 0xC53C);
        // 100D:C53C pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_C53D_1C60D_8288:
        CheckExternalEvents(cs1, 0xC53D);
        // 100D:C53D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_C6AC_1C77C(int loadOffset)
    {
    entrydispatcher:
    label_100D_C6AC_1C77C_10711:
        CheckExternalEvents(cs1, 0xC6AC);
        // 100D:C6AC ret near
        return NearRet((ushort)0x0000);
    }
}
