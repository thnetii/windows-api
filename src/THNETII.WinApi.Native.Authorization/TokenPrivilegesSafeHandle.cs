using System;
using System.Runtime.InteropServices;
using System.Threading;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class TokenPrivilegesSafeHandle : SafeHandle<TOKEN_PRIVILEGES>
    {
        private static readonly int PrivilegesOffset = Marshal.OffsetOf<TOKEN_PRIVILEGES>(nameof(TOKEN_PRIVILEGES.Privileges)).ToInt32();

        protected TokenPrivilegesSafeHandle() : this(IntPtr.Zero) { }
        protected TokenPrivilegesSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }

        /// <summary>
        /// Marshals the native data to a managed <see cref="TOKEN_PRIVILEGES"/> instance.
        /// </summary>
        /// <returns>A managed <see cref="TOKEN_PRIVILEGES"/> instance that corresponds to the native content of the memory segment represent by the safe handle.</returns>
        /// <exception cref="ObjectDisposedException">The handle has been closed and the controlled native memory has been released back to the system.</exception>
        /// <exception cref="InvalidOperationException">The native memory handle has an invalid value.</exception>
        public override TOKEN_PRIVILEGES MarshalToManagedInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));
            else if (IsInvalid)
                throw new InvalidOperationException("The native memory handle has an invalid value.");
            var nativeMarshaledInstance = Marshal.PtrToStructure<TOKEN_PRIVILEGES>(handle);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.PrivilegeCount == 0)
                nativeMarshaledInstance.Privileges = new LUID_AND_ATTRIBUTES[0];
            else if (nativeMarshaledInstance.PrivilegeCount > 1)
            {
                var groupsArray = new LUID_AND_ATTRIBUTES[nativeMarshaledInstance.PrivilegeCount];
                groupsArray[0] = nativeMarshaledInstance.Privileges[0];
                int groupIdx = 1;
                for (IntPtr groupInstancePtr = handle + PrivilegesOffset + LUID_AND_ATTRIBUTES.SizeOf; groupIdx < nativeMarshaledInstance.PrivilegeCount; groupInstancePtr += LUID_AND_ATTRIBUTES.SizeOf, groupIdx++)
                    groupsArray[groupIdx] = Marshal.PtrToStructure<LUID_AND_ATTRIBUTES>(groupInstancePtr);
                nativeMarshaledInstance.Privileges = groupsArray;
            }
            return nativeMarshaledInstance;
        }
    }

    public class TokenPrivilegesCoTaskSafeHandle : TokenPrivilegesSafeHandle
    {
        private int byteSize;
        private int privilegesSize;

        public int ByteSize
        {
            get { return byteSize; }
            set
            {
                if (value < TOKEN_PRIVILEGES.SizeOf)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Value must be at least {TOKEN_PRIVILEGES.SizeOf}, the byte size required for a {nameof(TOKEN_PRIVILEGES)} instance containing a single {nameof(LUID_AND_ATTRIBUTES)} element.");
                var byteSize = value;
                handle = Marshal.ReAllocCoTaskMem(handle, byteSize);
                this.byteSize = value;
                privilegesSize = 1 + (value - TOKEN_PRIVILEGES.SizeOf) / LUID_AND_ATTRIBUTES.SizeOf;
            }
        }

        public int PrivilegesCapacity
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

        public TokenPrivilegesCoTaskSafeHandle(int count) : base(IntPtr.Zero, ownsHandle: true)
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
            int byteSize = TOKEN_PRIVILEGES.SizeOf;
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