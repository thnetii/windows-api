using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11450
    /// <summary>
    /// The <see cref="QUOTA_LIMITS"/> structure describes the amount of system resources available to a user.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-quota_limits">QUOTA_LIMITS structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct QUOTA_LIMITS
    {
        /// <summary>
        /// <para>Specifies the amount of paged pool memory assigned to the user. The paged pool is an area of system memory (physical memory used by the operating system) for objects that can be written to disk when they are not being used.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public UIntPtr PagedPoolLimit;
        /// <summary>
        /// <para>Specifies the amount of nonpaged pool memory assigned to the user. The nonpaged pool is an area of system memory for objects that cannot be written to disk but must remain in physical memory as long as they are allocated.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public UIntPtr NonPagedPoolLimit;
        /// <summary>
        /// <para>Specifies the minimum set size assigned to the user. The "working set" of a process is the set of memory pages currently visible to the process in physical RAM memory. These pages are present in memory when the application is running and available for an application to use without triggering a page fault.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public UIntPtr MinimumWorkingSetSize;
        /// <summary>
        /// <para>Specifies the maximum set size assigned to the user.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public UIntPtr MaximumWorkingSetSize;
        /// <summary>
        /// <para>Specifies the maximum size, in bytes, of the paging file, which is a reserved space on disk that backs up committed physical memory on the computer.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public UIntPtr PagefileLimit;
        /// <summary>
        /// <para>Indicates the maximum amount of time the process can run.</para>
        /// <para>The value set in this member is not enforced by the LSA.</para>
        /// </summary>
        public long TimeLimit;
    }
}
