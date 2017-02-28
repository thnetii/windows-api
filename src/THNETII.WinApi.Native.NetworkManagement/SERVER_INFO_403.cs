using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="SERVER_INFO_403"/> structure contains information about the specified server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370944.aspx">SERVER_INFO_403 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetServerGetInfo"/>
    /// <seealso cref="NetServerSetInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public class SERVER_INFO_403
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// The last time the user list was modified. The value is expressed as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT, and applies to servers running with user-level security.
        /// </summary>
        public int sv403_ulist_mtime;
        /// <summary>
        /// The last time the user list was modified. The value is expressed as a <see cref="DateTime"/> value according to the local time of the system, and applies to servers running with user-level security.
        /// </summary>
        public DateTime UserListLastModificationDateTime => epoch.AddSeconds(sv403_ulist_mtime).ToLocalTime();
        /// <summary>
        /// The last time the group list was modified. The value is expressed as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT, and applies to servers running with user-level security.
        /// </summary>
        public int sv403_glist_mtime;
        /// <summary>
        /// The last time the group list was modified. The value is expressed as a <see cref="DateTime"/> value according to the local time of the system, and applies to servers running with user-level security.
        /// </summary>
        public DateTime GroupListLastModificationDateTime => epoch.AddSeconds(sv403_glist_mtime).ToLocalTime();
        /// <summary>
        /// The last time the access control list was modified. The value is expressed as the number of seconds that have elapsed since 00:00:00, January 1, 1970, GMT, and applies to servers running with user-level security.
        /// </summary>
        public int sv403_alist_mtime;
        /// <summary>
        /// The last time the access control list was modified. The value is expressed as a <see cref="DateTime"/> value according to the local time of the system, and applies to servers running with user-level security.
        /// </summary>
        public DateTime AccessControlListLastModificationDateTime => epoch.AddSeconds(sv403_alist_mtime).ToLocalTime();
        /// <summary>
        /// A string that specifies the list of user names on the server. Spaces separate the names.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv403_alerts;
        /// <summary>
        /// The security type of the server. This member can be one of the following values. Note that Windows NT, Windows 2000, Windows XP, and Windows Server 2003 operating systems do not support share-level security. 
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public SV_SECURITY sv403_security;
        /// <summary>
        /// The number of administrators the server can accommodate at one time.
        /// </summary>
        public int sv403_numadmin;
        /// <summary>
        /// The order in which the network device drivers are served.
        /// </summary>
        public int sv403_lanmask;
        /// <summary>
        /// A string that specifies the name of a reserved account for guest users on the server. The constant <see cref="UNLEN"/> specifies the maximum number of characters in the string.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv403_guestacct;
        /// <summary>
        /// The number of character-oriented devices that can be shared on the server.
        /// </summary>
        public int sv403_chdevs;
        /// <summary>
        /// The number of character-oriented device queues that can coexist on the server.
        /// </summary>
        public int sv403_chdevq;
        /// <summary>
        /// The number of character-oriented device jobs that can be pending at one time on the server.
        /// </summary>
        public int sv403_chdevjobs;
        /// <summary>
        /// The number of connections allowed on the server.
        /// </summary>
        public int sv403_connections;
        /// <summary>
        /// The number of share names the server can accommodate.
        /// </summary>
        public int sv403_shares;
        /// <summary>
        /// The number of files that can be open at once on the server.
        /// </summary>
        public int sv403_openfiles;
        /// <summary>
        /// The number of files that one session can open.
        /// </summary>
        public int sv403_sessopens;
        /// <summary>
        /// The maximum number of virtual circuits permitted per client.
        /// </summary>
        public int sv403_sessvcs;
        /// <summary>
        /// The number of simultaneous requests a client can make on a single virtual circuit.
        /// </summary>
        public int sv403_sessreqs;
        /// <summary>
        /// The number of search operations that can be carried out simultaneously.
        /// </summary>
        public int sv403_opensearch;
        /// <summary>
        /// The number of file locks that can be active at the same time.
        /// </summary>
        public int sv403_activelocks;
        /// <summary>
        /// The number of server buffers provided.
        /// </summary>
        public int sv403_numreqbuf;
        /// <summary>
        /// The size, in bytes, of each server buffer.
        /// </summary>
        public uint sv403_sizreqbuf;
        /// <summary>
        /// The number of 64K server buffers provided.
        /// </summary>
        public int sv403_numbigbuf;
        /// <summary>
        /// The number of processes that can access the operating system at one time.
        /// </summary>
        public int sv403_numfiletasks;
        /// <summary>
        /// The interval, in seconds, for notifying an administrator of a network event.
        /// </summary>
        public int sv403_alertsched;
        /// <summary>
        /// The number of entries that can be written to the error log, in any one interval, before notifying an administrator. The interval is specified by the <see cref="sv403_alertsched"/> member.
        /// </summary>
        public int sv403_erroralert;
        /// <summary>
        /// The number of invalid logon attempts to allow a user before notifying an administrator.
        /// </summary>
        public int sv403_logonalert;
        /// <summary>
        /// The number of invalid file access attempts to allow before notifying an administrator.
        /// </summary>
        public int sv403_accessalert;
        /// <summary>
        /// The point at which the system sends a message notifying an administrator that free space on a disk is low. This value is expressed as the number of kilobytes of free disk space remaining on the disk.
        /// </summary>
        public int sv403_diskalert;
        /// <summary>
        /// The network I/O error ratio, in tenths of a percent, that is allowed before notifying an administrator.
        /// </summary>
        public int sv403_netioalert;
        /// <summary>
        /// The maximum size, in kilobytes, of the audit file. The audit file traces user activity.
        /// </summary>
        public int sv403_maxauditsz;
        /// <summary>
        /// A string containing flags that control operations on a server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv403_srvheuristics;
        /// <summary>
        /// The audit event control mask.
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public SW_AUTOPROF sv403_auditedevents;
        /// <summary>
        /// A value that controls the action of the server on the profile.
        /// </summary>
        public int sv403_autoprofile;
        /// <summary>
        /// A string that contains the path for the profile.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string sv403_autopath;
    }
}
