using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 309
    //
    //  This is the 'catch all' type. The attribute manipulation
    //  code really doesn't care about the actual format of the
    //  value. Value subtypes are defined only for this type.
    //  Value subtypes permit easy addition of new subtypes
    //  without having to change the attribute manipulation
    //  (and WOW64 thunking!) code.
    //

    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> structure specifies an octet string value for a security attribute.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_security_attribute_octet_string_value">AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE structure</a></para>
    /// </remarks>
    /// <seealso cref="AUTHZ_SECURITY_ATTRIBUTE_V1"/>
    /// <seealso cref="AUTHZ_SECURITY_ATTRUBUTES_INFORMATION"/>
    /// <seealso cref="AuthzModifySecurityAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
    {
        /// <summary>
        /// A pointer to the value.
        /// </summary>
        public byte* pValue;         //  Pointer is BYTE aligned.
        /// <summary>
        /// The length, in bytes, of the <see cref="pValue"/> member.
        /// </summary>
        public int ValueLength;    //  In bytes
        /// <summary>
        /// A span of bytes over the value.
        /// </summary>
        public Span<byte> Value => new Span<byte>(pValue, ValueLength);
    }
}
