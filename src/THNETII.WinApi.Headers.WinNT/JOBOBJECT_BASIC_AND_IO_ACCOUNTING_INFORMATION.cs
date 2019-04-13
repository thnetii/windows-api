using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11763
    /// <summary>
    /// Contains basic accounting and I/O accounting information for a job object.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_and_io_accounting_information">JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="IO_COUNTERS"/>
    /// <seealso cref="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION"/>
    /// <seealso cref="QueryInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION
    {
        /// <summary>
        /// A <see cref="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION"/> structure that specifies the basic accounting information for the job.
        /// </summary>
        public JOBOBJECT_BASIC_ACCOUNTING_INFORMATION BasicInfo;
        /// <summary>
        /// An <see cref="IO_COUNTERS"/> structure that specifies the I/O accounting information for the job. The structure includes information for all processes that have ever been associated with the job, in addition to the information for all processes currently associated with the job.
        /// </summary>
        public IO_COUNTERS IoInfo;
    }
}
