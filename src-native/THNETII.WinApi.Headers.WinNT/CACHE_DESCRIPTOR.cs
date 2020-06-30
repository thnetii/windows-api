using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12275
    /// <summary>
    /// Describes the cache attributes.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-cache_descriptor">CACHE_DESCRIPTOR structure</a></para>
    /// </remarks>
    /// <seealso cref="GetLogicalProcessorInformation"/>
    /// <seealso cref="PROCESSOR_CACHE_TYPE"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct CACHE_DESCRIPTOR
    {
        /// <summary>The cache level.</summary>
        /// <value>
        /// This member can currently be one of the following values; other values may be supported in the future.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><c>1</c></term><description>L1</description></item>
        /// <item><term><c>2</c></term><description>L2</description></item>
        /// <item><term><c>3</c></term><description>L3</description></item>
        /// </list>
        /// </value>
        public byte Level;
        /// <summary>
        /// The cache associativity. If this member is <see cref="CACHE_FULLY_ASSOCIATIVE"/> (<c>0xFF</c>), the cache is fully associative.
        /// </summary>
        public byte Associativity;
        /// <summary>
        /// The cache line size, in bytes.
        /// </summary>
        public short LineSize;
        /// <summary>
        /// The cache size, in bytes.
        /// </summary>
        public int Size;
        /// <summary>
        /// The cache type. This member is a <see cref="PROCESSOR_CACHE_TYPE"/> value.
        /// </summary>
        public PROCESSOR_CACHE_TYPE Type;
    }
}
