using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    /// <summary/>
    /// <param name="Arg">Argument passed in</param>
    /// <param name="Principal">Principal ID</param>
    /// <param name="KeyVer">Key Version</param>
    /// <param name="Key">Returned ptr to key</param>
    /// <param name="Status">returned status</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void SEC_GET_KEY_FN(
        IntPtr Arg,
        IntPtr Principal,
        int KeyVer,
        out IntPtr Key,
        out int Status
        );
}
