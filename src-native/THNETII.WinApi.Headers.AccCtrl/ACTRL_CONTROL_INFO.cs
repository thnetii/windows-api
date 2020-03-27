using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 688
    /// <inheritdoc cref="ACTRL_CONTROL_INFO"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTRL_CONTROL_INFOA
    {
        /// <inheritdoc cref="ACTRL_CONTROL_INFO.lpControlId"/>
        public LPSTR lpControlId;
        /// <inheritdoc cref="ACTRL_CONTROL_INFO.lpControlName"/>
        public LPSTR lpControlName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 693
    /// <inheritdoc cref="ACTRL_CONTROL_INFO"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ACTRL_CONTROL_INFOW
    {
        /// <inheritdoc cref="ACTRL_CONTROL_INFO.lpControlId"/>
        public LPWSTR lpControlId;
        /// <inheritdoc cref="ACTRL_CONTROL_INFO.lpControlName"/>
        public LPWSTR lpControlName;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 698
#if !NETSTANDARD1_6
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
#else
    [StructLayout(LayoutKind.Sequential)]
#endif
    public struct ACTRL_CONTROL_INFO
    {
        public LPTSTR lpControlId;
        public LPTSTR lpControlName;
    }
}
