using System.Runtime.InteropServices;
using System.Security.Principal;
using THNETII.InteropServices.NativeMemory;

using static THNETII.WinApi.Native.WinNT.SECURITY_CONTEXT_TRACKING_MODE;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11172
    //
    // Quality Of Service
    //

    /// <summary>
    /// The <see cref="SECURITY_QUALITY_OF_SERVICE"/> data structure contains information used to support client impersonation. A client can specify this information when it connects to a server; the information determines whether the server may impersonate the client, and if so, to what extent.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-security_quality_of_service">SECURITY_QUALITY_OF_SERVICE structure</a></para>
    /// </remarks>
    /// <seealso cref="DdeSetQualityOfService"/>
    /// <seealso cref="TokenImpersonationLevel"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_QUALITY_OF_SERVICE
    {
        public static readonly int SizeOf = SizeOf<SECURITY_QUALITY_OF_SERVICE>.Bytes;

        /// <summary>
        /// Specifies the size, in bytes, of this structure.
        /// <para>Use the value of the static field <see cref="SizeOf"/>.</para>
        /// </summary>
        public int Length;
        /// <summary>
        /// Specifies the information given to the server about the client, and how the server may represent, or impersonate, the client. Security impersonation levels govern the degree to which a server <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">process</a> can act on behalf of a client process. This member is a <see cref="TokenImpersonationLevel"/> enumeration type value.
        /// </summary>
        public TokenImpersonationLevel ImpersonationLevel;
        /// <summary>
        /// Specifies whether the server is to be given a snapshot of the client's <a href="https://msdn.microsoft.com/3e9d7672-2314-45c8-8178-5a0afcfd0c50">security context</a> (called static tracking), or is to be continually updated to track changes to the client's security context (called dynamic tracking). The <see cref="SECURITY_STATIC_TRACKING"/> value specifies static tracking, and the <see cref="SECURITY_DYNAMIC_TRACKING"/> value specifies dynamic tracking. Not all communications mechanisms support dynamic tracking; those that do not will default to static tracking.
        /// </summary>
        public SECURITY_CONTEXT_TRACKING_MODE ContextTrackingMode;
        internal byte EffectiveOnlyValue;
        /// <summary>
        /// Specifies whether the server may enable or disable <a href="https://msdn.microsoft.com/2fe6cfd3-8a2e-4dbe-9fb8-332633daa97a">privileges</a> and groups that the client's security context may include.
        /// </summary>
        public bool EffectiveOnly
        {
            get => EffectiveOnlyValue != 0;
            set => EffectiveOnlyValue = value ? (byte)1 : (byte)0;
        }
    }
}
