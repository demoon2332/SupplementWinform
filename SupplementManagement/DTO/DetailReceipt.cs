using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DTO
{
    public class DetailReceipt
    {
        private long bid, pid;
        private string name, unit;
        private int quantity,type,inventory;
        private float price, intoMoney;

        public DetailReceipt(long bid,long pid,string name,string unit,int quantity,int type,int inventory,float price,float intoMoney)
        {
            this.Bid = bid; this.Pid = pid;
            this.Name = name;this.Unit = unit;
            this.Quantity = quantity;this.Type = type;this.Inventory = inventory;
            this.Price = price;this.IntoMoney = intoMoney;
        }

        public DetailReceipt(long bid,long pid,int quantity)
        {
            this.Bid = bid; this.Pid = pid;
            this.Name = ""; this.Unit = "";
            this.Quantity = quantity; this.Type = 0; this.Inventory = 0;
            this.Price = 0; this.IntoMoney = 0;
        }

        public DetailReceipt(DataRow row,bool full)
        {
            if (full)
            {
                this.Bid = (long)row["bid"]; this.Pid = (long)row["pid"];
                this.Name = row["name"].ToString(); this.Unit = row["unit"].ToString();
                
                // because type in SQL is TinyInt --> use byte to cast
                this.Type = (byte)row["type"];
                this.Inventory = (int)row["inventory"];
                this.Quantity = (int)row["quantity"];
                this.Price = (float)Convert.ToDouble(row["price"]);
                this.IntoMoney = (float)Convert.ToDouble(row["intoMoney"]);
            }
            else
            {
                this.Bid = (long)row["bid"]; this.Pid = (long)row["pid"];
                this.Quantity = (int)row["quantity"];
                this.Name = ""; this.Unit = "";
                this.Type = 0; this.Inventory = 0;
                this.Price = 0; this.IntoMoney = 0;
            }
        }

        public long Bid
        {
            get { return bid; }
            set { bid = value; }
        }

        public long Pid
        {
            get { return pid; }
            set { pid = value; }
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

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float IntoMoney
        {
            get { return intoMoney; }
            set { intoMoney = value; }
        }




    }
}
