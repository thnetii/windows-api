using System;
using System.ComponentModel;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.WinError;

using Xunit;

namespace THNETII.WinApi.Native.Sspi.Test
{
    using static SspiFunctions;
    using static WinErrorConstants;

    public static class EnumerateSecurityPackages
    {
        [FactWindowsOS]
        public static void Can_call_ansi_extern_function()
        {
            int error = EnumerateSecurityPackagesA(
                out Span<SecPkgInfoA> packages
                );
            try
            {
                if (error != SEC_E_OK)
                    throw new Win32Exception(error);
                foreach (ref SecPkgInfoA pkgInfo in packages)
                {
                    _ = pkgInfo.Capabilities;
                    _ = pkgInfo.wVersion;
                    _ = pkgInfo.wRPCID;
                    _ = pkgInfo.cbMaxToken;

                    string name = pkgInfo.Name.MarshalToString();
                    Assert.NotNull(name);
                    Assert.NotEmpty(name);
                    string comment = pkgInfo.Comment.MarshalToString();
                    _ = comment;
                }
            }
            finally
            {
                unsafe
                {
                    fixed (void* pPackages = packages)
                        error = FreeContextBuffer((IntPtr)pPackages);
                    packages = default;
                }
                Assert.Equal(SEC_E_OK, error);
            }
        }

        [FactWindowsOS]
        public static void Can_call_unicode_extern_function()
        {
            int error = EnumerateSecurityPackagesW(
                out Span<SecPkgInfoW> packages
                );
            try
            {
                if (error != SEC_E_OK)
                    throw new Win32Exception(error);
                foreach (ref SecPkgInfoW pkgInfo in packages)
                {
                    _ = pkgInfo.Capabilities;
                    _ = pkgInfo.wVersion;
                    _ = pkgInfo.wRPCID;
                    _ = pkgInfo.cbMaxToken;

                    string name = pkgInfo.Name.MarshalToString();
                    Assert.NotNull(name);
                    Assert.NotEmpty(name);
                    string comment = pkgInfo.Comment.MarshalToString();
                    _ = comment;
                }
            }
            finally
            {
                unsafe
                {
                    fixed (void* pPackages = packages)
                        error = FreeContextBuffer((IntPtr)pPackages);
                    packages = default;
                }
                Assert.Equal(SEC_E_OK, error);
            }
        }
    }
}
