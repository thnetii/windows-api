using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Helpers
{
    using static NativeLibraryNames;

    /// <summary>
    /// Provides helper methods to extend the functionality of the
    /// <see cref="DllImportAttribute"/> and related constructs.
    /// </summary>
    [SuppressMessage("Globalization", "CA2101: Specify marshaling for P/Invoke string arguments", Justification = "Properly specified through CharSet property of DllImport attribute")]
    public static class DllImportHelper
    {
        private static readonly Dictionary<string, IntPtr> nativelibs =
            new Dictionary<string, IntPtr>(StringComparer.OrdinalIgnoreCase);

        [DllImport(Kernel32,
            CallingConvention = CallingConvention.Winapi,
#if NETSTANDARD1_3
            EntryPoint = nameof(LoadLibrary) + "W",
            CharSet = CharSet.Unicode,
#else
            CharSet = CharSet.Auto,
#endif
            SetLastError = true
            )]
        private static extern IntPtr LoadLibrary([In] string lpLibFileName);

        [DllImport(Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Ansi)]
        private static extern IntPtr GetProcAddress(
            [In] IntPtr hModule,
            [In] string lpProcName
            );


        private static IntPtr GetNativeLibraryHandle(string libraryname)
        {
            bool found;
            IntPtr handle;
            lock (nativelibs)
            {
                found = nativelibs.TryGetValue(libraryname, out handle);
            }
            if (!found)
            {
#if !NETSTANDARD1_3 && !NETSTANDARD2_0 && NETCOREAPP
                handle = NativeLibrary.Load(libraryname);
#else
                handle = LoadLibrary(libraryname);
                if (handle == IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error());
#endif
                lock (nativelibs)
                {
                    nativelibs[libraryname] = handle;
                }
            }
            return handle;
        }

        private static IntPtr GetSymbolPointer(string library, string symbol)
        {
            var nativelib = GetNativeLibraryHandle(library);
            IntPtr symbolPtr;
#if !NETSTANDARD1_3 && !NETSTANDARD2_0 && NETCOREAPP
            symbolPtr = NativeLibrary.GetExport(nativelib, symbol);
#else
            symbolPtr = GetProcAddress(nativelib, symbol);
#endif
            return symbolPtr;
        }

        /// <summary>
        /// Creates a new lazily initialized pointer to a function or variable
        /// in a native library.
        /// </summary>
        /// <param name="library">The filename (or path) for the native library containg the exported symbol.</param>
        /// <param name="symbol">The name of the symbol to import.</param>
        /// <returns>A new <see cref="Lazy{IntPtr}"/> that returns the pointer to the specified exported <paramref name="symbol"/> in <paramref name="library"/>.</returns>
        public static Lazy<IntPtr> CreateDllImportLazy(string library, string symbol) =>
            new Lazy<IntPtr>(() => GetSymbolPointer(library, symbol));

    }
}
