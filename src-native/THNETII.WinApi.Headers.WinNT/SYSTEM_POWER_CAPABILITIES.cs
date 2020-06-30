using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static LATENCY_TIME;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16127
    /// <summary>
    /// Contains information about the power capabilities of the system.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_power_capabilities">SYSTEM_POWER_CAPABILITIES structure</a></para>
    /// </remarks>
    /// <seealso cref="CallNtPowerInformation"/>
    /// <seealso href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">System Power States</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SYSTEM_POWER_CAPABILITIES
    {
        // Misc supported system features
        #region public bool PowerButtonPresent;
        internal byte PowerButtonPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, there is a system power button.
        /// </summary>
        public bool PowerButtonPresent
        {
            get => PowerButtonPresentField != 0;
            set => PowerButtonPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool SleepButtonPresent;
        internal byte SleepButtonPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, there is a system sleep button.
        /// </summary>
        public bool SleepButtonPresent
        {
            get => SleepButtonPresentField != 0;
            set => SleepButtonPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool LidPresent;
        internal byte LidPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, there is a lid switch.
        /// </summary>
        public bool LidPresent
        {
            get => LidPresentField != 0;
            set => LidPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool SystemS1;
        internal byte SystemS1Field;
        /// <summary>
        /// If this member is <see langword="true"/>, the operating system supports <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">sleep state S1</a>.
        /// </summary>
        public bool SystemS1
        {
            get => SystemS1Field != 0;
            set => SystemS1Field = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool SystemS2;
        internal byte SystemS2Field;
        /// <summary>
        /// If this member is <see langword="true"/>, the operating system supports <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">sleep state S2</a>.
        /// </summary>
        public bool SystemS2
        {
            get => SystemS2Field != 0;
            set => SystemS2Field = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool SystemS3;
        internal byte SystemS3Field;
        /// <summary>
        /// If this member is <see langword="true"/>, the operating system supports <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">sleep state S3</a>.
        /// </summary>
        public bool SystemS3
        {
            get => SystemS3Field != 0;
            set => SystemS3Field = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool SystemS4;
        internal byte SystemS4Field; // hibernate
        /// <summary>
        /// If this member is <see langword="true"/>, the operating system supports <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">sleep state S4</a> (hibernation).
        /// </summary>
        public bool SystemS4
        {
            get => SystemS4Field != 0;
            set => SystemS4Field = (byte)(value ? 1 : 0);
        }
        #endregion           
        #region public bool SystemS5;
        internal byte SystemS5Field; // off
        /// <summary>
        /// If this member is <see langword="true"/>, the operating system supports <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">power off state S5</a> (soft off).
        /// </summary>
        public bool SystemS5
        {
            get => SystemS5Field != 0;
            set => SystemS5Field = (byte)(value ? 1 : 0);
        }
        #endregion           
        #region public bool HiberFilePresent;
        internal byte HiberFilePresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system hibernation file is present.
        /// </summary>
        public bool HiberFilePresent
        {
            get => HiberFilePresentField != 0;
            set => HiberFilePresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool FullWake;
        internal byte FullWakeField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports wake capabilities.
        /// </summary>
        public bool FullWake
        {
            get => FullWakeField != 0;
            set => FullWakeField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool VideoDimPresent;
        internal byte VideoDimPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports video display dimming capabilities.
        /// </summary>
        public bool VideoDimPresent
        {
            get => VideoDimPresentField != 0;
            set => VideoDimPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool ApmPresent;
        internal byte ApmPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports APM BIOS power management features.
        /// </summary>
        public bool ApmPresent
        {
            get => ApmPresentField != 0;
            set => ApmPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool UpsPresent;
        internal byte UpsPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, there is an uninterruptible power supply (UPS).
        /// </summary>
        public bool UpsPresent
        {
            get => UpsPresentField != 0;
            set => UpsPresentField = (byte)(value ? 1 : 0);
        }
        #endregion

        // Processors
        #region public bool ThermalControl;
        internal byte ThermalControlField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports thermal zones.
        /// </summary>
        public bool ThermalControl
        {
            get => ThermalControlField != 0;
            set => ThermalControlField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool ProcessorThrottle;
        internal byte ProcessorThrottleField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports processor throttling.
        /// </summary>
        public bool ProcessorThrottle
        {
            get => ProcessorThrottleField != 0;
            set => ProcessorThrottleField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public byte ProcessorMinThrottle;
        internal byte ProcessorMinThrottleField;
        /// <summary>
        /// The minimum level of system processor throttling supported, expressed as a percentage.
        /// </summary>
        public double ProcessorMinThrottle
        {
            get => ProcessorMinThrottleField / 100.0;
            set => ProcessorMinThrottleField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte ProcessorMaxThrottle;
        internal byte ProcessorMaxThrottleField;
        /// <summary>
        /// The maximum level of system processor throttling supported, expressed as a percentage.
        /// </summary>
        public double ProcessorMaxThrottle
        {
            get => ProcessorMaxThrottleField / 100.0;
            set => ProcessorMaxThrottleField = (byte)(value * 100.0);
        }
        #endregion
        #region public bool FastSystemS4;
        internal byte FastSystemS4Field;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports the hybrid sleep state.
        /// </summary>
        public bool FastSystemS4
        {
            get => FastSystemS4Field != 0;
            set => FastSystemS4Field = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool Hiberboot;
        internal byte HiberbootField;
        public bool Hiberboot
        {
            get => HiberbootField != 0;
            set => HiberbootField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool WakeAlarmPresent;
        internal byte WakeAlarmPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, the platform has support for ACPI wake alarm devices. For more details on wake alarm devices, please see the ACPI specification section 9.18.
        /// </summary>
        public bool WakeAlarmPresent
        {
            get => WakeAlarmPresentField != 0;
            set => WakeAlarmPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool AoAc;
        internal byte AoAcField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports the S0 low power idle model.
        /// </summary>
        public bool AoAc
        {
            get => AoAcField != 0;
            set => AoAcField = (byte)(value ? 1 : 0);
        }
        #endregion

        // Disk
        #region public bool DiskSpinDown;
        internal byte DiskSpinDownField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system supports allowing the removal of power to fixed disk devices.
        /// </summary>
        public bool DiskSpinDown
        {
            get => DiskSpinDownField != 0;
            set => DiskSpinDownField = (byte)(value ? 1 : 0);
        }
        #endregion

        // HiberFile
        public HIBERFILE_TYPE HiberFileType;
        #region public bool AoAcConnectivitySupported;
        internal byte AoAcConnectivitySupportedField;
        public bool AoAcConnectivitySupported
        {
            get => AoAcConnectivitySupportedField != 0;
            set => AoAcConnectivitySupportedField = (byte)(value ? 1 : 0);
        }
        #endregion
        public fixed byte spare3[6];

        // System Battery
        #region public bool SystemBatteriesPresent;
        internal byte SystemBatteriesPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, there are one or more batteries in the system.
        /// </summary>
        public bool SystemBatteriesPresent
        {
            get => SystemBatteriesPresentField != 0;
            set => SystemBatteriesPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool BatteriesAreShortTerm;
        internal byte BatteriesAreShortTermField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system batteries are short-term. Short-term batteries are used in uninterruptible power supplies (UPS).
        /// </summary>
        public bool BatteriesAreShortTerm
        {
            get => BatteriesAreShortTermField != 0;
            set => BatteriesAreShortTermField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public fixed BATTERY_REPORTING_SCALE BatteryScale[3];
        internal fixed byte BatteryScaleField[3 * BATTERY_REPORTING_SCALE.SizeOf];
        /// <summary>
        /// A span of <see cref="BATTERY_REPORTING_SCALE"/> structures that contain information about how system battery metrics are reported.
        /// </summary>
        public Span<BATTERY_REPORTING_SCALE> BatteryScale
        {
            get
            {
                fixed (void* ptr = BatteryScaleField)
                {
                    return new Span<BATTERY_REPORTING_SCALE>(ptr, 3);
                }
            }
        }
        #endregion

        // Wake
        /// <summary>
        /// The lowest <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">system sleep state</a> (Sx) that will generate a wake event when the system is on AC power. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE AcOnLineWake;
        /// <summary>
        /// The lowest <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">system sleep state</a> (Sx) that will generate a wake event via the lid switch. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE SoftLidWake;
        /// <summary>
        /// <para>The lowest <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">system sleep state</a> (Sx) supported by hardware that will generate a wake event via the Real Time Clock (RTC). This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.</para>
        /// <para>To wake the computer using the RTC, the operating system must also support waking from the sleep state the computer is in when the RTC generates the wake event. Therefore, the effective lowest sleep state from which an RTC wake event can wake the computer is the lowest sleep state supported by the operating system that is equal to or higher than the value of RtcWake. To determine the sleep states that the operating system supports, check the <see cref="SystemS1"/>, <see cref="SystemS2"/>, <see cref="SystemS3"/>, and <see cref="SystemS4"/> members.</para>
        /// </summary>
        public SYSTEM_POWER_STATE RtcWake;
        /// <summary>
        /// The minimum allowable <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">system power state</a> supporting wake events. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values. Note that this state may change as different device drivers are installed on the system.
        /// </summary>
        public SYSTEM_POWER_STATE MinDeviceWakeState; // note this may change on driver load
        /// <summary>
        /// The default <a href="https://msdn.microsoft.com/3d897a88-125e-457f-9ea7-ac2056b0767a">system power state</a> used if an application calls <see cref="RequestWakeupLatency"/> with <see cref="LT_LOWEST_LATENCY"/>. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE DefaultLowLatencyWake;
    }
}
