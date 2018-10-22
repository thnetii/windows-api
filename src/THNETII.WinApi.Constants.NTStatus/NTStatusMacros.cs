using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.NTStatus
{
    using static NTStatusConstants;
    using static WinNTConstants;

    public static class NTStatusMacros
    {
        #region FILTER_FLT_NTSTATUS_FROM_HRESULT macro
        /// <summary>
        /// Translation macro for converting:
        /// <see cref="T:THNETII.WinApi.HRESULT"/> --> <see cref="T:THNETII.WinApi.NTSTATUS"/>
        /// </summary>
        public static int FILTER_FLT_NTSTATUS_FROM_HRESULT(int x) =>
            (x & unchecked((int)0xC0007FFF)) |
            (FACILITY_FILTER_MANAGER << 16) |
            0x40000000;
        #endregion
        #region NTSTATUS_FROM_WIN32 macro
        /// <summary>
        /// Map a WIN32 error value into an <see cref="T:THNETII.WinApi.NTSTATUS"/>
        /// </summary>
        /// <remarks>
        /// Note: This assumes that WIN32 errors fall in the range -32k to 32k.
        /// </remarks>
        public static int NTSTATUS_FROM_WIN32(int x) => x <= 0 ? x
            : (x & 0x0000FFFF)
            | (FACILITY_NTWIN32 << 16)
            | ERROR_SEVERITY_ERROR;
        #endregion
    }
}
