using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.WinApi.Diagnostics.DbgHelp
{
    /// <summary>
    /// Represents an entry in the function table on 64-bit Windows.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://msdn.microsoft.com/en-us/library/ms681678.aspx">_IMAGE_RUNTIME_FUNCTION_ENTRY structure</a></para>
    /// </remarks>
    /// <seealso cref="SymFunctionTableAccess64"/>
    [StructLayout(LayoutKind.Sequential)]
    public class _IMAGE_RUNTIME_FUNCTION_ENTRY
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct UnwindUnion
        {
            [FieldOffset(0)]
            public int UnwindInfoAddress;
            [FieldOffset(0)]
            public int UnwindData;
        }

        /// <summary>The address of the start of the function.</summary>
        public int BeginAddress;
        /// <summary>The address of the end of the function.</summary>
        public int EndAddress;

        private UnwindUnion uUnwind;

        /// <summary>
        /// The address of the unwind information for the function.
        /// </summary>
        public int UnwindInfoAddress
        {
            get { return uUnwind.UnwindInfoAddress; }
            set { uUnwind.UnwindInfoAddress = value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int UnwindData
        {
            get { return uUnwind.UnwindData; }
            set { uUnwind.UnwindData = value; }
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
