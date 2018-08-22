using System;
using System.Collections.Generic;
using System.Text;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DSROLE_OPERATION_STATE"/> enumeration is used with the <see cref="DSROLE_OPERATION_STATE_INFO"/> structure to indicate the operational state of a computer.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-_dsrole_operation_state">_DSROLE_OPERATION_STATE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DSROLE_OPERATION_STATE_INFO"/>
    public enum DSROLE_OPERATION_STATE
    {
        /// <summary>
        /// The computer is idle.
        /// </summary>
        DsRoleOperationIdle = 0,
        /// <summary>
        /// The computer is active.
        /// </summary>
        DsRoleOperationActive,
        /// <summary>
        /// The computer requires a restart.
        /// </summary>
        DsRoleOperationNeedReboot
    }
}
