namespace THNETII.WinApi.Native.AuthZ
{
    public enum AUTHZ_GENERATE_RESULT : int
    {
        /// <summary>
        /// An audit message that indicates success was generated. 
        /// </summary>
        AUTHZ_GENERATE_SUCCESS_AUDIT = AuthZConstants.AUTHZ_GENERATE_SUCCESS_AUDIT,
        /// <summary>
        /// An audit message that indicates failure was generated. 
        /// </summary>
        AUTHZ_GENERATE_FAILURE_AUDIT = AuthZConstants.AUTHZ_GENERATE_FAILURE_AUDIT,
    }
}
