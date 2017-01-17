using System;
using System.Runtime.InteropServices;
using System.Threading;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class PrivilegeSetSafeHandle : SafeHandle<PRIVILEGE_SET>
    {
        private static readonly int PrivilegeOffset = Marshal.OffsetOf<PRIVILEGE_SET>(nameof(PRIVILEGE_SET.Privilege)).ToInt32();

        protected PrivilegeSetSafeHandle() : this(IntPtr.Zero) { }
        protected PrivilegeSetSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }

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
        private int privilegesSize;

        public int ByteSize => byteSize;

        public int PrivilegeCapacity
        {
            get { return privilegesSize; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be positive");
                var byteSize = CalculateByteSize(value);
                handle = Marshal.ReAllocCoTaskMem(handle, byteSize);
                this.byteSize = byteSize;
                privilegesSize = value;
            }
        }

        public PrivilegeSetCoTaskMemSafeHandle(int count) : base(IntPtr.Zero, ownsHandle: true)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), count, "Value must be non-negative");
            else if (count == 0)
                count = 1;
            int byteSize = CalculateByteSize(count);
            handle = Marshal.AllocCoTaskMem(byteSize);
            this.byteSize = byteSize;
            privilegesSize = count;
        }

        private static int CalculateByteSize(int count)
        {
            int byteSize = PRIVILEGE_SET.SizeOf;
            byteSize += (count - 1) * LUID_AND_ATTRIBUTES.SizeOf;
            return byteSize;
        }

        protected override bool ReleaseHandle()
        {
            var currentHandle = Interlocked.Exchange(ref handle, IntPtr.Zero);
            if (currentHandle == IntPtr.Zero)
                return false;
            Marshal.FreeCoTaskMem(handle);
            return true;
        }
    }
}