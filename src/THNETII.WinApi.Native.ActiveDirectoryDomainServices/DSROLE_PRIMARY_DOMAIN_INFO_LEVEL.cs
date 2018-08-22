namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DSROLE_PRIMARY_DOMAIN_INFO_LEVEL"/> enumeration is used with the <see cref="DsRoleGetPrimaryDomainInformation"/> function to specify the type of data to retrieve.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_dsrole_primary_domain_info_level">_DSROLE_PRIMARY_DOMAIN_INFO_LEVEL Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DSROLE_OPERATION_STATE_INFO"/>
    /// <seealso cref="DSROLE_PRIMARY_DOMAIN_INFO_BASIC"/>
    /// <seealso cref="DSROLE_UPGRADE_STATUS_INFO"/>
    /// <seealso cref="DsRoleGetPrimaryDomainInformation"/>
    public enum DSROLE_PRIMARY_DOMAIN_INFO_LEVEL
    {
        /// <summary>
        /// The <see cref="DsRoleGetPrimaryDomainInformation"/> function retrieves data from a <see cref="DSROLE_PRIMARY_DOMAIN_INFO_BASIC"/> structure.
        /// </summary>
        DsRolePrimaryDomainInfoBasic = 1,
        /// <summary>
        /// The <see cref="DsRoleGetPrimaryDomainInformation"/> function retrieves from a <see cref="DSROLE_UPGRADE_STATUS_INFO"/> structure.
        /// </summary>
        DsRoleUpgradeStatus,
        /// <summary>
        /// The <see cref="DsRoleGetPrimaryDomainInformation"/> function retrieves data from a <see cref="DSROLE_OPERATION_STATE_INFO"/> structure.
        /// </summary>
        DsRoleOperationState
    }
}
