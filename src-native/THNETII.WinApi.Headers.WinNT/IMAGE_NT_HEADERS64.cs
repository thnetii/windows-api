using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 16536
    /// <summary>
    /// Represents the PE header format.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_nt_headers64">IMAGE_NT_HEADERS64 structure</a></para>
    /// </remarks>
    /// <seealso cref="CheckSumMappedFile"/>
    /// <seealso cref="IMAGE_FILE_HEADER"/>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER64"/>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    /// <seealso cref="ImageNtHeader"/>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    /// <seealso cref="UpdateDebugInfoFile"/>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_NT_HEADERS64
    {
        /// <summary>
        /// A 4-byte signature identifying the file as a PE image.
        /// </summary>
        public int Signature;
        /// <summary>
        /// An <see cref="IMAGE_FILE_HEADER"/> structure that specifies the file header.
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader;
        /// <summary>
        /// An <see cref="IMAGE_OPTIONAL_HEADER64"/> structure that specifies the optional file header.
        /// </summary>
        public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
    }
}
