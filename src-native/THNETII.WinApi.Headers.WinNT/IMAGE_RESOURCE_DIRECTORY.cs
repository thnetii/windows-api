using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17716
    /// <summary>
    /// Resource directory consists of two counts, following by a variable length
    /// array of directory entries.  The first count is the number of entries at
    /// beginning of the array that have actual names associated with each entry.
    /// The entries are in ascending order, case insensitive strings.  The second
    /// count is the number of entries that immediately follow the named entries.
    /// This second count identifies the number of entries that have 16-bit integer
    /// Ids as their name.  These entries are also sorted in ascending order.
    /// <para>
    /// This structure allows fast lookup by either name or number, but for any
    /// given resource entry only one form of lookup is supported, not both.
    /// This is consistant with the syntax of the .RC file and the .RES file.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IMAGE_RESOURCE_DIRECTORY
    {
        public int Characteristics;
        public int TimeDateStamp;
        public short MajorVersion;
        public short MinorVersion;
        public Version Version
        {
            get => new Version(MajorVersion, MinorVersion);
            set
            {
                MajorVersion = (short)(value?.Major ?? 0);
                MinorVersion = (short)(value?.Minor ?? 0);
            }
        }
        public short NumberOfNamedEntries;
        public short NumberOfIdEntries;
        public Span<IMAGE_RESOURCE_DIRECTORY_ENTRY> DirectoryEntries =>
            SpanAfterStruct.GetSpan<IMAGE_RESOURCE_DIRECTORY, IMAGE_RESOURCE_DIRECTORY_ENTRY>(ref this, NumberOfNamedEntries + NumberOfIdEntries);
    }
}
