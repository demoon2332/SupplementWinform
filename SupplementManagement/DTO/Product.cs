using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DTO
{
    public class Product
    {
        private long id;
        private byte type;
        private string name, unit;
        private int inventory;
        private float price;

        public Product(long id,byte type,string name,string unit,int inventory,float price)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;this.Unit = unit;
            this.Inventory = inventory;
            this.Price = price;
        }

        public Product(DataRow row)
        {
            this.ID = (long)row["id"];
            this.Type = (byte) row["type"];
            this.Name = row["name"].ToString();
            this.Unit = row["unit"].ToString();
            this.Inventory = (int)row["inventory"];
            this.Price = (float)Convert.ToDouble(row["price"]);
        }


        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        public byte Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

    }
}
