using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11337
    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_SET_ARRAY
    {
        /// <summary>Handle to job object to insert</summary>
        public IntPtr JobHandle;
        /// <summary>Level of this job in the set. Must be > 0. Can be sparse.</summary>
        public int MemberLevel;
        /// <summary>Unused. Must be zero</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Flags;
    }
}
