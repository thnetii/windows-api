using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 292
    //
    //  Fully-qualified binary name.
    //

    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE"/> structure specifies a fully qualified binary name value associated with a security attribute.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_security_attribute_fqbn_value">AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE structure</a></para>
    /// </remarks>
    /// <seealso cref="AUTHZ_SECURITY_ATTRIBUTE_V1"/>
    /// <seealso cref="AUTHZ_SECURITY_ATTRUBUTES_INFORMATION"/>
    /// <seealso cref="AuthzModifySecurityAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE
    {
        /// <summary>
        /// The version number of the structure.
        /// </summary>
        public ulong Version;
        /// <summary>
        /// A pointer to a string that specify the names of the publisher, the product, and the original binary file of the value.
        /// </summary>
        public LPWSTR pName;
    }
}
