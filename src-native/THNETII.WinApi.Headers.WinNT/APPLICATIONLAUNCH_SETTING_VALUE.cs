using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTRuntimeConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15498
    /// <summary>
    /// Package definition for an experience button device notification.
    /// <para>
    /// When someone registers for <see cref="GUID_APPLAUNCH_BUTTON"/>, this is
    /// the definition of the setting data they'll get.
    /// </para>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct APPLICATIONLAUNCH_SETTING_VALUE
    {
        private static readonly DateTime ActivationTimeEpoch =
            new DateTime(1601, 01, 01, 00, 00, 00, DateTimeKind.Utc);

        /// <remarks>
        /// <note>This value is specified in 100ns intervals since January 1<sup>st</sup>, 1601</note>
        /// </remarks>
        internal long ActivationTimeField;
        /// <summary>
        /// System time when the most recent button press ocurred.
        /// </summary>
        public DateTime ActivationTime
        {
            get => ActivationTimeEpoch + TimeSpan.FromTicks(ActivationTimeField);
            set => ActivationTimeField = (value - ActivationTimeEpoch).Ticks;
        }

        /// <summary>
        /// Reserved for internal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Flags;

        /// <summary>
        /// which instance of this device was pressed?
        /// </summary>
        public int ButtonInstanceID;
    }
}
