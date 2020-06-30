using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using static THNETII.WinApi.Native.WinNT.PRIVILEGE_SET_CONTROL_FLAGS;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10337
    /// <summary>
    /// The <see cref="PRIVILEGE_SET"/> structure specifies a set of <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">privileges</a>. It is also used to indicate which, if any, privileges are held by a user or group requesting access to an object.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A privilege is used to control access to an object or service more strictly than is typical with discretionary access control. A system manager uses privileges to control which users are able to manipulate system resources. An application uses privileges when it changes a system-wide resource, such as when it changes the system time or shuts down the system.
    /// </para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-privilege_set">PRIVILEGE_SET structure</a></para>
    /// </remarks>
    /// <seealso cref="LUID"/>
    /// <seealso cref="LUID_AND_ATTRIBUTES"/>
    /// <seealso cref="PrivilegeCheck"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct PRIVILEGE_SET
    {
        /// <summary>
        /// Specifies the number of privileges in the privilege set.
        /// </summary>
        public int PrivilegeCount;
        /// <summary>
        /// Specifies a control flag related to the privileges. The <see cref="PRIVILEGE_SET_ALL_NECESSARY"/> control flag is currently defined. It indicates that all of the specified privileges must be held by the process requesting access. If this flag is not set, the presence of any privileges in the user's access token grants the access.
        /// </summary>
        public PRIVILEGE_SET_CONTROL_FLAGS Control;
        internal LUID_AND_ATTRIBUTES PrivilegeField;
        /// <summary>
        /// Specifies a span of <see cref="LUID_AND_ATTRIBUTES"/> structures describing the set's privileges. The attributes defined for privileges are defined by the <see cref="SE_PRIVILEGE_ATTRIBUTES"/> enumeration.
        /// </summary>
        public Span<LUID_AND_ATTRIBUTES> Privilege => SpanOverRef.GetSpan(ref PrivilegeField, PrivilegeCount);
    }
}
