namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DSROLE_MACHINE_ROLE"/> enumeration is used with the <see cref="DSROLE_PRIMARY_DOMAIN_INFO_BASIC.MachineRole"/> member of the <see cref="DSROLE_PRIMARY_DOMAIN_INFO_BASIC"/> structure to specify the computer role.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_dsrole_machine_role">_DSROLE_MACHINE_ROLE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DSROLE_PRIMARY_DOMAIN_INFO_BASIC"/>
    public enum DSROLE_MACHINE_ROLE
    {
        /// <summary>
        /// The computer is a workstation that is not a member of a domain.
        /// </summary>
        DsRole_RoleStandaloneWorkstation,
        /// <summary>
        /// The computer is a workstation that is a member of a domain.
        /// </summary>
        DsRole_RoleMemberWorkstation,
        /// <summary>
        /// The computer is a server that is not a member of a domain.
        /// </summary>
        DsRole_RoleStandaloneServer,
        /// <summary>
        /// The computer is a server that is a member of a domain.
        /// </summary>
        DsRole_RoleMemberServer,
        /// <summary>
        /// The computer is a backup domain controller.
        /// </summary>
        DsRole_RoleBackupDomainController,
        /// <summary>
        /// The computer is a primary domain controller.
        /// </summary>
        DsRole_RolePrimaryDomainController
    }
}
