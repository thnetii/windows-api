namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// Win32 System Error and <see cref="NTSTATUS"/> Severity Code.
    /// </summary>
    public enum StatusSeverity
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        Success = 0x00,
        Informational = 0x01,
        Warning = 0x10,
        Error = 0x11
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
