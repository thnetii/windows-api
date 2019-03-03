using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10949
    /// <summary>
    /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> structure specifies the <strong>OCTET_STRING</strong> value type of the claim security attribute.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-claim_security_attribute_octet_string_value">CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
    {
        /// <summary>
        /// A pointer to a buffer that contains the <strong>OCTET_STRING</strong> value. The value is a series of bytes of the length indicated in the <see cref="ValueLength"/> member.
        /// <para>Use the <see cref="Value"/> property to access the bytes in the buffer.</para>
        /// </summary>
        public IntPtr pValue;
        /// <summary>
        /// Gets the span over the <strong>OCTET_STRING</strong> value.
        /// </summary>
        public Span<byte> Value => pValue.AsRefStructSpan<byte>(ValueLength);
        /// <summary>
        /// The length, in bytes, of the <strong>OCTET_STRING</strong> value.
        /// </summary>
        public int ValueLength;
    }
}
