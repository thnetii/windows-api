using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.AuthZ
{
    //
    // Callback free function takes in
    //     pSidAttrArray - To be freed. This has been allocated by the compute
    //     dynamic groups function.
    //

    /// <summary>
    /// Callback free function
    /// </summary>
    /// <param name="pSidAttrArray">
    /// To be freed. This has been allocated by the compute
    /// dynamic groups function.
    /// </param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void AUTHZ_FREE_DYNAMIC_GROUPS(
        [In] SID_AND_ATTRIBUTES* pSidAttrArray
        );
}
