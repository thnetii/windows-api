namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADSTYPE"/> enumeration is used to identify the data type of an ADSI property value.
    /// </summary>
    /// <remarks>
    /// <para>When extending the active directory schema to add <see cref="ADS_DN_WITH_BINARY"/>, you must also specify the "otherWellKnownGuid" attribute definition. Add the following to the ldf file attribute definition: "omObjectClass:: KoZIhvcUAQEBCw=="</para>
    /// <para>When extending the active directory schema to add <see cref="ADS_DN_WITH_STRING"/>, you must also specify the "otherWellKnownGuid" attribute definition. Add the following to the ldf file attribute definition: "omObjectClass:: KoZIhvcUAQEBDA=="</para>
    /// <para>Because VBScript cannot read data from a type library, VBScript applications do not recognize symbolic constants, as defined above. Use the numerical constants instead to set the appropriate flags in your VBScript application. To use the symbolic constants as a good programming practice, write explicit declarations of such constants, as done here, in your VBScript application.</para>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ne-iads-__midl___midl_itf_ads_0000_0000_0001">__MIDL___MIDL_itf_ads_0000_0000_0001 Enumeration</a></para>
    /// </remarks>
    public enum ADSTYPE
    {
        /// <summary>
        /// The data type is not valid
        /// </summary>
        ADSTYPE_INVALID = 0,
        /// <summary>
        /// The string is of Distinguished Name (path) of a directory service object.
        /// </summary>
        ADSTYPE_DN_STRING = (ADSTYPE_INVALID + 1),
        /// <summary>
        /// The string is of the case-sensitive type.
        /// </summary>
        ADSTYPE_CASE_EXACT_STRING = (ADSTYPE_DN_STRING + 1),
        /// <summary>
        /// The string is of the case-insensitive type.
        /// </summary>
        ADSTYPE_CASE_IGNORE_STRING = (ADSTYPE_CASE_EXACT_STRING + 1),
        /// <summary>
        /// The string is displayable on screen or in print.
        /// </summary>
        ADSTYPE_PRINTABLE_STRING = (ADSTYPE_CASE_IGNORE_STRING + 1),
        /// <summary>
        /// The string is of a numeral to be interpreted as text.
        /// </summary>
        ADSTYPE_NUMERIC_STRING = (ADSTYPE_PRINTABLE_STRING + 1),
        /// <summary>
        /// The data is of a Boolean value.
        /// </summary>
        ADSTYPE_BOOLEAN = (ADSTYPE_NUMERIC_STRING + 1),
        /// <summary>
        /// The data is of an integer value.
        /// </summary>
        ADSTYPE_INTEGER = (ADSTYPE_BOOLEAN + 1),
        /// <summary>
        /// The string is of a byte array.
        /// </summary>
        ADSTYPE_OCTET_STRING = (ADSTYPE_INTEGER + 1),
        /// <summary>
        /// The data is of the universal time as expressed in Universal Time Coordinate (UTC).
        /// </summary>
        ADSTYPE_UTC_TIME = (ADSTYPE_OCTET_STRING + 1),
        /// <summary>
        /// The data is of a long integer value.
        /// </summary>
        ADSTYPE_LARGE_INTEGER = (ADSTYPE_UTC_TIME + 1),
        /// <summary>
        /// The string is of a provider-specific string.
        /// </summary>
        ADSTYPE_PROV_SPECIFIC = (ADSTYPE_LARGE_INTEGER + 1),
        /// <summary>
        /// Not used.
        /// </summary>
        ADSTYPE_OBJECT_CLASS = (ADSTYPE_PROV_SPECIFIC + 1),
        /// <summary>
        /// The data is of a list of case insensitive strings.
        /// </summary>
        ADSTYPE_CASEIGNORE_LIST = (ADSTYPE_OBJECT_CLASS + 1),
        /// <summary>
        /// The data is of a list of octet strings.
        /// </summary>
        ADSTYPE_OCTET_LIST = (ADSTYPE_CASEIGNORE_LIST + 1),
        /// <summary>
        /// The string is of a directory path.
        /// </summary>
        ADSTYPE_PATH = (ADSTYPE_OCTET_LIST + 1),
        /// <summary>
        /// The string is of the postal address type.
        /// </summary>
        ADSTYPE_POSTALADDRESS = (ADSTYPE_PATH + 1),
        /// <summary>
        /// The data is of a time stamp in seconds.
        /// </summary>
        ADSTYPE_TIMESTAMP = (ADSTYPE_POSTALADDRESS + 1),
        /// <summary>
        /// The string is of a back link.
        /// </summary>
        ADSTYPE_BACKLINK = (ADSTYPE_TIMESTAMP + 1),
        /// <summary>
        /// The string is of a typed name.
        /// </summary>
        ADSTYPE_TYPEDNAME = (ADSTYPE_BACKLINK + 1),
        /// <summary>
        /// The data is of the Hold data structure.
        /// </summary>
        ADSTYPE_HOLD = (ADSTYPE_TYPEDNAME + 1),
        /// <summary>
        /// The string is of a net address.
        /// </summary>
        ADSTYPE_NETADDRESS = (ADSTYPE_HOLD + 1),
        /// <summary>
        /// The data is of a replica pointer.
        /// </summary>
        ADSTYPE_REPLICAPOINTER = (ADSTYPE_NETADDRESS + 1),
        /// <summary>
        /// The string is of a fax number.
        /// </summary>
        ADSTYPE_FAXNUMBER = (ADSTYPE_REPLICAPOINTER + 1),
        /// <summary>
        /// The data is of an email message.
        /// </summary>
        ADSTYPE_EMAIL = (ADSTYPE_FAXNUMBER + 1),
        /// <summary>
        /// The data is a Windows security descriptor as represented by a byte array.
        /// </summary>
        ADSTYPE_NT_SECURITY_DESCRIPTOR = (ADSTYPE_EMAIL + 1),
        /// <summary>
        /// The data is of an undefined type.
        /// </summary>
        ADSTYPE_UNKNOWN = (ADSTYPE_NT_SECURITY_DESCRIPTOR + 1),
        /// <summary>
        /// The data is of <see cref="ADS_DN_WITH_BINARY"/> used for mapping a distinguished name to a nonvarying GUID. For more information, see the Remarks of the <see cref="ADSTYPE"/> Enumeration.
        /// </summary>
        ADSTYPE_DN_WITH_BINARY = (ADSTYPE_UNKNOWN + 1),
        /// <summary>
        /// The data is of <see cref="ADS_DN_WITH_STRING"/> used for mapping a distinguished name to a nonvarying string value. For more information, see Remarks of the <see cref="ADSTYPE"/> Enumeration.
        /// </summary>
        ADSTYPE_DN_WITH_STRING = (ADSTYPE_DN_WITH_BINARY + 1)
    }
}
