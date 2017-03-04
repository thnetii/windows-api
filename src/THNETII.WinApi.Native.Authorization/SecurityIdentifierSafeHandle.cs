using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public interface ISafeHandleReadableAsSecurityIdentifier : ISafeHandleReadableAs<SecurityIdentifier> { }

    public static class SecurityIdentifierSafeHandle
    {
        public static SecurityIdentifier MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;
            return new SecurityIdentifier(pNativeData);
        }

        public static SecurityIdentifier ReadValue<THandle>(this THandle safeHandle)
            where THandle : SafeHandle, ISafeHandleReadableAsSecurityIdentifier
            => safeHandle?.ReadValue(MarshalNativeToManaged);
    }

    public class SecurityIdentifierAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsSecurityIdentifier
    {
        protected SecurityIdentifierAnySafeHandle() : base() { }
        protected SecurityIdentifierAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected SecurityIdentifierAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public SecurityIdentifierAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }

    public class SecurityIdentifierCoTaskMemSafeHandle : CoTaskMemSafeHandle, ISafeHandleReadableAsSecurityIdentifier
    {
        public SecurityIdentifierCoTaskMemSafeHandle(SecurityIdentifier sid) : base(sid?.BinaryLength ?? throw new ArgumentNullException(nameof(sid)))
        {
            var binaryForm = new byte[sid.BinaryLength];
            sid.GetBinaryForm(binaryForm, 0);
            Marshal.Copy(source: binaryForm, destination: handle, startIndex: 0, length: binaryForm.Length);
        }
    }
}
