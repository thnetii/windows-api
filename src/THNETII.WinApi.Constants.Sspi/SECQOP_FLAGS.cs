using System;

namespace THNETII.WinApi.Native.Sspi
{
    [Flags]
    public enum SECQOP_FLAGS : int
    {
        SECQOP_WRAP_NO_ENCRYPT = SspiConstants.SECQOP_WRAP_NO_ENCRYPT,
        SECQOP_WRAP_OOB_DATA = SspiConstants.SECQOP_WRAP_OOB_DATA,
    }
}
