using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1335
    /// <inheritdoc cref="DATEFMT_ENUMPROCEX"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool DATEFMT_ENUMPROCEXA(LPSTR Arg1, CALID Arg2);

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1348
    /// <inheritdoc cref="DATEFMT_ENUMPROCEX"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool DATEFMT_ENUMPROCEXW(LPWSTR Arg1, CALID Arg2);


    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1399
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool DATEFMT_ENUMPROCEX(LPTSTR Arg1, CALID Arg2);
}
