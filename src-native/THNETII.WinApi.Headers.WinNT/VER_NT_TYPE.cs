namespace THNETII.WinApi.Native.WinNT
{
    public enum VER_NT_TYPE : int
    {
        /// <summary>
        /// The operating system is Windows 8, Windows 7, Windows Vista, Windows XP Professional, Windows XP Home Edition, or Windows 2000 Professional.
        /// </summary>
        VER_NT_WORKSTATION = WinNTConstants.VER_NT_WORKSTATION,
        /// <summary>
        /// The system is a domain controller and the operating system is Windows Server 2012 , Windows Server 2008 R2, Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
        /// </summary>
        VER_NT_DOMAIN_CONTROLLER = WinNTConstants.VER_NT_DOMAIN_CONTROLLER,
        /// <summary>
        /// The operating system is Windows Server 2012, Windows Server 2008 R2, Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
        /// <para>Note that a server that is also a domain controller is reported as <see cref="VER_NT_DOMAIN_CONTROLLER"/>, not <see cref="VER_NT_SERVER"/>.</para>
        /// </summary>
        VER_NT_SERVER = WinNTConstants.VER_NT_SERVER,
    }
}
