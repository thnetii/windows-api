using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.InAddr
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\inaddr.h, line 21
    //
    // IPv4 Internet address
    // This is an 'on-wire' format structure.
    //

    /// <summary>
    /// The <see cref="IN_ADDR"/> structure represents an IPv4 address.
    /// <para><note>The <strong>IPaddr</strong> type definition in IP Helper also represents an IPv4 address and can be cast to an interchangeable <strong>in_addr</strong> structure when needed. The <strong>in_addr</strong> structure in IP Helper has the same syntax and usage as the Windows Sockets <strong>in_addr</strong> structure, and is interchangeable with <strong>in_addr</strong> structure used in Windows sockets. Windows sockets also defines an <strong>IN_ADDR</strong> typedef for the <strong>in_addr</strong> structure.</note></para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/inaddr/ns-inaddr-in_addr">IN_ADDR structure</a></para>
    /// </remarks>
    /// <seealso cref="ARP_SEND_REPLY"/>
    /// <seealso cref="AddIPAddress"/>
    /// <seealso cref="GetBestInterface"/>
    /// <seealso cref="GetRTTAndHopCount"/>
    /// <seealso cref="ICMP_ECHO_REPLY"/>
    /// <seealso cref="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS"/>
    /// <seealso cref="IcmpSendEcho"/>
    /// <seealso cref="IcmpSendEcho2"/>
    /// <seealso cref="SendARP"/>
    /// <seealso cref="in_addr"/>
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public unsafe struct IN_ADDR
    {
        [FieldOffset(0)]
        internal fixed byte S_un_b[4];
        [FieldOffset(0)]
        internal fixed ushort S_un_w[2];
        [FieldOffset(0)]
        internal uint S_addr;

        /// <summary>Address of the host formatted as a 32-bit integer</summary>
        public uint s_addr
        {
            get => S_addr;
            set => S_addr = value;
        }

        /// <summary>host on imp</summary>
        public byte s_host
        {
            get => S_un_b[1];
            set => S_un_b[1] = value;
        }

        /// <summary>network</summary>
        public byte s_net
        {
            get => S_un_b[0];
            set => S_un_b[0] = value;
        }

        /// <summary>imp</summary>
        public ushort s_imp
        {
            get => S_un_w[1];
            set => S_un_w[1] = value;
        }

        /// <summary>imp #</summary>
        public byte s_impno
        {
            get => S_un_b[3];
            set => S_un_b[3] = value;
        }

        /// <summary>logical host</summary>
        public byte s_lh
        {
            get => S_un_b[2];
            set => S_un_b[2] = value;
        }
    }
}
