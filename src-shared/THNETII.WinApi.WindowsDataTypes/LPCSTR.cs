using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a constant null-terminated string of 8-bit Windows (ANSI) characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPCSTR : IConstTerminatedAnsiStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }
}
