using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32", Justification = nameof(CLAIM_SECURITY_ATTRIBUTE_V1.ValueType))]
    public enum CLAIM_SECURITY_ATTRIBUTE_VALUE_TYPE : short
    {
        CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="long"/> values.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="ulong"/> values.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of pointers to Unicode string values.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> values.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> values where the Value member of each <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> is a <see cref="SID"/>.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_SID,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="ulong"/> values where each element indicates a Boolean value. Non-zero values indicate <c>true</c> and the value <c>0UL</c> (zero) indicates <c>false</c>.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN,
        /// <summary>
        /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_V1.Values"/> member refers to an array of <see cref="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> values.
        /// </summary>
        CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = WinNTConstants.CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING,
    }
}
