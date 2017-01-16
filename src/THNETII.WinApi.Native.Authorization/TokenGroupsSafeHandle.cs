using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// Represents a safe native memory handle for the <see cref="TOKEN_GROUPS"/> type.
    /// </summary>
    public class TokenGroupsSafeHandle : SafeHandle<TOKEN_GROUPS>
    {
        private static readonly int GroupsOffset = Marshal.OffsetOf<TOKEN_GROUPS>(nameof(TOKEN_GROUPS.Groups)).ToInt32();

        /// <summary>
        /// Marshals the native data to a managed <see cref="TOKEN_GROUPS"/> instance.
        /// </summary>
        /// <returns>A managed <see cref="TOKEN_GROUPS"/> instance that corresponds to the native content of the memory segment represent by the safe handle.</returns>
        /// <exception cref="ObjectDisposedException">The handle has been closed and the controlled native memory has been released back to the system.</exception>
        /// <exception cref="InvalidOperationException">The native memory handle has an invalid value.</exception>
        public override TOKEN_GROUPS MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            var nativeMarshaledInstance = Marshal.PtrToStructure<TOKEN_GROUPS>(handle);
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
                for (IntPtr groupInstancePtr = handle + GroupsOffset + SID_AND_ATTRIBUTES.SizeOf; groupIdx < nativeMarshaledInstance.GroupCount; groupInstancePtr += SID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                    groupsArray[groupIdx] = Marshal.PtrToStructure<SID_AND_ATTRIBUTES>(groupInstancePtr);
                nativeMarshaledInstance.Groups = groupsArray;
            }
            return nativeMarshaledInstance;
        }
    }
}
