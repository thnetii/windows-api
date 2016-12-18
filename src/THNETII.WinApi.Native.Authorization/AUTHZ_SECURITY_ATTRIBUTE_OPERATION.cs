namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="AUTHZ_SECURITY_ATTRIBUTE_OPERATION"/> enumeration indicates the type of modification to be made to security attributes by a call to the <see cref="AuthzModifySecurityAttributes"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/dd401615.aspx">AUTHZ_SECURITY_ATTRIBUTE_OPERATION enumeration</a></para>
    /// </remarks>
    /// <seealso cref="AuthzModifySecurityAttributes"/>
    public enum AUTHZ_SECURITY_ATTRIBUTE_OPERATION
    {
        /// <summary>Do not perform any modification.</summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_NONE = 0,
        /// <summary>
        /// <para>Delete all existing security attributes and their values in the token and replace them with the specified attributes and values.</para>
        /// <para>If no new attributes are specified, all existing attributes and values are deleted.</para>
        /// <para>This operation must be the only operation specified and can be specified only once in a single call to <see cref="AuthzModifySecurityAttributes"/>. If the operation is not specified as the first in the list of operations, the call to <see cref="AuthzModifySecurityAttributes"/> fails. If the operation is specified as the first in the array of operations performed, the rest of the operations are ignored.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_REPLACE_ALL,
        /// <summary>
        /// <para>Add a new attribute or a new value to an existing attribute.</para>
        /// <para>If the value specified for any attribute already exists for that attribute, the call to <see cref="AuthzModifySecurityAttributes"/> fails.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_ADD,
        /// <summary>
        /// <para>Delete the specified values of the specified attributes. If an attribute is specified without a value, that attribute is deleted.</para>
        /// <para>If this operation results in an attribute that does not contain any values, that attribute is deleted.</para>
        /// <para>If a value is specified that does not match an existing attribute, no modifications are performed and the call to <see cref="AuthzModifySecurityAttributes"/> fails.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_DELETE,
        /// <summary>
        /// <para>The existing values of the specified security attributes are replaced by the specified new values.</para>
        /// <para>If any of the specified attributes does not already exist, they are added.</para>
        /// <para>When no value is specified for an attribute, that attribute is deleted. Otherwise, the operation is simply ignored and no failure is reported.</para>
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_OPERATION_REPLACE
    }
}
