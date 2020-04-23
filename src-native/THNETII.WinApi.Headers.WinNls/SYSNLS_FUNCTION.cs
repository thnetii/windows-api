namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1176
    //
    //  NLS function capabilities
    //

    /// <summary>
    /// Specifies NLS function capabilities.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ne-winnls-sysnls_function">SYSNLS_FUNCTION enumeration</a></para>
    /// </remarks>
    /// <seealso cref="CompareString"/>
    /// <seealso cref="GetNLSVersion"/>
    /// <seealso cref="IsNLSDefinedString"/>
    /// <seealso cref="LCMapString"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-enumeration-types">National Language Support Enumeration Types</seealso>
    public enum SYSNLS_FUNCTION
    {
        /// <summary>
        /// Value indicating comparison of two strings in the manner of the <see cref="CompareString"/> function or <see cref="LCMapString"/> with the <see cref="LCMAP_SORTKEY"/> flag specified.
        /// </summary>
        COMPARE_STRING = 0x0001,
    }
}
