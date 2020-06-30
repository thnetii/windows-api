using System;

namespace THNETII.WinApi.Native.WinNT
{
    using static Native.WinError.WinErrorConstants;

    [Flags]
    public enum JOB_OBJECT_END_OF_JOB_FLAGS : int
    {
        /// <summary>
        /// Terminates all processes and sets the exit status to <see cref="ERROR_NOT_ENOUGH_QUOTA"/>. The processes cannot prevent or delay their own termination. The job object is set to the signaled state and remains signaled until this limit is reset. No additional processes can be assigned to the job until the limit is reset. 
        /// <para>This is the default termination action.</para>
        /// </summary>
        JOB_OBJECT_TERMINATE_AT_END_OF_JOB = WinNTConstants.JOB_OBJECT_TERMINATE_AT_END_OF_JOB,
        /// <summary>
        /// Posts a completion packet to the completion port using the <see cref="PostQueuedCompletionStatus"/> function. After the completion packet is posted, the system clears the end-of-job time limit, and processes in the job can continue their execution. 
        /// <para>If no completion port is associated with the job when the time limit has been exceeded, the action taken is the same as for <see cref="JOB_OBJECT_TERMINATE_AT_END_OF_JOB"/>.</para>
        /// </summary>
        JOB_OBJECT_POST_AT_END_OF_JOB = WinNTConstants.JOB_OBJECT_POST_AT_END_OF_JOB,
    }
}
