using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    public static class WinNTRuntimeConstants
    {
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

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9011
        public static readonly int SECURITY_MAX_SID_SIZE =
            SizeOf<SID>.Bytes - SizeOf<int>.Bytes + (SID_MAX_SUB_AUTHORITIES * SizeOf<int>.Bytes);

        public static int SECURITY_SID_SIZE(byte SubAuthorityCount) =>
            SizeOf<SID>.Bytes - SizeOf<int>.Bytes + (SubAuthorityCount * SizeOf<int>.Bytes);

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9600
        //
        // Allocate the System Luid.  The first 1000 LUIDs are reserved.
        // Use #999 here (0x3e7 = 999)
        //

        public static ref readonly LUID SYSTEM_LUID => ref MemoryMarshal.Cast<int, LUID>(WinNTConstants.SYSTEM_LUID.Span)[0];
        public static ref readonly LUID ANONYMOUS_LOGON_LUID => ref MemoryMarshal.Cast<int, LUID>(WinNTConstants.ANONYMOUS_LOGON_LUID.Span)[0];
        public static ref readonly LUID LOCALSERVICE_LUID => ref MemoryMarshal.Cast<int, LUID>(WinNTConstants.LOCALSERVICE_LUID.Span)[0];
        public static ref readonly LUID NETWORKSERVICE_LUID => ref MemoryMarshal.Cast<int, LUID>(WinNTConstants.NETWORKSERVICE_LUID.Span)[0];
        public static ref readonly LUID IUSER_LUID => ref MemoryMarshal.Cast<int, LUID>(WinNTConstants.IUSER_LUID.Span)[0];

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

        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_NULL_SID_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_NULL_SID_AUTHORITY.Span)[0];
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_WORLD_SID_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_WORLD_SID_AUTHORITY.Span)[0];
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_LOCAL_SID_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_LOCAL_SID_AUTHORITY.Span)[0];
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_CREATOR_SID_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_CREATOR_SID_AUTHORITY.Span)[0];
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_NON_UNIQUE_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_NON_UNIQUE_AUTHORITY.Span)[0];
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_RESOURCE_MANAGER_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_RESOURCE_MANAGER_AUTHORITY.Span)[0];

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

        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_NT_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_NT_AUTHORITY.Span)[0];

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9361
        /// <summary>
        /// Application Package Authority.
        /// </summary>
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_APP_PACKAGE_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_APP_PACKAGE_AUTHORITY.Span)[0];

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9403
        /// <summary>
        /// Mandatory Label Authority.
        /// </summary>
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_MANDATORY_LABEL_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_MANDATORY_LABEL_AUTHORITY.Span)[0];

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9425
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_SCOPED_POLICY_ID_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_SCOPED_POLICY_ID_AUTHORITY.Span)[0];

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9427
        /// <summary>
        /// Authentication Authority
        /// </summary>
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_AUTHENTICATION_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_AUTHENTICATION_AUTHORITY.Span)[0];

        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9440
        /// <summary>
        /// Process Trust Authority
        /// </summary>
        public static ref readonly SID_IDENTIFIER_AUTHORITY SECURITY_PROCESS_TRUST_AUTHORITY => ref MemoryMarshal.Cast<byte, SID_IDENTIFIER_AUTHORITY>(WinNTConstants.SECURITY_PROCESS_TRUST_AUTHORITY.Span)[0];

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
    }
}
