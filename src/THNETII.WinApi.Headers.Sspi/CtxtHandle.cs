using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Sspi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CtxtHandle : IPointer
    {
        public IntPtr Pointer { get; }
    }
}
