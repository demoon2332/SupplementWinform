using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SupplementManagement.DTO
{
    public class GoodExport
    {
        private string paymentType,statusDelivery, exportDate;
        private long id, cid, sid;
        private bool statusPayment;
        public GoodExport(long id,long cid,long sid,bool statusPayment,string statusDelivery,string exportDate,string paymentType)
        {
            this.ID = id; this.CID = cid; this.SID = sid;this.StatusPayment = statusPayment;this.paymentType = paymentType;
            this.StatusDelivery = statusDelivery; this.ExportDate = exportDate;
        }

        public GoodExport(DataRow row)
        {
            this.ID = (long)row["id"];
            this.CID = (long)row["cid"];
            this.SID = (long)row["sid"];
            this.StatusPayment = (bool)row["statusPayment"];
            this.StatusDelivery = row["statusDelivery"].ToString();
            this.ExportDate = row["exportDate"].ToString();
            this.PaymentType = row["paymentType"].ToString();
        }

        

        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        public long CID
        {
            get { return cid; }
            set { cid = value; }
        }

        public long SID
        {
            get { return sid; }
            set { sid = value; }
        }

        public bool StatusPayment
        {
            get { return statusPayment; }
            set { statusPayment = value; }
        }

        public string StatusDelivery
        {
            get { return statusDelivery; }
            set { statusDelivery = value; }
        }

        public string ExportDate
        {
            get { return exportDate; }
            set { exportDate = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

    }
}
