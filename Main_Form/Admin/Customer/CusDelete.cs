﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Main_Form.Admin.Customer
{
    class CusDelete
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public bool DeleteFromCustomers(string name)
        {
            try
            {
                _conn.Open();
                string query = $"Delete from Token_Money where id =(Select id from Customers where name = '{name}');Delete from Customers where name = '{name}';";
                SqlCommand command = new SqlCommand(query, _conn);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    DialogResult result = MessageBox.Show("Data deletion successfully,Click OK to reload the form",
                        "Success", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        _conn.Close();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Deletion Failed");
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

            return true;
        }
    }
}