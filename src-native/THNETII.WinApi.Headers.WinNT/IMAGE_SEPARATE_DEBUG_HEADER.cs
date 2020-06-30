using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 18367
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_SEPARATE_DEBUG_HEADER
    {
        public short Signature;
        #region public IMAGE_SEPARATE_DEBUG_FLAGS Flags;
        internal short FlagsField;
        private static readonly Bitfield16 FlagsMask = Bitfield16.FromMask(IMAGE_SEPARATE_DEBUG_FLAGS_MASK);
        public IMAGE_SEPARATE_DEBUG_FLAGS Flags
        {
            get => (IMAGE_SEPARATE_DEBUG_FLAGS)FlagsMask.ReadMasked(FlagsField);
            set => FlagsMask.WriteMasked(ref FlagsField, (short)value);
        }
        #endregion
        public IMAGE_FILE_MACHINE_TYPE Machine;
        public IMAGE_DLLCHARACTERISTICS_FLAGS Characteristics;
        public int TimeDateStamp;
        public int CheckSum;
        public int ImageBase;
        public int SizeOfImage;
        public int NumberOfSections;
        public int ExportedNamesSize;
        public int DebugDirectorySize;
        public int SectionAlignment;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public fixed int Reserved[2];
    }
}
