using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Contains debugging information.
    /// <para><note>This type is used by the <see cref="MapDebugInformation"/> and <see cref="UnmapDebugInformation"/> functions, which are provided only for backward compatibility.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680309.aspx">IMAGE_DEBUG_INFORMATION structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_DEBUG_INFORMATION
    {
        public LIST_ENTRY List;
        public int ReservedSize;
        public IntPtr ReservedMappedBase;
        [MarshalAs(UnmanagedType.U2)]
        public IMAGE_FILE_MACHINE ReservedMachine;
        [MarshalAs(UnmanagedType.U2)]
        public IMAGE_FILE_CHARACTERISTICS ReservedCharacteristics;
        public int ReservedCheckSum;
        public int ImageBase;
        public int SizeOfImage;
        public int ReservedNumberOfSections;
        public IntPtr ReservedSections;
        public int ReservedExportedNamesSize;
        public IntPtr ReservedExportedNames;
        public int ReservedNumberOfFunctionTableEntries;
        public IntPtr ReservedFunctionTableEntries;
        public int ReservedLowestFunctionStartingAddress;
        public int ReservedHighestFunctionEndingAddress;
        public int ReservedNumberOfFpoTableEntries;
        public IntPtr ReservedFpoTableEntries;
        public int SizeOfCoffSymbols;
        public IntPtr CoffSymbols;
        public int ReservedSizeOfCodeViewSymbols;
        public IntPtr ReservedCodeViewSymbols;
        [MarshalAs(UnmanagedType.LPStr)]
        public string ImageFilePath;
        [MarshalAs(UnmanagedType.LPStr)]
        public string ImageFileName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string ReservedDebugFilePath;
        public int ReservedTimeDateStamp;
        [MarshalAs(UnmanagedType.Bool)]
        public bool ReservedRomImage;
        public IntPtr ReservedDebugDirectory;
        public int ReservedNumberOfDebugDirectories;
        public int ReservedOriginalFunctionTableBaseAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] Reserved;
    }
}
