using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// The processor performance control policy constants indicate the processor performance control algorithm applied to a power scheme.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/power/processor-performance-control-policy-constants">Processor Performance Control Policy Constants</a></para>
    /// </remarks>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32", Justification = nameof(SYSTEM_POWER_POLICY.DynamicThrottle))]
    public enum PPM_PERFORMANCE_CONTROL_POLICY : byte
    {
        /// <summary>
        /// No processor performance control is applied. This policy always runs the processor at its highest possible performance level. This policy will not engage processor clock throttling, except in response to thermal events.
        /// </summary>
        PO_THROTTLE_NONE = WinNTConstants.PO_THROTTLE_NONE,
        /// <summary>
        /// Does not allow the processor to use any high voltage performance states. This policy will not engage processor clock throttling, except in response to thermal events.
        /// </summary>
        PO_THROTTLE_CONSTANT = WinNTConstants.PO_THROTTLE_CONSTANT,
        /// <summary>
        /// Does not allow the processor to use any high voltage performance states. This policy will engage processor clock throttling when the battery is below a certain threshold, if the C3 state is not being utilized, or in response to thermal events.
        /// </summary>
        PO_THROTTLE_DEGRADE = WinNTConstants.PO_THROTTLE_DEGRADE,
        /// <summary>
        /// Attempts to match the performance of the processor to the current demand. This policy will use both high and low voltage and frequency states. This policy will lower the performance of the processor to the lowest voltage available whenever there is insufficient demand to justify a higher voltage. This policy will engage processor clock throttling if the C3 state is not being utilized, and in response to thermal events.
        /// </summary>
        PO_THROTTLE_ADAPTIVE = WinNTConstants.PO_THROTTLE_ADAPTIVE,
        PO_THROTTLE_MAXIMUM = WinNTConstants.PO_THROTTLE_MAXIMUM,
    }
}
