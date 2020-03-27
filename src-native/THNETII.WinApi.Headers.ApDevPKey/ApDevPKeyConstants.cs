using THNETII.WinApi.Native.DevPropDef;

namespace THNETII.WinApi.Native.ApDevPKey
{
    using static DevPropDefMacros;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\apdevpkey.h
    /// <summary>
    /// Defines Plug and Play Device property keys used for AutoPlay behavior.
    /// </summary>
    public static class ApDevPKeyConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\apdevpkey.h, line 29
        /// <summary>
        /// Indicate that AutoPlay should not be displayed for this device interface.
        /// <para><see cref="DEVPROPTYPE.DEVPROP_TYPE_BOOLEAN"/></para>
        /// </summary>
        public static readonly DEVPROPKEY DEVPKEY_DeviceInterface_Autoplay_Silent =
            DEFINE_DEVPROPKEY(0x434dd28f, unchecked((short)0x9e75), 0x450a, 0x9a, 0xb9, 0xff, 0x61, 0xe6, 0x18, 0xba, 0xd0, 2);  // DEVPROP_TYPE_BOOLEAN
    }
}
