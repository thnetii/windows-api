using System;
using System.Runtime.InteropServices;

using static System.Runtime.InteropServices.CallingConvention;

#if NETSTANDARD1_3
using EntryPointNotFoundException = System.Exception;
#endif

namespace THNETII.WinApi.Native.HandleApi
{
    public static class HandleApiFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\handleapi.h, line 35
        #region CloseHandle function
        /// <summary>
        /// Closes an open object handle.
        /// </summary>
        /// <param name="hObject">A valid handle to an open object.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <c>true</c>.</para>
        /// <para>If the function fails, the return value is <c>false</c>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// <para>If the application is running under a debugger, the function will throw an exception if it receives either a handle value that is not valid or a pseudo-handle value. This can happen if you close a handle twice, or if you call CloseHandle on a handle returned by the <see cref="FindFirstFile"/> function instead of calling the <see cref="FindClose"/> function.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// The <see cref="CloseHandle"/> function closes handles to the following objects:
        /// <list type="bullet">
        /// <item>Access token</item>
        /// <item>Communications device</item>
        /// <item>Console input</item>
        /// <item>Console screen buffer</item>
        /// <item>Event</item>
        /// <item>File</item>
        /// <item>File mapping</item>
        /// <item>I/O completion port</item>
        /// <item>Job</item>
        /// <item>Mailslot</item>
        /// <item>Memory resource notification</item>
        /// <item>Mutex</item>
        /// <item>Named pipe</item>
        /// <item>Pipe</item>
        /// <item>Process</item>
        /// <item>Semaphore</item>
        /// <item>Thread</item>
        /// <item>Transaction</item>
        /// <item>Waitable timer</item>
        /// </list>
        /// </para>
        /// <para>The documentation for the functions that create these objects indicates that CloseHandle should be used when you are finished with the object, and what happens to pending operations on the object after the handle is closed. In general, CloseHandle invalidates the specified object handle, decrements the object's handle count, and performs object retention checks. After the last handle to an object is closed, the object is removed from the system. For a summary of the creator functions for these objects, see <a href="https://msdn.microsoft.com/3e3288dd-155a-41d0-9d43-5f49ed4c4a9d">Kernel Objects</a>.</para>
        /// <para>Generally, an application should call CloseHandle once for each handle it opens. It is usually not necessary to call CloseHandle if a function that uses a handle fails with <see cref="ERROR_INVALID_HANDLE"/>, because this error usually indicates that the handle is already invalidated. However, some functions use ERROR_INVALID_HANDLE to indicate that the object itself is no longer valid. For example, a function that attempts to use a handle to a file on a network might fail with ERROR_INVALID_HANDLE if the network connection is severed, because the file object is no longer available. In this case, the application should close the handle.</para>
        /// <para>If a handle is transacted, all handles bound to a transaction should be closed before the transaction is committed. If a transacted handle was opened by calling <see cref="CreateFileTransacted"/> with the <see cref="FILE_FLAG_DELETE_ON_CLOSE"/> flag, the file is not deleted until the application closes the handle and calls <see cref="CommitTransaction"/>. For more information about transacted objects, see <a href="https://msdn.microsoft.com/356c66dc-5ddd-472f-835c-2e2cb019bcfd">Working With Transactions</a>.</para>
        /// <para>Closing a thread handle does not terminate the associated thread or remove the thread object. Closing a process handle does not terminate the associated process or remove the process object. To remove a thread object, you must terminate the thread, then close all handles to the thread. For more information, see <a href="https://msdn.microsoft.com/633e5d0c-e9d8-4f9a-9411-17cbe9e2e6e4">Terminating a Thread</a>. To remove a process object, you must terminate the process, then close all handles to the process. For more information, see <a href="https://msdn.microsoft.com/af24d157-2719-4052-8029-1eb8010047cc">Terminating a Process</a>.</para>
        /// <para>Closing a handle to a file mapping can succeed even when there are file views that are still open. For more information, see <a href="https://msdn.microsoft.com/d62d068c-9b1d-4dbf-8b21-31a636a41456">Closing a File Mapping Object</a>.</para>
        /// <para>Do not use the <see cref="CloseHandle"/> function to close a socket. For more information, see <a href="https://msdn.microsoft.com/383747c3-dd3d-4a18-b4e8-2815d5e5c0c7">Socket Closure</a>.</para>
        /// <para>Do not use the <see cref="CloseHandle"/> function to close a handle to an open registry key. Instead, use the <see cref="RegCloseKey"/> function. <see cref="CloseHandle"/> does not close the handle to the registry key, but does not return an error to indicate this failure.</para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-closehandle">CloseHandle function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CreateFile"/>
        /// <seealso cref="CreateFileTransacted"/>
        /// <seealso cref="DeleteFile"/>
        /// <seealso cref="FindClose"/>
        /// <seealso cref="FindFirstFile"/>
        /// <seealso href="https://msdn.microsoft.com/b4769e19-7478-4919-a9d2-8086ece6da70">Handle and Object Functions</seealso>
        /// <seealso href="https://msdn.microsoft.com/3e3288dd-155a-41d0-9d43-5f49ed4c4a9d">Kernel Objects</seealso>
        /// <seealso href="https://msdn.microsoft.com/437419c7-d6c5-4cae-b5d0-d552c75d4448">Object Interface</seealso>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);
        #endregion
    }
}
