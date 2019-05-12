using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static COMIMAGE_FLAGS;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18526
    /// <summary>CLR 2.0 header structure.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_COR20_HEADER
    {
        // Header versioning
        public int cb;
        public short MajorRuntimeVersion;
        public short MinorRuntimeVersion;

        // Symbol table and startup information
        public IMAGE_DATA_DIRECTORY MetaData;
        public COMIMAGE_FLAGS Flags;

        /// <summary>If <see cref="COMIMAGE_FLAGS_NATIVE_ENTRYPOINT"/> is set in <see cref="Flags"/>, <see cref="EntryPointRVA"/> represents an RVA to a native entrypoint.</summary>
        public int EntryPointRVA;
        /// <summary>If <see cref="COMIMAGE_FLAGS_NATIVE_ENTRYPOINT"/> is not set in <see cref="Flags"/>, <see cref="EntryPointToken"/> represents a managed entrypoint.</summary>
        public int EntryPointToken
        {
            get => EntryPointRVA;
            set => EntryPointRVA = value;
        }

        // Binding information
        public IMAGE_DATA_DIRECTORY Resources;
        public IMAGE_DATA_DIRECTORY StrongNameSignature;

        // Regular fixup and binding information
        public IMAGE_DATA_DIRECTORY CodeManagerTable;
        public IMAGE_DATA_DIRECTORY VTableFixups;
        public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;

        /// <summary>Precompiled image info (internal use only - set to zero)</summary>
        public IMAGE_DATA_DIRECTORY ManagedNativeHeader;

    }
}
