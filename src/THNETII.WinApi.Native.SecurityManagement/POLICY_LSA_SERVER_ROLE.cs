namespace Microsoft.Win32.WinApi.SecurityIdentity.SecurityManagement
{
    /// <summary>
    /// The <see cref="POLICY_LSA_SERVER_ROLE"/> enumeration type defines values that indicate the role of an LSA server. The <see cref="LsaQueryInformationPolicy"/> and <see cref="LsaSetInformationPolicy"/> functions use this enumeration type when their <em>InformationClass</em> parameters are set to <see cref="PolicyLsaServerRoleInformation"/>.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms721906.aspx">POLICY_LSA_SERVER_ROLE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="LsaQueryInformationPolicy"/>
    /// <seealso cref="LsaSetInformationPolicy"/>
    /// <seealso cref="POLICY_LSA_SERVER_ROLE_INFO"/>
    public enum POLICY_LSA_SERVER_ROLE
    {
        /// <summary>Indicates a backup LSA server.</summary>
        PolicyServerRoleBackup = 2,
        /// <summary>Indicates a primary LSA server, a workstation, or a standalone computer.</summary>
        PolicyServerRolePrimary
    }
}
