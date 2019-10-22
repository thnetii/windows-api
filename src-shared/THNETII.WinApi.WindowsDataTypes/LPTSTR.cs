using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native
{
    /// <summary>
    /// A pointer to a null-terminated string of platform-dependant characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPTSTR : ITerminatedAutoStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }

    /// <summary>
    /// A pointer to a constant null-terminated string of platform-dependant characters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LPCTSTR : IConstTerminatedAutoStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }
}
