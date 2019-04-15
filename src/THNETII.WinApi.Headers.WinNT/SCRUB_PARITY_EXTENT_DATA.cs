using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.NativeMemory;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13276
    [StructLayout(LayoutKind.Sequential)]
    public struct SCRUB_PARITY_EXTENT_DATA
    {
        /// <summary>
        /// Set to the static <see cref="SizeOf{SCRUB_PARITY_EXTENT_DATA}.Bytes"/>
        /// property of the <see cref="SizeOf{SCRUB_PARITY_EXTENT_DATA}"/> type.
        /// </summary>
        public short Size;

        /// <summary>Reserved</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public short Flags;

        /// <summary>
        /// Number of parity extents
        /// </summary>
        public short NumberOfParityExtents;

        /// <summary>
        /// Maximum number of parity extents in <see cref="ParityExtents"/> buffer
        /// </summary>
        public short MaximumNumberOfParityExtents;

        internal SCRUB_PARITY_EXTENT ParityExtentField;
        /// <summary>
        /// Output buffer for parity extents
        /// </summary>
        public Span<SCRUB_PARITY_EXTENT> ParityExtents => SpanOverRef.GetSpan(ref ParityExtentField, NumberOfParityExtents);
    }
}
