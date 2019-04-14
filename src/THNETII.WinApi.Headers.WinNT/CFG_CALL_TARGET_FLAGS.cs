using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum CFG_CALL_TARGET_FLAGS : int
    {
        /// <inheritdoc cref="WinNTConstants.CFG_CALL_TARGET_VALID"/>
        CFG_CALL_TARGET_VALID = WinNTConstants.CFG_CALL_TARGET_VALID,
        /// <inheritdoc cref="WinNTConstants.CFG_CALL_TARGET_PROCESSED"/>
        CFG_CALL_TARGET_PROCESSED = WinNTConstants.CFG_CALL_TARGET_PROCESSED,
        /// <inheritdoc cref="WinNTConstants.CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID"/>
        CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = WinNTConstants.CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID,
    }
}
