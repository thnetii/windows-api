using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11346
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EXCEPTION_REGISTRATION_RECORD
    {
        public EXCEPTION_REGISTRATION_RECORD* Next;
        public IntPtr HandlerPtr;
        public EXCEPTION_ROUTINE Handler
        {
            get
            {
                var ptr = HandlerPtr;
                if (ptr == IntPtr.Zero)
                    return null;
                return Marshal.GetDelegateForFunctionPointer<EXCEPTION_ROUTINE>(HandlerPtr);
            }
            set => HandlerPtr = value is null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
        }
    }
}
