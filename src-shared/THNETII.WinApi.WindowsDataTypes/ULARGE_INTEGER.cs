using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 838
    /// <summary>
    /// Represents a 64-bit unsigned integer value.
    /// </summary>
    /// <seealso cref="LARGE_INTEGER"/>
    [StructLayout(LayoutKind.Explicit)]
    public struct ULARGE_INTEGER
    {
        /// <summary/>
        [FieldOffset(0)]
        public uint LowPart;
        /// <summary/>
        [FieldOffset(sizeof(uint))]
        public uint HighPart;
        /// <summary>
        /// A signed 64-bit integer.
        /// </summary>
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}
