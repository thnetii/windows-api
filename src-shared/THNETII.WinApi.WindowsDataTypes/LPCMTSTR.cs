using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a constant multiple null-terminated string of platform-dependant characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPCMTSTR : IConstTerminatedAutoStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }

        /// <inheritdoc cref="LPMTSTR.AsEnumerable"/>
        public MultiStringEnumerable AsEnumerable(int? length = null) =>
            new MultiStringEnumerable(Pointer, length);

        /// <inheritdoc cref="LPMTSTR.MultiStringEnumerable"/>
        public readonly ref struct MultiStringEnumerable
        {
            private readonly IntPtr pointer;
            private readonly int? length;

            internal MultiStringEnumerable(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            /// <inheritdoc cref="LPMTSTR.MultiStringEnumerable.GetEnumerator"/>
            public MultiStringEnumerator GetEnumerator() =>
                new MultiStringEnumerator(pointer, length);
        }

        /// <inheritdoc cref="LPMTSTR.MultiStringEnumerator"/>
        public ref struct MultiStringEnumerator
        {
            private IntPtr pointer;
            private int? length;

            internal MultiStringEnumerator(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            /// <inheritdoc cref="LPMTSTR.MultiStringEnumerator.Current"/>
            public (LPCTSTR pointer, int length) Current { get; private set; }

            /// <inheritdoc cref="LPMTSTR.MultiStringEnumerator.MoveNext"/>
            [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
            public unsafe bool MoveNext()
            {
                var startPtr = InteropServices.Memory.Pointer.Create<LPCTSTR>(pointer);
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
