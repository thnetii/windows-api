using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinSCard
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 884
    /// <inheritdoc cref="OCNCONNPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Ansi)]
    public delegate SCARDHANDLE OCNCONNPROCA(
        [In] SCARDCONTEXT hSCardContext,
        [In] LPSTR szReader,
        [In] LPMSTR mszCards,
        [In] IntPtr pvUserData
        );
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 885
    /// <inheritdoc cref="OCNCONNPROC"/>
    [UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Unicode)]
    public delegate SCARDHANDLE OCNCONNPROCW(
        [In] SCARDCONTEXT hSCardContext,
        [In] LPWSTR szReader,
        [In] LPMWSTR mszCards,
        [In] IntPtr pvUserData
        );
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 886
    /// <param name="hSCardContext">the card context passed in the parameter block</param>
    /// <param name="szReader">the name of the reader</param>
    /// <param name="mszCards">
    /// multiple string that contains
    /// the possible card names in the reader
    /// </param>
    /// <param name="pvUserData">pointer to user data passed in parameter block</param>
#if !NETSTANDARD1_3
    [UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Auto)] 
#else
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
#endif // !NETSTANDARD1_3
    public delegate SCARDHANDLE OCNCONNPROC(
        [In] SCARDCONTEXT hSCardContext,
        [In] LPTSTR szReader,
        [In] LPMTSTR mszCards,
        [In] IntPtr pvUserData
        );

    [StructLayout(LayoutKind.Sequential)]
    public struct LPOCNCONNPROCA : IFunctionPointer<OCNCONNPROCA>
    {
        public IntPtr Pointer { get; }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct LPOCNCONNPROCW : IFunctionPointer<OCNCONNPROCW>
    {
        public IntPtr Pointer { get; }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct LPOCNCONNPROC : IFunctionPointer<OCNCONNPROC>
    {
        public IntPtr Pointer { get; }
    }
}
