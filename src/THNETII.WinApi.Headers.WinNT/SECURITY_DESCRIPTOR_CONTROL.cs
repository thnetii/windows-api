using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    [SuppressMessage("Design", "CA1028: Enum Storage should be Int32", Justification = @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 10105")]
    public enum SECURITY_DESCRIPTOR_CONTROL : short
    {
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// <see cref="SID"/> pointed to by the <see cref="SECURITY_DESCRIPTOR.Owner"/> field was provided by a
        /// defaulting mechanism rather than explicitly provided by the
        /// original provider of the security descriptor.  This may
        /// affect the treatment of the SID with respect to inheritence
        /// of an owner.
        /// </summary>
        SE_OWNER_DEFAULTED = WinNTConstants.SE_OWNER_DEFAULTED,
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// <see cref="SID"/> in the <see cref="SECURITY_DESCRIPTOR.Group"/> field was provided by a defaulting mechanism
        /// rather than explicitly provided by the original provider of
        /// the security descriptor.  This may affect the treatment of
        /// the SID with respect to inheritence of a primary group.
        /// </summary>
        SE_GROUP_DEFAULTED = WinNTConstants.SE_GROUP_DEFAULTED,
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// security descriptor contains a discretionary ACL.  If this
        /// flag is set and the <see cref="SECURITY_DESCRIPTOR.Dacl"/> field of the <see cref="SECURITY_DESCRIPTOR"/> is
        /// <see langword="null"/>, then a null ACL is explicitly being specified.
        /// </summary>
        SE_DACL_PRESENT = WinNTConstants.SE_DACL_PRESENT,
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// ACL pointed to by the <see cref="SECURITY_DESCRIPTOR.Dacl"/> field was provided by a defaulting
        /// mechanism rather than explicitly provided by the original
        /// provider of the security descriptor.  This may affect the
        /// treatment of the ACL with respect to inheritence of an ACL.
        /// This flag is ignored if the <see cref="SE_DACL_PRESENT"/> flag is not set.
        /// </summary>
        SE_DACL_DEFAULTED = WinNTConstants.SE_DACL_DEFAULTED,
        /// <summary>
        /// This boolean flag, when set,  indicates that the
        /// security descriptor contains a system ACL pointed to by the
        /// <see cref="SECURITY_DESCRIPTOR.Sacl"/> field.  If this flag is set and the <see cref="SECURITY_DESCRIPTOR.Sacl"/> field of the
        /// <see cref="SECURITY_DESCRIPTOR"/> is <see langword="null"/>, then an empty (but present)
        /// ACL is being specified.
        /// </summary>
        SE_SACL_PRESENT = WinNTConstants.SE_SACL_PRESENT,
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// ACL pointed to by the <see cref="SECURITY_DESCRIPTOR.Sacl"/> field was provided by a defaulting
        /// mechanism rather than explicitly provided by the original
        /// provider of the security descriptor.  This may affect the
        /// treatment of the ACL with respect to inheritence of an ACL.
        /// This flag is ignored if the <see cref="SE_SACL_PRESENT"/> flag is not set.
        /// </summary>
        SE_SACL_DEFAULTED = WinNTConstants.SE_SACL_DEFAULTED,
        SE_DACL_AUTO_INHERIT_REQ = WinNTConstants.SE_DACL_AUTO_INHERIT_REQ,
        SE_SACL_AUTO_INHERIT_REQ = WinNTConstants.SE_SACL_AUTO_INHERIT_REQ,
        SE_DACL_AUTO_INHERITED = WinNTConstants.SE_DACL_AUTO_INHERITED,
        SE_SACL_AUTO_INHERITED = WinNTConstants.SE_SACL_AUTO_INHERITED,
        SE_DACL_PROTECTED = WinNTConstants.SE_DACL_PROTECTED,
        SE_SACL_PROTECTED = WinNTConstants.SE_SACL_PROTECTED,
        SE_RM_CONTROL_VALID = WinNTConstants.SE_RM_CONTROL_VALID,
        /// <summary>
        /// This boolean flag, when set, indicates that the
        /// security descriptor is in self-relative form.  In this form,
        /// all fields of the security descriptor are contiguous in memory
        /// and all pointer fields are expressed as offsets from the
        /// beginning of the security descriptor.  This form is useful
        /// for treating security descriptors as opaque data structures
        /// for transmission in communication protocol or for storage on
        /// secondary media.
        /// </summary>
        SE_SELF_RELATIVE = WinNTConstants.SE_SELF_RELATIVE,
    }

    public static class SECURITY_DESCRIPTOR_CONTROL_EXTENSIONS
    {
        public static ControlFlags AsControlFlags(this SECURITY_DESCRIPTOR_CONTROL ctrl) =>
            (ControlFlags)ctrl;
    }
}
