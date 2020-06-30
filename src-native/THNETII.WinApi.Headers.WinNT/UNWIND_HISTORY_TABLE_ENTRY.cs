using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 3970
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_ENTRY_AMD64
    {
        internal const int SizeOf = sizeof(long) * 2;

        public long ImageBase;
        public IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4963
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_ENTRY_ARM
    {
        internal const int SizeOf = sizeof(int) * 2;

        public int ImageBase;
        public IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 6149
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UNWIND_HISTORY_TABLE_ENTRY_ARM64
    {
        internal const int SizeOf = sizeof(long) * 2;

        public long ImageBase;
        public IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
    }
}
