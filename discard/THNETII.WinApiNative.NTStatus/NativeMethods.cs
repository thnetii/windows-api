using static THNETII.WinApiNative.NTStatus.NTStatusConstants;
using static THNETII.WinApiNative.WinNT.WinNTConstants;

namespace THNETII.WinApiNative.NTStatus
{
    /// <summary>
    /// Native methods and macro definitions for the NTSTATUS values.
    /// </summary>
    public static class NativeMethods
    {
        #region FILTER_FLT_NTSTATUS_FROM_HRESULT macro
        /// <summary>
        /// Translation macro for converting:
        /// HRESULT --> NTSTATUS
        /// </summary>
        public static int FILTER_FLT_NTSTATUS_FROM_HRESULT(int x) =>
            (x & unchecked((int)0xC0007FFF)) |
            (FACILITY_FILTER_MANAGER << 16) |
            0x40000000;
        #endregion
        #region NTSTATUS_FROM_WIN32 macro
        /// <summary>
        /// Map a WIN32 error value into an NTSTATUS
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
