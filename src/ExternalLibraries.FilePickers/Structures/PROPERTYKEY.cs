﻿using System.Runtime.InteropServices;

namespace ExternalLibraries.Pickers.Structures;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
internal struct PROPERTYKEY
{
    public Guid fmtid;
    public uint pid;
}
