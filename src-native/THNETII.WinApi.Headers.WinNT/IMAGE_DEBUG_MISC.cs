using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18316
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_DEBUG_MISC
    {
        /// <summary>
        /// type of misc data
        /// </summary>
        public IMAGE_DEBUG_MISC_TYPE DataType;
        /// <summary>
        /// total length of record, rounded to four
        /// byte multiple.
        /// </summary>
        public int Length;
        #region public bool Unicode;
        internal byte UnicodeField;
        /// <summary>
        /// <see langword="true"/> if data is unicode string
        /// </summary>
        public bool Unicode
        {
            get => UnicodeField != 0;
            set => UnicodeField = (byte)(value ? 1 : 0);
        }
        #endregion
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed byte Reserved[3];
        #region public fixed byte Data[1];
        internal byte DataField;
        /// <summary>
        /// Actual data
        /// </summary>
        public Span<byte> Data => SpanOverRef.GetSpan(ref DataField, Length);
        #endregion
    }
}
