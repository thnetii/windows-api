using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 818
    /// <summary>
    /// Represents a 64-bit signed integer value.
    /// </summary>
    /// <seealso cref="ULARGE_INTEGER"/>
    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {
        /// <summary/>
        [FieldOffset(0)]
        public uint LowPart;
        /// <summary/>
        [FieldOffset(sizeof(uint))]
        public int HighPart;
        /// <summary>
        /// A signed 64-bit integer.
        /// </summary>
        [FieldOffset(0)]
        public long QuadPart;
    }
}
