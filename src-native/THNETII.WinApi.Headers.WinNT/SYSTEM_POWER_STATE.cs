namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15097
    /// <summary>
    /// Defines values that are used to specify system power states.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_power_state">SYSTEM_POWER_STATE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="ADMINISTRATOR_POWER_POLICY"/>
    /// <seealso cref="GLOBAL_MACHINE_POWER_POLICY"/>
    /// <seealso cref="MACHINE_POWER_POLICY"/>
    /// <seealso href="https://msdn.microsoft.com/f78cd97f-586f-4091-ab4a-5f109a0f679a">Power Management Enumeration Types</seealso>
    /// <seealso cref="SYSTEM_POWER_CAPABILITIES"/>
    /// <seealso cref="SYSTEM_POWER_POLICY"/>
    /// <seealso cref="USER_POWER_POLICY"/>
    public enum SYSTEM_POWER_STATE
    {
        /// <summary>Unspecified system power state.</summary>
        PowerSystemUnspecified = 0,
        /// <summary>Specifies system power state S0.</summary>
        PowerSystemWorking = 1,
        /// <summary>Specifies system power state S1.</summary>
        PowerSystemSleeping1 = 2,
        /// <summary>Specifies system power state S2.</summary>
        PowerSystemSleeping2 = 3,
        /// <summary>Specifies system power state S3.</summary>
        PowerSystemSleeping3 = 4,
        /// <summary>Specifies system power state S4 (HIBERNATE).</summary>
        PowerSystemHibernate = 5,
        /// <summary>Specifies system power state S5 (OFF).</summary>
        PowerSystemShutdown = 6,
        /// <summary>Specifies the maximum enumeration value.</summary>
        PowerSystemMaximum = 7
    }
}
