using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17761
    /// <inheritdoc cref="IMAGE_RESOURCE_DIRECTORY_STRING"/>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_RESOURCE_DIR_STRING_U
    {
        public short Length;
        internal char NameStringField;
        public Span<char> NameString => SpanOverRef.GetSpan(ref NameStringField, Length);
    }
}
