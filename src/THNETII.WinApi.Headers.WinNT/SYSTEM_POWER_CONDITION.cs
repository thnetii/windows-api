namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTRuntimeConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15449
    /// <summary>
    /// Used by the <see cref="GUID_ACDC_POWER_SOURCE"/> power event to indicate the current power source.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-system_power_condition">SYSTEM_POWER_CONDITION Enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/f78cd97f-586f-4091-ab4a-5f109a0f679a">Power Management Enumeration Types</seealso>
    public enum SYSTEM_POWER_CONDITION
    {
        /// <summary>
        /// The computer is powered by an AC power source (or similar, such as a laptop powered by a 12V automotive adapter).
        /// </summary>
        PoAc,
        /// <summary>The system is receiving power from built-in batteries.</summary>
        PoDc,
        /// <summary>The computer is powered by a short-term power source such as a UPS device.</summary>
        PoHot,
        /// <summary>Values equal to or greater than this value indicate an out of range value.</summary>
        PoConditionMaximum
    }
}
