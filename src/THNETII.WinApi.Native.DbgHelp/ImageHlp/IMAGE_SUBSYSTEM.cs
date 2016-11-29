namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    /// <summary>Subsystem Values</summary>
    public enum IMAGE_SUBSYSTEM : short
    {
        /// <summary>Unknown subsystem.</summary>
        IMAGE_SUBSYSTEM_UNKNOWN = 0,
        /// <summary>Image doesn't require a subsystem.</summary>
        IMAGE_SUBSYSTEM_NATIVE = 1,
        /// <summary>Image runs in the Windows GUI subsystem.</summary>
        IMAGE_SUBSYSTEM_WINDOWS_GUI = 2,
        /// <summary>Image runs in the Windows character subsystem.</summary>
        IMAGE_SUBSYSTEM_WINDOWS_CUI = 3,
        /// <summary>image runs in the OS/2 character subsystem.</summary>
        IMAGE_SUBSYSTEM_OS2_CUI = 5,
        /// <summary>image runs in the Posix character subsystem.</summary>
        IMAGE_SUBSYSTEM_POSIX_CUI = 7,
        /// <summary>image is a native Win9x driver.</summary>
        IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8,
        /// <summary>Image runs in the Windows CE subsystem.</summary>
        IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_EFI_APPLICATION = 10,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_EFI_ROM = 13,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_XBOX = 14,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16,
        /// <summary></summary>
        IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = 17,
    }
}