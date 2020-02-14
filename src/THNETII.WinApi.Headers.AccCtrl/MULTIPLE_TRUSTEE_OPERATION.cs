using System;
using System.Collections.Generic;
using System.Text;

namespace THNETII.WinApi.Native.AccCtrl
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AccCtrl.h, line 107
    //
    // Definition: MULTIPLE_TRUSTEE_OPERATION
    // If the trustee is a multiple trustee, this enumerated type specifies the type.
    // TRUSTEE_IS_IMPERSONATE       The trustee is an impersonate trustee and the multiple
    //                          trustee field in the trustee points to another trustee
    //                          that is a trustee for the server that will be doing the
    //                          impersonation.
    //


    /// <summary>
    /// The <see cref="MULTIPLE_TRUSTEE_OPERATION"/> enumeration contains values that indicate whether a <see cref="TRUSTEE"/> structure is an impersonation trustee.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/accctrl/ne-accctrl-multiple_trustee_operation">MULTIPLE_TRUSTEE_OPERATION enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/access-control">Access Control Overview</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/SecAuthZ/authorization-enumerations">Authorization Enumerations</seealso>
    /// <seealso cref="TRUSTEE"/>
    public enum MULTIPLE_TRUSTEE_OPERATION
    {
        /// <summary>
        /// The trustee is not an impersonation trustee.
        /// </summary>
        NO_MULTIPLE_TRUSTEE,
        /// <summary>
        /// The trustee is an impersonation trustee. The <see cref="TRUSTEE.pMultipleTrustee"/> member of the <see cref="TRUSTEE"/> structure points to a trustee for a server that can impersonate the client trustee.
        /// </summary>
        TRUSTEE_IS_IMPERSONATE,
    }
}
