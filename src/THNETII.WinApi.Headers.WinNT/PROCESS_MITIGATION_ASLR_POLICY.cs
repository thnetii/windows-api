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
        private static readonly Bitfield32 bfEnableBottomUpRandomization = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfEnableForceRelocateImages = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfEnableHighEntropy = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfDisallowStrippedImages = Bitfield32.DefineMiddleBits(3, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(28));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool EnableBottomUpRandomization
        {
            get => bfEnableBottomUpRandomization.Read(dwFlags) != 0;
            set => bfEnableBottomUpRandomization.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool EnableForceRelocateImages
        {
            get => bfEnableForceRelocateImages.Read(dwFlags) != 0;
            set => bfEnableForceRelocateImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// High entropy mode is read only and can only be set at creation time
        /// and not via the ProcessMitigationPolicy APIs.
        /// </summary>
        public bool EnableHighEntropy
        {
            get => bfEnableHighEntropy.Read(dwFlags) != 0;
            set => bfEnableHighEntropy.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool DisallowStrippedImages
        {
            get => bfDisallowStrippedImages.Read(dwFlags) != 0;
            set => bfDisallowStrippedImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
