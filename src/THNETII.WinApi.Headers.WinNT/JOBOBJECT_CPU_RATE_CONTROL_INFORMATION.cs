using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_CPU_RATE_CONTROL_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11872
    /// <summary>
    /// Contains CPU rate control information for a job object. This structure is used by the
    /// <see cref="SetInformationJobObject"/> and <see cref="QueryInformationJobObject"/> functions with the
    /// <see cref="JobObjectCpuRateControlInformation"/> information class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// You can set CPU rate control for multiple jobs in a hierarchy of nested jobs. When you set CPU rate
    /// control for a job object, the settings apply to the job and its child jobs in the hierarchy. When you
    /// set CPU rate control for a job in a nested hierarchy, the system calculates the corresponding
    /// quotas with respect to the CPU rate control of the immediate parent job for the job. In other
    /// words, the rates set for the job represent its portion of the CPU rate that is allocated to its parent
    /// job. If a job object does not have a parent with CPU rate control turned on in the chain of its
    /// parent jobs, the rate control for the job represents the portion of the CPU for the entire system.
    /// </para>
    /// <para>
    /// CPU rate control cannot be used by job objects in applications running under <a href="https://msdn.microsoft.com/90c40b7a-e324-43fc-a1e6-f29997ed9436">Remote Desktop Services</a> (formerly Terminal Services)
    /// if Dynamic Fair Share Scheduling (DFSS) is in effect.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_cpu_rate_control_information">JOBOBJECT_CPU_RATE_CONTROL_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
    {
        /// <summary>
        /// The scheduling policy for CPU rate control.
        /// </summary>
        public JOB_OBJECT_CPU_RATE_CONTROL_FLAGS ControlFlags;

        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public int CpuRate;
            [FieldOffset(0)]
            public int Weight;

            private struct DUMMYSTRUCTNAME
            {
                public short MinRate;
                public short MaxRate;
            }
            [FieldOffset(0)]
            private DUMMYSTRUCTNAME s;

            public short MinRate
            {
                get => s.MinRate;
                set => s.MinRate = value;
            }

            public short MaxRate
            {
                get => s.MaxRate;
                set => s.MaxRate = value;
            }
        }
        private DUMMYUNIONNAME u;

        /// <summary>
        /// <para>
        /// Specifies the portion of processor cycles that the threads in a job object can use during each
        /// scheduling interval, as the number of cycles per 10,000 cycles. If the <see cref="ControlFlags"/> member
        /// specifies <see cref="JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED"/> or
        /// <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>, this member is not used.
        /// </para>
        /// <para>
        /// Set <see cref="CpuRate"/> to a percentage times 100. For example, to let the job use 20% of the CPU, set
        /// <see cref="CpuRate"/> to 20 times 100, or 2,000.
        /// </para>
        /// <para>Do not set <see cref="CpuRate"/> to 0 (zero). If <see cref="CpuRate"/> is 0 (zero), <see cref="SetInformationJobObject"/> returns <strong>INVALID_ARGS</strong>.</para>
        /// </summary>
        public int CpuRate
        {
            get => u.CpuRate;
            set => u.CpuRate = value;
        }

        /// <summary>
        /// <para>
        /// If the <see cref="ControlFlags"/> member specifies <see cref="JOB_OBJECT_CPU_RATE_WEIGHT_BASED"/>, this member
        /// specifies the scheduling weight of the job object, which determines the share of processor time
        /// given to the job relative to other workloads on the processor.
        /// </para>
        /// <para>
        /// This member can be a value from 1 through 9, where 1 is the smallest share and 9 is the largest
        /// share. The default is 5, which should be used for most workloads.
        /// </para>
        /// <para>
        /// If the <see cref="ControlFlags"/> member specifies <see cref="JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE"/>, this
        /// member is not used.
        /// </para>
        /// </summary>
        public int Weight
        {
            get => u.Weight;
            set => u.Weight = value;
        }

        /// <summary>
        /// <para>
        /// Specifies the minimum portion of the processor cycles that the threads in a job object can reserve
        /// during each scheduling interval. Specify this rate as a percentage times 100. For example, to set a
        /// minimum rate of 50%, specify 50 times 100, or 5,000.
        /// </para>
        /// <para>
        /// For the minimum rates to work correctly, the sum of the minimum rates for all of the job objects in
        /// the system cannot exceed 10,000, which is the equivalent of 100%.
        /// </para>
        /// </summary>
        public short MinRate
        {
            get => u.MinRate;
            set => u.MinRate = value;
        }

        /// <summary>
        /// <para>
        /// Specifies the maximum portion of processor cycles that the threads in a job object can use during
        /// each scheduling interval. Specify this rate as a percentage times 100. For example, to set a
        /// maximum rate of 50%, specify 50 times 100, or 5,000.
        /// </para>
        /// <para>
        /// After the job reaches this limit for a scheduling interval, no threads associated with the job can run
        /// until the next scheduling interval.
        /// </para>
        /// </summary>
        public short MaxRate
        {
            get => u.MaxRate;
            set => u.MaxRate = value;
        }
    }
}
