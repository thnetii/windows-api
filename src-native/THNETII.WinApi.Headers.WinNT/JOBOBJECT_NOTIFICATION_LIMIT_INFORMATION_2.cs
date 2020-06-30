using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;
    using static JOB_OBJECT_MSG_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11795
    /// <summary>
    /// Contains extended information about notification limits for a job object. This structure is used by
    /// the <see cref="SetInformationJobObject"/> and <see cref="QueryInformationJobObject"/> functions with the
    /// <see cref="JobObjectNotificationLimitInformation2"/> information class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When a notification limit is exceeded, the system sends a <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/>
    /// message to the I/O completion port associated with the job. Processes in the job continue to run
    /// and can continue to allocate memory or transmit read or write bytes beyond the specified limits.
    /// </para>
    /// <para>
    /// When the application monitoring the I/O completion port receives a
    /// <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message, it must call <see cref="QueryInformationJobObject"/> with
    /// the <see cref="JobObjectLimitViolationInformation2"/> information class. Limit violation information is received
    /// in a <see cref="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2"/> structure that contains information about all
    /// notification limits that were exceeded at the time of the query. The system will not send another
    /// <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message until after <see cref="QueryInformationJobObject"/> is
    /// called.
    /// </para>
    /// <para>
    /// CPU rate control limits for a job are established in a
    /// <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"/> structure. The CPU rate control values in the
    /// <see cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/> structure specify how much the job can
    /// exceed its established CPU rate control limits before notification is sent.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_notification_limit_information_2">JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2 structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_IO_RATE_CONTROL_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2"/>
    /// <seealso cref="JOBOBJECT_NET_RATE_CONTROL_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    /// <seealso cref="SetIoRateControlInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2
    {
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/>, this member is the notification limit for total I/O bytes read by all processes in the job. Otherwise, this member is ignored.
        /// </summary>
        public long IoReadBytesLimit;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/>, this member is the notification limit for total I/O bytes written by all processes in the job. Otherwise, this member is ignored.
        /// </summary>
        public long IoWriteBytesLimit;
        /// <summary>
        /// <para>If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_TIME"/>, this member is the notification limit for per-job user-mode execution time, in 100-nanosecond ticks. Otherwise, this member is ignored.</para>
        /// <para>The system adds the accumulated execution time of processes associated with the job to this limit when the limit is set. For example, if a process associated with the job has already accumulated 5 minutes of user-mode execution time and the limit is set to 1 minute, the limit actually enforced is 6 minutes.</para>
        /// <para>To specify <see cref="PerJobUserTimeLimit"/> as an enforceable limit and terminate processes in jobs that exceed the limit, see the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        public long PerJobUserTimeLimit;

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
        /// <para>If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/>, this member is the notification limit for total virtual memory that can be committed by all processes in the job, in bytes. Otherwise, this member is ignored.</para>
        /// <para>To specify <see cref="JobMemoryLimit"/> as an enforceable limit and prevent processes in jobs that exceed the limit from continuing to commit memory, see the <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        public long JobHighMemoryLimit
        {
            get => u.JobHighMemoryLimit;
            set => u.JobHighMemoryLimit = value;
        }

        /// <summary>
        /// <para>If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/>, this member is the notification limit for total virtual memory that can be committed by all processes in the job, in bytes. Otherwise, this member is ignored.</para>
        /// <para>To specify <see cref="JobMemoryLimit"/> as an enforceable limit and prevent processes in jobs that exceed the limit from continuing to commit memory, see the <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure.</para>
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
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the extent to which a job can exceed its CPU rate control limits during the interval specified by the <see cref="RateControlToleranceInterval"/> member. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
        {
            get => u2.RateControlTolerance;
            set => u2.RateControlTolerance = value;
        }

        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/>, this member specifies the extent to which a job can exceed its CPU rate control limits during the interval specified by the <see cref="RateControlToleranceInterval"/> member. Otherwise, this member is ignored.
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
            public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval;
        }
        private DUMMYUNIONNAME3 u3;

        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the interval during which a job's CPU usage is monitored to determine whether the job has exceeded its CPU rate control limits. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval
        {
            get => u3.RateControlToleranceInterval;
            set => u3.RateControlToleranceInterval = value;
        }

        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/>, this member specifies the interval during which a job's CPU usage is monitored to determine whether the job has exceeded its CPU rate control limits. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval
        {
            get => u3.CpuRateControlToleranceInterval;
            set => u3.CpuRateControlToleranceInterval = value;
        }

        /// <summary>
        /// The limit flags that are in effect. This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        /// <value>
        /// Any combination of the following values can be specified.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH"/></term><description>Establishes the notification threshold for the job-wide sum of private committed memory for all processes associated with the job. The <see cref="JobHighMemoryLimit"/> member contains additional information.</description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_LOW"/></term><description>Establishes the notification minimum for the job-wide sum of private committed memory for all processes associated with the job. If this value is set, a notification is sent when the amount of private committed memory falls below this threshold. The <see cref="JobLowMemoryLimit"/> member contains additional information.</description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/></term><description>Establishes the I/O read bytes limit to the job-wide sum of I/O bytes read by all processes associated with the job. The <see cref="IoReadBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/></term><description>Establishes the I/O write bytes limit to the job-wide sum of I/O bytes written by all processes associated with the job. The <see cref="IoWriteBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_TIME"/></term><description>Establishes the limit for user-mode execution time for the job. The <see cref="PerJobUserTimeLimit"/> member contains additional information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_CPU_RATE_CONTROL"/></term><description><para>Establishes the notification threshold for the CPU rate control limits established for the job. The <see cref="CpuRateControlTolerance"/> and <see cref="CpuRateControlToleranceInterval"/> members contain additional information. </para><para>CPU rate control limits are established by calling <see cref="SetInformationJobObject"/> with the <see cref="JobObjectCpuRateInformationClass"/> information class.</para></description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description><para>Establishes the notification threshold for the CPU rate control limits established for the job. The <see cref="RateControlTolerance"/> and <see cref="RateControlToleranceInterval"/> members contain additional information. </para><para>CPU rate control limits are established by calling <see cref="SetInformationJobObject"/> with the <see cref="JobObjectCpuRateInformationClass"/> information class.</para></description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/></term><description><para>Establishes the notification threshold for the I/O rate control limits established for the job. The <see cref="IoRateControlTolerance"/> and <see cref="IoRateControlToleranceInterval"/> members contain additional information. </para><para>I/O rate control limits are established by calling <see cref="SetIoRateControlInformationJobObject"/>.</para></description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/></term><description><para>Establishes the notification threshold for the network rate control limits established for the job. The <see cref="NetRateControlTolerance"/> and <see cref="NetRateControlToleranceInterval"/> members contain additional information. </para><para>Network rate control limits are established by calling <see cref="SetInformationJobObject"/> with the <see cref="JobObjectNetRateInformationClass"/> information class.</para></description></item>
        /// </list>
        /// </value>
        public JOB_OBJECT_LIMIT_FLAGS LimitFlags;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/>, this member
        /// specifies the extent to which a job can exceed its I/O rate control limits during the interval
        /// specified by the <see cref="IoRateControlToleranceInterval"/> member. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY_LOW"/>, this member is the
        /// notification limit minimum for the total virtual memory that can be committed by all processes in
        /// the job, in bytes. Otherwise, this member is ignored.
        /// </summary>
        public long JobLowMemoryLimit;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/>, this member
        /// specifies the interval during which a job's I/O usage is monitored to determine whether the job has
        /// exceeded its I/O rate control limits. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL IoRateControlToleranceInterval;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_IO_RATE_CONTROL"/>, this member
        /// specifies the extent to which a job can exceed its network rate control limits during the interval
        /// specified by the <see cref="NetRateControlToleranceInterval"/> member. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_NET_RATE_CONTROL"/>, this member
        /// specifies the interval during which a job's network usage is monitored to determine whether the
        /// job has exceeded its network rate control limits. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL NetRateControlToleranceInterval;
    }
}
