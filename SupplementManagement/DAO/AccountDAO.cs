using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }

        }

        private AccountDAO() { }

        public bool Login(string username, string pass)
        {
            String query = "EXEC dbo.UserLogin @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, pass });

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec getAccountByUsername @username", new object[] { username });
            if(data.Rows.Count > 0)
            {
                Account acc = new Account(data.Rows[0]);
                return acc;
            }
            return null;
        }

        public bool updateAccount(string username,string disName,string phone,string birth)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("Exec updateAccount @username , @disName , @phone , @birth ", new object[] { username, disName, phone, birth});
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool resetPassword(string username,string newPass)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("Exec resetPassword @username , @newPass ", new object[] { username,newPass });
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
