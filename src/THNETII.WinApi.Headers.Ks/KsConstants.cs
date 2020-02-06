using System;

using THNETII.WinApi.Native.WinIOCtl;

namespace THNETII.WinApi.Native.Ks
{
    using static WinIOCtlConstants;
    using static WinIOCtlFunctions;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h
    /// <summary>
    /// Windows Driver Model/Connection and Streaming Architecture (WDM-CSA)
    /// core definitions.
    /// </summary>
    public static class KsConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 62
        public static readonly Guid GUID_NULL = Guid.Parse("00000000-0000-0000-0000-000000000000");

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 72
        //===========================================================================

        public static readonly int IOCTL_KS_PROPERTY = CTL_CODE(FILE_DEVICE_KS, 0x000, METHOD_NEITHER, FILE_ANY_ACCESS);
        public static readonly int IOCTL_KS_ENABLE_EVENT = CTL_CODE(FILE_DEVICE_KS, 0x001, METHOD_NEITHER, FILE_ANY_ACCESS);
        public static readonly int IOCTL_KS_DISABLE_EVENT = CTL_CODE(FILE_DEVICE_KS, 0x002, METHOD_NEITHER, FILE_ANY_ACCESS);
        public static readonly int IOCTL_KS_METHOD = CTL_CODE(FILE_DEVICE_KS, 0x003, METHOD_NEITHER, FILE_ANY_ACCESS);
        public static readonly int IOCTL_KS_WRITE_STREAM = CTL_CODE(FILE_DEVICE_KS, 0x004, METHOD_NEITHER, FILE_WRITE_ACCESS);
        public static readonly int IOCTL_KS_READ_STREAM = CTL_CODE(FILE_DEVICE_KS, 0x005, METHOD_NEITHER, FILE_READ_ACCESS);
        public static readonly int IOCTL_KS_RESET_STATE = CTL_CODE(FILE_DEVICE_KS, 0x006, METHOD_NEITHER, FILE_ANY_ACCESS);

        //===========================================================================

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 96
        public const int KSPRIORITY_LOW = 0x00000001;
        public const int KSPRIORITY_NORMAL = 0x40000000;
        public const int KSPRIORITY_HIGH = unchecked((int)0x80000000);
        public const int KSPRIORITY_EXCLUSIVE = unchecked((int)0xFFFFFFFF);
    }
}
