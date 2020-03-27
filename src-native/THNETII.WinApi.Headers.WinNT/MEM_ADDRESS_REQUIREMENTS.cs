using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12731
    /// <summary>
    /// Specifies a lowest and highest base address and alignment as part of an extended parameter to a function that manages virtual memory.
    /// </summary>
    /// <remarks>
    /// Specifying a <see cref="MEM_ADDRESS_REQUIREMENTS"/> structure with all fields set to their default values is the same as not specifying one at all.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-mem_address_requirements">MEM_ADDRESS_REQUIREMENTS structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct MEM_ADDRESS_REQUIREMENTS
    {
        /// <summary>
        /// Specifies the lowest acceptable address. Calling <see cref="VirtualAlloc2"/> or <see cref="MapViewOfFile3"/>, and specifying <see cref="IntPtr.Zero"/> for <see cref="LowestStartingAddress"/>, gives the same behavior as calling <see cref="VirtualAlloc"/>/<see cref="MapViewOfFile"/>.
        /// </summary>
        public IntPtr LowestStartingAddress;
        /// <summary>
        /// Specifies the highest acceptable address (inclusive). This address must not exceed <em>lpMaximumApplicationAddress</em> returned by <see cref="GetSystemInfo"/>. Calling <see cref="VirtualAlloc2"/> or <see cref="MapViewOfFile3"/>, and specifying <see cref="IntPtr.Zero"/> for <see cref="HighestEndingAddress"/>, gives the same behavior as calling <see cref="VirtualAlloc"/>/<see cref="MapViewOfFile"/>.
        /// </summary>
        public IntPtr HighestEndingAddress;
        internal UIntPtr AlignmentField;
        /// <summary>
        /// Specifies power-of-2 alignment. Specifying <c>0</c> (zero) aligns the returned address on the system allocation granularity.
        /// </summary>
        public int Alignment
        {
            get => (int)AlignmentField.ToUInt32();
            set => AlignmentField = (UIntPtr)(uint)value;
        }
    }
}
