using System;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Sspi
{
    public struct CredHandle : IPointer
    {
        public IntPtr Pointer { get; }
    }
}
