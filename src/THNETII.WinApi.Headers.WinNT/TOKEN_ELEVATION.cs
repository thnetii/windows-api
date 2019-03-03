using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10795
    /// <summary>
    /// The <see cref="TOKEN_ELEVATION"/> structure indicates whether a token has elevated privileges.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_elevation">TOKEN_ELEVATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_ELEVATION
    {
        internal int TokenIsElevatedValue;
        /// <summary>
        /// Gets or sets whether the token has elevated privileges.
        /// </summary>
        /// <value><c>true</c> if the token has elevated privileges; otherwise, <c>false</c>.</value>
        public bool TokenIsElevated
        {
            get => TokenIsElevatedValue != 0;
            set => TokenIsElevatedValue = value ? 1 : 0;
        }
    }
}
