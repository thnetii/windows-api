using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.WinNls
{
    using static NativeLibraryNames;
    using static WinErrorConstants;
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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1518
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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1529
        #region GetOEMCP function
        /// <summary>
        /// Returns the current original equipment manufacturer (OEM) code page identifier for the operating system.
        /// <para><note>The ANSI code pages can be different on different computers, or can be changed for a single computer, leading to data corruption. For the most consistent results, applications should use Unicode, such as UTF-8 or UTF-16, instead of a specific code page.</note></para>
        /// </summary>
        /// <returns>Returns the current OEM code page identifier for the operating system.</returns>
        /// <remarks>
        /// See <a href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</a> for a list of OEM and other code pages.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps only]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps only]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-getoemcp">GetOEMCP function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="GetACP"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetOEMCP();
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1540
        #region GetCPInfo function
        /// <summary>
        /// Retrieves information about any valid installed or available code page.
        /// <para><note>To obtain additional information about valid installed or available code pages, the application should use <see cref="GetCPInfoEx"/>.</note></para>
        /// </summary>
        /// <param name="CodePage">Identifier for the code page for which to retrieve information. For details, see the <em>CodePage</em> parameter of <see cref="GetCPInfoEx"/>.</param>
        /// <param name="lpCPInfo">A <see cref="CPINFO"/> structure that receives information about the code page. See the Remarks section.</param>
        /// <returns>
        /// Returns <see langword="true"/> if successful, or <see langword="false"/> otherwise. To get extended error information, the application can call <see cref="GetLastError"/>, which can return one of the following error codes:
        /// <list type="table">
        /// <item><term><see cref="ERROR_INVALID_PARAMETER"/></term><description>Any of the parameter values was invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// See Remarks for <see cref="GetCPInfoEx"/>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-getcpinfo">GetCPInfo function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CPINFO"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</seealso>
        /// <seealso cref="GetACP"/>
        /// <seealso cref="GetCPInfoEx"/>
        /// <seealso cref="GetOEMCP"/>
        /// <seealso cref="MultiByteToWideChar"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
        /// <seealso cref="WideCharToMultiByte"/>
        [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accuratedly and may be unreliable on many machines.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfo(
            [In] int CodePage,
            out CPINFO lpCPInfo
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1548
        #region GetCPInfoExA function
        /// <inheritdoc cref="GetCPInfoEx"/>
        [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accuratedly and may be unreliable on many machines.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExA(
            [In] int CodePage,
            [In] int dwFlags,
            out CPINFOEXA lpCPInfoEx
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1556
        #region GetCPInfoExW function
        /// <inheritdoc cref="GetCPInfoEx"/>
        [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accuratedly and may be unreliable on many machines.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExW(
            [In] int CodePage,
            [In] int dwFlags,
            out CPINFOEXW lpCPInfoEx
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1564
        #region GetCPInfoEx function
        /// <summary>
        /// Retrieves information about any valid installed or available code page.
        /// </summary>
        /// <param name="CodePage">
        /// Identifier for the code page for which to retrieve information. The application can specify the code page identifier for any installed or available code page, or one of the following predefined values. See <a href="https://docs.microsoft.com/windows/desktop/Intl/code-page-identifiers">Code Page Identifiers</a> for a list of identifiers for ANSI and other code pages.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="CP_ACP"/></term><description>Use the system default Windows ANSI code page.</description></item>
        /// <item><term><see cref="CP_MACCP"/></term><description>Use the system default Macintosh code page.</description></item>
        /// <item><term><see cref="CP_OEMCP"/></term><description>Use the system default OEM code page.</description></item>
        /// <item><term><see cref="CP_THREAD_ACP"/></term><description>Use the current thread's ANSI code page.</description></item>
        /// </list>
        /// </param>
        /// <param name="dwFlags">Reserved; must be <c>0</c> (zero).</param>
        /// <param name="lpCPInfoEx">A <see cref="CPINFOEX"/> structure that receives information about the code page.</param>
        /// <returns>
        /// Returns <see langword="true"/> if successful, or <see langword="false"/> otherwise. To get extended error information, the application can call <see cref="GetLastError"/>, which can return one of the following error codes:
        /// <list type="table">
        /// <item><term><see cref="ERROR_INVALID_PARAMETER"/></term><description>Any of the parameter values was invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>The information retrieved in the <see cref="CPINFOEX"/> structure is not always useful for all code pages. To determine buffer sizes, for example, the application should call <see cref="MultiByteToWideChar"/> or <see cref="WideCharToMultiByte"/> to request an accurate buffer size. If <see cref="CPINFOEX"/> settings indicate that a lead byte exists, the conversion function does not necessarily handle lead bytes differently, for example, in the case of a missing or illegal trail byte.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nf-winnls-getcpinfoexw">GetCPInfoExW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CPINFOEX"/>
        /// <seealso cref="GetACP"/>
        /// <seealso cref="GetCPInfo"/>
        /// <seealso cref="GetOEMCP"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
        [Obsolete("Use Unicode. The information in this structure cannot represent all encodings accuratedly and may be unreliable on many machines.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto 
#endif
            )]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoEx(
            [In] int CodePage,
            [In] int dwFlags,
            out CPINFOEX lpCPInfoEx
            );
        #endregion
    }
}
