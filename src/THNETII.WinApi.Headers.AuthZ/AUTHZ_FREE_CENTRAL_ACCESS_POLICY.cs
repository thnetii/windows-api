using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.AuthZ
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AuthZ.h, line 254
    //
    // Callback central access policy free function takes in
    //     pCentralAccessPolicy - To be freed. This memory has been allocated by 
    //     the central access policy retrieval callback function.
    //

    /// <summary>
    /// Callback central access policy free function
    /// </summary>
    /// <param name="pCentralAccessPolicy">
    /// To be freed. This memory has been allocated by
    /// the central access policy retrieval callback function.
    /// </param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void AUTHZ_FREE_CENTRAL_ACCESS_POLICY(
        [In] IntPtr pCentralAccessPolicy
        );
}
