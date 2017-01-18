using System;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class GuidArrayAuditSafeHandle : ValueArraySafeHandle<Guid>
    {
        protected GuidArrayAuditSafeHandle() : this(IntPtr.Zero) { }
        protected GuidArrayAuditSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }

        protected override bool ReleaseHandle()
        {
            AuditFree(handle);
            return true;
        }
    }
}