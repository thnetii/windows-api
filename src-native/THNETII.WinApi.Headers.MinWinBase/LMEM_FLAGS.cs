using System;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.MinWinBase
{
    /// <summary>
    /// Local Memory Flags
    /// </summary>
    [Flags]
    public enum LMEM_FLAGS : int
    {
        LMEM_FIXED = MinWinBaseConstants.LMEM_FIXED,
        LMEM_MOVEABLE = MinWinBaseConstants.LMEM_MOVEABLE,
        [Obsolete("Value is obsolete but provided for compatibility with 16-bit Windows.")]
        LMEM_NOCOMPACT = MinWinBaseConstants.LMEM_NOCOMPACT,
        [Obsolete("Value is obsolete but provided for compatibility with 16-bit Windows.")]
        LMEM_NODISCARD = MinWinBaseConstants.LMEM_NODISCARD,
        LMEM_ZEROINIT = MinWinBaseConstants.LMEM_ZEROINIT,
        LMEM_MODIFY = MinWinBaseConstants.LMEM_MODIFY,
        [Obsolete("Value is obsolete but provided for compatibility with 16-bit Windows.")]
        LMEM_DISCARDABLE = MinWinBaseConstants.LMEM_DISCARDABLE,
        LMEM_VALID_FLAGS = MinWinBaseConstants.LMEM_VALID_FLAGS,
        LMEM_INVALID_HANDLE = MinWinBaseConstants.LMEM_INVALID_HANDLE,

        LHND = MinWinBaseConstants.LHND,
        LPTR = MinWinBaseConstants.LPTR,

        NONZEROLHND = MinWinBaseConstants.NONZEROLHND,
        NONZEROLPTR = MinWinBaseConstants.NONZEROLPTR,
    }
}
