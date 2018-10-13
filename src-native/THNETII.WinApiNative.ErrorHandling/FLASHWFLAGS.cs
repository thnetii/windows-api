using System;
using System.Diagnostics.CodeAnalysis;

namespace THNETII.WinApiNative.ErrorHandling
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum FLASHWFLAGS : int
    {
        /// <summary>
        /// Stop flashing. The system restores the window to its original state. 
        /// </summary>
        FLASHW_STOP = 0,
        /// <summary>
        /// Flash the window caption. 
        /// </summary>
        FLASHW_CAPTION = 0x00000001,
        /// <summary>
        /// Flash the taskbar button. 
        /// </summary>
        FLASHW_TRAY = 0x00000002,
        /// <summary>
        /// Flash both the window caption and taskbar button. This is equivalent to setting the <c><see cref="FLASHW_CAPTION"/> | <see cref="FLASHW_TRAY"/></c> flags. 
        /// </summary>
        FLASHW_ALL = (FLASHW_CAPTION | FLASHW_TRAY),
        /// <summary>
        /// Flash continuously, until the <see cref="FLASHW_STOP"/> flag is set. 
        /// </summary>
        FLASHW_TIMER = 0x00000004,
        /// <summary>
        /// Flash continuously until the window comes to the foreground. 
        /// </summary>
        FLASHW_TIMERNOFG = 0x0000000C,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
