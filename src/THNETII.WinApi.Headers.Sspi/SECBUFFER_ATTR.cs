namespace THNETII.WinApi.Native.Sspi
{
    public enum SECBUFFER_ATTR
    {
        /// <summary>
        ///  The buffer is read-only with no checksum. This flag is intended for sending header information to the security package for computing the checksum. The package can read this buffer, but cannot modify it.
        /// </summary>
        SECBUFFER_READONLY = SspiConstants.SECBUFFER_READONLY,  // Buffer is read-only, no checksum
        /// <summary>
        /// The buffer is read-only with a checksum.
        /// </summary>
        SECBUFFER_READONLY_WITH_CHECKSUM = SspiConstants.SECBUFFER_READONLY_WITH_CHECKSUM,  // Buffer is read-only, and checksummed
        SECBUFFER_RESERVED = SspiConstants.SECBUFFER_RESERVED,  // Flags reserved to security system
    }
}
