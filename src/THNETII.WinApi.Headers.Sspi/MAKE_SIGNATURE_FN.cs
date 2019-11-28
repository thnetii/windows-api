using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2015
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int MAKE_SIGNATURE_FN(
        in CtxtHandle phContext,    // Context to use
        [In] int fQOP,              // Quality of Protection
        in SecBufferDesc pMessage,  // Message to sign
        [In] uint MessageSeqNo      // Message Sequence Num.
        );
}
