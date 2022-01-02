
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = SupplementManagement.DTO.Type;

namespace SupplementManagement.DAO
{
    public class TypeDAO
    {
        private static TypeDAO instance;

        public static TypeDAO Instance
        {
            get { if (instance == null) instance = new TypeDAO(); return instance; }
            private set { instance = value; }

        }

        private TypeDAO() { }

        public List<Type> getAllTypesList()
        {
            List<Type> list = new List<Type>();
            string query = "Select * from Type ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Type i = new Type(item);
                list.Add(i);
            }
            return list;
        }
    }
}
