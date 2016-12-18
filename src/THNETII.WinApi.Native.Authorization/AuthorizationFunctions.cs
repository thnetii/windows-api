using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public static class AuthorizationFunctions
    {
        #region AuthzAccessCheckCallback callback function
        /// <summary>
        /// The <see cref="AuthzAccessCheckCallback"/> function is an application-defined function that handles callback <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs) during an access check. <see cref="AuthzAccessCheckCallback"/> is a placeholder for the application-defined function name. The application registers this callback by calling <see cref="AuthzInitializeResourceManager"/>. 
        /// </summary>
        /// <param name="hAuthzClientContext">A handle to a client context.</param>
        /// <param name="pAce">A reference to a <see cref="GenericAce"/> to evaluate for inclusion in the call to the <see cref="AuthzAccessCheck"/> function.</param>
        /// <param name="pArgs">Data passed in the <em>DynamicGroupArgs</em> parameter of the call to <see cref="AuthzAccessCheck"/> or <see cref="AuthzCachedAccessCheck"/>.</param>
        /// <param name="pbAceApplicable">
        /// <para>A Boolean reference variable that receives the results of the evaluation of the logic defined by the application.</para>
        /// <para>The results are <c>true</c> if the logic determines that the ACE is applicable and will be included in the call to <see cref="AuthzAccessCheck"/>; otherwise, the results are <c>false</c>.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the function returns <c>true</c>.<br/>
        /// If the function is unable to perform the evaluation, it returns <c>false</c>. Use <see cref="SetLastError"/> to return an error to the access check function.
        /// </returns>
        /// <remarks>
        /// <para>Security attribute variables must be present in the client context if referred to in a conditional expression, otherwise the conditional expression term referencing them will evaluate to unknown.</para>
        /// <para>For more information, see the <a href="https://msdn.microsoft.com/en-us/library/aa446683.aspx">How AccessCheck Works</a> and <a href="https://msdn.microsoft.com/en-us/library/jj662749.aspx">Centralized Authorization Policy</a> overviews.</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa375794.aspx">AuthzAccessCheckCallback callback function</a></para>
        /// </remarks>
        /// <seealso cref="AuthzAccessCheck"/>
        /// <seealso cref="AuthzCachedAccessCheck"/>
        /// <seealso cref="AuthzInitializeRemoteResourceManager"/>
        /// <seealso cref="AuthzInitializeResourceManager"/>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool AuthzAccessCheckCallback(
            [In] IntPtr hAuthzClientContext,
            [In, MarshalAs(44, MarshalTypeRef = typeof(GenericAceCustomMarshaler))] GenericAce pAce,
            [In, Optional] IntPtr pArgs,
            ref bool pbAceApplicable
            );
        #endregion
    }
}
