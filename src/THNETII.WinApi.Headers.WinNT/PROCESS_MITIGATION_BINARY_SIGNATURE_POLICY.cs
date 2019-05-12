using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11610
    /// <summary>
    /// Contains process mitigation policy settings for the loading of images depending on the signatures for the image.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_binary_signature_policy">PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY structure</a></para>
    /// </remarks>
    /// <seealso cref="GetProcessMitigationPolicy"/>
    /// <seealso cref="SetProcessMitigationPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY
    {
        private static readonly Bitfield32 bfMicrosoftSignedOnly = Bitfield32.LowBits(1);
        private static readonly Bitfield32 bfStoreSignedOnly = Bitfield32.SelectBits(1, 1);
        private static readonly Bitfield32 bfMitigationOptIn = Bitfield32.SelectBits(2, 1);
        private static readonly Bitfield32 bfAuditMicrosoftSignedOnly = Bitfield32.SelectBits(3, 1);
        private static readonly Bitfield32 bfAuditStoreSignedOnly = Bitfield32.SelectBits(4, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(27));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that are not signed by Microsoft;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool MicrosoftSignedOnly
        {
            get => bfMicrosoftSignedOnly.ReadBool(dwFlags);
            set => bfMicrosoftSignedOnly.WriteBool(ref dwFlags, value);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that are not signed by the Windows Store;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool StoreSignedOnly
        {
            get => bfStoreSignedOnly.ReadBool(dwFlags);
            set => bfStoreSignedOnly.WriteBool(ref dwFlags, value);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that are not signed by Microsoft, the
        /// Windows Store and the Windows Hardware Quality Labs (WHQL);
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool MitigationOptIn
        {
            get => bfMitigationOptIn.ReadBool(dwFlags);
            set => bfMitigationOptIn.WriteBool(ref dwFlags, value);
        }

        public bool AuditMicrosoftSignedOnly
        {
            get => bfAuditMicrosoftSignedOnly.ReadBool(dwFlags);
            set => bfAuditMicrosoftSignedOnly.WriteBool(ref dwFlags, value);
        }

        public bool AuditStoreSignedOnly
        {
            get => bfAuditStoreSignedOnly.ReadBool(dwFlags);
            set => bfAuditStoreSignedOnly.WriteBool(ref dwFlags, value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.ReadMasked(dwFlags);
            set => bfReservedFlags.WriteMasked(ref dwFlags, (uint)value);
        }
    }
}
