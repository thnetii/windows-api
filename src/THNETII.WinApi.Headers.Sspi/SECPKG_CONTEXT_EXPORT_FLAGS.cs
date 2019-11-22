using System;

namespace THNETII.WinApi.Native.Sspi
{
    /// <summary>
    /// Flags for <see cref="ExportSecurityContext"/>
    /// </summary>
    [Flags]
    public enum SECPKG_CONTEXT_EXPORT_FLAGS : int
    {
        /// <summary>New context is reset to initial state</summary>
        SECPKG_CONTEXT_EXPORT_RESET_NEW = SspiConstants.SECPKG_CONTEXT_EXPORT_RESET_NEW,
        /// <summary>Old context is deleted during export</summary>
        SECPKG_CONTEXT_EXPORT_DELETE_OLD = SspiConstants.SECPKG_CONTEXT_EXPORT_DELETE_OLD,
        // This is only valid in W2K3SP1 and greater
        /// <summary>Context is to be transferred to the kernel</summary>
        SECPKG_CONTEXT_EXPORT_TO_KERNEL = SspiConstants.SECPKG_CONTEXT_EXPORT_TO_KERNEL,
    }
}
