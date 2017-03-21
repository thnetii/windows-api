using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUTHZ_ACCESS_REQUEST"/> structure defines an access check request.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa376322.aspx">AUTHZ_ACCESS_REQUEST structure</a></para>
    /// </remarks>
    /// <seealso cref="AuthzAccessCheckCallback"/>
    [StructLayout(LayoutKind.Sequential)]
    public class AUTHZ_ACCESS_REQUEST
    {
        /// <summary>The type of access to test for.</summary>
        public ACCESS_MASK DesiredAccess;
        /// <summary>
        /// The <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) to use for the principal self SID in the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_list_gly">access control list</a></em> (ACL).
        /// </summary>
        public SecurityIdentifierAnySafeHandle PrincipalSelfSid;
        /// <summary>
        /// Marshal to managed instance: The <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) to use for the principal self SID in the <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_list_gly">access control list</a></em> (ACL).
        /// </summary>
        /// <returns>A <see cref="SecurityIdentifier"/> instance that is initialized with the value of <see cref="PrincipalSelfSid"/>, or <c>null</c> if <see cref="PrincipalSelfSid"/> is <see cref="IntPtr.Zero"/>.</returns>
        public SecurityIdentifier GetMarshaledPrincipalSelfSid() => SecurityIdentifierSafeHandle.ReadValue(PrincipalSelfSid);
        /// <summary>
        /// An handle for an array of <see cref="OBJECT_TYPE_LIST"/> structures in the object tree for the object. Set to <c>null</c> unless the application checks access at the property level.
        /// </summary>
        public ObjectTypeListArrayAnySafeHandle ObjectTypeList;
        /// <summary>
        /// The number of elements in the <see cref="ObjectTypeList"/> array. This member is necessary only if the application checks access at the property level.
        /// </summary>
        public int ObjectTypeListLength;
        public OBJECT_TYPE_LIST[] GetObjectTypeListArray() => ObjectTypeList.ReadValue(ObjectTypeListLength);
        /// <summary>
        /// A pointer to memory to pass to <see cref="AuthzAccessCheckCallback"/> when checking callback <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs).
        /// </summary>
        public IntPtr OptionalArguments;
    }
}
