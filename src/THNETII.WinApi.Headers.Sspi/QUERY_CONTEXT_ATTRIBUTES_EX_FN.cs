using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CONTEXT_ATTRIBUTES_EX_FN_W(
        in CtxtHandle phContext,              // Context to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CONTEXT_ATTRIBUTES_EX_FN_A(
        in CtxtHandle phContext,              // Context to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate int QUERY_CONTEXT_ATTRIBUTES_EX_FN(
        in CtxtHandle phContext,              // Context to query
        [In, MarshalAs(UnmanagedType.U4)]
        SECPKG_ATTR_TYPE ulAttribute,         // Attribute to query
        byte* pBuffer,                        // Buffer for attributes
        [In] int cbBuffer                     // Length of buffer
        );
}
