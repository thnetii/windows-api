using Microsoft.Win32.SafeHandles;
using Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp;
using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Contains information about the loaded image.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms680349.aspx">LOADED_IMAGE structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_NT_HEADERS_COMMON"/>
    /// <seealso cref="IMAGE_NT_HEADERS32"/>
    /// <seealso cref="IMAGE_NT_HEADERS64"/>
    /// <seealso cref="IMAGE_SECTION_HEADER"/>
    /// <seealso cref="ImageLoad"/>
    /// <seealso cref="MapAndLoad"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LOADED_IMAGE
    {
        /// <summary>
        /// The file name of the mapped file.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ModuleName;
        /// <summary>
        /// A handle to the mapped file.
        /// </summary>
        public IntPtr hFilePtr;
        /// <summary>
        /// The base address of the mapped file.
        /// </summary>
        public IntPtr MappedAddress;
        /// <summary>
        /// A pointer to an <see cref="IMAGE_NT_HEADERS_COMMON"/>, an <see cref="IMAGE_NT_HEADERS32"/> or an <see cref="IMAGE_NT_HEADERS64"/> instance.
        /// </summary>
        public IntPtr FileHeader;
        /// <summary>
        /// A pointer to an <see cref="IMAGE_SECTION_HEADER"/> structure.
        /// </summary>
        public IntPtr LastRvaSection;
        /// <summary>
        /// The number of COFF section headers.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="Sections"/> by calling the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_SECTION_HEADER}(IntPtr, int)"/> method.</remarks>
        public int NumberOfSections;
        /// <summary>
        /// A pointer to an <see cref="IMAGE_SECTION_HEADER"/> instance.
        /// <para>This pointer can be marshaled into a managed array of <see cref="IMAGE_SECTION_HEADER"/> instances using the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_SECTION_HEADER}(IntPtr, int)"/> method.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="NumberOfSections"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr Sections;
        /// <summary>The image characteristics value.</summary>
        protected int ulCharacteristics;
        /// <summary>The image characteristics value.</summary>
        public IMAGE_FILE_CHARACTERISTICS Characteristics
        {
            get { return (IMAGE_FILE_CHARACTERISTICS)ulCharacteristics; }
            set { ulCharacteristics = (int)value; }
        }
        /// <summary>
        /// If the image is a kernel mode executable image, this value is <c>true</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool fSystemImage;
        /// <summary>
        /// If the image is a 16-bit executable image, this value is <c>true</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool fDOSImage;
        /// <summary>
        /// <para>If the image is read-only, this value is <c>true</c>.</para>
        /// <para><strong>Prior to Windows Vista:</strong> This member is not included in the structure.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool fReadOnly;
        /// <summary>
        /// <para>The version string.</para>
        /// <para><strong>Prior to Windows Vista:</strong> This member is not included in the structure.</para>
        /// </summary>
        public byte Version;
        /// <summary>The list of loaded images.</summary>
        public LIST_ENTRY Links;
        /// <summary>The size of the image, in bytes.</summary>
        public int SizeOfImage;
    }
}
