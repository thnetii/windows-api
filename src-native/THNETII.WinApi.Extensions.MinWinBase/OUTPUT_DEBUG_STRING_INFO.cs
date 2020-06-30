using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 345
    /// <summary>
    /// Contains the address, format, and length, in bytes, of a debugging string.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-output_debug_string_info">OUTPUT_DEBUG_STRING_INFO structure</a></para>
    /// </remarks>
    /// <seealso cref="DEBUG_EVENT"/>
    /// <seealso cref="ReadProcessMemory"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        public IntPtr lpDebugStringData;
        internal short fUnicodeField;
        /// <summary>
        /// The format of the debugging string. If this member is <see langword="false"/>, the debugging string is ANSI; if it is <see langword="true"/>, the string is Unicode.
        /// </summary>
        public bool fUnicode
        {
            get => fUnicodeField != 0;
            set => fUnicodeField = (short)(value ? 1 : 0);
        }
        /// <summary>
        /// The size of the debugging string, in characters. The length includes the string's terminating null character.
        /// </summary>
        public short nDebugStringLength;
    }
}
