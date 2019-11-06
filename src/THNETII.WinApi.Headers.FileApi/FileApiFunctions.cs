using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinError;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.FileApi
{
    using static MinWinDefConstants;
    using static NativeLibraryNames;
    using static WinErrorConstants;

    public static class FileApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 47
        #region CompareFileTime function
        /// <summary>
        /// Compares two file times.
        /// </summary>
        /// <param name="lpFileTime1">A read-only reference to a <see cref="FILETIME"/> structure that specifies the first file time.</param>
        /// <param name="lpFileTime2">A read-only reference to a <see cref="FILETIME"/> structure that specifies the second file time.</param>
        /// <returns>
        /// The return value is one of the following values.
        /// <list type="table">
        /// <listheader><term>Return value</term><description>Description</description></listheader>
        /// <item><term><c>-1</c></term><description>First file time is earlier than second file time. </description></item>
        /// <item><term><c>0</c> (zero)</term><description>First file time is equal to second file time.</description></item>
        /// <item><term><c>1</c></term><description>First file time is later than second file time.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/fileapi/nf-fileapi-comparefiletime">CompareFileTime function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="FILETIME"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</seealso>
        /// <seealso cref="GetFileTime"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/time-functions">Time Functions</seealso>
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern int CompareFileTime(
            in FILETIME lpFileTime1,
            in FILETIME lpFileTime2
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 56
        #region CreateDirectoryA function
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryA(
            [In] LPCSTR lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryA(LPCSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectoryA(LPCSTR lpPathName) =>
            CreateDirectoryA(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectoryA(LPCSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectoryA(
            [In] LPCSTR lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryA(LPCSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryA(
            [In, MarshalAs(UnmanagedType.LPStr)] string lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryA(LPCSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectoryA(string lpPathName) =>
            CreateDirectoryA(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectoryA(LPCSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryA) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectoryA(
            [In, MarshalAs(UnmanagedType.LPStr)] string lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 64
        #region CreateDirectoryW function
        /// <summary>
        /// Creates a new directory. If the underlying file system supports security on files and directories, the function applies a specified security descriptor to the new directory.
        /// <para>To specify a template directory, use the <see cref="CreateDirectoryEx"/> function.</para>
        /// <para>To perform this operation as a transacted operation, use the <see cref="CreateDirectoryTransacted"/> function.</para>
        /// </summary>
        /// <param name="lpPathName">
        /// <para>The path of the directory to be created.</para>
        /// <para>For the ANSI version of this function, there is a default string size limit for paths of 248 characters (<see cref="MAX_PATH"/> - enough room for a 8.3 filename). To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\?" to the path. For more information, see <a href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">Naming a File</a></para>
        /// <para>
        /// <note>Starting with Windows 10, version 1607, for the unicode version of this function (<see cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>), you can opt-in to remove the 248 character limitation without prepending "\\?\". The 255 character limit per path segment still applies. See the "Maximum Path Length Limitation" section of <a href="https://docs.microsoft.com/windows/desktop/FileIO/naming-a-file">Naming Files, Paths, and Namespaces</a> for details.</note>
        /// </para>
        /// </param>
        /// <param name="lpSecurityAttributes">
        /// A read-only reference to a <see cref="SECURITY_ATTRIBUTES"/> structure. The <see cref="SECURITY_ATTRIBUTES.lpSecurityDescriptor"/> member of the structure specifies a security descriptor for the new directory. If <paramref name="lpSecurityAttributes"/> is omitted, the directory gets a default security descriptor. The ACLs in the default security descriptor for a directory are inherited from its parent directory.
        /// <para>The target file system must support security on files and directories for this parameter to have an effect. (This is indicated when <see cref="GetVolumeInformation"/> returns <see cref="FS_PERSISTENT_ACLS"/>.)</para>
        /// </param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="GetLastError"/>. Possible errors include the following.
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><see cref="ERROR_ALREADY_EXISTS"/></term><description>The specified directory already exists.</description></item>
        /// <item><term><see cref="ERROR_PATH_NOT_FOUND"/></term><description>One or more intermediate directories do not exist; this function will only create the final directory in the path.</description></item>
        /// </list>
        /// </para>
        /// </returns>
        /// <remarks>
        /// <para>Some file systems, such as the NTFS file system, support compression or encryption for individual files and directories. On volumes formatted for such a file system, a new directory inherits the compression and encryption attributes of its parent directory.</para>
        /// <para>An application can obtain a handle to a directory by calling <see cref="CreateFile"/> with the <see cref="FILE_FLAG_BACKUP_SEMANTICS"/> flag set. For a code example, see <see cref="CreateFile"/>.</para>
        /// <para>To support inheritance functions that query the security descriptor of this object may heuristically determine and report that inheritance is in effect. See <a href="https://docs.microsoft.com/windows/desktop/SecAuthZ/automatic-propagation-of-inheritable-aces">Automatic Propagation of Inheritable ACEs</a> for more information.</para>
        /// <para>
        /// In Windows 8 and Windows Server 2012, this function is supported by the following technologies.
        /// <list type="table">
        /// <listheader><term>Technology</term><description>Supported</description></listheader>
        /// <item><term>Server Message Block (SMB) 3.0 protocol </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 Transparent Failover (TFO) </term><description>Yes</description></item>
        /// <item><term>SMB 3.0 with Scale-out File Shares (SO) </term><description>Yes</description></item>
        /// <item><term>Cluster Shared Volume File System (CsvFS) </term><description>Yes</description></item>
        /// <item><term>Resilient File System (ReFS) </term><description>Yes</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows XP [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows Server 2003 [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/fileapi/nf-fileapi-createdirectoryw">CreateDirectoryW function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CreateDirectoryEx"/>
        /// <seealso cref="CreateDirectoryTransacted"/>
        /// <seealso cref="CreateFile"/>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/creating-and-deleting-directories">Creating and Deleting Directories</seealso>
        /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/directory-management-functions">Directory Management Functions</seealso>
        /// <seealso cref="RemoveDirectory"/>
        /// <seealso cref="SECURITY_ATTRIBUTES"/>
        /// <seealso cref="SECURITY_INFORMATION"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryW(
            [In] LPCWSTR lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectoryW(LPCWSTR lpPathName) =>
            CreateDirectoryW(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectoryW(
            [In] LPCWSTR lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectoryW(string lpPathName) =>
            CreateDirectoryW(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectoryW) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectoryW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 72
        #region CreateDirectory function
        /// <inheritdoc cref="CreateDirectoryW(LPCWSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectory(
            [In] LPCTSTR lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectory(LPCTSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectory(
            [In] LPCTSTR lpPathName
            ) =>
            CreateDirectory(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectory(LPCTSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectory(
            [In] LPCTSTR lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
#if !NETSTANDARD1_3
        /// <inheritdoc cref="CreateDirectory(LPCTSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectory(
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpPathName,
            [In, Optional] in SECURITY_ATTRIBUTES lpSecurityAttributes
            );
        /// <inheritdoc cref="CreateDirectory(LPCTSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        public static bool CreateDirectory(string lpPathName) =>
            CreateDirectory(lpPathName, IntPtr.Zero);
        /// <inheritdoc cref="CreateDirectory(LPCTSTR, in SECURITY_ATTRIBUTES)"/>
        [Obsolete(".NET Applications should not call " + nameof(CreateDirectory) + ". Instead the types in the System.IO namespace should be used.")]
        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateDirectory(
            [In, MarshalAs(UnmanagedType.LPTStr)] string lpPathName,
            [In, Optional] IntPtr lpSecurityAttributes
            );
#endif // !NETSTANDARD1_3
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 116
        #region DefineDosDeviceW function

        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\fileapi.h, line 126
        #region DefineDosDevice function

        #endregion
    }
}
