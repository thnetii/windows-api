using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int OUT_OF_PROCESS_FUNCTION_TABLE_AMD64_CALLBACK(
            [In] IntPtr Process,
            [In] IntPtr TableAddress,
            out int Entries,
            out IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* Functions
        );

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int OUT_OF_PROCESS_FUNCTION_TABLE_ARM_CALLBACK(
        [In] IntPtr Process,
        [In] IntPtr TableAddress,
        out int Entries,
        out IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* Functions
    );

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int OUT_OF_PROCESS_FUNCTION_TABLE_ARM64_CALLBACK(
        [In] IntPtr Process,
        [In] IntPtr TableAddress,
        out int Entries,
        out IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* Functions
    );
}
