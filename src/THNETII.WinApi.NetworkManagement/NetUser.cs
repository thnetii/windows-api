using Microsoft.Win32.WinApi.WinError;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.LanManConstants;
using static Microsoft.Win32.WinApi.Networking.NetworkManagement.NetworkManagementFunctions;
using static Microsoft.Win32.WinApi.WinError.Win32ErrorCode;
using static THNETII.WinApi.Networking.NetworkManagement.NetUserEnumFilter;
using Microsoft.Win32.WinApi.Networking.NetworkManagement;
using THNETII.InteropServices.SafeHandles;
using System.Linq;

namespace THNETII.WinApi.Networking.NetworkManagement
{
    public class NetUser
    {
        private int level = -1;
        private string servername;
        private string username;
        private USER_INFO_0 usri0;
        private USER_INFO_1 usri1;
        private USER_INFO_2 usri2;

        /// <summary>
        /// Gets the current information level.
        /// </summary>
        /// <remarks>
        /// Information that is fetched from the system is cached. The information level specifies how much information is currently cached.
        /// </remarks>
        public int CurrentLevel => level;

        public static IEnumerable<NetUser> Enumerate(string servername = null, int level = 0, NetUserEnumFilter filter = NoFilter)
        {
            Win32ErrorCode netStatus;
            IntPtr resume_handle = IntPtr.Zero;
            do
            {
                netStatus = NetUserEnum(servername, level, filter.AsNative(), out var netEnumBuffer, MAX_PREFERRED_LENGTH, out int entriesread, out int totalentries, ref resume_handle);
                switch (netStatus)
                {
                    default:
                        throw new Win32Exception((int)netStatus);

                    case NERR_Success:
                    case ERROR_MORE_DATA:
                        break;
                }

                using (netEnumBuffer)
                {
                    foreach (NetUser netUser in CreateNetUserArrayFromBuffer(servername, level, entriesread, netEnumBuffer))
                        yield return netUser;
                }
            } while (netStatus == ERROR_MORE_DATA);
        }

        private static IEnumerable<NetUser> CreateNetUserArrayFromBuffer(string servername, int level, int entriesread, UserInfoArrayNetApiBufferHandle netapiBuffer)
        {
            switch (level)
            {
                case 0: return netapiBuffer.AsLevel0Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 1: return netapiBuffer.AsLevel1Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 2: return netapiBuffer.AsLevel2Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 3: return netapiBuffer.AsLevel3Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 10: return netapiBuffer.AsLevel10Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 11: return netapiBuffer.AsLevel11Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                case 20: return netapiBuffer.AsLevel20Buffer().ReadValue(entriesread).Select(u => Create(servername, u));
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, "Unknown User Info level. The returned data from the system cannot be represented, because its format is unknown.");
            }
        }

        private static NetUser Create(string servername, USER_INFO_0 u)
        {
            return new NetUser(servername, u.usri0_name)
            {
                level = 0,
                usri0 = u
            };
        }

        private static NetUser Create(string servername, USER_INFO_1 u)
        {
            return new NetUser(servername, u.usri1_name)
            {
                level = 1,
                usri1 = u
            };
        }

        private static NetUser Create(string servername, USER_INFO_2 u)
        {
            return new NetUser(servername, u.usri2_name)
            {
                level = 2,
                usri2 = u
            };
        }

        private static NetUser Create(string servername, USER_INFO_3 u)
        {
            throw new NotImplementedException();
        }

        private static NetUser Create(string servername, USER_INFO_10 u)
        {
            throw new NotImplementedException();
        }

        private static NetUser Create(string servername, USER_INFO_11 u)
        {
            throw new NotImplementedException();
        }

        private static NetUser Create(string servername, USER_INFO_20 u)
        {
            throw new NotImplementedException();
        }

        public NetUser(string username) : this(null, username) { }
        public NetUser(string servername, string username)
        {
            this.servername = servername;
            this.username = username;
        }

        /// <summary>
        /// Gets or sets the name of the user account.
        /// </summary>
        public string Name
        {
            get
            {
                switch (level)
                {
                    case 0:
                        if (usri0 == null) goto default;
                        return usri0.usri0_name;
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_name;
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_name;
                    default:
                        GetInfo(0);
                        return Name;
                }
            }
            set
            {
                SetInfo(0, new USER_INFO_0 { usri0_name = value });
                username = value;
            }
        }

        /// <summary>
        /// Gets the amount of time that has elapsed since the user account password was last changed.
        /// </summary>
        public TimeSpan PasswordAge
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.PasswordAge;
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.PasswordAge;
                    default:
                        GetInfo(1);
                        return PasswordAge;
                }
            }
        }

        /// <summary>
        /// Gets or sets the level of privilege assigned to the user account.
        /// </summary>
        public NetUserPrivilegeLevel PrivilegeLevel
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_priv.AsManaged();
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_priv.AsManaged();
                    default:
                        GetInfo(1);
                        return PrivilegeLevel;
                }
            }
            set { SetInfo(1005, new USER_INFO_1005 { usri1005_priv = value.AsNative() }); }
        }

        /// <summary>
        /// Gets or sets the user's home directory path. The string can be <c>null</c>.
        /// </summary>
        public string HomeDirectory
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_home_dir;
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_home_dir;
                    default:
                        GetInfo(1);
                        return HomeDirectory;
                }
            }
            set { SetInfo(1006, new USER_INFO_1006 { usri1006_home_dir = value }); }
        }

        /// <summary>
        /// Gets or sets the comment associated with the user network account. The string <c>null</c>.
        /// </summary>
        public string Comment
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_comment;
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_comment;
                    default:
                        GetInfo(1);
                        return Comment;
                }
            }
            set { SetInfo(1007, new USER_INFO_1007 { usri1007_comment = value }); }
        }

        /// <summary>
        /// Gets or sets a set of bit flags defining several user network account parameters.
        /// </summary>
        public NetUserFlags Flags
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_flags.AsManaged();
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_flags.AsManaged();
                    default:
                        GetInfo(1);
                        return Flags;
                }
            }
            set { SetInfo(1008, new USER_INFO_1008 { usri1008_flags = value.AsNative() }); }
        }

        /// <summary>
        /// Gets or sets the path for a user's logon script file. The string can also be <c>null</c>.
        /// </summary>
        /// <remarks>
        /// The script file can be a .CMD file, an .EXE file, or a .BAT file. The string can also be <c>null</c>.
        /// </remarks>
        public string ScriptPath
        {
            get
            {
                switch (level)
                {
                    case 1:
                        if (usri1 == null) goto default;
                        return usri1.usri1_script_path;
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_script_path;
                    default:
                        GetInfo(1);
                        return ScriptPath;
                }
            }
            set { SetInfo(1009, new USER_INFO_1009 { usri1009_script_path = value }); }
        }

        /// <summary>
        /// Gets or sets the user's operator privileges.
        /// </summary>
        public NetUserOperatorPrivilege AuthFlags
        {
            get
            {
                switch (level)
                {
                    case 2:
                        if (usri2 == null) goto default;
                        return usri2.usri2_auth_flags.AsManaged();
                    default:
                        GetInfo(2);
                        return AuthFlags;
                }
            }
            set { SetInfo(1010, new USER_INFO_1010 { usri1010_auth_flags = value.AsNative() }); }
        }

        private void GetInfo(int level)
        {
            var netStatus = NetUserGetInfo(servername, username, level, out var netUserBuffer);
            switch (netStatus)
            {
                case NERR_Success: break;
                default:
                    throw new Win32Exception((int)netStatus);
            }

            using (netUserBuffer)
            {
                switch (level)
                {
                    case 0:
                        usri0 = netUserBuffer.AsLevel0Buffer().ReadValue();
                        this.level = level;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(level), level, "Unknown User Info level. The returned data from the system cannot be represented, because its format is unknown.");
                }
            }
        }

        private void SetInfo(int level, object usri)
        {
            var netStatus = NetUserSetInfo(servername, username, level, usri, out var parm_err);
            switch (netStatus)
            {
                case NERR_Success: break;
                default:
                    throw new Win32Exception((int)netStatus);
            }

            this.level = -1;
        }
    }
}
