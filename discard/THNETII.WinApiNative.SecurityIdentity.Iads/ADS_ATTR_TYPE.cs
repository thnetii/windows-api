namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The following constants are used with the <see cref="ADS_ATTR_INFO.dwControlCode"/> member of <see cref="ADS_ATTR_INFO"/> structure to specify the type of operation to be performed when an attribute is modified with the <see cref="IDirectoryObject.SetObjectAttributes"/> method. For more information about using these values, see <a href="https://docs.microsoft.com/nb-no/windows/desktop/ADSI/modifying-attributes-with-adsi">Modifying Attributes with ADSI</a>.
    /// </summary>
    /// <remarks>
    /// These constants are intended to be used with the <see cref="ADS_ATTR_INFO"/> structure in the <see cref="IDirectoryObject.SetObjectAttributes"/> method. These constants should not be confused with members of the <see cref="ADS_PROPERTY_OPERATION_ENUM"/> enumeration, which are intended to be used with the <see cref="IADs.PutEx"/> method.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/ADSI/adsi-attribute-modification-types">ADSI Attribute Modification Types</a></para>
    /// </remarks>
    /// <seealso cref="ADS_ATTR_INFO"/>
    /// <seealso cref="IDirectoryObject.SetObjectAttributes"/>
    public enum ADS_ATTR_TYPE : int
    {
        /// <summary>
        /// Causes all attribute values to be removed from an object.
        /// </summary>
        ADS_ATTR_CLEAR = 1,
        /// <summary>
        /// Causes the specified attribute values to be updated.
        /// </summary>
        ADS_ATTR_UPDATE = 2,
        /// <summary>
        /// Causes the specified attribute values to be appended to the existing attribute values.
        /// </summary>
        ADS_ATTR_APPEND = 3,
        /// <summary>
        /// Causes the specified attribute values to be removed from an object.
        /// </summary>
        ADS_ATTR_DELETE = 4
    }
}
