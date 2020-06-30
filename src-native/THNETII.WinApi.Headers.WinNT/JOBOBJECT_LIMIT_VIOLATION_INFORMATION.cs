using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_LIMIT_FLAGS;
    using static JOB_OBJECT_MSG_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11824
    /// <summary>
    /// Contains information about resource notification limits that have been exceeded for a job object.
    /// This structure is used with the <see cref="QueryInformationJobObject"/> function with the
    /// <see cref="JobObjectLimitViolationInformation"/> information class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When any notification limit specified in a <see cref="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION"/>
    /// structure is exceeded, the system sends a <see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/> message to the
    /// I/O completion port associated with the job.
    /// </para>
    /// <para>
    /// To retrieve information about the limits that were exceeded, the application monitoring the I/O
    /// completion port must call the <see cref="QueryInformationJobObject"/> function with the
    /// <see cref="JobObjectLimitViolationInformation"/> information class and a pointer to a
    /// <see cref="JOBOBJECT_LIMIT_VIOLATION_INFORMATION"/> structure.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_limit_violation_information">JOBOBJECT_LIMIT_VIOLATION_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION
    {
        /// <summary>
        /// Flags that identify the notification limits in effect for the job.
        /// This member is a bitfield that determines whether other structure members are used.
        /// </summary>
        /// <value>
        /// This member can be any combination of the following values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/></term><description>The job has a committed memory notification limit. The <see cref="JobMemoryLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_READ_BYTES"/></term><description>The job has an I/O read bytes notification limit. The <see cref="IoReadBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_TIME"/></term><description>The job has a user-mode execution time notification limit. The <see cref="PerJobUserTimeLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_WRITE_BYTES"/></term><description>The job has an I/O write bytes notification limit. The <see cref="IoWriteBytesLimit"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description>The extent to which a job can exceed its CPU rate control limit. The <see cref="RateControlToleranceLimit"/> member contains more information. </description></item>
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
        /// <item><term><see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/></term><description>The job's committed memory notification limit has been exceeded. The <see cref="JobMemory"/> member contains more information. </description></item>
        /// <item><term><see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/></term><description>The job's CPU rate control limit has been exceeded. The <see cref="RateControlTolerance"/> member contains more information. </description></item>
        /// </list>
        /// </value>
        public JOB_OBJECT_LIMIT_FLAGS ViolationLimitFlags;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_READ_BYTES"/>, this member contains
        /// the total I/O read bytes for all processes in the job at the time the notification was sent.
        /// </summary>
        public long IoReadBytes;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_READ_BYTES"/>, this member contains the I/O
        /// read bytes notification limit in effect for the job.
        /// </summary>
        public long IoReadBytesLimit;
        /// <summary>
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_WRITE_BYTES"/>, this member
        /// contains the total I/O write bytes for all processes in the job at the time the notification was sent.
        /// </summary>
        public long IoWriteBytes;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_WRITE_BYTES"/>, this member contains the I/O
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
        /// If the <see cref="ViolationLimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/>, this member
        /// contains the committed memory for all processes in the job at the time the notification was sent.
        /// </summary>
        public long JobMemory;
        /// <summary>
        /// If the <see cref="LimitFlags"/> member specifies <see cref="JOB_OBJECT_LIMIT_JOB_MEMORY"/>, this member contains the
        /// committed memory limit in effect for the job.
        /// </summary>
        public long JobMemoryLimit;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member specifies the
        /// extent to which the job exceeded its CPU rate control limits at the time the notification was sent.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
        /// <summary>
        /// If the <see cref="LimitFlags"/> parameter specifies <see cref="JOB_OBJECT_LIMIT_RATE_CONTROL"/>, this member contains the CPU rate control notification limits specified for the job.
        /// </summary>
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;
    }
}
