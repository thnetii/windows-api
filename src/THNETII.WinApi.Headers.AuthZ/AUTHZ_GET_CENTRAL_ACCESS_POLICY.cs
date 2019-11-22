using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 229
    //
    // Callback central access policy retrieval function takes in
    //     AuthzClientContext - a client context
    //     capid - CAPID of the central access policy to retrieve.
    //     pArgs - Optional arguments that were passed to AuthzAccessCheck through
    //         AuthzAccessRequest->OptionalArguments are passed back here.
    //     pCentralAccessPolicyApplicable - The resource manager must indicate 
    //         whether a central access policy should be used in access evaluation.
    //     ppCentralAccessPolicy - Pointer to the CAP to be used in the 
    //         computation of access evaluation. If NULL, the default CAP is applied.
    //
    // Returns
    //     TRUE if the API succeeded.
    //     FALSE on any intermediate errors (like failed memory allocation)
    //         In case of failure, the caller must use SetLastError(ErrorValue).
    //

    /// <summary>
    /// Callback central access policy retrieval function
    /// </summary>
    /// <param name="hAuthzClientContext">a client context</param>
    /// <param name="capid">CAPID of the central access policy to retrieve.</param>
    /// <param name="pArgs">
    /// Optional arguments that were passed to AuthzAccessCheck through
    /// AuthzAccessRequest->OptionalArguments are passed back here.
    /// </param>
    /// <param name="pCentralAccessPolicyApplicable">
    /// The resource manager must indicate
    /// whether a central access policy should be used in access evaluation.
    /// </param>
    /// <param name="ppCentralAccessPolicy">
    /// Pointer to the CAP to be used in the
    /// computation of access evaluation. If NULL, the default CAP is applied.
    /// </param>
    /// <returns>
    /// <para><see langword="true"/> if the API succeeded.</para>
    /// <para>
    /// <see langword="false"/> on any intermediate errors (like failed memory allocation)
    /// In case of failure, the caller must use <see cref="SetLastError"/>.
    /// </para>
    /// </returns>
    [UnmanagedFunctionPointer(CallingConvention.Winapi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public unsafe delegate bool AUTHZ_GET_CENTRAL_ACCESS_POLICY(
        [In] AUTHZ_CLIENT_CONTEXT_HANDLE hAuthzClientContext,
        in SID capid,
        [In] IntPtr pArgs,
        [MarshalAs(UnmanagedType.Bool)] out bool pCentralAccessPolicyApplicable,
        out IntPtr ppCentralAccessPolicy
        );
}
