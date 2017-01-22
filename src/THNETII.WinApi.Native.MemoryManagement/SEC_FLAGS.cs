using System;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum SEC_FLAGS : int
    {
        SEC_64K_PAGES = 0x00080000,
        SEC_FILE = 0x00800000,
        SEC_IMAGE = 0x01000000,
        SEC_PROTECTED_IMAGE = 0x02000000,
        SEC_RESERVE = 0x04000000,
        SEC_COMMIT = 0x08000000,
        SEC_NOCACHE = 0x10000000,
        SEC_WRITECOMBINE = 0x40000000,
        SEC_LARGE_PAGES = unchecked((int)0x80000000),
        SEC_IMAGE_NO_EXECUTE = (SEC_IMAGE | SEC_NOCACHE),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
