using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.WindowsErrorCodes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32ErrorCode
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(16, 12);
        private static readonly Bitfield32 customer_flag = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 severity_field = Bitfield32.DefineRemainingBits(30);

        private readonly int value;

        public int Value => value;

        public int Code => code_field.Read(value);

        public Win32Facility Facility => (Win32Facility)facility_field.Read(value);

        public bool IsCustomerCode => customer_flag.Read(value) != 0;

        public StatusSeverity Severity => (StatusSeverity)severity_field.Read(value);

        public int AsInt32() => value;

        public Win32ErrorCode(int code) : this() => value = code;

        public Win32ErrorCode(uint code) : this(unchecked((int)code)) { }

        public static implicit operator Win32ErrorCode(int code) =>
            new Win32ErrorCode(code);

        public static implicit operator Win32ErrorCode(uint code) =>
            new Win32ErrorCode(code);

        public static explicit operator int(Win32ErrorCode e) => e.AsInt32();

        public override int GetHashCode() => value.GetHashCode();

        public static bool operator ==(Win32ErrorCode left, Win32ErrorCode right) =>
            left.value == right.value;

        public static bool operator !=(Win32ErrorCode left, Win32ErrorCode right) =>
            left.value != right.value;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Win32ErrorCode e: return this == e;
                case int code: return this == code;
                default: return false;
            }
        }

        public override string ToString() => $"0x{value:X8}";
    }
}
