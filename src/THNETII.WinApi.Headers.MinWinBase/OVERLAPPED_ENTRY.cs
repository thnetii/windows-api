using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 66
    /// <summary>
    /// Contains the information returned by a call to the <see cref="GetQueuedCompletionStatusEx"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-overlapped_entry">OVERLAPPED_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="GetQueuedCompletionStatusEx"/>
    /// <seealso cref="OVERLAPPED"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct OVERLAPPED_ENTRY
    {
        /// <summary>
        /// Receives the completion key value associated with the file handle whose I/O operation has completed. A completion key is a per-file key that is specified in a call to <see cref="CreateIoCompletionPort"/>.
        /// </summary>
        public UIntPtr lpCompletionKey;
        /// <summary>
        /// Receives the address of the <see cref="OVERLAPPED"/> structure that was specified when the completed I/O operation was started.
        /// </summary>
        public OVERLAPPED* lpOverlapped;
        /// <summary>
        /// Reserved.
        /// </summary>
        public UIntPtr Internal;
        /// <summary>
        /// Receives the number of bytes transferred during the I/O operation that has completed.
        /// </summary>
        public int dwNumberOfBytesTransferred;
    }
}
