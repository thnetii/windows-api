namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum ADDRESS_MODE
    {
        /// <summary>
        /// 16:16 addressing. To support this addressing mode, you must supply a <see cref="TranslateAddressProc64"/> callback function.
        /// </summary>
        AddrMode1616,
        /// <summary>
        /// 16:32 addressing. To support this addressing mode, you must supply a <see cref="TranslateAddressProc64"/> callback function.
        /// </summary>
        AddrMode1632,
        /// <summary>
        /// Real-mode addressing. To support this addressing mode, you must supply a <see cref="TranslateAddressProc64"/> callback function.
        /// </summary>
        AddrModeReal,
        /// <summary>
        /// Flat addressing. This is the only addressing mode supported by the library.
        /// </summary>
        AddrModeFlat
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}