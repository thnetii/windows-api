using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 83
    //
    // Structure defining the access check request.
    //

    /// <summary>
    /// The <see cref="AUTHZ_ACCESS_REQUEST"/> structure defines an access check request.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_access_request">AUTHZ_ACCESS_REQUEST structure</a></para>
    /// </remarks>
    /// <seealso cref="AuthzAccessCheckCallback"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_ACCESS_REQUEST
    {
        /// <summary>
        /// The type of access to test for.
        /// </summary>
        public ACCESS_MASK DesiredAccess;

        //
        // To replace the principal self sid in the acl.
        //

        /// <summary>
        /// The <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security identifier</a> (SID) to use for the principal self SID in the <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control list</a> (ACL).
        /// </summary>
        public SID* PrincipalSelfSid;

        //
        // Object type list represented by an array of (level, guid) pair and the
        // number of elements in the array. This is a post-fix representation of the
        // object tree.
        // These fields should be set to NULL and 0 respectively except when per
        // property access is desired.
        //

        #region public Span<OBJECT_TYPE_LIST> ObjectTypeList;
        public OBJECT_TYPE_LIST* pObjectTypeList;
        /// <summary>
        /// A span of <see cref="OBJECT_TYPE_LIST"/> structures in the object tree for the object. Set to an empty span unless the application checks access at the property level.
        /// </summary>
        public Span<OBJECT_TYPE_LIST> ObjectTypeList =>
            new Span<OBJECT_TYPE_LIST>(pObjectTypeList, ObjectTypeListLength);
        #endregion
        /// <summary>
        /// The number of elements in the <see cref="ObjectTypeList"/> array. This member is necessary only if the application checks access at the property level.
        /// </summary>
        public int ObjectTypeListLength;

        //
        // To support completely business rules based access. This will be passed as
        // input to the callback access check function. Access check algorithm does
        // not interpret these.
        //

        /// <summary>
        /// A pointer to memory to pass to <see cref="AuthzAccessCheckCallback"/> when checking callback <a href="https://docs.microsoft.com/windows/desktop/SecGloss/a-gly">access control entries</a> (ACEs).
        /// </summary>
        public IntPtr OptionalArguments;
    }
}
