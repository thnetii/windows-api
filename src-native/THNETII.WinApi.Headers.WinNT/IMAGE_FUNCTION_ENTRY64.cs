using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18338
    /// <summary>
    /// Represents an entry in the function table.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_function_entry64">IMAGE_FUNCTION_ENTRY64 structure</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    /// <seealso cref="STACKFRAME64"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_FUNCTION_ENTRY64
    {
        /// <summary>
        /// The image address of the start of the function.
        /// </summary>
        public long StartingAddress;
        /// <summary>
        /// The image address of the end of the function.
        /// </summary>
        public long EndingAddress;
        /// <summary>
        /// The image address of the end of the prologue code.
        /// </summary>
        public long EndOfPrologue;
        public long UnwindInfoAddress
        {
            get => EndOfPrologue;
            set => EndOfPrologue = value;
        }
    }
}
