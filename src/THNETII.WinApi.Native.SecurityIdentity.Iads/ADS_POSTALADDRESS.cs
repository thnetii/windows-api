using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_POSTALADDRESS"/> structure is an ADSI representation of the <strong>Postal Address</strong> attribute.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0006">__MIDL___MIDL_itf_ads_0000_0000_0006 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_POSTALADDRESS
    {
        /// <summary>
        /// An array of six strings that represent the postal address.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPWStr, SizeConst = 6)]
        public string[] PostalAddress;
    }
}
