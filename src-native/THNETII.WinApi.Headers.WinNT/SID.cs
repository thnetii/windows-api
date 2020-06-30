using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Principal;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SID
    {
        public byte Revision;
        public byte SubAuthorityCount;
        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
        internal int SubAuthorityField;
        public Span<int> SubAuthority => SpanOverRef.GetSpan(ref SubAuthorityField, SubAuthorityCount);

        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public static SecurityIdentifier MarshalToManagedSid(IntPtr pSid) =>
            pSid == IntPtr.Zero ? null : new SecurityIdentifier(pSid);
    }
}
