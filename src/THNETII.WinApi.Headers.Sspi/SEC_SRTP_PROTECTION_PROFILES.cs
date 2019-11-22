using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 414
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SEC_SRTP_PROTECTION_PROFILES
    {
        /// <summary>
        /// Size in bytes of the SRTP protection profiles array
        /// </summary>
        public ushort ProfilesSize;
        #region public Span<byte> ProfilesList;
        internal byte* ProfilesListPtr;
        /// <summary>
        /// Array of SRTP protection profiles
        /// </summary>
        public Span<byte> ProfilesList => new Span<byte>(ProfilesListPtr, ProfilesSize);
        #endregion
    }
}
