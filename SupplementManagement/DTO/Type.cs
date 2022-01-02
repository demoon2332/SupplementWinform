using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DTO
{
    public class Type
    {
        private byte id;
        private string name;

        public Type(byte id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Type(DataRow row)
        {
            this.ID = (byte)row["id"];
            this.Name = row["name"].ToString();
        }


        public byte ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
