using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.NativeMemory;
using THNETII.WinApi.Native.SecurityIdentity.Iads;

namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices.AdsProp
{
    /// <summary>
    /// The <see cref="ADSPROPINITPARAMS"/> structure is used with the <see cref="ADsPropGetInitInfo"/> function to obtain object data that a display specifier applies to.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/adsprop/ns-adsprop-_adspropinitparams">_ADSPROPINITPARAMS structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ADSPROPINITPARAMS
    {
        /// <summary>
        /// Gets the size, in bytes, of the <see cref="ADSPROPINITPARAMS"/> structure.
        /// </summary>
        public static int Size { get; } = SizeOf<ADSPROPINITPARAMS>.Bytes;

        /// <summary>
        /// The size, in bytes, of the <see cref="ADSPROPINITPARAMS"/> structure. Set this value to <see cref="Size"/> before calling <see cref="ADsPropGetInitInfo"/>.
        /// </summary>
        public int dwSize;

        /// <summary>
        /// Reserved.
        /// </summary>
        public int dwFlags;

        /// <summary>
        /// Contains an <see cref="HRESULT"/> value that specifies the result of the bind/get operation. If this value does not equal <see cref="S_OK"/>, then the remaining structure members are not initialized and should be ignored.
        /// </summary>
        public int hr;

        public IntPtr pDsObj;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwzCN;

        public IntPtr pWritableAttrs;

        public ref ADS_ATTR_INFO refWritableAttrs =>
            ref pWritableAttrs.AsRefStruct<ADS_ATTR_INFO>();
    }
}
