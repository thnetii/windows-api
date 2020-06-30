using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.WinNT;
using THNETII.WinApi.Native.WinError;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinNTConstants;
    using static WinErrorConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 52
    /// <summary>
    /// Contains information used in asynchronous (or <em>overlapped</em>) input and output (I/O).
    /// </summary>
    /// <remarks>
    /// <para>Any unused members of this structure should always be initialized to zero before the structure is used in a function call. Otherwise, the function may fail and return <see cref="ERROR_INVALID_PARAMETER"/>.</para>
    /// <para>The <see cref="Offset"/> and <see cref="OffsetHigh"/> members together represent a 64-bit file position. It is a byte offset from the start of the file or file-like device, and it is specified by the user; the system will not modify these values. The calling process must set this member before passing the <see cref="OVERLAPPED"/> structure to functions that use an offset, such as the <see cref="ReadFile"/> or <see cref="WriteFile"/> (and related) functions.</para>
    /// <para>You can use the <see cref="HasOverlappedIoCompleted"/> macro to check whether an asynchronous I/O operation has completed if <see cref="GetOverlappedResult"/> is too cumbersome for your application.</para>
    /// <para>You can use the <see cref="CancelIo"/> function to cancel an asynchronous I/O operation.</para>
    /// <para>A common mistake is to reuse an <see cref="OVERLAPPED"/> structure before the previous asynchronous operation has been completed. You should use a separate structure for each request. You should also create an event object for each thread that processes data. If you store the event handles in an array, you could easily wait for all events to be signaled using the <see cref="WaitForMultipleObjects"/> function.</para>
    /// <para>For additional information and potential pitfalls of asynchronous I/O usage, see <see cref="CreateFile"/>, <see cref="ReadFile"/>, <see cref="WriteFile"/>, and related functions.</para>
    /// <para>For a general synchronization overview and conceptual <see cref="OVERLAPPED"/> usage information, see <a href="https://docs.microsoft.com/windows/desktop/Sync/synchronization-and-overlapped-input-and-output">Synchronization and Overlapped Input and Output</a> and related topics.</para>
    /// <para>For a file I/O–oriented overview of synchronous and asynchronous I/O, see <a href="https://docs.microsoft.com/windows/desktop/FileIO/synchronous-and-asynchronous-i-o">Synchronous and Asynchronous I/O</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/ns-minwinbase-overlapped">OVERLAPPED structure</a></para>
    /// </remarks>
    /// <seealso cref="CancelIo"/>
    /// <seealso cref="CreateFile"/>
    /// <seealso cref="GetOverlappedResult"/>
    /// <seealso cref="HasOverlappedIoCompleted"/>
    /// <seealso cref="ReadFile"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Sync/synchronization-and-overlapped-input-and-output"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/synchronous-and-asynchronous-i-o"/>
    /// <seealso cref="WriteFile"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct OVERLAPPED
    {
        /// <summary>
        /// <para>The status code for the I/O request. When the request is issued, the system sets this member to <see cref="STATUS_PENDING"/> to indicate that the operation has not yet started. When the request is completed, the system sets this member to the status code for the completed request.</para>
        /// <para>The <see cref="Internal"/> member was originally reserved for system use and its behavior may change.</para>
        /// </summary>
        public UIntPtr Internal;

        /// <summary>
        /// <para>The number of bytes transferred for the I/O request. The system sets this member if the request is completed without errors.</para>
        /// <para>The <see cref="InternalHigh"/> member was originally reserved for system use and its behavior may change.</para>
        /// </summary>
        public UIntPtr InternalHigh;

        [StructLayout(LayoutKind.Explicit)]
        internal struct DUMMYUNIONNAME
        {
            [FieldOffset(0)]
            public uint Offset;

            [FieldOffset(sizeof(uint))]
            public uint OffsetHigh;

            [FieldOffset(0)]
            public IntPtr Pointer;
        }
        internal DUMMYUNIONNAME u;

        /// <summary>
        /// <para>The low-order portion of the file position at which to start the I/O request, as specified by the user.</para>
        /// <para>This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset (also referred to as a file pointer mechanism), such as a file. Otherwise, this member must be zero.</para>
        /// <para>For additional information, see Remarks.</para>
        /// </summary>
        public int Offset
        {
            get => (int)u.Offset;
            set => u.Offset = (uint)value;
        }

        /// <summary>
        /// <para>The high-order portion of the file position at which to start the I/O request, as specified by the user.</para>
        /// <para>This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset (also referred to as a file pointer mechanism), such as a file. Otherwise, this member must be zero.</para>
        /// <para>For additional information, see Remarks.</para>
        /// </summary>
        public int OffsetHigh
        {
            get => (int)u.OffsetHigh;
            set => u.OffsetHigh = (uint)value;
        }

        /// <summary>
        /// <para>The 64-bit file position at which to start the I/O request, as specified by the user.</para>
        /// <para>This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset (also referred to as a file pointer mechanism), such as a file. Otherwise, this member must be zero.</para>
        /// <para>For additional information, see Remarks.</para>
        /// </summary>
        public long Offset64
        {
            get => (long)(((ulong)u.OffsetHigh) << 32 | u.Offset);
            set
            {
                ulong ulValue = (ulong)value;
                (u.Offset, u.OffsetHigh) = ((uint)ulValue, (uint)(ulValue >> 32));
            }
        }

        /// <summary>
        /// Reserved for system use; do not use after initialization to zero.
        /// </summary>
        public IntPtr Pointer
        {
            get => u.Pointer;
            set => u.Pointer = value;
        }

        /// <summary>
        /// <para>A handle to the event that will be set to a signaled state by the system when the operation has completed. The user must initialize this member either to zero or a valid event handle using the <see cref="CreateEvent"/> function before passing this structure to any overlapped functions. This event can then be used to synchronize simultaneous I/O requests for a device. For additional information, see Remarks.</para>
        /// <para>Functions such as <see cref="ReadFile"/> and <see cref="WriteFile"/> set this handle to the nonsignaled state before they begin an I/O operation. When the operation has completed, the handle is set to the signaled state.</para>
        /// <para>Functions such as <see cref="GetOverlappedResult"/> and the synchronization <a href="https://docs.microsoft.com/windows/desktop/Sync/wait-functions">wait functions</a> reset auto-reset events to the nonsignaled state. Therefore, you should use a manual reset event; if you use an auto-reset event, your application can stop responding if you wait for the operation to complete and then call <see cref="GetOverlappedResult"/> with the <em>bWait</em> parameter set to <see langword="true"/>.</para>
        /// </summary>
        public IntPtr hEvent;
    }
}
