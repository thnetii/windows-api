using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// Represents a safe native memory handle for the <see cref="TOKEN_GROUPS"/> type.
    /// </summary>
    /// <remarks>Becuase managed arrays in contain <see cref="Array.Length"/> information, the <see cref="TOKEN_GROUPS"/> type is superflous and this Safe Handle implementation wraps the <see cref="SID_AND_ATTRIBUTES"/> instance directly.</remarks>
    public class TokenGroupsSafeHandle : SafeHandle<SID_AND_ATTRIBUTES[]>
    {
        private static readonly int GroupsOffset = Marshal.OffsetOf<TOKEN_GROUPS>(nameof(TOKEN_GROUPS.Groups)).ToInt32();

        /// <summary>
        /// Marshals the native <see cref="TOKEN_GROUPS"/> instance directory to a managed array containing the <see cref="TOKEN_GROUPS.Groups"/> values stored within the <see cref="TOKEN_GROUPS"/> instance.
        /// </summary>
        /// <returns>A managed array instance of <see cref="SID_AND_ATTRIBUTES"/> that corresponds to the native content of the <see cref="TOKEN_GROUPS.Groups"/> member in the <see cref="TOKEN_GROUPS"/> instance.</returns>
        /// <exception cref="ObjectDisposedException">The handle has been closed and the controlled native memory has been released back to the system.</exception>
        /// <exception cref="InvalidOperationException">The native memory handle has an invalid value.</exception>
        public override SID_AND_ATTRIBUTES[] MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            var nativeMarshaledInstance = Marshal.PtrToStructure<TOKEN_GROUPS>(handle);
            if (nativeMarshaledInstance == null)
                return null;
            var groupsArray = new SID_AND_ATTRIBUTES[nativeMarshaledInstance.GroupCount];
            int groupIdx = 0;
            for (IntPtr groupInstancePtr = handle + GroupsOffset; groupIdx < nativeMarshaledInstance.GroupCount; groupInstancePtr += SID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                groupsArray[groupIdx] = Marshal.PtrToStructure<SID_AND_ATTRIBUTES>(groupInstancePtr);
            return groupsArray;
        }
    }
}
