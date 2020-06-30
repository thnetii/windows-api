using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void TERMINATION_HANDLER(
        [MarshalAs(UnmanagedType.U1)] bool AbnormalTermination,
        IntPtr EstablisherFrame
        );
}
