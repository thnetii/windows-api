using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum VER_SUITE_FLAGS : int
    {
        /// <summary>Microsoft Small Business Server was once installed on the system, but may have been upgraded to another version of Windows.</summary>
        VER_SUITE_SMALLBUSINESS = WinNTConstants.VER_SUITE_SMALLBUSINESS,
        /// <summary>Windows Server 2008 Enterprise, Windows Server 2003, Enterprise Edition, or Windows 2000 Advanced Server is installed.</summary>
        VER_SUITE_ENTERPRISE = WinNTConstants.VER_SUITE_ENTERPRISE,
        /// <summary>Microsoft BackOffice components are installed.</summary>
        VER_SUITE_BACKOFFICE = WinNTConstants.VER_SUITE_BACKOFFICE,
        VER_SUITE_COMMUNICATIONS = WinNTConstants.VER_SUITE_COMMUNICATIONS,
        /// <summary>
        /// Terminal Services is installed. This value is always set.
        /// <para>If <see cref="VER_SUITE_TERMINAL"/> is set but <see cref="VER_SUITE_SINGLEUSERTS"/> is not set, the system is running in application server mode.</para>
        /// </summary>
        VER_SUITE_TERMINAL = WinNTConstants.VER_SUITE_TERMINAL,
        /// <summary>Microsoft Small Business Server is installed with the restrictive client license in force.</summary>
        VER_SUITE_SMALLBUSINESS_RESTRICTED = WinNTConstants.VER_SUITE_SMALLBUSINESS_RESTRICTED,
        /// <summary>Windows XP Embedded is installed.</summary>
        VER_SUITE_EMBEDDEDNT = WinNTConstants.VER_SUITE_EMBEDDEDNT,
        /// <summary>Windows Server 2008 Datacenter, Windows Server 2003, Datacenter Edition, or Windows 2000 Datacenter Server is installed.</summary>
        VER_SUITE_DATACENTER = WinNTConstants.VER_SUITE_DATACENTER,
        /// <summary>Remote Desktop is supported, but only one interactive session is supported. This value is set unless the system is running in application server mode.</summary>
        VER_SUITE_SINGLEUSERTS = WinNTConstants.VER_SUITE_SINGLEUSERTS,
        /// <summary>Windows Vista Home Premium, Windows Vista Home Basic, or Windows XP Home Edition is installed.</summary>
        VER_SUITE_PERSONAL = WinNTConstants.VER_SUITE_PERSONAL,
        /// <summary>Windows Server 2003, Web Edition is installed.</summary>
        VER_SUITE_BLADE = WinNTConstants.VER_SUITE_BLADE,
        VER_SUITE_EMBEDDED_RESTRICTED = WinNTConstants.VER_SUITE_EMBEDDED_RESTRICTED,
        VER_SUITE_SECURITY_APPLIANCE = WinNTConstants.VER_SUITE_SECURITY_APPLIANCE,
        /// <summary>Windows Storage Server 2003 R2 or Windows Storage Server 2003is installed.</summary>
        VER_SUITE_STORAGE_SERVER = WinNTConstants.VER_SUITE_STORAGE_SERVER,
        /// <summary>Windows Server 2003, Compute Cluster Edition is installed.</summary>
        VER_SUITE_COMPUTE_SERVER = WinNTConstants.VER_SUITE_COMPUTE_SERVER,
        /// <summary>Windows Home Server is installed. </summary>
        VER_SUITE_WH_SERVER = WinNTConstants.VER_SUITE_WH_SERVER,
        /// <summary>AppServer mode is enabled.</summary>
        VER_SUITE_MULTIUSERTS = WinNTConstants.VER_SUITE_MULTIUSERTS,
    }
}
