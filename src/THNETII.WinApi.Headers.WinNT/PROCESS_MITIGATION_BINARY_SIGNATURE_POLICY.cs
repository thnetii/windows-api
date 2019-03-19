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
        private static readonly Bitfield32 bfMicrosoftSignedOnly = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfStoreSignedOnly = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfMitigationOptIn = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfAuditMicrosoftSignedOnly = Bitfield32.DefineMiddleBits(3, 1);
        private static readonly Bitfield32 bfAuditStoreSignedOnly = Bitfield32.DefineMiddleBits(4, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(27));

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
            get => bfMicrosoftSignedOnly.Read(dwFlags) != 0;
            set => bfMicrosoftSignedOnly.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that are not signed by the Windows Store;
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool StoreSignedOnly
        {
            get => bfStoreSignedOnly.Read(dwFlags) != 0;
            set => bfStoreSignedOnly.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from loading images that are not signed by Microsoft, the
        /// Windows Store and the Windows Hardware Quality Labs (WHQL);
        /// otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool MitigationOptIn
        {
            get => bfMitigationOptIn.Read(dwFlags) != 0;
            set => bfMitigationOptIn.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditMicrosoftSignedOnly
        {
            get => bfAuditMicrosoftSignedOnly.Read(dwFlags) != 0;
            set => bfAuditMicrosoftSignedOnly.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditStoreSignedOnly
        {
            get => bfAuditStoreSignedOnly.Read(dwFlags) != 0;
            set => bfAuditStoreSignedOnly.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
