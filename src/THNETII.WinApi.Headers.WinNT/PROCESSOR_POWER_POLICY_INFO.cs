using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16026
    /// <summary>
    /// Contains information about processor C-state policy settings. This structure is part of the <see cref="PROCESSOR_POWER_POLICY"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-processor_power_policy_info">PROCESSOR_POWER_POLICY_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="PROCESSOR_POWER_POLICY"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_POWER_POLICY_INFO
    {
        // Time based information (will be converted to kernel units)
        #region public int TimeCheck;
        internal int TimeCheckField; // in µs
        /// <summary>
        /// The time that must expire before promotion or demotion is considered.
        /// </summary>
        public TimeSpan TimeCheck
        {
            get => TimeSpan.FromMilliseconds(TimeCheckField / 1000.0);
            set => TimeCheckField = (int)(value.TotalMilliseconds * 1000.0);
        }
        #endregion
        #region public int DemoteLimit;
        internal int DemoteLimitField; // in µs
        /// <summary>
        /// The minimum amount of time that must be spent in the idle loop to avoid demotion.
        /// </summary>
        public TimeSpan DemoteLimit
        {
            get => TimeSpan.FromMilliseconds(DemoteLimitField / 1000.0);
            set => DemoteLimitField = (int)(value.TotalMilliseconds * 1000.0);
        }
        #endregion
        #region public int PromoteLimit;
        internal int PromoteLimitField; // in µs
        /// <summary>
        /// The time that must be exceeded to cause promotion to a deeper idle state.
        /// </summary>
        public TimeSpan PromoteLimit
        {
            get => TimeSpan.FromMilliseconds(PromoteLimitField / 1000.0);
            set => PromoteLimitField = (int)(value.TotalMilliseconds * 1000.0);
        }
        #endregion

        // Percentage based information
        #region public byte DemotePercent;
        internal byte DemotePercentField;
        /// <summary>
        /// The value that scales the threshold at which the power policy manager
        /// decreases the performance of the processor, expressed as a percentage.
        /// </summary>
        /// <value>A <see cref="double"/> value between <c>0.0</c> (0%) and <c>1.0</c> (100%).</value>
        public double DemotePercent
        {
            get => DemotePercentField / 100.0;
            set => DemotePercentField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte PromotePercent;
        internal byte PromotePercentField;
        /// <summary>
        /// The value that scales the threshold at which the power policy manager
        /// increases the performance of the processor, expressed as a percentage.
        /// </summary>
        /// <value>A <see cref="double"/> value between <c>0.0</c> (0%) and <c>1.0</c> (100%).</value>
        public double PromotePercent
        {
            get => PromotePercentField / 100.0;
            set => PromotePercentField = (byte)(value * 100.0);
        }
        #endregion
        #region public byte[] Spare = new byte[2];
        internal short SpareField;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<byte> Spare => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref SpareField));
        #endregion

        // Flags
        private static readonly Bitfield32 AllowDemotionBitfield = Bitfield32.Bit(0);
        private static readonly Bitfield32 AllowPromotionBitfield = Bitfield32.Bit(1);
        private static readonly Bitfield32 ReservedBitfield = Bitfield32.RemainingBits(2);
        private uint Flags;
        /// <summary>
        /// When set, allows the kernel power policy manager to demote from the current state.
        /// </summary>
        public bool AllowDemotion
        {
            get => AllowDemotionBitfield.ReadMasked(Flags) != 0;
            set => AllowDemotionBitfield.WriteMasked(ref Flags, value ? ~0U : 0U);
        }
        /// <summary>
        /// When set, allows the kernel power policy manager to promote from the current state.
        /// </summary>
        public bool AllowPromotion
        {
            get => AllowPromotionBitfield.ReadMasked(Flags) != 0;
            set => AllowPromotionBitfield.WriteMasked(ref Flags, value ? ~0U : 0U);
        }
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved
        {
            get => (int)ReservedBitfield.Read(Flags);
            set => ReservedBitfield.Write(ref Flags, (uint)value);
        }
    }
}
