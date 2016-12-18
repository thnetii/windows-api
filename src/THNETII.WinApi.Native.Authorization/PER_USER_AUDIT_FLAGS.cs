using System;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// Valid bits for Per user policy mask.
    /// </summary>
    [Flags]
    public enum PER_USER_AUDIT_FLAGS : int
    {
        /// <summary>Do not change auditing options for the specified event type.</summary>
        PER_USER_POLICY_UNCHANGED = (0x00),
        /// <summary>Audit successful occurrences of the specified event type.</summary>
        PER_USER_AUDIT_SUCCESS_INCLUDE = (0x01),
        /// <summary>Do not audit successful occurrences of the specified event type.</summary>
        PER_USER_AUDIT_SUCCESS_EXCLUDE = (0x02),
        /// <summary>Audit failed attempts to cause the specified event type.</summary>
        PER_USER_AUDIT_FAILURE_INCLUDE = (0x04),
        /// <summary>Do not audit failed attempts to cause the specified event type.</summary>
        PER_USER_AUDIT_FAILURE_EXCLUDE = (0x08),
        /// <summary>Do not audit the specified event type.</summary>
        PER_USER_AUDIT_NONE = (0x10),

        VALID_PER_USER_AUDIT_POLICY_FLAG = (PER_USER_AUDIT_SUCCESS_INCLUDE | PER_USER_AUDIT_SUCCESS_EXCLUDE | PER_USER_AUDIT_FAILURE_INCLUDE | PER_USER_AUDIT_FAILURE_EXCLUDE | PER_USER_AUDIT_NONE)
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}