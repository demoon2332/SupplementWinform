using SupplementManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplementManagement.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetProductsByTypeId(int id)
        {
            List<Product> list = new List<Product>();

            string query = "Exec exec getProductsTypeId @id ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { id });

            foreach (DataRow Product in data.Rows)
            {
                Product i = new Product(Product);
                list.Add(i);
            }

            return list;
        }

        public Product GetProductById(long id)
        {

            string query = "Select * from Product where id=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Product Product = new Product(data.Rows[0]);

            return Product;
        }

        

        public List<Product> getAllItemsByType(byte id)
        {
            List<Product> list = new List<Product>();
            string query = "Select * from Product where type="+id.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product i = new Product(item);
                list.Add(i);
            }

            return list;
        }

        public void updateStorage(long id,int quantity)
        {
            // if quantity < 0 --> decrease and quantity > 0 --> increase
                string query = "Exec updateInventory @id , @quantity";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, quantity });           
        }


    }
}
