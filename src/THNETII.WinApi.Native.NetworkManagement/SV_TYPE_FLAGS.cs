using System;

using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// Bit-mapped values for svX_type fields. X = 1, 2 or 3.
    /// </summary>
    [Flags]
    public enum SV_TYPE_FLAGS : uint
    {
        /// <summary>A workstation.</summary>
        SV_TYPE_WORKSTATION = 0x00000001,
        /// <summary>A server.</summary>
        SV_TYPE_SERVER = 0x00000002,
        /// <summary>A server running with Microsoft SQL Server.</summary>
        SV_TYPE_SQLSERVER = 0x00000004,
        /// <summary>A primary domain controller.</summary>
        SV_TYPE_DOMAIN_CTRL = 0x00000008,
        /// <summary>A backup domain controller.</summary>
        SV_TYPE_DOMAIN_BAKCTRL = 0x00000010,
        /// <summary>A server running the Timesource service.</summary>
        SV_TYPE_TIME_SOURCE = 0x00000020,
        /// <summary>A server running the Apple Filing Protocol (AFP) file service.</summary>
        SV_TYPE_AFP = 0x00000040,
        /// <summary>A Novell server.</summary>
        SV_TYPE_NOVELL = 0x00000080,
        /// <summary>A LAN Manager 2.x domain member.</summary>
        SV_TYPE_DOMAIN_MEMBER = 0x00000100,
        /// <summary>A server that shares a print queue.</summary>
        SV_TYPE_PRINTQ_SERVER = 0x00000200,
        /// <summary>A server that runs a dial-in service.</summary>
        SV_TYPE_DIALIN_SERVER = 0x00000400,
        /// <summary>A Xenix server.</summary>
        SV_TYPE_XENIX_SERVER = 0x00000800,
        /// <summary>A Unix server.</summary>
        SV_TYPE_SERVER_UNIX = SV_TYPE_XENIX_SERVER,
        /// <summary>A workstation or server.</summary>
        SV_TYPE_NT = 0x00001000,
        /// <summary>A computer that runs Windows for Workgroups.</summary>
        SV_TYPE_WFW = 0x00002000,
        /// <summary>A server that runs the Microsoft File and Print for NetWare service.</summary>
        SV_TYPE_SERVER_MFPN = 0x00004000,
        /// <summary>Any server that is not a domain controller.</summary>
        SV_TYPE_SERVER_NT = 0x00008000,
        /// <summary>A computer that can run the browser service.</summary>
        SV_TYPE_POTENTIAL_BROWSER = 0x00010000,
        /// <summary>A server running a browser service as backup.</summary>
        SV_TYPE_BACKUP_BROWSER = 0x00020000,
        /// <summary>A server running the master browser service.</summary>
        SV_TYPE_MASTER_BROWSER = 0x00040000,
        /// <summary>A server running the domain master browser.</summary>
        SV_TYPE_DOMAIN_MASTER = 0x00080000,
        /// <summary>A computer that runs OSF.</summary>
        SV_TYPE_SERVER_OSF = 0x00100000,
        /// <summary>A computer that runs VMS.</summary>
        SV_TYPE_SERVER_VMS = 0x00200000,
        /// <summary>A computer that runs Windows.</summary>
        SV_TYPE_WINDOWS = 0x00400000,  /* Windows95 and above */
        /// <summary>A server that is the root of a DFS tree.</summary>
        SV_TYPE_DFS = 0x00800000,  /* Root of a DFS tree */
        /// <summary>A server cluster available in the domain.</summary>
        SV_TYPE_CLUSTER_NT = 0x01000000,  /* NT Cluster */
        /// <summary>A server that runs the Terminal Server service.</summary>
        SV_TYPE_TERMINALSERVER = 0x02000000,  /* Terminal Server(Hydra) */
        /// <summary>Cluster virtual servers available in the domain.</summary>
        SV_TYPE_CLUSTER_VS_NT = 0x04000000,  /* NT Cluster Virtual Server Name */
        /// <summary>A server that runs the DCE Directory and Security Services or equivalent.</summary>
        SV_TYPE_DCE = 0x10000000,  /* IBM DSS (Directory and Security Services) or equivalent */
        /// <summary>A server that is returned by an alternate transport.</summary>
        SV_TYPE_ALTERNATE_XPORT = 0x20000000,  /* return list for alternate transport */
        /// <summary>A server that is maintained by the browser.</summary>
        SV_TYPE_LOCAL_LIST_ONLY = 0x40000000,  /* Return local list only */
        /// <summary>A primary domain.</summary>
        SV_TYPE_DOMAIN_ENUM = 0x80000000,
        /// <summary>Can be used to check for all server types when used with the <see cref="NetServerEnum"/> function. </summary>
        SV_TYPE_ALL = 0xFFFFFFFF,  /* handy for NetServerEnum2 */

    }
}