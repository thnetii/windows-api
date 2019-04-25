using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using THNETII.InteropServices.Bitwise;

using static THNETII.WinApi.Native.WinNT.WinNTConstants;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 8824
    /// <summary>
    /// The <see cref="ACCESS_MASK"/> data type is a 32-bit integer value that defines standard, specific, and generic rights. These rights are used in <a href="https://msdn.microsoft.com/library/windows/desktop/ms721532#-security-access-control-entry-gly"><em>access control entries</em></a> (ACEs) and are the primary means of specifying the requested or granted access to an object.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/secauthz/access-mask">ACCESS_MASK</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/en-us/windows/desktop/secauthz/access-control">Access Control</seealso>
    /// <seealso href="https://docs.microsoft.com/en-us/windows/desktop/secauthz/authorization-structures">Basic Access Control Structures</seealso>
    /// <seealso href="https://docs.microsoft.com/en-us/windows/desktop/secauthz/access-rights-and-access-masks">Access Rights and Access Masks</seealso>
    /// <seealso cref="GENERIC_MAPPING"/>
    [StructLayout(LayoutKind.Sequential)]
    [DebuggerDisplay(nameof(DebuggerDisplay) + "()")]
    public struct ACCESS_MASK : IEquatable<ACCESS_MASK>, IEquatable<int>
    {
        private static readonly Bitfield32 bitsSpecificRights = Bitfield32.FromMask(SPECIFIC_RIGHTS_ALL);

        private static readonly Bitfield32 bitsStandardDelete = Bitfield32.FromMask(DELETE);
        private static readonly Bitfield32 bitsStandardReadControl = Bitfield32.FromMask(READ_CONTROL);
        private static readonly Bitfield32 bitsStandardWriteDac = Bitfield32.FromMask(WRITE_DAC);
        private static readonly Bitfield32 bitsStandardWriteOwner = Bitfield32.FromMask(WRITE_OWNER);
        private static readonly Bitfield32 bitsStandardSynchronize = Bitfield32.FromMask(SYNCHRONIZE);
        private static readonly Bitfield32 bitsStandardRightsRequired = Bitfield32.FromMask(STANDARD_RIGHTS_REQUIRED);
        private static readonly Bitfield32 bitsStandardRead = Bitfield32.FromMask(STANDARD_RIGHTS_READ);
        private static readonly Bitfield32 bitsStandardWrite = Bitfield32.FromMask(STANDARD_RIGHTS_WRITE);
        private static readonly Bitfield32 bitsStandardExecute = Bitfield32.FromMask(STANDARD_RIGHTS_EXECUTE);
        private static readonly Bitfield32 bitsStandardRights = Bitfield32.FromMask(STANDARD_RIGHTS_ALL);

        private static readonly Bitfield32 bitsAccessSystemAcl = Bitfield32.FromMask(ACCESS_SYSTEM_SECURITY);
        private static readonly Bitfield32 bitsMaximumAllowed = Bitfield32.FromMask(MAXIMUM_ALLOWED);
        private static readonly Bitfield32 bitsGenericAll = Bitfield32.FromMask(GENERIC_ALL);
        private static readonly Bitfield32 bitsGenericExecute = Bitfield32.FromMask(GENERIC_EXECUTE);
        private static readonly Bitfield32 bitsGenericWrite = Bitfield32.FromMask(GENERIC_WRITE);
        private static readonly Bitfield32 bitsGenericRead = Bitfield32.FromMask(GENERIC_READ);

        private int value;

        public ACCESS_MASK(int value) : this() => this.value = value;

        /// <summary>
        /// Specific rights. Contains the access mask specific to the object type associated with the mask.
        /// </summary>
        public ushort SpecificRights
        {
            get => (ushort)bitsSpecificRights.ReadMasked(value);
            set => bitsSpecificRights.WriteMasked(ref this.value, value);
        }

        /// <summary>
        /// Standard rights. Contains the object's standard access rights.
        /// </summary>
        public int StandardRights
        {
            get => bitsStandardRights.ReadMasked(value);
            set => bitsStandardRights.WriteMasked(ref this.value, value);
        }

        /// <summary>
        /// Delete access.
        /// </summary>
        public bool StandardDelete
        {
            get => bitsStandardDelete.ReadMasked(value) != 0;
            set => bitsStandardDelete.WriteMasked(ref this.value, value ? DELETE : 0);
        }

        /// <summary>
        /// Read access to the owner, group, and <a href="https://msdn.microsoft.com/library/windows/desktop/ms721573#-security-discretionary-access-control-list-gly"><em>discretionary access control list</em></a> (DACL) of the security descriptor.
        /// </summary>
        public bool StandardReadControl
        {
            get => bitsStandardReadControl.ReadMasked(value) != 0;
            set => bitsStandardReadControl.WriteMasked(ref this.value, value ? READ_CONTROL : 0);
        }

        /// <summary>
        /// Write access to the <a href="https://msdn.microsoft.com/library/windows/desktop/ms721573#-security-discretionary-access-control-list-gly"><em>discretionary access control list</em></a> (DACL).
        /// </summary>
        public bool StandardWriteDac
        {
            get => bitsStandardWriteDac.ReadMasked(value) != 0;
            set => bitsStandardWriteDac.WriteMasked(ref this.value, value ? WRITE_DAC : 0);
        }

        /// <summary>
        /// Write access to owner.
        /// </summary>
        public bool StandardWriteOwner
        {
            get => bitsStandardWriteOwner.ReadMasked(value) != 0;
            set => bitsStandardWriteOwner.WriteMasked(ref this.value, value ? WRITE_OWNER : 0);
        }

        /// <summary>
        /// Synchronize access.
        /// </summary>
        public bool StandardSynchronize
        {
            get => bitsStandardSynchronize.ReadMasked(value) != 0;
            set => bitsStandardSynchronize.WriteMasked(ref this.value, value ? SYNCHRONIZE : 0);
        }

        public bool StandardRightsRequired
        {
            get => bitsStandardRightsRequired.ReadMasked(value) == STANDARD_RIGHTS_REQUIRED;
            set => bitsStandardRightsRequired.WriteMasked(ref this.value, value ? STANDARD_RIGHTS_REQUIRED : 0);
        }

        /// <summary>
        /// <para>Access system security.</para>
        /// <para>
        /// It is used to indicate access to a <a href="https://msdn.microsoft.com/library/windows/desktop/ms721625#-security-system-access-control-list-gly"><em>system access control list</em></a> (SACL).
        /// This type of access requires the calling process to have the <see cref="SE_SECURITY_NAME"/> (Manage auditing and security log) privilege. If this flag is set in the access mask of an audit access ACE (successful or unsuccessful access), the SACL access will be audited.
        /// </para>
        /// </summary>
        public bool AccessSystemAcl
        {
            get => bitsAccessSystemAcl.ReadMasked(value) != 0;
            set => bitsAccessSystemAcl.WriteMasked(ref this.value, value ? ACCESS_SYSTEM_SECURITY : 0);
        }

        /// <summary>
        /// Maximum allowed.
        /// </summary>
        public bool MaximumAllowed
        {
            get => bitsMaximumAllowed.ReadMasked(value) != 0;
            set => bitsMaximumAllowed.WriteMasked(ref this.value, value ? MAXIMUM_ALLOWED : 0);
        }

        /// <summary>
        /// Generic all.
        /// </summary>
        public bool GenericAll
        {
            get => bitsGenericAll.ReadMasked(value) != 0;
            set => bitsGenericAll.WriteMasked(ref this.value, value ? GENERIC_ALL : 0);
        }

        /// <summary>
        /// Generic execute.
        /// </summary>
        public bool GenericExecute
        {
            get => bitsGenericExecute.ReadMasked(value) != 0;
            set => bitsGenericExecute.WriteMasked(ref this.value, value ? GENERIC_EXECUTE : 0);
        }

        /// <summary>
        /// Generic write.
        /// </summary>
        public bool GenericWrite
        {
            get => bitsGenericWrite.ReadMasked(value) != 0;
            set => bitsGenericWrite.WriteMasked(ref this.value, value ? GENERIC_WRITE : 0);
        }

        /// <summary>
        /// Generic read.
        /// </summary>
        public bool GenericRead
        {
            get => bitsGenericRead.ReadMasked(value) != 0;
            set => bitsGenericRead.WriteMasked(ref this.value, value ? GENERIC_READ : 0);
        }

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case ACCESS_MASK access_mask: return this == access_mask;
                case int value: return this == value;
                default: return false;
            }
        }

        public bool Equals(ACCESS_MASK access_mask) => this == access_mask;

        public bool Equals(int value) => this == value;

        public override int GetHashCode() => value.GetHashCode();

        public static bool operator ==(ACCESS_MASK a, ACCESS_MASK b) =>
            a.value == b.value;

        public static bool operator !=(ACCESS_MASK a, ACCESS_MASK b) =>
            a.value != b.value;

        public static bool operator ==(ACCESS_MASK access_mask, int value) =>
            access_mask.value == value;

        public static bool operator !=(ACCESS_MASK access_mask, int value) =>
            access_mask.value != value;

        public static bool operator ==(int value, ACCESS_MASK access_mask) =>
            access_mask.value == value;

        public static bool operator !=(int value, ACCESS_MASK access_mask) =>
            access_mask.value != value;

        private string DebuggerDisplay()
        {
            var builder = new StringBuilder();
            builder.Append(FormattableString.Invariant($"{nameof(SpecificRights)} = 0x{SpecificRights:X4}"));
            if (StandardDelete)
                builder.Append(FormattableString.Invariant($", {nameof(StandardDelete)}"));
            if (StandardReadControl)
                builder.Append(FormattableString.Invariant($", {nameof(StandardReadControl)}"));
            if (StandardWriteDac)
                builder.Append(FormattableString.Invariant($", {nameof(StandardWriteDac)}"));
            if (StandardWriteOwner)
                builder.Append(FormattableString.Invariant($", {nameof(StandardWriteOwner)}"));
            if (StandardSynchronize)
                builder.Append(FormattableString.Invariant($", {nameof(StandardSynchronize)}"));
            if (AccessSystemAcl)
                builder.Append(FormattableString.Invariant($", {nameof(AccessSystemAcl)}"));
            if (MaximumAllowed)
                builder.Append(FormattableString.Invariant($", {nameof(MaximumAllowed)}"));
            if (GenericRead)
                builder.Append(FormattableString.Invariant($", {nameof(GenericRead)}"));
            if (GenericWrite)
                builder.Append(FormattableString.Invariant($", {nameof(GenericWrite)}"));
            if (GenericExecute)
                builder.Append(FormattableString.Invariant($", {nameof(GenericExecute)}"));
            if (GenericAll)
                builder.Append(FormattableString.Invariant($", {nameof(GenericAll)}"));
            builder.Append(FormattableString.Invariant($", Value = 0x{value:X8}"));
            return builder.ToString();
        }
    }
}
