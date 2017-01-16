using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class PrivilegeSetSafeHandle : SafeHandle<PRIVILEGE_SET>
    {
        private static readonly int PrivilegeOffset = Marshal.OffsetOf<PRIVILEGE_SET>(nameof(PRIVILEGE_SET.Privilege)).ToInt32();

        /// <summary>
        /// Marshals the native data to a managed <see cref="PRIVILEGE_SET"/> instance.
        /// </summary>
        /// <returns>A managed <see cref="PRIVILEGE_SET"/> instance that corresponds to the native content of the memory segment represent by the safe handle.</returns>
        /// <exception cref="ObjectDisposedException">The handle has been closed and the controlled native memory has been released back to the system.</exception>
        /// <exception cref="InvalidOperationException">The native memory handle has an invalid value.</exception>
        public override PRIVILEGE_SET MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            var nativeMarshaledInstance = Marshal.PtrToStructure<PRIVILEGE_SET>(handle);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.PrivilegeCount == 0)
                nativeMarshaledInstance.Privilege = new LUID_AND_ATTRIBUTES[0];
            else if (nativeMarshaledInstance.PrivilegeCount > 1)
            {
                var groupsArray = new LUID_AND_ATTRIBUTES[nativeMarshaledInstance.PrivilegeCount];
                groupsArray[0] = nativeMarshaledInstance.Privilege[0];
                int groupIdx = 1;
                for (IntPtr groupInstancePtr = handle + PrivilegeOffset + LUID_AND_ATTRIBUTES.SizeOf; groupIdx < nativeMarshaledInstance.PrivilegeCount; groupInstancePtr += LUID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                    groupsArray[groupIdx] = Marshal.PtrToStructure<LUID_AND_ATTRIBUTES>(groupInstancePtr);
                nativeMarshaledInstance.Privilege = groupsArray;
            }
            return nativeMarshaledInstance;
        }
    }

    public class PrivilegeSetCoTaskMemSafeHandle : PrivilegeSetSafeHandle
    {
        private int byteSize;

        public PrivilegeSetCoTaskMemSafeHandle(int count) : base()
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), count, "Value must be non-negative");
            else if (count == 0)
                count = 1;
            int byteSize = PRIVILEGE_SET.SizeOf;
            byteSize += (count - 1) * LUID_AND_ATTRIBUTES.SizeOf;
            handle = Marshal.AllocCoTaskMem(byteSize);
            this.byteSize = byteSize;
        }

        protected override bool ReleaseHandle()
        {
            Marshal.FreeCoTaskMem(handle);
            return true;
        }
    }
}