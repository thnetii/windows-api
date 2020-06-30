namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15524
    /// <summary>
    /// Indicates the OEM's preferred power management profile. These values are read from the Preferred_PM_Profile field of the Fixed ACPI Description Table (FADT). These values are returned by the <see cref="PowerDeterminePlatformRole"/> or <see cref="PowerDeterminePlatformRoleEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-power_platform_role">POWER_PLATFORM_ROLE Enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/f78cd97f-586f-4091-ab4a-5f109a0f679a">Power Management Enumeration Types</seealso>
    /// <seealso cref="PowerDeterminePlatformRole"/>
    public enum POWER_PLATFORM_ROLE
    {
        /// <summary>The OEM did not specify a specific role.</summary>
        PlatformRoleUnspecified = 0,
        /// <summary>The OEM specified a desktop role.</summary>
        PlatformRoleDesktop,
        /// <summary>The OEM specified a mobile role (for example, a laptop).</summary>
        PlatformRoleMobile,
        /// <summary>The OEM specified a workstation role.</summary>
        PlatformRoleWorkstation,
        /// <summary>The OEM specified an enterprise server role.</summary>
        PlatformRoleEnterpriseServer,
        /// <summary>The OEM specified a single office/home office (SOHO) server role.</summary>
        PlatformRoleSOHOServer,
        /// <summary>The OEM specified an appliance PC role.</summary>
        PlatformRoleAppliancePC,
        /// <summary>The OEM specified a performance server role.</summary>
        PlatformRolePerformanceServer, // v1 last supported
        /// <summary>
        /// The OEM specified a tablet form factor role.
        /// <para>
        /// <strong>Windows 7, Windows Server 2008 R2, Windows Vista or Windows Server 2008:</strong>
        /// In version 1 of this enumeration, this value is equivalent to <see cref="PlatformRoleMaximum"/>. This value is supported in version 2 of this enumeration starting with Windows 8 and Windows Server 2012.
        /// </para>
        /// </summary>
        PlatformRoleSlate,             // v2 last supported
        /// <summary>Values equal to or greater than this value indicate an out of range value.</summary>
        PlatformRoleMaximum
    }
}
