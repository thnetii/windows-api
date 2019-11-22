namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 309
    //
    //  Attribute operations that can be specified for a 'set' API:
    //

    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTE_OPERATION"/> enumeration indicates the type of modification to be made to security attributes by a call to the <see cref="AuthzModifySecurityAttributes"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ne-winnt-authz_security_attribute_operation">AUTHZ_SECURITY_ATTRIBUTE_OPERATION Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="AuthzModifySecurityAttributes"/>
    public enum AUTHZ_SECURITY_ATTRIBUTE_OPERATION
    {
        //
        //  No-op
        //

        /// <summary>
        /// Do not perform any modification.
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_NONE = 0,

        //
        //  Delete all existing security attributes and their values in
        //  the NT token and replace it with the specified attributes/values.
        //  If attributes to replace with are not specified, all existing
        //  attributes and values are deleted.
        //
        //  This operation can be specified at most once and must be the
        //  only operation specified.
        //

        /// <summary>
        /// <para>
        /// Delete all existing security attributes and their values in the token and replace them with the specified attributes and values.<br/>
        /// If no new attributes are specified, all existing attributes and values are deleted.
        /// </para>
        /// <para>This operation must be the only operation specified and can be specified only once in a single call to <see cref="AuthzModifySecurityAttributes"/>. If the operation is not specified as the first in the list of operations, the call to <see cref="AuthzModifySecurityAttributes"/> fails. If the operation is specified as the first in the array of operations performed, the rest of the operations are ignored.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_REPLACE_ALL,

        //
        //  Add a new attribute or a new value to an existing attribute.
        //  If the value specified for any attribute already exists for
        //  that attribute, the call fails.
        //

        /// <summary>
        /// Add a new attribute or a new value to an existing attribute.<br/>
        /// If the value specified for any attribute already exists for that attribute, the call to <see cref="AuthzModifySecurityAttributes"/> fails.
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_ADD,

        //
        //  Delete the specified value(s) of the specified attribute(s).
        //  If the last value is deleted from an attribute, the attribute
        //  itself is removed. If no matching attribute name was found, no
        //  modifications are done and the call fails. If no value is specified
        //  for the attribute, the attribute itself will be deleted.
        //

        /// <summary>
        /// Delete the specified values of the specified attributes. If an attribute is specified without a value, that attribute is deleted. <br/>
        /// If this operation results in an attribute that does not contain any values, that attribute is deleted.
        /// <para>If a value is specified that does not match an existing attribute, no modifications are performed and the call to <see cref="AuthzModifySecurityAttributes"/> fails.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_DELETE,

        //
        //  The value(s) of the specified security attribute(s) completely
        //  replace(s) the existing value(s) of the attribute(s). If the
        //  attribute does not already exist, it is added.  When no value
        //  is specified, the attribute is deleted, if it exists; otherwise,
        //  the operation is simply ignored and no failure is reported.
        //

        /// <summary>
        /// The existing values of the specified security attributes are replaced by the specified new values.<br/>
        /// If any of the specified attributes does not already exist, they are added.
        /// <para>When no value is specified for an attribute, that attribute is deleted. Otherwise, the operation is simply ignored and no failure is reported.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_REPLACE
    }
}
