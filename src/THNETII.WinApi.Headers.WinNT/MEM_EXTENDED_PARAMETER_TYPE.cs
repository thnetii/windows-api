namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12737
    /// <summary>
    /// Defines values for extended parameters used for file mapping into an address space.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-mem_extended_parameter_type">MEM_EXTENDED_PARAMETER_TYPE Enumeration</a></para>
    /// </remarks>
    public enum MEM_EXTENDED_PARAMETER_TYPE
    {
        MemExtendedParameterInvalidType = 0,
        /// <summary>
        /// This extended parameter type is used to specify alignment and virtual address range restrictions for new memory allocations created by <see cref="VirtualAlloc2"/> and <see cref="MapViewOfFile3"/>.
        /// </summary>
        MemExtendedParameterAddressRequirements,
        /// <summary>
        /// This extended parameter type is used to specify the preferred NUMA node for new memory allocations created by <see cref="VirtualAlloc2"/> and <see cref="MapViewOfFile3"/>.
        /// </summary>
        MemExtendedParameterNumaNode,
        MemExtendedParameterPartitionHandle,
        MemExtendedParameterMax
    }
}
