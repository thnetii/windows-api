using System;

namespace THNETII.WinApi.Native.WinUser
{
    [Flags]
    public enum FLASHWFLAGS : int
    {
        /// <summary>
        /// Stop flashing. The system restores the window to its original state. 
        /// </summary>
        FLASHW_STOP = WinUserConstants.FLASHW_STOP,
        /// <summary>
        /// Flash the window caption. 
        /// </summary>
        FLASHW_CAPTION = WinUserConstants.FLASHW_CAPTION,
        /// <summary>
        /// Flash the taskbar button. 
        /// </summary>
        FLASHW_TRAY = WinUserConstants.FLASHW_TRAY,
        /// <summary>
        /// Flash both the window caption and taskbar button. This is equivalent to setting the <c><see cref="FLASHW_CAPTION"/> | <see cref="FLASHW_TRAY"/></c> flags. 
        /// </summary>
        FLASHW_ALL = WinUserConstants.FLASHW_ALL,
        /// <summary>
        /// Flash continuously, until the <see cref="FLASHW_STOP"/> flag is set. 
        /// </summary>
        FLASHW_TIMER = WinUserConstants.FLASHW_TIMER,
        /// <summary>
        /// Flash continuously until the window comes to the foreground. 
        /// </summary>
        FLASHW_TIMERNOFG = WinUserConstants.FLASHW_TIMERNOFG,
    }
}
