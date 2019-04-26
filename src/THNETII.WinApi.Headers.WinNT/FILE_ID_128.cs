using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12955
    /// <summary>
    /// Defines a 128-bit file identifier.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-file_id_128">FILE_ID_128 structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FILE_ID_128
    {
        /// <summary>
        /// A byte span containing the 128 bit identifier.
        /// </summary>
        public fixed byte Identifier[16];
    }
}
