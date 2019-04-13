using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11754
    /// <summary>
    /// Specifies the action the system will perform when an end-of-job time limit is exceeded.
    /// </summary>
    /// <remarks>
    /// <para>The end-of-job time limit is specified in the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerJobUserTimeLimit"/> member of the <see cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/> structure.</para>
    /// <para>To associate a completion port with a job, use the <see cref="JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/> structure.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_end_of_job_time_information">JOBOBJECT_END_OF_JOB_TIME_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="JOBOBJECT_ASSOCIATE_COMPLETION_PORT"/>
    /// <seealso cref="JOBOBJECT_BASIC_LIMIT_INFORMATION"/>
    /// <seealso cref="PostQueuedCompletionStatus"/>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_END_OF_JOB_TIME_INFORMATION
    {
        public JOB_OBJECT_END_OF_JOB_FLAGS EndOfJobTimeAction;
    }
}
