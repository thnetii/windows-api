using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11686
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_CHILD_PROCESS_POLICY
    {
        private static readonly Bitfield32 bfNoChildProcessCreation = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfAuditNoChildProcessCreation = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfAllowSecureProcessCreation = Bitfield32.DefineMiddleBits(2, 1);

        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(29));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool NoChildProcessCreation
        {
            get => bfNoChildProcessCreation.Read(dwFlags) != 0;
            set => bfNoChildProcessCreation.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditNoChildProcessCreation
        {
            get => bfAuditNoChildProcessCreation.Read(dwFlags) != 0;
            set => bfAuditNoChildProcessCreation.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AllowSecureProcessCreation
        {
            get => bfAllowSecureProcessCreation.Read(dwFlags) != 0;
            set => bfAllowSecureProcessCreation.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
