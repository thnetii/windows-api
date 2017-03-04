using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.Networking.NetworkManagement
{
    /// <summary>
    /// The <see cref="NET_VALIDATE_PASSWORD_HASH"/> structure contains a password hash.
    /// </summary>
    /// <remarks>
    /// <para>The <see cref="NET_VALIDATE_PASSWORD_RESET_INPUT_ARG"/> and <see cref="NET_VALIDATE_PASSWORD_CHANGE_INPUT_ARG"/> structures contain a <see cref="NET_VALIDATE_PASSWORD_HASH"/> structure. The <see cref="NET_VALIDATE_PERSISTED_FIELDS"/> structure contains a pointer to this structure. </para>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/aa370688.aspx">NET_VALIDATE_PASSWORD_HASH structure</a></para>
    /// </remarks>
    /// <seealso cref="NetValidatePasswordPolicy"/>
    [StructLayout(LayoutKind.Sequential)]
    public class NET_VALIDATE_PASSWORD_HASH
    {
        /// <summary>Specifies the length of this structure.</summary>
        public int Length;
        /// <summary>Password hash.</summary>
        public ByteArrayAnySafeHandle Hash;

        /// <summary>
        /// Gets the marshaled byte array stored within <see cref="Hash"/> memory segment.
        /// </summary>
        /// <returns>A managed array instance with exactly <see cref="Length"/> <see cref="byte"/> values.</returns>
        /// <exception cref="ObjectDisposedException">The pointer value of <see cref="Hash"/> refers to a disposed memory segment.</exception>
        /// <exception cref="InvalidOperationException">The pointer value of <see cref="Hash"/> has an invalid value.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><see cref="Length"/> is less than <c>0</c> (zero).</exception>
        public byte[] GetMarshaledByteArray() => ByteArraySafeHandle.ReadValue(Hash, Length);

        /// <summary>
        /// Explicit casting operator for the <see cref="NET_VALIDATE_PASSWORD_HASH"/> type to a managed Byte Array using the <see cref="GetMarshaledByteArray"/> method.
        /// </summary>
        /// <param name="instance">The <see cref="NET_VALIDATE_PASSWORD_HASH"/> instance to convert to a Byte Array.</param>
        /// <returns>A managed array instance with exactly <see cref="Length"/> <see cref="byte"/> values, or <c>null</c> if <paramref name="instance"/> is <c>null</c>.</returns>
        /// <exception cref="ObjectDisposedException">The pointer value of <see cref="Hash"/> refers to a disposed memory segment.</exception>
        /// <exception cref="InvalidOperationException">The pointer value of <see cref="Hash"/> has an invalid value.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><see cref="Length"/> is less than <c>0</c> (zero).</exception>
        public static explicit operator byte[] (NET_VALIDATE_PASSWORD_HASH instance) => instance?.GetMarshaledByteArray();
    }

    public class NET_VALIDATE_PASSWORD_HASH_AnySafeHandle : AnySafeHandle, ISafeHandleReadableAsSimpleStructure<NET_VALIDATE_PASSWORD_HASH>
    {
        protected NET_VALIDATE_PASSWORD_HASH_AnySafeHandle() : base() { }
        protected NET_VALIDATE_PASSWORD_HASH_AnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected NET_VALIDATE_PASSWORD_HASH_AnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public NET_VALIDATE_PASSWORD_HASH_AnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }
}