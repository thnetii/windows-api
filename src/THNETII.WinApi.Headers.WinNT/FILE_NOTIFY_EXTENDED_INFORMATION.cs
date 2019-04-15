using System;
using System.IO;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12971
    /// <summary>
    /// Describes the changes found by the <see cref="ReadDirectoryChangesExW"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-file_notify_extended_information">FILE_NOTIFY_EXTENDED_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="ReadDirectoryChangesExW"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_NOTIFY_EXTENDED_INFORMATION
    {
        /// <summary>
        /// The number of bytes that must be skipped to get to the next record. A value of zero indicates that this is the last record.
        /// </summary>
        public int NextEntryOffset;
        /// <summary>
        /// The type of change that has occurred.
        /// </summary>
        public FILE_ACTION_TYPE Action;
        internal long CreationTimeField;
        /// <summary>
        /// The date and time that the directory or file was created and added to the file system.
        /// </summary>
        public DateTime CreationTime
        {
            get => DateTime.FromFileTime(CreationTimeField);
            set => CreationTimeField = value.ToFileTime();
        }
        internal long LastModificationTimeField;
        /// <summary>
        /// The date and time that the content of the directory or file was last modified in the file system.
        /// </summary>
        public DateTime LastModificationTime
        {
            get => DateTime.FromFileTime(LastModificationTimeField);
            set => LastModificationTimeField = value.ToFileTime();
        }
        internal long LastChangeTimeField;
        /// <summary>
        /// The date and time that the metadata or content of the directory or file was last changed in the file system.
        /// </summary>
        public DateTime LastChangeTime
        {
            get => DateTime.FromFileTime(LastChangeTimeField);
            set => LastChangeTimeField = value.ToFileTime();
        }
        internal long LastAccessTimeField;
        /// <summary>
        /// The date and time the directory or file was last accessed in the file system.
        /// </summary>
        public DateTime LastAccessTime
        {
            get => DateTime.FromFileTime(LastAccessTimeField);
            set => LastAccessTimeField = value.ToFileTime();
        }
        /// <summary>
        /// The allocated size of the file, in bytes.
        /// </summary>
        public long AllocatedLength;
        /// <summary>
        /// The new size of the directory or file in bytes, or the old size if the size is unchanged.
        /// </summary>
        public long FileSize;
        internal int FileAttributesField;
        /// <summary>
        /// The attributes of the directory or file.
        /// </summary>
        public FileAttributes FileAttributes
        {
            get => (FileAttributes)FileAttributesField;
            set => FileAttributesField = (int)value;
        }
        /// <summary>
        /// The identifier tag of a reparse point for the directory or file.
        /// </summary>
        public int ReparsePointTag;
        /// <summary>
        /// The identifier of the directory or file.
        /// </summary>
        public long FileId;
        /// <summary>
        /// The identifier of the parent directory for the file.
        /// </summary>
        public long ParentFileId;
        /// <summary>
        /// The size of the file name portion of the record, in bytes.
        /// </summary>
        public int FileNameLength;
        internal char FileNameField;
        /// <summary>
        /// <para>A variable-length field that contains the file name relative to the directory handle.</para>
        /// <para>If there is both a short and long name for the file, the function will return one of these names, but it is unspecified which one.</para>
        /// </summary>
        public Span<char> FileName => SpanOverRef.GetSpan(ref FileNameField, FileNameLength / 2);
    }
}
