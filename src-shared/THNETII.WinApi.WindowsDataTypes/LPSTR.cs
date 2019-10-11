using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LPSTR : ITerminatedAnsiStringPointer
    {
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPCSTR : IConstTerminatedAnsiStringPointer
    {
        public IntPtr Pointer { get; }
    }
}
