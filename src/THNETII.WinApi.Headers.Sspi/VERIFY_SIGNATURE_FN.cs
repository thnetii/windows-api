using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2032
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int VERIFY_SIGNATURE_FN(
        in CtxtHandle phContext,        // Context to use
        in SecBufferDesc pMessage,      // Message to verify
        [In] uint MessageSeqNo,         // Sequence Num.
        out int pfQOP                   // QOP used
        );
}
