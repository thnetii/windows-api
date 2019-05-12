using System;

namespace THNETII.WinApi.Helpers
{
    public static class SpanAfterStruct
    {
        public unsafe static Span<TTo> GetSpan<TFrom, TTo>(ref TFrom @this, int length)
            where TFrom : unmanaged
        {
            fixed (TFrom* ptr = &@this)
            {
                void* pSpan = ptr + 1;
                return new Span<TTo>(pSpan, length);
            }
        }
    }
}
