using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 522
    /// <summary>
    /// A pointer to a null-terminated string of Unicode (UTF-16) characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct LPWSTR : ITerminatedUnicodeStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }
}
