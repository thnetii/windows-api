using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.WindowsErrorCodes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HRESULT
    {
        private readonly int value;

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
    }
}
