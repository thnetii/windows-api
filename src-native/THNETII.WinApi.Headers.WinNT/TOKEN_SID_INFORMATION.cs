using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10899
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_SID_INFORMATION
    {
        public IntPtr Sid;

        public SecurityIdentifier MarshalSidToManaged() =>
            SID.MarshalToManagedSid(Sid);
    }
}
