using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18139
    /// <summary>
    /// Represents an entry in the function table on 64-bit Windows.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-_image_runtime_function_entry">RUNTIME_FUNCTION structure</a></para>
    /// </remarks>
    /// <seealso cref="SymFunctionTableAccess64"/>
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public struct IMAGE_IA64_RUNTIME_FUNCTION_ENTRY
    {
        /// <summary>
        /// The address of the start of the function.
        /// </summary>
        [FieldOffset(0)]
        public int BeginAddress;
        /// <summary>
        /// The address of the end of the function.
        /// </summary>
        [FieldOffset(sizeof(int))]
        public int EndAddress;
        /// <summary>
        /// The address of the unwind information for the function.
        /// </summary>
        [FieldOffset(2 * sizeof(int))]
        public int UnwindInfoAddress;
        [FieldOffset(2 * sizeof(int))]
        public int UnwindData;
    }
}
