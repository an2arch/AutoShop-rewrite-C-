using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AutoShop.Models
{
    public class Account
    {
        [JsonConstructor]
        public Account(string Name, string Login, string Password, LevelAccess Access)
        {
            m_id = currentAccountId++;
            m_name = Name;
            m_login = Login;
            m_password = Password;
            m_levelAccess = Access;
        }

        public Account(uint id, string newName, string newLogin, string newPassword, LevelAccess access)
        {
            m_id = id;
            m_name = newName;
            m_login = newLogin;
            m_password = newPassword;
            m_levelAccess = access;
        }

        public class AccountList : BindingList<Account> { };

        public enum LevelAccess
        {
            Admin, Employee
        }

        public static uint currentAccountId = 0;

        private uint m_id;
        private string m_name;
        private string m_login;
        private string m_password;
        private LevelAccess m_levelAccess;

        [JsonIgnore]
        public uint Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public string Login
        {
            get { return m_login; }
            set { m_login = value; }
        }
        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        public LevelAccess Access
        {
            get { return m_levelAccess; }
            set { m_levelAccess = value; }
        }
    }
}
