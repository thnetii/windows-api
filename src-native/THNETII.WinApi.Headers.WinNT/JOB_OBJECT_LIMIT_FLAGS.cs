using System;

namespace THNETII.WinApi.Native.WinNT
{
    using static JOB_OBJECT_MSG_TYPE;

    [Flags]
    public enum JOB_OBJECT_LIMIT_FLAGS : int
    {
        //
        // Basic Limits
        //
        /// <summary>
        /// <para> Causes all processes associated with the job to use the same minimum and maximum working set sizes. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.MinimumWorkingSetSize"/> and <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.MaximumWorkingSetSize"/> members contain additional information.</para>
        /// <para>If the job is nested, the effective working set size is the smallest working set size in the job chain.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_WORKINGSET = WinNTConstants.JOB_OBJECT_LIMIT_WORKINGSET,
        /// <summary>
        /// Establishes a user-mode execution time limit for each currently active process and for all future processes associated with the job. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerProcessUserTimeLimit"/> member contains additional information. 
        /// </summary>
        JOB_OBJECT_LIMIT_PROCESS_TIME = WinNTConstants.JOB_OBJECT_LIMIT_PROCESS_TIME,
        /// <summary>
        /// Establishes a user-mode execution time limit for the job. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerJobUserTimeLimit"/> member contains additional information. This flag cannot be used with <see cref="JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME"/>.
        /// </summary>
        JOB_OBJECT_LIMIT_JOB_TIME = WinNTConstants.JOB_OBJECT_LIMIT_JOB_TIME,
        /// <summary>
        /// Establishes a maximum number of simultaneously active processes associated with the job. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.ActiveProcessLimit"/> member contains additional information.
        /// </summary>
        JOB_OBJECT_LIMIT_ACTIVE_PROCESS = WinNTConstants.JOB_OBJECT_LIMIT_ACTIVE_PROCESS,
        /// <summary>
        /// <para>Causes all processes associated with the job to use the same processor affinity. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.Affinity"/> member contains additional information.</para>
        /// <para>If the job is nested, the specified processor affinity must be a subset of the effective affinity of the parent job. If the specified affinity a superset of the affinity of the parent job, it is ignored and the affinity of the parent job is used.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_AFFINITY = WinNTConstants.JOB_OBJECT_LIMIT_AFFINITY,
        /// <summary>
        /// <para>Causes all processes associated with the job to use the same priority class. For more information, see <a href="https://msdn.microsoft.com/8710cd56-6bf3-4317-a1f6-1a159394ce2a">Scheduling Priorities</a>. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.PriorityClass"/> member contains additional information. </para>
        /// <para>If the job is nested, the effective priority class is the lowest priority class in the job chain.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_PRIORITY_CLASS = WinNTConstants.JOB_OBJECT_LIMIT_PRIORITY_CLASS,
        /// <summary>
        /// Preserves any job time limits you previously set. As long as this flag is set, you can establish a per-job time limit once, then alter other limits in subsequent calls. This flag cannot be used with <see cref="JOB_OBJECT_LIMIT_JOB_TIME"/>.
        /// </summary>
        JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = WinNTConstants.JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME,
        /// <summary>
        /// <para>Causes all processes in the job to use the same scheduling class. The <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.SchedulingClass"/> member contains additional information. </para>
        /// <para>If the job is nested, the effective scheduling class is the lowest scheduling class in the job chain.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_SCHEDULING_CLASS = WinNTConstants.JOB_OBJECT_LIMIT_SCHEDULING_CLASS,

        //
        // Extended Limits
        //
        /// <summary>
        /// <para>Causes all processes associated with the job to limit their committed memory. When a process attempts to commit memory that would exceed the per-process limit, it fails. If the job object is associated with a completion port, a <see cref="JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT"/> message is sent to the completion port.</para>
        /// <para>If the job is nested, the effective memory limit is the most restrictive memory limit in the job chain.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_PROCESS_MEMORY = WinNTConstants.JOB_OBJECT_LIMIT_PROCESS_MEMORY,
        /// <summary>
        /// <para>Causes all processes associated with the job to limit the job-wide sum of their committed memory. When a process attempts to commit memory that would exceed the job-wide limit, it fails. If the job object is associated with a completion port, a <see cref="JOB_OBJECT_MSG_JOB_MEMORY_LIMIT"/> message is sent to the completion port.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// <para>To register for notification when this limit is exceeded while allowing processes to continue to commit memory, use the <see cref="SetInformationJobObject"/> function with the <see cref="JobObjectNotificationLimitInformation"/> information class.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_JOB_MEMORY = WinNTConstants.JOB_OBJECT_LIMIT_JOB_MEMORY,
        JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = WinNTConstants.JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH,
        /// <summary>
        /// <para>Forces a call to the <see cref="SetErrorMode"/> function with the <see cref="SEM_NOGPFAULTERRORBOX"/> flag for each process associated with the job. </para>
        /// <para>If an exception occurs and the system calls the <see cref="UnhandledExceptionFilter"/> function, the debugger will be given a chance to act. If there is no debugger, the functions returns <see cref="EXCEPTION_EXECUTE_HANDLER"/>. Normally, this will cause termination of the process with the exception code as the exit status.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = WinNTConstants.JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION,
        /// <summary>
        /// <para> If any process associated with the job creates a child process using the <see cref="CREATE_BREAKAWAY_FROM_JOB"/> flag while this limit is in effect, the child process is not associated with the job.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_BREAKAWAY_OK = WinNTConstants.JOB_OBJECT_LIMIT_BREAKAWAY_OK,
        /// <summary>
        /// <para>Allows any process associated with the job to create child processes that are not associated with the job. <br/>If the job is nested and its immediate job object allows breakaway, the child process breaks away from the immediate job object and from each job in the parent job chain, moving up the hierarchy until it reaches a job that does not permit breakaway. If the immediate job object does not allow breakaway, the child process does not break away even if jobs in its parent job chain allow it.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = WinNTConstants.JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK,
        /// <summary>
        /// <para>Causes all processes associated with the job to terminate when the last handle to the job is closed.</para>
        /// <para>This limit requires use of a <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"/> structure. Its <see cref="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"/> member is a <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = WinNTConstants.JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE,
        /// <summary>
        /// <para>Allows processes to use a subset of the processor affinity for all processes associated with the job. This value must be combined with <see cref="JOB_OBJECT_LIMIT_AFFINITY"/>.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This flag is supported starting with Windows 7 and Windows Server 2008 R2.</para>
        /// </summary>
        JOB_OBJECT_LIMIT_SUBSET_AFFINITY = WinNTConstants.JOB_OBJECT_LIMIT_SUBSET_AFFINITY,
        JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = WinNTConstants.JOB_OBJECT_LIMIT_JOB_MEMORY_LOW,

        //
        // Notification Limits
        //

        JOB_OBJECT_LIMIT_JOB_READ_BYTES = WinNTConstants.JOB_OBJECT_LIMIT_JOB_READ_BYTES,
        JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = WinNTConstants.JOB_OBJECT_LIMIT_JOB_WRITE_BYTES,
        JOB_OBJECT_LIMIT_RATE_CONTROL = WinNTConstants.JOB_OBJECT_LIMIT_RATE_CONTROL,
        JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = WinNTConstants.JOB_OBJECT_LIMIT_CPU_RATE_CONTROL,
        JOB_OBJECT_LIMIT_IO_RATE_CONTROL = WinNTConstants.JOB_OBJECT_LIMIT_IO_RATE_CONTROL,
        JOB_OBJECT_LIMIT_NET_RATE_CONTROL = WinNTConstants.JOB_OBJECT_LIMIT_NET_RATE_CONTROL,


        //
        // Valid Job Object Limits
        //

        JOB_OBJECT_LIMIT_VALID_FLAGS = WinNTConstants.JOB_OBJECT_LIMIT_VALID_FLAGS,
        JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = WinNTConstants.JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS,
        JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = WinNTConstants.JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS,
        JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = WinNTConstants.JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS,
    }
}
