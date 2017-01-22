using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Specifies the class of heap information to be set or retrieved. 
    /// </summary>
    /// <remarks>
    /// <para>To retrieve information about a heap, use the <see cref="HeapQueryInformation"/> function. To enable features for a heap, use the <see cref="HeapSetInformation"/> function.</para>
    /// <para><strong>Windows XP and Windows Server 2003: </strong></para>
    /// <para>A look-aside list is a fast memory allocation mechanism that contains only fixed-sized blocks. Look-aside lists are enabled by default for heaps that support them. Starting with Windows Vista, look-aside lists are not used and the LFH is enabled by default.</para>
    /// <para>Look-aside lists are faster than general pool allocations that vary in size, because the system does not search for free memory that fits the allocation. In addition, access to look-aside lists is generally synchronized using fast atomic processor exchange instructions instead of mutexes or spinlocks. Look-aside lists can be created by the system or drivers. They can be allocated from paged or nonpaged pool. </para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dn280633.aspx">HEAP_INFORMATION_CLASS enumeration</a></para>
    /// </remarks>
    /// <seealso cref="HeapQueryInformation"/>
    /// <seealso cref="HeapSetInformation"/>
    public enum HEAP_INFORMATION_CLASS
    {
        /// <summary>
        /// The heap features that are enabled. The available features vary based on operating system. Depending on the <em>HeapInformation</em> parameter in the <see cref="HeapQueryInformation"/> or <see cref="HeapSetInformation"/> functions, specifying this enumeration value can indicate one of the following features:
        /// <list type="bullet">
        /// <item>A standard heap that does not support look-aside lists.</item>
        /// <item>A heap that supports look-aside lists.</item>
        /// <item>A <a href="https://msdn.microsoft.com/en-us/library/aa366750.aspx">low-fragmentation heap</a> (LFH), which does not support look-aside lists.</item>
        /// </list>
        /// For more information about look-aside lists, see the Remarks section.
        /// </summary>
        HeapCompatibilityInformation = 0,
        /// <summary>
        /// <para>The terminate-on-corruption feature. If the heap manager detects an error in any heap used by the process, it calls the Windows Error Reporting service and terminates the process.</para>
        /// <para>After a process enables this feature, it cannot be disabled.</para>
        /// </summary>
        HeapEnableTerminationOnCorruption = 1
    }
}
