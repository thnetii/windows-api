using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12963
    /// <summary>
    /// Describes the changes found by the <see cref="ReadDirectoryChangesW"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-file_notify_information">FILE_NOTIFY_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="ReadDirectoryChangesW"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_NOTIFY_INFORMATION
    {
        /// <summary>
        /// The number of bytes that must be skipped to get to the next record. A value of zero indicates that this is the last record.
        /// </summary>
        public int NextEntryOffset;
        /// <summary>
        /// The type of change that has occurred.
        /// </summary>
        public FILE_ACTION_TYPE Action;
        /// <summary>
        /// The size of the file name portion of the record, in bytes. Note that this value does not include the terminating null character.
        /// </summary>
        public int FileNameLength;
        private char FileNameField;
        /// <summary>
        /// A variable-length field that contains the file name relative to the directory handle.
        /// <para>If there is both a short and long name for the file, the function will return one of these names, but it is unspecified which one.</para>
        /// </summary>
        public Span<char> FileName => SpanOverRef.GetSpan(ref FileNameField, FileNameLength / 2);
    }
}
