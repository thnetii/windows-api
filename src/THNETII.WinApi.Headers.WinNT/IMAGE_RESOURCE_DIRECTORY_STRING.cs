using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17761
    /// <summary>
    /// For resource directory entries that have actual string names, the Name
    /// field of the directory entry points to an object of the following type.
    /// All of these string objects are stored together after the last resource
    /// directory entry and before the first resource data object.  This minimizes
    /// the impact of these variable length objects on the alignment of the fixed
    /// size directory entry objects.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_RESOURCE_DIRECTORY_STRING
    {
        public short Length;
        internal byte NameStringField;
        public Span<byte> NameBytes => SpanOverRef.GetSpan(ref NameStringField, Length);
        public unsafe string NameString
        {
            get
            {
                fixed (byte* pStr = &NameStringField)
                {
                    return Marshal.PtrToStringAnsi(new IntPtr(pStr), Length);
                }
            }
        }
    }
}
