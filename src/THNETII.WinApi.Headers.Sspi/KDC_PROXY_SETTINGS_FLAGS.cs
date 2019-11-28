using System;

namespace THNETII.WinApi.Native.Sspi
{
    [Flags]
    public enum KDC_PROXY_SETTINGS_FLAGS : int
    {
        KDC_PROXY_SETTINGS_FLAGS_FORCEPROXY = SspiConstants.KDC_PROXY_SETTINGS_FLAGS_FORCEPROXY,
    }
}
