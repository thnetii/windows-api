#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace THNETII.WinApiNative.WinNT
{
    public static class WinNTConstants
    {
        #region Lines 750-754
        public const int APPLICATION_ERROR_MASK = 0x20000000;
        public const int ERROR_SEVERITY_SUCCESS = 0x00000000;
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        public const int ERROR_SEVERITY_WARNING = unchecked((int)0x80000000);
        public const int ERROR_SEVERITY_ERROR = unchecked((int)0xC0000000);
        #endregion
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
