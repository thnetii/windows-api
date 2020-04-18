using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1332
    /// <inheritdoc cref="UILANGUAGE_ENUMPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool UILANGUAGE_ENUMPROCA(
        LPSTR Arg1,
        IntPtr Arg2
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1345
    /// <inheritdoc cref="UILANGUAGE_ENUMPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool UILANGUAGE_ENUMPROCW(
        LPWSTR Arg1,
        IntPtr Arg2
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1396
    /// <summary>
    /// An application-defined callback function that processes enumerated user interface language information provided by the <see cref="EnumUILanguages"/> function. The <see cref="UILANGUAGE_ENUMPROC"/> type defines a pointer to this callback function.
    /// </summary>
    /// <returns>Returns <see langword="true"/> to continue enumeration or <see langword="false"/> otherwise.</returns>
    /// <remarks>
    /// <para>An <see cref="UILANGUAGE_ENUMPROC"/> function can carry out any task. The application registers this function by passing its address to the <see cref="EnumUILanguages"/> function.</para>
    /// <para>
    /// If <see cref="MUI_LANGUAGE_ID"/> was specified in the call to <see cref="EnumUILanguages"/>, the language strings passed to this function will be hexadecimal language
    /// identifiers that do not include the leading 0x, and will be 4 characters in length. For example, <c>en-US</c> will
    /// be passed as <c>"0409"</c> and <c>en</c> as <c>"0009"</c>.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nc-winnls-langgrouplocale_enumprocw">LANGGROUPLOCALE_ENUMPROCW callback function</a></para>
    /// </remarks>
    /// <seealso cref="EnumUILanguages"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/multilingual-user-interface">Multilingual User Interface</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/multilingual-user-interface-functions">Multilingual User Interface Functions</seealso>
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool UILANGUAGE_ENUMPROC(
        LPTSTR Arg1,
        IntPtr Arg2
        );
}
