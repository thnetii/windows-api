using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1730
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int DELETE_SECURITY_CONTEXT_FN(
        in CtxtHandle phContext     // Context to delete
        );
}
