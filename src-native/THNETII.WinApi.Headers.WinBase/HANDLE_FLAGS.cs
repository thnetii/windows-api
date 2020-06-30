using System;

namespace THNETII.WinApi.Native.WinBase
{
    [Flags]
    public enum HANDLE_FLAGS : int
    {
        /// <summary>
        /// A child process created with the <em>bInheritHandles</em> parameter of <see cref="CreateProcess"/> set to <see langword="true"/> will inherit object handles that have this flag set.
        /// </summary>
        HANDLE_FLAG_INHERIT = WinBaseConstants.HANDLE_FLAG_INHERIT,
        /// <summary>
        /// Calls to <see cref="M:THNETII.WinApi.Native.HnaldeApi.HandleApiFunctions.CloseHandle"/> will not close object handles that have this flag set.
        /// </summary>
        HANDLE_FLAG_PROTECT_FROM_CLOSE = WinBaseConstants.HANDLE_FLAG_PROTECT_FROM_CLOSE,
    }
}
