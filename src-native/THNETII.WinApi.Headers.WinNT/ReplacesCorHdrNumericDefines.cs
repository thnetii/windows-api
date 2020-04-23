namespace THNETII.WinApi.Native.WinNT
{
    public enum ReplacesCorHdrNumericDefines
    {
        // COM+ Header entry point flags.
        COMIMAGE_FLAGS_ILONLY = 0x00000001,
        COMIMAGE_FLAGS_32BITREQUIRED = 0x00000002,
        COMIMAGE_FLAGS_IL_LIBRARY = 0x00000004,
        COMIMAGE_FLAGS_STRONGNAMESIGNED = 0x00000008,
        COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 0x00000010,
        COMIMAGE_FLAGS_TRACKDEBUGDATA = 0x00010000,
        COMIMAGE_FLAGS_32BITPREFERRED = 0x00020000,

        // Version flags for image.
        COR_VERSION_MAJOR_V2 = 2,
        COR_VERSION_MAJOR = COR_VERSION_MAJOR_V2,
        COR_VERSION_MINOR = 5,
        COR_DELETED_NAME_LENGTH = 8,
        COR_VTABLEGAP_NAME_LENGTH = 8,

        // Maximum size of a NativeType descriptor.
        NATIVE_TYPE_MAX_CB = 1,
        COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 0xFF,

        // #defines for the MIH FLAGS
        IMAGE_COR_MIH_METHODRVA = 0x01,
        IMAGE_COR_MIH_EHRVA = 0x02,
        IMAGE_COR_MIH_BASICBLOCK = 0x08,

        // V-table constants
        /// <summary>V-table slots are 32-bits in size.</summary>
        COR_VTABLE_32BIT = 0x01,
        /// <summary>V-table slots are 64-bits in size.</summary>
        COR_VTABLE_64BIT = 0x02,
        /// <summary>If set, transition from unmanaged.</summary>
        COR_VTABLE_FROM_UNMANAGED = 0x04,
        /// <summary>If set, transition from unmanaged with keeping the current appdomain.</summary>
        COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 0x08,
        /// <summary>Call most derived method described by</summary>
        COR_VTABLE_CALL_MOST_DERIVED = 0x10,

        // EATJ constants
        /// <summary>Size of a jump thunk reserved range.</summary>
        IMAGE_COR_EATJ_THUNK_SIZE = 32,

        // Max name lengths
        //@todo: Change to unlimited name lengths.
        MAX_CLASS_NAME = 1024,
        MAX_PACKAGE_NAME = 1024,
    }
}
