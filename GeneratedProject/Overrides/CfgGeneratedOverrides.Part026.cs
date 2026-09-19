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
    public virtual Action unknown_3358_32C1_36841(int loadOffset)
    {
        goto label_3358_32C1_36841_15870;

    label_3358_3280_36800_15981:
        CheckExternalEvents(cs2, 0x3280);
        // 3358:3280 mov DI,0xC71C
        DI = (ushort)0xC71C;
        // 3358:3283 mov DX,0x0010
        DX = (ushort)0x0010;
        // 3358:3286 mov AX,0xFEFE
        AX = (ushort)0xFEFE;
    label_3358_3289_36809_15985:
        CheckExternalEvents(cs2, 0x3289);
        // 3358:3289 mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:328C rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:328E add DI,0x00B8
        DI = Alu16.Add(DI, (ushort)0x00B8);
        // 3358:3292 dec DX
        DX = Alu16.Dec(DX);
        // 3358:3293 jne short 0x3289
        if (!ZeroFlag)
        {
            goto label_3358_3289_36809_15985;
        }
    label_3358_3295_36815_15991:
        CheckExternalEvents(cs2, 0x3295);
        // 3358:3295 mov DX,8
        DX = (ushort)0x0008;
        // 3358:3298 mov AX,0xF208
        AX = (ushort)0xF208;
    label_3358_329B_3681B_15994:
        CheckExternalEvents(cs2, 0x329B);
        // 3358:329B mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:329E rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:32A0 add DI,0x00B8
        DI = Alu16.Add(DI, (ushort)0x00B8);
        // 3358:32A4 xchg AL,AH
        byte temp_3358_32A4_36824 = AL;
        AL = AH;
        AH = unchecked((byte)temp_3358_32A4_36824);
        // 3358:32A6 dec DX
        DX = Alu16.Dec(DX);
        // 3358:32A7 jne short 0x329B
        if (!ZeroFlag)
        {
            goto label_3358_329B_3681B_15994;
        }
    label_3358_32A9_36829_16001:
        CheckExternalEvents(cs2, 0x32A9);
        // 3358:32A9 mov DX,0x0010
        DX = (ushort)0x0010;
        // 3358:32AC mov AX,0xFEFE
        AX = (ushort)0xFEFE;
    label_3358_32AF_3682F_16004:
        CheckExternalEvents(cs2, 0x32AF);
        // 3358:32AF mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:32B2 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:32B4 add DI,0x00B8
        DI = Alu16.Add(DI, (ushort)0x00B8);
        // 3358:32B8 dec DX
        DX = Alu16.Dec(DX);
        // 3358:32B9 jne short 0x32AF
        if (!ZeroFlag)
        {
            goto label_3358_32AF_3682F_16004;
        }
    label_3358_32BB_3683B_16010:
        CheckExternalEvents(cs2, 0x32BB);
        // 3358:32BB mov DS,word ptr CS:[0x2537]
        DS = UInt16[CS, (ushort)0x2537];
        // 3358:32C0 ret near
        return NearRet((ushort)0x0000);
    label_3358_32C1_36841_15870:
        CheckExternalEvents(cs2, 0x32C1);
        // 3358:32C1 cmp CL,9
        Alu8.Sub(CL, (byte)0x09);
        // 3358:32C4 je short 0x3280
        if (ZeroFlag)
        {
            goto label_3358_3280_36800_15981;
        }
    label_3358_32C6_36846_15873:
        CheckExternalEvents(cs2, 0x32C6);
        // 3358:32C6 mov word ptr CS:[0x3116],CX
        UInt16[CS, (ushort)0x3116] = CX;
        // 3358:32CB mov word ptr CS:[0x3114],AX
        UInt16[CS, (ushort)0x3114] = AX;
        // 3358:32CF mov DI,0xE01C
        DI = (ushort)0xE01C;
        // 3358:32D2 lea BP,DI-320
        BP = unchecked((ushort)(DI + (short)-320));
        // 3358:32D6 mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:32D9 mov SI,DI
        SI = DI;
        // 3358:32DB rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:32DD add DI,0x00B8
        DI = Alu16.Add(DI, (ushort)0x00B8);
        // 3358:32E1 mov SI,DI
        SI = DI;
        // 3358:32E3 mov BX,BP
        BX = BP;
        // 3358:32E5 mov DX,0x0014
        DX = (ushort)0x0014;
        // 3358:32E8 jmp short 0x32FA
        goto label_3358_32FA_3687A_15886;
    label_3358_32EA_3686A_15900:
        CheckExternalEvents(cs2, 0x32EA);
        // 3358:32EA sub SI,0x01C8
        SI = Alu16.Sub(SI, (ushort)0x01C8);
        // 3358:32EE sub DI,0x01C8
        DI = Alu16.Sub(DI, (ushort)0x01C8);
        // 3358:32F2 add BX,0x00B8
        BX = Alu16.Add(BX, (ushort)0x00B8);
        // 3358:32F6 add BP,0x00B8
        BP = Alu16.Add(BP, (ushort)0x00B8);
    label_3358_32FA_3687A_15886:
        CheckExternalEvents(cs2, 0x32FA);
        // 3358:32FA dec DX
        DX = Alu16.Dec(DX);
        // 3358:32FB js short 0x3330
        if (SignFlag)
        {
            goto label_3358_3330_368B0_15917;
        }
    label_3358_32FD_3687D_15889:
        CheckExternalEvents(cs2, 0x32FD);
        // 3358:32FD mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:3300 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:3302 xchg DI,BP
        ushort temp_3358_3302_36882 = DI;
        DI = BP;
        BP = unchecked((ushort)temp_3358_3302_36882);
        // 3358:3304 xchg SI,BX
        ushort temp_3358_3304_36884 = SI;
        SI = BX;
        BX = unchecked((ushort)temp_3358_3304_36884);
        // 3358:3306 mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:3309 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:330B xchg DI,BP
        ushort temp_3358_330B_3688B = DI;
        DI = BP;
        BP = unchecked((ushort)temp_3358_330B_3688B);
        // 3358:330D xchg SI,BX
        ushort temp_3358_330D_3688D = SI;
        SI = BX;
        BX = unchecked((ushort)temp_3358_330D_3688D);
        // 3358:330F dec AL
        AL = Alu8.Dec(AL);
        // 3358:3311 jne short 0x32EA
        if (!ZeroFlag)
        {
            goto label_3358_32EA_3686A_15900;
        }
    label_3358_3313_36893_15905:
        CheckExternalEvents(cs2, 0x3313);
        // 3358:3313 mov CX,0x0140
        CX = (ushort)0x0140;
        // 3358:3316 sub DL,AH
        DL = Alu8.Sub(DL, AH);
        // 3358:3318 jbe short 0x3328
        if (CarryFlag || ZeroFlag)
        {
            goto label_3358_3328_368A8_15978;
        }
    label_3358_331A_3689A_15909:
        CheckExternalEvents(cs2, 0x331A);
        // 3358:331A sub SI,CX
        SI = Alu16.Sub(SI, CX);
        // 3358:331C add BX,CX
        BX = Alu16.Add(BX, CX);
        // 3358:331E dec AH
        AH = Alu8.Dec(AH);
        // 3358:3320 jne short 0x331A
        if (!ZeroFlag)
        {
            goto label_3358_331A_3689A_15909;
        }
    label_3358_3322_368A2_15914:
        CheckExternalEvents(cs2, 0x3322);
        // 3358:3322 mov AX,word ptr CS:[0x3114]
        AX = UInt16[CS, (ushort)0x3114];
        // 3358:3326 jmp short 0x32EA
        goto label_3358_32EA_3686A_15900;
    label_3358_3328_368A8_15978:
        CheckExternalEvents(cs2, 0x3328);
        // 3358:3328 sub DI,0x01C8
        DI = Alu16.Sub(DI, (ushort)0x01C8);
        // 3358:332C add BP,0x00B8
        BP = Alu16.Add(BP, (ushort)0x00B8);
    label_3358_3330_368B0_15917:
        CheckExternalEvents(cs2, 0x3330);
        // 3358:3330 mov BX,0xFEFE
        BX = (ushort)0xFEFE;
        // 3358:3333 mov AX,0xF208
        AX = (ushort)0xF208;
        // 3358:3336 mov DX,word ptr CS:[0x3116]
        DX = UInt16[CS, (ushort)0x3116];
        // 3358:333B cmp DX,9
        Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)9)));
        // 3358:333E jb short 0x3346
        if (CarryFlag)
        {
            goto label_3358_3346_368C6_15927;
        }
    label_3358_3340_368C0_15923:
        CheckExternalEvents(cs2, 0x3340);
        // 3358:3340 sub DX,0x0012
        DX = Alu16.Sub(DX, unchecked((ushort)unchecked((short)(sbyte)18)));
        // 3358:3343 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
        // 3358:3345 xchg BX,AX
        ushort temp_3358_3345_368C5 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_3358_3345_368C5);
    label_3358_3346_368C6_15927:
        CheckExternalEvents(cs2, 0x3346);
        // 3358:3346 mov CX,0x0044
        CX = (ushort)0x0044;
        // 3358:3349 xchg BX,AX
        ushort temp_3358_3349_368C9 = BX;
        BX = AX;
        AX = unchecked((ushort)temp_3358_3349_368C9);
        // 3358:334A xchg BP,DI
        ushort temp_3358_334A_368CA = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_334A_368CA);
        // 3358:334C rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:334E xchg BX,AX
        ushort temp_3358_334E_368CE = BX;
        BX = AX;
        AX = unchecked((ushort)temp_3358_334E_368CE);
        // 3358:334F xchg BP,DI
        ushort temp_3358_334F_368CF = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_334F_368CF);
        // 3358:3351 mov CL,0x44
        CL = (byte)0x44;
        // 3358:3353 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:3355 xchg AL,AH
        byte temp_3358_3355_368D5 = AL;
        AL = AH;
        AH = unchecked((byte)temp_3358_3355_368D5);
        // 3358:3357 xchg BL,BH
        byte temp_3358_3357_368D7 = BL;
        BL = BH;
        BH = unchecked((byte)temp_3358_3357_368D7);
        // 3358:3359 sub DI,0x01C8
        DI = Alu16.Sub(DI, (ushort)0x01C8);
        // 3358:335D add BP,0x00B8
        BP = Alu16.Add(BP, (ushort)0x00B8);
        // 3358:3361 dec DX
        DX = Alu16.Dec(DX);
        // 3358:3362 jne short 0x3346
        if (!ZeroFlag)
        {
            goto label_3358_3346_368C6_15927;
        }
    label_3358_3364_368E4_15941:
        CheckExternalEvents(cs2, 0x3364);
        // 3358:3364 mov AX,0xFEFE
        AX = (ushort)0xFEFE;
    label_3358_3367_368E7_15943:
        CheckExternalEvents(cs2, 0x3367);
        // 3358:3367 mov CL,0x44
        CL = (byte)0x44;
        // 3358:3369 xchg BP,DI
        ushort temp_3358_3369_368E9 = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_3369_368E9);
        // 3358:336B rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:336D xchg BP,DI
        ushort temp_3358_336D_368ED = BP;
        BP = DI;
        DI = unchecked((ushort)temp_3358_336D_368ED);
        // 3358:336F mov CL,0x44
        CL = (byte)0x44;
        // 3358:3371 rep stos word ptr ES:[DI],AX
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = AX;
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:3373 sub DI,0x01C8
        DI = Alu16.Sub(DI, (ushort)0x01C8);
        // 3358:3377 add BP,0x00B8
        BP = Alu16.Add(BP, (ushort)0x00B8);
        // 3358:337B cmp DI,0xC6C0
        Alu16.Sub(DI, (ushort)0xC6C0);
        // 3358:337F jae short 0x3367
        if (!CarryFlag)
        {
            goto label_3358_3367_368E7_15943;
        }
    label_3358_3381_36901_15954:
        CheckExternalEvents(cs2, 0x3381);
        // 3358:3381 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_356F_36AEF(int loadOffset)
    {
    label_3358_356F_36AEF_32806:
        CheckExternalEvents(cs2, 0x356F);
        // 3358:356F push SI
        Stack.Push16(SI);
        // 3358:3570 push DI
        Stack.Push16(DI);
        // 3358:3571 mov SI,DI
        SI = DI;
        // 3358:3573 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 3358:3574 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:3576 mov CX,DX
        CX = DX;
        // 3358:3578 rep movs word ptr ES:[DI],word ptr DS:[SI]
        while (CX != (ushort)0x0000)
        {
            UInt16[ES, DI] = UInt16[DS, SI];
            SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
            DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
            CX = unchecked((ushort)(CX - (ushort)0x0001));
        }
        // 3358:357A pop DI
        DI = Stack.Pop16();
        // 3358:357B pop SI
        SI = Stack.Pop16();
        // 3358:357C add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3580 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_35C8_36B48(int loadOffset)
    {
    label_3358_35C8_36B48_19658:
        CheckExternalEvents(cs2, 0x35C8);
        // 3358:35C8 mov SI,DI
        SI = DI;
        // 3358:35CA add SI,AX
        SI = Alu16.Add(SI, AX);
    label_3358_35CC_36B4C_19661:
        CheckExternalEvents(cs2, 0x35CC);
        // 3358:35CC push SI
        Stack.Push16(SI);
        // 3358:35CD push DI
        Stack.Push16(DI);
        // 3358:35CE mov CX,DX
        CX = DX;
    label_3358_35D0_36B50_19664:
        CheckExternalEvents(cs2, 0x35D0);
        // 3358:35D0 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 3358:35D1 inc SI
        SI = Alu16.Inc(SI);
        // 3358:35D2 mov AH,AL
        AH = AL;
        // 3358:35D4 mov word ptr ES:[DI+0x0140],AX
        UInt16[ES, (ushort)(DI + (short)320)] = AX;
        // 3358:35D9 stos word ptr ES:[DI],AX
        UInt16[ES, DI] = AX;
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 3358:35DA loop 0x35D0
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_35D0_36B50_19664;
        }
    label_3358_35DC_36B5C_19671:
        CheckExternalEvents(cs2, 0x35DC);
        // 3358:35DC pop DI
        DI = Stack.Pop16();
        // 3358:35DD pop SI
        SI = Stack.Pop16();
        // 3358:35DE add SI,0x0280
        SI = Alu16.Add(SI, (ushort)0x0280);
        // 3358:35E2 add DI,0x0280
        DI = Alu16.Add(DI, (ushort)0x0280);
        // 3358:35E6 dec BX
        BX = Alu16.Dec(BX);
        // 3358:35E7 jne short 0x35CC
        if (!ZeroFlag)
        {
            goto label_3358_35CC_36B4C_19661;
        }
    label_3358_35E9_36B69_19678:
        CheckExternalEvents(cs2, 0x35E9);
        // 3358:35E9 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_36B0_36C30(int loadOffset)
    {
    label_3358_36B0_36C30_23866:
        CheckExternalEvents(cs2, 0x36B0);
        // 3358:36B0 mov AX,word ptr DS:[DI+4]
        AX = UInt16[DS, (ushort)(DI + (sbyte)4)];
        // 3358:36B3 mov DX,word ptr DS:[DI]
        DX = UInt16[DS, DI];
        // 3358:36B5 sub AX,DX
        AX = Alu16.Sub(AX, DX);
        // 3358:36B7 sub AX,0x0014
        AX = Alu16.Sub(AX, (ushort)0x0014);
        // 3358:36BA shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36BC add DX,AX
        DX = Alu16.Add(DX, AX);
        // 3358:36BE mov word ptr CS:[0x35F6],DX
        UInt16[CS, (ushort)0x35F6] = DX;
        // 3358:36C3 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36C5 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36C7 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36C9 mov word ptr CS:[0x35EE],AX
        UInt16[CS, (ushort)0x35EE] = AX;
        // 3358:36CD mov AX,word ptr DS:[DI+6]
        AX = UInt16[DS, (ushort)(DI + (sbyte)6)];
        // 3358:36D0 mov BX,word ptr DS:[DI+2]
        BX = UInt16[DS, (ushort)(DI + (sbyte)2)];
        // 3358:36D3 sub AX,BX
        AX = Alu16.Sub(AX, BX);
        // 3358:36D5 sub AX,0x0014
        AX = Alu16.Sub(AX, (ushort)0x0014);
        // 3358:36D8 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36DA add BX,AX
        BX = Alu16.Add(BX, AX);
        // 3358:36DC mov word ptr CS:[0x35F8],BX
        UInt16[CS, (ushort)0x35F8] = BX;
        // 3358:36E1 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36E3 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36E5 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 3358:36E7 mov word ptr CS:[0x35F0],AX
        UInt16[CS, (ushort)0x35F0] = AX;
        // 3358:36EB sub DX,word ptr CS:[0x35F2]
        DX = Alu16.Sub(DX, UInt16[CS, (ushort)0x35F2]);
        // 3358:36F0 sub BX,word ptr CS:[0x35F4]
        BX = Alu16.Sub(BX, UInt16[CS, (ushort)0x35F4]);
        // 3358:36F5 or DX,DX
        DX = Alu16.Or(DX, DX);
        // 3358:36F7 pushf
        Stack.Push16(FlagRegister16);
        // 3358:36F8 jns short 0x36FC
        if (!SignFlag)
        {
            goto label_3358_36FC_36C7C_23896;
        }
    label_3358_36FA_36C7A_23894:
        CheckExternalEvents(cs2, 0x36FA);
        // 3358:36FA neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_3358_36FC_36C7C_23896:
        CheckExternalEvents(cs2, 0x36FC);
        // 3358:36FC shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:36FE shr DX,1
        DX = Alu16.Shr(DX, 1);
        // 3358:3700 shr DX,1
        DX = Alu16.Shr(DX, 1);
    label_3358_3702_36C82_23899:
        CheckExternalEvents(cs2, 0x3702);
        // 3358:3702 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_3703_36C83_23901:
        CheckExternalEvents(cs2, 0x3703);
        // 3358:3703 jns short 0x3707
        if (!SignFlag)
        {
            goto label_3358_3707_36C87_23905;
        }
    label_3358_3705_36C85_23903:
        CheckExternalEvents(cs2, 0x3705);
        // 3358:3705 neg DX
        DX = Alu16.Sub((ushort)0x0000, DX);
        CarryFlag = DX != (ushort)0x0000;
    label_3358_3707_36C87_23905:
        CheckExternalEvents(cs2, 0x3707);
        // 3358:3707 or BX,BX
        BX = Alu16.Or(BX, BX);
        // 3358:3709 pushf
        Stack.Push16(FlagRegister16);
        // 3358:370A jns short 0x370E
        if (!SignFlag)
        {
            goto label_3358_370E_36C8E_23910;
        }
    label_3358_370C_36C8C_23908:
        CheckExternalEvents(cs2, 0x370C);
        // 3358:370C neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_3358_370E_36C8E_23910:
        CheckExternalEvents(cs2, 0x370E);
        // 3358:370E shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:3710 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 3358:3712 shr BX,1
        BX = Alu16.Shr(BX, 1);
    label_3358_3714_36C94_23913:
        CheckExternalEvents(cs2, 0x3714);
        // 3358:3714 popf
        FlagRegister16 = Stack.Pop16();
    label_3358_3715_36C95_23915:
        CheckExternalEvents(cs2, 0x3715);
        // 3358:3715 jns short 0x3719
        if (!SignFlag)
        {
            goto label_3358_3719_36C99_23919;
        }
    label_3358_3717_36C97_23917:
        CheckExternalEvents(cs2, 0x3717);
        // 3358:3717 neg BX
        BX = Alu16.Sub((ushort)0x0000, BX);
        CarryFlag = BX != (ushort)0x0000;
    label_3358_3719_36C99_23919:
        CheckExternalEvents(cs2, 0x3719);
        // 3358:3719 mov word ptr CS:[0x35EA],DX
        UInt16[CS, (ushort)0x35EA] = DX;
        // 3358:371E mov word ptr CS:[0x35EC],BX
        UInt16[CS, (ushort)0x35EC] = BX;
        // 3358:3723 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_372D_36CAD(int loadOffset)
    {
    label_3358_372D_36CAD_23937:
        CheckExternalEvents(cs2, 0x372D);
        // 3358:372D mov CX,0x0014
        CX = (ushort)0x0014;
        // 3358:3730 mov SI,0x0014
        SI = (ushort)0x0014;
        return unknown_3358_3733_36CB3(0x0000);
    }

    public virtual Action unknown_3358_3733_36CB3(int loadOffset)
    {
    label_3358_3733_36CB3_23940:
        CheckExternalEvents(cs2, 0x3733);
        // 3358:3733 add SI,DX
        SI = Alu16.Add(SI, DX);
        // 3358:3735 add CX,BX
        CX = Alu16.Add(CX, BX);
        // 3358:3737 mov AX,4
        AX = (ushort)0x0004;
        // 3358:373A cmp DX,AX
        Alu16.Sub(DX, AX);
        // 3358:373C jge short 0x3740
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_3740_36CC0_23945;
        }
    label_3358_373E_36CBE_37418:
        CheckExternalEvents(cs2, 0x373E);
        // 3358:373E mov DX,AX
        DX = AX;
    label_3358_3740_36CC0_23945:
        CheckExternalEvents(cs2, 0x3740);
        // 3358:3740 cmp SI,AX
        Alu16.Sub(SI, AX);
        // 3358:3742 jge short 0x3746
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:3742");
        }
    label_3358_3746_36CC6_23948:
        CheckExternalEvents(cs2, 0x3746);
        // 3358:3746 mov AX,0x013C
        AX = (ushort)0x013C;
        // 3358:3749 cmp DX,AX
        Alu16.Sub(DX, AX);
        // 3358:374B jle short 0x374F
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:374B");
        }
    label_3358_374F_36CCF_23952:
        CheckExternalEvents(cs2, 0x374F);
        // 3358:374F cmp SI,AX
        Alu16.Sub(SI, AX);
        // 3358:3751 jle short 0x3755
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_3755_36CD5_23955;
        }
    label_3358_3753_36CD3_36755:
        CheckExternalEvents(cs2, 0x3753);
        // 3358:3753 mov SI,AX
        SI = AX;
    label_3358_3755_36CD5_23955:
        CheckExternalEvents(cs2, 0x3755);
        // 3358:3755 mov AX,4
        AX = (ushort)0x0004;
        // 3358:3758 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 3358:375A jge short 0x375E
        if (SignFlag == OverflowFlag)
        {
            goto label_3358_375E_36CDE_23959;
        }
    label_3358_375C_36CDC_38368:
        CheckExternalEvents(cs2, 0x375C);
        // 3358:375C mov BX,AX
        BX = AX;
    label_3358_375E_36CDE_23959:
        CheckExternalEvents(cs2, 0x375E);
        // 3358:375E cmp CX,AX
        Alu16.Sub(CX, AX);
        // 3358:3760 jge short 0x3764
        if (!(SignFlag == OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:3760");
        }
    label_3358_3764_36CE4_23962:
        CheckExternalEvents(cs2, 0x3764);
        // 3358:3764 mov AX,0x0094
        AX = (ushort)0x0094;
        // 3358:3767 cmp BX,AX
        Alu16.Sub(BX, AX);
        // 3358:3769 jle short 0x376D
        if (!(ZeroFlag || SignFlag != OverflowFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 3358:3769");
        }
    label_3358_376D_36CED_23966:
        CheckExternalEvents(cs2, 0x376D);
        // 3358:376D cmp CX,AX
        Alu16.Sub(CX, AX);
        // 3358:376F jle short 0x3773
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_3773_36CF3_23969;
        }
    label_3358_3771_36CF1_33463:
        CheckExternalEvents(cs2, 0x3771);
        // 3358:3771 mov CX,AX
        CX = AX;
    label_3358_3773_36CF3_23969:
        CheckExternalEvents(cs2, 0x3773);
        // 3358:3773 sub SI,DX
        SI = Alu16.Sub(SI, DX);
        // 3358:3775 sub CX,BX
        CX = Alu16.Sub(CX, BX);
        // 3358:3777 inc SI
        SI = Alu16.Inc(SI);
        // 3358:3778 sub CX,2
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:377B call near 0x0C10
        NearCall(cs2, 0x377E, unknown_3358_0C10_34190);
    label_3358_377E_36CFE_23975:
        CheckExternalEvents(cs2, 0x377E);
        // 3358:377E push CX
        Stack.Push16(CX);
        // 3358:377F push CX
        Stack.Push16(CX);
        // 3358:3780 mov CX,SI
        CX = SI;
        // 3358:3782 mov AL,0x0F
        AL = (byte)0x0F;
    label_3358_3784_36D04_23980:
        CheckExternalEvents(cs2, 0x3784);
        // 3358:3784 xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:3786 inc DI
        DI = Alu16.Inc(DI);
        // 3358:3787 loop 0x3784
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3784_36D04_23980;
        }
    label_3358_3789_36D09_23984:
        CheckExternalEvents(cs2, 0x3789);
        // 3358:3789 dec DI
        DI = Alu16.Dec(DI);
        // 3358:378A pop CX
        CX = Stack.Pop16();
        // 3358:378B or CX,CX
        CX = Alu16.Or(CX, CX);
        // 3358:378D jle short 0x379B
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_379B_36D1B_23995;
        }
    label_3358_378F_36D0F_23989:
        CheckExternalEvents(cs2, 0x378F);
        // 3358:378F add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:3793 xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:3795 loop 0x378F
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_378F_36D0F_23989;
        }
    label_3358_3797_36D17_23993:
        CheckExternalEvents(cs2, 0x3797);
        // 3358:3797 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
    label_3358_379B_36D1B_23995:
        CheckExternalEvents(cs2, 0x379B);
        // 3358:379B mov CX,SI
        CX = SI;
    label_3358_379D_36D1D_23996:
        CheckExternalEvents(cs2, 0x379D);
        // 3358:379D xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:379F dec DI
        DI = Alu16.Dec(DI);
        // 3358:37A0 loop 0x379D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_379D_36D1D_23996;
        }
    label_3358_37A2_36D22_24000:
        CheckExternalEvents(cs2, 0x37A2);
        // 3358:37A2 inc DI
        DI = Alu16.Inc(DI);
        // 3358:37A3 pop CX
        CX = Stack.Pop16();
        // 3358:37A4 or CX,CX
        CX = Alu16.Or(CX, CX);
        // 3358:37A6 jle short 0x37B0
        if (ZeroFlag || SignFlag != OverflowFlag)
        {
            goto label_3358_37B0_36D30_24009;
        }
    label_3358_37A8_36D28_24005:
        CheckExternalEvents(cs2, 0x37A8);
        // 3358:37A8 sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
        // 3358:37AC xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:37AE loop 0x37A8
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_37A8_36D28_24005;
        }
    label_3358_37B0_36D30_24009:
        CheckExternalEvents(cs2, 0x37B0);
        // 3358:37B0 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_3358_37B1_36D31(int loadOffset)
    {
    label_3358_37B1_36D31_24047:
        CheckExternalEvents(cs2, 0x37B1);
        // 3358:37B1 push BP
        Stack.Push16(BP);
        // 3358:37B2 mov BP,CX
        BP = CX;
        // 3358:37B4 call near 0x0C10
        NearCall(cs2, 0x37B7, unknown_3358_0C10_34190);
    label_3358_37B7_36D37_24051:
        CheckExternalEvents(cs2, 0x37B7);
        // 3358:37B7 mov AX,0x0F0F
        AX = (ushort)0x0F0F;
        // 3358:37BA mov CX,5
        CX = (ushort)0x0005;
    label_3358_37BD_36D3D_24054:
        CheckExternalEvents(cs2, 0x37BD);
        // 3358:37BD xor word ptr DS:[DI],AX
        UInt16[DS, DI] = Alu16.Xor(UInt16[DS, DI], AX);
        // 3358:37BF add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:37C2 loop 0x37BD
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_37BD_36D3D_24054;
        }
    label_3358_37C4_36D44_24058:
        CheckExternalEvents(cs2, 0x37C4);
        // 3358:37C4 add DI,BP
        DI = Alu16.Add(DI, BP);
        // 3358:37C6 sub DI,0x0014
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 3358:37C9 mov CX,5
        CX = (ushort)0x0005;
    label_3358_37CC_36D4C_24062:
        CheckExternalEvents(cs2, 0x37CC);
        // 3358:37CC xor word ptr DS:[DI],AX
        UInt16[DS, DI] = Alu16.Xor(UInt16[DS, DI], AX);
        // 3358:37CE add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:37D1 loop 0x37CC
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_37CC_36D4C_24062;
        }
    label_3358_37D3_36D53_24066:
        CheckExternalEvents(cs2, 0x37D3);
        // 3358:37D3 dec DI
        DI = Alu16.Dec(DI);
        // 3358:37D4 mov CX,9
        CX = (ushort)0x0009;
    label_3358_37D7_36D57_24069:
        CheckExternalEvents(cs2, 0x37D7);
        // 3358:37D7 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:37DB xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:37DD loop 0x37D7
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_37D7_36D57_24069;
        }
    label_3358_37DF_36D5F_24073:
        CheckExternalEvents(cs2, 0x37DF);
        // 3358:37DF mov AX,SI
        AX = SI;
        // 3358:37E1 sub AX,0x0014
        AX = Alu16.Sub(AX, (ushort)0x0014);
        // 3358:37E4 mov CX,0x0140
        CX = (ushort)0x0140;
        // 3358:37E7 imul CX
        int result_3358_37E7_36D67 = Alu16.Imul(unchecked((short)AX), unchecked((short)CX));
        DX = unchecked((ushort)(result_3358_37E7_36D67 >> 16));
        AX = unchecked((ushort)result_3358_37E7_36D67);
        // 3358:37E9 add DI,AX
        DI = Alu16.Add(DI, AX);
        // 3358:37EB mov AX,0x0F0F
        AX = (ushort)0x0F0F;
        // 3358:37EE mov CX,9
        CX = (ushort)0x0009;
    label_3358_37F1_36D71_24081:
        CheckExternalEvents(cs2, 0x37F1);
        // 3358:37F1 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:37F5 xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:37F7 loop 0x37F1
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_37F1_36D71_24081;
        }
    label_3358_37F9_36D79_24085:
        CheckExternalEvents(cs2, 0x37F9);
        // 3358:37F9 add DI,0x0140
        DI = Alu16.Add(DI, (ushort)0x0140);
        // 3358:37FD dec DI
        DI = Alu16.Dec(DI);
        // 3358:37FE mov CX,5
        CX = (ushort)0x0005;
    label_3358_3801_36D81_24089:
        CheckExternalEvents(cs2, 0x3801);
        // 3358:3801 xor word ptr DS:[DI],AX
        UInt16[DS, DI] = Alu16.Xor(UInt16[DS, DI], AX);
        // 3358:3803 sub DI,2
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:3806 loop 0x3801
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3801_36D81_24089;
        }
    label_3358_3808_36D88_24093:
        CheckExternalEvents(cs2, 0x3808);
        // 3358:3808 sub DI,BP
        DI = Alu16.Sub(DI, BP);
        // 3358:380A add DI,0x0014
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)20)));
        // 3358:380D mov CX,5
        CX = (ushort)0x0005;
    label_3358_3810_36D90_24097:
        CheckExternalEvents(cs2, 0x3810);
        // 3358:3810 xor word ptr DS:[DI],AX
        UInt16[DS, DI] = Alu16.Xor(UInt16[DS, DI], AX);
        // 3358:3812 sub DI,2
        DI = Alu16.Sub(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:3815 loop 0x3810
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3810_36D90_24097;
        }
    label_3358_3817_36D97_24101:
        CheckExternalEvents(cs2, 0x3817);
        // 3358:3817 add DI,2
        DI = Alu16.Add(DI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 3358:381A mov CX,9
        CX = (ushort)0x0009;
    label_3358_381D_36D9D_24104:
        CheckExternalEvents(cs2, 0x381D);
        // 3358:381D sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
        // 3358:3821 xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:3823 loop 0x381D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_381D_36D9D_24104;
        }
    label_3358_3825_36DA5_24108:
        CheckExternalEvents(cs2, 0x3825);
        // 3358:3825 mov AX,SI
        AX = SI;
        // 3358:3827 sub AX,0x0014
        AX = Alu16.Sub(AX, (ushort)0x0014);
        // 3358:382A mov CX,0x0140
        CX = (ushort)0x0140;
        // 3358:382D imul CX
        int result_3358_382D_36DAD = Alu16.Imul(unchecked((short)AX), unchecked((short)CX));
        DX = unchecked((ushort)(result_3358_382D_36DAD >> 16));
        AX = unchecked((ushort)result_3358_382D_36DAD);
        // 3358:382F sub DI,AX
        DI = Alu16.Sub(DI, AX);
        // 3358:3831 mov AX,0x0F0F
        AX = (ushort)0x0F0F;
        // 3358:3834 mov CX,9
        CX = (ushort)0x0009;
    label_3358_3837_36DB7_24116:
        CheckExternalEvents(cs2, 0x3837);
        // 3358:3837 sub DI,0x0140
        DI = Alu16.Sub(DI, (ushort)0x0140);
        // 3358:383B xor byte ptr DS:[DI],AL
        UInt8[DS, DI] = Alu8.Xor(UInt8[DS, DI], AL);
        // 3358:383D loop 0x3837
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_3358_3837_36DB7_24116;
        }
    label_3358_383F_36DBF_24120:
        CheckExternalEvents(cs2, 0x383F);
        // 3358:383F pop BP
        BP = Stack.Pop16();
        // 3358:3840 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0100_56520(int loadOffset)
    {
    label_5642_0100_56520_1273:
        CheckExternalEvents(cs3, 0x0100);
        // 5642:0100 jmp short 0x0120
    label_5642_0120_56540_1275:
        CheckExternalEvents(cs3, 0x0120);
        // 5642:0120 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 5642:0122 je short 0x0144
        if (ZeroFlag)
        {
            goto label_5642_0144_56564_1368;
        }
    label_5642_0124_56544_1278:
        CheckExternalEvents(cs3, 0x0124);
        // 5642:0124 push AX
        Stack.Push16(AX);
        // 5642:0125 and AL,0x0F
        AL = Alu8.And(AL, (byte)0x0F);
        // 5642:0127 mov BX,2
        BX = (ushort)0x0002;
        // 5642:012A call near 0x082B
        NearCall(cs3, 0x012D, unknown_5642_082B_56C4B);
    label_5642_012D_5654D_1325:
        CheckExternalEvents(cs3, 0x012D);
        // 5642:012D pop AX
        AX = Stack.Pop16();
        // 5642:012E shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0130 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0132 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0134 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0136 push AX
        Stack.Push16(AX);
        // 5642:0137 mov BX,1
        BX = (ushort)0x0001;
        // 5642:013A call near 0x082B
        NearCall(cs3, 0x013D, unknown_5642_082B_56C4B);
    label_5642_013D_5655D_1344:
        CheckExternalEvents(cs3, 0x013D);
        // 5642:013D pop AX
        AX = Stack.Pop16();
        // 5642:013E mov BX,0x000D
        BX = (ushort)0x000D;
        // 5642:0141 call near 0x082B
        NearCall(cs3, 0x0144, unknown_5642_082B_56C4B);
    label_5642_0144_56564_1368:
        CheckExternalEvents(cs3, 0x0144);
        // 5642:0144 mov BX,3
        BX = (ushort)0x0003;
        // 5642:0147 call near 0x082B
        NearCall(cs3, 0x014A, unknown_5642_082B_56C4B);
    label_5642_014A_5656A_1694:
        CheckExternalEvents(cs3, 0x014A);
        // 5642:014A mov word ptr CS:[0x011C],0x0100
        UInt16[CS, (ushort)0x011C] = (ushort)0x0100;
        // 5642:0151 mov word ptr CS:[0x011E],CS
        UInt16[CS, (ushort)0x011E] = CS;
        // 5642:0156 mov word ptr CS:[0x0118],0x0100
        UInt16[CS, (ushort)0x0118] = (ushort)0x0100;
        // 5642:015D mov word ptr CS:[0x011A],CS
        UInt16[CS, (ushort)0x011A] = CS;
        // 5642:0162 push CS
        Stack.Push16(CS);
        // 5642:0163 call near 0x01C2
        NearCall(cs3, 0x0166, unknown_5642_01C2_565E2);
    label_5642_0166_56586_1718:
        CheckExternalEvents(cs3, 0x0166);
        // 5642:0166 mov BX,0x000F
        BX = (ushort)0x000F;
        // 5642:0169 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0103_56523(int loadOffset)
    {
    label_5642_0103_56523_20139:
        CheckExternalEvents(cs3, 0x0103);
        // 5642:0103 jmp near 0x01C2
        return unknown_5642_01C2_565E2(0x0000);
    }

    public virtual Action unknown_5642_0106_56526(int loadOffset)
    {
    label_5642_0106_56526_1888:
        CheckExternalEvents(cs3, 0x0106);
        // 5642:0106 jmp near 0x01DE
        return unknown_5642_01DE_565FE(0x0000);
    }

    public virtual Action unknown_5642_0109_56529(int loadOffset)
    {
    label_5642_0109_56529_1856:
        CheckExternalEvents(cs3, 0x0109);
        // 5642:0109 jmp near 0x01C2
        return unknown_5642_01C2_565E2(0x0000);
    }

    public virtual Action unknown_5642_010C_5652C(int loadOffset)
    {
    label_5642_010C_5652C_3457:
        CheckExternalEvents(cs3, 0x010C);
        // 5642:010C jmp near 0x01CB
    label_5642_01CB_565EB_3459:
        CheckExternalEvents(cs3, 0x01CB);
        // 5642:01CB push AX
        Stack.Push16(AX);
        // 5642:01CC xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:01CE push BX
        Stack.Push16(BX);
        // 5642:01CF mov BX,0x000C
        BX = (ushort)0x000C;
        // 5642:01D2 call near 0x082B
        NearCall(cs3, 0x01D5, unknown_5642_082B_56C4B);
    label_5642_01D5_565F5_3478:
        CheckExternalEvents(cs3, 0x01D5);
        // 5642:01D5 pop BX
        BX = Stack.Pop16();
        // 5642:01D6 pop AX
        AX = Stack.Pop16();
        // 5642:01D7 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0112_56532(int loadOffset)
    {
    label_5642_0112_56532_5571:
        CheckExternalEvents(cs3, 0x0112);
        // 5642:0112 jmp near 0x0217
    label_5642_0217_56637_5573:
        CheckExternalEvents(cs3, 0x0217);
        // 5642:0217 push ES
        Stack.Push16(ES);
        // 5642:0218 mov word ptr CS:[0x011C],SI
        UInt16[CS, (ushort)0x011C] = SI;
        // 5642:021D mov word ptr CS:[0x011E],DS
        UInt16[CS, (ushort)0x011E] = DS;
        // 5642:0222 les DI,word ptr DS:[SI]
        ushort lxsOffset_5642_0222_56642 = SI;
        ushort lxsValue_5642_0222_56642 = UInt16[DS, lxsOffset_5642_0222_56642];
        ushort lxsSegment_5642_0222_56642 = UInt16[DS, (ushort)(lxsOffset_5642_0222_56642 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_5642_0222_56642);
        ES = unchecked((ushort)lxsSegment_5642_0222_56642);
        // 5642:0224 mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 5642:0227 cmp byte ptr DS:[SI+7],0
        Alu8.Sub(UInt8[DS, (ushort)(SI + (sbyte)7)], (byte)0x00);
        // 5642:022B jns short 0x0232
        if (!SignFlag)
        {
            goto label_5642_0232_56652_5581;
        }
    label_5642_022D_5664D_10142:
        CheckExternalEvents(cs3, 0x022D);
        // 5642:022D or BX,BX
        BX = Alu16.Or(BX, BX);
        // 5642:022F je short 0x0232
        if (ZeroFlag)
        {
            goto label_5642_0232_56652_5581;
        }
    label_5642_0231_56651_10145:
        CheckExternalEvents(cs3, 0x0231);
        // 5642:0231 dec BX
        BX = Alu16.Dec(BX);
    label_5642_0232_56652_5581:
        CheckExternalEvents(cs3, 0x0232);
        // 5642:0232 mov byte ptr ES:[BX+DI+6],0
        UInt8[ES, (ushort)(BX + DI + (sbyte)6)] = (byte)0x00;
        // 5642:0237 mov byte ptr ES:[DI+2],2
        UInt8[ES, (ushort)(DI + (sbyte)2)] = (byte)0x02;
        // 5642:023C mov word ptr ES:[DI+3],BX
        UInt16[ES, (ushort)(DI + (sbyte)3)] = BX;
        // 5642:0240 mov byte ptr ES:[DI+5],0
        UInt8[ES, (ushort)(DI + (sbyte)5)] = (byte)0x00;
        // 5642:0245 mov byte ptr DS:[SI+6],2
        UInt8[DS, (ushort)(SI + (sbyte)6)] = (byte)0x02;
        // 5642:0249 cmp byte ptr CS:[0x0292],0
        Alu8.Sub(UInt8[CS, (ushort)0x0292], (byte)0x00);
        // 5642:024F jne short 0x0281
        if (!ZeroFlag)
        {
            goto label_5642_0281_566A1_5589;
        }
    label_5642_0251_56671_8577:
        CheckExternalEvents(cs3, 0x0251);
        // 5642:0251 cmp byte ptr CS:[0x02FE],0
        Alu8.Sub(UInt8[CS, (ushort)0x02FE], (byte)0x00);
        // 5642:0257 jne short 0x0281
        if (!ZeroFlag)
        {
            goto label_5642_0281_566A1_5589;
        }
    label_5642_0259_56679_25668:
        CheckExternalEvents(cs3, 0x0259);
        // 5642:0259 lds SI,word ptr CS:[0x011C]
        ushort lxsOffset_5642_0259_56679 = (ushort)0x011C;
        ushort lxsValue_5642_0259_56679 = UInt16[CS, lxsOffset_5642_0259_56679];
        ushort lxsSegment_5642_0259_56679 = UInt16[CS, (ushort)(lxsOffset_5642_0259_56679 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_0259_56679);
        DS = unchecked((ushort)lxsSegment_5642_0259_56679);
        // 5642:025E les DI,word ptr DS:[SI]
        ushort lxsOffset_5642_025E_5667E = SI;
        ushort lxsValue_5642_025E_5667E = UInt16[DS, lxsOffset_5642_025E_5667E];
        ushort lxsSegment_5642_025E_5667E = UInt16[DS, (ushort)(lxsOffset_5642_025E_5667E + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_5642_025E_5667E);
        ES = unchecked((ushort)lxsSegment_5642_025E_5667E);
        // 5642:0260 add word ptr DS:[SI+4],6
        UInt16[DS, (ushort)(SI + (sbyte)4)] = Alu16.Add(UInt16[DS, (ushort)(SI + (sbyte)4)], unchecked((ushort)unchecked((short)(sbyte)6)));
        // 5642:0264 mov byte ptr ES:[DI],1
        UInt8[ES, DI] = (byte)0x01;
        // 5642:0268 mov byte ptr ES:[DI+3],1
        UInt8[ES, (ushort)(DI + (sbyte)3)] = (byte)0x01;
        // 5642:026D mov AL,byte ptr CS:[0x02FC]
        AL = UInt8[CS, (ushort)0x02FC];
        // 5642:0271 mov byte ptr ES:[DI+4],AL
        UInt8[ES, (ushort)(DI + (sbyte)4)] = AL;
        // 5642:0275 mov AL,byte ptr CS:[0x02FD]
        AL = UInt8[CS, (ushort)0x02FD];
        // 5642:0279 mov byte ptr ES:[DI+5],AL
        UInt8[ES, (ushort)(DI + (sbyte)5)] = AL;
        // 5642:027D push CS
        Stack.Push16(CS);
        // 5642:027E call near 0x01DE
        NearCall(cs3, 0x0281, unknown_5642_01DE_565FE);
    label_5642_0281_566A1_5589:
        CheckExternalEvents(cs3, 0x0281);
        // 5642:0281 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0282 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0115_56535(int loadOffset)
    {
    label_5642_0115_56535_1731:
        CheckExternalEvents(cs3, 0x0115);
        // 5642:0115 jmp near 0x01A7
    label_5642_01A7_565C7_1733:
        CheckExternalEvents(cs3, 0x01A7);
        // 5642:01A7 call near 0x016A
        NearCall(cs3, 0x01AA, unknown_5642_016A_5658A);
    label_5642_01AA_565CA_1769:
        CheckExternalEvents(cs3, 0x01AA);
        // 5642:01AA mov AH,4
        AH = (byte)0x04;
        // 5642:01AC call near 0x01B0
        NearCall(cs3, 0x01AF, unknown_5642_01B0_565D0);
    label_5642_01AF_565CF_1783:
        CheckExternalEvents(cs3, 0x01AF);
        // 5642:01AF ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_016A_5658A(int loadOffset)
    {
    label_5642_016A_5658A_1735:
        CheckExternalEvents(cs3, 0x016A);
        // 5642:016A push BX
        Stack.Push16(BX);
        // 5642:016B push DX
        Stack.Push16(DX);
        // 5642:016C shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5642:016E shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5642:0170 shr AL,1
        AL = Alu8.Shr(AL, 1);
        // 5642:0172 mov DX,AX
        DX = AX;
        // 5642:0174 mov BX,0xF078
        BX = (ushort)0xF078;
        // 5642:0177 cmp AH,BL
        Alu8.Sub(AH, BL);
        // 5642:0179 jbe short 0x017D
        if (CarryFlag || ZeroFlag)
        {
            goto label_5642_017D_5659D_1745;
        }
    label_5642_017B_5659B_25741:
        CheckExternalEvents(cs3, 0x017B);
        // 5642:017B mov AH,BL
        AH = BL;
    label_5642_017D_5659D_1745:
        CheckExternalEvents(cs3, 0x017D);
        // 5642:017D xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:017F div BH
        byte divisor_5642_017F_5659F = BH;
        ushort dividend_5642_017F_5659F = AX;
        byte quotient_5642_017F_5659F = Alu8.Div(unchecked((ushort)dividend_5642_017F_5659F), unchecked((byte)divisor_5642_017F_5659F));
        AL = unchecked((byte)quotient_5642_017F_5659F);
        AH = unchecked((byte)(dividend_5642_017F_5659F % unchecked((ushort)divisor_5642_017F_5659F)));
        // 5642:0181 mul DL
        ushort result_5642_0181_565A1 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)DL)));
        AH = unchecked((byte)(result_5642_0181_565A1 >> 8));
        AL = unchecked((byte)result_5642_0181_565A1);
        // 5642:0183 xchg AH,DH
        byte temp_5642_0183_565A3 = AH;
        AH = DH;
        DH = unchecked((byte)temp_5642_0183_565A3);
        // 5642:0185 sub AH,BH
        AH = Alu8.Sub(AH, BH);
        // 5642:0187 neg AH
        AH = Alu8.Sub((byte)0x00, AH);
        CarryFlag = AH != (byte)0x00;
        // 5642:0189 cmp AH,BL
        Alu8.Sub(AH, BL);
        // 5642:018B jbe short 0x018F
        if (CarryFlag || ZeroFlag)
        {
            goto label_5642_018F_565AF_1756;
        }
    label_5642_018D_565AD_1754:
        CheckExternalEvents(cs3, 0x018D);
        // 5642:018D mov AH,BL
        AH = BL;
    label_5642_018F_565AF_1756:
        CheckExternalEvents(cs3, 0x018F);
        // 5642:018F xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:0191 div BH
        byte divisor_5642_0191_565B1 = BH;
        ushort dividend_5642_0191_565B1 = AX;
        byte quotient_5642_0191_565B1 = Alu8.Div(unchecked((ushort)dividend_5642_0191_565B1), unchecked((byte)divisor_5642_0191_565B1));
        AL = unchecked((byte)quotient_5642_0191_565B1);
        AH = unchecked((byte)(dividend_5642_0191_565B1 % unchecked((ushort)divisor_5642_0191_565B1)));
        // 5642:0193 mul DL
        ushort result_5642_0193_565B3 = Alu8.Mul(AL, unchecked((byte)unchecked((sbyte)DL)));
        AH = unchecked((byte)(result_5642_0193_565B3 >> 8));
        AL = unchecked((byte)result_5642_0193_565B3);
        // 5642:0195 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0197 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:0199 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:019B shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:019D mov AH,DH
        AH = DH;
        // 5642:019F and AX,0x0FF0
        AX = Alu16.And(AX, (ushort)0x0FF0);
        // 5642:01A2 or AL,AH
        AL = Alu8.Or(AL, AH);
        // 5642:01A4 pop DX
        DX = Stack.Pop16();
        // 5642:01A5 pop BX
        BX = Stack.Pop16();
        // 5642:01A6 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_01B0_565D0(int loadOffset)
    {
    label_5642_01B0_565D0_1772:
        CheckExternalEvents(cs3, 0x01B0);
        // 5642:01B0 push DX
        Stack.Push16(DX);
        // 5642:01B1 mov DX,word ptr CS:[0x0285]
        DX = UInt16[CS, (ushort)0x0285];
        // 5642:01B6 add DL,4
        DL = Alu8.Add(DL, (byte)0x04);
        // 5642:01B9 xchg AL,AH
        byte temp_5642_01B9_565D9 = AL;
        AL = AH;
        AH = unchecked((byte)temp_5642_01B9_565D9);
        // 5642:01BB out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:01BC inc DX
        DX = Alu16.Inc(DX);
        // 5642:01BD xchg AL,AH
        byte temp_5642_01BD_565DD = AL;
        AL = AH;
        AH = unchecked((byte)temp_5642_01BD_565DD);
        // 5642:01BF out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:01C0 pop DX
        DX = Stack.Pop16();
        // 5642:01C1 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_01C2_565E2(int loadOffset)
    {
    label_5642_01C2_565E2_1701:
        CheckExternalEvents(cs3, 0x01C2);
        // 5642:01C2 push BX
        Stack.Push16(BX);
        // 5642:01C3 mov BX,8
        BX = (ushort)0x0008;
        // 5642:01C6 call near 0x082B
        NearCall(cs3, 0x01C9, unknown_5642_082B_56C4B);
    label_5642_01C9_565E9_1715:
        CheckExternalEvents(cs3, 0x01C9);
        // 5642:01C9 pop BX
        BX = Stack.Pop16();
        // 5642:01CA ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_01DE_565FE(int loadOffset)
    {
    label_5642_01DE_565FE_1890:
        CheckExternalEvents(cs3, 0x01DE);
        // 5642:01DE push ES
        Stack.Push16(ES);
        // 5642:01DF mov word ptr CS:[0x0118],SI
        UInt16[CS, (ushort)0x0118] = SI;
        // 5642:01E4 mov word ptr CS:[0x011A],DS
        UInt16[CS, (ushort)0x011A] = DS;
        // 5642:01E9 les DI,word ptr DS:[SI]
        ushort lxsOffset_5642_01E9_56609 = SI;
        ushort lxsValue_5642_01E9_56609 = UInt16[DS, lxsOffset_5642_01E9_56609];
        ushort lxsSegment_5642_01E9_56609 = UInt16[DS, (ushort)(lxsOffset_5642_01E9_56609 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_5642_01E9_56609);
        ES = unchecked((ushort)lxsSegment_5642_01E9_56609);
        // 5642:01EB mov BX,word ptr DS:[SI+4]
        BX = UInt16[DS, (ushort)(SI + (sbyte)4)];
        // 5642:01EE or byte ptr DS:[SI+6],3
        UInt8[DS, (ushort)(SI + (sbyte)6)] = Alu8.Or(UInt8[DS, (ushort)(SI + (sbyte)6)], (byte)0x03);
        // 5642:01F2 mov byte ptr ES:[BX+DI],0
        UInt8[ES, (ushort)(BX + DI)] = (byte)0x00;
        // 5642:01F6 sub BX,4
        BX = Alu16.Sub(BX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 5642:01F9 cmp byte ptr ES:[DI+3],0
        Alu8.Sub(UInt8[ES, (ushort)(DI + (sbyte)3)], (byte)0x00);
        // 5642:01FE jne short 0x0206
        if (!ZeroFlag)
        {
            goto label_5642_0206_56626_5565;
        }
    label_5642_0200_56620_1901:
        CheckExternalEvents(cs3, 0x0200);
        // 5642:0200 cmp word ptr ES:[DI+1],BX
        Alu16.Sub(UInt16[ES, (ushort)(DI + (sbyte)1)], BX);
        // 5642:0204 jb short 0x020F
        if (CarryFlag)
        {
            goto label_5642_020F_5662F_1904;
        }
    label_5642_0206_56626_5565:
        CheckExternalEvents(cs3, 0x0206);
        // 5642:0206 mov word ptr ES:[DI+1],BX
        UInt16[ES, (ushort)(DI + (sbyte)1)] = BX;
        // 5642:020A mov byte ptr ES:[DI+3],0
        UInt8[ES, (ushort)(DI + (sbyte)3)] = (byte)0x00;
    label_5642_020F_5662F_1904:
        CheckExternalEvents(cs3, 0x020F);
        // 5642:020F mov BX,6
        BX = (ushort)0x0006;
        // 5642:0212 call near 0x082B
        NearCall(cs3, 0x0215, unknown_5642_082B_56C4B);
    label_5642_0215_56635_2068:
        CheckExternalEvents(cs3, 0x0215);
        // 5642:0215 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0216 ret far
        return FarRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_02FF_5671F(int loadOffset)
    {
    label_5642_02FF_5671F_1425:
        CheckExternalEvents(cs3, 0x02FF);
        // 5642:02FF push CX
        Stack.Push16(CX);
        // 5642:0300 mov CX,0x0200
        CX = (ushort)0x0200;
        // 5642:0303 mov AH,AL
        AH = AL;
        // 5642:0305 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0306 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5642:0308 jns short 0x030F
        if (!(!SignFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0308");
        }
    label_5642_030F_5672F_1432:
        CheckExternalEvents(cs3, 0x030F);
        // 5642:030F mov AL,AH
        AL = AH;
        // 5642:0311 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0312 clc
        CarryFlag = false;
        // 5642:0313 pop CX
        CX = Stack.Pop16();
        // 5642:0314 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0315_56735(int loadOffset)
    {
    label_5642_0315_56735_1389:
        CheckExternalEvents(cs3, 0x0315);
        // 5642:0315 push CX
        Stack.Push16(CX);
        // 5642:0316 push DX
        Stack.Push16(DX);
        // 5642:0317 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:031B add DL,0x0E
        DL = Alu8.Add(DL, (byte)0x0E);
        // 5642:031E mov CX,0x0200
        CX = (ushort)0x0200;
    label_5642_0321_56741_1395:
        CheckExternalEvents(cs3, 0x0321);
        // 5642:0321 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0322 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5642:0324 js short 0x032B
        if (SignFlag)
        {
            goto label_5642_032B_5674B_1401;
        }
    label_5642_0326_56746_1398:
        CheckExternalEvents(cs3, 0x0326);
        // 5642:0326 loop 0x0321
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5642_0321_56741_1395;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0326");
        }
    label_5642_032B_5674B_1401:
        CheckExternalEvents(cs3, 0x032B);
        // 5642:032B sub DL,4
        DL = Alu8.Sub(DL, (byte)0x04);
        // 5642:032E in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:032F clc
        CarryFlag = false;
        // 5642:0330 pop DX
        DX = Stack.Pop16();
        // 5642:0331 pop CX
        CX = Stack.Pop16();
        // 5642:0332 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0333_56753(int loadOffset)
    {
    label_5642_0333_56753_1606:
        CheckExternalEvents(cs3, 0x0333);
        // 5642:0333 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:0337 add DL,0x0C
        DL = Alu8.Add(DL, (byte)0x0C);
        return unknown_5642_033A_5675A(0x0000);
    }

    public virtual Action unknown_5642_033A_5675A(int loadOffset)
    {
    label_5642_033A_5675A_1464:
        CheckExternalEvents(cs3, 0x033A);
        // 5642:033A mov AH,AL
        AH = AL;
        // 5642:033C mov AL,0xF0
        AL = (byte)0xF0;
    label_5642_033E_5675E_1467:
        CheckExternalEvents(cs3, 0x033E);
        // 5642:033E in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:033F or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5642:0341 js short 0x033E
        if (SignFlag)
        {
            goto label_5642_033E_5675E_1467;
        }
    label_5642_0343_56763_1470:
        CheckExternalEvents(cs3, 0x0343);
        // 5642:0343 mov AL,AH
        AL = AH;
        // 5642:0345 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0346 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0347_56767(int loadOffset)
    {
    label_5642_0347_56767_1476:
        CheckExternalEvents(cs3, 0x0347);
        // 5642:0347 push DX
        Stack.Push16(DX);
        // 5642:0348 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:034C add DL,0x0E
        DL = Alu8.Add(DL, (byte)0x0E);
        // 5642:034F xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:0351 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0352 or AL,AL
        AL = Alu8.Or(AL, AL);
        // 5642:0354 jns short 0x0351
        if (!SignFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:0354");
        }
    label_5642_0356_56776_1484:
        CheckExternalEvents(cs3, 0x0356);
        // 5642:0356 sub DL,4
        DL = Alu8.Sub(DL, (byte)0x04);
        // 5642:0359 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:035A pop DX
        DX = Stack.Pop16();
        // 5642:035B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_035C_5677C(int loadOffset)
    {
    label_5642_035C_5677C_1376:
        CheckExternalEvents(cs3, 0x035C);
        // 5642:035C mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:0360 add DL,6
        DL = Alu8.Add(DL, (byte)0x06);
        // 5642:0363 mov AL,1
        AL = (byte)0x01;
        // 5642:0365 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0366 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0367 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0368 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0369 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:036A xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:036C out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:036D mov BL,0x10
        BL = (byte)0x10;
        // 5642:036F call near 0x0315
        NearCall(cs3, 0x0372, unknown_5642_0315_56735);
    label_5642_0372_56792_1408:
        CheckExternalEvents(cs3, 0x0372);
        // 5642:0372 cmp AL,0xAA
        Alu8.Sub(AL, (byte)0xAA);
        // 5642:0374 je short 0x0380
        if (!(ZeroFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0374");
        }
    label_5642_0380_567A0_1411:
        CheckExternalEvents(cs3, 0x0380);
        // 5642:0380 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0382 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 5642:0384 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0385_567A5(int loadOffset)
    {
    label_5642_0385_567A5_1419:
        CheckExternalEvents(cs3, 0x0385);
        // 5642:0385 mov BX,2
        BX = (ushort)0x0002;
        // 5642:0388 mov AL,0xE0
        AL = (byte)0xE0;
        // 5642:038A mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:038E add DL,0x0C
        DL = Alu8.Add(DL, (byte)0x0C);
        // 5642:0391 call near 0x02FF
        NearCall(cs3, 0x0394, unknown_5642_02FF_5671F);
    label_5642_0394_567B4_1438:
        CheckExternalEvents(cs3, 0x0394);
        // 5642:0394 jb short 0x03A8
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:0394");
        }
    label_5642_0396_567B6_1440:
        CheckExternalEvents(cs3, 0x0396);
        // 5642:0396 mov AL,0xAA
        AL = (byte)0xAA;
        // 5642:0398 call near 0x02FF
        NearCall(cs3, 0x039B, unknown_5642_02FF_5671F);
    label_5642_039B_567BB_1443:
        CheckExternalEvents(cs3, 0x039B);
        // 5642:039B jb short 0x03A8
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:039B");
        }
    label_5642_039D_567BD_1445:
        CheckExternalEvents(cs3, 0x039D);
        // 5642:039D call near 0x0315
        NearCall(cs3, 0x03A0, unknown_5642_0315_56735);
    label_5642_03A0_567C0_1447:
        CheckExternalEvents(cs3, 0x03A0);
        // 5642:03A0 jb short 0x03A8
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:03A0");
        }
    label_5642_03A2_567C2_1449:
        CheckExternalEvents(cs3, 0x03A2);
        // 5642:03A2 cmp AL,0x55
        Alu8.Sub(AL, (byte)0x55);
        // 5642:03A4 jne short 0x03A8
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:03A4");
        }
    label_5642_03A6_567C6_1452:
        CheckExternalEvents(cs3, 0x03A6);
        // 5642:03A6 xor BX,BX
        BX = Alu16.Xor(BX, BX);
        // 5642:03A8 mov AX,BX
        AX = BX;
        // 5642:03AA or AX,AX
        AX = Alu16.Or(AX, AX);
        // 5642:03AC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_03AD_567CD(int loadOffset)
    {
    label_5642_03AD_567CD_1629:
        CheckExternalEvents(cs3, 0x03AD);
        // 5642:03AD push AX
        Stack.Push16(AX);
        // 5642:03AE push DX
        Stack.Push16(DX);
        // 5642:03AF mov DX,word ptr CS:[0x0285]
        DX = UInt16[CS, (ushort)0x0285];
        // 5642:03B4 add DL,0x0E
        DL = Alu8.Add(DL, (byte)0x0E);
        // 5642:03B7 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:03B8 mov byte ptr CS:[0x028E],1
        UInt8[CS, (ushort)0x028E] = (byte)0x01;
        // 5642:03BE mov AL,0x20
        AL = (byte)0x20;
        // 5642:03C0 cmp byte ptr CS:[0x0287],8
        Alu8.Sub(UInt8[CS, (ushort)0x0287], (byte)0x08);
        // 5642:03C6 jb short 0x03CC
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:03C6");
        }
    label_5642_03CC_567EC_1639:
        CheckExternalEvents(cs3, 0x03CC);
        // 5642:03CC out 0x20,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x20), AL);
        // 5642:03CE pop DX
        DX = Stack.Pop16();
        // 5642:03CF pop AX
        AX = Stack.Pop16();
        // 5642:03D0 iret
        return InterruptRet();
    }

    public virtual Action unknown_5642_03D1_567F1(int loadOffset)
    {
    label_5642_03D1_567F1_1501:
        CheckExternalEvents(cs3, 0x03D1);
        // 5642:03D1 mov byte ptr DS:[0x028E],0
        UInt8[DS, (ushort)0x028E] = (byte)0x00;
        // 5642:03D6 mov AX,0x03AD
        AX = (ushort)0x03AD;
        // 5642:03D9 call near 0x04D8
        NearCall(cs3, 0x03DC, unknown_5642_04D8_568F8);
    label_5642_03DC_567FC_1553:
        CheckExternalEvents(cs3, 0x03DC);
        // 5642:03DC mov DX,CS
        DX = CS;
        // 5642:03DE mov AX,0x0291
        AX = (ushort)0x0291;
        // 5642:03E1 call near 0x048A
        NearCall(cs3, 0x03E4, unknown_5642_048A_568AA);
    label_5642_03E4_56804_1568:
        CheckExternalEvents(cs3, 0x03E4);
        // 5642:03E4 xor CX,CX
        CX = Alu16.Xor(CX, CX);
        // 5642:03E6 mov DH,0x48
        DH = (byte)0x48;
        // 5642:03E8 call near 0x0450
        NearCall(cs3, 0x03EB, unknown_5642_0450_56870);
    label_5642_03EB_5680B_1603:
        CheckExternalEvents(cs3, 0x03EB);
        // 5642:03EB mov AL,0x40
        AL = (byte)0x40;
        // 5642:03ED call near 0x0333
        NearCall(cs3, 0x03F0, unknown_5642_0333_56753);
    label_5642_03F0_56810_1609:
        CheckExternalEvents(cs3, 0x03F0);
        // 5642:03F0 mov AL,0x64
        AL = (byte)0x64;
        // 5642:03F2 call near 0x033A
        NearCall(cs3, 0x03F5, unknown_5642_033A_5675A);
    label_5642_03F5_56815_1612:
        CheckExternalEvents(cs3, 0x03F5);
        // 5642:03F5 mov AL,0x14
        AL = (byte)0x14;
        // 5642:03F7 call near 0x033A
        NearCall(cs3, 0x03FA, unknown_5642_033A_5675A);
    label_5642_03FA_5681A_1615:
        CheckExternalEvents(cs3, 0x03FA);
        // 5642:03FA xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:03FC call near 0x033A
        NearCall(cs3, 0x03FF, unknown_5642_033A_5675A);
    label_5642_03FF_5681F_1618:
        CheckExternalEvents(cs3, 0x03FF);
        // 5642:03FF xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:0401 call near 0x033A
        NearCall(cs3, 0x0404, unknown_5642_033A_5675A);
    label_5642_0404_56824_1621:
        CheckExternalEvents(cs3, 0x0404);
        // 5642:0404 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:0406 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
    label_5642_0409_56829_1624:
        CheckExternalEvents(cs3, 0x0409);
        // 5642:0409 cmp byte ptr DS:[0x028E],0
        Alu8.Sub(UInt8[DS, (ushort)0x028E], (byte)0x00);
        // 5642:040E jne short 0x0414
        if (!ZeroFlag)
        {
            goto label_5642_0414_56834_1644;
        }
    label_5642_0410_56830_1626:
        CheckExternalEvents(cs3, 0x0410);
        // 5642:0410 loop 0x0409
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000)
        {
            goto label_5642_0409_56829_1624;
        }
        else
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0410");
        }
    label_5642_0414_56834_1644:
        CheckExternalEvents(cs3, 0x0414);
        // 5642:0414 push AX
        Stack.Push16(AX);
        // 5642:0415 call near 0x0524
        NearCall(cs3, 0x0418, unknown_5642_0524_56944);
    label_5642_0418_56838_1668:
        CheckExternalEvents(cs3, 0x0418);
        // 5642:0418 pop AX
        AX = Stack.Pop16();
        // 5642:0419 or AX,AX
        AX = Alu16.Or(AX, AX);
        // 5642:041B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_041C_5683C(int loadOffset)
    {
    label_5642_041C_5683C_1461:
        CheckExternalEvents(cs3, 0x041C);
        // 5642:041C mov AL,0xE1
        AL = (byte)0xE1;
        // 5642:041E call near 0x033A
        NearCall(cs3, 0x0421, unknown_5642_033A_5675A);
    label_5642_0421_56841_1474:
        CheckExternalEvents(cs3, 0x0421);
        // 5642:0421 call near 0x0347
        NearCall(cs3, 0x0424, unknown_5642_0347_56767);
    label_5642_0424_56844_1489:
        CheckExternalEvents(cs3, 0x0424);
        // 5642:0424 mov AH,AL
        AH = AL;
        // 5642:0426 call near 0x0347
        NearCall(cs3, 0x0429, unknown_5642_0347_56767);
    label_5642_0429_56849_1492:
        CheckExternalEvents(cs3, 0x0429);
        // 5642:0429 cmp AX,0x0103
        Alu16.Sub(AX, (ushort)0x0103);
        // 5642:042C mov AX,0
        AX = (ushort)0x0000;
        // 5642:042F adc AL,AH
        AL = Alu8.Adc(AL, AH);
        // 5642:0431 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0432_56852(int loadOffset)
    {
    label_5642_0432_56852_5855:
        CheckExternalEvents(cs3, 0x0432);
        // 5642:0432 pushf
        Stack.Push16(FlagRegister16);
        // 5642:0433 mov CX,0x0064
        CX = (ushort)0x0064;
        // 5642:0436 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:043A add DL,0x0C
        DL = Alu8.Add(DL, (byte)0x0C);
    label_5642_043D_5685D_5860:
        CheckExternalEvents(cs3, 0x043D);
        // 5642:043D sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_5642_043E_5685E_5861:
        CheckExternalEvents(cs3, 0x043E);
        // 5642:043E cmp byte ptr DS:[0x0292],0
        Alu8.Sub(UInt8[DS, (ushort)0x0292], (byte)0x00);
        // 5642:0443 je short 0x044E
        if (ZeroFlag)
        {
            goto label_5642_044E_5686E_5873;
        }
    label_5642_0445_56865_5864:
        CheckExternalEvents(cs3, 0x0445);
        // 5642:0445 cli
        InterruptFlag = false;
        // 5642:0446 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:0447 test AL,0x80
        Alu8.And(AL, (byte)0x80);
        // 5642:0449 loopne 0x043D
        CX = unchecked((ushort)(CX - (ushort)0x0001));
        if (CX != (ushort)0x0000 && !ZeroFlag)
        {
            goto label_5642_043D_5685D_5860;
        }
    label_5642_044B_5686B_5870:
        CheckExternalEvents(cs3, 0x044B);
        // 5642:044B mov AL,0xD0
        AL = (byte)0xD0;
        // 5642:044D out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
    label_5642_044E_5686E_5873:
        CheckExternalEvents(cs3, 0x044E);
        // 5642:044E popf
        FlagRegister16 = Stack.Pop16();
    label_5642_044F_5686F_5875:
        CheckExternalEvents(cs3, 0x044F);
        // 5642:044F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0450_56870(int loadOffset)
    {
    label_5642_0450_56870_1572:
        CheckExternalEvents(cs3, 0x0450);
        // 5642:0450 push BX
        Stack.Push16(BX);
        // 5642:0451 mov BX,AX
        BX = AX;
        // 5642:0453 mov AH,DL
        AH = DL;
        // 5642:0455 mov AL,byte ptr CS:[0x0288]
        AL = UInt8[CS, (ushort)0x0288];
        // 5642:0459 mov DL,AL
        DL = AL;
        // 5642:045B or AL,4
        AL = Alu8.Or(AL, (byte)0x04);
        // 5642:045D out 0x0A,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x0A), AL);
        // 5642:045F xor AL,AL
        AL = Alu8.Xor(AL, AL);
        // 5642:0461 out 0x0C,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x0C), AL);
        // 5642:0463 mov AL,DH
        AL = DH;
        // 5642:0465 or AL,DL
        AL = Alu8.Or(AL, DL);
        // 5642:0467 out 0x0B,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x0B), AL);
        // 5642:0469 xor DH,DH
        DH = Alu8.Xor(DH, DH);
        // 5642:046B shl DX,1
        DX = Alu16.Shl(DX, 1);
        // 5642:046D mov AL,BL
        AL = BL;
        // 5642:046F out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0470 mov AL,BH
        AL = BH;
        // 5642:0472 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0473 mov AL,CL
        AL = CL;
        // 5642:0475 inc DX
        DX = Alu16.Inc(DX);
        // 5642:0476 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0477 mov AL,CH
        AL = CH;
        // 5642:0479 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:047A mov DL,byte ptr CS:[0x0289]
        DL = UInt8[CS, (ushort)0x0289];
        // 5642:047F mov AL,AH
        AL = AH;
        // 5642:0481 out DX,AL
        Machine.IoPortDispatcher.WriteByte(DX, AL);
        // 5642:0482 mov AL,byte ptr CS:[0x0288]
        AL = UInt8[CS, (ushort)0x0288];
        // 5642:0486 out 0x0A,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x0A), AL);
        // 5642:0488 pop BX
        BX = Stack.Pop16();
        // 5642:0489 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_048A_568AA(int loadOffset)
    {
    label_5642_048A_568AA_1557:
        CheckExternalEvents(cs3, 0x048A);
        // 5642:048A push CX
        Stack.Push16(CX);
        // 5642:048B mov CL,4
        CL = (byte)0x04;
        // 5642:048D rol DX,CL
        DX = Alu16.Rol(DX, CL);
        // 5642:048F mov CX,DX
        CX = DX;
        // 5642:0491 and DX,0x000F
        DX = Alu16.And(DX, unchecked((ushort)unchecked((short)(sbyte)15)));
        // 5642:0494 and CX,-16
        CX = Alu16.And(CX, unchecked((ushort)unchecked((short)(sbyte)-16)));
        // 5642:0497 add AX,CX
        AX = Alu16.Add(AX, CX);
        // 5642:0499 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:049C pop CX
        CX = Stack.Pop16();
        // 5642:049D ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_049E_568BE(int loadOffset)
    {
    label_5642_049E_568BE_1976:
        CheckExternalEvents(cs3, 0x049E);
        // 5642:049E mov DX,word ptr DS:[0x0295]
        DX = UInt16[DS, (ushort)0x0295];
        // 5642:04A2 add AX,word ptr DS:[0x0293]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x0293]);
        // 5642:04A6 jae short 0x04AB
        if (!(!CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:04A6");
        }
    label_5642_04AB_568CB_1980:
        CheckExternalEvents(cs3, 0x04AB);
        // 5642:04AB ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_04AC_568CC(int loadOffset)
    {
    label_5642_04AC_568CC_1988:
        CheckExternalEvents(cs3, 0x04AC);
        // 5642:04AC push ES
        Stack.Push16(ES);
        // 5642:04AD push DI
        Stack.Push16(DI);
        // 5642:04AE les DI,word ptr DS:[0x0293]
        ushort lxsOffset_5642_04AE_568CE = (ushort)0x0293;
        ushort lxsValue_5642_04AE_568CE = UInt16[DS, lxsOffset_5642_04AE_568CE];
        ushort lxsSegment_5642_04AE_568CE = UInt16[DS, (ushort)(lxsOffset_5642_04AE_568CE + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_5642_04AE_568CE);
        ES = unchecked((ushort)lxsSegment_5642_04AE_568CE);
        // 5642:04B2 mov AX,word ptr ES:[DI+1]
        AX = UInt16[ES, (ushort)(DI + (sbyte)1)];
        // 5642:04B6 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 5642:04B8 mov DL,byte ptr ES:[DI+3]
        DL = UInt8[ES, (ushort)(DI + (sbyte)3)];
        // 5642:04BC pop DI
        DI = Stack.Pop16();
        // 5642:04BD pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:04BE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_04BF_568DF(int loadOffset)
    {
    label_5642_04BF_568DF_1513:
        CheckExternalEvents(cs3, 0x04BF);
        // 5642:04BF mov AL,byte ptr DS:[0x0287]
        AL = UInt8[DS, (ushort)0x0287];
        // 5642:04C2 add AL,8
        AL = Alu8.Add(AL, (byte)0x08);
        // 5642:04C4 cmp AL,0x10
        Alu8.Sub(AL, (byte)0x10);
        // 5642:04C6 jb short 0x04CA
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:04C6");
        }
    label_5642_04CA_568EA_1518:
        CheckExternalEvents(cs3, 0x04CA);
        // 5642:04CA xor AH,AH
        AH = Alu8.Xor(AH, AH);
        // 5642:04CC shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5642:04CE shl AX,1
        AX = Alu16.Shl(AX, 1);
        // 5642:04D0 mov BX,AX
        BX = AX;
        // 5642:04D2 xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:04D4 mov ES,AX
        ES = AX;
    label_5642_04D6_568F6_1525:
        CheckExternalEvents(cs3, 0x04D6);
        // 5642:04D6 cli
        InterruptFlag = false;
        // 5642:04D7 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_04D8_568F8(int loadOffset)
    {
    label_5642_04D8_568F8_1505:
        CheckExternalEvents(cs3, 0x04D8);
        // 5642:04D8 pushf
        Stack.Push16(FlagRegister16);
        // 5642:04D9 push BX
        Stack.Push16(BX);
        // 5642:04DA push CX
        Stack.Push16(CX);
        // 5642:04DB push DX
        Stack.Push16(DX);
        // 5642:04DC mov DX,AX
        DX = AX;
        // 5642:04DE push ES
        Stack.Push16(ES);
        // 5642:04DF call near 0x04BF
        NearCall(cs3, 0x04E2, unknown_5642_04BF_568DF);
    label_5642_04E2_56902_1528:
        CheckExternalEvents(cs3, 0x04E2);
        // 5642:04E2 mov AX,CS
        AX = CS;
        // 5642:04E4 xchg DX,word ptr ES:[BX]
        ushort xchgOffset_5642_04E4_56904 = BX;
        ushort temp_5642_04E4_56904 = DX;
        DX = UInt16[ES, xchgOffset_5642_04E4_56904];
        UInt16[ES, xchgOffset_5642_04E4_56904] = unchecked((ushort)temp_5642_04E4_56904);
        // 5642:04E7 mov word ptr DS:[0x0297],DX
        UInt16[DS, (ushort)0x0297] = DX;
        // 5642:04EB xchg AX,word ptr ES:[BX+2]
        ushort xchgOffset_5642_04EB_5690B = unchecked((ushort)(BX + (sbyte)2));
        ushort temp_5642_04EB_5690B = AX;
        AX = UInt16[ES, xchgOffset_5642_04EB_5690B];
        UInt16[ES, xchgOffset_5642_04EB_5690B] = unchecked((ushort)temp_5642_04EB_5690B);
        // 5642:04EF mov word ptr DS:[0x0299],AX
        UInt16[DS, (ushort)0x0299] = AX;
        // 5642:04F2 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:04F3 mov CL,byte ptr DS:[0x0287]
        CL = UInt8[DS, (ushort)0x0287];
        // 5642:04F7 cmp CL,8
        Alu8.Sub(CL, (byte)0x08);
        // 5642:04FA jb short 0x0510
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:04FA");
        }
    label_5642_0510_56930_1538:
        CheckExternalEvents(cs3, 0x0510);
        // 5642:0510 mov AH,1
        AH = (byte)0x01;
        // 5642:0512 shl AH,CL
        AH = Alu8.Shl(AH, unchecked((int)CL));
        // 5642:0514 not AH
        AH = unchecked((byte)~AH);
        // 5642:0516 in AL,0x21
        AL = Machine.IoPortDispatcher.ReadByte(unchecked((ushort)(byte)0x21));
        // 5642:0518 mov byte ptr DS:[0x029B],AL
        UInt8[DS, (ushort)0x029B] = AL;
        // 5642:051B and AL,AH
        AL = Alu8.And(AL, AH);
        // 5642:051D out 0x21,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x21), AL);
        // 5642:051F pop DX
        DX = Stack.Pop16();
        // 5642:0520 pop CX
        CX = Stack.Pop16();
        // 5642:0521 pop BX
        BX = Stack.Pop16();
    label_5642_0522_56942_1549:
        CheckExternalEvents(cs3, 0x0522);
        // 5642:0522 popf
        FlagRegister16 = Stack.Pop16();
    label_5642_0523_56943_1551:
        CheckExternalEvents(cs3, 0x0523);
        // 5642:0523 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0524_56944(int loadOffset)
    {
    label_5642_0524_56944_1647:
        CheckExternalEvents(cs3, 0x0524);
        // 5642:0524 pushf
        Stack.Push16(FlagRegister16);
        // 5642:0525 push BX
        Stack.Push16(BX);
        // 5642:0526 push ES
        Stack.Push16(ES);
        // 5642:0527 call near 0x04BF
        NearCall(cs3, 0x052A, unknown_5642_04BF_568DF);
    label_5642_052A_5694A_1652:
        CheckExternalEvents(cs3, 0x052A);
        // 5642:052A mov AX,word ptr DS:[0x0297]
        AX = UInt16[DS, (ushort)0x0297];
        // 5642:052D mov word ptr ES:[BX],AX
        UInt16[ES, BX] = AX;
        // 5642:0530 mov AX,word ptr DS:[0x0299]
        AX = UInt16[DS, (ushort)0x0299];
        // 5642:0533 mov word ptr ES:[BX+2],AX
        UInt16[ES, (ushort)(BX + (sbyte)2)] = AX;
        // 5642:0537 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0538 cmp byte ptr DS:[0x0287],8
        Alu8.Sub(UInt8[DS, (ushort)0x0287], (byte)0x08);
        // 5642:053D jb short 0x0544
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:053D");
        }
    label_5642_0544_56964_1660:
        CheckExternalEvents(cs3, 0x0544);
        // 5642:0544 mov AL,byte ptr DS:[0x029B]
        AL = UInt8[DS, (ushort)0x029B];
        // 5642:0547 out 0x21,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x21), AL);
        // 5642:0549 pop BX
        BX = Stack.Pop16();
    label_5642_054A_5696A_1664:
        CheckExternalEvents(cs3, 0x054A);
        // 5642:054A popf
        FlagRegister16 = Stack.Pop16();
    label_5642_054B_5696B_1666:
        CheckExternalEvents(cs3, 0x054B);
        // 5642:054B ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_054C_5696C(int loadOffset)
    {
    label_5642_054C_5696C_1939:
        CheckExternalEvents(cs3, 0x054C);
        // 5642:054C push DS
        Stack.Push16(DS);
        // 5642:054D push SI
        Stack.Push16(SI);
        // 5642:054E lds SI,word ptr DS:[0x0293]
        ushort lxsOffset_5642_054E_5696E = (ushort)0x0293;
        ushort lxsValue_5642_054E_5696E = UInt16[DS, lxsOffset_5642_054E_5696E];
        ushort lxsSegment_5642_054E_5696E = UInt16[DS, (ushort)(lxsOffset_5642_054E_5696E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_054E_5696E);
        DS = unchecked((ushort)lxsSegment_5642_054E_5696E);
        // 5642:0552 lods AL,byte ptr DS:[SI]
        AL = UInt8[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction8)));
        // 5642:0553 pop SI
        SI = Stack.Pop16();
        // 5642:0554 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0555 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0556_56976(int loadOffset)
    {
    label_5642_0556_56976_1973:
        CheckExternalEvents(cs3, 0x0556);
        // 5642:0556 mov CX,AX
        CX = AX;
        // 5642:0558 call near 0x049E
        NearCall(cs3, 0x055B, unknown_5642_049E_568BE);
    label_5642_055B_5697B_1982:
        CheckExternalEvents(cs3, 0x055B);
        // 5642:055B call near 0x048A
        NearCall(cs3, 0x055E, unknown_5642_048A_568AA);
    label_5642_055E_5697E_1984:
        CheckExternalEvents(cs3, 0x055E);
        // 5642:055E mov byte ptr DS:[0x029D],DL
        UInt8[DS, (ushort)0x029D] = DL;
        // 5642:0562 mov word ptr DS:[0x029E],AX
        UInt16[DS, (ushort)0x029E] = AX;
        // 5642:0565 call near 0x04AC
        NearCall(cs3, 0x0568, unknown_5642_04AC_568CC);
    label_5642_0568_56988_1998:
        CheckExternalEvents(cs3, 0x0568);
        // 5642:0568 sub CX,4
        CX = Alu16.Sub(CX, unchecked((ushort)unchecked((short)(sbyte)4)));
        // 5642:056B sub AX,CX
        AX = Alu16.Sub(AX, CX);
        // 5642:056D sbb DX,0
        DX = Alu16.Sbb(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:0570 mov word ptr DS:[0x02A0],AX
        UInt16[DS, (ushort)0x02A0] = AX;
        // 5642:0573 mov word ptr DS:[0x02A2],DX
        UInt16[DS, (ushort)0x02A2] = DX;
        // 5642:0577 sub AX,1
        AX = Alu16.Sub(AX, (ushort)0x0001);
        // 5642:057A sbb DX,0
        DX = Alu16.Sbb(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:057D add AX,word ptr DS:[0x029E]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x029E]);
        // 5642:0581 adc DL,byte ptr DS:[0x029D]
        DL = Alu8.Adc(DL, UInt8[DS, (ushort)0x029D]);
        // 5642:0585 mov word ptr DS:[0x02A4],AX
        UInt16[DS, (ushort)0x02A4] = AX;
        // 5642:0588 sub DL,byte ptr DS:[0x029D]
        DL = Alu8.Sub(DL, UInt8[DS, (ushort)0x029D]);
        // 5642:058C mov byte ptr DS:[0x02A6],DL
        UInt8[DS, (ushort)0x02A6] = DL;
        // 5642:0590 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0591_569B1(int loadOffset)
    {
    label_5642_0591_569B1_2082:
        CheckExternalEvents(cs3, 0x0591);
        // 5642:0591 push DS
        Stack.Push16(DS);
        // 5642:0592 push ES
        Stack.Push16(ES);
        // 5642:0593 push AX
        Stack.Push16(AX);
        // 5642:0594 push BX
        Stack.Push16(BX);
        // 5642:0595 push CX
        Stack.Push16(CX);
        // 5642:0596 push DX
        Stack.Push16(DX);
        // 5642:0597 push SI
        Stack.Push16(SI);
        // 5642:0598 push DI
        Stack.Push16(DI);
        // 5642:0599 push BP
        Stack.Push16(BP);
        // 5642:059A cld
        DirectionFlag = false;
        // 5642:059B mov AX,CS
        AX = CS;
        // 5642:059D mov DS,AX
        DS = AX;
        // 5642:059F mov ES,AX
        ES = AX;
        // 5642:05A1 mov AL,0x20
        AL = (byte)0x20;
        // 5642:05A3 cmp byte ptr CS:[0x0287],8
        Alu8.Sub(UInt8[CS, (ushort)0x0287], (byte)0x08);
        // 5642:05A9 jb short 0x05AF
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:05A9");
        }
    label_5642_05AF_569CF_2099:
        CheckExternalEvents(cs3, 0x05AF);
        // 5642:05AF out 0x20,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x20), AL);
        // 5642:05B1 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:05B5 add DL,0x0E
        DL = Alu8.Add(DL, (byte)0x0E);
        // 5642:05B8 in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:05B9 sti
        if (!InterruptFlag)
        {
            State.InterruptShadowing = true;
        }
        else
        {
        }
        InterruptFlag = true;
    label_5642_05BA_569DA_2105:
        CheckExternalEvents(cs3, 0x05BA);
        // 5642:05BA mov AX,word ptr DS:[0x02A0]
        AX = UInt16[DS, (ushort)0x02A0];
        // 5642:05BD or AX,word ptr DS:[0x02A2]
        AX = Alu16.Or(AX, UInt16[DS, (ushort)0x02A2]);
        // 5642:05C1 jne short 0x05D5
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:05C1");
        }
    label_5642_05C3_569E3_2109:
        CheckExternalEvents(cs3, 0x05C3);
        // 5642:05C3 call near 0x0677
        NearCall(cs3, 0x05C6, unknown_5642_0677_56A97);
    label_5642_05C6_569E6_2143:
        CheckExternalEvents(cs3, 0x05C6);
        // 5642:05C6 call near 0x065F
        NearCall(cs3, 0x05C9, unknown_5642_065F_56A7F);
    label_5642_05C9_569E9_2158:
        CheckExternalEvents(cs3, 0x05C9);
        // 5642:05C9 cmp byte ptr DS:[0x02A7],0
        Alu8.Sub(UInt8[DS, (ushort)0x02A7], (byte)0x00);
        // 5642:05CE je short 0x05D8
        if (ZeroFlag)
        {
            goto label_5642_05D8_569F8_2179;
        }
    label_5642_05D0_569F0_2161:
        CheckExternalEvents(cs3, 0x05D0);
        // 5642:05D0 call near 0x0640
        NearCall(cs3, 0x05D3, unknown_5642_0640_56A60);
    label_5642_05D3_569F3_2177:
        CheckExternalEvents(cs3, 0x05D3);
        // 5642:05D3 jmp short 0x05D8
    label_5642_05D8_569F8_2179:
        CheckExternalEvents(cs3, 0x05D8);
        // 5642:05D8 pop BP
        BP = Stack.Pop16();
        // 5642:05D9 pop DI
        DI = Stack.Pop16();
        // 5642:05DA pop SI
        SI = Stack.Pop16();
        // 5642:05DB pop DX
        DX = Stack.Pop16();
        // 5642:05DC pop CX
        CX = Stack.Pop16();
        // 5642:05DD pop BX
        BX = Stack.Pop16();
        // 5642:05DE pop AX
        AX = Stack.Pop16();
        // 5642:05DF pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:05E0 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:05E1 iret
        return InterruptRet();
    }

    public virtual Action unknown_5642_05E2_56A02(int loadOffset)
    {
    label_5642_05E2_56A02_2014:
        CheckExternalEvents(cs3, 0x05E2);
        // 5642:05E2 mov CX,0xFFFF
        CX = (ushort)0xFFFF;
        // 5642:05E5 cmp byte ptr DS:[0x02A6],0
        Alu8.Sub(UInt8[DS, (ushort)0x02A6], (byte)0x00);
        // 5642:05EA jne short 0x05F4
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:05EA");
        }
    label_5642_05EC_56A0C_2018:
        CheckExternalEvents(cs3, 0x05EC);
        // 5642:05EC inc byte ptr DS:[0x02A6]
        UInt8[DS, (ushort)0x02A6] = Alu8.Inc(UInt8[DS, (ushort)0x02A6]);
        // 5642:05F0 mov CX,word ptr DS:[0x02A4]
        CX = UInt16[DS, (ushort)0x02A4];
        // 5642:05F4 sub CX,word ptr DS:[0x029E]
        CX = Alu16.Sub(CX, UInt16[DS, (ushort)0x029E]);
        // 5642:05F8 mov word ptr DS:[0x02A8],CX
        UInt16[DS, (ushort)0x02A8] = CX;
        // 5642:05FC inc CX
        CX = Alu16.Inc(CX);
        // 5642:05FD je short 0x060A
        if (ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:05FD");
        }
    label_5642_05FF_56A1F_2025:
        CheckExternalEvents(cs3, 0x05FF);
        // 5642:05FF sub word ptr DS:[0x02A0],CX
        UInt16[DS, (ushort)0x02A0] = Alu16.Sub(UInt16[DS, (ushort)0x02A0], CX);
        // 5642:0603 sbb word ptr DS:[0x02A2],0
        UInt16[DS, (ushort)0x02A2] = Alu16.Sbb(UInt16[DS, (ushort)0x02A2], unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:0608 jmp short 0x060E
    label_5642_060E_56A2E_2029:
        CheckExternalEvents(cs3, 0x060E);
        // 5642:060E mov DH,0x48
        DH = (byte)0x48;
        // 5642:0610 mov DL,byte ptr DS:[0x029D]
        DL = UInt8[DS, (ushort)0x029D];
        // 5642:0614 mov AX,word ptr DS:[0x029E]
        AX = UInt16[DS, (ushort)0x029E];
        // 5642:0617 mov CX,word ptr DS:[0x02A8]
        CX = UInt16[DS, (ushort)0x02A8];
        // 5642:061B call near 0x0450
        NearCall(cs3, 0x061E, unknown_5642_0450_56870);
    label_5642_061E_56A3E_2035:
        CheckExternalEvents(cs3, 0x061E);
        // 5642:061E dec byte ptr DS:[0x02A6]
        UInt8[DS, (ushort)0x02A6] = Alu8.Dec(UInt8[DS, (ushort)0x02A6]);
        // 5642:0622 inc byte ptr DS:[0x029D]
        UInt8[DS, (ushort)0x029D] = Alu8.Inc(UInt8[DS, (ushort)0x029D]);
        // 5642:0626 mov word ptr DS:[0x029E],0
        UInt16[DS, (ushort)0x029E] = (ushort)0x0000;
        // 5642:062C mov CX,word ptr DS:[0x02A8]
        CX = UInt16[DS, (ushort)0x02A8];
        // 5642:0630 mov AL,byte ptr DS:[0x02AA]
        AL = UInt8[DS, (ushort)0x02AA];
        // 5642:0633 call near 0x0333
        NearCall(cs3, 0x0636, unknown_5642_0333_56753);
    label_5642_0636_56A56_2042:
        CheckExternalEvents(cs3, 0x0636);
        // 5642:0636 mov AL,CL
        AL = CL;
        // 5642:0638 call near 0x033A
        NearCall(cs3, 0x063B, unknown_5642_033A_5675A);
    label_5642_063B_56A5B_2045:
        CheckExternalEvents(cs3, 0x063B);
        // 5642:063B mov AL,CH
        AL = CH;
        // 5642:063D jmp near 0x033A
        return unknown_5642_033A_5675A(0x0000);
    }

    public virtual Action unknown_5642_0640_56A60(int loadOffset)
    {
    label_5642_0640_56A60_2163:
        CheckExternalEvents(cs3, 0x0640);
        // 5642:0640 mov AL,byte ptr CS:[0x0288]
        AL = UInt8[CS, (ushort)0x0288];
        // 5642:0644 or AL,4
        AL = Alu8.Or(AL, (byte)0x04);
        // 5642:0646 out 0x0A,AL
        Machine.IoPortDispatcher.WriteByte(unchecked((ushort)(byte)0x0A), AL);
        // 5642:0648 call near 0x0524
        NearCall(cs3, 0x064B, unknown_5642_0524_56944);
    label_5642_064B_56A6B_2168:
        CheckExternalEvents(cs3, 0x064B);
        // 5642:064B xor AX,AX
        AX = Alu16.Xor(AX, AX);
        // 5642:064D mov byte ptr DS:[0x0292],AL
        UInt8[DS, (ushort)0x0292] = AL;
        // 5642:0650 mov word ptr DS:[0x02AB],AX
        UInt16[DS, (ushort)0x02AB] = AX;
        // 5642:0653 mov word ptr DS:[0x0283],AX
        UInt16[DS, (ushort)0x0283] = AX;
        // 5642:0656 mov DX,word ptr DS:[0x0285]
        DX = UInt16[DS, (ushort)0x0285];
        // 5642:065A add DL,0x0E
        DL = Alu8.Add(DL, (byte)0x0E);
        // 5642:065D in AL,DX
        AL = Machine.IoPortDispatcher.ReadByte(DX);
        // 5642:065E ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_065F_56A7F(int loadOffset)
    {
    label_5642_065F_56A7F_1937:
        CheckExternalEvents(cs3, 0x065F);
        // 5642:065F call near 0x054C
        NearCall(cs3, 0x0662, unknown_5642_054C_5696C);
    label_5642_0662_56A82_1947:
        CheckExternalEvents(cs3, 0x0662);
        // 5642:0662 cmp AL,8
        Alu8.Sub(AL, (byte)0x08);
        // 5642:0664 jae short 0x0672
        if (!CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:0664");
        }
    label_5642_0666_56A86_1950:
        CheckExternalEvents(cs3, 0x0666);
        // 5642:0666 cbw
        AX = unchecked((ushort)unchecked((short)unchecked((sbyte)AL)));
        // 5642:0667 mov BX,AX
        BX = AX;
        // 5642:0669 shl BX,1
        BX = Alu16.Shl(BX, 1);
        // 5642:066B call near word ptr DS:[BX+0x02D0]
        switch ((ushort)(UInt16[DS, (ushort)(BX + (short)720)]))
        {
            case 0x06CD:
                NearCall(cs3, 0x066F, unknown_5642_06CD_56AED);
                break;
            case 0x0740:
                NearCall(cs3, 0x066F, unknown_5642_0740_56B60);
                break;
            case 0x0788:
                NearCall(cs3, 0x066F, unknown_5642_0788_56BA8);
                break;
            case 0x0796:
                NearCall(cs3, 0x066F, unknown_5642_0796_56BB6);
                break;
            case 0x07D0:
                NearCall(cs3, 0x066F, unknown_5642_07D0_56BF0);
                break;
            case 0x07F9:
                NearCall(cs3, 0x066F, unknown_5642_07F9_56C19);
                break;
            default:
                throw FailAsUntested($"Unknown near call target 0x{((ushort)(UInt16[DS, (ushort)(BX + (short)720)])):X4} at 5642:066B");
        }
    label_5642_066F_56A8F_2060:
        CheckExternalEvents(cs3, 0x066F);
        // 5642:066F jb short 0x065F
        if (CarryFlag)
        {
            goto label_5642_065F_56A7F_1937;
        }
    label_5642_0671_56A91_2062:
        CheckExternalEvents(cs3, 0x0671);
        // 5642:0671 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0677_56A97(int loadOffset)
    {
    label_5642_0677_56A97_2111:
        CheckExternalEvents(cs3, 0x0677);
        // 5642:0677 push ES
        Stack.Push16(ES);
        // 5642:0678 push AX
        Stack.Push16(AX);
        // 5642:0679 push BX
        Stack.Push16(BX);
        // 5642:067A push DX
        Stack.Push16(DX);
        // 5642:067B les BX,word ptr DS:[0x0293]
        ushort lxsOffset_5642_067B_56A9B = (ushort)0x0293;
        ushort lxsValue_5642_067B_56A9B = UInt16[DS, lxsOffset_5642_067B_56A9B];
        ushort lxsSegment_5642_067B_56A9B = UInt16[DS, (ushort)(lxsOffset_5642_067B_56A9B + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_5642_067B_56A9B);
        ES = unchecked((ushort)lxsSegment_5642_067B_56A9B);
        // 5642:067F mov AX,word ptr ES:[BX+1]
        AX = UInt16[ES, (ushort)(BX + (sbyte)1)];
        // 5642:0683 xor DX,DX
        DX = Alu16.Xor(DX, DX);
        // 5642:0685 mov DL,byte ptr ES:[BX+3]
        DL = UInt8[ES, (ushort)(BX + (sbyte)3)];
        // 5642:0689 add AX,4
        AX = Alu16.Add(AX, (ushort)0x0004);
        // 5642:068C adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:068F add AX,word ptr DS:[0x0293]
        AX = Alu16.Add(AX, UInt16[DS, (ushort)0x0293]);
        // 5642:0693 adc DX,0
        DX = Alu16.Adc(DX, unchecked((ushort)unchecked((short)(sbyte)0)));
        // 5642:0696 ror DX,1
        DX = Alu16.Ror(DX, 1);
        // 5642:0698 ror DX,1
        DX = Alu16.Ror(DX, 1);
        // 5642:069A ror DX,1
        DX = Alu16.Ror(DX, 1);
        // 5642:069C ror DX,1
        DX = Alu16.Ror(DX, 1);
        // 5642:069E add DX,word ptr DS:[0x0295]
        DX = Alu16.Add(DX, UInt16[DS, (ushort)0x0295]);
        // 5642:06A2 mov BX,AX
        BX = AX;
        // 5642:06A4 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5642:06A6 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5642:06A8 shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5642:06AA shr BX,1
        BX = Alu16.Shr(BX, 1);
        // 5642:06AC add DX,BX
        DX = Alu16.Add(DX, BX);
        // 5642:06AE and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 5642:06B1 mov word ptr DS:[0x0295],DX
        UInt16[DS, (ushort)0x0295] = DX;
        // 5642:06B5 mov word ptr DS:[0x0293],AX
        UInt16[DS, (ushort)0x0293] = AX;
        // 5642:06B8 pop DX
        DX = Stack.Pop16();
        // 5642:06B9 pop BX
        BX = Stack.Pop16();
        // 5642:06BA pop AX
        AX = Stack.Pop16();
        // 5642:06BB pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:06BC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_06BD_56ADD(int loadOffset)
    {
    label_5642_06BD_56ADD_1915:
        CheckExternalEvents(cs3, 0x06BD);
        // 5642:06BD push AX
        Stack.Push16(AX);
        // 5642:06BE shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:06C0 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:06C2 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:06C4 shr AX,1
        AX = Alu16.Shr(AX, 1);
        // 5642:06C6 add DX,AX
        DX = Alu16.Add(DX, AX);
        // 5642:06C8 pop AX
        AX = Stack.Pop16();
        // 5642:06C9 and AX,0x000F
        AX = Alu16.And(AX, (ushort)0x000F);
        // 5642:06CC ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_06CD_56AED(int loadOffset)
    {
    label_5642_06CD_56AED_2145:
        CheckExternalEvents(cs3, 0x06CD);
        // 5642:06CD push ES
        Stack.Push16(ES);
        // 5642:06CE les SI,word ptr DS:[0x0118]
        ushort lxsOffset_5642_06CE_56AEE = (ushort)0x0118;
        ushort lxsValue_5642_06CE_56AEE = UInt16[DS, lxsOffset_5642_06CE_56AEE];
        ushort lxsSegment_5642_06CE_56AEE = UInt16[DS, (ushort)(lxsOffset_5642_06CE_56AEE + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_06CE_56AEE);
        ES = unchecked((ushort)lxsSegment_5642_06CE_56AEE);
        // 5642:06D2 mov byte ptr ES:[SI+6],0
        UInt8[ES, (ushort)(SI + (sbyte)6)] = (byte)0x00;
        // 5642:06D7 mov AL,byte ptr ES:[SI+7]
        AL = UInt8[ES, (ushort)(SI + (sbyte)7)];
        // 5642:06DB shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5642:06DD jb short 0x0733
        if (CarryFlag)
        {
            goto label_5642_0733_56B53_2152;
        }
    label_5642_06DF_56AFF_5622:
        CheckExternalEvents(cs3, 0x06DF);
        // 5642:06DF les SI,word ptr DS:[0x011C]
        ushort lxsOffset_5642_06DF_56AFF = (ushort)0x011C;
        ushort lxsValue_5642_06DF_56AFF = UInt16[DS, lxsOffset_5642_06DF_56AFF];
        ushort lxsSegment_5642_06DF_56AFF = UInt16[DS, (ushort)(lxsOffset_5642_06DF_56AFF + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_06DF_56AFF);
        ES = unchecked((ushort)lxsSegment_5642_06DF_56AFF);
        // 5642:06E3 cmp byte ptr ES:[SI+6],2
        Alu8.Sub(UInt8[ES, (ushort)(SI + (sbyte)6)], (byte)0x02);
        // 5642:06E8 je short 0x070F
        if (ZeroFlag)
        {
            goto label_5642_070F_56B2F_5626;
        }
    label_5642_06EA_56B0A_5650:
        CheckExternalEvents(cs3, 0x06EA);
        // 5642:06EA shl AL,1
        AL = Alu8.Shl(AL, 1);
        // 5642:06EC jae short 0x0738
        if (!CarryFlag)
        {
            goto label_5642_0738_56B58_2154;
        }
    label_5642_06EE_56B0E_5653:
        CheckExternalEvents(cs3, 0x06EE);
        // 5642:06EE les SI,word ptr DS:[0x0118]
        ushort lxsOffset_5642_06EE_56B0E = (ushort)0x0118;
        ushort lxsValue_5642_06EE_56B0E = UInt16[DS, lxsOffset_5642_06EE_56B0E];
        ushort lxsSegment_5642_06EE_56B0E = UInt16[DS, (ushort)(lxsOffset_5642_06EE_56B0E + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_06EE_56B0E);
        ES = unchecked((ushort)lxsSegment_5642_06EE_56B0E);
        // 5642:06F2 mov byte ptr ES:[SI+6],3
        UInt8[ES, (ushort)(SI + (sbyte)6)] = (byte)0x03;
        // 5642:06F7 les SI,word ptr ES:[SI]
        ushort lxsOffset_5642_06F7_56B17 = SI;
        ushort lxsValue_5642_06F7_56B17 = UInt16[ES, lxsOffset_5642_06F7_56B17];
        ushort lxsSegment_5642_06F7_56B17 = UInt16[ES, (ushort)(lxsOffset_5642_06F7_56B17 + (ushort)0x0002)];
        SI = unchecked((ushort)lxsValue_5642_06F7_56B17);
        ES = unchecked((ushort)lxsSegment_5642_06F7_56B17);
        // 5642:06FA cmp byte ptr ES:[SI+2],2
        Alu8.Sub(UInt8[ES, (ushort)(SI + (sbyte)2)], (byte)0x02);
        // 5642:06FF jne short 0x0704
        if (!ZeroFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:06FF");
        }
    label_5642_0701_56B21_5659:
        CheckExternalEvents(cs3, 0x0701);
        // 5642:0701 add SI,2
        SI = Alu16.Add(SI, unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5642:0704 mov word ptr DS:[0x0293],SI
        UInt16[DS, (ushort)0x0293] = SI;
        // 5642:0708 mov word ptr DS:[0x0295],ES
        UInt16[DS, (ushort)0x0295] = ES;
        // 5642:070C pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:070D stc
        CarryFlag = true;
        // 5642:070E ret near
        return NearRet((ushort)0x0000);
    label_5642_070F_56B2F_5626:
        CheckExternalEvents(cs3, 0x070F);
        // 5642:070F mov word ptr DS:[0x0118],SI
        UInt16[DS, (ushort)0x0118] = SI;
        // 5642:0713 mov word ptr DS:[0x011A],ES
        UInt16[DS, (ushort)0x011A] = ES;
        // 5642:0717 mov byte ptr ES:[SI+6],3
        UInt8[ES, (ushort)(SI + (sbyte)6)] = (byte)0x03;
        // 5642:071C cmp word ptr ES:[SI+4],3
        Alu16.Sub(UInt16[ES, (ushort)(SI + (sbyte)4)], unchecked((ushort)unchecked((short)(sbyte)3)));
        // 5642:0721 jb short 0x06CE
        if (CarryFlag)
        {
            throw FailAsUntested("Unobserved conditional jump target at 5642:0721");
        }
    label_5642_0723_56B43_5632:
        CheckExternalEvents(cs3, 0x0723);
        // 5642:0723 les AX,word ptr ES:[SI]
        ushort lxsOffset_5642_0723_56B43 = SI;
        ushort lxsValue_5642_0723_56B43 = UInt16[ES, lxsOffset_5642_0723_56B43];
        ushort lxsSegment_5642_0723_56B43 = UInt16[ES, (ushort)(lxsOffset_5642_0723_56B43 + (ushort)0x0002)];
        AX = unchecked((ushort)lxsValue_5642_0723_56B43);
        ES = unchecked((ushort)lxsSegment_5642_0723_56B43);
        // 5642:0726 add AX,2
        AX = Alu16.Add(AX, (ushort)0x0002);
        // 5642:0729 mov word ptr DS:[0x0293],AX
        UInt16[DS, (ushort)0x0293] = AX;
        // 5642:072C mov word ptr DS:[0x0295],ES
        UInt16[DS, (ushort)0x0295] = ES;
        // 5642:0730 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0731 stc
        CarryFlag = true;
        // 5642:0732 ret near
        return NearRet((ushort)0x0000);
    label_5642_0733_56B53_2152:
        CheckExternalEvents(cs3, 0x0733);
        // 5642:0733 mov byte ptr DS:[0x02FE],1
        UInt8[DS, (ushort)0x02FE] = (byte)0x01;
    label_5642_0738_56B58_2154:
        CheckExternalEvents(cs3, 0x0738);
        // 5642:0738 mov byte ptr DS:[0x02A7],1
        UInt8[DS, (ushort)0x02A7] = (byte)0x01;
        // 5642:073D pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:073E clc
        CarryFlag = false;
        // 5642:073F ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0740_56B60(int loadOffset)
    {
    label_5642_0740_56B60_1955:
        CheckExternalEvents(cs3, 0x0740);
        // 5642:0740 push ES
        Stack.Push16(ES);
        // 5642:0741 les DI,word ptr DS:[0x0293]
        ushort lxsOffset_5642_0741_56B61 = (ushort)0x0293;
        ushort lxsValue_5642_0741_56B61 = UInt16[DS, lxsOffset_5642_0741_56B61];
        ushort lxsSegment_5642_0741_56B61 = UInt16[DS, (ushort)(lxsOffset_5642_0741_56B61 + (ushort)0x0002)];
        DI = unchecked((ushort)lxsValue_5642_0741_56B61);
        ES = unchecked((ushort)lxsSegment_5642_0741_56B61);
        // 5642:0745 mov AL,0x40
        AL = (byte)0x40;
        // 5642:0747 call near 0x0333
        NearCall(cs3, 0x074A, unknown_5642_0333_56753);
    label_5642_074A_56B6A_1960:
        CheckExternalEvents(cs3, 0x074A);
        // 5642:074A mov AL,byte ptr ES:[DI+4]
        AL = UInt8[ES, (ushort)(DI + (sbyte)4)];
        // 5642:074E mov byte ptr DS:[0x02FC],AL
        UInt8[DS, (ushort)0x02FC] = AL;
        // 5642:0751 call near 0x033A
        NearCall(cs3, 0x0754, unknown_5642_033A_5675A);
    label_5642_0754_56B74_1964:
        CheckExternalEvents(cs3, 0x0754);
        // 5642:0754 mov AL,byte ptr ES:[DI+5]
        AL = UInt8[ES, (ushort)(DI + (sbyte)5)];
        // 5642:0758 mov byte ptr DS:[0x02FD],AL
        UInt8[DS, (ushort)0x02FD] = AL;
        // 5642:075B mov BX,0x02C5
        BX = (ushort)0x02C5;
        // 5642:075E xlat byte ptr DS:[BX+AL]
        AL = UInt8[DS, (ushort)(BX + unchecked((ushort)AL))];
        // 5642:075F mov byte ptr DS:[0x02AA],AL
        UInt8[DS, (ushort)0x02AA] = AL;
        // 5642:0762 pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:0763 mov AX,6
        AX = (ushort)0x0006;
        // 5642:0766 call near 0x0556
        NearCall(cs3, 0x0769, unknown_5642_0556_56976);
    label_5642_0769_56B89_2012:
        CheckExternalEvents(cs3, 0x0769);
        // 5642:0769 call near 0x05E2
        NearCall(cs3, 0x076C, unknown_5642_05E2_56A02);
    label_5642_076C_56B8C_2048:
        CheckExternalEvents(cs3, 0x076C);
        // 5642:076C call near 0x0771
        NearCall(cs3, 0x076F, unknown_5642_0771_56B91);
    label_5642_076F_56B8F_2057:
        CheckExternalEvents(cs3, 0x076F);
        // 5642:076F clc
        CarryFlag = false;
        // 5642:0770 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0771_56B91(int loadOffset)
    {
    label_5642_0771_56B91_2050:
        CheckExternalEvents(cs3, 0x0771);
        // 5642:0771 mov AL,byte ptr DS:[0x02AA]
        AL = UInt8[DS, (ushort)0x02AA];
        // 5642:0774 cmp AL,0x61
        Alu8.Sub(AL, (byte)0x61);
        // 5642:0776 jb short 0x0782
        if (!(CarryFlag))
        {
            throw FailAsUntested("Unobserved conditional fallthrough at 5642:0776");
        }
    label_5642_0782_56BA2_2054:
        CheckExternalEvents(cs3, 0x0782);
        // 5642:0782 and byte ptr DS:[0x02AA],0xFE
        UInt8[DS, (ushort)0x02AA] = Alu8.And(UInt8[DS, (ushort)0x02AA], (byte)0xFE);
        // 5642:0787 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0788_56BA8(int loadOffset)
    {
    label_5642_0788_56BA8_5640:
        CheckExternalEvents(cs3, 0x0788);
        // 5642:0788 mov AX,4
        AX = (ushort)0x0004;
        // 5642:078B call near 0x0556
        NearCall(cs3, 0x078E, unknown_5642_0556_56976);
    label_5642_078E_56BAE_5643:
        CheckExternalEvents(cs3, 0x078E);
        // 5642:078E call near 0x0771
        NearCall(cs3, 0x0791, unknown_5642_0771_56B91);
    label_5642_0791_56BB1_5645:
        CheckExternalEvents(cs3, 0x0791);
        // 5642:0791 call near 0x05E2
        NearCall(cs3, 0x0794, unknown_5642_05E2_56A02);
    label_5642_0794_56BB4_5647:
        CheckExternalEvents(cs3, 0x0794);
        // 5642:0794 clc
        CarryFlag = false;
        // 5642:0795 ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_0796_56BB6(int loadOffset)
    {
    label_5642_0796_56BB6_21683:
        CheckExternalEvents(cs3, 0x0796);
        // 5642:0796 mov AL,0x40
        AL = (byte)0x40;
        // 5642:0798 call near 0x0333
        NearCall(cs3, 0x079B, unknown_5642_0333_56753);
    label_5642_079B_56BBB_21686:
        CheckExternalEvents(cs3, 0x079B);
        // 5642:079B push ES
        Stack.Push16(ES);
        // 5642:079C les BX,word ptr DS:[0x0293]
        ushort lxsOffset_5642_079C_56BBC = (ushort)0x0293;
        ushort lxsValue_5642_079C_56BBC = UInt16[DS, lxsOffset_5642_079C_56BBC];
        ushort lxsSegment_5642_079C_56BBC = UInt16[DS, (ushort)(lxsOffset_5642_079C_56BBC + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_5642_079C_56BBC);
        ES = unchecked((ushort)lxsSegment_5642_079C_56BBC);
        // 5642:07A0 mov AL,byte ptr ES:[BX+6]
        AL = UInt8[ES, (ushort)(BX + (sbyte)6)];
        // 5642:07A4 call near 0x033A
        NearCall(cs3, 0x07A7, unknown_5642_033A_5675A);
    label_5642_07A7_56BC7_21691:
        CheckExternalEvents(cs3, 0x07A7);
        // 5642:07A7 mov AX,word ptr ES:[BX+4]
        AX = UInt16[ES, (ushort)(BX + (sbyte)4)];
        // 5642:07AB pop ES
        ES = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:07AC mov BX,AX
        BX = AX;
        // 5642:07AE mov AL,0x80
        AL = (byte)0x80;
        // 5642:07B0 call near 0x033A
        NearCall(cs3, 0x07B3, unknown_5642_033A_5675A);
    label_5642_07B3_56BD3_21697:
        CheckExternalEvents(cs3, 0x07B3);
        // 5642:07B3 mov AL,BL
        AL = BL;
        // 5642:07B5 call near 0x033A
        NearCall(cs3, 0x07B8, unknown_5642_033A_5675A);
    label_5642_07B8_56BD8_21700:
        CheckExternalEvents(cs3, 0x07B8);
        // 5642:07B8 mov AL,BH
        AL = BH;
        // 5642:07BA call near 0x033A
        NearCall(cs3, 0x07BD, unknown_5642_033A_5675A);
    label_5642_07BD_56BDD_21703:
        CheckExternalEvents(cs3, 0x07BD);
        // 5642:07BD clc
        CarryFlag = false;
        // 5642:07BE ret near
        return NearRet((ushort)0x0000);
    }

    public virtual Action unknown_5642_07D0_56BF0(int loadOffset)
    {
    label_5642_07D0_56BF0_10373:
        CheckExternalEvents(cs3, 0x07D0);
        // 5642:07D0 push DS
        Stack.Push16(DS);
        // 5642:07D1 lds BX,word ptr DS:[0x0293]
        ushort lxsOffset_5642_07D1_56BF1 = (ushort)0x0293;
        ushort lxsValue_5642_07D1_56BF1 = UInt16[DS, lxsOffset_5642_07D1_56BF1];
        ushort lxsSegment_5642_07D1_56BF1 = UInt16[DS, (ushort)(lxsOffset_5642_07D1_56BF1 + (ushort)0x0002)];
        BX = unchecked((ushort)lxsValue_5642_07D1_56BF1);
        DS = unchecked((ushort)lxsSegment_5642_07D1_56BF1);
        // 5642:07D5 mov AX,word ptr DS:[BX+4]
        AX = UInt16[DS, (ushort)(BX + (sbyte)4)];
        // 5642:07D8 pop DS
        DS = UInt16[SS, SP];
        SP = unchecked((ushort)(SP + (ushort)0x0002));
        // 5642:07D9 add word ptr DS:[0x02AB],2
        UInt16[DS, (ushort)0x02AB] = Alu16.Add(UInt16[DS, (ushort)0x02AB], unchecked((ushort)unchecked((short)(sbyte)2)));
        // 5642:07DE mov BX,word ptr DS:[0x02AB]
        BX = UInt16[DS, (ushort)0x02AB];
        // 5642:07E2 mov word ptr DS:[BX+0x02AB],AX
        UInt16[DS, (ushort)(BX + (short)683)] = AX;
        // 5642:07E6 push BX
        Stack.Push16(BX);
        // 5642:07E7 call near 0x0677
        NearCall(cs3, 0x07EA, unknown_5642_0677_56A97);
    label_5642_07EA_56C0A_10383:
        CheckExternalEvents(cs3, 0x07EA);
        // 5642:07EA mov SI,0x0293
        SI = (ushort)0x0293;
        // 5642:07ED mov DI,0x02B3
        DI = (ushort)0x02B3;
        // 5642:07F0 pop BX
        BX = Stack.Pop16();
        // 5642:07F1 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 5642:07F3 add DI,BX
        DI = Alu16.Add(DI, BX);
        // 5642:07F5 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5642:07F6 movs word ptr ES:[DI],word ptr DS:[SI]
        UInt16[ES, DI] = UInt16[DS, SI];
        SI = unchecked((ushort)(SI + unchecked((ushort)State.Direction16)));
        DI = unchecked((ushort)(DI + unchecked((ushort)State.Direction16)));
        // 5642:07F7 stc
        CarryFlag = true;
        // 5642:07F8 ret near
        return NearRet((ushort)0x0000);
    }
}
