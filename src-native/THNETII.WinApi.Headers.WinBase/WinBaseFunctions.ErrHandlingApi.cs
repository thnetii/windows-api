using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinBase
{

    public static partial class WinBaseFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\errhandlingapi.h, line 96
        #region SetLastError function
        /// <inheritdoc cref="M:THNETII.WinApi.Native.ErrHandlingApi.ErrHandlingApiFunctions.SetLastError(System.Int32)"/>
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        private static extern void SetLastError(
            [In] int dwErrCode
            );
        #endregion
    }
}
