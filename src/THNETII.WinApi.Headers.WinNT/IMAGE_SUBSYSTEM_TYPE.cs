using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Subsystem Values
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum IMAGE_SUBSYSTEM_TYPE : short
    {
        /// <summary>
        /// Unknown subsystem. 
        /// </summary>
        IMAGE_SUBSYSTEM_UNKNOWN = WinNTConstants.IMAGE_SUBSYSTEM_UNKNOWN,
        /// <summary>
        /// No subsystem required (device drivers and native system processes).
        /// </summary>
        IMAGE_SUBSYSTEM_NATIVE = WinNTConstants.IMAGE_SUBSYSTEM_NATIVE,
        /// <summary>
        /// Windows graphical user interface (GUI) subsystem.
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_GUI = WinNTConstants.IMAGE_SUBSYSTEM_WINDOWS_GUI,
        /// <summary>
        /// Windows character-mode user interface (CUI) subsystem.
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_CUI = WinNTConstants.IMAGE_SUBSYSTEM_WINDOWS_CUI,
        /// <summary>
        /// OS/2 CUI subsystem.
        /// </summary>
        IMAGE_SUBSYSTEM_OS2_CUI = WinNTConstants.IMAGE_SUBSYSTEM_OS2_CUI,
        /// <summary>
        /// POSIX CUI subsystem.
        /// </summary>
        IMAGE_SUBSYSTEM_POSIX_CUI = WinNTConstants.IMAGE_SUBSYSTEM_POSIX_CUI,
        IMAGE_SUBSYSTEM_NATIVE_WINDOWS = WinNTConstants.IMAGE_SUBSYSTEM_NATIVE_WINDOWS,
        /// <summary>
        /// Windows CE system. 
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = WinNTConstants.IMAGE_SUBSYSTEM_WINDOWS_CE_GUI,
        /// <summary>
        /// Extensible Firmware Interface (EFI) application. 
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_APPLICATION = WinNTConstants.IMAGE_SUBSYSTEM_EFI_APPLICATION,
        /// <summary>
        /// EFI driver with boot services. 
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = WinNTConstants.IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER,
        /// <summary>
        /// EFI driver with run-time services. 
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = WinNTConstants.IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER,
        /// <summary>
        /// EFI ROM image. 
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_ROM = WinNTConstants.IMAGE_SUBSYSTEM_EFI_ROM,
        /// <summary>
        /// Xbox system. 
        /// </summary>
        IMAGE_SUBSYSTEM_XBOX = WinNTConstants.IMAGE_SUBSYSTEM_XBOX,
        /// <summary>
        /// Boot application. 
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = WinNTConstants.IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION,
        IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = WinNTConstants.IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG,
    }
}
