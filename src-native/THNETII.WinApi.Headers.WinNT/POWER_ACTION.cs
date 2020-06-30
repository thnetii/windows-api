using System.ComponentModel;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15110
    /// <summary>
    /// Defines values that are used to specify system power action types.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-power_action">POWER_ACTION Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="POWER_ACTION_POLICY"/>
    /// <seealso href="https://msdn.microsoft.com/ba917d15-bbdb-46fe-9ad8-56a8837f7b2d">Power Management</seealso>
    /// <seealso href="https://msdn.microsoft.com/f78cd97f-586f-4091-ab4a-5f109a0f679a">Power Management Enumeration Types</seealso>
    public enum POWER_ACTION
    {
        /// <summary>No system power action.</summary>
        PowerActionNone = 0,
        /// <summary>Reserved; do not use.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PowerActionReserved,
        /// <summary>Sleep.</summary>
        PowerActionSleep,
        /// <summary>Hibernate.</summary>
        PowerActionHibernate,
        /// <summary>Shutdown.</summary>
        PowerActionShutdown,
        /// <summary>Shutdown and reset.</summary>
        PowerActionShutdownReset,
        /// <summary>Shutdown and power off.</summary>
        PowerActionShutdownOff,
        /// <summary>Warm eject.</summary>
        PowerActionWarmEject,
        PowerActionDisplayOff
    }
}
