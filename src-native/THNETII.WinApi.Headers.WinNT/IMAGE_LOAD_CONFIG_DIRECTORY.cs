using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17995
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY
    {
        public int Size;
        public int TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set => (MajorVersion, MinorVersion) = value is null
                ? default
                : ((short)value.Major, (short)value.Minor);
        }
        public int GlobalFlagsClear;
        public int GlobalFlagsSet;
        public int CriticalSectionDefaultTimeout;
        public IntPtr DeCommitFreeBlockThreshold;
        public IntPtr DeCommitTotalFreeThreshold;
        public IntPtr LockPrefixTable;                // VA
        public IntPtr MaximumAllocationSize;
        public IntPtr VirtualMemoryThreshold;
        public IntPtr ProcessAffinityMask;
        public int ProcessHeapFlags;
        public short CSDVersion;
        public short DependentLoadFlags;
        public IntPtr EditList;                       // VA
        public IntPtr SecurityCookie;                 // VA
        public IntPtr SEHandlerTable;                 // VA
        public IntPtr SEHandlerCount;
        public IntPtr GuardCFCheckFunctionPointer;    // VA
        public IntPtr GuardCFDispatchFunctionPointer; // VA
        public IntPtr GuardCFFunctionTable;           // VA
        public IntPtr GuardCFFunctionCount;
        public int GuardFlags;
        public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;
        public IntPtr GuardAddressTakenIatEntryTable; // VA
        public IntPtr GuardAddressTakenIatEntryCount;
        public IntPtr GuardLongJumpTargetTable;       // VA
        public IntPtr GuardLongJumpTargetCount;
        public IntPtr DynamicValueRelocTable;         // VA
        public IntPtr CHPEMetadataPointer;            // VA
        public IntPtr GuardRFFailureRoutine;          // VA
        public IntPtr GuardRFFailureRoutineFunctionPointer; // VA
        public int DynamicValueRelocTableOffset;
        public short DynamicValueRelocTableSection;
        public short Reserved2;
        public IntPtr GuardRFVerifyStackPointerFunctionPointer; // VA
        public int HotPatchTableOffset;
        public int Reserved3;
        public IntPtr EnclaveConfigurationPointer;     // VA
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17995
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY32
    {
        public int Size;
        public int TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set => (MajorVersion, MinorVersion) = value is null
                ? default
                : ((short)value.Major, (short)value.Minor);
        }
        public int GlobalFlagsClear;
        public int GlobalFlagsSet;
        public int CriticalSectionDefaultTimeout;
        public int DeCommitFreeBlockThreshold;
        public int DeCommitTotalFreeThreshold;
        public int LockPrefixTable;                // VA
        public int MaximumAllocationSize;
        public int VirtualMemoryThreshold;
        public int ProcessAffinityMask;
        public int ProcessHeapFlags;
        public short CSDVersion;
        public short DependentLoadFlags;
        public int EditList;                       // VA
        public int SecurityCookie;                 // VA
        public int SEHandlerTable;                 // VA
        public int SEHandlerCount;
        public int GuardCFCheckFunctionPointer;    // VA
        public int GuardCFDispatchFunctionPointer; // VA
        public int GuardCFFunctionTable;           // VA
        public int GuardCFFunctionCount;
        public int GuardFlags;
        public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;
        public int GuardAddressTakenIatEntryTable; // VA
        public int GuardAddressTakenIatEntryCount;
        public int GuardLongJumpTargetTable;       // VA
        public int GuardLongJumpTargetCount;
        public int DynamicValueRelocTable;         // VA
        public int CHPEMetadataPointer;            // VA
        public int GuardRFFailureRoutine;          // VA
        public int GuardRFFailureRoutineFunctionPointer; // VA
        public int DynamicValueRelocTableOffset;
        public short DynamicValueRelocTableSection;
        public short Reserved2;
        public int GuardRFVerifyStackPointerFunctionPointer; // VA
        public int HotPatchTableOffset;
        public int Reserved3;
        public int EnclaveConfigurationPointer;     // VA
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17995
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY64
    {
        public int Size;
        public int TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set => (MajorVersion, MinorVersion) = value is null
                ? default
                : ((short)value.Major, (short)value.Minor);
        }
        public int GlobalFlagsClear;
        public int GlobalFlagsSet;
        public int CriticalSectionDefaultTimeout;
        public long DeCommitFreeBlockThreshold;
        public long DeCommitTotalFreeThreshold;
        public long LockPrefixTable;                // VA
        public long MaximumAllocationSize;
        public long VirtualMemoryThreshold;
        public long ProcessAffinityMask;
        public int ProcessHeapFlags;
        public short CSDVersion;
        public short DependentLoadFlags;
        public long EditList;                       // VA
        public long SecurityCookie;                 // VA
        public long SEHandlerTable;                 // VA
        public long SEHandlerCount;
        public long GuardCFCheckFunctionPointer;    // VA
        public long GuardCFDispatchFunctionPointer; // VA
        public long GuardCFFunctionTable;           // VA
        public long GuardCFFunctionCount;
        public int GuardFlags;
        public IMAGE_LOAD_CONFIG_CODE_INTEGRITY CodeIntegrity;
        public long GuardAddressTakenIatEntryTable; // VA
        public long GuardAddressTakenIatEntryCount;
        public long GuardLongJumpTargetTable;       // VA
        public long GuardLongJumpTargetCount;
        public long DynamicValueRelocTable;         // VA
        public long CHPEMetadataPointer;            // VA
        public long GuardRFFailureRoutine;          // VA
        public long GuardRFFailureRoutineFunctionPointer; // VA
        public int DynamicValueRelocTableOffset;
        public short DynamicValueRelocTableSection;
        public short Reserved2;
        public long GuardRFVerifyStackPointerFunctionPointer; // VA
        public int HotPatchTableOffset;
        public int Reserved3;
        public long EnclaveConfigurationPointer;     // VA
    }
}
