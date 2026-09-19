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
    public virtual Action troop_icon_pick_script(int loadOffset)
    {
    label_100D_6770_16840_18274:
        CheckExternalEvents(cs1, 0x6770);
        // 100D:6770 test byte ptr DS:[SI+0x10],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:6774 jne short 0x678F
        if (!ZeroFlag)
        {
            goto label_100D_678F_1685F_18289;
        }
    label_100D_6776_16846_18277:
        CheckExternalEvents(cs1, 0x6776);
        // 100D:6776 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6779 test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:677D jne short 0x6792
        if (!ZeroFlag)
        {
            goto label_100D_6792_16862_23505;
        }
    label_100D_677F_1684F_18281:
        CheckExternalEvents(cs1, 0x677F);
        // 100D:677F or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6781 jns short 0x6792
        if (!SignFlag)
        {
            goto label_100D_6792_16862_23505;
        }
    label_100D_6783_16853_18284:
        CheckExternalEvents(cs1, 0x6783);
        // 100D:6783 mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6786 test byte ptr SS:[BP+0x0A],0x10
        Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)10)], (byte)0x10);
        // 100D:678A mov BP,0x181F
        BP = (ushort)0x181F;
        // 100D:678D jne short 0x6791
        if (!ZeroFlag)
        {
            goto label_100D_6791_16861_18291;
        }
    label_100D_678F_1685F_18289:
        CheckExternalEvents(cs1, 0x678F);
        // 100D:678F xor BP,BP
        BP = Alu16.Xor(BP, BP);
    label_100D_6791_16861_18291:
        CheckExternalEvents(cs1, 0x6791);
        // 100D:6791 ret near
        return NearRet((ushort)0x0000);
    label_100D_6792_16862_23505:
        CheckExternalEvents(cs1, 0x6792);
        // 100D:6792 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:6794 je short 0x6799
        if (ZeroFlag)
        {
            goto label_100D_6799_16869_23508;
        }
    label_100D_6796_16866_29554:
        CheckExternalEvents(cs1, 0x6796);
        // 100D:6796 jmp near 0x6827
        return troop_icon_pick_script_moving(0x0000);
    label_100D_6799_16869_23508:
        CheckExternalEvents(cs1, 0x6799);
        // 100D:6799 test AL,0x30
        Alu8.And(AL, (byte)0x30);
        // 100D:679B je short 0x67C5
        if (ZeroFlag)
        {
            goto label_100D_67C5_16895_23511;
        }
    label_100D_679D_1686D_28123:
        CheckExternalEvents(cs1, 0x679D);
        // 100D:679D and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:67A0 mov BP,AX
        BP = AX;
        // 100D:67A2 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:67A4 mov BP,word ptr SS:[BP+0x16B6]
        BP = UInt16[SS, (ushort)(BP + (short)5814)];
        // 100D:67A8 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:67AA jne short 0x67C4
        if (!ZeroFlag)
        {
            goto label_100D_67C4_16894_28134;
        }
    label_100D_67AC_1687C_28130:
        CheckExternalEvents(cs1, 0x67AC);
        // 100D:67AC mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:67AF and AL,0xC0
        AL = Alu8.And(AL, (byte)0xC0);
        // 100D:67B1 je short 0x67C4
        if (ZeroFlag)
        {
            goto label_100D_67C4_16894_28134;
        }
    label_100D_67B3_16883_33384:
        CheckExternalEvents(cs1, 0x67B3);
        // 100D:67B3 mov BP,0x1813
        BP = (ushort)0x1813;
        // 100D:67B6 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:67B8 je short 0x67C4
        if (ZeroFlag)
        {
            goto label_100D_67C4_16894_28134;
        }
    label_100D_67BA_1688A_34860:
        CheckExternalEvents(cs1, 0x67BA);
        // 100D:67BA mov BP,0x1817
        BP = (ushort)0x1817;
        // 100D:67BD cmp AL,0x40
        Alu8.Sub(AL, (byte)0x40);
        // 100D:67BF je short 0x67C4
        if (ZeroFlag)
        {
            goto label_100D_67C4_16894_28134;
        }
    label_100D_67C1_16891_34864:
        CheckExternalEvents(cs1, 0x67C1);
        // 100D:67C1 mov BP,0x181B
        BP = (ushort)0x181B;
    label_100D_67C4_16894_28134:
        CheckExternalEvents(cs1, 0x67C4);
        // 100D:67C4 ret near
        return NearRet((ushort)0x0000);
    label_100D_67C5_16895_23511:
        CheckExternalEvents(cs1, 0x67C5);
        // 100D:67C5 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:67C8 je short 0x680A
        if (ZeroFlag)
        {
            goto label_100D_680A_168DA_24647;
        }
    label_100D_67CA_1689A_23514:
        CheckExternalEvents(cs1, 0x67CA);
        // 100D:67CA mov BP,AX
        BP = AX;
        // 100D:67CC shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:67CE mov BP,word ptr SS:[BP+0x179C]
        BP = UInt16[SS, (ushort)(BP + (short)6044)];
        // 100D:67D2 cmp BP,0x1774
        Alu16.Sub(BP, (ushort)0x1774);
        // 100D:67D6 je short 0x67ED
        if (ZeroFlag)
        {
            goto label_100D_67ED_168BD_35837;
        }
    label_100D_67D8_168A8_23520:
        CheckExternalEvents(cs1, 0x67D8);
        // 100D:67D8 cmp BP,0x1732
        Alu16.Sub(BP, (ushort)0x1732);
        // 100D:67DC jne short 0x6791
        if (!ZeroFlag)
        {
            goto label_100D_6791_16861_18291;
        }
    label_100D_67DE_168AE_35832:
        CheckExternalEvents(cs1, 0x67DE);
        // 100D:67DE mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:67E1 test byte ptr SS:[BP+0x0A],2
        Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)10)], (byte)0x02);
        // 100D:67E5 mov BP,0x16AA
        BP = (ushort)0x16AA;
        // 100D:67E8 jne short 0x6791
        if (!ZeroFlag)
        {
            goto label_100D_6791_16861_18291;
        }
    label_100D_67EA_168BA_36120:
        CheckExternalEvents(cs1, 0x67EA);
        // 100D:67EA mov BP,0x1732
        BP = (ushort)0x1732;
    label_100D_67ED_168BD_35837:
        CheckExternalEvents(cs1, 0x67ED);
        // 100D:67ED mov AL,byte ptr DS:[SI+2]
        AL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:67F0 dec AL
        AL = Alu8.Dec(AL);
        // 100D:67F2 and AL,7
        AL = Alu8.And(AL, (byte)0x07);
        // 100D:67F4 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:67F6 jb short 0x6809
        if (CarryFlag)
        {
            goto label_100D_6809_168D9_35843;
        }
    label_100D_67F8_168C8_36931:
        CheckExternalEvents(cs1, 0x67F8);
        // 100D:67F8 add BP,0x000A
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:67FB cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:67FD je short 0x6809
        if (ZeroFlag)
        {
            goto label_100D_6809_168D9_35843;
        }
    label_100D_67FF_168CF_37109:
        CheckExternalEvents(cs1, 0x67FF);
        // 100D:67FF add BP,0x000A
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:6802 cmp AL,4
        Alu8.Sub(AL, (byte)0x04);
        // 100D:6804 je short 0x6809
        if (ZeroFlag)
        {
            goto label_100D_6809_168D9_35843;
        }
    label_100D_6806_168D6_37114:
        CheckExternalEvents(cs1, 0x6806);
        // 100D:6806 add BP,0x000A
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)10)));
    label_100D_6809_168D9_35843:
        CheckExternalEvents(cs1, 0x6809);
        // 100D:6809 ret near
        return NearRet((ushort)0x0000);
    label_100D_680A_168DA_24647:
        CheckExternalEvents(cs1, 0x680A);
        // 100D:680A test byte ptr DS:[SI+0x19],0xC0
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0xC0);
        // 100D:680E je short 0x67CA
        if (ZeroFlag)
        {
            goto label_100D_67CA_1689A_23514;
        }
    label_100D_6810_168E0_27797:
        CheckExternalEvents(cs1, 0x6810);
        // 100D:6810 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:6813 and AL,0xC0
        AL = Alu8.And(AL, (byte)0xC0);
        // 100D:6815 mov BP,0x17BC
        BP = (ushort)0x17BC;
        // 100D:6818 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:681A je short 0x6826
        if (ZeroFlag)
        {
            goto label_100D_6826_168F6_27803;
        }
    label_100D_681C_168EC_33753:
        CheckExternalEvents(cs1, 0x681C);
        // 100D:681C mov BP,0x17C9
        BP = (ushort)0x17C9;
        // 100D:681F cmp AL,0x40
        Alu8.Sub(AL, (byte)0x40);
        // 100D:6821 je short 0x6826
        if (ZeroFlag)
        {
            goto label_100D_6826_168F6_27803;
        }
    label_100D_6823_168F3_33757:
        CheckExternalEvents(cs1, 0x6823);
        // 100D:6823 mov BP,0x1806
        BP = (ushort)0x1806;
    label_100D_6826_168F6_27803:
        CheckExternalEvents(cs1, 0x6826);
        // 100D:6826 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_icon_pick_script_moving(int loadOffset)
    {
    label_100D_6827_168F7_29556:
        CheckExternalEvents(cs1, 0x6827);
        // 100D:6827 push BX
        Stack.Push16(BX);
        // 100D:6828 push DX
        Stack.Push16(DX);
        // 100D:6829 push DI
        Stack.Push16(DI);
        // 100D:682A mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:682D mov AX,word ptr DS:[DI+2]
        AX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:6830 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:6833 sub AX,word ptr DS:[SI+6]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:6836 mov AL,AH
        AL = AH;
        // 100D:6838 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:6839 mov DX,AX
        DX = AX;
        // 100D:683B mov DI,DX
        DI = DX;
        // 100D:683D jns short 0x6841
        if (!SignFlag)
        {
            goto label_100D_6841_16911_29569;
        }
    label_100D_683F_1690F_30954:
        CheckExternalEvents(cs1, 0x683F);
        // 100D:683F neg DI
        DI = Alu16.Sub((ushort)0x0000, DI);
        CarryFlag = DI != (ushort)0x0000;
    label_100D_6841_16911_29569:
        CheckExternalEvents(cs1, 0x6841);
        // 100D:6841 sub BX,word ptr DS:[SI+8]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)8)]);
        // 100D:6844 mov CX,BX
        CX = BX;
        // 100D:6846 jns short 0x684A
        if (!SignFlag)
        {
            goto label_100D_684A_1691A_29575;
        }
    label_100D_6848_16918_29573:
        CheckExternalEvents(cs1, 0x6848);
        // 100D:6848 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_100D_684A_1691A_29575:
        CheckExternalEvents(cs1, 0x684A);
        // 100D:684A mov BP,2
        BP = (ushort)0x0002;
        // 100D:684D cmp DI,CX
        Alu16.Sub(DI, CX);
        // 100D:684F jb short 0x6854
        if (CarryFlag)
        {
            goto label_100D_6854_16924_29578;
        }
    label_100D_6851_16921_30957:
        CheckExternalEvents(cs1, 0x6851);
        // 100D:6851 dec BP
        BP = Alu16.Dec(BP);
        // 100D:6852 xchg DX,BX
        ushort temp_100D_6852_16922 = DX;
        DX = BX;
        BX = unchecked((ushort)temp_100D_6852_16922);
    label_100D_6854_16924_29578:
        CheckExternalEvents(cs1, 0x6854);
        // 100D:6854 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:6856 jns short 0x685B
        if (!SignFlag)
        {
            goto label_100D_685B_1692B_29583;
        }
    label_100D_6858_16928_29581:
        CheckExternalEvents(cs1, 0x6858);
        // 100D:6858 xor BP,2
        BP = Alu16.Xor(BP, unchecked((ushort)unchecked((short)(sbyte)2)));
    label_100D_685B_1692B_29583:
        CheckExternalEvents(cs1, 0x685B);
        // 100D:685B call near 0x693B
        NearCall(cs1, 0x685E, troop_get_occupation_bits_2_and_3);
    label_100D_685E_1692E_29584:
        CheckExternalEvents(cs1, 0x685E);
        // 100D:685E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:6860 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:6862 add BP,AX
        BP = Alu16.Add(BP, AX);
        // 100D:6864 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:6866 mov BP,word ptr SS:[BP+0x18BF]
        BP = UInt16[SS, (ushort)(BP + (short)6335)];
        // 100D:686A pop DI
        DI = Stack.Pop16();
        // 100D:686B pop DX
        DX = Stack.Pop16();
        // 100D:686C pop BX
        BX = Stack.Pop16();
        // 100D:686D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_icon_screen_pos(int loadOffset)
    {
    label_100D_686E_1693E_18239:
        CheckExternalEvents(cs1, 0x686E);
        // 100D:686E cmp byte ptr DS:[0x46EB],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:6873 jb short 0x68AE
        if (CarryFlag)
        {
            goto label_100D_68AE_1697E_18269;
        }
    label_100D_6875_16945_18242:
        CheckExternalEvents(cs1, 0x6875);
        // 100D:6875 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:6879 jne short 0x68AF
        if (!ZeroFlag)
        {
            goto label_100D_68AF_1697F_29535;
        }
    label_100D_687B_1694B_18245:
        CheckExternalEvents(cs1, 0x687B);
        // 100D:687B mov BL,byte ptr DS:[SI+2]
        BL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:687E dec BX
        BX = Alu16.Dec(BX);
        // 100D:687F push DI
        Stack.Push16(DI);
        // 100D:6880 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6883 test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:6887 je short 0x688C
        if (ZeroFlag)
        {
            goto label_100D_688C_1695C_18252;
        }
    label_100D_6889_16959_35830:
        CheckExternalEvents(cs1, 0x6889);
        // 100D:6889 xor BL,8
        BL = Alu8.Xor(BL, (byte)0x08);
    label_100D_688C_1695C_18252:
        CheckExternalEvents(cs1, 0x688C);
        // 100D:688C pop DI
        DI = Stack.Pop16();
        // 100D:688D and BX,0x000F
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:6890 add BX,BX
        BX = Alu16.Add(BX, BX);
        // 100D:6892 mov AL,byte ptr DS:[BX+0x1672]
        AL = UInt8[DS, (ushort)(BX + (short)5746)];
        // 100D:6896 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:6897 mov DX,AX
        DX = AX;
        // 100D:6899 mov AL,byte ptr DS:[BX+0x1673]
        AL = UInt8[DS, (ushort)(BX + (short)5747)];
        // 100D:689D cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:689E add DX,word ptr SS:[BP+2]
        DX = Alu16.Add(DX, UInt16[SS, (ushort)(BP + (sbyte)2)]);
        // 100D:68A1 mov BX,word ptr SS:[BP+4]
        BX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 100D:68A4 cmp BH,0x80
        Alu8.Sub(BH, (byte)0x80);
        // 100D:68A7 jb short 0x68AE
        if (CarryFlag)
        {
            goto label_100D_68AE_1697E_18269;
        }
    label_100D_68A9_16979_18265:
        CheckExternalEvents(cs1, 0x68A9);
        // 100D:68A9 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:68AB add BX,AX
        BX = Alu16.Add(BX, AX);
        // 100D:68AD clc
        CarryFlag = false;
    label_100D_68AE_1697E_18269:
        CheckExternalEvents(cs1, 0x68AE);
        // 100D:68AE ret near
        return NearRet((ushort)0x0000);
    label_100D_68AF_1697F_29535:
        CheckExternalEvents(cs1, 0x68AF);
        // 100D:68AF mov DX,word ptr DS:[SI+6]
        DX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:68B2 mov BX,word ptr DS:[SI+8]
        BX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:68B5 call near 0xB647
        NearCall(cs1, 0x68B8, map_position_to_screen);
    label_100D_68B8_16988_29539:
        CheckExternalEvents(cs1, 0x68B8);
        // 100D:68B8 cmp DX,-16
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:68BB jle short 0x68D0
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_68D0_169A0_30972;
        }
    label_100D_68BD_1698D_29542:
        CheckExternalEvents(cs1, 0x68BD);
        // 100D:68BD cmp BX,-16
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 100D:68C0 jle short 0x68D0
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_100D_68D0_169A0_30972;
        }
    label_100D_68C2_16992_29545:
        CheckExternalEvents(cs1, 0x68C2);
        // 100D:68C2 cmp DX,0x0148
        Alu16.Sub(DX, (ushort)0x0148);
        // 100D:68C6 jge short 0x68D0
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_68D0_169A0_30972;
        }
    label_100D_68C8_16998_29548:
        CheckExternalEvents(cs1, 0x68C8);
        // 100D:68C8 cmp BX,0x00A0
        Alu16.Sub(BX, (ushort)0x00A0);
        // 100D:68CC jge short 0x68D0
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_68D0_169A0_30972;
        }
    label_100D_68CE_1699E_29551:
        CheckExternalEvents(cs1, 0x68CE);
        // 100D:68CE clc
        CarryFlag = false;
        // 100D:68CF ret near
        return NearRet((ushort)0x0000);
    label_100D_68D0_169A0_30972:
        CheckExternalEvents(cs1, 0x68D0);
        // 100D:68D0 stc
        CarryFlag = true;
        // 100D:68D1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_68D2_169A2(int loadOffset)
    {
    entrydispatcher:
    label_100D_68D2_169A2_35512:
        CheckExternalEvents(cs1, 0x68D2);
        // 100D:68D2 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:68D4 mov BP,0x68DA
        BP = (ushort)0x68DA;
        // 100D:68D7 jmp near 0x6603
        if (JumpDispatcher.Jump(for_each_troop_in_location, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_68DA_169AA(int loadOffset)
    {
    entrydispatcher:
    label_100D_68DA_169AA_35516:
        CheckExternalEvents(cs1, 0x68DA);
        // 100D:68DA test byte ptr DS:[SI+0x10],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:68DE je short 0x68EA
        if (ZeroFlag)
        {
            return unknown_100D_68EA_169BA(0x0000);
        }
        else
        {
            if (JumpDispatcher.Jump(unknown_100D_68E0_169B0, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action contact_verb_troop(int loadOffset)
    {
    label_100D_68EB_169BB_23461:
        CheckExternalEvents(cs1, 0x68EB);
        // 100D:68EB mov AL,byte ptr DS:[0x1954]
        AL = UInt8[DS, (ushort)0x1954];
        // 100D:68EE cmp byte ptr DS:[0x46EB],0x80
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x80);
        // 100D:68F3 jae short 0x6906
        if (!CarryFlag)
        {
            return unknown_100D_6906_169D6(0x0000);
        }
    label_100D_68F5_169C5_23465:
        CheckExternalEvents(cs1, 0x68F5);
        // 100D:68F5 mov AL,byte ptr DS:[0x476C]
        AL = UInt8[DS, (ushort)0x476C];
        // 100D:68F8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:68FA add AX,AX
        AX = Alu16.Add(AX, AX);
        // 100D:68FC mov SI,AX
        SI = AX;
        // 100D:68FE mov SI,word ptr DS:[SI+0x4758]
        SI = UInt16[DS, (ushort)(SI + (short)18264)];
        // 100D:6902 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:6904 jmp short 0x6912
        return unknown_100D_6912_169E2(0x0000);
    }

    public virtual Action unknown_100D_6906_169D6(int loadOffset)
    {
    label_100D_6906_169D6_3087:
        CheckExternalEvents(cs1, 0x6906);
        // 100D:6906 mov SI,AX
        SI = AX;
        // 100D:6908 dec AL
        AL = Alu8.Dec(AL);
        // 100D:690A mov AH,0x1B
        AH = (byte)0x1B;
        // 100D:690C mul AH
        ushort result_100D_690C_169DC = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_690C_169DC >> 8));
        AL = unchecked((byte)result_100D_690C_169DC);
        // 100D:690E add AX,0x08AA
        AX = Alu16.Add(AX, (ushort)0x08AA);
        // 100D:6911 xchg SI,AX
        ushort temp_100D_6911_169E1 = SI;
        SI = AX;
        AX = unchecked((ushort)temp_100D_6911_169E1);
        return unknown_100D_6912_169E2(0x0000);
    }

    public virtual Action troop_find_icon(int loadOffset)
    {
    label_100D_6917_169E7_23624:
        CheckExternalEvents(cs1, 0x6917);
        // 100D:6917 cmp byte ptr DS:[0x46EB],0
        Alu8.Sub(UInt8[DS, (ushort)0x46EB], (byte)0x00);
        // 100D:691C mov DI,0x3CAF
        DI = (ushort)0x3CAF;
        // 100D:691F jns short 0x6938
        if (!SignFlag)
        {
            goto label_100D_6938_16A08_29759;
        }
    label_100D_6921_169F1_23628:
        CheckExternalEvents(cs1, 0x6921);
        // 100D:6921 mov CX,word ptr DS:[0x3CBE]
        CX = UInt16[DS, (ushort)0x3CBE];
    label_100D_6925_169F5_23630:
        CheckExternalEvents(cs1, 0x6925);
        // 100D:6925 jcxz short 0x6938
        if (CX == (ushort)0x0000)
        {
            goto label_100D_6938_16A08_29759;
        }
    label_100D_6927_169F7_23631:
        CheckExternalEvents(cs1, 0x6927);
        // 100D:6927 add DI,0x0011
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:692A cmp word ptr DS:[DI+0x0A],SI
        Alu16.Sub(UInt16[DS, (ushort)(DI + (sbyte)10)], SI);
        // 100D:692D loopne 0x6927
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_100D_6927_169F7_23631;
        }
    label_100D_692F_169FF_23635:
        CheckExternalEvents(cs1, 0x692F);
        // 100D:692F jne short 0x6937
        if (!ZeroFlag)
        {
            goto label_100D_6937_16A07_23640;
        }
    label_100D_6931_16A01_23637:
        CheckExternalEvents(cs1, 0x6931);
        // 100D:6931 test byte ptr DS:[DI+0x0C],0x40
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x40);
        // 100D:6935 jne short 0x6925
        if (!ZeroFlag)
        {
            goto label_100D_6925_169F5_23630;
        }
    label_100D_6937_16A07_23640:
        CheckExternalEvents(cs1, 0x6937);
        // 100D:6937 ret near
        return NearRet((ushort)0x0000);
    label_100D_6938_16A08_29759:
        CheckExternalEvents(cs1, 0x6938);
        // 100D:6938 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:693A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_get_occupation_bits_2_and_3(int loadOffset)
    {
    label_100D_693B_16A0B_23012:
        CheckExternalEvents(cs1, 0x693B);
        // 100D:693B mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:693E and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:6941 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:6943 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:6945 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_icon_hit_test(int loadOffset)
    {
    label_100D_6946_16A16_26228:
        CheckExternalEvents(cs1, 0x6946);
        // 100D:6946 mov SI,0x3CBE
        SI = (ushort)0x3CBE;
        // 100D:6949 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:694A mov CX,AX
        CX = AX;
        // 100D:694C jcxz short 0x6972
        if (CX == (ushort)0x0000)
        {
            goto label_100D_6972_16A42_26255;
        }
    label_100D_694E_16A1E_26233:
        CheckExternalEvents(cs1, 0x694E);
        // 100D:694E mov AL,0x11
        AL = (byte)0x11;
        // 100D:6950 mul CL
        ushort result_100D_6950_16A20 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)CL)));
        AH = unchecked((byte)(result_100D_6950_16A20 >> 8));
        AL = unchecked((byte)result_100D_6950_16A20);
        // 100D:6952 add SI,AX
        SI = Alu16.Add(SI, AX);
    label_100D_6954_16A24_26237:
        CheckExternalEvents(cs1, 0x6954);
        // 100D:6954 sub SI,0x0011
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:6957 cmp word ptr DS:[SI],DX
        Alu16.Sub(UInt16[DS, SI], DX);
        // 100D:6959 jge short 0x6970
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_6970_16A40_26252;
        }
    label_100D_695B_16A2B_26240:
        CheckExternalEvents(cs1, 0x695B);
        // 100D:695B cmp word ptr DS:[SI+2],BX
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)2)], BX);
        // 100D:695E jge short 0x6970
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_6970_16A40_26252;
        }
    label_100D_6960_16A30_26243:
        CheckExternalEvents(cs1, 0x6960);
        // 100D:6960 cmp DX,word ptr DS:[SI+4]
        Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:6963 jge short 0x6970
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_6970_16A40_26252;
        }
    label_100D_6965_16A35_26246:
        CheckExternalEvents(cs1, 0x6965);
        // 100D:6965 test byte ptr DS:[SI+0x0C],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)12)], (byte)0x40);
        // 100D:6969 jne short 0x6970
        if (!ZeroFlag)
        {
            goto label_100D_6970_16A40_26252;
        }
    label_100D_696B_16A3B_26249:
        CheckExternalEvents(cs1, 0x696B);
        // 100D:696B cmp BX,word ptr DS:[SI+6]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:696E jl short 0x6974
        if (SignFlag != OverflowFlag)
        {
            goto label_100D_6974_16A44_29961;
        }
    label_100D_6970_16A40_26252:
        CheckExternalEvents(cs1, 0x6970);
        // 100D:6970 loop 0x6954
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6954_16A24_26237;
        }
    label_100D_6972_16A42_26255:
        CheckExternalEvents(cs1, 0x6972);
        // 100D:6972 clc
        CarryFlag = false;
        // 100D:6973 ret near
        return NearRet((ushort)0x0000);
    label_100D_6974_16A44_29961:
        CheckExternalEvents(cs1, 0x6974);
        // 100D:6974 mov DI,word ptr DS:[SI+0x0A]
        DI = UInt16[DS, (ushort)(SI + (sbyte)10)];
        // 100D:6977 cmp byte ptr DS:[DI+3],0x80
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)3)], (byte)0x80);
        // 100D:697B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_focus_troop_icon(int loadOffset)
    {
    label_100D_697C_16A4C_23622:
        CheckExternalEvents(cs1, 0x697C);
        // 100D:697C call near 0x6917
        NearCall(cs1, 0x697F, troop_find_icon);
    label_100D_697F_16A4F_23642:
        CheckExternalEvents(cs1, 0x697F);
        // 100D:697F jne short 0x69A2
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:697F");
        }
    label_100D_6981_16A51_23644:
        CheckExternalEvents(cs1, 0x6981);
        // 100D:6981 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:6985 jne short 0x698F
        if (!ZeroFlag)
        {
            goto label_100D_698F_16A5F_23664;
        }
    label_100D_6987_16A57_23647:
        CheckExternalEvents(cs1, 0x6987);
        // 100D:6987 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:698A call near 0x5ED0
        NearCall(cs1, 0x698D, unknown_100D_5ED0_15FA0);
    label_100D_698D_16A5D_23662:
        CheckExternalEvents(cs1, 0x698D);
        // 100D:698D jne short 0x69A2
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:698D");
        }
    label_100D_698F_16A5F_23664:
        CheckExternalEvents(cs1, 0x698F);
        // 100D:698F call near 0x686E
        NearCall(cs1, 0x6992, troop_icon_screen_pos);
    label_100D_6992_16A62_23666:
        CheckExternalEvents(cs1, 0x6992);
        // 100D:6992 jb short 0x69A2
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6992");
        }
    label_100D_6994_16A64_23668:
        CheckExternalEvents(cs1, 0x6994);
        // 100D:6994 mov BP,0x18FD
        BP = (ushort)0x18FD;
        // 100D:6997 call near 0xC5CF
        NearCall(cs1, 0x699A, troop_icon_spawn_with_anim);
    label_100D_699A_16A6A_23729:
        CheckExternalEvents(cs1, 0x699A);
        // 100D:699A or byte ptr DS:[DI+0x0C],0x40
        UInt8[DS, (ushort)(DI + (sbyte)12)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x40);
        // 100D:699E mov word ptr DS:[0x4752],DI
        UInt16[DS, (ushort)0x4752] = DI;
        // 100D:69A2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action map_remove_focused_troop_icon(int loadOffset)
    {
    label_100D_69A3_16A73_23578:
        CheckExternalEvents(cs1, 0x69A3);
        // 100D:69A3 push DI
        Stack.Push16(DI);
        // 100D:69A4 xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:69A6 xchg DI,word ptr DS:[0x4752]
        ushort xchgOffset_100D_69A6_16A76 = (ushort)0x4752;
        ushort temp_100D_69A6_16A76 = DI;
        DI = UInt16[DS, xchgOffset_100D_69A6_16A76];
        UInt16[DS, xchgOffset_100D_69A6_16A76] = unchecked((ushort)temp_100D_69A6_16A76);
        // 100D:69AA or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:69AC je short 0x69B1
        if (ZeroFlag)
        {
            goto label_100D_69B1_16A81_23584;
        }
    label_100D_69AE_16A7E_24988:
        CheckExternalEvents(cs1, 0x69AE);
        // 100D:69AE call near 0xC58A
        NearCall(cs1, 0x69B1, unknown_100D_C58A_1C65A);
    label_100D_69B1_16A81_23584:
        CheckExternalEvents(cs1, 0x69B1);
        // 100D:69B1 pop DI
        DI = Stack.Pop16();
        // 100D:69B2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6A33_16B03(int loadOffset)
    {
    entrydispatcher:
    label_100D_6A33_16B03_31308:
        CheckExternalEvents(cs1, 0x6A33);
        // 100D:6A33 mov AL,3
        AL = (byte)0x03;
        if (JumpDispatcher.Jump(troop_occupation_within_class, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_occupation_within_class(int loadOffset)
    {
    entrydispatcher:
    label_100D_6A35_16B05_31310:
        CheckExternalEvents(cs1, 0x6A35);
        // 100D:6A35 push AX
        Stack.Push16(AX);
        // 100D:6A36 call near 0x68EB
        NearCall(cs1, 0x6A39, contact_verb_troop);
    label_100D_6A39_16B09_31312:
        CheckExternalEvents(cs1, 0x6A39);
        // 100D:6A39 pop AX
        AX = Stack.Pop16();
        // 100D:6A3A mov CL,byte ptr DS:[SI+3]
        CL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6A3D and CL,0x0C
        CL = Alu8.And(CL, (byte)0x0C);
        // 100D:6A40 or CL,AL
        CL = Alu8.Or(CL, AL);
        // 100D:6A42 jmp short 0x6A89
        if (JumpDispatcher.Jump(troop_occupation_verb_apply, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_occupation_verb_apply(int loadOffset)
    {
    entrydispatcher:
    label_100D_6A89_16B59_24560:
        CheckExternalEvents(cs1, 0x6A89);
        // 100D:6A89 call near 0x68EB
        NearCall(cs1, 0x6A8C, contact_verb_troop);
    label_100D_6A8C_16B5C_24562:
        CheckExternalEvents(cs1, 0x6A8C);
        // 100D:6A8C mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6A8F and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:6A91 cmp AL,CL
        Alu8.Sub(AL, CL);
        // 100D:6A93 je short 0x6AB5
        if (ZeroFlag)
        {
            goto label_100D_6AB5_16B85_24762;
        }
    label_100D_6A95_16B65_24567:
        CheckExternalEvents(cs1, 0x6A95);
        // 100D:6A95 push word ptr DS:[SI+3]
        Stack.Push16(UInt16[DS, (ushort)(SI + (sbyte)3)]);
        // 100D:6A98 push SI
        Stack.Push16(SI);
        // 100D:6A99 push word ptr DS:[SI+0x12]
        Stack.Push16(UInt16[DS, (ushort)(SI + (sbyte)18)]);
        // 100D:6A9C call near 0x6ACB
        NearCall(cs1, 0x6A9F, troop_set_occupation);
    label_100D_6A9F_16B6F_24687:
        CheckExternalEvents(cs1, 0x6A9F);
        // 100D:6A9F call near 0xA1C4
        NearCall(cs1, 0x6AA2, unknown_100D_A1C4_1A294);
    label_100D_6AA2_16B72_24689:
        CheckExternalEvents(cs1, 0x6AA2);
        // 100D:6AA2 mov AL,0x0A
        AL = (byte)0x0A;
        // 100D:6AA4 call near 0x7BB9
        NearCall(cs1, 0x6AA7, map_present_troop_reaction_line);
    label_100D_6AA7_16B77_24750:
        CheckExternalEvents(cs1, 0x6AA7);
        // 100D:6AA7 call near 0xA1E2
        NearCall(cs1, 0x6AAA, unknown_100D_A1E2_1A2B2);
    label_100D_6AAA_16B7A_24752:
        CheckExternalEvents(cs1, 0x6AAA);
        // 100D:6AAA pop AX
        AX = Stack.Pop16();
        // 100D:6AAB pop SI
        SI = Stack.Pop16();
        // 100D:6AAC pop CX
        CX = Stack.Pop16();
        // 100D:6AAD je short 0x6AB8
        if (ZeroFlag)
        {
            goto label_100D_6AB8_16B88_24757;
        }
    label_100D_6AAF_16B7F_24781:
        CheckExternalEvents(cs1, 0x6AAF);
        // 100D:6AAF mov word ptr DS:[SI+0x12],AX
        UInt16[DS, (ushort)(SI + (sbyte)18)] = AX;
        // 100D:6AB2 call near 0x6ACB
        NearCall(cs1, 0x6AB5, troop_set_occupation);
    label_100D_6AB5_16B85_24762:
        CheckExternalEvents(cs1, 0x6AB5);
        // 100D:6AB5 jmp near 0xD2E2
        if (JumpDispatcher.Jump(menu_callback_choice_exit_menu, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_6AB8_16B88_24757:
        CheckExternalEvents(cs1, 0x6AB8);
        // 100D:6AB8 call near 0x693B
        NearCall(cs1, 0x6ABB, troop_get_occupation_bits_2_and_3);
    label_100D_6ABB_16B8B_24759:
        CheckExternalEvents(cs1, 0x6ABB);
        // 100D:6ABB or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6ABD je short 0x6AB5
        if (ZeroFlag)
        {
            goto label_100D_6AB5_16B85_24762;
        }
    label_100D_6ABF_16B8F_33513:
        CheckExternalEvents(cs1, 0x6ABF);
        // 100D:6ABF and byte ptr DS:[SI+0x19],0x7F
        UInt8[DS, (ushort)(SI + (sbyte)25)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x7F);
        // 100D:6AC3 jmp short 0x6AB5
        goto label_100D_6AB5_16B85_24762;
    }

    public virtual Action unknown_100D_6AC5_16B95(int loadOffset)
    {
    entrydispatcher:
    label_100D_6AC5_16B95_35584:
        CheckExternalEvents(cs1, 0x6AC5);
        // 100D:6AC5 mov CL,byte ptr DS:[SI+3]
        CL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6AC8 and CL,0xFC
        CL = Alu8.And(CL, (byte)0xFC);
        if (JumpDispatcher.Jump(troop_set_occupation, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_set_occupation(int loadOffset)
    {
    entrydispatcher:
    label_100D_6ACB_16B9B_24572:
        CheckExternalEvents(cs1, 0x6ACB);
        // 100D:6ACB mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6ACE and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:6AD0 cmp AL,CL
        Alu8.Sub(AL, CL);
        // 100D:6AD2 je short 0x6B24
        if (ZeroFlag)
        {
            return unknown_100D_6B24_16BF4(0x0000);
        }
        else
        {
            if (JumpDispatcher.Jump(troop_reinit_occupation, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action troop_reinit_occupation(int loadOffset)
    {
    entrydispatcher:
    label_100D_6AD4_16BA4_24577:
        CheckExternalEvents(cs1, 0x6AD4);
        // 100D:6AD4 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6AD7 cmp CL,8
        Alu8.Sub(CL, (byte)0x08);
        // 100D:6ADA jne short 0x6AEA
        if (!ZeroFlag)
        {
            goto label_100D_6AEA_16BBA_24581;
        }
    label_100D_6ADC_16BAC_39688:
        CheckExternalEvents(cs1, 0x6ADC);
        // 100D:6ADC cmp DI,0x07C8
        Alu16.Sub(DI, (ushort)0x07C8);
        // 100D:6AE0 jne short 0x6AEA
        if (!ZeroFlag)
        {
            goto label_100D_6AEA_16BBA_24581;
        }
    label_100D_6AE2_16BB2_39692:
        CheckExternalEvents(cs1, 0x6AE2);
        // 100D:6AE2 cmp byte ptr DS:[DI+0x1A],0
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)26)], (byte)0x00);
        // 100D:6AE6 jne short 0x6AEA
        if (!ZeroFlag)
        {
            goto label_100D_6AEA_16BBA_24581;
        }
    label_100D_6AE8_16BB8_39696:
        CheckExternalEvents(cs1, 0x6AE8);
        // 100D:6AE8 mov CL,0x0A
        CL = (byte)0x0A;
    label_100D_6AEA_16BBA_24581:
        CheckExternalEvents(cs1, 0x6AEA);
        // 100D:6AEA mov byte ptr DS:[SI+3],CL
        UInt8[DS, (ushort)(SI + (sbyte)3)] = CL;
        // 100D:6AED and byte ptr DS:[SI+0x12],0xCF
        UInt8[DS, (ushort)(SI + (sbyte)18)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)18)], (byte)0xCF);
        // 100D:6AF1 and word ptr DS:[SI+0x10],0xFEFF
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0xFEFF);
        // 100D:6AF6 call near 0x6C15
        NearCall(cs1, 0x6AF9, troop_occupation_not_viable);
    label_100D_6AF9_16BC9_24620:
        CheckExternalEvents(cs1, 0x6AF9);
        // 100D:6AF9 jb short 0x6B00
        if (CarryFlag)
        {
            goto label_100D_6B00_16BD0_24624;
        }
    label_100D_6AFB_16BCB_24622:
        CheckExternalEvents(cs1, 0x6AFB);
        // 100D:6AFB or word ptr DS:[SI+0x10],0x0100
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0100);
    label_100D_6B00_16BD0_24624:
        CheckExternalEvents(cs1, 0x6B00);
        // 100D:6B00 call near 0x8461
        NearCall(cs1, 0x6B03, troop_refresh_icon);
    label_100D_6B03_16BD3_24660:
        CheckExternalEvents(cs1, 0x6B03);
        // 100D:6B03 call near 0x6B25
        NearCall(cs1, 0x6B06, troop_reset_occupation_clocks);
    label_100D_6B06_16BD6_24662:
        CheckExternalEvents(cs1, 0x6B06);
        // 100D:6B06 cmp byte ptr DS:[SI+3],2
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x02);
        // 100D:6B0A je short 0x6B19
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6B0A");
        }
    label_100D_6B0C_16BDC_24665:
        CheckExternalEvents(cs1, 0x6B0C);
        // 100D:6B0C call near 0x693B
        NearCall(cs1, 0x6B0F, troop_get_occupation_bits_2_and_3);
    label_100D_6B0F_16BDF_24667:
        CheckExternalEvents(cs1, 0x6B0F);
        // 100D:6B0F mov CL,AL
        CL = AL;
        // 100D:6B11 mov AX,0x2000
        AX = (ushort)0x2000;
        // 100D:6B14 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:6B16 or word ptr DS:[SI+0x12],AX
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)18)], AX);
        // 100D:6B19 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:6B1B cmp AL,byte ptr DS:[0x1954]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1954]);
        // 100D:6B1F jne short 0x6B24
        if (!ZeroFlag)
        {
            return unknown_100D_6B24_16BF4(0x0000);
        }
    label_100D_6B21_16BF1_24675:
        CheckExternalEvents(cs1, 0x6B21);
        // 100D:6B21 call near 0x7847
        NearCall(cs1, 0x6B24, map_setup_troop_dialog_menu);
        return unknown_100D_6B24_16BF4(0x0000);
    }

    public virtual Action troop_reset_occupation_clocks(int loadOffset)
    {
    label_100D_6B25_16BF5_23257:
        CheckExternalEvents(cs1, 0x6B25);
        // 100D:6B25 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:6B28 mov word ptr DS:[SI+0x0A],AX
        UInt16[DS, (ushort)(SI + (sbyte)10)] = AX;
        // 100D:6B2B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:6B2D mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
        // 100D:6B30 mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
        // 100D:6B33 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action tick_troop_icon_anim(int loadOffset)
    {
    label_100D_6B34_16C04_18490:
        CheckExternalEvents(cs1, 0x6B34);
        // 100D:6B34 inc byte ptr DS:[0x46F6]
        UInt8[DS, (ushort)0x46F6] = Alu8.Inc(UInt8[DS, (ushort)0x46F6]);
        // 100D:6B38 mov AL,byte ptr DS:[0x46F6]
        AL = UInt8[DS, (ushort)0x46F6];
        // 100D:6B3B and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:6B3D je short 0x6B4B
        if (ZeroFlag)
        {
            goto label_100D_6B4B_16C1B_18530;
        }
    label_100D_6B3F_16C0F_18495:
        CheckExternalEvents(cs1, 0x6B3F);
        // 100D:6B3F mov CX,1
        CX = (ushort)0x0001;
        // 100D:6B42 mov DI,word ptr DS:[0x4752]
        DI = UInt16[DS, (ushort)0x4752];
        // 100D:6B46 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:6B48 jne short 0x6B55
        if (!ZeroFlag)
        {
            goto label_100D_6B55_16C25_24455;
        }
    label_100D_6B4A_16C1A_18500:
        CheckExternalEvents(cs1, 0x6B4A);
        // 100D:6B4A ret near
        return NearRet((ushort)0x0000);
    label_100D_6B4B_16C1B_18530:
        CheckExternalEvents(cs1, 0x6B4B);
        // 100D:6B4B mov SI,0x3CBE
        SI = (ushort)0x3CBE;
        // 100D:6B4E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:6B4F mov CX,AX
        CX = AX;
        // 100D:6B51 jcxz short 0x6B89
        if (CX == (ushort)0x0000)
        {
            goto label_100D_6B89_16C59_18535;
        }
    label_100D_6B53_16C23_24516:
        CheckExternalEvents(cs1, 0x6B53);
        // 100D:6B53 mov DI,SI
        DI = SI;
    label_100D_6B55_16C25_24455:
        CheckExternalEvents(cs1, 0x6B55);
        // 100D:6B55 test byte ptr DS:[DI+0x0C],1
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x01);
        // 100D:6B59 je short 0x6B84
        if (ZeroFlag)
        {
            goto label_100D_6B84_16C54_24510;
        }
    label_100D_6B5B_16C2B_24458:
        CheckExternalEvents(cs1, 0x6B5B);
        // 100D:6B5B mov SI,word ptr DS:[DI+0x0D]
        SI = UInt16[DS, (ushort)(DI + (sbyte)13)];
        // 100D:6B5E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:6B5F or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:6B61 jne short 0x6B6D
        if (!ZeroFlag)
        {
            goto label_100D_6B6D_16C3D_24463;
        }
    label_100D_6B63_16C33_24549:
        CheckExternalEvents(cs1, 0x6B63);
        // 100D:6B63 mov SI,word ptr DS:[DI+0x0F]
        SI = UInt16[DS, (ushort)(DI + (sbyte)15)];
        // 100D:6B66 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:6B67 test byte ptr DS:[DI+0x0C],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)12)], (byte)0x02);
        // 100D:6B6B jne short 0x6B84
        if (!ZeroFlag)
        {
            goto label_100D_6B84_16C54_24510;
        }
    label_100D_6B6D_16C3D_24463:
        CheckExternalEvents(cs1, 0x6B6D);
        // 100D:6B6D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:6B6F mov word ptr DS:[DI+8],AX
        UInt16[DS, (ushort)(DI + (sbyte)8)] = AX;
        // 100D:6B72 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:6B73 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:6B74 mov DX,AX
        DX = AX;
        // 100D:6B76 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:6B77 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 100D:6B78 mov BX,AX
        BX = AX;
        // 100D:6B7A mov word ptr DS:[DI+0x0D],SI
        UInt16[DS, (ushort)(DI + (sbyte)13)] = SI;
        // 100D:6B7D push CX
        Stack.Push16(CX);
        // 100D:6B7E push DI
        Stack.Push16(DI);
        // 100D:6B7F call near 0xC661
        NearCall(cs1, 0x6B82, troop_icon_move_and_redraw);
    label_100D_6B82_16C52_24507:
        CheckExternalEvents(cs1, 0x6B82);
        // 100D:6B82 pop DI
        DI = Stack.Pop16();
        // 100D:6B83 pop CX
        CX = Stack.Pop16();
    label_100D_6B84_16C54_24510:
        CheckExternalEvents(cs1, 0x6B84);
        // 100D:6B84 add DI,0x0011
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 100D:6B87 loop 0x6B55
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6B55_16C25_24455;
        }
    label_100D_6B89_16C59_18535:
        CheckExternalEvents(cs1, 0x6B89);
        // 100D:6B89 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6B8A_16C5A(int loadOffset)
    {
    entrydispatcher:
    label_100D_6B8A_16C5A_28322:
        CheckExternalEvents(cs1, 0x6B8A);
        // 100D:6B8A mov AH,byte ptr DS:[DI+0x0A]
        AH = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:6B8D and AH,0x41
        AH = Alu8.And(AH, (byte)0x41);
        // 100D:6B90 cmp AH,1
        Alu8.Sub(AH, (byte)0x01);
        // 100D:6B93 cmc
        CarryFlag = !CarryFlag;
        // 100D:6B94 jmp short 0x6BB6
        if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_spice_mining_not_viable(int loadOffset)
    {
    entrydispatcher:
    label_100D_6B96_16C66_24593:
        CheckExternalEvents(cs1, 0x6B96);
        // 100D:6B96 test word ptr DS:[SI+0x10],0x0200
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0200);
        // 100D:6B9B stc
        CarryFlag = true;
        // 100D:6B9C jne short 0x6BB6
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6B9C");
        }
    label_100D_6B9E_16C6E_24597:
        CheckExternalEvents(cs1, 0x6B9E);
        // 100D:6B9E test word ptr DS:[SI+0x12],0x0030
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0030);
        // 100D:6BA3 stc
        CarryFlag = true;
        // 100D:6BA4 jne short 0x6BB6
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6BA4");
        }
    label_100D_6BA6_16C76_24601:
        CheckExternalEvents(cs1, 0x6BA6);
        // 100D:6BA6 cmp byte ptr DS:[DI+0x12],1
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)18)], (byte)0x01);
        // 100D:6BAA jb short 0x6BB6
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:6BAA");
        }
    label_100D_6BAC_16C7C_24604:
        CheckExternalEvents(cs1, 0x6BAC);
        // 100D:6BAC mov AL,byte ptr DS:[DI+0x0A]
        AL = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:6BAF xor AL,0x40
        AL = Alu8.Xor(AL, (byte)0x40);
        // 100D:6BB1 and AL,0x41
        AL = Alu8.And(AL, (byte)0x41);
        // 100D:6BB3 je short 0x6BB6
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6BB5_16C85_28116:
        CheckExternalEvents(cs1, 0x6BB5);
        // 100D:6BB5 stc
        CarryFlag = true;
        if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_6BD7_16CA7(int loadOffset)
    {
    entrydispatcher:
    label_100D_6BD7_16CA7_39700:
        CheckExternalEvents(cs1, 0x6BD7);
        // 100D:6BD7 test word ptr DS:[SI+0x12],0x0030
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0030);
        // 100D:6BDC stc
        CarryFlag = true;
        // 100D:6BDD jne short 0x6BB6
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6BDF_16CAF_39705:
        CheckExternalEvents(cs1, 0x6BDF);
        // 100D:6BDF cmp byte ptr DS:[DI+0x1B],1
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)27)], (byte)0x01);
        // 100D:6BE3 jb short 0x6BB6
        if (CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6BE5_16CB5_39709:
        CheckExternalEvents(cs1, 0x6BE5);
        // 100D:6BE5 test byte ptr DS:[DI+0x0A],0x20
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x20);
        // 100D:6BE9 stc
        CarryFlag = true;
        // 100D:6BEA je short 0x6BB6
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_6BEC_16CBC_39714:
        CheckExternalEvents(cs1, 0x6BEC);
        // 100D:6BEC mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:6BEF and AL,2
        AL = Alu8.And(AL, (byte)0x02);
        // 100D:6BF1 cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:6BF3 jmp short 0x6BB6
        if (JumpDispatcher.Jump(unknown_100D_6BB6_16C86, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_occupation_not_viable(int loadOffset)
    {
    entrydispatcher:
    label_100D_6C15_16CE5_24586:
        CheckExternalEvents(cs1, 0x6C15);
        // 100D:6C15 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6C18 mov BL,byte ptr DS:[SI+3]
        BL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6C1B and BX,0x000F
        BX = Alu16.And(BX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 100D:6C1E shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:6C20 clc
        CarryFlag = false;
        // 100D:6C21 jmp near word ptr CS:[BX+0x6BF5]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)27637)]))
        {
            case 0x0F66:
                return globe_mouse_noop(0x0000);
            case 0x6B8A:
                if (JumpDispatcher.Jump(unknown_100D_6B8A_16C5A, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x6B96:
                if (JumpDispatcher.Jump(troop_spice_mining_not_viable, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x6BD7:
                if (JumpDispatcher.Jump(unknown_100D_6BD7_16CA7, 0x0000))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)27637)])):X4} at 100D:6C21");
        }
    }

    public virtual Action unknown_100D_6C46_16D16(int loadOffset)
    {
    label_100D_6C46_16D16_15100:
        CheckExternalEvents(cs1, 0x6C46);
        // 100D:6C46 mov AL,byte ptr DS:[0x002A]
        AL = UInt8[DS, (ushort)0x002A];
        // 100D:6C49 sub AL,0x2D
        AL = Alu8.Sub(AL, (byte)0x2D);
        // 100D:6C4B cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:6C4D jae short 0x6C6E
        if (!CarryFlag)
        {
            goto label_100D_6C6E_16D3E_15105;
        }
    label_100D_6C4F_16D1F_33763:
        CheckExternalEvents(cs1, 0x6C4F);
        // 100D:6C4F test word ptr DS:[0x0010],0x0010
        Alu16.And(UInt16[DS, (ushort)0x0010], (ushort)0x0010);
        // 100D:6C55 jne short 0x6C6E
        if (!ZeroFlag)
        {
            goto label_100D_6C6E_16D3E_15105;
        }
    label_100D_6C57_16D27_33766:
        CheckExternalEvents(cs1, 0x6C57);
        // 100D:6C57 mov DI,word ptr DS:[0x473C]
        DI = UInt16[DS, (ushort)0x473C];
        // 100D:6C5B or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:6C5D je short 0x6C6E
        if (ZeroFlag)
        {
            goto label_100D_6C6E_16D3E_15105;
        }
    label_100D_6C5F_16D2F_33770:
        CheckExternalEvents(cs1, 0x6C5F);
        // 100D:6C5F call near 0x331E
        NearCall(cs1, 0x6C62, prepare_location_data_for_condit);
    label_100D_6C62_16D32_33772:
        CheckExternalEvents(cs1, 0x6C62);
        // 100D:6C62 cmp byte ptr DS:[0x0066],0
        Alu8.Sub(UInt8[DS, (ushort)0x0066], (byte)0x00);
        // 100D:6C67 je short 0x6C6E
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6C67");
        }
    label_100D_6C6E_16D3E_15105:
        CheckExternalEvents(cs1, 0x6C6E);
        // 100D:6C6E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action run_troop_occupation_events(int loadOffset)
    {
    label_100D_6C6F_16D3F_15087:
        CheckExternalEvents(cs1, 0x6C6F);
        // 100D:6C6F xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:6C71 mov AX,word ptr DS:[0x101A]
        AX = UInt16[DS, (ushort)0x101A];
        // 100D:6C74 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:6C76 jne short 0x6C83
        if (!ZeroFlag)
        {
            goto label_100D_6C83_16D53_15098;
        }
    label_100D_6C78_16D48_15092:
        CheckExternalEvents(cs1, 0x6C78);
        // 100D:6C78 mov AL,0x1C
        AL = (byte)0x1C;
        // 100D:6C7A dec AH
        AH = Alu8.Dec(AH);
        // 100D:6C7C mul AH
        ushort result_100D_6C7C_16D4C = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_6C7C_16D4C >> 8));
        AL = unchecked((byte)result_100D_6C7C_16D4C);
        // 100D:6C7E add AX,0x0100
        AX = Alu16.Add(AX, (ushort)0x0100);
        // 100D:6C81 mov SI,AX
        SI = AX;
    label_100D_6C83_16D53_15098:
        CheckExternalEvents(cs1, 0x6C83);
        // 100D:6C83 mov word ptr DS:[0x473C],SI
        UInt16[DS, (ushort)0x473C] = SI;
        // 100D:6C87 call near 0x6C46
        NearCall(cs1, 0x6C8A, unknown_100D_6C46_16D16);
    label_100D_6C8A_16D5A_15107:
        CheckExternalEvents(cs1, 0x6C8A);
        // 100D:6C8A mov byte ptr DS:[0x4737],0
        UInt8[DS, (ushort)0x4737] = (byte)0x00;
        // 100D:6C8F mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_6C92_16D62_15110:
        CheckExternalEvents(cs1, 0x6C92);
        // 100D:6C92 test word ptr DS:[SI+0x12],0x0430
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x0430);
        // 100D:6C97 jne short 0x6CD3
        if (!ZeroFlag)
        {
            goto label_100D_6CD3_16DA3_35734;
        }
    label_100D_6C99_16D69_15112:
        CheckExternalEvents(cs1, 0x6C99);
        // 100D:6C99 cmp byte ptr DS:[SI+0x1A],0x14
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)26)], (byte)0x14);
        // 100D:6C9D jae short 0x6CA4
        if (!CarryFlag)
        {
            goto label_100D_6CA4_16D74_15115;
        }
    label_100D_6C9F_16D6F_15124:
        CheckExternalEvents(cs1, 0x6C9F);
        // 100D:6C9F call near 0x6D19
        NearCall(cs1, 0x6CA2, unknown_100D_6D19_16DE9);
    label_100D_6CA2_16D72_15131:
        CheckExternalEvents(cs1, 0x6CA2);
        // 100D:6CA2 jb short 0x6CC3
        if (CarryFlag)
        {
            goto label_100D_6CC3_16D93_15119;
        }
    label_100D_6CA4_16D74_15115:
        CheckExternalEvents(cs1, 0x6CA4);
        // 100D:6CA4 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6CA7 test AL,0xA0
        Alu8.And(AL, (byte)0xA0);
        // 100D:6CA9 jne short 0x6CC3
        if (!ZeroFlag)
        {
            goto label_100D_6CC3_16D93_15119;
        }
    label_100D_6CAB_16D7B_25124:
        CheckExternalEvents(cs1, 0x6CAB);
        // 100D:6CAB test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:6CAD jne short 0x6CED
        if (!ZeroFlag)
        {
            goto label_100D_6CED_16DBD_29725;
        }
    label_100D_6CAF_16D7F_25127:
        CheckExternalEvents(cs1, 0x6CAF);
        // 100D:6CAF and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:6CB2 mov BX,AX
        BX = AX;
        // 100D:6CB4 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:6CB6 push SI
        Stack.Push16(SI);
        // 100D:6CB7 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6CBA call near word ptr CS:[BX+0x6C26]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)27686)]))
        {
            case 0x6FE5:
                NearCall(cs1, 0x6CBF, troop_occupation_event_spice_mining);
                break;
            case 0x70CC:
                NearCall(cs1, 0x6CBF, troop_occupation_event_spice_prospecting);
                break;
            case 0x71EF:
                NearCall(cs1, 0x6CBF, unknown_100D_71EF_172BF);
                break;
            case 0x72B0:
                NearCall(cs1, 0x6CBF, unknown_100D_72B0_17380);
                break;
            case 0x739E:
                NearCall(cs1, 0x6CBF, unknown_100D_739E_1746E);
                break;
            case 0x767D:
                NearCall(cs1, 0x6CBF, unknown_100D_767D_1774D);
                break;
            case 0x7693:
                NearCall(cs1, 0x6CBF, unknown_100D_7693_17763);
                break;
            case 0x7711:
                NearCall(cs1, 0x6CBF, unknown_100D_7711_177E1);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)27686)])):X4} at 100D:6CBA");
        }
    label_100D_6CBF_16D8F_25190:
        CheckExternalEvents(cs1, 0x6CBF);
        // 100D:6CBF pop SI
        SI = Stack.Pop16();
        // 100D:6CC0 call near 0x6D7B
        NearCall(cs1, 0x6CC3, unknown_100D_6D7B_16E4B);
    label_100D_6CC3_16D93_15119:
        CheckExternalEvents(cs1, 0x6CC3);
        // 100D:6CC3 add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:6CC6 cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:6CCA jb short 0x6C92
        if (CarryFlag)
        {
            goto label_100D_6C92_16D62_15110;
        }
    label_100D_6CCC_16D9C_15133:
        CheckExternalEvents(cs1, 0x6CCC);
        // 100D:6CCC mov AL,byte ptr DS:[0x4737]
        AL = UInt8[DS, (ushort)0x4737];
        // 100D:6CCF mov byte ptr DS:[0x00FA],AL
        UInt8[DS, (ushort)0x00FA] = AL;
        // 100D:6CD2 ret near
        return NearRet((ushort)0x0000);
    label_100D_6CD3_16DA3_35734:
        CheckExternalEvents(cs1, 0x6CD3);
        // 100D:6CD3 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:6CD7 jne short 0x6CED
        if (!ZeroFlag)
        {
            goto label_100D_6CED_16DBD_29725;
        }
    label_100D_6CD9_16DA9_35737:
        CheckExternalEvents(cs1, 0x6CD9);
        // 100D:6CD9 cmp byte ptr DS:[0x00FA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FA], (byte)0x00);
        // 100D:6CDE je short 0x6CC3
        if (ZeroFlag)
        {
            goto label_100D_6CC3_16D93_15119;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6CDE");
        }
    label_100D_6CED_16DBD_29725:
        CheckExternalEvents(cs1, 0x6CED);
        // 100D:6CED mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:6CEF cmp AL,byte ptr DS:[0x1954]
        Alu8.Sub(AL, UInt8[DS, (ushort)0x1954]);
        // 100D:6CF3 je short 0x6CC3
        if (ZeroFlag)
        {
            goto label_100D_6CC3_16D93_15119;
        }
    label_100D_6CF5_16DC5_29729:
        CheckExternalEvents(cs1, 0x6CF5);
        // 100D:6CF5 push SI
        Stack.Push16(SI);
        // 100D:6CF6 call near 0x8308
        NearCall(cs1, 0x6CF9, troop_travel_step);
    label_100D_6CF9_16DC9_29766:
        CheckExternalEvents(cs1, 0x6CF9);
        // 100D:6CF9 pop SI
        SI = Stack.Pop16();
        // 100D:6CFA jmp short 0x6CC3
        goto label_100D_6CC3_16D93_15119;
    }

    public virtual Action unknown_100D_6CFC_16DCC(int loadOffset)
    {
    label_100D_6CFC_16DCC_26766:
        CheckExternalEvents(cs1, 0x6CFC);
        // 100D:6CFC cmp byte ptr DS:[DI+8],0x20
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x20);
        // 100D:6D00 jae short 0x6D18
        if (!CarryFlag)
        {
            goto label_100D_6D18_16DE8_26783;
        }
    label_100D_6D02_16DD2_26769:
        CheckExternalEvents(cs1, 0x6D02);
        // 100D:6D02 cmp byte ptr DS:[DI+0x0B],0x0C
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)11)], (byte)0x0C);
        // 100D:6D06 jae short 0x6D18
        if (!CarryFlag)
        {
            goto label_100D_6D18_16DE8_26783;
        }
    label_100D_6D08_16DD8_26772:
        CheckExternalEvents(cs1, 0x6D08);
        // 100D:6D08 test byte ptr DS:[DI+0x0A],1
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x01);
        // 100D:6D0C jne short 0x6D18
        if (!ZeroFlag)
        {
            goto label_100D_6D18_16DE8_26783;
        }
    label_100D_6D0E_16DDE_26775:
        CheckExternalEvents(cs1, 0x6D0E);
        // 100D:6D0E inc byte ptr DS:[DI+0x0B]
        UInt8[DS, (ushort)(DI + (sbyte)11)] = Alu8.Inc(UInt8[DS, (ushort)(DI + (sbyte)11)]);
        // 100D:6D11 push SI
        Stack.Push16(SI);
        // 100D:6D12 push DI
        Stack.Push16(DI);
        // 100D:6D13 call near 0x644E
        NearCall(cs1, 0x6D16, unknown_100D_644E_1651E);
    label_100D_6D16_16DE6_26780:
        CheckExternalEvents(cs1, 0x6D16);
        // 100D:6D16 pop DI
        DI = Stack.Pop16();
        // 100D:6D17 pop SI
        SI = Stack.Pop16();
    label_100D_6D18_16DE8_26783:
        CheckExternalEvents(cs1, 0x6D18);
        // 100D:6D18 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6D19_16DE9(int loadOffset)
    {
    label_100D_6D19_16DE9_15126:
        CheckExternalEvents(cs1, 0x6D19);
        // 100D:6D19 test byte ptr DS:[SI+3],0xE3
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xE3);
        // 100D:6D1D jne short 0x6D5E
        if (!ZeroFlag)
        {
            goto label_100D_6D5E_16E2E_15129;
        }
    label_100D_6D1F_16DEF_39912:
        CheckExternalEvents(cs1, 0x6D1F);
        // 100D:6D1F test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:6D23 jne short 0x6D5E
        if (!ZeroFlag)
        {
            goto label_100D_6D5E_16E2E_15129;
        }
    label_100D_6D25_16DF5_39916:
        CheckExternalEvents(cs1, 0x6D25);
        // 100D:6D25 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:6D29 je short 0x6D5E
        if (ZeroFlag)
        {
            goto label_100D_6D5E_16E2E_15129;
        }
    label_100D_6D2B_16DFB_39920:
        CheckExternalEvents(cs1, 0x6D2B);
        // 100D:6D2B mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6D2E xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:6D30 mov CL,byte ptr DS:[SI+0x1A]
        CL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:6D33 not CL
        CL = unchecked((byte)~CL);
        // 100D:6D35 mov DX,SI
        DX = SI;
        // 100D:6D37 mov BP,0x6D5F
        BP = (ushort)0x6D5F;
        // 100D:6D3A call near 0x661D
        NearCall(cs1, 0x6D3D, for_each_hired_troop_in_location);
    label_100D_6D3D_16E0D_39972:
        CheckExternalEvents(cs1, 0x6D3D);
        // 100D:6D3D or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:6D3F je short 0x6D5E
        if (ZeroFlag)
        {
            goto label_100D_6D5E_16E2E_15129;
        }
    label_100D_6D41_16E11_39976:
        CheckExternalEvents(cs1, 0x6D41);
        // 100D:6D41 mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:6D44 add byte ptr DS:[BX+0x1A],AL
        UInt8[DS, (ushort)(BX + (sbyte)26)] = Alu8.Add(UInt8[DS, (ushort)(BX + (sbyte)26)], AL);
        // 100D:6D47 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:6D4A mov AH,AL
        AH = AL;
        // 100D:6D4C and AL,byte ptr DS:[BX+0x19]
        AL = Alu8.And(AL, UInt8[DS, (ushort)(BX + (sbyte)25)]);
        // 100D:6D4F mov byte ptr DS:[SI+0x19],AL
        UInt8[DS, (ushort)(SI + (sbyte)25)] = AL;
        // 100D:6D52 or byte ptr DS:[BX+0x19],AH
        UInt8[DS, (ushort)(BX + (sbyte)25)] = Alu8.Or(UInt8[DS, (ushort)(BX + (sbyte)25)], AH);
        // 100D:6D55 or word ptr DS:[BX+0x12],0x0200
        UInt16[DS, (ushort)(BX + (sbyte)18)] = Alu16.Or(UInt16[DS, (ushort)(BX + (sbyte)18)], (ushort)0x0200);
        // 100D:6D5A call near 0x66B1
        NearCall(cs1, 0x6D5D, troop_remove_from_play);
    label_100D_6D5D_16E2D_39997:
        CheckExternalEvents(cs1, 0x6D5D);
        // 100D:6D5D stc
        CarryFlag = true;
    label_100D_6D5E_16E2E_15129:
        CheckExternalEvents(cs1, 0x6D5E);
        // 100D:6D5E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6D5F_16E2F(int loadOffset)
    {
    label_100D_6D5F_16E2F_39939:
        CheckExternalEvents(cs1, 0x6D5F);
        // 100D:6D5F test byte ptr DS:[SI+3],0xA0
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xA0);
        // 100D:6D63 jne short 0x6D7A
        if (!ZeroFlag)
        {
            goto label_100D_6D7A_16E4A_39942;
        }
    label_100D_6D65_16E35_39944:
        CheckExternalEvents(cs1, 0x6D65);
        // 100D:6D65 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:6D69 je short 0x6D7A
        if (ZeroFlag)
        {
            goto label_100D_6D7A_16E4A_39942;
        }
    label_100D_6D6B_16E3B_39948:
        CheckExternalEvents(cs1, 0x6D6B);
        // 100D:6D6B cmp SI,DX
        Alu16.Sub(SI, DX);
        // 100D:6D6D je short 0x6D7A
        if (ZeroFlag)
        {
            goto label_100D_6D7A_16E4A_39942;
        }
    label_100D_6D6F_16E3F_39952:
        CheckExternalEvents(cs1, 0x6D6F);
        // 100D:6D6F mov AL,byte ptr DS:[SI+0x1A]
        AL = UInt8[DS, (ushort)(SI + (sbyte)26)];
        // 100D:6D72 cmp CL,AL
        Alu8.Sub(CL, AL);
        // 100D:6D74 jb short 0x6D7A
        if (CarryFlag)
        {
            goto label_100D_6D7A_16E4A_39942;
        }
    label_100D_6D76_16E46_39957:
        CheckExternalEvents(cs1, 0x6D76);
        // 100D:6D76 mov BX,SI
        BX = SI;
        // 100D:6D78 mov CL,AL
        CL = AL;
    label_100D_6D7A_16E4A_39942:
        CheckExternalEvents(cs1, 0x6D7A);
        // 100D:6D7A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6D7B_16E4B(int loadOffset)
    {
    label_100D_6D7B_16E4B_25193:
        CheckExternalEvents(cs1, 0x6D7B);
        // 100D:6D7B test word ptr DS:[2],0x003F
        Alu16.And(UInt16[DS, (ushort)0x0002], (ushort)0x003F);
        // 100D:6D81 je short 0x6D84
        if (ZeroFlag)
        {
            goto label_100D_6D84_16E54_30885;
        }
    label_100D_6D83_16E53_25196:
        CheckExternalEvents(cs1, 0x6D83);
        // 100D:6D83 ret near
        return NearRet((ushort)0x0000);
    label_100D_6D84_16E54_30885:
        CheckExternalEvents(cs1, 0x6D84);
        // 100D:6D84 call near 0x693B
        NearCall(cs1, 0x6D87, troop_get_occupation_bits_2_and_3);
    label_100D_6D87_16E57_30887:
        CheckExternalEvents(cs1, 0x6D87);
        // 100D:6D87 mov CL,AL
        CL = AL;
        // 100D:6D89 mov AX,0xC000
        AX = (ushort)0xC000;
        // 100D:6D8C rol AX,CL
        AX = Alu16.Rol(AX, CL);
        // 100D:6D8E and AX,word ptr DS:[SI+0x12]
        AX = Alu16.And(AX, UInt16[DS, (ushort)(SI + (sbyte)18)]);
        // 100D:6D91 je short 0x6DBA
        if (ZeroFlag)
        {
            goto label_100D_6DBA_16E8A_30893;
        }
    label_100D_6D93_16E63_35777:
        CheckExternalEvents(cs1, 0x6D93);
        // 100D:6D93 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:6D95 jae short 0x6DA0
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6D95");
        }
    label_100D_6DA0_16E70_35780:
        CheckExternalEvents(cs1, 0x6DA0);
        // 100D:6DA0 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:6DA2 jae short 0x6DAD
        if (!CarryFlag)
        {
            goto label_100D_6DAD_16E7D_35783;
        }
    label_100D_6DA4_16E74_36925:
        CheckExternalEvents(cs1, 0x6DA4);
        // 100D:6DA4 cmp byte ptr DS:[SI+0x17],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)23)], (byte)0x00);
        // 100D:6DA8 je short 0x6DAD
        if (ZeroFlag)
        {
            goto label_100D_6DAD_16E7D_35783;
        }
    label_100D_6DAA_16E7A_36928:
        CheckExternalEvents(cs1, 0x6DAA);
        // 100D:6DAA dec byte ptr DS:[SI+0x17]
        UInt8[DS, (ushort)(SI + (sbyte)23)] = Alu8.Dec(UInt8[DS, (ushort)(SI + (sbyte)23)]);
    label_100D_6DAD_16E7D_35783:
        CheckExternalEvents(cs1, 0x6DAD);
        // 100D:6DAD shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:6DAF jae short 0x6DBA
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6DAF");
        }
    label_100D_6DBA_16E8A_30893:
        CheckExternalEvents(cs1, 0x6DBA);
        // 100D:6DBA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6DBB_16E8B(int loadOffset)
    {
    entrydispatcher:
    label_100D_6DBB_16E8B_36583:
        CheckExternalEvents(cs1, 0x6DBB);
        // 100D:6DBB push SI
        Stack.Push16(SI);
        // 100D:6DBC call near 0x40AE
        NearCall(cs1, 0x6DBF, location_entry_room_codes);
    label_100D_6DBF_16E8F_36586:
        CheckExternalEvents(cs1, 0x6DBF);
        // 100D:6DBF mov SI,0x0FD8
        SI = (ushort)0x0FD8;
        // 100D:6DC2 mov CX,0x000C
        CX = (ushort)0x000C;
    label_100D_6DC5_16E95_36589:
        CheckExternalEvents(cs1, 0x6DC5);
        // 100D:6DC5 cmp BX,word ptr DS:[SI+2]
        Alu16.Sub(BX, UInt16[DS, (ushort)(SI + (sbyte)2)]);
        // 100D:6DC8 jne short 0x6DD6
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6DC8");
        }
    label_100D_6DD6_16EA6_36591:
        CheckExternalEvents(cs1, 0x6DD6);
        // 100D:6DD6 add SI,0x0010
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:6DD9 loop 0x6DC5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_6DC5_16E95_36589;
        }
    label_100D_6DDB_16EAB_36595:
        CheckExternalEvents(cs1, 0x6DDB);
        // 100D:6DDB cmp BX,word ptr DS:[6]
        Alu16.Sub(BX, UInt16[DS, (ushort)0x0006]);
        // 100D:6DDF jne short 0x6DFB
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6DDF");
        }
    label_100D_6DFB_16ECB_36598:
        CheckExternalEvents(cs1, 0x6DFB);
        // 100D:6DFB pop SI
        SI = Stack.Pop16();
        // 100D:6DFC mov BP,0x6E0F
        BP = (ushort)0x6E0F;
        // 100D:6DFF call near 0x6603
        NearCall(cs1, 0x6E02, for_each_troop_in_location);
        if (JumpDispatcher.Jump(unknown_100D_6E02_16ED2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_6E02_16ED2(int loadOffset)
    {
    entrydispatcher:
    label_100D_6E02_16ED2_36610:
        CheckExternalEvents(cs1, 0x6E02);
        // 100D:6E02 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:6E04 mov BP,0x764D
        BP = (ushort)0x764D;
        // 100D:6E07 call near 0x6603
        NearCall(cs1, 0x6E0A, for_each_troop_in_location);
    label_100D_6E0A_16EDA_36618:
        CheckExternalEvents(cs1, 0x6E0A);
        // 100D:6E0A or CX,CX
        CX = Alu16.Or(CX, CX);
        // 100D:6E0C jne short 0x6E02
        if (!ZeroFlag)
        {
            goto label_100D_6E02_16ED2_36610;
        }
    label_100D_6E0E_16EDE_36621:
        CheckExternalEvents(cs1, 0x6E0E);
        // 100D:6E0E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6E0F_16EDF(int loadOffset)
    {
    label_100D_6E0F_16EDF_36602:
        CheckExternalEvents(cs1, 0x6E0F);
        // 100D:6E0F test word ptr DS:[SI+0x10],0x0020
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0020);
        // 100D:6E14 je short 0x6E1F
        if (ZeroFlag)
        {
            goto label_100D_6E1F_16EEF_36608;
        }
    label_100D_6E16_16EE6_36605:
        CheckExternalEvents(cs1, 0x6E16);
        // 100D:6E16 and word ptr DS:[SI+0x10],-33
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], unchecked((ushort)unchecked((short)(sbyte)-33)));
        // 100D:6E1A or word ptr DS:[SI+0x12],0x1000
        UInt16[DS, (ushort)(SI + (sbyte)18)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)18)], (ushort)0x1000);
    label_100D_6E1F_16EEF_36608:
        CheckExternalEvents(cs1, 0x6E1F);
        // 100D:6E1F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6E20_16EF0(int loadOffset)
    {
    label_100D_6E20_16EF0_25136:
        CheckExternalEvents(cs1, 0x6E20);
        // 100D:6E20 cmp byte ptr DS:[0x46DE],0
        Alu8.Sub(UInt8[DS, (ushort)0x46DE], (byte)0x00);
        // 100D:6E25 jne short 0x6E28
        if (!ZeroFlag)
        {
            goto label_100D_6E28_16EF8_26761;
        }
    label_100D_6E27_16EF7_25139:
        CheckExternalEvents(cs1, 0x6E27);
        // 100D:6E27 ret near
        return NearRet((ushort)0x0000);
    label_100D_6E28_16EF8_26761:
        CheckExternalEvents(cs1, 0x6E28);
        // 100D:6E28 test byte ptr DS:[DI+0x0A],8
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x08);
        // 100D:6E2C je short 0x6E4B
        if (ZeroFlag)
        {
            goto label_100D_6E4B_16F1B_26764;
        }
    label_100D_6E2E_16EFE_36566:
        CheckExternalEvents(cs1, 0x6E2E);
        // 100D:6E2E call near 0x1AC5
        NearCall(cs1, 0x6E31, unknown_100D_1AC5_11B95);
    label_100D_6E31_16F01_36568:
        CheckExternalEvents(cs1, 0x6E31);
        // 100D:6E31 sub AL,byte ptr DS:[DI+0x0B]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)11)]);
        // 100D:6E34 cmp AL,0xFE
        Alu8.Sub(AL, (byte)0xFE);
        // 100D:6E36 jae short 0x6E81
        if (!CarryFlag)
        {
            goto label_100D_6E81_16F51_26845;
        }
    label_100D_6E38_16F08_36578:
        CheckExternalEvents(cs1, 0x6E38);
        // 100D:6E38 and byte ptr DS:[DI+0x0A],0xF7
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0xF7);
        // 100D:6E3C and byte ptr DS:[DI+8],7
        UInt8[DS, (ushort)(DI + (sbyte)8)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x07);
        // 100D:6E40 inc byte ptr DS:[0x0027]
        UInt8[DS, (ushort)0x0027] = Alu8.Inc(UInt8[DS, (ushort)0x0027]);
        // 100D:6E44 call near 0x6DBB
        NearCall(cs1, 0x6E47, unknown_100D_6DBB_16E8B);
    label_100D_6E47_16F17_36623:
        CheckExternalEvents(cs1, 0x6E47);
        // 100D:6E47 mov byte ptr DS:[DI+0x0B],5
        UInt8[DS, (ushort)(DI + (sbyte)11)] = (byte)0x05;
    label_100D_6E4B_16F1B_26764:
        CheckExternalEvents(cs1, 0x6E4B);
        // 100D:6E4B call near 0x6CFC
        NearCall(cs1, 0x6E4E, unknown_100D_6CFC_16DCC);
    label_100D_6E4E_16F1E_26784:
        CheckExternalEvents(cs1, 0x6E4E);
        // 100D:6E4E call near 0x1AC5
        NearCall(cs1, 0x6E51, unknown_100D_1AC5_11B95);
    label_100D_6E51_16F21_26786:
        CheckExternalEvents(cs1, 0x6E51);
        // 100D:6E51 sub AL,byte ptr DS:[SI+0x14]
        AL = Alu8.Sub(AL, UInt8[DS, (ushort)(SI + (sbyte)20)]);
        // 100D:6E54 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 100D:6E56 jbe short 0x6E5D
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_6E5D_16F2D_26790;
        }
    label_100D_6E58_16F28_35302:
        CheckExternalEvents(cs1, 0x6E58);
        // 100D:6E58 mov AL,1
        AL = (byte)0x01;
        // 100D:6E5A call near 0x6F93
        NearCall(cs1, 0x6E5D, troop_decrease_motivation);
    label_100D_6E5D_16F2D_26790:
        CheckExternalEvents(cs1, 0x6E5D);
        // 100D:6E5D mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:6E5F cmp AL,byte ptr DS:[DI+9]
        Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)9)]);
        // 100D:6E62 jne short 0x6E81
        if (!ZeroFlag)
        {
            goto label_100D_6E81_16F51_26845;
        }
    label_100D_6E64_16F34_26794:
        CheckExternalEvents(cs1, 0x6E64);
        // 100D:6E64 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:6E66 mov BP,0x6E82
        BP = (ushort)0x6E82;
        // 100D:6E69 call near 0x661D
        NearCall(cs1, 0x6E6C, for_each_hired_troop_in_location);
    label_100D_6E6C_16F3C_26842:
        CheckExternalEvents(cs1, 0x6E6C);
        // 100D:6E6C cmp DL,3
        Alu8.Sub(DL, (byte)0x03);
        // 100D:6E6F jne short 0x6E81
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6E6F");
        }
    label_100D_6E81_16F51_26845:
        CheckExternalEvents(cs1, 0x6E81);
        // 100D:6E81 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6E82_16F52(int loadOffset)
    {
    label_100D_6E82_16F52_26812:
        CheckExternalEvents(cs1, 0x6E82);
        // 100D:6E82 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:6E86 je short 0x6EA7
        if (ZeroFlag)
        {
            goto label_100D_6EA7_16F77_26831;
        }
    label_100D_6E88_16F58_26815:
        CheckExternalEvents(cs1, 0x6E88);
        // 100D:6E88 cmp byte ptr DS:[DI+8],0x21
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x21);
        // 100D:6E8C jae short 0x6EA7
        if (!CarryFlag)
        {
            goto label_100D_6EA7_16F77_26831;
        }
    label_100D_6E8E_16F5E_26818:
        CheckExternalEvents(cs1, 0x6E8E);
        // 100D:6E8E cmp byte ptr DS:[SI+0x15],0x28
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x28);
        // 100D:6E92 jae short 0x6EA7
        if (!CarryFlag)
        {
            goto label_100D_6EA7_16F77_26831;
        }
    label_100D_6E94_16F64_26821:
        CheckExternalEvents(cs1, 0x6E94);
        // 100D:6E94 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6E97 and AL,0x2F
        AL = Alu8.And(AL, (byte)0x2F);
        // 100D:6E99 jne short 0x6EA7
        if (!ZeroFlag)
        {
            goto label_100D_6EA7_16F77_26831;
        }
    label_100D_6E9B_16F6B_26825:
        CheckExternalEvents(cs1, 0x6E9B);
        // 100D:6E9B mov DH,1
        DH = (byte)0x01;
        // 100D:6E9D test byte ptr DS:[SI+0x12],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)18)], (byte)0x80);
        // 100D:6EA1 je short 0x6EA5
        if (ZeroFlag)
        {
            goto label_100D_6EA5_16F75_26829;
        }
    label_100D_6EA3_16F73_32300:
        CheckExternalEvents(cs1, 0x6EA3);
        // 100D:6EA3 shl DH,1
        DH = Alu8.Shl(DH, 1);
    label_100D_6EA5_16F75_26829:
        CheckExternalEvents(cs1, 0x6EA5);
        // 100D:6EA5 or DL,DH
        DL = Alu8.Or(DL, DH);
    label_100D_6EA7_16F77_26831:
        CheckExternalEvents(cs1, 0x6EA7);
        // 100D:6EA7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6EBF_16F8F(int loadOffset)
    {
    label_100D_6EBF_16F8F_29477:
        CheckExternalEvents(cs1, 0x6EBF);
        // 100D:6EBF push DI
        Stack.Push16(DI);
        // 100D:6EC0 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6EC3 mov BP,0x6ECB
        BP = (ushort)0x6ECB;
        // 100D:6EC6 call near 0x661D
        NearCall(cs1, 0x6EC9, for_each_hired_troop_in_location);
    label_100D_6EC9_16F99_29487:
        CheckExternalEvents(cs1, 0x6EC9);
        // 100D:6EC9 pop DI
        DI = Stack.Pop16();
        // 100D:6ECA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6ECB_16F9B(int loadOffset)
    {
    label_100D_6ECB_16F9B_29482:
        CheckExternalEvents(cs1, 0x6ECB);
        // 100D:6ECB test byte ptr DS:[SI+0x12],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)18)], (byte)0x10);
        // 100D:6ECF je short 0x6EDA
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6ECF");
        }
    label_100D_6EDA_16FAA_29485:
        CheckExternalEvents(cs1, 0x6EDA);
        // 100D:6EDA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_increase_spice_skill(int loadOffset)
    {
    label_100D_6EDD_16FAD_27994:
        CheckExternalEvents(cs1, 0x6EDD);
        // 100D:6EDD mov DL,byte ptr DS:[BX+SI+0x16]
        DL = UInt8[DS, (ushort)(BX + SI + (sbyte)22)];
        // 100D:6EE0 add AL,DL
        AL = Alu8.Add(AL, DL);
        // 100D:6EE2 cmp AL,0x5F
        Alu8.Sub(AL, (byte)0x5F);
        // 100D:6EE4 jbe short 0x6EE8
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_6EE8_16FB8_27999;
        }
    label_100D_6EE6_16FB6_35741:
        CheckExternalEvents(cs1, 0x6EE6);
        // 100D:6EE6 mov AL,0x5F
        AL = (byte)0x5F;
    label_100D_6EE8_16FB8_27999:
        CheckExternalEvents(cs1, 0x6EE8);
        // 100D:6EE8 mov byte ptr DS:[BX+SI+0x16],AL
        UInt8[DS, (ushort)(BX + SI + (sbyte)22)] = AL;
        // 100D:6EEB xor AL,DL
        AL = Alu8.Xor(AL, DL);
        // 100D:6EED and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:6EEF je short 0x6EFC
        if (ZeroFlag)
        {
            goto label_100D_6EFC_16FCC_28004;
        }
    label_100D_6EF1_16FC1_28267:
        CheckExternalEvents(cs1, 0x6EF1);
        // 100D:6EF1 mov AX,word ptr DS:[SI+0x10]
        AX = UInt16[DS, (ushort)(SI + (sbyte)16)];
        // 100D:6EF4 and AL,0xFC
        AL = Alu8.And(AL, (byte)0xFC);
        // 100D:6EF6 inc BX
        BX = Alu16.Inc(BX);
        // 100D:6EF7 or AL,BL
        AL = Alu8.Or(AL, BL);
        // 100D:6EF9 mov word ptr DS:[SI+0x10],AX
        UInt16[DS, (ushort)(SI + (sbyte)16)] = AX;
    label_100D_6EFC_16FCC_28004:
        CheckExternalEvents(cs1, 0x6EFC);
        // 100D:6EFC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_compute_motivation_modifier(int loadOffset)
    {
    label_100D_6EFD_16FCD_22701:
        CheckExternalEvents(cs1, 0x6EFD);
        // 100D:6EFD mov AH,byte ptr DS:[SI+3]
        AH = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:6F00 and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:6F03 mov AL,byte ptr DS:[SI+0x15]
        AL = UInt8[DS, (ushort)(SI + (sbyte)21)];
        // 100D:6F06 cmp byte ptr DS:[0x00FA],0
        Alu8.Sub(UInt8[DS, (ushort)0x00FA], (byte)0x00);
        // 100D:6F0B je short 0x6F0F
        if (ZeroFlag)
        {
            goto label_100D_6F0F_16FDF_22707;
        }
    label_100D_6F0D_16FDD_40806:
        CheckExternalEvents(cs1, 0x6F0D);
        // 100D:6F0D add AL,0x14
        AL = Alu8.Add(AL, (byte)0x14);
    label_100D_6F0F_16FDF_22707:
        CheckExternalEvents(cs1, 0x6F0F);
        // 100D:6F0F cmp AH,6
        Alu8.Sub(AH, (byte)0x06);
        // 100D:6F12 jne short 0x6F23
        if (!ZeroFlag)
        {
            goto label_100D_6F23_16FF3_22710;
        }
    label_100D_6F14_16FE4_34326:
        CheckExternalEvents(cs1, 0x6F14);
        // 100D:6F14 push DI
        Stack.Push16(DI);
        // 100D:6F15 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:6F18 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:6F1C pop DI
        DI = Stack.Pop16();
        // 100D:6F1D jne short 0x6F31
        if (!ZeroFlag)
        {
            goto label_100D_6F31_17001_22717;
        }
    label_100D_6F1F_16FEF_36228:
        CheckExternalEvents(cs1, 0x6F1F);
        // 100D:6F1F add AL,0x1E
        AL = Alu8.Add(AL, (byte)0x1E);
        // 100D:6F21 jmp short 0x6F2B
        goto label_100D_6F2B_16FFB_22714;
    label_100D_6F23_16FF3_22710:
        CheckExternalEvents(cs1, 0x6F23);
        // 100D:6F23 and AH,0xFE
        AH = Alu8.And(AH, (byte)0xFE);
        // 100D:6F26 cmp AH,8
        Alu8.Sub(AH, (byte)0x08);
        // 100D:6F29 je short 0x6F2F
        if (ZeroFlag)
        {
            goto label_100D_6F2F_16FFF_38128;
        }
    label_100D_6F2B_16FFB_22714:
        CheckExternalEvents(cs1, 0x6F2B);
        // 100D:6F2B cmp AL,0x64
        Alu8.Sub(AL, (byte)0x64);
        // 100D:6F2D jb short 0x6F31
        if (CarryFlag)
        {
            goto label_100D_6F31_17001_22717;
        }
    label_100D_6F2F_16FFF_38128:
        CheckExternalEvents(cs1, 0x6F2F);
        // 100D:6F2F mov AL,0x64
        AL = (byte)0x64;
    label_100D_6F31_17001_22717:
        CheckExternalEvents(cs1, 0x6F31);
        // 100D:6F31 cmp byte ptr DS:[0x002A],0x64
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x64);
        // 100D:6F36 jb short 0x6F47
        if (CarryFlag)
        {
            goto label_100D_6F47_17017_22720;
        }
    label_100D_6F38_17008_36088:
        CheckExternalEvents(cs1, 0x6F38);
        // 100D:6F38 cmp byte ptr DS:[0x002A],0x68
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x68);
        // 100D:6F3D jae short 0x6F47
        if (!CarryFlag)
        {
            goto label_100D_6F47_17017_22720;
        }
    label_100D_6F3F_1700F_36091:
        CheckExternalEvents(cs1, 0x6F3F);
        // 100D:6F3F sub AL,0x28
        AL = Alu8.Sub(AL, (byte)0x28);
        // 100D:6F41 cmp AL,0x0A
        Alu8.Sub(AL, (byte)0x0A);
        // 100D:6F43 jge short 0x6F47
        if (SignFlag == OverflowFlag)
        {
            goto label_100D_6F47_17017_22720;
        }
    label_100D_6F45_17015_36095:
        CheckExternalEvents(cs1, 0x6F45);
        // 100D:6F45 mov AL,0x0A
        AL = (byte)0x0A;
    label_100D_6F47_17017_22720:
        CheckExternalEvents(cs1, 0x6F47);
        // 100D:6F47 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6F48_17018(int loadOffset)
    {
    label_100D_6F48_17018_36432:
        CheckExternalEvents(cs1, 0x6F48);
        // 100D:6F48 add byte ptr DS:[SI+0x15],AL
        UInt8[DS, (ushort)(SI + (sbyte)21)] = Alu8.Add(UInt8[DS, (ushort)(SI + (sbyte)21)], AL);
        // 100D:6F4B cmp byte ptr DS:[SI+0x15],0x64
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x64);
        // 100D:6F4F jbe short 0x6F55
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_6F55_17025_36436;
        }
    label_100D_6F51_17021_40099:
        CheckExternalEvents(cs1, 0x6F51);
        // 100D:6F51 mov byte ptr DS:[SI+0x15],0x64
        UInt8[DS, (ushort)(SI + (sbyte)21)] = (byte)0x64;
    label_100D_6F55_17025_36436:
        CheckExternalEvents(cs1, 0x6F55);
        // 100D:6F55 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6F56_17026(int loadOffset)
    {
    label_100D_6F56_17026_28099:
        CheckExternalEvents(cs1, 0x6F56);
        // 100D:6F56 push SI
        Stack.Push16(SI);
        // 100D:6F57 mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_6F5A_1702A_28102:
        CheckExternalEvents(cs1, 0x6F5A);
        // 100D:6F5A test byte ptr DS:[SI+3],0xA0
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xA0);
        // 100D:6F5E jne short 0x6F6D
        if (!ZeroFlag)
        {
            goto label_100D_6F6D_1703D_28108;
        }
    label_100D_6F60_17030_28104:
        CheckExternalEvents(cs1, 0x6F60);
        // 100D:6F60 add byte ptr DS:[SI+0x15],AL
        UInt8[DS, (ushort)(SI + (sbyte)21)] = Alu8.Add(UInt8[DS, (ushort)(SI + (sbyte)21)], AL);
        // 100D:6F63 cmp byte ptr DS:[SI+0x15],0x64
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x64);
        // 100D:6F67 jbe short 0x6F6D
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_6F6D_1703D_28108;
        }
    label_100D_6F69_17039_40096:
        CheckExternalEvents(cs1, 0x6F69);
        // 100D:6F69 mov byte ptr DS:[SI+0x15],0x64
        UInt8[DS, (ushort)(SI + (sbyte)21)] = (byte)0x64;
    label_100D_6F6D_1703D_28108:
        CheckExternalEvents(cs1, 0x6F6D);
        // 100D:6F6D add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:6F70 cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:6F74 jb short 0x6F5A
        if (CarryFlag)
        {
            goto label_100D_6F5A_1702A_28102;
        }
    label_100D_6F76_17046_28113:
        CheckExternalEvents(cs1, 0x6F76);
        // 100D:6F76 pop SI
        SI = Stack.Pop16();
        // 100D:6F77 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action increase_charisma(int loadOffset)
    {
    label_100D_6F78_17048_23239:
        CheckExternalEvents(cs1, 0x6F78);
        // 100D:6F78 mov AH,byte ptr DS:[0x0029]
        AH = UInt8[DS, (ushort)0x0029];
        // 100D:6F7C add AL,AH
        AL = Alu8.Add(AL, AH);
        // 100D:6F7E cmp AL,0xC8
        Alu8.Sub(AL, (byte)0xC8);
        // 100D:6F80 jbe short 0x6F84
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_6F84_17054_23244;
        }
    label_100D_6F82_17052_40553:
        CheckExternalEvents(cs1, 0x6F82);
        // 100D:6F82 mov AL,0xC8
        AL = (byte)0xC8;
    label_100D_6F84_17054_23244:
        CheckExternalEvents(cs1, 0x6F84);
        // 100D:6F84 mov byte ptr DS:[0x0029],AL
        UInt8[DS, (ushort)0x0029] = AL;
        // 100D:6F87 and AX,0xFCFC
        AX = Alu16.And(AX, (ushort)0xFCFC);
        // 100D:6F8A sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 100D:6F8C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:6F8E shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:6F90 jne short 0x6F56
        if (!ZeroFlag)
        {
            return unknown_100D_6F56_17026(0x0000);
        }
    label_100D_6F92_17062_23251:
        CheckExternalEvents(cs1, 0x6F92);
        // 100D:6F92 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_decrease_motivation(int loadOffset)
    {
    label_100D_6F93_17063_34439:
        CheckExternalEvents(cs1, 0x6F93);
        // 100D:6F93 sub byte ptr DS:[SI+0x15],AL
        UInt8[DS, (ushort)(SI + (sbyte)21)] = Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], AL);
        // 100D:6F96 jae short 0x6F9C
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6F96");
        }
    label_100D_6F9C_1706C_34442:
        CheckExternalEvents(cs1, 0x6F9C);
        // 100D:6F9C cmp byte ptr DS:[SI+0x15],5
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)21)], (byte)0x05);
        // 100D:6FA0 jae short 0x6FAF
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6FA0");
        }
    label_100D_6FAF_1707F_34445:
        CheckExternalEvents(cs1, 0x6FAF);
        // 100D:6FAF ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_6FB0_17080(int loadOffset)
    {
    label_100D_6FB0_17080_34419:
        CheckExternalEvents(cs1, 0x6FB0);
        // 100D:6FB0 mov AH,AL
        AH = AL;
        // 100D:6FB2 mov AL,byte ptr DS:[0x0029]
        AL = UInt8[DS, (ushort)0x0029];
        // 100D:6FB5 sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 100D:6FB7 ja short 0x6FBB
        if (!(!CarryFlag && !ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6FB7");
        }
    label_100D_6FBB_1708B_34424:
        CheckExternalEvents(cs1, 0x6FBB);
        // 100D:6FBB mov AH,AL
        AH = AL;
        // 100D:6FBD xchg AL,byte ptr DS:[0x0029]
        ushort xchgOffset_100D_6FBD_1708D = (ushort)0x0029;
        byte temp_100D_6FBD_1708D = AL;
        AL = UInt8[DS, xchgOffset_100D_6FBD_1708D];
        UInt8[DS, xchgOffset_100D_6FBD_1708D] = unchecked((byte)temp_100D_6FBD_1708D);
        // 100D:6FC1 and AX,0xFCFC
        AX = Alu16.And(AX, (ushort)0xFCFC);
        // 100D:6FC4 sub AL,AH
        AL = Alu8.Sub(AL, AH);
        // 100D:6FC6 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:6FC8 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 100D:6FCA jne short 0x6FCD
        if (!(!ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:6FCA");
        }
    label_100D_6FCD_1709D_34432:
        CheckExternalEvents(cs1, 0x6FCD);
        // 100D:6FCD push SI
        Stack.Push16(SI);
        // 100D:6FCE mov SI,0x08AA
        SI = (ushort)0x08AA;
    label_100D_6FD1_170A1_34435:
        CheckExternalEvents(cs1, 0x6FD1);
        // 100D:6FD1 test byte ptr DS:[SI+3],0xA0
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xA0);
        // 100D:6FD5 jne short 0x6FDA
        if (!ZeroFlag)
        {
            goto label_100D_6FDA_170AA_34447;
        }
    label_100D_6FD7_170A7_34437:
        CheckExternalEvents(cs1, 0x6FD7);
        // 100D:6FD7 call near 0x6F93
        NearCall(cs1, 0x6FDA, troop_decrease_motivation);
    label_100D_6FDA_170AA_34447:
        CheckExternalEvents(cs1, 0x6FDA);
        // 100D:6FDA add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:6FDD cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:6FE1 jb short 0x6FD1
        if (CarryFlag)
        {
            goto label_100D_6FD1_170A1_34435;
        }
    label_100D_6FE3_170B3_34452:
        CheckExternalEvents(cs1, 0x6FE3);
        // 100D:6FE3 pop SI
        SI = Stack.Pop16();
        // 100D:6FE4 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_occupation_event_spice_mining(int loadOffset)
    {
    label_100D_6FE5_170B5_25134:
        CheckExternalEvents(cs1, 0x6FE5);
        // 100D:6FE5 call near 0x6E20
        NearCall(cs1, 0x6FE8, unknown_100D_6E20_16EF0);
    label_100D_6FE8_170B8_25141:
        CheckExternalEvents(cs1, 0x6FE8);
        // 100D:6FE8 test word ptr DS:[SI+0x10],0x0200
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0200);
        // 100D:6FED jne short 0x705C
        if (!ZeroFlag)
        {
            goto label_100D_705C_1712C_34851;
        }
    label_100D_6FEF_170BF_25144:
        CheckExternalEvents(cs1, 0x6FEF);
        // 100D:6FEF call near 0x6B96
        NearCall(cs1, 0x6FF2, troop_spice_mining_not_viable);
    label_100D_6FF2_170C2_25146:
        CheckExternalEvents(cs1, 0x6FF2);
        // 100D:6FF2 jae short 0x6FF7
        if (!CarryFlag)
        {
            goto label_100D_6FF7_170C7_25148;
        }
    label_100D_6FF4_170C4_28154:
        CheckExternalEvents(cs1, 0x6FF4);
        // 100D:6FF4 jmp near 0x707B
        goto label_100D_707B_1714B_28156;
    label_100D_6FF7_170C7_25148:
        CheckExternalEvents(cs1, 0x6FF7);
        // 100D:6FF7 call near 0x714C
        NearCall(cs1, 0x6FFA, troop_harvester_events);
    label_100D_6FFA_170CA_25155:
        CheckExternalEvents(cs1, 0x6FFA);
        // 100D:6FFA or word ptr DS:[SI+0x10],0x0100
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0100);
        // 100D:6FFF call near 0x708A
        NearCall(cs1, 0x7002, troop_update_harvest_rate);
    label_100D_7002_170D2_25158:
        CheckExternalEvents(cs1, 0x7002);
        // 100D:7002 push AX
        Stack.Push16(AX);
        // 100D:7003 mov DX,word ptr DS:[SI+0x0E]
        DX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:7006 add AX,DX
        AX = Alu16.Add(AX, DX);
        // 100D:7008 mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
        // 100D:700B xor AX,DX
        AX = Alu16.Xor(AX, DX);
        // 100D:700D and AX,0xFF80
        AX = Alu16.And(AX, (ushort)0xFF80);
        // 100D:7010 je short 0x7019
        if (ZeroFlag)
        {
            goto label_100D_7019_170E9_25166;
        }
    label_100D_7012_170E2_27990:
        CheckExternalEvents(cs1, 0x7012);
        // 100D:7012 mov AL,1
        AL = (byte)0x01;
        // 100D:7014 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:7016 call near 0x6EDD
        NearCall(cs1, 0x7019, troop_increase_spice_skill);
    label_100D_7019_170E9_25166:
        CheckExternalEvents(cs1, 0x7019);
        // 100D:7019 pop AX
        AX = Stack.Pop16();
        // 100D:701A push AX
        Stack.Push16(AX);
        // 100D:701B add AX,word ptr DS:[0x46E1]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x46E1]);
        // 100D:701F xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:7021 mov CX,0x000A
        CX = (ushort)0x000A;
        // 100D:7024 div CX
        ushort divisor_100D_7024_170F4 = CX;
        uint dividend_100D_7024_170F4 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_7024_170F4 = Alu16.Div(unchecked((uint)dividend_100D_7024_170F4), unchecked((ushort)divisor_100D_7024_170F4));
        AX = unchecked((ushort)quotient_100D_7024_170F4);
        DX = unchecked((ushort)(dividend_100D_7024_170F4 % unchecked((uint)divisor_100D_7024_170F4)));
        // 100D:7026 mov word ptr DS:[0x46E1],DX
        UInt16[DS, (ushort)0x46E1] = DX;
        // 100D:702A add word ptr DS:[0x00A0],AX
        UInt16[DS, (ushort)0x00A0] = Alu16.Add(UInt16[DS, (ushort)0x00A0], AX);
        // 100D:702E pop AX
        AX = Stack.Pop16();
        // 100D:702F add AL,byte ptr DS:[DI+0x13]
        AL = Alu8.Add(AL, UInt8[DS, (ushort)(DI + (sbyte)19)]);
        // 100D:7032 adc AH,0
        AH = Alu8.Adc(AH, (byte)0x00);
        // 100D:7035 mov CL,byte ptr DS:[DI+0x11]
        CL = UInt8[DS, (ushort)(DI + (sbyte)17)];
        // 100D:7038 div CL
        byte divisor_100D_7038_17108 = CL;
        ushort dividend_100D_7038_17108 = AX;
        byte quotient_100D_7038_17108 = Alu8.Div(unchecked((ushort)dividend_100D_7038_17108), unchecked((byte)divisor_100D_7038_17108));
        AL = unchecked((byte)quotient_100D_7038_17108);
        AH = unchecked((byte)(dividend_100D_7038_17108 % unchecked((ushort)divisor_100D_7038_17108)));
        // 100D:703A mov byte ptr DS:[DI+0x13],AH
        UInt8[DS, (ushort)(DI + (sbyte)19)] = AH;
        // 100D:703D mov AH,byte ptr DS:[DI+0x12]
        AH = UInt8[DS, (ushort)(DI + (sbyte)18)];
        // 100D:7040 and AH,0x0F
        AH = Alu8.And(AH, (byte)0x0F);
        // 100D:7043 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:7045 jbe short 0x7052
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_7052_17122_25185;
        }
    label_100D_7047_17117_28176:
        CheckExternalEvents(cs1, 0x7047);
        // 100D:7047 test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:704C je short 0x7052
        if (ZeroFlag)
        {
            goto label_100D_7052_17122_25185;
        }
    label_100D_704E_1711E_39673:
        CheckExternalEvents(cs1, 0x704E);
        // 100D:704E inc byte ptr DS:[0x46EC]
        UInt8[DS, (ushort)0x46EC] = Alu8.Inc(UInt8[DS, (ushort)0x46EC]);
    label_100D_7052_17122_25185:
        CheckExternalEvents(cs1, 0x7052);
        // 100D:7052 sub byte ptr DS:[DI+0x12],AL
        UInt8[DS, (ushort)(DI + (sbyte)18)] = Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)18)], AL);
        // 100D:7055 jae short 0x705B
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7055");
        }
    label_100D_705B_1712B_25188:
        CheckExternalEvents(cs1, 0x705B);
        // 100D:705B ret near
        return NearRet((ushort)0x0000);
    label_100D_705C_1712C_34851:
        CheckExternalEvents(cs1, 0x705C);
        // 100D:705C mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:705F mov AH,byte ptr DS:[SI]
        AH = UInt8[DS, SI];
        // 100D:7061 and AX,0x0F0F
        AX = Alu16.And(AX, (ushort)0x0F0F);
        // 100D:7064 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:7066 jne short 0x7074
        if (!ZeroFlag)
        {
            goto label_100D_7074_17144_34857;
        }
    label_100D_7068_17138_35050:
        CheckExternalEvents(cs1, 0x7068);
        // 100D:7068 and word ptr DS:[SI+0x10],0xFDFF
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0xFDFF);
        // 100D:706D call near 0x6B96
        NearCall(cs1, 0x7070, troop_spice_mining_not_viable);
    label_100D_7070_17140_35053:
        CheckExternalEvents(cs1, 0x7070);
        // 100D:7070 jb short 0x705B
        if (CarryFlag)
        {
            goto label_100D_705B_1712B_25188;
        }
    label_100D_7072_17142_35055:
        CheckExternalEvents(cs1, 0x7072);
        // 100D:7072 jmp short 0x6FFA
        goto label_100D_6FFA_170CA_25155;
    label_100D_7074_17144_34857:
        CheckExternalEvents(cs1, 0x7074);
        // 100D:7074 mov word ptr DS:[SI+0x0C],0
        UInt16[DS, (ushort)(SI + (sbyte)12)] = (ushort)0x0000;
        // 100D:7079 jmp short 0x7085
        return troop_make_stop_working(0x0000);
    label_100D_707B_1714B_28156:
        CheckExternalEvents(cs1, 0x707B);
        // 100D:707B mov word ptr DS:[SI+0x0C],0
        UInt16[DS, (ushort)(SI + (sbyte)12)] = (ushort)0x0000;
        // 100D:7080 mov word ptr DS:[SI+0x0E],0
        UInt16[DS, (ushort)(SI + (sbyte)14)] = (ushort)0x0000;
        return troop_make_stop_working(0x0000);
    }

    public virtual Action troop_make_stop_working(int loadOffset)
    {
    label_100D_7085_17155_28159:
        CheckExternalEvents(cs1, 0x7085);
        // 100D:7085 or byte ptr DS:[SI+3],0x10
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x10);
        // 100D:7089 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_update_harvest_rate(int loadOffset)
    {
    label_100D_708A_1715A_24702:
        CheckExternalEvents(cs1, 0x708A);
        // 100D:708A call near 0x6EFD
        NearCall(cs1, 0x708D, troop_compute_motivation_modifier);
    label_100D_708D_1715D_24704:
        CheckExternalEvents(cs1, 0x708D);
        // 100D:708D mov AH,byte ptr DS:[SI+0x16]
        AH = UInt8[DS, (ushort)(SI + (sbyte)22)];
        // 100D:7090 and AH,0xF0
        AH = Alu8.And(AH, (byte)0xF0);
        // 100D:7093 add AL,AH
        AL = Alu8.Add(AL, AH);
        // 100D:7095 mul byte ptr DS:[SI+0x1A]
        ushort result_100D_7095_17165 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)UInt8[DS, (ushort)(SI + (sbyte)26)])));
        AH = unchecked((byte)(result_100D_7095_17165 >> 8));
        AL = unchecked((byte)result_100D_7095_17165);
        // 100D:7098 test byte ptr DS:[SI+0x19],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x80);
        // 100D:709C jne short 0x70A2
        if (!ZeroFlag)
        {
            goto label_100D_70A2_17172_24714;
        }
    label_100D_709E_1716E_24711:
        CheckExternalEvents(cs1, 0x709E);
        // 100D:709E shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:70A0 shr AX,1
        AX = Alu16.Shr(AX, 1);
    label_100D_70A2_17172_24714:
        CheckExternalEvents(cs1, 0x70A2);
        // 100D:70A2 mov AL,byte ptr DS:[DI+0x12]
        AL = UInt8[DS, (ushort)(DI + (sbyte)18)];
        // 100D:70A5 and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 100D:70A7 inc AX
        AX = Alu16.Inc(AX);
        // 100D:70A8 mul AH
        ushort result_100D_70A8_17178 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_100D_70A8_17178 >> 8));
        AL = unchecked((byte)result_100D_70A8_17178);
        // 100D:70AA xchg AL,AH
        byte temp_100D_70AA_1717A = AL;
        AL = AH;
        AH = unchecked((byte)temp_100D_70AA_1717A);
        // 100D:70AC rol AX,1
        AX = Alu16.Rol(AX, unchecked((byte)1));
        // 100D:70AE and AH,1
        AH = Alu8.And(AH, (byte)0x01);
        // 100D:70B1 mov DX,AX
        DX = AX;
        // 100D:70B3 xchg DX,word ptr DS:[SI+0x0C]
        ushort xchgOffset_100D_70B3_17183 = unchecked((ushort)(SI + (sbyte)12));
        ushort temp_100D_70B3_17183 = DX;
        DX = UInt16[DS, xchgOffset_100D_70B3_17183];
        UInt16[DS, xchgOffset_100D_70B3_17183] = unchecked((ushort)temp_100D_70B3_17183);
        // 100D:70B6 sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 100D:70B8 je short 0x70CB
        if (ZeroFlag)
        {
            goto label_100D_70CB_1719B_24733;
        }
    label_100D_70BA_1718A_24725:
        CheckExternalEvents(cs1, 0x70BA);
        // 100D:70BA mov BL,8
        BL = (byte)0x08;
        // 100D:70BC jb short 0x70C0
        if (CarryFlag)
        {
            goto label_100D_70C0_17190_24728;
        }
    label_100D_70BE_1718E_28181:
        CheckExternalEvents(cs1, 0x70BE);
        // 100D:70BE mov BL,4
        BL = (byte)0x04;
    label_100D_70C0_17190_24728:
        CheckExternalEvents(cs1, 0x70C0);
        // 100D:70C0 mov CX,word ptr DS:[SI+0x10]
        CX = UInt16[DS, (ushort)(SI + (sbyte)16)];
        // 100D:70C3 and CL,0xF3
        CL = Alu8.And(CL, (byte)0xF3);
        // 100D:70C6 or CL,BL
        CL = Alu8.Or(CL, BL);
        // 100D:70C8 mov word ptr DS:[SI+0x10],CX
        UInt16[DS, (ushort)(SI + (sbyte)16)] = CX;
    label_100D_70CB_1719B_24733:
        CheckExternalEvents(cs1, 0x70CB);
        // 100D:70CB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action troop_occupation_event_spice_prospecting(int loadOffset)
    {
    entrydispatcher:
    label_100D_70CC_1719C_30179:
        CheckExternalEvents(cs1, 0x70CC);
        // 100D:70CC mov AL,byte ptr DS:[DI+0x0A]
        AL = UInt8[DS, (ushort)(DI + (sbyte)10)];
        // 100D:70CF test AL,2
        Alu8.And(AL, (byte)0x02);
        // 100D:70D1 jne short 0x710F
        if (!ZeroFlag)
        {
            goto label_100D_710F_171DF_30215;
        }
    label_100D_70D3_171A3_30183:
        CheckExternalEvents(cs1, 0x70D3);
        // 100D:70D3 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:70D5 jne short 0x7126
        if (!ZeroFlag)
        {
            goto label_100D_7126_171F6_30590;
        }
    label_100D_70D7_171A7_30186:
        CheckExternalEvents(cs1, 0x70D7);
        // 100D:70D7 call near 0x6B8A
        NearCall(cs1, 0x70DA, unknown_100D_6B8A_16C5A);
    label_100D_70DA_171AA_30188:
        CheckExternalEvents(cs1, 0x70DA);
        // 100D:70DA jb short 0x710F
        if (CarryFlag)
        {
            goto label_100D_710F_171DF_30215;
        }
    label_100D_70DC_171AC_30190:
        CheckExternalEvents(cs1, 0x70DC);
        // 100D:70DC mov AX,word ptr DS:[SI+0x0C]
        AX = UInt16[DS, (ushort)(SI + (sbyte)12)];
        // 100D:70DF or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:70E1 jne short 0x70F7
        if (!ZeroFlag)
        {
            goto label_100D_70F7_171C7_30203;
        }
    label_100D_70E3_171B3_30194:
        CheckExternalEvents(cs1, 0x70E3);
        // 100D:70E3 mov AL,byte ptr DS:[DI+0x11]
        AL = UInt8[DS, (ushort)(DI + (sbyte)17)];
        // 100D:70E6 mov CL,4
        CL = (byte)0x04;
        // 100D:70E8 shl AX,CL
        AX = Alu16.Shl(AX, unchecked((int)CL));
        // 100D:70EA mov CL,byte ptr DS:[SI+0x15]
        CL = UInt8[DS, (ushort)(SI + (sbyte)21)];
        // 100D:70ED add CL,byte ptr DS:[SI+0x16]
        CL = Alu8.Add(CL, UInt8[DS, (ushort)(SI + (sbyte)22)]);
        // 100D:70F0 div CL
        byte divisor_100D_70F0_171C0 = CL;
        ushort dividend_100D_70F0_171C0 = AX;
        byte quotient_100D_70F0_171C0 = Alu8.Div(unchecked((ushort)dividend_100D_70F0_171C0), unchecked((byte)divisor_100D_70F0_171C0));
        AL = unchecked((byte)quotient_100D_70F0_171C0);
        AH = unchecked((byte)(dividend_100D_70F0_171C0 % unchecked((ushort)divisor_100D_70F0_171C0)));
        // 100D:70F2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:70F4 mov word ptr DS:[SI+0x0C],AX
        UInt16[DS, (ushort)(SI + (sbyte)12)] = AX;
    label_100D_70F7_171C7_30203:
        CheckExternalEvents(cs1, 0x70F7);
        // 100D:70F7 mov CX,word ptr DS:[2]
        CX = UInt16[DS, (ushort)0x0002];
        // 100D:70FB sub CX,word ptr DS:[SI+0x0A]
        CX = Alu16.Sub(CX, UInt16[DS, (ushort)(SI + (sbyte)10)]);
        // 100D:70FE cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:7100 jbe short 0x7110
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_7110_171E0_30582;
        }
    label_100D_7102_171D2_30207:
        CheckExternalEvents(cs1, 0x7102);
        // 100D:7102 jcxz short 0x710F
        if (CX == (ushort)0x0000)
        {
            goto label_100D_710F_171DF_30215;
        }
    label_100D_7104_171D4_30209:
        CheckExternalEvents(cs1, 0x7104);
        // 100D:7104 mov DX,0x0064
        DX = (ushort)0x0064;
        // 100D:7107 xchg CX,AX
        ushort temp_100D_7107_171D7 = CX;
        CX = AX;
        AX = unchecked((ushort)temp_100D_7107_171D7);
        // 100D:7108 mul DX
        uint result_100D_7108_171D8 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_100D_7108_171D8 >> 16));
        AX = unchecked((ushort)result_100D_7108_171D8);
        // 100D:710A div CX
        ushort divisor_100D_710A_171DA = CX;
        uint dividend_100D_710A_171DA = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_710A_171DA = Alu16.Div(unchecked((uint)dividend_100D_710A_171DA), unchecked((ushort)divisor_100D_710A_171DA));
        AX = unchecked((ushort)quotient_100D_710A_171DA);
        DX = unchecked((ushort)(dividend_100D_710A_171DA % unchecked((uint)divisor_100D_710A_171DA)));
        // 100D:710C mov word ptr DS:[SI+0x0E],AX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = AX;
    label_100D_710F_171DF_30215:
        CheckExternalEvents(cs1, 0x710F);
        // 100D:710F ret near
        return NearRet((ushort)0x0000);
    label_100D_7110_171E0_30582:
        CheckExternalEvents(cs1, 0x7110);
        // 100D:7110 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:7112 mov AL,2
        AL = (byte)0x02;
        // 100D:7114 call near 0x6EDD
        NearCall(cs1, 0x7117, troop_increase_spice_skill);
    label_100D_7117_171E7_30586:
        CheckExternalEvents(cs1, 0x7117);
        // 100D:7117 or byte ptr DS:[DI+0x0A],0x40
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.Or(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x40);
        // 100D:711B test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:7120 je short 0x7126
        if (ZeroFlag)
        {
            goto label_100D_7126_171F6_30590;
        }
    label_100D_7122_171F2_40973:
        CheckExternalEvents(cs1, 0x7122);
        // 100D:7122 inc byte ptr DS:[0x46EC]
        UInt8[DS, (ushort)0x46EC] = Alu8.Inc(UInt8[DS, (ushort)0x46EC]);
    label_100D_7126_171F6_30590:
        CheckExternalEvents(cs1, 0x7126);
        // 100D:7126 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:7129 push AX
        Stack.Push16(AX);
        // 100D:712A call near 0x6B8A
        NearCall(cs1, 0x712D, unknown_100D_6B8A_16C5A);
    label_100D_712D_171FD_30594:
        CheckExternalEvents(cs1, 0x712D);
        // 100D:712D mov word ptr DS:[SI+0x0E],0x0064
        UInt16[DS, (ushort)(SI + (sbyte)14)] = (ushort)0x0064;
        // 100D:7132 pop AX
        AX = Stack.Pop16();
        // 100D:7133 cmp SI,word ptr DS:[0x46EF]
        Alu16.Sub(SI, UInt16[DS, (ushort)0x46EF]);
        // 100D:7137 je short 0x710F
        if (ZeroFlag)
        {
            goto label_100D_710F_171DF_30215;
        }
    label_100D_7139_17209_30599:
        CheckExternalEvents(cs1, 0x7139);
        // 100D:7139 cmp word ptr DS:[0x11D3],0
        Alu16.Sub(UInt16[DS, (ushort)0x11D3], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:713E jne short 0x7149
        if (!ZeroFlag)
        {
            goto label_100D_7149_17219_30602;
        }
    label_100D_7140_17210_31400:
        CheckExternalEvents(cs1, 0x7140);
        // 100D:7140 test AL,0x10
        Alu8.And(AL, (byte)0x10);
        // 100D:7142 jne short 0x710F
        if (!ZeroFlag)
        {
            goto label_100D_710F_171DF_30215;
        }
    label_100D_7144_17214_33677:
        CheckExternalEvents(cs1, 0x7144);
        // 100D:7144 mov AL,0x0E
        AL = (byte)0x0E;
        // 100D:7146 jmp short 0x71B2
        return queue_vision_message_f00(0x0000);
    label_100D_7149_17219_30602:
        CheckExternalEvents(cs1, 0x7149);
        // 100D:7149 jmp near 0x84A6
        if (JumpDispatcher.Jump(troop_issue_move_order, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action troop_harvester_events(int loadOffset)
    {
    label_100D_714C_1721C_25150:
        CheckExternalEvents(cs1, 0x714C);
        // 100D:714C test byte ptr DS:[0x000A],1
        Alu8.And(UInt8[DS, (ushort)0x000A], (byte)0x01);
        // 100D:7151 je short 0x71BB
        if (ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7153_17223_32903:
        CheckExternalEvents(cs1, 0x7153);
        // 100D:7153 test byte ptr DS:[SI+0x19],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x80);
        // 100D:7157 je short 0x71BB
        if (ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7159_17229_32906:
        CheckExternalEvents(cs1, 0x7159);
        // 100D:7159 mov AX,word ptr DS:[2]
        AX = UInt16[DS, (ushort)0x0002];
        // 100D:715C mov AH,byte ptr DS:[SI]
        AH = UInt8[DS, SI];
        // 100D:715E and AX,0x0F0F
        AX = Alu16.And(AX, (ushort)0x0F0F);
        // 100D:7161 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:7163 jne short 0x71BB
        if (!ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7165_17235_33369:
        CheckExternalEvents(cs1, 0x7165);
        // 100D:7165 call near 0x71BC
        NearCall(cs1, 0x7168, troop_randomize_saboteurs);
    label_100D_7168_17238_33376:
        CheckExternalEvents(cs1, 0x7168);
        // 100D:7168 call near 0xE3CC
        NearCall(cs1, 0x716B, rand);
    label_100D_716B_1723B_33378:
        CheckExternalEvents(cs1, 0x716B);
        // 100D:716B mov AL,byte ptr DS:[DI]
        AL = UInt8[DS, DI];
        // 100D:716D mov BX,0x1141
        BX = (ushort)0x1141;
        // 100D:7170 xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 100D:7171 cmp AL,AH
        Alu8.Sub(AL, AH);
        // 100D:7173 jb short 0x71BB
        if (CarryFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7175_17245_33541:
        CheckExternalEvents(cs1, 0x7175);
        // 100D:7175 or word ptr DS:[SI+0x10],0x4000
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x4000);
        // 100D:717A test byte ptr DS:[SI+0x19],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x40);
        // 100D:717E jne short 0x71BB
        if (!ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7180_17250_33545:
        CheckExternalEvents(cs1, 0x7180);
        // 100D:7180 and AH,3
        AH = Alu8.And(AH, (byte)0x03);
        // 100D:7183 je short 0x71BB
        if (ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
    label_100D_7185_17255_33548:
        CheckExternalEvents(cs1, 0x7185);
        // 100D:7185 cmp AH,2
        Alu8.Sub(AH, (byte)0x02);
        // 100D:7188 ja short 0x71A4
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_71A4_17274_33660;
        }
    label_100D_718A_1725A_33551:
        CheckExternalEvents(cs1, 0x718A);
        // 100D:718A je short 0x719C
        if (ZeroFlag)
        {
            return troop_make_harvester_damaged(0x0000);
        }
    label_100D_718C_1725C_33553:
        CheckExternalEvents(cs1, 0x718C);
        // 100D:718C or word ptr DS:[SI+0x10],0x2000
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x2000);
        // 100D:7191 sub byte ptr DS:[SI+0x1A],2
        UInt8[DS, (ushort)(SI + (sbyte)26)] = Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)26)], (byte)0x02);
        // 100D:7195 ja short 0x71BB
        if (!CarryFlag && !ZeroFlag)
        {
            return unknown_100D_71BB_1728B(0x0000);
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7195");
        }
    label_100D_71A4_17274_33660:
        CheckExternalEvents(cs1, 0x71A4);
        // 100D:71A4 or word ptr DS:[SI+0x10],0x1000
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x1000);
        // 100D:71A9 and byte ptr DS:[SI+0x19],0x7F
        UInt8[DS, (ushort)(SI + (sbyte)25)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x7F);
        // 100D:71AD dec byte ptr DS:[DI+0x14]
        UInt8[DS, (ushort)(DI + (sbyte)20)] = Alu8.Dec(UInt8[DS, (ushort)(DI + (sbyte)20)]);
        // 100D:71B0 mov AL,6
        AL = (byte)0x06;
        return queue_vision_message_f00(0x0000);
    }

    public virtual Action troop_make_harvester_damaged(int loadOffset)
    {
    label_100D_719C_1726C_34842:
        CheckExternalEvents(cs1, 0x719C);
        // 100D:719C or word ptr DS:[SI+0x10],0x0200
        UInt16[DS, (ushort)(SI + (sbyte)16)] = Alu16.Or(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0200);
        // 100D:71A1 jmp near 0x7085
        return troop_make_stop_working(0x0000);
    }
}
