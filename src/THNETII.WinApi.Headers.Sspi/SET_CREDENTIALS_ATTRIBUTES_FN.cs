using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1951
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CREDENTIALS_ATTRIBUTES_FN_W(
        in CredHandle phCredential,         // Credential to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,       // Attribute to Set
        byte* pBuffer,                      // Buffer for attributes
        [In] int cbBuffer                   // Size (in bytes) of Buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1970
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CREDENTIALS_ATTRIBUTES_FN_A(
        in CredHandle phCredential,         // Credential to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,       // Attribute to Set
        byte* pBuffer,                      // Buffer for attributes
        [In] int cbBuffer                   // Size (in bytes) of Buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1979
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CREDENTIALS_ATTRIBUTES_FN(
        in CredHandle phCredential,         // Credential to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,       // Attribute to Set
        byte* pBuffer,                      // Buffer for attributes
        [In] int cbBuffer                   // Size (in bytes) of Buffer
        );
}
