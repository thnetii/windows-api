using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1028
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NativeNamesW
    {
        public LPWSTR sClientName;
        public LPWSTR sServerName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1034
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_NativeNamesA
    {
        public LPSTR sClientName;
        public LPSTR sServerName;
    }
}
