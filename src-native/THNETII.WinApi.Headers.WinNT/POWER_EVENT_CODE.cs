namespace THNETII.WinApi.Native.WinNT
{
    /// <remarks>
    /// for battery alarm EventCodes, the ID of the battery alarm &lt;&lt; 16 is ORed
    /// into the flags.  For example: <c>DISCHARGE_POLICY_LOW &lt;&lt; 16</c>.
    /// </remarks>
    public enum POWER_EVENT_CODE : int
    {
        /// <summary>
        /// User notified using the UI.
        /// </summary>
        POWER_LEVEL_USER_NOTIFY_TEXT = WinNTConstants.POWER_LEVEL_USER_NOTIFY_TEXT,
        /// <summary>
        /// User notified using sound.
        /// </summary>
        POWER_LEVEL_USER_NOTIFY_SOUND = WinNTConstants.POWER_LEVEL_USER_NOTIFY_SOUND,
        /// <summary>
        /// Specifies a program to be executed.
        /// </summary>
        POWER_LEVEL_USER_NOTIFY_EXEC = WinNTConstants.POWER_LEVEL_USER_NOTIFY_EXEC,
        /// <summary>
        /// Indicates that the power action is in response to a user power button press.
        /// </summary>
        POWER_USER_NOTIFY_BUTTON = WinNTConstants.POWER_USER_NOTIFY_BUTTON,
        /// <summary>
        /// Indicates a power action of shutdown/off.
        /// </summary>
        POWER_USER_NOTIFY_SHUTDOWN = WinNTConstants.POWER_USER_NOTIFY_SHUTDOWN,
        POWER_USER_NOTIFY_FORCED_SHUTDOWN = WinNTConstants.POWER_USER_NOTIFY_FORCED_SHUTDOWN,
        /// <summary>
        /// Clears a user power button press.
        /// </summary>
        POWER_FORCE_TRIGGER_RESET = WinNTConstants.POWER_FORCE_TRIGGER_RESET,
    }
}
