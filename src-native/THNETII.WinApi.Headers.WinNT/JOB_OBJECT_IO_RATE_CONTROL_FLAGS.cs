using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11914
    /// <summary>
    /// Control flags for IO rate control.
    /// </summary>
    [Flags]
    public enum JOB_OBJECT_IO_RATE_CONTROL_FLAGS
    {
        JOB_OBJECT_IO_RATE_CONTROL_ENABLE = 0x1,
        JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME = 0x2,
        JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL = 0x4,
        JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP = 0x8,
        JOB_OBJECT_IO_RATE_CONTROL_VALID_FLAGS = JOB_OBJECT_IO_RATE_CONTROL_ENABLE |
                                                 JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME |
                                                 JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL |
                                                 JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP
    }
}
