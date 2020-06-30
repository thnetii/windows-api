using System;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// UI restrictions for jobs
    /// </summary>
    [Flags]
    public enum JOB_OBJECT_UILIMIT_FLAGS : int
    {
        JOB_OBJECT_UILIMIT_NONE = WinNTConstants.JOB_OBJECT_UILIMIT_NONE,

        /// <summary>
        /// Prevents processes associated with the job from using USER handles owned by processes not associated with the same job. 
        /// </summary>
        JOB_OBJECT_UILIMIT_HANDLES = WinNTConstants.JOB_OBJECT_UILIMIT_HANDLES,
        /// <summary>
        /// Prevents processes associated with the job from reading data from the clipboard. 
        /// </summary>
        JOB_OBJECT_UILIMIT_READCLIPBOARD = WinNTConstants.JOB_OBJECT_UILIMIT_READCLIPBOARD,
        /// <summary>
        /// Prevents processes associated with the job from writing data to the clipboard. 
        /// </summary>
        JOB_OBJECT_UILIMIT_WRITECLIPBOARD = WinNTConstants.JOB_OBJECT_UILIMIT_WRITECLIPBOARD,
        /// <summary>
        /// Prevents processes associated with the job from changing system parameters by using the <see cref="SystemParametersInfo"/> function. 
        /// </summary>
        JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = WinNTConstants.JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS,
        /// <summary>
        /// Prevents processes associated with the job from calling the <see cref="ChangeDisplaySettings"/> function. 
        /// </summary>
        JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = WinNTConstants.JOB_OBJECT_UILIMIT_DISPLAYSETTINGS,
        /// <summary>
        /// Prevents processes associated with the job from accessing global atoms. When this flag is used, each job has its own atom table. 
        /// </summary>
        JOB_OBJECT_UILIMIT_GLOBALATOMS = WinNTConstants.JOB_OBJECT_UILIMIT_GLOBALATOMS,
        /// <summary>
        /// Prevents processes associated with the job from creating desktops and switching desktops using the <see cref="CreateDesktop"/> and <see cref="SwitchDesktop"/> functions. 
        /// </summary>
        JOB_OBJECT_UILIMIT_DESKTOP = WinNTConstants.JOB_OBJECT_UILIMIT_DESKTOP,
        /// <summary>
        /// Prevents processes associated with the job from calling the <see cref="ExitWindows"/> or <see cref="ExitWindowsEx"/> function. 
        /// </summary>
        JOB_OBJECT_UILIMIT_EXITWINDOWS = WinNTConstants.JOB_OBJECT_UILIMIT_EXITWINDOWS,

        JOB_OBJECT_UILIMIT_ALL = WinNTConstants.JOB_OBJECT_UILIMIT_ALL,

        JOB_OBJECT_UI_VALID_FLAGS = WinNTConstants.JOB_OBJECT_UI_VALID_FLAGS,
    }
}
