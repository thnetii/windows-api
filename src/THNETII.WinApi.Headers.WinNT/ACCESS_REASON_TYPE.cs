using System;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10367
    [Flags]
    public enum ACCESS_REASON_TYPE
    {

        /// <summary>Indicate no reason for the bit. The bit may not be checked, or just no known reason.</summary>
        AccessReasonNone = 0x00000000,

        //
        // The lowest 2 bytes store the index of the ACE that grant/deny this bit.
        // If the corresponding access mask is zero, then it is deny ACE; otherwise,
        // it is allow ACE.
        //
        /// <summary>Granted a permission.</summary>
        AccessReasonAllowedAce = 0x00010000,
        /// <summary>Denied a permission.</summary>
        AccessReasonDeniedAce = 0x00020000,

        /// <summary>Granted a permission from parent ACE</summary>
        AccessReasonAllowedParentAce = 0x00030000,
        /// <summary>Denied a permission from parent ACE</summary>
        AccessReasonDeniedParentAce = 0x00040000,

        /// <summary>A CAPE didn't grant the permission</summary>
        AccessReasonNotGrantedByCape = 0x00050000,
        /// <summary>A CAPE from the parent's SD didn't grant the permission</summary>
        AccessReasonNotGrantedByParentCape = 0x00060000,

        /// <summary>This is an AppContainer and no ACE granted the permission.</summary>
        AccessReasonNotGrantedToAppContainer = 0x00070000,

        AccessReasonMissingPrivilege = 0x00100000,
        AccessReasonFromPrivilege = 0x00200000,


        AccessReasonIntegrityLevel = 0x00300000,

        AccessReasonOwnership = 0x00400000,

        AccessReasonNullDacl = 0x00500000,
        AccessReasonEmptyDacl = 0x00600000,

        AccessReasonNoSD = 0x00700000,
        /// <summary>this access bit is not granted by any ACE.</summary>
        AccessReasonNoGrant = 0x00800000,

        /// <summary>The trust label ACE did not grant this access.</summary>
        AccessReasonTrustLabel = 0x00900000,

        /// <summary>The filtering ACE did not grant this access</summary>
        AccessReasonFilterAce = 0x00a00000
    }
}
