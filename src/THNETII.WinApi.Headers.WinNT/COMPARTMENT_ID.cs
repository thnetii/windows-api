namespace THNETII.WinApi.WinNT
{
    //
    // Compartment identifier
    //

    /// <summary>
    /// The <see cref="COMPARTMENT_ID"/> enumeration indicates the network routing compartment identifier.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-compartment_id">COMPARTMENT_ID Enumeration</a></para>
    /// </remarks>
    public enum COMPARTMENT_ID
    {
        /// <summary>Indicates that the routing compartment is undefined.</summary>
        UNSPECIFIED_COMPARTMENT_ID = 0,
        /// <summary>Indicates the default routing compartment.</summary>
        DEFAULT_COMPARTMENT_ID
    }
}
