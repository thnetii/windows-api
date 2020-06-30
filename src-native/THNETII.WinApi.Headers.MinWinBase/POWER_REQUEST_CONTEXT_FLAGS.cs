using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    public enum POWER_REQUEST_CONTEXT_FLAGS : int
    {
        /// <summary>
        /// The <see cref="REASON_CONTEXT.SimpleReasonString"/> member of the <see cref="REASON_CONTEXT"/> structure contains a simple, non-localizable string that describes the reason for the power request. 
        /// </summary>
        POWER_REQUEST_CONTEXT_SIMPLE_STRING = WinNTConstants.POWER_REQUEST_CONTEXT_SIMPLE_STRING,
        /// <summary>
        /// The <see cref="REASON_CONTEXT.Detailed"/> member of the <see cref="REASON_CONTEXT"/> structure identifies a localizable string resource that describes the reason for the power request. 
        /// </summary>
        POWER_REQUEST_CONTEXT_DETAILED_STRING = WinNTConstants.POWER_REQUEST_CONTEXT_DETAILED_STRING,
    }
}
