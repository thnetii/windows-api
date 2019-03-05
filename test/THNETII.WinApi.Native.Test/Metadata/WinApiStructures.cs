using System;
using System.Collections.Generic;
using System.Linq;
using THNETII.WinApi.Native.MinWinBase;
using THNETII.WinApi.Native.MinWinDef;
using THNETII.WinApi.Native.WinBase;
using THNETII.WinApi.Native.WinNT;
using THNETII.WinApi.Native.WinUser;

namespace THNETII.WinApi.Native.Metadata
{
    public static class WinApiStructures
    {
        public static readonly IEnumerable<Type> Types = new[]
        {
            // MinWinBase
            typeof(LMEM_STATUS),
            // MinWinDef
            typeof(HLOCAL),
            // WinBase
            typeof(FORMAT_MESSAGE_OPTIONS),
            // WinNT
            typeof(ACCESS_MASK),
            typeof(ACCESS_REASON),
            typeof(ACCESS_REASONS),
            typeof(ACL_REVISION_INFORMATION),
            typeof(ACL_SIZE_INFORMATION),
            typeof(CONTEXT),
            typeof(EXCEPTION_POINTERS),
            typeof(EXCEPTION_RECORD),
            typeof(FLOATING_SAVE_AREA),
            typeof(GENERIC_MAPPING),
            typeof(GROUP_AFFINITY),
            typeof(LDT_ENTRY), typeof(LDT_ENTRY_HIGHWORD),
            typeof(LIST_ENTRY),
            typeof(LUID),
            typeof(LUID_AND_ATTRIBUTES),
            typeof(M128A),
            typeof(OBJECT_TYPE_LIST),
            typeof(PRIVILEGE_SET),
            typeof(OBJECTID),
            typeof(PROCESSOR_NUMBER),
            typeof(SCOPE_RECORD),
            typeof(SCOPE_TABLE),
            typeof(SE_ACCESS_REPLY),
            typeof(SE_ACCESS_REQUEST),
            typeof(SE_SECURITY_DESCRIPTOR),
            typeof(SE_SID),
            typeof(SE_TOKEN_USER),
            typeof(SID_AND_ATTRIBUTES),
            typeof(SID_AND_ATTRIBUTES_HASH),
            typeof(SID_IDENTIFIER_AUTHORITY),
            typeof(SINGLE_LIST_ENTRY),
            typeof(TOKEN_ACCESS_INFORMATION),
            typeof(TOKEN_APPCONTAINER_INFORMATION),
            typeof(TOKEN_AUDIT_POLICY),
            typeof(TOKEN_CONTROL),
            typeof(TOKEN_DEFAULT_DACL),
            typeof(TOKEN_DEVICE_CLAIMS),
            typeof(TOKEN_ELEVATION),
            typeof(TOKEN_GROUPS),
            typeof(TOKEN_GROUPS_AND_PRIVILEGES),
            typeof(TOKEN_LINKED_TOKEN),
            typeof(TOKEN_MANDATORY_LABEL),
            typeof(TOKEN_MANDATORY_POLICY),
            typeof(TOKEN_ORIGIN),
            typeof(TOKEN_OWNER),
            typeof(TOKEN_PRIMARY_GROUP),
            typeof(TOKEN_PRIVILEGES),
            typeof(TOKEN_SID_INFORMATION),
            typeof(TOKEN_SOURCE),
            typeof(TOKEN_STATISTICS),
            typeof(TOKEN_USER),
            typeof(TOKEN_USER_CLAIMS),
            typeof(XSAVE_AREA),
            typeof(XSAVE_AREA_HEADER),
            typeof(XSAVE_FORMAT), typeof(XSAVE_FORMAT_WIN64),
            typeof(XSTATE_CONTEXT), typeof(XSTATE_CONTEXT_X86),
            // WinUser
            typeof(FLASHWINFO),
            // Error Codes
            typeof(HRESULT),
            typeof(NTSTATUS),
            typeof(Win32ErrorCode),
        };

        public static readonly IEnumerable<object[]> TypesMemberData =
            Types.Select(t => new object[] { t });
    }
}
