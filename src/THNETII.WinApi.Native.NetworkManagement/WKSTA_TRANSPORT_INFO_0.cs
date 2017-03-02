using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_TRANSPORT_INFO_0"/> structure contains information about the workstation transport protocol, such as Wide Area Network (WAN) or NetBIOS.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371407.aspx">WKSTA_TRANSPORT_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaTransportAdd"/>
    /// <seealso cref="NetWkstaTransportEnum"/>
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_TRANSPORT_INFO_0
    {
        /// <summary>
        /// Specifies a value that determines the search order of the transport protocol with respect to other transport protocols. The highest value is searched first.
        /// </summary>
        public int wkti0_quality_of_service;
        /// <summary>
        /// Specifies the number of clients communicating with the server using this transport protocol.
        /// </summary>
        public int wkti0_number_of_vcs;
        /// <summary>
        /// Specifies the device name of the transport protocol.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkti0_transport_name;
        /// <summary>
        /// Specifies the address of the server on this transport protocol.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wkti0_transport_address;
        /// <summary>
        /// This member is ignored by the <see cref="NetWkstaTransportAdd"/> function. For the <see cref="NetWkstaTransportEnum"/> function, this member indicates whether the transport protocol is a WAN transport protocol. This member is set to <c>true</c> for NetBIOS/TCIP; it is set to <c>false</c> for NetBEUI and NetBIOS/IPX. 
        /// <para>Certain legacy networking protocols, including NetBEUI, will no longer be supported. For more information, see <a href="https://msdn.microsoft.com/en-us/library/ms739935.aspx">Network Protocol Support in Windows</a>.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wkti0_wan_ish;
    }
}
