using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11219
    /// <summary>
    /// Base signing levels.
    /// </summary>
    [SuppressMessage("Design", "CA1028:" + "Enum Storage should be Int32", Justification = @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11223")]
    public enum SE_SIGNING_LEVEL : byte
    {
        SE_SIGNING_LEVEL_UNCHECKED = WinNTConstants.SE_SIGNING_LEVEL_UNCHECKED,
        SE_SIGNING_LEVEL_UNSIGNED = WinNTConstants.SE_SIGNING_LEVEL_UNSIGNED,
        SE_SIGNING_LEVEL_ENTERPRISE = WinNTConstants.SE_SIGNING_LEVEL_ENTERPRISE,
        SE_SIGNING_LEVEL_CUSTOM_1 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_1,
        SE_SIGNING_LEVEL_AUTHENTICODE = WinNTConstants.SE_SIGNING_LEVEL_AUTHENTICODE,
        SE_SIGNING_LEVEL_CUSTOM_2 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_2,
        SE_SIGNING_LEVEL_STORE = WinNTConstants.SE_SIGNING_LEVEL_STORE,
        SE_SIGNING_LEVEL_CUSTOM_3 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_3,
        SE_SIGNING_LEVEL_ANTIMALWARE = WinNTConstants.SE_SIGNING_LEVEL_ANTIMALWARE,
        SE_SIGNING_LEVEL_MICROSOFT = WinNTConstants.SE_SIGNING_LEVEL_MICROSOFT,
        SE_SIGNING_LEVEL_CUSTOM_4 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_4,
        SE_SIGNING_LEVEL_CUSTOM_5 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_5,
        SE_SIGNING_LEVEL_DYNAMIC_CODEGEN = WinNTConstants.SE_SIGNING_LEVEL_DYNAMIC_CODEGEN,
        SE_SIGNING_LEVEL_WINDOWS = WinNTConstants.SE_SIGNING_LEVEL_WINDOWS,
        SE_SIGNING_LEVEL_CUSTOM_7 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_7,
        SE_SIGNING_LEVEL_WINDOWS_TCB = WinNTConstants.SE_SIGNING_LEVEL_WINDOWS_TCB,
        SE_SIGNING_LEVEL_CUSTOM_6 = WinNTConstants.SE_SIGNING_LEVEL_CUSTOM_6,
    }
}
