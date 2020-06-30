using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static SYSTEM_POWER_STATE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16094
    // administrator power policy overrides

    /// <summary>
    /// Represents the administrator override power policy settings.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="ADMINISTRATOR_POWER_POLICY"/> structure defines limits to certain power policy values that are applied globally to all users' power schemes. The values in the <see cref="ADMINISTRATOR_POWER_POLICY"/> structure override any settings selected by the user in the Power Options control panel program.</para>
    /// <para>To set an administrator override policy, call the <see cref="CallNtPowerInformation"/> function.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-administrator_power_policy">ADMINISTRATOR_POWER_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="CallNtPowerInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADMINISTRATOR_POWER_POLICY
    {
        // meaning of power action "sleep"
        /// <summary>
        /// The minimum system power sleep state. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values between <see cref="PowerSystemSleeping1"/> (power state S1) and <see cref="PowerSystemHibernate"/> (power state S4).
        /// </summary>
        public SYSTEM_POWER_STATE MinSleep;
        /// <summary>
        /// The maximum system power sleep state. This member must be one of the <see cref="SYSTEM_POWER_STATE"/> enumeration type values between <see cref="PowerSystemSleeping1"/> (power state S1) and <see cref="PowerSystemHibernate"/> (power state S4).
        /// </summary>
        public SYSTEM_POWER_STATE MaxSleep;

        // video policies
        internal int MinVideoTimeoutField;
        /// <summary>
        /// The minimum allowable video idle time-out before turning the display device off, in seconds.
        /// </summary>
        public TimeSpan MinVideoTimeout
        {
            get => TimeSpan.FromSeconds(MinVideoTimeoutField);
            set => MinVideoTimeoutField = (int)(value.TotalSeconds);
        }
        internal int MaxVideoTimeoutField;
        /// <summary>
        /// The maximum allowable video idle time-out before turning the display device off, in seconds.
        /// </summary>
        public TimeSpan MaxVideoTimeout
        {
            get => TimeSpan.FromSeconds(MaxVideoTimeoutField);
            set => MaxVideoTimeoutField = (int)(value.TotalSeconds);
        }

        // disk policies
        internal int MinSpindownTimeoutField;
        /// <summary>
        /// The minimum allowable disk idle time before flushing the cache manager and spinning down a hard disk device, in seconds.
        /// </summary>
        public TimeSpan MinSpindownTimeout
        {
            get => TimeSpan.FromSeconds(MinSpindownTimeoutField);
            set => MinSpindownTimeoutField = (int)(value.TotalSeconds);
        }
        internal int MaxSpindownTimeoutField;
        /// <summary>
        /// The maximum allowable disk idle time before flushing the cache manager and spinning down a hard disk device, in seconds.
        /// </summary>
        public TimeSpan MaxSpindownTimeout
        {
            get => TimeSpan.FromSeconds(MaxSpindownTimeoutField);
            set => MaxSpindownTimeoutField = (int)(value.TotalSeconds);
        }
    }
}
