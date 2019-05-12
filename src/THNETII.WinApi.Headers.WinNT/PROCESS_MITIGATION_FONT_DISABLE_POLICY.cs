using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11610
    /// <summary>
    /// Contains process mitigation policy settings for the loading of non-system fonts.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_font_disable_policy">PROCESS_MITIGATION_FONT_DISABLE_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="GetProcessMitigationPolicy"/>
    /// <seealso cref="SetProcessMitigationPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_FONT_DISABLE_POLICY
    {
        private static readonly Bitfield32 bfDisableNonSystemFonts = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfAuditNonSystemFontLoading = Bitfield32.SelectBits(1, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(30));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading non-system fonts;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool DisableNonSystemFonts
        {
            get => bfDisableNonSystemFonts.ReadBool(dwFlags);
            set => bfDisableNonSystemFonts.WriteBool(ref dwFlags, value);
        }

        /// <summary>
        /// Set to <see langword="true"/> to indicate that an Event Tracing for Windows (ETW) event should be logged when the process attempts to load a non-system font;
        /// leave unset (<see langword="false"/>) to indicate that an ETW event should not be logged.
        /// </summary>
        public bool AuditNonSystemFontLoading
        {
            get => bfAuditNonSystemFontLoading.ReadBool(dwFlags);
            set => bfAuditNonSystemFontLoading.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}
