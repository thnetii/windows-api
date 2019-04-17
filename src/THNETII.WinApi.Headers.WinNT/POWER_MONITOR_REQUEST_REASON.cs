namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15369
    /// <summary>
    /// Monitor on/off reasons
    /// </summary>
    /// <remarks>
    /// <note>Update power-event mapping when adding new events.</note>
    /// </remarks>
    public enum POWER_MONITOR_REQUEST_REASON
    {
        MonitorRequestReasonUnknown,
        MonitorRequestReasonPowerButton,
        MonitorRequestReasonRemoteConnection,
        MonitorRequestReasonScMonitorpower,
        MonitorRequestReasonUserInput,
        MonitorRequestReasonAcDcDisplayBurst,
        MonitorRequestReasonUserDisplayBurst,
        MonitorRequestReasonPoSetSystemState,
        MonitorRequestReasonSetThreadExecutionState,
        MonitorRequestReasonFullWake,
        MonitorRequestReasonSessionUnlock,
        MonitorRequestReasonScreenOffRequest,
        MonitorRequestReasonIdleTimeout,
        MonitorRequestReasonPolicyChange,
        MonitorRequestReasonSleepButton,
        MonitorRequestReasonLid,
        MonitorRequestReasonBatteryCountChange,
        MonitorRequestReasonGracePeriod,
        MonitorRequestReasonPnP,
        MonitorRequestReasonDP,
        MonitorRequestReasonSxTransition,
        MonitorRequestReasonSystemIdle,
        MonitorRequestReasonNearProximity,
        MonitorRequestReasonThermalStandby,
        MonitorRequestReasonResumePdc,
        MonitorRequestReasonResumeS4,
        MonitorRequestReasonTerminal,
        MonitorRequestReasonPdcSignal,
        MonitorRequestReasonAcDcDisplayBurstSuppressed,
        MonitorRequestReasonSystemStateEntered, // When CS exit happens because system
                                                // transition to S4/S5, please note this
                                                // reason is different than ReasonSxTransition.
        MonitorRequestReasonWinrt,
        MonitorRequestReasonUserInputKeyboard,
        MonitorRequestReasonUserInputMouse,
        MonitorRequestReasonUserInputTouch,
        MonitorRequestReasonUserInputPen,
        MonitorRequestReasonUserInputAccelerometer,
        MonitorRequestReasonUserInputHid,
        MonitorRequestReasonUserInputPoUserPresent,
        MonitorRequestReasonUserInputSessionSwitch,
        MonitorRequestReasonUserInputInitialization,
        MonitorRequestReasonPdcSignalWindowsMobilePwrNotif,         // PDC_SIGNAL_PROVIDER_PWRNOTIF_SVC
        MonitorRequestReasonPdcSignalWindowsMobileShell,            // PDC_SIGNAL_PROVIDER_UM_CS_CONTROL
        MonitorRequestReasonPdcSignalHeyCortana,                    // PDC_SIGNAL_PROVIDER_HEY_CORTANA
        MonitorRequestReasonPdcSignalHolographicShell,              // PDC_SIGNAL_PROVIDER_HOLOSI_CRITICAL_BATTERY_WAKE
        MonitorRequestReasonPdcSignalFingerprint,                   // PDC_SIGNAL_PROVIDER_WINBIO
        MonitorRequestReasonMax
    }
}
