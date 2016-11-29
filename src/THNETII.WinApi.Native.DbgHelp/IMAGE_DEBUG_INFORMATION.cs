using Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp;
using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Contains debugging information.
    /// <para><note>This type is used by the <see cref="MapDebugInformation"/> and <see cref="UnmapDebugInformation"/> functions, which are provided only for backward compatibility.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680309.aspx">IMAGE_DEBUG_INFORMATION structure</a></para>
    /// </remarks>
    /// <seealso cref="FPO_DATA"/>
    /// <seealso cref="IMAGE_COFF_SYMBOLS_HEADER"/>
    /// <seealso cref="IMAGE_DEBUG_DIRECTORY"/>
    /// <seealso cref="IMAGE_FUNCTION_ENTRY"/>
    /// <seealso cref="IMAGE_SECTION_HEADER"/>
    /// <seealso cref="MapDebugInformation"/>
    /// <seealso cref="UnmapDebugInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_DEBUG_INFORMATION
    {
        /// <summary>
        /// The size, in bytes, that a <see cref="IMAGE_DEBUG_INFORMATION"/> instance occupies in memory.
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf<IMAGE_DEBUG_INFORMATION>();

        /// <summary>
        /// A linked list of <see cref="LIST_ENTRY"/> instances.
        /// </summary>
        public LIST_ENTRY List;
        /// <summary>
        /// The size of the memory allocated for the <see cref="IMAGE_DEBUG_INFORMATION"/> structure and all debugging information, in bytes.
        /// </summary>
        public int ReservedSize;
        /// <summary>
        /// The base address of the image.
        /// </summary>
        public IntPtr ReservedMappedBase;
        /// <summary>
        /// The computer type.
        /// </summary>
        [MarshalAs(UnmanagedType.U2)]
        public IMAGE_FILE_MACHINE ReservedMachine;
        /// <summary>
        /// The characteristics of the image.
        /// </summary>
        [MarshalAs(UnmanagedType.U2)]
        public IMAGE_FILE_CHARACTERISTICS ReservedCharacteristics;
        /// <summary>
        /// The checksum of the image.
        /// </summary>
        public int ReservedCheckSum;
        /// <summary>
        /// The requested base address of the image.
        /// </summary>
        public int ImageBase;
        /// <summary>
        /// The size of the image, in bytes.
        /// </summary>
        public int SizeOfImage;
        /// <summary>
        /// The number of COFF section headers.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="ReservedSections"/> by calling the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_SECTION_HEADER}(IntPtr, int)"/> method.</remarks>
        public int ReservedNumberOfSections;
        /// <summary>
        /// A pointer to the first COFF section header. For more information, see <see cref="IMAGE_SECTION_HEADER"/>.
        /// <para>This pointer can be marshaled into a managed array of <see cref="IMAGE_SECTION_HEADER"/> instances using the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_SECTION_HEADER}(IntPtr, int)"/> method.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="ReservedNumberOfSections"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr ReservedSections;
        /// <summary>
        /// The size of the <see cref="ReservedExportedNames"/> member, in bytes.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="ReservedExportedNames"/> by calling the <see cref="IntPtrExtensions.MarshalAsAnsiString(IntPtr, int)"/> method.</remarks>
        public int ReservedExportedNamesSize;
        /// <summary>
        /// A pointer to a series of null-terminated strings that name all the functions exported from the image.
        /// <para>This pointer can be marshaled into a managed string instance using the <see cref="IntPtrExtensions.MarshalAsAnsiString(IntPtr, int)"/> method.<br/> The resulting string can then be Split by calling on the <see cref="string.Split(char[])"/> method using the <c>'\0'</c> (null-termination) character as separator.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="ReservedExportedNamesSize"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr ReservedExportedNames;
        /// <summary>
        /// he number of entries contained in the <see cref="ReservedFunctionTableEntries"/> member.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="ReservedFunctionTableEntries"/> by calling the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_FUNCTION_ENTRY}(IntPtr, int)"/> method.</remarks>
        public int ReservedNumberOfFunctionTableEntries;
        /// <summary>
        /// A pointer to the first function table entry. For more information, see <see cref="IMAGE_FUNCTION_ENTRY"/>.
        /// <para>This pointer can be marshaled into a managed array of <see cref="IMAGE_FUNCTION_ENTRY"/> instances using the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_FUNCTION_ENTRY}(IntPtr, int)"/> method.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="ReservedNumberOfFunctionTableEntries"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr ReservedFunctionTableEntries;
        /// <summary>
        /// The lowest function table starting address.
        /// </summary>
        public int ReservedLowestFunctionStartingAddress;
        /// <summary>
        /// The highest function table ending address.
        /// </summary>
        public int ReservedHighestFunctionEndingAddress;
        /// <summary>
        /// The number of entries contained in the <see cref="ReservedFpoTableEntries"/> member.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="ReservedFpoTableEntries"/> by calling the <see cref="IntPtrExtensions.MarshalAsValueArray{FPO_DATA}(IntPtr, int)"/> method.</remarks>
        public int ReservedNumberOfFpoTableEntries;
        /// <summary>
        /// A pointer to the first FPO entry. For more information, see <see cref="FPO_DATA"/>.
        /// <para>This pointer can be marshaled into a managed array of <see cref="FPO_DATA"/> instances using the <see cref="IntPtrExtensions.MarshalAsValueArray{FPO_DATA}(IntPtr, int)"/> method.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="ReservedNumberOfFpoTableEntries"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr ReservedFpoTableEntries;
        /// <summary>
        /// The size of the COFF symbol table, in bytes.
        /// </summary>
        public int SizeOfCoffSymbols;
        /// <summary>
        /// A pointer to the COFF symbol table.
        /// <para>This pointer can be marshaled into a single <see cref="IMAGE_COFF_SYMBOLS_HEADER"/> instance using the <see cref="Marshal.PtrToStructure{IMAGE_COFF_SYMBOLS_HEADER}(IntPtr)"/> method.</para>
        /// <para>The memory area following after the data of the <see cref="IMAGE_COFF_SYMBOLS_HEADER"/> instance, contains the actual COFF symbol table data.</para>
        /// </summary>
        public IntPtr CoffSymbols;
        /// <summary>
        /// The size of the CodeView symbol table, in bytes.
        /// </summary>
        public int ReservedSizeOfCodeViewSymbols;
        /// <summary>
        /// A pointer to the beginning of the CodeView symbol table.
        /// </summary>
        public IntPtr ReservedCodeViewSymbols;
        /// <summary>
        /// The relative path to the image file name.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ImageFilePath;
        /// <summary>
        /// The image file name.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ImageFileName;
        /// <summary>
        /// The full path to the symbol file.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ReservedDebugFilePath;
        /// <summary>
        /// The timestamp of the image. This represents the date and time the image was created by the linker.
        /// </summary>
        public int ReservedTimeDateStamp;
        /// <summary>
        /// This value is <c>true</c> if the image is a ROM image.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool ReservedRomImage;
        /// <summary>
        /// A pointer to the first debug directory. For more information, see <see cref="IMAGE_DEBUG_DIRECTORY"/>.
        /// <para>This pointer can be marshaled into a managed array of <see cref="IMAGE_DEBUG_DIRECTORY"/> instances using the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_DEBUG_DIRECTORY}(IntPtr, int)"/> method.</para>
        /// <para>When marshaling the pointer to managed memory, supply the value of the <see cref="ReservedNumberOfDebugDirectories"/> field as the <em>length</em> parameter.</para>
        /// </summary>
        public IntPtr ReservedDebugDirectory;
        /// <summary>
        /// The number of entries contained in the <see cref="ReservedDebugDirectory"/> member.
        /// </summary>
        /// <remarks>Use this field value as the <em>length</em> argument when marshaling <see cref="ReservedDebugDirectory"/> by calling the <see cref="IntPtrExtensions.MarshalAsValueArray{IMAGE_DEBUG_DIRECTORY}(IntPtr, int)"/> method.</remarks>
        public int ReservedNumberOfDebugDirectories;
        /// <summary>
        /// The original function table base address.
        /// </summary>
        public int ReservedOriginalFunctionTableBaseAddress;
        /// <summary>
        /// This member is reserved for use by the operating system.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] Reserved;
    }
}
