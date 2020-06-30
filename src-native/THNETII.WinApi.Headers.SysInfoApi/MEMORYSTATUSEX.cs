using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.SysInfoApi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\sysinfoapi.h, line 72
    /// <summary>
    /// Contains information about the current state of both physical and virtual memory, including extended memory. The <see cref="GlobalMemoryStatusEx"/> function stores information in this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/ns-sysinfoapi-memorystatusex">MEMORYSTATUSEX structure</a></para>
    /// </remarks>
    /// <seealso cref="GlobalMemoryStatusEx"/>
    /// <seealso href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/aa965225">Memory Performance Information</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUSEX
    {
        public static readonly int SizeOf = SizeOf<MEMORYSTATUSEX>.Bytes;

        /// <summary>
        /// The size of the structure, in bytes. You must set this member to <see cref="SizeOf"/> before calling <see cref="GlobalMemoryStatusEx"/>.
        /// </summary>
        public int dwLength;
        /// <summary>
        /// A number between 0 and 100 that specifies the approximate percentage of physical memory that is in use (0 indicates no memory use and 100 indicates full memory use).
        /// </summary>
        public int dwMemoryLoad;
        /// <summary>
        /// The approximate percentage of physical memory that is in use.
        /// </summary>
        public double MemoryLoadPercentage
        {
            get => dwMemoryLoad / 100.0;
            set => dwMemoryLoad = (int)(value * 100.0);
        }
        /// <summary>
        /// The amount of actual physical memory, in bytes.
        /// </summary>
        public ulong ullTotalPhys;
        /// <summary>
        /// The amount of physical memory currently available, in bytes. This is the amount of physical memory that can be immediately reused without having to write its contents to disk first. It is the sum of the size of the standby, free, and zero lists.
        /// </summary>
        public ulong ullAvailPhys;
        /// <summary>
        /// The current committed memory limit for the system or the current process, whichever is smaller, in bytes. To get the system-wide committed memory limit, call <see cref="GetPerformanceInfo"/>.
        /// </summary>
        public ulong ullTotalPageFile;
        /// <summary>
        /// The maximum amount of memory the current process can commit, in bytes. This value is equal to or smaller than the system-wide available commit value. To calculate the system-wide available commit value, call <see cref="GetPerformanceInfo"/> and subtract the value of <see cref="CommitTotal"/> from the value of <see cref="CommitLimit"/>.
        /// </summary>
        public ulong ullAvailPageFile;
        /// <summary>
        /// The size of the user-mode portion of the virtual address space of the calling process, in bytes. This value depends on the type of process, the type of processor, and the configuration of the operating system. For example, this value is approximately 2 GB for most 32-bit processes on an x86 processor and approximately 3 GB for 32-bit processes that are large address aware running on a system with <a href="https://docs.microsoft.com/windows/desktop/Memory/4-gigabyte-tuning">4-gigabyte tuning</a> enabled.
        /// </summary>
        public ulong ullTotalVirtual;
        /// <summary>
        /// The amount of unreserved and uncommitted memory currently in the user-mode portion of the virtual address space of the calling process, in bytes.
        /// </summary>
        public ulong ullAvailVirtual;
        /// <summary>
        /// Reserved. This value is always <c>0</c> (zero).
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ulong ullAvailExtendedVirtual;

    }
}
