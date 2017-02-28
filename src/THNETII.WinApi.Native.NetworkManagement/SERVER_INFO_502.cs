using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_502"/> structure contains information about the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370945.aspx">SERVER_INFO_502 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="NetServerSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_502
    {
        /// <summary>
        /// The number of files that can be open in one session.
        /// </summary>
        public int sv502_sessopens;
        /// <summary>
        /// The maximum number of virtual circuits permitted per client.
        /// </summary>
        public int sv502_sessvcs;
        /// <summary>
        /// The number of search operations that can be carried out simultaneously.
        /// </summary>
        public int sv502_opensearch;
        /// <summary>
        /// The size, in bytes, of each server buffer.
        /// </summary>
        public int sv502_sizreqbuf;
        /// <summary>
        /// The initial number of receive buffers, or work items, used by the server.
        /// </summary>
        public int sv502_initworkitems;
        /// <summary>
        /// The maximum number of receive buffers, or work items, the server can allocate. If this limit is reached, the transport must initiate flow control at a significant performance cost.
        /// </summary>
        public int sv502_maxworkitems;
        /// <summary>
        /// The number of special work items the server uses for raw mode I/O. A large value for this member can increase performance, but it requires more memory.
        /// </summary>
        public int sv502_rawworkitems;
        /// <summary>
        /// The number of stack locations that the server allocated in I/O request packets (IRPs).
        /// </summary>
        public int sv502_irpstacksize;
        /// <summary>
        /// The maximum raw mode buffer size, in bytes.
        /// </summary>
        public int sv502_maxrawbuflen;
        /// <summary>
        /// The maximum number of users that can be logged on to the server using a single virtual circuit.
        /// </summary>
        public int sv502_sessusers;
        /// <summary>
        /// The maximum number of tree connections that can be made on the server using a single virtual circuit.
        /// </summary>
        public int sv502_sessconns;
        /// <summary>
        /// The maximum size, in bytes, of pageable memory that the server can allocate at any one time.
        /// </summary>
        public int sv502_maxpagedmemoryusage;
        /// <summary>
        /// The maximum size, in bytes, of nonpaged memory that the server can allocate at any one time.
        /// </summary>
        public int sv502_maxnonpagedmemoryusage;
        /// <summary>
        /// A value that indicates whether the server maps a request to a normal open request with shared-read access when the server receives a compatibility open request with read access. Mapping such requests allows several MS-DOS computers to open a single file for read access.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv502_enablesoftcompat;
        /// <summary>
        /// A value that indicates whether the server should force a client to disconnect, even if the client has open files, once the client's logon time has expired.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv502_enableforcedlogoff;
        /// <summary>
        /// A value that indicates whether the server is a reliable time source.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        ///A value that indicates whether the server accepts function calls from previous-generation LAN Manager clients.
        public bool sv502_timesource;
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv502_acceptdownlevelapis;
        /// <summary>
        /// A value that indicates whether the server is visible to LAN Manager 2.x clients.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv502_lmannounce;
    }
}
