using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinBase
{
    using static WinBaseConstants;

    [StructLayout(LayoutKind.Sequential)]
    [DebuggerDisplay(nameof(DebuggerDisplay) + "()")]
    public struct FORMAT_MESSAGE_OPTIONS : IEquatable<FORMAT_MESSAGE_OPTIONS>, IEquatable<int>, IEquatable<FORMAT_MESSAGE_FLAGS>
    {
        private static readonly Bitfield32 width_field = Bitfield32.FromMask(FORMAT_MESSAGE_MAX_WIDTH_MASK);
        private static readonly Bitfield32 flags_field = Bitfield32.FromMask(width_field.InverseMask);

        internal int dwFlags;

        public int Width
        {
            get => width_field.Read(dwFlags);
            set => width_field.Write(ref dwFlags, value);
        }

        public FORMAT_MESSAGE_FLAGS Flags
        {
            get => (FORMAT_MESSAGE_FLAGS)flags_field.Read(dwFlags);
            set => flags_field.Write(ref dwFlags, (int)value);
        }

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static explicit operator int(FORMAT_MESSAGE_OPTIONS options) =>
            options.dwFlags;

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static explicit operator FORMAT_MESSAGE_OPTIONS(int dwFlags) =>
            new FORMAT_MESSAGE_OPTIONS(dwFlags);

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static implicit operator FORMAT_MESSAGE_OPTIONS(FORMAT_MESSAGE_FLAGS dwFlags) =>
            new FORMAT_MESSAGE_OPTIONS(dwFlags);

        public FORMAT_MESSAGE_OPTIONS(int dwFlags) => this.dwFlags = dwFlags;

        public FORMAT_MESSAGE_OPTIONS(FORMAT_MESSAGE_FLAGS dwFlags) : this((int)dwFlags) { }

        public override int GetHashCode() => dwFlags.GetHashCode();

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null: return false;
                case FORMAT_MESSAGE_OPTIONS options: return dwFlags == options.dwFlags;
                case int dwFlags: return this.dwFlags == dwFlags;
                case FORMAT_MESSAGE_FLAGS dwFlags: return this.dwFlags == (int)dwFlags;
                default: return false;
            }
        }

        public bool Equals(FORMAT_MESSAGE_OPTIONS options) => dwFlags == options.dwFlags;

        public bool Equals(int dwFlags) => this.dwFlags == dwFlags;

        public bool Equals(FORMAT_MESSAGE_FLAGS dwFlags) => this.dwFlags == (int)dwFlags;

        public static bool operator ==(FORMAT_MESSAGE_OPTIONS left, FORMAT_MESSAGE_OPTIONS right) =>
            left.Equals(right);

        public static bool operator ==(FORMAT_MESSAGE_OPTIONS left, int right) =>
            left.Equals(right);

        public static bool operator ==(FORMAT_MESSAGE_OPTIONS left, FORMAT_MESSAGE_FLAGS right) =>
            left.Equals(right);

        public static bool operator ==(int left, FORMAT_MESSAGE_OPTIONS right) =>
            right.Equals(left);

        public static bool operator ==(FORMAT_MESSAGE_FLAGS left, FORMAT_MESSAGE_OPTIONS right) =>
            right.Equals(left);

        public static bool operator !=(FORMAT_MESSAGE_OPTIONS left, FORMAT_MESSAGE_OPTIONS right) =>
            !left.Equals(right);

        public static bool operator !=(FORMAT_MESSAGE_OPTIONS left, int right) =>
            !left.Equals(right);

        public static bool operator !=(FORMAT_MESSAGE_OPTIONS left, FORMAT_MESSAGE_FLAGS right) =>
            !left.Equals(right);

        public static bool operator !=(int left, FORMAT_MESSAGE_OPTIONS right) =>
            !right.Equals(left);

        public static bool operator !=(FORMAT_MESSAGE_FLAGS left, FORMAT_MESSAGE_OPTIONS right) =>
            !right.Equals(left);

        private string DebuggerDisplay() => $"{nameof(FORMAT_MESSAGE_OPTIONS)}({nameof(Flags)}: {Flags}; {nameof(Width)}: {Width})";
    }
}
