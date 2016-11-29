namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum IMAGE_DEBUG_TYPE : int
    {
        /// <summary>Unknown value, ignored by all tools.</summary>
        IMAGE_DEBUG_TYPE_UNKNOWN = 0,
        /// <summary>COFF debugging information (line numbers, symbol table, and string table). This type of debugging information is also pointed to by fields in the file headers.</summary>
        IMAGE_DEBUG_TYPE_COFF = 1,
        /// <summary>CodeView debugging information. The format of the data block is described by the CodeView 4.0 specification.</summary>
        IMAGE_DEBUG_TYPE_CODEVIEW = 2,
        /// <summary>Frame pointer omission (FPO) information. This information tells the debugger how to interpret nonstandard stack frames, which use the EBP register for a purpose other than as a frame pointer.</summary>
        IMAGE_DEBUG_TYPE_FPO = 3,
        /// <summary>Miscellaneous information.</summary>
        IMAGE_DEBUG_TYPE_MISC = 4,
        /// <summary>Exception information.</summary>
        IMAGE_DEBUG_TYPE_EXCEPTION = 5,
        /// <summary>Fixup information.</summary>
        IMAGE_DEBUG_TYPE_FIXUP = 6,
        IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7,
        IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8,
        /// <summary>Borland debugging information.</summary>
        IMAGE_DEBUG_TYPE_BORLAND = 9,
        IMAGE_DEBUG_TYPE_RESERVED10 = 10,
        IMAGE_DEBUG_TYPE_CLSID = 11,
        IMAGE_DEBUG_TYPE_VC_FEATURE = 12,
        IMAGE_DEBUG_TYPE_POGO = 13,
        IMAGE_DEBUG_TYPE_ILTCG = 14,
        IMAGE_DEBUG_TYPE_MPX = 15,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
