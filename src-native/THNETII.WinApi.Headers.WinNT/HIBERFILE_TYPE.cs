using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16122
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32")]
    public enum HIBERFILE_TYPE : byte
    {
        HIBERFILE_TYPE_NONE = WinNTConstants.HIBERFILE_TYPE_NONE,
        HIBERFILE_TYPE_REDUCED = WinNTConstants.HIBERFILE_TYPE_REDUCED,
        HIBERFILE_TYPE_FULL = WinNTConstants.HIBERFILE_TYPE_FULL,
        HIBERFILE_TYPE_MAX = WinNTConstants.HIBERFILE_TYPE_MAX,
    }
}
