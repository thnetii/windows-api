using System;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum JOB_FLAGS : byte
    {
        /// <summary>
        /// Do we exec programs for this job periodically (/EVERY switch)
        /// or one time (/NEXT switch).
        /// </summary>
        JOB_RUN_PERIODICALLY = 0x01,    //  set if EVERY

        /// <summary>
        /// Was there an error last time we tried to exec a program on behalf of
        /// this job.
        /// This flag is meaningfull on output only!
        /// </summary>
        JOB_EXEC_ERROR = 0x02,    //  set if error

        /// <summary>
        /// Will this job run today or tomorrow.
        /// This flag is meaningfull on output only!
        /// </summary>
        JOB_RUNS_TODAY = 0x04,    //  set if today

        /// <summary>
        /// Add current day of the month to DaysOfMonth input.
        /// This flag is meaningfull on input only!
        /// </summary>
        JOB_ADD_CURRENT_DATE = 0x08,    // set if to add current date

        /// <summary>
        /// Will this job be run interactively or not.  Windows NT 3.1 do not
        /// know about this bit, i.e. they submit interactive jobs only.
        /// </summary>
        JOB_NONINTERACTIVE = 0x10,    // set for noninteractive

        JOB_INPUT_FLAGS = (JOB_RUN_PERIODICALLY | JOB_ADD_CURRENT_DATE | JOB_NONINTERACTIVE),

        JOB_OUTPUT_FLAGS = (JOB_RUN_PERIODICALLY | JOB_EXEC_ERROR | JOB_RUNS_TODAY | JOB_NONINTERACTIVE),
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}