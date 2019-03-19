using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

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
        private static readonly Bitfield32 bfNoRemoteImages = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfNoLowMandatoryLabelImages = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfPreferSystem32Images = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfAuditNoRemoteImages = Bitfield32.DefineMiddleBits(3, 1);
        private static readonly Bitfield32 bfAuditNoLowMandatoryLabelImages = Bitfield32.DefineMiddleBits(4, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(27));

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
            get => bfNoRemoteImages.Read(dwFlags) != 0;
            set => bfNoRemoteImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that have a Low mandatory label, as written by low IL;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool NoLowMandatoryLabelImages
        {
            get => bfNoLowMandatoryLabelImages.Read(dwFlags) != 0;
            set => bfNoLowMandatoryLabelImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to search for images to load in the System32 subfolder of the folder in which
        /// Windows is installed first, then in the application directory in the standard DLL search order;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool PreferSystem32Images
        {
            get => bfPreferSystem32Images.Read(dwFlags) != 0;
            set => bfPreferSystem32Images.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditNoRemoteImages
        {
            get => bfAuditNoRemoteImages.Read(dwFlags) != 0;
            set => bfAuditNoRemoteImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditNoLowMandatoryLabelImages
        {
            get => bfAuditNoLowMandatoryLabelImages.Read(dwFlags) != 0;
            set => bfAuditNoLowMandatoryLabelImages.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
