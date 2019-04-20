using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15930
    /// <summary>
    /// Contains information about the current system power policy.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_power_policy">SYSTEM_POWER_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="CallNtPowerInformation"/>
    /// <seealso cref="POWER_ACTION_POLICY"/>
    /// <seealso cref="SYSTEM_POWER_LEVEL"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_POLICY
    {
        /// <summary>
        /// The current structure revision.
        /// </summary>
        /// <value><c>1</c></value>
        public int Revision;

        // events
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the system power action to initiate when the system power button is pressed.
        /// </summary>
        public POWER_ACTION_POLICY PowerButton;
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the system power action to initiate when the system sleep button is pressed.
        /// </summary>
        public POWER_ACTION_POLICY SleepButton;
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the system power action to initiate when the system lid switch is closed.
        /// </summary>
        public POWER_ACTION_POLICY LidClose;
        /// <summary>
        /// The maximum power state (highest Sx value) from which a lid-open event should wake the system. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE LidOpenWake;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;

        // "system idle" detection
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the system power action to initiate when the system idle timer expires.
        /// </summary>
        public POWER_ACTION_POLICY Idle;
        #region public int IdleTimeout;
        internal int IdleTimeoutField;
        /// <summary>
        /// The time that the level of system activity must remain below the idle detection threshold before the system idle timer expires, in seconds.
        /// </summary>
        public TimeSpan IdleTimeout
        {
            get => TimeSpan.FromSeconds(IdleTimeoutField);
            set => IdleTimeoutField = (int)value.TotalSeconds;
        }
        #endregion
        #region public byte IdleSensitivity;
        internal byte IdleSensitivityField;
        /// <summary>
        /// The level of system activity that defines the threshold for idle detection, expressed as a percentage.
        /// </summary>
        public double IdleSensitivity
        {
            get => IdleSensitivityField / 100.0;
            set => IdleSensitivityField = (byte)(value * 100.0);
        }
        #endregion

        public PPM_PERFORMANCE_CONTROL_POLICY DynamicThrottle;
        #region public byte[] Spare2 = new byte[2];
        internal short Spare2Field;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Spare2 => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref Spare2Field));
        #endregion

        // meaning of power action "sleep"
        /// <summary>
        /// The minimum system sleep state (lowest Sx value) currently supported. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE MinSleep;
        /// <summary>
        /// The maximum system sleep state (highest Sx value) currently supported. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE MaxSleep;
        /// <summary>
        /// The system power state (Sx value) to enter on a system sleep action when there are outstanding latency requirements. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values. If an application calls <see cref="RequestWakeupLatency"/> with <see cref="LT_LOWEST_LATENCY"/>, <see cref="ReducedLatencySleep"/> will be used in place of <see cref="MaxSleep"/>.
        /// </summary>
        public SYSTEM_POWER_STATE ReducedLatencySleep;
        /// <summary>
        /// This member can be <c>0</c> (zero) or <see cref="WINLOGON_LOCK_ON_SLEEP"/> (<c>0x00000001</c>).
        /// </summary>
        public int WinLogonFlags;

        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Spare3;

        // parameters for dozing
        //
        #region public int DozeS4Timeout;
        internal int DozeS4TimeoutField;
        /// <summary>
        /// The time to wait between entering the suspend state and entering the hibernate sleeping state, in seconds. A value of <see cref="TimeSpan.Zero"/> indicates never hibernate.
        /// </summary>
        public TimeSpan DozeS4Timeout
        {
            get => TimeSpan.FromSeconds(DozeS4TimeoutField);
            set => DozeS4TimeoutField = (int)value.TotalSeconds;
        }
        #endregion

        // battery policies
        /// <summary>
        /// The resolution of change in current battery capacity that should cause the system to be notified of a system power state changed event.
        /// </summary>
        public int BroadcastCapacityResolution;
        #region public SYSTEM_POWER_LEVEL[] DischargePolicy = new SYSTEM_POWER_LEVEL[NUM_DISCHARGE_POLICIES];
        [StructLayout(LayoutKind.Explicit, Size = SYSTEM_POWER_LEVEL.SizeOf * NUM_DISCHARGE_POLICIES)]
        private struct DUMMYSTRUCTNAME { }
        private DUMMYSTRUCTNAME s;
        /// <summary>
        /// An span of <see cref="SYSTEM_POWER_LEVEL"/> structures that defines the actions to take at system battery discharge events.
        /// </summary>
        public Span<SYSTEM_POWER_LEVEL> DischargePolicy => MemoryMarshal.Cast<DUMMYSTRUCTNAME, SYSTEM_POWER_LEVEL>(SpanOverRef.GetSpan(ref s));
        #endregion

        // video policies
        #region public int VideoTimeout;
        internal int VideoTimeoutField;
        /// <summary>
        /// The time before the display is turned off, in seconds.
        /// </summary>
        public TimeSpan VideoTimeout
        {
            get => TimeSpan.FromSeconds(VideoTimeoutField);
            set => VideoTimeoutField = (int)value.TotalSeconds;
        }
        #endregion
        #region public bool VideoDimDisplay; 
        internal byte VideoDimDisplayField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system includes support for display dimming.
        /// </summary>
        public bool VideoDimDisplay
        {
            get => VideoDimDisplayField != 0;
            set => VideoTimeoutField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public int[] VideoReserved = new int[3];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 3)]
        private struct DUMMYSTRUCTNAME2 { }
        private DUMMYSTRUCTNAME2 s2;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<int> VideoReserved => MemoryMarshal.Cast<DUMMYSTRUCTNAME2, int>(SpanOverRef.GetSpan(ref s2));
        #endregion

        // hard disk policies
        #region public int SpindownTimeout;
        internal int SpindownTimeoutField;
        public TimeSpan SpindownTimeout
        {
            get => TimeSpan.FromSeconds(SpindownTimeoutField);
            set => SpindownTimeoutField = (int)value.TotalSeconds;
        }
        #endregion

        // processor policies
        #region public bool OptimizeForPower;
        internal byte OptimizeForPowerField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system will turn on cooling fans and run the processor at full speed when passive cooling is specified. This causes the operating system to be biased toward using the fan and running the processor at full speed.
        /// </summary>
        public bool OptimizeForPower
        {
            get => OptimizeForPowerField != 0;
            set => OptimizeForPowerField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public byte FanThrottleTolerance;
        internal byte FanThrottleToleranceField;
        /// <summary>
        /// The lower limit that the processor may be throttled down to prior to turning on system fans in response to a thermal event, expressed as a percentage.
        /// </summary>
        public double FanThrottleTolerance
        {
            get => FanThrottleToleranceField / 100.0;
            set => FanThrottleToleranceField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte ForcedThrottle;
        internal byte ForcedThrottleField;
        /// <summary>
        /// The processor throttle level to be imposed by the system, expressed as a percentage.
        /// </summary>
        public double ForcedThrottle
        {
            get => ForcedThrottleField / 100.0;
            set => ForcedThrottleField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte MinThrottle;
        internal byte MinThrottleField;
        /// <summary>
        /// The minimum processor throttle level, expressed as a percentage.
        /// </summary>
        public double MinThrottle
        {
            get => MinThrottleField / 100.0;
            set => MinThrottleField = (byte)(value * 100.0);
        }
        #endregion
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the system power action to initiate in response to a thermal event when processor throttling is unable to adequately reduce the system temperature.
        /// </summary>
        public POWER_ACTION_POLICY OverThrottled;
    }
}
