using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11839
    /// <summary>
    /// Contains extended information about resource notification limits that have been exceeded for a
    /// job object. This structure is used with the <see cref="QueryInformationJobObject"/> function with the
    /// <see cref="JobObjectLimitViolationInformation2"/> information class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When any notification limit specified in a <see cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/>
    /// structure is exceeded, the system sends a <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message to
    /// the I/O completion port associated with the job.
    /// </para>
    /// <para>
    /// To retrieve information about the limits that were exceeded, the application monitoring the I/O
    /// completion port must call the <see cref="QueryInformationJobObject"/> function with the
    /// <see cref="JobObjectLimitViolationInformation2"/> information class and a pointer to a
    /// <see cref="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2"/> structure.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_limit_violation_information_2">JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2
    {
        /// <summary>
        /// Flags that identify the notification limits in effect for the job.
        /// This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        /// <value>
        /// This member can be any combination of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/></term><description>The job has a committed memory notification limit. The <see cref="JobHighMemoryLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_LOW"/></term><description>The job has a committed minimum memory notification limit. The <see cref="JobLowMemoryLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/></term><description>The job has an I/O read bytes notification limit. The <see cref="IoReadBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/></term><description>The job has an I/O write bytes notification limit. The <see cref="IoWriteBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_TIME"/></term><description>The job has a user-mode execution time notification limit. The <see cref="PerJobUserTimeLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description>The job has notification limit for the extent to which a job can exceed its CPU rate control limit. The <see cref="RateControlToleranceLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/></term><description>The job has notification limit for the extent to which a job can exceed its CPU rate control limit. The <see cref="CpuRateControlToleranceLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/></term><description>The job has notification limit for the extent to which a job can exceed its I/O rate control limit. The <see cref="IoRateControlToleranceLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/></term><description>The job has notification limit for the extent to which a job can exceed its network rate control limit. The <see cref="NetRateControlToleranceLimit"/> member contains more information. </description></item>
        /// </list>
        /// </value>
        public JOB_OBJECT_LIMIT_FLAGS LimitFlags;
        /// <summary>
        /// Flags that identify the notification limits that have been exceeded.
        /// This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        /// <value>
        /// This member can be any combination of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/></term><description>The job's I/O read bytes notification limit has been exceeded. The <see cref="IoReadBytes"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/></term><description>The job's I/O write bytes notification limit has been exceeded. The <see cref="IoWriteBytes"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_TIME"/></term><description>The job's user-mode execution time notification limit has been exceeded. The <see cref="PerJobUserTime"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/></term><description>The job's committed memory notification limit has been exceeded. The <see cref="JobMemory"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_LOW"/></term><description>The job's committed memory notification limit has been exceeded. The <see cref="JobMemory"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description>The job's CPU rate control limit has been exceeded. The <see cref="RateControlTolerance"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/></term><description>The job's CPU rate control limit has been exceeded. The <see cref="RateControlTolerance"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/></term><description>The job's I/O rate control limit has been exceeded. The <see cref="RateControlTolerance"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/></term><description>The job's network rate control limit has been exceeded. The <see cref="NetRateControlTolerance"/> member contains more information. </description></item>
        /// </list>
        /// </value>
        public JOB_OBJECT_LIMIT_FLAGS ViolationLimitFlags;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/>, this member contains
        /// the total I/O read bytes for all processes in the job at the time the notification was sent.
        /// </summary>
        public long IoReadBytes;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/>, this member contains the I/O
        /// read bytes notification limit in effect for the job.
        /// </summary>
        public long IoReadBytesLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/>, this member
        /// contains the total I/O write bytes for all processes in the job at the time the notification was sent.
        /// </summary>
        public long IoWriteBytes;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/>, this member contains the I/O
        /// write bytes notification limit in effect for the job.
        /// </summary>
        public long IoWriteBytesLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_TIME"/>, this member contains
        /// the total user-mode execution time for all processes in the job at the time the notification was
        /// sent.
        /// </summary>
        public long PerJobUserTime;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_TIME"/>, this member contains the user-
        /// mode execution notification limit in effect for the job.
        /// </summary>
        public long PerJobUserTimeLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/> or
        /// <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/>, this member contains the committed memory for all
        /// processes in the job at the time the notification was sent.
        /// </summary>
        public long JobMemory;

        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public long JobHighMemoryLimit;
            [FieldOffset(0)]
            public long JobMemoryLimit;
        }
        private DUMMYUNIONNAME u;

        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/>, this member
        /// contains the committed maximum memory limit in effect for the job.
        /// </summary>
        public long JobHighMemoryLimit
        {
            get => u.JobHighMemoryLimit;
            set => u.JobHighMemoryLimit = value;
        }

        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/>, this member contains the
        /// committed maximum memory limit in effect for the job.
        /// </summary>
        public long JobMemoryLimit
        {
            get => u.JobMemoryLimit;
            set => u.JobMemoryLimit = value;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME2
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
        }
        private DUMMYUNIONNAME2 u2;

        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the
        /// extent to which the job exceeded its CPU rate control limits at the time the notification was sent. 
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
        {
            get => u2.RateControlTolerance;
            set => u2.RateControlTolerance = value;
        }

        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/>, this member specifies the
        /// extent to which the job exceeded its CPU rate control limits at the time the notification was sent. 
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance
        {
            get => u2.CpuRateControlTolerance;
            set => u2.CpuRateControlTolerance = value;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct DUMMYUNIONNAME3
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit;
        }
        private DUMMYUNIONNAME3 u3;

        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member contains the
        /// CPU rate control notification limits specified for the job.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit
        {
            get => u3.RateControlToleranceLimit;
            set => u3.RateControlToleranceLimit = value;
        }

        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/>, this member contains the
        /// CPU rate control notification limits specified for the job.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit
        {
            get => u3.CpuRateControlToleranceLimit;
            set => u3.CpuRateControlToleranceLimit = value;
        }

        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_LOW"/>, this member contains
        /// the committed minimum memory limit in effect for the job.
        /// </summary>
        public long JobLowMemoryLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/>, this member specifies
        /// the extent to which the job exceeded its I/O rate control limits at the time the notification was sent. 
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/>, this member
        /// contains the I/O rate control notification limits specified for the job.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlToleranceLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/>, this member
        /// specifies the extent to which the job exceeded its network rate control limits at the time the notification was sent.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/>, this member
        /// contains the network rate control notification limits specified for the job.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlToleranceLimit;
    }
}
