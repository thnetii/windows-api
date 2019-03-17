using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE_T : IEquatable<SIZE_T>, IEquatable<uint>, IEquatable<ulong>
    {
        private readonly UIntPtr v;

        public UIntPtr ToUIntPtr() => v;

        public uint ToUInt32() => v.ToUInt32();

        public ulong ToUInt64() => v.ToUInt64();

        public override int GetHashCode() =>
            v.GetHashCode();

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case SIZE_T other:
                    return Equals(other);
                case uint other:
                    return Equals(other);
                case ulong other:
                    return Equals(other);
                default:
                    return false;
            }
        }

        public bool Equals(SIZE_T other) => v == other.v;

        public bool Equals(uint other) => v == new UIntPtr(other);

        public bool Equals(ulong other) => v == new UIntPtr(other);

        public override string ToString() => v.ToString();

        public SIZE_T(UIntPtr value) => v = value;
        public SIZE_T(uint value) => v = new UIntPtr(value);
        public SIZE_T(ulong value) => v = new UIntPtr(value);

        public static SIZE_T operator +(SIZE_T left, SIZE_T right) =>
            new SIZE_T(left.v.ToUInt64() + right.v.ToUInt64());
        public static SIZE_T operator +(SIZE_T left, int right) =>
            new SIZE_T(left.v + right);
        public static SIZE_T operator +(SIZE_T left, uint right) =>
            new SIZE_T(left.v.ToUInt64() + right);
        public static SIZE_T operator +(SIZE_T left, ulong right) =>
            new SIZE_T(left.v.ToUInt64() + right);
        public static SIZE_T operator +(int left, SIZE_T right) =>
            new SIZE_T(right.v + left);
        public static SIZE_T operator +(uint left, SIZE_T right) =>
            new SIZE_T(right.v.ToUInt64() + left);
        public static SIZE_T operator +(ulong left, SIZE_T right) =>
            new SIZE_T(right.v.ToUInt64() + left);

        public static SIZE_T Add(SIZE_T left, SIZE_T right) =>
            left + right;
        public static SIZE_T Add(SIZE_T left, int right) =>
            left + right;
        public static SIZE_T Add(SIZE_T left, uint right) =>
            left + right;
        public static SIZE_T Add(SIZE_T left, ulong right) =>
            left + right;

        public static SIZE_T operator -(SIZE_T left, SIZE_T right) =>
            new SIZE_T(left.v.ToUInt64() - right.v.ToUInt64());
        public static SIZE_T operator -(SIZE_T left, int right) =>
            new SIZE_T(left.v - right);
        public static SIZE_T operator -(SIZE_T left, uint right) =>
            new SIZE_T(left.v.ToUInt64() - right);
        public static SIZE_T operator -(SIZE_T left, ulong right) =>
            new SIZE_T(left.v.ToUInt64() - right);
        public static SIZE_T operator -(int left, SIZE_T right) =>
            new SIZE_T(right.v - left);
        public static SIZE_T operator -(uint left, SIZE_T right) =>
            new SIZE_T(right.v.ToUInt64() - left);
        public static SIZE_T operator -(ulong left, SIZE_T right) =>
            new SIZE_T(right.v.ToUInt64() - left);

        public static SIZE_T Subtract(SIZE_T left, SIZE_T right) =>
            left - right;
        public static SIZE_T Subtract(SIZE_T left, int right) =>
            left - right;
        public static SIZE_T Subtract(SIZE_T left, uint right) =>
            left - right;
        public static SIZE_T Subtract(SIZE_T left, ulong right) =>
            left - right;

        public static bool operator ==(SIZE_T left, SIZE_T right) =>
            left.Equals(right);
        public static bool operator ==(SIZE_T left, uint right) =>
            left.Equals(right);
        public static bool operator ==(SIZE_T left, ulong right) =>
            left.Equals(right);
        public static bool operator ==(uint left, SIZE_T right) =>
            right.Equals(left);
        public static bool operator ==(ulong left, SIZE_T right) =>
            right.Equals(left);

        public static bool operator !=(SIZE_T left, SIZE_T right) =>
            !left.Equals(right);
        public static bool operator !=(SIZE_T left, uint right) =>
            !left.Equals(right);
        public static bool operator !=(SIZE_T left, ulong right) =>
            !left.Equals(right);
        public static bool operator !=(uint left, SIZE_T right) =>
            !right.Equals(left);
        public static bool operator !=(ulong left, SIZE_T right) =>
            !right.Equals(left);

        public static explicit operator UIntPtr (SIZE_T size_t) =>
            size_t.v;
        public static explicit operator uint(SIZE_T size_t) =>
            (uint)size_t.v;
        public static implicit operator ulong(SIZE_T size_t) =>
            (ulong)size_t.v;

        public static explicit operator SIZE_T(UIntPtr value) =>
            new SIZE_T(value);
        public static explicit operator SIZE_T(uint value) =>
            new SIZE_T(value);
        public static implicit operator SIZE_T(ulong value) =>
            new SIZE_T(value);

        public static SIZE_T FromUIntPtr(UIntPtr value) =>
            new SIZE_T(value);
        public static SIZE_T FromUInt32(uint value) =>
            new SIZE_T(value);
        public static SIZE_T FromUInt64(ulong value) =>
            new SIZE_T(value);
    }
}
