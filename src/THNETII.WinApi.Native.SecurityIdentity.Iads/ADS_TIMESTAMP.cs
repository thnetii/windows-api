using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_TIMESTAMP"/> structure is an ADSI representation of the <strong>Timestamp</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0007">__MIDL___MIDL_itf_ads_0000_0000_0007 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_TIMESTAMP
    {
        /// <summary>
        /// The epoch reference for the timestamp format,
        /// representing 12:00 AM, January, 1970, UTC.
        /// </summary>
        public static DateTime Epoch { get; } = new DateTime(1970, 01, 01, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// Number of seconds, with zero value being equal to 12:00 AM, January, 1970, UTC.
        /// </summary>
        public int WholeSeconds;

        /// <summary>
        /// Gets the timestamp represented as a <see cref="DateTime"/> value.
        /// </summary>
        public DateTime DateTime => Epoch.AddSeconds(unchecked((uint)WholeSeconds));

        /// <summary>
        /// An event identifier, in the order of occurrence, within the period specified by <see cref="WholeSeconds"/>.
        /// </summary>
        public int EventID;
    }
}
