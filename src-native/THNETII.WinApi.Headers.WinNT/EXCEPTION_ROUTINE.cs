using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.Excpt;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate EXCEPTION_DISPOSITION EXCEPTION_ROUTINE(
        ref EXCEPTION_RECORD ExceptionRecord,
        [In] IntPtr EstablisherFrame,
        ref CONTEXT ContextRecord,
        [In] IntPtr DispatcherContext
        );
}
