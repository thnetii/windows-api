using System;

namespace THNETII.WinApi.Native.WinNls
{
    [Flags]
    public enum NLSSTRING_FLAGS : int
    {
        //
        //  String Flags.
        //
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

        //
        //  Search Flags
        //
        /// <summary>Test to find out if the value to find is the first value in the source string.</summary>
        FIND_STARTSWITH = WinNlsConstants.FIND_STARTSWITH,
        /// <summary>Test to find out if the value to find is the last value in the source string.</summary>
        FIND_ENDSWITH = WinNlsConstants.FIND_ENDSWITH,
        /// <summary>Search the string, starting with the first character of the string.</summary>
        FIND_FROMSTART = WinNlsConstants.FIND_FROMSTART,
        /// <summary>Search the string in the reverse direction, starting with the last character of the string.</summary>
        FIND_FROMEND = WinNlsConstants.FIND_FROMEND,

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
        /// <summary>Treat punctuation the same as symbols.</summary>
        SORT_STRINGSORT = WinNlsConstants.SORT_STRINGSORT,
        /// <summary><strong>Windows 7</strong>: Treat digits as numbers during sorting, for example, sort <c>"2"</c> before <c>"10"</c>.</summary>
        SORT_DIGITSASNUMBERS = WinNlsConstants.SORT_DIGITSASNUMBERS,
    }
}
