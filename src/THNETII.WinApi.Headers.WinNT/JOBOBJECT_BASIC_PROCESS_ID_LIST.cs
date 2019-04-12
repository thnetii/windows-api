using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11732
    /// <summary>
    /// Contains the process identifier list for a job object. If the job is nested, the process identifier list consists of all processes associated with the job and its child jobs.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-jobobject_basic_process_id_list">JOBOBJECT_BASIC_PROCESS_ID_LIST structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryInformationJobObject"/>
    /// <seealso cref="SetInformationJobObject"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_PROCESS_ID_LIST
    {
        /// <summary>
        /// The number of process identifiers to be stored in <see cref="ProcessIdList"/>.
        /// </summary>
        public int NumberOfAssignedProcesses;
        /// <summary>
        /// The number of process identifiers returned in the <see cref="ProcessIdList"/> buffer.
        /// If this number is less than <see cref="NumberOfAssignedProcesses"/>, increase the size of the buffer to accommodate the complete list.
        /// </summary>
        public int NumberOfProcessIdsInList;
        internal UIntPtr ProcessIdListField;
        /// <summary>
        /// A span of process identifiers returned by this call.
        /// </summary>
        public unsafe Span<UIntPtr> ProcessIdList => new Span<UIntPtr>(Unsafe.AsPointer(ref ProcessIdListField), NumberOfProcessIdsInList);
    }
}
