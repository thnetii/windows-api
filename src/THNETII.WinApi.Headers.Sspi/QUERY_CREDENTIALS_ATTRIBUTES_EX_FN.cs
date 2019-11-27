using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1888
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CREDENTIALS_ATTRIBUTES_EX_FN_W(
        in CredHandle phCredential,           // Credential to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1919
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CREDENTIALS_ATTRIBUTES_EX_FN_A(
        in CredHandle phCredential,           // Credential to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1930
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CREDENTIALS_ATTRIBUTES_EX_FN(
        in CredHandle phCredential,           // Credential to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );
}
