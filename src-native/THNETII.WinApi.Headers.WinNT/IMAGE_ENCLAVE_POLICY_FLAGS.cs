using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum IMAGE_ENCLAVE_POLICY_FLAGS : int
    {
        /// <summary>
        ///  The enclave permits debugging. 
        /// </summary>
        IMAGE_ENCLAVE_POLICY_DEBUGGABLE = WinNTConstants.IMAGE_ENCLAVE_POLICY_DEBUGGABLE,
    }
}
