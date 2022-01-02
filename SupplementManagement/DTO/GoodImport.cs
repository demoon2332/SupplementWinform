using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SupplementManagement.DTO
{
    public class GoodImport
    {
        long id, sid;
        string importDate;

        public GoodImport(long id,long sid,string date)
        {
            this.ID = id;
            this.SID = sid;
            this.ImportDate = date;
        }

        public GoodImport(DataRow row)
        {
            this.ID = (long)row["id"];
            this.SID = (long)row["sid"];
            this.ImportDate = row["importDate"].ToString();
        }

        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        public long SID
        {
            get { return sid; }
            set { sid = value; }
        }

        public string ImportDate
        {
            get { return importDate; }
            set { importDate = value; }
        }
    }
}
