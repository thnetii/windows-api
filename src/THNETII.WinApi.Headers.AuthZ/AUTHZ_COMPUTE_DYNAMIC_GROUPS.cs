using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AuthZ
{
    //
    // Callback compute dynamic groups function takes in
    //     AuthzClientContext - a client context
    //     pArgs - Optional arguments that supplied to AuthzInitializeClientContext*
    //         thru DynamicGroupArgs are passed back here..
    //     pSidAttrArray - To allocate and return an array of (sids, attribute)
    //         pairs to be added to the normal part of the client context.
    //     pSidCount - Number of elements in pSidAttrArray
    //     pRestrictedSidAttrArray - To allocate and return an array of (sids, attribute)
    //         pairs to be added to the restricted part of the client context.
    //     pRestrictedSidCount - Number of elements in pRestrictedSidAttrArray
    //
    // Note:
    //    Memory returned thru both these array will be freed by the callback
    //    free function defined by the resource manager.
    //
    // Returns
    //     TRUE if the API succeeded.
    //     FALSE on any intermediate errors (like failed memory allocation)
    //         In case of failure, the caller must use SetLastError(ErrorValue).
    //

    /// <summary>
    /// Callback compute dynamic groups function
    /// </summary>
    /// <param name="hAuthzClientContext">a client context</param>
    /// <param name="Args">
    /// Optional arguments that supplied to AuthzInitializeClientContext*
    /// thru DynamicGroupArgs are passed back here..
    /// </param>
    /// <param name="pSidAttrArray">
    /// To allocate and return an array of (sids, attribute)
    /// pairs to be added to the normal part of the client context.
    /// </param>
    /// <param name="pSidCount">Number of elements in <paramref name="pSidAttrArray"/></param>
    /// <param name="pRestrictedSidAttrArray">
    /// To allocate and return an array of (sids, attribute)
    /// pairs to be added to the restricted part of the client context.
    /// </param>
    /// <param name="pRestrictedSidCount">Number of elements in <paramref name="pRestrictedSidAttrArray"/></param>
    /// <returns>
    /// <para><see langword="true"/> if the API succeeded.</para>
    /// <para>
    /// <see langword="false"/> on any intermediate errors (like failed memory allocation)
    /// In case of failure, the caller must use <see cref="SetLastError"/>.
    /// </para>
    /// </returns>
    [UnmanagedFunctionPointer(CallingConvention.Winapi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public unsafe delegate bool AUTHZ_COMPUTE_DYNAMIC_GROUPS(
        [In] AUTHZ_CLIENT_CONTEXT_HANDLE hAuthzClientContext,
        [In] IntPtr Args,
        out SID_AND_ATTRIBUTES* pSidAttrArray,
        out int pSidCount,
        out SID_AND_ATTRIBUTES* pRestrictedSidAttrArray,
        out int pRestrictedSidCount
        );
}
