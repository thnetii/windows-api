using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11785
    /// <summary>
    /// Contains information about notification limits for a job object. This
    /// structure is used by the <see cref="SetInformationJobObject"/> and
    /// <see cref="QueryInformationJobObject"/> functions with the
    /// <see cref="JobObjectNotificationLimitInformation"/> information class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When a notification limit is exceeded, the system sends a <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/>
    /// message to the I/O completion port associated with the job. Processes in the job continue to run
    /// and can continue to allocate memory or transmit read or write bytes beyond the specified limits.
    /// </para>
    /// <para>
    /// When the application monitoring the I/O completion port receives a
    /// <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message, it must call <see cref="QueryInformationJobObject"/> with the
    /// <see cref="JobObjectLimitViolationInformation"/> information class. Limit violation information is received in a
    /// <see cref="JOBOBJECT_LIMIT_VIOLATION_STRUCTURE"/> that contains information about all notification limits
    /// that were exceeded at the time of the query. The system will not send another
    /// <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message until after <see cref="QueryInformationJobObject"/> is called.</para>
    /// <para>
    /// CPU rate control limits for a job are established in a
    /// <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"/> structure. The CPU rate control values in the
    /// <see cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"/> structure specify how much the job can exceed
    /// its established CPU rate control limits before notification is sent.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_notification_limit_information">JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"/>
    /// <seealso cref="JOBOBJECT_LIMIT_VIOLATION_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION
    {
        private static readonly Bitfield32 bfLimitFlags = Bitfield32.DefineFromMask((int)JOB_OBJECT_LIMIT_FLAGS.JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS);

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
        /// <summary>
        /// <para>If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/>, this member is the notification limit for total virtual memory that can be committed by all processes in the job, in bytes. Otherwise, this member is ignored.</para>
        /// <para>To specify <see cref="JobMemoryLimit"/> as an enforceable limit and prevent processes in jobs that exceed the limit from continuing to commit memory, see the <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        public long JobMemoryLimit;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the extent to which a job can exceed its CPU rate control limits during the interval specified by the <see cref="RateControlToleranceInterval"/> member. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the interval during which a job's CPU usage is monitored to determine whether the job has exceeded its CPU rate control limits. Otherwise, this member is ignored.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;
        internal int LimitFlagsField;
        /// <summary>
        /// The limit flags that are in effect. This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        /// <value>
        /// Any combination of the following values can be specified.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/></term><description>Establishes the committed memory limit to the job-wide sum of committed memory for all processes associated with the job. The <see cref="JobMemoryLimit"/> member contains additional information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/></term><description>Establishes the I/O read bytes limit to the job-wide sum of I/O bytes read by all processes associated with the job. The <see cref="IoReadBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/></term><description>Establishes the I/O write bytes limit to the job-wide sum of I/O bytes written by all processes associated with the job. The <see cref="IoWriteBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_TIME"/></term><description>Establishes the limit for user-mode execution time for the job. The <see cref="PerJobUserTimeLimit"/> member contains additional information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description><para>Establishes the notification threshold for the CPU rate control limits established for the job. The <see cref="RateControlTolerance"/> and <see cref="RateControlToleranceInterval"/> members contain additional information. </para><para>CPU rate control limits are established by calling <see cref="SetInformationJobObject"/> with the <see cref="JobObjectCpuRateInformationClass"/> information class.</para></description></item>
        /// </list>
        /// </value>
        public JOB_OBJECT_LIMIT_FLAGS LimitFlags
        {
            get => (JOB_OBJECT_LIMIT_FLAGS)bfLimitFlags.Read(LimitFlagsField);
            set => bfLimitFlags.Write(ref LimitFlagsField, (int)value);
        }
    }
}
