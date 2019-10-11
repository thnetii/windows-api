using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.ProcessEnv
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCK : IConstTerminatedAutoStringPointer
    {
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCKA : IConstTerminatedAnsiStringPointer
    {
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCKW : IConstTerminatedUnicodeStringPointer
    {
        public IntPtr Pointer { get; }
    }
}
