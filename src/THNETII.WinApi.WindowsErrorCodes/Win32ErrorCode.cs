using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// Represents a Win32 System Error code.
    /// </summary>
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
        public int Value => value;

        /// <summary>
        /// Gets the lower 16-bit code portion of the value.
        /// </summary>
        public int Code => code_field.Read(value);

        /// <summary>
        /// Gets the facility code indicating which part of the system reported
        /// the status.
        /// </summary>
        public Win32Facility Facility => (Win32Facility)facility_field.Read(value);

        /// <summary>
        /// Gets a value indicating whether the status code is a recognized code
        /// from the Win32 system, or a custom code defined by a third party.
        /// </summary>
        public bool IsCustomerCode => customer_flag.Read(value) != 0;

        /// <summary>
        /// Gets the severity of the system error code.
        /// </summary>
        public StatusSeverity Severity => (StatusSeverity)severity_field.Read(value);

        /// <summary>
        /// Returns the system error code as a 32-bit integer value.
        /// </summary>
        /// <returns></returns>
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
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(int code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Implicitly casts the 32-bit integer value to a Win32 system error code.
        /// </summary>
        /// <param name="code">The 32-bit integer to cast.</param>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator Win32ErrorCode(uint code) =>
            new Win32ErrorCode(code);

        /// <summary>
        /// Casting operator converting the Win32 system error code to a 32-bit
        /// integer value.
        /// </summary>
        /// <param name="e">The error code to cast.</param>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = nameof(AsInt32))]
        public static explicit operator int(Win32ErrorCode e) => e.AsInt32();

        /// <inheritdoc />
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

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case Win32ErrorCode e: return this == e;
                case int code: return this == code;
                default: return false;
            }
        }

        /// <inheritdoc />
        public bool Equals(int code) => this == code;

        /// <inheritdoc />
        public bool Equals(Win32ErrorCode e) => this == e;

        /// <inheritdoc />
        public override string ToString() => $"0x{value:X8}";
    }
}
