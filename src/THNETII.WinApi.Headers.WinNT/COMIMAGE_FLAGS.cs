using System;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>COM+ Header entry point flags.</summary>
    [Flags]
    public enum COMIMAGE_FLAGS : int
    {
        COMIMAGE_FLAGS_ILONLY = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_ILONLY,
        COMIMAGE_FLAGS_32BITREQUIRED = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITREQUIRED,
        COMIMAGE_FLAGS_IL_LIBRARY = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_IL_LIBRARY,
        COMIMAGE_FLAGS_STRONGNAMESIGNED = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_STRONGNAMESIGNED,
        COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_NATIVE_ENTRYPOINT,
        COMIMAGE_FLAGS_TRACKDEBUGDATA = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_TRACKDEBUGDATA,
        COMIMAGE_FLAGS_32BITPREFERRED = ReplacesCorHdrNumericDefines.COMIMAGE_FLAGS_32BITPREFERRED,
    }
}
