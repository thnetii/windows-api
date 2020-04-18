using System;
using System.Runtime.CompilerServices;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNls
{
    using static WinNlsConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h
    public static class WinNlsFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1448
        ////////////////////////////////////////////////////////////////////////////
        //
        //  Macros
        //
        //  Define all macros for the NLS component here.
        //
        ////////////////////////////////////////////////////////////////////////////

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1456
        //
        //  Macros to determine whether a character is a high or low surrogate,
        //  and whether two code points make up a surrogate pair (a high surrogate
        //  and a low surrogate).
        //
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1461
        #region IS_HIGH_SURROGATE macro
        /// <summary>
        /// Determines if a character is a UTF-16 high <a href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">surrogate</a> code point, ranging from <c>0xd800</c> to <c>0xdbff</c>, inclusive.
        /// </summary>
        /// <param name="wch">Character to test.</param>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-is_high_surrogate">IS_HIGH_SURROGATE macro</a></para>
        /// </remarks>
        /// <seealso cref="char.IsHighSurrogate(char)"/>
        /// <seealso cref="IS_LOW_SURROGATE"/>
        /// <seealso cref="IS_SURROGATE_PAIR"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-macros">National Language Support Macros</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">Surrogates and Supplementary Characters</seealso>
        [Obsolete(".NET applications should use the static methods on the System.Char type instead.")]
        public static bool IS_HIGH_SURROGATE(char wch) =>
            (wch >= HIGH_SURROGATE_START) && (wch <= HIGH_SURROGATE_END);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1462
        #region IS_LOW_SURROGATE macro
        /// <summary>
        /// Determines if a character is a UTF-16 low <a href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">surrogate</a> code point, ranging from <c>0xdc00</c> to <c>0xdfff</c>, inclusive.
        /// </summary>
        /// <param name="wch">Character to test.</param>
        /// <remarks>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-is_low_surrogate">IS_LOW_SURROGATE macro</a></para>
        /// </remarks>
        /// <seealso cref="char.IsLowSurrogate(char)"/>
        /// <seealso cref="IS_HIGH_SURROGATE"/>
        /// <seealso cref="IS_SURROGATE_PAIR"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-macros">National Language Support Macros</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">Surrogates and Supplementary Characters</seealso>
        [Obsolete(".NET applications should use the static methods on the System.Char type instead.")]
        public static bool IS_LOW_SURROGATE(char wch) =>
            (((wch) >= LOW_SURROGATE_START) && ((wch) <= LOW_SURROGATE_END));
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1463
        #region IS_SURROGATE_PAIR macro
        /// <summary>
        /// Determines if the specified code units form a UTF-16 <a href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">surrogate pair</a>.
        /// </summary>
        /// <param name="hs">UTF-16 code unit to test for a high surrogate value. The range for a high UTF-16 code unit is <c>0xd800</c> to <c>0xdbff</c>, inclusive.</param>
        /// <param name="ls">UTF-16 code unit to test for a low surrogate value. The range for a low UTF-16 code unit is <c>0xdc00</c> to <c>0xdfff</c>, inclusive.</param>
        /// <remarks>
        /// For this macro to succeed, the <paramref name="hs"/> value must be a high UTF-16 code unit, and the <paramref name="ls"/> value must be a low UTF-16 code unit.
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-is_surrogate_pair">IS_SURROGATE_PAIR macro</a></para>
        /// </remarks>
        /// <seealso cref="char.IsSurrogatePair(char, char)"/>
        /// <seealso cref="IS_HIGH_SURROGATE"/>
        /// <seealso cref="IS_LOW_SURROGATE"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-macros">National Language Support Macros</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">Surrogates and Supplementary Characters</seealso>
        [Obsolete(".NET applications should use the static methods on the System.Char type instead.")]
        public static bool IS_SURROGATE_PAIR(char hs, char ls) =>
            (IS_HIGH_SURROGATE(hs) && IS_LOW_SURROGATE(ls));
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1498
        ////////////////////////////////////////////////////////////////////////////
        //
        //  Function Prototypes
        //
        //  Only prototypes for the NLS APIs should go here.
        //
        ////////////////////////////////////////////////////////////////////////////

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1506
        //
        //  Code Page Dependent APIs.
        //
        //  Applications should use Unicode (WCHAR / UTF-16 &/or UTF-8)
        //

    }
}
