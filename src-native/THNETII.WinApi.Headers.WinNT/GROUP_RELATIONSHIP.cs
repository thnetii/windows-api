using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12329
    /// <summary>
    /// Represents information about processor groups. This structure is used with the <see cref="GetLogicalProcessorInformationEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-group_relationship">GROUP_RELATIONSHIP structure</a></para>
    /// </remarks>
    /// <seealso cref="GetLogicalProcessorInformationEx"/>
    /// <seealso cref="PROCESSOR_GROUP_INFO"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GROUP_RELATIONSHIP
    {
        /// <summary>
        /// The maximum number of processor groups on the system.
        /// </summary>
        public short MaximumGroupCount;
        /// <summary>
        /// The number of active groups on the system. This member indicates the number of <see cref="PROCESSOR_GROUP_INFO"/> structures in the <see cref="GroupInfo"/> member.
        /// </summary>
        public short ActiveGroupCount;
        /// <summary>This member is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved[20];
        #region public PROCESSOR_GROUP_INFO GroupInfo[];
        internal PROCESSOR_GROUP_INFO GroupInfoField;
        /// <summary>
        /// A span of <see cref="PROCESSOR_GROUP_INFO"/> structures. Each structure represents the number and affinity of processors in an active group on the system.
        /// </summary>
        public Span<PROCESSOR_GROUP_INFO> GroupInfo => SpanOverRef.GetSpan(ref GroupInfoField, ActiveGroupCount);
        #endregion
    }
}
