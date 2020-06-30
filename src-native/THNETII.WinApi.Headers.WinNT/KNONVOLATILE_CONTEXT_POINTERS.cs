using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    /// <summary>
    /// Nonvolatile context pointer record.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct KNONVOLATILE_CONTEXT_POINTERS_AMD64
    {
        public M128A* Xmm0;
        public M128A* Xmm1;
        public M128A* Xmm2;
        public M128A* Xmm3;
        public M128A* Xmm4;
        public M128A* Xmm5;
        public M128A* Xmm6;
        public M128A* Xmm7;
        public M128A* Xmm8;
        public M128A* Xmm9;
        public M128A* Xmm10;
        public M128A* Xmm11;
        public M128A* Xmm12;
        public M128A* Xmm13;
        public M128A* Xmm14;
        public M128A* Xmm15;

        public long* Rax;
        public long* Rcx;
        public long* Rdx;
        public long* Rbx;
        public long* Rsp;
        public long* Rbp;
        public long* Rsi;
        public long* Rdi;
        public long* R8;
        public long* R9;
        public long* R10;
        public long* R11;
        public long* R12;
        public long* R13;
        public long* R14;
        public long* R15;
    }

    /// <summary>
    /// Nonvolatile context pointer record.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct KNONVOLATILE_CONTEXT_POINTERS_ARM
    {
        public int* R4;
        public int* R5;
        public int* R6;
        public int* R7;
        public int* R8;
        public int* R9;
        public int* R10;
        public int* R11;
        public int* Lr;

        public ulong* D8;
        public ulong* D9;
        public ulong* D10;
        public ulong* D11;
        public ulong* D12;
        public ulong* D13;
        public ulong* D14;
        public ulong* D15;
    }

    /// <summary>
    /// Nonvolatile context pointer record.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct KNONVOLATILE_CONTEXT_POINTERS_ARM64
    {
        public long* X19;
        public long* X20;
        public long* X21;
        public long* X22;
        public long* X23;
        public long* X24;
        public long* X25;
        public long* X26;
        public long* X27;
        public long* X28;
        public long* Fp;
        public long* Lr;

        public long* D8;
        public long* D9;
        public long* D10;
        public long* D11;
        public long* D12;
        public long* D13;
        public long* D14;
        public long* D15;
    }
}
