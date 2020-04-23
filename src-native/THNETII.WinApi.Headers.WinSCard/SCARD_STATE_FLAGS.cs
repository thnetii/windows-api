using System;

namespace THNETII.WinApi.Native.WinSCard
{
    using static WinSCardFunctions;

    [Flags]
    public enum SCARD_STATE_FLAGS : int
    {
        /// <summary>
        /// The application is unaware of the
        /// current state, and would like to
        /// know.  The use of this value
        /// results in an immediate return
        /// from state transition monitoring
        /// services.  This is represented by
        /// all bits set to zero.
        /// </summary>
        SCARD_STATE_UNAWARE = WinSCardConstants.SCARD_STATE_UNAWARE,
        /// <summary>
        /// The application requested that
        /// this reader be ignored.  No other
        /// bits will be set.
        /// </summary>
        SCARD_STATE_IGNORE = WinSCardConstants.SCARD_STATE_IGNORE,
        /// <summary>
        /// This implies that there is a
        /// difference between the state
        /// believed by the application, and
        /// the state known by the Service
        /// Manager.  When this bit is set,
        /// the application may assume a
        /// significant state change has
        /// occurred on this reader.
        /// </summary>
        SCARD_STATE_CHANGED = WinSCardConstants.SCARD_STATE_CHANGED,
        /// <summary>
        /// This implies that the given
        /// reader name is not recognized by
        /// the Service Manager.  If this bit
        /// is set, then <see cref="SCARD_STATE_CHANGED"/>
        /// and <see cref="SCARD_STATE_IGNORE"/> will also
        /// be set.
        /// </summary>
        SCARD_STATE_UNKNOWN = WinSCardConstants.SCARD_STATE_UNKNOWN,
        /// <summary>
        /// This implies that the actual
        /// state of this reader is not
        /// available.  If this bit is set,
        /// then all the following bits are
        /// clear.
        /// </summary>
        SCARD_STATE_UNAVAILABLE = WinSCardConstants.SCARD_STATE_UNAVAILABLE,
        /// <summary>
        /// This implies that there is not
        /// card in the reader.  If this bit
        /// is set, all the following bits
        /// will be clear.
        /// </summary>
        SCARD_STATE_EMPTY = WinSCardConstants.SCARD_STATE_EMPTY,
        /// <summary>
        /// This implies that there is a card
        /// in the reader.
        /// </summary>
        SCARD_STATE_PRESENT = WinSCardConstants.SCARD_STATE_PRESENT,
        /// <summary>
        /// This implies that there is a card
        /// in the reader with an ATR
        /// matching one of the target cards.
        /// If this bit is set,
        /// <see cref="SCARD_STATE_PRESENT"/> will also be
        /// set.  This bit is only returned
        /// on the <see cref="SCardLocateCard"/> service.
        /// </summary>
        SCARD_STATE_ATRMATCH = WinSCardConstants.SCARD_STATE_ATRMATCH,
        /// <summary>
        /// This implies that the card in the
        /// reader is allocated for exclusive
        /// use by another application.  If
        /// this bit is set,
        /// <see cref="SCARD_STATE_PRESENT"/> will also be
        /// set.
        /// </summary>
        SCARD_STATE_EXCLUSIVE = WinSCardConstants.SCARD_STATE_EXCLUSIVE,
        /// <summary>
        /// This implies that the card in the
        /// reader is in use by one or more
        /// other applications, but may be
        /// connected to in shared mode.  If
        /// this bit is set,
        /// <see cref="SCARD_STATE_PRESENT"/> will also be
        /// set.
        /// </summary>
        SCARD_STATE_INUSE = WinSCardConstants.SCARD_STATE_INUSE,
        /// <summary>
        /// This implies that the card in the
        /// reader is unresponsive or not
        /// supported by the reader or
        /// software.
        /// </summary>
        SCARD_STATE_MUTE = WinSCardConstants.SCARD_STATE_MUTE,
        /// <summary>
        /// This implies that the card in the
        /// reader has not been powered up.
        /// </summary>
        SCARD_STATE_UNPOWERED = WinSCardConstants.SCARD_STATE_UNPOWERED,
    }
}
