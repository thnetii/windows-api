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
        /// <summary>
        /// Gets the pointer value of the <see cref="LPWSTR"/>.
        /// </summary>
        /// <value>A pointer to the first character of the string, or <see cref="IntPtr.Zero"/> if the <see cref="LPWSTR"/> refers to <see langword="null"/>.</value>
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPCWSTR : IConstTerminatedAnsiStringPointer
    {
        public IntPtr Pointer { get; }
    }
}
