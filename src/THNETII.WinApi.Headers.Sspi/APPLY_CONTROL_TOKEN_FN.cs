using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1742
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int APPLY_CONTROL_TOKEN_FN(
        in CtxtHandle phContext,              // Context to modify
        in SecBufferDesc pInput               // Input token to apply
        );
}
