namespace THNETII.WinApi.Native.WinNT
{
    public enum IMAGE_DEBUG_TYPE : int
    {
        /// <summary>
        /// Unknown value, ignored by all tools. 
        /// </summary>
        IMAGE_DEBUG_TYPE_UNKNOWN = WinNTConstants.IMAGE_DEBUG_TYPE_UNKNOWN,
        /// <summary>
        /// COFF debugging information (line numbers, symbol table, and string table). This type of debugging information is also pointed to by fields in the file headers. 
        /// </summary>
        IMAGE_DEBUG_TYPE_COFF = WinNTConstants.IMAGE_DEBUG_TYPE_COFF,
        /// <summary>
        /// CodeView debugging information. The format of the data block is described by the CodeView 4.0 specification. 
        /// </summary>
        IMAGE_DEBUG_TYPE_CODEVIEW = WinNTConstants.IMAGE_DEBUG_TYPE_CODEVIEW,
        /// <summary>
        /// Frame pointer omission (FPO) information. This information tells the debugger how to interpret nonstandard stack frames, which use the EBP register for a purpose other than as a frame pointer. 
        /// </summary>
        IMAGE_DEBUG_TYPE_FPO = WinNTConstants.IMAGE_DEBUG_TYPE_FPO,
        /// <summary>
        /// Miscellaneous information. 
        /// </summary>
        IMAGE_DEBUG_TYPE_MISC = WinNTConstants.IMAGE_DEBUG_TYPE_MISC,
        /// <summary>
        /// Exception information. 
        /// </summary>
        IMAGE_DEBUG_TYPE_EXCEPTION = WinNTConstants.IMAGE_DEBUG_TYPE_EXCEPTION,
        /// <summary>
        /// Fixup information. 
        /// </summary>
        IMAGE_DEBUG_TYPE_FIXUP = WinNTConstants.IMAGE_DEBUG_TYPE_FIXUP,
        IMAGE_DEBUG_TYPE_OMAP_TO_SRC = WinNTConstants.IMAGE_DEBUG_TYPE_OMAP_TO_SRC,
        IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = WinNTConstants.IMAGE_DEBUG_TYPE_OMAP_FROM_SRC,
        /// <summary>
        /// Borland debugging information. 
        /// </summary>
        IMAGE_DEBUG_TYPE_BORLAND = WinNTConstants.IMAGE_DEBUG_TYPE_BORLAND,
        IMAGE_DEBUG_TYPE_RESERVED10 = WinNTConstants.IMAGE_DEBUG_TYPE_RESERVED10,
        IMAGE_DEBUG_TYPE_CLSID = WinNTConstants.IMAGE_DEBUG_TYPE_CLSID,
        IMAGE_DEBUG_TYPE_VC_FEATURE = WinNTConstants.IMAGE_DEBUG_TYPE_VC_FEATURE,
        IMAGE_DEBUG_TYPE_POGO = WinNTConstants.IMAGE_DEBUG_TYPE_POGO,
        IMAGE_DEBUG_TYPE_ILTCG = WinNTConstants.IMAGE_DEBUG_TYPE_ILTCG,
        IMAGE_DEBUG_TYPE_MPX = WinNTConstants.IMAGE_DEBUG_TYPE_MPX,
        IMAGE_DEBUG_TYPE_REPRO = WinNTConstants.IMAGE_DEBUG_TYPE_REPRO,
    }
}
