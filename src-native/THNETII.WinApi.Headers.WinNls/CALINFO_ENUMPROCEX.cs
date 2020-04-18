using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1338
    /// <inheritdoc cref="CALINFO_ENUMPROCEX"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool CALINFO_ENUMPROCEXA(LPSTR Arg1, CALID Arg2);

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1351
    /// <inheritdoc cref="CALINFO_ENUMPROCEX"/>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool CALINFO_ENUMPROCEXW(LPWSTR Arg1, CALID Arg2);


    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1402
    [UnmanagedFunctionPointer(CallingConvention.StdCall
#if !NETSTANDARD1_3
        , CharSet = CharSet.Auto
#endif
        )]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool CALINFO_ENUMPROCEX(LPTSTR Arg1, CALID Arg2);
}
