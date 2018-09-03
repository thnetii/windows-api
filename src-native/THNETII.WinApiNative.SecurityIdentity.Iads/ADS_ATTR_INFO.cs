using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApiNative.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_ATTR_INFO"/> structure is used to contain one or more attribute values for use with the <see cref="IDirectoryObject.CreateDSObject"/>, <see cref="IDirectoryObject.GetObjectAttributes"/>, or <see cref="IDirectoryObject.SetObjectAttributes"/> method.
    /// </summary>
    /// <remarks>
    /// <para>In ADSI, attributes and properties are used interchangeably. Set attributes, when creating a directory service object, using the <see cref="IDirectoryObject.CreateDSObject"/> method. The <see cref="IDirectoryObject"/> interface also supports the <see cref="IDirectoryObject.GetObjectAttributes"/> and <see cref="IDirectoryObject.SetObjectAttributes"/> methods for retrieving and modifying the attributes of the object in a directory.</para>
    /// <para>Memory for the array of <see cref="ADSVALUE"/> structures is not allocated with this structure.</para>
    /// <para>The value of the <see cref="dwControlCode"/> member is ignored when the structure is used as an out parameter.</para>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/nb-no/windows/desktop/api/iads/ns-iads-_ads_attr_info">_ads_attr_info structure</a></para>
    /// </remarks>
    /// <see cref="ADSTYPE"/>
    /// <see cref="IDirectoryObject"/>
    /// <see cref="IDirectoryObject.CreateDSObject"/>
    /// <see cref="IDirectoryObject.GetObjectAttributes"/>
    /// <see cref="IDirectoryObject.SetObjectAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_ATTR_INFO
    {
        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the attribute name.
        /// </summary>
        public IntPtr pszAttrName;

        /// <summary>
        /// Gets a span over the characters of the string that contains the attribute name.
        /// </summary>
        public Span<char> AttrName => pszAttrName.AsZeroTerminatedUnicodeSpan();

        /// <summary>
        /// Contains one of the ADSI Attribute Modification Types values that determines the type of operation to be performed on the attribute value.
        /// </summary>
        public ADS_ATTR_TYPE dwControlCode;

        /// <summary>
        /// A value from the <see cref="ADSTYPE"/> enumeration that indicates the data type of the attribute.
        /// </summary>
        public ADSTYPE dwADsType;

        /// <summary>
        /// Pointer to an array of <see cref="ADSVALUE"/> structures that contain values for the attribute.
        /// </summary>
        public IntPtr pADsValues;

        /// <summary>
        /// Size of the <see cref="pADsValues"/> array.
        /// </summary>
        public int dwNumValues;

        /// <summary>
        /// Gets a span over the ADSI Values stored in the array pointed to by <see cref="pADsValues"/>.
        /// </summary>
        public Span<ADSVALUE> ADsValues =>
            pADsValues.AsRefStructSpan<ADSVALUE>(dwNumValues);
    }
}
