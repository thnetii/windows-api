using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10903
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct TOKEN_BNO_ISOLATION_INFORMATION
    {
        public PWSTR IsolationPrefix;
        internal byte IsolationEnabledValue;
        public bool IsolationEnabled
        {
            get => IsolationEnabledValue != 0;
            set => IsolationEnabledValue = value ? (byte)1 : (byte)0;
        }
    }
}
