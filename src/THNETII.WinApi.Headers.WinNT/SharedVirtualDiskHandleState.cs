using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13455
    [Flags]
    public enum SharedVirtualDiskHandleState
    {
        /// <summary>
        /// The file handle is not related to a shared virtual disk.
        /// </summary>
        SharedVirtualDiskHandleStateNone = 0,

        /// <summary>
        /// This handle is for the same file where at least one handle is
        /// accessing the file in shared mode.
        /// </summary>
        SharedVirtualDiskHandleStateFileShared = 1,

        /// <summary>
        /// This handle is currently being used to access a shared
        /// virtual disk.
        /// </summary>
        SharedVirtualDiskHandleStateHandleShared = 3
    }

    public static class SharedVirtualDiskHandleStateExtensions
    {
        /// <summary>
        /// Determines if the provided virtual disk handle state, from <see cref="SHARED_VIRTUAL_DISK_SUPPORT"/>,
        /// indicates that the target virtual disk file is opened in shared mode.
        /// </summary>
        public static bool IsVirtualDiskFileShared(this SharedVirtualDiskHandleState HandleState) =>
            WinNTFunctions.IsVirtualDiskFileShared(HandleState);
    }
}
