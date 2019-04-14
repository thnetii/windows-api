using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12193
    [StructLayout(LayoutKind.Sequential)]
    public struct SILOOBJECT_BASIC_INFORMATION
    {
        public int SiloId;
        public int SiloParentId;
        public int NumberOfProcesses;
        private int ReservedField;
        private Span<byte> ReservedSpan => MemoryMarshal.AsBytes(SpanOverRef.GetSpan(ref ReservedField));
        public bool IsInServerSilo
        {
            get => ReservedSpan[0] != 0;
            set => ReservedSpan[0] = value ? (byte)1 : (byte)0;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SuppressMessage("Usage", "PC001: API not supported on all platforms", Justification = "https://github.com/dotnet/platform-compat/issues/123")]
        public Span<byte> Reserved => ReservedSpan.Slice(1);
    }
}
