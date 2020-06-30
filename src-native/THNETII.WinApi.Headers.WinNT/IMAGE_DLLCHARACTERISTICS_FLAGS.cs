using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>DllCharacteristics Entries</summary>
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_DLLCHARACTERISTICS_FLAGS : short
    {
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        IMAGE_LIBRARY_PROCESS_INIT = WinNTConstants.IMAGE_LIBRARY_PROCESS_INIT,
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        IMAGE_LIBRARY_PROCESS_TERM = WinNTConstants.IMAGE_LIBRARY_PROCESS_TERM,
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        IMAGE_LIBRARY_THREAD_INIT = WinNTConstants.IMAGE_LIBRARY_THREAD_INIT,
        /// <summary>Reserved.</summary>
        [Obsolete("Reserved.")]
        IMAGE_LIBRARY_THREAD_TERM = WinNTConstants.IMAGE_LIBRARY_THREAD_TERM,
        IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = WinNTConstants.IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA,
        /// <summary>
        /// The DLL can be relocated at load time.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = WinNTConstants.IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE,
        /// <summary>
        /// Code integrity checks are forced. If you set this flag and a section contains only uninitialized data, set the <see cref="IMAGE_SECTION_HEADER.PointerToRawData"/> member of <see cref="IMAGE_SECTION_HEADER"/> for that section to zero; otherwise, the image will fail to load because the digital signature cannot be verified.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = WinNTConstants.IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY,
        /// <summary>
        /// The image is compatible with data execution prevention (DEP).
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NX_COMPAT = WinNTConstants.IMAGE_DLLCHARACTERISTICS_NX_COMPAT,
        /// <summary>
        /// The image is isolation aware, but should not be isolated.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = WinNTConstants.IMAGE_DLLCHARACTERISTICS_NO_ISOLATION,
        /// <summary>
        /// The image does not use structured exception handling (SEH). No handlers can be called in this image.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_SEH = WinNTConstants.IMAGE_DLLCHARACTERISTICS_NO_SEH,
        /// <summary>
        /// Do not bind the image. 
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_BIND = WinNTConstants.IMAGE_DLLCHARACTERISTICS_NO_BIND,
        IMAGE_DLLCHARACTERISTICS_APPCONTAINER = WinNTConstants.IMAGE_DLLCHARACTERISTICS_APPCONTAINER,
        /// <summary>
        /// A WDM driver. 
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = WinNTConstants.IMAGE_DLLCHARACTERISTICS_WDM_DRIVER,
        IMAGE_DLLCHARACTERISTICS_GUARD_CF = WinNTConstants.IMAGE_DLLCHARACTERISTICS_GUARD_CF,
        /// <summary>
        /// The image is terminal server aware. 
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = unchecked((short)WinNTConstants.IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE),
    }
}
