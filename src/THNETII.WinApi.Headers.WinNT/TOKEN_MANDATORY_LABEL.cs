using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10799
    /// <summary>
    /// The <see cref="TOKEN_MANDATORY_LABEL"/> structure specifies the mandatory integrity level for a token.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-token_mandatory_label">TOKEN_MANDATORY_LABEL structure</a></para>
    /// </remarks>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_MANDATORY_LABEL
    {
        public static readonly int TOKEN_INTEGRITY_LEVEL_MAX_SIZE = ((SizeOf<TOKEN_MANDATORY_LABEL>.Bytes + IntPtr.Size - 1) & ~(IntPtr.Size - 1)) + SID.SECURITY_MAX_SID_SIZE;

        /// <summary>
        /// A <see cref="SID_AND_ATTRIBUTES"/> structure that specifies the mandatory integrity level of the token.
        /// </summary>
        public SID_AND_ATTRIBUTES Label;
    }
}
