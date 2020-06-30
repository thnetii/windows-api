using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a constant null-terminated string of 16-bit Unicode characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPCWSTR : IConstTerminatedUnicodeStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }
}
