using System;
using System.Runtime.InteropServices;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinNls
{
    using static NativeLibraryNames;
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1512
        #region IsValidCodePage function
        /// <summary>
        /// Determines if a specified code page is valid.
        /// </summary>
        /// <param name="CodePage"><a href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code page identifier</a> for the code page to check.</param>
        /// <returns>Returns <see langword="true"/> if the code page is valid, or <see langword="false"/> if the code page is invalid.</returns>
        /// <remarks>
        /// <para>A code page is considered valid only if it is installed on the operating system. Unicode is preferred.</para>
        /// <para>Starting with Windows Vista, all code pages that can be installed are loaded by default.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-isvalidcodepage">IsValidCodePage function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetACP"/>
        /// <seealso cref="GetCPInfo"/>
        /// <seealso cref="GetOEMCP"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidCodePage(
            [In] int CodePage
            );
        #endregion
        #region GetACP function
        /// <summary>
        /// Retrieves the current Windows ANSI code page identifier for the operating system.
        /// <para><note type="caution">
        /// The ANSI API functions, for example, the ANSI version of <see cref="TextOut"/>, implicitly use <see cref="GetACP"/> to translate text to or from Unicode. For the Multilingual User Interface (MUI) edition of Windows, the system ACP might not cover all code points in the user's selected logon language identifier. For compatibility with this edition, your application should avoid calls that depend on <see cref="GetACP"/> either implicitly or explicitly, as this function can cause some locales to display text as question marks. Instead, the application should use the Unicode API functions directly, for example, the Unicode version of <see cref="TextOut"/>.
        /// </note></para>
        /// </summary>
        /// <returns>Returns the current Windows ANSI code page (ACP) identifier for the operating system. See <a href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</a> for a list of identifiers for Windows ANSI code pages and other code pages.</returns>
        /// <remarks>
        /// <para>The ANSI code pages can be different on different computers, or can be changed for a single computer, leading to data corruption. For the most consistent results, applications should use UTF-8 or UTF-16 when possible.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-getacp">GetACP function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</seealso>
        /// <seealso cref="GetCPInfo"/>
        /// <seealso cref="GetOEMCP"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetACP();
        #endregion
    }
}
