using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    public static class SID
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct STRUCT_SID
        {
            public byte Revision;
            public byte SubAuthorityCount;
            public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
            internal int SubAuthorityField;
            public unsafe Span<int> SubAuthority => new Span<int>(Unsafe.AsPointer(ref SubAuthorityField), SubAuthorityCount);
        }

        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public static SecurityIdentifier MarshalToManagedSid(IntPtr pSid) =>
            pSid == IntPtr.Zero ? null : new SecurityIdentifier(pSid);
    }
}
