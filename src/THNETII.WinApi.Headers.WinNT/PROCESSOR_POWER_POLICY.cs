using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16046
    /// <summary>
    /// Contains information used to set the system power state.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-processor_power_policy">PROCESSOR_POWER_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="CallNtPowerInformation"/>
    /// <seealso cref="PROCESSOR_POWER_POLICY_INFO"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PROCESSOR_POWER_POLICY
    {
        /// <summary>
        /// The current structure revision level. Set this value by calling <see cref="ReadProcessorPwrScheme"/> before using a <see cref="PROCESSOR_POWER_POLICY"/> structure to set power policy.
        /// </summary>
        public int Revision;

        // Dynamic Throttling Policy
        /// <summary>
        /// The current processor performance state policy. This member must be one of the values described in <a href="https://msdn.microsoft.com/928ba485-f767-47df-8b57-7630c68068a7">Processor Performance Control Policy Constants</a>.
        /// </summary>
        public PPM_PERFORMANCE_CONTROL_POLICY DynamicThrottle;
        /// <summary>Reserved; set to zero.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Spare[3];

        // Flags
        private static readonly Bitfield32 DisableCStatesBitfield = Bitfield32.Bit(0);
        private static readonly Bitfield32 ReservedBitfield = Bitfield32.RemainingBits(1);
        internal int Flags;
        /// <summary>Reserved; set to zero.</summary>
        public bool DisableCStates
        {
            get => DisableCStatesBitfield.ReadMasked(Flags) != 0;
            set => DisableCStatesBitfield.WriteMasked(ref Flags, value ? ~0 : 0);
        }
        /// <summary>Reserved; set to zero.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved
        {
            get => ReservedBitfield.Read(Flags);
            set => ReservedBitfield.Write(ref Flags, value);
        }

        // System policy information
        /// <summary>
        /// The number of elements in the <see cref="Policy"/> span.
        /// </summary>
        public int PolicyCount;
        #region public PROCESSOR_POWER_POLICY_INFO[] Policy = new PROCESSOR_POWER_POLICY_INFO[PolicyCount];
        internal PROCESSOR_POWER_POLICY_INFO Policy0;
        internal PROCESSOR_POWER_POLICY_INFO Policy1;
        internal PROCESSOR_POWER_POLICY_INFO Policy2;
        /// <summary>
        /// An span of <see cref="PROCESSOR_POWER_POLICY_INFO"/> structures that defines values used to apply processor C-state policy settings. <c><see cref="Policy"/>[0]</c> corresponds to ACPI C-state C1, <c><see cref="Policy"/>[1]</c> corresponds to C2, and <c><see cref="Policy"/>[2]</c> corresponds to C3. The <see cref="PROCESSOR_POWER_POLICY_INFO.AllowPromotion"/> member determines whether the processor can be promoted to the state. For example, if <c><see cref="Policy"/>[0].<see cref="PROCESSOR_POWER_POLICY_INFO.AllowPromotion"/></c> is <see langword="false"/>, the computer cannot transition from C0 to C1.
        /// </summary>
        public Span<PROCESSOR_POWER_POLICY_INFO> Policy => SpanOverRef.GetSpan(ref Policy0, (int)Math.Min(3U, (uint)PolicyCount));
        #endregion
    }
}
