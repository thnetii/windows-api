using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OBJECTID
    {
        public Guid Lineage;
        public int Uniquifier;
    }
}
