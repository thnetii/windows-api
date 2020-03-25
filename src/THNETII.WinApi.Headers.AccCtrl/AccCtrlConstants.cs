using System.Security.AccessControl;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h
    public static class AccCtrlConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 262
        //
        // Definition: Inheritance flags
        // These bit masks are provided to allow simple application of inheritance in
        // explicit access requests on containers.
        //
        /// <summary>
        /// The specific access permissions will only be applied to
        /// the container, and will not be inherited by objects created
        /// within the container.
        /// </summary>
        public const AceFlags NO_INHERITANCE = 0x0;
        /// <summary>
        /// The specific access permissions will only be inherited
        /// by objects created within the specific container.
        /// The access permissions will not be applied to the
        /// container itself.
        /// </summary>
        public const AceFlags SUB_OBJECTS_ONLY_INHERIT = (AceFlags)0x1;
        /// <summary>
        /// The specific access permissions will be inherited
        /// and applied to sub containers created within the
        /// container, and will be applied to the container
        /// itself.
        /// </summary>
        public const AceFlags SUB_CONTAINERS_ONLY_INHERIT = (AceFlags)0x2;
        /// <summary>
        /// The specific access permissions will be
        /// inherited by containers created within the
        /// specific container, will be applied to
        /// objects created within the container, but
        /// will not be applied to the container itself.
        /// </summary>
        public const AceFlags SUB_CONTAINERS_AND_OBJECTS_INHERIT = (AceFlags)0x3;
        /// <summary>
        /// Inherit but do not propagate.
        /// </summary>
        public const AceFlags INHERIT_NO_PROPAGATE = (AceFlags)0x4;
        /// <summary>
        /// Inherit only.
        /// </summary>
        public const AceFlags INHERIT_ONLY = (AceFlags)0x8;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 290
        //
        // Informational bit that is returned
        //
        public const int INHERITED_ACCESS_ENTRY = 0x10;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 295
        //
        // Informational bit that tells where a node was inherited from.  Valid only
        // for NT 5 APIs
        //
        public const int INHERITED_PARENT = 0x10000000;
        public const int INHERITED_GRANDPARENT = 0x20000000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 346
        //----------------------------------------------------------------------------
        //
        //                                  NT5 APIs
        //
        //----------------------------------------------------------------------------

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 352
        //
        // Default provider
        //
        public const string ACCCTRL_DEFAULT_PROVIDER = "Windows NT Access Provider";

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 352
        //
        // TRUSTEE_ACCESS flags
        //
        public const int TRUSTEE_ACCESS_ALLOWED = 0x00000001;
        public const int TRUSTEE_ACCESS_READ = 0x00000002;
        public const int TRUSTEE_ACCESS_WRITE = 0x00000004;

        public const int TRUSTEE_ACCESS_EXPLICIT = 0x00000001;
        public const int TRUSTEE_ACCESS_READ_WRITE = (TRUSTEE_ACCESS_READ | TRUSTEE_ACCESS_WRITE);

        public const int TRUSTEE_ACCESS_ALL = unchecked((int)0xFFFFFFFF);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 528
        //
        // Generic permission values
        //
        public const int ACTRL_RESERVED = 0x00000000;
        public const int ACTRL_PERM_1 = 0x00000001;
        public const int ACTRL_PERM_2 = 0x00000002;
        public const int ACTRL_PERM_3 = 0x00000004;
        public const int ACTRL_PERM_4 = 0x00000008;
        public const int ACTRL_PERM_5 = 0x00000010;
        public const int ACTRL_PERM_6 = 0x00000020;
        public const int ACTRL_PERM_7 = 0x00000040;
        public const int ACTRL_PERM_8 = 0x00000080;
        public const int ACTRL_PERM_9 = 0x00000100;
        public const int ACTRL_PERM_10 = 0x00000200;
        public const int ACTRL_PERM_11 = 0x00000400;
        public const int ACTRL_PERM_12 = 0x00000800;
        public const int ACTRL_PERM_13 = 0x00001000;
        public const int ACTRL_PERM_14 = 0x00002000;
        public const int ACTRL_PERM_15 = 0x00004000;
        public const int ACTRL_PERM_16 = 0x00008000;
        public const int ACTRL_PERM_17 = 0x00010000;
        public const int ACTRL_PERM_18 = 0x00020000;
        public const int ACTRL_PERM_19 = 0x00040000;
        public const int ACTRL_PERM_20 = 0x00080000;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 553
        //
        // Access permissions
        //
        public const int ACTRL_ACCESS_ALLOWED = 0x00000001;
        public const int ACTRL_ACCESS_DENIED = 0x00000002;
        public const int ACTRL_AUDIT_SUCCESS = 0x00000004;
        public const int ACTRL_AUDIT_FAILURE = 0x00000008;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 561
        //
        // Property list flags
        //
        public const int ACTRL_ACCESS_PROTECTED = 0x00000001;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 566
        //
        // Standard and object rights
        //
        public const int ACTRL_SYSTEM_ACCESS = 0x04000000;
        public const int ACTRL_DELETE = 0x08000000;
        public const int ACTRL_READ_CONTROL = 0x10000000;
        public const int ACTRL_CHANGE_ACCESS = 0x20000000;
        public const int ACTRL_CHANGE_OWNER = 0x40000000;
        public const int ACTRL_SYNCHRONIZE = unchecked((int)0x80000000);
        public const int ACTRL_STD_RIGHTS_ALL = unchecked((int)0xf8000000);
        public const int ACTRL_STD_RIGHT_REQUIRED = (ACTRL_STD_RIGHTS_ALL & ~ACTRL_SYNCHRONIZE);

        public const int ACTRL_DS_OPEN = ACTRL_RESERVED;
        public const int ACTRL_DS_CREATE_CHILD = ACTRL_PERM_1;
        public const int ACTRL_DS_DELETE_CHILD = ACTRL_PERM_2;
        public const int ACTRL_DS_LIST = ACTRL_PERM_3;
        public const int ACTRL_DS_SELF = ACTRL_PERM_4;
        public const int ACTRL_DS_READ_PROP = ACTRL_PERM_5;
        public const int ACTRL_DS_WRITE_PROP = ACTRL_PERM_6;
        public const int ACTRL_DS_DELETE_TREE = ACTRL_PERM_7;
        public const int ACTRL_DS_LIST_OBJECT = ACTRL_PERM_8;
        public const int ACTRL_DS_CONTROL_ACCESS = ACTRL_PERM_9;

        public const int ACTRL_FILE_READ = ACTRL_PERM_1;
        public const int ACTRL_FILE_WRITE = ACTRL_PERM_2;
        public const int ACTRL_FILE_APPEND = ACTRL_PERM_3;
        public const int ACTRL_FILE_READ_PROP = ACTRL_PERM_4;
        public const int ACTRL_FILE_WRITE_PROP = ACTRL_PERM_5;
        public const int ACTRL_FILE_EXECUTE = ACTRL_PERM_6;
        public const int ACTRL_FILE_READ_ATTRIB = ACTRL_PERM_8;
        public const int ACTRL_FILE_WRITE_ATTRIB = ACTRL_PERM_9;
        public const int ACTRL_FILE_CREATE_PIPE = ACTRL_PERM_10;
        public const int ACTRL_DIR_LIST = ACTRL_PERM_1;
        public const int ACTRL_DIR_CREATE_OBJECT = ACTRL_PERM_2;
        public const int ACTRL_DIR_CREATE_CHILD = ACTRL_PERM_3;
        public const int ACTRL_DIR_DELETE_CHILD = ACTRL_PERM_7;
        public const int ACTRL_DIR_TRAVERSE = ACTRL_PERM_6;
        public const int ACTRL_KERNEL_TERMINATE = ACTRL_PERM_1;
        public const int ACTRL_KERNEL_THREAD = ACTRL_PERM_2;
        public const int ACTRL_KERNEL_VM = ACTRL_PERM_3;
        public const int ACTRL_KERNEL_VM_READ = ACTRL_PERM_4;
        public const int ACTRL_KERNEL_VM_WRITE = ACTRL_PERM_5;
        public const int ACTRL_KERNEL_DUP_HANDLE = ACTRL_PERM_6;
        public const int ACTRL_KERNEL_PROCESS = ACTRL_PERM_7;
        public const int ACTRL_KERNEL_SET_INFO = ACTRL_PERM_8;
        public const int ACTRL_KERNEL_GET_INFO = ACTRL_PERM_9;
        public const int ACTRL_KERNEL_CONTROL = ACTRL_PERM_10;
        public const int ACTRL_KERNEL_ALERT = ACTRL_PERM_11;
        public const int ACTRL_KERNEL_GET_CONTEXT = ACTRL_PERM_12;
        public const int ACTRL_KERNEL_SET_CONTEXT = ACTRL_PERM_13;
        public const int ACTRL_KERNEL_TOKEN = ACTRL_PERM_14;
        public const int ACTRL_KERNEL_IMPERSONATE = ACTRL_PERM_15;
        public const int ACTRL_KERNEL_DIMPERSONATE = ACTRL_PERM_16;
        public const int ACTRL_PRINT_SADMIN = ACTRL_PERM_1;
        public const int ACTRL_PRINT_SLIST = ACTRL_PERM_2;
        public const int ACTRL_PRINT_PADMIN = ACTRL_PERM_3;
        public const int ACTRL_PRINT_PUSE = ACTRL_PERM_4;
        public const int ACTRL_PRINT_JADMIN = ACTRL_PERM_5;
        public const int ACTRL_SVC_GET_INFO = ACTRL_PERM_1;
        public const int ACTRL_SVC_SET_INFO = ACTRL_PERM_2;
        public const int ACTRL_SVC_STATUS = ACTRL_PERM_3;
        public const int ACTRL_SVC_LIST = ACTRL_PERM_4;
        public const int ACTRL_SVC_START = ACTRL_PERM_5;
        public const int ACTRL_SVC_STOP = ACTRL_PERM_6;
        public const int ACTRL_SVC_PAUSE = ACTRL_PERM_7;
        public const int ACTRL_SVC_INTERROGATE = ACTRL_PERM_8;
        public const int ACTRL_SVC_UCONTROL = ACTRL_PERM_9;
        public const int ACTRL_REG_QUERY = ACTRL_PERM_1;
        public const int ACTRL_REG_SET = ACTRL_PERM_2;
        public const int ACTRL_REG_CREATE_CHILD = ACTRL_PERM_3;
        public const int ACTRL_REG_LIST = ACTRL_PERM_4;
        public const int ACTRL_REG_NOTIFY = ACTRL_PERM_5;
        public const int ACTRL_REG_LINK = ACTRL_PERM_6;
        public const int ACTRL_WIN_CLIPBRD = ACTRL_PERM_1;
        public const int ACTRL_WIN_GLOBAL_ATOMS = ACTRL_PERM_2;
        public const int ACTRL_WIN_CREATE = ACTRL_PERM_3;
        public const int ACTRL_WIN_LIST_DESK = ACTRL_PERM_4;
        public const int ACTRL_WIN_LIST = ACTRL_PERM_5;
        public const int ACTRL_WIN_READ_ATTRIBS = ACTRL_PERM_6;
        public const int ACTRL_WIN_WRITE_ATTRIBS = ACTRL_PERM_7;
        public const int ACTRL_WIN_SCREEN = ACTRL_PERM_8;
        public const int ACTRL_WIN_EXIT = ACTRL_PERM_9;

    }
}
