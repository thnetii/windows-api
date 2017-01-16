using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="GENERIC_MAPPING"/> structure defines the mapping of generic access rights to specific and standard access rights for an object. When a client application requests generic access to an object, that request is mapped to the access rights defined in this structure.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa446633.aspx">GENERIC_MAPPING structure</a></para>
    /// </remarks>
    /// <seealso cref="AccessCheck"/>
    /// <seealso cref="AccessCheckAndAuditAlarm"/>
    /// <seealso cref="CreatePrivateObjectSecurity"/>
    /// <seealso cref="MapGenericMask"/>
    /// <seealso cref="SetPrivateObjectSecurity"/>
    /// <seealso cref="ACCESS_MASK"/>
    [StructLayout(LayoutKind.Sequential)]
    public class GENERIC_MAPPING
    {
        /// <summary>Specifies an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> defining read access to an object.</summary>
        public ACCESS_MASK GenericRead;
        /// <summary>Specifies an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> defining write access to an object.</summary>
        public ACCESS_MASK GenericWrite;
        /// <summary>Specifies an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> defining execute access to an object.</summary>
        public ACCESS_MASK GenericExecute;
        /// <summary>Specifies an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_mask_gly">access mask</a></em> defining all possible types of access to an object.</summary>
        public ACCESS_MASK GenericAll;
    }
}