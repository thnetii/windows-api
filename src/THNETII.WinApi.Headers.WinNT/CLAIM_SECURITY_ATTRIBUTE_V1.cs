using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.NativeMemory;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11016
    //
    //  An individual security attribute.
    //

    /// <summary>
    /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1"/> structure defines a security attribute that can be associated with a token or authorization context.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-claim_security_attribute_v1">CLAIM_SECURITY_ATTRIBUTE_V1 structure</a></para>
    /// </remarks>
    /// <seealso cref="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct CLAIM_SECURITY_ATTRIBUTE_V1
    {
        private static readonly Bitfield32 FlagsBitfield = Bitfield32.DefineFromMask(CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS);
        private static readonly Bitfield32 CustomFlagsBitfield = Bitfield32.DefineFromMask(CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS);

        /// <summary>
        /// A pointer to a string of Unicode characters that contains the name of the security attribute. This string must be at least 4 bytes in length.
        /// </summary>
        public PWSTR Name;
        /// <summary>
        /// A union tag value that indicates the type of information contained in the <see cref="Values"/> member.
        /// </summary>
        public CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE ValueType;
        /// <summary>
        /// This member is reserved and must be set to zero when sent and must be ignored when received.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Reserved;
        internal uint FlagsValue;
        /// <summary>
        /// The attribute flags. Only includes Bits 0 through 15.
        /// <para>The upper 16 bits can be used for custom flags and are accessible through the <see cref="CustomFlags"/> property.</para>
        /// </summary>
        public CLAIM_SECURITY_ATTRIBUTE_FLAGS Flags
        {
            get => (CLAIM_SECURITY_ATTRIBUTE_FLAGS)FlagsBitfield.Read(FlagsValue);
            set => FlagsBitfield.Write(ref FlagsValue, (uint)value);
        }
        /// <summary>
        /// Bits 16 through 31 of <see cref="Flags"/> may be set to any value.
        /// </summary>
        public int CustomFlags
        {
            get => CustomFlagsBitfield.Read((int)FlagsValue);
            set => CustomFlagsBitfield.Write(ref FlagsValue, (uint)value);
        }
        /// <summary>
        /// The number of values specified in the <see cref="Values"/> member.
        /// </summary>
        public int ValueCount;
        /// <summary>
        /// An array of security attribute values of the type specified in the <see cref="ValueType"/> member.
        /// </summary>
        public IntPtr Values;
        /// <summary>
        /// A span of <see cref="ValueCount"/> members where each member is a <see cref="long"/> of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64"/>.
        /// </summary>
        public Span<long> Int64
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64)
                    throw new InvalidOperationException($"Cannot access property {nameof(Int64)} if {nameof(ValueType)} is {ValueType}");
                return Values.AsRefStructSpan<long>(ValueCount);
            }
        }

        /// <summary>
        /// A span of <see cref="ValueCount"/> members where each member is a <see cref="ulong"/> of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64"/>.
        /// </summary>
        public Span<ulong> UInt64
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64)
                    throw new InvalidOperationException($"Cannot access property {nameof(UInt64)} if {nameof(ValueType)} is {ValueType}");
                return Values.AsRefStructSpan<ulong>(ValueCount);
            }
        }

        /// <summary>
        /// A span of <see cref="ValueCount"/> members where each member is a <see cref="PWSTR"/> of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING"/>.
        /// </summary>
        public Span<PWSTR> String
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING)
                    throw new InvalidOperationException($"Cannot access property {nameof(String)} if {nameof(ValueType)} is {ValueType}");
                return Values.AsRefStructSpan<PWSTR>(ValueCount);
            }
        }

        /// <summary>
        /// A span of <see cref="ValueCount"/> members where each member is a fully qualified binary name value of type <see cref="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/>.
        /// </summary>
        public Span<CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE> Fqbn
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN)
                    throw new InvalidOperationException($"Cannot access property {nameof(Fqbn)} if {nameof(ValueType)} is {ValueType}");
                return Values.AsRefStructSpan<CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE>(ValueCount);
            }
        }

        /// <summary>
        /// A span of <see cref="ValueCount"/> members where each member is an octet string of type <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/>.
        /// </summary>
        public Span<CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE> OctetString
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING)
                    throw new InvalidOperationException($"Cannot access property {nameof(OctetString)} if {nameof(ValueType)} is {ValueType}");
                return Values.AsRefStructSpan<CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE>(ValueCount);
            }
        }
    }
}
