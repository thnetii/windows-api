using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Helpers
{
    /// <summary>
    /// Provides helper methods to operate on native byte-buffers that contain string data.
    /// </summary>
    public static class FixedStringBuffer
    {
        /// <summary>
        /// Decodes the specified byte-buffer to a managed <see cref="string"/> value using
        /// the specified encoding.
        /// </summary>
        /// <param name="bytes">A pointer to the first byte in the byte-buffer. This pointer should be a pointer that is initialized using a <see langword="fixed"/> block.</param>
        /// <param name="maxLength">The maximum length of the buffer pointed to by <paramref name="bytes"/>.</param>
        /// <param name="encoding">The text-encoding to use to decode the string stored in <paramref name="bytes"/>.</param>
        /// <returns>An <see cref="string"/> containing a copy of the data pointed to by <paramref name="bytes"/>.</returns>
        /// <remarks>
        /// The returned string can be at most <paramref name="maxLength"/> characters long.
        /// A null-terminating byte within the buffer will be interpreted as the end of the string.
        /// </remarks>
        public static unsafe string ToStringZeroTerminated(byte* bytes, int maxLength, Encoding encoding)
        {
            Span<byte> byteSpan = new Span<byte>(bytes, maxLength);
            int len = byteSpan.IndexOf((byte)0);
            if (len < 0)
                len = maxLength;
            return encoding.GetString(bytes, len);
        }
        /// <summary>
        /// Encodes the specified <see cref="string"/> value into a fixed-sized byte-buffer
        /// using the specified encoding.
        /// </summary>
        /// <param name="str">The <see cref="string"/> to encode. Can be <see langword="null"/>.</param>
        /// <param name="bytes">A pointer to the start of the destination buffer.</param>
        /// <param name="maxLength">The maximum length of the buffer pointed to by <paramref name="bytes"/>.</param>
        /// <param name="encoding">The text-encoding to use to encode <paramref name="str"/>.</param>
        /// <remarks>
        /// At the most, only <paramref name="maxLength"/> characters will be encoded.
        /// If there is at least one byte remaining at the end of the encoded string, a null-terminating byte will be appended.
        /// </remarks>
        public static unsafe void ToBytesZeroTerminated(string str, byte* bytes, int maxLength, Encoding encoding)
        {
            string s = str ?? string.Empty;
            fixed (char* chs = s)
            {
                int cnt = encoding.GetBytes(chs, s.Length, bytes, maxLength);
                if (cnt < maxLength)
                    bytes[cnt] = 0;
            }
        }

        /// <seealso cref="Marshal.PtrToStringAnsi(IntPtr)"/>
        public static unsafe string MarshalAnsiString(byte* bytes)
        {
            IntPtr ptr = new IntPtr(bytes);
            return Marshal.PtrToStringAnsi(ptr);
        }
        /// <seealso cref="Marshal.PtrToStringAnsi(IntPtr)"/>
        public static unsafe string MarshalAnsiString(ref byte firstByte)
        {
            fixed (byte* bytes = &firstByte)
            {
                return MarshalAnsiString(bytes);
            }
        }
        /// <seealso cref="Marshal.PtrToStringAnsi(IntPtr, int)"/>
        public static unsafe string MarshalAnsiString(byte* bytes, int length)
        {
            IntPtr ptr = new IntPtr(bytes);
            return Marshal.PtrToStringAnsi(ptr, length);
        }
        /// <seealso cref="Marshal.PtrToStringAnsi(IntPtr, int)"/>
        public static unsafe string MarshalAnsiString(ref byte firstByte, int length)
        {
            fixed (byte* bytes = &firstByte)
            {
                return MarshalAnsiString(bytes, length);
            }
        }

        /// <seealso cref="Marshal.StringToCoTaskMemAnsi(string)"/>
        /// <seealso cref="ToBytesZeroTerminated(string, byte*, int, Encoding)"/>
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
        /// <seealso cref="Marshal.StringToCoTaskMemAnsi(string)"/>
        /// <seealso cref="ToBytesZeroTerminated(string, byte*, int, Encoding)"/>
        public static unsafe void MarshalAnsiBytes(string str, ref byte firstByte, int maxLength)
        {
            fixed (byte* bytes = &firstByte)
                MarshalAnsiBytes(str, bytes, maxLength);
        }
    }
}
