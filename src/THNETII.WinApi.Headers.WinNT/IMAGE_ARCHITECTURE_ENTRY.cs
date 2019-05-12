using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18430
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_ARCHITECTURE_ENTRY
    {
        /// <summary>
        /// RVA of instruction to fixup
        /// </summary>
        public int FixupInstRVA;
        /// <summary>
        /// fixup instruction (see alphaops.h)
        /// </summary>
        public int NewInst;
    }
}
