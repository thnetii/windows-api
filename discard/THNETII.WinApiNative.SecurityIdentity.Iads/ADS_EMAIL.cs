using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_EMAIL"/> structure is an ADSI representation of the <strong>Email Address</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0014">__MIDL___MIDL_itf_ads_0000_0000_0014 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_EMAIL
    {
        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the user address.
        /// </summary>
        public IntPtr pwzAddress;

        /// <summary>
        /// Gets a span over the string that contains the user address.
        /// </summary>
        public Span<char> Address => pwzAddress.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Type of the email message.
        /// </summary>
        public int Type;
    }
}
