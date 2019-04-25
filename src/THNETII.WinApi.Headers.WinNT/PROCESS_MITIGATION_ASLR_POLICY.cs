using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11528
    /// <summary>
    /// Contains process mitigation policy settings for Address Space Randomization Layout (ASLR).
    /// The <see cref="GetProcessMitigationPolicy"/> and <see cref="SetProcessMitigationPolicy"/> functions use this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_aslr_policy">PROCESS_MITIGATION_ASLR_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_ASLR_POLICY
    {
        private static readonly Bitfield32 bfEnableBottomUpRandomization = Bitfield32.Bit(0);
        private static readonly Bitfield32 bfEnableForceRelocateImages = Bitfield32.Bit(1);
        private static readonly Bitfield32 bfEnableHighEntropy = Bitfield32.Bit(2);
        private static readonly Bitfield32 bfDisallowStrippedImages = Bitfield32.Bit(3);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.RemainingBits(4);

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool EnableBottomUpRandomization
        {
            get => bfEnableBottomUpRandomization.ReadMasked(dwFlags) != 0;
            set => bfEnableBottomUpRandomization.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool EnableForceRelocateImages
        {
            get => bfEnableForceRelocateImages.ReadMasked(dwFlags) != 0;
            set => bfEnableForceRelocateImages.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        /// <summary>
        /// High entropy mode is read only and can only be set at creation time
        /// and not via the ProcessMitigationPolicy APIs.
        /// </summary>
        public bool EnableHighEntropy
        {
            get => bfEnableHighEntropy.ReadMasked(dwFlags) != 0;
            set => bfEnableHighEntropy.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        public bool DisallowStrippedImages
        {
            get => bfDisallowStrippedImages.ReadMasked(dwFlags) != 0;
            set => bfDisallowStrippedImages.WriteMasked(ref dwFlags, value ? ~0U : 0U);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}
