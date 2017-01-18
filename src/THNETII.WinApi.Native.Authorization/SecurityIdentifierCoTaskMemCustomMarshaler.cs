using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class SecurityIdentifierCoTaskMemCustomMarshaler
    {
        /// <summary>
        /// Performs necessary cleanup of the managed data when it is no longer needed.
        /// </summary>
        /// <param name="ManagedObj">The managed object to be destroyed.</param>
        public void CleanUpManagedData(object ManagedObj) { }

        /// <summary>
        /// Performs necessary cleanup of the unmanaged data when it is no longer needed.
        /// </summary>
        /// <param name="pNativeData">A pointer to the unmanaged data to be destroyed. </param>
        public void CleanUpNativeData(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return;
            Marshal.FreeCoTaskMem(pNativeData);
        }

        /// <summary>
        /// Returns the size of the native data to be marshaled.
        /// </summary>
        /// <returns>The size, in bytes, of the native data.</returns>
        int GetNativeDataSize() => -1;

        /// <summary>
        /// Converts the managed data to unmanaged data.
        /// </summary>
        /// <param name="ManagedObj">The managed object to be converted. </param>
        /// <returns>A pointer to the COM view of the managed object.</returns>
        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is SecurityIdentifier ManagedSid)
            {
                var binaryArray = new byte[ManagedSid.BinaryLength];
                ManagedSid.GetBinaryForm(binaryArray, 0);
                var pNativeData = Marshal.AllocCoTaskMem(binaryArray.Length);
                Marshal.Copy(binaryArray, startIndex: 0, destination: pNativeData, length: binaryArray.Length);
                return pNativeData;
            }
            return IntPtr.Zero;
        }

        /// <summary>
        /// Converts the unmanaged data to managed data.
        /// </summary>
        /// <param name="pNativeData">A pointer to the unmanaged data to be wrapped. </param>
        /// <returns>An object that represents the managed view of the COM data.</returns>
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;
            return new SecurityIdentifier(pNativeData);
        }

        public static SecurityIdentifierCoTaskMemCustomMarshaler GetInstance(string marshalCookie) => new SecurityIdentifierCoTaskMemCustomMarshaler();
    }
}