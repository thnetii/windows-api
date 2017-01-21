using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class WideStringAuditSafeHandle : WideStringSafeHandle
    {
        protected WideStringAuditSafeHandle() : this(IntPtr.Zero) { }
        protected WideStringAuditSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }

        protected override bool ReleaseHandle()
        {
            AuditFree(handle);
            return true;
        }

        public override string MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            return Marshal.PtrToStringUni(handle);
        }
    }
}