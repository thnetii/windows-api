using System;
using System.Runtime.InteropServices;

using THNETII.WinApi.Native.AccCtrl;

namespace THNETII.WinApi.Native.AclApi
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\AclAPI.h, line 32
    /// <summary>
    /// <para>Progress Function</para>
    /// <para>
    /// Caller of tree operation implements this Progress function, then
    /// passes its function pointer to tree operation.
    /// Tree operation invokes Progress function to provide progress and error
    /// information to the caller during the potentially long execution
    /// of the tree operation.  Tree operation provides the name of the object
    /// last processed and the error status of the operation on that object.
    /// Tree operation also passes the current InvokeSetting value.
    /// Caller may change the InvokeSetting value, for example, from "Always"
    /// to "Only On Error."
    /// </para>
    /// </summary>
    /// <param name="pObjectName">name of object just processed</param>
    /// <param name="Status">status of operation on object</param>
    /// <param name="pInvokeSetting">Never, always,</param>
    /// <param name="Args">Caller specific data</param>
    /// <param name="SecuritySet">Whether security was set</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void FN_PROGRESS(
        [In] LPWSTR pObjectName,    // name of object just processed
        [In] int Status,         // status of operation on object
        ref PROG_INVOKE_SETTING    pInvokeSetting, // Never, always,
        [In] IntPtr Args,           // Caller specific data
        [In, MarshalAs(UnmanagedType.Bool)]
        bool SecuritySet     // Whether security was set
        );
}
