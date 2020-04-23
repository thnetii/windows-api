using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1060
    /// <summary>
    /// Calendar type constant.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CALTYPE : IEquatable<CALTYPE>, IEquatable<int>
    {
        public CALTYPE(int value) : this() => Value = value;

        public int Value { get; }

        public override bool Equals(object obj) => obj switch
        {
            int value => Equals(value),
            CALTYPE other => Equals(other),
            null => false,
            _ => false
        };

        public bool Equals(CALTYPE other) => Value.Equals(other.Value);

        public bool Equals(int other) => Value.Equals(other);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(CALTYPE left, CALTYPE right) =>
            left.Equals(right);

        public static bool operator !=(CALTYPE left, CALTYPE right) =>
            !(left == right);

        public static bool operator ==(CALTYPE left, int right) =>
            left.Equals(right);

        public static bool operator !=(CALTYPE left, int right) =>
            !(left == right);

        public static bool operator ==(int left, CALTYPE right) =>
            left.Equals(right.Value);

        public static bool operator !=(int left, CALTYPE right) =>
            !(left == right);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(CALTYPE))]
        public static explicit operator CALTYPE(int value) =>
            new CALTYPE(value);


        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static implicit operator int(CALTYPE CALTYPE) => CALTYPE.Value;
    }
}
