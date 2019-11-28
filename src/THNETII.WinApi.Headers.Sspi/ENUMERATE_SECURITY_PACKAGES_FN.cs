using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2083
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int ENUMERATE_SECURITY_PACKAGES_FN_W(
        out int pcPackages,             // Receives num. packages
        out SecPkgInfoW* ppPackageInfo  // Receives array of info
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 2096
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int ENUMERATE_SECURITY_PACKAGES_FN_A(
        out int pcPackages,             // Receives num. packages
        out SecPkgInfoA* ppPackageInfo  // Receives array of info
        );
}
