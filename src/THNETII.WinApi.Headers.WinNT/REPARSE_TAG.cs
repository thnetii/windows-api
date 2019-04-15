using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13103
    [StructLayout(LayoutKind.Sequential)]
    public struct REPARSE_TAG : IEquatable<REPARSE_TAG>, IEquatable<int>, IEquatable<uint>
    {
        private static readonly Bitfield32 MBitfield =
            Bitfield32.DefineFromMask(1U << 31);
        private static readonly Bitfield32 RBitfield =
            Bitfield32.DefineFromMask(1U << 30);
        private static readonly Bitfield32 NBitfield =
            Bitfield32.DefineFromMask(1U << 29);
        private static readonly Bitfield32 DBitfield =
            Bitfield32.DefineFromMask(1U << 28);
        private static readonly Bitfield32 ReservedBitfield =
            Bitfield32.DefineFromMask(Bitmask.OffsetBitsUInt32(16, 28 - 16));
        private static readonly Bitfield32 TagValueBitfield =
            Bitfield32.DefineLowerBits(16);

        private readonly uint value;

        public REPARSE_TAG(int value) : this()
        {
            this.value = (uint)value;
        }

        public REPARSE_TAG(uint value)
        {
            this.value = value;
        }

        public bool IsMicrosoftTag => MBitfield.Read(value) != 0;

        public bool IsReservedTag => RBitfield.Read(value) != 0;

        public bool IsNameSurrogate => NBitfield.Read(value) != 0;

        public bool IsDirectory => DBitfield.Read(value) != 0;

        public int ReservedBits => (int)ReservedBitfield.Read(value);

        public short TagValue => (short)TagValueBitfield.Read(value);

        public int AsInt32() => (int)value;

        public override int GetHashCode() => value.GetHashCode();

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case int i:
                    return Equals(i);
                case uint u:
                    return Equals(u);
                case REPARSE_TAG r:
                    return Equals(r);
                default:
                    return false;
            }
        }

        public bool Equals(int value) => this.value.Equals((uint)value);
        public bool Equals(uint value) => this.value.Equals(value);
        public bool Equals(REPARSE_TAG tag) => value.Equals(tag.value);

        public static bool operator ==(REPARSE_TAG tag, int value) =>
            tag.Equals(value);
        public static bool operator !=(REPARSE_TAG tag, int value) =>
            !tag.Equals(value);
        public static bool operator ==(int value, REPARSE_TAG tag) =>
            tag.Equals(value);
        public static bool operator !=(int value, REPARSE_TAG tag) =>
            !tag.Equals(value);
        public static bool operator ==(REPARSE_TAG tag, uint value) =>
            tag.Equals(value);
        public static bool operator !=(REPARSE_TAG tag, uint value) =>
            !tag.Equals(value);
        public static bool operator ==(uint value, REPARSE_TAG tag) =>
            tag.Equals(value);
        public static bool operator !=(uint value, REPARSE_TAG tag) =>
            !tag.Equals(value);
        public static bool operator ==(REPARSE_TAG left, REPARSE_TAG right) =>
            left.Equals(right);
        public static bool operator !=(REPARSE_TAG left, REPARSE_TAG right) =>
            !left.Equals(right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = "Constructor")]
        public static implicit operator REPARSE_TAG(int value) =>
            new REPARSE_TAG(value);
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = "Constructor")]
        public static implicit operator REPARSE_TAG(uint value) =>
            new REPARSE_TAG(value);
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(AsInt32))]
        public static explicit operator int(REPARSE_TAG tag) => tag.AsInt32();
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(AsInt32))]
        public static explicit operator uint(REPARSE_TAG tag) => tag.value;
    }
}
