using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [StructLayout(LayoutKind.Sequential)]
    public class LIST_ENTRY
    {
        /// <summary>
        /// This pointer can be marshaled into a single <see cref="LIST_ENTRY"/> instance using the <see cref="Marshal.PtrToStructure{LIST_ENTRY}(IntPtr)"/> method.
        /// </summary>
        public IntPtr Flink;
        /// <summary>
        /// This pointer can be marshaled into a single <see cref="LIST_ENTRY"/> instance using the <see cref="Marshal.PtrToStructure{LIST_ENTRY}(IntPtr)"/> method.
        /// </summary>
        public IntPtr Blink;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}