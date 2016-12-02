using Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp;
using System.Runtime.InteropServices;
using Xunit;

using static Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp.ImageHlpFunctions;
using static Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp.IMAGE_OPTIONAL_HDR_MAGIC;

namespace THNETII.WinApi.Native.Test.DbgHelp.ImageHlp
{
    public class ImageHlpFunctionsTest
    {
        [Theory]
        [InlineData("ImageHlp.dll", null)]
        public void ImageLoadIsNotInvalid(string imageName, string imagePath)
        {
            using (var imageHandle = ImageLoad(imageName, imagePath))
            {
                Assert.NotNull(imageHandle);
                Assert.False(imageHandle.IsInvalid);
            }
        }

        [Theory]
        [InlineData("ImageHlp.dll", null)]
        public void ImageLoadMarshalToInstance(string imageName, string imagePath)
        {
            using (var imageHandle = ImageLoad(imageName, imagePath))
            {
                var loadedImage = imageHandle.MarshalAsInstance();
                Assert.NotNull(loadedImage);
            }
        }

        [Theory]
        [InlineData("ImageHlp.dll", null)]
        public void ImageLoadMarshaledInstanceFileHeader(string imageName, string imagePath)
        {
            using (var imageHandle = ImageLoad(imageName, imagePath))
            {
                var loadedImage = imageHandle.MarshalAsInstance();

                var ntHeader = Marshal.PtrToStructure<IMAGE_NT_HEADERS_COMMON>(loadedImage.FileHeader);
                Assert.NotNull(ntHeader);
                Assert.Equal(IMAGE_NT_HEADERS_COMMON.IMAGE_NT_SIGNATURE, ntHeader.Signature);
                Assert.Equal(loadedImage.Characteristics, ntHeader.FileHeader.Characteristics);
                Assert.Equal(loadedImage.NumberOfSections, ntHeader.FileHeader.NumberOfSections);

                Assert.True(
                    ntHeader.OptionalHeader.Magic == IMAGE_NT_OPTIONAL_HDR32_MAGIC ||
                    ntHeader.OptionalHeader.Magic == IMAGE_NT_OPTIONAL_HDR64_MAGIC
                    );
                switch (ntHeader.OptionalHeader.Magic)
                {
                    case IMAGE_NT_OPTIONAL_HDR32_MAGIC:
                        var nt32Header = Marshal.PtrToStructure<IMAGE_NT_HEADERS32>(loadedImage.FileHeader);
                        Assert.Equal(ntHeader.Signature, nt32Header.Signature);
                        Assert.Equal(ntHeader.FileHeader, nt32Header.FileHeader);
                        break;
                    case IMAGE_NT_OPTIONAL_HDR64_MAGIC:
                        var nt64Header = Marshal.PtrToStructure<IMAGE_NT_HEADERS64>(loadedImage.FileHeader);
                        Assert.Equal(ntHeader.Signature, nt64Header.Signature);
                        Assert.Equal(ntHeader.FileHeader, nt64Header.FileHeader);
                        break;
                }
            }
        }

        [Theory]
        [InlineData("ImageHlp.dll", null)]
        public void ImageUnloadMakeHandleClosed(string imageName, string imagePath)
        {
            var imageHandle = ImageLoad(imageName, imagePath);
            using (imageHandle)
            {
                Assert.False(imageHandle.IsClosed);
            }
            Assert.True(imageHandle.IsClosed);
        }
    }
}
