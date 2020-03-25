using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 670
    /// <inheritdoc cref="ACTRL_ACCESS_INFO"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTRL_ACCESS_INFOA
    {
        /// <inheritdoc cref="ACTRL_ACCESS_INFO.fAccessPermission"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessPermission;
        /// <inheritdoc cref="ACTRL_ACCESS_INFO.lpAccessPermissionName"/>
        public LPSTR lpAccessPermissionName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 675
    /// <inheritdoc cref="ACTRL_ACCESS_INFO"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ACTRL_ACCESS_INFOW
    {
        /// <inheritdoc cref="ACTRL_ACCESS_INFO.fAccessPermission"/>
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessPermission;
        /// <inheritdoc cref="ACTRL_ACCESS_INFO.lpAccessPermissionName"/>
        public LPWSTR lpAccessPermissionName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 680
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct ACTRL_ACCESS_INFO
    {
        [MarshalAs(UnmanagedType.U4)]
        public ACCESS_FLAGS fAccessPermission;
        public LPTSTR lpAccessPermissionName;
    }
}
