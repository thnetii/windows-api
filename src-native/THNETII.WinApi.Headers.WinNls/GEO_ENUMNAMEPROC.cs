using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1353
    /// <summary>
    /// An application-defined callback function that processes enumerated geographical location information provided by the <see cref="EnumSystemGeoNames"/> function. The <see cref="GEO_ENUMNAMEPROC"/> type defines a pointer to this callback function.
    /// </summary>
    /// <returns>Returns <see langword="true"/> to continue enumeration or <see langword="false"/> otherwise.</returns>
    /// <remarks>
    /// <para>An <see cref="GEO_ENUMNAMEPROC"/> function can carry out any desired task, and can use the information passed to it in the data parameter for any desired purpose. The application registers this function by passing its address to the <see cref="EnumSystemGeoNames"/> function.</para>
    /// <para>For information about two-letter ISO 3166-1 codes, see <a href="https://www.iso.org/iso-3166-country-codes.html">Country Codes - ISO 3166</a>. For information about numeric UN M.49 codes, see <a href="https://unstats.un.org/unsd/methodology/m49/">Standard country or area codes for statistical use (M49)</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/nc-winnls-geo_enumnameproc">GEO_ENUMNAMEPROC callback function</a></para>
    /// </remarks>
    /// <seealso cref="EnumSystemGeoNames"/>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support">National Language Support</seealso>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-functions">National Language Support Functions</seealso>
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool GEO_ENUMNAMEPROC(
        LPWSTR Arg1,
        IntPtr Arg2
        );
}
