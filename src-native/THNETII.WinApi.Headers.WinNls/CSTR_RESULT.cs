namespace THNETII.WinApi.Native.WinNls
{
    /// <summary>
    /// Compare String Return Values.
    /// </summary>
    public enum CSTR_RESULT : int
    {
        /// <summary>string 1 less than string 2</summary>
        CSTR_LESS_THAN = WinNlsConstants.CSTR_LESS_THAN,
        /// <summary>string 1 equal to string 2</summary>
        CSTR_EQUAL = WinNlsConstants.CSTR_EQUAL,
        /// <summary>string 1 greater than string 2</summary>
        CSTR_GREATER_THAN = WinNlsConstants.CSTR_GREATER_THAN,
    }
}
