using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18219
    /// <summary>
    /// Defines the format of the enclave configuration on Windows on the currently running architecture.
    /// </summary>
    /// <seealso cref="IMAGE_ENCLAVE_CONFIG32"/>
    /// <seealso cref="IMAGE_ENCLAVE_CONFIG64"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_ENCLAVE_CONFIG
    {
        /// <summary>
        /// The size of the <see cref="IMAGE_ENCLAVE_CONFIG"/> structure, in bytes.
        /// </summary>
        public int Size;
        /// <summary>
        /// <para>
        /// The minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG"/> structure that the image loader must be able to process in order for the enclave to be usable. This member allows an enclave to inform an earlier version of the image loader that the image loader can safely load the enclave and ignore optional members added to <see cref="IMAGE_ENCLAVE_CONFIG"/> for later versions of the enclave. If the size of <see cref="IMAGE_ENCLAVE_CONFIG"/> that the image loader can process is less than <see cref="MinimumRequiredConfigSize"/>, the enclave cannot be run securely.
        /// </para>
        /// <para>
        /// If <see cref="MinimumRequiredConfigSize"/> is <c>0</c> (zero), the minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG"/> structure that the image loader must be able to process in order for the enclave to be usable is assumed to be the size of the structure through and including the <see cref="MinimumRequiredConfigSize"/> member.
        /// </para>
        /// </summary>
        public int MinimumRequiredConfigSize;
        /// <summary>
        /// A flag that indicates whether the enclave permits debugging.
        /// </summary>
        public IMAGE_ENCLAVE_POLICY_FLAGS PolicyFlags;
        /// <summary>
        /// The number of images in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int NumberOfImports;
        /// <summary>
        /// The relative virtual address of the array of images that the enclave image may import, with identity information for each image.
        /// </summary>
        public int ImportList;
        /// <summary>
        /// The size of each image in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int ImportEntrySize;
        /// <summary>
        /// The family identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte FamilyID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The image identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte ImageID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int ImageVersion;
        /// <summary>
        /// The security version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int SecurityVersion;
        #region public int EnclaveSize;
        internal IntPtr EnclaveSizeField;
        /// <summary>
        /// The expected virtual size of the private address range for the enclave, in bytes.
        /// </summary>
        public int EnclaveSize
        {
            get => EnclaveSizeField.ToInt32();
            set => EnclaveSizeField = new IntPtr(value);
        }
        /// <inheritdoc cref="EnclaveSize"/>
        public long EnclaveSize64
        {
            get => EnclaveSizeField.ToInt64();
            set => EnclaveSizeField = new IntPtr(value);
        }
        #endregion
        /// <summary>
        /// The maximum number of threads that can be created within the enclave.
        /// </summary>
        public int NumberOfThreads;
        /// <summary>
        /// A flag that indicates whether the image is suitable for use as the primary image in the enclave.
        /// </summary>
        public IMAGE_ENCLAVE_FLAGS EnclaveFlags;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18187
    /// <summary>
    /// Defines the format of the enclave configuration for systems running 32-bit Windows.
    /// </summary>
    /// <remarks>
    /// The <see cref="IMAGE_ENCLAVE_CONFIG"/> structure is defined as another name for the <see cref="IMAGE_ENCLAVE_CONFIG32"/> structure on systems that run 32-bit Windows.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_enclave_config32">IMAGE_ENCLAVE_CONFIG32 structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_ENCLAVE_CONFIG64"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_ENCLAVE_CONFIG32
    {
        /// <summary>
        /// The size of the <see cref="IMAGE_ENCLAVE_CONFIG32"/> structure, in bytes.
        /// </summary>
        public int Size;
        /// <summary>
        /// <para>
        /// The minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG32"/> structure that the image loader must be able to process in order for the enclave to be usable. This member allows an enclave to inform an earlier version of the image loader that the image loader can safely load the enclave and ignore optional members added to <see cref="IMAGE_ENCLAVE_CONFIG32"/> for later versions of the enclave. If the size of <see cref="IMAGE_ENCLAVE_CONFIG32"/> that the image loader can process is less than <see cref="MinimumRequiredConfigSize"/>, the enclave cannot be run securely.
        /// </para>
        /// <para>
        /// If <see cref="MinimumRequiredConfigSize"/> is <c>0</c> (zero), the minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG32"/> structure that the image loader must be able to process in order for the enclave to be usable is assumed to be the size of the structure through and including the <see cref="MinimumRequiredConfigSize"/> member.
        /// </para>
        /// </summary>
        public int MinimumRequiredConfigSize;
        /// <summary>
        /// A flag that indicates whether the enclave permits debugging.
        /// </summary>
        public IMAGE_ENCLAVE_POLICY_FLAGS PolicyFlags;
        /// <summary>
        /// The number of images in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int NumberOfImports;
        /// <summary>
        /// The relative virtual address of the array of images that the enclave image may import, with identity information for each image.
        /// </summary>
        public int ImportList;
        /// <summary>
        /// The size of each image in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int ImportEntrySize;
        /// <summary>
        /// The family identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte FamilyID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The image identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte ImageID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int ImageVersion;
        /// <summary>
        /// The security version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int SecurityVersion;
        /// <summary>
        /// The expected virtual size of the private address range for the enclave, in bytes.
        /// </summary>
        public int EnclaveSize;
        /// <summary>
        /// The maximum number of threads that can be created within the enclave.
        /// </summary>
        public int NumberOfThreads;
        /// <summary>
        /// A flag that indicates whether the image is suitable for use as the primary image in the enclave.
        /// </summary>
        public IMAGE_ENCLAVE_FLAGS EnclaveFlags;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18203
    /// <summary>
    /// Defines the format of the enclave configuration for systems running 64-bit Windows.
    /// </summary>
    /// <remarks>
    /// The <see cref="IMAGE_ENCLAVE_CONFIG"/> structure is defined as another name for the <see cref="IMAGE_ENCLAVE_CONFIG32"/> structure on systems that run 64-bit Windows.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-image_enclave_config64">IMAGE_ENCLAVE_CONFIG64 structure</a></para>
    /// </remarks>
    /// <seealso cref="IMAGE_ENCLAVE_CONFIG32"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_ENCLAVE_CONFIG64
    {
        /// <summary>
        /// The size of the <see cref="IMAGE_ENCLAVE_CONFIG64"/> structure, in bytes.
        /// </summary>
        public int Size;
        /// <summary>
        /// <para>
        /// The minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG64"/> structure that the image loader must be able to process in order for the enclave to be usable. This member allows an enclave to inform an earlier version of the image loader that the image loader can safely load the enclave and ignore optional members added to <see cref="IMAGE_ENCLAVE_CONFIG64"/> for later versions of the enclave. If the size of <see cref="IMAGE_ENCLAVE_CONFIG64"/> that the image loader can process is less than <see cref="MinimumRequiredConfigSize"/>, the enclave cannot be run securely.
        /// </para>
        /// <para>
        /// If <see cref="MinimumRequiredConfigSize"/> is <c>0</c> (zero), the minimum size of the <see cref="IMAGE_ENCLAVE_CONFIG64"/> structure that the image loader must be able to process in order for the enclave to be usable is assumed to be the size of the structure through and including the <see cref="MinimumRequiredConfigSize"/> member.
        /// </para>
        /// </summary>
        public int MinimumRequiredConfigSize;
        /// <summary>
        /// A flag that indicates whether the enclave permits debugging.
        /// </summary>
        public IMAGE_ENCLAVE_POLICY_FLAGS PolicyFlags;
        /// <summary>
        /// The number of images in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int NumberOfImports;
        /// <summary>
        /// The relative virtual address of the array of images that the enclave image may import, with identity information for each image.
        /// </summary>
        public int ImportList;
        /// <summary>
        /// The size of each image in the array of images that the <see cref="ImportList"/> member points to.
        /// </summary>
        public int ImportEntrySize;
        /// <summary>
        /// The family identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte FamilyID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The image identifier that the author of the enclave assigned to the enclave.
        /// </summary>
        public fixed byte ImageID[IMAGE_ENCLAVE_SHORT_ID_LENGTH];
        /// <summary>
        /// The version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int ImageVersion;
        /// <summary>
        /// The security version number that the author of the enclave assigned to the enclave.
        /// </summary>
        public int SecurityVersion;
        /// <summary>
        /// The expected virtual size of the private address range for the enclave, in bytes.
        /// </summary>
        public long EnclaveSize;
        /// <summary>
        /// The maximum number of threads that can be created within the enclave.
        /// </summary>
        public int NumberOfThreads;
        /// <summary>
        /// A flag that indicates whether the image is suitable for use as the primary image in the enclave.
        /// </summary>
        public IMAGE_ENCLAVE_FLAGS EnclaveFlags;
    }
}
