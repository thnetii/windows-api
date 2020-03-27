namespace THNETII.WinApi.Native.AccCtrl
{
    /// <summary>
    /// The <see cref="PROG_INVOKE_SETTING"/> enumeration indicates the initial setting of the function used to track the progress of a call to the <see cref="TreeSetNamedSecurityInfo"/> or <see cref="TreeResetNamedSecurityInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-prog_invoke_setting">PROG_INVOKE_SETTING enumeration</a></para>
    /// </remarks>
    public enum PROG_INVOKE_SETTING
    {
        /// <summary>
        /// Never invoke the progress function.
        /// </summary>
        ProgressInvokeNever = 1,    // Never invoke the progress function
        /// <summary>
        /// Invoke the progress function for every object.
        /// </summary>
        ProgressInvokeEveryObject,  // Invoke for each object
        /// <summary>
        /// Invoke the progress function only when an error is encountered.
        /// </summary>
        ProgressInvokeOnError,      // Invoke only for each error case
        /// <summary>
        /// Discontinue the tree operation.
        /// <para><note>The original state of the tree will not be reset, and the results are unpredictable.</note></para>
        /// </summary>
        ProgressCancelOperation,    // Stop propagation and return
        /// <summary>
        /// Retry the tree operation.
        /// </summary>
        ProgressRetryOperation,     // Retry operation on subtree
        /// <summary>
        /// Invoke the progress function before and after applying security on the object and on the error.
        /// </summary>
        ProgressInvokePrePostError, // Invoke Pre, Post, Error

    }
}
