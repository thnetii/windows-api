using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.DevPropDef
{
    using static DevPropDefMacros;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\devpropdef.h, line 143
    //
    // DEVPROPCOMPKEY structure
    /// <summary>
    /// This structure represents a compound key for a property.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DEVPROPCOMPKEY : IEquatable<DEVPROPCOMPKEY>
    {
        /// <summary>
        /// A <see cref="DEVPROPKEY"/> structure that represents a key for a property.
        /// </summary>
        public DEVPROPKEY Key;
        /// <summary>
        /// A <see cref="DEVPROPSTORE"/>-typed value that indicates the property store.
        /// </summary>
        public DEVPROPSTORE Store;
        /// <summary>
        /// A string for the property's locale name.
        /// </summary>
        public LPCWSTR LocaleName;

        public override bool Equals(object obj) => obj switch
        {
            DEVPROPCOMPKEY key => this == key,
            null => false,
            _ => false,
        };

        public override int GetHashCode() =>
#if NETCOREAPP
            HashCode.Combine(Key, Store, LocaleName.Pointer);
#else
            Key.GetHashCode() ^ Store.GetHashCode() ^ LocaleName.Pointer.GetHashCode(); 
#endif

        public static bool operator ==(in DEVPROPCOMPKEY left, in DEVPROPCOMPKEY right) =>
            IsEqualDevPropCompKey(left, right);

        public static bool operator !=(DEVPROPCOMPKEY left, DEVPROPCOMPKEY right)
            => !(left == right);

        /// <inheritdoc cref="IEquatable{DEVPROPCOMPKEY}.Equals(DEVPROPCOMPKEY)"/>
        public readonly bool Equals(in DEVPROPCOMPKEY other) => this == other;

        bool IEquatable<DEVPROPCOMPKEY>.Equals(DEVPROPCOMPKEY other) =>
            Equals(in other);
    }
}
