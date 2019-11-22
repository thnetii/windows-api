using System;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.AuthZ
{
    public struct AUTHZ_CLIENT_CONTEXT_HANDLE : IPointer
    {
        public IntPtr Pointer { get; }
    }
}
