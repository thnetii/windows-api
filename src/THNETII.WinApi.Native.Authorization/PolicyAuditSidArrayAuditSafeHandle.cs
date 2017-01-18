using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class PolicyAuditSidArrayAuditSafeHandle : SafeHandle<POLICY_AUDIT_SID_ARRAY>
    {
        private static readonly int UserSidArrayOffset = Marshal.OffsetOf<POLICY_AUDIT_SID_ARRAY>(nameof(POLICY_AUDIT_SID_ARRAY.UserSidArray)).ToInt32();

        protected PolicyAuditSidArrayAuditSafeHandle() : this(IntPtr.Zero) { }
        protected PolicyAuditSidArrayAuditSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = true) : base(invalidHandleValue, ownsHandle) { }

        public override POLICY_AUDIT_SID_ARRAY MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            var nativeMarshaledInstance = Marshal.PtrToStructure<POLICY_AUDIT_SID_ARRAY>(handle);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.UsersCount == 0)
                nativeMarshaledInstance.UserSidArray = new IntPtr[0];
            else if (nativeMarshaledInstance.UsersCount > 1)
            {
                var groupsArray = new IntPtr[nativeMarshaledInstance.UsersCount];
                Marshal.Copy(handle + UserSidArrayOffset, groupsArray, startIndex: 0, length: groupsArray.Length);
                nativeMarshaledInstance.UserSidArray = groupsArray;
            }
            return nativeMarshaledInstance;
        }

        protected override bool ReleaseHandle()
        {
            AuditFree(handle);
            return true;
        }
    }
}