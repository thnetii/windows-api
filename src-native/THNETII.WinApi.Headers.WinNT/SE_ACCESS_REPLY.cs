using System;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10458
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SE_ACCESS_REPLY
    {
        public int Size;
        /// <summary>
        /// Indicate the array size of <see cref="GrantedAccess"/> and <see cref="AccessStatus"/>, it only can be either <c>1</c> or <see cref="SE_ACCESS_REQUEST.ObjectTypeListCount"/>.
        /// </summary>
        public int ResultListCount;
        public ACCESS_MASK* PtrGrantedAccess;
        public Span<ACCESS_MASK> GrantedAccess => new Span<ACCESS_MASK>(PtrGrantedAccess, ResultListCount);
        public int* PtrAccessStatus;
        public Span<int> AccessStatus => new Span<int>(PtrAccessStatus, ResultListCount);
        public ACCESS_REASONS* AccessReason;
        public PRIVILEGE_SET** Privileges;
    }
}
