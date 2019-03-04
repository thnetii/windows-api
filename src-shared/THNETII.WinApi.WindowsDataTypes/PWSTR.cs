using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 453
    /// <summary>
    /// A pointer to a null-terminated string of 16-bit Unicode characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PWSTR : IEquatable<PWSTR>, IEquatable<IntPtr>
    {
        /// <summary>
        /// Initializes a new <see cref="PWSTR"/> with a given pointer.
        /// </summary>
        /// <param name="ptr">A pointer to the first unicode character in the string. May be <see cref="IntPtr.Zero"/> to represent <c>null</c>.</param>
        public PWSTR(IntPtr ptr) => Pointer = ptr;

        /// <summary>
        /// Gets the pointer value of the <see cref="PWSTR"/>.
        /// </summary>
        /// <value>A pointer to the first character of the string, or <see cref="IntPtr.Zero"/> if the <see cref="PWSTR"/> refers to <c>null</c>.</value>
        public IntPtr Pointer { get; }

        /// <summary>
        /// Gets a value indicating whether the current pointer is a null-pointer.
        /// </summary>
        /// <value><c>true</c> is <see cref="Pointer"/> is not equal to <see cref="IntPtr.Zero"/>; otherwise, <c>false</c>.</value>
        public bool HasValue => Pointer != IntPtr.Zero;

        /// <summary>
        /// Marshals the data pointed to by <see cref="Pointer"/> into a managed
        /// string instance.
        /// <para>Copies each unicode character up to, but excluding the first encountered null-terminating character.</para>
        /// </summary>
        /// <returns>
        /// <c>null</c> if <see cref="Pointer"/> is <see cref="IntPtr.Zero"/>; otherwise,
        /// a managed string instance containing a copy of the unmanaged string.
        /// </returns>
        public override string ToString() => Pointer.MarshalAsUnicodeString();

        /// <summary>
        /// Marshals the data pointed to by <see cref="Pointer"/> into a managed
        /// string instance with the specified length.
        /// <para>Copies the specified number of unicode characters.</para>
        /// </summary>
        /// <param name="length">The non-negative number of two-byte UTF-16 characters to copy.</param>
        /// <returns>
        /// <c>null</c> if <see cref="Pointer"/> is <see cref="IntPtr.Zero"/>; otherwise,
        /// A managed string instance with a <see cref="string.Length"/> equal to <paramref name="length"/> containing a copy of the unmanaged string.
        /// </returns>
        public string ToString(int length) => Pointer.MarshalAsUnicodeString(length);

        /// <summary>
        /// Returns a writeable span for access to the characters of the unmanaged string.
        /// </summary>
        /// <param name="length">The non-negative number of two-byte UTF-16 characters in the string.</param>
        /// <returns>A span of <see cref="char"/> values starting at <see cref="Pointer"/> and a <see cref="Span{T}.Length"/> equal to <paramref name="length"/>.</returns>
        public Span<char> AsSpan(int length) => Pointer.AsRefStructSpan<char>(length);
        /// <summary>
        /// Returns a writeable span for access to the characters of the unmanaged string.
        /// <para>Returns a span up to, but excluding the first encountered null-terminating character.</para>
        /// </summary>
        /// <returns>A span of <see cref="char"/> values starting at <see cref="Pointer"/> spanning up to, but excluding the first encountered null-terminating character.</returns>
        public Span<char> AsSpan() => Pointer.ToZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Explcitly casts the pointer to a <see cref="PWSTR"/> pointer.
        /// Equivalent to calling the <see cref="PWSTR(IntPtr)"/> constructor.
        /// </summary>
        /// <param name="ptr">A pointer to the first unicode character in the string. May be <see cref="IntPtr.Zero"/> to represent <c>null</c>.</param>
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = ".ctor")]
        public static explicit operator PWSTR(IntPtr ptr) => new PWSTR(ptr);

        /// <summary>
        /// Explcitly casts a <see cref="PWSTR"/> to a pointer.
        /// Equivalent to retrieving the value of the <see cref="Pointer"/> property.
        /// </summary>
        /// <param name="lpwstr">A pointer to the first unicode character in the string.</param>
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Pointer))]
        public static explicit operator IntPtr(PWSTR lpwstr) => lpwstr.Pointer;

        /// <inheritdoc cref="IntPtr.GetHashCode"/>
        public override int GetHashCode() => Pointer.GetHashCode();

        /// <inheritdoc cref="IntPtr.Equals(object)"/>
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return !HasValue;
                case PWSTR lpwstr:
                    return Equals(lpwstr);
                case IntPtr ptr:
                    return Equals(ptr);
                default:
                    return false;
            }
        }

        /// <inheritdoc cref="IEquatable{PWSTR}.Equals(PWSTR)"/>
        public bool Equals(PWSTR lpwstr) => Pointer == lpwstr.Pointer;

        /// <inheritdoc cref="IEquatable{IntPtr}.Equals(IntPtr)"/>
        public bool Equals(IntPtr ptr) => Pointer == ptr;

        /// <inheritdoc cref="IEquatable{PWSTR}.Equals(PWSTR)"/>
        public static bool operator ==(PWSTR left, PWSTR right) =>
            left.Pointer == right.Pointer;

        /// <inheritdoc cref="IEquatable{IntPtr}.Equals(IntPtr)"/>
        public static bool operator ==(PWSTR left, IntPtr right) =>
            left.Pointer == right;

        /// <inheritdoc cref="IEquatable{IntPtr}.Equals(IntPtr)"/>
        public static bool operator ==(IntPtr left, PWSTR right) =>
            left == right.Pointer;

        /// <summary>
        /// Determines whether two <see cref="PWSTR"/> instances are not equal,
        /// by comparing their pointer values.
        /// </summary>
        /// <param name="left">The left comparand.</param>
        /// <param name="right">The right comparand.</param>
        /// <returns><c>true</c> if the pointers are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(PWSTR left, PWSTR right) =>
            left.Pointer != right.Pointer;

        /// <summary>
        /// Determines whether a <see cref="PWSTR"/> instances is not equal to a
        /// pointer.
        /// </summary>
        /// <param name="left">The left comparand.</param>
        /// <param name="right">The right comparand.</param>
        /// <returns><c>true</c> if the pointers are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(PWSTR left, IntPtr right) =>
            left.Pointer != right;

        /// <summary>
        /// Determines whether a <see cref="PWSTR"/> instances is not equal to a
        /// pointer.
        /// </summary>
        /// <param name="left">The left comparand.</param>
        /// <param name="right">The right comparand.</param>
        /// <returns><c>true</c> if the pointers are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(IntPtr left, PWSTR right) =>
            left != right.Pointer;
    }
}
