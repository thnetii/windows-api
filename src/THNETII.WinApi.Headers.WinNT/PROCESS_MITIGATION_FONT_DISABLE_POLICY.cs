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
        private static readonly Bitfield32 bfDisableNonSystemFonts = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfAuditNonSystemFontLoading = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(30));

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
            get => bfDisableNonSystemFonts.Read(dwFlags) != 0;
            set => bfDisableNonSystemFonts.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to indicate that an Event Tracing for Windows (ETW) event should be logged when the process attempts to load a non-system font;
        /// leave unset (<see langword="false"/>) to indicate that an ETW event should not be logged.
        /// </summary>
        public bool AuditNonSystemFontLoading
        {
            get => bfAuditNonSystemFontLoading.Read(dwFlags) != 0;
            set => bfAuditNonSystemFontLoading.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
