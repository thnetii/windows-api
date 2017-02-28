using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_TRANSPORT_INFO_1"/> structure contains information about the specified transport protocol, including name and address. This information level is valid only for the <see cref="NetServerTransportAddEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="SERVER_TRANSPORT_INFO_1"/> structure is used by the <see cref="NetServerTransportAddEx"/> function to bind the specified server to the transport protocol.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370950.aspx">SERVER_TRANSPORT_INFO_1 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerComputerNameAdd"/>
    /// <seealso cref="NetServerComputerNameDel"/>
    /// <seealso cref="NetServerTransportAdd"/>
    /// <seealso cref="NetServerTransportAddEx"/>
    /// <seealso cref="NetServerTransportDel"/>
    /// <seealso cref="NetServerTransportEnum"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_2"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_3"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_TRANSPORT_INFO_1
    {
        /// <summary>
        /// The number of clients connected to the server that are using the transport protocol specified by the <see cref="svti1_transportname"/> member.
        /// </summary>
        public int svti1_numberofvcs;
        /// <summary>
        /// A string that contains the name of a transport device; for example,
        /// <code>
        /// \Device\NetBT_Tcpip_{2C9725F4-151A-11D3-AEEC-C3B211BD350B}
        /// </code>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti1_transportname;
        /// <summary>
        /// <para>A pointer to a variable that contains the address the server is using on the transport device specified by the <see cref="svti1_transportname"/> member.</para>
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last bytes must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        public ByteArraySafeHandle svti1_transportaddress;
        /// <summary>
        /// The length, in bytes, of the <see cref="svti1_transportaddress"/> member. For NetBIOS names, the value of this member is 16 (decimal).
        /// </summary>
        public int svti1_transportaddresslength;
        /// <summary>
        /// Gets the address the server is using on the transport device specified by the <see cref="svti1_transportname"/> member.
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last character must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        /// <returns>A managed byte array containing exactly <see cref="svti1_transportaddresslength"/> items, or <c>null</c> if <see cref="svti1_transportaddress"/> is <c>null</c>.</returns>
        public byte[] GetTransportAddress() => svti1_transportaddress?.MarshalToManagedArray(svti1_transportaddresslength);
        /// <summary>
        /// A string that contains the address the network adapter is using. The string is transport-specific.
        /// <para>You can retrieve this value only with a call to the <see cref="NetServerTransportEnum"/> function. You cannot set this value with a call to the <see cref="NetServerTransportAdd"/> function or the <see cref="NetServerTransportAddEx"/> function.)</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti1_networkaddress;
        /// <summary>
        /// A string that contains the name of the domain to which the server should announce its presence. (When you call <see cref="NetServerTransportEnum"/>, this member is the name of the domain to which the server is announcing its presence.)
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti1_domain;
    }
}
