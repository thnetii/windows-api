using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum HEAP_TAG_FLAGS : int
    {
        HEAP_NO_SERIALIZE = WinNTConstants.HEAP_NO_SERIALIZE,
        HEAP_GROWABLE = WinNTConstants.HEAP_GROWABLE,
        HEAP_GENERATE_EXCEPTIONS = WinNTConstants.HEAP_GENERATE_EXCEPTIONS,
        HEAP_ZERO_MEMORY = WinNTConstants.HEAP_ZERO_MEMORY,
        HEAP_REALLOC_IN_PLACE_ONLY = WinNTConstants.HEAP_REALLOC_IN_PLACE_ONLY,
        HEAP_TAIL_CHECKING_ENABLED = WinNTConstants.HEAP_TAIL_CHECKING_ENABLED,
        HEAP_FREE_CHECKING_ENABLED = WinNTConstants.HEAP_FREE_CHECKING_ENABLED,
        HEAP_DISABLE_COALESCE_ON_FREE = WinNTConstants.HEAP_DISABLE_COALESCE_ON_FREE,
        HEAP_CREATE_ALIGN_16 = WinNTConstants.HEAP_CREATE_ALIGN_16,
        HEAP_CREATE_ENABLE_TRACING = WinNTConstants.HEAP_CREATE_ENABLE_TRACING,
        HEAP_CREATE_ENABLE_EXECUTE = WinNTConstants.HEAP_CREATE_ENABLE_EXECUTE,
        HEAP_CREATE_SEGMENT_HEAP = WinNTConstants.HEAP_CREATE_SEGMENT_HEAP,
        HEAP_CREATE_HARDENED = WinNTConstants.HEAP_CREATE_HARDENED,
    }
}
