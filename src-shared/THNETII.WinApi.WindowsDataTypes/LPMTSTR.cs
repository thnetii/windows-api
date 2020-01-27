using System;
using System.Collections;
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

        /// <summary>
        /// Returns a structure that can be used in a <see langword="foreach"/>
        /// loop to iterate over the strings referenced by the pointer.
        /// </summary>
        /// <param name="length">
        /// The optional total length of characters, including all
        /// terminator-characters. Use <see langword="null"/> if the total
        /// length should be determined automatically.
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable"/>-like structure that supports
        /// enumeration in a <see langword="foreach"/>-loop.
        /// </returns>
        /// <remarks>
        /// If <paramref name="length"/> is <see langword="null"/>, iteration
        /// will terminate at the first occurrence of two terminator characters
        /// followed after each other.
        /// </remarks>
        public MultiStringEnumerable AsEnumerable(int? length = null) =>
            new MultiStringEnumerable(Pointer, length);

        /// <summary>
        /// A wrapper structure wrapping a multi-string pointer and its
        /// total length (if known) for <see langword="foreach"/> iteration.
        /// </summary>
        public readonly ref struct MultiStringEnumerable
        {
            private readonly IntPtr pointer;
            private readonly int? length;

            internal MultiStringEnumerable(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            /// <inheritdoc cref="IEnumerable.GetEnumerator"/>
            public MultiStringEnumerator GetEnumerator() =>
                new MultiStringEnumerator(pointer, length);
        }

        /// <summary>
        /// Supports enumeration in a <see langword="foreach"/> loop over a
        /// multi-string.
        /// </summary>
        /// <seealso cref="IEnumerator"/>
        /// <seealso cref="Span{T}.Enumerator"/>
        public ref struct MultiStringEnumerator
        {
            private IntPtr pointer;
            private int? length;

            internal MultiStringEnumerator(IntPtr pointer, int? length) : this()
            {
                this.pointer = pointer;
                this.length = length;
            }

            /// <summary>
            /// Gets the current string-pointer and its determined length as
            /// a value tuple.
            /// <para>
            /// The returned length is the number of characters in the string,
            /// excluding the terminating character.
            /// </para>
            /// </summary>
            /// <remarks>
            /// When the enumerator has reached the end of the multi-string and
            /// <see cref="MoveNext"/> returns <see langword="false"/>, the
            /// value of <see cref="Current"/> is set to the default value,
            /// containing a pointer to <see cref="IntPtr.Zero"/> with an
            /// indicated length of <c>0</c> (zero).
            /// </remarks>
            /// <seealso cref="IEnumerator.Current"/>
            /// <seealso cref="Span{T}.Enumerator.Current"/>
            public (LPTSTR pointer, int length) Current { get; private set; }

            /// <summary>
            /// Advances the enumerator to the next string in the multi-string.
            /// </summary>
            /// <returns>
            /// <see langword="true"/> if the enumerator was successfully
            /// advanced to the next string in the multi-string;
            /// <see langword="false"/> if the enumerator has reached the end
            /// of the multi-string.
            /// </returns>
            /// <remarks>
            /// If the total length of the multi-string was not known when the
            /// enumerator was created, the end is implied at the first
            /// occurence of two consecutive terminating characters.
            /// </remarks>
            /// <seealso cref="IEnumerator.MoveNext"/>
            /// <seealso cref="Span{T}.Enumerator.MoveNext"/>
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
