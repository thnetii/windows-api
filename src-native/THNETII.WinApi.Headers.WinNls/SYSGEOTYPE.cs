using System;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1256
    //
    //  GEO information types for clients to query
    //
    // Please use GetGeoInfoEx and query by country/region name instead of GEOID (eg: "US" instead of 244)

    /// <summary>
    /// Defines the type of geographical location information requested in the <see cref="GetGeoInfo"/> or <see cref="GetGeoInfoEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ne-winnls-sysgeotype">SYSGEOTYPE enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetGeoInfo"/>
    /// <seealso cref="GetGeoInfoEx"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-enumeration-types">National Language Support Enumeration Types</seealso>
    public enum SYSGEOTYPE
    {
        /// <summary>
        /// The geographical location identifier (GEOID) of a nation. This value is stored in a long integer.
        /// <para><strong>Starting with Windows 10, version 1709:</strong> This value is not supported for the <see cref="GetGeoInfoEx"/> function, and should not be used.</para>
        /// </summary>
        [Obsolete("Starting with Windows 10, version 1709: This value is not supported for the GetGeoInfoEx function, and should not be used.")]
        GEO_NATION = 0x0001, // DEPRECATED Not used by name API
        /// <summary>
        /// The latitude of the location. This value is stored in a floating-point number.
        /// </summary>
        GEO_LATITUDE = 0x0002,
        /// <summary>
        /// The longitude of the location. This value is stored in a floating-point number.
        /// </summary>
        GEO_LONGITUDE = 0x0003,
        /// <summary>
        /// The ISO 2-letter country/region code. This value is stored in a string.
        /// </summary>
        GEO_ISO2 = 0x0004,
        /// <summary>
        /// The ISO 3-letter country/region code. This value is stored in a string.
        /// </summary>
        GEO_ISO3 = 0x0005,
        /// <summary>
        /// The name for a string, compliant with RFC 4646 (starting with Windows Vista), that is derived from the <see cref="GetGeoInfo"/> parameters <em>language</em> and <em>GeoId</em>.
        /// <para><strong>Starting with Windows 10, version 1709:</strong> This value is not supported for the <see cref="GetGeoInfoEx"/> function, and should not be used.</para>
        /// </summary>
        [Obsolete("Starting with Windows 10, version 1709: This value is not supported for the GetGeoInfoEx function, and should not be used.")]
        GEO_RFC1766 = 0x0006, // DEPRECATED and misleading, not used by name API
        /// <summary>
        /// A locale identifier derived using <see cref="GetGeoInfo"/>.
        /// <para><strong>Starting with Windows 10, version 1709:</strong> This value is not supported for the <see cref="GetGeoInfoEx"/> function, and should not be used.</para>
        /// </summary>
        [Obsolete("Starting with Windows 10, version 1709: This value is not supported for the GetGeoInfoEx function, and should not be used.")]
        GEO_LCID = 0x0007, // DEPRECATED Not used by name API
        /// <summary>
        /// The friendly name of the nation, for example, Germany. This value is stored in a string.
        /// </summary>
        GEO_FRIENDLYNAME = 0x0008,
        /// <summary>
        /// The official name of the nation, for example, Federal Republic of Germany. This value is stored in a string.
        /// </summary>
        GEO_OFFICIALNAME = 0x0009,
        /// <summary>
        /// Not implemented.
        /// </summary>
        GEO_TIMEZONES = 0x000A, // Not implemented
        /// <summary>
        /// Not implemented.
        /// </summary>
        GEO_OFFICIALLANGUAGES = 0x000B, // Not implemented
        /// <summary>
        /// <strong>Starting with Windows 8</strong>: The ISO 3-digit country/region code. This value is stored in a string.
        /// </summary>
        GEO_ISO_UN_NUMBER = 0x000C,
        /// <summary>
        /// <strong>Starting with Windows 8</strong>: The geographical location identifier of the parent region of a country/region. This value is stored in a string.
        /// </summary>
        GEO_PARENT = 0x000D,
        /// <summary>
        /// <strong>Starting with Windows 10, version 1709</strong>: The dialing code to use with telephone numbers in the geographic location. For example, 1 for the United States.
        /// </summary>
        GEO_DIALINGCODE = 0x000E,
        /// <summary>
        /// <strong>Starting with Windows 10, version 1709</strong>: The three-letter code for the currency that the geographic location uses. For example, USD for United States dollars.
        /// </summary>
        GEO_CURRENCYCODE = 0x000F, // eg: USD
        /// <summary>
        /// <strong>Starting with Windows 10, version 1709</strong>: The symbol for the currency that the geographic location uses. For example, the dollar sign ($).
        /// </summary>
        GEO_CURRENCYSYMBOL = 0x0010, // eg: $
        /// <summary>
        /// <strong>Starting with Windows 10, version 1709</strong>: The two-letter International Organization for Standardization (ISO) 3166-1 code or numeric United Nations (UN) Series M, Number 49 (M.49) code for the geographic region.
        /// <para>For information about two-letter ISO 3166-1 codes, see <a href="https://www.iso.org/iso-3166-country-codes.html">Country Codes - ISO 3166</a>. For information about numeric UN M.49 codes, see <a href="https://unstats.un.org/unsd/methodology/m49/">Standard country or area codes for statistical use (M49)</a>.</para>
        /// </summary>
        GEO_NAME = 0x0011, // Name, eg: US or 001
        /// <summary>
        /// <strong>Starting with Windows 10, version 1709</strong>: The Windows geographical location identifiers (GEOID) for the region. This value is provided for backward compatibility. Do not use this value in new applications, but use <see cref="GEO_NAME"/> instead.
        /// </summary>
        [Obsolete("Starting with Windows 10, version 1709: The Windows geographical location identifiers (GEOID) for the region. This value is provided for backward compatibility. Do not use this value in new applications, but use GEO_NAME instead.")]
        GEO_ID = 0x0012  // DEPRECATED - For compatibility, please avoid
    }
}
