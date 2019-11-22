using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AuthZ
{
    using static AUTHZ_SECURITY_ATTRIBUTE_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 429
    //
    //  An individual security attribute.
    //

    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTE_V1"/> structure defines a security attribute that can be associated with an authorization context.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_security_attribute_v1">AUTHZ_SECURITY_ATTRIBUTE_V1 structure</a></para>
    /// </remarks>
    /// <seealso cref="AUTHZ_SECURITY_ATTRIBUTES_INFORMATION"/>
    /// <seealso cref="AuthzModifySecurityAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_SECURITY_ATTRIBUTE_V1
    {
        //
        //  Name of the attribute.
        //  Case insensitive Windows Unicode string.
        //

        /// <summary>
        /// A pointer to a name of a security attribute.
        /// </summary>
        public LPWSTR pName;

        #region public AUTHZ_SECURITY_ATTRIBUTE_TYPE ValueType;
        //
        //  Data type of attribute.
        //

        internal ushort ValueTypeField;
        /// <summary>
        /// The data type of the values pointed to by the <see cref="Values"/> member.
        /// </summary>
        public AUTHZ_SECURITY_ATTRIBUTE_TYPE ValueType
        {
            get => (AUTHZ_SECURITY_ATTRIBUTE_TYPE)ValueTypeField;
            set => ValueTypeField = (ushort)value;
        }
        #endregion

        #region public ushort Reserved;
        //
        //  Pass 0 in a set operation and check for 0 in
        //  a get operation.
        //

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ushort Reserved; 
        #endregion

        #region public AUTHZ_SECURITY_ATTRIBUTE_FLAGS Flags;
        //
        //  Attribute must not be inherited across process spawns.
        //

        internal int FlagsField;
        /// <summary>
        /// A combination of one or more of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="AUTHZ_SECURITY_ATTRIBUTE_NON_INHERITABLE"/><br/><c>0x0001</c></term><description>This security attribute is not inherited across processes. </description></item>
        /// <item><term><see cref="AUTHZ_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE"/><br/><c>0x0002</c></term><description>The value of the attribute is case sensitive. This flag is valid for values that contain string types. </description></item>
        /// </list>
        /// </summary>
        public AUTHZ_SECURITY_ATTRIBUTE_FLAGS Flags
        {
            get => (AUTHZ_SECURITY_ATTRIBUTE_FLAGS)FlagsField;
            set => FlagsField = (int)value;
        }
        #endregion

        #region public int ValueCount;
        //
        //  Number of values.
        //

        /// <summary>
        /// The number of values specified in the <see cref="Values"/> member.
        /// </summary>
        public int ValueCount;
        #endregion

        //
        //  The actual value itself.
        //
        /// <summary>
        /// A pointer to the actual value itself.
        /// </summary>
        public void* pValues;

        /// <summary>
        /// One or more numeric attribute values.
        /// </summary>
        public Span<long> ValuesInt64 => new Span<long>(pValues, ValueCount);

        /// <summary>
        /// One or more numeric attribute values.
        /// </summary>
        public Span<ulong> ValuesUInt64 => new Span<ulong>(pValues, ValueCount);

        /// <summary>
        /// One or more string attribute values.
        /// </summary>
        public Span<LPWSTR> ValuesString => new Span<LPWSTR>(pValues, ValueCount);

        /// <summary>
        /// One or more <see cref="AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE"/> structures.
        /// </summary>
        public Span<AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE> ValuesFqbn =>
            new Span<AUTHZ_SECURITY_ATTRIBUTE_FQBN_VALUE>(pValues, ValueCount);

        /// <summary>
        /// One or more <see cref="AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> structures.
        /// </summary>
        public Span<AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE> ValuesOctetString =>
            new Span<AUTHZ_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE>(pValues, ValueCount);
    }
}
