namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12255
    /// <summary>
    /// Represents the relationship between the processor set identified in the corresponding <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> or <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure.
    /// </summary>
    /// <remarks>
    /// The value specified by this enumeration indicates the relationship represented in the corresponding <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/> or <see cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/> structure.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-_logical_processor_relationship">LOGICAL_PROCESSOR_RELATIONSHIP Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="GetLogicalProcessorInformation"/>
    /// <seealso cref="GetLogicalProcessorInformationEx"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"/>
    public enum LOGICAL_PROCESSOR_RELATIONSHIP
    {
        /// <summary>
        /// The specified logical processors share a single processor core.
        /// </summary>
        RelationProcessorCore,
        /// <summary>
        /// The specified logical processors are part of the same NUMA node.
        /// </summary>
        RelationNumaNode,
        /// <summary>
        /// The specified logical processors share a cache.
        /// <para><strong>Windows Server 2003:</strong> This value is not supported until Windows Server 2003 with SP1 and Windows XP Professional x64 Edition.</para>
        /// </summary>
        RelationCache,
        /// <summary>
        /// The specified logical processors share a physical package (a single package socketed or soldered onto a motherboard may contain multiple processor cores or threads, each of which is treated as a separate processor by the operating system). 
        /// <para><strong>Windows Server 2003:</strong> This value is not supported until Windows Server 2003 with SP1 and Windows XP Professional x64 Edition.</para>
        /// </summary>
        RelationProcessorPackage,
        /// <summary>
        /// The specified logical processors share a single <a href="https://msdn.microsoft.com/c627ac0f-96e8-48b5-9103-4316f487e173">processor group</a>. 
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP Professional x64 Edition:</strong> This value is not supported until Windows Server 2008 R2.</para>
        /// </summary>
        RelationGroup,
        /// <summary>
        /// On input, retrieves information about all possible relationship types. This value is not used on output.
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP Professional x64 Edition:</strong> This value is not supported until Windows Server 2008 R2.</para>
        /// </summary>
        RelationAll = 0xffff
    }
}
