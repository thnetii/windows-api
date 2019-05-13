using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate
        ref IMAGE_IA64_RUNTIME_FUNCTION_ENTRY
        GET_RUNTIME_FUNCTION_CALLBACK(
            [In] long ControlPc,
            [In, Optional] void* Context
        );
}
