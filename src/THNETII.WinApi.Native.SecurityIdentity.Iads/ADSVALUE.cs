using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using THNETII.WinApi.Native.Time;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// <para>The <see cref="ADSVALUE"/> structure contains a value specified as an ADSI data type. These data types can be <a href="https://msdn.microsoft.com/0bd34f13-269f-4f5d-8a18-74577522e402">ADSI Simple Data Types</a> or ADSI-defined custom data types that include C-style structures.</para>
    /// <para>The <see cref="ADS_ATTR_INFO"/> structure contains an array of <see cref="ADSVALUE"/> structures. Each <see cref="ADSVALUE"/> structure contains a single attribute value.</para>
    /// </summary>
    /// <remarks>
    /// Members of the <see cref="ADSVALUE"/> structure specify the data type of attributes. For more information and a code example, see <see cref="ADS_ATTR_INFO"/>.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-_adsvalue">_adsvalue structure</a></para>
    /// </remarks>
    /// <seealso cref="ADSTYPE"/>
    /// <seealso cref="ADS_ATTR_INFO"/>
    /// <seealso cref="ADS_BACKLINK"/>
    /// <seealso cref="ADS_CASEIGNORE_LIST"/>
    /// <seealso cref="ADS_DN_WITH_BINARY"/>
    /// <seealso cref="ADS_DN_WITH_STRING"/>
    /// <seealso cref="ADS_EMAIL"/>
    /// <seealso cref="ADS_FAXNUMBER"/>
    /// <seealso cref="ADS_HOLD"/>
    /// <seealso cref="ADS_NETADDRESS"/>
    /// <seealso cref="ADS_NT_SECURITY_DESCRIPTOR"/>
    /// <seealso cref="ADS_OCTET_LIST"/>
    /// <seealso cref="ADS_OCTET_STRING"/>
    /// <seealso cref="ADS_PATH"/>
    /// <seealso cref="ADS_POSTALADDRESS"/>
    /// <seealso cref="ADS_PROV_SPECIFIC"/>
    /// <seealso cref="ADS_REPLICAPOINTER"/>
    /// <seealso cref="ADS_TIMESTAMP"/>
    /// <seealso cref="ADS_TYPEDNAME"/>
    /// <seealso cref="IDirectoryObject.CreateDSObject"/>
    /// <seealso cref="IDirectoryObject.GetObjectAttributes"/>
    /// <seealso cref="IDirectoryObject.SetObjectAttributes"/>
    /// <seealso cref="IDirectorySearch.SetSearchPreference"/>
    [StructLayout(LayoutKind.Explicit)]
    public struct ADSVALUE
    {
        /// <summary>
        /// Data type used to interpret the union member of the structure. Values of this member are taken from the <see cref="ADSTYPE"/> enumeration.
        /// </summary>
        [FieldOffset(0)]
        public ADSTYPE dwType;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszDNString;

        public Span<char> DNString => pszDNString.AsZeroTerminatedUnicodeSpan();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszCaseExactString;

        public Span<char> CaseExactString => pszCaseExactString.AsZeroTerminatedUnicodeSpan();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszCaseIgnoreString;

        public Span<char> CaseIgnoreString => pszCaseIgnoreString.AsZeroTerminatedUnicodeSpan();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszPrintableString;

        public Span<char> PrintableString => pszPrintableString.AsZeroTerminatedUnicodeSpan();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszNumericString;

        public Span<char> NumericString => pszNumericString.AsZeroTerminatedUnicodeSpan();

        public bool Boolean
        {
            get => Integer != 0;
            set => Integer = value ? 1 : 0;
        }

        [FieldOffset(sizeof(ADSTYPE))]
        public int Integer;

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_OCTET_STRING OctetString;

        [FieldOffset(sizeof(ADSTYPE))]
        public SYSTEMTIME UTCTime;

        [FieldOffset(sizeof(ADSTYPE))]
        public long LargeInteger;

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pszClassName;

        public Span<char> ClassName => pszClassName.AsZeroTerminatedUnicodeSpan();

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_PROV_SPECIFIC ProviderSpecific;

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pCaseIgnoreList;

        public ref ADS_CASEIGNORE_LIST CaseIgnoreList =>
            ref pCaseIgnoreList.AsRefStruct<ADS_CASEIGNORE_LIST>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pOctetList;

        public ref ADS_OCTET_LIST OctetList =>
            ref pOctetList.AsRefStruct<ADS_OCTET_LIST>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pPath;

        public ref ADS_PATH Path =>
            ref pPath.AsRefStruct<ADS_PATH>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pPostalAddress;

        public ADS_POSTALADDRESS GetPostalAddress() =>
            Marshal.PtrToStructure<ADS_POSTALADDRESS>(pPostalAddress);

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_TIMESTAMP Timestamp;

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_BACKLINK BackLink;

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pTypedName;

        public ref ADS_TYPEDNAME TypedName =>
            ref pTypedName.AsRefStruct<ADS_TYPEDNAME>();

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_HOLD Hold;

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pNetAddress;

        public ref ADS_NETADDRESS NetAddress =>
            ref pNetAddress.AsRefStruct<ADS_NETADDRESS>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pReplicaPointer;

        public ref ADS_REPLICAPOINTER ReplicaPointer =>
            ref pReplicaPointer.AsRefStruct<ADS_REPLICAPOINTER>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pFaxNumber;

        public ref ADS_FAXNUMBER FaxNumber =>
            ref pFaxNumber.AsRefStruct<ADS_FAXNUMBER>();

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_EMAIL Email;

        [FieldOffset(sizeof(ADSTYPE))]
        public ADS_NT_SECURITY_DESCRIPTOR SecurityDescriptor;

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pDNWithBinary;

        public ref ADS_DN_WITH_BINARY DNWithBinary =>
            ref pDNWithBinary.AsRefStruct<ADS_DN_WITH_BINARY>();

        [FieldOffset(sizeof(ADSTYPE))]
        public IntPtr pDNWithString;

        public ref ADS_DN_WITH_STRING DNWithString =>
            ref pDNWithString.AsRefStruct<ADS_DN_WITH_STRING>();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
