using System;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Flag defintions for <see cref="NtFlushBuffersFileEx"/>
    /// </summary>
    [Flags]
    public enum FLUSH_FLAGS : int
    {
        /// <summary>
        /// If set, this operation will write the data for the given file from the
        /// Windows in-memory cache.  This will NOT commit any associated metadata
        /// changes.  This will NOT send a SYNC to the storage device to flush its
        /// cache.  Not supported on volume handles.  Only supported by the NTFS
        /// filesystem.
        /// </summary>
        FLUSH_FLAGS_FILE_DATA_ONLY = WinNTConstants.FLUSH_FLAGS_FILE_DATA_ONLY,

        /// <summary>
        /// If set, this operation will commit both the data and metadata changes for
        /// the given file from the Windows in-memory cache.  This will NOT send a SYNC
        /// to the storage device to flush its cache.  Not supported on volume handles.
        /// Only supported by the NTFS filesystem.
        /// </summary>
        FLUSH_FLAGS_NO_SYNC = WinNTConstants.FLUSH_FLAGS_NO_SYNC,

        /// <summary>
        /// If set, this operation will write the data for the given file from the
        /// Windows in-memory cache.  It will also try to skip updating the timestamp
        /// as much as possible.  This will send a SYNC to the storage device to flush its
        /// cache.  Not supported on volume or directory handles.  Only supported by the NTFS
        /// filesystem.
        /// </summary>
        FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = WinNTConstants.FLUSH_FLAGS_FILE_DATA_SYNC_ONLY,
    }
}
