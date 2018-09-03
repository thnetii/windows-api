using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices.AdsProp
{
    /// <summary>
    /// The <see cref="ADSPROPERROR"/> structure is used to pass error data to the notification object with the <see cref="ADsPropSendErrorMessage"/> function or the <see cref="WM_ADSPROP_NOTIFY_ERROR"/> message.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/adsprop/ns-adsprop-_adsproperror">_ADSPROPERROR structure</a></para>
    /// </remarks>
    /// <seealso cref="ADsPropSendErrorMessage"/>
    /// <seealso cref="WM_ADSPROP_NOTIFY_ERROR"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADSPROPERROR
    {
        /// <summary>
        /// Contains the window handle of the property page that generated the error.
        /// </summary>
        public IntPtr hwndPage;

        /// <summary>
        /// <see cref="string"/> that contains the title of the property page that generated the error.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszPageTitle;

        /// <summary>
        /// <see cref="string"/> that contains the ADsPath of the directory object that the error occurred on.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszObjPath;

        /// <summary>
        /// <see cref="string"/> that contains the class name of the directory object that the error occurred on.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszObjClass;

        /// <summary>
        /// Contains an <see cref="HRESULT"/> value that specifies the code of the error that occurred. If <see cref="hr"/> is not equal to <see cref="S_OK"/>, then <see cref="pszError"/> is ignored.
        /// If <see cref="hr"/> is equal to <see cref="S_OK"/>, then <see cref="pszError"/> contains an error message.
        /// </summary>
        public int hr;

        /// <summary>
        /// <see cref="string"/> that contains the error message to be displayed in the error dialog box. This member is ignored if <see cref="hr"/> is not equal to <see cref="S_OK"/>. In this case, the error dialog box will display a system-defined message for the error specified by <see cref="hr"/>.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszError;
    }
}
