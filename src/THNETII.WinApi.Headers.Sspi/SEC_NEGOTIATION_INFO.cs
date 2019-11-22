using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 376
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_NEGOTIATION_INFO
    {
        /// <summary>Size of this structure</summary>
        public int Size;
        /// <summary>Length of name hint</summary>
        public int NameLength;
        #region public Span<char> Name;
        internal char* NamePtr;
        /// <summary>Name hint</summary>
        public Span<char> Name => new Span<char>(NamePtr, NameLength);
        #endregion
        #region public void* Reserved;
        /// <summary>Reserved</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void* Reserved;
        #endregion
    }
}
