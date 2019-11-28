using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 772
    /// <summary>
    /// Specifies the type of credentials used to create a client context.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkgcontext_credinfo">SecPkgContext_CredInfo structure</a></para>
    /// </remarks>
    /// <seealso cref="SpQueryContextAttributes"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgContext_CredInfo
    {
        /// <summary>
        /// A value of the <see cref="SECPKG_CRED_CLASS"/> enumeration that indicates the type of credentials.
        /// </summary>
        public SECPKG_CRED_CLASS CredClass;
        internal int IsPromptingNeededField;
        /// <summary>
        /// Indicates that the application must prompt the user for credentials. All other values indicate that the application does not need to prompt the user.
        /// </summary>
        public bool IsPromptingNeeded
        {
            get => IsPromptingNeededField != 0;
            set => IsPromptingNeededField = value ? 1 : 0;
        }
    }
}
