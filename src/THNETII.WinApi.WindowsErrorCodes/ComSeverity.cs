using static THNETII.WinApiNative.WinError.WinErrorConstants;

namespace THNETII.WinApi.WindowsErrorCodes
{
    /// <summary>
    /// COM severity values for <see cref="HRESULT"/> and <see cref="SCODE"/>.
    /// </summary>
    public enum ComSeverity
    {
        Success = SEVERITY_SUCCESS,
        Error = SEVERITY_ERROR
    }
}
