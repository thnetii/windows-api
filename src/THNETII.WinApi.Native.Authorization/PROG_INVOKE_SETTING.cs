namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="PROG_INVOKE_SETTING"/> enumeration indicates the initial setting of the function used to track the progress of a call to the <see cref="TreeSetNamedSecurityInfo"/> or <see cref="TreeResetNamedSecurityInfo"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/bb736346.aspx">PROG_INVOKE_SETTING enumeration</a></para>
    /// </remarks>
    public enum PROG_INVOKE_SETTING
    {
        /// <summary>Never invoke the progress function.</summary>
        ProgressInvokeNever = 1,
        /// <summary>Invoke the progress function for every object.</summary>
        ProgressInvokeEveryObject,
        /// <summary>Invoke the progress function only when an error is encountered.</summary>
        ProgressInvokeOnError,
        /// <summary>
        /// Discontinue the tree operation.
        /// <para><note>The original state of the tree will not be reset, and the results are unpredictable.</note></para>
        /// </summary>
        ProgressCancelOperation,
        /// <summary>Retry the tree operation.</summary>
        ProgressRetryOperation,
        /// <summary>Invoke the progress function before and after applying security on the object and on the error.</summary>
        ProgressInvokePrePostError
    }
}
