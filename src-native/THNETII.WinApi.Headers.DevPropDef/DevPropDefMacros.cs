using System;
using System.Diagnostics.CodeAnalysis;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.DevPropDef
{
    using static DevPropDefConstants;

    public static class DevPropDefMacros
    {
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 114
        #region IsEqualDevPropKey macro
        public static bool IsEqualDevPropKey(in DEVPROPKEY a, in DEVPROPKEY b) =>
            a.pid == b.pid && a.fmtid == b.fmtid;
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 159
        #region IsEqualLocaleName
        public static bool IsEqualLocaleName<TPtr>(TPtr a, TPtr b)
            where TPtr : struct, IConstTerminatedUnicodeStringPointer =>
            a.Pointer == b.Pointer ||
            (
                a.HasValue() && b.HasValue() &&
                a.GetTerminatedSpan().Equals(b.GetTerminatedSpan(), StringComparison.Ordinal)
            );
        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 163
        #region IsEqualDevPropCompKey macro
        public static bool IsEqualDevPropCompKey(in DEVPROPCOMPKEY a, in DEVPROPCOMPKEY b) =>
            a.Key == b.Key &&
            a.Store == b.Store &&
            IsEqualLocaleName(a.LocaleName, b.LocaleName);

        #endregion
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 200
        #region DEFINE_DEVPROPKEY macro
        /// <summary>
        /// In Windows Vista and later versions of Windows, the <see cref="DEFINE_DEVPROPKEY"/> macro creates a <see cref="DEVPROPKEY"/> structure that represents a device property key in the <a href="https://docs.microsoft.com/windows-hardware/drivers/install/unified-device-property-model--windows-vista-and-later-">unified device property model</a>.
        /// </summary>
        /// <param name="l">A variable that supplies the value of the first argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="w1">A variable that supplies the value of the first argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="w2">A variable that supplies the value of the second argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b1">A variable that supplies the value of the third argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b2">A variable that supplies the value of the fourth argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b3">A variable that supplies the value of the fifth argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b4">A variable that supplies the value of the sixth argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b5">A variable that supplies the value of the seventh argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b6">A variable that supplies the value of the eighth argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b7">A variable that supplies the value of the ninth argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="b8">A variable that supplies the value of the last argument for the <see cref="Guid(int, short, short, byte, byte, byte, byte, byte, byte, byte, byte)"/> constructor that is invoked to set the <see cref="DEVPROPKEY.fmtid"/> field of the returned structure.</param>
        /// <param name="pid">A variable that supplies the value of the <see cref="DEVPROPKEY.pid"/> (property identifier) member of the <see cref="DEVPROPKEY"/> structure. The property identifier must be greater than or equal to two.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="pid"/> is less than <see cref="DEVPROPID_FIRST_USABLE"/>.
        /// </exception>
        /// <seealso cref="DEVPROPKEY"/>
        [SuppressMessage("Globalization", "CA1303: Do not pass literals as localized parameters")]
        public static DEVPROPKEY DEFINE_DEVPROPKEY(int l, short w1, short w2, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8, uint pid) =>
            pid >= DEVPROPID_FIRST_USABLE ? new DEVPROPKEY
            {
                fmtid = new Guid(l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8),
                pid = pid
            }
            : throw new ArgumentOutOfRangeException(nameof(pid), pid, $"Device property ID must be equal to or greater than {nameof(DEVPROPID_FIRST_USABLE)}");
        #endregion
    }
}
