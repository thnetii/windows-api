using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    /// <summary>
    /// The <see cref="SID_AND_ATTRIBUTES"/> structure represents a <em><a href="https://msdn.microsoft.com/en-us/library/ms721625.aspx#_security_security_identifier_gly">security identifier</a></em> (SID) and its attributes. SIDs are used to uniquely identify users or groups.
    /// </summary>
    /// <remarks>
    /// A group is represented by a SID. SIDs have attributes that indicate whether they are currently enabled, disabled, or mandatory. SIDs also indicate how these attributes are used. A <see cref="SID_AND_ATTRIBUTES"/> structure can represent a SID whose attributes change frequently. For example, <see cref="SID_AND_ATTRIBUTES"/> is used to represent groups in the <see cref="TOKEN_GROUPS"/> structure.
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa379595.aspx">SID_AND_ATTRIBUTES structure</a></para>
    /// </remarks>
    /// <seealso cref="SecurityIdentifier"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_USERS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SID_AND_ATTRIBUTES
    {
        public static readonly int SizeOf = Marshal.SizeOf<SID_AND_ATTRIBUTES>();

        /// <summary>
        /// A pointer to the native binary form of a <see cref="SecurityIdentifier"/> instance.
        /// </summary>
        public IntPtr SidPtr;
        /// <summary>
        /// Gets the marshaled .NET <see cref="SecurityIdentifier"/> instance referred to by <see cref="SidPtr"/>.
        /// </summary>
        /// <returns>A <see cref="SecurityIdentifier"/> instance or <c>null</c> if <see cref="SidPtr"/> is <see cref="IntPtr.Zero"/>.</returns>
        public SecurityIdentifier GetMarshaledSid() => SidPtr == IntPtr.Zero ? null : new SecurityIdentifier(SidPtr);
        /// <summary>
        /// Specifies attributes of the SID. This value contains up to 32 one-bit flags. Its meaning depends on the definition and use of the SID.
        /// </summary>
        public int Attributes;
    }
}