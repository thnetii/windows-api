using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Type that defines the native P/Invoke functions exported by the ImageHelp library.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680181.aspx">ImageHlp Functions</a></para>
    /// </remarks>
    public static class ImageHelpFunctions
    {
        #region BindImage function
        /// <summary>
        /// <para>Computes the virtual address of each imported function.</para>
        /// <para>This function has been superseded by the <see cref="BindImageEx"/> function. Use <see cref="BindImageEx"/> to provide a status routine or flags to control the image binding.</para>
        /// </summary>
        /// <param name="ImageName">The name of the file to be bound. This value can be a file name, a partial path, or a full path.</param>
        /// <param name="DllPath">The root of the search path to use if the file specified by the ImageName parameter cannot be opened.</param>
        /// <param name="SymbolPath">The root of the path to search for the file's corresponding symbol file.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>A call to <see cref="BindImage"/> is equivalent to the following call: <c>BindImageEx(0, ImageName, DllPath, SymbolPath, null);</c></para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679278.aspx">BindImage function</a></para>
        /// </remarks>
        /// <seealso cref="BindImageEx"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BindImage(
            [In, MarshalAs(UnmanagedType.LPStr)] string ImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath,
            [In, MarshalAs(UnmanagedType.LPStr)] string SymbolPath
            );
        #endregion
    }
}
