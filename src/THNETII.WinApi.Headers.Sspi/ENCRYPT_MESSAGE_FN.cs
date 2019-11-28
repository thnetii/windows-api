using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2049
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int ENCRYPT_MESSAGE_FN(
        in CtxtHandle phContext,
        [In] int fQOP,
        in SecBufferDesc pMessage,
        [In] uint MessageSeqNo
        );
}
