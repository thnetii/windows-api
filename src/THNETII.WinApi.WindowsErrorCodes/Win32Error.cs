using System.Runtime.InteropServices;

namespace THNETII.WinApi.WindowsErrorCodes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32Error
    {
        private readonly int value;

        public int AsInt32() => value;

        public Win32Error(int code) : this() => value = code;

        public Win32Error(uint code) : this(unchecked((int)code)) { }

        public static implicit operator Win32Error(int code) =>
            new Win32Error(code);

        public static implicit operator Win32Error(uint code) =>
            new Win32Error(code);

        public static explicit operator int(Win32Error e) => e.AsInt32();

        public override int GetHashCode() => value.GetHashCode();

        public static bool operator ==(Win32Error left, Win32Error right) =>
            left.value == right.value;

        public static bool operator !=(Win32Error left, Win32Error right) =>
            left.value != right.value;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Win32Error e: return this == e;
                case int code: return this == code;
                default: return false;
            }
        }

        public override string ToString() => $"0x{value:X8}";
    }
}
