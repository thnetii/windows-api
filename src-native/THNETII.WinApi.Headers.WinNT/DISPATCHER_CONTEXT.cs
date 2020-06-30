using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4017
    /// <summary>
    /// Define exception dispatch context structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DISPATCHER_CONTEXT_AMD64
    {
        public long ControlPc;
        public long ImageBase;
        public IMAGE_AMD64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
        public long EstablisherFrame;
        public long TargetIp;
        public CONTEXT_AMD64* ContextRecord;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public EXCEPTION_ROUTINE LanguageHandler;
        public void* HandlerData;
        public UNWIND_HISTORY_TABLE_AMD64* HistoryTable;
        public int ScopeIndex;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Fill0;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 4979
    /// <summary>
    /// Define exception dispatch context structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DISPATCHER_CONTEXT_ARM
    {
        public int ControlPc;
        public int ImageBase;
        public IMAGE_ARM_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
        public int EstablisherFrame;
        public int TargetIp;
        public CONTEXT_ARM* ContextRecord;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public EXCEPTION_ROUTINE LanguageHandler;
        public void* HandlerData;
        public UNWIND_HISTORY_TABLE_ARM* HistoryTable;
        public int ScopeIndex;
        #region public bool ControlPcIsUnwound;
        internal byte ControlPcIsUnwoundField;
        public bool ControlPcIsUnwound
        {
            get => ControlPcIsUnwoundField != 0;
            set => ControlPcIsUnwoundField = (byte)(value ? 1 : 0);
        }
        #endregion
        public byte* NonVolatileRegisters;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int Reserved;
    }

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 6173
    /// <summary>
    /// Define exception dispatch context structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DISPATCHER_CONTEXT_ARM64
    {
        public UIntPtr ControlPc;
        public UIntPtr ImageBase;
        public IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
        public UIntPtr EstablisherFrame;
        public UIntPtr TargetIp;
        public ARM64_NT_CONTEXT* ContextRecord;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public EXCEPTION_ROUTINE LanguageHandler;
        public void* HandlerData;
        public UNWIND_HISTORY_TABLE_ARM64* HistoryTable;
        public int ScopeIndex;
        #region public bool ControlPcIsUnwound;
        internal byte ControlPcIsUnwoundField;
        public bool ControlPcIsUnwound
        {
            get => ControlPcIsUnwoundField != 0;
            set => ControlPcIsUnwoundField = (byte)(value ? 1 : 0);
        }
        #endregion
        public byte* NonVolatileRegisters;
    }
}
