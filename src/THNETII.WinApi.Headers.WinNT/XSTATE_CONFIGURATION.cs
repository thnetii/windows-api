using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Bitwise;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 12562
    [StructLayout(LayoutKind.Sequential)]
    public struct XSTATE_CONFIGURATION
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
        private static readonly Bitfield32 bfOptimizedSave = Bitfield32.DefineFromMask(1 << 0);
        private static readonly Bitfield32 bfCompactionEnabled = Bitfield32.DefineFromMask(1 << 1);
        public bool OptimizedSave
        {
            get => bfOptimizedSave.Read(ControlFlags) != 0;
            set => bfOptimizedSave.Write(ref ControlFlags, value ? 1 : 0);
        }
        public bool CompactionEnabled
        {
            get => bfCompactionEnabled.Read(ControlFlags) != 0;
            set => bfCompactionEnabled.Write(ref ControlFlags, value ? 1 : 0);
        }

        #region public XSTATE_FEATURE Features[MAXIMUM_XSTATE_FEATURES];
        [StructLayout(LayoutKind.Sequential, Size = Length * XSTATE_FEATURE.SizeOf)]
        private struct DUMMYSTRUCTNAME
        {
            public const int Length = MAXIMUM_XSTATE_FEATURES;
            public Span<XSTATE_FEATURE> Span => MemoryMarshal.Cast<DUMMYSTRUCTNAME, XSTATE_FEATURE>(SpanOverRef.GetSpan(ref this));
            public ref XSTATE_FEATURE this[int index] => ref Span[index];
        }
#pragma warning disable IDE0044 // Add readonly modifier
        private DUMMYSTRUCTNAME s;
#pragma warning restore IDE0044 // Add readonly modifier
        /// <summary>
        /// List of features
        /// </summary>
        public Span<XSTATE_FEATURE> Features => s.Span;
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

        #region public int AllFeatures[MAXIMUM_XSTATE_FEATURES];
        [StructLayout(LayoutKind.Sequential, Size = Length * sizeof(int))]
        private struct DUMMYSTRUCTNAME2
        {
            public const int Length = MAXIMUM_XSTATE_FEATURES;
            public Span<int> Span => MemoryMarshal.Cast<DUMMYSTRUCTNAME2, int>(SpanOverRef.GetSpan(ref this));
            public ref int this[int index] => ref Span[index];
        }
#pragma warning disable IDE0044 // Add readonly modifier
        private DUMMYSTRUCTNAME2 s2;
#pragma warning restore IDE0044 // Add readonly modifier
        /// <summary>
        /// List which holds size of each user and supervisor state supported by CPU
        /// </summary>
        public Span<int> AllFeatures => s2.Span;
        #endregion
    }
}
