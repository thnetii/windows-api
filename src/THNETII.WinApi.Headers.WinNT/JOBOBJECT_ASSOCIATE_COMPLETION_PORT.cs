using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11758
    /// <summary>
    /// Contains information used to associate a completion port with a job. You can associate one completion port with a job.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The system sends messages to the I/O completion port associated with a
    /// job when certain events occur. If the job is nested, the message is sent
    /// to every I/O completion port associated with any job in the parent job
    /// chain of the job that triggered the message. All messages are sent
    /// directly from the job as if the job had called the
    /// <see cref="PostQueuedCompletionStatus"/> function.
    /// </para>
    /// <para>
    /// Note that, except for limits set with the
    /// <see cref="JobObjectNotificationLimitInformation"/> information class,
    /// messages are intended only as notifications and their delivery to the
    /// completion port is not guaranteed. The failure of a message to arrive at
    /// the completion port does not necessarily mean that the event did not
    /// occur. Notifications for limits set with
    /// <see cref="JobObjectNotificationLimitInformation"/> are guaranteed to
    /// arrive at the completion port.
    /// </para>
    /// <para>
    /// A thread must monitor the completion port using the
    /// <see cref="GetQueuedCompletionStatus"/> function to pick up the messages.
    /// The thread receives information in the
    /// <see cref="GetQueuedCompletionStatus"/> parameters shown in the
    /// following table.
    /// <list type="table">
    /// <listheader><term>Parameter</term><description>Information Received</description></listheader>
    /// <item><term><em>lpCompletionKey</em></term><description>The value specified in <em>CompletionKey</em> during the completion-port association. If a completion port is associated with multiple jobs, <em>CompletionKey</em> should help the caller determine which completion port is sending a message.</description></item>
    /// <item><term><em>lpOverlapped</em></term><description>Message-specific value. For more information, see the following table of message identifiers.</description></item>
    /// <item><term><em>lpNumberOfBytes</em></term><description>The message identifier that indicates which job-related event occurred. For more information, see the following table of message identifiers.</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// The following messages can be sent to the completion port. Note that for
    /// messages that return a process identifier, you cannot guarantee that
    /// this process is still active or that the identifier has not been
    /// recycled (assigned to a new process after termination) unless you
    /// maintain an open handle to the process.
    /// <list type="table">
    /// <listheader><term>Message Identifier</term><description>Description</description></listheader>
    /// <item><term><see cref="JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS"/></term><description>Indicates that a process associated with the job exited with an exit code that indicates an abnormal exit (see the list following this table). <br/>The value of <em>lpOverlapped</em> is the identifier of the exiting process.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT"/></term><description>Indicates that the active process limit has been exceeded. <br/>The value of <em>lpOverlapped</em> is <see cref="IntPtr.Zero"/>.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO"/></term><description>Indicates that the active process count has been decremented to 0 (zero). For example, if the job currently has two active processes, the system sends this message after they both terminate. <br/>The value of <em>lpOverlapped</em> is <see cref="IntPtr.Zero"/>.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_END_OF_JOB_TIME"/></term><description>Indicates that the <see cref="JOB_OBJECT_POST_AT_END_OF_JOB"/> option is in effect and the end-of-job time limit has been reached. Upon posting this message, the time limit is canceled and the job's processes can continue to run.<br/>The value of <em>lpOverlapped</em> is <see cref="IntPtr.Zero"/>.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_END_OF_PROCESS_TIME"/></term><description>Indicates that a process has exceeded a per-process time limit. The system sends this message after the process termination has been requested. <br/>The value of <em>lpOverlapped</em> is the identifier of the process that exceeded its limit.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_EXIT_PROCESS"/></term><description>Indicates that a process associated with the job has exited. <br/>The value of <em>lpOverlapped</em> is the identifier of the exiting process.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_JOB_MEMORY_LIMIT"/></term><description>Indicates that a process associated with the job caused the job to exceed the job-wide memory limit (if one is in effect).<br/>The value of <em>lpOverlapped</em> specifies the identifier of the process that has attempted to exceed the limit. The system does not send this message if the process has not yet reported its process identifier.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_NEW_PROCESS"/></term><description>Indicates that a process has been added to the job. Processes added to a job at the time a completion port is associated are also reported.<br/>The value of <em>lpOverlapped</em> is the identifier of the process added to the job.</description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_NOTIFICATION_LIMIT"/></term><description><para>Indicates that a process associated with a job that has registered for resource limit notifications has exceeded one or more limits. Use the <see cref="QueryInformationJobObject"/> function with <see cref="JobObjectLimitViolationInformation"/> to determine which limit was exceeded.</para><para>The value of <em>lpOverlapped</em> is the identifier of the process that has exceeded its limit. The system does not send this message if the process has not yet reported its process identifier.</para></description></item>
    /// <item><term><see cref="JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT"/></term><description>Indicates that a process associated with the job has exceeded its memory limit (if one is in effect).<br/>The value of <em>lpOverlapped</em> is the identifier of the process that has exceeded its limit. The system does not send this message if the process has not yet reported its process identifier.</description></item>
    /// </list>
    /// </para>
    /// <para>The following exit codes indicate an abnormal exit:</para>
    /// <para>
    /// You must be cautious when using the <see cref="JOB_OBJECT_MSG_NEW_PROCESS"/>
    /// and <see cref="JOB_OBJECT_MSG_EXIT_PROCESS"/> messages, as race
    /// conditions may occur. For instance, if processes are actively starting
    /// and exiting within a job, and you are in the process of assigning a
    /// completion port to the job, you may miss messages for processes whose
    /// states change during the association of the completion port. For this
    /// reason, it is best to associate a completion port with a job when the
    /// job is inactive.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_associate_completion_port">JOBOBJECT_ASSOCIATE_COMPLETION_PORT structure</a></para>
    /// </remarks>
    /// <seealso cref="PostQueuedCompletionStatus"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_ASSOCIATE_COMPLETION_PORT
    {
        /// <summary>
        /// The value to use in the <em>dwCompletionKey</em> parameter of
        /// <see cref="PostQueuedCompletionStatus"/> when messages are sent on
        /// behalf of the job.
        /// </summary>
        public IntPtr CompletionKey;
        /// <summary>
        /// <para>The completion port to use in the <em>CompletionPort</em> parameter of the <see cref="PostQueuedCompletionStatus"/> function when messages are sent on behalf of the job.</para>
        /// <para><strong>Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows 10 and Windows Server 2016</strong>: Specify <see cref="IntPtr.Zero"/> to remove the association between the current completion port and the job.</para>
        /// </summary>
        public IntPtr CompletionPort;
    }
}
