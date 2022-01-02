using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DTO
{
    public class Account
    {
        private long id;
        private string displayname;
        private string username;
        private string phone;
        private int gender;
        private string birth;


        public Account(DataRow row)
        {
            this.Id = (long)row["id"];
            this.Username = row["username"].ToString();
            this.DisplayName = row["displayname"].ToString();
            this.Phone = row["phone"].ToString();
            this.Gender = (int)row["gender"];
            this.Birth = row["birth"].ToString();
        }

        public Account(long id, string displayName, string username, string phone, int gender, string birth)
        {
            this.Id = id;
            this.Username = username;
            this.DisplayName = displayName;
            this.Phone = phone;
            this.Gender = gender;
            this.Birth = birth;
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string DisplayName
        {
            get { return displayname; }
            set { displayname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }


    }

  
}
