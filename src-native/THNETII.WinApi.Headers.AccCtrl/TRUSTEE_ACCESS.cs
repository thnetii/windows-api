using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 504
    /// <inheritdoc cref="TRUSTEE_ACCESS"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TRUSTEE_ACCESSA
    {
        /// <inheritdoc cref="TRUSTEE_ACCESS.lpProperty"/>
        public LPSTR lpProperty;
        /// <inheritdoc cref="TRUSTEE_ACCESS.Access"/>
        public ACCESS_RIGHTS Access;
        /// <inheritdoc cref="TRUSTEE_ACCESS.fAccessFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fAccessFlags;
        /// <inheritdoc cref="TRUSTEE_ACCESS.fReturnedAccess"/>
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fReturnedAccess;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 511
    /// <inheritdoc cref="TRUSTEE_ACCESS"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TRUSTEE_ACCESSW
    {
        /// <inheritdoc cref="TRUSTEE_ACCESS.lpProperty"/>
        public LPWSTR lpProperty;
        /// <inheritdoc cref="TRUSTEE_ACCESS.Access"/>
        public ACCESS_RIGHTS Access;
        /// <inheritdoc cref="TRUSTEE_ACCESS.fAccessFlags"/>
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fAccessFlags;
        /// <inheritdoc cref="TRUSTEE_ACCESS.fReturnedAccess"/>
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fReturnedAccess;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 518
#if !(NETSTANDARD1_3 || NETSTANDARD1_6)
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct TRUSTEE_ACCESS
    {
        public LPTSTR lpProperty;
        public ACCESS_RIGHTS Access;
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fAccessFlags;
        [MarshalAs(UnmanagedType.U4)]
        public TRUSTEE_ACCESS_FLAGS fReturnedAccess;
    }
}
