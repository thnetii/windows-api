using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinBase;

namespace THNETII.WinApi.Native.AccCtrl
{
    using static WinBaseFunctions;

    public static partial class AccCtrlFunctions
    {

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 38
        #region AccFree function
        /// <inheritdoc cref="LocalFree"/>
        public static void AccFree(HLOCAL hMem) => LocalFree(hMem);
        #endregion
    }
}
