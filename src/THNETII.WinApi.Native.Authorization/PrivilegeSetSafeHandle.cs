using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class PrivilegeSetSafeHandle : SafeHandle<PRIVILEGE_SET>
    {
        private static readonly int PrivilegeOffset = Marshal.OffsetOf<PRIVILEGE_SET>(nameof(PRIVILEGE_SET.Privilege)).ToInt32();

        public PrivilegeSetSafeHandle() : base() { }

        protected PrivilegeSetSafeHandle(IntPtr invalidHandleValue, bool ownsHandle) : base(invalidHandleValue, ownsHandle) { }
    }
}