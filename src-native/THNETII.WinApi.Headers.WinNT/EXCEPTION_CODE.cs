using THNETII.WinApi.Native.MinWinBase;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Lists the exception codes that are likely to occur due to common programming errors.
    /// </summary>
    /// <remarks>
    /// Other exception codes are likely to occur 
    /// </remarks>
    public enum EXCEPTION_CODE : int
    {
        /// <summary>
        /// The thread tried to read from or write to a virtual address for which it does not have the appropriate access. 
        /// </summary>
        EXCEPTION_ACCESS_VIOLATION = MinWinBaseConstants.EXCEPTION_ACCESS_VIOLATION,
        /// <summary>
        /// The thread tried to access an array element that is out of bounds and the underlying hardware supports bounds checking. 
        /// </summary>
        EXCEPTION_ARRAY_BOUNDS_EXCEEDED = MinWinBaseConstants.EXCEPTION_ARRAY_BOUNDS_EXCEEDED,
        /// <summary>
        /// A breakpoint was encountered. 
        /// </summary>
        EXCEPTION_BREAKPOINT = MinWinBaseConstants.EXCEPTION_BREAKPOINT,
        /// <summary>
        /// The thread tried to read or write data that is misaligned on hardware that does not provide alignment.
        /// For example, 16-bit values must be aligned on 2-byte boundaries;
        /// 32-bit values on 4-byte boundaries, and so on. 
        /// </summary>
        EXCEPTION_DATATYPE_MISALIGNMENT = MinWinBaseConstants.EXCEPTION_DATATYPE_MISALIGNMENT,
        /// <summary>
        /// One of the operands in a floating-point operation is denormal.
        /// A denormal value is one that is too small to represent as a standard floating-point value. 
        /// </summary>
        EXCEPTION_FLT_DENORMAL_OPERAND = MinWinBaseConstants.EXCEPTION_FLT_DENORMAL_OPERAND,
        /// <summary>
        /// The thread tried to divide a floating-point value by a floating-point divisor of zero. 
        /// </summary>
        EXCEPTION_FLT_DIVIDE_BY_ZERO = MinWinBaseConstants.EXCEPTION_FLT_DIVIDE_BY_ZERO,
        /// <summary>
        /// The result of a floating-point operation cannot be represented exactly as a decimal fraction. 
        /// </summary>
        EXCEPTION_FLT_INEXACT_RESULT = MinWinBaseConstants.EXCEPTION_FLT_INEXACT_RESULT,
        /// <summary>
        /// This exception represents any floating-point exception not included in the <see cref="EXCEPTION_CODE"/> enumeration. 
        /// </summary>
        EXCEPTION_FLT_INVALID_OPERATION = MinWinBaseConstants.EXCEPTION_FLT_INVALID_OPERATION,
        /// <summary>
        /// The exponent of a floating-point operation is greater than the magnitude allowed by the corresponding type. 
        /// </summary>
        EXCEPTION_FLT_OVERFLOW = MinWinBaseConstants.EXCEPTION_FLT_OVERFLOW,
        /// <summary>
        /// The stack overflowed or underflowed as the result of a floating-point operation. 
        /// </summary>
        EXCEPTION_FLT_STACK_CHECK = MinWinBaseConstants.EXCEPTION_FLT_STACK_CHECK,
        /// <summary>
        /// The exponent of a floating-point operation is less than the magnitude allowed by the corresponding type. 
        /// </summary>
        EXCEPTION_FLT_UNDERFLOW = MinWinBaseConstants.EXCEPTION_FLT_UNDERFLOW,
        /// <summary>
        /// The thread tried to execute an invalid instruction. 
        /// </summary>
        EXCEPTION_ILLEGAL_INSTRUCTION = MinWinBaseConstants.EXCEPTION_ILLEGAL_INSTRUCTION,
        /// <summary>
        /// The thread tried to access a page that was not present, and the system was unable to load the page. For example, this exception might occur if a network connection is lost while running a program over the network. 
        /// </summary>
        EXCEPTION_IN_PAGE_ERROR = MinWinBaseConstants.EXCEPTION_IN_PAGE_ERROR,
        /// <summary>
        /// The thread tried to divide an integer value by an integer divisor of zero. 
        /// </summary>
        EXCEPTION_INT_DIVIDE_BY_ZERO = MinWinBaseConstants.EXCEPTION_INT_DIVIDE_BY_ZERO,
        /// <summary>
        /// The result of an integer operation caused a carry out of the most significant bit of the result. 
        /// </summary>
        EXCEPTION_INT_OVERFLOW = MinWinBaseConstants.EXCEPTION_INT_OVERFLOW,
        /// <summary>
        /// An exception handler returned an invalid disposition to the exception dispatcher. Programmers using a high-level language such as C should never encounter this exception. 
        /// </summary>
        EXCEPTION_INVALID_DISPOSITION = MinWinBaseConstants.EXCEPTION_INVALID_DISPOSITION,
        /// <summary>
        /// The thread tried to continue execution after a noncontinuable exception occurred. 
        /// </summary>
        EXCEPTION_NONCONTINUABLE_EXCEPTION = MinWinBaseConstants.EXCEPTION_NONCONTINUABLE_EXCEPTION,
        /// <summary>
        /// The thread tried to execute an instruction whose operation is not allowed in the current machine mode. 
        /// </summary>
        EXCEPTION_PRIV_INSTRUCTION = MinWinBaseConstants.EXCEPTION_PRIV_INSTRUCTION,
        /// <summary>
        /// A trace trap or other single-instruction mechanism signaled that one instruction has been executed. 
        /// </summary>
        EXCEPTION_SINGLE_STEP = MinWinBaseConstants.EXCEPTION_SINGLE_STEP,
        /// <summary>
        /// The thread used up its stack. 
        /// </summary>
        EXCEPTION_STACK_OVERFLOW = MinWinBaseConstants.EXCEPTION_STACK_OVERFLOW,
        /// <summary>
        /// Exception code that is likely to occur when debugging console processes. It does not arise because of a programming error. The <see cref="DBG_CONTROL_C"/> exception code occurs when CTRL+C is input to a console process that handles CTRL+C signals and is being debugged. This exception code is not meant to be handled by applications. It is raised only for the benefit of the debugger, and is raised only when a debugger is attached to the console process.
        /// </summary>
        DBG_CONTROL_C = WinNTConstants.DBG_CONTROL_C,
    }
}
