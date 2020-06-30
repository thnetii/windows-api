using System;
using System.Collections.Generic;
using System.Text;

namespace THNETII.WinApi.Native.WinIOCtl
{
    public static class WinIOCtlFunctions
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 241
        #region CTL_CODE macro
        /// <summary>
        /// Macro definition for defining IOCTL and FSCTL function control codes.
        /// <para><note>
        /// Note that function codes 0-2047 are reserved for Microsoft Corporation, and
        /// 2048-4095 are reserved for customers.
        /// </note></para>
        /// </summary>
        public static int CTL_CODE(int DeviceType, int Function, int Method, int Access) =>
            (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 251
        #region DEVICE_TYPE_FROM_CTL_CODE macro
        /// <summary>
        /// Macro to extract device type out of the device io control code
        /// </summary>
        public static int DEVICE_TYPE_FROM_CTL_CODE(int ctrlCode) =>
            (int)(((uint)ctrlCode & 0xffff0000) >> 16);
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winioctl.h, line 256
        #region METHOD_FROM_CTL_CODE macro
        /// <summary>
        /// Macro to extract buffering method out of the device io control code
        /// </summary>
        public static int METHOD_FROM_CTL_CODE(int ctrlCode) => ctrlCode & 3;
        #endregion
    }
}
