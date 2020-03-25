using System;

namespace THNETII.WinApi.Native.AccCtrl
{
    [Flags]
    public enum PROPERTY_ACCESS_FLAGS : int
    {
        /// <summary>
        /// Protects the object or property from inheriting access-control entries.
        /// </summary>
        ACTRL_ACCESS_PROTECTED = AccCtrlConstants.ACTRL_ACCESS_PROTECTED,
    }
}
