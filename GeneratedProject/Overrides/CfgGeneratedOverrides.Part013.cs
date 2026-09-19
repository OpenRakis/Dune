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
    public virtual Action unknown_100D_7F11_17FE1(int loadOffset)
    {
    label_100D_7F11_17FE1_27780:
        CheckExternalEvents(cs1, 0x7F11);
        // 100D:7F11 push SI
        Stack.Push16(SI);
        // 100D:7F12 mov SI,0x470B
        SI = (ushort)0x470B;
        // 100D:7F15 std
        DirectionFlag = true;
        // 100D:7F16 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_100D_7F18_17FE8_27785:
        CheckExternalEvents(cs1, 0x7F18);
        // 100D:7F18 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:7F19 ror AX,1
        AX = Alu16.Ror(AX, 1);
        // 100D:7F1B cmp SI,0x4705
        Alu16.Sub(SI, (ushort)0x4705);
        // 100D:7F1F jae short 0x7F18
        if (!CarryFlag)
        {
            goto label_100D_7F18_17FE8_27785;
        }
    label_100D_7F21_17FF1_27790:
        CheckExternalEvents(cs1, 0x7F21);
        // 100D:7F21 pop SI
        SI = Stack.Pop16();
        // 100D:7F22 cld
        DirectionFlag = false;
        // 100D:7F23 mov byte ptr DS:[SI+0x19],AH
        UInt8[DS, (ushort)(SI + (sbyte)25)] = AH;
        // 100D:7F26 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7F27_17FF7(int loadOffset)
    {
    label_100D_7F27_17FF7_13750:
        CheckExternalEvents(cs1, 0x7F27);
        // 100D:7F27 mov BX,0x46FE
        BX = (ushort)0x46FE;
        return unknown_100D_7F2A_17FFA(0x0000);
    }

    public virtual Action unknown_100D_7F2A_17FFA(int loadOffset)
    {
    label_100D_7F2A_17FFA_13752:
        CheckExternalEvents(cs1, 0x7F2A);
        // 100D:7F2A push DI
        Stack.Push16(DI);
        // 100D:7F2B push DS
        Stack.Push16(DS);
        // 100D:7F2C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:7F2D mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:7F30 lea SI,DI+0x14
        SI = unchecked((ushort)(DI + (sbyte)20));
        // 100D:7F33 mov DI,BX
        DI = BX;
        // 100D:7F35 mov CX,7
        CX = (ushort)0x0007;
        // 100D:7F38 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_100D_7F3A_1800A_13760:
        CheckExternalEvents(cs1, 0x7F3A);
        // 100D:7F3A or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:7F3C je short 0x7F5D
        if (ZeroFlag)
        {
            goto label_100D_7F5D_1802D_13762;
        }
    label_100D_7F3E_1800E_22663:
        CheckExternalEvents(cs1, 0x7F3E);
        // 100D:7F3E call near 0x6906
        NearCall(cs1, 0x7F41, unknown_100D_6906_169D6);
    label_100D_7F41_18011_22665:
        CheckExternalEvents(cs1, 0x7F41);
        // 100D:7F41 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7F44 mov DI,BX
        DI = BX;
        // 100D:7F46 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F48 jae short 0x7F51
        if (!CarryFlag)
        {
            goto label_100D_7F51_18021_22670;
        }
    label_100D_7F4A_1801A_27826:
        CheckExternalEvents(cs1, 0x7F4A);
        // 100D:7F4A sub byte ptr DS:[DI],1
        UInt8[DS, DI] = Alu8.Sub(UInt8[DS, DI], (byte)0x01);
        // 100D:7F4D jae short 0x7F51
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7F4D");
        }
    label_100D_7F51_18021_22670:
        CheckExternalEvents(cs1, 0x7F51);
        // 100D:7F51 inc DI
        DI = Alu16.Inc(DI);
        // 100D:7F52 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F54 jb short 0x7F4A
        if (CarryFlag)
        {
            goto label_100D_7F4A_1801A_27826;
        }
    label_100D_7F56_18026_22674:
        CheckExternalEvents(cs1, 0x7F56);
        // 100D:7F56 jne short 0x7F51
        if (!ZeroFlag)
        {
            goto label_100D_7F51_18021_22670;
        }
    label_100D_7F58_18028_22676:
        CheckExternalEvents(cs1, 0x7F58);
        // 100D:7F58 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:7F5B jmp short 0x7F3A
        goto label_100D_7F3A_1800A_13760;
    label_100D_7F5D_1802D_13762:
        CheckExternalEvents(cs1, 0x7F5D);
        // 100D:7F5D pop DI
        DI = Stack.Pop16();
        // 100D:7F5E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7F5F_1802F(int loadOffset)
    {
    label_100D_7F5F_1802F_29914:
        CheckExternalEvents(cs1, 0x7F5F);
        // 100D:7F5F mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7F62 push DI
        Stack.Push16(DI);
        // 100D:7F63 add DI,0x0014
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 100D:7F66 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F68 jae short 0x7F6C
        if (!CarryFlag)
        {
            goto label_100D_7F6C_1803C_29920;
        }
    label_100D_7F6A_1803A_31398:
        CheckExternalEvents(cs1, 0x7F6A);
        // 100D:7F6A inc byte ptr DS:[DI]
        UInt8[DS, DI] = Alu8.Inc(UInt8[DS, DI]);
    label_100D_7F6C_1803C_29920:
        CheckExternalEvents(cs1, 0x7F6C);
        // 100D:7F6C inc DI
        DI = Alu16.Inc(DI);
        // 100D:7F6D shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F6F jb short 0x7F6A
        if (CarryFlag)
        {
            goto label_100D_7F6A_1803A_31398;
        }
    label_100D_7F71_18041_29924:
        CheckExternalEvents(cs1, 0x7F71);
        // 100D:7F71 jne short 0x7F6C
        if (!ZeroFlag)
        {
            goto label_100D_7F6C_1803C_29920;
        }
    label_100D_7F73_18043_29926:
        CheckExternalEvents(cs1, 0x7F73);
        // 100D:7F73 pop DI
        DI = Stack.Pop16();
        // 100D:7F74 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7F75_18045(int loadOffset)
    {
    label_100D_7F75_18045_29518:
        CheckExternalEvents(cs1, 0x7F75);
        // 100D:7F75 mov AL,byte ptr DS:[SI+0x19]
        AL = UInt8[DS, (ushort)(SI + (sbyte)25)];
        // 100D:7F78 push DI
        Stack.Push16(DI);
        // 100D:7F79 add DI,0x0014
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 100D:7F7C shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F7E jae short 0x7F87
        if (!CarryFlag)
        {
            goto label_100D_7F87_18057_29524;
        }
    label_100D_7F80_18050_33449:
        CheckExternalEvents(cs1, 0x7F80);
        // 100D:7F80 sub byte ptr DS:[DI],1
        UInt8[DS, DI] = Alu8.Sub(UInt8[DS, DI], (byte)0x01);
        // 100D:7F83 jae short 0x7F87
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:7F83");
        }
    label_100D_7F87_18057_29524:
        CheckExternalEvents(cs1, 0x7F87);
        // 100D:7F87 inc DI
        DI = Alu16.Inc(DI);
        // 100D:7F88 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:7F8A jb short 0x7F80
        if (CarryFlag)
        {
            goto label_100D_7F80_18050_33449;
        }
    label_100D_7F8C_1805C_29528:
        CheckExternalEvents(cs1, 0x7F8C);
        // 100D:7F8C jne short 0x7F87
        if (!ZeroFlag)
        {
            goto label_100D_7F87_18057_29524;
        }
    label_100D_7F8E_1805E_29530:
        CheckExternalEvents(cs1, 0x7F8E);
        // 100D:7F8E pop DI
        DI = Stack.Pop16();
        // 100D:7F8F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_7F90_18060(int loadOffset)
    {
    label_100D_7F90_18060_31208:
        CheckExternalEvents(cs1, 0x7F90);
        // 100D:7F90 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:7F93 push DI
        Stack.Push16(DI);
        // 100D:7F94 push word ptr DS:[DI+4]
        Stack.Push16(UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:7F97 push word ptr DS:[DI+2]
        Stack.Push16(UInt16[DS, (ushort)(DI + (sbyte)2)]);
        // 100D:7F9A mov BP,SP
        BP = SP;
        // 100D:7F9C mov word ptr DS:[0x470C],0xFFFF
        UInt16[DS, (ushort)0x470C] = (ushort)0xFFFF;
        // 100D:7FA2 mov DI,0x0138
        DI = (ushort)0x0138;
    label_100D_7FA5_18075_31216:
        CheckExternalEvents(cs1, 0x7FA5);
        // 100D:7FA5 cmp word ptr DS:[DI],-1
        Alu16.Sub(UInt16[DS, DI], unchecked((ushort)unchecked((short)(sbyte)-1)));
        // 100D:7FA8 je short 0x8014
        if (ZeroFlag)
        {
            goto label_100D_8014_180E4_31293;
        }
    label_100D_7FAA_1807A_31218:
        CheckExternalEvents(cs1, 0x7FAA);
        // 100D:7FAA test byte ptr DS:[DI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x80);
        // 100D:7FAE jne short 0x800F
        if (!ZeroFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FB0_18080_31225:
        CheckExternalEvents(cs1, 0x7FB0);
        // 100D:7FB0 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:7FB4 jae short 0x800F
        if (!CarryFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FB6_18086_31228:
        CheckExternalEvents(cs1, 0x7FB6);
        // 100D:7FB6 cmp DI,word ptr SS:[BP+4]
        Alu16.Sub(DI, UInt16[SS, (ushort)(BP + (sbyte)4)]);
        // 100D:7FB9 je short 0x800F
        if (ZeroFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FBB_1808B_31231:
        CheckExternalEvents(cs1, 0x7FBB);
        // 100D:7FBB mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:7FBE sub DX,word ptr SS:[BP]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 100D:7FC1 jns short 0x7FC5
        if (!SignFlag)
        {
            goto label_100D_7FC5_18095_31237;
        }
    label_100D_7FC3_18093_31235:
        CheckExternalEvents(cs1, 0x7FC3);
        // 100D:7FC3 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_100D_7FC5_18095_31237:
        CheckExternalEvents(cs1, 0x7FC5);
        // 100D:7FC5 mov AX,word ptr DS:[DI+4]
        AX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:7FC8 sub AX,word ptr SS:[BP+2]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)2)]);
        // 100D:7FCB jns short 0x7FCF
        if (!SignFlag)
        {
            goto label_100D_7FCF_1809F_31240;
        }
    label_100D_7FCD_1809D_31371:
        CheckExternalEvents(cs1, 0x7FCD);
        // 100D:7FCD neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_7FCF_1809F_31240:
        CheckExternalEvents(cs1, 0x7FCF);
        // 100D:7FCF mov DL,DH
        DL = DH;
        // 100D:7FD1 xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 100D:7FD3 cmp DL,AL
        Alu8.Sub(DL, AL);
        // 100D:7FD5 jae short 0x7FD9
        if (!CarryFlag)
        {
            goto label_100D_7FD9_180A9_31247;
        }
    label_100D_7FD7_180A7_31245:
        CheckExternalEvents(cs1, 0x7FD7);
        // 100D:7FD7 mov DX,AX
        DX = AX;
    label_100D_7FD9_180A9_31247:
        CheckExternalEvents(cs1, 0x7FD9);
        // 100D:7FD9 cmp DL,0x32
        Alu8.Sub(DL, (byte)0x32);
        // 100D:7FDC jae short 0x800F
        if (!CarryFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FDE_180AE_31249:
        CheckExternalEvents(cs1, 0x7FDE);
        // 100D:7FDE cmp byte ptr DS:[DI+8],0x21
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x21);
        // 100D:7FE2 jb short 0x7FE8
        if (CarryFlag)
        {
            goto label_100D_7FE8_180B8_31252;
        }
    label_100D_7FE4_180B4_34692:
        CheckExternalEvents(cs1, 0x7FE4);
        // 100D:7FE4 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 100D:7FE6 shr DX,1
        DX = Alu16.Shr(DX, 1);
    label_100D_7FE8_180B8_31252:
        CheckExternalEvents(cs1, 0x7FE8);
        // 100D:7FE8 cmp DX,word ptr DS:[0x470C]
        Alu16.Sub(DX, UInt16[DS, (ushort)0x470C]);
        // 100D:7FEC jae short 0x800F
        if (!CarryFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FEE_180BE_31255:
        CheckExternalEvents(cs1, 0x7FEE);
        // 100D:7FEE push BX
        Stack.Push16(BX);
        // 100D:7FEF mov BX,0x4C60
        BX = (ushort)0x4C60;
        // 100D:7FF2 call near 0x7F2A
        NearCall(cs1, 0x7FF5, unknown_100D_7F2A_17FFA);
    label_100D_7FF5_180C5_31260:
        CheckExternalEvents(cs1, 0x7FF5);
        // 100D:7FF5 pop BX
        BX = Stack.Pop16();
        // 100D:7FF6 cmp byte ptr DS:[BX+0x4C60],0
        Alu8.Sub(UInt8[DS, (ushort)(BX + (short)19552)], (byte)0x00);
        // 100D:7FFB je short 0x800F
        if (ZeroFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_7FFD_180CD_31266:
        CheckExternalEvents(cs1, 0x7FFD);
        // 100D:7FFD call near 0x8018
        NearCall(cs1, 0x8000, unknown_100D_8018_180E8);
    label_100D_8000_180D0_31287:
        CheckExternalEvents(cs1, 0x8000);
        // 100D:8000 cmp byte ptr DS:[BX+0x4C60],0
        Alu8.Sub(UInt8[DS, (ushort)(BX + (short)19552)], (byte)0x00);
        // 100D:8005 je short 0x800F
        if (ZeroFlag)
        {
            goto label_100D_800F_180DF_31221;
        }
    label_100D_8007_180D7_31290:
        CheckExternalEvents(cs1, 0x8007);
        // 100D:8007 mov word ptr DS:[0x470C],DX
        UInt16[DS, (ushort)0x470C] = DX;
        // 100D:800B mov word ptr DS:[0x470E],DI
        UInt16[DS, (ushort)0x470E] = DI;
    label_100D_800F_180DF_31221:
        CheckExternalEvents(cs1, 0x800F);
        // 100D:800F add DI,0x001C
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)28)));
        // 100D:8012 jmp short 0x7FA5
        goto label_100D_7FA5_18075_31216;
    label_100D_8014_180E4_31293:
        CheckExternalEvents(cs1, 0x8014);
        // 100D:8014 add SP,6
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:8017 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8018_180E8(int loadOffset)
    {
    label_100D_8018_180E8_31268:
        CheckExternalEvents(cs1, 0x8018);
        // 100D:8018 mov SI,0x088F
        SI = (ushort)0x088F;
    label_100D_801B_180EB_31270:
        CheckExternalEvents(cs1, 0x801B);
        // 100D:801B add SI,0x001B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)27)));
        // 100D:801E cmp SI,0x0FBB
        Alu16.Sub(SI, (ushort)0x0FBB);
        // 100D:8022 jae short 0x804C
        if (!CarryFlag)
        {
            goto label_100D_804C_1811C_31282;
        }
    label_100D_8024_180F4_31273:
        CheckExternalEvents(cs1, 0x8024);
        // 100D:8024 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:8027 test AL,0x40
        Alu8.And(AL, (byte)0x40);
        // 100D:8029 je short 0x801B
        if (ZeroFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
    label_100D_802B_180FB_31278:
        CheckExternalEvents(cs1, 0x802B);
        // 100D:802B and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:802D cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:802F jne short 0x801B
        if (!ZeroFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
    label_100D_8031_18101_31373:
        CheckExternalEvents(cs1, 0x8031);
        // 100D:8031 cmp DI,word ptr DS:[SI+4]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:8034 jne short 0x801B
        if (!ZeroFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
    label_100D_8036_18106_33452:
        CheckExternalEvents(cs1, 0x8036);
        // 100D:8036 cmp DI,word ptr DS:[SI+0x0C]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)12)]);
        // 100D:8039 je short 0x801B
        if (ZeroFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
    label_100D_803B_1810B_33455:
        CheckExternalEvents(cs1, 0x803B);
        // 100D:803B cmp BL,byte ptr DS:[SI+0x0E]
        Alu8.Sub(BL, UInt8[DS, (ushort)(SI + (sbyte)14)]);
        // 100D:803E jne short 0x801B
        if (!ZeroFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
    label_100D_8040_18110_33458:
        CheckExternalEvents(cs1, 0x8040);
        // 100D:8040 dec byte ptr DS:[BX+0x4C60]
        UInt8[DS, (ushort)(BX + (short)19552)] = Alu8.Dec(UInt8[DS, (ushort)(BX + (short)19552)]);
        // 100D:8044 jns short 0x801B
        if (!SignFlag)
        {
            goto label_100D_801B_180EB_31270;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8044");
        }
    label_100D_804C_1811C_31282:
        CheckExternalEvents(cs1, 0x804C);
        // 100D:804C cmp DI,word ptr DS:[0x1150]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x1150]);
        // 100D:8050 jne short 0x8063
        if (!ZeroFlag)
        {
            goto label_100D_8063_18133_31285;
        }
    label_100D_8052_18122_33443:
        CheckExternalEvents(cs1, 0x8052);
        // 100D:8052 cmp byte ptr DS:[0x002A],0x50
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x50);
        // 100D:8057 jae short 0x8063
        if (!CarryFlag)
        {
            goto label_100D_8063_18133_31285;
        }
    label_100D_8059_18129_33446:
        CheckExternalEvents(cs1, 0x8059);
        // 100D:8059 dec byte ptr DS:[0x4C61]
        UInt8[DS, (ushort)0x4C61] = Alu8.Dec(UInt8[DS, (ushort)0x4C61]);
        // 100D:805D jns short 0x8063
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:805D");
        }
    label_100D_8063_18133_31285:
        CheckExternalEvents(cs1, 0x8063);
        // 100D:8063 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_80AC_1817C(int loadOffset)
    {
    label_100D_80AC_1817C_29095:
        CheckExternalEvents(cs1, 0x80AC);
        // 100D:80AC mov BP,0x2136
        BP = (ushort)0x2136;
        // 100D:80AF and byte ptr SS:[BP+3],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)3)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0xBF);
        // 100D:80B3 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:80B5 mov AL,byte ptr DS:[0x4738]
        AL = UInt8[DS, (ushort)0x4738];
        // 100D:80B8 dec AL
        AL = Alu8.Dec(AL);
        // 100D:80BA cmp AL,2
        Alu8.Sub(AL, (byte)0x02);
        // 100D:80BC jb short 0x80C3
        if (CarryFlag)
        {
            goto label_100D_80C3_18193_29106;
        }
    label_100D_80BE_1818E_29103:
        CheckExternalEvents(cs1, 0x80BE);
        // 100D:80BE or byte ptr SS:[BP+3],0x40
        UInt8[SS, (ushort)(BP + (sbyte)3)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)3)], (byte)0x40);
        // 100D:80C2 inc CX
        CX = Alu16.Inc(CX);
    label_100D_80C3_18193_29106:
        CheckExternalEvents(cs1, 0x80C3);
        // 100D:80C3 mov BX,0x824D
        BX = (ushort)0x824D;
        // 100D:80C6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_80C8_18198(int loadOffset)
    {
    label_100D_80C8_18198_32112:
        CheckExternalEvents(cs1, 0x80C8);
        // 100D:80C8 mov byte ptr DS:[0x4738],0
        UInt8[DS, (ushort)0x4738] = (byte)0x00;
        // 100D:80CD xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 100D:80CF mov word ptr DS:[0x4718],AX
        UInt16[DS, (ushort)0x4718] = AX;
        // 100D:80D2 mov word ptr DS:[0x471A],AX
        UInt16[DS, (ushort)0x471A] = AX;
        // 100D:80D5 mov word ptr DS:[0x471C],AX
        UInt16[DS, (ushort)0x471C] = AX;
        // 100D:80D8 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_80DF_181AF(int loadOffset)
    {
    entrydispatcher:
    label_100D_80DF_181AF_28426:
        CheckExternalEvents(cs1, 0x80DF);
        // 100D:80DF push AX
        Stack.Push16(AX);
        // 100D:80E0 call near 0xC08E
        NearCall(cs1, 0x80E3, unknown_100D_C08E_1C15E);
    label_100D_80E3_181B3_28429:
        CheckExternalEvents(cs1, 0x80E3);
        // 100D:80E3 call near 0x8FD1
        NearCall(cs1, 0x80E6, unknown_100D_8FD1_190A1);
    label_100D_80E6_181B6_28431:
        CheckExternalEvents(cs1, 0x80E6);
        // 100D:80E6 pop BX
        BX = Stack.Pop16();
        // 100D:80E7 mov SI,0x2244
        SI = (ushort)0x2244;
        // 100D:80EA mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:80ED push AX
        Stack.Push16(AX);
        // 100D:80EE push word ptr DS:[SI+6]
        Stack.Push16(UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:80F1 push BX
        Stack.Push16(BX);
        // 100D:80F2 cmp AX,0x0032
        Alu16.Sub(AX, (ushort)0x0032);
        // 100D:80F5 jb short 0x80FA
        if (CarryFlag)
        {
            goto label_100D_80FA_181CA_28440;
        }
    label_100D_80F7_181C7_33411:
        CheckExternalEvents(cs1, 0x80F7);
        // 100D:80F7 add AX,0x0026
        AX = Alu16.Add(AX, (ushort)0x0026);
    label_100D_80FA_181CA_28440:
        CheckExternalEvents(cs1, 0x80FA);
        // 100D:80FA mov word ptr DS:[SI+2],AX
        UInt16[DS, (ushort)(SI + (sbyte)2)] = AX;
        // 100D:80FD mov word ptr DS:[SI+6],0x0019
        UInt16[DS, (ushort)(SI + (sbyte)6)] = (ushort)0x0019;
        // 100D:8102 call near 0x9F82
        NearCall(cs1, 0x8105, unknown_100D_9F82_1A052);
    label_100D_8105_181D5_28444:
        CheckExternalEvents(cs1, 0x8105);
        // 100D:8105 pop AX
        AX = Stack.Pop16();
        // 100D:8106 call near 0x88AF
        NearCall(cs1, 0x8109, unknown_100D_88AF_1897F);
    label_100D_8109_181D9_28447:
        CheckExternalEvents(cs1, 0x8109);
        // 100D:8109 cmp byte ptr DS:[0x4774],0
        Alu8.Sub(UInt8[DS, (ushort)0x4774], (byte)0x00);
        // 100D:810E jne short 0x811E
        if (!ZeroFlag)
        {
            goto label_100D_811E_181EE_28450;
        }
    label_100D_8110_181E0_29088:
        CheckExternalEvents(cs1, 0x8110);
        // 100D:8110 mov AX,0x010A
        AX = (ushort)0x010A;
        // 100D:8113 add AX,word ptr DS:[0xD810]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0xD810]);
        // 100D:8117 add word ptr DS:[0x4780],AX
        UInt16[DS, (ushort)0x4780] = Alu16.Add(UInt16[DS, (ushort)0x4780], AX);
        // 100D:811B call near 0x9EFD
        NearCall(cs1, 0x811E, unknown_100D_9EFD_19FCD);
    label_100D_811E_181EE_28450:
        CheckExternalEvents(cs1, 0x811E);
        // 100D:811E pop word ptr DS:[0x224A]
        ushort popStackCheck_100D_811E_181EE = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_811E_181EE = UInt16[DS, (ushort)0x224A];
        ushort poppedValue_100D_811E_181EE = Stack.Pop16();
        UInt16[DS, (ushort)0x224A] = unchecked((ushort)poppedValue_100D_811E_181EE);
        // 100D:8122 pop word ptr DS:[0x2246]
        ushort popStackCheck_100D_8122_181F2 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_8122_181F2 = UInt16[DS, (ushort)0x2246];
        ushort poppedValue_100D_8122_181F2 = Stack.Pop16();
        UInt16[DS, (ushort)0x2246] = unchecked((ushort)poppedValue_100D_8122_181F2);
        // 100D:8126 call near 0xC07C
        NearCall(cs1, 0x8129, unknown_100D_C07C_1C14C);
    label_100D_8129_181F9_28454:
        CheckExternalEvents(cs1, 0x8129);
        // 100D:8129 mov word ptr DS:[0x4720],0x18F3
        UInt16[DS, (ushort)0x4720] = (ushort)0x18F3;
        // 100D:812F mov byte ptr DS:[0x4722],0
        UInt8[DS, (ushort)0x4722] = (byte)0x00;
        // 100D:8134 call near 0x541F
        NearCall(cs1, 0x8137, unknown_100D_541F_154EF);
    label_100D_8137_18207_28900:
        CheckExternalEvents(cs1, 0x8137);
        // 100D:8137 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        // 100D:813D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_813E_1820E(int loadOffset)
    {
    label_100D_813E_1820E_28843:
        CheckExternalEvents(cs1, 0x813E);
        // 100D:813E sub SP,0x0030
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)48)));
        // 100D:8141 mov DI,SP
        DI = SP;
        // 100D:8143 call near 0x68EB
        NearCall(cs1, 0x8146, unknown_100D_68EB_169BB);
    label_100D_8146_18216_28847:
        CheckExternalEvents(cs1, 0x8146);
        // 100D:8146 mov DX,word ptr DS:[SI+6]
        DX = UInt16[DS, (ushort)(SI + (sbyte)6)];
        // 100D:8149 mov BX,word ptr DS:[SI+8]
        BX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:814C call near 0x81D7
        NearCall(cs1, 0x814F, unknown_100D_81D7_182A7);
    label_100D_814F_1821F_28862:
        CheckExternalEvents(cs1, 0x814F);
        // 100D:814F cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:8153 jne short 0x816A
        if (!ZeroFlag)
        {
            goto label_100D_816A_1823A_30157;
        }
    label_100D_8155_18225_28865:
        CheckExternalEvents(cs1, 0x8155);
        // 100D:8155 mov SI,0x4718
        SI = (ushort)0x4718;
    label_100D_8158_18228_28867:
        CheckExternalEvents(cs1, 0x8158);
        // 100D:8158 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8159 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:815B je short 0x8176
        if (ZeroFlag)
        {
            goto label_100D_8176_18246_28870;
        }
    label_100D_815D_1822D_29313:
        CheckExternalEvents(cs1, 0x815D);
        // 100D:815D mov BX,AX
        BX = AX;
        // 100D:815F mov DX,word ptr DS:[BX+2]
        DX = UInt16[DS, (ushort)(BX + (sbyte)2)];
        // 100D:8162 mov BX,word ptr DS:[BX+4]
        BX = UInt16[DS, (ushort)(BX + (sbyte)4)];
        // 100D:8165 call near 0x81D7
        NearCall(cs1, 0x8168, unknown_100D_81D7_182A7);
    label_100D_8168_18238_29318:
        CheckExternalEvents(cs1, 0x8168);
        // 100D:8168 jmp short 0x8158
        goto label_100D_8158_18228_28867;
    label_100D_816A_1823A_30157:
        CheckExternalEvents(cs1, 0x816A);
        // 100D:816A mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:816D mov DX,word ptr DS:[BX+2]
        DX = UInt16[DS, (ushort)(BX + (sbyte)2)];
        // 100D:8170 mov BX,word ptr DS:[BX+4]
        BX = UInt16[DS, (ushort)(BX + (sbyte)4)];
        // 100D:8173 call near 0x81D7
        NearCall(cs1, 0x8176, unknown_100D_81D7_182A7);
    label_100D_8176_18246_28870:
        CheckExternalEvents(cs1, 0x8176);
        // 100D:8176 mov SI,SP
        SI = SP;
    label_100D_8178_18248_28872:
        CheckExternalEvents(cs1, 0x8178);
        // 100D:8178 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8179 mov DX,AX
        DX = AX;
        // 100D:817B lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:817C mov BX,AX
        BX = AX;
        // 100D:817E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:817F mov DI,word ptr DS:[SI]
        DI = UInt16[DS, SI];
        // 100D:8181 cmp DI,0x8000
        Alu16.Sub(DI, (ushort)0x8000);
        // 100D:8185 je short 0x81D3
        if (ZeroFlag)
        {
            goto label_100D_81D3_182A3_28880;
        }
    label_100D_8187_18257_29321:
        CheckExternalEvents(cs1, 0x8187);
        // 100D:8187 push SI
        Stack.Push16(SI);
        // 100D:8188 mov CX,word ptr DS:[SI+2]
        CX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:818B sub AX,word ptr DS:[SI+4]
        AX = Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:818E mov SI,DX
        SI = DX;
        // 100D:8190 sub SI,DI
        SI = Alu16.Sub(SI, DI);
        // 100D:8192 xor AX,SI
        AX = Alu16.Xor(AX, SI);
        // 100D:8194 jns short 0x81C0
        if (!SignFlag)
        {
            goto label_100D_81C0_18290_29329;
        }
    label_100D_8196_18266_32128:
        CheckExternalEvents(cs1, 0x8196);
        // 100D:8196 mov AX,SI
        AX = SI;
        // 100D:8198 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:819A jns short 0x819E
        if (!SignFlag)
        {
            goto label_100D_819E_1826E_32132;
        }
    label_100D_819C_1826C_35057:
        CheckExternalEvents(cs1, 0x819C);
        // 100D:819C neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_819E_1826E_32132:
        CheckExternalEvents(cs1, 0x819E);
        // 100D:819E cmp AX,0x0050
        Alu16.Sub(AX, (ushort)0x0050);
        // 100D:81A1 jb short 0x81C0
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:81A1");
        }
    label_100D_81C0_18290_29329:
        CheckExternalEvents(cs1, 0x81C0);
        // 100D:81C0 mov ES,word ptr DS:[0xDBDA]
        ES = UInt16[DS, (ushort)0xDBDA];
        // 100D:81C4 mov AL,0x0C
        AL = (byte)0x0C;
        // 100D:81C6 mov BP,0x5555
        BP = (ushort)0x5555;
        // 100D:81C9 mov SI,0x46E3
        SI = (ushort)0x46E3;
        // 100D:81CC call far dword ptr DS:[0x3901]
        ushort targetSegment_29334 = unchecked((ushort)(UInt16[DS, (ushort)((ushort)0x3901 + (ushort)0x0002)]));
        ushort targetOffset_29334 = unchecked((ushort)(UInt16[DS, (ushort)0x3901]));
        if (targetSegment_29334 == cs2 && targetOffset_29334 == 0x0139)
        {
            FarCall(cs1, 0x81D0, cs2, unknown_3358_0139_336B9);
            goto label_100D_81D0_182A0_29342;
        }
        throw FailAsUntested($"Unknown far call target {targetSegment_29334:X4}:{targetOffset_29334:X4} at 100D:81CC");
    label_100D_81D0_182A0_29342:
        CheckExternalEvents(cs1, 0x81D0);
        // 100D:81D0 pop SI
        SI = Stack.Pop16();
        // 100D:81D1 jmp short 0x8178
        goto label_100D_8178_18248_28872;
    label_100D_81D3_182A3_28880:
        CheckExternalEvents(cs1, 0x81D3);
        // 100D:81D3 add SP,0x0030
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)48)));
        // 100D:81D6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_81D7_182A7(int loadOffset)
    {
    label_100D_81D7_182A7_28851:
        CheckExternalEvents(cs1, 0x81D7);
        // 100D:81D7 mov word ptr DS:[DI+4],DX
        UInt16[DS, (ushort)(DI + (sbyte)4)] = DX;
        // 100D:81DA push DI
        Stack.Push16(DI);
        // 100D:81DB call near 0xB647
        NearCall(cs1, 0x81DE, unknown_100D_B647_1B717);
    label_100D_81DE_182AE_28855:
        CheckExternalEvents(cs1, 0x81DE);
        // 100D:81DE pop DI
        DI = Stack.Pop16();
        // 100D:81DF mov word ptr DS:[DI],DX
        UInt16[DS, DI] = DX;
        // 100D:81E1 mov word ptr DS:[DI+2],BX
        UInt16[DS, (ushort)(DI + (sbyte)2)] = BX;
        // 100D:81E4 add DI,6
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:81E7 mov word ptr DS:[DI],0x8000
        UInt16[DS, DI] = (ushort)0x8000;
        // 100D:81EB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_81EC_182BC(int loadOffset)
    {
    entrydispatcher:
    label_100D_81EC_182BC_29264:
        CheckExternalEvents(cs1, 0x81EC);
        // 100D:81EC call near 0xC13B
        NearCall(cs1, 0x81EF, unknown_100D_C13B_1C20B);
    label_100D_81EF_182BF_29266:
        CheckExternalEvents(cs1, 0x81EF);
        // 100D:81EF mov DI,word ptr DS:[0xDBE2]
        DI = UInt16[DS, (ushort)0xDBE2];
        // 100D:81F3 call near 0xD6FE
        NearCall(cs1, 0x81F6, unknown_100D_D6FE_1D7CE);
    label_100D_81F6_182C6_29269:
        CheckExternalEvents(cs1, 0x81F6);
        // 100D:81F6 jae short 0x8246
        if (!CarryFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x8246))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_81F8_182C8_29271:
        CheckExternalEvents(cs1, 0x81F8);
        // 100D:81F8 call near 0x5944
        NearCall(cs1, 0x81FB, unknown_100D_5944_15A14);
    label_100D_81FB_182CB_29283:
        CheckExternalEvents(cs1, 0x81FB);
        // 100D:81FB mov byte ptr DS:[0x46EB],0x40
        UInt8[DS, (ushort)0x46EB] = (byte)0x40;
        // 100D:8200 mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:8202 call near 0x5E6D
        NearCall(cs1, 0x8205, unknown_100D_5E6D_15F3D);
    label_100D_8205_182D5_29287:
        CheckExternalEvents(cs1, 0x8205);
        // 100D:8205 mov byte ptr DS:[0x46EB],0xC0
        UInt8[DS, (ushort)0x46EB] = (byte)0xC0;
        // 100D:820A cmp AX,9
        Alu16.Sub(AX, (ushort)0x0009);
        // 100D:820D jae short 0x824C
        if (!CarryFlag)
        {
            goto label_100D_824C_1831C_29359;
        }
    label_100D_820F_182DF_29291:
        CheckExternalEvents(cs1, 0x820F);
        // 100D:820F call near 0x8256
        NearCall(cs1, 0x8212, unknown_100D_8256_18326);
    label_100D_8212_182E2_29357:
        CheckExternalEvents(cs1, 0x8212);
        // 100D:8212 jb short 0x824C
        if (!(CarryFlag))
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x8214))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_824C_1831C_29359:
        CheckExternalEvents(cs1, 0x824C);
        // 100D:824C ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_824D_1831D(int loadOffset)
    {
    label_100D_824D_1831D_30175:
        CheckExternalEvents(cs1, 0x824D);
        // 100D:824D call near 0x82B7
        NearCall(cs1, 0x8250, unknown_100D_82B7_18387);
        return unknown_100D_8250_18320(0x0000);
    }

    public virtual Action unknown_100D_8250_18320(int loadOffset)
    {
    label_100D_8250_18320_29684:
        CheckExternalEvents(cs1, 0x8250);
        // 100D:8250 call near 0x5AD3
        NearCall(cs1, 0x8253, unknown_100D_5AD3_15BA3);
    label_100D_8253_18323_29686:
        CheckExternalEvents(cs1, 0x8253);
        // 100D:8253 jmp near 0xC13B
        return unknown_100D_C13B_1C20B(0x0000);
    }

    public virtual Action unknown_100D_8256_18326(int loadOffset)
    {
    entrydispatcher:
    label_100D_8256_18326_29293:
        CheckExternalEvents(cs1, 0x8256);
        // 100D:8256 call near 0x68EB
        NearCall(cs1, 0x8259, unknown_100D_68EB_169BB);
    label_100D_8259_18329_29295:
        CheckExternalEvents(cs1, 0x8259);
        // 100D:8259 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:825D jne short 0x829E
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x829E))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_825F_1832F_29298:
        CheckExternalEvents(cs1, 0x825F);
        // 100D:825F mov AL,byte ptr DS:[DI+8]
        AL = UInt8[DS, (ushort)(DI + (sbyte)8)];
        // 100D:8262 cmp AL,0x20
        Alu8.Sub(AL, (byte)0x20);
        // 100D:8264 jb short 0x826C
        if (CarryFlag)
        {
            goto label_100D_826C_1833C_29302;
        }
    label_100D_8266_18336_38306:
        CheckExternalEvents(cs1, 0x8266);
        // 100D:8266 test byte ptr DS:[DI+0x0A],8
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x08);
        // 100D:826A je short 0x8296
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x8296))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_826C_1833C_29302:
        CheckExternalEvents(cs1, 0x826C);
        // 100D:826C cmp byte ptr DS:[0x4738],3
        Alu8.Sub(UInt8[DS, (ushort)0x4738], (byte)0x03);
        // 100D:8271 jb short 0x8276
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8271");
        }
    label_100D_8276_18346_29305:
        CheckExternalEvents(cs1, 0x8276);
        // 100D:8276 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:8278 mov BL,byte ptr DS:[0x4738]
        BL = UInt8[DS, (ushort)0x4738];
        // 100D:827C inc byte ptr DS:[0x4738]
        UInt8[DS, (ushort)0x4738] = Alu8.Inc(UInt8[DS, (ushort)0x4738]);
        // 100D:8280 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:8282 mov word ptr DS:[BX+0x4718],DI
        UInt16[DS, (ushort)(BX + (short)18200)] = DI;
        if (JumpDispatcher.Jump(unknown_100D_003A_1010A, 0x8286))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_82A0_18370(int loadOffset)
    {
    label_100D_82A0_18370_31158:
        CheckExternalEvents(cs1, 0x82A0);
        // 100D:82A0 call near 0xD41B
        NearCall(cs1, 0x82A3, unknown_100D_D41B_1D4EB);
    label_100D_82A3_18373_31160:
        CheckExternalEvents(cs1, 0x82A3);
        // 100D:82A3 cmp BP,0x212E
        Alu16.Sub(BP, (ushort)0x212E);
        // 100D:82A7 je short 0x82AD
        if (ZeroFlag)
        {
            goto label_100D_82AD_1837D_31165;
        }
    label_100D_82A9_18379_31163:
        CheckExternalEvents(cs1, 0x82A9);
        // 100D:82A9 cmp BP,0x2136
        Alu16.Sub(BP, (ushort)0x2136);
    label_100D_82AD_1837D_31165:
        CheckExternalEvents(cs1, 0x82AD);
        // 100D:82AD jne short 0x82B6
        if (!ZeroFlag)
        {
            goto label_100D_82B6_18386_31166;
        }
    label_100D_82AF_1837F_34698:
        CheckExternalEvents(cs1, 0x82AF);
        // 100D:82AF mov AL,byte ptr DS:[0x46EB]
        AL = UInt8[DS, (ushort)0x46EB];
        // 100D:82B2 not AL
        AL = unchecked((byte)~AL);
        // 100D:82B4 test AL,0x40
        Alu8.And(AL, (byte)0x40);
    label_100D_82B6_18386_31166:
        CheckExternalEvents(cs1, 0x82B6);
        // 100D:82B6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_82B7_18387(int loadOffset)
    {
    label_100D_82B7_18387_29369:
        CheckExternalEvents(cs1, 0x82B7);
        // 100D:82B7 test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:82BC je short 0x82D9
        if (ZeroFlag)
        {
            goto label_100D_82D9_183A9_29389;
        }
    label_100D_82BE_1838E_29372:
        CheckExternalEvents(cs1, 0x82BE);
        // 100D:82BE call near 0x58FA
        NearCall(cs1, 0x82C1, unknown_100D_58FA_159CA);
    label_100D_82C1_18391_29374:
        CheckExternalEvents(cs1, 0x82C1);
        // 100D:82C1 call near 0xE270
        NearCall(cs1, 0x82C4, unknown_100D_E270_1E340);
    label_100D_82C4_18394_29376:
        CheckExternalEvents(cs1, 0x82C4);
        // 100D:82C4 call near 0xC08E
        NearCall(cs1, 0x82C7, unknown_100D_C08E_1C15E);
    label_100D_82C7_18397_29378:
        CheckExternalEvents(cs1, 0x82C7);
        // 100D:82C7 mov SI,0x18E9
        SI = (ushort)0x18E9;
        // 100D:82CA call near 0xC551
        NearCall(cs1, 0x82CD, unknown_100D_C551_1C621);
    label_100D_82CD_1839D_29381:
        CheckExternalEvents(cs1, 0x82CD);
        // 100D:82CD call near 0x68EB
        NearCall(cs1, 0x82D0, unknown_100D_68EB_169BB);
    label_100D_82D0_183A0_29383:
        CheckExternalEvents(cs1, 0x82D0);
        // 100D:82D0 call near 0x7BE0
        NearCall(cs1, 0x82D3, unknown_100D_7BE0_17CB0);
    label_100D_82D3_183A3_29385:
        CheckExternalEvents(cs1, 0x82D3);
        // 100D:82D3 call near 0xC07C
        NearCall(cs1, 0x82D6, unknown_100D_C07C_1C14C);
    label_100D_82D6_183A6_29387:
        CheckExternalEvents(cs1, 0x82D6);
        // 100D:82D6 call near 0xE283
        NearCall(cs1, 0x82D9, unknown_100D_E283_1E353);
    label_100D_82D9_183A9_29389:
        CheckExternalEvents(cs1, 0x82D9);
        // 100D:82D9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_82DA_183AA(int loadOffset)
    {
    label_100D_82DA_183AA_29411:
        CheckExternalEvents(cs1, 0x82DA);
        // 100D:82DA push DI
        Stack.Push16(DI);
        // 100D:82DB push SI
        Stack.Push16(SI);
        // 100D:82DC mov BP,word ptr DS:[SI+4]
        BP = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:82DF cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:82E3 je short 0x82EB
        if (ZeroFlag)
        {
            goto label_100D_82EB_183BB_29417;
        }
    label_100D_82E5_183B5_30169:
        CheckExternalEvents(cs1, 0x82E5);
        // 100D:82E5 mov AL,0x10
        AL = (byte)0x10;
        // 100D:82E7 cmp DI,BP
        Alu16.Sub(DI, BP);
        // 100D:82E9 je short 0x82FA
        if (ZeroFlag)
        {
            goto label_100D_82FA_183CA_29444;
        }
    label_100D_82EB_183BB_29417:
        CheckExternalEvents(cs1, 0x82EB);
        // 100D:82EB push BP
        Stack.Push16(BP);
        // 100D:82EC mov word ptr DS:[SI+4],DI
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DI;
        // 100D:82EF call near 0x31F6
        NearCall(cs1, 0x82F2, unknown_100D_31F6_132C6);
    label_100D_82F2_183C2_29439:
        CheckExternalEvents(cs1, 0x82F2);
        // 100D:82F2 call near 0x2E98
        NearCall(cs1, 0x82F5, unknown_100D_2E98_12F68);
    label_100D_82F5_183C5_29441:
        CheckExternalEvents(cs1, 0x82F5);
        // 100D:82F5 pop word ptr DS:[SI+4]
        ushort popStackCheck_100D_82F5_183C5 = Stack.Peek16(unchecked((int)0x00000000u));
        ushort popDestinationCheck_100D_82F5_183C5 = UInt16[DS, (ushort)(SI + (sbyte)4)];
        ushort poppedValue_100D_82F5_183C5 = Stack.Pop16();
        UInt16[DS, (ushort)(SI + (sbyte)4)] = unchecked((ushort)poppedValue_100D_82F5_183C5);
        // 100D:82F8 mov AL,0x0B
        AL = (byte)0x0B;
    label_100D_82FA_183CA_29444:
        CheckExternalEvents(cs1, 0x82FA);
        // 100D:82FA call near 0x9F82
        NearCall(cs1, 0x82FD, unknown_100D_9F82_1A052);
    label_100D_82FD_183CD_29445:
        CheckExternalEvents(cs1, 0x82FD);
        // 100D:82FD call near 0xA1C4
        NearCall(cs1, 0x8300, unknown_100D_A1C4_1A294);
    label_100D_8300_183D0_29447:
        CheckExternalEvents(cs1, 0x8300);
        // 100D:8300 call near 0x7BBE
        NearCall(cs1, 0x8303, unknown_100D_7BBE_17C8E);
    label_100D_8303_183D3_29450:
        CheckExternalEvents(cs1, 0x8303);
        // 100D:8303 pop SI
        SI = Stack.Pop16();
        // 100D:8304 pop DI
        DI = Stack.Pop16();
        // 100D:8305 jmp near 0xA1E2
        return unknown_100D_A1E2_1A2B2(0x0000);
    }

    public virtual Action unknown_100D_8308_183D8(int loadOffset)
    {
    entrydispatcher:
    label_100D_8308_183D8_29732:
        CheckExternalEvents(cs1, 0x8308);
        // 100D:8308 mov CX,4
        CX = (ushort)0x0004;
        // 100D:830B test byte ptr DS:[SI+0x19],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)25)], (byte)0x40);
        // 100D:830F je short 0x8313
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_8313_183E3, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_8311_183E1_33489:
        CheckExternalEvents(cs1, 0x8311);
        // 100D:8311 mov CL,8
        CL = (byte)0x08;
        if (JumpDispatcher.Jump(unknown_100D_8313_183E3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8347_18417(int loadOffset)
    {
    label_100D_8347_18417_29824:
        CheckExternalEvents(cs1, 0x8347);
        // 100D:8347 push SI
        Stack.Push16(SI);
        // 100D:8348 push DI
        Stack.Push16(DI);
        // 100D:8349 mov DI,0x11D3
        DI = (ushort)0x11D3;
        // 100D:834C lea SI,DI+2
        SI = unchecked((ushort)(DI + (sbyte)2));
        // 100D:834F push DS
        Stack.Push16(DS);
        // 100D:8350 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8351 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8352 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8353 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 100D:8354 pop DI
        DI = Stack.Pop16();
        // 100D:8355 pop SI
        SI = Stack.Pop16();
        // 100D:8356 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8357_18427(int loadOffset)
    {
    entrydispatcher:
    label_100D_8357_18427_29815:
        CheckExternalEvents(cs1, 0x8357);
        // 100D:8357 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:835B jne short 0x8368
        if (!ZeroFlag)
        {
            goto label_100D_8368_18438_29837;
        }
    label_100D_835D_1842D_29818:
        CheckExternalEvents(cs1, 0x835D);
        // 100D:835D mov AX,word ptr DS:[0x11D3]
        AX = UInt16[DS, (ushort)0x11D3];
        // 100D:8360 cmp AX,word ptr DS:[SI+4]
        Alu16.Sub(AX, UInt16[DS, (ushort)(SI + (sbyte)4)]);
        // 100D:8363 jne short 0x8368
        if (!ZeroFlag)
        {
            goto label_100D_8368_18438_29837;
        }
    label_100D_8365_18435_29822:
        CheckExternalEvents(cs1, 0x8365);
        // 100D:8365 call near 0x8347
        NearCall(cs1, 0x8368, unknown_100D_8347_18417);
    label_100D_8368_18438_29837:
        CheckExternalEvents(cs1, 0x8368);
        // 100D:8368 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:836B and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:836D mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:8370 mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:8373 mov BX,word ptr DS:[DI+4]
        BX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 100D:8376 mov word ptr DS:[SI+6],DX
        UInt16[DS, (ushort)(SI + (sbyte)6)] = DX;
        // 100D:8379 mov word ptr DS:[SI+8],BX
        UInt16[DS, (ushort)(SI + (sbyte)8)] = BX;
        // 100D:837C test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:8380 jne short 0x8387
        if (!ZeroFlag)
        {
            goto label_100D_8387_18457_35478;
        }
    label_100D_8382_18452_29847:
        CheckExternalEvents(cs1, 0x8382);
        // 100D:8382 call near 0x5D36
        NearCall(cs1, 0x8385, unknown_100D_5D36_15E06);
    label_100D_8385_18455_29849:
        CheckExternalEvents(cs1, 0x8385);
        // 100D:8385 jb short 0x83A7
        if (CarryFlag)
        {
            goto label_100D_83A7_18477_29851;
        }
    label_100D_8387_18457_35478:
        CheckExternalEvents(cs1, 0x8387);
        // 100D:8387 push AX
        Stack.Push16(AX);
        // 100D:8388 call near 0x83BC
        NearCall(cs1, 0x838B, unknown_100D_83BC_1848C);
    label_100D_838B_1845B_35481:
        CheckExternalEvents(cs1, 0x838B);
        // 100D:838B pop AX
        AX = Stack.Pop16();
        // 100D:838C cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:838E je short 0x839A
        if (ZeroFlag)
        {
            goto label_100D_839A_1846A_35485;
        }
    label_100D_8390_18460_36116:
        CheckExternalEvents(cs1, 0x8390);
        // 100D:8390 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:8392 cmp AL,byte ptr DS:[DI+9]
        Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)9)]);
        // 100D:8395 jne short 0x83FD
        if (!ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_83FD_184CD, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_8397_18467_37944:
        CheckExternalEvents(cs1, 0x8397);
        // 100D:8397 jmp near 0x7429
        if (JumpDispatcher.Jump(unknown_100D_7429_174F9, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_839A_1846A_35485:
        CheckExternalEvents(cs1, 0x839A);
        // 100D:839A test byte ptr DS:[DI+0x0A],0x80
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x80);
        // 100D:839E je short 0x83FD
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:839E");
        }
    label_100D_83A0_18470_35488:
        CheckExternalEvents(cs1, 0x83A0);
        // 100D:83A0 and byte ptr DS:[DI+0x0A],0x7F
        UInt8[DS, (ushort)(DI + (sbyte)10)] = Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x7F);
        // 100D:83A4 jmp near 0x5D44
        return unknown_100D_5D44_15E14(0x0000);
    label_100D_83A7_18477_29851:
        CheckExternalEvents(cs1, 0x83A7);
        // 100D:83A7 cmp AL,5
        Alu8.Sub(AL, (byte)0x05);
        // 100D:83A9 jb short 0x83B6
        if (CarryFlag)
        {
            goto label_100D_83B6_18486_29854;
        }
    label_100D_83AB_1847B_34247:
        CheckExternalEvents(cs1, 0x83AB);
        // 100D:83AB cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:83AD ja short 0x83B6
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_83B6_18486_29854;
        }
    label_100D_83AF_1847F_35581:
        CheckExternalEvents(cs1, 0x83AF);
        // 100D:83AF push DI
        Stack.Push16(DI);
        // 100D:83B0 call near 0x6AC5
        NearCall(cs1, 0x83B3, unknown_100D_6AC5_16B95);
    label_100D_83B3_18483_35587:
        CheckExternalEvents(cs1, 0x83B3);
        // 100D:83B3 pop DI
        DI = Stack.Pop16();
        // 100D:83B4 xor AL,AL
        AL = Alu8.Xor(AL, AL);
    label_100D_83B6_18486_29854:
        CheckExternalEvents(cs1, 0x83B6);
        // 100D:83B6 and AL,3
        AL = Alu8.And(AL, (byte)0x03);
        // 100D:83B8 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:83BA je short 0x841F
        if (!(ZeroFlag))
        {
            if (JumpDispatcher.Jump(unknown_100D_83BC_1848C, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_841F_184EF_31349:
        CheckExternalEvents(cs1, 0x841F);
        // 100D:841F mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:8422 cmp DI,word ptr DS:[SI+0x0C]
        Alu16.Sub(DI, UInt16[DS, (ushort)(SI + (sbyte)12)]);
        // 100D:8425 je short 0x844D
        if (ZeroFlag)
        {
            goto label_100D_844D_1851D_31387;
        }
    label_100D_8427_184F7_31353:
        CheckExternalEvents(cs1, 0x8427);
        // 100D:8427 push SI
        Stack.Push16(SI);
        // 100D:8428 call near 0x7F27
        NearCall(cs1, 0x842B, unknown_100D_7F27_17FF7);
    label_100D_842B_184FB_31356:
        CheckExternalEvents(cs1, 0x842B);
        // 100D:842B pop SI
        SI = Stack.Pop16();
        // 100D:842C mov BX,word ptr DS:[SI+0x0E]
        BX = UInt16[DS, (ushort)(SI + (sbyte)14)];
        // 100D:842F mov CX,BX
        CX = BX;
        // 100D:8431 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 100D:8433 cmp byte ptr DS:[BX+0x46FE],0
        Alu8.Sub(UInt8[DS, (ushort)(BX + (short)18174)], (byte)0x00);
        // 100D:8438 je short 0x8442
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8438");
        }
    label_100D_843A_1850A_31363:
        CheckExternalEvents(cs1, 0x843A);
        // 100D:843A dec byte ptr DS:[BX+DI+0x14]
        UInt8[DS, (ushort)(BX + DI + (sbyte)20)] = Alu8.Dec(UInt8[DS, (ushort)(BX + DI + (sbyte)20)]);
        // 100D:843D or byte ptr DS:[SI+0x19],CH
        UInt8[DS, (ushort)(SI + (sbyte)25)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)25)], CH);
        // 100D:8440 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 100D:8442 mov word ptr DS:[SI+0x0E],CX
        UInt16[DS, (ushort)(SI + (sbyte)14)] = CX;
        // 100D:8445 mov DI,word ptr DS:[SI+0x0C]
        DI = UInt16[DS, (ushort)(SI + (sbyte)12)];
        // 100D:8448 mov word ptr DS:[SI+4],DI
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DI;
        // 100D:844B jmp short 0x8461
        if (JumpDispatcher.Jump(unknown_100D_8461_18531, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_844D_1851D_31387:
        CheckExternalEvents(cs1, 0x844D);
        // 100D:844D and byte ptr DS:[SI+3],0xFC
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xFC);
        // 100D:8451 jmp near 0x83BC
        if (JumpDispatcher.Jump(unknown_100D_83BC_1848C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_83BC_1848C(int loadOffset)
    {
    entrydispatcher:
    label_100D_83BC_1848C_29858:
        CheckExternalEvents(cs1, 0x83BC);
        // 100D:83BC call near 0x851F
        NearCall(cs1, 0x83BF, unknown_100D_851F_185EF);
    label_100D_83BF_1848F_29901:
        CheckExternalEvents(cs1, 0x83BF);
        // 100D:83BF and byte ptr DS:[SI+3],0xBF
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xBF);
        // 100D:83C3 call near 0x85CC
        NearCall(cs1, 0x83C6, unknown_100D_85CC_1869C);
    label_100D_83C6_18496_29912:
        CheckExternalEvents(cs1, 0x83C6);
        // 100D:83C6 call near 0x7F5F
        NearCall(cs1, 0x83C9, unknown_100D_7F5F_1802F);
    label_100D_83C9_18499_29929:
        CheckExternalEvents(cs1, 0x83C9);
        // 100D:83C9 mov CL,byte ptr DS:[SI+3]
        CL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:83CC or CL,CL
        CL = Alu8.Or(CL, CL);
        // 100D:83CE js short 0x83FC
        if (SignFlag)
        {
            goto label_100D_83FC_184CC_29942;
        }
    label_100D_83D0_184A0_29933:
        CheckExternalEvents(cs1, 0x83D0);
        // 100D:83D0 and CL,0x0F
        CL = Alu8.And(CL, (byte)0x0F);
        // 100D:83D3 call near 0x6AD4
        NearCall(cs1, 0x83D6, unknown_100D_6AD4_16BA4);
    label_100D_83D6_184A6_29938:
        CheckExternalEvents(cs1, 0x83D6);
        // 100D:83D6 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:83D9 cmp DI,word ptr DS:[0x114E]
        Alu16.Sub(DI, UInt16[DS, (ushort)0x114E]);
        // 100D:83DD jne short 0x83FC
        if (!ZeroFlag)
        {
            goto label_100D_83FC_184CC_29942;
        }
    label_100D_83DF_184AF_36714:
        CheckExternalEvents(cs1, 0x83DF);
        // 100D:83DF call near 0xD41B
        NearCall(cs1, 0x83E2, unknown_100D_D41B_1D4EB);
    label_100D_83E2_184B2_36716:
        CheckExternalEvents(cs1, 0x83E2);
        // 100D:83E2 cmp BP,0x1F0E
        Alu16.Sub(BP, (ushort)0x1F0E);
        // 100D:83E6 jne short 0x83FC
        if (!ZeroFlag)
        {
            goto label_100D_83FC_184CC_29942;
        }
    label_100D_83E8_184B8_36724:
        CheckExternalEvents(cs1, 0x83E8);
        // 100D:83E8 mov AL,1
        AL = (byte)0x01;
        // 100D:83EA cmp byte ptr DS:[0x002B],1
        Alu8.Sub(UInt8[DS, (ushort)0x002B], (byte)0x01);
        // 100D:83EF adc AL,0
        AL = Alu8.Adc(AL, (byte)0x00);
        // 100D:83F1 cmp byte ptr DS:[0x000B],AL
        Alu8.Sub(UInt8[DS, (ushort)0x000B], AL);
        // 100D:83F5 jne short 0x83FC
        if (!ZeroFlag)
        {
            goto label_100D_83FC_184CC_29942;
        }
    label_100D_83F7_184C7_36730:
        CheckExternalEvents(cs1, 0x83F7);
        // 100D:83F7 or byte ptr DS:[0x473B],1
        UInt8[DS, (ushort)0x473B] = Alu8.Or(UInt8[DS, (ushort)0x473B], (byte)0x01);
    label_100D_83FC_184CC_29942:
        CheckExternalEvents(cs1, 0x83FC);
        // 100D:83FC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_83FD_184CD(int loadOffset)
    {
    entrydispatcher:
    label_100D_83FD_184CD_34262:
        CheckExternalEvents(cs1, 0x83FD);
        // 100D:83FD mov BP,0x8403
        BP = (ushort)0x8403;
        // 100D:8400 jmp near 0x661D
        if (JumpDispatcher.Jump(unknown_100D_661D_166ED, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8403_184D3(int loadOffset)
    {
    label_100D_8403_184D3_34265:
        CheckExternalEvents(cs1, 0x8403);
        // 100D:8403 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:8407 jne short 0x841B
        if (!ZeroFlag)
        {
            goto label_100D_841B_184EB_34279;
        }
    label_100D_8409_184D9_34268:
        CheckExternalEvents(cs1, 0x8409);
        // 100D:8409 mov AL,byte ptr DS:[SI+3]
        AL = UInt8[DS, (ushort)(SI + (sbyte)3)];
        // 100D:840C and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:840E cmp AL,1
        Alu8.Sub(AL, (byte)0x01);
        // 100D:8410 je short 0x841C
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8410");
        }
    label_100D_8412_184E2_34273:
        CheckExternalEvents(cs1, 0x8412);
        // 100D:8412 cmp AL,6
        Alu8.Sub(AL, (byte)0x06);
        // 100D:8414 je short 0x841B
        if (ZeroFlag)
        {
            goto label_100D_841B_184EB_34279;
        }
    label_100D_8416_184E6_34276:
        CheckExternalEvents(cs1, 0x8416);
        // 100D:8416 mov CL,6
        CL = (byte)0x06;
        // 100D:8418 call near 0x6ACB
        NearCall(cs1, 0x841B, unknown_100D_6ACB_16B9B);
    label_100D_841B_184EB_34279:
        CheckExternalEvents(cs1, 0x841B);
        // 100D:841B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8461_18531(int loadOffset)
    {
    entrydispatcher:
    label_100D_8461_18531_24625:
        CheckExternalEvents(cs1, 0x8461);
        // 100D:8461 call near 0x6917
        NearCall(cs1, 0x8464, unknown_100D_6917_169E7);
    label_100D_8464_18534_24627:
        CheckExternalEvents(cs1, 0x8464);
        // 100D:8464 je short 0x8467
        if (ZeroFlag)
        {
            goto label_100D_8467_18537_24629;
        }
    label_100D_8466_18536_29936:
        CheckExternalEvents(cs1, 0x8466);
        // 100D:8466 ret near
        return NearRet((ushort)0x0000);
    label_100D_8467_18537_24629:
        CheckExternalEvents(cs1, 0x8467);
        // 100D:8467 push SI
        Stack.Push16(SI);
        // 100D:8468 call near 0xC58A
        NearCall(cs1, 0x846B, unknown_100D_C58A_1C65A);
    label_100D_846B_1853B_24634:
        CheckExternalEvents(cs1, 0x846B);
        // 100D:846B pop SI
        SI = Stack.Pop16();
        if (JumpDispatcher.Jump(unknown_100D_846C_1853C, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_846C_1853C(int loadOffset)
    {
    entrydispatcher:
    label_100D_846C_1853C_24636:
        CheckExternalEvents(cs1, 0x846C);
        // 100D:846C push SI
        Stack.Push16(SI);
        // 100D:846D test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:8471 jne short 0x847B
        if (!ZeroFlag)
        {
            goto label_100D_847B_1854B_24644;
        }
    label_100D_8473_18543_24639:
        CheckExternalEvents(cs1, 0x8473);
        // 100D:8473 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:8476 call near 0x5ED0
        NearCall(cs1, 0x8479, unknown_100D_5ED0_15FA0);
    label_100D_8479_18549_24642:
        CheckExternalEvents(cs1, 0x8479);
        // 100D:8479 jne short 0x848B
        if (!ZeroFlag)
        {
            goto label_100D_848B_1855B_35527;
        }
    label_100D_847B_1854B_24644:
        CheckExternalEvents(cs1, 0x847B);
        // 100D:847B mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:847D call near 0x6757
        NearCall(cs1, 0x8480, unknown_100D_6757_16827);
    label_100D_8480_18550_24650:
        CheckExternalEvents(cs1, 0x8480);
        // 100D:8480 jb short 0x848B
        if (CarryFlag)
        {
            goto label_100D_848B_1855B_35527;
        }
    label_100D_8482_18552_24652:
        CheckExternalEvents(cs1, 0x8482);
        // 100D:8482 mov SI,DI
        SI = DI;
        // 100D:8484 push DI
        Stack.Push16(DI);
        // 100D:8485 call near 0xC6AD
        NearCall(cs1, 0x8488, unknown_100D_C6AD_1C77D);
    label_100D_8488_18558_24656:
        CheckExternalEvents(cs1, 0x8488);
        // 100D:8488 pop DI
        DI = Stack.Pop16();
    label_100D_8489_18559_24658:
        CheckExternalEvents(cs1, 0x8489);
        // 100D:8489 pop SI
        SI = Stack.Pop16();
        // 100D:848A ret near
        return NearRet((ushort)0x0000);
    label_100D_848B_1855B_35527:
        CheckExternalEvents(cs1, 0x848B);
        // 100D:848B xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 100D:848D jmp short 0x8489
        goto label_100D_8489_18559_24658;
    }

    public virtual Action unknown_100D_848F_1855F(int loadOffset)
    {
    label_100D_848F_1855F_29463:
        CheckExternalEvents(cs1, 0x848F);
        // 100D:848F mov DI,word ptr DS:[0x11D3]
        DI = UInt16[DS, (ushort)0x11D3];
        // 100D:8493 cmp word ptr DS:[SI+4],DI
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)4)], DI);
        // 100D:8496 jne short 0x84A3
        if (!ZeroFlag)
        {
            goto label_100D_84A3_18573_29467;
        }
    label_100D_8498_18568_35439:
        CheckExternalEvents(cs1, 0x8498);
        // 100D:8498 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:849C jne short 0x84A3
        if (!ZeroFlag)
        {
            goto label_100D_84A3_18573_29467;
        }
    label_100D_849E_1856E_40139:
        CheckExternalEvents(cs1, 0x849E);
        // 100D:849E call near 0x8347
        NearCall(cs1, 0x84A1, unknown_100D_8347_18417);
    label_100D_84A1_18571_40142:
        CheckExternalEvents(cs1, 0x84A1);
        // 100D:84A1 jmp short 0x848F
        goto label_100D_848F_1855F_29463;
    label_100D_84A3_18573_29467:
        CheckExternalEvents(cs1, 0x84A3);
        // 100D:84A3 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:84A5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_84A6_18576(int loadOffset)
    {
    entrydispatcher:
    label_100D_84A6_18576_29458:
        CheckExternalEvents(cs1, 0x84A6);
        // 100D:84A6 cmp SI,0x08E0
        Alu16.Sub(SI, (ushort)0x08E0);
        // 100D:84AA jne short 0x84B2
        if (!ZeroFlag)
        {
            goto label_100D_84B2_18582_29472;
        }
    label_100D_84AC_1857C_29461:
        CheckExternalEvents(cs1, 0x84AC);
        // 100D:84AC call near 0x848F
        NearCall(cs1, 0x84AF, unknown_100D_848F_1855F);
    label_100D_84AF_1857F_29470:
        CheckExternalEvents(cs1, 0x84AF);
        // 100D:84AF jne short 0x84B2
        if (!ZeroFlag)
        {
            goto label_100D_84B2_18582_29472;
        }
    label_100D_84B1_18581_40145:
        CheckExternalEvents(cs1, 0x84B1);
        // 100D:84B1 ret near
        return NearRet((ushort)0x0000);
    label_100D_84B2_18582_29472:
        CheckExternalEvents(cs1, 0x84B2);
        // 100D:84B2 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:84B6 je short 0x84CA
        if (ZeroFlag)
        {
            goto label_100D_84CA_1859A_29475;
        }
    label_100D_84B8_18588_34873:
        CheckExternalEvents(cs1, 0x84B8);
        // 100D:84B8 mov word ptr DS:[SI+4],DI
        UInt16[DS, (ushort)(SI + (sbyte)4)] = DI;
        // 100D:84BB mov AL,3
        AL = (byte)0x03;
        // 100D:84BD and AL,byte ptr DS:[SI+3]
        AL = Alu8.And(AL, UInt8[DS, (ushort)(SI + (sbyte)3)]);
        // 100D:84C0 cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:84C2 jne short 0x84C8
        if (!ZeroFlag)
        {
            goto label_100D_84C8_18598_34879;
        }
    label_100D_84C4_18594_38010:
        CheckExternalEvents(cs1, 0x84C4);
        // 100D:84C4 and byte ptr DS:[SI+3],0xFC
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0xFC);
    label_100D_84C8_18598_34879:
        CheckExternalEvents(cs1, 0x84C8);
        // 100D:84C8 jmp short 0x8461
        if (JumpDispatcher.Jump(unknown_100D_8461_18531, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_84CA_1859A_29475:
        CheckExternalEvents(cs1, 0x84CA);
        // 100D:84CA call near 0x6EBF
        NearCall(cs1, 0x84CD, unknown_100D_6EBF_16F8F);
    label_100D_84CD_1859D_29490:
        CheckExternalEvents(cs1, 0x84CD);
        // 100D:84CD push DI
        Stack.Push16(DI);
        // 100D:84CE call near 0x858C
        NearCall(cs1, 0x84D1, unknown_100D_858C_1865C);
    label_100D_84D1_185A1_29509:
        CheckExternalEvents(cs1, 0x84D1);
        // 100D:84D1 pop DI
        DI = Stack.Pop16();
        // 100D:84D2 cmp byte ptr DS:[SI+3],6
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x06);
        // 100D:84D6 jne short 0x8501
        if (!ZeroFlag)
        {
            goto label_100D_8501_185D1_29513;
        }
    label_100D_84D8_185A8_35935:
        CheckExternalEvents(cs1, 0x84D8);
        // 100D:84D8 push DI
        Stack.Push16(DI);
        // 100D:84D9 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:84DC test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:84E0 je short 0x84EF
        if (ZeroFlag)
        {
            goto label_100D_84EF_185BF_35959;
        }
    label_100D_84E2_185B2_35940:
        CheckExternalEvents(cs1, 0x84E2);
        // 100D:84E2 call near 0x5098
        NearCall(cs1, 0x84E5, unknown_100D_5098_15168);
    label_100D_84E5_185B5_35942:
        CheckExternalEvents(cs1, 0x84E5);
        // 100D:84E5 jcxz short 0x84EF
        if (CX == (ushort)0x0000)
        {
            goto label_100D_84EF_185BF_35959;
        }
    label_100D_84E7_185B7_35944:
        CheckExternalEvents(cs1, 0x84E7);
        // 100D:84E7 dec DX
        DX = Alu16.Dec(DX);
        // 100D:84E8 jg short 0x84EF
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_100D_84EF_185BF_35959;
        }
    label_100D_84EA_185BA_35947:
        CheckExternalEvents(cs1, 0x84EA);
        // 100D:84EA push SI
        Stack.Push16(SI);
        // 100D:84EB call near 0x74B6
        NearCall(cs1, 0x84EE, unknown_100D_74B6_17586);
    label_100D_84EE_185BE_35957:
        CheckExternalEvents(cs1, 0x84EE);
        // 100D:84EE pop SI
        SI = Stack.Pop16();
    label_100D_84EF_185BF_35959:
        CheckExternalEvents(cs1, 0x84EF);
        // 100D:84EF pop DI
        DI = Stack.Pop16();
        // 100D:84F0 cmp byte ptr DS:[DI+8],0x28
        Alu8.Sub(UInt8[DS, (ushort)(DI + (sbyte)8)], (byte)0x28);
        // 100D:84F4 jae short 0x8501
        if (!CarryFlag)
        {
            goto label_100D_8501_185D1_29513;
        }
    label_100D_84F6_185C6_35962:
        CheckExternalEvents(cs1, 0x84F6);
        // 100D:84F6 test byte ptr DS:[DI+0x0A],2
        Alu8.And(UInt8[DS, (ushort)(DI + (sbyte)10)], (byte)0x02);
        // 100D:84FA jne short 0x851E
        if (!ZeroFlag)
        {
            goto label_100D_851E_185EE_34239;
        }
    label_100D_84FC_185CC_35965:
        CheckExternalEvents(cs1, 0x84FC);
        // 100D:84FC mov AL,3
        AL = (byte)0x03;
        // 100D:84FE call near 0x6F93
        NearCall(cs1, 0x8501, unknown_100D_6F93_17063);
    label_100D_8501_185D1_29513:
        CheckExternalEvents(cs1, 0x8501);
        // 100D:8501 xchg DI,word ptr DS:[SI+4]
        ushort xchgOffset_100D_8501_185D1 = unchecked((ushort)(SI + (sbyte)4));
        ushort temp_100D_8501_185D1 = DI;
        DI = UInt16[DS, xchgOffset_100D_8501_185D1];
        UInt16[DS, xchgOffset_100D_8501_185D1] = unchecked((ushort)temp_100D_8501_185D1);
        // 100D:8504 or byte ptr DS:[SI+3],0x40
        UInt8[DS, (ushort)(SI + (sbyte)3)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:8508 mov byte ptr DS:[SI+2],0
        UInt8[DS, (ushort)(SI + (sbyte)2)] = (byte)0x00;
        // 100D:850C call near 0x7F75
        NearCall(cs1, 0x850F, unknown_100D_7F75_18045);
    label_100D_850F_185DF_29533:
        CheckExternalEvents(cs1, 0x850F);
        // 100D:850F call near 0x8461
        NearCall(cs1, 0x8512, unknown_100D_8461_18531);
    label_100D_8512_185E2_29594:
        CheckExternalEvents(cs1, 0x8512);
        // 100D:8512 test byte ptr DS:[SI+0x10],0x10
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x10);
        // 100D:8516 jne short 0x851E
        if (!ZeroFlag)
        {
            goto label_100D_851E_185EE_34239;
        }
    label_100D_8518_185E8_29597:
        CheckExternalEvents(cs1, 0x8518);
        // 100D:8518 mov CX,7
        CX = (ushort)0x0007;
        // 100D:851B jmp near 0x8313
        if (JumpDispatcher.Jump(unknown_100D_8313_183E3, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_851E_185EE_34239:
        CheckExternalEvents(cs1, 0x851E);
        // 100D:851E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_851F_185EF(int loadOffset)
    {
    label_100D_851F_185EF_29860:
        CheckExternalEvents(cs1, 0x851F);
        // 100D:851F mov AH,byte ptr DS:[SI]
        AH = UInt8[DS, SI];
        // 100D:8521 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:8524 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8526 jne short 0x8540
        if (!ZeroFlag)
        {
            goto label_100D_8540_18610_29865;
        }
    label_100D_8528_185F8_31390:
        CheckExternalEvents(cs1, 0x8528);
        // 100D:8528 mov byte ptr DS:[DI+9],AH
        UInt8[DS, (ushort)(DI + (sbyte)9)] = AH;
        // 100D:852B mov CX,1
        CX = (ushort)0x0001;
        // 100D:852E mov byte ptr DS:[SI+2],CL
        UInt8[DS, (ushort)(SI + (sbyte)2)] = CL;
        // 100D:8531 test word ptr DS:[SI+0x10],0x0080
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0080);
        // 100D:8536 je short 0x853F
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:8536");
        }
    label_100D_853F_1860F_31396:
        CheckExternalEvents(cs1, 0x853F);
        // 100D:853F ret near
        return NearRet((ushort)0x0000);
    label_100D_8540_18610_29865:
        CheckExternalEvents(cs1, 0x8540);
        // 100D:8540 push DI
        Stack.Push16(DI);
        // 100D:8541 push DS
        Stack.Push16(DS);
        // 100D:8542 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8543 sub SP,0x001E
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:8546 mov DI,SP
        DI = SP;
        // 100D:8548 mov CX,0x001E
        CX = (ushort)0x001E;
        // 100D:854B push AX
        Stack.Push16(AX);
        // 100D:854C xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:854E rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:8550 pop AX
        AX = Stack.Pop16();
        // 100D:8551 mov DI,SP
        DI = SP;
        // 100D:8553 push SI
        Stack.Push16(SI);
        // 100D:8554 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_8556_18626_29879:
        CheckExternalEvents(cs1, 0x8556);
        // 100D:8556 call near 0x6906
        NearCall(cs1, 0x8559, unknown_100D_6906_169D6);
    label_100D_8559_18629_29880:
        CheckExternalEvents(cs1, 0x8559);
        // 100D:8559 mov BL,byte ptr DS:[SI+2]
        BL = UInt8[DS, (ushort)(SI + (sbyte)2)];
        // 100D:855C mov byte ptr DS:[BX+DI-1],0xFF
        UInt8[DS, (ushort)(BX + DI + (sbyte)-1)] = (byte)0xFF;
        // 100D:8560 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:8563 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8565 jne short 0x8556
        if (!ZeroFlag)
        {
            goto label_100D_8556_18626_29879;
        }
    label_100D_8567_18637_29886:
        CheckExternalEvents(cs1, 0x8567);
        // 100D:8567 mov byte ptr DS:[SI+1],AH
        UInt8[DS, (ushort)(SI + (sbyte)1)] = AH;
        // 100D:856A mov CX,0x001E
        CX = (ushort)0x001E;
        // 100D:856D pop SI
        SI = Stack.Pop16();
        // 100D:856E test word ptr DS:[SI+0x10],0x0080
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0080);
        // 100D:8573 je short 0x857B
        if (ZeroFlag)
        {
            goto label_100D_857B_1864B_29892;
        }
    label_100D_8575_18645_34250:
        CheckExternalEvents(cs1, 0x8575);
        // 100D:8575 sub CX,8
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 100D:8578 add DI,8
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)8)));
    label_100D_857B_1864B_29892:
        CheckExternalEvents(cs1, 0x857B);
        // 100D:857B xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 100D:857D repne scas AL,byte ptr ES:[DI]
        bool shouldContinue_100D_857D_1864D = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_857D_1864D)
        {
            Alu8.Sub(AL, UInt8[ES, DI]);
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_857D_1864D = ZeroFlag == false;
        }
        // 100D:857F sub CX,0x001E
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:8582 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:8584 add SP,0x001E
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)30)));
        // 100D:8587 pop DI
        DI = Stack.Pop16();
        // 100D:8588 mov byte ptr DS:[SI+2],CL
        UInt8[DS, (ushort)(SI + (sbyte)2)] = CL;
        // 100D:858B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_858C_1865C(int loadOffset)
    {
    label_100D_858C_1865C_29493:
        CheckExternalEvents(cs1, 0x858C);
        // 100D:858C mov BP,SI
        BP = SI;
        // 100D:858E mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:8590 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:8593 push DI
        Stack.Push16(DI);
        // 100D:8594 test byte ptr DS:[SI+3],0x40
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x40);
        // 100D:8598 jne short 0x85BA
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8598");
        }
    label_100D_859A_1866A_29500:
        CheckExternalEvents(cs1, 0x859A);
        // 100D:859A cmp AL,byte ptr DS:[DI+9]
        Alu8.Sub(AL, UInt8[DS, (ushort)(DI + (sbyte)9)]);
        // 100D:859D je short 0x85C2
        if (ZeroFlag)
        {
            goto label_100D_85C2_18692_29503;
        }
    label_100D_859F_1866F_30604:
        CheckExternalEvents(cs1, 0x859F);
        // 100D:859F mov CL,AL
        CL = AL;
        // 100D:85A1 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
    label_100D_85A4_18674_30607:
        CheckExternalEvents(cs1, 0x85A4);
        // 100D:85A4 call near 0x6906
        NearCall(cs1, 0x85A7, unknown_100D_6906_169D6);
    label_100D_85A7_18677_30608:
        CheckExternalEvents(cs1, 0x85A7);
        // 100D:85A7 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:85AA mov DI,SI
        DI = SI;
        // 100D:85AC or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:85AE je short 0x85BA
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:85AE");
        }
    label_100D_85B0_18680_30613:
        CheckExternalEvents(cs1, 0x85B0);
        // 100D:85B0 cmp AL,CL
        Alu8.Sub(AL, CL);
        // 100D:85B2 jne short 0x85A4
        if (!ZeroFlag)
        {
            goto label_100D_85A4_18674_30607;
        }
    label_100D_85B4_18684_30616:
        CheckExternalEvents(cs1, 0x85B4);
        // 100D:85B4 mov AH,byte ptr SS:[BP+1]
        AH = UInt8[SS, (ushort)(BP + (sbyte)1)];
        // 100D:85B7 mov byte ptr DS:[SI+1],AH
        UInt8[DS, (ushort)(SI + (sbyte)1)] = AH;
        // 100D:85BA mov SI,BP
        SI = BP;
        // 100D:85BC mov byte ptr DS:[SI+1],0
        UInt8[DS, (ushort)(SI + (sbyte)1)] = (byte)0x00;
        // 100D:85C0 pop DI
        DI = Stack.Pop16();
        // 100D:85C1 ret near
        return NearRet((ushort)0x0000);
    label_100D_85C2_18692_29503:
        CheckExternalEvents(cs1, 0x85C2);
        // 100D:85C2 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:85C4 xchg AH,byte ptr DS:[SI+1]
        ushort xchgOffset_100D_85C4_18694 = unchecked((ushort)(SI + (sbyte)1));
        byte temp_100D_85C4_18694 = AH;
        AH = UInt8[DS, xchgOffset_100D_85C4_18694];
        UInt8[DS, xchgOffset_100D_85C4_18694] = unchecked((byte)temp_100D_85C4_18694);
        // 100D:85C7 pop DI
        DI = Stack.Pop16();
        // 100D:85C8 mov byte ptr DS:[DI+9],AH
        UInt8[DS, (ushort)(DI + (sbyte)9)] = AH;
        // 100D:85CB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_85CC_1869C(int loadOffset)
    {
    label_100D_85CC_1869C_29904:
        CheckExternalEvents(cs1, 0x85CC);
        // 100D:85CC test word ptr DS:[SI+0x10],0x0080
        Alu16.And(UInt16[DS, (ushort)(SI + (sbyte)16)], (ushort)0x0080);
        // 100D:85D1 jne short 0x8603
        if (!ZeroFlag)
        {
            goto label_100D_8603_186D3_29910;
        }
    label_100D_85D3_186A3_29907:
        CheckExternalEvents(cs1, 0x85D3);
        // 100D:85D3 cmp byte ptr DS:[SI+2],8
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)2)], (byte)0x08);
        // 100D:85D7 jbe short 0x8603
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_8603_186D3_29910;
        }
    label_100D_85D9_186A9_38082:
        CheckExternalEvents(cs1, 0x85D9);
        // 100D:85D9 call near 0x858C
        NearCall(cs1, 0x85DC, unknown_100D_858C_1865C);
    label_100D_85DC_186AC_38085:
        CheckExternalEvents(cs1, 0x85DC);
        // 100D:85DC push SI
        Stack.Push16(SI);
        // 100D:85DD mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
    label_100D_85E0_186B0_38088:
        CheckExternalEvents(cs1, 0x85E0);
        // 100D:85E0 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:85E2 je short 0x85FF
        if (ZeroFlag)
        {
            goto label_100D_85FF_186CF_38090;
        }
    label_100D_85E4_186B4_38092:
        CheckExternalEvents(cs1, 0x85E4);
        // 100D:85E4 call near 0x6906
        NearCall(cs1, 0x85E7, unknown_100D_6906_169D6);
    label_100D_85E7_186B7_38101:
        CheckExternalEvents(cs1, 0x85E7);
        // 100D:85E7 mov AL,byte ptr DS:[SI+1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)1)];
        // 100D:85EA test byte ptr DS:[SI+0x10],0x80
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)16)], (byte)0x80);
        // 100D:85EE jne short 0x85E0
        if (!ZeroFlag)
        {
            goto label_100D_85E0_186B0_38088;
        }
    label_100D_85F0_186C0_38107:
        CheckExternalEvents(cs1, 0x85F0);
        // 100D:85F0 test byte ptr DS:[SI+3],0x20
        Alu8.And(UInt8[DS, (ushort)(SI + (sbyte)3)], (byte)0x20);
        // 100D:85F4 je short 0x85E0
        if (ZeroFlag)
        {
            goto label_100D_85E0_186B0_38088;
        }
    label_100D_85F6_186C6_38111:
        CheckExternalEvents(cs1, 0x85F6);
        // 100D:85F6 call near 0xE270
        NearCall(cs1, 0x85F9, unknown_100D_E270_1E340);
    label_100D_85F9_186C9_38119:
        CheckExternalEvents(cs1, 0x85F9);
        // 100D:85F9 call near 0x66B1
        NearCall(cs1, 0x85FC, unknown_100D_66B1_16781);
    label_100D_85FC_186CC_38122:
        CheckExternalEvents(cs1, 0x85FC);
        // 100D:85FC call near 0xE283
        NearCall(cs1, 0x85FF, unknown_100D_E283_1E353);
    label_100D_85FF_186CF_38090:
        CheckExternalEvents(cs1, 0x85FF);
        // 100D:85FF pop SI
        SI = Stack.Pop16();
        // 100D:8600 call near 0x851F
        NearCall(cs1, 0x8603, unknown_100D_851F_185EF);
    label_100D_8603_186D3_29910:
        CheckExternalEvents(cs1, 0x8603);
        // 100D:8603 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8604_186D4(int loadOffset)
    {
    label_100D_8604_186D4_29603:
        CheckExternalEvents(cs1, 0x8604);
        // 100D:8604 push SI
        Stack.Push16(SI);
        // 100D:8605 mov DI,word ptr DS:[SI+4]
        DI = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 100D:8608 mov DX,word ptr DS:[DI+2]
        DX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 100D:860B mov BX,word ptr DS:[SI+8]
        BX = UInt16[DS, (ushort)(SI + (sbyte)8)];
        // 100D:860E mov BP,BX
        BP = BX;
        // 100D:8610 shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 100D:8612 jns short 0x8616
        if (!SignFlag)
        {
            goto label_100D_8616_186E6_29613;
        }
    label_100D_8614_186E4_29611:
        CheckExternalEvents(cs1, 0x8614);
        // 100D:8614 neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_8616_186E6_29613:
        CheckExternalEvents(cs1, 0x8616);
        // 100D:8616 mov BP,word ptr SS:[BP+0x4880]
        BP = UInt16[SS, (ushort)(BP + (short)18560)];
        // 100D:861A sub BX,word ptr DS:[DI+4]
        BX = Alu16.Sub(BX, UInt16[DS, (ushort)(DI + (sbyte)4)]);
        // 100D:861D neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 100D:861F mov DI,1
        DI = (ushort)0x0001;
        // 100D:8622 jns short 0x8628
        if (!SignFlag)
        {
            goto label_100D_8628_186F8_29621;
        }
    label_100D_8624_186F4_29618:
        CheckExternalEvents(cs1, 0x8624);
        // 100D:8624 neg DI
        DI = Alu16.Sub((ushort)0x0000, DI);
        CarryFlag = DI != (ushort)0x0000;
        // 100D:8626 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_100D_8628_186F8_29621:
        CheckExternalEvents(cs1, 0x8628);
        // 100D:8628 sub DX,word ptr DS:[SI+6]
        DX = Alu16.Sub(DX, UInt16[DS, (ushort)(SI + (sbyte)6)]);
        // 100D:862B mov AX,DX
        AX = DX;
        // 100D:862D jns short 0x8631
        if (!SignFlag)
        {
            goto label_100D_8631_18701_29624;
        }
    label_100D_862F_186FF_30897:
        CheckExternalEvents(cs1, 0x862F);
        // 100D:862F neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
    label_100D_8631_18701_29624:
        CheckExternalEvents(cs1, 0x8631);
        // 100D:8631 mov SI,DX
        SI = DX;
        // 100D:8633 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8635 div BP
        ushort divisor_100D_8635_18705 = BP;
        uint dividend_100D_8635_18705 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_8635_18705 = Alu16.Div(unchecked((uint)dividend_100D_8635_18705), unchecked((ushort)divisor_100D_8635_18705));
        AX = unchecked((ushort)quotient_100D_8635_18705);
        DX = unchecked((ushort)(dividend_100D_8635_18705 % unchecked((uint)divisor_100D_8635_18705)));
        // 100D:8637 mov DX,SI
        DX = SI;
        // 100D:8639 xchg BX,DI
        ushort temp_100D_8639_18709 = BX;
        BX = DI;
        DI = unchecked((ushort)temp_100D_8639_18709);
        // 100D:863B cmp AX,DI
        Alu16.Sub(AX, DI);
        // 100D:863D jb short 0x8666
        if (CarryFlag)
        {
            goto label_100D_8666_18736_29736;
        }
    label_100D_863F_1870F_29632:
        CheckExternalEvents(cs1, 0x863F);
        // 100D:863F cmp AX,7
        Alu16.Sub(AX, (ushort)0x0007);
        // 100D:8642 jb short 0x8660
        if (CarryFlag)
        {
            goto label_100D_8660_18730_29810;
        }
    label_100D_8644_18714_29635:
        CheckExternalEvents(cs1, 0x8644);
        // 100D:8644 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:8646 jne short 0x864A
        if (!ZeroFlag)
        {
            goto label_100D_864A_1871A_29638;
        }
    label_100D_8648_18718_31347:
        CheckExternalEvents(cs1, 0x8648);
        // 100D:8648 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_864A_1871A_29638:
        CheckExternalEvents(cs1, 0x864A);
        // 100D:864A or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:864C jns short 0x8650
        if (!SignFlag)
        {
            goto label_100D_8650_18720_29641;
        }
    label_100D_864E_1871E_30899:
        CheckExternalEvents(cs1, 0x864E);
        // 100D:864E neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_8650_18720_29641:
        CheckExternalEvents(cs1, 0x8650);
        // 100D:8650 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:8652 je short 0x865E
        if (ZeroFlag)
        {
            goto label_100D_865E_1872E_29648;
        }
    label_100D_8654_18724_29644:
        CheckExternalEvents(cs1, 0x8654);
        // 100D:8654 mov DX,BP
        DX = BP;
        // 100D:8656 rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:865A jb short 0x865E
        if (CarryFlag)
        {
            goto label_100D_865E_1872E_29648;
        }
    label_100D_865C_1872C_29660:
        CheckExternalEvents(cs1, 0x865C);
        // 100D:865C xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_100D_865E_1872E_29648:
        CheckExternalEvents(cs1, 0x865E);
        // 100D:865E pop SI
        SI = Stack.Pop16();
        // 100D:865F ret near
        return NearRet((ushort)0x0000);
    label_100D_8660_18730_29810:
        CheckExternalEvents(cs1, 0x8660);
        // 100D:8660 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:8662 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8664 pop SI
        SI = Stack.Pop16();
        // 100D:8665 ret near
        return NearRet((ushort)0x0000);
    label_100D_8666_18736_29736:
        CheckExternalEvents(cs1, 0x8666);
        // 100D:8666 cmp DI,7
        Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 100D:8669 jb short 0x8660
        if (CarryFlag)
        {
            goto label_100D_8660_18730_29810;
        }
    label_100D_866B_1873B_29739:
        CheckExternalEvents(cs1, 0x866B);
        // 100D:866B or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:866D je short 0x865E
        if (ZeroFlag)
        {
            goto label_100D_865E_1872E_29648;
        }
    label_100D_866F_1873F_29742:
        CheckExternalEvents(cs1, 0x866F);
        // 100D:866F or DX,DX
        DX = Alu16.Or(DX, DX);
        // 100D:8671 jns short 0x8675
        if (!SignFlag)
        {
            goto label_100D_8675_18745_29745;
        }
    label_100D_8673_18743_32108:
        CheckExternalEvents(cs1, 0x8673);
        // 100D:8673 neg BP
        BP = Alu16.Sub((ushort)0x0000, BP);
        CarryFlag = BP != (ushort)0x0000;
    label_100D_8675_18745_29745:
        CheckExternalEvents(cs1, 0x8675);
        // 100D:8675 shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 100D:8677 je short 0x865E
        if (ZeroFlag)
        {
            goto label_100D_865E_1872E_29648;
        }
    label_100D_8679_18749_29748:
        CheckExternalEvents(cs1, 0x8679);
        // 100D:8679 mov DX,BP
        DX = BP;
        // 100D:867B rol word ptr DS:[0],1
        UInt16[DS, (ushort)0x0000] = Alu16.Rol(UInt16[DS, (ushort)0x0000], unchecked((byte)1));
        // 100D:867F jb short 0x865E
        if (CarryFlag)
        {
            goto label_100D_865E_1872E_29648;
        }
    label_100D_8681_18751_29752:
        CheckExternalEvents(cs1, 0x8681);
        // 100D:8681 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8683 pop SI
        SI = Stack.Pop16();
        // 100D:8684 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8751_18821(int loadOffset)
    {
    entrydispatcher:
    label_100D_8751_18821_24983:
        CheckExternalEvents(cs1, 0x8751);
        // 100D:8751 cmp byte ptr DS:[0x1954],0
        Alu8.Sub(UInt8[DS, (ushort)0x1954], (byte)0x00);
        // 100D:8756 je short 0x878B
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8756");
        }
    label_100D_8758_18828_24986:
        CheckExternalEvents(cs1, 0x8758);
        // 100D:8758 call near 0x69A3
        NearCall(cs1, 0x875B, unknown_100D_69A3_16A73);
    label_100D_875B_1882B_24990:
        CheckExternalEvents(cs1, 0x875B);
        // 100D:875B mov byte ptr DS:[0x1954],0
        UInt8[DS, (ushort)0x1954] = (byte)0x00;
        // 100D:8760 jmp near 0x7B58
        if (JumpDispatcher.Jump(unknown_100D_7B58_17C28, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8763_18833(int loadOffset)
    {
    entrydispatcher:
    label_100D_8763_18833_24967:
        CheckExternalEvents(cs1, 0x8763);
        // 100D:8763 cmp byte ptr DS:[0x46F3],0
        Alu8.Sub(UInt8[DS, (ushort)0x46F3], (byte)0x00);
        // 100D:8768 je short 0x8770
        if (ZeroFlag)
        {
            if (JumpDispatcher.Jump(unknown_100D_8770_18840, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
    label_100D_876A_1883A_24970:
        CheckExternalEvents(cs1, 0x876A);
        // 100D:876A call near 0x8770
        NearCall(cs1, 0x876D, unknown_100D_8770_18840);
    label_100D_876D_1883D_25105:
        CheckExternalEvents(cs1, 0x876D);
        // 100D:876D jmp near 0x186B
        if (JumpDispatcher.Jump(unknown_100D_186B_1193B, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8770_18840(int loadOffset)
    {
    entrydispatcher:
    label_100D_8770_18840_13243:
        CheckExternalEvents(cs1, 0x8770);
        // 100D:8770 cmp byte ptr DS:[0x1954],0
        Alu8.Sub(UInt8[DS, (ushort)0x1954], (byte)0x00);
        // 100D:8775 je short 0x878B
        if (ZeroFlag)
        {
            goto label_100D_878B_1885B_13246;
        }
    label_100D_8777_18847_24972:
        CheckExternalEvents(cs1, 0x8777);
        // 100D:8777 call near 0xE270
        NearCall(cs1, 0x877A, unknown_100D_E270_1E340);
    label_100D_877A_1884A_24974:
        CheckExternalEvents(cs1, 0x877A);
        // 100D:877A mov byte ptr DS:[0x46F3],0
        UInt8[DS, (ushort)0x46F3] = (byte)0x00;
        // 100D:877F call near 0x878C
        NearCall(cs1, 0x8782, unknown_100D_878C_1885C);
    label_100D_8782_18852_25102:
        CheckExternalEvents(cs1, 0x8782);
        // 100D:8782 mov word ptr DS:[0x1BEA],0
        UInt16[DS, (ushort)0x1BEA] = (ushort)0x0000;
        // 100D:8788 call near 0xE283
        NearCall(cs1, 0x878B, unknown_100D_E283_1E353);
    label_100D_878B_1885B_13246:
        CheckExternalEvents(cs1, 0x878B);
        // 100D:878B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_878C_1885C(int loadOffset)
    {
    entrydispatcher:
    label_100D_878C_1885C_18332:
        CheckExternalEvents(cs1, 0x878C);
        // 100D:878C mov word ptr DS:[0x47BA],0
        UInt16[DS, (ushort)0x47BA] = (ushort)0x0000;
        // 100D:8792 mov AX,0x40A7
        AX = (ushort)0x40A7;
        // 100D:8795 cmp byte ptr DS:[8],0xFF
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0xFF);
        // 100D:879A je short 0x87C0
        if (ZeroFlag)
        {
            goto label_100D_87C0_18890_18343;
        }
    label_100D_879C_1886C_18337:
        CheckExternalEvents(cs1, 0x879C);
        // 100D:879C cmp byte ptr DS:[8],0x20
        Alu8.Sub(UInt8[DS, (ushort)0x0008], (byte)0x20);
        // 100D:87A1 jb short 0x87AA
        if (CarryFlag)
        {
            goto label_100D_87AA_1887A_23557;
        }
    label_100D_87A3_18873_18340:
        CheckExternalEvents(cs1, 0x87A3);
        // 100D:87A3 cmp byte ptr DS:[0x000B],3
        Alu8.Sub(UInt8[DS, (ushort)0x000B], (byte)0x03);
        // 100D:87A8 jae short 0x87C0
        if (!CarryFlag)
        {
            goto label_100D_87C0_18890_18343;
        }
    label_100D_87AA_1887A_23557:
        CheckExternalEvents(cs1, 0x87AA);
        // 100D:87AA push DI
        Stack.Push16(DI);
        // 100D:87AB mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:87AF call near 0x7F27
        NearCall(cs1, 0x87B2, unknown_100D_7F27_17FF7);
    label_100D_87B2_18882_23561:
        CheckExternalEvents(cs1, 0x87B2);
        // 100D:87B2 pop DI
        DI = Stack.Pop16();
        // 100D:87B3 mov AX,0x00A7
        AX = (ushort)0x00A7;
        // 100D:87B6 cmp byte ptr DS:[0x46FF],0
        Alu8.Sub(UInt8[DS, (ushort)0x46FF], (byte)0x00);
        // 100D:87BB jne short 0x87C0
        if (!ZeroFlag)
        {
            goto label_100D_87C0_18890_18343;
        }
    label_100D_87BD_1888D_36531:
        CheckExternalEvents(cs1, 0x87BD);
        // 100D:87BD or AH,0x40
        AH = Alu8.Or(AH, (byte)0x40);
    label_100D_87C0_18890_18343:
        CheckExternalEvents(cs1, 0x87C0);
        // 100D:87C0 mov BP,0x20F2
        BP = (ushort)0x20F2;
        // 100D:87C3 mov word ptr SS:[BP+0x0E],AX
        UInt16[SS, (ushort)(BP + (sbyte)14)] = AX;
        // 100D:87C6 or byte ptr SS:[BP+0x0B],0x40
        UInt8[SS, (ushort)(BP + (sbyte)11)] = Alu8.Or(UInt8[SS, (ushort)(BP + (sbyte)11)], (byte)0x40);
        // 100D:87CA mov word ptr SS:[BP+0x12],0
        UInt16[SS, (ushort)(BP + (sbyte)18)] = (ushort)0x0000;
        // 100D:87CF cmp byte ptr DS:[0x002A],5
        Alu8.Sub(UInt8[DS, (ushort)0x002A], (byte)0x05);
        // 100D:87D4 jb short 0x87DF
        if (CarryFlag)
        {
            goto label_100D_87DF_188AF_18350;
        }
    label_100D_87D6_188A6_28314:
        CheckExternalEvents(cs1, 0x87D6);
        // 100D:87D6 and byte ptr SS:[BP+0x0B],0xBF
        UInt8[SS, (ushort)(BP + (sbyte)11)] = Alu8.And(UInt8[SS, (ushort)(BP + (sbyte)11)], (byte)0xBF);
        // 100D:87DA mov word ptr SS:[BP+0x12],0x0067
        UInt16[SS, (ushort)(BP + (sbyte)18)] = (ushort)0x0067;
    label_100D_87DF_188AF_18350:
        CheckExternalEvents(cs1, 0x87DF);
        // 100D:87DF cmp word ptr DS:[0x1176],2
        Alu16.Sub(UInt16[DS, (ushort)0x1176], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:87E4 jae short 0x8806
        if (!CarryFlag)
        {
            goto label_100D_8806_188D6_33350;
        }
    label_100D_87E6_188B6_18353:
        CheckExternalEvents(cs1, 0x87E6);
        // 100D:87E6 mov word ptr SS:[BP+6],0x4093
        UInt16[SS, (ushort)(BP + (sbyte)6)] = (ushort)0x4093;
        // 100D:87EB mov DI,word ptr DS:[0x114E]
        DI = UInt16[DS, (ushort)0x114E];
        // 100D:87EF or DI,DI
        DI = Alu16.Or(DI, DI);
        // 100D:87F1 je short 0x8816
        if (ZeroFlag)
        {
            goto label_100D_8816_188E6_18362;
        }
    label_100D_87F3_188C3_18358:
        CheckExternalEvents(cs1, 0x87F3);
        // 100D:87F3 mov AL,byte ptr DS:[DI+9]
        AL = UInt8[DS, (ushort)(DI + (sbyte)9)];
        // 100D:87F6 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:87F8 je short 0x8816
        if (ZeroFlag)
        {
            goto label_100D_8816_188E6_18362;
        }
    label_100D_87FA_188CA_23566:
        CheckExternalEvents(cs1, 0x87FA);
        // 100D:87FA call near 0x6906
        NearCall(cs1, 0x87FD, unknown_100D_6906_169D6);
    label_100D_87FD_188CD_23568:
        CheckExternalEvents(cs1, 0x87FD);
        // 100D:87FD jae short 0x8816
        if (!CarryFlag)
        {
            goto label_100D_8816_188E6_18362;
        }
    label_100D_87FF_188CF_23570:
        CheckExternalEvents(cs1, 0x87FF);
        // 100D:87FF and word ptr SS:[BP+6],0xBFFF
        UInt16[SS, (ushort)(BP + (sbyte)6)] = Alu16.And(UInt16[SS, (ushort)(BP + (sbyte)6)], (ushort)0xBFFF);
        // 100D:8804 jmp short 0x8816
        goto label_100D_8816_188E6_18362;
    label_100D_8806_188D6_33350:
        CheckExternalEvents(cs1, 0x8806);
        // 100D:8806 mov AX,0x0062
        AX = (ushort)0x0062;
        // 100D:8809 cmp word ptr DS:[0x3CBE],0
        Alu16.Sub(UInt16[DS, (ushort)0x3CBE], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 100D:880E jne short 0x8813
        if (!ZeroFlag)
        {
            goto label_100D_8813_188E3_33354;
        }
    label_100D_8810_188E0_33795:
        CheckExternalEvents(cs1, 0x8810);
        // 100D:8810 or AH,0x40
        AH = Alu8.Or(AH, (byte)0x40);
    label_100D_8813_188E3_33354:
        CheckExternalEvents(cs1, 0x8813);
        // 100D:8813 mov word ptr SS:[BP+6],AX
        UInt16[SS, (ushort)(BP + (sbyte)6)] = AX;
    label_100D_8816_188E6_18362:
        CheckExternalEvents(cs1, 0x8816);
        // 100D:8816 mov BX,0x0F66
        BX = (ushort)0x0F66;
        // 100D:8819 call near 0xD338
        NearCall(cs1, 0x881C, unknown_100D_D338_1D408);
    label_100D_881C_188EC_18365:
        CheckExternalEvents(cs1, 0x881C);
        // 100D:881C jmp near 0xC13B
        return unknown_100D_C13B_1C20B(0x0000);
    }

    public virtual Action unknown_100D_881F_188EF(int loadOffset)
    {
    entrydispatcher:
    label_100D_881F_188EF_28202:
        CheckExternalEvents(cs1, 0x881F);
        // 100D:881F mov SI,0x146A
        SI = (ushort)0x146A;
        // 100D:8822 jmp short 0x8831
        if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8824_188F4(int loadOffset)
    {
    entrydispatcher:
    label_100D_8824_188F4_31340:
        CheckExternalEvents(cs1, 0x8824);
        // 100D:8824 mov SI,0x1462
        SI = (ushort)0x1462;
        // 100D:8827 jmp short 0x8831
        if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8829_188F9(int loadOffset)
    {
    entrydispatcher:
    label_100D_8829_188F9_29695:
        CheckExternalEvents(cs1, 0x8829);
        // 100D:8829 mov SI,0x145E
        SI = (ushort)0x145E;
        // 100D:882C jmp short 0x8831
        if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_882E_188FE(int loadOffset)
    {
    entrydispatcher:
    label_100D_882E_188FE_29783:
        CheckExternalEvents(cs1, 0x882E);
        // 100D:882E mov SI,0x1466
        SI = (ushort)0x1466;
        if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_8850_18920(int loadOffset)
    {
    entrydispatcher:
    label_100D_8850_18920_28216:
        CheckExternalEvents(cs1, 0x8850);
        // 100D:8850 call near 0x7B36
        NearCall(cs1, 0x8853, unknown_100D_7B36_17C06);
    label_100D_8853_18923_28217:
        CheckExternalEvents(cs1, 0x8853);
        // 100D:8853 call near word ptr DS:[0x46ED]
        switch ((ushort)(UInt16[DS, (ushort)0x46ED]))
        {
            case 0x4377:
                NearCall(cs1, 0x8857, unknown_100D_4377_14447);
                if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x8857))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            case 0x5A9A:
                NearCall(cs1, 0x8857, unknown_100D_5A9A_15B6A);
                if (JumpDispatcher.Jump(unknown_100D_8831_18901, 0x8857))
                {
                    loadOffset = JumpDispatcher.NextEntryAddress;
                    goto entrydispatcher;
                }
                return JumpDispatcher.RequiredJumpAsmReturn;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)0x46ED])):X4} at 100D:8853");
        }
    }

    public virtual Action unknown_100D_8865_18935(int loadOffset)
    {
    label_100D_8865_18935_30026:
        CheckExternalEvents(cs1, 0x8865);
        // 100D:8865 call near 0xE270
        NearCall(cs1, 0x8868, unknown_100D_E270_1E340);
    label_100D_8868_18938_30028:
        CheckExternalEvents(cs1, 0x8868);
        // 100D:8868 mov SI,AX
        SI = AX;
        // 100D:886A mov word ptr DS:[0xDBE4],CX
        UInt16[DS, (ushort)0xDBE4] = CX;
        // 100D:886E call near 0xD04E
        NearCall(cs1, 0x8871, unknown_100D_D04E_1D11E);
    label_100D_8871_18941_30032:
        CheckExternalEvents(cs1, 0x8871);
        // 100D:8871 call near 0xCF70
        NearCall(cs1, 0x8874, unknown_100D_CF70_1D040);
    label_100D_8874_18944_30034:
        CheckExternalEvents(cs1, 0x8874);
        // 100D:8874 call near 0x88F1
        NearCall(cs1, 0x8877, unknown_100D_88F1_189C1);
    label_100D_8877_18947_30036:
        CheckExternalEvents(cs1, 0x8877);
        // 100D:8877 mov DI,0xA6B0
        DI = (ushort)0xA6B0;
        // 100D:887A push DI
        Stack.Push16(DI);
        // 100D:887B call near 0x8944
        NearCall(cs1, 0x887E, unknown_100D_8944_18A14);
    label_100D_887E_1894E_30040:
        CheckExternalEvents(cs1, 0x887E);
        // 100D:887E pop SI
        SI = Stack.Pop16();
        // 100D:887F push DS
        Stack.Push16(DS);
        // 100D:8880 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8881 call near 0xD1BB
        NearCall(cs1, 0x8884, unknown_100D_D1BB_1D28B);
    label_100D_8884_18954_30045:
        CheckExternalEvents(cs1, 0x8884);
        // 100D:8884 call near 0xE283
        NearCall(cs1, 0x8887, unknown_100D_E283_1E353);
    label_100D_8887_18957_30047:
        CheckExternalEvents(cs1, 0x8887);
        // 100D:8887 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_88AF_1897F(int loadOffset)
    {
    entrydispatcher:
    label_100D_88AF_1897F_11728:
        CheckExternalEvents(cs1, 0x88AF);
        // 100D:88AF or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:88B1 je short 0x88AE
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:88B1");
        }
    label_100D_88B3_18983_11731:
        CheckExternalEvents(cs1, 0x88B3);
        // 100D:88B3 mov word ptr DS:[0x4780],AX
        UInt16[DS, (ushort)0x4780] = AX;
        // 100D:88B6 mov byte ptr DS:[0x47E0],0
        UInt8[DS, (ushort)0x47E0] = (byte)0x00;
        // 100D:88BB test byte ptr DS:[0x46EB],0x40
        Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0x40);
        // 100D:88C0 je short 0x88CA
        if (ZeroFlag)
        {
            goto label_100D_88CA_1899A_11736;
        }
    label_100D_88C2_18992_28423:
        CheckExternalEvents(cs1, 0x88C2);
        // 100D:88C2 and byte ptr DS:[0x46EB],0xBF
        UInt8[DS, (ushort)0x46EB] = Alu8.And(UInt8[DS, (ushort)0x46EB], (byte)0xBF);
        // 100D:88C7 jmp near 0x80DF
        if (JumpDispatcher.Jump(unknown_100D_80DF_181AF, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    label_100D_88CA_1899A_11736:
        CheckExternalEvents(cs1, 0x88CA);
        // 100D:88CA mov SI,AX
        SI = AX;
        // 100D:88CC call near 0xCF70
        NearCall(cs1, 0x88CF, unknown_100D_CF70_1D040);
    label_100D_88CF_1899F_11750:
        CheckExternalEvents(cs1, 0x88CF);
        // 100D:88CF call near 0x88F1
        NearCall(cs1, 0x88D2, unknown_100D_88F1_189C1);
        if (JumpDispatcher.Jump(unknown_100D_88D2_189A2, 0x0000))
        {
            loadOffset = JumpDispatcher.NextEntryAddress;
            goto entrydispatcher;
        }
        return JumpDispatcher.RequiredJumpAsmReturn;
    }

    public virtual Action unknown_100D_88D2_189A2(int loadOffset)
    {
    entrydispatcher:
        goto label_100D_88D2_189A2_11781;

    label_100D_8888_18958_15713:
        CheckExternalEvents(cs1, 0x8888);
        // 100D:8888 cmp byte ptr DS:[0x46D9],0
        Alu8.Sub(UInt8[DS, (ushort)0x46D9], (byte)0x00);
        // 100D:888D jne short 0x88E1
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:888D");
        }
    label_100D_888F_1895F_15716:
        CheckExternalEvents(cs1, 0x888F);
        // 100D:888F mov word ptr DS:[0x479E],1
        UInt16[DS, (ushort)0x479E] = (ushort)0x0001;
        return unknown_100D_8895_18965(0x0000);
    label_100D_88D2_189A2_11781:
        CheckExternalEvents(cs1, 0x88D2);
        // 100D:88D2 mov DI,0xA6B0
        DI = (ushort)0xA6B0;
        // 100D:88D5 push DI
        Stack.Push16(DI);
        // 100D:88D6 call near 0x8944
        NearCall(cs1, 0x88D9, unknown_100D_8944_18A14);
    label_100D_88D9_189A9_11820:
        CheckExternalEvents(cs1, 0x88D9);
        // 100D:88D9 pop SI
        SI = Stack.Pop16();
        // 100D:88DA cmp byte ptr DS:[0x28E7],2
        Alu8.Sub(UInt8[DS, (ushort)0x28E7], (byte)0x02);
        // 100D:88DF jae short 0x8888
        if (!CarryFlag)
        {
            goto label_100D_8888_18958_15713;
        }
        else
        {
            if (JumpDispatcher.Jump(unknown_100D_88E1_189B1, 0x0000))
            {
                loadOffset = JumpDispatcher.NextEntryAddress;
                goto entrydispatcher;
            }
            return JumpDispatcher.RequiredJumpAsmReturn;
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_100D_88E1_189B1(int loadOffset)
    {
    entrydispatcher:
    label_100D_88E1_189B1_11824:
        CheckExternalEvents(cs1, 0x88E1);
        // 100D:88E1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:88E2 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:88E4 js short 0x88F0
        if (SignFlag)
        {
            goto label_100D_88F0_189C0_12277;
        }
    label_100D_88E6_189B6_11828:
        CheckExternalEvents(cs1, 0x88E6);
        // 100D:88E6 dec SI
        SI = Alu16.Dec(SI);
        // 100D:88E7 call near 0x8B11
        NearCall(cs1, 0x88EA, unknown_100D_8B11_18BE1);
    label_100D_88EA_189BA_12274:
        CheckExternalEvents(cs1, 0x88EA);
        // 100D:88EA cmp byte ptr DS:[SI],0xFE
        Alu8.Sub(UInt8[DS, SI], (byte)0xFE);
        // 100D:88ED jae short 0x88F0
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 100D:88ED");
        }
    label_100D_88F0_189C0_12277:
        CheckExternalEvents(cs1, 0x88F0);
        // 100D:88F0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_88F1_189C1(int loadOffset)
    {
    label_100D_88F1_189C1_11752:
        CheckExternalEvents(cs1, 0x88F1);
        // 100D:88F1 push DS
        Stack.Push16(DS);
        // 100D:88F2 push ES
        Stack.Push16(ES);
        // 100D:88F3 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:88F4 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:88F5 mov DI,0xA840
        DI = (ushort)0xA840;
    label_100D_88F8_189C8_11758:
        CheckExternalEvents(cs1, 0x88F8);
        // 100D:88F8 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:88F9 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:88FB je short 0x893D
        if (ZeroFlag)
        {
            goto label_100D_893D_18A0D_11775;
        }
    label_100D_88FD_189CD_11761:
        CheckExternalEvents(cs1, 0x88FD);
        // 100D:88FD cmp AL,0xFE
        Alu8.Sub(AL, (byte)0xFE);
        // 100D:88FF je short 0x8905
        if (ZeroFlag)
        {
            goto label_100D_8905_189D5_11767;
        }
    label_100D_8901_189D1_11764:
        CheckExternalEvents(cs1, 0x8901);
        // 100D:8901 cmp AL,0xE0
        Alu8.Sub(AL, (byte)0xE0);
        // 100D:8903 jae short 0x8910
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8903");
        }
    label_100D_8905_189D5_11767:
        CheckExternalEvents(cs1, 0x8905);
        // 100D:8905 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:8906 mov AL,0xFF
        AL = (byte)0xFF;
        // 100D:8908 cmp DI,0xA9CF
        Alu16.Sub(DI, (ushort)0xA9CF);
        // 100D:890C jae short 0x893D
        if (!CarryFlag)
        {
            goto label_100D_893D_18A0D_11775;
        }
    label_100D_890E_189DE_11772:
        CheckExternalEvents(cs1, 0x890E);
        // 100D:890E jmp short 0x88F8
        goto label_100D_88F8_189C8_11758;
    label_100D_893D_18A0D_11775:
        CheckExternalEvents(cs1, 0x893D);
        // 100D:893D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:893E mov SI,0xA840
        SI = (ushort)0xA840;
        // 100D:8941 push SS
        Stack.Push16(SS);
        // 100D:8942 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8943 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8944_18A14(int loadOffset)
    {
    label_100D_8944_18A14_11785:
        CheckExternalEvents(cs1, 0x8944);
        // 100D:8944 sub SP,0x0032
        SP = Alu16.Sub(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:8947 mov BP,SP
        BP = SP;
        // 100D:8949 push DS
        Stack.Push16(DS);
        // 100D:894A pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_100D_894B_18A1B_11790:
        CheckExternalEvents(cs1, 0x894B);
        // 100D:894B cmp byte ptr DS:[SI],0x20
        Alu8.Sub(UInt8[DS, SI], (byte)0x20);
        // 100D:894E jne short 0x8953
        if (!ZeroFlag)
        {
            goto label_100D_8953_18A23_11792;
        }
    label_100D_8950_18A20_26973:
        CheckExternalEvents(cs1, 0x8950);
        // 100D:8950 inc SI
        SI = Alu16.Inc(SI);
        // 100D:8951 jmp short 0x894B
        goto label_100D_894B_18A1B_11790;
    label_100D_8953_18A23_11792:
        CheckExternalEvents(cs1, 0x8953);
        // 100D:8953 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:8954 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8956 js short 0x895B
        if (SignFlag)
        {
            goto label_100D_895B_18A2B_11799;
        }
    label_100D_8958_18A28_11796:
        CheckExternalEvents(cs1, 0x8958);
        // 100D:8958 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:8959 jmp short 0x8953
        goto label_100D_8953_18A23_11792;
    label_100D_895B_18A2B_11799:
        CheckExternalEvents(cs1, 0x895B);
        // 100D:895B mov byte ptr DS:[0x477F],AL
        UInt8[DS, (ushort)0x477F] = AL;
        // 100D:895E cmp AL,0xF0
        Alu8.Sub(AL, (byte)0xF0);
        // 100D:8960 jae short 0x89B0
        if (!CarryFlag)
        {
            goto label_100D_89B0_18A80_11803;
        }
    label_100D_8962_18A32_20400:
        CheckExternalEvents(cs1, 0x8962);
        // 100D:8962 cmp AL,0xD0
        Alu8.Sub(AL, (byte)0xD0);
        // 100D:8964 jae short 0x899B
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8964");
        }
    label_100D_8966_18A36_20403:
        CheckExternalEvents(cs1, 0x8966);
        // 100D:8966 cmp AL,0xA0
        Alu8.Sub(AL, (byte)0xA0);
        // 100D:8968 jae short 0x89AD
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8968");
        }
    label_100D_896A_18A3A_20406:
        CheckExternalEvents(cs1, 0x896A);
        // 100D:896A cmp AL,0x90
        Alu8.Sub(AL, (byte)0x90);
        // 100D:896C jb short 0x8970
        if (CarryFlag)
        {
            goto label_100D_8970_18A40_20409;
        }
    label_100D_896E_18A3E_24807:
        CheckExternalEvents(cs1, 0x896E);
        // 100D:896E jmp short 0x89E4
        goto label_100D_89E4_18AB4_24809;
    label_100D_8970_18A40_20409:
        CheckExternalEvents(cs1, 0x8970);
        // 100D:8970 cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 100D:8972 jne short 0x8979
        if (!ZeroFlag)
        {
            goto label_100D_8979_18A49_24342;
        }
    label_100D_8974_18A44_20412:
        CheckExternalEvents(cs1, 0x8974);
        // 100D:8974 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:8975 xchg AH,AL
        byte temp_100D_8975_18A45 = AH;
        AH = AL;
        AL = unchecked((byte)temp_100D_8975_18A45);
        // 100D:8977 jmp short 0x8984
        goto label_100D_8984_18A54_20416;
    label_100D_8979_18A49_24342:
        CheckExternalEvents(cs1, 0x8979);
        // 100D:8979 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 100D:897C shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 100D:897E mov BX,AX
        BX = AX;
        // 100D:8980 mov AX,word ptr DS:[BX+0x11EB]
        AX = UInt16[DS, (ushort)(BX + (short)4587)];
    label_100D_8984_18A54_20416:
        CheckExternalEvents(cs1, 0x8984);
        // 100D:8984 mov word ptr SS:[BP],SI
        UInt16[SS, (ushort)(BP + (sbyte)0)] = SI;
        // 100D:8987 mov word ptr SS:[BP+2],DS
        UInt16[SS, (ushort)(BP + (sbyte)2)] = DS;
        // 100D:898A add BP,4
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:898D mov SI,AX
        SI = AX;
        // 100D:898F call near 0x8A3B
        NearCall(cs1, 0x8992, unknown_100D_8A3B_18B0B);
    label_100D_8992_18A62_20427:
        CheckExternalEvents(cs1, 0x8992);
        // 100D:8992 push ES
        Stack.Push16(ES);
        // 100D:8993 call near 0xCF70
        NearCall(cs1, 0x8996, unknown_100D_CF70_1D040);
    label_100D_8996_18A66_20430:
        CheckExternalEvents(cs1, 0x8996);
        // 100D:8996 push ES
        Stack.Push16(ES);
        // 100D:8997 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8998 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:8999 jmp short 0x8953
        goto label_100D_8953_18A23_11792;
    label_100D_89B0_18A80_11803:
        CheckExternalEvents(cs1, 0x89B0);
        // 100D:89B0 mov BX,SP
        BX = SP;
        // 100D:89B2 cmp BP,BX
        Alu16.Sub(BP, BX);
        // 100D:89B4 je short 0x89C1
        if (ZeroFlag)
        {
            goto label_100D_89C1_18A91_11807;
        }
    label_100D_89B6_18A86_20435:
        CheckExternalEvents(cs1, 0x89B6);
        // 100D:89B6 sub BP,4
        BP = Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:89B9 mov SI,word ptr SS:[BP]
        SI = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 100D:89BC mov DS,word ptr SS:[BP+2]
        DS = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 100D:89BF jmp short 0x8953
        goto label_100D_8953_18A23_11792;
    label_100D_89C1_18A91_11807:
        CheckExternalEvents(cs1, 0x89C1);
        // 100D:89C1 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:89C2 cmp AL,0xFF
        Alu8.Sub(AL, (byte)0xFF);
        // 100D:89C4 jne short 0x89C8
        if (!ZeroFlag)
        {
            goto label_100D_89C8_18A98_11813;
        }
    label_100D_89C6_18A96_11811:
        CheckExternalEvents(cs1, 0x89C6);
        // 100D:89C6 xor SI,SI
        SI = Alu16.Xor(SI, SI);
    label_100D_89C8_18A98_11813:
        CheckExternalEvents(cs1, 0x89C8);
        // 100D:89C8 mov word ptr DS:[0x47B6],SI
        UInt16[DS, (ushort)0x47B6] = SI;
        // 100D:89CC mov word ptr DS:[0x47B8],DS
        UInt16[DS, (ushort)0x47B8] = DS;
        // 100D:89D0 add SP,0x0032
        SP = Alu16.Add(SP, unchecked((ushort)unchecked((short)(sbyte)50)));
        // 100D:89D3 test byte ptr DS:[0x47DE],0x10
        Alu8.And(UInt8[DS, (ushort)0x47DE], (byte)0x10);
        // 100D:89D8 je short 0x89E3
        if (ZeroFlag)
        {
            goto label_100D_89E3_18AB3_11818;
        }
    label_100D_89DA_18AAA_23209:
        CheckExternalEvents(cs1, 0x89DA);
        // 100D:89DA mov BX,3
        BX = (ushort)0x0003;
        // 100D:89DD call near 0xE3B7
        NearCall(cs1, 0x89E0, unknown_100D_E3B7_1E487);
    label_100D_89E0_18AB0_23212:
        CheckExternalEvents(cs1, 0x89E0);
        // 100D:89E0 call near 0x8AC3
        NearCall(cs1, 0x89E3, unknown_100D_8AC3_18B93);
    label_100D_89E3_18AB3_11818:
        CheckExternalEvents(cs1, 0x89E3);
        // 100D:89E3 ret near
        return NearRet((ushort)0x0000);
    label_100D_89E4_18AB4_24809:
        CheckExternalEvents(cs1, 0x89E4);
        // 100D:89E4 push BP
        Stack.Push16(BP);
        // 100D:89E5 mov BL,AL
        BL = AL;
        // 100D:89E7 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:89E8 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 100D:89EA mov BP,AX
        BP = AX;
        // 100D:89EC mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (short)0)];
        // 100D:89F0 cmp BL,0x92
        Alu8.Sub(BL, (byte)0x92);
        // 100D:89F3 je short 0x89F7
        if (ZeroFlag)
        {
            goto label_100D_89F7_18AC7_24820;
        }
    label_100D_89F5_18AC5_24818:
        CheckExternalEvents(cs1, 0x89F5);
        // 100D:89F5 xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_100D_89F7_18AC7_24820:
        CheckExternalEvents(cs1, 0x89F7);
        // 100D:89F7 push AX
        Stack.Push16(AX);
        // 100D:89F8 call near 0x8ACC
        NearCall(cs1, 0x89FB, unknown_100D_8ACC_18B9C);
    label_100D_89FB_18ACB_24839:
        CheckExternalEvents(cs1, 0x89FB);
        // 100D:89FB pop AX
        AX = Stack.Pop16();
        // 100D:89FC call near 0x8A23
        NearCall(cs1, 0x89FF, unknown_100D_8A23_18AF3);
    label_100D_89FF_18ACF_24855:
        CheckExternalEvents(cs1, 0x89FF);
        // 100D:89FF xchg BX,AX
        ushort temp_100D_89FF_18ACF = BX;
        BX = AX;
        AX = unchecked((ushort)temp_100D_89FF_18ACF);
        // 100D:8A00 mov CX,5
        CX = (ushort)0x0005;
        // 100D:8A03 jmp short 0x8A0D
        goto label_100D_8A0D_18ADD_24859;
    label_100D_8A05_18AD5_24862:
        CheckExternalEvents(cs1, 0x8A05);
        // 100D:8A05 mov AL,DH
        AL = DH;
        // 100D:8A07 mov DH,DL
        DH = DL;
        // 100D:8A09 mov DL,BH
        DL = BH;
        // 100D:8A0B mov BH,BL
        BH = BL;
    label_100D_8A0D_18ADD_24859:
        CheckExternalEvents(cs1, 0x8A0D);
        // 100D:8A0D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:8A0F loope 0x8A05
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && ZeroFlag)
        {
            goto label_100D_8A05_18AD5_24862;
        }
    label_100D_8A11_18AE1_24867:
        CheckExternalEvents(cs1, 0x8A11);
        // 100D:8A11 inc CX
        CX = Alu16.Inc(CX);
    label_100D_8A12_18AE2_24869:
        CheckExternalEvents(cs1, 0x8A12);
        // 100D:8A12 add AL,0x30
        AL = Alu8.Add(AL, (byte)0x30);
        // 100D:8A14 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 100D:8A15 mov AL,DH
        AL = DH;
        // 100D:8A17 mov DH,DL
        DH = DL;
        // 100D:8A19 mov DL,BH
        DL = BH;
        // 100D:8A1B mov BH,BL
        BH = BL;
        // 100D:8A1D loop 0x8A12
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_8A12_18AE2_24869;
        }
    label_100D_8A1F_18AEF_24877:
        CheckExternalEvents(cs1, 0x8A1F);
        // 100D:8A1F pop BP
        BP = Stack.Pop16();
        // 100D:8A20 jmp near 0x8953
        goto label_100D_8953_18A23_11792;
    }

    public virtual Action unknown_100D_8A23_18AF3(int loadOffset)
    {
    label_100D_8A23_18AF3_24842:
        CheckExternalEvents(cs1, 0x8A23);
        // 100D:8A23 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8A25 mov CX,0x2710
        CX = (ushort)0x2710;
        // 100D:8A28 div CX
        ushort divisor_100D_8A28_18AF8 = CX;
        uint dividend_100D_8A28_18AF8 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_8A28_18AF8 = Alu16.Div(unchecked((uint)dividend_100D_8A28_18AF8), unchecked((ushort)divisor_100D_8A28_18AF8));
        AX = unchecked((ushort)quotient_100D_8A28_18AF8);
        DX = unchecked((ushort)(dividend_100D_8A28_18AF8 % unchecked((uint)divisor_100D_8A28_18AF8)));
        // 100D:8A2A mov BL,AL
        BL = AL;
        // 100D:8A2C mov CX,0x0064
        CX = (ushort)0x0064;
        // 100D:8A2F mov AX,DX
        AX = DX;
        // 100D:8A31 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:8A33 div CX
        ushort divisor_100D_8A33_18B03 = CX;
        uint dividend_100D_8A33_18B03 = unchecked((uint)(unchecked((uint)DX) << 16 | unchecked((uint)AX)));
        ushort quotient_100D_8A33_18B03 = Alu16.Div(unchecked((uint)dividend_100D_8A33_18B03), unchecked((ushort)divisor_100D_8A33_18B03));
        AX = unchecked((ushort)quotient_100D_8A33_18B03);
        DX = unchecked((ushort)(dividend_100D_8A33_18B03 % unchecked((uint)divisor_100D_8A33_18B03)));
        // 100D:8A35 aam
        byte v2_100D_8A35_18B05 = (byte)0x0A;
        byte v1_100D_8A35_18B05 = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_8A35_18B05 >> (byte)0x01)));
        if (v2_100D_8A35_18B05 == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_8A35_18B05 = unchecked((byte)(v1_100D_8A35_18B05 % v2_100D_8A35_18B05));
        AH = unchecked((byte)(v1_100D_8A35_18B05 / v2_100D_8A35_18B05));
        AL = unchecked((byte)result_100D_8A35_18B05);
        Alu8.UpdateFlags(unchecked((byte)result_100D_8A35_18B05));
        // 100D:8A37 xchg DX,AX
        ushort temp_100D_8A37_18B07 = DX;
        DX = AX;
        AX = unchecked((ushort)temp_100D_8A37_18B07);
        // 100D:8A38 aam
        byte v2_100D_8A38_18B08 = (byte)0x0A;
        byte v1_100D_8A38_18B08 = AL;
        Alu8.UpdateFlags(unchecked((byte)(v1_100D_8A38_18B08 >> (byte)0x01)));
        if (v2_100D_8A38_18B08 == (byte)0x00)
        {
            throw new Spice86.Core.Emulator.CPU.Exceptions.CpuDivisionErrorException("Division by zero");
        }
        else
        {
        }
        byte result_100D_8A38_18B08 = unchecked((byte)(v1_100D_8A38_18B08 % v2_100D_8A38_18B08));
        AH = unchecked((byte)(v1_100D_8A38_18B08 / v2_100D_8A38_18B08));
        AL = unchecked((byte)result_100D_8A38_18B08);
        Alu8.UpdateFlags(unchecked((byte)result_100D_8A38_18B08));
        // 100D:8A3A ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_8A3B_18B0B(int loadOffset)
    {
    label_100D_8A3B_18B0B_20422:
        CheckExternalEvents(cs1, 0x8A3B);
        // 100D:8A3B test byte ptr DS:[0x47DE],0x10
        Alu8.And(UInt8[DS, (ushort)0x47DE], (byte)0x10);
        // 100D:8A40 jne short 0x8A43
        if (!ZeroFlag)
        {
            goto label_100D_8A43_18B13_24347;
        }
    label_100D_8A42_18B12_20425:
        CheckExternalEvents(cs1, 0x8A42);
        // 100D:8A42 ret near
        return NearRet((ushort)0x0000);
    label_100D_8A43_18B13_24347:
        CheckExternalEvents(cs1, 0x8A43);
        // 100D:8A43 push BX
        Stack.Push16(BX);
        // 100D:8A44 mov BH,byte ptr DS:[0x477F]
        BH = UInt8[DS, (ushort)0x477F];
        // 100D:8A48 cmp BH,0x8B
        Alu8.Sub(BH, (byte)0x8B);
        // 100D:8A4B jne short 0x8A52
        if (!ZeroFlag)
        {
            goto label_100D_8A52_18B22_24352;
        }
    label_100D_8A4D_18B1D_24962:
        CheckExternalEvents(cs1, 0x8A4D);
        // 100D:8A4D sub AX,0x0108
        AX = Alu16.Sub(AX, (ushort)0x0108);
        // 100D:8A50 jmp short 0x8ABE
        return unknown_100D_8ABE_18B8E(0x0000);
    label_100D_8A52_18B22_24352:
        CheckExternalEvents(cs1, 0x8A52);
        // 100D:8A52 cmp BH,0x84
        Alu8.Sub(BH, (byte)0x84);
        // 100D:8A55 jne short 0x8A69
        if (!ZeroFlag)
        {
            goto label_100D_8A69_18B39_24355;
        }
    label_100D_8A57_18B27_24790:
        CheckExternalEvents(cs1, 0x8A57);
        // 100D:8A57 sub AX,0x0048
        AX = Alu16.Sub(AX, (ushort)0x0048);
        // 100D:8A5A je short 0x8ABE
        if (ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
    label_100D_8A5C_18B2C_24793:
        CheckExternalEvents(cs1, 0x8A5C);
        // 100D:8A5C dec AX
        AX = Alu16.Dec(AX);
        // 100D:8A5D cmp AL,3
        Alu8.Sub(AL, (byte)0x03);
        // 100D:8A5F jb short 0x8ABE
        if (CarryFlag)
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
    label_100D_8A61_18B31_24797:
        CheckExternalEvents(cs1, 0x8A61);
        // 100D:8A61 sub AX,0xFFCF
        AX = Alu16.Sub(AX, (ushort)0xFFCF);
        // 100D:8A64 cmp AX,0x000C
        Alu16.Sub(AX, (ushort)0x000C);
        // 100D:8A67 jmp short 0x8ABC
        goto label_100D_8ABC_18B8C_24801;
    label_100D_8A69_18B39_24355:
        CheckExternalEvents(cs1, 0x8A69);
        // 100D:8A69 cmp BH,0x83
        Alu8.Sub(BH, (byte)0x83);
        // 100D:8A6C je short 0x8A71
        if (ZeroFlag)
        {
            goto label_100D_8A71_18B41_24360;
        }
    label_100D_8A6E_18B3E_24358:
        CheckExternalEvents(cs1, 0x8A6E);
        // 100D:8A6E cmp BH,0x8C
        Alu8.Sub(BH, (byte)0x8C);
    label_100D_8A71_18B41_24360:
        CheckExternalEvents(cs1, 0x8A71);
        // 100D:8A71 jne short 0x8A7A
        if (!ZeroFlag)
        {
            goto label_100D_8A7A_18B4A_24361;
        }
    label_100D_8A73_18B43_33813:
        CheckExternalEvents(cs1, 0x8A73);
        // 100D:8A73 sub AX,0x00E8
        AX = Alu16.Sub(AX, (ushort)0x00E8);
        // 100D:8A76 cmp AL,7
        Alu8.Sub(AL, (byte)0x07);
        // 100D:8A78 jmp short 0x8ABC
        goto label_100D_8ABC_18B8C_24801;
    label_100D_8A7A_18B4A_24361:
        CheckExternalEvents(cs1, 0x8A7A);
        // 100D:8A7A mov BL,BH
        BL = BH;
        // 100D:8A7C sub BL,0x86
        BL = Alu8.Sub(BL, (byte)0x86);
        // 100D:8A7F cmp BL,3
        Alu8.Sub(BL, (byte)0x03);
        // 100D:8A82 jae short 0x8A97
        if (!CarryFlag)
        {
            goto label_100D_8A97_18B67_24366;
        }
    label_100D_8A84_18B54_24880:
        CheckExternalEvents(cs1, 0x8A84);
        // 100D:8A84 mov BL,byte ptr DS:[0x47DE]
        BL = UInt8[DS, (ushort)0x47DE];
        // 100D:8A88 and BL,0x0F
        BL = Alu8.And(BL, (byte)0x0F);
        // 100D:8A8B cmp BL,1
        Alu8.Sub(BL, (byte)0x01);
        // 100D:8A8E jne short 0x8AC1
        if (!ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x8AC1);
        }
    label_100D_8A90_18B60_30150:
        CheckExternalEvents(cs1, 0x8A90);
        // 100D:8A90 sub AX,0x00D1
        AX = Alu16.Sub(AX, (ushort)0x00D1);
        // 100D:8A93 cmp AL,7
        Alu8.Sub(AL, (byte)0x07);
        // 100D:8A95 jmp short 0x8ABC
        goto label_100D_8ABC_18B8C_24801;
    label_100D_8A97_18B67_24366:
        CheckExternalEvents(cs1, 0x8A97);
        // 100D:8A97 cmp BH,0x85
        Alu8.Sub(BH, (byte)0x85);
        // 100D:8A9A jne short 0x8AB2
        if (!ZeroFlag)
        {
            goto label_100D_8AB2_18B82_24369;
        }
    label_100D_8A9C_18B6C_29051:
        CheckExternalEvents(cs1, 0x8A9C);
        // 100D:8A9C mov BL,byte ptr DS:[0x47DE]
        BL = UInt8[DS, (ushort)0x47DE];
        // 100D:8AA0 and BL,0x0F
        BL = Alu8.And(BL, (byte)0x0F);
        // 100D:8AA3 cmp BL,1
        Alu8.Sub(BL, (byte)0x01);
        // 100D:8AA6 jne short 0x8AC1
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8AA6");
        }
    label_100D_8AA8_18B78_29056:
        CheckExternalEvents(cs1, 0x8AA8);
        // 100D:8AA8 cmp AX,0x0074
        Alu16.Sub(AX, (ushort)0x0074);
        // 100D:8AAB mov AL,0
        AL = (byte)0x00;
        // 100D:8AAD jne short 0x8ABE
        if (!ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
    label_100D_8AAF_18B7F_29060:
        CheckExternalEvents(cs1, 0x8AAF);
        // 100D:8AAF inc AX
        AX = Alu16.Inc(AX);
        // 100D:8AB0 jmp short 0x8ABE
        return unknown_100D_8ABE_18B8E(0x0000);
    label_100D_8AB2_18B82_24369:
        CheckExternalEvents(cs1, 0x8AB2);
        // 100D:8AB2 cmp BH,0x89
        Alu8.Sub(BH, (byte)0x89);
        // 100D:8AB5 jne short 0x8AC1
        if (!ZeroFlag)
        {
            return unknown_100D_8ABE_18B8E(0x8AC1);
        }
    label_100D_8AB7_18B87_27015:
        CheckExternalEvents(cs1, 0x8AB7);
        // 100D:8AB7 sub AX,0x00DA
        AX = Alu16.Sub(AX, (ushort)0x00DA);
        // 100D:8ABA cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
    label_100D_8ABC_18B8C_24801:
        CheckExternalEvents(cs1, 0x8ABC);
        // 100D:8ABC jae short 0x8AC1
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:8ABC");
        }
        else
        {
            return unknown_100D_8ABE_18B8E(0x0000);
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }
}
