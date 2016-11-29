using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp.ImageHelp
{
    /// <summary>
    /// Represents an entry in the function table.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680316.aspx">IMAGE_FUNCTION_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="STACKFRAME64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_FUNCTION_ENTRY
    {
        /// <summary>The image address of the start of the function.</summary>
        public int StartingAddress;
        /// <summary>The image address of the end of the function.</summary>
        public int EndingAddress;
        /// <summary>The image address of the end of the prologue code.</summary>
        public int EndOfPrologue;
    }

    /// <summary>
    /// Represents an entry in the function table.
    /// <para>This type definition exists for 64-bit support.</para>
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation: <a href="https://msdn.microsoft.com/en-us/library/ms680316.aspx">IMAGE_FUNCTION_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="STACKFRAME64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class IMAGE_FUNCTION_ENTRY64
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct Union1
        {
            [FieldOffset(0)]
            public ulong EndOfPrologue;
            [FieldOffset(0)]
            public ulong UnwindInfoAddress;
        }

        /// <summary>The image address of the start of the function.</summary>
        public ulong StartingAddress;
        /// <summary>The image address of the end of the function.</summary>
        public ulong EndingAddress;

        private Union1 u1;

        /// <summary>The image address of the end of the prologue code.</summary>
        public ulong EndOfPrologue
        {
            get { return u1.EndOfPrologue; }
            set { u1.EndOfPrologue = value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ulong UnwindInfoAddress
        {
            get { return u1.UnwindInfoAddress; }
            set { u1.UnwindInfoAddress = value; }
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
