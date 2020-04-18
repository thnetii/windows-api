using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1144
    //
    //  Currency format.
    //

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1148
    /// <inheritdoc cref="CURRENCYFMT"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CURRENCYFMTA
    {
        /// <inheritdoc cref="CURRENCYFMT.NumDigits"/>
        public int NumDigits;                 // number of decimal digits
        /// <inheritdoc cref="CURRENCYFMT.LeadingZero"/>
        public int LeadingZero;               // if leading zero in decimal fields
        /// <inheritdoc cref="CURRENCYFMT.Grouping"/>
        public int Grouping;                  // group size left of decimal
        /// <inheritdoc cref="CURRENCYFMT.lpDecimalSep"/>
        public LPSTR lpDecimalSep;              // ptr to decimal separator string
        /// <inheritdoc cref="CURRENCYFMT.lpThousandSep"/>
        public LPSTR lpThousandSep;             // ptr to thousand separator string
        /// <inheritdoc cref="CURRENCYFMT.NegativeOrder"/>
        public int NegativeOrder;             // negative currency ordering
        /// <inheritdoc cref="CURRENCYFMT.PositiveOrder"/>
        public int PositiveOrder;             // positive currency ordering
        /// <inheritdoc cref="CURRENCYFMT.lpCurrencySymbol"/>
        public LPSTR lpCurrencySymbol;          // ptr to currency symbol string
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1158
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CURRENCYFMTW
    {
        /// <inheritdoc cref="CURRENCYFMT.NumDigits"/>
        public int NumDigits;                 // number of decimal digits
        /// <inheritdoc cref="CURRENCYFMT.LeadingZero"/>
        public int LeadingZero;               // if leading zero in decimal fields
        /// <inheritdoc cref="CURRENCYFMT.Grouping"/>
        public int Grouping;                  // group size left of decimal
        /// <inheritdoc cref="CURRENCYFMT.lpDecimalSep"/>
        public LPWSTR lpDecimalSep;              // ptr to decimal separator string
        /// <inheritdoc cref="CURRENCYFMT.lpThousandSep"/>
        public LPWSTR lpThousandSep;             // ptr to thousand separator string
        /// <inheritdoc cref="CURRENCYFMT.NegativeOrder"/>
        public int NegativeOrder;             // negative currency ordering
        /// <inheritdoc cref="CURRENCYFMT.PositiveOrder"/>
        public int PositiveOrder;             // positive currency ordering
        /// <inheritdoc cref="CURRENCYFMT.lpCurrencySymbol"/>
        public LPWSTR lpCurrencySymbol;          // ptr to currency symbol string
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1168
    /// <summary>
    /// Contains information that defines the format of a currency string. The <see cref="GetCurrencyFormat"/> function uses this information to customize a currency string for a specified locale.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ns-winnls-currencyfmtw">CURRENCYFMTW structure</a></para>
    /// </remarks>
    /// <seealso cref="GetCurrencyFormat"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-structures">National Language Support Structures</seealso>
#if NETSTANDARD1_3
    [StructLayout(LayoutKind.Sequential)]
#else
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#endif
    public struct CURRENCYFMT
    {
        /// <summary>
        /// Number of fractional digits. This number is equivalent to <see cref="LOCALE_ICURRDIGITS"/>.
        /// </summary>
        public int NumDigits;                 // number of decimal digits
        /// <summary>
        /// Value indicating if leading zeros should be used in decimal fields. This value is equivalent to <see cref="LOCALE_ILZERO"/>.
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
        /// Negative currency mode. This mode is equivalent to <see cref="LOCALE_INEGCURR"/>.
        /// </summary>
        public int NegativeOrder;             // negative currency ordering
        /// <summary>
        /// Positive currency mode. This mode is equivalent to <see cref="LOCALE_ICURRENCY"/>.
        /// </summary>
        public int PositiveOrder;             // positive currency ordering
        /// <summary>
        /// Pointer to a null-terminated currency symbol string.
        /// </summary>
        public LPTSTR lpCurrencySymbol;          // ptr to currency symbol string
    }
}
