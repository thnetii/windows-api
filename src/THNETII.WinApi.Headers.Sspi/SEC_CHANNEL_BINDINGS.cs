using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    using static SECBUFFER_TYPE;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 383
    /// <summary>
    /// Specifies channel binding information for a security <a href="https://docs.microsoft.com/windows/desktop/SecGloss/c-gly">context</a>.
    /// </summary>
    /// <remarks>
    /// <para>Schannel sets to zero the value of all members of this structure other than <see cref="cbApplicationDataLength"/> and <see cref="dwApplicationDataOffset"/>.</para>
    /// <para><a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">Security support providers</a> (SSPs) other than Schannel should use the values of this structure obtained by a call to the <see cref="QueryContextAttributes"/> (Schannel) function to pass as a <see cref="SecBuffer"/> structure of type <see cref="SECBUFFER_CHANNEL_BINDINGS"/> as one of the buffers in the <em>pInput</em> parameter of a call to the <see cref="AcceptSecurityContext"/> (General) function.</para>
    /// <para>If the value of the <em>ulAttribute</em> parameter of the <see cref="QueryContextAttributes"/> (Schannel) function is <see cref="SECPKG_ATTR_UNIQUE_BINDINGS"/>, the channel binding data specified by this structure begins with "tls-unique:".</para>
    /// <para>If the value of the <em>ulAttribute</em> parameter of the <see cref="QueryContextAttributes"/> (Schannel) function is <see cref="SECPKG_ATTR_ENDPOINT_BINDINGS"/>, the channel binding data specified by this structure begins with "tls-server-end-point:".</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-sec_channel_bindings">SEC_CHANNEL_BINDINGS structure</a></para>
    /// </remarks>
    /// <seealso cref="QueryContextAttributes"/>
    /// <seealso cref="SecPkgContext_Bindings"/>
    [StructLayout(LayoutKind.Sequential)]
    public struct SEC_CHANNEL_BINDINGS
    {
        /// <summary>The type of address (for example, HTTP) specified for the client.</summary>
        public int dwInitiatorAddrType;
        /// <summary>The size, in bytes, of the data that specifies the client address.</summary>
        public int cbInitiatorLength;
        /// <summary>The number of bytes from the beginning of this structure to the beginning of the data that specifies the client address.</summary>
        public int dwInitiatorOffset;
        /// <summary>The type of address (for example, SPN) specified for the server.</summary>
        public int dwAcceptorAddrType;
        /// <summary>The size, in bytes, of the data that specifies the server address.</summary>
        public int cbAcceptorLength;
        /// <summary>The number of bytes from the beginning of this structure to the beginning of the data that specifies the server address.</summary>
        public int dwAcceptorOffset;
        /// <summary>The size, in bytes, of the channel binding data.</summary>
        public int cbApplicationDataLength;
        /// <summary>The size, in bytes, of this structure. The channel binding data immediately follows this structure.</summary>
        public int dwApplicationDataOffset;
    }
}
