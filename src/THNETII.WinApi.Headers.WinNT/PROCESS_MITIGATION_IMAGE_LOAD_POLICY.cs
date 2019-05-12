using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11610
    /// <summary>
    /// Contains process mitigation policy settings for the loading of images from a remote device.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_image_load_policy">PROCESS_MITIGATION_IMAGE_LOAD_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="GetProcessMitigationPolicy"/>
    /// <seealso cref="SetProcessMitigationPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_IMAGE_LOAD_POLICY
    {
        private static readonly Bitfield32 bfNoRemoteImages = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfNoLowMandatoryLabelImages = Bitfield32.SelectBits(1, 1);
        private static readonly Bitfield32 bfPreferSystem32Images = Bitfield32.SelectBits(2, 1);
        private static readonly Bitfield32 bfAuditNoRemoteImages = Bitfield32.SelectBits(3, 1);
        private static readonly Bitfield32 bfAuditNoLowMandatoryLabelImages = Bitfield32.SelectBits(4, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(27));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images from a remote device, such as a UNC share;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool NoRemoteImages
        {
            get => bfNoRemoteImages.ReadBool(dwFlags);
            set => bfNoRemoteImages.WriteBool(ref dwFlags, value);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that have a Low mandatory label, as written by low IL;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool NoLowMandatoryLabelImages
        {
            get => bfNoLowMandatoryLabelImages.ReadBool(dwFlags);
            set => bfNoLowMandatoryLabelImages.WriteBool(ref dwFlags, value);
        }

        /// <summary>
        /// Set to <see langword="true"/> to search for images to load in the System32 subfolder of the folder in which
        /// Windows is installed first, then in the application directory in the standard DLL search order;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool PreferSystem32Images
        {
            get => bfPreferSystem32Images.ReadBool(dwFlags);
            set => bfPreferSystem32Images.WriteBool(ref dwFlags, value);
        }

        public bool AuditNoRemoteImages
        {
            get => bfAuditNoRemoteImages.ReadBool(dwFlags);
            set => bfAuditNoRemoteImages.WriteBool(ref dwFlags, value);
        }

        public bool AuditNoLowMandatoryLabelImages
        {
            get => bfAuditNoLowMandatoryLabelImages.ReadBool(dwFlags);
            set => bfAuditNoLowMandatoryLabelImages.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}
