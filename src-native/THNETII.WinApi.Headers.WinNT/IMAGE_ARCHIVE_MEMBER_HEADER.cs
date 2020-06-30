using System.Runtime.InteropServices;
using System.Text;

using THNETII.WinApi.Helpers;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 17503
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe struct IMAGE_ARCHIVE_MEMBER_HEADER
    {
        #region public fixed byte Name[16];
        internal fixed byte NameField[16];
        /// <summary>
        /// File member name - '/' terminated.
        /// </summary>
        public string Name
        {
            get
            {
                fixed (byte* ptr = NameField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 16, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = NameField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 16, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte Date[12];
        internal fixed byte DateField[12];
        /// <summary>
        /// File member date - decimal. 
        /// </summary>
        public string Date
        {
            get
            {
                fixed (byte* ptr = DateField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 12, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = DateField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 12, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte UserID[6];
        internal fixed byte UserIDField[6];
        /// <summary>
        /// File member user id - decimal. 
        /// </summary>
        public string UserID
        {
            get
            {
                fixed (byte* ptr = UserIDField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 6, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = UserIDField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 6, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte GroupID[6];
        internal fixed byte GroupIDField[6];
        /// <summary>
        /// File member group id - decimal. 
        /// </summary>
        public string GroupID
        {
            get
            {
                fixed (byte* ptr = GroupIDField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 6, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = GroupIDField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 6, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte Mode[8];
        internal fixed byte ModeField[8];
        /// <summary>
        /// File member mode - octal. 
        /// </summary>
        public string Mode
        {
            get
            {
                fixed (byte* ptr = ModeField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 8, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = ModeField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 8, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte Size[10];
        internal fixed byte SizeField[10];
        /// <summary>
        /// File member size - decimal. 
        /// </summary>
        public string Size
        {
            get
            {
                fixed (byte* ptr = SizeField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 10, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = SizeField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 10, Encoding.UTF8);
            }
        }
        #endregion
        #region public fixed byte EndHeader[2];
        internal fixed byte EndHeaderField[2];
        /// <summary>
        /// String to end header.
        /// </summary>
        public string EndHeader
        {
            get
            {
                fixed (byte* ptr = EndHeaderField)
                    return FixedStringBuffer.ToStringZeroTerminated(ptr, 2, Encoding.UTF8);
            }
            set
            {
                fixed (byte* ptr = EndHeaderField)
                    FixedStringBuffer.ToBytesZeroTerminated(value, ptr, 2, Encoding.UTF8);
            }
        }
        #endregion
    }
}
