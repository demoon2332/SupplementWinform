using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DAO
{
    public class GoodExportDAO
    {
        private static GoodExportDAO instance;

        public static GoodExportDAO Instance
        {
            get { if (instance == null) instance = new GoodExportDAO(); return instance; }
            private set { instance = value; }

        }

        private GoodExportDAO() { }

        public List<DetailReceipt> GetDetailExport(long id)
        {
            List<DetailReceipt> list = new List<DetailReceipt>();
            string query = "Exec GetFullDetailExport @id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                DetailReceipt i = new DetailReceipt(item,true);
                list.Add(i);
            }

            return list;

        }

        public List<GoodExport> getWaitingOrders()
        {
            List<GoodExport> list = new List<GoodExport>();
            string query = "Select * from GoodExport where statusDelivery='Waiting'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GoodExport i = new GoodExport(item);
                list.Add(i);
            }

            return list;
        }

        public List<GoodExport> getShippingOrders()
        {
            List<GoodExport> list = new List<GoodExport>();
            string query = "Select * from GoodExport where statusDelivery='Shipping'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GoodExport i = new GoodExport(item);
                list.Add(i);
            }

            return list;
        }


        public long getIdOfLastestExport()
        {
            string query = "Exec GetLastestIDExport ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return (long)data.Rows[0]["id"];
        }

        public bool writeExport(long cid,long sid,string paymentType,bool statusPayment,string statusDelivery)
        {
            try
            {
                string query = "Exec writeExport @cid , @sid , @paymentType , @statusPayment ,  @statusDelivery ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cid, sid, paymentType, statusPayment, statusDelivery});
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool writeExportDetail(long bid,long pid,int quantity)
        {
            try
            {
                string query = "Exec writeExportDetail @bid , @pid , @quantity ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {bid,pid,quantity});
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void confirmExport(string username,long id)
        {
            Account staff = AccountDAO.Instance.GetAccountByUsername(username);
            string query = "Exec confirmExport @id , @sid ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , staff.Id });
        }

        public void cancelExport(string username,long id)
        {
            Account staff = AccountDAO.Instance.GetAccountByUsername(username);
            string query = "Exec cancelExport @id , @sid ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , staff.Id });
        }

        public void doneExport(string username,long id)
        {
            Account staff = AccountDAO.Instance.GetAccountByUsername(username);
            string query = "Exec doneExport @id , @sid ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , staff.Id });
        }
    }
}
