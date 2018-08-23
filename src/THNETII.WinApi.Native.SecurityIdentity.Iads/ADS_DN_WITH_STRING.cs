using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_DN_WITH_STRING"/> structure is used with the <see cref="ADSVALUE"/> structure to contain a distinguished name attribute value that also contains string data.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0016">__MIDL___MIDL_itf_ads_0000_0000_0016 structure</a></para>
    /// </remarks>
    /// <seealso cref="ADSVALUE"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_DN_WITH_STRING
    {
        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the string value of the attribute.
        /// </summary>
        public IntPtr pszStringValue;

        /// <summary>
        /// Gets a span over the string that contains the string value of the attribute.
        /// </summary>
        public Span<char> StringValue => pszStringValue.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the distinguished name.
        /// </summary>
        public IntPtr pszDNString;

        /// <summary>
        /// Gets a span over the string that contains the distinguished name.
        /// </summary>
        public Span<char> DNString => pszDNString.AsZeroTerminatedUnicodeSpan();
    }
}
