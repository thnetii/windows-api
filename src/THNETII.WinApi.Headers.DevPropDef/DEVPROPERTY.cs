using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.DevPropDef
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 175
    //
    // DEVPROPERTY structure
    /// <summary>
    /// Describes a property for a software device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DEVPROPERTY
    {
        /// <summary>
        /// A <see cref="DEVPROPCOMPKEY"/> structure that represents a compound key for a property.
        /// </summary>
        public DEVPROPCOMPKEY CompKey;
        /// <summary>
        /// A <see cref="DEVPROPTYPE"/> value that indicates the property type. Valid <see cref="DEVPROPTYPE"/> values are constructed from base <strong>DEVPROP_TYPE_</strong> values, which may be modified by a logical OR with <strong>DEVPROP_TYPEMOD_</strong> values, as appropriate.
        /// </summary>
        public DEVPROPTYPE Type;
        /// <summary>
        /// The size in bytes of the property in <see cref="Buffer"/>.
        /// </summary>
        public int BufferSize;
        internal IntPtr BufferPointer;
        /// <summary>
        /// The buffer that contains the property info.
        /// </summary>
        public unsafe Span<byte> Buffer
        {
            get => new Span<byte>(BufferPointer.ToPointer(), BufferSize);
            set
            {
                fixed (byte* pValue = value)
                    (BufferPointer, BufferSize) = ((IntPtr)pValue, value.Length);
            }
        }
    }
}
