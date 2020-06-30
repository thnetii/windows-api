using System;

namespace THNETII.WinApi.Native.WinSCard
{
    [Flags]
    public enum SC_DLG_FLAGS : int
    {
        /// <summary>
        /// Display the dialog box only if the card being searched for by the calling application is not located and available for use in a reader. This allows the card to be found, connected (either through the internal dialog box mechanism or the user callback functions), and returned to the calling application.
        /// </summary>
        SC_DLG_MINIMAL_UI = WinSCardConstants.SC_DLG_MINIMAL_UI,
        /// <summary>
        /// Force no display of the <strong>Select Card</strong> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">user interface</a> (UI), regardless of search outcome.
        /// </summary>
        SC_DLG_NO_UI = WinSCardConstants.SC_DLG_NO_UI,
        /// <summary>
        /// Force display of the <strong>Select Card</strong> <a href="https://docs.microsoft.com/windows/desktop/SecGloss/u-gly">user interface</a> (UI), regardless of the search outcome.
        /// </summary>
        SC_DLG_FORCE_UI = WinSCardConstants.SC_DLG_FORCE_UI,
    }
}
