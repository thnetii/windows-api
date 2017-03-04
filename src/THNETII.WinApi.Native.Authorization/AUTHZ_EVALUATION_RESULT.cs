using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.SafeHandles;

namespace Microsoft.Win32.WinApi.SecurityIdentity.Authorization
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AUTHZ_EVALUATION_RESULT : int
    {
        /// <summary>An audit message that indicates success was generated.</summary>
        AUTHZ_GENERATE_SUCCESS_AUDIT = 0x1,
        /// <summary>An audit message that indicates failure was generated.</summary>
        AUTHZ_GENERATE_FAILURE_AUDIT = 0x2
    }

    public class AuthzEvaluationResultArrayAnySafeHandle : AnySafeHandle, ISafeHandleReadableAsInt32CastArray<AUTHZ_EVALUATION_RESULT>
    {
        protected AuthzEvaluationResultArrayAnySafeHandle() : base() { }
        protected AuthzEvaluationResultArrayAnySafeHandle(bool ownsHandle) : base(ownsHandle) { }
        protected AuthzEvaluationResultArrayAnySafeHandle(IntPtr invalidHandleValue, bool ownsHandle = false) : base(invalidHandleValue, ownsHandle) { }
        public AuthzEvaluationResultArrayAnySafeHandle(IntPtr invalidHandleValue, SafeHandle owningHandle) : base(invalidHandleValue, owningHandle) { }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}