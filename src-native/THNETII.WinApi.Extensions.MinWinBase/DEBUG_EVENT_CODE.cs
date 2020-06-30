namespace THNETII.WinApi.Native.MinWinBase
{
    public enum DEBUG_EVENT_CODE : int
    {
        /// <summary>
        /// Reports an exception debugging event. The value of <see cref="DEBUG_EVENT.Exception"/> specifies an <see cref="EXCEPTION_DEBUG_INFO"/> structure. 
        /// </summary>
        EXCEPTION_DEBUG_EVENT = MinWinBaseConstants.EXCEPTION_DEBUG_EVENT,
        /// <summary>
        /// Reports a create-thread debugging event. The value of <see cref="DEBUG_EVENT.CreateThread"/> specifies a <see cref="CREATE_THREAD_DEBUG_INFO"/> structure.
        /// </summary>
        CREATE_THREAD_DEBUG_EVENT = MinWinBaseConstants.CREATE_THREAD_DEBUG_EVENT,
        /// <summary>
        ///  Reports a create-process debugging event. The value of <see cref="DEBUG_EVENT.CreateProcessInfo"/> specifies a <see cref="CREATE_PROCESS_DEBUG_INFO"/> structure.
        /// </summary>
        CREATE_PROCESS_DEBUG_EVENT = MinWinBaseConstants.CREATE_PROCESS_DEBUG_EVENT,
        /// <summary>
        /// Reports an exit-thread debugging event. The value of <see cref="DEBUG_EVENT.ExitThread"/> specifies an <see cref="EXIT_THREAD_DEBUG_INFO"/> structure.
        /// </summary>
        EXIT_THREAD_DEBUG_EVENT = MinWinBaseConstants.EXIT_THREAD_DEBUG_EVENT,
        /// <summary>
        /// Reports an exit-process debugging event. The value of <see cref="DEBUG_EVENT.ExitProcess"/> specifies an <see cref="EXIT_PROCESS_DEBUG_INFO"/> structure. 
        /// </summary>
        EXIT_PROCESS_DEBUG_EVENT = MinWinBaseConstants.EXIT_PROCESS_DEBUG_EVENT,
        /// <summary>
        /// Reports a load-dynamic-link-library (DLL) debugging event. The value of <see cref="DEBUG_EVENT.LoadDll"/> specifies a <see cref="LOAD_DLL_DEBUG_INFO"/> structure.
        /// </summary>
        LOAD_DLL_DEBUG_EVENT = MinWinBaseConstants.LOAD_DLL_DEBUG_EVENT,
        /// <summary>
        /// Reports an unload-DLL debugging event. The value of <see cref="DEBUG_EVENT.UnloadDll"/> specifies an <see cref="UNLOAD_DLL_DEBUG_INFO"/> structure.
        /// </summary>
        UNLOAD_DLL_DEBUG_EVENT = MinWinBaseConstants.UNLOAD_DLL_DEBUG_EVENT,
        /// <summary>
        /// Reports an output-debugging-string debugging event. The value of <see cref="DEBUG_EVENT.DebugString"/> specifies an <see cref="OUTPUT_DEBUG_STRING_INFO"/> structure.
        /// </summary>
        OUTPUT_DEBUG_STRING_EVENT = MinWinBaseConstants.OUTPUT_DEBUG_STRING_EVENT,
        /// <summary>
        /// Reports a RIP-debugging event (system debugging error). The value of <see cref="DEBUG_EVENT.RipInfo"/> specifies a <see cref="RIP_INFO"/> structure.
        /// </summary>
        RIP_EVENT = MinWinBaseConstants.RIP_EVENT,
    }
}
