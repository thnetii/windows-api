using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LPTSTR : ITerminatedAutoStringPointer
    {
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPCTSTR : IConstTerminatedAutoStringPointer
    {
        public IntPtr Pointer { get; }
    }
}
