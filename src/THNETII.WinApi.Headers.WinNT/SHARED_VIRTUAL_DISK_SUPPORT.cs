using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13475
    /// <summary>
    /// Response to <strong>FSCTL_QUERY_SHARED_VIRTUAL_DISK_SUPPORT</strong> that indicates the level
    /// of support for shared virtual disks on the target file system.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SHARED_VIRTUAL_DISK_SUPPORT
    {
        /// <summary>
        /// One or more of the <see cref="SharedVirtualDiskSupportType"/> flags that indicate the
        /// level of shared virtual disk support on this file system.
        /// </summary>
        public SharedVirtualDiskSupportType SharedVirtualDiskSupport;

        /// <summary>
        /// The state of the current shared virtual disk handle. This is one or more of the
        /// <see cref="SharedVirtualDiskHandleState"/> flags.
        /// </summary>
        public SharedVirtualDiskHandleState HandleState;
    }
}
