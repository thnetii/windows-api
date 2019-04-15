using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum FILE_SYSTEM_FLAGS : int
    {
        /// <summary>
        /// The specified volume supports case-sensitive file names. 
        /// </summary>
        FILE_CASE_SENSITIVE_SEARCH = WinNTConstants.FILE_CASE_SENSITIVE_SEARCH,
        /// <summary>
        /// The specified volume supports preserved case of file names when it places a name on disk. 
        /// </summary>
        FILE_CASE_PRESERVED_NAMES = WinNTConstants.FILE_CASE_PRESERVED_NAMES,
        /// <summary>
        /// The specified volume supports Unicode in file names as they appear on disk. 
        /// </summary>
        FILE_UNICODE_ON_DISK = WinNTConstants.FILE_UNICODE_ON_DISK,
        /// <summary>
        /// The specified volume preserves and enforces access control lists (ACL). For example, the NTFS file system preserves and enforces ACLs, and the FAT file system does not. 
        /// </summary>
        FILE_PERSISTENT_ACLS = WinNTConstants.FILE_PERSISTENT_ACLS,
        /// <summary>
        /// The specified volume supports file-based compression
        /// </summary>
        FILE_FILE_COMPRESSION = WinNTConstants.FILE_FILE_COMPRESSION,
        /// <summary>
        /// The specified volume supports disk quotas.
        /// </summary>
        FILE_VOLUME_QUOTAS = WinNTConstants.FILE_VOLUME_QUOTAS,
        /// <summary>
        /// The specified volume supports sparse files.
        /// </summary>
        FILE_SUPPORTS_SPARSE_FILES = WinNTConstants.FILE_SUPPORTS_SPARSE_FILES,
        /// <summary>
        /// The specified volume supports reparse points. 
        /// <para><strong>ReFS:</strong> ReFS supports reparse points but does not index them so FindFirstVolumeMountPoint and FindNextVolumeMountPoint will not function as expected.</para>
        /// </summary>
        FILE_SUPPORTS_REPARSE_POINTS = WinNTConstants.FILE_SUPPORTS_REPARSE_POINTS,
        FILE_SUPPORTS_REMOTE_STORAGE = WinNTConstants.FILE_SUPPORTS_REMOTE_STORAGE,
        FILE_RETURNS_CLEANUP_RESULT_INFO = WinNTConstants.FILE_RETURNS_CLEANUP_RESULT_INFO,
        FILE_SUPPORTS_POSIX_UNLINK_RENAME = WinNTConstants.FILE_SUPPORTS_POSIX_UNLINK_RENAME,

        /// <summary>
        /// The specified volume is a compressed volume, for example, a DoubleSpace volume.
        /// </summary>
        FILE_VOLUME_IS_COMPRESSED = WinNTConstants.FILE_VOLUME_IS_COMPRESSED,
        /// <summary>
        /// The specified volume supports object identifiers. 
        /// </summary>
        FILE_SUPPORTS_OBJECT_IDS = WinNTConstants.FILE_SUPPORTS_OBJECT_IDS,
        /// <summary>
        /// The specified volume supports the Encrypted File System (EFS). For more information, see <a href="https://msdn.microsoft.com/5f20109f-727d-44a9-90a1-0adc19b00d28">File Encryption</a>. 
        /// </summary>
        FILE_SUPPORTS_ENCRYPTION = WinNTConstants.FILE_SUPPORTS_ENCRYPTION,
        /// <summary>
        /// The specified volume supports named streams. 
        /// </summary>
        FILE_NAMED_STREAMS = WinNTConstants.FILE_NAMED_STREAMS,
        /// <summary>
        /// The specified volume is read-only. 
        /// </summary>
        FILE_READ_ONLY_VOLUME = WinNTConstants.FILE_READ_ONLY_VOLUME,
        /// <summary>
        /// The specified volume supports a single sequential write. 
        /// </summary>
        FILE_SEQUENTIAL_WRITE_ONCE = WinNTConstants.FILE_SEQUENTIAL_WRITE_ONCE,
        /// <summary>
        /// The specified volume supports transactions. For more information, see <a href="https://msdn.microsoft.com/85a79698-a1ae-45a4-805e-25175034fa65">About KTM</a>. 
        /// </summary>
        FILE_SUPPORTS_TRANSACTIONS = WinNTConstants.FILE_SUPPORTS_TRANSACTIONS,
        /// <summary>
        /// <para>The specified volume supports hard links. For more information, see <a href="https://msdn.microsoft.com/f9e40a86-a4a6-4524-8045-312da72dc655">Hard Links and Junctions</a>. </para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported until Windows Server 2008 R2 and Windows 7.</para>
        /// </summary>
        FILE_SUPPORTS_HARD_LINKS = WinNTConstants.FILE_SUPPORTS_HARD_LINKS,
        /// <summary>
        /// <para>The specified volume supports extended attributes. An extended attribute is a piece of application-specific metadata that an application can associate with a file and is not part of the file's data.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported until Windows Server 2008 R2 and Windows 7.</para>
        /// </summary>
        FILE_SUPPORTS_EXTENDED_ATTRIBUTES = WinNTConstants.FILE_SUPPORTS_EXTENDED_ATTRIBUTES,
        /// <summary>
        /// <para>The file system supports open by FileID. For more information, see <see cref="FILE_ID_BOTH_DIR_INFO"/>.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported until Windows Server 2008 R2 and Windows 7.</para>
        /// </summary>
        FILE_SUPPORTS_OPEN_BY_FILE_ID = WinNTConstants.FILE_SUPPORTS_OPEN_BY_FILE_ID,
        /// <summary>
        /// <para>The specified volume supports update sequence number (USN) journals. For more information, see <a href="https://msdn.microsoft.com/c41aa3a8-c8d8-4bf2-9bbb-d6a6a556c5e4">Change Journal Records</a>.</para>
        /// <para><strong>Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP:</strong> This value is not supported until Windows Server 2008 R2 and Windows 7.</para>
        /// </summary>
        FILE_SUPPORTS_USN_JOURNAL = WinNTConstants.FILE_SUPPORTS_USN_JOURNAL,
        FILE_SUPPORTS_INTEGRITY_STREAMS = WinNTConstants.FILE_SUPPORTS_INTEGRITY_STREAMS,
        FILE_SUPPORTS_BLOCK_REFCOUNTING = WinNTConstants.FILE_SUPPORTS_BLOCK_REFCOUNTING,
        FILE_SUPPORTS_SPARSE_VDL = WinNTConstants.FILE_SUPPORTS_SPARSE_VDL,
        /// <summary>
        /// <para>The specified volume is a direct access (DAX) volume.</para>
        /// <note>This flag was introduced in Windows 10, version 1607.</note>
        /// </summary>
        FILE_DAX_VOLUME = WinNTConstants.FILE_DAX_VOLUME,
        FILE_SUPPORTS_GHOSTING = WinNTConstants.FILE_SUPPORTS_GHOSTING,
    }
}
