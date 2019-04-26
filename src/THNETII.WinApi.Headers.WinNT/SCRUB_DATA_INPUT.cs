using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    using static SCRUB_DATA_INPUT_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13217
    [StructLayout(LayoutKind.Sequential)]
    public struct SCRUB_DATA_INPUT
    {
        /// <summary>
        /// Set to the static <see cref="SizeOf{SCRUB_DATA_INPUT}.Bytes"/>
        /// property of the <see cref="SizeOf{SCRUB_DATA_INPUT}"/> type.
        /// </summary>
        public int Size;

        /// <summary>
        /// <c>default</c> for the initial call.
        /// <para>
        /// <see cref="SCRUB_DATA_INPUT_FLAG_RESUME"/> has to be specified when
        /// <see cref="ResumeContext"/> is provided from the previous call
        /// </para>
        /// </summary>
        public SCRUB_DATA_INPUT_FLAGS Flags;

        /// <summary>
        /// Maximum number of IOs in a single call. This is a hint to a
        /// file system to halt the operation with a restart context if the
        /// operation takes too long.
        /// </summary>
        public int MaximumIos;

        #region public int[] ObjectId = new int[4];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 4)]
        private struct DUMMSTRUCTNAME { }
        private DUMMSTRUCTNAME s;
        /// <summary>
        /// 16 Byte object id. Only used if <see cref="SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID"/>
        /// is specified via <see cref="FSCTL_SCRUB_UNDISCOVERABLE_ID"/>.
        /// </summary>
        public Span<int> ObjectId => MemoryMarshal.Cast<DUMMSTRUCTNAME, int>(SpanOverRef.GetSpan(ref s));
        #endregion

        #region public int[] Reserved = new int[13];
        [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 13)]
        private struct DUMMSTRUCTNAME2 { }
        private DUMMSTRUCTNAME2 s2;
        /// <summary>Reserved</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Span<int> Reserved => MemoryMarshal.Cast<DUMMSTRUCTNAME2, int>(SpanOverRef.GetSpan(ref s2));
        #endregion

        #region public byte[] Reserved = new byte[816];
        [StructLayout(LayoutKind.Explicit, Size = 816)]
        private struct DUMMSTRUCTNAME3 { }
        private DUMMSTRUCTNAME3 s3;
        /// <summary>
        /// Opaque data returned from the previous call to restart the
        /// operation. Only valid when <see cref="SCRUB_DATA_INPUT_FLAG_RESUME"/> is set
        /// at <see cref="Flags"/> field.
        /// </summary>
        public Span<byte> ResumeContext => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref s3));
        #endregion
    }
}
