using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8992
    /// <summary>
    /// Union which can hold any valid sid.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SE_SID
    {
        public byte Revision;
        public byte SubAuthorityCount;
        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
        #region public int[SID_MAX_SUB_AUTHORITIES] SubAuthority
        internal SE_SID_SUBAUTHORITY SubAuthorityField;
        [StructLayout(LayoutKind.Explicit, Size = SID_MAX_SUB_AUTHORITIES * sizeof(int))]
        internal struct SE_SID_SUBAUTHORITY
        {
            public const int Length = SID_MAX_SUB_AUTHORITIES;
            public ref int this[int index] => ref Span[index];
            public Span<int> Span => MemoryMarshal.Cast<SE_SID_SUBAUTHORITY, int>(SpanOverRef.GetSpan(ref this));
        }
        public Span<int> SubAuthority => SubAuthorityField.Span;
        #endregion
    }
}
