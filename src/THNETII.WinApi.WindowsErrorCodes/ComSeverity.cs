using static THNETII.WinApiNative.WinError.WinErrorConstants;

namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// COM severity values for <see cref="HRESULT"/> and <see cref="SCODE"/>.
    /// </summary>
    public enum ComSeverity
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        Success = SEVERITY_SUCCESS,
        Error = SEVERITY_ERROR
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
