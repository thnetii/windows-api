using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 603
    //
    // Structure to represent a group-specific affinity, such as that of a
    // thread.  Specifies the group number and the affinity within that group.
    //

    /// <summary>
    /// Represents a processor group-specific affinity, such as the affinity of a thread.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_group_affinity">_GROUP_AFFINITY structure</a></para>
    /// </remarks>
    /// <seealso cref="CACHE_RELATIONSHIP"/>
    /// <seealso cref="NUMA_NODE_RELATIONSHIP"/>
    /// <seealso cref="PROCESSOR_RELATIONSHIP"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GROUP_AFFINITY
    {
        /// <summary>
        /// A bitmap that specifies the affinity for zero or more processors within the specified group.
        /// </summary>
        [MarshalAs(UnmanagedType.SysUInt)]
        public UIntPtr Mask;
        /// <summary>The processor group number.</summary>
        public short Group;
        /// <summary>This member is reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed short Reserved[3];
    }
}
