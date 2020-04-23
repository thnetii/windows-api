using System;

namespace THNETII.WinApi.Native.WinBase
{
    [Flags]
    public enum SYSTEM_ERROR_MODE : int
    {
        /// <summary>
        /// <para>The system does not display the critical-error-handler message box. Instead, the system sends the error to the calling thread.</para>
        /// <para>Best practice is that all applications call the process-wide <see cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetErrorMode(THNETII.WinApi.Native.WinBase.SYSTEM_ERROR_MODE)"/> function with a parameter of <see cref="SEM_FAILCRITICALERRORS"/> at startup. This is to prevent error mode dialogs from hanging the application.</para>
        /// </summary>
        SEM_FAILCRITICALERRORS = WinBaseConstants.SEM_FAILCRITICALERRORS,
        /// <summary>
        /// The system does not display the Windows Error Reporting dialog.
        /// </summary>
        SEM_NOGPFAULTERRORBOX = WinBaseConstants.SEM_NOGPFAULTERRORBOX,
        /// <summary>
        /// The system automatically fixes memory alignment faults and makes them invisible to the application.
        /// It does this for the calling process and any descendant processes.
        /// This feature is only supported by certain processor architectures. For more information, see <see cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetErrorMode(THNETII.WinApi.Native.WinBase.SYSTEM_ERROR_MODE)"/>.
        /// </summary>
        SEM_NOALIGNMENTFAULTEXCEPT = WinBaseConstants.SEM_NOALIGNMENTFAULTEXCEPT,
        /// <summary>
        /// The <see cref="M:THNETII.WinApiNative.FileManagement.FileManagementFunctions.OpenFile"/> function does not display a message box when it fails to find a file. Instead, the error is returned to the caller. This error mode overrides the <see cref="OF_PROMPT"/> flag.
        /// </summary>
        SEM_NOOPENFILEERRORBOX = WinBaseConstants.SEM_NOOPENFILEERRORBOX,
    }
}
