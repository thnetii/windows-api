using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int EXCEPTION_FILTER(
        EXCEPTION_POINTERS* ExceptionPointers,
        IntPtr EstablisherFrame
        );
}
