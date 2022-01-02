using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DTO
{
    public class Customer
    {
        private long id;
        private string name,address,phone;


        public Customer(long id,string name,string address,string phone)
        {
            this.ID = id;
            this.Name = name;this.Address = address;this.Phone = phone;
        }

        public Customer(DataRow row)
        {
            this.ID = (long)row["id"];
            this.Name = row["fullName"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
        }


        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
