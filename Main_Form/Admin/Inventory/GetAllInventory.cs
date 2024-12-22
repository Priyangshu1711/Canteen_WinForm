using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Main_Form.Admin.Inventory
{
    class GetAllInventory
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public List<Models.Inventory> GetAllInventories()
        {
            List<Models.Inventory> inventoryList = new List<Models.Inventory>();
            try
            {
                _conn.Open();
                string query = "Select i.Fid,Fname,Rate, Qty from inventory i, stock s where i.Fid = s.FId; ";
                SqlCommand command = new SqlCommand(query, _conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Models.Inventory inventory = new Models.Inventory
                    {
                        Fid = Convert.ToInt32(reader.GetValue(0)),
                        Fname = reader.GetValue(1).ToString(),
                        Rate = Convert.ToInt32(reader.GetValue(2)),
                        Qty = Convert.ToInt32(reader.GetValue(3))
                    };

                    inventoryList.Add(inventory);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _conn.Close();



            return inventoryList;
        }
    }
}



