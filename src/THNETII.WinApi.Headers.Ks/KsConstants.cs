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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 96
        public const int KSMETHOD_TYPE_NONE = 0x00000000;
        public const int KSMETHOD_TYPE_READ = 0x00000001;
        public const int KSMETHOD_TYPE_WRITE = 0x00000002;
        public const int KSMETHOD_TYPE_MODIFY = 0x00000003;
        public const int KSMETHOD_TYPE_SOURCE = 0x00000004;

        public const int KSMETHOD_TYPE_SEND = 0x00000001;
        public const int KSMETHOD_TYPE_SETSUPPORT = 0x00000100;
        public const int KSMETHOD_TYPE_BASICSUPPORT = 0x00000200;

        public const int KSMETHOD_TYPE_TOPOLOGY = 0x10000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\ks.h, line 135
        public const int KSPROPERTY_TYPE_GET = 0x00000001;
        public const int KSPROPERTY_TYPE_SET = 0x00000002;
        public const int KSPROPERTY_TYPE_GETPAYLOADSIZE = 0x00000004;
        public const int KSPROPERTY_TYPE_SETSUPPORT = 0x00000100;
        public const int KSPROPERTY_TYPE_BASICSUPPORT = 0x00000200;
        public const int KSPROPERTY_TYPE_RELATIONS = 0x00000400;
        public const int KSPROPERTY_TYPE_SERIALIZESET = 0x00000800;
        public const int KSPROPERTY_TYPE_UNSERIALIZESET = 0x00001000;
        public const int KSPROPERTY_TYPE_SERIALIZERAW = 0x00002000;
        public const int KSPROPERTY_TYPE_UNSERIALIZERAW = 0x00004000;
        public const int KSPROPERTY_TYPE_SERIALIZESIZE = 0x00008000;
        public const int KSPROPERTY_TYPE_DEFAULTVALUES = 0x00010000;

        public const int KSPROPERTY_TYPE_TOPOLOGY = 0x10000000;
        public const int KSPROPERTY_TYPE_HIGHPRIORITY = 0x08000000;
        public const int KSPROPERTY_TYPE_FSFILTERSCOPE = 0x40000000;
        public const int KSPROPERTY_TYPE_COPYPAYLOAD = unchecked((int)0x80000000);
    }
}
