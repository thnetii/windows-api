using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WindowsProtocols.WindowsErrorCodes
{
    /// <summary>
    /// Represents a Win32 System Error code.
    /// </summary>
    /// <remarks>
    /// Values are 32 bit values laid out as follows:
    /// <code>
    ///  3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
    ///  1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
    /// +---+-+-+-----------------------+-------------------------------+
    /// |Sev|C|R|     Facility          |               Code            |
    /// +---+-+-+-----------------------+-------------------------------+
    /// </code>
    /// where
    /// <list type="table">
    /// <listheader><term>Field</term><description>Description</description></listheader>
    /// <item>
    /// <term><c>Sev</c></term>
    /// <description>
    /// is the severity code
    /// <list type="table">
    /// <listheader><term>Value</term><description>Meaning</description></listheader>
    /// <item><term><c>0b00</c></term><description>Success</description></item>
    /// <item><term><c>0b01</c></term><description>Informational</description></item>
    /// <item><term><c>0b10</c></term><description>Warning</description></item>
    /// <item><term><c>0b11</c></term><description>Error</description></item>
    /// </list>
    /// </description>
    /// </item>
    /// <item><term><c>C</c></term><description>is the Customer code flag</description></item>
    /// <item><term><c>R</c></term><description>is a reserved bit</description></item>
    /// <item><term>Facility</term><description>is the facility code</description></item>
    /// <item><term>Code</term><description>is the facility's status code</description></item>
    /// </list>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32ErrorCode : IEquatable<int>, IEquatable<Win32ErrorCode>
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(16, 12);
        private static readonly Bitfield32 customer_flag = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 severity_field = Bitfield32.DefineRemainingBits(30);

        private readonly int value;

        /// <summary>
        /// The full 32-bit integer value of of the system error code.
        /// </summary>
        /// <value>The entire value as a signed 32-bit integer.</value>
        public int Value => value;

        /// <summary>
        /// Gets the the facility's status code.
        /// </summary>
        /// <value>An integer value containing the status code that is specific to the <see cref="Facility"/>.</value>
        public int Code => code_field.Read(value);

        /// <summary>
        /// Gets the facility code indicating which part of the system reported
        /// the status.
        /// </summary>
        /// <value>A value that, together with the <see cref="IsCustomerCode"/> bit, indicates the numbering space to use for the <see cref="Code"/> property.</value>
        public Win32Facility Facility => (Win32Facility)facility_field.Read(value);

        /// <summary>
        /// Gets a value indicating whether the status code is a recognized code
        /// from the Win32 system, or a custom code defined by a third party.
        /// </summary>
        /// <value><c>true</c> if the value is customer-defined; <c>false</c> for Microsoft-defined values.</value>
        public bool IsCustomerCode => customer_flag.Read(value) != 0;

        /// <summary>
        /// Gets the severity of the system error code.
        /// </summary>
        /// <value>One of the values defined in the <see cref="StatusSeverity"/> enumeration.</value>
        public StatusSeverity Severity => (StatusSeverity)severity_field.Read(value);

        /// <summary>
        /// Returns the system error code as a 32-bit integer value.
        /// </summary>
        /// <returns><see cref="Value"/>.</returns>
        public int AsInt32() => value;

        /// <summary>
        /// Initializes the specified integer value as a Win32 system error code.
        /// </summary>
        /// <param name="code">The system error code as a 32-bit signed integer value.</param>
        public Win32ErrorCode(int code) : this() => value = code;

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
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(int code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Implicitly casts the 32-bit integer value to a Win32 system error code.
        /// </summary>
        /// <param name="code">The 32-bit integer to cast.</param>
        /// <returns>A <see cref="Win32ErrorCode"/> whose <see cref="Value"/> is bitwise equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(uint code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Casting operator converting the Win32 system error code to a 32-bit
        /// integer value.
        /// </summary>
        /// <param name="e">The error code to cast.</param>
        /// <returns><see cref="Value"/></returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = nameof(AsInt32))]
        public static explicit operator int(Win32ErrorCode e) => e.AsInt32();

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The value obtained from calling <see cref="ValueType.GetHashCode"/> on <see cref="Value"/>.</returns>
        public override int GetHashCode() => value.GetHashCode();

        /// <summary>
        /// Checks whether two Win32 system error codes are equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> equals the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Win32ErrorCode left, Win32ErrorCode right) =>
            left.value == right.value;

        /// <summary>
        /// Checks whether two Win32 system error codes are not equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> is not equal to the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Win32ErrorCode left, Win32ErrorCode right) =>
            left.value != right.value;

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
        public override string ToString() => $"0x{value:X8}";
    }
}
