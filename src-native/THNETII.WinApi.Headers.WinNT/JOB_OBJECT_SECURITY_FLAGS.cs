using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum JOB_OBJECT_SECURITY_FLAGS : int
    {
        /// <summary>
        /// Prevents any process in the job from using a token that specifies the local administrators group. 
        /// </summary>
        JOB_OBJECT_SECURITY_NO_ADMIN = WinNTConstants.JOB_OBJECT_SECURITY_NO_ADMIN,
        /// <summary>
        /// Prevents any process in the job from using a token that was not created with the <see cref="CreateRestrictedToken"/> function. 
        /// </summary>
        JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = WinNTConstants.JOB_OBJECT_SECURITY_RESTRICTED_TOKEN,
        /// <summary>
        /// Forces processes in the job to run under a specific token. Requires a token handle in the <see cref="JOBOBJECT_SECURITY_LIMIT_INFORMATION.JobToken"/> member. 
        /// </summary>
        JOB_OBJECT_SECURITY_ONLY_TOKEN = WinNTConstants.JOB_OBJECT_SECURITY_ONLY_TOKEN,
        /// <summary>
        /// Applies a filter to the token when a process impersonates
        /// a client. Requires at least one of the following members
        /// to be set: <see cref="JOBOBJECT_SECURITY_LIMIT_INFORMATION.SidsToDisable"/>, <see cref="JOBOBJECT_SECURITY_LIMIT_INFORMATION.PrivilegesToDelete"/>, or
        /// <see cref="JOBOBJECT_SECURITY_LIMIT_INFORMATION.RestrictedSids"/>. 
        /// </summary>
        JOB_OBJECT_SECURITY_FILTER_TOKENS = WinNTConstants.JOB_OBJECT_SECURITY_FILTER_TOKENS,

        JOB_OBJECT_SECURITY_VALID_FLAGS = WinNTConstants.JOB_OBJECT_SECURITY_VALID_FLAGS,
    }
}
