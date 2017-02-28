using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_TRANSPORT_INFO_0"/> structure contains information about the specified transport protocol, including name, address, and location on the network.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="SERVER_TRANSPORT_INFO_0"/> structure is used by the <see cref="NetServerTransportAdd"/> or <see cref="NetServerTransportAddEx"/> function to bind the specified server to the transport protocol.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370949.aspx">SERVER_TRANSPORT_INFO_0 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerTransportAdd"/>
    /// <seealso cref="NetServerTransportAddEx"/>
    /// <seealso cref="NetServerTransportDel"/>
    /// <seealso cref="NetServerTransportEnum"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_2"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_3"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_TRANSPORT_INFO_0
    {
        /// <summary>
        /// The number of clients connected to the server that are using the transport protocol specified by the <see cref="svti0_transportname"/> member.
        /// </summary>
        public int svti0_numberofvcs;
        /// <summary>
        /// A string that contains the name of a transport device; for example,
        /// <code>
        /// \Device\NetBT_Tcpip_{2C9725F4-151A-11D3-AEEC-C3B211BD350B}
        /// </code>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti0_transportname;
        /// <summary>
        /// <para>A pointer to a variable that contains the address the server is using on the transport device specified by the <see cref="svti0_transportname"/> member.</para>
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last bytes must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        public ByteArraySafeHandle svti0_transportaddress;
        /// <summary>
        /// The length, in bytes, of the <see cref="svti0_transportaddress"/> member. For NetBIOS names, the value of this member is 16 (decimal).
        /// </summary>
        public int svti0_transportaddresslength;
        /// <summary>
        /// Gets the address the server is using on the transport device specified by the <see cref="svti0_transportname"/> member.
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last character must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        /// <returns>A managed byte array containing exactly <see cref="svti0_transportaddresslength"/> items, or <c>null</c> if <see cref="svti0_transportaddress"/> is <c>null</c>.</returns>
        public byte[] GetTransportAddress() => svti0_transportaddress?.MarshalToManagedArray(svti0_transportaddresslength);
        /// <summary>
        /// A string that contains the address the network adapter is using. The string is transport-specific.
        /// <para>You can retrieve this value only with a call to the <see cref="NetServerTransportEnum"/> function. You cannot set this value with a call to the <see cref="NetServerTransportAdd"/> function or the <see cref="NetServerTransportAddEx"/> function.)</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti0_networkaddress;
    }
}
