using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 73
    //
    //  File System time stamps are represented with the following structure:
    //
    /// <summary>
    /// Contains a 64-bit value representing the number of 100-nanosecond intervals since January 1, 1601 (UTC).
    /// </summary>
    /// <remarks>
    /// <para>To convert a <see cref="FILETIME"/> structure into a time that is easy to display to a user, use the <see cref="FileTimeToSystemTime"/> function.</para>
    /// <para>It is not recommended that you add and subtract values from the FILETIME structure to obtain relative times. Instead, you should cast the <see cref="FILETIME"/> value to a <see cref="long"/> value, perfrom 64-bit arithmetic, and cast the result back to <see cref="FILETIME"/> value.</para>
    /// <para>Not all file systems can record creation and last access time and not all file systems record them in the same manner. For example, on NT FAT, create time has a resolution of 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of 1 day (really, the access date). On NTFS, access time has a resolution of 1 hour. Therefore, the <see cref="GetFileTime"/> function may not return the same file time information set using the <see cref="SetFileTime"/> function. Furthermore, FAT records times on disk in local time. However, NTFS records times on disk in UTC. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</a>.</para>
    /// <para>A function using the <see cref="FILETIME"/> structure can allow for values outside of zero or positive values typically specified by the <see cref="dwLowDateTime"/> and <see cref="dwHighDateTime"/> members. For example, the <see cref="SetFileTime"/> function uses <c>0xFFFFFFFF</c> to specify that a file's previous access time should be preserved. For more information, see the topic for the function you are calling.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-filetime">FILETIME structure</a></para>
    /// </remarks>
    /// <seealso cref="CompareFileTime"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</seealso>
    /// <seealso cref="FileTimeToSystemTime"/>
    /// <seealso cref="GetFileTime"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME : IEquatable<FILETIME>, IComparable<FILETIME>
    {
        /// <summary>
        /// The low-order part of the file time.
        /// </summary>
        public int dwLowDateTime;
        /// <summary>
        /// The high-order part of the file time.
        /// </summary>
        public int dwHighDateTime;

        public long AsInt64() =>
            (dwLowDateTime & 0x00_00_00_00_FF_FF_FF_FF) |
            (dwHighDateTime & unchecked((long)0xFF_FF_FF_FF_00_00_00_00));

        public static FILETIME FromInt64(long value) => new FILETIME(value);

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case long int64:
                    return Equals(int64);
                case FILETIME ft:
                    return Equals(ft);
                case null:
                default:
                    return false;
            }
        }

        public override int GetHashCode() => AsInt64().GetHashCode();

        public bool Equals(FILETIME other) => AsInt64().Equals(other.AsInt64());

        public int CompareTo(FILETIME other) => AsInt64().CompareTo(other.AsInt64());

        [SuppressMessage("Usage", "CA2225: Operator overloads have named alternates", Justification = nameof(AsInt64))]
        public static explicit operator long(FILETIME ft) => ft.AsInt64();

        public static explicit operator FILETIME(long value) => FromInt64(value);

        public FILETIME(long value) : this()
        {
            dwLowDateTime = (int)value;
            dwHighDateTime = (int)(value >> 32);
        }

        public static bool operator ==(FILETIME left, FILETIME right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(FILETIME left, FILETIME right)
        {
            return !(left == right);
        }

        public static bool operator <(FILETIME left, FILETIME right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(FILETIME left, FILETIME right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(FILETIME left, FILETIME right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(FILETIME left, FILETIME right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
