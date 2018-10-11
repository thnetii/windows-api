using System;
using System.Collections.Generic;
using System.Text;

using static THNETII.WinApiNative.ActiveDirectoryDomainServices.DS_NAME_ERROR;
using static THNETII.WinApiNative.ActiveDirectoryDomainServices.DS_NAME_FORMAT;

namespace THNETII.WinApiNative.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_NAME_FLAGS"/> enumeration is used to define how the name syntax will be cracked. These flags are used by the <see cref="DsCrackNames"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_name_flags">DS_NAME_FLAGS Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DS_NAME_FORMAT"/>
    /// <seealso cref="DsCrackNames"/>
    [Flags]
    public enum DS_NAME_FLAGS
    {
        /// <summary>
        /// Indicates that there are no associated flags.
        /// </summary>
        DS_NAME_NO_FLAGS = 0x0,

        /// <summary>
        /// Performs a syntactical mapping at the client without transferring over the network. The only syntactic mapping supported is from <see cref="DS_FQDN_1779_NAME"/> to <see cref="DS_CANONICAL_NAME"/> or <see cref="DS_CANONICAL_NAME_EX"/>. <see cref="DsCrackNames"/> returns the <see cref="DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING"/> flag if a syntactical mapping is not possible.
        /// </summary>
        DS_NAME_FLAG_SYNTACTICAL_ONLY = 0x1,

        /// <summary>
        /// Forces a trip to the domain controller for evaluation, even if the syntax could be cracked locally.
        /// </summary>
        DS_NAME_FLAG_EVAL_AT_DC = 0x2,

        /// <summary>
        /// The call fails if the domain controller is not a global catalog server.
        /// </summary>
        DS_NAME_FLAG_GCVERIFY = 0x4,

        /// <summary>
        /// Enables cross forest trust referral.
        /// </summary>
        DS_NAME_FLAG_TRUST_REFERRAL = 0x8
    }
}
