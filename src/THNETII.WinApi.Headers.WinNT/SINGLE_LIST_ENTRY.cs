using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.WinNT
{
    using SLIST_ENTRY = SINGLE_LIST_ENTRY;

    //
    //  Singly linked list structure. Can be used as either a list head, or
    //  as link words.
    //

    /// <summary>
    /// Represents an item in a singly linked list.
    /// </summary>
    /// <remarks>
    /// All list items must be aligned on a <see cref="F:THNETII.WinApi.WinNT.WinNTConstants.MEMORY_ALLOCATION_ALIGNMENT"/> boundary. Unaligned items can cause unpredictable results. See <em>_aligned_malloc</em>.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_single_list_entry">_SINGLE_LIST_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="InitializeSListHead"/>
    /// <seealso cref="InterlockedFlushSList"/>
    /// <seealso cref="InterlockedPopEntrySList"/>
    /// <seealso cref="InterlockedPushEntrySList"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SINGLE_LIST_ENTRY
    {
        /// <summary>
        /// A pointer to an <see cref="SLIST_ENTRY"/> structure that represents the next item in a singly linked list.
        /// </summary>
        public PSINGLE_LIST_ENTRY Next;
    }

    /// <summary>
    /// Stringly typed pointer to a <see cref="SINGLE_LIST_ENTRY"/> structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PSINGLE_LIST_ENTRY : IIntPtr<SINGLE_LIST_ENTRY>
    {
        /// <summary>
        /// Initializes a new typed pointer with the specified pointer to an unspecified type.
        /// </summary>
        /// <param name="ptr">A pointer to an unspecified type.</param>
        public PSINGLE_LIST_ENTRY(IntPtr ptr) => Pointer = ptr;

        /// <inheritdoc />
        public IntPtr Pointer { get; }
    }
}
