using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 9056
    /// <summary>
    /// The <see cref="SID_AND_ATTRIBUTES"/> structure represents a <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security identifier</a> (SID) and its attributes. SIDs are used to uniquely identify users or groups.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A group is represented by a SID. SIDs have attributes that indicate whether they are currently
    /// enabled, disabled, or mandatory. SIDs also indicate how these attributes are used. A
    /// <see cref="SID_AND_ATTRIBUTES"/> structure can represent a SID whose attributes change frequently. For
    /// example, <see cref="SID_AND_ATTRIBUTES"/> is used to represent groups in the <see cref="TOKEN_GROUPS"/>
    /// structure.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-_sid_and_attributes">SID_AND_ATTRIBUTES structure</a></para>
    /// </remarks>
    /// <seealso cref="SID"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SID_AND_ATTRIBUTES
    {
        public PSID Sid;
        /// <summary>
        /// Specifies attributes of the SID. This value contains up to 32 one-bit flags. Its meaning depends on the definition and use of the SID.
        /// </summary>
        public int Attributes;
    }
}
