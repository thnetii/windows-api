using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinSCard
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SCARDHANDLE : IPointer
    {
        public IntPtr Pointer { get; }
    }
}
