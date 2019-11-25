using Microsoft.Win32.SafeHandles;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1719
    public delegate int QUERY_SECURITY_CONTEXT_TOKEN_FN(
        in CtxtHandle phContext,
        out SafeAccessTokenHandle Token
        );
}
