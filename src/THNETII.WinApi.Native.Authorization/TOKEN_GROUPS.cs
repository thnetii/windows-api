using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="TOKEN_GROUPS"/> structure contains information about the group <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifiers</a></em> (SIDs) in an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_token_gly">access token</a></em>.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379624.aspx">TOKEN_GROUPS structure</a></para>
    /// </remarks>
    /// <seealso cref="AdjustTokenGroups"/>
    /// <seealso cref="CreateRestrictedToken"/>
    /// <seealso cref="SID_AND_ATTRIBUTES"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_SOURCE"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public class TOKEN_GROUPS
    {
        /// <summary>Specifies the number of groups in the access token. </summary>
        public int GroupCount;
        /// <summary>
        /// Specifies an array of <see cref="SID_AND_ATTRIBUTES"/> structures that contain a set of SIDs and corresponding attributes. 
        /// <para>The <see cref="SID_AND_ATTRIBUTES.Attributes"/> members of the <see cref="SID_AND_ATTRIBUTES"/> structures are <see cref="SE_GROUP_ATTRIBUTES"/> values.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public SID_AND_ATTRIBUTES[] Groups;
    }
}
