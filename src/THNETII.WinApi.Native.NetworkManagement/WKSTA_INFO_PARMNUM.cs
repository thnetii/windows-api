using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// <para>Identifiers for use as <see cref="NetWkstaSetInfo"/> parmnum parameter</para>
    /// <para>
    /// One of these values indicates the parameter within an information
    /// structure that is invalid when <see cref="ERROR_INVALID_PARAMETER"/> is returned by
    /// <see cref="NetWkstaSetInfo"/>.
    /// </para>
    /// </summary>
    public enum WKSTA_INFO_PARMNUM : int
    {
        /// <summary><var>wki*_platform_id</var></summary>
        WKSTA_PLATFORM_ID_PARMNUM = 100,
        /// <summary><var>wki*_computername</var></summary>
        WKSTA_COMPUTERNAME_PARMNUM = 1,
        /// <summary><var>wki*_langroup</var></summary>
        WKSTA_LANGROUP_PARMNUM = 2,
        /// <summary><var>wki*_ver_major</var></summary>
        WKSTA_VER_MAJOR_PARMNUM = 4,
        /// <summary><var>wki*_ver_minor</var></summary>
        WKSTA_VER_MINOR_PARMNUM = 5,
        /// <summary><var>wki*_logged_on_users</var></summary>
        WKSTA_LOGGED_ON_USERS_PARMNUM = 6,
        /// <summary><var>wki*_lanroot</var></summary>
        WKSTA_LANROOT_PARMNUM = 7,
        /// <summary><var>wki*_logon_domain</var></summary>
        WKSTA_LOGON_DOMAIN_PARMNUM = 8,
        /// <summary><var>wki*_logon_server</var></summary>
        WKSTA_LOGON_SERVER_PARMNUM = 9,
        /// <summary><var>wki*_charwait</var></summary>
        WKSTA_CHARWAIT_PARMNUM = 10,  // Supported by down-level.
        /// <summary><var>wki*_chartime</var></summary>
        WKSTA_CHARTIME_PARMNUM = 11,  // Supported by down-level.
        /// <summary><var>wki*_charcount</var></summary>
        WKSTA_CHARCOUNT_PARMNUM = 12,  // Supported by down-level.
        /// <summary><var>wki*_keepconn</var></summary>
        WKSTA_KEEPCONN_PARMNUM = 13,
        /// <summary><var>wki*_keepsearch</var></summary>
        WKSTA_KEEPSEARCH_PARMNUM = 14,
        /// <summary><var>wki*_maxcmds</var></summary>
        WKSTA_MAXCMDS_PARMNUM = 15,
        /// <summary><var>wki*_numworkbuf</var></summary>
        WKSTA_NUMWORKBUF_PARMNUM = 16,
        /// <summary><var>wki*_maxwrkcache</var></summary>
        WKSTA_MAXWRKCACHE_PARMNUM = 17,
        /// <summary><var>wki*_sesstimeout</var></summary>
        WKSTA_SESSTIMEOUT_PARMNUM = 18,
        /// <summary><var>wki*_sizerror</var></summary>
        WKSTA_SIZERROR_PARMNUM = 19,
        /// <summary><var>wki*_numalerts</var></summary>
        WKSTA_NUMALERTS_PARMNUM = 20,
        /// <summary><var>wki*_numservices</var></summary>
        WKSTA_NUMSERVICES_PARMNUM = 21,
        /// <summary><var>wki*_numcharbuf</var></summary>
        WKSTA_NUMCHARBUF_PARMNUM = 22,
        /// <summary><var>wki*_sizcharbuf</var></summary>
        WKSTA_SIZCHARBUF_PARMNUM = 23,
        /// <summary><var>wki*_errlogsz</var></summary>
        WKSTA_ERRLOGSZ_PARMNUM = 27,  // Supported by down-level.
        /// <summary><var>wki*_printbuftime</var></summary>
        WKSTA_PRINTBUFTIME_PARMNUM = 28,  // Supported by down-level.
        /// <summary><var>wki*_sizworkbuf</var></summary>
        WKSTA_SIZWORKBUF_PARMNUM = 29,
        /// <summary><var>wki*_mailslots</var></summary>
        WKSTA_MAILSLOTS_PARMNUM = 30,
        /// <summary><var>wki*_numdgrambuf</var></summary>
        WKSTA_NUMDGRAMBUF_PARMNUM = 31,
        /// <summary><var>wki*_wrkheuristics</var></summary>
        WKSTA_WRKHEURISTICS_PARMNUM = 32,  // Supported by down-level.
        /// <summary><var>wki*_maxthreads</var></summary>
        WKSTA_MAXTHREADS_PARMNUM = 33,

        /// <summary><var>wki*_lockquota</var></summary>
        WKSTA_LOCKQUOTA_PARMNUM = 41,
        /// <summary><var>wki*_lockincrement</var></summary>
        WKSTA_LOCKINCREMENT_PARMNUM = 42,
        /// <summary><var>wki*_lockmaximum</var></summary>
        WKSTA_LOCKMAXIMUM_PARMNUM = 43,
        /// <summary><var>wki*_pipeincrement</var></summary>
        WKSTA_PIPEINCREMENT_PARMNUM = 44,
        /// <summary><var>wki*_pipemaximum</var></summary>
        WKSTA_PIPEMAXIMUM_PARMNUM = 45,
        /// <summary><var>wki*_dormantfilelimit</var></summary>
        WKSTA_DORMANTFILELIMIT_PARMNUM = 46,
        /// <summary><var>wki*_cachefiletimeout</var></summary>
        WKSTA_CACHEFILETIMEOUT_PARMNUM = 47,
        /// <summary><var>wki*_useopportunisticlocking</var></summary>
        WKSTA_USEOPPORTUNISTICLOCKING_PARMNUM = 48,
        /// <summary><var>wki*_useunlockbehind</var></summary>
        WKSTA_USEUNLOCKBEHIND_PARMNUM = 49,
        /// <summary><var>wki*_useclosebehind</var></summary>
        WKSTA_USECLOSEBEHIND_PARMNUM = 50,
        /// <summary><var>wki*_buffernamedpipes</var></summary>
        WKSTA_BUFFERNAMEDPIPES_PARMNUM = 51,
        /// <summary><var>wki*_uselockandreadandunlock</var></summary>
        WKSTA_USELOCKANDREADANDUNLOCK_PARMNUM = 52,
        /// <summary><var>wki*_utilizentcaching</var></summary>
        WKSTA_UTILIZENTCACHING_PARMNUM = 53,
        /// <summary><var>wki*_userawread</var></summary>
        WKSTA_USERAWREAD_PARMNUM = 54,
        /// <summary><var>wki*_userawwrite</var></summary>
        WKSTA_USERAWWRITE_PARMNUM = 55,
        /// <summary><var>wki*_usewriterawwithdata</var></summary>
        WKSTA_USEWRITERAWWITHDATA_PARMNUM = 56,
        /// <summary><var>wki*_useencryption</var></summary>
        WKSTA_USEENCRYPTION_PARMNUM = 57,
        /// <summary><var>wki*_buffileswithdenywrite</var></summary>
        WKSTA_BUFFILESWITHDENYWRITE_PARMNUM = 58,
        /// <summary><var>wki*_bufferreadonlyfiles</var></summary>
        WKSTA_BUFFERREADONLYFILES_PARMNUM = 59,
        /// <summary><var>wki*_forcecorecreatemode</var></summary>
        WKSTA_FORCECORECREATEMODE_PARMNUM = 60,
        /// <summary><var>wki*_use512bytesmaxtransfer</var></summary>
        WKSTA_USE512BYTESMAXTRANSFER_PARMNUM = 61,
        /// <summary><var>wki*_readaheadthruput</var></summary>
        WKSTA_READAHEADTHRUPUT_PARMNUM = 62,
    }
}