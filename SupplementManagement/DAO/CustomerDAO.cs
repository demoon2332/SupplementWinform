using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }

        }

        private CustomerDAO() { }

        public Customer getCustomerById(long id)
        {
            string query = "Select * from Customer where id=" + id.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Customer customer= new Customer(data.Rows[0]);
            return customer;

        }
    }
}
