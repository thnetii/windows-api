namespace THNETII.WinApi.Native.WinUser
{
    /// <summary>
    /// <see cref="M:THNETII.WinApi.Native.ErrorHandling.ErrorHandlingFunctions.SetLastErrorEx(System.Int32,THNETII.WinApi.Native.WinUser.SLE_TYPE)"/> types.
    /// </summary>
    public enum SLE_TYPE : int
    {
        SLE_ERROR = WinUserConstants.SLE_ERROR,
        SLE_MINORERROR = WinUserConstants.SLE_MINORERROR,
        SLE_WARNING = WinUserConstants.SLE_WARNING,
    }
}
