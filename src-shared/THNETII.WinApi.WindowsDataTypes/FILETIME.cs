using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\minwindef.h, line 267
    /// <summary>
    /// Contains a 64-bit value representing the number of 100-nanosecond intervals since January 1, 1601 (UTC).
    /// </summary>
    /// <remarks>
    /// <para>To convert a <see cref="FILETIME"/> structure into a time that is easy to display to a user, use the <see cref="FileTimeToSystemTime"/> function.</para>
    /// <para>It is not recommended that you add and subtract values from the <see cref="FILETIME"/> structure to obtain relative times. Instead, you should copy the low- and high-order parts of the file time to a <see cref="ULARGE_INTEGER"/> structure, perform 64-bit arithmetic on the <see cref="ULARGE_INTEGER.QuadPart"/> member, and copy the <see cref="ULARGE_INTEGER.LowPart"/> and <see cref="ULARGE_INTEGER.HighPart"/> members into the <see cref="FILETIME"/> structure.</para>
    /// <para>Do not cast a pointer to a <see cref="FILETIME"/> structure to either a <see cref="ULARGE_INTEGER"/> pointer or <see cref="ulong"/> value because it can cause alignment faults on 64-bit Windows.</para>
    /// <para>Not all file systems can record creation and last access time and not all file systems record them in the same manner. For example, on NT FAT, create time has a resolution of 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of 1 day (really, the access date). On NTFS, access time has a resolution of 1 hour. Therefore, the <see cref="GetFileTime"/> function may not return the same file time information set using the <see cref="SetFileTime"/> function. Furthermore, FAT records times on disk in local time. However, NTFS records times on disk in UTC. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</a>.</para>
    /// <para>A function using the <see cref="FILETIME"/> structure can allow for values outside of zero or positive values typically specified by the <see cref="dwLowDateTime"/> and <see cref="dwHighDateTime"/> members. For example, the <see cref="SetFileTime"/> function uses <c>0xFFFFFFFF</c> to specify that a file's previous access time should be preserved. For more information, see the topic for the function you are calling.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-filetime">FILETIME structure</a></para>
    /// </remarks>
    /// <seealso cref="CompareFileTime"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</seealso>
    /// <seealso cref="FileTimeToSystemTime"/>
    /// <seealso cref="GetFileTime"/>
    /// <seealso cref="ULARGE_INTEGER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        /// <summary>
        /// The low-order part of the file time.
        /// </summary>
        public uint dwLowDateTime;
        /// <summary>
        /// The high-order part of the file time.
        /// </summary>
        public int dwHighDateTime;
        /// <summary>
        /// The 64-bit part of the file time.
        /// </summary>
        public long QuadDateTime
        {
            get
            {
                var li = new LARGE_INTEGER
                {
                    LowPart = dwLowDateTime,
                    HighPart = dwHighDateTime
                };
                return li.QuadPart;
            }
            set
            {
                var li = new LARGE_INTEGER { QuadPart = value };
                (dwLowDateTime, dwHighDateTime) = (li.LowPart, li.HighPart);
            }
        }
    }
}
