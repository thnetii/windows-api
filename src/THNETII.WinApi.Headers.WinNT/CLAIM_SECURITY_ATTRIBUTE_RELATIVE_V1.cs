using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11016
    //
    //  Relative form of the security attribute.
    //

    /// <summary>
    /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"/> structure defines a resource attribute that is defined in continuous memory for persistence within a serialized security descriptor.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-claim_security_attribute_relative_v1">CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
    {
        private static readonly Bitfield32 FlagsBitfield = Bitfield32.DefineFromMask(CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS);
        private static readonly Bitfield32 CustomFlagsBitfield = Bitfield32.DefineFromMask(CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS);

        /// <summary>
        /// A value that indicates an offset from the beginning of the <see cref="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"/> structure to a string of Unicode characters that contain the name of the claim security attribute. The string must be at least 4 bytes in length.
        /// </summary>
        public int NameOffset;
        /// <summary>
        /// The span of Unicode characters that make up the name of the claim security attribute.
        /// </summary>
        public unsafe Span<char> Name
        {
            get
            {
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    var pwName = new PWSTR(new IntPtr(pThis) + NameOffset);
                    return pwName.AsSpan();
                }
            }
        }
        /// <summary>
        /// A union tag value that indicates the type of information contained being referred to by the <see cref="ValueOffsets"/> member.
        /// The <see cref="ValueOffsets"/> member will return a span of offsets from the beginning of the <see cref="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"/> structure to each value.
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
        /// The number of values contained in the <see cref="ValueOffsets"/> member.
        /// </summary>
        public int ValueCount;
        internal int ValueOffsetsField;
        /// <summary>
        /// A span of offsets from the beginning of the <see cref="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"/> structure. Each offset indicates the location of a claim security attribute value of the type specified in the <see cref="ValueType"/> member.
        /// </summary>
        public unsafe Span<int> ValueOffsets => new Span<int>(Unsafe.AsPointer(ref ValueOffsetsField), ValueCount);
        /// <summary>
        /// Provides referential access to <see cref="long"/> values of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64"/>
        /// </summary>
        public unsafe CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<long> Int64
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64)
                    throw new InvalidOperationException($"Cannot access property {nameof(Int64)} if {nameof(ValueType)} is {ValueType}");
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    return new CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<long>(pThis);
                }
            }
        }

        /// <summary>
        /// Provides referential access to <see cref="ulong"/> values of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64"/>
        /// </summary>
        public unsafe CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<ulong> UInt64
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64)
                    throw new InvalidOperationException($"Cannot access property {nameof(UInt64)} if {nameof(ValueType)} is {ValueType}");
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    return new CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<ulong>(pThis);
                }
            }
        }

        /// <summary>
        /// Provides referential access to <see cref="PWSTR"/> values of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING"/>
        /// </summary>
        public unsafe CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<PWSTR> String
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING)
                    throw new InvalidOperationException($"Cannot access property {nameof(String)} if {nameof(ValueType)} is {ValueType}");
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    return new CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<PWSTR>(pThis);
                }
            }
        }

        /// <summary>
        /// Provides referential access to <see cref="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> values of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN"/>
        /// </summary>
        public unsafe CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE> Fqbn
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN)
                    throw new InvalidOperationException($"Cannot access property {nameof(Fqbn)} if {nameof(ValueType)} is {ValueType}");
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    return new CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE>(pThis);
                }
            }
        }

        /// <summary>
        /// Provides referential access to <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> values of type <see cref="CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING"/>
        /// </summary>
        public unsafe CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE> OctetString
        {
            get
            {
                if (ValueType != CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE.CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING)
                    throw new InvalidOperationException($"Cannot access property {nameof(OctetString)} if {nameof(ValueType)} is {ValueType}");
                fixed (CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* pThis = &this)
                {
                    return new CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE>(pThis);
                }
            }
        }
    }

    public unsafe readonly struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES<T>
    {
        private readonly CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* @base;

        public CLAIM_SECURITY_ATTRIBUTE_RELATIVE_VALUES(CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1* @base) =>
            this.@base = @base;

        public ref T this[int index]
        {
            get
            {
                var pInt64 = (new IntPtr(@base) + @base->ValueOffsets[index]).ToPointer();
                return ref Unsafe.AsRef<T>(pInt64);
            }
        }
    }
}
