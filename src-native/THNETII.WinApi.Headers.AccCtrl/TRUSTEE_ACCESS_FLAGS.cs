using System;

namespace THNETII.WinApi.Native.AccCtrl
{
    /// <summary>
    /// TRUSTEE_ACCESS flags
    /// </summary>
    [Flags]
    public enum TRUSTEE_ACCESS_FLAGS : int
    {
        TRUSTEE_ACCESS_ALLOWED = AccCtrlConstants.TRUSTEE_ACCESS_ALLOWED,
        TRUSTEE_ACCESS_READ = AccCtrlConstants.TRUSTEE_ACCESS_READ,
        TRUSTEE_ACCESS_WRITE = AccCtrlConstants.TRUSTEE_ACCESS_WRITE,

        TRUSTEE_ACCESS_EXPLICIT = AccCtrlConstants.TRUSTEE_ACCESS_EXPLICIT,
        TRUSTEE_ACCESS_READ_WRITE = AccCtrlConstants.TRUSTEE_ACCESS_READ_WRITE,

        TRUSTEE_ACCESS_ALL = AccCtrlConstants.TRUSTEE_ACCESS_ALL,
    }
}
