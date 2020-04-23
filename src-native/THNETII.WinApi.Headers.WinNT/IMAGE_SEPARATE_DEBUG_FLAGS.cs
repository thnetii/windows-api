using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_SEPARATE_DEBUG_FLAGS : short
    {
        /// <inheritdoc cref="WinNTConstants.IMAGE_SEPARATE_DEBUG_MISMATCH"/>
        IMAGE_SEPARATE_DEBUG_MISMATCH = WinNTConstants.IMAGE_SEPARATE_DEBUG_MISMATCH,
    }
}
