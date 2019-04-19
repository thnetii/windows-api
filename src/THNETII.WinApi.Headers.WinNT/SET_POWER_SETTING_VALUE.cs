using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Runtime;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinNTConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 15460
    [StructLayout(LayoutKind.Sequential)]
    public struct SET_POWER_SETTING_VALUE
    {
        /// <summary>
        /// Version of this structure.  Currently should be set to
        /// <see cref="POWER_SETTING_VALUE_VERSION"/>.
        /// </summary>
        public int Version;

        /// <summary>
        /// GUID representing the power setting being applied.
        /// </summary>
        public Guid Guid;

        /// <summary>
        /// What power state should this setting be applied to?
        /// </summary>
        public SYSTEM_POWER_CONDITION PowerCondition;

        /// <summary>
        /// Length (in bytes) of the <see cref="Data"/> member.
        /// </summary>
        public int DataLength;

        #region public byte[] Data = new byte[DataLength];
        private byte DataField;
        /// <summary>
        /// Data which contains the actual setting value.
        /// </summary>
        public Span<byte> Data => SpanOverRef.GetSpan(ref DataField, DataLength);
        #endregion
    }
}
