using System;
using System.Runtime.InteropServices;
using THNETII.WinApi.Native.WinBase;
using THNETII.WinApi.Native.WinNT;

using static System.Runtime.InteropServices.CallingConvention;
using static THNETII.WinApi.Native.WinError.WinErrorConstants;
using static THNETII.WinApi.Native.WinNT.WinNTRuntimeConstants;

#if NETSTANDARD1_6
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
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
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
        /// <para>The documentation for the functions that create these objects indicates that <see cref="CloseHandle"/> should be used when you are finished with the object, and what happens to pending operations on the object after the handle is closed. In general, CloseHandle invalidates the specified object handle, decrements the object's handle count, and performs object retention checks. After the last handle to an object is closed, the object is removed from the system. For a summary of the creator functions for these objects, see <a href="https://msdn.microsoft.com/3e3288dd-155a-41d0-9d43-5f49ed4c4a9d">Kernel Objects</a>.</para>
        /// <para>Generally, an application should call <see cref="CloseHandle"/> once for each handle it opens. It is usually not necessary to call <see cref="CloseHandle"/> if a function that uses a handle fails with <see cref="ERROR_INVALID_HANDLE"/>, because this error usually indicates that the handle is already invalidated. However, some functions use <see cref="ERROR_INVALID_HANDLE"/> to indicate that the object itself is no longer valid. For example, a function that attempts to use a handle to a file on a network might fail with <see cref="ERROR_INVALID_HANDLE"/> if the network connection is severed, because the file object is no longer available. In this case, the application should close the handle.</para>
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
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\handleapi.h, line 43
        #region DuplicateHandle function
        /// <summary>
        /// Duplicates an object handle.
        /// </summary>
        /// <param name="hSourceProcessHandle">
        /// <para>A handle to the process with the handle to be duplicated.</para>
        /// <para>The handle must have the <see cref="PROCESS_DUP_HANDLE"/> access right. For more information, see <a href="https://msdn.microsoft.com/508a17c4-88cd-431a-a102-00180a7f7ab5">Process Security and Access Rights</a>.</para>
        /// </param>
        /// <param name="hSourceHandle">The handle to be duplicated. This is an open object handle that is valid in the context of the source process. For a list of objects whose handles can be duplicated, see the following Remarks section.</param>
        /// <param name="hTargetProcessHandle">A handle to the process that is to receive the duplicated handle. The handle must have the <see cref="PROCESS_DUP_HANDLE"/> access right.</param>
        /// <param name="lpTargetHandle">
        /// <para>Receives the duplicate handle. This handle value is valid in the context of the target process.</para>
        /// <para>If <paramref name="hSourceHandle"/> is a pseudo handle returned by <see cref="GetCurrentProcess"/> or <see cref="GetCurrentThread"/>, <see cref="DuplicateHandle"/> converts it to a real handle to a process or thread, respectively.</para>
        /// </param>
        /// <param name="dwDesiredAccess">
        /// <para>The access requested for the new handle. For the flags that can be specified for each object type, see the following Remarks section.</para>
        /// <para>This parameter is ignored if the <paramref name="dwOptions"/> parameter specifies the <see cref="DUPLICATE_FLAGS.DUPLICATE_SAME_ACCESS"/> flag. Otherwise, the flags that can be specified depend on the type of object whose handle is to be duplicated.</para>
        /// </param>
        /// <param name="bInheritHandle">A variable that indicates whether the handle is inheritable. If <see langword="true"/>, the duplicate handle can be inherited by new processes created by the target process. If <see langword="false"/>, the new handle cannot be inherited.</param>
        /// <param name="dwOptions">Optional actions. This parameter can be zero, or any combination of the values defined in the <see cref="DUPLICATE_FLAGS"/> enumeration type.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>The duplicate handle refers to the same object as the original handle. Therefore, any changes to the object are reflected through both handles. For example, if you duplicate a file handle, the current file position is always the same for both handles.</para>
        /// <para><see cref="DuplicateHandle"/> can be called by either the source process or the target process (or a process that is both the source and target process). For example, a process can use <see cref="DuplicateHandle"/> to create a non-inheritable duplicate of an inheritable handle, or a handle with different access than the original handle.</para>
        /// <para>The source process uses the <see cref="GetCurrentProcess"/> function to get a handle to itself. This handle is a pseudo handle, but <see cref="DuplicateHandle"/> converts it to a real process handle. To get the target process handle, it may be necessary to use some form of interprocess communication (for example, a named pipe or shared memory) to communicate the process identifier to the source process. The source process can use this identifier in the <see cref="OpenProcess"/> function to obtain a handle to the target process.</para>
        /// <para>If the process that calls <see cref="DuplicateHandle"/> is not also the target process, the source process must use interprocess communication to pass the value of the duplicate handle to the target process.</para>
        /// <para><see cref="DuplicateHandle"/> can be used to duplicate a handle between a 32-bit process and a 64-bit process. The resulting handle is appropriately sized to work in the target process. For more information, see <a href="https://msdn.microsoft.com/a573f26c-7577-4ff0-b314-ae0a33274738">Process Interoperability</a>.</para>
        /// <para>
        /// <see cref="DuplicateHandle"/> can duplicate handles to the following types of objects.
        /// <list type="table">
        /// <listheader><term>Object</term><description>Description</description></listheader>
        /// <item><term>Access token</term><description></description>The handle is returned by the <see cref="CreateRestrictedToken"/>, <see cref="DuplicateToken"/>, <see cref="DuplicateTokenEx"/>, <see cref="OpenProcessToken"/>, or <see cref="OpenThreadToken"/> function.</item>
        /// <item><term>Change notification</term><description></description>The handle is returned by the <see cref="FindFirstChangeNotification"/> function.</item>
        /// <item><term>Communications device</term><description></description>The handle is returned by the <see cref="CreateFile"/> function.</item>
        /// <item><term>Console input</term><description>The handle is returned by the <see cref="CreateFile"/> function when <c>CONIN$</c> is specified, or by the <see cref="GetStdHandle"/> function when <see cref="STD_INPUT_HANDLE"/> is specified. Console handles can be duplicated for use only in the same process.</description></item>
        /// <item><term>Console screen buffer</term><description>The handle is returned by the <see cref="CreateFile"/> function when <c>CONOUT$</c> is specified, or by the <see cref="GetStdHandle"/> function when <see cref="STD_OUTPUT_HANDLE"/> is specified. Console handles can be duplicated for use only in the same process.</description></item>
        /// <item><term>Desktop</term><description>The handle is returned by the <see cref="GetThreadDesktop"/> function.</description></item>
        /// <item><term>Event</term><description>The handle is returned by the <see cref="CreateEvent"/> or <see cref="OpenEvent"/> function.</description></item>
        /// <item><term>File</term><description>The handle is returned by the <see cref="CreateFile"/> function.</description></item>
        /// <item><term>File mapping</term><description>The handle is returned by the <see cref="CreateFileMapping"/> function.</description></item>
        /// <item><term>Job</term><description>The handle is returned by the <see cref="CreateJobObject"/> function.</description></item>
        /// <item><term>Mailslot</term><description>The handle is returned by the <see cref="CreateMailslot"/> function.</description></item>
        /// <item><term>Mutex</term><description>The handle is returned by the <see cref="CreateMutex"/> or <see cref="OpenMutex"/> function.</description></item>
        /// <item><term>Pipe</term><description>A named pipe handle is returned by the <see cref="CreateNamedPipe"/> or <see cref="CreateFile"/> function. An anonymous pipe handle is returned by the <see cref="CreatePipe"/> function.</description></item>
        /// <item><term>Process</term><description>The handle is returned by the <see cref="CreateProcess"/>, <see cref="GetCurrentProcess"/>, or <see cref="OpenProcess"/> function.</description></item>
        /// <item><term>Registry key</term><description>The handle is returned by the <see cref="RegCreateKey"/>, <see cref="RegCreateKeyEx"/>, <see cref="RegOpenKey"/>, or <see cref="RegOpenKeyEx"/> function. Note that registry key handles returned by the <see cref="RegConnectRegistry"/> function cannot be used in a call to <see cref="DuplicateHandle"/>.</description></item>
        /// <item><term>Semaphore</term><description>The handle is returned by the <see cref="CreateSemaphore"/> or <see cref="OpenSemaphore"/> function.</description></item>
        /// <item><term>Thread</term><description>The handle is returned by the <see cref="CreateProcess"/>, <see cref="CreateThread"/>, <see cref="CreateRemoteThread"/>, or <see cref="GetCurrentThread"/> function</description></item>
        /// <item><term>Timer</term><description>The handle is returned by the <see cref="CreateWaitableTimer"/> or <see cref="OpenWaitableTimer"/> function.</description></item>
        /// <item><term>Transaction</term><description>The handle is returned by the <see cref="CreateTransaction"/> function.</description></item>
        /// <item><term>Window station</term><description>The handle is returned by the <see cref="GetProcessWindowStation"/> function.</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// You should not use <see cref="DuplicateHandle"/> to duplicate handles to the following objects:
        /// <list type="bullet">
        /// <item>I/O completion ports. No error is returned, but the duplicate handle cannot be used.</item>
        /// <item>Sockets. No error is returned, but the duplicate handle may not be recognized by Winsock at the target process. Also, using <see cref="DuplicateHandle"/> interferes with internal reference counting on the underlying object. To duplicate a socket handle, use the <see cref="WSADuplicateSocket"/> function.</item>
        /// </list>
        /// </para>
        /// <para>
        /// The <paramref name="dwDesiredAccess"/> parameter specifies the new handle's access rights. All objects support the <a href="https://msdn.microsoft.com/f43bccce-0f8c-4732-b678-5fd3218a9f84">standard access rights</a>. Objects may also support additional access rights depending on the object type. For more information, see the following topics:
        /// <list type="bullet">
        /// <item><a href="https://msdn.microsoft.com/6512d128-3b0c-4ba7-8709-2fd225389a40">Desktop Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/en-us/library/Aa364399.aspx">File Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/8bbf7c98-ff83-4ed9-8b82-f08dcd31295c">File-Mapping Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/8d212292-f087-41e4-884e-cec4423dac49">Job Object Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/508a17c4-88cd-431a-a102-00180a7f7ab5">Process Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/266d5c8e-1bcd-48e5-bc06-2fbc956d8658">Registry Key Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/92478298-617c-4672-a1cc-9a8e9af40327">Synchronization Object Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/72709446-5c59-4fac-8dc8-7912906ecc85">Thread Security and Access Rights</a></item>
        /// <item><a href="https://msdn.microsoft.com/b132da61-26b7-4457-9433-4894ca0e640a">Window-Station Security and Access Rights</a></item>
        /// </list>
        /// </para>
        /// <para>In some cases, the new handle can have more access rights than the original handle. However, in other cases, <see cref="DuplicateHandle"/> cannot create a handle with more access rights than the original. For example, a file handle created with the <see cref="GENERIC_READ"/> access right cannot be duplicated so that it has both the <see cref="GENERIC_READ"/> and <see cref="GENERIC_WRITE"/> access right. </para>
        /// <para>
        /// Normally the target process closes a duplicated handle when that process is finished using the handle. To close a duplicated handle from the source process, call <see cref="DuplicateHandle"/> with the following parameters:
        /// <list type="bullet">
        /// <item>Set <paramref name="hSourceProcessHandle"/> to the target process from the <see cref="DuplicateHandle"/> call that created the handle.</item>
        /// <item>Set <paramref name="hSourceHandle"/> to the duplicated handle to close.</item>
        /// <item>Ignore the received value in <paramref name="lpTargetHandle"/>.</item>
        /// <item>Set <paramref name="dwOptions"/> to <see cref="DUPLICATE_FLAGS.DUPLICATE_CLOSE_SOURCE"/>.</item>
        /// </list>
        /// </para>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-duplicatehandle">DuplicateHandle function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CloseHandle"/>
        /// <seealso href="https://msdn.microsoft.com/957cd369-bebf-4e04-9f7e-a936e2e97887">Handle Inheritance</seealso>
        /// <seealso href="https://msdn.microsoft.com/b4769e19-7478-4919-a9d2-8086ece6da70">Handle and Object Functions</seealso>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, SetLastError = true)]
        public static extern bool DuplicateHandle(
            [In] IntPtr hSourceProcessHandle,
            [In] IntPtr hSourceHandle,
            [In] IntPtr hTargetProcessHandle,
            out IntPtr lpTargetHandle,
            [In] ACCESS_MASK dwDesiredAccess,
            [In, MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            [In] DUPLICATE_FLAGS dwOptions
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\handleapi.h, line 43
        #region CompareObjectHandles function
        /// <summary>
        /// Compares two object handles to determine if they refer to the same underlying kernel object.
        /// </summary>
        /// <param name="hFirstObjectHandle">The first object handle to compare.</param>
        /// <param name="hSecondObjectHandle">The second object handle to compare.</param>
        /// <returns>
        /// A Boolean value that indicates if the two handles refer to the same underlying kernel object. <see langword="true"/> if the same, otherwise <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// The <see cref="CompareObjectHandles"/> function is useful to determine if two kernel handles refer to the same kernel object without imposing a requirement that specific access rights be granted to either handle in order to perform the comparison. For example, if a process desires to determine whether a process handle is a handle to the current process, a call to <c>CompareObjectHandles(GetCurrentProcess(), hProcess)</c> can be used to determine if <c>hProcess</c> refers to the current process. Notably, this does not require the use of object-specific access rights, whereas in this example, calling <see cref="GetProcessId"/> to check the process IDs of two process handles imposes a requirement that the handles grant <see cref="PROCESS_QUERY_LIMITED_INFORMATION"/> access. However it is legal for a process handle to not have that access right granted depending on how the handle is intended to be used.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-compareobjecthandles">CompareObjectHandles function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso href="https://msdn.microsoft.com/b4769e19-7478-4919-a9d2-8086ece6da70">Handle and Object Functions</seealso>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, SetLastError = true)]
        public static extern bool CompareObjectHandles(
            [In] IntPtr hFirstObjectHandle,
            [In] IntPtr hSecondObjectHandle
         );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\handleapi.h, line 72
        #region GetHandleInformation function
        /// <summary>
        /// Retrieves certain properties of an object handle.
        /// </summary>
        /// <param name="hObject">
        /// <para>A handle to an object whose information is to be retrieved.</para>
        /// <para>You can specify a handle to one of the following types of objects: access token, console input buffer, console screen buffer, event, file, file mapping, job, mailslot, mutex, pipe, printer, process, registry key, semaphore, serial communication device, socket, thread, or waitable timer.</para>
        /// </param>
        /// <param name="lpdwFlags">Receives a set of bit flags that specify properties of the object handle.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-gethandleinformation">GetHandleInformation function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CloseHandle"/>
        /// <seealso cref="CreateProcess"/>
        /// <seealso href="https://msdn.microsoft.com/b4769e19-7478-4919-a9d2-8086ece6da70">Handle and Object Functions</seealso>
        /// <seealso cref="SetHandleInformation"/>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, SetLastError = true)]
        public static extern bool GetHandleInformation(
            [In] IntPtr hObject,
            out HANDLE_FLAGS lpdwFlags
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\handleapi.h, line 81
        #region SetHandleInformation function
        /// <summary>
        /// Sets certain properties of an object handle.
        /// </summary>
        /// <param name="hObject">
        /// <para>A handle to an object whose information is to be set.</para>
        /// <para>You can specify a handle to one of the following types of objects: access token, console input buffer, console screen buffer, event, file, file mapping, job, mailslot, mutex, pipe, printer, process, registry key, semaphore, serial communication device, socket, thread, or waitable timer.</para>
        /// </param>
        /// <param name="dwMask">A mask that specifies the bit flags to be changed.</param>
        /// <param name="dwFlags">Set of bit flags that specifies properties of the object handle. This parameter can be 0 or one or more of the values defined in the <see cref="HANDLE_FLAGS"/> enumeration type.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is <see langword="true"/>.</para>
        /// <para>If the function fails, the return value is <see langword="false"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
        /// </returns>
        /// <remarks>
        /// To set or clear the associated bit flag in <paramref name="dwFlags"/>, you must set a change mask bit flag in <paramref name="dwMask"/>.
        /// <para>
        /// <list type="table">
        /// <listheader><term>Requirements</term></listheader>
        /// <item><term><strong>Minimum supported client:</strong></term><description>Windows 2000 Professional [desktop apps | UWP apps]</description></item>
        /// <item><term><strong>Minimum supported server:</strong></term><description>Windows 2000 Server [desktop apps | UWP apps]</description></item>
        /// </list>
        /// </para>
        /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-sethandleinformation">SetHandleInformation function</a></para>
        /// </remarks>
        /// <exception cref="DllNotFoundException">The native library containg the function could not be found.</exception>
        /// <exception cref="EntryPointNotFoundException">Unable to find the entry point for the function in the native library.</exception>
        /// <seealso cref="CloseHandle"/>
        /// <seealso cref="CreateProcess"/>
        /// <seealso cref="GetHandleInformation"/>
        /// <seealso href="https://msdn.microsoft.com/b4769e19-7478-4919-a9d2-8086ece6da70">Handle and Object Functions</seealso>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(NativeLibraryNames.Kernel32, CallingConvention = Winapi, SetLastError = true)]
        public static extern bool SetHandleInformation(
            [In] IntPtr hObject,
            [In] HANDLE_FLAGS dwMask,
            [In] HANDLE_FLAGS dwFlags
            );
        #endregion
    }
}
