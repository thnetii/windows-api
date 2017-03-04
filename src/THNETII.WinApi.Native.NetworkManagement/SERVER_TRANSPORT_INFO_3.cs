using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.SVTI2_FLAGS;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_TRANSPORT_INFO_3"/> structure contains information about the specified transport protocol, including name, address and password (credentials). This information level is valid only for the <see cref="NetServerTransportAddEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="SERVER_TRANSPORT_INFO_3"/> structure is used by the <see cref="NetServerTransportAddEx"/> function to bind the specified server to the transport protocol.</para>
    /// <para>An example of the use of the <see cref="SVTI2_REMAP_PIPE_NAMES"/> value follows. Call the <see cref="NetServerTransportAddEx"/> function to add a transport to the server, specifying the address of "MyServer" in the <see cref="svti3_transportaddress"/> member, and <see cref="SVTI2_REMAP_PIPE_NAMES"/> in the <see cref="svti3_flags"/> member. When a client attempts to open "Pipe" on "\\MyServer" the client will actually open $$MyServer\Pipe instead.</para>
    /// <para>The <see cref="svti3_passwordlength"/> and <see cref="svti3_password"/> members are necessary for a client and server to perform mutual authentication.</para>
    /// <para>On Windows Server 2008 and Windows Vista with SP1, every name registered with the Windows remote file server (SRV) is designated as either a scoped name or a non-scoped name. Every share that is added to the system will then either be attached to all of the non-scoped names, or to a single scoped name. Applications that wish to use the scoping features are responsible for both registering the new name as a scoped endpoint and then creating the shares with an appropriate scope. In this way, legacy uses of the Network Management and Network Share Management functions are not affected in any way since they continue to register shares and names as non-scoped names. </para>
    /// <para>A scoped endpoint is created by calling the <see cref="NetServerTransportAddEx"/> function with the <var>level</var> parameter set to <c>2</c> and the <var>bufptr</var> parameter pointed to a <see cref="SERVER_TRANSPORT_INFO_2"/> structure with the <see cref="SVTI2_SCOPED_NAME"/> bit value set in <see cref="SERVER_TRANSPORT_INFO_2.svti2_flags"/> member. A scoped endpoint is also created by calling the <see cref="NetServerTransportAddEx"/> function with the <var>level</var> parameter set to <c>3</c> and the <var>bufptr</var> parameter pointed to a <see cref="SERVER_TRANSPORT_INFO_3"/> structure with the <see cref="SVTI2_SCOPED_NAME"/> bit value set in <see cref="svti3_flags"/> member. </para>
    /// <para>When the <see cref="SVTI2_SCOPED_NAME"/> bit value is set for a transport, then shares can be added with a corresponding server name (the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SHARE_INFO_503"/> structure) in a scoped fashion using the <see cref="NetShareAdd"/> function. If there is no transport registered with the <see cref="SVTI2_SCOPED_NAME"/> bit value and the name provided in <see cref="SHARE_INFO_503.shi503_servername"/> member, then the share add in a scoped fashion will not succeed. </para>
    /// <para>The <see cref="NetShareAdd"/> function is used to add a scoped share on a remote server specified in the <var>servername</var> parameter. The remote server specified in the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SHARE_INFO_503"/> passed in the <var>bufptr</var> parameter must have been bound to a transport protocol using the <see cref="NetServerTransportAddEx"/> function as a scoped endpoint. The <see cref="SVTI2_SCOPED_NAME"/> flag must have been specified in the <see cref="SHARE_INFO_503.shi503_servername"/> member of the <see cref="SERVER_TRANSPORT_INFO_2"/> or <see cref="SERVER_TRANSPORT_INFO_3"/> structure for the transport protocol. The <see cref="NetShareDelEx"/> function is used to delete a scoped share. The <see cref="NetShareGetInfo"/> and <see cref="NetShareSetInfo"/> functions are to used to get and set information on a scoped share. </para>
    /// <para>Scoped endpoints are generally used by the cluster namespace.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370951.aspx">SERVER_TRANSPORT_INFO_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerComputerNameAdd"/>
    /// <seealso cref="NetServerComputerNameDel"/>
    /// <seealso cref="NetServerTransportAdd"/>
    /// <seealso cref="NetServerTransportAddEx"/>
    /// <seealso cref="NetServerTransportDel"/>
    /// <seealso cref="NetServerTransportEnum"/>
    /// <seealso cref="NetShareAdd"/>
    /// <seealso cref="NetShareDelEx"/>
    /// <seealso cref="NetShareGetInfo"/>
    /// <seealso cref="NetShareSetInfo"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_0"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_1"/>
    /// <seealso cref="SERVER_TRANSPORT_INFO_2"/>
    /// <seealso cref="SHARE_INFO_503"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_TRANSPORT_INFO_3
    {
        /// <summary>
        /// The number of clients connected to the server that are using the transport protocol specified by the <see cref="svti3_transportname"/> member.
        /// </summary>
        public int svti3_numberofvcs;
        /// <summary>
        /// A string that contains the name of a transport device; for example,
        /// <code>
        /// \Device\NetBT_Tcpip_{2C9725F4-151A-11D3-AEEC-C3B211BD350B}
        /// </code>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti3_transportname;
        /// <summary>
        /// <para>A pointer to a variable that contains the address the server is using on the transport device specified by the <see cref="svti3_transportname"/> member.</para>
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last bytes must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        public ByteArrayAnySafeHandle svti3_transportaddress;
        /// <summary>
        /// The length, in bytes, of the <see cref="svti3_transportaddress"/> member. For NetBIOS names, the value of this member is 16 (decimal).
        /// </summary>
        public int svti3_transportaddresslength;
        /// <summary>
        /// Gets the address the server is using on the transport device specified by the <see cref="svti3_transportname"/> member.
        /// <para>This member is usually the NetBIOS name that the server is using. In these instances, the name must be 16 bytes long, and the last character must be a blank character (<c>0x20</c>).</para>
        /// </summary>
        /// <returns>A managed byte array containing exactly <see cref="svti3_transportaddresslength"/> items, or <c>null</c> if <see cref="svti3_transportaddress"/> is <c>null</c>.</returns>
        public byte[] GetTransportAddress() => ByteArraySafeHandle.ReadValue(svti3_transportaddress, svti3_transportaddresslength);
        /// <summary>
        /// A string that contains the address the network adapter is using. The string is transport-specific.
        /// <para>You can retrieve this value only with a call to the <see cref="NetServerTransportEnum"/> function. You cannot set this value with a call to the <see cref="NetServerTransportAdd"/> function or the <see cref="NetServerTransportAddEx"/> function.)</para>
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti3_networkaddress;
        /// <summary>
        /// A string that contains the name of the domain to which the server should announce its presence. (When you call <see cref="NetServerTransportEnum"/>, this member is the name of the domain to which the server is announcing its presence.)
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string svti3_domain;
        /// <summary>
        /// This member can be a combination of the bit values defined in the <see cref="SVTI2_FLAGS"/> type.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public SVTI2_FLAGS svti3_flags;
        /// <summary>
        /// The number of valid bytes in the <see cref="svti3_password"/> member.
        /// </summary>
        public int svti3_passwordlength;
        /// <summary>
        /// The credentials to use for the new transport address. If the <see cref="svti3_passwordlength"/> member is zero, the credentials for the server are used.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] svti3_password;
    }
}
