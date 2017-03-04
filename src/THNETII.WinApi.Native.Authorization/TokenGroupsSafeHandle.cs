using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public interface ISafeHandleReadableAsTokenGroups : ISafeHandleReadableAs<TOKEN_GROUPS> { }

    public static class TokenGroupsSafeHandle
    {
        private static readonly int GroupsOffset = Marshal.OffsetOf<TOKEN_GROUPS>(nameof(TOKEN_GROUPS.Groups)).ToInt32();

        /// <summary>
        /// Marshals the native data to a managed <see cref="TOKEN_GROUPS"/> instance.
        /// </summary>
        /// <param name="pNativeData">The pointer value to the memory containing the native data to be marshaled.</param>
        /// <returns>A managed <see cref="TOKEN_GROUPS"/> instance that corresponds to the native content of the memory segment represent by the pointer, or <c>null</c> if <paramref name="pNativeData"/> is <see cref="IntPtr.Zero"/>.</returns>
        public static TOKEN_GROUPS MarshalNativeToManaged(IntPtr pNativeData)
        {
            var nativeMarshaledInstance = Marshal.PtrToStructure<TOKEN_GROUPS>(pNativeData);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.GroupCount == 0)
            {
                nativeMarshaledInstance.Groups = new SID_AND_ATTRIBUTES[0];
            }
            else if (nativeMarshaledInstance.GroupCount > 1)
            {
                var groupsArray = new SID_AND_ATTRIBUTES[nativeMarshaledInstance.GroupCount];
                groupsArray[0] = nativeMarshaledInstance.Groups[0];
                int groupIdx = 1;
                for (IntPtr groupInstancePtr = pNativeData + GroupsOffset + SID_AND_ATTRIBUTES.SizeOf; groupIdx < nativeMarshaledInstance.GroupCount; groupInstancePtr += SID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                    groupsArray[groupIdx] = Marshal.PtrToStructure<SID_AND_ATTRIBUTES>(groupInstancePtr);
                nativeMarshaledInstance.Groups = groupsArray;
            }
            return nativeMarshaledInstance;
        }

        public static TOKEN_GROUPS ReadValue<THandle>(this THandle safeHandle)
            where THandle : SafeHandle, ISafeHandleReadableAsTokenGroups
            => safeHandle.ReadValue(MarshalNativeToManaged);
    }

    public class TokenGroupsAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsTokenGroups
    {
        protected TokenGroupsAnySafeHandle() : base() { }
        protected TokenGroupsAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected TokenGroupsAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public TokenGroupsAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }

    public class TokenGroupsCoTaskMemSafeHandle : CoTaskMemSafeHandle, ISafeHandleReadableAsTokenGroups
    {
        public TokenGroupsCoTaskMemSafeHandle(int count) : base(CalculateByteSize(count)) { }

        private static int CalculateByteSize(int count)
        {
            int byteSize = TOKEN_GROUPS.SizeOf;
            byteSize += (count - 1) * SID_AND_ATTRIBUTES.SizeOf;
            return byteSize;
        }

        public static implicit operator TokenGroupsAnySafeHandle(TokenGroupsCoTaskMemSafeHandle safeHandle)
            => safeHandle != null ? new TokenGroupsAnySafeHandle(invalidHandleValue, safeHandle) : null;
    }
}
