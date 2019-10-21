using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.MinWinBase;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.FileApi
{
    using static NativeLibraryNames;

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
    }
}
