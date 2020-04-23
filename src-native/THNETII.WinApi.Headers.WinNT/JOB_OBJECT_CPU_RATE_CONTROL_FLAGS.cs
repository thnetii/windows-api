using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum JOB_OBJECT_CPU_RATE_CONTROL_FLAGS : int
    {
        /// <summary>
        /// This flag enables the job's CPU rate to be controlled
        /// based on weight or hard cap. You must set this value
        /// if you also set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED"/>,
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP"/>, or
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>.
        /// </summary>
        JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_ENABLE,
        /// <summary>
        /// <para>
        /// The job's CPU rate is calculated based on its relative
        /// weight to the weight of other jobs. If this flag is set,
        /// the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.Weight"/> member contains more information. If
        /// this flag is clear, the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.CpuRate"/> member contains more
        /// information. 
        /// </para>
        /// <para>
        /// If you set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED"/>, you cannot also set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>.
        /// </para>
        /// </summary>
        JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED,
        /// <summary>
        /// <para>
        /// The job's CPU rate is a hard limit. After the job
        /// reaches its CPU cycle limit for the current scheduling
        /// interval, no threads associated with the job will run
        /// until the next interval.
        /// </para>
        /// <para>
        /// If you set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP"/>, you
        /// cannot also set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>.
        /// </para>
        /// </summary>
        JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP,
        /// <summary>
        /// Sends messages when the CPU rate for the job
        /// exceeds the rate limits for the job during the
        /// tolerance interval. 
        /// </summary>
        JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY,
        /// <summary>
        /// <para>
        /// The CPU rate for the job is limited by minimum and
        /// maximum rates that you specify in the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.MinRate"/> and
        /// <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.MaxRate"/> members. 
        /// </para>
        /// <para>
        /// If you set
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>,
        /// you can set neither
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED"/>
        /// nor <see cref="JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP"/>.
        /// </para>
        /// </summary>
        JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE,
        JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS = WinNTConstants.JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS,
    }
}
