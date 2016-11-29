using System;
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
        #region BindImageEx function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [Flags]
        public enum BIND_FLAGS : int
        {
            /// <summary>Do not generate a new import address table. </summary>
            BIND_NO_BOUND_IMPORTS = 0x00000001,
            /// <summary>Do not make changes to the file.</summary>
            BIND_NO_UPDATE = 0x00000002,
            /// <summary>Bind all images in the call tree for this file.</summary>
            BIND_ALL_IMAGES = 0x00000004,
            /// <summary>Do not discard DLL information in the cache between calls. This improves performance when binding a large number of images.</summary>
            BIND_CACHE_IMPORT_DLLS = 0x00000008,
            BIND_REPORT_64BIT_VA = 0x00000010,
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// Computes the virtual address of each function that is imported.
        /// </summary>
        /// <param name="Flags">The bind options.</param>
        /// <param name="ImageName">The name of the file to be bound. This value can be a file name, a partial path, or a full path.</param>
        /// <param name="DllPath">The root of the search path to use if the file specified by the ImageName parameter cannot be opened.</param>
        /// <param name="SymbolPath">The root of the path to search for the file's corresponding symbol file.</param>
        /// <param name="StatusRoutine">A pointer to a status routine. The status routine is called during the progress of the image binding. For more information, see <see cref="StatusRoutine"/>.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The process of binding an image consists of computing the virtual address of each imported function. The computed virtual address is then saved in the importing image's Import Address Table (IAT). As a result, the image is loaded much faster, particularly if it uses many DLLs, because the system loader does not have to compute the address of each imported function.</para>
        /// <para>If a corresponding symbol file can be located, its time stamp and checksum are updated.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679279.aspx">BindImageEx function</a></para>
        /// </remarks>
        /// <seealso cref="StatusRoutine"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BindImage(
            [In, MarshalAs(UnmanagedType.I4)] BIND_FLAGS Flags,
            [In, MarshalAs(UnmanagedType.LPStr)] string ImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath,
            [In, MarshalAs(UnmanagedType.LPStr)] string SymbolPath,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] StatusRoutine StatusRoutine
            );
        #endregion
        #region StatusRoutine callback function
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public enum IMAGEHLP_STATUS_REASON
        {
            /// <summary>Out of memory. The Parameter value is the number of bytes in the allocation attempt.</summary>
            BindOutOfMemory,
            /// <summary>The relative virtual address is invalid for the image. The Parameter value is not used.</summary>
            BindRvaToVaFailed,
            /// <summary>No room in the image for new format import table. The Parameter value is not used.</summary>
            BindNoRoomInImage,
            /// <summary>Module import failed. The Parameter value is not used.</summary>
            BindImportModuleFailed,
            /// <summary>Procedure import failed. The Parameter value is the name of the function.</summary>
            BindImportProcedureFailed,
            /// <summary>Module import is starting. The Parameter value is not used.</summary>
            BindImportModule,
            /// <summary>Procedure import is starting. The Parameter value is the name of the function.</summary>
            BindImportProcedure,
            /// <summary>The Parameter value is the name of the function forwarded.</summary>
            BindForwarder,
            /// <summary>The Parameter value is the name of the function not forwarded.</summary>
            BindForwarderNOT,
            /// <summary>Image modified. The Parameter value is not used.</summary>
            BindImageModified,
            /// <summary>File headers expanded. The Parameter value is the number of bytes</summary>
            BindExpandFileHeaders,
            /// <summary>Binding is complete. For more information on the Parameter value, see the following Remarks section.</summary>
            BindImageComplete,
            /// <summary>Checksum did not match. The Parameter value is the name of the symbol file.</summary>
            BindMismatchedSymbols,
            /// <summary>Symbol file was not updated. The Parameter value is the name of the symbol file not updated.</summary>
            BindSymbolsNotUpdated,
            BindImportProcedure32,
            BindImportProcedure64,
            BindForwarder32,
            BindForwarder64,
            BindForwarderNOT32,
            BindForwarderNOT64
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// <para>An application-defined callback function used with the <see cref="BindImageEx"/> function. The status routine is called during the process of the image binding.</para>
        /// </summary>
        /// <param name="Reason">The current status of the bind operation.</param>
        /// <param name="ImageName">The name of the file to be bound. This value can be a file name, a partial path, or a full path.</param>
        /// <param name="DllPath">The name of the DLL.</param>
        /// <param name="Va">The computed virtual address.</param>
        /// <param name="Parameter">Any additional status information. This value depends on the value of the <paramref name="Reason"/> parameter.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680653.aspx">StatusRoutine callback function</a></para>
        /// </remarks>
        /// <seealso cref="BindImageEx"/>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool StatusRoutine(
            [In] IMAGEHLP_STATUS_REASON Reason,
            [In, MarshalAs(UnmanagedType.LPStr)] string ImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath,
            [In] UIntPtr Va,
            [In] UIntPtr Parameter
            );
        #endregion
    }
}
