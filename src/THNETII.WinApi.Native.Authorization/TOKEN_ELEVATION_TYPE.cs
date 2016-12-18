namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TOKEN_ELEVATION_TYPE"/> enumeration indicates the elevation type of token being queried by the <see cref="GetTokenInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb530718.aspx">TOKEN_ELEVATION_TYPE enumeration</a></para>
    /// </remarks>
    public enum TOKEN_ELEVATION_TYPE
    {
        /// <summary>The token does not have a linked token.</summary>
        TokenElevationTypeDefault = 1,
        /// <summary>The token is an elevated token.</summary>
        TokenElevationTypeFull,
        /// <summary>The token is a limited token.</summary>
        TokenElevationTypeLimited
    }
}
