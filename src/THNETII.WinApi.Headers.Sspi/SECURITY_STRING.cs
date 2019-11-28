using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 193
    /// <summary>
    /// The <see cref="SECURITY_STRING"/> structure is used as the string interface for kernel operations and is a clone of the <see cref="UNICODE_STRING"/> structure. This is used for 32-bit mode.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-security_string">SECURITY_STRING structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_STRING
    {
        #region public ushort Length;
        internal ushort LengthField;
        /// <summary>
        /// Specifies the length, in bytes, of the string pointed to by the <see cref="Buffer"/> member, not including the terminating null character, if any.
        /// </summary>
        public int Length
        {
            get => LengthField;
            set => LengthField = (ushort)value;
        }
        #endregion
        #region public ushort MaximumLength;
        internal ushort MaximumLengthField;
        /// <summary>
        /// Specifies the total size, in bytes, of memory allocated for <see cref="Buffer"/>. Up to <see cref="MaximumLength"/> bytes may be written into the buffer without trampling memory.
        /// </summary>
        public int MaximumLength
        {
            get => MaximumLengthField;
            set => MaximumLengthField = (ushort)value;
        }
        #endregion
        #region public IntPtr Buffer;
        /// <summary>
        /// Pointer to a wide-character string. Note that the strings returned by the various LSA functions might not be null-terminated.
        /// </summary>
        public IntPtr Buffer;
        public unsafe Span<char> Span => new Span<char>(Buffer.ToPointer(), MaximumLength);
        /// <summary>
        /// Copies the contents of the <see cref="Buffer"/> member and returns
        /// it as <see cref="string"/> value.
        /// </summary>
        /// <returns>
        /// A new <see cref="string"/> value containing the string pointed to by
        /// the <see cref="Buffer"/> member.
        /// </returns>
        public override unsafe string ToString() =>
            new Span<char>(Buffer.ToPointer(), Length).ToString();
        #endregion
    }
}
