using System;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_REPSYNCALL_EVENT"/> enumeration is used with the <see cref="DS_REPSYNCALL_UPDATE"/> structure to define which event the <see cref="DS_REPSYNCALL_UPDATE"/> structure represents.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_repsyncall_event">DS_REPSYNCALL_EVENT Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DS_REPSYNCALL_UPDATE"/>
    public enum DS_REPSYNCALL_EVENT
    {
        /// <summary>
        /// An error occurred. Error data is stored in the <see cref="DS_REPSYNCALL_UPDATE.pErrInfo"/> member of the <see cref="DS_REPSYNCALL_UPDATE"/> structure.
        /// </summary>
        DS_REPSYNCALL_EVENT_ERROR = 0,
        /// <summary>
        /// Synchronization of two servers has started. Both the <see cref="DS_REPSYNCALL_UPDATE.pErrInfo"/> and <see cref="DS_REPSYNCALL_UPDATE.pSync"/> members of the <see cref="DS_REPSYNCALL_UPDATE"/> structure are <see cref="IntPtr.Zero"/>.
        /// </summary>
        DS_REPSYNCALL_EVENT_SYNC_STARTED = 1,
        /// <summary>
        /// Synchronization of two servers has just finished. The servers involved in the synchronization are identified by the <see cref="DS_REPSYNCALL_UPDATE.pSync"/> member of the <see cref="DS_REPSYNCALL_UPDATE"/> structure. The <see cref="DS_REPSYNCALL_UPDATE.pErrInfo"/> member of the <see cref="DS_REPSYNCALL_UPDATE"/> structure is <see cref="IntPtr.Zero"/>.
        /// </summary>
        DS_REPSYNCALL_EVENT_SYNC_COMPLETED = 2,
        /// <summary>
        /// Execution of <see cref="DsReplicaSyncAll"/> is complete. Both the <see cref="DS_REPSYNCALL_UPDATE.pErrInfo"/> and <see cref="DS_REPSYNCALL_UPDATE.pSync"/> members of the <see cref="DS_REPSYNCALL_UPDATE"/> structure are <see cref="IntPtr.Zero"/>. The return value of the callback function is ignored.
        /// </summary>
        DS_REPSYNCALL_EVENT_FINISHED = 3
    }
}
