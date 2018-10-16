using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi
{
    /// <summary>
    /// Represents a Win32 System Error code which are immutable 32-bit integer values.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32ErrorCode : IEquatable<int>, IEquatable<Win32ErrorCode>
    {
        private static readonly Bitfield32 appdefined_bit = Bitfield32.DefineSingleBit(29);

        /// <summary>
        /// The full 32-bit integer value of of the system error code.
        /// </summary>
        /// <value>The entire value as a signed 32-bit integer.</value>
        public int Value { get; }

        /// <summary>
        /// Whether the error code is an application-defined error code.
        /// </summary>
        /// <value><c>true</c> if the error code is application-defined; otherwise the error code is a system error code and the property value is <c>false</c>.</value>
        /// <remarks>
        /// <para>Bit 29 is reserved for application-defined error codes.</para>
        /// <para>No system error code has this property set to <c>true</c>.</para>
        /// <para>If you are defining an error code for your application, set this bit to one. That indicates that the error code has been defined by an application, and ensures that your error code does not conflict with any error codes defined by the system.</para>
        /// </remarks>
        public bool IsApplicationDefined => appdefined_bit.Read(Value) != 0;

        /// <summary>
        /// Initializes the specified integer value as a Win32 system error code.
        /// </summary>
        /// <param name="code">The system error code as a 32-bit signed integer value.</param>
        public Win32ErrorCode(int code) : this() => Value = code;

        /// <summary>
        /// Initializes the specified integer value as a Win32 system error code.
        /// </summary>
        /// <param name="code">The system error code as a 32-bit unsigned integer value.</param>
        public Win32ErrorCode(uint code) : this(unchecked((int)code)) { }

        /// <summary>
        /// Implicitly casts the 32-bit integer value to a Win32 system error code.
        /// </summary>
        /// <param name="code">The 32-bit integer to cast.</param>
        /// <returns>A <see cref="Win32ErrorCode"/> whose <see cref="Value"/> is equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(int code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Implicitly casts the 32-bit integer value to a Win32 system error code.
        /// </summary>
        /// <param name="code">The 32-bit integer to cast.</param>
        /// <returns>A <see cref="Win32ErrorCode"/> whose <see cref="Value"/> is bitwise equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(uint code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Casting operator converting the Win32 system error code to a 32-bit
        /// integer value.
        /// </summary>
        /// <param name="e">The error code to cast.</param>
        /// <returns><see cref="Value"/></returns>
        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(Value))]
        public static explicit operator int(Win32ErrorCode e) => e.Value;

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The value obtained from calling <see cref="ValueType.GetHashCode"/> on <see cref="Value"/>.</returns>
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Checks whether two Win32 system error codes are equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> equals the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Win32ErrorCode left, Win32ErrorCode right) =>
            left.Value == right.Value;

        /// <summary>
        /// Checks whether two Win32 system error codes are not equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> is not equal to the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Win32ErrorCode left, Win32ErrorCode right) =>
            left.Value != right.Value;

        /// <summary>
        /// Determines whether the current instance is equal to a specified object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>
        /// <c>true</c> if the current instance is logically equal to <paramref name="obj"/>; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Win32ErrorCode e: return this == e;
                case int code: return this == code;
                case IConvertible convertible: return this == convertible.ToInt32(System.Globalization.CultureInfo.InvariantCulture);
                default: return false;
            }
        }

        /// <summary>
        /// Determines whether the current instance is equal to a 32-bit integer value.
        /// </summary>
        /// <param name="code">The integer to compare with.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="Value"/> property of this instance is equal to <paramref name="code"/>;<br/>
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(int code) => this == code;

        /// <summary>
        /// Determines whether the current Windows Error Code is equal to another Windows Error Code.
        /// </summary>
        /// <param name="e">The Windows Error code to compare with.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="Value"/> property of this instance is equal to the <see cref="Value"/> property of <paramref name="e"/>;<br/>
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Win32ErrorCode e) => this == e;

        /// <summary>
        /// Returns a string representing the Windows Error Code as a 32-bit numeric value
        /// in capitalized prefixed hexadecimal notation.
        /// </summary>
        /// <returns><see cref="Value"/> formatted in capitalized 8 digit hexadecimal notation, prefixed with <c>0x</c>.</returns>
        public override string ToString() => $"0x{Value:X8}";
    }
}
