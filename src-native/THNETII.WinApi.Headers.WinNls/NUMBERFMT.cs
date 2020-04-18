using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1115
    //
    //  Number format.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1119
    /// <inheritdoc cref="NUMBERFMT"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct NUMBERFMTA
    {
        /// <inheritdoc cref="NUMBERFMT.NumDigits"/>
        public int NumDigits;                 // number of decimal digits
        /// <inheritdoc cref="NUMBERFMT.LeadingZero"/>
        public int LeadingZero;               // if leading zero in decimal fields
        /// <inheritdoc cref="NUMBERFMT.Grouping"/>
        public int Grouping;                  // group size left of decimal
        /// <inheritdoc cref="NUMBERFMT.lpDecimalSep"/>
        public LPSTR lpDecimalSep;              // ptr to decimal separator string
        /// <inheritdoc cref="NUMBERFMT.lpThousandSep"/>
        public LPSTR lpThousandSep;             // ptr to thousand separator string
        /// <inheritdoc cref="NUMBERFMT.NegativeOrder"/>
        public int NegativeOrder;             // negative number ordering
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1127
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct NUMBERFMTW
    {
        /// <inheritdoc cref="NUMBERFMT.NumDigits"/>
        public int NumDigits;                 // number of decimal digits
        /// <inheritdoc cref="NUMBERFMT.LeadingZero"/>
        public int LeadingZero;               // if leading zero in decimal fields
        /// <inheritdoc cref="NUMBERFMT.Grouping"/>
        public int Grouping;                  // group size left of decimal
        /// <inheritdoc cref="NUMBERFMT.lpDecimalSep"/>
        public LPWSTR lpDecimalSep;              // ptr to decimal separator string
        /// <inheritdoc cref="NUMBERFMT.lpThousandSep"/>
        public LPWSTR lpThousandSep;             // ptr to thousand separator string
        /// <inheritdoc cref="NUMBERFMT.NegativeOrder"/>
        public int NegativeOrder;             // negative number ordering
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1135
    /// <summary>
    /// Contains information that defines the format of a number string. The <see cref="GetNumberFormat"/> function uses this information to customize a number string for a specified locale.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-numberfmtw">NUMBERFMTW structure</a></para>
    /// </remarks>
    /// <seealso cref="GetNumberFormat"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
#if NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential)]
#else
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#endif
    public struct NUMBERFMT
    {
        /// <summary>
        /// Number of fractional digits. This value is equivalent to the locale information specified by the value <see cref="LOCALE_IDIGITS"/>.
        /// </summary>
        public int NumDigits;                 // number of decimal digits
        /// <summary>
        /// A value indicating if leading zeros should be used in decimal fields. This value is equivalent to the locale information specified by the value <see cref="LOCALE_ILZERO"/>.
        /// </summary>
        public int LeadingZero;               // if leading zero in decimal fields
        /// <summary>
        /// Number of digits in each group of numbers to the left of the decimal separator specified by <see cref="lpDecimalSep"/>. Values in the range 0 through 9 and 32 are valid. The most significant grouping digit indicates the number of digits in the least significant group immediately to the left of the decimal separator. Each subsequent grouping digit indicates the next significant group of digits to the left of the previous group. If the last value supplied is not 0, the remaining groups repeat the last group. Typical examples of settings for this member are: <c>0</c> to group digits as in <c>123456789.00</c>; <c>3</c> to group digits as in <c>123,456,789.00</c>; and <c>32</c> to group digits as in <c>12,34,56,789.00</c>.
        /// <para><note>You can use settings other than the typical settings, but they will not show up in the regional and language options portion of the Control Panel. Such settings are extremely uncommon and might have unexpected results.</note></para>
        /// </summary>
        public int Grouping;                  // group size left of decimal
        /// <summary>
        /// Pointer to a null-terminated decimal separator string.
        /// </summary>
        public LPTSTR lpDecimalSep;              // ptr to decimal separator string
        /// <summary>
        /// Pointer to a null-terminated thousand separator string.
        /// </summary>
        public LPTSTR lpThousandSep;             // ptr to thousand separator string
        /// <summary>
        /// Negative number mode. This mode is equivalent to the locale information specified by the value <see cref="LOCALE_INEGNUMBER"/>.
        /// </summary>
        public int NegativeOrder;             // negative number ordering
    }
}
