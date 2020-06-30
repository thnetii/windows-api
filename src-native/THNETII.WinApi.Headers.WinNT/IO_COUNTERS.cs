using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11488
    /// <summary>
    /// Contains I/O accounting information for a process or a job object. For a job object, the counters include all operations performed by all processes that have ever been associated with the job, in addition to all processes currently associated with the job.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-io_counters">IO_COUNTERS structure</a></para>
    /// </remarks>
    /// <seealso cref="GetProcessIoCounters"/>
    /// <seealso cref="JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct IO_COUNTERS
    {
        /// <summary>The number of read operations performed.</summary>
        public ulong ReadOperationCount;
        /// <summary>The number of write operations performed.</summary>
        public ulong WriteOperationCount;
        /// <summary>The number of I/O operations performed, other than read and write operations.</summary>
        public ulong OtherOperationCount;
        /// <summary>The number of bytes read.</summary>
        public ulong ReadTransferCount;
        /// <summary>The number of bytes written.</summary>
        public ulong WriteTransferCount;
        /// <summary>The number of bytes transferred during operations other than read and write operations.</summary>
        public ulong OtherTransferCount;
    }
}
