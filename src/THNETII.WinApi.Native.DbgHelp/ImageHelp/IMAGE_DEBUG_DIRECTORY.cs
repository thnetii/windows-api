using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents the debug directory format.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680307.aspx">IMAGE_DEBUG_DIRECTORY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_DEBUG_DIRECTORY
    {
        /// <summary>Reserved.</summary>
        public int Characteristics;
        /// <summary>The time and date the debugging information was created.</summary>
        public int TimeDateStamp;
        /// <summary>The major version number of the debugging information format.</summary>
        public short MajorVersion;
        /// <summary>The minor version number of the debugging information format.</summary>
        public short MinorVersion;
        /// <summary>The format of the debugging information.</summary>
        [MarshalAs(UnmanagedType.I4)]
        public IMAGE_DEBUG_TYPE Type;
        /// <summary>The size of the debugging information, in bytes. This value does not include the debug directory itself.</summary>
        public int SizeOfData;
        /// <summary>The address of the debugging information when the image is loaded, relative to the image base.</summary>
        public int AddressOfRawData;
        /// <summary>A file pointer to the debugging information.</summary>
        public int PointerToRawData;
    }
}
