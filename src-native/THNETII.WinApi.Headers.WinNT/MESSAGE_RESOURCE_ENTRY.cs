using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 19585
    /// <summary>
    /// Contains the error message or message box display text for a message table resource.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-message_resource_entry">MESSAGE_RESOURCE_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="MESSAGE_RESOURCE_BLOCK"/>
    /// <seealso cref="MESSAGE_RESOURCE_DATA"/>
    /// <seealso href="https://msdn.microsoft.com/en-us/library/ms632583(v=VS.85).aspx">Resources</seealso>
    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_ENTRY
    {
        /// <summary>
        /// The length, in bytes, of the <see cref="Text"/> span.
        /// </summary>
        public short Length;
        /// <summary>
        /// Indicates that the string is encoded in Unicode, if the value has <see cref="MESSAGE_RESOURCE_FLAGS.MESSAGE_RESOURCE_UNICODE"/> set.
        /// Indicates that the string is encoded in ANSI, if not.
        /// </summary>
        public MESSAGE_RESOURCE_FLAGS Flags;
        internal byte TextField;
        /// <summary>
        /// A span of bytes containing the error message or message box display text.
        /// </summary>
        public Span<byte> Text => SpanOverRef.GetSpan(ref TextField, Length);
        /// <summary>
        /// Marshals the data in the <see cref="Text"/> property to a managed <see cref="string"/> value.
        /// </summary>
        /// <returns>An allocated <see cref="string"/> containing a copy of the datat stored in <see cref="Text"/>.</returns>
        public unsafe string MarshalTextAsString()
        {
            fixed (void* ptr = &TextField)
            {
                IntPtr pString = new IntPtr(ptr);
                if (Flags.HasFlag(MESSAGE_RESOURCE_FLAGS.MESSAGE_RESOURCE_UNICODE))
                    return Marshal.PtrToStringUni(pString, Length);
                else
                    return Marshal.PtrToStringAnsi(pString, Length);
            }
        }
    }
}
