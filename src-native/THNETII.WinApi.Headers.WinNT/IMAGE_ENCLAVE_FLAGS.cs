using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum IMAGE_ENCLAVE_FLAGS : int
    {
        /// <summary>
        /// The image is suitable for use as the primary image in the enclave. 
        /// </summary>
        IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE = WinNTConstants.IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE,
    }
}
