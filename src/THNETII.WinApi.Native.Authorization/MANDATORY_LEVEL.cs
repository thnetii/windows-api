namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="MANDATORY_LEVEL"/> enumeration lists the possible security levels.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/hh448527.aspx">MANDATORY_LEVEL enumeration</a></para>
    /// </remarks>
    public enum MANDATORY_LEVEL
    {
        /// <summary>The required security level is untrusted.</summary>
        MandatoryLevelUntrusted = 0,
        /// <summary>The required security level is low.</summary>
        MandatoryLevelLow,
        /// <summary>The required security level is medium.</summary>
        MandatoryLevelMedium,
        /// <summary>The required security level is high.</summary>
        MandatoryLevelHigh,
        /// <summary>The required security level is system.</summary>
        MandatoryLevelSystem,
        /// <summary>The required security level is a secure process.</summary>
        MandatoryLevelSecureProcess,
        /// <summary>The count of the mandatory level.</summary>
        MandatoryLevelCount
    }
}
