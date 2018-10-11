namespace THNETII.WindowsProtocols.WindowsErrorCodes.Constants
{
    public static class WinNTConstants
    {
        public const int APPLICATION_ERROR_MASK = 0x20000000;
        public const int ERROR_SEVERITY_SUCCESS = 0x00000000;
        public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        public const int ERROR_SEVERITY_WARNING = unchecked((int)0x80000000);
        public const int ERROR_SEVERITY_ERROR = unchecked((int)0xC0000000);
    }
}
