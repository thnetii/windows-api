using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WindowsProtocols.WindowsErrorCodes
{
    /// <summary>
    /// Many kernel-mode standard driver routines and driver support routines use the <see cref="NTSTATUS"/> type for return values.
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
    public struct NTSTATUS : IEquatable<NTSTATUS>, IEquatable<int>
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(offset: 16, count: 11);
        private static readonly Bitfield32 c_bit = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 sev_field = Bitfield32.DefineRemainingBits(offset: 30);

        /// <summary>
        /// The full 32-bit integer value of of the system error code.
        /// </summary>
        /// <value>The entire value as a signed 32-bit integer.</value>
        [SuppressMessage("Design", "CA1051: Do not declare visible instance fields")]
        public readonly int Value;

        /// <summary>
        /// Gets the the facility's status code.
        /// </summary>
        /// <value>An integer value containing the status code that is specific to the <see cref="Facility"/>.</value>
        public int Code => code_field.Read(Value);

        /// <summary>
        /// Indicates the NT Facility that is responsible for the status value.
        /// </summary>
        /// <value>A value from the <see cref="NTFacility"/> enumeration.</value>
        public NTFacility Facility => (NTFacility)facility_field.Read(Value);

        /// <summary>
        /// Whether the <see cref="NTSTATUS"/> value is a customer-defined value.
        /// </summary>
        /// <value><c>false</c> is the <see cref="NTSTATUS"/> value is Microsoft-defined; <c>true</c> if it is Customer-defined.</value>
        public bool IsCustomerCode => c_bit.Read(Value) != 0;

        /// <summary>
        /// Gets the severity code.
        /// </summary>
        /// <value>A <see cref="StatusSeverity"/> value.</value>
        public StatusSeverity Severity => (StatusSeverity)sev_field.Read(Value);

        /// <summary>
        /// Initializes a new <see cref="NTSTATUS"/> with the specified integer value.
        /// </summary>
        /// <param name="code">The status code as a 32-bit integer value.</param>
        public NTSTATUS(int code) : this() => Value = code;

        /// <summary>
        /// Initializes a new <see cref="NTSTATUS"/> with the specified integer value.
        /// </summary>
        /// <param name="code">The status error code as an unsigned 32-bit integer value.</param>
        public NTSTATUS(uint code) : this(unchecked((int)code)) { }

        /// <summary>
        /// Implicityly casts the 32-bit integer value to a <see cref="NTSTATUS"/> value.
        /// </summary>
        /// <param name="code">The NTSTATUS error code as a 32-bit integer value.</param>
        /// <returns>A <see cref="NTSTATUS"/> whose <see cref="Value"/> is equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator NTSTATUS(int code) =>
            new NTSTATUS(code);

        /// <summary>
        /// Implicityly casts the unsigned 32-bit integer value to a <see cref="NTSTATUS"/> value.
        /// </summary>
        /// <param name="code">The NTSTATUS error code as an unsigned 32-bit integer value.</param>
        /// <returns>A <see cref="NTSTATUS"/> whose <see cref="Value"/> is bitwise equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator NTSTATUS(uint code) =>
            new NTSTATUS(code);

        /// <summary>
        /// Casting operator converting the <see cref="NTSTATUS"/> to a 32-bit
        /// integer value.
        /// </summary>
        /// <param name="e">The error code to cast.</param>
        /// <returns><see cref="Value"/></returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static explicit operator int(NTSTATUS e) => e.Value;

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The value obtained from calling <see cref="ValueType.GetHashCode"/> on <see cref="Value"/>.</returns>
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Checks whether two <see cref="NTSTATUS"/> value are equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> equals the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(NTSTATUS left, NTSTATUS right) =>
            left.Value == right.Value;

        /// <summary>
        /// Checks whether two <see cref="NTSTATUS"/> value are not equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> is not equal to the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(NTSTATUS left, NTSTATUS right) =>
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
                case NTSTATUS hr: return this == hr;
                case int code: return this == code;
                case IConvertible convertible: return this == convertible.ToInt32(System.Globalization.CultureInfo.InvariantCulture);
                default: return false;
            }
        }

        /// <summary>
        /// Determines whether the current value is equal to another <see cref="NTSTATUS"/> value.
        /// </summary>
        /// <param name="hr">The Windows Error code to compare with.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="Value"/> property of this instance is equal to the <see cref="Value"/> property of <paramref name="hr"/>;<br/>
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(NTSTATUS hr) => this == hr;

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
        /// Returns a string representing the <see cref="NTSTATUS"/> as a 32-bit numeric value
        /// in capitalized prefixed hexadecimal notation.
        /// </summary>
        /// <returns><see cref="Value"/> formatted in capitalized 8 digit hexadecimal notation, prefixed with <c>0x</c>.</returns>
        public override string ToString() => $"0x{Value:X8}";
    }
}
