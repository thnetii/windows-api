using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10766
    /// <summary>
    /// The <see cref="TOKEN_DEFAULT_DACL"/> structure specifies a <a href="https://msdn.microsoft.com/d007cbb9-b547-4dc7-bc22-b526f650f7c2">discretionary access control list</a> (DACL).
    /// </summary>
    /// <remarks>
    /// The <see cref="GetTokenInformation"/> function retrieves the default DACL for an access token, in the form of a <see cref="TOKEN_DEFAULT_DACL"/> structure. This structure is also used with the <see cref="SetTokenInformation"/> function to set the default DACL.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_default_dacl">TOKEN_DEFAULT_DACL structure</a></para>
    /// </remarks>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="SetTokenInformation"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_DEFAULT_DACL
    {
        private static readonly ArrayPool<byte> bytePool = ArrayPool<byte>.Shared;

        /// <summary>
        /// A pointer to an ACL structure assigned by default to any objects created by the user. The user is represented by the access token.
        /// </summary>
        public IntPtr DefaultDacl;

        /// <summary>
        /// Marshals the <see cref="DefaultDacl"/> pointer to a managed copy of the ACL data.
        /// </summary>
        /// <returns>A copy of the data pointed to by <see cref="DefaultDacl"/> in form of a <see cref="RawAcl"/> instance, or <c>null</c> if <see cref="DefaultDacl"/> is <see cref="IntPtr.Zero"/>.</returns>
        /// <exception cref="PlatformNotSupportedException"/>
        [SuppressMessage("Usage", "PC001: API not supported on all platforms")]
        public RawAcl MarshalDefaultDacl()
        {
            IntPtr pAcl = DefaultDacl;
            if (pAcl == IntPtr.Zero)
                return null;
            byte[] bytes = bytePool.Rent(GenericAcl.MaxBinaryLength);
            try
            {
                Marshal.Copy(pAcl, bytes, startIndex: 0, GenericAcl.MaxBinaryLength);
                return new RawAcl(bytes, offset: 0);
            }
            finally { bytePool.Return(bytes); }
        }
    }
}
