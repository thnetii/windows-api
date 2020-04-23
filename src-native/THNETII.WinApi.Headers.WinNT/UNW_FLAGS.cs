using System;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Define unwind information flags.
    /// </summary>
    [Flags]
    public enum UNW_FLAGS : int
    {
        /// <summary>
        /// The function has no handler. 
        /// </summary>
        UNW_FLAG_NHANDLER = WinNTConstants.UNW_FLAG_NHANDLER,
        /// <summary>
        /// The function has an exception handler that should be called. 
        /// </summary>
        UNW_FLAG_EHANDLER = WinNTConstants.UNW_FLAG_EHANDLER,
        /// <summary>
        /// The function has a termination handler that should be called when unwinding an exception. 
        /// </summary>
        UNW_FLAG_UHANDLER = WinNTConstants.UNW_FLAG_UHANDLER,
        /// <summary>
        /// The specified runtime function entry is the contents of a previous function table entry. 
        /// </summary>
        UNW_FLAG_CHAININFO = WinNTConstants.UNW_FLAG_CHAININFO,
    }
}
