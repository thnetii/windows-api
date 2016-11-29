using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    /// <summary>
    /// Contains the load configuration data of an image.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680328.aspx">IMAGE_LOAD_CONFIG_DIRECTORY64 structure</a></para>
    /// </remarks>
    /// <seealso cref="GetImageConfigInformation"/>
    /// <seealso cref="GetProcessAffinityMask"/>
    /// <seealso cref="SetImageConfigInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_LOAD_CONFIG_DIRECTORY32
    {
        /// <summary>
        /// The size, in bytes, that one instance of the <see cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/> type occupies in native memory.
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf<IMAGE_LOAD_CONFIG_DIRECTORY32>();

        /// <summary>
        /// The size of the structure. For Windows XP, the size must be specified as 64 for x86 images.
        /// </summary>
        public int Size;
        /// <summary>
        /// The date and time stamp value. The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
        /// </summary>
        public int TimeDateStamp;
        /// <summary>The major version number.</summary>
        public short MajorVersion;
        /// <summary>The minor version number.</summary>
        public short MinorVersion;
        /// <summary>
        /// The global flags that control system behavior. For more information, see Gflags.exe.
        /// </summary>
        public int GlobalFlagsClear;
        /// <summary>
        /// The global flags that control system behavior. For more information, see Gflags.exe.
        /// </summary>
        public int GlobalFlagsSet;
        /// <summary>
        /// The critical section default time-out value.
        /// </summary>
        public int CriticalSectionDefaultTimeout;
        /// <summary>
        /// The size of the minimum block that must be freed before it is freed (de-committed), in bytes. This value is advisory.
        /// </summary>
        public int DeCommitFreeBlockThreshold;
        /// <summary>
        /// The size of the minimum total memory that must be freed in the process heap before it is freed (de-committed), in bytes. This value is advisory.
        /// </summary>
        public int DeCommitTotalFreeThreshold;
        /// <summary>
        /// The VA of a list of addresses where the LOCK prefix is used. These will be replaced by NOP on single-processor systems. This member is available only for x86.
        /// </summary>
        public int LockPrefixTable;
#pragma warning disable CS0618 // Type or member is obsolete
        /// <summary>
        /// The maximum allocation size, in bytes. This member is obsolete and is used only for debugging purposes.
        /// </summary>
        [Obsolete("The " + nameof(MaximumAllocationSize) + "member is obsolete and is used only for debugging purposes.")]
        public int MaximumAllocationSize;
#pragma warning restore CS0618 // Type or member is obsolete
        /// <summary>
        /// The maximum block size that can be allocated from heap segments, in bytes.
        /// </summary>
        public int VirtualMemoryThreshold;
        /// <summary>
        /// The process affinity mask. For more information, see <see cref="GetProcessAffinityMask"/>. This member is available only for .exe files.
        /// </summary>
        public int ProcessAffinityMask;
        /// <summary>
        /// The process heap flags. For more information, see <see cref="HeapCreate"/>.
        /// </summary>
        public int ProcessHeapFlags;
        /// <summary>
        /// The service pack version.
        /// </summary>
        public short CSDVersion;
        /// <summary>
        /// Reserved for use by the operating system.
        /// </summary>
        public short Reserved1;
        /// <summary>
        /// Reserved for use by the system.
        /// </summary>
        public ulong EditList;
        /// <summary>
        /// A pointer to a cookie that is used by Visual C++ or GS implementation.
        /// </summary>
        public int SecurityCookie;
        /// <summary>
        /// The VA of the sorted table of RVAs of each valid, unique handler in the image. This member is available only for x86.
        /// </summary>
        public int SEHandlerTable;
        /// <summary>
        /// The count of unique handlers in the table. This member is available only for x86.
        /// </summary>
        public int SEHandlerCount;
    }

    /// <summary>
    /// Contains the load configuration data of an image.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680328.aspx">IMAGE_LOAD_CONFIG_DIRECTORY64 structure</a></para>
    /// </remarks>
    /// <seealso cref="GetImageConfigInformation"/>
    /// <seealso cref="GetProcessAffinityMask"/>
    /// <seealso cref="SetImageConfigInformation"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_LOAD_CONFIG_DIRECTORY64
    {
        /// <summary>
        /// The size, in bytes, that one instance of the <see cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/> type occupies in native memory.
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf<IMAGE_LOAD_CONFIG_DIRECTORY64>();

        /// <summary>
        /// The size of the structure. For Windows XP, the size must be specified as 64 for x86 images.
        /// </summary>
        public int Size;
        /// <summary>
        /// The date and time stamp value. The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
        /// </summary>
        public int TimeDateStamp;
        /// <summary>The major version number.</summary>
        public short MajorVersion;
        /// <summary>The minor version number.</summary>
        public short MinorVersion;
        /// <summary>
        /// The global flags that control system behavior. For more information, see Gflags.exe.
        /// </summary>
        public int GlobalFlagsClear;
        /// <summary>
        /// The global flags that control system behavior. For more information, see Gflags.exe.
        /// </summary>
        public int GlobalFlagsSet;
        /// <summary>
        /// The critical section default time-out value.
        /// </summary>
        public int CriticalSectionDefaultTimeout;
        /// <summary>
        /// The size of the minimum block that must be freed before it is freed (de-committed), in bytes. This value is advisory.
        /// </summary>
        public ulong DeCommitFreeBlockThreshold;
        /// <summary>
        /// The size of the minimum total memory that must be freed in the process heap before it is freed (de-committed), in bytes. This value is advisory.
        /// </summary>
        public ulong DeCommitTotalFreeThreshold;
        /// <summary>
        /// The VA of a list of addresses where the LOCK prefix is used. These will be replaced by NOP on single-processor systems. This member is available only for x86.
        /// </summary>
        public ulong LockPrefixTable;
#pragma warning disable CS0618 // Type or member is obsolete
        /// <summary>
        /// The maximum allocation size, in bytes. This member is obsolete and is used only for debugging purposes.
        /// </summary>
        [Obsolete("The " + nameof(MaximumAllocationSize) + "member is obsolete and is used only for debugging purposes.")]
        public ulong MaximumAllocationSize;
#pragma warning restore CS0618 // Type or member is obsolete
        /// <summary>
        /// The maximum block size that can be allocated from heap segments, in bytes.
        /// </summary>
        public ulong VirtualMemoryThreshold;
        /// <summary>
        /// The process affinity mask. For more information, see <see cref="GetProcessAffinityMask"/>. This member is available only for .exe files.
        /// </summary>
        public ulong ProcessAffinityMask;
        /// <summary>
        /// The process heap flags. For more information, see <see cref="HeapCreate"/>.
        /// </summary>
        public int ProcessHeapFlags;
        /// <summary>
        /// The service pack version.
        /// </summary>
        public short CSDVersion;
        /// <summary>
        /// Reserved for use by the operating system.
        /// </summary>
        public short Reserved1;
        /// <summary>
        /// Reserved for use by the system.
        /// </summary>
        public ulong EditList;
        /// <summary>
        /// A pointer to a cookie that is used by Visual C++ or GS implementation.
        /// </summary>
        public ulong SecurityCookie;
        /// <summary>
        /// The VA of the sorted table of RVAs of each valid, unique handler in the image. This member is available only for x86.
        /// </summary>
        public ulong SEHandlerTable;
        /// <summary>
        /// The count of unique handlers in the table. This member is available only for x86.
        /// </summary>
        public ulong SEHandlerCount;
    }
}
