namespace THNETII.WinApi.Native.WinNls
{
    public enum MUI_FILETYPE : int
    {
        /// <summary>
        /// The input file does not have resource configuration data. This file type is typical for older executable files. If this file type is specified, the other file types will not provide useful information.
        /// </summary>
        MUI_FILETYPE_NOT_LANGUAGE_NEUTRAL = WinNlsConstants.MUI_FILETYPE_NOT_LANGUAGE_NEUTRAL,
        /// <summary>The input file is an LN file.</summary>
        MUI_FILETYPE_LANGUAGE_NEUTRAL_MAIN = WinNlsConstants.MUI_FILETYPE_LANGUAGE_NEUTRAL_MAIN,
        /// <summary>The input file is a language-specific resource file.</summary>
        MUI_FILETYPE_LANGUAGE_NEUTRAL_MUI = WinNlsConstants.MUI_FILETYPE_LANGUAGE_NEUTRAL_MUI,
    }
}
