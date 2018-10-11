using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_PROV_SPECIFIC"/> structure contains provider-specific data represented as a binary large object (BLOB).
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="ADS_PROV_SPECIFIC"/> structure is one of the data types used as a member of the <see cref="ADSVALUE"/> structure definition. The data is represented as a BLOB here, although the actual data can be packed in any format, such as a C structure. The provider writer must publish the specific data format under the BLOB.</para>
    /// <para>ADSI may also return attributes as <see cref="ADS_PROV_SPECIFIC"/> if unable to determine the correct attribute syntax type as would occur if, for example, the schema was unavailable.</para>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0004">__MIDL___MIDL_itf_ads_0000_0000_0004  structure</a></para>
    /// </remarks>
    /// <see cref="ADSVALUE"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_PROV_SPECIFIC
    {
        /// <summary>
        /// The size of the character array.
        /// </summary>
        public int dwLength;

        /// <summary>
        /// A pointer to an array of bytes.
        /// </summary>
        public IntPtr lpValue;

        /// <summary>
        /// Returns the current instance as a span over the bytes pointed to by <see cref="lpValue"/>.
        /// </summary>
        /// <returns>A span granting read/write access to the bytes pointed to by the current instance.</returns>
        public unsafe Span<byte> AsSpan() => new Span<byte>(lpValue.ToPointer(), dwLength);
    }
}
