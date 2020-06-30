using System;
using System.IO;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.MinWinDef;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static MinWinDefConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 119
    /// <summary>
    /// Contains information about the file that is found by the <see cref="FindFirstFile"/>, <see cref="FindFirstFileEx"/>, or <see cref="FindNextFile"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-win32_find_dataw">WIN32_FIND_DATAW structure</a></para>
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
    public unsafe struct WIN32_FIND_DATAW
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
        internal fixed char cFileName[MAX_PATH];
        /// <summary>
        /// The name of the file.
        /// </summary>
        public Span<char> FileName
        {
            get
            {
                fixed (char* ptr = cFileName)
                    return new Span<char>(ptr, MAX_PATH);
            }
        }
        internal fixed char cAlternateFileName[14];
        /// <summary>
        /// An alternative name for the file.
        /// <para>This name is in the classic 8.3 file name format.</para>
        /// </summary>
        public Span<char> AlternateFileName
        {
            get
            {
                fixed (char* ptr = cAlternateFileName)
                    return new Span<char>(ptr, 14);
            }
        }
    }
}
