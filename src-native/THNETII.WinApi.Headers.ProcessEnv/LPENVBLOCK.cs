using System;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.ProcessEnv
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCK : IConstTerminatedAutoStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCKA : IConstTerminatedAnsiStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LPENVBLOCKW : IConstTerminatedUnicodeStringPointer
    {
        /// <inheritdoc cref="IPointer.Pointer"/>
        public IntPtr Pointer { get; }
    }
}
