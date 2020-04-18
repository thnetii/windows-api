using System;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h
    ////////////////////////////////////////////////////////////////////////////
    //
    //  Constants
    //
    //  Define all constants for the NLS component here.
    //
    ////////////////////////////////////////////////////////////////////////////

    public static class WinNlsConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 98
        //
        //  String Length Maximums.
        //
        public const int MAX_LEADBYTES = 12;    // 5 ranges, 2 bytes ea., 0 term.
        public const int MAX_DEFAULTCHAR = 2;   // single or double byte

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 104
        //
        //  Surrogate pairs
        //
        //  Conversion examples:
        //
        //  A) The first character in the Surrogate range (D800, DC00) as UTF-32:
        //
        //  1.  D800: binary 1101100000000000  (lower ten bits: 0000000000)
        //  2.  DC00: binary 1101110000000000  (lower ten bits: 0000000000)
        //  3.  Concatenate 0000000000+0000000000 = 0x0000
        //  4.  Add 0x10000
        //
        //  Result: U+10000. This is correct, since the first character in the Supplementary character
        //  range immediately follows the last code point in the 16-bit UTF-16 range (U+FFFF)
        //
        //  B) A UTF-32 code point such as U+2040A (this a CJK character in CJK Extension B), and wish
        //  to convert it in UTF-16:
        //
        //  1.  Subtract 0x10000 - Result: 0x1040A
        //  2.  Split into two ten-bit pieces: 0001000001 0000001010
        //  3.  Add 1101100000000000 (0xD800) to the high 10 bits piece (0001000001) - Result: 1101100001000001 (0xD841)
        //  4.  Add 1101110000000000 (0xDC00) to the low 10 bits piece (0000001010) - Result: 1101110000001010 (0xDC0A)
        //
        //  RESULT: The surrogate pair: U+D841, U+DC0A
        //
        //  Special Unicode code point values, for use with UTF-16 surrogate pairs.
        //
        public const short HIGH_SURROGATE_START = unchecked((short)0xd800);
        public const short HIGH_SURROGATE_END = unchecked((short)0xdbff);
        public const short LOW_SURROGATE_START = unchecked((short)0xdc00);
        public const short LOW_SURROGATE_END = unchecked((short)0xdfff);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 137
        //
        //  MBCS and Unicode Translation Flags.
        //  Please use Unicode, either UTF-16 (WCHAR) or UTF-8 (CP_UTF8)
        //
        // MB_PRECOMPOSED and MB_COMPOSITE are deprecated, not recommended, and
        // provide out-of-date behavior.
        // Windows typically uses Unicode Normalization Form C type sequences,
        // If explicit normalization forms are required, please use NormalizeString.
        [Obsolete("DEPRECATED: use single precomposed characters when possible.")]
        public const int MB_PRECOMPOSED = 0x00000001;
        [Obsolete("DEPRECATED: use multiple discrete characters when possible.")]
        public const int MB_COMPOSITE = 0x00000002;
        [Obsolete("DEPRECATED: use glyph chars, not ctrl chars")]
        public const int MB_USEGLYPHCHARS = 0x00000004;
        public const int MB_ERR_INVALID_CHARS = 0x00000008; // error for invalid chars

        // WC_COMPOSITECHECK, WC_DISCARDNS and WC_SEPCHARS are deprecated, not recommended,
        // and provide out-of-date behavior.
        // Windows typically uses Unicode Normalization Form C type sequences,
        // If explicit normalization forms are required, please use NormalizeString.
        /// <summary>convert composite to precomposed</summary>
        public const int WC_COMPOSITECHECK = 0x00000200;
        /// <summary>
        /// discard non-spacing chars
        /// <para>Used with <see cref="WC_COMPOSITECHECK"/></para>
        /// </summary>
        public const int WC_DISCARDNS = 0x00000010;
        /// <summary>
        /// generate separate chars
        /// <para>Used with <see cref="WC_COMPOSITECHECK"/></para>
        /// </summary>
        public const int WC_SEPCHARS = 0x00000020;
        /// <summary>
        /// replace w/ default char
        /// <para>Used with <see cref="WC_COMPOSITECHECK"/></para>
        /// </summary>
        public const int WC_DEFAULTCHAR = 0x00000040;
        /// <summary>error for invalid chars</summary>
        public const int WC_ERR_INVALID_CHARS = 0x00000080;
        /// <summary>do not use best fit chars</summary>
        public const int WC_NO_BEST_FIT_CHARS = 0x00000400;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 167
        //
        //  Character Type Flags.
        //
        /// <summary>ctype 1 information</summary>
        public const int CT_CTYPE1 = 0x00000001;
        /// <summary>ctype 2 information</summary>
        public const int CT_CTYPE2 = 0x00000002;
        /// <summary>ctype 3 information</summary>
        public const int CT_CTYPE3 = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 174
        //
        //  CType 1 Flag Bits.
        //
        /// <summary>upper case</summary>
        public const short C1_UPPER = 0x0001;
        /// <summary>lower case</summary>
        public const short C1_LOWER = 0x0002;
        /// <summary>decimal digits</summary>
        public const short C1_DIGIT = 0x0004;
        /// <summary>spacing characters</summary>
        public const short C1_SPACE = 0x0008;
        /// <summary>punctuation characters</summary>
        public const short C1_PUNCT = 0x0010;
        /// <summary>control characters</summary>
        public const short C1_CNTRL = 0x0020;
        /// <summary>blank characters</summary>
        public const short C1_BLANK = 0x0040;
        /// <summary>other digits</summary>
        public const short C1_XDIGIT = 0x0080;
        /// <summary>any linguistic character</summary>
        public const short C1_ALPHA = 0x0100;
        /// <summary>defined character</summary>
        public const short C1_DEFINED = 0x0200;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 188
        //
        //  CType 2 Flag Bits.
        //
        /// <summary>left to right</summary>
        public const short C2_LEFTTORIGHT = 0x0001;
        /// <summary>right to left</summary>
        public const short C2_RIGHTTOLEFT = 0x0002;

        /// <summary>European number, digit</summary>
        public const short C2_EUROPENUMBER = 0x0003;
        /// <summary>European numeric separator</summary>
        public const short C2_EUROPESEPARATOR = 0x0004;
        /// <summary>European numeric terminator</summary>
        public const short C2_EUROPETERMINATOR = 0x0005;
        /// <summary>Arabic number</summary>
        public const short C2_ARABICNUMBER = 0x0006;
        /// <summary>common numeric separator</summary>
        public const short C2_COMMONSEPARATOR = 0x0007;

        /// <summary>block separator</summary>
        public const short C2_BLOCKSEPARATOR = 0x0008;
        /// <summary>segment separator</summary>
        public const short C2_SEGMENTSEPARATOR = 0x0009;
        /// <summary>white space</summary>
        public const short C2_WHITESPACE = 0x000A;
        /// <summary>other neutrals</summary>
        public const short C2_OTHERNEUTRAL = 0x000B;

        /// <summary>no implicit directionality</summary>
        public const short C2_NOTAPPLICABLE = 0x0000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 207
        //
        //  CType 3 Flag Bits.
        //
        /// <summary>nonspacing character</summary>
        public const short C3_NONSPACING = 0x0001;
        /// <summary>diacritic mark</summary>
        public const short C3_DIACRITIC = 0x0002;
        /// <summary>vowel mark</summary>
        public const short C3_VOWELMARK = 0x0004;
        /// <summary>symbols</summary>
        public const short C3_SYMBOL = 0x0008;

        /// <summary>katakana character</summary>
        public const short C3_KATAKANA = 0x0010;
        /// <summary>hiragana character</summary>
        public const short C3_HIRAGANA = 0x0020;
        /// <summary>half width character</summary>
        public const short C3_HALFWIDTH = 0x0040;
        /// <summary>full width character</summary>
        public const short C3_FULLWIDTH = 0x0080;
        /// <summary>ideographic character</summary>
        public const short C3_IDEOGRAPH = 0x0100;
        /// <summary>Arabic kashida character</summary>
        public const short C3_KASHIDA = 0x0200;
        /// <summary>lexical character</summary>
        public const short C3_LEXICAL = 0x0400;
        /// <summary>high surrogate code unit</summary>
        public const short C3_HIGHSURROGATE = 0x0800;
        /// <summary>low surrogate code unit</summary>
        public const short C3_LOWSURROGATE = 0x1000;

        /// <summary>any linguistic char (C1_ALPHA)</summary>
        public const short C3_ALPHA = unchecked((short)0x8000);

        /// <summary>ctype 3 is not applicable</summary>
        public const short C3_NOTAPPLICABLE = 0x0000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 230
        //
        //  String Flags.
        //
        /// <summary>ignore case</summary>
        public const int NORM_IGNORECASE = 0x00000001;
        /// <summary>ignore nonspacing chars</summary>
        public const int NORM_IGNORENONSPACE = 0x00000002;
        /// <summary>ignore symbols</summary>
        public const int NORM_IGNORESYMBOLS = 0x00000004;

        /// <summary>linguistically appropriate 'ignore case'</summary>
        public const int LINGUISTIC_IGNORECASE = 0x00000010;
        /// <summary>linguistically appropriate 'ignore nonspace'</summary>
        public const int LINGUISTIC_IGNOREDIACRITIC = 0x00000020;

        /// <summary>ignore kanatype</summary>
        public const int NORM_IGNOREKANATYPE = 0x00010000;
        /// <summary>ignore width</summary>
        public const int NORM_IGNOREWIDTH = 0x00020000;
        /// <summary>use linguistic rules for casing</summary>
        public const int NORM_LINGUISTIC_CASING = 0x08000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 245
        //
        //  Locale Independent Mapping Flags.
        //
        /// <summary>fold compatibility zone chars</summary>
        public const int MAP_FOLDCZONE = 0x00000010;
        /// <summary>convert to precomposed chars</summary>
        public const int MAP_PRECOMPOSED = 0x00000020;
        /// <summary>convert to composite chars</summary>
        public const int MAP_COMPOSITE = 0x00000040;
        /// <summary>all digits to ASCII 0-9</summary>
        public const int MAP_FOLDDIGITS = 0x00000080;

        /// <summary>expand all ligatures</summary>
        public const int MAP_EXPAND_LIGATURES = 0x00002000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 257
        //
        //  Locale Dependent Mapping Flags.
        //
        /// <summary>lower case letters</summary>
        public const int LCMAP_LOWERCASE = 0x00000100;
        /// <summary>UPPER CASE LETTERS</summary>
        public const int LCMAP_UPPERCASE = 0x00000200;
        /// <summary>Title Case Letters</summary>
        public const int LCMAP_TITLECASE = 0x00000300;

        /// <summary>WC sort key (normalize)</summary>
        public const int LCMAP_SORTKEY = 0x00000400;
        /// <summary>byte reversal</summary>
        public const int LCMAP_BYTEREV = 0x00000800;

        /// <summary>map katakana to hiragana</summary>
        public const int LCMAP_HIRAGANA = 0x00100000;
        /// <summary>map hiragana to katakana</summary>
        public const int LCMAP_KATAKANA = 0x00200000;
        /// <summary>map double byte to single byte</summary>
        public const int LCMAP_HALFWIDTH = 0x00400000;
        /// <summary>map single byte to double byte</summary>
        public const int LCMAP_FULLWIDTH = 0x00800000;

        /// <summary>use linguistic rules for casing</summary>
        public const int LCMAP_LINGUISTIC_CASING = 0x01000000;

        /// <summary>map traditional chinese to simplified chinese</summary>
        public const int LCMAP_SIMPLIFIED_CHINESE = 0x02000000;
        /// <summary>map simplified chinese to traditional chinese</summary>
        public const int LCMAP_TRADITIONAL_CHINESE = 0x04000000;

        public const int LCMAP_SORTHANDLE = 0x20000000;
        public const int LCMAP_HASH = 0x00040000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 285
        //
        //  Search Flags
        //
        /// <summary>see if value is at the beginning of source</summary>
        public const int FIND_STARTSWITH = 0x00100000;
        /// <summary>see if value is at the end of source</summary>
        public const int FIND_ENDSWITH = 0x00200000;
        /// <summary>look for value in source, starting at the beginning</summary>
        public const int FIND_FROMSTART = 0x00400000;
        /// <summary>look for value in source, starting at the end</summary>
        public const int FIND_FROMEND = 0x00800000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 294
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        // Language Group Enumeration Flags.
        //
        // The "Language Group" concept is an obsolete concept.
        // The groups returned are not well defined, arbitrary, inconsistent, inaccurate,
        // no longer maintained, and no longer supported.
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        /// <summary>installed language group ids</summary>
        public const int LGRPID_INSTALLED = 0x00000001;
        /// <summary>supported language group ids</summary>
        public const int LGRPID_SUPPORTED = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 309
        //
        //  Locale Enumeration Flags.
        //
        /// <summary>installed locale ids</summary>
        public const int LCID_INSTALLED = 0x00000001;
        /// <summary>supported locale ids</summary>
        public const int LCID_SUPPORTED = 0x00000002;
        /// <summary>alternate sort locale ids</summary>
        public const int LCID_ALTERNATE_SORTS = 0x00000004;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 317
        //
        //  Named based enumeration flags.
        //
        /// <summary>enumerate all named based locales</summary>
        public const int LOCALE_ALL = 0;
        /// <summary>shipped locales and/or replacements for them</summary>
        public const int LOCALE_WINDOWS = 0x00000001;
        /// <summary>supplemental locales only</summary>
        public const int LOCALE_SUPPLEMENTAL = 0x00000002;
        /// <summary>alternate sort locales</summary>
        public const int LOCALE_ALTERNATE_SORTS = 0x00000004;
        /// <summary>locales that replace shipped locales (callback flag only)</summary>
        public const int LOCALE_REPLACEMENT = 0x00000008;
        /// <summary>Locales that are "neutral" (language only, region data is default)</summary>
        public const int LOCALE_NEUTRALDATA = 0x00000010;
        /// <summary>Locales that contain language and region data</summary>
        public const int LOCALE_SPECIFICDATA = 0x00000020;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 333
        //
        //  Code Page Enumeration Flags.
        //
        /// <summary>installed code page ids</summary>
        public const int CP_INSTALLED = 0x00000001;
        /// <summary>supported code page ids</summary>
        public const int CP_SUPPORTED = 0x00000002;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 340
        //
        //  Sorting Flags.
        //
        //    WORD Sort:    culturally correct sort
        //                  hyphen and apostrophe are special cased
        //                  example: "coop" and "co-op" will sort together in a list
        //
        //                        co_op     <-------  underscore (symbol)
        //                        coat
        //                        comb
        //                        coop
        //                        co-op     <-------  hyphen (punctuation)
        //                        cork
        //                        went
        //                        were
        //                        we're     <-------  apostrophe (punctuation)
        //
        //
        //    STRING Sort:  hyphen and apostrophe will sort with all other symbols
        //
        //                        co-op     <-------  hyphen (punctuation)
        //                        co_op     <-------  underscore (symbol)
        //                        coat
        //                        comb
        //                        coop
        //                        cork
        //                        we're     <-------  apostrophe (punctuation)
        //                        went
        //                        were
        //
        /// <summary>use string sort method</summary>
        public const int SORT_STRINGSORT = 0x00001000;

        //  Sort digits as numbers (ie: 2 comes before 10)
        /// <summary>use digits as numbers sort method</summary>
        public const int SORT_DIGITSASNUMBERS = 0x00000008;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 378
        //
        //  Compare String Return Values.
        //
        /// <summary>string 1 less than string 2</summary>
        public const int CSTR_LESS_THAN = 1;
        /// <summary>string 1 equal to string 2</summary>
        public const int CSTR_EQUAL = 2;
        /// <summary>string 1 greater than string 2</summary>
        public const int CSTR_GREATER_THAN = 3;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 386
        //
        //  Code Page Default Values.
        //  Please Use Unicode, either UTF-16 (as in WCHAR) or UTF-8 (code page CP_ACP)
        //
        /// <summary>default to ANSI code page</summary>
        public const int CP_ACP = 0;
        /// <summary>default to OEM  code page</summary>
        public const int CP_OEMCP = 1;
        /// <summary>default to MAC  code page</summary>
        public const int CP_MACCP = 2;
        /// <summary>current thread's ANSI code page</summary>
        public const int CP_THREAD_ACP = 3;
        /// <summary>SYMBOL translations</summary>
        public const int CP_SYMBOL = 42;

        /// <summary>UTF-7 translation</summary>
        public const int CP_UTF7 = 65000;
        /// <summary>UTF-8 translation</summary>
        public const int CP_UTF8 = 65001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 399
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  Country/Region Codes.
        //
        //  DEPRECATED: The GEOID  concept is deprecated, please use
        //  Country/Region Names instead, eg: "US" instead of a GEOID like 244.
        //  See the documentation for GetGeoInfoEx.
        //
        //  WARNING: These values are arbitrarily assigned values, please use
        //           standard country/region names instead, such as "US".
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        private const string GEOID_DEPRECATION_MESSAGE =
            "DEPRECATED: The GEOID  concept is deprecated, please use " +
            "Country/Region Names instead, eg: \"US\" instead of a GEOID like 244. " +
            "See the documentation for GetGeoInfoEx.";

        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_DEFAULT = 0;

        /// <summary>Albania</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ALBANIA = 355;
        /// <summary>Algeria</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ALGERIA = 213;
        /// <summary>Argentina</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ARGENTINA = 54;
        /// <summary>Armenia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ARMENIA = 374;
        /// <summary>Australia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_AUSTRALIA = 61;
        /// <summary>Austria</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_AUSTRIA = 43;
        /// <summary>Azerbaijan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_AZERBAIJAN = 994;
        /// <summary>Bahrain</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BAHRAIN = 973;
        /// <summary>Belarus</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BELARUS = 375;
        /// <summary>Belgium</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BELGIUM = 32;
        /// <summary>Belize</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BELIZE = 501;
        /// <summary>Bolivia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BOLIVIA = 591;
        /// <summary>Brazil</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BRAZIL = 55;
        /// <summary>Brunei Darussalam</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BRUNEI_DARUSSALAM = 673;
        /// <summary>Bulgaria</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_BULGARIA = 359;
        /// <summary>Canada</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_CANADA = 2;
        /// <summary>Caribbean</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_CARIBBEAN = 1;
        /// <summary>Chile</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_CHILE = 56;
        /// <summary>Colombia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_COLOMBIA = 57;
        /// <summary>Costa Rica</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_COSTA_RICA = 506;
        /// <summary>Croatia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_CROATIA = 385;
        /// <summary>Czech Republic</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_CZECH = 420;
        /// <summary>Denmark</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_DENMARK = 45;
        /// <summary>Dominican Republic</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_DOMINICAN_REPUBLIC = 1;
        /// <summary>Ecuador</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ECUADOR = 593;
        /// <summary>Egypt</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_EGYPT = 20;
        /// <summary>El Salvador</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_EL_SALVADOR = 503;
        /// <summary>Estonia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ESTONIA = 372;
        /// <summary>Faeroe Islands</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_FAEROE_ISLANDS = 298;
        /// <summary>Finland</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_FINLAND = 358;
        /// <summary>France</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_FRANCE = 33;
        /// <summary>Georgia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_GEORGIA = 995;
        /// <summary>Germany</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_GERMANY = 49;
        /// <summary>Greece</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_GREECE = 30;
        /// <summary>Guatemala</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_GUATEMALA = 502;
        /// <summary>Honduras</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_HONDURAS = 504;
        /// <summary>Hong Kong S.A.R., P.R.C.</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_HONG_KONG = 852;
        /// <summary>Hungary</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_HUNGARY = 36;
        /// <summary>Iceland</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ICELAND = 354;
        /// <summary>India</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_INDIA = 91;
        /// <summary>Indonesia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_INDONESIA = 62;
        /// <summary>Iran</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_IRAN = 981;
        /// <summary>Iraq</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_IRAQ = 964;
        /// <summary>Ireland</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_IRELAND = 353;
        /// <summary>Israel</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ISRAEL = 972;
        /// <summary>Italy</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ITALY = 39;
        /// <summary>Jamaica</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_JAMAICA = 1;
        /// <summary>Japan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_JAPAN = 81;
        /// <summary>Jordan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_JORDAN = 962;
        /// <summary>Kazakstan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_KAZAKSTAN = 7;
        /// <summary>Kenya</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_KENYA = 254;
        /// <summary>Kuwait</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_KUWAIT = 965;
        /// <summary>Kyrgyzstan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_KYRGYZSTAN = 996;
        /// <summary>Latvia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LATVIA = 371;
        /// <summary>Lebanon</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LEBANON = 961;
        /// <summary>Libya</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LIBYA = 218;
        /// <summary>Liechtenstein</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LIECHTENSTEIN = 41;
        /// <summary>Lithuania</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LITHUANIA = 370;
        /// <summary>Luxembourg</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_LUXEMBOURG = 352;
        /// <summary>Macao SAR, PRC</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MACAU = 853;
        /// <summary>Former Yugoslav Republic of Macedonia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MACEDONIA = 389;
        /// <summary>Malaysia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MALAYSIA = 60;
        /// <summary>Maldives</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MALDIVES = 960;
        /// <summary>Mexico</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MEXICO = 52;
        /// <summary>Principality of Monaco</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MONACO = 33;
        /// <summary>Mongolia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MONGOLIA = 976;
        /// <summary>Morocco</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_MOROCCO = 212;
        /// <summary>Netherlands</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_NETHERLANDS = 31;
        /// <summary>New Zealand</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_NEW_ZEALAND = 64;
        /// <summary>Nicaragua</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_NICARAGUA = 505;
        /// <summary>Norway</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_NORWAY = 47;
        /// <summary>Oman</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_OMAN = 968;
        /// <summary>Islamic Republic of Pakistan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PAKISTAN = 92;
        /// <summary>Panama</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PANAMA = 507;
        /// <summary>Paraguay</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PARAGUAY = 595;
        /// <summary>Peru</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PERU = 51;
        /// <summary>Republic of the Philippines</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PHILIPPINES = 63;
        /// <summary>Poland</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_POLAND = 48;
        /// <summary>Portugal</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PORTUGAL = 351;
        /// <summary>People's Republic of China</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PRCHINA = 86;
        /// <summary>Puerto Rico</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_PUERTO_RICO = 1;
        /// <summary>Qatar</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_QATAR = 974;
        /// <summary>Romania</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ROMANIA = 40;
        /// <summary>Russia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_RUSSIA = 7;
        /// <summary>Saudi Arabia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SAUDI_ARABIA = 966;
        /// <summary>Serbia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SERBIA = 381;
        /// <summary>Singapore</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SINGAPORE = 65;
        /// <summary>Slovak Republic</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SLOVAK = 421;
        /// <summary>Slovenia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SLOVENIA = 386;
        /// <summary>South Africa</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SOUTH_AFRICA = 27;
        /// <summary>Korea</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SOUTH_KOREA = 82;
        /// <summary>Spain</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SPAIN = 34;
        /// <summary>Sweden</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SWEDEN = 46;
        /// <summary>Switzerland</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SWITZERLAND = 41;
        /// <summary>Syria</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_SYRIA = 963;
        /// <summary>Taiwan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_TAIWAN = 886;
        /// <summary>Tatarstan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_TATARSTAN = 7;
        /// <summary>Thailand</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_THAILAND = 66;
        /// <summary>Trinidad y Tobago</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_TRINIDAD_Y_TOBAGO = 1;
        /// <summary>Tunisia</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_TUNISIA = 216;
        /// <summary>Turkey</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_TURKEY = 90;
        /// <summary>U.A.E.</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_UAE = 971;
        /// <summary>Ukraine</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_UKRAINE = 380;
        /// <summary>United Kingdom</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_UNITED_KINGDOM = 44;
        /// <summary>United States</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_UNITED_STATES = 1;
        /// <summary>Uruguay</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_URUGUAY = 598;
        /// <summary>Uzbekistan</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_UZBEKISTAN = 7;
        /// <summary>Venezuela</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_VENEZUELA = 58;
        /// <summary>Viet Nam</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_VIET_NAM = 84;
        /// <summary>Yemen</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_YEMEN = 967;
        /// <summary>Zimbabwe</summary>
        [Obsolete(GEOID_DEPRECATION_MESSAGE)]
        public const int CTRY_ZIMBABWE = 263;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 528
        //
        //  Locale Types.
        //
        //  These types are used for the GetLocaleInfo NLS API routine.
        //  Some of these types are also used for the SetLocaleInfo NLS API routine.
        //

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 535
        //
        //  The following LCTypes may be used in combination with any other LCTypes.
        //
        //    LOCALE_NOUSEROVERRIDE is also used in GetTimeFormat and
        //    GetDateFormat.
        //
        //    LOCALE_RETURN_NUMBER will return the result from GetLocaleInfo as a
        //    number instead of a string.  This flag is only valid for the LCTypes
        //    beginning with LOCALE_I.
        //
        //    DEPRECATED: LOCALE_USE_CP_ACP is used in many of the A (Ansi) apis that need
        //                to do string translation.  Callers are encouraged to use the W
        //                (WCHAR/Unicode) apis instead.
        //
        /// <summary>Not Recommended - do not use user overrides</summary>
        public const int LOCALE_NOUSEROVERRIDE = unchecked((int)0x80000000);
        [Obsolete("DEPRECATED, call Unicode APIs instead: use the system ACP")]
        public const int LOCALE_USE_CP_ACP = 0x40000000;

        /// <summary>return number instead of string</summary>
        public const int LOCALE_RETURN_NUMBER = 0x20000000;

        /// <summary>Flag to return the Genitive forms of month names</summary>
        public const int LOCALE_RETURN_GENITIVE_NAMES = 0x10000000;
        /// <summary>Flag to allow returning neutral names/lcids for name conversion</summary>
        public const int LOCALE_ALLOW_NEUTRAL_NAMES = 0x08000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 562
        //
        //  The following LCTypes are mutually exclusive in that they may NOT
        //  be used in combination with each other.
        //

        //
        // These are the various forms of the name of the locale:
        //
        /// <summary>localized name of locale, eg "German (Germany)" in UI language</summary>
        public const int LOCALE_SLOCALIZEDDISPLAYNAME = 0x00000002;
        /// <summary>Display name (language + country/region usually) in English, eg "German (Germany)"</summary>
        public const int LOCALE_SENGLISHDISPLAYNAME = 0x00000072;
        /// <summary>Display name in native locale language, eg "Deutsch (Deutschland)</summary>
        public const int LOCALE_SNATIVEDISPLAYNAME = 0x00000073;

        /// <summary>Language Display Name for a language, eg "German" in UI language</summary>
        public const int LOCALE_SLOCALIZEDLANGUAGENAME = 0x0000006f;
        /// <summary>English name of language, eg "German"</summary>
        public const int LOCALE_SENGLISHLANGUAGENAME = 0x00001001;
        /// <summary>native name of language, eg "Deutsch"</summary>
        public const int LOCALE_SNATIVELANGUAGENAME = 0x00000004;

        /// <summary>localized name of country/region, eg "Germany" in UI language</summary>
        public const int LOCALE_SLOCALIZEDCOUNTRYNAME = 0x00000006;
        /// <summary>English name of country/region, eg "Germany"</summary>
        public const int LOCALE_SENGLISHCOUNTRYNAME = 0x00001002;
        /// <summary>native name of country/region, eg "Deutschland"</summary>
        public const int LOCALE_SNATIVECOUNTRYNAME = 0x00000008;

        // Additional LCTypes
        /// <summary>country/region dialing code, example: en-US and en-CA return 1.</summary>
        public const int LOCALE_IDIALINGCODE = 0x00000005;

        /// <summary>list item separator, eg "," for "1,2,3,4"</summary>
        public const int LOCALE_SLIST = 0x0000000C;
        /// <summary>0 = metric, 1 = US measurement system</summary>
        public const int LOCALE_IMEASURE = 0x0000000D;

        /// <summary>decimal separator, eg "." for 1,234.00</summary>
        public const int LOCALE_SDECIMAL = 0x0000000E;
        /// <summary>thousand separator, eg "," for 1,234.00</summary>
        public const int LOCALE_STHOUSAND = 0x0000000F;
        /// <summary>digit grouping, eg "3;0" for 1,000,000</summary>
        public const int LOCALE_SGROUPING = 0x00000010;
        /// <summary>number of fractional digits eg 2 for 1.00</summary>
        public const int LOCALE_IDIGITS = 0x00000011;
        /// <summary>leading zeros for decimal, 0 for .97, 1 for 0.97</summary>
        public const int LOCALE_ILZERO = 0x00000012;
        /// <summary>negative number mode, 0-4, see documentation</summary>
        public const int LOCALE_INEGNUMBER = 0x00001010;
        /// <summary>native digits for 0-9, eg "0123456789"</summary>
        public const int LOCALE_SNATIVEDIGITS = 0x00000013;

        /// <summary>local monetary symbol, eg "$"</summary>
        public const int LOCALE_SCURRENCY = 0x00000014;
        /// <summary>intl monetary symbol, eg "USD"</summary>
        public const int LOCALE_SINTLSYMBOL = 0x00000015;
        /// <summary>monetary decimal separator, eg "." for $1,234.00</summary>
        public const int LOCALE_SMONDECIMALSEP = 0x00000016;
        /// <summary>monetary thousand separator, eg "," for $1,234.00</summary>
        public const int LOCALE_SMONTHOUSANDSEP = 0x00000017;
        /// <summary>monetary grouping, eg "3;0" for $1,000,000.00</summary>
        public const int LOCALE_SMONGROUPING = 0x00000018;
        /// <summary># local monetary digits, eg 2 for $1.00</summary>
        public const int LOCALE_ICURRDIGITS = 0x00000019;
        /// <summary>positive currency mode, 0-3, see documentation</summary>
        public const int LOCALE_ICURRENCY = 0x0000001B;
        /// <summary>negative currency mode, 0-15, see documentation</summary>
        public const int LOCALE_INEGCURR = 0x0000001C;

        /// <summary>short date format string, eg "MM/dd/yyyy"</summary>
        public const int LOCALE_SSHORTDATE = 0x0000001F;
        /// <summary>long date format string, eg "dddd, MMMM dd, yyyy"</summary>
        public const int LOCALE_SLONGDATE = 0x00000020;
        /// <summary>time format string, eg "HH:mm:ss"</summary>
        public const int LOCALE_STIMEFORMAT = 0x00001003;
        /// <summary>AM designator, eg "AM"</summary>
        public const int LOCALE_SAM = 0x00000028;
        /// <summary>PM designator, eg "PM"</summary>
        public const int LOCALE_SPM = 0x00000029;

        /// <summary>type of calendar specifier, eg CAL_GREGORIAN</summary>
        public const int LOCALE_ICALENDARTYPE = 0x00001009;
        /// <summary>additional calendar types specifier, eg CAL_GREGORIAN_US</summary>
        public const int LOCALE_IOPTIONALCALENDAR = 0x0000100B;
        /// <summary>first day of week specifier, 0-6, 0=Monday, 6=Sunday</summary>
        public const int LOCALE_IFIRSTDAYOFWEEK = 0x0000100C;
        /// <summary>first week of year specifier, 0-2, see documentation</summary>
        public const int LOCALE_IFIRSTWEEKOFYEAR = 0x0000100D;

        /// <summary>long name for Monday</summary>
        public const int LOCALE_SDAYNAME1 = 0x0000002A;
        /// <summary>long name for Tuesday</summary>
        public const int LOCALE_SDAYNAME2 = 0x0000002B;
        /// <summary>long name for Wednesday</summary>
        public const int LOCALE_SDAYNAME3 = 0x0000002C;
        /// <summary>long name for Thursday</summary>
        public const int LOCALE_SDAYNAME4 = 0x0000002D;
        /// <summary>long name for Friday</summary>
        public const int LOCALE_SDAYNAME5 = 0x0000002E;
        /// <summary>long name for Saturday</summary>
        public const int LOCALE_SDAYNAME6 = 0x0000002F;
        /// <summary>long name for Sunday</summary>
        public const int LOCALE_SDAYNAME7 = 0x00000030;
        /// <summary>abbreviated name for Monday</summary>
        public const int LOCALE_SABBREVDAYNAME1 = 0x00000031;
        /// <summary>abbreviated name for Tuesday</summary>
        public const int LOCALE_SABBREVDAYNAME2 = 0x00000032;
        /// <summary>abbreviated name for Wednesday</summary>
        public const int LOCALE_SABBREVDAYNAME3 = 0x00000033;
        /// <summary>abbreviated name for Thursday</summary>
        public const int LOCALE_SABBREVDAYNAME4 = 0x00000034;
        /// <summary>abbreviated name for Friday</summary>
        public const int LOCALE_SABBREVDAYNAME5 = 0x00000035;
        /// <summary>abbreviated name for Saturday</summary>
        public const int LOCALE_SABBREVDAYNAME6 = 0x00000036;
        /// <summary>abbreviated name for Sunday</summary>
        public const int LOCALE_SABBREVDAYNAME7 = 0x00000037;
        /// <summary>long name for January</summary>
        public const int LOCALE_SMONTHNAME1 = 0x00000038;
        /// <summary>long name for February</summary>
        public const int LOCALE_SMONTHNAME2 = 0x00000039;
        /// <summary>long name for March</summary>
        public const int LOCALE_SMONTHNAME3 = 0x0000003A;
        /// <summary>long name for April</summary>
        public const int LOCALE_SMONTHNAME4 = 0x0000003B;
        /// <summary>long name for May</summary>
        public const int LOCALE_SMONTHNAME5 = 0x0000003C;
        /// <summary>long name for June</summary>
        public const int LOCALE_SMONTHNAME6 = 0x0000003D;
        /// <summary>long name for July</summary>
        public const int LOCALE_SMONTHNAME7 = 0x0000003E;
        /// <summary>long name for August</summary>
        public const int LOCALE_SMONTHNAME8 = 0x0000003F;
        /// <summary>long name for September</summary>
        public const int LOCALE_SMONTHNAME9 = 0x00000040;
        /// <summary>long name for October</summary>
        public const int LOCALE_SMONTHNAME10 = 0x00000041;
        /// <summary>long name for November</summary>
        public const int LOCALE_SMONTHNAME11 = 0x00000042;
        /// <summary>long name for December</summary>
        public const int LOCALE_SMONTHNAME12 = 0x00000043;
        /// <summary>long name for 13th month (if exists)</summary>
        public const int LOCALE_SMONTHNAME13 = 0x0000100E;
        /// <summary>abbreviated name for January</summary>
        public const int LOCALE_SABBREVMONTHNAME1 = 0x00000044;
        /// <summary>abbreviated name for February</summary>
        public const int LOCALE_SABBREVMONTHNAME2 = 0x00000045;
        /// <summary>abbreviated name for March</summary>
        public const int LOCALE_SABBREVMONTHNAME3 = 0x00000046;
        /// <summary>abbreviated name for April</summary>
        public const int LOCALE_SABBREVMONTHNAME4 = 0x00000047;
        /// <summary>abbreviated name for May</summary>
        public const int LOCALE_SABBREVMONTHNAME5 = 0x00000048;
        /// <summary>abbreviated name for June</summary>
        public const int LOCALE_SABBREVMONTHNAME6 = 0x00000049;
        /// <summary>abbreviated name for July</summary>
        public const int LOCALE_SABBREVMONTHNAME7 = 0x0000004A;
        /// <summary>abbreviated name for August</summary>
        public const int LOCALE_SABBREVMONTHNAME8 = 0x0000004B;
        /// <summary>abbreviated name for September</summary>
        public const int LOCALE_SABBREVMONTHNAME9 = 0x0000004C;
        /// <summary>abbreviated name for October</summary>
        public const int LOCALE_SABBREVMONTHNAME10 = 0x0000004D;
        /// <summary>abbreviated name for November</summary>
        public const int LOCALE_SABBREVMONTHNAME11 = 0x0000004E;
        /// <summary>abbreviated name for December</summary>
        public const int LOCALE_SABBREVMONTHNAME12 = 0x0000004F;
        /// <summary>abbreviated name for 13th month (if exists)</summary>
        public const int LOCALE_SABBREVMONTHNAME13 = 0x0000100F;

        /// <summary>positive sign, eg ""</summary>
        public const int LOCALE_SPOSITIVESIGN = 0x00000050;
        /// <summary>negative sign, eg "-"</summary>
        public const int LOCALE_SNEGATIVESIGN = 0x00000051;
        /// <summary>positive sign position (derived from INEGCURR)</summary>
        public const int LOCALE_IPOSSIGNPOSN = 0x00000052;
        /// <summary>negative sign position (derived from INEGCURR)</summary>
        public const int LOCALE_INEGSIGNPOSN = 0x00000053;
        /// <summary>mon sym precedes pos amt (derived from ICURRENCY)</summary>
        public const int LOCALE_IPOSSYMPRECEDES = 0x00000054;
        /// <summary>mon sym sep by space from pos amt (derived from ICURRENCY)</summary>
        public const int LOCALE_IPOSSEPBYSPACE = 0x00000055;
        /// <summary>mon sym precedes neg amt (derived from INEGCURR)</summary>
        public const int LOCALE_INEGSYMPRECEDES = 0x00000056;
        /// <summary>mon sym sep by space from neg amt (derived from INEGCURR)</summary>
        public const int LOCALE_INEGSEPBYSPACE = 0x00000057;

        /// <summary>font signature</summary>
        public const int LOCALE_FONTSIGNATURE = 0x00000058;
        /// <summary>ISO abbreviated language name, eg "en"</summary>
        public const int LOCALE_SISO639LANGNAME = 0x00000059;
        /// <summary>ISO abbreviated country/region name, eg "US"</summary>
        public const int LOCALE_SISO3166CTRYNAME = 0x0000005A;


        /// <summary>1 = letter, 5 = legal, 8 = a3, 9 = a4</summary>
        public const int LOCALE_IPAPERSIZE = 0x0000100A;
        /// <summary>english name of currency, eg "Euro"</summary>
        public const int LOCALE_SENGCURRNAME = 0x00001007;
        /// <summary>native name of currency, eg "euro"</summary>
        public const int LOCALE_SNATIVECURRNAME = 0x00001008;
        /// <summary>year month format string, eg "MM/yyyy"</summary>
        public const int LOCALE_SYEARMONTH = 0x00001006;
        /// <summary>sort name, usually "", eg "Dictionary" in UI Language</summary>
        public const int LOCALE_SSORTNAME = 0x00001013;
        /// <summary>0 = context, 1 = none, 2 = national</summary>
        public const int LOCALE_IDIGITSUBSTITUTION = 0x00001014;

        /// <summary>locale name (ie: en-us)</summary>
        public const int LOCALE_SNAME = 0x0000005c;
        /// <summary>time duration format, eg "hh:mm:ss"</summary>
        public const int LOCALE_SDURATION = 0x0000005d;
        /// <summary>Shortest day name for Monday</summary>
        public const int LOCALE_SSHORTESTDAYNAME1 = 0x00000060;
        /// <summary>Shortest day name for Tuesday</summary>
        public const int LOCALE_SSHORTESTDAYNAME2 = 0x00000061;
        /// <summary>Shortest day name for Wednesday</summary>
        public const int LOCALE_SSHORTESTDAYNAME3 = 0x00000062;
        /// <summary>Shortest day name for Thursday</summary>
        public const int LOCALE_SSHORTESTDAYNAME4 = 0x00000063;
        /// <summary>Shortest day name for Friday</summary>
        public const int LOCALE_SSHORTESTDAYNAME5 = 0x00000064;
        /// <summary>Shortest day name for Saturday</summary>
        public const int LOCALE_SSHORTESTDAYNAME6 = 0x00000065;
        /// <summary>Shortest day name for Sunday</summary>
        public const int LOCALE_SSHORTESTDAYNAME7 = 0x00000066;
        /// <summary>3 character ISO abbreviated language name, eg "eng"</summary>
        public const int LOCALE_SISO639LANGNAME2 = 0x00000067;
        /// <summary>3 character ISO country/region name, eg "USA"</summary>
        public const int LOCALE_SISO3166CTRYNAME2 = 0x00000068;
        /// <summary>Not a Number, eg "NaN"</summary>
        public const int LOCALE_SNAN = 0x00000069;
        /// <summary>+ Infinity, eg "infinity"</summary>
        public const int LOCALE_SPOSINFINITY = 0x0000006a;
        /// <summary>- Infinity, eg "-infinity"</summary>
        public const int LOCALE_SNEGINFINITY = 0x0000006b;
        /// <summary>Typical scripts in the locale: ; delimited script codes, eg "Latn;"</summary>
        public const int LOCALE_SSCRIPTS = 0x0000006c;
        /// <summary>Fallback name for resources, eg "en" for "en-US"</summary>
        public const int LOCALE_SPARENT = 0x0000006d;
        /// <summary>Fallback name for within the console for Unicode Only locales, eg "en" for bn-IN</summary>
        public const int LOCALE_SCONSOLEFALLBACKNAME = 0x0000006e;

        /// <summary>
        /// Returns one of the following 4 reading layout values:
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>0</c> (zero)</term><description>Left to right (eg en-US)</description></item>
        /// <item><term><c>1</c></term><description>Right to left (eg arabic locales)</description></item>
        /// <item><term><c>2</c></term><description>Vertical top to bottom with columns to the left and also left to right (ja-JP locales)</description></item>
        /// <item><term><c>3</c></term><description>Vertical top to bottom with columns proceeding to the right</description></item>
        /// </list>
        /// </summary>
        public const int LOCALE_IREADINGLAYOUT = 0x00000070;
        /// <summary>Returns 0 for specific cultures, 1 for neutral cultures.</summary>
        public const int LOCALE_INEUTRAL = 0x00000071;
        /// <summary>Returns 0-11 for the negative percent format</summary>
        public const int LOCALE_INEGATIVEPERCENT = 0x00000074;
        /// <summary>Returns 0-3 for the positive percent formatIPOSITIVEPERCENT</summary>
        public const int LOCALE_IPOSITIVEPERCENT = 0x00000075;
        /// <summary>Returns the percent symbol</summary>
        public const int LOCALE_SPERCENT = 0x00000076;
        /// <summary>Returns the permille (U+2030) symbol</summary>
        public const int LOCALE_SPERMILLE = 0x00000077;
        /// <summary>Returns the preferred month/day format</summary>
        public const int LOCALE_SMONTHDAY = 0x00000078;
        /// <summary>Returns the preferred short time format (ie: no seconds, just h:mm)</summary>
        public const int LOCALE_SSHORTTIME = 0x00000079;
        /// <summary>Open type language tag, eg: "latn" or "dflt"</summary>
        public const int LOCALE_SOPENTYPELANGUAGETAG = 0x0000007a;
        /// <summary>Name of locale to use for sorting/collation/casing behavior.</summary>
        public const int LOCALE_SSORTLOCALE = 0x0000007b;

        /// <summary>Long date without year, day of week, month, date, eg: for lock screen</summary>
        public const int LOCALE_SRELATIVELONGDATE = 0x0000007c;

        /// <summary>Shortest AM designator, eg "A"</summary>
        public const int LOCALE_SSHORTESTAM = 0x0000007e;
        /// <summary>Shortest PM designator, eg "P"</summary>
        public const int LOCALE_SSHORTESTPM = 0x0000007f;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 732
        //
        // DEPRECATED LCTYPEs
        //

        // DEPRECATED LCTYPEs for Code Pages
        // Applications are strongly encouraged to Use Unicode, such as UTF-16 (WCHAR type)
        // or the CP_UTF8 Code Page.  Legacy encodings are unable to represent the full
        // set of scripts/language and characters (& emoji!) available on modern computers.
        // Use of legacy code pages (encodings) is a leading cause of data loss and corruption.
        /// <summary>default oem code page for locale (user may configure as UTF-8, use of Unicode is recommended instead)</summary>
        public const int LOCALE_IDEFAULTCODEPAGE = 0x0000000B;
        /// <summary>default ansi code page for locale (user may configure as UTF-8, use of Unicode is recommended instead)</summary>
        public const int LOCALE_IDEFAULTANSICODEPAGE = 0x00001004;
        /// <summary>default mac code page for locale (user may configure as UTF-8, use of Unicode is recommended instead)</summary>
        public const int LOCALE_IDEFAULTMACCODEPAGE = 0x00001011;
        /// <summary>default ebcdic code page for a locale (use of Unicode is recommended instead)</summary>
        public const int LOCALE_IDEFAULTEBCDICCODEPAGE = 0x00001012;

        // LCTYPEs using out-of-date concepts
        [Obsolete("DEPRECATED language id (LCID), LOCALE_SNAME preferred")]
        public const int LOCALE_ILANGUAGE = 0x00000001;
        [Obsolete("DEPRECATED arbitrary abbreviated language name, LOCALE_SISO639LANGNAME instead.")]
        public const int LOCALE_SABBREVLANGNAME = 0x00000003;
        [Obsolete("DEPRECATED arbitrary abbreviated country/region name, LOCALE_SISO3166CTRYNAME instead.")]
        public const int LOCALE_SABBREVCTRYNAME = 0x00000007;
        [Obsolete("DEPRECATED geographical location id, use LOCALE_SISO3166CTRYNAME instead.")]
        public const int LOCALE_IGEOID = 0x0000005B;
        [Obsolete("DEPRECATED default language id, deprecated.")]
        public const int LOCALE_IDEFAULTLANGUAGE = 0x00000009;
        [Obsolete("DEPRECATED default country/region code, deprecated.")]
        public const int LOCALE_IDEFAULTCOUNTRY = 0x0000000A;
        [Obsolete("DEPRECATED, use LOCALE_ICURRDIGITS # intl monetary digits, eg 2 for $1.00.")]
        public const int LOCALE_IINTLCURRDIGITS = 0x0000001A;

        // Derived legacy date & time values for compatibility only.
        // Please use the appropriate date or time pattern instead.
        // These can be misleading, for example a locale configured as 12h24m52s could have a time separator of "h".
        [Obsolete("DEPRECATED date separator (derived from LOCALE_SSHORTDATE, use that instead)")]
        public const int LOCALE_SDATE = 0x0000001D;
        [Obsolete("DEPRECATED time separator (derived from LOCALE_STIMEFORMAT, use that instead)")]
        public const int LOCALE_STIME = 0x0000001E;
        [Obsolete("DEPRECATED short date format ordering (derived from LOCALE_SSHORTDATE, use that instead)")]
        public const int LOCALE_IDATE = 0x00000021;
        [Obsolete("DEPRECATED long date format ordering (derived from LOCALE_SLONGDATE, use that instead)")]
        public const int LOCALE_ILDATE = 0x00000022;
        [Obsolete("DEPRECATED time format specifier (derived from LOCALE_STIMEFORMAT, use that instead)")]
        public const int LOCALE_ITIME = 0x00000023;
        [Obsolete("DEPRECATED time marker position (derived from LOCALE_STIMEFORMAT, use that instead)")]
        public const int LOCALE_ITIMEMARKPOSN = 0x00001005;
        [Obsolete("DEPRECATED century format specifier (short date, LOCALE_SSHORTDATE is preferred)")]
        public const int LOCALE_ICENTURY = 0x00000024;
        [Obsolete("DEPRECATED leading zeros in time field (derived from LOCALE_STIMEFORMAT, use that instead)")]
        public const int LOCALE_ITLZERO = 0x00000025;
        [Obsolete("DEPRECATED leading zeros in day field (short date, LOCALE_SSHORTDATE is preferred)")]
        public const int LOCALE_IDAYLZERO = 0x00000026;
        [Obsolete("DEPRECATED leading zeros in month field (short date, LOCALE_SSHORTDATE is preferred)")]
        public const int LOCALE_IMONLZERO = 0x00000027;

        /// <summary>Used internally, see GetKeyboardLayoutName() function</summary>
        public const int LOCALE_SKEYBOARDSTOINSTALL = 0x0000005e;

        // LCTYPEs which have been renamed to enable more understandable source code.
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SLANGUAGE = LOCALE_SLOCALIZEDDISPLAYNAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SLANGDISPLAYNAME = LOCALE_SLOCALIZEDLANGUAGENAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SENGLANGUAGE = LOCALE_SENGLISHLANGUAGENAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SNATIVELANGNAME = LOCALE_SNATIVELANGUAGENAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SCOUNTRY = LOCALE_SLOCALIZEDCOUNTRYNAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SENGCOUNTRY = LOCALE_SENGLISHCOUNTRYNAME;
        [Obsolete("DEPRECATED as new name is more readable.")]
        public const int LOCALE_SNATIVECTRYNAME = LOCALE_SNATIVECOUNTRYNAME;
        /// <summary>Deprecated synonym for LOCALE_IDIALINGCODE</summary>
        [Obsolete("DEPRECATED: Use LOCALE_SISO3166CTRYNAME to query for a region identifier, LOCALE_ICOUNTRY is not a region identifier.")]
        public const int LOCALE_ICOUNTRY = LOCALE_IDIALINGCODE;
        [Obsolete("DEPRECATED: Please use LOCALE_SAM, which is more readable.")]
        public const int LOCALE_S1159 = LOCALE_SAM;
        [Obsolete("DEPRECATED: Please use LOCALE_SPM, which is more readable.")]
        public const int LOCALE_S2359 = LOCALE_SPM;


        //
        //  Time Flags for GetTimeFormat.
        //
        /// <summary>do not use minutes or seconds</summary>
        public const int TIME_NOMINUTESORSECONDS = 0x00000001;
        /// <summary>do not use seconds</summary>
        public const int TIME_NOSECONDS = 0x00000002;
        /// <summary>do not use time marker</summary>
        public const int TIME_NOTIMEMARKER = 0x00000004;
        /// <summary>always use 24 hour format</summary>
        public const int TIME_FORCE24HOURFORMAT = 0x00000008;


        //
        //  Date Flags for GetDateFormat.
        //
        /// <summary>use short date picture</summary>
        public const int DATE_SHORTDATE = 0x00000001;
        /// <summary>use long date picture</summary>
        public const int DATE_LONGDATE = 0x00000002;
        /// <summary>use alternate calendar (if any)</summary>
        public const int DATE_USE_ALT_CALENDAR = 0x00000004;

        /// <summary>use year month picture</summary>
        public const int DATE_YEARMONTH = 0x00000008;
        /// <summary>add marks for left to right reading order layout</summary>
        public const int DATE_LTRREADING = 0x00000010;
        /// <summary>add marks for right to left reading order layout</summary>
        public const int DATE_RTLREADING = 0x00000020;

        /// <summary>add appropriate marks for left-to-right or right-to-left reading order layout</summary>
        public const int DATE_AUTOLAYOUT = 0x00000040;

        /// <summary>include month day pictures</summary>
        public const int DATE_MONTHDAY = 0x00000080;

        //
        //  Calendar Types.
        //
        //  These types are used for the EnumCalendarInfo and GetCalendarInfo
        //  NLS API routines.
        //  Some of these types are also used for the SetCalendarInfo NLS API
        //  routine.
        //

        //
        //  The following CalTypes may be used in combination with any other CalTypes.
        //
        //    CAL_NOUSEROVERRIDE
        //
        //    CAL_RETURN_NUMBER will return the result from GetCalendarInfo as a
        //    number instead of a string.  This flag is only valid for the CalTypes
        //    beginning with CAL_I.
        //
        //    DEPRECATED: CAL_USE_CP_ACP is used in many of the A (Ansi) apis that need
        //                to do string translation.  Callers are encouraged to use the W
        //                (WCHAR/Unicode) apis instead.
        //
        /// <summary>Not Recommended - do not use user overrides</summary>
        public const int CAL_NOUSEROVERRIDE = LOCALE_NOUSEROVERRIDE;
        [Obsolete("DEPRECATED, call Unicode APIs instead: use the system ACP.")]
        public const int CAL_USE_CP_ACP = LOCALE_USE_CP_ACP;
        /// <summary>return number instead of string</summary>
        public const int CAL_RETURN_NUMBER = LOCALE_RETURN_NUMBER;

        /// <summary>return genitive forms of month names</summary>
        public const int CAL_RETURN_GENITIVE_NAMES = LOCALE_RETURN_GENITIVE_NAMES;

        //
        //  The following CalTypes are mutually exclusive in that they may NOT
        //  be used in combination with each other.
        //
        /// <summary>calendar type</summary>
        public const int CAL_ICALINTVALUE = 0x00000001;
        /// <summary>native name of calendar</summary>
        public const int CAL_SCALNAME = 0x00000002;
        /// <summary>starting years of eras</summary>
        public const int CAL_IYEAROFFSETRANGE = 0x00000003;
        /// <summary>era name for IYearOffsetRanges, eg A.D.</summary>
        public const int CAL_SERASTRING = 0x00000004;
        /// <summary>short date format string</summary>
        public const int CAL_SSHORTDATE = 0x00000005;
        /// <summary>long date format string</summary>
        public const int CAL_SLONGDATE = 0x00000006;
        /// <summary>native name for Monday</summary>
        public const int CAL_SDAYNAME1 = 0x00000007;
        /// <summary>native name for Tuesday</summary>
        public const int CAL_SDAYNAME2 = 0x00000008;
        /// <summary>native name for Wednesday</summary>
        public const int CAL_SDAYNAME3 = 0x00000009;
        /// <summary>native name for Thursday</summary>
        public const int CAL_SDAYNAME4 = 0x0000000a;
        /// <summary>native name for Friday</summary>
        public const int CAL_SDAYNAME5 = 0x0000000b;
        /// <summary>native name for Saturday</summary>
        public const int CAL_SDAYNAME6 = 0x0000000c;
        /// <summary>native name for Sunday</summary>
        public const int CAL_SDAYNAME7 = 0x0000000d;
        /// <summary>abbreviated name for Mon</summary>
        public const int CAL_SABBREVDAYNAME1 = 0x0000000e;
        /// <summary>abbreviated name for Tue</summary>
        public const int CAL_SABBREVDAYNAME2 = 0x0000000f;
        /// <summary>abbreviated name for Wed</summary>
        public const int CAL_SABBREVDAYNAME3 = 0x00000010;
        /// <summary>abbreviated name for Thu</summary>
        public const int CAL_SABBREVDAYNAME4 = 0x00000011;
        /// <summary>abbreviated name for Fri</summary>
        public const int CAL_SABBREVDAYNAME5 = 0x00000012;
        /// <summary>abbreviated name for Sat</summary>
        public const int CAL_SABBREVDAYNAME6 = 0x00000013;
        /// <summary>abbreviated name for Sun</summary>
        public const int CAL_SABBREVDAYNAME7 = 0x00000014;
        // Note that in the hebrew calendar the leap month name is always returned as the 7th month
        /// <summary>native name for January</summary>
        public const int CAL_SMONTHNAME1 = 0x00000015;
        /// <summary>native name for February</summary>
        public const int CAL_SMONTHNAME2 = 0x00000016;
        /// <summary>native name for March</summary>
        public const int CAL_SMONTHNAME3 = 0x00000017;
        /// <summary>native name for April</summary>
        public const int CAL_SMONTHNAME4 = 0x00000018;
        /// <summary>native name for May</summary>
        public const int CAL_SMONTHNAME5 = 0x00000019;
        /// <summary>native name for June</summary>
        public const int CAL_SMONTHNAME6 = 0x0000001a;
        /// <summary>native name for July</summary>
        public const int CAL_SMONTHNAME7 = 0x0000001b;
        /// <summary>native name for August</summary>
        public const int CAL_SMONTHNAME8 = 0x0000001c;
        /// <summary>native name for September</summary>
        public const int CAL_SMONTHNAME9 = 0x0000001d;
        /// <summary>native name for October</summary>
        public const int CAL_SMONTHNAME10 = 0x0000001e;
        /// <summary>native name for November</summary>
        public const int CAL_SMONTHNAME11 = 0x0000001f;
        /// <summary>native name for December</summary>
        public const int CAL_SMONTHNAME12 = 0x00000020;
        /// <summary>native name for 13th month (if any)</summary>
        public const int CAL_SMONTHNAME13 = 0x00000021;
        /// <summary>abbreviated name for Jan</summary>
        public const int CAL_SABBREVMONTHNAME1 = 0x00000022;
        /// <summary>abbreviated name for Feb</summary>
        public const int CAL_SABBREVMONTHNAME2 = 0x00000023;
        /// <summary>abbreviated name for Mar</summary>
        public const int CAL_SABBREVMONTHNAME3 = 0x00000024;
        /// <summary>abbreviated name for Apr</summary>
        public const int CAL_SABBREVMONTHNAME4 = 0x00000025;
        /// <summary>abbreviated name for May</summary>
        public const int CAL_SABBREVMONTHNAME5 = 0x00000026;
        /// <summary>abbreviated name for Jun</summary>
        public const int CAL_SABBREVMONTHNAME6 = 0x00000027;
        /// <summary>abbreviated name for July</summary>
        public const int CAL_SABBREVMONTHNAME7 = 0x00000028;
        /// <summary>abbreviated name for Aug</summary>
        public const int CAL_SABBREVMONTHNAME8 = 0x00000029;
        /// <summary>abbreviated name for Sep</summary>
        public const int CAL_SABBREVMONTHNAME9 = 0x0000002a;
        /// <summary>abbreviated name for Oct</summary>
        public const int CAL_SABBREVMONTHNAME10 = 0x0000002b;
        /// <summary>abbreviated name for Nov</summary>
        public const int CAL_SABBREVMONTHNAME11 = 0x0000002c;
        /// <summary>abbreviated name for Dec</summary>
        public const int CAL_SABBREVMONTHNAME12 = 0x0000002d;
        /// <summary>abbreviated name for 13th month (if any)</summary>
        public const int CAL_SABBREVMONTHNAME13 = 0x0000002e;

        /// <summary>year month format string</summary>
        public const int CAL_SYEARMONTH = 0x0000002f;
        /// <summary>two digit year max</summary>
        public const int CAL_ITWODIGITYEARMAX = 0x00000030;

        /// <summary>Shortest day name for Mo</summary>
        public const int CAL_SSHORTESTDAYNAME1 = 0x00000031;
        /// <summary>Shortest day name for Tu</summary>
        public const int CAL_SSHORTESTDAYNAME2 = 0x00000032;
        /// <summary>Shortest day name for We</summary>
        public const int CAL_SSHORTESTDAYNAME3 = 0x00000033;
        /// <summary>Shortest day name for Th</summary>
        public const int CAL_SSHORTESTDAYNAME4 = 0x00000034;
        /// <summary>Shortest day name for Fr</summary>
        public const int CAL_SSHORTESTDAYNAME5 = 0x00000035;
        /// <summary>Shortest day name for Sa</summary>
        public const int CAL_SSHORTESTDAYNAME6 = 0x00000036;
        /// <summary>Shortest day name for Su</summary>
        public const int CAL_SSHORTESTDAYNAME7 = 0x00000037;

        /// <summary>Month/day format</summary>
        public const int CAL_SMONTHDAY = 0x00000038;
        /// <summary>Abbreviated era string (eg: AD)</summary>
        public const int CAL_SABBREVERASTRING = 0x00000039;

        /// <summary>Long date without year, day of week, month, date, eg: for lock screen</summary>
        public const int CAL_SRELATIVELONGDATE = 0x0000003a;

        /// <summary>Japanese calendar only: return the English era names for .Net compatibility</summary>
        public const int CAL_SENGLISHERANAME = 0x0000003b;
        /// <summary>Japanese calendar only: return the English Abbreviated era names for .Net compatibility</summary>
        public const int CAL_SENGLISHABBREVERANAME = 0x0000003c;

        //
        //  Calendar Enumeration Value.
        //
        /// <summary>enumerate all calendars</summary>
        public const int ENUM_ALL_CALENDARS = unchecked((int)0xffffffff);

        //
        //  Calendar ID Values.
        //
        /// <summary>Gregorian (localized) calendar</summary>
        public const int CAL_GREGORIAN = 1;
        /// <summary>Gregorian (U.S.) calendar</summary>
        public const int CAL_GREGORIAN_US = 2;
        /// <summary>Japanese Emperor Era calendar</summary>
        public const int CAL_JAPAN = 3;
        /// <summary>Taiwan calendar</summary>
        public const int CAL_TAIWAN = 4;
        /// <summary>Korean Tangun Era calendar</summary>
        public const int CAL_KOREA = 5;
        /// <summary>Hijri (Arabic Lunar) calendar</summary>
        public const int CAL_HIJRI = 6;
        /// <summary>Thai calendar</summary>
        public const int CAL_THAI = 7;
        /// <summary>Hebrew (Lunar) calendar</summary>
        public const int CAL_HEBREW = 8;
        /// <summary>Gregorian Middle East French calendar</summary>
        public const int CAL_GREGORIAN_ME_FRENCH = 9;
        /// <summary>Gregorian Arabic calendar</summary>
        public const int CAL_GREGORIAN_ARABIC = 10;
        /// <summary>Gregorian Transliterated English calendar</summary>
        public const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
        /// <summary>Gregorian Transliterated French calendar</summary>
        public const int CAL_GREGORIAN_XLIT_FRENCH = 12;
        /// <summary>Persian (Solar Hijri) calendar</summary>
        public const int CAL_PERSIAN = 22;
        /// <summary>UmAlQura Hijri (Arabic Lunar) calendar</summary>
        public const int CAL_UMALQURA = 23;

        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  Language Group ID Values
        //
        // The "Language Group" concept is an obsolete concept.
        // The groups returned are not well defined, arbitrary, inconsistent, inaccurate,
        // no longer maintained, and no longer supported.
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        public const string LGRPID_DEPRECATION_MESSAGE =
            "The \"Language Group\" concept is an obsolete concept." + "\r\n" +
            "The groups returned are not well defined, arbitrary, inconsistent, inaccurate, " +
            "no longer maintained, and no longer supported.";

        /// <summary>Western Europe &amp; U.S.</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_WESTERN_EUROPE = 0x0001;
        /// <summary>Central Europe</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_CENTRAL_EUROPE = 0x0002;
        /// <summary>Baltic</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_BALTIC = 0x0003;
        /// <summary>Greek</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_GREEK = 0x0004;
        /// <summary>Cyrillic</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_CYRILLIC = 0x0005;
        /// <summary>Turkic</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_TURKIC = 0x0006;
        /// <summary>Turkish</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_TURKISH = 0x0006;
        /// <summary>Japanese</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_JAPANESE = 0x0007;
        /// <summary>Korean</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_KOREAN = 0x0008;
        /// <summary>Traditional Chinese</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_TRADITIONAL_CHINESE = 0x0009;
        /// <summary>Simplified Chinese</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_SIMPLIFIED_CHINESE = 0x000a;
        /// <summary>Thai</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_THAI = 0x000b;
        /// <summary>Hebrew</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_HEBREW = 0x000c;
        /// <summary>Arabic</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_ARABIC = 0x000d;
        /// <summary>Vietnamese</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_VIETNAMESE = 0x000e;
        /// <summary>Indic</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_INDIC = 0x000f;
        /// <summary>Georgian</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_GEORGIAN = 0x0010;
        /// <summary>Armenian</summary>
        [Obsolete(LGRPID_DEPRECATION_MESSAGE)]
        public const int LGRPID_ARMENIAN = 0x0011;

        //
        //  MUI function flag values
        //
        /// <summary>Use traditional language ID convention</summary>
        public const int MUI_LANGUAGE_ID = 0x4;
        /// <summary>Use ISO language (culture) name convention</summary>
        public const int MUI_LANGUAGE_NAME = 0x8;
        /// <summary>GetThreadPreferredUILanguages merges in parent and base languages</summary>
        public const int MUI_MERGE_SYSTEM_FALLBACK = 0x10;
        /// <summary>GetThreadPreferredUILanguages merges in user preferred languages</summary>
        public const int MUI_MERGE_USER_FALLBACK = 0x20;
        public const int MUI_UI_FALLBACK = MUI_MERGE_SYSTEM_FALLBACK | MUI_MERGE_USER_FALLBACK;
        /// <summary>GetThreadPreferredUILanguages merges in user preferred languages</summary>
        public const int MUI_THREAD_LANGUAGES = 0x40;
        /// <summary>SetThreadPreferredUILanguages takes on console specific behavior</summary>
        public const int MUI_CONSOLE_FILTER = 0x100;
        /// <summary>SetThreadPreferredUILanguages takes on complex script specific behavior</summary>
        public const int MUI_COMPLEX_SCRIPT_FILTER = 0x200;
        /// <summary>Reset MUI_CONSOLE_FILTER and MUI_COMPLEX_SCRIPT_FILTER</summary>
        public const int MUI_RESET_FILTERS = 0x001;
        /// <summary>GetFileMUIPath returns the MUI files for the languages in the fallback list</summary>
        public const int MUI_USER_PREFERRED_UI_LANGUAGES = 0x10;
        /// <summary>GetFileMUIPath returns all the MUI files installed in the machine</summary>
        public const int MUI_USE_INSTALLED_LANGUAGES = 0x20;
        /// <summary>GetFileMUIPath returns all the MUI files irrespective of whether language is installed</summary>
        public const int MUI_USE_SEARCH_ALL_LANGUAGES = 0x40;
        /// <summary>GetFileMUIPath returns target file with .mui extension</summary>
        public const int MUI_LANG_NEUTRAL_PE_FILE = 0x100;
        /// <summary>GetFileMUIPath returns target file with same name as source</summary>
        public const int MUI_NON_LANG_NEUTRAL_FILE = 0x200;
        public const int MUI_MACHINE_LANGUAGE_SETTINGS = 0x400;
        /// <summary>GetFileMUIInfo found a non-split resource file</summary>
        public const int MUI_FILETYPE_NOT_LANGUAGE_NEUTRAL = 0x001;
        /// <summary>GetFileMUIInfo found a LN main module resource file</summary>
        public const int MUI_FILETYPE_LANGUAGE_NEUTRAL_MAIN = 0x002;
        /// <summary>GetFileMUIInfo found a LN MUI module resource file</summary>
        public const int MUI_FILETYPE_LANGUAGE_NEUTRAL_MUI = 0x004;
        /// <summary>GetFileMUIInfo will look for the type of the resource file</summary>
        public const int MUI_QUERY_TYPE = 0x001;
        /// <summary>GetFileMUIInfo will look for the checksum of the resource file</summary>
        public const int MUI_QUERY_CHECKSUM = 0x002;
        /// <summary>GetFileMUIInfo will look for the culture of the resource file</summary>
        public const int MUI_QUERY_LANGUAGE_NAME = 0x004;
        /// <summary>GetFileMUIInfo will look for the resource types of the resource file</summary>
        public const int MUI_QUERY_RESOURCE_TYPES = 0x008;
        /// <summary>Version of FILEMUIINFO structure used with GetFileMUIInfo</summary>
        public const int MUI_FILEINFO_VERSION = 0x001;

        public const int MUI_FULL_LANGUAGE = 0x01;
        public const int MUI_PARTIAL_LANGUAGE = 0x02;
        public const int MUI_LIP_LANGUAGE = 0x04;
        public const int MUI_LANGUAGE_INSTALLED = 0x20;
        public const int MUI_LANGUAGE_LICENSED = 0x40;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1250
        public const int GEOID_NOT_AVAILABLE = -1;
    }
}
