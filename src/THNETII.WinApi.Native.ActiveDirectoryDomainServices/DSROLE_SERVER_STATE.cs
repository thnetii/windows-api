namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DSROLE_SERVER_STATE"/> enumeration is used with the <see cref="DSROLE_UPGRADE_STATUS_INFO"/> structure to indicate the role of a server.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_dsrole_server_state">_DSROLE_SERVER_STATE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DSROLE_UPGRADE_STATUS_INFO"/>
    public enum DSROLE_SERVER_STATE
    {
        /// <summary>
        /// The server role is unknown.
        /// </summary>
        DsRoleServerUnknown = 0,
        /// <summary>
        /// The server was, or is, a primary domain controller.
        /// </summary>
        DsRoleServerPrimary,
        /// <summary>
        /// The server was, or is, a backup domain controller.
        /// </summary>
        DsRoleServerBackup
    }
}
