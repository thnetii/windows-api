namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10881
    /// <summary>
    /// The <see cref="MANDATORY_LEVEL"/> enumeration lists the possible security levels.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ne-winnt-mandatory_level">MANDATORY_LEVEL enumeration</a></para>
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
