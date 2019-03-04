using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10891
    /// <summary>
    /// The <see cref="TOKEN_APPCONTAINER_INFORMATION"/> structure specifies all the information in a token that is necessary for an app container.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_appcontainer_information">TOKEN_APPCONTAINER_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_APPCONTAINER_INFORMATION
    {
        /// <summary>
        /// The <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID) of the app container.
        /// </summary>
        public SID* TokenAppContainer;
    }
}
