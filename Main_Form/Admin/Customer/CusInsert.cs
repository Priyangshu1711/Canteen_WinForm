using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Main_Form.Admin.Customer
{
    class CusInsert
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public bool InsetIntoCustomers(string name, string password,string ph_no, int balance)
        {
            try
            {
                _conn.Open();
                string query = $"Insert into Customers (name , password,Ph_no) Values('{name}','{password}','{ph_no}');Insert into Token_Money(id,Balance) values ((select id from Customers where name ='{name}'), {balance});";

                SqlCommand command = new SqlCommand(query, _conn);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    DialogResult result = MessageBox.Show("Data inserted successfully,Click OK to reload the form",
                        "Success", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        _conn.Close();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                    _conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(@"{0}", ex);
                _conn.Close();
                return false;
            }

            _conn.Close();
            return true;
        }
    }
}
