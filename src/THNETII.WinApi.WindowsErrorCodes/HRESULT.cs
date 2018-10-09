using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// The <see cref="HRESULT"/> is a data type used to represent error and warning conditions.
    /// <para><see cref="HRESULT"/>s are numerical error codes. Various bits within an HRESULT encode information about the nature of the error code, and where it came from. </para>
    /// </summary>
    /// <remarks>
    /// The <see cref="HRESULT"/> numbering space is vendor-extensible. Vendors can supply their own values for this field, as long as the C bit (<c>0x20000000</c>) is set, indicating it is a customer code.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct HRESULT : IEquatable<HRESULT>, IEquatable<int>
    {
        private static readonly Bitfield32 code_field = Bitfield32.DefineLowerBits(16);
        private static readonly Bitfield32 facility_field = Bitfield32.DefineMiddleBits(16, 11);
        private static readonly Bitfield32 msgid_bit = Bitfield32.DefineSingleBit(27);
        private static readonly Bitfield32 nt_bit = Bitfield32.DefineSingleBit(28);
        private static readonly Bitfield32 c_bit = Bitfield32.DefineSingleBit(29);
        private static readonly Bitfield32 s_bit = Bitfield32.DefineSingleBit(31);
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
        /// Indicates the system service that is responsible for the error.
        /// </summary>
        /// <value>A value from the <see cref="Win32Facility"/> enumeration.</value>
        public Win32Facility Facility => (Win32Facility)facility_field.Read(value);

        /// <summary>
        /// Whether the <see cref="HRESULT"/> value is not a status value, but a message id for display string.
        /// </summary>
        /// <value>
        /// <c>false</c> if the current <see cref="HRESULT"/> is a normal status value;
        /// <c>true</c> if it is a display string message ID.
        /// </value>
        public bool IsMessageId => msgid_bit.Read(value) != 0;

        /// <summary>
        /// Whether the <see cref="HRESULT"/> value is a <see cref="NTSTATUS"/> value mapped to an <see cref="HRESULT"/>.
        /// </summary>
        /// <value><c>true</c> if the <see cref="HRESULT"/> is a mapped <see cref="NTSTATUS"/> value; otherwise, <c>false</c>.</value>
        public bool IsNTMapped => nt_bit.Read(value) != 0;

        /// <summary>
        /// Whether the <see cref="HRESULT"/> value is a customer-defined value.
        /// </summary>
        /// <value><c>false</c> is the <see cref="HRESULT"/> value is Microsoft-defined; <c>true</c> if it is Customer-defined.</value>
        public bool IsCustomerCode => c_bit.Read(value) != 0;

        /// <summary>
        /// Whether the <see cref="HRESULT"/> value indicates a successful operation.
        /// </summary>
        /// <value><c>true</c> if successful; <c>false</c> if not.</value>
        public bool IsSuccess => s_bit.Read(value) == 0;

        /// <summary>
        /// Whether the <see cref="HRESULT"/> value indicates a failed operation.
        /// </summary>
        /// <value><c>true</c> if the operation failed; <c>false</c> if not.</value>
        public bool IsFailure => s_bit.Read(value) != 0;

        /// <summary>
        /// Gets the severity for a mapped <see cref="NTSTATUS"/> value.
        /// </summary>
        /// <value>A <see cref="StatusSeverity"/> value provide one extra bit of information compared to <see cref="Severity"/>.</value>
        /// <seealso cref="Severity"/>
        public StatusSeverity NTStatusSeverity => (StatusSeverity)sev_field.Read(value);

        /// <summary>
        /// Indicates success or failure
        /// </summary>
        /// <value><see cref="HResultSeverity.Success"/> if successful; otherwise, <see cref="HResultSeverity.Error"/>.</value>
        public HResultSeverity Severity => (HResultSeverity)s_bit.Read(value);

        /// <summary>
        /// Returns the system error code as a 32-bit integer value.
        /// </summary>
        /// <returns><see cref="Value"/>.</returns>
        public int AsInt32() => value;

        /// <summary>
        /// Converts the <see cref="HRESULT"/> error code to a corresponding managed
        /// <see cref="Exception"/> instance.
        /// </summary>
        /// <returns>
        /// A regular .NET Exception instance if <see cref="Value"/> can be mapped to a .NET <see cref="Exception"/>;
        /// otherwise, a non-specific <see cref="COMException"/> is returned.
        /// </returns>
        public Exception GetException() => Marshal.GetExceptionForHR(value);

        /// <summary>
        /// Initializes a new <see cref="HRESULT"/> with the specified integer value.
        /// </summary>
        /// <param name="code">The HRESULT error code as a 32-bit integer value.</param>
        public HRESULT(int code) : this() => value = code;

        /// <summary>
        /// Initializes a new <see cref="HRESULT"/> with the specified integer value.
        /// </summary>
        /// <param name="code">The HRESULT error code as an unsigned 32-bit integer value.</param>
        public HRESULT(uint code) : this(unchecked((int)code)) { }

        /// <summary>
        /// Implicityly casts the 32-bit integer value to a <see cref="HRESULT"/> value.
        /// </summary>
        /// <param name="code">The HRESULT error code as a 32-bit integer value.</param>
        /// <returns>A <see cref="HRESULT"/> whose <see cref="Value"/> is equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator HRESULT(int code) =>
            new HRESULT(code);

        /// <summary>
        /// Implicityly casts the unsigned 32-bit integer value to a <see cref="HRESULT"/> value.
        /// </summary>
        /// <param name="code">The HRESULT error code as an unsigned 32-bit integer value.</param>
        /// <returns>A <see cref="HRESULT"/> whose <see cref="Value"/> is bitwise equal to <paramref name="code"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static implicit operator HRESULT(uint code) =>
            new HRESULT(code);

        /// <summary>
        /// Casting operator converting the <see cref="HRESULT"/> to a 32-bit
        /// integer value.
        /// </summary>
        /// <param name="e">The error code to cast.</param>
        /// <returns><see cref="Value"/></returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static explicit operator int(HRESULT e) => e.AsInt32();

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The value obtained from calling <see cref="ValueType.GetHashCode"/> on <see cref="Value"/>.</returns>
        public override int GetHashCode() => value.GetHashCode();

        /// <summary>
        /// Checks whether two <see cref="HRESULT"/> value are equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> equals the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator ==(HRESULT left, HRESULT right) =>
            left.value == right.value;

        /// <summary>
        /// Checks whether two <see cref="HRESULT"/> value are not equal.
        /// </summary>
        /// <param name="left">The left side operand of the comparison.</param>
        /// <param name="right">The right side operand of the comparison.</param>
        /// <returns><c>true</c> if the <see cref="Value"/> property of <paramref name="left"/> is not equal to the <see cref="Value"/> of <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        public static bool operator !=(HRESULT left, HRESULT right) =>
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
                case HRESULT hr: return this == hr;
                case int code: return this == code;
                case IConvertible convertible: return this == convertible.ToInt32(System.Globalization.CultureInfo.InvariantCulture);
                default: return false;
            }
        }

        /// <summary>
        /// Determines whether the current value is equal to another <see cref="HRESULT"/> value.
        /// </summary>
        /// <param name="hr">The Windows Error code to compare with.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="Value"/> property of this instance is equal to the <see cref="Value"/> property of <paramref name="hr"/>;<br/>
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(HRESULT hr) => this == hr;

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
        /// Returns a string representing the <see cref="HRESULT"/> as a 32-bit numeric value
        /// in capitalized prefixed hexadecimal notation.
        /// </summary>
        /// <returns><see cref="Value"/> formatted in capitalized 8 digit hexadecimal notation, prefixed with <c>0x</c>.</returns>
        public override string ToString() => $"0x{value:X8}";

        /// <summary>
        /// Casts the Win32 Error Code to an <see cref="HRESULT"/> value using the <see cref="Win32Facility.Win32"/> facility.
        /// </summary>
        /// <param name="x">The raw Win32 Error Code to cast.</param>
        /// <returns><paramref name="x"/> mapped to an <see cref="HRESULT"/> value with a <see cref="Facility"/> of <see cref="Win32Facility.Win32"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates")]
        public static explicit operator HRESULT(Win32ErrorCode x)
        {
            return FromWin32(x.Value);
        }

        /// <summary>
        /// Converts the Win32 Error Code to an <see cref="HRESULT"/> value using the <see cref="Win32Facility.Win32"/> facility.
        /// </summary>
        /// <param name="x">The raw Win32 Error Code to convert.</param>
        /// <returns><paramref name="x"/> mapped to an <see cref="HRESULT"/> value with a <see cref="Facility"/> of <see cref="Win32Facility.Win32"/>.</returns>
        public static HRESULT FromWin32(int x)
        {
            int hr = default;
            code_field.Write(ref hr, x);
            facility_field.Write(ref hr, (int)Win32Facility.Win32);
            s_bit.Write(ref hr, 1);
            return new HRESULT(hr);
        }
    }
}
