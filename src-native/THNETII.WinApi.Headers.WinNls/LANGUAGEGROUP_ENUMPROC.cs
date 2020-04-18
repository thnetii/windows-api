using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1328
    /// <inheritdoc cref="LANGUAGEGROUP_ENUMPROC"/>
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGUAGEGROUP_ENUMPROCA(
        LGRPID lgrpid,
        LPSTR arg2,
        LPSTR arg3,
        int arg4,
        int arg5
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1341
    /// <inheritdoc cref="LANGUAGEGROUP_ENUMPROC"/>
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGUAGEGROUP_ENUMPROCW(
        LGRPID lgrpid,
        LPWSTR arg2,
        LPWSTR arg3,
        int arg4,
        int arg5
        );

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1392
    [Obsolete("The Language Group concept is obsolete and no longer supported.")]
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )] 
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LANGUAGEGROUP_ENUMPROC(
        LGRPID lgrpid,
        LPTSTR arg2,
        LPTSTR arg3,
        int arg4,
        int arg5
        );
}
