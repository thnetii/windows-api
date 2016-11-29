namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>DllCharacteristics Entries</summary>
    public enum IMAGE_DLLCHARACTERISTICS : short
    {
        /// <summary>Reserved.</summary>
        IMAGE_LIBRARY_PROCESS_INIT = 0x0001,
        /// <summary>Reserved.</summary>
        IMAGE_LIBRARY_PROCESS_TERM = 0x0002,
        /// <summary>Reserved.</summary>
        IMAGE_LIBRARY_THREAD_INIT = 0x0004,
        /// <summary>Reserved.</summary>
        IMAGE_LIBRARY_THREAD_TERM = 0x0008,
        /// <summary>Image can handle a high entropy 64-bit virtual address space.</summary>
        IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = 0x0020,
        /// <summary>DLL can move.</summary>
        IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 0x0040,
        /// <summary>Code Integrity Image</summary>
        IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 0x0080,
        /// <summary>Image is NX compatible</summary>
        IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 0x0100,
        /// <summary>Image understands isolation and doesn't want it</summary>
        IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200,
        /// <summary>Image does not use SEH.  No SE handler may reside in this image</summary>
        IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400,
        /// <summary>Do not bind this image.</summary>
        IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800,
        /// <summary>Image should execute in an AppContainer</summary>
        IMAGE_DLLCHARACTERISTICS_APPCONTAINER = 0x1000,
        /// <summary>Driver uses WDM model</summary>
        IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000,
        /// <summary>Image supports Control Flow Guard.</summary>
        IMAGE_DLLCHARACTERISTICS_GUARD_CF = 0x4000,
        /// <summary>The image is terminal server aware.</summary>
        IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = unchecked((short)0x8000),
    }
}
