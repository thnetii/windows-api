using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum VER_TYPE_MASK : int
    {
        /// <summary><see cref="OSVERSIONINFOEXW.dwMinorVersion"/></summary>
        VER_MINORVERSION = WinNTConstants.VER_MINORVERSION,
        /// <summary><see cref="OSVERSIONINFOEXW.dwMajorVersion"/></summary>
        VER_MAJORVERSION = WinNTConstants.VER_MAJORVERSION,
        /// <summary><see cref="OSVERSIONINFOEXW.dwBuildNumber"/></summary>
        VER_BUILDNUMBER = WinNTConstants.VER_BUILDNUMBER,
        /// <summary><see cref="OSVERSIONINFOEXW.dwPlatformId"/></summary>
        VER_PLATFORMID = WinNTConstants.VER_PLATFORMID,
        /// <summary><see cref="OSVERSIONINFOEXW.wServicePackMinor"/></summary>
        VER_SERVICEPACKMINOR = WinNTConstants.VER_SERVICEPACKMINOR,
        /// <summary><see cref="OSVERSIONINFOEXW.wServicePackMajor"/></summary>
        VER_SERVICEPACKMAJOR = WinNTConstants.VER_SERVICEPACKMAJOR,
        /// <summary><see cref="OSVERSIONINFOEXW.SuiteMask"/></summary>
        VER_SUITENAME = WinNTConstants.VER_SUITENAME,
        /// <summary><see cref="OSVERSIONINFOEXW.ProductType"/></summary>
        VER_PRODUCT_TYPE = WinNTConstants.VER_PRODUCT_TYPE,
    }
}
