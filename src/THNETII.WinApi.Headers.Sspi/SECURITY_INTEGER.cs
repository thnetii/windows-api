using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 161
    /// <summary>
    /// <see cref="SECURITY_INTEGER"/> is a structure that holds a numeric value. It is used in defining other types.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-security_integer">SECURITY_INTEGER structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_INTEGER
    {
        internal LARGE_INTEGER value;

        /// <summary>
        /// Least significant digits.
        /// </summary>
        public uint LowPart
        {
            get => value.LowPart;
            set => this.value.LowPart = value;
        }
        /// <summary>
        /// Most significant digits.
        /// </summary>
        public int HighPart
        {
            get => value.HighPart;
            set => this.value.HighPart = value;
        }
        public long QuadPart
        {
            get => value.QuadPart;
            set => this.value.QuadPart = value;
        }
    }
}
