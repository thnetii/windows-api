using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTRuntimeConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19163
    /// <summary>
    /// Represents an item in a singly linked list.
    /// </summary>
    /// <remarks>
    /// <para>All list items must be aligned on a <see cref="MEMORY_ALLOCATION_ALIGNMENT"/> boundary. Unaligned items can cause unpredictable results.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-slist_entry">SLIST_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="InitializeSListHead"/>
    /// <seealso cref="InterlockedFlushSList"/>
    /// <seealso cref="InterlockedPopEntrySList"/>
    /// <seealso cref="InterlockedPushEntrySList"/>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public unsafe struct SLIST_ENTRY
    {
        /// <summary>
        /// A pointer to an <see cref="SLIST_ENTRY"/> structure that represents the next item in a singly linked list.
        /// </summary>
        public SLIST_ENTRY* Next;
    }
}
