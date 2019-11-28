using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.Sspi
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int INITIALIZE_SECURITY_CONTEXT_FN_W(
        [Optional] in CredHandle phCredential,  // Cred to base context
        [Optional] in CtxtHandle phContext,     // Existing context (OPT)
        [In, Optional] LPCWSTR pszTargetName,   // Name of target
        [In, MarshalAs(UnmanagedType.U4)]
        ISC_REQ_FLAGS fContextReq,              // Context Requirements
        [In] int Reserved1,                     // Reserved, MBZ
        [In, MarshalAs(UnmanagedType.U4)]
        SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
        [Optional] in SecBufferDesc pInput,     // Input Buffers
        [In] int Reserved2,                     // Reserved, MBZ
        [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
        [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
        [MarshalAs(UnmanagedType.U4)]
        out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
        [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int INITIALIZE_SECURITY_CONTEXT_FN_A(
        [Optional] in CredHandle phCredential,  // Cred to base context
        [Optional] in CtxtHandle phContext,     // Existing context (OPT)
        [In, Optional] LPCSTR pszTargetName,   // Name of target
        [In, MarshalAs(UnmanagedType.U4)]
        ISC_REQ_FLAGS fContextReq,              // Context Requirements
        [In] int Reserved1,                     // Reserved, MBZ
        [In, MarshalAs(UnmanagedType.U4)]
        SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
        [Optional] in SecBufferDesc pInput,     // Input Buffers
        [In] int Reserved2,                     // Reserved, MBZ
        [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
        [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
        [MarshalAs(UnmanagedType.U4)]
        out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
        [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
        );

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int INITIALIZE_SECURITY_CONTEXT_FN(
        [Optional] in CredHandle phCredential,  // Cred to base context
        [Optional] in CtxtHandle phContext,     // Existing context (OPT)
        [In, Optional] LPCTSTR pszTargetName,   // Name of target
        [In, MarshalAs(UnmanagedType.U4)]
        ISC_REQ_FLAGS fContextReq,              // Context Requirements
        [In] int Reserved1,                     // Reserved, MBZ
        [In, MarshalAs(UnmanagedType.U4)]
        SECURITY_DREP_TYPE TargetDataRep,       // Data rep of target
        [Optional] in SecBufferDesc pInput,     // Input Buffers
        [In] int Reserved2,                     // Reserved, MBZ
        [Optional] ref CtxtHandle phNewContext, // (out) New Context handle
        [Optional] ref SecBufferDesc pOutput,   // (inout) Output Buffers
        [MarshalAs(UnmanagedType.U4)]
        out ISC_RET_FLAGS pfContextAttr,        // (out) Context attrs
        [Optional] out TimeStamp ptsExpiry      // (out) Life span (OPT)
        );
}
