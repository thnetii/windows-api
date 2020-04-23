using System.Runtime.InteropServices;


namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8992
    /// <summary>
    /// Union which can hold any valid sid.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct SE_SID
    {
        [FieldOffset(0)]
        public SID Sid;
        [FieldOffset(0)]
        public fixed byte Buffer[SECURITY_MAX_SID_SIZE];
    }
}
