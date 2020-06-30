namespace THNETII.WinApi.Native.WinNT
{
    public enum VER_CONDITION : byte
    {
        /// <summary>
        ///  The current value must be equal to the specified value. 
        /// </summary>
        VER_EQUAL = WinNTConstants.VER_EQUAL,
        /// <summary>
        /// The current value must be greater than the specified value. 
        /// </summary>
        VER_GREATER = WinNTConstants.VER_GREATER,
        /// <summary>
        /// The current value must be greater than or equal to the specified value. 
        /// </summary>
        VER_GREATER_EQUAL = WinNTConstants.VER_GREATER_EQUAL,
        /// <summary>
        /// The current value must be less than the specified value. 
        /// </summary>
        VER_LESS = WinNTConstants.VER_LESS,
        /// <summary>
        /// The current value must be less than or equal to the specified value. 
        /// </summary>
        VER_LESS_EQUAL = WinNTConstants.VER_LESS_EQUAL,
        /// <summary>
        /// All specified product suites must be present in the current system. 
        /// </summary>
        VER_AND = WinNTConstants.VER_AND,
        /// <summary>
        /// At least one of the specified product suites must be present in the current system. 
        /// </summary>
        VER_OR = WinNTConstants.VER_OR,
    }
}
