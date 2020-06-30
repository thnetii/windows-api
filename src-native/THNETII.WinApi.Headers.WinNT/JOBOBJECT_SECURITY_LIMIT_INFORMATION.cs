using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11746
    /// <summary>
    /// Contains the security limitations for a job object.
    /// </summary>
    /// <remarks>
    /// <para>After security limitations are placed on processes in a job, they cannot be revoked.</para>
    /// <para>
    /// Starting with Windows Vista, you must set security limitations individually for each process
    /// associated with a job object, rather than setting them for the job object by using
    /// <see cref="SetInformationJobObject"/>. For information, see <a href="https://msdn.microsoft.com/508a17c4-88cd-431a-a102-00180a7f7ab5">Process Security and Access Rights</a>.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_security_limit_information">JOBOBJECT_SECURITY_LIMIT_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="CreateRestrictedToken"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    [Obsolete("JOBOBJECT_SECURITY_LIMIT_INFORMATION is available for use in the operating systems starting with Windows XP and Windows Server 2003. Support for this structure was removed starting with Windows Vista. For information, see https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_security_limit_information#remarks.")]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
    {
        /// <summary>
        /// The security limitations for the job.
        /// </summary>
        public JOB_OBJECT_SECURITY_FLAGS SecurityLimitFlags;
        /// <summary>
        /// <para>A handle to the primary token that represents a user. The handle must have <see cref="TOKEN_ASSIGN_PRIMARY"/> access.</para>
        /// <para>If the token was created with <see cref="CreateRestrictedToken"/>, all processes in the job are limited to that token or a further restricted token. Otherwise, the caller must have the <see cref="SE_ASSIGNPRIMARYTOKEN_NAME"/> privilege.</para>
        /// </summary>
        public IntPtr JobToken;
        /// <summary>
        /// <para>A pointer to a <see cref="TOKEN_GROUPS"/> structure that specifies the SIDs to disable for access checking, if <see cref="SecurityLimitFlags"/> is <see cref="JOB_OBJECT_SECURITY_FLAGS.JOB_OBJECT_SECURITY_FILTER_TOKENS"/>.</para>
        /// <para>This member can be <see langword="null"/> if you do not want to disable any SIDs.</para>
        /// </summary>
        public TOKEN_GROUPS* SidsToDisable;
        /// <summary>
        /// <para>A pointer to a <see cref="TOKEN_PRIVILEGES"/> structure that specifies the privileges to delete from the token, if <see cref="SecurityLimitFlags"/> is <see cref="JOB_OBJECT_SECURITY_FLAGS.JOB_OBJECT_SECURITY_FILTER_TOKENS"/>.</para>
        /// <para>This member can be <see langword="null"/> if you do not want to delete any privileges.</para>
        /// </summary>
        public TOKEN_PRIVILEGES* PrivilegesToDelete;
        /// <summary>
        /// <para>A pointer to a <see cref="TOKEN_GROUPS"/> structure that specifies the deny-only SIDs that will be added to the access token, if <see cref="SecurityLimitFlags"/> is <see cref="JOB_OBJECT_SECURITY_FLAGS.JOB_OBJECT_SECURITY_FILTER_TOKENS"/>.</para>
        /// <para>This member can be <see langword="null"/> if you do not want to specify any deny-only SIDs.</para>
        /// </summary>
        public TOKEN_GROUPS* RestrictedSids;
    }
}
