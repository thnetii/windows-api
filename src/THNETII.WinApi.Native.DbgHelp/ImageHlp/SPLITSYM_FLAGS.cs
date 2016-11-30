using System;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    [Flags]
    public enum SPLITSYM_FLAGS : int
    {
        /// <summary>
        /// This strips off the private CodeView symbolic information when generating the symbol file.
        /// Used for creating .dbg files that ship
        /// as part of the product.
        /// </summary>
        SPLITSYM_REMOVE_PRIVATE = 0x00000001,
        /// <summary>
        /// Usually, an image with the symbols split off will still contain a MISC debug directory with the name of the symbol file. Therefore, the debugger can still find the symbols. Using this flag removes this link. The end result is similar to using the <strong>-debug:none</strong> switch on the Microsoft linker.
        /// </summary>
        SPLITSYM_EXTRACT_ALL = 0x00000002,
        /// <summary>
        /// The symbol file path contains an alternate path to locate the .pdb file.
        /// </summary>
        SPLITSYM_SYMBOLPATH_IS_SRC = 0x00000004
    }
}
