using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Represents an address. It is used in the <see cref="STACKFRAME64"/> structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679272.aspx">ADDRESS64 structure</a></para>
    /// </remarks>
    /// <seealso cref="STACKFRAME64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ADDRESS64
    {
        /// <summary>
        /// The offset into the segment, or a 32-bit virtual address. The interpretation of this value depends on the value contained in the <see cref="Mode"/> member.
        /// </summary>
        public long Offset;
        /// <summary>The segment number. This value is used only for 16-bit addressing.</summary>
        public short Segment;
        /// <summary>The addressing mode.</summary>
        public ADDRESS_MODE Mode;
    }
}
