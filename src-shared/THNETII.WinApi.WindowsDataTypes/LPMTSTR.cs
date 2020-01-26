using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a null-terminated string of platform-dependant characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPMTSTR : ITerminatedAutoStringPointer
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

            public (LPTSTR pointer, int length) Current { get; private set; }

            [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
            public unsafe bool MoveNext()
            {
                var startPtr = InteropServices.Memory.Pointer.Create<LPTSTR>(pointer);
                bool result;
                switch (Marshal.SystemDefaultCharSize)
                {
                    case 1:
                        result = MultiStringHelper.MoveNext<byte>(ref pointer,
                            ref length, out var currentAnsiSpan);
                        Current = (startPtr, currentAnsiSpan.Length);
                        break;
                    case 2:
                        result = MultiStringHelper.MoveNext<char>(ref pointer,
                            ref length, out var currentUnicodeSpan);
                        Current = (startPtr, currentUnicodeSpan.Length);
                        break;
                    default: throw new PlatformNotSupportedException($"System Default Char size of {Marshal.SystemDefaultCharSize} bytes is not supported.");
                }
                return result;
            }
        }
    }
}
