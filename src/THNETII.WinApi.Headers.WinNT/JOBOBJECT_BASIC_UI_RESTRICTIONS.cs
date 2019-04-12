using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_UILIMIT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11738
    /// <summary>
    /// Contains basic user-interface restrictions for a job object.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If you specify the <see cref="JOB_OBJECT_UILIMIT_HANDLES"/> flag, when a
    /// process associated with the job broadcasts messages, they are only sent
    /// to top-level windows owned by processes associated with the same job. In
    /// addition, hooks can be installed only on threads belonging to processes
    /// associated with the job.
    /// </para>
    /// <para>To grant access to a User handle to a job that has a user-interface restriction, use the <see cref="UserHandleGrantAccess"/> function.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_ui_restrictions">JOBOBJECT_BASIC_UI_RESTRICTIONS structure</a></para>
    /// </remarks>
    /// <seealso cref="ExitWindows"/>
    /// <seealso cref="ExitWindowsEx"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    /// <seealso cref="SystemParametersInfo"/>
    /// <seealso cref="UserHandleGrantAccess"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_UI_RESTRICTIONS
    {
        /// <summary>
        /// The restriction class for the user interface.
        /// </summary>
        public JOB_OBJECT_UILIMIT_FLAGS UIRestrictionsClass;
    }
}
