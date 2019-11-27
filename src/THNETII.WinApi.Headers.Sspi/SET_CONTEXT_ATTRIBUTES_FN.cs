using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1830
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CONTEXT_ATTRIBUTES_FN_W(
        in CtxtHandle phContext,                   // Context to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,              // Attribute to Set
        byte* pBuffer,                             // Buffer for attributes
        int cbBuffer                               // Size (in bytes) of Buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1849
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CONTEXT_ATTRIBUTES_FN_A(
        in CtxtHandle phContext,                   // Context to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,              // Attribute to Set
        byte* pBuffer,                             // Buffer for attributes
        int cbBuffer                               // Size (in bytes) of Buffer
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 1858
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int SET_CONTEXT_ATTRIBUTES_FN(
        in CtxtHandle phContext,                   // Context to Set
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,              // Attribute to Set
        byte* pBuffer,                             // Buffer for attributes
        int cbBuffer                               // Size (in bytes) of Buffer
        );
}
