using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.WindowsErrorCodes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HRESULT
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(16, 11);
        private static readonly Bitfield32 msgid_bit = Bitfield32.DefineSingleBit(27);
        private static readonly Bitfield32 nt_bit = Bitfield32.DefineSingleBit(28);
        private static readonly Bitfield32 c_bit = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 s_bit = Bitfield32.DefineSingleBit(31);
        private static readonly Bitfield32 sev_field = Bitfield32.DefineRemainingBits(30);

        private readonly int value;

        public int Value => value;

        public int Code => code_field.Read(value);

        public Win32Facility Facility => (Win32Facility)facility_field.Read(value);

        public bool IsMessageId => msgid_bit.Read(value) != 0;

        public bool IsNTMapped => nt_bit.Read(value) != 0;

        public bool IsCustomerCode => c_bit.Read(value) != 0;

        public bool IsSuccess => s_bit.Read(value) == 0;

        public bool IsFailure => s_bit.Read(value) != 0;

        public StatusSeverity NTStatusSeverity => (StatusSeverity)sev_field.Read(value);

        public ComSeverity Severity => (ComSeverity)s_bit.Read(value);

        public int AsInt32() => value;

        public Exception GetException() => Marshal.GetExceptionForHR(value);

        public HRESULT(int code) : this() => value = code;

        public HRESULT(uint code) : this(unchecked((int)code)) { }

        public static implicit operator HRESULT(int code) =>
            new HRESULT(code);

        public static implicit operator HRESULT(uint code) =>
            new HRESULT(code);

        public static explicit operator int(HRESULT e) => e.AsInt32();

        public override int GetHashCode() => value.GetHashCode();

        public static bool operator ==(HRESULT left, HRESULT right) =>
            left.value == right.value;

        public static bool operator !=(HRESULT left, HRESULT right) =>
            left.value != right.value;

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case HRESULT hr: return this == hr;
                case int code: return this == code;
                default: return false;
            }
        }

        public override string ToString() => $"0x{value:X8}";

        public static explicit operator HRESULT(Win32ErrorCode x)
        {
            int hr = default;
            code_field.Write(ref hr, x.Code);
            facility_field.Write(ref hr, (int)Win32Facility.Win32);
            s_bit.Write(ref hr, 1);
            return new HRESULT(hr);
        }
    }
}
