using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.ACCESS_MASK;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// <para>Privileges determine the type of system operations that a user account can perform. An administrator assigns privileges to user and group accounts. Each user's privileges include those granted to the user and to the groups to which the user belongs.</para>
    /// <para>The functions that get and adjust the privileges in an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em> use the <em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_locally_unique_identifier_gly">locally unique identifier</a></em> (LUID) type to identify privileges. Use the <see cref="LookupPrivilegeValue"/> function to determine the LUID on the local system that corresponds to a privilege constant. Use the <see cref="LookupPrivilegeName"/> function to convert a LUID to its corresponding string constant.</para>
    /// <para>The operating system represents a privilege by using the string that follows "User Right" in the Summary documentation text of the priviliges defined in within this type. The operating system displays the user right strings in the <strong>Policy</strong> column of the <strong>User Rights Assignment</strong> node of the Local Security Settings Microsoft Management Console (MMC) snap-in.</para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb530716.aspx">Privilege Constants</a></para>
    /// </remarks>
    public static class PrivilegeConstants
    {
        /// <summary>
        /// <para>Required to assign the <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_primary_token_gly">primary token</a></em> of a process.</para>
        /// <para>User Right: Replace a process-level token.</para>
        /// </summary>
        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";
        /// <summary>
        /// <para>Required to generate audit-log entries.Give this privilege to secure servers.</para>
        /// <para>User Right: Generate security audits.</para>
        /// </summary>
        public const string SE_AUDIT_NAME = "SeAuditPrivilege";
        /// <summary>
        /// <para>
        /// Required to perform backup operations.This privilege causes the system to grant all read access control to any file, regardless of the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_list_gly">access control list</a></em> (ACL) specified for the file.Any access request other than read is still evaluated with the ACL. This privilege is required by the <see cref="RegSaveKey"/> and <see cref="RegSaveKeyEx"/> functions. The following access rights are granted if this privilege is held:
        /// <list type="bullet">
        /// <item><see cref="READ_CONTROL"/></item>
        /// <item><see cref="ACCESS_SYSTEM_SECURITY"/></item>
        /// <item><see cref="FILE_GENERIC_READ"/></item>
        /// <item><see cref="FILE_TRAVERSE"/></item>
        /// </list>
        /// </para>
        /// <para>User Right: Back up files and directories.</para>
        /// </summary>
        public const string SE_BACKUP_NAME = "SeBackupPrivilege";
        /// <summary>
        /// <para>Required to receive notifications of changes to files or directories.This privilege also causes the system to skip all traversal access checks.It is enabled by default for all users.</para>
        /// <para>User Right: Bypass traverse checking.</para>
        /// </summary>
        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";
        /// <summary>
        /// <para>Required to create named file mapping objects in the global namespace during Terminal Services sessions.This privilege is enabled by default for administrators, services, and the local system account.</para>
        /// <para>User Right: Create global objects.</para>
        /// </summary>
        public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";
        /// <summary>
        /// <para>Required to create a paging file.</para>
        /// <para>User Right: Create a pagefile.</para>
        /// </summary>
        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";
        /// <summary>
        /// <para>Required to create a permanent object.</para>
        /// <para>User Right: Create permanent shared objects.</para>
        /// </summary>
        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";
        /// <summary>
        /// <para>Required to create a symbolic link.</para>
        /// <para>User Right: Create symbolic links.</para>
        /// </summary>
        public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";
        /// <summary>
        /// <para>Required to create a <em><a href="https://msdn.microsoft.com/en-us/library/ms721603.aspx#_security_primary_token_gly">primary token</a></em>.</para>
        /// <para>User Right: Create a token object.</para>
        /// <para>You cannot add this privilege to a user account with the "Create a token object" policy.Additionally, you cannot add this privilege to an owned process using Windows APIs.</para>
        /// <para><strong>Windows Server2003 and WindowsXP with SP1 and earlier:</strong> Windows APIs can add this privilege to an owned process.</para>
        /// </summary>
        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";
        /// <summary>
        /// <para>Required to debug and adjust the memory of a process owned by another account.</para>
        /// <para>User Right: Debug programs.</para>
        /// </summary>
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        /// <summary>
        /// <para>Required to mark user and computer accounts as trusted for delegation.</para>
        /// <para>User Right: Enable computer and user accounts to be trusted for delegation.</para>
        /// </summary>
        public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";
        /// <summary>
        /// <para>Required to impersonate.</para>
        /// <para>User Right: Impersonate a client after authentication.</para>
        /// </summary>
        public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";
        /// <summary>
        /// <para>Required to increase the base priority of a process.</para>
        /// <para>User Right: Increase scheduling priority.</para>
        /// </summary>
        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";
        /// <summary>
        /// <para>Required to increase the quota assigned to a process.</para>
        /// <para>User Right: Adjust memory quotas for a process.</para>
        /// </summary>
        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";
        /// <summary>
        /// <para>Required to allocate more memory for applications that run in the context of users.</para>
        /// <para>User Right: Increase a process working set.</para>
        /// </summary>
        public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";
        /// <summary>
        /// <para>Required to load or unload a device driver.</para>
        /// <para>User Right: Load and unload device drivers.</para>
        /// </summary>
        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";
        /// <summary>
        /// <para>Required to lock physical pages in memory.</para>
        /// <para>User Right: Lock pages in memory.</para>
        /// </summary>
        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";
        /// <summary>
        /// <para>Required to create a computer account.</para>
        /// <para>User Right: Add workstations to domain.</para>
        /// </summary>
        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";
        /// <summary>
        /// <para>Required to enable volume management privileges.</para>
        /// <para>User Right: Manage the files on a volume.</para>
        /// </summary>
        public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";
        /// <summary>
        /// <para>Required to gather profiling information for a single process.</para>
        /// <para>User Right: Profile single process.</para>
        /// </summary>
        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";
        /// <summary>
        /// <para>Required to modify the mandatory integrity level of an object.</para>
        /// <para>User Right: Modify an object label.</para>
        /// </summary>
        public const string SE_RELABEL_NAME = "SeRelabelPrivilege";
        /// <summary>
        /// <para>Required to shut down a system using a network request.</para>
        /// <para>User Right: Force shutdown from a remote system.</para>
        /// </summary>
        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";
        /// <summary>
        /// <para>
        /// Required to perform restore operations. This privilege causes the system to grant all write access control to any file, regardless of the ACL specified for the file. Any access request other than write is still evaluated with the ACL. Additionally, this privilege enables you to set any valid user or group SID as the owner of a file. This privilege is required by the <see cref="RegLoadKey"/> function. The following access rights are granted if this privilege is held:
        /// <list type="bullet">
        /// <item><see cref="WRITE_DAC"/></item>
        /// <item><see cref="WRITE_OWNER"/></item>
        /// <item><see cref="ACCESS_SYSTEM_SECURITY"/></item>
        /// <item><see cref="FILE_GENERIC_WRITE"/></item>
        /// <item><see cref="FILE_ADD_FILE"/></item>
        /// <item><see cref="FILE_ADD_SUBDIRECTORY"/></item>
        /// <item><see cref="DELETE"/></item>
        /// </list>
        /// </para>
        /// <para>User Right: Restore files and directories.</para>
        /// </summary>
        public const string SE_RESTORE_NAME = "SeRestorePrivilege";
        /// <summary>
        /// <para>Required to perform a number of security - related functions, such as controlling and viewing audit messages. This privilege identifies its holder as a security operator.</para>
        /// <para>User Right: Manage auditing and security log.</para>
        /// </summary>
        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";
        /// <summary>
        /// <para>Required to shut down a local system.</para>
        /// <para>User Right: Shut down the system.</para>
        /// </summary>
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        /// <summary>
        /// <para>Required for a domain controller to use the <em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_lightweight_directory_access_protocol_gly">Lightweight Directory Access Protocol</a></em> directory synchronization services. This privilege enables the holder to read all objects and properties in the directory, regardless of the protection on the objects and properties.By default, it is assigned to the Administrator and LocalSystem accounts on domain controllers.</para>
        /// <para>User Right: Synchronize directory service data.</para>
        /// </summary>
        public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";
        /// <summary>
        /// <para>Required to modify the nonvolatile RAM of systems that use this type of memory to store configuration information.</para>
        /// <para>User Right: Modify firmware environment values.</para>
        /// </summary>
        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";
        /// <summary>
        /// <para>Required to gather profiling information for the entire system.</para>
        /// <para>User Right: Profile system performance.</para>
        /// </summary>
        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";
        /// <summary>
        /// <para>Required to modify the system time.</para>
        /// <para>User Right: Change the system time.</para>
        /// </summary>
        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
        /// <summary>
        /// <para>Required to take ownership of an object without being granted discretionary access.This privilege allows the owner value to be set only to those values that the holder may legitimately assign as the owner of an object.</para>
        /// <para>User Right: Take ownership of files or other objects.</para>
        /// </summary>
        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";
        /// <summary>
        /// <para>This privilege identifies its holder as part of the trusted computer base.Some trusted protected subsystems are granted this privilege.</para>
        /// <para>User Right: Act as part of the operating system.</para>
        /// </summary>
        public const string SE_TCB_NAME = "SeTcbPrivilege";
        /// <summary>
        /// <para>Required to adjust the time zone associated with the computer's internal clock.</para>
        /// <para>User Right: Change the time zone.</para>
        /// </summary>
        public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";
        /// <summary>
        /// <para>Required to access Credential Manager as a trusted caller.</para>
        /// <para>User Right: Access Credential Manager as a trusted caller.</para>
        /// </summary>
        public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";
        /// <summary>
        /// <para>Required to undock a laptop.</para>
        /// <para>User Right: Remove computer from docking station.</para>
        /// </summary>
        public const string SE_UNDOCK_NAME = "SeUndockPrivilege";
        /// <summary>
        /// <para>Required to read unsolicited input from a <em><a href="https://msdn.microsoft.com/en-us/library/ms721627.aspx#_security_terminal_gly">terminal</a></em> device.</para>
        /// <para>User Right: Not applicable.</para>
        /// </summary>
        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";
    }
}
