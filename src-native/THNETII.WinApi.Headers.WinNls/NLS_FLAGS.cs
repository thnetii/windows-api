using System;

namespace THNETII.WinApi.Native.WinNls
{
    using static WinNlsFunctions;

    /// <summary>
    /// Combines flags values from different flag enumeration types together for
    /// calls to methods defined in <see cref="WinNlsFunctions"/>.
    /// </summary>
    public static class NLS_FLAGS
    {
        /// <summary>
        /// Combines string-comparison flags for calls to <see cref="CompareString"/> and <see cref="CompareStringEx"/>
        /// </summary>
        /// <seealso cref="CompareString"/>
        /// <seealso cref="CompareStringEx"/>
        public static SORT_FLAGS CmpFlags(
            STRING_FLAGS string_flags = default,
            SORT_FLAGS sort_flags = default) =>
            (SORT_FLAGS)string_flags | sort_flags;

        /// <summary>
        /// Combines string-finding flags for calls to <see cref="FindNLSString"/> and <see cref="FindNLSStringEx"/>
        /// </summary>
        /// <seealso cref="FindNLSString"/>
        /// <seealso cref="FindNLSStringEx"/>
        public static FIND_FLAGS FindFlags(
            STRING_FLAGS string_flags = default,
            FIND_FLAGS find_flags = default) =>
            (FIND_FLAGS)string_flags | find_flags;

        /// <summary>
        /// Combines locale dependant mapping flags for calls to <see cref="LCMapString"/> and <see cref="LCMapStringEx"/>.
        /// </summary>
        /// <seealso cref="LCMapString"/>
        /// <seealso cref="LCMapStringEx"/>
        public static LCMAP_FLAGS LcMapFlags(
            STRING_FLAGS string_flags = default,
            SORT_FLAGS sort_flags = default,
            LCMAP_FLAGS lcmap_flags = default) =>
            (LCMAP_FLAGS)string_flags | (LCMAP_FLAGS)sort_flags | lcmap_flags;
    }

    /// <summary>
    /// String Flags.
    /// </summary>
    [Flags]
    public enum STRING_FLAGS : int
    {
        /// <summary>
        /// Ignore case. For many scripts (notably Latin scripts), <see cref="NORM_IGNORECASE"/> coincides with <see cref="LINGUISTIC_IGNORECASE"/>.
        /// <para><note><see cref="NORM_IGNORECASE"/> ignores any tertiary distinction, whether it is actually linguistic case or not. For example, in Arabic and Indic scripts, this distinguishes alternate forms of a character, but the differences do not correspond to linguistic case. <see cref="LINGUISTIC_IGNORECASE"/> causes the function to ignore only actual linguistic casing, instead of ignoring the third sorting weight.</note></para>
        /// <para><note>With this flag set, the function ignores the distinction between the wide and narrow forms of the CJK compatibility characters.</note></para>
        /// </summary>
        NORM_IGNORECASE = WinNlsConstants.NORM_IGNORECASE,
        /// <summary>
        /// Ignore nonspacing characters. For many scripts (notably Latin scripts), <see cref="NORM_IGNORENONSPACE"/> coincides with <see cref="LINGUISTIC_IGNOREDIACRITIC"/>.
        /// <para><note><see cref="NORM_IGNORENONSPACE"/> ignores any secondary distinction, whether it is a diacritic or not. Scripts for Korean, Japanese, Chinese, and Indic languages, among others, use this distinction for purposes other than diacritics. <see cref="LINGUISTIC_IGNOREDIACRITIC"/> causes the function to ignore only actual diacritics, instead of ignoring the second sorting weight.</note></para>
        /// <para><note><see cref="NORM_IGNORENONSPACE"/> only has an effect for locales in which accented characters are sorted in a second pass from main characters. Normally all characters in the string are first compared without regard to accents and, if the strings are equal, a second pass over the strings is performed to compare accents. This flag causes the second pass to not be performed. For locales that sort accented characters in the first pass, this flag has no effect.</note></para>
        /// </summary>
        NORM_IGNORENONSPACE = WinNlsConstants.NORM_IGNORENONSPACE,
        /// <summary>Ignore symbols and punctuation.</summary>
        NORM_IGNORESYMBOLS = WinNlsConstants.NORM_IGNORESYMBOLS,

        /// <summary>
        /// Ignore case, as linguistically appropriate.
        /// </summary>
        LINGUISTIC_IGNORECASE = WinNlsConstants.LINGUISTIC_IGNORECASE,
        /// <summary>
        /// Ignore nonspacing characters, as linguistically appropriate.
        /// <para><note>This flag does not always produce predictable results when used with decomposed characters, that is, characters in which a base character and one or more nonspacing characters each have distinct code point values.</note></para>
        /// </summary>
        LINGUISTIC_IGNOREDIACRITIC = WinNlsConstants.LINGUISTIC_IGNOREDIACRITIC,

        /// <summary>Do not differentiate between hiragana and katakana characters. Corresponding hiragana and katakana characters compare as equal.</summary>
        NORM_IGNOREKANATYPE = WinNlsConstants.NORM_IGNOREKANATYPE,
        /// <summary>Ignore the difference between half-width and full-width characters, for example, <c>C a t</c> == <c>cat</c>. The full-width form is a formatting distinction used in Chinese and Japanese scripts.</summary>
        NORM_IGNOREWIDTH = WinNlsConstants.NORM_IGNOREWIDTH,
        /// <summary>Use the default linguistic rules for casing, instead of file system rules. Note that most scenarios for <see cref="CompareStringEx"/> use this flag. This flag does not have to be used when your application calls <see cref="CompareStringOrdinal"/>.</summary>
        NORM_LINGUISTIC_CASING = WinNlsConstants.NORM_LINGUISTIC_CASING,
    }

    /// <summary>
    /// Locale Independent Mapping Flags.
    /// </summary>
    [Flags]
    public enum MAP_FLAGS : int
    {
        /// <inheritdoc cref="WinNlsConstants.MAP_FOLDCZONE"/>
        MAP_FOLDCZONE = WinNlsConstants.MAP_FOLDCZONE,
        /// <inheritdoc cref="WinNlsConstants.MAP_PRECOMPOSED"/>
        MAP_PRECOMPOSED = WinNlsConstants.MAP_PRECOMPOSED,
        /// <inheritdoc cref="WinNlsConstants.MAP_COMPOSITE"/>
        MAP_COMPOSITE = WinNlsConstants.MAP_COMPOSITE,
        /// <inheritdoc cref="WinNlsConstants.MAP_FOLDDIGITS"/>
        MAP_FOLDDIGITS = WinNlsConstants.MAP_FOLDDIGITS,

        /// <inheritdoc cref="WinNlsConstants.MAP_EXPAND_LIGATURES"/>
        MAP_EXPAND_LIGATURES = WinNlsConstants.MAP_EXPAND_LIGATURES,
    }

    /// <summary>
    /// Locale Dependent Mapping Flags.
    /// </summary>
    [Flags]
    public enum LCMAP_FLAGS : int
    {
        /// <summary>For locales and scripts capable of handling uppercase and lowercase, map all characters to lowercase.</summary>
        LCMAP_LOWERCASE = WinNlsConstants.LCMAP_LOWERCASE,
        /// <summary>
        /// For locales and scripts capable of handling uppercase and lowercase, map all characters to uppercase.
        /// </summary>
        LCMAP_UPPERCASE = WinNlsConstants.LCMAP_UPPERCASE,
        /// <summary>
        /// <strong>Windows 7</strong>: Map all characters to title case, in which the first letter of each major word is capitalized.
        /// </summary>
        LCMAP_TITLECASE = WinNlsConstants.LCMAP_TITLECASE,

        /// <summary>
        /// Produce a normalized sort key. If the <see cref="LCMAP_SORTKEY"/> flag is not specified, the function performs string mapping. For details of sort key generation and string mapping, see the Remarks section of <see cref="LCMapStringEx"/>.
        /// </summary>
        LCMAP_SORTKEY = WinNlsConstants.LCMAP_SORTKEY,
        /// <summary>Use byte reversal. For example, if the application passes in <c>0x3450 0x4822</c>, the result is <c>0x5034 0x2248</c>.</summary>
        LCMAP_BYTEREV = WinNlsConstants.LCMAP_BYTEREV,

        /// <summary>Map all katakana characters to hiragana. This flag and <see cref="LCMAP_KATAKANA"/> are mutually exclusive.</summary>
        LCMAP_HIRAGANA = WinNlsConstants.LCMAP_HIRAGANA,
        /// <summary>Map all hiragana characters to katakana. This flag and <see cref="LCMAP_HIRAGANA"/> are mutually exclusive.</summary>
        LCMAP_KATAKANA = WinNlsConstants.LCMAP_KATAKANA,
        /// <summary>Use narrow characters where applicable. This flag and <see cref="LCMAP_FULLWIDTH"/> are mutually exclusive.</summary>
        LCMAP_HALFWIDTH = WinNlsConstants.LCMAP_HALFWIDTH,
        /// <summary>Use Unicode (wide) characters where applicable. This flag and <see cref="LCMAP_HALFWIDTH"/> are mutually exclusive. With this flag, the mapping may use Normalization Form C even if an input character is already full-width. For example, the string <c>"は゛"</c> (which is already full-width) is normalized to <c>"ば"</c>. See <a href="http://www.unicode.org/reports/tr15/">Unicode normalization forms</a>.</summary>
        LCMAP_FULLWIDTH = WinNlsConstants.LCMAP_FULLWIDTH,

        /// <summary>Use linguistic rules for casing, instead of file system rules (default). This flag is valid with <see cref="LCMAP_LOWERCASE"/> or <see cref="LCMAP_UPPERCASE"/> only.</summary>
        LCMAP_LINGUISTIC_CASING = WinNlsConstants.LCMAP_LINGUISTIC_CASING,

        /// <summary>
        /// Map traditional Chinese characters to simplified Chinese characters. This flag and <see cref="LCMAP_TRADITIONAL_CHINESE"/> are mutually exclusive.
        /// </summary>
        LCMAP_SIMPLIFIED_CHINESE = WinNlsConstants.LCMAP_SIMPLIFIED_CHINESE,
        /// <summary>
        /// Map simplified Chinese characters to traditional Chinese characters. This flag and <see cref="LCMAP_SIMPLIFIED_CHINESE"/> are mutually exclusive.
        /// </summary>
        LCMAP_TRADITIONAL_CHINESE = WinNlsConstants.LCMAP_TRADITIONAL_CHINESE,

        /// <summary>
        /// <para>Return a token representing the resolved sort parameters for the locale (like locale name), so future calls can pass <see langword="null"/> for the sort name and pass the previously queried sort handle as the last parameter (<em>sortHandle</em>) in subsequent calls to <see cref="CompareStringEx"/> or <see cref="LCMapStringEx"/>.</para>
        /// <para><see cref="LCMAP_SORTHANDLE"/> requires that the output buffer be of size of a pointer on the platform.</para>
        /// </summary>
        /// <remarks>
        /// The use of a sort handle results in minimal performance improvements and is discouraged.
        /// </remarks>
        LCMAP_SORTHANDLE = WinNlsConstants.LCMAP_SORTHANDLE,
        /// <summary>
        /// <para>Return a hash of the raw sort weights of a string.</para>
        /// <para>Strings that appear equivalent typically return the same hash (for example, <c>"hello"</c> and <c>"HELLO"</c> with <see cref="STRING_FLAGS.NORM_IGNORECASE"/>). However, some complex cases, such as East Asian languages, can have similar strings with identical weights that compare as equal but do not return the same hash.</para>
        /// <para><see cref="LCMAP_HASH"/> requires that the output buffer be of size <c>sizeof(int)</c>.</para>
        /// </summary>
        LCMAP_HASH = WinNlsConstants.LCMAP_HASH,
    }

    /// <summary>
    /// Search Flags
    /// </summary>
    [Flags]
    public enum FIND_FLAGS : int
    {
        /// <summary>
        /// Test to find out if the value to find is the first value in the source string.
        /// </summary>
        FIND_STARTSWITH = WinNlsConstants.FIND_STARTSWITH,
        /// <summary>
        /// Test to find out if the value to find is the last value in the source string.
        /// </summary>
        FIND_ENDSWITH = WinNlsConstants.FIND_ENDSWITH,
        /// <summary>
        /// Search the string, starting with the first character of the string.
        /// </summary>
        FIND_FROMSTART = WinNlsConstants.FIND_FROMSTART,
        /// <summary>
        /// Search the string in the reverse direction, starting with the last character of the string.
        /// </summary>
        FIND_FROMEND = WinNlsConstants.FIND_FROMEND,
    }

    /// <summary>
    /// Language Group Enumeration Flags.
    /// </summary>
    [Obsolete(WinNlsConstants.LGRPID_DEPRECATION_MESSAGE)]
    [Flags]
    public enum LGRPID_FLAGS : int
    {
        /// <inheritdoc cref="WinNlsConstants.LGRPID_INSTALLED"/>
        LGRPID_INSTALLED = WinNlsConstants.LGRPID_INSTALLED,
        /// <inheritdoc cref="WinNlsConstants.LGRPID_SUPPORTED"/>
        LGRPID_SUPPORTED = WinNlsConstants.LGRPID_SUPPORTED,
    }

    /// <summary>
    /// Locale Enumeration Flags.
    /// </summary>
    [Flags]
    public enum LCID_FLAGS : int
    {
        /// <inheritdoc cref="WinNlsConstants.LCID_INSTALLED"/>
        LCID_INSTALLED = WinNlsConstants.LCID_INSTALLED,
        /// <inheritdoc cref="WinNlsConstants.LCID_SUPPORTED"/>
        LCID_SUPPORTED = WinNlsConstants.LCID_SUPPORTED,
        /// <inheritdoc cref="WinNlsConstants.LCID_ALTERNATE_SORTS"/>
        LCID_ALTERNATE_SORTS = WinNlsConstants.LCID_ALTERNATE_SORTS,
    }

    /// <summary>
    /// Locale Enumeration Flags.
    /// </summary>
    [Flags]
    public enum LOCALE_FLAGS : int
    {
        /// <inheritdoc cref="WinNlsConstants.LCID_INSTALLED"/>
        LCID_INSTALLED = WinNlsConstants.LCID_INSTALLED,
        /// <inheritdoc cref="WinNlsConstants.LCID_SUPPORTED"/>
        LCID_SUPPORTED = WinNlsConstants.LCID_SUPPORTED,
        /// <inheritdoc cref="WinNlsConstants.LCID_ALTERNATE_SORTS"/>
        LCID_ALTERNATE_SORTS = WinNlsConstants.LCID_ALTERNATE_SORTS,
    }

    /// <summary>
    /// Code Page Enumeration Flags.
    /// </summary>
    [Flags]
    public enum CP_FLAGS : int
    {
        /// <inheritdoc cref="WinNlsConstants.CP_INSTALLED"/>
        CP_INSTALLED = WinNlsConstants.CP_INSTALLED,
        /// <inheritdoc cref="WinNlsConstants.CP_SUPPORTED"/>
        CP_SUPPORTED = WinNlsConstants.CP_SUPPORTED,
    }

    /// <summary>
    /// Sorting Flags.
    /// </summary>
    [Flags]
    public enum SORT_FLAGS : int
    {
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
        /// <summary>
        /// Treat punctuation the same as symbols.
        /// </summary>
        SORT_STRINGSORT = WinNlsConstants.SORT_STRINGSORT,

        /// <summary>
        /// <strong>Windows 7</strong>: Treat digits as numbers during sorting, for example, sort "2" before "10".
        /// </summary>
        SORT_DIGITSASNUMBERS = WinNlsConstants.SORT_DIGITSASNUMBERS,
    }
}
