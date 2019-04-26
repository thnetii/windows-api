using System.Runtime.InteropServices;
using System.Security.Principal;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8984
    /// <summary>
    /// The <see cref="SID_IDENTIFIER_AUTHORITY"/> structure represents the top-level authority of a <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID).
    /// </summary>
    /// <remarks>
    /// <para>
    /// The identifier authority value identifies the agency that issued the SID. The following identifier
    /// authorities are predefined.
    /// <list type="table">
    /// <listheader><term>Identifier authority</term><description>Value</description></listheader>
    /// <item><term><see cref="SECURITY_NULL_SID_AUTHORITY"/></term><description><c>0</c> (zero)</description></item>
    /// <item><term><see cref="SECURITY_WORLD_SID_AUTHORITY"/></term><description><c>1</c></description></item>
    /// <item><term><see cref="SECURITY_LOCAL_SID_AUTHORITY"/></term><description><c>2</c></description></item>
    /// <item><term><see cref="SECURITY_CREATOR_SID_AUTHORITY"/></term><description><c>3</c></description></item>
    /// <item><term><see cref="SECURITY_NON_UNIQUE_AUTHORITY"/></term><description><c>4</c></description></item>
    /// <item><term><see cref="SECURITY_NT_AUTHORITY"/></term><description><c>5</c></description></item>
    /// <item><term><see cref="SECURITY_RESOURCE_MANAGER_AUTHORITY"/></term><description><c>9</c></description></item>
    /// </list>
    /// </para>
    /// <para>A SID must contain a top-level authority and at least one <a href="https://msdn.microsoft.com/ce589e18-02ac-42c2-b76b-776deb686bbd">relative identifier</a> (RID) value.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_sid_identifier_authority">SID_IDENTIFIER_AUTHORITY structure</a></para>
    /// </remarks>
    /// <seealso cref="AllocateAndInitializeSid"/>
    /// <seealso cref="GetSidIdentifierAuthority"/>
    /// <seealso cref="InitializeSid"/>
    /// <seealso cref="SID"/>
    /// <seealso cref="SecurityIdentifier"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SID_IDENTIFIER_AUTHORITY
    {
        /// <summary>
        /// A span of 6 bytes specifying a SID's top-level authority.
        /// </summary>
        public fixed byte Value[6];
    }
}
