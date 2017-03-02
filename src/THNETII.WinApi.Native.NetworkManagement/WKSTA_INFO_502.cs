using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="WKSTA_INFO_502"/> structure is obsolete. The structure contains information about a workstation environment.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa371404.aspx">WKSTA_INFO_502 structure</a></para>
    /// </remarks>
    /// <seealso cref="NetWkstaGetInfo"/>
    /// <seealso cref="NetWkstaSetInfo"/>
    [Obsolete("The WKSTA_INFO_502 structure is obsolete.")]
    [StructLayout(LayoutKind.Sequential)]
    public class WKSTA_INFO_502
    {
        /// <summary>
        /// The number of seconds the computer waits for a remote resource to become available.
        /// </summary>
        public int wki502_char_wait;
        /// <summary>
        /// The time the computer waist for a remote resource to become available.
        /// </summary>
        /// <seealso cref="wki502_char_wait"/>
        public TimeSpan CharWait
        {
            get { return TimeSpan.FromSeconds((uint)wki502_char_wait); }
            set { wki502_char_wait = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// The number of milliseconds the computer collects data before sending the data to a character device resource. The workstation waits the specified time or collects the number of characters specified by the <see cref="wki502_maximum_collection_count"/> member, whichever comes first.
        /// </summary>
        public int wki502_collection_time;
        /// <summary>
        /// The time the computer collects data before sending the data to a character device resource. The workstation waits the specified time or collects the number of characters specified by the <see cref="wki502_maximum_collection_count"/> member, whichever comes first.
        /// </summary>
        /// <seealso cref="wki502_collection_time"/>
        public TimeSpan CollectionTime
        {
            get { return TimeSpan.FromMilliseconds((uint)wki502_collection_time); }
            set { wki502_collection_time = (int)((uint)value.TotalMilliseconds); }
        }
        /// <summary>
        /// The number of bytes of information the computer collects before sending the data to a character device resource. The workstation collects the specified number of bytes or waits the period of time specified by the <see cref="wki502_collection_time"/> member, whichever comes first.
        /// </summary>
        public int wki502_maximum_collection_count;
        /// <summary>
        /// The number of seconds the server maintains an inactive connection to a server's resource.
        /// </summary>
        public int wki502_keep_conn;
        /// <summary>
        /// The amount of time the server maintains an inactive connection to a server's resource.
        /// </summary>
        /// <seealso cref="wki502_keep_conn"/>
        public TimeSpan KeepInactiveConnectionTime
        {
            get { return TimeSpan.FromSeconds((uint)wki502_keep_conn); }
            set { wki502_keep_conn = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// The number of simultaneous network device driver commands that can be sent to the network.
        /// </summary>
        public int wki502_max_cmds;
        /// <summary>
        /// The number of seconds the server waits before disconnecting an inactive session.
        /// </summary>
        public int wki502_sess_timeout;
        /// <summary>
        /// The amount of time the server waits before disconnecting an inactive session.
        /// </summary>
        public TimeSpan InactiveSessionTimeout
        {
            get { return TimeSpan.FromSeconds(wki502_sess_timeout); }
            set { wki502_sess_timeout = (int)((uint)value.TotalSeconds); }
        }
        /// <summary>
        /// The maximum size, in bytes, of a character pipe buffer and device buffer.
        /// </summary>
        public int wki502_siz_char_buf;
        /// <summary>
        /// The number of threads the computer can dedicate to the network.
        /// </summary>
        public int wki502_max_threads;
        /// <summary>Reserved.</summary>
        public int wki502_lock_quota;
        /// <summary>Reserved.</summary>
        public int wki502_lock_increment;
        /// <summary>Reserved.</summary>
        public int wki502_lock_maximum;
        /// <summary>Reserved.</summary>
        public int wki502_pipe_increment;
        /// <summary>Reserved.</summary>
        public int wki502_pipe_maximum;
        /// <summary>Reserved.</summary>
        public int wki502_cache_file_timeout;
        /// <summary>Reserved.</summary>
        public int wki502_dormant_file_limit;
        /// <summary>Reserved.</summary>
        public int wki502_read_ahead_throughput;
        /// <summary>Reserved.</summary>
        public int wki502_num_mailslot_buffers;
        /// <summary>Reserved.</summary>
        public int wki502_num_srv_announce_buffers;
        /// <summary>Reserved.</summary>
        public int wki502_max_illegal_datagram_events;
        /// <summary>Reserved.</summary>
        public int wki502_illegal_datagram_event_reset_frequency;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_log_election_packets;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_opportunistic_locking;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_unlock_behind;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_close_behind;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_buf_named_pipes;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_lock_read_unlock;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_utilize_nt_caching;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_raw_read;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_raw_write;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_write_raw_data;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_encryption;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_buf_files_deny_write;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_buf_read_only_files;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_force_core_create_mode;
        /// <summary>Reserved.</summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool wki502_use_512_byte_max_transfer;
    }
}
