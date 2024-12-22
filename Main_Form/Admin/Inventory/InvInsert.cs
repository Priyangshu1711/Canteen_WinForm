using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Main_Form.Admin.Inventory
{
    class InvInsert
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);

        public bool InsetIntoInventory(string fname , int rate ,int qty)
        {
            try
            {
                _conn.Open();
                string query = $"Insert into Inventory (Fname , Rate) Values('{fname}',{rate});Insert into stock(Fid,Qty) values ((select fid from Inventory where fname ='{fname}'), {qty});";
                
                SqlCommand command = new SqlCommand(query,_conn);
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
                Console.WriteLine(@"{0}",ex);
                _conn.Close();
                return false;
            }

            _conn.Close();
            return true;
        }
    }
}
