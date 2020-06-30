namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12266
    /// <summary>
    /// Represents the type of processor cache identified in the corresponding <see cref="CACHE_DESCRIPTOR"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-_processor_cache_type">PROCESSOR_CACHE_TYPE Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="CACHE_DESCRIPTOR"/>
    /// <seealso cref="GetLogicalProcessorInformation"/>
    /// <seealso cref="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"/>
    public enum PROCESSOR_CACHE_TYPE
    {
        /// <summary>The cache is unified.</summary>
        CacheUnified,
        /// <summary>The cache is for processor instructions.</summary>
        CacheInstruction,
        /// <summary>The cache is for data.</summary>
        CacheData,
        /// <summary>The cache is for traces.</summary>
        CacheTrace
    }
}
