using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="AT_ENUM"/> structure contains information about a submitted job. The <see cref="NetScheduleJobEnum"/> function uses this structure to enumerate and return information about an entire queue of submitted jobs.
    /// </summary>
    /// <remarks>
    /// For more information about setting the bit flags to schedule jobs that execute once, jobs that execute multiple times, and jobs that execute periodically without deletion, see the <see cref="NetScheduleJobAdd"/> function.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370247.aspx">AT_ENUM structure</a></para>
    /// </remarks>
    /// <seealso cref="NetScheduleJobEnum"/>
    [StructLayout(LayoutKind.Sequential)]
    public class AT_ENUM
    {
        /// <summary>
        /// The job identifier of a submitted (queued) job.
        /// </summary>
        public int JobId;
        /// <summary>
        /// A pointer to the time of day at which the job is scheduled to run. The time is the local time at a computer on which the schedule service is running; it is measured from midnight, and is expressed in milliseconds.
        /// </summary>
        public IntPtr JobTimePtr;
        /// <summary>
        /// The time of day at which the job is scheduled to run. The time is the local time at a computer on which the schedule service is running.
        /// </summary>
        public TimeSpan JobTime => JobTimePtr == IntPtr.Zero ? TimeSpan.Zero : TimeSpan.FromMilliseconds(Marshal.ReadInt32(JobTimePtr));
        /// <summary>
        /// <para>A set of bit flags representing the days of the month. For each bit that is set, the scheduled job will run at the time specified by the <see cref="JobTime"/> member, on the corresponding day of the month. Bit 0 corresponds to the first day of the month, and so on. </para>
        /// <para>The value of the bitmask is zero if the job was scheduled to run only once, at the first occurrence specified in the <see cref="JobTime"/> member </para>
        /// </summary>
        public int DaysOfMonth;
        /// <summary>
        /// <para>A set of bit flags representing the days of the week. For each bit that is set, the scheduled job will run at the time specified by the <see cref="JobTime"/> member, on the corresponding day of the week. Bit 0 corresponds to Monday, and so on. </para>
        /// <para>The value of the bitmask is zero if the job was scheduled to run only once, at the first occurrence specified in the <see cref="JobTime"/> member. </para>
        /// </summary>
        public byte DaysOfWeek;
        /// <summary>
        /// A set of bit flags describing job properties. This member can have one or more of the flags defined in the <see cref="JOB_FLAGS"/> enumeration type.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public JOB_FLAGS Flags;
        /// <summary>
        /// A string that contains the name of the command, batch program, or binary file to execute.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Command;
    }
}
