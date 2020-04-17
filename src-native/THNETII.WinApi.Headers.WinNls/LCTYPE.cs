using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1055
    /// <summary>
    /// Locale type constant.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LCTYPE : IEquatable<LCTYPE>, IEquatable<int>
    {
        public LCTYPE(int value) : this() => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => obj switch
        {
            int value => Equals(value),
            LCTYPE other => Equals(other),
            null => false,
            _ => false
        };

        public bool Equals(LCTYPE other) => Value.Equals(other.Value);

        public bool Equals(int other) => Value.Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(LCTYPE left, LCTYPE right) =>
            left.Equals(right);

        public static bool operator !=(LCTYPE left, LCTYPE right) =>
            !(left == right);

        public static bool operator ==(LCTYPE left, int right) =>
            left.Equals(right);

        public static bool operator !=(LCTYPE left, int right) =>
            !(left == right);

        public static bool operator ==(int left, LCTYPE right) =>
            left.Equals(right.Value);

        public static bool operator !=(int left, LCTYPE right) =>
            !(left == right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(LCTYPE))]
        public static explicit operator LCTYPE(int value) =>
            new LCTYPE(value);


        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static implicit operator int(LCTYPE LCTYPE) => LCTYPE.Value;
    }
}
