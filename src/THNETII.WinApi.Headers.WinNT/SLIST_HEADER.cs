using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19163
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19204
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19220
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19231
    [StructLayout(LayoutKind.Explicit)]
    public struct SLIST_HEADER
    {
        [FieldOffset(0)]
        public ulong Alignment;
        [FieldOffset(sizeof(ulong))]
        public ulong Region;
        [FieldOffset(0)]
        public SLIST_HEADER_AMD64 HeaderX64;
        [FieldOffset(0)]
        public SLIST_HEADER_X86 HeaderX86;
        [FieldOffset(0)]
        public SLIST_HEADER_ARM HeaderArm;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct SLIST_HEADER_AMD64
    {
        internal ulong f1;
        internal ulong f2;
        private static readonly Bitfield64 BitfieldDepth = Bitfield64.LowBits(16);
        private static readonly Bitfield64 BitfieldSequence = Bitfield64.RemainingBits(16);
        private static readonly Bitfield64 BitfieldReserved = Bitfield64.LowBits(4);
        private static readonly Bitfield64 BitfieldNextEntry = Bitfield64.RemainingBits(60);
        public short Depth
        {
            get => (short)BitfieldDepth.Read(f1);
            set => BitfieldDepth.Write(ref f1, (ulong)value);
        }
        public ulong Sequence
        {
            get => BitfieldSequence.Read(f1);
            set => BitfieldSequence.Write(ref f1, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ulong Reserved
        {
            get => BitfieldReserved.Read(f2);
            set => BitfieldReserved.Write(ref f2, value);
        }
        public SLIST_ENTRY* NextEntry
        {
            get => (SLIST_ENTRY*)BitfieldNextEntry.ReadMasked(f2);
            set => BitfieldNextEntry.WriteMasked(ref f2, (ulong)value);
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct SLIST_HEADER_ARM64
    {
        internal ulong f1;
        internal ulong f2;
        private static readonly Bitfield64 BitfieldDepth = Bitfield64.LowBits(16);
        private static readonly Bitfield64 BitfieldSequence = Bitfield64.RemainingBits(16);
        private static readonly Bitfield64 BitfieldReserved = Bitfield64.LowBits(4);
        private static readonly Bitfield64 BitfieldNextEntry = Bitfield64.RemainingBits(60);
        public short Depth
        {
            get => (short)BitfieldDepth.Read(f1);
            set => BitfieldDepth.Write(ref f1, (ulong)value);
        }
        public ulong Sequence
        {
            get => BitfieldSequence.Read(f1);
            set => BitfieldSequence.Write(ref f1, value);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ulong Reserved
        {
            get => BitfieldReserved.Read(f2);
            set => BitfieldReserved.Write(ref f2, value);
        }
        public SLIST_ENTRY* NextEntry
        {
            get => (SLIST_ENTRY*)BitfieldNextEntry.ReadMasked(f2);
            set => BitfieldNextEntry.WriteMasked(ref f2, (ulong)value);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class SLIST_HEADER_X86
    {
        public SINGLE_LIST_ENTRY Next;
        public short Depth;
        public short CpuId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class SLIST_HEADER_ARM
    {
        public SINGLE_LIST_ENTRY Next;
        public short Depth;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved;
    }
}
