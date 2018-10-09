namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// Win32 System Error and <see cref="NTSTATUS"/> Severity Code.
    /// </summary>
    public enum StatusSeverity
    {
        /// <summary>Success</summary>
        Success = 0b00,

        /// <summary>Informational</summary>
        Informational = 0b01,

        /// <summary>Warning</summary>
        Warning = 0b10,

        /// <summary>Error</summary>
        Error = 0b11
    }
}
