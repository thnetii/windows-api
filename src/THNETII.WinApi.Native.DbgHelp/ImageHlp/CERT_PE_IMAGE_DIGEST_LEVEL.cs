using System;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum CERT_PE_IMAGE_DIGEST_LEVEL : int
    {
        /// <summary>Include symbolic debugging information.</summary>
        CERT_PE_IMAGE_DIGEST_DEBUG_INFO = 0x01,
        /// <summary>Include resource information.</summary>
        CERT_PE_IMAGE_DIGEST_RESOURCES = 0x02,
        /// <summary>Include all import information.</summary>
        CERT_PE_IMAGE_DIGEST_ALL_IMPORT_INFO = 0x04,
        /// <summary>include data outside the PE image</summary>
        CERT_PE_IMAGE_DIGEST_NON_PE_INFO = 0x08,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}