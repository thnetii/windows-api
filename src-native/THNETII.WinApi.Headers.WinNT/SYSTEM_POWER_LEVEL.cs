using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15915
    /// <summary>
    /// Contains information about system battery drain policy settings. This structure is part of the <see cref="GLOBAL_USER_POWER_POLICY"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-system_power_level">SYSTEM_POWER_LEVEL structure</a></para>
    /// </remarks>
    /// <seealso cref="GLOBAL_USER_POWER_POLICY"/>
    /// <seealso cref="POWER_ACTION_POLICY"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SYSTEM_POWER_LEVEL
    {
        internal const int SizeOf = sizeof(int) * 2
            + POWER_ACTION_POLICY.SizeOf
            + sizeof(SYSTEM_POWER_STATE);

        private byte EnableField;
        /// <summary>
        /// If this member is <see langword="true"/>, the alarm should be activated when the battery discharges below the value set in <see cref="BatteryLevel"/>.
        /// </summary>
        public bool Enable
        {
            get => EnableField != 0;
            set => EnableField = (byte)(value ? 1 : 0);
        }
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Spare[3];
        #region public int BatteryLevel;
        /// <summary>
        ///
        /// </summary>
        internal int BatteryLevelField;
        /// <summary>
        /// The battery capacity for this battery discharge policy, expressed as a percentage.
        /// </summary>
        public double BatteryLevel
        {
            get => BatteryLevelField / 100.0;
            set => BatteryLevelField = (int)(value * 100.0);
        }
        #endregion
        /// <summary>
        /// A <see cref="POWER_ACTION_POLICY"/> structure that defines the action to take for this battery discharge policy.
        /// </summary>
        public POWER_ACTION_POLICY PowerPolicy;
        /// <summary>
        /// The minimum system sleep state to enter when the battery discharges below the value set in <see cref="BatteryLevel"/>. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values.
        /// </summary>
        public SYSTEM_POWER_STATE MinSystemState;
    }
}
