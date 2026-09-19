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
    public virtual Action unknown_100D_F13F_1F20F(int loadOffset)
    {
    label_100D_F13F_1F20F_6355:
        CheckExternalEvents(cs1, 0xF13F);
        // 100D:F13F push CX
        Stack.Push16(CX);
        // 100D:F140 mov BP,word ptr DS:[2]
        BP = UInt16[DS, (ushort)0x0002];
        // 100D:F144 mov SI,0xD844
        SI = (ushort)0xD844;
        // 100D:F147 mov DI,0xDA8C
        DI = (ushort)0xDA8C;
        // 100D:F14A mov CX,0x0091
        CX = (ushort)0x0091;
        // 100D:F14D xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:F14F mov BX,DX
        BX = DX;
    label_100D_F151_1F221_6363:
        CheckExternalEvents(cs1, 0xF151);
        // 100D:F151 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F154 add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:F157 mov AX,word ptr DS:[SI+2]
        AX = UInt16[DS, (ushort)(SI + (sbyte)2)];
        // 100D:F15A or AX,AX
        AX = Alu16.Or(AX, AX);
        // 100D:F15C je short 0xF16A
        if (ZeroFlag)
        {
            goto label_100D_F16A_1F23A_6368;
        }
    label_100D_F15E_1F22E_6371:
        CheckExternalEvents(cs1, 0xF15E);
        // 100D:F15E mov AX,BP
        AX = BP;
        // 100D:F160 sub AX,word ptr DS:[DI]
        AX = Alu16.Sub(AX, UInt16[DS, DI]);
        // 100D:F162 cmp AX,DX
        Alu16.Sub(AX, DX);
        // 100D:F164 jb short 0xF16A
        if (CarryFlag)
        {
            goto label_100D_F16A_1F23A_6368;
        }
    label_100D_F166_1F236_6376:
        CheckExternalEvents(cs1, 0xF166);
        // 100D:F166 mov DX,AX
        DX = AX;
        // 100D:F168 mov BX,SI
        BX = SI;
    label_100D_F16A_1F23A_6368:
        CheckExternalEvents(cs1, 0xF16A);
        // 100D:F16A loop 0xF151
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_F151_1F221_6363;
        }
    label_100D_F16C_1F23C_6379:
        CheckExternalEvents(cs1, 0xF16C);
        // 100D:F16C or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:F16E je short 0xF130
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F16E");
        }
    label_100D_F170_1F240_6382:
        CheckExternalEvents(cs1, 0xF170);
        // 100D:F170 mov AX,BX
        AX = BX;
        // 100D:F172 sub AX,0xD844
        AX = Alu16.Sub(AX, (ushort)0xD844);
        // 100D:F175 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F177 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F179 cmp AX,word ptr DS:[0x2784]
        Alu16.Sub(AX, UInt16[DS, (ushort)0x2784]);
        // 100D:F17D jne short 0xF185
        if (!ZeroFlag)
        {
            goto label_100D_F185_1F255_6389;
        }
    label_100D_F17F_1F24F_35305:
        CheckExternalEvents(cs1, 0xF17F);
        // 100D:F17F mov word ptr DS:[0x2784],0xFFFF
        UInt16[DS, (ushort)0x2784] = (ushort)0xFFFF;
    label_100D_F185_1F255_6389:
        CheckExternalEvents(cs1, 0xF185);
        // 100D:F185 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:F187 xchg DX,word ptr DS:[BX+2]
        ushort xchgOffset_100D_F187_1F257 = unchecked((ushort)(BX + (sbyte)2));
        ushort temp_100D_F187_1F257 = DX;
        DX = UInt16[DS, xchgOffset_100D_F187_1F257];
        UInt16[DS, xchgOffset_100D_F187_1F257] = unchecked((ushort)temp_100D_F187_1F257);
        // 100D:F18A mov SI,0xD84A
        SI = (ushort)0xD84A;
        // 100D:F18D mov CX,0x0091
        CX = (ushort)0x0091;
        // 100D:F190 mov BX,0x8000
        BX = (ushort)0x8000;
    label_100D_F193_1F263_6395:
        CheckExternalEvents(cs1, 0xF193);
        // 100D:F193 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 100D:F194 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F197 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:F199 jb short 0xF1A1
        if (CarryFlag)
        {
            goto label_100D_F1A1_1F271_6399;
        }
    label_100D_F19B_1F26B_6402:
        CheckExternalEvents(cs1, 0xF19B);
        // 100D:F19B cmp AX,BX
        Alu16.Sub(AX, BX);
        // 100D:F19D jae short 0xF1A1
        if (!CarryFlag)
        {
            goto label_100D_F1A1_1F271_6399;
        }
    label_100D_F19F_1F26F_6405:
        CheckExternalEvents(cs1, 0xF19F);
        // 100D:F19F mov BX,AX
        BX = AX;
    label_100D_F1A1_1F271_6399:
        CheckExternalEvents(cs1, 0xF1A1);
        // 100D:F1A1 loop 0xF193
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_F193_1F263_6395;
        }
    label_100D_F1A3_1F273_6407:
        CheckExternalEvents(cs1, 0xF1A3);
        // 100D:F1A3 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 100D:F1A5 js short 0xF1F5
        if (SignFlag)
        {
            goto label_100D_F1F5_1F2C5_10018;
        }
    label_100D_F1A7_1F277_6410:
        CheckExternalEvents(cs1, 0xF1A7);
        // 100D:F1A7 mov SI,0xD846
        SI = (ushort)0xD846;
        // 100D:F1AA mov CX,0x0091
        CX = (ushort)0x0091;
    label_100D_F1AD_1F27D_6413:
        CheckExternalEvents(cs1, 0xF1AD);
        // 100D:F1AD add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:F1B0 cmp word ptr DS:[SI],DX
        Alu16.Sub(UInt16[DS, SI], DX);
        // 100D:F1B2 jb short 0xF1B6
        if (CarryFlag)
        {
            goto label_100D_F1B6_1F286_6416;
        }
    label_100D_F1B4_1F284_6419:
        CheckExternalEvents(cs1, 0xF1B4);
        // 100D:F1B4 sub word ptr DS:[SI],BX
        UInt16[DS, SI] = Alu16.Sub(UInt16[DS, SI], BX);
    label_100D_F1B6_1F286_6416:
        CheckExternalEvents(cs1, 0xF1B6);
        // 100D:F1B6 loop 0xF1AD
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_F1AD_1F27D_6413;
        }
    label_100D_F1B8_1F288_6421:
        CheckExternalEvents(cs1, 0xF1B8);
        // 100D:F1B8 mov SI,0xDBB2
        SI = (ushort)0xDBB2;
        // 100D:F1BB cmp word ptr DS:[SI],DX
        Alu16.Sub(UInt16[DS, SI], DX);
        // 100D:F1BD jb short 0xF1C1
        if (CarryFlag)
        {
            goto label_100D_F1C1_1F291_6427;
        }
    label_100D_F1BF_1F28F_6425:
        CheckExternalEvents(cs1, 0xF1BF);
        // 100D:F1BF sub word ptr DS:[SI],BX
        UInt16[DS, SI] = Alu16.Sub(UInt16[DS, SI], BX);
    label_100D_F1C1_1F291_6427:
        CheckExternalEvents(cs1, 0xF1C1);
        // 100D:F1C1 mov ES,DX
        ES = DX;
        // 100D:F1C3 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 100D:F1C5 mov DS,DX
        DS = DX;
        // 100D:F1C7 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 100D:F1C9 mov DI,SI
        DI = SI;
        // 100D:F1CB mov AX,word ptr SS:[0x39B9]
        AX = UInt16[SS, (ushort)0x39B9];
        // 100D:F1CF sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 100D:F1D1 cmp AX,0x1000
        Alu16.Sub(AX, (ushort)0x1000);
        // 100D:F1D4 jbe short 0xF1E3
        if (CarryFlag || ZeroFlag)
        {
            goto label_100D_F1E3_1F2B3_6436;
        }
    label_100D_F1D6_1F2A6_9503:
        CheckExternalEvents(cs1, 0xF1D6);
        // 100D:F1D6 mov CX,0x8000
        CX = (ushort)0x8000;
        // 100D:F1D9 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:F1DB mov DX,ES
        DX = ES;
        // 100D:F1DD add DX,0x1000
        DX = Alu16.Add(DX, (ushort)0x1000);
        // 100D:F1E1 jmp short 0xF1C1
        goto label_100D_F1C1_1F291_6427;
    label_100D_F1E3_1F2B3_6436:
        CheckExternalEvents(cs1, 0xF1E3);
        // 100D:F1E3 mov CX,AX
        CX = AX;
        // 100D:F1E5 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:F1E7 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:F1E9 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 100D:F1EB rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 100D:F1ED push SS
        Stack.Push16(SS);
        // 100D:F1EE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F1EF sub word ptr DS:[0x39B9],BX
        UInt16[DS, (ushort)0x39B9] = Alu16.Sub(UInt16[DS, (ushort)0x39B9], BX);
        // 100D:F1F3 pop CX
        CX = Stack.Pop16();
        // 100D:F1F4 ret near
        return NearRet((ushort)0x0000);
    label_100D_F1F5_1F2C5_10018:
        CheckExternalEvents(cs1, 0xF1F5);
        // 100D:F1F5 mov word ptr DS:[0x39B9],DX
        UInt16[DS, (ushort)0x39B9] = DX;
        // 100D:F1F9 pop CX
        CX = Stack.Pop16();
        // 100D:F1FA ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F1FB_1F2CB(int loadOffset)
    {
    label_100D_F1FB_1F2CB_189:
        CheckExternalEvents(cs1, 0xF1FB);
        // 100D:F1FB push DX
        Stack.Push16(DX);
        // 100D:F1FC call near 0xF2A7
        NearCall(cs1, 0xF1FF, unknown_100D_F2A7_1F377);
    label_100D_F1FF_1F2CF_201:
        CheckExternalEvents(cs1, 0xF1FF);
        // 100D:F1FF pop SI
        SI = Stack.Pop16();
        // 100D:F200 jae short 0xF228
        if (!CarryFlag)
        {
            return unknown_100D_F228_1F2F8(0x0000);
        }
    label_100D_F202_1F2D2_204:
        CheckExternalEvents(cs1, 0xF202);
        // 100D:F202 mov DX,SI
        DX = SI;
        return unknown_100D_F204_1F2D4(0x0000);
    }

    public virtual Action unknown_100D_F204_1F2D4(int loadOffset)
    {
    label_100D_F204_1F2D4_206:
        CheckExternalEvents(cs1, 0xF204);
        // 100D:F204 push DX
        Stack.Push16(DX);
        // 100D:F205 call near 0xF2FC
        NearCall(cs1, 0xF208, unknown_100D_F2FC_1F3CC);
    label_100D_F208_1F2D8_225:
        CheckExternalEvents(cs1, 0xF208);
        // 100D:F208 mov AX,0x3D00
        AX = (ushort)0x3D00;
        // 100D:F20B int 0x21
        InterruptCall(cs1, 0xF20D, unchecked((byte)((byte)0x21)));
    label_100D_F20D_1F2DD_228:
        CheckExternalEvents(cs1, 0xF20D);
        // 100D:F20D pop DX
        DX = Stack.Pop16();
        // 100D:F20E jb short 0xF228
        if (CarryFlag)
        {
            return unknown_100D_F228_1F2F8(0x0000);
        }
    label_100D_F210_1F2E0_20222:
        CheckExternalEvents(cs1, 0xF210);
        // 100D:F210 mov BX,AX
        BX = AX;
        // 100D:F212 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:F214 mov DX,CX
        DX = CX;
        // 100D:F216 mov AX,0x4202
        AX = (ushort)0x4202;
        // 100D:F219 int 0x21
        InterruptCall(cs1, 0xF21B, unchecked((byte)((byte)0x21)));
    label_100D_F21B_1F2EB_20228:
        CheckExternalEvents(cs1, 0xF21B);
        // 100D:F21B push AX
        Stack.Push16(AX);
        // 100D:F21C push DX
        Stack.Push16(DX);
        // 100D:F21D xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:F21F mov DX,CX
        DX = CX;
        // 100D:F221 mov AX,0x4200
        AX = (ushort)0x4200;
        // 100D:F224 int 0x21
        InterruptCall(cs1, 0xF226, unchecked((byte)((byte)0x21)));
    label_100D_F226_1F2F6_20235:
        CheckExternalEvents(cs1, 0xF226);
        // 100D:F226 pop BP
        BP = Stack.Pop16();
        // 100D:F227 pop CX
        CX = Stack.Pop16();
        return unknown_100D_F228_1F2F8(0x0000);
    }

    public virtual Action unknown_100D_F229_1F2F9(int loadOffset)
    {
    label_100D_F229_1F2F9_535:
        CheckExternalEvents(cs1, 0xF229);
        // 100D:F229 call near 0xF1FB
        NearCall(cs1, 0xF22C, unknown_100D_F1FB_1F2CB);
    label_100D_F22C_1F2FC_557:
        CheckExternalEvents(cs1, 0xF22C);
        // 100D:F22C jb short 0xF22F
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F22C");
        }
    label_100D_F22E_1F2FE_559:
        CheckExternalEvents(cs1, 0xF22E);
        // 100D:F22E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F244_1F314(int loadOffset)
    {
    label_100D_F244_1F314_532:
        CheckExternalEvents(cs1, 0xF244);
        // 100D:F244 push DX
        Stack.Push16(DX);
        // 100D:F245 call near 0xF229
        NearCall(cs1, 0xF248, unknown_100D_F229_1F2F9);
    label_100D_F248_1F318_561:
        CheckExternalEvents(cs1, 0xF248);
        // 100D:F248 pop DX
        DX = Stack.Pop16();
        // 100D:F249 cmp BX,word ptr DS:[0xDBBA]
        Alu16.Sub(BX, UInt16[DS, (ushort)0xDBBA]);
        // 100D:F24D jne short 0xF260
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F24D");
        }
    label_100D_F24F_1F31F_565:
        CheckExternalEvents(cs1, 0xF24F);
        // 100D:F24F call near 0xF2EA
        NearCall(cs1, 0xF252, unknown_100D_F2EA_1F3BA);
    label_100D_F252_1F322_567:
        CheckExternalEvents(cs1, 0xF252);
        // 100D:F252 jb short 0xF244
        if (CarryFlag)
        {
            goto label_100D_F244_1F314_532;
        }
    label_100D_F254_1F324_569:
        CheckExternalEvents(cs1, 0xF254);
        // 100D:F254 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F255_1F325(int loadOffset)
    {
    label_100D_F255_1F325_20216:
        CheckExternalEvents(cs1, 0xF255);
        // 100D:F255 push DX
        Stack.Push16(DX);
        // 100D:F256 push DI
        Stack.Push16(DI);
        // 100D:F257 push ES
        Stack.Push16(ES);
        // 100D:F258 call near 0xF204
        NearCall(cs1, 0xF25B, unknown_100D_F204_1F2D4);
    label_100D_F25B_1F32B_20238:
        CheckExternalEvents(cs1, 0xF25B);
        // 100D:F25B jb short 0xF22F
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F25B");
        }
    label_100D_F25D_1F32D_20240:
        CheckExternalEvents(cs1, 0xF25D);
        // 100D:F25D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F25E pop DI
        DI = Stack.Pop16();
        // 100D:F25F pop DX
        DX = Stack.Pop16();
        // 100D:F260 push DX
        Stack.Push16(DX);
        // 100D:F261 push DI
        Stack.Push16(DI);
        // 100D:F262 push ES
        Stack.Push16(ES);
        // 100D:F263 push DS
        Stack.Push16(DS);
        // 100D:F264 push ES
        Stack.Push16(ES);
        // 100D:F265 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F266 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
        // 100D:F269 mov DX,DI
        DX = DI;
        // 100D:F26B mov AH,0x3F
        AH = (byte)0x3F;
        // 100D:F26D int 0x21
        InterruptCall(cs1, 0xF26F, unchecked((byte)((byte)0x21)));
    label_100D_F26F_1F33F_20254:
        CheckExternalEvents(cs1, 0xF26F);
        // 100D:F26F pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F270 mov CX,AX
        CX = AX;
        // 100D:F272 pushf
        Stack.Push16(FlagRegister16);
        // 100D:F273 mov AH,0x3E
        AH = (byte)0x3E;
        // 100D:F275 int 0x21
        InterruptCall(cs1, 0xF277, unchecked((byte)((byte)0x21)));
    label_100D_F277_1F347_20260:
        CheckExternalEvents(cs1, 0xF277);
        // 100D:F277 popf
        FlagRegister16 = Stack.Pop16();
    label_100D_F278_1F348_20262:
        CheckExternalEvents(cs1, 0xF278);
        // 100D:F278 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F279 pop DI
        DI = Stack.Pop16();
        // 100D:F27A pop DX
        DX = Stack.Pop16();
        // 100D:F27B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F2A7_1F377(int loadOffset)
    {
    label_100D_F2A7_1F377_192:
        CheckExternalEvents(cs1, 0xF2A7);
        // 100D:F2A7 push DI
        Stack.Push16(DI);
        // 100D:F2A8 push ES
        Stack.Push16(ES);
        // 100D:F2A9 cmp word ptr DS:[0xDBBA],1
        Alu16.Sub(UInt16[DS, (ushort)0xDBBA], unchecked((ushort)unchecked((short)(sbyte)1)));
        // 100D:F2AE jb short 0xF2D3
        if (CarryFlag)
        {
            goto label_100D_F2D3_1F3A3_197;
        }
    label_100D_F2B0_1F380_537:
        CheckExternalEvents(cs1, 0xF2B0);
        // 100D:F2B0 mov SI,DX
        SI = DX;
        // 100D:F2B2 call near 0xF314
        NearCall(cs1, 0xF2B5, unknown_100D_F314_1F3E4);
    label_100D_F2B5_1F385_540:
        CheckExternalEvents(cs1, 0xF2B5);
        // 100D:F2B5 jb short 0xF2D3
        if (CarryFlag)
        {
            goto label_100D_F2D3_1F3A3_197;
        }
    label_100D_F2B7_1F387_542:
        CheckExternalEvents(cs1, 0xF2B7);
        // 100D:F2B7 call near 0xF3A7
        NearCall(cs1, 0xF2BA, unknown_100D_F3A7_1F477);
    label_100D_F2BA_1F38A_547:
        CheckExternalEvents(cs1, 0xF2BA);
        // 100D:F2BA jb short 0xF2D3
        if (CarryFlag)
        {
            goto label_100D_F2D3_1F3A3_197;
        }
    label_100D_F2BC_1F38C_549:
        CheckExternalEvents(cs1, 0xF2BC);
        // 100D:F2BC xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 100D:F2BE mov CL,byte ptr ES:[DI+5]
        CL = UInt8[ES, (ushort)(DI + (sbyte)5)];
        // 100D:F2C2 mov BP,CX
        BP = CX;
        // 100D:F2C4 mov CX,word ptr ES:[DI+3]
        CX = UInt16[ES, (ushort)(DI + (sbyte)3)];
        // 100D:F2C8 mov AX,word ptr ES:[DI+6]
        AX = UInt16[ES, (ushort)(DI + (sbyte)6)];
        // 100D:F2CC mov DX,word ptr ES:[DI+8]
        DX = UInt16[ES, (ushort)(DI + (sbyte)8)];
        // 100D:F2D0 call near 0xF2D6
        NearCall(cs1, 0xF2D3, unknown_100D_F2D6_1F3A6);
    label_100D_F2D3_1F3A3_197:
        CheckExternalEvents(cs1, 0xF2D3);
        // 100D:F2D3 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F2D4 pop DI
        DI = Stack.Pop16();
        // 100D:F2D5 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F2D6_1F3A6(int loadOffset)
    {
    label_100D_F2D6_1F3A6_253:
        CheckExternalEvents(cs1, 0xF2D6);
        // 100D:F2D6 push CX
        Stack.Push16(CX);
        // 100D:F2D7 mov BX,word ptr SS:[0xDBBA]
        BX = UInt16[SS, (ushort)0xDBBA];
        // 100D:F2DC mov CX,DX
        CX = DX;
        // 100D:F2DE mov DX,AX
        DX = AX;
        // 100D:F2E0 mov AX,0x4200
        AX = (ushort)0x4200;
        // 100D:F2E3 int 0x21
        InterruptCall(cs1, 0xF2E5, unchecked((byte)((byte)0x21)));
    label_100D_F2E5_1F3B5_260:
        CheckExternalEvents(cs1, 0xF2E5);
        // 100D:F2E5 pop CX
        CX = Stack.Pop16();
        // 100D:F2E6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F2EA_1F3BA(int loadOffset)
    {
    label_100D_F2EA_1F3BA_270:
        CheckExternalEvents(cs1, 0xF2EA);
        // 100D:F2EA push DS
        Stack.Push16(DS);
        // 100D:F2EB push ES
        Stack.Push16(ES);
        // 100D:F2EC pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F2ED mov BX,word ptr SS:[0xDBBA]
        BX = UInt16[SS, (ushort)0xDBBA];
        // 100D:F2F2 mov DX,DI
        DX = DI;
        // 100D:F2F4 mov AH,0x3F
        AH = (byte)0x3F;
        // 100D:F2F6 int 0x21
        InterruptCall(cs1, 0xF2F8, unchecked((byte)((byte)0x21)));
    label_100D_F2F8_1F3C8_278:
        CheckExternalEvents(cs1, 0xF2F8);
        // 100D:F2F8 cmp AX,CX
        Alu16.Sub(AX, CX);
        // 100D:F2FA pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F2FB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F2FC_1F3CC(int loadOffset)
    {
    label_100D_F2FC_1F3CC_208:
        CheckExternalEvents(cs1, 0xF2FC);
        // 100D:F2FC push SI
        Stack.Push16(SI);
        // 100D:F2FD push DI
        Stack.Push16(DI);
        // 100D:F2FE mov SI,DX
        SI = DX;
        // 100D:F300 mov DI,word ptr DS:[0x38A6]
        DI = UInt16[DS, (ushort)0x38A6];
    label_100D_F304_1F3D4_213:
        CheckExternalEvents(cs1, 0xF304);
        // 100D:F304 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 100D:F306 inc SI
        SI = Alu16.Inc(SI);
        // 100D:F307 mov byte ptr DS:[DI],AL
        UInt8[DS, DI] = AL;
        // 100D:F309 inc DI
        DI = Alu16.Inc(DI);
        // 100D:F30A or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:F30C jne short 0xF304
        if (!ZeroFlag)
        {
            goto label_100D_F304_1F3D4_213;
        }
    label_100D_F30E_1F3DE_220:
        CheckExternalEvents(cs1, 0xF30E);
        // 100D:F30E pop DI
        DI = Stack.Pop16();
        // 100D:F30F pop SI
        SI = Stack.Pop16();
        // 100D:F310 mov DX,0x3826
        DX = (ushort)0x3826;
        // 100D:F313 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F314_1F3E4(int loadOffset)
    {
    label_100D_F314_1F3E4_303:
        CheckExternalEvents(cs1, 0xF314);
        // 100D:F314 push SS
        Stack.Push16(SS);
        // 100D:F315 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 100D:F316 cmp word ptr DS:[SI+2],0x505C
        Alu16.Sub(UInt16[DS, (ushort)(SI + (sbyte)2)], (ushort)0x505C);
        // 100D:F31B je short 0xF36C
        if (ZeroFlag)
        {
            goto label_100D_F36C_1F43C_423;
        }
    label_100D_F31D_1F3ED_308:
        CheckExternalEvents(cs1, 0xF31D);
        // 100D:F31D push SI
        Stack.Push16(SI);
        // 100D:F31E mov CX,0x0010
        CX = (ushort)0x0010;
        // 100D:F321 mov DX,CX
        DX = CX;
    label_100D_F323_1F3F3_312:
        CheckExternalEvents(cs1, 0xF323);
        // 100D:F323 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F324 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 100D:F326 loopne 0xF323
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_100D_F323_1F3F3_312;
        }
    label_100D_F328_1F3F8_316:
        CheckExternalEvents(cs1, 0xF328);
        // 100D:F328 jne short 0xF32B
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 100D:F328");
        }
    label_100D_F32A_1F3FA_318:
        CheckExternalEvents(cs1, 0xF32A);
        // 100D:F32A inc CX
        CX = Alu16.Inc(CX);
        // 100D:F32B sub CX,0x0010
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 100D:F32E neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 100D:F330 pop SI
        SI = Stack.Pop16();
        // 100D:F331 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 100D:F333 mov AX,word ptr DS:[0xCE78]
        AX = UInt16[DS, (ushort)0xCE78];
        // 100D:F336 mov DI,AX
        DI = AX;
        // 100D:F338 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 100D:F33A mov DI,word ptr DS:[DI+0x31FF]
        DI = UInt16[DS, (ushort)(DI + (short)12799)];
        // 100D:F33E add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F341 push CX
        Stack.Push16(CX);
        // 100D:F342 push SI
        Stack.Push16(SI);
        // 100D:F343 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
        bool shouldContinue_100D_F343_1F413 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_F343_1F413)
        {
            Alu8.Sub(UInt8[DS, SI], UInt8[ES, DI]);
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_F343_1F413 = ZeroFlag == true;
        }
        // 100D:F345 pop SI
        SI = Stack.Pop16();
        // 100D:F346 pop CX
        CX = Stack.Pop16();
        // 100D:F347 je short 0xF3A5
        if (ZeroFlag)
        {
            goto label_100D_F3A5_1F475_354;
        }
    label_100D_F349_1F419_335:
        CheckExternalEvents(cs1, 0xF349);
        // 100D:F349 mov BX,0x31FF
        BX = (ushort)0x31FF;
        // 100D:F34C mov BP,0x00F7
        BP = (ushort)0x00F7;
    label_100D_F34F_1F41F_338:
        CheckExternalEvents(cs1, 0xF34F);
        // 100D:F34F mov DI,word ptr ES:[BX]
        DI = UInt16[ES, BX];
        // 100D:F352 mov AX,BX
        AX = BX;
        // 100D:F354 sub AX,0x31FF
        AX = Alu16.Sub(AX, (ushort)0x31FF);
        // 100D:F357 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 100D:F359 add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F35C add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 100D:F35F push CX
        Stack.Push16(CX);
        // 100D:F360 push SI
        Stack.Push16(SI);
        // 100D:F361 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
        bool shouldContinue_100D_F361_1F431 = true;
        while (CX != (ushort)0x0000 && shouldContinue_100D_F361_1F431)
        {
            Alu8.Sub(UInt8[DS, SI], UInt8[ES, DI]);
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_100D_F361_1F431 = ZeroFlag == true;
        }
        // 100D:F363 pop SI
        SI = Stack.Pop16();
        // 100D:F364 pop CX
        CX = Stack.Pop16();
        // 100D:F365 je short 0xF3A5
        if (ZeroFlag)
        {
            goto label_100D_F3A5_1F475_354;
        }
    label_100D_F367_1F437_350:
        CheckExternalEvents(cs1, 0xF367);
        // 100D:F367 dec BP
        BP = Alu16.Dec(BP);
        // 100D:F368 jne short 0xF34F
        if (!ZeroFlag)
        {
            goto label_100D_F34F_1F41F_338;
        }
    label_100D_F36A_1F43A_452:
        CheckExternalEvents(cs1, 0xF36A);
        // 100D:F36A stc
        CarryFlag = true;
        // 100D:F36B ret near
        return NearRet((ushort)0x0000);
    label_100D_F36C_1F43C_423:
        CheckExternalEvents(cs1, 0xF36C);
        // 100D:F36C add SI,4
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 100D:F36F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F370 sub AL,0x40
        AL = Alu8.Sub(AL, (byte)0x40);
        // 100D:F372 mov DL,AL
        DL = AL;
        // 100D:F374 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 100D:F376 mov CX,3
        CX = (ushort)0x0003;
    label_100D_F379_1F449_430:
        CheckExternalEvents(cs1, 0xF379);
        // 100D:F379 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F37A cmp AL,0x41
        Alu8.Sub(AL, (byte)0x41);
        // 100D:F37C jb short 0xF380
        if (CarryFlag)
        {
            goto label_100D_F380_1F450_433;
        }
    label_100D_F37E_1F44E_457:
        CheckExternalEvents(cs1, 0xF37E);
        // 100D:F37E sub AL,7
        AL = Alu8.Sub(AL, (byte)0x07);
    label_100D_F380_1F450_433:
        CheckExternalEvents(cs1, 0xF380);
        // 100D:F380 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 100D:F382 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:F384 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:F386 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:F388 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 100D:F38A or BL,AL
        BL = Alu8.Or(BL, AL);
        // 100D:F38C loop 0xF379
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_100D_F379_1F449_430;
        }
    label_100D_F38E_1F45E_442:
        CheckExternalEvents(cs1, 0xF38E);
        // 100D:F38E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F38F cmp AL,0x4F
        Alu8.Sub(AL, (byte)0x4F);
        // 100D:F391 cmc
        CarryFlag = !CarryFlag;
        // 100D:F392 rcl DL,1
        DL = Alu8.Rcl(DL, unchecked((byte)1));
        // 100D:F394 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 100D:F395 sub AL,0x41
        AL = Alu8.Sub(AL, (byte)0x41);
        // 100D:F397 jb short 0xF3A3
        if (CarryFlag)
        {
            goto label_100D_F3A3_1F473_450;
        }
    label_100D_F399_1F469_459:
        CheckExternalEvents(cs1, 0xF399);
        // 100D:F399 shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:F39B shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:F39D shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:F39F shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 100D:F3A1 or BH,AL
        BH = Alu8.Or(BH, AL);
    label_100D_F3A3_1F473_450:
        CheckExternalEvents(cs1, 0xF3A3);
        // 100D:F3A3 mov AX,BX
        AX = BX;
    label_100D_F3A5_1F475_354:
        CheckExternalEvents(cs1, 0xF3A5);
        // 100D:F3A5 clc
        CarryFlag = false;
        // 100D:F3A6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F3A7_1F477(int loadOffset)
    {
    label_100D_F3A7_1F477_362:
        CheckExternalEvents(cs1, 0xF3A7);
        // 100D:F3A7 les DI,word ptr SS:[0xDBBC]
        ushort lxsOffset_100D_F3A7_1F477 = (ushort)0xDBBC;
        ushort lxsValue_100D_F3A7_1F477 = UInt16[SS, lxsOffset_100D_F3A7_1F477];
        ushort lxsSegment_100D_F3A7_1F477 = UInt16[SS, (ushort)(lxsOffset_100D_F3A7_1F477 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_100D_F3A7_1F477);
        ES = unchecked((ushort)lxsSegment_100D_F3A7_1F477);
        // 100D:F3AC sub DI,5
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)5)));
    label_100D_F3AF_1F47F_365:
        CheckExternalEvents(cs1, 0xF3AF);
        // 100D:F3AF add DI,5
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 100D:F3B2 cmp DL,byte ptr ES:[DI+4]
        Alu8.Sub(DL, UInt8[ES, (ushort)(DI + (sbyte)4)]);
        // 100D:F3B6 jne short 0xF3BC
        if (!ZeroFlag)
        {
            goto label_100D_F3BC_1F48C_368;
        }
    label_100D_F3B8_1F488_544:
        CheckExternalEvents(cs1, 0xF3B8);
        // 100D:F3B8 cmp AX,word ptr ES:[DI+2]
        Alu16.Sub(AX, UInt16[ES, (ushort)(DI + (sbyte)2)]);
    label_100D_F3BC_1F48C_368:
        CheckExternalEvents(cs1, 0xF3BC);
        // 100D:F3BC ja short 0xF3AF
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_F3AF_1F47F_365;
        }
    label_100D_F3BE_1F48E_370:
        CheckExternalEvents(cs1, 0xF3BE);
        // 100D:F3BE mov DI,word ptr ES:[DI]
        DI = UInt16[ES, DI];
        // 100D:F3C1 sub DI,0x000A
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)10)));
    label_100D_F3C4_1F494_373:
        CheckExternalEvents(cs1, 0xF3C4);
        // 100D:F3C4 add DI,0x000A
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)10)));
        // 100D:F3C7 cmp DL,byte ptr ES:[DI+2]
        Alu8.Sub(DL, UInt8[ES, (ushort)(DI + (sbyte)2)]);
        // 100D:F3CB jne short 0xF3D0
        if (!ZeroFlag)
        {
            goto label_100D_F3D0_1F4A0_376;
        }
    label_100D_F3CD_1F49D_420:
        CheckExternalEvents(cs1, 0xF3CD);
        // 100D:F3CD cmp AX,word ptr ES:[DI]
        Alu16.Sub(AX, UInt16[ES, DI]);
    label_100D_F3D0_1F4A0_376:
        CheckExternalEvents(cs1, 0xF3D0);
        // 100D:F3D0 ja short 0xF3C4
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_100D_F3C4_1F494_373;
        }
    label_100D_F3D2_1F4A2_378:
        CheckExternalEvents(cs1, 0xF3D2);
        // 100D:F3D2 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_100D_F403_1F4D3(int loadOffset)
    {
    label_100D_F403_1F4D3_2819:
        CheckExternalEvents(cs1, 0xF403);
        // 100D:F403 push CX
        Stack.Push16(CX);
        // 100D:F404 push DI
        Stack.Push16(DI);
        // 100D:F405 push DS
        Stack.Push16(DS);
        // 100D:F406 add SI,6
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 100D:F409 xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 100D:F40B jmp short 0xF435
        return unknown_100D_F435_1F505(0x0000);
    }

    public virtual Action unknown_3358_0100_33680(int loadOffset)
    {
    label_3358_0100_33680_757:
        CheckExternalEvents(cs2, 0x0100);
        // 3358:0100 jmp near 0x0967
    label_3358_0967_33EE7_759:
        CheckExternalEvents(cs2, 0x0967);
        // 3358:0967 mov AH,0x0F
        AH = (byte)0x0F;
        // 3358:0969 int 0x10
        InterruptCall(cs2, 0x096B, unchecked((byte)((byte)0x10)));
    label_3358_096B_33EEB_766:
        CheckExternalEvents(cs2, 0x096B);
        // 3358:096B cmp AL,0x13
        Alu8.Sub(AL, (byte)0x13);
        // 3358:096D je short 0x0974
        if (ZeroFlag)
        {
            goto label_3358_0974_33EF4_772;
        }
    label_3358_096F_33EEF_769:
        CheckExternalEvents(cs2, 0x096F);
        // 3358:096F mov AX,0x0013
        AX = (ushort)0x0013;
        // 3358:0972 int 0x10
        InterruptCall(cs2, 0x0974, unchecked((byte)((byte)0x10)));
    label_3358_0974_33EF4_772:
        CheckExternalEvents(cs2, 0x0974);
        // 3358:0974 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0103_33683(int loadOffset)
    {
    label_3358_0103_33683_726:
        CheckExternalEvents(cs2, 0x0103);
        // 3358:0103 jmp near 0x09D9
    label_3358_09D9_33F59_728:
        CheckExternalEvents(cs2, 0x09D9);
        // 3358:09D9 mov AX,0xA000
        AX = (ushort)0xA000;
        // 3358:09DC mov CX,0xFA00
        CX = (ushort)0xFA00;
        // 3358:09DF xor BP,BP
        BP = Alu16.Xor(BP, BP);
        // 3358:09E1 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0106_33686(int loadOffset)
    {
    label_3358_0106_33686_4131:
        CheckExternalEvents(cs2, 0x0106);
        // 3358:0106 jmp near 0x09E2
    label_3358_09E2_33F62_4133:
        CheckExternalEvents(cs2, 0x09E2);
        // 3358:09E2 push AX
        Stack.Push16(AX);
        // 3358:09E3 push BX
        Stack.Push16(BX);
        // 3358:09E4 push CX
        Stack.Push16(CX);
        // 3358:09E5 push SI
        Stack.Push16(SI);
        // 3358:09E6 push DI
        Stack.Push16(DI);
        // 3358:09E7 push DS
        Stack.Push16(DS);
        // 3358:09E8 push ES
        Stack.Push16(ES);
        // 3358:09E9 push ES
        Stack.Push16(ES);
        // 3358:09EA pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:09EB push CS
        Stack.Push16(CS);
        // 3358:09EC pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:09ED mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:09F0 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:09F2 mov AX,CX
        AX = CX;
        // 3358:09F4 mov SI,DX
        SI = DX;
        // 3358:09F6 repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
        bool shouldContinue_3358_09F6_33F76 = true;
        while (CX != (ushort)0x0000 && shouldContinue_3358_09F6_33F76)
        {
            Alu8.Sub(UInt8[DS, SI], UInt8[ES, DI]);
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
            shouldContinue_3358_09F6_33F76 = ZeroFlag == true;
        }
        // 3358:09F8 je short 0x0A19
        if (ZeroFlag)
        {
            goto label_3358_0A19_33F99_4198;
        }
    label_3358_09FA_33F7A_4151:
        CheckExternalEvents(cs2, 0x09FA);
        // 3358:09FA mov byte ptr CS:[0x01BE],1
        UInt8[CS, (ushort)0x01BE] = (byte)0x01;
        // 3358:0A00 mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:0A03 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:0A05 mov SI,DX
        SI = DX;
        // 3358:0A07 mov CX,AX
        CX = AX;
        // 3358:0A09 push CX
        Stack.Push16(CX);
        // 3358:0A0A rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0A0C pop CX
        CX = Stack.Pop16();
        // 3358:0A0D call near 0x0A21
        NearCall(cs2, 0x0A10, unknown_3358_0A21_33FA1);
    label_3358_0A10_33F90_4193:
        CheckExternalEvents(cs2, 0x0A10);
        // 3358:0A10 mov DI,0x01BF
        DI = (ushort)0x01BF;
        // 3358:0A13 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:0A15 mov AL,1
        AL = (byte)0x01;
        // 3358:0A17 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_0A19_33F99_4198:
        CheckExternalEvents(cs2, 0x0A19);
        // 3358:0A19 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A1A pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A1B pop DI
        DI = Stack.Pop16();
        // 3358:0A1C pop SI
        SI = Stack.Pop16();
        // 3358:0A1D pop CX
        CX = Stack.Pop16();
        // 3358:0A1E pop BX
        BX = Stack.Pop16();
        // 3358:0A1F pop AX
        AX = Stack.Pop16();
        // 3358:0A20 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0109_33689(int loadOffset)
    {
    label_3358_0109_33689_14816:
        CheckExternalEvents(cs2, 0x0109);
        // 3358:0109 jmp near 0x1888
    label_3358_1888_34E08_14818:
        CheckExternalEvents(cs2, 0x1888);
        // 3358:1888 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1889 sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 3358:188B jae short 0x188F
        if (!CarryFlag)
        {
            goto label_3358_188F_34E0F_14822;
        }
    label_3358_188D_34E0D_31376:
        CheckExternalEvents(cs2, 0x188D);
        // 3358:188D xor DX,DX
        DX = Alu16.Xor(DX, DX);
    label_3358_188F_34E0F_14822:
        CheckExternalEvents(cs2, 0x188F);
        // 3358:188F lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1890 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:1892 jae short 0x1896
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1892");
        }
    label_3358_1896_34E16_14826:
        CheckExternalEvents(cs2, 0x1896);
        // 3358:1896 mov CX,0x0010
        CX = (ushort)0x0010;
        // 3358:1899 cmp BX,0x00B8
        Alu16.Sub(BX, (ushort)0x00B8);
        // 3358:189D jbe short 0x18A4
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_18A4_34E24_14830;
        }
    label_3358_189F_34E1F_16160:
        CheckExternalEvents(cs2, 0x189F);
        // 3358:189F mov CX,0x00C8
        CX = (ushort)0x00C8;
        // 3358:18A2 sub CX,BX
        CX = Alu16.Sub(CX, BX);
    label_3358_18A4_34E24_14830:
        CheckExternalEvents(cs2, 0x18A4);
        // 3358:18A4 call near 0x0C10
        NearCall(cs2, 0x18A7, unknown_3358_0C10_34190);
    label_3358_18A7_34E27_14832:
        CheckExternalEvents(cs2, 0x18A7);
        // 3358:18A7 mov AX,0xA000
        AX = (ushort)0xA000;
        // 3358:18AA mov ES,AX
        ES = AX;
        // 3358:18AC sub DX,0x0140
        DX = Alu16.Sub(DX, (ushort)0x0140);
        // 3358:18B0 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 3358:18B2 cmp DX,0x0010
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)16)));
        // 3358:18B5 jbe short 0x18BA
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_18BA_34E3A_14841;
        }
    label_3358_18B7_34E37_14839:
        CheckExternalEvents(cs2, 0x18B7);
        // 3358:18B7 mov DX,0x0010
        DX = (ushort)0x0010;
    label_3358_18BA_34E3A_14841:
        CheckExternalEvents(cs2, 0x18BA);
        // 3358:18BA mov word ptr CS:[0x018C],DX
        UInt16[CS, (ushort)0x018C] = DX;
        // 3358:18BF mov word ptr CS:[0x018E],CX
        UInt16[CS, (ushort)0x018E] = CX;
        // 3358:18C4 mov word ptr CS:[0x018A],DI
        UInt16[CS, (ushort)0x018A] = DI;
        // 3358:18C9 mov BX,0xFA00
        BX = (ushort)0xFA00;
        // 3358:18CC shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:18CE mov word ptr CS:[0x0190],DX
        UInt16[CS, (ushort)0x0190] = DX;
        // 3358:18D3 mov word ptr CS:[0x0192],CX
        UInt16[CS, (ushort)0x0192] = CX;
    label_3358_18D8_34E58_14848:
        CheckExternalEvents(cs2, 0x18D8);
        // 3358:18D8 mov CX,word ptr CS:[0x0190]
        CX = UInt16[CS, (ushort)0x0190];
        // 3358:18DD mov BP,word ptr DS:[SI+0x20]
        BP = UInt16[DS, (ushort)(SI + (sbyte)32)];
        // 3358:18E0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:18E1 mov DX,AX
        DX = AX;
        // 3358:18E3 jcxz short 0x1911
        if (CX == (ushort)0x0000)
        {
            goto label_3358_1911_34E91_14875;
        }
    label_3358_18E5_34E65_14853:
        CheckExternalEvents(cs2, 0x18E5);
        // 3358:18E5 mov AX,word ptr ES:[DI]
        AX = UInt16[ES, DI];
        // 3358:18E8 mov word ptr ES:[BX],AX
        UInt16[ES, BX] = AX;
        // 3358:18EB add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:18EE rol BP,1
        BP = Alu16.Rol(BP, unchecked((byte)1));
        // 3358:18F0 add DX,DX
        DX = Alu16.Add(DX, DX);
        // 3358:18F2 jb short 0x18FE
        if (CarryFlag)
        {
            goto label_3358_18FE_34E7E_14864;
        }
    label_3358_18F4_34E74_14860:
        CheckExternalEvents(cs2, 0x18F4);
        // 3358:18F4 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:18F6 test BP,1
        Alu16.And(BP, (ushort)0x0001);
        // 3358:18FA je short 0x18FE
        if (ZeroFlag)
        {
            goto label_3358_18FE_34E7E_14864;
        }
    label_3358_18FC_34E7C_14886:
        CheckExternalEvents(cs2, 0x18FC);
        // 3358:18FC mov AL,0x0F
        AL = (byte)0x0F;
    label_3358_18FE_34E7E_14864:
        CheckExternalEvents(cs2, 0x18FE);
        // 3358:18FE rol BP,1
        BP = Alu16.Rol(BP, unchecked((byte)1));
        // 3358:1900 add DX,DX
        DX = Alu16.Add(DX, DX);
        // 3358:1902 jb short 0x190E
        if (CarryFlag)
        {
            goto label_3358_190E_34E8E_14872;
        }
    label_3358_1904_34E84_14868:
        CheckExternalEvents(cs2, 0x1904);
        // 3358:1904 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1906 test BP,1
        Alu16.And(BP, (ushort)0x0001);
        // 3358:190A je short 0x190E
        if (ZeroFlag)
        {
            goto label_3358_190E_34E8E_14872;
        }
    label_3358_190C_34E8C_14884:
        CheckExternalEvents(cs2, 0x190C);
        // 3358:190C mov AH,0x0F
        AH = (byte)0x0F;
    label_3358_190E_34E8E_14872:
        CheckExternalEvents(cs2, 0x190E);
        // 3358:190E stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:190F loop 0x18E5
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_18E5_34E65_14853;
        }
    label_3358_1911_34E91_14875:
        CheckExternalEvents(cs2, 0x1911);
        // 3358:1911 test byte ptr CS:[0x018C],1
        Alu8.And(UInt8[CS, (ushort)0x018C], (byte)0x01);
        // 3358:1917 je short 0x192F
        if (ZeroFlag)
        {
            goto label_3358_192F_34EAF_14878;
        }
    label_3358_1919_34E99_25296:
        CheckExternalEvents(cs2, 0x1919);
        // 3358:1919 mov AL,byte ptr ES:[DI]
        AL = UInt8[ES, DI];
        // 3358:191C mov byte ptr ES:[BX],AL
        UInt8[ES, BX] = AL;
        // 3358:191F inc BX
        BX = Alu16.Inc(BX);
        // 3358:1920 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1921 add DX,DX
        DX = Alu16.Add(DX, DX);
        // 3358:1923 jb short 0x192F
        if (CarryFlag)
        {
            goto label_3358_192F_34EAF_14878;
        }
    label_3358_1925_34EA5_25303:
        CheckExternalEvents(cs2, 0x1925);
        // 3358:1925 xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 3358:1927 add BP,BP
        BP = Alu16.Add(BP, BP);
        // 3358:1929 jae short 0x192D
        if (!CarryFlag)
        {
            goto label_3358_192D_34EAD_25307;
        }
    label_3358_192B_34EAB_25310:
        CheckExternalEvents(cs2, 0x192B);
        // 3358:192B mov AL,0x0F
        AL = (byte)0x0F;
    label_3358_192D_34EAD_25307:
        CheckExternalEvents(cs2, 0x192D);
        // 3358:192D dec DI
        DI = Alu16.Dec(DI);
        // 3358:192E stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_3358_192F_34EAF_14878:
        CheckExternalEvents(cs2, 0x192F);
        // 3358:192F sub DI,word ptr CS:[0x018C]
        DI = Alu16.Sub(DI, UInt16[CS, (ushort)0x018C]);
        // 3358:1934 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:1938 dec word ptr CS:[0x0192]
        UInt16[CS, (ushort)0x0192] = Alu16.Dec(UInt16[CS, (ushort)0x0192]);
        // 3358:193D jne short 0x18D8
        if (!ZeroFlag)
        {
            goto label_3358_18D8_34E58_14848;
        }
    label_3358_193F_34EBF_14888:
        CheckExternalEvents(cs2, 0x193F);
        // 3358:193F ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_010C_3368C(int loadOffset)
    {
    label_3358_010C_3368C_14977:
        CheckExternalEvents(cs2, 0x010C);
        // 3358:010C jmp near 0x1940
    label_3358_1940_34EC0_14979:
        CheckExternalEvents(cs2, 0x1940);
        // 3358:1940 push AX
        Stack.Push16(AX);
        // 3358:1941 push BX
        Stack.Push16(BX);
        // 3358:1942 push CX
        Stack.Push16(CX);
        // 3358:1943 push DX
        Stack.Push16(DX);
        // 3358:1944 push SI
        Stack.Push16(SI);
        // 3358:1945 push DI
        Stack.Push16(DI);
        // 3358:1946 push BP
        Stack.Push16(BP);
        // 3358:1947 push DS
        Stack.Push16(DS);
        // 3358:1948 push ES
        Stack.Push16(ES);
        // 3358:1949 mov BP,word ptr CS:[0x018A]
        BP = UInt16[CS, (ushort)0x018A];
        // 3358:194E mov BX,word ptr CS:[0x018C]
        BX = UInt16[CS, (ushort)0x018C];
        // 3358:1953 mov DX,word ptr CS:[0x018E]
        DX = UInt16[CS, (ushort)0x018E];
        // 3358:1958 mov AX,0xA000
        AX = (ushort)0xA000;
        // 3358:195B mov ES,AX
        ES = AX;
        // 3358:195D mov DS,AX
        DS = AX;
        // 3358:195F mov SI,0xFA00
        SI = (ushort)0xFA00;
    label_3358_1962_34EE2_14996:
        CheckExternalEvents(cs2, 0x1962);
        // 3358:1962 mov DI,BP
        DI = BP;
        // 3358:1964 mov CX,BX
        CX = BX;
        // 3358:1966 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1968 add BP,0x0140
        BP = Alu16.Add(BP, (ushort)0x0140);
        // 3358:196C dec DX
        DX = Alu16.Dec(DX);
        // 3358:196D jne short 0x1962
        if (!ZeroFlag)
        {
            goto label_3358_1962_34EE2_14996;
        }
    label_3358_196F_34EEF_15003:
        CheckExternalEvents(cs2, 0x196F);
        // 3358:196F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1970 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1971 pop BP
        BP = Stack.Pop16();
        // 3358:1972 pop DI
        DI = Stack.Pop16();
        // 3358:1973 pop SI
        SI = Stack.Pop16();
        // 3358:1974 pop DX
        DX = Stack.Pop16();
        // 3358:1975 pop CX
        CX = Stack.Pop16();
        // 3358:1976 pop BX
        BX = Stack.Pop16();
        // 3358:1977 pop AX
        AX = Stack.Pop16();
        // 3358:1978 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_010F_3368F(int loadOffset)
    {
    label_3358_010F_3368F_5308:
        CheckExternalEvents(cs2, 0x010F);
        // 3358:010F jmp near 0x0F5B
        goto label_3358_0F5B_344DB_5310;
    label_3358_0CD5_34255_6965:
        CheckExternalEvents(cs2, 0x0CD5);
        // 3358:0CD5 mov BP,word ptr [0x00034256]
        BP = UInt16[unchecked((uint)(0x00034256u))];
        // 3358:0CD8 add DI,BP
        DI = Alu16.Add(DI, BP);
        // 3358:0CDA add DI,BP
        DI = Alu16.Add(DI, BP);
        // 3358:0CDC selector
        if (SelectorSignatureMatches(cs2, 0x0CDC, [(byte)0x81, (byte)0xC7, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0CDC_3425C_6936;
        }
        if (SelectorSignatureMatches(cs2, 0x0CDC, [(byte)0x81, (byte)0xEF, (byte)0x40, (byte)0x01]))
        {
            goto label_3358_0CDC_3425C_9605;
        }
        throw FailAsUntested("No selector signature matched at 3358:0CDC");
    label_3358_0CDC_3425C_6936:
        CheckExternalEvents(cs2, 0x0CDC);
        // 3358:0CDC add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        goto label_3358_0CE0_34260_6865;
    label_3358_0CDC_3425C_9605:
        CheckExternalEvents(cs2, 0x0CDC);
        // 3358:0CDC sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
    label_3358_0CE0_34260_6865:
        CheckExternalEvents(cs2, 0x0CE0);
        // 3358:0CE0 mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 3358:0CE2 inc SI
        SI = Alu16.Inc(SI);
        // 3358:0CE3 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0CE5 js short 0x0D51
        if (SignFlag)
        {
            goto label_3358_0D51_342D1_6870;
        }
    label_3358_0CE7_34267_6902:
        CheckExternalEvents(cs2, 0x0CE7);
        // 3358:0CE7 mov CX,AX
        CX = AX;
        // 3358:0CE9 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0CEB inc CX
        CX = Alu16.Inc(CX);
        // 3358:0CEC sub BP,CX
        BP = Alu16.Sub(BP, CX);
    label_3358_0CEE_3426E_6907:
        CheckExternalEvents(cs2, 0x0CEE);
        // 3358:0CEE mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 3358:0CF0 inc SI
        SI = Alu16.Inc(SI);
        // 3358:0CF1 mov AH,AL
        AH = AL;
        // 3358:0CF3 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:0CF5 je short 0x0D1A
        if (ZeroFlag)
        {
            goto label_3358_0D1A_3429A_6943;
        }
    label_3358_0CF7_34277_6912:
        CheckExternalEvents(cs2, 0x0CF7);
        // 3358:0CF7 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0CF9 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0CFA shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_0CFC_3427C_6916:
        CheckExternalEvents(cs2, 0x0CFC);
        // 3358:0CFC shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0CFE shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0D00 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0D02 je short 0x0D1F
        if (ZeroFlag)
        {
            goto label_3358_0D1F_3429F_6940;
        }
    label_3358_0D04_34284_6920:
        CheckExternalEvents(cs2, 0x0D04);
        // 3358:0D04 mov AL,AH
        AL = AH;
        // 3358:0D06 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0D08 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0D09 loop 0x0CEE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0CEE_3426E_6907;
        }
    label_3358_0D0B_3428B_6926:
        CheckExternalEvents(cs2, 0x0D0B);
        // 3358:0D0B or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0D0D ja short 0x0CE0
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0CE0_34260_6865;
        }
    label_3358_0D0F_3428F_6937:
        CheckExternalEvents(cs2, 0x0D0F);
        // 3358:0D0F dec BX
        BX = Alu16.Dec(BX);
        // 3358:0D10 jne short 0x0CD5
        if (!ZeroFlag)
        {
            goto label_3358_0CD5_34255_6965;
        }
    label_3358_0D12_34292_6955:
        CheckExternalEvents(cs2, 0x0D12);
        // 3358:0D12 cld
        DirectionFlag = false;
        // 3358:0D13 mov byte ptr CS:[0x0CDD],0xC7
        UInt8[CS, (ushort)0x0CDD] = (byte)0xC7;
        // 3358:0D19 ret far
        return FarRet((ushort)0x0000);
    label_3358_0D1A_3429A_6943:
        CheckExternalEvents(cs2, 0x0D1A);
        // 3358:0D1A dec DI
        DI = Alu16.Dec(DI);
        // 3358:0D1B shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:0D1D jne short 0x0CFC
        if (!ZeroFlag)
        {
            goto label_3358_0CFC_3427C_6916;
        }
    label_3358_0D1F_3429F_6940:
        CheckExternalEvents(cs2, 0x0D1F);
        // 3358:0D1F dec DI
        DI = Alu16.Dec(DI);
        // 3358:0D20 loop 0x0CEE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0CEE_3426E_6907;
        }
    label_3358_0D22_342A2_6953:
        CheckExternalEvents(cs2, 0x0D22);
        // 3358:0D22 jmp short 0x0D0B
        goto label_3358_0D0B_3428B_6926;
    label_3358_0D24_342A4_6948:
        CheckExternalEvents(cs2, 0x0D24);
        // 3358:0D24 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 3358:0D26 sub DI,CX
        DI = Alu16.Sub(DI, CX);
        // 3358:0D28 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0D2A ja short 0x0CE0
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0CE0_34260_6865;
        }
    label_3358_0D2C_342AC_6963:
        CheckExternalEvents(cs2, 0x0D2C);
        // 3358:0D2C jmp short 0x0D46
        goto label_3358_0D46_342C6_6929;
    label_3358_0D2F_342AF_20450:
        CheckExternalEvents(cs2, 0x0D2F);
        // 3358:0D2F mov AL,AH
        AL = AH;
        // 3358:0D31 add AL,DH
        AL = Alu8.Add(AL, DH);
    label_3358_0D33_342B3_20453:
        CheckExternalEvents(cs2, 0x0D33);
        // 3358:0D33 dec DI
        DI = Alu16.Dec(DI);
        // 3358:0D34 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0D35 loop 0x0D33
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0D33_342B3_20453;
        }
    label_3358_0D37_342B7_20457:
        CheckExternalEvents(cs2, 0x0D37);
        // 3358:0D37 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0D39 ja short 0x0CE0
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0CE0_34260_6865;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:0D39");
        }
    label_3358_0D3E_342BE_7612:
        CheckExternalEvents(cs2, 0x0D3E);
        // 3358:0D3E stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0D3F dec DI
        DI = Alu16.Dec(DI);
        // 3358:0D40 loop 0x0D3E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0D3E_342BE_7612;
        }
    label_3358_0D42_342C2_6899:
        CheckExternalEvents(cs2, 0x0D42);
        // 3358:0D42 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0D44 ja short 0x0CE0
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0CE0_34260_6865;
        }
    label_3358_0D46_342C6_6929:
        CheckExternalEvents(cs2, 0x0D46);
        // 3358:0D46 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0D47 jne short 0x0CD5
        if (!ZeroFlag)
        {
            goto label_3358_0CD5_34255_6965;
        }
    label_3358_0D49_342C9_6959:
        CheckExternalEvents(cs2, 0x0D49);
        // 3358:0D49 cld
        DirectionFlag = false;
        // 3358:0D4A mov byte ptr CS:[0x0CDD],0xC7
        UInt8[CS, (ushort)0x0CDD] = (byte)0xC7;
        // 3358:0D50 ret far
        return FarRet((ushort)0x0000);
    label_3358_0D51_342D1_6870:
        CheckExternalEvents(cs2, 0x0D51);
        // 3358:0D51 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:0D54 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0D56 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:0D58 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:0D5A mov AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        // 3358:0D5C inc SI
        SI = Alu16.Inc(SI);
        // 3358:0D5D shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0D5F je short 0x0D24
        if (ZeroFlag)
        {
            goto label_3358_0D24_342A4_6948;
        }
    label_3358_0D61_342E1_6879:
        CheckExternalEvents(cs2, 0x0D61);
        // 3358:0D61 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0D63 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0D65 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0D67 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0D69 je short 0x0D2F
        if (ZeroFlag)
        {
            goto label_3358_0D2F_342AF_20450;
        }
    label_3358_0D6B_342EB_6885:
        CheckExternalEvents(cs2, 0x0D6B);
        // 3358:0D6B shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0D6D shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0D6F shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:0D71 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:0D73 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 3358:0D75 je short 0x0D3E
        if (ZeroFlag)
        {
            goto label_3358_0D3E_342BE_7612;
        }
    label_3358_0D77_342F7_6892:
        CheckExternalEvents(cs2, 0x0D77);
        // 3358:0D77 add AH,DH
        AH = Alu8.Add(AH, DH);
        // 3358:0D79 dec DI
        DI = Alu16.Dec(DI);
        // 3358:0D7A xchg AH,AL
        byte temp_3358_0D7A_342FA = AH;
        AH = AL;
        AL = unchecked((byte)temp_3358_0D7A_342FA);
        // 3358:0D7C rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0D7E inc DI
        DI = Alu16.Inc(DI);
        // 3358:0D7F jmp short 0x0D42
        goto label_3358_0D42_342C2_6899;
    label_3358_0E2D_343AD_5453:
        CheckExternalEvents(cs2, 0x0E2D);
        // 3358:0E2D mov BP,DX
        BP = DX;
        // 3358:0E2F sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 3358:0E31 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
    label_3358_0E35_343B5_5420:
        CheckExternalEvents(cs2, 0x0E35);
        // 3358:0E35 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0E36 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0E38 js short 0x0E6A
        if (SignFlag)
        {
            goto label_3358_0E6A_343EA_5424;
        }
    label_3358_0E3A_343BA_5436:
        CheckExternalEvents(cs2, 0x0E3A);
        // 3358:0E3A mov CX,AX
        CX = AX;
        // 3358:0E3C xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0E3E inc CX
        CX = Alu16.Inc(CX);
        // 3358:0E3F sub BP,CX
        BP = Alu16.Sub(BP, CX);
    label_3358_0E41_343C1_5441:
        CheckExternalEvents(cs2, 0x0E41);
        // 3358:0E41 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0E42 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0E44 je short 0x0E5E
        if (ZeroFlag)
        {
            goto label_3358_0E5E_343DE_5458;
        }
    label_3358_0E46_343C6_5444:
        CheckExternalEvents(cs2, 0x0E46);
        // 3358:0E46 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0E47 loop 0x0E41
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0E41_343C1_5441;
        }
    label_3358_0E49_343C9_5447:
        CheckExternalEvents(cs2, 0x0E49);
        // 3358:0E49 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0E4B ja short 0x0E35
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0E35_343B5_5420;
        }
    label_3358_0E4D_343CD_5461:
        CheckExternalEvents(cs2, 0x0E4D);
        // 3358:0E4D dec BX
        BX = Alu16.Dec(BX);
        // 3358:0E4E jne short 0x0E2D
        if (!ZeroFlag)
        {
            goto label_3358_0E2D_343AD_5453;
        }
    label_3358_0E50_343D0_5476:
        CheckExternalEvents(cs2, 0x0E50);
        // 3358:0E50 cld
        DirectionFlag = false;
        // 3358:0E51 mov byte ptr CS:[0x0E32],0xC7
        UInt8[CS, (ushort)0x0E32] = (byte)0xC7;
        // 3358:0E57 mov byte ptr CS:[0x0EF0],0xC7
        UInt8[CS, (ushort)0x0EF0] = (byte)0xC7;
        // 3358:0E5D ret far
        return FarRet((ushort)0x0000);
    label_3358_0E5E_343DE_5458:
        CheckExternalEvents(cs2, 0x0E5E);
        // 3358:0E5E inc DI
        DI = Alu16.Inc(DI);
        // 3358:0E5F loop 0x0E41
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0E41_343C1_5441;
        }
    label_3358_0E61_343E1_5468:
        CheckExternalEvents(cs2, 0x0E61);
        // 3358:0E61 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0E63 ja short 0x0E35
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0E35_343B5_5420;
        }
    label_3358_0E65_343E5_5471:
        CheckExternalEvents(cs2, 0x0E65);
        // 3358:0E65 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0E66 jne short 0x0E2D
        if (!ZeroFlag)
        {
            goto label_3358_0E2D_343AD_5453;
        }
    label_3358_0E68_343E8_5918:
        CheckExternalEvents(cs2, 0x0E68);
        // 3358:0E68 jmp short 0x0E50
        goto label_3358_0E50_343D0_5476;
    label_3358_0E6A_343EA_5424:
        CheckExternalEvents(cs2, 0x0E6A);
        // 3358:0E6A mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:0E6D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0E6F sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:0E71 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:0E73 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0E74 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0E76 je short 0x0E83
        if (ZeroFlag)
        {
            goto label_3358_0E83_34403_5432;
        }
    label_3358_0E78_343F8_5464:
        CheckExternalEvents(cs2, 0x0E78);
        // 3358:0E78 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0E7A or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0E7C ja short 0x0E35
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0E35_343B5_5420;
        }
    label_3358_0E7E_343FE_5950:
        CheckExternalEvents(cs2, 0x0E7E);
        // 3358:0E7E dec BX
        BX = Alu16.Dec(BX);
        // 3358:0E7F jne short 0x0E2D
        if (!ZeroFlag)
        {
            goto label_3358_0E2D_343AD_5453;
        }
    label_3358_0E81_34401_5959:
        CheckExternalEvents(cs2, 0x0E81);
        // 3358:0E81 jmp short 0x0E50
        goto label_3358_0E50_343D0_5476;
    label_3358_0E83_34403_5432:
        CheckExternalEvents(cs2, 0x0E83);
        // 3358:0E83 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:0E85 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:0E87 ja short 0x0E35
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0E35_343B5_5420;
        }
    label_3358_0E89_34409_5450:
        CheckExternalEvents(cs2, 0x0E89);
        // 3358:0E89 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0E8A jne short 0x0E2D
        if (!ZeroFlag)
        {
            goto label_3358_0E2D_343AD_5453;
        }
    label_3358_0E8C_3440C_5474:
        CheckExternalEvents(cs2, 0x0E8C);
        // 3358:0E8C jmp short 0x0E50
        goto label_3358_0E50_343D0_5476;
    label_3358_0EEB_3446B_5825:
        CheckExternalEvents(cs2, 0x0EEB);
        // 3358:0EEB mov BP,DX
        BP = DX;
        // 3358:0EED sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 3358:0EEF add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
    label_3358_0EF3_34473_5803:
        CheckExternalEvents(cs2, 0x0EF3);
        // 3358:0EF3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0EF4 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:0EF6 js short 0x0F09
        if (SignFlag)
        {
            goto label_3358_0F09_34489_5807;
        }
    label_3358_0EF8_34478_5815:
        CheckExternalEvents(cs2, 0x0EF8);
        // 3358:0EF8 mov CX,AX
        CX = AX;
        // 3358:0EFA xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0EFC inc CX
        CX = Alu16.Inc(CX);
        // 3358:0EFD sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:0EFF rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0F01 ja short 0x0EF3
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0EF3_34473_5803;
        }
    label_3358_0F03_34483_5829:
        CheckExternalEvents(cs2, 0x0F03);
        // 3358:0F03 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0F04 jne short 0x0EEB
        if (!ZeroFlag)
        {
            goto label_3358_0EEB_3446B_5825;
        }
    label_3358_0F06_34486_5845:
        CheckExternalEvents(cs2, 0x0F06);
        // 3358:0F06 jmp near 0x0E50
        goto label_3358_0E50_343D0_5476;
    label_3358_0F09_34489_5807:
        CheckExternalEvents(cs2, 0x0F09);
        // 3358:0F09 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:0F0C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:0F0E sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:0F10 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:0F12 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0F13 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0F15 ja short 0x0EF3
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_0EF3_34473_5803;
        }
    label_3358_0F17_34497_5822:
        CheckExternalEvents(cs2, 0x0F17);
        // 3358:0F17 dec BX
        BX = Alu16.Dec(BX);
        // 3358:0F18 jne short 0x0EEB
        if (!ZeroFlag)
        {
            goto label_3358_0EEB_3446B_5825;
        }
    label_3358_0F1A_3449A_5832:
        CheckExternalEvents(cs2, 0x0F1A);
        // 3358:0F1A jmp near 0x0E50
        goto label_3358_0E50_343D0_5476;
    label_3358_0F5B_344DB_5310:
        CheckExternalEvents(cs2, 0x0F5B);
        // 3358:0F5B cmp CH,0xFE
        Alu8.Sub(CH, (byte)0xFE);
        // 3358:0F5E jb short 0x0F63
        if (CarryFlag)
        {
            goto label_3358_0F63_344E3_6021;
        }
    label_3358_0F60_344E0_5313:
        CheckExternalEvents(cs2, 0x0F60);
        // 3358:0F60 jmp near 0x100A
        goto label_3358_100A_3458A_5315;
    label_3358_0F63_344E3_6021:
        CheckExternalEvents(cs2, 0x0F63);
        // 3358:0F63 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 3358:0F65 js short 0x0F8E
        if (SignFlag)
        {
            goto label_3358_0F8E_3450E_6024;
        }
    label_3358_0F67_344E7_7304:
        CheckExternalEvents(cs2, 0x0F67);
        // 3358:0F67 mov AX,DI
        AX = DI;
        // 3358:0F69 mov BP,0x0100
        BP = (ushort)0x0100;
        // 3358:0F6C test AX,0x6000
        Alu16.And(AX, (ushort)0x6000);
        // 3358:0F6F je short 0x0F74
        if (ZeroFlag)
        {
            goto label_3358_0F74_344F4_7309;
        }
    label_3358_0F71_344F1_7385:
        CheckExternalEvents(cs2, 0x0F71);
        // 3358:0F71 jmp near 0x0D85
        return unknown_3358_0D85_34305(0x0000);
    label_3358_0F74_344F4_7309:
        CheckExternalEvents(cs2, 0x0F74);
        // 3358:0F74 and AX,0x01FF
        AX = Alu16.And(AX, (ushort)0x01FF);
        // 3358:0F77 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 3358:0F7A shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:0F7C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:0F7E mov word ptr CS:[0x158B],AX
        UInt16[CS, (ushort)0x158B] = AX;
        // 3358:0F82 call near 0x0C10
        NearCall(cs2, 0x0F85, unknown_3358_0C10_34190);
    label_3358_0F85_34505_7316:
        CheckExternalEvents(cs2, 0x0F85);
        // 3358:0F85 mov DH,CH
        DH = CH;
        // 3358:0F87 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0F89 mov DL,0x0F
        DL = (byte)0x0F;
        // 3358:0F8B jmp near 0x158A
        return unknown_3358_158A_34B0A(0x0000);
    label_3358_0F8E_3450E_6024:
        CheckExternalEvents(cs2, 0x0F8E);
        // 3358:0F8E mov AX,DI
        AX = DI;
        // 3358:0F90 and AX,0x01FF
        AX = Alu16.And(AX, (ushort)0x01FF);
        // 3358:0F93 mov word ptr CS:[0x0D81],AX
        UInt16[CS, (ushort)0x0D81] = AX;
        // 3358:0F97 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 3358:0F9A shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:0F9C shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:0F9E shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:0FA0 mov BP,AX
        BP = AX;
        // 3358:0FA2 mov AX,DI
        AX = DI;
        // 3358:0FA4 call near 0x0C10
        NearCall(cs2, 0x0FA7, unknown_3358_0C10_34190);
    label_3358_0FA7_34527_6035:
        CheckExternalEvents(cs2, 0x0FA7);
        // 3358:0FA7 mov DH,CH
        DH = CH;
        // 3358:0FA9 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:0FAB mov DL,0x0F
        DL = (byte)0x0F;
        // 3358:0FAD mov BX,CX
        BX = CX;
        // 3358:0FAF test AX,0x4000
        Alu16.And(AX, (ushort)0x4000);
        // 3358:0FB2 jne short 0x0FD9
        if (!ZeroFlag)
        {
            goto label_3358_0FD9_34559_6856;
        }
    label_3358_0FB4_34534_6042:
        CheckExternalEvents(cs2, 0x0FB4);
        // 3358:0FB4 mov word ptr CS:[0x0C3C],BP
        UInt16[CS, (ushort)0x0C3C] = BP;
        // 3358:0FB9 test AX,0x2000
        Alu16.And(AX, (ushort)0x2000);
        // 3358:0FBC je short 0x0FD6
        if (ZeroFlag)
        {
            goto label_3358_0FD6_34556_6046;
        }
    label_3358_0FBE_3453E_9609:
        CheckExternalEvents(cs2, 0x0FBE);
        // 3358:0FBE mov byte ptr CS:[0x0C43],0xEF
        UInt8[CS, (ushort)0x0C43] = (byte)0xEF;
        // 3358:0FC4 mov AH,BL
        AH = BL;
        // 3358:0FC6 dec AH
        AH = Alu8.Dec(AH);
        // 3358:0FC8 mov CH,AH
        CH = AH;
        // 3358:0FCA xor CL,CL
        CL = Alu8.Xor(CL, CL);
        // 3358:0FCC mov AL,CL
        AL = CL;
        // 3358:0FCE shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:0FD0 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:0FD2 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:0FD4 add DI,CX
        DI = Alu16.Add(DI, CX);
    label_3358_0FD6_34556_6046:
        CheckExternalEvents(cs2, 0x0FD6);
        // 3358:0FD6 jmp near 0x0C46
        return unknown_3358_0C46_341C6(0x0000);
    label_3358_0FD9_34559_6856:
        CheckExternalEvents(cs2, 0x0FD9);
        // 3358:0FD9 mov word ptr CS:[0x0CD6],BP
        UInt16[CS, (ushort)0x0CD6] = BP;
        // 3358:0FDE test AX,0x2000
        Alu16.And(AX, (ushort)0x2000);
        // 3358:0FE1 je short 0x0FFB
        if (ZeroFlag)
        {
            goto label_3358_0FFB_3457B_6860;
        }
    label_3358_0FE3_34563_9594:
        CheckExternalEvents(cs2, 0x0FE3);
        // 3358:0FE3 mov byte ptr CS:[0x0CDD],0xEF
        UInt8[CS, (ushort)0x0CDD] = (byte)0xEF;
        // 3358:0FE9 mov AH,BL
        AH = BL;
        // 3358:0FEB dec AH
        AH = Alu8.Dec(AH);
        // 3358:0FED mov CH,AH
        CH = AH;
        // 3358:0FEF xor CL,CL
        CL = Alu8.Xor(CL, CL);
        // 3358:0FF1 mov AL,CL
        AL = CL;
        // 3358:0FF3 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:0FF5 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:0FF7 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:0FF9 add DI,CX
        DI = Alu16.Add(DI, CX);
    label_3358_0FFB_3457B_6860:
        CheckExternalEvents(cs2, 0x0FFB);
        // 3358:0FFB add DI,word ptr CS:[0x0D81]
        DI = Alu16.Add(DI, UInt16[CS, (ushort)0x0D81]);
        // 3358:1000 dec DI
        DI = Alu16.Dec(DI);
        // 3358:1001 std
        DirectionFlag = true;
        // 3358:1002 jmp near 0x0CE0
        goto label_3358_0CE0_34260_6865;
    label_3358_100A_3458A_5315:
        CheckExternalEvents(cs2, 0x100A);
        // 3358:100A or DI,DI
        DI = Alu16.Or(DI, DI);
        // 3358:100C js short 0x1064
        if (SignFlag)
        {
            goto label_3358_1064_345E4_5401;
        }
    label_3358_100E_3458E_5318:
        CheckExternalEvents(cs2, 0x100E);
        // 3358:100E mov BP,DI
        BP = DI;
        // 3358:1010 and BP,0x01FF
        BP = Alu16.And(BP, (ushort)0x01FF);
        // 3358:1014 mov AX,DI
        AX = DI;
        // 3358:1016 call near 0x0C10
        NearCall(cs2, 0x1019, unknown_3358_0C10_34190);
    label_3358_1019_34599_5336:
        CheckExternalEvents(cs2, 0x1019);
        // 3358:1019 mov BX,CX
        BX = CX;
        // 3358:101B xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 3358:101D cmp CH,0xFF
        Alu8.Sub(CH, (byte)0xFF);
        // 3358:1020 je short 0x1043
        if (ZeroFlag)
        {
            goto label_3358_1043_345C3_5376;
        }
    label_3358_1022_345A2_5341:
        CheckExternalEvents(cs2, 0x1022);
        // 3358:1022 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:1024 mov AX,DI
        AX = DI;
        // 3358:1026 jb short 0x1035
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:1026");
        }
    label_3358_1028_345A8_5345:
        CheckExternalEvents(cs2, 0x1028);
        // 3358:1028 mov CX,BP
        CX = BP;
        // 3358:102A mov DI,AX
        DI = AX;
        // 3358:102C rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:102E add AX,0x0140
        AX = Alu16.Add(AX, (ushort)0x0140);
        // 3358:1031 dec BX
        BX = Alu16.Dec(BX);
        // 3358:1032 jne short 0x1028
        if (!ZeroFlag)
        {
            goto label_3358_1028_345A8_5345;
        }
    label_3358_1034_345B4_5352:
        CheckExternalEvents(cs2, 0x1034);
        // 3358:1034 ret far
        return FarRet((ushort)0x0000);
    label_3358_1043_345C3_5376:
        CheckExternalEvents(cs2, 0x1043);
        // 3358:1043 mov DX,DI
        DX = DI;
    label_3358_1045_345C5_5378:
        CheckExternalEvents(cs2, 0x1045);
        // 3358:1045 mov CX,BP
        CX = BP;
        // 3358:1047 mov DI,DX
        DI = DX;
    label_3358_1049_345C9_5380:
        CheckExternalEvents(cs2, 0x1049);
        // 3358:1049 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:104A or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:104C je short 0x1059
        if (ZeroFlag)
        {
            goto label_3358_1059_345D9_5383;
        }
    label_3358_104E_345CE_5387:
        CheckExternalEvents(cs2, 0x104E);
        // 3358:104E stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:104F loop 0x1049
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1049_345C9_5380;
        }
    label_3358_1051_345D1_5395:
        CheckExternalEvents(cs2, 0x1051);
        // 3358:1051 add DX,0x0140
        DX = Alu16.Add(DX, (ushort)0x0140);
        // 3358:1055 dec BX
        BX = Alu16.Dec(BX);
        // 3358:1056 jne short 0x1045
        if (!ZeroFlag)
        {
            goto label_3358_1045_345C5_5378;
        }
    label_3358_1058_345D8_5488:
        CheckExternalEvents(cs2, 0x1058);
        // 3358:1058 ret far
        return FarRet((ushort)0x0000);
    label_3358_1059_345D9_5383:
        CheckExternalEvents(cs2, 0x1059);
        // 3358:1059 inc DI
        DI = Alu16.Inc(DI);
        // 3358:105A loop 0x1049
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1049_345C9_5380;
        }
    label_3358_105C_345DC_5390:
        CheckExternalEvents(cs2, 0x105C);
        // 3358:105C add DX,0x0140
        DX = Alu16.Add(DX, (ushort)0x0140);
        // 3358:1060 dec BX
        BX = Alu16.Dec(BX);
        // 3358:1061 jne short 0x1045
        if (!ZeroFlag)
        {
            goto label_3358_1045_345C5_5378;
        }
    label_3358_1063_345E3_5399:
        CheckExternalEvents(cs2, 0x1063);
        // 3358:1063 ret far
        return FarRet((ushort)0x0000);
    label_3358_1064_345E4_5401:
        CheckExternalEvents(cs2, 0x1064);
        // 3358:1064 mov BP,DI
        BP = DI;
        // 3358:1066 and BP,0x01FF
        BP = Alu16.And(BP, (ushort)0x01FF);
        // 3358:106A mov AX,DI
        AX = DI;
        // 3358:106C call near 0x0C10
        NearCall(cs2, 0x106F, unknown_3358_0C10_34190);
    label_3358_106F_345EF_5406:
        CheckExternalEvents(cs2, 0x106F);
        // 3358:106F mov BX,CX
        BX = CX;
        // 3358:1071 xor BH,BH
        BH = Alu8.Xor(BH, BH);
        // 3358:1073 test AX,0x4000
        Alu16.And(AX, (ushort)0x4000);
        // 3358:1076 jne short 0x10A8
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:1076");
        }
    label_3358_1078_345F8_5411:
        CheckExternalEvents(cs2, 0x1078);
        // 3358:1078 test AX,0x2000
        Alu16.And(AX, (ushort)0x2000);
        // 3358:107B je short 0x109B
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:107B");
        }
    label_3358_109B_3461B_5414:
        CheckExternalEvents(cs2, 0x109B);
        // 3358:109B mov DX,BP
        DX = BP;
        // 3358:109D cmp CH,0xFF
        Alu8.Sub(CH, (byte)0xFF);
        // 3358:10A0 je short 0x10A5
        if (ZeroFlag)
        {
            goto label_3358_10A5_34625_5418;
        }
    label_3358_10A2_34622_5801:
        CheckExternalEvents(cs2, 0x10A2);
        // 3358:10A2 jmp near 0x0EF3
        goto label_3358_0EF3_34473_5803;
    label_3358_10A5_34625_5418:
        CheckExternalEvents(cs2, 0x10A5);
        // 3358:10A5 jmp near 0x0E35
        goto label_3358_0E35_343B5_5420;
    }

    public virtual Action unknown_3358_0112_33692(int loadOffset)
    {
    label_3358_0112_33692_8158:
        CheckExternalEvents(cs2, 0x0112);
        // 3358:0112 jmp near 0x1452
        goto label_3358_1452_349D2_8160;
    label_3358_10E2_34662_9380:
        CheckExternalEvents(cs2, 0x10E2);
        // 3358:10E2 mov BP,word ptr CS:[0x10DE]
        BP = UInt16[CS, (ushort)0x10DE];
        // 3358:10E7 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:10E9 pushf
        Stack.Push16(FlagRegister16);
        // 3358:10EA jcxz short 0x10F4
        if (CX == (ushort)0x0000)
        {
            goto label_3358_10F4_34674_9385;
        }
    label_3358_10EC_3466C_9471:
        CheckExternalEvents(cs2, 0x10EC);
        // 3358:10EC or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:10EE js short 0x111D
        if (SignFlag)
        {
            goto label_3358_111D_3469D_9395;
        }
    label_3358_10F0_34670_9486:
        CheckExternalEvents(cs2, 0x10F0);
        // 3358:10F0 jmp short 0x1100
        goto label_3358_1100_34680_9400;
    label_3358_10F2_34672_9402:
        CheckExternalEvents(cs2, 0x10F2);
        // 3358:10F2 add SI,CX
        SI = Alu16.Add(SI, CX);
    label_3358_10F4_34674_9385:
        CheckExternalEvents(cs2, 0x10F4);
        // 3358:10F4 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:10F5 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:10F7 mov DL,AL
        DL = AL;
        // 3358:10F9 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:10FB js short 0x1117
        if (SignFlag)
        {
            goto label_3358_1117_34697_9391;
        }
    label_3358_10FD_3467D_9397:
        CheckExternalEvents(cs2, 0x10FD);
        // 3358:10FD mov CX,AX
        CX = AX;
        // 3358:10FF inc CX
        CX = Alu16.Inc(CX);
    label_3358_1100_34680_9400:
        CheckExternalEvents(cs2, 0x1100);
        // 3358:1100 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1102 jae short 0x10F2
        if (!CarryFlag)
        {
            goto label_3358_10F2_34672_9402;
        }
    label_3358_1104_34684_9994:
        CheckExternalEvents(cs2, 0x1104);
        // 3358:1104 add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:1106 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:1108 mov CX,BP
        CX = BP;
        // 3358:110A neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:110C mov BP,word ptr CS:[0x10E0]
        BP = UInt16[CS, (ushort)0x10E0];
    label_3358_1111_34691_10000:
        CheckExternalEvents(cs2, 0x1111);
        // 3358:1111 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_1112_34692_10002:
        CheckExternalEvents(cs2, 0x1112);
        // 3358:1112 jae short 0x1146
        if (!CarryFlag)
        {
            goto label_3358_1146_346C6_9425;
        }
    label_3358_1114_34694_10116:
        CheckExternalEvents(cs2, 0x1114);
        // 3358:1114 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1115 jmp short 0x1132
        goto label_3358_1132_346B2_9415;
    label_3358_1117_34697_9391:
        CheckExternalEvents(cs2, 0x1117);
        // 3358:1117 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:111A sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:111C inc SI
        SI = Alu16.Inc(SI);
    label_3358_111D_3469D_9395:
        CheckExternalEvents(cs2, 0x111D);
        // 3358:111D sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:111F jae short 0x10F4
        if (!CarryFlag)
        {
            goto label_3358_10F4_34674_9385;
        }
    label_3358_1121_346A1_9404:
        CheckExternalEvents(cs2, 0x1121);
        // 3358:1121 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1123 mov CX,BP
        CX = BP;
        // 3358:1125 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1127 mov BP,word ptr CS:[0x10E0]
        BP = UInt16[CS, (ushort)0x10E0];
    label_3358_112C_346AC_9409:
        CheckExternalEvents(cs2, 0x112C);
        // 3358:112C popf
        FlagRegister16 = Stack.Pop16();
    label_3358_112D_346AD_9411:
        CheckExternalEvents(cs2, 0x112D);
        // 3358:112D jae short 0x1146
        if (!CarryFlag)
        {
            goto label_3358_1146_346C6_9425;
        }
    label_3358_112F_346AF_9413:
        CheckExternalEvents(cs2, 0x112F);
        // 3358:112F mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
    label_3358_1132_346B2_9415:
        CheckExternalEvents(cs2, 0x1132);
        // 3358:1132 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1134 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1136 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1138 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:113A je short 0x1141
        if (ZeroFlag)
        {
            goto label_3358_1141_346C1_9420;
        }
    label_3358_113C_346BC_10120:
        CheckExternalEvents(cs2, 0x113C);
        // 3358:113C add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:113E mov byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
    label_3358_1141_346C1_9420:
        CheckExternalEvents(cs2, 0x1141);
        // 3358:1141 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1142 dec CX
        CX = Alu16.Dec(CX);
        // 3358:1143 dec BP
        BP = Alu16.Dec(BP);
        // 3358:1144 je short 0x1184
        if (ZeroFlag)
        {
            goto label_3358_1184_34704_9462;
        }
    label_3358_1146_346C6_9425:
        CheckExternalEvents(cs2, 0x1146);
        // 3358:1146 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:1148 jcxz short 0x1151
        if (CX == (ushort)0x0000)
        {
            goto label_3358_1151_346D1_9449;
        }
    label_3358_114A_346CA_9428:
        CheckExternalEvents(cs2, 0x114A);
        // 3358:114A or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:114C jns short 0x115D
        if (!SignFlag)
        {
            goto label_3358_115D_346DD_9478;
        }
    label_3358_114E_346CE_9431:
        CheckExternalEvents(cs2, 0x114E);
        // 3358:114E jmp short 0x11A8
        goto label_3358_11A8_34728_9433;
    label_3358_1151_346D1_9449:
        CheckExternalEvents(cs2, 0x1151);
        // 3358:1151 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1152 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1154 mov DL,AL
        DL = AL;
        // 3358:1156 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1158 js short 0x11A2
        if (SignFlag)
        {
            goto label_3358_11A2_34722_9455;
        }
    label_3358_115A_346DA_9475:
        CheckExternalEvents(cs2, 0x115A);
        // 3358:115A mov CX,AX
        CX = AX;
        // 3358:115C inc CX
        CX = Alu16.Inc(CX);
    label_3358_115D_346DD_9478:
        CheckExternalEvents(cs2, 0x115D);
        // 3358:115D sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:115F jae short 0x1165
        if (!CarryFlag)
        {
            goto label_3358_1165_346E5_9966;
        }
    label_3358_1161_346E1_9480:
        CheckExternalEvents(cs2, 0x1161);
        // 3358:1161 add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:1163 je short 0x1180
        if (ZeroFlag)
        {
            goto label_3358_1180_34700_9483;
        }
    label_3358_1165_346E5_9966:
        CheckExternalEvents(cs2, 0x1165);
        // 3358:1165 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1166 mov AH,AL
        AH = AL;
        // 3358:1168 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 3358:116A je short 0x1198
        if (ZeroFlag)
        {
            goto label_3358_1198_34718_9984;
        }
    label_3358_116C_346EC_9971:
        CheckExternalEvents(cs2, 0x116C);
        // 3358:116C add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:116E stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:116F shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_1171_346F1_9975:
        CheckExternalEvents(cs2, 0x1171);
        // 3358:1171 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1173 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1175 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1177 je short 0x119D
        if (ZeroFlag)
        {
            goto label_3358_119D_3471D_9979;
        }
    label_3358_1179_346F9_9989:
        CheckExternalEvents(cs2, 0x1179);
        // 3358:1179 mov AL,AH
        AL = AH;
        // 3358:117B add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:117D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:117E loop 0x1165
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1165_346E5_9966;
        }
    label_3358_1180_34700_9483:
        CheckExternalEvents(cs2, 0x1180);
        // 3358:1180 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:1182 jns short 0x1151
        if (!SignFlag)
        {
            goto label_3358_1151_346D1_9449;
        }
    label_3358_1184_34704_9462:
        CheckExternalEvents(cs2, 0x1184);
        // 3358:1184 mov CX,BP
        CX = BP;
        // 3358:1186 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1188 sub DI,word ptr CS:[0x10E0]
        DI = Alu16.Sub(DI, UInt16[CS, (ushort)0x10E0]);
        // 3358:118D add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:1191 dec BX
        BX = Alu16.Dec(BX);
        // 3358:1192 je short 0x1197
        if (ZeroFlag)
        {
            goto label_3358_1197_34717_9489;
        }
    label_3358_1194_34714_9469:
        CheckExternalEvents(cs2, 0x1194);
        // 3358:1194 jmp near 0x10E2
        goto label_3358_10E2_34662_9380;
    label_3358_1197_34717_9489:
        CheckExternalEvents(cs2, 0x1197);
        // 3358:1197 ret far
        return FarRet((ushort)0x0000);
    label_3358_1198_34718_9984:
        CheckExternalEvents(cs2, 0x1198);
        // 3358:1198 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1199 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:119B jne short 0x1171
        if (!ZeroFlag)
        {
            goto label_3358_1171_346F1_9975;
        }
    label_3358_119D_3471D_9979:
        CheckExternalEvents(cs2, 0x119D);
        // 3358:119D inc DI
        DI = Alu16.Inc(DI);
        // 3358:119E loop 0x1165
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1165_346E5_9966;
        }
    label_3358_11A0_34720_9982:
        CheckExternalEvents(cs2, 0x11A0);
        // 3358:11A0 jmp short 0x1180
        goto label_3358_1180_34700_9483;
    label_3358_11A2_34722_9455:
        CheckExternalEvents(cs2, 0x11A2);
        // 3358:11A2 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:11A5 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:11A7 inc SI
        SI = Alu16.Inc(SI);
    label_3358_11A8_34728_9433:
        CheckExternalEvents(cs2, 0x11A8);
        // 3358:11A8 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:11AA jae short 0x11B0
        if (!CarryFlag)
        {
            goto label_3358_11B0_34730_9436;
        }
    label_3358_11AC_3472C_9459:
        CheckExternalEvents(cs2, 0x11AC);
        // 3358:11AC add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:11AE je short 0x11D1
        if (ZeroFlag)
        {
            goto label_3358_11D1_34751_9444;
        }
    label_3358_11B0_34730_9436:
        CheckExternalEvents(cs2, 0x11B0);
        // 3358:11B0 mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:11B3 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:11B5 je short 0x11D8
        if (ZeroFlag)
        {
            goto label_3358_11D8_34758_9440;
        }
    label_3358_11B7_34737_10093:
        CheckExternalEvents(cs2, 0x11B7);
        // 3358:11B7 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:11B9 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:11BB shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:11BD shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:11BF je short 0x11DE
        if (ZeroFlag)
        {
            goto label_3358_11DE_3475E_12373;
        }
    label_3358_11C1_34741_10099:
        CheckExternalEvents(cs2, 0x11C1);
        // 3358:11C1 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:11C3 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:11C5 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:11C7 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:11C9 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 3358:11CB je short 0x11E8
        if (ZeroFlag)
        {
            goto label_3358_11E8_34768_12367;
        }
    label_3358_11CD_3474D_10106:
        CheckExternalEvents(cs2, 0x11CD);
        // 3358:11CD add AH,DH
        AH = Alu8.Add(AH, DH);
        // 3358:11CF rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_11D1_34751_9444:
        CheckExternalEvents(cs2, 0x11D1);
        // 3358:11D1 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:11D3 js short 0x1184
        if (SignFlag)
        {
            goto label_3358_1184_34704_9462;
        }
    label_3358_11D5_34755_9447:
        CheckExternalEvents(cs2, 0x11D5);
        // 3358:11D5 jmp near 0x1151
        goto label_3358_1151_346D1_9449;
    label_3358_11D8_34758_9440:
        CheckExternalEvents(cs2, 0x11D8);
        // 3358:11D8 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 3358:11DA add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:11DC jmp short 0x11D1
        goto label_3358_11D1_34751_9444;
    label_3358_11DE_3475E_12373:
        CheckExternalEvents(cs2, 0x11DE);
        // 3358:11DE mov AL,AH
        AL = AH;
        // 3358:11E0 add AL,DH
        AL = Alu8.Add(AL, DH);
    label_3358_11E2_34762_12376:
        CheckExternalEvents(cs2, 0x11E2);
        // 3358:11E2 inc DI
        DI = Alu16.Inc(DI);
        // 3358:11E3 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:11E4 loop 0x11E2
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_11E2_34762_12376;
        }
    label_3358_11E6_34766_12380:
        CheckExternalEvents(cs2, 0x11E6);
        // 3358:11E6 jmp short 0x11D1
        goto label_3358_11D1_34751_9444;
    label_3358_11E8_34768_12367:
        CheckExternalEvents(cs2, 0x11E8);
        // 3358:11E8 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:11E9 inc DI
        DI = Alu16.Inc(DI);
        // 3358:11EA loop 0x11E8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_11E8_34768_12367;
        }
    label_3358_11EC_3476C_12371:
        CheckExternalEvents(cs2, 0x11EC);
        // 3358:11EC jmp short 0x11D1
        goto label_3358_11D1_34751_9444;
    label_3358_11EE_3476E_8823:
        CheckExternalEvents(cs2, 0x11EE);
        // 3358:11EE mov BP,word ptr CS:[0x10DE]
        BP = UInt16[CS, (ushort)0x10DE];
        // 3358:11F3 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:11F5 jne short 0x11FF
        if (!ZeroFlag)
        {
            goto label_3358_11FF_3477F_9202;
        }
    label_3358_11F7_34777_8827:
        CheckExternalEvents(cs2, 0x11F7);
        // 3358:11F7 mov BP,word ptr CS:[0x10E0]
        BP = UInt16[CS, (ushort)0x10E0];
        // 3358:11FC jmp short 0x1266
        goto label_3358_1266_347E6_8830;
    label_3358_11FF_3477F_9202:
        CheckExternalEvents(cs2, 0x11FF);
        // 3358:11FF shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:1201 pushf
        Stack.Push16(FlagRegister16);
        // 3358:1202 jcxz short 0x120C
        if (CX == (ushort)0x0000)
        {
            goto label_3358_120C_3478C_9206;
        }
    label_3358_1204_34784_9491:
        CheckExternalEvents(cs2, 0x1204);
        // 3358:1204 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:1206 js short 0x1235
        if (SignFlag)
        {
            goto label_3358_1235_347B5_9216;
        }
    label_3358_1208_34788_9494:
        CheckExternalEvents(cs2, 0x1208);
        // 3358:1208 jmp short 0x1218
        goto label_3358_1218_34798_9221;
    label_3358_120A_3478A_9223:
        CheckExternalEvents(cs2, 0x120A);
        // 3358:120A add SI,CX
        SI = Alu16.Add(SI, CX);
    label_3358_120C_3478C_9206:
        CheckExternalEvents(cs2, 0x120C);
        // 3358:120C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:120D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:120F mov DL,AL
        DL = AL;
        // 3358:1211 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1213 js short 0x122F
        if (SignFlag)
        {
            goto label_3358_122F_347AF_9212;
        }
    label_3358_1215_34795_9218:
        CheckExternalEvents(cs2, 0x1215);
        // 3358:1215 mov CX,AX
        CX = AX;
        // 3358:1217 inc CX
        CX = Alu16.Inc(CX);
    label_3358_1218_34798_9221:
        CheckExternalEvents(cs2, 0x1218);
        // 3358:1218 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:121A jae short 0x120A
        if (!CarryFlag)
        {
            goto label_3358_120A_3478A_9223;
        }
    label_3358_121C_3479C_9225:
        CheckExternalEvents(cs2, 0x121C);
        // 3358:121C add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:121E add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:1220 mov CX,BP
        CX = BP;
        // 3358:1222 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1224 mov BP,word ptr CS:[0x10E0]
        BP = UInt16[CS, (ushort)0x10E0];
    label_3358_1229_347A9_9231:
        CheckExternalEvents(cs2, 0x1229);
        // 3358:1229 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_122A_347AA_9233:
        CheckExternalEvents(cs2, 0x122A);
        // 3358:122A jae short 0x1266
        if (!CarryFlag)
        {
            goto label_3358_1266_347E6_8830;
        }
    label_3358_122C_347AC_9235:
        CheckExternalEvents(cs2, 0x122C);
        // 3358:122C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:122D jmp short 0x124A
        goto label_3358_124A_347CA_9238;
    label_3358_122F_347AF_9212:
        CheckExternalEvents(cs2, 0x122F);
        // 3358:122F mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:1232 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:1234 inc SI
        SI = Alu16.Inc(SI);
    label_3358_1235_347B5_9216:
        CheckExternalEvents(cs2, 0x1235);
        // 3358:1235 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1237 jae short 0x120C
        if (!CarryFlag)
        {
            goto label_3358_120C_3478C_9206;
        }
    label_3358_1239_347B9_9249:
        CheckExternalEvents(cs2, 0x1239);
        // 3358:1239 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:123B mov CX,BP
        CX = BP;
        // 3358:123D neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:123F mov BP,word ptr CS:[0x10E0]
        BP = UInt16[CS, (ushort)0x10E0];
    label_3358_1244_347C4_9254:
        CheckExternalEvents(cs2, 0x1244);
        // 3358:1244 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_1245_347C5_9256:
        CheckExternalEvents(cs2, 0x1245);
        // 3358:1245 jae short 0x1266
        if (!CarryFlag)
        {
            goto label_3358_1266_347E6_8830;
        }
    label_3358_1247_347C7_9258:
        CheckExternalEvents(cs2, 0x1247);
        // 3358:1247 mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
    label_3358_124A_347CA_9238:
        CheckExternalEvents(cs2, 0x124A);
        // 3358:124A shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:124C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:124E shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1250 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1252 je short 0x1259
        if (ZeroFlag)
        {
            goto label_3358_1259_347D9_9244;
        }
    label_3358_1254_347D4_10026:
        CheckExternalEvents(cs2, 0x1254);
        // 3358:1254 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:1256 mov byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
    label_3358_1259_347D9_9244:
        CheckExternalEvents(cs2, 0x1259);
        // 3358:1259 inc DI
        DI = Alu16.Inc(DI);
        // 3358:125A dec CX
        CX = Alu16.Dec(CX);
        // 3358:125B dec BP
        BP = Alu16.Dec(BP);
        // 3358:125C jne short 0x1266
        if (!ZeroFlag)
        {
            goto label_3358_1266_347E6_8830;
        }
    label_3358_125E_347DE_36318:
        CheckExternalEvents(cs2, 0x125E);
        // 3358:125E mov BP,word ptr CS:[0x10DC]
        BP = UInt16[CS, (ushort)0x10DC];
        // 3358:1263 jmp near 0x132C
        goto label_3358_132C_348AC_8878;
    label_3358_1266_347E6_8830:
        CheckExternalEvents(cs2, 0x1266);
        // 3358:1266 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:1268 pushf
        Stack.Push16(FlagRegister16);
        // 3358:1269 jcxz short 0x1272
        if (CX == (ushort)0x0000)
        {
            goto label_3358_1272_347F2_8834;
        }
    label_3358_126B_347EB_8907:
        CheckExternalEvents(cs2, 0x126B);
        // 3358:126B or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:126D jns short 0x127E
        if (!SignFlag)
        {
            goto label_3358_127E_347FE_8918;
        }
    label_3358_126F_347EF_8910:
        CheckExternalEvents(cs2, 0x126F);
        // 3358:126F jmp short 0x12C7
        goto label_3358_12C7_34847_8844;
    label_3358_1272_347F2_8834:
        CheckExternalEvents(cs2, 0x1272);
        // 3358:1272 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1273 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:1275 mov DL,AL
        DL = AL;
        // 3358:1277 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1279 js short 0x12C1
        if (SignFlag)
        {
            goto label_3358_12C1_34841_8840;
        }
    label_3358_127B_347FB_8915:
        CheckExternalEvents(cs2, 0x127B);
        // 3358:127B mov CX,AX
        CX = AX;
        // 3358:127D inc CX
        CX = Alu16.Inc(CX);
    label_3358_127E_347FE_8918:
        CheckExternalEvents(cs2, 0x127E);
        // 3358:127E sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1280 jae short 0x1286
        if (!CarryFlag)
        {
            goto label_3358_1286_34806_8923;
        }
    label_3358_1282_34802_8920:
        CheckExternalEvents(cs2, 0x1282);
        // 3358:1282 add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:1284 je short 0x12A1
        if (ZeroFlag)
        {
            goto label_3358_12A1_34821_8942;
        }
    label_3358_1286_34806_8923:
        CheckExternalEvents(cs2, 0x1286);
        // 3358:1286 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1287 mov AH,AL
        AH = AL;
        // 3358:1289 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 3358:128B je short 0x12B7
        if (ZeroFlag)
        {
            goto label_3358_12B7_34837_8928;
        }
    label_3358_128D_3480D_8968:
        CheckExternalEvents(cs2, 0x128D);
        // 3358:128D add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:128F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1290 shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_1292_34812_8932:
        CheckExternalEvents(cs2, 0x1292);
        // 3358:1292 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1294 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1296 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1298 je short 0x12BC
        if (ZeroFlag)
        {
            goto label_3358_12BC_3483C_8983;
        }
    label_3358_129A_3481A_8937:
        CheckExternalEvents(cs2, 0x129A);
        // 3358:129A mov AL,AH
        AL = AH;
        // 3358:129C add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:129E stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:129F loop 0x1286
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1286_34806_8923;
        }
    label_3358_12A1_34821_8942:
        CheckExternalEvents(cs2, 0x12A1);
        // 3358:12A1 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:12A3 jns short 0x1272
        if (!SignFlag)
        {
            goto label_3358_1272_347F2_8834;
        }
    label_3358_12A5_34825_8945:
        CheckExternalEvents(cs2, 0x12A5);
        // 3358:12A5 mov CX,BP
        CX = BP;
        // 3358:12A7 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:12A9 mov BP,word ptr CS:[0x10DC]
        BP = UInt16[CS, (ushort)0x10DC];
        // 3358:12AE xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_3358_12B0_34830_8950:
        CheckExternalEvents(cs2, 0x12B0);
        // 3358:12B0 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_12B1_34831_8952:
        CheckExternalEvents(cs2, 0x12B1);
        // 3358:12B1 jae short 0x132C
        if (!CarryFlag)
        {
            goto label_3358_132C_348AC_8878;
        }
    label_3358_12B3_34833_8954:
        CheckExternalEvents(cs2, 0x12B3);
        // 3358:12B3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:12B4 jmp short 0x131E
        goto label_3358_131E_3489E_8871;
    label_3358_12B7_34837_8928:
        CheckExternalEvents(cs2, 0x12B7);
        // 3358:12B7 inc DI
        DI = Alu16.Inc(DI);
        // 3358:12B8 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:12BA jne short 0x1292
        if (!ZeroFlag)
        {
            goto label_3358_1292_34812_8932;
        }
    label_3358_12BC_3483C_8983:
        CheckExternalEvents(cs2, 0x12BC);
        // 3358:12BC inc DI
        DI = Alu16.Inc(DI);
        // 3358:12BD loop 0x1286
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1286_34806_8923;
        }
    label_3358_12BF_3483F_8986:
        CheckExternalEvents(cs2, 0x12BF);
        // 3358:12BF jmp short 0x12A1
        goto label_3358_12A1_34821_8942;
    label_3358_12C1_34841_8840:
        CheckExternalEvents(cs2, 0x12C1);
        // 3358:12C1 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:12C4 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:12C6 inc SI
        SI = Alu16.Inc(SI);
    label_3358_12C7_34847_8844:
        CheckExternalEvents(cs2, 0x12C7);
        // 3358:12C7 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:12C9 jae short 0x12CF
        if (!CarryFlag)
        {
            goto label_3358_12CF_3484F_8849;
        }
    label_3358_12CB_3484B_8846:
        CheckExternalEvents(cs2, 0x12CB);
        // 3358:12CB add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:12CD je short 0x1306
        if (ZeroFlag)
        {
            goto label_3358_1306_34886_8857;
        }
    label_3358_12CF_3484F_8849:
        CheckExternalEvents(cs2, 0x12CF);
        // 3358:12CF mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:12D2 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:12D4 je short 0x12F2
        if (ZeroFlag)
        {
            goto label_3358_12F2_34872_8853;
        }
    label_3358_12D6_34856_8988:
        CheckExternalEvents(cs2, 0x12D6);
        // 3358:12D6 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:12D8 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:12DA shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:12DC shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:12DE je short 0x12F8
        if (ZeroFlag)
        {
            goto label_3358_12F8_34878_11635;
        }
    label_3358_12E0_34860_8994:
        CheckExternalEvents(cs2, 0x12E0);
        // 3358:12E0 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:12E2 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:12E4 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:12E6 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:12E8 or AH,AH
        AH = Alu8.Or(AH, AH);
        // 3358:12EA je short 0x1302
        if (ZeroFlag)
        {
            goto label_3358_1302_34882_10161;
        }
    label_3358_12EC_3486C_9001:
        CheckExternalEvents(cs2, 0x12EC);
        // 3358:12EC add AH,DH
        AH = Alu8.Add(AH, DH);
        // 3358:12EE rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:12F0 jmp short 0x1306
        goto label_3358_1306_34886_8857;
    label_3358_12F2_34872_8853:
        CheckExternalEvents(cs2, 0x12F2);
        // 3358:12F2 shl CX,1
        CX = Alu16.Shl(CX, 1);
        // 3358:12F4 add DI,CX
        DI = Alu16.Add(DI, CX);
        // 3358:12F6 jmp short 0x1306
        goto label_3358_1306_34886_8857;
    label_3358_12F8_34878_11635:
        CheckExternalEvents(cs2, 0x12F8);
        // 3358:12F8 mov AL,AH
        AL = AH;
        // 3358:12FA add AL,DH
        AL = Alu8.Add(AL, DH);
    label_3358_12FC_3487C_11638:
        CheckExternalEvents(cs2, 0x12FC);
        // 3358:12FC inc DI
        DI = Alu16.Inc(DI);
        // 3358:12FD stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:12FE loop 0x12FC
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_12FC_3487C_11638;
        }
    label_3358_1300_34880_11642:
        CheckExternalEvents(cs2, 0x1300);
        // 3358:1300 jmp short 0x1306
        goto label_3358_1306_34886_8857;
    label_3358_1302_34882_10161:
        CheckExternalEvents(cs2, 0x1302);
        // 3358:1302 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1303 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1304 loop 0x1302
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1302_34882_10161;
        }
    label_3358_1306_34886_8857:
        CheckExternalEvents(cs2, 0x1306);
        // 3358:1306 or BP,BP
        BP = Alu16.Or(BP, BP);
        // 3358:1308 js short 0x130D
        if (SignFlag)
        {
            goto label_3358_130D_3488D_8860;
        }
    label_3358_130A_3488A_8913:
        CheckExternalEvents(cs2, 0x130A);
        // 3358:130A jmp near 0x1272
        goto label_3358_1272_347F2_8834;
    label_3358_130D_3488D_8860:
        CheckExternalEvents(cs2, 0x130D);
        // 3358:130D xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:130F mov CX,BP
        CX = BP;
        // 3358:1311 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1313 mov BP,word ptr CS:[0x10DC]
        BP = UInt16[CS, (ushort)0x10DC];
    label_3358_1318_34898_8865:
        CheckExternalEvents(cs2, 0x1318);
        // 3358:1318 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_1319_34899_8867:
        CheckExternalEvents(cs2, 0x1319);
        // 3358:1319 jae short 0x132C
        if (!CarryFlag)
        {
            goto label_3358_132C_348AC_8878;
        }
    label_3358_131B_3489B_8869:
        CheckExternalEvents(cs2, 0x131B);
        // 3358:131B mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
    label_3358_131E_3489E_8871:
        CheckExternalEvents(cs2, 0x131E);
        // 3358:131E and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 3358:1320 je short 0x1327
        if (ZeroFlag)
        {
            goto label_3358_1327_348A7_8873;
        }
    label_3358_1322_348A2_8958:
        CheckExternalEvents(cs2, 0x1322);
        // 3358:1322 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:1324 mov byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
    label_3358_1327_348A7_8873:
        CheckExternalEvents(cs2, 0x1327);
        // 3358:1327 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1328 dec CX
        CX = Alu16.Dec(CX);
        // 3358:1329 dec BP
        BP = Alu16.Dec(BP);
        // 3358:132A je short 0x1362
        if (ZeroFlag)
        {
            goto label_3358_1362_348E2_8901;
        }
    label_3358_132C_348AC_8878:
        CheckExternalEvents(cs2, 0x132C);
        // 3358:132C shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:132E jcxz short 0x1338
        if (CX == (ushort)0x0000)
        {
            goto label_3358_1338_348B8_8887;
        }
    label_3358_1330_348B0_8881:
        CheckExternalEvents(cs2, 0x1330);
        // 3358:1330 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:1332 js short 0x1358
        if (SignFlag)
        {
            goto label_3358_1358_348D8_8884;
        }
    label_3358_1334_348B4_8961:
        CheckExternalEvents(cs2, 0x1334);
        // 3358:1334 jmp short 0x1344
        goto label_3358_1344_348C4_8963;
    label_3358_1336_348B6_8966:
        CheckExternalEvents(cs2, 0x1336);
        // 3358:1336 add SI,CX
        SI = Alu16.Add(SI, CX);
    label_3358_1338_348B8_8887:
        CheckExternalEvents(cs2, 0x1338);
        // 3358:1338 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1339 xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:133B mov DL,AL
        DL = AL;
        // 3358:133D or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:133F js short 0x1352
        if (SignFlag)
        {
            goto label_3358_1352_348D2_8893;
        }
    label_3358_1341_348C1_8972:
        CheckExternalEvents(cs2, 0x1341);
        // 3358:1341 mov CX,AX
        CX = AX;
        // 3358:1343 inc CX
        CX = Alu16.Inc(CX);
    label_3358_1344_348C4_8963:
        CheckExternalEvents(cs2, 0x1344);
        // 3358:1344 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:1346 jae short 0x1336
        if (!CarryFlag)
        {
            goto label_3358_1336_348B6_8966;
        }
    label_3358_1348_348C8_8975:
        CheckExternalEvents(cs2, 0x1348);
        // 3358:1348 add CX,BP
        CX = Alu16.Add(CX, BP);
        // 3358:134A add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:134C mov CX,BP
        CX = BP;
        // 3358:134E neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1350 jmp short 0x1362
        goto label_3358_1362_348E2_8901;
    label_3358_1352_348D2_8893:
        CheckExternalEvents(cs2, 0x1352);
        // 3358:1352 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:1355 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:1357 inc SI
        SI = Alu16.Inc(SI);
    label_3358_1358_348D8_8884:
        CheckExternalEvents(cs2, 0x1358);
        // 3358:1358 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:135A jae short 0x1338
        if (!CarryFlag)
        {
            goto label_3358_1338_348B8_8887;
        }
    label_3358_135C_348DC_8897:
        CheckExternalEvents(cs2, 0x135C);
        // 3358:135C xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:135E mov CX,BP
        CX = BP;
        // 3358:1360 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
    label_3358_1362_348E2_8901:
        CheckExternalEvents(cs2, 0x1362);
        // 3358:1362 sub DI,word ptr CS:[0x10E0]
        DI = Alu16.Sub(DI, UInt16[CS, (ushort)0x10E0]);
        // 3358:1367 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:136B dec BX
        BX = Alu16.Dec(BX);
        // 3358:136C je short 0x1371
        if (ZeroFlag)
        {
            goto label_3358_1371_348F1_9005;
        }
    label_3358_136E_348EE_8905:
        CheckExternalEvents(cs2, 0x136E);
        // 3358:136E jmp near 0x11EE
        goto label_3358_11EE_3476E_8823;
    label_3358_1371_348F1_9005:
        CheckExternalEvents(cs2, 0x1371);
        // 3358:1371 ret far
        return FarRet((ushort)0x0000);
    label_3358_1372_348F2_8208:
        CheckExternalEvents(cs2, 0x1372);
        // 3358:1372 mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:1375 mov byte ptr CS:[0x019E],AL
        UInt8[CS, (ushort)0x019E] = AL;
        // 3358:1379 and DI,0x1FFF
        DI = Alu16.And(DI, (ushort)0x1FFF);
        // 3358:137D mov word ptr CS:[0x158B],DI
        UInt16[CS, (ushort)0x158B] = DI;
        // 3358:1382 add DI,3
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:1385 shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:1387 shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:1389 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 3358:138B mov AX,word ptr SS:[BP+2]
        AX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:138E sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:1390 jle short 0x13BE
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_13BE_3493E_8220;
        }
    label_3358_1392_34912_9163:
        CheckExternalEvents(cs2, 0x1392);
        // 3358:1392 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:1394 jbe short 0x13F1
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_13F1_34971_9156;
        }
    label_3358_1396_34916_9166:
        CheckExternalEvents(cs2, 0x1396);
        // 3358:1396 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 3358:1398 push DX
        Stack.Push16(DX);
        // 3358:1399 push CX
        Stack.Push16(CX);
        // 3358:139A push BP
        Stack.Push16(BP);
        // 3358:139B mul DI
        uint result_3358_139B_3491B = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DI)));
        DX = unchecked((ushort)(result_3358_139B_3491B >> 16));
        AX = unchecked((ushort)result_3358_139B_3491B);
        // 3358:139D mov BP,AX
        BP = AX;
        // 3358:139F xor AH,AH
        AH = Alu8.Xor(AH, AH);
    label_3358_13A1_34921_9174:
        CheckExternalEvents(cs2, 0x13A1);
        // 3358:13A1 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:13A2 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:13A4 js short 0x13B1
        if (SignFlag)
        {
            goto label_3358_13B1_34931_9177;
        }
    label_3358_13A6_34926_9184:
        CheckExternalEvents(cs2, 0x13A6);
        // 3358:13A6 mov CX,AX
        CX = AX;
        // 3358:13A8 inc CX
        CX = Alu16.Inc(CX);
        // 3358:13A9 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:13AB sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:13AD jne short 0x13A1
        if (!ZeroFlag)
        {
            goto label_3358_13A1_34921_9174;
        }
    label_3358_13AF_3492F_9190:
        CheckExternalEvents(cs2, 0x13AF);
        // 3358:13AF jmp short 0x13BB
        goto label_3358_13BB_3493B_9192;
    label_3358_13B1_34931_9177:
        CheckExternalEvents(cs2, 0x13B1);
        // 3358:13B1 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:13B4 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:13B6 inc SI
        SI = Alu16.Inc(SI);
        // 3358:13B7 sub BP,CX
        BP = Alu16.Sub(BP, CX);
        // 3358:13B9 jne short 0x13A1
        if (!ZeroFlag)
        {
            goto label_3358_13A1_34921_9174;
        }
    label_3358_13BB_3493B_9192:
        CheckExternalEvents(cs2, 0x13BB);
        // 3358:13BB pop BP
        BP = Stack.Pop16();
        // 3358:13BC pop CX
        CX = Stack.Pop16();
        // 3358:13BD pop DX
        DX = Stack.Pop16();
    label_3358_13BE_3493E_8220:
        CheckExternalEvents(cs2, 0x13BE);
        // 3358:13BE mov AX,BX
        AX = BX;
        // 3358:13C0 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:13C2 sub AX,word ptr SS:[BP+6]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)6)]);
        // 3358:13C5 jbe short 0x13CB
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_13CB_3494B_8225;
        }
    label_3358_13C7_34947_9153:
        CheckExternalEvents(cs2, 0x13C7);
        // 3358:13C7 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:13C9 jbe short 0x13F1
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_13F1_34971_9156;
        }
    label_3358_13CB_3494B_8225:
        CheckExternalEvents(cs2, 0x13CB);
        // 3358:13CB mov AX,DX
        AX = DX;
        // 3358:13CD add AX,DI
        AX = Alu16.Add(AX, DI);
        // 3358:13CF add AX,DI
        AX = Alu16.Add(AX, DI);
        // 3358:13D1 sub AX,word ptr SS:[BP+4]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)4)]);
        // 3358:13D4 jg short 0x1419
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_1419_34999_8805;
        }
    label_3358_13D6_34956_8231:
        CheckExternalEvents(cs2, 0x13D6);
        // 3358:13D6 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:13D9 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:13DB jg short 0x13F2
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_13F2_34972_9364;
        }
    label_3358_13DD_3495D_8235:
        CheckExternalEvents(cs2, 0x13DD);
        // 3358:13DD mov word ptr CS:[0x0C3C],DI
        UInt16[CS, (ushort)0x0C3C] = DI;
        // 3358:13E2 mov BP,DI
        BP = DI;
        // 3358:13E4 call near 0x0C10
        NearCall(cs2, 0x13E7, unknown_3358_0C10_34190);
    label_3358_13E7_34967_8239:
        CheckExternalEvents(cs2, 0x13E7);
        // 3358:13E7 mov BX,CX
        BX = CX;
        // 3358:13E9 mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:13EE jmp near 0x0C46
        return unknown_3358_0C46_341C6(0x0000);
    label_3358_13F1_34971_9156:
        CheckExternalEvents(cs2, 0x13F1);
        // 3358:13F1 ret far
        return FarRet((ushort)0x0000);
    label_3358_13F2_34972_9364:
        CheckExternalEvents(cs2, 0x13F2);
        // 3358:13F2 cmp AX,word ptr CS:[0x158B]
        Alu16.Sub(AX, UInt16[CS, (ushort)0x158B]);
        // 3358:13F7 jae short 0x13F1
        if (!CarryFlag)
        {
            goto label_3358_13F1_34971_9156;
        }
    label_3358_13F9_34979_9367:
        CheckExternalEvents(cs2, 0x13F9);
        // 3358:13F9 mov BP,DI
        BP = DI;
        // 3358:13FB shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 3358:13FD sub BP,AX
        BP = Alu16.Sub(BP, AX);
        // 3358:13FF mov word ptr CS:[0x10E0],BP
        UInt16[CS, (ushort)0x10E0] = BP;
        // 3358:1404 mov word ptr CS:[0x10DE],AX
        UInt16[CS, (ushort)0x10DE] = AX;
        // 3358:1408 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:140A call near 0x0C10
        NearCall(cs2, 0x140D, unknown_3358_0C10_34190);
    label_3358_140D_3498D_9375:
        CheckExternalEvents(cs2, 0x140D);
        // 3358:140D mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:1412 mov BX,CX
        BX = CX;
        // 3358:1414 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 3358:1416 jmp near 0x10E2
        goto label_3358_10E2_34662_9380;
    label_3358_1419_34999_8805:
        CheckExternalEvents(cs2, 0x1419);
        // 3358:1419 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 3358:141B sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:141D jle short 0x13F1
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_13F1_34971_9156;
        }
    label_3358_141F_3499F_8809:
        CheckExternalEvents(cs2, 0x141F);
        // 3358:141F mov word ptr CS:[0x10DC],AX
        UInt16[CS, (ushort)0x10DC] = AX;
        // 3358:1423 mov word ptr CS:[0x10DE],0
        UInt16[CS, (ushort)0x10DE] = (ushort)0x0000;
        // 3358:142A mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:142D sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:142F jle short 0x143B
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_143B_349BB_8815;
        }
    label_3358_1431_349B1_9196:
        CheckExternalEvents(cs2, 0x1431);
        // 3358:1431 mov word ptr CS:[0x10DE],AX
        UInt16[CS, (ushort)0x10DE] = AX;
        // 3358:1435 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:1437 jle short 0x13F1
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_13F1_34971_9156;
        }
    label_3358_1439_349B9_9200:
        CheckExternalEvents(cs2, 0x1439);
        // 3358:1439 add DX,AX
        DX = Alu16.Add(DX, AX);
    label_3358_143B_349BB_8815:
        CheckExternalEvents(cs2, 0x143B);
        // 3358:143B mov word ptr CS:[0x10E0],DI
        UInt16[CS, (ushort)0x10E0] = DI;
        // 3358:1440 call near 0x0C10
        NearCall(cs2, 0x1443, unknown_3358_0C10_34190);
    label_3358_1443_349C3_8818:
        CheckExternalEvents(cs2, 0x1443);
        // 3358:1443 mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:1448 mov BX,CX
        BX = CX;
        // 3358:144A xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 3358:144C jmp near 0x11EE
        goto label_3358_11EE_3476E_8823;
    label_3358_144F_349CF_31510:
        CheckExternalEvents(cs2, 0x144F);
        // 3358:144F jmp near 0x17E8
        goto label_3358_17E8_34D68_31512;
    label_3358_1452_349D2_8160:
        CheckExternalEvents(cs2, 0x1452);
        // 3358:1452 cmp CH,0xFE
        Alu8.Sub(CH, (byte)0xFE);
        // 3358:1455 jae short 0x144F
        if (!CarryFlag)
        {
            goto label_3358_144F_349CF_31510;
        }
    label_3358_1457_349D7_8163:
        CheckExternalEvents(cs2, 0x1457);
        // 3358:1457 or DI,DI
        DI = Alu16.Or(DI, DI);
        // 3358:1459 jns short 0x145E
        if (!SignFlag)
        {
            goto label_3358_145E_349DE_8166;
        }
    label_3358_145B_349DB_8206:
        CheckExternalEvents(cs2, 0x145B);
        // 3358:145B jmp near 0x1372
        goto label_3358_1372_348F2_8208;
    label_3358_145E_349DE_8166:
        CheckExternalEvents(cs2, 0x145E);
        // 3358:145E mov AL,byte ptr DS:[SI-1]
        AL = UInt8[DS, (ushort)(SI + (sbyte)-1)];
        // 3358:1461 mov byte ptr CS:[0x019E],AL
        UInt8[CS, (ushort)0x019E] = AL;
        // 3358:1465 mov word ptr CS:[0x158B],DI
        UInt16[CS, (ushort)0x158B] = DI;
        // 3358:146A add DI,3
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:146D shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:146F shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:1471 shl DI,1
        DI = Alu16.Shl(DI, 1);
        // 3358:1473 mov AX,word ptr SS:[BP+2]
        AX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1476 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:1478 jle short 0x1485
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_1485_34A05_8177;
        }
    label_3358_147A_349FA_12863:
        CheckExternalEvents(cs2, 0x147A);
        // 3358:147A sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:147C jbe short 0x14B8
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_14B8_34A38_9161;
        }
    label_3358_147E_349FE_26042:
        CheckExternalEvents(cs2, 0x147E);
        // 3358:147E add BX,AX
        BX = Alu16.Add(BX, AX);
    label_3358_1480_34A00_26044:
        CheckExternalEvents(cs2, 0x1480);
        // 3358:1480 add SI,DI
        SI = Alu16.Add(SI, DI);
        // 3358:1482 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1483 jne short 0x1480
        if (!ZeroFlag)
        {
            goto label_3358_1480_34A00_26044;
        }
    label_3358_1485_34A05_8177:
        CheckExternalEvents(cs2, 0x1485);
        // 3358:1485 mov AX,BX
        AX = BX;
        // 3358:1487 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:1489 sub AX,word ptr SS:[BP+6]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)6)]);
        // 3358:148C jbe short 0x1492
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1492_34A12_8182;
        }
    label_3358_148E_34A0E_9158:
        CheckExternalEvents(cs2, 0x148E);
        // 3358:148E sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:1490 jbe short 0x14B8
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_14B8_34A38_9161;
        }
    label_3358_1492_34A12_8182:
        CheckExternalEvents(cs2, 0x1492);
        // 3358:1492 mov AX,DX
        AX = DX;
        // 3358:1494 add AX,word ptr CS:[0x158B]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x158B]);
        // 3358:1499 sub AX,word ptr SS:[BP+4]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)4)]);
        // 3358:149C jg short 0x14FD
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_14FD_34A7D_10008;
        }
    label_3358_149E_34A1E_8187:
        CheckExternalEvents(cs2, 0x149E);
        // 3358:149E mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:14A1 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:14A3 jg short 0x14B9
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_14B9_34A39_10005;
        }
    label_3358_14A5_34A25_8191:
        CheckExternalEvents(cs2, 0x14A5);
        // 3358:14A5 mov AX,DI
        AX = DI;
        // 3358:14A7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:14A9 mov word ptr CS:[0x158B],AX
        UInt16[CS, (ushort)0x158B] = AX;
        // 3358:14AD call near 0x0C10
        NearCall(cs2, 0x14B0, unknown_3358_0C10_34190);
    label_3358_14B0_34A30_8196:
        CheckExternalEvents(cs2, 0x14B0);
        // 3358:14B0 mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:14B5 jmp near 0x158A
        return unknown_3358_158A_34B0A(0x0000);
    label_3358_14B8_34A38_9161:
        CheckExternalEvents(cs2, 0x14B8);
        // 3358:14B8 ret far
        return FarRet((ushort)0x0000);
    label_3358_14B9_34A39_10005:
        CheckExternalEvents(cs2, 0x14B9);
        // 3358:14B9 sub word ptr CS:[0x158B],AX
        UInt16[CS, (ushort)0x158B] = Alu16.Sub(UInt16[CS, (ushort)0x158B], AX);
        // 3358:14BE jle short 0x14B8
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_14B8_34A38_9161;
        }
    label_3358_14C0_34A40_27281:
        CheckExternalEvents(cs2, 0x14C0);
        // 3358:14C0 push SI
        Stack.Push16(SI);
        // 3358:14C1 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:14C3 mov SI,AX
        SI = AX;
        // 3358:14C5 and SI,3
        SI = Alu16.And(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:14C8 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 3358:14CA mov SI,word ptr CS:[SI+0x14F5]
        SI = UInt16[CS, (ushort)(SI + (short)5365)];
        // 3358:14CF shr DI,1
        DI = Alu16.Shr(DI, 1);
        // 3358:14D1 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:14D3 mov byte ptr CS:[SI+2],AL
        UInt8[CS, (ushort)(SI + (sbyte)2)] = AL;
        // 3358:14D7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:14D9 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:14DB mov word ptr CS:[SI+4],DI
        UInt16[CS, (ushort)(SI + (sbyte)4)] = DI;
        // 3358:14DF call near 0x0C10
        NearCall(cs2, 0x14E2, unknown_3358_0C10_34190);
    label_3358_14E2_34A62_27295:
        CheckExternalEvents(cs2, 0x14E2);
        // 3358:14E2 mov BP,SI
        BP = SI;
        // 3358:14E4 pop SI
        SI = Stack.Pop16();
        // 3358:14E5 mov AX,BP
        AX = BP;
        // 3358:14E7 sub AX,0x163D
        AX = Alu16.Sub(AX, (ushort)0x163D);
        // 3358:14EA mov byte ptr CS:[0x163C],AL
        UInt8[CS, (ushort)0x163C] = AL;
        // 3358:14EE mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:14F3 jmp near BP
        switch ((ushort)(BP))
        {
            case 0x15FB:
                goto label_3358_15FB_34B7B_33797;
            case 0x166E:
                goto label_3358_166E_34BEE_33431;
            case 0x1684:
                goto label_3358_1684_34C04_33641;
            case 0x1690:
                goto label_3358_1690_34C10_33430;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(BP)):X4} at 3358:14F3");
        }
    label_3358_14FD_34A7D_10008:
        CheckExternalEvents(cs2, 0x14FD);
        // 3358:14FD sub word ptr CS:[0x158B],AX
        UInt16[CS, (ushort)0x158B] = Alu16.Sub(UInt16[CS, (ushort)0x158B], AX);
        // 3358:1502 jle short 0x14B8
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_14B8_34A38_9161;
        }
    label_3358_1504_34A84_26048:
        CheckExternalEvents(cs2, 0x1504);
        // 3358:1504 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1507 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:1509 jg short 0x152D
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_152D_34AAD_26052;
        }
    label_3358_150B_34A8B_30431:
        CheckExternalEvents(cs2, 0x150B);
        // 3358:150B mov AX,word ptr CS:[0x158B]
        AX = UInt16[CS, (ushort)0x158B];
        // 3358:150F mov word ptr CS:[0x16AB],AX
        UInt16[CS, (ushort)0x16AB] = AX;
        // 3358:1513 add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 3358:1516 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:1518 and AL,0xFE
        AL = Alu8.And(AL, (byte)0xFE);
        // 3358:151A sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:151C mov AX,DI
        AX = DI;
        // 3358:151E mov byte ptr CS:[0x16A9],AL
        UInt8[CS, (ushort)0x16A9] = AL;
        // 3358:1522 call near 0x0C10
        NearCall(cs2, 0x1525, unknown_3358_0C10_34190);
    label_3358_1525_34AA5_30441:
        CheckExternalEvents(cs2, 0x1525);
        // 3358:1525 mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:152A jmp near 0x16AA
        goto label_3358_16AA_34C2A_32015;
    label_3358_152D_34AAD_26052:
        CheckExternalEvents(cs2, 0x152D);
        // 3358:152D sub word ptr CS:[0x158B],AX
        UInt16[CS, (ushort)0x158B] = Alu16.Sub(UInt16[CS, (ushort)0x158B], AX);
        // 3358:1532 jle short 0x14B8
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_14B8_34A38_9161;
        }
    label_3358_1534_34AB4_26055:
        CheckExternalEvents(cs2, 0x1534);
        // 3358:1534 push CX
        Stack.Push16(CX);
        // 3358:1535 mov CX,AX
        CX = AX;
        // 3358:1537 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:1539 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:153B push SI
        Stack.Push16(SI);
        // 3358:153C add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:153E mov SI,AX
        SI = AX;
        // 3358:1540 and SI,3
        SI = Alu16.And(SI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:1543 shl SI,1
        SI = Alu16.Shl(SI, 1);
        // 3358:1545 mov SI,word ptr CS:[SI+0x1582]
        SI = UInt16[CS, (ushort)(SI + (short)5506)];
        // 3358:154A add AX,word ptr CS:[0x158B]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x158B]);
        // 3358:154F add AX,3
        AX = Alu16.Add(AX, (ushort)0x0003);
        // 3358:1552 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:1554 and AL,0xFE
        AL = Alu8.And(AL, (byte)0xFE);
        // 3358:1556 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:1558 mov AX,DI
        AX = DI;
        // 3358:155A add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:155C mov byte ptr CS:[SI+2],AL
        UInt8[CS, (ushort)(SI + (sbyte)2)] = AL;
        // 3358:1560 mov AX,word ptr CS:[0x158B]
        AX = UInt16[CS, (ushort)0x158B];
        // 3358:1564 mov word ptr CS:[SI+4],AX
        UInt16[CS, (ushort)(SI + (sbyte)4)] = AX;
        // 3358:1568 call near 0x0C10
        NearCall(cs2, 0x156B, unknown_3358_0C10_34190);
    label_3358_156B_34AEB_26077:
        CheckExternalEvents(cs2, 0x156B);
        // 3358:156B mov BP,SI
        BP = SI;
        // 3358:156D pop SI
        SI = Stack.Pop16();
        // 3358:156E pop CX
        CX = Stack.Pop16();
        // 3358:156F mov AX,BP
        AX = BP;
        // 3358:1571 sub AX,0x1779
        AX = Alu16.Sub(AX, (ushort)0x1779);
        // 3358:1574 mov byte ptr CS:[0x1778],AL
        UInt8[CS, (ushort)0x1778] = AL;
        // 3358:1578 mov DX,word ptr CS:[0x019D]
        DX = UInt16[CS, (ushort)0x019D];
        // 3358:157D add BP,3
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:1580 jmp near BP
        switch ((ushort)(BP))
        {
            case 0x172B:
                goto label_3358_172B_34CAB_38133;
            case 0x17AC:
                goto label_3358_17AC_34D2C_37937;
            case 0x17C4:
                goto label_3358_17C4_34D44_38131;
            case 0x17D2:
                goto label_3358_17D2_34D52_26180;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(BP)):X4} at 3358:1580");
        }
    label_3358_15FB_34B7B_33797:
        CheckExternalEvents(cs2, 0x15FB);
        // 3358:15FB add SI,(short)byte ptr [0x00034B7D]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034B7Du))])));
        // 3358:15FE mov BP,word ptr [0x00034B7F]
        BP = UInt16[unchecked((uint)(0x00034B7Fu))];
        // 3358:1601 push DI
        Stack.Push16(DI);
    label_3358_1602_34B82_27336:
        CheckExternalEvents(cs2, 0x1602);
        // 3358:1602 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1603 mov BL,AL
        BL = AL;
        // 3358:1605 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:1607 je short 0x163E
        if (ZeroFlag)
        {
            goto label_3358_163E_34BBE_27378;
        }
    label_3358_1609_34B89_27341:
        CheckExternalEvents(cs2, 0x1609);
        // 3358:1609 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:160B stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:160C shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:160E shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1610 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1612 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1614 je short 0x164D
        if (ZeroFlag)
        {
            goto label_3358_164D_34BCD_27373;
        }
    label_3358_1616_34B96_27349:
        CheckExternalEvents(cs2, 0x1616);
        // 3358:1616 mov AL,BL
        AL = BL;
    label_3358_1618_34B98_27316:
        CheckExternalEvents(cs2, 0x1618);
        // 3358:1618 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:161A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:161B mov AL,AH
        AL = AH;
    label_3358_161D_34B9D_27320:
        CheckExternalEvents(cs2, 0x161D);
        // 3358:161D and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:161F je short 0x1661
        if (ZeroFlag)
        {
            goto label_3358_1661_34BE1_27366;
        }
    label_3358_1621_34BA1_27322:
        CheckExternalEvents(cs2, 0x1621);
        // 3358:1621 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:1623 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1624 shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_1626_34BA6_27326:
        CheckExternalEvents(cs2, 0x1626);
        // 3358:1626 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1628 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:162A shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:162C je short 0x1668
        if (ZeroFlag)
        {
            goto label_3358_1668_34BE8_27355;
        }
    label_3358_162E_34BAE_27330:
        CheckExternalEvents(cs2, 0x162E);
        // 3358:162E mov AL,AH
        AL = AH;
    label_3358_1630_34BB0_27332:
        CheckExternalEvents(cs2, 0x1630);
        // 3358:1630 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:1632 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1633 dec BP
        BP = Alu16.Dec(BP);
        // 3358:1634 jne short 0x1602
        if (!ZeroFlag)
        {
            goto label_3358_1602_34B82_27336;
        }
    label_3358_1636_34BB6_27351:
        CheckExternalEvents(cs2, 0x1636);
        // 3358:1636 pop DI
        DI = Stack.Pop16();
        // 3358:1637 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        goto label_3358_163B_34BBB_27400;
    label_3358_163B_34BBB_27354:
        CheckExternalEvents(cs2, 0x163B);
        // 3358:163B loop 0x1690
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1690_34C10_33430;
        }
        else
        {
            goto label_3358_163D_34BBD_27387;
        }
    label_3358_163B_34BBB_27400:
        CheckExternalEvents(cs2, 0x163B);
        // 3358:163B selector
        if (SelectorSignatureMatches(cs2, 0x163B, [(byte)0xE2, (byte)0x31]))
        {
            goto label_3358_163B_34BBB_30945;
        }
        if (SelectorSignatureMatches(cs2, 0x163B, [(byte)0xE2, (byte)0x47]))
        {
            goto label_3358_163B_34BBB_31385;
        }
        if (SelectorSignatureMatches(cs2, 0x163B, [(byte)0xE2, (byte)0x53]))
        {
            goto label_3358_163B_34BBB_27354;
        }
        if (SelectorSignatureMatches(cs2, 0x163B, [(byte)0xE2, (byte)0xBE]))
        {
            goto label_3358_163B_34BBB_27399;
        }
        throw FailAsUntested("No selector signature matched at 3358:163B");
    label_3358_163B_34BBB_27399:
        CheckExternalEvents(cs2, 0x163B);
        // 3358:163B loop 0x15FB
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_15FB_34B7B_33797;
        }
        else
        {
            goto label_3358_163D_34BBD_27387;
        }
    label_3358_163B_34BBB_30945:
        CheckExternalEvents(cs2, 0x163B);
        // 3358:163B loop 0x166E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_166E_34BEE_33431;
        }
        else
        {
            goto label_3358_163D_34BBD_27387;
        }
    label_3358_163B_34BBB_31385:
        CheckExternalEvents(cs2, 0x163B);
        // 3358:163B loop 0x1684
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1684_34C04_33641;
        }
    label_3358_163D_34BBD_27387:
        CheckExternalEvents(cs2, 0x163D);
        // 3358:163D ret far
        return FarRet((ushort)0x0000);
    label_3358_163E_34BBE_27378:
        CheckExternalEvents(cs2, 0x163E);
        // 3358:163E inc DI
        DI = Alu16.Inc(DI);
        // 3358:163F or AL,BL
        AL = Alu8.Or(AL, BL);
        // 3358:1641 je short 0x164D
        if (ZeroFlag)
        {
            goto label_3358_164D_34BCD_27373;
        }
    label_3358_1643_34BC3_27389:
        CheckExternalEvents(cs2, 0x1643);
        // 3358:1643 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1645 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1647 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1649 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:164B jmp short 0x1618
        goto label_3358_1618_34B98_27316;
    label_3358_164D_34BCD_27373:
        CheckExternalEvents(cs2, 0x164D);
        // 3358:164D inc DI
        DI = Alu16.Inc(DI);
        // 3358:164E mov AL,AH
        AL = AH;
        // 3358:1650 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1652 jne short 0x161D
        if (!ZeroFlag)
        {
            goto label_3358_161D_34B9D_27320;
        }
    label_3358_1654_34BD4_27369:
        CheckExternalEvents(cs2, 0x1654);
        // 3358:1654 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:1657 dec BP
        BP = Alu16.Dec(BP);
        // 3358:1658 jne short 0x1602
        if (!ZeroFlag)
        {
            goto label_3358_1602_34B82_27336;
        }
    label_3358_165A_34BDA_27361:
        CheckExternalEvents(cs2, 0x165A);
        // 3358:165A pop DI
        DI = Stack.Pop16();
        // 3358:165B add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:165F jmp short 0x163B
        goto label_3358_163B_34BBB_27400;
    label_3358_1661_34BE1_27366:
        CheckExternalEvents(cs2, 0x1661);
        // 3358:1661 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1663 je short 0x1654
        if (ZeroFlag)
        {
            goto label_3358_1654_34BD4_27369;
        }
    label_3358_1665_34BE5_27383:
        CheckExternalEvents(cs2, 0x1665);
        // 3358:1665 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1666 jmp short 0x1626
        goto label_3358_1626_34BA6_27326;
    label_3358_1668_34BE8_27355:
        CheckExternalEvents(cs2, 0x1668);
        // 3358:1668 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1669 dec BP
        BP = Alu16.Dec(BP);
        // 3358:166A jne short 0x1602
        if (!ZeroFlag)
        {
            goto label_3358_1602_34B82_27336;
        }
    label_3358_166C_34BEC_27359:
        CheckExternalEvents(cs2, 0x166C);
        // 3358:166C jmp short 0x165A
        goto label_3358_165A_34BDA_27361;
    label_3358_166E_34BEE_33431:
        CheckExternalEvents(cs2, 0x166E);
        // 3358:166E add SI,(short)byte ptr [0x00034BF0]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034BF0u))])));
        // 3358:1671 mov BP,word ptr [0x00034BF2]
        BP = UInt16[unchecked((uint)(0x00034BF2u))];
        // 3358:1674 push DI
        Stack.Push16(DI);
        // 3358:1675 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1676 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 3358:1678 jbe short 0x1668
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1668_34BE8_27355;
        }
    label_3358_167A_34BFA_30947:
        CheckExternalEvents(cs2, 0x167A);
        // 3358:167A shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:167C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:167E shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1680 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1682 jmp short 0x1630
        goto label_3358_1630_34BB0_27332;
    label_3358_1684_34C04_33641:
        CheckExternalEvents(cs2, 0x1684);
        // 3358:1684 add SI,(short)byte ptr [0x00034C06]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034C06u))])));
        // 3358:1687 mov BP,word ptr [0x00034C08]
        BP = UInt16[unchecked((uint)(0x00034C08u))];
        // 3358:168A push DI
        Stack.Push16(DI);
        // 3358:168B lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:168C mov AH,AL
        AH = AL;
        // 3358:168E jmp short 0x161D
        goto label_3358_161D_34B9D_27320;
    label_3358_1690_34C10_33430:
        CheckExternalEvents(cs2, 0x1690);
        // 3358:1690 add SI,(short)byte ptr [0x00034C12]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034C12u))])));
        // 3358:1693 mov BP,word ptr [0x00034C14]
        BP = UInt16[unchecked((uint)(0x00034C14u))];
        // 3358:1696 push DI
        Stack.Push16(DI);
        // 3358:1697 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1698 and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 3358:169A je short 0x164D
        if (ZeroFlag)
        {
            goto label_3358_164D_34BCD_27373;
        }
    label_3358_169C_34C1C_27310:
        CheckExternalEvents(cs2, 0x169C);
        // 3358:169C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:169E shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:16A0 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:16A2 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:16A4 jmp near 0x1618
        goto label_3358_1618_34B98_27316;
    label_3358_16A7_34C27_33144:
        CheckExternalEvents(cs2, 0x16A7);
        // 3358:16A7 add SI,(short)byte ptr [0x00034C29]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034C29u))])));
    label_3358_16AA_34C2A_32015:
        CheckExternalEvents(cs2, 0x16AA);
        // 3358:16AA mov BP,word ptr [0x00034C2B]
        BP = UInt16[unchecked((uint)(0x00034C2Bu))];
        // 3358:16AD push DI
        Stack.Push16(DI);
        // 3358:16AE add BP,DI
        BP = Alu16.Add(BP, DI);
    label_3358_16B0_34C30_30448:
        CheckExternalEvents(cs2, 0x16B0);
        // 3358:16B0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:16B1 mov BL,AL
        BL = AL;
        // 3358:16B3 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:16B5 je short 0x16F9
        if (ZeroFlag)
        {
            goto label_3358_16F9_34C79_30452;
        }
    label_3358_16B7_34C37_30504:
        CheckExternalEvents(cs2, 0x16B7);
        // 3358:16B7 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:16B9 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:16BA cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:16BC jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_16BE_34C3E_30509:
        CheckExternalEvents(cs2, 0x16BE);
        // 3358:16BE shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:16C0 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:16C2 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:16C4 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:16C6 je short 0x170C
        if (ZeroFlag)
        {
            goto label_3358_170C_34C8C_30459;
        }
    label_3358_16C8_34C48_30515:
        CheckExternalEvents(cs2, 0x16C8);
        // 3358:16C8 mov AL,BL
        AL = BL;
    label_3358_16CA_34C4A_30480:
        CheckExternalEvents(cs2, 0x16CA);
        // 3358:16CA add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:16CC stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:16CD cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:16CF jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_16D1_34C51_30485:
        CheckExternalEvents(cs2, 0x16D1);
        // 3358:16D1 mov AL,AH
        AL = AH;
    label_3358_16D3_34C53_30487:
        CheckExternalEvents(cs2, 0x16D3);
        // 3358:16D3 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:16D5 je short 0x171C
        if (ZeroFlag)
        {
            goto label_3358_171C_34C9C_30524;
        }
    label_3358_16D7_34C57_30489:
        CheckExternalEvents(cs2, 0x16D7);
        // 3358:16D7 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:16D9 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:16DA cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:16DC jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_16DE_34C5E_30494:
        CheckExternalEvents(cs2, 0x16DE);
        // 3358:16DE shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_16E0_34C60_30496:
        CheckExternalEvents(cs2, 0x16E0);
        // 3358:16E0 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:16E2 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:16E4 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:16E6 je short 0x1725
        if (ZeroFlag)
        {
            goto label_3358_1725_34CA5_30532;
        }
    label_3358_16E8_34C68_30500:
        CheckExternalEvents(cs2, 0x16E8);
        // 3358:16E8 mov AL,AH
        AL = AH;
        // 3358:16EA add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:16EC stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_3358_16ED_34C6D_30470:
        CheckExternalEvents(cs2, 0x16ED);
        // 3358:16ED cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:16EF jb short 0x16B0
        if (CarryFlag)
        {
            goto label_3358_16B0_34C30_30448;
        }
    label_3358_16F1_34C71_30517:
        CheckExternalEvents(cs2, 0x16F1);
        // 3358:16F1 pop DI
        DI = Stack.Pop16();
        // 3358:16F2 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:16F6 loop 0x16A7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_16A7_34C27_33144;
        }
    label_3358_16F8_34C78_30535:
        CheckExternalEvents(cs2, 0x16F8);
        // 3358:16F8 ret far
        return FarRet((ushort)0x0000);
    label_3358_16F9_34C79_30452:
        CheckExternalEvents(cs2, 0x16F9);
        // 3358:16F9 inc DI
        DI = Alu16.Inc(DI);
        // 3358:16FA cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:16FC jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_16FE_34C7E_30456:
        CheckExternalEvents(cs2, 0x16FE);
        // 3358:16FE or AL,BL
        AL = Alu8.Or(AL, BL);
        // 3358:1700 je short 0x170C
        if (ZeroFlag)
        {
            goto label_3358_170C_34C8C_30459;
        }
    label_3358_1702_34C82_30474:
        CheckExternalEvents(cs2, 0x1702);
        // 3358:1702 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1704 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1706 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1708 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:170A jmp short 0x16CA
        goto label_3358_16CA_34C4A_30480;
    label_3358_170C_34C8C_30459:
        CheckExternalEvents(cs2, 0x170C);
        // 3358:170C inc DI
        DI = Alu16.Inc(DI);
        // 3358:170D cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:170F jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_1711_34C91_30463:
        CheckExternalEvents(cs2, 0x1711);
        // 3358:1711 mov AL,AH
        AL = AH;
        // 3358:1713 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1715 jne short 0x16D3
        if (!ZeroFlag)
        {
            goto label_3358_16D3_34C53_30487;
        }
    label_3358_1717_34C97_30467:
        CheckExternalEvents(cs2, 0x1717);
        // 3358:1717 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:171A jmp short 0x16ED
        goto label_3358_16ED_34C6D_30470;
    label_3358_171C_34C9C_30524:
        CheckExternalEvents(cs2, 0x171C);
        // 3358:171C inc DI
        DI = Alu16.Inc(DI);
        // 3358:171D cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:171F jae short 0x16F1
        if (!CarryFlag)
        {
            goto label_3358_16F1_34C71_30517;
        }
    label_3358_1721_34CA1_30528:
        CheckExternalEvents(cs2, 0x1721);
        // 3358:1721 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1723 jne short 0x16E0
        if (!ZeroFlag)
        {
            goto label_3358_16E0_34C60_30496;
        }
    label_3358_1725_34CA5_30532:
        CheckExternalEvents(cs2, 0x1725);
        // 3358:1725 inc DI
        DI = Alu16.Inc(DI);
        // 3358:1726 jmp short 0x16ED
        goto label_3358_16ED_34C6D_30470;
    label_3358_1728_34CA8_38135:
        CheckExternalEvents(cs2, 0x1728);
        // 3358:1728 add SI,(short)byte ptr [0x00034CAA]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034CAAu))])));
    label_3358_172B_34CAB_38133:
        CheckExternalEvents(cs2, 0x172B);
        // 3358:172B mov BP,word ptr [0x00034CAC]
        BP = UInt16[unchecked((uint)(0x00034CACu))];
        // 3358:172E push DI
        Stack.Push16(DI);
        // 3358:172F add BP,DI
        BP = Alu16.Add(BP, DI);
    label_3358_1731_34CB1_26126:
        CheckExternalEvents(cs2, 0x1731);
        // 3358:1731 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:1732 mov BL,AL
        BL = AL;
        // 3358:1734 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:1736 je short 0x177A
        if (ZeroFlag)
        {
            goto label_3358_177A_34CFA_26150;
        }
    label_3358_1738_34CB8_26131:
        CheckExternalEvents(cs2, 0x1738);
        // 3358:1738 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:173A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:173B cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:173D jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_173F_34CBF_26136:
        CheckExternalEvents(cs2, 0x173F);
        // 3358:173F shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1741 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1743 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1745 shr BL,1
        BL = Alu8.Shr(BL, 1);
        // 3358:1747 je short 0x178D
        if (ZeroFlag)
        {
            goto label_3358_178D_34D0D_26157;
        }
    label_3358_1749_34CC9_26142:
        CheckExternalEvents(cs2, 0x1749);
        // 3358:1749 mov AL,BL
        AL = BL;
    label_3358_174B_34CCB_26100:
        CheckExternalEvents(cs2, 0x174B);
        // 3358:174B add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:174D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:174E cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:1750 jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_1752_34CD2_26105:
        CheckExternalEvents(cs2, 0x1752);
        // 3358:1752 mov AL,AH
        AL = AH;
    label_3358_1754_34CD4_26107:
        CheckExternalEvents(cs2, 0x1754);
        // 3358:1754 and AL,DL
        AL = Alu8.And(AL, DL);
        // 3358:1756 je short 0x179D
        if (ZeroFlag)
        {
            goto label_3358_179D_34D1D_37454;
        }
    label_3358_1758_34CD8_26109:
        CheckExternalEvents(cs2, 0x1758);
        // 3358:1758 add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:175A stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:175B cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:175D jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_175F_34CDF_26114:
        CheckExternalEvents(cs2, 0x175F);
        // 3358:175F shr AH,1
        AH = Alu8.Shr(AH, 1);
    label_3358_1761_34CE1_26116:
        CheckExternalEvents(cs2, 0x1761);
        // 3358:1761 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1763 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1765 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:1767 je short 0x17A6
        if (ZeroFlag)
        {
            goto label_3358_17A6_34D26_26169;
        }
    label_3358_1769_34CE9_26120:
        CheckExternalEvents(cs2, 0x1769);
        // 3358:1769 mov AL,AH
        AL = AH;
    label_3358_176B_34CEB_26122:
        CheckExternalEvents(cs2, 0x176B);
        // 3358:176B add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:176D stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
    label_3358_176E_34CEE_26124:
        CheckExternalEvents(cs2, 0x176E);
        // 3358:176E cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:1770 jb short 0x1731
        if (CarryFlag)
        {
            goto label_3358_1731_34CB1_26126;
        }
    label_3358_1772_34CF2_26144:
        CheckExternalEvents(cs2, 0x1772);
        // 3358:1772 pop DI
        DI = Stack.Pop16();
        // 3358:1773 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:1777 selector
        if (SelectorSignatureMatches(cs2, 0x1777, [(byte)0xE2, (byte)0x30]))
        {
            goto label_3358_1777_34CF7_37447;
        }
        if (SelectorSignatureMatches(cs2, 0x1777, [(byte)0xE2, (byte)0x48]))
        {
            goto label_3358_1777_34CF7_33294;
        }
        if (SelectorSignatureMatches(cs2, 0x1777, [(byte)0xE2, (byte)0x56]))
        {
            goto label_3358_1777_34CF7_26147;
        }
        if (SelectorSignatureMatches(cs2, 0x1777, [(byte)0xE2, (byte)0xAF]))
        {
            goto label_3358_1777_34CF7_33957;
        }
        throw FailAsUntested("No selector signature matched at 3358:1777");
    label_3358_1777_34CF7_26147:
        CheckExternalEvents(cs2, 0x1777);
        // 3358:1777 loop 0x17CF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_17CF_34D4F_38137;
        }
        else
        {
            goto label_3358_1779_34CF9_26178;
        }
    label_3358_1777_34CF7_33294:
        CheckExternalEvents(cs2, 0x1777);
        // 3358:1777 loop 0x17C1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_17C1_34D41_40321;
        }
        else
        {
            goto label_3358_1779_34CF9_26178;
        }
    label_3358_1777_34CF7_33957:
        CheckExternalEvents(cs2, 0x1777);
        // 3358:1777 loop 0x1728
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1728_34CA8_38135;
        }
        else
        {
            goto label_3358_1779_34CF9_26178;
        }
    label_3358_1777_34CF7_37447:
        CheckExternalEvents(cs2, 0x1777);
        // 3358:1777 loop 0x17A9
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_17A9_34D29_37939;
        }
    label_3358_1779_34CF9_26178:
        CheckExternalEvents(cs2, 0x1779);
        // 3358:1779 ret far
        return FarRet((ushort)0x0000);
    label_3358_177A_34CFA_26150:
        CheckExternalEvents(cs2, 0x177A);
        // 3358:177A inc DI
        DI = Alu16.Inc(DI);
        // 3358:177B cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:177D jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_177F_34CFF_26154:
        CheckExternalEvents(cs2, 0x177F);
        // 3358:177F or AL,BL
        AL = Alu8.Or(AL, BL);
        // 3358:1781 je short 0x178D
        if (ZeroFlag)
        {
            goto label_3358_178D_34D0D_26157;
        }
    label_3358_1783_34D03_26172:
        CheckExternalEvents(cs2, 0x1783);
        // 3358:1783 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1785 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1787 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:1789 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:178B jmp short 0x174B
        goto label_3358_174B_34CCB_26100;
    label_3358_178D_34D0D_26157:
        CheckExternalEvents(cs2, 0x178D);
        // 3358:178D inc DI
        DI = Alu16.Inc(DI);
        // 3358:178E cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:1790 jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_1792_34D12_26161:
        CheckExternalEvents(cs2, 0x1792);
        // 3358:1792 mov AL,AH
        AL = AH;
        // 3358:1794 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1796 jne short 0x1754
        if (!ZeroFlag)
        {
            goto label_3358_1754_34CD4_26107;
        }
    label_3358_1798_34D18_26165:
        CheckExternalEvents(cs2, 0x1798);
        // 3358:1798 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:179B jmp short 0x176E
        goto label_3358_176E_34CEE_26124;
    label_3358_179D_34D1D_37454:
        CheckExternalEvents(cs2, 0x179D);
        // 3358:179D inc DI
        DI = Alu16.Inc(DI);
        // 3358:179E cmp DI,BP
        Alu16.Sub(DI, BP);
        // 3358:17A0 jae short 0x1772
        if (!CarryFlag)
        {
            goto label_3358_1772_34CF2_26144;
        }
    label_3358_17A2_34D22_37459:
        CheckExternalEvents(cs2, 0x17A2);
        // 3358:17A2 shr AH,1
        AH = Alu8.Shr(AH, 1);
        // 3358:17A4 je short 0x1761
        if (ZeroFlag)
        {
            goto label_3358_1761_34CE1_26116;
        }
    label_3358_17A6_34D26_26169:
        CheckExternalEvents(cs2, 0x17A6);
        // 3358:17A6 inc DI
        DI = Alu16.Inc(DI);
        // 3358:17A7 jmp short 0x176E
        goto label_3358_176E_34CEE_26124;
    label_3358_17A9_34D29_37939:
        CheckExternalEvents(cs2, 0x17A9);
        // 3358:17A9 add SI,(short)byte ptr [0x00034D2B]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034D2Bu))])));
    label_3358_17AC_34D2C_37937:
        CheckExternalEvents(cs2, 0x17AC);
        // 3358:17AC mov BP,word ptr [0x00034D2D]
        BP = UInt16[unchecked((uint)(0x00034D2Du))];
        // 3358:17AF push DI
        Stack.Push16(DI);
        // 3358:17B0 add BP,DI
        BP = Alu16.Add(BP, DI);
        // 3358:17B2 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:17B3 cmp AL,DL
        Alu8.Sub(AL, DL);
        // 3358:17B5 jbe short 0x17A6
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_17A6_34D26_26169;
        }
    label_3358_17B7_34D37_37429:
        CheckExternalEvents(cs2, 0x17B7);
        // 3358:17B7 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17B9 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17BB shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17BD shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17BF jmp short 0x176B
        goto label_3358_176B_34CEB_26122;
    label_3358_17C1_34D41_40321:
        CheckExternalEvents(cs2, 0x17C1);
        // 3358:17C1 add SI,(short)byte ptr [0x00034D43]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034D43u))])));
    label_3358_17C4_34D44_38131:
        CheckExternalEvents(cs2, 0x17C4);
        // 3358:17C4 mov BP,word ptr [0x00034D45]
        BP = UInt16[unchecked((uint)(0x00034D45u))];
        // 3358:17C7 push DI
        Stack.Push16(DI);
        // 3358:17C8 add BP,DI
        BP = Alu16.Add(BP, DI);
        // 3358:17CA lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:17CB mov AH,AL
        AH = AL;
        // 3358:17CD jmp short 0x1754
        goto label_3358_1754_34CD4_26107;
    label_3358_17CF_34D4F_38137:
        CheckExternalEvents(cs2, 0x17CF);
        // 3358:17CF add SI,(short)byte ptr [0x00034D51]
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)Int8[unchecked((uint)(0x00034D51u))])));
    label_3358_17D2_34D52_26180:
        CheckExternalEvents(cs2, 0x17D2);
        // 3358:17D2 mov BP,word ptr [0x00034D53]
        BP = UInt16[unchecked((uint)(0x00034D53u))];
        // 3358:17D5 push DI
        Stack.Push16(DI);
        // 3358:17D6 add BP,DI
        BP = Alu16.Add(BP, DI);
        // 3358:17D8 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:17D9 and AL,0xF0
        AL = Alu8.And(AL, (byte)0xF0);
        // 3358:17DB je short 0x178D
        if (ZeroFlag)
        {
            goto label_3358_178D_34D0D_26157;
        }
    label_3358_17DD_34D5D_26094:
        CheckExternalEvents(cs2, 0x17DD);
        // 3358:17DD shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17DF shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17E1 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17E3 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 3358:17E5 jmp near 0x174B
        goto label_3358_174B_34CCB_26100;
    label_3358_17E8_34D68_31512:
        CheckExternalEvents(cs2, 0x17E8);
        // 3358:17E8 xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:17EA mov AX,word ptr SS:[BP+2]
        AX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:17ED sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:17EF jle short 0x17FC
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_17FC_34D7C_31517;
        }
    label_3358_17F1_34D71_37483:
        CheckExternalEvents(cs2, 0x17F1);
        // 3358:17F1 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:17F3 jbe short 0x1825
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1825_34DA5_37486;
        }
    label_3358_17F5_34D75_37488:
        CheckExternalEvents(cs2, 0x17F5);
        // 3358:17F5 add BX,AX
        BX = Alu16.Add(BX, AX);
    label_3358_17F7_34D77_37490:
        CheckExternalEvents(cs2, 0x17F7);
        // 3358:17F7 add SI,DI
        SI = Alu16.Add(SI, DI);
        // 3358:17F9 dec AX
        AX = Alu16.Dec(AX);
        // 3358:17FA jne short 0x17F7
        if (!ZeroFlag)
        {
            goto label_3358_17F7_34D77_37490;
        }
    label_3358_17FC_34D7C_31517:
        CheckExternalEvents(cs2, 0x17FC);
        // 3358:17FC mov AX,BX
        AX = BX;
        // 3358:17FE add AX,CX
        AX = Alu16.Add(AX, CX);
        // 3358:1800 sub AX,word ptr SS:[BP+6]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)6)]);
        // 3358:1803 jbe short 0x1809
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1809_34D89_31522;
        }
    label_3358_1805_34D85_31573:
        CheckExternalEvents(cs2, 0x1805);
        // 3358:1805 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:1807 jbe short 0x1825
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_1825_34DA5_37486;
        }
    label_3358_1809_34D89_31522:
        CheckExternalEvents(cs2, 0x1809);
        // 3358:1809 mov AX,DX
        AX = DX;
        // 3358:180B add AX,DI
        AX = Alu16.Add(AX, DI);
        // 3358:180D sub AX,word ptr SS:[BP+4]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)4)]);
        // 3358:1810 jg short 0x1854
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_1854_34DD4_31527;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1810");
        }
    label_3358_1825_34DA5_37486:
        CheckExternalEvents(cs2, 0x1825);
        // 3358:1825 ret far
        return FarRet((ushort)0x0000);
    label_3358_1837_34DB7_31548:
        CheckExternalEvents(cs2, 0x1837);
        // 3358:1837 sub BP,DX
        BP = Alu16.Sub(BP, DX);
    label_3358_1839_34DB9_31550:
        CheckExternalEvents(cs2, 0x1839);
        // 3358:1839 mov CX,DX
        CX = DX;
    label_3358_183B_34DBB_31551:
        CheckExternalEvents(cs2, 0x183B);
        // 3358:183B lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:183C or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:183E je short 0x184F
        if (ZeroFlag)
        {
            goto label_3358_184F_34DCF_31554;
        }
    label_3358_1840_34DC0_31558:
        CheckExternalEvents(cs2, 0x1840);
        // 3358:1840 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1841 loop 0x183B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_183B_34DBB_31551;
        }
    label_3358_1843_34DC3_31563:
        CheckExternalEvents(cs2, 0x1843);
        // 3358:1843 sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 3358:1845 add SI,BP
        SI = Alu16.Add(SI, BP);
        // 3358:1847 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:184B dec BX
        BX = Alu16.Dec(BX);
        // 3358:184C jne short 0x1839
        if (!ZeroFlag)
        {
            goto label_3358_1839_34DB9_31550;
        }
    label_3358_184E_34DCE_31570:
        CheckExternalEvents(cs2, 0x184E);
        // 3358:184E ret far
        return FarRet((ushort)0x0000);
    label_3358_184F_34DCF_31554:
        CheckExternalEvents(cs2, 0x184F);
        // 3358:184F inc DI
        DI = Alu16.Inc(DI);
        // 3358:1850 loop 0x183B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_183B_34DBB_31551;
        }
    label_3358_1852_34DD2_31561:
        CheckExternalEvents(cs2, 0x1852);
        // 3358:1852 jmp short 0x1843
        goto label_3358_1843_34DC3_31563;
    label_3358_1854_34DD4_31527:
        CheckExternalEvents(cs2, 0x1854);
        // 3358:1854 mov word ptr CS:[0x158B],DI
        UInt16[CS, (ushort)0x158B] = DI;
        // 3358:1859 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:185B jle short 0x1825
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_1825_34DA5_37486;
        }
    label_3358_185D_34DDD_31531:
        CheckExternalEvents(cs2, 0x185D);
        // 3358:185D mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1860 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:1862 jg short 0x1872
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_1872_34DF2_31535;
        }
    label_3358_1864_34DE4_37501:
        CheckExternalEvents(cs2, 0x1864);
        // 3358:1864 push DI
        Stack.Push16(DI);
        // 3358:1865 call near 0x0C10
        NearCall(cs2, 0x1868, unknown_3358_0C10_34190);
    label_3358_1868_34DE8_37506:
        CheckExternalEvents(cs2, 0x1868);
        // 3358:1868 pop DX
        DX = Stack.Pop16();
        // 3358:1869 mov BP,word ptr CS:[0x158B]
        BP = UInt16[CS, (ushort)0x158B];
        // 3358:186E mov BX,CX
        BX = CX;
        // 3358:1870 jmp short 0x1837
        goto label_3358_1837_34DB7_31548;
    label_3358_1872_34DF2_31535:
        CheckExternalEvents(cs2, 0x1872);
        // 3358:1872 sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:1874 jle short 0x1825
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_1825_34DA5_37486;
        }
    label_3358_1876_34DF6_31538:
        CheckExternalEvents(cs2, 0x1876);
        // 3358:1876 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:1878 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:187A push DI
        Stack.Push16(DI);
        // 3358:187B call near 0x0C10
        NearCall(cs2, 0x187E, unknown_3358_0C10_34190);
    label_3358_187E_34DFE_31543:
        CheckExternalEvents(cs2, 0x187E);
        // 3358:187E pop DX
        DX = Stack.Pop16();
        // 3358:187F mov BP,word ptr CS:[0x158B]
        BP = UInt16[CS, (ushort)0x158B];
        // 3358:1884 mov BX,CX
        BX = CX;
        // 3358:1886 jmp short 0x1837
        goto label_3358_1837_34DB7_31548;
    }

    public virtual Action unknown_3358_0115_33695(int loadOffset)
    {
    label_3358_0115_33695_12176:
        CheckExternalEvents(cs2, 0x0115);
        // 3358:0115 jmp near 0x1BF5
    label_3358_1BF5_35175_12178:
        CheckExternalEvents(cs2, 0x1BF5);
        // 3358:1BF5 call near 0x0C10
        NearCall(cs2, 0x1BF8, unknown_3358_0C10_34190);
    label_3358_1BF8_35178_12180:
        CheckExternalEvents(cs2, 0x1BF8);
        // 3358:1BF8 mov BX,AX
        BX = AX;
        // 3358:1BFA mov DX,CX
        DX = CX;
        // 3358:1BFC xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 3358:1BFE mov BP,DI
        BP = DI;
        // 3358:1C00 or BH,BH
        BH = Alu8.Or(BH, BH);
        // 3358:1C02 je short 0x1C1F
        if (ZeroFlag)
        {
            goto label_3358_1C1F_3519F_12187;
        }
    label_3358_1C04_35184_13438:
        CheckExternalEvents(cs2, 0x1C04);
        // 3358:1C04 mov CL,DL
        CL = DL;
        // 3358:1C06 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1C07 mov AH,AL
        AH = AL;
    label_3358_1C09_35189_13442:
        CheckExternalEvents(cs2, 0x1C09);
        // 3358:1C09 mov AL,BL
        AL = BL;
        // 3358:1C0B shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 3358:1C0D jb short 0x1C11
        if (CarryFlag)
        {
            goto label_3358_1C11_35191_13447;
        }
    label_3358_1C0F_3518F_13445:
        CheckExternalEvents(cs2, 0x1C0F);
        // 3358:1C0F mov AL,BH
        AL = BH;
    label_3358_1C11_35191_13447:
        CheckExternalEvents(cs2, 0x1C11);
        // 3358:1C11 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1C12 loop 0x1C09
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1C09_35189_13442;
        }
    label_3358_1C14_35194_13450:
        CheckExternalEvents(cs2, 0x1C14);
        // 3358:1C14 add BP,0x0140
        BP = Alu16.Add(BP, (ushort)0x0140);
        // 3358:1C18 mov DI,BP
        DI = BP;
        // 3358:1C1A dec DH
        DH = Alu8.Dec(DH);
        // 3358:1C1C jne short 0x1C04
        if (!ZeroFlag)
        {
            goto label_3358_1C04_35184_13438;
        }
    label_3358_1C1E_3519E_13455:
        CheckExternalEvents(cs2, 0x1C1E);
        // 3358:1C1E ret far
        return FarRet((ushort)0x0000);
    label_3358_1C1F_3519F_12187:
        CheckExternalEvents(cs2, 0x1C1F);
        // 3358:1C1F mov CL,DL
        CL = DL;
        // 3358:1C21 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:1C22 mov AH,AL
        AH = AL;
        // 3358:1C24 mov AL,BL
        AL = BL;
    label_3358_1C26_351A6_12192:
        CheckExternalEvents(cs2, 0x1C26);
        // 3358:1C26 shl AH,1
        AH = Alu8.Shl(AH, 1);
        // 3358:1C28 jb short 0x1C38
        if (CarryFlag)
        {
            goto label_3358_1C38_351B8_12194;
        }
    label_3358_1C2A_351AA_12198:
        CheckExternalEvents(cs2, 0x1C2A);
        // 3358:1C2A inc DI
        DI = Alu16.Inc(DI);
        // 3358:1C2B loop 0x1C26
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1C26_351A6_12192;
        }
    label_3358_1C2D_351AD_12201:
        CheckExternalEvents(cs2, 0x1C2D);
        // 3358:1C2D add BP,0x0140
        BP = Alu16.Add(BP, (ushort)0x0140);
        // 3358:1C31 mov DI,BP
        DI = BP;
        // 3358:1C33 dec DH
        DH = Alu8.Dec(DH);
        // 3358:1C35 jne short 0x1C1F
        if (!ZeroFlag)
        {
            goto label_3358_1C1F_3519F_12187;
        }
    label_3358_1C37_351B7_12206:
        CheckExternalEvents(cs2, 0x1C37);
        // 3358:1C37 ret far
        return FarRet((ushort)0x0000);
    label_3358_1C38_351B8_12194:
        CheckExternalEvents(cs2, 0x1C38);
        // 3358:1C38 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1C39 loop 0x1C26
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1C26_351A6_12192;
        }
    label_3358_1C3B_351BB_27513:
        CheckExternalEvents(cs2, 0x1C3B);
        // 3358:1C3B add BP,0x0140
        BP = Alu16.Add(BP, (ushort)0x0140);
        // 3358:1C3F mov DI,BP
        DI = BP;
        // 3358:1C41 dec DH
        DH = Alu8.Dec(DH);
        // 3358:1C43 jne short 0x1C1F
        if (!ZeroFlag)
        {
            goto label_3358_1C1F_3519F_12187;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:1C43");
        }
        throw FailAsUntested("Generated partition reached the end without a terminating control-flow instruction.");
    }

    public virtual Action unknown_3358_0118_33698(int loadOffset)
    {
    label_3358_0118_33698_2712:
        CheckExternalEvents(cs2, 0x0118);
        // 3358:0118 jmp near 0x19F7
    label_3358_19F7_34F77_2714:
        CheckExternalEvents(cs2, 0x19F7);
        // 3358:19F7 push AX
        Stack.Push16(AX);
        // 3358:19F8 push CX
        Stack.Push16(CX);
        // 3358:19F9 push DI
        Stack.Push16(DI);
        // 3358:19FA xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 3358:19FC xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:19FE mov CX,0x7D00
        CX = (ushort)0x7D00;
        // 3358:1A01 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1A03 pop DI
        DI = Stack.Pop16();
        // 3358:1A04 pop CX
        CX = Stack.Pop16();
        // 3358:1A05 pop AX
        AX = Stack.Pop16();
        // 3358:1A06 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_011B_3369B(int loadOffset)
    {
    label_3358_011B_3369B_6678:
        CheckExternalEvents(cs2, 0x011B);
        // 3358:011B jmp near 0x1979
    label_3358_1979_34EF9_6680:
        CheckExternalEvents(cs2, 0x1979);
        // 3358:1979 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        return unknown_3358_197B_34EFB(0x0000);
    }

    public virtual Action unknown_3358_011E_3369E(int loadOffset)
    {
    label_3358_011E_3369E_10057:
        CheckExternalEvents(cs2, 0x011E);
        // 3358:011E jmp near 0x197B
        return unknown_3358_197B_34EFB(0x0000);
    }

    public virtual Action unknown_3358_0121_336A1(int loadOffset)
    {
    label_3358_0121_336A1_2735:
        CheckExternalEvents(cs2, 0x0121);
        // 3358:0121 jmp near 0x1B7C
        return unknown_3358_1B7C_350FC(0x0000);
    }

    public virtual Action unknown_3358_0124_336A4(int loadOffset)
    {
    label_3358_0124_336A4_19241:
        CheckExternalEvents(cs2, 0x0124);
        // 3358:0124 jmp near 0x1B8E
        return unknown_3358_1B8E_3510E(0x0000);
    }

    public virtual Action unknown_3358_012A_336AA(int loadOffset)
    {
    label_3358_012A_336AA_8091:
        CheckExternalEvents(cs2, 0x012A);
        // 3358:012A jmp near 0x1B8C
    label_3358_1B8C_3510C_8093:
        CheckExternalEvents(cs2, 0x1B8C);
        // 3358:1B8C mov DS,SI
        DS = SI;
        return unknown_3358_1B8E_3510E(0x0000);
    }

    public virtual Action unknown_3358_012D_336AD(int loadOffset)
    {
    label_3358_012D_336AD_4665:
        CheckExternalEvents(cs2, 0x012D);
        // 3358:012D jmp near 0x1B7C
        return unknown_3358_1B7C_350FC(0x0000);
    }

    public virtual Action unknown_3358_0130_336B0(int loadOffset)
    {
    label_3358_0130_336B0_8283:
        CheckExternalEvents(cs2, 0x0130);
        // 3358:0130 jmp near 0x1B8E
        return unknown_3358_1B8E_3510E(0x0000);
    }

    public virtual Action unknown_3358_0133_336B3(int loadOffset)
    {
    label_3358_0133_336B3_5596:
        CheckExternalEvents(cs2, 0x0133);
        // 3358:0133 jmp near 0x1BCA
    label_3358_1BCA_3514A_5598:
        CheckExternalEvents(cs2, 0x1BCA);
        // 3358:1BCA mov BP,DI
        BP = DI;
        // 3358:1BCC and BP,0x01FF
        BP = Alu16.And(BP, (ushort)0x01FF);
        // 3358:1BD0 call near 0x0C10
        NearCall(cs2, 0x1BD3, unknown_3358_0C10_34190);
    label_3358_1BD3_35153_5602:
        CheckExternalEvents(cs2, 0x1BD3);
        // 3358:1BD3 mov DX,CX
        DX = CX;
        // 3358:1BD5 xor DH,DH
        DH = Alu8.Xor(DH, DH);
    label_3358_1BD7_35157_5605:
        CheckExternalEvents(cs2, 0x1BD7);
        // 3358:1BD7 mov CX,BP
        CX = BP;
        // 3358:1BD9 push DI
        Stack.Push16(DI);
    label_3358_1BDA_3515A_5607:
        CheckExternalEvents(cs2, 0x1BDA);
        // 3358:1BDA movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:1BDB inc DI
        DI = Alu16.Inc(DI);
        // 3358:1BDC loop 0x1BDA
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_1BDA_3515A_5607;
        }
    label_3358_1BDE_3515E_5611:
        CheckExternalEvents(cs2, 0x1BDE);
        // 3358:1BDE pop DI
        DI = Stack.Pop16();
        // 3358:1BDF add DI,0x0280
        DI = Alu16.Add(DI, (ushort)0x0280);
        // 3358:1BE3 dec DX
        DX = Alu16.Dec(DX);
        // 3358:1BE4 jne short 0x1BD7
        if (!ZeroFlag)
        {
            goto label_3358_1BD7_35157_5605;
        }
    label_3358_1BE6_35166_5617:
        CheckExternalEvents(cs2, 0x1BE6);
        // 3358:1BE6 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0136_336B6(int loadOffset)
    {
    label_3358_0136_336B6_6579:
        CheckExternalEvents(cs2, 0x0136);
        // 3358:0136 jmp near 0x1BE7
    label_3358_1BE7_35167_6581:
        CheckExternalEvents(cs2, 0x1BE7);
        // 3358:1BE7 push DS
        Stack.Push16(DS);
        // 3358:1BE8 mov DS,SI
        DS = SI;
        // 3358:1BEA xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 3358:1BEC mov DI,SI
        DI = SI;
        // 3358:1BEE mov CX,0x5F00
        CX = (ushort)0x5F00;
        // 3358:1BF1 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1BF3 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1BF4 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0139_336B9(int loadOffset)
    {
    label_3358_0139_336B9_7497:
        CheckExternalEvents(cs2, 0x0139);
        // 3358:0139 jmp near 0x1A07
    label_3358_1A07_34F87_7499:
        CheckExternalEvents(cs2, 0x1A07);
        // 3358:1A07 mov word ptr CS:[0x019A],BP
        UInt16[CS, (ushort)0x019A] = BP;
        // 3358:1A0C mov word ptr CS:[0x0198],SI
        UInt16[CS, (ushort)0x0198] = SI;
        // 3358:1A11 mov byte ptr CS:[0x019C],AL
        UInt8[CS, (ushort)0x019C] = AL;
        // 3358:1A15 push AX
        Stack.Push16(AX);
        // 3358:1A16 push BX
        Stack.Push16(BX);
        // 3358:1A17 push CX
        Stack.Push16(CX);
        // 3358:1A18 push DX
        Stack.Push16(DX);
        // 3358:1A19 push DI
        Stack.Push16(DI);
        // 3358:1A1A mov word ptr CS:[0x0194],DX
        UInt16[CS, (ushort)0x0194] = DX;
        // 3358:1A1F mov word ptr CS:[0x0196],BX
        UInt16[CS, (ushort)0x0196] = BX;
        // 3358:1A24 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 3358:1A26 sub DX,DI
        DX = Alu16.Sub(DX, DI);
        // 3358:1A28 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
        // 3358:1A2A neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 3358:1A2C call near 0x1ADC
        NearCall(cs2, 0x1A2F, unknown_3358_1ADC_3505C);
    label_3358_1A2F_34FAF_7596:
        CheckExternalEvents(cs2, 0x1A2F);
        // 3358:1A2F mov BP,word ptr CS:[0x019A]
        BP = UInt16[CS, (ushort)0x019A];
        // 3358:1A34 pop DI
        DI = Stack.Pop16();
        // 3358:1A35 pop DX
        DX = Stack.Pop16();
        // 3358:1A36 pop CX
        CX = Stack.Pop16();
        // 3358:1A37 pop BX
        BX = Stack.Pop16();
        // 3358:1A38 pop AX
        AX = Stack.Pop16();
        // 3358:1A39 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_013C_336BC(int loadOffset)
    {
    label_3358_013C_336BC_2968:
        CheckExternalEvents(cs2, 0x013C);
        // 3358:013C ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0142_336C2(int loadOffset)
    {
    label_3358_0142_336C2_20891:
        CheckExternalEvents(cs2, 0x0142);
        // 3358:0142 jmp near 0x23EB
    label_3358_23EB_3596B_20893:
        CheckExternalEvents(cs2, 0x23EB);
        // 3358:23EB push DI
        Stack.Push16(DI);
        // 3358:23EC mov DI,CX
        DI = CX;
        // 3358:23EE dec DI
        DI = Alu16.Dec(DI);
        // 3358:23EF add BX,DI
        BX = Alu16.Add(BX, DI);
        // 3358:23F1 add AX,DI
        AX = Alu16.Add(AX, DI);
        // 3358:23F3 push AX
        Stack.Push16(AX);
        // 3358:23F4 push DX
        Stack.Push16(DX);
        // 3358:23F5 mov AX,0x00C8
        AX = (ushort)0x00C8;
        // 3358:23F8 mul DI
        uint result_3358_23F8_35978 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DI)));
        DX = unchecked((ushort)(result_3358_23F8_35978 >> 16));
        AX = unchecked((ushort)result_3358_23F8_35978);
        // 3358:23FA add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:23FC pop DX
        DX = Stack.Pop16();
        // 3358:23FD pop AX
        AX = Stack.Pop16();
        // 3358:23FE call near 0x0C10
        NearCall(cs2, 0x2401, unknown_3358_0C10_34190);
    label_3358_2401_35981_20907:
        CheckExternalEvents(cs2, 0x2401);
        // 3358:2401 pop DX
        DX = Stack.Pop16();
        // 3358:2402 xchg CX,DX
        ushort temp_3358_2402_35982 = CX;
        CX = DX;
        DX = unchecked((ushort)temp_3358_2402_35982);
    label_3358_2404_35984_20910:
        CheckExternalEvents(cs2, 0x2404);
        // 3358:2404 call near 0x2413
        NearCall(cs2, 0x2407, unknown_3358_2413_35993);
    label_3358_2407_35987_20956:
        CheckExternalEvents(cs2, 0x2407);
        // 3358:2407 sub SI,0x00C8
        SI = Alu16.Sub(SI, (ushort)0x00C8);
        // 3358:240B sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
        // 3358:240F dec DX
        DX = Alu16.Dec(DX);
        // 3358:2410 jne short 0x2404
        if (!ZeroFlag)
        {
            goto label_3358_2404_35984_20910;
        }
    label_3358_2412_35992_20964:
        CheckExternalEvents(cs2, 0x2412);
        // 3358:2412 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0145_336C5(int loadOffset)
    {
    label_3358_0145_336C5_12502:
        CheckExternalEvents(cs2, 0x0145);
        // 3358:0145 jmp near 0x1CB6
    label_3358_1CB6_35236_12504:
        CheckExternalEvents(cs2, 0x1CB6);
        // 3358:1CB6 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:1CB8 mov AX,0x9090
        AX = (ushort)0x9090;
        // 3358:1CBB je short 0x1CC0
        if (ZeroFlag)
        {
            goto label_3358_1CC0_35240_12508;
        }
    label_3358_1CBD_3523D_19262:
        CheckExternalEvents(cs2, 0x1CBD);
        // 3358:1CBD mov AX,0x7DEB
        AX = (ushort)0x7DEB;
    label_3358_1CC0_35240_12508:
        CheckExternalEvents(cs2, 0x1CC0);
        // 3358:1CC0 mov word ptr CS:[0x1E4A],AX
        UInt16[CS, (ushort)0x1E4A] = AX;
        // 3358:1CC4 mov word ptr CS:[0x1CA0],SI
        UInt16[CS, (ushort)0x1CA0] = SI;
        // 3358:1CC9 mov word ptr CS:[0x1CA2],DS
        UInt16[CS, (ushort)0x1CA2] = DS;
        // 3358:1CCE mov word ptr CS:[0x1CA4],BP
        UInt16[CS, (ushort)0x1CA4] = BP;
        // 3358:1CD3 add BP,0x0319
        BP = Alu16.Add(BP, (ushort)0x0319);
        // 3358:1CD7 mov word ptr CS:[0x1CA8],BP
        UInt16[CS, (ushort)0x1CA8] = BP;
        // 3358:1CDC mov DI,BP
        DI = BP;
        // 3358:1CDE mov word ptr CS:[0x1CA6],BP
        UInt16[CS, (ushort)0x1CA6] = BP;
        // 3358:1CE3 add BP,0x0CD9
        BP = Alu16.Add(BP, (ushort)0x0CD9);
        // 3358:1CE7 mov word ptr CS:[0x1CAA],BP
        UInt16[CS, (ushort)0x1CAA] = BP;
        // 3358:1CEC add BP,0x3301
        BP = Alu16.Add(BP, (ushort)0x3301);
        // 3358:1CF0 mov word ptr CS:[0x1CAC],BP
        UInt16[CS, (ushort)0x1CAC] = BP;
        // 3358:1CF5 mov word ptr CS:[0x1CB4],0xFEC0
        UInt16[CS, (ushort)0x1CB4] = (ushort)0xFEC0;
        // 3358:1CFC push CS
        Stack.Push16(CS);
        // 3358:1CFD call near 0x1D5A
        NearCall(cs2, 0x1D00, unknown_3358_1D5A_352DA);
    label_3358_1D00_35280_12537:
        CheckExternalEvents(cs2, 0x1D00);
        // 3358:1D00 push CS
        Stack.Push16(CS);
        // 3358:1D01 call near 0x1D07
        NearCall(cs2, 0x1D04, unknown_3358_1D07_35287);
    label_3358_1D04_35284_12640:
        CheckExternalEvents(cs2, 0x1D04);
        // 3358:1D04 jae short 0x1D00
        if (!CarryFlag)
        {
            goto label_3358_1D00_35280_12537;
        }
    label_3358_1D06_35286_12703:
        CheckExternalEvents(cs2, 0x1D06);
        // 3358:1D06 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0148_336C8(int loadOffset)
    {
    label_3358_0148_336C8_12727:
        CheckExternalEvents(cs2, 0x0148);
        // 3358:0148 jmp near 0x1D07
        return unknown_3358_1D07_35287(0x0000);
    }

    public virtual Action unknown_3358_014B_336CB(int loadOffset)
    {
    label_3358_014B_336CB_14451:
        CheckExternalEvents(cs2, 0x014B);
        // 3358:014B jmp near 0x1C46
    label_3358_1C46_351C6_14453:
        CheckExternalEvents(cs2, 0x1C46);
        // 3358:1C46 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1C49 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1C4C call near 0x0C10
        NearCall(cs2, 0x1C4F, unknown_3358_0C10_34190);
    label_3358_1C4F_351CF_14457:
        CheckExternalEvents(cs2, 0x1C4F);
        // 3358:1C4F mov CX,word ptr SS:[BP+4]
        CX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1C52 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:1C55 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 3358:1C57 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:1C59 xchg DI,SI
        ushort temp_3358_1C59_351D9 = DI;
        DI = SI;
        SI = unchecked((ushort)temp_3358_1C59_351D9);
        // 3358:1C5B mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:1C5E sub DX,CX
        DX = Alu16.Sub(DX, CX);
        // 3358:1C60 push DS
        Stack.Push16(DS);
        // 3358:1C61 push ES
        Stack.Push16(ES);
        // 3358:1C62 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1C63 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_3358_1C64_351E4_14469:
        CheckExternalEvents(cs2, 0x1C64);
        // 3358:1C64 push CX
        Stack.Push16(CX);
        // 3358:1C65 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:1C67 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1C69 adc CX,CX
        CX = Alu16.Adc(CX, CX);
        // 3358:1C6B rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1C6D pop CX
        CX = Stack.Pop16();
        // 3358:1C6E add SI,DX
        SI = Alu16.Add(SI, DX);
        // 3358:1C70 dec AX
        AX = Alu16.Dec(AX);
        // 3358:1C71 jne short 0x1C64
        if (!ZeroFlag)
        {
            goto label_3358_1C64_351E4_14469;
        }
    label_3358_1C73_351F3_14479:
        CheckExternalEvents(cs2, 0x1C73);
        // 3358:1C73 push SS
        Stack.Push16(SS);
        // 3358:1C74 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1C75 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_014E_336CE(int loadOffset)
    {
    label_3358_014E_336CE_25917:
        CheckExternalEvents(cs2, 0x014E);
        // 3358:014E jmp near 0x1C76
    label_3358_1C76_351F6_25919:
        CheckExternalEvents(cs2, 0x1C76);
        // 3358:1C76 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1C79 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1C7C call near 0x0C10
        NearCall(cs2, 0x1C7F, unknown_3358_0C10_34190);
    label_3358_1C7F_351FF_25923:
        CheckExternalEvents(cs2, 0x1C7F);
        // 3358:1C7F mov CX,word ptr SS:[BP+4]
        CX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:1C82 mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:1C85 sub CX,DX
        CX = Alu16.Sub(CX, DX);
        // 3358:1C87 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:1C89 mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:1C8C sub DX,CX
        DX = Alu16.Sub(DX, CX);
    label_3358_1C8E_3520E_25930:
        CheckExternalEvents(cs2, 0x1C8E);
        // 3358:1C8E push CX
        Stack.Push16(CX);
        // 3358:1C8F shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:1C91 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1C93 adc CX,CX
        CX = Alu16.Adc(CX, CX);
        // 3358:1C95 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:1C97 pop CX
        CX = Stack.Pop16();
        // 3358:1C98 add DI,DX
        DI = Alu16.Add(DI, DX);
        // 3358:1C9A dec AX
        AX = Alu16.Dec(AX);
        // 3358:1C9B jne short 0x1C8E
        if (!ZeroFlag)
        {
            goto label_3358_1C8E_3520E_25930;
        }
    label_3358_1C9D_3521D_25940:
        CheckExternalEvents(cs2, 0x1C9D);
        // 3358:1C9D push SS
        Stack.Push16(SS);
        // 3358:1C9E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:1C9F ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0151_336D1(int loadOffset)
    {
    label_3358_0151_336D1_4499:
        CheckExternalEvents(cs2, 0x0151);
        // 3358:0151 jmp near 0x25E7
    label_3358_25E7_35B67_4501:
        CheckExternalEvents(cs2, 0x25E7);
        // 3358:25E7 mov word ptr CS:[0x2768],8
        UInt16[CS, (ushort)0x2768] = (ushort)0x0008;
        // 3358:25EE mov word ptr CS:[0x276A],1
        UInt16[CS, (ushort)0x276A] = (ushort)0x0001;
        // 3358:25F5 mov word ptr CS:[0x2535],SI
        UInt16[CS, (ushort)0x2535] = SI;
        // 3358:25FA mov word ptr CS:[0x2537],DS
        UInt16[CS, (ushort)0x2537] = DS;
        // 3358:25FF mov word ptr CS:[0x2539],ES
        UInt16[CS, (ushort)0x2539] = ES;
        // 3358:2604 mov CX,0x0098
        CX = (ushort)0x0098;
        // 3358:2607 and AX,0x00FE
        AX = Alu16.And(AX, (ushort)0x00FE);
        // 3358:260A cmp AX,0x003E
        Alu16.Sub(AX, (ushort)0x003E);
        // 3358:260D jb short 0x2614
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:260D");
        }
    label_3358_2614_35B94_4511:
        CheckExternalEvents(cs2, 0x2614);
        // 3358:2614 mov BX,AX
        BX = AX;
        // 3358:2616 jmp near word ptr CS:[BX+0x25A9]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)9641)]))
        {
            case 0x2628:
                break;
            case 0x26B0:
                goto label_3358_26B0_35C30_11464;
            case 0x272E:
                goto label_3358_272E_35CAE_4514;
            case 0x2757:
                goto label_3358_2757_35CD7_5195;
            case 0x2A15:
                goto label_3358_2A15_35F95_31861;
            case 0x2A68:
                goto label_3358_2A68_35FE8_19726;
            case 0x2AD1:
                goto label_3358_2AD1_36051_16892;
            case 0x2CCA:
                goto label_3358_2CCA_3624A_18606;
            case 0x2D44:
                goto label_3358_2D44_362C4_41516;
            case 0x2DC0:
                goto label_3358_2DC0_36340_14578;
            case 0x2DC3:
                goto label_3358_2DC3_36343_6484;
            case 0x2EEA:
                goto label_3358_2EEA_3646A_28014;
            case 0x2F53:
                goto label_3358_2F53_364D3_32635;
            case 0x2F87:
                goto label_3358_2F87_36507_32510;
            case 0x2F9F:
                goto label_3358_2F9F_3651F_32431;
            case 0x3130:
                goto label_3358_3130_366B0_19995;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)9641)])):X4} at 3358:2616");
        }
    label_3358_2628_35BA8_5895:
        CheckExternalEvents(cs2, 0x2628);
        // 3358:2628 call near 0x0A58
        NearCall(cs2, 0x262B, unknown_3358_0A58_33FD8);
    label_3358_262B_35BAB_5897:
        CheckExternalEvents(cs2, 0x262B);
        // 3358:262B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:262D mov DI,0x01BE
        DI = (ushort)0x01BE;
        // 3358:2630 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:2633 rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2635 mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:2638 mov DX,DI
        DX = DI;
        // 3358:263A mov CX,0x02FD
        CX = (ushort)0x02FD;
        // 3358:263D rep stos byte ptr ES:[DI],AL
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = AL;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:263F xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 3358:2641 mov CX,0x00FF
        CX = (ushort)0x00FF;
        // 3358:2644 call near 0x0B68
        NearCall(cs2, 0x2647, unknown_3358_0B68_340E8);
    label_3358_2647_35BC7_5909:
        CheckExternalEvents(cs2, 0x2647);
        // 3358:2647 mov CX,0x0060
        CX = (ushort)0x0060;
        // 3358:264A mov DX,0x0140
        DX = (ushort)0x0140;
    label_3358_264D_35BCD_4589:
        CheckExternalEvents(cs2, 0x264D);
        // 3358:264D mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:2652 mov ES,word ptr CS:[0x2539]
        ES = UInt16[CS, (ushort)0x2539];
        // 3358:2657 push CS
        Stack.Push16(CS);
        // 3358:2658 call near 0x1B7C
        NearCall(cs2, 0x265B, unknown_3358_1B7C_350FC);
    label_3358_265B_35BDB_4594:
        CheckExternalEvents(cs2, 0x265B);
        // 3358:265B push CS
        Stack.Push16(CS);
        // 3358:265C push CS
        Stack.Push16(CS);
        // 3358:265D pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:265E pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_3358_265F_35BDF_4599:
        CheckExternalEvents(cs2, 0x265F);
        // 3358:265F xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_3358_2661_35BE1_4600:
        CheckExternalEvents(cs2, 0x2661);
        // 3358:2661 push BX
        Stack.Push16(BX);
        // 3358:2662 push CX
        Stack.Push16(CX);
        // 3358:2663 push DX
        Stack.Push16(DX);
        // 3358:2664 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2667 mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:266A add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:266C lea SI,DI-768
        SI = unchecked((ushort)(DI + (short)-768));
        // 3358:2670 push BX
        Stack.Push16(BX);
        // 3358:2671 push CX
        Stack.Push16(CX);
        // 3358:2672 push DI
        Stack.Push16(DI);
    label_3358_2673_35BF3_4610:
        CheckExternalEvents(cs2, 0x2673);
        // 3358:2673 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:2674 sub AL,byte ptr DS:[DI]
        AL = Alu8.Sub(AL, UInt8[DS, DI]);
        // 3358:2676 je short 0x2690
        if (ZeroFlag)
        {
            goto label_3358_2690_35C10_4613;
        }
    label_3358_2678_35BF8_4617:
        CheckExternalEvents(cs2, 0x2678);
        // 3358:2678 mov BL,AL
        BL = AL;
        // 3358:267A xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 3358:267C div DH
        byte divisor_3358_267C_35BFC = DH;
        ushort dividend_3358_267C_35BFC = AX;
        byte quotient_3358_267C_35BFC = Alu8.Div(unchecked((ushort)dividend_3358_267C_35BFC), unchecked((byte)divisor_3358_267C_35BFC));
        AL = unchecked((byte)quotient_3358_267C_35BFC);
        AH = unchecked((byte)(dividend_3358_267C_35BFC % unchecked((ushort)divisor_3358_267C_35BFC)));
        // 3358:267E xchg AL,AH
        byte temp_3358_267E_35BFE = AL;
        AL = AH;
        AH = unchecked((byte)temp_3358_267E_35BFE);
        // 3358:2680 inc AH
        AH = Alu8.Inc(AH);
        // 3358:2682 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 3358:2684 jne short 0x268A
        if (!ZeroFlag)
        {
            goto label_3358_268A_35C0A_4628;
        }
    label_3358_2686_35C06_4625:
        CheckExternalEvents(cs2, 0x2686);
        // 3358:2686 dec AH
        AH = Alu8.Dec(AH);
        // 3358:2688 mov AL,DH
        AL = DH;
    label_3358_268A_35C0A_4628:
        CheckExternalEvents(cs2, 0x268A);
        // 3358:268A cmp AH,DL
        Alu8.Sub(AH, DL);
        // 3358:268C jb short 0x2690
        if (CarryFlag)
        {
            goto label_3358_2690_35C10_4613;
        }
    label_3358_268E_35C0E_4653:
        CheckExternalEvents(cs2, 0x268E);
        // 3358:268E add byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Add(UInt8[DS, DI], AL);
    label_3358_2690_35C10_4613:
        CheckExternalEvents(cs2, 0x2690);
        // 3358:2690 inc DI
        DI = Alu16.Inc(DI);
        // 3358:2691 loop 0x2673
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2673_35BF3_4610;
        }
    label_3358_2693_35C13_4631:
        CheckExternalEvents(cs2, 0x2693);
        // 3358:2693 pop DX
        DX = Stack.Pop16();
        // 3358:2694 pop CX
        CX = Stack.Pop16();
        // 3358:2695 pop BX
        BX = Stack.Pop16();
        // 3358:2696 call near 0x0A21
        NearCall(cs2, 0x2699, unknown_3358_0A21_33FA1);
    label_3358_2699_35C19_4636:
        CheckExternalEvents(cs2, 0x2699);
        // 3358:2699 call near 0x0B68
        NearCall(cs2, 0x269C, unknown_3358_0B68_340E8);
    label_3358_269C_35C1C_4638:
        CheckExternalEvents(cs2, 0x269C);
        // 3358:269C pop BX
        BX = Stack.Pop16();
        // 3358:269D call near 0x261D
        NearCall(cs2, 0x26A0, unknown_3358_261D_35B9D);
    label_3358_26A0_35C20_4641:
        CheckExternalEvents(cs2, 0x26A0);
        // 3358:26A0 pop DX
        DX = Stack.Pop16();
        // 3358:26A1 pop CX
        CX = Stack.Pop16();
        // 3358:26A2 pop BX
        BX = Stack.Pop16();
        // 3358:26A3 add BX,CX
        BX = Alu16.Add(BX, CX);
        // 3358:26A5 cmp BX,0x02FD
        Alu16.Sub(BX, (ushort)0x02FD);
        // 3358:26A9 jb short 0x2661
        if (CarryFlag)
        {
            goto label_3358_2661_35BE1_4600;
        }
    label_3358_26AB_35C2B_4649:
        CheckExternalEvents(cs2, 0x26AB);
        // 3358:26AB dec DL
        DL = Alu8.Dec(DL);
        // 3358:26AD jne short 0x265F
        if (!ZeroFlag)
        {
            goto label_3358_265F_35BDF_4599;
        }
    label_3358_26AF_35C2F_4655:
        CheckExternalEvents(cs2, 0x26AF);
        // 3358:26AF ret far
        return FarRet((ushort)0x0000);
    label_3358_26B0_35C30_11464:
        CheckExternalEvents(cs2, 0x26B0);
        // 3358:26B0 call near 0x0A58
        NearCall(cs2, 0x26B3, unknown_3358_0A58_33FD8);
    label_3358_26B3_35C33_11466:
        CheckExternalEvents(cs2, 0x26B3);
        // 3358:26B3 mov DX,0x0220
        DX = (ushort)0x0220;
        // 3358:26B6 mov AX,0x0040
        AX = (ushort)0x0040;
        // 3358:26B9 call near 0x26E3
        NearCall(cs2, 0x26BC, unknown_3358_26E3_35C63);
    label_3358_26BC_35C3C_11470:
        CheckExternalEvents(cs2, 0x26BC);
        // 3358:26BC mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:26C1 mov ES,word ptr CS:[0x2539]
        ES = UInt16[CS, (ushort)0x2539];
        // 3358:26C6 push CS
        Stack.Push16(CS);
        // 3358:26C7 call near 0x1B7C
        NearCall(cs2, 0x26CA, unknown_3358_1B7C_350FC);
    label_3358_26CA_35C4A_11475:
        CheckExternalEvents(cs2, 0x26CA);
        // 3358:26CA push CS
        Stack.Push16(CS);
        // 3358:26CB push CS
        Stack.Push16(CS);
        // 3358:26CC pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:26CD pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:26CE mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:26D1 mov DX,DI
        DX = DI;
        // 3358:26D3 mov SI,0x02BF
        SI = (ushort)0x02BF;
        // 3358:26D6 mov CX,0x0180
        CX = (ushort)0x0180;
        // 3358:26D9 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:26DB xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 3358:26DD mov CX,0x0060
        CX = (ushort)0x0060;
        // 3358:26E0 jmp near 0x0B0C
        return unknown_3358_0B0C_3408C(0x0000);
    label_3358_272E_35CAE_4514:
        CheckExternalEvents(cs2, 0x272E);
        // 3358:272E push CS
        Stack.Push16(CS);
        // 3358:272F push CS
        Stack.Push16(CS);
        // 3358:2730 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2731 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2732 mov SI,0x05C2
        SI = (ushort)0x05C2;
        // 3358:2735 mov DI,0x02C2
        DI = (ushort)0x02C2;
        // 3358:2738 mov CX,0x017D
        CX = (ushort)0x017D;
    label_3358_273B_35CBB_4522:
        CheckExternalEvents(cs2, 0x273B);
        // 3358:273B mov AX,word ptr DS:[DI]
        AX = UInt16[DS, DI];
        // 3358:273D xchg AX,word ptr DS:[SI]
        ushort xchgOffset_3358_273D_35CBD = SI;
        ushort temp_3358_273D_35CBD = AX;
        AX = UInt16[DS, xchgOffset_3358_273D_35CBD];
        UInt16[DS, xchgOffset_3358_273D_35CBD] = unchecked((ushort)temp_3358_273D_35CBD);
        // 3358:273F stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:2740 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:2743 loop 0x273B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_273B_35CBB_4522;
        }
    label_3358_2745_35CC5_4528:
        CheckExternalEvents(cs2, 0x2745);
        // 3358:2745 mov AX,0x0055
        AX = (ushort)0x0055;
        // 3358:2748 mov DX,0x0316
        DX = (ushort)0x0316;
        // 3358:274B call near 0x26E3
        NearCall(cs2, 0x274E, unknown_3358_26E3_35C63);
    label_3358_274E_35CCE_4585:
        CheckExternalEvents(cs2, 0x274E);
        // 3358:274E mov CX,0x00FF
        CX = (ushort)0x00FF;
        // 3358:2751 mov DX,0x0316
        DX = (ushort)0x0316;
        // 3358:2754 jmp near 0x264D
        goto label_3358_264D_35BCD_4589;
    label_3358_2757_35CD7_5195:
        CheckExternalEvents(cs2, 0x2757);
        // 3358:2757 push CS
        Stack.Push16(CS);
        // 3358:2758 call near 0x0B0C
        NearCall(cs2, 0x275B, unknown_3358_0B0C_3408C);
    label_3358_275B_35CDB_5198:
        CheckExternalEvents(cs2, 0x275B);
        // 3358:275B mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:2760 mov SI,DI
        SI = DI;
        // 3358:2762 mov CX,0x5F00
        CX = (ushort)0x5F00;
        // 3358:2765 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2767 ret far
        return FarRet((ushort)0x0000);
    label_3358_2A15_35F95_31861:
        CheckExternalEvents(cs2, 0x2A15);
        // 3358:2A15 mov DX,0x0096
        DX = (ushort)0x0096;
        // 3358:2A18 mov AX,0x0140
        AX = (ushort)0x0140;
        // 3358:2A1B push DX
        Stack.Push16(DX);
        // 3358:2A1C mul CX
        uint result_3358_2A1C_35F9C = Alu16.Mul(AX, unchecked((ushort)unchecked((short)CX)));
        DX = unchecked((ushort)(result_3358_2A1C_35F9C >> 16));
        AX = unchecked((ushort)result_3358_2A1C_35F9C);
        // 3358:2A1E pop DX
        DX = Stack.Pop16();
        // 3358:2A1F mov CX,1
        CX = (ushort)0x0001;
    label_3358_2A22_35FA2_31868:
        CheckExternalEvents(cs2, 0x2A22);
        // 3358:2A22 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2A25 push DX
        Stack.Push16(DX);
    label_3358_2A26_35FA6_31870:
        CheckExternalEvents(cs2, 0x2A26);
        // 3358:2A26 mov SI,CX
        SI = CX;
        // 3358:2A28 add SI,word ptr CS:[0x01A3]
        SI = Alu16.Add(SI, UInt16[CS, (ushort)0x01A3]);
        // 3358:2A2D mov DI,SI
        DI = SI;
        // 3358:2A2F movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2A30 sub SI,word ptr CS:[0x01A3]
        SI = Alu16.Sub(SI, UInt16[CS, (ushort)0x01A3]);
        // 3358:2A35 add SI,0x7FFE
        SI = Alu16.Add(SI, (ushort)0x7FFE);
        // 3358:2A39 cmp SI,AX
        Alu16.Sub(SI, AX);
        // 3358:2A3B jae short 0x2A4A
        if (!CarryFlag)
        {
            goto label_3358_2A4A_35FCA_31883;
        }
    label_3358_2A3D_35FBD_31878:
        CheckExternalEvents(cs2, 0x2A3D);
        // 3358:2A3D add SI,word ptr CS:[0x01A3]
        SI = Alu16.Add(SI, UInt16[CS, (ushort)0x01A3]);
        // 3358:2A42 mov DI,SI
        DI = SI;
        // 3358:2A44 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2A45 sub SI,word ptr CS:[0x01A3]
        SI = Alu16.Sub(SI, UInt16[CS, (ushort)0x01A3]);
    label_3358_2A4A_35FCA_31883:
        CheckExternalEvents(cs2, 0x2A4A);
        // 3358:2A4A shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2A4C jae short 0x2A51
        if (!CarryFlag)
        {
            goto label_3358_2A51_35FD1_31887;
        }
    label_3358_2A4E_35FCE_31885:
        CheckExternalEvents(cs2, 0x2A4E);
        // 3358:2A4E xor CH,0x44
        CH = Alu8.Xor(CH, (byte)0x44);
    label_3358_2A51_35FD1_31887:
        CheckExternalEvents(cs2, 0x2A51);
        // 3358:2A51 cmp CX,1
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 3358:2A54 je short 0x2A61
        if (ZeroFlag)
        {
            goto label_3358_2A61_35FE1_31903;
        }
    label_3358_2A56_35FD6_31889:
        CheckExternalEvents(cs2, 0x2A56);
        // 3358:2A56 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2A57 jne short 0x2A26
        if (!ZeroFlag)
        {
            goto label_3358_2A26_35FA6_31870;
        }
    label_3358_2A59_35FD9_31895:
        CheckExternalEvents(cs2, 0x2A59);
        // 3358:2A59 pop DX
        DX = Stack.Pop16();
    label_3358_2A5A_35FDA_31897:
        CheckExternalEvents(cs2, 0x2A5A);
        // 3358:2A5A cmp BX,word ptr SS:[BP]
        Alu16.Sub(BX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2A5D je short 0x2A5A
        if (ZeroFlag)
        {
            goto label_3358_2A5A_35FDA_31897;
        }
    label_3358_2A5F_35FDF_31899:
        CheckExternalEvents(cs2, 0x2A5F);
        // 3358:2A5F jmp short 0x2A22
        goto label_3358_2A22_35FA2_31868;
    label_3358_2A61_35FE1_31903:
        CheckExternalEvents(cs2, 0x2A61);
        // 3358:2A61 pop DX
        DX = Stack.Pop16();
        // 3358:2A62 xor SI,SI
        SI = Alu16.Xor(SI, SI);
        // 3358:2A64 mov DI,SI
        DI = SI;
        // 3358:2A66 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2A67 ret far
        return FarRet((ushort)0x0000);
    label_3358_2A68_35FE8_19726:
        CheckExternalEvents(cs2, 0x2A68);
        // 3358:2A68 mov BX,0x004A
        BX = (ushort)0x004A;
        // 3358:2A6B mov DX,0x009C
        DX = (ushort)0x009C;
        // 3358:2A6E call near 0x0C10
        NearCall(cs2, 0x2A71, unknown_3358_0C10_34190);
    label_3358_2A71_35FF1_19730:
        CheckExternalEvents(cs2, 0x2A71);
        // 3358:2A71 mov DX,1
        DX = (ushort)0x0001;
        // 3358:2A74 mov AX,0xFB08
        AX = (ushort)0xFB08;
        // 3358:2A77 call near 0x2AB0
        NearCall(cs2, 0x2A7A, unknown_3358_2AB0_36030);
    label_3358_2A7A_35FFA_19756:
        CheckExternalEvents(cs2, 0x2A7A);
        // 3358:2A7A inc DX
        DX = Alu16.Inc(DX);
        // 3358:2A7B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:2A7D call near 0x2AB0
        NearCall(cs2, 0x2A80, unknown_3358_2AB0_36030);
    label_3358_2A80_36000_19762:
        CheckExternalEvents(cs2, 0x2A80);
        // 3358:2A80 mov DX,2
        DX = (ushort)0x0002;
    label_3358_2A83_36003_19764:
        CheckExternalEvents(cs2, 0x2A83);
        // 3358:2A83 mov AX,0xFAF8
        AX = (ushort)0xFAF8;
        // 3358:2A86 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:2A88 call near 0x2AB0
        NearCall(cs2, 0x2A8B, unknown_3358_2AB0_36030);
    label_3358_2A8B_3600B_19767:
        CheckExternalEvents(cs2, 0x2A8B);
        // 3358:2A8B sub DI,0x04F8
        DI = Alu16.Sub(DI, (ushort)0x04F8);
        // 3358:2A8F mov AX,0xF600
        AX = (ushort)0xF600;
        // 3358:2A92 call near 0x2AB0
        NearCall(cs2, 0x2A95, unknown_3358_2AB0_36030);
    label_3358_2A95_36015_19771:
        CheckExternalEvents(cs2, 0x2A95);
        // 3358:2A95 add DI,0x0508
        DI = Alu16.Add(DI, (ushort)0x0508);
        // 3358:2A99 inc DX
        DX = Alu16.Inc(DX);
        // 3358:2A9A mov AX,0xFB08
        AX = (ushort)0xFB08;
        // 3358:2A9D call near 0x2AB0
        NearCall(cs2, 0x2AA0, unknown_3358_2AB0_36030);
    label_3358_2AA0_36020_19776:
        CheckExternalEvents(cs2, 0x2AA0);
        // 3358:2AA0 add DI,0x04F8
        DI = Alu16.Add(DI, (ushort)0x04F8);
        // 3358:2AA4 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 3358:2AA6 call near 0x2AB0
        NearCall(cs2, 0x2AA9, unknown_3358_2AB0_36030);
    label_3358_2AA9_36029_19780:
        CheckExternalEvents(cs2, 0x2AA9);
        // 3358:2AA9 inc DX
        DX = Alu16.Inc(DX);
        // 3358:2AAA cmp DX,0x0026
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)38)));
        // 3358:2AAD jb short 0x2A83
        if (CarryFlag)
        {
            goto label_3358_2A83_36003_19764;
        }
    label_3358_2AAF_3602F_19785:
        CheckExternalEvents(cs2, 0x2AAF);
        // 3358:2AAF ret far
        return FarRet((ushort)0x0000);
    label_3358_2AD1_36051_16892:
        CheckExternalEvents(cs2, 0x2AD1);
        // 3358:2AD1 push CS
        Stack.Push16(CS);
        // 3358:2AD2 call near 0x0B0C
        NearCall(cs2, 0x2AD5, unknown_3358_0B0C_3408C);
    label_3358_2AD5_36055_16895:
        CheckExternalEvents(cs2, 0x2AD5);
        // 3358:2AD5 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 3358:2AD7 js short 0x2B1A
        if (SignFlag)
        {
            goto label_3358_2B1A_3609A_17284;
        }
    label_3358_2AD9_36059_16898:
        CheckExternalEvents(cs2, 0x2AD9);
        // 3358:2AD9 push CX
        Stack.Push16(CX);
        // 3358:2ADA push DS
        Stack.Push16(DS);
        // 3358:2ADB mov DS,word ptr CS:[0x2539]
        DS = UInt16[CS, (ushort)0x2539];
        // 3358:2AE0 call near 0x2C52
        NearCall(cs2, 0x2AE3, unknown_3358_2C52_361D2);
    label_3358_2AE3_36063_16970:
        CheckExternalEvents(cs2, 0x2AE3);
        // 3358:2AE3 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2AE4 pop CX
        CX = Stack.Pop16();
        // 3358:2AE5 mov BX,CX
        BX = CX;
    label_3358_2AE7_36067_16974:
        CheckExternalEvents(cs2, 0x2AE7);
        // 3358:2AE7 mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:2AEA sub BX,8
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2AED push BX
        Stack.Push16(BX);
        // 3358:2AEE push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2AF1 jns short 0x2AF7
        if (!SignFlag)
        {
            goto label_3358_2AF7_36077_16979;
        }
    label_3358_2AF3_36073_17099:
        CheckExternalEvents(cs2, 0x2AF3);
        // 3358:2AF3 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 3358:2AF5 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_3358_2AF7_36077_16979:
        CheckExternalEvents(cs2, 0x2AF7);
        // 3358:2AF7 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_2AFA_3607A_16981:
        CheckExternalEvents(cs2, 0x2AFA);
        // 3358:2AFA cmp AX,word ptr SS:[BP]
        Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2AFD je short 0x2AFA
        if (ZeroFlag)
        {
            goto label_3358_2AFA_3607A_16981;
        }
    label_3358_2AFF_3607F_16984:
        CheckExternalEvents(cs2, 0x2AFF);
        // 3358:2AFF call near 0x0C10
        NearCall(cs2, 0x2B02, unknown_3358_0C10_34190);
    label_3358_2B02_36082_16986:
        CheckExternalEvents(cs2, 0x2B02);
        // 3358:2B02 push BX
        Stack.Push16(BX);
        // 3358:2B03 push DX
        Stack.Push16(DX);
        // 3358:2B04 push DI
        Stack.Push16(DI);
        // 3358:2B05 call near 0x2BAC
        NearCall(cs2, 0x2B08, unknown_3358_2BAC_3612C);
    label_3358_2B08_36088_17017:
        CheckExternalEvents(cs2, 0x2B08);
        // 3358:2B08 pop DI
        DI = Stack.Pop16();
        // 3358:2B09 pop DX
        DX = Stack.Pop16();
        // 3358:2B0A pop BX
        BX = Stack.Pop16();
        // 3358:2B0B call near 0x2B56
        NearCall(cs2, 0x2B0E, unknown_3358_2B56_360D6);
    label_3358_2B0E_3608E_17063:
        CheckExternalEvents(cs2, 0x2B0E);
        // 3358:2B0E pop BX
        BX = Stack.Pop16();
        // 3358:2B0F call near 0x2572
        NearCall(cs2, 0x2B12, unknown_3358_2572_35AF2);
    label_3358_2B12_36092_17066:
        CheckExternalEvents(cs2, 0x2B12);
        // 3358:2B12 pop BX
        BX = Stack.Pop16();
        // 3358:2B13 cmp BX,0xFEC8
        Alu16.Sub(BX, (ushort)0xFEC8);
        // 3358:2B17 jg short 0x2AE7
        if (!ZeroFlag && SignFlag == OverflowFlag)
        {
            goto label_3358_2AE7_36067_16974;
        }
    label_3358_2B19_36099_17119:
        CheckExternalEvents(cs2, 0x2B19);
        // 3358:2B19 ret far
        return FarRet((ushort)0x0000);
    label_3358_2B1A_3609A_17284:
        CheckExternalEvents(cs2, 0x2B1A);
        // 3358:2B1A push CX
        Stack.Push16(CX);
        // 3358:2B1B push DS
        Stack.Push16(DS);
        // 3358:2B1C mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:2B21 call near 0x2C52
        NearCall(cs2, 0x2B24, unknown_3358_2C52_361D2);
    label_3358_2B24_360A4_17289:
        CheckExternalEvents(cs2, 0x2B24);
        // 3358:2B24 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2B25 pop CX
        CX = Stack.Pop16();
        // 3358:2B26 mov BX,0xFEC8
        BX = (ushort)0xFEC8;
    label_3358_2B29_360A9_17293:
        CheckExternalEvents(cs2, 0x2B29);
        // 3358:2B29 mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:2B2C push BX
        Stack.Push16(BX);
        // 3358:2B2D push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:2B30 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:2B32 jns short 0x2B38
        if (!SignFlag)
        {
            goto label_3358_2B38_360B8_17301;
        }
    label_3358_2B34_360B4_17298:
        CheckExternalEvents(cs2, 0x2B34);
        // 3358:2B34 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 3358:2B36 xor BX,BX
        BX = Alu16.Xor(BX, BX);
    label_3358_2B38_360B8_17301:
        CheckExternalEvents(cs2, 0x2B38);
        // 3358:2B38 call near 0x0C10
        NearCall(cs2, 0x2B3B, unknown_3358_0C10_34190);
    label_3358_2B3B_360BB_17302:
        CheckExternalEvents(cs2, 0x2B3B);
        // 3358:2B3B push BX
        Stack.Push16(BX);
        // 3358:2B3C push DX
        Stack.Push16(DX);
        // 3358:2B3D push DI
        Stack.Push16(DI);
        // 3358:2B3E call near 0x2C02
        NearCall(cs2, 0x2B41, unknown_3358_2C02_36182);
    label_3358_2B41_360C1_17315:
        CheckExternalEvents(cs2, 0x2B41);
        // 3358:2B41 pop DI
        DI = Stack.Pop16();
        // 3358:2B42 pop DX
        DX = Stack.Pop16();
        // 3358:2B43 pop BX
        BX = Stack.Pop16();
        // 3358:2B44 call near 0x2B56
        NearCall(cs2, 0x2B47, unknown_3358_2B56_360D6);
    label_3358_2B47_360C7_17320:
        CheckExternalEvents(cs2, 0x2B47);
        // 3358:2B47 pop BX
        BX = Stack.Pop16();
        // 3358:2B48 call near 0x2572
        NearCall(cs2, 0x2B4B, unknown_3358_2572_35AF2);
    label_3358_2B4B_360CB_17323:
        CheckExternalEvents(cs2, 0x2B4B);
        // 3358:2B4B pop BX
        BX = Stack.Pop16();
        // 3358:2B4C add BX,8
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2B4F cmp BX,0x0098
        Alu16.Sub(BX, (ushort)0x0098);
        // 3358:2B53 jl short 0x2B29
        if (SignFlag != OverflowFlag)
        {
            goto label_3358_2B29_360A9_17293;
        }
    label_3358_2B55_360D5_17363:
        CheckExternalEvents(cs2, 0x2B55);
        // 3358:2B55 ret far
        return FarRet((ushort)0x0000);
    label_3358_2CCA_3624A_18606:
        CheckExternalEvents(cs2, 0x2CCA);
        // 3358:2CCA or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:2CCC js short 0x2CFE
        if (!(SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:2CCC");
        }
    label_3358_2CFE_3627E_18609:
        CheckExternalEvents(cs2, 0x2CFE);
        // 3358:2CFE call near 0x2596
        NearCall(cs2, 0x2D01, unknown_3358_2596_35B16);
    label_3358_2D01_36281_18622:
        CheckExternalEvents(cs2, 0x2D01);
        // 3358:2D01 mov AX,0x0140
        AX = (ushort)0x0140;
        // 3358:2D04 mul CX
        uint result_3358_2D04_36284 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)CX)));
        DX = unchecked((ushort)(result_3358_2D04_36284 >> 16));
        AX = unchecked((ushort)result_3358_2D04_36284);
        // 3358:2D06 mov DX,AX
        DX = AX;
        // 3358:2D08 mov SI,0x0A00
        SI = (ushort)0x0A00;
        // 3358:2D0B mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_2D0E_3628E_18628:
        CheckExternalEvents(cs2, 0x2D0E);
        // 3358:2D0E push SI
        Stack.Push16(SI);
        // 3358:2D0F xor DI,DI
        DI = Alu16.Xor(DI, DI);
        // 3358:2D11 mov CX,DX
        CX = DX;
        // 3358:2D13 sub CX,SI
        CX = Alu16.Sub(CX, SI);
        // 3358:2D15 mov AX,DS
        AX = DS;
        // 3358:2D17 mov DS,word ptr CS:[0x2535]
        DS = UInt16[CS, (ushort)0x2535];
        // 3358:2D1C shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2D1E rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2D20 mov DS,AX
        DS = AX;
        // 3358:2D22 mov CX,0x0500
        CX = (ushort)0x0500;
        // 3358:2D25 mov AX,0x0707
        AX = (ushort)0x0707;
        // 3358:2D28 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:2D2A cmp DI,DX
        Alu16.Sub(DI, DX);
        // 3358:2D2C jae short 0x2D35
        if (!CarryFlag)
        {
            goto label_3358_2D35_362B5_18642;
        }
    label_3358_2D2E_362AE_18658:
        CheckExternalEvents(cs2, 0x2D2E);
        // 3358:2D2E mov CX,0x0500
        CX = (ushort)0x0500;
        // 3358:2D31 mov SI,DI
        SI = DI;
        // 3358:2D33 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_2D35_362B5_18642:
        CheckExternalEvents(cs2, 0x2D35);
        // 3358:2D35 pop SI
        SI = Stack.Pop16();
        // 3358:2D36 add SI,0x0A00
        SI = Alu16.Add(SI, (ushort)0x0A00);
        // 3358:2D3A call near 0x253D
        NearCall(cs2, 0x2D3D, unknown_3358_253D_35ABD);
    label_3358_2D3D_362BD_18654:
        CheckExternalEvents(cs2, 0x2D3D);
        // 3358:2D3D cmp SI,DX
        Alu16.Sub(SI, DX);
        // 3358:2D3F jbe short 0x2D0E
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_2D0E_3628E_18628;
        }
    label_3358_2D41_362C1_18662:
        CheckExternalEvents(cs2, 0x2D41);
        // 3358:2D41 ret far
        return FarRet((ushort)0x0000);
    label_3358_2D44_362C4_41516:
        CheckExternalEvents(cs2, 0x2D44);
        // 3358:2D44 mov BX,0xFEC0
        BX = (ushort)0xFEC0;
        // 3358:2D47 call near 0x2596
        NearCall(cs2, 0x2D4A, unknown_3358_2596_35B16);
    label_3358_2D4A_362CA_41521:
        CheckExternalEvents(cs2, 0x2D4A);
        // 3358:2D4A mov word ptr CS:[0x253B],0
        UInt16[CS, (ushort)0x253B] = (ushort)0x0000;
        // 3358:2D51 push BX
        Stack.Push16(BX);
        // 3358:2D52 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 3358:2D54 mov BX,CX
        BX = CX;
        // 3358:2D56 call near 0x0C10
        NearCall(cs2, 0x2D59, unknown_3358_0C10_34190);
    label_3358_2D59_362D9_41532:
        CheckExternalEvents(cs2, 0x2D59);
        // 3358:2D59 pop BX
        BX = Stack.Pop16();
        // 3358:2D5A mov SI,DI
        SI = DI;
        // 3358:2D5C mov DX,DI
        DX = DI;
        // 3358:2D5E call near 0x2588
        NearCall(cs2, 0x2D61, unknown_3358_2588_35B08);
    label_3358_2D61_362E1_41549:
        CheckExternalEvents(cs2, 0x2D61);
        // 3358:2D61 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
    label_3358_2D64_362E4_41550:
        CheckExternalEvents(cs2, 0x2D64);
        // 3358:2D64 push CX
        Stack.Push16(CX);
        // 3358:2D65 push SI
        Stack.Push16(SI);
        // 3358:2D66 mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:2D6B mov CX,DX
        CX = DX;
        // 3358:2D6D sub CX,SI
        CX = Alu16.Sub(CX, SI);
        // 3358:2D6F je short 0x2D7A
        if (ZeroFlag)
        {
            goto label_3358_2D7A_362FA_41557;
        }
    label_3358_2D71_362F1_41559:
        CheckExternalEvents(cs2, 0x2D71);
        // 3358:2D71 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2D73 mov DS,word ptr CS:[0x2535]
        DS = UInt16[CS, (ushort)0x2535];
        // 3358:2D78 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_2D7A_362FA_41557:
        CheckExternalEvents(cs2, 0x2D7A);
        // 3358:2D7A mov CX,DX
        CX = DX;
        // 3358:2D7C sub CX,DI
        CX = Alu16.Sub(CX, DI);
        // 3358:2D7E je short 0x2D8E
        if (ZeroFlag)
        {
            goto label_3358_2D8E_3630E_41565;
        }
    label_3358_2D80_36300_41567:
        CheckExternalEvents(cs2, 0x2D80);
        // 3358:2D80 mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:2D85 mov SI,word ptr CS:[0x01A3]
        SI = UInt16[CS, (ushort)0x01A3];
        // 3358:2D8A shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2D8C rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
    label_3358_2D8E_3630E_41565:
        CheckExternalEvents(cs2, 0x2D8E);
        // 3358:2D8E pop SI
        SI = Stack.Pop16();
        // 3358:2D8F pop CX
        CX = Stack.Pop16();
        // 3358:2D90 inc word ptr CS:[0x253B]
        UInt16[CS, (ushort)0x253B] = Alu16.Inc(UInt16[CS, (ushort)0x253B]);
        // 3358:2D95 mov AX,word ptr CS:[0x253B]
        AX = UInt16[CS, (ushort)0x253B];
        // 3358:2D99 mov AH,6
        AH = (byte)0x06;
        // 3358:2D9B mul AH
        ushort result_3358_2D9B_3631B = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)AH)));
        AH = unchecked((byte)(result_3358_2D9B_3631B >> 8));
        AL = unchecked((byte)result_3358_2D9B_3631B);
    label_3358_2D9D_3631D_41579:
        CheckExternalEvents(cs2, 0x2D9D);
        // 3358:2D9D mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2DA0 sub BX,CX
        BX = Alu16.Sub(BX, CX);
        // 3358:2DA2 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 3358:2DA4 jb short 0x2D9D
        if (CarryFlag)
        {
            goto label_3358_2D9D_3631D_41579;
        }
    label_3358_2DA6_36326_41585:
        CheckExternalEvents(cs2, 0x2DA6);
        // 3358:2DA6 mov BX,0xFEC0
        BX = (ushort)0xFEC0;
        // 3358:2DA9 je short 0x2DB2
        if (ZeroFlag)
        {
            goto label_3358_2DB2_36332_41588;
        }
    label_3358_2DAB_3632B_41590:
        CheckExternalEvents(cs2, 0x2DAB);
        VerifySpeculativeEntryOrFail(cs2, 0x2DAB, [(byte)0x03, (byte)0xDB]);
        // 3358:2DAB add BX,BX
        BX = Alu16.Add(BX, BX);
        VerifySpeculativeEntryOrFail(cs2, 0x2DAD, [(byte)0x2E, (byte)0xFF, (byte)0x06, (byte)0x3B, (byte)0x25]);
        // 3358:2DAD inc word ptr CS:[0x253B]
        UInt16[CS, (ushort)0x253B] = Alu16.Inc(UInt16[CS, (ushort)0x253B]);
    label_3358_2DB2_36332_41588:
        CheckExternalEvents(cs2, 0x2DB2);
        // 3358:2DB2 add SI,BX
        SI = Alu16.Add(SI, BX);
        // 3358:2DB4 cmp SI,word ptr CS:[0x01A3]
        Alu16.Sub(SI, UInt16[CS, (ushort)0x01A3]);
        // 3358:2DB9 jb short 0x2DBF
        if (CarryFlag)
        {
            goto label_3358_2DBF_3633F_41596;
        }
    label_3358_2DBB_3633B_41598:
        CheckExternalEvents(cs2, 0x2DBB);
        // 3358:2DBB cmp SI,DX
        Alu16.Sub(SI, DX);
        // 3358:2DBD jb short 0x2D64
        if (CarryFlag)
        {
            goto label_3358_2D64_362E4_41550;
        }
    label_3358_2DBF_3633F_41596:
        CheckExternalEvents(cs2, 0x2DBF);
        // 3358:2DBF ret far
        return FarRet((ushort)0x0000);
    label_3358_2DC0_36340_14578:
        CheckExternalEvents(cs2, 0x2DC0);
        // 3358:2DC0 mov CX,0x00C8
        CX = (ushort)0x00C8;
    label_3358_2DC3_36343_6484:
        CheckExternalEvents(cs2, 0x2DC3);
        // 3358:2DC3 mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2DC6 mov SI,0x2FD7
        SI = (ushort)0x2FD7;
        // 3358:2DC9 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2DCB shr CX,1
        CX = Alu16.Shr(CX, 1);
    label_3358_2DCD_3634D_6489:
        CheckExternalEvents(cs2, 0x2DCD);
        // 3358:2DCD lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:2DCF or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:2DD1 js short 0x2DF7
        if (SignFlag)
        {
            goto label_3358_2DF7_36377_6533;
        }
    label_3358_2DD3_36353_6492:
        CheckExternalEvents(cs2, 0x2DD3);
        // 3358:2DD3 push CX
        Stack.Push16(CX);
        // 3358:2DD4 push SI
        Stack.Push16(SI);
        // 3358:2DD5 add AX,word ptr CS:[0x01A3]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x01A3]);
        // 3358:2DDA mov DI,AX
        DI = AX;
        // 3358:2DDC xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_3358_2DDE_3635E_6498:
        CheckExternalEvents(cs2, 0x2DDE);
        // 3358:2DDE push DI
        Stack.Push16(DI);
        // 3358:2DDF mov DX,0x0050
        DX = (ushort)0x0050;
    label_3358_2DE2_36362_6500:
        CheckExternalEvents(cs2, 0x2DE2);
        // 3358:2DE2 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2DE3 add DI,3
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:2DE6 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2DE7 jne short 0x2DE2
        if (!ZeroFlag)
        {
            goto label_3358_2DE2_36362_6500;
        }
    label_3358_2DE9_36369_6505:
        CheckExternalEvents(cs2, 0x2DE9);
        // 3358:2DE9 pop DI
        DI = Stack.Pop16();
        // 3358:2DEA add DI,0x0500
        DI = Alu16.Add(DI, (ushort)0x0500);
        // 3358:2DEE loop 0x2DDE
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2DDE_3635E_6498;
        }
    label_3358_2DF0_36370_6510:
        CheckExternalEvents(cs2, 0x2DF0);
        // 3358:2DF0 call near 0x2572
        NearCall(cs2, 0x2DF3, unknown_3358_2572_35AF2);
    label_3358_2DF3_36373_6527:
        CheckExternalEvents(cs2, 0x2DF3);
        // 3358:2DF3 pop SI
        SI = Stack.Pop16();
        // 3358:2DF4 pop CX
        CX = Stack.Pop16();
        // 3358:2DF5 jmp short 0x2DCD
        goto label_3358_2DCD_3634D_6489;
    label_3358_2DF7_36377_6533:
        CheckExternalEvents(cs2, 0x2DF7);
        // 3358:2DF7 push CS
        Stack.Push16(CS);
        // 3358:2DF8 call near 0x0B0C
        NearCall(cs2, 0x2DFB, unknown_3358_0B0C_3408C);
    label_3358_2DFB_3637B_6536:
        CheckExternalEvents(cs2, 0x2DFB);
        // 3358:2DFB mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2DFE mov SI,0x2FD7
        SI = (ushort)0x2FD7;
    label_3358_2E01_36381_6539:
        CheckExternalEvents(cs2, 0x2E01);
        // 3358:2E01 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:2E03 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:2E05 js short 0x2E2B
        if (SignFlag)
        {
            goto label_3358_2E2B_363AB_6567;
        }
    label_3358_2E07_36387_6542:
        CheckExternalEvents(cs2, 0x2E07);
        // 3358:2E07 push CX
        Stack.Push16(CX);
        // 3358:2E08 push SI
        Stack.Push16(SI);
        // 3358:2E09 add AX,word ptr CS:[0x01A3]
        AX = Alu16.Add(AX, UInt16[CS, (ushort)0x01A3]);
        // 3358:2E0E mov DI,AX
        DI = AX;
    label_3358_2E10_36390_6547:
        CheckExternalEvents(cs2, 0x2E10);
        // 3358:2E10 push DI
        Stack.Push16(DI);
        // 3358:2E11 mov DX,0x0050
        DX = (ushort)0x0050;
    label_3358_2E14_36394_6549:
        CheckExternalEvents(cs2, 0x2E14);
        // 3358:2E14 mov SI,DI
        SI = DI;
        // 3358:2E16 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2E17 add DI,3
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)3)));
        // 3358:2E1A dec DX
        DX = Alu16.Dec(DX);
        // 3358:2E1B jne short 0x2E14
        if (!ZeroFlag)
        {
            goto label_3358_2E14_36394_6549;
        }
    label_3358_2E1D_3639D_6555:
        CheckExternalEvents(cs2, 0x2E1D);
        // 3358:2E1D pop DI
        DI = Stack.Pop16();
        // 3358:2E1E add DI,0x0500
        DI = Alu16.Add(DI, (ushort)0x0500);
        // 3358:2E22 loop 0x2E10
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2E10_36390_6547;
        }
    label_3358_2E24_363A4_6560:
        CheckExternalEvents(cs2, 0x2E24);
        // 3358:2E24 call near 0x2572
        NearCall(cs2, 0x2E27, unknown_3358_2572_35AF2);
    label_3358_2E27_363A7_6562:
        CheckExternalEvents(cs2, 0x2E27);
        // 3358:2E27 pop SI
        SI = Stack.Pop16();
        // 3358:2E28 pop CX
        CX = Stack.Pop16();
        // 3358:2E29 jmp short 0x2E01
        goto label_3358_2E01_36381_6539;
    label_3358_2E2B_363AB_6567:
        CheckExternalEvents(cs2, 0x2E2B);
        // 3358:2E2B ret far
        return FarRet((ushort)0x0000);
    label_3358_2EEA_3646A_28014:
        CheckExternalEvents(cs2, 0x2EEA);
        // 3358:2EEA mov BX,word ptr SS:[BP]
        BX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:2EED mov SI,0x2EE8
        SI = (ushort)0x2EE8;
        // 3358:2EF0 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2EF2 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:2EF4 shr CX,1
        CX = Alu16.Shr(CX, 1);
    label_3358_2EF6_36476_28020:
        CheckExternalEvents(cs2, 0x2EF6);
        // 3358:2EF6 cmp SI,0x2E66
        Alu16.Sub(SI, (ushort)0x2E66);
        // 3358:2EFA jbe short 0x2F24
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_2F24_364A4_28047;
        }
    label_3358_2EFC_3647C_28022:
        CheckExternalEvents(cs2, 0x2EFC);
        // 3358:2EFC sub SI,2
        SI = Alu16.Sub(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:2EFF mov AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        // 3358:2F02 push CX
        Stack.Push16(CX);
        // 3358:2F03 mov DI,AX
        DI = AX;
        // 3358:2F05 add DI,word ptr CS:[0x01A3]
        DI = Alu16.Add(DI, UInt16[CS, (ushort)0x01A3]);
        // 3358:2F0A xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_3358_2F0C_3648C_28029:
        CheckExternalEvents(cs2, 0x2F0C);
        // 3358:2F0C push DI
        Stack.Push16(DI);
        // 3358:2F0D mov DX,0x0028
        DX = (ushort)0x0028;
    label_3358_2F10_36490_28031:
        CheckExternalEvents(cs2, 0x2F10);
        // 3358:2F10 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2F11 add DI,7
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 3358:2F14 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2F15 jne short 0x2F10
        if (!ZeroFlag)
        {
            goto label_3358_2F10_36490_28031;
        }
    label_3358_2F17_36497_28036:
        CheckExternalEvents(cs2, 0x2F17);
        // 3358:2F17 pop DI
        DI = Stack.Pop16();
        // 3358:2F18 add DI,0x0A00
        DI = Alu16.Add(DI, (ushort)0x0A00);
        // 3358:2F1C loop 0x2F0C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2F0C_3648C_28029;
        }
    label_3358_2F1E_3649E_28041:
        CheckExternalEvents(cs2, 0x2F1E);
        // 3358:2F1E call near 0x2572
        NearCall(cs2, 0x2F21, unknown_3358_2572_35AF2);
    label_3358_2F21_364A1_28043:
        CheckExternalEvents(cs2, 0x2F21);
        // 3358:2F21 pop CX
        CX = Stack.Pop16();
        // 3358:2F22 jmp short 0x2EF6
        goto label_3358_2EF6_36476_28020;
    label_3358_2F24_364A4_28047:
        CheckExternalEvents(cs2, 0x2F24);
        // 3358:2F24 push CS
        Stack.Push16(CS);
        // 3358:2F25 call near 0x0B0C
        NearCall(cs2, 0x2F28, unknown_3358_0B0C_3408C);
    label_3358_2F28_364A8_28050:
        CheckExternalEvents(cs2, 0x2F28);
        // 3358:2F28 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:2F2A or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:2F2C js short 0x2F52
        if (SignFlag)
        {
            goto label_3358_2F52_364D2_28078;
        }
    label_3358_2F2E_364AE_28054:
        CheckExternalEvents(cs2, 0x2F2E);
        // 3358:2F2E push CX
        Stack.Push16(CX);
        // 3358:2F2F push SI
        Stack.Push16(SI);
        // 3358:2F30 mov SI,AX
        SI = AX;
        // 3358:2F32 add SI,word ptr CS:[0x01A3]
        SI = Alu16.Add(SI, UInt16[CS, (ushort)0x01A3]);
    label_3358_2F37_364B7_28059:
        CheckExternalEvents(cs2, 0x2F37);
        // 3358:2F37 push SI
        Stack.Push16(SI);
        // 3358:2F38 mov DX,0x0028
        DX = (ushort)0x0028;
    label_3358_2F3B_364BB_28061:
        CheckExternalEvents(cs2, 0x2F3B);
        // 3358:2F3B mov DI,SI
        DI = SI;
        // 3358:2F3D movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:2F3E add SI,7
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)7)));
        // 3358:2F41 dec DX
        DX = Alu16.Dec(DX);
        // 3358:2F42 jne short 0x2F3B
        if (!ZeroFlag)
        {
            goto label_3358_2F3B_364BB_28061;
        }
    label_3358_2F44_364C4_28067:
        CheckExternalEvents(cs2, 0x2F44);
        // 3358:2F44 pop SI
        SI = Stack.Pop16();
        // 3358:2F45 add SI,0x0A00
        SI = Alu16.Add(SI, (ushort)0x0A00);
        // 3358:2F49 loop 0x2F37
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_2F37_364B7_28059;
        }
    label_3358_2F4B_364CB_28072:
        CheckExternalEvents(cs2, 0x2F4B);
        // 3358:2F4B call near 0x2572
        NearCall(cs2, 0x2F4E, unknown_3358_2572_35AF2);
    label_3358_2F4E_364CE_28074:
        CheckExternalEvents(cs2, 0x2F4E);
        // 3358:2F4E pop SI
        SI = Stack.Pop16();
        // 3358:2F4F pop CX
        CX = Stack.Pop16();
        // 3358:2F50 jmp short 0x2F28
        goto label_3358_2F28_364A8_28050;
    label_3358_2F52_364D2_28078:
        CheckExternalEvents(cs2, 0x2F52);
        // 3358:2F52 ret far
        return FarRet((ushort)0x0000);
    label_3358_2F53_364D3_32635:
        CheckExternalEvents(cs2, 0x2F53);
        // 3358:2F53 call near 0x2596
        NearCall(cs2, 0x2F56, unknown_3358_2596_35B16);
    label_3358_2F56_364D6_32637:
        CheckExternalEvents(cs2, 0x2F56);
        // 3358:2F56 push DS
        Stack.Push16(DS);
        // 3358:2F57 mov DS,SI
        DS = SI;
        // 3358:2F59 call near 0x2FC1
        NearCall(cs2, 0x2F5C, unknown_3358_2FC1_36541);
    label_3358_2F5C_364DC_32641:
        CheckExternalEvents(cs2, 0x2F5C);
        // 3358:2F5C call near 0x2FF9
        NearCall(cs2, 0x2F5F, unknown_3358_2FF9_36579);
    label_3358_2F5F_364DF_32643:
        CheckExternalEvents(cs2, 0x2F5F);
        // 3358:2F5F call near 0x3031
        NearCall(cs2, 0x2F62, unknown_3358_3031_365B1);
    label_3358_2F62_364E2_32697:
        CheckExternalEvents(cs2, 0x2F62);
        // 3358:2F62 push CS
        Stack.Push16(CS);
        // 3358:2F63 call near 0x0B0C
        NearCall(cs2, 0x2F66, unknown_3358_0B0C_3408C);
    label_3358_2F66_364E6_32700:
        CheckExternalEvents(cs2, 0x2F66);
        // 3358:2F66 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2F67 call near 0x3031
        NearCall(cs2, 0x2F6A, unknown_3358_3031_365B1);
    label_3358_2F6A_364EA_32703:
        CheckExternalEvents(cs2, 0x2F6A);
        // 3358:2F6A call near 0x2FF9
        NearCall(cs2, 0x2F6D, unknown_3358_2FF9_36579);
    label_3358_2F6D_364ED_32705:
        CheckExternalEvents(cs2, 0x2F6D);
        // 3358:2F6D call near 0x2FC1
        NearCall(cs2, 0x2F70, unknown_3358_2FC1_36541);
    label_3358_2F70_364F0_32707:
        CheckExternalEvents(cs2, 0x2F70);
        // 3358:2F70 ret far
        return FarRet((ushort)0x0000);
    label_3358_2F87_36507_32510:
        CheckExternalEvents(cs2, 0x2F87);
        // 3358:2F87 call near 0x2596
        NearCall(cs2, 0x2F8A, unknown_3358_2596_35B16);
    label_3358_2F8A_3650A_32512:
        CheckExternalEvents(cs2, 0x2F8A);
        // 3358:2F8A push DS
        Stack.Push16(DS);
        // 3358:2F8B mov DS,SI
        DS = SI;
        // 3358:2F8D call near 0x2FC1
        NearCall(cs2, 0x2F90, unknown_3358_2FC1_36541);
    label_3358_2F90_36510_32516:
        CheckExternalEvents(cs2, 0x2F90);
        // 3358:2F90 call near 0x2FF9
        NearCall(cs2, 0x2F93, unknown_3358_2FF9_36579);
    label_3358_2F93_36513_32569:
        CheckExternalEvents(cs2, 0x2F93);
        // 3358:2F93 push CS
        Stack.Push16(CS);
        // 3358:2F94 call near 0x0B0C
        NearCall(cs2, 0x2F97, unknown_3358_0B0C_3408C);
    label_3358_2F97_36517_32572:
        CheckExternalEvents(cs2, 0x2F97);
        // 3358:2F97 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2F98 call near 0x2FF9
        NearCall(cs2, 0x2F9B, unknown_3358_2FF9_36579);
    label_3358_2F9B_3651B_32575:
        CheckExternalEvents(cs2, 0x2F9B);
        // 3358:2F9B call near 0x2FC1
        NearCall(cs2, 0x2F9E, unknown_3358_2FC1_36541);
    label_3358_2F9E_3651E_32577:
        CheckExternalEvents(cs2, 0x2F9E);
        // 3358:2F9E ret far
        return FarRet((ushort)0x0000);
    label_3358_2F9F_3651F_32431:
        CheckExternalEvents(cs2, 0x2F9F);
        // 3358:2F9F call near 0x2596
        NearCall(cs2, 0x2FA2, unknown_3358_2596_35B16);
    label_3358_2FA2_36522_32433:
        CheckExternalEvents(cs2, 0x2FA2);
        // 3358:2FA2 push DS
        Stack.Push16(DS);
        // 3358:2FA3 mov DS,SI
        DS = SI;
        // 3358:2FA5 call near 0x2FC1
        NearCall(cs2, 0x2FA8, unknown_3358_2FC1_36541);
    label_3358_2FA8_36528_32486:
        CheckExternalEvents(cs2, 0x2FA8);
        // 3358:2FA8 call near 0x2FC1
        NearCall(cs2, 0x2FAB, unknown_3358_2FC1_36541);
    label_3358_2FAB_3652B_32488:
        CheckExternalEvents(cs2, 0x2FAB);
        // 3358:2FAB call near 0x2FC1
        NearCall(cs2, 0x2FAE, unknown_3358_2FC1_36541);
    label_3358_2FAE_3652E_32490:
        CheckExternalEvents(cs2, 0x2FAE);
        // 3358:2FAE push CS
        Stack.Push16(CS);
        // 3358:2FAF call near 0x0B0C
        NearCall(cs2, 0x2FB2, unknown_3358_0B0C_3408C);
    label_3358_2FB2_36532_32493:
        CheckExternalEvents(cs2, 0x2FB2);
        // 3358:2FB2 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:2FB3 call near 0x2FC1
        NearCall(cs2, 0x2FB6, unknown_3358_2FC1_36541);
    label_3358_2FB6_36536_32496:
        CheckExternalEvents(cs2, 0x2FB6);
        // 3358:2FB6 ret far
        return FarRet((ushort)0x0000);
    label_3358_3130_366B0_19995:
        CheckExternalEvents(cs2, 0x3130);
        // 3358:3130 call near 0x2596
        NearCall(cs2, 0x3133, unknown_3358_2596_35B16);
    label_3358_3133_366B3_19997:
        CheckExternalEvents(cs2, 0x3133);
        // 3358:3133 mov DS,word ptr CS:[0x2535]
        DS = UInt16[CS, (ushort)0x2535];
        // 3358:3138 mov AX,word ptr CS:[0x01A3]
        AX = UInt16[CS, (ushort)0x01A3];
        // 3358:313C mov word ptr CS:[0x3118],AX
        UInt16[CS, (ushort)0x3118] = AX;
        // 3358:3140 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:3142 mov CX,0x0101
        CX = (ushort)0x0101;
        // 3358:3145 js short 0x314A
        if (SignFlag)
        {
            goto label_3358_314A_366CA_20006;
        }
    label_3358_3147_366C7_20004:
        CheckExternalEvents(cs2, 0x3147);
        // 3358:3147 mov CX,0xFF11
        CX = (ushort)0xFF11;
    label_3358_314A_366CA_20006:
        CheckExternalEvents(cs2, 0x314A);
        // 3358:314A push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:314D push CX
        Stack.Push16(CX);
        // 3358:314E push BP
        Stack.Push16(BP);
        // 3358:314F xor CH,CH
        CH = Alu8.Xor(CH, CH);
        // 3358:3151 mov BX,CX
        BX = CX;
        // 3358:3153 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:3155 mov AX,word ptr CS:[BX+0x30F0]
        AX = UInt16[CS, (ushort)(BX + (short)12528)];
        // 3358:315A call near 0x316D
        NearCall(cs2, 0x315D, unknown_3358_316D_366ED);
    label_3358_315D_366DD_20073:
        CheckExternalEvents(cs2, 0x315D);
        // 3358:315D pop BP
        BP = Stack.Pop16();
        // 3358:315E pop CX
        CX = Stack.Pop16();
        // 3358:315F pop BX
        BX = Stack.Pop16();
        // 3358:3160 call near 0x253D
        NearCall(cs2, 0x3163, unknown_3358_253D_35ABD);
    label_3358_3163_366E3_20078:
        CheckExternalEvents(cs2, 0x3163);
        // 3358:3163 add CL,CH
        CL = Alu8.Add(CL, CH);
        // 3358:3165 je short 0x316C
        if (ZeroFlag)
        {
            goto label_3358_316C_366EC_20097;
        }
    label_3358_3167_366E7_20081:
        CheckExternalEvents(cs2, 0x3167);
        // 3358:3167 cmp CL,0x11
        Alu8.Sub(CL, (byte)0x11);
        // 3358:316A jb short 0x314A
        if (CarryFlag)
        {
            goto label_3358_314A_366CA_20006;
        }
    label_3358_316C_366EC_20097:
        CheckExternalEvents(cs2, 0x316C);
        // 3358:316C ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0154_336D4(int loadOffset)
    {
    label_3358_0154_336D4_1009:
        CheckExternalEvents(cs2, 0x0154);
        // 3358:0154 jmp near 0x0975
    label_3358_0975_33EF5_1011:
        CheckExternalEvents(cs2, 0x0975);
        // 3358:0975 mov byte ptr CS:[0x01BD],AL
        UInt8[CS, (ushort)0x01BD] = AL;
        // 3358:0979 pushf
        Stack.Push16(FlagRegister16);
        // 3358:097A sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_3358_097B_33EFB_1015:
        CheckExternalEvents(cs2, 0x097B);
        // 3358:097B mov AX,0x0040
        AX = (ushort)0x0040;
        // 3358:097E mov ES,AX
        ES = AX;
        // 3358:0980 mov DX,word ptr ES:[0x0063]
        DX = UInt16[ES, (ushort)0x0063];
        // 3358:0985 add DL,6
        DL = Alu8.Add(DL, (byte)0x06);
        // 3358:0988 mov word ptr CS:[0x019F],DX
        UInt16[CS, (ushort)0x019F] = DX;
        // 3358:098D in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 3358:098E and AL,8
        AL = Alu8.And(AL, (byte)0x08);
        // 3358:0990 call near 0x09B8
        NearCall(cs2, 0x0993, unknown_3358_09B8_33F38);
    label_3358_0993_33F13_1055:
        CheckExternalEvents(cs2, 0x0993);
        // 3358:0993 jae short 0x09B4
        if (!CarryFlag)
        {
            goto label_3358_09B4_33F34_1072;
        }
    label_3358_0995_33F15_1057:
        CheckExternalEvents(cs2, 0x0995);
        // 3358:0995 call near 0x09B8
        NearCall(cs2, 0x0998, unknown_3358_09B8_33F38);
    label_3358_0998_33F18_1059:
        CheckExternalEvents(cs2, 0x0998);
        // 3358:0998 jae short 0x09B4
        if (!CarryFlag)
        {
            goto label_3358_09B4_33F34_1072;
        }
    label_3358_099A_33F1A_1061:
        CheckExternalEvents(cs2, 0x099A);
        // 3358:099A mov DI,SI
        DI = SI;
        // 3358:099C mov byte ptr CS:[0x01A2],AH
        UInt8[CS, (ushort)0x01A2] = AH;
        // 3358:09A1 call near 0x09B8
        NearCall(cs2, 0x09A4, unknown_3358_09B8_33F38);
    label_3358_09A4_33F24_1066:
        CheckExternalEvents(cs2, 0x09A4);
        // 3358:09A4 jae short 0x09B4
        if (!CarryFlag)
        {
            goto label_3358_09B4_33F34_1072;
        }
    label_3358_09A6_33F26_1068:
        CheckExternalEvents(cs2, 0x09A6);
        // 3358:09A6 cmp SI,DI
        Alu16.Sub(SI, DI);
        // 3358:09A8 not byte ptr CS:[0x01A1]
        UInt8[CS, (ushort)0x01A1] = unchecked((byte)~UInt8[CS, (ushort)0x01A1]);
        // 3358:09AD jae short 0x09B4
        if (!CarryFlag)
        {
            goto label_3358_09B4_33F34_1072;
        }
    label_3358_09AF_33F2F_33356:
        CheckExternalEvents(cs2, 0x09AF);
        // 3358:09AF mov byte ptr CS:[0x01A2],AH
        UInt8[CS, (ushort)0x01A2] = AH;
    label_3358_09B4_33F34_1072:
        CheckExternalEvents(cs2, 0x09B4);
        // 3358:09B4 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_09B5_33F35_1074:
        CheckExternalEvents(cs2, 0x09B5);
        // 3358:09B5 jmp near 0x0B0C
        return unknown_3358_0B0C_3408C(0x0000);
    }

    public virtual Action unknown_3358_0157_336D7(int loadOffset)
    {
    label_3358_0157_336D7_17544:
        CheckExternalEvents(cs2, 0x0157);
        // 3358:0157 jmp near 0x1F4C
    label_3358_1F4C_354CC_17546:
        CheckExternalEvents(cs2, 0x1F4C);
        // 3358:1F4C mov word ptr CS:[0x01A7],DI
        UInt16[CS, (ushort)0x01A7] = DI;
        // 3358:1F51 mov word ptr CS:[0x01A9],ES
        UInt16[CS, (ushort)0x01A9] = ES;
        // 3358:1F56 mov word ptr CS:[0x01BB],BP
        UInt16[CS, (ushort)0x01BB] = BP;
        // 3358:1F5B mov word ptr CS:[0x01A5],SI
        UInt16[CS, (ushort)0x01A5] = SI;
        // 3358:1F60 mov word ptr CS:[0x01B7],0x0024
        UInt16[CS, (ushort)0x01B7] = (ushort)0x0024;
        // 3358:1F67 mov word ptr CS:[0x01AB],BX
        UInt16[CS, (ushort)0x01AB] = BX;
        // 3358:1F6C mov word ptr CS:[0x1CB2],0x0504
        UInt16[CS, (ushort)0x1CB2] = (ushort)0x0504;
        // 3358:1F73 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:1F75 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:1F77 shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 3358:1F79 jns short 0x1FE3
        if (!SignFlag)
        {
            goto label_3358_1FE3_35563_32050;
        }
    label_3358_1F7B_354FB_17558:
        CheckExternalEvents(cs2, 0x1F7B);
        // 3358:1F7B neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:1F7D add BP,AX
        BP = Alu16.Add(BP, AX);
        // 3358:1F7F mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1F82 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1F85 neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1F87 mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:1F8C mov word ptr CS:[0x01B9],0x08F7
        UInt16[CS, (ushort)0x01B9] = (ushort)0x08F7;
        // 3358:1F93 add word ptr CS:[0x01BB],0x02B0
        UInt16[CS, (ushort)0x01BB] = Alu16.Add(UInt16[CS, (ushort)0x01BB], (ushort)0x02B0);
        // 3358:1F9A add DI,0x008C
        DI = Alu16.Add(DI, (ushort)0x008C);
        // 3358:1F9E call near 0x2025
        NearCall(cs2, 0x1FA1, unknown_3358_2025_355A5);
    label_3358_1FA1_35521_17670:
        CheckExternalEvents(cs2, 0x1FA1);
        // 3358:1FA1 sub BP,8
        BP = Alu16.Sub(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:1FA4 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1FA7 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1FAA neg CX
        CX = Alu16.Sub((ushort)0x0000, CX);
        CarryFlag = CX != (ushort)0x0000;
        // 3358:1FAC je short 0x1FC5
        if (ZeroFlag)
        {
            goto label_3358_1FC5_35545_17902;
        }
    label_3358_1FAE_3552E_17676:
        CheckExternalEvents(cs2, 0x1FAE);
        // 3358:1FAE mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:1FB3 add DI,0x06CC
        DI = Alu16.Add(DI, (ushort)0x06CC);
        // 3358:1FB7 call near 0x2025
        NearCall(cs2, 0x1FBA, unknown_3358_2025_355A5);
    label_3358_1FBA_3553A_17690:
        CheckExternalEvents(cs2, 0x1FBA);
        // 3358:1FBA call near 0x2123
        NearCall(cs2, 0x1FBD, unknown_3358_2123_356A3);
    label_3358_1FBD_3553D_17890:
        CheckExternalEvents(cs2, 0x1FBD);
        // 3358:1FBD dec word ptr CS:[0x01B7]
        UInt16[CS, (ushort)0x01B7] = Alu16.Dec(UInt16[CS, (ushort)0x01B7]);
        // 3358:1FC2 jne short 0x1FA1
        if (!ZeroFlag)
        {
            goto label_3358_1FA1_35521_17670;
        }
    label_3358_1FC4_35544_26189:
        CheckExternalEvents(cs2, 0x1FC4);
        // 3358:1FC4 ret far
        return FarRet((ushort)0x0000);
    label_3358_1FC5_35545_17902:
        CheckExternalEvents(cs2, 0x1FC5);
        // 3358:1FC5 mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:1FCA mov word ptr CS:[0x01B9],0x092F
        UInt16[CS, (ushort)0x01B9] = (ushort)0x092F;
        // 3358:1FD1 add word ptr CS:[0x01BB],8
        UInt16[CS, (ushort)0x01BB] = Alu16.Add(UInt16[CS, (ushort)0x01BB], unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:1FD7 add DI,0x06CC
        DI = Alu16.Add(DI, (ushort)0x06CC);
        // 3358:1FDB call near 0x2025
        NearCall(cs2, 0x1FDE, unknown_3358_2025_355A5);
    label_3358_1FDE_3555E_17908:
        CheckExternalEvents(cs2, 0x1FDE);
        // 3358:1FDE call near 0x2123
        NearCall(cs2, 0x1FE1, unknown_3358_2123_356A3);
    label_3358_1FE1_35561_17910:
        CheckExternalEvents(cs2, 0x1FE1);
        // 3358:1FE1 jmp short 0x201D
        goto label_3358_201D_3559D_17912;
    label_3358_1FE3_35563_32050:
        CheckExternalEvents(cs2, 0x1FE3);
        // 3358:1FE3 add BP,AX
        BP = Alu16.Add(BP, AX);
        // 3358:1FE5 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:1FE8 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:1FEB mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:1FF0 mov word ptr CS:[0x01B9],0x092F
        UInt16[CS, (ushort)0x01B9] = (ushort)0x092F;
        // 3358:1FF7 add word ptr CS:[0x01BB],0x02B8
        UInt16[CS, (ushort)0x01BB] = Alu16.Add(UInt16[CS, (ushort)0x01BB], (ushort)0x02B8);
        // 3358:1FFE add DI,0x008C
        DI = Alu16.Add(DI, (ushort)0x008C);
        // 3358:2002 call near 0x2025
        NearCall(cs2, 0x2005, unknown_3358_2025_355A5);
    label_3358_2005_35585_17915:
        CheckExternalEvents(cs2, 0x2005);
        // 3358:2005 add BP,8
        BP = Alu16.Add(BP, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2008 mov CX,word ptr SS:[BP]
        CX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:200B mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:200E mov DI,word ptr CS:[0x01A5]
        DI = UInt16[CS, (ushort)0x01A5];
        // 3358:2013 add DI,0x06CC
        DI = Alu16.Add(DI, (ushort)0x06CC);
        // 3358:2017 call near 0x2025
        NearCall(cs2, 0x201A, unknown_3358_2025_355A5);
    label_3358_201A_3559A_17922:
        CheckExternalEvents(cs2, 0x201A);
        // 3358:201A call near 0x2153
        NearCall(cs2, 0x201D, unknown_3358_2153_356D3);
    label_3358_201D_3559D_17912:
        CheckExternalEvents(cs2, 0x201D);
        // 3358:201D dec word ptr CS:[0x01B7]
        UInt16[CS, (ushort)0x01B7] = Alu16.Dec(UInt16[CS, (ushort)0x01B7]);
        // 3358:2022 jne short 0x2005
        if (!ZeroFlag)
        {
            goto label_3358_2005_35585_17915;
        }
    label_3358_2024_355A4_17943:
        CheckExternalEvents(cs2, 0x2024);
        // 3358:2024 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_015A_336DA(int loadOffset)
    {
    label_3358_015A_336DA_11059:
        CheckExternalEvents(cs2, 0x015A);
        // 3358:015A jmp near 0x3200
        goto label_3358_3200_36780_11061;
    label_3358_276C_35CEC_11071:
        CheckExternalEvents(cs2, 0x276C);
        // 3358:276C mov CX,word ptr CS:[0x2768]
        CX = UInt16[CS, (ushort)0x2768];
        // 3358:2771 mov SI,word ptr CS:[0x276A]
        SI = UInt16[CS, (ushort)0x276A];
        // 3358:2776 push CX
        Stack.Push16(CX);
        // 3358:2777 push SI
        Stack.Push16(SI);
        // 3358:2778 call near 0x27E6
        NearCall(cs2, 0x277B, unknown_3358_27E6_35D66);
    label_3358_277B_35CFB_11280:
        CheckExternalEvents(cs2, 0x277B);
        // 3358:277B pop SI
        SI = Stack.Pop16();
        // 3358:277C pop CX
        CX = Stack.Pop16();
        // 3358:277D add CX,8
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)8)));
        // 3358:2780 add SI,1
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)1)));
        // 3358:2783 cmp CX,0x0212
        Alu16.Sub(CX, (ushort)0x0212);
        // 3358:2787 jb short 0x278F
        if (CarryFlag)
        {
            goto label_3358_278F_35D0F_11287;
        }
    label_3358_2789_35D09_11400:
        CheckExternalEvents(cs2, 0x2789);
        // 3358:2789 mov CX,8
        CX = (ushort)0x0008;
        // 3358:278C mov SI,1
        SI = (ushort)0x0001;
    label_3358_278F_35D0F_11287:
        CheckExternalEvents(cs2, 0x278F);
        // 3358:278F mov word ptr CS:[0x2768],CX
        UInt16[CS, (ushort)0x2768] = CX;
        // 3358:2794 mov word ptr CS:[0x276A],SI
        UInt16[CS, (ushort)0x276A] = SI;
        // 3358:2799 ret far
        return FarRet((ushort)0x0000);
    label_3358_3200_36780_11061:
        CheckExternalEvents(cs2, 0x3200);
        // 3358:3200 mov word ptr CS:[0x2535],SI
        UInt16[CS, (ushort)0x2535] = SI;
        // 3358:3205 mov word ptr CS:[0x2537],DS
        UInt16[CS, (ushort)0x2537] = DS;
        // 3358:320A mov word ptr CS:[0x2539],ES
        UInt16[CS, (ushort)0x2539] = ES;
        // 3358:320F and AX,0x00FE
        AX = Alu16.And(AX, (ushort)0x00FE);
        // 3358:3212 cmp AX,0x001A
        Alu16.Sub(AX, (ushort)0x001A);
        // 3358:3215 jb short 0x321C
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:3215");
        }
    label_3358_321C_3679C_11068:
        CheckExternalEvents(cs2, 0x321C);
        // 3358:321C mov BX,AX
        BX = AX;
        // 3358:321E jmp near word ptr CS:[BX+0x31E6]
        switch ((ushort)(UInt16[CS, (ushort)(BX + (short)12774)]))
        {
            case 0x276C:
                goto label_3358_276C_35CEC_11071;
            case 0x3382:
                break;
            case 0x33CA:
                goto label_3358_33CA_3694A_39302;
            case 0x3429:
                goto label_3358_3429_369A9_39418;
            case 0x3500:
                goto label_3358_3500_36A80_32748;
            case 0x3581:
                goto label_3358_3581_36B01_19632;
            case 0x3602:
                goto label_3358_3602_36B82_23848;
            case 0x3841:
                goto label_3358_3841_36DC1_25024;
            case 0x38D8:
                goto label_3358_38D8_36E58_26432;
            case 0x39BB:
                goto label_3358_39BB_36F3B_26593;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BX + (short)12774)])):X4} at 3358:321E");
        }
    label_3358_3382_36902_15837:
        CheckExternalEvents(cs2, 0x3382);
        // 3358:3382 cmp CX,0x0011
        Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)17)));
        // 3358:3385 jne short 0x33A3
        if (!ZeroFlag)
        {
            goto label_3358_33A3_36923_15860;
        }
    label_3358_3387_36907_15840:
        CheckExternalEvents(cs2, 0x3387);
        // 3358:3387 push CX
        Stack.Push16(CX);
        // 3358:3388 push SI
        Stack.Push16(SI);
        // 3358:3389 push DS
        Stack.Push16(DS);
        // 3358:338A push ES
        Stack.Push16(ES);
        // 3358:338B push ES
        Stack.Push16(ES);
        // 3358:338C push SI
        Stack.Push16(SI);
        // 3358:338D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:338E pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:338F mov DX,0x005C
        DX = (ushort)0x005C;
        // 3358:3392 mov BX,0x009F
        BX = (ushort)0x009F;
        // 3358:3395 mov BP,0x0088
        BP = (ushort)0x0088;
        // 3358:3398 mov AX,0x0029
        AX = (ushort)0x0029;
        // 3358:339B push CS
        Stack.Push16(CS);
        // 3358:339C call near 0x1B8E
        NearCall(cs2, 0x339F, unknown_3358_1B8E_3510E);
    label_3358_339F_3691F_15855:
        CheckExternalEvents(cs2, 0x339F);
        // 3358:339F pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:33A0 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:33A1 pop SI
        SI = Stack.Pop16();
        // 3358:33A2 pop CX
        CX = Stack.Pop16();
    label_3358_33A3_36923_15860:
        CheckExternalEvents(cs2, 0x33A3);
        // 3358:33A3 cmp CL,9
        Alu8.Sub(CL, (byte)0x09);
        // 3358:33A6 jb short 0x33AA
        if (CarryFlag)
        {
            goto label_3358_33AA_3692A_15865;
        }
    label_3358_33A8_36928_15862:
        CheckExternalEvents(cs2, 0x33A8);
        // 3358:33A8 push SI
        Stack.Push16(SI);
        // 3358:33A9 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_3358_33AA_3692A_15865:
        CheckExternalEvents(cs2, 0x33AA);
        // 3358:33AA push CX
        Stack.Push16(CX);
        // 3358:33AB mov BX,CX
        BX = CX;
        // 3358:33AD shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 3358:33AF mov AX,word ptr CS:[BX+0x30F0]
        AX = UInt16[CS, (ushort)(BX + (short)12528)];
        // 3358:33B4 call near 0x32C1
        NearCall(cs2, 0x33B7, unknown_3358_32C1_36841);
    label_3358_33B7_36937_15956:
        CheckExternalEvents(cs2, 0x33B7);
        // 3358:33B7 pop CX
        CX = Stack.Pop16();
        // 3358:33B8 loop 0x33C9
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_33C9_36949_15959;
        }
    label_3358_33BA_3693A_16014:
        CheckExternalEvents(cs2, 0x33BA);
        // 3358:33BA mov DX,0x005C
        DX = (ushort)0x005C;
        // 3358:33BD mov BX,0x009F
        BX = (ushort)0x009F;
        // 3358:33C0 mov BP,0x0088
        BP = (ushort)0x0088;
        // 3358:33C3 mov AX,0x0029
        AX = (ushort)0x0029;
        // 3358:33C6 jmp near 0x1B8E
        return unknown_3358_1B8E_3510E(0x0000);
    label_3358_33C9_36949_15959:
        CheckExternalEvents(cs2, 0x33C9);
        // 3358:33C9 ret far
        return FarRet((ushort)0x0000);
    label_3358_33CA_3694A_39302:
        CheckExternalEvents(cs2, 0x33CA);
        // 3358:33CA mov BP,SI
        BP = SI;
        // 3358:33CC push BP
        Stack.Push16(BP);
        // 3358:33CD mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:33D0 mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:33D3 sub BX,2
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:33D6 call near 0x0C10
        NearCall(cs2, 0x33D9, unknown_3358_0C10_34190);
    label_3358_33D9_36959_39315:
        CheckExternalEvents(cs2, 0x33D9);
        // 3358:33D9 mov SI,DI
        SI = DI;
        // 3358:33DB mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:33DE mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:33E1 call near 0x0C10
        NearCall(cs2, 0x33E4, unknown_3358_0C10_34190);
    label_3358_33E4_36964_39324:
        CheckExternalEvents(cs2, 0x33E4);
        // 3358:33E4 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:33E7 sub DX,word ptr SS:[BP]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:33EA shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:33EC mov BX,2
        BX = (ushort)0x0002;
    label_3358_33EF_3696F_39329:
        CheckExternalEvents(cs2, 0x33EF);
        // 3358:33EF push BX
        Stack.Push16(BX);
        // 3358:33F0 push SI
        Stack.Push16(SI);
        // 3358:33F1 push DI
        Stack.Push16(DI);
        // 3358:33F2 mov AX,DX
        AX = DX;
        // 3358:33F4 add AX,AX
        AX = Alu16.Add(AX, AX);
    label_3358_33F6_36976_39334:
        CheckExternalEvents(cs2, 0x33F6);
        // 3358:33F6 mov CX,DX
        CX = DX;
        // 3358:33F8 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:33FA sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:33FC sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:33FE add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3402 add SI,0x0140
        SI = Alu16.Add(SI, (ushort)0x0140);
        // 3358:3406 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3407 jne short 0x33F6
        if (!ZeroFlag)
        {
            goto label_3358_33F6_36976_39334;
        }
    label_3358_3409_36989_39344:
        CheckExternalEvents(cs2, 0x3409);
        // 3358:3409 pop DI
        DI = Stack.Pop16();
        // 3358:340A pop SI
        SI = Stack.Pop16();
        // 3358:340B pop BX
        BX = Stack.Pop16();
        // 3358:340C add BX,2
        BX = Alu16.Add(BX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:340F sub SI,0x0280
        SI = Alu16.Sub(SI, (ushort)0x0280);
        // 3358:3413 jae short 0x33EF
        if (!CarryFlag)
        {
            goto label_3358_33EF_3696F_39329;
        }
    label_3358_3415_36995_39353:
        CheckExternalEvents(cs2, 0x3415);
        // 3358:3415 pop BP
        BP = Stack.Pop16();
        // 3358:3416 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:3419 mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:341C mov AX,word ptr SS:[BP+6]
        AX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:341F mov BP,word ptr SS:[BP+4]
        BP = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:3422 sub BP,DX
        BP = Alu16.Sub(BP, DX);
        // 3358:3424 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:3426 jmp near 0x1B8E
        return unknown_3358_1B8E_3510E(0x0000);
    label_3358_3429_369A9_39418:
        CheckExternalEvents(cs2, 0x3429);
        // 3358:3429 mov BP,SI
        BP = SI;
        // 3358:342B mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:342E mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:3431 call near 0x0C10
        NearCall(cs2, 0x3434, unknown_3358_0C10_34190);
    label_3358_3434_369B4_39427:
        CheckExternalEvents(cs2, 0x3434);
        // 3358:3434 mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:3437 sub DX,word ptr SS:[BP]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:343A shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:343C mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
        // 3358:343F sub BX,word ptr SS:[BP+2]
        BX = Alu16.Sub(BX, UInt16[SS, (ushort)(BP + (sbyte)2)]);
        // 3358:3442 sub BX,6
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)6)));
    label_3358_3445_369C5_39434:
        CheckExternalEvents(cs2, 0x3445);
        // 3358:3445 push BX
        Stack.Push16(BX);
        // 3358:3446 push DI
        Stack.Push16(DI);
        // 3358:3447 mov AX,DX
        AX = DX;
        // 3358:3449 add AX,AX
        AX = Alu16.Add(AX, AX);
        // 3358:344B or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:344D je short 0x3464
        if (ZeroFlag)
        {
            goto label_3358_3464_369E4_39440;
        }
    label_3358_344F_369CF_39442:
        CheckExternalEvents(cs2, 0x344F);
        // 3358:344F push DS
        Stack.Push16(DS);
        // 3358:3450 push ES
        Stack.Push16(ES);
        // 3358:3451 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_3358_3452_369D2_39449:
        CheckExternalEvents(cs2, 0x3452);
        // 3358:3452 mov CX,DX
        CX = DX;
        // 3358:3454 lea SI,DI+0x0780
        SI = unchecked((ushort)(DI + (short)1920));
        // 3358:3458 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:345A sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:345C add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3460 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3461 jne short 0x3452
        if (!ZeroFlag)
        {
            goto label_3358_3452_369D2_39449;
        }
    label_3358_3463_369E3_39468:
        CheckExternalEvents(cs2, 0x3463);
        // 3358:3463 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
    label_3358_3464_369E4_39440:
        CheckExternalEvents(cs2, 0x3464);
        // 3358:3464 mov BX,6
        BX = (ushort)0x0006;
    label_3358_3467_369E7_39444:
        CheckExternalEvents(cs2, 0x3467);
        // 3358:3467 mov CX,DX
        CX = DX;
        // 3358:3469 mov SI,DI
        SI = DI;
        // 3358:346B rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:346D sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:346F add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3473 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3474 jne short 0x3467
        if (!ZeroFlag)
        {
            goto label_3358_3467_369E7_39444;
        }
    label_3358_3476_369F6_39460:
        CheckExternalEvents(cs2, 0x3476);
        // 3358:3476 pop DI
        DI = Stack.Pop16();
        // 3358:3477 pop BX
        BX = Stack.Pop16();
        // 3358:3478 sub BX,6
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)6)));
        // 3358:347B jae short 0x3445
        if (!CarryFlag)
        {
            goto label_3358_3445_369C5_39434;
        }
    label_3358_347D_369FD_39474:
        CheckExternalEvents(cs2, 0x347D);
        // 3358:347D cmp BX,-6
        Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)-6)));
        // 3358:3480 mov BX,0
        BX = (ushort)0x0000;
        // 3358:3483 jne short 0x3445
        if (!ZeroFlag)
        {
            goto label_3358_3445_369C5_39434;
        }
    label_3358_3485_36A05_39479:
        CheckExternalEvents(cs2, 0x3485);
        // 3358:3485 ret far
        return FarRet((ushort)0x0000);
    label_3358_3500_36A80_32748:
        CheckExternalEvents(cs2, 0x3500);
        // 3358:3500 call near 0x0BDC
        NearCall(cs2, 0x3503, unknown_3358_0BDC_3415C);
    label_3358_3503_36A83_32777:
        CheckExternalEvents(cs2, 0x3503);
        // 3358:3503 push SI
        Stack.Push16(SI);
        // 3358:3504 mov DX,word ptr SS:[SI]
        DX = UInt16[SS, SI];
        // 3358:3507 mov BX,word ptr SS:[SI+2]
        BX = UInt16[SS, (ushort)(SI + (sbyte)2)];
        // 3358:350B add BX,word ptr CS:[0x34FC]
        BX = Alu16.Add(BX, UInt16[CS, (ushort)0x34FC]);
        // 3358:3510 inc word ptr CS:[0x34FC]
        UInt16[CS, (ushort)0x34FC] = Alu16.Inc(UInt16[CS, (ushort)0x34FC]);
        // 3358:3515 mov BP,word ptr SS:[SI+6]
        BP = UInt16[SS, (ushort)(SI + (sbyte)6)];
        // 3358:3519 sub BP,BX
        BP = Alu16.Sub(BP, BX);
        // 3358:351B ja short 0x352C
        if (!CarryFlag && !ZeroFlag)
        {
            goto label_3358_352C_36AAC_32786;
        }
    label_3358_351D_36A9D_37301:
        CheckExternalEvents(cs2, 0x351D);
        // 3358:351D add BP,BX
        BP = Alu16.Add(BP, BX);
        // 3358:351F mov word ptr CS:[0x34FC],0
        UInt16[CS, (ushort)0x34FC] = (ushort)0x0000;
        // 3358:3526 mov BX,word ptr SS:[SI+2]
        BX = UInt16[SS, (ushort)(SI + (sbyte)2)];
        // 3358:352A sub BP,BX
        BP = Alu16.Sub(BP, BX);
    label_3358_352C_36AAC_32786:
        CheckExternalEvents(cs2, 0x352C);
        // 3358:352C call near 0x0C10
        NearCall(cs2, 0x352F, unknown_3358_0C10_34190);
    label_3358_352F_36AAF_32788:
        CheckExternalEvents(cs2, 0x352F);
        // 3358:352F sub DX,word ptr SS:[SI+4]
        DX = Alu16.Sub(DX, UInt16[SS, (ushort)(SI + (sbyte)4)]);
        // 3358:3533 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 3358:3535 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:3537 push DI
        Stack.Push16(DI);
        // 3358:3538 xchg DI,word ptr CS:[0x34FE]
        ushort xchgOffset_3358_3538_36AB8 = (ushort)0x34FE;
        ushort temp_3358_3538_36AB8 = DI;
        DI = UInt16[CS, xchgOffset_3358_3538_36AB8];
        UInt16[CS, xchgOffset_3358_3538_36AB8] = unchecked((ushort)temp_3358_3538_36AB8);
        // 3358:353D sub DI,5
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 3358:3540 mov SI,DI
        SI = DI;
        // 3358:3542 mov CX,DX
        CX = DX;
        // 3358:3544 add CX,5
        CX = Alu16.Add(CX, unchecked((ushort)unchecked((short)(sbyte)5)));
        // 3358:3547 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:3549 pop DI
        DI = Stack.Pop16();
        // 3358:354A mov SI,0x3487
        SI = (ushort)0x3487;
    label_3358_354D_36ACD_32801:
        CheckExternalEvents(cs2, 0x354D);
        // 3358:354D lods AL,byte ptr CS:[SI]
        AL = UInt8[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:354F cmp AL,0x80
        Alu8.Sub(AL, (byte)0x80);
        // 3358:3551 je short 0x356D
        if (ZeroFlag)
        {
            goto label_3358_356D_36AED_32822;
        }
    label_3358_3553_36AD3_32804:
        CheckExternalEvents(cs2, 0x3553);
        // 3358:3553 call near 0x356F
        NearCall(cs2, 0x3556, unknown_3358_356F_36AEF);
    label_3358_3556_36AD6_32818:
        CheckExternalEvents(cs2, 0x3556);
        // 3358:3556 dec BP
        BP = Alu16.Dec(BP);
        // 3358:3557 jne short 0x354D
        if (!ZeroFlag)
        {
            goto label_3358_354D_36ACD_32801;
        }
    label_3358_3559_36AD9_33740:
        CheckExternalEvents(cs2, 0x3559);
        // 3358:3559 pop AX
        AX = Stack.Pop16();
        // 3358:355A push AX
        Stack.Push16(AX);
        // 3358:355B push DX
        Stack.Push16(DX);
        // 3358:355C push SI
        Stack.Push16(SI);
        // 3358:355D mov SI,AX
        SI = AX;
        // 3358:355F mov DX,word ptr SS:[SI]
        DX = UInt16[SS, SI];
        // 3358:3562 mov BX,word ptr SS:[SI+2]
        BX = UInt16[SS, (ushort)(SI + (sbyte)2)];
        // 3358:3566 call near 0x0C10
        NearCall(cs2, 0x3569, unknown_3358_0C10_34190);
    label_3358_3569_36AE9_33749:
        CheckExternalEvents(cs2, 0x3569);
        // 3358:3569 pop SI
        SI = Stack.Pop16();
        // 3358:356A pop DX
        DX = Stack.Pop16();
        // 3358:356B jmp short 0x354D
        goto label_3358_354D_36ACD_32801;
    label_3358_356D_36AED_32822:
        CheckExternalEvents(cs2, 0x356D);
        // 3358:356D pop SI
        SI = Stack.Pop16();
        // 3358:356E ret far
        return FarRet((ushort)0x0000);
    label_3358_3581_36B01_19632:
        CheckExternalEvents(cs2, 0x3581);
        // 3358:3581 mov DX,word ptr SS:[SI]
        DX = UInt16[SS, SI];
        // 3358:3584 mov BX,word ptr SS:[SI+2]
        BX = UInt16[SS, (ushort)(SI + (sbyte)2)];
        // 3358:3588 call near 0x0C10
        NearCall(cs2, 0x358B, unknown_3358_0C10_34190);
    label_3358_358B_36B0B_19636:
        CheckExternalEvents(cs2, 0x358B);
        // 3358:358B mov DX,word ptr SS:[SI+4]
        DX = UInt16[SS, (ushort)(SI + (sbyte)4)];
        // 3358:358F sub DX,word ptr SS:[SI]
        DX = Alu16.Sub(DX, UInt16[SS, SI]);
        // 3358:3592 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:3594 mov BX,word ptr SS:[SI+6]
        BX = UInt16[SS, (ushort)(SI + (sbyte)6)];
        // 3358:3598 sub BX,word ptr SS:[SI+2]
        BX = Alu16.Sub(BX, UInt16[SS, (ushort)(SI + (sbyte)2)]);
        // 3358:359C shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:359E je short 0x35C7
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 3358:359E");
        }
    label_3358_35A0_36B20_19644:
        CheckExternalEvents(cs2, 0x35A0);
        // 3358:35A0 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
    label_3358_35A3_36B23_19646:
        CheckExternalEvents(cs2, 0x35A3);
        // 3358:35A3 mov SI,0x2FB7
        SI = (ushort)0x2FB7;
    label_3358_35A6_36B26_19647:
        CheckExternalEvents(cs2, 0x35A6);
        // 3358:35A6 lods AX,word ptr CS:[SI]
        AX = UInt16[CS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:35A8 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:35AA js short 0x35A3
        if (SignFlag)
        {
            goto label_3358_35A3_36B23_19646;
        }
    label_3358_35AC_36B2C_19650:
        CheckExternalEvents(cs2, 0x35AC);
        // 3358:35AC push BX
        Stack.Push16(BX);
        // 3358:35AD push CX
        Stack.Push16(CX);
        // 3358:35AE push DX
        Stack.Push16(DX);
        // 3358:35AF push SI
        Stack.Push16(SI);
        // 3358:35B0 push DI
        Stack.Push16(DI);
        // 3358:35B1 push BP
        Stack.Push16(BP);
        // 3358:35B2 call near 0x35C8
        NearCall(cs2, 0x35B5, unknown_3358_35C8_36B48);
    label_3358_35B5_36B35_19680:
        CheckExternalEvents(cs2, 0x35B5);
        // 3358:35B5 pop BP
        BP = Stack.Pop16();
        // 3358:35B6 pop DI
        DI = Stack.Pop16();
        // 3358:35B7 pop SI
        SI = Stack.Pop16();
        // 3358:35B8 pop DX
        DX = Stack.Pop16();
        // 3358:35B9 pop CX
        CX = Stack.Pop16();
        // 3358:35BA pop BX
        BX = Stack.Pop16();
        // 3358:35BB pop AX
        AX = Stack.Pop16();
        // 3358:35BC push AX
        Stack.Push16(AX);
        // 3358:35BD sub AX,word ptr SS:[BP]
        AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:35C0 neg AX
        AX = Alu16.Sub((ushort)0x0000, AX);
        CarryFlag = AX != (ushort)0x0000;
        // 3358:35C2 cmp AX,CX
        Alu16.Sub(AX, CX);
        // 3358:35C4 jb short 0x35A6
        if (CarryFlag)
        {
            goto label_3358_35A6_36B26_19647;
        }
    label_3358_35C6_36B46_19695:
        CheckExternalEvents(cs2, 0x35C6);
        // 3358:35C6 pop AX
        AX = Stack.Pop16();
        // 3358:35C7 ret far
        return FarRet((ushort)0x0000);
    label_3358_3602_36B82_23848:
        CheckExternalEvents(cs2, 0x3602);
        // 3358:3602 push DS
        Stack.Push16(DS);
        // 3358:3603 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3604 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:3606 jns short 0x360A
        if (!SignFlag)
        {
            goto label_3358_360A_36B8A_23853;
        }
    label_3358_3608_36B88_40584:
        CheckExternalEvents(cs2, 0x3608);
        // 3358:3608 xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_3358_360A_36B8A_23853:
        CheckExternalEvents(cs2, 0x360A);
        // 3358:360A cmp AX,0x012C
        Alu16.Sub(AX, (ushort)0x012C);
        // 3358:360D jb short 0x3612
        if (CarryFlag)
        {
            goto label_3358_3612_36B92_23856;
        }
    label_3358_360F_36B8F_36753:
        CheckExternalEvents(cs2, 0x360F);
        // 3358:360F mov AX,0x012C
        AX = (ushort)0x012C;
    label_3358_3612_36B92_23856:
        CheckExternalEvents(cs2, 0x3612);
        // 3358:3612 mov word ptr CS:[0x35F2],AX
        UInt16[CS, (ushort)0x35F2] = AX;
        // 3358:3616 push AX
        Stack.Push16(AX);
        // 3358:3617 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3618 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 3358:361A jns short 0x361E
        if (!SignFlag)
        {
            goto label_3358_361E_36B9E_23862;
        }
    label_3358_361C_36B9C_40523:
        CheckExternalEvents(cs2, 0x361C);
        // 3358:361C xor AX,AX
        AX = Alu16.Xor(AX, AX);
    label_3358_361E_36B9E_23862:
        CheckExternalEvents(cs2, 0x361E);
        // 3358:361E mov word ptr CS:[0x35F4],AX
        UInt16[CS, (ushort)0x35F4] = AX;
        // 3358:3622 push AX
        Stack.Push16(AX);
        // 3358:3623 call near 0x36B0
        NearCall(cs2, 0x3626, unknown_3358_36B0_36C30);
    label_3358_3626_36BA6_23922:
        CheckExternalEvents(cs2, 0x3626);
        // 3358:3626 pop BX
        BX = Stack.Pop16();
        // 3358:3627 pop DX
        DX = Stack.Pop16();
        // 3358:3628 push ES
        Stack.Push16(ES);
        // 3358:3629 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:362A mov CX,2
        CX = (ushort)0x0002;
    label_3358_362D_36BAD_23928:
        CheckExternalEvents(cs2, 0x362D);
        // 3358:362D push BX
        Stack.Push16(BX);
        // 3358:362E push CX
        Stack.Push16(CX);
        // 3358:362F push DX
        Stack.Push16(DX);
        // 3358:3630 mov CX,8
        CX = (ushort)0x0008;
    label_3358_3633_36BB3_23932:
        CheckExternalEvents(cs2, 0x3633);
        // 3358:3633 push BX
        Stack.Push16(BX);
        // 3358:3634 push CX
        Stack.Push16(CX);
        // 3358:3635 push DX
        Stack.Push16(DX);
        // 3358:3636 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:3639 call near 0x372D
        NearCall(cs2, 0x363C, unknown_3358_372D_36CAD);
    label_3358_363C_36BBC_24011:
        CheckExternalEvents(cs2, 0x363C);
        // 3358:363C pop BX
        BX = Stack.Pop16();
        // 3358:363D call near 0x2572
        NearCall(cs2, 0x3640, unknown_3358_2572_35AF2);
    label_3358_3640_36BC0_24014:
        CheckExternalEvents(cs2, 0x3640);
        // 3358:3640 pop DX
        DX = Stack.Pop16();
        // 3358:3641 pop CX
        CX = Stack.Pop16();
        // 3358:3642 pop BX
        BX = Stack.Pop16();
        // 3358:3643 add DX,word ptr CS:[0x35EA]
        DX = Alu16.Add(DX, UInt16[CS, (ushort)0x35EA]);
        // 3358:3648 add BX,word ptr CS:[0x35EC]
        BX = Alu16.Add(BX, UInt16[CS, (ushort)0x35EC]);
        // 3358:364D loop 0x3633
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3633_36BB3_23932;
        }
    label_3358_364F_36BCF_24022:
        CheckExternalEvents(cs2, 0x364F);
        // 3358:364F pop DX
        DX = Stack.Pop16();
        // 3358:3650 pop CX
        CX = Stack.Pop16();
        // 3358:3651 pop BX
        BX = Stack.Pop16();
        // 3358:3652 loop 0x362D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_362D_36BAD_23928;
        }
    label_3358_3654_36BD4_24028:
        CheckExternalEvents(cs2, 0x3654);
        // 3358:3654 mov AX,2
        AX = (ushort)0x0002;
    label_3358_3657_36BD7_24030:
        CheckExternalEvents(cs2, 0x3657);
        // 3358:3657 push AX
        Stack.Push16(AX);
        // 3358:3658 mov DX,word ptr CS:[0x35F6]
        DX = UInt16[CS, (ushort)0x35F6];
        // 3358:365D mov BX,word ptr CS:[0x35F8]
        BX = UInt16[CS, (ushort)0x35F8];
        // 3358:3662 mov CX,0x0014
        CX = (ushort)0x0014;
        // 3358:3665 mov SI,0x0014
        SI = (ushort)0x0014;
        // 3358:3668 mov AX,8
        AX = (ushort)0x0008;
    label_3358_366B_36BEB_24036:
        CheckExternalEvents(cs2, 0x366B);
        // 3358:366B push AX
        Stack.Push16(AX);
        // 3358:366C push BX
        Stack.Push16(BX);
        // 3358:366D push CX
        Stack.Push16(CX);
        // 3358:366E push DX
        Stack.Push16(DX);
        // 3358:366F push SI
        Stack.Push16(SI);
        // 3358:3670 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:3673 mov word ptr CS:[0x35FA],DX
        UInt16[CS, (ushort)0x35FA] = DX;
        // 3358:3678 mov word ptr CS:[0x35FC],BX
        UInt16[CS, (ushort)0x35FC] = BX;
        // 3358:367D mov word ptr CS:[0x35FE],CX
        UInt16[CS, (ushort)0x35FE] = CX;
        // 3358:3682 mov word ptr CS:[0x3600],SI
        UInt16[CS, (ushort)0x3600] = SI;
        // 3358:3687 call near 0x37B1
        NearCall(cs2, 0x368A, unknown_3358_37B1_36D31);
    label_3358_368A_36C0A_24123:
        CheckExternalEvents(cs2, 0x368A);
        // 3358:368A pop BX
        BX = Stack.Pop16();
        // 3358:368B call near 0x2572
        NearCall(cs2, 0x368E, unknown_3358_2572_35AF2);
    label_3358_368E_36C0E_24126:
        CheckExternalEvents(cs2, 0x368E);
        // 3358:368E pop SI
        SI = Stack.Pop16();
        // 3358:368F pop DX
        DX = Stack.Pop16();
        // 3358:3690 pop CX
        CX = Stack.Pop16();
        // 3358:3691 pop BX
        BX = Stack.Pop16();
        // 3358:3692 mov AX,word ptr CS:[0x35EE]
        AX = UInt16[CS, (ushort)0x35EE];
        // 3358:3696 sub DX,AX
        DX = Alu16.Sub(DX, AX);
        // 3358:3698 add CX,AX
        CX = Alu16.Add(CX, AX);
        // 3358:369A add CX,AX
        CX = Alu16.Add(CX, AX);
        // 3358:369C mov AX,word ptr CS:[0x35F0]
        AX = UInt16[CS, (ushort)0x35F0];
        // 3358:36A0 sub BX,AX
        BX = Alu16.Sub(BX, AX);
        // 3358:36A2 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:36A4 add SI,AX
        SI = Alu16.Add(SI, AX);
        // 3358:36A6 pop AX
        AX = Stack.Pop16();
        // 3358:36A7 dec AX
        AX = Alu16.Dec(AX);
        // 3358:36A8 jne short 0x366B
        if (!ZeroFlag)
        {
            goto label_3358_366B_36BEB_24036;
        }
    label_3358_36AA_36C2A_24143:
        CheckExternalEvents(cs2, 0x36AA);
        // 3358:36AA pop AX
        AX = Stack.Pop16();
        // 3358:36AB dec AX
        AX = Alu16.Dec(AX);
        // 3358:36AC jne short 0x3657
        if (!ZeroFlag)
        {
            goto label_3358_3657_36BD7_24030;
        }
    label_3358_36AE_36C2E_24148:
        CheckExternalEvents(cs2, 0x36AE);
        // 3358:36AE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:36AF ret far
        return FarRet((ushort)0x0000);
    label_3358_3841_36DC1_25024:
        CheckExternalEvents(cs2, 0x3841);
        // 3358:3841 push DS
        Stack.Push16(DS);
        // 3358:3842 push ES
        Stack.Push16(ES);
        // 3358:3843 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:3844 mov AX,2
        AX = (ushort)0x0002;
    label_3358_3847_36DC7_25029:
        CheckExternalEvents(cs2, 0x3847);
        // 3358:3847 push AX
        Stack.Push16(AX);
        // 3358:3848 mov DX,word ptr CS:[0x35FA]
        DX = UInt16[CS, (ushort)0x35FA];
        // 3358:384D mov BX,word ptr CS:[0x35FC]
        BX = UInt16[CS, (ushort)0x35FC];
        // 3358:3852 mov CX,word ptr CS:[0x35FE]
        CX = UInt16[CS, (ushort)0x35FE];
        // 3358:3857 mov SI,word ptr CS:[0x3600]
        SI = UInt16[CS, (ushort)0x3600];
        // 3358:385C mov AX,8
        AX = (ushort)0x0008;
    label_3358_385F_36DDF_25035:
        CheckExternalEvents(cs2, 0x385F);
        // 3358:385F push AX
        Stack.Push16(AX);
        // 3358:3860 push BX
        Stack.Push16(BX);
        // 3358:3861 push CX
        Stack.Push16(CX);
        // 3358:3862 push DX
        Stack.Push16(DX);
        // 3358:3863 push SI
        Stack.Push16(SI);
        // 3358:3864 push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:3867 call near 0x37B1
        NearCall(cs2, 0x386A, unknown_3358_37B1_36D31);
    label_3358_386A_36DEA_25042:
        CheckExternalEvents(cs2, 0x386A);
        // 3358:386A pop BX
        BX = Stack.Pop16();
        // 3358:386B call near 0x2572
        NearCall(cs2, 0x386E, unknown_3358_2572_35AF2);
    label_3358_386E_36DEE_25045:
        CheckExternalEvents(cs2, 0x386E);
        // 3358:386E pop SI
        SI = Stack.Pop16();
        // 3358:386F pop DX
        DX = Stack.Pop16();
        // 3358:3870 pop CX
        CX = Stack.Pop16();
        // 3358:3871 pop BX
        BX = Stack.Pop16();
        // 3358:3872 mov AX,word ptr CS:[0x35EE]
        AX = UInt16[CS, (ushort)0x35EE];
        // 3358:3876 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:3878 sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:387A sub CX,AX
        CX = Alu16.Sub(CX, AX);
        // 3358:387C mov AX,word ptr CS:[0x35F0]
        AX = UInt16[CS, (ushort)0x35F0];
        // 3358:3880 add BX,AX
        BX = Alu16.Add(BX, AX);
        // 3358:3882 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:3884 sub SI,AX
        SI = Alu16.Sub(SI, AX);
        // 3358:3886 pop AX
        AX = Stack.Pop16();
        // 3358:3887 dec AX
        AX = Alu16.Dec(AX);
        // 3358:3888 jne short 0x385F
        if (!ZeroFlag)
        {
            goto label_3358_385F_36DDF_25035;
        }
    label_3358_388A_36E0A_25062:
        CheckExternalEvents(cs2, 0x388A);
        // 3358:388A pop AX
        AX = Stack.Pop16();
        // 3358:388B dec AX
        AX = Alu16.Dec(AX);
        // 3358:388C jne short 0x3847
        if (!ZeroFlag)
        {
            goto label_3358_3847_36DC7_25029;
        }
    label_3358_388E_36E0E_25067:
        CheckExternalEvents(cs2, 0x388E);
        // 3358:388E mov CX,2
        CX = (ushort)0x0002;
    label_3358_3891_36E11_25069:
        CheckExternalEvents(cs2, 0x3891);
        // 3358:3891 push CX
        Stack.Push16(CX);
        // 3358:3892 mov DX,word ptr CS:[0x35F6]
        DX = UInt16[CS, (ushort)0x35F6];
        // 3358:3897 mov BX,word ptr CS:[0x35F8]
        BX = UInt16[CS, (ushort)0x35F8];
        // 3358:389C mov CX,8
        CX = (ushort)0x0008;
    label_3358_389F_36E1F_25073:
        CheckExternalEvents(cs2, 0x389F);
        // 3358:389F sub DX,word ptr CS:[0x35EA]
        DX = Alu16.Sub(DX, UInt16[CS, (ushort)0x35EA]);
        // 3358:38A4 sub BX,word ptr CS:[0x35EC]
        BX = Alu16.Sub(BX, UInt16[CS, (ushort)0x35EC]);
        // 3358:38A9 push BX
        Stack.Push16(BX);
        // 3358:38AA push CX
        Stack.Push16(CX);
        // 3358:38AB push DX
        Stack.Push16(DX);
        // 3358:38AC push word ptr SS:[BP]
        Stack.Push16(UInt16[SS, (ushort)(BP + (sbyte)0)]);
        // 3358:38AF call near 0x372D
        NearCall(cs2, 0x38B2, unknown_3358_372D_36CAD);
    label_3358_38B2_36E32_25080:
        CheckExternalEvents(cs2, 0x38B2);
        // 3358:38B2 pop BX
        BX = Stack.Pop16();
        // 3358:38B3 call near 0x2572
        NearCall(cs2, 0x38B6, unknown_3358_2572_35AF2);
    label_3358_38B6_36E36_25083:
        CheckExternalEvents(cs2, 0x38B6);
        // 3358:38B6 pop DX
        DX = Stack.Pop16();
        // 3358:38B7 pop CX
        CX = Stack.Pop16();
        // 3358:38B8 pop BX
        BX = Stack.Pop16();
        // 3358:38B9 loop 0x389F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_389F_36E1F_25073;
        }
    label_3358_38BB_36E3B_25089:
        CheckExternalEvents(cs2, 0x38BB);
        // 3358:38BB pop CX
        CX = Stack.Pop16();
        // 3358:38BC loop 0x3891
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3891_36E11_25069;
        }
    label_3358_38BE_36E3E_25093:
        CheckExternalEvents(cs2, 0x38BE);
        // 3358:38BE pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:38BF ret far
        return FarRet((ushort)0x0000);
    label_3358_38D8_36E58_26432:
        CheckExternalEvents(cs2, 0x38D8);
        // 3358:38D8 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38D9 add AX,8
        AX = Alu16.Add(AX, (ushort)0x0008);
        // 3358:38DC mov word ptr CS:[0x38C8],AX
        UInt16[CS, (ushort)0x38C8] = AX;
        // 3358:38E0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38E1 add AX,8
        AX = Alu16.Add(AX, (ushort)0x0008);
        // 3358:38E4 mov word ptr CS:[0x38CA],AX
        UInt16[CS, (ushort)0x38CA] = AX;
        // 3358:38E8 mov SI,DI
        SI = DI;
        // 3358:38EA lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38EB mov DX,AX
        DX = AX;
        // 3358:38ED lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38EE mov BX,AX
        BX = AX;
        // 3358:38F0 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38F1 mov CX,AX
        CX = AX;
        // 3358:38F3 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:38F4 mov SI,AX
        SI = AX;
        // 3358:38F6 xchg CX,SI
        ushort temp_3358_38F6_36E76 = CX;
        CX = SI;
        SI = unchecked((ushort)temp_3358_38F6_36E76);
        // 3358:38F8 mov word ptr CS:[0x38CC],DX
        UInt16[CS, (ushort)0x38CC] = DX;
        // 3358:38FD mov word ptr CS:[0x38CE],BX
        UInt16[CS, (ushort)0x38CE] = BX;
        // 3358:3902 mov word ptr CS:[0x38D0],SI
        UInt16[CS, (ushort)0x38D0] = SI;
        // 3358:3907 mov word ptr CS:[0x38D2],CX
        UInt16[CS, (ushort)0x38D2] = CX;
        // 3358:390C sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 3358:390E shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 3358:3910 shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 3358:3912 shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 3358:3914 shr SI,1
        SI = Alu16.Shr(SI, 1);
        // 3358:3916 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:3918 shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:391A shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:391C shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:391E shr CX,1
        CX = Alu16.Shr(CX, 1);
        // 3358:3920 mov word ptr CS:[0x38C4],SI
        UInt16[CS, (ushort)0x38C4] = SI;
        // 3358:3925 mov word ptr CS:[0x38C6],CX
        UInt16[CS, (ushort)0x38C6] = CX;
        // 3358:392A sub DX,word ptr CS:[0x38C8]
        DX = Alu16.Sub(DX, UInt16[CS, (ushort)0x38C8]);
        // 3358:392F pushf
        Stack.Push16(FlagRegister16);
        // 3358:3930 jns short 0x3934
        if (!SignFlag)
        {
            goto label_3358_3934_36EB4_26468;
        }
    label_3358_3932_36EB2_29711:
        CheckExternalEvents(cs2, 0x3932);
        // 3358:3932 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_3358_3934_36EB4_26468:
        CheckExternalEvents(cs2, 0x3934);
        // 3358:3934 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:3936 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:3938 shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:393A shr DX,1
        DX = Alu16.Shr(DX, 1);
    label_3358_393C_36EBC_26473:
        CheckExternalEvents(cs2, 0x393C);
        // 3358:393C popf
        FlagRegister16 = Stack.Pop16();
    label_3358_393D_36EBD_26475:
        CheckExternalEvents(cs2, 0x393D);
        // 3358:393D jns short 0x3941
        if (!SignFlag)
        {
            goto label_3358_3941_36EC1_26477;
        }
    label_3358_393F_36EBF_29713:
        CheckExternalEvents(cs2, 0x393F);
        // 3358:393F neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_3358_3941_36EC1_26477:
        CheckExternalEvents(cs2, 0x3941);
        // 3358:3941 mov word ptr CS:[0x38C0],DX
        UInt16[CS, (ushort)0x38C0] = DX;
        // 3358:3946 sub BX,word ptr CS:[0x38CA]
        BX = Alu16.Sub(BX, UInt16[CS, (ushort)0x38CA]);
        // 3358:394B pushf
        Stack.Push16(FlagRegister16);
        // 3358:394C jns short 0x3950
        if (!SignFlag)
        {
            goto label_3358_3950_36ED0_26484;
        }
    label_3358_394E_36ECE_26482:
        CheckExternalEvents(cs2, 0x394E);
        // 3358:394E neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_3358_3950_36ED0_26484:
        CheckExternalEvents(cs2, 0x3950);
        // 3358:3950 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:3952 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:3954 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:3956 shr BX,1
        BX = Alu16.Shr(BX, 1);
    label_3358_3958_36ED8_26488:
        CheckExternalEvents(cs2, 0x3958);
        // 3358:3958 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_3959_36ED9_26490:
        CheckExternalEvents(cs2, 0x3959);
        // 3358:3959 jns short 0x395D
        if (!SignFlag)
        {
            goto label_3358_395D_36EDD_26494;
        }
    label_3358_395B_36EDB_26492:
        CheckExternalEvents(cs2, 0x395B);
        // 3358:395B neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_3358_395D_36EDD_26494:
        CheckExternalEvents(cs2, 0x395D);
        // 3358:395D mov word ptr CS:[0x38C2],BX
        UInt16[CS, (ushort)0x38C2] = BX;
        // 3358:3962 mov DX,word ptr CS:[0x38C8]
        DX = UInt16[CS, (ushort)0x38C8];
        // 3358:3967 mov BX,word ptr CS:[0x38CA]
        BX = UInt16[CS, (ushort)0x38CA];
        // 3358:396C xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 3358:396E xor SI,SI
        SI = Alu16.Xor(SI, SI);
    label_3358_3970_36EF0_26499:
        CheckExternalEvents(cs2, 0x3970);
        // 3358:3970 push DS
        Stack.Push16(DS);
        // 3358:3971 push ES
        Stack.Push16(ES);
        // 3358:3972 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:3973 mov AX,word ptr SS:[BP]
        AX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:3976 mov word ptr CS:[0x38D4],AX
        UInt16[CS, (ushort)0x38D4] = AX;
        // 3358:397A mov AX,0x000F
        AX = (ushort)0x000F;
    label_3358_397D_36EFD_26505:
        CheckExternalEvents(cs2, 0x397D);
        // 3358:397D push AX
        Stack.Push16(AX);
        // 3358:397E add DX,word ptr CS:[0x38C0]
        DX = Alu16.Add(DX, UInt16[CS, (ushort)0x38C0]);
        // 3358:3983 add BX,word ptr CS:[0x38C2]
        BX = Alu16.Add(BX, UInt16[CS, (ushort)0x38C2]);
        // 3358:3988 add SI,word ptr CS:[0x38C4]
        SI = Alu16.Add(SI, UInt16[CS, (ushort)0x38C4]);
        // 3358:398D add CX,word ptr CS:[0x38C6]
        CX = Alu16.Add(CX, UInt16[CS, (ushort)0x38C6]);
        // 3358:3992 push BX
        Stack.Push16(BX);
        // 3358:3993 push CX
        Stack.Push16(CX);
        // 3358:3994 push DX
        Stack.Push16(DX);
        // 3358:3995 push SI
        Stack.Push16(SI);
        // 3358:3996 call near 0x3733
        NearCall(cs2, 0x3999, unknown_3358_3733_36CB3);
    label_3358_3999_36F19_26517:
        CheckExternalEvents(cs2, 0x3999);
        // 3358:3999 mov BX,word ptr CS:[0x38D4]
        BX = UInt16[CS, (ushort)0x38D4];
        // 3358:399E call near 0x2572
        NearCall(cs2, 0x39A1, unknown_3358_2572_35AF2);
    label_3358_39A1_36F21_26520:
        CheckExternalEvents(cs2, 0x39A1);
        // 3358:39A1 mov word ptr CS:[0x38D4],BX
        UInt16[CS, (ushort)0x38D4] = BX;
        // 3358:39A6 pop SI
        SI = Stack.Pop16();
        // 3358:39A7 pop DX
        DX = Stack.Pop16();
        // 3358:39A8 pop CX
        CX = Stack.Pop16();
        // 3358:39A9 pop BX
        BX = Stack.Pop16();
        // 3358:39AA push BX
        Stack.Push16(BX);
        // 3358:39AB push CX
        Stack.Push16(CX);
        // 3358:39AC push DX
        Stack.Push16(DX);
        // 3358:39AD push SI
        Stack.Push16(SI);
        // 3358:39AE call near 0x3733
        NearCall(cs2, 0x39B1, unknown_3358_3733_36CB3);
    label_3358_39B1_36F31_26531:
        CheckExternalEvents(cs2, 0x39B1);
        // 3358:39B1 pop SI
        SI = Stack.Pop16();
        // 3358:39B2 pop DX
        DX = Stack.Pop16();
        // 3358:39B3 pop CX
        CX = Stack.Pop16();
        // 3358:39B4 pop BX
        BX = Stack.Pop16();
        // 3358:39B5 pop AX
        AX = Stack.Pop16();
        // 3358:39B6 dec AX
        AX = Alu16.Dec(AX);
        // 3358:39B7 jne short 0x397D
        if (!ZeroFlag)
        {
            goto label_3358_397D_36EFD_26505;
        }
    label_3358_39B9_36F39_26540:
        CheckExternalEvents(cs2, 0x39B9);
        // 3358:39B9 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:39BA ret far
        return FarRet((ushort)0x0000);
    label_3358_39BB_36F3B_26593:
        CheckExternalEvents(cs2, 0x39BB);
        // 3358:39BB mov DX,word ptr CS:[0x38CC]
        DX = UInt16[CS, (ushort)0x38CC];
        // 3358:39C0 mov BX,word ptr CS:[0x38CE]
        BX = UInt16[CS, (ushort)0x38CE];
        // 3358:39C5 mov SI,word ptr CS:[0x38D0]
        SI = UInt16[CS, (ushort)0x38D0];
        // 3358:39CA mov CX,word ptr CS:[0x38D2]
        CX = UInt16[CS, (ushort)0x38D2];
        // 3358:39CF sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 3358:39D1 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:39D3 neg word ptr CS:[0x38C0]
        UInt16[CS, (ushort)0x38C0] = Alu16.Sub((ushort)0x0000, UInt16[CS, (ushort)0x38C0]);
        CarryFlag = UInt16[CS, (ushort)0x38C0] != (ushort)0x0000;
        // 3358:39D8 neg word ptr CS:[0x38C2]
        UInt16[CS, (ushort)0x38C2] = Alu16.Sub((ushort)0x0000, UInt16[CS, (ushort)0x38C2]);
        CarryFlag = UInt16[CS, (ushort)0x38C2] != (ushort)0x0000;
        // 3358:39DD neg word ptr CS:[0x38C4]
        UInt16[CS, (ushort)0x38C4] = Alu16.Sub((ushort)0x0000, UInt16[CS, (ushort)0x38C4]);
        CarryFlag = UInt16[CS, (ushort)0x38C4] != (ushort)0x0000;
        // 3358:39E2 neg word ptr CS:[0x38C6]
        UInt16[CS, (ushort)0x38C6] = Alu16.Sub((ushort)0x0000, UInt16[CS, (ushort)0x38C6]);
        CarryFlag = UInt16[CS, (ushort)0x38C6] != (ushort)0x0000;
        // 3358:39E7 jmp short 0x3970
        goto label_3358_3970_36EF0_26499;
    }

    public virtual Action unknown_3358_015D_336DD(int loadOffset)
    {
    label_3358_015D_336DD_10274:
        CheckExternalEvents(cs2, 0x015D);
        // 3358:015D jmp near 0x19C9
    label_3358_19C9_34F49_10276:
        CheckExternalEvents(cs2, 0x19C9);
        // 3358:19C9 mov DX,word ptr SS:[BP]
        DX = UInt16[SS, (ushort)(BP + (sbyte)0)];
        // 3358:19CC mov BX,word ptr SS:[BP+2]
        BX = UInt16[SS, (ushort)(BP + (sbyte)2)];
        // 3358:19CF call near 0x0C10
        NearCall(cs2, 0x19D2, unknown_3358_0C10_34190);
    label_3358_19D2_34F52_10280:
        CheckExternalEvents(cs2, 0x19D2);
        // 3358:19D2 mov SI,DI
        SI = DI;
        // 3358:19D4 mov DX,word ptr SS:[BP+8]
        DX = UInt16[SS, (ushort)(BP + (sbyte)8)];
        // 3358:19D7 mov BX,word ptr SS:[BP+0x0A]
        BX = UInt16[SS, (ushort)(BP + (sbyte)10)];
        // 3358:19DA call near 0x0C10
        NearCall(cs2, 0x19DD, unknown_3358_0C10_34190);
    label_3358_19DD_34F5D_10285:
        CheckExternalEvents(cs2, 0x19DD);
        // 3358:19DD mov DX,word ptr SS:[BP+4]
        DX = UInt16[SS, (ushort)(BP + (sbyte)4)];
        // 3358:19E0 mov BX,word ptr SS:[BP+6]
        BX = UInt16[SS, (ushort)(BP + (sbyte)6)];
    label_3358_19E3_34F63_10288:
        CheckExternalEvents(cs2, 0x19E3);
        // 3358:19E3 mov CX,DX
        CX = DX;
        // 3358:19E5 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:19E7 sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 3358:19E9 sub DI,DX
        DI = Alu16.Sub(DI, DX);
        // 3358:19EB add SI,0x0140
        SI = Alu16.Add(SI, (ushort)0x0140);
        // 3358:19EF add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:19F3 dec BX
        BX = Alu16.Dec(BX);
        // 3358:19F4 jne short 0x19E3
        if (!ZeroFlag)
        {
            goto label_3358_19E3_34F63_10288;
        }
    label_3358_19F6_34F76_10297:
        CheckExternalEvents(cs2, 0x19F6);
        // 3358:19F6 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0160_336E0(int loadOffset)
    {
    label_3358_0160_336E0_4672:
        CheckExternalEvents(cs2, 0x0160);
        // 3358:0160 jmp near 0x0B0C
        return unknown_3358_0B0C_3408C(0x0000);
    }

    public virtual Action unknown_3358_0163_336E3(int loadOffset)
    {
    label_3358_0163_336E3_3407:
        CheckExternalEvents(cs2, 0x0163);
        // 3358:0163 jmp near 0x0C06
    label_3358_0C06_34186_3409:
        CheckExternalEvents(cs2, 0x0C06);
        // 3358:0C06 mov DX,0x0140
        DX = (ushort)0x0140;
        // 3358:0C09 mul DX
        uint result_3358_0C09_34189 = Alu16.Mul(AX, unchecked((ushort)unchecked((short)DX)));
        DX = unchecked((ushort)(result_3358_0C09_34189 >> 16));
        AX = unchecked((ushort)result_3358_0C09_34189);
        // 3358:0C0B mov word ptr CS:[0x01A3],AX
        UInt16[CS, (ushort)0x01A3] = AX;
        // 3358:0C0F ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0169_336E9(int loadOffset)
    {
    label_3358_0169_336E9_7744:
        CheckExternalEvents(cs2, 0x0169);
        // 3358:0169 jmp near 0x0D85
        return unknown_3358_0D85_34305(0x0000);
    }

    public virtual Action unknown_3358_016C_336EC(int loadOffset)
    {
    label_3358_016C_336EC_7209:
        CheckExternalEvents(cs2, 0x016C);
        // 3358:016C jmp near 0x39E9
    label_3358_39E9_36F69_7211:
        CheckExternalEvents(cs2, 0x39E9);
        // 3358:39E9 push AX
        Stack.Push16(AX);
        // 3358:39EA push DI
        Stack.Push16(DI);
        // 3358:39EB call near 0x0C10
        NearCall(cs2, 0x39EE, unknown_3358_0C10_34190);
    label_3358_39EE_36F6E_7215:
        CheckExternalEvents(cs2, 0x39EE);
        // 3358:39EE pop BX
        BX = Stack.Pop16();
        // 3358:39EF mov DX,AX
        DX = AX;
    label_3358_39F1_36F71_7218:
        CheckExternalEvents(cs2, 0x39F1);
        // 3358:39F1 shr BP,1
        BP = Alu16.Shr(BP, 1);
        // 3358:39F3 jae short 0x39F7
        if (!CarryFlag)
        {
            goto label_3358_39F7_36F77_7220;
        }
    label_3358_39F5_36F75_9581:
        CheckExternalEvents(cs2, 0x39F5);
        // 3358:39F5 xor BP,SI
        BP = Alu16.Xor(BP, SI);
    label_3358_39F7_36F77_7220:
        CheckExternalEvents(cs2, 0x39F7);
        // 3358:39F7 mov AX,BP
        AX = BP;
        // 3358:39F9 and AX,3
        AX = Alu16.And(AX, (ushort)0x0003);
        // 3358:39FC dec AX
        AX = Alu16.Dec(AX);
        // 3358:39FD add AL,DH
        AL = Alu8.Add(AL, DH);
        // 3358:39FF stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3A00 add DX,BX
        DX = Alu16.Add(DX, BX);
        // 3358:3A02 loop 0x39F1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_39F1_36F71_7218;
        }
    label_3358_3A04_36F84_7229:
        CheckExternalEvents(cs2, 0x3A04);
        // 3358:3A04 pop AX
        AX = Stack.Pop16();
        // 3358:3A05 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_016F_336EF(int loadOffset)
    {
    label_3358_016F_336EF_9680:
        CheckExternalEvents(cs2, 0x016F);
        // 3358:016F jmp near 0x3A14
    label_3358_3A14_36F94_9682:
        CheckExternalEvents(cs2, 0x3A14);
        // 3358:3A14 call near 0x0C10
        NearCall(cs2, 0x3A17, unknown_3358_0C10_34190);
    label_3358_3A17_36F97_9684:
        CheckExternalEvents(cs2, 0x3A17);
        // 3358:3A17 mov SI,DI
        SI = DI;
        // 3358:3A19 mov DI,word ptr CS:[0x01A3]
        DI = UInt16[CS, (ushort)0x01A3];
        // 3358:3A1E shl BP,1
        BP = Alu16.Shl(BP, 1);
        // 3358:3A20 jmp near word ptr CS:[BP+0x3A04]
        switch ((ushort)(UInt16[CS, (ushort)(BP + (short)14852)]))
        {
            case 0x3A25:
                break;
            case 0x3A69:
                goto label_3358_3A69_36FE9_9858;
            case 0x3A9D:
                goto label_3358_3A9D_3701D_9820;
            case 0x3AD9:
                goto label_3358_3AD9_37059_9801;
            case 0x3AF6:
                goto label_3358_3AF6_37076_9754;
            case 0x3B46:
                goto label_3358_3B46_370C6_9689;
            default:
                throw FailAsUntested($"Unknown near jump target 0x{((ushort)(UInt16[CS, (ushort)(BP + (short)14852)])):X4} at 3358:3A20");
        }
    label_3358_3A25_36FA5_9894:
        CheckExternalEvents(cs2, 0x3A25);
        // 3358:3A25 mov BX,0x0013
        BX = (ushort)0x0013;
    label_3358_3A28_36FA8_9896:
        CheckExternalEvents(cs2, 0x3A28);
        // 3358:3A28 mov CX,0x0028
        CX = (ushort)0x0028;
        // 3358:3A2B mov BP,6
        BP = (ushort)0x0006;
    label_3358_3A2E_36FAE_9898:
        CheckExternalEvents(cs2, 0x3A2E);
        // 3358:3A2E push CX
        Stack.Push16(CX);
    label_3358_3A2F_36FAF_9899:
        CheckExternalEvents(cs2, 0x3A2F);
        // 3358:3A2F lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3A30 mov AH,AL
        AH = AL;
        // 3358:3A32 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A33 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A34 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A35 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A36 loop 0x3A2F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3A2F_36FAF_9899;
        }
    label_3358_3A38_36FB8_9907:
        CheckExternalEvents(cs2, 0x3A38);
        // 3358:3A38 pop CX
        CX = Stack.Pop16();
        // 3358:3A39 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:3A3B dec BP
        BP = Alu16.Dec(BP);
        // 3358:3A3C jne short 0x3A2E
        if (!ZeroFlag)
        {
            goto label_3358_3A2E_36FAE_9898;
        }
    label_3358_3A3E_36FBE_9913:
        CheckExternalEvents(cs2, 0x3A3E);
        // 3358:3A3E lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3A3F mov AH,AL
        AH = AL;
        // 3358:3A41 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A46 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A47 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3A48 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A4D stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A4E lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3A4F mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A54 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A55 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3A56 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A5B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A5C loop 0x3A3E
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3A3E_36FBE_9913;
        }
    label_3358_3A5E_36FDE_9928:
        CheckExternalEvents(cs2, 0x3A5E);
        // 3358:3A5E add SI,0x0028
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)40)));
        // 3358:3A61 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3A65 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3A66 jne short 0x3A28
        if (!ZeroFlag)
        {
            goto label_3358_3A28_36FA8_9896;
        }
    label_3358_3A68_36FE8_9934:
        CheckExternalEvents(cs2, 0x3A68);
        // 3358:3A68 ret far
        return FarRet((ushort)0x0000);
    label_3358_3A69_36FE9_9858:
        CheckExternalEvents(cs2, 0x3A69);
        // 3358:3A69 mov BX,0x0026
        BX = (ushort)0x0026;
    label_3358_3A6C_36FEC_9860:
        CheckExternalEvents(cs2, 0x3A6C);
        // 3358:3A6C mov CX,0x0050
        CX = (ushort)0x0050;
        // 3358:3A6F mov BP,2
        BP = (ushort)0x0002;
    label_3358_3A72_36FF2_9862:
        CheckExternalEvents(cs2, 0x3A72);
        // 3358:3A72 push CX
        Stack.Push16(CX);
    label_3358_3A73_36FF3_9863:
        CheckExternalEvents(cs2, 0x3A73);
        // 3358:3A73 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3A74 mov AH,AL
        AH = AL;
        // 3358:3A76 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A77 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A78 loop 0x3A73
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3A73_36FF3_9863;
        }
    label_3358_3A7A_36FFA_9869:
        CheckExternalEvents(cs2, 0x3A7A);
        // 3358:3A7A pop CX
        CX = Stack.Pop16();
        // 3358:3A7B add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:3A7D dec BP
        BP = Alu16.Dec(BP);
        // 3358:3A7E jne short 0x3A72
        if (!ZeroFlag)
        {
            goto label_3358_3A72_36FF2_9862;
        }
    label_3358_3A80_37000_9875:
        CheckExternalEvents(cs2, 0x3A80);
        // 3358:3A80 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3A81 mov AH,AL
        AH = AL;
        // 3358:3A83 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A88 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A89 lods AX,word ptr DS:[SI]
        AX = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        // 3358:3A8A mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3A8F stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3A90 loop 0x3A80
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3A80_37000_9875;
        }
    label_3358_3A92_37012_9884:
        CheckExternalEvents(cs2, 0x3A92);
        // 3358:3A92 add SI,0x0050
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)80)));
        // 3358:3A95 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3A99 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3A9A jne short 0x3A6C
        if (!ZeroFlag)
        {
            goto label_3358_3A6C_36FEC_9860;
        }
    label_3358_3A9C_3701C_9890:
        CheckExternalEvents(cs2, 0x3A9C);
        // 3358:3A9C ret far
        return FarRet((ushort)0x0000);
    label_3358_3A9D_3701D_9820:
        CheckExternalEvents(cs2, 0x3A9D);
        // 3358:3A9D mov BX,0x0032
        BX = (ushort)0x0032;
    label_3358_3AA0_37020_9822:
        CheckExternalEvents(cs2, 0x3AA0);
        // 3358:3AA0 mov CX,0x006A
        CX = (ushort)0x006A;
        // 3358:3AA3 push CX
        Stack.Push16(CX);
    label_3358_3AA4_37024_9824:
        CheckExternalEvents(cs2, 0x3AA4);
        // 3358:3AA4 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AA5 mov AH,AL
        AH = AL;
        // 3358:3AA7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3AA8 movs byte ptr ES:[DI],byte ptr DS:[SI]
        UInt8[ES, DI] = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3AA9 loop 0x3AA4
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3AA4_37024_9824;
        }
    label_3358_3AAB_3702B_9830:
        CheckExternalEvents(cs2, 0x3AAB);
        // 3358:3AAB lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AAC mov AH,AL
        AH = AL;
        // 3358:3AAE stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3AAF pop CX
        CX = Stack.Pop16();
        // 3358:3AB0 add SI,CX
        SI = Alu16.Add(SI, CX);
        // 3358:3AB2 inc SI
        SI = Alu16.Inc(SI);
    label_3358_3AB3_37033_9837:
        CheckExternalEvents(cs2, 0x3AB3);
        // 3358:3AB3 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AB4 mov AH,AL
        AH = AL;
        // 3358:3AB6 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3ABB stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3ABC lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3ABD mov byte ptr ES:[DI+0x0140],AL
        UInt8[ES, (ushort)(DI + (short)320)] = AL;
        // 3358:3AC2 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3AC3 loop 0x3AB3
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3AB3_37033_9837;
        }
    label_3358_3AC5_37045_9846:
        CheckExternalEvents(cs2, 0x3AC5);
        // 3358:3AC5 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AC6 mov AH,AL
        AH = AL;
        // 3358:3AC8 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3ACD stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3ACE add SI,0x006B
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)107)));
        // 3358:3AD1 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3AD5 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3AD6 jne short 0x3AA0
        if (!ZeroFlag)
        {
            goto label_3358_3AA0_37020_9822;
        }
    label_3358_3AD8_37058_9856:
        CheckExternalEvents(cs2, 0x3AD8);
        // 3358:3AD8 ret far
        return FarRet((ushort)0x0000);
    label_3358_3AD9_37059_9801:
        CheckExternalEvents(cs2, 0x3AD9);
        // 3358:3AD9 mov BX,0x004C
        BX = (ushort)0x004C;
    label_3358_3ADC_3705C_9803:
        CheckExternalEvents(cs2, 0x3ADC);
        // 3358:3ADC mov CX,0x00A0
        CX = (ushort)0x00A0;
    label_3358_3ADF_3705F_9804:
        CheckExternalEvents(cs2, 0x3ADF);
        // 3358:3ADF lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AE0 mov AH,AL
        AH = AL;
        // 3358:3AE2 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:3AE7 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3AE8 loop 0x3ADF
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3ADF_3705F_9804;
        }
    label_3358_3AEA_3706A_9810:
        CheckExternalEvents(cs2, 0x3AEA);
        // 3358:3AEA add SI,0x00A0
        SI = Alu16.Add(SI, (ushort)0x00A0);
        // 3358:3AEE add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3AF2 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3AF3 jne short 0x3ADC
        if (!ZeroFlag)
        {
            goto label_3358_3ADC_3705C_9803;
        }
    label_3358_3AF5_37075_9816:
        CheckExternalEvents(cs2, 0x3AF5);
        // 3358:3AF5 ret far
        return FarRet((ushort)0x0000);
    label_3358_3AF6_37076_9754:
        CheckExternalEvents(cs2, 0x3AF6);
        // 3358:3AF6 mov BX,0x0032
        BX = (ushort)0x0032;
    label_3358_3AF9_37079_9756:
        CheckExternalEvents(cs2, 0x3AF9);
        // 3358:3AF9 mov CX,0x006A
        CX = (ushort)0x006A;
    label_3358_3AFC_3707C_9757:
        CheckExternalEvents(cs2, 0x3AFC);
        // 3358:3AFC lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3AFD mov AH,AL
        AH = AL;
        // 3358:3AFF stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B00 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3B01 add DI,0x013D
        DI = Alu16.Add(DI, (ushort)0x013D);
        // 3358:3B05 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B06 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3B07 add DI,0x013D
        DI = Alu16.Add(DI, (ushort)0x013D);
        // 3358:3B0B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B0C stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3B0D sub DI,0x0280
        DI = Alu16.Sub(DI, (ushort)0x0280);
        // 3358:3B11 loop 0x3AFC
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3AFC_3707C_9757;
        }
    label_3358_3B13_37093_9770:
        CheckExternalEvents(cs2, 0x3B13);
        // 3358:3B13 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3B14 mov AH,AL
        AH = AL;
        // 3358:3B16 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B17 add DI,0x013E
        DI = Alu16.Add(DI, (ushort)0x013E);
        // 3358:3B1B stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B1C add DI,0x013E
        DI = Alu16.Add(DI, (ushort)0x013E);
        // 3358:3B20 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B21 add SI,0x00D5
        SI = Alu16.Add(SI, (ushort)0x00D5);
        // 3358:3B25 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3B26 jne short 0x3AF9
        if (!ZeroFlag)
        {
            goto label_3358_3AF9_37079_9756;
        }
    label_3358_3B28_370A8_9782:
        CheckExternalEvents(cs2, 0x3B28);
        // 3358:3B28 mov CX,0x006A
        CX = (ushort)0x006A;
    label_3358_3B2B_370AB_9784:
        CheckExternalEvents(cs2, 0x3B2B);
        // 3358:3B2B lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3B2C mov AH,AL
        AH = AL;
        // 3358:3B2E stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B2F stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3B30 add DI,0x013D
        DI = Alu16.Add(DI, (ushort)0x013D);
        // 3358:3B34 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B35 stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:3B36 sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
        // 3358:3B3A loop 0x3B2B
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3B2B_370AB_9784;
        }
    label_3358_3B3C_370BC_9794:
        CheckExternalEvents(cs2, 0x3B3C);
        // 3358:3B3C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3B3D mov AH,AL
        AH = AL;
        // 3358:3B3F stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B40 add DI,0x013E
        DI = Alu16.Add(DI, (ushort)0x013E);
        // 3358:3B44 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B45 ret far
        return FarRet((ushort)0x0000);
    label_3358_3B46_370C6_9689:
        CheckExternalEvents(cs2, 0x3B46);
        // 3358:3B46 mov BX,0x0026
        BX = (ushort)0x0026;
    label_3358_3B49_370C9_9691:
        CheckExternalEvents(cs2, 0x3B49);
        // 3358:3B49 mov CX,0x0050
        CX = (ushort)0x0050;
    label_3358_3B4C_370CC_9692:
        CheckExternalEvents(cs2, 0x3B4C);
        // 3358:3B4C lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:3B4D mov AH,AL
        AH = AL;
        // 3358:3B4F mov BP,4
        BP = (ushort)0x0004;
    label_3358_3B52_370D2_9695:
        CheckExternalEvents(cs2, 0x3B52);
        // 3358:3B52 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B53 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:3B54 add DI,0x013C
        DI = Alu16.Add(DI, (ushort)0x013C);
        // 3358:3B58 dec BP
        BP = Alu16.Dec(BP);
        // 3358:3B59 jne short 0x3B52
        if (!ZeroFlag)
        {
            goto label_3358_3B52_370D2_9695;
        }
    label_3358_3B5B_370DB_9701:
        CheckExternalEvents(cs2, 0x3B5B);
        // 3358:3B5B sub DI,0x04FC
        DI = Alu16.Sub(DI, (ushort)0x04FC);
        // 3358:3B5F loop 0x3B4C
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3B4C_370CC_9692;
        }
    label_3358_3B61_370E1_9705:
        CheckExternalEvents(cs2, 0x3B61);
        // 3358:3B61 add SI,0x00F0
        SI = Alu16.Add(SI, (ushort)0x00F0);
        // 3358:3B65 add DI,0x03C0
        DI = Alu16.Add(DI, (ushort)0x03C0);
        // 3358:3B69 dec BX
        BX = Alu16.Dec(BX);
        // 3358:3B6A jne short 0x3B49
        if (!ZeroFlag)
        {
            goto label_3358_3B49_370C9_9691;
        }
    label_3358_3B6C_370EC_9711:
        CheckExternalEvents(cs2, 0x3B6C);
        // 3358:3B6C ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0172_336F2(int loadOffset)
    {
    label_3358_0172_336F2_6246:
        CheckExternalEvents(cs2, 0x0172);
        // 3358:0172 jmp near 0x0A40
    label_3358_0A40_33FC0_6248:
        CheckExternalEvents(cs2, 0x0A40);
        // 3358:0A40 push CX
        Stack.Push16(CX);
        // 3358:0A41 push SI
        Stack.Push16(SI);
        // 3358:0A42 push DI
        Stack.Push16(DI);
        // 3358:0A43 push DS
        Stack.Push16(DS);
        // 3358:0A44 push ES
        Stack.Push16(ES);
        // 3358:0A45 push ES
        Stack.Push16(ES);
        // 3358:0A46 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A47 push CS
        Stack.Push16(CS);
        // 3358:0A48 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A49 mov DI,0x02BF
        DI = (ushort)0x02BF;
        // 3358:0A4C add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:0A4E mov SI,DX
        SI = DX;
        // 3358:0A50 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt8[ES, DI] = UInt8[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:0A52 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A53 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0A54 pop DI
        DI = Stack.Pop16();
        // 3358:0A55 pop SI
        SI = Stack.Pop16();
        // 3358:0A56 pop CX
        CX = Stack.Pop16();
        // 3358:0A57 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_0175_336F5(int loadOffset)
    {
    label_3358_0175_336F5_6279:
        CheckExternalEvents(cs2, 0x0175);
        // 3358:0175 jmp near 0x0AD7
    label_3358_0AD7_34057_6281:
        CheckExternalEvents(cs2, 0x0AD7);
        // 3358:0AD7 push AX
        Stack.Push16(AX);
        // 3358:0AD8 push BX
        Stack.Push16(BX);
        // 3358:0AD9 push CX
        Stack.Push16(CX);
        // 3358:0ADA push DX
        Stack.Push16(DX);
        // 3358:0ADB push SI
        Stack.Push16(SI);
        // 3358:0ADC push DI
        Stack.Push16(DI);
        // 3358:0ADD push BP
        Stack.Push16(BP);
        // 3358:0ADE push ES
        Stack.Push16(ES);
        // 3358:0ADF push DS
        Stack.Push16(DS);
        // 3358:0AE0 push CS
        Stack.Push16(CS);
        // 3358:0AE1 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0AE2 push CS
        Stack.Push16(CS);
        // 3358:0AE3 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0AE4 mov DL,AL
        DL = AL;
        // 3358:0AE6 or DL,DL
        DL = Alu8.Or(DL, DL);
        // 3358:0AE8 jne short 0x0AEB
        if (!ZeroFlag)
        {
            goto label_3358_0AEB_3406B_6298;
        }
    label_3358_0AEA_3406A_10770:
        CheckExternalEvents(cs2, 0x0AEA);
        // 3358:0AEA inc DX
        DX = Alu16.Inc(DX);
    label_3358_0AEB_3406B_6298:
        CheckExternalEvents(cs2, 0x0AEB);
        // 3358:0AEB mov DI,0x05BF
        DI = (ushort)0x05BF;
        // 3358:0AEE add DI,BX
        DI = Alu16.Add(DI, BX);
        // 3358:0AF0 lea SI,DI-768
        SI = unchecked((ushort)(DI + (short)-768));
        // 3358:0AF4 push DI
        Stack.Push16(DI);
        // 3358:0AF5 push CX
        Stack.Push16(CX);
    label_3358_0AF6_34076_6304:
        CheckExternalEvents(cs2, 0x0AF6);
        // 3358:0AF6 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:0AF7 sub AL,byte ptr DS:[DI]
        AL = Alu8.Sub(AL, UInt8[DS, DI]);
        // 3358:0AF9 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 3358:0AFA idiv DL
        sbyte divisor_3358_0AFA_3407A = unchecked((sbyte)DL);
        short dividend_3358_0AFA_3407A = unchecked((short)AX);
        sbyte quotient_3358_0AFA_3407A = Alu8.Idiv(unchecked((short)dividend_3358_0AFA_3407A), unchecked((sbyte)divisor_3358_0AFA_3407A));
        AL = unchecked((byte)quotient_3358_0AFA_3407A);
        AH = unchecked((byte)(dividend_3358_0AFA_3407A % unchecked((short)divisor_3358_0AFA_3407A)));
        // 3358:0AFC add AL,byte ptr DS:[DI]
        AL = Alu8.Add(AL, UInt8[DS, DI]);
        // 3358:0AFE stos byte ptr ES:[DI],AL
        UInt8[ES, DI] = AL;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction8)));
        // 3358:0AFF loop 0x0AF6
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_0AF6_34076_6304;
        }
    label_3358_0B01_34081_6312:
        CheckExternalEvents(cs2, 0x0B01);
        // 3358:0B01 pop CX
        CX = Stack.Pop16();
        // 3358:0B02 call near 0x0A21
        NearCall(cs2, 0x0B05, unknown_3358_0A21_33FA1);
    label_3358_0B05_34085_6315:
        CheckExternalEvents(cs2, 0x0B05);
        // 3358:0B05 pop DX
        DX = Stack.Pop16();
        // 3358:0B06 call near 0x0B68
        NearCall(cs2, 0x0B09, unknown_3358_0B68_340E8);
    label_3358_0B09_34089_6318:
        CheckExternalEvents(cs2, 0x0B09);
        // 3358:0B09 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 3358:0B0A jmp short 0x0B5F
        return unknown_3358_0B5F_340DF(0x0000);
    }
}
