using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApiNative.ErrorHandling
{
    using static ErrorHandlingFunctions;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags, SuppressMessage("Naming", "CA1714: Flags enums should have plural names")]
    public enum SystemErrorMode : int
    {
        /// <summary>
        /// <para>The system does not display the critical-error-handler message box. Instead, the system sends the error to the calling thread.</para>
        /// <para>Best practice is that all applications call the process-wide <see cref="SetErrorMode"/> function with a parameter of <see cref="SEM_FAILCRITICALERRORS"/> at startup. This is to prevent error mode dialogs from hanging the application.</para>
        /// </summary>
        SEM_FAILCRITICALERRORS = 0x0001,
        /// <summary>
        /// The system does not display the Windows Error Reporting dialog.
        /// </summary>
        SEM_NOGPFAULTERRORBOX = 0x0002,
        /// <summary>
        /// The system automatically fixes memory alignment faults and makes them invisible to the application.
        /// It does this for the calling process and any descendant processes.
        /// This feature is only supported by certain processor architectures. For more information, see <see cref="SetErrorMode"/>.
        /// </summary>
        SEM_NOALIGNMENTFAULTEXCEPT = 0x0004,
        /// <summary>
        /// The <see cref="M:THNETII.WinApiNative.FileManagement.FileManagementFunctions.OpenFile"/> function does not display a message box when it fails to find a file. Instead, the error is returned to the caller. This error mode overrides the <see cref="OF_PROMPT"/> flag.
        /// </summary>
        SEM_NOOPENFILEERRORBOX = 0x8000,

    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
