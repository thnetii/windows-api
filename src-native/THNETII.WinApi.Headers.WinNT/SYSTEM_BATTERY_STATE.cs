using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16189
    /// <summary>
    /// Contains information about the power capabilities of the system.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_battery_state">SYSTEM_BATTERY_STATE structure</a></para>
    /// </remarks>
    /// <seealso cref="CallNtPowerInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SYSTEM_BATTERY_STATE
    {
        #region public bool AcOnLine;
        internal byte AcOnLineField;
        /// <summary>
        /// If this member is <see langword="true"/>, the system battery charger is currently operating on external power.
        /// </summary>
        public bool AcOnLine
        {
            get => AcOnLineField != 0;
            set => AcOnLineField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool BatteryPresent;
        internal byte BatteryPresentField;
        /// <summary>
        /// If this member is <see langword="true"/>, at least one battery is present in the system.
        /// </summary>
        public bool BatteryPresent
        {
            get => BatteryPresentField != 0;
            set => BatteryPresentField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool Charging;
        internal byte ChargingField;
        /// <summary>
        /// If this member is <see langword="true"/>, a battery is currently charging.
        /// </summary>
        public bool Charging
        {
            get => ChargingField != 0;
            set => ChargingField = (byte)(value ? 1 : 0);
        }
        #endregion
        #region public bool Discharging;
        internal byte DischargingField;
        /// <summary>
        /// If this member is <see langword="true"/>, a battery is currently discharging.
        /// </summary>
        public bool Discharging
        {
            get => DischargingField != 0;
            set => DischargingField = (byte)(value ? 1 : 0);
        }
        #endregion
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Spare1[3];

        public byte Tag;

        /// <summary>
        /// The theoretical capacity of the battery when new.
        /// </summary>
        public int MaxCapacity;
        /// <summary>
        /// The estimated remaining capacity of the battery.
        /// </summary>
        public int RemainingCapacity;
        /// <summary>
        /// The current rate of discharge of the battery, in mW. A nonzero, positive rate indicates charging; a negative rate indicates discharging. Some batteries report only discharging rates.
        /// This value can contain negative values.
        /// </summary>
        public int Rate;
        #region public int EstimatedTime;
        internal int EstimatedTimeField;
        /// <summary>
        /// The estimated time remaining on the battery, in seconds.
        /// </summary>
        public TimeSpan EstimatedTime
        {
            get => TimeSpan.FromSeconds(EstimatedTimeField);
            set => EstimatedTimeField = (int)(value.TotalSeconds);
        }
        #endregion

        /// <summary>
        /// The manufacturer's suggestion of a capacity, in mWh, at which a low battery alert should occur. Definitions of low vary from manufacturer to manufacturer. In general, a warning state will occur before a low state, but you should not assume that it always will. To reduce risk of data loss, this value is usually used as the default setting for the critical battery alarm.
        /// </summary>
        public int DefaultAlert1;
        /// <summary>
        /// The manufacturer's suggestion of a capacity, in mWh, at which a warning battery alert should occur. Definitions of warning vary from manufacturer to manufacturer. In general, a warning state will occur before a low state, but you should not assume that it always will. To reduce risk of data loss, this value is usually used as the default setting for the low battery alarm.
        /// </summary>
        public int DefaultAlert2;
    }
}
