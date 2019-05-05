using System;
using System.Runtime.InteropServices;
using System.Text;

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
                {
                    var span = new Span<byte>(ptr, 16);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 16 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = NameField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 16);
                    if (len < 16)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 12);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 12 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = DateField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 12);
                    if (len < 12)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 6);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 6 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = UserIDField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 6);
                    if (len < 6)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 6);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 6 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = GroupIDField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 6);
                    if (len < 6)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 8);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 8 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = ModeField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 8);
                    if (len < 8)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 10);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 10 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = SizeField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 10);
                    if (len < 10)
                        ptr[len] = 0;
                }
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
                {
                    var span = new Span<byte>(ptr, 2);
                    int len = span.IndexOf((byte)0);
                    return Encoding.UTF8.GetString(ptr, len < 0 ? 2 : len);
                }
            }
            set
            {
                string str = value ?? string.Empty;
                fixed (char* ch = str)
                fixed (byte* ptr = EndHeaderField)
                {
                    int len = Encoding.UTF8.GetBytes(ch, str.Length, ptr, 2);
                    if (len < 2)
                        ptr[len] = 0;
                }
            }
        }
        #endregion
    }
}
