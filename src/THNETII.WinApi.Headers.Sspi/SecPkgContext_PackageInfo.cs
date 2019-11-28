using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 963
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_PackageInfoW
    {
        public SecPkgInfoW PackageInfo;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 970
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_PackageInfoA
    {
        public SecPkgInfoA PackageInfo;
    }
}
