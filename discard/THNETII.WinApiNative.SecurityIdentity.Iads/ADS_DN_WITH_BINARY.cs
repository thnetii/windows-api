using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_DN_WITH_BINARY"/> structure is used with the <see cref="ADSVALUE"/> structure to contain a distinguished name attribute value that also contains binary data.
    /// </summary>
    /// <remarks>
    /// When extending the active directory schema to add <see cref="ADS_DN_WITH_BINARY"/>, you must also specify the <c>otherWellKnownGuid</c> attribute definition. Add the following to the ldf file attribute definition: <c>omObjectClass:: KoZIhvcUAQEBCw==</c>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0015">__MIDL___MIDL_itf_ads_0000_0000_0015 structure</a></para>
    /// </remarks>
    /// <seealso cref="ADSVALUE"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_DN_WITH_BINARY
    {
        /// <summary>
        /// Contains the length, in bytes, of the binary data in <see cref="lpBinaryValue"/>.
        /// </summary>
        public int dwLength;

        /// <summary>
        /// Pointer to an array of bytes that contains the binary data for the attribute. The <see cref="dwLength"/> member contains the number of bytes in this array.
        /// </summary>
        public IntPtr lpBinaryValue;

        /// <summary>
        /// Gets a span over the binary data pointed to by <see cref="lpBinaryValue"/>.
        /// </summary>
        public unsafe Span<byte> BinaryValue =>
            new Span<byte>(lpBinaryValue.ToPointer(), dwLength);

        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the distinguished name.
        /// </summary>
        public IntPtr pszDNString;

        /// <summary>
        /// Gets a span over the characters of the string that contains the distinguished name.
        /// </summary>
        public Span<char> DNString => pszDNString.AsZeroTerminatedUnicodeSpan();
    }
}
