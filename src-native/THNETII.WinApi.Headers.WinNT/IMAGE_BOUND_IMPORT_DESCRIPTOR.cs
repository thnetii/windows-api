using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17663
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_BOUND_IMPORT_DESCRIPTOR
    {
        public int TimeDateStamp;
        public short OffsetModuleName;
        public short NumberOfModuleForwarderRefs;
        // Span of zero or more IMAGE_BOUND_FORWARDER_REF follows
        public unsafe Span<IMAGE_BOUND_FORWARDER_REF> ModuleForwarderRefs =>
            SpanAfterStruct.GetSpan<IMAGE_BOUND_IMPORT_DESCRIPTOR, IMAGE_BOUND_FORWARDER_REF>(ref this, NumberOfModuleForwarderRefs);
    }
}
