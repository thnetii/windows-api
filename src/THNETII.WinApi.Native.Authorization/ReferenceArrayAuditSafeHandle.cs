using System;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class ReferenceArrayAuditSafeHandle<T> : ReferenceArraySafeHandle<T>
    {
        protected ReferenceArrayAuditSafeHandle() : this(IntPtr.Zero) { }
        protected ReferenceArrayAuditSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }

        protected override bool ReleaseHandle()
        {
            AuditFree(handle);
            return true;
        }
    }

    public class GuidReferenceArrayAuditSafeHandle : ReferenceArrayAuditSafeHandle<Guid>
    {
        protected GuidReferenceArrayAuditSafeHandle() : this(IntPtr.Zero) { }
        protected GuidReferenceArrayAuditSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }
    }
}