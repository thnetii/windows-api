using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10720
    [StructLayout(LayoutKind.Sequential)]
    public struct SE_TOKEN_USER
    {
        [StructLayout(LayoutKind.Explicit)]
        internal struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            internal TOKEN_USER TokenUser;
            [FieldOffset(0)]
            internal SID_AND_ATTRIBUTES User;
        }
        internal DUMMYUNIONNAME u;
        public ref TOKEN_USER TokenUser => ref SpanOverRef.GetSpan(ref u.TokenUser)[0];
        public ref SID_AND_ATTRIBUTES User => ref SpanOverRef.GetSpan(ref u.User)[0];

        public SE_SID Sid;
    }
}
