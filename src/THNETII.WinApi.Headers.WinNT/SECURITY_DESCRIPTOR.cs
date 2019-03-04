using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10205
    /// <summary>
    /// The <see cref="SECURITY_DESCRIPTOR"/> structure contains the security information associated with an object. Applications use this structure to set and query an object's security status.
    /// <para>Because the internal format of a security descriptor can vary, we recommend that applications not modify the <see cref="SECURITY_DESCRIPTOR"/> structure directly. For creating and manipulating a security descriptor, use the functions listed in See Also.</para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// A security descriptor includes information that specifies the following components of an object's security:
    /// <list type="bullet">
    /// <item>An owner <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID)</item>
    /// <item>A primary group SID</item>
    /// <item>A <a href="https://msdn.microsoft.com/d007cbb9-b547-4dc7-bc22-b526f650f7c2">discretionary access control list</a> (DACL)</item>
    /// <item>A <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">system access control list</a> (SACL)</item>
    /// <item>Qualifiers for the preceding items</item>
    /// </list>
    /// </para>
    /// <para>Several functions that use the <see cref="SECURITY_DESCRIPTOR"/> structure require that this structure be aligned on a valid pointer boundary in memory. These boundaries vary depending on the type of processor used. Memory allocation functions such as <see cref="LocalAlloc"/> return properly aligned pointers.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-security_descriptor">SECURITY_DESCRIPTOR structure</a></para>
    /// </remarks>
    /// <seealso cref="GetSecurityDescriptorControl"/>
    /// <seealso cref="GetSecurityDescriptorDacl"/>
    /// <seealso cref="GetSecurityDescriptorGroup"/>
    /// <seealso cref="GetSecurityDescriptorLength"/>
    /// <seealso cref="GetSecurityDescriptorOwner"/>
    /// <seealso cref="GetSecurityDescriptorRMControl"/>
    /// <seealso cref="GetSecurityDescriptorSacl"/>
    /// <seealso cref="InitializeSecurityDescriptor"/>
    /// <seealso cref="IsValidSecurityDescriptor"/>
    /// <seealso cref="SetSecurityDescriptorDacl"/>
    /// <seealso cref="SetSecurityDescriptorGroup"/>
    /// <seealso cref="SetSecurityDescriptorOwner"/>
    /// <seealso cref="SetSecurityDescriptorRMControl"/>
    /// <seealso cref="SetSecurityDescriptorSacl"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SECURITY_DESCRIPTOR
    {
        public SECURITY_DESCRIPTOR_REVISION Revision;
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal byte Sbz1;
        public SECURITY_DESCRIPTOR_CONTROL Control;
        public SID* Owner;
        public SID* Group;
        public ACL* Sacl;
        public ACL* Dacl;
    }
}
