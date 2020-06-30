using System;
using System.Collections.Generic;
using System.Text;

namespace THNETII.WinApi.Native.WinError
{
    using static WinErrorConstants;

    public static class WinErrorFunctions
    {
        #region SUCCEEDED macro
        /// <summary>
        /// Provides a generic test for success on any status value.
        /// </summary>
        /// <param name="hr">The status code. This value can be an <see cref="T:THNETII.WinApi.HRESULT"/>. A non-negative number indicates success.</param>
        /// <returns><see langword="true"/> if the status code specified by <paramref name="hr"/> indicates success; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-succeeded">SUCCEEDED macro</a></para>
        /// </remarks>
        public static bool SUCCEEDED(int hr) => hr >= 0;
        #endregion
        #region FAILED macro
        /// <summary>
        /// Provides a generic test for failure on any status value.
        /// </summary>
        /// <param name="hr">The status code. This value can be an <see cref="T:THNETII.WinApi.HRESULT"/>. A negative number indicates failure.</param>
        /// <returns><see langword="true"/> if the status code specified by <paramref name="hr"/> indicates failure; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-failed">FAILED macro</a></para>
        /// </remarks>
        public static bool FAILED(int hr) => hr < 0;
        #endregion
        #region IS_ERROR macro
        /// <summary>
        /// Provides a generic test for errors on any status value.
        /// </summary>
        /// <param name="status">The status code. This value can be an <see cref="T:THNETII.WinApi.HRESULT"/>.</param>
        /// <returns><see langword="true"/> if the status code specified by <paramref name="status"/> indicates an error; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-is_error">IS_ERROR macro</a></para>
        /// </remarks>
        public static bool IS_ERROR(int status) => (unchecked((uint)status) >> 31) == SEVERITY_ERROR;
        #endregion
        #region HRESULT_CODE macro
        /// <summary>
        /// Extracts the code portion of the specified <see cref="T:THNETII.WinApi.HRESULT"/>.
        /// </summary>
        /// <param name="hr">The <see cref="T:THNETII.WinApi.HRESULT"/> value.</param>
        /// <returns>The code portion of the value specified by <paramref name="hr"/>.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-hresult_code">HRESULT_CODE macro</a></para>
        /// </remarks>
        public static int HRESULT_CODE(int hr) => hr & 0xFFFF;
        #endregion
        #region SCODE_CODE macro
        /// <summary>
        /// Extracts the code portion of the specified <strong>SCODE</strong>.
        /// </summary>
        /// <param name="sc">The <strong>SCODE</strong> value.</param>
        /// <returns>The code portion of the value specified by <paramref name="sc"/>.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-scode_code">SCODE_CODE macro</a></para>
        /// </remarks>
        public static int SCODE_CODE(int sc) => sc & 0xFFFF;
        #endregion
        #region HRESULT_FACILITY macro
        /// <summary>
        /// Extracts the facility of the specified <see cref="T:THNETII.WinApi.HRESULT"/>.
        /// </summary>
        /// <param name="hr">The <see cref="T:THNETII.WinApi.HRESULT"/> value.</param>
        /// <returns>The facility code of the specified status code.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-hresult_facility">HRESULT_FACILITY macro</a></para>
        /// </remarks>
        public static int HRESULT_FACILITY(int hr) => (hr >> 16) & 0x1fff;
        #endregion
        #region SCODE_FACILITY macro
        /// <summary>
        /// Extracts the facility of the specified <strong>SCODE</strong>.
        /// </summary>
        /// <param name="sc">The status code.</param>
        /// <returns>The facility code of the specified status code.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-scode_facility">SCODE_FACILITY macro</a></para>
        /// </remarks>
        public static int SCODE_FACILITY(int sc) => (sc >> 16) & 0x1fff;
        #endregion
        #region HRESULT_SEVERITY macro
        /// <summary>
        /// Extracts the severity field of the specified <see cref="T:THNETII.WinApi.HRESULT"/>.
        /// </summary>
        /// <param name="hr">The <see cref="T:THNETII.WinApi.HRESULT"/>.</param>
        /// <returns>The value of the severity field in the specified status code.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-hresult_severity">HRESULT_SEVERITY macro</a></para>
        /// </remarks>
        public static int HRESULT_SEVERITY(int hr) => (hr >> 31) & 0x1;
        #endregion
        #region SCODE_SEVERITY
        /// <summary>
        /// Extracts the severity field of the specified <strong>SCODE</strong>.
        /// </summary>
        /// <param name="sc">The status code.</param>
        /// <returns>The value of the severity field in the specified status code.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-scode_severity">SCODE_SEVERITY macro</a></para>
        /// </remarks>
        public static int SCODE_SEVERITY(int sc) => (sc >> 31) & 0x1;
        #endregion
        #region MAKE_HRESULT macro
        /// <summary>
        /// Creates an <see cref="T:THNETII.WinApi.HRESULT"/> value from its component pieces.
        /// </summary>
        /// <param name="sev">The severity.</param>
        /// <param name="fac">The facility.</param>
        /// <param name="code">The code.</param>
        /// <returns>An <see cref="T:THNETII.WinApi.HRESULT"/> value composed of the specified compoents.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-make_hresult">MAKE_HRESULT macro</a></para>
        /// </remarks>
        public static int MAKE_HRESULT(int sev, int fac, int code)
        {
            return unchecked((int)(
                (unchecked((uint)sev) << 31) |
                (unchecked((uint)fac) << 16) |
                unchecked((uint)code)
                ));
        }
        #endregion
        #region MAKE_SCODE macro
        /// <summary>
        /// Creates an <strong>SCODE</strong> value from its component pieces.
        /// </summary>
        /// <param name="sev">The severity.</param>
        /// <param name="fac">The facility.</param>
        /// <param name="code">The code.</param>
        /// <returns>An <strong>SCODE</strong> value composed of the specified compoents.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-make_scode">MAKE_SCODE macro</a></para>
        /// </remarks>
        public static int MAKE_SCODE(int sev, int fac, int code)
        {
            return unchecked((int)(
                (unchecked((uint)sev) << 31) |
                (unchecked((uint)fac) << 16) |
                unchecked((uint)code)
                ));
        }
        #endregion
        #region HRESULT_FROM_WIN32 macro
        /// <summary>
        /// Maps a <a href="https://msdn.microsoft.com/4a3a8feb-a05f-4614-8f04-1f507da7e5b7">system error code</a> to an <see cref="T:THNETII.WinApi.HRESULT"/> value.
        /// </summary>
        /// <param name="x">The system error code.</param>
        /// <returns>The system error code translated to an <see cref="T:THNETII.WinApi.HRESULT"/> value.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-hresult_from_win32">HRESULT_FROM_WIN32 macro</a></para>
        /// </remarks>
        public static int HRESULT_FROM_WIN32(int x) => x <= 0 ? x
            : (x & 0x0000FFFF)
            | (FACILITY_WIN32 << 16)
            | unchecked((int)0x80000000);
        #endregion
        #region HRESULT_FROM_NT macro
        /// <summary>
        /// Maps an NT status value to an <see cref="T:THNETII.WinApi.HRESULT"/> value.
        /// </summary>
        /// <param name="x">The NT status value.</param>
        /// <returns>The NT status value mapped to an <see cref="T:THNETII.WinApi.HRESULT"/> value.</returns>
        /// <remarks>
        /// <para>Original Microsoft Docs documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winerror/nf-winerror-hresult_from_nt">HRESULT_FROM_NT macro</a></para>
        /// </remarks>
        public static int HRESULT_FROM_NT(int x) => x | FACILITY_NT_BIT;
        #endregion
        #region OBSOLETE functions
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>Extract the <strong>SCODE</strong> from a <strong>HRESULT</strong></summary>
        [Obsolete("This function is obsolete and should not be used.")]
        public static int GetScode(int hr) => hr;
        /// <summary>Convert an <strong>SCODE</strong> into an <strong>HRESULT</strong>.</summary>
        [Obsolete("This function is obsolete and should not be used.")]
        public static int ResultFromScode(int sc) => sc;
        /// <summary><see cref="PropagateResult"/> is a noop</summary>
        [Obsolete("This function is obsolete and should not be used.")]
        public static int PropagateResult(int hrPrevious, int scBase) =>
            scBase;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        #endregion
    }
}
