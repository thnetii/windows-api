namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    /// <summary>
    /// Define checksum return codes.
    /// </summary>
    public enum CHECKSUM_STATUS : int
    {
        /// <summary>The file was mapped successfully.</summary>
        CHECKSUM_SUCCESS         = 0,
        /// <summary>Could not map the file.</summary>
        CHECKSUM_OPEN_FAILURE = 1,
        /// <summary>Could not map a view of the file.</summary>
        CHECKSUM_MAP_FAILURE = 2,
        /// <summary>Could not open the file.</summary>
        CHECKSUM_MAPVIEW_FAILURE = 3,
        /// <summary>Could not convert the file name to Unicode.</summary>
        CHECKSUM_UNICODE_FAILURE = 4,

    }
}
