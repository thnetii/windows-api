using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;
using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.PrivilegeConstants;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>
    /// The <see cref="ACCESS_MASK"/> data type is a <see cref="uint"/>-sized enumeration type that defines standard, specific, and generic rights. These rights are used in <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entries</a></em> (ACEs) and are the primary means of specifying the requested or granted access to an object.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374892.aspx">ACCESS_MASK</a></para>
    /// </remarks>
    /// <seealso cref="GENERIC_MAPPING"/>
    [Flags]
    public enum ACCESS_MASK : uint
    {
        /// <summary>Delete access.</summary>
        DELETE = 0x00010000,
        /// <summary>Read access to the owner, group, and <em><a href="https://msdn.microsoft.com/en-us/library/ms721573.aspx#_security_discretionary_access_control_list_gly">discretionary access control list</a></em> (DACL) of the security descriptor.</summary>
        READ_CONTROL = 0x00020000,
        /// <summary>Write access to the DACL.</summary>
        WRITE_DAC = 0x00040000,
        /// <summary>Write access to owner.</summary>
        WRITE_OWNER = 0x00080000,
        /// <summary>Synchronize access.</summary>
        SYNCHRONIZE = 0x00100000,

        /// <summary />
        STANDARD_RIGHTS_REQUIRED = 0x000F0000,

        /// <summary />
        STANDARD_RIGHTS_READ = READ_CONTROL,
        /// <summary />
        STANDARD_RIGHTS_WRITE = READ_CONTROL,
        /// <summary />
        STANDARD_RIGHTS_EXECUTE = READ_CONTROL,

        /// <summary>Standard rights. Contains the object's standard access rights.</summary>
        STANDARD_RIGHTS_ALL = 0x001F0000,

        /// <summary>Specific rights. Contains the access mask specific to the object type associated with the mask.</summary>
        SPECIFIC_RIGHTS_ALL = 0x0000FFFF,

        /// <summary>
        /// Access system security. It is used to indicate access to a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_system_access_control_list_gly">system access control list</a></em> (SACL). This type of access requires the calling process to have the <see cref="SE_SECURITY_NAME"/> (Manage auditing and security log) privilege. If this flag is set in the access mask of an audit access ACE (successful or unsuccessful access), the SACL access will be audited.
        /// </summary>
        ACCESS_SYSTEM_SECURITY = 0x01000000,

        /// <summary>Maximum allowed</summary>
        MAXIMUM_ALLOWED = 0x02000000,

        /// <summary>Generic read.</summary>
        GENERIC_READ = 0x80000000,
        /// <summary>Generic write.</summary>
        GENERIC_WRITE = 0x40000000,
        /// <summary>Generic execute.</summary>
        GENERIC_EXECUTE = 0x20000000,
        /// <summary>Generic all.</summary>
        GENERIC_ALL = 0x10000000,

        FILE_READ_DATA = 0x0001,    // file & pipe
        FILE_LIST_DIRECTORY = 0x0001,    // directory

        FILE_WRITE_DATA = 0x0002,    // file & pipe
        FILE_ADD_FILE = 0x0002,    // directory

        FILE_APPEND_DATA = 0x0004,    // file
        FILE_ADD_SUBDIRECTORY = 0x0004,    // directory
        FILE_CREATE_PIPE_INSTANCE = 0x0004,    // named pipe


        FILE_READ_EA = 0x0008,    // file & directory

        FILE_WRITE_EA = 0x0010,    // file & directory

        FILE_EXECUTE = 0x0020,    // file
        FILE_TRAVERSE = 0x0020,    // directory

        FILE_DELETE_CHILD = 0x0040,    // directory

        FILE_READ_ATTRIBUTES = 0x0080,    // all

        FILE_WRITE_ATTRIBUTES = 0x0100,    // all

        FILE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF,

        FILE_GENERIC_READ = STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE,

        FILE_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA | SYNCHRONIZE,

        FILE_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE,

        AUDIT_SET_SYSTEM_POLICY = (0x0001),
        AUDIT_QUERY_SYSTEM_POLICY = (0x0002),
        AUDIT_SET_USER_POLICY = (0x0004),
        AUDIT_QUERY_USER_POLICY = (0x0008),
        AUDIT_ENUMERATE_USERS = (0x0010),
        AUDIT_SET_MISC_POLICY = (0x0020),
        AUDIT_QUERY_MISC_POLICY = (0x0040),

        AUDIT_GENERIC_ALL = (STANDARD_RIGHTS_REQUIRED | AUDIT_SET_SYSTEM_POLICY | AUDIT_QUERY_SYSTEM_POLICY | AUDIT_SET_USER_POLICY | AUDIT_QUERY_USER_POLICY | AUDIT_ENUMERATE_USERS | AUDIT_SET_MISC_POLICY | AUDIT_QUERY_MISC_POLICY),

        AUDIT_GENERIC_READ = (STANDARD_RIGHTS_READ | AUDIT_QUERY_SYSTEM_POLICY | AUDIT_QUERY_USER_POLICY | AUDIT_ENUMERATE_USERS | AUDIT_QUERY_MISC_POLICY),

        AUDIT_GENERIC_WRITE = (STANDARD_RIGHTS_WRITE | AUDIT_SET_USER_POLICY | AUDIT_SET_MISC_POLICY | AUDIT_SET_SYSTEM_POLICY),

        AUDIT_GENERIC_EXECUTE = (STANDARD_RIGHTS_EXECUTE),

    }

    public class AccessMaskArrayAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsInt32CastArray<ACCESS_MASK>
    {
        protected AccessMaskArrayAnySafeHandle() : base() { }
        protected AccessMaskArrayAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected AccessMaskArrayAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public AccessMaskArrayAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
