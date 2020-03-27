using System;
using System.ComponentModel;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum CLAIM_SECURITY_ATTRIBUTE_FLAGS
    {
        /// <summary>
        /// This attribute is ignored by the operating system. This claim security attribute is not inherited across processes.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE,
        /// <summary>
        /// The value of the claim security attribute is case sensitive. This flag is valid for values that contain string types.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE,
        /// <summary>
        /// The claim security attribute is considered only for deny <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access control entries</a> (ACEs).
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY,
        /// <summary>
        /// The claim security attribute is disabled by default.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT,
        /// <summary>
        /// The claim security attribute is disabled and will not be applied by the <see cref="AccessCheck"/> function.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_DISABLED = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_DISABLED,
        /// <summary>
        /// The claim security attribute is mandatory.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_MANDATORY = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_MANDATORY,
        [EditorBrowsable(EditorBrowsableState.Never)]
        CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS
    }
}
