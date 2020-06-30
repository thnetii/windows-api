using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13427
    /// <summary>
    /// Whether the file system supports shared virtual disks.
    /// </summary>
    [Flags]
    public enum SharedVirtualDiskSupportType
    {
        /// <summary>
        /// Shared virtual disks are not supported.
        /// </summary>
        SharedVirtualDisksUnsupported = 0,

        /// <summary>
        /// Shared virtual disks are supported.
        /// </summary>
        SharedVirtualDisksSupported = 1,

        /// <summary>
        /// The target device supports taking virtual disk
        /// snapshots.
        /// </summary>
        SharedVirtualDiskSnapshotsSupported = 3,

        /// <summary>
        /// The target device supports Continuous Data
        /// Protection (log based) snapshots.
        /// </summary>
        SharedVirtualDiskCDPSnapshotsSupported = 7
    }
}
