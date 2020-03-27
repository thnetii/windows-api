using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11649
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_SYSTEM_CALL_FILTER_POLICY
    {
        private static readonly Bitfield32 bfFilterId = Bitfield32.LowBits(4);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.FromMask(Bitmask.HigherBitsUInt32(28));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public int FilterId
        {
            get => (int)bfFilterId.Read(dwFlags);
            set => bfFilterId.Write(ref dwFlags, (uint)value);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}
