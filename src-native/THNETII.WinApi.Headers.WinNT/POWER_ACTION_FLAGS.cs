namespace THNETII.WinApi.Native.WinNT
{
    public enum POWER_ACTION_FLAGS : int
    {
        /// <summary>
        /// Has no effect.
        /// </summary>
        POWER_ACTION_QUERY_ALLOWED = WinNTConstants.POWER_ACTION_QUERY_ALLOWED,
        /// <summary>
        /// Applications can prompt the user for directions on how to prepare for suspension. Sets bit 0 in the <see cref="Flags"/> parameter passed in the <em>lParam</em> parameter of <see cref="WM_POWERBROADCAST"/>.
        /// </summary>
        POWER_ACTION_UI_ALLOWED = WinNTConstants.POWER_ACTION_UI_ALLOWED,
        /// <summary>
        /// Has no effect.
        /// </summary>
        POWER_ACTION_OVERRIDE_APPS = WinNTConstants.POWER_ACTION_OVERRIDE_APPS,
        POWER_ACTION_HIBERBOOT = WinNTConstants.POWER_ACTION_HIBERBOOT,
        POWER_ACTION_USER_NOTIFY = WinNTConstants.POWER_ACTION_USER_NOTIFY,
        POWER_ACTION_DOZE_TO_HIBERNATE = WinNTConstants.POWER_ACTION_DOZE_TO_HIBERNATE,
        POWER_ACTION_ACPI_CRITICAL = WinNTConstants.POWER_ACTION_ACPI_CRITICAL,
        POWER_ACTION_ACPI_USER_NOTIFY = WinNTConstants.POWER_ACTION_ACPI_USER_NOTIFY,
        POWER_ACTION_DIRECTED_DRIPS = WinNTConstants.POWER_ACTION_DIRECTED_DRIPS,
        POWER_ACTION_PSEUDO_TRANSITION = WinNTConstants.POWER_ACTION_PSEUDO_TRANSITION,
        /// <summary>
        /// Uses the first lightest available sleep state.
        /// </summary>
        POWER_ACTION_LIGHTEST_FIRST = WinNTConstants.POWER_ACTION_LIGHTEST_FIRST,
        /// <summary>
        /// Requires entry of the system password upon resume from one of the system standby states.
        /// </summary>
        POWER_ACTION_LOCK_CONSOLE = WinNTConstants.POWER_ACTION_LOCK_CONSOLE,
        /// <summary>
        /// Disables all wake events.
        /// </summary>
        POWER_ACTION_DISABLE_WAKES = WinNTConstants.POWER_ACTION_DISABLE_WAKES,
        /// <summary>
        /// Forces a critical suspension.
        /// </summary>
        POWER_ACTION_CRITICAL = WinNTConstants.POWER_ACTION_CRITICAL,
    }
}
