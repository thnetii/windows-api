namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11501
    /// <summary>
    /// Defines the types of hardware counters being profiled.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-hardware_counter_type">HARDWARE_COUNTER_TYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="HARDWARE_COUNTER_DATA"/>
    public enum HARDWARE_COUNTER_TYPE
    {
        /// <summary>Hardware performance monitoring counters.</summary>
        PMCCounter,
        /// <summary>The maximum enumeration value for this enumeration.</summary>
        MaxHardwareCounterType
    }
}
