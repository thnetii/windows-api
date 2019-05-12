using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12562
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct XSTATE_CONFIGURATION
    {
        /// <summary>Mask of all enabled features</summary>
        public ulong EnabledFeatures;

        /// <summary>Mask of volatile enabled features</summary>
        public ulong EnabledVolatileFeatures;

        /// <summary>
        /// Total size of the save area for user states
        /// </summary>
        public int Size;

        /// <summary>
        /// Control Flags
        /// </summary>
        public int ControlFlags;
        private static readonly Bitfield32 bfOptimizedSave = Bitfield32.Bit(0);
        private static readonly Bitfield32 bfCompactionEnabled = Bitfield32.Bit(1);
        public bool OptimizedSave
        {
            get => bfOptimizedSave.ReadBool(ControlFlags);
            set => bfOptimizedSave.WriteBool(ref ControlFlags, value);
        }
        public bool CompactionEnabled
        {
            get => bfCompactionEnabled.ReadBool(ControlFlags);
            set => bfCompactionEnabled.WriteBool(ref ControlFlags, value);
        }

        #region public fixed XSTATE_FEATURE Features[MAXIMUM_XSTATE_FEATURES];
        internal fixed byte FeaturesField[MAXIMUM_XSTATE_FEATURES * XSTATE_FEATURE.SizeOf];
        /// <summary>
        /// List of features
        /// </summary>
        public Span<XSTATE_FEATURE> Features
        {
            get
            {
                fixed (byte* ptr = FeaturesField)
                {
                    return new Span<XSTATE_FEATURE>(ptr, MAXIMUM_XSTATE_FEATURES);
                }
            }
        }
        #endregion

        /// <summary>
        /// Mask of all supervisor features
        /// </summary>
        public ulong EnabledSupervisorFeatures;

        /// <summary>
        /// Mask of features that require start address to be 64 byte aligned
        /// </summary>
        public ulong AlignedFeatures;

        /// <summary>
        /// Total size of the save area for user and supervisor states
        /// </summary>
        public int AllFeatureSize;

        /// <summary>
        /// List which holds size of each user and supervisor state supported by CPU
        /// </summary>
        public fixed int AllFeatures[MAXIMUM_XSTATE_FEATURES];
    }
}
