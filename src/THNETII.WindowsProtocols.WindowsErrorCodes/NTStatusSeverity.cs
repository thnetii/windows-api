namespace THNETII.WindowsProtocols.WindowsErrorCodes
{
    using static Constants.StatusSeverityConstants;

    /// <summary>
    /// Win32 System Error and <see cref="NTSTATUS"/> Severity Code.
    /// </summary>
    public enum NTStatusSeverity
    {
        /// <summary>Success</summary>
        Success = STATUS_SEVERITY_SUCCESS,

        /// <summary>Informational</summary>
        Informational = STATUS_SEVERITY_INFORMATIONAL,

        /// <summary>Warning</summary>
        Warning = STATUS_SEVERITY_WARNING,

        /// <summary>Error</summary>
        Error = STATUS_SEVERITY_ERROR
    }
}
