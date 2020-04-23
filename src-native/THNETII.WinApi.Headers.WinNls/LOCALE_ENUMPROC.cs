using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1339
    /// <inheritdoc cref="LOCALE_ENUMPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LOCALE_ENUMPROCA(LPSTR Arg1);

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1340
    /// <inheritdoc cref="LOCALE_ENUMPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LOCALE_ENUMPROCW(LPWSTR Arg1);


    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1403
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool LOCALE_ENUMPROC(LPTSTR Arg1);
}
