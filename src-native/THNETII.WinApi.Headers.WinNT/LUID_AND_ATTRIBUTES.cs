using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8933
    /// <summary>
    /// The <see cref="LUID_AND_ATTRIBUTES"/> structure represents a <a href="https://msdn.microsoft.com/65dd9a04-fc7c-4179-95ff-dac7dad4668f">locally unique identifier</a> (LUID) and its attributes.
    /// </summary>
    /// <remarks>
    /// An <see cref="LUID_AND_ATTRIBUTES"/> structure can represent an <see cref="LUID"/> whose attributes change frequently, such as when the <see cref="LUID"/> is used to represent privileges in the <see cref="PRIVILEGE_SET"/> structure. Privileges are represented by LUIDs and have attributes indicating whether they are currently enabled or disabled.
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_luid_and_attributes">LUID_AND_ATTRIBUTES structure</a></para>
    /// </remarks>
    /// <seealso cref="AllocateLocallyUniqueId"/>
    /// <seealso cref="LUID"/>
    /// <seealso cref="PRIVILEGE_SET"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct LUID_AND_ATTRIBUTES
    {
        /// <summary>
        /// Specifies an <see cref="LUID"/> value.
        /// </summary>
        public LUID Luid;
        /// <summary>
        /// Specifies attributes of the <see cref="LUID"/>. This value contains up to 32 one-bit flags. Its meaning is dependent on the definition and use of the <see cref="LUID"/>.
        /// </summary>
        public int Attributes;
    }
}
