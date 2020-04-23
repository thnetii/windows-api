using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1066
    /// <summary>
    /// Calendar ID.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CALID : IEquatable<CALID>, IEquatable<int>
    {
        public CALID(int value) : this() => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => obj switch
        {
            int value => Equals(value),
            CALID other => Equals(other),
            null => false,
            _ => false
        };

        public bool Equals(CALID other) => Value.Equals(other.Value);

        public bool Equals(int other) => Value.Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(CALID left, CALID right) =>
            left.Equals(right);

        public static bool operator !=(CALID left, CALID right) =>
            !(left == right);

        public static bool operator ==(CALID left, int right) =>
            left.Equals(right);

        public static bool operator !=(CALID left, int right) =>
            !(left == right);

        public static bool operator ==(int left, CALID right) =>
            left.Equals(right.Value);

        public static bool operator !=(int left, CALID right) =>
            !(left == right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(CALID))]
        public static explicit operator CALID(int value) =>
            new CALID(value);


        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static implicit operator int(CALID CALID) => CALID.Value;
    }
}
