using System;
using System.Runtime.InteropServices;
using System.Threading;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// Represents a safe native memory handle for the <see cref="TOKEN_GROUPS"/> type.
    /// </summary>
    public class TokenGroupsSafeHandle : SafeHandle<TOKEN_GROUPS>
    {
        private static readonly int GroupsOffset = Marshal.OffsetOf<TOKEN_GROUPS>(nameof(TOKEN_GROUPS.Groups)).ToInt32();

        protected TokenGroupsSafeHandle() : this(IntPtr.Zero) { }
        protected TokenGroupsSafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }

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

    public class TokenGroupsCoTaskSafeHandle : TokenGroupsSafeHandle
    {
        private int byteSize;
        private int groupsSize;

        public int ByteSize
        {
            get { return byteSize; }
            set
            {
                if (value < TOKEN_GROUPS.SizeOf)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Value must be at least {TOKEN_GROUPS.SizeOf}, the byte size required for a {nameof(TOKEN_GROUPS)} instance containing a single {nameof(SID_AND_ATTRIBUTES)} element.");
                var byteSize = value;
                handle = Marshal.ReAllocCoTaskMem(handle, byteSize);
                this.byteSize = value;
                groupsSize = 1 + (value - TOKEN_GROUPS.SizeOf) / SID_AND_ATTRIBUTES.SizeOf;
            }
        }

        public int GroupsCapacity
        {
            get { return groupsSize; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be positive");
                var byteSize = CalculateByteSize(value);
                handle = Marshal.ReAllocCoTaskMem(handle, byteSize);
                this.byteSize = byteSize;
                groupsSize = value;
            }
        }

        public TokenGroupsCoTaskSafeHandle(int count) : base(IntPtr.Zero, ownsHandle: true)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), count, "Value must be non-negative");
            else if (count == 0)
                count = 1;
            int byteSize = CalculateByteSize(count);
            handle = Marshal.AllocCoTaskMem(byteSize);
            this.byteSize = byteSize;
            groupsSize = count;
        }

        private static int CalculateByteSize(int count)
        {
            int byteSize = TOKEN_GROUPS.SizeOf;
            byteSize += (count - 1) * SID_AND_ATTRIBUTES.SizeOf;
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
