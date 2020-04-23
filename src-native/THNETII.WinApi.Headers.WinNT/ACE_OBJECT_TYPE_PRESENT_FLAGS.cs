using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum ACE_OBJECT_TYPE_PRESENT_FLAGS : int
    {
        ACE_OBJECT_TYPE_PRESENT = WinNTConstants.ACE_OBJECT_TYPE_PRESENT,
        ACE_INHERITED_OBJECT_TYPE_PRESENT = WinNTConstants.ACE_INHERITED_OBJECT_TYPE_PRESENT,
    }
}
