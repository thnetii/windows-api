using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.MinWinBase
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 223
    /// <summary>
    /// An application-defined callback function used with the <see cref="ReadFileEx"/> and <see cref="WriteFileEx"/> functions. It is called when the asynchronous input and output (I/O) operation is completed or canceled and the calling thread is in an alertable state (by using the <see cref="SleepEx"/>, <see cref="MsgWaitForMultipleObjectsEx"/>, <see cref="WaitForSingleObjectEx"/>, or <see cref="WaitForMultipleObjectsEx"/> function with the <em>fAlertable</em> parameter set to <see langword="true"/>).
    /// <para></para>
    /// </summary>
    /// <param name="dwErrorCode">The I/O completion status. This parameter can be one of the <a href="https://docs.microsoft.com/windows/desktop/Debug/system-error-codes">system error codes</a>.</param>
    /// <param name="dwNumberOfBytesTransfered">The number of bytes transferred. If an error occurs, this parameter is zero.</param>
    /// <param name="lpOverlapped">A reference to the <see cref="OVERLAPPED"/> structure specified by the asynchronous I/O function.</param>
    /// <remarks>
    /// <para>
    /// The return value for an asynchronous operation is <c>0</c> (<see cref="ERROR_SUCCESS"/>) if the operation completed successfully or if the operation completed with a warning. To determine whether an I/O operation was completed successfully, check that <paramref name="dwErrorCode"/> is <c>0</c> (zero), call <see cref="GetOverlappedResult"/>, then call <see cref="Marshal.GetLastWin32Error"/>. For example, if the buffer was not large enough to receive all of the data from a call to <see cref="ReadFileEx"/>, <paramref name="dwErrorCode"/> is set to <c>0</c> (zero), <see cref="GetOverlappedResult"/> fails, and <see cref="Marshal.GetLastWin32Error"/> returns <see cref="ERROR_MORE_DATA"/>.
    /// </para>
    /// <para>
    /// Returning from this function allows another pending I/O completion routine to be called. All waiting completion routines are called before the alertable thread's wait is completed with a return code of <see cref="WAIT_IO_COMPLETION"/>. The system may call the waiting completion routines in any order. They may or may not be called in the order the I/O functions are completed.
    /// </para>
    /// <para>Each time the system calls a completion routine, it uses some of the application's stack. If the completion routine does additional asynchronous I/O and alertable waits, the stack may grow.</para>
    /// <para>For more information, see <a href="https://docs.microsoft.com/windows/desktop/Sync/asynchronous-procedure-calls">Asynchronous Procedure Calls</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/minwinbase/nc-minwinbase-lpoverlapped_completion_routine">LPOVERLAPPED_COMPLETION_ROUTINE callback function</a></para>
    /// </remarks>
    /// <seealso cref="BindIoCompletionCallback"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/file-management-functions">File Management Functions</seealso>
    /// <seealso cref="OVERLAPPED"/>
    /// <seealso cref="ReadFileEx"/>
    /// <seealso cref="SleepEx"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/FileIO/synchronous-and-asynchronous-i-o">Synchronous and Asynchronous I/O</seealso>
    /// <seealso cref="WaitForMultipleObjectsEx"/>
    /// <seealso cref="WaitForSingleObjectEx"/>
    /// <seealso cref="WriteFileEx"/>
    public delegate void LPOVERLAPPED_COMPLETION_ROUTINE(
        [In] int dwErrorCode,
        [In] int dwNumberOfBytesTransfered,
        ref OVERLAPPED lpOverlapped
        );
}
