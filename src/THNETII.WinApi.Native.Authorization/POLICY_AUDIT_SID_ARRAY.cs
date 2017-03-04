using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="POLICY_AUDIT_SID_ARRAY"/> structure specifies an array of <see cref="SecurityIdentifier"/> structures that represent Windows users or groups.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa965823.aspx">POLICY_AUDIT_SID_ARRAY structure</a></para>
    /// </remarks>
    /// <seealso cref="AuditEnumeratePerUserPolicy"/>
    /// <seealso cref="SecurityIdentifier"/>
    [StructLayout(LayoutKind.Sequential)]
    public class POLICY_AUDIT_SID_ARRAY
    {
        /// <summary>
        /// The number of pointers in the <see cref="UserSidArray"/> array.
        /// </summary>
        public int UsersCount;
        /// <summary>
        /// An array of pointers to <see cref="SecurityIdentifier"/> structures that specify Windows users or groups.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] UserSidArray;

        public SecurityIdentifier[] MarshalUserSidArrayToManagedInstances() => UserSidArray?.Select(userSidPtr => new SecurityIdentifier(userSidPtr)).ToArray();
    }

    public interface ISafeHandleReadableAsPOLICY_AUDIT_SID_ARRAY : ISafeHandleReadableAs<SecurityIdentifier[]> { }

    public static class PolicyAuditSidArraySafeHandle
    {
        private static readonly int UserSidArrayOffset = Marshal.OffsetOf<POLICY_AUDIT_SID_ARRAY>(nameof(POLICY_AUDIT_SID_ARRAY.UserSidArray)).ToInt32();

        public static SecurityIdentifier[] MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;
            var nativeMarshaledInstance = Marshal.PtrToStructure<POLICY_AUDIT_SID_ARRAY>(pNativeData);
            if (nativeMarshaledInstance == null)
                return null;
            else if (nativeMarshaledInstance.UsersCount == 0)
                nativeMarshaledInstance.UserSidArray = new IntPtr[0];
            else if (nativeMarshaledInstance.UsersCount > 1)
            {
                var groupsArray = new IntPtr[nativeMarshaledInstance.UsersCount];
                Marshal.Copy(pNativeData + UserSidArrayOffset, groupsArray, startIndex: 0, length: groupsArray.Length);
                nativeMarshaledInstance.UserSidArray = groupsArray;
            }
            return nativeMarshaledInstance.UserSidArray.Select(userSidPtr => new SecurityIdentifier(userSidPtr)).ToArray();
        }

        public static SecurityIdentifier[] ReadValue<THandle>(this THandle safeHandle)
            where THandle : SafeHandle, ISafeHandleReadableAsPOLICY_AUDIT_SID_ARRAY
            => safeHandle.ReadValue(MarshalNativeToManaged);
    }
}