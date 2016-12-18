using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="ACE_HEADER"/> structure defines the type and size of an <em><a href="https://msdn.microsoft.com/en-us/library/ms721532.aspx#_security_access_control_entry_gly">access control entry</a></em> (ACE).
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="ACE_HEADER"/> structure is the first member of the various types of ACE structures.</para>
    /// <para>System-alarm ACEs are not currently supported. The <see cref="AceType"/> member cannot specify the <see cref="AceType.SystemAlarm"/> or <see cref="AceType.SystemAlarmObject"/> values.</para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa374919.aspx">ACE_HEADER structure</a></para>
    /// </remarks>
    /// <seealso cref="CommonAce"/>
    /// <seealso cref="CompoundAce"/>
    /// <seealso cref="CustomAce"/>
    /// <seealso cref="GenericAce"/>
    /// <seealso cref="GenericAcl"/>
    /// <seealso cref="KnownAce"/>
    /// <seealso cref="ObjectAce"/>
    /// <seealso cref="QualifiedAce"/>
    [StructLayout(LayoutKind.Sequential)]
    public class ACE_HEADER
    {
        /// <summary>
        /// Specifies the ACE type.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public AceType AceType;
        /// <summary>
        /// Specifies a set of ACE type-specific control flags.
        /// </summary>
        [MarshalAs(UnmanagedType.U1)]
        public AceFlags AceFlags;
        /// <summary>
        /// Specifies the size, in bytes, of the ACE.
        /// </summary>
        public ushort AceSize;
    }
}
