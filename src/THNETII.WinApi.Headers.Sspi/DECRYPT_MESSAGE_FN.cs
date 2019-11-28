using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2061
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int DECRYPT_MESSAGE_FN(
        in CtxtHandle phContext,
        in SecBufferDesc pMessage,
        [In] uint MessageSeqNo,
        [Optional] out int fQOP
        );
}
