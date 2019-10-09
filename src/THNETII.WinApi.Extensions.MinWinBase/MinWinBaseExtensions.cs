using System;
using System.Security.AccessControl;
using THNETII.WinApi.Native.WinNT;

namespace THNETII.WinApi.Native.MinWinBase
{
    using static WinNTFunctions;

    public static class MinWinBaseExtensions
    {
        // C:\Program Files(x86)\Windows Kits\10\Include\10.0.17134.0\um\minwinbase.h, line 33
        #region MoveMemory macro
        /// <inheritdoc cref="RtlMoveMemory"/>
        public static void MoveMemory(IntPtr Destination, IntPtr Source, UIntPtr Length) =>
            RtlMoveMemory(Destination, Source, Length);
        #endregion
        #region CopyMemory macro
        /// <inheritdoc cref="RtlCopyMemory"/>
        public static void CopyMemory(IntPtr Destination, IntPtr Source, UIntPtr Length) =>
            RtlCopyMemory(Destination, Source, Length);
        #endregion
        #region FillMemory macro
        /// <inheritdoc cref="RtlFillMemory"/>
        public static void FillMemory(IntPtr Destination, UIntPtr Length, int Fill) =>
            RtlFillMemory(Destination, Length, Fill);
        #endregion
        #region ZeroMemory macro
        /// <inheritdoc cref="RtlZeroMemory"/>
        public static void ZeroMemory(IntPtr Destination, UIntPtr Length) =>
            RtlZeroMemory(Destination, Length);
        #endregion

        public static RawSecurityDescriptor MarshalSecurityDescriptor(
            this in SECURITY_ATTRIBUTES attr) =>
            SECURITY_DESCRIPTOR.MarshalToManagedSecurityDescriptor(attr.lpSecurityDescriptor);
    }
}
