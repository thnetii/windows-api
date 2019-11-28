using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int COMPLETE_AUTH_TOKEN_FN(
        in CtxtHandle phContext,              // Context to complete
        in SecBufferDesc pToken               // Token to complete
        );
}
