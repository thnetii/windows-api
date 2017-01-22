using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.SystemServices.MemoryManagement.MemoryManagementFunctions;

namespace Microsoft.Win32.WinApi.SystemServices.MemoryManagement
{
    /// <summary>
    /// Specifies flags for a HeapOptimizeResources operation initiated with <see cref="HeapSetInformation"/>.
    /// </summary>
    /// <remarks>
    /// <para>Mandatory parameter to the HeapOptimizeResources class.</para>
    /// <para>The <see cref="HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION"/> constant is available to fill in the <see cref="Version"/> field of the <see cref="HEAP_OPTIMIZE_RESOURCES_INFORMATION"/> structure. The only legal value for this field is currently 1. </para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dn872745.aspx">HEAP_OPTIMIZE_RESOURCES_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="PrefetchVirtualMemory"/>
    [StructLayout(LayoutKind.Sequential)]
    public class HEAP_OPTIMIZE_RESOURCES_INFORMATION
    {
        /// <summary/>
        public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;

        /// <summary/>
        public int Version;
        /// <summary/>
        public int Flags;
    }
}
