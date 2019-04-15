using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;
    using static WinNTFunctions;

    public static class WinNTRuntimeConstants
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 117
        public static readonly int MAX_NATURAL_ALIGNMENT = IntPtr.Size;
        // #if defined(_WIN64) || defined(_M_ALPHA)
        // public const int MEMORY_ALLOCATION_ALIGNMENT = 16;
        // #else
        // public const int MEMORY_ALLOCATION_ALIGNMENT = 8;
        // #endif

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 216
        // #if defined(_AMD64_) || defined(_X86_)
        // public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 64;
        // #else
        // public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 128;
        // #endif

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 614
        private static int GET_MAXIMUM_PROC_PER_GROUP()
        {
            switch (RuntimeInformation.OSArchitecture)
            {
                case Architecture.X86:
                case Architecture.Arm:
                    return 32;
                case Architecture.X64:
                case Architecture.Arm64:
                    return 64;
                default: return default;
            }
        }

        public static readonly int MAXIMUM_PROC_PER_GROUP = GET_MAXIMUM_PROC_PER_GROUP();

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 624
        public static readonly int MAXIMUM_PROCESSORS = MAXIMUM_PROC_PER_GROUP;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2209
        //
        // ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED **
        //
        //  Deprecated default System and User IDs for language and locale.
        //
        //  Locale names such as LOCALE_NAME_SYSTEM_DEFAULT, LOCALE_NAME_USER_DEFAULT,
        //  and LOCALE_NAME_INVARIANT are preferred.  See documentation for GetLocaleInfoEx.
        //

        public static readonly int LANG_SYSTEM_DEFAULT = MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT);
        public static readonly int LANG_USER_DEFAULT = MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT);

        public static readonly int LOCALE_SYSTEM_DEFAULT = MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT);
        public static readonly int LOCALE_USER_DEFAULT = MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2224
        //
        //  Other special IDs for language and locale.
        //
        //  DEPRECATED: These identifiers are all underspecified and lose information.
        //              Please use Locale Names such as "en-FJ".
        //              See documentation for GetLocaleInfoEx.
        //
        public static readonly int LOCALE_CUSTOM_DEFAULT =
            MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_DEFAULT), SORT_DEFAULT);

        public static readonly int LOCALE_CUSTOM_UNSPECIFIED =
            MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_UNSPECIFIED), SORT_DEFAULT);

        public static readonly int LOCALE_CUSTOM_UI_DEFAULT =
            MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_UI_CUSTOM_DEFAULT), SORT_DEFAULT);

        public static readonly int LOCALE_NEUTRAL =
            MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), SORT_DEFAULT);

        public static readonly int LOCALE_INVARIANT =
            MAKELCID(MAKELANGID(LANG_INVARIANT, SUBLANG_NEUTRAL), SORT_DEFAULT);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 2260
        /// <summary>
        /// Locale with an unassigned LCID
        /// These locales cannot be queried by LCID
        /// Currently same as <see cref="LOCALE_CUSTOM_UNSPECIFIED"/>
        /// </summary>
        [Obsolete("Please use Locale Names; see documentation for GetLocaleInfoEx.")]
        public static readonly int LOCALE_UNASSIGNED_LCID = LOCALE_CUSTOM_UNSPECIFIED;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8869
        ////////////////////////////////////////////////////////////////////////
        //                                                                    //
        //                             ACCESS TYPES                           //
        //                                                                    //
        ////////////////////////////////////////////////////////////////////////


        // begin_wdm
        //
        //  The following are masks for the predefined standard access types
        //

        public static readonly ACCESS_MASK DELETE = new ACCESS_MASK(WinNTConstants.DELETE);
        public static readonly ACCESS_MASK READ_CONTROL = new ACCESS_MASK(WinNTConstants.READ_CONTROL);
        public static readonly ACCESS_MASK WRITE_DAC = new ACCESS_MASK(WinNTConstants.WRITE_DAC);
        public static readonly ACCESS_MASK WRITE_OWNER = new ACCESS_MASK(WinNTConstants.WRITE_OWNER);
        public static readonly ACCESS_MASK SYNCHRONIZE = new ACCESS_MASK(WinNTConstants.SYNCHRONIZE);

        public static readonly ACCESS_MASK STANDARD_RIGHTS_REQUIRED = new ACCESS_MASK(WinNTConstants.STANDARD_RIGHTS_REQUIRED);

        public static readonly ACCESS_MASK STANDARD_RIGHTS_READ = new ACCESS_MASK(WinNTConstants.STANDARD_RIGHTS_READ);
        public static readonly ACCESS_MASK STANDARD_RIGHTS_WRITE = new ACCESS_MASK(WinNTConstants.STANDARD_RIGHTS_WRITE);
        public static readonly ACCESS_MASK STANDARD_RIGHTS_EXECUTE = new ACCESS_MASK(WinNTConstants.STANDARD_RIGHTS_EXECUTE);

        public static readonly ACCESS_MASK STANDARD_RIGHTS_ALL = new ACCESS_MASK(WinNTConstants.STANDARD_RIGHTS_ALL);

        public static readonly ACCESS_MASK SPECIFIC_RIGHTS_ALL = new ACCESS_MASK(WinNTConstants.SPECIFIC_RIGHTS_ALL);

        //
        // AccessSystemAcl access type
        //

        public static readonly ACCESS_MASK ACCESS_SYSTEM_SECURITY = new ACCESS_MASK(WinNTConstants.ACCESS_SYSTEM_SECURITY);

        //
        // MaximumAllowed access type
        //

        public static readonly ACCESS_MASK MAXIMUM_ALLOWED = new ACCESS_MASK(WinNTConstants.MAXIMUM_ALLOWED);

        //
        //  These are the generic rights.
        //

        public static readonly ACCESS_MASK GENERIC_READ = new ACCESS_MASK(WinNTConstants.GENERIC_READ);
        public static readonly ACCESS_MASK GENERIC_WRITE = new ACCESS_MASK(WinNTConstants.GENERIC_WRITE);
        public static readonly ACCESS_MASK GENERIC_EXECUTE = new ACCESS_MASK(WinNTConstants.GENERIC_EXECUTE);
        public static readonly ACCESS_MASK GENERIC_ALL = new ACCESS_MASK(WinNTConstants.GENERIC_ALL);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9012
        public static readonly int SECURITY_MAX_SID_SIZE =
            SizeOf<SID.STRUCT_SID>.Bytes - SizeOf<int>.Bytes + (SID_MAX_SUB_AUTHORITIES * SizeOf<int>.Bytes);

        public static int SECURITY_SID_SIZE(byte SubAuthorityCount_) => SizeOf<SID.STRUCT_SID>.Bytes - SizeOf<int>.Bytes +
            (SubAuthorityCount_ * SizeOf<int>.Bytes);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9078
        /////////////////////////////////////////////////////////////////////////////
        //                                                                         //
        // Universal well-known SIDs                                               //
        //                                                                         //
        //     Null SID                     S-1-0-0                                //
        //     World                        S-1-1-0                                //
        //     Local                        S-1-2-0                                //
        //     Creator Owner ID             S-1-3-0                                //
        //     Creator Group ID             S-1-3-1                                //
        //     Creator Owner Server ID      S-1-3-2                                //
        //     Creator Group Server ID      S-1-3-3                                //
        //                                                                         //
        //     (Non-unique IDs)             S-1-4                                  //
        //                                                                         //
        /////////////////////////////////////////////////////////////////////////////

        private static SID_IDENTIFIER_AUTHORITY SID_IDENTIFIER_AUTHORITY_FROM_BYTES(byte b0, byte b1, byte b2, byte b3, byte b4, byte b5)
        {
            ReadOnlySpan<byte> span = stackalloc byte[] { b0, b1, b2, b3, b4, b5 };
            return MemoryMarshal.Read<SID_IDENTIFIER_AUTHORITY>(span);
        }

        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_NULL_SID_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 0);
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_WORLD_SID_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 1);
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_LOCAL_SID_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 2);
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_CREATOR_SID_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 3);
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_NON_UNIQUE_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 4);
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_RESOURCE_MANAGER_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 9);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9115
        ///////////////////////////////////////////////////////////////////////////////
        //                                                                           //
        // NT well-known SIDs                                                        //
        //                                                                           //
        //     NT Authority            S-1-5                                         //
        //     Dialup                  S-1-5-1                                       //
        //                                                                           //
        //     Network                 S-1-5-2                                       //
        //     Batch                   S-1-5-3                                       //
        //     Interactive             S-1-5-4                                       //
        //     (Logon IDs)             S-1-5-5-X-Y                                   //
        //     Service                 S-1-5-6                                       //
        //     AnonymousLogon          S-1-5-7       (aka null logon session)        //
        //     Proxy                   S-1-5-8                                       //
        //     Enterprise DC (EDC)     S-1-5-9       (aka domain controller account) //
        //     Self                    S-1-5-10      (self RID)                      //
        //     Authenticated User      S-1-5-11      (Authenticated user somewhere)  //
        //     Restricted Code         S-1-5-12      (Running restricted code)       //
        //     Terminal Server         S-1-5-13      (Running on Terminal Server)    //
        //     Remote Logon            S-1-5-14      (Remote Interactive Logon)      //
        //     This Organization       S-1-5-15                                      //
        //                                                                           //
        //     IUser                   S-1-5-17
        //     Local System            S-1-5-18                                      //
        //     Local Service           S-1-5-19                                      //
        //     Network Service         S-1-5-20                                      //
        //                                                                           //
        //     (NT non-unique IDs)     S-1-5-0x15-... (NT Domain Sids)               //
        //                                                                           //
        //     (Built-in domain)       S-1-5-0x20                                    //
        //                                                                           //
        //     (Security Package IDs)  S-1-5-0x40                                    //
        //     NTLM Authentication     S-1-5-0x40-10                                 //
        //     SChannel Authentication S-1-5-0x40-14                                 //
        //     Digest Authentication   S-1-5-0x40-21                                 //
        //                                                                           //
        //     Other Organization      S-1-5-1000    (>=1000 can not be filtered)    //
        //                                                                           //
        //                                                                           //
        // NOTE: the relative identifier values (RIDs) determine which security      //
        //       boundaries the SID is allowed to cross.  Before adding new RIDs,    //
        //       a determination needs to be made regarding which range they should  //
        //       be added to in order to ensure proper "SID filtering"               //
        //                                                                           //
        ///////////////////////////////////////////////////////////////////////////////

        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_NT_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 5); // ntifs

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9361
        /// <summary>
        /// Application Package Authority.
        /// </summary>
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_APP_PACKAGE_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 15);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9403
        /// <summary>
        /// Mandatory Label Authority.
        /// </summary>
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_MANDATORY_LABEL_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 16);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9425
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_SCOPED_POLICY_ID_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 17);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9427
        /// <summary>
        /// Authentication Authority
        /// </summary>
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_AUTHENTICATION_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 18);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9440
        /// <summary>
        /// Process Trust Authority
        /// </summary>
        public static readonly SID_IDENTIFIER_AUTHORITY SECURITY_PROCESS_TRUST_AUTHORITY = SID_IDENTIFIER_AUTHORITY_FROM_BYTES(0, 0, 0, 0, 0, 19);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9600
        //
        // Allocate the System Luid.  The first 1000 LUIDs are reserved.
        // Use #999 here (0x3e7 = 999)
        //

        private static LUID LUID_FROM_INTS(int i1, int i2)
        {
            ReadOnlySpan<int> span = stackalloc int[] { i1, i2 };
            return MemoryMarshal.Read<LUID>(MemoryMarshal.AsBytes(span));
        }

        public static readonly LUID SYSTEM_LUID = LUID_FROM_INTS(0x3e7, 0x0);
        public static readonly LUID ANONYMOUS_LOGON_LUID = LUID_FROM_INTS(0x3e6, 0x0);
        public static readonly LUID LOCALSERVICE_LUID = LUID_FROM_INTS(0x3e5, 0x0);
        public static readonly LUID NETWORKSERVICE_LUID = LUID_FROM_INTS(0x3e4, 0x0);
        public static readonly LUID IUSER_LUID = LUID_FROM_INTS(0x3e3, 0x0);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9915
        public static readonly ACCESS_MASK SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = new ACCESS_MASK(WinNTConstants.SYSTEM_MANDATORY_LABEL_NO_WRITE_UP);
        public static readonly ACCESS_MASK SYSTEM_MANDATORY_LABEL_NO_READ_UP = new ACCESS_MASK(WinNTConstants.SYSTEM_MANDATORY_LABEL_NO_READ_UP);
        public static readonly ACCESS_MASK SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = new ACCESS_MASK(WinNTConstants.SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP);

        public static readonly ACCESS_MASK SYSTEM_MANDATORY_LABEL_VALID_MASK = new ACCESS_MASK(WinNTConstants.SYSTEM_MANDATORY_LABEL_VALID_MASK);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9923
        // Placeholder value that allows all ranges
        public static readonly ACCESS_MASK SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = new ACCESS_MASK(WinNTConstants.SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK);
        public static readonly ACCESS_MASK SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = new ACCESS_MASK(WinNTConstants.SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK);
        public static readonly ACCESS_MASK SYSTEM_ACCESS_FILTER_VALID_MASK = new ACCESS_MASK(WinNTConstants.SYSTEM_ACCESS_FILTER_VALID_MASK);
        public static readonly ACCESS_MASK SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = new ACCESS_MASK(WinNTConstants.SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK);

        public static readonly int SECURITY_DESCRIPTOR_MIN_LENGTH = SizeOf<SECURITY_DESCRIPTOR.STRUCT_SECURITY_DESCRIPTOR>.Bytes;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10733
        public static readonly int TOKEN_USER_MAX_SIZE = SizeOf<TOKEN_USER>.Bytes + SECURITY_MAX_SID_SIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10758
        public static readonly int TOKEN_OWNER_MAX_SIZE = SizeOf<TOKEN_OWNER>.Bytes + SECURITY_MAX_SID_SIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10811
        public static readonly int TOKEN_INTEGRITY_LEVEL_MAX_SIZE = ((SizeOf<TOKEN_MANDATORY_LABEL>.Bytes + IntPtr.Size - 1) & ~(IntPtr.Size - 1)) + SECURITY_MAX_SID_SIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10896
        public static readonly int TOKEN_APPCONTAINER_SID_MAX_SIZE = SizeOf<TOKEN_APPCONTAINER_INFORMATION>.Bytes + SECURITY_MAX_SID_SIZE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11284
        public static readonly ACCESS_MASK PROCESS_TERMINATE = new ACCESS_MASK(WinNTConstants.PROCESS_TERMINATE);
        public static readonly ACCESS_MASK PROCESS_CREATE_THREAD = new ACCESS_MASK(WinNTConstants.PROCESS_CREATE_THREAD);
        public static readonly ACCESS_MASK PROCESS_SET_SESSIONID = new ACCESS_MASK(WinNTConstants.PROCESS_SET_SESSIONID);
        public static readonly ACCESS_MASK PROCESS_VM_OPERATION = new ACCESS_MASK(WinNTConstants.PROCESS_VM_OPERATION);
        public static readonly ACCESS_MASK PROCESS_VM_READ = new ACCESS_MASK(WinNTConstants.PROCESS_VM_READ);
        public static readonly ACCESS_MASK PROCESS_VM_WRITE = new ACCESS_MASK(WinNTConstants.PROCESS_VM_WRITE);
        public static readonly ACCESS_MASK PROCESS_DUP_HANDLE = new ACCESS_MASK(WinNTConstants.PROCESS_DUP_HANDLE);
        public static readonly ACCESS_MASK PROCESS_CREATE_PROCESS = new ACCESS_MASK(WinNTConstants.PROCESS_CREATE_PROCESS);
        public static readonly ACCESS_MASK PROCESS_SET_QUOTA = new ACCESS_MASK(WinNTConstants.PROCESS_SET_QUOTA);
        public static readonly ACCESS_MASK PROCESS_SET_INFORMATION = new ACCESS_MASK(WinNTConstants.PROCESS_SET_INFORMATION);
        public static readonly ACCESS_MASK PROCESS_QUERY_INFORMATION = new ACCESS_MASK(WinNTConstants.PROCESS_QUERY_INFORMATION);
        public static readonly ACCESS_MASK PROCESS_SUSPEND_RESUME = new ACCESS_MASK(WinNTConstants.PROCESS_SUSPEND_RESUME);
        public static readonly ACCESS_MASK PROCESS_QUERY_LIMITED_INFORMATION = new ACCESS_MASK(WinNTConstants.PROCESS_QUERY_LIMITED_INFORMATION);
        public static readonly ACCESS_MASK PROCESS_SET_LIMITED_INFORMATION = new ACCESS_MASK(WinNTConstants.PROCESS_SET_LIMITED_INFORMATION);
        public static readonly ACCESS_MASK PROCESS_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.PROCESS_ALL_ACCESS);

        public static readonly ACCESS_MASK THREAD_TERMINATE = new ACCESS_MASK(WinNTConstants.THREAD_TERMINATE);
        public static readonly ACCESS_MASK THREAD_SUSPEND_RESUME = new ACCESS_MASK(WinNTConstants.THREAD_SUSPEND_RESUME);
        public static readonly ACCESS_MASK THREAD_GET_CONTEXT = new ACCESS_MASK(WinNTConstants.THREAD_GET_CONTEXT);
        public static readonly ACCESS_MASK THREAD_SET_CONTEXT = new ACCESS_MASK(WinNTConstants.THREAD_SET_CONTEXT);
        public static readonly ACCESS_MASK THREAD_QUERY_INFORMATION = new ACCESS_MASK(WinNTConstants.THREAD_QUERY_INFORMATION);
        public static readonly ACCESS_MASK THREAD_SET_INFORMATION = new ACCESS_MASK(WinNTConstants.THREAD_SET_INFORMATION);
        public static readonly ACCESS_MASK THREAD_SET_THREAD_TOKEN = new ACCESS_MASK(WinNTConstants.THREAD_SET_THREAD_TOKEN);
        public static readonly ACCESS_MASK THREAD_IMPERSONATE = new ACCESS_MASK(WinNTConstants.THREAD_IMPERSONATE);
        public static readonly ACCESS_MASK THREAD_DIRECT_IMPERSONATION = new ACCESS_MASK(WinNTConstants.THREAD_DIRECT_IMPERSONATION);
        // begin_wdm
        public static readonly ACCESS_MASK THREAD_SET_LIMITED_INFORMATION = new ACCESS_MASK(WinNTConstants.THREAD_SET_LIMITED_INFORMATION);
        public static readonly ACCESS_MASK THREAD_QUERY_LIMITED_INFORMATION = new ACCESS_MASK(WinNTConstants.THREAD_QUERY_LIMITED_INFORMATION);
        public static readonly ACCESS_MASK THREAD_RESUME = new ACCESS_MASK(WinNTConstants.THREAD_RESUME);
        public static readonly ACCESS_MASK THREAD_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.THREAD_ALL_ACCESS);

        public static readonly ACCESS_MASK JOB_OBJECT_ASSIGN_PROCESS = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_ASSIGN_PROCESS);
        public static readonly ACCESS_MASK JOB_OBJECT_SET_ATTRIBUTES = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_SET_ATTRIBUTES);
        public static readonly ACCESS_MASK JOB_OBJECT_QUERY = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_QUERY);
        public static readonly ACCESS_MASK JOB_OBJECT_TERMINATE = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_TERMINATE);
        public static readonly ACCESS_MASK JOB_OBJECT_SET_SECURITY_ATTRIBUTES = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_SET_SECURITY_ATTRIBUTES);
        public static readonly ACCESS_MASK JOB_OBJECT_IMPERSONATE = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_IMPERSONATE);
        public static readonly ACCESS_MASK JOB_OBJECT_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.JOB_OBJECT_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12223
        public static readonly ACCESS_MASK EVENT_MODIFY_STATE = new ACCESS_MASK(WinNTConstants.EVENT_MODIFY_STATE);
        public static readonly ACCESS_MASK EVENT_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.EVENT_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12223
        //
        // Mutant Specific Access Rights
        //
        public static readonly ACCESS_MASK MUTANT_QUERY_STATE = new ACCESS_MASK(WinNTConstants.MUTANT_QUERY_STATE);

        public static readonly ACCESS_MASK MUTANT_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.MUTANT_ALL_ACCESS);

        public static readonly ACCESS_MASK SEMAPHORE_MODIFY_STATE = new ACCESS_MASK(WinNTConstants.SEMAPHORE_MODIFY_STATE);
        public static readonly ACCESS_MASK SEMAPHORE_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.SEMAPHORE_ALL_ACCESS);

        //
        // Timer Specific Access Rights.
        //

        public static readonly ACCESS_MASK TIMER_QUERY_STATE = new ACCESS_MASK(WinNTConstants.TIMER_QUERY_STATE);
        public static readonly ACCESS_MASK TIMER_MODIFY_STATE = new ACCESS_MASK(WinNTConstants.TIMER_MODIFY_STATE);

        public static readonly ACCESS_MASK TIMER_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.TIMER_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12668
        public static readonly ACCESS_MASK SECTION_QUERY = new ACCESS_MASK(WinNTConstants.SECTION_QUERY);
        public static readonly ACCESS_MASK SECTION_MAP_WRITE = new ACCESS_MASK(WinNTConstants.SECTION_MAP_WRITE);
        public static readonly ACCESS_MASK SECTION_MAP_READ = new ACCESS_MASK(WinNTConstants.SECTION_MAP_READ);
        public static readonly ACCESS_MASK SECTION_MAP_EXECUTE = new ACCESS_MASK(WinNTConstants.SECTION_MAP_EXECUTE);
        public static readonly ACCESS_MASK SECTION_EXTEND_SIZE = new ACCESS_MASK(WinNTConstants.SECTION_EXTEND_SIZE);
        /// <remarks>not included in <see cref="SECTION_ALL_ACCESS"/></remarks>
        public static readonly ACCESS_MASK SECTION_MAP_EXECUTE_EXPLICIT = new ACCESS_MASK(WinNTConstants.SECTION_MAP_EXECUTE_EXPLICIT);

        public static readonly ACCESS_MASK SECTION_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.SECTION_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12681
        //
        // Session Specific Access Rights.
        //

        public static readonly ACCESS_MASK SESSION_QUERY_ACCESS = new ACCESS_MASK(WinNTConstants.SESSION_QUERY_ACCESS);
        public static readonly ACCESS_MASK SESSION_MODIFY_ACCESS = new ACCESS_MASK(WinNTConstants.SESSION_MODIFY_ACCESS);

        public static readonly ACCESS_MASK SESSION_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.SESSION_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12819
        //
        // Define access rights to files and directories
        //

        //
        // The FILE_READ_DATA and FILE_WRITE_DATA constants are also defined in
        // devioctl.h as FILE_READ_ACCESS and FILE_WRITE_ACCESS. The values for these
        // constants *MUST* always be in sync.
        // The values are redefined in devioctl.h because they must be available to
        // both DOS and NT.
        //

        /// <summary>
        /// Grants the right to read data from the file.
        /// </summary>
        public static readonly ACCESS_MASK FILE_READ_DATA = new ACCESS_MASK(WinNTConstants.FILE_READ_DATA);
        /// <summary>
        /// Grants the right to read data from the file. For a directory, this value grants the right to list the contents of the directory.
        /// </summary>
        public static readonly ACCESS_MASK FILE_LIST_DIRECTORY = new ACCESS_MASK(WinNTConstants.FILE_LIST_DIRECTORY);

        /// <summary>
        /// Grants the right to write data to the file.
        /// </summary>
        public static readonly ACCESS_MASK FILE_WRITE_DATA = new ACCESS_MASK(WinNTConstants.FILE_WRITE_DATA);
        /// <summary>
        /// Grants the right to write data to the file. For a directory, this value grants the right to create a file in the directory.
        /// </summary>
        public static readonly ACCESS_MASK FILE_ADD_FILE = new ACCESS_MASK(WinNTConstants.FILE_ADD_FILE);

        /// <summary>
        /// Grants the right to append data to the file. For a directory, this value grants the right to create a subdirectory.
        /// </summary>
        public static readonly ACCESS_MASK FILE_APPEND_DATA = new ACCESS_MASK(WinNTConstants.FILE_APPEND_DATA);
        /// <summary>
        /// Grants the right to append data to the file. For a directory, this value grants the right to create a subdirectory.
        /// </summary>
        public static readonly ACCESS_MASK FILE_ADD_SUBDIRECTORY = new ACCESS_MASK(WinNTConstants.FILE_ADD_SUBDIRECTORY);
        public static readonly ACCESS_MASK FILE_CREATE_PIPE_INSTANCE = new ACCESS_MASK(WinNTConstants.FILE_CREATE_PIPE_INSTANCE);

        /// <summary>
        /// Grants the right to read extended attributes.
        /// </summary>
        public static readonly ACCESS_MASK FILE_READ_EA = new ACCESS_MASK(WinNTConstants.FILE_READ_EA);

        /// <summary>
        /// Grants the right to write extended attributes.
        /// </summary>
        public static readonly ACCESS_MASK FILE_WRITE_EA = new ACCESS_MASK(WinNTConstants.FILE_WRITE_EA);

        /// <summary>
        /// Grants the right to execute a file.
        /// </summary>
        public static readonly ACCESS_MASK FILE_EXECUTE = new ACCESS_MASK(WinNTConstants.FILE_EXECUTE);
        /// <summary>
        /// Grants the right to execute a file. For a directory, the directory can be traversed.
        /// </summary>
        public static readonly ACCESS_MASK FILE_TRAVERSE = new ACCESS_MASK(WinNTConstants.FILE_TRAVERSE);

        /// <summary>
        /// Grants the right to delete a directory and all the files it contains (its children), even if the files are read-only.
        /// </summary>
        public static readonly ACCESS_MASK FILE_DELETE_CHILD = new ACCESS_MASK(WinNTConstants.FILE_DELETE_CHILD);

        /// <summary>
        /// Grants the right to read file attributes.
        /// </summary>
        public static readonly ACCESS_MASK FILE_READ_ATTRIBUTES = new ACCESS_MASK(WinNTConstants.FILE_READ_ATTRIBUTES);

        /// <summary>
        /// Grants the right to change file attributes.
        /// </summary>
        public static readonly ACCESS_MASK FILE_WRITE_ATTRIBUTES = new ACCESS_MASK(WinNTConstants.FILE_WRITE_ATTRIBUTES);

        public static readonly ACCESS_MASK FILE_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.FILE_ALL_ACCESS);

        public static readonly ACCESS_MASK FILE_GENERIC_READ = new ACCESS_MASK(WinNTConstants.FILE_GENERIC_READ);


        public static readonly ACCESS_MASK FILE_GENERIC_WRITE = new ACCESS_MASK(WinNTConstants.FILE_GENERIC_WRITE);


        public static readonly ACCESS_MASK FILE_GENERIC_EXECUTE = new ACCESS_MASK(WinNTConstants.FILE_GENERIC_EXECUTE);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13566
        //
        // Object Manager Symbolic Link Specific Access Rights.
        //

        public static readonly ACCESS_MASK DUPLICATE_CLOSE_SOURCE = new ACCESS_MASK(WinNTConstants.DUPLICATE_CLOSE_SOURCE);
        public static readonly ACCESS_MASK DUPLICATE_SAME_ACCESS = new ACCESS_MASK(WinNTConstants.DUPLICATE_SAME_ACCESS);
    }
}
