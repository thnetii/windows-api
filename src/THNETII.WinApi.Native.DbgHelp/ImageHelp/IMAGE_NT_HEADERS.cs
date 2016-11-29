using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the PE header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680336.aspx">IMAGE_NT_HEADERS structure</a></para>
    /// </remarks>
    /// <seealso cref="CheckSumMappedFile"/>
    /// <seealso cref="IMAGE_FILE_HEADER"/>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER_COMMON"/>
    /// <seealso cref="ImageNtHeader"/>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    /// <seealso cref="UpdateDebugInfoFile"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_NT_HEADERS_COMMON
    {
        /// <summary>PE00</summary>
        public const int IMAGE_NT_SIGNATURE = 0x00004550;

        /// <summary>
        /// A 4-byte signature identifying the file as a PE image. The bytes are "PE\0\0".
        /// </summary>
        public int Signature;
        /// <summary>
        /// An <see cref="IMAGE_FILE_HEADER"/> instance that specifies the file header.
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader;
        /// <summary>
        /// An <see cref="IMAGE_OPTIONAL_HEADER_COMMON"/> instance that specifies the optional file header.
        /// </summary>
        public IMAGE_OPTIONAL_HEADER_COMMON OptionalHeader;
    }

    /// <summary>
    /// Represents the PE header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680336.aspx">IMAGE_NT_HEADERS structure</a></para>
    /// </remarks>
    /// <seealso cref="CheckSumMappedFile"/>
    /// <seealso cref="IMAGE_FILE_HEADER"/>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER32"/>
    /// <seealso cref="ImageNtHeader"/>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    /// <seealso cref="UpdateDebugInfoFile"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_NT_HEADERS32
    {
        /// <summary>
        /// A 4-byte signature identifying the file as a PE image. The bytes are "PE\0\0".
        /// </summary>
        public int Signature;
        /// <summary>
        /// An <see cref="IMAGE_FILE_HEADER"/> instance that specifies the file header.
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader;
        /// <summary>
        /// An <see cref="IMAGE_OPTIONAL_HEADER32"/> instance that specifies the optional file header.
        /// </summary>
        public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
    }

    /// <summary>
    /// Represents the PE header format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680336.aspx">IMAGE_NT_HEADERS structure</a></para>
    /// </remarks>
    /// <seealso cref="CheckSumMappedFile"/>
    /// <seealso cref="IMAGE_FILE_HEADER"/>
    /// <seealso cref="IMAGE_OPTIONAL_HEADER64"/>
    /// <seealso cref="ImageNtHeader"/>
    /// <seealso cref="ImageRvaToSection"/>
    /// <seealso cref="ImageRvaToVa"/>
    /// <seealso cref="LOADED_IMAGE"/>
    /// <seealso cref="UpdateDebugInfoFile"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_NT_HEADERS64
    {
        /// <summary>
        /// A 4-byte signature identifying the file as a PE image. The bytes are "PE\0\0".
        /// </summary>
        public int Signature;
        /// <summary>
        /// An <see cref="IMAGE_FILE_HEADER"/> instance that specifies the file header.
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader;
        /// <summary>
        /// An <see cref="IMAGE_OPTIONAL_HEADER64"/> instance that specifies the optional file header.
        /// </summary>
        public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
    }
}
