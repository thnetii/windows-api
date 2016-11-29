using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
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
        public static extern bool BindImageEx(
            [In, MarshalAs(UnmanagedType.I4)] BIND_FLAGS Flags,
            [In, MarshalAs(UnmanagedType.LPStr)] string ImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath,
            [In, MarshalAs(UnmanagedType.LPStr)] string SymbolPath,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] StatusRoutine StatusRoutine
            );
        #endregion
        #region CheckSumMappedFile function
        /// <summary>
        /// Computes the checksum of the specified image file.
        /// </summary>
        /// <param name="BaseAddress">The base address of the mapped file. This value is obtained by calling the <see cref="MapViewOfFile"/> function.</param>
        /// <param name="FileLength">The size of the file, in bytes.</param>
        /// <param name="HeaderSum">A variable that receives the original checksum from the image file, or zero if there is an error.</param>
        /// <param name="CheckSum">A variable that receives the computed checksum.</param>
        /// <returns>
        /// If the function succeeds, the return value is a pointer to the <see cref="IMAGE_NT_HEADERS32"/> or <see cref="IMAGE_NT_HEADERS64"/> structure contained in the mapped image.
        /// Your should marshal the pointer value to an <see cref="IMAGE_NT_HEADERS_COMMON"/> instance first to evaluate the signature in the <see cref="IMAGE_OPTIONAL_HEADER_COMMON"/> structure to find whether the image is a 32-bit or 64-bit header.
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="CheckSumMappedFile"/> function computes a new checksum for the file and returns it in the CheckSum parameter. This function is used by any application that creates or modifies an executable image. Checksums are required for kernel-mode drivers and some system DLLs. The linker computes the original checksum at link time, if you use the appropriate linker switch. For more details, see your linker documentation.</para>
        /// <para>It is recommended that all images have valid checksums. It is the caller's responsibility to place the newly computed checksum into the mapped image and update the on-disk image of the file.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679281.aspx">CheckSumMappedFile function</a></para>
        /// </remarks>
        /// <seealso cref="IMAGE_NT_HEADERS32"/>
        /// <seealso cref="IMAGE_NT_HEADERS64"/>
        /// <seealso cref="MapFileAndCheckSum"/>
        /// <seealso cref="MapViewOfFile"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern IntPtr CheckSumMappedFile(
            [In] IntPtr BaseAddress,
            [In] int FileLength,
            out int HeaderSum,
            out int CheckSum
            );
        #endregion
        #region DigestFunction callback function
        /// <summary>
        /// An application-defined callback function used by the <see cref="ImageGetDigestStream"/> function to process data.
        /// </summary>
        /// <param name="refdata">A user-supplied handle to the digest. This value is passed as a parameter to the <see cref="ImageGetDigestStream"/> function.</param>
        /// <param name="pData">The data stream.</param>
        /// <param name="dwLength">The size of the data stream, in bytes.</param>
        /// <returns>If the function succeeds, the return value should be <c>true</c>. If the function fails, the return value should be <c>false</c>.</returns>
        /// <remarks>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679313.aspx">DigestFunction callback function</a></para>
        /// </remarks>
        /// <seealso cref="ImageGetDigestStream"/>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool DigestFunction(
            [In] IntPtr refdata,
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pData,
            [In] int dwLength
            );
        #endregion
        #region GetImageConfigInformation function
        /// <summary>
        /// Locates and returns the load configuration data of an image.
        /// </summary>
        /// <param name="LoadedImage">A reference to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to <see cref="MapAndLoad"/> or <see cref="ImageLoad"/>.</param>
        /// <param name="ImageConfigInformation">An <see cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/> variable that receives the configuration information.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SetImageConfigInformation"/> function locates and changes the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679358.aspx">GetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/>
        /// <seealso cref="LOADED_IMAGE"/>
        /// <seealso cref="SetImageConfigInformation"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetImageConfigInformation(
            [In, MarshalAs(UnmanagedType.LPStruct)] LOADED_IMAGE LoadedImage,
            out IMAGE_LOAD_CONFIG_DIRECTORY32 ImageConfigInformation
            );

        /// <summary>
        /// Locates and returns the load configuration data of an image.
        /// </summary>
        /// <param name="LoadedImage">A reference to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to <see cref="MapAndLoad"/> or <see cref="ImageLoad"/>.</param>
        /// <param name="ImageConfigInformation">An <see cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/> variable that receives the configuration information.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SetImageConfigInformation"/> function locates and changes the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679358.aspx">GetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/>
        /// <seealso cref="LOADED_IMAGE"/>
        /// <seealso cref="SetImageConfigInformation"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetImageConfigInformation(
            [In, MarshalAs(UnmanagedType.LPStruct)] LOADED_IMAGE LoadedImage,
            out IMAGE_LOAD_CONFIG_DIRECTORY64 ImageConfigInformation
            );
        #endregion
        #region GetImageUnusedHeaderBytes function
        /// <summary>
        /// Retrieves the offset and size of the part of the PE header that is currently unused.
        /// </summary>
        /// <param name="LoadedImage">A reference to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to <see cref="MapAndLoad"/> or <see cref="ImageLoad"/>.</param>
        /// <param name="SizeUnusedHeaderBytes">A variable to receive the size, in bytes, of the part of the image's header which is unused.</param>
        /// <returns>
        /// If the function succeeds, the return value is the offset from the base address of the first unused header byte.
        /// If the function fails, the return value is zero. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679359.aspx">GetImageUnusedHeaderBytes function</a></para>
        /// </remarks>
        /// <seealso cref="LOADED_IMAGE"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int GetImageUnusedHeaderBytes(
            [In, MarshalAs(UnmanagedType.LPStruct)] LOADED_IMAGE LoadedImage,
            out int SizeUnusedHeaderBytes
            );
        #endregion
        #region ImageGetDigestStream function
        /// <summary>
        /// Retrieves the requested data from the specified image file.
        /// </summary>
        /// <param name="FileHandle">A handle to the image file. This handle must be opened for <see cref="FileAccess.Read"/> access.</param>
        /// <param name="DigestLevel">The aspects of the image that are to be included in the returned data stream.</param>
        /// <param name="DigestFunction">A callback routine to process the data. For more information, see <see cref="DigestFunction"/>.</param>
        /// <param name="DigestHandle">A user-supplied handle to the digest. This parameter is passed to <paramref name="DigestFunction"/> as the first argument.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="ImageGetDigestStream"/> function returns the data to be digested from a specified image file, subject to the passed <paramref name="DigestLevel"/> parameter. The order of the bytes will be consistent for different calls, which is required to ensure that the same message digest is always produced from the retrieved byte stream.</para>
        /// <para>To ensure cross-platform compatibility, all implementations of this function must behave in a consistent manner with respect to the order in which the various parts of the image file are returned.</para>
        /// <para>Data should be returned in the following order: <list type="number"><item>Image (executable and static data) information.</item> <item>Resource data.</item> <item>Debugging information.</item></list> If any of these are not specified, the remaining parts must be returned in the same order.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680160.aspx">ImageGetDigestStream function</a></para>
        /// </remarks>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImageGetDigestStream(
            [In] SafeFileHandle FileHandle,
            [In, MarshalAs(UnmanagedType.I4)] CERT_PE_IMAGE_DIGEST_LEVEL DigestLevel,
            [In, MarshalAs(UnmanagedType.FunctionPtr)] DigestFunction DigestFunction,
            [In] IntPtr DigestHandle
            );
        #endregion
        #region ImageLoad function
        /// <summary>
        /// Maintains a list of loaded DLLs.
        /// </summary>
        /// <param name="DllName">The name of the image.</param>
        /// <param name="DllPath">The path used to locate the image if the name provided cannot be found. If <c>null</c> is used, then the search path rules set forth in the <see cref="SearchPath"/> function apply.</param>
        /// <returns>
        /// If the function succeeds, the return value is a pointer to a <see cref="LOADED_IMAGE"/> structure.
        /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="ImageLoad"/> function is used to maintain a list of loaded DLLs. If the image has already been loaded, the prior <see cref="LOADED_IMAGE"/> is returned. Otherwise, the new image is added to the list.</para>
        /// <para>The returned non-zero pointer must be deallocated by the <see cref="ImageUnload"/> function.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680209.aspx">ImageLoad function</a></para>
        /// </remarks>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.LPStruct)]
        public static extern IntPtr ImageLoad(
            [In, MarshalAs(UnmanagedType.LPStr)] string DllName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath
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
