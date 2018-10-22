using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory.Specialized;

namespace THNETII.WinApi.Native.WinNT
{
    public static class WinNTFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18578
        #region RtlCaptureStackBackTrace function
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi)]
        public static extern ushort RtlCaptureStackBackTrace(
            [In] int FramesToSkip,
            [In] int FramesToCapture,
            out ArrayOfIntPtr BackTrace,
            [Optional] out int BackTraceHash
            );
        #endregion
    }
}
