using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Main_Form.Admin.Inventory
{
    class InvUpdate
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public bool Update_Inventory(string newfname,string oldfname , int rate , int qty)
        {
            try
            {
                _conn.Open();
                string query = $"Update Stock set qty = {qty} where fid = (Select fid from Inventory where fname = '{oldfname}');Update Inventory set fname ='{newfname}' , Rate = {rate} where fname = '{oldfname}'; ";
                SqlCommand command = new SqlCommand(query, _conn);
                int  rowAffected = command.ExecuteNonQuery();
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
                Console.WriteLine(@"{0}",ex);
            }

            return true;
        }
    }
}
