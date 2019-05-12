using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;
    using static IMAGE_ENCLAVE_IMPORT_MATCH_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18233
    /// <summary>
    /// Defines a entry in the array of images that an enclave can import.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_enclave_import">IMAGE_ENCLAVE_IMPORT structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_ENCLAVE_IMPORT
    {
        /// <summary>
        /// The type of identifier of the image that must match the value in the import record.
        /// </summary>
        public IMAGE_ENCLAVE_IMPORT_MATCH_TYPE MatchType;
        /// <summary>
        /// The minimum enclave security version that each image must have for the image to be imported successfully. The image is rejected unless its enclave security version is equal to or greater than the minimum value in the import record. Set the value in the import record to zero to turn off the security version check.
        /// </summary>
        public int MinimumSecurityVersion;
        /// <summary>
        /// The unique identifier of the primary module for the enclave, if the <see cref="MatchType"/> member is <see cref="IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID"/>. Otherwise, the author identifier of the primary module for the enclave.
        /// </summary>
        public fixed byte UniqueOrAuthorID[IMAGE_ENCLAVE_LONG_ID_LENGTH];
        /// <summary>
        /// The family identifier of the primary module for the enclave.
        /// </summary>
        public fixed byte FamilyID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The image identifier of the primary module for the enclave.
        /// </summary>
        public fixed byte ImageID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The relative virtual address of a null-terminated string that contains the same value found in the import directory for the image.
        /// </summary>
        public int ImportName;
        /// <summary>Reserved.</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;
    }
}
