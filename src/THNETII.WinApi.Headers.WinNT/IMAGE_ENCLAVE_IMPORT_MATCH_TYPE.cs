namespace THNETII.WinApi.Native.WinNT
{
    public enum IMAGE_ENCLAVE_IMPORT_MATCH_TYPE : int
    {
        /// <summary>
        ///  None of the identifiers of the image need to match the value in the import record. 
        /// </summary>
        IMAGE_ENCLAVE_IMPORT_MATCH_NONE = WinNTConstants.IMAGE_ENCLAVE_IMPORT_MATCH_NONE,
        /// <summary>
        /// The value of the enclave unique identifier of the image must match the value in the import record. Otherwise, loading of the image fails. 
        /// </summary>
        IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID = WinNTConstants.IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID,
        /// <summary>
        /// The value of the enclave author identifier of the image must match the value in the import record. Otherwise, loading of the image fails. If this flag is set and the import record indicates an author identifier of all zeros, the imported image must be part of the Windows installation. 
        /// </summary>
        IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID = WinNTConstants.IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID,
        /// <summary>
        /// The value of the enclave family identifier of the image must match the value in the import record. Otherwise, loading of the image fails. 
        /// </summary>
        IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID = WinNTConstants.IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID,
        /// <summary>
        /// The value of the enclave image identifier must match the value in the import record. Otherwise, loading of the image fails. 
        /// </summary>
        IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID = WinNTConstants.IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID,
    }
}
