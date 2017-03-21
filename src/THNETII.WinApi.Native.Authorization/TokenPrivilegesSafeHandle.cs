using System;
using System.Runtime.InteropServices;
using System.Threading;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public interface ISafeHandleReadableAsTokenPrivileges : ISafeHandleReadableAs<TOKEN_PRIVILEGES> { }

    public static class TokenPrivilegesSafeHandle
    {
        private static readonly int PrivilegesOffset = Marshal.OffsetOf<TOKEN_PRIVILEGES>(nameof(TOKEN_PRIVILEGES.Privileges)).ToInt32();

        /// <summary>
        /// Marshals the native data to a managed <see cref="TOKEN_PRIVILEGES"/> instance.
        /// </summary>
        /// <param name="pNativeData">The pointer value to the memory containing the native data to be marshaled.</param>
        /// <returns>A managed <see cref="TOKEN_PRIVILEGES"/> instance that corresponds to the native content of the memory segment represented by the specified pointer, or <c>null</c> if <paramref name="pNativeData"/> is <see cref="IntPtr.Zero"/>.</returns>
        public static TOKEN_PRIVILEGES MarshalToManagedInstance(IntPtr pNativeData)
        {
            var nativeMarshaledInstance = Marshal.PtrToStructure<TOKEN_PRIVILEGES>(pNativeData);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.PrivilegeCount == 0)
                nativeMarshaledInstance.Privileges = new LUID_AND_ATTRIBUTES[0];
            else if (nativeMarshaledInstance.PrivilegeCount > 1)
            {
                var groupsArray = new LUID_AND_ATTRIBUTES[nativeMarshaledInstance.PrivilegeCount];
                groupsArray[0] = nativeMarshaledInstance.Privileges[0];
                int groupIdx = 1;
                for (IntPtr groupInstancePtr = pNativeData + PrivilegesOffset + LUID_AND_ATTRIBUTES.SizeOf; groupIdx < nativeMarshaledInstance.PrivilegeCount; groupInstancePtr += LUID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                    groupsArray[groupIdx] = Marshal.PtrToStructure<LUID_AND_ATTRIBUTES>(groupInstancePtr);
                nativeMarshaledInstance.Privileges = groupsArray;
            }
            return nativeMarshaledInstance;
        }

        public static TOKEN_PRIVILEGES ReadValue(this ISafeHandleReadableAsTokenPrivileges safeHandle)
            => safeHandle.ReadValue(MarshalToManagedInstance);
    }

    public class TokenPrivilegesAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsTokenPrivileges
    {
        protected TokenPrivilegesAnySafeHandle() : base() { }
        protected TokenPrivilegesAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected TokenPrivilegesAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public TokenPrivilegesAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }
}