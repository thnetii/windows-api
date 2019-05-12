using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Helpers
{
    public static class FixedStringBuffer
    {
        public static unsafe string ToString(byte* bytes, int maxLength, Encoding encoding)
        {
            Span<byte> byteSpan = new Span<byte>(bytes, maxLength);
            int len = byteSpan.IndexOf((byte)0);
            if (len < 0)
                len = maxLength;
            return encoding.GetString(bytes, len);
        }
        public static unsafe void ToBytes(string str, byte* bytes, int maxLength, Encoding encoding)
        {
            string s = str ?? string.Empty;
            fixed (char* chs = s)
            {
                int cnt = encoding.GetBytes(chs, s.Length, bytes, maxLength);
                if (cnt < maxLength)
                    bytes[cnt] = 0;
            }
        }

        public static unsafe string MarshalAnsiString(byte* bytes)
        {
            IntPtr ptr = new IntPtr(bytes);
            return Marshal.PtrToStringAnsi(ptr);
        }
        public static unsafe string MarshalAnsiString(ref byte firstByte)
        {
            fixed (byte* bytes = &firstByte)
            {
                return MarshalAnsiString(bytes);
            }
        }
        public static unsafe string MarshalAnsiString(byte* bytes, int length)
        {
            IntPtr ptr = new IntPtr(bytes);
            return Marshal.PtrToStringAnsi(ptr, length);
        }
        public static unsafe string MarshalAnsiString(ref byte firstByte, int length)
        {
            fixed (byte* bytes = &firstByte)
            {
                return MarshalAnsiString(bytes, length);
            }
        }

        [SuppressMessage("Usage", "PC001: API not supported on all platforms", Justification = "https://github.com/dotnet/platform-compat/issues/123")]
        public static unsafe void MarshalAnsiBytes(string str, byte* bytes, int maxLength)
        {
            Span<byte> byteSpan = new Span<byte>(bytes, maxLength);
            if (str is null)
            {
                byteSpan.Fill(0);
                return;
            }

            var pStr = Marshal.StringToCoTaskMemAnsi(str);
            try
            {
                var valueSpan = new Span<byte>(pStr.ToPointer(), maxLength);
                int endIdx = valueSpan.IndexOf((byte)0);
                if (endIdx >= 0)
                    valueSpan = valueSpan.Slice(start: 0, length: endIdx + 1);
                valueSpan.CopyTo(byteSpan);
            }
            finally
            {
                Marshal.FreeCoTaskMem(pStr);
            }
        }
        public static unsafe void MarshalAnsiBytes(string str, ref byte firstByte, int maxLength)
        {
            fixed (byte* bytes = &firstByte)
                MarshalAnsiBytes(str, bytes, maxLength);
        }
    }
}
