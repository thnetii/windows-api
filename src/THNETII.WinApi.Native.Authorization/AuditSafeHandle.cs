using System;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class AuditSafeHandle : SafeHandle
    {
        /// <inheritdoc />
        public override bool IsInvalid => handle == IntPtr.Zero;
        
        /// <inheritdoc />
        protected override bool ReleaseHandle()
        {
            if (IsInvalid)
                return false;
            AuditFree(handle);
            return true;
        }

        protected AuditSafeHandle() : base(IntPtr.Zero, ownsHandle: true) { }
    }
}
