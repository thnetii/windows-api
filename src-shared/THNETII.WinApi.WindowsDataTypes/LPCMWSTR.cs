using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a constant multiple null-terminated string of 16-bit Unicode characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPCMWSTR : IConstTerminatedUnicodeStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }

        public MultiStringEnumerable AsEnumerable(int? length = null) =>
            new MultiStringEnumerable(Pointer, length);

        public readonly ref struct MultiStringEnumerable
        {
            private readonly IntPtr pointer;
            private readonly int? length;

            public MultiStringEnumerable(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            public MultiStringEnumerator GetEnumerator() =>
                new MultiStringEnumerator(pointer, length);
        }

        public ref struct MultiStringEnumerator
        {
            private IntPtr pointer;
            private int? length;

            public MultiStringEnumerator(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            public (LPCWSTR pointer, int length) Current { get; private set; }

            [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
            public unsafe bool MoveNext()
            {
                var startPtr = InteropServices.Memory.Pointer.Create<LPCWSTR>(pointer);
                bool result = MultiStringHelper.MoveNext<char>(ref pointer,
                    ref length, out var currentSpan);
                Current = (startPtr, currentSpan.Length);
                return result;
            }
        }
    }
}
