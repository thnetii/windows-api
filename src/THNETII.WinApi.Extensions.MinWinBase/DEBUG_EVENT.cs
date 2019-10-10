using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 357
    /// <summary>
    /// Describes a debugging event.
    /// </summary>
    /// <remarks>
    /// If the <see cref="WaitForDebugEvent"/> function succeeds, it fills in the members of a <see cref="DEBUG_EVENT"/> structure.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-debug_event">DEBUG_EVENT structure</a></para>
    /// </remarks>
    /// <seealso cref="CREATE_PROCESS_DEBUG_INFO"/>
    /// <seealso cref="CREATE_THREAD_DEBUG_INFO"/>
    /// <seealso cref="EXCEPTION_DEBUG_INFO"/>
    /// <seealso cref="EXIT_PROCESS_DEBUG_INFO"/>
    /// <seealso cref="EXIT_THREAD_DEBUG_INFO"/>
    /// <seealso cref="LOAD_DLL_DEBUG_INFO"/>
    /// <seealso cref="OUTPUT_DEBUG_STRING_INFO"/>
    /// <seealso cref="UNLOAD_DLL_DEBUG_INFO"/>
    /// <seealso cref="WaitForDebugEvent"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct DEBUG_EVENT
    {
        /// <summary>
        /// The code that identifies the type of debugging event.
        /// </summary>
        public DEBUG_EVENT_CODE dwDebugEventCode;
        /// <summary>
        /// The identifier of the process in which the debugging event occurred. A debugger uses this value to locate the debugger's per-process structure. These values are not necessarily small integers that can be used as table indices.
        /// </summary>
        public int dwProcessId;
        /// <summary>
        /// The identifier of the thread in which the debugging event occurred. A debugger uses this value to locate the debugger's per-thread structure. These values are not necessarily small integers that can be used as table indices.
        /// </summary>
        public int dwThreadId;

        [StructLayout(LayoutKind.Explicit)]
        internal struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public EXCEPTION_DEBUG_INFO Exception;
            [FieldOffset(0)]
            public CREATE_THREAD_DEBUG_INFO CreateThread;
            [FieldOffset(0)]
            public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;
            [FieldOffset(0)]
            public EXIT_THREAD_DEBUG_INFO ExitThread;
            [FieldOffset(0)]
            public EXIT_PROCESS_DEBUG_INFO ExitProcess;
            [FieldOffset(0)]
            public LOAD_DLL_DEBUG_INFO LoadDll;
            [FieldOffset(0)]
            public UNLOAD_DLL_DEBUG_INFO UnloadDll;
            [FieldOffset(0)]
            public OUTPUT_DEBUG_STRING_INFO DebugString;
            [FieldOffset(0)]
            public RIP_INFO RipInfo;
        }
        /// <summary>
        /// Any additional information relating to the debugging event. This union takes on the type and value appropriate to the type of debugging event, as described in the <see cref="dwDebugEventCode"/> member.
        /// </summary>
        internal DUMMYUNIONNAME u;
        /// <inheritdoc cref="DEBUG_EVENT_CODE.EXCEPTION_DEBUG_EVENT"/> 
        public ref EXCEPTION_DEBUG_INFO Exception => ref SpanOverRef.GetSpan(ref u.Exception)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.CREATE_THREAD_DEBUG_EVENT"/>
        public ref CREATE_THREAD_DEBUG_INFO CreateThread => ref SpanOverRef.GetSpan(ref u.CreateThread)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.CREATE_PROCESS_DEBUG_EVENT"/>
        public ref CREATE_PROCESS_DEBUG_INFO CreateProcessInfo => ref SpanOverRef.GetSpan(ref u.CreateProcessInfo)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.EXIT_THREAD_DEBUG_EVENT"/>
        public ref EXIT_THREAD_DEBUG_INFO ExitThread => ref SpanOverRef.GetSpan(ref u.ExitThread)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.EXIT_PROCESS_DEBUG_EVENT"/>
        public ref EXIT_PROCESS_DEBUG_INFO ExitProcess => ref SpanOverRef.GetSpan(ref u.ExitProcess)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.LOAD_DLL_DEBUG_EVENT"/>
        public ref LOAD_DLL_DEBUG_INFO LoadDll => ref SpanOverRef.GetSpan(ref u.LoadDll)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.UNLOAD_DLL_DEBUG_EVENT"/>
        public ref UNLOAD_DLL_DEBUG_INFO UnloadDll => ref SpanOverRef.GetSpan(ref u.UnloadDll)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.OUTPUT_DEBUG_STRING_EVENT"/>
        public ref OUTPUT_DEBUG_STRING_INFO DebugString => ref SpanOverRef.GetSpan(ref u.DebugString)[0];
        /// <inheritdoc cref="DEBUG_EVENT_CODE.RIP_EVENT"/>
        public ref RIP_INFO RipInfo => ref SpanOverRef.GetSpan(ref u.RipInfo)[0];
    }
}
