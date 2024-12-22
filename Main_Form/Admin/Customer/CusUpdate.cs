using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Main_Form.Admin.Customer
{
    class CusUpdate
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);

        public bool Update_Customers(string newname, string oldname, string password, string ph_no, int balance)
        {
            try
            {
                _conn.Open();
                string query =
                    $"Update Token_Money set balance = {balance} where id = (Select id from Customers where name = '{oldname}');Update Customers set name ='{newname}' , password = '{password}', ph_no = '{ph_no}' where name = '{oldname}'; ";
                SqlCommand command = new SqlCommand(query, _conn);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    DialogResult result = MessageBox.Show("Data updated successfully,Click OK to reload the form",
                        "Success", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        _conn.Close();
                        return true;
                    }
                } 
                else
                {
                    MessageBox.Show("Updation Failed");
                    _conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"{0}", ex);
            }

            return true;
        }
    }
}
