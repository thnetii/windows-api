using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    public static class ACL
    {
        public static readonly ArrayPool<byte> bytePool = ArrayPool<byte>.Shared;

        [StructLayout(LayoutKind.Sequential)]
        private readonly ref struct STRUCT_ACL
        {
            public readonly byte AclRevision;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public readonly byte Sbz1;
            public readonly short AclSize;
            public readonly short AceCount;
            [EditorBrowsable(EditorBrowsableState.Never)]
            public readonly short Sbz2;
        }

        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public static RawAcl MarshalToManagedAcl(IntPtr ptrAcl)
        {
            if (ptrAcl == IntPtr.Zero)
                return null;
            short cbAcl;
            unsafe
            {
                STRUCT_ACL* pAcl = (STRUCT_ACL*)ptrAcl.ToPointer();
                cbAcl = pAcl->AclSize;
            }
            var spanAcl = ptrAcl.AsRefStructSpan<byte>(cbAcl);
            byte[] bytesAcl = bytePool.Rent(cbAcl);
            try
            {
                spanAcl.CopyTo(bytesAcl);
                return new RawAcl(bytesAcl, offset: 0);
            }
            finally { bytePool.Return(bytesAcl); }
        }
    }
}
