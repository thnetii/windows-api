namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1283
    //
    //  More GEOCLASS defines will be listed here
    //

    /// <summary>
    /// Specifies the geographical location class.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ne-winnls-sysgeoclass">SYSGEOCLASS enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-enumeration-types">National Language Support Enumeration Types</seealso>
    public enum SYSGEOCLASS
    {
        /// <summary>
        /// Class for nation geographical location identifiers.
        /// </summary>
        GEOCLASS_NATION = 16,
        /// <summary>
        /// Class for region geographical location identifiers.
        /// </summary>
        GEOCLASS_REGION = 14,
        /// <summary>
        /// <strong>Starting with Windows 8</strong>: Class for all geographical location identifiers.
        /// </summary>
        GEOCLASS_ALL = 0
    }
}
