using System.Runtime.InteropServices;
using System.Security.Principal;
using THNETII.InteropServices.NativeMemory;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11184
    /// <summary>
    /// Used to represent information related to a thread impersonation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SE_IMPERSONATION_STATE
    {
        public static readonly int SizeOf = SizeOf<SE_IMPERSONATION_STATE>.Bytes;

        /// <summary>
        /// Specifies the size, in bytes, of this structure.
        /// <para>Use the value of the static field <see cref="SizeOf"/>.</para>
        /// </summary>
        public int Length;
        internal byte CopyOnOpenValue;
        public bool CopyOnOpen
        {
            get => CopyOnOpenValue != 0;
            set => CopyOnOpenValue = value ? (byte)1 : (byte)0;
        }
        internal byte EffectiveOnlyValue;
        public bool EffectiveOnly
        {
            get => EffectiveOnlyValue != 0;
            set => EffectiveOnlyValue = value ? (byte)1 : (byte)0;
        }
        public TokenImpersonationLevel Level;
    }
}
