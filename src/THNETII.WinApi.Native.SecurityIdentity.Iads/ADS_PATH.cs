using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.SecurityIdentity.Iads
{
    /// <summary>
    /// The <see cref="ADS_PATH"/> structure is an ADSI representation of the Path attribute syntax.
    /// </summary>
    /// <remarks>
    /// The <see cref="pszPath"/> attribute in represents a file system path.
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/iads/ns-iads-__midl___midl_itf_ads_0000_0000_0005">__MIDL___MIDL_itf_ads_0000_0000_0005  structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADS_PATH
    {
        /// <summary>
        /// Type of file in the file system.
        /// </summary>
        public int Type;

        /// <summary>
        /// A pointer to a null-terminated Unicode string that contains the name of an existing volume in the file system.
        /// </summary>
        public IntPtr pszVolumeName;

        /// <summary>
        /// Gets the null-terminated Unicode string that contains the name of an existing volume in the file system.
        /// </summary>
        /// <returns>A copy of the <see cref="string"/> data located at the location pointed to by <see cref="pszVolumeName"/>.</returns>
        public string GetVolumeName() => pszVolumeName.MarshalAsUnicodeString();

        /// <summary>
        /// A pointer to a null-terminated Unicode string that contains the path of a directory in the file system.
        /// </summary>
        public IntPtr pszPath;

        /// <summary>
        /// Gets the null-terminated Unicode string that contains the path of a directory in the file system.
        /// </summary>
        /// <returns>A copy of the <see cref="string"/> data located at the location pointed to by <see cref="pszPath"/>.</returns>
        public string GetPath() => pszPath.MarshalAsUnicodeString();
    }
}
