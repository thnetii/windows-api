using System;

namespace THNETII.WinApi.Native.AccCtrl
{
    [Flags]
    public enum ACCESS_FLAGS : int
    {
        /// <summary>
        /// The rights are allowed.
        /// </summary>
        ACTRL_ACCESS_ALLOWED = AccCtrlConstants.ACTRL_ACCESS_ALLOWED,
        /// <summary>
        /// The rights are denied.
        /// </summary>
        ACTRL_ACCESS_DENIED = AccCtrlConstants.ACTRL_ACCESS_DENIED,
        /// <summary>
        /// The system generates audit messages for failed attempts to use the rights.
        /// </summary>
        ACTRL_AUDIT_SUCCESS = AccCtrlConstants.ACTRL_AUDIT_SUCCESS,
        /// <summary>
        /// The system generates audit messages for successful attempts to use the rights.
        /// </summary>
        ACTRL_AUDIT_FAILURE = AccCtrlConstants.ACTRL_AUDIT_FAILURE,
    }
}
