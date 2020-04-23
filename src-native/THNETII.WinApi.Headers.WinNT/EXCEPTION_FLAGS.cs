using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum EXCEPTION_FLAGS : int
    {
        /// <summary>Noncontinuable exception</summary>
        EXCEPTION_NONCONTINUABLE = WinNTConstants.EXCEPTION_NONCONTINUABLE,
        /// <summary>Unwind is in progress</summary>
        EXCEPTION_UNWINDING = WinNTConstants.EXCEPTION_UNWINDING,
        /// <summary>Exit unwind is in progress</summary>
        EXCEPTION_EXIT_UNWIND = WinNTConstants.EXCEPTION_EXIT_UNWIND,
        /// <summary>Stack out of limits or unaligned</summary>
        EXCEPTION_STACK_INVALID = WinNTConstants.EXCEPTION_STACK_INVALID,
        /// <summary>Nested exception handler call</summary>
        EXCEPTION_NESTED_CALL = WinNTConstants.EXCEPTION_NESTED_CALL,
        /// <summary>Target unwind in progress</summary>
        EXCEPTION_TARGET_UNWIND = WinNTConstants.EXCEPTION_TARGET_UNWIND,
        /// <summary>Collided exception handler call</summary>
        EXCEPTION_COLLIDED_UNWIND = WinNTConstants.EXCEPTION_COLLIDED_UNWIND,

        EXCEPTION_UNWIND = WinNTConstants.EXCEPTION_UNWIND,
    }

    public static class EXCEPTION_FLAGS_EXTENSIONS
    {
        public static bool IsUnwinding(this EXCEPTION_FLAGS Flag) =>
            WinNTFunctions.IS_UNWINDING((int)Flag);
        public static bool IsDispatching(this EXCEPTION_FLAGS Flag) =>
            WinNTFunctions.IS_DISPATCHING((int)Flag);
        public static bool IsTargetUnwind(this EXCEPTION_FLAGS Flag) =>
            WinNTFunctions.IS_TARGET_UNWIND((int)Flag);
    }
}
