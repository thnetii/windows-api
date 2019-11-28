using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1053
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_CredentialNameW
    {
        public int CredentialType;  
        public LPWSTR sCredentialName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1062
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_CredentialNameA
    {
        public int CredentialType;
        public LPSTR sCredentialName;
    }
}
