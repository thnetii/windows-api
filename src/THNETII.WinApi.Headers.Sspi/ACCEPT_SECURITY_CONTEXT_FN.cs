using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int ACCEPT_SECURITY_CONTEXT_FN(
        [Optional] in CredHandle phCredential,  // Cred to base context
        [Optional] in CtxtHandle phContext,     // Existing context (OPT)
        [Optional] in SecBufferDesc pInput,     // Input buffer
        [In, MarshalAs(UnmanagedType.U4)]
        ASC_REQ_FLAGS fContextReq,              // Context Requirements
        [In, MarshalAs(UnmanagedType.U4)]
        SECURITY_DREP_TYPE TargetDataRep,       // Target Data Rep
        [Optional] ref CtxtHandle phNewContext, // (out) New context handle
        [Optional] ref SecBufferDesc pOutput,   // (inout) Output buffers
        [MarshalAs(UnmanagedType.U4)]
        out ASC_RET_FLAGS pfContextAttr,        // (out) Context attributes
        [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
        );
}
