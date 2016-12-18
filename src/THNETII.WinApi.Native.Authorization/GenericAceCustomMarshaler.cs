using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
    public class GenericAceCustomMarshaler
    {
        private readonly string marshalCookie;

        public void CleanUpManagedData(object ManagedObj) { }

        public void CleanUpNativeData(IntPtr pNativeData) { }

        public int GetNativeDataSize() => -1;

        public IntPtr MarshalManagedToNative(object ManagedObj) { throw new NotSupportedException(); }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;
            var aceHeader = Marshal.PtrToStructure<ACE_HEADER>(pNativeData);
            var aceSize = aceHeader?.AceSize ?? 0;
            var aceBytes = new byte[aceSize];
            Marshal.Copy(pNativeData, aceBytes, 0, aceSize);
            return GenericAce.CreateFromBinaryForm(aceBytes, 0);
        }

        public GenericAceCustomMarshaler() { }
        public GenericAceCustomMarshaler(string marshalCookie) { this.marshalCookie = marshalCookie; }
        public static GenericAceCustomMarshaler GetInstance(string marshalCookie) => new GenericAceCustomMarshaler(marshalCookie);
    }
}