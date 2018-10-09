﻿using System;
using System.Diagnostics.CodeAnalysis;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// Many kernel-mode standard driver routines and driver support routines use the <see cref="NTSTATUS"/> type for return values.
    /// </summary>
    public struct NTSTATUS : IEquatable<NTSTATUS>, IEquatable<int>
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(16, 11);
        private static readonly Bitfield32 c_bit = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 sev_field = Bitfield32.DefineRemainingBits(30);

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
        /// Indicates the NT Facility that is responsible for the status value.
        /// </summary>
        /// <value>A value from the <see cref="NTFacility"/> enumeration.</value>
        public NTFacility Facility => (NTFacility)facility_field.Read(value);

        /// <summary>
        /// Whether the <see cref="NTSTATUS"/> value is a customer-defined value.
        /// </summary>
        /// <value><c>false</c> is the <see cref="NTSTATUS"/> value is Microsoft-defined; <c>true</c> if it is Customer-defined.</value>
        public bool IsCustomerCode => c_bit.Read(value) != 0;

        /// <summary>
        /// Gets the severity code.
        /// </summary>
        /// <value>A <see cref="StatusSeverity"/> value.</value>
        public StatusSeverity Severity => (StatusSeverity)sev_field.Read(value);

        /// <summary>
        /// Returns the system error code as a 32-bit integer value.
        /// </summary>
        /// <returns><see cref="Value"/>.</returns>
        public int AsInt32() => value;

        /// <summary>
        /// Initializes a new <see cref="NTSTATUS"/> with the specified integer value.
        /// </summary>
        /// <param name="code">The status code as a 32-bit integer value.</param>
        public NTSTATUS(int code) : this() => value = code;

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
        public static explicit operator int(NTSTATUS e) => e.AsInt32();

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The value obtained from calling <see cref="ValueType.GetHashCode"/> on <see cref="Value"/>.</returns>
        public override int GetHashCode() => value.GetHashCode();

        /// <summary>
        /// Checks whether two <see cref="NTSTATUS"/> value are equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> equals the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(NTSTATUS left, NTSTATUS right) =>
            left.value == right.value;

        /// <summary>
        /// Checks whether two <see cref="NTSTATUS"/> value are not equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> is not equal to the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(NTSTATUS left, NTSTATUS right) =>
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
        public override string ToString() => $"0x{value:X8}";
    }
}
