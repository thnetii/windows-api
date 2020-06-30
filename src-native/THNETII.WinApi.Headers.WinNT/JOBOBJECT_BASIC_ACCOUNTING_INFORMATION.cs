using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11699
    /// <summary>
    /// Contains basic accounting information for a job object.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_accounting_information">JOBOBJECT_BASIC_ACCOUNTING_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
    {
        /// <summary>
        /// The total amount of user-mode execution time for all active processes associated with the job, as well as all terminated processes no longer associated with the job, in 100-nanosecond ticks.
        /// </summary>
        public long TotalUserTime;
        /// <summary>
        /// The total amount of kernel-mode execution time for all active processes associated with the job, as well as all terminated processes no longer associated with the job, in 100-nanosecond ticks.
        /// </summary>
        public long TotalKernelTime;
        /// <summary>
        /// <para>The total amount of user-mode execution time for all active processes associated with the job (as well as all terminated processes no longer associated with the job) since the last call that set a per-job user-mode time limit, in 100-nanosecond ticks.</para>
        /// <para>This member is set to 0 on creation of the job, and each time a per-job user-mode time limit is established.</para>
        /// </summary>
        public long ThisPeriodTotalUserTime;
        /// <summary>
        /// <para>The total amount of kernel-mode execution time for all active processes associated with the job (as well as all terminated processes no longer associated with the job) since the last call that set a per-job kernel-mode time limit, in 100-nanosecond ticks.</para>
        /// <para>This member is set to zero on creation of the job, and each time a per-job kernel-mode time limit is established.</para>
        /// </summary>
        public long ThisPeriodTotalKernelTime;
        /// <summary>
        /// The total number of page faults encountered by all active processes associated with the job, as well as all terminated processes no longer associated with the job.
        /// </summary>
        public int TotalPageFaultCount;
        /// <summary>
        /// The total number of processes associated with the job during its lifetime, including those that have terminated. For example, when a process is associated with a job, but the association fails because of a limit violation, this value is incremented.
        /// </summary>
        public int TotalProcesses;
        /// <summary>
        /// The total number of processes currently associated with the job. When a process is associated with a job, but the association fails because of a limit violation, this value is temporarily incremented. When the terminated process exits and all references to the process are released, this value is decremented.
        /// </summary>
        public int ActiveProcesses;
        /// <summary>
        /// The total number of processes terminated because of a limit violation.
        /// </summary>
        public int TotalTerminatedProcesses;
    }
}
