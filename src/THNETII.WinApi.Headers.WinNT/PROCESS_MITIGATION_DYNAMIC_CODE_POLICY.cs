using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11585
    /// <summary>
    /// Contains process mitigation policy settings for restricting dynamic code generation and modification.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_dynamic_code_policy">PROCESS_MITIGATION_DYNAMIC_CODE_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_DYNAMIC_CODE_POLICY
    {
        private static readonly Bitfield32 bfProhibitDynamicCode = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfAllowThreadOptOut = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfAllowRemoteDowngrade = Bitfield32.DefineMiddleBits(2, 1);
        private static readonly Bitfield32 bfAuditProhibitDynamicCode = Bitfield32.DefineMiddleBits(3, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(28));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        /// <summary>
        /// Set to <see langword="true"/> to prevent the process from generating
        /// dynamic code or modifying existing executable code; otherwise leave unset (<see langword="false"/>).
        /// </summary>
        public bool ProhibitDynamicCode
        {
            get => bfProhibitDynamicCode.Read(dwFlags) != 0;
            set => bfProhibitDynamicCode.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to allow threads to opt out of the restrictions on dynamic code generation by calling
        /// the <see cref="SetThreadInformation"/> function with the <em>ThreadInformation</em> parameter set to
        /// <see cref="ThreadDynamicCodePolicy"/>; otherwise leave unset (<see langword="false"/>). You should not use the
        /// <see cref="AllowThreadOptOut"/> and <see cref="ThreadDynamicCodePolicy"/> settings together to provide strong
        /// security. These settings are only intended to enable applications to adapt their code more
        /// easily for full dynamic code restrictions.
        /// </summary>
        public bool AllowThreadOptOut
        {
            get => bfAllowThreadOptOut.Read(dwFlags) != 0;
            set => bfAllowThreadOptOut.Write(ref dwFlags, value ? 1U : 0U);
        }

        /// <summary>
        /// Set to <see langword="true"/> to allow non-AppContainer processes to modify all of the dynamic code settings for
        /// the calling process, including relaxing dynamic code restrictions after they have been set.
        /// </summary>
        public bool AllowRemoteDowngrade
        {
            get => bfAllowRemoteDowngrade.Read(dwFlags) != 0;
            set => bfAllowRemoteDowngrade.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditProhibitDynamicCode
        {
            get => bfAuditProhibitDynamicCode.Read(dwFlags) != 0;
            set => bfAuditProhibitDynamicCode.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
