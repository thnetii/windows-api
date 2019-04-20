using System;
using System.IO;
using System.Runtime.CompilerServices;
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12878
        public const FileShare FILE_SHARE_READ = (FileShare)WinNTConstants.FILE_SHARE_READ;
        public const FileShare FILE_SHARE_WRITE = (FileShare)WinNTConstants.FILE_SHARE_WRITE;
        public const FileShare FILE_SHARE_DELETE = (FileShare)WinNTConstants.FILE_SHARE_DELETE;
        public const FileAttributes FILE_ATTRIBUTE_READONLY = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_READONLY;
        public const FileAttributes FILE_ATTRIBUTE_HIDDEN = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_HIDDEN;
        public const FileAttributes FILE_ATTRIBUTE_SYSTEM = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_SYSTEM;
        public const FileAttributes FILE_ATTRIBUTE_DIRECTORY = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_DIRECTORY;
        public const FileAttributes FILE_ATTRIBUTE_ARCHIVE = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_ARCHIVE;
        public const FileAttributes FILE_ATTRIBUTE_DEVICE = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_DEVICE;
        public const FileAttributes FILE_ATTRIBUTE_NORMAL = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_NORMAL;
        public const FileAttributes FILE_ATTRIBUTE_TEMPORARY = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_TEMPORARY;
        public const FileAttributes FILE_ATTRIBUTE_SPARSE_FILE = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_SPARSE_FILE;
        public const FileAttributes FILE_ATTRIBUTE_REPARSE_POINT = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_REPARSE_POINT;
        public const FileAttributes FILE_ATTRIBUTE_COMPRESSED = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_COMPRESSED;
        public const FileAttributes FILE_ATTRIBUTE_OFFLINE = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_OFFLINE;
        public const FileAttributes FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_NOT_CONTENT_INDEXED;
        public const FileAttributes FILE_ATTRIBUTE_ENCRYPTED = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_ENCRYPTED;
        public const FileAttributes FILE_ATTRIBUTE_INTEGRITY_STREAM = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_INTEGRITY_STREAM;
        public const FileAttributes FILE_ATTRIBUTE_VIRTUAL = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_VIRTUAL;
        public const FileAttributes FILE_ATTRIBUTE_NO_SCRUB_DATA = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_NO_SCRUB_DATA;
        public const FileAttributes FILE_ATTRIBUTE_EA = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_EA;
        public const FileAttributes FILE_ATTRIBUTE_PINNED = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_PINNED;
        public const FileAttributes FILE_ATTRIBUTE_UNPINNED = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_UNPINNED;
        public const FileAttributes FILE_ATTRIBUTE_RECALL_ON_OPEN = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_RECALL_ON_OPEN;
        public const FileAttributes FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS;
        public const FileAttributes FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = (FileAttributes)WinNTConstants.FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL;
        public const NotifyFilters FILE_NOTIFY_CHANGE_FILE_NAME = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_FILE_NAME;
        public const NotifyFilters FILE_NOTIFY_CHANGE_DIR_NAME = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_DIR_NAME;
        public const NotifyFilters FILE_NOTIFY_CHANGE_ATTRIBUTES = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_ATTRIBUTES;
        public const NotifyFilters FILE_NOTIFY_CHANGE_SIZE = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_SIZE;
        public const NotifyFilters FILE_NOTIFY_CHANGE_LAST_WRITE = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_LAST_WRITE;
        public const NotifyFilters FILE_NOTIFY_CHANGE_LAST_ACCESS = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_LAST_ACCESS;
        public const NotifyFilters FILE_NOTIFY_CHANGE_CREATION = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_CREATION;
        public const NotifyFilters FILE_NOTIFY_CHANGE_SECURITY = (NotifyFilters)WinNTConstants.FILE_NOTIFY_CHANGE_SECURITY;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13078
        public static readonly int REPARSE_GUID_DATA_BUFFER_HEADER_SIZE = Marshal.OffsetOf<REPARSE_GUID_DATA_BUFFER>(nameof(REPARSE_GUID_DATA_BUFFER.DataBufferField)).ToInt32();

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13086
        //
        // Predefined reparse tags.
        // These tags need to avoid conflicting with IO_REMOUNT defined in ntos\inc\io.h
        //

        public static readonly REPARSE_TAG IO_REPARSE_TAG_RESERVED_ZERO =
    WinNTConstants.IO_REPARSE_TAG_RESERVED_ZERO;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_RESERVED_ONE =
            WinNTConstants.IO_REPARSE_TAG_RESERVED_ONE;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_RESERVED_TWO =
            WinNTConstants.IO_REPARSE_TAG_RESERVED_TWO;

        /// <summary>
        /// The value of the following constant needs to satisfy the following conditions:
        /// (1) Be at least as large as the largest of the reserved tags.
        /// (2) Be strictly smaller than all the tags in use.
        /// </summary>
        public static readonly REPARSE_TAG IO_REPARSE_TAG_RESERVED_RANGE =
            WinNTConstants.IO_REPARSE_TAG_RESERVED_RANGE;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13156
        public static readonly REPARSE_TAG IO_REPARSE_TAG_MOUNT_POINT = WinNTConstants.IO_REPARSE_TAG_MOUNT_POINT;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_HSM = WinNTConstants.IO_REPARSE_TAG_HSM;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_HSM2 = WinNTConstants.IO_REPARSE_TAG_HSM2;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_SIS = WinNTConstants.IO_REPARSE_TAG_SIS;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_WIM = WinNTConstants.IO_REPARSE_TAG_WIM;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CSV = WinNTConstants.IO_REPARSE_TAG_CSV;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_DFS = WinNTConstants.IO_REPARSE_TAG_DFS;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_SYMLINK = WinNTConstants.IO_REPARSE_TAG_SYMLINK;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_DFSR = WinNTConstants.IO_REPARSE_TAG_DFSR;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_DEDUP = WinNTConstants.IO_REPARSE_TAG_DEDUP;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_NFS = WinNTConstants.IO_REPARSE_TAG_NFS;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_FILE_PLACEHOLDER = WinNTConstants.IO_REPARSE_TAG_FILE_PLACEHOLDER;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_WOF = WinNTConstants.IO_REPARSE_TAG_WOF;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_WCI = WinNTConstants.IO_REPARSE_TAG_WCI;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_WCI_1 = WinNTConstants.IO_REPARSE_TAG_WCI_1;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_GLOBAL_REPARSE = WinNTConstants.IO_REPARSE_TAG_GLOBAL_REPARSE;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD = WinNTConstants.IO_REPARSE_TAG_CLOUD;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_1 = WinNTConstants.IO_REPARSE_TAG_CLOUD_1;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_2 = WinNTConstants.IO_REPARSE_TAG_CLOUD_2;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_3 = WinNTConstants.IO_REPARSE_TAG_CLOUD_3;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_4 = WinNTConstants.IO_REPARSE_TAG_CLOUD_4;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_5 = WinNTConstants.IO_REPARSE_TAG_CLOUD_5;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_6 = WinNTConstants.IO_REPARSE_TAG_CLOUD_6;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_7 = WinNTConstants.IO_REPARSE_TAG_CLOUD_7;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_8 = WinNTConstants.IO_REPARSE_TAG_CLOUD_8;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_9 = WinNTConstants.IO_REPARSE_TAG_CLOUD_9;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_A = WinNTConstants.IO_REPARSE_TAG_CLOUD_A;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_B = WinNTConstants.IO_REPARSE_TAG_CLOUD_B;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_C = WinNTConstants.IO_REPARSE_TAG_CLOUD_C;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_D = WinNTConstants.IO_REPARSE_TAG_CLOUD_D;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_E = WinNTConstants.IO_REPARSE_TAG_CLOUD_E;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_CLOUD_F = WinNTConstants.IO_REPARSE_TAG_CLOUD_F;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_APPEXECLINK = WinNTConstants.IO_REPARSE_TAG_APPEXECLINK;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_PROJFS = WinNTConstants.IO_REPARSE_TAG_PROJFS;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_STORAGE_SYNC = WinNTConstants.IO_REPARSE_TAG_STORAGE_SYNC;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_WCI_TOMBSTONE = WinNTConstants.IO_REPARSE_TAG_WCI_TOMBSTONE;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_UNHANDLED = WinNTConstants.IO_REPARSE_TAG_UNHANDLED;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_ONEDRIVE = WinNTConstants.IO_REPARSE_TAG_ONEDRIVE;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_PROJFS_TOMBSTONE = WinNTConstants.IO_REPARSE_TAG_PROJFS_TOMBSTONE;
        public static readonly REPARSE_TAG IO_REPARSE_TAG_AF_UNIX = WinNTConstants.IO_REPARSE_TAG_AF_UNIX;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13503
        //
        // I/O Completion Specific Access Rights.
        //

        public static readonly ACCESS_MASK IO_COMPLETION_MODIFY_STATE = new ACCESS_MASK(WinNTConstants.IO_COMPLETION_MODIFY_STATE);
        public static readonly ACCESS_MASK IO_COMPLETION_ALL_ACCESS = new ACCESS_MASK(WinNTConstants.IO_COMPLETION_ALL_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13566
        //
        // Object Manager Symbolic Link Specific Access Rights.
        //

        public static readonly ACCESS_MASK DUPLICATE_CLOSE_SOURCE = new ACCESS_MASK(WinNTConstants.DUPLICATE_CLOSE_SOURCE);
        public static readonly ACCESS_MASK DUPLICATE_SAME_ACCESS = new ACCESS_MASK(WinNTConstants.DUPLICATE_SAME_ACCESS);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 13573
        //
        // =========================================
        // Define GUIDs which represent well-known power schemes
        // =========================================
        //

        /// <summary>
        /// Maximum Power Savings - indicates that very aggressive power savings measures will be used to help
        ///                         stretch battery life.
        /// </summary>
        public static readonly Guid GUID_MAX_POWER_SAVINGS = new Guid(WinNTConstants.GUID_MAX_POWER_SAVINGS);

        /// <summary>
        /// No Power Savings - indicates that almost no power savings measures will be used.
        /// </summary>
        public static readonly Guid GUID_MIN_POWER_SAVINGS = new Guid(WinNTConstants.GUID_MIN_POWER_SAVINGS);

        /// <summary>
        /// Typical Power Savings - indicates that fairly aggressive power savings measures will be used.
        /// </summary>
        public static readonly Guid GUID_TYPICAL_POWER_SAVINGS = new Guid(WinNTConstants.GUID_TYPICAL_POWER_SAVINGS);

        /// <summary>
        /// This is a special GUID that represents "no subgroup" of settings.  That is, it indicates
        /// that settings that are in the root of the power policy hierarchy as opposed to settings
        /// that are buried under a subgroup of settings.  This should be used when querying for
        /// power settings that may not fall into a subgroup.
        /// </summary>
        public static readonly Guid NO_SUBGROUP_GUID = new Guid(WinNTConstants.NO_SUBGROUP_GUID);

        /// <summary>
        /// This is a special GUID that represents "every power scheme".  That is, it indicates
        /// that any write to this power scheme should be reflected to every scheme present.
        /// This allows users to write a single setting once and have it apply to all schemes.  They
        /// can then apply custom settings to specific power schemes that they care about.
        /// </summary>
        public static readonly Guid ALL_POWERSCHEMES_GUID = new Guid(WinNTConstants.ALL_POWERSCHEMES_GUID);

        /// <summary>
        /// This is a special GUID that represents a 'personality' that each power scheme will have.
        /// In other words, each power scheme will have this key indicating "I'm most like *this* base
        /// power scheme."
        /// </summary>
        /// <value>
        /// This individual setting will have one of three settings:
        /// <list type="bullet">
        /// <item><see cref="GUID_MAX_POWER_SAVINGS"/></item>
        /// <item><see cref="GUID_MIN_POWER_SAVINGS"/></item>
        /// <item><see cref="GUID_TYPICAL_POWER_SAVINGS"/></item>
        /// </list>
        /// </value>
        /// <remarks>
        /// This allows several features:
        /// <list type="number">
        /// <item>
        ///    Drivers and applications can register for notification of this GUID.  So when this power
        ///    scheme is activiated, this GUID's setting will be sent across the system and drivers/applications
        ///    can see "GUID_MAX_POWER_SAVINGS" which will tell them in a generic fashion "get real aggressive
        ///    about conserving power".
        /// </item>
        /// <item>
        ///    UserB may install a driver or application which creates power settings, and UserB may modify
        ///    those power settings.  Now UserA logs in.  How does he see those settings?  They simply don't
        ///    exist in his private power key.  Well they do exist over in the system power key.  When we
        ///    enumerate all the power settings in this system power key and don't find a corresponding entry
        ///    in the user's private power key, then we can go look at this "personality" key in the users
        ///    power scheme.  We can then go get a default value for the power setting, depending on which
        ///    "personality" power scheme is being operated on.  Here's an example:
        ///    <list type="number">
        ///    <item>
        ///       UserB installs an application that creates a power setting Seetting1
        ///    </item>
        ///    <item>
        ///       UserB changes Setting1 to have a value of 50 because that's one of the possible settings
        ///       available for setting1.
        ///    </item>
        ///    <item>
        ///       UserB logs out
        ///    </item>
        ///    <item>
        ///       UserA logs in and his active power scheme is some custom scheme that was derived from
        ///       the <see cref="GUID_TYPICAL_POWER_SAVINGS"/>.  But remember that UserA has no setting1 in his
        ///       private power key.
        ///    </item>
        ///    <item>
        ///       When activating UserA's selected power scheme, all power settings in the system power key will
        ///       be enumerated (including Setting1).
        ///    </item>
        ///    <item>
        ///       The power manager will see that UserA has no Setting1 power setting in his private power scheme.
        ///    </item>
        ///    <item>
        ///       The power manager will query UserA's power scheme for its personality and retrieve
        ///       <see cref="GUID_TYPICAL_POWER_SAVINGS"/>.
        ///    </item>
        ///    <item>
        ///       The power manager then looks in Setting1 in the system power key and looks in its set of default
        ///       values for the corresponding value for <see cref="GUID_TYPICAL_POWER_SAVINGS"/> power schemes.
        ///    </item>
        ///    <item>
        ///       This derived power setting is applied.
        ///    </item>
        ///    </list>
        /// </item>
        /// </list>
        /// </remarks>
        public static readonly Guid GUID_POWERSCHEME_PERSONALITY = new Guid(WinNTConstants.GUID_POWERSCHEME_PERSONALITY);

        /// <summary>
        /// Define a special GUID which will be used to define the active power scheme.
        /// User will register for this power setting GUID, and when the active power
        /// scheme changes, they'll get a callback where the payload is the GUID
        /// representing the active powerscheme.
        /// </summary>
        public static readonly Guid GUID_ACTIVE_POWERSCHEME = new Guid(WinNTConstants.GUID_ACTIVE_POWERSCHEME);

        //
        // =========================================
        // Define GUIDs which represent well-known power settings
        // =========================================
        //

        // Idle resiliency settings
        // -------------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the idle resiliency
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_IDLE_RESILIENCY_SUBGROUP = new Guid(WinNTConstants.GUID_IDLE_RESILIENCY_SUBGROUP);

        /// <summary>
        /// Specifies the maximum clock interrupt period (in ms)
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_IDLE_RESILIENCY_PERIOD = new Guid(WinNTConstants.GUID_IDLE_RESILIENCY_PERIOD);

        /// <summary>
        /// Specifies the deep sleep policy setting.
        /// This is intended to override the <see cref="GUID_IDLE_RESILIENCY_PERIOD"/>
        /// </summary>
        public static readonly Guid GUID_DEEP_SLEEP_ENABLED = new Guid(WinNTConstants.GUID_DEEP_SLEEP_ENABLED);

        /// <summary>
        /// Specifies the platform idle state index associated with idle resiliency
        /// period.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_DEEP_SLEEP_PLATFORM_STATE = new Guid(WinNTConstants.GUID_DEEP_SLEEP_PLATFORM_STATE);

        /// <summary>
        /// Specifies (in milliseconds) how long we wait after the last disk access
        /// before we power off the disk in case when IO coalescing is active.
        /// </summary>
        public static readonly Guid GUID_DISK_COALESCING_POWERDOWN_TIMEOUT = new Guid(WinNTConstants.GUID_DISK_COALESCING_POWERDOWN_TIMEOUT);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the CS Enter before
        /// we deactivate execution required request.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>implies execution power requests are disabled and have no effect</description></item>
        /// <item><term>-1</term><description>implies execution power requests are never deactivated</description></item>
        /// </list>
        /// </para>
        /// <note>
        /// Execution required power requests are mapped into system required
        /// power requests on non-AoAc machines and this value has no effect.
        /// </note>
        /// </remarks>
        public static readonly Guid GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT = new Guid(WinNTConstants.GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT);


        // Video settings
        // --------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the video
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_VIDEO_SUBGROUP = new Guid(WinNTConstants.GUID_VIDEO_SUBGROUP);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last user input has been
        /// received before we power off the video.
        /// </summary>
        public static readonly Guid GUID_VIDEO_POWERDOWN_TIMEOUT = new Guid(WinNTConstants.GUID_VIDEO_POWERDOWN_TIMEOUT);

        /// <summary>
        /// Specifies whether adaptive display dimming is turned on or off.
        /// </summary>
        [Obsolete("This setting is DEPRECATED in Windows 8.1")]
        public static readonly Guid GUID_VIDEO_ANNOYANCE_TIMEOUT = new Guid(WinNTConstants.GUID_VIDEO_ANNOYANCE_TIMEOUT);

        /// <summary>
        /// Specifies how much adaptive dim time out will be increased by.
        /// </summary>
        [Obsolete("This setting is DEPRECATED in Windows 8.1")]
        public static readonly Guid GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE = new Guid(WinNTConstants.GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last user input has been
        /// received before we dim the video.
        /// </summary>
        public static readonly Guid GUID_VIDEO_DIM_TIMEOUT = new Guid(WinNTConstants.GUID_VIDEO_DIM_TIMEOUT);

        /// <summary>
        /// Specifies if the operating system should use adaptive timers (based on
        /// previous behavior) to power down the video.
        /// </summary>
        public static readonly Guid GUID_VIDEO_ADAPTIVE_POWERDOWN = new Guid(WinNTConstants.GUID_VIDEO_ADAPTIVE_POWERDOWN);

        /// <summary>
        /// Specifies if the monitor is currently being powered or not.
        /// </summary>
        public static readonly Guid GUID_MONITOR_POWER_ON = new Guid(WinNTConstants.GUID_MONITOR_POWER_ON);

        /// <summary>
        /// Monitor brightness policy when in normal state.
        /// </summary>
        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS = new Guid(WinNTConstants.GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS);

        /// <summary>
        /// Monitor brightness policy when in dim state.
        /// </summary>
        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS = new Guid(WinNTConstants.GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS);

        /// <summary>
        /// Current monitor brightness.
        /// </summary>
        public static readonly Guid GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS = new Guid(WinNTConstants.GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS);

        /// <summary>
        /// Specifies if the operating system should use ambient light sensor to change
        /// adaptively the display's brightness.
        /// </summary>
        public static readonly Guid GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS = new Guid(WinNTConstants.GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS);

        /// <summary>
        /// Specifies a change in the current monitor's display state.
        /// </summary>
        public static readonly Guid GUID_CONSOLE_DISPLAY_STATE = new Guid(WinNTConstants.GUID_CONSOLE_DISPLAY_STATE);

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to create display required
        /// power requests.
        /// </summary>
        public static readonly Guid GUID_ALLOW_DISPLAY_REQUIRED = new Guid(WinNTConstants.GUID_ALLOW_DISPLAY_REQUIRED);

        /// <summary>
        /// Specifies the video power down timeout (in seconds) after the interactive
        /// console is locked (and sensors indicate UserNotPresent). Value 0
        /// effectively disables this feature.
        /// </summary>
        public static readonly Guid GUID_VIDEO_CONSOLE_LOCK_TIMEOUT = new Guid(WinNTConstants.GUID_VIDEO_CONSOLE_LOCK_TIMEOUT);


        // Adaptive power behavior settings
        // --------------------------------

        public static readonly Guid GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP = new Guid(WinNTConstants.GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP);

        /// <summary>
        /// Specifies the input timeout (in seconds) to be used to indicate UserUnkown.
        /// Value 0 effectively disables this feature.
        /// </summary>
        public static readonly Guid GUID_NON_ADAPTIVE_INPUT_TIMEOUT = new Guid(WinNTConstants.GUID_NON_ADAPTIVE_INPUT_TIMEOUT);

        /// <summary>
        /// Specifies a change in the input controller(s) global system's state:
        /// e.g. enabled, suppressed, filtered.
        /// </summary>
        public static readonly Guid GUID_ADAPTIVE_INPUT_CONTROLLER_STATE = new Guid(WinNTConstants.GUID_ADAPTIVE_INPUT_CONTROLLER_STATE);

        // Harddisk settings
        // -----------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the harddisk
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_DISK_SUBGROUP = new Guid(WinNTConstants.GUID_DISK_SUBGROUP);

        /// <summary>
        /// Specifies a maximum power consumption level.
        /// </summary>
        public static readonly Guid GUID_DISK_MAX_POWER = new Guid(WinNTConstants.GUID_DISK_MAX_POWER);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the last disk access
        /// before we power off the disk.
        /// </summary>
        public static readonly Guid GUID_DISK_POWERDOWN_TIMEOUT = new Guid(WinNTConstants.GUID_DISK_POWERDOWN_TIMEOUT);

        /// <summary>
        /// Specifies (in milliseconds) how long we wait after the last disk access
        /// before we power off the disk taking into account if IO coalescing is active.
        /// </summary>
        public static readonly Guid GUID_DISK_IDLE_TIMEOUT = new Guid(WinNTConstants.GUID_DISK_IDLE_TIMEOUT);

        /// <summary>
        /// Specifies the amount of contiguous disk activity time to ignore when
        /// calculating disk idleness.
        /// </summary>
        public static readonly Guid GUID_DISK_BURST_IGNORE_THRESHOLD = new Guid(WinNTConstants.GUID_DISK_BURST_IGNORE_THRESHOLD);

        /// <summary>
        /// Specifies if the operating system should use adaptive timers (based on
        /// previous behavior) to power down the disk,
        /// </summary>
        public static readonly Guid GUID_DISK_ADAPTIVE_POWERDOWN = new Guid(WinNTConstants.GUID_DISK_ADAPTIVE_POWERDOWN);

        // System sleep settings
        // ---------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the sleep
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_SLEEP_SUBGROUP = new Guid(WinNTConstants.GUID_SLEEP_SUBGROUP);

        /// <summary>
        /// Specifies an idle treshold percentage (0-100). The system must be this idle
        /// over a period of time in order to idle to sleep.
        /// </summary>
        [Obsolete("DEPRECATED IN WINDOWS 6.1")]
        public static readonly Guid GUID_SLEEP_IDLE_THRESHOLD = new Guid(WinNTConstants.GUID_SLEEP_IDLE_THRESHOLD);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the system is deemed
        /// "idle" before moving to standby (S1, S2 or S3).
        /// </summary>
        public static readonly Guid GUID_STANDBY_TIMEOUT = new Guid(WinNTConstants.GUID_STANDBY_TIMEOUT);

        /// <summary>
        /// Specifies (in seconds) how long the system should go back to sleep after
        /// waking unattended. 0 indicates that the standard standby/hibernate idle
        /// policy should be used instead.
        /// </summary>
        public static readonly Guid GUID_UNATTEND_SLEEP_TIMEOUT = new Guid(WinNTConstants.GUID_UNATTEND_SLEEP_TIMEOUT);

        /// <summary>
        /// Specifies (in seconds) how long we wait after the system is deemed
        /// "idle" before moving to hibernate (S4).
        /// </summary>
        public static readonly Guid GUID_HIBERNATE_TIMEOUT = new Guid(WinNTConstants.GUID_HIBERNATE_TIMEOUT);

        /// <summary>
        /// Specifies whether or not Fast S4 should be enabled if the system supports it
        /// </summary>
        public static readonly Guid GUID_HIBERNATE_FASTS4_POLICY = new Guid(WinNTConstants.GUID_HIBERNATE_FASTS4_POLICY);

        /// <summary>
        /// Define a GUID for controlling the criticality of sleep state transitions.
        /// Critical sleep transitions do not query applications, services or drivers
        /// before transitioning the platform to a sleep state.
        /// </summary>
        public static readonly Guid GUID_CRITICAL_POWER_TRANSITION = new Guid(WinNTConstants.GUID_CRITICAL_POWER_TRANSITION);

        /// <summary>
        /// Specifies if the system is entering or exiting 'away mode'.
        /// </summary>
        public static readonly Guid GUID_SYSTEM_AWAYMODE = new Guid(WinNTConstants.GUID_SYSTEM_AWAYMODE);

        /// <summary>
        /// Specify whether away mode is allowed
        /// </summary>
        public static readonly Guid GUID_ALLOW_AWAYMODE = new Guid(WinNTConstants.GUID_ALLOW_AWAYMODE);

        /// <summary>
        /// Defines a guid to control User Presence Prediction mode.
        /// </summary>
        public static readonly Guid GUID_USER_PRESENCE_PREDICTION = new Guid(WinNTConstants.GUID_USER_PRESENCE_PREDICTION);

        /// <summary>
        /// Defines a guid to control Standby Budget Grace Period.
        /// </summary>
        public static readonly Guid GUID_STANDBY_BUDGET_GRACE_PERIOD = new Guid(WinNTConstants.GUID_STANDBY_BUDGET_GRACE_PERIOD);

        /// <summary>
        /// Defines a guid to control Standby Budget Percent.
        /// </summary>
        public static readonly Guid GUID_STANDBY_BUDGET_PERCENT = new Guid(WinNTConstants.GUID_STANDBY_BUDGET_PERCENT);

        /// <summary>
        /// Defines a guid to control Standby Reserve Grace Period.
        /// </summary>
        public static readonly Guid GUID_STANDBY_RESERVE_GRACE_PERIOD = new Guid(WinNTConstants.GUID_STANDBY_RESERVE_GRACE_PERIOD);

        /// <summary>
        /// Defines a guid to control Standby Reserve Time.
        /// </summary>
        public static readonly Guid GUID_STANDBY_RESERVE_TIME = new Guid(WinNTConstants.GUID_STANDBY_RESERVE_TIME);

        /// <summary>
        /// Defines a guid to control Standby Reset Percentage.
        /// </summary>
        public static readonly Guid GUID_STANDBY_RESET_PERCENT = new Guid(WinNTConstants.GUID_STANDBY_RESET_PERCENT);

        /// <summary>
        /// Defines a guid for enabling/disabling standby (S1-S3) states. This does not
        /// affect hibernation (S4).
        /// </summary>
        public static readonly Guid GUID_ALLOW_STANDBY_STATES = new Guid(WinNTConstants.GUID_ALLOW_STANDBY_STATES);

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to wake via RTC.
        /// </summary>
        public static readonly Guid GUID_ALLOW_RTC_WAKE = new Guid(WinNTConstants.GUID_ALLOW_RTC_WAKE);

        /// <summary>
        /// Defines a guid for enabling/disabling legacy RTC mitigations.
        /// </summary>
        public static readonly Guid GUID_LEGACY_RTC_MITIGATION = new Guid(WinNTConstants.GUID_LEGACY_RTC_MITIGATION);

        /// <summary>
        /// Defines a guid for enabling/disabling the ability to create system required
        /// power requests.
        /// </summary>
        public static readonly Guid GUID_ALLOW_SYSTEM_REQUIRED = new Guid(WinNTConstants.GUID_ALLOW_SYSTEM_REQUIRED);

        // Energy Saver settings
        // ---------------------

        /// <summary>
        /// Indicates if Enegry Saver is ON or OFF.
        /// </summary>
        public static readonly Guid GUID_POWER_SAVING_STATUS = new Guid(WinNTConstants.GUID_POWER_SAVING_STATUS);

        /// <summary>
        /// Specifies the subgroup which will contain all of the Energy Saver settings
        /// for a single policy.
        /// </summary>
        public static readonly Guid GUID_ENERGY_SAVER_SUBGROUP = new Guid(WinNTConstants.GUID_ENERGY_SAVER_SUBGROUP);

        /// <summary>
        /// Defines a guid to engage Energy Saver at specific battery charge level
        /// </summary>
        public static readonly Guid GUID_ENERGY_SAVER_BATTERY_THRESHOLD = new Guid(WinNTConstants.GUID_ENERGY_SAVER_BATTERY_THRESHOLD);

        /// <summary>
        /// Defines a guid to specify display brightness weight when Energy Saver is engaged
        /// </summary>
        public static readonly Guid GUID_ENERGY_SAVER_BRIGHTNESS = new Guid(WinNTConstants.GUID_ENERGY_SAVER_BRIGHTNESS);

        /// <summary>
        /// Defines a guid to specify the Energy Saver policy
        /// </summary>
        public static readonly Guid GUID_ENERGY_SAVER_POLICY = new Guid(WinNTConstants.GUID_ENERGY_SAVER_POLICY);

        // System button actions
        // ---------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the system button
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_SYSTEM_BUTTON_SUBGROUP = new Guid(WinNTConstants.GUID_SYSTEM_BUTTON_SUBGROUP);

        /// <summary>
        /// Specifies (in a <see cref="POWER_ACTION_POLICY"/> structure) the appropriate action to
        /// take when the system power button is pressed.
        /// </summary>
        public static readonly Guid GUID_POWERBUTTON_ACTION = new Guid(WinNTConstants.GUID_POWERBUTTON_ACTION);

        /// <summary>
        /// Specifies (in a <see cref="POWER_ACTION_POLICY"/> structure) the appropriate action to
        /// take when the system sleep button is pressed.
        /// </summary>
        public static readonly Guid GUID_SLEEPBUTTON_ACTION = new Guid(WinNTConstants.GUID_SLEEPBUTTON_ACTION);

        /// <summary>
        /// Specifies (in a <see cref="POWER_ACTION_POLICY"/> structure) the appropriate action to
        /// take when the system sleep button is pressed.
        /// </summary>
        public static readonly Guid GUID_USERINTERFACEBUTTON_ACTION = new Guid(WinNTConstants.GUID_USERINTERFACEBUTTON_ACTION);

        /// <summary>
        /// Specifies (in a <see cref="POWER_ACTION_POLICY"/> structure) the appropriate action to
        /// take when the system lid is closed.
        /// </summary>
        public static readonly Guid GUID_LIDCLOSE_ACTION = new Guid(WinNTConstants.GUID_LIDCLOSE_ACTION);
        public static readonly Guid GUID_LIDOPEN_POWERSTATE = new Guid(WinNTConstants.GUID_LIDOPEN_POWERSTATE);


        // Battery Discharge Settings
        // --------------------------

        /// <summary>
        /// Specifies the subgroup which will contain all of the battery discharge
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_BATTERY_SUBGROUP = new Guid(WinNTConstants.GUID_BATTERY_SUBGROUP);

        //
        // 4 battery discharge alarm settings.
        //
        // GUID_BATTERY_DISCHARGE_ACTION_x - This is the action to take.  It is a value
        //                                   of type POWER_ACTION
        // GUID_BATTERY_DISCHARGE_LEVEL_x  - This is the battery level (%)
        // GUID_BATTERY_DISCHARGE_FLAGS_x  - Flags defined below:
        //                                   POWER_ACTION_POLICY->EventCode flags
        //                                   BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK
        //                                   BATTERY_DISCHARGE_FLAGS_ENABLE

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_0 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_ACTION_0);
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_0 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_LEVEL_0);
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_0 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_FLAGS_0);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_1 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_ACTION_1);
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_1 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_LEVEL_1);
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_1 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_FLAGS_1);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_2 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_ACTION_2);
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_2 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_LEVEL_2);
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_2 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_FLAGS_2);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_3 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_ACTION_3);
        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_3 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_LEVEL_3);
        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_3 = new Guid(WinNTConstants.GUID_BATTERY_DISCHARGE_FLAGS_3);

        // Processor power settings
        // ------------------------
        //

        /// <summary>
        /// Specifies the subgroup which will contain all of the processor
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_SETTINGS_SUBGROUP = new Guid(WinNTConstants.GUID_PROCESSOR_SETTINGS_SUBGROUP);

        /// <summary>
        /// Specifies various attributes that control processor performance/throttle
        /// states.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THROTTLE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_THROTTLE_POLICY);

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should never go above.  For example, if this value is set to 80, then
        /// the processor frequency will never be throttled above 80 percent of its
        /// maximum frequency by the system.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM = new Guid(WinNTConstants.GUID_PROCESSOR_THROTTLE_MAXIMUM);

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should never go above for Processor Power Efficiency Class 1.
        /// For example, if this value is set to 80, then the processor frequency will
        /// never be throttled above 80 percent of its maximum frequency by the system.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM_1 = new Guid(WinNTConstants.GUID_PROCESSOR_THROTTLE_MAXIMUM_1);

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should not drop below.  For example, if this value is set to 50, then the
        /// processor frequency will never be throttled below 50 percent of its
        /// maximum frequency by the system.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM = new Guid(WinNTConstants.GUID_PROCESSOR_THROTTLE_MINIMUM);

        /// <summary>
        /// Specifies a percentage (between 0 and 100) that the processor frequency
        /// should not drop below for Processor Power Efficiency Class 1.
        /// For example, if this value is set to 50, then the processor frequency will
        /// never be throttled below 50 percent of its maximum frequency by the system.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM_1 = new Guid(WinNTConstants.GUID_PROCESSOR_THROTTLE_MINIMUM_1);

        /// <summary>
        /// Specifies the maximum processor frequency (expresssed in MHz).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT = new Guid(WinNTConstants.GUID_PROCESSOR_FREQUENCY_LIMIT);

        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT_1 = new Guid(WinNTConstants.GUID_PROCESSOR_FREQUENCY_LIMIT_1);

        /// <summary>
        /// Specifies whether throttle states are allowed to be used even when
        /// performance states are available.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_ALLOW_THROTTLING = new Guid(WinNTConstants.GUID_PROCESSOR_ALLOW_THROTTLING);

        /// <summary>
        /// Specifies processor power settings for CState policy data
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLESTATE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_IDLESTATE_POLICY);

        /// <summary>
        /// Specifies processor power settings for PerfState policy data
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERFSTATE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_PERFSTATE_POLICY);

        /// <summary>
        /// Specifies the increase busy percentage threshold that must be met before
        /// increasing the processor performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_THRESHOLD);

        /// <summary>
        /// Specifies the increase busy percentage threshold that must be met before
        /// increasing the processor performance state for Processor Power Efficiency
        /// Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1);

        /// <summary>
        /// Specifies the decrease busy percentage threshold that must be met before
        /// decreasing the processor performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_THRESHOLD);

        /// <summary>
        /// Specifies the decrease busy percentage threshold that must be met before
        /// decreasing the processor performance state for Processor Power Efficiency
        /// Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when increasing the processor performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_POLICY);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when increasing the processor performance state
        /// for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_POLICY_1);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when decreasing the processor performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_POLICY);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive performance
        /// states should be selected when decreasing the processor performance state for
        /// Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_POLICY_1);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_TIME);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_TIME_1);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_TIME);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time that must elapse after
        /// the last processor performance state change before increasing the processor
        /// performance state for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_TIME_1);

        /// <summary>
        /// Specifies the time, in milliseconds, that must expire before considering
        /// a change in the processor performance states or parked core set.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_TIME_CHECK = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_TIME_CHECK);

        /// <summary>
        /// Specifies how the processor should manage performance and efficiency
        /// tradeoffs when boosting frequency above the maximum.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_BOOST_POLICY);

        /// <summary>
        /// Specifies how a processor opportunistically increases frequency above
        /// the maximum when operating contitions allow it to do so safely.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_MODE = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_BOOST_MODE);

        /// <summary>
        /// Specifies whether or not a procesor should autonomously select its
        /// operating performance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_MODE = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_AUTONOMOUS_MODE);

        /// <summary>
        /// Specifies the tradeoff between performance and energy the processor should
        /// make when operating in autonomous mode.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE);

        /// <summary>
        /// Specifies the window over which the processor should observe utilization when
        /// operating in autonomous mode, in microseconds.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW);

        /// <summary>
        /// Specifies whether the processor should perform duty cycling.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_DUTY_CYCLING = new Guid(WinNTConstants.GUID_PROCESSOR_DUTY_CYCLING);

        /// <summary>
        /// Specifies if idle state promotion and demotion values should be scaled based
        /// on the current peformance state.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_ALLOW_SCALING = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_ALLOW_SCALING);

        /// <summary>
        /// Specifies if idle states should be disabled.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_DISABLE = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_DISABLE);

        /// <summary>
        /// Specifies the deepest idle state type that should be used. If this value is
        /// set to zero, this setting is ignored. Values higher than supported by the
        /// processor then this setting has no effect.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_STATE_MAXIMUM = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_STATE_MAXIMUM);

        /// <summary>
        /// Specifies the time that elapsed since the last idle state promotion or
        /// demotion before idle states may be promoted or demoted again (in
        /// microseconds).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_TIME_CHECK = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_TIME_CHECK);


        /// <summary>
        /// Specifies the upper busy threshold that must be met before demoting the
        /// processor to a lighter idle state (in percentage).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD);

        /// <summary>
        /// Specifies the lower busy threshold that must be met before promoting the
        /// processor to a deeper idle state (in percentage).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD);

        /// <summary>
        /// Specifies the utilization threshold in percent that must be crossed in order to un-park cores.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD);

        /// <summary>
        /// Specifies the utilization threshold in percent that must be crossed in order to park cores.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive core parking is when cores must be unparked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY);

        /// <summary>
        /// Specifies, either as ideal, single or rocket, how aggressive core parking is when cores must be parked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY);

        /// <summary>
        /// Specifies, on a per processor group basis, the maximum number of cores that can be kept unparked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_MAX_CORES);

        /// <summary>
        /// Specifies, on a per processor group basis, the maximum number of cores that
        /// can be kept unparked for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1 = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1);

        /// <summary>
        /// Specifies, on a per processor group basis, the minimum number of cores that must be kept unparked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_MIN_CORES);

        /// <summary>
        /// Specifies, on a per processor group basis, the minimum number of cores that
        /// must be kept unparked in Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1 = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time a core must be parked before it can be unparked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME);

        /// <summary>
        /// Specifies, in milliseconds, the minimum amount of time a core must be unparked before it can be parked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME);

        /// <summary>
        /// Specifies the factor by which to decrease affinity history on each core after each check.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR);

        /// <summary>
        /// Specifies the threshold above which a core is considered to have had significant affinitized work scheduled to it while parked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD);

        /// <summary>
        /// Specifies the weighting given to each occurence where affinitized work was scheduled to a parked core.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING);

        /// <summary>
        /// Specifies the factor by which to decrease the over utilization history on each core after the current performance check.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR);

        /// <summary>
        /// Specifies the threshold above which a core is considered to have been recently over utilized while parked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD);

        /// <summary>
        /// Specifies the weighting given to each occurence where a parked core is found to be over utilized.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING);

        /// <summary>
        /// Specifies, in percentage, the busy threshold that must be met before a parked core is considered over utilized.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD);

        /// <summary>
        /// Specifies if at least one processor per core should always remain unparked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_CORE_OVERRIDE = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_CORE_OVERRIDE);

        /// <summary>
        /// Specifies what performance state a processor should enter when first parked.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_PERF_STATE);

        /// <summary>
        /// Specifies what performance state a processor should enter when first parked
        /// for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_PERF_STATE_1);

        /// <summary>
        /// Specify the busy threshold that must be met when calculating the concurrency of a node's workload.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD);

        /// <summary>
        /// Specify the busy threshold that must be met by all cores in a concurrency set to unpark an extra core.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD);

        /// <summary>
        /// Specify the percentage utilization used to calculate the distribution concurrency.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD);

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_HISTORY);

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over in
        /// Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_HISTORY_1);

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over to
        /// determine performance increase.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_HISTORY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_INCREASE_HISTORY);

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over to
        /// determine performance decrease.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_HISTORY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_DECREASE_HISTORY);

        /// <summary>
        /// Specifies the number of perf time check intervals to average utility over for
        /// core parking.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY);

        /// <summary>
        /// Specifies whether latency sensitivity hints should be taken into account by
        /// the perf state engine.
        /// </summary>
        [Obsolete("This power setting is DEPRECATED.")]
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_LATENCY_HINT);

        /// <summary>
        /// Specifies the processor performance state in response to latency sensitivity hints.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_LATENCY_HINT_PERF);

        /// <summary>
        /// Specifies the processor performance state in response to latency sensitivity
        /// hints for Processor Power Efficiency Class 1.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1 = new Guid(WinNTConstants.GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1);

        /// <summary>
        /// Specifies the minimum unparked processors when a latency hint is active
        /// (in a percentage).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK = new Guid(WinNTConstants.GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK);

        /// <summary>
        /// Specifies the minimum unparked processors when a latency hint is active
        /// for Processor Power Efficiency Class 1 (in a percentage).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1 = new Guid(WinNTConstants.GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1);

        /// <summary>
        /// Specifies whether the core parking engine should distribute processor
        /// utility.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_DISTRIBUTE_UTILITY = new Guid(WinNTConstants.GUID_PROCESSOR_DISTRIBUTE_UTILITY);

        //
        // GUIDS to control PPM settings on computer system with more than one
        // Processor Power Efficiency Classes (heterogeneous system).
        // -----------------

        /// <summary>
        /// Specifies the current active heterogeneous policy.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_HETEROGENEOUS_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_HETEROGENEOUS_POLICY);

        /// <summary>
        /// Specifies the number of perf check cycles required to decrease the number of
        /// Processor Power Efficiency Class 1 processors.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_HETERO_DECREASE_TIME);

        /// <summary>
        /// Specifies the number of perf check cycles required to increase the number of
        /// Processor Power Efficiency Class 1 processors.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_TIME = new Guid(WinNTConstants.GUID_PROCESSOR_HETERO_INCREASE_TIME);

        /// <summary>
        /// Specifies the performance level (in units of Processor Power Efficiency
        /// Class 0 processor performance) at which the number of Processor Power
        /// Efficiency Class 1 processors is decreased.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD);

        /// <summary>
        /// Specifies the performance level (in units of Processor Power Efficiency
        /// Class 0 processor performance) at which the number of Processor Power
        /// Efficiency Class 1 processors is increased.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD = new Guid(WinNTConstants.GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD);

        /// <summary>
        /// Specifies the performance target floor of a Processor Power Efficiency
        /// Class 0 processor when the system unparks Processor Power Efficiency Class 1
        /// processor(s).
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CLASS0_FLOOR_PERF = new Guid(WinNTConstants.GUID_PROCESSOR_CLASS0_FLOOR_PERF);

        /// <summary>
        /// Specifies the initial performance target of a Processor Power Efficiency
        /// Class 1 processor when the system makes a transition up from zero Processor
        /// Power Efficiency Class 1 processors.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_CLASS1_INITIAL_PERF = new Guid(WinNTConstants.GUID_PROCESSOR_CLASS1_INITIAL_PERF);

        /// <summary>
        /// Specifies the scheduling policy for threads in a given QoS class.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_THREAD_SCHEDULING_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_THREAD_SCHEDULING_POLICY);

        /// <summary>
        /// Specifies the scheduling policy for short running threads in a given QoS
        /// class.
        /// </summary>
        public static readonly Guid GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY = new Guid(WinNTConstants.GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY);

        /// <summary>
        /// Specifies active vs passive cooling.  Although not directly related to
        /// processor settings, it is the processor that gets throttled if we're doing
        /// passive cooling, so it is fairly strongly related.
        /// </summary>
        public static readonly Guid GUID_SYSTEM_COOLING_POLICY = new Guid(WinNTConstants.GUID_SYSTEM_COOLING_POLICY);

        // Lock Console on Wake
        // --------------------
        //

        /// <summary>
        /// Specifies the behavior of the system when we wake from standby or
        /// hibernate.  If this is set, then we will cause the console to lock
        /// after we resume.
        /// </summary>
        public static readonly Guid GUID_LOCK_CONSOLE_ON_WAKE = new Guid(WinNTConstants.GUID_LOCK_CONSOLE_ON_WAKE);

        // Device idle characteristics
        // ---------------------------

        /// <summary>
        /// Specifies whether to use the "performance" or "conservative" timeouts for
        /// device idle management.
        /// </summary>
        public static readonly Guid GUID_DEVICE_IDLE_POLICY = new Guid(WinNTConstants.GUID_DEVICE_IDLE_POLICY);

        /// <summary>
        /// Specifies standby connectivity preference.
        /// </summary>
        public static readonly Guid GUID_CONNECTIVITY_IN_STANDBY = new Guid(WinNTConstants.GUID_CONNECTIVITY_IN_STANDBY);

        /// <summary>
        /// Specifies the mode for disconnected standby.
        /// </summary>
        public static readonly Guid GUID_DISCONNECTED_STANDBY_MODE = new Guid(WinNTConstants.GUID_DISCONNECTED_STANDBY_MODE);

        // AC/DC power source
        // ------------------
        //

        /// <summary>
        /// Specifies the power source for the system.
        /// </summary>
        /// <remarks>
        /// Consumers may register for
        /// notification when the power source changes and will be notified with
        /// one of 3 values:
        /// 0 - Indicates the system is being powered by an AC power source.
        /// 1 - Indicates the system is being powered by a DC power source.
        /// 2 - Indicates the system is being powered by a short-term DC power
        ///     source.  For example, this would be the case if the system is
        ///     being powed by a short-term battery supply in a backing UPS
        ///     system.  When this value is recieved, the consumer should make
        ///     preparations for either a system hibernate or system shutdown.
        /// </remarks>
        public static readonly Guid GUID_ACDC_POWER_SOURCE = new Guid(WinNTConstants.GUID_ACDC_POWER_SOURCE);

        // Lid state changes
        // -----------------

        /// <summary>
        /// Specifies the current state of the lid (open or closed). The callback won't
        /// be called at all until a lid device is found and its current state is known.
        /// </summary>
        /// <remarks>
        /// Values:
        /// 0 - closed
        /// 1 - opened
        /// </remarks>
        public static readonly Guid GUID_LIDSWITCH_STATE_CHANGE = new Guid(WinNTConstants.GUID_LIDSWITCH_STATE_CHANGE);

        // Battery status changes
        // ----------------------
        //

        /// <summary>
        /// <para>
        /// Specifies the percentage of battery life remaining.  The consumer
        /// may register for notification in order to track battery life in
        /// a fine-grained manner.
        /// </para>
        /// <para>
        /// Once registered, the consumer can expect to be notified as the battery
        /// life percentage changes.
        /// </para>
        /// <para>
        /// The consumer will recieve a value between 0 and 100 (inclusive) which
        /// indicates percent battery life remaining.
        /// </para>
        /// </summary>
        public static readonly Guid GUID_BATTERY_PERCENTAGE_REMAINING = new Guid(WinNTConstants.GUID_BATTERY_PERCENTAGE_REMAINING);

        /// <summary>
        /// <para>
        /// Specifies change in number of batteries present on the system. The consumer
        /// may register for notification in order to track change in number of batteries
        /// available on a system.
        /// </para>
        /// <para>
        /// Once registered, the consumer can expect to be notified whenever the
        /// batteries are added or removed from the system.
        /// </para>
        /// <para>
        /// The consumer will recieve a value indicating number of batteries currently
        /// present on the system.
        /// </para>
        /// </summary>
        public static readonly Guid GUID_BATTERY_COUNT = new Guid(WinNTConstants.GUID_BATTERY_COUNT);

        /// <summary>
        /// Global notification indicating to listeners user activity/presence accross
        /// all sessions in the system (Present, NotPresent, Inactive)
        /// </summary>
        public static readonly Guid GUID_GLOBAL_USER_PRESENCE = new Guid(WinNTConstants.GUID_GLOBAL_USER_PRESENCE);

        /// <summary>
        /// Session specific notification indicating to listeners whether or not the display
        /// related to the given session is on/off/dim
        /// </summary>
        /// <remarks>
        /// This is a session-specific notification, sent only to interactive
        /// session registrants. Session 0 and kernel mode consumers do not receive
        /// this notification.
        /// </remarks>
        public static readonly Guid GUID_SESSION_DISPLAY_STATUS = new Guid(WinNTConstants.GUID_SESSION_DISPLAY_STATUS);

        /// <summary>
        /// Session specific notification indicating to listeners user activity/presence
        /// (Present, NotPresent, Inactive)
        /// </summary>
        /// <remarks>
        /// <note>
        ///      This is a session-specific notification, sent only to interactive
        ///      session registrants. Session 0 and kernel mode consumers do not receive
        ///      this notification.
        /// </note>
        /// </remarks>
        public static readonly Guid GUID_SESSION_USER_PRESENCE = new Guid(WinNTConstants.GUID_SESSION_USER_PRESENCE);


        /// <summary>
        /// Notification to listeners that the system is fairly busy and won't be moving
        /// into an idle state any time soon.  This can be used as a hint to listeners
        /// that now might be a good time to do background tasks.
        /// </summary>
        public static readonly Guid GUID_IDLE_BACKGROUND_TASK = new Guid(WinNTConstants.GUID_IDLE_BACKGROUND_TASK);

        /// <summary>
        /// Notification to listeners that the system is fairly busy and won't be moving
        /// into an idle state any time soon.  This can be used as a hint to listeners
        /// that now might be a good time to do background tasks.
        /// </summary>
        public static readonly Guid GUID_BACKGROUND_TASK_NOTIFICATION = new Guid(WinNTConstants.GUID_BACKGROUND_TASK_NOTIFICATION);

        /// <summary>
        /// Define a GUID that will represent the action of a direct experience button
        /// on the platform.  Users will register for this DPPE setting and recieve
        /// notification when the h/w button is pressed.
        /// </summary>
        public static readonly Guid GUID_APPLAUNCH_BUTTON = new Guid(WinNTConstants.GUID_APPLAUNCH_BUTTON);

        // PCI Express power settings
        // ------------------------
        //

        /// <summary>
        /// Specifies the subgroup which will contain all of the PCI Express
        /// settings for a single policy.
        /// </summary>
        public static readonly Guid GUID_PCIEXPRESS_SETTINGS_SUBGROUP = new Guid(WinNTConstants.GUID_PCIEXPRESS_SETTINGS_SUBGROUP);

        /// <summary>
        /// Specifies the PCI Express ASPM power policy.
        /// </summary>
        public static readonly Guid GUID_PCIEXPRESS_ASPM_POLICY = new Guid(WinNTConstants.GUID_PCIEXPRESS_ASPM_POLICY);

        // POWER Shutdown settings
        // ------------------------
        //

        /// <summary>
        /// Specifies if forced shutdown should be used for all button and lid initiated
        /// shutdown actions.
        /// </summary>
        public static readonly Guid GUID_ENABLE_SWITCH_FORCED_SHUTDOWN = new Guid(WinNTConstants.GUID_ENABLE_SWITCH_FORCED_SHUTDOWN);

        // Interrupt Steering power settings
        // ------------------------
        //

        public static readonly Guid GUID_INTSTEER_SUBGROUP = new Guid(WinNTConstants.GUID_INTSTEER_SUBGROUP);

        public static readonly Guid GUID_INTSTEER_MODE = new Guid(WinNTConstants.GUID_INTSTEER_MODE);

        public static readonly Guid GUID_INTSTEER_LOAD_PER_PROC_TRIGGER = new Guid(WinNTConstants.GUID_INTSTEER_LOAD_PER_PROC_TRIGGER);

        public static readonly Guid GUID_INTSTEER_TIME_UNPARK_TRIGGER = new Guid(WinNTConstants.GUID_INTSTEER_TIME_UNPARK_TRIGGER);

        // Graphics power settings
        // ------------------------
        //

        /// <summary>
        /// Specified the subgroup which contains all inbox graphics settings.
        /// </summary>
        public static readonly Guid GUID_GRAPHICS_SUBGROUP = new Guid(WinNTConstants.GUID_GRAPHICS_SUBGROUP);

        /// <summary>
        /// Specifies the GPU preference policy.
        /// </summary>
        public static readonly Guid GUID_GPU_PREFERENCE_POLICY = new Guid(WinNTConstants.GUID_GPU_PREFERENCE_POLICY);

        // Other miscellaneous power notification GUIDs
        // ------------------------
        //

        /// <summary>
        /// Specifies whether mixed reality mode is engaged.
        /// </summary>
        public static readonly Guid GUID_MIXED_REALITY_MODE = new Guid(WinNTConstants.GUID_MIXED_REALITY_MODE);

        /// <summary>
        /// Specifies a change (start/end) in System Power Report's Active Session.
        /// </summary>
        public static readonly Guid GUID_SPR_ACTIVE_SESSION_CHANGE = new Guid(WinNTConstants.GUID_SPR_ACTIVE_SESSION_CHANGE);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15542
        public const POWER_PLATFORM_ROLE POWER_PLATFORM_ROLE_V1_MAX = (POWER_PLATFORM_ROLE)(POWER_PLATFORM_ROLE.PlatformRolePerformanceServer + 1);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15545
        public const POWER_PLATFORM_ROLE POWER_PLATFORM_ROLE_V2_MAX = (POWER_PLATFORM_ROLE)(POWER_PLATFORM_ROLE.PlatformRoleSlate + 1);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15549
        public const int POWER_PLATFORM_ROLE_VERSION = POWER_PLATFORM_ROLE_V2;
        public const POWER_PLATFORM_ROLE POWER_PLATFORM_ROLE_VERSION_MAX = POWER_PLATFORM_ROLE_V2_MAX;

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15790
        //
        // Processor Power Management WMI interface.
        //

        public static readonly Guid PPM_PERFSTATE_CHANGE_GUID = new Guid(WinNTConstants.PPM_PERFSTATE_CHANGE_GUID);

        public static readonly Guid PPM_PERFSTATE_DOMAIN_CHANGE_GUID = new Guid(WinNTConstants.PPM_PERFSTATE_DOMAIN_CHANGE_GUID);

        public static readonly Guid PPM_IDLESTATE_CHANGE_GUID = new Guid(WinNTConstants.PPM_IDLESTATE_CHANGE_GUID);

        public static readonly Guid PPM_PERFSTATES_DATA_GUID = new Guid(WinNTConstants.PPM_PERFSTATES_DATA_GUID);

        public static readonly Guid PPM_IDLESTATES_DATA_GUID = new Guid(WinNTConstants.PPM_IDLESTATES_DATA_GUID);

        public static readonly Guid PPM_IDLE_ACCOUNTING_GUID = new Guid(WinNTConstants.PPM_IDLE_ACCOUNTING_GUID);

        public static readonly Guid PPM_IDLE_ACCOUNTING_EX_GUID = new Guid(WinNTConstants.PPM_IDLE_ACCOUNTING_EX_GUID);

        public static readonly Guid PPM_THERMALCONSTRAINT_GUID = new Guid(WinNTConstants.PPM_THERMALCONSTRAINT_GUID);

        public static readonly Guid PPM_PERFMON_PERFSTATE_GUID = new Guid(WinNTConstants.PPM_PERFMON_PERFSTATE_GUID);

        public static readonly Guid PPM_THERMAL_POLICY_CHANGE_GUID = new Guid(WinNTConstants.PPM_THERMAL_POLICY_CHANGE_GUID);
    }
}
