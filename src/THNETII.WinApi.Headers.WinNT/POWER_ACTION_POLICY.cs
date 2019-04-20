using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15874
    /// <summary>
    /// Contains information used to set the system power state.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-power_action_policy">POWER_ACTION_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="GLOBAL_USER_POWER_POLICY"/>
    /// <seealso cref="MACHINE_POWER_POLICY"/>
    /// <seealso cref="USER_POWER_POLICY"/>
    /// <seealso cref="WM_POWERBROADCAST"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_ACTION_POLICY
    {
        /// <summary>
        /// The requested system power state. This member must be one of the <see cref="POWER_ACTION"/> enumeration type values.
        /// </summary>
        public POWER_ACTION Action;
        /// <summary>
        /// A flag that controls how to switch the power state.
        /// </summary>
        public POWER_ACTION_FLAGS Flags;
        /// <summary>
        /// The level of user notification.
        /// </summary>
        public POWER_EVENT_CODE EventCode;
    }
}
