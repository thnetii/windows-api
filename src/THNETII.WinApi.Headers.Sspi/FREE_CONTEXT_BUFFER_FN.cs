using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int FREE_CONTEXT_BUFFER_FN(
        [In, Out] IntPtr pvContextBuffer      // buffer to free
        );
}
