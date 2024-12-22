using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Main_Form.Admin.Customer
{
    class GetAllCustomer
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public List<Models.Customer> GetAllCustomers()
        {
            List<Models.Customer> customerList = new List<Models.Customer>();
            try
            {
                _conn.Open();
                string query = "Select c.id,name,Password,Ph_no , Balance from Customers c, Token_Money m where c.id = m.id;";
                SqlCommand command = new SqlCommand(query, _conn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Models.Customer customer = new Models.Customer
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = reader.GetValue(1).ToString(),
                        Password =reader.GetValue(2).ToString(), 
                        Phno = reader.GetValue(3).ToString(),
                        Balance = Convert.ToInt32(reader.GetValue(4))
                    };

                    customerList.Add(customer);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _conn.Close();



            return customerList;
        }
    }
}
