using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static MEM_FLAGS;
    using static MEM_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12601
    /// <summary>
    /// Contains information about a range of pages in the virtual address space of a process. The <see cref="VirtualQuery"/> and <see cref="VirtualQueryEx"/> functions use this structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-memory_basic_information">MEMORY_BASIC_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="VirtualAlloc"/>
    /// <seealso cref="VirtualQuery"/>
    /// <seealso cref="VirtualQueryEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        /// <summary>
        /// A pointer to the base address of the region of pages.
        /// </summary>
        public IntPtr BaseAddress;
        /// <summary>
        /// A pointer to the base address of a range of pages allocated by the <see cref="VirtualAlloc"/> function. The page pointed to by the <see cref="BaseAddress"/> member is contained within this allocation range.
        /// </summary>
        public IntPtr AllocationBase;
        /// <summary>
        /// The memory protection option when the region was initially allocated. This member can be one of the memory protection constants or <c>default</c> if the caller does not have access.
        /// </summary>
        public PAGE_FLAGS AllocationProtect;
        /// <summary>
        /// The size of the region beginning at the base address in which all pages have identical attributes, in bytes.
        /// </summary>
        public UIntPtr RegionSize;
        /// <summary>
        /// The state of the pages in the region.
        /// </summary>
        /// <value>
        /// This member can be one of the following values.
        /// <list type="table">
        /// <listheader><term>State</term><description>Meaning</description></listheader>
        /// <item><term><see cref="MEM_COMMIT"/></term><description>Indicates committed pages for which physical storage has been allocated, either in memory or in the paging file on disk.</description></item>
        /// <item><term><see cref="MEM_FREE"/></term><description>Indicates free pages not accessible to the calling process and available to be allocated. For free pages, the information in the <see cref="AllocationBase"/>, <see cref="AllocationProtect"/>, <see cref="Protect"/>, and <see cref="Type"/> members is undefined.</description></item>
        /// <item><term><see cref="MEM_RESERVE"/></term><description>Indicates reserved pages where a range of the process's virtual address space is reserved without any physical storage being allocated. For reserved pages, the information in the <see cref="Protect"/> member is undefined.</description></item>
        /// </list>
        /// </value>
        public MEM_FLAGS State;
        /// <summary>
        /// The access protection of the pages in the region. This member is one of the values listed for the <see cref="AllocationProtect"/> member.
        /// </summary>
        public PAGE_FLAGS Protect;
        /// <summary>
        /// The type of pages in the region.
        /// </summary>
        /// <value>
        /// The following types are defined.
        /// <list type="table">
        /// <listheader><term>Type</term><description>Meaning</description></listheader>
        /// <item><term><see cref="MEM_IMAGE"/></term><description>Indicates that the memory pages within the region are mapped into the view of an image section. </description></item>
        /// <item><term><see cref="MEM_MAPPED"/></term><description>Indicates that the memory pages within the region are mapped into the view of a section. </description></item>
        /// <item><term><see cref="MEM_PRIVATE"/></term><description>Indicates that the memory pages within the region are private (that is, not shared by other processes). </description></item>
        /// </list>
        /// </value>
        public MEM_TYPE Type;
    }

    /// <inheritdoc cref="MEMORY_BASIC_INFORMATION"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION32
    {
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.BaseAddress"/>
        public uint BaseAddress;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.AllocationBase"/>
        public uint AllocationBase;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.AllocationProtect"/>
        public PAGE_FLAGS AllocationProtect;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.RegionSize"/>
        public uint RegionSize;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.State"/>
        public MEM_FLAGS State;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.Protect"/>
        public PAGE_FLAGS Protect;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.Type"/>
        public MEM_TYPE Type;
    }

    /// <inheritdoc cref="MEMORY_BASIC_INFORMATION"/>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct MEMORY_BASIC_INFORMATION64
    {
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.BaseAddress"/>
        public ulong BaseAddress;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.AllocationBase"/>
        public ulong AllocationBase;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.AllocationProtect"/>
        public PAGE_FLAGS AllocationProtect;
        internal int __alignment1;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.RegionSize"/>
        public ulong RegionSize;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.State"/>
        public MEM_FLAGS State;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.Protect"/>
        public PAGE_FLAGS Protect;
        /// <inheritdoc cref="MEMORY_BASIC_INFORMATION.Type"/>
        public MEM_TYPE Type;
        internal int __alignment2;
    }
}
