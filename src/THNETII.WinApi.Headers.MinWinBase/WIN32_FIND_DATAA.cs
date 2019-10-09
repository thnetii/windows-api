using System.IO;
using System.Runtime.InteropServices;

using THNETII.WinApi.Helpers;
using THNETII.WinApi.Native.MinWinDef;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static MinWinDefConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 102
    /// <summary>
    /// Contains information about the file that is found by the <see cref="FindFirstFile"/>, <see cref="FindFirstFileEx"/>, or <see cref="FindNextFile"/> function.
    /// </summary>
    /// <remarks>
    /// <para>If a file has a long file name, the complete name appears in the <see cref="FileName"/> member, and the 8.3 format truncated version of the name appears in the <see cref="AlternateFileName"/> member. Otherwise, <see cref="AlternateFileName"/> is empty. If the <see cref="FindFirstFileEx"/> function was called with a value of <see cref="FindExInfoBasic"/> in the <em>fInfoLevelId</em> parameter, the <see cref="AlternateFileName"/> member will always contain an empty string value. This remains true for all subsequent calls to the <see cref="FindNextFile"/> function. As an alternative method of retrieving the 8.3 format version of a file name, you can use the <see cref="GetShortPathName"/> function. For more information about file names, see <a href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">File Names, Paths, and Namespaces</a>.</para>
    /// <para>Not all file systems can record creation and last access times, and not all file systems record them in the same manner. For example, on the FAT file system, create time has a resolution of 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of 1 day. The NTFS file system delays updates to the last access time for a file by up to 1 hour after the last access. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-win32_find_dataa">WIN32_FIND_DATAA structure</a></para>
    /// </remarks>
    /// <seealso cref="FILETIME"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/file-attribute-constants">File Attribute Constants</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">File Names, Paths, and Namespaces</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</seealso>
    /// <seealso cref="FileTimeToLocalFileTime"/>
    /// <seealso cref="FileTimeToSystemTime"/>
    /// <seealso cref="FindFirstFile"/>
    /// <seealso cref="FindFirstFileEx"/>
    /// <seealso cref="FindNextFile"/>
    /// <seealso cref="GetShortPathName"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WIN32_FIND_DATAA
    {
        internal int dwFileAttributes;
        /// <summary>
        /// <para>The file attributes of a file.</para>
        /// <para>The <see cref="F:THNETII.WinApi.Native.WinNT.WinNTRuntimeConstants.FILE_ATTRIBUTE_SPARSE_FILE"/> attribute on the file is set if any of the streams of the file have ever been sparse.</para>
        /// </summary>
        public FileAttributes FileAttributes
        {
            get => (FileAttributes)dwFileAttributes;
            set => dwFileAttributes = (int)value;
        }
        /// <summary>
        /// A <see cref="FILETIME"/> structure that specifies when a file or directory was created.
        /// <para>If the underlying file system does not support creation time, this member is zero.</para>
        /// </summary>
        public FILETIME ftCreationTime;
        /// <summary>
        /// A <see cref="FILETIME"/> structure.
        /// <para>For a file, the structure specifies when the file was last read from, written to, or for executable files, run.</para>
        /// <para>For a directory, the structure specifies when the directory is created. If the underlying file system does not support last access time, this member is zero.</para>
        /// <para>On the FAT file system, the specified date for both files and directories is correct, but the time of day is always set to midnight.</para>
        /// </summary>
        public FILETIME ftLastAccessTime;
        /// <summary>
        /// A <see cref="FILETIME"/> structure.
        /// <para>For a file, the structure specifies when the file was last written to, truncated, or overwritten, for example, when <see cref="WriteFile"/> or <see cref="SetEndOfFile"/> are used. The date and time are not updated when file attributes or security descriptors are changed.</para>
        /// <para>For a directory, the structure specifies when the directory is created. If the underlying file system does not support last write time, this member is zero.</para>
        /// </summary>
        public FILETIME ftLastWriteTime;
        internal int nFileSizeHigh;
        internal int nFileSizeLow;
        /// <summary>The file size, in bytes.</summary>
        public long FileSize
        {
            get => (nFileSizeHigh << 32) | (nFileSizeLow);
            set => (nFileSizeHigh, nFileSizeLow) =
                ((int)(value >> 32), (int)(value & int.MaxValue));
        }
        /// <summary>
        /// If the <see cref="dwFileAttributes"/> member includes the <see cref="F:THNETII.WinApi.Native.WinNT.WinNTRuntimeConstants.FILE_ATTRIBUTE_REPARSE_POINT"/> attribute, this member specifies the reparse point tag.
        /// <para>Otherwise, this value is undefined and should not be used.</para>
        /// <para>For more information see <a href="https://docs.microsoft.com/windows/desktop/FileIO/reparse-point-tags">Reparse Point Tags</a>.</para>
        /// </summary>
        public int dwReserved0;
        /// <summary>Reserved for future use.</summary>
        public int dwReserved1;
        internal fixed byte cFileName[MAX_PATH];
        /// <summary>
        /// The name of the file.
        /// </summary>
        public string FileName
        {
            get
            {
                fixed (byte* ptr = cFileName)
                    return FixedStringBuffer.MarshalAnsiString(ptr, MAX_PATH);
            }
            set
            {
                fixed (byte* ptr = cFileName)
                    FixedStringBuffer.MarshalAnsiBytes(value, ptr, MAX_PATH);
            }
        }
        internal fixed byte cAlternateFileName[14];
        /// <summary>
        /// An alternative name for the file.
        /// <para>This name is in the classic 8.3 file name format.</para>
        /// </summary>
        public string AlternateFileName
        {
            get
            {
                fixed (byte* ptr = cAlternateFileName)
                    return FixedStringBuffer.MarshalAnsiString(ptr, 14);
            }
            set
            {
                fixed (byte* ptr = cAlternateFileName)
                    FixedStringBuffer.MarshalAnsiBytes(value, ptr, 14);
            }
        }
    }
}
