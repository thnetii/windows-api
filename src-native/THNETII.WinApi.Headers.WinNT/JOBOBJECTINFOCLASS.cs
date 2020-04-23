using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12005
    public enum JOBOBJECTINFOCLASS
    {
        JobObjectBasicAccountingInformation = 1,
        JobObjectBasicLimitInformation,
        JobObjectBasicProcessIdList,
        JobObjectBasicUIRestrictions,
#pragma warning disable CA1041 // Provide ObsoleteAttribute message
        [Obsolete]
        JobObjectSecurityLimitInformation,
#pragma warning restore CA1041 // Provide ObsoleteAttribute message
        JobObjectEndOfJobTimeInformation,
        JobObjectAssociateCompletionPortInformation,
        JobObjectBasicAndIoAccountingInformation,
        JobObjectExtendedLimitInformation,
        JobObjectJobSetInformation,
        JobObjectGroupInformation,
        JobObjectNotificationLimitInformation,
        JobObjectLimitViolationInformation,
        JobObjectGroupInformationEx,
        JobObjectCpuRateControlInformation,
        JobObjectCompletionFilter,
        JobObjectCompletionCounter,
        JobObjectReserved1Information = 18,
        JobObjectReserved2Information,
        JobObjectReserved3Information,
        JobObjectReserved4Information,
        JobObjectReserved5Information,
        JobObjectReserved6Information,
        JobObjectReserved7Information,
        JobObjectReserved8Information,
        JobObjectReserved9Information,
        JobObjectReserved10Information,
        JobObjectReserved11Information,
        JobObjectReserved12Information,
        JobObjectReserved13Information,
        JobObjectReserved14Information = 31,
        JobObjectNetRateControlInformation,
        JobObjectNotificationLimitInformation2,
        JobObjectLimitViolationInformation2,
        JobObjectCreateSilo,
        JobObjectSiloBasicInformation,
        JobObjectReserved15Information = 37,
        JobObjectReserved16Information = 38,
        JobObjectReserved17Information = 39,
        JobObjectReserved18Information = 40,
        JobObjectReserved19Information = 41,
        JobObjectReserved20Information = 42,
        JobObjectReserved21Information = 43,
        JobObjectReserved22Information = 44,
        JobObjectReserved23Information = 45,
        JobObjectReserved24Information = 46,
        JobObjectReserved25Information = 47,
        MaxJobObjectInfoClass
    }
}
