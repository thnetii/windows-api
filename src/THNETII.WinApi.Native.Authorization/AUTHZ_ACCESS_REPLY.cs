using Microsoft.Win32.WinApi.WinError;
using System.Linq;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.ACCESS_MASK;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// The <see cref="AUTHZ_ACCESS_REPLY"/> structure defines an access check reply.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa376321.aspx">AUTHZ_ACCESS_REPLY structure</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheck"/>
    [StructLayout(LayoutKind.Sequential)]
    public class AUTHZ_ACCESS_REPLY
    {
        /// <summary>
        /// The number of elements in the <see cref="GrantedAccessMask"/>, <see cref="SaclEvaluationResults"/>, and <see cref="Error"/> arrays. This number matches the number of entries in the object type list structure used in the access check. If no object type is used to represent the object, then set <see cref="ResultListLength"/> to one.
        /// </summary>
        public int ResultListLength;
        /// <summary>
        /// An array of granted access masks. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>.
        /// <para>The <see cref="GetMarshaledGrantedAccessMaskArray"/> method is a convenience method that returns the granted access masks as a marshaled managed array instance.</para>
        /// </summary>
        public AccessMaskArrayAnySafeHandle GrantedAccessMask;
        public ACCESS_MASK[] GetMarshaledGrantedAccessMaskArray() => GrantedAccessMask.ReadValue(ResultListLength);
        /// <summary>
        /// An array of <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_system_access_control_list_gly">system access control list</a></em> (SACL) evaluation results. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>. SACL evaluation will only be performed if auditing is requested.
        /// <para>The <see cref="GetMarshaledSaclEvaluationResultsArray"/> method is a convenience method that returns the SACL evaluation results as a marshaled managed array instance.</para>
        /// </summary>
        public AuthzEvaluationResultArrayAnySafeHandle SaclEvaluationResults;
        public AUTHZ_EVALUATION_RESULT[] GetMarshaledSaclEvaluationResultsArray() => SaclEvaluationResults.ReadValue(ResultListLength);
        /// <summary>
        /// An array of results for each element of the array. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>. 
        /// <para>The <see cref="GetErrorArray"/> method is a convenience method that returns the error values as a marshaled managed array instance.</para>
        /// </summary>
        /// <remarks>
        /// The following table lists the possible error values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <term><see cref="ERROR_SUCCESS"/></term> <description>All the access bits, not including <see cref="MAXIMUM_ALLOWED"/>, are granted and the <see cref="GrantedAccessMask"/> member is not <c>null</c>.</description>
        /// <term><see cref="ERROR_PRIVILEGE_NOT_HELD"/></term> <description>DesiredAccess includes <see cref="ACCESS_SYSTEM_SECURITY"/> and the client does not have <strong>SeSecurityPrivilege</strong>.</description>
        /// <term><see cref="ERROR_ACCESS_DENIED"/></term> <description>Includes each of the following: <list type="bullet"><item>The requested bits are not granted.</item> <item>MaximumAllowed bit is on and granted access is zero.</item> <item>DesiredAccess is zero.</item></list></description>
        /// </list>
        /// </remarks>
        public Int32ArrayAnySafeHandle Error;
        public Win32ErrorCode[] GetErrorArray() => Int32ArraySafeHandle.ReadValue(Error, ResultListLength).Cast<Win32ErrorCode>().ToArray();
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
