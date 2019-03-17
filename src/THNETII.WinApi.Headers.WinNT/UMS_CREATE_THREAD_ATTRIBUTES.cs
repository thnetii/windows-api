using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    using static WinBase.WinBaseConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11422
    /// <summary>
    /// <para>Specifies attributes for a user-mode scheduling (UMS) worker thread.</para>
    /// <para>This structure is used with the <see cref="UpdateProcThreadAttribute"/> function.</para>
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-ums_create_thread_attributes">UMS_CREATE_THREAD_ATTRIBUTES structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct UMS_CREATE_THREAD_ATTRIBUTES
    {
        /// <summary>
        /// The UMS version for which the application was built. This parameter must be <see cref="UMS_VERSION"/>.
        /// </summary>
        public int UmsVersion;
        /// <summary>
        /// A pointer to a UMS thread context for the worker thread to be created. This pointer is provided by the <see cref="CreateUmsThreadContext"/> function.
        /// </summary>
        public IntPtr UmsContext;
        /// <summary>
        /// A pointer to a UMS completion list. This pointer is provided by the <see cref="CreateUmsCompletionList"/> function. The newly created worker thread is queued to the specified completion list.
        /// </summary>
        public IntPtr UmsCompletionList;
    }
}
