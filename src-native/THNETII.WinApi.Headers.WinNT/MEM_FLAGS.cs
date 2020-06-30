using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum MEM_FLAGS : int
    {
        MEM_COMMIT = WinNTConstants.MEM_COMMIT,
        MEM_RESERVE = WinNTConstants.MEM_RESERVE,
        MEM_REPLACE_PLACEHOLDER = WinNTConstants.MEM_REPLACE_PLACEHOLDER,
        MEM_RESERVE_PLACEHOLDER = WinNTConstants.MEM_RESERVE_PLACEHOLDER,
        MEM_RESET = WinNTConstants.MEM_RESET,
        MEM_TOP_DOWN = WinNTConstants.MEM_TOP_DOWN,
        MEM_WRITE_WATCH = WinNTConstants.MEM_WRITE_WATCH,
        MEM_PHYSICAL = WinNTConstants.MEM_PHYSICAL,
        MEM_ROTATE = WinNTConstants.MEM_ROTATE,
        MEM_DIFFERENT_IMAGE_BASE_OK = WinNTConstants.MEM_DIFFERENT_IMAGE_BASE_OK,
        MEM_RESET_UNDO = WinNTConstants.MEM_RESET_UNDO,
        MEM_LARGE_PAGES = WinNTConstants.MEM_LARGE_PAGES,
        MEM_4MB_PAGES = WinNTConstants.MEM_4MB_PAGES,
        MEM_64K_PAGES = WinNTConstants.MEM_64K_PAGES,
        MEM_UNMAP_WITH_TRANSIENT_BOOST = WinNTConstants.MEM_UNMAP_WITH_TRANSIENT_BOOST,
        MEM_COALESCE_PLACEHOLDERS = WinNTConstants.MEM_COALESCE_PLACEHOLDERS,
        MEM_PRESERVE_PLACEHOLDER = WinNTConstants.MEM_PRESERVE_PLACEHOLDER,
        MEM_DECOMMIT = WinNTConstants.MEM_DECOMMIT,
        MEM_RELEASE = WinNTConstants.MEM_RELEASE,
        MEM_FREE = WinNTConstants.MEM_FREE,
    }
}
