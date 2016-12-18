namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// <para>Account rights determine the type of logon that a user account can perform. An administrator assigns account rights to user and group accounts. Each user's account rights include those granted to the user and to the groups to which the user belongs.</para>
    /// <para>A system administrator can use the <a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_local_security_authority_gly">Local Security Authority</a> (LSA) functions to work with account rights. The <see cref="LsaAddAccountRights"/> and <see cref="LsaRemoveAccountRights"/> functions add or remove account rights from an account. The <see cref="LsaEnumerateAccountRights"/> function enumerates the account rights held by a specified account. The <see cref="LsaEnumerateAccountsWithUserRight"/> function enumerates the accounts that hold a specified account right.</para>
    /// <para>The account right constants are used to control the logon ability of an account. The <see cref="LogonUser"/> or <see cref="LsaLogonUser"/> functions fail if the account being logged on does not have the account rights required for the type of logon being performed.</para>
    /// </summary>
    /// <remarks>
    /// <para>The <strong>SE_DENY</strong> rights override the corresponding account rights. An administrator can assign an <strong>SE_DENY</strong> right to an account to override any logon rights that an account might have as a result of a group membership. For example, you could assign the <see cref="SE_NETWORK_LOGON_NAME"/> right to Everyone but assign the <see cref="SE_DENY_NETWORK_LOGON_NAME"/> right to Administrators to prevent remote administration of computers.</para>
    /// <para>All of the LSA functions mentioned in the introduction above support both account rights and privileges. Unlike privileges, however, account rights are not supported by the <see cref="LookupPrivilegeValue"/> and <see cref="LookupPrivilegeName"/> functions. The <see cref="GetTokenInformation"/> function will obtain information on account rights if <see cref="TokenGroups"/>, and not <see cref="TokenPrivileges"/>, is specified as the value of the <em>TokenInformationClass</em> parameter.</para>
    /// <para>The account right constants are defined as strings in Ntsecapi.h. For example, the <see cref="SE_INTERACTIVE_LOGON_NAME"/> constant is defined as <c>"SeInteractiveLogonRight"</c>.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb545671.aspx">Account Rights Constants</a></para>
    /// </remarks>
    public static class AccountRightsConstants
    {
        /// <summary>Required for an account to log on using the batch logon type.</summary>
        public const string SE_BATCH_LOGON_NAME = "SeBatchLogonRight";
        /// <summary>Explicitly denies an account the right to log on using the batch logon type.</summary>
        public const string SE_DENY_BATCH_LOGON_NAME = "SeDenyBatchLogonRight";
        /// <summary>Explicitly denies an account the right to log on using the interactive logon type.</summary>
        public const string SE_DENY_INTERACTIVE_LOGON_NAME = "SeDenyInteractiveLogonRight";
        /// <summary>Explicitly denies an account the right to log on using the network logon type.</summary>
        public const string SE_DENY_NETWORK_LOGON_NAME = "SeDenyNetworkLogonRight";
        /// <summary>Explicitly denies an account the right to log on remotely using the interactive logon type.</summary>
        public const string SE_DENY_REMOTE_INTERACTIVE_LOGON_NAME = "SeDenyRemoteInteractiveLogonRight";
        /// <summary>Explicitly denies an account the right to log on using the service logon type.</summary>
        public const string SE_DENY_SERVICE_LOGON_NAME = "SeDenyServiceLogonRight";
        /// <summary>Required for an account to log on using the interactive logon type.</summary>
        public const string SE_INTERACTIVE_LOGON_NAME = "SeInteractiveLogonRight";
        /// <summary>Required for an account to log on using the network logon type.</summary>
        public const string SE_NETWORK_LOGON_NAME = "SeNetworkLogonRight";
        /// <summary>Required for an account to log on remotely using the interactive logon type.</summary>
        public const string SE_REMOTE_INTERACTIVE_LOGON_NAME = "SeRemoteInteractiveLogonRight";
        /// <summary>Required for an account to log on using the service logon type.</summary>
        public const string SE_SERVICE_LOGON_NAME = "SeServiceLogonRight";
    }
}
