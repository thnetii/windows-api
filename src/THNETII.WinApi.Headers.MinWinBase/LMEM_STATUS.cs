using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

using static THNETII.WinApi.Native.MinWinBase.MinWinBaseConstants;

namespace THNETII.WinApi.Native.MinWinBase
{
    [StructLayout(LayoutKind.Sequential), DebuggerDisplay(nameof(DebuggerDisplay) + "()")]
    public struct LMEM_STATUS : IEquatable<LMEM_STATUS>, IEquatable<int>
    {
        private static readonly Bitfield32 isinvalid = Bitfield32.FromMask(LMEM_INVALID_HANDLE);
        private static readonly Bitfield32 discarded = Bitfield32.FromMask(LMEM_DISCARDED);
        private static readonly Bitfield32 lockcount = Bitfield32.FromMask(LMEM_LOCKCOUNT);

        private readonly int value;

        public LMEM_STATUS(int value) : this() => this.value = value;

        public int LockCount => lockcount.Read(value);

        public bool IsDiscarded => discarded.ReadMasked(value) != 0;

        public bool IsInvalid => isinvalid.ReadMasked(value) != 0;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case int value: return this == value;
                case LMEM_STATUS status: return this == status;
            }
            return false;
        }

        public bool Equals(LMEM_STATUS status) => this == status;

        public bool Equals(int value) => this == value;

        public override int GetHashCode() => value.GetHashCode();

        public static bool operator ==(LMEM_STATUS a, LMEM_STATUS b) =>
            a.value == b.value;

        public static bool operator !=(LMEM_STATUS a, LMEM_STATUS b) =>
            a.value != b.value;

        public static bool operator ==(LMEM_STATUS status, int value) =>
            status.value == value;

        public static bool operator !=(LMEM_STATUS status, int value) =>
            status.value != value;

        public static bool operator ==(int value, LMEM_STATUS status) =>
            status.value == value;

        public static bool operator !=(int value, LMEM_STATUS status) =>
            status.value != value;

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static explicit operator int(LMEM_STATUS status) => status.value;

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static explicit operator LMEM_STATUS(int value) => new LMEM_STATUS(value);

        private string DebuggerDisplay()
        {
            string str = FormattableString.Invariant($"{nameof(LockCount)} = {LockCount}");
            if (IsDiscarded)
                str += FormattableString.Invariant($", {nameof(LMEM_DISCARDED)}");
            if (IsInvalid)
                str += FormattableString.Invariant($", {nameof(LMEM_INVALID_HANDLE)}");
            str += FormattableString.Invariant($", Value = 0x{value:X4}");
            return str;
        }
    }
}
