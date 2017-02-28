using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_503"/> structure is obsolete. The structure contains information about the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370948.aspx">SERVER_INFO_503 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    [Obsolete("The SERVER_INFO_503 structure is obsolete.")]
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_503
    {
        /// <summary>
        /// The number of files that can be open in one session.
        /// </summary>
        public int sv503_sessopens;
        /// <summary>
        /// The maximum number of virtual circuits permitted per client.
        /// </summary>
        public int sv503_sessvcs;
        /// <summary>
        /// The number of search operations that can be carried out simultaneously.
        /// </summary>
        public int sv503_opensearch;
        /// <summary>
        /// The size, in bytes, of each server buffer.
        /// </summary>
        public int sv503_sizreqbuf;
        /// <summary>
        /// The initial number of receive buffers, or work items, used by the server.
        /// </summary>
        public int sv503_initworkitems;
        /// <summary>
        /// The maximum number of receive buffers, or work items, the server can allocate. If this limit is reached, the transport must initiate flow control at a significant performance cost.
        /// </summary>
        public int sv503_maxworkitems;
        /// <summary>
        /// The number of special work items the server uses for raw mode I/O. A large value for this member can increase performance, but it requires more memory.
        /// </summary>
        public int sv503_rawworkitems;
        /// <summary>
        /// The number of stack locations that the server allocated in I/O request packets (IRPs).
        /// </summary>
        public int sv503_irpstacksize;
        /// <summary>
        /// The maximum raw mode buffer size, in bytes.
        /// </summary>
        public int sv503_maxrawbuflen;
        /// <summary>
        /// The maximum number of users that can be logged on to the server using a single virtual circuit.
        /// </summary>
        public int sv503_sessusers;
        /// <summary>
        /// The maximum number of tree connections that can be made on the server using a single virtual circuit.
        /// </summary>
        public int sv503_sessconns;
        /// <summary>
        /// The maximum size, in bytes, of pageable memory that the server can allocate at any one time.
        /// </summary>
        public int sv503_maxpagedmemoryusage;
        /// <summary>
        /// The maximum size, in bytes, of nonpaged memory that the server can allocate at any one time.
        /// </summary>
        public int sv503_maxnonpagedmemoryusage;
        /// <summary>
        /// A value that indicates whether the server maps a request to a normal open request with shared-read access when the server receives a compatibility open request with read access. Mapping such requests allows several MS-DOS computers to open a single file for read access.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enablesoftcompat;
        /// <summary>
        /// A value that indicates whether the server should force a client to disconnect, even if the client has open files, once the client's logon time has expired.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enableforcedlogoff;
        /// <summary>
        /// A value that indicates whether the server is a reliable time source.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        ///A value that indicates whether the server accepts function calls from previous-generation LAN Manager clients.
        public bool sv503_timesource;
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_acceptdownlevelapis;
        /// <summary>
        /// A value that indicates whether the server is visible to LAN Manager 2.x clients.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_lmannounce;
        /// <summary>
        /// A string that specifies the name of the server's domain.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv503_domain;
        /// <summary>
        /// The maximum length, in bytes, of copy reads on the server. This member is unused. 
        /// </summary>
        public int sv503_maxcopyreadlen;
        /// <summary>
        /// The maximum length, in bytes, of copy writes on the server. This member is unused. 
        /// </summary>
        public int sv503_maxcopywritelen;
        /// <summary>
        /// The minimum length of time the server retains information about incomplete search operations. This member is unused. 
        /// </summary>
        public int sv503_minkeepsearch;
        /// <summary>
        /// The maximum length of time, in seconds, the server retains information about incomplete search operations.
        /// </summary>
        public int sv503_maxkeepsearch;
        /// <summary>
        /// The minimum length of time, in seconds, the server retains information about complete search operations. This member is unused. 
        /// </summary>
        public int sv503_minkeepcomplsearch;
        /// <summary>
        /// The maximum length of time, in seconds, the server retains information about complete search operations. This member is unused. 
        /// </summary>
        public int sv503_maxkeepcomplsearch;
        /// <summary>
        /// The number of additional threads the server should use in addition to one worker thread per processor it already uses. This member is unused. 
        /// </summary>
        public int sv503_threadcountadd;
        /// <summary>
        /// The number of threads set aside by the server to service requests that can block the thread for a significant amount of time. This member is unused. 
        /// </summary>
        public int sv503_numblockthreads;
        /// <summary>
        /// The period of time, in seconds, that the scavenger remains idle before waking up to service requests.
        /// </summary>
        public int sv503_scavtimeout;
        /// <summary>
        /// The minimum number of free receive work items the server requires before it begins to allocate more.
        /// </summary>
        public int sv503_minrcvqueue;
        /// <summary>
        /// The minimum number of available receive work items that the server requires to begin processing a server message block.
        /// </summary>
        public int sv503_minfreeworkitems;
        /// <summary>
        /// The size, in bytes, of the shared memory region used to process server functions.
        /// </summary>
        public int sv503_xactmemsize;
        /// <summary>
        /// The priority of all server threads in relation to the base priority of the process.
        /// </summary>
        public int sv503_threadpriority;
        /// <summary>
        /// The maximum number of outstanding requests that any one client can send to the server. For example, 10 means you can have 10 unanswered requests at the server. When any single client has 10 requests queued within the server, the client must wait for a server response before sending another request.
        /// </summary>
        public int sv503_maxmpxct;
        /// <summary>
        /// The period of time, in seconds, to wait before timing out an opportunistic lock break request.
        /// </summary>
        public int sv503_oplockbreakwait;
        /// <summary>
        /// The period of time, in seconds, the server waits for a client to respond to an oplock break request from the server. 
        /// </summary>
        public int sv503_oplockbreakresponsewait;
        /// <summary>
        /// A value that indicates whether the server allows clients to use opportunistic locks on files. Opportunistic locks are a significant performance enhancement, but have the potential to cause lost cached data on some networks, particularly wide-area networks.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enableoplocks;
        /// <summary>
        /// A value that indicates how the server should behave if a client has an opportunistic lock (oplock) and does not respond to an oplock break. This member indicates whether the server will fail the second open (value of 0), or force close the open instance of a client that has an oplock (value equal to 1). This member is unused.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enableoplockforceclose;
        /// <summary>
        /// A value that indicates whether several MS-DOS File Control Blocks (FCBs) are placed in a single location accessible to the server. If enabled, this can save resources on the server.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enablefcbopens;
        /// <summary>
        /// A value that indicates whether the server processes raw Server Message Blocks (SMBs). If enabled, this allows more data to transfer per transaction and also improves performance. However, it is possible that processing raw SMBs can impede performance on certain networks. The server maintains the value of this member.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enableraw;
        /// <summary>
        /// A value that indicates whether the server allows redirected server drives to be shared.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool sv503_enablesharednetdrives;
        /// <summary>
        /// The minimum number of free connection blocks maintained per endpoint. The server sets these aside to handle bursts of requests by clients to connect to the server.
        /// </summary>
        public int sv503_minfreeconnections;
        /// <summary>
        /// The maximum number of free connection blocks maintained per endpoint. The server sets these aside to handle bursts of requests by clients to connect to the server.
        /// </summary>
        public int sv503_maxfreeconnections;
    }
}
