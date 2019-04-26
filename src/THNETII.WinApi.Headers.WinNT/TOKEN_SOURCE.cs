using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10848
    /// <summary>
    /// The <see cref="TOKEN_SOURCE"/> structure identifies the source of an <a href="https://msdn.microsoft.com/0baaa937-f635-4500-8dcd-9dbbd6f4cd02">access token</a>.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/Winnt/ns-winnt-token_source">TOKEN_SOURCE structure</a></para>
    /// </remarks>
    /// <seealso cref="GetTokenInformation"/>
    /// <seealso cref="LUID"/>
    /// <seealso cref="TOKEN_CONTROL"/>
    /// <seealso cref="TOKEN_DEFAULT_DACL"/>
    /// <seealso cref="TOKEN_GROUPS"/>
    /// <seealso cref="TOKEN_INFORMATION_CLASS"/>
    /// <seealso cref="TOKEN_OWNER"/>
    /// <seealso cref="TOKEN_PRIMARY_GROUP"/>
    /// <seealso cref="TOKEN_PRIVILEGES"/>
    /// <seealso cref="TOKEN_STATISTICS"/>
    /// <seealso cref="TOKEN_TYPE"/>
    /// <seealso cref="TOKEN_USER"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_SOURCE
    {
        #region public char[TOKEN_SOURCE_LENGTH] SourceName;
        [StructLayout(LayoutKind.Explicit, Size = TOKEN_SOURCE_LENGTH)]
        internal struct TOKEN_SOURCE_NAME
        {
            public ref byte this[int index] => ref Span[index];
            internal Span<byte> Span => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref this));
        }
        internal TOKEN_SOURCE_NAME SourceNameField;
        /// <summary>
        /// The ANSI string character bytes used to store the value of <see cref="SourceName"/>.
        /// </summary>
        public Span<byte> SourceNameBytes => SourceNameField.Span;
        /// <summary>
        /// Specifies a string used to identify the source of an access token. This is used to distinguish between such sources as Session Manager, LAN Manager, and RPC Server. A string, rather than a constant, is used to identify the source so users and developers can make extensions to the system, such as by adding other networks, that act as the source of access tokens.
        /// </summary>
        [SuppressMessage("Usage", "PC001: API not supported on all platforms", Justification = "https://github.com/dotnet/platform-compat/issues/123")]
        public unsafe string SourceName
        {
            get
            {
                fixed (void* pSourceName = &SourceNameField)
                {
                    return Marshal.PtrToStringAnsi(new IntPtr(pSourceName), TOKEN_SOURCE_LENGTH);
                }
            }
            set
            {
                if (value is null)
                {
                    SourceNameBytes.Fill(0);
                    return;
                }
                var pValue = Marshal.StringToCoTaskMemAnsi(value);
                try
                {
                    var valueSpan = new Span<byte>(pValue.ToPointer(), TOKEN_SOURCE_LENGTH);
                    int endIdx = valueSpan.IndexOf((byte)0);
                    if (endIdx >= 0)
                        valueSpan = valueSpan.Slice(start: 0, length: endIdx + 1);
                    valueSpan.CopyTo(SourceNameBytes);
                }
                finally
                {
                    Marshal.FreeCoTaskMem(pValue);
                }
            }
        }
        #endregion
        /// <summary>
        /// Specifies a locally unique identifier (LUID) provided by the source component named by the <see cref="SourceName"/> member. This value aids the source component in relating context blocks, such as session-control structures, to the token. This value is typically, but not necessarily, a LUID.
        /// </summary>
        public LUID SourceIdentifier;
    }
}
