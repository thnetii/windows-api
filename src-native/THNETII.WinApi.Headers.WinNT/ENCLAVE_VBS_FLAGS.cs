using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum ENCLAVE_VBS_FLAGS : int
    {
        /// <summary>
        /// The enclave permits debugging. 
        /// </summary>
        ENCLAVE_VBS_FLAG_DEBUG = WinNTConstants.ENCLAVE_VBS_FLAG_DEBUG,
    }
}
