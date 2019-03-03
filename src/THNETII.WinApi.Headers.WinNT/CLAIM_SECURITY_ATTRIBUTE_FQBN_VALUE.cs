using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10937
    /// <summary>
    /// The <see cref="CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> structure specifies the fully qualified binary name.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-claim_security_attribute_fqbn_value">CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE
    {
        /// <summary>
        /// The version of the fully qualified binary name value.
        /// </summary>
        public ulong Version;
        /// <summary>
        /// A pointer to a zero-terminated Unicode (UTF-16) string containing
        /// the fully qualified binary name.
        /// <para>Use the <see cref="Name"/> property to access the string.</para>
        /// </summary>
        public IntPtr NamePtr;
        /// <summary>
        /// A fully qualified binary name.
        /// </summary>
#if NETSTANDARD1_6
        public string Name => NamePtr.MarshalAsUnicodeString();
#else
        public Span<char> Name => NamePtr.ToZeroTerminatedUnicodeSpan();
#endif // !NETSTANDARD1_6
    }
}
