using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1328
    /// <inheritdoc cref="LANGGROUPLOCALE_ENUMPROC"/>
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGGROUPLOCALE_ENUMPROCA(
        LGRPID lgrpid,
        int lcid,
        LPSTR Arg3,
        int Arg4
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1343
    /// <inheritdoc cref="LANGGROUPLOCALE_ENUMPROC"/>
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGGROUPLOCALE_ENUMPROCW(
        LGRPID lgrpid,
        int lcid,
        LPWSTR Arg3,
        int Arg4
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1394
    /// <summary>
    /// An application-defined callback function that processes enumerated language group locale information provided by the <see cref="EnumLanguageGroupLocales"/> function. The <see cref="LANGGROUPLOCALE_ENUMPROC"/> type defines a pointer to this callback function.
    /// </summary>
    /// <returns>Returns <see langword="true"/> to continue enumeration or <see langword="false"/> otherwise.</returns>
    /// <remarks>
    /// An <see cref="LANGGROUPLOCALE_ENUMPROC"/> function can carry out any desired task. The application registers this function by passing its address to the <see cref="EnumLanguageGroupLocales"/> function.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nc-winnls-langgrouplocale_enumprocw">LANGGROUPLOCALE_ENUMPROCW callback function</a></para>
    /// </remarks>
    /// <seealso cref="EnumLanguageGroupLocales"/>
    /// <seealso cref="EnumSystemLanguageGroups"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGGROUPLOCALE_ENUMPROC(
        LGRPID lgrpid,
        int lcid,
        LPTSTR Arg3,
        int Arg4
        );
}
