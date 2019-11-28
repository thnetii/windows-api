using System;

namespace THNETII.WinApi.Native.AuthZ
{
    using static AUTHZ_SECURITY_ATTRIBUTE_TYPE;

    [Flags]
    public enum AUTHZ_SECURITY_ATTRIBUTE_FLAGS
    {
        /// <summary>
        /// Attribute must not be inherited across process spawns.
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_NON_INHERITABLE = AuthZConstants.AUTHZ_SECURITY_ATTRIBUTE_NON_INHERITABLE,


        /// <summary>
        /// Attribute value is compared in a case sensitive way. It is valid with string value
        /// or composite type containing string value. For other types of value, this flag
        /// will be ignored. Currently, it is valid with the two types:
        /// <see cref="AUTHZ_SECURITY_ATTRIBUTE_TYPE_STRING"/> and <see cref="AUTHZ_SECURITY_ATTRIBUTE_TYPE_FQBN"/>.
        /// </summary>
        AUTHZ_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = AuthZConstants.AUTHZ_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE,

        AUTHZ_SECURITY_ATTRIBUTE_VALID_FLAGS = AuthZConstants.AUTHZ_SECURITY_ATTRIBUTE_VALID_FLAGS,
    }
}
