using System;
using System.Diagnostics.CodeAnalysis;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    internal static class MultiStringHelper
    {
        internal static bool MoveNext<T>(ref IntPtr pointer, ref int? length,
            out Span<T> currentSpan)
            where T : struct, IEquatable<T>
        {
            if (pointer == IntPtr.Zero)
            {
                currentSpan = default;
                return false;
            }

            if (length.HasValue)
            {
                int lengthValue = length.Value;
                bool result = MoveNextInternal<T>(ref pointer, ref lengthValue,
                    out currentSpan);
                length = lengthValue;
                return result;
            }
            else
            {
                return MoveNextInternal<T>(ref pointer, out currentSpan);
            }
        }

        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        private static bool MoveNextInternal<T>(ref IntPtr pointer, ref int length,
            out Span<T> currentSpan)
            where T : struct, IEquatable<T>
        {
            if (length < 1 || (length == 1 && pointer.AsRefStruct<T>().Equals(default)))
            {
                length = 0;
                currentSpan = default;
                pointer = IntPtr.Zero;
                return false;
            }

            var remainingSpan = pointer.AsRefStructSpan<T>(length);
            var terminatorIdx = remainingSpan.IndexOf(default(T));
            currentSpan = terminatorIdx < 0 ? remainingSpan
                : remainingSpan.Slice(0, terminatorIdx);
            int consumed = currentSpan.Length + 1;
            length -= consumed;
            pointer += SizeOf<T>.Bytes * consumed;
            return true;
        }

        private static bool MoveNextInternal<T>(ref IntPtr pointer, out Span<T> currentSpan)
            where T : struct, IEquatable<T>
        {
            currentSpan = pointer.ToDefaultTerminatedSpan<T>();
            int consumed = currentSpan.Length + 1;
            var nextPointer = pointer + (SizeOf<T>.Bytes * consumed);
            if (currentSpan.IsEmpty)
            {
                pointer = IntPtr.Zero;
                return false;
            }
            else
            {
                pointer = nextPointer;
                return true;
            }
        }
    }
}
