using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11710
    /// <summary>
    /// Contains basic limit information for a job object.
    /// </summary>
    /// <remarks>
    /// <para>Processes can still empty their working sets using the <see cref="SetProcessWorkingSetSize"/> function with <c>new UIntPtr(-1)</c>, even when <see cref="JOB_OBJECT_LIMIT_WORKINGSET"/> is used. However, you cannot use <see cref="SetProcessWorkingSetSize"/> change the minimum or maximum working set size of a process in a job object.</para>
    /// <para>The system increments the active process count when you attempt to associate a process with a job. If the limit is exceeded, the system decrements the active process count only when the process terminates and all handles to the process are closed. Therefore, if you have an open handle to a process that has been terminated in such a manner, you cannot associate any new processes until the handle is closed and the active process count is below the limit.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_limit_information">JOBOBJECT_BASIC_LIMIT_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="GetProcessAffinityMask"/>
    /// <seealso cref="JOBOBJECT_END_OF_JOB_TIME_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    /// <seealso cref="SetProcessWorkingSetSize"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_PROCESS_TIME"/>, this member is the per-process user-mode execution time limit, in 100-nanosecond ticks. Otherwise, this member is ignored.</para>
        /// <para>The system periodically checks to determine whether each process associated with the job has accumulated more user-mode time than the set limit. If it has, the process is terminated.</para>
        /// <para>If the job is nested, the effective limit is the most restrictive limit in the job chain.</para>
        /// </summary>
        public long PerProcessUserTimeLimit;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_JOB_TIME"/>, this member is the per-job user-mode execution time limit, in 100-nanosecond ticks. Otherwise, this member is ignored.</para>
        /// <para>The system adds the current time of the processes associated with the job to this limit. For example, if you set this limit to 1 minute, and the job has a process that has accumulated 5 minutes of user-mode time, the limit actually enforced is 6 minutes.</para>
        /// <para>The system periodically checks to determine whether the sum of the user-mode execution time for all processes is greater than this end-of-job limit. If it is, the action specified in the <see cref="EndOfJobTimeAction"/> member of the <see cref="JOBOBJECT_END_OF_JOB_TIME_INFORMATION"/> structure is carried out. By default, all processes are terminated and the status code is set to <see cref="ERROR_NOT_ENOUGH_QUOTA"/>.</para>
        /// </summary>
        public long PerJobUserTimeLimit;
        /// <summary>
        /// The limit flags that are in effect. This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        public JOB_OBJECT_LIMIT_FLAGS LimitFlags;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_WORKINGSET"/>, this member is the minimum working set size in bytes for each process associated with the job. Otherwise, this member is ignored.</para>
        /// <para>If <see cref="MaximumWorkingSetSize"/> is nonzero, <see cref="MinimumWorkingSetSize"/> cannot be zero.</para>
        /// </summary>
        public UIntPtr MinimumWorkingSetSize;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_WORKINGSET"/>, this member is the maximum working set size in bytes for each process associated with the job. Otherwise, this member is ignored.</para>
        /// <para>If <see cref="MinimumWorkingSetSize"/> is nonzero, <see cref="MaximumWorkingSetSize"/> cannot be zero.</para>
        /// </summary>
        public UIntPtr MaximumWorkingSetSize;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_ACTIVE_PROCESS"/>, this member is the active process limit for the job. Otherwise, this member is ignored.</para>
        /// <para>If you try to associate a process with a job, and this causes the active process count to exceed this limit, the process is terminated and the association fails.</para>
        /// </summary>
        public int ActiveProcessLimit;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_AFFINITY"/>, this member is the processor affinity for all processes associated with the job. Otherwise, this member is ignored.</para>
        /// <para>The affinity must be a subset of the system affinity mask obtained by calling the <see cref="GetProcessAffinityMask"/> function. The affinity of each thread is set to this value, but threads are free to subsequently set their affinity, as long as it is a subset of the specified affinity mask. Processes cannot set their own affinity mask.</para>
        /// </summary>
        public UIntPtr Affinity;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_PRIORITY_CLASS"/>, this member is the priority class for all processes associated with the job. Otherwise, this member is ignored.</para>
        /// <para>Processes and threads cannot modify their priority class. The calling process must enable the <see cref="WinNTConstants.SE_INC_BASE_PRIORITY_NAME"/> privilege.</para>
        /// </summary>
        public int PriorityClass;
        /// <summary>
        /// <para>If <see cref="LimitFlags"/> specifies <see cref="JOB_OBJECT_LIMIT_SCHEDULING_CLASS"/>, this member is the scheduling class for all processes associated with the job. Otherwise, this member is ignored.</para>
        /// <para>The valid values are 0 to 9. Use 0 for the least favorable scheduling class relative to other threads, and 9 for the most favorable scheduling class relative to other threads. By default, this value is 5. To use a scheduling class greater than 5, the calling process must enable the <see cref="WinNTConstants.SE_INC_BASE_PRIORITY_NAME"/> privilege.</para>
        /// </summary>
        public int SchedulingClass;
    }
}
