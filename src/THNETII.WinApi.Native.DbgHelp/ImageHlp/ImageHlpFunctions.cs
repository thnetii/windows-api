using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

using static Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp.CHECKSUM_STATUS;

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
        /// <param name="BaseAddress">The base address of the mapped file. This value is obtained by calling the <see cref="System.IO.MemoryMappedFiles.MemoryMappedFile.CreateViewAccessor(long, long, System.IO.MemoryMappedFiles.MemoryMappedFileAccess)"/> function.</param>
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
        /// <seealso cref="System.IO.MemoryMappedFiles.MemoryMappedFile.CreateViewAccessor(long, long, System.IO.MemoryMappedFiles.MemoryMappedFileAccess)"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern IntPtr CheckSumMappedFile(
            [In] SafeMemoryMappedViewHandle BaseAddress,
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
        /// <para>The <see cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY32)"/> function (and overloads) locates and changes the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679358.aspx">GetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/>
        /// <seealso cref="LOADED_IMAGE"/>
        /// <seealso cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY32)"/>
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
        /// <para>The <see cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY64)"/> function (and overloads) locates and changes the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms679358.aspx">GetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/>
        /// <seealso cref="LOADED_IMAGE"/>
        /// <seealso cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY64)"/>
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
        #region ImageUnload function
        /// <summary>
        /// Deallocates resources from a previous call to the <see cref="ImageLoad"/> function.
        /// </summary>
        /// <param name="LoadedImage">A pointer to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to the <see cref="ImageLoad"/> function.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// <para><see cref="ImageLoad"/> and <see cref="ImageUnload"/> share internal data that can be corrupted if multiple consecutive calls to <see cref="ImageLoad"/> are performed. Therefore, make sure that you have called <see cref="ImageLoad"/> only once before calling <see cref="ImageUnload"/>.</para>
        /// </returns>
        /// <remarks>
        /// All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680221.aspx">ImageUnload function</a></para>
        /// </remarks>
        /// <seealso cref="ImageLoad"/>
        /// <seealso cref="LOADED_IMAGE"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImageUnload(
            [In] IntPtr LoadedImage
            );
        #endregion
        #region MapAndLoad function
        /// <summary>
        /// Maps an image and preloads data from the mapped file.
        /// </summary>
        /// <param name="ImageName">The file name of the image (executable file or DLL) that is loaded.</param>
        /// <param name="DllPath">The path used to locate the image if the name provided cannot be found. If this parameter is <c>null</c>, then the search path rules set using the <see cref="SearchPath"/> function apply.</param>
        /// <param name="LoadedImage">A <see cref="LOADED_IMAGE"/> variable that receives information about the image after it is loaded.</param>
        /// <param name="DotDll">The default extension to be used if the image name does not contain a file name extension. If the value is <c>true</c>, a .DLL extension is used. If the value is <c>false</c>, then an .EXE extension is used.</param>
        /// <param name="ReadOnly">The access mode. If this value is <c>true</c>, the file is mapped for read-access only. If the value is <c>false</c>, the file is mapped for read and write access.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="MapAndLoad"/> function maps an image and preloads data from the mapped file. The corresponding function, <see cref="UnMapAndLoad"/>, must be used to deallocate all resources that are allocated by the <see cref="MapAndLoad"/> function. </para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680353.aspx">MapAndLoad function</a></para>
        /// </remarks>
        /// <seealso cref="LOADED_IMAGE"/>
        /// <seealso cref="UnMapAndLoad"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapAndLoad(
            [In, MarshalAs(UnmanagedType.LPStr)] string ImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string DllPath,
            out LOADED_IMAGE LoadedImage,
            [In, MarshalAs(UnmanagedType.Bool)] bool DotDll,
            [In, MarshalAs(UnmanagedType.Bool)] bool ReadOnly
            );
        #endregion
        #region MapFileAndCheckSum function
        /// <summary>
        /// Computes the checksum of the specified file.
        /// </summary>
        /// <param name="Filename">The file name of the file for which the checksum is to be computed.</param>
        /// <param name="HeaderSum">A variable that receives the original checksum from the image file, or zero if there is an error.</param>
        /// <param name="CheckSum">A variable that receives the computed checksum.</param>
        /// <returns>If the function succeeds, the return value is <see cref="CHECKSUM_SUCCESS"/> (0).</returns>
        /// <remarks>
        /// <para>The <see cref="MapFileAndCheckSum"/> function computes a new checksum for the file and returns it in the <paramref name="CheckSum"/> parameter. This function is used by any application that creates or modifies an executable image. Checksums are required for kernel-mode drivers and some system DLLs. The linker computes the original checksum at link time, if you use the appropriate linker switch. For more details, see your linker documentation.</para>
        /// <para>It is recommended that all images have valid checksums. It is the caller's responsibility to place the newly computed checksum into the mapped image and update the on-disk image of the file.</para>
        /// <para>Passing a <paramref name="Filename"/> parameter that does not point to a valid executable image will produce unpredictable results. Any user of this function is encouraged to make sure that a valid executable image is being passed.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><note>The Unicode implementation of this function calls the ASCII implementation and as a result, the function can fail if the codepage does not support the characters in the path. For example, if you pass a non-English Unicode file path, and the default codepage is English, the unrecognized non-English wide chars are converted to "??" and the file cannot be opened (the function returns <see cref="CHECKSUM_OPEN_FAILURE"/>).</note></para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680355.aspx">MapFileAndCheckSum function</a></para>
        /// </remarks>
        /// <seealso cref="CheckSumMappedFile"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern CHECKSUM_STATUS MapFileAndCheckSum(
            [In, MarshalAs(UnmanagedType.LPTStr)] string Filename,
            out int HeaderSum,
            out int CheckSum
            );
        #endregion
        #region ReBaseImage function
        /// <summary>
        /// <para>Changes the load address for the specified image, which reduces the required load time for a DLL.</para>
        /// <para>Alternatively, you can use the Rebase tool. This tool is available in Visual Studio and the <a href="http://go.microsoft.com/fwlink/p/?linkid=84091">Windows SDK</a>.</para>
        /// <para>Note that this function is implemented as a call to the <see cref="ReBaseImage64"/> function.</para>
        /// </summary>
        /// <param name="CurrentImageName">The name of the file to be rebased. You must specify the full path to the file unless the module is in the current working directory of the calling process.</param>
        /// <param name="SymbolPath">The path used to find the corresponding symbol file. Specify this path for executable images that have symbolic information because when image addresses change, the corresponding symbol database file (PDB) may also need to be changed. Note that even if the symbol path is not valid, the function will succeed if it is able to rebases your image.</param>
        /// <param name="fReBase">If this value is <c>true</c>, the image is rebased. Otherwise, the image is not rebased.</param>
        /// <param name="fRebaseSysfileOk">If this value is <c>true</c>, the system image is rebased. Otherwise, the system image is not rebased.</param>
        /// <param name="fGoingDown">If this value is <c>true</c>, the image can be rebased below the given base; otherwise, it cannot.</param>
        /// <param name="CheckImageSize">The maximum size that the image can grow to, in bytes, or zero if there is no limit.</param>
        /// <param name="OldImageSize">A variable that receives the original image size, in bytes.</param>
        /// <param name="OldImageBase">A variable that receives the original image base.</param>
        /// <param name="NewImageSize">A variable that receives the new image size after the rebase operation, in bytes.</param>
        /// <param name="NewImageBase">The base address to use for rebasing the image. If the address is not available and the <paramref name="fGoingDown"/> parameter is set to <c>true</c>, the function finds a new base address and sets this parameter to the new base address. If <paramref name="fGoingDown"/> is <c>false</c>, the function finds a new base address but does not set this parameter to the new base address.</param>
        /// <param name="TimeStamp">
        /// <para>The new time date stamp for the image file header. The value must be represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.</para>
        /// <para>If this parameter is 0, the current file header time date stamp is incremented by 1 second.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="ReBaseImage"/> function changes the desired load address for the specified image. This operation involves reading the entire image and updating all fixups, debugging information, and checksum. You can rebase an image to reduce the required load time for its DLLs. If an application can rely on a DLL being loaded at the desired load address, then the system loader does not have to relocate the image. The image is simply loaded into the application's virtual address space and the <see cref="DllMain"/> function is called, if one is present.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para>You cannot rebase DLLs that link with /DYNAMICBASE or that reside in protected directories, such as the System32 folder.</para>
        /// <para>As an alternative to using this function, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152358">/BASE</a> linker option.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/aa363364.aspx">ReBaseImage function</a></para>
        /// </remarks>
        /// <seealso cref="DllMain"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReBaseImage(
            [In, MarshalAs(UnmanagedType.LPStr)] string CurrentImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string SymbolPath,
            [In, MarshalAs(UnmanagedType.Bool)] bool fReBase,
            [In, MarshalAs(UnmanagedType.Bool)] bool fRebaseSysfileOk,
            [In, MarshalAs(UnmanagedType.Bool)] bool fGoingDown,
            [In] uint CheckImageSize,
            out uint OldImageSize,
            out UIntPtr OldImageBase,
            out uint NewImageSize,
            ref UIntPtr NewImageBase,
            [In] uint TimeStamp
            );
        #endregion
        #region ReBaseImage64 function
        /// <summary>
        /// <para>Changes the load address for the specified image, which reduces the required load time for a DLL.</para>
        /// <para>Alternatively, you can use the Rebase tool. This tool is available in Visual Studio and the <a href="http://go.microsoft.com/fwlink/p/?linkid=84091">Windows SDK</a>.</para>
        /// </summary>
        /// <param name="CurrentImageName">The name of the file to be rebased. You must specify the full path to the file unless the module is in the current working directory of the calling process.</param>
        /// <param name="SymbolPath">The path used to find the corresponding symbol file. Specify this path for executable images that have symbolic information because when image addresses change, the corresponding symbol database file (PDB) may also need to be changed. Note that even if the symbol path is not valid, the function will succeed if it is able to rebases your image.</param>
        /// <param name="fReBase">If this value is <c>true</c>, the image is rebased. Otherwise, the image is not rebased.</param>
        /// <param name="fRebaseSysfileOk">If this value is <c>true</c>, the system image is rebased. Otherwise, the system image is not rebased.</param>
        /// <param name="fGoingDown">If this value is <c>true</c>, the image can be rebased below the given base; otherwise, it cannot.</param>
        /// <param name="CheckImageSize">The maximum size that the image can grow to, in bytes, or zero if there is no limit.</param>
        /// <param name="OldImageSize">A variable that receives the original image size, in bytes.</param>
        /// <param name="OldImageBase">A variable that receives the original image base.</param>
        /// <param name="NewImageSize">A variable that receives the new image size after the rebase operation, in bytes.</param>
        /// <param name="NewImageBase">The base address to use for rebasing the image. If the address is not available and the <paramref name="fGoingDown"/> parameter is set to <c>true</c>, the function finds a new base address and sets this parameter to the new base address. If <paramref name="fGoingDown"/> is <c>false</c>, the function finds a new base address but does not set this parameter to the new base address.</param>
        /// <param name="TimeStamp">
        /// <para>The new time date stamp for the image file header. The value must be represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.</para>
        /// <para>If this parameter is 0, the current file header time date stamp is incremented by 1 second.</para>
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="ReBaseImage64"/> function changes the desired load address for the specified image. This operation involves reading the entire image and updating all fixups, debugging information, and checksum. You can rebase an image to reduce the required load time for its DLLs. If an application can rely on a DLL being loaded at the desired load address, then the system loader does not have to relocate the image. The image is simply loaded into the application's virtual address space and the <see cref="DllMain"/> function is called, if one is present.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para>You cannot rebase DLLs that link with /DYNAMICBASE or that reside in protected directories, such as the System32 folder.</para>
        /// <para>As an alternative to using this function, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=152358">/BASE</a> linker option.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/aa363366.aspx">ReBaseImage64 function</a></para>
        /// </remarks>
        /// <seealso cref="DllMain"/>
        /// <seealso cref="ReBaseImage"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReBaseImage64(
            [In, MarshalAs(UnmanagedType.LPStr)] string CurrentImageName,
            [In, MarshalAs(UnmanagedType.LPStr)] string SymbolPath,
            [In, MarshalAs(UnmanagedType.Bool)] bool fReBase,
            [In, MarshalAs(UnmanagedType.Bool)] bool fRebaseSysfileOk,
            [In, MarshalAs(UnmanagedType.Bool)] bool fGoingDown,
            [In] uint CheckImageSize,
            out uint OldImageSize,
            out UIntPtr OldImageBase,
            out uint NewImageSize,
            ref UIntPtr NewImageBase,
            [In] uint TimeStamp
            );
        #endregion
        #region SetImageConfigInformation function
        /// <summary>
        /// Locates and changes the load configuration data of an image.
        /// </summary>
        /// <param name="LoadedImage">A reference to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to <see cref="MapAndLoad"/> or <see cref="LoadImage"/>. </param>
        /// <param name="ImageConfigInformation">A pointer to an <see cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/> instance.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY32)"/> function locates and returns the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680624.aspx">SetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="GetImageConfigInformation(LOADED_IMAGE, out IMAGE_LOAD_CONFIG_DIRECTORY32)"/>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY32"/>
        /// <seealso cref="LOADED_IMAGE"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetImageConfigInformation(
            [In, MarshalAs(UnmanagedType.LPStruct)] LOADED_IMAGE LoadedImage,
            [In, MarshalAs(UnmanagedType.LPStruct)] IMAGE_LOAD_CONFIG_DIRECTORY32 ImageConfigInformation
            );

        /// <summary>
        /// Locates and changes the load configuration data of an image.
        /// </summary>
        /// <param name="LoadedImage">A reference to a <see cref="LOADED_IMAGE"/> instance that is returned from a call to <see cref="MapAndLoad"/> or <see cref="LoadImage"/>. </param>
        /// <param name="ImageConfigInformation">A pointer to an <see cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/> instance.</param>
        /// <returns>
        /// If the function succeeds, the return value is <c>true</c>.
        /// If the function fails, the return value is <c>false</c>. To retrieve extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        /// </returns>
        /// <remarks>
        /// <para>The <see cref="SetImageConfigInformation(LOADED_IMAGE, IMAGE_LOAD_CONFIG_DIRECTORY64)"/> function locates and returns the load configuration data of an image.</para>
        /// <para>All ImageHlp functions, such as this one, are single threaded. Therefore, calls from more than one thread to this function will likely result in unexpected behavior or memory corruption. To avoid this, you must synchronize all concurrent calls from more than one thread to this function.</para>
        /// <para><strong>Minimum supported client:</strong> Windows XP [desktop apps only]</para>
        /// <para><strong>Minimum supported server:</strong> Windows Server 2003 [desktop apps only]</para>
        /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680624.aspx">SetImageConfigInformation function</a></para>
        /// </remarks>
        /// <seealso cref="GetImageConfigInformation(LOADED_IMAGE, out IMAGE_LOAD_CONFIG_DIRECTORY64)"/>
        /// <seealso cref="IMAGE_LOAD_CONFIG_DIRECTORY64"/>
        /// <seealso cref="LOADED_IMAGE"/>
        [DllImport("Imagehlp.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetImageConfigInformation(
            [In, MarshalAs(UnmanagedType.LPStruct)] LOADED_IMAGE LoadedImage,
            [In, MarshalAs(UnmanagedType.LPStruct)] IMAGE_LOAD_CONFIG_DIRECTORY64 ImageConfigInformation
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
