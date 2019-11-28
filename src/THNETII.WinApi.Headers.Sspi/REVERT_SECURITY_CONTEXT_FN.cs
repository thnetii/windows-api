using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int REVERT_SECURITY_CONTEXT_FN(
        in CtxtHandle phContext               // Context from which to re
        );
}
