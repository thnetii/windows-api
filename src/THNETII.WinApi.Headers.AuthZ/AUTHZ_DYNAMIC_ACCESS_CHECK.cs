using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 161
    //
    // Typedefs for callback functions to be provided by the resource manager.
    //

    //
    // Callback access check function takes in
    //     AuthzClientContext - a client context
    //     pAce - pointer to a callback ace
    //     pArgs - Optional arguments that were passed to AuthzAccessCheck thru
    //             AuthzAccessRequest->OptionalArguments are passed back here.
    //     pbAceApplicable - The resource manager must supply whether the ace should
    //         be used in the computation of access evaluation
    //
    // Returns
    //     TRUE if the API succeeded.
    //     FALSE on any intermediate errors (like failed memory allocation)
    //         In case of failure, the caller must use SetLastError(ErrorValue).
    //

    /// <summary>
    /// Callback access check function
    /// </summary>
    /// <param name="hAuthzClientContext">a client context</param>
    /// <param name="pAce">pointer to a callback ace</param>
    /// <param name="pArgs">
    /// Optional arguments that were passed to AuthzAccessCheck thru
    /// AuthzAccessRequest->OptionalArguments are passed back here.
    /// </param>
    /// <param name="pbAceApplicable">
    /// The resource manager must supply whether the ace should
    /// be used in the computation of access evaluation
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
    public unsafe delegate bool AUTHZ_DYNAMIC_ACCESS_CHECK(
        [In] AUTHZ_CLIENT_CONTEXT_HANDLE hAuthzClientContext,
        [In] IntPtr pAce,
        [In, Optional] IntPtr pArgs,
        [MarshalAs(UnmanagedType.Bool)] ref bool pbAceApplicable
        );
}
