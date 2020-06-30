using System;

namespace THNETII.WinApi.Native.WinSmcrd
{
    [Flags]
    public enum SCARD_PROTOCOL_FLAGS : int
    {
        /// <summary>
        /// There is no active protocol.
        /// </summary>
        SCARD_PROTOCOL_UNDEFINED = WinSmcrdConstants.SCARD_PROTOCOL_UNDEFINED,
        /// <summary>
        /// T=0 is the active protocol.
        /// </summary>
        SCARD_PROTOCOL_T0 = WinSmcrdConstants.SCARD_PROTOCOL_T0,
        /// <summary>
        /// T=1 is the active protocol.
        /// </summary>
        SCARD_PROTOCOL_T1 = WinSmcrdConstants.SCARD_PROTOCOL_T1,
        /// <summary>
        /// Raw is the active protocol.
        /// </summary>
        SCARD_PROTOCOL_RAW = WinSmcrdConstants.SCARD_PROTOCOL_RAW,
        /// <summary>
        /// This is the mask of ISO defined transmission protocols
        /// </summary>
        SCARD_PROTOCOL_Tx = WinSmcrdConstants.SCARD_PROTOCOL_Tx,
        /// <summary>
        /// Use the default transmission parameters / card clock freq.
        /// </summary>
        SCARD_PROTOCOL_DEFAULT = WinSmcrdConstants.SCARD_PROTOCOL_DEFAULT,
        //
        /// <summary>
        /// Use optimal transmission parameters / card clock freq.
        /// Since using the optimal parameters is the default case no bit is defined to be 1
        /// </summary>
        SCARD_PROTOCOL_OPTIMAL = WinSmcrdConstants.SCARD_PROTOCOL_OPTIMAL,
    }
}
