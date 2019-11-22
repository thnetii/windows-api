using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinError;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AuthZ
{
    using static WinNTConstants;
    using static WinErrorConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 118
    //
    // Structure to return the results of the access check call.
    //

    /// <summary>
    /// The <see cref="AUTHZ_ACCESS_REPLY"/> structure defines an access check reply.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/authz/ns-winnt-authz_access_reply">AUTHZ_ACCESS_REPLY structure</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheck"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AUTHZ_ACCESS_REPLY
    {
        //
        // The length of the array representing the object type list structure. If
        // no object type is used to represent the object, then the length must be
        // set to 1.
        //
        // Note: This parameter must be filled!
        //

        /// <summary>
        /// The number of elements in the <see cref="GrantedAccessMask"/>, <see cref="SaclEvaluationResults"/>, and <see cref="Error"/> arrays. This number matches the number of entries in the object type list structure used in the access check. If no object type is used to represent the object, then set <see cref="ResultListLength"/> to one.
        /// </summary>
        public int ResultListLength;

        #region public Span<ACESS_MASK> GrantedAccessMask;
        //
        // Array of granted access masks. This memory is allocated by the RM. Access
        // check routines just fill in the values.
        //

        public ACCESS_MASK* GrantedAccessMaskPtr;
        /// <summary>
        /// An span of granted access masks. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>.
        /// </summary>
        public Span<ACCESS_MASK> GrantedAccessMask =>
            new Span<ACCESS_MASK>(GrantedAccessMaskPtr, ResultListLength);
        #endregion

        #region public Span<int> SaclEvaluationResults;
        //
        // Array of SACL evaluation results.  This memory is allocated by the RM, if SACL
        // evaluation results are desired. Access check routines just fill in the values.
        // Sacl evaluation will only be performed if auditing is requested.
        //

        public AUTHZ_GENERATE_RESULT* SaclEvaluationResultsPtr;
        /// <summary>
        /// A span of <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">system access control list</a> (SACL) evaluation results. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>. SACL evaluation will only be performed if auditing is requested.
        /// </summary>
        public Span<AUTHZ_GENERATE_RESULT> SaclEvaluationResults =>
            new Span<AUTHZ_GENERATE_RESULT>(SaclEvaluationResultsPtr, ResultListLength);
        #endregion

        #region public Span<int> Error;
        //
        // Array of results for each element of the array. This memory is allocated
        // by the RM. Access check routines just fill in the values.
        //

        public int* ErrorPtr;
        /// <summary>
        /// A span of results for each element of the array. Memory for this array is allocated by the application before calling <see cref="AccessCheck"/>.
        /// <para>
        /// The following table lists the possible error values.
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><see cref="ERROR_SUCCESS"/></term><description>All the access bits, not including <see cref="MAXIMUM_ALLOWED"/>, are granted and the <see cref="GrantedAccessMask"/> member is not zero.</description></item>
        /// <item><term><see cref="ERROR_PRIVILEGE_NOT_HELD"/></term><description>DesiredAccess includes <see cref="ACCESS_SYSTEM_SECURITY"/> and the client does not have <see cref="SeSecurityPrivilege"/>.</description></item>
        /// <item><term><see cref="ERROR_ACCESS_DENIED"/></term><description>Includes each of the following: <list type="bullet"><item>The requested bits are not granted.</item><item>MaximumAllowed bit is on and granted access is zero.</item><item>DesiredAccess is zero.</item></list></description></item>
        /// </list>
        /// </para>
        /// </summary>
        public Span<int> Error => new Span<int>(ErrorPtr, ResultListLength);
        #endregion
    }
}
