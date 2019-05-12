using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18253
    /// <summary>
    /// Defines a entry in the array of images that an enclave can import.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_debug_directory">IMAGE_DEBUG_DIRECTORY structure</a></para>
    /// </remarks>
    /// <seealso href="https://msdn.microsoft.com/b88c7a21-933f-450c-97e8-04cf3c5f9b11">ImageHlp Structures</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_DEBUG_DIRECTORY
    {
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Characteristics;
        /// <summary>
        /// The time and date the debugging information was created.
        /// </summary>
        public int TimeDateStamp;
        #region public short MajorVersion; public short MinorVersion;
        /// <summary>
        /// The major version number of the debugging information format.
        /// </summary>
        public short MajorVersion;
        /// <summary>
        /// The minor version number of the debugging information format.
        /// </summary>
        public short MinorVersion;
        /// <summary>
        /// The version of the debugging information format.
        /// </summary>
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set => (MajorVersion, MinorVersion) = value is null
                ? default
                : ((short)value.Major, (short)value.Minor);
        }
        #endregion
        /// <summary>
        /// The format of the debugging information.
        /// </summary>
        public IMAGE_DEBUG_TYPE Type;
        /// <summary>
        /// The size of the debugging information, in bytes. This value does not include the debug directory itself.
        /// </summary>
        public int SizeOfData;
        /// <summary>
        /// The address of the debugging information when the image is loaded, relative to the image base.
        /// </summary>
        public int AddressOfRawData;
        /// <summary>
        /// A file pointer to the debugging information.
        /// </summary>
        public int PointerToRawData;
    }
}
