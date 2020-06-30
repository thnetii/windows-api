namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10650
    /// <summary>
    /// The <see cref="TOKEN_ELEVATION_TYPE"/> enumeration indicates the elevation type of token being queried by the <see cref="GetTokenInformation"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ne-winnt-token_elevation_type">TOKEN_ELEVATION_TYPE enumeration</a></para>
    /// </remarks>
    public enum TOKEN_ELEVATION_TYPE
    {
        /// <summary>The token does not have a linked token.</summary>
        TokenElevationTypeDefault = 1,
        /// <summary>The token is an elevated token.</summary>
        TokenElevationTypeFull,
        /// <summary>The token is a limited token.</summary>
        TokenElevationTypeLimited,
    }
}
