using System;

namespace THNETII.WinApi.Helpers
{
    /// <summary>
    /// Provides helper methods to access data that follows header structures in contiguous
    /// memory.
    /// </summary>
    public static class SpanAfterStruct
    {
        /// <summary>
        /// Returns a span of specified type and length that follows after the end of
        /// the specified header structure.
        /// </summary>
        /// <typeparam name="THead">The type of the header structure.</typeparam>
        /// <typeparam name="TData">The type of the data that immediately follows the header.</typeparam>
        /// <param name="header">A reference to the header structure.</param>
        /// <param name="length">The number of <typeparamref name="TData"/> items that follow the <paramref name="header"/>.</param>
        /// <returns>A <see cref="Span{TData}"/> of <typeparamref name="TData"/> items with a length of <paramref name="length"/>.</returns>
        public unsafe static Span<TData> GetSpan<THead, TData>(ref THead header, int length)
            where THead : unmanaged
        {
            fixed (THead* ptr = &header)
            {
                void* pSpan = ptr + 1;
                return new Span<TData>(pSpan, length);
            }
        }
    }
}
