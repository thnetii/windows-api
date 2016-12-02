using Microsoft.Win32.WindowsProtocols.MsErrRef;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp.ImageHlpFunctions;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHlp
{
    public class LoadedImageHandle : SafeHandle
    {
        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            var api_success = ImageUnload(handle);
            if (api_success)
                return true;

            var system_error_code = (Win32ErrorCode)Marshal.GetLastWin32Error();
            throw new Win32Exception((int)system_error_code);
        }

        public LOADED_IMAGE MarshalAsInstance()
        {
            if (IsClosed)
                throw new ObjectDisposedException(nameof(handle));

            return Marshal.PtrToStructure<LOADED_IMAGE>(handle);
        }

        protected LoadedImageHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }
        protected LoadedImageHandle() : this(ownsHandle: true) { }
    }
}
