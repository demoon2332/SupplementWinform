using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DAO
{
    public class GoodImportDAO
    {
        private static GoodImportDAO instance;

        public static GoodImportDAO Instance
        {
            get { if (instance == null) instance = new GoodImportDAO(); return GoodImportDAO.instance; }
            private set { GoodImportDAO.instance = value; }
        }

        private GoodImportDAO() { }


        public List<DetailReceipt> GetDetailImport(long id)
        {
            List<DetailReceipt> list = new List<DetailReceipt>();
            string query = "Exec GetFullDetailImport @id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                DetailReceipt i = new DetailReceipt(item, true);
                list.Add(i);
            }

            return list;

        }

        public long getIdOfLastestImport()
        {
            string query = "Exec GetLastestIDimport ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return (long)data.Rows[0]["id"];
        }

        public bool writeImport(long sid)
        {
            try
            {
                string query = "Exec writeImport @sid ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sid});
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool writeImportDetail(long bid,long pid,int quantity)
        {
            try
            {
                string query = "Exec writeImportDetail @bid , @pid , @quantity ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { bid, pid, quantity });
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }


    }
}
