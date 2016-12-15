using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class DbgHelpFunctions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        #region EnumDirTree function
        /// <summary>
        /// Enumerates all occurrences of the specified file in the specified directory tree.
        /// </summary>
        /// <param name="hProcess">A handle to a process. This handle must have been previously passed to the <paramref name="SymInitialize"/> function.</param>
        /// <param name="RootPath">The path where the function should begin searching for the file.</param>
        /// <param name="InputPathName">The name of the file to be found. You can specify a partial path.</param>
        /// <param name="OutputPathBuffer">
        /// <para>A reference to a buffer that receives the full path of the file. If the function fails or does not find a matching file, this buffer will still contain the last full path that was found. </para>
        /// <para>This parameter is optional and can be <c>null</c>.</para>
        /// </param>
        /// <param name="Callback">An application-defined callback function, or <c>null</c>. For more information, see <see cref="EnumDirTreeProc"/>.</param>
        /// <param name="CallbackData">The user-defined data or <c>null</c>. This value is passed to the callback function.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The search can be canceled if you register a <see cref="SymRegisterCallbackProc64"/> callback function. For every file operation, <see cref="EnumDirTree"/> calls this callback function with <see cref="CBA_DEFERRED_SYMBOL_LOAD_CANCEL"/>. If the callback function returns <c>true</c>, <see cref="EnumDirTree"/> cancels the search.</para>
        /// <para>All DbgHelp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Redistributable:</strong> DbgHelp.dll 6.0 or later</para>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms679314.aspx">EnumDirTree function</a></para>
        /// </remarks>
        /// <seealso cref="EnumDirTreeProc"/>
        [DllImport("Dbghelp.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = nameof(EnumDirTree) + "W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDirTree(
            [In, Optional] IntPtr hProcess,
            [In, MarshalAs(UnmanagedType.LPTStr)] string RootPath,
            [In, MarshalAs(UnmanagedType.LPTStr)] string InputPathName,
            [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder OutputPathBuffer,
            [In, Optional, MarshalAs(UnmanagedType.FunctionPtr)] EnumDirTreeProc Callback,
            [In, Optional] IntPtr CallbackData
            );
        #endregion
        #region EnumDirTreeProc callback function
        /// <summary>
        /// <para>An application-defined callback function used with the <see cref="EnumDirTree"/> function. It is called every time a match is found.</para>
        /// </summary>
        /// <param name="FilePath">A string value that contains the full path of the file that is found.</param>
        /// <param name="CallerData">A user-defined value specified in <see cref="EnumDirTree"/>, or <see cref="IntPtr.Zero"/>. Typically, this parameter is used by an application to pass a pointer to a data structure that enables the callback function to establish some context.</param>
        /// <returns>
        /// To continue enumeration, the callback function must return <c>false</c>.
        /// To stop enumeration, the callback function must return <c>true</c>.
        /// </returns>
        /// <remarks>
        /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms679315.aspx">EnumDirTreeProc callback function</a></para>
        /// </remarks>
        /// <seealso cref="EnumDirTree"/>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public delegate bool EnumDirTreeProc(
            [In, MarshalAs(UnmanagedType.LPTStr)] string FilePath,
            [In, Optional] IntPtr CallerData
            );
        #endregion
    }
}
