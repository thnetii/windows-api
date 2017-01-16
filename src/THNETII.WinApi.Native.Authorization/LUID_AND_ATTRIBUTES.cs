using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.SecurityIdentity.Authorization.AuthorizationFunctions;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="LUID_AND_ATTRIBUTES"/> structure represents a <em><a href="https://msdn.microsoft.com/en-us/library/ms721592.aspx#_security_locally_unique_identifier_gly">locally unique identifier</a></em> (LUID) and its attributes.
    /// </summary>
    /// <remarks>
    /// An <see cref="LUID_AND_ATTRIBUTES"/> structure can represent an LUID whose attributes change frequently, such as when the LUID is used to represent privileges in the <see cref="PRIVILEGE_SET"/> structure. Privileges are represented by LUIDs and have attributes indicating whether they are currently enabled or disabled.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379263.aspx">LUID_AND_ATTRIBUTES structure</a></para>
    /// </remarks>
    /// <seealso cref="AllocateLocallyUniqueId"/>
    /// <seealso cref="PRIVILEGE_SET"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    [StructLayout(LayoutKind.Sequential)]
    public class LUID_AND_ATTRIBUTES
    {
        /// <summary>Specifies an LUID value.</summary>
        public ulong Luid;
        /// <summary>Specifies attributes of the LUID. This value contains up to 32 one-bit flags. Its meaning is dependent on the definition and use of the LUID.</summary>
        public int Attributes;
    }
}