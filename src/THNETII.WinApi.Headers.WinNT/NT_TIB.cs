using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11353
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NT_TIB
    {
        public EXCEPTION_REGISTRATION_RECORD* ExceptionList;
        public IntPtr StackBase;
        public IntPtr StackLimit;
        public IntPtr SubSystemTib;
        public IntPtr FiberData;
        public int Version
        {
            get
            {
                fixed (IntPtr* pFiberData = &FiberData)
                {
                    ReadOnlySpan<IntPtr> spanFiberData = new ReadOnlySpan<IntPtr>(pFiberData, 1);
                    return MemoryMarshal.Read<int>(MemoryMarshal.AsBytes(spanFiberData));
                }
            }
            set => FiberData = new IntPtr(value);
        }
        public IntPtr ArbitraryUserPointer;
        public NT_TIB* Self;
    }
}
