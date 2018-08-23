using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_NETADDRESS"/> structure is an ADSI representation of the <strong>Net Address</strong> attribute syntax.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0011">__MIDL___MIDL_itf_ads_0000_0000_0011 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_NETADDRESS
    {
        /// <summary>
        /// Types of communication protocols.
        /// </summary>
        public int AddressType;

        /// <summary>
        /// Address length in bytes.
        /// </summary>
        public int AddressLength;

        /// <summary>
        /// A pointer to the network address
        /// </summary>
        public IntPtr pAddress;

        /// <summary>
        /// Gets the span over the network address.
        /// </summary>
        public unsafe Span<byte> Address => new Span<byte>(pAddress.ToPointer(), AddressLength);
    }
}
