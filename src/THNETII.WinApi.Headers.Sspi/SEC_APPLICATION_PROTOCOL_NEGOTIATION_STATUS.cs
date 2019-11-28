namespace THNETII.WinApi.Native.Sspi
{
    /// <summary>
    /// Describes the status of the SEC application protocol negotiation.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ne-sspi-sec_application_protocol_negotiation_status">SEC_APPLICATION_PROTOCOL_NEGOTIATION_STATUS Enumeration</a></para>
    /// </remarks>
    public enum SEC_APPLICATION_PROTOCOL_NEGOTIATION_STATUS
    {
        /// <summary>
        /// No application protocol was negotiated.
        /// </summary>
        SecApplicationProtocolNegotiationStatus_None,
        /// <summary>
        /// The application protocol was negotiated successfully.
        /// </summary>
        SecApplicationProtocolNegotiationStatus_Success,
        /// <summary>
        /// The application protocol was negotiated successfully, but for selected clients only.
        /// </summary>
        SecApplicationProtocolNegotiationStatus_SelectedClientOnly
    }
}
