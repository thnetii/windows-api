using System;

namespace THNETII.WinApi.Native.Sspi
{
    public static class SspiRuntimeConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 146
        //
        // pseudo handle value: the handle has already been deleted
        //

        public static readonly UIntPtr SEC_DELETED_HANDLE =
            new UIntPtr(unchecked((uint)-2));
    }
}
