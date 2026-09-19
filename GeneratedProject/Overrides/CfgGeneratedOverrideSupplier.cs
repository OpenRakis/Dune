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

public sealed class CfgGeneratedOverrideSupplier : IOverrideSupplier
{
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(ILoggerService loggerService, Configuration configuration, ushort programStartAddress, Machine machine)
    {
        return new CfgGeneratedOverrides(new Dictionary<SegmentedAddress, FunctionInformation>(), machine, loggerService, configuration, programStartAddress).FunctionInformations;
    }
}
