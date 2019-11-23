using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.CredSSP
{
    using static CREDSPP_SUBMIT_TYPE;
    using static CredSSPConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\credssp.h, line 71
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CREDSSP_CRED_EX
    {
        /// <summary>
        /// must be <see cref="CredsspCredEx"/>
        /// </summary>
        public CREDSPP_SUBMIT_TYPE Type; // must be CredsspCredEx
        /// <summary>
        /// must be <see cref="CREDSSP_CRED_EX_VERSION"/>
        /// </summary>
        public int Version; // 
        #region public int Flags;
        internal int FlagsField;
        public CREDSSP_FLAGS Field
        {
            get => (CREDSSP_FLAGS)FlagsField;
            set => FlagsField = (int)value;
        }
        #endregion
        public int Reserved;
        public CREDSSP_CRED Cred;
    }
}
