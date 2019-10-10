using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 261
    /// <summary>
    /// Contains information about a power request. This structure is used by the <see cref="PowerCreateRequest"/> and <see cref="SetWaitableTimerEx"/> functions.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-reason_context">REASON_CONTEXT structure</a></para>
    /// </remarks>
    /// <seealso cref="PowerCreateRequest"/>
    /// <seealso cref="SetWaitableTimerEx"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct REASON_CONTEXT
    {
        /// <summary>
        /// The version number of the structure. This parameter must be set to <see cref="POWER_REQUEST_CONTEXT_VERSION"/>.
        /// </summary>
        public uint Version;
        /// <summary>
        /// The format of the reason for the power request.
        /// </summary>
        public POWER_REQUEST_CONTEXT_FLAGS Flags;

        [StructLayout(LayoutKind.Explicit)]
        internal struct REASON_CONTEXT_VALUE
        {
            [FieldOffset(0)]
            public REASON_CONTEXT_DETAIL Detailed;
            [FieldOffset(0)]
            public PWSTR SimpleReasonString;
        }
        /// <summary>
        /// A union that consists of either a <see cref="Detailed"/> structure or a string.
        /// </summary>
        internal REASON_CONTEXT_VALUE Reason;
        public ref REASON_CONTEXT_DETAIL Detailed => ref SpanOverRef.GetSpan(ref Reason.Detailed)[0];
        /// <summary>
        /// A non-localized string that describes the reason for the power request.
        /// </summary>
        public PWSTR SimpleReasonString
        {
            get => Reason.SimpleReasonString;
            set => Reason.SimpleReasonString = value;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct REASON_CONTEXT_DETAIL
    {
        /// <summary>
        /// The module that contains the string resource.
        /// </summary>
        public IntPtr LocalizedReasonModule;
        /// <summary>
        /// The ID of the string resource.
        /// </summary>
        public int LocalizedReasonId;
        /// <summary>
        /// The number of strings in the <see cref="ReasonStrings"/> parameter.
        /// </summary>
        public int ReasonStringCount;
        internal PWSTR* ReasonStringsField;
        /// <summary>
        /// An span of strings to be substituted in the string resource at run time.
        /// </summary>
        public Span<PWSTR> ReasonStrings => new Span<PWSTR>(ReasonStringsField, ReasonStringCount);
    }
}
