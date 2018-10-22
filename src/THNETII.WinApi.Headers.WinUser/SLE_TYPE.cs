namespace THNETII.WinApi.Native.WinUser
{
    using static WinUserFunctions;

    /// <summary>
    /// <see cref="SetLastErrorEx"/> types.
    /// </summary>
    public enum SLE_TYPE : int
    {
        SLE_ERROR = WinUserConstants.SLE_ERROR,
        SLE_MINORERROR = WinUserConstants.SLE_MINORERROR,
        SLE_WARNING = WinUserConstants.SLE_WARNING,
    }
}
