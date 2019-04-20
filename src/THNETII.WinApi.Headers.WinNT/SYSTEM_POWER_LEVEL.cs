using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

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
    public struct SYSTEM_POWER_LEVEL
    {
        #region public bool Enable;
        private int EnableField;
        private Span<byte> EnableSpan => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref EnableField));
        /// <summary>
        /// If this member is <see langword="true"/>, the alarm should be activated when the battery discharges below the value set in <see cref="BatteryLevel"/>.
        /// </summary>
        public bool Enable
        {
            get => EnableSpan[0] != 0;
            set => EnableSpan[0] = (byte)(value ? 1 : 0);
        }
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SuppressMessage("Usage", "PC001: API not supported on all platforms", Justification = "https://github.com/dotnet/platform-compat/issues/123")]
        public Span<byte> Spare => EnableSpan.Slice(start: 1);
        #endregion
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
