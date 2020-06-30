namespace THNETII.WinApi.Native.WinSCard
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winscard.h, line 1084
    public enum READER_SEL_REQUEST_MATCH_TYPE
    {
        /// <summary>
        /// Reader selection
        /// provider will match smart cards based on whether they are in the given
        /// reader and have the given key container. Reader name and container name are
        /// both optional. Reader name and container name, if any, need to be appended
        /// after <see cref="READER_SEL_REQUEST"/> structure and set their offsets and lengths in
        /// <see cref="READER_SEL_REQUEST.ReaderAndContainerParameter"/> member.
        /// </summary>
        RSR_MATCH_TYPE_READER_AND_CONTAINER = 1,
        /// <summary>
        /// Reader selection
        /// provider will match smart cards based on their serial numbers / card IDs.
        /// Serial number is required. It needs to be appended after <see cref="READER_SEL_REQUEST"/>
        /// structure as a byte array and set its offset and length in
        /// <see cref="READER_SEL_REQUEST.SerialNumberParameter"/> member.
        /// </summary>
        RSR_MATCH_TYPE_SERIAL_NUMBER,
        /// <summary>
        /// Reader selection provider
        /// will allow all recognized cards to be selected by user without any filtering.
        /// The card may not be personalized for Base CSP / Smart Card KSP yet, or even
        /// have its own CSP.
        /// </summary>
        RSR_MATCH_TYPE_ALL_CARDS
    }
}
