using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate
        ref IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY
        GET_RUNTIME_FUNCTION_AMD64_CALLBACK(
            [In] long ControlPc,
            [In, Optional] void* Context
        );

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate
        ref IMAGE_ARM_RUNTIME_FUNCTION_ENTRY
        GET_RUNTIME_FUNCTION_ARM_CALLBACK(
            [In] int ControlPc,
            [In, Optional] void* Context
        );

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate
        ref IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY
        GET_RUNTIME_FUNCTION_ARM64_CALLBACK(
            [In] long ControlPc,
            [In, Optional] void* Context
        );
}
