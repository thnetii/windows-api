using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10278
    /// <summary>
    /// DS values for Level
    /// </summary>
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32", Justification = nameof(OBJECT_TYPE_LIST.Level))]
    public enum OBJECT_TYPE_LEVEL : short
    {
        /// <summary>Indicates the object itself at level zero.</summary>
        ACCESS_OBJECT_GUID = WinNTConstants.ACCESS_OBJECT_GUID,
        /// <summary> Indicates a property set at level one.</summary>
        ACCESS_PROPERTY_SET_GUID = WinNTConstants.ACCESS_PROPERTY_SET_GUID,
        /// <summary>Indicates a property at level two.</summary>
        ACCESS_PROPERTY_GUID = WinNTConstants.ACCESS_PROPERTY_GUID,

        /// <summary></summary>
        ACCESS_MAX_LEVEL = WinNTConstants.ACCESS_MAX_LEVEL,
    }
}
