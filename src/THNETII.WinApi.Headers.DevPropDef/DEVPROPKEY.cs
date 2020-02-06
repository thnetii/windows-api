using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.DevPropDef
{
    using static DevPropDefMacros;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 107
    /// <summary>
    /// In Windows Vista and later versions of Windows, the <see cref="DEVPROPKEY"/> structure represents a device property key for a device property in the <a href="https://docs.microsoft.com/windows-hardware/drivers/install/unified-device-property-model--windows-vista-and-later-">unified device property model</a>.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="DEVPROPKEY"/> structure is part of the <a href="https://docs.microsoft.com/windows-hardware/drivers/install/unified-device-property-model--windows-vista-and-later-">unified device property model</a>.</para>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows-hardware/drivers/install/devpropkey">DEVPROPKEY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct DEVPROPKEY : IEquatable<DEVPROPKEY>
    {
        /// <summary>
        /// A <see cref="Guid"/> value that specifies a property category.
        /// </summary>
        public Guid fmtid;
        /// <summary>
        /// A value that uniquely identifies the property within the property category. For internal system reasons, a property identifier must be greater than or equal to two.
        /// </summary>
        public uint pid;

        public override bool Equals(object obj) => obj switch
        {
            DEVPROPKEY otherKey => Equals(in otherKey),
            null => false,
            _ => false,
        };

        public override int GetHashCode() =>
#if NETCOREAPP
            HashCode.Combine(fmtid, pid);
#else
            fmtid.GetHashCode() ^ pid.GetHashCode();
#endif

        public static bool operator ==(in DEVPROPKEY left, in DEVPROPKEY right) =>
            IsEqualDevPropKey(left, right);

        public static bool operator !=(in DEVPROPKEY left, in DEVPROPKEY right) =>
            !(left == right);

        /// <inheritdoc cref="IEquatable{DEVPROPKEY}.Equals(DEVPROPKEY)"/>
        public readonly bool Equals(in DEVPROPKEY other) => this == other;

        bool IEquatable<DEVPROPKEY>.Equals(DEVPROPKEY other) =>
            Equals(in other);
    }
}
